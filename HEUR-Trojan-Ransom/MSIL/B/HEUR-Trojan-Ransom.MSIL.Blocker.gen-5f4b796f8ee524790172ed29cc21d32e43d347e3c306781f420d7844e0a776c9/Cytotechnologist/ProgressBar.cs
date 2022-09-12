using System;

namespace Cytotechnologist;

public class ProgressBar
{
	private int _lastValue;

	public float Value
	{
		set
		{
			int num5 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -274024548;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB64EC67Fu) % 10u)
					{
					case 9u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num = ((int)num2 * -1072362428) ^ 0x19D85BC6;
						continue;
					case 7u:
						num5 = (int)(value * 100f) + 1;
						flag = num5 == _lastValue;
						num = (int)(num2 * 873800888) ^ -219743299;
						continue;
					case 6u:
						ProgressBar.smethod_0(num5 + 3, 1);
						num = (int)(num2 * 538895309) ^ -1500167074;
						continue;
					case 5u:
						num = ((int)num2 * -1756489874) ^ 0x69D2A7EA;
						continue;
					case 4u:
						_lastValue = num5;
						ProgressBar.smethod_0(num5 + 1, 1);
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num = -1328342153;
						continue;
					case 3u:
						num = (int)((num2 * 731085511) ^ 0x6B76A2DB);
						continue;
					case 1u:
						num = (int)(num2 * 317254185) ^ -808740628;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1551558021;
							num4 = -1551558021;
						}
						else
						{
							num3 = -304266453;
							num4 = -304266453;
						}
						num = num3 ^ ((int)num2 * -1335131829);
						continue;
					}
					default:
						return;
					case 8u:
						break;
					case 2u:
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
