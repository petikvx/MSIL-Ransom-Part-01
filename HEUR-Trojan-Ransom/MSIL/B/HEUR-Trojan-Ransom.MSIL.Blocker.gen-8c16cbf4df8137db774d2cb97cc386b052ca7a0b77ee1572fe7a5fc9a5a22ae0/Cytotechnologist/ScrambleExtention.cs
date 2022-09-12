using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		int index = default(int);
		int num3 = default(int);
		T value = default(T);
		while (true)
		{
			int num = -506838335;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFDE00E6Au) % 11u)
				{
				case 10u:
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					value = list[index];
					num = (int)((num2 * 176489639) ^ 0x3725A4B7);
					continue;
				case 9u:
					list[num3] = value;
					num = ((int)num2 * -580072766) ^ -2072092886;
					continue;
				case 8u:
					num = ((int)num2 * -1200917997) ^ -33022976;
					continue;
				case 7u:
					num3--;
					num = ((int)num2 * -1562074157) ^ 0x469CD8F;
					continue;
				case 5u:
					num = -1936483418;
					continue;
				case 4u:
					num3 = list.Count;
					num = (int)((num2 * 496323368) ^ 0x1C4AA016);
					continue;
				case 3u:
					num = (int)((num2 * 412741552) ^ 0x492A0156);
					continue;
				case 2u:
				{
					int num4;
					if (num3 <= 1)
					{
						num = -2127335441;
						num4 = -2127335441;
					}
					else
					{
						num = -379852911;
						num4 = -379852911;
					}
					continue;
				}
				case 1u:
					list[index] = list[num3];
					num = (int)(num2 * 1267151156) ^ -1329983029;
					continue;
				default:
					return;
				case 0u:
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
