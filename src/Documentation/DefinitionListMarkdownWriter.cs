// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using DotMarkdown;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    internal class DefinitionListMarkdownWriter : AbstractDefinitionListTextWriter
    {
        private readonly MarkdownWriter _writer;
        private bool _pendingIndentation;

        public DefinitionListMarkdownWriter(
            MarkdownWriter writer,
            SymbolFilterOptions filter,
            DefinitionListFormat format = null,
            IComparer<ISymbol> comparer = null,
            string rootDirectoryUrl = null) : base(filter, format, comparer)
        {
            _writer = writer;
            RootDirectoryUrl = rootDirectoryUrl;
        }

        public string RootDirectoryUrl { get; }

        public override bool SupportsMultilineDefinitions => false;

        public override void WriteStartTypes()
        {
        }

        public override void WriteTypeSeparator()
        {
        }

        public override void WriteStartMembers()
        {
        }

        public override void WriteMemberSeparator()
        {
        }

        public override void Write(ISymbol symbol, SymbolDisplayFormat format)
        {
            if (RootDirectoryUrl != null)
            {
                WritePendingIndentation();
                _writer.WriteStartLink();
            }

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

            if (part.Kind == SymbolDisplayPartKind.LineBreak)
                _pendingIndentation = true;
        }

        public override void Write(string value)
        {
            WritePendingIndentation();

            _writer.WriteString(value);
        }

        private void WritePendingIndentation()
        {
            if (_pendingIndentation)
            {
                _pendingIndentation = false;
                WriteIndentation();
            }
        }

        public override void WriteLine()
        {
            _writer.WriteLine();

            _pendingIndentation = true;
        }

        private void WriteIndentation()
        {
            if (IndentationLevel > 0)
            {
                Write("| ");

                _writer.WriteEntityRef("emsp");

                for (int i = 1; i < IndentationLevel; i++)
                {
                    Write(" | ");

                    _writer.WriteEntityRef("emsp");
                }

                Write(" ");
            }
        }
    }
}
