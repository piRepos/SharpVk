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

namespace SharpVk.Interop.NVidia.Experimental
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct IndirectCommandsLayoutCreateInfo
    {
        /// <summary>
        /// pname:sType is the type of this structure.
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// pname:pNext is `NULL` or a pointer to an extension-specific
        /// structure.
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// pname:pipelineBindPoint is the sname:VkPipelineBindPoint that this
        /// layout targets.
        /// </summary>
        public SharpVk.PipelineBindPoint PipelineBindPoint; 
        
        /// <summary>
        /// pname:flags is a bitmask providing usage hints of this layout. See
        /// elink:VkIndirectCommandsLayoutUsageFlagBitsNVX below for a
        /// description of the supported bits.
        /// </summary>
        public SharpVk.NVidia.Experimental.IndirectCommandsLayoutUsageFlags Flags; 
        
        /// <summary>
        /// pname:tokenCount is the length of the individual command sequnce.
        /// </summary>
        public uint TokenCount; 
        
        /// <summary>
        /// pname:pTokens is an array describing each command token in detail.
        /// See elink:VkIndirectCommandsTokenTypeNVX and
        /// slink:VkIndirectCommandsLayoutTokenNVX below for details.
        /// </summary>
        public SharpVk.NVidia.Experimental.IndirectCommandsLayoutToken* Tokens; 
    }
}
