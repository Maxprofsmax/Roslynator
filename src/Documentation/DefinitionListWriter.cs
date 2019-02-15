// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    internal abstract class DefinitionListWriter
    {
        protected DefinitionListWriter(
            SymbolFilterOptions filter = null,
            DefinitionListFormat format = null,
            IComparer<ISymbol> comparer = null)
        {
            Filter = filter ?? SymbolFilterOptions.Default;
            Format = format ?? DefinitionListFormat.Default;
            Comparer = comparer ?? SymbolDefinitionComparer.Instance;
        }

        public SymbolFilterOptions Filter { get; }

        public DefinitionListFormat Format { get; }

        public IComparer<ISymbol> Comparer { get; }

        public virtual bool SupportsMultilineDefinitions => true;

        public abstract void WriteStartDocument();

        public abstract void WriteEndDocument();

        public abstract void WriteStartAssemblies();

        public abstract void WriteEndAssemblies();

        public abstract void WriteStartAssembly(IAssemblySymbol assemblySymbol);

        public abstract void WriteEndAssembly(IAssemblySymbol assemblySymbol);

        public abstract void WriteAssemblySeparator();

        public abstract void WriteStartNamespaces();

        public abstract void WriteEndNamespaces();

        public abstract void WriteStartNamespace(INamespaceSymbol namespaceSymbol);

        public abstract void WriteEndNamespace(INamespaceSymbol namespaceSymbol);

        public abstract void WriteNamespaceSeparator();

        public abstract void WriteStartTypes();

        public abstract void WriteEndTypes();

        public abstract void WriteStartType(INamedTypeSymbol typeSymbol);

        public abstract void WriteEndType(INamedTypeSymbol typeSymbol);

        public abstract void WriteTypeSeparator();

        public abstract void WriteStartMembers();

        public abstract void WriteEndMembers();

        public abstract void WriteStartMember(ISymbol symbol);

        public abstract void WriteEndMember(ISymbol symbol);

        public abstract void WriteMemberSeparator();

        public abstract void WriteStartEnumMembers();

        public abstract void WriteEndEnumMembers();

        public abstract void WriteStartEnumMember(ISymbol symbol);

        public abstract void WriteEndEnumMember(ISymbol symbol);

        public abstract void WriteEnumMemberSeparator();

        public abstract void WriteStartAttributes(bool assemblyAttribute);

        public abstract void WriteEndAttributes(bool assemblyAttribute);

        public abstract void WriteStartAttribute(AttributeData attribute, bool assemblyAttribute);

        public abstract void WriteEndAttribute(AttributeData attribute, bool assemblyAttribute);

        public abstract void WriteAttributeSeparator(bool assemblyAttribute);

        public void WriteDocument(IEnumerable<IAssemblySymbol> assemblies)
        {
            WriteStartDocument();
            WriteAssemblies(assemblies);
            WriteEndDocument();
        }

        public void WriteAssemblies(IEnumerable<IAssemblySymbol> assemblies)
        {
            WriteStartAssemblies();

            using (IEnumerator<IAssemblySymbol> en = assemblies
                .OrderBy(f => f.Name)
                .ThenBy(f => f.Identity.Version)
                .GetEnumerator())
            {
                if (en.MoveNext())
                {
                    while (true)
                    {
                        IAssemblySymbol assembly = en.Current;

                        WriteStartAssembly(assembly);

                        if (Format.AssemblyAttributes)
                            WriteAttributes(assembly);

                        WriteEndAssembly(assembly);

                        if (en.MoveNext())
                        {
                            WriteAssemblySeparator();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            WriteEndAssemblies();

            IEnumerable<IGrouping<INamespaceSymbol, INamedTypeSymbol>> typesByNamespace = assemblies
                .SelectMany(a => a.GetTypes(t => t.ContainingType == null && Filter.IsVisibleType(t)))
                .GroupBy(t => t.ContainingNamespace, MetadataNameEqualityComparer<INamespaceSymbol>.Instance)
                .Where(g => Filter.IsVisibleNamespace(g.Key))
                .OrderBy(g => g.Key, Comparer);

            WriteStartNamespaces();

            if (Format.NestNamespaces)
            {
                WriteNamespacesWithHierarchy(typesByNamespace.ToDictionary(f => f.Key, f => f.AsEnumerable()));
            }
            else
            {
                WriteNamespaces(typesByNamespace);
            }

            WriteEndNamespaces();
        }

        private void WriteNamespaces(IEnumerable<IGrouping<INamespaceSymbol, INamedTypeSymbol>> typesByNamespace)
        {
            using (IEnumerator<IGrouping<INamespaceSymbol, INamedTypeSymbol>> en = typesByNamespace.GetEnumerator())
            {
                if (en.MoveNext())
                {
                    while (true)
                    {
                        INamespaceSymbol namespaceSymbol = en.Current.Key;

                        WriteStartNamespace(namespaceSymbol);

                        if ((Filter.SymbolGroupFilter & SymbolGroupFilter.Type) != 0)
                            WriteTypes(en.Current);

                        WriteEndNamespace(namespaceSymbol);

                        if (en.MoveNext())
                        {
                            WriteNamespaceSeparator();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void WriteNamespacesWithHierarchy(Dictionary<INamespaceSymbol, IEnumerable<INamedTypeSymbol>> typesByNamespace)
        {
            var rootNamespaces = new HashSet<INamespaceSymbol>(MetadataNameEqualityComparer<INamespaceSymbol>.Instance);

            var nestedNamespaces = new HashSet<INamespaceSymbol>(MetadataNameEqualityComparer<INamespaceSymbol>.Instance);

            foreach (INamespaceSymbol namespaceSymbol in typesByNamespace.Select(f => f.Key))
            {
                if (namespaceSymbol.IsGlobalNamespace)
                {
                    rootNamespaces.Add(namespaceSymbol);
                }
                else
                {
                    INamespaceSymbol n = namespaceSymbol;

                    while (true)
                    {
                        INamespaceSymbol containingNamespace = n.ContainingNamespace;

                        if (containingNamespace.IsGlobalNamespace)
                        {
                            rootNamespaces.Add(n);
                            break;
                        }

                        nestedNamespaces.Add(n);

                        n = containingNamespace;
                    }
                }
            }

            using (IEnumerator<INamespaceSymbol> en = rootNamespaces
                .OrderBy(f => f, Comparer)
                .GetEnumerator())
            {
                if (en.MoveNext())
                {
                    while (true)
                    {
                        WriteNamespace(en.Current);

                        if (en.MoveNext())
                        {
                            WriteNamespaceSeparator();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            void WriteNamespace(INamespaceSymbol namespaceSymbol)
            {
                WriteStartNamespace(namespaceSymbol);

                if ((Filter.SymbolGroupFilter & SymbolGroupFilter.Type) != 0)
                    WriteTypes(typesByNamespace[namespaceSymbol]);

                using (List<INamespaceSymbol>.Enumerator en = nestedNamespaces
                    .Where(f => MetadataNameEqualityComparer<INamespaceSymbol>.Instance.Equals(f.ContainingNamespace, namespaceSymbol))
                    .Distinct(MetadataNameEqualityComparer<INamespaceSymbol>.Instance)
                    .OrderBy(f => f, Comparer)
                    .ToList()
                    .GetEnumerator())
                {
                    if (en.MoveNext())
                    {
                        while (true)
                        {
                            nestedNamespaces.Remove(en.Current);

                            WriteNamespace(en.Current);

                            if (en.MoveNext())
                            {
                                WriteNamespaceSeparator();
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }

                WriteEndNamespace(namespaceSymbol);
            }
        }

        private void WriteTypes(IEnumerable<INamedTypeSymbol> types)
        {
            using (IEnumerator<INamedTypeSymbol> en = types
                .OrderBy(f => f, Comparer)
                .GetEnumerator())
            {
                if (en.MoveNext())
                {
                    WriteStartTypes();

                    while (true)
                    {
                        INamedTypeSymbol namedType = en.Current;

                        WriteStartType(namedType);

                        switch (namedType.TypeKind)
                        {
                            case TypeKind.Class:
                            case TypeKind.Interface:
                            case TypeKind.Struct:
                                {
                                    WriteMembers(namedType);
                                    break;
                                }
                            case TypeKind.Enum:
                                {
                                    WriteEnumMembers(namedType);
                                    break;
                                }
                            default:
                                {
                                    Debug.Assert(namedType.TypeKind == TypeKind.Delegate, namedType.TypeKind.ToString());
                                    break;
                                }
                        }

                        WriteEndType(namedType);

                        if (en.MoveNext())
                        {
                            WriteTypeSeparator();
                        }
                        else
                        {
                            break;
                        }
                    }

                    WriteEndTypes();
                }
            }
        }

        private void WriteMembers(INamedTypeSymbol namedType)
        {
            if ((Filter.SymbolGroupFilter & SymbolGroupFilter.Member) != 0)
            {
                using (IEnumerator<ISymbol> en = namedType
                    .GetMembers()
                    .Where(f => Filter.IsVisibleMember(f))
                    .OrderBy(f => f, Comparer)
                    .GetEnumerator())
                {
                    if (en.MoveNext())
                    {
                        WriteStartMembers();

                        MemberDeclarationKind kind = en.Current.GetMemberDeclarationKind();

                        while (true)
                        {
                            WriteStartMember(en.Current);
                            WriteEndMember(en.Current);

                            if (en.MoveNext())
                            {
                                MemberDeclarationKind nextKind = en.Current.GetMemberDeclarationKind();

                                if (kind != nextKind
                                    || Format.EmptyLineBetweenMembers)
                                {
                                    WriteMemberSeparator();
                                }

                                kind = nextKind;
                            }
                            else
                            {
                                break;
                            }
                        }

                        WriteEndMembers();
                    }
                }
            }

            if ((Filter.SymbolGroupFilter & SymbolGroupFilter.Type) != 0)
                WriteTypes(namedType.GetTypeMembers().Where(f => Filter.IsVisibleType(f)));
        }

        private void WriteEnumMembers(INamedTypeSymbol enumType)
        {
            if ((Filter.SymbolGroupFilter & SymbolGroupFilter.Member) == 0)
                return;

            using (IEnumerator<ISymbol> en = enumType
                .GetMembers()
                .Where(m => m.Kind == SymbolKind.Field
                    && m.DeclaredAccessibility == Accessibility.Public)
                .GetEnumerator())
            {
                if (en.MoveNext())
                {
                    WriteStartEnumMembers();

                    while (true)
                    {
                        WriteStartEnumMember(en.Current);
                        WriteEndEnumMember(en.Current);

                        if (en.MoveNext())
                        {
                            WriteEnumMemberSeparator();
                        }
                        else
                        {
                            break;
                        }
                    }

                    WriteEndEnumMembers();
                }
            }
        }

        public void WriteAttributes(ISymbol symbol)
        {
            using (IEnumerator<AttributeData> en = symbol
                .GetAttributes()
                .Where(f => Filter.IsVisibleAttribute(f.AttributeClass))
                .OrderBy(f => f.AttributeClass, Comparer).GetEnumerator())
            {
                if (en.MoveNext())
                {
                    bool assemblyAttribute = symbol.Kind == SymbolKind.Assembly;

                    WriteStartAttributes(assemblyAttribute);

                    while (true)
                    {
                        WriteStartAttribute(en.Current, assemblyAttribute);

                        ImmutableArray<SymbolDisplayPart> parts = SymbolDefinitionDisplay.GetAttributeParts(
                            attribute: en.Current,
                            omitContainingNamespace: Format.OmitContainingNamespace,
                            includeAttributeArguments: Format.IncludeAttributeArguments);

                        Write(parts);

                        WriteEndAttribute(en.Current, assemblyAttribute);

                        if (en.MoveNext())
                        {
                            WriteAttributeSeparator(assemblyAttribute);
                        }
                        else
                        {
                            break;
                        }
                    }

                    WriteEndAttributes(assemblyAttribute);
                }
            }
        }

        public virtual void Write(ISymbol symbol, SymbolDisplayFormat format)
        {
            ImmutableArray<SymbolDisplayPart> parts = SymbolDefinitionDisplay.GetDisplayParts(
                symbol,
                format,
                SymbolDisplayTypeDeclarationOptions.IncludeAccessibility | SymbolDisplayTypeDeclarationOptions.IncludeModifiers,
                omitContainingNamespace: Format.OmitContainingNamespace,
                addAttributes: false,
                addParameterAttributes: true,
                addAccessorAttributes: true,
                shouldDisplayAttribute: Filter.IsVisibleAttribute,
                formatAttributes: Format.FormatAttributes && SupportsMultilineDefinitions,
                formatBaseList: Format.FormatBaseList && SupportsMultilineDefinitions,
                formatConstraints: Format.FormatConstraints && SupportsMultilineDefinitions,
                formatParameters: Format.FormatParameters && SupportsMultilineDefinitions,
                includeAttributeArguments: Format.IncludeAttributeArguments,
                omitIEnumerable: Format.OmitIEnumerable,
                useDefaultLiteral: Format.UseDefaultLiteral);

            Write(parts);
        }

        public virtual void Write(IEnumerable<SymbolDisplayPart> parts)
        {
            foreach (SymbolDisplayPart part in parts)
                Write(part);
        }

        public virtual void Write(SymbolDisplayPart part)
        {
            Write(part.ToString());
        }

        public abstract void Write(string value);

        public abstract void WriteLine();

        public virtual void WriteLine(string value)
        {
            Write(value);
            WriteLine();
        }
    }
}
