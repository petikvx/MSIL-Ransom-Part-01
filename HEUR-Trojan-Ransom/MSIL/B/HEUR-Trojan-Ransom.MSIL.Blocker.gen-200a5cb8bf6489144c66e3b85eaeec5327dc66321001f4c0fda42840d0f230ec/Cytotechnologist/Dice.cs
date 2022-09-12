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
			int num = 1896720302;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x799CBAC1u) % 5u)
				{
				case 4u:
					num = (int)((num2 * 889489073) ^ 0xAF6DEE1);
					continue;
				case 3u:
					num3 = Dice.smethod_1(_random);
					num = (int)((num2 * 1755458728) ^ 0x54624F7F);
					continue;
				case 1u:
					result = num3 <= (double)chance;
					num = (int)(num2 * 1906852477) ^ -331166889;
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
