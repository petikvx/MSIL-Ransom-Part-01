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
			int num = 1493802928;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3C8848ADu) % 4u)
				{
				case 3u:
					result = num3 <= (double)chance;
					num = ((int)num2 * -629187409) ^ 0x395D8B9A;
					continue;
				case 1u:
					num3 = Dice.smethod_1(_random);
					num = ((int)num2 * -842910654) ^ -349852688;
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
