// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    internal sealed class SymbolHierarchy
    {
        private SymbolHierarchy(SymbolHierarchyItem root, SymbolHierarchyItem staticRoot)
        {
            Root = root;
            StaticRoot = staticRoot;
        }

        public SymbolHierarchyItem Root { get; }

        public SymbolHierarchyItem StaticRoot { get; }

        public static SymbolHierarchy Create(
            IEnumerable<IAssemblySymbol> assemblies,
            SymbolFilterOptions filter = null,
            IComparer<INamedTypeSymbol> comparer = null)
        {
            Func<INamedTypeSymbol, bool> predicate = null;

            if (filter != null)
            {
                predicate = t => filter.IsVisibleType(t)
                    && filter.IsVisibleNamespace(t.ContainingNamespace);
            }

            IEnumerable<INamedTypeSymbol> types = assemblies.SelectMany(a => a.GetTypes(predicate));

            return Create(types, comparer);
        }

        public static SymbolHierarchy Create(IEnumerable<INamedTypeSymbol> types, IComparer<INamedTypeSymbol> comparer = null)
        {
            if (comparer == null)
                comparer = SymbolDefinitionComparer.SystemNamespaceFirstInstance;

            INamedTypeSymbol objectType = FindObjectType();

            if (objectType == null)
                throw new InvalidOperationException("Object type not found.");

            Dictionary<INamedTypeSymbol, SymbolHierarchyItem> allItems = types
                .Where(f => !f.IsStatic)
                .ToDictionary(f => f, f => new  SymbolHierarchyItem(f));

            allItems[objectType] = new SymbolHierarchyItem(objectType, isExternal: true);

            foreach (INamedTypeSymbol type in types.Where(f => !f.IsStatic))
            {
                INamedTypeSymbol t = type.BaseType;

                while (t != null)
                {
                    if (!allItems.ContainsKey(t.OriginalDefinition))
                        allItems[t.OriginalDefinition] = new SymbolHierarchyItem(t.OriginalDefinition, isExternal: true);

                    t = t.BaseType;
                }
            }

            SymbolHierarchyItem root = FillHierarchyItem(allItems[objectType], null);

            SymbolHierarchyItem staticRoot = GetStaticRoot();

            return new SymbolHierarchy(root, staticRoot);

            SymbolHierarchyItem FillHierarchyItem(SymbolHierarchyItem item, SymbolHierarchyItem parent)
            {
                item.Parent = parent;

                allItems.Remove(item.Symbol);

                SymbolHierarchyItem[] derivedTypes = allItems
                    .Select(f => f.Value)
                    .Where(f => f.Symbol.BaseType?.OriginalDefinition == item.Symbol.OriginalDefinition
                        || f.Symbol.Interfaces.Any(i => i.OriginalDefinition == item.Symbol.OriginalDefinition))
                    .OrderBy(f => f.Symbol, comparer)
                    .ToArray();

                if (derivedTypes.Length > 0)
                {
                    SymbolHierarchyItem last = FillHierarchyItem(derivedTypes[derivedTypes.Length - 1], item);

                    SymbolHierarchyItem next = last;

                    SymbolHierarchyItem child = null;

                    for (int i = derivedTypes.Length - 2; i >= 0; i--)
                    {
                        child = FillHierarchyItem(derivedTypes[i], item);

                        child.next = next;

                        next = child;
                    }

                    last.next = child ?? last;

                    item.lastChild = last;
                }

                return item;
            }

            SymbolHierarchyItem GetStaticRoot()
            {
                var item = new SymbolHierarchyItem(null);

                using (IEnumerator<INamedTypeSymbol> en = types
                    .Where(f => f.IsStatic)
                    .OrderByDescending(f => f, comparer)
                    .GetEnumerator())
                {
                    if (en.MoveNext())
                    {
                        var last = new SymbolHierarchyItem(en.Current) { Parent = item };

                        SymbolHierarchyItem next = last;

                        SymbolHierarchyItem child = null;

                        while (en.MoveNext())
                        {
                            child = new SymbolHierarchyItem(en.Current) { Parent = item, next = next };

                            next = child;
                        }

                        last.next = child ?? last;

                        item.lastChild = last;
                    }
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
