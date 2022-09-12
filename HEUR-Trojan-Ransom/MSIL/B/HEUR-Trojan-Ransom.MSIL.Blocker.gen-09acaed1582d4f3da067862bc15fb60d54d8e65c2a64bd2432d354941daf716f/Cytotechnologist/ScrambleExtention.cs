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
			int num2;
			int num3;
			if (num <= 1)
			{
				num2 = -82517857;
				num3 = -82517857;
			}
			else
			{
				num2 = -1950212742;
				num3 = -1950212742;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0x8A9EB843u) % 12u)
				{
				case 11u:
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = (int)((num4 * 1857753320) ^ 0x73BF2F89);
					continue;
				case 10u:
					num2 = (int)(num4 * 1102766491) ^ -1883947539;
					continue;
				case 9u:
					num2 = -1267648657;
					continue;
				case 8u:
					num--;
					num2 = ((int)num4 * -492623921) ^ -296780488;
					continue;
				case 7u:
					num2 = -1950212742;
					continue;
				case 6u:
					list[index] = list[num];
					num2 = ((int)num4 * -236521895) ^ 0xE4F4323;
					continue;
				case 5u:
					num2 = (int)(num4 * 1834999480) ^ -502320198;
					continue;
				case 3u:
					num2 = ((int)num4 * -972163076) ^ -793462958;
					continue;
				case 2u:
					value = list[index];
					num2 = ((int)num4 * -465748510) ^ 0x6999058D;
					continue;
				case 0u:
					list[num] = value;
					num2 = (int)(num4 * 234907451) ^ -1051148204;
					continue;
				default:
					return;
				case 1u:
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
