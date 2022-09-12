using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1174638198;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x903E9685u) % 8u)
				{
				case 7u:
					num3 = list.Count;
					num = ((int)num2 * -405671067) ^ 0x575B71F6;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1042337407;
						num5 = 1042337407;
					}
					else
					{
						num4 = 1420573217;
						num5 = 1420573217;
					}
					num = num4 ^ (int)(num2 * 1411909745);
					continue;
				}
				case 3u:
				{
					num3--;
					int index = ScrambleExtention.smethod_0(Random, num3 + 1);
					T value = list[index];
					list[index] = list[num3];
					list[num3] = value;
					num = ((int)num2 * -494701315) ^ -1353267829;
					continue;
				}
				case 2u:
					num = -654294410;
					continue;
				case 1u:
					num = (int)((num2 * 237509547) ^ 0x7A80BB7E);
					continue;
				case 0u:
					flag = num3 > 1;
					num = -969483437;
					continue;
				default:
					return;
				case 5u:
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
