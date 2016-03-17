﻿//The MIT License (MIT)
//
//Copyright (c) 2016 Andrew Armstrong/FacticiusVir
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using System.Runtime.InteropServices;

namespace SharpVk
{
	[StructLayout(LayoutKind.Explicit)]
	public struct ClearColorValue
	{
		[FieldOffset(0)]
		public float Float320;
		[FieldOffset(0)]
		public float Float321;
		[FieldOffset(0)]
		public float Float322;
		[FieldOffset(0)]
		public float Float323;
		[FieldOffset(0)]
		public int Int320;
		[FieldOffset(0)]
		public int Int321;
		[FieldOffset(0)]
		public int Int322;
		[FieldOffset(0)]
		public int Int323;
		[FieldOffset(0)]
		public uint Uint320;
		[FieldOffset(0)]
		public uint Uint321;
		[FieldOffset(0)]
		public uint Uint322;
		[FieldOffset(0)]
		public uint Uint323;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ClearValue
	{
		[FieldOffset(0)]
		public ClearColorValue Color;
		[FieldOffset(0)]
		public ClearDepthStencilValue DepthStencil;
	}

}