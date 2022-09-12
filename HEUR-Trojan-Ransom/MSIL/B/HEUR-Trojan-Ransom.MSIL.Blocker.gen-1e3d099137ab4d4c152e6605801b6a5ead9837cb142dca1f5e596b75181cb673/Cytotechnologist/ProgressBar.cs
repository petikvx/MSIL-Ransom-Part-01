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
				goto IL_001b;
			}
			goto IL_00c5;
			IL_00c5:
			_lastValue = num;
			ProgressBar.smethod_0(num + 1, 1);
			int num2 = -151842627;
			goto IL_0094;
			IL_0094:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x8369DFE5u) % 8u)
				{
				case 6u:
					break;
				case 5u:
					ProgressBar.smethod_1("█ {0:P1} ", (object)value);
					num2 = (int)(num3 * 635555545) ^ -57595327;
					continue;
				case 4u:
					num2 = ((int)num3 * -21213115) ^ 0xB15F48A;
					continue;
				case 3u:
					ProgressBar.smethod_0(num + 3, 1);
					ProgressBar.smethod_1("{0:P1} ", (object)value);
					num2 = ((int)num3 * -1712676404) ^ -895713733;
					continue;
				case 2u:
					num2 = ((int)num3 * -1000882476) ^ 0xC8CE48C;
					continue;
				case 0u:
					num2 = ((int)num3 * -248387072) ^ -119135448;
					continue;
				default:
					return;
				case 7u:
					goto IL_00c5;
				case 1u:
					return;
				}
				break;
			}
			goto IL_001b;
			IL_001b:
			num2 = -81734967;
			goto IL_0094;
		}
	}

	public ProgressBar()
	{
		while (true)
		{
			int num = -409932455;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE3BEBF45u) % 3u)
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
				num = (int)((num2 * 1605356577) ^ 0x78DC9567);
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
