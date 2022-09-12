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
			int num = -1306185417;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD33BA4C8u) % 5u)
				{
				case 2u:
					result = num3 <= (double)chance;
					num = ((int)num2 * -1557803917) ^ 0x1657DEAD;
					continue;
				case 1u:
					num3 = Dice.smethod_1(_random);
					num = (int)((num2 * 1806831352) ^ 0x2CFA9442);
					continue;
				case 0u:
					num = ((int)num2 * -1929600326) ^ 0x647CD58;
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
