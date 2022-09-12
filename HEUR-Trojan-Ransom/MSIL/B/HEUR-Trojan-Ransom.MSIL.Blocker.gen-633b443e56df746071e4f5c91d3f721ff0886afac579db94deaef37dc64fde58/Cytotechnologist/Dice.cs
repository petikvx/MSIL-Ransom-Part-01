using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = -1162576703;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDB7F91D0u) % 5u)
				{
				case 4u:
					num = (int)((num2 * 218522793) ^ 0x540297B);
					continue;
				case 1u:
					num = ((int)num2 * -1750163578) ^ -284862014;
					continue;
				case 0u:
					_random = Dice.smethod_0((int)DateTime.Now.Ticks);
					num = (int)((num2 * 1205872000) ^ 0x44D09537);
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
		double num3 = default(double);
		while (true)
		{
			int num = 2039305693;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C210C82u) % 5u)
				{
				case 2u:
					result = num3 <= (double)chance;
					num = (int)(num2 * 1809415520) ^ -637624635;
					continue;
				case 1u:
					num3 = Dice.smethod_1(_random);
					num = ((int)num2 * -1843425835) ^ -1559275516;
					continue;
				case 0u:
					num = ((int)num2 * -2074660651) ^ -1217072850;
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
