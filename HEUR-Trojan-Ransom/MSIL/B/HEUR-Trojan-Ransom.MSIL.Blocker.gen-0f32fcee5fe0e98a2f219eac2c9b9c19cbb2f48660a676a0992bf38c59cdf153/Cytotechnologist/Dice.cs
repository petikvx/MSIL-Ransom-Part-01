using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = -1729285771;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x99209E33u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -8555288) ^ -1399453646;
					continue;
				case 1u:
					num = (int)(num2 * 148806941) ^ -1971771243;
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
