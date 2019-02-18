// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.IO;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    internal class SymbolHierarchyTextWriter : SymbolDefinitionTextWriter
    {
        public SymbolHierarchyTextWriter(
            TextWriter writer,
            SymbolFilterOptions filter = null,
            DefinitionListFormat format = null,
            IComparer<ISymbol> comparer = null) : base(writer, filter, format, comparer)
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
