// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Roslynator.Host.Mef;

namespace Roslynator.FindSymbols
{
    internal static class SymbolFinder
    {
        internal static async Task<ImmutableArray<ISymbol>> FindSymbolsAsync(
            Project project,
            SymbolFinderOptions options = null,
            IFindSymbolsProgress progress = null,
            CancellationToken cancellationToken = default)
        {
            Compilation compilation = await project.GetCompilationAsync(cancellationToken).ConfigureAwait(false);

            INamedTypeSymbol generatedCodeAttribute = compilation.GetTypeByMetadataName("System.CodeDom.Compiler.GeneratedCodeAttribute");

            ImmutableArray<ISymbol>.Builder symbols = null;

            var namespaceOrTypeSymbols = new Stack<INamespaceOrTypeSymbol>();

            namespaceOrTypeSymbols.Push(compilation.Assembly.GlobalNamespace);

            while (namespaceOrTypeSymbols.Count > 0)
            {
                INamespaceOrTypeSymbol namespaceOrTypeSymbol = namespaceOrTypeSymbols.Pop();

                foreach (ISymbol symbol in namespaceOrTypeSymbol.GetMembers())
                {
                    if (symbol.IsImplicitlyDeclared)
                        continue;

                    if (options.IgnoreObsolete
                        && symbol.HasAttribute(MetadataNames.System_ObsoleteAttribute))
                    {
                        continue;
                    }

                    SymbolKind kind = symbol.Kind;

                    if (kind == SymbolKind.Namespace)
                    {
                        namespaceOrTypeSymbols.Push((INamespaceSymbol)symbol);
                        continue;
                    }

                    bool isUnused = false;

                    if (!options.UnusedOnly
                        || UnusedSymbolUtility.CanBeUnusedSymbol(symbol))
                    {
                        if (IsMatch(symbol))
                        {
                            if (options.UnusedOnly)
                            {
                                isUnused = await UnusedSymbolUtility.IsUnusedSymbolAsync(symbol, project.Solution, cancellationToken).ConfigureAwait(false);
                            }

                            if (!options.UnusedOnly
                                || isUnused)
                            {
                                progress?.OnSymbolFound(symbol);

                                (symbols ?? (symbols = ImmutableArray.CreateBuilder<ISymbol>())).Add(symbol);
                            }
                        }
                    }

                    if (!isUnused
                        && kind == SymbolKind.NamedType)
                    {
                        namespaceOrTypeSymbols.Push((INamedTypeSymbol)symbol);
                    }
                }
            }

            return symbols?.ToImmutableArray() ?? ImmutableArray<ISymbol>.Empty;

            bool IsMatch(ISymbol symbol)
            {
                SymbolGroups symbolGroups = GetSymbolGroups(symbol);

                if ((options.SymbolGroups & symbolGroups) == 0)
                    return false;

                Visibility visibility = symbol.GetVisibility();

                Debug.Assert(visibility != Visibility.NotApplicable, $"{visibility} {symbol}");

                if (!options.IsVisible(symbol))
                    return false;

                if (options.HasIgnoredAttribute(symbol))
                    return false;

                if (options.IgnoreGeneratedCode
                    && GeneratedCodeUtility.IsGeneratedCode(symbol, generatedCodeAttribute, MefWorkspaceServices.Default.GetService<ISyntaxFactsService>(compilation.Language).IsComment, cancellationToken))
                {
                    return false;
                }

                return true;
            }
        }

        private static SymbolGroups GetSymbolGroups(ISymbol symbol)
        {
            switch (symbol.Kind)
            {
                case SymbolKind.NamedType:
                    {
                        var namedType = (INamedTypeSymbol)symbol;

                        switch (namedType.TypeKind)
                        {
                            case TypeKind.Class:
                                return SymbolGroups.Class;
                            case TypeKind.Delegate:
                                return SymbolGroups.Delegate;
                            case TypeKind.Enum:
                                return SymbolGroups.Enum;
                            case TypeKind.Interface:
                                return SymbolGroups.Interface;
                            case TypeKind.Struct:
                                return SymbolGroups.Struct;
                        }

                        Debug.Fail(namedType.TypeKind.ToString());
                        return SymbolGroups.None;
                    }
                case SymbolKind.Event:
                    {
                        return SymbolGroups.Event;
                    }
                case SymbolKind.Field:
                    {
                        return (((IFieldSymbol)symbol).IsConst)
                            ? SymbolGroups.Const
                            : SymbolGroups.Field;
                    }
                case SymbolKind.Method:
                    {
                        var methodSymbol = (IMethodSymbol)symbol;

                        switch (methodSymbol.MethodKind)
                        {
                            case MethodKind.Constructor:
                                {
                                    if (methodSymbol.ContainingType.TypeKind == TypeKind.Struct
                                        && !methodSymbol.Parameters.Any())
                                    {
                                        return SymbolGroups.None;
                                    }

                                    return SymbolGroups.Method;
                                }
                            case MethodKind.Conversion:
                            case MethodKind.UserDefinedOperator:
                            case MethodKind.Ordinary:
                                return SymbolGroups.Method;
                            case MethodKind.AnonymousFunction:
                            case MethodKind.DelegateInvoke:
                            case MethodKind.Destructor:
                            case MethodKind.EventAdd:
                            case MethodKind.EventRaise:
                            case MethodKind.EventRemove:
                            case MethodKind.ExplicitInterfaceImplementation:
                            case MethodKind.PropertyGet:
                            case MethodKind.PropertySet:
                            case MethodKind.ReducedExtension:
                            case MethodKind.StaticConstructor:
                            case MethodKind.BuiltinOperator:
                            case MethodKind.DeclareMethod:
                            case MethodKind.LocalFunction:
                                return SymbolGroups.None;
                        }

                        Debug.Fail(methodSymbol.MethodKind.ToString());

                        return SymbolGroups.None;
                    }
                case SymbolKind.Property:
                    {
                        return (((IPropertySymbol)symbol).IsIndexer)
                            ? SymbolGroups.Indexer
                            : SymbolGroups.Property;
                    }
            }

            Debug.Fail(symbol.Kind.ToString());
            return SymbolGroups.None;
        }
    }
}
