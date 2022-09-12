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
				int num = -806626928;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x862F95E6u) % 13u)
					{
					case 12u:
						num = (int)((num2 * 1540761943) ^ 0x2489FB58);
						continue;
					case 11u:
						num3 = (int)(num4 * 100f) + 1;
						num = ((int)num2 * -1298512857) ^ -2111902229;
						continue;
					case 9u:
					{
						int num5;
						int num6;
						if (!flag)
						{
							num5 = -606501875;
							num6 = -606501875;
						}
						else
						{
							num5 = -1194597093;
							num6 = -1194597093;
						}
						num = num5 ^ ((int)num2 * -373294941);
						continue;
					}
					case 7u:
						num4 = value;
						num = (int)(num2 * 18951846) ^ -1112285951;
						continue;
					case 6u:
						num = (int)((num2 * 279630518) ^ 0x1A76A91B);
						continue;
					case 5u:
						ProgressBar.smethod_0(num3 + 3, 1);
						num = (int)(num2 * 1953176214) ^ -764009778;
						continue;
					case 4u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num4);
						num = (int)((num2 * 594682857) ^ 0x768D9567);
						continue;
					case 3u:
						ProgressBar.smethod_1("{0:P1} ", (object)num4);
						num = ((int)num2 * -1992960134) ^ 0x1EFAB092;
						continue;
					case 2u:
						_lastValue = num3;
						ProgressBar.smethod_0(num3 + 1, 1);
						num = -1235271517;
						continue;
					case 1u:
						flag = num3 == _lastValue;
						num = (int)((num2 * 2112024830) ^ 0x6529464);
						continue;
					case 0u:
						num = ((int)num2 * -1693033284) ^ -840427584;
						continue;
					default:
						return;
					case 8u:
						break;
					case 10u:
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
