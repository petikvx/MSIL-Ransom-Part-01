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
			while (true)
			{
				int num = 119353953;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x675EA4C4u) % 9u)
					{
					case 8u:
						ProgressBar.smethod_0(num3 + 1, 1);
						num = (int)(num2 * 2102346610) ^ -94277903;
						continue;
					case 7u:
						num3 = (int)(value * 100f) + 1;
						num = ((int)num2 * -2093493030) ^ -876316510;
						continue;
					case 6u:
						_lastValue = num3;
						num = 477167855;
						continue;
					case 5u:
						ProgressBar.smethod_0(num3 + 3, 1);
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num = ((int)num2 * -90192039) ^ 0xC46CD02;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (num3 != _lastValue)
						{
							num4 = -1950870173;
							num5 = -1950870173;
						}
						else
						{
							num4 = -1651892173;
							num5 = -1651892173;
						}
						num = num4 ^ (int)(num2 * 2118607110);
						continue;
					}
					case 2u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num = (int)(num2 * 611975908) ^ -62483398;
						continue;
					case 1u:
						num = (int)(num2 * 1102521524) ^ -726314718;
						continue;
					default:
						return;
					case 0u:
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
