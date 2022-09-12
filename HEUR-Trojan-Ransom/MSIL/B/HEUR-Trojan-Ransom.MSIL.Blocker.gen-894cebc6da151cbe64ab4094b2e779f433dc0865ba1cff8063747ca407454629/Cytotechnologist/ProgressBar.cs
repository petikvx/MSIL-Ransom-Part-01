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
			float num4 = default(float);
			bool flag = default(bool);
			while (true)
			{
				int num = 2053913875;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x395AD11Bu) % 12u)
					{
					case 11u:
						num3 = (int)(num4 * 100f) + 1;
						num = ((int)num2 * -322464715) ^ 0x987E8A2;
						continue;
					case 9u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = 682862672;
							num6 = 682862672;
						}
						else
						{
							num5 = 462754097;
							num6 = 462754097;
						}
						num = num5 ^ ((int)num2 * -1913747712);
						continue;
					}
					case 8u:
						num4 = value;
						num = (int)(num2 * 60939641) ^ -139239420;
						continue;
					case 7u:
						num = ((int)num2 * -727863093) ^ -2064899281;
						continue;
					case 6u:
						flag = num3 == _lastValue;
						num = ((int)num2 * -1450319358) ^ -1603848310;
						continue;
					case 5u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num4);
						num = ((int)num2 * -1650797979) ^ -1575191583;
						continue;
					case 4u:
						num = (int)(num2 * 901789859) ^ -934121750;
						continue;
					case 3u:
						ProgressBar.smethod_0(num3 + 3, 1);
						ProgressBar.smethod_1("{0:P1} ", (object)num4);
						num = ((int)num2 * -1358795499) ^ -460234144;
						continue;
					case 2u:
						_lastValue = num3;
						ProgressBar.smethod_0(num3 + 1, 1);
						num = 608933266;
						continue;
					case 0u:
						num = (int)(num2 * 479751634) ^ -480395413;
						continue;
					default:
						return;
					case 10u:
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
