using System.IO;

namespace BmHCcZGH;

internal sealed class Class1
{
	internal static byte[] Byte_0
	{
		get
		{
			try
			{
				return File.ReadAllBytes("");
			}
			catch
			{
			}
			return new byte[0];
		}
	}

	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] = (byte)(byte_0[i] ^ byte_1[i % byte_1.Length]);
		}
		return byte_0;
	}
}
