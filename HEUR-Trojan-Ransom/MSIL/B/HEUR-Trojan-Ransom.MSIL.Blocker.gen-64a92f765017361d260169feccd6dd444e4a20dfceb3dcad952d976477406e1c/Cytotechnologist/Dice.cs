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
			int num = 1620135413;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x301EC0C0u) % 5u)
				{
				case 4u:
					result = num3 <= (double)chance;
					num = ((int)num2 * -1562389293) ^ -1442720707;
					continue;
				case 3u:
					num = ((int)num2 * -1712871540) ^ -2031935469;
					continue;
				case 2u:
					num3 = Dice.smethod_1(_random);
					num = ((int)num2 * -1185581914) ^ 0x7A83EBD0;
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
