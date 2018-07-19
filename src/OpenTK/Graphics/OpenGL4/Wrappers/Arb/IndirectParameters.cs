//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Graphics.OpenGL4
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "IndirectParameters" in the extension "Arb".
        /// </summary>
        public static partial class Arb
        {
            /// <summary>
            /// [requires: ARB_indirect_parameters]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="indirect">
            /// </param>
            /// <param name="drawcount">
            /// </param>
            /// <param name="maxdrawcount">
            /// </param>
            /// <param name="stride">
            /// </param>
            [AutoGenerated(Category = "ARB_indirect_parameters", Version = "", EntryPoint = "glMultiDrawArraysIndirectCountARB")]
            public static void MultiDrawArraysIndirectCount(OpenTK.Graphics.OpenGL4.PrimitiveType mode, IntPtr indirect, IntPtr drawcount, uint maxdrawcount, uint stride)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_indirect_parameters]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="indirect">
            /// </param>
            /// <param name="drawcount">
            /// </param>
            /// <param name="maxdrawcount">
            /// </param>
            /// <param name="stride">
            /// </param>
            /// <typeparam name="T1"></typeparam>
            [AutoGenerated(Category = "ARB_indirect_parameters", Version = "", EntryPoint = "glMultiDrawArraysIndirectCountARB")]
            public static void MultiDrawArraysIndirectCount<T1>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, [InAttribute, OutAttribute] T1[] indirect, IntPtr drawcount, uint maxdrawcount, uint stride)
                where T1 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_indirect_parameters]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="indirect">
            /// </param>
            /// <param name="drawcount">
            /// </param>
            /// <param name="maxdrawcount">
            /// </param>
            /// <param name="stride">
            /// </param>
            /// <typeparam name="T1"></typeparam>
            [AutoGenerated(Category = "ARB_indirect_parameters", Version = "", EntryPoint = "glMultiDrawArraysIndirectCountARB")]
            public static void MultiDrawArraysIndirectCount<T1>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, [InAttribute, OutAttribute] T1[,] indirect, IntPtr drawcount, uint maxdrawcount, uint stride)
                where T1 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_indirect_parameters]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="indirect">
            /// </param>
            /// <param name="drawcount">
            /// </param>
            /// <param name="maxdrawcount">
            /// </param>
            /// <param name="stride">
            /// </param>
            /// <typeparam name="T1"></typeparam>
            [AutoGenerated(Category = "ARB_indirect_parameters", Version = "", EntryPoint = "glMultiDrawArraysIndirectCountARB")]
            public static void MultiDrawArraysIndirectCount<T1>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, [InAttribute, OutAttribute] T1[,,] indirect, IntPtr drawcount, uint maxdrawcount, uint stride)
                where T1 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_indirect_parameters]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="indirect">
            /// </param>
            /// <param name="drawcount">
            /// </param>
            /// <param name="maxdrawcount">
            /// </param>
            /// <param name="stride">
            /// </param>
            /// <typeparam name="T1"></typeparam>
            [AutoGenerated(Category = "ARB_indirect_parameters", Version = "", EntryPoint = "glMultiDrawArraysIndirectCountARB")]
            public static void MultiDrawArraysIndirectCount<T1>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, [InAttribute, OutAttribute] ref T1 indirect, IntPtr drawcount, uint maxdrawcount, uint stride)
                where T1 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_indirect_parameters]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indirect">
            /// </param>
            /// <param name="drawcount">
            /// </param>
            /// <param name="maxdrawcount">
            /// </param>
            /// <param name="stride">
            /// </param>
            [AutoGenerated(Category = "ARB_indirect_parameters", Version = "", EntryPoint = "glMultiDrawElementsIndirectCountARB")]
            public static void MultiDrawElementsIndirectCount(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indirect, IntPtr drawcount, uint maxdrawcount, uint stride)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_indirect_parameters]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indirect">
            /// </param>
            /// <param name="drawcount">
            /// </param>
            /// <param name="maxdrawcount">
            /// </param>
            /// <param name="stride">
            /// </param>
            /// <typeparam name="T2"></typeparam>
            [AutoGenerated(Category = "ARB_indirect_parameters", Version = "", EntryPoint = "glMultiDrawElementsIndirectCountARB")]
            public static void MultiDrawElementsIndirectCount<T2>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute] T2[] indirect, IntPtr drawcount, uint maxdrawcount, uint stride)
                where T2 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_indirect_parameters]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indirect">
            /// </param>
            /// <param name="drawcount">
            /// </param>
            /// <param name="maxdrawcount">
            /// </param>
            /// <param name="stride">
            /// </param>
            /// <typeparam name="T2"></typeparam>
            [AutoGenerated(Category = "ARB_indirect_parameters", Version = "", EntryPoint = "glMultiDrawElementsIndirectCountARB")]
            public static void MultiDrawElementsIndirectCount<T2>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute] T2[,] indirect, IntPtr drawcount, uint maxdrawcount, uint stride)
                where T2 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_indirect_parameters]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indirect">
            /// </param>
            /// <param name="drawcount">
            /// </param>
            /// <param name="maxdrawcount">
            /// </param>
            /// <param name="stride">
            /// </param>
            /// <typeparam name="T2"></typeparam>
            [AutoGenerated(Category = "ARB_indirect_parameters", Version = "", EntryPoint = "glMultiDrawElementsIndirectCountARB")]
            public static void MultiDrawElementsIndirectCount<T2>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute] T2[,,] indirect, IntPtr drawcount, uint maxdrawcount, uint stride)
                where T2 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_indirect_parameters]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indirect">
            /// </param>
            /// <param name="drawcount">
            /// </param>
            /// <param name="maxdrawcount">
            /// </param>
            /// <param name="stride">
            /// </param>
            /// <typeparam name="T2"></typeparam>
            [AutoGenerated(Category = "ARB_indirect_parameters", Version = "", EntryPoint = "glMultiDrawElementsIndirectCountARB")]
            public static void MultiDrawElementsIndirectCount<T2>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute] ref T2 indirect, IntPtr drawcount, uint maxdrawcount, uint stride)
                where T2 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            #pragma warning disable SA1300 // Element should begin with an upper-case letter

            [Slot(701)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMultiDrawArraysIndirectCountARB(OpenTK.Graphics.OpenGL4.PrimitiveType mode, IntPtr indirect, IntPtr drawcount, uint maxdrawcount, uint stride);

            [Slot(708)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMultiDrawElementsIndirectCountARB(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indirect, IntPtr drawcount, uint maxdrawcount, uint stride);
        }
    }
}
