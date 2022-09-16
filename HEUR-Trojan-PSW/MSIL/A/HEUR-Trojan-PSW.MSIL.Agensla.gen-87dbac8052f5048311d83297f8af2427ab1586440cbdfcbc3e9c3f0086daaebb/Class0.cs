using System.Collections.Generic;
using System.Text;

internal static class Class0
{
	internal static List<byte> smethod_0(byte[] byte_0)
	{
		byte[] bytes = Encoding.ASCII.GetBytes("Nwxkbsmxje");
		List<byte> list = new List<byte>();
		for (int i = 0; i < byte_0.Length; i++)
		{
			list.Add((byte)(bytes[i % bytes.Length] ^ byte_0[i]));
		}
		return list;
	}
}
