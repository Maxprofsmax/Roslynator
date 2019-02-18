// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Xml;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation.Xml
{
    internal class SymbolHierarchyXmlWriter : SymbolDefinitionXmlWriter
    {
        public SymbolHierarchyXmlWriter(
            XmlWriter writer,
            SymbolFilterOptions filter = null,
            DefinitionListFormat format = null,
            SymbolDocumentationProvider documentationProvider = null,
            IComparer<ISymbol> comparer = null) : base(writer, filter, format, documentationProvider, comparer)
        {
        }

        public override bool SupportsMultilineDefinitions => false;
    }
}
