// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Roslynator.Documentation
{
    internal class SymbolHierarchyWriter
    {
        private readonly SymbolDefinitionWriter _writer;

        public SymbolHierarchyWriter(SymbolDefinitionWriter writer)
        {
            _writer = writer;
        }

        public void WriteTypeHierarchy(SymbolHierarchy hierarchy)
        {
            WriteTypeHierarchy(hierarchy.Root);

            void WriteTypeHierarchy(SymbolHierarchyItem item)
            {
                _writer.WriteStartType(item.Symbol);

                if (item.Symbol.HasAttribute(MetadataNames.System_ObsoleteAttribute))
                    _writer.Write("[deprecated] ");

                _writer.WriteType(
                    item.Symbol,
                    format: SymbolDefinitionDisplayFormats.HierarchyType,
                    typeDeclarationOptions: (SymbolDisplayTypeDeclarationOptions?)SymbolDisplayTypeDeclarationOptions.Interfaces);

                foreach (SymbolHierarchyItem derivedItem in item.Children())
                    WriteTypeHierarchy(derivedItem);

                _writer.WriteEndType(item.Symbol);
            }
        }
    }
}
