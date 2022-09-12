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
			int num = 33165751;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2AAE00FBu) % 11u)
				{
				case 9u:
					num3 = list.Count;
					num = (int)(num2 * 1904873920) ^ -371058936;
					continue;
				case 8u:
				{
					int num4;
					if (num3 > 1)
					{
						num = 999118132;
						num4 = 999118132;
					}
					else
					{
						num = 1869847840;
						num4 = 1869847840;
					}
					continue;
				}
				case 7u:
					num = ((int)num2 * -755120136) ^ 0x65AB34A5;
					continue;
				case 6u:
					list[num3] = value;
					num = (int)(num2 * 1708587574) ^ -794104276;
					continue;
				case 5u:
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					value = list[index];
					num = (int)((num2 * 1057870871) ^ 0x43EB76D6);
					continue;
				case 4u:
					num3--;
					num = 1258759857;
					continue;
				case 3u:
					num = (int)(num2 * 710046174) ^ -2135394407;
					continue;
				case 2u:
					list[index] = list[num3];
					num = ((int)num2 * -1801140903) ^ 0x7DAD98F;
					continue;
				case 1u:
					num = ((int)num2 * -1727538350) ^ 0x44037693;
					continue;
				default:
					return;
				case 0u:
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
