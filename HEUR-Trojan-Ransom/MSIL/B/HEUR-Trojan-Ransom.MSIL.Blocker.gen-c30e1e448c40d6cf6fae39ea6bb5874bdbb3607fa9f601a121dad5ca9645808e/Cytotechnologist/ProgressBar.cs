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
				int num2 = -2008534071;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xC14B172Eu) % 8u)
					{
					case 7u:
						flag = num == _lastValue;
						num2 = ((int)num3 * -452627303) ^ -1727890201;
						continue;
					case 6u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 2134096535;
							num5 = 2134096535;
						}
						else
						{
							num4 = 1372771164;
							num5 = 1372771164;
						}
						num2 = num4 ^ ((int)num3 * -1077812980);
						continue;
					}
					case 3u:
						ProgressBar.smethod_0(num + 1, 1);
						num2 = ((int)num3 * -1580010158) ^ 0x6A532EE0;
						continue;
					case 2u:
						_lastValue = num;
						num2 = -1572464611;
						continue;
					case 1u:
						ProgressBar.smethod_0(num + 3, 1);
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num2 = (int)(num3 * 961580082) ^ -1378536687;
						continue;
					case 0u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num2 = ((int)num3 * -1959894312) ^ 0xECDA443;
						continue;
					default:
						return;
					case 4u:
						break;
					case 5u:
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
