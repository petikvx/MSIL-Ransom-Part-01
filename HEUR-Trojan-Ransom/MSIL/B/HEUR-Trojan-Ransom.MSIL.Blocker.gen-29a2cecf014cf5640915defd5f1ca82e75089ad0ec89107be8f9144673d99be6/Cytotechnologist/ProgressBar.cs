using System;

namespace Cytotechnologist;

public class ProgressBar
{
	private int _lastValue;

	public float Value
	{
		set
		{
			float num4 = default(float);
			int num3 = default(int);
			while (true)
			{
				int num = -1735591379;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD1B7A047u) % 13u)
					{
					case 12u:
						ProgressBar.smethod_1("{0:P1} ", (object)num4);
						num = (int)(num2 * 889256359) ^ -1069917530;
						continue;
					case 9u:
						num4 = value;
						num3 = (int)(num4 * 100f) + 1;
						num = ((int)num2 * -496106187) ^ 0x73A107EB;
						continue;
					case 8u:
					{
						int num5;
						int num6;
						if (num3 == _lastValue)
						{
							num5 = -1083438236;
							num6 = -1083438236;
						}
						else
						{
							num5 = -103329250;
							num6 = -103329250;
						}
						num = num5 ^ (int)(num2 * 117712061);
						continue;
					}
					case 7u:
						num = ((int)num2 * -481901286) ^ -671735532;
						continue;
					case 6u:
						ProgressBar.smethod_0(num3 + 1, 1);
						num = ((int)num2 * -867566932) ^ -2115367194;
						continue;
					case 5u:
						num = ((int)num2 * -376751286) ^ -2058726408;
						continue;
					case 4u:
						ProgressBar.smethod_0(num3 + 3, 1);
						num = ((int)num2 * -1779002691) ^ 0x616B4594;
						continue;
					case 3u:
						num = ((int)num2 * -2053713699) ^ -1450859874;
						continue;
					case 2u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num4);
						num = ((int)num2 * -1485421142) ^ -848941586;
						continue;
					case 1u:
						_lastValue = num3;
						num = -1317399110;
						continue;
					case 0u:
						num = ((int)num2 * -1954883125) ^ -1297290491;
						continue;
					default:
						return;
					case 11u:
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
