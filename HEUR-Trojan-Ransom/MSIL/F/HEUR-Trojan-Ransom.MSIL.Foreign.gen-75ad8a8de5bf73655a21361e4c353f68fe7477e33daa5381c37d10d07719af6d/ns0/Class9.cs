using System;
using System.Collections.Generic;

namespace ns0;

internal class Class9
{
	public Class4.Enum1 enum1_0;

	public byte[] byte_0;

	public Class9(Class4.Enum1 header, byte[] data)
	{
		enum1_0 = header;
		byte_0 = data;
	}

	public byte[] method_0()
	{
		List<byte> list = new List<byte>();
		list.AddRange(BitConverter.GetBytes((int)enum1_0));
		list.AddRange(byte_0);
		byte[] array = list.ToArray();
		list.Clear();
		list = null;
		return Class0.smethod_0(array, bool_0: true);
	}
}
