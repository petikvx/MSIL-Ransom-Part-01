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
			int num2 = 1978367804;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x14EC152Bu) % 8u)
				{
				case 7u:
					num2 = (int)((num3 * 201984591) ^ 0x5A10C8AA);
					continue;
				case 6u:
					list[num] = value;
					num2 = ((int)num3 * -683994284) ^ -428630229;
					continue;
				case 5u:
					num2 = (int)((num3 * 843878631) ^ 0x39E5630E);
					continue;
				case 3u:
					num--;
					index = ScrambleExtention.smethod_0(Random, num + 1);
					value = list[index];
					num2 = 1887242818;
					continue;
				case 1u:
					list[index] = list[num];
					num2 = ((int)num3 * -528963430) ^ 0x1BA6E09C;
					continue;
				case 0u:
				{
					int num4;
					if (num <= 1)
					{
						num2 = 1631881201;
						num4 = 1631881201;
					}
					else
					{
						num2 = 316954440;
						num4 = 316954440;
					}
					continue;
				}
				default:
					return;
				case 4u:
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
