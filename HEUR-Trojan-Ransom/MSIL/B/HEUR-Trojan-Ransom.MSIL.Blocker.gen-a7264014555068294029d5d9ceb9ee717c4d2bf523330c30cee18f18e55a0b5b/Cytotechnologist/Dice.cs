using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = -1090584692;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9035A86Du) % 4u)
				{
				case 3u:
					_random = Dice.smethod_0((int)DateTime.Now.Ticks);
					num = ((int)num2 * -49471263) ^ -381363092;
					continue;
				case 1u:
					num = (int)(num2 * 158369763) ^ -223998939;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public bool Roll(float chance)
	{
		double num = Dice.smethod_1(_random);
		bool result = default(bool);
		while (true)
		{
			int num2 = 127939231;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x50329930u) % 4u)
				{
				case 3u:
					result = num <= (double)chance;
					num2 = (int)((num3 * 1711004213) ^ 0x7AECA379);
					continue;
				case 2u:
					num2 = (int)(num3 * 1934077269) ^ -2142934589;
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
