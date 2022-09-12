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
				int num = 1439864627;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x31D45BB5u) % 14u)
					{
					case 13u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num5);
						num = ((int)num2 * -863242513) ^ 0x2500E843;
						continue;
					case 12u:
						num5 = value;
						num = (int)(num2 * 1531092160) ^ -1981538725;
						continue;
					case 11u:
						_lastValue = num6;
						ProgressBar.smethod_0(num6 + 1, 1);
						num = 266347836;
						continue;
					case 10u:
						ProgressBar.smethod_0(num6 + 3, 1);
						num = ((int)num2 * -169038116) ^ 0x300CDCE2;
						continue;
					case 9u:
						num = (int)((num2 * 128910999) ^ 0x7DEFA03B);
						continue;
					case 8u:
						num = (int)((num2 * 521365536) ^ 0x36E293EB);
						continue;
					case 7u:
						num = ((int)num2 * -1210889112) ^ 0x3472E03;
						continue;
					case 5u:
						ProgressBar.smethod_1("{0:P1} ", (object)num5);
						num = (int)((num2 * 387652258) ^ 0x6A71D1A8);
						continue;
					case 3u:
						num = (int)((num2 * 1050638464) ^ 0x70200ADB);
						continue;
					case 2u:
						num6 = (int)(num5 * 100f) + 1;
						num = (int)((num2 * 1341075519) ^ 0x49394116);
						continue;
					case 1u:
						flag = num6 == _lastValue;
						num = ((int)num2 * -1162392469) ^ -591115690;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1335723969;
							num4 = 1335723969;
						}
						else
						{
							num3 = 1069969904;
							num4 = 1069969904;
						}
						num = num3 ^ (int)(num2 * 1056369377);
						continue;
					}
					default:
						return;
					case 6u:
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
