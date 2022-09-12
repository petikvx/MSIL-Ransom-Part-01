using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		int num3 = default(int);
		int index = default(int);
		T value = default(T);
		bool flag = default(bool);
		while (true)
		{
			int num = 1745136704;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x50C11C88u) % 12u)
				{
				case 11u:
					num = ((int)num2 * -1973939857) ^ 0x65AC6B64;
					continue;
				case 9u:
					num = ((int)num2 * -1610398480) ^ -1311511104;
					continue;
				case 8u:
					num3 = list.Count;
					num = ((int)num2 * -447554348) ^ 0x30BBFD37;
					continue;
				case 7u:
					list[index] = list[num3];
					num = (int)((num2 * 1360150264) ^ 0x57AA8003);
					continue;
				case 6u:
					value = list[index];
					num = ((int)num2 * -1237454196) ^ 0x38CF46C3;
					continue;
				case 5u:
					num3--;
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					num = 1649603514;
					continue;
				case 4u:
					num = (int)(num2 * 1039995522) ^ -1503009435;
					continue;
				case 3u:
					list[num3] = value;
					num = (int)(num2 * 55369261) ^ -1026615834;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1597575043;
						num5 = -1597575043;
					}
					else
					{
						num4 = -1610330720;
						num5 = -1610330720;
					}
					num = num4 ^ ((int)num2 * -1708861292);
					continue;
				}
				case 1u:
					flag = num3 > 1;
					num = 986780178;
					continue;
				default:
					return;
				case 10u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	static int smethod_0(Random random_0, int int_0)
	{
		return random_0.Next(int_0);
	}

	static Random smethod_1()
	{
		return new Random();
	}
}
