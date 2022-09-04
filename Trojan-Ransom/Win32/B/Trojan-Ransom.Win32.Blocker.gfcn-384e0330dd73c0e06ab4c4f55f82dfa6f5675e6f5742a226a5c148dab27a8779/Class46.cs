using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;

internal sealed class Class46
{
	internal sealed class Class47
	{
		internal sealed class Class48
		{
			internal static string smethod_0<T>(object object_0, short short_0, int int_0)
			{
				char[] char_ = default(char[]);
				byte[] byte_ = default(byte[]);
				object byte_2 = default(object);
				object int_ = default(object);
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int num4 = default(int);
				object obj = default(object);
				try
				{
					char_ = Class45.char_0;
					byte_ = Class35.byte_1;
					while (true)
					{
						byte_2 = Class35.byte_0;
						int_ = Class36.int_0;
						while (true)
						{
							num = 11;
							while (true)
							{
								num2 = 0;
								num3 = ((int[])int_)[222] - 38024;
								num = 15;
								while (true)
								{
									IL_024b:
									int num6;
									int num7;
									switch (num3)
									{
									case 10:
										num = 13;
										goto IL_0018;
									case 0:
										num = byte_[155] * 2;
										goto IL_00f9;
									case 9:
										num = 9;
										goto IL_008c;
									case 7:
										num = 18;
										goto IL_002f;
									case 6:
										num = (int)byte_[27] / 8;
										goto IL_00f9;
									case 5:
										num = byte_[185];
										goto IL_00f9;
									case 4:
										num = byte_[134];
										goto IL_00f9;
									case 3:
										num = 7;
										goto IL_00be;
									case 2:
										num = 1;
										goto IL_0155;
									case 1:
										num = 10;
										goto IL_0082;
									default:
										num = byte_[185] + 0;
										goto IL_00f9;
									case 8:
										num = 11;
										break;
									case 11:
										{
											num = 12;
											goto IL_02bf;
										}
										IL_0018:
										num = ((num4 % 2 == 0) ? (char_[255] - 34758) : (byte_[80] - 12));
										goto IL_00f9;
										IL_00a3:
										num = byte_[98];
										goto IL_00f9;
										IL_0082:
										num2++;
										num = 18;
										goto IL_002f;
										IL_00f9:
										while (true)
										{
											int num5;
											switch (num)
											{
											case 13:
												break;
											case 18:
												goto IL_002f;
											default:
												num = char_[229] - 59732;
												continue;
											case 14:
												num5 = (byte_2 as byte[])[367] - 29;
												goto IL_0071;
											case 10:
												goto IL_0082;
											case 9:
												goto IL_008c;
											case 5:
												goto IL_00a3;
											case 8:
												num5 = ((int[])int_)[81] - 24116;
												goto IL_0071;
											case 7:
												goto IL_00be;
											case 1:
												goto IL_0155;
											case 0:
												goto IL_0168;
											case 2:
												num3 = ((byte[])byte_2)[459] - 150;
												num = 15;
												goto IL_024b;
											case 3:
												num3 = ((int[])int_)[172] - 11267;
												num = 15;
												goto IL_024b;
											case 17:
												goto IL_01da;
											case 6:
												goto IL_01dd;
											case 15:
												goto IL_024b;
											case 11:
												goto end_IL_024d;
											case 4:
												goto end_IL_0288;
											case 19:
												goto end_IL_02a5;
											case 12:
												goto IL_02bf;
												IL_0071:
												num3 = num5;
												num = byte_[152] - 56;
												continue;
											}
											break;
										}
										goto IL_0018;
										IL_02bf:
										return ((IConvertible)obj) as string;
										IL_0155:
										switch (((short_0 ^ int_0) - 7) ^ num2)
										{
										case 0:
											goto IL_019b;
										}
										num = 0;
										goto IL_0168;
										IL_019b:
										num = 17;
										goto IL_01da;
										IL_01da:
										num6 = 3;
										goto IL_01db;
										IL_002f:
										num4 = short_0 * short_0;
										num4 = short_0 + num4;
										num3 = 10;
										num = byte_[155] * 3;
										goto IL_00f9;
										IL_0168:
										num7 = (int_ as int[])[148];
										Class36.int_0[141] = (Class36.int_0[141] ^ short_0) & 0xDF;
										num6 = num7 - 32378;
										goto IL_01db;
										IL_01db:
										num3 = num6;
										goto IL_01dd;
										IL_01dd:
										num = 15;
										continue;
										IL_00be:
										obj = Class50.smethod_0<object>((T)object_0, '§', 180);
										num3 = 0;
										num = 15;
										goto case 0;
										IL_008c:
										obj = null;
										num3 = (int_ as int[])[8] - ((int[])int_)[8];
										goto IL_00a3;
										end_IL_024d:
										break;
									}
									break;
								}
								continue;
								end_IL_0288:
								break;
							}
							continue;
							end_IL_02a5:
							break;
						}
					}
				}
				catch (Exception exception_)
				{
					int num8 = default(int);
					int num9 = default(int);
					Class25.smethod_11(exception_, new object[14]
					{
						num2,
						obj,
						num4,
						num8,
						num3,
						byte_2,
						int_,
						num9,
						num,
						char_,
						byte_,
						(T)object_0,
						short_0,
						int_0
					});
					throw;
				}
			}

			internal static string[] smethod_1<T>(object object_0, char char_0, int int_0) where T : Assembly
			{
				byte[] byte_ = default(byte[]);
				char[] char_ = default(char[]);
				Array int_ = default(Array);
				object byte_2 = default(object);
				int num = default(int);
				int num4 = default(int);
				int num2 = default(int);
				object obj = default(object);
				try
				{
					byte_ = Class35.byte_1;
					char_ = Class45.char_0;
					while (true)
					{
						int_ = Class36.int_0;
						byte_2 = Class35.byte_0;
						num = byte_[3];
						while (true)
						{
							int num3;
							int num5;
							switch (num)
							{
							case 10:
								num4 = 0;
								num2 = 9;
								num = 7;
								goto IL_0020;
							case 16:
								switch (((char_0 ^ int_0) - 12) ^ num4)
								{
								case 0:
									goto IL_014f;
								}
								num = 5;
								goto case 5;
							case 5:
								num3 = 8;
								goto IL_0039;
							case 11:
								num4++;
								if ((char_0 * char_0 + char_0) % 2 != 0)
								{
									num = 0;
									goto case 0;
								}
								num = 14;
								goto case 14;
							case 0:
								num5 = (int_ as int[])[266] - 3135;
								goto IL_006d;
							case 14:
								num5 = 0;
								goto IL_006d;
							case 7:
								switch (num2)
								{
								case 10:
									break;
								case 9:
									goto IL_0020;
								case 1:
									goto IL_003f;
								default:
									goto IL_00a7;
								case 5:
									goto IL_00ac;
								case 2:
									goto IL_00c8;
								case 3:
									goto IL_00dd;
								case 4:
									goto IL_00ec;
								case 6:
									goto IL_00fb;
								case 7:
									goto IL_010c;
								case 8:
									goto IL_013d;
								case 11:
									goto IL_0161;
								case 0:
									goto IL_022e;
								}
								num = 10;
								goto case 10;
							case 3:
							case 19:
								num2 = (int_ as int[])[163] - 40989;
								num = 7;
								goto case 7;
							case 9:
								obj = Class50.smethod_1<Assembly>(object_0, 664, 'ˁ');
								goto case 8;
							case 8:
								num2 = 1;
								num = char_[274] - 23401;
								continue;
							case 13:
								num2 = ((byte[])byte_2)[5] - ((byte[])byte_2)[201];
								goto case 15;
							case 15:
								num = char_[174] - 43442;
								continue;
							case 18:
								num3 = (byte_2 as byte[])[121] - 217;
								goto IL_0039;
							case 17:
								num2 = 9;
								num = 7;
								goto IL_0020;
							case 12:
								obj = null;
								num = 2;
								goto case 2;
							case 2:
								num2 = 1;
								num = 7;
								goto IL_003f;
							default:
								num = 6;
								break;
							case 6:
								break;
							case 1:
								{
									string[] result = obj as string[];
									Class45.char_0[211] = (char)(Class45.char_0[211] & int_0 & 'Æ');
									return result;
								}
								IL_0020:
								num = 16;
								goto case 16;
								IL_014f:
								num = char_[206] - 63975;
								continue;
								IL_0039:
								num2 = num3;
								num = 7;
								goto case 7;
								IL_022e:
								num = 1;
								goto case 1;
								IL_0161:
								num = 13;
								goto case 13;
								IL_013d:
								num = char_[142] - 26702;
								continue;
								IL_010c:
								num = 9;
								goto case 9;
								IL_00fb:
								num = char_[6] - 64574;
								continue;
								IL_00ec:
								num = byte_[197];
								continue;
								IL_00dd:
								num = byte_[185];
								continue;
								IL_00c8:
								num = char_[284] - 8228;
								continue;
								IL_00ac:
								num = 3;
								goto case 3;
								IL_00a7:
								num = 3;
								goto case 3;
								IL_003f:
								num = 11;
								goto case 11;
								IL_006d:
								num2 = num5;
								num = 7;
								goto case 7;
							}
							break;
						}
					}
				}
				catch (Exception exception_)
				{
					int num6 = default(int);
					int num7 = default(int);
					Class25.smethod_11(exception_, new object[13]
					{
						num4, obj, num6, num2, int_, byte_2, num7, num, byte_, char_,
						object_0, char_0, int_0
					});
					throw;
				}
			}

			internal static string smethod_2(short short_0, char char_0)
			{
				char[] char_ = default(char[]);
				byte[] byte_ = default(byte[]);
				Array byte_2 = default(Array);
				Array int_ = default(Array);
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int num4 = default(int);
				object obj = default(object);
				try
				{
					char_ = Class45.char_0;
					byte_ = Class35.byte_1;
					while (true)
					{
						byte_2 = Class35.byte_0;
						while (true)
						{
							int_ = Class36.int_0;
							num = 9;
							while (true)
							{
								num2 = 0;
								num3 = ((byte[])byte_2)[407] - 140;
								while (true)
								{
									IL_0230:
									num = 8;
									while (true)
									{
										IL_01f7:
										switch (num3)
										{
										case 10:
											break;
										case 9:
											goto IL_018a;
										case 8:
											goto IL_018e;
										case 7:
											goto IL_019a;
										case 6:
											goto IL_01a1;
										case 5:
											goto IL_01b1;
										case 3:
											goto IL_01be;
										case 2:
											goto IL_01c8;
										case 1:
											goto IL_01d0;
										case 0:
											goto IL_01dd;
										default:
											goto IL_01f0;
										case 4:
											goto IL_0234;
										case 11:
											goto IL_0239;
										}
										num = 16;
										goto IL_0015;
										IL_0239:
										num = 9;
										break;
										IL_0234:
										num = 9;
										break;
										IL_01f0:
										num = 7;
										goto IL_0072;
										IL_01dd:
										num = char_[279] - 30734;
										goto IL_009f;
										IL_01d0:
										num = byte_[134];
										goto IL_009f;
										IL_01c8:
										num = 19;
										goto IL_0041;
										IL_01be:
										num = byte_[98];
										goto IL_009f;
										IL_01b1:
										num = byte_[265];
										goto IL_009f;
										IL_01a1:
										num = char_[11] - 7838;
										goto IL_009f;
										IL_019a:
										num = 0;
										goto IL_0081;
										IL_018e:
										num = (int)byte_[57] / 3;
										goto IL_009f;
										IL_018a:
										num = 6;
										goto IL_011a;
										IL_0041:
										num2++;
										num4 = short_0 * short_0;
										num4 = short_0 + num4;
										num = byte_[112] - 174;
										goto IL_009f;
										IL_0015:
										num3 = (int_ as int[])[108] - 53055;
										num = char_[155] - 40290;
										goto IL_009f;
										IL_009f:
										while (true)
										{
											int num5;
											int num6;
											switch (num)
											{
											case 16:
												break;
											case 20:
												obj = null;
												num = byte_[40];
												continue;
											case 19:
												goto IL_0041;
											case 15:
												num3 = 1;
												num = char_[281] - 64894;
												continue;
											case 7:
												goto IL_0072;
											case 0:
												goto IL_0081;
											case 3:
												switch (((char_0 ^ short_0) - 65) ^ num2)
												{
												case 0:
													goto IL_0115;
												}
												num = 12;
												goto case 12;
											case 6:
												goto IL_011a;
											case 11:
												num5 = 8;
												goto IL_0184;
											case 12:
												num6 = ((int[])int_)[46] - 62217;
												goto IL_0161;
											case 13:
												num6 = 9;
												goto IL_0161;
											case 17:
												num3 = (int_ as int[])[280] - 51283;
												num = 8;
												goto IL_01f7;
											case 18:
												num5 = 1;
												goto IL_0184;
											case 8:
												goto IL_01f7;
											case 1:
												goto IL_0230;
											case 9:
												goto end_IL_01f7;
											case 4:
												goto end_IL_023c;
											default:
												num = 5;
												goto end_IL_0255;
											case 5:
												goto end_IL_0255;
											case 14:
												{
													return obj as string;
												}
												IL_0184:
												num3 = num5;
												num = 8;
												goto IL_01f7;
												IL_0115:
												num = 13;
												goto case 13;
												IL_0161:
												num3 = num6;
												num = 8;
												goto IL_01f7;
											}
											break;
										}
										goto IL_0015;
										IL_011a:
										obj = Class50.smethod_2(827, 811);
										num3 = (byte_2 as byte[])[189] - (byte_2 as byte[])[79];
										num = 8;
										continue;
										IL_0081:
										num = ((num4 % 2 != 0) ? byte_[157] : (char_[178] - 11948));
										goto IL_009f;
										IL_0072:
										num3 = 4;
										num = byte_[197] - 1;
										goto IL_009f;
										continue;
										end_IL_01f7:
										break;
									}
									break;
								}
								continue;
								end_IL_023c:
								break;
							}
							continue;
							end_IL_0255:
							break;
						}
					}
				}
				catch (Exception exception_)
				{
					int num7 = default(int);
					int num8 = default(int);
					Class25.smethod_11(exception_, new object[13]
					{
						num2, obj, num4, num7, num3, byte_2, int_, num8, num, char_,
						byte_, short_0, char_0
					});
					throw;
				}
			}

			internal static void smethod_3<T>(object object_0, ProcessWindowStyle processWindowStyle_0, int int_0, short short_0) where T : ProcessStartInfo
			{
				byte[] byte_ = default(byte[]);
				char[] char_ = default(char[]);
				int num = default(int);
				Array byte_2 = default(Array);
				int num2 = default(int);
				int num3 = default(int);
				try
				{
					byte_ = Class35.byte_1;
					char_ = Class45.char_0;
					num = 13;
					while (true)
					{
						byte_2 = Class35.byte_0;
						while (true)
						{
							num2 = 8;
							num = 8;
							while (true)
							{
								IL_01b7:
								num = byte_[125] - 117;
								while (true)
								{
									int num4;
									switch (num)
									{
									case 15:
										break;
									case 3:
										goto IL_0020;
									case 0:
										goto IL_0063;
									case 14:
										goto IL_0084;
									case 12:
										num4 = 0;
										goto IL_0088;
									case 2:
										num = 8;
										goto IL_008c;
									case 8:
										goto IL_008c;
									case 7:
										goto IL_00bd;
									case 1:
										goto IL_0101;
									case 6:
									case 11:
										goto IL_0119;
									case 10:
										switch (((int_0 ^ short_0) - 100) ^ num3)
										{
										default:
											num = char_[299] - 19520;
											continue;
										case 0:
											break;
										}
										num = 9;
										goto case 9;
									case 9:
										num4 = ((byte[])byte_2)[6] - 203;
										goto IL_0088;
									case 5:
										goto end_IL_016e;
									default:
										goto end_IL_01c3;
									case 4:
										return;
										IL_0088:
										num2 = num4;
										goto case 2;
									}
									num2 = 3;
									num = 8;
									goto IL_001d;
									IL_008c:
									switch (num2)
									{
									case 3:
										break;
									default:
										goto IL_00ba;
									case 0:
										goto IL_00d6;
									case 1:
										goto IL_00e2;
									case 2:
										goto IL_00f4;
									case 6:
										goto IL_00f9;
									case 7:
										goto IL_00fe;
									case 9:
										goto IL_0115;
									case 8:
										goto IL_01b7;
									case 4:
										num = 4;
										return;
									case 5:
										num = 4;
										return;
									}
									goto IL_001d;
									IL_0115:
									num = 11;
									goto IL_0119;
									IL_0119:
									Class36.Class37.smethod_2<ProcessStartInfo>(object_0, processWindowStyle_0, 798, 778);
									goto IL_0020;
									IL_00fe:
									num = 1;
									goto IL_0101;
									IL_00f9:
									num = 1;
									goto IL_0101;
									IL_00f4:
									num = 1;
									goto IL_0101;
									IL_0101:
									num2 = 1;
									num = char_[223] - 6698;
									continue;
									IL_00e2:
									num = char_[290] - 45398;
									continue;
									IL_00d6:
									num = byte_[98];
									continue;
									IL_00ba:
									num = 7;
									goto IL_00bd;
									IL_00bd:
									num3 = 0;
									num2 = 1;
									num = char_[298] - 3936;
									continue;
									IL_0084:
									int num5 = 7;
									goto IL_0072;
									IL_0072:
									num2 = num5;
									num = byte_[185] * 4;
									continue;
									IL_001d:
									num = 3;
									goto IL_0020;
									IL_0020:
									num3++;
									int num6 = (short_0 * short_0 + short_0) % 2;
									Class35.byte_0[410] = (byte)((Class35.byte_0[410] ^ short_0) & 0x85);
									if (num6 != 0)
									{
										num = char_[231] - 42191;
										continue;
									}
									num = 0;
									goto IL_0063;
									IL_0063:
									num5 = ((byte[])byte_2)[20] - 239;
									goto IL_0072;
									continue;
									end_IL_016e:
									break;
								}
								break;
							}
							continue;
							end_IL_01c3:
							break;
						}
					}
				}
				catch (Exception exception_)
				{
					int num7 = default(int);
					int num8 = default(int);
					int num9 = default(int);
					int num10 = default(int);
					int num11 = default(int);
					int num12 = default(int);
					Class25.smethod_11(exception_, new object[16]
					{
						num3, num7, num2, byte_2, num8, num9, num10, num, byte_, char_,
						num11, num12, object_0, processWindowStyle_0, int_0, short_0
					});
					throw;
				}
			}

			internal static Evidence smethod_4<T>(object object_0, int int_0, int int_1) where T : Assembly
			{
				char[] char_ = default(char[]);
				byte[] byte_ = default(byte[]);
				Array int_2 = default(Array);
				Array byte_2 = default(Array);
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int num6 = default(int);
				int num7 = default(int);
				object obj = default(object);
				try
				{
					char_ = Class45.char_0;
					byte_ = Class35.byte_1;
					while (true)
					{
						int_2 = Class36.int_0;
						byte_2 = Class35.byte_0;
						num = 6;
						while (true)
						{
							num2 = 0;
							num3 = (int_2 as int[])[38] - 10015;
							num = 16;
							while (true)
							{
								IL_0245:
								switch (num3)
								{
								case 11:
									num = 1;
									goto IL_0017;
								case 10:
									num = 7;
									goto IL_0027;
								case 8:
									num = char_[253] - 26200;
									goto IL_0194;
								case 7:
									num = 7;
									goto IL_0027;
								case 6:
									num = 18;
									goto IL_00d7;
								case 5:
									num = 15;
									goto IL_0134;
								case 4:
									num = byte_[96] - 56;
									goto IL_0194;
								case 3:
									num = char_[15] - 43270;
									goto IL_0194;
								case 2:
									num = 17;
									goto IL_0105;
								case 1:
									num = 15;
									goto IL_0134;
								default:
									num = 1;
									goto IL_0017;
								case 9:
									num = 6;
									break;
								case 0:
									{
										num = 14;
										goto IL_02b5;
									}
									IL_0194:
									while (true)
									{
										int num5;
										int num4;
										switch (num)
										{
										case 1:
											break;
										case 13:
											goto IL_001b;
										case 7:
											goto IL_0027;
										case 11:
										case 19:
											num2++;
											num6 = 19;
											num = 12;
											goto case 12;
										case 12:
										{
											num7 = 639;
											int num8 = 639 - num6 * 8;
											Class36.int_0[165] = (Class36.int_0[165] + int_0) & 0x92;
											if (5112 <= num8)
											{
												num = char_[182] - 43695;
												continue;
											}
											num = 2;
											goto case 2;
										}
										case 2:
											num5 = ((int[])int_2)[167] - 42934;
											goto IL_00c3;
										case 18:
											goto IL_00d7;
										case 17:
											goto IL_0105;
										case 15:
											goto IL_0134;
										case 9:
											num3 = 2;
											num = char_[198] - 17411;
											continue;
										case 5:
											num5 = 1;
											goto IL_00c3;
										case 3:
											num4 = 7;
											goto IL_016e;
										case 0:
											num4 = ((byte[])byte_2)[310] - 58;
											goto IL_016e;
										case 16:
											goto IL_0245;
										case 6:
											goto end_IL_0247;
										default:
											num = 4;
											goto end_IL_0281;
										case 4:
											goto end_IL_0281;
										case 8:
										case 14:
											goto IL_02b5;
											IL_016e:
											num3 = num4;
											num = char_[329] - 1490;
											continue;
											IL_00c3:
											num3 = num5;
											num = char_[103] - 60888;
											continue;
										}
										break;
									}
									goto IL_0017;
									IL_02b5:
									return obj as Evidence;
									IL_0134:
									num3 = ((byte[])byte_2)[169] - 227;
									num = byte_[40];
									goto IL_0194;
									IL_0105:
									num = (((int_1 ^ int_0) - 90) ^ num2) switch
									{
										0 => char_[149] - 59343, 
										_ => byte_[134], 
									};
									goto IL_0194;
									IL_00d7:
									obj = Class36.Class37.smethod_4<Assembly>(object_0, '\u031f', 'Ͷ');
									num3 = 8;
									num = char_[233] - 53917;
									goto IL_0194;
									IL_0027:
									obj = null;
									num3 = (int_2 as int[])[33] - 9282;
									num = 16;
									continue;
									IL_0017:
									num3 = 9;
									goto IL_001b;
									IL_001b:
									num = 16;
									continue;
									end_IL_0247:
									break;
								}
								break;
							}
							continue;
							end_IL_0281:
							break;
						}
					}
				}
				catch (Exception exception_)
				{
					int num9 = default(int);
					int num10 = default(int);
					Class25.smethod_11(exception_, new object[15]
					{
						num2, obj, num7, num6, num9, num3, int_2, byte_2, num10, num,
						char_, byte_, object_0, int_0, int_1
					});
					throw;
				}
			}
		}

		internal sealed class Class49
		{
			internal static string smethod_0<T>(object object_0, char char_0, int int_0) where T : ResolveEventArgs
			{
				char[] char_ = default(char[]);
				byte[] byte_ = default(byte[]);
				object byte_2 = default(object);
				object int_ = default(object);
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				object obj = default(object);
				try
				{
					char_ = Class45.char_0;
					byte_ = Class35.byte_1;
					while (true)
					{
						byte_2 = Class35.byte_0;
						int_ = Class36.int_0;
						while (true)
						{
							num = 13;
							while (true)
							{
								num2 = 0;
								num3 = (byte_2 as byte[])[33] - 103;
								num = 3;
								while (true)
								{
									IL_01fd:
									int num6;
									switch (num3)
									{
									case 10:
										num = char_[346] - 40625;
										goto IL_0118;
									case 0:
										num = 0;
										goto IL_0047;
									case 9:
										num = 17;
										goto IL_0029;
									case 8:
										num = 7;
										goto IL_00b0;
									case 7:
										num = char_[68] - 11138;
										goto IL_0118;
									case 6:
										num = char_[19] - 47561;
										goto IL_0118;
									case 5:
										num = 10;
										goto IL_008a;
									case 4:
										num = 17;
										goto IL_0029;
									case 2:
										num = 16;
										goto IL_0079;
									case 1:
										num = byte_[265];
										goto IL_0118;
									default:
										num = char_[60] - 10957;
										goto IL_0118;
									case 3:
										num = 13;
										break;
									case 11:
										{
											num = 13;
											break;
										}
										IL_0118:
										while (true)
										{
											int num4;
											switch (num)
											{
											case 17:
												break;
											case 0:
												goto IL_0047;
											case 4:
												goto IL_0068;
											case 9:
											case 16:
												goto IL_0079;
											case 10:
												goto IL_008a;
											case 7:
												goto IL_00b0;
											case 6:
												num3 = ((byte[])byte_2)[197];
												num = char_[298] - 3941;
												continue;
											case 2:
												goto IL_00d9;
											case 1:
											{
												int num5 = char_0 ^ int_0;
												Class45.char_0[111] = (char)((Class45.char_0[111] - int_0) & 'O');
												switch ((num5 - 81) ^ num2)
												{
												default:
													num = char_[70] - 42413;
													continue;
												case 0:
													break;
												}
												num = 18;
												goto case 18;
											}
											case 12:
												num4 = 8;
												goto IL_0186;
											case 18:
												num4 = ((byte[])byte_2)[222];
												goto IL_0186;
											case 3:
												goto IL_01fd;
											case 13:
												goto end_IL_01fe;
											case 11:
												goto end_IL_023f;
											default:
												num = 15;
												goto end_IL_0254;
											case 14:
											case 15:
												goto end_IL_0254;
											case 5:
												{
													return (string)(IComparable)obj;
												}
												IL_0186:
												num3 = num4;
												num = 3;
												goto IL_01fd;
											}
											break;
										}
										goto IL_0029;
										IL_00d9:
										num6 = ((byte[])byte_2)[97];
										goto IL_0069;
										IL_00b0:
										obj = null;
										num3 = 0;
										num = 3;
										goto case 0;
										IL_008a:
										num3 = (int_ as int[])[178] - 60279;
										num = char_[268] - 47472;
										goto IL_0118;
										IL_0079:
										num3 = 3;
										num = byte_[134];
										goto IL_0118;
										IL_0029:
										obj = Class36.Class37.smethod_5<ResolveEventArgs>(object_0, 559, 'ɰ');
										num3 = 0;
										num = 3;
										goto case 0;
										IL_0047:
										num2++;
										if ((char_0 * char_0 + char_0) % 2 != 0)
										{
											num = byte_[185] - 0;
											goto IL_0118;
										}
										num = 4;
										goto IL_0068;
										IL_0068:
										num6 = 7;
										goto IL_0069;
										IL_0069:
										num3 = num6;
										num = byte_[134];
										goto IL_0118;
										end_IL_01fe:
										break;
									}
									break;
								}
								continue;
								end_IL_023f:
								break;
							}
							continue;
							end_IL_0254:
							break;
						}
					}
				}
				catch (Exception exception_)
				{
					int num7 = default(int);
					int num8 = default(int);
					Class25.smethod_11(exception_, new object[13]
					{
						num2, obj, num7, num3, byte_2, int_, num8, num, char_, byte_,
						object_0, char_0, int_0
					});
					throw;
				}
			}

			internal static string smethod_1<T, U>(object object_0, object object_1, int int_0, short short_0) where T : string where U : string
			{
				byte[] byte_ = default(byte[]);
				char[] char_ = default(char[]);
				object byte_2 = default(object);
				Array int_ = default(Array);
				int num = default(int);
				int num3 = default(int);
				int num2 = default(int);
				int num6 = default(int);
				object obj = default(object);
				try
				{
					byte_ = Class35.byte_1;
					char_ = Class45.char_0;
					while (true)
					{
						byte_2 = Class35.byte_0;
						int_ = Class36.int_0;
						num = byte_[185];
						while (true)
						{
							int num8;
							int num7;
							switch (num)
							{
							case 19:
								num3 = 1;
								num = 9;
								goto IL_001b;
							case 18:
								num2++;
								num6 = short_0 * short_0;
								goto case 14;
							case 14:
								num6 = short_0 + num6;
								num = char_[223] - 6699;
								continue;
							case 17:
								num = 9;
								goto case 9;
							case 0:
								if (num6 % 2 == 0)
								{
									num = 11;
									goto case 11;
								}
								num = 13;
								goto case 13;
							case 11:
								num8 = 0;
								goto IL_0071;
							case 13:
								num8 = (byte_2 as byte[])[197];
								goto IL_0071;
							case 16:
								obj = Class36.Class37.Class39.smethod_2<string, string>(object_0, object_1, 31, '\u0004');
								num3 = ((int[])int_)[129] - 12050;
								num = 9;
								goto case 9;
							case 9:
								switch (num3)
								{
								case 1:
									break;
								case 11:
									goto IL_0051;
								case 3:
									goto IL_0079;
								default:
									goto IL_00e2;
								case 0:
									goto IL_00eb;
								case 2:
									goto IL_00fa;
								case 4:
									goto IL_010f;
								case 5:
									goto IL_0124;
								case 6:
									goto IL_0136;
								case 7:
									goto IL_0145;
								case 8:
									goto IL_0157;
								case 10:
									goto IL_0160;
								case 9:
									goto IL_0287;
								}
								goto IL_001b;
							case 1:
								num3 = 6;
								num = byte_[33] - 99;
								continue;
							case 12:
								num7 = 7;
								goto IL_016a;
							case 10:
								obj = null;
								num3 = (byte_2 as byte[])[425] - 67;
								num = char_[325] - 59348;
								continue;
							case 7:
								num3 = (byte_2 as byte[])[17];
								num = byte_[93] - 238;
								continue;
							case 6:
							{
								int num4 = (short_0 ^ int_0) - 23;
								int num5 = num2;
								Class35.byte_0[243] = (byte)(Class35.byte_0[243] & short_0 & 0x6A);
								switch (num4 ^ num5)
								{
								default:
									num = byte_[40] - 4;
									continue;
								case 0:
									break;
								}
								num = 5;
								goto case 5;
							}
							case 5:
								num7 = 3;
								goto IL_016a;
							case 2:
								num2 = 0;
								num3 = ((byte[])byte_2)[197];
								num = char_[166] - 10172;
								continue;
							default:
								num = 8;
								break;
							case 8:
								break;
							case 3:
							case 15:
								{
									return (string)obj;
								}
								IL_016a:
								num3 = num7;
								goto case 17;
								IL_0287:
								num = 3;
								goto case 3;
								IL_0160:
								num = 19;
								goto case 19;
								IL_0157:
								num = 18;
								goto case 18;
								IL_0145:
								num = char_[44] - 44101;
								continue;
								IL_0136:
								num = byte_[265];
								continue;
								IL_0124:
								num = byte_[83] - byte_[50];
								continue;
								IL_010f:
								num = 1;
								goto case 1;
								IL_00fa:
								num = char_[224] - 10430;
								continue;
								IL_00eb:
								num = byte_[134];
								continue;
								IL_00e2:
								num = 19;
								goto case 19;
								IL_0079:
								num = 16;
								goto case 16;
								IL_0051:
								num = 0;
								goto case 0;
								IL_001b:
								num = byte_[185];
								continue;
								IL_0071:
								num3 = num8;
								num = 9;
								goto case 9;
							}
							break;
						}
					}
				}
				catch (Exception exception_)
				{
					int num9 = default(int);
					int num10 = default(int);
					Class25.smethod_11(exception_, new object[15]
					{
						num2, obj, num6, num9, num3, byte_2, int_, num10, num, byte_,
						char_, object_0, object_1, int_0, short_0
					});
					throw;
				}
			}

			internal static void smethod_2<T>(object object_0, byte[] byte_0, short short_0, char char_0) where T : string
			{
				char[] char_ = default(char[]);
				byte[] byte_ = default(byte[]);
				int num = default(int);
				Array int_ = default(Array);
				Array byte_2 = default(Array);
				int num2 = default(int);
				int num3 = default(int);
				int num6 = default(int);
				int num7 = default(int);
				try
				{
					char_ = Class45.char_0;
					byte_ = Class35.byte_1;
					num = 14;
					while (true)
					{
						int_ = Class36.int_0;
						byte_2 = Class35.byte_0;
						num2 = 8;
						num = 0;
						while (true)
						{
							IL_01e1:
							num = 4;
							while (true)
							{
								num3 = 0;
								num2 = 7;
								num = byte_[28] - 249;
								while (true)
								{
									int num5;
									int num4;
									switch (num)
									{
									case 16:
										break;
									case 15:
										num2 = (int_ as int[])[177] - 6869;
										goto case 6;
									case 6:
									case 11:
										num = byte_[98] - 15;
										continue;
									case 13:
										num5 = (int)((byte[])byte_2)[85] / 6;
										goto IL_0069;
									case 0:
										goto IL_006e;
									case 10:
										goto IL_00f3;
									case 3:
										goto IL_010e;
									case 8:
										goto IL_0123;
									case 12:
										num5 = (int_ as int[])[287] - 9984;
										goto IL_0069;
									case 9:
										num4 = 1;
										goto IL_0149;
									case 5:
										num4 = 6;
										goto IL_0149;
									case 1:
										switch (((short_0 ^ char_0) - 70) ^ num3)
										{
										case 0:
											goto IL_0174;
										}
										num = 12;
										goto case 12;
									case 4:
										goto end_IL_017d;
									default:
										goto end_IL_01cd;
									case 7:
										return;
										IL_0174:
										num = 13;
										goto case 13;
										IL_0149:
										num2 = num4;
										num = byte_[166] - 17;
										continue;
										IL_0069:
										num2 = num5;
										num = 0;
										goto IL_006e;
									}
									goto IL_0018;
									IL_006e:
									switch (num2)
									{
									case 0:
										break;
									case 1:
										goto IL_00b7;
									case 2:
										goto IL_00cc;
									case 3:
										goto IL_00d5;
									case 4:
										goto IL_00ea;
									case 5:
										goto IL_00ef;
									case 6:
										goto IL_010b;
									case 7:
										goto IL_0114;
									case 9:
										goto IL_0120;
									default:
										goto IL_01ca;
									case 8:
										goto IL_01e1;
									}
									num = char_[321] - 57083;
									continue;
									IL_01ca:
									num = 4;
									break;
									IL_0120:
									num = 8;
									goto IL_0123;
									IL_010b:
									num = 3;
									goto IL_010e;
									IL_010e:
									num2 = 7;
									num = 0;
									goto IL_0114;
									IL_0114:
									num = byte_[33] - 107;
									continue;
									IL_00ef:
									num = 10;
									goto IL_00f3;
									IL_00f3:
									Class36.Class37.Class39.smethod_3<string>(object_0, byte_0, 'ǭ', 477);
									goto IL_0123;
									IL_00ea:
									num = 8;
									goto IL_0123;
									IL_0123:
									num3++;
									num = 16;
									goto IL_0018;
									IL_00d5:
									num = byte_[124] - byte_[156];
									continue;
									IL_00cc:
									num = 16;
									goto IL_0018;
									IL_00b7:
									num = char_[140] - 25118;
									continue;
									IL_0018:
									num6 = 160;
									num7 = 291;
									num = char_[281] - 64893;
									continue;
									end_IL_017d:
									break;
								}
								continue;
								end_IL_01cd:
								break;
							}
							break;
						}
					}
				}
				catch (Exception exception_)
				{
					int num8 = default(int);
					int num9 = default(int);
					int num10 = default(int);
					int num11 = default(int);
					int num12 = default(int);
					int num13 = default(int);
					Class25.smethod_11(exception_, new object[19]
					{
						num3, num7, num6, num8, num2, int_, byte_2, num9, num10, num11,
						num, char_, byte_, num12, num13, object_0, byte_0, short_0, char_0
					});
					throw;
				}
			}
		}

		internal static AppDomain smethod_0(char char_0, char char_1)
		{
			byte[] byte_ = default(byte[]);
			char[] char_2 = default(char[]);
			Array byte_2 = default(Array);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num5 = default(int);
			object obj = default(object);
			try
			{
				byte_ = Class35.byte_1;
				char_2 = Class45.char_0;
				while (true)
				{
					byte_2 = Class35.byte_0;
					num = 5;
					while (true)
					{
						num2 = 0;
						num3 = ((byte[])byte_2)[97];
						num = 11;
						while (true)
						{
							int num6;
							switch (num3)
							{
							case 11:
								num = byte_[155];
								goto IL_0101;
							case 8:
								num = char_2[118] - 62136;
								goto IL_0101;
							case 5:
								num = 4;
								goto IL_0091;
							case 10:
								num = 9;
								goto IL_00c5;
							case 9:
								num = char_2[29] - 60120;
								goto IL_0101;
							case 7:
								num = 17;
								goto IL_015d;
							case 6:
								num = byte_[157];
								goto IL_0101;
							case 4:
								num = byte_[157];
								goto IL_0101;
							case 3:
								num = char_2[289] - 37580;
								goto IL_0101;
							case 2:
								num = char_2[274] - 23394;
								goto IL_0101;
							case 1:
								num = char_2[205] - 42769;
								goto IL_0101;
							case 0:
								num = 15;
								goto IL_007c;
							default:
								{
									num = 15;
									goto IL_007c;
								}
								IL_0101:
								while (true)
								{
									int num4;
									switch (num)
									{
									case 20:
										break;
									case 19:
										goto IL_0035;
									case 10:
									case 18:
										num2++;
										num5 = char_1 * char_1;
										num5 = char_1 + num5;
										num = byte_[32] - 62;
										continue;
									case 16:
										num4 = 1;
										goto IL_0067;
									case 15:
										goto IL_007c;
									case 14:
										goto IL_0089;
									case 4:
										goto IL_0091;
									case 13:
										goto IL_00bb;
									case 9:
										goto IL_00c5;
									case 12:
										num4 = 7;
										goto IL_0067;
									case 6:
										goto IL_00df;
									case 1:
										obj = null;
										num = char_2[294] - 49582;
										continue;
									default:
										num = byte_[185];
										continue;
									case 17:
										goto IL_015d;
									case 3:
									case 8:
										goto IL_0171;
									case 11:
										goto end_IL_01f0;
									case 5:
										goto end_IL_01ee;
									case 2:
										goto end_IL_0227;
									case 7:
										{
											return (obj as MarshalByRefObject) as AppDomain;
										}
										IL_0067:
										num3 = num4;
										num = char_2[302] - 1259;
										continue;
									}
									break;
								}
								num3 = 8;
								num = 11;
								goto case 8;
								IL_015d:
								obj = Class50.smethod_4('ĉ', 305);
								num3 = 8;
								goto IL_0171;
								IL_0171:
								num = 11;
								break;
								IL_00df:
								num6 = 9;
								goto IL_0036;
								IL_00bb:
								num3 = 10;
								num = 11;
								goto case 10;
								IL_00c5:
								if (num5 % 2 == 0)
								{
									num = byte_[265];
									goto IL_0101;
								}
								num = 19;
								goto IL_0035;
								IL_0036:
								num3 = num6;
								num = char_2[294] - 49591;
								goto IL_0101;
								IL_0089:
								num3 = 5;
								num = 11;
								goto case 5;
								IL_0091:
								num = (((char_1 ^ char_0) - 4) ^ num2) switch
								{
									0 => char_2[101] - 39200, 
									_ => char_2[3] - 64077, 
								};
								goto IL_0101;
								IL_007c:
								num3 = 11;
								num = (int)byte_[81] / 2;
								goto IL_0101;
								IL_0035:
								num6 = 5;
								goto IL_0036;
								end_IL_01f0:
								break;
							}
							continue;
							end_IL_01ee:
							break;
						}
						continue;
						end_IL_0227:
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				int num7 = default(int);
				int num8 = default(int);
				Class25.smethod_11(exception_, new object[12]
				{
					num2, obj, num5, num7, num3, byte_2, num8, num, byte_, char_2,
					char_0, char_1
				});
				throw;
			}
		}

		internal static void smethod_1<T>(object object_0, byte[] byte_0, int int_0, int int_1, char char_0, char char_1) where T : Stream
		{
			char[] char_2 = default(char[]);
			byte[] byte_ = default(byte[]);
			int num = default(int);
			object byte_2 = default(object);
			Array int_2 = default(Array);
			int num2 = default(int);
			int num3 = default(int);
			int num6 = default(int);
			try
			{
				char_2 = Class45.char_0;
				byte_ = Class35.byte_1;
				num = 6;
				while (true)
				{
					byte_2 = Class35.byte_0;
					int_2 = Class36.int_0;
					num2 = 0;
					num = 16;
					while (true)
					{
						IL_01d0:
						num = char_2[54] - 62833;
						while (true)
						{
							int num4;
							switch (num)
							{
							case 2:
								break;
							case 1:
								goto IL_0035;
							case 7:
							case 16:
								goto IL_003b;
							case 5:
								goto IL_006c;
							case 3:
								goto IL_006e;
							case 0:
								goto IL_0094;
							case 12:
								goto IL_0100;
							case 15:
								if (num3 % 2 == 0)
								{
									num = 8;
									goto case 8;
								}
								num = 10;
								goto case 10;
							case 8:
								num4 = 3;
								goto IL_013f;
							case 10:
								num4 = (int_2 as int[])[240] - 35207;
								goto IL_013f;
							case 13:
								num = byte_[40];
								continue;
							case 11:
								num2 = (int_2 as int[])[180] - 14411;
								goto case 13;
							case 9:
								goto IL_0168;
							case 4:
								num2 = (byte_2 as byte[])[197];
								num = byte_[40];
								continue;
							default:
								goto end_IL_0183;
							case 14:
								return;
								IL_013f:
								num2 = num4;
								num = byte_[40];
								continue;
							}
							goto IL_001a;
							IL_0168:
							int num5 = 1;
							goto IL_0036;
							IL_001a:
							switch (((char_1 ^ char_0) - 97) ^ num6)
							{
							case 0:
								break;
							default:
								goto IL_00c0;
							}
							num = 1;
							goto IL_0035;
							IL_00c0:
							num = byte_[197];
							continue;
							IL_006e:
							num2 = 7;
							num = byte_[40];
							continue;
							IL_0035:
							num5 = 2;
							goto IL_0036;
							IL_0036:
							num2 = num5;
							num = 16;
							goto IL_003b;
							IL_003b:
							switch (num2)
							{
							case 5:
								break;
							default:
								goto IL_0069;
							case 1:
								goto IL_007c;
							case 2:
								goto IL_0091;
							case 3:
								goto IL_00ae;
							case 6:
								goto IL_00cf;
							case 7:
								goto IL_00d5;
							case 8:
								goto IL_00ea;
							case 9:
								goto IL_00fc;
							case 0:
								goto IL_01d0;
							case 4:
								num = 14;
								return;
							}
							num = 2;
							goto IL_001a;
							IL_00fc:
							num = 12;
							goto IL_0100;
							IL_00ea:
							num = char_2[62] - 64021;
							continue;
							IL_00d5:
							num = char_2[284] - 8243;
							continue;
							IL_00cf:
							num = 12;
							goto IL_0100;
							IL_00ae:
							num = byte_[190] - 76;
							continue;
							IL_0091:
							num = 0;
							goto IL_0094;
							IL_0094:
							Class36.Class37.smethod_6<Stream>(object_0, byte_0, int_0, int_1, 169, 'ü');
							goto IL_0100;
							IL_0100:
							num6++;
							num3 = char_0 * char_0;
							num3 = char_0 + num3;
							num = char_2[51] - 37379;
							continue;
							IL_007c:
							num = char_2[205] - 42766;
							continue;
							IL_0069:
							num = 5;
							goto IL_006c;
							IL_006c:
							num6 = 0;
							goto IL_006e;
							continue;
							end_IL_0183:
							break;
						}
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				int num7 = default(int);
				int num8 = default(int);
				int num9 = default(int);
				int num10 = default(int);
				int num11 = default(int);
				int num12 = default(int);
				Class25.smethod_11(exception_, new object[20]
				{
					num6, num3, num7, num2, byte_2, int_2, num8, num9, num10, num,
					char_2, byte_, num11, num12, object_0, byte_0, int_0, int_1, char_0, char_1
				});
				throw;
			}
		}

		internal static int smethod_2<T>(object object_0, byte[] byte_0, int int_0, int int_1, char char_0, char char_1) where T : Stream
		{
			byte[] byte_ = default(byte[]);
			char[] char_2 = default(char[]);
			Array int_2 = default(Array);
			Array byte_2 = default(Array);
			int num = default(int);
			int num5 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num2 = default(int);
			try
			{
				byte_ = Class35.byte_1;
				char_2 = Class45.char_0;
				while (true)
				{
					int_2 = Class36.int_0;
					byte_2 = Class35.byte_0;
					num = char_2[129] - 18821;
					while (true)
					{
						int num7;
						int num6;
						switch (num)
						{
						case 3:
						case 21:
							num7 = (int)(byte_2 as byte[])[47] / 2;
							goto IL_0020;
						case 10:
							num5 = ((int[])int_2)[197] - 48667;
							num = 7;
							goto case 7;
						case 4:
							num3 = 0;
							num5 = (byte_2 as byte[])[120] - 242;
							num = 7;
							goto case 7;
						case 7:
							switch (num5)
							{
							case 11:
								break;
							case 3:
								goto IL_0045;
							default:
								goto IL_0096;
							case 0:
								goto IL_00ab;
							case 1:
								goto IL_00bd;
							case 2:
								goto IL_00d2;
							case 4:
								goto IL_0100;
							case 5:
								goto IL_0112;
							case 6:
								goto IL_0136;
							case 7:
								goto IL_0148;
							case 8:
								goto IL_0155;
							case 9:
								goto IL_016a;
							case 10:
								goto IL_0186;
							}
							num = 10;
							goto case 10;
						case 19:
							num5 = (int_2 as int[])[127] - 28561;
							num = byte_[269] + byte_[134];
							continue;
						case 17:
							num3++;
							num4 = char_1 * char_1;
							goto case 14;
						case 14:
							num4 = char_1 + num4;
							num = char_2[82] - 22728;
							continue;
						case 15:
							num5 = 5;
							num = byte_[153] - 158;
							continue;
						case 20:
							num2 = Class50.smethod_5<Stream>(object_0, byte_0, int_0, int_1, 'Ͽ', 917);
							num = char_2[196] - 60745;
							continue;
						case 18:
							num5 = (int_2 as int[])[17] - 30521;
							num = byte_[231] - byte_[256];
							continue;
						case 16:
							num7 = (int_2 as int[])[119] - ((int[])int_2)[119];
							goto IL_0020;
						case 13:
							num5 = (int_2 as int[])[129] - 12048;
							num = 7;
							goto case 7;
						case 0:
						case 12:
							num6 = ((byte[])byte_2)[251] - 213;
							goto IL_0236;
						case 9:
							num6 = 6;
							goto IL_0236;
						case 8:
							num2 = 14;
							num = 15;
							goto case 15;
						default:
							num = byte_[185];
							continue;
						case 5:
							num = ((num4 % 2 != 0) ? (char_2[137] - char_2[137]) : byte_[197]);
							continue;
						case 1:
							switch (((char_1 ^ char_0) - 121) ^ num3)
							{
							case 0:
								num = byte_[40];
								continue;
							}
							num = 3;
							goto case 3;
						case 2:
							break;
						case 11:
							{
								return num2;
							}
							IL_0045:
							num = 4;
							goto case 4;
							IL_0236:
							num5 = num6;
							num = char_2[236] - 51519;
							continue;
							IL_0020:
							num5 = num7;
							num = 7;
							goto case 7;
							IL_0186:
							num = (int)byte_[98] / 3;
							continue;
							IL_016a:
							num = 15;
							goto case 15;
							IL_0155:
							num = byte_[194] - 144;
							continue;
							IL_0148:
							num = (int)byte_[7] / 3;
							continue;
							IL_0136:
							num = (int)byte_[192] / 9;
							continue;
							IL_0112:
							num = 17;
							goto case 17;
							IL_0100:
							num = char_2[53] - 50081;
							continue;
							IL_00d2:
							num = 19;
							goto case 19;
							IL_00bd:
							num = char_2[131] - 12465;
							continue;
							IL_00ab:
							num = byte_[165] - 84;
							continue;
							IL_0096:
							num = byte_[200] - byte_[73];
							continue;
						}
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				int num8 = default(int);
				int num9 = default(int);
				Class25.smethod_11(exception_, new object[17]
				{
					num3, num2, num4, num8, num5, int_2, byte_2, num9, num, byte_,
					char_2, object_0, byte_0, int_0, int_1, char_0, char_1
				});
				throw;
			}
		}

		internal static ProcessStartInfo smethod_3<T>(object object_0, int int_0, int int_1) where T : Process
		{
			byte[] byte_ = default(byte[]);
			char[] char_ = default(char[]);
			object byte_2 = default(object);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			object obj = default(object);
			try
			{
				byte_ = Class35.byte_1;
				char_ = Class45.char_0;
				while (true)
				{
					byte_2 = Class35.byte_0;
					num = byte_[3] - byte_[269];
					while (true)
					{
						int num4;
						int num5;
						switch (num)
						{
						case 18:
							num2 = 2;
							num = 17;
							goto IL_001b;
						case 0:
						{
							int num8 = int_0 ^ int_1;
							Class36.int_0[65] = (Class36.int_0[65] - Class36.int_0[244]) & 0xA8;
							num = ((num8 - 102) ^ num3) switch
							{
								0 => byte_[190] - byte_[83], 
								_ => byte_[239] - 236, 
							};
							continue;
						}
						case 17:
							switch (num2)
							{
							case 2:
								break;
							default:
								goto IL_00b2;
							case 0:
								goto IL_00be;
							case 3:
								goto IL_00d3;
							case 4:
								goto IL_00e5;
							case 5:
								goto IL_00f4;
							case 6:
								goto IL_0113;
							case 7:
								goto IL_0125;
							case 8:
								goto IL_012e;
							case 9:
								goto IL_0143;
							case 11:
								goto IL_0151;
							case 1:
								goto IL_0259;
							case 10:
								goto IL_025e;
							}
							goto IL_001b;
						case 5:
							num2 = 4;
							num = 17;
							goto IL_00e5;
						case 9:
							num3++;
							num6 = 162;
							num7 = 521;
							num = byte_[3];
							continue;
						case 4:
						case 16:
							num4 = 3;
							goto IL_0161;
						case 15:
							num2 = 2;
							num = char_[321] - 57081;
							continue;
						case 14:
							num5 = ((byte[])byte_2)[197];
							goto IL_018e;
						case 13:
							obj = null;
							goto case 12;
						case 12:
							num2 = 5;
							num = 17;
							goto IL_00f4;
						case 11:
							num5 = 9;
							goto IL_018e;
						case 10:
							num4 = 0;
							goto IL_0161;
						case 6:
							num3 = 0;
							num2 = 2;
							num = 17;
							goto IL_001b;
						case 3:
							obj = Class36.smethod_0<Process>(object_0, 940, 1020);
							num2 = (byte_2 as byte[])[97];
							num = byte_[94] - byte_[88];
							continue;
						default:
							num = 2;
							break;
						case 1:
						case 2:
							break;
						case 7:
							{
								return (ProcessStartInfo)obj;
							}
							IL_018e:
							num2 = num5;
							num = 17;
							goto case 17;
							IL_0161:
							num2 = num4;
							num = 17;
							goto case 17;
							IL_025e:
							num = 7;
							goto case 7;
							IL_0259:
							num = 7;
							goto case 7;
							IL_0151:
							num = byte_[134];
							continue;
							IL_0143:
							num = (int)byte_[80] / 2;
							continue;
							IL_012e:
							num = char_[312] - 58564;
							continue;
							IL_0125:
							num = 18;
							goto case 18;
							IL_0113:
							num = char_[13] - 27109;
							continue;
							IL_00f4:
							num = 9;
							goto case 9;
							IL_00d3:
							num = byte_[28] - 234;
							continue;
							IL_00be:
							num = byte_[40] - byte_[197];
							continue;
							IL_00b2:
							num = 5;
							goto case 5;
							IL_00e5:
							num = byte_[265];
							continue;
							IL_001b:
							num = 0;
							goto case 0;
						}
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				int num9 = default(int);
				int num10 = default(int);
				Class25.smethod_11(exception_, new object[14]
				{
					num3, obj, num7, num6, num9, num2, byte_2, num10, num, byte_,
					char_, object_0, int_0, int_1
				});
				throw;
			}
		}

		internal static Assembly smethod_4(char char_0, short short_0)
		{
			char[] char_ = default(char[]);
			byte[] byte_ = default(byte[]);
			object int_ = default(object);
			object byte_2 = default(object);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			object obj = default(object);
			try
			{
				char_ = Class45.char_0;
				byte_ = Class35.byte_1;
				while (true)
				{
					int_ = Class36.int_0;
					byte_2 = Class35.byte_0;
					num = 8;
					while (true)
					{
						num2 = 0;
						while (true)
						{
							num3 = ((int[])int_)[136] - (int_ as int[])[136];
							num = byte_[134];
							while (true)
							{
								int num6;
								switch (num)
								{
								case 17:
									break;
								case 5:
								case 16:
									num6 = 8;
									goto IL_003f;
								case 9:
									goto IL_0047;
								case 3:
									goto IL_0075;
								case 2:
									goto IL_00ae;
								case 14:
									goto IL_00c3;
								case 11:
									goto IL_00c9;
								case 13:
									goto IL_00de;
								case 15:
									goto IL_00e1;
								case 6:
									num6 = ((byte[])byte_2)[223];
									goto IL_003f;
								case 0:
									num2++;
									num4 = 237;
									num5 = 23;
									num = byte_[40];
									continue;
								case 12:
									goto end_IL_014b;
								case 10:
									goto IL_01c9;
								case 8:
									goto end_IL_019b;
								default:
									num = 4;
									goto end_IL_01cf;
								case 4:
									goto end_IL_01cf;
								case 1:
									goto IL_01ea;
									IL_003f:
									num3 = num6;
									num = 3;
									goto IL_0075;
								}
								goto IL_0012;
								IL_0075:
								switch (num3)
								{
								case 7:
									break;
								case 0:
									goto IL_00ac;
								case 1:
									goto IL_00db;
								case 2:
									goto IL_00e7;
								case 4:
									goto IL_00ef;
								case 5:
									goto IL_0101;
								case 6:
									goto IL_0109;
								case 9:
									goto IL_0113;
								default:
									goto IL_01c1;
								case 10:
									goto IL_01c6;
								case 3:
									goto IL_01cd;
								case 8:
									goto IL_01e8;
								}
								num = 9;
								goto IL_0047;
								IL_01e8:
								num = 1;
								goto IL_01ea;
								IL_01ea:
								return ((obj is _Assembly) ? obj : null) as Assembly;
								IL_01c6:
								num = 10;
								goto IL_01c9;
								IL_01c1:
								num = 10;
								goto IL_01c9;
								IL_01c9:
								num3 = 3;
								num = 3;
								goto IL_01cd;
								IL_01cd:
								num = 8;
								goto end_IL_019b;
								IL_0113:
								num = char_[227] - 52551;
								continue;
								IL_0109:
								num = byte_[185];
								continue;
								IL_0101:
								num = 17;
								goto IL_0012;
								IL_00e7:
								num = 17;
								goto IL_0012;
								IL_00db:
								num = 13;
								goto IL_00de;
								IL_00de:
								obj = null;
								goto IL_00e1;
								IL_00e1:
								num3 = 4;
								num = 3;
								goto IL_00ef;
								IL_00ef:
								num = char_[274] - char_[274];
								continue;
								IL_00ac:
								num = 2;
								goto IL_00ae;
								IL_00ae:
								switch (((char_0 ^ short_0) - 98) ^ num2)
								{
								case 0:
									goto IL_00c6;
								}
								num = 14;
								goto IL_00c3;
								IL_00c6:
								num = 11;
								goto IL_00c9;
								IL_00c9:
								int num7 = 2;
								goto IL_00ca;
								IL_0012:
								obj = Class36.Class37.Class39.smethod_4('\u00a0', 218);
								num3 = ((byte[])byte_2)[33] - 105;
								num = byte_[134];
								continue;
								IL_00c3:
								num7 = 1;
								goto IL_00ca;
								IL_00ca:
								num3 = num7;
								num = char_[174] - 43446;
								continue;
								IL_0047:
								int num8 = ((int[])int_)[111];
								Class45.char_0[190] = (char)(Class45.char_0[190] & short_0 & 'q');
								num3 = num8 - 47113;
								num = 3;
								goto IL_0075;
								continue;
								end_IL_014b:
								break;
							}
							continue;
							end_IL_019b:
							break;
						}
						continue;
						end_IL_01cf:
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				int num9 = default(int);
				int num10 = default(int);
				Class25.smethod_11(exception_, new object[14]
				{
					num2, obj, num4, num5, num9, num3, int_, byte_2, num10, num,
					char_, byte_, char_0, short_0
				});
				throw;
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
	private struct Struct17
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct17 struct17_0/* Not supported: data(56 E1 12 E1 56 E1 52 DA 24 D7 34 E3 13 FD 59 ED EF C3 64 E7 19 CE 02 DA 2D D7 37 E3 1B FD 15 ED B8 C3 68 E7 11 CE 52 DA 38 D7 3D E3 49 FD 5B ED E9 C3 70 E7 1B CE 53 DA 21 D7 63 E3 06 FD 09 ED B8 C3 3E E7 4C CE 04 DA 76 D7 61 E3 18 FD) */;

	internal static object smethod_0<T, U>(object object_0, object object_1, char char_2, short short_0) where T : string where U : AppDomain
	{
		char[] array = default(char[]);
		byte[] byte_ = default(byte[]);
		object int_ = default(object);
		int num = default(int);
		int num3 = default(int);
		int num5 = default(int);
		object obj = default(object);
		int num6 = default(int);
		int num7 = default(int);
		try
		{
			array = Class45.char_0;
			byte_ = Class35.byte_1;
			while (true)
			{
				int_ = Class36.int_0;
				num = array[312] - 58558;
				while (true)
				{
					int num4;
					int num2;
					switch (num)
					{
					case 18:
						num3 = 6;
						num = 1;
						goto IL_001a;
					case 2:
						Class36.int_0[40] = (Class36.int_0[40] ^ short_0) & 0xC8;
						num = (((char_2 ^ short_0) - 101) ^ num5) switch
						{
							0 => byte_[125] - 117, 
							_ => array[174] - 43446, 
						};
						continue;
					case 17:
						num4 = 3;
						goto IL_006b;
					case 5:
						obj = Class36.smethod_1<AppDomain, string>(object_0, object_1, 109, 8);
						goto case 4;
					case 4:
						num3 = ((int[])int_)[287] - 9984;
						num = 1;
						goto case 1;
					case 10:
						num3 = (int_ as int[])[142] - 24128;
						num = 1;
						goto case 1;
					case 1:
						switch (num3)
						{
						case 6:
							break;
						case 9:
							goto IL_0072;
						case 5:
							goto IL_00a4;
						case 4:
							goto IL_00a9;
						case 2:
							goto IL_00c7;
						default:
							goto IL_0103;
						case 1:
							goto IL_010d;
						case 3:
							goto IL_011e;
						case 7:
							goto IL_0133;
						case 8:
							goto IL_0142;
						case 0:
							goto IL_014e;
						case 10:
							goto IL_0157;
						case 11:
							goto IL_0169;
						}
						goto IL_001a;
					case 6:
					case 12:
						num3 = 1;
						num = 1;
						goto IL_010d;
					case 11:
						num5 = 0;
						num3 = 6;
						num = 1;
						goto IL_001a;
					case 14:
						obj = null;
						num3 = 0;
						num = 1;
						goto IL_014e;
					case 15:
						num5++;
						num6 = 286;
						num7 = 342;
						num = array[121] - 62441;
						continue;
					case 8:
						num4 = ((int[])int_)[279] - 47980;
						goto IL_006b;
					case 7:
						num2 = 9;
						goto IL_01b4;
					case 3:
						num2 = 8;
						goto IL_01b4;
					default:
						num = 9;
						break;
					case 9:
						break;
					case 0:
						{
							return obj;
						}
						IL_01b4:
						num3 = num2;
						num = 1;
						goto case 1;
						IL_006b:
						num3 = num4;
						num = 1;
						goto case 1;
						IL_0169:
						num = array[239] - 44247;
						continue;
						IL_0157:
						num = byte_[236] - byte_[80];
						continue;
						IL_0142:
						num = 14;
						goto case 14;
						IL_014e:
						num = byte_[98];
						continue;
						IL_0133:
						num = byte_[233] - 34;
						continue;
						IL_011e:
						num = array[174] - 43431;
						continue;
						IL_0103:
						num = 12;
						goto case 6;
						IL_010d:
						num = 11;
						goto case 11;
						IL_00c7:
						num = 5;
						goto case 5;
						IL_00a9:
						num = 10;
						goto case 10;
						IL_00a4:
						num = 5;
						goto case 5;
						IL_0072:
						num = 5;
						goto case 5;
						IL_001a:
						num = 2;
						goto case 2;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num8 = default(int);
			int num9 = default(int);
			Class25.smethod_11(exception_, new object[15]
			{
				num5, obj, num7, num6, num8, num3, int_, num9, num, array,
				byte_, object_0, object_1, char_2, short_0
			});
			throw;
		}
	}

	internal static void smethod_1<T, U, V>(object object_0, object object_1, object object_2, int int_0, char char_2) where T : string where U : AppDomain
	{
		char[] array = default(char[]);
		byte[] byte_ = default(byte[]);
		int num = default(int);
		Array int_ = default(Array);
		Array byte_2 = default(Array);
		int num2 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		try
		{
			array = Class45.char_0;
			byte_ = Class35.byte_1;
			num = 2;
			while (true)
			{
				int_ = Class36.int_0;
				while (true)
				{
					byte_2 = Class35.byte_0;
					num2 = 8;
					num = 14;
					while (true)
					{
						IL_021b:
						num = array[114] - 11855;
						while (true)
						{
							int num3;
							int num5;
							switch (num)
							{
							case 16:
								num = 14;
								goto case 14;
							case 12:
								num4++;
								num6 = char_2 * char_2;
								goto case 8;
							case 8:
								num6 = char_2 + num6;
								num = 1;
								goto case 1;
							case 1:
								num2 = (byte_2 as byte[])[463] - 249;
								num = 14;
								goto case 14;
							case 3:
								Class36.Class37.smethod_7<AppDomain, object, string>(object_0, object_1, (V)object_2, 998, 914);
								goto case 12;
							case 10:
								num4 = 0;
								num2 = ((int[])int_)[34] - 23419;
								goto case 16;
							case 14:
								switch (num2)
								{
								case 9:
									break;
								case 6:
									goto IL_004c;
								case 3:
									goto IL_0052;
								default:
									goto IL_0078;
								case 0:
									goto IL_00c1;
								case 1:
									goto IL_00d6;
								case 2:
									goto IL_00e8;
								case 4:
									goto IL_00fd;
								case 5:
									goto IL_0130;
								case 7:
									goto IL_0145;
								case 8:
									goto IL_021b;
								}
								num = 12;
								goto case 12;
							case 15:
								num = ((num6 % 2 != 0) ? (array[177] - 17054) : (array[229] - 59744));
								continue;
							case 13:
								num3 = ((int[])int_)[271] - 54828;
								goto IL_016a;
							case 11:
								switch (((char_2 ^ int_0) - 66) ^ num4)
								{
								case 0:
									goto IL_018e;
								}
								num = 5;
								goto case 5;
							case 5:
								num5 = 1;
								goto IL_01a4;
							case 4:
								num5 = ((int[])int_)[217] - 48237;
								goto IL_01a4;
							case 7:
								num3 = 0;
								goto IL_016a;
							case 0:
								num2 = ((int[])int_)[176] - 6967;
								num = 14;
								goto case 14;
							case 6:
								break;
							default:
								goto end_IL_022a;
							case 9:
								return;
								IL_018e:
								num = 4;
								goto case 4;
								IL_01a4:
								num2 = num5;
								num = 14;
								goto case 14;
								IL_016a:
								num2 = num3;
								num = (int)byte_[57] / 3;
								continue;
								IL_0145:
								num = array[227] - 52541;
								continue;
								IL_0130:
								num = array[156] - 47227;
								continue;
								IL_00fd:
								num = 15;
								goto case 15;
								IL_00e8:
								num = array[306] - 1619;
								continue;
								IL_00d6:
								num = byte_[86] - 173;
								continue;
								IL_00c1:
								num = array[140] - 25116;
								continue;
								IL_0078:
								num = 10;
								goto case 10;
								IL_0052:
								num = 3;
								goto case 3;
								IL_004c:
								num = 12;
								goto case 12;
							}
							break;
						}
						break;
					}
					continue;
					end_IL_022a:
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			int num12 = default(int);
			Class25.smethod_11(exception_, new object[19]
			{
				num4,
				num6,
				num7,
				num2,
				int_,
				byte_2,
				num8,
				num9,
				num10,
				num,
				array,
				byte_,
				num11,
				num12,
				object_0,
				object_1,
				(V)object_2,
				int_0,
				char_2
			});
			throw;
		}
	}

	internal static byte[] smethod_2<T>(object object_0, short short_0, int int_0) where T : MemoryStream
	{
		byte[] byte_ = default(byte[]);
		char[] array = default(char[]);
		object int_ = default(object);
		object byte_2 = default(object);
		int num = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		object obj = default(object);
		try
		{
			byte_ = Class35.byte_1;
			array = Class45.char_0;
			while (true)
			{
				int_ = Class36.int_0;
				byte_2 = Class35.byte_0;
				num = array[275] - 57096;
				while (true)
				{
					int num2;
					int num7;
					switch (num)
					{
					case 4:
					case 19:
						num2 = 8;
						goto IL_0015;
					case 7:
						Class35.byte_1[60] = (byte)((Class35.byte_1[60] * int_0) & 0x50);
						switch (((short_0 ^ int_0) - 117) ^ num3)
						{
						case 0:
							goto IL_005f;
						}
						num = 11;
						goto case 11;
					case 11:
						num7 = ((int[])int_)[240] - 35209;
						goto IL_0073;
					case 10:
						num7 = ((int[])int_)[14] - 52169;
						goto IL_0073;
					case 14:
						switch (num4)
						{
						case 8:
							break;
						default:
							goto IL_00b0;
						case 0:
							goto IL_00bd;
						case 2:
							goto IL_00cb;
						case 3:
							goto IL_00da;
						case 4:
							goto IL_00ef;
						case 5:
							goto IL_0122;
						case 1:
							goto IL_012f;
						case 6:
							goto IL_013b;
						case 7:
							goto IL_014a;
						case 10:
							goto IL_018a;
						case 11:
							goto IL_01a3;
						case 9:
							goto IL_02a1;
						}
						num = 7;
						goto case 7;
					case 13:
						num4 = 3;
						num = 14;
						goto IL_00da;
					case 18:
						num = ((num5 % 2 != 0) ? (byte_[97] - byte_[172]) : (array[265] - 27893));
						continue;
					case 12:
						obj = null;
						num4 = 1;
						num = 14;
						goto IL_012f;
					case 5:
						obj = Class50.smethod_6<MemoryStream>(object_0, 461, 438);
						goto case 8;
					case 8:
						num4 = (byte_2 as byte[])[85] - ((byte[])byte_2)[4];
						num = (int)byte_[213] / 4;
						continue;
					case 17:
						num4 = 8;
						num = byte_[46] - byte_[50];
						continue;
					case 6:
					case 16:
						num4 = 4;
						num = array[142] - 26700;
						continue;
					case 15:
					{
						num3++;
						num5 = short_0 * short_0;
						int num6 = num5;
						Class35.byte_0[273] = (byte)((Class35.byte_0[273] ^ int_0) & 0x22);
						num5 = short_0 + num6;
						num = 16;
						goto case 6;
					}
					default:
						num = (int)byte_[265] / 6;
						continue;
					case 2:
						num3 = 0;
						num4 = 8;
						num = byte_[68] - 117;
						continue;
					case 0:
						num2 = ((byte[])byte_2)[197];
						goto IL_0015;
					case 1:
						break;
					case 9:
						{
							return (byte[])obj;
						}
						IL_0015:
						num4 = num2;
						num = 14;
						goto case 14;
						IL_02a1:
						num = 9;
						goto case 9;
						IL_01a3:
						num = array[66] - 10086;
						continue;
						IL_018a:
						num = 17;
						goto case 17;
						IL_014a:
						num = 5;
						goto case 5;
						IL_013b:
						num = byte_[197];
						continue;
						IL_0122:
						num = 12;
						goto case 12;
						IL_012f:
						num = byte_[98];
						continue;
						IL_00ef:
						num = 18;
						goto case 18;
						IL_0073:
						num4 = num7;
						num = 14;
						goto case 14;
						IL_00cb:
						num = byte_[155];
						continue;
						IL_00bd:
						num = byte_[48] - 1;
						continue;
						IL_00b0:
						num = 13;
						goto case 13;
						IL_00da:
						num = array[284] - 8243;
						continue;
						IL_005f:
						num = 10;
						goto case 10;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num8 = default(int);
			int num9 = default(int);
			Class25.smethod_11(exception_, new object[14]
			{
				num3, obj, num5, num8, num4, int_, byte_2, num9, num, byte_,
				array, object_0, short_0, int_0
			});
			throw;
		}
	}

	internal static object smethod_3<T, U>(object object_0, object object_1, short short_0, int int_0) where T : ResourceManager where U : string
	{
		char[] array = default(char[]);
		byte[] byte_ = default(byte[]);
		Array int_ = default(Array);
		object byte_2 = default(object);
		int num = default(int);
		object obj = default(object);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		try
		{
			array = Class45.char_0;
			byte_ = Class35.byte_1;
			while (true)
			{
				int_ = Class36.int_0;
				byte_2 = Class35.byte_0;
				num = byte_[134];
				while (true)
				{
					int num7;
					int num6;
					switch (num)
					{
					case 6:
					case 17:
						obj = Class36.smethod_2<ResourceManager, string>(object_0, object_1, 720, '\u02fb');
						num2 = 8;
						num = byte_[162] + 1;
						continue;
					case 16:
						num7 = (int_ as int[])[198] - 22869;
						goto IL_0057;
					case 4:
						num = 13;
						goto case 13;
					case 9:
						num2 = 4;
						num = 13;
						goto IL_006a;
					case 3:
						num3 = 0;
						goto case 5;
					case 5:
						num2 = (int_ as int[])[226] - 14529;
						num = 13;
						goto case 13;
					case 14:
						num2 = 5;
						num = 13;
						goto IL_009b;
					case 7:
						switch (((short_0 ^ int_0) - 56) ^ num3)
						{
						case 0:
							break;
						default:
							goto IL_00c7;
						}
						num = 15;
						goto case 15;
					case 15:
						num7 = ((int[])int_)[53] - 44244;
						goto IL_0057;
					case 13:
						switch (num2)
						{
						case 10:
							break;
						case 4:
							goto IL_006a;
						case 9:
							goto IL_008a;
						case 1:
							goto IL_0090;
						case 5:
							goto IL_009b;
						default:
							goto IL_0103;
						case 0:
							goto IL_0118;
						case 2:
							goto IL_012d;
						case 3:
							goto IL_013c;
						case 6:
							goto IL_0147;
						case 7:
							goto IL_0150;
						case 8:
							goto IL_015c;
						}
						num = 9;
						goto case 9;
					case 12:
						num6 = 5;
						goto IL_0165;
					case 11:
						num6 = 2;
						goto IL_0165;
					case 10:
						num3++;
						num4 = 4008;
						num5 = 468;
						num = 11;
						goto case 11;
					case 2:
						obj = null;
						num2 = ((byte[])byte_2)[295] - 123;
						num = array[170] - 23212;
						continue;
					default:
						num = array[207] - 42838;
						continue;
					case 0:
						break;
					case 8:
						{
							return obj;
						}
						IL_0165:
						num2 = num6;
						num = 13;
						goto case 13;
						IL_0057:
						num2 = num7;
						goto case 4;
						IL_015c:
						num = byte_[3];
						continue;
						IL_0150:
						num = byte_[185];
						continue;
						IL_0147:
						num = 17;
						goto case 6;
						IL_013c:
						num = (int)byte_[109] / 8;
						continue;
						IL_012d:
						num = byte_[50] - 50;
						continue;
						IL_0118:
						num = byte_[144] - 187;
						continue;
						IL_0103:
						num = array[231] - 42196;
						continue;
						IL_0090:
						num = 14;
						goto case 14;
						IL_009b:
						num = 7;
						goto case 7;
						IL_00c7:
						num = 16;
						goto case 16;
						IL_008a:
						num = 9;
						goto case 9;
						IL_006a:
						num = 3;
						goto case 3;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num8 = default(int);
			int num9 = default(int);
			Class25.smethod_11(exception_, new object[16]
			{
				num3, obj, num4, num5, num8, num2, int_, byte_2, num9, num,
				array, byte_, object_0, object_1, short_0, int_0
			});
			throw;
		}
	}

	internal static string smethod_4(int int_0, object object_0, int int_1, int int_2)
	{
		char[] array = default(char[]);
		byte[] byte_ = default(byte[]);
		object byte_2 = default(object);
		object int_3 = default(object);
		int num = default(int);
		int num2 = default(int);
		object obj = default(object);
		int num3 = default(int);
		int num4 = default(int);
		object obj7 = default(object);
		int num8 = default(int);
		object obj5 = default(object);
		int num6 = default(int);
		char c = default(char);
		int num11 = default(int);
		int num12 = default(int);
		object obj6 = default(object);
		IEnumerable enumerable = default(IEnumerable);
		int num14 = default(int);
		try
		{
			array = Class45.char_0;
			byte_ = Class35.byte_1;
			while (true)
			{
				byte_2 = Class35.byte_0;
				int_3 = Class36.int_0;
				num = 25;
				while (true)
				{
					num2 = int_1 ^ 0x3E8A5220 ^ int_2;
					obj = char_1;
					char[] obj2 = (char[])obj;
					num3 = obj2[num2];
					num3 = obj2[num2 + 2] ^ num3;
					num = 22;
					while (true)
					{
						num4 = 16;
						num = array[183] - 2721;
						while (true)
						{
							int num13;
							int num7;
							int num5;
							switch (num)
							{
							case 32:
								if ((obj7 = string_0[num3]) != null)
								{
									num = 12;
									goto case 12;
								}
								num = 3;
								goto case 3;
							case 12:
								num13 = 9;
								goto IL_0030;
							case 3:
								num13 = 0;
								goto IL_0030;
							case 31:
								num8 = (((Array)obj5) as char[])[num6 + 1] ^ c;
								num = 11;
								goto case 11;
							case 11:
							{
								byte num9 = ((byte[])byte_2)[445];
								byte num10 = (byte_2 as byte[])[197];
								Class36.int_0[270] = (Class36.int_0[270] + Class35.byte_0[17]) & 0xEF;
								num4 = num9 + num10;
								num = 9;
								goto case 9;
							}
							case 4:
								num11++;
								num4 = ((byte[])byte_2)[74] - ((byte[])byte_2)[197];
								num = 9;
								goto case 9;
							case 5:
								if ((num8 & 0x20) == 0)
								{
									num = 26;
									goto case 26;
								}
								num = array[302] - 1251;
								continue;
							case 26:
								num7 = 10;
								goto IL_00e3;
							case 20:
							case 29:
								num6 += 3;
								num12 = (num8 & 0x1F) | ((num8 & 0xFFC0) >> 1);
								num = 15;
								goto case 15;
							case 15:
								num4 = 11;
								num = 9;
								goto IL_00d0;
							case 10:
								Class36.Class37.smethod_1<StringBuilder>(obj6 as StringBuilder, (char)(c ^ ((char[])(Array)obj5)[num6 + num12 - num11] ^ ((enumerable as Array) as char[])[(num11 + num6 + 17) % num14]), '%', 39);
								num = 7;
								goto case 7;
							case 7:
								num4 = 13;
								num = 9;
								goto IL_00a6;
							case 9:
								switch (num4)
								{
								case 13:
									break;
								case 11:
									goto IL_00d0;
								case 7:
									goto IL_00ee;
								case 5:
									goto IL_0118;
								default:
									goto IL_01be;
								case 0:
									goto IL_01d2;
								case 2:
									goto IL_01e3;
								case 3:
									goto IL_01f4;
								case 4:
									goto IL_0216;
								case 6:
									goto IL_0246;
								case 8:
									goto IL_0251;
								case 10:
									goto IL_0262;
								case 12:
									goto IL_029f;
								case 16:
									goto IL_02a9;
								case 17:
									goto IL_02b2;
								case 1:
									goto IL_044d;
								case 14:
									goto IL_0453;
								case 9:
									goto IL_049c;
								case 15:
									goto IL_04ad;
								}
								goto IL_00a6;
							case 2:
								num4 = ((byte[])byte_2)[47];
								num = array[225] - 14853;
								continue;
							case 1:
								num12 = (num12 << 15) | (((char[])(Array)obj5)[num6++] ^ c);
								num = byte_[83] - 62;
								continue;
							case 17:
								num14 = ((char[])(Array)enumerable).Length;
								num11 = 1;
								num4 = 17;
								num = byte_[197];
								continue;
							case 30:
								if (num11 > num12)
								{
									num = 6;
									goto case 6;
								}
								num = byte_[243] - 128;
								continue;
							case 6:
								num5 = (int_3 as int[])[30] - 63692;
								goto IL_02ce;
							case 28:
								obj7 = Class50.smethod_0<object>((StringBuilder)obj6, '\u03a2', 945);
								goto case 18;
							case 18:
								string_0[num3] = (string)obj7;
								num = 23;
								goto case 23;
							case 23:
								num4 = (int)(byte_2 as byte[])[392] / 9;
								num = 9;
								goto case 9;
							case 19:
								num7 = 4;
								goto IL_00e3;
							case 16:
								obj6 = new StringBuilder();
								c = ((obj5 as Array) as char[])[num6];
								goto case 31;
							case 14:
								num4 = 10;
								num = 9;
								goto IL_0262;
							case 13:
							{
								char[] obj3 = (char[])obj;
								char[] obj4 = char_0;
								num6 = num2;
								enumerable = obj4;
								obj5 = obj3;
								num4 = 6;
								num = 9;
								goto IL_0246;
							}
							case 8:
								num5 = (int_3 as int[])[195] - 15206;
								goto IL_02ce;
							case 22:
								break;
							case 25:
								goto end_IL_0435;
							default:
								num = 21;
								goto end_IL_0457;
							case 21:
								goto end_IL_0457;
							case 0:
								return obj7 as string;
							case 24:
								{
									return obj7 as string;
								}
								IL_04ad:
								num = 24;
								goto case 24;
								IL_049c:
								num = 0;
								goto case 0;
								IL_0453:
								num = 25;
								goto end_IL_0435;
								IL_044d:
								num = 25;
								goto end_IL_0435;
								IL_02b2:
								num = 30;
								goto case 30;
								IL_02ce:
								num4 = num5;
								num = byte_[197];
								continue;
								IL_02a9:
								num = 32;
								goto case 32;
								IL_029f:
								num = byte_[7];
								continue;
								IL_0262:
								num = 17;
								goto case 17;
								IL_0251:
								num = byte_[18] - 190;
								continue;
								IL_0246:
								num = byte_[40];
								continue;
								IL_0216:
								num = 1;
								goto case 1;
								IL_01f4:
								num = 2;
								goto case 2;
								IL_01e3:
								num = array[107] - 12114;
								continue;
								IL_01d2:
								num = byte_[97] - 190;
								continue;
								IL_01be:
								num = array[231] - 42203;
								continue;
								IL_0118:
								num = 10;
								goto case 10;
								IL_00ee:
								num = 20;
								goto case 20;
								IL_00d0:
								num = 5;
								goto case 5;
								IL_00e3:
								num4 = num7;
								num = 9;
								goto case 9;
								IL_0030:
								num4 = num13;
								num = byte_[73] - 221;
								continue;
								IL_00a6:
								num = 4;
								goto case 4;
							}
							break;
						}
						continue;
						end_IL_0435:
						break;
					}
					continue;
					end_IL_0457:
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num15 = default(int);
			int num16 = default(int);
			Class25.smethod_11(exception_, new object[25]
			{
				num2, num3, obj, obj7, obj6, c, num8, num12, num14, num11,
				obj5, enumerable, num6, num15, num4, byte_2, int_3, num16, num, array,
				byte_, int_0, object_0, int_1, int_2
			});
			throw;
		}
	}

	internal static void smethod_5<T, U>(object object_0, object object_1, int int_0, int int_1) where T : ProcessStartInfo where U : string
	{
		char[] array = default(char[]);
		byte[] byte_ = default(byte[]);
		int num = default(int);
		object byte_2 = default(object);
		object int_2 = default(object);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		try
		{
			array = Class45.char_0;
			byte_ = Class35.byte_1;
			num = 0;
			while (true)
			{
				byte_2 = Class35.byte_0;
				int_2 = Class36.int_0;
				while (true)
				{
					num2 = 1;
					num = 7;
					while (true)
					{
						IL_01a7:
						num = array[224] - 10430;
						while (true)
						{
							switch (num)
							{
							case 15:
								break;
							case 5:
								goto IL_0039;
							case 11:
							case 14:
								goto IL_0051;
							case 12:
							case 13:
								goto IL_0066;
							case 9:
								goto IL_007b;
							case 8:
								goto IL_0090;
							case 7:
								goto IL_009f;
							case 6:
								goto IL_00cd;
							case 3:
								goto IL_00f0;
							case 1:
								goto IL_012f;
							case 2:
								goto IL_014a;
							case 4:
								goto end_IL_015e;
							default:
								goto end_IL_01b9;
							case 10:
								return;
							}
							goto IL_0017;
							IL_009f:
							switch (num2)
							{
							case 4:
								break;
							default:
								goto IL_00ca;
							case 0:
								goto IL_00ed;
							case 2:
								goto IL_0115;
							case 5:
								goto IL_011e;
							case 7:
								goto IL_0123;
							case 8:
								goto IL_012c;
							case 1:
								goto IL_01a7;
							case 3:
								num = 10;
								return;
							case 6:
								num = 10;
								return;
							}
							goto IL_006c;
							IL_012c:
							num = 1;
							goto IL_012f;
							IL_012f:
							Class36.Class37.Class38.smethod_0<ProcessStartInfo, string>(object_0, object_1, 608, 539);
							goto IL_014a;
							IL_0123:
							num = 15;
							goto IL_0017;
							IL_011e:
							num = 2;
							goto IL_014a;
							IL_014a:
							num3++;
							num4 = 228;
							num = byte_[134];
							continue;
							IL_0115:
							num = 12;
							goto IL_0066;
							IL_00ed:
							num = 3;
							goto IL_00f0;
							IL_00f0:
							num5 = 56;
							if (76 >= num4 / 3 - 56)
							{
								num = 11;
								goto IL_0051;
							}
							num = byte_[64] - 232;
							continue;
							IL_0039:
							int num6 = 8;
							goto IL_003a;
							IL_003a:
							num2 = num6;
							num = array[345] - 50724;
							continue;
							IL_00ca:
							num = 6;
							goto IL_00cd;
							IL_00cd:
							num3 = 0;
							num2 = (byte_2 as byte[])[299] - 45;
							num = byte_[83] - 69;
							continue;
							IL_0090:
							int num7 = ((byte[])byte_2)[109] - 87;
							goto IL_0052;
							IL_007b:
							num6 = (int_2 as int[])[280] - 51288;
							goto IL_003a;
							IL_0066:
							num2 = 4;
							num = 7;
							goto IL_006c;
							IL_006c:
							num = byte_[185];
							continue;
							IL_0051:
							num7 = 6;
							goto IL_0052;
							IL_0052:
							num2 = num7;
							num = array[95] - 44791;
							continue;
							IL_0017:
							switch (((int_0 ^ int_1) - 4) ^ num3)
							{
							default:
								num = byte_[32] - 66;
								continue;
							case 0:
								break;
							}
							num = 5;
							goto IL_0039;
							continue;
							end_IL_015e:
							break;
						}
						break;
					}
					continue;
					end_IL_01b9:
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			int num12 = default(int);
			int num13 = default(int);
			Class25.smethod_11(exception_, new object[19]
			{
				num3, num4, num5, num8, num2, byte_2, int_2, num9, num10, num11,
				num, array, byte_, num12, num13, object_0, object_1, int_0, int_1
			});
			throw;
		}
	}

	static Class46()
	{
		Class52.KPUgGmhz2nAeI();
		byte[] byte_ = default(byte[]);
		char[] array = default(char[]);
		int num = default(int);
		object int_ = default(object);
		int num2 = default(int);
		IEnumerable enumerable = default(IEnumerable);
		try
		{
			byte_ = Class35.byte_1;
			array = Class45.char_0;
			num = 13;
			while (true)
			{
				int_ = Class36.int_0;
				num2 = 1;
				num = 12;
				while (true)
				{
					IL_0198:
					num = array[245] - 45226;
					while (true)
					{
						switch (num)
						{
						case 14:
							((char[])(Array)enumerable)[2] = '؋';
							((char[])(enumerable as Array))[3] = '⊋';
							num = (int)byte_[7] / 3;
							continue;
						case 4:
							char_1 = new char[39]
							{
								'\ue156', '\ue112', '\ue156', '\uda52', '휤', '\ue334', 'ﴓ', '\ued59', '쏯', '\ue764',
								'츙', '\uda02', '휭', '\ue337', 'ﴛ', '\ued15', '쎸', '\ue768', '츑', '\uda52',
								'휸', '\ue33d', '\ufd49', '\ued5b', '쏩', '\ue770', '츛', '\uda53', '휡', '\ue363',
								'ﴆ', '\ued09', '쎸', '\ue73e', '칌', '\uda04', '흶', '\ue361', 'ﴘ'
							};
							num = 3;
							goto case 3;
						case 3:
							enumerable = new char[8];
							goto case 7;
						case 7:
							((enumerable as Array) as char[])[7] = '㙃';
							num2 = ((int[])int_)[249] - (int_ as int[])[249];
							num = 12;
							goto case 12;
						case 12:
							switch (num2)
							{
							case 0:
								goto IL_00c5;
							case 2:
								goto IL_00d1;
							case 4:
								goto IL_00d7;
							case 7:
								goto IL_00e4;
							case 1:
								goto IL_0198;
							case 3:
								goto IL_01df;
							case 5:
								goto IL_01e4;
							case 6:
								goto IL_01ec;
							}
							num = 4;
							goto case 4;
						case 9:
							num2 = ((int[])int_)[99] - 2023;
							num = (int)byte_[7] / 2;
							continue;
						case 0:
						case 2:
						case 8:
							num2 = (int_ as int[])[43] - 9528;
							num = 12;
							goto case 12;
						case 5:
							(((Array)enumerable) as char[])[5] = 'ᱽ';
							((char[])(enumerable as Array))[0] = '㭦';
							num = byte_[197];
							continue;
						case 10:
							((char[])(enumerable as Array))[1] = '⽿';
							((enumerable as Array) as char[])[6] = 'ɓ';
							num = 1;
							goto case 1;
						case 1:
							num2 = 6;
							num = 12;
							goto IL_01ec;
						case 6:
							((char[])(enumerable as Array))[4] = '౮';
							string_0 = new string[1];
							num = 11;
							goto case 11;
						case 11:
							{
								char_0 = (char[])(Array)enumerable;
								return;
							}
							IL_01e4:
							num = 1;
							goto case 1;
							IL_01ec:
							num = 6;
							goto case 6;
							IL_01df:
							num = 11;
							goto case 11;
							IL_00e4:
							num = array[214] - 48305;
							continue;
							IL_00d7:
							num = array[82] - 22738;
							continue;
							IL_00d1:
							num = byte_[3];
							continue;
							IL_00c5:
							num = (int)byte_[109] / 8;
							continue;
						}
						break;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			Class25.smethod_10(exception_, enumerable, num3, num2, int_, num4, num, byte_, array, num5, num6);
			throw;
		}
	}
}
