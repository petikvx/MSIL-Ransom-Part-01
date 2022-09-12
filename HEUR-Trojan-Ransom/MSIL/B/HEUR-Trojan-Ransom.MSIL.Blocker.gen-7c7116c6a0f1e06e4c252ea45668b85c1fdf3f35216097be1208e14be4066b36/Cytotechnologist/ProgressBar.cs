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
			int num4 = default(int);
			while (true)
			{
				int num = -1510063167;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF9B6A502u) % 13u)
					{
					case 12u:
						num3 = value;
						num = ((int)num2 * -977653376) ^ 0x3FA3DC0E;
						continue;
					case 11u:
					{
						int num5;
						int num6;
						if (num4 == _lastValue)
						{
							num5 = -1277220447;
							num6 = -1277220447;
						}
						else
						{
							num5 = -1024847797;
							num6 = -1024847797;
						}
						num = num5 ^ (int)(num2 * 791249374);
						continue;
					}
					case 10u:
						ProgressBar.smethod_1("{0:P1} ", (object)num3);
						num = (int)((num2 * 1877740690) ^ 0x305F3A2C);
						continue;
					case 9u:
						_lastValue = num4;
						num = -2122499314;
						continue;
					case 8u:
						num = (int)((num2 * 1414296065) ^ 0x1482F3AA);
						continue;
					case 7u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num3);
						num = ((int)num2 * -1110395564) ^ 0x70E82941;
						continue;
					case 6u:
						num = ((int)num2 * -85223108) ^ 0x4C2DE4DB;
						continue;
					case 5u:
						ProgressBar.smethod_0(num4 + 1, 1);
						num = (int)(num2 * 978300328) ^ -988662045;
						continue;
					case 4u:
						ProgressBar.smethod_0(num4 + 3, 1);
						num = ((int)num2 * -622430767) ^ 0x6C47DE5D;
						continue;
					case 1u:
						num = ((int)num2 * -1966583658) ^ -1487982501;
						continue;
					case 0u:
						num4 = (int)(num3 * 100f) + 1;
						num = ((int)num2 * -1214716416) ^ 0x48CD2B5C;
						continue;
					default:
						return;
					case 2u:
						break;
					case 3u:
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
