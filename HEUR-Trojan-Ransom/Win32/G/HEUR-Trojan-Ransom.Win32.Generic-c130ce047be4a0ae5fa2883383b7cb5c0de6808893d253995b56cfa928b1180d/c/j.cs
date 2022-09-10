using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

namespace c;

internal sealed class j
{
	internal sealed class a
	{
		internal short[] m;

		internal int y;

		internal bool i;

		internal int l;

		internal byte[] j;

		internal byte[] q;

		internal int d;

		internal int c;

		internal a()
		{
		}
	}

	public static byte[] c()
	{
		byte[] array = new byte[56336];
		j.smethod_0((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		return array;
	}

	[SecuritySafeCritical]
	internal static byte[] t<T>(T gparam_0, short short_0, short short_1) where T : AssemblyName
	{
		char[] k = e.e.k;
		int[] x = l.x;
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		Array array = default(Array);
		int num3 = default(int);
		while (true)
		{
			int num = 796910758;
			while (true)
			{
				uint num2;
				int num4;
				switch ((num2 = (uint)num ^ 0x64C24F4u) % 13u)
				{
				case 12u:
					switch (((short_0 ^ short_1) - 79) ^ num5)
					{
					default:
						num = 1716115240;
						continue;
					case 0:
						break;
					}
					goto default;
				default:
					num4 = 5;
					goto IL_002e;
				case 10u:
					while (true)
					{
						switch (num3)
						{
						case 1:
							break;
						case 10:
							num5++;
							num6 = 1900;
							goto case 8;
						case 8:
							num7 = 433;
							goto case 2;
						case 2:
							num3 = ((475 < num6 / 4 - num7) ? (x[230] - 54307) : (k[245] - 17391));
							continue;
						case 6:
							array = null;
							num3 = k[545] - 60854;
							continue;
						case 0:
						case 5:
							array = j.smethod_1((AssemblyName)gparam_0);
							num3 = 10;
							goto case 10;
						default:
							goto IL_00d2;
						case 3:
							num3 = 1;
							break;
						case 4:
							goto IL_00e0;
						case 9:
							goto IL_00e7;
						case 7:
							return array as byte[];
						}
						break;
					}
					goto case 12u;
				case 6u:
					goto IL_00e0;
				case 5u:
					goto IL_00e7;
				case 9u:
					num4 = 6;
					goto IL_002e;
				case 8u:
					num = ((int)num2 * -1529232545) ^ -329311202;
					continue;
				case 7u:
					num = (int)(num2 * 826240358) ^ -331037416;
					continue;
				case 3u:
					num3 = 9;
					num = (int)(num2 * 962845781) ^ -1891002585;
					continue;
				case 2u:
					num = ((int)num2 * -2004648576) ^ -422659695;
					continue;
				case 1u:
					num3 = 1;
					num = ((int)num2 * -1304494390) ^ 0xDBF9A6;
					continue;
				case 0u:
					num = ((int)num2 * -981860353) ^ 0xDE24209;
					continue;
				case 4u:
					break;
					IL_00e7:
					num5 = 0;
					num = 2107562281;
					continue;
					IL_00e0:
					num = 346169270;
					continue;
					IL_00d2:
					num = 1770598937;
					continue;
					IL_002e:
					num3 = num4;
					num = 564990237;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Stream u<T, U>(T gparam_0, U gparam_1, int int_0, short short_0) where T : Assembly where U : string
	{
		char[] k = e.e.k;
		int num4 = default(int);
		int[] x = default(int[]);
		object obj = default(object);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -80589830;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)num ^ 0xFAAC673Bu) % 12u)
				{
				case 11u:
					switch (((int_0 ^ short_0) - 64) ^ num4)
					{
					default:
						num = -898586761;
						continue;
					case 0:
						break;
					}
					goto default;
				default:
					num6 = k[171] - 4785;
					goto IL_0033;
				case 9u:
					x = l.x;
					num = ((int)num2 * -1994096440) ^ 0x2455FB38;
					continue;
				case 8u:
					num6 = 9;
					goto IL_0033;
				case 7u:
					while (true)
					{
						switch (num3)
						{
						case 4:
							break;
						case 2:
						case 6:
						case 10:
							obj = j.smethod_2((Assembly)gparam_0, (string)gparam_1);
							num3 = 5;
							goto case 5;
						case 5:
							num4++;
							num5 = short_0 * short_0;
							num5 = short_0 + num5;
							num3 = 7;
							goto case 7;
						case 7:
							num3 = ((num5 % 2 != 0) ? (k[267] - 51161) : (k[27] - 37406));
							continue;
						case 9:
							obj = null;
							num3 = x[275] - 4938;
							continue;
						case 1:
							num3 = x[24] - 41143;
							continue;
						default:
							goto IL_00fa;
						case 0:
							goto IL_0101;
						case 11:
							goto IL_0108;
						case 3:
						case 8:
							return (Stream)obj;
						}
						break;
					}
					goto case 11u;
				case 6u:
					goto IL_0101;
				case 4u:
					goto IL_0108;
				case 3u:
					num = ((int)num2 * -1373006571) ^ 0x71A71A70;
					continue;
				case 2u:
					num = ((int)num2 * -1526089269) ^ -993324946;
					continue;
				case 1u:
					num3 = 4;
					num = (int)(num2 * 1507942857) ^ -1335611847;
					continue;
				case 0u:
					num3 = 11;
					num = (int)((num2 * 950702150) ^ 0x338696A5);
					continue;
				case 5u:
					break;
					IL_0108:
					num4 = 0;
					num = -178860634;
					continue;
					IL_0101:
					num = -1151243513;
					continue;
					IL_00fa:
					num = -841372071;
					continue;
					IL_0033:
					num3 = num6;
					num = -1089053572;
					continue;
				}
				break;
			}
		}
	}

	static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	static byte[] smethod_1(AssemblyName assemblyName_0)
	{
		return assemblyName_0.GetPublicKey();
	}

	static Stream smethod_2(Assembly assembly_0, string string_0)
	{
		return assembly_0.GetManifestResourceStream(string_0);
	}
}
