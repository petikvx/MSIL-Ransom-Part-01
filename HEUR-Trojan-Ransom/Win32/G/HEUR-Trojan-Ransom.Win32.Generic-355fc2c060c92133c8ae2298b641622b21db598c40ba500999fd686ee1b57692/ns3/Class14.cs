using System;
using System.IO;
using System.Runtime.InteropServices;
using ns0;
using ns5;

namespace ns3;

internal sealed class Class14 : Class13
{
	protected internal byte[] byte_0;

	public Class14(Class10 class10_2, Class10 class10_3, ushort ushort_1)
	{
		class10_0 = class10_2;
		class10_1 = class10_3;
		ushort_0 = ushort_1;
	}

	internal override IntPtr vmethod_1(IntPtr intptr_2, IntPtr intptr_3)
	{
		if (int_0 > 0)
		{
			byte_0 = new byte[int_0];
			Marshal.Copy(intptr_3, byte_0, 0, byte_0.Length);
		}
		return new IntPtr(intptr_3.ToInt32() + int_0);
	}

	internal override void vmethod_2(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(byte_0);
	}
}
