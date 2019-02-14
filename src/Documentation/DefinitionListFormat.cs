// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Roslynator.Documentation
{
    //TODO: order by namespace, accessibility, typekind, memberkind, name
    internal class DefinitionListFormat
    {
        public DefinitionListFormat(
            string indentChars = DefaultValues.IndentChars,
            bool omitContainingNamespace = DefaultValues.OmitContainingNamespace,
            bool nestNamespaces = DefaultValues.NestNamespaces,
            bool emptyLineBetweenMembers = DefaultValues.EmptyLineBetweenMembers,
            bool formatBaseList = DefaultValues.FormatBaseList,
            bool formatConstraints = DefaultValues.FormatConstraints,
            bool formatParameters = DefaultValues.FormatParameters,
            bool splitAttributes = DefaultValues.SplitAttributes,
            bool includeAttributeArguments = DefaultValues.IncludeAttributeArguments,
            bool omitIEnumerable = DefaultValues.OmitIEnumerable,
            bool useDefaultLiteral = DefaultValues.UseDefaultLiteral,
            bool assemblyAttributes = DefaultValues.AssemblyAttributes)
        {
            IndentChars = indentChars;
            OmitContainingNamespace = omitContainingNamespace;
            NestNamespaces = nestNamespaces;
            EmptyLineBetweenMembers = emptyLineBetweenMembers;
            FormatBaseList = formatBaseList;
            FormatConstraints = formatConstraints;
            FormatParameters = formatParameters;
            SplitAttributes = splitAttributes;
            IncludeAttributeArguments = includeAttributeArguments;
            OmitIEnumerable = omitIEnumerable;
            UseDefaultLiteral = useDefaultLiteral;
            AssemblyAttributes = assemblyAttributes;
        }

        public static DefinitionListFormat Default { get; } = new DefinitionListFormat();

        public string IndentChars { get; }

        public bool OmitContainingNamespace { get; }

        public bool NestNamespaces { get; }

        public bool EmptyLineBetweenMembers { get; }

        public bool FormatBaseList { get; }

        public bool FormatConstraints { get; }

        public bool FormatParameters { get; }

        public bool SplitAttributes { get; }

        public bool IncludeAttributeArguments { get; }

        public bool OmitIEnumerable { get; }

        public bool UseDefaultLiteral { get; }

        public bool AssemblyAttributes { get; }

        internal static class DefaultValues
        {
            public const Visibility Visibility = Roslynator.Visibility.Private;
            public const SymbolGroups SymbolGroups = Roslynator.SymbolGroups.NamespaceOrTypeOrMember;
            public const string IndentChars = "  ";
            public const bool OmitContainingNamespace = false;
            public const bool NestNamespaces = false;
            public const bool EmptyLineBetweenMembers = false;
            public const bool FormatBaseList = false;
            public const bool FormatConstraints = false;
            public const bool FormatParameters = false;
            public const bool SplitAttributes = true;
            public const bool IncludeAttributeArguments = true;
            public const bool OmitIEnumerable = true;
            public const bool UseDefaultLiteral = true;
            public const bool AssemblyAttributes = false;
        }
    }
}
