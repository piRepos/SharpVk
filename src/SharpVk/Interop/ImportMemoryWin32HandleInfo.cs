using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ImportMemoryWin32HandleInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public ImportMemoryWin32HandleInfo(StructureType sType, void* next, ExternalMemoryHandleTypeFlags handleType, IntPtr handle)
        {
            this.SType = sType;
            this.Next = next;
            this.HandleType = handleType;
            this.Handle = handle;
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
        public ExternalMemoryHandleTypeFlags HandleType; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Handle; 
    }
}
