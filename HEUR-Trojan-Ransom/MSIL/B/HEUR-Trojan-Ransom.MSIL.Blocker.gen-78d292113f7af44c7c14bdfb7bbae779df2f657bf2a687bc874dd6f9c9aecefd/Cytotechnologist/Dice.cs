using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = 1782739107;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBD2A731u) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
					_random = Dice.smethod_0((int)DateTime.Now.Ticks);
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -1570475010) ^ 0x4881D4F6;
			}
		}
	}

	public bool Roll(float chance)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -854211699;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAFFEABA2u) % 4u)
				{
				case 3u:
				{
					double num3 = Dice.smethod_1(_random);
					result = num3 <= (double)chance;
					num = (int)(num2 * 1458184859) ^ -1408003719;
					continue;
				}
				case 2u:
					num = (int)(num2 * 507273219) ^ -1001954751;
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
