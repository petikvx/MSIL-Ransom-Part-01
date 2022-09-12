using System;

namespace Cytotechnologist;

public class ProgressBar
{
	private int _lastValue;

	public float Value
	{
		set
		{
			int num4 = default(int);
			float num3 = default(float);
			while (true)
			{
				int num = 385948886;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x42D2139Au) % 11u)
					{
					case 10u:
						_lastValue = num4;
						num = 232874435;
						continue;
					case 9u:
						ProgressBar.smethod_0(num4 + 1, 1);
						num = ((int)num2 * -234707509) ^ -921313231;
						continue;
					case 8u:
						num = (int)((num2 * 1671357267) ^ 0x38FE1B51);
						continue;
					case 6u:
						ProgressBar.smethod_1("{0:P1} ", (object)num3);
						num = (int)(num2 * 2102947264) ^ -1796102525;
						continue;
					case 5u:
						ProgressBar.smethod_0(num4 + 3, 1);
						num = ((int)num2 * -1588094517) ^ 0x1EA9E50A;
						continue;
					case 4u:
						num = (int)((num2 * 1149697203) ^ 0x2A3C5599);
						continue;
					case 3u:
					{
						num3 = value;
						num4 = (int)(num3 * 100f) + 1;
						int num5;
						int num6;
						if (num4 != _lastValue)
						{
							num5 = 953198203;
							num6 = 953198203;
						}
						else
						{
							num5 = 2060806501;
							num6 = 2060806501;
						}
						num = num5 ^ (int)(num2 * 111044415);
						continue;
					}
					case 2u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num3);
						num = (int)((num2 * 259649863) ^ 0x53B1079A);
						continue;
					case 1u:
						num = (int)(num2 * 890903294) ^ -1972983729;
						continue;
					default:
						return;
					case 0u:
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
