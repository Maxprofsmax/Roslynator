// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using DotMarkdown;
using Microsoft.CodeAnalysis;
using Roslynator.Documentation;
using static Roslynator.Logger;

namespace Roslynator.CommandLine
{
    internal class ListSymbolsCommand : MSBuildWorkspaceCommand
    {
        public ListSymbolsCommand(
            ListSymbolsCommandLineOptions options,
            SymbolFilterOptions symbolFilterOptions,
            string rootDirectoryUrl,
            in ProjectFilter projectFilter) : base(projectFilter)
        {
            Options = options;
            SymbolFilterOptions = symbolFilterOptions;
            RootDirectoryUrl = rootDirectoryUrl;
        }

        public ListSymbolsCommandLineOptions Options { get; }

        public SymbolFilterOptions SymbolFilterOptions { get; }

        public string RootDirectoryUrl { get; }

        public override async Task<CommandResult> ExecuteAsync(ProjectOrSolution projectOrSolution, CancellationToken cancellationToken = default)
        {
            AssemblyResolver.Register();

            var format = new DefinitionListFormat(
                omitContainingNamespace: Options.OmitContainingNamespace,
                indentChars: Options.IndentChars,
                nestNamespaces: Options.NestNamespaces,
                emptyLineBetweenMembers: Options.EmptyLineBetweenMembers,
                formatAttributes: Options.FormatAttributes,
                formatParameters: Options.FormatParameters,
                formatBaseList: Options.FormatBaseList,
                formatConstraints: Options.FormatConstraints,
                includeAttributeArguments: !Options.NoAttributeArguments,
                omitIEnumerable: true,
                assemblyAttributes: Options.AssemblyAttributes);

            ImmutableArray<Compilation> compilations = await GetCompilationsAsync(projectOrSolution, cancellationToken);

            string text = null;

            SymbolDefinitionComparer comparer = SymbolDefinitionComparer.SystemNamespaceFirstInstance;

            IEnumerable<IAssemblySymbol> assemblies = compilations.Select(f => f.Assembly);

            using (var stringWriter = new StringWriter())
            {
                DefinitionListWriter writer = new DefinitionListTextWriter(
                    stringWriter,
                    filter: SymbolFilterOptions,
                    format: format,
                    comparer: comparer);

                writer.WriteAssemblies(assemblies);

                text = stringWriter.ToString();
            }

            WriteLine(Verbosity.Minimal);
            WriteLine(text, Verbosity.Minimal);

            foreach (string path in Options.Output)
            {
                WriteLine($"Save '{path}'", ConsoleColor.DarkGray, Verbosity.Diagnostic);

                string extension = Path.GetExtension(path);

                if (string.Equals(extension, ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    var xmlWriterSettings = new XmlWriterSettings() { Indent = true, IndentChars = Options.IndentChars };
#if DEBUG
                    using (XmlWriter xmlWriter = XmlWriter.Create(ConsoleOut, xmlWriterSettings))
                    {
                        DefinitionListWriter writer = new DefinitionListXmlWriter(xmlWriter, SymbolFilterOptions, format, comparer);

                        writer.WriteDocument(assemblies);
                    }

                    WriteLine();
#endif
                    using (XmlWriter xmlWriter = XmlWriter.Create(path, xmlWriterSettings))
                    {
                        DefinitionListWriter writer = new DefinitionListXmlWriter(xmlWriter, SymbolFilterOptions, format, comparer);

                        writer.WriteDocument(assemblies);
                    }
                }
                else if (string.Equals(extension, ".md", StringComparison.OrdinalIgnoreCase))
                {
                    var markdownWriterSettings = new MarkdownWriterSettings();
#if DEBUG
                    using (MarkdownWriter markdownWriter = MarkdownWriter.Create(ConsoleOut, markdownWriterSettings))
                    {
                        DefinitionListWriter writer = new DefinitionListMarkdownWriter(markdownWriter, SymbolFilterOptions, format, comparer, RootDirectoryUrl);

                        writer.WriteDocument(assemblies);
                    }

                    WriteLine();
#endif
                    using (var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read))
                    using (MarkdownWriter markdownWriter = MarkdownWriter.Create(fileStream, markdownWriterSettings))
                    {
                        DefinitionListWriter writer = new DefinitionListMarkdownWriter(markdownWriter, SymbolFilterOptions, format, comparer, RootDirectoryUrl);

                        writer.WriteDocument(assemblies);
                    }
                }
                else
                {
                    File.WriteAllText(path, text, Encoding.UTF8);
                }
            }

            if (ShouldWrite(Verbosity.Normal))
                WriteSummary(assemblies, SymbolFilterOptions, Verbosity.Normal);

            return CommandResult.Success;
        }

        private static void WriteSummary(IEnumerable<IAssemblySymbol> assemblies, SymbolFilterOptions filter, Verbosity verbosity)
        {
            WriteLine(verbosity);

            WriteLine($"{assemblies.Count()} assemblies", verbosity);

            INamedTypeSymbol[] types = assemblies
                .SelectMany(a => a.GetTypes(t => filter.IsVisibleType(t)))
                .ToArray();

            IEnumerable<INamespaceSymbol> namespaces = types
                .Select(f => f.ContainingNamespace)
                .Distinct(MetadataNameEqualityComparer<INamespaceSymbol>.Instance)
                .Where(f => filter.IsVisibleNamespace(f));

            WriteLine($"  {namespaces.Count()} namespaces", verbosity);

            WriteLine($"    {types.Length} types", verbosity);

            foreach (IGrouping<SymbolGroup, INamedTypeSymbol> grouping in types.GroupBy(f => f.GetSymbolGroup()))
            {
                WriteLine($"      {grouping.Count()} {grouping.Key.GetPluralText()}", verbosity);
            }

            WriteLine(verbosity);

            ISymbol[] members = types
                .Where(f => f.TypeKind.Is(TypeKind.Class, TypeKind.Struct, TypeKind.Interface))
                .SelectMany(t => t.GetMembers().Where(m => filter.IsVisibleMember(m)))
                .ToArray();

            WriteLine($"    {members.Length} members", verbosity);

            foreach (IGrouping<SymbolGroup, ISymbol> grouping in members.GroupBy(f => f.GetSymbolGroup()))
            {
                WriteLine($"      {grouping.Count()} {grouping.Key.GetPluralText()}", verbosity);
            }

            WriteLine(verbosity);
        }
    }
}
