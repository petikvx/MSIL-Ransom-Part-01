using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = -109309359;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF6EEAA00u) % 4u)
				{
				case 2u:
					_random = Dice.smethod_0((int)DateTime.Now.Ticks);
					num = (int)((num2 * 274371338) ^ 0x2C7AAE94);
					continue;
				case 1u:
					num = (int)(num2 * 541362511) ^ -733508971;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
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
			int num = -1535336367;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x98D64DE2u) % 3u)
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
				num = ((int)num2 * -2089515799) ^ 0xE0002D5;
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
