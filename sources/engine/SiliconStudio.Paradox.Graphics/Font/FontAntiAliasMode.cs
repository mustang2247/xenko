﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
//
// Copyright (c) 2010-2013 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using SiliconStudio.Core;

namespace SiliconStudio.Paradox.Graphics.Font
{
    /// <summary>
    /// Available antialias mode.
    /// </summary>
    [DataContract]
    public enum FontAntiAliasMode
    {
        /// <summary>
        /// The default grayscale anti-aliasing
        /// </summary>
        /// <userdoc>Equivalent to 'Grayscale'.</userdoc>
        Default,

        /// <summary>
        /// Use grayscale antialiasing
        /// </summary>
        /// <userdoc>Uses several levels of gray smooth the character edges. 
        /// 'ClearType' .</userdoc>
        Grayscale = Default,

        /// <summary>
        /// Use cleartype antialiasing.
        /// </summary>
        /// <userdoc>Uses the display red/green/blue sub-pixels to smooth character edges</userdoc>
        ClearType,

        /// <summary>
        /// Don't use any antialiasing
        /// </summary>
        /// <userdoc>Does not perform any anti-aliasing</userdoc>
        Aliased,
    }
}