// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace Roslynator
{
    internal class SymbolDefinitionComparer : IComparer<ISymbol>
    {
        public static SymbolDefinitionComparer Instance { get; } = new SymbolDefinitionComparer(systemNamespaceFirst: false);

        public static SymbolDefinitionComparer SystemNamespaceFirstInstance { get; } = new SymbolDefinitionComparer(systemNamespaceFirst: true);

        public bool SystemNamespaceFirst { get; }

        internal SymbolDefinitionComparer(bool systemNamespaceFirst = false)
        {
            SystemNamespaceFirst = systemNamespaceFirst;
        }

        public static SymbolDefinitionComparer GetInstance(bool systemNamespaceFirst)
        {
            return (systemNamespaceFirst) ? SystemNamespaceFirstInstance : Instance;
        }

        public int Compare(ISymbol x, ISymbol y)
        {
            if (object.ReferenceEquals(x, y))
                return 0;

            if (x == null)
                return -1;

            if (y == null)
                return 1;

            switch (x.Kind)
            {
                case SymbolKind.Namespace:
                    {
                        var namespaceSymbol = (INamespaceSymbol)x;

                        switch (y.Kind)
                        {
                            case SymbolKind.Namespace:
                                return NamespaceSymbolDefinitionComparer.GetInstance(SystemNamespaceFirst).Compare(namespaceSymbol, (INamespaceSymbol)y);
                            case SymbolKind.NamedType:
                            case SymbolKind.Event:
                            case SymbolKind.Field:
                            case SymbolKind.Method:
                            case SymbolKind.Property:
                                return -CompareSymbolAndNamespaceSymbol(y, namespaceSymbol);
                        }

                        break;
                    }
                case SymbolKind.NamedType:
                    {
                        var typeSymbol = (INamedTypeSymbol)x;

                        switch (y.Kind)
                        {
                            case SymbolKind.Namespace:
                                return CompareSymbolAndNamespaceSymbol(typeSymbol, (INamespaceSymbol)y);
                            case SymbolKind.NamedType:
                                return CompareNamedTypeSymbol(typeSymbol, (INamedTypeSymbol)y);
                            case SymbolKind.Event:
                            case SymbolKind.Field:
                            case SymbolKind.Method:
                            case SymbolKind.Property:
                                return -CompareSymbolAndNamedTypeSymbol(y, typeSymbol);
                        }

                        break;
                    }
                case SymbolKind.Event:
                case SymbolKind.Field:
                case SymbolKind.Method:
                case SymbolKind.Property:
                    {
                        switch (y.Kind)
                        {
                            case SymbolKind.Namespace:
                                return CompareSymbolAndNamespaceSymbol(x, (INamespaceSymbol)y);
                            case SymbolKind.NamedType:
                                return CompareSymbolAndNamedTypeSymbol(x, (INamedTypeSymbol)y);
                            case SymbolKind.Event:
                            case SymbolKind.Field:
                            case SymbolKind.Method:
                            case SymbolKind.Property:
                                return CompareMemberSymbol(x, y);
                        }

                        break;
                    }
            }

            throw new InvalidOperationException();
        }

        private int CompareNamedTypeSymbol(INamedTypeSymbol typeSymbol1, INamedTypeSymbol typeSymbol2)
        {
            int diff = NamespaceSymbolDefinitionComparer.GetInstance(SystemNamespaceFirst).Compare(typeSymbol1.ContainingNamespace, typeSymbol2.ContainingNamespace);

            if (diff != 0)
                return diff;

            return NamedTypeSymbolDefinitionComparer.Instance.Compare(typeSymbol1, typeSymbol2);
        }

        private int CompareMemberSymbol(ISymbol symbol1, ISymbol symbol2)
        {
            int diff = CompareNamedTypeSymbol(symbol1.ContainingType, symbol2.ContainingType);

            if (diff != 0)
                return diff;

            return MemberSymbolDefinitionComparer.Instance.Compare(symbol1, symbol2);
        }

        private int CompareSymbolAndNamespaceSymbol(ISymbol symbol, INamespaceSymbol namespaceSymbol)
        {
            int diff = NamespaceSymbolDefinitionComparer.GetInstance(SystemNamespaceFirst).Compare(symbol.ContainingNamespace, namespaceSymbol);

            if (diff != 0)
                return diff;

            return 1;
        }

        private static int CompareSymbolAndNamedTypeSymbol(ISymbol symbol, INamedTypeSymbol typeSymbol)
        {
            int diff = NamedTypeSymbolDefinitionComparer.Instance.Compare(symbol.ContainingType, typeSymbol);

            if (diff != 0)
                return diff;

            return 1;
        }

        public static int CompareName(ISymbol symbol1, ISymbol symbol2)
        {
            return string.Compare(symbol1.Name, symbol2.Name, StringComparison.Ordinal);
        }
    }
}
