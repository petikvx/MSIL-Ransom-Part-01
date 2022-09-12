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
			bool flag = num == _lastValue;
			while (true)
			{
				int num2 = 194199627;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x5A63428u) % 10u)
					{
					case 9u:
						_lastValue = num;
						ProgressBar.smethod_0(num + 1, 1);
						num2 = 1233019663;
						continue;
					case 8u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num2 = (int)(num3 * 1141917536) ^ -82637786;
						continue;
					case 7u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -813896265;
							num5 = -813896265;
						}
						else
						{
							num4 = -1456157344;
							num5 = -1456157344;
						}
						num2 = num4 ^ ((int)num3 * -1245106852);
						continue;
					}
					case 6u:
						num2 = ((int)num3 * -1080314593) ^ 0xAFEFA01;
						continue;
					case 5u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num2 = (int)(num3 * 1057630212) ^ -869637718;
						continue;
					case 3u:
						num2 = (int)(num3 * 899921872) ^ -446853045;
						continue;
					case 1u:
						ProgressBar.smethod_0(num + 3, 1);
						num2 = (int)((num3 * 286610223) ^ 0x5A14C90D);
						continue;
					case 0u:
						num2 = ((int)num3 * -1403999318) ^ 0x7572BF16;
						continue;
					default:
						return;
					case 4u:
						break;
					case 2u:
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
