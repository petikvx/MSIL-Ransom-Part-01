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
			int num = 672223951;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x18F33ADAu) % 5u)
				{
				case 4u:
					num3 = Dice.smethod_1(_random);
					num = ((int)num2 * -193027104) ^ 0x7F5FA9EE;
					continue;
				case 1u:
					result = num3 <= (double)chance;
					num = ((int)num2 * -978767378) ^ 0x2140057D;
					continue;
				case 0u:
					num = (int)(num2 * 851735962) ^ -2115098664;
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
