using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = -1480670377;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8FB6A219u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 454381813) ^ -312476358;
					continue;
				case 1u:
					num = ((int)num2 * -1520136135) ^ 0x406BFF68;
					continue;
				case 3u:
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
		double num = Dice.smethod_1(_random);
		bool result = default(bool);
		while (true)
		{
			int num2 = 1484758238;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x61A51D26u) % 3u)
				{
				case 1u:
					goto IL_000e;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000e:
				result = num <= (double)chance;
				num2 = ((int)num3 * -1216714108) ^ -390344588;
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
