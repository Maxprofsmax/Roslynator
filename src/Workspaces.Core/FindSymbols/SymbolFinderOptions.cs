// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace Roslynator.FindSymbols
{
    internal class SymbolFinderOptions
    {
        public SymbolFinderOptions(
            SymbolGroups symbolGroups = SymbolGroups.TypeOrMember,
            VisibilityFilter visibilityFilter = default,
            ImmutableArray<MetadataName> ignoredAttributes = default,
            bool ignoreObsolete = false,
            bool ignoreGeneratedCode = false,
            bool unusedOnly = false)
        {
            SymbolGroups = symbolGroups;
            VisibilityFilter = visibilityFilter;
            IgnoredAttributes = (!ignoredAttributes.IsDefault) ? ignoredAttributes : ImmutableArray<MetadataName>.Empty;
            IgnoreGeneratedCode = ignoreGeneratedCode;
            UnusedOnly = unusedOnly;
            IgnoreObsolete = ignoreObsolete;
        }

        public static SymbolFinderOptions Default { get; } = new SymbolFinderOptions();

        public SymbolGroups SymbolGroups { get; }

        public VisibilityFilter VisibilityFilter{ get; }

        public bool IgnoreObsolete { get; }

        public bool IgnoreGeneratedCode { get; }

        public bool UnusedOnly { get; }

        public ImmutableArray<MetadataName> IgnoredAttributes { get; }

        public bool IsVisible(ISymbol symbol)
        {
            return symbol.IsVisible(VisibilityFilter);
        }

        public bool HasIgnoredAttribute(ISymbol symbol)
        {
            if (IgnoredAttributes.Any())
            {
                foreach (AttributeData attribute in symbol.GetAttributes())
                {
                    foreach (MetadataName attributeName in IgnoredAttributes)
                    {
                        if (attribute.AttributeClass.HasMetadataName(attributeName))
                            return true;
                    }
                }
            }

            return false;
        }
    }
}
