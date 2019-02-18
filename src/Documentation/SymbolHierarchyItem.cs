// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    internal class SymbolHierarchyItem
    {
        internal SymbolHierarchyItem lastChild;
        internal SymbolHierarchyItem next;

        internal SymbolHierarchyItem(INamedTypeSymbol symbol, bool isExternal = false)
        {
            Symbol = symbol;
            IsExternal = isExternal;
        }

        public INamedTypeSymbol Symbol { get; }

        public SymbolHierarchyItem Parent { get; internal set; }

        public bool IsExternal { get; }

        public int Depth
        {
            get
            {
                int depth = 0;

                SymbolHierarchyItem parent = Parent;

                while (parent != null)
                {
                    depth++;
                    parent = parent.Parent;
                }

                return depth;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay
        {
            get { return $"{Symbol.ToDisplayString(Roslynator.SymbolDisplayFormats.Test)}"; }
        }

        public IEnumerable<SymbolHierarchyItem> Children()
        {
            SymbolHierarchyItem e = lastChild;

            if (e != null)
            {
                do
                {
                    e = e.next;
                    yield return e;

                } while (e.Parent == this && e != lastChild);
            }
        }

        public IEnumerable<SymbolHierarchyItem> Ancestors()
        {
            return GetAncestors(self: false);
        }

        public IEnumerable<SymbolHierarchyItem> AncestorsAndSelf()
        {
            return GetAncestors(self: true);
        }

        internal IEnumerable<SymbolHierarchyItem> GetAncestors(bool self)
        {
            SymbolHierarchyItem c = ((self) ? this : Parent);

            while (c != null)
            {
                yield return c;

                c = c.Parent;
            }
        }

        public IEnumerable<SymbolHierarchyItem> Descendants()
        {
            return GetDescendants(self: false);
        }

        public IEnumerable<SymbolHierarchyItem> DescendantsAndSelf()
        {
            return GetDescendants(self: true);
        }

        internal IEnumerable<SymbolHierarchyItem> GetDescendants(bool self)
        {
            var e = this;

            if (self)
                yield return e;

            var c = this;

            while (true)
            {
                SymbolHierarchyItem first = c?.lastChild?.next;

                if (first != null)
                {
                    e = first;
                }
                else
                {
                    while (e != this
                        && e == e.Parent.lastChild)
                    {
                        e = e.Parent;
                    }

                    if (e == this)
                        break;

                    e = e.next;
                }

                if (e != null)
                    yield return e;

                c = e;
            }
        }
    }
}
