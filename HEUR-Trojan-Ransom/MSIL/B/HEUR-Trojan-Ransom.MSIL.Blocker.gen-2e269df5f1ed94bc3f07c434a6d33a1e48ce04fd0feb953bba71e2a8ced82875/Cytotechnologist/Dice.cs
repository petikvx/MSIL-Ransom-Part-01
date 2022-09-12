using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = -1142562282;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB07949Du) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1714349594) ^ -448973607;
					continue;
				case 2u:
					_random = Dice.smethod_0((int)DateTime.Now.Ticks);
					num = ((int)num2 * -948962472) ^ 0x1BBAC490;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public bool Roll(float chance)
	{
		double num = Dice.smethod_1(_random);
		bool result = num <= (double)chance;
		while (true)
		{
			int num2 = 1586901027;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x3BF00F75u) % 3u)
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
				num2 = (int)(num3 * 1665347197) ^ -426191809;
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
