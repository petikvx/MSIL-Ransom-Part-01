using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		int num3 = default(int);
		int index = default(int);
		T value = default(T);
		bool flag = default(bool);
		while (true)
		{
			int num = -1925515557;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC696A981u) % 11u)
				{
				case 10u:
					num3 = list.Count;
					num = ((int)num2 * -1659833330) ^ 0x58EED745;
					continue;
				case 7u:
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					value = list[index];
					num = (int)(num2 * 1251816243) ^ -1005656499;
					continue;
				case 6u:
					num = (int)((num2 * 1432296746) ^ 0x400A5B62);
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1289754834;
						num5 = -1289754834;
					}
					else
					{
						num4 = -1716388945;
						num5 = -1716388945;
					}
					num = num4 ^ ((int)num2 * -1292908832);
					continue;
				}
				case 4u:
					num3--;
					num = -37496217;
					continue;
				case 3u:
					flag = num3 > 1;
					num = -2115182337;
					continue;
				case 2u:
					num = (int)((num2 * 616443317) ^ 0x6D45E9A6);
					continue;
				case 1u:
					list[index] = list[num3];
					num = ((int)num2 * -757345914) ^ -733812815;
					continue;
				case 0u:
					list[num3] = value;
					num = (int)(num2 * 140677681) ^ -304017943;
					continue;
				default:
					return;
				case 9u:
					break;
				case 8u:
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
