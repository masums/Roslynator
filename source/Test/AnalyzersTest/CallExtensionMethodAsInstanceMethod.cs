﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Linq;
using System.Collections.Generic;
using static Roslynator.CSharp.Analyzers.Test.CallExtensionMethodAsInstanceMethodRefactoring;

#pragma warning disable RCS1060, RCS1176, RCS1177

namespace Roslynator.CSharp.Analyzers.Test
{
    internal static class CallExtensionMethodAsInstanceMethodRefactoring2
    {
        public static void Method(string parameter1, string parameter2)
        {
            CallExtensionMethodAsInstanceMethodRefactoring.ExtensionMethod(parameter1, parameter2);
            Roslynator.CSharp.Analyzers.Test.CallExtensionMethodAsInstanceMethodRefactoring.ExtensionMethod(parameter1, parameter2);
            parameter1.ExtensionMethod(parameter2);

            IEnumerable<int> items = Enumerable.Select(Enumerable.Range(0, 1), f => f);
        }

        internal static IEnumerable<TResult> Select<TResult, TSource>(this IEnumerable<TSource> items, Func<TSource, TResult> selector)
        {
            foreach (TSource item in items)
                yield return selector(item);
        }
    }

    internal static class CallExtensionMethodAsInstanceMethodRefactoring
    {
        public static void ExtensionMethod(this string parameter1, string parameter2)
        {
            ExtensionMethod(parameter1, parameter2);
            CallExtensionMethodAsInstanceMethodRefactoring.ExtensionMethod(parameter1, parameter2);
            Roslynator.CSharp.Analyzers.Test.CallExtensionMethodAsInstanceMethodRefactoring.ExtensionMethod(parameter1, parameter2);
            parameter1.ExtensionMethod(parameter2);

            IEnumerable<int> items = Enumerable.Select(Enumerable.Range(0, 1), f => f);
        }

        internal static IEnumerable<TResult> Select<TResult, TSource>(this IEnumerable<TSource> items, Func<TSource, TResult> selector)
        {
            foreach (TSource item in items)
                yield return selector(item);
        }
    }
}