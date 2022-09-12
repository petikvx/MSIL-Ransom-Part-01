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
			int num = 1352854675;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30B30D95u) % 4u)
				{
				case 2u:
				{
					double num3 = Dice.smethod_1(_random);
					result = num3 <= (double)chance;
					num = ((int)num2 * -2128755896) ^ 0x13A1E79C;
					continue;
				}
				case 1u:
					num = (int)((num2 * 1658808395) ^ 0x3902982A);
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
