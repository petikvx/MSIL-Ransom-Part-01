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
				num2 = -31127844;
				num3 = -31127844;
			}
			else
			{
				num2 = -928678588;
				num3 = -928678588;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0xB37CD63Fu) % 10u)
				{
				case 8u:
					num--;
					num2 = ((int)num4 * -860680171) ^ -759274721;
					continue;
				case 7u:
					value = list[index];
					list[index] = list[num];
					num2 = ((int)num4 * -1677386510) ^ -88725703;
					continue;
				case 6u:
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = ((int)num4 * -359230203) ^ 0xFAD6492;
					continue;
				case 5u:
					list[num] = value;
					num2 = (int)((num4 * 86855703) ^ 0x66EEA35E);
					continue;
				case 4u:
					num2 = (int)(num4 * 649688943) ^ -122544848;
					continue;
				case 2u:
					num2 = (int)((num4 * 979888626) ^ 0x4264382C);
					continue;
				case 1u:
					num2 = -561497791;
					continue;
				case 0u:
					num2 = -31127844;
					continue;
				default:
					return;
				case 3u:
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
