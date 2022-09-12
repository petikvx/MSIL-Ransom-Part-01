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
			int num2 = 2035156317;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x8CFCFE9u) % 10u)
				{
				case 8u:
					num--;
					num2 = 675745077;
					continue;
				case 6u:
					num2 = ((int)num3 * -104096708) ^ -1469204776;
					continue;
				case 5u:
					list[index] = list[num];
					num2 = ((int)num3 * -1786804202) ^ 0x13C18BA0;
					continue;
				case 4u:
					num2 = ((int)num3 * -1768277018) ^ 0xDC5FEAF;
					continue;
				case 3u:
					num2 = (int)((num3 * 147004122) ^ 0x83CEFED);
					continue;
				case 2u:
					index = ScrambleExtention.smethod_0(Random, num + 1);
					value = list[index];
					num2 = ((int)num3 * -304350847) ^ -1564668004;
					continue;
				case 1u:
					list[num] = value;
					num2 = ((int)num3 * -1190515426) ^ -369051965;
					continue;
				case 0u:
				{
					int num4;
					if (num <= 1)
					{
						num2 = 800265566;
						num4 = 800265566;
					}
					else
					{
						num2 = 730556215;
						num4 = 730556215;
					}
					continue;
				}
				default:
					return;
				case 7u:
					break;
				case 9u:
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
