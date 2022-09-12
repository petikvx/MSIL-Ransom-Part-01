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
		bool flag = default(bool);
		int index = default(int);
		while (true)
		{
			int num2 = 416988992;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x46AEBC4Eu) % 12u)
				{
				case 11u:
					list[num] = value;
					num2 = (int)((num3 * 2078970277) ^ 0x57FBFAA1);
					continue;
				case 10u:
					flag = num > 1;
					num2 = 827310175;
					continue;
				case 8u:
					num2 = (int)(num3 * 2014649961) ^ -1185656732;
					continue;
				case 7u:
					value = list[index];
					num2 = (int)((num3 * 779495125) ^ 0x36C9C138);
					continue;
				case 6u:
					num2 = 1020041469;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 499989389;
						num5 = 499989389;
					}
					else
					{
						num4 = 1431553315;
						num5 = 1431553315;
					}
					num2 = num4 ^ ((int)num3 * -1444679017);
					continue;
				}
				case 3u:
					num--;
					num2 = (int)((num3 * 1533593334) ^ 0x224D9514);
					continue;
				case 2u:
					num2 = (int)((num3 * 784060243) ^ 0x1EE2A94A);
					continue;
				case 1u:
					list[index] = list[num];
					num2 = (int)((num3 * 488219865) ^ 0xD3E9628);
					continue;
				case 0u:
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = ((int)num3 * -1867164447) ^ -1802967651;
					continue;
				default:
					return;
				case 9u:
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
