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
				num2 = -1700198464;
				num3 = -1700198464;
			}
			else
			{
				num2 = -23441456;
				num3 = -23441456;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0xEC254201u) % 9u)
				{
				case 8u:
					list[num] = value;
					num2 = (int)((num4 * 535854636) ^ 0x47DDED8D);
					continue;
				case 7u:
					list[index] = list[num];
					num2 = (int)((num4 * 780185207) ^ 0x3018CBBC);
					continue;
				case 6u:
					value = list[index];
					num2 = (int)((num4 * 1303977856) ^ 0x30C066E4);
					continue;
				case 4u:
					num2 = -1700198464;
					continue;
				case 2u:
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = ((int)num4 * -1361384488) ^ 0x9FC6620;
					continue;
				case 1u:
					num--;
					num2 = -940710338;
					continue;
				case 0u:
					num2 = ((int)num4 * -957982472) ^ -1090089322;
					continue;
				default:
					return;
				case 3u:
					break;
				case 5u:
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
