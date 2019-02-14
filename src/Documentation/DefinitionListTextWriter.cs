// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    internal class DefinitionListTextWriter : DefinitionListWriter
    {
        private bool _pendingIndentation;
        private int _indentationLevel;
        private readonly TextWriter _writer;

        public DefinitionListTextWriter(
            TextWriter writer,
            SymbolFilterOptions filter,
            DefinitionListFormat format = null,
            IComparer<ISymbol> comparer = null) : base(filter, format, comparer)
        {
            _writer = writer;
        }

        public override void WriteStartDocument()
        {
        }

        public override void WriteEndDocument()
        {
        }

        public override void WriteStartAssemblies()
        {
        }

        public override void WriteEndAssemblies()
        {
        }

        public override void WriteStartAssembly(IAssemblySymbol assemblySymbol)
        {
            Write("assembly ");
            Write(assemblySymbol.Identity.ToString());

            _indentationLevel++;

            if (Format.AssemblyAttributes)
            {
                WriteLine();
                WriteAttributes(assemblySymbol);
            }

            DecreaseIndentation();
        }

        public override void WriteEndAssembly(IAssemblySymbol assemblySymbol)
        {
        }

        public override void WriteAssemblySeparator()
        {
            WriteLine();
        }

        public override void WriteStartNamespaces()
        {
        }

        public override void WriteEndNamespaces()
        {
        }

        public override void WriteStartNamespace(INamespaceSymbol namespaceSymbol)
        {
            if (namespaceSymbol.IsGlobalNamespace)
                return;

            Write(namespaceSymbol, SymbolDefinitionDisplayFormats.NamespaceDefinition);
            WriteLine();

            _indentationLevel++;
        }

        public override void WriteEndNamespace(INamespaceSymbol namespaceSymbol)
        {
            if (namespaceSymbol.IsGlobalNamespace)
                return;

            DecreaseIndentation();
        }

        public override void WriteNamespaceSeparator()
        {
            WriteLine();
        }

        public override void WriteStartTypes()
        {
            WriteLine();
        }

        public override void WriteEndTypes()
        {
        }

        public override void WriteStartType(INamedTypeSymbol typeSymbol)
        {
            Write(typeSymbol, SymbolDefinitionDisplayFormats.FullDefinition_NameOnly);

            TypeKind typeKind = typeSymbol.TypeKind;

            if (typeSymbol.TypeKind != TypeKind.Delegate)
            {
                WriteLine();

                _indentationLevel++;
            }
        }

        public override void WriteEndType(INamedTypeSymbol typeSymbol)
        {
            if (typeSymbol.TypeKind != TypeKind.Delegate)
            {
                DecreaseIndentation();
            }
        }

        public override void WriteTypeSeparator()
        {
            WriteLine();
        }

        public override void WriteStartMembers()
        {
            WriteLine();
        }

        public override void WriteEndMembers()
        {
        }

        public override void WriteStartMember(ISymbol symbol)
        {
            SymbolDisplayFormat format = (Format.OmitContainingNamespace)
                ? SymbolDefinitionDisplayFormats.FullDefinition_NameAndContainingTypes
                : SymbolDefinitionDisplayFormats.FullDefinition_NameAndContainingTypesAndNamespaces;

            Write(symbol, format);
        }

        public override void WriteEndMember(ISymbol symbol)
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

        public override void WriteEndEnumMembers()
        {
        }

        public override void WriteStartEnumMember(ISymbol symbol)
        {
            Write(symbol, SymbolDefinitionDisplayFormats.FullDefinition_NameOnly);
        }

        public override void WriteEndEnumMember(ISymbol symbol)
        {
            WriteLine();
        }

        public override void WriteEnumMemberSeparator()
        {
        }

        public override void WriteStartAttributes()
        {
            Write("[");
        }

        public override void WriteEndAttributes()
        {
            Write("]");
            WriteLine();
        }

        public override void WriteStartAttribute(AttributeData attribute)
        {
        }

        public override void WriteEndAttribute(AttributeData attribute)
        {
        }

        public override void WriteAttributeSeparator()
        {
            if (Format.SplitAttributes)
            {
                Write("]");

                if (SupportsMultilineDefinitions)
                {
                    WriteLine();
                }
                else
                {
                    Write(" ");
                }

                Write("[");
            }
            else
            {
                Write(", ");
            }
        }

        public override void Write(ISymbol symbol, SymbolDisplayFormat format)
        {
            WriteAttributes(symbol);
            base.Write(symbol, format);
        }

        public override void Write(SymbolDisplayPart part)
        {
            base.Write(part);

            if (part.Kind == SymbolDisplayPartKind.LineBreak)
                _pendingIndentation = true;
        }

        public override void Write(string value)
        {
            CheckPendingIndentation();
            _writer.Write(value);
        }

        public override void WriteLine()
        {
            _writer.WriteLine();

            _pendingIndentation = true;
        }

        public override void WriteLine(string value)
        {
            Write(value);
            WriteLine();
        }

        private void WriteIndentation()
        {
            for (int i = 0; i < _indentationLevel; i++)
            {
                Write(Format.IndentChars);
            }
        }

        private void CheckPendingIndentation()
        {
            if (_pendingIndentation)
            {
                _pendingIndentation = false;
                WriteIndentation();
            }
        }

        private void DecreaseIndentation()
        {
            Debug.Assert(_indentationLevel > 0, "Cannot decrease indentation level.");
            _indentationLevel--;
        }

        public override string ToString()
        {
            return _writer.ToString();
        }
    }
}
