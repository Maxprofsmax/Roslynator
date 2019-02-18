// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using DotMarkdown;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation.Markdown
{
    internal class SymbolHierarchyMarkdownWriter : SymbolDefinitionMarkdownWriter
    {
        public SymbolHierarchyMarkdownWriter(
            MarkdownWriter writer,
            SymbolFilterOptions filter = null,
            DefinitionListFormat format = null,
            IComparer<ISymbol> comparer = null,
            string rootDirectoryUrl = null) : base(writer, filter, format, comparer, rootDirectoryUrl)
        {
        }

        public override bool SupportsMultilineDefinitions => false;

        public override SymbolDisplayFormat GetTypeFormat(INamedTypeSymbol typeSymbol)
        {
            return SymbolDefinitionDisplayFormats.HierarchyType;
        }

        public override SymbolDisplayTypeDeclarationOptions GetTypeDeclarationOptions()
        {
            return SymbolDisplayTypeDeclarationOptions.Interfaces;
        }
    }
}
