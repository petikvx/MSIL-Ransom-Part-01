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
		bool flag = default(bool);
		while (true)
		{
			int num2 = -806162283;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xC47762FDu) % 12u)
				{
				case 11u:
					list[num] = value;
					num2 = (int)(num3 * 349599337) ^ -1826743662;
					continue;
				case 10u:
					num2 = -457494585;
					continue;
				case 9u:
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = ((int)num3 * -2056107041) ^ -1951629572;
					continue;
				case 8u:
					num2 = (int)((num3 * 1911127410) ^ 0x5A2E4A2A);
					continue;
				case 6u:
					value = list[index];
					list[index] = list[num];
					num2 = (int)((num3 * 787546241) ^ 0x3C794F6B);
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1024826330;
						num5 = -1024826330;
					}
					else
					{
						num4 = -1843092981;
						num5 = -1843092981;
					}
					num2 = num4 ^ ((int)num3 * -1326158480);
					continue;
				}
				case 4u:
					num2 = ((int)num3 * -303809767) ^ 0x389CE94C;
					continue;
				case 2u:
					num--;
					num2 = ((int)num3 * -1717637361) ^ 0x52BFFF82;
					continue;
				case 1u:
					flag = num > 1;
					num2 = -546936528;
					continue;
				case 0u:
					num2 = ((int)num3 * -1843688923) ^ 0x2852E344;
					continue;
				default:
					return;
				case 3u:
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
