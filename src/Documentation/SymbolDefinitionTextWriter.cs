// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.IO;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    internal class SymbolDefinitionTextWriter : AbstractSymbolDefinitionTextWriter
    {
        private readonly TextWriter _writer;
        private bool _pendingIndentation;

        public SymbolDefinitionTextWriter(
            TextWriter writer,
            SymbolFilterOptions filter,
            DefinitionListFormat format = null,
            IComparer<ISymbol> comparer = null) : base(filter, format, comparer)
        {
            _writer = writer;
        }

        public override void WriteStartNamespaces()
        {
            WriteLine();
        }

        public override void WriteNamespaceSeparator()
        {
            WriteLine();
        }

        public override void WriteStartTypes()
        {
            WriteLine();
        }

        public override void WriteTypeSeparator()
        {
            WriteLine();
        }

        public override void WriteStartMembers()
        {
            WriteLine();
        }

        public override void WriteMemberSeparator()
        {
            WriteLine();
        }

        public override void WriteStartEnumMembers()
        {
            WriteLine();
        }

        public override void Write(SymbolDisplayPart part)
        {
            base.Write(part);

            if (part.Kind == SymbolDisplayPartKind.LineBreak)
                _pendingIndentation = true;
        }

        public override void Write(string value)
        {
            if (_pendingIndentation)
                WriteIndentation();

            _writer.Write(value);
        }

        public override void WriteLine()
        {
            _writer.WriteLine();

            _pendingIndentation = true;
        }

        protected override void WriteIndentation()
        {
            _pendingIndentation = false;

            for (int i = 0; i < Depth; i++)
            {
                Write(Format.IndentChars);
            }
        }
    }
}
