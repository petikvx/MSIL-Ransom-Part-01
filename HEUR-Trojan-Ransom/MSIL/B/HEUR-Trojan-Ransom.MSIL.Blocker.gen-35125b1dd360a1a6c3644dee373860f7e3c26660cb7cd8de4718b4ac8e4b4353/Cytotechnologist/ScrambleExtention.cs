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
			int num = -1639332331;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCD7A68EAu) % 11u)
				{
				case 9u:
				{
					int num4;
					if (num3 > 1)
					{
						num = -1307358876;
						num4 = -1307358876;
					}
					else
					{
						num = -705728747;
						num4 = -705728747;
					}
					continue;
				}
				case 8u:
					num = ((int)num2 * -1018440998) ^ 0x6BCE49A4;
					continue;
				case 7u:
					value = list[index];
					num = ((int)num2 * -1770464350) ^ 0x20EA2511;
					continue;
				case 6u:
					num = -553608637;
					continue;
				case 5u:
					num = ((int)num2 * -1557772421) ^ 0xD400FD5;
					continue;
				case 4u:
					num3--;
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					num = ((int)num2 * -758789843) ^ -288091418;
					continue;
				case 3u:
					num = (int)(num2 * 631991106) ^ -2079878882;
					continue;
				case 2u:
					list[index] = list[num3];
					list[num3] = value;
					num = ((int)num2 * -305453878) ^ 0x25C719D3;
					continue;
				case 1u:
					num3 = list.Count;
					num = ((int)num2 * -1194605536) ^ -1012010015;
					continue;
				default:
					return;
				case 0u:
					break;
				case 10u:
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
