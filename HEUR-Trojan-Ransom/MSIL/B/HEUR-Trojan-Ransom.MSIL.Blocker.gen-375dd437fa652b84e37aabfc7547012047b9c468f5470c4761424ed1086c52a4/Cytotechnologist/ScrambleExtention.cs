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
			int num2 = 1615949292;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x89D2CBBu) % 12u)
				{
				case 11u:
					num2 = ((int)num3 * -2015344861) ^ 0x3DD6A328;
					continue;
				case 9u:
					num--;
					num2 = ((int)num3 * -1691096778) ^ -1683573550;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 468290829;
						num5 = 468290829;
					}
					else
					{
						num4 = 1400370267;
						num5 = 1400370267;
					}
					num2 = num4 ^ (int)(num3 * 1868822214);
					continue;
				}
				case 6u:
					num2 = 1324135618;
					continue;
				case 5u:
					list[index] = list[num];
					num2 = (int)((num3 * 730728839) ^ 0x5197153B);
					continue;
				case 4u:
					num2 = ((int)num3 * -104612777) ^ -629356215;
					continue;
				case 3u:
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = (int)(num3 * 1790764119) ^ -768444885;
					continue;
				case 2u:
					list[num] = value;
					num2 = ((int)num3 * -1567866692) ^ 0x2D1D9E1B;
					continue;
				case 1u:
					value = list[index];
					num2 = ((int)num3 * -245064822) ^ -196735028;
					continue;
				case 0u:
					num2 = 18798353;
					continue;
				default:
					return;
				case 10u:
					break;
				case 8u:
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
