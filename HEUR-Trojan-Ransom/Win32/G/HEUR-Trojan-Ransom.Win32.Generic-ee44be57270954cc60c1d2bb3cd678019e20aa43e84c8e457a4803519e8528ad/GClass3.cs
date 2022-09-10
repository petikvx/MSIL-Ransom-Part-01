using System;
using System.IO;
using System.Text;

public sealed class GClass3 : GClass0
{
	private string string_2;

	internal GClass3(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		string_2 = memoryStream_0.ReadByte().ToString("x2") + memoryStream_0.ReadByte().ToString("x2") + ":" + memoryStream_0.ReadByte().ToString("x2") + memoryStream_0.ReadByte().ToString("x2") + ":" + memoryStream_0.ReadByte().ToString("x2") + memoryStream_0.ReadByte().ToString("x2") + ":" + memoryStream_0.ReadByte().ToString("x2") + memoryStream_0.ReadByte().ToString("x2") + ":" + memoryStream_0.ReadByte().ToString("x2") + memoryStream_0.ReadByte().ToString("x2") + ":" + memoryStream_0.ReadByte().ToString("x2") + memoryStream_0.ReadByte().ToString("x2") + ":" + memoryStream_0.ReadByte().ToString("x2") + memoryStream_0.ReadByte().ToString("x2") + ":" + memoryStream_0.ReadByte().ToString("x2") + memoryStream_0.ReadByte().ToString("x2");
		string_0 = "IPv6 Address: " + string_2;
	}

	private static string smethod_1(byte[] byte_0)
	{
		if (byte_0 != null)
		{
			StringBuilder stringBuilder = default(StringBuilder);
			int num3 = default(int);
			while (true)
			{
				int num = 46580389;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x37CA778Eu) % 9u)
					{
					case 8u:
						stringBuilder.Append(byte_0[num3].ToString("X2"));
						num = 1480795117;
						continue;
					case 6u:
						num3 = 0;
						num = (int)(num2 * 657388986) ^ -395150593;
						continue;
					case 4u:
						stringBuilder = new StringBuilder(1024);
						num = (int)((num2 * 199734881) ^ 0x43FFEF43);
						continue;
					case 2u:
						num3++;
						num = (int)((num2 * 1018208844) ^ 0xE96AB9C);
						continue;
					case 1u:
						break;
					case 0u:
						num = ((int)num2 * -810453935) ^ 0x7951A2C5;
						continue;
					case 3u:
						goto end_IL_0094;
					case 5u:
						return stringBuilder.ToString();
					default:
						goto end_IL_00ca;
					}
					int num4;
					if (num3 >= byte_0.Length)
					{
						num = 378949718;
						num4 = 378949718;
					}
					else
					{
						num = 594451897;
						num4 = 594451897;
					}
					continue;
					end_IL_0094:
					break;
				}
				continue;
				end_IL_00ca:
				break;
			}
		}
		return null;
	}

	private static byte[] smethod_2(string string_3)
	{
		int num = string_3.Length / 2;
		int num4 = default(int);
		byte[] array = default(byte[]);
		int num5 = default(int);
		int value2 = default(int);
		string value = default(string);
		while (true)
		{
			int num2 = -2087822506;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xA8CB43C3u) % 8u)
				{
				case 7u:
				{
					int num6;
					if (num4 < string_3.Length - 1)
					{
						num2 = -268764062;
						num6 = -268764062;
					}
					else
					{
						num2 = -1145239032;
						num6 = -1145239032;
					}
					continue;
				}
				case 6u:
					num2 = (int)(num3 * 21933031) ^ -1262353538;
					continue;
				case 5u:
					array = new byte[num - 1];
					num5 = 0;
					num4 = 0;
					num2 = (int)((num3 * 486472332) ^ 0x41AE1CC9);
					continue;
				case 4u:
					array[num5] = Convert.ToByte(value2);
					num5++;
					num4 = 2;
					num2 = (int)(num3 * 1476164465) ^ -1318037784;
					continue;
				case 2u:
					value2 = Convert.ToInt32(value, 16);
					num2 = ((int)num3 * -1484746454) ^ -689672453;
					continue;
				case 1u:
					value = string_3.Substring(num4, 2);
					num2 = -555773471;
					continue;
				case 0u:
					break;
				default:
					return array;
				}
				break;
			}
		}
	}
}
