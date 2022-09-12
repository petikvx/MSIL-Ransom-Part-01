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
				int num = -829752103;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB9E1BC55u) % 11u)
					{
					case 9u:
						num4 = value;
						num = ((int)num2 * -1318514914) ^ 0x46C08FDA;
						continue;
					case 7u:
						ProgressBar.smethod_0(num3 + 3, 1);
						num = (int)(num2 * 1003094146) ^ -1302653584;
						continue;
					case 6u:
						num = ((int)num2 * -1258373953) ^ -1980324064;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (num3 != _lastValue)
						{
							num5 = 451902411;
							num6 = 451902411;
						}
						else
						{
							num5 = 1583238113;
							num6 = 1583238113;
						}
						num = num5 ^ ((int)num2 * -769492717);
						continue;
					}
					case 4u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num4);
						num = ((int)num2 * -532008278) ^ -1799377761;
						continue;
					case 3u:
						num = (int)((num2 * 1657842119) ^ 0x547F7EF0);
						continue;
					case 2u:
						num3 = (int)(num4 * 100f) + 1;
						num = (int)(num2 * 44515782) ^ -1973993313;
						continue;
					case 1u:
						ProgressBar.smethod_1("{0:P1} ", (object)num4);
						num = ((int)num2 * -607449857) ^ 0x58C959E0;
						continue;
					case 0u:
						_lastValue = num3;
						ProgressBar.smethod_0(num3 + 1, 1);
						num = -318769605;
						continue;
					default:
						return;
					case 8u:
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
