namespace ___codefort;

internal static class Class24
{
	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
	{
		byte b = byte_0[1];
		int num = byte_1.Length;
		byte b2 = (byte)((num + 11) ^ (b + 7));
		uint num2 = (uint)((byte_0[0] | (byte_0[2] << 8)) + (b2 << 3));
		ushort num3 = 0;
		for (int i = 0; i < num; i++)
		{
			if ((i & 1) == 0)
			{
				num2 = num2 * 214013 + 2531011;
				num3 = (ushort)(num2 >> 16);
			}
			byte b3 = (byte)num3;
			num3 = (ushort)(num3 >> 8);
			byte b4 = byte_1[i];
			byte_1[i] = (byte)(b4 ^ b ^ (b2 + 3) ^ b3);
			b2 = b4;
		}
		return byte_1;
	}
}
