using System;
using System.Reflection;
using System.Security;
using System.Text;

namespace c;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method)]
internal sealed class g : Attribute
{
	[SecuritySafeCritical]
	internal static string n<T>(T gparam_0, short short_0, short short_1) where T : ResolveEventArgs
	{
		int[] array = l.x;
		char[] k = default(char[]);
		IComparable comparable = default(IComparable);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -576174177;
			while (true)
			{
				uint num2;
				int num4;
				switch ((num2 = (uint)num ^ 0xC61C5F29u) % 12u)
				{
				case 11u:
					while (true)
					{
						switch (num3)
						{
						case 8:
							num3 = k[547] - 42040;
							continue;
						case 7:
							comparable = g.smethod_0((ResolveEventArgs)gparam_0);
							num3 = k[493] - 35936;
							continue;
						case 2:
							num3 = k[591] - 51158;
							continue;
						case 0:
							goto IL_0086;
						case 1:
							goto IL_00a1;
						case 6:
							goto IL_00ab;
						case 5:
						case 9:
						case 10:
							comparable = null;
							num3 = 3;
							goto case 3;
						case 3:
							num5++;
							goto case 11;
						case 11:
							num3 = 4;
							goto case 4;
						case 4:
							return comparable as string;
						}
						break;
					}
					num = -2106655736;
					continue;
				case 4u:
					goto IL_0086;
				case 9u:
					goto IL_00a1;
				case 8u:
					goto IL_00ab;
				default:
					num4 = 7;
					goto IL_00c5;
				case 10u:
					num = ((int)num2 * -763149712) ^ -1730133538;
					continue;
				case 7u:
					num4 = array[271] - 2079;
					goto IL_00c5;
				case 6u:
					num3 = array[196] - 2554;
					num = ((int)num2 * -116376933) ^ 0xB97A334;
					continue;
				case 3u:
					num = ((int)num2 * -413031226) ^ 0x43391D6C;
					continue;
				case 2u:
					k = e.e.k;
					num = (int)((num2 * 1653039846) ^ 0x168F4A30);
					continue;
				case 1u:
					num = (int)(num2 * 1903456164) ^ -911859903;
					continue;
				case 0u:
					break;
					IL_00ab:
					switch (((short_0 ^ short_1) - 42) ^ num5)
					{
					default:
						num = -1654769106;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_00c5:
					num3 = num4;
					num = -2052394153;
					continue;
					IL_00a1:
					num = -2054902029;
					continue;
					IL_0086:
					num5 = 0;
					num3 = k[161] - 38118;
					num = -1069698306;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte[] a<T, U>(T gparam_0, U gparam_1, int int_0, short short_0) where T : Encoding where U : string
	{
		int[] array = l.x;
		int num6 = default(int);
		object obj = default(object);
		int num5 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = -556608858;
			while (true)
			{
				uint num3;
				int num4;
				switch ((num3 = (uint)num2 ^ 0xF809A2A3u) % 10u)
				{
				case 9u:
					num5 = array[121] - 14827;
					num2 = ((int)num3 * -332936605) ^ 0x11AD59AE;
					continue;
				case 8u:
					while (true)
					{
						switch (num5)
						{
						case 11:
							num5 = array[157] - 19140;
							continue;
						case 9:
							num5 = array[240] - 46426;
							continue;
						case 8:
							num++;
							num6 = 107;
							goto case 0;
						case 0:
							if (1064 <= 133 - num6 * 8)
							{
								num5 = 11;
								goto case 11;
							}
							num5 = 1;
							goto case 1;
						case 7:
							obj = g.smethod_1((Encoding)gparam_0, (string)gparam_1);
							num5 = 8;
							goto case 8;
						case 4:
							obj = null;
							num5 = 8;
							goto case 8;
						case 3:
							goto IL_00c4;
						case 6:
							goto IL_00cb;
						case 5:
						case 10:
							goto end_IL_0136;
						case 1:
						case 2:
							return (byte[])obj;
						}
						break;
					}
					num2 = -750049628;
					continue;
				case 3u:
					goto IL_00c4;
				case 1u:
					goto IL_00cb;
				default:
					num4 = array[277] - 53067;
					goto IL_00f0;
				case 7u:
					num5 = array[123] - 45948;
					num2 = (int)((num3 * 1209514376) ^ 0x4618D4B9);
					continue;
				case 6u:
					num2 = (int)(num3 * 1987054833) ^ -1573359303;
					continue;
				case 5u:
					num2 = -877782463;
					continue;
				case 4u:
					num4 = 4;
					goto IL_00f0;
				case 0u:
					break;
					IL_00cb:
					switch (((short_0 ^ int_0) - 65) ^ num)
					{
					default:
						num2 = -353823451;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_00f0:
					num5 = num4;
					num2 = -1543921573;
					continue;
					IL_00c4:
					num2 = -748872532;
					continue;
					end_IL_0136:
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly x(short short_0, short short_1)
	{
		int[] array = l.x;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 7;
			int num3 = -2048085313;
			while (true)
			{
				uint num4;
				int num5;
				switch ((num4 = (uint)num3 ^ 0x8535152Cu) % 9u)
				{
				case 8u:
					num3 = -347676966;
					continue;
				case 7u:
					num3 = ((int)num4 * -1815386307) ^ 0x4094550B;
					continue;
				case 5u:
					num5 = 4;
					goto IL_0028;
				default:
					num5 = 2;
					goto IL_0028;
				case 3u:
					num3 = ((int)num4 * -1132019825) ^ 0x63CB96C7;
					continue;
				case 2u:
					while (true)
					{
						switch (num2)
						{
						case 4:
						case 8:
						case 11:
							obj = null;
							num2 = array[262] - 6587;
							continue;
						case 0:
							goto IL_0093;
						case 3:
							num2 = 7;
							goto IL_00a2;
						case 9:
							num2 = 7;
							goto IL_00a2;
						case 7:
							goto IL_00a2;
						case 1:
							goto end_IL_00c3;
						case 2:
							obj = g.smethod_2();
							num2 = 6;
							goto case 6;
						case 6:
							num++;
							num2 = 5;
							goto case 5;
						case 5:
						case 10:
							return (Assembly)obj;
						}
						break;
					}
					num3 = -1100630735;
					continue;
				case 1u:
					goto IL_0093;
				case 0u:
					goto IL_00a2;
				case 6u:
					break;
					IL_00a2:
					switch (((short_1 ^ short_0) - 57) ^ num)
					{
					case 0:
						break;
					default:
						num3 = -1237219766;
						continue;
					}
					goto default;
					IL_0093:
					num2 = 1;
					num3 = -347676966;
					continue;
					IL_0028:
					num2 = num5;
					num3 = -639879927;
					continue;
					end_IL_00c3:
					break;
				}
				break;
			}
		}
	}

	static string smethod_0(ResolveEventArgs resolveEventArgs_0)
	{
		return resolveEventArgs_0.Name;
	}

	static byte[] smethod_1(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	static Assembly smethod_2()
	{
		return Assembly.GetExecutingAssembly();
	}
}
