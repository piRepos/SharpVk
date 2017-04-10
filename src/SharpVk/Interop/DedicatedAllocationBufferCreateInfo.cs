using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DedicatedAllocationBufferCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DedicatedAllocationBufferCreateInfo(StructureType sType, void* next, Bool32 dedicatedAllocation)
        {
            this.SType = sType;
            this.Next = next;
            this.DedicatedAllocation = dedicatedAllocation;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DedicatedAllocation; 
    }
}
