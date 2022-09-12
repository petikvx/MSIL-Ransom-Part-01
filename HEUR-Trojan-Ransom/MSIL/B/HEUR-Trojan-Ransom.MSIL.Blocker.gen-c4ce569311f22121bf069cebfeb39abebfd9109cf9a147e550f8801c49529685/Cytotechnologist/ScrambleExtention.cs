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
			int num2 = 2074455143;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x69F85ED1u) % 11u)
				{
				case 10u:
					num--;
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = ((int)num3 * -853625730) ^ 0x383AB29B;
					continue;
				case 9u:
					num2 = (int)((num3 * 1345933758) ^ 0x5079042D);
					continue;
				case 7u:
					flag = num > 1;
					num2 = 1983612432;
					continue;
				case 6u:
					list[num] = value;
					num2 = ((int)num3 * -464192838) ^ 0x59E30E67;
					continue;
				case 5u:
					list[index] = list[num];
					num2 = (int)((num3 * 485888437) ^ 0x7FCD34AA);
					continue;
				case 4u:
					num2 = 460307731;
					continue;
				case 3u:
					value = list[index];
					num2 = ((int)num3 * -44916503) ^ 0x704E8EAB;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1784207338;
						num5 = 1784207338;
					}
					else
					{
						num4 = 542100934;
						num5 = 542100934;
					}
					num2 = num4 ^ ((int)num3 * -1500806561);
					continue;
				}
				case 0u:
					num2 = (int)(num3 * 2050272979) ^ -956285575;
					continue;
				default:
					return;
				case 8u:
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
