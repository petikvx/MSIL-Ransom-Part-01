using System;

namespace Cytotechnologist;

public class Dice
{
	private readonly Random _random;

	public Dice()
	{
		while (true)
		{
			int num = 752730080;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x76857FA5u) % 5u)
				{
				case 4u:
					num = (int)(num2 * 675224496) ^ -1211565505;
					continue;
				case 3u:
					_random = Dice.smethod_0((int)DateTime.Now.Ticks);
					num = (int)(num2 * 1078714510) ^ -334873847;
					continue;
				case 1u:
					num = (int)(num2 * 1433685063) ^ -558890051;
					continue;
				default:
					return;
				case 0u:
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
			int num = 586674450;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC67CB9Fu) % 4u)
				{
				case 3u:
					result = num3 <= (double)chance;
					num = (int)((num2 * 1171600876) ^ 0x7A67E193);
					continue;
				case 1u:
					num3 = Dice.smethod_1(_random);
					num = ((int)num2 * -1084830828) ^ 0x4A969FA8;
					continue;
				case 2u:
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
