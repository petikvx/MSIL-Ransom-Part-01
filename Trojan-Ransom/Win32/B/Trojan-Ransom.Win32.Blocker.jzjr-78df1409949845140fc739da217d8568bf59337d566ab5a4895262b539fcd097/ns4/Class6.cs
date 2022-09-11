using System;
using System.Collections.Generic;
using ns0;

namespace ns4;

internal sealed class Class6
{
	public delegate void Delegate0();

	private static List<Delegate0> list_0;

	private static Random random_0;

	private unsafe static void smethod_0(ref List<Delegate0> list_1)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = list_1.Count;
		Delegate0 value = default(Delegate0);
		while (true)
		{
			int num = -140793191;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(473669776 - (num2 ^ -637531228)))) % 6u)
				{
				case 3u:
					list_1[*(int*)ptr] = value;
					num = ((int)num3 * -869571007) ^ -1528346949;
					continue;
				case 2u:
					(*(int*)ptr)--;
					*(int*)((byte*)ptr + 4) = random_0.Next(*(int*)ptr + 1);
					value = list_1[*(int*)((byte*)ptr + 4)];
					list_1[*(int*)((byte*)ptr + 4)] = list_1[*(int*)ptr];
					num = -502151637;
					continue;
				case 1u:
					num = (int)((num3 * 698682294) ^ 0x100BA9FA);
					continue;
				case 0u:
				{
					int num4;
					if (*(int*)ptr <= 1)
					{
						num = -1792905719;
						num4 = -1792905719;
					}
					else
					{
						num = -2014058400;
						num4 = -2014058400;
					}
					continue;
				}
				default:
					return;
				case 4u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	static Class6()
	{
		list_0 = new List<Delegate0>();
		random_0 = new Random();
		list_0.Add(Form1.smethod_0);
		list_0.Add(Form1.smethod_3);
		list_0.Add(Form1.smethod_1);
		list_0.Add(Form1.smethod_5);
		list_0.Add(Form1.smethod_4);
		smethod_0(ref list_0);
	}

	public static void smethod_1(int[] int_0)
	{
		try
		{
			int num = 0;
			while (true)
			{
				int num2;
				int num3;
				if (num < list_0.Count)
				{
					num2 = 1315014991;
					num3 = 1315014991;
				}
				else
				{
					num2 = 1766824572;
					num3 = 1766824572;
				}
				while (true)
				{
					int num4 = num2;
					uint num5;
					switch ((num5 = (uint)(-(num4 * 630079063 - 489228318))) % 4u)
					{
					case 3u:
						num2 = 1315014991;
						continue;
					case 1u:
						list_0[int_0[num]]();
						num++;
						num2 = -245433242;
						continue;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}
		catch
		{
		}
	}
}
