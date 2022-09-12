using System;

namespace Cytotechnologist;

public class ProgressBar
{
	private int _lastValue;

	public float Value
	{
		set
		{
			int num3 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = 274352955;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6414EDCBu) % 11u)
					{
					case 10u:
						_lastValue = num3;
						num = 1289352029;
						continue;
					case 9u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num = ((int)num2 * -1940647729) ^ -460516502;
						continue;
					case 8u:
						ProgressBar.smethod_0(num3 + 1, 1);
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num = ((int)num2 * -382604915) ^ -1584955344;
						continue;
					case 7u:
						num3 = (int)(value * 100f) + 1;
						flag = num3 == _lastValue;
						num = ((int)num2 * -1047467179) ^ -454058687;
						continue;
					case 5u:
						num = ((int)num2 * -371601339) ^ -164320835;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 960479364;
							num5 = 960479364;
						}
						else
						{
							num4 = 1030741322;
							num5 = 1030741322;
						}
						num = num4 ^ ((int)num2 * -1082374703);
						continue;
					}
					case 2u:
						num = ((int)num2 * -1617000238) ^ -2055626765;
						continue;
					case 1u:
						num = ((int)num2 * -982744621) ^ -1342080203;
						continue;
					case 0u:
						ProgressBar.smethod_0(num3 + 3, 1);
						num = ((int)num2 * -1394377228) ^ -95539276;
						continue;
					default:
						return;
					case 4u:
						break;
					case 6u:
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
