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
			int num = -1236824578;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC7C8C58u) % 12u)
				{
				case 10u:
					list[num3] = value;
					num = (int)((num2 * 1971536069) ^ 0x1F5C71C7);
					continue;
				case 9u:
					num = (int)(num2 * 1411337388) ^ -1931831323;
					continue;
				case 7u:
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					num = (int)((num2 * 1399298322) ^ 0x4B2FFFDE);
					continue;
				case 6u:
				{
					int num4;
					if (num3 > 1)
					{
						num = -1896427299;
						num4 = -1896427299;
					}
					else
					{
						num = -1247752396;
						num4 = -1247752396;
					}
					continue;
				}
				case 5u:
					num = (int)((num2 * 1304835544) ^ 0x14300C2A);
					continue;
				case 4u:
					list[index] = list[num3];
					num = (int)(num2 * 1012368194) ^ -223681817;
					continue;
				case 3u:
					num = (int)((num2 * 1477782377) ^ 0x5899774D);
					continue;
				case 2u:
					num3 = list.Count;
					num = ((int)num2 * -26582686) ^ -679021698;
					continue;
				case 1u:
					num3--;
					num = -88051089;
					continue;
				case 0u:
					value = list[index];
					num = (int)((num2 * 1091599066) ^ 0x63665218);
					continue;
				default:
					return;
				case 11u:
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
