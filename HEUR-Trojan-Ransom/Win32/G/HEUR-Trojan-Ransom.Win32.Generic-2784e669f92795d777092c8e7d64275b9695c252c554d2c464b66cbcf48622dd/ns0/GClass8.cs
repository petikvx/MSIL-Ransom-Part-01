using System;
using System.Diagnostics;
using System.IO;

namespace ns0;

public class GClass8
{
	[DebuggerNonUserCode]
	public GClass8()
	{
		smethod_1(this);
	}

	public static byte[] smethod_0(object object_0)
	{
		_ = 1;
		if (!smethod_6())
		{
			goto IL_00b0;
		}
		int num = 23;
		if (smethod_6())
		{
			goto IL_008a;
		}
		goto IL_00ed;
		IL_01b3:
		int[] array = default(int[]);
		int num3 = default(int);
		int num2 = num2 ^ array[num3];
		goto IL_01bc;
		IL_00ed:
		int num5 = default(int);
		int num6 = default(int);
		byte[] array2 = default(byte[]);
		int int_ = default(int);
		int num4 = default(int);
		checked
		{
			while (true)
			{
				switch (num)
				{
				case 29:
					break;
				default:
					goto IL_0029;
				case 15:
					goto IL_003c;
				case 7:
					goto IL_0047;
				case 22:
					goto IL_004c;
				case 5:
				case 26:
					goto IL_006e;
				case 2:
					goto IL_0074;
				case 14:
					goto IL_0079;
				case 12:
					goto IL_0084;
				case 13:
					goto IL_008a;
				case 11:
					goto IL_0090;
				case 24:
					goto IL_0099;
				case 0:
				case 17:
					goto IL_00b0;
				case 9:
					num5 ^= num6;
					num = 5;
					if (smethod_6())
					{
					}
					continue;
				case 3:
					num5 = (int)(unchecked((num5 & -2) / 2L) & 0x7FFFFFFFL);
					goto case 9;
				case 1:
					array2 = new byte[1025];
					goto case 19;
				case 19:
					int_ = 1024;
					goto case 20;
				case 20:
					num4 = ((Array)object_0).Length;
					goto IL_01d0;
				case 16:
					goto IL_019d;
				case 4:
					goto IL_01b3;
				case 18:
					goto IL_01bc;
				case 27:
					goto IL_01c4;
				case 6:
				case 8:
				case 25:
					goto IL_01d0;
				case 10:
				case 21:
				case 23:
					goto IL_01dc;
				case 30:
					goto IL_01e4;
				}
				break;
			}
			goto IL_0021;
		}
		IL_008a:
		int num7 = checked(num7 + 1);
		goto IL_0090;
		IL_0084:
		array[num7] = num5;
		goto IL_008a;
		IL_0029:
		num2 = -1;
		num = 1;
		if (!smethod_5())
		{
			goto IL_003c;
		}
		goto IL_00ed;
		IL_0021:
		MemoryStream object_ = new MemoryStream((byte[])object_0);
		goto IL_0029;
		IL_0090:
		if (num7 > 255)
		{
			goto IL_0021;
		}
		goto IL_0099;
		IL_00b0:
		num6 = -306674912;
		goto IL_003c;
		IL_003c:
		array = new int[257];
		goto IL_0047;
		IL_0047:
		num7 = 0;
		goto IL_0099;
		IL_0099:
		num5 = num7;
		goto IL_004c;
		IL_004c:
		int num8 = 8;
		goto IL_0079;
		IL_0079:
		checked
		{
			if ((num5 & 1) == 0)
			{
				num5 = (int)(unchecked((num5 & -2) / 2L) & 0x7FFFFFFFL);
				goto IL_006e;
			}
			num = 3;
			if (!smethod_6())
			{
				goto IL_00ed;
			}
			goto IL_01dc;
		}
		IL_01bc:
		int num9 = checked(num9 + 1);
		goto IL_01dc;
		IL_01dc:
		int num10 = default(int);
		if (num9 <= num10)
		{
			num3 = (num2 & 0xFF) ^ array2[num9];
			goto IL_019d;
		}
		goto IL_01c4;
		IL_01c4:
		num4 = smethod_2(object_, array2, 0, int_);
		goto IL_01d0;
		IL_01d0:
		if (num4 > 0)
		{
			num10 = checked(num4 - 1);
			num9 = 0;
			goto IL_01dc;
		}
		goto IL_01e4;
		IL_0074:
		if (num8 >= 1)
		{
			goto IL_0079;
		}
		goto IL_0084;
		IL_01e4:
		return (byte[])smethod_4(smethod_3(~num2));
		IL_006e:
		num8 = checked(num8 + -1);
		goto IL_0074;
		IL_019d:
		num2 = ((num2 & -256) / 256) & 0xFFFFFF;
		goto IL_01b3;
	}

	internal static void smethod_1(object object_0)
	{
		object_0._002Ector();
	}

	internal static int smethod_2(object object_0, object object_1, int int_0, int int_1)
	{
		return ((MemoryStream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static object smethod_3(int int_0)
	{
		return BitConverter.GetBytes(int_0);
	}

	internal static object smethod_4(object object_0)
	{
		return GClass4.smethod_3(object_0);
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
