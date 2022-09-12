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
		bool result = default(bool);
		while (true)
		{
			int num = -185059869;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3AB35F1u) % 4u)
				{
				case 2u:
				{
					double num3 = Dice.smethod_1(_random);
					result = num3 <= (double)chance;
					num = ((int)num2 * -1264092114) ^ 0x5199A698;
					continue;
				}
				case 1u:
					num = ((int)num2 * -244585326) ^ -527759017;
					continue;
				case 3u:
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
