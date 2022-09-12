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
			int num2 = 883650036;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x4CBF5AC9u) % 4u)
				{
				case 2u:
					num2 = ((int)num3 * -566267836) ^ 0x613806E5;
					continue;
				case 1u:
					result = num <= (double)chance;
					num2 = ((int)num3 * -9532130) ^ -108414519;
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
