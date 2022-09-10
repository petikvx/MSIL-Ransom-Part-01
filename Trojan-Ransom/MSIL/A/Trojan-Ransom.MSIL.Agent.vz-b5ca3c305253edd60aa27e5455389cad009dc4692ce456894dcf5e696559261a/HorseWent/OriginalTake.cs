using System;
using System.Collections.Generic;
using Recordperson;

namespace HorseWent;

internal static class OriginalTake
{
	private static byte[] Mindsong;

	static OriginalTake()
	{
		while (true)
		{
			int num = 5;
			while (true)
			{
				int num2 = 612954211;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x7C620177u) % 4u)
					{
					case 3u:
						goto IL_0004;
					case 0u:
						num = 2;
						num2 = (int)(num3 * 2017690757) ^ -431403788;
						continue;
					case 1u:
						break;
					default:
						HurtSand(new byte[9] { 225, 136, 35, 109, 238, 53, 90, 179, 81 });
						return;
					}
					break;
					IL_0004:
					int num4 = num;
					int num5 = num4 * num4;
					int num6 = num;
					if (num5 + num6 * num6 + 2 * num * num != (num + num) * (num + num))
					{
						goto end_IL_0059;
					}
					num2 = (int)(num3 * 1440958658) ^ -1052352365;
				}
				continue;
				end_IL_0059:
				break;
			}
		}
	}

	private static void HurtSand(byte[] byte_0)
	{
		List<int> list = new List<int>();
		list.Add(2090);
		list.Add(3881);
		list.Add(355);
		while (true)
		{
			int num = 1912985676;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x287F4BE6u) % 5u)
				{
				case 4u:
					list.Add(15350);
					num = (int)((num2 * 1888803637) ^ 0x3256EBAD);
					continue;
				case 3u:
					Array.Reverse((Array)Mindsong);
					num = (int)(num2 * 1762864722) ^ -966289332;
					continue;
				case 0u:
					list.Add(11668);
					Mindsong = byte_0;
					num = (int)(num2 * 1577441561) ^ -144390532;
					continue;
				default:
					return;
				case 1u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public static byte MaryAlso(int int_0)
	{
		new object();
		List<string> list = default(List<string>);
		int num3 = default(int);
		while (true)
		{
			int num = 885689497;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1ED31AFBu) % 7u)
				{
				case 6u:
				{
					int num4;
					if (new object() == WonderCame.WhilesMachine)
					{
						num = 130959244;
						num4 = 130959244;
					}
					else
					{
						num = 1518855081;
						num4 = 1518855081;
					}
					continue;
				}
				case 5u:
					num = 1050704141;
					continue;
				case 4u:
					list.Add("OTOablOeOBOeOiOnOg".Replace("O", ""));
					list.Add("SciewnwtiwstwVwiwswit".Replace("w", ""));
					list.Add("StoppedRBookCharteport".Remove(8, 9));
					list.Add("TestwithFoureTestwithxeTestwithrTestwithcTestwithise".Replace("Testwith", ""));
					num3 = int_0 % Mindsong.Length;
					num = (int)((num2 * 1195786009) ^ 0x11F843F2);
					continue;
				case 1u:
				{
					string[] array = new string[7];
					array[3] = "fr";
					array[6] = "a";
					array[4] = "i";
					array[5] = "c";
					array[1] = "ot";
					array[0] = "N";
					array[2] = "a";
					string.Concat(array);
					list = new List<string>();
					num = (int)((num2 * 1770752157) ^ 0x2AA5325A);
					continue;
				}
				case 0u:
					num = (int)((num2 * 1085990871) ^ 0xBBF5368);
					continue;
				case 2u:
					break;
				default:
					return Mindsong[Mindsong.Length - 1 - num3];
				}
				break;
			}
		}
	}
}
