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
		while (true)
		{
			int num2 = 987826568;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x500A9263u) % 7u)
				{
				case 6u:
					list[num] = value;
					num2 = (int)(num3 * 2004163213) ^ -1083515550;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1849330963;
						num5 = -1849330963;
					}
					else
					{
						num4 = -557389548;
						num5 = -557389548;
					}
					num2 = num4 ^ (int)(num3 * 1279548314);
					continue;
				}
				case 4u:
					flag = num > 1;
					num2 = 1867848719;
					continue;
				case 3u:
					num2 = (int)(num3 * 1744062129) ^ -1069994225;
					continue;
				case 1u:
				{
					num--;
					int index = ScrambleExtention.smethod_0(Random, num + 1);
					value = list[index];
					list[index] = list[num];
					num2 = 804754573;
					continue;
				}
				default:
					return;
				case 0u:
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
