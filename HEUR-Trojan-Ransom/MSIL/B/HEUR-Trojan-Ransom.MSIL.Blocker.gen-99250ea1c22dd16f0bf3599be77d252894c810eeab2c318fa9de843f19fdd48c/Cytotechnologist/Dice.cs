using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = -1639754193;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84C1D266u) % 5u)
				{
				case 4u:
					_random = Dice.smethod_0((int)DateTime.Now.Ticks);
					num = (int)((num2 * 439764820) ^ 0x233729D0);
					continue;
				case 2u:
					num = ((int)num2 * -166479412) ^ 0x2C354284;
					continue;
				case 1u:
					num = (int)((num2 * 1564749899) ^ 0x34B001D4);
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public bool Roll(float chance)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 880098011;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29FEC6F2u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -523440445) ^ -86350113;
					continue;
				case 1u:
				{
					double num3 = Dice.smethod_1(_random);
					result = num3 <= (double)chance;
					num = ((int)num2 * -715729604) ^ 0x6D6467A4;
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
