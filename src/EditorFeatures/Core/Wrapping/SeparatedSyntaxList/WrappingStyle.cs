﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.


namespace Microsoft.CodeAnalysis.Editor.Wrapping.SeparatedSyntaxList
{
    internal enum WrappingStyle
    {
        /// <summary>
        /// Wraps first item.  Subsequent wrapped items will be aligned with that first item. i.e.:
        ///      MethodName(
        ///          int a, int b, int c, int d, int e,
        ///          int f, int g, int h, int i, int j)
        /// </summary>
        WrapFirst,

        /// <summary>
        /// Unwraps first item.  Subsequent wrapped items will be aligned with that first item. i.e.:
        ///      MethodName(int a, int b, int c, int d, int e,
        ///                 int f, int g, int h, int i, int j)
        /// </summary>
        UnwrapFirst_AlignRest,

        /// <summary>
        /// Unwraps first item.  Subsequent wrapped items will be indented, but not aligned with that first item. i.e.:
        ///      MethodName(int a, int b, int c, int d, int e,
        ///          int f, int g, int h, int i, int j)
        /// </summary>
        UnwrapFirst_IndentRest,
    }
}
