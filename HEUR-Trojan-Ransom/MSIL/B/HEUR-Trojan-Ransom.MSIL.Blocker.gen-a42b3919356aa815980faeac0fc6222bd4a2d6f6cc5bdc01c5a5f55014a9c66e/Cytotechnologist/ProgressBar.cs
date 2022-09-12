using System;

namespace Cytotechnologist;

public class ProgressBar
{
	private int _lastValue;

	public float Value
	{
		set
		{
			int num = (int)(value * 100f) + 1;
			bool flag = default(bool);
			while (true)
			{
				int num2 = -978346089;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xEC883633u) % 13u)
					{
					case 12u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1591169159;
							num5 = -1591169159;
						}
						else
						{
							num4 = -1237248031;
							num5 = -1237248031;
						}
						num2 = num4 ^ ((int)num3 * -1736316464);
						continue;
					}
					case 11u:
						num2 = (int)(num3 * 332771811) ^ -1130592957;
						continue;
					case 10u:
						flag = num == _lastValue;
						num2 = ((int)num3 * -31320283) ^ 0x6E476011;
						continue;
					case 9u:
						ProgressBar.smethod_0(num + 3, 1);
						num2 = (int)((num3 * 1845348937) ^ 0x5E081E66);
						continue;
					case 7u:
						num2 = ((int)num3 * -1567550368) ^ -1106945345;
						continue;
					case 6u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num2 = (int)(num3 * 933209614) ^ -1467954023;
						continue;
					case 5u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num2 = ((int)num3 * -1085694733) ^ 0x1617A922;
						continue;
					case 4u:
						num2 = (int)((num3 * 1534916564) ^ 0x5F25A599);
						continue;
					case 3u:
						num2 = ((int)num3 * -587569962) ^ 0x2C403DD7;
						continue;
					case 2u:
						_lastValue = num;
						num2 = -353704273;
						continue;
					case 1u:
						ProgressBar.smethod_0(num + 1, 1);
						num2 = ((int)num3 * -1261122152) ^ -212222878;
						continue;
					default:
						return;
					case 8u:
						break;
					case 0u:
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
