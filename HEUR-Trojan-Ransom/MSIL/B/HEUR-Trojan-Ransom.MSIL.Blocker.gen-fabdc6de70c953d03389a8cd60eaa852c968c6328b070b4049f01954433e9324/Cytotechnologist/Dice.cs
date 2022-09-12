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
			int num = 207148224;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x28E5DD9Fu) % 5u)
				{
				case 4u:
					num3 = Dice.smethod_1(_random);
					num = (int)(num2 * 223728865) ^ -1535639657;
					continue;
				case 3u:
					result = num3 <= (double)chance;
					num = (int)((num2 * 923522272) ^ 0x16F70CB1);
					continue;
				case 2u:
					num = ((int)num2 * -1402906594) ^ -1735477725;
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
