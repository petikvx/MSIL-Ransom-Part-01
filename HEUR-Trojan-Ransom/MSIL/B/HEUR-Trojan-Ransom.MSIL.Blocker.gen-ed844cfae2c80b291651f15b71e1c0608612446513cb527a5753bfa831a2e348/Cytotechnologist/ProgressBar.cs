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
			if (num == _lastValue)
			{
				goto IL_0054;
			}
			goto IL_00c7;
			IL_00c7:
			_lastValue = num;
			ProgressBar.smethod_0(num + 1, 1);
			int num2 = 794166367;
			goto IL_0096;
			IL_0096:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x60F6FFE3u) % 8u)
				{
				case 7u:
					num2 = ((int)num3 * -1518480143) ^ -385994595;
					continue;
				case 6u:
					ProgressBar.smethod_0(num + 3, 1);
					ProgressBar.smethod_1("{0:P1} ", (object)value);
					num2 = (int)(num3 * 608140424) ^ -2147175765;
					continue;
				case 5u:
					break;
				case 4u:
					num2 = (int)((num3 * 847589867) ^ 0x52DEF8EC);
					continue;
				case 3u:
					ProgressBar.smethod_1("█ {0:P1} ", (object)value);
					num2 = ((int)num3 * -1391079892) ^ 0x4FB88936;
					continue;
				case 0u:
					num2 = ((int)num3 * -1792273360) ^ 0x1DA7149C;
					continue;
				default:
					return;
				case 2u:
					goto IL_00c7;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0054;
			IL_0054:
			num2 = 1420037085;
			goto IL_0096;
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
