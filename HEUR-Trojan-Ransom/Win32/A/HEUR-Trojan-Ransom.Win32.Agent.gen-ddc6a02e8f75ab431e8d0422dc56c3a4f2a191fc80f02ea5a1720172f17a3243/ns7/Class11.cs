using System;
using System.IO;
using System.Runtime.InteropServices;
using ns2;
using ns4;

namespace ns7;

internal sealed class Class11 : Class5
{
	protected byte[] byte_0;

	public Class11(IntPtr intptr_2, IntPtr intptr_3, Class4 class4_2, Class4 class4_3, ushort ushort_1, int int_1)
		: base(intptr_2, intptr_3, class4_2, class4_3, ushort_1, int_1)
	{
	}

	internal override IntPtr vmethod_0(IntPtr intptr_2, IntPtr intptr_3)
	{
		if (int_0 > 0)
		{
			byte_0 = new byte[int_0];
			Marshal.Copy(intptr_3, byte_0, 0, byte_0.Length);
		}
		return new IntPtr(intptr_3.ToInt32() + int_0);
	}

	internal override void vmethod_1(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(byte_0);
	}
}
