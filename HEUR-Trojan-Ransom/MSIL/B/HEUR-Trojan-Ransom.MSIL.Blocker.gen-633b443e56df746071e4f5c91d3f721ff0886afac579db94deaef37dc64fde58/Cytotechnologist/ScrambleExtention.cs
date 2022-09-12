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
		int index = default(int);
		while (true)
		{
			int num2;
			int num3;
			if (num > 1)
			{
				num2 = 25758085;
				num3 = 25758085;
			}
			else
			{
				num2 = 784176017;
				num3 = 784176017;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0x68B1D040u) % 11u)
				{
				case 9u:
					num2 = (int)(num4 * 1390226603) ^ -152395440;
					continue;
				case 8u:
					num2 = 25758085;
					continue;
				case 7u:
					num2 = 1156366442;
					continue;
				case 6u:
					value = list[index];
					list[index] = list[num];
					num2 = ((int)num4 * -700972511) ^ -2075307882;
					continue;
				case 5u:
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = (int)(num4 * 1318758441) ^ -1321480589;
					continue;
				case 4u:
					list[num] = value;
					num2 = (int)((num4 * 2054194995) ^ 0x6BC9388C);
					continue;
				case 3u:
					num--;
					num2 = ((int)num4 * -1221794013) ^ -1718030448;
					continue;
				case 2u:
					num2 = ((int)num4 * -492570188) ^ -258636442;
					continue;
				case 0u:
					num2 = (int)(num4 * 769325718) ^ -1671998417;
					continue;
				default:
					return;
				case 1u:
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
