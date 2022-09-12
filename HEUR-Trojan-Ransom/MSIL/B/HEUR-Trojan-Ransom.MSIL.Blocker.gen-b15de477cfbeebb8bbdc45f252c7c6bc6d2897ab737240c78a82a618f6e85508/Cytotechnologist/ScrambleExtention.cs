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
			int num = -315099662;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFD1A01D0u) % 15u)
				{
				case 14u:
					flag = num3 > 1;
					num = -120225563;
					continue;
				case 13u:
					num = -2044133587;
					continue;
				case 11u:
					num = ((int)num2 * -1857970363) ^ 0x5981B906;
					continue;
				case 10u:
					value = list[index];
					num = ((int)num2 * -23469516) ^ 0x7360C1BF;
					continue;
				case 9u:
					num3 = list.Count;
					num = (int)(num2 * 1766201678) ^ -1124909870;
					continue;
				case 8u:
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					num = ((int)num2 * -1830966642) ^ 0x1B09B843;
					continue;
				case 7u:
					list[num3] = value;
					num = (int)(num2 * 960011240) ^ -1813356040;
					continue;
				case 6u:
					num = (int)(num2 * 1581364375) ^ -73961905;
					continue;
				case 5u:
					num3--;
					num = ((int)num2 * -609855872) ^ 0x2DCCA3A5;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -2067148925;
						num5 = -2067148925;
					}
					else
					{
						num4 = -307700014;
						num5 = -307700014;
					}
					num = num4 ^ (int)(num2 * 708734692);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1443822564) ^ -864781955;
					continue;
				case 1u:
					list[index] = list[num3];
					num = ((int)num2 * -1062599695) ^ 0x57FB66BF;
					continue;
				case 0u:
					num = ((int)num2 * -1112827274) ^ 0x46D6FF12;
					continue;
				default:
					return;
				case 2u:
					break;
				case 12u:
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
