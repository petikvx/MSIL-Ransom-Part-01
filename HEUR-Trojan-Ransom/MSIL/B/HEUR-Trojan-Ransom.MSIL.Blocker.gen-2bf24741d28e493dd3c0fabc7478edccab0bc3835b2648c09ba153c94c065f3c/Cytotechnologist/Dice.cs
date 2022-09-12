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
		double num3 = default(double);
		bool result = default(bool);
		while (true)
		{
			int num = -760005615;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA090F67Bu) % 4u)
				{
				case 2u:
					num3 = Dice.smethod_1(_random);
					num = (int)(num2 * 1757372398) ^ -604944690;
					continue;
				case 1u:
					result = num3 <= (double)chance;
					num = (int)((num2 * 544683812) ^ 0x1A6D326F);
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
