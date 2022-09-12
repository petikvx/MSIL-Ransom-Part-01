using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		bool flag = default(bool);
		int index = default(int);
		int num3 = default(int);
		T value = default(T);
		while (true)
		{
			int num = -1448264914;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5B6A036u) % 12u)
				{
				case 11u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -468075034;
						num5 = -468075034;
					}
					else
					{
						num4 = -315931413;
						num5 = -315931413;
					}
					num = num4 ^ ((int)num2 * -347463529);
					continue;
				}
				case 10u:
					num = (int)(num2 * 1295424850) ^ -408644943;
					continue;
				case 9u:
					list[index] = list[num3];
					num = ((int)num2 * -2121896162) ^ -1049291288;
					continue;
				case 8u:
					num3 = list.Count;
					num = ((int)num2 * -1395374064) ^ -821830219;
					continue;
				case 7u:
					flag = num3 > 1;
					num = -1541377271;
					continue;
				case 6u:
					num3--;
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					num = (int)(num2 * 1626890588) ^ -357303417;
					continue;
				case 5u:
					num = -610334304;
					continue;
				case 3u:
					list[num3] = value;
					num = ((int)num2 * -632640068) ^ -637725200;
					continue;
				case 1u:
					value = list[index];
					num = ((int)num2 * -2006708151) ^ -938270062;
					continue;
				case 0u:
					num = ((int)num2 * -153684560) ^ 0x472BA955;
					continue;
				default:
					return;
				case 2u:
					break;
				case 4u:
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
