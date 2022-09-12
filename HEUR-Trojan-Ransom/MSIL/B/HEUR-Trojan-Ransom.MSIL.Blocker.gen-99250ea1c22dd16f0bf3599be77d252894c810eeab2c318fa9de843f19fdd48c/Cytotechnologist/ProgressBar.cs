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
			bool flag = default(bool);
			while (true)
			{
				int num = -170043731;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8B0CED5Au) % 12u)
					{
					case 11u:
						ProgressBar.smethod_0(num3 + 3, 1);
						num = ((int)num2 * -638406916) ^ -217018108;
						continue;
					case 10u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -2013659154;
							num5 = -2013659154;
						}
						else
						{
							num4 = -633057643;
							num5 = -633057643;
						}
						num = num4 ^ (int)(num2 * 195347353);
						continue;
					}
					case 9u:
						num = (int)(num2 * 2104546390) ^ -1168056795;
						continue;
					case 7u:
						num3 = (int)(value * 100f) + 1;
						flag = num3 == _lastValue;
						num = (int)((num2 * 1649635591) ^ 0x4C55C21);
						continue;
					case 6u:
						num = ((int)num2 * -250601153) ^ 0x156D376B;
						continue;
					case 4u:
						ProgressBar.smethod_0(num3 + 1, 1);
						num = (int)(num2 * 586249832) ^ -925040575;
						continue;
					case 3u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num = (int)(num2 * 790128286) ^ -1897334035;
						continue;
					case 2u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num = (int)(num2 * 2125238900) ^ -972806298;
						continue;
					case 1u:
						_lastValue = num3;
						num = -1105165454;
						continue;
					case 0u:
						num = ((int)num2 * -380678186) ^ -744961053;
						continue;
					default:
						return;
					case 8u:
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
