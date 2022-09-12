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
		double num = Dice.smethod_1(_random);
		bool result = num <= (double)chance;
		while (true)
		{
			int num2 = 764365581;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x68D51015u) % 3u)
				{
				case 1u:
					goto IL_0017;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0017:
				num2 = (int)((num3 * 1312611875) ^ 0xD2DBBC7);
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
