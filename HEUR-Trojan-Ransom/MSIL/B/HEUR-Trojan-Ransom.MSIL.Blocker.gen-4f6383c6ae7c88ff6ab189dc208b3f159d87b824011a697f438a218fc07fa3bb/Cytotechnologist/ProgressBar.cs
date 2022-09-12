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
				int num = -411278732;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8A98307Bu) % 13u)
					{
					case 12u:
						num3 = (int)(value * 100f) + 1;
						flag = num3 == _lastValue;
						num = ((int)num2 * -1224393121) ^ -1459365341;
						continue;
					case 11u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num = (int)((num2 * 389841305) ^ 0x6BBA83E1);
						continue;
					case 10u:
						num = ((int)num2 * -787147759) ^ -516716641;
						continue;
					case 8u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num = ((int)num2 * -1567506665) ^ 0x374D2D8B;
						continue;
					case 6u:
						num = (int)(num2 * 2107139712) ^ -1462674086;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1836966490;
							num5 = 1836966490;
						}
						else
						{
							num4 = 1552654445;
							num5 = 1552654445;
						}
						num = num4 ^ ((int)num2 * -586184385);
						continue;
					}
					case 4u:
						_lastValue = num3;
						num = -1645413123;
						continue;
					case 3u:
						ProgressBar.smethod_0(num3 + 3, 1);
						num = (int)((num2 * 1371517008) ^ 0x1B0CD9C1);
						continue;
					case 2u:
						num = (int)((num2 * 1901549815) ^ 0x76B99C3E);
						continue;
					case 1u:
						ProgressBar.smethod_0(num3 + 1, 1);
						num = ((int)num2 * -1700860022) ^ 0x5DE4B4B8;
						continue;
					case 0u:
						num = (int)(num2 * 1383542015) ^ -1452627367;
						continue;
					default:
						return;
					case 7u:
						break;
					case 9u:
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
			int num = 2083532952;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x524799B2u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -1742514922) ^ -678379450;
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
