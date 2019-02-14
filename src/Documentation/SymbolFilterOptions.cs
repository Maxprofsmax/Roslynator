// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    internal class SymbolFilterOptions
    {
        public static SymbolFilterOptions Default { get; } = new SymbolFilterOptions();

        internal SymbolFilterOptions(
            VisibilityFilter visibilityFilter = VisibilityFilter.All,
            SymbolGroups symbolGroups = SymbolGroups.NamespaceOrTypeOrMember,
            IEnumerable<MetadataName> ignoredNames = null,
            IEnumerable<MetadataName> ignoredAttributeNames = null)
        {
            VisibilityFilter = visibilityFilter;
            SymbolGroups = symbolGroups;
            IgnoredNames = ignoredNames?.ToImmutableArray() ?? ImmutableArray<MetadataName>.Empty;
            IgnoredAttributeNames = ignoredAttributeNames?.ToImmutableArray() ?? ImmutableArray<MetadataName>.Empty;
        }

        public VisibilityFilter VisibilityFilter { get; }

        public SymbolGroups SymbolGroups { get; }

        public ImmutableArray<MetadataName> IgnoredNames { get; }

        public ImmutableArray<MetadataName> IgnoredAttributeNames { get; }

        public bool IncludesGroup(SymbolGroups symbolGroups)
        {
            return (SymbolGroups & symbolGroups) == symbolGroups;
        }

        private bool IsVisible(ISymbol symbol)
        {
            return symbol.IsVisible(VisibilityFilter);
        }

        public virtual bool IsVisibleNamespace(INamespaceSymbol namespaceSymbol)
        {
            return IncludesGroup(SymbolGroups.Namespace)
                && !IsIgnorableNamespace(namespaceSymbol);
        }

        public virtual bool IsVisibleType(INamedTypeSymbol typeSymbol)
        {
            return !typeSymbol.IsImplicitlyDeclared
                && IncludesGroup(typeSymbol.TypeKind.ToSymbolGroups())
                && IsVisible(typeSymbol)
                && !IsIgnorableType(typeSymbol);
        }

        public virtual bool IsVisibleMember(ISymbol symbol)
        {
            bool canBeImplicitlyDeclared = false;

            switch (symbol.Kind)
            {
                case SymbolKind.Event:
                    {
                        if (!IncludesGroup(SymbolGroups.Event))
                            return false;

                        break;
                    }
                case SymbolKind.Field:
                    {
                        var fieldSymbol = (IFieldSymbol)symbol;

                        if (fieldSymbol.IsConst)
                        {
                            if (!IncludesGroup(SymbolGroups.Const))
                            {
                                return false;
                            }
                            else if (!IncludesGroup(SymbolGroups.Field))
                            {
                                return false;
                            }
                        }

                        break;
                    }
                case SymbolKind.Property:
                    {
                        var propertySymbol = (IPropertySymbol)symbol;

                        if (propertySymbol.IsIndexer)
                        {
                            if (!IncludesGroup(SymbolGroups.Indexer))
                            {
                                return false;
                            }
                            else if (!IncludesGroup(SymbolGroups.Property))
                            {
                                return false;
                            }
                        }

                        break;
                    }
                case SymbolKind.Method:
                    {
                        if (!IncludesGroup(SymbolGroups.Method))
                            return false;

                        var methodSymbol = (IMethodSymbol)symbol;

                        switch (methodSymbol.MethodKind)
                        {
                            case MethodKind.Constructor:
                                {
                                    TypeKind typeKind = methodSymbol.ContainingType.TypeKind;

                                    Debug.Assert(typeKind == TypeKind.Class || typeKind == TypeKind.Struct, typeKind.ToString());

                                    if (typeKind == TypeKind.Class)
                                    {
                                        if (!methodSymbol.Parameters.Any())
                                            canBeImplicitlyDeclared = true;
                                    }
                                    else if (typeKind == TypeKind.Struct)
                                    {
                                        if (!methodSymbol.Parameters.Any())
                                            return false;
                                    }

                                    break;
                                }
                            case MethodKind.Conversion:
                            case MethodKind.UserDefinedOperator:
                            case MethodKind.Ordinary:
                                break;
                            case MethodKind.ExplicitInterfaceImplementation:
                            case MethodKind.StaticConstructor:
                            case MethodKind.Destructor:
                            case MethodKind.EventAdd:
                            case MethodKind.EventRaise:
                            case MethodKind.EventRemove:
                            case MethodKind.PropertyGet:
                            case MethodKind.PropertySet:
                                return false;
                            default:
                                {
                                    Debug.Fail(methodSymbol.MethodKind.ToString());
                                    return false;
                                }
                        }

                        break;
                    }
                default:
                    {
                        Debug.Assert(symbol.Kind == SymbolKind.NamedType, symbol.Kind.ToString());
                        return false;
                    }
            }

            return (canBeImplicitlyDeclared || !symbol.IsImplicitlyDeclared)
                && IsVisible(symbol)
                && !IsIgnorableMember(symbol);
        }

        public virtual bool IsVisibleAttribute(INamedTypeSymbol attributeType)
        {
            return AttributeDisplay.ShouldBeDisplayed(attributeType);
        }

        internal bool IsIgnorableNamespace(INamespaceSymbol namespaceSymbol)
        {
            foreach (MetadataName metadataName in IgnoredNames)
            {
                if (namespaceSymbol.HasMetadataName(metadataName))
                    return true;
            }

            return false;
        }

        internal bool IsIgnorableType(INamedTypeSymbol typeSymbol)
        {
            foreach (MetadataName metadataName in IgnoredNames)
            {
                if (typeSymbol.HasMetadataName(metadataName))
                    return true;
            }

            return HasIgnorableAttribute(typeSymbol);
        }

        internal bool IsIgnorableMember(ISymbol symbol)
        {
            Debug.Assert(symbol.IsKind(SymbolKind.Event, SymbolKind.Field, SymbolKind.Method, SymbolKind.Property), symbol.Kind.ToString());

            return HasIgnorableAttribute(symbol);
        }

        internal bool HasIgnorableAttribute(ISymbol symbol)
        {
            Debug.Assert(symbol.IsKind(SymbolKind.Event, SymbolKind.Field, SymbolKind.Method, SymbolKind.Property, SymbolKind.NamedType), symbol.Kind.ToString());

            if (IgnoredAttributeNames.Any())
            {
                foreach (AttributeData attribute in symbol.GetAttributes())
                {
                    foreach (MetadataName attributeName in IgnoredAttributeNames)
                    {
                        if (attribute.AttributeClass.HasMetadataName(attributeName))
                            return true;
                    }
                }
            }

            return false;
        }
    }
}
