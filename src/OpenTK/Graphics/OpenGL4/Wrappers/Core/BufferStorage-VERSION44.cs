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
        /// [requires: v4.4 or ARB_buffer_storage|VERSION_4_4]
        /// Creates and initializes a buffer object's immutable data store.
        /// </summary>
        /// <param name="target">
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer, AtomicCounterBuffer, CopyReadBuffer, CopyWriteBuffer, DrawIndirectBuffer, DispatchIndirectBuffer, ElementArrayBuffer, PixelPackBuffer, PixelUnpackBuffer, QueryBuffer, ShaderStorageBuffer, TextureBuffer, TransformFeedbackBuffer, or UniformBuffer.
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">
        /// [length: size]
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="flags">
        /// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. DynamicStorageBit, MapReadBitMapWriteBit, MapPersistentBit, MapCoherentBit, and ClientStorageBit.
        /// </param>
        [AutoGenerated(Category = "ARB_buffer_storage|VERSION_4_4", Version = "4.4", EntryPoint = "glBufferStorage")]
        public static void BufferStorage(OpenTK.Graphics.OpenGL4.BufferTarget target, int size, [CountAttribute(Parameter = "size")] IntPtr data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.4 or ARB_buffer_storage|VERSION_4_4]
        /// Creates and initializes a buffer object's immutable data store.
        /// </summary>
        /// <param name="target">
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer, AtomicCounterBuffer, CopyReadBuffer, CopyWriteBuffer, DrawIndirectBuffer, DispatchIndirectBuffer, ElementArrayBuffer, PixelPackBuffer, PixelUnpackBuffer, QueryBuffer, ShaderStorageBuffer, TextureBuffer, TransformFeedbackBuffer, or UniformBuffer.
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">
        /// [length: size]
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="flags">
        /// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. DynamicStorageBit, MapReadBitMapWriteBit, MapPersistentBit, MapCoherentBit, and ClientStorageBit.
        /// </param>
        /// <typeparam name="T2"></typeparam>
        [AutoGenerated(Category = "ARB_buffer_storage|VERSION_4_4", Version = "4.4", EntryPoint = "glBufferStorage")]
        public static void BufferStorage<T2>(OpenTK.Graphics.OpenGL4.BufferTarget target, int size, [InAttribute, OutAttribute, CountAttribute(Parameter = "size")] T2[] data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.4 or ARB_buffer_storage|VERSION_4_4]
        /// Creates and initializes a buffer object's immutable data store.
        /// </summary>
        /// <param name="target">
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer, AtomicCounterBuffer, CopyReadBuffer, CopyWriteBuffer, DrawIndirectBuffer, DispatchIndirectBuffer, ElementArrayBuffer, PixelPackBuffer, PixelUnpackBuffer, QueryBuffer, ShaderStorageBuffer, TextureBuffer, TransformFeedbackBuffer, or UniformBuffer.
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">
        /// [length: size]
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="flags">
        /// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. DynamicStorageBit, MapReadBitMapWriteBit, MapPersistentBit, MapCoherentBit, and ClientStorageBit.
        /// </param>
        /// <typeparam name="T2"></typeparam>
        [AutoGenerated(Category = "ARB_buffer_storage|VERSION_4_4", Version = "4.4", EntryPoint = "glBufferStorage")]
        public static void BufferStorage<T2>(OpenTK.Graphics.OpenGL4.BufferTarget target, int size, [InAttribute, OutAttribute, CountAttribute(Parameter = "size")] T2[,] data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.4 or ARB_buffer_storage|VERSION_4_4]
        /// Creates and initializes a buffer object's immutable data store.
        /// </summary>
        /// <param name="target">
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer, AtomicCounterBuffer, CopyReadBuffer, CopyWriteBuffer, DrawIndirectBuffer, DispatchIndirectBuffer, ElementArrayBuffer, PixelPackBuffer, PixelUnpackBuffer, QueryBuffer, ShaderStorageBuffer, TextureBuffer, TransformFeedbackBuffer, or UniformBuffer.
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">
        /// [length: size]
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="flags">
        /// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. DynamicStorageBit, MapReadBitMapWriteBit, MapPersistentBit, MapCoherentBit, and ClientStorageBit.
        /// </param>
        /// <typeparam name="T2"></typeparam>
        [AutoGenerated(Category = "ARB_buffer_storage|VERSION_4_4", Version = "4.4", EntryPoint = "glBufferStorage")]
        public static void BufferStorage<T2>(OpenTK.Graphics.OpenGL4.BufferTarget target, int size, [InAttribute, OutAttribute, CountAttribute(Parameter = "size")] T2[,,] data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.4 or ARB_buffer_storage|VERSION_4_4]
        /// Creates and initializes a buffer object's immutable data store.
        /// </summary>
        /// <param name="target">
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer, AtomicCounterBuffer, CopyReadBuffer, CopyWriteBuffer, DrawIndirectBuffer, DispatchIndirectBuffer, ElementArrayBuffer, PixelPackBuffer, PixelUnpackBuffer, QueryBuffer, ShaderStorageBuffer, TextureBuffer, TransformFeedbackBuffer, or UniformBuffer.
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">
        /// [length: size]
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="flags">
        /// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. DynamicStorageBit, MapReadBitMapWriteBit, MapPersistentBit, MapCoherentBit, and ClientStorageBit.
        /// </param>
        /// <typeparam name="T2"></typeparam>
        [AutoGenerated(Category = "ARB_buffer_storage|VERSION_4_4", Version = "4.4", EntryPoint = "glBufferStorage")]
        public static void BufferStorage<T2>(OpenTK.Graphics.OpenGL4.BufferTarget target, int size, [InAttribute, OutAttribute, CountAttribute(Parameter = "size")] ref T2 data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.4 or ARB_buffer_storage|VERSION_4_4]
        /// Creates and initializes a buffer object's immutable data store.
        /// </summary>
        /// <param name="target">
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer, AtomicCounterBuffer, CopyReadBuffer, CopyWriteBuffer, DrawIndirectBuffer, DispatchIndirectBuffer, ElementArrayBuffer, PixelPackBuffer, PixelUnpackBuffer, QueryBuffer, ShaderStorageBuffer, TextureBuffer, TransformFeedbackBuffer, or UniformBuffer.
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">
        /// [length: size]
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="flags">
        /// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. DynamicStorageBit, MapReadBitMapWriteBit, MapPersistentBit, MapCoherentBit, and ClientStorageBit.
        /// </param>
        [AutoGenerated(Category = "ARB_buffer_storage|VERSION_4_4", Version = "4.4", EntryPoint = "glBufferStorage")]
        public static void BufferStorage(OpenTK.Graphics.OpenGL4.BufferTarget target, UIntPtr size, [CountAttribute(Parameter = "size")] IntPtr data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.4 or ARB_buffer_storage|VERSION_4_4]
        /// Creates and initializes a buffer object's immutable data store.
        /// </summary>
        /// <param name="target">
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer, AtomicCounterBuffer, CopyReadBuffer, CopyWriteBuffer, DrawIndirectBuffer, DispatchIndirectBuffer, ElementArrayBuffer, PixelPackBuffer, PixelUnpackBuffer, QueryBuffer, ShaderStorageBuffer, TextureBuffer, TransformFeedbackBuffer, or UniformBuffer.
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">
        /// [length: size]
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="flags">
        /// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. DynamicStorageBit, MapReadBitMapWriteBit, MapPersistentBit, MapCoherentBit, and ClientStorageBit.
        /// </param>
        /// <typeparam name="T2"></typeparam>
        [AutoGenerated(Category = "ARB_buffer_storage|VERSION_4_4", Version = "4.4", EntryPoint = "glBufferStorage")]
        public static void BufferStorage<T2>(OpenTK.Graphics.OpenGL4.BufferTarget target, UIntPtr size, [InAttribute, OutAttribute, CountAttribute(Parameter = "size")] T2[] data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.4 or ARB_buffer_storage|VERSION_4_4]
        /// Creates and initializes a buffer object's immutable data store.
        /// </summary>
        /// <param name="target">
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer, AtomicCounterBuffer, CopyReadBuffer, CopyWriteBuffer, DrawIndirectBuffer, DispatchIndirectBuffer, ElementArrayBuffer, PixelPackBuffer, PixelUnpackBuffer, QueryBuffer, ShaderStorageBuffer, TextureBuffer, TransformFeedbackBuffer, or UniformBuffer.
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">
        /// [length: size]
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="flags">
        /// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. DynamicStorageBit, MapReadBitMapWriteBit, MapPersistentBit, MapCoherentBit, and ClientStorageBit.
        /// </param>
        /// <typeparam name="T2"></typeparam>
        [AutoGenerated(Category = "ARB_buffer_storage|VERSION_4_4", Version = "4.4", EntryPoint = "glBufferStorage")]
        public static void BufferStorage<T2>(OpenTK.Graphics.OpenGL4.BufferTarget target, UIntPtr size, [InAttribute, OutAttribute, CountAttribute(Parameter = "size")] T2[,] data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.4 or ARB_buffer_storage|VERSION_4_4]
        /// Creates and initializes a buffer object's immutable data store.
        /// </summary>
        /// <param name="target">
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer, AtomicCounterBuffer, CopyReadBuffer, CopyWriteBuffer, DrawIndirectBuffer, DispatchIndirectBuffer, ElementArrayBuffer, PixelPackBuffer, PixelUnpackBuffer, QueryBuffer, ShaderStorageBuffer, TextureBuffer, TransformFeedbackBuffer, or UniformBuffer.
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">
        /// [length: size]
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="flags">
        /// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. DynamicStorageBit, MapReadBitMapWriteBit, MapPersistentBit, MapCoherentBit, and ClientStorageBit.
        /// </param>
        /// <typeparam name="T2"></typeparam>
        [AutoGenerated(Category = "ARB_buffer_storage|VERSION_4_4", Version = "4.4", EntryPoint = "glBufferStorage")]
        public static void BufferStorage<T2>(OpenTK.Graphics.OpenGL4.BufferTarget target, UIntPtr size, [InAttribute, OutAttribute, CountAttribute(Parameter = "size")] T2[,,] data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.4 or ARB_buffer_storage|VERSION_4_4]
        /// Creates and initializes a buffer object's immutable data store.
        /// </summary>
        /// <param name="target">
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer, AtomicCounterBuffer, CopyReadBuffer, CopyWriteBuffer, DrawIndirectBuffer, DispatchIndirectBuffer, ElementArrayBuffer, PixelPackBuffer, PixelUnpackBuffer, QueryBuffer, ShaderStorageBuffer, TextureBuffer, TransformFeedbackBuffer, or UniformBuffer.
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">
        /// [length: size]
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="flags">
        /// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. DynamicStorageBit, MapReadBitMapWriteBit, MapPersistentBit, MapCoherentBit, and ClientStorageBit.
        /// </param>
        /// <typeparam name="T2"></typeparam>
        [AutoGenerated(Category = "ARB_buffer_storage|VERSION_4_4", Version = "4.4", EntryPoint = "glBufferStorage")]
        public static void BufferStorage<T2>(OpenTK.Graphics.OpenGL4.BufferTarget target, UIntPtr size, [InAttribute, OutAttribute, CountAttribute(Parameter = "size")] ref T2 data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        #pragma warning disable SA1300 // Element should begin with an upper-case letter

        [Slot(58)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBufferStorage(OpenTK.Graphics.OpenGL4.BufferTarget target, UIntPtr size, [CountAttribute(Parameter = "size")] IntPtr data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags);
    }
}
