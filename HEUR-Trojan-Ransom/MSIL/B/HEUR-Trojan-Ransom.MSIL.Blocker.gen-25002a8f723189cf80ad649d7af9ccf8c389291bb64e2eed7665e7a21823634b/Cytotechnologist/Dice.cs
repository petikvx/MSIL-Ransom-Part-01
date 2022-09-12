using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = 430895854;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C95EE14u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				_random = Dice.smethod_0((int)DateTime.Now.Ticks);
				num = ((int)num2 * -277798731) ^ -364741636;
			}
		}
	}

	public bool Roll(float chance)
	{
		double num = Dice.smethod_1(_random);
		bool result = default(bool);
		while (true)
		{
			int num2 = 1038814436;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xF3D7E36u) % 4u)
				{
				case 3u:
					num2 = ((int)num3 * -2124838616) ^ -796630405;
					continue;
				case 2u:
					result = num <= (double)chance;
					num2 = ((int)num3 * -2006492302) ^ -887981571;
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
