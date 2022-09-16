using System.Collections.Generic;
using System.Text;

internal static class Class4
{
	internal static byte[] smethod_0(byte[] byte_0)
	{
		string s = "Zfjsjyvqizurf";
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		List<byte> list = new List<byte>();
		for (int i = 0; i < byte_0.Length; i++)
		{
			list.Add((byte)(bytes[i % bytes.Length] ^ byte_0[i]));
		}
		return list.ToArray();
	}
}
