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
			int num = -2019811156;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D28D554u) % 5u)
				{
				case 4u:
					result = num3 <= (double)chance;
					num = ((int)num2 * -266943017) ^ -1401722148;
					continue;
				case 3u:
					num3 = Dice.smethod_1(_random);
					num = ((int)num2 * -1783105459) ^ 0x37287A83;
					continue;
				case 1u:
					num = ((int)num2 * -750305794) ^ -390357446;
					continue;
				case 2u:
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
