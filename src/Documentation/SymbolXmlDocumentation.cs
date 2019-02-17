// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class SymbolXmlDocumentation
    {
        private readonly XElement _element;

        internal static SymbolXmlDocumentation Default { get; } = new SymbolXmlDocumentation(null, null);

        public SymbolXmlDocumentation(ISymbol symbol, XElement element)
        {
            Symbol = symbol;
            _element = element;
        }

        public ISymbol Symbol { get; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay
        {
            get { return $"{_element}"; }
        }

        public XElement Element(string name)
        {
            foreach (XElement element in _element.Elements())
            {
                if (string.Equals(element.Name.LocalName, name, StringComparison.OrdinalIgnoreCase))
                    return element;
            }

            return default;
        }

        internal XElement Element(string name, string attributeName, string attributeValue)
        {
            foreach (XElement element in _element.Elements())
            {
                if (string.Equals(element.Name.LocalName, name, StringComparison.OrdinalIgnoreCase)
                    && element.Attribute(attributeName)?.Value == attributeValue)
                {
                    return element;
                }
            }

            return default;
        }

        public IEnumerable<XElement> Elements(string name)
        {
            foreach (XElement element in _element.Elements())
            {
                if (string.Equals(element.Name.LocalName, name, StringComparison.OrdinalIgnoreCase))
                    yield return element;
            }
        }

        public bool HasElement(string name)
        {
            return Element(name) != null;
        }

        public string GetInnerXml()
        {
            using (XmlReader reader = _element.CreateReader())
            {
                if (reader.Read()
                    && reader.NodeType == XmlNodeType.Element
                    && reader.Name == "member"
                    && reader.Read()
                    && reader.NodeType == XmlNodeType.Text
                    && reader.Read()
                    && reader.NodeType == XmlNodeType.Element)
                {
                    return reader.ReadOuterXml();
                }
            }

            Debug.Fail(_element.ToString());

            return null;
        }
    }
}
