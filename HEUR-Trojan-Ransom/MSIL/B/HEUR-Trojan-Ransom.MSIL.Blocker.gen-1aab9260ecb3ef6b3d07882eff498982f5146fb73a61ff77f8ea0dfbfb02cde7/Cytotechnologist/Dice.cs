using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		_random = Dice.smethod_0((int)DateTime.Now.Ticks);
	}

	public bool Roll(float chance)
	{
		bool result = default(bool);
		double num3 = default(double);
		while (true)
		{
			int num = -1747439844;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA5C005Du) % 5u)
				{
				case 4u:
					num = (int)(num2 * 284650485) ^ -1139803029;
					continue;
				case 2u:
					result = num3 <= (double)chance;
					num = ((int)num2 * -1239754574) ^ 0xA5BD7B2;
					continue;
				case 1u:
					num3 = Dice.smethod_1(_random);
					num = (int)((num2 * 1010378944) ^ 0x33705731);
					continue;
				case 3u:
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
