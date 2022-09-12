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
			bool flag = default(bool);
			int num4 = default(int);
			while (true)
			{
				int num = -249560217;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEB09277Cu) % 14u)
					{
					case 13u:
						num3 = value;
						num = (int)((num2 * 1363916244) ^ 0x74D4DC45);
						continue;
					case 12u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = 1742070188;
							num6 = 1742070188;
						}
						else
						{
							num5 = 1269544505;
							num6 = 1269544505;
						}
						num = num5 ^ (int)(num2 * 793646935);
						continue;
					}
					case 11u:
						num = ((int)num2 * -1538536295) ^ -1394097644;
						continue;
					case 10u:
						num = ((int)num2 * -1070660507) ^ -460093205;
						continue;
					case 9u:
						num4 = (int)(num3 * 100f) + 1;
						num = (int)((num2 * 124818153) ^ 0x697E2EF5);
						continue;
					case 8u:
						ProgressBar.smethod_0(num4 + 3, 1);
						num = ((int)num2 * -1188463660) ^ 0x6EFB472;
						continue;
					case 6u:
						num = (int)(num2 * 70658152) ^ -162741486;
						continue;
					case 5u:
						ProgressBar.smethod_1("{0:P1} ", (object)num3);
						num = (int)((num2 * 719964969) ^ 0x318E75A8);
						continue;
					case 4u:
						num = (int)((num2 * 192656277) ^ 0x254FF757);
						continue;
					case 3u:
						_lastValue = num4;
						ProgressBar.smethod_0(num4 + 1, 1);
						num = -1318908120;
						continue;
					case 2u:
						flag = num4 == _lastValue;
						num = (int)(num2 * 1601440714) ^ -1053176820;
						continue;
					case 0u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num3);
						num = (int)(num2 * 663881437) ^ -2104754706;
						continue;
					default:
						return;
					case 7u:
						break;
					case 1u:
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
