using System;

namespace Cytotechnologist;

public class ProgressBar
{
	private int _lastValue;

	public float Value
	{
		set
		{
			int num4 = default(int);
			float num3 = default(float);
			while (true)
			{
				int num = -1773261174;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9C7F3311u) % 11u)
					{
					case 10u:
						ProgressBar.smethod_0(num4 + 3, 1);
						num = ((int)num2 * -2098056307) ^ -213857505;
						continue;
					case 9u:
					{
						int num5;
						int num6;
						if (num4 == _lastValue)
						{
							num5 = -1106059291;
							num6 = -1106059291;
						}
						else
						{
							num5 = -1080563297;
							num6 = -1080563297;
						}
						num = num5 ^ ((int)num2 * -855026555);
						continue;
					}
					case 8u:
						_lastValue = num4;
						ProgressBar.smethod_0(num4 + 1, 1);
						ProgressBar.smethod_1("█ {0:P1} ", (object)num3);
						num = -580984894;
						continue;
					case 7u:
						num3 = value;
						num = (int)((num2 * 252062754) ^ 0x54783B3D);
						continue;
					case 6u:
						num = ((int)num2 * -908786432) ^ -372989983;
						continue;
					case 5u:
						num4 = (int)(num3 * 100f) + 1;
						num = (int)(num2 * 1536711676) ^ -329303018;
						continue;
					case 2u:
						num = (int)(num2 * 837944786) ^ -1446213871;
						continue;
					case 1u:
						num = (int)((num2 * 1373351814) ^ 0x504BDD61);
						continue;
					case 0u:
						ProgressBar.smethod_1("{0:P1} ", (object)num3);
						num = ((int)num2 * -1938722282) ^ -538731108;
						continue;
					default:
						return;
					case 4u:
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
