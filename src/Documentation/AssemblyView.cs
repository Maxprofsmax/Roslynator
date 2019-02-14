// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    //TODO: AssemblyView?
    internal class AssemblyView
    {
        internal AssemblyView(
            IEnumerable<IAssemblySymbol> assemblies,
            VisibilityFilter visibilityFilter = VisibilityFilter.All,
            SymbolGroups symbolGroups = SymbolGroups.NamespaceOrTypeOrMember,
            IEnumerable<MetadataName> ignoredNames = null,
            IEnumerable<MetadataName> ignoredAttributeNames = null)
        {
            Assemblies = assemblies.ToImmutableArray();
            VisibilityFilter = visibilityFilter;
            SymbolGroups = symbolGroups;
            IgnoredNames = ignoredNames?.ToImmutableArray() ?? ImmutableArray<MetadataName>.Empty;
            IgnoredAttributeNames = ignoredAttributeNames?.ToImmutableArray() ?? ImmutableArray<MetadataName>.Empty;
        }

        public ImmutableArray<IAssemblySymbol> Assemblies { get; }

        public VisibilityFilter VisibilityFilter { get; }

        public SymbolGroups SymbolGroups { get; }

        public ImmutableArray<MetadataName> IgnoredNames { get; }

        public ImmutableArray<MetadataName> IgnoredAttributeNames { get; }

        public bool IncludesGroups(SymbolGroups symbolGroups)
        {
            return (SymbolGroups & symbolGroups) == symbolGroups;
        }

        public IEnumerable<INamedTypeSymbol> GetTypes()
        {
            return GetTypes(f => IsVisibleType(f));
        }

        public IEnumerable<INamedTypeSymbol> GetTypes(INamedTypeSymbol typeSymbol)
        {
            return typeSymbol.GetTypeMembers().Where(f => IsVisibleType(f));
        }

        public IEnumerable<INamedTypeSymbol> GetNonNestedTypes()
        {
            return GetTypes(f => f.ContainingType == null && IsVisibleType(f));
        }

        private IEnumerable<INamedTypeSymbol> GetTypes(Func<INamedTypeSymbol, bool> predicate)
        {
            foreach (IAssemblySymbol assembly in Assemblies)
            {
                foreach (INamedTypeSymbol typeSymbol in assembly.GetTypes(predicate))
                    yield return typeSymbol;
            }
        }

        public IEnumerable<ISymbol> GetMembers()
        {
            foreach (INamedTypeSymbol typeSymbol in GetTypes())
            {
                foreach (ISymbol member in GetMembers(typeSymbol))
                    yield return member;
            }
        }

        public IEnumerable<ISymbol> GetMembers(INamedTypeSymbol typeSymbol)
        {
            switch (typeSymbol.TypeKind)
            {
                case TypeKind.Class:
                case TypeKind.Struct:
                case TypeKind.Interface:
                    {
                        foreach (ISymbol member in typeSymbol.GetMembers())
                        {
                            if (IsVisibleMember(member))
                                yield return member;
                        }

                        break;
                    }
            }
        }

        public IEnumerable<INamedTypeSymbol> GetDerivedTypes(INamedTypeSymbol typeSymbol)
        {
            if (typeSymbol.TypeKind.Is(TypeKind.Class, TypeKind.Interface)
                && !typeSymbol.IsStatic)
            {
                foreach (INamedTypeSymbol symbol in GetTypes())
                {
                    if (symbol.BaseType?.OriginalDefinition.Equals(typeSymbol) == true)
                        yield return symbol;

                    foreach (INamedTypeSymbol interfaceSymbol in symbol.Interfaces)
                    {
                        if (interfaceSymbol.OriginalDefinition.Equals(typeSymbol))
                            yield return symbol;
                    }
                }
            }
        }

        public IEnumerable<INamedTypeSymbol> GetAllDerivedTypes(INamedTypeSymbol typeSymbol)
        {
            if (typeSymbol.TypeKind.Is(TypeKind.Class, TypeKind.Interface)
                && !typeSymbol.IsStatic)
            {
                foreach (INamedTypeSymbol symbol in GetTypes())
                {
                    if (symbol.InheritsFrom(typeSymbol, includeInterfaces: true))
                        yield return symbol;
                }
            }
        }

        public IEnumerable<IMethodSymbol> GetExtensionMethods()
        {
            foreach (INamedTypeSymbol typeSymbol in GetTypes())
            {
                if (typeSymbol.MightContainExtensionMethods)
                {
                    foreach (ISymbol member in typeSymbol.GetMembers().Where(f => IsVisibleMember(f)))
                    {
                        if (member.Kind == SymbolKind.Method
                            && member.IsStatic
                            && IsVisibleMember(member))
                        {
                            var methodSymbol = (IMethodSymbol)member;

                            if (methodSymbol.IsExtensionMethod)
                                yield return methodSymbol;
                        }
                    }
                }
            }
        }

        public IEnumerable<IMethodSymbol> GetExtensionMethods(INamedTypeSymbol typeSymbol)
        {
            foreach (INamedTypeSymbol symbol in GetTypes())
            {
                if (symbol.MightContainExtensionMethods)
                {
                    foreach (ISymbol member in symbol.GetMembers().Where(f => IsVisibleMember(f)))
                    {
                        if (member.Kind == SymbolKind.Method
                            && member.IsStatic
                            && IsVisibleMember(member))
                        {
                            var methodSymbol = (IMethodSymbol)member;

                            if (methodSymbol.IsExtensionMethod)
                            {
                                ITypeSymbol typeSymbol2 = GetExtendedType(methodSymbol);

                                if (typeSymbol == typeSymbol2)
                                    yield return methodSymbol;
                            }
                        }
                    }
                }
            }
        }

        public IEnumerable<INamedTypeSymbol> GetExtendedExternalTypes()
        {
            return Iterator().Distinct();

            IEnumerable<INamedTypeSymbol> Iterator()
            {
                foreach (IMethodSymbol methodSymbol in GetExtensionMethods())
                {
                    INamedTypeSymbol typeSymbol = GetExternalSymbol(methodSymbol);

                    if (typeSymbol != null)
                        yield return typeSymbol;
                }
            }

            INamedTypeSymbol GetExternalSymbol(IMethodSymbol methodSymbol)
            {
                INamedTypeSymbol type = GetExtendedType(methodSymbol);

                if (type == null)
                    return null;

                foreach (IAssemblySymbol assembly in Assemblies)
                {
                    if (type.ContainingAssembly == assembly)
                        return null;
                }

                return type;
            }
        }

        private static INamedTypeSymbol GetExtendedType(IMethodSymbol methodSymbol)
        {
            ITypeSymbol type = methodSymbol.Parameters[0].Type.OriginalDefinition;

            switch (type.Kind)
            {
                case SymbolKind.NamedType:
                    return (INamedTypeSymbol)type;
                case SymbolKind.TypeParameter:
                    return GetTypeParameterConstraintClass((ITypeParameterSymbol)type);
            }

            return null;

            INamedTypeSymbol GetTypeParameterConstraintClass(ITypeParameterSymbol typeParameter)
            {
                foreach (ITypeSymbol constraintType in typeParameter.ConstraintTypes)
                {
                    if (constraintType.TypeKind == TypeKind.Class)
                    {
                        return (INamedTypeSymbol)constraintType;
                    }
                    else if (constraintType.TypeKind == TypeKind.TypeParameter)
                    {
                        return GetTypeParameterConstraintClass((ITypeParameterSymbol)constraintType);
                    }
                }

                return null;
            }
        }

        public bool IsExternal(ISymbol symbol)
        {
            foreach (IAssemblySymbol assembly in Assemblies)
            {
                if (symbol.ContainingAssembly == assembly)
                    return false;
            }

            return true;
        }

        private bool IsVisible(ISymbol symbol)
        {
            return symbol.IsVisible(VisibilityFilter);
        }

        public virtual bool IsVisibleNamespace(INamespaceSymbol namespaceSymbol)
        {
            return IncludesGroups(SymbolGroups.Namespace)
                && !IsIgnorableNamespace(namespaceSymbol);
        }

        public virtual bool IsVisibleType(INamedTypeSymbol typeSymbol)
        {
            return !typeSymbol.IsImplicitlyDeclared
                && IncludesGroups(typeSymbol.TypeKind.ToSymbolGroups())
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
                        if (!IncludesGroups(SymbolGroups.Event))
                            return false;

                        break;
                    }
                case SymbolKind.Field:
                    {
                        var fieldSymbol = (IFieldSymbol)symbol;

                        if (fieldSymbol.IsConst)
                        {
                            if (!IncludesGroups(SymbolGroups.Const))
                            {
                                return false;
                            }
                            else if (!IncludesGroups(SymbolGroups.Field))
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
                            if (!IncludesGroups(SymbolGroups.Indexer))
                            {
                                return false;
                            }
                            else if (!IncludesGroups(SymbolGroups.Property))
                            {
                                return false;
                            }
                        }

                        break;
                    }
                case SymbolKind.Method:
                    {
                        if (!IncludesGroups(SymbolGroups.Method))
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
