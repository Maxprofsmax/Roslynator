// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using CommandLine;

namespace Roslynator.CommandLine
{
#if DEBUG
    [Verb("find-symbols", HelpText = "Finds symbols in the specified project or solution.")]
#endif
    public class FindSymbolsCommandLineOptions : MSBuildCommandLineOptions
    {
        [Option(longName: "ignored-attributes")]
        public IEnumerable<string> IgnoredAttributes { get; set; }

        [Option(longName: "ignore-obsolete")]
        public bool IgnoreObsolete { get; set; }

        [Option(longName: "ignored-symbols")]
        public IEnumerable<string> IgnoredSymbols { get; set; }

        [Option(longName: "ignore-generated-code")]
        public bool IgnoreGeneratedCode { get; set; }

        [Option(longName: ParameterNames.SymbolGroupFilter)]
        public IEnumerable<string> SymbolGroupFilter { get; set; }

        [Option(longName: "unused-only")]
        public bool UnusedOnly { get; set; }

        [Option(longName: ParameterNames.Visibility)]
        public IEnumerable<string> Visibility { get; set; }
    }
}
