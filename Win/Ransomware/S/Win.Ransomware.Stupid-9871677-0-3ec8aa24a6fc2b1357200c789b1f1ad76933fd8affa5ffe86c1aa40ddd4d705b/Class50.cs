using System;
using System.Runtime.InteropServices;

internal sealed class Class50
{
	public struct Struct5
	{
		public int int_0;

		public IntPtr intptr_0;

		public int int_1;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate2(string sDirectory);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate3();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int Delegate4(ref Struct5 tsData, ref Struct5 tsResult, int iContent);
}
