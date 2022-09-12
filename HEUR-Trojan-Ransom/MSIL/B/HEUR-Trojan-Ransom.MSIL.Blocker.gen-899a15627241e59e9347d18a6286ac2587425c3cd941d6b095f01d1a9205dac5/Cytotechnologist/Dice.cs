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
			int num2 = -1491206103;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xD7D3D68Fu) % 4u)
				{
				case 2u:
					result = num <= (double)chance;
					num2 = ((int)num3 * -1359966329) ^ 0x31E20E54;
					continue;
				case 1u:
					num2 = ((int)num3 * -1020656556) ^ 0x1D6C19AC;
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
