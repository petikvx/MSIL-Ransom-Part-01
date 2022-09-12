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
		while (true)
		{
			int num = -89934287;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDAF31842u) % 4u)
				{
				case 3u:
				{
					double num3 = Dice.smethod_1(_random);
					result = num3 <= (double)chance;
					num = (int)(num2 * 1489284302) ^ -1324714239;
					continue;
				}
				case 1u:
					num = ((int)num2 * -1412329516) ^ 0x68F4E754;
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
