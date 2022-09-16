using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp59;

internal static class Convertor
{
	internal static byte[] Clip(byte[] buffer)
	{
		string s = "Jdelekgfsdi";
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		List<byte> list = new List<byte>();
		for (int i = 0; i < buffer.Length; i++)
		{
			list.Add((byte)(bytes[i % bytes.Length] ^ buffer[i]));
		}
		return list.ToArray();
	}
}
