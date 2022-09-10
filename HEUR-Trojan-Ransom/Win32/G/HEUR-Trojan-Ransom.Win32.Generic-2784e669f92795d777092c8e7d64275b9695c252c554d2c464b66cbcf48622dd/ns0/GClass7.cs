using System;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

public class GClass7
{
	[DebuggerNonUserCode]
	public GClass7()
	{
		smethod_1(this);
	}

	public static byte[] smethod_0(object object_0)
	{
		checked
		{
			long num;
			long num2 = default(long);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			while (true)
			{
				IL_0001:
				num = 1L;
				_ = 1;
				if (!smethod_6())
				{
					while (true)
					{
						num2 = 0L;
						if (smethod_5())
						{
							switch (14)
							{
							case 10:
								break;
							case 1:
							case 9:
								continue;
							case 14:
								num3 = 0;
								goto case 19;
							case 19:
								num4 = ((Array)object_0).Length;
								goto IL_0124;
							case 5:
								goto IL_00ad;
							case 0:
								goto IL_00b1;
							case 20:
								goto IL_00b7;
							case 11:
								goto IL_00bd;
							default:
								goto IL_00d5;
							case 7:
								goto IL_00de;
							case 4:
								goto IL_00e5;
							case 8:
								goto IL_00e9;
							case 12:
								goto IL_00f4;
							case 2:
								goto IL_010c;
							case 18:
								goto IL_0118;
							case 13:
							case 15:
								goto IL_0124;
							case 16:
								goto IL_014f;
							case 3:
							case 6:
							case 21:
								goto end_IL_0017;
							case 22:
								goto end_IL_0001;
							}
							goto IL_0001;
						}
						break;
						continue;
						end_IL_0017:
						break;
					}
				}
				goto IL_0156;
				IL_00b1:
				num5++;
				goto IL_00b7;
				IL_0156:
				if (num6 >= 16)
				{
					num5 = 0;
					goto IL_00bd;
				}
				goto IL_00de;
				IL_00de:
				if (num6 != 0)
				{
					goto IL_00f4;
				}
				goto IL_010c;
				IL_00f4:
				num += ((byte[])object_0)[unchecked(0 - ((num3 == checked(num3 + 1)) ? 1 : 0))] & 0xFF;
				goto IL_00e5;
				IL_00e5:
				num2 += num;
				goto IL_00e9;
				IL_00e9:
				if (-(-num6) != 0)
				{
					goto IL_00f4;
				}
				goto IL_010c;
				IL_010c:
				num = unchecked(num % 65521L);
				goto IL_0118;
				IL_0118:
				num2 = unchecked(num2 % 65521L);
				goto IL_0124;
				IL_0124:
				if (num4 <= 0)
				{
					break;
				}
				num6 = smethod_3(smethod_2(num4 < 5552, num4, 5552));
				goto IL_014f;
				IL_00d5:
				num6 -= 16;
				goto IL_0156;
				IL_014f:
				num4 -= num6;
				goto IL_0156;
				IL_00b7:
				if (num5 <= 15)
				{
					goto IL_00bd;
				}
				goto IL_00d5;
				IL_00bd:
				num += ((byte[])object_0)[unchecked(0 - ((num3 == checked(num3 + 1)) ? 1 : 0))] & 0xFF;
				goto IL_00ad;
				IL_00ad:
				num2 += num;
				goto IL_00b1;
				continue;
				end_IL_0001:
				break;
			}
			return (byte[])smethod_4((num2 << 16) | num);
		}
	}

	internal static void smethod_1(object object_0)
	{
		object_0._002Ector();
	}

	internal static object smethod_2(bool bool_0, object object_0, object object_1)
	{
		return Interaction.IIf(bool_0, object_0, object_1);
	}

	internal static int smethod_3(object object_0)
	{
		return Conversions.ToInteger(object_0);
	}

	internal static object smethod_4(long long_0)
	{
		return BitConverter.GetBytes(long_0);
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static bool smethod_6()
	{
		return false;
	}
}
