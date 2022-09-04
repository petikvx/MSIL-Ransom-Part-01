using System;

public class Deflate
{
	private const int HASH_VALUES = 4096;

	private const int UNCONDITIONAL_MATCHLEN = 6;

	private const int UNCOMPRESSED_END = 4;

	private const int CWORD_LEN = 4;

	private static int headerLen(byte[] source)
	{
		if ((source[0] & 2) != 2)
		{
			return 3;
		}
		return 9;
	}

	public static int sizeDecompressed(byte[] source)
	{
		if (headerLen(source) == 9)
		{
			return source[5] | (source[6] << 8) | (source[7] << 16) | (source[8] << 24);
		}
		return source[2];
	}

	public static byte[] Decompress(byte[] source)
	{
		int num = sizeDecompressed(source);
		int num2 = headerLen(source);
		int num3 = 0;
		uint num4 = 1u;
		byte[] array = new byte[num];
		int num5 = num - 6 - 4 - 1;
		uint num6 = 0u;
		int num7 = (source[0] >> 2) & 3;
		if ((source[0] & 1) != 1)
		{
			byte[] array2 = new byte[num];
			Array.Copy(source, headerLen(source), array2, 0, num);
			return array2;
		}
		while (true)
		{
			if (num4 == 1)
			{
				num4 = (uint)(source[num2] | (source[num2 + 1] << 8) | (source[num2 + 2] << 16) | (source[num2 + 3] << 24));
				num2 += 4;
				if (num3 <= num5)
				{
					num6 = (uint)((num7 != 1) ? (source[num2] | (source[num2 + 1] << 8) | (source[num2 + 2] << 16) | (source[num2 + 3] << 24)) : (source[num2] | (source[num2 + 1] << 8) | (source[num2 + 2] << 16)));
				}
			}
			if ((num4 & 1) == 1)
			{
				num4 >>= 1;
				uint num8;
				uint num9;
				if ((num6 & 3) == 0)
				{
					num8 = (num6 & 0xFF) >> 2;
					num9 = 3u;
					num2++;
				}
				else if ((num6 & 2) == 0)
				{
					num8 = (num6 & 0xFFFF) >> 2;
					num9 = 3u;
					num2 += 2;
				}
				else if ((num6 & 1) == 0)
				{
					num8 = (num6 & 0xFFFF) >> 6;
					num9 = ((num6 >> 2) & 0xF) + 3;
					num2 += 2;
				}
				else if ((num6 & 0x7F) != 3)
				{
					num8 = (num6 >> 7) & 0x1FFFFu;
					num9 = ((num6 >> 2) & 0x1F) + 2;
					num2 += 3;
				}
				else
				{
					num8 = num6 >> 15;
					num9 = ((num6 >> 7) & 0xFF) + 3;
					num2 += 4;
				}
				uint num10 = (uint)(num3 - num8);
				array[num3] = array[num10];
				array[num3 + 1] = array[num10 + 1];
				array[num3 + 2] = array[num10 + 2];
				for (int i = 3; i < num9; i++)
				{
					array[num3 + i] = array[num10 + i];
				}
				num3 += (int)num9;
				num6 = (uint)(source[num2] | (source[num2 + 1] << 8) | (source[num2 + 2] << 16) | (source[num2 + 3] << 24));
			}
			else
			{
				if (num3 > num5)
				{
					break;
				}
				array[num3] = source[num2];
				num3++;
				num2++;
				num4 >>= 1;
				num6 = ((num6 >> 8) & 0xFFFFu) | (uint)(source[num2 + 2] << 16) | (uint)(source[num2 + 3] << 24);
			}
		}
		while (num3 <= num - 1)
		{
			if (num4 == 1)
			{
				num2 += 4;
				num4 = 2147483648u;
			}
			array[num3] = source[num2];
			num3++;
			num2++;
			num4 >>= 1;
		}
		return array;
	}
}
