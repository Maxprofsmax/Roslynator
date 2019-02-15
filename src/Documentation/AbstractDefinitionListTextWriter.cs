// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    internal abstract class AbstractDefinitionListTextWriter : DefinitionListWriter
    {
        public int IndentationLevel { get; private set; }

        protected AbstractDefinitionListTextWriter(
            SymbolFilterOptions filter,
            DefinitionListFormat format = null,
            IComparer<ISymbol> comparer = null) : base(filter, format, comparer)
        {
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
            WriteLine();
        }

        public override void WriteStartAssembly(IAssemblySymbol assemblySymbol)
        {
            Write("assembly ");
            WriteLine(assemblySymbol.Identity.ToString());
            IncreaseIndentation();
        }

        public override void WriteEndAssembly(IAssemblySymbol assemblySymbol)
        {
            DecreaseIndentation();
        }

        public override void WriteAssemblySeparator()
        {
            if (Format.AssemblyAttributes)
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
            IncreaseIndentation();
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

        public override void WriteEndTypes()
        {
        }

        public override void WriteStartType(INamedTypeSymbol typeSymbol)
        {
            Write(typeSymbol, SymbolDefinitionDisplayFormats.FullDefinition_NameOnly);
            WriteLine();

            IncreaseIndentation();
        }

        public override void WriteEndType(INamedTypeSymbol typeSymbol)
        {
            DecreaseIndentation();
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
            WriteLine();
            IncreaseIndentation();
        }

        public override void WriteEndMember(ISymbol symbol)
        {
            DecreaseIndentation();
        }

        public override void WriteEndEnumMembers()
        {
        }

        public override void WriteStartEnumMember(ISymbol symbol)
        {
            Write(symbol, SymbolDefinitionDisplayFormats.FullDefinition_NameOnly);
            WriteLine();
            IncreaseIndentation();
        }

        public override void WriteEndEnumMember(ISymbol symbol)
        {
            DecreaseIndentation();
        }

        public override void WriteEnumMemberSeparator()
        {
        }

        public override void WriteStartAttributes(bool assemblyAttribute)
        {
            Write("[");
        }

        public override void WriteEndAttributes(bool assemblyAttribute)
        {
            Write("]");

            if (assemblyAttribute || SupportsMultilineDefinitions)
            {
                WriteLine();
            }
            else
            {
                Write(" ");
            }
        }

        public override void WriteStartAttribute(AttributeData attribute, bool assemblyAttribute)
        {
        }

        public override void WriteEndAttribute(AttributeData attribute, bool assemblyAttribute)
        {
        }

        public override void WriteAttributeSeparator(bool assemblyAttribute)
        {
            if (assemblyAttribute
                || (Format.FormatAttributes && SupportsMultilineDefinitions))
            {
                Write("]");
                WriteLine();
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

        public void IncreaseIndentation()
        {
            IndentationLevel++;
        }

        public void DecreaseIndentation()
        {
            Debug.Assert(IndentationLevel > 0, "Cannot decrease indentation level.");
            IndentationLevel--;
        }
    }
}
