// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Roslynator
{
    [Flags]
    internal enum SymbolGroupFilter
    {
        None = 0,
        Namespace = 1,
        Class = 2,
        Delegate = 4,
        Enum = 8,
        Interface = 16,
        Struct = 32,
        Type = Class | Delegate | Enum | Interface | Struct,
        NamespaceOrType = Namespace | Type,
        Event = 64,
        Field = 128,
        Const = 256,
        Method = 512,
        Property = 1024,
        Indexer = 2048,
        Member = Event | Field | Const | Method | Property | Indexer,
        TypeOrMember = Type | Member,
        NamespaceOrTypeOrMember = Namespace | Type | Member
    }
}
