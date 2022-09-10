using System;
using System.Collections;
using System.Reflection;
using System.Security;

namespace c;

internal sealed class f
{
	internal sealed class p
	{
		internal int w;

		internal p()
		{
		}
	}

	[SecuritySafeCritical]
	internal static string x<T>(T gparam_0, char char_0, int int_0) where T : string
	{
		int[] array = l.x;
		int num4 = default(int);
		char[] k = default(char[]);
		int num5 = default(int);
		IEnumerable enumerable = default(IEnumerable);
		int num3 = default(int);
		while (true)
		{
			int num = -108600474;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)num ^ 0xBE336E4Fu) % 12u)
				{
				case 11u:
					num6 = array[94] - 16494;
					goto IL_0015;
				case 10u:
					num = ((int)num2 * -336051662) ^ -1600502141;
					continue;
				case 9u:
					num4 = 0;
					num = -463619865;
					continue;
				case 8u:
					while (true)
					{
						switch (num3)
						{
						case 9:
							break;
						case 11:
							num3 = array[290] - 34386;
							continue;
						case 10:
							if (num5 % 2 != 0)
							{
								num3 = k[560] - 7812;
								continue;
							}
							num3 = 4;
							goto case 4;
						case 3:
						case 7:
							num4++;
							num5 = char_0 * char_0;
							num5 = char_0 + num5;
							goto case 2;
						case 2:
							num3 = k[254] - 3625;
							continue;
						case 5:
							enumerable = f.smethod_0((string)gparam_0);
							num3 = 3;
							goto case 3;
						case 0:
							enumerable = null;
							num3 = 3;
							goto case 3;
						default:
							goto IL_00d6;
						case 1:
							goto IL_00e0;
						case 6:
						case 8:
							goto IL_00f5;
						case 4:
							return enumerable as string;
						}
						break;
					}
					goto case 9u;
				case 2u:
					goto IL_00e0;
				case 3u:
					goto IL_00f5;
				default:
					num6 = k[592] - 5352;
					goto IL_0015;
				case 7u:
					num = ((int)num2 * -623225300) ^ 0x1C0F7F76;
					continue;
				case 5u:
					k = e.e.k;
					num = (int)((num2 * 2139112283) ^ 0x52563273);
					continue;
				case 4u:
					num = (int)((num2 * 730522857) ^ 0x6D708AF3);
					continue;
				case 0u:
					num3 = 6;
					num = (int)(num2 * 592598965) ^ -1624536927;
					continue;
				case 6u:
					break;
					IL_00f5:
					switch (((char_0 ^ int_0) - 125) ^ num4)
					{
					default:
						num = -1252443640;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_00e0:
					num3 = array[181] - 40513;
					num = -934059537;
					continue;
					IL_00d6:
					num = -686352035;
					continue;
					IL_0015:
					num3 = num6;
					num = -540000525;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static AssemblyName s<T>(T gparam_0, short short_0, short short_1) where T : Assembly
	{
		char[] k = e.e.k;
		int[] array = default(int[]);
		ICloneable cloneable = default(ICloneable);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 569895978;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x1D690F05u) % 14u)
				{
				case 12u:
					num = ((int)num2 * -1930574303) ^ -1767969394;
					continue;
				case 11u:
					num4 = 8;
					num = ((int)num2 * -1134633644) ^ 0x9EA7B65;
					continue;
				case 10u:
					num = (int)((num2 * 961075481) ^ 0x7DBCB0DA);
					continue;
				case 9u:
					num5 = 0;
					num = 1228252714;
					continue;
				case 8u:
					num4 = k[427] - 44625;
					num = (int)((num2 * 2140503284) ^ 0x425194BF);
					continue;
				default:
					num3 = array[344] - 26224;
					goto IL_007d;
				case 6u:
					num = (int)((num2 * 1090600174) ^ 0x63E2D6BC);
					continue;
				case 5u:
					while (true)
					{
						switch (num4)
						{
						case 9:
							break;
						case 4:
						case 6:
							cloneable = null;
							num4 = k[17] - 10442;
							continue;
						default:
							goto IL_00de;
						case 2:
							goto IL_00e5;
						case 3:
							num4 = 8;
							goto IL_00f2;
						case 10:
							num4 = 8;
							goto IL_00f2;
						case 1:
						case 8:
							goto IL_00f2;
						case 11:
							cloneable = f.smethod_1((Assembly)gparam_0);
							num4 = 5;
							goto case 0;
						case 0:
						case 5:
							num5++;
							num4 = 7;
							goto case 7;
						case 7:
							return cloneable as AssemblyName;
						}
						break;
					}
					goto case 9u;
				case 0u:
					goto IL_00e5;
				case 3u:
					goto IL_00f2;
				case 4u:
					num = (int)((num2 * 2072151396) ^ 0x6121697C);
					continue;
				case 2u:
					num3 = 6;
					goto IL_007d;
				case 1u:
					array = l.x;
					num = ((int)num2 * -1531339312) ^ -441670859;
					continue;
				case 13u:
					break;
					IL_00f2:
					switch (((short_0 ^ short_1) - 68) ^ num5)
					{
					case 0:
						break;
					default:
						num = 1542696447;
						continue;
					}
					goto default;
					IL_00e5:
					num = 265223811;
					continue;
					IL_00de:
					num = 2043235913;
					continue;
					IL_007d:
					num4 = num3;
					num = 595367693;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime g(short short_0, char char_0)
	{
		int[] array = l.x;
		char[] k = e.e.k;
		DateTime result = default(DateTime);
		while (true)
		{
			int num = 0;
			int num2 = 10;
			int num3 = -663580834;
			while (true)
			{
				uint num4;
				int num5;
				switch ((num4 = (uint)num3 ^ 0xBC1EE8F7u) % 9u)
				{
				default:
					num5 = 11;
					goto IL_0013;
				case 6u:
					num3 = (int)(num4 * 1497787362) ^ -580046661;
					continue;
				case 5u:
					num3 = -850389367;
					continue;
				case 4u:
					num3 = -254039121;
					continue;
				case 3u:
					num5 = 2;
					goto IL_0013;
				case 2u:
					num2 = array[111] - 33547;
					num3 = ((int)num4 * -1846359309) ^ -893236735;
					continue;
				case 1u:
					while (true)
					{
						switch (num2)
						{
						case 1:
							break;
						case 11:
							result = DateTime.Now;
							num2 = array[311] - 53283;
							continue;
						case 9:
							num2 = k[171] - 4790;
							continue;
						case 3:
							num++;
							goto case 9;
						case 2:
							result = default(DateTime);
							num2 = k[509] - 2970;
							continue;
						default:
							goto IL_00e3;
						case 0:
						case 4:
							num2 = 10;
							goto IL_00f2;
						case 6:
							num2 = 10;
							goto IL_00f2;
						case 10:
							goto IL_00f2;
						case 7:
						case 8:
							goto end_IL_0114;
						case 5:
							return result;
						}
						break;
					}
					goto case 4u;
				case 0u:
					goto IL_00f2;
				case 7u:
					break;
					IL_00f2:
					switch (((short_0 ^ char_0) - 71) ^ num)
					{
					case 0:
						break;
					default:
						num3 = -525369236;
						continue;
					}
					goto default;
					IL_00e3:
					num3 = -2094233308;
					continue;
					IL_0013:
					num2 = num5;
					num3 = -850389367;
					continue;
					end_IL_0114:
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int n(ref DateTime dateTime_0, char char_0, int int_0)
	{
		int[] array = l.x;
		int result = default(int);
		int num5 = default(int);
		char[] k = default(char[]);
		int num4 = default(int);
		while (true)
		{
			int num = 1498294061;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x1EE65B49u) % 12u)
				{
				case 11u:
					num = 1634374985;
					continue;
				case 10u:
					num = ((int)num2 * -1144238943) ^ 0x430A2D99;
					continue;
				case 9u:
					while (true)
					{
						switch (num4)
						{
						case 8:
							break;
						case 14:
							result = dateTime_0.Hour;
							num4 = 6;
							goto case 6;
						case 6:
							num5++;
							num4 = array[109] - 54925;
							continue;
						case 12:
							result = dateTime_0.Month;
							num4 = k[38] - 47657;
							continue;
						case 11:
							num4 = 6;
							goto case 6;
						case 10:
							num4 = array[95] - 48770;
							continue;
						case 4:
						case 5:
							result = dateTime_0.Minute;
							num4 = k[486] - 61326;
							continue;
						case 3:
							result = dateTime_0.Day;
							num4 = 6;
							goto case 6;
						case 1:
							result = 14;
							num4 = 6;
							goto case 6;
						case 0:
							result = dateTime_0.Year;
							goto case 11;
						default:
							goto IL_00e2;
						case 2:
							goto IL_00ec;
						case 7:
							goto IL_014e;
						case 9:
						case 13:
							return result;
						}
						break;
					}
					goto case 11u;
				case 3u:
					goto IL_00ec;
				default:
					goto IL_0117;
				case 2u:
					goto IL_014e;
				case 8u:
					num4 = 7;
					num = (int)(num2 * 813093696) ^ -971071802;
					continue;
				case 7u:
					num = ((int)num2 * -1762122012) ^ 0x2BBAB4C0;
					continue;
				case 6u:
					num3 = 1;
					goto IL_0146;
				case 5u:
					num = ((int)num2 * -1043944659) ^ 0x3881D6D1;
					continue;
				case 4u:
					k = e.e.k;
					num = (int)(num2 * 1961112909) ^ -1791480181;
					continue;
				case 0u:
					break;
					IL_014e:
					num5 = 0;
					num4 = array[64] - 12652;
					num = 231085032;
					continue;
					IL_00ec:
					switch (((int_0 ^ char_0) - 60) ^ num5)
					{
					case 0:
						goto IL_0117;
					case 1:
						goto IL_011a;
					case 2:
						goto IL_011e;
					case 3:
						goto IL_012d;
					case 4:
						goto IL_0139;
					}
					num = 689088887;
					continue;
					IL_0139:
					num3 = array[197] - 40885;
					goto IL_0146;
					IL_012d:
					num3 = array[48] - 33530;
					goto IL_0146;
					IL_011e:
					num3 = array[302] - 22708;
					goto IL_0146;
					IL_011a:
					num3 = 12;
					goto IL_0146;
					IL_0117:
					num3 = 0;
					goto IL_0146;
					IL_0146:
					num4 = num3;
					num = 1110940060;
					continue;
					IL_00e2:
					num = 5462782;
					continue;
				}
				break;
			}
		}
	}

	static string smethod_0(string string_0)
	{
		return string_0.Trim();
	}

	static AssemblyName smethod_1(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}
}
