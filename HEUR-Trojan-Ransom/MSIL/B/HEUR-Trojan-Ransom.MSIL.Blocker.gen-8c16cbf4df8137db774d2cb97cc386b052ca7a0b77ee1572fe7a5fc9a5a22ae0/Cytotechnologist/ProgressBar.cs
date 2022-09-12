using System;

namespace Cytotechnologist;

public class ProgressBar
{
	private int _lastValue;

	public float Value
	{
		set
		{
			float num3 = default(float);
			bool flag = default(bool);
			int num4 = default(int);
			while (true)
			{
				int num = 1140876685;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x32AB99u) % 15u)
					{
					case 14u:
						num3 = value;
						num = ((int)num2 * -1013891023) ^ -914451292;
						continue;
					case 13u:
						ProgressBar.smethod_1("{0:P1} ", (object)num3);
						num = ((int)num2 * -2049558450) ^ 0x5F76D5CA;
						continue;
					case 12u:
						num = ((int)num2 * -1958884642) ^ 0xACE92D8;
						continue;
					case 11u:
						num = (int)(num2 * 1841604246) ^ -720214093;
						continue;
					case 10u:
						num = (int)((num2 * 2120890446) ^ 0x622DCC68);
						continue;
					case 8u:
						flag = num4 == _lastValue;
						num = ((int)num2 * -130533982) ^ -1883026631;
						continue;
					case 6u:
						_lastValue = num4;
						num = 633060473;
						continue;
					case 5u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num3);
						num = (int)((num2 * 956403507) ^ 0x14FF5DA9);
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (!flag)
						{
							num5 = 1699901807;
							num6 = 1699901807;
						}
						else
						{
							num5 = 22031058;
							num6 = 22031058;
						}
						num = num5 ^ ((int)num2 * -1743587547);
						continue;
					}
					case 3u:
						ProgressBar.smethod_0(num4 + 3, 1);
						num = ((int)num2 * -528195615) ^ -2138260610;
						continue;
					case 2u:
						num = (int)(num2 * 421228281) ^ -2094519148;
						continue;
					case 1u:
						ProgressBar.smethod_0(num4 + 1, 1);
						num = ((int)num2 * -1275839384) ^ -629538441;
						continue;
					case 0u:
						num4 = (int)(num3 * 100f) + 1;
						num = (int)((num2 * 1350349580) ^ 0x7389821C);
						continue;
					default:
						return;
					case 9u:
						break;
					case 7u:
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
