using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		int num = list.Count;
		int index = default(int);
		T value = default(T);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -2005523477;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x9AA73585u) % 12u)
				{
				case 11u:
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = ((int)num3 * -1770057724) ^ 0x35D6D793;
					continue;
				case 10u:
					value = list[index];
					list[index] = list[num];
					num2 = (int)(num3 * 176293296) ^ -982020286;
					continue;
				case 9u:
					num2 = -533099664;
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 55919142;
						num5 = 55919142;
					}
					else
					{
						num4 = 165725140;
						num5 = 165725140;
					}
					num2 = num4 ^ (int)(num3 * 658765191);
					continue;
				}
				case 6u:
					list[num] = value;
					num2 = (int)((num3 * 396522970) ^ 0x1137376D);
					continue;
				case 4u:
					flag = num > 1;
					num2 = -1482096619;
					continue;
				case 3u:
					num2 = (int)(num3 * 838793306) ^ -1115616611;
					continue;
				case 2u:
					num2 = ((int)num3 * -881702906) ^ -259853967;
					continue;
				case 1u:
					num--;
					num2 = (int)((num3 * 799476111) ^ 0x5A5E3269);
					continue;
				case 0u:
					num2 = (int)((num3 * 983119217) ^ 0x55B42961);
					continue;
				default:
					return;
				case 5u:
					break;
				case 7u:
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
