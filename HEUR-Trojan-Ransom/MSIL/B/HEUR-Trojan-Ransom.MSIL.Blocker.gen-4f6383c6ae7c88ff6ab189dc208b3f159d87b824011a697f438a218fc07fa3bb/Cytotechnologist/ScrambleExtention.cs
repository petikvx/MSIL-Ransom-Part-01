using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		int num = list.Count;
		int index = default(int);
		T value = default(T);
		while (true)
		{
			bool flag = num > 1;
			int num2 = 1940624384;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x335A1A4Fu) % 11u)
				{
				case 10u:
					num--;
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = ((int)num3 * -470733608) ^ 0x51FEB49;
					continue;
				case 9u:
					value = list[index];
					list[index] = list[num];
					num2 = ((int)num3 * -590520179) ^ 0x182FA8DF;
					continue;
				case 8u:
					num2 = (int)((num3 * 1825957741) ^ 0x561473EC);
					continue;
				case 7u:
					list[num] = value;
					num2 = (int)(num3 * 1527469279) ^ -438092685;
					continue;
				case 6u:
					num2 = (int)(num3 * 2011746705) ^ -49120813;
					continue;
				case 4u:
					num2 = 1674460389;
					continue;
				case 3u:
					num2 = 1793921667;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -646122415;
						num5 = -646122415;
					}
					else
					{
						num4 = -1352552369;
						num5 = -1352552369;
					}
					num2 = num4 ^ ((int)num3 * -1989019594);
					continue;
				}
				case 1u:
					num2 = (int)((num3 * 1608953008) ^ 0x2A1446E7);
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
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
