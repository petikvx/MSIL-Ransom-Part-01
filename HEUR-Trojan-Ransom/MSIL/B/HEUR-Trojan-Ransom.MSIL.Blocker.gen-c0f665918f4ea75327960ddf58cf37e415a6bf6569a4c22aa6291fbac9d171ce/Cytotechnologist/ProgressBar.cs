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
			while (true)
			{
				int num = 406684002;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7EDD0FABu) % 13u)
					{
					case 12u:
						num4 = (int)(num3 * 100f) + 1;
						num = ((int)num2 * -1679718258) ^ -2030102162;
						continue;
					case 11u:
						ProgressBar.smethod_0(num4 + 1, 1);
						num = (int)(num2 * 16355747) ^ -743499590;
						continue;
					case 10u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num3);
						num = (int)((num2 * 86219710) ^ 0x68F3F560);
						continue;
					case 9u:
						ProgressBar.smethod_0(num4 + 3, 1);
						num = (int)(num2 * 445413212) ^ -1708087498;
						continue;
					case 8u:
						ProgressBar.smethod_1("{0:P1} ", (object)num3);
						num = ((int)num2 * -72161150) ^ -1845081495;
						continue;
					case 7u:
					{
						int num5;
						int num6;
						if (num4 != _lastValue)
						{
							num5 = -1343844273;
							num6 = -1343844273;
						}
						else
						{
							num5 = -774282260;
							num6 = -774282260;
						}
						num = num5 ^ (int)(num2 * 2080556194);
						continue;
					}
					case 5u:
						_lastValue = num4;
						num = 1858340373;
						continue;
					case 4u:
						num3 = value;
						num = ((int)num2 * -1342364271) ^ 0x7B85206F;
						continue;
					case 3u:
						num = (int)(num2 * 291213704) ^ -1588615275;
						continue;
					case 2u:
						num = (int)((num2 * 1622237265) ^ 0x626B63A4);
						continue;
					case 1u:
						num = (int)((num2 * 263609935) ^ 0x3E667123);
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
			int num = 1706181764;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2A15E6CDu) % 3u)
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
				num = ((int)num2 * -1677836847) ^ 0x7CAB691F;
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
