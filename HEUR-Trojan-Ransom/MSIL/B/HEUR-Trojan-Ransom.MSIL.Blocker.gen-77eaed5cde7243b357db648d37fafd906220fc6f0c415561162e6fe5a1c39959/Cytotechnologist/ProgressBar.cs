using System;

namespace Cytotechnologist;

public class ProgressBar
{
	private int _lastValue;

	public float Value
	{
		set
		{
			float num5 = default(float);
			int num6 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -3492633;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x93FA9BD9u) % 12u)
					{
					case 10u:
						num5 = value;
						num6 = (int)(num5 * 100f) + 1;
						num = ((int)num2 * -83576327) ^ 0x2FD697DD;
						continue;
					case 9u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num5);
						num = (int)(num2 * 1662559476) ^ -1510201659;
						continue;
					case 8u:
						num = (int)(num2 * 840580071) ^ -835903954;
						continue;
					case 7u:
						ProgressBar.smethod_0(num6 + 3, 1);
						num = ((int)num2 * -2076242294) ^ -318689290;
						continue;
					case 5u:
						_lastValue = num6;
						ProgressBar.smethod_0(num6 + 1, 1);
						num = -986097328;
						continue;
					case 4u:
						num = ((int)num2 * -246067695) ^ 0x681A922;
						continue;
					case 3u:
						num = (int)((num2 * 1349447278) ^ 0x3460F777);
						continue;
					case 2u:
						flag = num6 == _lastValue;
						num = ((int)num2 * -605994889) ^ -2031670369;
						continue;
					case 1u:
						ProgressBar.smethod_1("{0:P1} ", (object)num5);
						num = (int)((num2 * 584586380) ^ 0x246FD80E);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -420846794;
							num4 = -420846794;
						}
						else
						{
							num3 = -1904797420;
							num4 = -1904797420;
						}
						num = num3 ^ ((int)num2 * -1002155557);
						continue;
					}
					default:
						return;
					case 6u:
						break;
					case 11u:
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
