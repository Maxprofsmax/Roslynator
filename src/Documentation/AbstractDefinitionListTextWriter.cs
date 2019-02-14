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
            Write(assemblySymbol.Identity.ToString());

            IncreaseIndentation();

            if (Format.AssemblyAttributes)
                WriteAttributes(assemblySymbol);

            DecreaseIndentation();
        }

        public override void WriteEndAssembly(IAssemblySymbol assemblySymbol)
        {
        }

        public override void WriteAssemblySeparator()
        {
            if (Format.AssemblyAttributes)
                WriteLine();

            WriteLine();
        }

        public override void WriteStartNamespaces()
        {
            WriteLine();
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

            TypeKind typeKind = typeSymbol.TypeKind;

            if (typeSymbol.TypeKind != TypeKind.Delegate)
            {
                WriteLine();

                IncreaseIndentation();
            }
        }

        public override void WriteEndType(INamedTypeSymbol typeSymbol)
        {
            if (typeSymbol.TypeKind != TypeKind.Delegate)
            {
                DecreaseIndentation();
            }
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

        public override void WriteStartAttributes(bool assemblyAttribute)
        {
            if (assemblyAttribute)
                WriteLine();

            Write("[");
        }

        public override void WriteEndAttributes(bool assemblyAttribute)
        {
            Write("]");

            if (!assemblyAttribute)
            {
                if (Format.FormatAttributes
                    && SupportsMultilineDefinitions)
                {
                    WriteLine();
                }
                else
                {
                    Write(" ");
                }
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
