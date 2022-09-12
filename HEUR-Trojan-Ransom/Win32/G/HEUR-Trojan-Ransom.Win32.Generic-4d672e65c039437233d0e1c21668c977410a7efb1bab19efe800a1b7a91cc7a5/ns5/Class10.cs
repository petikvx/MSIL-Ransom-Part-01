using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns2;

namespace ns5;

internal sealed class Class10
{
	private Class29.Struct1 struct1_0 = default(Class29.Struct1);

	private byte[] byte_0;

	[SpecialName]
	public byte[] method_0()
	{
		return byte_0;
	}

	internal void method_1(IntPtr intptr_0, uint uint_0)
	{
		struct1_0 = (Class29.Struct1)Marshal.PtrToStructure(intptr_0, typeof(Class29.Struct1));
		byte_0 = new byte[uint_0];
		Marshal.Copy(intptr_0, byte_0, 0, byte_0.Length);
	}
}
