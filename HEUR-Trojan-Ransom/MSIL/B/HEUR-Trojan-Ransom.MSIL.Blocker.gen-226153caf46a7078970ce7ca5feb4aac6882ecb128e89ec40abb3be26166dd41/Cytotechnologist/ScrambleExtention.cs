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
		int index = default(int);
		while (true)
		{
			int num = 206925938;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x328D98BAu) % 13u)
				{
				case 12u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -840280341;
						num5 = -840280341;
					}
					else
					{
						num4 = -62161687;
						num5 = -62161687;
					}
					num = num4 ^ (int)(num2 * 1031779701);
					continue;
				}
				case 10u:
					num = 1519421446;
					continue;
				case 9u:
					num = (int)(num2 * 2141300844) ^ -411283268;
					continue;
				case 8u:
					num3 = list.Count;
					num = (int)(num2 * 877680839) ^ -1886524146;
					continue;
				case 7u:
					value = list[index];
					list[index] = list[num3];
					num = (int)(num2 * 909094229) ^ -280679476;
					continue;
				case 6u:
					num = (int)(num2 * 604070560) ^ -1848187587;
					continue;
				case 5u:
					list[num3] = value;
					num = ((int)num2 * -78506719) ^ -384754893;
					continue;
				case 4u:
					num = (int)(num2 * 859389488) ^ -1417282499;
					continue;
				case 3u:
					num3--;
					num = ((int)num2 * -538732473) ^ -1461024844;
					continue;
				case 2u:
					flag = num3 > 1;
					num = 1468453105;
					continue;
				case 1u:
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					num = (int)(num2 * 226082910) ^ -1151210394;
					continue;
				default:
					return;
				case 0u:
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
