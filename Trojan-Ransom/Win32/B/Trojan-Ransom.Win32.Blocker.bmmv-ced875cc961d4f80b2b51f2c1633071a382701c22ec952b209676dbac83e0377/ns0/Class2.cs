using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

namespace ns0;

internal sealed class Class2
{
	private sealed class Class3
	{
		public static readonly Class3 class3_0;

		private Class4.Class5.Class7 class7_0 = new Class4.Class5.Class7();

		[SecuritySafeCritical]
		static Class3()
		{
			byte[] byte_ = byte_1;
			byte[] byte_2 = Class1.byte_1;
			int num = 1;
			while (true)
			{
				Class8.smethod_6();
				int num2 = 5;
				num = byte_[85];
				while (true)
				{
					int num3;
					switch (num)
					{
					case 0:
						Class4.Class5.smethod_13();
						goto case 8;
					case 8:
						if (BabelAttribute.Class0.smethod_12(BabelAttribute.Class0.smethod_11(818, '\u032b'), new DateTime(635088607163926425L), 726, 730))
						{
							num = 2;
							goto case 2;
						}
						num = 3;
						goto case 3;
					case 2:
					case 5:
						num3 = 1;
						goto IL_0050;
					case 3:
						num3 = 2;
						goto IL_0050;
					case 7:
					case 10:
						switch (num2)
						{
						case 5:
							break;
						case 3:
							goto IL_0056;
						default:
							goto IL_0078;
						case 0:
							goto IL_0082;
						case 4:
							goto IL_008c;
						case 1:
							goto IL_00e0;
						case 2:
							goto IL_00e5;
						}
						num = 0;
						goto case 0;
					case 4:
						class3_0 = new Class3();
						num = 6;
						return;
					case 11:
						throw new Exception();
					case 6:
						return;
						IL_0078:
						num = byte_[64] - 74;
						continue;
						IL_0056:
						num = 8;
						goto case 8;
						IL_0050:
						num2 = num3;
						num = 10;
						goto case 7;
						IL_00e5:
						num = 4;
						goto case 4;
						IL_00e0:
						num = 11;
						goto case 11;
						IL_008c:
						num = byte_2[241] - byte_2[314];
						continue;
						IL_0082:
						num = byte_2[165];
						continue;
					}
					break;
				}
			}
		}

		private Class3()
		{
			object obj = BabelAttribute.smethod_15(487, 'ƅ');
			object obj2 = Class4.Class5.Class6.smethod_9(((ICustomAttributeProvider)obj) as Assembly, smethod_1(), '\u035d', 770);
			if ((Stream)obj2 != null)
			{
				object obj3 = new byte[256];
				class7_0.byte_0 = (byte[])obj3;
				Class9.smethod_14(obj2 as Stream, class7_0.byte_0, 0, class7_0.byte_0.Length, 470, 469);
			}
			Class4.Class5.Class6.smethod_4();
			Class9.Class11.smethod_9();
		}

		public string method_0(string string_0, int int_0)
		{
			byte[] byte_ = byte_1;
			byte[] byte_2 = Class1.byte_1;
			object obj = default(object);
			int num4 = default(int);
			while (true)
			{
				object byte_3 = byte_0;
				int num = 11;
				while (true)
				{
					int num2 = Class4.Class5.smethod_17(string_0, 569, 573);
					int num3 = 11;
					num = 14;
					while (true)
					{
						IL_0212:
						num = byte_2[168] - 29;
						while (true)
						{
							switch (num)
							{
							case 17:
								break;
							case 12:
							case 16:
								goto IL_002b;
							case 15:
								num3 = (byte_3 as byte[])[162] - ((byte[])byte_3)[49];
								num = byte_2[276] - 103;
								continue;
							case 9:
							case 14:
								goto IL_0072;
							case 1:
								goto IL_00d5;
							case 6:
								goto IL_00ee;
							case 2:
								goto IL_0117;
							case 13:
								goto IL_0159;
							case 10:
								obj = BabelAttribute.Class0.smethod_13(string_0, 243, 'È');
								num3 = 6;
								goto case 8;
							case 8:
								num = 14;
								goto IL_0072;
							default:
								num = byte_[63] - byte_[9];
								continue;
							case 4:
								((char[])obj)[num2] = (char)(((char[])obj)[num2] ^ (class7_0.byte_0[num4] | int_0));
								num = byte_[87] - 73;
								continue;
							case 3:
								goto IL_01b7;
							case 11:
								goto end_IL_01bf;
							case 0:
								goto end_IL_0227;
							case 7:
								return Class9.smethod_17(new string((char[])obj), 46, 27);
							}
							goto IL_0011;
							IL_01b7:
							num3 = 10;
							num = 14;
							goto IL_0149;
							IL_0159:
							int num5 = 3;
							goto IL_001d;
							IL_0072:
							switch (num3)
							{
							case 0:
								goto IL_00b0;
							case 1:
								goto IL_00c0;
							case 2:
								goto IL_00cf;
							case 3:
								goto IL_00d3;
							case 4:
								goto IL_00dc;
							case 5:
								goto IL_00ec;
							case 6:
								goto IL_0115;
							case 8:
								goto IL_013c;
							case 10:
								goto IL_0149;
							case 11:
								goto IL_0212;
							case 7:
								goto IL_021f;
							case 9:
								goto IL_0224;
							}
							num = 16;
							goto IL_002b;
							IL_0224:
							num = 11;
							break;
							IL_021f:
							num = 11;
							break;
							IL_0149:
							num = byte_[133] - 237;
							continue;
							IL_0115:
							num = 2;
							goto IL_0117;
							IL_0117:
							if (--num2 < 0)
							{
								num = 17;
								goto IL_0011;
							}
							num = byte_[146] - 163;
							continue;
							IL_0011:
							num5 = (byte_3 as byte[])[1] - 105;
							goto IL_001d;
							IL_001d:
							num3 = num5;
							num = byte_2[96] - 65;
							continue;
							IL_00ec:
							num = 6;
							goto IL_00ee;
							IL_00ee:
							num4 = int_0 & 0xFF;
							num3 = ((byte[])byte_3)[124];
							num = byte_2[207] - 175;
							continue;
							IL_00dc:
							num = byte_2[99] - 184;
							continue;
							IL_00d3:
							num = 1;
							goto IL_00d5;
							IL_00cf:
							num = 1;
							goto IL_00d5;
							IL_00d5:
							num3 = 8;
							num = 14;
							goto IL_013c;
							IL_013c:
							num = byte_[190] - 61;
							continue;
							IL_00c0:
							num = byte_[2] - 228;
							continue;
							IL_00b0:
							num = byte_2[134] - 25;
							continue;
							IL_002b:
							num3 = (byte_3 as byte[])[421] - 238;
							num = byte_[106];
							continue;
							end_IL_01bf:
							break;
						}
						break;
					}
					continue;
					end_IL_0227:
					break;
				}
			}
		}
	}

	internal static Struct1 struct1_0/* Not supported: data(DD 6A 87 61 31 0D 53 C0 1F 9A 9B CE 9D 7C F4 5D 0C 03 CD B1 EA 45 07 5F 27 8D 9C 36 33 F1 67 49 6B 7E 3A 2B 8A 8F B9 78 82 95 63 82 B3 3C D3 41 06 A4 48 0E 4B FD 5C 98 62 28 39 A2 70 1C 8C 2D 32 51 63 1E 42 C8 D1 7B 49 54 2F 55 E0 84 AA EA B9 5B 30 8E A8 58 FD 6C 21 A1 C8 62 55 16 08 65 08 36 4F 62 D7 B4 FE 3D D2 CC C4 F5 CD 06 B6 DD 7C 4E E8 15 EB FD 83 D9 52 F5 FC A0 00 6E 25 33 4B C8 4C AA 34 47 12 05 5B F2 BB DB 92 07 9D 1B E9 E9 E5 07 2D F2 79 0A B1 75 10 E1 B7 5E 3C 63 A6 91 AA 05 B9 0B A8 34 3B E2 B8 F7 41 A7 46 4A 57 E1 B5 15 88 1D 05 58 4F 41 F8 BE 37 30 4D FC B5 57 34 01 5C 98 60 DD 41 B0 CA 49 3A 80 C7 09 2E C4 89 D5 A7 27 D9 88 8B 52 B4 77 12 E9 FB 0B 95 BA 41 E8 73 44 ED BD 80 D6 D3 D7 52 BB 1D CD 78 EF 8F 72 A5 77 55 8D 7D AA 75 0A E3 E7 CB 57 B3 BF B3 7E 3F DE 95 E8 D6 CA 54 CF 53 02 36 CF 34 E5 FE 22 59 89 64 1E 65 B2 6B C7 CE E2 D9 97 0B 7B 23 92 07 9E 8E 99 59 A5 9B DA 22 84 3A 7A 73 A4 D5 FC E8 A9 FC 2A 5A 94 19 8B 72 CC 1A F2 EF BB C4 D6 DE A3 C7 94 57 64 C7 B2 ED 89 FA E0 78 EF 53 2A 0D DC AE 61 7D F8 37 72 85 03 26 8C 8B A7 E9 65 BF 62 9B CF DB 40 A4 84 E0 4A 3C CF 98 38 12 81 78 EE E5 13 0D 62 58 E4 6B 55 0F 53 3D 3B 26 45 9F 95 20 15 54 83 4D CB 37 2A 7F 33 BC 67 D8 4C EF A4 13 9C C1 D6 57 5C 09 B5 63 86 30 50 46 A5 24 F5 30 03 17 FB 2D F4 A1 19 DA E2 E2 25 28 04 7C C1 63 98 27 89 82 C8 3D C3 0C 9D 20 C6 9B E5 E2 D8 0F C5 37 D4 35 F2 77 1E F9 A8 FA 74 78 E3 8C 5F) */;

	internal static byte[] byte_0;

	internal static Struct4 struct4_0/* Not supported: data(55 86 E7 DC 17 5A 97 05 00 18 93 6A 4F 00 F6 79 74 5D CC 3A DE E9 36 9D E6 2C 7A EE D3 E7 CC 58 C6 E1 88 74 18 DE A9 1C FD E0 F0 22 71 3F AE B0 C1 AF F8 C1 9F 6D BC 6B 50 49 F5 E9 DE A7 30 18 4A 3A A3 6C 76 81 60 94 B2 B0 3C FD F8 13 2B A6 7C C9 2C 24 ED 0A B8 58 25 1D 23 CE E8 BE 3C 55 AF D8 D6 36 9B 41 39 40 4E 64 0E ED 31 BE 72 3C 1D 4E 6C 15 7A 0C 29 3F 81 4A 47 59 5D 91 AA F3 74 E5 4D 1F 3C F4 0B 3B 8F EB D4 88 FB CA 27 65 A9 E6 B0 9A 51 27 DA A3 AE 97 B4 50 F8 DF E1 BB B9 1A 78 4A 70 52 00 28 42 31 84 8D 36 9F 43 B6 23 E0 AE 76 E0 0F A1 4C 0B A9 70 A4 3F B9 41 AE 09 18 CE E0 51 DB F4 57 E5 87 57 20 A2 4C 6C 0E 53 FD 2D 18) */;

	internal static byte[] byte_1;

	public Class2()
	{
		Class4.Class5.smethod_7();
		Class9.Class10.smethod_5();
	}

	public static string smethod_0(string string_0, int int_0)
	{
		byte[] array = byte_1;
		byte[] array2 = Class1.byte_1;
		int num2 = default(int);
		while (true)
		{
			object obj = byte_0;
			Array array3 = Class1.byte_0;
			int num = array[20] - 214;
			while (true)
			{
				int num3;
				switch (num)
				{
				case 11:
					num3 = 4;
					goto IL_0012;
				case 9:
					num = (int)array2[165] / 4;
					continue;
				case 2:
				case 10:
					num3 = (array3 as byte[])[141] - 38;
					goto IL_0012;
				case 8:
					if (BabelAttribute.Class0.smethod_12(BabelAttribute.Class0.smethod_11(477, 'Ǆ'), new DateTime(635088607164527289L), 406, 410))
					{
						num = 2;
						goto case 2;
					}
					num = 11;
					goto case 11;
				case 1:
					switch (num2)
					{
					case 1:
						break;
					case 3:
						goto IL_0095;
					default:
						goto IL_00a6;
					case 0:
						goto IL_00ac;
					case 2:
						goto IL_00b0;
					case 5:
						goto IL_00bd;
					case 4:
						goto IL_011a;
					case 6:
						goto IL_011e;
					}
					num = 5;
					goto case 5;
				case 5:
					num2 = ((byte[])obj)[124];
					num = 1;
					goto case 1;
				default:
					num = 4;
					break;
				case 4:
					break;
				case 0:
					throw new Exception();
				case 7:
					{
						string result = Class9.smethod_17(Class3.class3_0.method_0(string_0, int_0), 127, 74);
						Class4.smethod_2();
						Class9.Class12.smethod_4();
						return result;
					}
					IL_011e:
					num = 0;
					goto case 0;
					IL_011a:
					num = 7;
					goto case 7;
					IL_00bd:
					num = array[100] - 147;
					continue;
					IL_00b0:
					num = array2[282] - 44;
					continue;
					IL_00ac:
					num = 8;
					goto case 8;
					IL_00a6:
					num = array[7];
					continue;
					IL_0095:
					num = 5;
					goto case 5;
					IL_0012:
					num2 = num3;
					goto case 9;
				}
				break;
			}
		}
	}

	[SpecialName]
	public static string smethod_1()
	{
		string result = Class4.Class5.Class6.smethod_7(1486502086, 6L, 2);
		BabelAttribute.Class0.smethod_7();
		Class9.Class11.smethod_5();
		return result;
	}
}
