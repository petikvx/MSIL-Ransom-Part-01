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
		while (true)
		{
			int num = 387574097;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x23C6F03Du) % 8u)
				{
				case 7u:
					flag = num3 > 1;
					num = 92876044;
					continue;
				case 6u:
					num = 390068829;
					continue;
				case 4u:
					num3 = list.Count;
					num = ((int)num2 * -2009011704) ^ 0x2EFE0392;
					continue;
				case 2u:
					num = (int)((num2 * 1903245520) ^ 0x42B29B52);
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 2071820142;
						num5 = 2071820142;
					}
					else
					{
						num4 = 1714829859;
						num5 = 1714829859;
					}
					num = num4 ^ (int)(num2 * 1737740144);
					continue;
				}
				case 0u:
				{
					num3--;
					int index = ScrambleExtention.smethod_0(Random, num3 + 1);
					T value = list[index];
					list[index] = list[num3];
					list[num3] = value;
					num = (int)(num2 * 2118262972) ^ -1197902945;
					continue;
				}
				default:
					return;
				case 5u:
					break;
				case 3u:
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
