using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		int num = list.Count;
		bool flag = default(bool);
		T value = default(T);
		while (true)
		{
			int num2 = -645587971;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xE729F2ACu) % 9u)
				{
				case 8u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 930883350;
						num5 = 930883350;
					}
					else
					{
						num4 = 312180996;
						num5 = 312180996;
					}
					num2 = num4 ^ ((int)num3 * -1884396147);
					continue;
				}
				case 6u:
				{
					num--;
					int index = ScrambleExtention.smethod_0(Random, num + 1);
					value = list[index];
					list[index] = list[num];
					num2 = ((int)num3 * -787115104) ^ 0x5172478B;
					continue;
				}
				case 5u:
					num2 = (int)((num3 * 594338999) ^ 0x135CCD61);
					continue;
				case 4u:
					flag = num > 1;
					num2 = -636505118;
					continue;
				case 3u:
					num2 = -224921434;
					continue;
				case 2u:
					num2 = ((int)num3 * -548498164) ^ -2087756436;
					continue;
				case 1u:
					list[num] = value;
					num2 = ((int)num3 * -997974306) ^ 0x5BD381B9;
					continue;
				default:
					return;
				case 7u:
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
