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
		while (true)
		{
			int num = 967113948;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4F458F3Fu) % 13u)
				{
				case 11u:
				{
					int index = ScrambleExtention.smethod_0(Random, num3 + 1);
					value = list[index];
					list[index] = list[num3];
					num = ((int)num2 * -1657448466) ^ 0x74612294;
					continue;
				}
				case 10u:
					num = ((int)num2 * -1296732191) ^ 0xCA7D6CF;
					continue;
				case 9u:
					num3--;
					num = ((int)num2 * -504800374) ^ 0x46EFEC89;
					continue;
				case 8u:
					num = (int)((num2 * 1443999343) ^ 0x23D56873);
					continue;
				case 7u:
					num = 2134429048;
					continue;
				case 6u:
					list[num3] = value;
					num = (int)(num2 * 819048835) ^ -1285164300;
					continue;
				case 4u:
					num = ((int)num2 * -285224124) ^ 0x4FE8659;
					continue;
				case 3u:
					num = ((int)num2 * -1122983250) ^ 0x55CE36C;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1428593475;
						num5 = -1428593475;
					}
					else
					{
						num4 = -2130810048;
						num5 = -2130810048;
					}
					num = num4 ^ ((int)num2 * -2114825001);
					continue;
				}
				case 1u:
					num3 = list.Count;
					num = ((int)num2 * -456579509) ^ 0x70319BB8;
					continue;
				case 0u:
					flag = num3 > 1;
					num = 892321724;
					continue;
				default:
					return;
				case 12u:
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
