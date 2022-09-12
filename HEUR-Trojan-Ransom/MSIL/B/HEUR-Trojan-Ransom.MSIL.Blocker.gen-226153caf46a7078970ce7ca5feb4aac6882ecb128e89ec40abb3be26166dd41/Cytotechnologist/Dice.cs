using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = -2085050973;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBF39664Au) % 4u)
				{
				case 1u:
					num = ((int)num2 * -117073404) ^ -798284530;
					continue;
				case 0u:
					_random = Dice.smethod_0((int)DateTime.Now.Ticks);
					num = ((int)num2 * -2078602375) ^ 0x22111308;
					continue;
				default:
					return;
				case 3u:
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
		bool result = default(bool);
		while (true)
		{
			int num = -1986374792;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA8A9DF37u) % 4u)
				{
				case 3u:
				{
					double num3 = Dice.smethod_1(_random);
					result = num3 <= (double)chance;
					num = (int)(num2 * 480222764) ^ -824657407;
					continue;
				}
				case 2u:
					num = (int)((num2 * 205037613) ^ 0x3436829C);
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
