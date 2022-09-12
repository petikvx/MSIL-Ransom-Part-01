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
			int num4 = default(int);
			float num3 = default(float);
			while (true)
			{
				int num = 1979690533;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3F6CB738u) % 15u)
					{
					case 14u:
						num = (int)((num2 * 659198179) ^ 0x56FD5DB3);
						continue;
					case 13u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = 874264919;
							num6 = 874264919;
						}
						else
						{
							num5 = 447728275;
							num6 = 447728275;
						}
						num = num5 ^ ((int)num2 * -1261716469);
						continue;
					}
					case 12u:
						num = (int)((num2 * 1592491287) ^ 0x39A8329C);
						continue;
					case 11u:
						_lastValue = num4;
						num = 485807262;
						continue;
					case 10u:
						num = (int)(num2 * 873137397) ^ -1722576857;
						continue;
					case 7u:
						flag = num4 == _lastValue;
						num = ((int)num2 * -595946386) ^ 0x5AC11B8A;
						continue;
					case 6u:
						num = ((int)num2 * -648217528) ^ -1819691291;
						continue;
					case 5u:
						num3 = value;
						num4 = (int)(num3 * 100f) + 1;
						num = (int)((num2 * 1061099284) ^ 0x63DD9F5C);
						continue;
					case 4u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num3);
						num = ((int)num2 * -413401083) ^ -1436669271;
						continue;
					case 3u:
						num = ((int)num2 * -1770249663) ^ 0x52ECC313;
						continue;
					case 2u:
						ProgressBar.smethod_0(num4 + 1, 1);
						num = ((int)num2 * -821639245) ^ -1104580603;
						continue;
					case 1u:
						ProgressBar.smethod_0(num4 + 3, 1);
						num = ((int)num2 * -543359061) ^ 0x7CAA3383;
						continue;
					case 0u:
						ProgressBar.smethod_1("{0:P1} ", (object)num3);
						num = (int)((num2 * 58025181) ^ 0xA5131D3);
						continue;
					default:
						return;
					case 8u:
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
			int num = 1415421960;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1517B238u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				num = (int)(num2 * 575939126) ^ -175245831;
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
