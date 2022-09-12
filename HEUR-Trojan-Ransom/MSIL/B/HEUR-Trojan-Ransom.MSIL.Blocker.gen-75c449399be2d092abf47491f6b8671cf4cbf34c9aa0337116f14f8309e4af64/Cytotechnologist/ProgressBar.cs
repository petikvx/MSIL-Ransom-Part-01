using System;

namespace Cytotechnologist;

public class ProgressBar
{
	private int _lastValue;

	public float Value
	{
		set
		{
			float num3 = default(float);
			int num4 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = 198191742;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6BA9610Du) % 11u)
					{
					case 10u:
						num = (int)(num2 * 1946088418) ^ -857501790;
						continue;
					case 9u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num3);
						num = ((int)num2 * -1652306586) ^ -1094497862;
						continue;
					case 8u:
						ProgressBar.smethod_1("{0:P1} ", (object)num3);
						num = (int)(num2 * 978300088) ^ -1727238692;
						continue;
					case 6u:
						num3 = value;
						num = (int)(num2 * 1119712793) ^ -817397782;
						continue;
					case 5u:
						_lastValue = num4;
						num = 970407799;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (!flag)
						{
							num5 = -2100803842;
							num6 = -2100803842;
						}
						else
						{
							num5 = -1726553487;
							num6 = -1726553487;
						}
						num = num5 ^ (int)(num2 * 447582001);
						continue;
					}
					case 2u:
						ProgressBar.smethod_0(num4 + 3, 1);
						num = ((int)num2 * -1527677970) ^ -1968827811;
						continue;
					case 1u:
						ProgressBar.smethod_0(num4 + 1, 1);
						num = (int)(num2 * 1412527649) ^ -639777570;
						continue;
					case 0u:
						num4 = (int)(num3 * 100f) + 1;
						flag = num4 == _lastValue;
						num = ((int)num2 * -49892123) ^ 0x5CAC03CB;
						continue;
					default:
						return;
					case 7u:
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
