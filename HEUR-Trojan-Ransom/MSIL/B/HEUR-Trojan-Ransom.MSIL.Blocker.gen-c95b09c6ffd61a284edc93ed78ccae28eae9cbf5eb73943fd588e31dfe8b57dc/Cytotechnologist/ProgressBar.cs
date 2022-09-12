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
				int num = 1769535287;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6EE51DF7u) % 13u)
					{
					case 12u:
						ProgressBar.smethod_0(num3 + 3, 1);
						num = ((int)num2 * -120568669) ^ -1718573724;
						continue;
					case 11u:
						num = (int)(num2 * 774922652) ^ -903449667;
						continue;
					case 10u:
						num = (int)(num2 * 1348639964) ^ -94150144;
						continue;
					case 9u:
						num = (int)((num2 * 1014598404) ^ 0x7AB7371);
						continue;
					case 8u:
						_lastValue = num3;
						num = 446950440;
						continue;
					case 7u:
					{
						num3 = (int)(value * 100f) + 1;
						int num4;
						int num5;
						if (num3 == _lastValue)
						{
							num4 = 1860323530;
							num5 = 1860323530;
						}
						else
						{
							num4 = 123255488;
							num5 = 123255488;
						}
						num = num4 ^ (int)(num2 * 821373859);
						continue;
					}
					case 5u:
						num = ((int)num2 * -631103704) ^ -727123986;
						continue;
					case 3u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num = ((int)num2 * -1536357305) ^ 0x603127CA;
						continue;
					case 2u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num = ((int)num2 * -913401112) ^ 0x4375B103;
						continue;
					case 1u:
						ProgressBar.smethod_0(num3 + 1, 1);
						num = (int)(num2 * 908881247) ^ -1546452908;
						continue;
					case 0u:
						num = (int)(num2 * 130773251) ^ -1975220620;
						continue;
					default:
						return;
					case 4u:
						break;
					case 6u:
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
			int num = 171112328;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2A1F0A07u) % 3u)
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
				num = (int)(num2 * 1028069949) ^ -1847447375;
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
