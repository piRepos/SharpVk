// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2019
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

namespace SharpVk.Khronos
{
    /// <summary>
    /// Structure specifying parameters of images that will be used with a
    /// framebuffer
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct FramebufferAttachmentsCreateInfo
    {
        /// <summary>
        /// An array of FramebufferAttachmentImageInfo instances, each of which
        /// describes a number of parameters of the corresponding attachment in
        /// a render pass instance.
        /// </summary>
        public SharpVk.Khronos.FramebufferAttachmentImageInfo[] AttachmentImageInfos
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.FramebufferAttachmentsCreateInfo* pointer)
        {
            pointer->SType = StructureType.FramebufferAttachmentsCreateInfo;
            pointer->Next = null;
            pointer->AttachmentImageInfoCount = (uint)(Interop.HeapUtil.GetLength(this.AttachmentImageInfos));
            if (this.AttachmentImageInfos != null)
            {
                var fieldPointer = (SharpVk.Interop.Khronos.FramebufferAttachmentImageInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.FramebufferAttachmentImageInfo>(this.AttachmentImageInfos.Length).ToPointer());
                for(int index = 0; index < (uint)(this.AttachmentImageInfos.Length); index++)
                {
                    this.AttachmentImageInfos[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->AttachmentImageInfos = fieldPointer;
            }
            else
            {
                pointer->AttachmentImageInfos = null;
            }
        }
    }
}
