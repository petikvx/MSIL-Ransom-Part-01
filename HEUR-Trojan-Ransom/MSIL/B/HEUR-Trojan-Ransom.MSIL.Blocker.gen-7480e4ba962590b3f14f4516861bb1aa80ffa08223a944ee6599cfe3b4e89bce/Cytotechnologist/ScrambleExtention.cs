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
			int num = -1687977893;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB49F42BDu) % 11u)
				{
				case 10u:
					num3--;
					num = -371924999;
					continue;
				case 9u:
					num = (int)(num2 * 1195081473) ^ -1315002097;
					continue;
				case 8u:
					num = ((int)num2 * -9601140) ^ -889159054;
					continue;
				case 7u:
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					value = list[index];
					num = ((int)num2 * -890563857) ^ -1038422040;
					continue;
				case 4u:
					num3 = list.Count;
					num = ((int)num2 * -951758421) ^ -2144078008;
					continue;
				case 3u:
					flag = num3 > 1;
					num = -1159999803;
					continue;
				case 2u:
					list[num3] = value;
					num = (int)((num2 * 1784848270) ^ 0x1B4F80E6);
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1577172914;
						num5 = -1577172914;
					}
					else
					{
						num4 = -1769559621;
						num5 = -1769559621;
					}
					num = num4 ^ ((int)num2 * -1644618796);
					continue;
				}
				case 0u:
					list[index] = list[num3];
					num = (int)((num2 * 1501964336) ^ 0x745E1AD2);
					continue;
				default:
					return;
				case 5u:
					break;
				case 6u:
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
