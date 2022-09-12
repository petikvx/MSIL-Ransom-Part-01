using System;

namespace Cytotechnologist;

public class ProgressBar
{
	private int _lastValue;

	public float Value
	{
		set
		{
			float num4 = default(float);
			int num3 = default(int);
			while (true)
			{
				int num = 222473055;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7E751D83u) % 10u)
					{
					case 8u:
						ProgressBar.smethod_1("{0:P1} ", (object)num4);
						num = (int)(num2 * 1725251352) ^ -1379535818;
						continue;
					case 7u:
					{
						int num5;
						int num6;
						if (num3 != _lastValue)
						{
							num5 = -1182165311;
							num6 = -1182165311;
						}
						else
						{
							num5 = -1609436152;
							num6 = -1609436152;
						}
						num = num5 ^ ((int)num2 * -1880976554);
						continue;
					}
					case 6u:
						ProgressBar.smethod_0(num3 + 3, 1);
						num = ((int)num2 * -440727703) ^ 0x41E54F1F;
						continue;
					case 4u:
						num3 = (int)(num4 * 100f) + 1;
						num = (int)(num2 * 1724604653) ^ -1412402768;
						continue;
					case 3u:
						num = ((int)num2 * -1228946903) ^ -895253882;
						continue;
					case 2u:
						num4 = value;
						num = ((int)num2 * -384566321) ^ -371597159;
						continue;
					case 1u:
						num = (int)((num2 * 211816311) ^ 0x7586A17B);
						continue;
					case 0u:
						_lastValue = num3;
						ProgressBar.smethod_0(num3 + 1, 1);
						ProgressBar.smethod_1("█ {0:P1} ", (object)num4);
						num = 661794808;
						continue;
					default:
						return;
					case 5u:
						break;
					case 9u:
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
			int num = -1922078853;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x91BB8E9Au) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				num = (int)((num2 * 15343078) ^ 0x1531F8A);
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
