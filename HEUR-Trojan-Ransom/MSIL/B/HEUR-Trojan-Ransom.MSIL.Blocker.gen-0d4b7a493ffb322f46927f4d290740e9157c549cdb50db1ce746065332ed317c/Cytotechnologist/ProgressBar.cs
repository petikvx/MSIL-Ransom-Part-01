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
				int num = 1098709341;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3EA00BECu) % 10u)
					{
					case 7u:
						num = (int)((num2 * 900866945) ^ 0x4AD74607);
						continue;
					case 6u:
						ProgressBar.smethod_0(num4 + 3, 1);
						num = ((int)num2 * -750041988) ^ -755694213;
						continue;
					case 5u:
						_lastValue = num4;
						ProgressBar.smethod_0(num4 + 1, 1);
						ProgressBar.smethod_1("█ {0:P1} ", (object)num3);
						num = 151961555;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (num4 == _lastValue)
						{
							num5 = 1349573380;
							num6 = 1349573380;
						}
						else
						{
							num5 = 564878683;
							num6 = 564878683;
						}
						num = num5 ^ (int)(num2 * 1092770943);
						continue;
					}
					case 3u:
						num = (int)((num2 * 1081680221) ^ 0x12484DC9);
						continue;
					case 2u:
						num = ((int)num2 * -1022270488) ^ -1485858456;
						continue;
					case 1u:
						num3 = value;
						num4 = (int)(num3 * 100f) + 1;
						num = (int)((num2 * 1610547274) ^ 0x787051C);
						continue;
					case 0u:
						ProgressBar.smethod_1("{0:P1} ", (object)num3);
						num = ((int)num2 * -612358698) ^ 0x5DCB322A;
						continue;
					default:
						return;
					case 9u:
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
