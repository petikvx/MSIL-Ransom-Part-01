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
		bool flag = default(bool);
		while (true)
		{
			int num = -1637234907;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA906B65Du) % 13u)
				{
				case 12u:
					list[num3] = value;
					num = ((int)num2 * -346766428) ^ 0x2A4ABCA9;
					continue;
				case 11u:
					num = ((int)num2 * -180720264) ^ -781744000;
					continue;
				case 9u:
					list[index] = list[num3];
					num = (int)((num2 * 1691269408) ^ 0x2DE512E0);
					continue;
				case 7u:
					flag = num3 > 1;
					num = -951075746;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1895108229;
						num5 = 1895108229;
					}
					else
					{
						num4 = 1845754414;
						num5 = 1845754414;
					}
					num = num4 ^ (int)(num2 * 622274240);
					continue;
				}
				case 5u:
					num = ((int)num2 * -1727756611) ^ 0x485930B1;
					continue;
				case 4u:
					num3 = list.Count;
					num = (int)((num2 * 463427194) ^ 0x28D333E8);
					continue;
				case 3u:
					num = ((int)num2 * -2090578312) ^ 0x3BCB4DA0;
					continue;
				case 2u:
					num3--;
					num = -1054713715;
					continue;
				case 1u:
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					num = ((int)num2 * -1948750803) ^ -1709067594;
					continue;
				case 0u:
					value = list[index];
					num = (int)(num2 * 1641189159) ^ -322616741;
					continue;
				default:
					return;
				case 10u:
					break;
				case 8u:
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
