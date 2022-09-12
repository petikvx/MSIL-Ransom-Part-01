using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		int num3 = default(int);
		T value = default(T);
		int index = default(int);
		while (true)
		{
			int num = -2093215464;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF920A9F7u) % 10u)
				{
				case 9u:
					num = ((int)num2 * -1641691048) ^ 0x9B72874;
					continue;
				case 7u:
					list[num3] = value;
					num = ((int)num2 * -254955882) ^ -1366030961;
					continue;
				case 6u:
					value = list[index];
					list[index] = list[num3];
					num = (int)(num2 * 1661773617) ^ -1078105242;
					continue;
				case 5u:
					num = ((int)num2 * -28591135) ^ -2009508134;
					continue;
				case 4u:
				{
					int num4;
					if (num3 > 1)
					{
						num = -199643001;
						num4 = -199643001;
					}
					else
					{
						num = -1855772467;
						num4 = -1855772467;
					}
					continue;
				}
				case 3u:
					num3 = list.Count;
					num = (int)((num2 * 379939668) ^ 0x2D135E5C);
					continue;
				case 2u:
					num3--;
					num = -1625676832;
					continue;
				case 1u:
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					num = ((int)num2 * -896727978) ^ -1492365781;
					continue;
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
