using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		bool flag = default(bool);
		int num5 = default(int);
		int index = default(int);
		T value = default(T);
		while (true)
		{
			int num = -1468442738;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE8CB7C87u) % 11u)
				{
				case 10u:
					flag = num5 > 1;
					num = -294372729;
					continue;
				case 9u:
					index = ScrambleExtention.smethod_0(Random, num5 + 1);
					num = (int)(num2 * 660329927) ^ -852343435;
					continue;
				case 7u:
					num = ((int)num2 * -542806838) ^ 0xBCDAAD1;
					continue;
				case 6u:
					num5--;
					num = -1933434713;
					continue;
				case 5u:
					list[index] = list[num5];
					num = ((int)num2 * -1502993698) ^ 0x102C4FDE;
					continue;
				case 4u:
					value = list[index];
					num = ((int)num2 * -41913157) ^ 0x40D3502A;
					continue;
				case 3u:
					num5 = list.Count;
					num = (int)(num2 * 1270420941) ^ -36347790;
					continue;
				case 2u:
					list[num5] = value;
					num = ((int)num2 * -562416503) ^ -740895229;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1725701754;
						num4 = -1725701754;
					}
					else
					{
						num3 = -1558091779;
						num4 = -1558091779;
					}
					num = num3 ^ ((int)num2 * -1470951672);
					continue;
				}
				default:
					return;
				case 0u:
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
