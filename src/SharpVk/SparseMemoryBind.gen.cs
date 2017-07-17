// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using System;
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// Structure specifying a sparse memory bind operation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SparseMemoryBind
    {
        /// <summary>
        /// pname:resourceOffset is the offset into the resource.
        /// </summary>
        public DeviceSize ResourceOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:size is the size of the memory region to be bound.
        /// </summary>
        public DeviceSize Size
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memory is the sname:VkDeviceMemory object that the range of
        /// the resource is bound to. If pname:memory is dlink:VK_NULL_HANDLE,
        /// the range is unbound.
        /// </summary>
        public SharpVk.DeviceMemory Memory
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memoryOffset is the offset into the sname:VkDeviceMemory
        /// object to bind the resource range to. If pname:memory is
        /// dlink:VK_NULL_HANDLE, this value is ignored.
        /// </summary>
        public DeviceSize MemoryOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:flags is a bitmask specifying usage of the binding operation.
        /// Bits which can: be set include: + --
        /// </summary>
        public SharpVk.SparseMemoryBindFlags? Flags
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(SharpVk.Interop.SparseMemoryBind* pointer)
        {
            pointer->ResourceOffset = this.ResourceOffset;
            pointer->Size = this.Size;
            pointer->Memory = this.Memory?.handle ?? default(SharpVk.Interop.DeviceMemory);
            pointer->MemoryOffset = this.MemoryOffset;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.SparseMemoryBindFlags);
            }
        }
        
        internal static unsafe SparseMemoryBind MarshalFrom(SharpVk.Interop.SparseMemoryBind* pointer)
        {
            SparseMemoryBind result = default(SparseMemoryBind);
            result.ResourceOffset = pointer->ResourceOffset;
            result.Size = pointer->Size;
            result.Memory = new SharpVk.DeviceMemory(default(SharpVk.Device), pointer->Memory);
            result.MemoryOffset = pointer->MemoryOffset;
            result.Flags = pointer->Flags;
            return result;
        }
    }
}
