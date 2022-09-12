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
				int num2 = 1567390296;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x5496B7C1u) % 13u)
					{
					case 12u:
						ProgressBar.smethod_0(num + 1, 1);
						num2 = ((int)num3 * -1666362897) ^ -1270007390;
						continue;
					case 10u:
						num2 = (int)((num3 * 675584116) ^ 0x3C36FDFC);
						continue;
					case 9u:
						_lastValue = num;
						num2 = 1832528262;
						continue;
					case 8u:
						num2 = ((int)num3 * -1731325051) ^ -455610471;
						continue;
					case 7u:
						ProgressBar.smethod_0(num + 3, 1);
						num2 = ((int)num3 * -1090263287) ^ -1878754535;
						continue;
					case 5u:
						num2 = ((int)num3 * -31531691) ^ -1872439302;
						continue;
					case 4u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num2 = (int)(num3 * 345760495) ^ -1744843739;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1679823262;
							num5 = 1679823262;
						}
						else
						{
							num4 = 159755321;
							num5 = 159755321;
						}
						num2 = num4 ^ (int)(num3 * 905481315);
						continue;
					}
					case 2u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num2 = (int)((num3 * 1842350139) ^ 0x389ACC63);
						continue;
					case 1u:
						flag = num == _lastValue;
						num2 = (int)((num3 * 1176941480) ^ 0x2F12699F);
						continue;
					case 0u:
						num2 = (int)((num3 * 994876959) ^ 0x3959E011);
						continue;
					default:
						return;
					case 6u:
						break;
					case 11u:
						return;
					}
					break;
				}
			}
		}
	}

	public ProgressBar()
	{
		while (true)
		{
			int num = -2003516092;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6C3CF0Cu) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -1842539271) ^ -371572497;
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
