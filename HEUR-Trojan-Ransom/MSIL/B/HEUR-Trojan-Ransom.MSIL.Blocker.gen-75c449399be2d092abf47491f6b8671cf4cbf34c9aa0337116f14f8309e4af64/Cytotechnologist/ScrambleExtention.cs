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
			bool flag = num > 1;
			int num2 = -513404712;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x867ADE8Cu) % 8u)
				{
				case 7u:
					num2 = -15869991;
					continue;
				case 6u:
					list[num] = value;
					num2 = ((int)num3 * -2020109686) ^ -769161607;
					continue;
				case 5u:
					num--;
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = -1359496274;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1687294045;
						num5 = 1687294045;
					}
					else
					{
						num4 = 982074272;
						num5 = 982074272;
					}
					num2 = num4 ^ ((int)num3 * -181128675);
					continue;
				}
				case 3u:
					list[index] = list[num];
					num2 = ((int)num3 * -2126104606) ^ -1740842188;
					continue;
				case 2u:
					value = list[index];
					num2 = ((int)num3 * -177300226) ^ -132760573;
					continue;
				default:
					return;
				case 1u:
					break;
				case 0u:
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
