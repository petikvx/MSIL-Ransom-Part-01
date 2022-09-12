using System;

namespace Cytotechnologist;

public class ProgressBar
{
	private int _lastValue;

	public float Value
	{
		set
		{
			bool flag = default(bool);
			int num3 = default(int);
			while (true)
			{
				int num = 1513870250;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x50A55045u) % 11u)
					{
					case 9u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num = (int)((num2 * 88896265) ^ 0x6B957DB5);
						continue;
					case 8u:
						flag = num3 == _lastValue;
						num = ((int)num2 * -542807478) ^ -1403139034;
						continue;
					case 7u:
						_lastValue = num3;
						ProgressBar.smethod_0(num3 + 1, 1);
						num = 124476066;
						continue;
					case 5u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num = (int)((num2 * 861766152) ^ 0x2E2ED108);
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1118866985;
							num5 = 1118866985;
						}
						else
						{
							num4 = 947712381;
							num5 = 947712381;
						}
						num = num4 ^ ((int)num2 * -75460537);
						continue;
					}
					case 3u:
						num3 = (int)(value * 100f) + 1;
						num = (int)((num2 * 526451663) ^ 0x7ABDE432);
						continue;
					case 2u:
						num = ((int)num2 * -581072102) ^ -205832152;
						continue;
					case 1u:
						num = ((int)num2 * -1742483805) ^ -1661008329;
						continue;
					case 0u:
						ProgressBar.smethod_0(num3 + 3, 1);
						num = (int)(num2 * 949562736) ^ -1611467668;
						continue;
					default:
						return;
					case 6u:
						break;
					case 10u:
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
