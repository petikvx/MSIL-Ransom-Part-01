using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;

namespace ns0;

internal sealed class Class4
{
	internal sealed class Class5
	{
		internal sealed class Class6
		{
			private static bool bool_0;

			internal static void smethod_0()
			{
				int[] int_ = Class0.int_0;
				char[] char_ = Class1.char_1;
				int num = 2;
				int num7 = default(int);
				char[] char_3 = default(char[]);
				char[] char_2 = default(char[]);
				int num3 = default(int);
				int num6 = default(int);
				while (true)
				{
					switch (num)
					{
					case 1:
					case 7:
						num7 = 2;
						num = int_[165] - 26099;
						break;
					case 6:
						num7 = char_3[420] - 45403;
						num = 4;
						break;
					case 4:
						num = num7 switch
						{
							0 => int_[192] - 44120, 
							1 => int_[352] - 55874, 
							2 => int_[5] - 34987, 
							3 => char_[171] - 24789, 
							4 => 3, 
							_ => 3, 
						};
						break;
					case 3:
						if (!bool_0)
						{
							num = int_[331] - 23109;
							break;
						}
						return;
					default:
						char_2 = Class0.char_0;
						goto case 0;
					case 0:
						char_3 = Class1.char_0;
						goto case 1;
					case 5:
					{
						Type typeFromHandle;
						Class7.smethod_0((object)(typeFromHandle = typeof(Class6)), (short)891, 777);
						try
						{
							int num2 = 12;
							while (true)
							{
								int num4;
								switch (num2)
								{
								default:
									num3 = 1;
									num2 = 3;
									continue;
								case 5:
								case 11:
									Class10.Class11.Class12.smethod_0<AppDomain, ResolveEventHandler>(Class7.Class8.smethod_0('l', 17), Class2.smethod_0, 'Σ', 'ϡ');
									num2 = char_[105] - 12474;
									continue;
								case 7:
								case 9:
									num4 = char_2[77] - 40069;
									goto IL_0162;
								case 2:
									num2 = 3;
									continue;
								case 6:
									num4 = 0;
									goto IL_0162;
								case 4:
									num3 = 5;
									num2 = 3;
									continue;
								case 3:
									num2 = num3 switch
									{
										0 => int_[255] - 28357, 
										1 => 0, 
										2 => 5, 
										3 => int_[150] - 64998, 
										4 => char_[217] - 1934, 
										5 => int_[0] - 47368, 
										_ => 0, 
									};
									continue;
								case 1:
									bool_0 = true;
									num2 = 5;
									continue;
								case 0:
									num2 = (bool_0 ? 7 : 6);
									continue;
								case 8:
									break;
									IL_0162:
									num3 = num4;
									goto case 2;
								}
								break;
							}
						}
						finally
						{
							switch (3)
							{
							default:
								Class7.smethod_0((object)typeFromHandle, (short)510, 397);
								break;
							}
						}
						int num5 = 5;
						while (true)
						{
							switch (num5)
							{
							case 2:
							case 8:
								num5 = num6 switch
								{
									0 => int_[379] - 29443, 
									1 => int_[237] - 51032, 
									2 => char_[410] - 40555, 
									3 => 1, 
									4 => 6, 
									5 => char_[52] - 19389, 
									_ => char_[298] - 50862, 
								};
								break;
							case 1:
							case 7:
								num6 = char_2[135] - 29397;
								num5 = char_[75] - 6857;
								break;
							case 0:
							case 6:
								num6 = 2;
								num5 = char_[115] - 24198;
								break;
							default:
								num6 = 0;
								num5 = int_[394] - 53894;
								break;
							case 3:
								return;
							}
						}
					}
					}
				}
			}

			internal static AppDomain smethod_1(char char_0, int int_0)
			{
				int[] int_ = Class0.int_0;
				char[] char_ = Class1.char_1;
				int num3 = default(int);
				int num2 = default(int);
				object obj = default(object);
				int num4 = default(int);
				while (true)
				{
					Array char_2 = Class1.char_0;
					Array char_3 = Class0.char_0;
					int num = 10;
					while (true)
					{
						int num6;
						int num5;
						switch (num)
						{
						case 16:
						case 22:
							num6 = (char_2 as char[])[93] - ((char[])char_2)[93];
							goto IL_0024;
						case 10:
						case 20:
							num3 = 0;
							num2 = ((char[])char_2)[311] - 42083;
							num = 19;
							continue;
						case 19:
							num = num2 switch
							{
								0 => 15, 
								1 => char_[149] - 61254, 
								2 => 12, 
								3 => 11, 
								4 => char_[146] - 58722, 
								5 => 6, 
								6 => char_[168] - 53014, 
								7 => 6, 
								8 => 10, 
								9 => 1, 
								10 => 18, 
								11 => 7, 
								12 => 0, 
								_ => 0, 
							};
							continue;
						case 18:
							num2 = 9;
							num = 19;
							continue;
						case 17:
							num5 = 6;
							goto IL_0120;
						case 15:
							obj = Class7.Class8.smethod_0('>', 67);
							num = 18;
							continue;
						case 14:
							num2 = ((char[])char_2)[182] - 14984;
							num = 19;
							continue;
						case 13:
							num6 = 3;
							goto IL_0024;
						case 12:
							num = ((num4 % 2 != 0) ? (char_[84] - 34652) : (char_[400] - 51769));
							continue;
						case 11:
							obj = null;
							num2 = 9;
							num = int_[26] - 22952;
							continue;
						case 9:
							num6 = (char_2 as char[])[100] - 1506;
							goto IL_0024;
						case 8:
							num4 = char_0 + num4;
							num = 14;
							continue;
						case 7:
							num = (((char_0 ^ int_0) - 75) ^ num3) switch
							{
								0 => 16, 
								1 => 9, 
								_ => char_[284] - 49262, 
							};
							continue;
						case 6:
							obj = Class7.Class8.smethod_0('ż', 257);
							num2 = (char_2 as char[])[264] - 19799;
							num = 19;
							continue;
						default:
							num = int_[192] - 44104;
							continue;
						case 3:
							num5 = ((char[])char_2)[286] - 52079;
							goto IL_0120;
						case 2:
							num2 = (char_3 as char[])[156] - 39189;
							num = 19;
							continue;
						case 1:
							num3++;
							num4 = char_0 * char_0;
							goto case 8;
						case 0:
							num2 = 1;
							num = int_[51] - 15065;
							continue;
						case 21:
							break;
						case 4:
							{
								return obj as AppDomain;
							}
							IL_0024:
							num2 = num6;
							num = 19;
							continue;
							IL_0120:
							num2 = num5;
							num = char_[167] - 50189;
							continue;
						}
						break;
					}
				}
			}

			internal static void smethod_2<T, U>(T gparam_0, U gparam_1, char char_0, char char_1) where T : AppDomain where U : ResolveEventHandler
			{
				int[] int_ = Class0.int_0;
				char[] char_2 = Class1.char_1;
				int num = 6;
				int num2 = default(int);
				int num3 = default(int);
				object char_4 = default(object);
				object char_3 = default(object);
				int num4 = default(int);
				while (true)
				{
					int num7;
					int num5;
					switch (num)
					{
					case 16:
						num2 = 0;
						num = 0;
						break;
					case 15:
						num = (((char_1 ^ char_0) - 120) ^ num3) switch
						{
							0 => 13, 
							_ => 12, 
						};
						break;
					case 13:
						num7 = 7;
						goto IL_0040;
					case 8:
						num = 0;
						break;
					case 12:
						num7 = 8;
						goto IL_0040;
					case 11:
					{
						char num6 = (char_4 as char[])[44];
						Class1.char_1[228] = (char)((Class1.char_1[228] + Class1.char_1[201]) & 'Ø');
						num5 = num6 - 55258;
						goto IL_0084;
					}
					case 10:
						num5 = ((char[])char_3)[376] - 25190;
						goto IL_0084;
					case 9:
						num3++;
						num4 = char_1 * char_1;
						num4 = char_1 + num4;
						num = char_2[90] - 49013;
						break;
					case 7:
						num = 0;
						break;
					default:
						char_3 = Class1.char_0;
						char_4 = Class0.char_0;
						goto case 4;
					case 4:
						num2 = 6;
						num = 0;
						break;
					case 5:
						num2 = (char_3 as char[])[33] - 45803;
						num = 0;
						break;
					case 3:
						num = ((num4 % 2 != 0) ? (char_2[395] - 2461) : 10);
						break;
					case 2:
						num3 = 0;
						num2 = 4;
						goto case 7;
					case 1:
						Class10.Class11.Class12.smethod_0((AppDomain)gparam_0, (ResolveEventHandler)gparam_1, '\0', 'C');
						goto case 9;
					case 0:
						num = num2 switch
						{
							0 => 3, 
							1 => 9, 
							2 => 14, 
							3 => int_[315] - 20829, 
							4 => 15, 
							5 => int_[118] - 12381, 
							6 => char_2[362] - 45938, 
							7 => char_2[56] - 6553, 
							8 => int_[191] - 33628, 
							9 => 14, 
							_ => 2, 
						};
						break;
					case 14:
						return;
						IL_0084:
						num2 = num5;
						num = 0;
						break;
						IL_0040:
						num2 = num7;
						goto case 8;
					}
				}
			}

			internal static int smethod_3<T>(T gparam_0, short short_0, short short_1) where T : BinaryReader
			{
				int[] int_ = Class0.int_0;
				char[] char_ = Class1.char_1;
				int num3 = default(int);
				int result = default(int);
				int num4 = default(int);
				while (true)
				{
					Array char_2 = Class0.char_0;
					object char_3 = Class1.char_0;
					int num = int_[148] - 30004;
					while (true)
					{
						int num2;
						int num5;
						switch (num)
						{
						case 17:
							num = (((short_1 ^ short_0) - 75) ^ num3) switch
							{
								0 => 0, 
								_ => 16, 
							};
							continue;
						case 16:
							num2 = (char_2 as char[])[187] - 56540;
							goto IL_0044;
						case 9:
						case 15:
							result = Class10.Class11.Class12.smethod_1((BinaryReader)gparam_0, (short)416, (short)396);
							num4 = 4;
							num = 13;
							continue;
						case 14:
							num4 = 7;
							num = 13;
							continue;
						case 13:
							num = num4 switch
							{
								0 => 8, 
								1 => char_[320] - 14012, 
								2 => 5, 
								3 => 7, 
								4 => int_[162] - 47025, 
								5 => 14, 
								6 => 15, 
								7 => char_[149] - 61247, 
								8 => 12, 
								9 => 14, 
								10 => char_[298] - 50854, 
								11 => char_[200] - 11194, 
								_ => 12, 
							};
							continue;
						case 12:
							num4 = (char_2 as char[])[384] - 378;
							num = char_[117] - 52652;
							continue;
						case 11:
							num5 = 2;
							goto IL_017b;
						case 10:
							result = 3;
							num4 = (char_3 as char[])[86] - 50885;
							num = 13;
							continue;
						case 8:
							num3++;
							num = (((short_0 * short_0 + short_0) % 2 == 0) ? 4 : 11);
							continue;
						case 5:
							num4 = 7;
							num = 13;
							continue;
						case 4:
							num5 = ((char[])char_2)[258] - 52507;
							goto IL_017b;
						case 3:
							num3 = 0;
							num4 = 7;
							num = 13;
							continue;
						default:
							num = int_[359] - 19715;
							continue;
						case 0:
							num2 = 6;
							goto IL_0044;
						case 1:
						case 6:
						case 18:
							break;
						case 7:
							{
								return result;
							}
							IL_0044:
							num4 = num2;
							num = char_[421] - 33465;
							continue;
							IL_017b:
							num4 = num5;
							num = 13;
							continue;
						}
						break;
					}
				}
			}

			internal static Assembly smethod_4(byte[] byte_0, short short_0, int int_0)
			{
				//IL_026f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0275: Expected O, but got Unknown
				char[] char_ = Class1.char_1;
				int[] int_ = Class0.int_0;
				int num2 = default(int);
				int num5 = default(int);
				object obj = default(object);
				while (true)
				{
					object char_2 = Class1.char_0;
					object char_3 = Class0.char_0;
					int num = char_[293] - 17545;
					while (true)
					{
						int num7;
						int num6;
						switch (num)
						{
						case 12:
						case 18:
							num = (((short_0 ^ int_0) - 82) ^ num2) switch
							{
								0 => 5, 
								_ => 11, 
							};
							continue;
						case 17:
							num = num5 switch
							{
								0 => 0, 
								1 => 18, 
								2 => 7, 
								3 => 16, 
								4 => 6, 
								5 => 8, 
								6 => int_[159] - 58253, 
								7 => 16, 
								8 => 2, 
								9 => 0, 
								10 => char_[172] - 42919, 
								_ => char_[264] - 45285, 
							};
							continue;
						case 16:
							obj = Class7.Class8.smethod_1(byte_0, 228, 251);
							num5 = ((char[])char_2)[171] - 3204;
							num = char_[200] - 11187;
							continue;
						case 7:
						case 15:
							num2 = 0;
							num5 = 1;
							num = 17;
							continue;
						case 14:
							num5 = 2;
							num = 17;
							continue;
						case 13:
							num7 = (char_2 as char[])[93] - 57285;
							goto IL_0141;
						case 11:
							num6 = ((char[])char_2)[267] - 54913;
							goto IL_0165;
						case 3:
						case 9:
							num7 = 1;
							goto IL_0141;
						case 8:
							obj = null;
							num = int_[212] - 50109;
							continue;
						case 6:
							num5 = 1;
							num = int_[382] - 31293;
							continue;
						case 5:
							num6 = 7;
							goto IL_0165;
						default:
							num = 10;
							continue;
						case 2:
							num5 = ((char[])char_3)[513] - 17453;
							num = int_[165] - 26086;
							continue;
						case 1:
						{
							num2++;
							int num3 = 135;
							int num4 = 18;
							num = ((45 < num3 / 3 - num4) ? (int_[106] - 43914) : (int_[27] - 63410));
							continue;
						}
						case 10:
							break;
						case 0:
							{
								return (Assembly)(_Assembly)obj;
							}
							IL_0165:
							num5 = num6;
							num = 17;
							continue;
							IL_0141:
							num5 = num7;
							num = int_[26] - 22954;
							continue;
						}
						break;
					}
				}
			}

			internal static void smethod_5<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, char char_0, short short_0) where T : Stream
			{
				char[] char_ = Class1.char_1;
				int[] int_2 = Class0.int_0;
				int num = 4;
				int num4 = default(int);
				int num6 = default(int);
				Array char_3 = default(Array);
				int num2 = default(int);
				Array char_2 = default(Array);
				while (true)
				{
					int num5;
					int num3;
					switch (num)
					{
					case 16:
						num5 = 2;
						goto IL_0014;
					case 14:
						num4 = 8;
						num = char_[396] - 65045;
						break;
					case 6:
					case 13:
						num6 = char_0 * char_0;
						goto case 11;
					case 11:
						num6 = char_0 + num6;
						num4 = 1;
						num = int_2[0] - 47367;
						break;
					case 12:
						num3 = (char_3 as char[])[423] - 35202;
						goto IL_0065;
					case 10:
						num = ((num6 % 2 != 0) ? 7 : (int_2[92] - 60694));
						break;
					case 9:
						num = num4 switch
						{
							0 => char_[65] - 57522, 
							1 => int_2[200] - 30362, 
							2 => 15, 
							3 => char_[382] - 4429, 
							4 => 15, 
							5 => 5, 
							6 => 8, 
							7 => 14, 
							8 => int_2[353] - 34891, 
							9 => 8, 
							_ => 5, 
						};
						break;
					case 8:
						Class10.Class11.smethod_0((Stream)gparam_0, byte_0, int_0, int_1, (short)638, (short)530);
						goto case 2;
					case 2:
						num2++;
						num = 6;
						break;
					case 7:
						num5 = 3;
						goto IL_0014;
					case 5:
						num2 = 0;
						num4 = 3;
						num = int_2[332] - 62750;
						break;
					default:
						char_3 = Class1.char_0;
						char_2 = Class0.char_0;
						num4 = 5;
						num = char_[373] - 38827;
						break;
					case 3:
						num3 = (char_2 as char[])[472] - 34632;
						goto IL_0065;
					case 0:
						num = (((short_0 ^ char_0) - 14) ^ num2) switch
						{
							0 => char_[320] - 14012, 
							_ => char_[182] - 53669, 
						};
						break;
					case 1:
					case 15:
						return;
						IL_0014:
						num4 = num5;
						num = 9;
						break;
						IL_0065:
						num4 = num3;
						num = char_[338] - 60162;
						break;
					}
				}
			}

			internal static byte[] smethod_6<T>(T gparam_0, int int_0, char char_0) where T : MemoryStream
			{
				char[] char_ = Class1.char_1;
				int[] int_ = Class0.int_0;
				int num2 = default(int);
				object obj = default(object);
				int num4 = default(int);
				int num5 = default(int);
				while (true)
				{
					object char_2 = Class1.char_0;
					int num = 4;
					while (true)
					{
						int num6;
						int num3;
						switch (num)
						{
						case 19:
							num6 = 8;
							goto IL_0012;
						case 18:
							num6 = 6;
							goto IL_0012;
						case 17:
							num = ((num5 % 2 == 0) ? 1 : (int_[36] - 19862));
							continue;
						case 16:
							num2 = (char_2 as char[])[326] - ((char[])char_2)[326];
							num = int_[314] - 62789;
							continue;
						case 14:
							obj = Class10.Class11.smethod_1((MemoryStream)gparam_0, 'Ų', 'ň');
							num2 = 2;
							num = char_[234] - 54306;
							continue;
						case 4:
						case 13:
							num4 = 0;
							num2 = 5;
							num = char_[256] - 10842;
							continue;
						case 12:
							num = 5;
							continue;
						case 11:
							num3 = ((char[])char_2)[171] - 3209;
							goto IL_00c8;
						default:
							num = char_[395] - 2469;
							continue;
						case 8:
						case 9:
							num4++;
							num5 = char_0 * char_0;
							num5 = char_0 + num5;
							num = 0;
							continue;
						case 7:
							obj = null;
							num2 = 2;
							num = 5;
							continue;
						case 6:
							num2 = 5;
							num = 5;
							continue;
						case 5:
							num = num2 switch
							{
								0 => 4, 
								1 => 15, 
								2 => 9, 
								3 => 16, 
								4 => int_[76] - 54371, 
								5 => 2, 
								6 => 7, 
								7 => 17, 
								8 => char_[84] - 34641, 
								9 => 15, 
								10 => char_[126] - 14926, 
								11 => 6, 
								_ => 16, 
							};
							continue;
						case 2:
							num = (((int_0 ^ char_0) - 5) ^ num4) switch
							{
								0 => char_[3] - char_[298], 
								_ => int_[35] - 51977, 
							};
							continue;
						case 1:
							num3 = 1;
							goto IL_00c8;
						case 0:
							num2 = 7;
							num = 5;
							continue;
						case 3:
							break;
						case 15:
							{
								byte[] result = obj as byte[];
								Class0.char_0[43] = (char)(Class0.char_0[43] & int_0 & '§');
								return result;
							}
							IL_00c8:
							num2 = num3;
							goto case 12;
							IL_0012:
							num2 = num6;
							num = 5;
							continue;
						}
						break;
					}
				}
			}

			internal static Assembly smethod_7<T>(byte[] byte_0, byte[] byte_1, T gparam_0, char char_0, int int_0) where T : Evidence
			{
				char[] char_ = Class1.char_1;
				int[] int_ = Class0.int_0;
				int num7 = default(int);
				int num3 = default(int);
				object obj = default(object);
				int num5 = default(int);
				int num4 = default(int);
				while (true)
				{
					object char_2 = Class1.char_0;
					object char_3 = Class0.char_0;
					int num = 18;
					while (true)
					{
						int num6;
						int num2;
						switch (num)
						{
						case 19:
							num6 = (char_3 as char[])[281] - 33171;
							goto IL_0024;
						case 18:
							num7 = 0;
							num3 = 5;
							num = char_[8] - 42870;
							continue;
						case 17:
							num3 = 5;
							num = 0;
							continue;
						case 11:
						case 15:
							obj = null;
							num3 = (char_2 as char[])[99] - 64162;
							num = 0;
							continue;
						case 0:
						case 14:
							num = num3 switch
							{
								0 => char_[23] - 43752, 
								1 => 15, 
								2 => char_[252] - 48588, 
								3 => 5, 
								4 => int_[191] - 33630, 
								5 => char_[338] - 60165, 
								6 => int_[182] - 35620, 
								7 => 17, 
								8 => 16, 
								9 => 13, 
								10 => 4, 
								11 => int_[350] - 28509, 
								_ => 12, 
							};
							continue;
						case 13:
							num7++;
							num5 = 80;
							num4 = 995;
							num = char_[62] - 29071;
							continue;
						case 12:
							num3 = 0;
							num = 0;
							continue;
						default:
							num = char_[255] - 34335;
							continue;
						case 2:
						case 8:
							num2 = (char_2 as char[])[181] - 48193;
							goto IL_01a1;
						case 7:
							num6 = (char_2 as char[])[309] - 5567;
							goto IL_0024;
						case 6:
							Class0.int_0[376] = (Class0.int_0[376] ^ Class1.char_1[352]) & 0x5D;
							num = (((int_0 ^ char_0) - 0) ^ num7) switch
							{
								0 => 19, 
								_ => char_[238] - 23890, 
							};
							continue;
						case 5:
							num = ((2985 > num4 - num5 * 3) ? (int_[351] - 6090) : 8);
							continue;
						case 4:
							obj = Class10.smethod_0(byte_0, byte_1, (Evidence)gparam_0, 254, 154);
							num3 = ((char[])char_2)[121] - 17608;
							num = 0;
							continue;
						case 3:
							num3 = (char_3 as char[])[187] - 56546;
							num = 0;
							continue;
						case 1:
							num2 = 8;
							goto IL_01a1;
						case 10:
							break;
						case 16:
							{
								return (Assembly)obj;
							}
							IL_0024:
							num3 = num6;
							num = char_[347] - char_[347];
							continue;
							IL_01a1:
							num3 = num2;
							num = 0;
							continue;
						}
						break;
					}
				}
			}
		}

		internal static string smethod_0<T>(T gparam_0, short short_0, int int_0) where T : ResolveEventArgs
		{
			char[] char_ = Class1.char_1;
			int[] int_ = Class0.int_0;
			int num2 = default(int);
			int num3 = default(int);
			object obj = default(object);
			while (true)
			{
				object char_2 = Class1.char_0;
				object char_3 = Class0.char_0;
				while (true)
				{
					int num = 10;
					while (true)
					{
						int num4;
						int num5;
						switch (num)
						{
						case 18:
							num4 = ((char[])char_2)[256] - 17406;
							goto IL_0023;
						case 6:
							num = char_[395] - 2465;
							continue;
						case 5:
						case 14:
							num5 = 4;
							goto IL_0039;
						case 13:
							num5 = 11;
							goto IL_0039;
						case 12:
							num2 = 2;
							num = 7;
							continue;
						case 11:
							num4 = (char_2 as char[])[86] - 50889;
							goto IL_0023;
						case 10:
							num3 = 0;
							num2 = 2;
							num = char_[357] - 23598;
							continue;
						case 9:
							num2 = ((char[])char_2)[44] - 42127;
							num = int_[341] - 56424;
							continue;
						default:
							num = 16;
							continue;
						case 7:
							break;
						case 4:
							goto IL_018d;
						case 3:
							obj = Class10.smethod_1((ResolveEventArgs)gparam_0, (short)278, 'Ą');
							num2 = ((char[])char_3)[528] - 59944;
							num = char_[304] - 21787;
							continue;
						case 2:
							obj = null;
							num2 = 3;
							num = char_[347] - 59827;
							continue;
						case 1:
							num2 = (char_3 as char[])[503] - 33691;
							num = 7;
							continue;
						case 0:
							goto IL_0219;
						case 15:
							goto end_IL_0246;
						case 16:
							goto end_IL_029d;
						case 17:
							{
								return obj as string;
							}
							IL_0039:
							num2 = num5;
							num = 7;
							continue;
							IL_0023:
							num2 = num4;
							goto case 6;
						}
						num = num2 switch
						{
							0 => 17, 
							1 => char_[300] - 50286, 
							2 => 4, 
							3 => char_[54] - char_[54], 
							4 => 2, 
							5 => 17, 
							6 => char_[409] - 20533, 
							7 => int_[35] - 51986, 
							8 => int_[117] - 18037, 
							9 => 0, 
							10 => char_[115] - 24189, 
							11 => char_[263] - 48150, 
							_ => char_[275] - 58403, 
						};
						continue;
						IL_0219:
						num3++;
						num = (((short_0 * short_0 + short_0) % 2 == 0) ? (char_[255] - 34334) : (int_[382] - 31292));
						continue;
						IL_018d:
						num = (((short_0 ^ int_0) - 61) ^ num3) switch
						{
							0 => 13, 
							_ => 5, 
						};
						continue;
						end_IL_0246:
						break;
					}
					continue;
					end_IL_029d:
					break;
				}
			}
		}

		internal static Assembly smethod_1(char char_0, short short_0)
		{
			int[] int_ = Class0.int_0;
			char[] char_ = Class1.char_1;
			int num4 = default(int);
			int num2 = default(int);
			object obj = default(object);
			while (true)
			{
				Array char_2 = Class1.char_0;
				Array char_3 = Class0.char_0;
				int num = int_[79] - 21880;
				while (true)
				{
					int num7;
					int num3;
					switch (num)
					{
					default:
						num = 11;
						continue;
					case 18:
					case 19:
						num7 = 3;
						goto IL_001a;
					case 16:
						num = (((char_0 ^ short_0) - 52) ^ num4) switch
						{
							0 => 2, 
							1 => 13, 
							_ => int_[106] - 43908, 
						};
						continue;
					case 15:
						num3 = 2;
						goto IL_0065;
					case 14:
						num = num2 switch
						{
							0 => 17, 
							1 => char_[130] - 54081, 
							2 => 6, 
							3 => 8, 
							4 => 9, 
							5 => int_[21] - int_[21], 
							6 => 12, 
							7 => char_[343] - 25192, 
							8 => int_[342] - 28908, 
							9 => 10, 
							10 => 16, 
							11 => int_[208] - 48873, 
							12 => char_[327] - 26020, 
							_ => 12, 
						};
						continue;
					case 13:
						num3 = 4;
						goto IL_0065;
					case 12:
						num2 = 9;
						num = 14;
						continue;
					case 10:
						num4 = 0;
						num2 = 10;
						goto case 5;
					case 5:
						num = 14;
						continue;
					case 9:
						obj = Class10.Class11.Class12.smethod_2(292, 'Ħ');
						num2 = 8;
						num = int_[226] - 24395;
						continue;
					case 8:
						num2 = (char_2 as char[])[50] - 3014;
						num = 14;
						continue;
					case 7:
						num7 = 0;
						goto IL_001a;
					case 6:
					{
						obj = null;
						char num8 = ((char[])char_2)[166];
						Class0.int_0[348] = (Class0.int_0[348] | Class1.char_1[363]) & 0x9B;
						num2 = num8 - 25425;
						num = 14;
						continue;
					}
					case 4:
						num2 = (char_3 as char[])[272] - 58927;
						num = 14;
						continue;
					case 3:
						num4++;
						goto case 1;
					case 1:
					{
						int num5 = 373;
						int num6 = 620;
						num = ((2480 > num6 - num5 * 4) ? 7 : 18);
						continue;
					}
					case 2:
						num3 = 5;
						goto IL_0065;
					case 0:
						obj = Class10.Class11.Class12.smethod_2(56, ':');
						num2 = (char_2 as char[])[370] - 48190;
						num = char_[7] - 5759;
						continue;
					case 11:
						break;
					case 17:
						{
							return (Assembly)((obj is _Assembly) ? obj : null);
						}
						IL_001a:
						num2 = num7;
						num = char_[344] - 64725;
						continue;
						IL_0065:
						num2 = num3;
						num = 14;
						continue;
					}
					break;
				}
			}
		}

		internal static byte[] smethod_2<T>(T gparam_0, int int_0, char char_0, short short_0) where T : BinaryReader
		{
			char[] char_ = Class1.char_1;
			int[] int_ = Class0.int_0;
			int num4 = default(int);
			int num3 = default(int);
			ICollection collection = default(ICollection);
			int num2 = default(int);
			while (true)
			{
				Array char_2 = Class0.char_0;
				object char_3 = Class1.char_0;
				int num = 19;
				while (true)
				{
					int num6;
					int num5;
					switch (num)
					{
					case 19:
						num4 = 0;
						num3 = (char_2 as char[])[71] - 32257;
						num = 2;
						continue;
					case 18:
						collection = Class10.smethod_2((BinaryReader)gparam_0, int_0, '\n', 25);
						num3 = 2;
						num = int_[153] - int_[142];
						continue;
					case 17:
						num = (((short_0 ^ char_0) - 33) ^ num4) switch
						{
							0 => 3, 
							_ => char_[319] - 32251, 
						};
						continue;
					case 16:
						num = 2;
						continue;
					case 15:
						num3 = ((char[])char_2)[233] - 658;
						num = 2;
						continue;
					case 13:
						num6 = ((char[])char_3)[72] - 49929;
						goto IL_00b4;
					case 12:
					{
						char num7 = ((char[])char_2)[116];
						Class1.char_0[134] = (char)((Class1.char_0[134] ^ Class0.char_0[422]) & '\u0015');
						num3 = num7 - 13290;
						goto case 16;
					}
					case 6:
					case 10:
					case 11:
						num5 = (char_2 as char[])[446] - 41120;
						goto IL_0113;
					case 9:
						num6 = ((char[])char_3)[37] - 17909;
						goto IL_00b4;
					default:
						num = char_[153] - 3021;
						continue;
					case 5:
						collection = null;
						num3 = 2;
						num = 2;
						continue;
					case 4:
						num4++;
						num = 1;
						continue;
					case 3:
						num5 = (char_2 as char[])[386] - 14550;
						goto IL_0113;
					case 2:
						num = num3 switch
						{
							0 => 0, 
							1 => 19, 
							2 => int_[208] - 48872, 
							3 => 15, 
							4 => 4, 
							5 => int_[13] - 44990, 
							6 => char_[129] - 48424, 
							7 => 12, 
							8 => 1, 
							9 => int_[282] - 41415, 
							10 => char_[194] - 24620, 
							11 => char_[301] - 31011, 
							_ => 15, 
						};
						continue;
					case 1:
						num2 = char_0 * char_0;
						num2 = char_0 + num2;
						num3 = 0;
						num = 2;
						continue;
					case 0:
						num = ((num2 % 2 != 0) ? (int_[200] - 30359) : 9);
						continue;
					case 8:
						break;
					case 14:
						{
							return (collection as Array) as byte[];
						}
						IL_0113:
						num3 = num5;
						num = 2;
						continue;
						IL_00b4:
						num3 = num6;
						num = char_[395] - 2470;
						continue;
					}
					break;
				}
			}
		}

		internal static object smethod_3<T, U>(T gparam_0, U gparam_1, int int_0, short short_0) where T : AppDomain where U : string
		{
			char[] char_ = Class1.char_1;
			int[] int_ = Class0.int_0;
			int num3 = default(int);
			int num2 = default(int);
			int num7 = default(int);
			object result = default(object);
			while (true)
			{
				object char_2 = Class1.char_0;
				int num = int_[135] - 26706;
				while (true)
				{
					int num8;
					int num4;
					switch (num)
					{
					case 19:
						num3 = 9;
						num = int_[225] - 24486;
						continue;
					case 18:
						Class1.char_0[54] = (char)((Class1.char_0[54] ^ short_0) & 'ó');
						num = (((short_0 ^ int_0) - 57) ^ num2) switch
						{
							0 => int_[5] - 34977, 
							_ => 17, 
						};
						continue;
					case 17:
						num8 = 4;
						goto IL_006a;
					case 15:
						num4 = 8;
						goto IL_007d;
					case 14:
						num3 = (char_2 as char[])[180] - 11277;
						num = 7;
						continue;
					case 13:
						num8 = 7;
						goto IL_006a;
					case 12:
						num2++;
						num7 = 286;
						num = 6;
						continue;
					default:
						num = char_[36] - 62606;
						continue;
					case 10:
						num = char_[205] - 64328;
						continue;
					case 9:
						num3 = 5;
						num = 7;
						continue;
					case 7:
						num = num3 switch
						{
							0 => 14, 
							1 => 3, 
							2 => 16, 
							3 => 9, 
							4 => 3, 
							5 => int_[240] - 62202, 
							6 => char_[398] - 50447, 
							7 => char_[6] - 62448, 
							8 => int_[237] - 51016, 
							9 => 18, 
							10 => int_[5] - 34974, 
							11 => char_[362] - 45928, 
							_ => 9, 
						};
						continue;
					case 6:
					{
						int num6 = 355;
						num = ((2485 > num6 - num7 * 7) ? (int_[6] - 26805) : (char_[284] - 49260));
						continue;
					}
					case 5:
					{
						result = Class10.Class11.smethod_2((AppDomain)gparam_0, (string)gparam_1, 'Ľ', 'Ė');
						num3 = 11;
						char num5 = char_[304];
						Class0.int_0[398] = (Class0.int_0[398] + short_0) & 0xD3;
						num = num5 - 21787;
						continue;
					}
					case 4:
						num4 = 2;
						goto IL_007d;
					case 3:
						result = null;
						num3 = 11;
						goto case 10;
					case 2:
						num2 = 0;
						num3 = 9;
						goto case 1;
					case 1:
						num = 7;
						continue;
					case 0:
						break;
					case 16:
						{
							return result;
						}
						IL_007d:
						num3 = num4;
						num = 7;
						continue;
						IL_006a:
						num3 = num8;
						num = char_[68] - 16540;
						continue;
					}
					break;
				}
			}
		}

		internal static Evidence smethod_4<T>(T gparam_0, int int_0, int int_1) where T : Assembly
		{
			int[] int_2 = Class0.int_0;
			char[] char_ = Class1.char_1;
			int num7 = default(int);
			int num5 = default(int);
			int num2 = default(int);
			int num3 = default(int);
			object obj = default(object);
			while (true)
			{
				object char_2 = Class0.char_0;
				Array char_3 = Class1.char_0;
				int num = char_[408] - 13851;
				while (true)
				{
					int num4;
					int num8;
					switch (num)
					{
					default:
						num = int_2[65] - 40437;
						continue;
					case 19:
						num4 = 7;
						goto IL_0022;
					case 16:
						num = 8;
						continue;
					case 18:
						num7 = num5 + num7;
						goto case 4;
					case 4:
						num = ((num7 % 2 != 0) ? 17 : (char_[3] - 50873));
						continue;
					case 17:
						num8 = (char_3 as char[])[224] - 10349;
						goto IL_0062;
					case 15:
						num2 = 11;
						num = 8;
						continue;
					case 14:
						num8 = 1;
						goto IL_0062;
					case 12:
						Class0.int_0[71] = (Class0.int_0[71] | int_1) & 0xF4;
						num = (((int_0 ^ int_1) - 51) ^ num3) switch
						{
							0 => 3, 
							_ => char_[254] - 39004, 
						};
						continue;
					case 9:
					case 10:
						obj = null;
						num = char_[305] - 23692;
						continue;
					case 8:
						num = num2 switch
						{
							0 => 15, 
							1 => 13, 
							2 => int_2[38] - 59992, 
							3 => 1, 
							4 => 0, 
							5 => 7, 
							6 => 2, 
							7 => 10, 
							8 => 5, 
							9 => 2, 
							10 => char_[327] - 26006, 
							11 => 12, 
							_ => int_2[228] - 33272, 
						};
						continue;
					case 7:
						num2 = 8;
						num = 8;
						continue;
					case 6:
						num2 = 10;
						num = char_[366] - 62102;
						continue;
					case 5:
					{
						num3++;
						num5 = 874;
						int num6 = num5;
						num7 = num6 * num6;
						num = 6;
						continue;
					}
					case 3:
						num4 = 4;
						goto IL_0022;
					case 2:
						num3 = 0;
						num2 = (char_2 as char[])[236] - 48467;
						num = 8;
						continue;
					case 1:
						num2 = 6;
						num = 8;
						continue;
					case 0:
						obj = Class7.smethod_1((Assembly)gparam_0, (short)590, (short)597);
						num2 = 8;
						num = 8;
						continue;
					case 11:
						break;
					case 13:
						{
							return (Evidence)obj;
						}
						IL_0062:
						num2 = num8;
						num = 8;
						continue;
						IL_0022:
						num2 = num4;
						goto case 16;
					}
					break;
				}
			}
		}

		internal static string[] smethod_5<T>(T gparam_0, short short_0, int int_0) where T : Assembly
		{
			char[] char_ = Class1.char_1;
			int[] int_ = Class0.int_0;
			int num2 = default(int);
			int num5 = default(int);
			object obj = default(object);
			while (true)
			{
				object char_2 = Class0.char_0;
				int num = 15;
				while (true)
				{
					int num3;
					int num6;
					switch (num)
					{
					case 5:
					case 17:
						num2 = 7;
						num = 3;
						continue;
					case 16:
						num2 = 10;
						num = int_[180] - 49725;
						continue;
					case 15:
						num5 = 0;
						num2 = 10;
						num = 3;
						continue;
					case 14:
						num5++;
						num = (((short_0 * short_0 + short_0) % 2 == 0) ? (char_[68] - 16534) : (char_[7] - 5772));
						continue;
					case 13:
						num3 = ((char[])char_2)[398] - 43434;
						goto IL_0080;
					case 11:
						num6 = 1;
						goto IL_0092;
					case 10:
						obj = Class10.Class11.Class12.smethod_3((Assembly)gparam_0, 'Ö', 249);
						num2 = 11;
						num = int_[369] - 3795;
						continue;
					case 9:
						num6 = 8;
						goto IL_0092;
					case 8:
						num2 = ((char[])char_2)[538] - 16715;
						num = 3;
						continue;
					default:
						num = 18;
						continue;
					case 6:
					{
						int num4 = int_0 ^ short_0;
						Class1.char_0[303] = (char)((Class1.char_0[303] ^ short_0) & '\u0006');
						num = ((num4 - 59) ^ num5) switch
						{
							0 => int_[199] - 34246, 
							_ => int_[382] - 31299, 
						};
						continue;
					}
					case 3:
						num = num2 switch
						{
							0 => char_[5] - 45979, 
							1 => 2, 
							2 => int_[359] - 19700, 
							3 => int_[132] - 44262, 
							4 => 0, 
							5 => 4, 
							6 => char_[277] - 32568, 
							7 => 15, 
							8 => 10, 
							9 => 10, 
							10 => 6, 
							11 => int_[275] - 60764, 
							_ => char_[398] - 50448, 
						};
						continue;
					case 2:
						obj = null;
						goto case 8;
					case 1:
						num3 = (char_2 as char[])[464] - 1556;
						goto IL_0080;
					case 0:
						num2 = 10;
						num = char_[336] - 26411;
						continue;
					case 18:
						break;
					case 4:
					case 12:
						{
							return obj as string[];
						}
						IL_0092:
						num2 = num6;
						num = 3;
						continue;
						IL_0080:
						num2 = num3;
						num = int_[4] - 29792;
						continue;
					}
					break;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 206)]
	private struct Struct3
	{
	}

	private static readonly object object_0;

	private static readonly object object_1;

	private static readonly object object_2;

	internal static Struct3 struct3_0/* Not supported: data(22 50 BE 50 22 50 CC 5D 64 4F B3 53 56 44 55 7E 3B 57 90 48 7B 6F CF 5D 7C 4F BF 53 5D 44 03 7E 36 57 9C 48 7C 6F C2 5D 7D 4F B6 53 18 44 44 7E 39 57 94 48 62 6F D4 5D 7D 4F A3 53 56 44 55 7E 30 57 87 48 65 6F D4 5D 64 4F B3 53 5B 44 48 7E 79 57 C5 48 3E 6F 90 5D 26 4F F6 53 16 44 58 7E 68 57 9B 48 7F 6F C9 5D 7B 4F B4 53 5D 44 1E 7E 75 57 D9 48 62 6F C5 5D 6C 4F A7 53 57 44 04 7E 27 57 90 48 74 6F C1 5D 67 4F AA 53 4A 44 0D 7E 31 57 94 48 7F 6F CC 5D 7A 4F A3 53 5C 44 09 7E 3A 57 99 48 75 6F CD 5D 67 4F B4 53 50 44 0B 7E 75 57 90 48 7C 6F C7 5D 67 4F A9 53 5F 44 BA F6 BF F6 BB F6 0C FB D5 E9 6D F5 E6 E2 DD D8) */;

	static Class4()
	{
		int[] int_ = Class0.int_0;
		int num = 1;
		char[] array = default(char[]);
		while (true)
		{
			switch (num)
			{
			case 8:
				array[2] = 'ᣗ';
				goto case 0;
			case 0:
				array[3] = 'ݷ';
				num = 3;
				continue;
			case 4:
			case 6:
				num = 8;
				continue;
			case 5:
				array[0] = '\u0d82';
				object_2 = new string[2];
				object_0 = array;
				num = 7;
				continue;
			case 3:
				array[5] = 'ᐚ';
				array[4] = '⹊';
				num = int_[237] - 51030;
				continue;
			case 2:
				array[1] = '㼲';
				array[7] = 'Ἢ';
				goto case 4;
			case 7:
				Class5.Class6.smethod_0();
				return;
			}
			object_1 = new char[103]
			{
				'倢', '傾', '倢', '巌', '佤', '厳', '䑖', '繕', '圻', '䢐',
				'潻', '巏', '佼', '县', '䑝', '縃', '圶', '䢜', '潼', '巂',
				'佽', '厶', '䐘', '繄', '圹', '䢔', '潢', '巔', '佽', '厣',
				'䑖', '繕', '地', '䢇', '潥', '巔', '佤', '厳', '䑛', '繈',
				'坹', '䣅', '漾', '嶐', '伦', '叶', '䐖', '繘', '坨', '䢛',
				'潿', '巉', '佻', '厴', '䑝', '縞', '坵', '䣙', '潢', '巅',
				'佬', '厧', '䑗', '縄', '圧', '䢐', '潴', '巁', '佧', '厪',
				'䑊', '縍', '圱', '䢔', '潿', '巌', '佺', '厣', '䑜', '縉',
				'场', '䢙', '潵', '巍', '佧', '厴', '䑐', '縋', '坵', '䢐',
				'潼', '巇', '佧', '厩', '䑟', '\uf6ba', '\uf6bf', '\uf6bb', '\ufb0c', '\ue9d5',
				'\uf56d', '\ue2e6', '\ud8dd'
			};
			array = new char[8] { '\0', '\0', '\0', '\0', '\0', '\0', 'Ϥ', '\0' };
			num = 2;
		}
	}

	internal static string smethod_0(long long_0, int int_0, Assembly assembly_0, int int_1)
	{
		char[] char_ = Class1.char_1;
		int[] int_2 = Class0.int_0;
		int num2 = default(int);
		int num8 = default(int);
		char[] array2 = default(char[]);
		int num7 = default(int);
		char[] array3 = default(char[]);
		int num5 = default(int);
		int num12 = default(int);
		char[] array = default(char[]);
		int num6 = default(int);
		int num9 = default(int);
		int num4 = default(int);
		char c = default(char);
		string text = default(string);
		StringBuilder gparam_ = default(StringBuilder);
		while (true)
		{
			char[] char_2 = Class0.char_0;
			int num = 23;
			while (true)
			{
				int num3;
				int num11;
				int num10;
				switch (num)
				{
				default:
					num = char_[293] - 17522;
					continue;
				case 32:
					num2 = 0;
					num = int_2[103] - 47432;
					continue;
				case 31:
					num3 = 11;
					goto IL_0039;
				case 2:
				case 29:
					num2 = 2;
					goto case 16;
				case 16:
					num = int_2[371] - 59893;
					continue;
				case 28:
					num11 = char_2[355] - 10853;
					goto IL_0065;
				case 27:
					num8 = array2.Length;
					num7 = 1;
					num = 32;
					continue;
				case 26:
				{
					char[] array5 = array3;
					char[] obj = (char[])object_0;
					num5 = num12;
					array2 = obj;
					array = array5;
					num2 = 5;
					num = int_2[125] - 18031;
					continue;
				}
				case 25:
					num5 += 3;
					num6 = (num9 & 0x1F) | ((num9 & 0xFFC0) >> 1);
					num = 22;
					continue;
				case 24:
					num2 = 17;
					num = int_2[371] - 59893;
					continue;
				case 23:
				{
					num12 = int_0 ^ 0x3A90AD16 ^ int_1;
					array3 = (char[])object_1;
					char[] array4 = array3;
					num4 = array4[num12];
					num4 = array4[num12 + 2] ^ num4;
					num = 24;
					continue;
				}
				case 22:
					num2 = 8;
					num = char_[305] - 23692;
					continue;
				case 13:
				case 21:
					num6 = (num6 << 15) | (array[num5++] ^ c);
					num = 10;
					continue;
				case 20:
					num = (((num9 & 0x20) == 0) ? 28 : (int_2[39] - 29867));
					continue;
				case 19:
					num10 = 16;
					goto IL_016b;
				case 18:
					num11 = 13;
					goto IL_0065;
				case 17:
					num = (((text = ((string[])object_2)[num4]) == null) ? 19 : 14);
					continue;
				case 15:
					num2 = char_2[520] - 56461;
					num = 7;
					continue;
				case 14:
					num10 = 10;
					goto IL_016b;
				case 12:
					num7++;
					num2 = 0;
					num = 7;
					continue;
				case 11:
					num = ((num7 <= num6) ? 1 : 31);
					continue;
				case 10:
					num2 = 3;
					num = char_[364] - 40276;
					continue;
				case 8:
					gparam_ = (StringBuilder)(ISerializable)new StringBuilder();
					c = array[num5];
					num9 = array[num5 + 1] ^ c;
					num = 5;
					continue;
				case 7:
					num = num2 switch
					{
						0 => 11, 
						1 => 29, 
						2 => 23, 
						3 => int_2[63] - 54715, 
						4 => 26, 
						5 => 8, 
						6 => char_[108] - 32492, 
						7 => 32, 
						8 => int_2[212] - 50091, 
						9 => 4, 
						10 => 9, 
						11 => 3, 
						12 => int_2[28] - 2674, 
						13 => 13, 
						14 => 6, 
						15 => int_2[292] - 10280, 
						16 => char_[301] - 30990, 
						17 => 17, 
						_ => 29, 
					};
					continue;
				case 6:
					Class10.Class11.smethod_3(gparam_, (char)(c ^ array[num5 + num6 - num7] ^ array2[(num7 + num5 + 17) % num8]), 218, 140);
					num = int_2[166] - 32233;
					continue;
				case 5:
					num2 = 15;
					num = int_2[69] - 12064;
					continue;
				case 3:
					text = (string)(IConvertible)Class10.Class11.Class12.smethod_4((object)gparam_, 'Ȟ', (short)609);
					((string[])object_2)[num4] = text;
					num = char_[343] - 25186;
					continue;
				case 1:
					num3 = 14;
					goto IL_0039;
				case 0:
					num2 = 12;
					num = int_2[222] - 32239;
					continue;
				case 30:
					break;
				case 4:
					return text;
				case 9:
					{
						return text;
					}
					IL_0039:
					num2 = num3;
					num = 7;
					continue;
					IL_016b:
					num2 = num10;
					num = 7;
					continue;
					IL_0065:
					num2 = num11;
					num = char_[24] - 4585;
					continue;
				}
				break;
			}
		}
	}

	internal static Encoding smethod_1(short short_0, char char_0)
	{
		int[] int_ = Class0.int_0;
		char[] char_ = Class1.char_1;
		int num5 = default(int);
		int num3 = default(int);
		object obj = default(object);
		while (true)
		{
			Array char_2 = Class1.char_0;
			object char_3 = Class0.char_0;
			while (true)
			{
				int num = char_[227] - 26166;
				while (true)
				{
					int num2;
					int num4;
					switch (num)
					{
					case 18:
						break;
					case 17:
						num5 = 0;
						num3 = (char_2 as char[])[41] - 32800;
						num = int_[66] - 26758;
						continue;
					case 16:
						num2 = 3;
						goto IL_0116;
					case 15:
						goto IL_012b;
					case 11:
					case 14:
						num4 = ((char[])char_3)[255] - 720;
						goto IL_017b;
					case 13:
						num3 = 8;
						num = int_[123] - 12091;
						continue;
					case 9:
					case 12:
						goto IL_0198;
					case 10:
						num4 = 10;
						goto IL_017b;
					case 7:
						num3 = 8;
						num = int_[290] - 13651;
						continue;
					case 6:
						obj = null;
						num3 = 4;
						num = char_[22] - 22568;
						continue;
					case 4:
						obj = Class10.Class11.Class12.smethod_5(544, 526);
						num3 = 4;
						num = 18;
						continue;
					default:
						num = int_[70] - 12776;
						continue;
					case 2:
						num3 = (char_2 as char[])[35] - 23396;
						num = int_[152] - 49934;
						continue;
					case 0:
						num2 = 1;
						goto IL_0116;
					case 1:
						goto end_IL_022a;
					case 5:
						goto end_IL_0281;
					case 8:
						{
							return (Encoding)obj;
						}
						IL_017b:
						num3 = num4;
						num = 18;
						continue;
						IL_0116:
						num3 = num2;
						num = char_[216] - 22874;
						continue;
					}
					num = num3 switch
					{
						0 => int_[44] - 12402, 
						1 => char_[118] - 46112, 
						2 => 13, 
						3 => 6, 
						4 => char_[54] - 21466, 
						5 => 13, 
						6 => char_[392] - 43173, 
						7 => char_[329] - 26896, 
						8 => 9, 
						9 => 7, 
						10 => 8, 
						11 => int_[211] - 56600, 
						_ => char_[408] - 13851, 
					};
					continue;
					IL_0198:
					num = (((char_0 ^ short_0) - 12) ^ num5) switch
					{
						0 => 0, 
						_ => 16, 
					};
					continue;
					IL_012b:
					num5++;
					int num6 = 233;
					int num7 = 353;
					num = ((2118 > num7 - num6 * 6) ? 10 : (int_[222] - 32232));
					continue;
					end_IL_022a:
					break;
				}
				continue;
				end_IL_0281:
				break;
			}
		}
	}
}
