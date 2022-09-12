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
		T value = default(T);
		while (true)
		{
			int num = -1053336770;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB49FE9A8u) % 12u)
				{
				case 11u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 453666843;
						num5 = 453666843;
					}
					else
					{
						num4 = 1749151680;
						num5 = 1749151680;
					}
					num = num4 ^ (int)(num2 * 1925621461);
					continue;
				}
				case 10u:
					num3 = list.Count;
					num = (int)((num2 * 1070695883) ^ 0x62FF0010);
					continue;
				case 9u:
					num = ((int)num2 * -669628647) ^ -1032053485;
					continue;
				case 8u:
					num3--;
					num = (int)(num2 * 32187716) ^ -118169839;
					continue;
				case 7u:
					num = -988509184;
					continue;
				case 6u:
					flag = num3 > 1;
					num = -4937073;
					continue;
				case 5u:
				{
					int index = ScrambleExtention.smethod_0(Random, num3 + 1);
					value = list[index];
					list[index] = list[num3];
					num = ((int)num2 * -2074151311) ^ 0x5F92D848;
					continue;
				}
				case 2u:
					num = (int)((num2 * 1804977543) ^ 0x1DCE59A0);
					continue;
				case 1u:
					num = (int)((num2 * 105330787) ^ 0x73C147D3);
					continue;
				case 0u:
					list[num3] = value;
					num = (int)(num2 * 2004488265) ^ -1533519051;
					continue;
				default:
					return;
				case 3u:
					break;
				case 4u:
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
