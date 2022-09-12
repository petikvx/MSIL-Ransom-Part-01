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
			bool flag = num == _lastValue;
			while (true)
			{
				int num2 = 764639720;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x18B760CAu) % 11u)
					{
					case 10u:
						num2 = (int)(num3 * 1126542025) ^ -1053104099;
						continue;
					case 9u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num2 = (int)(num3 * 1260068555) ^ -309175036;
						continue;
					case 8u:
						num2 = ((int)num3 * -107835911) ^ -185659569;
						continue;
					case 7u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num2 = (int)(num3 * 2075641766) ^ -1945115694;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -618022116;
							num5 = -618022116;
						}
						else
						{
							num4 = -608787559;
							num5 = -608787559;
						}
						num2 = num4 ^ ((int)num3 * -1346293674);
						continue;
					}
					case 3u:
						_lastValue = num;
						ProgressBar.smethod_0(num + 1, 1);
						num2 = 921248276;
						continue;
					case 2u:
						num2 = (int)(num3 * 249383484) ^ -1944834758;
						continue;
					case 1u:
						ProgressBar.smethod_0(num + 3, 1);
						num2 = ((int)num3 * -944545442) ^ 0x2C815925;
						continue;
					case 0u:
						num2 = ((int)num3 * -750517108) ^ -296507689;
						continue;
					default:
						return;
					case 6u:
						break;
					case 4u:
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
			int num = 1140510446;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7A27245Fu) % 3u)
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
				num = (int)(num2 * 1635411577) ^ -1694062438;
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
