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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct AttachmentDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public AttachmentDescription(AttachmentDescriptionFlags flags, Format format, SampleCountFlags samples, AttachmentLoadOp loadOp, AttachmentStoreOp storeOp, AttachmentLoadOp stencilLoadOp, AttachmentStoreOp stencilStoreOp, ImageLayout initialLayout, ImageLayout finalLayout)
        {
            this.Flags = flags;
            this.Format = format;
            this.Samples = samples;
            this.LoadOp = loadOp;
            this.StoreOp = storeOp;
            this.StencilLoadOp = stencilLoadOp;
            this.StencilStoreOp = stencilStoreOp;
            this.InitialLayout = initialLayout;
            this.FinalLayout = finalLayout;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentDescriptionFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public Format Format; 
        
        /// <summary>
        /// 
        /// </summary>
        public SampleCountFlags Samples; 
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentLoadOp LoadOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentStoreOp StoreOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentLoadOp StencilLoadOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentStoreOp StencilStoreOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageLayout InitialLayout; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageLayout FinalLayout; 
    }
}
