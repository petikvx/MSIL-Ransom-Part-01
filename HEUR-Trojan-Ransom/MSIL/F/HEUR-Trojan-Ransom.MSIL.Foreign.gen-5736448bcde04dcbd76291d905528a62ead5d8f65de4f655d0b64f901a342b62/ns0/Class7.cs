using System;
using System.Collections.Generic;

namespace ns0;

internal class Class7
{
	public Class6.Enum0 enum0_0;

	public byte[] byte_0;

	public Class7(Class6.Enum0 header, byte[] data)
	{
		enum0_0 = header;
		byte_0 = data;
	}

	public byte[] method_0()
	{
		List<byte> list = new List<byte>();
		list.AddRange(BitConverter.GetBytes((int)enum0_0));
		list.AddRange(byte_0);
		byte[] array = list.ToArray();
		list.Clear();
		list = null;
		return Class12.smethod_0(array, bool_0: true);
	}
}
