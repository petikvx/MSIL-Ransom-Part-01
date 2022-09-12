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
		double num = Dice.smethod_1(_random);
		bool result = default(bool);
		while (true)
		{
			int num2 = 1460003496;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x693773ADu) % 4u)
				{
				case 2u:
					num2 = (int)(num3 * 359074163) ^ -576628172;
					continue;
				case 1u:
					result = num <= (double)chance;
					num2 = (int)(num3 * 1733242990) ^ -883796575;
					continue;
				case 0u:
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
