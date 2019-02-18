// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using DotMarkdown;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation.Markdown
{
    internal class SymbolDefinitionMarkdownWriter : AbstractSymbolDefinitionTextWriter
    {
        private readonly MarkdownWriter _writer;

        public SymbolDefinitionMarkdownWriter(
            MarkdownWriter writer,
            SymbolFilterOptions filter = null,
            DefinitionListFormat format = null,
            IComparer<ISymbol> comparer = null,
            string rootDirectoryUrl = null) : base(filter, format, comparer)
        {
            _writer = writer;
            RootDirectoryUrl = rootDirectoryUrl;
        }

        public string RootDirectoryUrl { get; }

        public override bool SupportsMultilineDefinitions => false;

        public override void WriteStartAssembly(IAssemblySymbol assemblySymbol)
        {
            WriteStartBulletItem();
            base.WriteStartAssembly(assemblySymbol);
        }

        public override void WriteAssembly(IAssemblySymbol assemblySymbol)
        {
            base.WriteAssembly(assemblySymbol);
            WriteEndBulletItem();
        }

        public override void WriteStartNamespaces()
        {
        }

        public override void WriteStartNamespace(INamespaceSymbol namespaceSymbol)
        {
            WriteStartBulletItem();
            base.WriteStartNamespace(namespaceSymbol);
        }

        public override void WriteNamespace(INamespaceSymbol namespaceSymbol)
        {
            base.WriteNamespace(namespaceSymbol);
            WriteEndBulletItem();
        }

        public override void WriteNamespaceSeparator()
        {
        }

        public override void WriteStartTypes()
        {
        }

        public override void WriteStartType(INamedTypeSymbol typeSymbol)
        {
            WriteStartBulletItem();
            base.WriteStartType(typeSymbol);
        }

        public override void WriteType(INamedTypeSymbol typeSymbol)
        {
            base.WriteType(typeSymbol);
            WriteEndBulletItem();
        }

        public override void WriteTypeSeparator()
        {
        }

        public override void WriteStartMembers()
        {
        }

        public override void WriteStartMember(ISymbol symbol)
        {
            WriteStartBulletItem();
            base.WriteStartMember(symbol);
        }

        public override void WriteMember(ISymbol symbol)
        {
            base.WriteMember(symbol);
            WriteEndBulletItem();
        }

        public override void WriteMemberSeparator()
        {
        }

        public override void WriteStartEnumMembers()
        {
        }

        public override void WriteStartEnumMember(ISymbol symbol)
        {
            WriteStartBulletItem();
            base.WriteStartEnumMember(symbol);
        }

        public override void WriteEnumMember(ISymbol symbol)
        {
            base.WriteEnumMember(symbol);
            WriteEndBulletItem();
        }

        private void WriteStartBulletItem()
        {
            _writer.WriteStartBulletItem();
        }

        private void WriteEndBulletItem()
        {
            _writer.WriteEndBulletItem();
        }

        public override void Write(ISymbol symbol, SymbolDisplayFormat format)
        {
            if (RootDirectoryUrl != null)
                _writer.WriteStartLink();

            base.Write(symbol, format);

            if (RootDirectoryUrl != null)
            {
                DocumentationUrlProvider urlProvider = WellKnownUrlProviders.GitHub;

                ImmutableArray<string> folders = urlProvider.GetFolders(symbol);

                string url = urlProvider.GetLocalUrl(folders).Url;

                url = RootDirectoryUrl + url;

                _writer.WriteEndLink(url: url);
            }
        }

        public override void Write(SymbolDisplayPart part)
        {
            base.Write(part);

            Debug.Assert(part.Kind != SymbolDisplayPartKind.LineBreak, "");
        }

        public override void Write(string value)
        {
            Debug.Assert(value?.Contains("\n") != true, @"\n");
            Debug.Assert(value?.Contains("\r") != true, @"\r");

            _writer.WriteString(value);
        }

        public override void WriteLine()
        {
            _writer.WriteLine();
        }

        protected override void WriteIndentation()
        {
            if (Depth > 0)
            {
                _writer.WriteEntityRef("emsp");

                for (int i = 1; i < Depth; i++)
                {
                    Write(" | ");

                    _writer.WriteEntityRef("emsp");
                }

                Write(" ");
            }
        }
    }
}
