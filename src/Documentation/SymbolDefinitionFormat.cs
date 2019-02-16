// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    internal class SymbolDefinitionFormat
    {
        public SymbolDefinitionFormat(
            SymbolDisplayFormat format,
            SymbolDisplayTypeDeclarationOptions typeDeclarationOptions = SymbolDisplayTypeDeclarationOptions.None,
            bool omitContainingNamespace = false,
            bool includeAttributes = false,
            bool includeParameterAttributes = false,
            bool includeAccessorAttributes = false,
            bool formatAttributes = false,
            bool formatBaseList = false,
            bool formatConstraints = false,
            bool formatParameters = false,
            bool includeAttributeArguments = false,
            bool omitIEnumerable = false,
            bool preferDefaultLiteral = true)
        {
            Format = format;
            TypeDeclarationOptions = typeDeclarationOptions;
            OmitContainingNamespace = omitContainingNamespace;
            IncludeAttributes = includeAttributes;
            IncludeParameterAttributes = includeParameterAttributes;
            IncludeAccessorAttributes = includeAccessorAttributes;
            FormatAttributes = formatAttributes;
            FormatBaseList = formatBaseList;
            FormatConstraints = formatConstraints;
            FormatParameters = formatParameters;
            IncludeAttributeArguments = includeAttributeArguments;
            OmitIEnumerable = omitIEnumerable;
            PreferDefaultLiteral = preferDefaultLiteral;
        }

        public SymbolDisplayFormat Format { get; }

        public SymbolDisplayTypeDeclarationOptions TypeDeclarationOptions { get; }

        public bool OmitContainingNamespace { get; }

        public bool IncludeAttributes { get; }

        public bool IncludeParameterAttributes { get; }

        public bool IncludeAccessorAttributes { get; }

        public bool FormatAttributes { get; }

        public bool FormatBaseList { get; }

        public bool FormatConstraints { get; }

        public bool FormatParameters { get; }

        public bool IncludeAttributeArguments { get; }

        public bool OmitIEnumerable { get; }

        public bool PreferDefaultLiteral { get; }

        public SymbolDefinitionFormat WithFormatAttributes(bool formatAttributes)
        {
            return new SymbolDefinitionFormat(
                Format,
                TypeDeclarationOptions,
                OmitContainingNamespace,
                IncludeAttributes,
                IncludeParameterAttributes,
                IncludeAccessorAttributes,
                formatAttributes,
                FormatBaseList,
                FormatConstraints,
                FormatParameters,
                IncludeAttributeArguments,
                OmitIEnumerable,
                PreferDefaultLiteral);
        }
    }
}
