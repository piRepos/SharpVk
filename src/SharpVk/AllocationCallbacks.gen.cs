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
    /// Structure containing callback function pointers for memory allocation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct AllocationCallbacks
    {
        /// <summary>
        /// pname:pUserData is a value to be interpreted by the implementation
        /// of the callbacks. When any of the callbacks in
        /// sname:VkAllocationCallbacks are called, the Vulkan implementation
        /// will pass this value as the first parameter to the callback. This
        /// value can: vary each time an allocator is passed into a command,
        /// even when the same object takes an allocator in multiple commands.
        /// </summary>
        public IntPtr? UserData
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pfnAllocation is a pointer to an application-defined memory
        /// allocation function of type tlink:PFN_vkAllocationFunction.
        /// </summary>
        public SharpVk.AllocationFunctionDelegate Allocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pfnReallocation is a pointer to an application-defined memory
        /// reallocation function of type tlink:PFN_vkReallocationFunction.
        /// </summary>
        public SharpVk.ReallocationFunctionDelegate Reallocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pfnFree is a pointer to an application-defined memory free
        /// function of type tlink:PFN_vkFreeFunction.
        /// </summary>
        public SharpVk.FreeFunctionDelegate Free
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pfnInternalAllocation is a pointer to an application-defined
        /// function that is called by the implementation when the
        /// implementation makes internal allocations, and it is of type
        /// tlink:PFN_vkInternalAllocationNotification.
        /// </summary>
        public SharpVk.InternalAllocationNotificationDelegate InternalAllocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pfnInternalFree is a pointer to an application-defined
        /// function that is called by the implementation when the
        /// implementation frees internal allocations, and it is of type
        /// tlink:PFN_vkInternalFreeNotification.
        /// </summary>
        public SharpVk.InternalFreeNotificationDelegate InternalFree
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(SharpVk.Interop.AllocationCallbacks* pointer)
        {
            if (this.UserData != null)
            {
                pointer->UserData = this.UserData.Value.ToPointer();
            }
            else
            {
                pointer->UserData = default(void*);
            }
            pointer->Allocation = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.Allocation);
            pointer->Reallocation = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.Reallocation);
            pointer->Free = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.Free);
            pointer->InternalAllocation = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.InternalAllocation);
            pointer->InternalFree = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.InternalFree);
        }
    }
}
