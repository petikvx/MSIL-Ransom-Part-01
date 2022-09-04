using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Resources;

namespace ns0;

internal sealed class Class0
{
	internal static Struct0 struct0_0/* Not supported: data(C1 DC 00 00 0A 0C 00 00 C5 AC 00 00 EE 2E 00 00 A3 3E 00 00 E5 14 00 00 59 1A 00 00 27 05 00 00 AA D9 00 00 8A 01 00 00 09 0E 00 00 92 40 00 00 50 97 00 00 32 51 00 00 88 73 00 00 98 E2 00 00 C3 53 00 00 60 6F 00 00 02 5D 00 00 7A 21 00 00 3A 30 00 00 15 07 00 00 22 35 00 00 1F E8 00 00 AF 23 00 00 4D CC 00 00 1C 98 00 00 31 73 00 00 55 F9 00 00 57 B2 00 00 FA 10 00 00 26 79 00 00 D8 2E 00 00 C0 09 00 00 3E 7B 00 00 5D 11 00 00 20 C8 00 00 06 E0 00 00 27 C2 00 00 53 47 00 00 F6 7E 00 00 05 03 00 00 F2 85 00 00 84 D9 00 00 0C 34 00 00 46 57 00 00 80 62 00 00 70 F9 00 00 44 01 00 00 3A 4A 00 00 10 B7 00 00 DF 4D 00 00 0D 9C 00 00 F5 CD 00 00 F1 70 00 00 AB D5 00 00 E6 D6 00 00 A4 C4 00 00 3F 0B 00 00 54 72 00 00 C8 7C 00 00 26 A7 00 00 D0 0B 00 00 52 27 00 00 8E F0 00 00 E2 94 00 00 B9 11 00 00 8F 8D 00 00 F3 D5 00 00 2A 62 00 00 78 1A 00 00 BB 73 00 00 37 AD 00 00 AF 15 00 00 82 A2 00 00 34 2D 00 00 22 81 00 00 9C 5B 00 00 12 B4 00 00 68 CC 00 00 CD 69 00 00 AA 9E 00 00 EC 71 00 00 1B AF 00 00 46 FB 00 00 1A C3 00 00 17 DD 00 00 E1 60 00 00 CE 98 00 00 91 A5 00 00 75 3A 00 00 7B 03 00 00 C7 D4 00 00 D2 4F 00 00 89 CA 00 00 CE D7 00 00 34 F7 00 00 9F 5E 00 00 F4 E8 00 00 29 9F 00 00 8C 45 00 00 F0 D4 00 00 7D 23 00 00 19 9F 00 00 C1 2F 00 00 55 43 00 00 A6 A0 00 00 5E 86 00 00 72 2B 00 00 BC 43 00 00 88 54 00 00 4A 7B 00 00 92 10 00 00 D5 3E 00 00 87 08 00 00 1C DE 00 00 3A 35 00 00 B4 5C 00 00 0B 2C 00 00 74 2D 00 00 C9 B7 00 00 D6 B0 00 00 C0 F4 00 00 61 30 00 00 B4 27 00 00 FD 16 00 00 F2 9E 00 00 64 5D 00 00 24 4B 00 00 B3 CA 00 00 FF 35 00 00 83 22 00 00 A6 72 00 00 E9 14 00 00 DB 86 00 00 DC 94 00 00 2D 7B 00 00 D2 D2 00 00 5A 7F 00 00 F1 B7 00 00 74 22 00 00 B9 56 00 00 6F 35 00 00 11 55 00 00 08 51 00 00 2A BF 00 00 E8 F2 00 00 F1 95 00 00 4B 47 00 00 6C EC 00 00 94 A2 00 00 7F 9A 00 00 93 32 00 00 80 BB 00 00 5E E7 00 00 B4 94 00 00 2E E0 00 00 1A F3 00 00 65 77 00 00 C4 18 00 00 61 A4 00 00 41 43 00 00 39 3B 00 00 BE 60 00 00 BC 0D 00 00 05 32 00 00 A4 08 00 00 A7 FB 00 00 F8 B7 00 00 AA 73 00 00 EF 62 00 00 67 62 00 00 58 DD 00 00 19 74 00 00 00 0B 00 00 10 61 00 00 67 7B 00 00 AE 9F 00 00 58 DF 00 00 89 68 00 00 13 24 00 00 00 09 00 00 19 16 00 00 B7 5E 00 00 1F 28 00 00 7F 9B 00 00 EF EF 00 00 24 B7 00 00 8A 2D 00 00 26 F2 00 00 AC B4 00 00 11 88 00 00 6D 5B 00 00 96 66 00 00 8F 13 00 00 31 DF 00 00 80 1B 00 00 AF D4 00 00 54 47 00 00 03 1F 00 00 85 B6 00 00 3F F7 00 00 F7 DD 00 00 A0 D3 00 00 7C 89 00 00 2C 40 00 00 26 BD 00 00 78 BE 00 00 80 B0 00 00 4E 86 00 00 4C 19 00 00 80 40 00 00 C2 13 00 00 DB 0E 00 00 AF F4 00 00 60 9B 00 00 28 2D 00 00 81 DC 00 00 9E 38 00 00 3C 72 00 00 15 42 00 00 7E 51 00 00 1D CE 00 00 D1 C5 00 00 FC BE 00 00 DD DA 00 00 FA 06 00 00 C2 76 00 00 89 60 00 00 CD 2B 00 00 90 45 00 00 B7 A6 00 00 59 58 00 00 54 C0 00 00 02 B2 00 00 D3 2C 00 00 07 2B 00 00 77 42 00 00 39 D5 00 00 F1 E7 00 00 58 DE 00 00 76 31 00 00 A4 06 00 00 3B A7 00 00 D9 D8 00 00 2C 74 00 00 4E 74 00 00 91 4C 00 00 E6 71 00 00 2E 78 00 00 09 B2 00 00 FD 3E 00 00 10 9C 00 00 17 D5 00 00 EC DC 00 00 06 65 00 00 21 29 00 00 26 18 00 00 A3 14 00 00 9E AE 00 00 32 39 00 00 63 46 00 00 EE 5D 00 00 B2 84 00 00 BE 40 00 00 94 72 00 00 25 E8 00 00 6D 53 00 00 D7 5C 00 00 DB C7 00 00 58 70 00 00 AF EA 00 00 48 07 00 00 AC 50 00 00 E3 93 00 00 9E 10 00 00 DA 4A 00 00 E2 26 00 00 F7 EC 00 00 CF 4A 00 00 8F 66 00 00 67 BA 00 00 DC 04 00 00 5A E8 00 00 C3 79 00 00 92 06 00 00 A6 0A 00 00 41 83 00 00 67 E3 00 00 FB 4C 00 00 B1 03 00 00 E1 12 00 00 D3 2D 00 00 9B 26 00 00 BF AE 00 00 F4 97 00 00 86 D3 00 00 F0 81 00 00 7D 66 00 00 44 66 00 00 06 8C 00 00 E1 20 00 00 B8 EF 00 00 09 AA 00 00 D6 07 00 00 58 C7 00 00 B5 37 00 00 64 4B 00 00 33 41 00 00 4E CC 00 00 2C 1A 00 00 3F 02 00 00 2D 2B 00 00 D3 C9 00 00 0F 48 00 00 C9 7E 00 00 87 41 00 00 93 75 00 00 EF 0A 00 00 2B 3A 00 00 EE 67 00 00 E3 64 00 00 04 70 00 00 DC 0F 00 00 29 C4 00 00 76 5D 00 00 DB BC 00 00 AC E0 00 00 EC A1 00 00 EE FB 00 00 16 3D 00 00 E8 C8 00 00 64 C0 00 00 B3 86 00 00 C8 BE 00 00 AE 45 00 00 AE CA 00 00 D1 5A 00 00 84 E0 00 00 69 B2 00 00 DC CE 00 00 40 BF 00 00 0E 42 00 00 19 17 00 00 CF 32 00 00 72 01 00 00 B3 E7 00 00 FF 63 00 00 8A DE 00 00 F5 2F 00 00 6D 56 00 00 F3 5D 00 00 01 77 00 00 51 2C 00 00 54 FE 00 00 23 27 00 00 DB B0 00 00 DC DF 00 00 DE E5 00 00 5E AA 00 00 7D 0A 00 00 08 57 00 00 77 A9 00 00 44 45 00 00 37 8F 00 00 42 51 00 00 D9 41 00 00 78 A4 00 00 0A 0B 00 00 60 02 00 00 1A B4 00 00 B4 E6 00 00 0D 95 00 00 84 58 00 00 4E 6B 00 00 AD A8 00 00 D4 22 00 00 EB 58 00 00 0B DD 00 00 B7 C2 00 00 C2 75 00 00 DB 58 00 00 21 02 00 00 F7 71 00 00 80 A5 00 00 22 DF 00 00 E7 51 00 00 13 94 00 00 5D 88 00 00 A5 97 00 00 D1 94 00 00 D0 EA 00 00 F1 74 00 00 25 36 00 00 EC A7 00 00 D3 77 00 00 C9 15 00 00 C9 FC 00 00 E0 87 00 00 8B E1 00 00 97 BF 00 00 3A 43 00 00 F5 58 00 00 2A DC 00 00 D9 7B 00 00 B7 6F 00 00 E4 C8 00 00 7C 1E 00 00 01 C1 00 00 A7 55 00 00 4E 04 00 00 EF 57 00 00 D0 02 00 00 27 23 00 00 9C 34 00 00 A1 B1 00 00 E6 54 00 00 80 37 00 00 C2 9F 00 00 13 B0 00 00 5A FF 00 00 C5 AD 00 00 1A 1C 00 00 64 73 00 00 8E 6D 00 00 48 C9 00 00 C2 71 00 00 E8 5E 00 00 97 B0 00 00 79 F3 00 00 E3 92 00 00 0A 26 00 00 09 D1 00 00 7E FB 00 00 1F 03 00 00 87 32 00 00 E4 FF 00 00 F6 25 00 00 1C F6 00 00 C8 35 00 00 3D 16 00 00 6A 33 00 00 10 D3 00 00 B6 32 00 00 56 93 00 00 E2 3C 00 00 FF E7 00 00 CA 51 00 00 89 01 00 00 4A F6 00 00 EC 22 00 00 48 DE 00 00 06 5D 00 00 CC D7 00 00 30 E2 00 00 D1 11 00 00 1F 27 00 00 90 E5 00 00 9B 6E 00 00 8F B2 00 00 F4 FD 00 00 FC 69 00 00 E4 6D 00 00 87 CD 00 00 C2 C2 00 00 42 DE 00 00 E4 86 00 00 51 07 00 00) */;

	internal static int[] int_0;

	public static Stream smethod_0(string string_0)
	{
		int[] array = int_0;
		while (true)
		{
			object obj = (Stream)Class2.Class3.smethod_1(new ResourceManager(string_0, Class4.Class5.Class6.smethod_1(240, 'ÿ')), Class4.Class5.Class6.smethod_0(null, 5, 2017833777), 'Ȫ', 637);
			while (true)
			{
				int num = 0;
				while (true)
				{
					switch (num)
					{
					default:
					{
						int num2 = array[337];
						Class1.byte_0[16] = (byte)((Class1.byte_0[16] - Class1.byte_0[112]) & 0xBA);
						num = num2 - 23244;
						continue;
					}
					case 3:
						break;
					case 4:
					case 5:
						goto end_IL_0055;
					case 0:
					case 2:
						return obj as Stream;
					}
					break;
				}
				continue;
				end_IL_0055:
				break;
			}
		}
	}

	public static byte[] smethod_1(string string_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		Image val = (Image)new Bitmap(smethod_0(string_0));
		return smethod_2((Bitmap)val);
	}

	public static byte[] smethod_2(Bitmap bitmap_0)
	{
		byte[] byte_ = Class1.byte_0;
		int[] array = int_0;
		Color color_ = default(Color);
		int num3 = default(int);
		Color color_2 = default(Color);
		while (true)
		{
			object obj = new List<byte>();
			while (true)
			{
				int num = 0;
				int num2 = 5;
				while (true)
				{
					switch (num2)
					{
					case 13:
						num++;
						num2 = array[217] - 56444;
						continue;
					case 11:
						color_ = Class4.Class5.Class6.smethod_6<Bitmap>(bitmap_0, num, num3, 238, 170);
						color_2 = Class4.Class5.smethod_4(0, 0, 0, 0, 668, 737);
						num2 = 6;
						continue;
					case 2:
					case 8:
					case 9:
						num3 = 0;
						num2 = 7;
						continue;
					case 7:
						break;
					case 6:
						goto IL_0082;
					case 5:
						goto IL_00d3;
					default:
						num2 = 10;
						continue;
					case 3:
					{
						List<byte> obj2 = (List<byte>)obj;
						object obj3 = new byte[3];
						(obj3 as byte[])[0] = Class2.smethod_4(ref color_, 607, 598);
						((byte[])obj3)[1] = Class2.smethod_4(ref color_, 270, 260);
						((byte[])obj3)[2] = Class2.smethod_4(ref color_, 11, 0);
						obj2.AddRange((byte[])obj3);
						goto case 0;
					}
					case 0:
						num3++;
						num2 = 7;
						continue;
					case 1:
						goto end_IL_015f;
					case 10:
						goto end_IL_01a2;
					case 12:
						return (obj as List<byte>).ToArray();
					}
					num2 = ((num3 < ((Image)bitmap_0).get_Height()) ? byte_[90] : 13);
					continue;
					IL_00d3:
					num2 = ((num < ((Image)bitmap_0).get_Width()) ? 2 : (array[301] - 8405));
					continue;
					IL_0082:
					bool num4 = Class2.Class3.smethod_3(color_, color_2, 978, 'ΰ');
					int_0[241] = int_0[241] & int_0[92] & 0x83;
					num2 = ((!num4) ? (byte_[46] - 157) : 3);
					continue;
					end_IL_015f:
					break;
				}
				continue;
				end_IL_01a2:
				break;
			}
		}
	}

	public static byte[] smethod_3(byte[] byte_0)
	{
		int[] array = int_0;
		byte[] byte_ = Class1.byte_0;
		int num2 = default(int);
		while (true)
		{
			Array array2 = new byte[byte_0.Length - 16];
			Class4.smethod_3((Array)byte_0, 16, (Array)(byte[])array2, 0, ((byte[])array2).Length, 489, (short)493);
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 8:
				case 9:
					((byte[])array2)[num2] ^= byte_0[num2 % 16];
					num = 6;
					continue;
				case 6:
				{
					int num3 = num2;
					Class1.byte_0[61] = (byte)((Class1.byte_0[61] ^ Class1.byte_0[99]) & 0x89);
					num2 = num3 + 1;
					num = byte_[109] - 196;
					continue;
				}
				default:
					num = array[235] - 11471;
					continue;
				case 3:
					num = array[203] - 54175;
					continue;
				case 2:
					num2 = 0;
					goto case 3;
				case 1:
					num = ((num2 < ((byte[])array2).Length) ? (byte_[18] - 139) : byte_[9]);
					continue;
				case 4:
					break;
				case 0:
				case 7:
					return array2 as byte[];
				}
				break;
			}
		}
	}
}
