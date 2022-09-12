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
			while (true)
			{
				int num2 = -1557596943;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x80F90760u) % 10u)
					{
					case 9u:
						num2 = (int)((num3 * 1764784635) ^ 0x7D347561);
						continue;
					case 8u:
						ProgressBar.smethod_0(num + 3, 1);
						num2 = ((int)num3 * -1445391344) ^ 0x25224D9D;
						continue;
					case 7u:
					{
						int num4;
						int num5;
						if (num != _lastValue)
						{
							num4 = 285762123;
							num5 = 285762123;
						}
						else
						{
							num4 = 392445341;
							num5 = 392445341;
						}
						num2 = num4 ^ (int)(num3 * 1069411369);
						continue;
					}
					case 6u:
						_lastValue = num;
						num2 = -1107406727;
						continue;
					case 5u:
						ProgressBar.smethod_0(num + 1, 1);
						num2 = ((int)num3 * -1991934594) ^ -1342391151;
						continue;
					case 3u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num2 = ((int)num3 * -2097842210) ^ -1257156699;
						continue;
					case 1u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num2 = (int)((num3 * 1936032319) ^ 0x758C3E51);
						continue;
					case 0u:
						num2 = ((int)num3 * -537309673) ^ 0x2F317862;
						continue;
					default:
						return;
					case 2u:
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
