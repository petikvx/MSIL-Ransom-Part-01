using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = -1013028819;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x964072A3u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
					_random = Dice.smethod_0((int)DateTime.Now.Ticks);
					return;
				}
				break;
				IL_0008:
				num = (int)((num2 * 257870426) ^ 0x655A33C1);
			}
		}
	}

	public bool Roll(float chance)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1283619123;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C185BE2u) % 3u)
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
				num = ((int)num2 * -1569324540) ^ -1090059469;
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
