using System.Collections.Generic;

namespace ns1;

internal static class Class3
{
	internal static byte[] smethod_0(this byte[] byte_0)
	{
		List<byte> list = new List<byte>();
		list.AddRange(byte_0);
		list.Reverse();
		return list.ToArray();
	}
}
