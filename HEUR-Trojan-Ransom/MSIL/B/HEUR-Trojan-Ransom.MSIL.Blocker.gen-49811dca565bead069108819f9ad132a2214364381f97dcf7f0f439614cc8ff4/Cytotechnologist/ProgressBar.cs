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
				int num2 = -644878615;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x888D6D6Eu) % 10u)
					{
					case 9u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1812304196;
							num5 = -1812304196;
						}
						else
						{
							num4 = -767535887;
							num5 = -767535887;
						}
						num2 = num4 ^ ((int)num3 * -2106091478);
						continue;
					}
					case 7u:
						ProgressBar.smethod_0(num + 3, 1);
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num2 = (int)((num3 * 1797561216) ^ 0x5EAEAD5F);
						continue;
					case 6u:
						num2 = ((int)num3 * -1724146551) ^ -595132791;
						continue;
					case 5u:
						num2 = ((int)num3 * -1705907641) ^ 0x4FEAB1F7;
						continue;
					case 4u:
						ProgressBar.smethod_0(num + 1, 1);
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num2 = (int)((num3 * 14865493) ^ 0x7052E4);
						continue;
					case 3u:
						_lastValue = num;
						num2 = -1184206304;
						continue;
					case 2u:
						num2 = (int)((num3 * 152981071) ^ 0x3C8FDE97);
						continue;
					case 0u:
						num2 = ((int)num3 * -795220274) ^ -1459845207;
						continue;
					default:
						return;
					case 8u:
						break;
					case 1u:
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
