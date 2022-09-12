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
			int num2;
			int num3;
			if (num <= 1)
			{
				num2 = -1096793167;
				num3 = -1096793167;
			}
			else
			{
				num2 = -1648991861;
				num3 = -1648991861;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0xC3C9687Cu) % 9u)
				{
				case 8u:
					list[num] = value;
					num2 = ((int)num4 * -1263066870) ^ -554619687;
					continue;
				case 7u:
					value = list[index];
					list[index] = list[num];
					num2 = (int)((num4 * 698391884) ^ 0x5BA71B32);
					continue;
				case 6u:
					num--;
					num2 = -1537912055;
					continue;
				case 5u:
					num2 = (int)(num4 * 1944875707) ^ -697017161;
					continue;
				case 3u:
					num2 = -1648991861;
					continue;
				case 1u:
					num2 = (int)((num4 * 236351031) ^ 0x7C8E52F7);
					continue;
				case 0u:
					index = ScrambleExtention.smethod_0(Random, num + 1);
					num2 = ((int)num4 * -2031550037) ^ -546048762;
					continue;
				default:
					return;
				case 2u:
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
