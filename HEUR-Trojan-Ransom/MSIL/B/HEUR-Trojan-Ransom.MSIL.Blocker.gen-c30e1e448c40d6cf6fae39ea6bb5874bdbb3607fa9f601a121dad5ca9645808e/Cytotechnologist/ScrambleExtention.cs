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
		while (true)
		{
			int num2 = -1738031235;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xA213104Eu) % 9u)
				{
				case 8u:
					num--;
					num2 = (int)((num3 * 81705621) ^ 0x273CC559);
					continue;
				case 7u:
				{
					int num4;
					if (num <= 1)
					{
						num2 = -1073597582;
						num4 = -1073597582;
					}
					else
					{
						num2 = -1818610328;
						num4 = -1818610328;
					}
					continue;
				}
				case 6u:
					num2 = -705261283;
					continue;
				case 4u:
					list[num] = value;
					num2 = ((int)num3 * -1237877218) ^ 0x4906B3AE;
					continue;
				case 2u:
					value = list[index];
					list[index] = list[num];
					num2 = ((int)num3 * -2034667668) ^ 0x1E811B28;
					continue;
				case 1u:
					num2 = ((int)num3 * -1134417586) ^ -1520445256;
					continue;
				case 0u:
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = ((int)num3 * -398168121) ^ 0x3CEFF111;
					continue;
				default:
					return;
				case 5u:
					break;
				case 3u:
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
