// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation.Xml
{
    internal class SymbolDefinitionXmlWriter : SymbolDefinitionWriter
    {
        private readonly XmlWriter _writer;

        public SymbolDefinitionXmlWriter(
            XmlWriter writer,
            SymbolFilterOptions filter = null,
            DefinitionListFormat format = null,
            SymbolDocumentationProvider documentationProvider = null,
            IComparer<ISymbol> comparer = null) : base(filter, format, comparer)
        {
            _writer = writer;
            DocumentationProvider = documentationProvider;
        }

        public override bool SupportsMultilineDefinitions => false;

        public SymbolDocumentationProvider DocumentationProvider { get; }

        public override SymbolDisplayFormat GetNamespaceFormat(INamespaceSymbol namespaceSymbol)
        {
            return SymbolDefinitionDisplayFormats.TypeNameAndContainingTypesAndNamespaces;
        }

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
        }

        public override void WriteAssembly(IAssemblySymbol assemblySymbol)
        {
            WriteStartAttribute("name");
            Write(assemblySymbol.Identity.ToString());
            WriteEndAttribute();

            if (Format.IncludeAssemblyAttributes)
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
        }

        public override void WriteNamespace(INamespaceSymbol namespaceSymbol, SymbolDisplayFormat format = null)
        {
            WriteStartAttribute("name");

            if (!namespaceSymbol.IsGlobalNamespace)
                Write(namespaceSymbol, format ?? GetNamespaceFormat(namespaceSymbol));

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
            WriteStartElement("type");
        }

        public override void WriteType(INamedTypeSymbol typeSymbol, SymbolDisplayFormat format = null, SymbolDisplayTypeDeclarationOptions? typeDeclarationOptions = null)
        {
            WriteStartAttribute("def");
            Write(typeSymbol, format ?? GetTypeFormat(typeSymbol), typeDeclarationOptions);
            WriteEndAttribute();
            WriteDocumentation(typeSymbol);

            if (Format.IncludeAttributes)
                WriteAttributes(typeSymbol);
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
            WriteStartElement("member");
        }

        public override void WriteMember(ISymbol symbol, SymbolDisplayFormat format = null)
        {
            WriteStartAttribute("def");
            Write(symbol, format ?? GetMemberFormat(symbol));
            WriteEndAttribute();
            WriteDocumentation(symbol);

            if (Format.IncludeAttributes)
                WriteAttributes(symbol);
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
            WriteStartElement("member");
        }

        public override void WriteEnumMember(ISymbol symbol, SymbolDisplayFormat format = null)
        {
            WriteStartAttribute("def");
            Write(symbol, format ?? GetEnumMemberFormat(symbol));
            WriteEndAttribute();

            if (Format.IncludeAttributes)
                WriteAttributes(symbol);
        }

        public override void WriteEndEnumMember(ISymbol symbol)
        {
            WriteEndElement();
        }

        public override void WriteEnumMemberSeparator()
        {
        }

        public override void WriteStartAttributes(bool assemblyAttribute)
        {
            WriteStartElement("attributes");
        }

        public override void WriteEndAttributes(bool assemblyAttribute)
        {
            WriteEndElement();
        }

        public override void WriteStartAttribute(AttributeData attribute, bool assemblyAttribute)
        {
            WriteStartElement("attribute");
        }

        public override void WriteEndAttribute(AttributeData attribute, bool assemblyAttribute)
        {
            WriteEndElement();
        }

        public override void WriteAttributeSeparator(bool assemblyAttribute)
        {
        }

        public override void Write(string value)
        {
            Debug.Assert(value?.Contains("\n") != true, @"\n");
            Debug.Assert(value?.Contains("\r") != true, @"\r");

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
            IncreaseDepth();
        }

        private void WriteStartAttribute(string localName)
        {
            _writer.WriteStartAttribute(localName);
        }

        private void WriteEndElement()
        {
            _writer.WriteEndElement();
            DecreaseDepth();
        }

        private void WriteEndAttribute()
        {
            _writer.WriteEndAttribute();
        }

        private void WriteDocumentation(ISymbol symbol)
        {
            if (DocumentationProvider == null)
                return;

            SymbolXmlDocumentation xmlDocumentation = DocumentationProvider.GetXmlDocumentation(symbol);

            if (xmlDocumentation == null)
                return;

            WriteStartElement("doc");

            string xml = xmlDocumentation.GetInnerXml();

            _writer.WriteWhitespace(_writer.Settings.NewLineChars);

            using (var sr = new StringReader(xml))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < Depth; i++)
                        _writer.WriteWhitespace(_writer.Settings.IndentChars);

                    _writer.WriteRaw(line);
                    _writer.WriteWhitespace(_writer.Settings.NewLineChars);
                }
            }

            for (int i = 1; i < Depth; i++)
                _writer.WriteWhitespace(_writer.Settings.IndentChars);

            WriteEndElement();
        }
    }
}
