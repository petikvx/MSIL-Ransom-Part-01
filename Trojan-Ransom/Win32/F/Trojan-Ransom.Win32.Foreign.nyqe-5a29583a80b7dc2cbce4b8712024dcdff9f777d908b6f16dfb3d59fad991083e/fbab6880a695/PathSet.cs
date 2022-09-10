using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace fbab6880a695;

[StandardModule]
internal sealed class PathSet
{
	public static string[] nextCaption;

	static PathSet()
	{
		string[] array = new string[15]
		{
			"Rm9ybTE=", "Q2xpY2sgTWUh", null, null, null, null, null, null, null, null,
			null, null, null, null, null
		};
		while (true)
		{
			int num = -51501937;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC85B2D25u) % 14u)
				{
				case 13u:
					array[11] = "TWFybGV0dA==";
					num = ((int)num2 * -1321782943) ^ 0x29E65EED;
					continue;
				case 12u:
					array[5] = "LnJlc291cmNlcw==";
					num = ((int)num2 * -763643653) ^ 0x3D07B4EA;
					continue;
				case 11u:
					array[6] = "WW91IENsaWNrZWQgTWUh";
					num = ((int)num2 * -1913544820) ^ 0xE818064;
					continue;
				case 10u:
					array[14] = "Ng==";
					nextCaption = ToggleDatabase(array);
					num = (int)(num2 * 851427295) ^ -1562398058;
					continue;
				case 8u:
					array[3] = "MQ==";
					num = (int)((num2 * 1323331169) ^ 0x6321A159);
					continue;
				case 7u:
					array[12] = "dQ==";
					num = (int)(num2 * 10609512) ^ -1278442907;
					continue;
				case 6u:
					array[9] = "VGFob21h";
					num = ((int)num2 * -183430158) ^ -745980300;
					continue;
				case 4u:
					array[2] = "MA==";
					num = ((int)num2 * -1113379766) ^ -2129717093;
					continue;
				case 3u:
					array[7] = "QXJpYWw=";
					array[8] = "";
					num = ((int)num2 * -1860527625) ^ 0x4184308A;
					continue;
				case 2u:
					array[4] = "XzA4NDViYjdiMzZmZQ==";
					num = (int)(num2 * 1546877139) ^ -798975263;
					continue;
				case 1u:
					array[10] = "dA==";
					num = (int)((num2 * 1939876324) ^ 0x3A3B20A2);
					continue;
				case 0u:
					array[13] = "IC4uLiA=";
					num = (int)((num2 * 208796145) ^ 0x10867A97);
					continue;
				default:
					return;
				case 9u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private static string[] ToggleDatabase(string[] nextCaption)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		int num4 = default(int);
		int num3 = default(int);
		List<string> list = default(List<string>);
		string[] result = default(string[]);
		while (true)
		{
			int num = -65796129;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB315E861u) % 7u)
				{
				case 5u:
				{
					int num5;
					if (num4 > num3)
					{
						num = -1119574362;
						num5 = -1119574362;
					}
					else
					{
						num = -679107698;
						num5 = -679107698;
					}
					continue;
				}
				case 4u:
					num = ((int)num2 * -351134914) ^ -1039320840;
					continue;
				case 3u:
					list.Add(uTF8Encoding.GetString(Convert.FromBase64String(nextCaption[num4])));
					num4 = checked(num4 + 1);
					num = -551717424;
					continue;
				case 2u:
					list = new List<string>();
					num3 = checked(nextCaption.Length - 1);
					num4 = 0;
					num = ((int)num2 * -1741038922) ^ -573880124;
					continue;
				case 1u:
					result = list.ToArray();
					num = ((int)num2 * -836707392) ^ -1690422835;
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}
}
