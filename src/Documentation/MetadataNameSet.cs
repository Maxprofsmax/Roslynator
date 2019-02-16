// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    internal class MetadataNameSet
    {
        public ImmutableArray<MetadataName> Values { get; }

        private readonly Dictionary<string, ImmutableArray<MetadataName>> _valuesByName;

        public MetadataNameSet(IEnumerable<string> values)
            : this(values.Select(f => MetadataName.Parse(f)))
        {
        }

        public MetadataNameSet(IEnumerable<MetadataName> values)
        {
            Values = values.ToImmutableArray();

            _valuesByName = Values
                .GroupBy(f => f.Name)
                .ToDictionary(f => f.Key, f => f.ToImmutableArray());
        }

        public bool Contains(ISymbol symbol)
        {
            if (_valuesByName.TryGetValue(symbol.Name, out ImmutableArray<MetadataName> names))
            {
                foreach (MetadataName name in names)
                {
                    if (symbol.HasMetadataName(name))
                        return true;
                }
            }

            return false;
        }
    }
}
