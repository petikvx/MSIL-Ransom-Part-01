internal static class a41805c0
{
	public unsafe static uint b3b1be1f(ref byte* pByte_0)
	{
		uint num = 0u;
		int num2 = 0;
		do
		{
			num |= (uint)((*pByte_0 & 0x7F) << num2);
			num2 += 7;
		}
		while ((*(pByte_0++) & 0x80u) != 0);
		return num;
	}

	public static uint bf3cf4f2(uint uint_0)
	{
		uint num = uint_0 >> 3;
		return (uint_0 & 7) switch
		{
			1u => num | 0x2000000u, 
			2u => num | 0x1000000u, 
			3u => num | 0x1B000000u, 
			4u => num | 0xA000000u, 
			5u => num | 0x6000000u, 
			6u => num | 0x4000000u, 
			7u => num | 0x2B000000u, 
			_ => num, 
		};
	}

	public static void smethod_0(uint uint_0, uint uint_1, uint uint_2, uint uint_3, ref byte byte_0, byte byte_1)
	{
		byte b7056385 = 0;
		if (uint_3 == 0)
		{
			b7056385 = (byte)(b7056385 | fae0f10.cf4ec1c9);
		}
		if (((ulong)uint_3 & 0x80000000uL) > 0L)
		{
			b7056385 = (byte)(b7056385 | fae0f10.byte_9);
		}
		if (((ulong)((uint_0 ^ uint_2) & (uint_1 ^ uint_2)) & 0x80000000uL) > 0L)
		{
			b7056385 = (byte)(b7056385 | fae0f10.b28d533f);
		}
		if (((ulong)(uint_0 ^ ((uint_0 ^ uint_1) & (uint_1 ^ uint_2))) & 0x80000000uL) > 0L)
		{
			b7056385 = (byte)(b7056385 | fae0f10.bdee4792);
		}
		byte_0 = (byte)((byte_0 & ~byte_1) | (b7056385 & byte_1));
	}

	public static void smethod_1(ulong ulong_0, ulong ulong_1, ulong ulong_2, ulong ulong_3, ref byte byte_0, byte byte_1)
	{
		byte b7056385 = 0;
		if (ulong_3 == 0L)
		{
			b7056385 = (byte)(b7056385 | fae0f10.cf4ec1c9);
		}
		if ((ulong_3 & 0x80000000L) > 0L)
		{
			b7056385 = (byte)(b7056385 | fae0f10.byte_9);
		}
		if (((ulong_0 ^ ulong_2) & (ulong_1 ^ ulong_2) & 0x80000000L) > 0L)
		{
			b7056385 = (byte)(b7056385 | fae0f10.b28d533f);
		}
		if (((ulong_0 ^ ((ulong_0 ^ ulong_1) & (ulong_1 ^ ulong_2))) & 0x80000000L) > 0L)
		{
			b7056385 = (byte)(b7056385 | fae0f10.bdee4792);
		}
		byte_0 = (byte)((byte_0 & ~byte_1) | (b7056385 & byte_1));
	}
}
