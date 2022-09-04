using System;
using System.Collections;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Security;

namespace ns0;

internal static class Class1
{
	internal static Struct0 struct0_0/* Not supported: data(6A D6 7C 4D 1D 08 46 14 16 F5 CB 61 81 E7 5C 44 C2 74 D0 1F 35 FC D5 CF 98 5A 21 C1 A8 A6 D4 35 68 02 74 5B EA 95 71 88 56 8F 92 3B 91 BC BE 80 2A F5 34 28 28 A6 D7 6C 01 AC B4 C1 E6 83 6B 6F 21 95 F8 7E 72 01 58 2D 03 48 C8 A5 6A 9A 3D DA 9B 9F 97 B1 72 AB 0C C0 2A 07 59 3E E0 AE A0 D1 24 22 19 FB C2 3F 0D 28 9C 07 25 DF DD 32 02 65 6F D8 25 47 EB B8 FC 74 88 38 54 6B A6 1A 4B 53 A6 F6 81 47 80 41 17 5B 91 6F 15 6B 86 2C E2 F6 04 F3 CE 07 88 59 E4 6B 25 A4 72 8A EA A1 81 82 BA D0 38 E5 B0 BA E4 2D C1 C8 B4 7C A2 90 EC 5B 54 5C 66 B2 4B 43 C9 4C 11 15 21 DA CD 8B 6F EE EC 91 AF B4 F2 FB 46 49 0E A0 45 BF A4 68 C7 93 B6 17 36 8E 3B CE 36 76 07 EA D4 9A 98 09 5F 35 58 C4 8E 10 E0 38 68 57 15 1C) */;

	internal static byte[] byte_0;

	internal static Struct5 struct5_0/* Not supported: data(7A CB BF 1B 5F DB F0 C6 D4 C1 26 FC 41 03 B0 19 C2 C1 A6 10 01 E3 09 B5 EC B8 D3 57 28 67 86 1F BB A9 F0 16 D0 03 45 62 10 EC 36 C0 D0 05 34 45 EC 08 89 69 AC 45 1D 96 C1 09 2E A6 08 99 9D 6D 3B 07 41 96 11 9A 48 BE 7B 43 00 14 AC 48 E4 E6 84 8E 69 20 DD 1D 71 75 8C 5A 53 C6 D4 9E 5A 76 4F C8 84 C8 C3 9C 33 52 BE C9 EC 68 45 08 E8 79 24 46 21 79 2F 7C 8E 1E 94 CA 0A B6 47 80 E9 DB E8 89 C4 E3 C2 1B 23 E6 5A 17 61 13 2F 09 30 83 71 D8 A1 8D 7D E0 46 D1 39 66 33 F8 92 7C 0B 3D DE 10 7E BA 43 04 B6 09 23 39 1E 17 1B 7B ED 8B 99 85 45 6D DE 5C 5E 08 42 F1 A9 5C E6 2A 54 DD 0C 23 33 1E 89 75 3F 6C 22 98 69 43 C1 2F B6 BD 77 A7 5E 0C 37 9C 5E 82 B1 76 78 51 59 5A 21 F8 E4 40 0A F6 47 CF 02 24 45 D7 4B 45 F1 1A 46 13 3A EB E3 3F CA 47 A5 6E C3 B0 6C 12 FC ED 12 C7 77 6F 5E 80 24 BE 75 A7 A4 3A C5 5E 51 19 8F 96 30 64 16 6D 75 E1 2E 9C 99 9A 33 95 62 EF 27 57 C5 82 CD 82 BB C5 ED 7B 75 3C 99 90 80 47 1D AA 21 D4 E1 97 D7 A4 51 94 41 C1 E5 88 8B DF 44 B4 12 6E 97 CD 4A 0D DA 69 76 99 F6 38 47 9C 1B 52 7D 88 74 8C 0D 8E) */;

	internal static byte[] byte_1;

	private static Assembly smethod_0(Package package_0, string string_0)
	{
		byte[] array = byte_1;
		byte[] array2 = Class2.byte_1;
		object obj = new Uri(string_0, UriKind.Relative);
		object obj2 = BabelAttribute.smethod_16(Class4.Class5.Class6.smethod_10(package_0, (Uri)obj, 702, 'ˆ'), '\u02d3', 651);
		int num = array[165];
		object obj3 = default(object);
		object obj4 = default(object);
		int num2 = default(int);
		while (true)
		{
			int num3;
			switch (num)
			{
			case 5:
			case 13:
				obj3 = BabelAttribute.smethod_17((byte[])obj4, 183, 254);
				num = array[246] - 165;
				break;
			default:
				num2 = 3;
				num = 2;
				goto IL_007a;
			case 10:
				num2 = 4;
				num = array[85] - 27;
				break;
			case 8:
				num3 = 5;
				goto IL_009d;
			case 6:
				num2 = 2;
				num = array[333] - 154;
				break;
			case 4:
				try
				{
					obj4 = new byte[(int)Class4.Class5.Class6.smethod_11((Stream)obj2, 295, 'ŉ')];
					BabelAttribute.Class0.smethod_10((Stream)obj2, (byte[])obj4, 0, (obj4 as byte[]).Length, 337, 'ĕ');
				}
				finally
				{
					int num4 = 6;
					while (true)
					{
						int num5 = 5;
						num4 = 0;
						while (true)
						{
							IL_01a1:
							num4 = array2[144] - 161;
							while (true)
							{
								int num6;
								switch (num4)
								{
								case 1:
									num6 = 0;
									goto IL_011d;
								case 0:
									switch (num5)
									{
									case 0:
										goto IL_0156;
									case 4:
										goto IL_0161;
									case 5:
										goto IL_01a1;
									case 1:
										goto IL_01ba;
									case 2:
										num4 = 2;
										goto end_IL_01b2;
									case 3:
										goto IL_01c5;
									}
									num4 = 8;
									goto case 8;
								case 3:
									num6 = 1;
									goto IL_011d;
								case 8:
									if ((Stream)obj2 == null)
									{
										num4 = 1;
										goto case 1;
									}
									num4 = 3;
									goto case 3;
								case 4:
								case 7:
								case 9:
									((IDisposable)(Stream)obj2).Dispose();
									goto end_IL_01b2;
								case 2:
									goto end_IL_01b2;
									IL_011d:
									num5 = num6;
									num4 = 0;
									goto case 0;
									IL_01c5:
									num4 = 9;
									goto case 4;
									IL_01ba:
									num4 = 9;
									goto case 4;
									IL_0161:
									num4 = array[248] - 187;
									continue;
									IL_0156:
									num4 = array2[90] - 33;
									continue;
								}
								break;
							}
							break;
						}
						continue;
						end_IL_01b2:
						break;
					}
				}
				num = 12;
				goto default;
			case 3:
				num3 = 0;
				goto IL_009d;
			case 2:
				switch (num2)
				{
				case 3:
					break;
				default:
					goto IL_020b;
				case 0:
					goto IL_0213;
				case 1:
					goto IL_021b;
				case 2:
					goto IL_0223;
				case 5:
					goto IL_022e;
				case 6:
					goto IL_023c;
				case 7:
					goto IL_0247;
				case 4:
					goto IL_02c0;
				}
				goto IL_007a;
			case 0:
			case 1:
				if (Class4.smethod_7(null, (obj3 as ICustomAttributeProvider) as Assembly, 'ʇ', 711))
				{
					num = 3;
					goto case 3;
				}
				num = array2[75] - 245;
				break;
			case 7:
				throw new ArgumentException(Class9.Class11.smethod_13(Class2.smethod_0(Class4.Class5.Class6.smethod_7(1486502075, 4L, 3), 58888), string_0, ':', 4));
			case 9:
			case 11:
				{
					return (Assembly)(ICustomAttributeProvider)obj3;
				}
				IL_02c0:
				num = 7;
				goto case 7;
				IL_0247:
				num = 0;
				goto case 0;
				IL_007a:
				num = array[240] - 53;
				break;
				IL_023c:
				num = array2[119] - 53;
				break;
				IL_022e:
				num = array[232] - 63;
				break;
				IL_0223:
				num = array2[118] - 32;
				break;
				IL_021b:
				num = 4;
				goto case 4;
				IL_0213:
				num = array[122];
				break;
				IL_020b:
				num = 5;
				goto case 5;
				IL_009d:
				num2 = num3;
				num = array2[79] - 164;
				break;
			}
		}
	}

	[SecuritySafeCritical]
	[STAThread]
	private static void Main(string[] args)
	{
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_0589: Incompatible stack heights: 0 vs 1
		//IL_05ee: Incompatible stack heights: 0 vs 1
		//IL_0600: Incompatible stack heights: 0 vs 1
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		byte[] array = Class2.byte_1;
		byte[] array2 = byte_1;
		int num = 3;
		while (true)
		{
			Class8.smethod_6();
			while (true)
			{
				object obj = Class2.byte_0;
				object obj2 = byte_0;
				int num2 = 4;
				num = 0;
				while (true)
				{
					IL_00b9:
					num = array2[115] - 120;
					while (true)
					{
						switch (num)
						{
						case 8:
							num2 = 3;
							num = array2[40] - 16;
							continue;
						case 7:
							if (BabelAttribute.Class0.smethod_12(BabelAttribute.Class0.smethod_11(163, 'º'), new DateTime(635088607167131033L), 862, 850))
							{
								num = 8;
								goto case 8;
							}
							try
							{
								object obj3 = Class4.Class5.Class6.smethod_9(BabelAttribute.smethod_18(typeof(Class1), 'ɬ', 554), Class2.smethod_0(Class4.Class5.Class6.smethod_7(1486502020, 11L, 1), 62022), '³', 236);
								try
								{
									object obj4 = BabelAttribute.smethod_19(obj3 as Stream, FileMode.Open, FileAccess.Read, 305, 365);
									try
									{
										int num3 = 6;
										while (true)
										{
											int num4 = 4;
											num3 = 2;
											while (true)
											{
												IL_0261:
												num3 = 5;
												while (true)
												{
													object obj5 = smethod_0((Package)(IDisposable)obj4, Class2.smethod_0(Class4.Class5.Class6.smethod_7(1486502047, 0L, 1), 63453));
													num3 = 1;
													while (true)
													{
														byte num5 = (obj2 as byte[])[233];
														byte_0[50] = (byte)((byte_0[50] * byte_0[138]) & 0xF4);
														num4 = num5 - 26;
														byte num6 = array[78];
														byte num7 = array[118];
														byte_1[151] = (byte)((byte_1[151] - byte_1[169]) & 0x6E);
														num3 = num6 - num7;
														while (true)
														{
															switch (num3)
															{
															case 0:
															case 2:
															case 7:
																break;
															case 1:
																goto end_IL_0187;
															case 5:
															case 8:
																goto end_IL_01b7;
															default:
																goto end_IL_0228;
															case 4:
																goto IL_0276;
															}
															switch (num4)
															{
															case 1:
																break;
															case 3:
																goto IL_017e;
															default:
																goto IL_0220;
															case 0:
																goto IL_0225;
															case 4:
																goto IL_0261;
															case 2:
																goto IL_026e;
															case 5:
																goto IL_0273;
															}
															num3 = array2[40] - 11;
															continue;
															IL_017e:
															num3 = array2[15] - 20;
															continue;
															IL_0273:
															num3 = 4;
															goto IL_0276;
															IL_026e:
															num3 = 4;
															goto IL_0276;
															IL_0276:
															MethodInfo methodBase_ = BabelAttribute.smethod_20(((obj5 is IEvidenceFactory) ? obj5 : null) as Assembly, 206, 193);
															object obj6 = new object[1];
															(obj6 as object[])[0] = args;
															BabelAttribute.smethod_21(methodBase_, null, (object[])obj6, 979, 914);
															goto end_IL_0266;
															IL_0225:
															num3 = 5;
															goto end_IL_01b7;
															IL_0220:
															num3 = 5;
															goto end_IL_01b7;
															continue;
															end_IL_0187:
															break;
														}
														continue;
														end_IL_01b7:
														break;
													}
													continue;
													end_IL_0228:
													break;
												}
												break;
											}
											continue;
											end_IL_0266:
											break;
										}
									}
									finally
									{
										int num8 = 7;
										while (true)
										{
											int num9 = 0;
											num8 = 4;
											while (true)
											{
												IL_0399:
												num8 = 5;
												while (true)
												{
													if (!(((IDisposable)obj4) is Package))
													{
														num8 = array[69] - 121;
														goto IL_0347;
													}
													num8 = 0;
													goto IL_0335;
													IL_037c:
													num8 = 5;
													continue;
													IL_0325:
													num8 = array[71] - array[136];
													goto IL_0347;
													IL_0347:
													switch (num8)
													{
													case 8:
													case 9:
														break;
													case 6:
														goto IL_02e2;
													case 4:
														goto IL_02e5;
													case 0:
														goto IL_0335;
													case 5:
													case 10:
														continue;
													default:
														goto end_IL_0386;
													case 2:
														goto IL_03b3;
													case 3:
														goto end_IL_039e;
													}
													int num10 = ((byte[])obj2)[144];
													goto IL_02e0;
													IL_0335:
													num10 = ((byte[])obj2)[54] - 214;
													goto IL_02e0;
													IL_031a:
													num8 = array[26] - 120;
													goto IL_0347;
													IL_02e0:
													num9 = num10;
													goto IL_02e2;
													IL_02e2:
													num8 = 4;
													goto IL_02e5;
													IL_02e5:
													switch (num9)
													{
													case 1:
														break;
													case 3:
														goto IL_031a;
													case 6:
														goto IL_0325;
													default:
														goto IL_037c;
													case 0:
														goto IL_0399;
													case 2:
														goto IL_03a6;
													case 4:
														num8 = 3;
														goto end_IL_039e;
													case 5:
														goto IL_03b0;
													}
													num8 = array2[314] - array2[21];
													goto IL_0347;
													IL_03b0:
													num8 = 2;
													goto IL_03b3;
													IL_03a6:
													num8 = 2;
													goto IL_03b3;
													IL_03b3:
													((IDisposable)(Package)(IDisposable)obj4).Dispose();
													goto end_IL_039e;
													continue;
													end_IL_0386:
													break;
												}
												break;
											}
											continue;
											end_IL_039e:
											break;
										}
									}
								}
								finally
								{
									int num11 = 1;
									while (true)
									{
										int num12 = 6;
										num11 = 8;
										while (true)
										{
											IL_0496:
											num11 = 5;
											while (true)
											{
												IL_0488:
												if ((Stream)obj3 == null)
												{
													num11 = 0;
													goto IL_046a;
												}
												num11 = 2;
												goto IL_044a;
												IL_0459:
												int num13;
												num12 = num13;
												num11 = array2[193] - array2[3];
												while (true)
												{
													switch (num11)
													{
													case 8:
													case 9:
														break;
													case 2:
														goto end_IL_0415;
													case 0:
														goto IL_046a;
													case 5:
														goto IL_0488;
													default:
														goto end_IL_0488;
													case 10:
														goto IL_04b3;
													case 6:
													case 7:
														goto end_IL_049b;
													}
													switch (num12)
													{
													case 2:
														break;
													case 4:
														goto IL_0409;
													default:
														goto IL_0479;
													case 5:
														goto IL_047e;
													case 6:
														goto IL_0496;
													case 0:
														num11 = 7;
														goto end_IL_049b;
													case 1:
														goto IL_04a8;
													case 3:
														num11 = 7;
														goto end_IL_049b;
													}
													num11 = (int)array2[122] / 2;
													continue;
													IL_0409:
													num11 = array2[190] - 79;
													continue;
													IL_04a8:
													num11 = 10;
													goto IL_04b3;
													IL_04b3:
													((IDisposable)(Stream)obj3).Dispose();
													goto end_IL_049b;
													IL_047e:
													num11 = 5;
													goto IL_0488;
													IL_0479:
													num11 = 5;
													goto IL_0488;
													continue;
													end_IL_0415:
													break;
												}
												goto IL_044a;
												IL_044a:
												num13 = ((byte[])obj)[343] - 96;
												goto IL_0459;
												IL_046a:
												num13 = ((byte[])obj2)[115] - 68;
												goto IL_0459;
												continue;
												end_IL_0488:
												break;
											}
											break;
										}
										continue;
										end_IL_049b:
										break;
									}
								}
							}
							catch (Exception ex)
							{
								int num14 = 9;
								while (true)
								{
									ICollection collection = new string[5];
									(((Array)collection) as string[])[0] = Class4.smethod_12(Class4.smethod_11(ex, 869, '\u0337'), 130, 247);
									num14 = 4;
									while (true)
									{
										IL_0605:
										int num15 = 3;
										num14 = 5;
										while (true)
										{
											(((Array)collection) as string[])[1] = Class9.Class12.smethod_11('ȳ', 591);
											while (true)
											{
												IL_0527:
												((string[])(collection as Array))[2] = Class9.smethod_16(ex as Exception, 'ɦ', 523);
												num14 = 10;
												while (true)
												{
													IL_054f:
													num15 = ((byte[])obj2)[33];
													while (true)
													{
														IL_055b:
														num14 = 5;
														while (true)
														{
															switch (num15)
															{
															case 0:
																goto IL_054f;
															case 5:
																goto IL_057f;
															case 4:
																goto IL_05e8;
															case 2:
																goto IL_05f3;
															case 1:
																goto end_IL_050a;
															}
															break;
															IL_05f3:
															_ = array[157] - 215;
															goto IL_04d0;
															IL_05e8:
															_ = array[0] - 75;
															goto IL_04d0;
															IL_057f:
															_ = array2[99] - 194;
															goto IL_04d0;
															IL_04d0:
															switch (/*Error near IL_04d0: Stack underflow*/)
															{
															case 3L:
																break;
															case 0L:
																goto IL_0527;
															case 10L:
																goto IL_054f;
															case 7L:
																goto IL_055b;
															case 5L:
																continue;
															case 1L:
															case 8L:
																((string[])(Array)collection)[3] = Class9.Class12.smethod_11('ŉ', 309);
																((collection as Array) as string[])[4] = Class9.smethod_16(ex, '\u0381', 1007);
																num14 = 2;
																goto case 2L;
															case 2L:
																num15 = (obj as byte[])[135];
																num14 = 5;
																continue;
															case 4L:
																goto IL_0605;
															default:
																goto end_IL_050a;
															case 6L:
																Class9.Class11.smethod_14(Class8.smethod_10(((Array)collection) as string[], 'Ψ', 'Ͻ'), 165, '\u008e');
																goto end_IL_0610;
															}
															break;
														}
														break;
													}
													break;
												}
												break;
											}
											continue;
											end_IL_050a:
											break;
										}
										break;
									}
									continue;
									end_IL_0610:
									break;
								}
							}
							Class4.Class5.smethod_8();
							Class9.Class11.smethod_2();
							return;
						case 0:
						case 2:
							switch (num2)
							{
							case 0:
								goto IL_0074;
							case 1:
								goto IL_0078;
							case 2:
								goto IL_007c;
							case 3:
								goto IL_0085;
							case 4:
								goto IL_00b9;
							}
							num = 1;
							goto case 1;
						case 1:
							Class4.Class5.smethod_13();
							goto case 7;
						case 6:
							break;
						default:
							goto end_IL_00c3;
						case 4:
							{
								throw new Exception();
							}
							IL_0085:
							num = array[69] - 125;
							continue;
							IL_007c:
							num = 1;
							goto case 1;
							IL_0078:
							num = 7;
							goto case 7;
							IL_0074:
							num = 7;
							goto case 7;
						}
						break;
					}
					break;
				}
				continue;
				end_IL_00c3:
				break;
			}
		}
	}
}
