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
				int num = 1910817437;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4B1D819Du) % 12u)
					{
					case 11u:
						_lastValue = num4;
						ProgressBar.smethod_0(num4 + 1, 1);
						num = 1744909357;
						continue;
					case 9u:
						num = (int)(num2 * 1334721523) ^ -290257027;
						continue;
					case 8u:
						num3 = value;
						num4 = (int)(num3 * 100f) + 1;
						num = (int)(num2 * 585172580) ^ -1279576155;
						continue;
					case 7u:
						ProgressBar.smethod_0(num4 + 3, 1);
						num = (int)((num2 * 1353450561) ^ 0x162AA494);
						continue;
					case 6u:
						ProgressBar.smethod_1("{0:P1} ", (object)num3);
						num = ((int)num2 * -1116417103) ^ 0x74DF1446;
						continue;
					case 5u:
						num = ((int)num2 * -1325631993) ^ 0x1B1AEF10;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (num4 != _lastValue)
						{
							num5 = -1334038906;
							num6 = -1334038906;
						}
						else
						{
							num5 = -1774504588;
							num6 = -1774504588;
						}
						num = num5 ^ (int)(num2 * 1374635634);
						continue;
					}
					case 3u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num3);
						num = ((int)num2 * -439671788) ^ -912817168;
						continue;
					case 2u:
						num = (int)((num2 * 1325824304) ^ 0xA59FE3C);
						continue;
					case 0u:
						num = (int)((num2 * 893340267) ^ 0x420BBC62);
						continue;
					default:
						return;
					case 10u:
						break;
					case 1u:
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
			int num = -678052846;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x98FD914Au) % 3u)
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
				num = (int)(num2 * 1817703354) ^ -1613738301;
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
