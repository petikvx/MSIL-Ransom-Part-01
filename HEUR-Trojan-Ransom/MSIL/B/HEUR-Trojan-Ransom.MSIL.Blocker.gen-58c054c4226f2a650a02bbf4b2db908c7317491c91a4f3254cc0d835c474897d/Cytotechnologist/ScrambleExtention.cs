using System;
using System.Collections.Generic;

namespace Cytotechnologist;

public static class ScrambleExtention
{
	private static readonly Random Random = ScrambleExtention.smethod_1();

	public static void Shuffle<T>(IList<T> list)
	{
		bool flag = default(bool);
		int num3 = default(int);
		T value = default(T);
		int index = default(int);
		while (true)
		{
			int num = -98605623;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80F720E8u) % 10u)
				{
				case 9u:
					flag = num3 > 1;
					num = -1941430886;
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 689911720;
						num5 = 689911720;
					}
					else
					{
						num4 = 411127581;
						num5 = 411127581;
					}
					num = num4 ^ (int)(num2 * 1772153023);
					continue;
				}
				case 7u:
					list[num3] = value;
					num = (int)((num2 * 752282662) ^ 0x49F47A69);
					continue;
				case 5u:
					value = list[index];
					list[index] = list[num3];
					num = ((int)num2 * -113614201) ^ 0x4281AC29;
					continue;
				case 3u:
					num3--;
					index = ScrambleExtention.smethod_0(Random, num3 + 1);
					num = -1400616823;
					continue;
				case 2u:
					num = (int)(num2 * 1767592599) ^ -247079419;
					continue;
				case 1u:
					num3 = list.Count;
					num = (int)((num2 * 331386844) ^ 0x399477FA);
					continue;
				case 0u:
					num = ((int)num2 * -106390205) ^ -1239051497;
					continue;
				default:
					return;
				case 4u:
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
