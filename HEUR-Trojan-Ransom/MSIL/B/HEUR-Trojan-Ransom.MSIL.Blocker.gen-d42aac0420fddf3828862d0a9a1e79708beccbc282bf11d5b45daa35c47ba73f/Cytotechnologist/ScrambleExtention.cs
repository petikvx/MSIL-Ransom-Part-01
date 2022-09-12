using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		T value = default(T);
		int index = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -809888036;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB101A740u) % 11u)
				{
				case 10u:
					value = list[index];
					list[index] = list[num3];
					num = (int)(num2 * 507191251) ^ -245894535;
					continue;
				case 9u:
					num = ((int)num2 * -135381742) ^ 0x5AB041ED;
					continue;
				case 8u:
					num3 = list.Count;
					num = ((int)num2 * -1492680641) ^ 0xDC9E8EF;
					continue;
				case 7u:
				{
					int num4;
					if (num3 > 1)
					{
						num = -816119751;
						num4 = -816119751;
					}
					else
					{
						num = -1646713119;
						num4 = -1646713119;
					}
					continue;
				}
				case 5u:
					num3--;
					num = -1400103852;
					continue;
				case 4u:
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					num = (int)(num2 * 802982290) ^ -902422478;
					continue;
				case 3u:
					num = ((int)num2 * -955158745) ^ 0x12EDCC2F;
					continue;
				case 1u:
					num = ((int)num2 * -324521326) ^ -1030944621;
					continue;
				case 0u:
					list[num3] = value;
					num = ((int)num2 * -1758787583) ^ -121945718;
					continue;
				default:
					return;
				case 2u:
					break;
				case 6u:
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
