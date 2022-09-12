using System;

namespace Cytotechnologist;

public class ProgressBar
{
	private int _lastValue;

	public float Value
	{
		set
		{
			bool flag = default(bool);
			int num3 = default(int);
			float num4 = default(float);
			while (true)
			{
				int num = -863198004;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x85A7FD08u) % 11u)
					{
					case 10u:
					{
						int num5;
						int num6;
						if (!flag)
						{
							num5 = 1209328909;
							num6 = 1209328909;
						}
						else
						{
							num5 = 1200718886;
							num6 = 1200718886;
						}
						num = num5 ^ (int)(num2 * 1642797865);
						continue;
					}
					case 9u:
						ProgressBar.smethod_0(num3 + 1, 1);
						num = (int)((num2 * 61215000) ^ 0x74D2A429);
						continue;
					case 8u:
						num = (int)((num2 * 762125823) ^ 0x2AC10E46);
						continue;
					case 7u:
						ProgressBar.smethod_1("{0:P1} ", (object)num4);
						num = ((int)num2 * -117006746) ^ 0x7EFBAC4;
						continue;
					case 6u:
						ProgressBar.smethod_0(num3 + 3, 1);
						num = ((int)num2 * -1944899451) ^ -1599779267;
						continue;
					case 5u:
						num4 = value;
						num3 = (int)(num4 * 100f) + 1;
						flag = num3 == _lastValue;
						num = ((int)num2 * -604156896) ^ -1177328568;
						continue;
					case 4u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num4);
						num = ((int)num2 * -1396912622) ^ 0x504EB260;
						continue;
					case 3u:
						_lastValue = num3;
						num = -1826434946;
						continue;
					case 1u:
						num = ((int)num2 * -570404968) ^ -1666609758;
						continue;
					default:
						return;
					case 2u:
						break;
					case 0u:
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
