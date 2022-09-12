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
		while (true)
		{
			int num = -1427883576;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD2BE303Fu) % 11u)
				{
				case 9u:
				{
					int num4;
					if (num3 <= 1)
					{
						num = -625314386;
						num4 = -625314386;
					}
					else
					{
						num = -1173763355;
						num4 = -1173763355;
					}
					continue;
				}
				case 8u:
					num = ((int)num2 * -246492086) ^ 0x6A2D43CF;
					continue;
				case 6u:
					list[num3] = value;
					num = ((int)num2 * -1239241400) ^ -996055407;
					continue;
				case 5u:
					num = (int)(num2 * 458018044) ^ -1366178008;
					continue;
				case 4u:
					value = list[index];
					num = (int)((num2 * 2130529982) ^ 0x52A1DBDF);
					continue;
				case 3u:
					num = (int)((num2 * 1099009813) ^ 0x26AF76A);
					continue;
				case 2u:
					list[index] = list[num3];
					num = ((int)num2 * -457156669) ^ 0x67719227;
					continue;
				case 1u:
					num3 = list.Count;
					num = ((int)num2 * -1735833859) ^ 0x41BB263A;
					continue;
				case 0u:
					num3--;
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					num = -21875512;
					continue;
				default:
					return;
				case 7u:
					break;
				case 10u:
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
