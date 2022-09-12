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
			int num4 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -174672523;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAD4B6DFFu) % 13u)
					{
					case 12u:
						num3 = value;
						num4 = (int)(num3 * 100f) + 1;
						num = ((int)num2 * -2000235828) ^ 0x4AB73D44;
						continue;
					case 10u:
						num = (int)(num2 * 761270658) ^ -414354426;
						continue;
					case 9u:
						_lastValue = num4;
						ProgressBar.smethod_0(num4 + 1, 1);
						num = -1734254805;
						continue;
					case 8u:
					{
						int num5;
						int num6;
						if (!flag)
						{
							num5 = 1589203365;
							num6 = 1589203365;
						}
						else
						{
							num5 = 635020830;
							num6 = 635020830;
						}
						num = num5 ^ (int)(num2 * 1342515436);
						continue;
					}
					case 7u:
						num = ((int)num2 * -1315221342) ^ 0x453A0D90;
						continue;
					case 6u:
						num = (int)(num2 * 2009872201) ^ -1353664345;
						continue;
					case 5u:
						ProgressBar.smethod_0(num4 + 3, 1);
						num = (int)((num2 * 1979854620) ^ 0x267B38A8);
						continue;
					case 4u:
						num = ((int)num2 * -1056689446) ^ -125111379;
						continue;
					case 3u:
						flag = num4 == _lastValue;
						num = ((int)num2 * -1818449790) ^ -2053732686;
						continue;
					case 2u:
						ProgressBar.smethod_1("{0:P1} ", (object)num3);
						num = ((int)num2 * -683982516) ^ -305858934;
						continue;
					case 0u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num3);
						num = ((int)num2 * -306584418) ^ 0x676B056D;
						continue;
					default:
						return;
					case 11u:
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
