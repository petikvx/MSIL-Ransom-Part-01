using System;
using System.Reflection;
using System.Security;

namespace c;

internal sealed class n
{
	internal sealed class u
	{
		internal byte[] t;

		internal int s;

		internal int f;

		internal u()
		{
		}
	}

	internal sealed class l
	{
		internal short[] w;

		internal byte[] n;

		internal l()
		{
		}
	}

	public static void g()
	{
		try
		{
			c.r.v();
		}
		catch (Exception)
		{
		}
	}

	[SecuritySafeCritical]
	internal static object r<T, U>(T gparam_0, U gparam_1, object[] object_0, short short_0, short short_1) where T : MethodBase
	{
		int[] x = c.l.x;
		char[] k = default(char[]);
		object result = default(object);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -1377717657;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x84BDCEB3u) % 12u)
				{
				case 10u:
					num4 = x[294] - 8144;
					num = -1201366811;
					continue;
				case 9u:
					goto IL_0024;
				default:
					num3 = k[314] - 29857;
					goto IL_004d;
				case 8u:
					goto IL_0059;
				case 7u:
					while (true)
					{
						switch (num4)
						{
						case 8:
							break;
						case 5:
							goto IL_0024;
						case 7:
							goto IL_0059;
						case 10:
						case 11:
							num4 = x[311] - 53281;
							continue;
						default:
							goto IL_00ab;
						case 6:
							num4 = 5;
							goto IL_0024;
						case 0:
						case 1:
						case 3:
							result = n.smethod_0((MethodBase)gparam_0, (object)gparam_1, object_0);
							num4 = 2;
							goto case 2;
						case 4:
							result = null;
							num4 = 2;
							goto case 2;
						case 2:
							num5++;
							num4 = 9;
							goto case 9;
						case 9:
							return result;
						}
						break;
					}
					goto case 10u;
				case 5u:
					num = (int)(num2 * 1119456573) ^ -681722459;
					continue;
				case 4u:
					k = e.e.k;
					num = (int)((num2 * 1339778538) ^ 0x76805E3E);
					continue;
				case 3u:
					num4 = 5;
					num = ((int)num2 * -76844808) ^ -290040632;
					continue;
				case 2u:
					num = ((int)num2 * -751770740) ^ -1358565976;
					continue;
				case 1u:
					num = (int)((num2 * 348992210) ^ 0x178A3D21);
					continue;
				case 0u:
					num3 = 4;
					goto IL_004d;
				case 11u:
					break;
					IL_00ab:
					num = -1753157235;
					continue;
					IL_0059:
					num5 = 0;
					num = -552922400;
					continue;
					IL_0024:
					switch (((short_0 ^ short_1) - 9) ^ num5)
					{
					default:
						num = -1830562765;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_004d:
					num4 = num3;
					num = -1908074022;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string[] q<T>(T gparam_0, char[] char_0, int int_0, int int_1) where T : string
	{
		int[] x = c.l.x;
		char[] k = e.e.k;
		Array array = default(Array);
		int num6 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			int num3 = -1328174920;
			while (true)
			{
				uint num4;
				int num5;
				switch ((num4 = (uint)num3 ^ 0xF5D3ABFFu) % 11u)
				{
				case 10u:
					while (true)
					{
						switch (num2)
						{
						case 5:
						case 11:
							array = n.smethod_1((string)gparam_0, char_0);
							num2 = k[201] - 45892;
							continue;
						case 2:
						case 6:
							num++;
							num6 = 1838;
							goto case 3;
						case 3:
						{
							int num7 = num6;
							if ((num7 * num7 + num6) % 2 != 0)
							{
								num2 = k[448] - 50361;
								continue;
							}
							num2 = 9;
							goto case 9;
						}
						case 0:
							array = null;
							num2 = 6;
							goto case 2;
						case 7:
							num2 = 1;
							goto IL_00a7;
						case 8:
							num2 = 1;
							goto IL_00a7;
						case 1:
							goto IL_00a7;
						case 10:
							goto IL_00fd;
						case 4:
							goto end_IL_016c;
						case 9:
							return array as string[];
						}
						break;
					}
					num3 = -1822780196;
					continue;
				case 1u:
					goto IL_00a7;
				default:
				{
					int num8 = x[274];
					e.e.k[555] = (char)((e.e.k[555] - c.l.x[339]) & '\'');
					num5 = num8 - 32540;
					goto IL_00f5;
				}
				case 9u:
					goto IL_00fd;
				case 8u:
					num3 = -1863307577;
					continue;
				case 6u:
					num3 = ((int)num4 * -501259675) ^ 0xCC957C4;
					continue;
				case 5u:
					num5 = x[236] - x[236];
					goto IL_00f5;
				case 3u:
					num2 = x[109] - 54934;
					num3 = ((int)num4 * -1690152203) ^ 0x7BE536BD;
					continue;
				case 2u:
					num3 = (int)(num4 * 930052735) ^ -1832531506;
					continue;
				case 0u:
					num3 = (int)(num4 * 1754846834) ^ -495628041;
					continue;
				case 4u:
					break;
					IL_00fd:
					num3 = -558460915;
					continue;
					IL_00a7:
					switch (((int_0 ^ int_1) - 89) ^ num)
					{
					default:
						num3 = -1035188555;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_00f5:
					num2 = num5;
					num3 = -1003052664;
					continue;
					end_IL_016c:
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool p<T, U>(T gparam_0, U gparam_1, short short_0, int int_0) where T : string where U : string
	{
		int[] x = c.l.x;
		char[] k = default(char[]);
		int num4 = default(int);
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 1876699388;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)num ^ 0x740F30A7u) % 12u)
				{
				case 11u:
					k = e.e.k;
					num = (int)(num2 * 982165720) ^ -1373131965;
					continue;
				case 10u:
					num4 = 0;
					num = 1595107550;
					continue;
				default:
					num6 = x[310] - 18338;
					goto IL_003d;
				case 8u:
					num = (int)(num2 * 1901470525) ^ -1175628839;
					continue;
				case 7u:
					num = ((int)num2 * -364874547) ^ -1687195330;
					continue;
				case 6u:
					goto IL_006c;
				case 5u:
					num = (int)(num2 * 277283310) ^ -1383734949;
					continue;
				case 3u:
					num6 = k[27] - 37405;
					goto IL_003d;
				case 2u:
					while (true)
					{
						switch (num3)
						{
						case 3:
							break;
						case 0:
							goto IL_006c;
						case 9:
							result = true;
							num3 = k[415] - 21233;
							continue;
						default:
							goto IL_00ed;
						case 1:
						case 5:
							goto IL_00f4;
						case 2:
						case 8:
							result = n.smethod_2((string)gparam_0, (string)gparam_1);
							num3 = 7;
							goto case 7;
						case 7:
						{
							num4++;
							int num5 = short_0 * short_0;
							c.l.x[263] = (c.l.x[263] - c.l.x[227]) & 0x1B;
							if ((num5 + short_0) % 2 != 0)
							{
								num3 = 6;
								goto case 6;
							}
							num3 = 11;
							goto case 4;
						}
						case 6:
							num3 = 0;
							goto IL_006c;
						case 10:
							num3 = 0;
							goto IL_006c;
						case 4:
						case 11:
							return result;
						}
						break;
					}
					goto case 10u;
				case 0u:
					goto IL_00f4;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1771760319) ^ 0x1C149214;
					continue;
				case 4u:
					break;
					IL_00f4:
					num3 = x[271] - 2085;
					num = 770243192;
					continue;
					IL_00ed:
					num = 132508963;
					continue;
					IL_006c:
					switch (((int_0 ^ short_0) - 118) ^ num4)
					{
					case 0:
						break;
					default:
						num = 617883096;
						continue;
					}
					goto default;
					IL_003d:
					num3 = num6;
					num = 236283706;
					continue;
				}
				break;
			}
		}
	}

	static object smethod_0(MethodBase methodBase_0, object object_0, object[] object_1)
	{
		return methodBase_0.Invoke(object_0, object_1);
	}

	static string[] smethod_1(string string_0, char[] char_0)
	{
		return string_0.Split(char_0);
	}

	static bool smethod_2(string string_0, string string_1)
	{
		return string_0 == string_1;
	}
}
