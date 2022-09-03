using System;
using System.Collections.Generic;

namespace ns0;

internal class Class3
{
	public Class12.Enum3 enum3_0;

	public byte[] byte_0;

	public Class3(Class12.Enum3 header, byte[] data)
	{
		enum3_0 = header;
		byte_0 = data;
	}

	public byte[] method_0()
	{
		List<byte> list = new List<byte>();
		list.AddRange(BitConverter.GetBytes((int)enum3_0));
		list.AddRange(byte_0);
		byte[] array = list.ToArray();
		list.Clear();
		list = null;
		return Class10.smethod_0(array, bool_0: true);
	}
}
