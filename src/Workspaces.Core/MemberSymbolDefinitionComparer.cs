// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis;

namespace Roslynator
{
    internal sealed class MemberSymbolDefinitionComparer : IComparer<ISymbol>
    {
        public static MemberSymbolDefinitionComparer Instance { get; } = new MemberSymbolDefinitionComparer();

        public int Compare(ISymbol x, ISymbol y)
        {
            Debug.Assert(x.IsKind(SymbolKind.Event, SymbolKind.Field, SymbolKind.Method, SymbolKind.Property), x.Kind.ToString());
            Debug.Assert(y.IsKind(SymbolKind.Event, SymbolKind.Field, SymbolKind.Method, SymbolKind.Property), y.Kind.ToString());

            if (object.ReferenceEquals(x, y))
                return 0;

            if (x == null)
                return -1;

            if (y == null)
                return 1;

            MemberDeclarationKind kind1 = x.GetMemberDeclarationKind();
            MemberDeclarationKind kind2 = y.GetMemberDeclarationKind();

            int diff = ((int)kind1).CompareTo((int)kind2);

            if (diff != 0)
                return diff;

            diff = SymbolDefinitionComparer.CompareName(x, y);

            if (diff != 0)
                return diff;

            switch (kind1)
            {
                case MemberDeclarationKind.Constructor:
                case MemberDeclarationKind.OrdinaryMethod:
                    {
                        var methodSymbol1 = (IMethodSymbol)x;
                        var methodSymbol2 = (IMethodSymbol)y;

                        diff = methodSymbol1.TypeParameters.Length.CompareTo(methodSymbol2.TypeParameters.Length);

                        if (diff != 0)
                            return diff;

                        return CompareParameters(methodSymbol1.Parameters, methodSymbol2.Parameters);
                    }
                case MemberDeclarationKind.Indexer:
                case MemberDeclarationKind.Property:
                    {
                        var propertySymbol1 = (IPropertySymbol)x;
                        var propertySymbol2 = (IPropertySymbol)y;

                        return CompareParameters(propertySymbol1.Parameters, propertySymbol2.Parameters);
                    }
            }

            return 0;
        }

        private static int CompareParameters(ImmutableArray<IParameterSymbol> parameters1, ImmutableArray<IParameterSymbol> parameters2)
        {
            int length = parameters1.Length;

            int diff = length.CompareTo(parameters2.Length);

            if (diff != 0)
                return diff;

            for (int i = 0; i < length; i++)
            {
                diff = CompareParameter(parameters1[i], parameters2[i]);

                if (diff != 0)
                    return diff;
            }

            return 0;
        }

        private static int CompareParameter(IParameterSymbol x, IParameterSymbol y)
        {
            if (object.ReferenceEquals(x, y))
                return 0;

            if (x == null)
                return -1;

            if (y == null)
                return 1;

            int diff = ((int)x.RefKind).CompareTo((int)y.RefKind);

            if (diff != 0)
                return diff;

            return SymbolDefinitionComparer.CompareName(x, y);
        }
    }
}
