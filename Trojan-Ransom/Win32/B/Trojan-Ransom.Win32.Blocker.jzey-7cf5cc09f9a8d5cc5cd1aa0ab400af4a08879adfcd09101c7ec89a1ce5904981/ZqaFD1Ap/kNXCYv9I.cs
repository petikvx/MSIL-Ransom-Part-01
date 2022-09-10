using System;
using System.IO;
using System.Reflection;
using IoSuaiAb;
using di1mqJMz;
using ns4;
using yer6kF3B;

namespace ZqaFD1Ap;

internal class kNXCYv9I
{
	private const int o1eY2722 = 4096;

	private const int zFocBIoJ = 6;

	private const int wkWhao4s = 4;

	private const int FljflL5j = 4;

	public static void OSH9hD99()
	{
		AppDomain appDomain_ = wBNSfNgl.smethod_4(41280);
		Class16.m8yFGwZR(appDomain_, YmuD8JCG, 37789);
	}

	internal static Assembly YmuD8JCG(object object_0, ResolveEventArgs w8cwWiUk)
	{
		string string_ = U0nDFthS.gn4174gi(Class16.tThlOe8i(w8cwWiUk, 35212), 0, U0nDFthS.a7rPdJnI(FFXb5i9i.UUMks6OM(Class16.tThlOe8i(w8cwWiUk, 35212), 63153), ",", 3436), 12858);
		byte[] byte_ = Class16.n92tsWAo(U0nDFthS.fMEKY27X(18106), string_, 63035);
		string string_2 = Class16.Wq3Y85iR(byte_, 37904);
		Stream stream = Class16.WlJHEhz8(Class16.f0EYAloj(60107), string_2, 42186);
		BinaryReader binaryReader_ = new BinaryReader(stream);
		byte[] array = new byte[Class16.smethod_1(stream, 58151)];
		Class16.smethod_2(binaryReader_, array, 0, array.Length, 3990);
		if (array[0] != 77 && array[1] != 90)
		{
			return Class16.FFTEa34N(aNCNndRP(array), 48190);
		}
		return Class16.FFTEa34N(array, 48190);
	}

	public static byte[] aNCNndRP(byte[] nJZorDJa)
	{
		int num = r9tk6OiV(nJZorDJa);
		int num2 = hXgNi7dW(nJZorDJa);
		int num3 = 0;
		uint num4 = 1u;
		byte[] array = new byte[num];
		int[] array2 = new int[4096];
		byte[] array3 = new byte[4096];
		int num5 = num - 6 - 4 - 1;
		int num6 = -1;
		uint num7 = 0u;
		int num8 = (nJZorDJa[0] >> 2) & 3;
		if (num8 != 1 && num8 != 3)
		{
			throw new ArgumentException("C# version only supports level 1 and 3");
		}
		if ((nJZorDJa[0] & 1) != 1)
		{
			byte[] array4 = new byte[num];
			Class16.Ap5NzaH2(nJZorDJa, hXgNi7dW(nJZorDJa), array4, 0, num, 54215);
			return array4;
		}
		while (true)
		{
			if (num4 == 1)
			{
				num4 = (uint)(nJZorDJa[num2] | (nJZorDJa[num2 + 1] << 8) | (nJZorDJa[num2 + 2] << 16) | (nJZorDJa[num2 + 3] << 24));
				num2 += 4;
				if (num3 <= num5)
				{
					num7 = (uint)((num8 != 1) ? (nJZorDJa[num2] | (nJZorDJa[num2 + 1] << 8) | (nJZorDJa[num2 + 2] << 16) | (nJZorDJa[num2 + 3] << 24)) : (nJZorDJa[num2] | (nJZorDJa[num2 + 1] << 8) | (nJZorDJa[num2 + 2] << 16)));
				}
			}
			if ((num4 & 1) == 1)
			{
				num4 >>= 1;
				uint num10;
				uint num11;
				if (num8 == 1)
				{
					int num9 = ((int)num7 >> 4) & 0xFFF;
					num10 = (uint)array2[num9];
					if ((num7 & 0xFu) != 0)
					{
						num11 = (num7 & 0xF) + 2;
						num2 += 2;
					}
					else
					{
						num11 = nJZorDJa[num2 + 2];
						num2 += 3;
					}
				}
				else
				{
					uint num12;
					if ((num7 & 3) == 0)
					{
						num12 = (num7 & 0xFF) >> 2;
						num11 = 3u;
						num2++;
					}
					else if ((num7 & 2) == 0)
					{
						num12 = (num7 & 0xFFFF) >> 2;
						num11 = 3u;
						num2 += 2;
					}
					else if ((num7 & 1) == 0)
					{
						num12 = (num7 & 0xFFFF) >> 6;
						num11 = ((num7 >> 2) & 0xF) + 3;
						num2 += 2;
					}
					else if ((num7 & 0x7F) != 3)
					{
						num12 = (num7 >> 7) & 0x1FFFFu;
						num11 = ((num7 >> 2) & 0x1F) + 2;
						num2 += 3;
					}
					else
					{
						num12 = num7 >> 15;
						num11 = ((num7 >> 7) & 0xFF) + 3;
						num2 += 4;
					}
					num10 = (uint)(num3 - num12);
				}
				array[num3] = array[num10];
				array[num3 + 1] = array[num10 + 1];
				array[num3 + 2] = array[num10 + 2];
				for (int i = 3; i < num11; i++)
				{
					array[num3 + i] = array[num10 + i];
				}
				num3 += (int)num11;
				if (num8 == 1)
				{
					num7 = (uint)(array[num6 + 1] | (array[num6 + 2] << 8) | (array[num6 + 3] << 16));
					while (num6 < num3 - num11)
					{
						num6++;
						int num9 = (int)(((num7 >> 12) ^ num7) & 0xFFF);
						array2[num9] = num6;
						array3[num9] = 1;
						num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (array[num6 + 3] << 16));
					}
					num7 = (uint)(nJZorDJa[num2] | (nJZorDJa[num2 + 1] << 8) | (nJZorDJa[num2 + 2] << 16));
				}
				else
				{
					num7 = (uint)(nJZorDJa[num2] | (nJZorDJa[num2 + 1] << 8) | (nJZorDJa[num2 + 2] << 16) | (nJZorDJa[num2 + 3] << 24));
				}
				num6 = num3 - 1;
				continue;
			}
			if (num3 > num5)
			{
				break;
			}
			array[num3] = nJZorDJa[num2];
			num3++;
			num2++;
			num4 >>= 1;
			if (num8 == 1)
			{
				while (num6 < num3 - 3)
				{
					num6++;
					int num13 = array[num6] | (array[num6 + 1] << 8) | (array[num6 + 2] << 16);
					int num9 = ((num13 >> 12) ^ num13) & 0xFFF;
					array2[num9] = num6;
					array3[num9] = 1;
				}
				num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (nJZorDJa[num2 + 2] << 16));
			}
			else
			{
				num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (nJZorDJa[num2 + 2] << 16) | (nJZorDJa[num2 + 3] << 24));
			}
		}
		while (num3 <= num - 1)
		{
			if (num4 == 1)
			{
				num2 += 4;
				num4 = 2147483648u;
			}
			array[num3] = nJZorDJa[num2];
			num3++;
			num2++;
			num4 >>= 1;
		}
		return array;
	}

	private static int hXgNi7dW(byte[] obC9rDdF)
	{
		if ((obC9rDdF[0] & 2) != 2)
		{
			return 3;
		}
		return 9;
	}

	public static int r9tk6OiV(byte[] t2LsR54T)
	{
		if (hXgNi7dW(t2LsR54T) == 9)
		{
			return t2LsR54T[5] | (t2LsR54T[6] << 8) | (t2LsR54T[7] << 16) | (t2LsR54T[8] << 24);
		}
		return t2LsR54T[2];
	}
}
