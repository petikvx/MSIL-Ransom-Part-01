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
		bool flag = default(bool);
		T value = default(T);
		while (true)
		{
			int num2 = 2112773460;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x44975ABCu) % 9u)
				{
				case 8u:
					num--;
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = ((int)num3 * -1090556322) ^ -993073729;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -392474219;
						num5 = -392474219;
					}
					else
					{
						num4 = -1210311458;
						num5 = -1210311458;
					}
					num2 = num4 ^ (int)(num3 * 343484660);
					continue;
				}
				case 5u:
					flag = num > 1;
					num2 = 1636455283;
					continue;
				case 3u:
					num2 = (int)(num3 * 783462846) ^ -50632212;
					continue;
				case 2u:
					value = list[index];
					list[index] = list[num];
					num2 = ((int)num3 * -42172489) ^ 0x5CBE1F28;
					continue;
				case 1u:
					num2 = 1376837797;
					continue;
				case 0u:
					list[num] = value;
					num2 = (int)((num3 * 260732584) ^ 0x2DB8F884);
					continue;
				default:
					return;
				case 7u:
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
