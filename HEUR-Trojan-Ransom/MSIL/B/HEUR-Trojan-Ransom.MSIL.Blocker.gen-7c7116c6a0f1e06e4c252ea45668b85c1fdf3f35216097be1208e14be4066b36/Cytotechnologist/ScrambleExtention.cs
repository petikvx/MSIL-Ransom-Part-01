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
		bool flag = default(bool);
		int index = default(int);
		while (true)
		{
			int num = -1320655790;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE9D63F7Au) % 12u)
				{
				case 11u:
					list[num3] = value;
					num = ((int)num2 * -2093123067) ^ 0x12E5E986;
					continue;
				case 10u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -192481847;
						num5 = -192481847;
					}
					else
					{
						num4 = -1406916079;
						num5 = -1406916079;
					}
					num = num4 ^ (int)(num2 * 13930119);
					continue;
				}
				case 9u:
					num3--;
					num = -1974125534;
					continue;
				case 8u:
					num3 = list.Count;
					num = ((int)num2 * -1010845112) ^ -1854326907;
					continue;
				case 7u:
					flag = num3 > 1;
					num = -294343336;
					continue;
				case 6u:
					value = list[index];
					num = (int)((num2 * 1071319643) ^ 0x7FFF51D6);
					continue;
				case 3u:
					num = (int)(num2 * 2035963248) ^ -630513241;
					continue;
				case 2u:
					list[index] = list[num3];
					num = ((int)num2 * -1071019725) ^ -611918005;
					continue;
				case 1u:
					num = (int)(num2 * 1036364889) ^ -2094225728;
					continue;
				case 0u:
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					num = (int)(num2 * 745122288) ^ -61987900;
					continue;
				default:
					return;
				case 4u:
					break;
				case 5u:
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
