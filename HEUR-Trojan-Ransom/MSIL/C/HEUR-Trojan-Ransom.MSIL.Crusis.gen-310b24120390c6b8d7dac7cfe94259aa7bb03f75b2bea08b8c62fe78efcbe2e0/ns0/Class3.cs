using System;

namespace ns0;

internal sealed class Class3
{
	internal static void smethod_0(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] ^= byte_1[i % byte_1.Length];
		}
	}

	internal static void smethod_1(string string_0, byte[] byte_0)
	{
		Buffer.BlockCopy(string_0.ToCharArray(), 0, byte_0, 0, byte_0.Length);
	}
}
