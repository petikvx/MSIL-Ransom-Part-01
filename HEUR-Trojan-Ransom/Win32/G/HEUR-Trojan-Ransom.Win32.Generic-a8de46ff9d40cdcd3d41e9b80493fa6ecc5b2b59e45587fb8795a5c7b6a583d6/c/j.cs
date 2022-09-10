using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace c;

internal sealed class j
{
	static void e(v.w w_0)
	{
		byte[] array = h.d;
		char[] array2 = default(char[]);
		int num4 = default(int);
		while (true)
		{
			int num = 683541631;
			while (true)
			{
				uint num2;
				int num3;
				int num5;
				switch ((num2 = (uint)num ^ 0x32FE2DDBu) % 7u)
				{
				case 6u:
					array2 = x.s;
					num4 = 2;
					num = (int)(num2 * 567066989) ^ -1110043671;
					continue;
				default:
					num3 = 1;
					goto IL_0026;
				case 3u:
					while (true)
					{
						switch (num4)
						{
						case 5:
						case 7:
							w_0.h[w_0.v++] = (byte)w_0.y;
							num4 = array2[259] - 23130;
							continue;
						case 6:
							if (w_0.h <= 8)
							{
								num4 = array2[119] - 40048;
								continue;
							}
							num4 = 0;
							goto case 0;
						case 2:
						case 4:
							goto IL_00a6;
						case 0:
							w_0.h[w_0.v++] = (byte)(w_0.y >> 8);
							num4 = 1;
							goto case 1;
						case 1:
							w_0.y = 0u;
							goto case 3;
						case 3:
							w_0.h = 0;
							return;
						}
						break;
					}
					num = 2058706393;
					continue;
				case 0u:
					goto IL_00a6;
				case 2u:
					num = (int)((num2 * 1965013314) ^ 0xDF4B791);
					continue;
				case 1u:
					num3 = array[270] - array[249];
					goto IL_0026;
				case 5u:
					break;
					IL_00a6:
					if (w_0.h > 0)
					{
						num = 277902451;
						num5 = 277902451;
					}
					else
					{
						num = 1360227875;
						num5 = 1360227875;
					}
					continue;
					IL_0026:
					num4 = num3;
					num = 2138241613;
					continue;
				}
				break;
			}
		}
	}

	static bool x(int int_0, v.j j_0)
	{
		char[] array = x.s;
		int num = 0;
		while (true)
		{
			int num2 = 1715603636;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x174B200Bu) % 9u)
				{
				case 8u:
					j_0.j[j_0.l++] = (byte)int_0;
					num = array[19] - 22432;
					num2 = 1830501940;
					continue;
				case 7u:
					num2 = ((int)num3 * -935397781) ^ -1369092950;
					continue;
				case 5u:
					switch (num)
					{
					case 3:
					case 5:
						break;
					default:
						goto IL_0069;
					case 0:
						goto IL_0070;
					case 2:
						goto IL_0085;
					case 4:
						goto IL_008e;
					case 1:
						goto IL_00fe;
					}
					goto case 8u;
				case 3u:
					goto IL_0070;
				case 2u:
					goto IL_0085;
				case 4u:
					goto IL_008e;
				case 1u:
					num2 = ((int)num3 * -1840399041) ^ 0x20BCFC35;
					continue;
				case 0u:
					break;
				default:
					goto IL_00fe;
					IL_00fe:
					return j_0.l >= 16384;
					IL_008e:
					j_0.v.a[int_0]++;
					num2 = 1274442506;
					continue;
					IL_0085:
					num = 1;
					num2 = 1288611793;
					continue;
					IL_0070:
					j_0.g[j_0.l] = 0;
					num2 = 1672502393;
					continue;
					IL_0069:
					num2 = 547518272;
					continue;
				}
				break;
			}
		}
	}

	static byte[] w(MemoryStream memoryStream_0, byte[] byte_0, ICryptoTransform icryptoTransform_0)
	{
		char[] array = x.s;
		object obj = j.smethod_0((Stream)memoryStream_0, icryptoTransform_0, CryptoStreamMode.Write);
		Array array2 = default(Array);
		try
		{
			while (true)
			{
				IL_00d1:
				int num = 5;
				int num2 = -1265879256;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xCD9ACAA6u) % 10u)
					{
					case 8u:
						switch (num)
						{
						case 0:
						case 1:
							goto IL_003a;
						case 3:
							goto IL_0049;
						case 2:
						case 4:
						case 5:
							goto IL_005b;
						}
						num2 = -1163271859;
						continue;
					case 1u:
						goto IL_003a;
					case 4u:
						goto IL_0049;
					case 3u:
					case 5u:
						goto IL_005b;
					case 7u:
						num2 = ((int)num3 * -1085913692) ^ 0x4080B8B4;
						continue;
					case 6u:
						num2 = -1163304253;
						continue;
					case 0u:
						num = 1;
						num2 = ((int)num3 * -1705851393) ^ 0x4902E81F;
						continue;
					default:
						goto end_IL_0097;
					case 9u:
						break;
					case 2u:
						goto end_IL_0097;
						IL_005b:
						j.smethod_1((Stream)(CryptoStream)obj, byte_0, 0, byte_0.Length);
						num2 = -1183151552;
						continue;
						IL_0049:
						j.smethod_2((CryptoStream)obj);
						num2 = -1074904276;
						continue;
						IL_003a:
						array2 = j.smethod_3(memoryStream_0);
						num2 = -772385668;
						continue;
					}
					goto IL_00d1;
					continue;
					end_IL_0097:
					break;
				}
				break;
			}
		}
		finally
		{
			while (true)
			{
				IL_0180:
				int num4 = 5;
				int num5 = -705467974;
				while (true)
				{
					uint num3;
					int num6;
					switch ((num3 = (uint)num5 ^ 0xCD9ACAA6u) % 7u)
					{
					default:
						num6 = 2;
						goto IL_00e6;
					case 4u:
						switch (num4)
						{
						default:
							num5 = -1068448603;
							continue;
						case 3:
						case 5:
						case 6:
							break;
						case 0:
						case 1:
						case 4:
							j.smethod_4((IDisposable)(obj as CryptoStream));
							goto end_IL_0150;
						case 2:
							goto end_IL_0150;
						}
						goto case 0u;
					case 0u:
					case 1u:
					{
						int num7;
						if (obj is CryptoStream)
						{
							num5 = -1278712377;
							num7 = -1278712377;
						}
						else
						{
							num5 = -666242558;
							num7 = -666242558;
						}
						continue;
					}
					case 3u:
						num5 = -773929782;
						continue;
					case 2u:
						num6 = array[285] - 3456;
						goto IL_00e6;
					case 6u:
						break;
						IL_00e6:
						num4 = num6;
						num5 = -705467974;
						continue;
					}
					goto IL_0180;
					continue;
					end_IL_0150:
					break;
				}
				break;
			}
		}
		while (true)
		{
			int num8 = 0;
			int num9 = -557110470;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num9 ^ 0xCD9ACAA6u) % 5u)
				{
				case 3u:
					num9 = -133749977;
					continue;
				case 1u:
					switch (num8)
					{
					default:
						num9 = (int)(num3 * 1497041660) ^ -247286583;
						continue;
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
						break;
					}
					goto default;
				case 2u:
					break;
				default:
					return (byte[])array2;
				}
				break;
			}
		}
	}

	static void w(int int_0, v.j j_0)
	{
		byte[] array = h.d;
		int num5 = default(int);
		int num3 = default(int);
		object obj = default(object);
		while (true)
		{
			int num = -1046019612;
			while (true)
			{
				uint num2;
				int num4;
				switch ((num2 = (uint)num ^ 0x8F05FE06u) % 19u)
				{
				case 18u:
					num = ((int)num2 * -79890146) ^ 0x36C41CE4;
					continue;
				case 17u:
				{
					int num6;
					if (num5 >= int_0)
					{
						num = -1521073899;
						num6 = -1521073899;
					}
					else
					{
						num = -526219116;
						num6 = -526219116;
					}
					continue;
				}
				case 16u:
					goto IL_003d;
				case 15u:
					num4 = 7;
					goto IL_0073;
				case 14u:
					goto IL_007e;
				case 13u:
					goto IL_008a;
				case 12u:
					num3 = 10;
					num = ((int)num2 * -156621231) ^ 0x2A1FA3F;
					continue;
				case 11u:
					num = (int)(num2 * 2089307943) ^ -830045673;
					continue;
				case 10u:
					while (true)
					{
						switch (num3)
						{
						case 10:
							break;
						case 6:
							goto IL_003d;
						case 3:
						case 4:
							goto IL_007e;
						case 5:
							goto IL_008a;
						case 7:
							obj = j_0.v;
							goto case 0;
						case 0:
						{
							object obj2 = j_0.j;
							j.e((v.j.m)obj2, (v.j.m)obj);
							num3 = array[173] - 8;
							continue;
						}
						default:
							goto IL_0130;
						case 2:
							goto IL_013a;
						case 8:
							goto IL_0165;
						case 9:
							goto IL_0173;
						case 1:
						{
							obj = j_0.w;
							object obj2 = j_0.j;
							j.e(obj2 as v.j.m, (v.j.m)obj);
							return;
						}
						}
						break;
					}
					goto case 17u;
				case 7u:
					goto IL_013a;
				case 0u:
					goto IL_0165;
				case 6u:
					goto IL_0173;
				case 9u:
					num = ((int)num2 * -646534317) ^ -835156062;
					continue;
				default:
					num4 = array[216] - 195;
					goto IL_0073;
				case 5u:
					num = (int)((num2 * 378474350) ^ 0x18E120A8);
					continue;
				case 3u:
					num = ((int)num2 * -1007158479) ^ -541876959;
					continue;
				case 2u:
					num3 = 10;
					num = ((int)num2 * -1347822049) ^ -75262391;
					continue;
				case 1u:
					num3 = 5;
					num = ((int)num2 * -432678860) ^ 0x17AA870C;
					continue;
				case 4u:
					break;
					IL_0173:
					j.o(j_0.y, j_0.w.j - 1, 5);
					j.o(j_0.y, int_0 - 4, 4);
					num3 = 4;
					num = -938061596;
					continue;
					IL_0165:
					num5++;
					num = -1786469777;
					continue;
					IL_013a:
					j.o(j_0.y, (int)j_0.j.y[v.j.y[num5]], 3);
					num3 = 8;
					num = -1890030253;
					continue;
					IL_0130:
					num = -456952587;
					continue;
					IL_008a:
					j.f(j_0.j);
					j.f(j_0.v);
					num = -2064319391;
					continue;
					IL_007e:
					num5 = 0;
					num = -1092804064;
					continue;
					IL_0073:
					num3 = num4;
					num = -1855574300;
					continue;
					IL_003d:
					j.f(j_0.w);
					j.o(j_0.y, j_0.v.j - 257, 5);
					num3 = 9;
					num = -1809815540;
					continue;
				}
				break;
			}
		}
	}

	static void t(v.j j_0)
	{
		char[] array = x.s;
		byte[] array2 = h.d;
		int num4 = default(int);
		int num8 = default(int);
		int num3 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = 1343619689;
			while (true)
			{
				uint num2;
				int num6;
				int num11;
				switch ((num2 = (uint)num ^ 0x120B77DAu) % 12u)
				{
				case 11u:
					num = ((int)num2 * -1557816100) ^ 0x15053C7;
					continue;
				case 9u:
					while (true)
					{
						switch (num5)
						{
						case 16:
							j.o(j_0.y, num4 & ((1 << num8) - 1), num8);
							num5 = 10;
							goto case 10;
						case 10:
							num3++;
							num5 = array2[272];
							continue;
						case 14:
							if (num8 > 0)
							{
								num5 = 9;
								goto case 9;
							}
							num5 = array[293] - 18521;
							continue;
						case 9:
							if (num8 <= 5)
							{
								num5 = 2;
								goto case 2;
							}
							num5 = array2[288] - 142;
							continue;
						case 2:
							j.o(j_0.y, num9 & ((1 << num8) - 1), num8);
							goto case 13;
						case 13:
						{
							int num7 = j.j(j_0, num4);
							j.v(j_0.w, num7);
							num8 = num7 / 2 - 1;
							num5 = 12;
							goto case 8;
						}
						case 8:
						case 12:
							if (num8 > 0)
							{
								num5 = 16;
								goto case 16;
							}
							num5 = 10;
							goto case 10;
						case 11:
							num8 = (num10 - 261) / 4;
							num5 = 14;
							goto case 14;
						case 5:
							num10 = j.c(j_0, num9);
							j.v(j_0.v, num10);
							goto case 11;
						case 3:
							j.v(j_0.v, num9);
							goto case 10;
						case 1:
							if (num3 < j_0.l)
							{
								num5 = array[203] - 47248;
								continue;
							}
							num5 = 0;
							goto case 0;
						case 6:
							goto IL_017c;
						case 7:
							goto IL_0197;
						case 4:
						case 15:
							goto IL_01b9;
						case 0:
							j.v(j_0.v, 256);
							return;
						}
						break;
					}
					num = 1119192471;
					continue;
				case 6u:
					goto IL_017c;
				case 3u:
					goto IL_0197;
				case 1u:
					goto IL_01b9;
				case 8u:
					num6 = 5;
					goto IL_01c6;
				case 7u:
					num5 = 15;
					num = (int)(num2 * 1070927480) ^ -359148485;
					continue;
				default:
					num6 = array[138] - 11982;
					goto IL_01c6;
				case 4u:
					num5 = array[555] - 19456;
					num = (int)(num2 * 58719894) ^ -1488352590;
					continue;
				case 2u:
					num4 = j_0.g[num3];
					num = ((int)num2 * -120988550) ^ -1431093186;
					continue;
				case 0u:
					num = ((int)num2 * -1896788505) ^ 0x444DB07B;
					continue;
				case 10u:
					break;
					IL_01c6:
					num5 = num6;
					num = 2142904787;
					continue;
					IL_01b9:
					num3 = 0;
					num5 = 1;
					num = 420607993;
					continue;
					IL_0197:
					if (num4-- == 0)
					{
						num = 1378837227;
						num11 = 1378837227;
					}
					else
					{
						num = 1063548254;
						num11 = 1063548254;
					}
					continue;
					IL_017c:
					num9 = j_0.j[num3] & 0xFF;
					num = 617415044;
					continue;
				}
				break;
			}
		}
	}

	static void l(v.e e_0)
	{
		e_0.g = 0;
		e_0.a = 0;
		e_0.x = 0;
		e_0.k = 0u;
	}

	static v.t g(v.b b_0)
	{
		char[] array = x.s;
		int num = 1;
		object obj = default(object);
		while (true)
		{
			int num2 = 493636492;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x33ADC99Au) % 6u)
				{
				case 4u:
					switch (num)
					{
					case 1:
						goto IL_002e;
					case 0:
					case 4:
						goto IL_0041;
					case 2:
					case 3:
						goto IL_00ae;
					}
					num2 = 644381424;
					continue;
				case 2u:
					goto IL_002e;
				case 1u:
					goto IL_0041;
				case 3u:
					num = array[105] - 63127;
					num2 = ((int)num3 * -1675822792) ^ -1868095404;
					continue;
				case 5u:
					break;
				default:
					goto IL_00ae;
					IL_00ae:
					return new v.t((byte[])obj);
					IL_0041:
					j.smethod_5((Array)b_0.w, b_0.t, (Array)(obj as byte[]), 0, b_0.o);
					num2 = 1034418711;
					continue;
					IL_002e:
					obj = new byte[b_0.o];
					num2 = 1524360715;
					continue;
				}
				break;
			}
		}
	}

	static bool h(int int_0, int int_1, v.j j_0)
	{
		byte[] array = h.d;
		char[] array2 = x.s;
		int num6 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 1777867211;
			while (true)
			{
				uint num2;
				int num3;
				int num7;
				switch ((num2 = (uint)num ^ 0x5C331AF2u) % 12u)
				{
				case 11u:
					while (true)
					{
						switch (num4)
						{
						case 11:
							if (num6 < 285)
							{
								num4 = 0;
								goto case 0;
							}
							num4 = 5;
							goto case 5;
						case 0:
							j_0.b += (num6 - 261) / 4;
							num4 = array[94];
							continue;
						case 5:
							num5 = j.j(j_0, int_1 - 1);
							goto case 6;
						case 6:
							j_0.w.a[num5]++;
							num4 = 3;
							goto case 3;
						case 3:
							if (num5 >= 4)
							{
								num4 = array2[264] - 17041;
								continue;
							}
							num4 = 1;
							goto case 1;
						case 2:
							goto IL_00bf;
						case 7:
							goto IL_00e4;
						case 8:
							goto IL_00f9;
						case 4:
						case 10:
							goto IL_0112;
						case 9:
							j_0.b += num5 / 2 - 1;
							num4 = 1;
							goto case 1;
						case 1:
							return j_0.l >= 16384;
						}
						break;
					}
					num = 1508938757;
					continue;
				case 5u:
					goto IL_00bf;
				case 10u:
					goto IL_00e4;
				case 7u:
					goto IL_00f9;
				case 3u:
					goto IL_0112;
				case 9u:
					num = (int)(num2 * 556149263) ^ -1357256858;
					continue;
				case 8u:
					j_0.j[j_0.l++] = (byte)(int_0 - 3);
					num4 = 7;
					num = ((int)num2 * -99979594) ^ 0x29FE6DBF;
					continue;
				default:
					num3 = 5;
					goto IL_0178;
				case 2u:
					num4 = 2;
					num = ((int)num2 * -493834481) ^ -1129649185;
					continue;
				case 1u:
					num4 = 8;
					num = ((int)num2 * -494250644) ^ 0x4808EC09;
					continue;
				case 0u:
					num3 = 11;
					goto IL_0178;
				case 4u:
					break;
					IL_0178:
					num4 = num3;
					num = 1618584837;
					continue;
					IL_0112:
					j_0.v.a[num6]++;
					num = 1887345012;
					continue;
					IL_00f9:
					j_0.g[j_0.l] = (short)int_1;
					num = 1200686146;
					continue;
					IL_00e4:
					num6 = j.c(j_0, int_0 - 3);
					num = 1451519821;
					continue;
					IL_00bf:
					if (num6 < 265)
					{
						num = 1082753184;
						num7 = 1082753184;
					}
					else
					{
						num = 1879683290;
						num7 = 1879683290;
					}
					continue;
				}
				break;
			}
		}
	}

	static ICryptoTransform i(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		char[] array = x.s;
		object obj = j.smethod_6();
		IDisposable disposable = default(IDisposable);
		try
		{
			while (true)
			{
				IL_00c1:
				int num = 5;
				int num2 = 627254846;
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)num2 ^ 0x2A478E8Au) % 6u)
					{
					case 5u:
					{
						x.s[380] = (char)((x.s[380] ^ x.s[377]) & 'ý');
						int num5;
						if (bool_0)
						{
							num2 = 1961379666;
							num5 = 1961379666;
						}
						else
						{
							num2 = 2136564347;
							num5 = 2136564347;
						}
						continue;
					}
					case 3u:
						num2 = 701638760;
						continue;
					default:
						num4 = array[238] - 41668;
						goto IL_006a;
					case 1u:
						num4 = 3;
						goto IL_006a;
					case 0u:
					{
						ICryptoTransform cryptoTransform;
						switch (num)
						{
						case 4:
						case 5:
							break;
						default:
							num2 = 1791873903;
							continue;
						case 0:
						case 2:
							cryptoTransform = j.smethod_8((SymmetricAlgorithm)(obj as DESCryptoServiceProvider), byte_1, byte_0);
							goto IL_00e6;
						case 3:
							cryptoTransform = j.smethod_7((SymmetricAlgorithm)(obj as DESCryptoServiceProvider), byte_1, byte_0);
							goto IL_00e6;
						case 1:
							goto end_IL_0098;
							IL_00e6:
							disposable = cryptoTransform;
							goto end_IL_0098;
						}
						goto case 5u;
					}
					case 4u:
						break;
						IL_006a:
						num = num4;
						num2 = 627254846;
						continue;
					}
					goto IL_00c1;
					continue;
					end_IL_0098:
					break;
				}
				break;
			}
		}
		finally
		{
			while (true)
			{
				IL_018d:
				int num6 = 3;
				int num7 = 251486619;
				while (true)
				{
					uint num3;
					int num8;
					switch ((num3 = (uint)num7 ^ 0x2A478E8Au) % 7u)
					{
					case 6u:
						num7 = 1073589792;
						continue;
					default:
						num8 = 2;
						goto IL_00fb;
					case 3u:
						num7 = ((int)num3 * -1706588223) ^ 0x121D3BA0;
						continue;
					case 2u:
						switch (num6)
						{
						default:
							num7 = 757222495;
							continue;
						case 3:
							break;
						case 0:
						case 1:
						case 5:
							j.smethod_4((IDisposable)(obj as DESCryptoServiceProvider));
							goto end_IL_015d;
						case 2:
						case 4:
							goto end_IL_015d;
						}
						goto case 1u;
					case 1u:
					{
						int num9;
						if (obj is DESCryptoServiceProvider)
						{
							num7 = 396944934;
							num9 = 396944934;
						}
						else
						{
							num7 = 962737803;
							num9 = 962737803;
						}
						continue;
					}
					case 0u:
						num8 = 0;
						goto IL_00fb;
					case 5u:
						break;
						IL_00fb:
						num6 = num8;
						num7 = 805949041;
						continue;
					}
					goto IL_018d;
					continue;
					end_IL_015d:
					break;
				}
				break;
			}
		}
		return (ICryptoTransform)disposable;
	}

	static void c(v.u u_0)
	{
		byte[] array = h.d;
		int num6 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 888658034;
			while (true)
			{
				uint num2;
				int num4;
				int num9;
				switch ((num2 = (uint)num ^ 0x711267ABu) % 19u)
				{
				case 18u:
					num3 = array[272];
					num = (int)((num2 * 842382720) ^ 0x187606BE);
					continue;
				case 17u:
					num6 = u_0.p[num5] & 0xFFFF;
					num = 942272803;
					continue;
				default:
					num4 = 11;
					goto IL_0041;
				case 15u:
					goto IL_004c;
				case 13u:
					while (true)
					{
						switch (num3)
						{
						case 11:
							break;
						case 4:
							goto IL_004c;
						case 10:
							num7++;
							num3 = 7;
							goto case 7;
						case 7:
							num3 = ((num7 < 32768) ? (array[291] - 37) : (array[294] - 77));
							continue;
						case 5:
							num7 = 0;
							num3 = 7;
							goto case 7;
						case 2:
						{
							int num8 = u_0.x[num7] & 0xFFFF;
							u_0.x[num7] = (short)((num8 >= 32768) ? (num8 - 32768) : 0);
							goto case 10;
						}
						default:
							goto IL_00f1;
						case 0:
							goto IL_00fb;
						case 1:
							goto IL_0121;
						case 3:
							goto IL_0145;
						case 8:
							goto IL_0153;
						case 9:
							goto IL_016f;
						case 6:
							return;
						}
						break;
					}
					goto case 17u;
				case 7u:
					goto IL_00fb;
				case 4u:
					goto IL_0121;
				case 2u:
					goto IL_0145;
				case 1u:
					goto IL_0153;
				case 8u:
					goto IL_016f;
				case 12u:
					u_0.p[num5] = (short)((num6 >= 32768) ? (num6 - 32768) : 0);
					num = 1117992861;
					continue;
				case 11u:
					num3 = 0;
					num = ((int)num2 * -864279983) ^ 0x399EB097;
					continue;
				case 10u:
					num3 = array[167] - array[152];
					num = ((int)num2 * -814353586) ^ -1037236049;
					continue;
				case 9u:
					num3 = array[233];
					num = ((int)num2 * -368590608) ^ 0x1B1F861F;
					continue;
				case 6u:
					num4 = 5;
					goto IL_0041;
				case 5u:
					u_0.h -= 32768;
					num3 = 9;
					num = ((int)num2 * -763313721) ^ -372601744;
					continue;
				case 3u:
					num = (int)(num2 * 1415256387) ^ -190902976;
					continue;
				case 0u:
					num = ((int)num2 * -2144202303) ^ -836993782;
					continue;
				case 14u:
					break;
					IL_0041:
					num3 = num4;
					num = 1138111806;
					continue;
					IL_004c:
					num5 = 0;
					num = 261694126;
					continue;
					IL_016f:
					u_0.f -= 32768;
					num = 1560067591;
					continue;
					IL_0153:
					u_0.y -= 32768;
					num = 1152371987;
					continue;
					IL_0145:
					num5++;
					num = 1625040634;
					continue;
					IL_0121:
					if (num5 >= 32768)
					{
						num = 809917936;
						num9 = 809917936;
					}
					else
					{
						num = 384191327;
						num9 = 384191327;
					}
					continue;
					IL_00fb:
					j.smethod_5((Array)u_0.h, 32768, (Array)u_0.h, 0, 32768);
					num = 325942249;
					continue;
					IL_00f1:
					num = 1741456229;
					continue;
				}
				break;
			}
		}
	}

	static int n(v.u u_0)
	{
		int num = 5;
		int num4 = default(int);
		short num5 = default(short);
		while (true)
		{
			int num2 = 2035317526;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x12E843D7u) % 12u)
				{
				case 10u:
					num4 = ((u_0.v << 5) ^ u_0.h[u_0.f + 2]) & 0x7FFF;
					num2 = 1646905290;
					continue;
				case 9u:
					switch (num)
					{
					case 5:
						break;
					default:
						goto IL_0052;
					case 0:
						goto IL_005c;
					case 1:
						goto IL_0065;
					case 2:
						goto IL_006e;
					case 4:
						goto IL_0092;
					case 6:
						goto IL_009b;
					case 3:
						goto IL_012c;
					}
					goto case 10u;
				case 1u:
					goto IL_005c;
				case 3u:
					goto IL_0065;
				case 6u:
					goto IL_006e;
				case 0u:
					goto IL_0092;
				case 7u:
					goto IL_009b;
				case 8u:
					num2 = ((int)num3 * -507206233) ^ -1676997362;
					continue;
				case 5u:
					num2 = ((int)num3 * -210991926) ^ 0x4A0C514;
					continue;
				case 2u:
					u_0.v = num4;
					num2 = (int)(num3 * 796046186) ^ -45324068;
					continue;
				case 4u:
					break;
				default:
					goto IL_012c;
					IL_012c:
					return num5 & 0xFFFF;
					IL_009b:
					u_0.p[num4] = (short)u_0.f;
					num2 = 584600649;
					continue;
					IL_0092:
					num = 6;
					num2 = 2035317526;
					continue;
					IL_006e:
					num5 = (u_0.x[u_0.f & 0x7FFF] = u_0.p[num4]);
					num2 = 35296895;
					continue;
					IL_0065:
					num = 3;
					num2 = 1065619455;
					continue;
					IL_005c:
					num = 2;
					num2 = 1793020346;
					continue;
					IL_0052:
					num2 = 167338669;
					continue;
				}
				break;
			}
		}
	}

	static void a(int int_0, int int_1, byte[] byte_0, v.x x_0)
	{
		char[] array = x.s;
		byte[] array2 = default(byte[]);
		int num4 = default(int);
		while (true)
		{
			int num = 697266400;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x5024D7C1u) % 6u)
				{
				default:
					num3 = 5;
					goto IL_000c;
				case 3u:
					array2 = h.d;
					num4 = 3;
					num = (int)((num2 * 1370952517) ^ 0x1DC53125);
					continue;
				case 2u:
				{
					int num5;
					if (x_0.c <= 0)
					{
						num = 2113748831;
						num5 = 2113748831;
					}
					else
					{
						num = 1899609345;
						num5 = 1899609345;
					}
					continue;
				}
				case 1u:
					while (true)
					{
						switch (num4)
						{
						case 1:
						case 3:
							break;
						case 6:
							int_0 += int_1 - 32768;
							int_1 = 32768;
							num4 = array2[233];
							continue;
						case 5:
							if (int_1 > 32768)
							{
								num4 = array[150] - 31026;
								continue;
							}
							num4 = 4;
							goto case 4;
						default:
							goto IL_00af;
						case 2:
							throw j.smethod_9();
						case 4:
							j.smethod_5((Array)byte_0, int_0, (Array)x_0.m, 0, int_1);
							goto case 0;
						case 0:
						case 7:
							x_0.d = int_1 & 0x7FFF;
							return;
						}
						break;
					}
					goto case 2u;
				case 0u:
					num3 = 2;
					goto IL_000c;
				case 5u:
					break;
					IL_00af:
					num = 1133109599;
					continue;
					IL_000c:
					num4 = num3;
					num = 1871138752;
					continue;
				}
				break;
			}
		}
	}

	static SymmetricAlgorithm x(string string_0)
	{
		Rijndael rijndael = j.smethod_10();
		DeriveBytes deriveBytes = j.smethod_11(string_0, m.t, 32768);
		j.u(rijndael, (Rfc2898DeriveBytes)deriveBytes);
		x.s[619] = (char)((x.s[619] | h.d[92]) & '!');
		return rijndael;
	}

	static int i(v.x x_0)
	{
		return 32768 - x_0.c;
	}

	static void r(int int_0, byte[] byte_0, int int_1, v.w w_0)
	{
		j.smethod_5((Array)byte_0, int_0, (Array)w_0.h, w_0.v, int_1);
		w_0.v += int_1;
	}

	static byte[] g()
	{
		byte[] array = new byte[71184];
		j.smethod_12((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		return array;
	}

	static byte[] d(int int_0, byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		//IL_0dfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e01: Expected I4, but got Unknown
		//IL_0e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e14: Expected I4, but got Unknown
		//IL_0e4f: Incompatible stack heights: 0 vs 1
		//IL_0e56: Incompatible stack heights: 0 vs 1
		byte[] array = h.d;
		char[] array2 = x.s;
		Array array7 = default(Array);
		try
		{
			MemoryStream memoryStream = default(MemoryStream);
			Array array5 = default(Array);
			int num21 = default(int);
			object obj6 = default(object);
			Array array3 = default(Array);
			int num12 = default(int);
			Array bytes = default(Array);
			Array array6 = default(Array);
			int num22 = default(int);
			object obj8 = default(object);
			long num5 = default(long);
			int num31 = default(int);
			object obj4 = default(object);
			long position3 = default(long);
			long position2 = default(long);
			long num24 = default(long);
			Array array8 = default(Array);
			uint num26 = default(uint);
			uint num25 = default(uint);
			int num28 = default(int);
			int num29 = default(int);
			long position = default(long);
			object obj7 = default(object);
			int num27 = default(int);
			object obj5 = default(object);
			Array array4 = default(Array);
			object obj = default(object);
			object obj3 = default(object);
			while (true)
			{
				IL_08b0:
				int num = 20;
				int num2 = 488917464;
				while (true)
				{
					int num4;
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x5C3B4EACu) % 8u)
					{
					default:
						num4 = array[71] - 60;
						goto IL_0019;
					case 6u:
						num2 = (int)(num3 * 1254654104) ^ -526039608;
						continue;
					case 0u:
					case 5u:
					{
						memoryStream = new v.a();
						int num32;
						if (int_0 != 0)
						{
							num2 = 2102613171;
							num32 = 2102613171;
						}
						else
						{
							num2 = 1745655015;
							num32 = 1745655015;
						}
						continue;
					}
					case 4u:
						while (true)
						{
							switch (num)
							{
							case 20:
							case 44:
								break;
							case 55:
								array5 = new byte[512];
								num21 = j.r((byte[])array5, (v.n)obj6);
								if (num21 > 0)
								{
									num = 42;
									goto case 42;
								}
								num = 7;
								goto case 7;
							case 42:
								((v.a)memoryStream).Write(array5 as byte[], 0, num21);
								goto case 25;
							case 25:
								if (!(obj6 as v.n).x)
								{
									num = 55;
									goto case 55;
								}
								num = 7;
								goto case 7;
							case 7:
								((v.n)obj6).o |= 12;
								num = 15;
								goto case 15;
							case 15:
								if ((obj6 as v.n).i)
								{
									num = array2[464] - 17419;
									continue;
								}
								num = 31;
								goto case 31;
							case 31:
								array3 = new byte[512];
								num12 = j.r(array3 as byte[], (v.n)obj6);
								num = ((num12 <= 0) ? (array[182] - 32) : (array2[268] - 58317));
								continue;
							case 54:
								j.t((v.a)memoryStream, byte_2.Length);
								bytes = Encoding.UTF8.GetBytes(c.k(1229547741, null, 3));
								num = array[160];
								continue;
							case 53:
								array6 = new byte[512];
								num22 = j.r((byte[])array6, (v.n)obj8);
								if (num22 > 0)
								{
									num = 40;
									goto case 40;
								}
								num = array[57] - 46;
								continue;
							case 40:
								(memoryStream as v.a).Write(array6 as byte[], 0, num22);
								goto case 4;
							case 4:
								if (!((v.n)obj8).i)
								{
									num = 53;
									goto case 53;
								}
								num = 9;
								goto case 9;
							case 9:
							case 14:
								num5 = (obj8 as v.n).x;
								j.t((v.a)memoryStream, 33639248);
								j.i(20, memoryStream as v.a);
								num = array2[28] - 54005;
								continue;
							case 52:
								j.t(memoryStream as v.a, 25000571);
								j.t((v.a)memoryStream, byte_2.Length);
								num = 37;
								goto case 37;
							case 37:
								num31 = 0;
								num = 0;
								goto case 0;
							case 0:
								if (num31 >= byte_2.Length)
								{
									num = array2[181] - 417;
									continue;
								}
								num = 51;
								goto case 51;
							case 51:
								obj4 = new byte[Math.Min(2097151, byte_2.Length - num31)];
								Buffer.BlockCopy(byte_2, num31, obj4 as byte[], 0, (obj4 as byte[]).Length);
								num = array[158] - 23;
								continue;
							case 50:
								position3 = (memoryStream as v.a).Position;
								(memoryStream as v.a).Position = position2;
								j.t(memoryStream as v.a, (int)((v.n)obj6).x);
								num = 43;
								goto case 43;
							case 43:
								((v.a)memoryStream).Position = position3;
								num31 += ((byte[])obj4).Length;
								num = 0;
								goto case 0;
							case 49:
								j.i(0, (v.a)memoryStream);
								j.t((v.a)memoryStream, 0);
								j.t(memoryStream as v.a, 0);
								num = array[160] - 10;
								continue;
							case 48:
							{
								obj8 = new v.n();
								DateTime now = DateTime.Now;
								int num30 = ((now.Year - 1980) & 0x7F) << 25;
								int month = now.Month;
								h.d[93] = (byte)((h.d[93] * x.s[151]) & 0x7D);
								num24 = (uint)(num30 | (month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
								num = 29;
								goto case 29;
							}
							case 29:
								array8 = _003CModule_003E.smethod_34<uint[]>(793690115u);
								num26 = uint.MaxValue;
								num25 = uint.MaxValue;
								num = array2[542] - 29432;
								continue;
							case 47:
								j.h(obj8 as v.n, byte_2);
								num = 22;
								goto case 22;
							case 22:
								if ((obj8 as v.n).x)
								{
									num = 26;
									goto case 26;
								}
								num = array[94] * 7;
								continue;
							case 26:
								((v.n)obj8).o |= 12;
								num = 4;
								goto case 4;
							case 45:
								num28 = 0;
								num29 = byte_2.Length;
								num = array2[591] - 38024;
								continue;
							case 39:
								j.t(memoryStream as v.a, (int)num25);
								position = (memoryStream as v.a).Position;
								j.t(memoryStream as v.a, 0);
								num = array[40] - 103;
								continue;
							case 38:
								j.i(((byte[])bytes).Length, (v.a)memoryStream);
								goto case 30;
							case 30:
								j.i(0, memoryStream as v.a);
								num = 16;
								goto case 16;
							case 16:
								(memoryStream as v.a).Write((byte[])bytes, 0, (bytes as byte[]).Length);
								num = 47;
								goto case 47;
							case 34:
								num25 = ((uint[])array8)[(num25 ^ byte_2[num28++]) & 0xFF] ^ (num25 >> 8);
								num = 36;
								goto case 36;
							case 36:
								if (--num29 >= 0)
								{
									num = 34;
									goto case 34;
								}
								num = array[161];
								continue;
							case 35:
								obj7 = new byte[512];
								num27 = j.r(obj7 as byte[], (v.n)obj8);
								if (num27 > 0)
								{
									num = 2;
									goto case 1;
								}
								num = array[120] - 61;
								continue;
							case 1:
							case 2:
								(memoryStream as v.a).Write((byte[])obj7, 0, num27);
								goto case 22;
							case 33:
								j.t(memoryStream as v.a, byte_2.Length);
								j.i((bytes as byte[]).Length, (v.a)memoryStream);
								num = array2[253] - 43557;
								continue;
							case 32:
								obj6 = new v.n();
								j.h(obj6 as v.n, obj4 as byte[]);
								num = 25;
								goto case 25;
							case 28:
								(memoryStream as v.a).Write((byte[])bytes, 0, (bytes as byte[]).Length);
								num = 27;
								goto case 27;
							case 27:
								j.t(memoryStream as v.a, 101010256);
								j.i(0, (v.a)memoryStream);
								j.i(0, memoryStream as v.a);
								num = array[153] - 42;
								continue;
							case 24:
								num25 ^= num26;
								j.t((v.a)memoryStream, 67324752);
								j.i(20, (v.a)memoryStream);
								num = 10;
								goto case 10;
							case 10:
								j.i(0, memoryStream as v.a);
								j.i(8, (v.a)memoryStream);
								j.t(memoryStream as v.a, (int)num24);
								num = array2[30] - 58116;
								continue;
							case 23:
								goto IL_065c;
							case 19:
								j.i(0, memoryStream as v.a);
								j.i(0, (v.a)memoryStream);
								j.i(0, memoryStream as v.a);
								num = 49;
								goto case 49;
							case 17:
								j.t(memoryStream as v.a, (int)num24);
								j.t((v.a)memoryStream, (int)num25);
								j.t((v.a)memoryStream, (int)num5);
								num = array2[331] - 44812;
								continue;
							case 11:
								if (int_0 == 2)
								{
									num = array2[24] - 37372;
									continue;
								}
								while (true)
								{
									int num13 = 4;
									int num14 = 898490718;
									while (true)
									{
										switch ((num3 = (uint)num14 ^ 0x5C3B4EACu) % 12u)
										{
										case 11u:
											num13 = 3;
											num14 = (int)(num3 * 1489561662) ^ -2000102754;
											continue;
										case 4u:
										case 10u:
											break;
										case 8u:
											num14 = ((int)num3 * -139967193) ^ -1008283506;
											continue;
										case 7u:
											goto IL_0914;
										case 5u:
											num14 = ((int)num3 * -1072779900) ^ 0x7E02221A;
											continue;
										case 3u:
											goto IL_092d;
										case 2u:
											switch (num13)
											{
											case 1:
											case 4:
												break;
											case 6:
												goto IL_0914;
											case 3:
											case 5:
												goto IL_092d;
											default:
												goto IL_0967;
											case 0:
												goto IL_096e;
											case 2:
												goto IL_09d1;
											}
											break;
										case 1u:
											goto IL_096e;
										case 0u:
											num14 = 1032536137;
											continue;
										case 9u:
											goto end_IL_0985;
										default:
											goto IL_09d1;
											IL_096e:
											obj5 = j.d(1, (byte[])null, (byte[])null, byte_2);
											num14 = 1160156779;
											continue;
											IL_0967:
											num14 = 850448942;
											continue;
											IL_092d:
											j.t((v.a)memoryStream, 58555003);
											num14 = 459316217;
											continue;
											IL_0914:
											num13 = 2;
											num14 = 214394333;
											continue;
										}
										if (int_0 != 3)
										{
											goto end_IL_09c7;
										}
										num14 = 971828147;
										continue;
										IL_09d1:
										IDisposable disposable = j.j(bool_0: false, byte_1, byte_0);
										try
										{
											while (true)
											{
												IL_0a98:
												int num15 = 1;
												int num16 = 439279667;
												while (true)
												{
													switch ((num3 = (uint)num16 ^ 0x5C3B4EACu) % 8u)
													{
													case 7u:
														switch (num15)
														{
														case 3:
															goto IL_0a07;
														case 1:
														case 4:
														case 5:
															goto IL_0a2a;
														case 0:
														case 2:
															goto end_IL_0a67;
														}
														num16 = 1870897121;
														continue;
													case 4u:
														goto IL_0a07;
													case 2u:
													case 5u:
														goto IL_0a2a;
													case 1u:
														num15 = 3;
														num16 = ((int)num3 * -1906184453) ^ -107377552;
														continue;
													case 0u:
														num16 = 1057421943;
														continue;
													default:
														goto end_IL_0a67;
													case 3u:
														break;
													case 6u:
														goto end_IL_0a67;
														IL_0a2a:
														array4 = (disposable as ICryptoTransform).TransformFinalBlock(obj5 as byte[], 0, ((byte[])obj5).Length);
														num16 = 1231887349;
														continue;
														IL_0a07:
														((v.a)memoryStream).Write((byte[])array4, 0, (array4 as byte[]).Length);
														num16 = 416184162;
														continue;
													}
													goto IL_0a98;
													continue;
													end_IL_0a67:
													break;
												}
												break;
											}
										}
										finally
										{
											while (true)
											{
												IL_0b56:
												int num17 = 6;
												int num18 = 433493129;
												while (true)
												{
													int num19;
													switch ((num3 = (uint)num18 ^ 0x5C3B4EACu) % 8u)
													{
													case 0u:
													case 7u:
													{
														int num20;
														if (disposable is ICryptoTransform)
														{
															num18 = 1825485114;
															num20 = 1825485114;
														}
														else
														{
															num18 = 30158102;
															num20 = 30158102;
														}
														continue;
													}
													case 6u:
														num19 = array2[1] - 31762;
														goto IL_0ad8;
													case 5u:
														switch (num17)
														{
														case 0:
														case 1:
														case 2:
														case 6:
															break;
														default:
															num18 = 1564686412;
															continue;
														case 4:
															((ICryptoTransform)disposable).Dispose();
															goto end_IL_0b25;
														case 3:
														case 5:
															goto end_IL_0b25;
														}
														goto case 0u;
													case 3u:
														num18 = 932885160;
														continue;
													default:
														num19 = array[94];
														goto IL_0ad8;
													case 1u:
														num18 = (int)(num3 * 2005308424) ^ -771854591;
														continue;
													case 4u:
														break;
														IL_0ad8:
														num17 = num19;
														num18 = 228047453;
														continue;
													}
													goto IL_0b56;
													continue;
													end_IL_0b25:
													break;
												}
												break;
											}
										}
										goto end_IL_09c7;
										continue;
										end_IL_0985:
										break;
									}
									continue;
									end_IL_09c7:
									break;
								}
								goto case 18;
							case 8:
								position2 = ((v.a)memoryStream).Position;
								j.t((v.a)memoryStream, 0);
								j.t((v.a)memoryStream, ((byte[])obj4).Length);
								num = 32;
								goto case 32;
							case 5:
								(memoryStream as v.a).Write((byte[])array3, 0, num12);
								goto case 15;
							case 3:
								j.i(20, memoryStream as v.a);
								j.i(0, (v.a)memoryStream);
								j.i(8, memoryStream as v.a);
								num = array[151];
								continue;
							default:
								goto IL_0869;
							case 6:
								j.t((v.a)memoryStream, 41777787);
								obj = j.d(1, (byte[])null, (byte[])null, byte_2);
								num = 12;
								goto case 12;
							case 12:
							{
								object obj2 = j.i(byte_0, byte_1, bool_0: false);
								try
								{
									while (true)
									{
										IL_0c43:
										int num6 = 0;
										int num7 = 2076408242;
										while (true)
										{
											switch ((num3 = (uint)num7 ^ 0x5C3B4EACu) % 9u)
											{
											case 7u:
												num6 = 3;
												num7 = 559279174;
												continue;
											case 6u:
												goto IL_0b8a;
											case 4u:
												num7 = (int)((num3 * 2111045099) ^ 0x7FADB77C);
												continue;
											case 3u:
												num7 = 911848258;
												continue;
											case 1u:
											case 2u:
												goto IL_0bc3;
											case 0u:
												switch (num6)
												{
												case 4:
													break;
												case 1:
												case 3:
													goto IL_0b8a;
												case 0:
												case 2:
												case 5:
													goto IL_0bc3;
												default:
													goto IL_0c08;
												}
												goto case 7u;
											default:
												goto end_IL_0c0d;
											case 8u:
												break;
											case 5u:
												goto end_IL_0c0d;
												IL_0c08:
												num7 = 719564335;
												continue;
												IL_0bc3:
												obj3 = ((ICryptoTransform)obj2).TransformFinalBlock((byte[])obj, 0, (obj as byte[]).Length);
												num7 = 2145534898;
												continue;
												IL_0b8a:
												(memoryStream as v.a).Write((byte[])obj3, 0, (obj3 as byte[]).Length);
												num7 = 1738853891;
												continue;
											}
											goto IL_0c43;
											continue;
											end_IL_0c0d:
											break;
										}
										break;
									}
								}
								finally
								{
									while (true)
									{
										IL_0cfb:
										int num8 = 2;
										int num9 = 1795747436;
										while (true)
										{
											int num10;
											switch ((num3 = (uint)num9 ^ 0x5C3B4EACu) % 8u)
											{
											case 7u:
												num9 = ((int)num3 * -1674945501) ^ -433510911;
												continue;
											case 6u:
												num9 = 710743647;
												continue;
											case 1u:
											case 5u:
											{
												int num11;
												if (obj2 is ICryptoTransform)
												{
													num9 = 814453120;
													num11 = 814453120;
												}
												else
												{
													num9 = 363350286;
													num11 = 363350286;
												}
												continue;
											}
											case 4u:
												num10 = array[91] * 7;
												goto IL_0c96;
											default:
												num10 = 5;
												goto IL_0c96;
											case 0u:
												switch (num8)
												{
												case 1:
												case 2:
												case 3:
												case 6:
													break;
												default:
													num9 = 1878763585;
													continue;
												case 0:
													(obj2 as ICryptoTransform).Dispose();
													goto end_IL_0cca;
												case 4:
												case 5:
													goto end_IL_0cca;
												}
												goto case 1u;
											case 3u:
												break;
												IL_0c96:
												num8 = num10;
												num9 = 883672195;
												continue;
											}
											goto IL_0cfb;
											continue;
											end_IL_0cca:
											break;
										}
										break;
									}
								}
								goto case 18;
							}
							case 21:
								j.i(1, memoryStream as v.a);
								j.i(1, memoryStream as v.a);
								j.t((v.a)memoryStream, 46 + ((byte[])bytes).Length);
								num = 13;
								goto case 13;
							case 13:
								j.t((v.a)memoryStream, (int)(30 + ((byte[])bytes).Length + num5));
								num = 46;
								goto case 46;
							case 46:
								j.i(0, (v.a)memoryStream);
								(memoryStream as v.a).Seek(position, SeekOrigin.Begin);
								num = 41;
								goto case 41;
							case 41:
								j.t(memoryStream as v.a, (int)num5);
								goto case 18;
							case 18:
								while (true)
								{
									IL_0de1:
									((v.a)memoryStream).Flush();
									int num23 = 2001010701;
									while (true)
									{
										switch ((num3 = (uint)num23 ^ 0x5C3B4EACu) % 6u)
										{
										case 3u:
											(memoryStream as v.a).Close();
											array7 = (memoryStream as v.a).ToArray();
											num23 = 945985416;
											continue;
										case 0u:
											num23 = 651391623;
											continue;
										default:
											goto end_IL_0db8;
										case 1u:
										case 2u:
										case 5u:
											break;
										case 4u:
											goto end_IL_0db8;
										}
										goto IL_0de1;
										continue;
										end_IL_0db8:
										break;
									}
									break;
								}
								goto end_IL_087c;
							}
							break;
							IL_065c:
							num = ((int_0 != 1) ? (array2[464] - 17458) : (array[51] - 135));
						}
						goto case 0u;
					case 3u:
						num4 = 48;
						goto IL_0019;
					case 2u:
						num2 = 363982877;
						continue;
					case 1u:
						break;
						IL_0869:
						num2 = 1238315724;
						continue;
						IL_0019:
						num = num4;
						num2 = 1023390234;
						continue;
					}
					goto IL_08b0;
					continue;
					end_IL_087c:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			while (true)
			{
				_ = 1542236308;
				while (true)
				{
					_003F val = /*Error near IL_0dff: Stack underflow*/^ 0x5C3B4EAC;
					uint num3 = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						v.a = v.a.u(7, int_0, typeof(t), 1468094607) + ex.Message;
						_ = (num3 * 1195589249) ^ 0x5C50A024;
						continue;
					case 0:
						break;
					default:
						throw;
					}
					break;
				}
			}
		}
		return (byte[])array7;
	}

	static byte[] o(byte[] byte_0)
	{
		byte[] array = h.d;
		Array array7 = default(Array);
		int num23 = default(int);
		object obj = default(object);
		int num20 = default(int);
		int num14 = default(int);
		int num15 = default(int);
		char[] array2 = default(char[]);
		Array array4 = default(Array);
		Array array3 = default(Array);
		int num26 = default(int);
		int num21 = default(int);
		short num24 = default(short);
		int num25 = default(int);
		int num22 = default(int);
		int num18 = default(int);
		IEvidenceFactory val2 = default(IEvidenceFactory);
		IEvidenceFactory val = default(IEvidenceFactory);
		int num13 = default(int);
		Array array5 = default(Array);
		object obj4 = default(object);
		object obj3 = default(object);
		int num17 = default(int);
		object obj2 = default(object);
		Array array11 = default(Array);
		object obj7 = default(object);
		IDisposable disposable2 = default(IDisposable);
		Array array13 = default(Array);
		int num6 = default(int);
		while (true)
		{
			int num = 14869332;
			while (true)
			{
				int num5;
				uint num2;
				switch ((num2 = (uint)num ^ 0x3471508Fu) % 8u)
				{
				default:
					num5 = 6;
					goto IL_000c;
				case 6u:
					num5 = array[233];
					goto IL_000c;
				case 5u:
					num6 = 13;
					num = ((int)num2 * -266025588) ^ -597267625;
					continue;
				case 4u:
					while (true)
					{
						int num16;
						switch (num6)
						{
						case 35:
						{
							object obj6 = new v.h((byte[])array7);
							j.p(num23, obj as byte[], num20, (v.h)obj6);
							num6 = array[76] - 107;
							continue;
						}
						case 34:
							break;
						case 32:
							if (num14 > 0)
							{
								num6 = array[161];
								continue;
							}
							num6 = 16;
							goto case 16;
						case 16:
							if (num15 > 0)
							{
								num6 = 9;
								goto case 9;
							}
							num6 = array2[231] - 50780;
							continue;
						case 9:
						{
							Array array6 = new byte[num15];
							j.smethod_17((Stream)(v.a)obj2, array6 as byte[], 0, num15);
							num6 = array[249] - 237;
							continue;
						}
						case 30:
							goto IL_0122;
						case 28:
							goto IL_012c;
						case 29:
							j.d(obj2 as v.a);
							j.d((v.a)obj2);
							j.d(obj2 as v.a);
							num6 = array2[46] - 53718;
							continue;
						case 27:
							j.smethod_17((Stream)(obj2 as v.a), array7 as byte[], 0, (array7 as byte[]).Length);
							num6 = 35;
							goto case 35;
						case 26:
						{
							byte[] array8 = new byte[8];
							j.smethod_12((Array)array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
							array4 = array8;
							byte[] array9 = new byte[8];
							j.smethod_12((Array)array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
							array3 = array9;
							num6 = array[206];
							continue;
						}
						case 23:
						case 24:
						{
							object obj5 = new byte[num14];
							j.smethod_17((Stream)(v.a)obj2, (byte[])obj5, 0, num14);
							num6 = array2[606] - 49888;
							continue;
						}
						case 20:
						{
							int num19 = j.d((v.a)obj2);
							num20 = j.d((v.a)obj2);
							array7 = new byte[num19];
							num6 = 27;
							goto case 27;
						}
						case 19:
							num26 = j.d(obj2 as v.a);
							obj = new byte[num26];
							num23 = 0;
							num6 = 1;
							goto case 1;
						case 1:
							if (num23 >= num26)
							{
								num6 = 17;
								goto case 17;
							}
							num6 = array[16] - 8;
							continue;
						case 17:
							if (num21 == 2)
							{
								num6 = array2[318] - 3874;
								continue;
							}
							goto IL_07d7;
						case 15:
							num24 = (short)j.m(obj2 as v.a);
							num25 = j.m(obj2 as v.a);
							num22 = j.m(obj2 as v.a);
							num6 = 8;
							goto case 8;
						case 8:
							if (num18 == 67324752)
							{
								num6 = array2[28] - 53978;
								continue;
							}
							num6 = 25;
							goto case 11;
						case 14:
							if (num18 == 8223355)
							{
								num6 = array[119] - array[245];
								continue;
							}
							goto IL_09cd;
						case 12:
							num23 += num20;
							num6 = 1;
							goto case 1;
						case 7:
							if (num22 == 8)
							{
								num6 = 29;
								goto case 29;
							}
							num6 = 25;
							goto case 11;
						case 6:
							obj2 = new v.a(byte_0);
							obj = new byte[0];
							num18 = j.d((v.a)obj2);
							num6 = 3;
							goto case 3;
						case 3:
							if (num18 == 67324752)
							{
								num6 = array[14] - 151;
								continue;
							}
							num6 = 5;
							goto case 5;
						case 5:
							num21 = num18 >> 24;
							num18 -= num21 << 24;
							num6 = 14;
							goto case 14;
						case 4:
							if (j.y(val2 as Assembly, (Assembly)(object)val))
							{
								num6 = 6;
								goto case 6;
							}
							num6 = 2;
							goto case 2;
						case 0:
							num13 = j.d(obj2 as v.a);
							num14 = j.m((v.a)obj2);
							num15 = j.m((v.a)obj2);
							num6 = array[28];
							continue;
						default:
							goto end_IL_03d2;
						case 13:
							goto IL_0470;
						case 2:
							return null;
						case 10:
							obj3 = new byte[j.smethod_18((Stream)(obj2 as v.a)) - j.smethod_19((Stream)(obj2 as v.a))];
							num6 = 33;
							goto case 33;
						case 18:
						{
							IDisposable disposable = j.i(array3 as byte[], array4 as byte[], bool_0: true);
							try
							{
								while (true)
								{
									IL_05ff:
									int num7 = 1;
									int num8 = 189982888;
									while (true)
									{
										switch ((num2 = (uint)num8 ^ 0x3471508Fu) % 8u)
										{
										case 7u:
											switch (num7)
											{
											case 0:
											case 2:
											case 3:
												goto IL_0585;
											case 4:
												goto IL_059a;
											case 1:
											case 5:
												goto IL_05ad;
											}
											num8 = 640048470;
											continue;
										case 4u:
											goto IL_0585;
										case 6u:
											goto IL_059a;
										case 0u:
										case 1u:
											goto IL_05ad;
										case 5u:
											num8 = 1054571012;
											continue;
										default:
											goto end_IL_05ce;
										case 3u:
											break;
										case 2u:
											goto end_IL_05ce;
											IL_05ad:
											array5 = j.smethod_20((ICryptoTransform)disposable, byte_0, 4, byte_0.Length - 4);
											num8 = 1476848801;
											continue;
											IL_059a:
											num7 = array2[116] - 59894;
											num8 = 189982888;
											continue;
											IL_0585:
											obj = j.o(array5 as byte[]);
											num8 = 1420797013;
											continue;
										}
										goto IL_05ff;
										continue;
										end_IL_05ce:
										break;
									}
									break;
								}
							}
							finally
							{
								while (true)
								{
									IL_06b8:
									int num9 = 0;
									int num10 = 1392521448;
									while (true)
									{
										int num11;
										switch ((num2 = (uint)num10 ^ 0x3471508Fu) % 8u)
										{
										case 7u:
											switch (num9)
											{
											default:
												num10 = 1454638558;
												continue;
											case 0:
											case 2:
											case 3:
												break;
											case 1:
											case 5:
												j.smethod_4((IDisposable)(ICryptoTransform)disposable);
												goto end_IL_0687;
											case 4:
											case 6:
												goto end_IL_0687;
											}
											goto case 1u;
										case 1u:
										case 6u:
										{
											int num12;
											if (!(disposable is ICryptoTransform))
											{
												num10 = 501244483;
												num12 = 501244483;
											}
											else
											{
												num10 = 727445869;
												num12 = 727445869;
											}
											continue;
										}
										case 5u:
											num10 = (int)((num2 * 464867270) ^ 0x79489346);
											continue;
										default:
											num11 = 4;
											goto IL_0670;
										case 2u:
											num11 = array[272];
											goto IL_0670;
										case 0u:
											num10 = 1083264732;
											continue;
										case 3u:
											break;
											IL_0670:
											num9 = num11;
											num10 = 1827444978;
											continue;
										}
										goto IL_06b8;
										continue;
										end_IL_0687:
										break;
									}
									break;
								}
							}
							goto IL_07d7;
						}
						case 11:
						case 25:
							throw j.smethod_16(v.a.u(4, 7, j.smethod_15(typeof(w).TypeHandle), 1468094651));
						case 33:
							j.smethod_17((Stream)(obj2 as v.a), obj3 as byte[], 0, ((byte[])obj3).Length);
							num6 = 21;
							goto case 21;
						case 21:
							obj4 = new v.h(obj3 as byte[]);
							obj = new byte[num13];
							goto case 31;
						case 31:
							j.p(0, (byte[])obj, (obj as byte[]).Length, (v.h)obj4);
							num6 = 22;
							goto case 22;
						case 22:
							{
								obj3 = null;
								goto IL_0a42;
							}
							IL_0a11:
							while (true)
							{
								switch ((num2 = (uint)num16 ^ 0x3471508Fu) % 8u)
								{
								case 7u:
									break;
								case 4u:
									num16 = 310223072;
									continue;
								case 0u:
								case 3u:
									num16 = 389575786;
									continue;
								case 1u:
									switch (num17)
									{
									case 0:
									case 3:
									case 4:
										break;
									default:
										goto IL_0a04;
									case 5:
										goto IL_0a42;
									case 1:
									case 2:
										goto IL_0a55;
									}
									goto case 0u;
								case 2u:
									goto IL_0a42;
								case 5u:
									goto IL_0a55;
								default:
									{
										obj2 = null;
										return obj as byte[];
									}
									IL_0a55:
									throw j.smethod_16(v.a.u(4, 13, j.smethod_15(typeof(v).TypeHandle), 1468094546));
									IL_0a04:
									num16 = ((int)num2 * -303439724) ^ 0x72F5397B;
									continue;
								}
								break;
							}
							goto IL_09cd;
							IL_09cd:
							num17 = 3;
							num16 = 1279461350;
							goto IL_0a11;
							IL_07d7:
							while (true)
							{
								int num27 = 0;
								int num28 = 1611608209;
								while (true)
								{
									byte[] array10;
									byte[] array12;
									switch ((num2 = (uint)num28 ^ 0x3471508Fu) % 11u)
									{
									case 10u:
										num28 = 1034701691;
										continue;
									case 1u:
									case 9u:
										break;
									case 8u:
										goto IL_06eb;
									case 7u:
										goto IL_0704;
									case 6u:
										goto IL_0721;
									case 4u:
										num28 = (int)((num2 * 103990832) ^ 0x4E5E49C1);
										continue;
									case 3u:
										num27 = 1;
										num28 = ((int)num2 * -1437489142) ^ -1368747418;
										continue;
									case 2u:
										switch (num27)
										{
										case 0:
										case 4:
											break;
										case 3:
											goto IL_06eb;
										case 2:
										case 6:
											goto IL_0704;
										case 1:
										case 5:
											goto IL_0721;
										default:
											goto IL_0794;
										}
										break;
									case 5u:
										goto end_IL_0799;
									default:
										goto IL_07e1;
										IL_0794:
										num28 = 1572374076;
										continue;
										IL_0721:
										array10 = new byte[16];
										j.smethod_12((Array)array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
										array11 = array10;
										array12 = new byte[16];
										j.smethod_12((Array)array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
										obj7 = array12;
										num28 = 760505570;
										continue;
										IL_0704:
										disposable2 = j.j(bool_0: true, array11 as byte[], (byte[])obj7);
										num28 = 399961345;
										continue;
										IL_06eb:
										num27 = array[152] - 242;
										num28 = 1611608209;
										continue;
									}
									if (num21 != 3)
									{
										goto end_IL_07d7;
									}
									num28 = 286042676;
									continue;
									IL_07e1:
									try
									{
										while (true)
										{
											IL_0879:
											int num29 = 1;
											int num30 = 2044332080;
											while (true)
											{
												switch ((num2 = (uint)num30 ^ 0x3471508Fu) % 8u)
												{
												case 7u:
													switch (num29)
													{
													case 0:
														goto IL_080e;
													case 1:
													case 3:
													case 5:
														goto IL_0818;
													case 2:
													case 4:
														goto IL_0883;
													}
													num30 = 355284327;
													continue;
												case 3u:
													goto IL_080e;
												case 0u:
												case 6u:
													goto IL_0818;
												case 5u:
													num30 = 1416797699;
													continue;
												case 2u:
													num30 = (int)(num2 * 899726619) ^ -299598858;
													continue;
												case 4u:
													break;
												default:
													goto IL_0883;
													IL_0883:
													obj = j.o(array13 as byte[]);
													goto end_IL_0848;
													IL_0818:
													array13 = j.smethod_20(disposable2 as ICryptoTransform, byte_0, 4, byte_0.Length - 4);
													num30 = 2051135356;
													continue;
													IL_080e:
													num29 = 4;
													num30 = 2115110205;
													continue;
												}
												goto IL_0879;
												continue;
												end_IL_0848:
												break;
											}
											break;
										}
									}
									finally
									{
										while (true)
										{
											IL_093a:
											int num31 = 1;
											int num32 = 558602574;
											while (true)
											{
												int num33;
												switch ((num2 = (uint)num32 ^ 0x3471508Fu) % 8u)
												{
												case 3u:
												case 6u:
												{
													int num34;
													if ((ICryptoTransform)disposable2 == null)
													{
														num32 = 87368933;
														num34 = 87368933;
													}
													else
													{
														num32 = 708005170;
														num34 = 708005170;
													}
													continue;
												}
												case 5u:
													num33 = 3;
													goto IL_08bf;
												case 4u:
													num32 = 1583991312;
													continue;
												default:
													num33 = 2;
													goto IL_08bf;
												case 1u:
													switch (num31)
													{
													case 0:
													case 1:
													case 4:
														break;
													default:
														num32 = 1265346236;
														continue;
													case 3:
														j.smethod_4((IDisposable)(ICryptoTransform)disposable2);
														goto end_IL_0909;
													case 2:
													case 5:
													case 6:
														goto end_IL_0909;
													}
													goto case 3u;
												case 0u:
													num32 = ((int)num2 * -1170585648) ^ 0x3EB26D4E;
													continue;
												case 7u:
													break;
													IL_08bf:
													num31 = num33;
													num32 = 902418639;
													continue;
												}
												goto IL_093a;
												continue;
												end_IL_0909:
												break;
											}
											break;
										}
									}
									goto end_IL_07d7;
									continue;
									end_IL_0799:
									break;
								}
								continue;
								end_IL_07d7:
								break;
							}
							goto IL_0a42;
							IL_0a42:
							j.smethod_21((Stream)(obj2 as v.a));
							num16 = 1413090233;
							goto IL_0a11;
						}
						if (num21 == 1)
						{
							byte num35 = array[182];
							h.d[204] = (byte)((h.d[204] ^ h.d[107]) & 0xE6);
							num6 = num35 - 63;
						}
						else
						{
							num6 = array2[459] - 20958;
						}
						continue;
						IL_0122:
						if (num24 == 20)
						{
							num6 = 28;
							goto IL_012c;
						}
						num6 = array[26];
						continue;
						IL_012c:
						num6 = ((num25 != 0) ? (array2[137] - 45715) : (array2[48] - 65311));
						continue;
						end_IL_03d2:
						break;
					}
					num = 1943739342;
					continue;
				case 1u:
					goto IL_0470;
				case 3u:
					array2 = x.s;
					num = ((int)num2 * -327109678) ^ 0x6FAB396C;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if ((object)(val as Assembly) == (Assembly)(object)val2)
					{
						num3 = -1848258256;
						num4 = -1848258256;
					}
					else
					{
						num3 = -724052559;
						num4 = -724052559;
					}
					num = num3 ^ ((int)num2 * -2005477912);
					continue;
				}
				case 2u:
					break;
					IL_0470:
					val = (IEvidenceFactory)(object)j.smethod_13();
					val2 = (IEvidenceFactory)(object)j.smethod_14();
					num = 200537839;
					continue;
					IL_000c:
					num6 = num5;
					num = 910723563;
					continue;
				}
				break;
			}
		}
	}

	static void h(v.n n_0, byte[] byte_0)
	{
		j.b(n_0.a, byte_0);
	}

	static void p()
	{
		try
		{
			while (true)
			{
				j.f();
				int num = -1333555509;
				while (true)
				{
					switch ((uint)(num ^ -325677340) % 3u)
					{
					case 0u:
						goto IL_0003;
					default:
						return;
					case 2u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0003:
					num = -863965614;
				}
			}
		}
		catch (Exception)
		{
		}
	}

	static void p(v.e e_0, int int_0)
	{
		e_0.k >>= int_0;
		e_0.g -= int_0;
		x.s[66] = (char)((x.s[66] | h.d[14]) & '\u009e');
	}

	static bool l(v.b b_0, v.e e_0)
	{
		byte[] array = h.d;
		char[] array2 = default(char[]);
		int num7 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int int_ = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -844298098;
			while (true)
			{
				uint num2;
				int num4;
				switch ((num2 = (uint)num ^ 0xCF9E1C8Du) % 6u)
				{
				case 4u:
					while (true)
					{
						switch (num3)
						{
						case 39:
							b_0.t = j.d(e_0, 5);
							if (b_0.t >= 0)
							{
								num3 = 10;
								goto case 10;
							}
							num3 = 27;
							goto case 27;
						case 10:
							b_0.t += 257;
							j.p(e_0, 5);
							b_0.e = 1;
							num3 = 30;
							goto case 30;
						case 30:
							b_0.o = j.d(e_0, 5);
							if (b_0.o < 0)
							{
								num3 = array2[47] - 30311;
								continue;
							}
							num3 = 11;
							goto case 11;
						case 11:
							b_0.o++;
							j.p(e_0, 5);
							b_0.l = b_0.t + b_0.o;
							num3 = 29;
							goto case 29;
						case 29:
							b_0.w = new byte[b_0.l];
							b_0.e = 2;
							num3 = array[187] - array[133];
							continue;
						case 38:
							num7 = j.d(e_0, 3);
							if (num7 >= 0)
							{
								num3 = array[36] - 31;
								continue;
							}
							num3 = 34;
							goto case 34;
						case 35:
							b_0.w[b_0.i++] = (b_0.a = (byte)num5);
							num3 = 16;
							goto case 16;
						case 16:
							if (b_0.i != b_0.l)
							{
								num3 = 7;
								goto case 7;
							}
							num3 = array2[172] - 18385;
							continue;
						case 7:
							if (((num5 = j.o(b_0.w, e_0)) & -16) == 0)
							{
								num3 = 35;
								goto case 35;
							}
							num3 = 18;
							goto case 18;
						case 18:
							if (num5 >= 0)
							{
								num3 = array[262] - array[209];
								continue;
							}
							num3 = 25;
							goto case 25;
						case 33:
							num3 = ((num6-- > 0) ? (array2[369] - 65362) : (array[91] * 9));
							continue;
						case 31:
							b_0.w[b_0.i++] = b_0.a;
							num3 = 33;
							goto case 33;
						case 28:
							b_0.i++;
							num3 = array2[259] - 23135;
							continue;
						case 26:
							if (num5 >= 17)
							{
								num3 = 13;
								goto case 13;
							}
							num3 = array2[197] - 47599;
							continue;
						case 13:
							b_0.a = 0;
							num3 = array2[393] - 40526;
							continue;
						case 24:
							j.p(e_0, 3);
							b_0.x[v.b.l[b_0.i]] = (byte)num7;
							num3 = 28;
							goto case 28;
						case 22:
							j.p(e_0, int_);
							num6 += v.b.g[b_0.n];
							num3 = 33;
							goto case 33;
						case 20:
							b_0.f = j.d(e_0, 4);
							if (b_0.f >= 0)
							{
								num3 = 14;
								goto case 14;
							}
							num3 = 15;
							goto case 15;
						case 14:
							b_0.f += 4;
							j.p(e_0, 4);
							b_0.x = new byte[19];
							num3 = 12;
							goto case 12;
						case 12:
							b_0.i = 0;
							b_0.e = 3;
							num3 = 1;
							goto case 1;
						case 1:
							if (b_0.i >= b_0.f)
							{
								num3 = array2[278] - 25476;
								continue;
							}
							num3 = 38;
							goto case 38;
						case 17:
							int_ = v.b.p[b_0.n];
							num6 = j.d(e_0, int_);
							if (num6 >= 0)
							{
								num3 = 22;
								goto case 22;
							}
							num3 = 8;
							goto case 8;
						case 9:
							b_0.e = 4;
							num3 = 7;
							goto case 7;
						case 6:
							b_0.w = new v.t(b_0.x);
							goto case 5;
						case 5:
							b_0.x = null;
							b_0.i = 0;
							num3 = 9;
							goto case 9;
						case 2:
							b_0.n = num5 - 16;
							b_0.e = 5;
							num3 = array[153] - 46;
							continue;
						case 0:
							if (b_0.i != b_0.l)
							{
								num3 = 21;
								goto case 21;
							}
							num3 = 3;
							goto case 3;
						case 21:
							b_0.e = 4;
							num3 = 37;
							goto IL_0429;
						case 36:
							num3 = 37;
							goto IL_0429;
						case 37:
							goto IL_0429;
						case 3:
							h.d[279] = (byte)((h.d[279] * h.d[293]) & 0xD0);
							return true;
						case 8:
							return false;
						case 15:
							return false;
						case 23:
							return true;
						case 4:
						case 19:
						case 32:
							return false;
						case 25:
							return false;
						case 34:
							return false;
						case 27:
							return false;
						}
						break;
					}
					num = -768713235;
					continue;
				case 0u:
					goto IL_0429;
				default:
					goto IL_0455;
				case 2u:
					num4 = array[99] - array[101];
					goto IL_0483;
				case 1u:
					array2 = x.s;
					num3 = 37;
					num = ((int)num2 * -1284434462) ^ -1062088581;
					continue;
				case 5u:
					break;
					IL_0429:
					switch (b_0.e)
					{
					case 0:
						goto IL_0455;
					case 1:
						goto IL_0459;
					case 2:
						goto IL_0466;
					case 3:
						goto IL_046e;
					case 4:
						goto IL_047e;
					case 5:
						goto IL_0481;
					}
					num = -1618914125;
					continue;
					IL_0481:
					num4 = 17;
					goto IL_0483;
					IL_047e:
					num4 = 7;
					goto IL_0483;
					IL_046e:
					num4 = array2[611] - 26038;
					goto IL_0483;
					IL_0466:
					num4 = (int)array[58] / 8;
					goto IL_0483;
					IL_0459:
					num4 = array2[124] - 63452;
					goto IL_0483;
					IL_0455:
					num4 = 39;
					goto IL_0483;
					IL_0483:
					num3 = num4;
					num = -792774179;
					continue;
				}
				break;
			}
		}
	}

	static int m(v.a a_0)
	{
		return j.smethod_22((Stream)a_0) | (j.smethod_22((Stream)a_0) << 8);
	}

	static void b(v.j.m m_0)
	{
		byte[] array = h.d;
		char[] array2 = x.s;
		int num18 = default(int);
		int num17 = default(int);
		object obj2 = default(object);
		int num24 = default(int);
		int num7 = default(int);
		int num5 = default(int);
		int num12 = default(int);
		object obj = default(object);
		int num11 = default(int);
		int num10 = default(int);
		int num21 = default(int);
		int num13 = default(int);
		int num6 = default(int);
		int num22 = default(int);
		object obj3 = default(object);
		int num15 = default(int);
		int num23 = default(int);
		int num8 = default(int);
		int num19 = default(int);
		int num20 = default(int);
		int num14 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 20040647;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x73C0B208u) % 14u)
				{
				case 13u:
					num4 = 49;
					num = ((int)num2 * -586793451) ^ 0x40C93263;
					continue;
				case 12u:
					num = (int)((num2 * 1915761763) ^ 0x16792D8E);
					continue;
				case 11u:
					num18 = 0;
					num4 = array[160];
					num = ((int)num2 * -1734039989) ^ 0x3817A081;
					continue;
				case 10u:
					num3 = 19;
					goto IL_0059;
				case 8u:
					num = ((int)num2 * -355916011) ^ -2001100646;
					continue;
				case 7u:
				{
					num17 = m_0.a[num18];
					int num25;
					if (num17 == 0)
					{
						num = 1182194769;
						num25 = 1182194769;
					}
					else
					{
						num = 1300291784;
						num25 = 1300291784;
					}
					continue;
				}
				case 6u:
					obj2 = new int[num24];
					num = ((int)num2 * -574032223) ^ -1029411460;
					continue;
				case 5u:
					goto IL_00bd;
				case 4u:
					num7 = 0;
					num4 = 9;
					num = ((int)num2 * -1746835734) ^ 0x6110AC16;
					continue;
				case 3u:
					num = (int)((num2 * 573918200) ^ 0x41688400);
					continue;
				case 2u:
					while (true)
					{
						int num9;
						int num16;
						switch (num4)
						{
						case 35:
							break;
						case 49:
							goto IL_00bd;
						case 53:
							((int[])obj2)[num5] = ((int[])obj2)[num12];
							num4 = 48;
							goto case 48;
						case 48:
							if ((num5 = num12) > 0)
							{
								num4 = 3;
								goto case 3;
							}
							num4 = 37;
							goto case 24;
						case 3:
							if ((obj as int[])[((int[])obj2)[num12 = (num5 - 1) / 2]] <= num11)
							{
								num4 = 37;
								goto case 24;
							}
							num4 = array[133] - 84;
							continue;
						case 24:
						case 37:
							(obj2 as int[])[num5] = num10;
							num21 = (obj2 as int[])[0];
							num4 = array[159];
							continue;
						case 52:
							if (num13 > 0)
							{
								num4 = array[261];
								continue;
							}
							num4 = 44;
							goto case 44;
						case 44:
							((int[])obj2)[num13] = num18;
							num6 = num18;
							num4 = 20;
							goto case 20;
						case 20:
							num18++;
							num4 = array2[298] - 19230;
							continue;
						case 13:
							(obj2 as int[])[num12] = ((int[])obj2)[num5];
							num12 = num5;
							num4 = 11;
							goto case 11;
						case 11:
							num5 = num5 * 2 + 1;
							num4 = 8;
							goto case 8;
						case 8:
							if (num5 < num7)
							{
								num4 = 51;
								goto case 51;
							}
							num4 = array2[460] - 54929;
							continue;
						case 1:
							if ((obj as int[])[(obj2 as int[])[num5]] <= (obj as int[])[((int[])obj2)[num5 + 1]])
							{
								num4 = 13;
								goto case 13;
							}
							num4 = array[16];
							continue;
						case 51:
							if (num5 + 1 >= num7)
							{
								num4 = 13;
								goto case 13;
							}
							num4 = 1;
							goto case 1;
						case 50:
							num9 = ++num6;
							goto IL_0256;
						case 42:
							if (num7 >= 2)
							{
								num4 = array[276] + array[276];
								continue;
							}
							num4 = 33;
							goto case 33;
						case 33:
							num4 = ((num6 < 2) ? (array[143] - 134) : (array2[4] - 4607));
							continue;
						case 47:
							num10 = num22++;
							(obj3 as int[])[2 * num10] = num15;
							num4 = 15;
							goto case 15;
						case 15:
							((int[])obj3)[2 * num10 + 1] = num21;
							num23 = j.smethod_24(((int[])obj)[num15] & 0xFF, (obj as int[])[num21] & 0xFF);
							num4 = 45;
							goto case 45;
						case 45:
							num11 = (((int[])obj)[num10] = (obj as int[])[num15] + (obj as int[])[num21] - num23 + 1);
							num4 = 23;
							goto case 23;
						case 23:
							num12 = 0;
							num5 = 1;
							num4 = array2[266] - 64261;
							continue;
						case 46:
							num5 = num12 * 2 + 1;
							num4 = array2[313] - 11099;
							continue;
						case 43:
							num22 = num8;
							num19 = 0;
							num4 = 2;
							goto case 2;
						case 2:
							num4 = ((num19 < num7) ? array[86] : (array2[411] - 29414));
							continue;
						case 41:
							if (num5 >= num7)
							{
								num4 = array2[248] - 37533;
								continue;
							}
							num4 = 7;
							goto case 7;
						case 7:
							if (num5 + 1 < num7)
							{
								num4 = (int)array[0] / 5;
								continue;
							}
							num4 = 0;
							goto case 0;
						case 0:
							((int[])obj2)[num12] = ((int[])obj2)[num5];
							num12 = num5;
							num4 = 46;
							goto case 46;
						case 40:
							num20 = ((int[])obj2)[num19];
							((int[])obj3)[2 * num19] = num20;
							num4 = array[51] - 151;
							continue;
						case 39:
							if ((obj as int[])[(obj2 as int[])[num5]] > ((int[])obj)[(obj2 as int[])[num5 + 1]])
							{
								num4 = array2[52] - 31841;
								continue;
							}
							num4 = 0;
							goto case 0;
						case 38:
							goto IL_045b;
						case 36:
							((int[])obj3)[2 * num19 + 1] = -1;
							((int[])obj)[num19] = m_0.a[num20] << 8;
							num4 = 16;
							goto case 16;
						case 16:
							(obj2 as int[])[num19] = num19;
							num19++;
							num4 = 2;
							goto case 2;
						case 29:
						case 34:
							if ((obj as int[])[((int[])obj2)[num12 = (num5 - 1) / 2]] <= num11)
							{
								num4 = array2[309] - 28291;
								continue;
							}
							num4 = 18;
							goto case 18;
						case 18:
							(obj2 as int[])[num5] = (obj2 as int[])[num12];
							num4 = array[26];
							continue;
						case 32:
							(obj2 as int[])[num5] = num10;
							if (num7 > 1)
							{
								num4 = array[188] - 160;
								continue;
							}
							num4 = 26;
							goto case 26;
						case 31:
							num4 = 42;
							goto case 42;
						case 30:
							obj3 = new int[4 * num7 - 2];
							goto case 22;
						case 22:
							obj = new int[2 * num7 - 1];
							num4 = 43;
							goto case 43;
						case 28:
							num5++;
							num4 = (int)array[24] / 9;
							continue;
						case 27:
							if (m_0.a[(obj2 as int[])[num14 = (num13 - 1) / 2]] <= num17)
							{
								num4 = 44;
								goto case 44;
							}
							num4 = array[151];
							continue;
						case 25:
							if ((num5 = num12) > 0)
							{
								num4 = 29;
								goto case 29;
							}
							num4 = 32;
							goto case 32;
						case 21:
							num15 = ((int[])obj2)[0];
							num10 = (obj2 as int[])[--num7];
							num4 = (int)array[23] / 7;
							continue;
						case 19:
							num13 = num7++;
							num4 = 52;
							goto case 52;
						case 17:
							((int[])obj2)[num13] = (obj2 as int[])[num14];
							num13 = num14;
							num4 = array[166] - 167;
							continue;
						case 14:
							num12 = 0;
							num5 = 1;
							num4 = array[99] - 35;
							continue;
						case 12:
							num11 = ((int[])obj)[num10];
							num4 = array[161] * 2;
							continue;
						case 10:
							num9 = 0;
							goto IL_0256;
						case 6:
							m_0.j = j.smethod_23(num6 + 1, m_0.u);
							num8 = num7;
							num4 = 30;
							goto case 30;
						case 5:
							num4 = 25;
							goto case 25;
						case 4:
							num5++;
							num4 = array2[255] - 24204;
							continue;
						default:
							goto IL_0771;
						case 9:
							goto IL_0778;
						case 26:
							{
								j.s(m_0, obj3 as int[]);
								return;
							}
							IL_0256:
							num16 = num9;
							(obj2 as int[])[num7++] = num16;
							num4 = 42;
							goto case 42;
						}
						break;
						IL_045b:
						if (num18 >= num24)
						{
							num4 = (int)array[288] / 5;
							continue;
						}
						num4 = 35;
						break;
					}
					goto case 7u;
				case 0u:
					goto IL_0778;
				default:
					num3 = array2[206] - 50989;
					goto IL_0059;
				case 9u:
					break;
					IL_0778:
					num6 = 0;
					num = 118511089;
					continue;
					IL_0771:
					num = 1452486455;
					continue;
					IL_00bd:
					num24 = m_0.a.Length;
					num = 567269538;
					continue;
					IL_0059:
					num4 = num3;
					num = 2037929029;
					continue;
				}
				break;
			}
		}
	}

	static int u(v.j.m m_0)
	{
		int num = 5;
		int num6 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2 = 929163232;
			while (true)
			{
				uint num3;
				int num5;
				switch ((num3 = (uint)num2 ^ 0x26EAAC79u) % 13u)
				{
				case 12u:
					num5 = 3;
					goto IL_0008;
				case 11u:
					num6 = 0;
					num2 = (int)((num3 * 1441668103) ^ 0x4C7A41F9);
					continue;
				case 10u:
				{
					int num7;
					if (num6 >= m_0.a.Length)
					{
						num2 = 1039330241;
						num7 = 1039330241;
					}
					else
					{
						num2 = 1650311418;
						num7 = 1650311418;
					}
					continue;
				}
				case 9u:
					goto IL_004e;
				case 8u:
					num2 = ((int)num3 * -1942328598) ^ -1267374914;
					continue;
				case 7u:
					goto IL_0078;
				case 6u:
					goto IL_0081;
				case 5u:
					goto IL_008c;
				default:
					num5 = 6;
					goto IL_0008;
				case 3u:
					num = 1;
					num2 = ((int)num3 * -1939794579) ^ -1801259836;
					continue;
				case 1u:
					switch (num)
					{
					case 1:
						break;
					case 0:
					case 2:
					case 6:
						goto IL_004e;
					case 4:
						goto IL_0078;
					case 7:
						goto IL_0081;
					case 5:
						goto IL_008c;
					default:
						goto IL_00d2;
					case 3:
						return num4;
					}
					goto case 10u;
				case 0u:
					num = 1;
					num2 = ((int)num3 * -1352771719) ^ -1128232852;
					continue;
				case 2u:
					break;
					IL_00d2:
					num2 = 1285255894;
					continue;
					IL_008c:
					num4 = 0;
					num2 = 1776896213;
					continue;
					IL_0081:
					num6++;
					num2 = 1212842133;
					continue;
					IL_0078:
					num = 7;
					num2 = 1901874794;
					continue;
					IL_004e:
					num4 += m_0.a[num6] * m_0.y[num6];
					num2 = 448299539;
					continue;
					IL_0008:
					num = num5;
					num2 = 929163232;
					continue;
				}
				break;
			}
		}
	}

	static void m(object object_0, object[] object_1)
	{
		j.smethod_25((MethodBase)(MethodInfo)object_0, (object)null, object_1);
	}

	static void g(v.x x_0, int int_0)
	{
		char[] array = x.s;
		int num8 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -1806282740;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xCA4B9C83u) % 7u)
				{
				default:
					num3 = 5;
					goto IL_000c;
				case 5u:
					num8 = 1;
					num = ((int)num2 * -1718575232) ^ -1273488939;
					continue;
				case 4u:
					while (true)
					{
						switch (num8)
						{
						case 4:
						case 6:
							num8 = array[81] - 41627;
							continue;
						case 5:
							x_0.m[x_0.d++] = (byte)int_0;
							goto case 4;
						case 1:
							goto IL_007f;
						case 0:
							throw j.smethod_9();
						case 2:
							x_0.d &= 32767;
							return;
						case 3:
							return;
						}
						break;
					}
					num = -630791752;
					continue;
				case 0u:
					goto IL_007f;
				case 2u:
				{
					int num5 = num4;
					x.s[37] = (char)((x.s[37] * int_0) & 'ê');
					int num6;
					int num7;
					if (num5 == 32768)
					{
						num6 = 2050742623;
						num7 = 2050742623;
					}
					else
					{
						num6 = 1780300103;
						num7 = 1780300103;
					}
					num = num6 ^ (int)(num2 * 281518995);
					continue;
				}
				case 1u:
					num3 = 0;
					goto IL_000c;
				case 3u:
					break;
					IL_000c:
					num8 = num3;
					num = -1401224875;
					continue;
					IL_007f:
					num4 = x_0.c++;
					num = -1133555054;
					continue;
				}
				break;
			}
		}
	}

	static void w(v.n n_0)
	{
		n_0.o |= 12;
	}

	static int n(v.x x_0, v.e e_0, int int_0)
	{
		char[] array = x.s;
		byte[] array2 = default(byte[]);
		int num5 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1229154952;
			while (true)
			{
				uint num2;
				int num4;
				int num7;
				switch ((num2 = (uint)num ^ 0x263BA8E7u) % 11u)
				{
				case 10u:
					num = ((int)num2 * -1212142550) ^ -1868687102;
					continue;
				case 9u:
					num3 = array[161] - 13112;
					num = 582342719;
					continue;
				case 8u:
					goto IL_0035;
				case 7u:
					array2 = h.d;
					num = (int)((num2 * 891389031) ^ 0x26F14DE9);
					continue;
				case 6u:
					num4 = 3;
					goto IL_0079;
				case 4u:
					while (true)
					{
						switch (num3)
						{
						case 7:
							break;
						case 1:
						case 9:
							goto IL_0035;
						case 8:
							x_0.d = (x_0.d + num5) & 0x7FFF;
							x_0.c += num5;
							num3 = array2[293] - 58;
							continue;
						case 0:
						case 6:
							num5 = j.c(e_0, x_0.m, x_0.d, int_0);
							num3 = 8;
							goto case 8;
						case 5:
							num5 += j.c(e_0, x_0.m, 0, int_0 - num6);
							num3 = (int)array2[164] / 6;
							continue;
						case 3:
							num5 = j.c(e_0, x_0.m, x_0.d, num6);
							if (num5 == num6)
							{
								num3 = array[240] - 47639;
								continue;
							}
							num3 = 8;
							goto case 8;
						default:
							goto IL_0151;
						case 2:
							goto IL_0158;
						case 4:
							return num5;
						}
						break;
					}
					goto case 9u;
				case 1u:
					goto IL_0158;
				default:
					num4 = 6;
					goto IL_0079;
				case 2u:
					num = (int)(num2 * 315710983) ^ -1839524344;
					continue;
				case 0u:
					num3 = 1;
					num = ((int)num2 * -1571781836) ^ 0x4A3B010C;
					continue;
				case 5u:
					break;
					IL_0158:
					num6 = 32768 - x_0.d;
					if (int_0 <= num6)
					{
						num = 726264025;
						num7 = 726264025;
					}
					else
					{
						num = 626680189;
						num7 = 626680189;
					}
					continue;
					IL_0151:
					num = 1997957227;
					continue;
					IL_0079:
					num3 = num4;
					num = 143629322;
					continue;
					IL_0035:
					int_0 = j.smethod_24(j.smethod_24(int_0, 32768 - x_0.c), e_0.e);
					num = 2013049006;
					continue;
				}
				break;
			}
		}
	}

	static int d(v.a a_0)
	{
		return j.m(a_0) | (j.m(a_0) << 16);
	}

	static void s(v.j.m m_0, int[] int_0)
	{
		byte[] array = h.d;
		int num15 = default(int);
		char[] array2 = default(char[]);
		int num6 = default(int);
		int num12 = default(int);
		int num10 = default(int);
		int num8 = default(int);
		int num7 = default(int);
		int num9 = default(int);
		int num11 = default(int);
		object obj = default(object);
		int num4 = default(int);
		int num14 = default(int);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -295740303;
			while (true)
			{
				uint num2;
				int num16;
				int num17;
				switch ((num2 = (uint)num ^ 0xD31BD529u) % 17u)
				{
				case 16u:
					m_0.y[num15] = 0;
					num = -232926569;
					continue;
				case 15u:
					num15++;
					num3 = 3;
					num = (int)(num2 * 1456674516) ^ -1134687697;
					continue;
				case 14u:
					array2 = x.s;
					num3 = 10;
					num = ((int)num2 * -670249979) ^ -789284401;
					continue;
				case 13u:
					num16 = array[29] - 149;
					goto IL_005e;
				case 12u:
					num = (int)((num2 * 1248580302) ^ 0x5D3DEB0B);
					continue;
				case 11u:
					goto IL_007b;
				case 10u:
					num3 = 24;
					num = (int)((num2 * 2006701650) ^ 0x4077AC83);
					continue;
				case 9u:
					goto IL_00a2;
				case 7u:
					num = ((int)num2 * -1116319762) ^ -681677853;
					continue;
				case 6u:
					goto IL_00d1;
				case 5u:
					goto IL_00f7;
				case 4u:
					num6 = int_0.Length / 2;
					num = (int)(num2 * 1803930925) ^ -1840248579;
					continue;
				default:
					num16 = 13;
					goto IL_005e;
				case 2u:
					num12 = 0;
					num = (int)(num2 * 1043258474) ^ -1797806778;
					continue;
				case 1u:
					num15 = 0;
					num = ((int)num2 * -985445185) ^ -1496181610;
					continue;
				case 0u:
					while (true)
					{
						switch (num3)
						{
						case 13:
						case 20:
							break;
						case 24:
							goto IL_007b;
						case 10:
							goto IL_00a2;
						case 3:
							goto IL_00d1;
						case 28:
							goto IL_00f7;
						case 36:
							num10 = num6 - 1;
							num3 = array2[631] - 57791;
							continue;
						case 35:
							num8--;
							num3 = 19;
							goto case 19;
						case 19:
							num3 = ((num8 != 0) ? (array[205] - 90) : array[272]);
							continue;
						case 34:
							m_0.y[num7]--;
							m_0.y[++num7]++;
							num3 = array2[411] - 29406;
							continue;
						case 33:
							if (num10 < 0)
							{
								num3 = 6;
								goto case 6;
							}
							num3 = array[37] - array[33];
							continue;
						case 6:
							if (num12 == 0)
							{
								num3 = (int)array[153] / 9;
								continue;
							}
							num3 = 22;
							goto case 22;
						case 22:
							num7 = m_0.q - 1;
							num3 = 2;
							goto case 2;
						case 2:
						case 32:
							while (m_0.y[--num7] == 0)
							{
								num3 = 2;
							}
							num3 = 34;
							goto case 34;
						case 31:
							num9 = m_0.y[num8 - 1];
							num3 = 17;
							goto case 17;
						case 17:
							num3 = ((num9 > 0) ? (array2[124] - 63477) : (array2[358] - 43736));
							continue;
						case 30:
							num11 = (obj as int[])[num10] + 1;
							if (num11 > m_0.q)
							{
								num3 = array[226] + 13;
								continue;
							}
							num3 = 11;
							goto case 11;
						case 11:
							((int[])obj)[int_0[2 * num10]] = (((int[])obj)[int_0[2 * num10 + 1]] = num11);
							num3 = array[26];
							continue;
						case 29:
							num12 -= 1 << m_0.q - 1 - num7;
							num3 = 23;
							goto case 23;
						case 23:
							if (num12 > 0)
							{
								num3 = 27;
								goto case 27;
							}
							num3 = 18;
							goto case 18;
						case 27:
							if (num7 >= m_0.q - 1)
							{
								num3 = 18;
								goto case 18;
							}
							num3 = array2[381] - 198;
							continue;
						case 18:
							if (num12 <= 0)
							{
								num3 = 0;
								goto case 0;
							}
							num3 = array[272] * 2;
							continue;
						case 0:
							m_0.y[m_0.q - 1] += num12;
							num3 = 16;
							goto case 16;
						case 16:
							m_0.y[m_0.q - 2] -= num12;
							num3 = 8;
							goto case 8;
						case 8:
							num4 = 2 * num14;
							num8 = m_0.q;
							num3 = array[27] + 8;
							continue;
						case 26:
							if (int_0[2 * num10 + 1] != -1)
							{
								num3 = 30;
								goto case 30;
							}
							num3 = 21;
							goto case 21;
						case 21:
						{
							int num13 = ((int[])obj)[num10];
							m_0.y[num13 - 1]++;
							num3 = 9;
							goto case 9;
						}
						case 9:
							m_0.y[int_0[2 * num10]] = (byte)(obj as int[])[num10];
							num3 = array[26];
							continue;
						case 25:
							num10--;
							num3 = 33;
							goto case 33;
						case 15:
							num11 = m_0.q;
							num12++;
							num3 = 11;
							goto case 11;
						case 14:
							if (int_0[num5 + 1] == -1)
							{
								num3 = 4;
								goto case 4;
							}
							num3 = array[151];
							continue;
						case 4:
							m_0.y[int_0[num5]] = (byte)num8;
							num9--;
							num3 = 17;
							goto case 17;
						case 12:
							obj = new int[num6];
							((int[])obj)[num6 - 1] = 0;
							num3 = 36;
							goto case 36;
						case 5:
							num5 = 2 * int_0[num4++];
							num3 = 14;
							goto case 14;
						default:
							goto IL_050e;
						case 1:
							return;
						case 7:
							return;
						}
						break;
					}
					goto case 16u;
				case 8u:
					break;
					IL_050e:
					num = -26709879;
					continue;
					IL_00f7:
					num3 = array[188] - array[118];
					num = -100859729;
					continue;
					IL_00d1:
					if (num15 >= m_0.q)
					{
						num = -318195099;
						num17 = -318195099;
					}
					else
					{
						num = -721588894;
						num17 = -721588894;
					}
					continue;
					IL_00a2:
					m_0.y = new byte[m_0.a.Length];
					num = -1405517599;
					continue;
					IL_007b:
					num14 = (num6 + 1) / 2;
					num = -765186898;
					continue;
					IL_005e:
					num3 = num16;
					num = -1357072521;
					continue;
				}
				break;
			}
		}
	}

	static int j(v.j j_0, int int_0)
	{
		char[] array = x.s;
		int num5 = default(int);
		byte[] array2 = default(byte[]);
		int num4 = default(int);
		while (true)
		{
			int num = -1915573707;
			while (true)
			{
				uint num2;
				int num3;
				int num6;
				switch ((num2 = (uint)num ^ 0xA86B7D5Bu) % 12u)
				{
				case 11u:
					num5 += 2;
					num = -431335049;
					continue;
				case 10u:
					array2 = h.d;
					num = ((int)num2 * -1110127237) ^ 0x6151B40F;
					continue;
				default:
					num3 = array2[94];
					goto IL_0037;
				case 8u:
					int_0 >>= 1;
					num4 = array[570] - array[570];
					num = (int)(num2 * 1952432619) ^ -254049684;
					continue;
				case 7u:
					num = ((int)num2 * -1519206996) ^ -1570919328;
					continue;
				case 6u:
					goto IL_007a;
				case 5u:
					goto IL_0085;
				case 4u:
					num = ((int)num2 * -473107932) ^ -979007676;
					continue;
				case 3u:
					switch (num4)
					{
					case 4:
					case 5:
						break;
					case 2:
						goto IL_007a;
					case 0:
					case 3:
						goto IL_0085;
					default:
						goto IL_00d3;
					case 1:
					case 6:
						return num5 + int_0;
					}
					goto case 11u;
				case 2u:
					num4 = 2;
					num = (int)((num2 * 548588983) ^ 0x12E0B326);
					continue;
				case 1u:
					num3 = 1;
					goto IL_0037;
				case 0u:
					break;
					IL_00d3:
					num = -276641959;
					continue;
					IL_0085:
					if (int_0 < 4)
					{
						num = -225420686;
						num6 = -225420686;
					}
					else
					{
						num = -1491513402;
						num6 = -1491513402;
					}
					continue;
					IL_007a:
					num5 = 0;
					num4 = 0;
					num = -1396638044;
					continue;
					IL_0037:
					num4 = num3;
					num = -1361280541;
					continue;
				}
				break;
			}
		}
	}

	static short r(int int_0)
	{
		return (short)((v.j.u[int_0 & 0xF] << 12) | (v.j.u[(int_0 >> 4) & 0xF] << 8) | (v.j.u[(int_0 >> 8) & 0xF] << 4) | v.j.u[int_0 >> 12]);
	}

	static void l()
	{
		j.m((object)j.smethod_26(x.g()), new object[0]);
	}

	static void q(v.j.m m_0, v.j.m m_1)
	{
		byte[] array = h.d;
		int num5 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		char[] array2 = default(char[]);
		int num12 = default(int);
		int num11 = default(int);
		int num10 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -498276782;
			while (true)
			{
				uint num2;
				int num4;
				switch ((num2 = (uint)num ^ 0xB781B967u) % 11u)
				{
				case 9u:
					num5 = m_0.y[num8];
					num = ((int)num2 * -180093040) ^ -1200470900;
					continue;
				case 8u:
					while (true)
					{
						switch (num3)
						{
						case 19:
							if (num9 > 10)
							{
								num3 = array2[164] - 2498;
								continue;
							}
							num3 = 3;
							goto case 3;
						case 18:
							if (num12 != 0)
							{
								num3 = array2[456] - 65428;
								continue;
							}
							num3 = 19;
							goto case 19;
						case 12:
						case 17:
							m_1.a[num5]++;
							num3 = 6;
							goto case 6;
						case 6:
							num9 = 0;
							num3 = 0;
							goto case 0;
						case 0:
							num12 = num5;
							num8++;
							num3 = 14;
							goto case 14;
						case 14:
							if (num8 < m_0.j)
							{
								num3 = array2[51] - 14330;
								continue;
							}
							num3 = 7;
							goto case 7;
						case 7:
							if (num9 >= num11)
							{
								num3 = 18;
								goto case 18;
							}
							num3 = 2;
							goto case 2;
						case 16:
							num10 = 6;
							num11 = 3;
							if (num12 != num5)
							{
								num3 = 12;
								goto case 12;
							}
							num3 = 0;
							goto case 0;
						case 10:
							if (num12 != m_0.y[num8])
							{
								num3 = 7;
								goto case 7;
							}
							num3 = array[233];
							continue;
						case 4:
							num8++;
							if (++num9 < num10)
							{
								num3 = 14;
								goto case 14;
							}
							num3 = array2[231] - 50783;
							continue;
						case 1:
							num10 = 138;
							num11 = 3;
							num3 = array2[181] - 435;
							continue;
						case 5:
							m_1.a[18]++;
							num3 = 8;
							goto case 8;
						case 11:
							goto IL_01ba;
						case 2:
							m_1.a[num12] += (short)num9;
							num3 = 8;
							goto case 8;
						case 3:
							m_1.a[17]++;
							num3 = 8;
							goto case 8;
						case 20:
							m_1.a[16]++;
							goto case 13;
						case 13:
							num3 = 8;
							goto case 8;
						case 8:
							if (num8 < m_0.j)
							{
								num3 = 15;
								goto IL_023d;
							}
							num3 = 9;
							return;
						case 15:
							goto IL_023d;
						case 21:
							goto IL_0247;
						case 9:
							return;
						}
						break;
					}
					num = -1286130282;
					continue;
				case 4u:
					goto IL_01ba;
				case 6u:
					goto IL_023d;
				case 0u:
					goto IL_0247;
				case 7u:
					num8 = 0;
					num = ((int)num2 * -625449998) ^ 0x258A6C4F;
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (num5 == 0)
					{
						num6 = -920227303;
						num7 = -920227303;
					}
					else
					{
						num6 = -1855194938;
						num7 = -1855194938;
					}
					num = num6 ^ (int)(num2 * 172341636);
					continue;
				}
				case 3u:
					num4 = 1;
					goto IL_0287;
				default:
					num4 = array[37] - 184;
					goto IL_0287;
				case 1u:
					array2 = x.s;
					num3 = 21;
					num = (int)(num2 * 1481801486) ^ -1530446736;
					continue;
				case 10u:
					break;
					IL_0287:
					num3 = num4;
					num = -289979498;
					continue;
					IL_023d:
					num9 = 1;
					num = -313892972;
					continue;
					IL_01ba:
					num3 = 8;
					num = -289979498;
					continue;
					IL_0247:
					num12 = -1;
					num = -163476520;
					continue;
				}
				break;
			}
		}
	}

	static void f(byte[] byte_0, v.j.m m_0, short[] short_0)
	{
		m_0.w = short_0;
		while (true)
		{
			int num = -1862994437;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB70D55DCu) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0009:
				m_0.y = byte_0;
				num = (int)(num2 * 662790247) ^ -1327181679;
			}
		}
	}

	static void f(v.j.m m_0)
	{
		char[] array = x.s;
		int num = 12;
		int num5 = default(int);
		object obj = default(object);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num2 = 1005064065;
			while (true)
			{
				uint num3;
				int num4;
				int num9;
				switch ((num3 = (uint)num2 ^ 0x3A8ADE4Fu) % 12u)
				{
				case 11u:
					num4 = 3;
					goto IL_000f;
				case 10u:
					while (true)
					{
						switch (num)
						{
						case 14:
							m_0.w[num5] = j.r((obj as int[])[num6 - 1]);
							num = 11;
							goto case 11;
						case 11:
							((int[])obj)[num6 - 1] += 1 << 16 - num6;
							num = array[217] - 50451;
							continue;
						case 13:
							if (num5 < m_0.j)
							{
								num = 9;
								goto case 9;
							}
							num = 10;
							return;
						case 9:
							num6 = m_0.y[num5];
							if (num6 > 0)
							{
								num = 14;
								goto case 14;
							}
							num = array[117] - 30386;
							continue;
						case 8:
							num5++;
							num = 13;
							goto case 13;
						case 3:
							num5 = 0;
							num = array[188] - 24802;
							continue;
						case 1:
							goto IL_0107;
						case 4:
							goto IL_0133;
						case 0:
						case 6:
							goto IL_0141;
						case 7:
							goto IL_0163;
						case 5:
						case 12:
							goto IL_017c;
						case 2:
						case 10:
							return;
						}
						break;
					}
					num2 = 1683916392;
					continue;
				case 0u:
					goto IL_0107;
				case 4u:
					goto IL_0133;
				case 1u:
					goto IL_0141;
				case 9u:
					goto IL_0163;
				case 7u:
					goto IL_017c;
				case 8u:
					num2 = (int)((num3 * 2055399843) ^ 0x6BA0D721);
					continue;
				case 6u:
					num2 = ((int)num3 * -240899120) ^ 0x32F558E1;
					continue;
				case 5u:
					m_0.w = new short[m_0.a.Length];
					num = 4;
					num2 = (int)(num3 * 1417845476) ^ -1446639051;
					continue;
				default:
					num4 = 1;
					goto IL_000f;
				case 3u:
					break;
					IL_017c:
					obj = new int[m_0.q];
					num7 = 0;
					num2 = 33208786;
					continue;
					IL_0163:
					num8++;
					num = array[629] - 31771;
					num2 = 1005064065;
					continue;
					IL_0141:
					if (num8 < m_0.q)
					{
						num2 = 1707483869;
						num9 = 1707483869;
					}
					else
					{
						num2 = 1925766036;
						num9 = 1925766036;
					}
					continue;
					IL_000f:
					num = num4;
					num2 = 1005064065;
					continue;
					IL_0133:
					num8 = 0;
					num = 6;
					num2 = 1005064065;
					continue;
					IL_0107:
					(obj as int[])[num8] = num7;
					num7 += m_0.y[num8] << 15 - num8;
					num = 7;
					num2 = 856051887;
					continue;
				}
				break;
			}
		}
	}

	static v.t y(v.b b_0)
	{
		char[] array = x.s;
		int num = 1;
		object obj = default(object);
		while (true)
		{
			int num2 = -785066172;
			while (true)
			{
				uint num3;
				v.t result;
				switch ((num3 = (uint)num2 ^ 0x8FEE1A25u) % 5u)
				{
				case 4u:
					switch (num)
					{
					case 1:
					case 3:
						goto IL_002e;
					case 0:
					case 2:
					case 4:
						goto IL_00a3;
					}
					num2 = -1153244261;
					continue;
				case 3u:
					goto IL_002e;
				case 2u:
					j.smethod_5((Array)b_0.w, 0, (Array)(obj as byte[]), 0, b_0.t);
					num = array[293] - array[293];
					num2 = ((int)num3 * -1870241825) ^ -306777406;
					continue;
				case 0u:
					break;
				default:
					goto IL_00a3;
					IL_00a3:
					result = new v.t((byte[])obj);
					h.d[38] = (byte)((h.d[38] * h.d[33]) & 0x60);
					return result;
					IL_002e:
					obj = new byte[b_0.t];
					num2 = -435738337;
					continue;
				}
				break;
			}
		}
	}

	static Assembly f(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected I4, but got Unknown
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected I4, but got Unknown
		//IL_0637: Incompatible stack heights: 0 vs 1
		//IL_063e: Incompatible stack heights: 0 vs 1
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected I4, but got Unknown
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected I4, but got Unknown
		//IL_0675: Incompatible stack heights: 0 vs 1
		//IL_067c: Incompatible stack heights: 0 vs 1
		byte[] array = h.d;
		t.v v2 = default(t.v);
		bool flag2 = default(bool);
		int num23 = default(int);
		char[] array4 = default(char[]);
		Array array3 = default(Array);
		IEnumerable enumerable2 = default(IEnumerable);
		int num22 = default(int);
		IEquatable<string> equatable = default(IEquatable<string>);
		int num5 = default(int);
		IComparable<string> comparable = default(IComparable<string>);
		bool flag = default(bool);
		int num3 = default(int);
		int num18 = default(int);
		object obj5 = default(object);
		Array array5 = default(Array);
		object obj4 = default(object);
		object obj2 = default(object);
		IEquatable<string> equatable2 = default(IEquatable<string>);
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			int num = 247202910;
			while (true)
			{
				uint num2;
				int num4;
				int num26;
				switch ((num2 = (uint)num ^ 0x1522D21Fu) % 18u)
				{
				case 17u:
					num3 = 18;
					num = ((int)num2 * -1794658630) ^ 0x8B78E8E;
					continue;
				case 16u:
					v2 = new t.v(j.smethod_27(resolveEventArgs_0));
					num = 487940449;
					continue;
				case 14u:
					flag2 = false;
					num23 = 0;
					num3 = array4[484] - 42498;
					num = (int)(num2 * 1735086758) ^ -1121521334;
					continue;
				case 13u:
					while (true)
					{
						switch (num3)
						{
						case 11:
						case 18:
							break;
						case 21:
							if (num23 >= (array3 as string[]).Length - 1)
							{
								num3 = 14;
								goto case 14;
							}
							num3 = 10;
							goto IL_0249;
						case 14:
							if (j.smethod_33(enumerable2 as string) == 0)
							{
								num3 = 17;
								goto case 17;
							}
							num3 = 5;
							goto case 5;
						case 17:
							num3 = ((j.smethod_33(v2.d) != 0) ? (array[272] * 5) : ((int)array[161] / 2));
							continue;
						case 5:
							if (j.smethod_33(enumerable2 as string) > 0)
							{
								num3 = 2;
								goto case 2;
							}
							goto IL_0a87;
						case 2:
						case 4:
							num3 = ((j.smethod_34(enumerable2 as string, 0) != '[') ? (array4[235] - 62088) : (array4[499] - 58839));
							continue;
						case 20:
							num23 += 2;
							num3 = 21;
							goto case 21;
						case 19:
							if (num22 >= (array3 as string[]).Length - 1)
							{
								num3 = 5;
								goto case 5;
							}
							num3 = array4[319] - 13574;
							continue;
						case 16:
							if (j.smethod_32((array3 as string[])[num22], (string)equatable))
							{
								num3 = array4[295] - 3801;
								continue;
							}
							num3 = 0;
							goto case 0;
						case 0:
							num22 += 2;
							num3 = 19;
							goto case 19;
						case 15:
							enumerable2 = (array3 as string[])[num23 + 1];
							num3 = 14;
							goto case 14;
						case 12:
							equatable = j.smethod_30(j.smethod_29(j.smethod_28(), v2.t));
							num22 = 0;
							num3 = 19;
							goto case 19;
						case 6:
							enumerable2 = (array3 as string[])[num22 + 1];
							num3 = 5;
							goto case 5;
						default:
							goto IL_0215;
						case 1:
							goto IL_021f;
						case 8:
							goto IL_022f;
						case 13:
							goto IL_023c;
						case 10:
							goto IL_0249;
						case 22:
							num5 = j.smethod_35(enumerable2 as string, ']');
							comparable = j.smethod_36((string)enumerable2, 1, num5 - 1);
							num3 = 9;
							goto case 9;
						case 9:
							flag = j.smethod_35(comparable as string, 'z') >= 0;
							flag2 = j.smethod_35(comparable as string, 't') >= 0;
							num3 = 7;
							goto case 7;
						case 7:
							enumerable2 = j.smethod_37((string)enumerable2, num5 + 1);
							num3 = 3;
							goto case 3;
						case 3:
							{
								object obj;
								j.smethod_38(obj = t.t);
								try
								{
									while (true)
									{
										IL_0594:
										int num6 = 7;
										int num7 = 1585760730;
										while (true)
										{
											int num8;
											int num19;
											switch ((num2 = (uint)num7 ^ 0x1522D21Fu) % 7u)
											{
											default:
												num8 = 8;
												goto IL_0452;
											case 5u:
												while (true)
												{
													switch (num6)
													{
													case 10:
														num18 = (int)j.smethod_18(obj5 as Stream);
														goto case 3;
													case 3:
														array5 = new byte[num18];
														goto case 1;
													case 1:
														j.smethod_17(obj5 as Stream, (byte[])array5, 0, num18);
														num6 = 9;
														goto case 9;
													case 9:
														if (flag)
														{
															num6 = 4;
															goto case 4;
														}
														num6 = array4[279] - 50451;
														continue;
													case 4:
														array5 = j.o(array5 as byte[]);
														num6 = array4[268] - 58316;
														continue;
													case 8:
														obj5 = j.smethod_39(j.smethod_14(), enumerable2 as string);
														if (obj5 is Stream)
														{
															num6 = 10;
															goto case 10;
														}
														goto end_IL_0564;
													case 2:
													case 5:
													case 7:
														goto IL_052b;
													case 0:
														obj4 = t.t[enumerable2 as string];
														goto IL_0a93;
													case 6:
													{
														ICustomAttributeProvider customAttributeProvider = null;
														if (!flag2)
														{
															try
															{
																while (true)
																{
																	IL_05ed:
																	customAttributeProvider = j.smethod_40((byte[])array5);
																	int num9 = 1408477342;
																	while (true)
																	{
																		switch ((num2 = (uint)num9 ^ 0x1522D21Fu) % 5u)
																		{
																		case 3u:
																			goto IL_05c3;
																		default:
																			goto end_IL_05c8;
																		case 1u:
																		case 2u:
																		case 4u:
																			break;
																		case 0u:
																			goto end_IL_05c8;
																		}
																		goto IL_05ed;
																		IL_05c3:
																		num9 = 484351970;
																		continue;
																		end_IL_05c8:
																		break;
																	}
																	break;
																}
															}
															catch (FileLoadException)
															{
																while (true)
																{
																	IL_0639:
																	_ = 1878990779;
																	while (true)
																	{
																		_003F val = /*Error near IL_0610: Stack underflow*/^ 0x1522D21F;
																		num2 = (uint)(int)val;
																		switch (val % 3)
																		{
																		default:
																			goto end_IL_060a;
																		case 1:
																			flag2 = true;
																			_ = (num2 * 1657745072) ^ 0x2CA5F767;
																			continue;
																		case 2:
																			break;
																		case 0:
																			goto end_IL_060a;
																		}
																		goto IL_0639;
																		continue;
																		end_IL_060a:
																		break;
																	}
																	break;
																}
															}
															catch (BadImageFormatException)
															{
																while (true)
																{
																	IL_0677:
																	_ = 1487504652;
																	while (true)
																	{
																		_003F val2 = /*Error near IL_064e: Stack underflow*/^ 0x1522D21F;
																		num2 = (uint)(int)val2;
																		switch (val2 % 3)
																		{
																		default:
																			goto end_IL_0648;
																		case 1:
																			flag2 = true;
																			_ = ((int)num2 * -1389727688) ^ 0x77EC924E;
																			continue;
																		case 0:
																			break;
																		case 2:
																			goto end_IL_0648;
																		}
																		goto IL_0677;
																		continue;
																		end_IL_0648:
																		break;
																	}
																	break;
																}
															}
														}
														while (true)
														{
															IL_06d4:
															int num10 = 3;
															int num11 = 320698639;
															while (true)
															{
																switch ((num2 = (uint)num11 ^ 0x1522D21Fu) % 5u)
																{
																case 3u:
																	num11 = 1638227454;
																	continue;
																case 1u:
																	switch (num10)
																	{
																	default:
																		num11 = ((int)num2 * -1201032750) ^ -330645401;
																		continue;
																	case 0:
																	case 1:
																	case 2:
																	case 3:
																	case 4:
																		break;
																	}
																	goto default;
																case 4u:
																	break;
																default:
																	if (flag2)
																	{
																		try
																		{
																			while (true)
																			{
																				IL_0898:
																				int num12 = 3;
																				int num13 = 2077858823;
																				while (true)
																				{
																					int num14;
																					int num15;
																					switch ((num2 = (uint)num13 ^ 0x1522D21Fu) % 15u)
																					{
																					case 12u:
																					case 14u:
																						num13 = 2104182881;
																						continue;
																					case 13u:
																						switch (num12)
																						{
																						case 3:
																						case 4:
																							break;
																						default:
																							goto IL_0725;
																						case 0:
																							goto IL_072f;
																						case 1:
																							goto IL_0759;
																						case 6:
																							obj2 = j.smethod_46(equatable2 as string);
																							goto case 2;
																						case 2:
																						case 8:
																							j.smethod_1((Stream)(obj2 as FileStream), array5 as byte[], 0, (array5 as byte[]).Length);
																							num12 = 7;
																							goto case 5;
																						case 5:
																						case 7:
																							j.smethod_21((Stream)(obj2 as FileStream));
																							j.MoveFileEx(equatable2 as string, (string)null, 4);
																							j.MoveFileEx(cloneable as string, (string)null, 4);
																							num12 = 9;
																							goto case 9;
																						case 9:
																							customAttributeProvider = j.smethod_47(equatable2 as string);
																							goto end_IL_084a;
																						}
																						goto case 12u;
																					case 2u:
																						goto IL_072f;
																					case 6u:
																						goto IL_0759;
																					case 11u:
																						num13 = ((int)num2 * -2051360223) ^ 0x14809993;
																						continue;
																					case 9u:
																						num12 = 1;
																						num13 = ((int)num2 * -474088932) ^ -881012825;
																						continue;
																					case 8u:
																						num13 = 805451063;
																						continue;
																					case 7u:
																						cloneable = j.smethod_42(c.k(1229547729, null, 6), (object)j.smethod_41(), (object)(string)enumerable2);
																						num13 = (int)((num2 * 1972983572) ^ 0x6757D97A);
																						continue;
																					case 5u:
																						num13 = (int)(num2 * 2127197194) ^ -679692943;
																						continue;
																					case 4u:
																						num12 = array4[486] - array4[486];
																						num13 = ((int)num2 * -1974057340) ^ 0x52522C00;
																						continue;
																					case 3u:
																						equatable2 = j.smethod_44((string)cloneable, v2.t, c.k(1229547725, null, 0));
																						num13 = ((int)num2 * -594360845) ^ 0x46AC8375;
																						continue;
																					default:
																						num14 = array[71] - 74;
																						goto IL_0836;
																					case 0u:
																						num14 = array[276] * 2;
																						goto IL_0836;
																					case 10u:
																						break;
																						IL_0836:
																						num12 = num14;
																						num13 = 2077858823;
																						continue;
																						IL_0759:
																						j.smethod_43((string)cloneable);
																						num13 = 2081103465;
																						continue;
																						IL_072f:
																						if (j.smethod_45(equatable2 as string))
																						{
																							num13 = 1514067345;
																							num15 = 1514067345;
																						}
																						else
																						{
																							num13 = 1716206053;
																							num15 = 1716206053;
																						}
																						continue;
																						IL_0725:
																						num13 = 1318018011;
																						continue;
																					}
																					goto IL_0898;
																					continue;
																					end_IL_084a:
																					break;
																				}
																				break;
																			}
																		}
																		catch
																		{
																		}
																	}
																	while (true)
																	{
																		IL_099e:
																		int num16 = 5;
																		int num17 = 131830105;
																		while (true)
																		{
																			switch ((num2 = (uint)num17 ^ 0x1522D21Fu) % 7u)
																			{
																			case 1u:
																			case 3u:
																				t.t[(string)enumerable2] = customAttributeProvider as Assembly;
																				obj4 = customAttributeProvider as Assembly;
																				num17 = 408594450;
																				continue;
																			case 2u:
																				num17 = 1437547402;
																				continue;
																			case 0u:
																				switch (num16)
																				{
																				case 0:
																				case 1:
																				case 3:
																				case 4:
																				case 5:
																					break;
																				default:
																					num17 = (int)(num2 * 143010108) ^ -1808963427;
																					continue;
																				case 2:
																					goto end_IL_0971;
																				}
																				goto case 1u;
																			default:
																				goto end_IL_0971;
																			case 6u:
																				break;
																			case 4u:
																				goto end_IL_0971;
																			case 5u:
																				goto IL_0a93;
																			}
																			goto IL_099e;
																			continue;
																			end_IL_0971:
																			break;
																		}
																		break;
																	}
																	goto end_IL_06af;
																}
																goto IL_06d4;
																continue;
																end_IL_06af:
																break;
															}
															break;
														}
														goto end_IL_0564;
													}
													}
													break;
												}
												num7 = 1336803328;
												continue;
											case 1u:
											case 2u:
												goto IL_052b;
											case 3u:
												num8 = array[91];
												goto IL_0452;
											case 0u:
												num7 = 440003996;
												continue;
											case 4u:
												break;
												IL_052b:
												if (t.t.ContainsKey(enumerable2 as string))
												{
													num7 = 138644359;
													num19 = 138644359;
												}
												else
												{
													num7 = 1064919425;
													num19 = 1064919425;
												}
												continue;
												IL_0452:
												num6 = num8;
												num7 = 1585760730;
												continue;
											}
											goto IL_0594;
											continue;
											end_IL_0564:
											break;
										}
										break;
									}
								}
								finally
								{
									while (true)
									{
										IL_0a20:
										int num20 = 2;
										int num21 = 1562670596;
										while (true)
										{
											switch ((num2 = (uint)num21 ^ 0x1522D21Fu) % 6u)
											{
											case 5u:
												switch (num20)
												{
												default:
													num21 = (int)(num2 * 714217984) ^ -1113981339;
													continue;
												case 1:
												case 2:
												case 3:
													break;
												case 0:
												case 4:
													goto end_IL_09f7;
												}
												goto case 0u;
											case 0u:
											case 3u:
												j.smethod_48((object)(obj as Dictionary<string, Assembly>));
												num21 = 1138977677;
												continue;
											case 2u:
												num21 = 1863642258;
												continue;
											default:
												goto end_IL_09f7;
											case 1u:
												break;
											case 4u:
												goto end_IL_09f7;
											}
											goto IL_0a20;
											continue;
											end_IL_09f7:
											break;
										}
										break;
									}
								}
								goto IL_0a87;
							}
							IL_0a87:
							while (true)
							{
								int num24 = 3;
								int num25 = 261347123;
								while (true)
								{
									switch ((num2 = (uint)num25 ^ 0x1522D21Fu) % 6u)
									{
									case 4u:
										num25 = 1303434556;
										continue;
									case 0u:
										switch (num24)
										{
										case 2:
										case 3:
										case 4:
										case 5:
											goto IL_0a91;
										case 0:
										case 1:
											goto end_IL_0a87;
										}
										num25 = ((int)num2 * -165021013) ^ -2077813450;
										continue;
									case 3u:
										break;
									case 1u:
									case 2u:
										goto IL_0a91;
									default:
										goto end_IL_0a87;
										IL_0a91:
										return null;
									}
									break;
								}
								continue;
								end_IL_0a87:
								break;
							}
							goto IL_0a93;
							IL_0a93:
							return obj4 as Assembly;
						}
						break;
					}
					goto case 16u;
				case 0u:
					goto IL_021f;
				case 6u:
					goto IL_022f;
				case 8u:
					goto IL_023c;
				case 4u:
					goto IL_0249;
				case 12u:
					num = (int)(num2 * 560058869) ^ -1563918546;
					continue;
				case 11u:
					array4 = x.s;
					num = (int)((num2 * 1452565312) ^ 0x532AC930);
					continue;
				default:
					num4 = 20;
					goto IL_02aa;
				case 9u:
					num = ((int)num2 * -1667126948) ^ -352550108;
					continue;
				case 7u:
					num4 = array[99] - array[16];
					goto IL_02aa;
				case 5u:
				{
					string string_ = v.a.u(5, 15, j.smethod_15(typeof(v.e).TypeHandle), 1468094532);
					Array array2 = new char[1];
					(array2 as char[])[0] = ',';
					array3 = j.smethod_31(string_, (char[])array2);
					num3 = 1;
					num = (int)(num2 * 794161508) ^ -150427835;
					continue;
				}
				case 3u:
					num = ((int)num2 * -1682702060) ^ -2007320860;
					continue;
				case 2u:
				{
					IEnumerable<char> enumerable = v2.i(bool_0: false);
					equatable = j.smethod_30(j.smethod_29(j.smethod_28(), enumerable as string));
					num = ((int)num2 * -515219939) ^ 0x7764CF1C;
					continue;
				}
				case 1u:
					num3 = array[186] - 203;
					num = (int)(num2 * 697030049) ^ -1851931571;
					continue;
				case 15u:
					break;
					IL_02aa:
					num3 = num4;
					num = 60061832;
					continue;
					IL_023c:
					num = 59416442;
					continue;
					IL_022f:
					flag = false;
					num = 481808687;
					continue;
					IL_021f:
					enumerable2 = string.Empty;
					num = 1840466937;
					continue;
					IL_0215:
					num = 319296235;
					continue;
					IL_0249:
					if (!j.smethod_32(((string[])array3)[num23], (string)equatable))
					{
						num = 155662059;
						num26 = 155662059;
					}
					else
					{
						num = 1856416324;
						num26 = 1856416324;
					}
					continue;
				}
				break;
			}
		}
	}

	static string[] h()
	{
		return new string[16]
		{
			c.k(1229547724, null, 8),
			c.k(1229547768, null, 6),
			c.k(1229547767, null, 4),
			c.k(1229547766, null, 2),
			c.k(1229547756, null, 2),
			c.k(1229547752, null, 8),
			c.k(1229547749, null, 0),
			c.k(1229547548, null, 3),
			c.k(1229547537, null, 0),
			v.a.u(4, 11, j.smethod_15(typeof(p.c).TypeHandle), 1468094500),
			c.k(1229547528, null, 3),
			v.a.u(0, 13, j.smethod_15(typeof(p.c).TypeHandle), 1468094510),
			c.k(1229547528, null, 4),
			v.a.u(1, 2, j.smethod_15(typeof(e).TypeHandle), 1468094933),
			c.k(1229547525, null, 3),
			c.k(1229547724, null, 8)
		};
	}

	static void p(v.e e_0)
	{
		char[] array = x.s;
		int num3 = default(int);
		while (true)
		{
			int num = -57029149;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEEBCDDF2u) % 8u)
				{
				case 7u:
					e_0.k >>= e_0.g & 7;
					num = -370651375;
					continue;
				case 6u:
					switch (num3)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_0044;
					case 1:
					case 3:
						goto IL_004b;
					case 4:
						goto IL_0061;
					}
					goto case 7u;
				case 0u:
					goto IL_004b;
				case 3u:
					goto IL_0061;
				case 2u:
					num = ((int)num2 * -1466354970) ^ -1563997024;
					continue;
				case 1u:
					num3 = 0;
					num = (int)(num2 * 175895718) ^ -2125395894;
					continue;
				default:
					return;
				case 4u:
					break;
				case 5u:
					return;
					IL_0061:
					num3 = array[160] - 16810;
					num = -1651832512;
					continue;
					IL_004b:
					e_0.g &= -8;
					num = -1826906081;
					continue;
					IL_0044:
					num = -501332979;
					continue;
				}
				break;
			}
		}
	}

	static void i(int int_0, v.a a_0)
	{
		j.smethod_49((Stream)a_0, (byte)((uint)int_0 & 0xFFu));
		while (true)
		{
			int num = 2044809385;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30B68A20u) % 4u)
				{
				case 1u:
					j.smethod_49((Stream)a_0, (byte)((uint)(int_0 >> 8) & 0xFFu));
					num = (int)((num2 * 283661779) ^ 0x5B5E10A7);
					continue;
				case 0u:
					x.s[299] = (char)((x.s[299] | int_0) & 'è');
					num = (int)(num2 * 1343611827) ^ -1544757241;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	static bool a(int int_0, v.u u_0)
	{
		byte[] array = h.d;
		char[] array2 = x.s;
		int num9 = default(int);
		int num10 = default(int);
		byte b2 = default(byte);
		int num7 = default(int);
		int num8 = default(int);
		int num4 = default(int);
		object obj = default(object);
		int num12 = default(int);
		int num6 = default(int);
		byte b3 = default(byte);
		int num11 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -1688503945;
			while (true)
			{
				uint num2;
				int num5;
				int num13;
				switch ((num2 = (uint)num ^ 0xAB13DDC6u) % 20u)
				{
				case 19u:
					num9 = u_0.f + u_0.s;
					num10 = j.smethod_23(u_0.s, 2);
					num = -1852589548;
					continue;
				case 18u:
					b2 = u_0.h[num9];
					num = (int)((num2 * 2076141129) ^ 0x4DD6BB0E);
					continue;
				case 16u:
					while (true)
					{
						switch (num3)
						{
						case 1:
							break;
						case 32:
							if (u_0.h[++num7] == u_0.h[++num8])
							{
								num3 = 25;
								goto case 25;
							}
							num3 = 19;
							goto case 19;
						case 25:
							if (u_0.h[++num7] == u_0.h[++num8])
							{
								num3 = 8;
								goto case 8;
							}
							num3 = 19;
							goto case 19;
						case 8:
							if (num7 >= num4)
							{
								num3 = 19;
								goto case 19;
							}
							num3 = 29;
							goto case 29;
						case 29:
							if (u_0.h[++num7] == u_0.h[++num8])
							{
								num3 = 4;
								goto case 4;
							}
							num3 = 19;
							goto case 19;
						case 4:
							if (u_0.h[++num7] == u_0.h[++num8])
							{
								num3 = 9;
								goto case 9;
							}
							num3 = 19;
							goto case 19;
						case 9:
							if (u_0.h[++num7] == u_0.h[++num8])
							{
								num3 = 7;
								goto case 7;
							}
							num3 = 19;
							goto case 19;
						case 7:
							if (u_0.h[++num7] == u_0.h[++num8])
							{
								num3 = 11;
								goto case 11;
							}
							num3 = array[32] - array[99];
							continue;
						case 11:
							if (u_0.h[++num7] == u_0.h[++num8])
							{
								num3 = array[16];
								continue;
							}
							num3 = 19;
							goto case 19;
						case 19:
							if (num7 > num9)
							{
								num3 = array2[47] - 30305;
								continue;
							}
							num3 = 14;
							goto case 14;
						case 14:
							num7 = u_0.f;
							num3 = 5;
							goto case 5;
						case 5:
							if ((int_0 = ((short[])obj)[int_0 & 0x7FFF] & 0xFFFF) > num12)
							{
								num3 = array2[51] - 14338;
								continue;
							}
							num3 = 30;
							goto case 30;
						case 28:
							if (u_0.h[++num7] == u_0.h[++num8])
							{
								num3 = 32;
								goto case 32;
							}
							num3 = 19;
							goto case 19;
						case 27:
							num6 >>= 2;
							num3 = array[99] - 31;
							continue;
						case 24:
							if (u_0.h[int_0 + num10 - 1] == b3)
							{
								num3 = 6;
								goto case 6;
							}
							num3 = 5;
							goto case 5;
						case 6:
							if (u_0.h[int_0] == u_0.h[num7])
							{
								num3 = 21;
								goto case 21;
							}
							num3 = 5;
							goto case 5;
						case 21:
							if (u_0.h[int_0 + 1] == u_0.h[num7 + 1])
							{
								num3 = 13;
								goto case 13;
							}
							num3 = 5;
							goto case 5;
						case 13:
							num8 = int_0 + 2;
							num7 += 2;
							num3 = array[125] - 16;
							continue;
						case 23:
							b3 = u_0.h[num9 - 1];
							b2 = u_0.h[num9];
							num3 = 14;
							goto case 14;
						case 22:
							num11 = u_0.o;
							num3 = 15;
							goto case 15;
						case 15:
							num3 = ((u_0.h[int_0 + num10] != b2) ? array[94] : array[161]);
							continue;
						case 16:
							if (num10 < num11)
							{
								num3 = 23;
								goto case 23;
							}
							num3 = array[281];
							continue;
						case 12:
							if (num11 > u_0.o)
							{
								num3 = (int)array[145] / 3;
								continue;
							}
							num3 = 15;
							goto case 15;
						case 3:
						case 10:
							u_0.h = int_0;
							num9 = num7;
							num10 = num7 - u_0.f;
							num3 = 16;
							goto case 16;
						case 2:
							if (--num6 != 0)
							{
								num3 = 15;
								goto case 15;
							}
							num3 = 30;
							goto case 30;
						default:
							goto IL_03bb;
						case 17:
							goto IL_03c5;
						case 18:
							goto IL_03e3;
						case 20:
							goto IL_0405;
						case 26:
							goto IL_041c;
						case 0:
						case 31:
							goto IL_043d;
						case 30:
							u_0.s = j.smethod_24(num10, u_0.o);
							return u_0.s >= 3;
						}
						break;
					}
					goto case 19u;
				case 3u:
					goto IL_03c5;
				case 5u:
					goto IL_03e3;
				case 4u:
					goto IL_0405;
				case 8u:
					goto IL_041c;
				case 6u:
					goto IL_043d;
				case 15u:
					num = (int)((num2 * 585184925) ^ 0x37EC9575);
					continue;
				case 14u:
					num3 = array[151];
					num = ((int)num2 * -1141474669) ^ 0x4BAAB910;
					continue;
				case 13u:
					num5 = 27;
					goto IL_0483;
				case 12u:
					num3 = 20;
					num = (int)(num2 * 1222408059) ^ -1777835631;
					continue;
				default:
					num5 = array[36] - 43;
					goto IL_0483;
				case 10u:
					num = (int)(num2 * 1007383563) ^ -1649682732;
					continue;
				case 9u:
					num4 = u_0.f + 258 - 1;
					num = ((int)num2 * -1324838432) ^ -97556030;
					continue;
				case 7u:
					num = ((int)num2 * -1137272364) ^ -1754317962;
					continue;
				case 2u:
					num3 = 26;
					num = (int)(num2 * 1815080895) ^ -480796677;
					continue;
				case 1u:
					num3 = 31;
					num = (int)(num2 * 150113356) ^ -1395529674;
					continue;
				case 0u:
					num = ((int)num2 * -995726994) ^ 0x7A40B93A;
					continue;
				case 17u:
					break;
					IL_0483:
					num3 = num5;
					num = -366847814;
					continue;
					IL_043d:
					num6 = 128;
					num11 = 128;
					num = -1887509409;
					continue;
					IL_041c:
					if (num10 >= 8)
					{
						num = -785403901;
						num13 = -785403901;
					}
					else
					{
						num = -265181459;
						num13 = -265181459;
					}
					continue;
					IL_0405:
					b3 = u_0.h[num9 - 1];
					num = -1743203560;
					continue;
					IL_03e3:
					obj = u_0.x;
					num7 = u_0.f;
					num3 = array[272];
					num = -329183284;
					continue;
					IL_03c5:
					num12 = j.smethod_23(u_0.f - 32506, 0);
					num = -1107004021;
					continue;
					IL_03bb:
					num = -764205132;
					continue;
				}
				break;
			}
		}
	}

	static bool m(bool bool_0, bool bool_1, v.u u_0)
	{
		byte[] array = h.d;
		int num = 5;
		bool flag = default(bool);
		while (true)
		{
			int num2 = -528111653;
			while (true)
			{
				int num3;
				int num4;
				switch ((uint)(num2 ^ -1797602996) % 6u)
				{
				case 5u:
					while (true)
					{
						int bool_2;
						switch (num)
						{
						case 4:
							bool_2 = 0;
							goto IL_000e;
						case 3:
							bool_2 = ((u_0.n == u_0.e) ? 1 : 0);
							goto IL_000e;
						case 0:
							if (flag)
							{
								num = 5;
								goto IL_0074;
							}
							num = 1;
							goto case 1;
						case 2:
						case 5:
							goto IL_0074;
						case 6:
						case 7:
							goto IL_0081;
						case 1:
							{
								return flag;
							}
							IL_000e:
							flag = j.c((byte)bool_2 != 0, bool_1, u_0);
							if (u_0.g.v != 0)
							{
								num = array[272];
								continue;
							}
							num = 0;
							goto case 0;
						}
						break;
					}
					num2 = -177799742;
					continue;
				case 4u:
					goto IL_0074;
				case 1u:
					goto IL_0081;
				default:
					num3 = 4;
					goto IL_009e;
				case 2u:
					num3 = array[151] - 14;
					goto IL_009e;
				case 0u:
					break;
					IL_009e:
					num = num3;
					num2 = -528111653;
					continue;
					IL_0081:
					if (bool_0)
					{
						num2 = -991120320;
						num4 = -991120320;
					}
					else
					{
						num2 = -702099745;
						num4 = -702099745;
					}
					continue;
					IL_0074:
					j.tl(u_0);
					num2 = -1319102699;
					continue;
				}
				break;
			}
		}
	}

	static bool c(bool bool_0, bool bool_1, v.u u_0)
	{
		char[] array = x.s;
		byte[] array2 = h.d;
		int num = 14;
		object obj3 = default(object);
		int int_3 = default(int);
		int num9 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int int_4 = default(int);
		object obj4 = default(object);
		object obj = default(object);
		object obj2 = default(object);
		int int_ = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num2 = 1662741337;
			while (true)
			{
				uint num3;
				int num4;
				switch ((num3 = (uint)num2 ^ 0x5EBF0072u) % 6u)
				{
				case 4u:
				{
					int num12;
					if (u_0.o >= 262)
					{
						num2 = 36491472;
						num12 = 36491472;
					}
					else
					{
						num2 = 629225616;
						num12 = 629225616;
					}
					continue;
				}
				case 3u:
					while (true)
					{
						int num5;
						switch (num)
						{
						case 14:
							break;
						case 44:
							obj3 = u_0.r;
							int_3 = u_0.h[u_0.f - 1] & 0xFF;
							num = array[118] - 34982;
							continue;
						case 43:
							num = 2;
							goto case 2;
						case 20:
							if (--num9 > 0)
							{
								num = 3;
								goto case 3;
							}
							num = array[532] - 65273;
							continue;
						case 3:
							u_0.f++;
							u_0.o--;
							goto case 43;
						case 2:
						case 13:
							if (u_0.o < 3)
							{
								num = 20;
								goto case 20;
							}
							num = array[46] - 53710;
							continue;
						case 42:
						{
							int num10 = u_0.f;
							int num11 = num7;
							x.s[594] = (char)((x.s[594] * x.s[471]) & 'Ý');
							if (num10 - num11 <= 32506)
							{
								num = 38;
								goto case 38;
							}
							num = 21;
							goto case 21;
						}
						case 38:
							num = ((!j.a(num7, u_0)) ? (array[358] - 43750) : (array[216] - 55547));
							continue;
						case 21:
							if (num9 >= 3)
							{
								num = 37;
								goto case 37;
							}
							num = array2[28];
							continue;
						case 37:
							num = ((u_0.s > num9) ? (array2[145] - 34) : ((int)array2[164] / 2));
							continue;
						case 41:
							if (u_0.o < 262)
							{
								num = 29;
								goto case 29;
							}
							num = 5;
							goto case 5;
						case 29:
							if (bool_0)
							{
								num = 5;
								goto case 5;
							}
							num = 17;
							goto case 17;
						case 5:
							if (u_0.o == 0)
							{
								num = 15;
								goto case 15;
							}
							num = array2[251] - 68;
							continue;
						case 15:
							if (u_0.a)
							{
								num = 44;
								goto case 44;
							}
							num = array[419] - 52330;
							continue;
						case 39:
							num7 = j.n(u_0);
							if (num7 != 0)
							{
								num = array2[158] + 11;
								continue;
							}
							num = 21;
							goto case 21;
						case 36:
							u_0.f++;
							u_0.o--;
							num = 30;
							goto case 30;
						case 30:
							u_0.a = false;
							u_0.s = 2;
							num = array[590] - 36324;
							continue;
						case 35:
							u_0.a = true;
							u_0.f++;
							u_0.o--;
							num = 23;
							goto case 23;
						case 23:
							if (u_0.r.l < 16384)
							{
								num = 41;
								goto case 41;
							}
							num = 28;
							goto case 28;
						case 34:
							j.x(int_3, (v.j)obj3);
							num = array2[27];
							continue;
						case 33:
							num8 = u_0.h;
							num9 = u_0.s;
							if (u_0.o >= 3)
							{
								num = 39;
								goto case 39;
							}
							num = array2[269] - 70;
							continue;
						case 32:
							if (u_0.a)
							{
								num = 1;
								goto case 1;
							}
							num = 35;
							goto case 35;
						case 1:
							obj3 = u_0.r;
							int_3 = u_0.h[u_0.f - 1] & 0xFF;
							num = array2[294] - 64;
							continue;
						case 31:
							goto IL_0303;
						case 27:
							j.h(num9, int_4, (v.j)obj4);
							num9 -= 2;
							num = array2[291] - 36;
							continue;
						case 25:
							if (u_0.f - u_0.h > 4096)
							{
								num = array2[159] - 35;
								continue;
							}
							num = 21;
							goto case 21;
						case 24:
							obj4 = u_0.r;
							int_4 = u_0.f - 1 - num8;
							num = 27;
							goto case 27;
						case 19:
							j.x(int_3, obj3 as v.j);
							num = 35;
							goto case 35;
						case 16:
							if (u_0.f >= 65274)
							{
								num = 6;
								goto case 6;
							}
							num = 33;
							goto case 33;
						case 6:
						case 10:
							j.c(u_0);
							goto case 33;
						case 12:
							u_0.s = 2;
							num = array[298] - 19247;
							continue;
						case 8:
							j.n(u_0);
							num = array[419] - 52321;
							continue;
						case 7:
							if (u_0.s <= 5)
							{
								num = array2[206] + 13;
								continue;
							}
							num = 21;
							goto case 21;
						case 0:
							if (!bool_0)
							{
								num = array[632] - 60575;
								continue;
							}
							num = 41;
							goto case 41;
						default:
							goto IL_0509;
						case 11:
							u_0.a = false;
							obj = u_0.r;
							obj2 = u_0.h;
							int_ = u_0.y;
							num = 9;
							goto case 9;
						case 9:
						{
							int int_2 = u_0.f - u_0.y;
							j.a(int_, bool_1, (v.j)obj, (byte[])obj2, int_2);
							num = 22;
							goto case 22;
						}
						case 22:
							u_0.y = u_0.f;
							return false;
						case 28:
							num6 = u_0.f - u_0.y;
							if (u_0.a)
							{
								num = 48;
								goto case 48;
							}
							num = 45;
							goto case 45;
						case 40:
							return false;
						case 17:
							return true;
						case 48:
							num6--;
							num = 45;
							goto case 45;
						case 45:
							if (bool_1)
							{
								num = 4;
								goto case 4;
							}
							num = 18;
							goto case 18;
						case 4:
							if (u_0.o == 0)
							{
								num = 46;
								goto case 46;
							}
							num = 18;
							goto case 18;
						case 46:
							num5 = ((!u_0.a) ? 1 : 0);
							goto IL_060e;
						case 18:
							num5 = 0;
							goto IL_060e;
						case 26:
							j.a(int_, flag, (v.j)obj, obj2 as byte[], num6);
							u_0.y += num6;
							num = 47;
							goto case 47;
						case 47:
							{
								return !flag;
							}
							IL_060e:
							flag = (byte)num5 != 0;
							obj = u_0.r;
							obj2 = u_0.h;
							int_ = u_0.y;
							num = 26;
							goto case 26;
						}
						break;
						IL_0303:
						num = ((u_0.s != 3) ? (array[350] - 60651) : (array[349] - 31322));
					}
					goto case 4u;
				case 2u:
					num4 = 0;
					goto IL_0511;
				case 1u:
					num2 = (int)((num3 * 1656055762) ^ 0x5F74EB43);
					continue;
				default:
					num4 = 41;
					goto IL_0511;
				case 5u:
					break;
					IL_0511:
					num = num4;
					num2 = 1018038519;
					continue;
					IL_0509:
					num2 = 255432604;
					continue;
				}
				break;
			}
		}
	}

	static int o(v.t t_0, v.e e_0)
	{
		char[] array = x.s;
		byte[] array2 = default(byte[]);
		int num7 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num9 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1067177824;
			while (true)
			{
				uint num2;
				int num10;
				switch ((num2 = (uint)num ^ 0x1F294AD6u) % 8u)
				{
				case 7u:
					num = ((int)num2 * -795959760) ^ 0x2EFC8A1F;
					continue;
				case 6u:
					array2 = h.d;
					num = ((int)num2 * -1735153785) ^ 0x7F50A844;
					continue;
				default:
					num10 = 16;
					goto IL_0037;
				case 4u:
				{
					int num11;
					if ((num6 = j.d(e_0, 9)) < 0)
					{
						num = 993720867;
						num11 = 993720867;
					}
					else
					{
						num = 1615931981;
						num11 = 1615931981;
					}
					continue;
				}
				case 3u:
					num10 = 0;
					goto IL_0037;
				case 1u:
					while (true)
					{
						switch (num3)
						{
						case 11:
							break;
						case 17:
							goto IL_006f;
						case 16:
							num7 = e_0.g;
							num6 = j.d(e_0, num7);
							num4 = t_0.k[num6];
							num3 = 10;
							goto case 8;
						case 8:
						case 10:
							num3 = ((num4 < 0) ? (array[54] - 45250) : ((int)array2[76] / 7));
							continue;
						case 13:
						{
							num5 = -(num4 >> 4);
							int int_ = num4 & 0xF;
							if ((num6 = j.d(e_0, int_)) >= 0)
							{
								num3 = array[503] - 16348;
								continue;
							}
							num3 = 7;
							goto case 7;
						}
						case 0:
							if ((num4 = t_0.k[num6]) < 0)
							{
								num3 = 13;
								goto case 13;
							}
							num3 = 14;
							goto case 14;
						default:
							goto IL_016f;
						case 2:
							return -1;
						case 6:
							num4 = t_0.k[num5 | (num6 >> 9)];
							j.p(e_0, num4 & 0xF);
							num3 = 3;
							goto case 3;
						case 3:
							return num4 >> 4;
						case 7:
							num9 = e_0.g;
							num6 = j.d(e_0, num9);
							num4 = t_0.k[num5 | (num6 >> 9)];
							num3 = 12;
							goto case 12;
						case 12:
							if ((num4 & 0xF) <= num9)
							{
								num3 = 4;
								goto case 4;
							}
							num3 = 9;
							goto case 5;
						case 4:
							j.p(e_0, num4 & 0xF);
							return num4 >> 4;
						case 5:
						case 9:
							return -1;
						case 14:
						{
							int num8 = num4;
							x.s[195] = (char)(x.s[195] & x.s[410] & '\f');
							j.p(e_0, num8 & 0xF);
							return num4 >> 4;
						}
						case 15:
							j.p(e_0, num4 & 0xF);
							goto case 1;
						case 1:
							return num4 >> 4;
						}
						break;
						IL_006f:
						num3 = (((num4 & 0xF) > num7) ? (array[178] - 53067) : (array2[243] - array2[269]));
					}
					goto case 4u;
				case 0u:
					num3 = 11;
					num = ((int)num2 * -94401947) ^ -1911119673;
					continue;
				case 2u:
					break;
					IL_016f:
					num = 1889971930;
					continue;
					IL_0037:
					num3 = num10;
					num = 1797047785;
					continue;
				}
				break;
			}
		}
	}

	static void b(v.u u_0, byte[] byte_0)
	{
		u_0.x = byte_0;
		u_0.n = 0;
		u_0.e = byte_0.Length;
	}

	static bool v(v.h h_0)
	{
		char[] array = x.s;
		byte[] array2 = h.d;
		int num = 7;
		int num5 = default(int);
		int num9 = default(int);
		while (true)
		{
			int num2 = -2092604478;
			while (true)
			{
				uint num3;
				int num4;
				switch ((num3 = (uint)num2 ^ 0xF1FFB0F7u) % 6u)
				{
				case 5u:
					num5 = h_0.n;
					num2 = -1674995852;
					continue;
				case 3u:
					while (true)
					{
						switch (num)
						{
						case 7:
							break;
						case 31:
							h_0.g = j.y(h_0.g);
							h_0.p = j.g(h_0.g);
							num = array[242] - 15819;
							continue;
						case 28:
							if (j.l(h_0.g, h_0.x))
							{
								num = array[302] - 40184;
								continue;
							}
							num = 17;
							goto case 17;
						case 26:
							j.p(h_0.x, 16);
							h_0.n = 4;
							num = 1;
							goto case 1;
						case 1:
						{
							int num8 = j.d(h_0.x, 16);
							if (num8 >= 0)
							{
								num = 3;
								goto case 3;
							}
							num = 19;
							goto case 19;
						}
						case 3:
							j.p(h_0.x, 16);
							h_0.n = 5;
							num = array2[4] - 37;
							continue;
						case 23:
							j.p(h_0.x, 3);
							if (((uint)num9 & (true ? 1u : 0u)) != 0)
							{
								num = array[583] - 20851;
								continue;
							}
							num = 22;
							goto case 22;
						case 21:
							if (h_0.b == 0)
							{
								num = array2[206];
								continue;
							}
							num = 2;
							goto case 2;
						case 15:
							if ((h_0.b = j.d(h_0.x, 16)) >= 0)
							{
								num = 26;
								goto case 26;
							}
							num = 24;
							goto case 24;
						case 14:
						{
							int num6 = j.n(h_0.k, h_0.x, h_0.b);
							h_0.b -= num6;
							byte num7 = array2[236];
							x.s[398] = (char)((x.s[398] + x.s[365]) & '·');
							num = num7 - 118;
							continue;
						}
						case 12:
							goto IL_0195;
						case 9:
							h_0.m = true;
							num = array[414] - 57094;
							continue;
						case 0:
							goto IL_01cb;
						default:
							goto IL_0283;
						case 8:
							h_0.n = 7;
							num = 30;
							goto case 30;
						case 11:
							return false;
						case 18:
							h_0.n = 2;
							return true;
						case 2:
							return !h_0.x.i;
						case 22:
							switch (num9 >> 1)
							{
							case 0:
								goto IL_03c3;
							case 1:
								goto IL_03c8;
							case 2:
								goto IL_03ec;
							}
							num = 5;
							goto case 5;
						case 5:
							num = 6;
							goto case 6;
						case 20:
							h_0.g = v.t.g;
							h_0.p = v.t.s;
							h_0.n = 7;
							num = 6;
							goto case 6;
						case 10:
							h_0.g = new v.b();
							h_0.n = 6;
							num = 6;
							goto case 6;
						case 24:
							return false;
						case 25:
							h_0.n = 12;
							return false;
						case 19:
							return false;
						case 17:
							return false;
						case 29:
							j.p(h_0.x);
							goto case 16;
						case 16:
							h_0.n = 3;
							num = 6;
							goto case 6;
						case 6:
						case 27:
							return true;
						case 30:
							return j.k(h_0);
						case 13:
						case 32:
							num = 4;
							goto case 4;
						case 4:
							return false;
						case 33:
							{
								return false;
							}
							IL_03ec:
							num = 10;
							goto case 10;
							IL_03c8:
							num = 20;
							goto case 20;
							IL_03c3:
							num = 29;
							goto case 29;
						}
						break;
						IL_01cb:
						num9 = j.d(h_0.x, 3);
						num = ((num9 >= 0) ? (array[555] - 19440) : (array2[4] - 18));
						continue;
						IL_0195:
						num = ((!h_0.m) ? array2[91] : (array[278] - 25457));
					}
					goto case 5u;
				default:
					num4 = 12;
					goto IL_028f;
				case 1u:
					switch (num5)
					{
					case 2:
						break;
					default:
						goto IL_02cf;
					case 3:
						goto IL_02de;
					case 4:
						goto IL_02ed;
					case 5:
						goto IL_02f0;
					case 6:
						goto IL_02ff;
					case 7:
						goto IL_0303;
					case 8:
						goto IL_0307;
					case 9:
						goto IL_0313;
					case 10:
						goto IL_031a;
					case 11:
						goto IL_0321;
					case 12:
						goto IL_0330;
					}
					goto default;
				case 0u:
					num4 = 13;
					goto IL_028f;
				case 4u:
					break;
					IL_0330:
					num4 = 11;
					goto IL_028f;
					IL_0321:
					num4 = array[121] - 38383;
					goto IL_028f;
					IL_031a:
					num4 = 30;
					goto IL_028f;
					IL_0313:
					num4 = 30;
					goto IL_028f;
					IL_0307:
					num4 = array2[281];
					goto IL_028f;
					IL_0303:
					num4 = 30;
					goto IL_028f;
					IL_02ff:
					num4 = 28;
					goto IL_028f;
					IL_02f0:
					num4 = array2[143] - 170;
					goto IL_028f;
					IL_02ed:
					num4 = 1;
					goto IL_028f;
					IL_02de:
					num4 = array[432] - 62715;
					goto IL_028f;
					IL_02cf:
					num2 = ((int)num3 * -375398264) ^ 0xE61270D;
					continue;
					IL_028f:
					num = num4;
					num2 = -2092604478;
					continue;
					IL_0283:
					num2 = -1459668490;
					continue;
				}
				break;
			}
		}
	}

	static void t(v.a a_0, int int_0)
	{
		j.i(int_0, a_0);
		j.i(int_0 >> 16, a_0);
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static bool k(v.h h_0)
	{
		byte[] array = h.d;
		char[] array2 = x.s;
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 988493232;
			while (true)
			{
				uint num2;
				int num8;
				switch ((num2 = (uint)num ^ 0x21918F61u) % 10u)
				{
				case 9u:
					num3 = 12;
					num = (int)(num2 * 898932261) ^ -1561785306;
					continue;
				case 8u:
					num3 = 8;
					num = ((int)num2 * -1522690798) ^ -586091292;
					continue;
				case 7u:
					num = ((int)num2 * -1305928682) ^ -237698659;
					continue;
				case 6u:
					num5 = j.i(h_0.k);
					num = 1789682617;
					continue;
				case 5u:
					goto IL_0063;
				default:
					goto IL_008e;
				case 4u:
					num8 = array[261];
					goto IL_00a7;
				case 1u:
					num = (int)((num2 * 1650222946) ^ 0x416E3E41);
					continue;
				case 0u:
					while (true)
					{
						switch (num3)
						{
						case 12:
							break;
						case 19:
							goto IL_0063;
						case 28:
							if (((num6 = j.o(h_0.g, h_0.x)) & -256) == 0)
							{
								num3 = 29;
								goto case 29;
							}
							num3 = 18;
							goto case 18;
						case 29:
							j.g(h_0.k, num6);
							if (--num5 >= 258)
							{
								num3 = 28;
								goto case 28;
							}
							num3 = array[27];
							continue;
						case 18:
							if (num6 < 257)
							{
								num3 = array2[62] - 54389;
								continue;
							}
							num3 = 26;
							goto case 26;
						case 26:
							h_0.o = v.h.a[num6 - 257];
							h_0.g = v.h.r[num6 - 257];
							num3 = 13;
							goto case 13;
						case 13:
							if (h_0.g > 0)
							{
								num3 = 21;
								goto case 21;
							}
							num3 = array2[128] - 25892;
							continue;
						case 21:
							h_0.n = 8;
							num7 = j.d(h_0.x, h_0.g);
							num3 = ((num7 >= 0) ? array[26] : array[276]);
							continue;
						case 27:
							num3 = 8;
							goto case 8;
						case 8:
							if (num5 >= 258)
							{
								num3 = array[32] - 43;
								continue;
							}
							num3 = 6;
							goto case 6;
						case 25:
							j.p(h_0.x, h_0.g);
							h_0.o += num7;
							num3 = array[91];
							continue;
						case 24:
							j.t(h_0.k, h_0.o, h_0.l);
							num5 -= h_0.o;
							num3 = array2[217] - 50437;
							continue;
						case 23:
							num6 = j.o(h_0.p, h_0.x);
							num3 = ((num6 >= 0) ? (array2[206] - 51004) : (array[272] + 1));
							continue;
						case 22:
							h_0.n = 7;
							num3 = 8;
							goto case 8;
						case 20:
							if (h_0.g > 0)
							{
								num3 = array2[261] - 43827;
								continue;
							}
							num3 = 24;
							goto case 24;
						case 7:
						case 16:
							if (num6 < 0)
							{
								num3 = array[182] - 67;
								continue;
							}
							num3 = 17;
							goto case 17;
						case 5:
						case 14:
							h_0.l = v.h.d[num6];
							h_0.g = v.h.c[num6];
							num3 = array2[131] - 24152;
							continue;
						case 10:
							h_0.n = 10;
							num4 = j.d(h_0.x, h_0.g);
							goto case 1;
						case 1:
							if (num4 >= 0)
							{
								num3 = 4;
								goto case 4;
							}
							num3 = 9;
							goto case 9;
						case 4:
							j.p(h_0.x, h_0.g);
							h_0.l += num4;
							num3 = array2[620] - 2455;
							continue;
						case 0:
							h_0.n = 9;
							num3 = 23;
							goto case 23;
						default:
							goto IL_03c0;
						case 2:
							return false;
						case 3:
							return false;
						case 9:
							x.s[501] = (char)((x.s[501] + x.s[73]) & 'Q');
							return false;
						case 11:
							return true;
						case 15:
							return false;
						case 17:
							h_0.p = null;
							h_0.g = null;
							h_0.n = 2;
							return true;
						case 6:
							return true;
						}
						break;
					}
					goto case 6u;
				case 2u:
					break;
					IL_03c0:
					num = 726483621;
					continue;
					IL_0063:
					switch (h_0.n)
					{
					case 7:
						goto IL_008e;
					case 8:
						goto IL_0092;
					case 9:
						goto IL_00a1;
					case 10:
						goto IL_00a5;
					}
					num = 716512653;
					continue;
					IL_00a5:
					num8 = 20;
					goto IL_00a7;
					IL_00a1:
					num8 = 23;
					goto IL_00a7;
					IL_0092:
					num8 = array2[381] - 219;
					goto IL_00a7;
					IL_008e:
					num8 = 28;
					goto IL_00a7;
					IL_00a7:
					num3 = num8;
					num = 1414545560;
					continue;
				}
				break;
			}
		}
	}

	static void a(int int_0, bool bool_0, v.j j_0, byte[] byte_0, int int_1)
	{
		byte[] array = h.d;
		int num6 = default(int);
		object obj2 = default(object);
		char[] array2 = default(char[]);
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int num5 = default(int);
		object obj = default(object);
		Array array3 = default(Array);
		int num3 = default(int);
		while (true)
		{
			int num = -1224316496;
			while (true)
			{
				uint num2;
				int num4;
				int num11;
				switch ((num2 = (uint)num ^ 0x9BBF1950u) % 17u)
				{
				case 16u:
					while (true)
					{
						switch (num3)
						{
						case 30:
							num6--;
							num3 = array[276];
							continue;
						case 29:
							j.f((byte[])array3, obj2 as v.j.m, (short[])obj);
							obj2 = j_0.w;
							num3 = array2[620] - 2458;
							continue;
						case 28:
							num7 = num8;
							num3 = array[7] - 214;
							continue;
						case 26:
							num8 += j_0.v.a[num9] * v.j.q[num9];
							num3 = 7;
							goto case 7;
						case 7:
							num9++;
							num3 = array[161];
							continue;
						case 2:
							num8 += j_0.w.a[num10] * v.j.p[num10];
							num3 = 23;
							goto case 23;
						case 23:
							num10++;
							num3 = 25;
							goto case 25;
						case 25:
							if (num10 < 30)
							{
								num3 = 2;
								goto case 2;
							}
							num3 = 11;
							goto case 11;
						case 11:
							if (num7 >= num8)
							{
								num3 = 28;
								goto case 28;
							}
							num3 = 22;
							goto case 22;
						case 22:
							if (int_0 >= 0)
							{
								num3 = 0;
								goto case 0;
							}
							num3 = 4;
							goto case 4;
						case 0:
							if (int_1 + 4 >= num7 >> 3)
							{
								num3 = 4;
								goto case 4;
							}
							num3 = 20;
							goto case 20;
						case 4:
							if (num7 == num8)
							{
								num3 = 16;
								goto case 16;
							}
							num3 = 9;
							goto case 9;
						case 16:
							j.o(j_0.y, 2 + (bool_0 ? 1 : 0), 3);
							obj2 = j_0.v;
							obj = v.j.j;
							array3 = v.j.q;
							num3 = 29;
							goto case 29;
						case 24:
							if (num9 >= 286)
							{
								num3 = 5;
								goto case 5;
							}
							num3 = 26;
							goto case 26;
						case 5:
							num10 = 0;
							num3 = 25;
							goto case 25;
						case 18:
							num7 = 14 + num5 * 3 + j.u(j_0.j) + j.u(j_0.v) + j.u(j_0.w) + j_0.b;
							num3 = 8;
							goto case 8;
						case 8:
							num8 = j_0.b;
							num9 = 0;
							num3 = 24;
							goto case 24;
						case 14:
							num5 = num6 + 1;
							num3 = 30;
							goto case 30;
						case 3:
							if (num6 <= num5)
							{
								num3 = 18;
								goto case 18;
							}
							num3 = array[151];
							continue;
						case 12:
							goto IL_0241;
						case 15:
							goto IL_0256;
						case 17:
							goto IL_0271;
						case 19:
							goto IL_02a3;
						case 27:
							goto IL_02dc;
						case 1:
						case 13:
						case 21:
							obj = v.j.c;
							array3 = v.j.p;
							j.f((byte[])array3, (v.j.m)obj2, (short[])obj);
							num3 = 10;
							goto case 10;
						case 10:
							j.t(j_0);
							j.tt(j_0);
							return;
						case 6:
							return;
						case 20:
							j.c(int_1, j_0, bool_0, int_0, byte_0);
							return;
						case 9:
							j.o(j_0.y, 4 + (bool_0 ? 1 : 0), 3);
							j.w(num5, j_0);
							j.t(j_0);
							j.tt(j_0);
							return;
						}
						break;
					}
					num = -1764196799;
					continue;
				case 12u:
					goto IL_0241;
				case 11u:
					goto IL_0256;
				case 6u:
					goto IL_0271;
				case 3u:
					goto IL_02a3;
				case 15u:
					goto IL_02dc;
				case 14u:
					num5 = 4;
					num = ((int)num2 * -1837757819) ^ 0x626FBF52;
					continue;
				case 13u:
					num = (int)(num2 * 1054570773) ^ -1251776166;
					continue;
				case 9u:
					num = (int)((num2 * 527680972) ^ 0x60367447);
					continue;
				case 8u:
					num4 = 14;
					goto IL_0341;
				default:
					num4 = 30;
					goto IL_0341;
				case 5u:
					num = (int)(num2 * 639357576) ^ -634198673;
					continue;
				case 4u:
					array2 = x.s;
					num3 = 27;
					num = (int)((num2 * 2052384527) ^ 0x6287E4DF);
					continue;
				case 2u:
					num = (int)((num2 * 1472985484) ^ 0x51811DE7);
					continue;
				case 1u:
					j.b(j_0.j);
					num = ((int)num2 * -686371743) ^ -1790045290;
					continue;
				case 0u:
					num3 = 12;
					num = (int)((num2 * 2056828500) ^ 0x49A611ED);
					continue;
				case 10u:
					break;
					IL_0341:
					num3 = num4;
					num = -1623613790;
					continue;
					IL_02dc:
					j_0.v.a[256]++;
					num3 = 19;
					num = -1502254582;
					continue;
					IL_02a3:
					j.b(j_0.v);
					j.b(j_0.w);
					j.q(j_0.v, j_0.j);
					num3 = array[80] - 91;
					num = -773032046;
					continue;
					IL_0271:
					if (j_0.j.y[v.j.y[num6]] <= 0)
					{
						num = -1692951426;
						num11 = -1692951426;
					}
					else
					{
						num = -2020713843;
						num11 = -2020713843;
					}
					continue;
					IL_0241:
					num6 = 18;
					num3 = array[276];
					num = -542090753;
					continue;
					IL_0256:
					j.q(j_0.w, j_0.j);
					num = -702381409;
					continue;
				}
				break;
			}
		}
	}

	static int c(v.e e_0, byte[] byte_0, int int_0, int int_1)
	{
		byte[] array = h.d;
		int num4 = default(int);
		char[] array2 = default(char[]);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 153336747;
			while (true)
			{
				uint num2;
				int num8;
				int num7;
				switch ((num2 = (uint)num ^ 0x9FCCC0Cu) % 16u)
				{
				case 15u:
					num4 = 0;
					num3 = 7;
					num = 695052846;
					continue;
				case 13u:
					goto IL_0019;
				default:
					num8 = 8;
					goto IL_003e;
				case 11u:
					num = (int)(num2 * 1077483587) ^ -1390002643;
					continue;
				case 10u:
					num8 = 6;
					goto IL_003e;
				case 9u:
					num = (int)(num2 * 1865644870) ^ -1994552198;
					continue;
				case 8u:
					goto IL_0070;
				case 7u:
					array2 = x.s;
					num3 = 15;
					num = ((int)num2 * -76751094) ^ -1642214390;
					continue;
				case 6u:
					goto IL_00b2;
				case 5u:
					num4++;
					num = ((int)num2 * -1791440751) ^ -816610918;
					continue;
				case 4u:
					goto IL_00e0;
				case 3u:
					num3 = 7;
					num = (int)((num2 * 916555288) ^ 0x7394DA8F);
					continue;
				case 2u:
					num = ((int)num2 * -845427424) ^ -419489844;
					continue;
				case 1u:
					goto IL_0117;
				case 0u:
					while (true)
					{
						switch (num3)
						{
						case 2:
						case 15:
							break;
						case 4:
							goto IL_0019;
						case 16:
							goto IL_0070;
						case 14:
							goto IL_00b2;
						case 13:
							goto IL_00e0;
						case 7:
							goto IL_0117;
						case 17:
							if (((uint)(e_0.x - e_0.a) & (true ? 1u : 0u)) != 0)
							{
								num3 = 11;
								goto case 11;
							}
							num3 = array2[624] - 30102;
							continue;
						case 11:
							e_0.k = e_0.m[e_0.x++] & 0xFFu;
							num3 = 9;
							goto case 9;
						case 9:
							e_0.g = 8;
							num3 = array[287] - array[55];
							continue;
						case 12:
							j.smethod_5((Array)e_0.m, e_0.x, (Array)byte_0, int_0, int_1);
							goto case 0;
						case 0:
							e_0.x += int_1;
							num3 = array[151];
							continue;
						case 8:
							goto IL_01d5;
						case 6:
							goto IL_01f3;
						case 3:
							int_1 = num5;
							num3 = array2[589] - 60477;
							continue;
						case 1:
						{
							num5 = e_0.a - e_0.x;
							if (int_1 > num5)
							{
								num3 = 3;
								goto case 3;
							}
							char num6 = array2[629];
							h.d[162] = (byte)((h.d[162] * x.s[133]) & 0xC9);
							num3 = num6 - 31765;
							continue;
						}
						default:
							goto IL_02cd;
						case 5:
							return num4;
						case 10:
							return num4 + int_1;
						}
						break;
						IL_01f3:
						num3 = ((int_1 > 0) ? (array2[515] - 38802) : (array2[510] - 15102));
						continue;
						IL_01d5:
						num3 = ((int_1 != 0) ? (array2[86] - 16362) : array[94]);
					}
					goto case 15u;
				case 14u:
					break;
					IL_02cd:
					num = 889472563;
					continue;
					IL_0117:
					if (e_0.g > 0)
					{
						num = 870899142;
						num7 = 870899142;
					}
					else
					{
						num = 1917813712;
						num7 = 1917813712;
					}
					continue;
					IL_0019:
					e_0.g -= 8;
					num3 = array[4] - array[160];
					num = 2004150668;
					continue;
					IL_00e0:
					int_1--;
					num = 1728147801;
					continue;
					IL_00b2:
					e_0.k >>= 8;
					num = 1919361281;
					continue;
					IL_0070:
					byte_0[int_0++] = (byte)e_0.k;
					num3 = array[274] - 120;
					num = 2004150668;
					continue;
					IL_003e:
					num3 = num8;
					num = 1776948933;
					continue;
				}
				break;
			}
		}
	}

	static byte[] s(byte[] byte_0)
	{
		return j.d(1, (byte[])null, (byte[])null, byte_0);
	}

	static int d(v.e e_0, int int_0)
	{
		byte[] array = h.d;
		int num = 4;
		while (true)
		{
			int num2 = -537093957;
			while (true)
			{
				int num3;
				int num7;
				switch ((uint)(num2 ^ -1683044161) % 5u)
				{
				case 4u:
					while (true)
					{
						switch (num)
						{
						case 5:
						case 8:
							e_0.g += 16;
							num = (int)array[206] / 9;
							continue;
						case 6:
						case 7:
							if (e_0.x != e_0.a)
							{
								num = 1;
								goto case 1;
							}
							num = 0;
							goto case 0;
						case 1:
						case 3:
						{
							uint num4 = e_0.k;
							int num5 = e_0.m[e_0.x++] & 0xFF;
							int num6 = e_0.m[e_0.x++] & 0xFF;
							h.d[98] = (byte)((h.d[98] * int_0) & 0x61);
							e_0.k = num4 | (uint)((num5 | (num6 << 8)) << e_0.g);
							num = 8;
							goto case 5;
						}
						case 4:
							goto IL_00e4;
						case 2:
							return (int)(e_0.k & ((1 << int_0) - 1));
						case 0:
							return -1;
						}
						break;
					}
					num2 = -1794896009;
					continue;
				case 3u:
					goto IL_00e4;
				case 2u:
					num3 = 6;
					goto IL_0107;
				default:
					num3 = 2;
					goto IL_0107;
				case 0u:
					break;
					IL_0107:
					num = num3;
					num2 = -537093957;
					continue;
					IL_00e4:
					if (e_0.g < int_0)
					{
						num2 = -1000160652;
						num7 = -1000160652;
					}
					else
					{
						num2 = -752851617;
						num7 = -752851617;
					}
					continue;
				}
				break;
			}
		}
	}

	static void e(v.j.m m_0, v.j.m m_1)
	{
		byte[] array = h.d;
		char[] array2 = default(char[]);
		int num6 = default(int);
		int num11 = default(int);
		int num3 = default(int);
		int num9 = default(int);
		int num12 = default(int);
		int num10 = default(int);
		int num7 = default(int);
		while (true)
		{
			int num = 420144893;
			while (true)
			{
				uint num2;
				int num8;
				switch ((num2 = (uint)num ^ 0x25D22BCAu) % 12u)
				{
				case 11u:
					array2 = x.s;
					num7 = 9;
					num = (int)((num2 * 476406253) ^ 0x6657DCD9);
					continue;
				case 9u:
					num6 = 0;
					num = (int)(num2 * 1515328269) ^ -1009233455;
					continue;
				case 8u:
					num = (int)((num2 * 1601862765) ^ 0x74B2C74E);
					continue;
				case 7u:
					num11 = 1;
					num = 1431951904;
					continue;
				case 6u:
					num3 = m_1.y[num6];
					num = ((int)num2 * -1159149483) ^ -1906687367;
					continue;
				default:
					num8 = array[220] - 196;
					goto IL_0083;
				case 4u:
					while (true)
					{
						switch (num7)
						{
						case 11:
							break;
						case 22:
							if (num11-- <= 0)
							{
								num7 = 0;
								goto case 0;
							}
							num7 = array2[158] - 22491;
							continue;
						case 0:
							num7 = 14;
							goto case 14;
						case 14:
							if (num6 < m_1.j)
							{
								num7 = array[234] - 127;
								continue;
							}
							num7 = 3;
							return;
						case 21:
							num6++;
							if (++num11 < num9)
							{
								num7 = 6;
								goto case 6;
							}
							num7 = 10;
							goto case 10;
						case 6:
							if (num6 < m_1.j)
							{
								num7 = 13;
								goto case 13;
							}
							num7 = 10;
							goto case 10;
						case 13:
							if (num12 != m_1.y[num6])
							{
								num7 = 10;
								goto case 10;
							}
							num7 = array[203] - 151;
							continue;
						case 10:
							if (num11 < num10)
							{
								num7 = 17;
								goto case 17;
							}
							num7 = array[206];
							continue;
						case 17:
							num7 = 22;
							goto case 22;
						case 20:
							j.v(m_0, num12);
							goto case 22;
						case 19:
							num7 = 5;
							goto case 5;
						case 5:
							num12 = num3;
							num6++;
							num7 = 6;
							goto case 6;
						case 18:
							goto IL_015e;
						case 16:
							if (num11 <= 10)
							{
								num7 = array2[335] - 35663;
								continue;
							}
							num7 = 8;
							goto case 8;
						case 8:
							j.v(m_0, 18);
							j.o(m_1.v.y, num11 - 11, 7);
							goto case 14;
						case 15:
							num9 = 6;
							num10 = 3;
							goto case 12;
						case 12:
							if (num12 != num3)
							{
								num7 = 7;
								goto case 7;
							}
							num7 = array2[629] - 31772;
							continue;
						case 7:
							j.v(m_0, num3);
							num11 = 0;
							num7 = array2[474] - 3859;
							continue;
						case 4:
							j.v(m_0, 17);
							j.o(m_1.v.y, num11 - 3, 3);
							num7 = array2[611] - 26025;
							continue;
						case 2:
							j.v(m_0, 16);
							j.o(m_1.v.y, num11 - 3, 2);
							num7 = (int)array[23] / 7;
							continue;
						case 1:
							num9 = 138;
							num10 = 3;
							goto case 19;
						default:
							goto IL_02d3;
						case 9:
							goto IL_02da;
						case 23:
							goto IL_02e4;
						case 3:
							return;
						}
						break;
						IL_015e:
						num7 = ((num12 == 0) ? (array[157] - array[25]) : (array2[597] - 31835));
					}
					goto case 7u;
				case 0u:
					goto IL_02da;
				case 2u:
					goto IL_02e4;
				case 3u:
					num8 = 1;
					goto IL_0083;
				case 1u:
				{
					int num4;
					int num5;
					if (num3 != 0)
					{
						num4 = -23748726;
						num5 = -23748726;
					}
					else
					{
						num4 = -223873280;
						num5 = -223873280;
					}
					num = num4 ^ ((int)num2 * -1129793811);
					continue;
				}
				case 10u:
					break;
					IL_02e4:
					num7 = array[231] - 200;
					num = 1358979622;
					continue;
					IL_02da:
					num12 = -1;
					num = 1571531219;
					continue;
					IL_02d3:
					num = 327859994;
					continue;
					IL_0083:
					num7 = num8;
					num = 326962738;
					continue;
				}
				break;
			}
		}
	}

	static bool q(v.j j_0)
	{
		return j_0.l >= 16384;
	}

	static void c(int int_0, v.j j_0, bool bool_0, int int_1, byte[] byte_0)
	{
		char[] array = x.s;
		int num3 = default(int);
		while (true)
		{
			int num = -1901350295;
			while (true)
			{
				uint num2;
				v.w w_;
				switch ((num2 = (uint)num ^ 0x86C479D7u) % 10u)
				{
				case 9u:
					j.k(j_0.y, ~int_0);
					num3 = array[98] - 8173;
					num = -1340487651;
					continue;
				case 8u:
					switch (num3)
					{
					case 2:
						break;
					default:
						goto IL_0047;
					case 3:
						goto IL_0051;
					case 1:
					case 4:
						goto IL_0093;
					case 0:
						goto IL_013d;
					}
					goto case 9u;
				case 0u:
					goto IL_0051;
				case 5u:
					goto IL_0093;
				case 7u:
					j.e(j_0.y);
					num = (int)(num2 * 1187848040) ^ -745989260;
					continue;
				case 4u:
					num = ((int)num2 * -915425356) ^ 0x15AE39F7;
					continue;
				case 2u:
					num3 = 3;
					num = ((int)num2 * -943109704) ^ 0x3081CF6F;
					continue;
				case 1u:
					j.k(j_0.y, int_0);
					num = (int)((num2 * 282824975) ^ 0x2A0133EF);
					continue;
				case 6u:
					break;
				default:
					goto IL_013d;
					IL_013d:
					j.tt(j_0);
					return;
					IL_0093:
					j.r(int_1, byte_0, int_0, j_0.y);
					num = -43408498;
					continue;
					IL_0051:
					w_ = j_0.y;
					x.s[214] = (char)((x.s[214] | h.d[132]) & '\u0080');
					j.o(w_, bool_0 ? 1 : 0, 3);
					num = -1034925926;
					continue;
					IL_0047:
					num = -1294610349;
					continue;
				}
				break;
			}
		}
	}

	static byte[] a(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return j.d(2, byte_2, byte_0, byte_1);
	}

	static bool y(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] array = h.d;
		char[] array3 = default(char[]);
		Array array2 = default(Array);
		Array array4 = default(Array);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -61227046;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xB565964Cu) % 8u)
				{
				case 7u:
					num4 = 2;
					num = ((int)num2 * -623459761) ^ 0x6B1795F9;
					continue;
				case 6u:
					array3 = x.s;
					num = (int)(num2 * 2046424479) ^ -113620079;
					continue;
				case 5u:
				{
					array2 = j.smethod_51(j.smethod_50(assembly_1));
					int num6;
					int num7;
					if ((byte[])array2 == null == !(array4 is byte[]))
					{
						num6 = -1130299929;
						num7 = -1130299929;
					}
					else
					{
						num6 = -528148156;
						num7 = -528148156;
					}
					num = num6 ^ ((int)num2 * -873709094);
					continue;
				}
				case 4u:
					while (true)
					{
						switch (num4)
						{
						case 3:
						case 7:
						case 11:
							num4 = ((((byte[])array2)[num5] == (array4 as byte[])[num5]) ? (array3[51] - 14334) : (array3[503] - array3[503]));
							continue;
						case 4:
						case 10:
							num5 = 0;
							num4 = 5;
							goto case 5;
						case 5:
							if (num5 < ((byte[])array2).Length)
							{
								num4 = 7;
								goto case 3;
							}
							num4 = 8;
							goto case 8;
						case 6:
							num5++;
							num4 = 5;
							goto case 5;
						case 1:
							if (array2 is byte[])
							{
								num4 = 4;
								goto case 4;
							}
							num4 = array3[542] - 29469;
							continue;
						case 2:
							goto IL_0135;
						case 0:
							return false;
						case 9:
							return false;
						case 8:
							return true;
						}
						break;
					}
					num = -1543719185;
					continue;
				case 3u:
					goto IL_0135;
				case 2u:
					num3 = 9;
					goto IL_014a;
				default:
					num3 = array[272];
					goto IL_014a;
				case 0u:
					break;
					IL_014a:
					num4 = num3;
					num = -1432813888;
					continue;
					IL_0135:
					array4 = j.smethod_51(j.smethod_50(assembly_0));
					num = -573111095;
					continue;
				}
				break;
			}
		}
	}

	static int c(v.j j_0, int int_0)
	{
		byte[] array = h.d;
		char[] array2 = default(char[]);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1392757018;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x3F4B7950u) % 7u)
				{
				case 5u:
					num = (int)(num2 * 78100428) ^ -1658749699;
					continue;
				default:
				{
					char num7 = array2[244];
					x.s[199] = (char)((x.s[199] * int_0) & '\u0087');
					num5 = num7 - 41186;
					goto IL_0048;
				}
				case 3u:
				{
					int num6;
					if (int_0 == 255)
					{
						num = 2016796900;
						num6 = 2016796900;
					}
					else
					{
						num = 1666291121;
						num6 = 1666291121;
					}
					continue;
				}
				case 2u:
					num5 = array[272] * 2;
					goto IL_0048;
				case 1u:
					array2 = x.s;
					num3 = 6;
					num = (int)(num2 * 2022253234) ^ -1383012255;
					continue;
				case 0u:
					while (true)
					{
						switch (num3)
						{
						case 3:
						case 6:
							break;
						case 8:
							num3 = ((int_0 >= 8) ? array[272] : array[91]);
							continue;
						case 4:
						case 5:
							num4 = 257;
							num3 = array[143] - 176;
							continue;
						case 1:
							num4 += 4;
							int_0 >>= 1;
							num3 = 8;
							goto case 8;
						default:
							goto IL_0100;
						case 0:
							return num4 + int_0;
						case 2:
						case 7:
							return 285;
						}
						break;
					}
					goto case 3u;
				case 6u:
					break;
					IL_0100:
					num = 360403008;
					continue;
					IL_0048:
					num3 = num5;
					num = 371516110;
					continue;
				}
				break;
			}
		}
	}

	static byte[] j(byte[] byte_0)
	{
		byte[] array = h.d;
		object obj = j.x(m.m);
		Array array2;
		try
		{
			object obj2 = j.smethod_52((SymmetricAlgorithm)obj);
			try
			{
				object obj3 = j.smethod_53();
				try
				{
					array2 = j.w((MemoryStream)obj3, byte_0, obj2 as ICryptoTransform);
				}
				finally
				{
					while (true)
					{
						IL_00db:
						int num = 1;
						int num2 = -1095867740;
						while (true)
						{
							uint num3;
							int num4;
							switch ((num3 = (uint)num2 ^ 0xBC6261B2u) % 7u)
							{
							case 6u:
							{
								int num5;
								if ((MemoryStream)obj3 != null)
								{
									num2 = -355523832;
									num5 = -355523832;
								}
								else
								{
									num2 = -50691851;
									num5 = -50691851;
								}
								continue;
							}
							case 5u:
								num2 = -1868948457;
								continue;
							case 4u:
								num2 = ((int)num3 * -1846593425) ^ -1833454536;
								continue;
							case 3u:
								switch (num)
								{
								case 0:
								case 1:
								case 5:
									break;
								default:
									num2 = -755375218;
									continue;
								case 4:
									j.smethod_4((IDisposable)(MemoryStream)obj3);
									goto end_IL_00ad;
								case 2:
								case 3:
									goto end_IL_00ad;
								}
								goto case 6u;
							default:
								num4 = 3;
								goto IL_00a1;
							case 0u:
								num4 = 4;
								goto IL_00a1;
							case 1u:
								break;
								IL_00a1:
								num = num4;
								num2 = -817600362;
								continue;
							}
							goto IL_00db;
							continue;
							end_IL_00ad:
							break;
						}
						break;
					}
				}
			}
			finally
			{
				while (true)
				{
					IL_0191:
					int num6 = 2;
					int num7 = -97568653;
					while (true)
					{
						uint num3;
						int num9;
						switch ((num3 = (uint)num7 ^ 0xBC6261B2u) % 7u)
						{
						case 6u:
							num9 = 3;
							goto IL_00f8;
						default:
							num9 = 4;
							goto IL_00f8;
						case 4u:
							num7 = ((int)num3 * -2074792139) ^ 0x377A2B11;
							continue;
						case 3u:
							switch (num6)
							{
							default:
								num7 = -571701378;
								continue;
							case 2:
								break;
							case 0:
							case 3:
								j.smethod_4((IDisposable)(obj2 as ICryptoTransform));
								goto end_IL_0160;
							case 1:
							case 4:
							case 5:
								goto end_IL_0160;
							}
							goto case 0u;
						case 0u:
						{
							int num8;
							if (obj2 is ICryptoTransform)
							{
								num7 = -914299370;
								num8 = -914299370;
							}
							else
							{
								num7 = -829405258;
								num8 = -829405258;
							}
							continue;
						}
						case 2u:
							num7 = -234232128;
							continue;
						case 1u:
							break;
							IL_00f8:
							num6 = num9;
							num7 = -1481356888;
							continue;
						}
						goto IL_0191;
						continue;
						end_IL_0160:
						break;
					}
					break;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_023e:
				int num10 = 5;
				int num11 = -1696597503;
				while (true)
				{
					uint num3;
					byte num12;
					switch ((num3 = (uint)num11 ^ 0xBC6261B2u) % 6u)
					{
					case 5u:
					{
						int num13;
						if (!(obj is SymmetricAlgorithm))
						{
							num11 = -320699180;
							num13 = -320699180;
						}
						else
						{
							num11 = -1662066604;
							num13 = -1662066604;
						}
						continue;
					}
					case 4u:
						num11 = -145692903;
						continue;
					case 3u:
						switch (num10)
						{
						case 0:
						case 1:
						case 5:
							break;
						default:
							num11 = -1286272143;
							continue;
						case 2:
						case 3:
							j.smethod_4((IDisposable)(SymmetricAlgorithm)obj);
							goto end_IL_0214;
						case 4:
							goto end_IL_0214;
						}
						goto case 5u;
					default:
						num12 = array[233];
						goto IL_0202;
					case 0u:
						num12 = array[276];
						goto IL_0202;
					case 1u:
						break;
						IL_0202:
						num10 = num12;
						num11 = -1696597503;
						continue;
					}
					goto IL_023e;
					continue;
					end_IL_0214:
					break;
				}
				break;
			}
		}
		return (byte[])array2;
	}

	static int r(byte[] byte_0, v.n n_0)
	{
		byte[] array = h.d;
		char[] array2 = x.s;
		int num = 5;
		int num8 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		object obj = default(object);
		bool bool_ = default(bool);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = 41581578;
			while (true)
			{
				uint num3;
				int num10;
				int num9;
				switch ((num3 = (uint)num2 ^ 0x3C45809Fu) % 14u)
				{
				case 13u:
					n_0.x += num8;
					num2 = 1707094857;
					continue;
				case 12u:
					num6 = byte_0.Length;
					num2 = (int)((num3 * 127015633) ^ 0x7B111289);
					continue;
				case 11u:
					num7 += num8;
					num = array[91];
					num2 = (int)((num3 * 535867843) ^ 0x2462979);
					continue;
				case 10u:
					num2 = ((int)num3 * -1745096927) ^ -1909416564;
					continue;
				case 9u:
					num10 = array[211] - 196;
					goto IL_0081;
				default:
					num10 = array2[178] - 53056;
					goto IL_0081;
				case 6u:
					goto IL_009b;
				case 5u:
					goto IL_00b7;
				case 4u:
					goto IL_00d7;
				case 3u:
					num = 12;
					num2 = ((int)num3 * -1087167250) ^ 0x1EA1A5F4;
					continue;
				case 2u:
					goto IL_0100;
				case 1u:
					while (true)
					{
						switch (num)
						{
						case 0:
							break;
						case 12:
							goto IL_009b;
						case 14:
							goto IL_00b7;
						case 7:
							goto IL_00d7;
						case 5:
							goto IL_0100;
						case 19:
							if (n_0.o == 28)
							{
								num = 9;
								goto case 9;
							}
							num = 12;
							goto IL_009b;
						case 9:
							j.e(n_0.w);
							n_0.o = 30;
							num = array[7] - 224;
							continue;
						case 18:
							obj = n_0.a;
							bool_ = (n_0.o & 4) != 0;
							num = 3;
							goto case 3;
						case 3:
						case 17:
						{
							bool bool_2 = (n_0.o & 8) != 0;
							if (!j.m(bool_, bool_2, (v.u)obj))
							{
								num = array[110] - 112;
								continue;
							}
							num = 12;
							goto IL_009b;
						}
						case 15:
							if (n_0.o != 30)
							{
								num = 18;
								goto case 18;
							}
							num = 13;
							goto case 13;
						case 10:
							if (n_0.o != 16)
							{
								num = 2;
								goto case 2;
							}
							num = 11;
							goto case 11;
						case 2:
							if (n_0.o == 20)
							{
								num = array[58] - 156;
								continue;
							}
							num = 19;
							goto case 19;
						case 8:
							j.o(n_0.w, 2, 10);
							num4 -= 10;
							num = array[294] - 77;
							continue;
						case 6:
							if (num4 <= 0)
							{
								num = 1;
								goto case 1;
							}
							num = array[186] - 208;
							continue;
						case 1:
							n_0.o = 16;
							num = array2[300] - 1954;
							continue;
						case 4:
							num4 = 8 + (-n_0.w.h & 7);
							num = 6;
							goto case 6;
						default:
							goto IL_028a;
						case 16:
							goto IL_0291;
						case 11:
							return num5 - num6;
						case 13:
							return num5 - num6;
						}
						break;
					}
					goto case 13u;
				case 0u:
					goto IL_0291;
				case 7u:
					break;
					IL_0291:
					num5 = num6;
					num2 = 278418214;
					continue;
					IL_028a:
					num2 = 371142971;
					continue;
					IL_0100:
					num7 = 0;
					num2 = 461325587;
					continue;
					IL_00d7:
					num6 -= num8;
					num = 14;
					num2 = 41581578;
					continue;
					IL_00b7:
					if (num6 != 0)
					{
						num2 = 831050086;
						num9 = 831050086;
					}
					else
					{
						num2 = 1308616243;
						num9 = 1308616243;
					}
					continue;
					IL_009b:
					num8 = j.x(n_0.w, byte_0, num7, num6);
					num2 = 726458894;
					continue;
					IL_0081:
					num = num10;
					num2 = 2134748761;
					continue;
				}
				break;
			}
		}
	}

	static void u(Rijndael rijndael_0, Rfc2898DeriveBytes rfc2898DeriveBytes_0)
	{
		j.smethod_54((SymmetricAlgorithm)rijndael_0, PaddingMode.PKCS7);
		j.smethod_56((SymmetricAlgorithm)rijndael_0, j.smethod_55((DeriveBytes)rfc2898DeriveBytes_0, 32));
		j.smethod_57((SymmetricAlgorithm)rijndael_0, j.smethod_55((DeriveBytes)rfc2898DeriveBytes_0, 16));
		while (true)
		{
			int num = 1527216039;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F122FCu) % 3u)
				{
				case 2u:
					goto IL_0025;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0025:
				x.s[347] = (char)((x.s[347] * x.s[101]) & '¤');
				num = ((int)num2 * -246611755) ^ 0x108BF022;
			}
		}
	}

	static byte[] q(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return j.d(3, byte_0, byte_2, byte_1);
	}

	static void h(v.u u_0)
	{
		u_0.v = (u_0.h[u_0.f] << 5) ^ u_0.h[u_0.f + 1];
	}

	static int x(v.w w_0, byte[] byte_0, int int_0, int int_1)
	{
		byte[] array = h.d;
		char[] array2 = default(char[]);
		int num4 = default(int);
		while (true)
		{
			int num = -2004386428;
			while (true)
			{
				uint num2;
				int num3;
				int num5;
				switch ((num2 = (uint)num ^ 0x81548E85u) % 7u)
				{
				case 6u:
					num = (int)((num2 * 1729449421) ^ 0x18563172);
					continue;
				case 5u:
					while (true)
					{
						switch (num4)
						{
						case 10:
							w_0.h[w_0.v++] = (byte)w_0.y;
							num4 = array2[93] - 23426;
							continue;
						case 8:
							j.smethod_5((Array)w_0.h, w_0.q, (Array)byte_0, int_0, int_1);
							goto case 2;
						case 2:
							w_0.q += int_1;
							num4 = array[101] + 0;
							continue;
						case 6:
							int_1 = w_0.v - w_0.q;
							j.smethod_5((Array)w_0.h, w_0.q, (Array)byte_0, int_0, int_1);
							num4 = 1;
							goto case 1;
						case 1:
							w_0.q = 0;
							w_0.v = 0;
							goto case 5;
						case 5:
							num4 = array2[88] - 54963;
							continue;
						case 0:
						case 4:
							if (int_1 > w_0.v - w_0.q)
							{
								num4 = array[276] * 2;
								continue;
							}
							num4 = 8;
							goto case 8;
						case 3:
							w_0.y >>= 8;
							w_0.h -= 8;
							num4 = 0;
							goto case 0;
						case 9:
							goto IL_013a;
						case 7:
							return int_1;
						}
						break;
					}
					num = -913321915;
					continue;
				case 0u:
					goto IL_013a;
				case 4u:
					array2 = x.s;
					num4 = 9;
					num = (int)((num2 * 1886621636) ^ 0x42EE901);
					continue;
				default:
					num3 = 0;
					goto IL_0175;
				case 1u:
					num3 = array[138] - 45;
					goto IL_0175;
				case 2u:
					break;
					IL_0175:
					num4 = num3;
					num = -1786151658;
					continue;
					IL_013a:
					if (w_0.h < 8)
					{
						num = -156913461;
						num5 = -156913461;
					}
					else
					{
						num = -275151562;
						num5 = -275151562;
					}
					continue;
				}
				break;
			}
		}
	}

	static void o(v.w w_0, int int_0, int int_1)
	{
		char[] array = x.s;
		byte[] array2 = default(byte[]);
		int num4 = default(int);
		while (true)
		{
			int num = -1892534469;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x86E74022u) % 11u)
				{
				case 10u:
					num4 = array[57] - 63942;
					num = -538664645;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (w_0.h < 16)
					{
						num5 = 374960881;
						num6 = 374960881;
					}
					else
					{
						num5 = 619386765;
						num6 = 619386765;
					}
					num = num5 ^ (int)(num2 * 292347743);
					continue;
				}
				case 8u:
					num3 = array[259] - 23135;
					goto IL_005b;
				case 7u:
					while (true)
					{
						switch (num4)
						{
						case 2:
							break;
						case 1:
							w_0.h[w_0.v++] = (byte)w_0.y;
							num4 = array2[138] - array2[159];
							continue;
						default:
							goto IL_00c1;
						case 0:
							goto IL_00c8;
						case 3:
						case 6:
							goto IL_00e7;
						case 8:
							w_0.h[w_0.v++] = (byte)(w_0.y >> 8);
							num4 = 4;
							goto case 4;
						case 4:
							w_0.y >>= 16;
							goto case 7;
						case 7:
							w_0.h -= 16;
							num4 = 5;
							return;
						case 5:
							return;
						}
						break;
					}
					goto case 10u;
				case 5u:
					goto IL_00c8;
				case 0u:
					goto IL_00e7;
				case 6u:
					num = (int)(num2 * 91083335) ^ -1774396880;
					continue;
				case 4u:
					num4 = 0;
					num = (int)((num2 * 1645326656) ^ 0x179C699F);
					continue;
				default:
					num3 = 5;
					goto IL_005b;
				case 1u:
					array2 = h.d;
					num = (int)((num2 * 1948498975) ^ 0x13E1FA98);
					continue;
				case 3u:
					break;
					IL_00e7:
					w_0.h += int_1;
					num = -1063238703;
					continue;
					IL_00c8:
					w_0.y |= (uint)(int_0 << w_0.h);
					num = -1227286941;
					continue;
					IL_00c1:
					num = -1602852968;
					continue;
					IL_005b:
					num4 = num3;
					num = -1520290337;
					continue;
				}
				break;
			}
		}
	}

	static void u(v.x x_0, int int_0, int int_1, int int_2)
	{
		byte[] array = h.d;
		int num3 = default(int);
		while (true)
		{
			int num = 1827885967;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x7E63C539u) % 14u)
				{
				case 6u:
				case 12u:
				{
					int num6;
					if (int_1-- <= 0)
					{
						num = 970925112;
						num6 = 970925112;
					}
					else
					{
						num = 2008996811;
						num6 = 2008996811;
					}
					continue;
				}
				case 11u:
					num5 = array[138] - 53;
					goto IL_003c;
				case 10u:
					num3 = 7;
					num = ((int)num2 * -64437809) ^ -982542023;
					continue;
				case 9u:
					goto IL_005b;
				default:
					num5 = 6;
					goto IL_003c;
				case 7u:
					num = ((int)num2 * -797548452) ^ -796171105;
					continue;
				case 5u:
				{
					int num4 = int_0;
					h.d[246] = (byte)((h.d[246] ^ int_2) & 0xB0);
					int_0 = num4 & 0x7FFF;
					num = (int)(num2 * 956118750) ^ -554009826;
					continue;
				}
				case 4u:
					switch (num3)
					{
					case 0:
					case 1:
					case 7:
						break;
					case 3:
					case 5:
						goto IL_005b;
					default:
						goto IL_00ed;
					case 4:
					case 6:
						goto IL_00f4;
					case 2:
						return;
					}
					goto case 6u;
				case 0u:
					goto IL_00f4;
				case 3u:
					num = ((int)num2 * -158626313) ^ 0x5BCC189A;
					continue;
				case 2u:
					num3 = 5;
					num = ((int)num2 * -1957250008) ^ -124149252;
					continue;
				case 1u:
					num3 = 1;
					num = ((int)num2 * -1889122580) ^ 0x2179A15F;
					continue;
				case 13u:
					break;
					IL_00f4:
					x_0.m[x_0.d++] = x_0.m[int_0++];
					num = 1367786067;
					continue;
					IL_00ed:
					num = 1066886599;
					continue;
					IL_005b:
					x_0.d &= 32767;
					num = 952733888;
					continue;
					IL_003c:
					num3 = num5;
					num = 1216808518;
					continue;
				}
				break;
			}
		}
	}

	static int a(v.x x_0)
	{
		return x_0.c;
	}

	static void t(v.x x_0, int int_0, int int_1)
	{
		char[] array = x.s;
		byte[] array2 = h.d;
		int num = 0;
		int num10 = default(int);
		int num9 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num2 = -533463836;
			while (true)
			{
				uint num3;
				int num5;
				switch ((num3 = (uint)num2 ^ 0xDE6C1E49u) % 7u)
				{
				case 6u:
					while (true)
					{
						switch (num)
						{
						case 3:
						case 13:
							if (x_0.d < num10)
							{
								num = 1;
								goto case 1;
							}
							num = 10;
							goto case 10;
						case 1:
							if (int_0 > int_1)
							{
								num = array2[55] - 237;
								continue;
							}
							num = 8;
							goto case 8;
						case 11:
						case 12:
							num9 = (x_0.d - int_1) & 0x7FFF;
							goto case 9;
						case 9:
							num10 = 32768 - int_0;
							num = 2;
							goto case 2;
						case 2:
							if (num9 <= num10)
							{
								num = array2[276];
								continue;
							}
							num = 10;
							goto case 10;
						case 0:
							goto IL_00aa;
						case 4:
							x_0.m[x_0.d++] = x_0.m[num9++];
							num = 5;
							goto case 5;
						case 5:
							if (int_0-- > 0)
							{
								num = 4;
								goto case 4;
							}
							num = 6;
							return;
						case 6:
							return;
						case 7:
							throw j.smethod_9();
						case 8:
							j.smethod_5((Array)x_0.m, num9, (Array)x_0.m, x_0.d, int_0);
							x_0.d += int_0;
							return;
						case 10:
							j.u(x_0, num9, int_0, int_1);
							return;
						}
						break;
					}
					num2 = -1936404090;
					continue;
				case 3u:
					goto IL_00aa;
				case 5u:
				{
					int num7;
					int num8;
					if (num6 <= 32768)
					{
						num7 = 212521187;
						num8 = 212521187;
					}
					else
					{
						num7 = 620124798;
						num8 = 620124798;
					}
					num2 = num7 ^ ((int)num3 * -1366728506);
					continue;
				}
				default:
					num5 = 11;
					goto IL_00ee;
				case 2u:
					num2 = (int)(num3 * 1686150591) ^ -1016354265;
					continue;
				case 1u:
				{
					char num4 = array[0];
					x.s[572] = (char)((x.s[572] * int_1) & '\u00ad');
					num5 = num4 - 44454;
					goto IL_00ee;
				}
				case 0u:
					break;
					IL_00ee:
					num = num5;
					num2 = -1216491084;
					continue;
					IL_00aa:
					num6 = (x_0.c += int_0);
					num2 = -109222130;
					continue;
				}
				break;
			}
		}
	}

	static void k(v.w w_0, int int_0)
	{
		char[] array = x.s;
		int num = 3;
		while (true)
		{
			int num2 = -1101312023;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xB117C474u) % 7u)
				{
				case 6u:
				{
					char num4 = array[240];
					x.s[79] = (char)((x.s[79] * int_0) & 'A');
					num = num4 - 47643;
					num2 = -2102229157;
					continue;
				}
				case 5u:
					switch (num)
					{
					case 2:
						break;
					default:
						goto IL_0051;
					case 0:
					case 1:
						goto IL_0058;
					case 3:
						goto IL_007d;
					case 4:
						return;
					}
					goto case 6u;
				case 2u:
					goto IL_0058;
				case 4u:
					goto IL_007d;
				case 3u:
					num2 = (int)(num3 * 1558978292) ^ -722680539;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
					IL_007d:
					w_0.h[w_0.v++] = (byte)int_0;
					num2 = -1571681412;
					continue;
					IL_0058:
					w_0.h[w_0.v++] = (byte)(int_0 >> 8);
					num2 = -894440790;
					continue;
					IL_0051:
					num2 = -1062976144;
					continue;
				}
				break;
			}
		}
	}

	static void s(int int_0, v.e e_0, int int_1, byte[] byte_0)
	{
		char[] array = x.s;
		byte[] array2 = default(byte[]);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1734492226;
			while (true)
			{
				uint num2;
				int num8;
				switch ((num2 = (uint)num ^ 0x4E96431Du) % 6u)
				{
				case 5u:
					array2 = h.d;
					num3 = 8;
					num = ((int)num2 * -1431943342) ^ 0x5F190A33;
					continue;
				case 4u:
					num8 = 7;
					goto IL_0026;
				case 2u:
				{
					int num9;
					if (e_0.x >= e_0.a)
					{
						num = 1757029662;
						num9 = 1757029662;
					}
					else
					{
						num = 164117657;
						num9 = 164117657;
					}
					continue;
				}
				default:
					num8 = array[417] - 14478;
					goto IL_0026;
				case 0u:
					while (true)
					{
						switch (num3)
						{
						case 8:
							break;
						case 12:
							if (int_1 <= num4)
							{
								num3 = 4;
								goto case 4;
							}
							num3 = 3;
							goto case 3;
						case 4:
							if (num4 > byte_0.Length)
							{
								num3 = array2[276];
								continue;
							}
							num3 = 10;
							goto case 6;
						case 6:
						case 10:
							if ((int_0 & 1) == 0)
							{
								num3 = array[514] - 47477;
								continue;
							}
							num3 = 11;
							goto case 1;
						case 9:
							num4 = int_1 + int_0;
							goto case 5;
						case 5:
							if (0 <= int_1)
							{
								num3 = 12;
								goto case 12;
							}
							num3 = 3;
							goto case 3;
						default:
							goto IL_00e8;
						case 7:
							throw j.smethod_9();
						case 1:
						case 11:
						{
							uint num5 = e_0.k;
							int num6 = byte_0[int_1++] & 0xFF;
							int num7 = e_0.g & 0x1F;
							h.d[163] = (byte)((h.d[163] + int_0) & 0x54);
							e_0.k = num5 | (uint)(num6 << num7);
							num3 = 2;
							goto case 2;
						}
						case 2:
							e_0.g += 8;
							num3 = 0;
							goto case 0;
						case 3:
							throw j.smethod_58();
						case 0:
							e_0.m = byte_0;
							e_0.x = int_1;
							e_0.a = num4;
							return;
						}
						break;
					}
					goto case 2u;
				case 3u:
					break;
					IL_00e8:
					num = 1959478521;
					continue;
					IL_0026:
					num3 = num8;
					num = 1034643293;
					continue;
				}
				break;
			}
		}
	}

	static void n(byte[] byte_0, v.t t_0)
	{
		char[] array = x.s;
		Array array2 = default(Array);
		int num8 = default(int);
		int num12 = default(int);
		object obj = default(object);
		byte[] array3 = default(byte[]);
		int num13 = default(int);
		int num18 = default(int);
		int num15 = default(int);
		int num14 = default(int);
		int num17 = default(int);
		int num9 = default(int);
		int num16 = default(int);
		int num11 = default(int);
		int num19 = default(int);
		int num10 = default(int);
		int num7 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -2061899448;
			while (true)
			{
				uint num2;
				int num21;
				switch ((num2 = (uint)num ^ 0xBCE24EE1u) % 12u)
				{
				case 10u:
					array2 = new int[16];
					num8 = 0;
					num3 = 8;
					num = ((int)num2 * -1311009677) ^ -52861816;
					continue;
				default:
					num21 = 30;
					goto IL_002d;
				case 8u:
				{
					int num22;
					int num23;
					if (num12 > 0)
					{
						num22 = 14350101;
						num23 = 14350101;
					}
					else
					{
						num22 = 836078312;
						num23 = 836078312;
					}
					num = num22 ^ ((int)num2 * -931155001);
					continue;
				}
				case 7u:
					num = (int)((num2 * 1173846980) ^ 0x6531ADD5);
					continue;
				case 6u:
					obj = new int[16];
					num = -1212204521;
					continue;
				case 5u:
					array3 = h.d;
					num = ((int)num2 * -1608710698) ^ -2127050974;
					continue;
				case 4u:
					num21 = 11;
					goto IL_002d;
				case 3u:
					num = (int)((num2 * 1228683677) ^ 0x2BAF3B26);
					continue;
				case 2u:
					goto IL_00b5;
				case 1u:
					num3 = 33;
					num = ((int)num2 * -1130151452) ^ 0x2C9F9F4D;
					continue;
				case 0u:
					while (true)
					{
						switch (num3)
						{
						case 33:
							break;
						case 2:
							goto IL_00b5;
						case 20:
							num13 += 1 << num18;
							if (num13 < num15)
							{
								num3 = 37;
								goto case 37;
							}
							num3 = 17;
							goto case 17;
						case 37:
							t_0.k[num14 | (num13 >> 9)] = (short)((num17 << 4) | num18);
							num3 = 20;
							goto case 20;
						case 17:
							(array2 as int[])[num18] = num9 + (1 << 16 - num18);
							num3 = 23;
							goto case 23;
						case 23:
							num17++;
							num3 = array3[243] - 91;
							continue;
						case 36:
							num3 = array[488] - 42859;
							continue;
						case 35:
							num16 += 1 << num11 - 9;
							num3 = 22;
							goto case 22;
						case 22:
							num19 += 128;
							num3 = 4;
							goto case 4;
						case 10:
							t_0.k[j.r(num19)] = (short)((-num16 << 4) | num11);
							num3 = 35;
							goto case 35;
						case 4:
							if (num19 < num10)
							{
								num3 = 10;
								goto case 10;
							}
							num3 = array3[291] - 5;
							continue;
						case 34:
							num11--;
							num3 = 21;
							goto case 21;
						case 21:
							num3 = ((num11 >= 10) ? array3[28] : (array3[290] - 205));
							continue;
						case 32:
							num10 = num9 & 0x1FF80;
							num9 -= (obj as int[])[num11] << 16 - num11;
							num3 = array[391] - 28099;
							continue;
						case 31:
							if (num7 >= 10)
							{
								num3 = array[298] - 19241;
								continue;
							}
							num3 = 26;
							goto case 6;
						case 6:
						case 26:
							num7++;
							num3 = array[86] - 16354;
							continue;
						case 30:
							num8++;
							num3 = array[606] - 49896;
							continue;
						case 29:
							t_0.k[num13] = (short)((num17 << 4) | num18);
							num3 = 19;
							goto case 19;
						case 19:
							num13 += 1 << num18;
							if (num13 >= 512)
							{
								num3 = 25;
								goto case 25;
							}
							num3 = array[311] - 12343;
							continue;
						case 25:
							num3 = array3[234] - 121;
							continue;
						case 28:
							num9 = 0;
							num4 = 512;
							num7 = 1;
							num3 = array[403] - 48676;
							continue;
						case 27:
							num6 = ((int[])array2)[num7] & 0x1FF80;
							num5 = num9 & 0x1FF80;
							num3 = array3[91];
							continue;
						case 18:
						{
							int num20 = num9 & 0x1FF80;
							num19 = num20;
							num3 = 4;
							goto case 4;
						}
						case 16:
							num17 = 0;
							goto case 36;
						case 15:
							if (num17 >= byte_0.Length)
							{
								num3 = array3[13] - 203;
								continue;
							}
							num3 = 3;
							goto case 3;
						case 3:
							num18 = byte_0[num17];
							if (num18 != 0)
							{
								num3 = 1;
								goto case 1;
							}
							num3 = array3[0] - 172;
							continue;
						case 1:
							num9 = ((int[])array2)[num18];
							num13 = j.r(num9);
							if (num18 <= 9)
							{
								num3 = 29;
								goto case 29;
							}
							num3 = (int)array3[177] / 5;
							continue;
						case 14:
							num11 = 15;
							num3 = 21;
							goto case 21;
						case 13:
							t_0.k = new short[num4];
							num16 = 512;
							goto case 14;
						case 12:
							num14 = t_0.k[num13 & 0x1FF];
							num15 = 1 << (num14 & 0xF);
							num3 = 5;
							goto case 5;
						case 5:
							num14 = -(num14 >> 4);
							num3 = array[293] - 18497;
							continue;
						case 11:
							((int[])obj)[num12]++;
							num3 = array[65] - 10683;
							continue;
						case 9:
							if (num7 > 15)
							{
								num3 = 13;
								goto case 13;
							}
							num3 = 7;
							goto case 7;
						case 7:
							(array2 as int[])[num7] = num9;
							num9 += ((int[])obj)[num7] << 16 - num7;
							num3 = 31;
							goto case 31;
						case 8:
							if (num8 >= byte_0.Length)
							{
								num3 = 28;
								goto case 28;
							}
							num3 = 2;
							goto IL_00b5;
						case 0:
							num4 += num5 - num6 >> 16 - num7;
							num3 = 26;
							goto case 6;
						default:
							goto IL_0521;
						case 24:
							return;
						}
						break;
					}
					goto case 6u;
				case 11u:
					break;
					IL_0521:
					num = -585409253;
					continue;
					IL_00b5:
					num12 = byte_0[num8];
					num = -66759183;
					continue;
					IL_002d:
					num3 = num21;
					num = -77364278;
					continue;
				}
				break;
			}
		}
	}

	static void v(v.j.m m_0, int int_0)
	{
		j.o(m_0.v.y, m_0.w[int_0] & 0xFFFF, (int)m_0.y[int_0]);
	}

	static void z(v.x x_0)
	{
		x_0.d = 0;
		x_0.c = 0;
	}

	static void f()
	{
		try
		{
			while (true)
			{
				j.smethod_60(j.smethod_59(), (ResolveEventHandler)j.f);
				int num = 2088698932;
				while (true)
				{
					switch ((uint)(num ^ 0x7FADCE8A) % 3u)
					{
					case 0u:
						goto IL_0003;
					default:
						return;
					case 1u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0003:
					num = 2122776418;
				}
			}
		}
		catch
		{
		}
	}

	static bool te(v.u u_0)
	{
		return u_0.e == u_0.n;
	}

	static ICryptoTransform j(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		char[] array = x.s;
		object obj = j.smethod_61();
		object obj2 = default(object);
		try
		{
			while (true)
			{
				IL_00d1:
				int num = 1;
				int num2 = 412876136;
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)num2 ^ 0x4BACB42Bu) % 7u)
					{
					case 6u:
					{
						ICryptoTransform cryptoTransform;
						switch (num)
						{
						default:
							num2 = 1947416457;
							continue;
						case 1:
							break;
						case 4:
							cryptoTransform = j.smethod_7((SymmetricAlgorithm)obj, byte_0, byte_1);
							goto IL_00f6;
						case 0:
						case 3:
						case 5:
							cryptoTransform = j.smethod_8((SymmetricAlgorithm)obj, byte_0, byte_1);
							goto IL_00f6;
						case 2:
							goto end_IL_00a4;
							IL_00f6:
							obj2 = cryptoTransform;
							goto end_IL_00a4;
						}
						goto case 4u;
					}
					case 4u:
					{
						int num6;
						if (!bool_0)
						{
							num2 = 858871173;
							num6 = 858871173;
						}
						else
						{
							num2 = 2013009557;
							num6 = 2013009557;
						}
						continue;
					}
					case 5u:
						num2 = (int)(num3 * 161258150) ^ -2041116532;
						continue;
					case 3u:
					{
						char num5 = array[51];
						h.d[259] = (byte)((h.d[259] ^ h.d[280]) & 0xEA);
						num4 = num5 - 14336;
						goto IL_0094;
					}
					default:
						num4 = 3;
						goto IL_0094;
					case 0u:
						num2 = 1854271717;
						continue;
					case 2u:
						break;
						IL_0094:
						num = num4;
						num2 = 423689517;
						continue;
					}
					goto IL_00d1;
					continue;
					end_IL_00a4:
					break;
				}
				break;
			}
		}
		finally
		{
			while (true)
			{
				IL_0198:
				int num7 = 5;
				int num8 = 402993436;
				while (true)
				{
					uint num3;
					int num9;
					switch ((num3 = (uint)num8 ^ 0x4BACB42Bu) % 7u)
					{
					case 6u:
						num9 = 0;
						goto IL_0104;
					case 5u:
					{
						int num10;
						if ((SymmetricAlgorithm)obj != null)
						{
							num8 = 1726898369;
							num10 = 1726898369;
						}
						else
						{
							num8 = 1897947158;
							num10 = 1897947158;
						}
						continue;
					}
					case 3u:
						num8 = 1433743463;
						continue;
					case 2u:
						num8 = ((int)num3 * -1139770651) ^ -1857291069;
						continue;
					default:
						num9 = 3;
						goto IL_0104;
					case 0u:
						switch (num7)
						{
						case 5:
							break;
						default:
							num8 = 752792279;
							continue;
						case 0:
						case 1:
						case 2:
							j.smethod_4((IDisposable)(obj as SymmetricAlgorithm));
							goto end_IL_016b;
						case 3:
						case 4:
							goto end_IL_016b;
						}
						goto case 5u;
					case 4u:
						break;
						IL_0104:
						num7 = num9;
						num8 = 1969623384;
						continue;
					}
					goto IL_0198;
					continue;
					end_IL_016b:
					break;
				}
				break;
			}
		}
		return (ICryptoTransform)obj2;
	}

	static void tt(v.j j_0)
	{
		j_0.l = 0;
		while (true)
		{
			int num = -856498648;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA40CA1E8u) % 3u)
				{
				case 2u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0009:
				j_0.b = 0;
				num = (int)(num2 * 1610413770) ^ -1549965787;
			}
		}
	}

	static int p(int int_0, byte[] byte_0, int int_1, v.h h_0)
	{
		byte[] array = h.d;
		char[] array2 = default(char[]);
		int num6 = default(int);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -6875250;
			while (true)
			{
				uint num2;
				int num4;
				switch ((num2 = (uint)num ^ 0x8F5B4C57u) % 9u)
				{
				case 8u:
				{
					int num9;
					if (h_0.n != 11)
					{
						num = -362019463;
						num9 = -362019463;
					}
					else
					{
						num = -121817130;
						num9 = -121817130;
					}
					continue;
				}
				case 6u:
					array2 = x.s;
					num = (int)(num2 * 1250010299) ^ -2015845283;
					continue;
				case 5u:
					num4 = 6;
					goto IL_004b;
				case 4u:
					num = ((int)num2 * -1609024485) ^ 0x30930C04;
					continue;
				case 3u:
					while (true)
					{
						switch (num3)
						{
						case 8:
							break;
						case 9:
						case 10:
						{
							num6 += num5;
							int num7 = int_1;
							int num8 = num5;
							h.d[280] = (byte)(h.d[280] & x.s[525] & 0xA4);
							int_1 = num7 - num8;
							if (int_1 != 0)
							{
								num3 = 2;
								goto case 2;
							}
							num3 = 7;
							goto case 7;
						}
						case 2:
						case 4:
						case 5:
							if (!j.v(h_0))
							{
								num3 = 0;
								goto case 0;
							}
							num3 = array2[117] - 30386;
							continue;
						case 0:
							if (h_0.k.c > 0)
							{
								num3 = 1;
								goto case 1;
							}
							num3 = 3;
							goto case 3;
						case 1:
							if (h_0.n != 11)
							{
								num3 = array2[350] - 60664;
								continue;
							}
							num3 = 3;
							goto case 3;
						case 6:
							num5 = j.o(byte_0, h_0.k, int_0, int_1);
							int_0 += num5;
							num3 = array2[353] - 5669;
							continue;
						default:
							goto IL_014d;
						case 11:
							goto IL_0154;
						case 7:
							return num6;
						case 3:
							return num6;
						}
						break;
					}
					goto case 8u;
				case 2u:
					goto IL_0154;
				default:
					num4 = array2[387] - 64255;
					goto IL_004b;
				case 0u:
					num3 = 11;
					num = ((int)num2 * -1521131918) ^ 0x1B288C83;
					continue;
				case 7u:
					break;
					IL_0154:
					num6 = 0;
					num3 = array[173] - 1;
					num = -2133504639;
					continue;
					IL_014d:
					num = -1625016517;
					continue;
					IL_004b:
					num3 = num4;
					num = -1400152440;
					continue;
				}
				break;
			}
		}
	}

	static void tl(v.u u_0)
	{
		char[] array = x.s;
		byte[] array2 = h.d;
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -1090563166;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)num ^ 0x8E3D209Du) % 6u)
				{
				case 5u:
					num6 = 13;
					goto IL_0013;
				case 3u:
					num3 = 5;
					num = (int)((num2 * 1831277999) ^ 0x2F376B24);
					continue;
				default:
					num6 = array[514] - 47474;
					goto IL_0013;
				case 1u:
				{
					int num5;
					if (u_0.f >= 65274)
					{
						num = -731612122;
						num5 = -731612122;
					}
					else
					{
						num = -1910640447;
						num5 = -1910640447;
					}
					continue;
				}
				case 0u:
					while (true)
					{
						switch (num3)
						{
						case 5:
							break;
						case 13:
							j.c(u_0);
							goto case 2;
						case 2:
							num3 = 3;
							goto case 3;
						case 3:
							num3 = ((u_0.o >= 262) ? (array[376] - 13294) : (array2[148] - 69));
							continue;
						case 11:
						case 12:
							goto IL_00a2;
						case 10:
							u_0.n += num4;
							u_0.a += num4;
							goto case 7;
						case 7:
							num3 = 0;
							goto case 0;
						case 0:
							u_0.o += num4;
							num3 = 3;
							goto case 3;
						case 8:
							num4 = u_0.e - u_0.n;
							num3 = 4;
							goto case 4;
						case 4:
							j.smethod_5((Array)u_0.x, u_0.n, (Array)u_0.h, u_0.f + u_0.o, num4);
							num3 = 10;
							goto case 10;
						case 6:
							goto IL_0147;
						case 1:
							goto IL_0163;
						default:
							goto IL_01e9;
						case 14:
							j.h(u_0);
							return;
						case 9:
							return;
						}
						break;
						IL_0163:
						num4 = 65536 - u_0.o - u_0.f;
						num3 = ((num4 <= u_0.e - u_0.n) ? (array[309] - 28319) : (array[155] - 9826));
						continue;
						IL_0147:
						if (u_0.o >= 3)
						{
							num3 = array[343] - 48443;
							continue;
						}
						num3 = 9;
						return;
						IL_00a2:
						num3 = ((u_0.n < u_0.e) ? (array[592] - 3538) : (array2[230] - array2[78]));
					}
					goto case 1u;
				case 4u:
					break;
					IL_01e9:
					num = -400262152;
					continue;
					IL_0013:
					num3 = num6;
					num = -2033280971;
					continue;
				}
				break;
			}
		}
	}

	static int o(byte[] byte_0, v.x x_0, int int_0, int int_1)
	{
		byte[] array = h.d;
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		int num4 = default(int);
		char[] array2 = default(char[]);
		while (true)
		{
			int num = 67887093;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x147E7D66u) % 9u)
				{
				case 7u:
					num7 = x_0.d;
					num = 192857989;
					continue;
				case 6u:
					num = (int)((num2 * 1221259129) ^ 0x1DF15130);
					continue;
				case 5u:
					while (true)
					{
						switch (num4)
						{
						case 1:
						case 8:
							break;
						case 12:
							num8 = int_1;
							num9 = int_1 - num7;
							num4 = ((num9 <= 0) ? array[91] : array[233]);
							continue;
						case 11:
							if (x_0.c >= 0)
							{
								num4 = array[101];
								continue;
							}
							num4 = 10;
							goto case 10;
						case 9:
							int_1 = num7;
							num4 = 0;
							goto case 0;
						case 0:
							j.smethod_5((Array)x_0.m, num7 - int_1, (Array)byte_0, int_0, int_1);
							goto case 3;
						case 3:
							x_0.c -= num8;
							num4 = 11;
							goto case 11;
						case 6:
							num7 = (x_0.d - x_0.c + int_1) & 0x7FFF;
							num4 = 12;
							goto case 12;
						case 5:
							int_1 = x_0.c;
							num4 = array[71] - 71;
							continue;
						case 4:
							j.smethod_5((Array)x_0.m, 32768 - num9, (Array)byte_0, int_0, num9);
							int_0 += num9;
							num4 = array2[134] - 27992;
							continue;
						default:
							goto IL_0132;
						case 10:
							throw j.smethod_9();
						case 2:
						case 7:
							return num8;
						}
						break;
					}
					goto case 7u;
				default:
					num3 = 6;
					goto IL_013a;
				case 3u:
				{
					int num5;
					int num6;
					if (int_1 <= x_0.c)
					{
						num5 = -1170073603;
						num6 = -1170073603;
					}
					else
					{
						num5 = -65408478;
						num6 = -65408478;
					}
					num = num5 ^ ((int)num2 * -443525307);
					continue;
				}
				case 2u:
					num4 = 8;
					num = (int)(num2 * 292970808) ^ -1811343879;
					continue;
				case 1u:
					array2 = x.s;
					num = ((int)num2 * -1068617724) ^ 0x68806DE7;
					continue;
				case 0u:
					num3 = 5;
					goto IL_013a;
				case 8u:
					break;
					IL_0132:
					num = 660112494;
					continue;
					IL_013a:
					num4 = num3;
					num = 1329729855;
					continue;
				}
				break;
			}
		}
	}

	static void y()
	{
		char[] array = x.s;
		int num3 = default(int);
		while (true)
		{
			int num = 421702156;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6CBBE9A5u) % 9u)
				{
				case 8u:
					m.m = v.a.u(7, 12, j.smethod_15(typeof(v.h).TypeHandle), 1468094616);
					num = ((int)num2 * -45800740) ^ 0x6F955C54;
					continue;
				case 7u:
					switch (num3)
					{
					case 0:
					case 1:
						goto IL_005d;
					case 3:
						goto IL_0075;
					case 2:
					case 4:
						goto IL_020d;
					}
					num = 310826295;
					continue;
				case 2u:
					goto IL_005d;
				case 3u:
					goto IL_0075;
				case 6u:
					m.t = new string[16]
					{
						c.k(1229547724, null, 8),
						c.k(1229547774, null, 0),
						c.k(1229547761, null, 2),
						c.k(1229547760, null, 4),
						c.k(1229547754, null, 4),
						c.k(1229547745, null, 1),
						c.k(1229547746, null, 7),
						c.k(1229547551, null, 0),
						c.k(1229547537, null, 0),
						v.a.u(6, 11, j.smethod_15(typeof(a).TypeHandle), 1468094502),
						c.k(1229547533, null, 6),
						v.a.u(1, 15, j.smethod_15(typeof(m).TypeHandle), 1468094511),
						c.k(1229547528, null, 4),
						v.a.u(1, 13, j.smethod_15(typeof(p.y).TypeHandle), 1468094933),
						c.k(1229547523, null, 5),
						c.k(1229547714, null, 6)
					};
					num = ((int)num2 * -777624779) ^ -469564570;
					continue;
				case 5u:
					num3 = 3;
					num = ((int)num2 * -1881367205) ^ 0xC3C48D6;
					continue;
				case 4u:
					num = ((int)num2 * -305041906) ^ 0x2B4FA45D;
					continue;
				case 0u:
					break;
				default:
					goto IL_020d;
					IL_020d:
					m.t = m.t.Select(byte.Parse).ToArray();
					return;
					IL_0075:
					num = 1668004575;
					continue;
					IL_005d:
					num3 = array[363] - 7298;
					num = 1529183985;
					continue;
				}
				break;
			}
		}
	}

	static CryptoStream smethod_0(Stream stream_0, ICryptoTransform icryptoTransform_0, CryptoStreamMode cryptoStreamMode_0)
	{
		return new CryptoStream(stream_0, icryptoTransform_0, cryptoStreamMode_0);
	}

	static void smethod_1(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	static void smethod_2(CryptoStream cryptoStream_0)
	{
		cryptoStream_0.FlushFinalBlock();
	}

	static byte[] smethod_3(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	static void smethod_4(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static void smethod_5(Array array_0, int int_0, Array array_1, int int_1, int int_2)
	{
		Array.Copy(array_0, int_0, array_1, int_1, int_2);
	}

	static DESCryptoServiceProvider smethod_6()
	{
		return new DESCryptoServiceProvider();
	}

	static ICryptoTransform smethod_7(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		return symmetricAlgorithm_0.CreateEncryptor(byte_0, byte_1);
	}

	static ICryptoTransform smethod_8(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		return symmetricAlgorithm_0.CreateDecryptor(byte_0, byte_1);
	}

	static InvalidOperationException smethod_9()
	{
		return new InvalidOperationException();
	}

	static Rijndael smethod_10()
	{
		return Rijndael.Create();
	}

	static Rfc2898DeriveBytes smethod_11(string string_0, byte[] byte_0, int int_0)
	{
		return new Rfc2898DeriveBytes(string_0, byte_0, int_0);
	}

	static void smethod_12(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	static Assembly smethod_13()
	{
		return Assembly.GetCallingAssembly();
	}

	static Assembly smethod_14()
	{
		return Assembly.GetExecutingAssembly();
	}

	static Type smethod_15(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static FormatException smethod_16(string string_0)
	{
		return new FormatException(string_0);
	}

	static int smethod_17(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		return stream_0.Read(byte_0, int_0, int_1);
	}

	static long smethod_18(Stream stream_0)
	{
		return stream_0.Length;
	}

	static long smethod_19(Stream stream_0)
	{
		return stream_0.Position;
	}

	static byte[] smethod_20(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1)
	{
		return icryptoTransform_0.TransformFinalBlock(byte_0, int_0, int_1);
	}

	static void smethod_21(Stream stream_0)
	{
		stream_0.Close();
	}

	static int smethod_22(Stream stream_0)
	{
		return stream_0.ReadByte();
	}

	static int smethod_23(int int_0, int int_1)
	{
		return Math.Max(int_0, int_1);
	}

	static int smethod_24(int int_0, int int_1)
	{
		return Math.Min(int_0, int_1);
	}

	static object smethod_25(MethodBase methodBase_0, object object_0, object[] object_1)
	{
		return methodBase_0.Invoke(object_0, object_1);
	}

	static MethodInfo smethod_26(Assembly assembly_0)
	{
		return assembly_0.EntryPoint;
	}

	static string smethod_27(ResolveEventArgs resolveEventArgs_0)
	{
		return resolveEventArgs_0.Name;
	}

	static Encoding smethod_28()
	{
		return Encoding.UTF8;
	}

	static byte[] smethod_29(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	static string smethod_30(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	static string[] smethod_31(string string_0, char[] char_0)
	{
		return string_0.Split(char_0);
	}

	static bool smethod_32(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static int smethod_33(string string_0)
	{
		return string_0.Length;
	}

	static char smethod_34(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	static int smethod_35(string string_0, char char_0)
	{
		return string_0.IndexOf(char_0);
	}

	static string smethod_36(string string_0, int int_0, int int_1)
	{
		return string_0.Substring(int_0, int_1);
	}

	static string smethod_37(string string_0, int int_0)
	{
		return string_0.Substring(int_0);
	}

	static void smethod_38(object object_0)
	{
		Monitor.Enter(object_0);
	}

	static Stream smethod_39(Assembly assembly_0, string string_0)
	{
		return assembly_0.GetManifestResourceStream(string_0);
	}

	static Assembly smethod_40(byte[] byte_0)
	{
		return Assembly.Load(byte_0);
	}

	static string smethod_41()
	{
		return Path.GetTempPath();
	}

	static string smethod_42(string string_0, object object_0, object object_1)
	{
		return string.Format(string_0, object_0, object_1);
	}

	static DirectoryInfo smethod_43(string string_0)
	{
		return Directory.CreateDirectory(string_0);
	}

	static string smethod_44(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static bool smethod_45(string string_0)
	{
		return File.Exists(string_0);
	}

	static FileStream smethod_46(string string_0)
	{
		return File.OpenWrite(string_0);
	}

	static Assembly smethod_47(string string_0)
	{
		return Assembly.LoadFile(string_0);
	}

	static void smethod_48(object object_0)
	{
		Monitor.Exit(object_0);
	}

	static void smethod_49(Stream stream_0, byte byte_0)
	{
		stream_0.WriteByte(byte_0);
	}

	static AssemblyName smethod_50(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}

	static byte[] smethod_51(AssemblyName assemblyName_0)
	{
		return assemblyName_0.GetPublicKey();
	}

	static ICryptoTransform smethod_52(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		return symmetricAlgorithm_0.CreateDecryptor();
	}

	static MemoryStream smethod_53()
	{
		return new MemoryStream();
	}

	static void smethod_54(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0)
	{
		symmetricAlgorithm_0.Padding = paddingMode_0;
	}

	static byte[] smethod_55(DeriveBytes deriveBytes_0, int int_0)
	{
		return deriveBytes_0.GetBytes(int_0);
	}

	static void smethod_56(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		symmetricAlgorithm_0.Key = byte_0;
	}

	static void smethod_57(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		symmetricAlgorithm_0.IV = byte_0;
	}

	static ArgumentOutOfRangeException smethod_58()
	{
		return new ArgumentOutOfRangeException();
	}

	static AppDomain smethod_59()
	{
		return AppDomain.CurrentDomain;
	}

	static void smethod_60(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0)
	{
		appDomain_0.AssemblyResolve += resolveEventHandler_0;
	}

	static RijndaelManaged smethod_61()
	{
		return new RijndaelManaged();
	}
}
