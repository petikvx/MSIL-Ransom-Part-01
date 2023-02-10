using System;

namespace xClient.Core.Compression;

public static class SafeQuickLZ
{
	public const int QLZ_VERSION_MAJOR = 1;

	public const int QLZ_VERSION_MINOR = 5;

	public const int QLZ_VERSION_REVISION = 0;

	public const int QLZ_STREAMING_BUFFER = 0;

	public const int QLZ_MEMORY_SAFE = 0;

	private const int HASH_VALUES = 4096;

	private const int MINOFFSET = 2;

	private const int UNCONDITIONAL_MATCHLEN = 6;

	private const int UNCOMPRESSED_END = 4;

	private const int CWORD_LEN = 4;

	private const int DEFAULT_HEADERLEN = 9;

	private const int QLZ_POINTERS_1 = 1;

	private const int QLZ_POINTERS_3 = 16;

	private static int HeaderLength(byte[] source)
	{
		if ((source[0] & 2) != 2)
		{
			return 3;
		}
		return 9;
	}

	public static int SizeDecompressed(byte[] source)
	{
		if (HeaderLength(source) == 9)
		{
			return source[5] | (source[6] << 8) | (source[7] << 16) | (source[8] << 24);
		}
		return source[2];
	}

	public static int SizeCompressed(byte[] source)
	{
		if (HeaderLength(source) == 9)
		{
			return source[1] | (source[2] << 8) | (source[3] << 16) | (source[4] << 24);
		}
		return source[1];
	}

	private static void WriteHeader(byte[] dst, int level, bool compressible, int sizeCompressed, int sizeDecompressed)
	{
		dst[0] = (byte)(2u | (compressible ? 1u : 0u));
		dst[0] |= (byte)(level << 2);
		dst[0] |= 64;
		dst[0] |= 0;
		FastWrite(dst, 1, sizeDecompressed, 4);
		FastWrite(dst, 5, sizeCompressed, 4);
	}

	public static byte[] Compress(byte[] source, int level = 3)
	{
		if (source.Length == 0)
		{
			return new byte[0];
		}
		int[,] array = level switch
		{
			1 => new int[4096, 1], 
			3 => new int[4096, 16], 
			_ => throw new ArgumentException("C# version only supports level 1 and 3"), 
		};
		int i = 0;
		int num = 13;
		uint num2 = 2147483648u;
		int i2 = 9;
		byte[] array2 = new byte[source.Length + 400];
		int[] array3 = new int[4096];
		byte[] array4 = new byte[4096];
		int num3 = 0;
		int num4 = source.Length - 6 - 4 - 1;
		int num5 = 0;
		if (i <= num4)
		{
			num3 = source[i] | (source[i + 1] << 8) | (source[i + 2] << 16);
		}
		byte[] array5;
		while (i <= num4)
		{
			if ((num2 & 1) == 1)
			{
				if (i > source.Length >> 1 && num > i - (i >> 5))
				{
					array5 = new byte[source.Length + 9];
					WriteHeader(array5, level, compressible: false, source.Length, source.Length + 9);
					Array.Copy(source, 0, array5, 9, source.Length);
					return array5;
				}
				FastWrite(array2, i2, (int)(num2 >> 1) | int.MinValue, 4);
				i2 = num;
				num += 4;
				num2 = 2147483648u;
			}
			if (level == 1)
			{
				int num6 = ((num3 >> 12) ^ num3) & 0xFFF;
				int num7 = array[num6, 0];
				int num8 = array3[num6] ^ num3;
				array3[num6] = num3;
				array[num6, 0] = i;
				if (num8 == 0 && array4[num6] != 0 && (i - num7 > 2 || (i == num7 + 1 && num5 >= 3 && i > 3 && source[i] == source[i - 3] && source[i] == source[i - 2] && source[i] == source[i - 1] && source[i] == source[i + 1] && source[i] == source[i + 2])))
				{
					num2 = (num2 >> 1) | 0x80000000u;
					if (source[num7 + 3] != source[i + 3])
					{
						int num9 = 1 | (num6 << 4);
						array2[num] = (byte)num9;
						array2[num + 1] = (byte)(num9 >> 8);
						i += 3;
						num += 2;
					}
					else
					{
						int num10 = i;
						int num11 = ((source.Length - 4 - i + 1 - 1 > 255) ? 255 : (source.Length - 4 - i + 1 - 1));
						i += 4;
						if (source[num7 + i - num10] == source[i])
						{
							i++;
							if (source[num7 + i - num10] == source[i])
							{
								for (i++; source[num7 + (i - num10)] == source[i] && i - num10 < num11; i++)
								{
								}
							}
						}
						int num12 = i - num10;
						num6 <<= 4;
						if (num12 < 18)
						{
							int num13 = num6 | (num12 - 2);
							array2[num] = (byte)num13;
							array2[num + 1] = (byte)(num13 >> 8);
							num += 2;
						}
						else
						{
							FastWrite(array2, num, num6 | (num12 << 16), 3);
							num += 3;
						}
					}
					num3 = source[i] | (source[i + 1] << 8) | (source[i + 2] << 16);
					num5 = 0;
				}
				else
				{
					num5++;
					array4[num6] = 1;
					array2[num] = source[i];
					num2 >>= 1;
					i++;
					num++;
					num3 = ((num3 >> 8) & 0xFFFF) | (source[i + 2] << 16);
				}
				continue;
			}
			num3 = source[i] | (source[i + 1] << 8) | (source[i + 2] << 16);
			int num14 = ((source.Length - 4 - i + 1 - 1 > 255) ? 255 : (source.Length - 4 - i + 1 - 1));
			int num15 = ((num3 >> 12) ^ num3) & 0xFFF;
			byte b = array4[num15];
			int num16 = 0;
			int num17 = 0;
			int num18;
			for (int j = 0; j < 16 && b > j; j++)
			{
				num18 = array[num15, j];
				if ((byte)num3 == source[num18] && (byte)(num3 >> 8) == source[num18 + 1] && (byte)(num3 >> 16) == source[num18 + 2] && num18 < i - 2)
				{
					int k;
					for (k = 3; source[num18 + k] == source[i + k] && k < num14; k++)
					{
					}
					if (k > num16 || (k == num16 && num18 > num17))
					{
						num17 = num18;
						num16 = k;
					}
				}
			}
			num18 = num17;
			array[num15, b & 0xF] = i;
			b = (array4[num15] = (byte)(b + 1));
			if (num16 >= 3 && i - num18 < 131071)
			{
				int num19 = i - num18;
				for (int l = 1; l < num16; l++)
				{
					num3 = source[i + l] | (source[i + l + 1] << 8) | (source[i + l + 2] << 16);
					num15 = ((num3 >> 12) ^ num3) & 0xFFF;
					array[num15, array4[num15]++ & 0xF] = i + l;
				}
				i += num16;
				num2 = (num2 >> 1) | 0x80000000u;
				if (num16 == 3 && num19 <= 63)
				{
					FastWrite(array2, num, num19 << 2, 1);
					num++;
				}
				else if (num16 == 3 && num19 <= 16383)
				{
					FastWrite(array2, num, (num19 << 2) | 1, 2);
					num += 2;
				}
				else if (num16 <= 18 && num19 <= 1023)
				{
					FastWrite(array2, num, (num16 - 3 << 2) | (num19 << 6) | 2, 2);
					num += 2;
				}
				else if (num16 <= 33)
				{
					FastWrite(array2, num, (num16 - 2 << 2) | (num19 << 7) | 3, 3);
					num += 3;
				}
				else
				{
					FastWrite(array2, num, (num16 - 3 << 7) | (num19 << 15) | 3, 4);
					num += 4;
				}
				num5 = 0;
			}
			else
			{
				array2[num] = source[i];
				num2 >>= 1;
				i++;
				num++;
			}
		}
		while (i <= source.Length - 1)
		{
			if ((num2 & 1) == 1)
			{
				FastWrite(array2, i2, (int)(num2 >> 1) | int.MinValue, 4);
				i2 = num;
				num += 4;
				num2 = 2147483648u;
			}
			array2[num] = source[i];
			i++;
			num++;
			num2 >>= 1;
		}
		while ((num2 & 1) != 1)
		{
			num2 >>= 1;
		}
		FastWrite(array2, i2, (int)(num2 >> 1) | int.MinValue, 4);
		WriteHeader(array2, level, compressible: true, source.Length, num);
		array5 = new byte[num];
		Array.Copy(array2, array5, num);
		return array5;
	}

	private static void FastWrite(byte[] a, int i, int value, int numbytes)
	{
		for (int j = 0; j < numbytes; j++)
		{
			a[i + j] = (byte)(value >> j * 8);
		}
	}

	public static byte[] Decompress(byte[] source)
	{
		if (source.Length == 0)
		{
			return new byte[0];
		}
		int num = (source[0] >> 2) & 3;
		if (num != 1 && num != 3)
		{
			throw new ArgumentException("C# version only supports level 1 and 3");
		}
		int num2 = SizeDecompressed(source);
		int num3 = HeaderLength(source);
		int num4 = 0;
		uint num5 = 1u;
		byte[] array = new byte[num2];
		int[] array2 = new int[4096];
		byte[] array3 = new byte[4096];
		int num6 = num2 - 6 - 4 - 1;
		int num7 = -1;
		uint num8 = 0u;
		if ((source[0] & 1) != 1)
		{
			byte[] array4 = new byte[num2];
			Array.Copy(source, HeaderLength(source), array4, 0, num2);
			return array4;
		}
		while (true)
		{
			if (num5 == 1)
			{
				num5 = (uint)(source[num3] | (source[num3 + 1] << 8) | (source[num3 + 2] << 16) | (source[num3 + 3] << 24));
				num3 += 4;
				if (num4 <= num6)
				{
					num8 = (uint)((num != 1) ? (source[num3] | (source[num3 + 1] << 8) | (source[num3 + 2] << 16) | (source[num3 + 3] << 24)) : (source[num3] | (source[num3 + 1] << 8) | (source[num3 + 2] << 16)));
				}
			}
			if ((num5 & 1) == 1)
			{
				num5 >>= 1;
				uint num10;
				uint num11;
				if (num == 1)
				{
					int num9 = ((int)num8 >> 4) & 0xFFF;
					num10 = (uint)array2[num9];
					if ((num8 & 0xFu) != 0)
					{
						num11 = (num8 & 0xF) + 2;
						num3 += 2;
					}
					else
					{
						num11 = source[num3 + 2];
						num3 += 3;
					}
				}
				else
				{
					uint num12;
					if ((num8 & 3) == 0)
					{
						num12 = (num8 & 0xFF) >> 2;
						num11 = 3u;
						num3++;
					}
					else if ((num8 & 2) == 0)
					{
						num12 = (num8 & 0xFFFF) >> 2;
						num11 = 3u;
						num3 += 2;
					}
					else if ((num8 & 1) == 0)
					{
						num12 = (num8 & 0xFFFF) >> 6;
						num11 = ((num8 >> 2) & 0xF) + 3;
						num3 += 2;
					}
					else if ((num8 & 0x7F) != 3)
					{
						num12 = (num8 >> 7) & 0x1FFFFu;
						num11 = ((num8 >> 2) & 0x1F) + 2;
						num3 += 3;
					}
					else
					{
						num12 = num8 >> 15;
						num11 = ((num8 >> 7) & 0xFF) + 3;
						num3 += 4;
					}
					num10 = (uint)(num4 - num12);
				}
				array[num4] = array[num10];
				array[num4 + 1] = array[num10 + 1];
				array[num4 + 2] = array[num10 + 2];
				for (int i = 3; i < num11; i++)
				{
					array[num4 + i] = array[num10 + i];
				}
				num4 += (int)num11;
				if (num == 1)
				{
					num8 = (uint)(array[num7 + 1] | (array[num7 + 2] << 8) | (array[num7 + 3] << 16));
					while (num7 < num4 - num11)
					{
						num7++;
						int num9 = (int)(((num8 >> 12) ^ num8) & 0xFFF);
						array2[num9] = num7;
						array3[num9] = 1;
						num8 = (uint)(((num8 >> 8) & 0xFFFFu) | (array[num7 + 3] << 16));
					}
					num8 = (uint)(source[num3] | (source[num3 + 1] << 8) | (source[num3 + 2] << 16));
				}
				else
				{
					num8 = (uint)(source[num3] | (source[num3 + 1] << 8) | (source[num3 + 2] << 16) | (source[num3 + 3] << 24));
				}
				num7 = num4 - 1;
				continue;
			}
			if (num4 > num6)
			{
				break;
			}
			array[num4] = source[num3];
			num4++;
			num3++;
			num5 >>= 1;
			if (num == 1)
			{
				while (num7 < num4 - 3)
				{
					num7++;
					int num13 = array[num7] | (array[num7 + 1] << 8) | (array[num7 + 2] << 16);
					int num9 = ((num13 >> 12) ^ num13) & 0xFFF;
					array2[num9] = num7;
					array3[num9] = 1;
				}
				num8 = (uint)(((num8 >> 8) & 0xFFFFu) | (source[num3 + 2] << 16));
			}
			else
			{
				num8 = (uint)(((num8 >> 8) & 0xFFFFu) | (source[num3 + 2] << 16) | (source[num3 + 3] << 24));
			}
		}
		while (num4 <= num2 - 1)
		{
			if (num5 == 1)
			{
				num3 += 4;
				num5 = 2147483648u;
			}
			array[num4] = source[num3];
			num4++;
			num3++;
			num5 >>= 1;
		}
		return array;
	}
}
