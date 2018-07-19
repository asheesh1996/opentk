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
        /// Contains native bindings to functions in the category "DebugLabel" in the extension "Ext".
        /// </summary>
        public static partial class Ext
        {
            /// <summary>
            /// [requires: EXT_debug_label]
            /// Retrieve the label of a named object identified within a namespace.
            /// </summary>
            /// <param name="type">
            /// The namespace from which the name of the object is allocated.
            /// </param>
            /// <param name="object">
            /// The name of the object whose label to retrieve.
            /// </param>
            /// <param name="bufSize">
            /// The length of the buffer whose address is in label.
            /// </param>
            /// <param name="length">
            /// [length: 1]
            /// The address of a variable to receive the length of the object label.
            /// </param>
            /// <param name="label">
            /// [length: bufSize]
            /// The address of a string that will receive the object label.
            /// </param>
            [AutoGenerated(Category = "EXT_debug_label", Version = "", EntryPoint = "glGetObjectLabelEXT")]
            public static void GetObjectLabel(OpenTK.Graphics.OpenGL4.ExtDebugLabel type, uint @object, uint bufSize, [OutAttribute, CountAttribute(Count = 1)] out uint length, [OutAttribute, CountAttribute(Parameter = "bufSize")] out string label)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_debug_label]
            /// Retrieve the label of a named object identified within a namespace.
            /// </summary>
            /// <param name="type">
            /// The namespace from which the name of the object is allocated.
            /// </param>
            /// <param name="object">
            /// The name of the object whose label to retrieve.
            /// </param>
            /// <param name="bufSize">
            /// The length of the buffer whose address is in label.
            /// </param>
            /// <param name="length">
            /// [length: 1]
            /// The address of a variable to receive the length of the object label.
            /// </param>
            /// <param name="label">
            /// [length: bufSize]
            /// The address of a string that will receive the object label.
            /// </param>
            [AutoGenerated(Category = "EXT_debug_label", Version = "", EntryPoint = "glGetObjectLabelEXT")]
            public static unsafe void GetObjectLabel(OpenTK.Graphics.OpenGL4.ExtDebugLabel type, uint @object, uint bufSize, [OutAttribute, CountAttribute(Count = 1)] uint* length, [OutAttribute, CountAttribute(Parameter = "bufSize")] out string label)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_debug_label]
            /// </summary>
            /// <param name="type">
            /// </param>
            /// <param name="object">
            /// </param>
            /// <param name="length">
            /// </param>
            /// <param name="label">
            /// </param>
            [AutoGenerated(Category = "EXT_debug_label", Version = "", EntryPoint = "glLabelObjectEXT")]
            public static void LabelObject(OpenTK.Graphics.OpenGL4.ExtDebugLabel type, uint @object, uint length, string label)
            {
                throw new BindingsNotRewrittenException();
            }

            #pragma warning disable SA1300 // Element should begin with an upper-case letter

            [Slot(468)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetObjectLabelEXT(OpenTK.Graphics.OpenGL4.ExtDebugLabel type, uint @object, uint bufSize, [OutAttribute, CountAttribute(Count = 1)] uint* length, [OutAttribute, CountAttribute(Parameter = "bufSize")] IntPtr label);

            [Slot(641)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glLabelObjectEXT(OpenTK.Graphics.OpenGL4.ExtDebugLabel type, uint @object, uint length, IntPtr label);
        }
    }
}
