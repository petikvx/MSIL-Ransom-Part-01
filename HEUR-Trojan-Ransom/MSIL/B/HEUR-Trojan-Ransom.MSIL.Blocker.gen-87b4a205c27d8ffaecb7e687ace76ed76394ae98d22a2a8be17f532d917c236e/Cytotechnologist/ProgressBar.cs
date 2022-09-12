using System;

namespace Cytotechnologist;

public class ProgressBar
{
	private int _lastValue;

	public float Value
	{
		set
		{
			int num3 = default(int);
			while (true)
			{
				int num = 1923075097;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5B532B8Bu) % 11u)
					{
					case 10u:
						_lastValue = num3;
						ProgressBar.smethod_0(num3 + 1, 1);
						num = 1561091673;
						continue;
					case 9u:
					{
						num3 = (int)(value * 100f) + 1;
						int num4;
						int num5;
						if (num3 == _lastValue)
						{
							num4 = 472254989;
							num5 = 472254989;
						}
						else
						{
							num4 = 1797931292;
							num5 = 1797931292;
						}
						num = num4 ^ ((int)num2 * -951227399);
						continue;
					}
					case 8u:
						ProgressBar.smethod_0(num3 + 3, 1);
						num = ((int)num2 * -1563378170) ^ 0x1C5F39C5;
						continue;
					case 7u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num = (int)(num2 * 234639640) ^ -1887018985;
						continue;
					case 6u:
						num = ((int)num2 * -1912152831) ^ -16306910;
						continue;
					case 5u:
						num = ((int)num2 * -1856328606) ^ -803639746;
						continue;
					case 3u:
						num = (int)((num2 * 2054379020) ^ 0x20592576);
						continue;
					case 2u:
						num = ((int)num2 * -1532391679) ^ 0x51C3B21F;
						continue;
					case 1u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num = ((int)num2 * -1871888009) ^ 0xE6A1A39;
						continue;
					default:
						return;
					case 0u:
						break;
					case 4u:
						return;
					}
					break;
				}
			}
		}
	}

	static void smethod_0(int int_0, int int_1)
	{
		Console.SetCursorPosition(int_0, int_1);
	}

	static void smethod_1(string string_0, object object_0)
	{
		Console.Write(string_0, object_0);
	}
}
