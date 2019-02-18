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
using Roslynator.Documentation.Markdown;
using Roslynator.Documentation.Xml;
using static Roslynator.Logger;

namespace Roslynator.CommandLine
{
    internal class TypeHierarchyCommand : MSBuildWorkspaceCommand
    {
        public TypeHierarchyCommand(
            TypeHierarchyCommandLineOptions options,
            SymbolFilterOptions symbolFilterOptions,
            string rootDirectoryUrl,
            in ProjectFilter projectFilter) : base(projectFilter)
        {
            Options = options;
            SymbolFilterOptions = symbolFilterOptions;
            RootDirectoryUrl = rootDirectoryUrl;
        }

        public TypeHierarchyCommandLineOptions Options { get; }

        public SymbolFilterOptions SymbolFilterOptions { get; }

        public string RootDirectoryUrl { get; }

        public override async Task<CommandResult> ExecuteAsync(ProjectOrSolution projectOrSolution, CancellationToken cancellationToken = default)
        {
            AssemblyResolver.Register();

            var format = new DefinitionListFormat(
                omitContainingNamespace: Options.OmitContainingNamespace,
                indentChars: Options.IndentChars,
                includeAttributes: false,
                includeAssemblyAttributes: false,
                formatAttributes: Options.FormatAttributes,
                includeAttributeArguments: !Options.NoAttributeArguments,
                omitIEnumerable: true);

            ImmutableArray<Compilation> compilations = await GetCompilationsAsync(projectOrSolution, cancellationToken);

            SymbolDefinitionComparer comparer = SymbolDefinitionComparer.SystemNamespaceFirstInstance;

            IEnumerable<IAssemblySymbol> assemblies = compilations.Select(f => f.Assembly);

            HashSet<IAssemblySymbol> externalAssemblies = null;

            foreach (string reference in Options.References)
            {
                IAssemblySymbol externalAssembly = FindExternalAssembly(compilations, reference);

                if (externalAssembly == null)
                {
                    WriteLine($"Cannot find external assembly '{reference}'", Verbosity.Quiet);
                    return CommandResult.Fail;
                }

                (externalAssemblies ?? (externalAssemblies = new HashSet<IAssemblySymbol>())).Add(externalAssembly);
            }

            if (externalAssemblies != null)
                assemblies = assemblies.Concat(externalAssemblies);

            SymbolHierarchy hierarchy = SymbolHierarchy.Create(assemblies, SymbolFilterOptions);

#if DEBUG
            SymbolDefinitionWriter textWriter = new SymbolHierarchyTextWriter(
                ConsoleOut,
                filter: SymbolFilterOptions,
                format: format,
                comparer: comparer);

            var hierarchyWriter2 = new SymbolHierarchyWriter(textWriter);

            hierarchyWriter2.WriteTypeHierarchy(hierarchy);

            WriteLine();

            using (XmlWriter xmlWriter = XmlWriter.Create(ConsoleOut, new XmlWriterSettings() { Indent = true, IndentChars = Options.IndentChars }))
            {
                SymbolDefinitionWriter writer = new SymbolHierarchyXmlWriter(xmlWriter, SymbolFilterOptions, format, new SymbolDocumentationProvider(compilations), comparer);

                var hierarchyWriter = new SymbolHierarchyWriter(writer);

                hierarchyWriter.WriteTypeHierarchy(hierarchy);
            }

            WriteLine();

            using (MarkdownWriter markdownWriter = MarkdownWriter.Create(ConsoleOut))
            {
                SymbolDefinitionWriter writer = new SymbolHierarchyMarkdownWriter(markdownWriter, SymbolFilterOptions, format, comparer, RootDirectoryUrl);

                var hierarchyWriter = new SymbolHierarchyWriter(writer);

                hierarchyWriter.WriteTypeHierarchy(hierarchy);
            }

            WriteLine();
#endif
            string text = null;

            using (var stringWriter = new StringWriter())
            {
                SymbolDefinitionWriter writer = new SymbolHierarchyTextWriter(
                    stringWriter,
                    filter: SymbolFilterOptions,
                    format: format,
                    comparer: comparer);

                var hierarchyWriter = new SymbolHierarchyWriter(writer);

                hierarchyWriter.WriteTypeHierarchy(hierarchy);

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
                    SymbolDocumentationProvider documentationProvider = (Options.IncludeDocumentation)
                        ? new SymbolDocumentationProvider(compilations)
                        : null;

                    var xmlWriterSettings = new XmlWriterSettings() { Indent = true, IndentChars = Options.IndentChars };

                    using (XmlWriter xmlWriter = XmlWriter.Create(path, xmlWriterSettings))
                    {
                        SymbolDefinitionWriter writer = new SymbolHierarchyXmlWriter(xmlWriter, SymbolFilterOptions, format, documentationProvider, comparer);

                        var hierarchyWriter = new SymbolHierarchyWriter(writer);

                        hierarchyWriter.WriteTypeHierarchy(hierarchy);
                    }
                }
                else if (string.Equals(extension, ".md", StringComparison.OrdinalIgnoreCase))
                {
                    var markdownWriterSettings = new MarkdownWriterSettings();

                    using (var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read))
                    using (var streamWriter = new StreamWriter(fileStream, Encodings.UTF8NoBom))
                    using (MarkdownWriter markdownWriter = MarkdownWriter.Create(streamWriter, markdownWriterSettings))
                    {
                        SymbolDefinitionWriter writer = new SymbolHierarchyMarkdownWriter(markdownWriter, SymbolFilterOptions, format, comparer, RootDirectoryUrl);

                        var hierarchyWriter = new SymbolHierarchyWriter(writer);

                        hierarchyWriter.WriteTypeHierarchy(hierarchy);
                    }
                }
                else
                {
                    File.WriteAllText(path, text, Encoding.UTF8);
                }
            }

            return CommandResult.Success;
        }

        private static IAssemblySymbol FindExternalAssembly(IEnumerable<Compilation> compilations, string path)
        {
            foreach (Compilation compilation in compilations)
            {
                foreach (MetadataReference externalReference in compilation.ExternalReferences)
                {
                    if (externalReference is PortableExecutableReference reference)
                    {
                        if (string.Equals(path, reference.FilePath, StringComparison.OrdinalIgnoreCase)
                            || string.Equals(path, Path.GetFileName(reference.FilePath), StringComparison.OrdinalIgnoreCase))
                        {
                            return compilation.GetAssemblyOrModuleSymbol(reference) as IAssemblySymbol;
                        }
                    }
                }
            }

            return null;
        }
    }
}
