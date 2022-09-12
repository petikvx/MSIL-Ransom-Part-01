using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = 233920497;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FF6D9DEu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1030204723) ^ -991367245;
					continue;
				case 2u:
					_random = Dice.smethod_0((int)DateTime.Now.Ticks);
					num = ((int)num2 * -164934805) ^ 0x204F72E9;
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
		bool result = default(bool);
		while (true)
		{
			int num2 = -1444516310;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xF785490Fu) % 3u)
				{
				case 2u:
					goto IL_000e;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000e:
				result = num <= (double)chance;
				num2 = ((int)num3 * -583022061) ^ 0x34CAF258;
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
