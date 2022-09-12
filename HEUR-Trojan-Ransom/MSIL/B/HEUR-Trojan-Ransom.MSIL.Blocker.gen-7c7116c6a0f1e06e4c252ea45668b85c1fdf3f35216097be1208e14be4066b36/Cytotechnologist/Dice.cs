using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = 301938738;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x41F7FBCCu) % 5u)
				{
				case 4u:
					num = (int)(num2 * 480601447) ^ -1478076425;
					continue;
				case 2u:
					num = (int)(num2 * 1599458817) ^ -1890237350;
					continue;
				case 0u:
					_random = Dice.smethod_0((int)DateTime.Now.Ticks);
					num = ((int)num2 * -701201305) ^ 0x8AA7F75;
					continue;
				default:
					return;
				case 3u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public bool Roll(float chance)
	{
		double num = Dice.smethod_1(_random);
		return num <= (double)chance;
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
