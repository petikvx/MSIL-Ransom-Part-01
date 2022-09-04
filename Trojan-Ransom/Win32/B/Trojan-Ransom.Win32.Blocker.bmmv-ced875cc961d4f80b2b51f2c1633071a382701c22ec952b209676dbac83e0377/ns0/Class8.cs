using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace ns0;

internal sealed class Class8
{
	private static bool bool_0;

	[SecuritySafeCritical]
	static Class8()
	{
		smethod_6();
	}

	[SecuritySafeCritical]
	internal static object smethod_0()
	{
		smethod_8(105, 66).SetData(Class9.Class12.smethod_8(8, 1319696999, null), null);
		return null;
	}

	internal static void smethod_1()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		int num = 2;
		while (true)
		{
			int num2 = 961;
			int num3 = 923521;
			while (true)
			{
				num3 = num2 + num3;
				num = 0;
				while (true)
				{
					switch ((num3 % 2 == 0) ? byte_[13] : (byte_2[123] - 85))
					{
					case 0:
					case 1:
						break;
					case 5:
						goto end_IL_0042;
					default:
						goto end_IL_0049;
					case 3:
						smethod_1();
						goto case 4;
					case 4:
						Class2.byte_1[77] = (byte)((Class2.byte_1[77] + Class2.byte_1[56]) & 0xB5);
						return;
					case 6:
						return;
					}
					continue;
					end_IL_0042:
					break;
				}
				continue;
				end_IL_0049:
				break;
			}
		}
	}

	internal static string smethod_2()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		while (true)
		{
			int num = byte_2[75] - byte_2[140];
			while (true)
			{
				switch (num)
				{
				default:
					goto IL_000e;
				case 3:
					break;
				case 2:
				case 5:
				case 6:
					smethod_2();
					num = 1;
					goto case 1;
				case 1:
					return null;
				}
				break;
				IL_000e:
				num = byte_[13];
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type smethod_3()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		while (true)
		{
			int num = 0;
			Array array = (byte[])Class9.Class12.smethod_9(smethod_8(487, 459), Class9.Class12.smethod_8(2, 1319697005, null), 375, 'Ī');
			int num2 = (int)byte_[3] / 3;
			while (true)
			{
				switch (num2)
				{
				case 21:
				case 29:
					num2 = ((((byte[])array)[num] < 65) ? ((int)byte_[192] / 2) : (byte_2[209] - 225));
					continue;
				case 28:
					if (65 != ((byte[])array)[num])
					{
						num2 = (int)byte_[286] / 3;
						continue;
					}
					num2 = 23;
					goto case 23;
				case 23:
					num++;
					num2 = byte_[168] - 33;
					continue;
				case 19:
				case 27:
					if (8 != ((byte[])array)[num])
					{
						num2 = 25;
						goto case 25;
					}
					num2 = 20;
					goto case 20;
				case 25:
					smethod_1();
					goto case 20;
				case 20:
					num++;
					num2 = 11;
					goto case 11;
				case 11:
					if (((byte[])array)[num] >= 208)
					{
						num2 = 24;
						goto case 24;
					}
					num2 = 0;
					goto case 0;
				case 24:
					if (208 != ((byte[])array)[num])
					{
						num2 = 4;
						goto case 4;
					}
					num2 = 15;
					goto case 15;
				case 4:
					Class9.smethod_4();
					num2 = 15;
					goto case 15;
				case 15:
					num++;
					num2 = (int)byte_2[125] / 5;
					continue;
				case 18:
					if (((byte[])array)[num] >= 145)
					{
						num2 = 17;
						goto case 17;
					}
					num2 = 14;
					goto case 14;
				case 17:
					if (145 == (array as byte[])[num])
					{
						num2 = byte_[19];
						continue;
					}
					num2 = 12;
					goto case 12;
				case 13:
					Class9.smethod_0();
					num2 = byte_2[160] - 162;
					continue;
				case 10:
					num++;
					num2 = byte_2[19] - 40;
					continue;
				case 9:
					if (((byte[])array)[num] >= 8)
					{
						num2 = 27;
						goto case 19;
					}
					num2 = byte_[175] - 131;
					continue;
				case 7:
					Class9.Class10.smethod_4();
					num2 = 10;
					goto case 10;
				case 5:
					num2 = ((196 == ((byte[])array)[num]) ? byte_[122] : (byte_2[101] - byte_2[19]));
					continue;
				case 2:
					num2 = ((((byte[])array)[num] < 196) ? (byte_[226] + 16) : (byte_[123] - 177));
					continue;
				default:
					num2 = 1;
					break;
				case 1:
					break;
				case 6:
					return typeof(Attribute0);
				case 8:
					return typeof(BabelAttribute);
				case 12:
					Class9.Class11.smethod_0();
					num2 = 16;
					goto case 16;
				case 16:
					num++;
					return typeof(Class4.Class5.Class7);
				case 14:
					return typeof(Struct5);
				case 26:
					return typeof(BabelAttribute);
				case 0:
					return typeof(Class4.Class5.Class6);
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long smethod_4()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		while (true)
		{
			int num = 0;
			object obj = (byte[])Class9.Class12.smethod_9(smethod_8(37, 8), Class9.Class12.smethod_8(4, 1319697003, null), 856, '\u0306');
			int num2 = 0;
			while (true)
			{
				IL_02fb:
				if (((byte[])obj)[num] < 8)
				{
					num2 = byte_[139];
					goto IL_024b;
				}
				num2 = 31;
				goto IL_0139;
				IL_0139:
				if (8 != (obj as byte[])[num])
				{
					num2 = byte_[241] - byte_[21];
					goto IL_024b;
				}
				num2 = 11;
				goto IL_015a;
				IL_015a:
				num++;
				num2 = byte_[232] - 33;
				goto IL_024b;
				IL_024b:
				while (true)
				{
					switch (num2)
					{
					case 39:
						break;
					case 21:
					case 38:
						Class9.smethod_3();
						goto case 17;
					case 17:
						num++;
						num2 = 37;
						goto case 37;
					case 37:
						if ((obj as byte[])[num] >= 196)
						{
							num2 = 35;
							goto case 35;
						}
						num2 = 18;
						goto case 18;
					case 35:
						if (196 != ((byte[])obj)[num])
						{
							num2 = byte_2[30] - 171;
							continue;
						}
						num2 = 6;
						goto case 6;
					case 36:
						goto IL_0091;
					case 34:
						if (65 != (obj as byte[])[num])
						{
							num2 = 12;
							goto case 12;
						}
						num2 = 27;
						goto case 27;
					case 12:
						Class9.smethod_4();
						num2 = 27;
						goto case 27;
					case 27:
						num++;
						num2 = 26;
						goto case 26;
					case 26:
						num2 = (((obj as byte[])[num] < 196) ? (byte_[258] - 71) : (byte_2[38] - byte_2[10]));
						continue;
					case 32:
						smethod_1();
						goto case 15;
					case 15:
						num++;
						num2 = 4;
						goto case 4;
					case 4:
						if ((obj as byte[])[num] >= 65)
						{
							num2 = byte_2[129] - 195;
							continue;
						}
						num2 = 29;
						goto case 29;
					case 31:
						goto end_IL_024b;
					case 11:
						goto IL_015a;
					case 30:
						if (160 != (obj as byte[])[num])
						{
							num2 = byte_[52] - 151;
							continue;
						}
						num2 = 17;
						goto case 17;
					case 28:
						num++;
						num2 = 5;
						goto case 5;
					case 5:
					case 25:
						if (((byte[])obj)[num] >= 160)
						{
							num2 = 30;
							goto case 30;
						}
						num2 = 9;
						goto case 9;
					case 22:
						goto IL_01b8;
					case 13:
						if ((obj as byte[])[num] >= 145)
						{
							num2 = 2;
							goto case 2;
						}
						num2 = 20;
						goto case 20;
					case 2:
						if (145 != (obj as byte[])[num])
						{
							num2 = byte_[13];
							continue;
						}
						num2 = 28;
						goto case 28;
					case 8:
						Class9.smethod_3();
						goto IL_015a;
					case 7:
						smethod_0();
						num2 = byte_2[38] - 168;
						continue;
					case 3:
						smethod_1();
						goto case 28;
					case 1:
						num++;
						num2 = byte_[39] - 85;
						continue;
					case 0:
					case 16:
						goto IL_02fb;
					default:
						num2 = 24;
						goto end_IL_02fb;
					case 24:
						goto end_IL_02fb;
					case 14:
						return 0L;
					case 19:
						return 5L;
					case 20:
						return 9L;
					case 23:
						return 11L;
					case 9:
						return 8L;
					case 29:
						return 9L;
					case 33:
						Class9.smethod_1();
						num2 = 6;
						goto case 6;
					case 6:
						num++;
						return 8L;
					case 18:
						return 1L;
					}
					goto IL_001e;
					IL_01b8:
					num2 = ((196 == (obj as byte[])[num]) ? (byte_2[161] - 25) : (byte_[188] - 223));
					continue;
					IL_0091:
					if (((byte[])obj)[num] >= 208)
					{
						num2 = 39;
						goto IL_001e;
					}
					num2 = byte_2[106];
					continue;
					IL_001e:
					num2 = ((208 == ((byte[])obj)[num]) ? (byte_[177] - 118) : (byte_[19] * 2));
					continue;
					end_IL_024b:
					break;
				}
				goto IL_0139;
				continue;
				end_IL_02fb:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_5()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		while (true)
		{
			int num = 0;
			object obj = (byte[])Class9.Class12.smethod_9(smethod_8(230, 200), Class9.Class12.smethod_8(2, 1319697005, null), 560, 'ɯ');
			int num2 = 7;
			while (true)
			{
				if ((obj as byte[])[num] >= 8)
				{
					num2 = 2;
					while (true)
					{
						IL_0173:
						if (8 == ((byte[])obj)[num])
						{
							num2 = 1;
							goto IL_015b;
						}
						num2 = 3;
						goto IL_0152;
						IL_015b:
						while (true)
						{
							IL_015b_2:
							num++;
							num2 = byte_[273] - byte_[4];
							while (true)
							{
								switch (num2)
								{
								case 18:
									if ((obj as byte[])[num] >= 65)
									{
										num2 = byte_[192];
										continue;
									}
									num2 = 16;
									goto case 16;
								case 12:
									if (65 != (obj as byte[])[num])
									{
										num2 = byte_[25] - 169;
										continue;
									}
									num2 = 13;
									goto case 13;
								default:
									num2 = byte_[71] - 173;
									continue;
								case 10:
									Class9.Class11.smethod_0();
									num2 = 6;
									goto case 6;
								case 6:
									num++;
									num2 = 18;
									goto case 18;
								case 5:
									break;
								case 0:
								case 4:
									goto IL_00d0;
								case 3:
									goto end_IL_00f6;
								case 1:
									goto IL_015b_2;
								case 2:
									goto IL_0173;
								case 7:
								case 9:
									goto end_IL_0173;
								case 14:
								case 17:
									goto end_IL_0183;
								case 8:
									return 5;
								case 15:
									smethod_1();
									goto case 13;
								case 13:
									num++;
									return 0;
								case 16:
									return 14;
								case 19:
									goto IL_01e8;
								}
								if ((obj as byte[])[num] >= 208)
								{
									byte num3 = byte_2[175];
									Class1.byte_1[1] = (byte)((Class1.byte_1[1] - Class1.byte_1[235]) & 0xDC);
									num2 = num3 - 182;
								}
								else
								{
									num2 = byte_2[75] - 245;
								}
								continue;
								IL_00d0:
								num2 = ((208 == ((byte[])obj)[num]) ? (byte_[191] - 215) : byte_[122]);
								continue;
								end_IL_00f6:
								break;
							}
							break;
						}
						goto IL_0152;
						IL_0152:
						Class9.Class10.smethod_1();
						num2 = 1;
						goto IL_015b;
						continue;
						end_IL_0173:
						break;
					}
					continue;
				}
				num2 = 19;
				goto IL_01e8;
				IL_01e8:
				return 10;
				continue;
				end_IL_0183:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_6()
	{
		byte[] byte_ = Class1.byte_1;
		int num = 3;
		while (!bool_0)
		{
			switch (byte_[27])
			{
			case 87:
			case 88:
			case 89:
			{
				MemberInfo typeFromHandle;
				Monitor.Enter(typeFromHandle = typeof(Class8));
				try
				{
					int num2 = 4;
					while (true)
					{
						if (bool_0)
						{
							switch ((int)byte_[13] / 3)
							{
							case 3:
								goto IL_0077;
							case 0:
							case 2:
								goto end_IL_0070;
							case 1:
							case 5:
								return;
							}
							continue;
						}
						goto IL_0077;
						IL_0077:
						bool_0 = true;
						smethod_7();
						break;
						continue;
						end_IL_0070:
						break;
					}
					num2 = 1;
					return;
				}
				finally
				{
					Monitor.Exit((Type)typeFromHandle);
				}
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_7()
	{
		byte[] byte_ = Class2.byte_1;
		int num = 4;
		while (true)
		{
			Array bytes = BitConverter.GetBytes(DateTime.UtcNow.Ticks);
			while (true)
			{
				AppDomain.CurrentDomain.SetData("b5e4b66ab5ff4ca18958c35c897c6a90", bytes as byte[]);
				while (true)
				{
					num = 2;
					while (true)
					{
						if (!BitConverter.IsLittleEndian)
						{
							switch (byte_[160])
							{
							case 184:
								break;
							case 183:
								goto end_IL_003c;
							case 188:
								goto end_IL_0045;
							default:
								goto end_IL_0049;
							case 182:
								goto IL_0075;
							case 185:
								return;
							}
							continue;
						}
						goto IL_0075;
						IL_0075:
						Array.Reverse((Array)(byte[])bytes);
						return;
						continue;
						end_IL_003c:
						break;
					}
					continue;
					end_IL_0045:
					break;
				}
				continue;
				end_IL_0049:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static AppDomain smethod_8(short short_0, int int_0)
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 18;
			while (true)
			{
				IL_02df:
				switch (((short_0 ^ int_0) - 23) ^ num)
				{
				case 40:
					num2 = byte_2[184] - byte_2[139];
					goto IL_00f0;
				case 39:
					num2 = byte_[16] - 100;
					goto IL_00f0;
				case 38:
					num2 = byte_2[15];
					goto IL_00f0;
				case 37:
					num2 = byte_[144] - 136;
					goto IL_00f0;
				case 36:
					num2 = byte_2[28] + 3;
					goto IL_00f0;
				case 35:
					num2 = 24;
					goto IL_00b5;
				case 33:
					num2 = byte_[201] - byte_[26];
					goto IL_00f0;
				case 32:
					num2 = byte_[200] - 228;
					goto IL_00f0;
				case 31:
					num2 = byte_[46] - 166;
					goto IL_00f0;
				case 30:
					num2 = 38;
					goto IL_0079;
				case 28:
					num2 = 0;
					goto IL_00e2;
				case 27:
					num2 = byte_[14] - byte_[91];
					goto IL_00f0;
				case 26:
					num2 = byte_[125] - 108;
					goto IL_00f0;
				case 25:
					num2 = 15;
					goto IL_00cf;
				case 17:
					num2 = byte_2[122];
					goto IL_00f0;
				case 15:
					num2 = byte_[11] - 72;
					goto IL_00f0;
				case 14:
					num2 = byte_[22] - 51;
					goto IL_00f0;
				case 13:
					num2 = 41;
					goto IL_006c;
				case 9:
					num2 = byte_[30] - 165;
					goto IL_00f0;
				case 8:
					num2 = byte_2[16] - 149;
					goto IL_00f0;
				case 7:
					num2 = 42;
					goto IL_005c;
				case 5:
					num2 = 49;
					goto IL_0026;
				case 3:
					num2 = 35;
					goto IL_0096;
				case 1:
					num2 = byte_[160] - byte_[79];
					goto IL_00f0;
				default:
					num2 = 14;
					goto IL_0498;
				case 0:
					num2 = 7;
					goto IL_0460;
				case 2:
					num2 = 48;
					goto IL_058b;
				case 4:
					num2 = 22;
					goto IL_04cc;
				case 6:
					num2 = 17;
					goto IL_04a2;
				case 10:
					num2 = 46;
					goto IL_0580;
				case 11:
					num2 = 28;
					goto IL_0512;
				case 12:
					num2 = 32;
					goto IL_0533;
				case 16:
					num2 = 30;
					goto IL_0528;
				case 18:
					num2 = 23;
					goto IL_04da;
				case 19:
					num2 = 44;
					goto IL_056a;
				case 20:
					num2 = 27;
					goto IL_0504;
				case 21:
					num2 = 29;
					goto IL_051d;
				case 22:
					num2 = 21;
					goto IL_04be;
				case 23:
					num2 = 36;
					goto IL_0549;
				case 24:
					num2 = 2;
					goto IL_0436;
				case 29:
					num2 = 6;
					goto IL_0452;
				case 34:
					{
						num2 = 26;
						goto IL_04f6;
					}
					IL_00f0:
					while (true)
					{
						switch (num2)
						{
						case 49:
							break;
						case 47:
							obj = AppDomain.CurrentDomain;
							num2 = byte_[117];
							continue;
						case 43:
							obj = AppDomain.CurrentDomain;
							num2 = byte_[117];
							continue;
						case 42:
							goto IL_005c;
						case 41:
							goto IL_006c;
						case 38:
							goto IL_0079;
						case 37:
							obj = AppDomain.CurrentDomain;
							goto case 4;
						case 4:
							num2 = byte_2[192];
							continue;
						case 35:
							goto IL_0096;
						case 33:
							obj = AppDomain.CurrentDomain;
							num2 = byte_[117];
							continue;
						case 24:
							goto IL_00b5;
						case 9:
							goto IL_00bb;
						case 16:
							obj = AppDomain.CurrentDomain;
							num2 = byte_[117];
							continue;
						case 15:
							goto IL_00cf;
						case 0:
							goto IL_00e2;
						case 18:
							goto IL_02df;
						default:
							num2 = 11;
							goto end_IL_02e8;
						case 11:
							goto end_IL_02e8;
						case 1:
							obj = AppDomain.CurrentDomain;
							num2 = 12;
							goto IL_0594;
						case 2:
							goto IL_0436;
						case 3:
							obj = AppDomain.CurrentDomain;
							num2 = 12;
							goto IL_0594;
						case 6:
							goto IL_0452;
						case 7:
							goto IL_0460;
						case 8:
							obj = AppDomain.CurrentDomain;
							num2 = 12;
							goto IL_0594;
						case 10:
							obj = AppDomain.CurrentDomain;
							num2 = 12;
							goto IL_0594;
						case 13:
							obj = AppDomain.CurrentDomain;
							num2 = 12;
							goto IL_0594;
						case 14:
							goto IL_0498;
						case 17:
							goto IL_04a2;
						case 19:
							obj = AppDomain.CurrentDomain;
							num2 = 12;
							goto IL_0594;
						case 21:
							goto IL_04be;
						case 22:
							goto IL_04cc;
						case 23:
							goto IL_04da;
						case 25:
							obj = AppDomain.CurrentDomain;
							num2 = 12;
							goto IL_0594;
						case 26:
							goto IL_04f6;
						case 27:
							goto IL_0504;
						case 28:
							goto IL_0512;
						case 29:
							goto IL_051d;
						case 30:
							goto IL_0528;
						case 32:
							goto IL_0533;
						case 5:
							goto IL_0539;
						case 34:
							obj = AppDomain.CurrentDomain;
							num2 = 12;
							goto IL_0594;
						case 36:
							goto IL_0549;
						case 39:
							obj = AppDomain.CurrentDomain;
							num2 = 12;
							goto IL_0594;
						case 40:
							obj = AppDomain.CurrentDomain;
							num2 = 12;
							goto IL_0594;
						case 44:
							goto IL_056a;
						case 45:
							obj = AppDomain.CurrentDomain;
							num2 = 12;
							goto IL_0594;
						case 46:
							goto IL_0580;
						case 48:
							goto IL_058b;
						case 12:
							goto IL_0594;
						case 20:
							goto IL_05bc;
						}
						break;
					}
					goto IL_0026;
					IL_058b:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_0580:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_056a:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_0549:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_0533:
					obj = AppDomain.CurrentDomain;
					goto IL_0539;
					IL_0539:
					num2 = 12;
					goto IL_0594;
					IL_0528:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_051d:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_0512:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_0504:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_04f6:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_04da:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_04cc:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_04be:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_04a2:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_0498:
					obj = null;
					num2 = 12;
					goto IL_0594;
					IL_0460:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_0452:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_0436:
					obj = AppDomain.CurrentDomain;
					num2 = 12;
					goto IL_0594;
					IL_0594:
					num++;
					Class1.byte_1[86] = (byte)((Class1.byte_1[86] ^ Class2.byte_1[145]) & 0x33);
					num2 = 20;
					goto IL_05bc;
					IL_05bc:
					return obj as AppDomain;
					IL_00e2:
					obj = AppDomain.CurrentDomain;
					num2 = byte_2[192];
					goto IL_00f0;
					IL_00cf:
					obj = AppDomain.CurrentDomain;
					num2 = byte_2[221] - 78;
					goto IL_00f0;
					IL_00b5:
					obj = AppDomain.CurrentDomain;
					goto IL_00bb;
					IL_00bb:
					num2 = byte_[117];
					goto IL_00f0;
					IL_0096:
					obj = AppDomain.CurrentDomain;
					num2 = byte_2[340] - 1;
					goto IL_00f0;
					IL_0079:
					obj = AppDomain.CurrentDomain;
					num2 = byte_[117];
					goto IL_00f0;
					IL_006c:
					obj = AppDomain.CurrentDomain;
					num2 = byte_[117];
					goto IL_00f0;
					IL_005c:
					obj = AppDomain.CurrentDomain;
					num2 = byte_[117];
					goto IL_00f0;
					IL_0026:
					obj = AppDomain.CurrentDomain;
					num2 = byte_2[153] - 90;
					goto IL_00f0;
					end_IL_02e8:
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_9(Stream stream_0, byte[] byte_0, int int_0, int int_1, char char_0, char char_1)
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		int num = 6;
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num2 = 0;
			num = byte_[179] - 104;
			while (true)
			{
				switch (num)
				{
				case 7:
					num2++;
					num = byte_2[153] - 148;
					continue;
				case 5:
					stream_0.Write(byte_0, int_0, int_1);
					goto case 7;
				case 0:
				case 4:
					if (5778 <= num4 - num3 * 6)
					{
						num = 2;
						goto case 2;
					}
					num = 1;
					return;
				case 2:
					num = byte_[319] - 175;
					continue;
				case 3:
					num3 = 812;
					num4 = 963;
					goto case 0;
				case 1:
					return;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_10(string[] string_0, char char_0, char char_1)
	{
		byte[] byte_ = Class1.byte_1;
		while (true)
		{
			int num = 0;
			int num2 = 7;
			while (true)
			{
				IComparable<string> comparable = string.Concat(string_0);
				num++;
				if ((char_1 * char_1 + char_1) % 2 != 0)
				{
					switch (byte_[26])
					{
					case 209:
					case 211:
						num2 = 7;
						break;
					case 215:
						break;
					default:
						num2 = 0;
						goto end_IL_003d;
					case 208:
						goto end_IL_003d;
					case 210:
					case 212:
					case 214:
						goto IL_005d;
					}
					continue;
				}
				num2 = 4;
				goto IL_005d;
				IL_005d:
				return comparable as string;
				continue;
				end_IL_003d:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_11(ResolveEventArgs resolveEventArgs_0, char char_0, int int_0)
	{
		_Assembly requestingAssembly = (_Assembly)(object)resolveEventArgs_0.RequestingAssembly;
		return requestingAssembly as Assembly;
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_12(byte[] byte_0, int int_0, int int_1)
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		object obj = default(object);
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = byte_[102] - byte_[22];
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 7:
					obj = Assembly.Load(byte_0);
					goto case 1;
				case 1:
					num++;
					num3 = 839;
					num2 = byte_[126] - 164;
					continue;
				case 6:
				{
					int num4 = num3;
					num5 = num4 * num4;
					num5 = num3 + num5;
					goto case 5;
				}
				case 5:
					if (num5 % 2 == 0)
					{
						num2 = byte_2[234] - 75;
						continue;
					}
					num2 = 3;
					goto case 3;
				default:
					num2 = 2;
					break;
				case 2:
					break;
				case 0:
					return (Assembly)obj;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_13(ResolveEventArgs resolveEventArgs_0, short short_0, int int_0)
	{
		byte[] byte_ = Class2.byte_1;
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				IEnumerable name = resolveEventArgs_0.Name;
				num++;
				int num3 = short_0 * short_0;
				while (true)
				{
					IL_006e:
					num2 = 3;
					while (true)
					{
						num3 = short_0 + num3;
						if (num3 % 2 != 0)
						{
							break;
						}
						byte num4 = byte_[79];
						Class1.byte_1[236] = (byte)((Class1.byte_1[236] ^ Class2.byte_1[47]) & 0x99);
						switch (num4 - 165)
						{
						case 2:
						case 3:
							continue;
						case 5:
							goto IL_006e;
						case 6:
							goto end_IL_0060;
						case 7:
							goto end_IL_0072;
						case 1:
						case 4:
							return (string)name;
						}
						num2 = 7;
						goto end_IL_0072;
						continue;
						end_IL_0060:
						break;
					}
					break;
				}
				continue;
				end_IL_0072:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_14(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, short short_0, short short_1)
	{
		byte[] byte_ = Class2.byte_1;
		int num = 6;
		while (true)
		{
			int num2 = 0;
			num = byte_[7];
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
				case 5:
					appDomain_0.ResourceResolve += resolveEventHandler_0;
					goto case 3;
				case 3:
					num2++;
					if ((short_0 * short_0 + short_0) % 2 != 0)
					{
						num = 1;
						goto case 1;
					}
					num = byte_[160] - 183;
					continue;
				case 1:
					num = byte_[7];
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_15(byte[] byte_0, byte[] byte_1, SecurityContextSource securityContextSource_0, short short_0, char char_0)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		byte[] byte_2 = Class2.byte_1;
		byte[] byte_3 = Class1.byte_1;
		while (true)
		{
			int num = 0;
			int num2 = 3;
			while (true)
			{
				_Assembly val = (_Assembly)(object)Assembly.Load(byte_0, byte_1, securityContextSource_0);
				num++;
				while (true)
				{
					num2 = 4;
					while (true)
					{
						if ((char_0 * char_0 + char_0) % 2 != 0)
						{
							num2 = byte_2[7];
							while (true)
							{
								switch (num2)
								{
								default:
									num2 = byte_2[136] - 142;
									continue;
								case 5:
									num2 = byte_3[157] - byte_3[111];
									continue;
								case 4:
									break;
								case 6:
								case 7:
									goto end_IL_0061;
								case 3:
									goto end_IL_006e;
								case 1:
									goto end_IL_0073;
								case 0:
									goto IL_008c;
								}
								break;
							}
							continue;
						}
						num2 = 0;
						goto IL_008c;
						IL_008c:
						return val as Assembly;
						continue;
						end_IL_0061:
						break;
					}
					continue;
					end_IL_006e:
					break;
				}
				continue;
				end_IL_0073:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type smethod_16(Exception exception_0, char char_0, short short_0)
	{
		byte[] byte_ = Class2.byte_1;
		int num4 = default(int);
		int num3 = default(int);
		IReflect type = default(IReflect);
		while (true)
		{
			int num = 0;
			int num2 = byte_[209] - 247;
			while (true)
			{
				switch (num2)
				{
				case 7:
				case 8:
					num2 = ((1064 > num4 - num3 * 8) ? (byte_[75] - 251) : (byte_[40] - 252));
					continue;
				case 6:
					type = exception_0.GetType();
					num++;
					num3 = 117;
					num2 = 0;
					goto case 0;
				case 0:
					num4 = 133;
					goto case 7;
				case 1:
					num2 = 6;
					goto case 6;
				default:
					num2 = 5;
					break;
				case 5:
					break;
				case 2:
				case 4:
					return (Type)type;
				}
				break;
			}
		}
	}
}
