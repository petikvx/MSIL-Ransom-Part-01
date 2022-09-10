using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;

namespace c;

internal sealed class b
{
	public static PaddingMode f => PaddingMode.PKCS7;

	public static string l => t.h(2, 1517858829, '\u0080');

	[SecuritySafeCritical]
	internal static int y(int int_0, int int_1, short short_0, char char_0)
	{
		char[] k = e.e.k;
		int num6 = default(int);
		int num4 = default(int);
		int result = default(int);
		int[] x = default(int[]);
		int num7 = default(int);
		while (true)
		{
			int num = 1260319243;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x7448E4EFu) % 10u)
				{
				default:
					num3 = 11;
					goto IL_000d;
				case 8u:
					switch (((char_0 ^ short_0) - 112) ^ num6)
					{
					case 0:
						break;
					default:
						num = 483683654;
						continue;
					}
					goto default;
				case 7u:
					num = (int)((num2 * 382421436) ^ 0x3B19C23A);
					continue;
				case 6u:
					goto IL_0046;
				case 5u:
					while (true)
					{
						switch (num4)
						{
						case 7:
							break;
						case 4:
							goto IL_0046;
						case 2:
						case 11:
							result = b.smethod_0(int_0, int_1);
							num4 = x[261] - 31522;
							continue;
						case 8:
						case 10:
							num6++;
							num7 = short_0 * short_0;
							num7 = short_0 + num7;
							goto case 1;
						case 1:
							num4 = x[337] - 60897;
							continue;
						case 3:
						{
							result = 3;
							int num5 = x[226];
							e.e.k[435] = (char)((e.e.k[435] + short_0) & '\u0087');
							num4 = num5 - 64348;
							continue;
						}
						case 0:
							goto IL_00cc;
						default:
							goto IL_0113;
						case 5:
							goto IL_0121;
						case 6:
							num4 = 7;
							break;
						case 9:
							return result;
						}
						break;
						IL_00cc:
						if (num7 % 2 == 0)
						{
							num4 = x[41] - 32968;
							continue;
						}
						num4 = 7;
						break;
					}
					goto case 8u;
				case 3u:
					goto IL_0121;
				case 4u:
					x = c.l.x;
					num = ((int)num2 * -1647165430) ^ -388524615;
					continue;
				case 1u:
					num3 = x[346] - 43971;
					goto IL_000d;
				case 0u:
					num = (int)((num2 * 79269633) ^ 0x27EA1DE1);
					continue;
				case 2u:
					break;
					IL_0121:
					num4 = k[39] - 27715;
					num = 1435662182;
					continue;
					IL_0113:
					num = 2079399470;
					continue;
					IL_0046:
					num6 = 0;
					num4 = k[332] - 37509;
					num = 1435662182;
					continue;
					IL_000d:
					num4 = num3;
					num = 384238454;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int w<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, char char_0) where T : Stream
	{
		char[] k = e.e.k;
		int[] x = default(int[]);
		int num4 = default(int);
		int result = default(int);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1873494783;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0x192A6111u) % 12u)
				{
				case 11u:
					num7 = 2;
					goto IL_000c;
				case 10u:
					x = c.l.x;
					num = (int)(num2 * 1776976761) ^ -1523656884;
					continue;
				case 9u:
					switch (((char_0 ^ short_0) - 92) ^ num4)
					{
					default:
						num = 1600646894;
						continue;
					case 0:
						break;
					}
					goto default;
				default:
					num7 = k[546] - 46083;
					goto IL_000c;
				case 7u:
					goto IL_005c;
				case 6u:
					while (true)
					{
						switch (num3)
						{
						case 7:
						case 10:
							break;
						case 6:
							goto IL_005c;
						case 4:
						case 11:
						{
							int num6 = num5 % 2;
							e.e.k[465] = (char)((e.e.k[465] * c.l.x[333]) & 'x');
							if (num6 == 0)
							{
								num3 = x[45] - 55490;
								continue;
							}
							num3 = 10;
							break;
						}
						case 8:
						case 9:
							result = b.smethod_1((Stream)gparam_0, byte_0, int_0, int_1);
							num3 = 0;
							goto case 0;
						case 0:
							num4++;
							num5 = char_0 * char_0;
							num5 = char_0 + num5;
							num3 = 4;
							goto case 4;
						case 2:
							result = 0;
							num3 = k[142] - 64887;
							continue;
						default:
							goto IL_0112;
						case 3:
							num3 = 10;
							break;
						case 5:
							goto IL_0121;
						case 1:
							return result;
						}
						break;
					}
					goto case 9u;
				case 0u:
					goto IL_0121;
				case 5u:
					num = ((int)num2 * -499166932) ^ -409895617;
					continue;
				case 4u:
					num = ((int)num2 * -512013600) ^ -2058110285;
					continue;
				case 2u:
					num3 = k[49] - 32748;
					num = ((int)num2 * -1910315196) ^ -1746687347;
					continue;
				case 1u:
					num = ((int)num2 * -827850655) ^ -1053314930;
					continue;
				case 8u:
					break;
					IL_0121:
					num3 = 6;
					num = 2129797048;
					continue;
					IL_0112:
					num = 1325637705;
					continue;
					IL_005c:
					num4 = 0;
					num = 1684392083;
					continue;
					IL_000c:
					num3 = num7;
					num = 157860300;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long g<T>(T gparam_0, long long_0, SeekOrigin seekOrigin_0, char char_0, short short_0) where T : Stream
	{
		int[] x = c.l.x;
		int num5 = default(int);
		char[] k = default(char[]);
		int num3 = default(int);
		long result = default(long);
		while (true)
		{
			int num = -807814623;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)num ^ 0xDBF1D850u) % 12u)
				{
				case 11u:
					num6 = x[167] - 44455;
					goto IL_0018;
				case 10u:
					num5 = 0;
					num = -1202787432;
					continue;
				case 9u:
					goto IL_002f;
				case 7u:
					goto IL_0039;
				default:
					num6 = k[400] - 57829;
					goto IL_0018;
				case 5u:
					num = ((int)num2 * -1438781729) ^ -1054513936;
					continue;
				case 4u:
					num3 = x[205] - 60896;
					num = (int)(num2 * 199279485) ^ -1951682641;
					continue;
				case 3u:
					while (true)
					{
						switch (num3)
						{
						case 1:
						case 6:
							break;
						case 7:
							goto IL_002f;
						case 5:
							goto IL_0039;
						case 4:
						case 10:
							num5++;
							num3 = k[161] - 38122;
							continue;
						case 9:
						{
							result = 9L;
							int num4 = x[208];
							c.l.x[211] = (c.l.x[211] + short_0) & 9;
							num3 = num4 - 14604;
							continue;
						}
						case 0:
						case 8:
							result = b.smethod_2((Stream)gparam_0, long_0, seekOrigin_0);
							num3 = x[157] - 19142;
							continue;
						default:
							goto IL_0132;
						case 3:
							num3 = 5;
							goto IL_0039;
						case 2:
							return result;
						}
						break;
					}
					goto case 10u;
				case 2u:
					num3 = 6;
					num = ((int)num2 * -308123579) ^ 0x7BE2E7E7;
					continue;
				case 1u:
					k = e.e.k;
					num = ((int)num2 * -1385719378) ^ 0x4F0FC8BA;
					continue;
				case 0u:
					num = (int)((num2 * 1708180995) ^ 0x1D96D976);
					continue;
				case 8u:
					break;
					IL_0132:
					num = -1613866963;
					continue;
					IL_0039:
					switch (((char_0 ^ short_0) - 118) ^ num5)
					{
					default:
						num = -1263791465;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_002f:
					num = -1688223338;
					continue;
					IL_0018:
					num3 = num6;
					num = -1268379897;
					continue;
				}
				break;
			}
		}
	}

	static int smethod_0(int int_0, int int_1)
	{
		return Math.Min(int_0, int_1);
	}

	static int smethod_1(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		return stream_0.Read(byte_0, int_0, int_1);
	}

	static long smethod_2(Stream stream_0, long long_0, SeekOrigin seekOrigin_0)
	{
		return stream_0.Seek(long_0, seekOrigin_0);
	}
}
