using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = 895997040;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5AB34E83u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -181485186) ^ -1538741580;
					continue;
				case 1u:
					num = ((int)num2 * -458242519) ^ 0x20A5ACBC;
					continue;
				case 0u:
					break;
				default:
					_random = Dice.smethod_0((int)DateTime.Now.Ticks);
					return;
				}
				break;
			}
		}
	}

	public bool Roll(float chance)
	{
		bool result = default(bool);
		double num3 = default(double);
		while (true)
		{
			int num = -1914830863;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9426E058u) % 5u)
				{
				case 2u:
					result = num3 <= (double)chance;
					num = ((int)num2 * -172282035) ^ 0x152AF081;
					continue;
				case 1u:
					num3 = Dice.smethod_1(_random);
					num = (int)((num2 * 1061236993) ^ 0x4E1D446A);
					continue;
				case 0u:
					num = ((int)num2 * -384461018) ^ -1558877730;
					continue;
				case 4u:
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
