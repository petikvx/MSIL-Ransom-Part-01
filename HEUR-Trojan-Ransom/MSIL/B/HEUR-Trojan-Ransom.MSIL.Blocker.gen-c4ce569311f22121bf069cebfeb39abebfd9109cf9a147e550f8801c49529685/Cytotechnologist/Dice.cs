using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = -1587779111;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE7C3B344u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 101056309) ^ -2025773211;
					continue;
				case 1u:
					num = ((int)num2 * -136396933) ^ -1586331455;
					continue;
				case 0u:
					break;
				default:
					_random = Dice.smethod_0((int)DateTime.Now.Ticks);
					return;
				}
				break;
			}
		}
	}

	public bool Roll(float chance)
	{
		double num3 = default(double);
		bool result = default(bool);
		while (true)
		{
			int num = -1847323672;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF6C5311Bu) % 5u)
				{
				case 3u:
					num3 = Dice.smethod_1(_random);
					num = (int)(num2 * 1669725307) ^ -1677907916;
					continue;
				case 2u:
					num = (int)((num2 * 1082814001) ^ 0x3A488054);
					continue;
				case 1u:
					result = num3 <= (double)chance;
					num = ((int)num2 * -257038087) ^ 0x76D4AABB;
					continue;
				case 4u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	static Random smethod_0(int int_0)
	{
		return new Random(int_0);
	}

	static double smethod_1(Random random_0)
	{
		return random_0.NextDouble();
	}
}
