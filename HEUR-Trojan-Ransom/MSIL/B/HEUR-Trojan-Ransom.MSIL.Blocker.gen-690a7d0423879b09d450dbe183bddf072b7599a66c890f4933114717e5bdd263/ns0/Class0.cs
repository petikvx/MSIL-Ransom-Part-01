using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Policy;

namespace ns0;

internal static class Class0
{
	internal static Struct0 struct0_0/* Not supported: data(22 95 A1 99 A9 63 1A 9B 37 24 34 A3 3D 96 57 06 E9 29 AC 1B 10 AC 73 0B 91 0E 5A 29 CE 0B 40 E6 F4 68 F6 21 40 F3 8C A5 79 DC 73 76 B5 C0 5F BE C8 21 15 56 D7 80 93 3F FA 6A 33 9E 8F 86 5F FA DA 3C 89 8C 73 6B 09 99 CB 2E E7 EA E5 5B F6 6E 28 AF 6D 2D E2 70 2B 24 DE D7 90 7F A2 B2 8E 83 DD 1C 3E 37 A1 D1 F0 4F 7B 88 BE 81 FD A1 AF 1E EB D8 49 A5 52 79 20 CE 5D 22 AA 56 5C 9B B5 8B 1B 95 AF B1 98 CE 06 82 E6 BD C3 72 75 B7 0B 7E 0F C6 49 84 63 F6 0B AF 90 05 8A 9C 7F E6 36 A2 72 A3 48 FD B5 22 BB 33 90 CC 9F 36 E4 71 1A BB 8B EA C3 4C 1D C0 80 89 95 71 C4 8D 99 4C 7E 58 10 92 2B E5 0E 8F 2F 26 F7 B0 9B 30 A6 C5 19 AA C8 7F 95 53 DF 89 31 04 5A 8B F0 F2 1E 19 61 3C C9 BE 1A D7 AD 2A 14 25 F4 33 A1 67 23 BF 7B 5E CB 3F 7D 13 79 97 22 71 A4 B2 F4 2D 76 0C 4B 38 B0 37 E4 9D FB 1C 64 20 7B 0D 50 C0 3D F1 D7 72 A1 37 9B 78 F1 B3 FB 78 BF AC B2 6D C0 2F 99 F7 A4 33 BC 83 B6 CA 79 9A 16 63 84 27 89 24 6E 2A 08 26 92 30 62 E6 7A 9D 20 99 83 54 73 F7 D4 51 1F 47 93 51 7F CC 74 ED F5 D5 B9 F8 E5 2E 77 FE DB E5 D5 B7 72 ED 58 BB AF B3 28 46 BB B1 18 D2 BC E3 DE 9F 7D 3D E8 2E 3C 63 FB 71 34 D5 2B 10 5B 79 8B F2 5A FA E7 DC EC D9 C3 53 B5 D9 1C E3 26 81 1D 62 DC 31 2B 5B 31 A1 4A 42 A4 21 EA 3A D6 54 3D CC 9C B4 3F AB 11 3A 30 69 BE 76 DE DF D6 7E 4A 14 BD B9 40 F9 06 17 8B C8 96 EE 22 D5 5E 7C 53 BC 19 74 69 E3 5D FE FD 51 8B 24 18 92 1F DE 55 0A 31 3A 91 51 4C 14 8F 56 E6 30 71 A1 3A 7E 93 02 10 DA FD 96 5E BD F5 29 19 D6 2A 10 CC 7B 7B 1A 10 5E A2 C5 05 9A 73 E0 16 CC 9A B8 85 73 B9 5C CC DE DC E4 30 CE 3A 3E 8B 3C D9 02 B2 A7 83 22 1E CD BB 2F FE 2E 2C 25 92 CB 46 28 63 E3 4B 18 06 7B 72 14 79 EE 99 57 C3 17 68 52 39 E6 EE 63 9C 67 E1 E3 EB F3 E7 5E 12 F8 AA FD 3E 3E 95 81 0B DE 91 B7 C1 77 08 4C 40 D3 00 40 06 C6 37 D7 49 EF DA 9A D5 5C 5D A6 2A E1 A0 56 E7 4E C9 35 3E E2 B9 81 6D 65 A3 B7 20 CA EC 1B F5 44 63 8C A2 FE 41 6A 9D D6 A8 58 ED 0E CA 48 70 2A 73 CF 7B F1 67 AD 20 47 01 14 84 B0 5A 97 0A 45 05 3B 6A 4E 41 17 4E 68 E8 7C 92 F5 DB 3F C2 82 FB 10 FA 94 21 BE A8 7C 59 76 3C 98 9A 86 74 B7 1E C2 9C 72 5C EB 65 4D FE 68 62 69 5E 6D 4A C8 7F A6 69 70 60 8D E0 B4 C2 33 80 0F E6 3A 44 85 E3 4A AE 3C 68 2A 38 69 DE B2 9D B3 0C C8 D0 96 C6 BE 7E E7 A1 C5 AD C3 CB 50 21 CC 16 B4 37 37 E1 6A F2 F5 00 85 63 A1 26 C5 F4 49 0A DC A2 D1 0B E1 F6 4E CE C1 7E 0C 31 68 F9 8A FF 4E 7B 01 13 5A DC 38 C5 31 AA 39 D4 6D 62 1D 95 04 81 0E 8F AA 8C 54 9E 8E 7F 81 BF A3 AF A9 7F 77 5C DA 52 BC 29 56 FF 49 CF 3D 7E 8A 81 99 1D C0 EF 00 A3 60 C4 58 2B 88 E8 63 CE F1 8D BB 9E 2E CC 33 7E 98 25 C4 9A 69 EE 17 5B 9A 6C 7A 62 C9 7E 4D 5C F1 7F 76 D3 F6 99 70 55 BB 8B 5A E3 2D 5B 37 75 D7 70 E7 2A 50 08 12 FA 40 30 11 FC 76 90 C0 BD 78 D6 30 06 D9 0F 15 35 95 AB A0 B1 1C 00 EF ED 25 D2 5A 00 E9 98 DF 15 40 90 5F 01 40 E6 41 C6 8C 7F FC 71 4C FF 13 AD A2 83 4F 98 45 17 06 E1 2A D0 50 71 8C 5E 0A 62 6B 96 1C D1 F2 4E 87 29 4D 08 A9 30 9F 85 69 65 A1 52 B4 48 B8 B0 50 CD 59 D3 07 AC 4A 83 60 89 71 49 4E 44 F7 E5 77 6F A7 44 0E 40 85 79 44 BD C4 FD 62 E3 1D 3A 29 3C EB EE D2 2D EA 65 44 3A 14 53 12 9D 83 56 09 FF 67 B2 61 6F 92 0C 97 5F C0 7A D6 80 A0 73 D8 37 44 BF FB 30 BA D9 9A D6 04 14 E5 8C 94 96 DC 8A 59 8C 14 EE 62 1E 5D 54 97 58 AE 8F C2 2B EA 25 8B F5 75 48 7E 75 CE 23 CA E3 73 76 3C 79 47 35 84 56 41 82 F8 D7 0F D8 BB 38 60 84 B7 F4 D0 C3 6D CC AC 41 00 FC C8 CB A8 08 83 63 24 27 06 61 3E 96 0D D9 EA AC FF 64 AF 7F 26 00 72) */;

	internal static char[] char_0;

	internal static Struct5 struct5_0/* Not supported: data(10 B9 00 00 A9 6D 00 00 8E 8D 00 00 FE D0 00 00 63 74 00 00 AE 88 00 00 B9 68 00 00 7B FF 00 00 C7 A0 00 00 CB 78 00 00 10 5D 00 00 7F E0 00 00 C9 D8 00 00 CC AF 00 00 42 FA 00 00 8E 7F 00 00 D5 93 00 00 B6 79 00 00 BA 21 00 00 5B EA 00 00 42 8B 00 00 CE 9D 00 00 FD C1 00 00 63 2B 00 00 A3 DA 00 00 F6 18 00 00 BB 59 00 00 BF F7 00 00 7E 0A 00 00 F0 CA 00 00 69 0B 00 00 0E BF 00 00 E7 77 00 00 E7 DA 00 00 E0 4D 00 00 1B CB 00 00 A1 4D 00 00 81 E3 00 00 5D EA 00 00 BD 74 00 00 96 D0 00 00 94 B1 00 00 63 C9 00 00 34 41 00 00 78 30 00 00 21 85 00 00 40 D7 00 00 7F 98 00 00 76 E8 00 00 00 5C 00 00 85 25 00 00 EC 3A 00 00 E7 CB 00 00 61 AD 00 00 B9 DA 00 00 41 1B 00 00 AA AB 00 00 2A 62 00 00 5A F6 00 00 6D 5B 00 00 F2 2E 00 00 F9 70 00 00 FC F4 00 00 D6 D5 00 00 62 6D 00 00 00 9E 00 00 98 68 00 00 E0 FD 00 00 EB 61 00 00 27 2F 00 00 ED 31 00 00 53 B0 00 00 58 8F 00 00 FB AC 00 00 C5 19 00 00 AC D9 00 00 6A D4 00 00 C9 80 00 00 E9 FA 00 00 82 55 00 00 B4 41 00 00 3B C1 00 00 48 0F 00 00 7C AE 00 00 6B A5 00 00 7B D0 00 00 26 F3 00 00 85 CA 00 00 2E 00 00 00 9E 32 00 00 70 1F 00 00 75 EB 00 00 26 ED 00 00 EF 8E 00 00 CA 45 00 00 9D 5F 00 00 96 BC 00 00 8B F3 00 00 D1 D3 00 00 76 92 00 00 89 1C 00 00 5E D9 00 00 93 36 00 00 4F B9 00 00 13 2A 00 00 30 75 00 00 93 AB 00 00 EB 1E 00 00 9C 93 00 00 0C 01 00 00 D6 46 00 00 E1 2A 00 00 40 67 00 00 D8 A0 00 00 B8 19 00 00 B6 6D 00 00 B0 61 00 00 7F 46 00 00 6B 30 00 00 E5 9C 00 00 D9 AA 00 00 11 9E 00 00 B2 FD 00 00 4D 2F 00 00 B6 0F 00 00 76 46 00 00 2C C3 00 00 68 00 00 00 30 67 00 00 27 BA 00 00 16 1D 00 00 DE E0 00 00 F6 AC 00 00 73 68 00 00 F8 38 00 00 54 68 00 00 A7 8A 00 00 F7 55 00 00 69 84 00 00 3A 30 00 00 E8 24 00 00 3A D4 00 00 E9 36 00 00 21 FF 00 00 C6 EB 00 00 8E F4 00 00 35 84 00 00 4E 4C 00 00 37 75 00 00 13 D8 00 00 EB FD 00 00 16 76 00 00 20 C3 00 00 EB 36 00 00 9C E7 00 00 76 7E 00 00 AB DB 00 00 46 07 00 00 98 A9 00 00 9B E3 00 00 03 B2 00 00 2A AB 00 00 B9 B7 00 00 74 D9 00 00 F4 E3 00 00 F7 65 00 00 E9 7D 00 00 CC FE 00 00 DF 67 00 00 62 B1 00 00 0E E3 00 00 B8 0B 00 00 15 C2 00 00 31 00 00 00 FD 77 00 00 9D D6 00 00 28 67 00 00 8F FE 00 00 85 43 00 00 27 1B 00 00 40 C2 00 00 DE 76 00 00 30 8B 00 00 1C 8F 00 00 3A BC 00 00 FE A6 00 00 BD 1D 00 00 0B 76 00 00 D6 80 00 00 81 BA 00 00 A8 8C 00 00 61 83 00 00 5D AC 00 00 CD A0 00 00 36 7E 00 00 BC 79 00 00 81 1C 00 00 74 5D 00 00 2C 1B 00 00 CF 85 00 00 A4 76 00 00 68 85 00 00 6D E4 00 00 D3 C3 00 00 03 F5 00 00 32 F2 00 00 00 B4 00 00 EF C2 00 00 EC BE 00 00 FE 10 00 00 4D 17 00 00 1A DD 00 00 BF C3 00 00 71 8E 00 00 5B 21 00 00 24 3B 00 00 F9 1F 00 00 9D 28 00 00 39 1D 00 00 F6 3C 00 00 39 48 00 00 DD 07 00 00 F6 7D 00 00 5C AD 00 00 B9 24 00 00 AD 5F 00 00 59 5F 00 00 47 21 00 00 F9 81 00 00 40 FE 00 00 1C BA 00 00 B4 09 00 00 63 E3 00 00 B4 BD 00 00 81 A4 00 00 D8 3C 00 00 6F 92 00 00 5B C7 00 00 17 9A 00 00 07 CA 00 00 FC F2 00 00 CD 5A 00 00 1E B7 00 00 D7 6F 00 00 34 A3 00 00 8D AF 00 00 A0 BF 00 00 EC 1D 00 00 71 7F 00 00 11 43 00 00 C2 59 00 00 E2 F3 00 00 3A 40 00 00 35 DE 00 00 96 3D 00 00 C6 6E 00 00 72 07 00 00 11 37 00 00 19 9F 00 00 56 95 00 00 D8 92 00 00 B8 92 00 00 F5 40 00 00 AA C0 00 00 E1 56 00 00 98 0D 00 00 B6 F9 00 00 0A 06 00 00 EE E9 00 00 82 E4 00 00 B4 A8 00 00 9D 58 00 00 85 8E 00 00 31 53 00 00 F8 49 00 00 6A ED 00 00 BE 50 00 00 1E 0E 00 00 28 0A 00 00 2B 75 00 00 0B A0 00 00 6D 41 00 00 D5 A1 00 00 E8 3E 00 00 7D A4 00 00 39 C6 00 00 78 C9 00 00 2D 05 00 00 1E 80 00 00 BB 35 00 00 65 35 00 00 5D 5B 00 00 41 28 00 00 C0 04 00 00 2E 37 00 00 44 60 00 00 D8 19 00 00 72 F6 00 00 F6 18 00 00 9B 95 00 00 D5 B5 00 00 96 B9 00 00 FC 33 00 00 EE 9A 00 00 5B 9A 00 00 25 01 00 00 5D 65 00 00 08 ED 00 00 3D 94 00 00 2A 50 00 00 08 1E 00 00 52 F9 00 00 E9 2C 00 00 EE 29 00 00 4A F5 00 00 6B 51 00 00 E2 F0 00 00 0C 02 00 00 2D 1C 00 00 A7 90 00 00 1F 44 00 00 88 F4 00 00 EA 85 00 00 33 B4 00 00 1C AF 00 00 56 4D 00 00 5B 30 00 00 C4 89 00 00 03 1C 00 00 B3 E9 00 00 92 D3 00 00 4B 5A 00 00 27 F5 00 00 8B 74 00 00 54 BF 00 00 73 E6 00 00 70 0D 00 00 E6 06 00 00 8C A4 00 00 58 A3 00 00 DB 60 00 00 6F DC 00 00 EF 70 00 00 F4 2F 00 00 B2 17 00 00 12 3C 00 00 74 2E 00 00 52 FE 00 00 75 0F 00 00 C1 E5 00 00 60 6F 00 00 CB 17 00 00 45 DA 00 00 4D 88 00 00 7C 51 00 00 4C C1 00 00 AC 33 00 00 C8 7F 00 00 D1 EB 00 00 04 4D 00 00 C8 D0 00 00 98 DB 00 00 05 D1 00 00 88 AA 00 00 97 7C 00 00 BC C3 00 00 2A 04 00 00 5C B8 00 00 98 6A 00 00 D6 0E 00 00 FB 43 00 00 FC E9 00 00 7F 5D 00 00 D3 78 00 00 CB 2F 00 00 AE 67 00 00 98 83 00 00 F6 55 00 00 80 9C 00 00 09 73 00 00 E1 1E 00 00 08 32 00 00 4E 7A 00 00 40 36 00 00 52 7A 00 00 C6 BB 00 00 04 80 00 00 D9 6C 00 00 0F 23 00 00 07 FE 00 00 C7 B2 00 00 A7 8D 00 00 13 1B 00 00 87 57 00 00 8E D2 00 00 42 85 00 00 69 0B 00 00 65 C6 00 00 5B B3 00 00 F5 53 00 00 E7 37 00 00 17 76 00 00) */;

	internal static int[] int_0;

	[STAThread]
	public static int Main(string[] args)
	{
		int[] array = int_0;
		char[] char_ = Class1.char_1;
		int num2 = default(int);
		while (true)
		{
			int num = array[77] - 32963;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
				case 7:
				{
					char num3 = char_[370];
					Class1.char_1[348] = (char)((Class1.char_1[348] | Class1.char_1[376]) & ']');
					num = num3 - 62424;
					continue;
				}
				case 5:
					num = num2 switch
					{
						0 => 1, 
						1 => 6, 
						2 => array[223] - 44379, 
						3 => char_[336] - 26408, 
						4 => char_[244] - 46945, 
						_ => 1, 
					};
					continue;
				default:
					num = array[116] - 25008;
					continue;
				case 1:
					num2 = 4;
					goto case 2;
				case 0:
					break;
				case 6:
				{
					Class4.Class5.Class6.smethod_0();
					AppDomain gparam_ = Class4.Class5.Class6.smethod_1('\u009a', 209);
					Class4.Class5.Class6.smethod_2<AppDomain, ResolveEventHandler>(gparam_, smethod_0, 'ί', 'ϗ');
					int result = Class10.Class11.smethod_7<Evidence, AssemblyName, AppDomain>(gparam_, new AssemblyName(Class4.smethod_0(7L, 982560017, null, 7)), null, args, 'é', '\u0096');
					char_0[487] = (char)((char_0[487] + char_0[88]) & '\v');
					return result;
				}
				}
				break;
			}
		}
	}

	public static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		int[] array = int_0;
		char[] char_ = Class1.char_1;
		int num2 = default(int);
		while (true)
		{
			object obj = char_0;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					num = array[199] - 34251;
					continue;
				case 0:
				case 6:
					num2 = (obj as char[])[182] - 54577;
					goto case 1;
				case 1:
				case 5:
					num = 2;
					continue;
				case 2:
					num = num2 switch
					{
						0 => 3, 
						1 => 3, 
						2 => 3, 
						3 => char_[181] - 21303, 
						4 => 6, 
						_ => array[113] - 41170, 
					};
					continue;
				case 4:
					break;
				case 3:
					return smethod_1(Convert.ToBase64String(Class10.Class11.smethod_8(Class4.smethod_1(147, '\u009f'), Class10.Class11.Class12.smethod_6(Class4.Class5.smethod_0(resolveEventArgs_0, 118, 75), 97, 2), 534, 'ɞ')));
				}
				break;
			}
		}
	}

	public static Assembly smethod_1(string string_0)
	{
		int[] array = int_0;
		char[] char_ = Class1.char_1;
		int num11 = default(int);
		object obj4 = default(object);
		int num4 = default(int);
		int num6 = default(int);
		int num9 = default(int);
		while (true)
		{
			Array array2 = Class1.char_0;
			object obj = char_0;
			while (true)
			{
				int num = 1;
				while (true)
				{
					switch (num)
					{
					default:
						num = 7;
						continue;
					case 4:
					case 5:
						num11 = (obj as char[])[371] - 34046;
						num = array[73] - 44283;
						continue;
					case 0:
						break;
					case 2:
						goto end_IL_0089;
					case 3:
					case 7:
						goto end_IL_00b4;
					case 1:
					{
						object obj2 = Class2.smethod_2(Class4.Class5.smethod_1('ϗ', 995), string_0, 484, 426);
						try
						{
							Stream obj3 = obj2 as Stream;
							if (obj3 == null)
							{
								obj4 = null;
							}
							else
							{
								int num2 = Class4.Class5.Class6.smethod_3(new BinaryReader(obj3), 134, 205);
								object obj5 = new DeflateStream(obj2 as Stream, CompressionMode.Decompress);
								try
								{
									int num3 = 3;
									while (true)
									{
										switch (num3)
										{
										case 6:
											num3 = num4 switch
											{
												0 => 1, 
												1 => 2, 
												2 => 1, 
												3 => 4, 
												4 => 2, 
												_ => char_[6] - 62449, 
											};
											continue;
										case 4:
											obj4 = Class4.Class5.Class6.smethod_4(Class4.Class5.smethod_2(new BinaryReader(obj5 as DeflateStream), num2, 'ñ', 208), 455, 405);
											num3 = char_[200] - 11203;
											continue;
										default:
											num4 = 3;
											goto case 6;
										case 2:
											break;
										case 0:
										case 1:
										case 5:
											break;
										}
										break;
									}
								}
								finally
								{
									int num5 = 1;
									while (true)
									{
										int num7;
										switch (num5)
										{
										case 9:
											num7 = 2;
											goto IL_01e8;
										case 2:
										case 8:
											num7 = ((char[])array2)[55] - 14739;
											goto IL_01e8;
										case 4:
										case 7:
											num5 = num6 switch
											{
												0 => 5, 
												1 => 3, 
												2 => 3, 
												3 => 5, 
												4 => 0, 
												5 => 0, 
												_ => 0, 
											};
											continue;
										case 0:
										case 6:
											num5 = ((!(obj5 is DeflateStream)) ? 9 : (char_[159] - 58535));
											continue;
										default:
											num6 = 4;
											num5 = 4;
											continue;
										case 5:
											((IDisposable)(obj5 as DeflateStream)).Dispose();
											break;
										case 3:
											break;
											IL_01e8:
											num6 = num7;
											num5 = char_[124] - 36911;
											continue;
										}
										break;
									}
								}
							}
						}
						finally
						{
							int num8 = 3;
							while (true)
							{
								int num10;
								switch (num8)
								{
								case 9:
									num8 = num9 switch
									{
										0 => 5, 
										1 => 0, 
										2 => char_[40] - 17676, 
										3 => array[314] - array[314], 
										4 => 4, 
										5 => array[15] - 32650, 
										_ => 0, 
									};
									continue;
								case 1:
								case 8:
									num10 = 2;
									goto IL_0322;
								case 7:
									num10 = 4;
									goto IL_0322;
								case 0:
								case 6:
									num8 = ((!(obj2 is Stream)) ? (char_[395] - 2464) : 7);
									continue;
								default:
									num9 = 3;
									num8 = array[117] - array[125];
									continue;
								case 4:
									((IDisposable)(Stream)obj2).Dispose();
									break;
								case 5:
									break;
									IL_0322:
									num9 = num10;
									num8 = 9;
									continue;
								}
								break;
							}
						}
						Assembly result = (obj4 as ISerializable) as Assembly;
						char_0[219] = (char)((char_0[219] + char_0[170]) & '³');
						return result;
					}
					}
					num = num11 switch
					{
						0 => array[44] - 12403, 
						1 => char_[256] - 10846, 
						2 => 1, 
						3 => char_[178] - 7405, 
						4 => 1, 
						_ => 5, 
					};
					continue;
					end_IL_0089:
					break;
				}
				continue;
				end_IL_00b4:
				break;
			}
		}
	}
}
