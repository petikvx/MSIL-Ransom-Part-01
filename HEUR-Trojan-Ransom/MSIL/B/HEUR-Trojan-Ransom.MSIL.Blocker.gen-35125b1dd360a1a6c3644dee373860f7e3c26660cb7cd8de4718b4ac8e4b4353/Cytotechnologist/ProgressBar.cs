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
			bool flag = default(bool);
			while (true)
			{
				int num2 = -794699499;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xA746B873u) % 11u)
					{
					case 10u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num2 = (int)(num3 * 544920371) ^ -2090635533;
						continue;
					case 9u:
						flag = num == _lastValue;
						num2 = ((int)num3 * -1738726331) ^ 0x1A24E35F;
						continue;
					case 7u:
						ProgressBar.smethod_0(num + 1, 1);
						num2 = ((int)num3 * -1980199246) ^ 0x11982AF5;
						continue;
					case 6u:
						num2 = (int)((num3 * 1749138005) ^ 0x5BABEBC4);
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1843901726;
							num5 = 1843901726;
						}
						else
						{
							num4 = 1332039318;
							num5 = 1332039318;
						}
						num2 = num4 ^ ((int)num3 * -644234778);
						continue;
					}
					case 4u:
						num2 = ((int)num3 * -341903813) ^ -289512748;
						continue;
					case 3u:
						ProgressBar.smethod_0(num + 3, 1);
						num2 = ((int)num3 * -949278186) ^ 0x3039234B;
						continue;
					case 2u:
						_lastValue = num;
						num2 = -457857514;
						continue;
					case 1u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num2 = (int)(num3 * 1811944285) ^ -116683153;
						continue;
					default:
						return;
					case 0u:
						break;
					case 8u:
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
