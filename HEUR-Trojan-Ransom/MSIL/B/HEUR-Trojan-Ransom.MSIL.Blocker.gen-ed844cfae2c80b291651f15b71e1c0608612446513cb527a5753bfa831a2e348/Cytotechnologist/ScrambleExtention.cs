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
			int num = -122433833;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA88D9745u) % 10u)
				{
				case 9u:
					list[num3] = value;
					num = ((int)num2 * -117771648) ^ -454149845;
					continue;
				case 8u:
				{
					int num4;
					if (num3 > 1)
					{
						num = -952854437;
						num4 = -952854437;
					}
					else
					{
						num = -1735408920;
						num4 = -1735408920;
					}
					continue;
				}
				case 6u:
					num = -1058511729;
					continue;
				case 5u:
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					value = list[index];
					num = (int)(num2 * 11650676) ^ -571180576;
					continue;
				case 4u:
					num = ((int)num2 * -1742045039) ^ 0x16BA6080;
					continue;
				case 2u:
					num3 = list.Count;
					num = (int)(num2 * 482858910) ^ -544618313;
					continue;
				case 1u:
					list[index] = list[num3];
					num = ((int)num2 * -99435651) ^ -145549930;
					continue;
				case 0u:
					num3--;
					num = (int)((num2 * 860210869) ^ 0x58BFFAC);
					continue;
				default:
					return;
				case 7u:
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
