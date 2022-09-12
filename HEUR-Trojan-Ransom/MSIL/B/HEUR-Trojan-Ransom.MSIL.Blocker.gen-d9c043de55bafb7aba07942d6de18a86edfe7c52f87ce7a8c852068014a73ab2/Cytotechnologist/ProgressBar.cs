using System;

namespace Cytotechnologist;

public class ProgressBar
{
	private int _lastValue;

	public float Value
	{
		set
		{
			int num6 = default(int);
			float num5 = default(float);
			bool flag = default(bool);
			while (true)
			{
				int num = 1017403497;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x22DC435Fu) % 12u)
					{
					case 10u:
						ProgressBar.smethod_0(num6 + 3, 1);
						num = ((int)num2 * -64661109) ^ -68038104;
						continue;
					case 8u:
						ProgressBar.smethod_1("{0:P1} ", (object)num5);
						num = (int)((num2 * 1211939066) ^ 0x18A6E86C);
						continue;
					case 7u:
						num = (int)((num2 * 1685384089) ^ 0x4EE85FCD);
						continue;
					case 6u:
						num5 = value;
						num = ((int)num2 * -1813787736) ^ 0x5A05C916;
						continue;
					case 5u:
						num6 = (int)(num5 * 100f) + 1;
						num = (int)(num2 * 905739125) ^ -274234222;
						continue;
					case 4u:
						flag = num6 == _lastValue;
						num = (int)(num2 * 1907604669) ^ -11439733;
						continue;
					case 3u:
						_lastValue = num6;
						ProgressBar.smethod_0(num6 + 1, 1);
						num = 234423701;
						continue;
					case 2u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num5);
						num = ((int)num2 * -855501602) ^ 0x5090819A;
						continue;
					case 1u:
						num = ((int)num2 * -1950110457) ^ 0x4871F050;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1316150260;
							num4 = 1316150260;
						}
						else
						{
							num3 = 1869596473;
							num4 = 1869596473;
						}
						num = num3 ^ ((int)num2 * -645446825);
						continue;
					}
					default:
						return;
					case 11u:
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
