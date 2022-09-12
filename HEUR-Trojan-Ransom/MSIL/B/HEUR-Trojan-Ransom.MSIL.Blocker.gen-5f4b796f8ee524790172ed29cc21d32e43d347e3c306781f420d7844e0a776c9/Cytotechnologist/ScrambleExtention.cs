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
			bool flag = num > 1;
			int num2 = -58471937;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xD0671DC7u) % 13u)
				{
				case 10u:
					num2 = -136007953;
					continue;
				case 9u:
					num2 = (int)(num3 * 1002917132) ^ -429336997;
					continue;
				case 8u:
					value = list[index];
					num2 = ((int)num3 * -1806929726) ^ -1421053533;
					continue;
				case 7u:
					num2 = -413088342;
					continue;
				case 6u:
					list[index] = list[num];
					num2 = ((int)num3 * -1890344701) ^ 0x20248462;
					continue;
				case 5u:
					list[num] = value;
					num2 = ((int)num3 * -1906663195) ^ -2114658175;
					continue;
				case 4u:
					num2 = ((int)num3 * -912285891) ^ 0x17CD7CD3;
					continue;
				case 3u:
					num--;
					num2 = ((int)num3 * -167476010) ^ -427789574;
					continue;
				case 2u:
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = (int)((num3 * 51471117) ^ 0x690E6ABF);
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1143811430;
						num5 = -1143811430;
					}
					else
					{
						num4 = -28082015;
						num5 = -28082015;
					}
					num2 = num4 ^ (int)(num3 * 888029546);
					continue;
				}
				case 0u:
					num2 = (int)(num3 * 180468797) ^ -2047852508;
					continue;
				default:
					return;
				case 12u:
					break;
				case 11u:
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
