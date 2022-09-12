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
			int num = 1041421525;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x10E90768u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 302344110) ^ 0x36E9194C);
					continue;
				case 1u:
				{
					double num3 = Dice.smethod_1(_random);
					result = num3 <= (double)chance;
					num = (int)(num2 * 668235244) ^ -372873233;
					continue;
				}
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
