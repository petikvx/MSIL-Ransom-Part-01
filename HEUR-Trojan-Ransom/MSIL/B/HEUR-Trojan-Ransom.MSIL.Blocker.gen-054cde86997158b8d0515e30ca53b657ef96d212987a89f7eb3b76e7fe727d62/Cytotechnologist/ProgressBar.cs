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
			bool flag = default(bool);
			while (true)
			{
				int num = -340338273;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC224967Eu) % 11u)
					{
					case 9u:
						ProgressBar.smethod_0(num4 + 3, 1);
						ProgressBar.smethod_1("{0:P1} ", (object)num3);
						num = (int)((num2 * 1543310110) ^ 0x4E0AEC3);
						continue;
					case 8u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num3);
						num = ((int)num2 * -1329244089) ^ -132484496;
						continue;
					case 7u:
						num = ((int)num2 * -1754663554) ^ 0x345DE306;
						continue;
					case 6u:
						_lastValue = num4;
						ProgressBar.smethod_0(num4 + 1, 1);
						num = -872701572;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (!flag)
						{
							num5 = 849185932;
							num6 = 849185932;
						}
						else
						{
							num5 = 294487746;
							num6 = 294487746;
						}
						num = num5 ^ (int)(num2 * 616175431);
						continue;
					}
					case 4u:
						num = (int)((num2 * 117088052) ^ 0x3BCD7165);
						continue;
					case 3u:
						num = ((int)num2 * -1916873094) ^ 0xA9B98F8;
						continue;
					case 1u:
						num3 = value;
						num = (int)((num2 * 1782357157) ^ 0x4B1E554A);
						continue;
					case 0u:
						num4 = (int)(num3 * 100f) + 1;
						flag = num4 == _lastValue;
						num = ((int)num2 * -1423820047) ^ 0x28ACCF13;
						continue;
					default:
						return;
					case 10u:
						break;
					case 2u:
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
			int num = 1401194875;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x249FED11u) % 3u)
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
				num = (int)(num2 * 1531389492) ^ -647772038;
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
