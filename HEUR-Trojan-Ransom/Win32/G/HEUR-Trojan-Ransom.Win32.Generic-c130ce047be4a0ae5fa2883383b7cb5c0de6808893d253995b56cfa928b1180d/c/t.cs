using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace c;

internal sealed class t
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 562)]
	private struct m
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 478)]
	private struct j
	{
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct a
	{
		internal short[] o;
	}

	[CompilerGenerated]
	private readonly MemoryStream n;

	[CompilerGenerated]
	private readonly ICryptoTransform d;

	private e.i y = new e.i();

	private static readonly object r;

	private static readonly Array p;

	private static readonly object e;

	internal static m o/* Not supported: data(D3 42 D0 42 D3 42 FC 7C D3 45 06 6B B4 E0 B7 E0 B5 E0 62 C9 CA CF B0 F1 55 10 57 10 57 10 0D 3E A7 14 BC BE BE BE BF BE 90 80 B2 B9 B5 D1 B7 D1 B1 D1 CB FE B2 C0 17 94 15 94 12 94 E4 90 4B BF 1D 43 1C 43 1B 43 CF 6A DD E9 DF E9 DA E9 83 C7 24 ED FB D3 F9 D3 F3 D3 D3 ED F6 D4 2C 2D 2F 2D 25 2D F9 04 56 02 28 3C 49 60 4A 60 43 60 4B 71 13 4E B0 64 1D C0 1E C0 16 C0 E6 C4 4F EB 37 FE 88 F8 8B F8 84 F8 A1 C6 87 FF 5D D1 D5 F8 D6 F8 D8 F8 08 D1 A8 D7 D2 E9 33 34 30 34 3D 34 37 25 6B 1A C9 30 52 D5 51 D5 5D D5 AD D1 08 FE 7B EB 48 76 4B 76 58 76 63 48 44 71 9E 5F 99 B7 9A B7 88 B7 45 9E E0 98 9D A6 DD 71 DF 71 CF 71 86 5F 22 75 FE 72 BE 72 ED 72 4B 5B C1 5D 85 63 CA 5C 1E 76 FD 59 95 4C 86 75 28 5B D2 5D AF 63 CC 5C 78 76 D4 59 97 4C 96 75 60 5B C8 5D FF 63 B8 5C 55 76 AA 59 BE 4C B8 75 48 5B F1 5D 93 63 F6 5C 5E 76 BB 59 D2 4C 97 75 97 19 92 19 83 19 42 30 B5 36 D0 08 91 37 1A 1D EA 01 E0 01 FF 01 BE 2F 4F 05 EE 2A 98 3F A1 06 7C 28 C0 2E 89 10 A3 2F 0D 05 60 41 67 41 76 41 43 6E 34 50 7B 6F DF 45 7E 6A 1E 7F 36 46 2D 18 3C 18 3A 18 7B 33 58 26 70 1F A2 31 0D 37 4C 09 3D 36 83 1C 0D 33 55 26 7C 1F A5 31 00 37 6D 09 14 36 C6 1C 6A 33 DE EB D6 EB C6 EB D6 FA D2 C5 67 EF C0 C0 B1 D5 8A EC 4F C2 D2 C4 6B 39 63 39 72 39 36 3E F7 10 41 16 70 28 72 17 D7 3D 33 12 07 07 56 5F 51 5F 4C 5F 61 74 30 61 5F 58 C9 76 64 70 53 4E 44 71 59 E1 5D E1 42 E1 2E DF 0D E6 D9 C8 38 CE 32 38 24 38 2E 38 3C 13 5B 06 7F 3F A2 11 1C 17 69 29 3C 16 90 3C 0A 13 09 06 78 3F B3 11 19 17 66 29 3E 16 B1 3C 79 13 4E 06 64 3F B9 11 0F 17 50 29 5D 6B 53 6B 40 6B E4 6F 53 40 22 55 04 6C DC 42 5A 44 48 7A 5A 45 E1 6F 59 40 28 55 0E 6C D7 42 47 44 61 2D 67 2D 7F 2D 75 03 CB 29 7E 06 1B 13 3D 2A FE 04) */;

	private static readonly object l;

	private static readonly Array f;

	private static readonly Array y;

	internal static j i/* Not supported: data(95 DF 97 DF 95 DF 9B D8 40 F6 D8 0D DB 0D D9 0D A4 22 DB 1C 80 23 05 DA 07 DA 07 DA F8 DE 5A F1 7E B3 7D B3 7D B3 57 8D 74 B4 AB 9A EF 8B EE 8B EB 8B E9 9A 0E BA 0F BA 0B BA 20 84 49 32 4A 32 4F 32 9B 1B 3F 1D 4D 23 DD E0 DE E0 DA E0 DB F1 80 CE 24 E4 7E 35 7D 35 76 35 8D 31 24 1E 54 0B A0 33 A3 33 A9 33 8A 0D A9 34 76 1A 79 52 7B 52 73 52 01 7D 7B 43 F8 3F FA 3F F3 3F 06 3B A2 14 5F 19 55 19 53 19 5A 1E DE 30 62 36 1F 08 42 37 F8 1D 41 32 07 27 47 1E 97 30 07 B3 03 B3 0A B3 8F 9A 24 9C 47 A2 00 9D 44 F3 4C F3 4A F3 12 D8 31 CD 13 F4 C9 DA 78 DC 03 E2 48 DD D9 F7 C6 C6 C9 C6 C9 C6 92 E8 63 C2 C8 ED B6 F8 91 C1 76 EF F0 E9 96 D7 E4 E8 6E C2 C4 ED B1 F8 9C C1 57 EF D9 E9 E3 77 EE 77 F3 77 EF 59 50 73 ED 5C D6 49 AB 70 70 5E F3 58 A2 66 EF 59 46 73 F8 5C 8B 49 BA 70 7E 12 E0 12 6F 12 36 03 20 3C 81 16 76 39 06 2C 72 15 A2 3B 55 3D 7F 03 74 3C 82 16 77 39 01 2C 6B 15 A2 3B 03 3D 2A 03 75 3C 98 16 22 39 54 2C 77 15 AE 3B 1C 3D 7F 03 74 3C 84 16 71 39 48 2C 23 15 AC 3B 54 3D 2E 03 20 3C 87 16 74 39 03 2C 3D 15 C7 3B 4B 3D 10 03 3B 3C C6 16 6D 39 32 2C 22 15 EF 3B 00 3D 21 03 75 3C D9 16 61 39 57 2C 24 15 CF 3B 5D 3D 13 03 4D 3C F9 16 5B 39 32 2C 27 15 E9 3B 7B 3D 1C 03 73 3C E4 16 57 39 26 2C 0A 15 E9 3B 77 3D 26 03 74 3C 85 16 43 39 3D 2C 1C 15 EF 3B 00 3D 1F 03 4D 3C CC 16 43 39 2D 2C 22 15 E9 3B 67 3D 78 03 46 3C D2 16 62 39 1C 2C 1E 15 AF D1 A5 D1 BD D1 E4 FA 8E EF A4 D6 7B F8 D0 FE A8 C0 E6 FF 36 D5 96 FA F1 EF) */;

	public byte[] u
	{
		[CompilerGenerated]
		get
		{
			return this.y.w;
		}
	}

	public MemoryStream s
	{
		[CompilerGenerated]
		get
		{
			return n;
		}
	}

	public ICryptoTransform t
	{
		[CompilerGenerated]
		get
		{
			return d;
		}
	}

	public t(byte[] byte_0, MemoryStream memoryStream_0, ICryptoTransform icryptoTransform_0)
	{
		while (true)
		{
			int num = 1524129118;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA81D99u) % 4u)
				{
				case 3u:
					this.y.w = byte_0 as byte[];
					n = memoryStream_0;
					num = ((int)num2 * -1692916173) ^ -407126327;
					continue;
				case 1u:
					d = icryptoTransform_0;
					num = ((int)num2 * -1015451187) ^ -2118218566;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	static t()
	{
		int[] array = c.l.x;
		char[] array2 = c.e.e.k;
		int num = 11;
		Array array3 = default(Array);
		object obj = default(object);
		while (true)
		{
			int num2 = -1315683650;
			while (true)
			{
				uint num3;
				char[] array_;
				char[] array_2;
				switch ((num3 = (uint)num2 ^ 0xC0476606u) % 38u)
				{
				case 37u:
					num2 = ((int)num3 * -1803846445) ^ 0x2C043AE1;
					continue;
				case 36u:
					switch (num)
					{
					case 0:
						goto IL_006a;
					case 1:
						goto IL_0076;
					case 2:
						goto IL_008e;
					case 3:
						goto IL_00a6;
					case 6:
						goto IL_00ca;
					case 7:
						goto IL_00dc;
					case 8:
						goto IL_00f4;
					case 5:
					case 9:
						goto IL_010c;
					case 10:
						goto IL_0140;
					case 11:
						goto IL_0158;
					case 12:
						goto IL_017c;
					case 4:
						goto IL_0476;
					}
					num2 = -1022657498;
					continue;
				case 25u:
					goto IL_006a;
				case 5u:
					goto IL_0076;
				case 6u:
					goto IL_008e;
				case 3u:
					goto IL_00a6;
				case 18u:
					goto IL_00ca;
				case 14u:
					goto IL_00dc;
				case 1u:
					goto IL_00f4;
				case 31u:
					goto IL_010c;
				case 11u:
					goto IL_0140;
				case 2u:
					goto IL_0158;
				case 28u:
					goto IL_017c;
				case 35u:
					((char[])array3)[4] = '⽏';
					num2 = ((int)num3 * -818035863) ^ 0x7BE8B397;
					continue;
				case 32u:
					num2 = ((int)num3 * -533076005) ^ -1967201034;
					continue;
				case 30u:
					(array3 as char[])[6] = '\u0738';
					num = 1;
					num2 = (int)((num3 * 1907455589) ^ 0xAF650A4);
					continue;
				case 29u:
					((char[])obj)[7] = '㸛';
					num = 5;
					num2 = ((int)num3 * -1565396401) ^ -1495425217;
					continue;
				case 27u:
					num = 12;
					num2 = ((int)num3 * -55425953) ^ 0x5866AFCA;
					continue;
				case 26u:
					num = array[147] - 18357;
					num2 = ((int)num3 * -1401843141) ^ 0x7252F10D;
					continue;
				case 24u:
					num = array2[207] - 15901;
					num2 = ((int)num3 * -1509557774) ^ -793788326;
					continue;
				case 23u:
					e = new string[31];
					num2 = (int)(num3 * 105089544) ^ -1396361796;
					continue;
				case 22u:
					num = array[344] - 26233;
					num2 = ((int)num3 * -2137970201) ^ -1499243034;
					continue;
				case 21u:
					obj = new char[8];
					num2 = (int)((num3 * 1262564793) ^ 0x23AFED93);
					continue;
				case 20u:
					num2 = ((int)num3 * -564614814) ^ 0x2B55256E;
					continue;
				case 19u:
					num2 = (int)((num3 * 1115559595) ^ 0x1DEF37F9);
					continue;
				case 17u:
					num2 = ((int)num3 * -2110446633) ^ -1510470503;
					continue;
				case 16u:
					(obj as char[])[5] = '⧤';
					num2 = ((int)num3 * -615455297) ^ -498205658;
					continue;
				case 15u:
					((char[])array3)[5] = '⧤';
					num2 = ((int)num3 * -1875805396) ^ -1381817479;
					continue;
				case 13u:
					num2 = (int)(num3 * 199325599) ^ -2051062170;
					continue;
				case 12u:
					r = array3 as char[];
					num2 = (int)((num3 * 724255774) ^ 0x524FE19);
					continue;
				case 10u:
					num2 = (int)(num3 * 1901874083) ^ -867046504;
					continue;
				case 9u:
					num = 3;
					num2 = (int)(num3 * 885247546) ^ -1804780227;
					continue;
				case 8u:
					((char[])obj)[4] = '⽏';
					num2 = ((int)num3 * -1810444492) ^ -911177163;
					continue;
				case 4u:
					((char[])array3)[1] = 'Ӌ';
					num2 = (int)((num3 * 749030249) ^ 0x1CD587B6);
					continue;
				case 0u:
					num2 = (int)(num3 * 38147019) ^ -779119530;
					continue;
				default:
					return;
				case 7u:
					break;
				case 33u:
					return;
				case 34u:
					goto IL_0476;
					IL_0476:
					((char[])obj)[1] = 'Ӌ';
					y = new string[19];
					l = (char[])obj;
					return;
					IL_017c:
					((char[])obj)[3] = 'ᄵ';
					num2 = -356844496;
					continue;
					IL_0158:
					array_ = new char[281];
					c.t.smethod_8((Array)array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					p = array_;
					num2 = -357194218;
					continue;
					IL_0140:
					(obj as char[])[0] = '⭫';
					num2 = -2047923927;
					continue;
					IL_010c:
					(obj as char[])[2] = '\u2e69';
					((char[])obj)[6] = '\u0738';
					num = array[177] - 10699;
					num2 = -1315683650;
					continue;
					IL_00f4:
					(array3 as char[])[3] = 'ᄵ';
					num2 = -223639497;
					continue;
					IL_00dc:
					((char[])array3)[0] = '⭫';
					num2 = -1679443047;
					continue;
					IL_00ca:
					array3 = new char[8];
					num2 = -1735627770;
					continue;
					IL_00a6:
					array_2 = new char[239];
					c.t.smethod_8((Array)array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					f = array_2;
					num2 = -792876977;
					continue;
					IL_008e:
					((char[])array3)[2] = '\u2e69';
					num2 = -1268177257;
					continue;
					IL_0076:
					((char[])array3)[7] = '㸛';
					num2 = -860106196;
					continue;
					IL_006a:
					num = 7;
					num2 = -258977346;
					continue;
				}
				break;
			}
		}
	}

	internal static string h(int int_0, int int_1, char char_0)
	{
		int[] array = global::c.l.x;
		char[] array2 = global::c.e.e.k;
		int num7 = default(int);
		int num10 = default(int);
		IComparable comparable = default(IComparable);
		ISerializable serializable = default(ISerializable);
		char c = default(char);
		Array array3 = default(Array);
		int num8 = default(int);
		object obj5 = default(object);
		int num11 = default(int);
		int num9 = default(int);
		object obj = default(object);
		int num4 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = -1086219046;
			while (true)
			{
				uint num2;
				int num6;
				int num12;
				switch ((num2 = (uint)num ^ 0xA60972CDu) % 13u)
				{
				case 11u:
					num6 = array2[23] - 41789;
					goto IL_001b;
				case 10u:
					while (true)
					{
						switch (num3)
						{
						case 17:
							if (num7 > num10)
							{
								num3 = 7;
								goto case 7;
							}
							num3 = array2[211] - 21990;
							continue;
						case 7:
							comparable = global::c.t.smethod_2((object)(StringBuilder)serializable);
							((string[])e)[num5] = (string)comparable;
							num3 = array2[358] - 34878;
							continue;
						case 16:
							global::c.t.smethod_1((StringBuilder)serializable, (char)(c ^ (array3 as char[])[num8 + num10 - num7] ^ (obj5 as char[])[(num7 + num8 + 17) % num11]));
							num3 = array2[554] - 43448;
							continue;
						case 14:
							num8 += 3;
							num10 = (num9 & 0x1F) | ((num9 & 0xFFC0) >> 1);
							num3 = array[68] - 40588;
							continue;
						case 11:
						case 13:
							serializable = global::c.t.smethod_0();
							c = (array3 as char[])[num8];
							num9 = ((char[])array3)[num8 + 1] ^ c;
							num3 = 14;
							goto case 14;
						case 10:
							num11 = (obj5 as char[]).Length;
							num7 = 1;
							num3 = 17;
							goto case 17;
						case 8:
							if (((uint)num9 & 0x20u) != 0)
							{
								num3 = 2;
								goto case 2;
							}
							num3 = 10;
							goto case 10;
						case 2:
						case 5:
							num10 = (num10 << 15) | ((array3 as char[])[num8++] ^ c);
							num3 = 10;
							goto case 10;
						case 3:
						{
							char[] obj3 = (char[])obj;
							char[] obj4 = (char[])r;
							num8 = num4;
							obj5 = obj4;
							array3 = obj3;
							num3 = 11;
							goto case 11;
						}
						case 0:
							num7++;
							num3 = 17;
							goto case 17;
						case 1:
							goto IL_01d9;
						case 4:
							goto IL_01ee;
						case 15:
							goto IL_021c;
						case 9:
							return comparable as string;
						case 6:
						case 12:
							return comparable as string;
						}
						break;
					}
					num = -1886931809;
					continue;
				case 9u:
					goto IL_01d9;
				case 8u:
					goto IL_01ee;
				case 4u:
					goto IL_021c;
				case 7u:
					num = ((int)num2 * -2066805247) ^ 0x17A69E76;
					continue;
				default:
					num6 = 3;
					goto IL_001b;
				case 5u:
					num = ((int)num2 * -1594927662) ^ -1592125010;
					continue;
				case 3u:
				{
					obj = p;
					char[] obj2 = (char[])obj;
					num5 = obj2[num4];
					num5 = obj2[num4 + 2] ^ num5;
					num = (int)(num2 * 335685600) ^ -723156122;
					continue;
				}
				case 2u:
					num3 = array[275] - 4942;
					num = ((int)num2 * -289116950) ^ 0xE718357;
					continue;
				case 1u:
					num = (int)(num2 * 256891557) ^ -2008262827;
					continue;
				case 0u:
					num3 = array2[334] - 36535;
					num = ((int)num2 * -2105406202) ^ 0xC5D2DFC;
					continue;
				case 12u:
					break;
					IL_021c:
					num = -1449140920;
					continue;
					IL_01ee:
					if ((comparable = ((string[])e)[num5]) != null)
					{
						num = -1906226221;
						num12 = -1906226221;
					}
					else
					{
						num = -2084021560;
						num12 = -2084021560;
					}
					continue;
					IL_001b:
					num3 = num6;
					num = -1912920187;
					continue;
					IL_01d9:
					num4 = int_1 ^ 0x5A78B066 ^ int_0;
					num = -1504009228;
					continue;
				}
				break;
			}
		}
	}

	internal static string x(int int_0, int int_1, int int_2)
	{
		char[] array = global::c.e.e.k;
		IComparable<string> comparable = default(IComparable<string>);
		int num10 = default(int);
		int[] array2 = default(int[]);
		int num9 = default(int);
		object obj7 = default(object);
		char c = default(char);
		object obj6 = default(object);
		int num7 = default(int);
		object obj5 = default(object);
		int num11 = default(int);
		int num8 = default(int);
		object obj = default(object);
		int num3 = default(int);
		int num6 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -248369658;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xA21357CDu) % 14u)
				{
				case 13u:
				{
					int num13;
					if ((comparable = ((string[])y)[num4]) != null)
					{
						num = -1752030619;
						num13 = -1752030619;
					}
					else
					{
						num = -122995254;
						num13 = -122995254;
					}
					continue;
				}
				case 12u:
					while (true)
					{
						switch (num6)
						{
						case 7:
							break;
						case 16:
							num10++;
							num6 = array2[327] - 44517;
							continue;
						case 14:
							if (num10 <= num9)
							{
								num6 = 11;
								goto case 11;
							}
							num6 = 12;
							goto case 12;
						case 11:
						{
							global::c.t.smethod_1((StringBuilder)obj7, (char)(c ^ ((char[])obj6)[num7 + num9 - num10] ^ (obj5 as char[])[(num10 + num7 + 17) % num11]));
							char num12 = array[17];
							global::c.l.x[145] = (global::c.l.x[145] * global::c.e.e.k[14]) & 0x6D;
							num6 = num12 - 10431;
							continue;
						}
						case 13:
							num6 = array[338] - 17328;
							continue;
						case 9:
							num9 = (num9 << 15) | (((char[])obj6)[num7++] ^ c);
							num6 = 8;
							goto case 8;
						case 8:
							num11 = (obj5 as char[]).Length;
							num10 = 1;
							num6 = 14;
							goto case 14;
						case 5:
							if (((uint)num8 & 0x20u) != 0)
							{
								num6 = 9;
								goto case 9;
							}
							num6 = 8;
							goto case 8;
						case 4:
						{
							char[] obj3 = (char[])obj;
							char[] obj4 = (char[])l;
							num7 = num3;
							obj5 = obj4;
							obj6 = obj3;
							num6 = 1;
							goto case 1;
						}
						case 1:
							obj7 = global::c.t.smethod_0();
							c = ((char[])obj6)[num7];
							num8 = ((char[])obj6)[num7 + 1] ^ c;
							goto case 13;
						case 2:
							num7 += 3;
							num9 = (num8 & 0x1F) | ((num8 & 0xFFC0) >> 1);
							num6 = 5;
							goto case 5;
						default:
							goto IL_01d2;
						case 3:
							goto IL_01dc;
						case 6:
						case 15:
							goto IL_01f0;
						case 12:
							comparable = global::c.t.smethod_2((object)(StringBuilder)obj7);
							((string[])y)[num4] = comparable as string;
							num6 = 0;
							goto case 0;
						case 0:
						case 10:
							return comparable as string;
						case 17:
							return (string)comparable;
						}
						break;
					}
					goto case 13u;
				case 6u:
					goto IL_01dc;
				case 1u:
					goto IL_01f0;
				case 10u:
					num6 = 3;
					num = (int)(num2 * 221676069) ^ -1060932291;
					continue;
				case 9u:
					num = (int)(num2 * 1363443749) ^ -568750898;
					continue;
				case 8u:
					obj = f;
					num = ((int)num2 * -65892799) ^ 0x45EA9285;
					continue;
				default:
					num5 = array[594] - 21638;
					goto IL_0243;
				case 5u:
					num = ((int)num2 * -1003398444) ^ -137934937;
					continue;
				case 4u:
					num6 = 7;
					num = ((int)num2 * -573383431) ^ -1211737848;
					continue;
				case 3u:
					array2 = global::c.l.x;
					num = ((int)num2 * -1750755811) ^ -1070022881;
					continue;
				case 2u:
					num5 = array[474] - 30902;
					goto IL_0243;
				case 0u:
				{
					char[] obj2 = (char[])obj;
					num4 = obj2[num3];
					num4 = obj2[num3 + 2] ^ num4;
					num = (int)((num2 * 298251293) ^ 0x6D0D8A3B);
					continue;
				}
				case 11u:
					break;
					IL_0243:
					num6 = num5;
					num = -1813802773;
					continue;
					IL_01f0:
					num = -578224045;
					continue;
					IL_01dc:
					num3 = int_1 ^ 0x197AA080 ^ int_2;
					num = -1516464879;
					continue;
					IL_01d2:
					num = -1509714118;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Rijndael b(int int_0, short short_0)
	{
		char[] array = c.e.e.k;
		int num5 = default(int);
		int num6 = default(int);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		int num4 = default(int);
		while (true)
		{
			int num = -992447086;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xB1C9BE1Eu) % 10u)
				{
				default:
					num3 = 4;
					goto IL_000c;
				case 8u:
					num = (int)(num2 * 1927202869) ^ -145185849;
					continue;
				case 7u:
					num4 = 11;
					num = (int)(num2 * 1097887895) ^ -1618545360;
					continue;
				case 5u:
					num = -760623245;
					continue;
				case 4u:
					goto IL_0048;
				case 3u:
					goto IL_0063;
				case 2u:
					num = ((int)num2 * -1952108144) ^ -564003485;
					continue;
				case 1u:
					while (true)
					{
						switch (num4)
						{
						case 0:
							break;
						case 1:
						case 8:
							goto IL_0048;
						case 11:
							goto IL_0063;
						case 10:
							num5++;
							num6 = 16;
							goto case 7;
						case 7:
							if (3528 <= 504 - num6 * 7)
							{
								num4 = array[362] - 63208;
								continue;
							}
							num4 = 2;
							goto case 2;
						case 3:
						case 9:
							num4 = array[318] - 21036;
							continue;
						case 6:
							symmetricAlgorithm = null;
							num4 = 10;
							goto case 10;
						case 4:
							symmetricAlgorithm = c.t.smethod_3();
							num4 = 10;
							goto case 10;
						default:
							goto IL_0115;
						case 5:
							num4 = 8;
							goto IL_0048;
						case 2:
							return symmetricAlgorithm as Rijndael;
						}
						break;
					}
					goto case 5u;
				case 0u:
					num3 = array[144] - 35049;
					goto IL_000c;
				case 6u:
					break;
					IL_0115:
					num = -203535017;
					continue;
					IL_0063:
					num5 = 0;
					num4 = array[508] - 25433;
					num = -749996974;
					continue;
					IL_0048:
					switch (((short_0 ^ int_0) - 77) ^ num5)
					{
					case 0:
						break;
					default:
						num = -878028056;
						continue;
					}
					goto default;
					IL_000c:
					num4 = num3;
					num = -2085330309;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void k<T>(T gparam_0, short short_0, int int_0) where T : Form
	{
		char[] array = c.e.e.k;
		int[] array2 = c.l.x;
		int num5 = default(int);
		int num6 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 1224573227;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x55990C5Fu) % 10u)
				{
				default:
					num3 = array2[37] - 64399;
					goto IL_001b;
				case 8u:
					num4 = 8;
					num = (int)((num2 * 694656617) ^ 0x692A3BA8);
					continue;
				case 7u:
					num5 = 0;
					num = 262809941;
					continue;
				case 6u:
					num4 = 7;
					num = (int)((num2 * 325006012) ^ 0x63CB1966);
					continue;
				case 5u:
					while (true)
					{
						switch (num4)
						{
						case 7:
							break;
						case 9:
							if (num6 % 2 != 0)
							{
								num4 = array[12] - 15438;
								continue;
							}
							num4 = 3;
							return;
						case 2:
						case 6:
							c.t.smethod_4((Form)(object)gparam_0);
							goto case 0;
						case 0:
							num5++;
							num6 = short_0 * short_0;
							num6 = short_0 + num6;
							goto case 5;
						case 5:
							num4 = 9;
							goto case 9;
						case 4:
							num4 = 0;
							goto case 0;
						default:
							goto IL_00c4;
						case 8:
							goto IL_00cb;
						case 1:
						case 3:
							return;
						}
						break;
					}
					goto case 7u;
				case 4u:
					goto IL_00cb;
				case 3u:
					num = (int)(num2 * 377081017) ^ -34492141;
					continue;
				case 2u:
					num = (int)((num2 * 555790627) ^ 0x352BAC04);
					continue;
				case 1u:
					num3 = array[122] - 43662;
					goto IL_001b;
				case 0u:
					break;
					IL_00cb:
					switch (((short_0 ^ int_0) - 97) ^ num5)
					{
					case 0:
						break;
					default:
						num = 1931471436;
						continue;
					}
					goto default;
					IL_00c4:
					num = 1349690098;
					continue;
					IL_001b:
					num4 = num3;
					num = 1282777305;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void q<T>(T gparam_0, AutoScaleMode autoScaleMode_0, char char_0, short short_0) where T : ContainerControl
	{
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		char[] array = c.e.e.k;
		int[] array2 = c.l.x;
		int num = 2;
		int num4 = default(int);
		while (true)
		{
			int num2 = -670738135;
			while (true)
			{
				uint num3;
				int num6;
				switch ((num3 = (uint)num2 ^ 0x92648918u) % 8u)
				{
				case 7u:
					num4 = 0;
					num2 = -455637068;
					continue;
				case 5u:
					num6 = array[231] - 59619;
					goto IL_002d;
				case 4u:
					num = 5;
					num2 = (int)(num3 * 2138540317) ^ -2000947977;
					continue;
				case 3u:
					num2 = ((int)num3 * -880032196) ^ -315036323;
					continue;
				case 2u:
					goto IL_005b;
				default:
					num6 = 6;
					goto IL_002d;
				case 1u:
					while (true)
					{
						switch (num)
						{
						case 1:
						case 2:
							break;
						case 5:
							goto IL_005b;
						case 0:
						{
							int num5 = array2[349];
							c.e.e.k[235] = (char)((c.e.e.k[235] + short_0) & '³');
							num = num5 - 45809;
							continue;
						}
						default:
							goto IL_00d1;
						case 3:
							num = 4;
							goto case 4;
						case 6:
							c.t.smethod_5((ContainerControl)(object)gparam_0, autoScaleMode_0);
							goto case 4;
						case 4:
							num4++;
							num = 9;
							return;
						case 7:
						case 8:
						case 9:
							return;
						}
						break;
					}
					goto case 7u;
				case 6u:
					break;
					IL_00d1:
					num2 = -806081897;
					continue;
					IL_005b:
					switch (((char_0 ^ short_0) - 12) ^ num4)
					{
					default:
						num2 = -1261948691;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_002d:
					num = num6;
					num2 = -670738135;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string z<T>(T gparam_0, int int_0, int int_1, char char_0) where T : string
	{
		char[] array = c.e.e.k;
		object obj = default(object);
		int num5 = default(int);
		int num6 = default(int);
		int[] array2 = default(int[]);
		int num4 = default(int);
		while (true)
		{
			int num = -77241977;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x930E39DEu) % 12u)
				{
				case 11u:
					num = -426433387;
					continue;
				case 10u:
					while (true)
					{
						switch (num4)
						{
						case 0:
							break;
						case 11:
							obj = null;
							num4 = 3;
							goto case 3;
						case 3:
							num5++;
							num6 = char_0 * char_0;
							goto case 10;
						case 10:
							num6 = char_0 + num6;
							num4 = 8;
							goto case 7;
						case 7:
						case 8:
							if (num6 % 2 == 0)
							{
								num4 = array2[163] - 26064;
								continue;
							}
							num4 = 4;
							goto IL_00a6;
						case 2:
						case 9:
							obj = c.t.smethod_6((string)gparam_0, int_0);
							num4 = 3;
							goto case 3;
						default:
							goto IL_008a;
						case 1:
							num4 = 4;
							goto IL_00a6;
						case 6:
							goto IL_0098;
						case 4:
							goto IL_00a6;
						case 5:
							return (string)obj;
						}
						break;
					}
					goto case 11u;
				case 5u:
					goto IL_0098;
				case 3u:
					goto IL_00a6;
				default:
					num3 = array[564] - 32749;
					goto IL_00cb;
				case 8u:
					num4 = array[593] - 28947;
					num = ((int)num2 * -1334154610) ^ -1746010466;
					continue;
				case 7u:
					num4 = 6;
					num = ((int)num2 * -460306823) ^ -1801669755;
					continue;
				case 6u:
					num3 = 11;
					goto IL_00cb;
				case 4u:
					num = (int)(num2 * 1333445208) ^ -1123639952;
					continue;
				case 1u:
					array2 = c.l.x;
					num = (int)((num2 * 424383608) ^ 0x42DB05B7);
					continue;
				case 0u:
					num = ((int)num2 * -1896378394) ^ -1467246784;
					continue;
				case 9u:
					break;
					IL_0098:
					num5 = 0;
					num = -1592441294;
					continue;
					IL_008a:
					num = -547720051;
					continue;
					IL_00a6:
					switch (((int_1 ^ char_0) - 46) ^ num5)
					{
					default:
						num = -1954576508;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_00cb:
					num4 = num3;
					num = -950743888;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string dg<T>(T gparam_0, int int_0, int int_1, char char_0, char char_1) where T : string
	{
		int[] array = c.l.x;
		IComparable<string> comparable = default(IComparable<string>);
		char[] array2 = default(char[]);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1671439690;
			while (true)
			{
				uint num2;
				int num4;
				int num6;
				int num7;
				switch ((num2 = (uint)num ^ 0x173B555Cu) % 11u)
				{
				case 10u:
					num3 = 10;
					num = (int)((num2 * 579215229) ^ 0x1F558382);
					continue;
				case 9u:
					num = 1093273039;
					continue;
				default:
					num4 = 7;
					goto IL_002b;
				case 7u:
					while (true)
					{
						switch (num3)
						{
						case 2:
							break;
						case 8:
							comparable = null;
							num3 = array[23] - 19443;
							continue;
						case 5:
							num3 = array2[336] - 54700;
							continue;
						default:
							goto IL_0087;
						case 0:
							goto IL_0091;
						case 10:
							goto IL_009a;
						case 1:
						case 7:
							comparable = c.t.smethod_7((string)gparam_0, int_0, int_1);
							num3 = 4;
							goto case 4;
						case 4:
							num5++;
							num3 = 9;
							goto case 3;
						case 3:
						case 6:
						case 9:
							return comparable as string;
						}
						break;
					}
					goto case 9u;
				case 3u:
					goto IL_0091;
				case 5u:
					goto IL_009a;
				case 4u:
					num4 = array[314] - 6030;
					goto IL_002b;
				case 2u:
					num3 = 0;
					num = (int)((num2 * 1284444239) ^ 0x4178882E);
					continue;
				case 1u:
					array2 = c.e.e.k;
					num = (int)((num2 * 1572779073) ^ 0x7BE9D807);
					continue;
				case 0u:
					num = (int)(num2 * 1168730688) ^ -1869552205;
					continue;
				case 6u:
					break;
					IL_009a:
					num6 = (char_0 ^ char_1) - 80;
					num7 = num5;
					c.l.x[284] = (c.l.x[284] * int_1) & 0xE9;
					switch (num6 ^ num7)
					{
					case 0:
						break;
					default:
						num = 1002769679;
						continue;
					}
					goto default;
					IL_0091:
					num5 = 0;
					num = 686166745;
					continue;
					IL_0087:
					num = 396837800;
					continue;
					IL_002b:
					num3 = num4;
					num = 533117975;
					continue;
				}
				break;
			}
		}
	}

	static StringBuilder smethod_0()
	{
		return new StringBuilder();
	}

	static StringBuilder smethod_1(StringBuilder stringBuilder_0, char char_0)
	{
		return stringBuilder_0.Append(char_0);
	}

	static string smethod_2(object object_0)
	{
		return object_0.ToString();
	}

	static Rijndael smethod_3()
	{
		return Rijndael.Create();
	}

	static void smethod_4(Form form_0)
	{
		Application.Run(form_0);
	}

	static void smethod_5(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static string smethod_6(string string_0, int int_0)
	{
		return string_0.Substring(int_0);
	}

	static string smethod_7(string string_0, int int_0, int int_1)
	{
		return string_0.Substring(int_0, int_1);
	}

	static void smethod_8(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}
}
