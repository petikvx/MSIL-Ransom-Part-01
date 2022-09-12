using System;
using System.IO;
using System.Runtime.InteropServices;
using ns0;
using ns7;

namespace ns4;

internal sealed class Class7 : Class0
{
	protected byte[] byte_0;

	public Class7(IntPtr intptr_2, IntPtr intptr_3, Class40 class40_2, Class40 class40_3, ushort ushort_1, int int_1)
		: base(intptr_2, intptr_3, class40_2, class40_3, ushort_1, int_1)
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
