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

        private static readonly MetadataNameSet _nonVisibleAttributes = new MetadataNameSet(new string[]
        {
            "System.Diagnostics.CodeAnalysis.SuppressMessageAttribute",
            "System.Diagnostics.ConditionalAttribute",
            "System.Diagnostics.DebuggableAttribute",
            "System.Diagnostics.DebuggerBrowsableAttribute",
            "System.Diagnostics.DebuggerDisplayAttribute",
            "System.Diagnostics.DebuggerHiddenAttribute",
            "System.Diagnostics.DebuggerNonUserCodeAttribute",
            "System.Diagnostics.DebuggerStepperBoundaryAttribute",
            "System.Diagnostics.DebuggerStepThroughAttribute",
            "System.Diagnostics.DebuggerTypeProxyAttribute",
            "System.Diagnostics.DebuggerVisualizerAttribute",
            "System.Reflection.DefaultMemberAttribute",
            "System.Reflection.AssemblyConfigurationAttribute",
            "System.Reflection.AssemblyCultureAttribute",
            "System.Reflection.AssemblyVersionAttribute",
            "System.Runtime.CompilerServices.AsyncStateMachineAttribute",
            "System.Runtime.CompilerServices.CompilationRelaxationsAttribute",
            "System.Runtime.CompilerServices.CompilerGeneratedAttribute",
            "System.Runtime.CompilerServices.IsReadOnlyAttribute",
            "System.Runtime.CompilerServices.InternalsVisibleToAttribute",
            "System.Runtime.CompilerServices.IteratorStateMachineAttribute",
            "System.Runtime.CompilerServices.MethodImplAttribute",
            "System.Runtime.CompilerServices.RuntimeCompatibilityAttribute",
            "System.Runtime.CompilerServices.StateMachineAttribute",
            "System.Runtime.CompilerServices.TupleElementNamesAttribute",
            "System.Runtime.CompilerServices.TypeForwardedFromAttribute",
            "System.Runtime.CompilerServices.TypeForwardedToAttribute"
        });

#if DEBUG
        private static readonly MetadataNameSet _knownVisibleAttributes = new MetadataNameSet(new string[]
        {
            "System.AttributeUsageAttribute",
            "System.CLSCompliantAttribute",
            "System.ComVisibleAttribute",
            "System.FlagsAttribute",
            "System.ObsoleteAttribute",
            "System.ComponentModel.DefaultValueAttribute",
            "System.ComponentModel.EditorBrowsableAttribute",
            "System.Composition.MetadataAttributeAttribute",
            "System.Reflection.AssemblyCompanyAttribute",
            "System.Reflection.AssemblyCopyrightAttribute",
            "System.Reflection.AssemblyDescriptionAttribute",
            "System.Reflection.AssemblyFileVersionAttribute",
            "System.Reflection.AssemblyInformationalVersionAttribute",
            "System.Reflection.AssemblyProductAttribute",
            "System.Reflection.AssemblyTitleAttribute",
            "System.Reflection.AssemblyTrademarkAttribute",
            "System.Runtime.CompilerServices.InternalImplementationOnlyAttribute",
            "System.Runtime.InteropServices.GuidAttribute",
            "System.Runtime.Versioning.TargetFrameworkAttribute",
            "System.Xml.Serialization.XmlArrayItemAttribute",
            "System.Xml.Serialization.XmlAttributeAttribute",
            "System.Xml.Serialization.XmlElementAttribute",
            "System.Xml.Serialization.XmlRootAttribute",
        });
#endif

        internal SymbolFilterOptions(
            VisibilityFilter visibilityFilter = VisibilityFilter.All,
            SymbolGroupFilter symbolGroupFilter = SymbolGroupFilter.NamespaceOrTypeOrMember,
            IEnumerable<MetadataName> ignoredNames = null,
            IEnumerable<MetadataName> ignoredAttributeNames = null)
        {
            VisibilityFilter = visibilityFilter;
            SymbolGroupFilter = symbolGroupFilter;
            IgnoredNames = ignoredNames?.ToImmutableArray() ?? ImmutableArray<MetadataName>.Empty;
            IgnoredAttributeNames = ignoredAttributeNames?.ToImmutableArray() ?? ImmutableArray<MetadataName>.Empty;
        }

        public VisibilityFilter VisibilityFilter { get; }

        public SymbolGroupFilter SymbolGroupFilter { get; }

        public ImmutableArray<MetadataName> IgnoredNames { get; }

        public ImmutableArray<MetadataName> IgnoredAttributeNames { get; }

        public bool IncludesSymbolGroup(SymbolGroupFilter symbolGroupFilter)
        {
            return (SymbolGroupFilter & symbolGroupFilter) == symbolGroupFilter;
        }

        private bool IsVisible(ISymbol symbol)
        {
            return symbol.IsVisible(VisibilityFilter);
        }

        public virtual bool IsVisibleNamespace(INamespaceSymbol namespaceSymbol)
        {
            return IncludesSymbolGroup(SymbolGroupFilter.Namespace)
                && !IsIgnorableNamespace(namespaceSymbol);
        }

        public virtual bool IsVisibleType(INamedTypeSymbol typeSymbol)
        {
            return !typeSymbol.IsImplicitlyDeclared
                && IncludesSymbolGroup(typeSymbol.TypeKind.ToSymbolGroupFilter())
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
                        if (!IncludesSymbolGroup(SymbolGroupFilter.Event))
                            return false;

                        break;
                    }
                case SymbolKind.Field:
                    {
                        var fieldSymbol = (IFieldSymbol)symbol;

                        if (fieldSymbol.IsConst)
                        {
                            if (!IncludesSymbolGroup(SymbolGroupFilter.Const))
                            {
                                return false;
                            }
                            else if (!IncludesSymbolGroup(SymbolGroupFilter.Field))
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
                            if (!IncludesSymbolGroup(SymbolGroupFilter.Indexer))
                            {
                                return false;
                            }
                            else if (!IncludesSymbolGroup(SymbolGroupFilter.Property))
                            {
                                return false;
                            }
                        }

                        break;
                    }
                case SymbolKind.Method:
                    {
                        if (!IncludesSymbolGroup(SymbolGroupFilter.Method))
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
            if (_nonVisibleAttributes.Contains(attributeType))
                return false;
#if DEBUG
            switch (attributeType.MetadataName)
            {
                case "FooAttribute":
                case "BarAttribute":
                    return true;
            }

            if (_knownVisibleAttributes.Contains(attributeType))
                return true;

            Debug.Fail(attributeType.ToDisplayString());
#endif
            return true;
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
