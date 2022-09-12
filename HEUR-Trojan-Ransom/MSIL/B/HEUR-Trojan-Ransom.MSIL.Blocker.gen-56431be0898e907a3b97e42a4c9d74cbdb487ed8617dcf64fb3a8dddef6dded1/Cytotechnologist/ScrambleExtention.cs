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
			int num2 = 1843662942;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x1252A6EEu) % 12u)
				{
				case 11u:
				{
					int num4;
					if (num > 1)
					{
						num2 = 2089916388;
						num4 = 2089916388;
					}
					else
					{
						num2 = 1237891932;
						num4 = 1237891932;
					}
					continue;
				}
				case 10u:
					num2 = 677583513;
					continue;
				case 9u:
					num2 = (int)(num3 * 1662452184) ^ -618796785;
					continue;
				case 8u:
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = (int)(num3 * 668696578) ^ -1439553064;
					continue;
				case 7u:
					list[index] = list[num];
					num2 = (int)((num3 * 1072501678) ^ 0x69E22531);
					continue;
				case 6u:
					value = list[index];
					num2 = (int)((num3 * 245975162) ^ 0x7190B041);
					continue;
				case 5u:
					list[num] = value;
					num2 = (int)((num3 * 1702362104) ^ 0xA84AA7B);
					continue;
				case 4u:
					num2 = ((int)num3 * -1523705826) ^ 0x78BF9049;
					continue;
				case 3u:
					num--;
					num2 = ((int)num3 * -766222755) ^ -128972583;
					continue;
				case 1u:
					num2 = ((int)num3 * -1341791962) ^ -2053379001;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
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
