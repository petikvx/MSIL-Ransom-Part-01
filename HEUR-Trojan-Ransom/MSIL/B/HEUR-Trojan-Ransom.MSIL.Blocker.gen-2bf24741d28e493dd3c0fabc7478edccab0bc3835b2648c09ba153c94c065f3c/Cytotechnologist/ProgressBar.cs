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
			bool flag = default(bool);
			float num3 = default(float);
			while (true)
			{
				int num = 1823648388;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x14D92F5Eu) % 14u)
					{
					case 13u:
						num = ((int)num2 * -2084165978) ^ 0x14EB77E0;
						continue;
					case 12u:
						ProgressBar.smethod_0(num4 + 1, 1);
						num = (int)(num2 * 220474650) ^ -766056516;
						continue;
					case 11u:
						num = ((int)num2 * -161239950) ^ 0x27CC1AA7;
						continue;
					case 10u:
						_lastValue = num4;
						num = 476766928;
						continue;
					case 9u:
					{
						int num5;
						int num6;
						if (!flag)
						{
							num5 = -309473974;
							num6 = -309473974;
						}
						else
						{
							num5 = -1842488813;
							num6 = -1842488813;
						}
						num = num5 ^ (int)(num2 * 1461569440);
						continue;
					}
					case 8u:
						ProgressBar.smethod_1("{0:P1} ", (object)num3);
						num = (int)((num2 * 1683936394) ^ 0x6B197A57);
						continue;
					case 6u:
						num3 = value;
						num = (int)(num2 * 1350571810) ^ -789853538;
						continue;
					case 5u:
						num = (int)((num2 * 1214989044) ^ 0x45614910);
						continue;
					case 4u:
						num4 = (int)(num3 * 100f) + 1;
						flag = num4 == _lastValue;
						num = ((int)num2 * -1519803300) ^ -1083455523;
						continue;
					case 2u:
						num = ((int)num2 * -309161147) ^ -2020253729;
						continue;
					case 1u:
						ProgressBar.smethod_0(num4 + 3, 1);
						num = ((int)num2 * -613579383) ^ -1242557928;
						continue;
					case 0u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)num3);
						num = ((int)num2 * -1498793313) ^ 0xBA4733D;
						continue;
					default:
						return;
					case 7u:
						break;
					case 3u:
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
