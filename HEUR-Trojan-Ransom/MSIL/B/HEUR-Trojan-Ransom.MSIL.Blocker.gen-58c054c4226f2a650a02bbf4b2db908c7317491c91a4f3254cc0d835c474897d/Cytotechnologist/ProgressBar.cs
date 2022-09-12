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
				int num = 477471001;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5B6EC8CEu) % 12u)
					{
					case 11u:
						ProgressBar.smethod_0(num3 + 3, 1);
						num = ((int)num2 * -1818085023) ^ 0x1B136446;
						continue;
					case 10u:
						num = (int)(num2 * 938937492) ^ -1199344777;
						continue;
					case 9u:
						num = ((int)num2 * -783036868) ^ 0x1D21F189;
						continue;
					case 7u:
						num3 = (int)(value * 100f) + 1;
						num = (int)((num2 * 1051525691) ^ 0x61E8F8FA);
						continue;
					case 6u:
						_lastValue = num3;
						ProgressBar.smethod_0(num3 + 1, 1);
						num = 724021922;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (num3 != _lastValue)
						{
							num4 = 1184852568;
							num5 = 1184852568;
						}
						else
						{
							num4 = 96457467;
							num5 = 96457467;
						}
						num = num4 ^ (int)(num2 * 241059816);
						continue;
					}
					case 4u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num = ((int)num2 * -180270387) ^ -966365718;
						continue;
					case 3u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num = ((int)num2 * -1042545031) ^ -134943301;
						continue;
					case 1u:
						num = (int)((num2 * 547572800) ^ 0x203E5FFC);
						continue;
					case 0u:
						num = (int)(num2 * 284760928) ^ -1817365828;
						continue;
					default:
						return;
					case 8u:
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
