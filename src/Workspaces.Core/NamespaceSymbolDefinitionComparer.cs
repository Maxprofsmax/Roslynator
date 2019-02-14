// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis;

namespace Roslynator
{
    internal sealed class NamespaceSymbolDefinitionComparer : IComparer<INamespaceSymbol>
    {
        public static NamespaceSymbolDefinitionComparer Instance { get; } = new NamespaceSymbolDefinitionComparer(systemNamespaceFirst: false);

        public static NamespaceSymbolDefinitionComparer SystemNamespaceFirstInstance { get; } = new NamespaceSymbolDefinitionComparer(systemNamespaceFirst: true);

        public bool SystemNamespaceFirst { get; }

        internal NamespaceSymbolDefinitionComparer(bool systemNamespaceFirst = false)
        {
            SystemNamespaceFirst = systemNamespaceFirst;
        }

        public static NamespaceSymbolDefinitionComparer GetInstance(bool systemNamespaceFirst)
        {
            return (systemNamespaceFirst) ? SystemNamespaceFirstInstance : Instance;
        }

        public int Compare(INamespaceSymbol x, INamespaceSymbol y)
        {
            if (object.ReferenceEquals(x, y))
                return 0;

            if (x == null)
                return -1;

            if (y == null)
                return 1;

            if (x.IsGlobalNamespace)
            {
                return (y.IsGlobalNamespace) ? 0 : -1;
            }
            else if (y.IsGlobalNamespace)
            {
                return 1;
            }

            int count1 = CountContainingNamespaces(x);
            int count2 = CountContainingNamespaces(y);

            if (SystemNamespaceFirst)
            {
                INamespaceSymbol namespaceSymbol1 = GetNamespaceSymbol(x, count1);
                INamespaceSymbol namespaceSymbol2 = GetNamespaceSymbol(y, count2);

                if (namespaceSymbol1.Name == "System")
                {
                    if (namespaceSymbol2.Name != "System")
                        return -1;
                }
                else if (namespaceSymbol2.Name == "System")
                {
                    return 1;
                }
            }

            while (true)
            {
                INamespaceSymbol namespaceSymbol1 = GetNamespaceSymbol(x, count1);
                INamespaceSymbol namespaceSymbol2 = GetNamespaceSymbol(y, count2);

                int diff = SymbolDefinitionComparer.CompareName(namespaceSymbol1, namespaceSymbol2);

                if (diff != 0)
                    return diff;

                if (count1 == 0)
                    return (count2 == 0) ? 0 : -1;

                if (count2 == 0)
                    return 1;

                count1--;
                count2--;
            }

            int CountContainingNamespaces(INamespaceSymbol namespaceSymbol)
            {
                int count = 0;

                while (true)
                {
                    namespaceSymbol = namespaceSymbol.ContainingNamespace;

                    if (namespaceSymbol.IsGlobalNamespace)
                        break;

                    count++;
                }

                return count;
            }

            INamespaceSymbol GetNamespaceSymbol(INamespaceSymbol namespaceSymbol, int count)
            {
                while (count > 0)
                {
                    namespaceSymbol = namespaceSymbol.ContainingNamespace;
                    count--;
                }

                return namespaceSymbol;
            }
        }
    }
}
