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
			int num2 = -1771065554;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xC940AEAEu) % 10u)
				{
				case 9u:
					list[index] = list[num];
					list[num] = value;
					num2 = (int)((num3 * 861243128) ^ 0x2427C0F8);
					continue;
				case 8u:
					num2 = -2032574819;
					continue;
				case 7u:
					value = list[index];
					num2 = (int)(num3 * 535035863) ^ -1399886868;
					continue;
				case 6u:
					num2 = (int)((num3 * 1812968939) ^ 0x7AA92D42);
					continue;
				case 4u:
					num2 = (int)(num3 * 797771098) ^ -2086149426;
					continue;
				case 3u:
					num--;
					num2 = ((int)num3 * -1815152822) ^ -139601654;
					continue;
				case 2u:
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = ((int)num3 * -1083554556) ^ -1906674323;
					continue;
				case 0u:
				{
					int num4;
					if (num > 1)
					{
						num2 = -1867993966;
						num4 = -1867993966;
					}
					else
					{
						num2 = -7026813;
						num4 = -7026813;
					}
					continue;
				}
				default:
					return;
				case 5u:
					break;
				case 1u:
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
