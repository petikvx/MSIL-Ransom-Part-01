using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		int num3 = default(int);
		T value = default(T);
		int index = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 784041196;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC35518Au) % 13u)
				{
				case 11u:
					num = ((int)num2 * -1189793064) ^ 0x2EEFDC13;
					continue;
				case 10u:
					num = ((int)num2 * -2115914792) ^ -574802484;
					continue;
				case 9u:
					num3 = list.Count;
					num = (int)(num2 * 71935025) ^ -296016110;
					continue;
				case 8u:
					num = 2068809504;
					continue;
				case 7u:
					num3--;
					num = ((int)num2 * -3007307) ^ 0x3E1128B;
					continue;
				case 6u:
					list[num3] = value;
					num = (int)((num2 * 1795542741) ^ 0x107CF994);
					continue;
				case 5u:
					value = list[index];
					num = ((int)num2 * -1936771682) ^ 0xCCCC96E;
					continue;
				case 4u:
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					num = (int)(num2 * 703729754) ^ -184088685;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 858831248;
						num5 = 858831248;
					}
					else
					{
						num4 = 1704495923;
						num5 = 1704495923;
					}
					num = num4 ^ ((int)num2 * -509292137);
					continue;
				}
				case 1u:
					flag = num3 > 1;
					num = 1659791683;
					continue;
				case 0u:
					list[index] = list[num3];
					num = ((int)num2 * -453400578) ^ 0x790ED2AB;
					continue;
				default:
					return;
				case 2u:
					break;
				case 12u:
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
