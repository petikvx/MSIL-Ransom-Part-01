using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using Evaluation;

namespace ns0;

internal sealed class Class9
{
	internal sealed class Class10
	{
		internal static object smethod_0()
		{
			byte[] byte_ = Class2.byte_1;
			while (true)
			{
				int num = 5;
				int num2 = 127;
				while (true)
				{
					int num3 = ((889 <= num2 - num * 7) ? (byte_[206] - 105) : (byte_[117] - byte_[7]));
					while (true)
					{
						switch (num3)
						{
						case 4:
						case 7:
							smethod_0();
							num3 = byte_[7];
							continue;
						case 2:
							break;
						default:
							num3 = 1;
							goto end_IL_0052;
						case 1:
							goto end_IL_0052;
						case 0:
						case 3:
							num3 = 5;
							goto case 5;
						case 5:
							return null;
						}
						break;
					}
					continue;
					end_IL_0052:
					break;
				}
			}
		}

		internal static string smethod_1()
		{
			byte[] byte_ = Class2.byte_1;
			while (true)
			{
				int num = 121;
				while (true)
				{
					IL_006c:
					int num2;
					if (530 > 265 - num * 2)
					{
						num2 = byte_[175] - 178;
						goto IL_0040;
					}
					num2 = 3;
					goto IL_0038;
					IL_0040:
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = byte_[157] - 221;
							continue;
						case 4:
							smethod_1();
							num2 = byte_[111] - 59;
							continue;
						case 3:
							break;
						case 7:
							goto IL_006c;
						case 2:
							goto end_IL_006c;
						case 1:
						case 6:
							return null;
						}
						break;
					}
					goto IL_0038;
					IL_0038:
					num2 = byte_[64] - 73;
					goto IL_0040;
					continue;
					end_IL_006c:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static byte smethod_2()
		{
			Class8.smethod_8(823, 800).SetData(Class12.smethod_8(7, 1319697000, null), null);
			return 5;
		}

		internal static byte smethod_3()
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			while (true)
			{
				int num = byte_[13];
				while (true)
				{
					switch (num)
					{
					default:
						num = byte_[25] - 177;
						continue;
					case 3:
						smethod_3();
						num = byte_2[73] - 176;
						continue;
					case 7:
						break;
					case 4:
					case 5:
						num = 0;
						goto case 0;
					case 0:
					case 1:
					case 2:
						return 22;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static string smethod_4()
		{
			byte[] byte_ = Class2.byte_1;
			while (true)
			{
				Class8.smethod_8(26, 2).SetData(Class12.smethod_8(0, 1319697007, null), null);
				int num = byte_[111] - 57;
				while (true)
				{
					switch (num)
					{
					default:
						goto IL_0008;
					case 1:
					case 2:
					case 4:
						break;
					case 3:
						return null;
					}
					break;
					IL_0008:
					num = byte_[119] - 59;
				}
			}
		}

		[SecuritySafeCritical]
		internal static string smethod_5()
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			while (true)
			{
				int num = 0;
				while (true)
				{
					object obj = (byte[])Class12.smethod_9(Class8.smethod_8(268, 277), Class12.smethod_8(5, 1319697002, null), 482, 'ƭ');
					int num2 = 7;
					while (true)
					{
						if (((byte[])obj)[num] >= 8)
						{
							num2 = byte_[48] - 218;
							while (true)
							{
								switch (num2)
								{
								case 2:
								case 24:
									if ((obj as byte[])[num] >= 196)
									{
										num2 = 8;
										goto case 8;
									}
									num2 = byte_[274] - 16;
									continue;
								case 8:
									if (196 != ((byte[])obj)[num])
									{
										num2 = 9;
										goto case 9;
									}
									num2 = 3;
									goto case 3;
								case 9:
									Class9.smethod_4();
									num2 = byte_[138] - 94;
									continue;
								case 23:
									if (208 != (obj as byte[])[num])
									{
										num2 = 4;
										goto case 4;
									}
									num2 = 1;
									goto case 1;
								case 4:
									smethod_3();
									num2 = byte_2[209] - 252;
									continue;
								case 1:
									num++;
									num2 = byte_[298] - 142;
									continue;
								case 22:
									num++;
									num2 = 2;
									goto case 2;
								case 14:
								case 19:
									if (((byte[])obj)[num] >= 208)
									{
										num2 = 23;
										goto case 23;
									}
									num2 = byte_[123] - 182;
									continue;
								case 18:
									if (8 != (obj as byte[])[num])
									{
										num2 = 12;
										goto case 12;
									}
									num2 = 5;
									goto case 5;
								case 12:
									Class9.smethod_0();
									num2 = 5;
									goto case 5;
								case 5:
									num++;
									num2 = 14;
									goto case 14;
								case 15:
									if (65 != ((byte[])obj)[num])
									{
										num2 = 13;
										goto case 13;
									}
									num2 = byte_2[190] - 43;
									continue;
								case 13:
									Class9.smethod_4();
									num2 = byte_[35];
									continue;
								case 11:
									if ((obj as byte[])[num] >= 65)
									{
										num2 = 15;
										goto case 15;
									}
									num2 = 17;
									goto case 17;
								case 7:
									break;
								case 20:
									goto end_IL_01af;
								default:
									num2 = 21;
									goto end_IL_01c0;
								case 21:
									goto end_IL_01c0;
								case 0:
									return null;
								case 6:
									return null;
								case 17:
									return null;
								case 3:
									num++;
									return null;
								case 10:
									goto IL_0210;
								}
								break;
							}
							continue;
						}
						num2 = 10;
						goto IL_0210;
						IL_0210:
						Class2.byte_1[48] = (byte)(Class2.byte_1[48] & Class2.byte_1[43] & 0x38);
						return null;
						continue;
						end_IL_01af:
						break;
					}
					continue;
					end_IL_01c0:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static Type smethod_6()
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			while (true)
			{
				int num = 0;
				Array array = (byte[])Class12.smethod_9(Class8.smethod_8(284, 262), Class12.smethod_8(6, 1319697001, null), 110, '>');
				int num2 = 4;
				while (true)
				{
					IL_013c:
					if (((byte[])array)[num] < 8)
					{
						num2 = byte_2[276] - 102;
						goto IL_00dd;
					}
					num2 = 8;
					goto IL_0098;
					IL_019e:
					return typeof(DeepSeaObfuscator);
					IL_0044:
					num++;
					num2 = 1;
					goto IL_004a;
					IL_00dd:
					while (true)
					{
						switch (num2)
						{
						case 19:
							if (65 == ((byte[])array)[num])
							{
								num2 = byte_[0] - byte_[183];
								continue;
							}
							num2 = 10;
							goto case 10;
						case 18:
							break;
						case 1:
							goto IL_004a;
						case 11:
						case 14:
							if (208 != (array as byte[])[num])
							{
								num2 = 2;
								goto case 2;
							}
							num2 = 13;
							goto case 13;
						case 2:
						case 7:
							smethod_4();
							num2 = 13;
							goto case 13;
						case 13:
							num++;
							num2 = byte_[208] - 80;
							continue;
						case 8:
							goto IL_0098;
						case 5:
							goto IL_00a6;
						case 3:
						case 6:
							if (((byte[])array)[num] >= 65)
							{
								num2 = 19;
								goto case 19;
							}
							num2 = 17;
							goto case 17;
						default:
							num2 = byte_[0] - 69;
							continue;
						case 4:
							goto IL_013c;
						case 16:
							goto end_IL_013c;
						case 15:
							return typeof(Class9);
						case 17:
							return typeof(Class4.Class5.Class6);
						case 12:
							goto IL_019e;
						case 10:
							Class9.smethod_2();
							goto case 9;
						case 9:
							num++;
							return typeof(_003CModule_003E);
						}
						break;
					}
					goto IL_0044;
					IL_0098:
					if (8 != ((byte[])array)[num])
					{
						num2 = 5;
						goto IL_00a6;
					}
					num2 = 18;
					goto IL_0044;
					IL_004a:
					if (((byte[])array)[num] >= 208)
					{
						num2 = byte_[35] - 105;
						goto IL_00dd;
					}
					num2 = 12;
					goto IL_019e;
					IL_00a6:
					Class12.smethod_0();
					num2 = byte_[75] - 235;
					goto IL_00dd;
					continue;
					end_IL_013c:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static byte smethod_7()
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			while (true)
			{
				int num = 0;
				Array array = (byte[])Class12.smethod_9(Class8.smethod_8(491, 496), Class12.smethod_8(6, 1319697001, null), 679, '\u02f6');
				int num2 = 1;
				while (true)
				{
					num2 = (((array as byte[])[num] >= 8) ? (byte_[110] - 98) : (byte_2[36] - 184));
					while (true)
					{
						switch (num2)
						{
						case 39:
							Class12.smethod_0();
							num2 = byte_2[165];
							continue;
						case 38:
							if ((array as byte[])[num] >= 196)
							{
								num2 = 9;
								goto case 9;
							}
							num2 = byte_[85];
							continue;
						case 9:
							if (196 != ((byte[])array)[num])
							{
								num2 = 25;
								goto case 25;
							}
							num2 = byte_2[220] - byte_2[90];
							continue;
						case 25:
							Class9.smethod_1();
							num2 = 6;
							goto case 6;
						case 6:
							num++;
							num2 = 11;
							goto case 11;
						case 11:
							if ((array as byte[])[num] >= 145)
							{
								num2 = 33;
								goto case 33;
							}
							num2 = byte_2[75];
							continue;
						case 33:
							if (145 != (array as byte[])[num])
							{
								num2 = 18;
								goto case 18;
							}
							num2 = 15;
							goto case 15;
						case 18:
							smethod_1();
							num2 = byte_2[324] - 59;
							continue;
						case 15:
							num++;
							num2 = byte_2[192];
							continue;
						case 37:
							num++;
							num2 = 0;
							goto case 0;
						case 0:
							if (((byte[])array)[num] >= 208)
							{
								num2 = 23;
								goto case 23;
							}
							num2 = 26;
							goto case 26;
						case 23:
							if (208 != ((byte[])array)[num])
							{
								num2 = byte_2[134];
								continue;
							}
							num2 = 30;
							goto case 30;
						case 30:
						case 36:
							num++;
							num2 = 27;
							goto case 27;
						case 27:
							if ((array as byte[])[num] >= 65)
							{
								num2 = byte_[38] - 166;
								continue;
							}
							num2 = 5;
							goto case 5;
						case 35:
							Class8.smethod_0();
							num2 = 30;
							goto case 30;
						case 3:
						case 34:
							break;
						case 32:
							if (196 != ((byte[])array)[num])
							{
								num2 = 14;
								goto case 14;
							}
							num2 = 29;
							goto case 29;
						case 14:
							smethod_3();
							num2 = byte_2[340] + 16;
							continue;
						case 13:
						case 28:
							if (160 != ((byte[])array)[num])
							{
								num2 = 39;
								goto case 39;
							}
							num2 = byte_2[165];
							continue;
						case 22:
							Class9.smethod_0();
							num2 = byte_2[263] - 130;
							continue;
						case 21:
							Class9.smethod_4();
							num2 = byte_2[296] - 109;
							continue;
						case 16:
							if (8 != (array as byte[])[num])
							{
								num2 = byte_[78] - 21;
								continue;
							}
							num2 = 37;
							goto case 37;
						case 12:
							if (((byte[])array)[num] >= 160)
							{
								num2 = byte_[37] - 209;
								continue;
							}
							num2 = 7;
							goto case 7;
						case 8:
							num++;
							num2 = byte_[7] + 33;
							continue;
						case 4:
							num++;
							num2 = 2;
							goto case 2;
						case 2:
							if (((byte[])array)[num] >= 196)
							{
								num2 = 32;
								goto case 32;
							}
							num2 = byte_2[111] - 104;
							continue;
						case 1:
							goto end_IL_0282;
						default:
							num2 = 19;
							goto end_IL_0339;
						case 19:
							goto end_IL_0339;
						case 10:
							return 25;
						case 7:
							return 14;
						case 17:
							return 30;
						case 20:
							return 22;
						case 24:
							return 23;
						case 29:
							num++;
							return 20;
						case 5:
							return 22;
						case 26:
							return 7;
						}
						num2 = ((65 == (array as byte[])[num]) ? (byte_2[140] - 39) : (byte_[66] - 142));
						continue;
						end_IL_0282:
						break;
					}
					continue;
					end_IL_0339:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static bool smethod_8(DateTime dateTime_0, DateTime dateTime_1, short short_0, int int_0)
		{
			int num = 0;
			bool result;
			int num2;
			do
			{
				result = dateTime_0 > dateTime_1;
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static Stream smethod_9(PackagePart packagePart_0, int int_0, int int_1)
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			int num3 = default(int);
			IDisposable stream = default(IDisposable);
			while (true)
			{
				int num = 0;
				int num2 = byte_[174] - 67;
				while (true)
				{
					switch (num2)
					{
					case 8:
					{
						int num4 = num3;
						num2 = (((num4 * num4 + num3) % 2 == 0) ? (byte_[21] - 232) : byte_2[13]);
						continue;
					}
					case 5:
						num++;
						num3 = 1191;
						num2 = 8;
						goto case 8;
					case 3:
						num2 = byte_2[201] - byte_2[201];
						continue;
					case 0:
					case 2:
						stream = packagePart_0.GetStream();
						goto case 5;
					default:
						num2 = 6;
						break;
					case 6:
						break;
					case 1:
					case 4:
						return stream as Stream;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static Package smethod_10(Stream stream_0, FileMode fileMode_0, FileAccess fileAccess_0, int int_0, int int_1)
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			while (true)
			{
				int num = 0;
				int num2 = 4;
				while (true)
				{
					object obj = Package.Open(stream_0, fileMode_0, fileAccess_0);
					while (true)
					{
						num++;
						num2 = 5;
						while (true)
						{
							int num3 = 272;
							int num4 = 73984;
							while (true)
							{
								num4 = num3 + num4;
								num2 = 6;
								while (true)
								{
									if (num4 % 2 != 0)
									{
										num2 = byte_2[57] - 69;
										while (true)
										{
											switch (num2)
											{
											default:
												num2 = byte_[162] - 118;
												continue;
											case 6:
												break;
											case 3:
												goto end_IL_004f;
											case 5:
												goto end_IL_0057;
											case 7:
												goto end_IL_0062;
											case 1:
											case 4:
												goto end_IL_0072;
											case 8:
												goto end_IL_007a;
											case 0:
												goto IL_008e;
											}
											break;
										}
										continue;
									}
									num2 = 0;
									goto IL_008e;
									IL_008e:
									return (Package)((obj is Package) ? obj : null);
									continue;
									end_IL_004f:
									break;
								}
								continue;
								end_IL_0057:
								break;
							}
							continue;
							end_IL_0062:
							break;
						}
						continue;
						end_IL_0072:
						break;
					}
					continue;
					end_IL_007a:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static bool smethod_11(Assembly assembly_0, Assembly assembly_1, short short_0, char char_0)
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			int num4 = default(int);
			bool result = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = byte_[122];
				while (true)
				{
					switch (num2)
					{
					case 11:
						num4 = short_0 * short_0;
						goto case 2;
					case 2:
						num4 = short_0 + num4;
						num2 = 9;
						goto case 9;
					case 9:
						num2 = ((num4 % 2 != 0) ? (byte_2[164] - 102) : (byte_2[24] - 230));
						continue;
					case 6:
					case 10:
					{
						int num3 = short_0 ^ char_0;
						Class2.byte_1[152] = (byte)((Class2.byte_1[152] * short_0) & 0x8A);
						switch ((num3 - 5) ^ num)
						{
						case 0:
							goto IL_007f;
						case 1:
							goto IL_008b;
						}
						num2 = 1;
						goto case 1;
					}
					case 1:
						result = true;
						num2 = byte_2[7];
						continue;
					case 4:
						result = assembly_0 == assembly_1;
						num2 = 5;
						goto case 5;
					case 5:
						num++;
						goto case 11;
					default:
						num2 = byte_[71] - 182;
						continue;
					case 3:
						result = assembly_0 != assembly_1;
						num2 = byte_2[7];
						continue;
					case 8:
						break;
					case 0:
						{
							return result;
						}
						IL_008b:
						num2 = 4;
						goto case 4;
						IL_007f:
						num2 = byte_2[3] - 217;
						continue;
					}
					break;
				}
			}
		}
	}

	internal sealed class Class11
	{
		[SecuritySafeCritical]
		internal static string smethod_0()
		{
			byte[] byte_ = Class2.byte_1;
			while (true)
			{
				Class8.smethod_8(798, 770).SetData(Class12.smethod_8(6, 1319697001, null), null);
				while (true)
				{
					switch (byte_[81])
					{
					case 200:
						continue;
					default:
					{
						int num = 3;
						break;
					}
					case 202:
						break;
					case 201:
						return null;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_1()
		{
			Class8.smethod_8(81, 76).SetData(Class12.smethod_8(6, 1319697001, null), null);
		}

		[SecuritySafeCritical]
		internal static object smethod_2()
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			while (true)
			{
				int num = 0;
				object obj = (byte[])Class12.smethod_9(Class8.smethod_8(511, 481), Class12.smethod_8(0, 1319697007, null), 337, 'ă');
				int num2 = 25;
				while (true)
				{
					if (((byte[])obj)[num] >= 8)
					{
						num2 = 32;
						while (true)
						{
							IL_022c:
							if (8 == ((byte[])obj)[num])
							{
								num2 = 24;
								goto IL_0219;
							}
							num2 = 18;
							goto IL_0210;
							IL_0219:
							while (true)
							{
								IL_0219_2:
								num++;
								num2 = byte_[19];
								while (true)
								{
									switch (num2)
									{
									case 30:
										num++;
										num2 = byte_2[156] - 241;
										continue;
									case 28:
										num++;
										num2 = byte_[41] - 234;
										continue;
									case 26:
										if (208 != ((byte[])obj)[num])
										{
											num2 = 22;
											goto case 22;
										}
										num2 = 28;
										goto case 28;
									case 22:
										smethod_0();
										num2 = 28;
										goto case 28;
									case 23:
										if (196 != (obj as byte[])[num])
										{
											num2 = 21;
											goto case 21;
										}
										num2 = 13;
										goto case 13;
									case 21:
										Class9.smethod_1();
										num2 = (int)byte_2[101] / 5;
										continue;
									case 13:
										num++;
										num2 = 12;
										goto case 12;
									case 12:
										if ((obj as byte[])[num] >= 145)
										{
											num2 = byte_[47] - 55;
											continue;
										}
										num2 = 5;
										goto case 5;
									case 17:
										Class9.smethod_0();
										num2 = byte_[52] - 172;
										continue;
									case 16:
										if ((obj as byte[])[num] >= 208)
										{
											num2 = byte_2[161];
											continue;
										}
										num2 = 27;
										goto case 27;
									case 14:
										if (145 != (obj as byte[])[num])
										{
											num2 = 3;
											goto case 3;
										}
										num2 = 30;
										goto case 30;
									case 3:
										Class10.smethod_2();
										num2 = byte_[119];
										continue;
									case 11:
										if ((obj as byte[])[num] >= 196)
										{
											num2 = 23;
											goto case 23;
										}
										num2 = 1;
										goto case 1;
									case 6:
									case 8:
										break;
									case 2:
										if (((byte[])obj)[num] >= 65)
										{
											num2 = (int)byte_[28] / 5;
											continue;
										}
										num2 = 19;
										goto case 19;
									case 0:
										num++;
										num2 = 11;
										goto case 11;
									case 18:
										goto end_IL_017c;
									case 4:
									case 24:
										goto IL_0219_2;
									case 32:
										goto IL_022c;
									case 20:
									case 25:
										goto end_IL_022c;
									default:
										num2 = 10;
										goto end_IL_023d;
									case 10:
										goto end_IL_023d;
									case 7:
										if ((obj as byte[])[num] >= 160)
										{
											num2 = 31;
											goto case 31;
										}
										num2 = 34;
										goto case 34;
									case 1:
										return null;
									case 19:
										return null;
									case 5:
										return null;
									case 27:
										return null;
									case 31:
										if (160 != (obj as byte[])[num])
										{
											num2 = 15;
											goto case 15;
										}
										num2 = 9;
										goto case 9;
									case 15:
										Class8.smethod_0();
										num2 = 9;
										goto case 9;
									case 9:
										num++;
										return null;
									case 34:
										return null;
									case 29:
										goto IL_02e8;
									}
									num2 = ((65 == ((byte[])obj)[num]) ? (byte_2[21] - 233) : (byte_2[57] - 56));
									continue;
									end_IL_017c:
									break;
								}
								break;
							}
							goto IL_0210;
							IL_0210:
							Class10.smethod_0();
							num2 = 24;
							goto IL_0219;
							continue;
							end_IL_022c:
							break;
						}
						continue;
					}
					num2 = 29;
					goto IL_02e8;
					IL_02e8:
					return null;
					continue;
					end_IL_023d:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static object smethod_3()
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			while (true)
			{
				int num = 0;
				Array array = (byte[])Class12.smethod_9(Class8.smethod_8(674, 701), Class12.smethod_8(7, 1319697000, null), 583, 'Ȕ');
				int num2 = 35;
				while (true)
				{
					num2 = ((((byte[])array)[num] >= 8) ? (byte_[163] - 43) : byte_2[3]);
					while (true)
					{
						switch (num2)
						{
						case 38:
							if (145 != (array as byte[])[num])
							{
								num2 = 32;
								goto case 32;
							}
							num2 = 21;
							goto case 21;
						case 32:
							Class10.smethod_0();
							num2 = byte_[145] - 209;
							continue;
						case 21:
							num++;
							num2 = 18;
							goto case 18;
						case 18:
							if (((byte[])array)[num] >= 160)
							{
								num2 = 8;
								goto case 8;
							}
							num2 = 23;
							goto case 23;
						case 8:
							if (160 != (array as byte[])[num])
							{
								num2 = 20;
								goto case 20;
							}
							num2 = byte_[193] + 10;
							continue;
						case 20:
							Class10.smethod_2();
							num2 = byte_2[113] - 36;
							continue;
						case 36:
							smethod_0();
							num2 = byte_[47] - 162;
							continue;
						case 34:
							num++;
							num2 = byte_[81] - 179;
							continue;
						case 31:
							break;
						case 30:
							if (196 != (array as byte[])[num])
							{
								num2 = byte_[83];
								continue;
							}
							num2 = 14;
							goto case 14;
						case 14:
							num++;
							num2 = 7;
							goto case 7;
						case 7:
							if ((array as byte[])[num] >= 145)
							{
								num2 = 38;
								goto case 38;
							}
							num2 = byte_2[286];
							continue;
						case 26:
							goto IL_0142;
						case 25:
							num++;
							num2 = byte_[207] - byte_[117];
							continue;
						case 22:
							if (((byte[])array)[num] >= 196)
							{
								num2 = (int)byte_2[184] / 2;
								continue;
							}
							num2 = 6;
							goto case 6;
						case 15:
							smethod_1();
							goto case 12;
						case 12:
							num++;
							num2 = 0;
							goto case 0;
						case 0:
							num2 = (((array as byte[])[num] < 65) ? byte_[9] : (byte_[100] - 151));
							continue;
						default:
							num2 = byte_[175] - 181;
							continue;
						case 11:
							num++;
							num2 = byte_2[273] - 74;
							continue;
						case 10:
							goto IL_0203;
						case 5:
							Class8.smethod_1();
							goto case 11;
						case 4:
							if (65 != ((byte[])array)[num])
							{
								num2 = 5;
								goto case 5;
							}
							num2 = 11;
							goto case 11;
						case 3:
							Class8.smethod_0();
							num2 = 25;
							goto case 25;
						case 2:
							if ((array as byte[])[num] >= 208)
							{
								num2 = byte_2[122];
								continue;
							}
							num2 = 9;
							goto case 9;
						case 19:
						case 35:
							goto end_IL_0267;
						case 1:
							goto end_IL_0322;
						case 9:
							return null;
						case 6:
							return null;
						case 24:
							return null;
						case 27:
							return null;
						case 29:
							return null;
						case 33:
							if (196 != (array as byte[])[num])
							{
								num2 = 28;
								goto case 28;
							}
							num2 = 16;
							goto case 16;
						case 28:
							Class10.smethod_4();
							num2 = 16;
							goto case 16;
						case 16:
						case 17:
							num++;
							return null;
						case 23:
						case 37:
							return null;
						case 39:
							return null;
						}
						num2 = ((8 == ((byte[])array)[num]) ? (byte_[133] - 219) : (byte_[172] - 51));
						continue;
						IL_0203:
						num2 = ((208 == (array as byte[])[num]) ? byte_[117] : (byte_2[98] - 117));
						continue;
						IL_0142:
						num2 = (((array as byte[])[num] < 196) ? (byte_[24] - 201) : (byte_[139] - 106));
						continue;
						end_IL_0267:
						break;
					}
					continue;
					end_IL_0322:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_4()
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			int num = 0;
			object obj = (byte[])Class12.smethod_9(Class8.smethod_8(176, 144), Class12.smethod_8(0, 1319697007, null), 964, 'ΐ');
			while ((obj as byte[])[num] >= 8)
			{
				int num2 = 15;
				while (true)
				{
					IL_038e:
					if (8 == ((byte[])obj)[num])
					{
						num2 = 31;
						goto IL_037f;
					}
					num2 = 17;
					goto IL_037a;
					IL_037f:
					while (true)
					{
						IL_037f_2:
						num++;
						num2 = 0;
						while (true)
						{
							IL_0366:
							if ((obj as byte[])[num] < 208)
							{
								num2 = byte_[165];
								goto IL_02a8;
							}
							num2 = 10;
							goto IL_025a;
							IL_0137:
							smethod_0();
							num2 = 34;
							goto IL_0147;
							IL_014f:
							if (((byte[])obj)[num] >= 196)
							{
								num2 = byte_2[38] - 144;
								goto IL_02a8;
							}
							num2 = 3;
							return;
							IL_02a8:
							while (true)
							{
								switch (num2)
								{
								case 42:
									num++;
									num2 = byte_2[9];
									continue;
								case 41:
									Class10.smethod_1();
									num2 = 20;
									goto case 8;
								case 8:
								case 20:
									num++;
									num2 = 32;
									goto case 23;
								case 23:
								case 32:
									if (((byte[])obj)[num] >= 218)
									{
										num2 = byte_2[139] - 97;
										continue;
									}
									num2 = 6;
									return;
								case 40:
									num++;
									num2 = 12;
									goto case 12;
								case 12:
									if (((byte[])obj)[num] >= 145)
									{
										num2 = byte_2[119] - 54;
										continue;
									}
									num2 = 2;
									return;
								case 39:
									break;
								case 38:
									if (196 != ((byte[])obj)[num])
									{
										num2 = 41;
										goto case 41;
									}
									num2 = byte_[35] - 2;
									continue;
								case 36:
									goto end_IL_02a8;
								case 33:
									goto IL_0137;
								case 34:
									goto IL_0147;
								case 27:
									goto IL_014f;
								case 35:
									if ((obj as byte[])[num] >= 196)
									{
										num2 = 38;
										goto case 38;
									}
									num2 = 1;
									return;
								case 29:
									goto IL_018d;
								case 11:
									goto IL_0195;
								case 25:
									if (196 != (obj as byte[])[num])
									{
										num2 = 13;
										goto case 13;
									}
									num2 = 40;
									goto case 40;
								case 13:
									Class10.smethod_3();
									num2 = byte_[28];
									continue;
								case 24:
									goto IL_01e4;
								case 18:
									num++;
									num2 = byte_[134];
									continue;
								case 16:
									Class9.smethod_0();
									num2 = 42;
									goto case 42;
								case 14:
									if (160 != (obj as byte[])[num])
									{
										num2 = 7;
										goto case 7;
									}
									num2 = byte_[13] * 6;
									continue;
								case 7:
									smethod_0();
									num2 = 18;
									goto case 18;
								case 10:
									goto IL_025a;
								case 5:
									goto IL_026c;
								case 9:
									goto IL_0284;
								default:
									return;
								case 0:
									goto IL_0366;
								case 17:
									goto end_IL_0366;
								case 31:
									goto IL_037f_2;
								case 15:
									goto IL_038e;
								case 26:
									goto end_IL_038e;
								case 4:
									return;
								case 19:
									return;
								case 28:
									Class9.smethod_4();
									num2 = 21;
									goto case 21;
								case 21:
									num++;
									return;
								case 22:
								case 30:
									return;
								case 1:
									return;
								case 3:
									return;
								case 37:
									return;
								case 2:
									return;
								case 6:
									return;
								}
								num2 = ((218 == ((byte[])obj)[num]) ? (byte_2[55] - 86) : (byte_[220] - byte_[159]));
								continue;
								IL_0284:
								num2 = ((145 == ((byte[])obj)[num]) ? (byte_2[25] - 2) : ((int)byte_2[164] / 7));
								continue;
								IL_01e4:
								num2 = ((((byte[])obj)[num] < 160) ? byte_[119] : (byte_[286] - byte_[15]));
								continue;
								end_IL_02a8:
								break;
							}
							goto IL_0127;
							IL_025a:
							if (208 != ((byte[])obj)[num])
							{
								num2 = 5;
								goto IL_026c;
							}
							num2 = 29;
							goto IL_018d;
							IL_0127:
							if (65 != ((byte[])obj)[num])
							{
								num2 = 33;
								goto IL_0137;
							}
							num2 = 34;
							goto IL_0147;
							IL_026c:
							Class9.smethod_0();
							num2 = 29;
							goto IL_018d;
							IL_0147:
							num++;
							num2 = 27;
							goto IL_014f;
							IL_018d:
							num++;
							num2 = 11;
							goto IL_0195;
							IL_0195:
							if ((obj as byte[])[num] >= 65)
							{
								num2 = 36;
								goto IL_0127;
							}
							num2 = byte_[200] + 3;
							goto IL_02a8;
							continue;
							end_IL_0366:
							break;
						}
						break;
					}
					goto IL_037a;
					IL_037a:
					Class8.smethod_1();
					goto IL_037f;
					continue;
					end_IL_038e:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static Type smethod_5()
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			while (true)
			{
				int num = 0;
				while (true)
				{
					Array array = (byte[])Class12.smethod_9(Class8.smethod_8(656, 689), Class12.smethod_8(4, 1319697003, null), 717, 'ʘ');
					int num2 = byte_2[19];
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = byte_[126] - 163;
							continue;
						case 18:
							num++;
							num2 = byte_2[340] + byte_2[165];
							continue;
						case 17:
							if (((byte[])array)[num] >= 208)
							{
								num2 = byte_2[149] - 216;
								continue;
							}
							num2 = 0;
							goto case 0;
						case 16:
							if ((array as byte[])[num] >= 8)
							{
								num2 = 13;
								goto case 13;
							}
							num2 = byte_[156] - 239;
							continue;
						case 13:
							if (8 != (array as byte[])[num])
							{
								num2 = 11;
								goto case 11;
							}
							num2 = 18;
							goto case 18;
						case 11:
							Class9.smethod_1();
							num2 = byte_2[63] - 91;
							continue;
						case 12:
							if (65 != ((byte[])array)[num])
							{
								num2 = byte_2[165];
								continue;
							}
							num2 = 5;
							goto case 5;
						case 10:
							Class8.smethod_0();
							num2 = 3;
							goto case 3;
						case 3:
							num++;
							num2 = byte_2[140] - 46;
							continue;
						case 8:
							if (208 != ((byte[])array)[num])
							{
								num2 = 10;
								goto case 10;
							}
							num2 = 3;
							goto case 3;
						case 1:
							if (((byte[])array)[num] >= 65)
							{
								num2 = 12;
								goto case 12;
							}
							num2 = 6;
							goto case 6;
						case 14:
						case 15:
							break;
						case 2:
						case 7:
							goto end_IL_0163;
						case 4:
							Class10.smethod_4();
							num2 = 5;
							goto case 5;
						case 6:
							return typeof(Class2.Class3);
						case 9:
							return typeof(BabelAttribute.Class0);
						case 5:
							num++;
							return typeof(Class4.Class5.Class7);
						case 0:
							return typeof(Struct0);
						}
						break;
					}
					continue;
					end_IL_0163:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_6()
		{
			byte[] byte_ = Class2.byte_1;
			int num = 0;
			object obj = (byte[])Class12.smethod_9(Class8.smethod_8(864, 834), Class12.smethod_8(2, 1319697005, null), 726, 'ʀ');
			while ((obj as byte[])[num] >= 8)
			{
				int num2 = 6;
				while (true)
				{
					if (8 == ((byte[])obj)[num])
					{
						switch (byte_[7])
						{
						default:
							return;
						case 6:
							break;
						case 0:
						case 2:
							goto end_IL_006a;
						case 1:
							goto IL_0084;
						case 3:
						case 4:
							return;
						case 5:
							goto IL_008c;
						case 7:
							return;
						}
						continue;
					}
					goto IL_0084;
					IL_008c:
					num++;
					return;
					IL_0084:
					Class9.smethod_2();
					goto IL_008c;
					continue;
					end_IL_006a:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static Type smethod_7()
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			while (true)
			{
				int num = 0;
				Array array = (byte[])Class12.smethod_9(Class8.smethod_8(282, 313), Class12.smethod_8(1, 1319697006, null), 312, 'ů');
				int num2 = byte_[330] - 245;
				while (true)
				{
					switch (num2)
					{
					case 22:
						num++;
						num2 = 0;
						goto case 0;
					case 0:
						num2 = (((array as byte[])[num] < 208) ? (byte_[303] - 155) : (byte_2[42] - 223));
						continue;
					case 21:
						smethod_0();
						num2 = byte_2[7] + 17;
						continue;
					case 20:
						num2 = (((array as byte[])[num] < 65) ? byte_[165] : (byte_2[11] - 88));
						continue;
					case 19:
						Class9.smethod_1();
						num2 = byte_2[47] - 167;
						continue;
					case 5:
					case 18:
						if (65 != ((byte[])array)[num])
						{
							num2 = 19;
							goto case 19;
						}
						num2 = 9;
						goto case 9;
					case 9:
						num++;
						num2 = byte_2[71] - 140;
						continue;
					case 17:
						if (208 != (array as byte[])[num])
						{
							num2 = 10;
							goto case 10;
						}
						num2 = byte_[71] - byte_[25];
						continue;
					case 10:
						smethod_0();
						num2 = (int)byte_2[9] / 4;
						continue;
					default:
						num2 = (int)byte_[122] / 5;
						continue;
					case 7:
						if (8 != (array as byte[])[num])
						{
							num2 = byte_[217] - 97;
							continue;
						}
						num2 = 22;
						goto case 22;
					case 3:
					case 6:
						num++;
						num2 = 20;
						goto case 20;
					case 1:
						if ((array as byte[])[num] >= 8)
						{
							num2 = 7;
							goto case 7;
						}
						num2 = 16;
						goto case 16;
					case 2:
						break;
					case 4:
						return typeof(Class1);
					case 8:
						if ((array as byte[])[num] >= 196)
						{
							num2 = 11;
							goto case 11;
						}
						num2 = 14;
						goto case 14;
					case 11:
					case 12:
						if (196 != (array as byte[])[num])
						{
							num2 = 24;
							goto case 24;
						}
						num2 = 23;
						goto case 23;
					case 14:
						return typeof(Class1);
					case 15:
						return typeof(Class9);
					case 16:
						return typeof(Class4.Class5);
					case 24:
						Class8.smethod_0();
						num2 = 23;
						goto case 23;
					case 23:
						num++;
						return typeof(Class4.Class5.Struct3);
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static object smethod_8()
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			while (true)
			{
				int num = 0;
				object obj = (byte[])Class12.smethod_9(Class8.smethod_8(509, 473), Class12.smethod_8(7, 1319697000, null), 745, 'ʱ');
				int num2 = 16;
				while (true)
				{
					IL_0210:
					if (((byte[])obj)[num] < 8)
					{
						num2 = byte_[192];
						goto IL_0188;
					}
					num2 = 29;
					goto IL_001e;
					IL_0188:
					while (true)
					{
						switch (num2)
						{
						case 29:
							break;
						case 27:
							Class9.smethod_3();
							goto case 23;
						case 23:
							num++;
							num2 = 24;
							goto case 24;
						case 24:
							if ((obj as byte[])[num] >= 208)
							{
								num2 = byte_2[91] - 181;
								continue;
							}
							num2 = 3;
							goto case 3;
						case 26:
							smethod_1();
							goto case 7;
						case 7:
						case 19:
							num++;
							num2 = 1;
							goto case 1;
						case 1:
							num2 = ((((byte[])obj)[num] < 196) ? (byte_[170] - 13) : byte_[35]);
							continue;
						case 25:
							if (208 != (obj as byte[])[num])
							{
								num2 = byte_[105] - byte_[32];
								continue;
							}
							num2 = 9;
							goto case 9;
						case 9:
							num++;
							num2 = 0;
							goto case 0;
						case 0:
							if ((obj as byte[])[num] >= 65)
							{
								num2 = 8;
								goto case 8;
							}
							num2 = 4;
							goto case 4;
						case 8:
							num2 = ((65 == (obj as byte[])[num]) ? (byte_2[10] - 128) : ((int)byte_[36] / 8));
							continue;
						case 22:
							if (196 != (obj as byte[])[num])
							{
								num2 = 13;
								goto case 13;
							}
							num2 = 2;
							goto case 2;
						case 13:
							Class10.smethod_3();
							num2 = byte_[203] - 65;
							continue;
						case 2:
							num++;
							num2 = 15;
							goto case 15;
						case 15:
							if (((byte[])obj)[num] >= 145)
							{
								num2 = 10;
								goto case 10;
							}
							num2 = 21;
							goto case 21;
						case 10:
							if (145 != (obj as byte[])[num])
							{
								num2 = 11;
								goto case 11;
							}
							num2 = 18;
							goto case 18;
						case 11:
							Class9.smethod_0();
							num2 = byte_[273] - byte_[103];
							continue;
						case 14:
							Class9.smethod_2();
							goto case 9;
						case 16:
							goto IL_0210;
						default:
							num2 = 5;
							goto end_IL_0210;
						case 5:
							goto end_IL_0210;
						case 12:
							return null;
						case 17:
						case 20:
							return null;
						case 18:
							num++;
							goto case 6;
						case 6:
							return null;
						case 21:
							return null;
						case 4:
							return null;
						case 3:
							return null;
						}
						break;
					}
					goto IL_001e;
					IL_001e:
					num2 = ((8 == ((byte[])obj)[num]) ? (byte_[21] - 204) : (byte_2[37] - 195));
					goto IL_0188;
					continue;
					end_IL_0210:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static Type smethod_9()
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			while (true)
			{
				int num = 0;
				while (true)
				{
					object obj = (byte[])Class12.smethod_9(Class8.smethod_8(613, 576), Class12.smethod_8(0, 1319697007, null), 605, 'Ȅ');
					int num2 = byte_[91] - 205;
					while (true)
					{
						switch (num2)
						{
						case 32:
							if (65 != ((byte[])obj)[num])
							{
								num2 = 9;
								goto case 9;
							}
							num2 = byte_2[75];
							continue;
						case 9:
							Class9.smethod_1();
							num2 = 20;
							goto case 20;
						case 20:
							num++;
							num2 = byte_2[276] - byte_2[153];
							continue;
						case 31:
							if (160 == (obj as byte[])[num])
							{
								num2 = byte_2[35];
								continue;
							}
							num2 = 28;
							goto case 28;
						case 30:
							if ((obj as byte[])[num] >= 145)
							{
								num2 = byte_2[232] - 62;
								continue;
							}
							num2 = 34;
							goto case 34;
						case 29:
							if ((obj as byte[])[num] >= 65)
							{
								num2 = byte_[174] - 35;
								continue;
							}
							num2 = 21;
							goto case 3;
						case 25:
							if (((byte[])obj)[num] >= 160)
							{
								num2 = byte_2[31];
								continue;
							}
							num2 = 2;
							goto case 2;
						case 23:
							num++;
							num2 = (int)byte_[125] / 5;
							continue;
						case 19:
							num++;
							num2 = byte_2[107] - byte_2[39];
							continue;
						case 0:
						case 18:
							Class12.smethod_0();
							num2 = byte_2[318] - 45;
							continue;
						case 17:
							num++;
							num2 = 30;
							goto case 30;
						case 16:
							Class10.smethod_4();
							num2 = 17;
							goto case 17;
						case 15:
							break;
						case 8:
							goto IL_012e;
						case 14:
							num++;
							num2 = byte_[87] - 63;
							continue;
						case 13:
							Class10.smethod_3();
							num2 = 19;
							goto case 19;
						case 12:
							if (208 != ((byte[])obj)[num])
							{
								num2 = 18;
								goto case 0;
							}
							num2 = 23;
							goto case 23;
						case 7:
							if (145 != ((byte[])obj)[num])
							{
								num2 = 4;
								goto case 4;
							}
							num2 = byte_2[289] - byte_2[338];
							continue;
						case 4:
							Class9.smethod_0();
							num2 = byte_2[172] - 13;
							continue;
						case 6:
							if ((obj as byte[])[num] >= 208)
							{
								num2 = 12;
								goto case 12;
							}
							num2 = 27;
							goto case 27;
						case 5:
							if (8 != ((byte[])obj)[num])
							{
								num2 = 13;
								goto case 13;
							}
							num2 = 19;
							goto case 19;
						case 1:
							if (((byte[])obj)[num] >= 8)
							{
								num2 = byte_2[28] - byte_2[134];
								continue;
							}
							num2 = 26;
							goto case 26;
						case 11:
							goto end_IL_0234;
						default:
							num2 = 24;
							goto end_IL_02c8;
						case 24:
							goto end_IL_02c8;
						case 2:
							return typeof(Struct5);
						case 26:
							return typeof(Struct1);
						case 27:
							return typeof(Class4.Class5.Class7);
						case 3:
						case 21:
							return typeof(Class4.Class5.Struct3);
						case 28:
							Class9.smethod_4();
							num2 = 22;
							goto case 22;
						case 22:
							num++;
							return typeof(Struct1);
						case 33:
							return typeof(Class2.Class3);
						case 34:
							return typeof(Class4.Class5.Class6);
						}
						if ((obj as byte[])[num] >= 196)
						{
							num2 = 8;
							goto IL_012e;
						}
						num2 = byte_2[136] - 57;
						continue;
						IL_012e:
						num2 = ((196 == ((byte[])obj)[num]) ? (byte_2[153] - 85) : (byte_[81] - 185));
						continue;
						end_IL_0234:
						break;
					}
					continue;
					end_IL_02c8:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static long smethod_10()
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			while (true)
			{
				int num = 0;
				while (true)
				{
					Array array = (byte[])Class12.smethod_9(Class8.smethod_8(980, 1010), Class12.smethod_8(1, 1319697006, null), 84, '\u000e');
					while (true)
					{
						int num2 = byte_2[228] - 64;
						while (true)
						{
							switch (num2)
							{
							case 8:
								break;
							case 7:
								goto IL_0034;
							default:
								num2 = byte_[25] - 44;
								continue;
							case 9:
								goto end_IL_0055;
							case 3:
								goto end_IL_0085;
							case 0:
								goto end_IL_0092;
							case 1:
								Class9.smethod_2();
								goto case 6;
							case 4:
							case 5:
								return 0L;
							case 6:
								num++;
								return 5L;
							}
							goto IL_0011;
							IL_0034:
							if (((byte[])array)[num] >= 8)
							{
								num2 = 8;
								goto IL_0011;
							}
							num2 = byte_2[37] + 2;
							continue;
							IL_0011:
							num2 = ((8 == (array as byte[])[num]) ? (byte_2[42] - 48) : (byte_2[78] - 227));
							continue;
							end_IL_0055:
							break;
						}
						continue;
						end_IL_0085:
						break;
					}
					continue;
					end_IL_0092:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static long smethod_11()
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			while (true)
			{
				int num = 0;
				Array array = (byte[])Class12.smethod_9(Class8.smethod_8(468, 499), Class12.smethod_8(2, 1319697005, null), 938, 'ϱ');
				int num2 = 4;
				while (true)
				{
					IL_0242:
					if ((array as byte[])[num] < 8)
					{
						num2 = byte_[209] - 166;
						goto IL_01bb;
					}
					num2 = 8;
					goto IL_0176;
					IL_0054:
					num++;
					num2 = byte_2[117];
					goto IL_01bb;
					IL_0184:
					Class10.smethod_2();
					num2 = 26;
					goto IL_0054;
					IL_01bb:
					while (true)
					{
						switch (num2)
						{
						case 27:
							break;
						case 26:
							goto end_IL_01bb;
						case 24:
							num++;
							num2 = byte_[3];
							continue;
						case 21:
							goto IL_006f;
						case 19:
							num++;
							num2 = 14;
							goto case 14;
						case 14:
							if (((byte[])array)[num] >= 196)
							{
								num2 = 17;
								goto case 17;
							}
							num2 = byte_2[42] - 220;
							continue;
						case 17:
							if (196 != ((byte[])array)[num])
							{
								num2 = 3;
								goto case 3;
							}
							num2 = byte_[241] - 211;
							continue;
						case 3:
							Class10.smethod_2();
							num2 = 24;
							goto case 24;
						case 18:
							if (65 != ((byte[])array)[num])
							{
								num2 = 13;
								goto case 13;
							}
							num2 = 19;
							goto case 19;
						case 13:
							Class9.smethod_1();
							num2 = 19;
							goto case 19;
						case 16:
							num2 = byte_2[126] - 168;
							continue;
						case 15:
							num++;
							goto case 16;
						case 12:
							if (((byte[])array)[num] >= 208)
							{
								num2 = 10;
								goto case 10;
							}
							num2 = byte_2[156] - 248;
							continue;
						case 10:
							if (208 != (array as byte[])[num])
							{
								num2 = 9;
								goto case 9;
							}
							num2 = 15;
							goto case 15;
						case 9:
							Class9.smethod_2();
							goto case 15;
						case 8:
							goto IL_0176;
						case 6:
							goto IL_0184;
						case 2:
							goto IL_019c;
						case 4:
							goto IL_0242;
						default:
							num2 = 23;
							goto end_IL_0242;
						case 23:
							goto end_IL_0242;
						case 0:
							return 8L;
						case 1:
							Class1.byte_1[341] = (byte)((Class1.byte_1[341] ^ Class1.byte_1[317]) & 0x4A);
							return 5L;
						case 7:
							Class8.smethod_0();
							num2 = 22;
							goto case 22;
						case 20:
							return 0L;
						case 22:
							num++;
							return 9L;
						case 25:
							return 2L;
						case 5:
						case 11:
						case 28:
							return 4L;
						}
						num2 = ((((byte[])array)[num] < 145) ? (byte_[296] - 89) : (byte_2[79] - 145));
						continue;
						IL_019c:
						num2 = ((((byte[])array)[num] < 65) ? byte_[15] : (byte_2[27] - 220));
						continue;
						IL_006f:
						num2 = ((145 == ((byte[])array)[num]) ? (byte_2[144] - 147) : (byte_2[64] - byte_2[174]));
						continue;
						end_IL_01bb:
						break;
					}
					goto IL_0054;
					IL_0176:
					if (8 != ((byte[])array)[num])
					{
						num2 = 6;
						goto IL_0184;
					}
					num2 = byte_2[161];
					goto IL_01bb;
					continue;
					end_IL_0242:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static object smethod_12()
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			while (true)
			{
				int num = 0;
				object obj = (byte[])Class12.smethod_9(Class8.smethod_8(281, 305), Class12.smethod_8(7, 1319697000, null), 316, 'Š');
				int num2 = byte_[139];
				while (true)
				{
					switch (num2)
					{
					case 43:
						if (196 != ((byte[])obj)[num])
						{
							num2 = 21;
							goto case 21;
						}
						num2 = byte_[134];
						continue;
					case 21:
						smethod_1();
						goto case 35;
					case 35:
						num++;
						num2 = 7;
						goto case 7;
					case 7:
						if ((obj as byte[])[num] >= 218)
						{
							num2 = 23;
							goto case 23;
						}
						num2 = byte_[52] - 171;
						continue;
					case 23:
						if (218 != ((byte[])obj)[num])
						{
							num2 = 18;
							goto case 18;
						}
						num2 = byte_[200];
						continue;
					case 18:
						Class8.smethod_0();
						num2 = byte_2[86] - 150;
						continue;
					case 42:
						if (208 != (obj as byte[])[num])
						{
							num2 = (int)byte_2[0] / 5;
							continue;
						}
						num2 = 20;
						goto case 20;
					case 20:
						num++;
						num2 = 15;
						goto case 15;
					case 15:
						if (((byte[])obj)[num] >= 65)
						{
							num2 = byte_2[175] - byte_2[72];
							continue;
						}
						num2 = 33;
						goto case 33;
					case 40:
						num++;
						num2 = 10;
						goto case 10;
					case 10:
					case 16:
						if ((obj as byte[])[num] >= 196)
						{
							num2 = 43;
							goto case 43;
						}
						num2 = byte_[83];
						continue;
					case 38:
						Class10.smethod_1();
						num2 = byte_[272] - 12;
						continue;
					default:
						num2 = byte_[286];
						continue;
					case 36:
						num++;
						num2 = 9;
						goto case 9;
					case 9:
						if (((byte[])obj)[num] >= 145)
						{
							num2 = 27;
							goto case 27;
						}
						num2 = 28;
						goto case 28;
					case 27:
						if (145 != (obj as byte[])[num])
						{
							num2 = 14;
							goto case 14;
						}
						num2 = 8;
						goto case 8;
					case 14:
						smethod_0();
						num2 = byte_[212] - 47;
						continue;
					case 8:
						num++;
						num2 = byte_[184] - byte_[184];
						continue;
					case 0:
					case 31:
						if (((byte[])obj)[num] >= 160)
						{
							num2 = 26;
							goto case 26;
						}
						num2 = 11;
						goto case 11;
					case 26:
						if (160 != (obj as byte[])[num])
						{
							num2 = 24;
							goto case 24;
						}
						num2 = byte_[229] - 167;
						continue;
					case 24:
						Class9.smethod_2();
						goto case 40;
					case 30:
						num2 = ((8 == (obj as byte[])[num]) ? (byte_2[144] - 167) : ((int)byte_[240] / 2));
						continue;
					case 29:
						smethod_1();
						goto case 2;
					case 2:
						num++;
						num2 = 6;
						goto case 6;
					case 6:
						if (((byte[])obj)[num] >= 208)
						{
							num2 = byte_[301] - 29;
							continue;
						}
						num2 = 13;
						goto case 13;
					case 25:
						if (((byte[])obj)[num] >= 196)
						{
							num2 = 3;
							goto case 3;
						}
						num2 = (int)byte_[264] / 4;
						continue;
					case 3:
						if (196 != ((byte[])obj)[num])
						{
							num2 = 38;
							goto case 38;
						}
						num2 = byte_2[83];
						continue;
					case 12:
					case 22:
						smethod_1();
						goto case 5;
					case 5:
						num++;
						num2 = 25;
						goto case 25;
					case 19:
						if ((obj as byte[])[num] >= 8)
						{
							num2 = byte_[184] - 36;
							continue;
						}
						num2 = 44;
						goto case 44;
					case 17:
						Class12.smethod_0();
						num2 = 20;
						goto case 20;
					case 4:
						if (65 != (obj as byte[])[num])
						{
							num2 = byte_[35];
							continue;
						}
						num2 = 5;
						goto case 5;
					case 39:
						break;
					case 1:
						return null;
					case 13:
						return null;
					case 11:
						return null;
					case 32:
						return null;
					case 34:
						num++;
						return null;
					case 28:
						return null;
					case 41:
						return null;
					case 33:
						return null;
					case 44:
						return null;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static string smethod_13(string string_0, string string_1, char char_0, short short_0)
		{
			byte[] byte_ = Class2.byte_1;
			while (true)
			{
				int num = 0;
				int num2 = 6;
				while (true)
				{
					IEquatable<string> equatable = string_0 + string_1;
					num++;
					num2 = byte_[2] - byte_[24];
					while (true)
					{
						switch (num2)
						{
						case 1:
						case 5:
						{
							int num3 = short_0 * short_0;
							num3 = short_0 + num3;
							if (num3 % 2 != 0)
							{
								num2 = (int)byte_[117] / 2;
								continue;
							}
							num2 = 0;
							goto case 0;
						}
						case 6:
						case 7:
							break;
						default:
							num2 = 2;
							goto end_IL_0048;
						case 2:
							goto end_IL_0048;
						case 0:
						case 4:
							return equatable as string;
						}
						break;
					}
					continue;
					end_IL_0048:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static DialogResult smethod_14(string string_0, int int_0, char char_0)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			byte[] byte_ = Class1.byte_1;
			DialogResult result = default(DialogResult);
			int num3 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = byte_[13];
				while (true)
				{
					switch (num2)
					{
					default:
						num2 = byte_[165];
						continue;
					case 3:
						result = MessageBox.Show(string_0);
						num++;
						num3 = char_0 * char_0;
						num2 = 6;
						goto case 0;
					case 0:
					case 6:
					{
						num3 = char_0 + num3;
						int num4 = num3 % 2;
						Class2.byte_1[142] = (byte)((Class2.byte_1[142] ^ int_0) & 0xC1);
						if (num4 != 0)
						{
							num2 = 3;
							goto case 3;
						}
						num2 = (int)byte_[19] / 8;
						continue;
					}
					case 4:
					case 5:
						break;
					case 1:
					case 2:
						return result;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static long smethod_15(Stream stream_0, char char_0, int int_0)
		{
			byte[] byte_ = Class2.byte_1;
			while (true)
			{
				int num = 0;
				int num2 = 1;
				while (true)
				{
					long length = stream_0.Length;
					while (true)
					{
						num++;
						num2 = (((char_0 * char_0 + char_0) % 2 != 0) ? byte_[7] : (byte_[182] - 157));
						while (true)
						{
							switch (num2)
							{
							default:
								num2 = byte_[78] - 36;
								continue;
							case 3:
								break;
							case 5:
								num2 = 1;
								goto end_IL_004e;
							case 0:
							case 1:
								goto end_IL_004e;
							case 7:
								goto end_IL_005f;
							case 4:
							case 6:
								return length;
							}
							break;
						}
						continue;
						end_IL_004e:
						break;
					}
					continue;
					end_IL_005f:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static Assembly smethod_16(int int_0, short short_0)
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			object executingAssembly = default(object);
			while (true)
			{
				int num = 0;
				int num2 = byte_2[40] - 12;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_000e;
					case 0:
					case 1:
						break;
					case 4:
					{
						executingAssembly = Assembly.GetExecutingAssembly();
						int num3 = num;
						Class1.byte_1[86] = (byte)((Class1.byte_1[86] - int_0) & 0x4F);
						num = num3 + 1;
						if ((short_0 * short_0 + short_0) % 2 != 0)
						{
							num2 = 6;
							goto case 2;
						}
						num2 = 3;
						goto case 3;
					}
					case 2:
					case 6:
						num2 = 4;
						goto case 4;
					case 3:
						return executingAssembly as Assembly;
					}
					break;
					IL_000e:
					num2 = byte_[120] - 128;
				}
			}
		}

		[SecuritySafeCritical]
		internal static MethodInfo smethod_17(Assembly assembly_0, char char_0, int int_0)
		{
			byte[] byte_ = Class2.byte_1;
			int num2 = default(int);
			_MethodInfo entryPoint = default(_MethodInfo);
			while (true)
			{
				int num = 0;
				int num3;
				switch (byte_[200])
				{
				default:
					goto IL_0008;
				case 223:
					continue;
				case 224:
					num2 = char_0 + num2;
					if (num2 % 2 != 0)
					{
						num3 = 6;
						goto case 229;
					}
					num3 = 4;
					break;
				case 229:
					entryPoint = (_MethodInfo)(object)assembly_0.EntryPoint;
					goto case 228;
				case 228:
					num++;
					num2 = char_0 * char_0;
					goto case 230;
				case 230:
					num3 = 1;
					goto case 224;
				case 226:
				case 227:
					break;
				}
				break;
				IL_0008:
				num3 = 0;
			}
			return entryPoint as MethodInfo;
		}

		[SecuritySafeCritical]
		internal static int smethod_18(string string_0, int int_0, short short_0)
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			int num3 = default(int);
			int length = default(int);
			while (true)
			{
				int num = 0;
				int num2 = byte_[47] - 64;
				while (true)
				{
					switch (num2)
					{
					case 2:
						num++;
						num3 = 1293;
						num2 = 4;
						goto case 4;
					case 4:
						if (431 >= num3 / 3 - 77)
						{
							goto IL_0035;
						}
						num2 = 5;
						goto case 5;
					case 5:
					case 7:
						length = string_0.Length;
						goto case 2;
					default:
						num2 = 0;
						break;
					case 0:
						break;
					case 1:
					case 3:
						return length;
					}
					break;
					IL_0035:
					num2 = (int)byte_2[9] / 8;
				}
			}
		}
	}

	internal sealed class Class12
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 224)]
		private struct Struct6
		{
		}

		private static readonly char[] char_0;

		private static readonly Array array_0;

		private static readonly Array array_1;

		internal static Struct6 struct6_0/* Not supported: data(56 0E 56 0E 56 0E 76 0E B5 0B 3A 2B 58 0C 3F 3D 23 26 51 37 4E 1B 1B 06 B5 0B 3A 2B 5B 0C 6D 3D 75 26 04 37 19 1B 4B 06 EF 0B 36 2B 08 0C 33 3D 22 26 54 37 4D 1B 19 06 EF 0B 36 2B 0A 0C 68 3D 77 26 06 37 41 1B 4A 06 B5 44 B4 44 B4 44 90 44 C1 6C E0 7D A3 51 F9 4C 57 41 D8 61 BC 46 DB 77 8E 6C BD 7D AE 51 FE 4C 0C 41 C0 61 EB 46 DE 77 C5 6C E0 7D B7 51 F9 4C 05 41 DD 61 EF 46 C4 77 95 6C E6 7D AE 51 AC 4C 0D 41 D8 61 E8 46 8F 77 C6 6C B7 7D A2 51 AC 4C 07 7C 05 7C 05 7C 25 7C 27 54 52 45 1D 69 4A 74 B4 79 3E 59 5E 7E 60 4F 71 54 05 45 18 69 4A 74 B0 79 6D 59 08 7E 6B 4F 70 54 00 45 1A 69 1B 74 E5 79 39 59 5F 7E 6C 4F 70 54 01 45 18 69 4B 74 E7 79 6A 59 0D 7E 3E 4F) */;

		internal static int smethod_0()
		{
			byte[] byte_ = Class1.byte_1;
			while (true)
			{
				int num = 3052009;
				num = 3053756;
				int num2 = 2;
				while (true)
				{
					if (num % 2 == 0)
					{
						num2 = 0;
						while (true)
						{
							smethod_0();
							num2 = byte_[165];
							while (true)
							{
								switch (num2)
								{
								default:
									num2 = byte_[301] - 64;
									continue;
								case 0:
								case 5:
								case 6:
									break;
								case 2:
								case 3:
									goto end_IL_003f;
								case 7:
									goto end_IL_004f;
								case 4:
									goto IL_0068;
								}
								break;
							}
							continue;
							end_IL_003f:
							break;
						}
						continue;
					}
					num2 = 4;
					goto IL_0068;
					IL_0068:
					return 15;
					continue;
					end_IL_004f:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static int smethod_1()
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			while (true)
			{
				int num = 0;
				Array array = (byte[])smethod_9(Class8.smethod_8(390, 431), smethod_8(8, 1319696999, null), 540, 'ɼ');
				int num2 = byte_[0] - 82;
				while (true)
				{
					switch (num2)
					{
					case 5:
						if (8 != ((byte[])array)[num])
						{
							num2 = byte_2[66] - 64;
							continue;
						}
						num2 = 2;
						goto case 2;
					case 3:
						num2 = (((array as byte[])[num] < 8) ? (byte_[182] - 155) : (byte_2[162] - 121));
						continue;
					default:
						num2 = 4;
						break;
					case 4:
						break;
					case 1:
						Class8.smethod_1();
						goto case 2;
					case 2:
						num++;
						goto case 8;
					case 8:
						return 1;
					case 6:
					case 7:
					case 9:
						return 7;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static long smethod_2()
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			while (true)
			{
				int num = 0;
				object obj = (byte[])smethod_9(Class8.smethod_8(226, 205), smethod_8(2, 1319697005, null), 597, 'ȴ');
				int num2 = 11;
				while (true)
				{
					num2 = ((((byte[])obj)[num] >= 8) ? (byte_[9] - 23) : (byte_2[48] - 223));
					while (true)
					{
						switch (num2)
						{
						case 24:
							Class10.smethod_4();
							num2 = byte_2[35];
							continue;
						case 23:
							if (208 != (obj as byte[])[num])
							{
								num2 = 18;
								goto case 7;
							}
							num2 = (int)byte_[62] / 3;
							continue;
						case 7:
						case 18:
							Class9.smethod_3();
							goto case 16;
						case 16:
							num++;
							num2 = 21;
							goto case 21;
						case 21:
							if (((byte[])obj)[num] >= 65)
							{
								num2 = 4;
								goto case 4;
							}
							num2 = byte_[79] - 151;
							continue;
						case 4:
							num2 = ((65 == (obj as byte[])[num]) ? byte_[85] : (byte_[1] - byte_[110]));
							continue;
						case 22:
							num++;
							num2 = 12;
							goto case 12;
						case 12:
							if ((obj as byte[])[num] >= 208)
							{
								num2 = byte_[201] - 112;
								continue;
							}
							num2 = 14;
							goto case 14;
						case 20:
							Class10.smethod_2();
							num2 = 10;
							goto case 10;
						case 10:
							num++;
							num2 = 17;
							goto case 17;
						case 17:
							if ((obj as byte[])[num] >= 196)
							{
								num2 = byte_[160] - 176;
								continue;
							}
							num2 = 19;
							goto case 19;
						case 9:
							if (196 == ((byte[])obj)[num])
							{
								num2 = byte_2[159] - 59;
								continue;
							}
							num2 = 3;
							goto case 3;
						case 1:
							break;
						case 6:
						case 11:
							goto end_IL_0146;
						default:
							num2 = 0;
							goto end_IL_01bc;
						case 0:
							goto end_IL_01bc;
						case 3:
							Class11.smethod_1();
							goto case 2;
						case 2:
							num++;
							goto case 8;
						case 8:
							return 4L;
						case 13:
							return 5L;
						case 15:
							return 6L;
						case 19:
							return 15L;
						case 14:
							return 15L;
						}
						num2 = ((8 == ((byte[])obj)[num]) ? (byte_[160] - 163) : (byte_2[279] - 132));
						continue;
						end_IL_0146:
						break;
					}
					continue;
					end_IL_01bc:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_3()
		{
			int num = 0;
			Array array = (byte[])smethod_9(Class8.smethod_8(649, 697), smethod_8(3, 1319697004, null), 639, 'ȝ');
			if ((array as byte[])[0] < 8)
			{
				return;
			}
			if (8 != (array as byte[])[num])
			{
				Class9.smethod_0();
			}
			num++;
			if ((array as byte[])[num] >= 208)
			{
				if (208 != ((byte[])array)[num])
				{
					Class10.smethod_4();
				}
				num++;
			}
		}

		[SecuritySafeCritical]
		internal static string smethod_4()
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			while (true)
			{
				int num = 0;
				Array array = (byte[])smethod_9(Class8.smethod_8(872, 857), smethod_8(3, 1319697004, null), 161, 'Â');
				int num2 = byte_[158];
				while (true)
				{
					switch (num2)
					{
					case 44:
						if (145 != (array as byte[])[num])
						{
							num2 = 22;
							goto case 22;
						}
						num2 = 21;
						goto case 21;
					case 22:
						smethod_0();
						num2 = byte_2[45] - 42;
						continue;
					case 21:
						num++;
						num2 = 33;
						goto case 33;
					case 33:
						if ((array as byte[])[num] >= 160)
						{
							num2 = 35;
							goto case 35;
						}
						num2 = 20;
						goto case 20;
					case 35:
						if (160 != (array as byte[])[num])
						{
							num2 = byte_[190] - byte_[240];
							continue;
						}
						num2 = 41;
						goto case 41;
					case 41:
						num++;
						num2 = 5;
						goto case 5;
					case 5:
						if (((byte[])array)[num] >= 196)
						{
							num2 = 31;
							goto case 31;
						}
						num2 = 15;
						goto case 15;
					case 31:
						num2 = ((196 == (array as byte[])[num]) ? (byte_[246] - 126) : (byte_[123] - 139));
						continue;
					case 43:
						Class11.smethod_0();
						num2 = 39;
						goto case 39;
					case 39:
						num++;
						num2 = 17;
						goto case 17;
					case 17:
						if (((byte[])array)[num] >= 218)
						{
							num2 = 19;
							goto case 19;
						}
						num2 = 12;
						goto case 12;
					case 19:
						num2 = ((218 == ((byte[])array)[num]) ? byte_2[167] : byte_2[85]);
						continue;
					case 38:
						if ((array as byte[])[num] >= 145)
						{
							num2 = byte_2[63] + 20;
							continue;
						}
						num2 = 13;
						goto case 13;
					case 37:
						smethod_0();
						num2 = 32;
						goto case 32;
					case 32:
						num++;
						num2 = 0;
						goto case 0;
					case 0:
						if (((byte[])array)[num] >= 65)
						{
							num2 = 27;
							goto case 27;
						}
						num2 = 23;
						goto case 23;
					case 27:
						if (65 != ((byte[])array)[num])
						{
							num2 = 1;
							goto case 1;
						}
						num2 = byte_2[106];
						continue;
					case 1:
						Class10.smethod_0();
						num2 = 14;
						goto case 14;
					case 14:
						num++;
						num2 = byte_2[27] - 210;
						continue;
					case 30:
						Class10.smethod_4();
						num2 = byte_2[155] - 77;
						continue;
					case 9:
					case 28:
						if (((byte[])array)[num] >= 196)
						{
							num2 = byte_2[119] - 56;
							continue;
						}
						num2 = 2;
						goto case 2;
					case 26:
						Class10.smethod_2();
						num2 = 41;
						goto case 41;
					case 25:
						if (((byte[])array)[num] >= 208)
						{
							num2 = 16;
							goto case 16;
						}
						num2 = 42;
						goto case 42;
					case 16:
						if (208 != ((byte[])array)[num])
						{
							num2 = 37;
							goto case 37;
						}
						num2 = byte_2[44] - 81;
						continue;
					case 24:
						Class10.smethod_3();
						num2 = 4;
						goto case 4;
					case 4:
						num++;
						num2 = 38;
						goto case 38;
					case 7:
					case 18:
						if (196 != (array as byte[])[num])
						{
							num2 = byte_[192] * 2;
							continue;
						}
						num2 = 4;
						goto case 4;
					case 11:
						if (((byte[])array)[num] >= 8)
						{
							num2 = 8;
							goto case 8;
						}
						num2 = 36;
						goto case 36;
					case 8:
						if (8 != (array as byte[])[num])
						{
							num2 = 30;
							goto case 30;
						}
						num2 = 3;
						goto case 3;
					case 3:
						num++;
						num2 = 25;
						goto case 25;
					default:
						num2 = 6;
						break;
					case 6:
						break;
					case 10:
						smethod_0();
						num2 = 40;
						goto case 40;
					case 2:
					case 34:
						return null;
					case 36:
						return null;
					case 23:
						return null;
					case 13:
						return null;
					case 40:
						num++;
						return null;
					case 42:
						return null;
					case 12:
						return null;
					case 15:
						return null;
					case 20:
						return null;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static long smethod_5()
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			while (true)
			{
				int num = 0;
				Array array = (byte[])smethod_9(Class8.smethod_8(1, 51), smethod_8(0, 1319697007, null), 499, 'Ɨ');
				while (true)
				{
					int num2 = byte_[165];
					while (true)
					{
						switch (num2)
						{
						case 39:
							if (((byte[])array)[num] >= 160)
							{
								num2 = 6;
								goto case 6;
							}
							num2 = 12;
							goto case 12;
						case 6:
							if (160 != ((byte[])array)[num])
							{
								num2 = 0;
								goto case 0;
							}
							num2 = byte_[3];
							continue;
						case 0:
							Class9.smethod_1();
							num2 = byte_[3];
							continue;
						case 37:
							if (((byte[])array)[num] >= 65)
							{
								num2 = byte_[4] - 69;
								continue;
							}
							num2 = 35;
							goto case 35;
						case 36:
							if (145 != (array as byte[])[num])
							{
								num2 = byte_[139];
								continue;
							}
							num2 = 14;
							goto case 14;
						case 14:
							num++;
							num2 = 39;
							goto case 39;
						case 34:
							if (196 == (array as byte[])[num])
							{
								num2 = byte_[322] - 150;
								continue;
							}
							num2 = 24;
							goto case 24;
						case 3:
						case 31:
							num++;
							num2 = 21;
							goto case 21;
						case 21:
							if (((byte[])array)[num] >= 208)
							{
								num2 = 13;
								goto case 13;
							}
							num2 = 7;
							goto case 7;
						case 13:
							if (208 != (array as byte[])[num])
							{
								num2 = 5;
								goto case 5;
							}
							num2 = 10;
							goto case 10;
						case 5:
							Class9.smethod_2();
							goto case 10;
						case 10:
							num++;
							num2 = 37;
							goto case 37;
						case 30:
							if (((byte[])array)[num] >= 196)
							{
								num2 = 8;
								goto case 8;
							}
							num2 = byte_[192] + 21;
							continue;
						case 8:
							if (196 != ((byte[])array)[num])
							{
								num2 = byte_2[161] - 11;
								continue;
							}
							num2 = 2;
							goto case 2;
						case 2:
							num++;
							num2 = byte_2[100] - 144;
							continue;
						case 29:
							if ((array as byte[])[num] >= 196)
							{
								num2 = 34;
								goto case 34;
							}
							num2 = 16;
							goto case 16;
						case 27:
							num++;
							num2 = 29;
							goto case 29;
						case 26:
							if (65 != ((byte[])array)[num])
							{
								num2 = 9;
								goto case 9;
							}
							num2 = 25;
							goto case 25;
						case 9:
							Class9.smethod_3();
							goto case 25;
						case 25:
							num++;
							num2 = byte_2[62] - 18;
							continue;
						case 23:
							if (8 != (array as byte[])[num])
							{
								num2 = byte_2[42] - 218;
								continue;
							}
							num2 = 3;
							goto case 3;
						case 22:
							Class9.smethod_1();
							num2 = byte_2[81] - 198;
							continue;
						case 19:
							Class9.smethod_4();
							num2 = 14;
							goto case 14;
						default:
							num2 = byte_[172] + byte_[158];
							continue;
						case 15:
							Class9.smethod_2();
							goto case 2;
						case 11:
							if (((byte[])array)[num] >= 145)
							{
								num2 = 36;
								goto case 36;
							}
							num2 = 28;
							goto case 28;
						case 4:
							break;
						case 32:
							goto end_IL_023f;
						case 38:
							goto end_IL_02ea;
						case 20:
							return 11L;
						case 28:
							return 12L;
						case 16:
							return 12L;
						case 7:
							return 11L;
						case 17:
						case 33:
							return 6L;
						case 24:
							Class8.smethod_1();
							goto case 1;
						case 1:
							num++;
							return 9L;
						case 35:
							return 9L;
						case 12:
							Class1.byte_1[108] = (byte)((Class1.byte_1[108] - Class1.byte_1[107]) & 0x4B);
							return 12L;
						}
						num2 = ((((byte[])array)[num] < 8) ? byte_[75] : (byte_2[90] - 12));
						continue;
						end_IL_023f:
						break;
					}
					continue;
					end_IL_02ea:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static byte smethod_6()
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			while (true)
			{
				int num = 0;
				Array array = (byte[])smethod_9(Class8.smethod_8(483, 464), smethod_8(6, 1319697001, null), 711, 'ʢ');
				int num2 = byte_[40] - 243;
				while (true)
				{
					switch (num2)
					{
					case 12:
					case 44:
						num++;
						num2 = 35;
						goto case 35;
					case 35:
						if ((array as byte[])[num] >= 208)
						{
							num2 = byte_[42] - byte_[2];
							continue;
						}
						num2 = 0;
						goto case 0;
					case 42:
						num2 = ((145 == ((byte[])array)[num]) ? byte_2[19] : (byte_[145] - 213));
						continue;
					case 38:
						num++;
						num2 = byte_2[258] - 57;
						continue;
					case 37:
						if (((byte[])array)[num] >= 196)
						{
							num2 = 26;
							goto case 26;
						}
						num2 = 23;
						goto case 23;
					case 26:
						if (196 != (array as byte[])[num])
						{
							num2 = byte_[165] - 48;
							continue;
						}
						num2 = 19;
						goto case 19;
					case 19:
						num++;
						num2 = byte_2[153] - byte_2[324];
						continue;
					case 36:
						Class10.smethod_3();
						num2 = byte_2[29] - 82;
						continue;
					case 34:
						Class10.smethod_2();
						num2 = 19;
						goto case 19;
					case 33:
						num2 = byte_2[240] - 51;
						continue;
					case 31:
						num2 = ((160 == ((byte[])array)[num]) ? (byte_2[192] + 10) : (byte_[27] - 235));
						continue;
					case 30:
						Class10.smethod_1();
						num2 = 44;
						goto case 12;
					case 28:
						if (((byte[])array)[num] >= 145)
						{
							num2 = 42;
							goto case 42;
						}
						num2 = 43;
						goto case 43;
					case 25:
						if (((byte[])array)[num] >= 65)
						{
							num2 = byte_2[239] + 5;
							continue;
						}
						num2 = 2;
						goto case 2;
					case 24:
						if (65 != ((byte[])array)[num])
						{
							num2 = 8;
							goto case 8;
						}
						num2 = 38;
						goto case 38;
					case 8:
						Class8.smethod_0();
						num2 = byte_2[224] - 190;
						continue;
					case 22:
						num++;
						num2 = 20;
						goto case 20;
					case 20:
						if (((byte[])array)[num] >= 196)
						{
							num2 = 1;
							goto case 1;
						}
						num2 = byte_[167] - 27;
						continue;
					case 1:
						if (196 != ((byte[])array)[num])
						{
							num2 = 36;
							goto case 36;
						}
						num2 = byte_[57] - 52;
						continue;
					case 21:
						num++;
						goto case 33;
					case 18:
						if (8 != ((byte[])array)[num])
						{
							num2 = 30;
							goto case 30;
						}
						num2 = 44;
						goto case 12;
					case 17:
						Class10.smethod_0();
						num2 = 16;
						goto case 16;
					case 16:
						num++;
						num2 = byte_2[232] - byte_2[42];
						continue;
					case 15:
						if ((array as byte[])[num] >= 160)
						{
							num2 = 31;
							goto case 31;
						}
						num2 = byte_2[165];
						continue;
					case 14:
						num++;
						num2 = byte_[190] - 40;
						continue;
					case 11:
						Class9.smethod_0();
						num2 = 14;
						goto case 14;
					case 10:
						if (((byte[])array)[num] >= 8)
						{
							num2 = 18;
							goto case 18;
						}
						num2 = 40;
						goto case 40;
					case 9:
						if (208 != (array as byte[])[num])
						{
							num2 = 11;
							goto case 11;
						}
						num2 = byte_[106];
						continue;
					case 3:
						Class8.smethod_0();
						num2 = 22;
						goto case 22;
					default:
						num2 = 6;
						break;
					case 6:
						break;
					case 4:
						return 23;
					case 13:
						return 7;
					case 2:
						return 1;
					case 7:
					case 32:
						if (((byte[])array)[num] >= 218)
						{
							num2 = 39;
							goto case 39;
						}
						num2 = 29;
						goto case 29;
					case 29:
						return 15;
					case 23:
						return 24;
					case 39:
						if (218 != (array as byte[])[num])
						{
							num2 = 5;
							goto case 5;
						}
						num2 = 41;
						goto case 41;
					case 5:
						Class9.smethod_1();
						num2 = 41;
						goto case 41;
					case 40:
						return 28;
					case 41:
						num++;
						return 3;
					case 43:
						return 5;
					case 0:
						return 20;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static long smethod_7()
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			while (true)
			{
				int num = 0;
				Array array = (byte[])smethod_9(Class8.smethod_8(79, 123), smethod_8(7, 1319697000, null), 280, 'ž');
				int num2 = 33;
				while (true)
				{
					if (((byte[])array)[num] >= 8)
					{
						num2 = 20;
						while (true)
						{
							IL_0296:
							if (8 == (array as byte[])[num])
							{
								num2 = 8;
								goto IL_0280;
							}
							num2 = byte_[192];
							goto IL_01af;
							IL_032c:
							return 14L;
							IL_01af:
							while (true)
							{
								switch (num2)
								{
								case 32:
									num++;
									num2 = byte_2[119] - byte_2[45];
									continue;
								case 0:
								case 31:
									if (((byte[])array)[num] >= 160)
									{
										num2 = 15;
										goto case 15;
									}
									num2 = byte_2[167] - 36;
									continue;
								case 15:
									if (160 != (array as byte[])[num])
									{
										num2 = (int)byte_[207] / 7;
										continue;
									}
									num2 = 23;
									goto case 23;
								case 28:
									if (145 != (array as byte[])[num])
									{
										num2 = 7;
										goto case 7;
									}
									num2 = (int)byte_2[70] / 3;
									continue;
								case 7:
									Class10.smethod_3();
									num2 = 32;
									goto case 32;
								case 27:
									Class10.smethod_2();
									num2 = byte_2[40] - 230;
									continue;
								case 26:
									if (((byte[])array)[num] >= 65)
									{
										num2 = 19;
										goto case 19;
									}
									num2 = byte_[119];
									continue;
								case 19:
									if (65 != (array as byte[])[num])
									{
										num2 = 16;
										goto case 16;
									}
									num2 = 5;
									goto case 5;
								case 16:
									Class9.smethod_4();
									num2 = byte_[248] - byte_[71];
									continue;
								case 5:
									num++;
									num2 = 21;
									goto case 21;
								case 21:
									if (((byte[])array)[num] >= 196)
									{
										num2 = 10;
										goto case 10;
									}
									num2 = 14;
									goto case 14;
								case 10:
									if (196 != (array as byte[])[num])
									{
										num2 = 3;
										goto case 3;
									}
									num2 = byte_2[16] - 105;
									continue;
								case 3:
									Class10.smethod_2();
									num2 = 11;
									goto case 11;
								case 11:
									num++;
									num2 = (int)byte_2[117] / 6;
									continue;
								case 18:
								case 22:
									break;
								case 9:
									goto IL_0163;
								default:
									num2 = byte_[196] - 108;
									continue;
								case 2:
									goto IL_0181;
								case 6:
									goto IL_024e;
								case 17:
									goto IL_0263;
								case 12:
									Class9.smethod_3();
									goto IL_0280;
								case 8:
									goto IL_0280;
								case 20:
									goto IL_0296;
								case 33:
									goto end_IL_0296;
								case 29:
									goto end_IL_02a7;
								case 4:
								case 24:
									return 7L;
								case 25:
									return 5L;
								case 14:
									return 11L;
								case 30:
									return 7L;
								case 23:
									num++;
									return 11L;
								case 34:
									goto IL_032c;
								case 1:
									goto IL_0338;
								}
								break;
								IL_0181:
								num2 = ((((byte[])array)[num] < 145) ? (byte_2[133] - 219) : (byte_[227] - 218));
							}
							goto IL_015e;
							IL_0280:
							num++;
							num2 = 17;
							goto IL_0263;
							IL_0263:
							if ((array as byte[])[num] >= 208)
							{
								num2 = 6;
								goto IL_024e;
							}
							num2 = 34;
							goto IL_032c;
							IL_015e:
							Class8.smethod_1();
							goto IL_0163;
							IL_024e:
							if (208 == (array as byte[])[num])
							{
								num2 = byte_[260] - 27;
								goto IL_01af;
							}
							num2 = 18;
							goto IL_015e;
							IL_0163:
							num++;
							num2 = byte_[262] - 91;
							goto IL_01af;
							continue;
							end_IL_0296:
							break;
						}
						continue;
					}
					num2 = 1;
					goto IL_0338;
					IL_0338:
					return 3L;
					continue;
					end_IL_02a7:
					break;
				}
			}
		}

		internal static string smethod_8(int int_0, int int_1, Class12 class12_0)
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			char c = default(char);
			Array array = default(Array);
			int num4 = default(int);
			int num6 = default(int);
			object obj3 = default(object);
			int num9 = default(int);
			Array array2 = default(Array);
			int num8 = default(int);
			int num7 = default(int);
			int num5 = default(int);
			while (true)
			{
				int num = int_1 ^ 0x4EA8FA6F ^ int_0;
				while (true)
				{
					object obj = array_0;
					char[] obj2 = (char[])obj;
					int num2 = obj2[num + 1];
					num2 = obj2[num] ^ num2;
					int num3 = 6;
					while (true)
					{
						IEquatable<string> equatable;
						if ((equatable = ((string[])array_1)[num2]) == null)
						{
							num3 = (int)byte_[19] / 2;
							while (true)
							{
								switch (num3)
								{
								case 16:
									c = ((char[])array)[num4 + 1];
									num6 = (array as char[])[num4 + 2] ^ c;
									num3 = byte_2[7] + 2;
									continue;
								case 4:
									((char[])obj3)[num9] = (char)(c ^ ((char[])array)[num4 + num9] ^ ((char[])array2)[(num9 + num4) % num8]);
									num3 = 5;
									goto case 5;
								case 5:
									num9++;
									num3 = 14;
									goto case 14;
								case 14:
									if (num9 < num7)
									{
										num3 = 4;
										goto case 4;
									}
									num3 = byte_2[102] - byte_2[25];
									continue;
								case 3:
								case 12:
									num7 = num5 | (num6 << 16);
									num8 = (array2 as char[]).Length;
									num3 = 2;
									goto case 2;
								case 2:
									obj3 = new char[num7];
									num9 = 0;
									goto case 0;
								case 0:
									num3 = 14;
									goto case 14;
								case 8:
								{
									char[] obj4 = (char[])obj;
									char[] obj5 = char_0;
									num4 = num;
									array2 = obj5;
									array = obj4;
									num3 = 16;
									goto case 16;
								}
								case 7:
									num5 = (array as char[])[num4 + 3] ^ c;
									num4 += 4;
									num3 = 12;
									goto case 3;
								case 6:
									break;
								case 10:
									goto end_IL_0142;
								default:
									num3 = 11;
									goto end_IL_0159;
								case 11:
									goto end_IL_0159;
								case 1:
									goto IL_018a;
								case 13:
									equatable = new string((char[])obj3);
									((string[])array_1)[num2] = equatable as string;
									num3 = 9;
									goto case 9;
								case 9:
									return (string)equatable;
								}
								break;
							}
							continue;
						}
						num3 = 1;
						goto IL_018a;
						IL_018a:
						return (string)equatable;
						continue;
						end_IL_0142:
						break;
					}
					continue;
					end_IL_0159:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static object smethod_9(AppDomain appDomain_0, string string_0, short short_0, char char_1)
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			object result = default(object);
			while (true)
			{
				int num = 0;
				int num2 = (int)byte_[164] / 4;
				while (true)
				{
					switch (num2)
					{
					case 42:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 17:
					case 34:
						num++;
						if ((char_1 * char_1 + char_1) % 2 != 0)
						{
							num2 = 2;
							goto case 2;
						}
						num2 = 14;
						goto case 14;
					case 2:
						num2 = byte_[182] - 133;
						continue;
					default:
						num2 = byte_[118] - 23;
						continue;
					case 40:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 39:
						result = appDomain_0.GetData(string_0);
						num2 = byte_2[78] - byte_2[26];
						continue;
					case 38:
						result = appDomain_0.GetData(string_0);
						num2 = byte_2[215] - 113;
						continue;
					case 37:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 36:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 35:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 33:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 32:
						result = appDomain_0.GetData(string_0);
						num2 = byte_[91] - 189;
						continue;
					case 31:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 30:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 29:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 28:
						switch (((short_0 ^ char_1) - 79) ^ num)
						{
						case 0:
							goto IL_01b0;
						case 1:
							goto IL_01c9;
						case 2:
							goto IL_01e1;
						case 3:
							goto IL_01f1;
						case 4:
							goto IL_020e;
						case 5:
							goto IL_021e;
						case 6:
							goto IL_0228;
						case 7:
							goto IL_0235;
						case 8:
							goto IL_0250;
						case 9:
							goto IL_0263;
						case 10:
							goto IL_0270;
						case 11:
							goto IL_0283;
						case 12:
							goto IL_0296;
						case 13:
							goto IL_02a3;
						case 14:
							goto IL_02ab;
						case 15:
							goto IL_02b8;
						case 16:
							goto IL_02cb;
						case 17:
							goto IL_02de;
						case 18:
							goto IL_02e6;
						case 19:
							goto IL_02ee;
						case 20:
							goto IL_0301;
						case 21:
							goto IL_0313;
						case 22:
							goto IL_0323;
						case 23:
							goto IL_032b;
						case 24:
							goto IL_0333;
						case 25:
							goto IL_0342;
						case 26:
							goto IL_0354;
						case 27:
							goto IL_0367;
						case 28:
							goto IL_036f;
						case 29:
							goto IL_037c;
						case 30:
							goto IL_0389;
						case 31:
							goto IL_039c;
						case 32:
							goto IL_03ae;
						}
						num2 = byte_[101] - 45;
						continue;
					case 8:
						result = appDomain_0.GetData(string_0);
						num2 = byte_[11] - byte_[123];
						continue;
					case 26:
						result = appDomain_0.GetData(string_0);
						num2 = byte_[111] - 43;
						continue;
					case 3:
						result = appDomain_0.GetData(string_0);
						num2 = byte_2[191] - 204;
						continue;
					case 12:
						result = appDomain_0.GetData(string_0);
						num2 = byte_2[36] - 191;
						continue;
					case 19:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 23:
						result = appDomain_0.GetData(string_0);
						goto case 13;
					case 13:
						num2 = 17;
						goto case 17;
					case 15:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 24:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 5:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 4:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 27:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 25:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 7:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 16:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 22:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 21:
						result = appDomain_0.GetData(string_0);
						num2 = 17;
						goto case 17;
					case 20:
						result = null;
						num2 = byte_[101] - byte_[62];
						continue;
					case 11:
						result = appDomain_0.GetData(string_0);
						num2 = byte_2[294] - 220;
						continue;
					case 10:
						result = appDomain_0.GetData(string_0);
						num2 = byte_[0] - 68;
						continue;
					case 9:
						result = appDomain_0.GetData(string_0);
						goto case 0;
					case 0:
						num2 = byte_[140] - 234;
						continue;
					case 6:
						result = appDomain_0.GetData(string_0);
						num2 = byte_[100] - 138;
						continue;
					case 1:
						result = appDomain_0.GetData(string_0);
						num2 = byte_[14] - 229;
						continue;
					case 18:
						break;
					case 14:
						{
							return result;
						}
						IL_03ae:
						num2 = 16;
						goto case 16;
						IL_039c:
						num2 = 7;
						goto case 7;
						IL_0389:
						num2 = 25;
						goto case 25;
						IL_037c:
						num2 = byte_2[107] - 66;
						continue;
						IL_036f:
						num2 = byte_[117] + 9;
						continue;
						IL_0367:
						num2 = 39;
						goto case 39;
						IL_0354:
						num2 = 27;
						goto case 27;
						IL_0342:
						num2 = 4;
						goto case 4;
						IL_0333:
						num2 = byte_[2] - 222;
						continue;
						IL_032b:
						num2 = 36;
						goto case 36;
						IL_0323:
						num2 = 42;
						goto case 42;
						IL_0313:
						num2 = byte_2[203] - 57;
						continue;
						IL_0301:
						num2 = 5;
						goto case 5;
						IL_02ee:
						num2 = byte_2[207] - 160;
						continue;
						IL_02e6:
						num2 = 37;
						goto case 37;
						IL_02de:
						num2 = 31;
						goto case 31;
						IL_02cb:
						num2 = byte_2[290] - 204;
						continue;
						IL_02b8:
						num2 = 24;
						goto case 24;
						IL_02ab:
						num2 = byte_[19] - 26;
						continue;
						IL_02a3:
						num2 = 40;
						goto case 40;
						IL_0296:
						num2 = (int)byte_[22] / 9;
						continue;
						IL_0283:
						num2 = 15;
						goto case 15;
						IL_0270:
						num2 = 23;
						goto case 23;
						IL_0263:
						num2 = byte_2[134];
						continue;
						IL_0250:
						num2 = 19;
						goto case 19;
						IL_0235:
						num2 = 12;
						goto case 12;
						IL_0228:
						num2 = byte_2[158];
						continue;
						IL_021e:
						num2 = byte_2[35];
						continue;
						IL_020e:
						num2 = byte_[75] - 223;
						continue;
						IL_01f1:
						num2 = 3;
						goto case 3;
						IL_01e1:
						num2 = byte_2[99] - 167;
						continue;
						IL_01c9:
						num2 = 26;
						goto case 26;
						IL_01b0:
						num2 = 8;
						goto case 8;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static char[] smethod_10(string string_0, int int_0, int int_1)
		{
			byte[] byte_ = Class2.byte_1;
			int num4 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 6;
				while (true)
				{
					Array array = string_0.ToCharArray();
					while (true)
					{
						num++;
						int num3 = 1708;
						switch (byte_[156])
						{
						case 251:
							break;
						case 248:
							num4 = 601;
							goto case 252;
						case 252:
							if (854 < num3 / 2 - num4)
							{
								num2 = 6;
								goto end_IL_0008;
							}
							num2 = 2;
							goto case 249;
						case 253:
							goto end_IL_0008;
						default:
							num2 = 3;
							goto end_IL_005e;
						case 250:
							goto end_IL_005e;
						case 249:
						case 254:
							return (char[])array;
						}
						continue;
						end_IL_0008:
						break;
					}
					continue;
					end_IL_005e:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static string smethod_11(char char_1, short short_0)
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			int num3 = default(int);
			object newLine = default(object);
			while (true)
			{
				int num = 0;
				int num2 = byte_[102] - 50;
				while (true)
				{
					switch (num2)
					{
					case 7:
						num++;
						num3 = char_1 * char_1;
						goto case 4;
					case 4:
						num2 = byte_2[22] - 48;
						continue;
					case 6:
						num3 = char_1 + num3;
						if (num3 % 2 == 0)
						{
							num2 = byte_[138] - byte_[4];
							continue;
						}
						num2 = 1;
						goto case 0;
					case 0:
					case 1:
						newLine = Environment.NewLine;
						goto case 7;
					default:
						num2 = 5;
						break;
					case 5:
						break;
					case 2:
						return (string)newLine;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static PackagePart smethod_12(Package package_0, Uri uri_0, short short_0, char char_1)
		{
			int num = 0;
			object part;
			do
			{
				part = package_0.GetPart(uri_0);
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return (PackagePart)((part is PackagePart) ? part : null);
		}

		[SecuritySafeCritical]
		internal static Assembly smethod_13(Type type_0, int int_0, short short_0)
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			object assembly = default(object);
			int num3 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = byte_[338] - 112;
				while (true)
				{
					switch (num2)
					{
					case 7:
						num2 = byte_[32] - 187;
						continue;
					case 4:
					case 6:
						assembly = type_0.Assembly;
						num++;
						goto case 3;
					case 3:
						num3 = short_0 * short_0;
						goto case 7;
					case 0:
						num3 = short_0 + num3;
						if (num3 % 2 == 0)
						{
							byte num4 = byte_2[164];
							Class1.byte_1[79] = (byte)((Class1.byte_1[79] | short_0) & 0x78);
							num2 = num4 - 111;
							continue;
						}
						num2 = 4;
						goto case 4;
					default:
						num2 = 5;
						break;
					case 5:
						break;
					case 1:
						return (Assembly)assembly;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static object smethod_14(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			int num3 = default(int);
			object result = default(object);
			while (true)
			{
				int num = 0;
				int num2 = (int)byte_[19] / 8;
				while (true)
				{
					switch (num2)
					{
					case 8:
					{
						byte num4 = byte_[3];
						Class2.byte_1[169] = (byte)(Class2.byte_1[169] & Class1.byte_1[14] & 0x79);
						num2 = num4 - 25;
						continue;
					}
					case 6:
						num3 = 187;
						goto case 3;
					case 3:
						if (1827 <= 203 - num3 * 9)
						{
							num2 = 8;
							goto case 8;
						}
						num2 = byte_2[110] - byte_2[44];
						continue;
					case 4:
						num++;
						num2 = (int)byte_2[83] / 6;
						continue;
					case 2:
						result = methodBase_0.Invoke(object_0, object_1);
						goto case 4;
					default:
						num2 = 0;
						break;
					case 0:
						break;
					case 1:
					case 5:
						return result;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static long smethod_15(ref DateTime dateTime_0, int int_0, char char_1)
		{
			byte[] byte_ = Class1.byte_1;
			while (true)
			{
				int num = 0;
				int num2 = 2;
				while (true)
				{
					long ticks = dateTime_0.Ticks;
					while (true)
					{
						num++;
						while (true)
						{
							if ((char_1 * char_1 + char_1) % 2 == 0)
							{
								switch (byte_[21])
								{
								case 226:
									continue;
								case 229:
									goto end_IL_003b;
								case 230:
									goto IL_004e;
								case 225:
									goto end_IL_0046;
								case 224:
									goto end_IL_0050;
								case 223:
								case 227:
									return ticks;
								}
								num2 = 1;
								goto end_IL_0050;
							}
							num2 = 7;
							goto IL_004e;
							IL_004e:
							num2 = 2;
							goto end_IL_0046;
							continue;
							end_IL_003b:
							break;
						}
						continue;
						end_IL_0046:
						break;
					}
					continue;
					end_IL_0050:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static string[] smethod_16(Assembly assembly_0, short short_0, char char_1)
		{
			byte[] byte_ = Class2.byte_1;
			Array manifestResourceNames = default(Array);
			while (true)
			{
				int num = 0;
				int num2;
				switch (byte_[209])
				{
				default:
					goto IL_0008;
				case 249:
				case 251:
					continue;
				case 0:
					num2 = 4;
					goto case 252;
				case 252:
				case 253:
					manifestResourceNames = assembly_0.GetManifestResourceNames();
					num++;
					if ((short_0 * short_0 + short_0) % 2 != 0)
					{
						num2 = 7;
						goto case 0;
					}
					num2 = 6;
					break;
				case 250:
				case byte.MaxValue:
					break;
				}
				break;
				IL_0008:
				num2 = 2;
			}
			string[] result = (string[])manifestResourceNames;
			Class2.byte_1[34] = (byte)((Class2.byte_1[34] ^ Class2.byte_1[72]) & 0xCB);
			return result;
		}

		[SecuritySafeCritical]
		internal static byte[] smethod_17(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			Array array = memoryStream_0.ToArray();
			return (byte[])array;
		}

		static Class12()
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			int num = 1;
			while (true)
			{
				array_0 = new char[112]
				{
					'๖', '๖', '๖', '\u0e76', 'வ', '⬺', 'ౘ', '㴿', '☣', '㝑',
					'\u1b4e', '؛', 'வ', '⬺', '\u0c5b', '㵭', '♵', '㜄', 'ᬙ', '\u064b',
					'௯', '⬶', 'ఈ', '㴳', '☢', '㝔', '\u1b4d', '\u0619', '௯', '⬶',
					'ఊ', '㵨', '♷', '㜆', '\u1b41', 'ي', '䒵', '䒴', '䒴', '䒐',
					'況', '締', '冣', '䳹', '䅗', '懘', '䚼', '矛', '沎', '綽',
					'冮', '䳾', '䄌', '懀', '䛫', '矞', '泅', '締', '冷', '䳹',
					'䄅', '懝', '䛯', '矄', '沕', '緦', '冮', '䲬', '䄍', '懘',
					'䛨', '瞏', '泆', '綷', '冢', '䲬', '簇', '簅', '簅', '簥',
					'吧', '䕒', '椝', '瑊', '禴', '夾', '繞', '你', '呱', '䔅',
					'椘', '瑊', '禰', '奭', '縈', '佫', '呰', '䔀', '椚', '琛',
					'秥', '夹', '繟', '佬', '呰', '䔁', '椘', '瑋', '秧', '奪',
					'縍', '伾'
				};
				Array array = new char[8];
				(array as char[])[4] = 'ց';
				num = 4;
				while (true)
				{
					((char[])array)[5] = '╙';
					((char[])array)[7] = '㍝';
					num = 6;
					while (true)
					{
						((char[])array)[1] = '㤱';
						((char[])array)[2] = 'ᔮ';
						while (true)
						{
							num = byte_[38] - byte_[38];
							while (true)
							{
								switch (num)
								{
								case 0:
									((char[])array)[0] = '⠗';
									(array as char[])[6] = 'ɫ';
									num = byte_2[128] - 225;
									continue;
								case 3:
									break;
								case 2:
								case 6:
									goto end_IL_0063;
								case 4:
									goto end_IL_006f;
								default:
									goto end_IL_008b;
								case 5:
								case 7:
									(array as char[])[3] = '\u082c';
									array_1 = new string[3];
									char_0 = array as char[];
									return;
								}
								break;
							}
							continue;
							end_IL_0063:
							break;
						}
						continue;
						end_IL_006f:
						break;
					}
					continue;
					end_IL_008b:
					break;
				}
			}
		}
	}

	[SecuritySafeCritical]
	static Class9()
	{
		Class8.smethod_6();
	}

	[SecuritySafeCritical]
	internal static byte smethod_0()
	{
		Class8.smethod_8(769, 820).SetData(Class12.smethod_8(3, 1319697004, null), null);
		return 20;
	}

	[SecuritySafeCritical]
	internal static byte smethod_1()
	{
		byte[] byte_ = Class2.byte_1;
		while (true)
		{
			Class8.smethod_8(574, 520).SetData(Class12.smethod_8(1, 1319697006, null), null);
			while (true)
			{
				byte num = byte_[9];
				Class1.byte_1[152] = (byte)((Class1.byte_1[152] * Class1.byte_1[312]) & 0x4A);
				switch ((int)num / 6)
				{
				case 1:
				case 2:
					continue;
				default:
				{
					int num2 = 0;
					break;
				}
				case 0:
					break;
				case 4:
				case 5:
					return 12;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_2()
	{
		Class8.smethod_8(637, 586).SetData(Class12.smethod_8(5, 1319697002, null), null);
	}

	internal static void smethod_3()
	{
		byte[] byte_ = Class1.byte_1;
		int num = 2;
		while (true)
		{
			switch (byte_[15] - byte_[15])
			{
			case 0:
			case 1:
				smethod_3();
				return;
			case 5:
			case 6:
				num = 3;
				return;
			case 3:
			case 4:
				return;
			}
		}
	}

	internal static object smethod_4()
	{
		byte[] byte_ = Class2.byte_1;
		while (true)
		{
			int num = 430;
			int num2 = 502;
			while (true)
			{
				switch ((1004 <= num2 - num * 2) ? (byte_[85] - 3) : (byte_[26] - 120))
				{
				case 0:
					continue;
				default:
				{
					int num3 = 6;
					break;
				}
				case 6:
					break;
				case 2:
				{
					smethod_4();
					int num3 = 1;
					goto case 1;
				}
				case 3:
				case 7:
				{
					int num3 = 1;
					goto case 1;
				}
				case 1:
				case 4:
					return null;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte smethod_5()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		while (true)
		{
			int num = 0;
			object obj = (byte[])Class12.smethod_9(Class8.smethod_8(866, 858), Class12.smethod_8(5, 1319697002, null), 188, 'Û');
			while (true)
			{
				int num2 = byte_[253] - byte_[149];
				while (true)
				{
					switch (num2)
					{
					case 13:
						if ((obj as byte[])[num] >= 8)
						{
							num2 = 10;
							goto case 10;
						}
						num2 = byte_[338] - 116;
						continue;
					case 10:
						if (8 != (obj as byte[])[num])
						{
							num2 = 11;
							goto case 11;
						}
						num2 = byte_[318] - 67;
						continue;
					case 11:
						Class11.smethod_0();
						num2 = byte_2[0] - 84;
						continue;
					case 12:
						if (((byte[])obj)[num] >= 208)
						{
							num2 = 4;
							goto case 4;
						}
						num2 = 5;
						goto case 5;
					case 4:
						if (208 != ((byte[])obj)[num])
						{
							num2 = byte_[26] - 204;
							continue;
						}
						num2 = 8;
						goto case 8;
					case 1:
					case 3:
						num++;
						num2 = 12;
						goto case 12;
					case 6:
						break;
					default:
						num2 = 2;
						goto end_IL_00da;
					case 2:
						goto end_IL_00da;
					case 0:
						return 28;
					case 7:
						smethod_0();
						num2 = 8;
						goto case 8;
					case 8:
						num++;
						return 4;
					case 5:
						return 6;
					}
					break;
				}
				continue;
				end_IL_00da:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long smethod_6()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		while (true)
		{
			int num = 0;
			object obj = (byte[])Class12.smethod_9(Class8.smethod_8(869, 860), Class12.smethod_8(2, 1319697005, null), 917, 'Ͻ');
			int num2 = 4;
			while (true)
			{
				IL_015f:
				if (((byte[])obj)[num] < 8)
				{
					num2 = byte_2[14] - 238;
					goto IL_00ff;
				}
				num2 = 11;
				goto IL_00b2;
				IL_01d1:
				return 13L;
				IL_009d:
				num++;
				num2 = 16;
				goto IL_0075;
				IL_00ff:
				while (true)
				{
					switch (num2)
					{
					case 18:
						Class8.smethod_1();
						goto case 10;
					case 10:
						num++;
						num2 = 0;
						goto case 0;
					case 0:
					case 1:
						if (((byte[])obj)[num] >= 65)
						{
							num2 = byte_[293] - 180;
							continue;
						}
						num2 = 9;
						goto case 9;
					case 2:
					case 17:
						break;
					case 16:
						goto end_IL_00ff;
					case 15:
						Class10.smethod_1();
						num2 = 14;
						goto IL_009d;
					case 13:
					case 14:
						goto IL_009d;
					case 12:
						Class10.smethod_3();
						num2 = byte_2[7];
						continue;
					case 11:
						goto IL_00b2;
					case 7:
						if (208 != ((byte[])obj)[num])
						{
							num2 = byte_2[7] + 13;
							continue;
						}
						num2 = 10;
						goto case 10;
					default:
						num2 = byte_[78] - 222;
						continue;
					case 4:
						goto IL_015f;
					case 6:
						goto end_IL_015f;
					case 5:
						num++;
						return 6L;
					case 8:
						return 10L;
					case 9:
						return 13L;
					case 19:
						goto IL_01d1;
					}
					num2 = ((65 == ((byte[])obj)[num]) ? byte_2[7] : (byte_[25] - 172));
					continue;
					end_IL_00ff:
					break;
				}
				goto IL_0075;
				IL_00b2:
				if (8 != ((byte[])obj)[num])
				{
					num2 = byte_[201] - 137;
					goto IL_00ff;
				}
				num2 = 14;
				goto IL_009d;
				IL_0075:
				if (((byte[])obj)[num] >= 208)
				{
					num2 = byte_[36] - byte_[105];
					goto IL_00ff;
				}
				num2 = 19;
				goto IL_01d1;
				continue;
				end_IL_015f:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_7()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		int num = 0;
		object obj = (byte[])Class12.smethod_9(Class8.smethod_8(305, 267), Class12.smethod_8(6, 1319697001, null), 36, 'M');
		while (((byte[])obj)[num] >= 8)
		{
			int num2 = 17;
			while (true)
			{
				num2 = ((8 != ((byte[])obj)[num]) ? byte_[3] : (byte_2[42] - byte_2[20]));
				while (true)
				{
					switch (num2)
					{
					case 27:
						Class11.smethod_1();
						goto case 18;
					case 18:
						num++;
						num2 = 16;
						goto case 16;
					case 16:
						if ((obj as byte[])[num] >= 208)
						{
							num2 = byte_[4] - 90;
							continue;
						}
						num2 = 19;
						return;
					case 26:
						if (196 != (obj as byte[])[num])
						{
							num2 = byte_2[155] - 80;
							continue;
						}
						num2 = 23;
						goto case 23;
					case 23:
						num++;
						goto case 12;
					case 12:
						num2 = byte_2[132] - 49;
						continue;
					case 25:
						num++;
						num2 = byte_2[153] - 147;
						continue;
					case 21:
						Class10.smethod_0();
						num2 = byte_2[200] - byte_2[18];
						continue;
					case 15:
						smethod_4();
						num2 = 13;
						goto case 13;
					case 13:
						num++;
						num2 = 3;
						goto case 3;
					case 3:
						if ((obj as byte[])[num] >= 65)
						{
							num2 = 1;
							goto case 1;
						}
						num2 = 7;
						return;
					case 1:
						if (65 != (obj as byte[])[num])
						{
							num2 = byte_2[87] - byte_2[174];
							continue;
						}
						num2 = 25;
						goto case 25;
					case 11:
						break;
					case 9:
						goto IL_0162;
					case 5:
						if (208 != ((byte[])obj)[num])
						{
							num2 = byte_[26] - 196;
							continue;
						}
						num2 = 13;
						goto case 13;
					case 4:
						if ((obj as byte[])[num] >= 196)
						{
							num2 = 26;
							goto case 26;
						}
						num2 = byte_[13] + 11;
						continue;
					case 0:
						Class10.smethod_2();
						num2 = 23;
						goto case 23;
					default:
						return;
					case 17:
						goto end_IL_01ec;
					case 22:
						goto end_IL_026c;
					case 2:
						Class8.smethod_1();
						goto case 6;
					case 6:
					case 8:
						num++;
						return;
					case 10:
						return;
					case 14:
						return;
					case 7:
						return;
					case 20:
						return;
					case 24:
						return;
					case 19:
						return;
					}
					num2 = (((obj as byte[])[num] < 145) ? (byte_2[110] - 104) : (byte_[334] - 18));
					continue;
					IL_0162:
					num2 = ((145 == ((byte[])obj)[num]) ? (byte_[241] - byte_[21]) : (byte_[169] - byte_[212]));
					continue;
					end_IL_01ec:
					break;
				}
				continue;
				end_IL_026c:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_8()
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		while (true)
		{
			int num = 0;
			object obj = (byte[])Class12.smethod_9(Class8.smethod_8(485, 478), Class12.smethod_8(7, 1319697000, null), 368, 'Ě');
			int num2 = byte_2[3] - 23;
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (8 == ((byte[])obj)[num])
					{
						num2 = byte_[92] - 230;
						continue;
					}
					num2 = 7;
					goto case 7;
				case 3:
				case 4:
					num2 = ((((byte[])obj)[num] < 8) ? (byte_2[136] - byte_2[103]) : (byte_[24] - 221));
					continue;
				default:
					num2 = byte_[7];
					continue;
				case 5:
					break;
				case 8:
					return null;
				case 7:
					Class10.smethod_2();
					num2 = 2;
					goto case 2;
				case 2:
				case 6:
					num++;
					goto case 0;
				case 0:
					return null;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte smethod_9()
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		while (true)
		{
			int num = 0;
			object obj = (byte[])Class12.smethod_9(Class8.smethod_8(176, 140), Class12.smethod_8(0, 1319697007, null), 48, '[');
			int num2 = byte_[209] - 240;
			while (true)
			{
				switch (num2)
				{
				case 34:
					smethod_4();
					num2 = 25;
					goto case 25;
				case 25:
					num++;
					num2 = 18;
					goto case 18;
				case 18:
					if (((byte[])obj)[num] >= 208)
					{
						num2 = 33;
						goto case 33;
					}
					num2 = 24;
					goto case 24;
				case 33:
					if (208 != ((byte[])obj)[num])
					{
						num2 = byte_2[324] - byte_2[324];
						continue;
					}
					num2 = 8;
					goto case 8;
				case 8:
					num++;
					num2 = 27;
					goto case 27;
				case 27:
					num2 = (((obj as byte[])[num] < 65) ? (byte_[38] - 152) : byte_2[165]);
					continue;
				case 2:
				case 32:
					if (145 != ((byte[])obj)[num])
					{
						num2 = (int)byte_[42] / 8;
						continue;
					}
					num2 = 5;
					goto case 5;
				case 5:
					num++;
					num2 = 26;
					goto case 26;
				case 26:
					if ((obj as byte[])[num] >= 160)
					{
						num2 = byte_2[13];
						continue;
					}
					num2 = 10;
					goto case 10;
				case 31:
					num++;
					num2 = 29;
					goto case 29;
				case 29:
					if ((obj as byte[])[num] >= 145)
					{
						num2 = 32;
						goto case 2;
					}
					num2 = 12;
					goto case 12;
				case 30:
					Class8.smethod_0();
					num2 = byte_[183] - 71;
					continue;
				case 28:
					Class10.smethod_2();
					num2 = 31;
					goto case 31;
				case 23:
					Class11.smethod_0();
					num2 = byte_2[36] - 201;
					continue;
				case 22:
					if (((byte[])obj)[num] >= 196)
					{
						num2 = 19;
						goto case 19;
					}
					num2 = 6;
					goto case 6;
				case 19:
					if (196 != (obj as byte[])[num])
					{
						num2 = 28;
						goto case 28;
					}
					num2 = 31;
					goto case 31;
				case 13:
				case 20:
					if ((obj as byte[])[num] >= 8)
					{
						num2 = byte_[38] - 153;
						continue;
					}
					num2 = 14;
					goto case 14;
				case 16:
					if (8 != (obj as byte[])[num])
					{
						num2 = 34;
						goto case 34;
					}
					num2 = 25;
					goto case 25;
				default:
					num2 = byte_[161] - 17;
					continue;
				case 7:
					num++;
					num2 = byte_2[158] + 11;
					continue;
				case 4:
					if (65 != (obj as byte[])[num])
					{
						num2 = byte_2[228] - 48;
						continue;
					}
					num2 = 7;
					goto case 7;
				case 3:
					if (160 != (obj as byte[])[num])
					{
						num2 = byte_[98] - 213;
						continue;
					}
					num2 = 21;
					goto case 21;
				case 0:
					Class8.smethod_1();
					goto case 8;
				case 9:
					break;
				case 1:
					Class10.smethod_0();
					num2 = 21;
					goto case 21;
				case 17:
					return 14;
				case 14:
					return 5;
				case 21:
					num++;
					goto case 15;
				case 15:
					return 22;
				case 6:
					return 18;
				case 12:
					return 15;
				case 10:
					return 25;
				case 24:
					return 21;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type smethod_10()
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		while (true)
		{
			int num = 0;
			object obj = (byte[])Class12.smethod_9(Class8.smethod_8(223, 226), Class12.smethod_8(1, 1319697006, null), 958, 'ϒ');
			int num2 = 10;
			while (true)
			{
				num2 = ((((byte[])obj)[num] >= 8) ? (byte_[196] - 72) : (byte_[66] - 156));
				while (true)
				{
					switch (num2)
					{
					case 13:
						num++;
						num2 = byte_[14] - 244;
						continue;
					case 1:
					case 11:
						Class10.smethod_3();
						num2 = byte_2[172] - 14;
						continue;
					case 0:
					case 9:
						break;
					case 3:
						if (208 != ((byte[])obj)[num])
						{
							num2 = byte_2[165];
							continue;
						}
						num2 = 8;
						goto case 5;
					case 2:
						if (((byte[])obj)[num] >= 208)
						{
							num2 = 3;
							goto case 3;
						}
						num2 = 12;
						goto case 12;
					case 10:
						goto end_IL_009b;
					default:
						num2 = 6;
						goto end_IL_00ec;
					case 6:
						goto end_IL_00ec;
					case 4:
						smethod_2();
						goto case 5;
					case 7:
						return typeof(Class4.Class5.Struct3);
					case 5:
					case 8:
						num++;
						return typeof(Class4.Class5.Struct3);
					case 12:
						return typeof(DeepSeaObfuscator);
					}
					num2 = ((8 == (obj as byte[])[num]) ? ((int)byte_2[107] / 8) : (byte_2[207] - 188));
					continue;
					end_IL_009b:
					break;
				}
				continue;
				end_IL_00ec:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_11()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		while (true)
		{
			int num = 0;
			while (true)
			{
				Array array = (byte[])Class12.smethod_9(Class8.smethod_8(43, 21), Class12.smethod_8(3, 1319697004, null), 1010, 'Ο');
				int num2 = 9;
				while (true)
				{
					if (((byte[])array)[num] >= 8)
					{
						num2 = 3;
						while (true)
						{
							IL_00d3:
							if (8 == (array as byte[])[num])
							{
								num2 = 0;
								goto IL_00c0;
							}
							num2 = byte_[122];
							goto IL_003b;
							IL_0091:
							num2 = ((208 != ((byte[])array)[num]) ? (byte_[165] - byte_[13]) : byte_2[7]);
							goto IL_003b;
							IL_003b:
							while (true)
							{
								switch (num2)
								{
								case 1:
									smethod_4();
									num2 = byte_[136] - 85;
									continue;
								case 13:
									break;
								case 11:
									goto IL_00a3;
								case 10:
									Class10.smethod_0();
									num2 = 0;
									goto IL_00c0;
								case 0:
									goto IL_00c0;
								case 3:
								case 7:
									goto IL_00d3;
								case 9:
									goto end_IL_00d3;
								case 4:
									goto end_IL_00e4;
								default:
									num2 = 14;
									goto end_IL_00f5;
								case 14:
									goto end_IL_00f5;
								case 5:
									num++;
									return null;
								case 2:
								case 6:
									goto IL_0134;
								case 12:
									goto IL_0139;
								}
								break;
							}
							goto IL_0091;
							IL_00c0:
							num++;
							num2 = 11;
							goto IL_00a3;
							IL_00a3:
							if ((array as byte[])[num] >= 208)
							{
								num2 = 13;
								goto IL_0091;
							}
							num2 = 2;
							goto IL_0134;
							IL_0134:
							return null;
							continue;
							end_IL_00d3:
							break;
						}
						continue;
					}
					num2 = 12;
					goto IL_0139;
					IL_0139:
					return null;
					continue;
					end_IL_00e4:
					break;
				}
				continue;
				end_IL_00f5:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_12()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		int num = 0;
		Array array = (byte[])Class12.smethod_9(Class8.smethod_8(604, 611), Class12.smethod_8(1, 1319697006, null), 934, 'ψ');
		while (((byte[])array)[num] >= 8)
		{
			int num2 = byte_[158];
			while (true)
			{
				switch (num2)
				{
				case 7:
				case 20:
					Class10.smethod_2();
					num2 = 8;
					goto case 8;
				case 8:
					num++;
					num2 = 2;
					goto case 2;
				case 2:
					if ((array as byte[])[num] >= 65)
					{
						num2 = 16;
						goto case 16;
					}
					num2 = byte_[192];
					continue;
				case 16:
					if (65 != ((byte[])array)[num])
					{
						num2 = 6;
						goto case 0;
					}
					num2 = 15;
					goto case 15;
				case 0:
				case 6:
					Class10.smethod_0();
					num2 = 15;
					goto case 15;
				case 15:
					num++;
					num2 = 10;
					goto case 10;
				case 10:
					if ((array as byte[])[num] >= 196)
					{
						num2 = byte_2[133] - 235;
						continue;
					}
					num2 = 19;
					return;
				case 18:
					Class10.smethod_4();
					num2 = byte_2[26] - 101;
					continue;
				case 17:
					num2 = ((208 == ((byte[])array)[num]) ? (byte_2[175] - byte_2[46]) : (byte_2[123] - 69));
					continue;
				case 1:
				case 14:
					if ((array as byte[])[num] >= 208)
					{
						num2 = 17;
						goto case 17;
					}
					num2 = 5;
					return;
				case 13:
					Class10.smethod_1();
					num2 = byte_[165];
					continue;
				case 11:
					if (8 != (array as byte[])[num])
					{
						num2 = 13;
						goto case 13;
					}
					num2 = byte_2[18] - 200;
					continue;
				case 9:
					num2 = ((196 == ((byte[])array)[num]) ? (byte_[34] - 219) : (byte_2[3] - 202));
					continue;
				case 4:
					num++;
					num2 = byte_2[106];
					continue;
				default:
					return;
				case 3:
					break;
				case 12:
					return;
				case 5:
					return;
				case 19:
					return;
				case 21:
					num++;
					return;
				case 22:
					return;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_13(AppDomain appDomain_0, string string_0, object object_0, short short_0, int int_0)
	{
		byte[] byte_ = Class2.byte_1;
		int num = 4;
		while (true)
		{
			int num2 = 0;
			switch (byte_[208] - byte_[165])
			{
			default:
				continue;
			case 6:
				num = 1;
				goto case 0;
			case 0:
			case 1:
			case 2:
				appDomain_0.SetData(string_0, object_0);
				num2++;
				goto case 7;
			case 7:
				num = 3;
				break;
			case 3:
				break;
			case 5:
				return;
			}
			break;
		}
		num = 5;
	}

	[SecuritySafeCritical]
	internal static int smethod_14(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		byte[] byte_ = Class1.byte_1;
		while (true)
		{
			int num = 0;
			int num2 = 3;
			while (true)
			{
				int result = stream_0.Read(byte_0, int_0, int_1);
				num++;
				num2 = 2;
				while (true)
				{
					int num3 = 1944;
					Class1.byte_1[281] = (byte)((Class1.byte_1[281] ^ int_3) & 0x7C);
					int num4 = 3779136;
					while (true)
					{
						num4 = num3 + num4;
						while (true)
						{
							num2 = 7;
							while (true)
							{
								if (num4 % 2 != 0)
								{
									switch (byte_[13])
									{
									case 7:
										continue;
									case 4:
										goto end_IL_003c;
									case 6:
										goto end_IL_0043;
									case 2:
										goto end_IL_0047;
									case 3:
										goto end_IL_004e;
									case 0:
									case 5:
										goto end_IL_0079;
									case 1:
										goto IL_0096;
									}
									num2 = 5;
									goto end_IL_0079;
								}
								num2 = 1;
								goto IL_0096;
								IL_0096:
								return result;
								continue;
								end_IL_003c:
								break;
							}
							continue;
							end_IL_0043:
							break;
						}
						continue;
						end_IL_0047:
						break;
					}
					continue;
					end_IL_004e:
					break;
				}
				continue;
				end_IL_0079:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime smethod_15(char char_0, short short_0)
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		DateTime result = default(DateTime);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = byte_2[71] - 139;
			while (true)
			{
				switch (num2)
				{
				case 10:
					result = DateTime.UtcNow;
					num2 = 2;
					goto case 2;
				case 5:
				case 8:
					if (716 < num3 / 4 - num4)
					{
						num2 = 9;
						goto case 9;
					}
					num2 = 0;
					goto case 0;
				case 9:
					switch (((char_0 ^ short_0) - 38) ^ num)
					{
					case 1:
						break;
					default:
						goto IL_0062;
					case 0:
						goto IL_006e;
					}
					num2 = 10;
					goto case 10;
				case 2:
					num++;
					num3 = 2864;
					num4 = 239;
					goto case 5;
				case 3:
					result = DateTime.Now;
					num2 = byte_2[55] - 105;
					continue;
				default:
					num2 = byte_[231] - 35;
					continue;
				case 6:
					result = default(DateTime);
					num2 = 2;
					goto case 2;
				case 1:
					break;
				case 0:
				case 4:
					{
						return result;
					}
					IL_006e:
					num2 = 3;
					goto case 3;
					IL_0062:
					num2 = byte_2[26] - byte_2[16];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_16(Exception exception_0, char char_0, int int_0)
	{
		byte[] byte_ = Class2.byte_1;
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				object obj;
				switch (((char_0 ^ int_0) - 109) ^ num)
				{
				case 0:
					num2 = 8;
					while (true)
					{
						obj = exception_0.Message;
						switch (byte_[101])
						{
						case 72:
							break;
						case 66:
							num2 = 6;
							goto end_IL_000a;
						case 67:
						case 68:
						case 70:
							goto end_IL_000a;
						default:
							num2 = 9;
							goto end_IL_005b;
						case 73:
							goto end_IL_005b;
						case 69:
							goto IL_0075;
						case 75:
							goto IL_007e;
						case 64:
						case 65:
							goto IL_0087;
						case 74:
							goto IL_008e;
						}
						continue;
						end_IL_000a:
						break;
					}
					continue;
				default:
					num2 = 5;
					goto IL_0075;
				case 1:
					{
						num2 = 11;
						goto IL_007e;
					}
					IL_008e:
					return (string)obj;
					IL_007e:
					obj = exception_0.StackTrace;
					num2 = 1;
					goto IL_0087;
					IL_0075:
					obj = null;
					num2 = 1;
					goto IL_0087;
					IL_0087:
					num++;
					num2 = 10;
					goto IL_008e;
					end_IL_005b:
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_17(string string_0, short short_0, short short_1)
	{
		byte[] byte_ = Class1.byte_1;
		int num3 = default(int);
		int num5 = default(int);
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			int num = 0;
			byte num2 = byte_[158];
			Class2.byte_1[80] = (byte)((Class2.byte_1[80] | short_0) & 0xC4);
			int num4;
			switch (num2 - 6)
			{
			default:
				goto IL_0008;
			case 7:
				continue;
			case 6:
				num3 = 214;
				num4 = 3;
				goto case 3;
			case 3:
				num5 = 86;
				goto case 0;
			case 0:
				if (107 < num3 / 2 - num5)
				{
					num4 = 5;
					goto case 4;
				}
				num4 = 2;
				break;
			case 4:
			case 5:
				convertible = string.Intern(string_0);
				num++;
				goto case 6;
			case 2:
				break;
			}
			break;
			IL_0008:
			num4 = 7;
		}
		return convertible as string;
	}

	[SecuritySafeCritical]
	internal static Stream smethod_18(Assembly assembly_0, string string_0, int int_0, char char_0)
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				object manifestResourceStream = assembly_0.GetManifestResourceStream(string_0);
				while (true)
				{
					num++;
					num2 = byte_[119] - 61;
					while (true)
					{
						switch (num2)
						{
						case 5:
							if (676 >= num3 / 2 - num4)
							{
								num2 = byte_2[239] - 13;
								continue;
							}
							num2 = 1;
							goto end_IL_006e;
						default:
							num2 = byte_[196] - 74;
							continue;
						case 2:
							num3 = 1352;
							num4 = 443;
							goto case 5;
						case 3:
							break;
						case 1:
							goto end_IL_006e;
						case 7:
							goto end_IL_007e;
						case 6:
							return (Stream)manifestResourceStream;
						}
						break;
					}
					continue;
					end_IL_006e:
					break;
				}
				continue;
				end_IL_007e:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_19(object object_0, char char_0, int int_0)
	{
		int num = 0;
		switch (((char_0 ^ int_0) - 30) ^ 0)
		{
		case 0:
			Monitor.Enter(object_0);
			break;
		case 1:
			Monitor.Exit(object_0);
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static byte[] smethod_20(long long_0, int int_0, char char_0)
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		int num3 = default(int);
		object bytes = default(object);
		while (true)
		{
			int num = 0;
			int num2 = (int)byte_[106] / 7;
			while (true)
			{
				switch (num2)
				{
				case 7:
					num++;
					num3 = 25;
					num2 = 4;
					goto case 4;
				case 4:
					if (978 <= 163 - num3 * 6)
					{
						num2 = 6;
						goto case 6;
					}
					num2 = byte_2[282] - 48;
					continue;
				case 6:
					num2 = byte_[208] - 81;
					continue;
				case 0:
				case 2:
					bytes = BitConverter.GetBytes(long_0);
					goto case 7;
				default:
					num2 = 1;
					break;
				case 1:
				case 5:
					break;
				case 3:
					return (byte[])bytes;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_21(MemberInfo memberInfo_0, int int_0, short short_0)
	{
		byte[] byte_ = Class2.byte_1;
		int num3 = default(int);
		IConvertible name = default(IConvertible);
		while (true)
		{
			int num = 0;
			int num2 = byte_[66] - 161;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 7:
					num3 = short_0 * short_0;
					num2 = byte_[92] - 229;
					continue;
				case 3:
					num3 = short_0 + num3;
					if (num3 % 2 == 0)
					{
						num2 = byte_[7] - 1;
						continue;
					}
					num2 = 2;
					goto case 2;
				case 2:
					name = memberInfo_0.Name;
					num++;
					goto case 1;
				default:
					num2 = 0;
					break;
				case 0:
					break;
				case 4:
				case 5:
					return name as string;
				}
				break;
			}
		}
	}
}
