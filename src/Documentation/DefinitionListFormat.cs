// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Roslynator.Documentation
{
    //TODO: order by: namespace, accessibility, typekind, memberkind, name. group by: assembly, namespace, hierarchy
    internal class DefinitionListFormat
    {
        public DefinitionListFormat(
            string indentChars = DefaultValues.IndentChars,
            bool nestNamespaces = DefaultValues.NestNamespaces,
            bool emptyLineBetweenMembers = DefaultValues.EmptyLineBetweenMembers,
            bool omitContainingNamespace = DefaultValues.OmitContainingNamespace,
            bool includeAttributes = DefaultValues.IncludeAttributes,
            bool includeAssemblyAttributes = DefaultValues.IncludeAssemblyAttributes,
            bool includeAttributeArguments = DefaultValues.IncludeAttributeArguments,
            bool formatAttributes = DefaultValues.FormatAttributes,
            bool formatParameters = DefaultValues.FormatParameters,
            bool formatBaseList = DefaultValues.FormatBaseList,
            bool formatConstraints = DefaultValues.FormatConstraints,
            bool omitIEnumerable = DefaultValues.OmitIEnumerable,
            bool preferDefaultLiteral = DefaultValues.PreferDefaultLiteral)
        {
            IndentChars = indentChars;
            NestNamespaces = nestNamespaces;
            EmptyLineBetweenMembers = emptyLineBetweenMembers;
            OmitContainingNamespace = omitContainingNamespace;
            IncludeAttributes = includeAttributes;
            IncludeAssemblyAttributes = includeAssemblyAttributes;
            IncludeAttributeArguments = includeAttributeArguments;
            FormatAttributes = formatAttributes;
            FormatParameters = formatParameters;
            FormatBaseList = formatBaseList;
            FormatConstraints = formatConstraints;
            OmitIEnumerable = omitIEnumerable;
            PreferDefaultLiteral = preferDefaultLiteral;
        }

        public static DefinitionListFormat Default { get; } = new DefinitionListFormat();

        public string IndentChars { get; }

        public bool NestNamespaces { get; }

        public bool EmptyLineBetweenMembers { get; }

        public bool OmitContainingNamespace { get; }

        public bool IncludeAttributes { get; }

        public bool IncludeAssemblyAttributes { get; }

        public bool IncludeAttributeArguments { get; }

        public bool FormatAttributes { get; }

        public bool FormatParameters { get; }

        public bool FormatBaseList { get; }

        public bool FormatConstraints { get; }

        public bool OmitIEnumerable { get; }

        public bool PreferDefaultLiteral { get; }

        internal static class DefaultValues
        {
            public const Visibility Visibility = Roslynator.Visibility.Private;
            public const SymbolGroupFilter SymbolGroupFilter = Roslynator.SymbolGroupFilter.NamespaceOrTypeOrMember;
            public const string IndentChars = "  ";
            public const bool NestNamespaces = false;
            public const bool EmptyLineBetweenMembers = false;
            public const bool OmitContainingNamespace = false;
            public const bool IncludeAttributes = true;
            public const bool IncludeAssemblyAttributes = false;
            public const bool IncludeAttributeArguments = true;
            public const bool FormatAttributes = false;
            public const bool FormatParameters = false;
            public const bool FormatBaseList = false;
            public const bool FormatConstraints = false;
            public const bool OmitIEnumerable = true;
            public const bool PreferDefaultLiteral = true;
        }
    }
}
