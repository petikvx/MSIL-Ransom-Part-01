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
			bool flag = default(bool);
			while (true)
			{
				int num = 781053472;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x53CF3E82u) % 11u)
					{
					case 10u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num = (int)(num2 * 1464058342) ^ -1834865706;
						continue;
					case 9u:
						ProgressBar.smethod_0(num3 + 3, 1);
						num = (int)((num2 * 1886740567) ^ 0xB6EBD2E);
						continue;
					case 8u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1042317491;
							num5 = -1042317491;
						}
						else
						{
							num4 = -926592699;
							num5 = -926592699;
						}
						num = num4 ^ ((int)num2 * -1760827622);
						continue;
					}
					case 7u:
						num = ((int)num2 * -1849201014) ^ 0x640737F7;
						continue;
					case 5u:
						num = (int)((num2 * 529499901) ^ 0x4A9851F7);
						continue;
					case 4u:
						num = (int)((num2 * 327527017) ^ 0x3F534E8F);
						continue;
					case 3u:
						num3 = (int)(value * 100f) + 1;
						flag = num3 == _lastValue;
						num = ((int)num2 * -449847008) ^ -1676158418;
						continue;
					case 2u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num = (int)(num2 * 1199360712) ^ -1043476192;
						continue;
					case 1u:
						_lastValue = num3;
						ProgressBar.smethod_0(num3 + 1, 1);
						num = 62691949;
						continue;
					default:
						return;
					case 0u:
						break;
					case 6u:
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
