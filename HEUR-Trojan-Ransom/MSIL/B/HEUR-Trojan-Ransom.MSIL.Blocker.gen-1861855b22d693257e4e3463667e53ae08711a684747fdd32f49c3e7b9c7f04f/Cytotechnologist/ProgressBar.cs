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
			bool flag = default(bool);
			while (true)
			{
				int num = -1359872407;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x839C4ACEu) % 10u)
					{
					case 8u:
						num = ((int)num2 * -1575351778) ^ 0x716F2051;
						continue;
					case 7u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num4);
						num = (int)(num2 * 378712183) ^ -711741445;
						continue;
					case 6u:
						num = ((int)num2 * -1196504778) ^ 0x3BC8DF1D;
						continue;
					case 5u:
						ProgressBar.smethod_0(num3 + 1, 1);
						num = (int)((num2 * 1676721023) ^ 0x673D33F8);
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = -1891466546;
							num6 = -1891466546;
						}
						else
						{
							num5 = -1869202562;
							num6 = -1869202562;
						}
						num = num5 ^ ((int)num2 * -579234756);
						continue;
					}
					case 2u:
						_lastValue = num3;
						num = -1858893299;
						continue;
					case 1u:
						num4 = value;
						num3 = (int)(num4 * 100f) + 1;
						flag = num3 == _lastValue;
						num = ((int)num2 * -369655268) ^ 0x3B514D71;
						continue;
					case 0u:
						ProgressBar.smethod_0(num3 + 3, 1);
						ProgressBar.smethod_1("{0:P1} ", (object)num4);
						num = (int)(num2 * 1350019986) ^ -756724444;
						continue;
					default:
						return;
					case 4u:
						break;
					case 9u:
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
