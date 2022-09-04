using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns6;

namespace ns1;

internal sealed class Class22
{
	private Class23.Struct5 struct5_0 = default(Class23.Struct5);

	private byte[] byte_0;

	[SpecialName]
	public byte[] method_0()
	{
		return byte_0;
	}

	internal void method_1(IntPtr intptr_0, uint uint_0)
	{
		struct5_0 = (Class23.Struct5)Marshal.PtrToStructure(intptr_0, typeof(Class23.Struct5));
		byte_0 = new byte[uint_0];
		Marshal.Copy(intptr_0, byte_0, 0, byte_0.Length);
	}
}
