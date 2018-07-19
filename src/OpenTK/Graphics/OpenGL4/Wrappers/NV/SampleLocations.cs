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
        /// Contains native bindings to functions in the category "SampleLocations" in the extension "NV".
        /// </summary>
        public static partial class NV
        {
            /// <summary>
            /// [requires: NV_sample_locations]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="start">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="v">
            /// </param>
            [AutoGenerated(Category = "NV_sample_locations", Version = "", EntryPoint = "glFramebufferSampleLocationsfvNV")]
            public static void FramebufferSampleLocations(OpenTK.Graphics.OpenGL4.FramebufferTarget target, uint start, uint count, float[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_sample_locations]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="start">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="v">
            /// </param>
            [AutoGenerated(Category = "NV_sample_locations", Version = "", EntryPoint = "glFramebufferSampleLocationsfvNV")]
            public static void FramebufferSampleLocations(OpenTK.Graphics.OpenGL4.FramebufferTarget target, uint start, uint count, ref float v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_sample_locations]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="start">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="v">
            /// </param>
            [AutoGenerated(Category = "NV_sample_locations", Version = "", EntryPoint = "glFramebufferSampleLocationsfvNV")]
            public static unsafe void FramebufferSampleLocations(OpenTK.Graphics.OpenGL4.FramebufferTarget target, uint start, uint count, float* v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_sample_locations]
            /// </summary>
            /// <param name="framebuffer">
            /// </param>
            /// <param name="start">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="v">
            /// </param>
            [AutoGenerated(Category = "NV_sample_locations", Version = "", EntryPoint = "glNamedFramebufferSampleLocationsfvNV")]
            public static void NamedFramebufferSampleLocations(uint framebuffer, uint start, uint count, float[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_sample_locations]
            /// </summary>
            /// <param name="framebuffer">
            /// </param>
            /// <param name="start">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="v">
            /// </param>
            [AutoGenerated(Category = "NV_sample_locations", Version = "", EntryPoint = "glNamedFramebufferSampleLocationsfvNV")]
            public static void NamedFramebufferSampleLocations(uint framebuffer, uint start, uint count, ref float v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_sample_locations]
            /// </summary>
            /// <param name="framebuffer">
            /// </param>
            /// <param name="start">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="v">
            /// </param>
            [AutoGenerated(Category = "NV_sample_locations", Version = "", EntryPoint = "glNamedFramebufferSampleLocationsfvNV")]
            public static unsafe void NamedFramebufferSampleLocations(uint framebuffer, uint start, uint count, float* v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_sample_locations]
            /// </summary>
            [AutoGenerated(Category = "NV_sample_locations", Version = "", EntryPoint = "glResolveDepthValuesNV")]
            public static void ResolveDepthValues()
            {
                throw new BindingsNotRewrittenException();
            }

            #pragma warning disable SA1300 // Element should begin with an upper-case letter

            [Slot(291)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glFramebufferSampleLocationsfvNV(OpenTK.Graphics.OpenGL4.FramebufferTarget target, uint start, uint count, float* v);

            [Slot(759)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glNamedFramebufferSampleLocationsfvNV(uint framebuffer, uint start, uint count, float* v);

            [Slot(995)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glResolveDepthValuesNV();
        }
    }
}
