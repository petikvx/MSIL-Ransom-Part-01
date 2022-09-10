using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace c;

internal sealed class m
{
	internal sealed class c
	{
		internal IContainer f;

		internal c()
		{
		}
	}

	public static a g
	{
		set
		{
			n.r<MethodBase, object>((MethodInfo)value.o, null, value.f, 650, 643);
		}
	}

	public static void g()
	{
		int[] x = l.x;
		int num = 4;
		while (true)
		{
			int num2 = 2044878984;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x4D9CA46Du) % 7u)
				{
				case 6u:
					y.g = b.l;
					num2 = 1493639314;
					continue;
				case 4u:
					goto IL_0021;
				case 3u:
					num = x[79] - 51189;
					num2 = (int)((num3 * 1768213259) ^ 0x5CBDF82B);
					continue;
				case 1u:
					switch (num)
					{
					case 3:
					case 4:
						break;
					case 1:
						goto IL_0021;
					default:
						goto IL_0082;
					case 0:
					case 2:
						return;
					}
					goto case 6u;
				case 0u:
					y.w = new string[32]
					{
						t.h(8, 1517858926, '\u0093'),
						t.h(2, 1517858914, 'r'),
						t.h(3, 1517858921, 'ß'),
						t.h(2, 1517858933, '\u0003'),
						t.h(8, 1517858936, 'Ø'),
						t.h(4, 1517858937, '?'),
						t.h(4, 1517858882, 'Ì'),
						t.h(3, 1517858881, '\u0093'),
						t.h(3, 1517858892, '0'),
						t.x(2, 427466884, 4),
						t.h(0, 1517858888, 'c'),
						t.x(4, 427466881, 4),
						t.h(0, 1517858898, '!'),
						t.x(1, 427466883, 8),
						t.h(0, 1517858908, 'Â'),
						t.x(0, 427466897, 1),
						t.h(0, 1517858854, 'ù'),
						t.x(15, 427466900, 2),
						t.h(6, 1517858854, '·'),
						t.x(10, 427466909, 7),
						t.h(7, 1517858861, 'o'),
						t.x(9, 427466911, 1),
						t.h(5, 1517858865, 'L'),
						t.x(10, 427466912, 4),
						t.h(6, 1517858918, 'L'),
						t.x(8, 427466914, 8),
						t.h(0, 1517858878, '\u0018'),
						t.x(6, 427466931, 3),
						t.h(8, 1517858864, 'N'),
						t.x(0, 427466933, 3),
						t.h(3, 1517858817, 'M'),
						t.x(0, 427466937, 2)
					};
					num2 = ((int)num3 * -1577836689) ^ -2142140363;
					continue;
				default:
					return;
				case 5u:
					break;
				case 2u:
					return;
					IL_0082:
					num2 = 195872417;
					continue;
					IL_0021:
					y.h = y.w.Select(byte.Parse).ToArray();
					num2 = 1333767794;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void o<T>(T gparam_0, PaddingMode paddingMode_0, int int_0, short short_0) where T : SymmetricAlgorithm
	{
		int[] x = l.x;
		int num5 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1147360626;
			while (true)
			{
				uint num2;
				int num4;
				switch ((num2 = (uint)num ^ 0x7C5BE9D4u) % 9u)
				{
				case 8u:
					switch (((short_0 ^ int_0) - 37) ^ num5)
					{
					default:
						num = 1634021756;
						continue;
					case 0:
						break;
					}
					goto default;
				default:
					num4 = x[18] - 54969;
					goto IL_0030;
				case 7u:
					num3 = 4;
					num = (int)(num2 * 401048705) ^ -1390252431;
					continue;
				case 6u:
					num = (int)((num2 * 1238705052) ^ 0x681B3EEB);
					continue;
				case 5u:
					while (true)
					{
						switch (num3)
						{
						case 1:
						case 7:
						case 9:
							break;
						case 8:
							num5++;
							num6 = short_0 * short_0;
							num6 = short_0 + num6;
							num3 = 3;
							goto case 3;
						case 3:
							num3 = ((num6 % 2 != 0) ? (x[41] - 32970) : (x[104] - 24109));
							continue;
						case 5:
							m.smethod_0((SymmetricAlgorithm)gparam_0, paddingMode_0);
							goto case 8;
						case 0:
							num3 = 8;
							goto case 8;
						default:
							goto IL_00d2;
						case 2:
						case 4:
							goto IL_00d9;
						case 6:
							return;
						}
						break;
					}
					goto case 8u;
				case 3u:
					goto IL_00d9;
				case 1u:
					num4 = 0;
					goto IL_0030;
				case 0u:
					num3 = 7;
					num = (int)((num2 * 1164765651) ^ 0x5F94A299);
					continue;
				case 4u:
					break;
					IL_00d9:
					num5 = 0;
					num = 1159836014;
					continue;
					IL_00d2:
					num = 2140632042;
					continue;
					IL_0030:
					num3 = num4;
					num = 1745032973;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool k<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : Version where U : Version
	{
		int[] x = l.x;
		int num4 = default(int);
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 1260835944;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x377CF0CBu) % 10u)
				{
				case 9u:
					num = (int)(num2 * 484790340) ^ -2124812125;
					continue;
				case 8u:
					num5 = 10;
					goto IL_001f;
				case 7u:
					num4 = 0;
					num3 = x[251] - 4569;
					num = 632260543;
					continue;
				case 6u:
					num3 = 8;
					num = ((int)num2 * -618643180) ^ -283613884;
					continue;
				case 5u:
					goto IL_0058;
				default:
					num5 = 2;
					goto IL_001f;
				case 4u:
					switch (num3)
					{
					case 5:
					case 8:
						break;
					case 1:
						goto IL_0058;
					default:
						goto IL_00ac;
					case 0:
						num3 = 1;
						goto IL_0058;
					case 2:
						result = m.smethod_1((Version)gparam_0, (Version)gparam_1);
						num3 = 6;
						goto case 6;
					case 4:
						goto IL_00ce;
					case 10:
						result = true;
						goto case 11;
					case 11:
						num3 = 6;
						goto case 6;
					case 6:
						num4++;
						if ((char_0 * char_0 + char_0) % 2 != 0)
						{
							num3 = 9;
							goto case 9;
						}
						num3 = 7;
						goto case 3;
					case 9:
						num3 = 1;
						goto IL_0058;
					case 3:
					case 7:
						return result;
					}
					goto case 7u;
				case 2u:
					goto IL_00ce;
				case 3u:
					num = ((int)num2 * -1111754867) ^ -159968129;
					continue;
				case 0u:
					break;
					IL_00ce:
					num = 1753471541;
					continue;
					IL_00ac:
					num = 1143271119;
					continue;
					IL_0058:
					switch (((char_0 ^ int_0) - 35) ^ num4)
					{
					default:
						num = 287584661;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_001f:
					num3 = num5;
					num = 632260543;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void q<T>(T gparam_0, SizeF sizeF_0, int int_0, short short_0) where T : ContainerControl
	{
		int[] x = l.x;
		char[] array = default(char[]);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -821099452;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x90426241u) % 10u)
				{
				case 9u:
					array = e.e.k;
					num = ((int)num2 * -2133258292) ^ -547276643;
					continue;
				case 7u:
					num4 = 3;
					num = (int)(num2 * 1941256297) ^ -142294639;
					continue;
				case 6u:
					num5 = 0;
					num = -2001511196;
					continue;
				case 5u:
					while (true)
					{
						switch (num4)
						{
						case 8:
							break;
						case 0:
						case 2:
						case 7:
							num4 = x[347] - 60214;
							continue;
						case 6:
							m.smethod_2((ContainerControl)(object)gparam_0, sizeF_0);
							goto case 1;
						case 1:
						case 5:
							num5++;
							if ((short_0 * short_0 + short_0) % 2 != 0)
							{
								num4 = 2;
								goto case 0;
							}
							num4 = array[247] - 18185;
							continue;
						case 4:
							num4 = 1;
							goto case 1;
						default:
							goto IL_00b4;
						case 3:
							goto IL_00bb;
						case 9:
							return;
						}
						break;
					}
					goto case 6u;
				case 3u:
					goto IL_00bb;
				default:
					num3 = array[43] - 46624;
					goto IL_00de;
				case 4u:
					num4 = 8;
					num = (int)((num2 * 967670283) ^ 0x5E17029C);
					continue;
				case 1u:
					num = (int)(num2 * 1507300069) ^ -624391123;
					continue;
				case 0u:
					num3 = x[265] - 17918;
					goto IL_00de;
				case 8u:
					break;
					IL_00bb:
					switch (((short_0 ^ int_0) - 48) ^ num5)
					{
					default:
						num = -1980835831;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_00de:
					num4 = num3;
					num = -2073425924;
					continue;
					IL_00b4:
					num = -1823195247;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string s<T>(T gparam_0, short short_0, char char_0) where T : ProcessModule
	{
		int[] x = l.x;
		char[] array = e.e.k;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = -772253140;
			while (true)
			{
				uint num3;
				int num5;
				switch ((num3 = (uint)num2 ^ 0xDA7E80BFu) % 11u)
				{
				case 10u:
					num2 = -828657957;
					continue;
				case 9u:
					num4 = x[202] - 53442;
					num2 = ((int)num3 * -1019418650) ^ 0x690A2B87;
					continue;
				case 8u:
					num5 = array[229] - 800;
					goto IL_0048;
				case 7u:
					num2 = ((int)num3 * -1369437361) ^ -17966205;
					continue;
				case 5u:
					num4 = 7;
					num2 = (int)((num3 * 1766207162) ^ 0x2FCF55E7);
					continue;
				case 4u:
					switch (((short_0 ^ char_0) - 86) ^ num)
					{
					default:
						num2 = -7807808;
						continue;
					case 0:
						break;
					}
					goto default;
				default:
					num5 = x[62] - 25264;
					goto IL_0048;
				case 2u:
					num2 = (int)(num3 * 1989621855) ^ -1168944015;
					continue;
				case 1u:
					while (true)
					{
						switch (num4)
						{
						case 7:
							break;
						case 11:
							enumerable = m.smethod_3((ProcessModule)gparam_0);
							num4 = 8;
							goto case 8;
						case 8:
						case 10:
							num++;
							num4 = (((char_0 * char_0 + char_0) % 2 == 0) ? (x[304] - 65426) : (x[183] - 6715));
							continue;
						case 3:
						case 9:
							num4 = array[296] - 47734;
							continue;
						case 6:
							enumerable = null;
							num4 = x[22] - 24263;
							continue;
						case 0:
						case 5:
							num4 = x[103] - 65046;
							continue;
						default:
							goto IL_0152;
						case 1:
							goto IL_0159;
						case 4:
							goto end_IL_0169;
						case 2:
							return (string)enumerable;
						}
						break;
					}
					goto case 4u;
				case 0u:
					goto IL_0159;
				case 6u:
					break;
					IL_0159:
					num2 = -1353869465;
					continue;
					IL_0152:
					num2 = -988889020;
					continue;
					IL_0048:
					num4 = num5;
					num2 = -828657957;
					continue;
					end_IL_0169:
					break;
				}
				break;
			}
		}
	}

	static void smethod_0(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0)
	{
		symmetricAlgorithm_0.Padding = paddingMode_0;
	}

	static bool smethod_1(Version version_0, Version version_1)
	{
		return version_0 != version_1;
	}

	static void smethod_2(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static string smethod_3(ProcessModule processModule_0)
	{
		return processModule_0.ModuleName;
	}
}
