using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		bool flag = default(bool);
		int num3 = default(int);
		int index = default(int);
		T value = default(T);
		while (true)
		{
			int num = -1165438070;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8F5BC6FAu) % 10u)
				{
				case 9u:
					num = ((int)num2 * -991881055) ^ 0x10CC4A9;
					continue;
				case 8u:
					num = -401036185;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1233089323;
						num5 = 1233089323;
					}
					else
					{
						num4 = 1450492998;
						num5 = 1450492998;
					}
					num = num4 ^ ((int)num2 * -229605903);
					continue;
				}
				case 6u:
					flag = num3 > 1;
					num = -848974109;
					continue;
				case 3u:
					num3--;
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					num = (int)(num2 * 2049577644) ^ -559365648;
					continue;
				case 2u:
					num3 = list.Count;
					num = (int)((num2 * 1668500838) ^ 0x1CEA445E);
					continue;
				case 1u:
					list[num3] = value;
					num = (int)((num2 * 386097101) ^ 0x2F3435B0);
					continue;
				case 0u:
					value = list[index];
					list[index] = list[num3];
					num = ((int)num2 * -1829026717) ^ 0x34D607E9;
					continue;
				default:
					return;
				case 4u:
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
