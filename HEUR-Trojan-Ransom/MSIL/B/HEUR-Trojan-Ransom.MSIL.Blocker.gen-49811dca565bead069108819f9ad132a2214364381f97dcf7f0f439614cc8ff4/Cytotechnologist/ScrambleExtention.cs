using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		int num = list.Count;
		T value = default(T);
		bool flag = default(bool);
		int index = default(int);
		while (true)
		{
			int num2 = 897420260;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x3ECC0DC8u) % 10u)
				{
				case 9u:
					list[num] = value;
					num2 = (int)(num3 * 1504549103) ^ -736629980;
					continue;
				case 8u:
					num2 = 1181648666;
					continue;
				case 6u:
					num2 = (int)(num3 * 120218231) ^ -938945495;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -135171383;
						num5 = -135171383;
					}
					else
					{
						num4 = -1179646240;
						num5 = -1179646240;
					}
					num2 = num4 ^ (int)(num3 * 1154183166);
					continue;
				}
				case 4u:
					list[index] = list[num];
					num2 = ((int)num3 * -1878314651) ^ -2105764667;
					continue;
				case 2u:
					value = list[index];
					num2 = (int)(num3 * 1784574229) ^ -1769225966;
					continue;
				case 1u:
					flag = num > 1;
					num2 = 1157763645;
					continue;
				case 0u:
					num--;
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = (int)((num3 * 1227455421) ^ 0x4813096A);
					continue;
				default:
					return;
				case 3u:
					break;
				case 7u:
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
