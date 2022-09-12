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
			int num = 1929786123;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x290AB64u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				double num3 = Dice.smethod_1(_random);
				result = num3 <= (double)chance;
				num = (int)(num2 * 718131119) ^ -547616026;
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
