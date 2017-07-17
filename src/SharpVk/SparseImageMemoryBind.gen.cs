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
    /// Structure specifying sparse image memory bind.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SparseImageMemoryBind
    {
        /// <summary>
        /// pname:subresource is the aspectMask and region of interest in the
        /// image.
        /// </summary>
        public SharpVk.ImageSubresource Subresource
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:offset are the coordinates of the first texel within the
        /// image subresource to bind.
        /// </summary>
        public SharpVk.Offset3D Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:extent is the size in texels of the region within the image
        /// subresource to bind. The extent must: be a multiple of the sparse
        /// image block dimensions, except when binding sparse image blocks
        /// along the edge of an image subresource it can: instead be such that
        /// any coordinate of [eq]#pname:offset + pname:extent# equals the
        /// corresponding dimensions of the image subresource.
        /// </summary>
        public SharpVk.Extent3D Extent
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memory is the sname:VkDeviceMemory object that the sparse
        /// image blocks of the image are bound to. If pname:memory is
        /// dlink:VK_NULL_HANDLE, the sparse image blocks are unbound.
        /// </summary>
        public SharpVk.DeviceMemory Memory
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memoryOffset is an offset into sname:VkDeviceMemory object.
        /// If pname:memory is dlink:VK_NULL_HANDLE, this value is ignored.
        /// </summary>
        public DeviceSize MemoryOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:flags are sparse memory binding flags.
        /// </summary>
        public SharpVk.SparseMemoryBindFlags? Flags
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(SharpVk.Interop.SparseImageMemoryBind* pointer)
        {
            pointer->Subresource = this.Subresource;
            pointer->Offset = this.Offset;
            pointer->Extent = this.Extent;
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
        
        internal static unsafe SparseImageMemoryBind MarshalFrom(SharpVk.Interop.SparseImageMemoryBind* pointer)
        {
            SparseImageMemoryBind result = default(SparseImageMemoryBind);
            result.Subresource = pointer->Subresource;
            result.Offset = pointer->Offset;
            result.Extent = pointer->Extent;
            result.Memory = new SharpVk.DeviceMemory(default(SharpVk.Device), pointer->Memory);
            result.MemoryOffset = pointer->MemoryOffset;
            result.Flags = pointer->Flags;
            return result;
        }
    }
}
