// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    internal sealed class SymbolHierarchy
    {
        private SymbolHierarchy(SymbolHierarchyItem root)
        {
            Root = root;
        }

        public SymbolHierarchyItem Root { get; }

        public static SymbolHierarchy Create(IEnumerable<INamedTypeSymbol> types, IComparer<INamedTypeSymbol> comparer = null)
        {
            if (comparer == null)
                comparer = SymbolDefinitionComparer.SystemNamespaceFirstInstance;

            INamedTypeSymbol objectType = FindObjectType();

            if (objectType == null)
                throw new InvalidOperationException("Object type not found.");

            var allTypes = new HashSet<INamedTypeSymbol>(types) { objectType };

            foreach (INamedTypeSymbol type in types)
            {
                INamedTypeSymbol t = type.BaseType;

                while (t != null)
                {
                    allTypes.Add(t.OriginalDefinition);
                    t = t.BaseType;
                }
            }

            SymbolHierarchyItem root = CreateHierarchyItem(objectType, null);

            return new SymbolHierarchy(root);

            SymbolHierarchyItem CreateHierarchyItem(INamedTypeSymbol baseType, SymbolHierarchyItem parent)
            {
                var item = new SymbolHierarchyItem(baseType) { Parent = parent };

                allTypes.Remove(baseType);

                INamedTypeSymbol[] derivedTypes = allTypes
                    .Where(f => f.BaseType?.OriginalDefinition == baseType.OriginalDefinition || f.Interfaces.Any(i => i.OriginalDefinition == baseType.OriginalDefinition))
                    .ToArray();

                if (derivedTypes.Length > 0)
                {
                    Array.Sort(derivedTypes, comparer);

                    SymbolHierarchyItem last = CreateHierarchyItem(derivedTypes[derivedTypes.Length - 1], item);

                    SymbolHierarchyItem next = last;

                    SymbolHierarchyItem child = null;

                    for (int i = derivedTypes.Length - 2; i >= 0; i--)
                    {
                        child = CreateHierarchyItem(derivedTypes[i], item);

                        child.next = next;

                        next = child;
                    }

                    last.next = child ?? last;

                    item.lastChild = last;
                }

                return item;
            }

            INamedTypeSymbol FindObjectType()
            {
                foreach (INamedTypeSymbol type in types)
                {
                    INamedTypeSymbol t = type;

                    do
                    {
                        if (t.SpecialType == SpecialType.System_Object)
                            return t;

                        t = t.BaseType;
                    }
                    while (t != null);
                }

                return null;
            }
        }
    }
}
