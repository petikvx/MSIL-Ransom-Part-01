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
			bool flag = default(bool);
			int num3 = default(int);
			while (true)
			{
				int num = -524121817;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFCC2736Cu) % 14u)
					{
					case 13u:
						num = ((int)num2 * -315424639) ^ 0x234198D1;
						continue;
					case 12u:
						num = (int)(num2 * 1461095048) ^ -289201393;
						continue;
					case 11u:
						num4 = value;
						num = (int)((num2 * 1957950034) ^ 0x4C8A2F5F);
						continue;
					case 10u:
						ProgressBar.smethod_1("{0:P1} ", (object)num4);
						num = ((int)num2 * -856858253) ^ -2072029148;
						continue;
					case 8u:
						num = ((int)num2 * -149778787) ^ -385137484;
						continue;
					case 7u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = 1952348011;
							num6 = 1952348011;
						}
						else
						{
							num5 = 1606983268;
							num6 = 1606983268;
						}
						num = num5 ^ (int)(num2 * 1640894258);
						continue;
					}
					case 6u:
						num = (int)((num2 * 2133749284) ^ 0x98CCC99);
						continue;
					case 5u:
						num3 = (int)(num4 * 100f) + 1;
						num = (int)(num2 * 372975655) ^ -861603356;
						continue;
					case 3u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num4);
						num = (int)((num2 * 484392415) ^ 0x57ABF384);
						continue;
					case 2u:
						_lastValue = num3;
						ProgressBar.smethod_0(num3 + 1, 1);
						num = -1710817382;
						continue;
					case 1u:
						flag = num3 == _lastValue;
						num = (int)((num2 * 1204272887) ^ 0x41C1710E);
						continue;
					case 0u:
						ProgressBar.smethod_0(num3 + 3, 1);
						num = (int)(num2 * 1729366469) ^ -1568099340;
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
