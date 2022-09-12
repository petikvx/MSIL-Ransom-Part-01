using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		T value = default(T);
		int index = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1715280762;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2B59AD4Bu) % 10u)
				{
				case 8u:
					value = list[index];
					list[index] = list[num3];
					num = (int)(num2 * 714420101) ^ -1780390630;
					continue;
				case 7u:
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					num = (int)(num2 * 1032124449) ^ -761741090;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1846180399;
						num5 = 1846180399;
					}
					else
					{
						num4 = 2020875209;
						num5 = 2020875209;
					}
					num = num4 ^ ((int)num2 * -1241793232);
					continue;
				}
				case 5u:
					num = (int)(num2 * 417935156) ^ -1378616619;
					continue;
				case 4u:
					flag = num3 > 1;
					num = 615193759;
					continue;
				case 3u:
					num3 = list.Count;
					num = ((int)num2 * -372981023) ^ 0x4B1B06A8;
					continue;
				case 2u:
					num3--;
					num = 1801532030;
					continue;
				case 1u:
					list[num3] = value;
					num = (int)(num2 * 922000119) ^ -1044228501;
					continue;
				default:
					return;
				case 9u:
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
