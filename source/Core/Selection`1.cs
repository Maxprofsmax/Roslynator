﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Text;

namespace Roslynator
{
    public abstract class Selection<T> : IReadOnlyList<T>
    {
        protected Selection(TextSpan span, int firstIndex, int lastIndex)
        {
            Span = span;
            FirstIndex = firstIndex;
            LastIndex = lastIndex;
        }

        protected abstract IReadOnlyList<T> List { get; }

        public virtual TextSpan Span { get; }

        public virtual int FirstIndex { get; }

        public virtual int LastIndex { get; }

        public int Count
        {
            get
            {
                if (Any())
                {
                    return LastIndex - FirstIndex + 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < FirstIndex
                    || index > LastIndex)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), index, "");
                }

                return List[index];
            }
        }

        public bool Any()
        {
            return FirstIndex != -1;
        }

        public T First()
        {
            return List[FirstIndex];
        }

        public T FirstOrDefault()
        {
            if (Any())
            {
                return List[FirstIndex];
            }
            else
            {
                return default(T);
            }
        }

        public T Last()
        {
            return List[LastIndex];
        }

        public T LastOrDefault()
        {
            if (Any())
            {
                return List[LastIndex];
            }
            else
            {
                return default(T);
            }
        }

        private IEnumerable<T> Enumerate()
        {
            if (Any())
            {
                for (int i = FirstIndex; i <= LastIndex; i++)
                    yield return List[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Enumerate().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
