// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    internal class DefinitionListXmlWriter : DefinitionListWriter
    {
        private readonly XmlWriter _writer;

        public DefinitionListXmlWriter(
            XmlWriter writer,
            SymbolFilterOptions filter,
            DefinitionListFormat format = null,
            IComparer<ISymbol> comparer = null) : base(filter, format, comparer)
        {
            _writer = writer;
        }

        public override bool SupportsMultilineDefinitions => false;

        public override void WriteStartDocument()
        {
            _writer.WriteStartDocument();
            WriteStartElement("root");
        }

        public override void WriteEndDocument()
        {
            WriteEndElement();
            _writer.WriteEndDocument();
        }

        public override void WriteStartAssemblies()
        {
            WriteStartElement("assemblies");
        }

        public override void WriteEndAssemblies()
        {
            WriteEndElement();
        }

        public override void WriteStartAssembly(IAssemblySymbol assemblySymbol)
        {
            WriteStartElement("assembly");
            WriteStartAttribute("name");
            Write(assemblySymbol.Identity.ToString());
            WriteEndAttribute();

            if (Format.AssemblyAttributes)
                WriteAttributes(assemblySymbol);
        }

        public override void WriteEndAssembly(IAssemblySymbol assemblySymbol)
        {
            WriteEndElement();
        }

        public override void WriteAssemblySeparator()
        {
        }

        public override void WriteStartNamespaces()
        {
            WriteStartElement("namespaces");
        }

        public override void WriteEndNamespaces()
        {
            WriteEndElement();
        }

        public override void WriteStartNamespace(INamespaceSymbol namespaceSymbol)
        {
            WriteStartElement("namespace");
            WriteStartAttribute("name");

            if (!namespaceSymbol.IsGlobalNamespace)
                Write(namespaceSymbol, SymbolDefinitionDisplayFormats.TypeNameAndContainingTypesAndNamespaces);

            WriteEndAttribute();
        }

        public override void WriteEndNamespace(INamespaceSymbol namespaceSymbol)
        {
            WriteEndElement();
        }

        public override void WriteNamespaceSeparator()
        {
        }

        public override void WriteStartTypes()
        {
            WriteStartElement("types");
        }

        public override void WriteEndTypes()
        {
            WriteEndElement();
        }

        public override void WriteStartType(INamedTypeSymbol typeSymbol)
        {
            WriteStartElement(GetTypeName());
            WriteStartAttribute("def");
            Write(typeSymbol, SymbolDefinitionDisplayFormats.FullDefinition_NameOnly);
            WriteEndAttribute();
            WriteAttributes(typeSymbol);

            string GetTypeName()
            {
                switch (typeSymbol.TypeKind)
                {
                    case TypeKind.Class:
                        return "class";
                    case TypeKind.Delegate:
                        return "delegate";
                    case TypeKind.Enum:
                        return "enum";
                    case TypeKind.Interface:
                        return "interface";
                    case TypeKind.Struct:
                        return "struct";
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public override void WriteEndType(INamedTypeSymbol typeSymbol)
        {
            WriteEndElement();
        }

        public override void WriteTypeSeparator()
        {
        }

        public override void WriteStartMembers()
        {
            WriteStartElement("members");
        }

        public override void WriteEndMembers()
        {
            WriteEndElement();
        }

        public override void WriteStartMember(ISymbol symbol)
        {
            WriteStartElement(GetMemberName());
            WriteStartAttribute("def");

            SymbolDisplayFormat format = (Format.OmitContainingNamespace)
                ? SymbolDefinitionDisplayFormats.FullDefinition_NameAndContainingTypes
                : SymbolDefinitionDisplayFormats.FullDefinition_NameAndContainingTypesAndNamespaces;

            Write(symbol, format);
            WriteEndAttribute();
            WriteAttributes(symbol);

            string GetMemberName()
            {
                switch (symbol.GetMemberDeclarationKind())
                {
                    case MemberDeclarationKind.Const:
                        return "const";
                    case MemberDeclarationKind.Field:
                        return "field";
                    case MemberDeclarationKind.StaticConstructor:
                    case MemberDeclarationKind.Constructor:
                        return "constructor";
                    case MemberDeclarationKind.Destructor:
                        return "destructor";
                    case MemberDeclarationKind.Event:
                        return "event";
                    case MemberDeclarationKind.Property:
                        return "property";
                    case MemberDeclarationKind.Indexer:
                        return "indexer";
                    case MemberDeclarationKind.OrdinaryMethod:
                        return "method";
                    case MemberDeclarationKind.ConversionOperator:
                    case MemberDeclarationKind.Operator:
                        return "operator";
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public override void WriteEndMember(ISymbol symbol)
        {
            WriteEndElement();
        }

        public override void WriteMemberSeparator()
        {
        }

        public override void WriteStartEnumMembers()
        {
            WriteStartElement("members");
        }

        public override void WriteEndEnumMembers()
        {
            WriteEndElement();
        }

        public override void WriteStartEnumMember(ISymbol symbol)
        {
            WriteStartElement("field");
            WriteStartAttribute("def");
            Write(symbol, SymbolDefinitionDisplayFormats.FullDefinition_NameOnly);
            WriteEndAttribute();
            WriteAttributes(symbol);
        }

        public override void WriteEndEnumMember(ISymbol symbol)
        {
            WriteEndElement();
        }

        public override void WriteEnumMemberSeparator()
        {
        }

        public override void WriteStartAttributes()
        {
            WriteStartElement("attributes");
        }

        public override void WriteEndAttributes()
        {
            WriteEndElement();
        }

        public override void WriteStartAttribute(AttributeData attribute)
        {
            WriteStartElement("attribute");
        }

        public override void WriteEndAttribute(AttributeData attribute)
        {
            WriteEndElement();
        }

        public override void WriteAttributeSeparator()
        {
        }

        public override void Write(string value)
        {
            _writer.WriteString(value);
        }

        public override void WriteLine()
        {
            throw new InvalidOperationException();
        }

        public override void WriteLine(string value)
        {
            throw new InvalidOperationException();
        }

        private void WriteStartElement(string localName)
        {
            _writer.WriteStartElement(localName);
        }

        private void WriteStartAttribute(string localName)
        {
            _writer.WriteStartAttribute(localName);
        }

        private void WriteEndElement()
        {
            _writer.WriteEndElement();
        }

        private void WriteEndAttribute()
        {
            _writer.WriteEndAttribute();
        }
    }
}
