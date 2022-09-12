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
			int num = 1153530885;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x20E708CDu) % 5u)
				{
				case 4u:
					num3 = Dice.smethod_1(_random);
					num = ((int)num2 * -424394580) ^ -256261671;
					continue;
				case 2u:
					result = num3 <= (double)chance;
					num = ((int)num2 * -1547869001) ^ 0x306A9070;
					continue;
				case 1u:
					num = (int)((num2 * 1860006048) ^ 0x46014174);
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
