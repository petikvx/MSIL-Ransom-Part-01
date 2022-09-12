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
				int num = -1484917952;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD8C30BF3u) % 11u)
					{
					case 10u:
						num = (int)(num2 * 1706692625) ^ -612477961;
						continue;
					case 9u:
					{
						int num5;
						int num6;
						if (num4 == _lastValue)
						{
							num5 = 668285490;
							num6 = 668285490;
						}
						else
						{
							num5 = 233109122;
							num6 = 233109122;
						}
						num = num5 ^ (int)(num2 * 1595181517);
						continue;
					}
					case 7u:
						ProgressBar.smethod_0(num4 + 3, 1);
						ProgressBar.smethod_1("{0:P1} ", (object)num3);
						num = (int)(num2 * 1418932036) ^ -189272119;
						continue;
					case 6u:
						ProgressBar.smethod_0(num4 + 1, 1);
						ProgressBar.smethod_1("█ {0:P1} ", (object)num3);
						num = ((int)num2 * -1152219473) ^ -122397170;
						continue;
					case 4u:
						num = ((int)num2 * -687023763) ^ -215889905;
						continue;
					case 3u:
						num = ((int)num2 * -830543110) ^ 0x609504A5;
						continue;
					case 2u:
						_lastValue = num4;
						num = -50585725;
						continue;
					case 1u:
						num3 = value;
						num4 = (int)(num3 * 100f) + 1;
						num = ((int)num2 * -1474016326) ^ -1481410904;
						continue;
					case 0u:
						num = ((int)num2 * -527144705) ^ 0x3CCB68F6;
						continue;
					default:
						return;
					case 5u:
						break;
					case 8u:
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
