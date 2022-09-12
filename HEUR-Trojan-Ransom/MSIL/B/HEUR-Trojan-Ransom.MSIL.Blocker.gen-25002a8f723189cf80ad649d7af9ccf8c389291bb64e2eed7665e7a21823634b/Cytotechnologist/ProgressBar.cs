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
				int num2 = -236768151;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x8C4631FCu) % 8u)
					{
					case 7u:
						num2 = (int)((num3 * 731851437) ^ 0x2A83F451);
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1288323101;
							num5 = 1288323101;
						}
						else
						{
							num4 = 1825686395;
							num5 = 1825686395;
						}
						num2 = num4 ^ ((int)num3 * -720551705);
						continue;
					}
					case 4u:
						_lastValue = num;
						ProgressBar.smethod_0(num + 1, 1);
						num2 = -1295084689;
						continue;
					case 3u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num2 = ((int)num3 * -2135098753) ^ -1908647042;
						continue;
					case 2u:
						ProgressBar.smethod_0(num + 3, 1);
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num2 = ((int)num3 * -987915450) ^ 0x3C5748A1;
						continue;
					case 1u:
						num2 = ((int)num3 * -610270948) ^ 0x13A4470E;
						continue;
					default:
						return;
					case 0u:
						break;
					case 6u:
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
			int num = -2027720673;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9ACC110Bu) % 3u)
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
				num = ((int)num2 * -1477998313) ^ -2098965556;
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
