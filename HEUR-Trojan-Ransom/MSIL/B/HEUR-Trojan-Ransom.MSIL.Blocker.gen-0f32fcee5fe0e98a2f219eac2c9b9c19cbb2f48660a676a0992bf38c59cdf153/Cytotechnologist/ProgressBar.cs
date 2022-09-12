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
				int num = -1918929108;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA79A8ECBu) % 15u)
					{
					case 14u:
						num = ((int)num2 * -1228345808) ^ 0x8D12147;
						continue;
					case 13u:
						ProgressBar.smethod_1("█ {0:P1} ", (object)value);
						num = (int)((num2 * 41305174) ^ 0xBE7195D);
						continue;
					case 12u:
						ProgressBar.smethod_0(num3 + 3, 1);
						num = ((int)num2 * -1386575825) ^ 0x48DC9B86;
						continue;
					case 11u:
						ProgressBar.smethod_1("{0:P1} ", (object)value);
						num = (int)(num2 * 1868480643) ^ -1522404684;
						continue;
					case 10u:
						ProgressBar.smethod_0(num3 + 1, 1);
						num = (int)(num2 * 1788254185) ^ -1433604857;
						continue;
					case 9u:
						num = (int)((num2 * 569583822) ^ 0x25E5C20A);
						continue;
					case 8u:
						num = ((int)num2 * -1662967790) ^ -1946402868;
						continue;
					case 7u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -2107416012;
							num5 = -2107416012;
						}
						else
						{
							num4 = -192725162;
							num5 = -192725162;
						}
						num = num4 ^ (int)(num2 * 1038166705);
						continue;
					}
					case 6u:
						_lastValue = num3;
						num = -460572331;
						continue;
					case 4u:
						num = ((int)num2 * -55246529) ^ -1213654222;
						continue;
					case 2u:
						num3 = (int)(value * 100f) + 1;
						num = (int)(num2 * 1475237152) ^ -1130249152;
						continue;
					case 1u:
						flag = num3 == _lastValue;
						num = (int)(num2 * 1495758900) ^ -574556287;
						continue;
					case 0u:
						num = (int)((num2 * 1515029455) ^ 0x8A9556B);
						continue;
					default:
						return;
					case 3u:
						break;
					case 5u:
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
			int num = 1984198581;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x73FB5F43u) % 3u)
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
				num = (int)(num2 * 589213595) ^ -1828414809;
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
