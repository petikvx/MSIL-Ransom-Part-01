using System;
using System.Collections;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using ns0;

public sealed class BabelAttribute : Attribute
{
	internal sealed class Class0
	{
		[SecuritySafeCritical]
		internal static string smethod_0()
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			int num2 = default(int);
			while (true)
			{
				object byte_3 = Class1.byte_0;
				int num = (int)byte_[45] / 7;
				while (true)
				{
					switch (num)
					{
					case 2:
						num2 = (byte_3 as byte[])[80] - 150;
						goto case 0;
					case 0:
						num = 4;
						goto case 4;
					case 7:
						num2 = (byte_3 as byte[])[33];
						num = 4;
						goto case 4;
					case 4:
						switch (num2)
						{
						case 1:
							break;
						case 2:
							goto IL_0056;
						default:
							goto IL_008e;
						case 0:
							goto IL_009d;
						case 3:
							goto IL_00aa;
						case 4:
							goto IL_00f0;
						case 5:
							goto IL_00f4;
						}
						num = 7;
						goto case 7;
					case 9:
						Class9.smethod_13(smethod_8(844, 824), Class4.Class5.Class6.smethod_7(1486502120, 7L, 0), null, 616, 575);
						goto case 2;
					default:
						num = 3;
						break;
					case 3:
						break;
					case 6:
					case 8:
						{
							Class9.Class12.smethod_6();
							return null;
						}
						IL_00f4:
						num = 8;
						goto case 6;
						IL_00f0:
						num = 8;
						goto case 6;
						IL_00aa:
						num = byte_2[13] * 3;
						continue;
						IL_009d:
						num = byte_[155] - 78;
						continue;
						IL_008e:
						num = byte_2[41] - byte_2[314];
						continue;
						IL_0056:
						num = 9;
						goto case 9;
					}
					break;
				}
			}
		}

		internal static Type smethod_1()
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			while (true)
			{
				object byte_3 = Class2.byte_0;
				object byte_4 = Class1.byte_0;
				int num = 10;
				while (true)
				{
					int num2 = 2643;
					int num3 = 204;
					num = 7;
					while (true)
					{
						IL_00df:
						if (881 < num2 / 3 - num3)
						{
							num = 2;
							goto IL_00d3;
						}
						num = 12;
						goto IL_00b6;
						IL_00c6:
						int num4;
						int num5 = num4;
						num = byte_2[165] * 2;
						while (true)
						{
							switch (num)
							{
							case 9:
								break;
							case 0:
							case 4:
							case 8:
								goto IL_003b;
							case 11:
							case 12:
								goto end_IL_007a;
							case 2:
								goto IL_00d3;
							case 7:
								goto IL_00df;
							case 10:
								goto end_IL_00df;
							default:
								num = 6;
								goto end_IL_00f5;
							case 6:
								goto end_IL_00f5;
							case 1:
								goto IL_011e;
							case 5:
								goto IL_012a;
							}
							goto IL_0018;
							IL_0018:
							num5 = (byte_3 as byte[])[51] - (byte_3 as byte[])[5];
							num = 8;
							goto IL_003b;
							IL_003b:
							switch (num5)
							{
							case 6:
								goto IL_0036;
							case 0:
								goto IL_005f;
							case 5:
								goto IL_006f;
							case 2:
								goto IL_00d6;
							case 1:
								goto IL_00f2;
							case 4:
								goto IL_011c;
							case 3:
								goto IL_0128;
							}
							num = 9;
							goto IL_0018;
							IL_011c:
							num = 1;
							goto IL_011e;
							IL_011e:
							smethod_1();
							num5 = 3;
							num = 8;
							goto IL_0128;
							IL_0128:
							num = 5;
							goto IL_012a;
							IL_012a:
							Type typeFromHandle = typeof(BabelAttribute);
							Class9.Class11.smethod_9();
							return typeFromHandle;
							IL_00f2:
							num = 10;
							goto end_IL_00df;
							IL_00d6:
							num = 7;
							goto IL_00df;
							IL_006f:
							num = byte_[47] - 175;
							continue;
							IL_005f:
							num = byte_[144] - 168;
							continue;
							IL_0036:
							num = 9;
							goto IL_0018;
							continue;
							end_IL_007a:
							break;
						}
						goto IL_00b6;
						IL_00b6:
						num4 = (byte_4 as byte[])[53] - 161;
						goto IL_00c6;
						IL_00d3:
						num4 = 3;
						goto IL_00c6;
						continue;
						end_IL_00df:
						break;
					}
					continue;
					end_IL_00f5:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static object smethod_2()
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			object obj = default(object);
			int num3 = default(int);
			int num2 = default(int);
			while (true)
			{
				Array byte_3 = Class1.byte_0;
				Array byte_4 = Class2.byte_0;
				int num = byte_[122];
				while (true)
				{
					int num8;
					int num4;
					int num6;
					int num5;
					switch (num)
					{
					case 26:
						num2++;
						num3 = (byte_3 as byte[])[201] - 157;
						goto case 12;
					case 12:
						num = byte_[293] - 189;
						continue;
					case 25:
						num8 = (int)(byte_3 as byte[])[67] / 9;
						goto IL_004b;
					case 24:
						if (208 != ((byte[])obj)[num2])
						{
							num = 18;
							goto case 18;
						}
						num = byte_2[206] - 91;
						continue;
					case 18:
						num4 = ((byte[])byte_4)[238] - 23;
						goto IL_007c;
					case 23:
						smethod_1();
						num3 = 14;
						num = 8;
						goto IL_00aa;
					case 20:
						num6 = (int)((byte[])byte_3)[141] / 4;
						goto IL_00ce;
					case 6:
						if ((obj as byte[])[num2] >= 208)
						{
							num = 5;
							goto case 5;
						}
						num = byte_2[117] + 8;
						continue;
					case 5:
						num6 = ((byte[])byte_3)[83] - ((byte[])byte_3)[164];
						goto IL_00ce;
					case 8:
					case 13:
						switch (num3)
						{
						case 14:
							break;
						case 3:
							goto IL_00d3;
						default:
							goto IL_0147;
						case 1:
							goto IL_0158;
						case 2:
							goto IL_0167;
						case 4:
							goto IL_0178;
						case 7:
							goto IL_0180;
						case 8:
							goto IL_0190;
						case 9:
							goto IL_01e5;
						case 10:
							goto IL_0219;
						case 11:
							goto IL_0226;
						case 12:
							goto IL_022f;
						case 13:
							goto IL_023c;
						case 5:
							goto IL_032a;
						case 6:
							goto IL_0334;
						case 0:
							goto IL_0340;
						}
						goto IL_00aa;
					case 2:
						num3 = 2;
						num = byte_2[25] - 36;
						continue;
					case 10:
						num2 = 0;
						obj = (byte[])Class4.smethod_6(smethod_8(118, 3), Class4.Class5.Class6.smethod_7(1486502125, 5L, 5), 692, 'ʩ');
						num = 16;
						goto case 16;
					case 16:
						num3 = ((byte[])byte_3)[119] - 109;
						num = byte_2[85] - 2;
						continue;
					case 11:
					{
						byte num7 = ((byte[])obj)[num2];
						Class2.byte_0[342] = Class1.byte_0[93];
						if (8 != num7)
						{
							num = 7;
							goto case 7;
						}
						num = 25;
						goto case 25;
					}
					case 7:
						num8 = 13;
						goto IL_004b;
					case 19:
						num5 = ((byte[])byte_4)[135];
						goto IL_0256;
					case 17:
						num4 = ((byte[])byte_4)[124];
						goto IL_007c;
					case 3:
						num5 = ((byte[])byte_3)[101] - ((byte[])byte_3)[210];
						goto IL_0256;
					case 0:
						if ((obj as byte[])[num2] >= 8)
						{
							num = 3;
							goto case 3;
						}
						num = 19;
						goto case 19;
					default:
						num = 9;
						break;
					case 9:
						break;
					case 14:
						Class9.Class12.smethod_3();
						return null;
					case 4:
						smethod_0();
						num3 = 0;
						num = 8;
						goto IL_0340;
					case 1:
					case 21:
						return null;
					case 22:
						{
							num2++;
							return null;
						}
						IL_0256:
						num3 = num5;
						num = 8;
						goto case 8;
						IL_00ce:
						num3 = num6;
						num = 8;
						goto case 8;
						IL_0334:
						num = 4;
						goto case 4;
						IL_0340:
						num = 22;
						goto case 22;
						IL_032a:
						num = 14;
						goto case 14;
						IL_023c:
						num = byte_[193] - 12;
						continue;
						IL_022f:
						num = byte_[123] - 182;
						continue;
						IL_0226:
						num = (int)byte_[13] / 3;
						continue;
						IL_0219:
						num = byte_2[165] - 80;
						continue;
						IL_01e5:
						num = 11;
						goto case 11;
						IL_007c:
						num3 = num4;
						num = byte_2[196] - byte_2[57];
						continue;
						IL_0190:
						num = 10;
						goto case 10;
						IL_0180:
						num = byte_2[71] - 148;
						continue;
						IL_0178:
						num = 26;
						goto case 26;
						IL_0167:
						num = 10;
						goto case 10;
						IL_0158:
						num = byte_[165] * 6;
						continue;
						IL_0147:
						num = 2;
						goto case 2;
						IL_00d3:
						num = 6;
						goto case 6;
						IL_004b:
						num3 = num8;
						num = (int)byte_2[9] / 3;
						continue;
						IL_00aa:
						num = byte_[333] - byte_[215];
						continue;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_3()
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			int num = 6;
			object obj = default(object);
			int num4 = default(int);
			int num2 = default(int);
			while (true)
			{
				object byte_3 = Class2.byte_0;
				while (true)
				{
					Array byte_4 = Class1.byte_0;
					switch (byte_2[98] - byte_2[98])
					{
					case 7:
						continue;
					case 0:
						num2 = 0;
						num = 5;
						goto case 5;
					case 5:
						obj = (byte[])Class4.smethod_6(smethod_8(986, 940), Class4.Class5.Class6.smethod_7(1486502127, 8L, 7), 636, 'ɢ');
						num = 1;
						goto case 1;
					case 1:
						while (((byte[])obj)[num2] >= 8)
						{
							int num3 = byte_[290] - 199;
							while (true)
							{
								int num9;
								int num7;
								int num8;
								int num6;
								int num5;
								switch (num3)
								{
								case 30:
									num9 = ((byte[])byte_4)[34] - 107;
									goto IL_00b5;
								case 12:
									if (65 == ((byte[])obj)[num2])
									{
										num3 = 23;
										goto case 23;
									}
									num3 = byte_[234] - byte_[240];
									continue;
								case 23:
									num7 = 15;
									goto IL_00da;
								case 24:
									smethod_1();
									num4 = (byte_3 as byte[])[355] - 99;
									goto case 8;
								case 8:
									num3 = 25;
									goto case 25;
								case 2:
									if (208 == (obj as byte[])[num2])
									{
										num3 = 15;
										goto case 15;
									}
									num3 = byte_[139];
									continue;
								case 15:
									num8 = ((byte[])byte_4)[225] - 188;
									goto IL_012f;
								case 10:
									if ((obj as byte[])[num2] >= 208)
									{
										num3 = 28;
										goto case 28;
									}
									num3 = byte_[119];
									continue;
								case 28:
									num9 = 10;
									goto IL_00b5;
								case 25:
									switch (num4)
									{
									case 13:
										break;
									case 11:
										goto IL_00e1;
									case 10:
										goto IL_0101;
									case 16:
										goto IL_0136;
									default:
										goto IL_01a6;
									case 0:
										goto IL_01b3;
									case 2:
										goto IL_01ca;
									case 4:
										goto IL_01dd;
									case 5:
										goto IL_01e9;
									case 6:
										goto IL_01ee;
									case 7:
										goto IL_01fe;
									case 8:
										goto IL_0225;
									case 3:
										goto IL_0233;
									case 9:
										goto IL_0261;
									case 12:
										goto IL_027a;
									case 14:
										goto IL_029f;
									case 15:
										goto IL_02ac;
									case 1:
										goto IL_03e5;
									case 17:
										num3 = 27;
										return;
									}
									num3 = 12;
									goto case 12;
								case 11:
								case 29:
									BabelAttribute.smethod_1();
									num4 = 15;
									num3 = byte_[15];
									continue;
								case 13:
									num3 = ((8 == ((byte[])obj)[num2]) ? (byte_2[19] - 54) : byte_[35]);
									continue;
								case 5:
									num2++;
									num4 = 3;
									num3 = 25;
									goto IL_0233;
								case 14:
									if ((obj as byte[])[num2] >= 65)
									{
										num3 = 21;
										goto case 21;
									}
									num3 = byte_2[117] + 4;
									continue;
								case 21:
									num6 = 13;
									goto IL_0249;
								case 22:
									num5 = 11;
									goto IL_02cb;
								case 19:
									num8 = (int)(byte_4 as byte[])[48] / 3;
									goto IL_012f;
								case 17:
									num7 = 0;
									goto IL_00da;
								case 16:
									num6 = (byte_3 as byte[])[350] - 21;
									goto IL_0249;
								case 9:
									num2++;
									num4 = 16;
									num3 = 25;
									goto IL_0136;
								case 7:
									num3 = 25;
									goto case 25;
								case 6:
									num4 = ((byte[])byte_3)[22];
									goto case 7;
								case 4:
									num5 = (byte_3 as byte[])[319] - 240;
									goto IL_02cb;
								case 1:
									num4 = 6;
									num3 = byte_[323] - byte_[319];
									continue;
								case 0:
									Class4.Class5.Class6.smethod_1();
									goto case 5;
								default:
									return;
								case 31:
									break;
								case 3:
									return;
								case 18:
									return;
								case 20:
									return;
								case 26:
									num2++;
									return;
								case 27:
									return;
									IL_02cb:
									num4 = num5;
									num3 = 25;
									goto case 25;
									IL_00b5:
									num4 = num9;
									num3 = 25;
									goto case 25;
									IL_03e5:
									num3 = 31;
									break;
									IL_02ac:
									num3 = byte_2[189] - 159;
									continue;
									IL_029f:
									num3 = byte_[63] - 109;
									continue;
									IL_027a:
									num3 = byte_[257] - 97;
									continue;
									IL_0261:
									num3 = byte_2[36] - 4;
									continue;
									IL_0225:
									num3 = 5;
									goto case 5;
									IL_0233:
									num3 = 14;
									goto case 14;
									IL_0249:
									num4 = num6;
									num3 = byte_[15];
									continue;
									IL_01fe:
									num3 = 13;
									goto case 13;
									IL_01ee:
									num3 = byte_2[47] - 158;
									continue;
									IL_01e9:
									num3 = 13;
									goto case 13;
									IL_01dd:
									num3 = (int)byte_[15] / 5;
									continue;
									IL_01ca:
									num3 = byte_2[153] - 142;
									continue;
									IL_01b3:
									num3 = 11;
									goto case 11;
									IL_01a6:
									num3 = byte_[111] - 103;
									continue;
									IL_0136:
									num3 = 10;
									goto case 10;
									IL_012f:
									num4 = num8;
									num3 = 25;
									goto case 25;
									IL_00e1:
									num3 = 24;
									goto case 24;
									IL_0101:
									num3 = 2;
									goto case 2;
									IL_00da:
									num4 = num7;
									num3 = 25;
									goto case 25;
								}
								break;
							}
						}
						goto case 2;
					case 2:
					case 3:
					case 4:
						Class9.Class10.smethod_7();
						return;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_4()
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			int num = 1;
			while (true)
			{
				Array byte_3 = Class1.byte_0;
				while (true)
				{
					Array byte_4 = Class2.byte_0;
					num = 6;
					int num2;
					while (true)
					{
						num2 = 0;
						switch (byte_2[153])
						{
						case 154:
							break;
						case 150:
							goto end_IL_0010;
						default:
							goto end_IL_0045;
						case 148:
						case 151:
						case 153:
							goto IL_0059;
						case 152:
							goto IL_06f7;
						}
						continue;
						end_IL_0010:
						break;
					}
					continue;
					IL_06f7:
					Class9.Class12.smethod_1();
					return;
					IL_0059:
					ICollection collection = (byte[])Class4.smethod_6(smethod_8(622, 537), Class4.Class5.Class6.smethod_7(1486502120, 8L, 0), 676, 'ʻ');
					while (((collection as Array) as byte[])[num2] >= 8)
					{
						int num3 = 31;
						while (true)
						{
							int num4 = 25;
							num3 = byte_2[186] - 112;
							while (true)
							{
								int num7;
								int num8;
								int num10;
								int num9;
								int num5;
								switch (num3)
								{
								case 49:
									num7 = 26;
									goto IL_00a1;
								case 16:
									break;
								case 12:
									goto IL_00c7;
								case 27:
									goto IL_00e2;
								case 11:
									goto IL_00fb;
								case 26:
									goto IL_0111;
								case 38:
									goto IL_011e;
								case 0:
									goto IL_013c;
								case 14:
									goto IL_01bc;
								case 44:
									goto IL_0211;
								case 48:
									goto IL_0298;
								case 28:
									goto IL_02c2;
								case 9:
									goto IL_0324;
								case 30:
									goto IL_034e;
								case 7:
									goto IL_0379;
								case 37:
									goto IL_03a8;
								case 47:
									BabelAttribute.smethod_3();
									goto IL_011e;
								case 46:
									smethod_0();
									num4 = 8;
									num3 = byte_2[9] - 24;
									continue;
								case 2:
								case 45:
									goto IL_0411;
								case 43:
									if (((byte[])(collection as Array))[num2] >= 208)
									{
										num3 = 5;
										goto case 5;
									}
									num3 = byte_2[14] - byte_2[20];
									continue;
								case 5:
									num8 = (int)((byte[])byte_3)[126] / 5;
									goto IL_043c;
								case 42:
									num2++;
									num4 = (byte_4 as byte[])[385] - 55;
									num3 = byte_[234] - 75;
									continue;
								case 39:
									num10 = 11;
									goto IL_0481;
								case 36:
									BabelAttribute.smethod_4();
									goto case 42;
								case 35:
									num10 = 7;
									goto IL_0481;
								case 33:
									num7 = 20;
									goto IL_00a1;
								case 1:
								case 32:
									Class4.Class5.smethod_0();
									goto IL_0211;
								case 29:
									if (((collection as Array) as byte[])[num2] >= 65)
									{
										num3 = 49;
										goto case 49;
									}
									num3 = byte_2[98] - 181;
									continue;
								case 24:
									num8 = ((byte[])byte_3)[223] - (byte_3 as byte[])[51];
									goto IL_043c;
								case 22:
									num9 = 21;
									goto IL_04f1;
								case 21:
									num9 = 27;
									goto IL_04f1;
								case 19:
									goto IL_0508;
								case 18:
									goto IL_051d;
								case 17:
									num4 = 12;
									num3 = byte_2[189] - byte_2[160];
									continue;
								case 15:
									num5 = 18;
									goto IL_054e;
								case 8:
									num3 = byte_2[101] - byte_2[101];
									continue;
								case 10:
									if (65 != ((byte[])(collection as Array))[num2])
									{
										num3 = 39;
										goto case 39;
									}
									num3 = byte_2[90];
									continue;
								case 6:
								{
									if (116 != (((Array)collection) as byte[])[num2])
									{
										num3 = 15;
										goto case 15;
									}
									byte num6 = byte_2[85];
									Class2.byte_1[115] = (byte)((Class2.byte_1[115] * Class2.byte_1[194]) & 0xDF);
									num3 = num6 - 7;
									continue;
								}
								case 3:
									num5 = ((byte[])byte_3)[79] - 210;
									goto IL_054e;
								default:
									return;
								case 31:
									goto end_IL_05d9;
								case 40:
									goto end_IL_06aa;
								case 13:
									return;
								case 20:
									num2++;
									return;
								case 23:
									return;
								case 34:
									return;
								case 4:
									return;
								case 25:
									return;
								case 41:
									return;
									IL_043c:
									num4 = num8;
									num3 = 0;
									goto IL_013c;
									IL_00a1:
									num4 = num7;
									num3 = 0;
									goto IL_013c;
									IL_054e:
									num4 = num5;
									goto case 8;
									IL_04f1:
									num4 = num9;
									num3 = byte_2[98] - 214;
									continue;
									IL_0481:
									num4 = num10;
									num3 = 0;
									goto IL_013c;
								}
								goto IL_00af;
								IL_051d:
								int num11 = (int)(byte_4 as byte[])[449] / 9;
								goto IL_00d7;
								IL_0508:
								int num12 = (byte_4 as byte[])[339] - 36;
								goto IL_0391;
								IL_0411:
								int num13 = 23;
								goto IL_02c3;
								IL_013c:
								switch (num4)
								{
								case 25:
									break;
								case 15:
									goto IL_00de;
								case 2:
									goto IL_011a;
								case 4:
									goto IL_01b8;
								case 5:
									goto IL_01ea;
								case 6:
									goto IL_01f7;
								case 7:
									goto IL_020d;
								case 8:
									goto IL_0229;
								case 9:
									goto IL_023a;
								case 10:
									goto IL_024e;
								case 11:
									goto IL_0262;
								case 12:
									goto IL_0272;
								case 13:
									goto IL_0280;
								case 14:
									goto IL_0294;
								case 16:
									goto IL_02d3;
								case 17:
									goto IL_02e1;
								case 18:
									goto IL_02f1;
								case 19:
									goto IL_0301;
								case 21:
									goto IL_0312;
								case 22:
									goto IL_0320;
								case 23:
									goto IL_034a;
								case 24:
									goto IL_03a4;
								case 26:
									goto IL_03d7;
								case 27:
									goto IL_03e2;
								case 1:
									goto IL_06bf;
								default:
									num3 = 25;
									return;
								case 0:
									num3 = 4;
									return;
								case 3:
									num3 = 25;
									return;
								case 20:
									num3 = 41;
									return;
								}
								num3 = 16;
								goto IL_00af;
								IL_06bf:
								num3 = 40;
								goto end_IL_06aa;
								IL_03e2:
								num3 = byte_[200];
								continue;
								IL_03d7:
								num3 = byte_2[85];
								continue;
								IL_03a4:
								num3 = 37;
								goto IL_03a8;
								IL_03a8:
								BabelAttribute.smethod_0();
								num4 = 22;
								num3 = byte_[270] - 143;
								continue;
								IL_034a:
								num3 = 30;
								goto IL_034e;
								IL_034e:
								if (196 != ((collection as Array) as byte[])[num2])
								{
									num3 = byte_[302] - byte_[122];
									continue;
								}
								num3 = 7;
								goto IL_0379;
								IL_0111:
								int num14 = 17;
								goto IL_0113;
								IL_0113:
								num4 = num14;
								num3 = 0;
								goto IL_013c;
								IL_0379:
								num12 = (byte_3 as byte[])[172] - (byte_3 as byte[])[24];
								goto IL_0391;
								IL_0391:
								num4 = num12;
								num3 = byte_2[81] - 201;
								continue;
								IL_0320:
								num3 = 9;
								goto IL_0324;
								IL_0324:
								num2++;
								num4 = (byte_4 as byte[])[375];
								num3 = byte_2[164] - 112;
								continue;
								IL_0312:
								num3 = byte_2[44] - 107;
								continue;
								IL_0301:
								num3 = byte_[316] - 96;
								continue;
								IL_02f1:
								num3 = byte_2[85] + byte_2[83];
								continue;
								IL_02e1:
								num3 = (int)byte_[201] / 4;
								continue;
								IL_02d3:
								num3 = byte_2[35] - 87;
								continue;
								IL_0294:
								num3 = 48;
								goto IL_0298;
								IL_0298:
								if (((byte[])(Array)collection)[num2] >= 196)
								{
									num3 = byte_2[165] - 80;
									continue;
								}
								num3 = 28;
								goto IL_02c2;
								IL_00d7:
								num4 = num11;
								num3 = 0;
								goto IL_013c;
								IL_00af:
								if (8 != ((byte[])(Array)collection)[num2])
								{
									num3 = 12;
									goto IL_00c7;
								}
								num3 = byte_2[107] - 219;
								continue;
								IL_02c2:
								num13 = 0;
								goto IL_02c3;
								IL_02c3:
								num4 = num13;
								num3 = byte_[29] - 103;
								continue;
								IL_0280:
								num3 = byte_2[182] - 148;
								continue;
								IL_0272:
								num3 = byte_2[102] - 32;
								continue;
								IL_0262:
								num3 = (int)byte_[165] / 4;
								continue;
								IL_024e:
								num3 = byte_[229] - 165;
								continue;
								IL_023a:
								num3 = byte_2[129] - 182;
								continue;
								IL_0229:
								num3 = byte_2[38] - 149;
								continue;
								IL_020d:
								num3 = 44;
								goto IL_0211;
								IL_0211:
								num2++;
								num4 = 14;
								num3 = byte_[107] - 104;
								continue;
								IL_01f7:
								num3 = byte_2[179] - byte_2[165];
								continue;
								IL_01ea:
								num3 = (int)byte_[42] / 6;
								continue;
								IL_01b8:
								num3 = 14;
								goto IL_01bc;
								IL_01bc:
								num3 = ((((byte[])(Array)collection)[num2] < 116) ? (byte_2[174] - 46) : byte_[35]);
								continue;
								IL_00fb:
								num14 = ((byte[])byte_3)[171] - 115;
								goto IL_0113;
								IL_00c7:
								num11 = ((byte[])byte_3)[23] - 183;
								goto IL_00d7;
								IL_011a:
								num3 = 38;
								goto IL_011e;
								IL_011e:
								num2++;
								num4 = (byte_4 as byte[])[362] - 148;
								num3 = 0;
								goto IL_013c;
								IL_00de:
								num3 = 27;
								goto IL_00e2;
								IL_00e2:
								if (208 != (((Array)collection) as byte[])[num2])
								{
									num3 = 11;
									goto IL_00fb;
								}
								num3 = 26;
								goto IL_0111;
								continue;
								end_IL_05d9:
								break;
							}
							continue;
							end_IL_06aa:
							break;
						}
					}
					goto IL_06f7;
					continue;
					end_IL_0045:
					break;
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
				Array byte_3 = Class2.byte_0;
				while (true)
				{
					object byte_4 = Class1.byte_0;
					int num = 71;
					while (true)
					{
						int num2 = 0;
						ICollection collection = (byte[])Class4.smethod_6(smethod_8(743, 671), Class4.Class5.Class6.smethod_7(1486502122, 13L, 2), 654, 'ʮ');
						num = 9;
						while (true)
						{
							int num3 = (byte_3 as byte[])[375] * 2;
							num = 0;
							while (true)
							{
								IL_08f5:
								switch (num3)
								{
								case 44:
									break;
								case 0:
									goto IL_0107;
								case 27:
									goto IL_01dc;
								case 36:
									goto IL_01fa;
								case 34:
									goto IL_032b;
								case 16:
									goto IL_05e3;
								case 43:
									goto IL_074c;
								case 42:
									goto IL_0755;
								case 41:
									goto IL_075e;
								case 40:
									goto IL_0767;
								case 39:
									goto IL_0770;
								case 38:
									goto IL_077d;
								case 37:
									goto IL_078e;
								case 35:
									goto IL_0797;
								case 33:
									goto IL_07a0;
								case 32:
									goto IL_07a9;
								case 31:
									goto IL_07ba;
								case 29:
									goto IL_07ce;
								case 28:
									goto IL_07d7;
								case 26:
									goto IL_07e2;
								case 25:
									goto IL_07ed;
								case 24:
									goto IL_07f6;
								case 23:
									goto IL_080a;
								case 22:
									goto IL_0813;
								case 21:
									goto IL_081c;
								case 20:
									goto IL_0824;
								case 18:
									goto IL_082f;
								case 17:
									goto IL_083d;
								case 15:
									goto IL_0846;
								case 14:
									goto IL_0854;
								case 13:
									goto IL_085d;
								case 12:
									goto IL_0866;
								case 11:
									goto IL_0877;
								case 9:
									goto IL_087f;
								case 8:
									goto IL_0888;
								case 7:
									goto IL_0893;
								case 6:
									goto IL_089e;
								case 5:
									goto IL_08a9;
								case 4:
									goto IL_08b2;
								case 3:
									goto IL_08c8;
								case 2:
									goto IL_08d3;
								case 1:
									goto IL_08dc;
								default:
									goto IL_08e4;
								case 10:
									goto IL_0a24;
								case 19:
									goto IL_0a2a;
								case 30:
									goto IL_0a30;
								}
								num = byte_2[146] - 131;
								goto IL_042c;
								IL_0a30:
								num = 66;
								goto IL_0a46;
								IL_0a2a:
								num = 69;
								goto IL_0a48;
								IL_0a24:
								num = 65;
								goto IL_0a44;
								IL_08e4:
								num = byte_2[155] - 55;
								goto IL_042c;
								IL_08dc:
								num = 4;
								goto IL_058d;
								IL_08d3:
								num = 61;
								goto IL_0182;
								IL_08c8:
								num = byte_[124];
								goto IL_042c;
								IL_08b2:
								num = byte_[269] + byte_[212];
								goto IL_042c;
								IL_08a9:
								num = 63;
								goto IL_0148;
								IL_089e:
								num = byte_[28];
								goto IL_042c;
								IL_0893:
								num = byte_[42];
								goto IL_042c;
								IL_0888:
								num = byte_[116];
								goto IL_042c;
								IL_087f:
								num = 17;
								goto IL_035c;
								IL_0877:
								num = 8;
								goto IL_03da;
								IL_0866:
								num = byte_[257] - 65;
								goto IL_042c;
								IL_085d:
								num = 26;
								goto IL_05be;
								IL_0854:
								num = 29;
								goto IL_05d8;
								IL_0846:
								num = byte_[184];
								goto IL_042c;
								IL_083d:
								num = 59;
								goto IL_01cf;
								IL_082f:
								num = byte_[158];
								goto IL_042c;
								IL_0824:
								num = byte_[42];
								goto IL_042c;
								IL_081c:
								num = 7;
								goto IL_0408;
								IL_0813:
								num = 19;
								goto IL_0331;
								IL_080a:
								num = 13;
								goto IL_0320;
								IL_07f6:
								num = byte_2[209] - 233;
								goto IL_042c;
								IL_07ed:
								num = 72;
								goto IL_00fd;
								IL_07e2:
								num = byte_[13];
								goto IL_042c;
								IL_07d7:
								num = byte_2[64];
								goto IL_042c;
								IL_07ce:
								num = 38;
								goto IL_01ef;
								IL_07ba:
								num = byte_2[189] - 147;
								goto IL_042c;
								IL_07a9:
								num = byte_2[27] - 223;
								goto IL_042c;
								IL_07a0:
								num = 12;
								goto IL_03a1;
								IL_0797:
								num = 25;
								goto IL_02ef;
								IL_078e:
								num = 41;
								goto IL_0292;
								IL_077d:
								num = byte_2[201] - 60;
								goto IL_042c;
								IL_0770:
								num = byte_[15] - 3;
								goto IL_042c;
								IL_0767:
								num = 64;
								goto IL_012e;
								IL_075e:
								num = 53;
								goto IL_06aa;
								IL_0755:
								num = 42;
								goto IL_026a;
								IL_074c:
								num = 55;
								goto IL_01ea;
								IL_01fa:
								num = 77;
								goto IL_0053;
								IL_042c:
								while (true)
								{
									byte num6;
									int num5;
									int num4;
									switch (num)
									{
									case 80:
										if (252 == ((collection as Array) as byte[])[num2])
										{
											num = byte_2[189] - 161;
											continue;
										}
										num = 28;
										goto case 28;
									case 77:
										break;
									case 37:
										goto IL_006c;
									case 76:
										goto IL_0090;
									case 75:
										if (((byte[])(Array)collection)[num2] >= 8)
										{
											num = 57;
											goto case 57;
										}
										num = byte_2[10] - 85;
										continue;
									case 57:
										num6 = (byte_3 as byte[])[94];
										goto IL_00c1;
									case 73:
										num5 = (byte_4 as byte[])[40] - 63;
										goto IL_00eb;
									case 72:
										goto IL_00fd;
									case 18:
										goto IL_010b;
									case 64:
										goto IL_012e;
									case 63:
										goto IL_0148;
									case 62:
										num6 = ((byte[])byte_4)[233];
										goto IL_00c1;
									case 30:
									case 61:
										goto IL_0182;
									case 49:
										goto IL_0198;
									case 56:
										goto IL_01a0;
									case 60:
										goto IL_01b5;
									case 59:
										goto IL_01cf;
									case 55:
										goto IL_01ea;
									case 38:
										goto IL_01ef;
									case 50:
										goto IL_0203;
									default:
										num = byte_[286];
										continue;
									case 47:
										goto IL_0233;
									case 43:
										goto IL_025a;
									case 42:
										goto IL_026a;
									case 41:
										goto IL_0292;
									case 36:
										goto IL_02bb;
									case 27:
										goto IL_02de;
									case 25:
										goto IL_02ef;
									case 21:
										goto IL_0300;
									case 20:
										Class4.Class5.Class6.smethod_0();
										goto IL_0320;
									case 13:
										goto IL_0320;
									case 19:
										goto IL_0331;
									case 17:
										goto IL_035c;
									case 15:
										Class4.Class5.smethod_1();
										num3 = 39;
										num = byte_[63] - 109;
										continue;
									case 14:
										goto IL_039a;
									case 12:
										goto IL_03a1;
									case 11:
										num2++;
										num3 = 1;
										num = byte_[193] - 35;
										continue;
									case 10:
										num5 = (byte_4 as byte[])[42] - 122;
										goto IL_00eb;
									case 8:
										goto IL_03da;
									case 7:
										goto IL_0408;
									case 2:
										goto IL_057c;
									case 4:
										goto IL_058d;
									case 24:
										num4 = 39;
										goto IL_0742;
									case 26:
										goto IL_05be;
									case 29:
										goto IL_05d8;
									case 31:
										goto IL_05ec;
									case 32:
										goto IL_05fb;
									case 33:
										goto IL_0613;
									case 34:
										goto IL_061b;
									case 40:
										BabelAttribute.smethod_2();
										num3 = ((byte[])byte_4)[160] - 168;
										num = 0;
										goto IL_08f5;
									case 1:
										goto IL_064f;
									case 16:
										goto IL_0665;
									case 44:
										goto IL_0673;
									case 51:
										goto IL_0692;
									case 52:
										goto IL_069e;
									case 53:
										goto IL_06aa;
									case 35:
										goto IL_06c3;
									case 6:
										goto IL_06ca;
									case 58:
									case 67:
										num2++;
										num3 = ((byte[])byte_3)[38] - 164;
										num = 0;
										goto IL_08f5;
									case 68:
										goto IL_06f4;
									case 78:
										goto IL_0704;
									case 79:
										goto IL_0710;
									case 70:
										goto IL_0729;
									case 23:
										goto IL_0731;
									case 28:
										num4 = 32;
										goto IL_0742;
									case 0:
										goto IL_08f5;
									case 9:
										goto end_IL_08f5;
									case 71:
										goto end_IL_09b5;
									case 5:
										goto end_IL_09ce;
									case 39:
										goto end_IL_0a0f;
									case 3:
										return null;
									case 22:
										num2++;
										return null;
									case 45:
										return null;
									case 46:
										return null;
									case 54:
										return null;
									case 65:
										goto IL_0a44;
									case 66:
										goto IL_0a46;
									case 69:
										goto IL_0a48;
									case 74:
										{
											Class9.Class10.smethod_5();
											return null;
										}
										IL_00eb:
										num3 = num5;
										num = byte_[42] - byte_[42];
										continue;
										IL_0742:
										num3 = num4;
										num = 0;
										goto IL_08f5;
										IL_00c1:
										num3 = num6;
										num = byte_2[83] - 36;
										continue;
									}
									break;
									IL_0233:
									num = ((8 == ((byte[])(collection as Array))[num2]) ? byte_2[57] : byte_2[85]);
								}
								goto IL_0053;
								IL_0a48:
								return null;
								IL_0a46:
								return null;
								IL_0a44:
								return null;
								IL_06aa:
								if (145 != ((byte[])(collection as Array))[num2])
								{
									num = 35;
									goto IL_06c3;
								}
								num = 6;
								goto IL_06ca;
								IL_01b5:
								int num7 = 27;
								goto IL_01b7;
								IL_06c3:
								int num8 = 40;
								goto IL_06cc;
								IL_01b7:
								num3 = num7;
								num = byte_[270] - byte_[270];
								goto IL_042c;
								IL_06ca:
								num8 = 13;
								goto IL_06cc;
								IL_06cc:
								num3 = num8;
								num = 0;
								continue;
								IL_069e:
								int num9 = 18;
								goto IL_06a0;
								IL_0692:
								int num10 = 22;
								goto IL_0694;
								IL_0673:
								int num11 = (byte_3 as byte[])[44] - ((byte[])byte_3)[83];
								goto IL_0688;
								IL_0613:
								int num12 = 43;
								goto IL_0657;
								IL_05d8:
								num2++;
								num3 = 16;
								num = 0;
								goto IL_05e3;
								IL_05e3:
								num = 79;
								goto IL_0710;
								IL_0710:
								if ((((Array)collection) as byte[])[num2] >= 145)
								{
									num = 70;
									goto IL_0729;
								}
								num = 23;
								goto IL_0731;
								IL_0182:
								if (116 != ((byte[])(collection as Array))[num2])
								{
									num = 49;
									goto IL_0198;
								}
								num = 56;
								goto IL_01a0;
								IL_0729:
								int num13 = 41;
								goto IL_0732;
								IL_006d:
								int num14;
								num3 = num14;
								num = byte_[52] - byte_[52];
								goto IL_042c;
								IL_0731:
								num13 = 7;
								goto IL_0732;
								IL_0732:
								num3 = num13;
								num = 0;
								continue;
								IL_05be:
								num2++;
								num3 = ((byte[])byte_4)[51] - 31;
								num = 0;
								continue;
								IL_058d:
								if ((((Array)collection) as byte[])[num2] >= 196)
								{
									num = 31;
									goto IL_05ec;
								}
								num = 68;
								goto IL_06f4;
								IL_0198:
								int num15 = 33;
								goto IL_01a2;
								IL_05ec:
								int num16 = (int)(byte_4 as byte[])[3] / 7;
								goto IL_06f6;
								IL_006c:
								num14 = 4;
								goto IL_006d;
								IL_06f4:
								num16 = 26;
								goto IL_06f6;
								IL_06f6:
								num3 = num16;
								num = 0;
								continue;
								IL_057c:
								int num17 = (int)(byte_3 as byte[])[16] / 6;
								goto IL_0706;
								IL_0408:
								if (((byte[])(collection as Array))[num2] >= 65)
								{
									num = 76;
									goto IL_0090;
								}
								num = 43;
								goto IL_025a;
								IL_01a0:
								num15 = 14;
								goto IL_01a2;
								IL_01a2:
								num3 = num15;
								num = byte_[34] - 240;
								goto IL_042c;
								IL_03da:
								if (196 != ((byte[])(Array)collection)[num2])
								{
									num = byte_2[160] - byte_2[201];
									goto IL_042c;
								}
								num = 14;
								goto IL_039a;
								IL_0148:
								smethod_0();
								num3 = ((byte[])byte_3)[368] - 127;
								num = byte_[272] - 48;
								goto IL_042c;
								IL_012e:
								Class4.smethod_0();
								num3 = 13;
								num = byte_[7] - 198;
								goto IL_042c;
								IL_03a1:
								smethod_0();
								num3 = 14;
								num = byte_2[7] - 5;
								goto IL_042c;
								IL_039a:
								int num18 = 25;
								goto IL_020f;
								IL_035c:
								if ((((Array)collection) as byte[])[num2] >= 239)
								{
									num = byte_[19] + 28;
									goto IL_042c;
								}
								num = 32;
								goto IL_05fb;
								IL_00fd:
								num2++;
								num3 = 0;
								num = 0;
								goto IL_0107;
								IL_0107:
								num = 18;
								goto IL_010b;
								IL_05fb:
								num11 = (byte_4 as byte[])[168] - ((byte[])byte_4)[37];
								goto IL_0688;
								IL_0688:
								num3 = num11;
								num = 0;
								continue;
								IL_0331:
								if (208 != ((byte[])(collection as Array))[num2])
								{
									num = 27;
									goto IL_02de;
								}
								num = byte_[192] * 5;
								goto IL_042c;
								IL_010b:
								if (((byte[])(Array)collection)[num2] >= 116)
								{
									num = byte_2[25] - 42;
									goto IL_042c;
								}
								num = 78;
								goto IL_0704;
								IL_01cf:
								smethod_1();
								num3 = 27;
								num = 0;
								goto IL_01dc;
								IL_0320:
								num2++;
								num3 = 34;
								num = 0;
								goto IL_032b;
								IL_032b:
								num = 36;
								goto IL_02bb;
								IL_0300:
								num14 = (byte_4 as byte[])[52] - (byte_4 as byte[])[233];
								goto IL_006d;
								IL_02ef:
								num3 = 3;
								num = byte_[82] - 105;
								goto IL_042c;
								IL_02de:
								num7 = (byte_4 as byte[])[123] - 90;
								goto IL_01b7;
								IL_02bb:
								if (((collection as Array) as byte[])[num2] >= 208)
								{
									num = byte_[102];
									goto IL_042c;
								}
								num = 34;
								goto IL_061b;
								IL_01dc:
								num = byte_2[174];
								goto IL_042c;
								IL_0704:
								num17 = 10;
								goto IL_0706;
								IL_061b:
								num10 = ((byte[])byte_3)[12] - 127;
								goto IL_0694;
								IL_0694:
								num3 = num10;
								num = 0;
								continue;
								IL_0292:
								if (239 != ((byte[])(Array)collection)[num2])
								{
									num = byte_[282] - 18;
									goto IL_042c;
								}
								num = 1;
								goto IL_064f;
								IL_0706:
								num3 = num17;
								num = 0;
								continue;
								IL_0090:
								int num19 = 42;
								goto IL_0092;
								IL_064f:
								num12 = (byte_4 as byte[])[4];
								goto IL_0657;
								IL_0657:
								num3 = num12;
								num = 0;
								continue;
								IL_026a:
								if (65 == ((collection as Array) as byte[])[num2])
								{
									num = byte_[193] + 17;
									goto IL_042c;
								}
								num = 16;
								goto IL_0665;
								IL_0092:
								num3 = num19;
								num = byte_2[123] - 89;
								goto IL_042c;
								IL_0665:
								num9 = ((byte[])byte_4)[96] - 30;
								goto IL_06a0;
								IL_06a0:
								num3 = num9;
								num = 0;
								continue;
								IL_0053:
								if ((((Array)collection) as byte[])[num2] >= 252)
								{
									num = 37;
									goto IL_006c;
								}
								num = byte_2[47] - 155;
								goto IL_042c;
								IL_025a:
								num19 = (int)(byte_4 as byte[])[24] / 8;
								goto IL_0092;
								IL_0203:
								num18 = (byte_4 as byte[])[119] - 111;
								goto IL_020f;
								IL_020f:
								num3 = num18;
								num = byte_[163] - 186;
								goto IL_042c;
								IL_01ea:
								BabelAttribute.smethod_3();
								goto IL_01ef;
								IL_01ef:
								num2++;
								num3 = 36;
								num = 0;
								goto IL_01fa;
								continue;
								end_IL_08f5:
								break;
							}
							continue;
							end_IL_09b5:
							break;
						}
						continue;
						end_IL_09ce:
						break;
					}
					continue;
					end_IL_0a0f:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static byte smethod_6()
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			int num4 = default(int);
			while (true)
			{
				object byte_3 = Class2.byte_0;
				int num = 5;
				while (true)
				{
					int num2 = 0;
					num = 10;
					while (true)
					{
						IEnumerable enumerable = (byte[])Class4.smethod_6(smethod_8(666, 739), Class4.Class5.Class6.smethod_7(1486502126, 7L, 6), 912, 'α');
						num = byte_2[260] - 27;
						while (true)
						{
							int num5;
							int num3;
							switch (num)
							{
							case 16:
								num5 = (byte_3 as byte[])[309] - 168;
								goto IL_0023;
							case 15:
								break;
							case 3:
							case 12:
								goto IL_0066;
							case 8:
								goto IL_00b5;
							case 4:
								goto IL_00b8;
							case 9:
								num4 = 4;
								num = byte_[19] - 43;
								continue;
							case 7:
								if (((byte[])(enumerable as Array))[num2] >= 8)
								{
									num = byte_2[269] - 23;
									continue;
								}
								num = 16;
								goto case 16;
							case 2:
								num5 = 2;
								goto IL_0023;
							case 1:
								num3 = 8;
								goto IL_0107;
							case 0:
								num3 = 3;
								goto IL_0107;
							case 10:
								goto end_IL_0116;
							case 5:
								goto end_IL_016a;
							default:
								num = 13;
								goto end_IL_01b3;
							case 13:
								goto end_IL_01b3;
							case 6:
							case 14:
								goto IL_01d3;
							case 17:
								goto IL_01df;
							case 18:
								goto IL_01e4;
								IL_0107:
								num4 = num3;
								num = byte_[62] - 33;
								continue;
								IL_0023:
								num4 = num5;
								num = 15;
								break;
							}
							switch (num4)
							{
							case 0:
								goto IL_005b;
							case 2:
								goto IL_0064;
							case 4:
								goto IL_0097;
							case 5:
								goto IL_00a4;
							case 6:
								goto IL_00b3;
							case 9:
								goto IL_00c5;
							case 1:
								goto IL_01c8;
							case 3:
								goto IL_01cc;
							case 7:
								goto IL_01d1;
							case 8:
								goto IL_01dc;
							}
							num = 8;
							goto IL_00b5;
							IL_005b:
							num = byte_[7];
							continue;
							IL_01dc:
							num = 17;
							goto IL_01df;
							IL_01df:
							Class4.Class5.Class6.smethod_1();
							goto IL_01e4;
							IL_01d1:
							num = 6;
							goto IL_01d3;
							IL_01cc:
							num = 18;
							goto IL_01e4;
							IL_01e4:
							num2++;
							return 12;
							IL_01c8:
							num = 6;
							goto IL_01d3;
							IL_01d3:
							Class9.Class12.smethod_2();
							return 30;
							IL_00c5:
							num = byte_2[122];
							continue;
							IL_00b3:
							num = 8;
							goto IL_00b5;
							IL_00a4:
							num = byte_[64] - byte_[174];
							continue;
							IL_0097:
							num = byte_[18] - 197;
							continue;
							IL_0064:
							num = 3;
							goto IL_0066;
							IL_0066:
							num = ((8 == ((enumerable as Array) as byte[])[num2]) ? (byte_[38] - byte_[38]) : (byte_[140] - 250));
							continue;
							IL_00b5:
							num4 = 0;
							goto IL_00b8;
							IL_00b8:
							num = byte_2[222] - 18;
							continue;
							end_IL_0116:
							break;
						}
						continue;
						end_IL_016a:
						break;
					}
					continue;
					end_IL_01b3:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static byte smethod_7()
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			int num4 = default(int);
			while (true)
			{
				object byte_3 = Class2.byte_0;
				Array byte_4 = Class1.byte_0;
				int num = 24;
				while (true)
				{
					int num2 = 0;
					object obj = (byte[])Class4.smethod_6(smethod_8(378, 256), Class4.Class5.Class6.smethod_7(1486502122, 12L, 2), 965, 'ϧ');
					num = byte_2[35];
					while (true)
					{
						int num5;
						int num6;
						int num7;
						int num3;
						switch (num)
						{
						case 18:
							num5 = (byte_3 as byte[])[218] - ((byte[])byte_3)[19];
							goto IL_0029;
						case 15:
							if (8 != ((byte[])obj)[num2])
							{
								num = 14;
								goto case 14;
							}
							num = 20;
							goto case 20;
						case 20:
							num6 = 7;
							goto IL_004b;
						case 22:
							num4 = ((byte[])byte_3)[16];
							num = 10;
							goto case 10;
						case 10:
							switch (num4)
							{
							case 6:
								break;
							case 1:
								goto IL_0052;
							case 14:
								goto IL_00a9;
							default:
								goto IL_00de;
							case 0:
								goto IL_00e9;
							case 2:
								goto IL_00f4;
							case 3:
								goto IL_0105;
							case 5:
								goto IL_0112;
							case 7:
								goto IL_0120;
							case 8:
								goto IL_0130;
							case 9:
								goto IL_016b;
							case 10:
								goto IL_0170;
							case 11:
								goto IL_017b;
							case 12:
								goto IL_0188;
							case 13:
								goto IL_01ac;
							case 4:
								goto IL_02e4;
							}
							num = 15;
							goto case 15;
						case 4:
							if (208 != ((byte[])obj)[num2])
							{
								num = 18;
								goto case 18;
							}
							num = 17;
							goto case 17;
						case 14:
						case 21:
							num6 = (byte_3 as byte[])[124];
							goto IL_004b;
						case 17:
						case 23:
							num5 = 2;
							goto IL_0029;
						case 7:
							break;
						case 6:
							goto IL_0123;
						case 16:
							if ((obj as byte[])[num2] >= 8)
							{
								num = 9;
								goto case 9;
							}
							num = 1;
							goto case 1;
						case 9:
							num7 = 6;
							goto IL_01a3;
						case 1:
							num7 = 5;
							goto IL_01a3;
						case 3:
							goto IL_01af;
						case 12:
							BabelAttribute.smethod_1();
							num4 = 7;
							num = byte_2[122];
							continue;
						case 5:
							num3 = (byte_4 as byte[])[99] - 237;
							goto IL_01fc;
						case 0:
							num3 = 4;
							goto IL_01fc;
						case 24:
							goto end_IL_0209;
						default:
							num = 2;
							goto end_IL_027e;
						case 2:
							goto end_IL_027e;
						case 11:
							Class9.Class10.smethod_5();
							return 20;
						case 13:
							return 14;
						case 25:
						case 26:
							Class4.Class5.Class6.smethod_3();
							goto case 19;
						case 19:
							{
								num2++;
								return 9;
							}
							IL_01fc:
							num4 = num3;
							num = 10;
							goto case 10;
							IL_0029:
							num4 = num5;
							num = 10;
							goto case 10;
							IL_02e4:
							num = 13;
							goto case 13;
							IL_01ac:
							num = 3;
							goto IL_01af;
							IL_0188:
							num = 16;
							goto case 16;
							IL_01a3:
							num4 = num7;
							num = byte_2[122];
							continue;
							IL_017b:
							num = byte_[106] - 7;
							continue;
							IL_016b:
							num = 3;
							goto IL_01af;
							IL_0120:
							num = 6;
							goto IL_0123;
							IL_0112:
							num = byte_2[158];
							continue;
							IL_0105:
							num = (int)byte_2[36] / 8;
							continue;
							IL_00f4:
							num = byte_[30] - 185;
							continue;
							IL_00e9:
							num = byte_[117];
							continue;
							IL_00de:
							num = 7;
							break;
							IL_00a9:
							num = 4;
							goto case 4;
							IL_004b:
							num4 = num6;
							num = 10;
							goto case 10;
							IL_0052:
							num = 22;
							goto case 22;
						}
						num4 = 8;
						num = 10;
						goto IL_0130;
						IL_01af:
						num = ((((byte[])obj)[num2] < 208) ? (byte_[100] - byte_[100]) : (byte_2[183] - byte_2[13]));
						continue;
						IL_0170:
						num = byte_2[13];
						continue;
						IL_0130:
						byte num8 = byte_2[228];
						byte num9 = byte_2[116];
						Class2.byte_1[150] = (byte)((Class2.byte_1[150] * Class2.byte_1[153]) & 0xB0);
						num = num8 - num9;
						continue;
						IL_0123:
						num2++;
						num4 = 10;
						num = 10;
						goto IL_0170;
						continue;
						end_IL_0209:
						break;
					}
					continue;
					end_IL_027e:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static AppDomain smethod_8(int int_0, int int_1)
		{
			//IL_0e0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e10: Expected O, but got Unknown
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			object obj = default(object);
			while (true)
			{
				Array byte_3 = Class2.byte_0;
				object byte_4 = Class1.byte_0;
				int num = 4;
				while (true)
				{
					int num2 = 0;
					int num3 = (byte_3 as byte[])[390];
					num = 9;
					while (true)
					{
						IL_0d02:
						int num5;
						byte num6;
						switch (num3)
						{
						case 50:
							break;
						case 49:
							num = 67;
							goto IL_003c;
						case 40:
							num = 42;
							goto IL_010c;
						case 21:
							num = (int)byte_[9] / 6;
							goto IL_0612;
						case 48:
							num = 29;
							goto IL_0503;
						case 47:
							num = 18;
							goto IL_0565;
						case 46:
							num = 77;
							goto IL_0320;
						case 45:
							num = 27;
							goto IL_0515;
						case 44:
							num = byte_2[132] - byte_2[246];
							goto IL_0612;
						case 43:
							num = byte_[67] - byte_[123];
							goto IL_0612;
						case 42:
							num = 49;
							goto IL_042c;
						case 39:
							num = 47;
							goto IL_0447;
						case 38:
							num = 14;
							goto IL_058c;
						case 37:
							num = 46;
							goto IL_085c;
						case 36:
							num = byte_2[175] - 74;
							goto IL_0612;
						case 35:
							num = 36;
							goto IL_04cb;
						case 34:
							num = 93;
							goto IL_007b;
						case 33:
							num = 90;
							goto IL_00d8;
						case 32:
							num = 86;
							goto IL_0164;
						case 31:
							num = byte_[64];
							goto IL_0612;
						case 30:
							num = 35;
							goto IL_0838;
						case 29:
							num = 38;
							goto IL_0050;
						case 28:
							num = byte_[63] + 28;
							goto IL_0612;
						case 27:
							num = 12;
							goto IL_05a8;
						case 26:
							num = 82;
							goto IL_02c6;
						case 25:
							num = 54;
							goto IL_03bc;
						case 24:
							num = byte_2[332] - 66;
							goto IL_0612;
						case 23:
							num = 1;
							goto IL_05f6;
						case 22:
							num = byte_2[200] + 35;
							goto IL_0612;
						case 20:
							num = byte_2[119];
							goto IL_0612;
						case 19:
							num = 6;
							goto IL_05e1;
						case 18:
							num = byte_[172] + 34;
							goto IL_0612;
						case 17:
							num = byte_2[96];
							goto IL_0612;
						case 16:
							num = 41;
							goto IL_047d;
						case 15:
							num = byte_2[119] + 4;
							goto IL_0612;
						case 14:
							num = 60;
							goto IL_03a8;
						case 13:
							num = 44;
							goto IL_0463;
						case 12:
							num = byte_[155] - 29;
							goto IL_0612;
						case 11:
							num = byte_[102];
							goto IL_0612;
						case 10:
							num = 21;
							goto IL_052f;
						case 9:
							num = 78;
							goto IL_092e;
						case 8:
							num = 64;
							goto IL_038c;
						case 7:
							num = byte_[164] - 23;
							goto IL_0612;
						case 6:
							num = 91;
							goto IL_00b8;
						case 5:
							num = 17;
							goto IL_0577;
						case 4:
							num = byte_[207] + byte_[57];
							goto IL_0612;
						case 3:
							num = 10;
							goto IL_05c4;
						case 2:
							num = byte_2[290] - 134;
							goto IL_0612;
						case 1:
							num = 32;
							goto IL_04e7;
						case 0:
							num = 39;
							goto IL_04a4;
						default:
							num = 60;
							goto IL_03a8;
						case 41:
							{
								num = 4;
								goto end_IL_0d02;
							}
							IL_003c:
							obj = Class8.smethod_8(660, 702);
							num = 38;
							goto IL_0050;
							IL_0050:
							num3 = ((byte[])byte_4)[51];
							num = byte_2[217] - byte_2[63];
							goto IL_0612;
							IL_0612:
							while (true)
							{
								int num4;
								switch (num)
								{
								case 97:
									break;
								case 67:
									goto IL_003c;
								case 38:
									goto IL_0050;
								default:
									num = (int)byte_[42] / 5;
									continue;
								case 93:
									goto IL_007b;
								case 91:
									goto IL_00b8;
								case 90:
									goto IL_00d8;
								case 89:
									goto IL_00fb;
								case 42:
									goto IL_010c;
								case 88:
									goto IL_011f;
								case 87:
									obj = Class8.smethod_8(247, 221);
									num3 = ((byte[])byte_4)[51];
									num = byte_[196] - 72;
									continue;
								case 86:
									goto IL_0164;
								case 82:
									goto IL_02c6;
								case 79:
									obj = AppDomain.CurrentDomain;
									num3 = 40;
									num = byte_[98] - 205;
									continue;
								case 77:
									goto IL_0320;
								case 74:
									obj = Class8.smethod_8(605, 631);
									num3 = 40;
									num = byte_2[13] * 3;
									continue;
								case 69:
									obj = Class8.smethod_8(437, 415);
									num3 = 40;
									num = byte_2[239] - byte_2[122];
									continue;
								case 68:
									goto IL_037c;
								case 64:
									goto IL_038c;
								case 60:
									goto IL_03a8;
								case 54:
									goto IL_03bc;
								case 52:
									obj = Class8.smethod_8(837, 879);
									num3 = ((byte[])byte_4)[51];
									num = byte_[207] - 5;
									continue;
								case 51:
									obj = Class8.smethod_8(28, 54);
									num3 = (byte_3 as byte[])[16] + 28;
									num = byte_[201] - 126;
									continue;
								case 49:
									goto IL_042c;
								case 47:
									goto IL_0447;
								case 44:
									goto IL_0463;
								case 41:
									goto IL_047d;
								case 39:
									goto IL_04a4;
								case 36:
									goto IL_04cb;
								case 32:
									goto IL_04e7;
								case 29:
									goto IL_0503;
								case 27:
									goto IL_0515;
								case 21:
									goto IL_052f;
								case 19:
									goto IL_0553;
								case 18:
									goto IL_0565;
								case 17:
									goto IL_0577;
								case 14:
									goto IL_058c;
								case 12:
									goto IL_05a8;
								case 10:
									goto IL_05c4;
								case 6:
									goto IL_05e1;
								case 1:
									goto IL_05f6;
								case 5:
									obj = AppDomain.CurrentDomain;
									num3 = (byte_4 as byte[])[51];
									num = 9;
									goto IL_0d02;
								case 15:
									num4 = 11;
									goto IL_089a;
								case 16:
									goto IL_07cb;
								case 20:
									goto IL_07d2;
								case 22:
									goto IL_07d9;
								case 30:
									obj = Class8.smethod_8(744, 706);
									num3 = ((byte[])byte_3)[30] - 63;
									num = 9;
									goto IL_0d02;
								case 31:
									goto IL_0812;
								case 34:
									obj = Class8.smethod_8(37, 15);
									num3 = (int)((byte[])byte_3)[123] / 4;
									num = 9;
									goto IL_0d02;
								case 35:
									goto IL_0838;
								case 46:
									goto IL_085c;
								case 50:
									goto IL_0886;
								case 55:
									num4 = 42;
									goto IL_089a;
								case 58:
									goto IL_08a4;
								case 61:
									goto IL_08ab;
								case 62:
									goto IL_08b2;
								case 65:
									obj = Class8.smethod_8(249, 211);
									num3 = (byte_3 as byte[])[16] + 28;
									num = 9;
									goto IL_0d02;
								case 66:
									goto IL_08f9;
								case 71:
									obj = null;
									num3 = (byte_3 as byte[])[394] - 37;
									goto case 43;
								case 43:
									num = 9;
									goto IL_0d02;
								case 73:
									goto IL_091c;
								case 78:
									goto IL_092e;
								case 7:
									goto IL_0951;
								case 75:
									goto IL_095b;
								case 83:
									goto IL_097a;
								case 26:
									goto IL_0985;
								case 53:
									goto IL_0990;
								case 72:
									goto IL_099b;
								case 33:
									goto IL_09a6;
								case 59:
									goto IL_09bf;
								case 11:
									goto IL_09ca;
								case 76:
									goto IL_09d5;
								case 80:
									goto IL_09ea;
								case 81:
									goto IL_09f5;
								case 28:
									goto IL_0a00;
								case 3:
									goto IL_0a13;
								case 13:
									goto IL_0a1d;
								case 8:
									goto IL_0a32;
								case 25:
								case 85:
									goto IL_0a3c;
								case 84:
									goto IL_0a46;
								case 56:
									goto IL_0a5c;
								case 0:
									goto IL_0a70;
								case 24:
									goto IL_0a86;
								case 40:
									goto IL_0a8e;
								case 2:
									goto IL_0aa3;
								case 70:
									goto IL_0aaa;
								case 37:
									goto IL_0ab2;
								case 45:
									goto IL_0aba;
								case 23:
									goto IL_0ac2;
								case 63:
									goto IL_0aca;
								case 92:
									goto IL_0ace;
								case 94:
									goto IL_0ad2;
								case 95:
									goto IL_0ad5;
								case 96:
									goto IL_0ad9;
								case 9:
									goto IL_0d02;
								case 4:
									goto end_IL_0d02;
								case 48:
									goto end_IL_0ddc;
								case 57:
									{
										AppDomain result = ((_AppDomain)obj) as AppDomain;
										Class9.Class10.smethod_6();
										return result;
									}
									IL_089a:
									num3 = num4;
									num = 9;
									goto IL_0d02;
								}
								break;
							}
							goto IL_0015;
							IL_0ad9:
							num5 = ((byte[])byte_4)[224] - 61;
							goto IL_0ae9;
							IL_0ace:
							num5 = 23;
							goto IL_0ae9;
							IL_092e:
							obj = Class8.smethod_8(3, 41);
							num3 = ((byte[])byte_3)[22] + 33;
							num = 9;
							continue;
							IL_091c:
							num5 = ((byte[])byte_3)[435];
							goto IL_0ae9;
							IL_08f9:
							num5 = 19;
							goto IL_0ae9;
							IL_08b2:
							num5 = ((byte[])byte_3)[238] + (byte_3 as byte[])[135];
							goto IL_0ae9;
							IL_08ab:
							num5 = 43;
							goto IL_0ae9;
							IL_08a4:
							num5 = 13;
							goto IL_0ae9;
							IL_0886:
							num5 = ((byte[])byte_4)[31] - 23;
							goto IL_0ae9;
							IL_085c:
							obj = Class8.smethod_8(776, 802);
							num3 = ((byte[])byte_3)[378] - 48;
							num = 9;
							continue;
							IL_0838:
							obj = Class8.smethod_8(108, 70);
							num3 = ((byte[])byte_3)[347] - 74;
							num = 9;
							continue;
							IL_0812:
							num5 = 1;
							goto IL_0ae9;
							IL_07d9:
							num5 = ((byte[])byte_3)[290];
							goto IL_0ae9;
							IL_07d2:
							num5 = 22;
							goto IL_0ae9;
							IL_07cb:
							num5 = 31;
							goto IL_0ae9;
							IL_05f6:
							obj = Class8.smethod_8(202, 224);
							num3 = 40;
							num = 9;
							goto case 40;
							IL_05e1:
							obj = Class8.smethod_8(41, 3);
							num3 = 40;
							num = 9;
							goto case 40;
							IL_05c4:
							obj = Class8.smethod_8(455, 493);
							num3 = 40;
							num = byte_2[13] + 6;
							goto IL_0612;
							IL_05a8:
							obj = Class8.smethod_8(735, 757);
							num3 = 40;
							num = 9;
							goto case 40;
							IL_058c:
							obj = Class8.smethod_8(530, 568);
							num3 = 40;
							num = 9;
							goto case 40;
							IL_0577:
							obj = Class8.smethod_8(831, 789);
							goto IL_037c;
							IL_0565:
							obj = AppDomain.CurrentDomain;
							num3 = 40;
							num = 9;
							goto case 40;
							IL_0553:
							obj = AppDomain.CurrentDomain;
							num3 = 40;
							num = 9;
							goto case 40;
							IL_052f:
							obj = Class8.smethod_8(371, 345);
							num3 = 40;
							num = byte_[125] - 136;
							goto IL_0612;
							IL_0515:
							obj = AppDomain.CurrentDomain;
							num3 = 40;
							num = byte_2[259] - 119;
							goto IL_0612;
							IL_0503:
							obj = AppDomain.CurrentDomain;
							num3 = 40;
							num = 9;
							goto case 40;
							IL_04e7:
							obj = Class8.smethod_8(880, 858);
							num3 = 40;
							num = 9;
							goto case 40;
							IL_04cb:
							obj = Class8.smethod_8(900, 942);
							num3 = 40;
							num = 9;
							goto case 40;
							IL_04a4:
							obj = Class8.smethod_8(139, 161);
							num3 = 40;
							num = byte_[146] - 167;
							goto IL_0612;
							IL_047d:
							obj = Class8.smethod_8(388, 430);
							num3 = 40;
							num = byte_2[270] - 134;
							goto IL_0612;
							IL_0463:
							obj = AppDomain.CurrentDomain;
							num3 = 40;
							num = byte_[100] - 146;
							goto IL_0612;
							IL_0447:
							obj = Class8.smethod_8(678, 652);
							num3 = 40;
							num = 9;
							goto case 40;
							IL_042c:
							num3 = ((byte[])byte_3)[390];
							num = (int)byte_[45] / 7;
							goto IL_0612;
							IL_03bc:
							obj = Class8.smethod_8(182, 156);
							num3 = 40;
							num = 9;
							goto case 40;
							IL_03a8:
							num3 = 21;
							num = 9;
							goto case 21;
							IL_038c:
							obj = Class8.smethod_8(494, 452);
							num3 = 40;
							num = 9;
							goto case 40;
							IL_037c:
							num3 = 40;
							num = byte_2[13] * 3;
							goto IL_0612;
							IL_0320:
							obj = Class8.smethod_8(21, 63);
							num3 = 40;
							num = 9;
							goto case 40;
							IL_02c6:
							obj = AppDomain.CurrentDomain;
							num6 = ((byte[])byte_3)[132];
							Class2.byte_1[59] = (byte)((Class2.byte_1[59] ^ int_0) & 0xF8);
							num3 = num6 - 12;
							num = byte_[86] - 175;
							goto IL_0612;
							IL_0164:
							switch (((int_1 ^ int_0) - 95) ^ num2)
							{
							case 7:
								break;
							case 9:
								goto IL_0226;
							case 12:
								goto IL_0233;
							case 13:
								goto IL_0244;
							case 15:
								goto IL_0254;
							case 19:
								goto IL_0265;
							case 20:
								goto IL_0276;
							case 22:
								goto IL_0287;
							case 28:
								goto IL_0292;
							case 29:
								goto IL_02a0;
							case 35:
								goto IL_02ad;
							case 38:
								goto IL_02b8;
							default:
								goto IL_094e;
							case 0:
								goto IL_0957;
							case 1:
								goto IL_096d;
							case 2:
								goto IL_0976;
							case 3:
								goto IL_0981;
							case 4:
								goto IL_098c;
							case 5:
								goto IL_0997;
							case 6:
								goto IL_09a2;
							case 8:
								goto IL_09bb;
							case 10:
								goto IL_09c6;
							case 11:
								goto IL_09d1;
							case 14:
								goto IL_09e6;
							case 16:
								goto IL_09f1;
							case 17:
								goto IL_09fc;
							case 18:
								goto IL_0a07;
							case 21:
								goto IL_0a10;
							case 23:
								goto IL_0a19;
							case 24:
								goto IL_0a2f;
							case 25:
								goto IL_0a38;
							case 26:
								goto IL_0a42;
							case 27:
								goto IL_0a58;
							case 30:
								goto IL_0a6d;
							case 31:
								goto IL_0a82;
							case 32:
								goto IL_0a8a;
							case 33:
								goto IL_0aa0;
							case 34:
								goto IL_0aa6;
							case 36:
								goto IL_0aae;
							case 37:
								goto IL_0ab6;
							case 39:
								goto IL_0abe;
							case 40:
								goto IL_0ac6;
							}
							num = byte_2[75];
							goto IL_0612;
							IL_0ac6:
							num = 63;
							goto IL_0aca;
							IL_0aca:
							num5 = 24;
							goto IL_0ae9;
							IL_0abe:
							num = 23;
							goto IL_0ac2;
							IL_0ac2:
							num5 = 45;
							goto IL_0ae9;
							IL_0ab6:
							num = 45;
							goto IL_0aba;
							IL_0aba:
							num5 = 17;
							goto IL_0ae9;
							IL_0aae:
							num = 37;
							goto IL_0ab2;
							IL_0ab2:
							num5 = 50;
							goto IL_0ae9;
							IL_0aa6:
							num = 70;
							goto IL_0aaa;
							IL_0aaa:
							num5 = 47;
							goto IL_0ae9;
							IL_0aa0:
							num = 2;
							goto IL_0aa3;
							IL_0aa3:
							num5 = 7;
							goto IL_0ae9;
							IL_0a8a:
							num = 40;
							goto IL_0a8e;
							IL_0a8e:
							num5 = (byte_4 as byte[])[162] - 30;
							goto IL_0ae9;
							IL_0a82:
							num = 24;
							goto IL_0a86;
							IL_0a86:
							num5 = 44;
							goto IL_0ae9;
							IL_0a6d:
							num = 0;
							goto IL_0a70;
							IL_0a70:
							num5 = (byte_4 as byte[])[151] - 104;
							goto IL_0ae9;
							IL_0a58:
							num = 56;
							goto IL_0a5c;
							IL_0a5c:
							num5 = (byte_4 as byte[])[141] - 7;
							goto IL_0ae9;
							IL_0a42:
							num = 84;
							goto IL_0a46;
							IL_0a46:
							num5 = (byte_3 as byte[])[420];
							goto IL_0ae9;
							IL_0a38:
							num = 85;
							goto IL_0a3c;
							IL_0a3c:
							num5 = 5;
							goto IL_0ae9;
							IL_0a2f:
							num = 8;
							goto IL_0a32;
							IL_0a32:
							num5 = 0;
							goto IL_0ae9;
							IL_0a19:
							num = 13;
							goto IL_0a1d;
							IL_0a1d:
							num5 = (byte_4 as byte[])[25] - 75;
							goto IL_0ae9;
							IL_0a10:
							num = 3;
							goto IL_0a13;
							IL_0a13:
							num5 = 6;
							goto IL_0ae9;
							IL_0a07:
							num = 95;
							goto IL_0ad5;
							IL_0ad5:
							num5 = 12;
							goto IL_0ae9;
							IL_09fc:
							num = 28;
							goto IL_0a00;
							IL_0a00:
							num5 = 46;
							goto IL_0ae9;
							IL_09f1:
							num = 81;
							goto IL_09f5;
							IL_09f5:
							num5 = 20;
							goto IL_0ae9;
							IL_09e6:
							num = 80;
							goto IL_09ea;
							IL_09ea:
							num5 = 33;
							goto IL_0ae9;
							IL_09d1:
							num = 76;
							goto IL_09d5;
							IL_09d5:
							num5 = (byte_4 as byte[])[88] - 4;
							goto IL_0ae9;
							IL_09c6:
							num = 11;
							goto IL_09ca;
							IL_09ca:
							num5 = 25;
							goto IL_0ae9;
							IL_09bb:
							num = 59;
							goto IL_09bf;
							IL_09bf:
							num5 = 39;
							goto IL_0ae9;
							IL_09a2:
							num = 33;
							goto IL_09a6;
							IL_09a6:
							num5 = (byte_3 as byte[])[350] - 20;
							goto IL_0ae9;
							IL_0997:
							num = 72;
							goto IL_099b;
							IL_099b:
							num5 = 10;
							goto IL_0ae9;
							IL_098c:
							num = 53;
							goto IL_0990;
							IL_0990:
							num5 = 28;
							goto IL_0ae9;
							IL_0981:
							num = 26;
							goto IL_0985;
							IL_0985:
							num5 = 16;
							goto IL_0ae9;
							IL_0976:
							num = 83;
							goto IL_097a;
							IL_097a:
							num5 = 49;
							goto IL_0ae9;
							IL_096d:
							num = 94;
							goto IL_0ad2;
							IL_0ad2:
							num5 = 8;
							goto IL_0ae9;
							IL_0957:
							num = 75;
							goto IL_095b;
							IL_095b:
							num5 = (byte_3 as byte[])[207];
							goto IL_0ae9;
							IL_094e:
							num = 7;
							goto IL_0951;
							IL_0951:
							num5 = 2;
							goto IL_0ae9;
							IL_0ae9:
							num3 = num5;
							num = 9;
							continue;
							IL_02b8:
							num = byte_2[159];
							goto IL_0612;
							IL_02ad:
							num = byte_[19];
							goto IL_0612;
							IL_02a0:
							num = byte_[63] - 8;
							goto IL_0612;
							IL_0292:
							num = byte_[100] - 89;
							goto IL_0612;
							IL_0287:
							num = byte_[57];
							goto IL_0612;
							IL_0276:
							num = byte_2[286] + 53;
							goto IL_0612;
							IL_0265:
							num = byte_[27] - 176;
							goto IL_0612;
							IL_0254:
							num = byte_2[321] - 60;
							goto IL_0612;
							IL_0244:
							num = byte_[85] + byte_[117];
							goto IL_0612;
							IL_0233:
							num = byte_2[233] - 119;
							goto IL_0612;
							IL_0226:
							num = (int)byte_[100] / 5;
							goto IL_0612;
							IL_007b:
							obj = Class8.smethod_8(785, 827);
							num3 = ((byte[])byte_3)[340] + (byte_3 as byte[])[143];
							num = byte_2[178] - 60;
							goto IL_0612;
							IL_011f:
							obj = Class8.smethod_8(772, 814);
							num3 = 40;
							num = 9;
							goto case 40;
							IL_00fb:
							obj = AppDomain.CurrentDomain;
							num3 = 40;
							num = 9;
							goto case 40;
							IL_010c:
							num2++;
							num = byte_2[4] - 80;
							goto IL_0612;
							IL_00d8:
							obj = Class8.smethod_8(186, 144);
							num3 = 40;
							num = byte_[3] - 211;
							goto IL_0612;
							IL_00b8:
							obj = Class8.smethod_8(722, 760);
							num3 = 40;
							num = byte_2[122] - 1;
							goto IL_0612;
						}
						num = 97;
						goto IL_0015;
						IL_0015:
						obj = AppDomain.CurrentDomain;
						num3 = ((byte[])byte_3)[225] - 146;
						num = 9;
						continue;
						end_IL_0d02:
						break;
					}
					continue;
					end_IL_0ddc:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void smethod_9(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			int num = 2;
			while (true)
			{
				int num2 = 3;
				num = 1;
				while (true)
				{
					IL_0100:
					num = 5;
					while (true)
					{
						int num3 = 0;
						num2 = 2;
						while (true)
						{
							num = byte_2[167] - 39;
							while (true)
							{
								int num4;
								switch (num)
								{
								case 10:
									break;
								case 9:
									goto IL_0020;
								case 3:
									goto IL_0033;
								case 4:
									goto IL_003b;
								case 8:
									num = byte_2[111] - 59;
									continue;
								case 6:
									num4 = 2;
									goto IL_0053;
								case 1:
									goto IL_0056;
								case 0:
									num4 = 0;
									goto IL_0053;
								case 7:
									goto end_IL_00b2;
								case 5:
									goto end_IL_00ea;
								default:
									goto end_IL_00f9;
								case 11:
									{
										Class9.Class10.smethod_5();
										return;
									}
									IL_0053:
									num2 = num4;
									goto case 8;
								}
								goto IL_0013;
								IL_0056:
								switch (num2)
								{
								case 0:
									break;
								case 1:
									goto IL_0084;
								case 2:
									goto IL_0089;
								case 4:
									goto IL_0099;
								case 5:
									goto IL_009d;
								case 6:
									goto IL_00a7;
								default:
									goto IL_00f7;
								case 3:
									goto IL_0100;
								}
								num = byte_[158];
								continue;
								IL_00f7:
								num = 5;
								goto end_IL_00ea;
								IL_00a7:
								num = 9;
								goto IL_0020;
								IL_009d:
								num = byte_[96] - 74;
								continue;
								IL_0099:
								num = 3;
								goto IL_0033;
								IL_0089:
								num = byte_[163] - 177;
								continue;
								IL_0084:
								num = 10;
								goto IL_0013;
								IL_0013:
								num = byte_[39] - 98;
								continue;
								IL_0020:
								Class8.smethod_9(stream_0, byte_0, int_0, int_1, '\u0385', 'σ');
								goto IL_0033;
								IL_0033:
								num3++;
								num2 = 1;
								goto IL_003b;
								IL_003b:
								num = byte_[226] - 9;
								continue;
								end_IL_00b2:
								break;
							}
							continue;
							end_IL_00ea:
							break;
						}
						continue;
						end_IL_00f9:
						break;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static int smethod_10(Stream stream_0, byte[] byte_0, int int_0, int int_1, short short_0, char char_0)
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			int num7 = default(int);
			int num4 = default(int);
			while (true)
			{
				Array byte_3 = Class1.byte_0;
				int num = 2;
				while (true)
				{
					int num2 = 0;
					int num3 = 7;
					num = 1;
					while (true)
					{
						IL_0228:
						num = byte_[338] - 96;
						while (true)
						{
							int num5;
							int num6;
							switch (num)
							{
							case 21:
								if (num7 % 2 == 0)
								{
									num = 10;
									goto case 10;
								}
								num = byte_2[106];
								continue;
							case 10:
								num5 = (byte_3 as byte[])[154] - 108;
								goto IL_002c;
							case 19:
								num3 = ((byte[])byte_3)[68] - 114;
								goto case 3;
							case 3:
								num = 1;
								goto case 1;
							case 9:
								num4 = 4;
								num3 = ((byte[])byte_3)[11] - ((byte[])byte_3)[11];
								num = 1;
								goto case 1;
							case 1:
							case 12:
								switch (num3)
								{
								case 4:
									break;
								case 3:
									goto IL_0047;
								case 8:
									goto IL_0066;
								default:
									goto IL_00a2;
								case 0:
									goto IL_00af;
								case 1:
									goto IL_00d9;
								case 2:
									goto IL_00e6;
								case 6:
									goto IL_00eb;
								case 9:
									goto IL_00fb;
								case 10:
									goto IL_0123;
								case 11:
									goto IL_0130;
								case 7:
									goto IL_0228;
								case 5:
									goto IL_0235;
								}
								num = 19;
								goto case 19;
							case 0:
								num2++;
								num7 = char_0 * char_0;
								num = 5;
								goto case 5;
							case 5:
								num7 = char_0 + num7;
								num3 = 8;
								goto case 16;
							case 16:
								num = byte_[178] - 68;
								continue;
							case 13:
								num4 = Class9.smethod_14(stream_0, byte_0, int_0, int_1, 806, 805);
								num = byte_2[71] - 129;
								continue;
							case 7:
								num3 = 5;
								num = byte_[123] - 181;
								continue;
							case 20:
								Class1.byte_1[185] = (byte)((Class1.byte_1[185] | Class1.byte_1[74]) & 0x54);
								switch (((char_0 ^ short_0) - 67) ^ num2)
								{
								case 0:
									goto IL_018b;
								case 1:
									goto IL_0190;
								}
								num = 4;
								goto case 4;
							case 4:
								num6 = 3;
								goto IL_0194;
							case 6:
								num6 = 2;
								goto IL_0194;
							case 8:
								num6 = 10;
								goto IL_0194;
							case 18:
								num4 = Class9.smethod_14(stream_0, byte_0, int_0, int_1, 829, 830);
								num3 = 0;
								num = byte_[200] - 33;
								continue;
							case 14:
								num5 = 7;
								goto IL_002c;
							case 2:
								break;
							default:
								num = 11;
								goto end_IL_0237;
							case 11:
								goto end_IL_0237;
							case 15:
								{
									int result = num4;
									Class9.Class10.smethod_7();
									return result;
								}
								IL_0190:
								num = 8;
								goto case 8;
								IL_018b:
								num = 6;
								goto case 6;
								IL_0194:
								num3 = num6;
								num = 1;
								goto case 1;
								IL_002c:
								num3 = num5;
								num = 1;
								goto case 1;
								IL_0235:
								num = 2;
								break;
								IL_0130:
								num = 7;
								goto case 7;
								IL_0123:
								num = byte_2[64] - 56;
								continue;
								IL_00fb:
								num = 13;
								goto case 13;
								IL_00eb:
								num = byte_2[38] - 154;
								continue;
								IL_00e6:
								num = 13;
								goto case 13;
								IL_00d9:
								num = byte_2[22] - 49;
								continue;
								IL_00af:
								num = 0;
								goto case 0;
								IL_00a2:
								num = byte_[7] - byte_[2];
								continue;
								IL_0066:
								num = 21;
								goto case 21;
								IL_0047:
								num = 9;
								goto case 9;
							}
							break;
						}
						break;
					}
					continue;
					end_IL_0237:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static DateTime smethod_11(int int_0, char char_0)
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			DateTime dateTime = default(DateTime);
			int num5 = default(int);
			while (true)
			{
				object byte_3 = Class1.byte_0;
				int num = 5;
				while (true)
				{
					int num2 = 0;
					int num3 = ((byte[])byte_3)[149] - 87;
					while (true)
					{
						num = 7;
						while (true)
						{
							int num6;
							switch (num3)
							{
							case 7:
								num = byte_2[176] - 139;
								goto IL_0065;
							case 3:
								num = 4;
								goto IL_00b9;
							case 6:
								num = byte_[83] - 30;
								goto IL_0065;
							case 5:
								num = (int)byte_[85] / 5;
								goto IL_0065;
							case 4:
								num = byte_[117];
								goto IL_0065;
							case 2:
								num = byte_[106];
								goto IL_0065;
							case 0:
								num = 0;
								goto IL_00ad;
							default:
								num = 12;
								goto IL_0137;
							case 1:
								{
									num = 5;
									goto end_IL_012e;
								}
								IL_0065:
								while (true)
								{
									switch (num)
									{
									case 14:
									{
										dateTime = Class9.smethod_15('2', 20);
										byte num4 = byte_[157];
										Class1.byte_1[168] = Class2.byte_1[90];
										num = num4 - 221;
										continue;
									}
									case 2:
										num2++;
										num = byte_[163] - byte_[64];
										continue;
									case 0:
										break;
									case 4:
										goto IL_00b9;
									case 9:
										goto IL_00bd;
									case 8:
										goto IL_00c5;
									case 10:
									case 13:
										goto IL_00cc;
									case 7:
										goto end_IL_0107;
									case 1:
										goto end_IL_0106;
									case 12:
										goto IL_0137;
									case 5:
										goto end_IL_012e;
									default:
										num = 3;
										goto end_IL_013f;
									case 3:
										goto end_IL_013f;
									case 6:
									{
										DateTime result = dateTime;
										Class9.Class11.smethod_11();
										return result;
									}
									}
									break;
								}
								goto IL_00ad;
								IL_0137:
								num3 = 1;
								num = 7;
								goto case 1;
								IL_00ad:
								num5 = char_0 * char_0;
								num3 = 3;
								num = 7;
								goto case 3;
								IL_00b9:
								num5 = char_0 + num5;
								goto IL_00bd;
								IL_00bd:
								if (num5 % 2 == 0)
								{
									num = 8;
									goto IL_00c5;
								}
								num = 10;
								goto IL_00cc;
								IL_00cc:
								num6 = 2;
								goto IL_00cd;
								IL_00c5:
								num6 = 6;
								goto IL_00cd;
								IL_00cd:
								num3 = num6;
								num = 7;
								break;
								end_IL_0107:
								break;
							}
							continue;
							end_IL_0106:
							break;
						}
						continue;
						end_IL_012e:
						break;
					}
					continue;
					end_IL_013f:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static bool smethod_12(DateTime dateTime_0, DateTime dateTime_1, short short_0, short short_1)
		{
			byte[] byte_ = Class1.byte_1;
			byte[] byte_2 = Class2.byte_1;
			int num3 = default(int);
			int num4 = default(int);
			bool flag = default(bool);
			int num2 = default(int);
			int num5 = default(int);
			while (true)
			{
				object byte_3 = Class2.byte_0;
				while (true)
				{
					Array byte_4 = Class1.byte_0;
					int num = byte_2[175] - 169;
					while (true)
					{
						switch (num)
						{
						case 15:
							break;
						case 13:
							goto IL_0022;
						case 11:
							goto IL_002c;
						case 10:
							goto IL_0040;
						case 9:
							num3 = 585;
							num4 = 721;
							num = byte_[17] - 188;
							continue;
						case 8:
							goto IL_00af;
						default:
							num = byte_[52] - 172;
							continue;
						case 6:
							goto IL_00c7;
						case 5:
							goto IL_00d3;
						case 2:
							goto IL_00fe;
						case 3:
							goto IL_0132;
						case 1:
							flag = Class9.Class10.smethod_8(dateTime_0, dateTime_1, 35, 60);
							num2++;
							num = byte_[13];
							continue;
						case 14:
							goto end_IL_01af;
						case 0:
							goto end_IL_01fb;
						case 4:
						case 12:
						{
							bool result = flag;
							Class9.Class12.smethod_6();
							return result;
						}
						}
						num5 = 4;
						num = 2;
						goto IL_0016;
						IL_00fe:
						switch (num5)
						{
						case 4:
							break;
						case 3:
							goto IL_012a;
						case 6:
							goto IL_012f;
						default:
							goto IL_0148;
						case 0:
							goto IL_0150;
						case 1:
							goto IL_015e;
						case 2:
							goto IL_0166;
						case 5:
							goto IL_0174;
						case 7:
							goto IL_017e;
						case 8:
							goto IL_018b;
						}
						goto IL_0016;
						IL_018b:
						num = byte_[165];
						continue;
						IL_017e:
						num = byte_[34] - byte_[21];
						continue;
						IL_0174:
						num = (int)byte_[28] / 5;
						continue;
						IL_0166:
						num = byte_2[161] - 17;
						continue;
						IL_015e:
						num = 5;
						goto IL_00d3;
						IL_0150:
						num = byte_[215] - 115;
						continue;
						IL_0148:
						num = 8;
						goto IL_00af;
						IL_012f:
						num = 3;
						goto IL_0132;
						IL_012a:
						num = 3;
						goto IL_0132;
						IL_0132:
						num5 = ((byte[])byte_3)[217] - 80;
						num = 2;
						goto IL_00fe;
						IL_00d3:
						if (4326 <= num4 - num3 * 6)
						{
							num = byte_2[144] - 163;
							continue;
						}
						num = 10;
						goto IL_0040;
						IL_0022:
						num2 = 0;
						num5 = 4;
						num = 2;
						goto IL_0016;
						IL_0016:
						num = (int)byte_2[7] / 5;
						continue;
						IL_00c7:
						int num6 = ((byte[])byte_3)[124];
						goto IL_007e;
						IL_00af:
						num5 = 7;
						goto IL_002c;
						IL_0040:
						byte num7 = ((byte[])byte_4)[144];
						byte num8 = (byte_4 as byte[])[144];
						Class1.byte_0[218] = (byte)((Class1.byte_0[218] - Class1.byte_0[98]) & 0xA2);
						num6 = num7 + num8;
						goto IL_007e;
						IL_007e:
						num5 = num6;
						num = byte_2[196] - 79;
						continue;
						IL_002c:
						num = byte_[289] - 128;
						continue;
						end_IL_01af:
						break;
					}
					continue;
					end_IL_01fb:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static char[] smethod_13(string string_0, short short_0, char char_0)
		{
			byte[] byte_ = Class2.byte_1;
			byte[] byte_2 = Class1.byte_1;
			int num6 = default(int);
			int num7 = default(int);
			while (true)
			{
				object byte_3 = Class1.byte_0;
				int num = 10;
				while (true)
				{
					int num2 = 0;
					int num3 = 0;
					num = 5;
					while (true)
					{
						IL_015e:
						num = 14;
						while (true)
						{
							object obj = Class9.Class12.smethod_10(string_0, 768, 888);
							int num4 = num2;
							Class2.byte_1[85] = Class1.byte_1[122];
							num2 = num4 + 1;
							num = byte_2[48] - byte_2[21];
							while (true)
							{
								int num5;
								switch (num)
								{
								case 15:
									num = ((7720 > num6 - num7 * 8) ? (byte_[79] - 153) : byte_2[13]);
									continue;
								case 8:
								case 13:
									num5 = 6;
									goto IL_003a;
								case 9:
									num7 = 60;
									num3 = ((byte[])byte_3)[11] - ((byte[])byte_3)[90];
									num = 5;
									break;
								case 5:
									break;
								default:
									num = byte_[18] - byte_[18];
									continue;
								case 4:
									num6 = 965;
									num = 15;
									goto case 15;
								case 3:
									num5 = 1;
									goto IL_003a;
								case 14:
									goto end_IL_00db;
								case 1:
								case 6:
									goto IL_0159;
								case 11:
								case 12:
									goto IL_016b;
								case 10:
									goto end_IL_0123;
								case 0:
									goto end_IL_0173;
								case 2:
									goto IL_018a;
									IL_003a:
									num3 = num5;
									num = byte_[57] - 68;
									continue;
								}
								switch (num3)
								{
								case 2:
									goto IL_0099;
								case 7:
									goto IL_00a6;
								case 8:
									goto IL_00b0;
								case 1:
									goto IL_0157;
								case 0:
									goto IL_015e;
								case 3:
									goto IL_0163;
								case 4:
									goto IL_0168;
								case 5:
									goto IL_0170;
								case 6:
									goto IL_0188;
								}
								num = byte_2[192];
								continue;
								IL_0099:
								num = byte_2[99] - 185;
								continue;
								IL_0188:
								num = 2;
								goto IL_018a;
								IL_018a:
								char[] result = (char[])obj;
								Class9.smethod_8();
								return result;
								IL_0168:
								num = 12;
								goto IL_016b;
								IL_0163:
								num = 12;
								goto IL_016b;
								IL_016b:
								num3 = 5;
								num = 5;
								goto IL_0170;
								IL_0170:
								num = 10;
								goto end_IL_0123;
								IL_0157:
								num = 6;
								goto IL_0159;
								IL_0159:
								num3 = 0;
								num = 5;
								goto IL_015e;
								IL_00b0:
								num = byte_2[165];
								continue;
								IL_00a6:
								num = byte_2[165];
								continue;
								end_IL_00db:
								break;
							}
							continue;
							end_IL_0123:
							break;
						}
						break;
					}
					continue;
					end_IL_0173:
					break;
				}
			}
		}

		[SecuritySafeCritical]
		static Class0()
		{
			Class8.smethod_6();
		}
	}

	public const string Version = "4.0.0.0";

	public BabelAttribute()
	{
		Class0.smethod_7();
		Class9.smethod_12();
	}

	[SecuritySafeCritical]
	static BabelAttribute()
	{
		Class8.smethod_6();
		Class4.Class5.smethod_13();
	}

	[SecuritySafeCritical]
	internal static byte smethod_0()
	{
		Class9.smethod_13(Class0.smethod_8(596, 559), Class4.Class5.Class6.smethod_7(1486502126, 1L, 6), null, 414, 457);
		Class9.Class12.smethod_1();
		return 14;
	}

	internal static string smethod_1()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		int num3 = default(int);
		while (true)
		{
			object byte_3 = Class1.byte_0;
			while (true)
			{
				object byte_4 = Class2.byte_0;
				int num = 0;
				while (true)
				{
					int num2 = 2029;
					num = byte_2[120] - 125;
					while (true)
					{
						switch (num)
						{
						case 13:
							break;
						case 12:
							goto IL_0030;
						case 10:
							goto IL_0045;
						case 2:
							goto IL_004b;
						default:
							num = byte_[13] * 3;
							continue;
						case 6:
							num3 = (byte_4 as byte[])[64] - 47;
							num = 1;
							goto IL_007e;
						case 1:
							goto IL_007e;
						case 4:
							goto IL_00d0;
						case 3:
							goto IL_00f3;
						case 0:
						case 5:
							goto end_IL_011c;
						case 7:
							goto end_IL_015f;
						case 9:
							goto end_IL_016f;
						case 11:
							goto IL_018b;
						}
						goto IL_0011;
						IL_007e:
						switch (num3)
						{
						case 0:
							goto IL_00a9;
						case 1:
							goto IL_00bb;
						case 2:
							goto IL_00c5;
						case 4:
							goto IL_00ce;
						case 5:
							goto IL_00e9;
						case 6:
							goto IL_00f1;
						case 3:
							goto IL_0183;
						case 7:
							goto IL_0188;
						}
						num = 3;
						goto IL_00f3;
						IL_0188:
						num = 11;
						goto IL_018b;
						IL_0183:
						num = 11;
						goto IL_018b;
						IL_018b:
						Class8.smethod_5();
						return null;
						IL_00f1:
						num = 3;
						goto IL_00f3;
						IL_00e9:
						num = 10;
						goto IL_0045;
						IL_00ce:
						num = 4;
						goto IL_00d0;
						IL_00d0:
						if ((num2 * num2 + num2) % 2 != 0)
						{
							num = 13;
							goto IL_0011;
						}
						num = 12;
						goto IL_0030;
						IL_0011:
						int num4 = ((byte[])byte_3)[33];
						goto IL_001b;
						IL_001b:
						num3 = num4;
						num = byte_2[173] - 158;
						continue;
						IL_00c5:
						num = (int)byte_2[9] / 4;
						continue;
						IL_00bb:
						num = byte_[2] - byte_[2];
						continue;
						IL_00a9:
						num = byte_[258] - byte_[190];
						continue;
						IL_0030:
						num4 = ((byte[])byte_4)[407] - 156;
						goto IL_001b;
						IL_00f3:
						num3 = 1;
						byte num5 = byte_2[2];
						Class1.byte_1[120] = (byte)((Class1.byte_1[120] - Class1.byte_1[62]) & 0x3B);
						num = num5 - 230;
						continue;
						IL_0045:
						smethod_1();
						goto IL_004b;
						IL_004b:
						num3 = 3;
						num = byte_[177] - 132;
						continue;
						end_IL_011c:
						break;
					}
					continue;
					end_IL_015f:
					break;
				}
				continue;
				end_IL_016f:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type smethod_2()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		while (true)
		{
			object byte_3 = Class1.byte_0;
			while (true)
			{
				int num = 2;
				while (true)
				{
					Class4.smethod_9(Class0.smethod_8(276, 360), Class4.Class5.Class6.smethod_7(1486502112, 15L, 8), null, 598, 'ȝ');
					while (true)
					{
						int num2 = 5;
						num = 6;
						while (true)
						{
							IL_00d5:
							num = byte_[279] - 147;
							while (true)
							{
								switch (num)
								{
								case 6:
									break;
								case 8:
									goto IL_0032;
								case 3:
									goto end_IL_00a5;
								case 2:
									goto end_IL_00e5;
								case 5:
								case 7:
									goto end_IL_00ec;
								default:
									num = 4;
									goto end_IL_0121;
								case 1:
								case 4:
									goto end_IL_0121;
								case 9:
								{
									Type typeFromHandle = typeof(Class2.Class3);
									Class9.Class10.smethod_5();
									return typeFromHandle;
								}
								}
								goto IL_0011;
								IL_0011:
								switch (num2)
								{
								case 0:
									goto IL_0066;
								case 1:
									goto IL_0073;
								case 2:
									goto IL_007d;
								case 3:
									goto IL_008d;
								case 4:
									goto IL_009d;
								case 5:
									goto IL_00d5;
								}
								num = 8;
								goto IL_0032;
								IL_009d:
								num = byte_2[67] - 105;
								continue;
								IL_008d:
								num = byte_2[173] - 157;
								continue;
								IL_007d:
								num = byte_[333] - 154;
								continue;
								IL_0073:
								num = byte_2[70] - 88;
								continue;
								IL_0066:
								num = byte_[168] - 33;
								continue;
								IL_0032:
								byte num3 = (byte_3 as byte[])[111];
								Class2.byte_0[412] = (byte)((Class2.byte_0[412] - Class2.byte_0[60]) & 0x71);
								num2 = num3 - 101;
								num = 6;
								goto IL_0011;
								continue;
								end_IL_00a5:
								break;
							}
							break;
						}
						continue;
						end_IL_00e5:
						break;
					}
					continue;
					end_IL_00ec:
					break;
				}
				continue;
				end_IL_0121:
				break;
			}
		}
	}

	internal static void smethod_3()
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		int num = 9;
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			object byte_3 = Class2.byte_0;
			int num2 = 0;
			num = byte_[85];
			while (true)
			{
				int num3;
				switch (num)
				{
				case 7:
					num3 = (byte_3 as byte[])[224] - ((byte[])byte_3)[140];
					goto IL_002f;
				case 10:
					switch (num2)
					{
					case 4:
						break;
					default:
						goto IL_009b;
					case 0:
						goto IL_009f;
					case 1:
						goto IL_00b9;
					case 2:
						goto IL_00bd;
					case 3:
						goto IL_00c7;
					case 6:
						goto IL_00d4;
					case 5:
						goto IL_0125;
					}
					num = 11;
					goto case 6;
				case 3:
				case 4:
					num3 = 2;
					goto IL_002f;
				case 6:
				case 11:
				{
					int num6 = num5;
					int num7 = num4;
					Class1.byte_1[206] = (byte)((Class1.byte_1[206] + Class1.byte_1[62]) & 0xA0);
					if (8032 > num6 - num7 * 8)
					{
						num = 7;
						goto case 7;
					}
					num = 3;
					goto case 3;
				}
				case 5:
					num4 = 791;
					num5 = 1004;
					num = byte_2[158];
					continue;
				case 8:
					num2 = 6;
					num = 10;
					goto IL_00d4;
				case 2:
					smethod_3();
					goto case 0;
				case 0:
				case 1:
					{
						Class9.Class11.smethod_10();
						return;
					}
					IL_002f:
					num2 = num3;
					num = 10;
					goto case 10;
					IL_0125:
					num = 2;
					goto case 2;
					IL_00c7:
					num = byte_[30] - 202;
					continue;
					IL_00bd:
					num = 8;
					goto case 8;
					IL_00b9:
					num = 8;
					goto case 8;
					IL_00d4:
					num = byte_2[139] - 18;
					continue;
					IL_009f:
					num = 5;
					goto case 5;
					IL_009b:
					num = 5;
					goto case 5;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_4()
	{
		Class9.smethod_13(Class0.smethod_8(189, 192), Class4.Class5.Class6.smethod_7(1486502127, 13L, 7), null, 701, 746);
		Class9.Class12.smethod_2();
	}

	[SecuritySafeCritical]
	internal static Type smethod_5()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		IStructuralComparable structuralComparable = default(IStructuralComparable);
		int num5 = default(int);
		int num2 = default(int);
		while (true)
		{
			Array byte_3 = Class2.byte_0;
			object byte_4 = Class1.byte_0;
			int num = byte_2[125] - 143;
			while (true)
			{
				int num6;
				int num4;
				int num11;
				int num3;
				int num13;
				int num12;
				int num8;
				int num10;
				int num9;
				int num7;
				switch (num)
				{
				case 46:
				case 53:
					num6 = (byte_4 as byte[])[108] - 215;
					goto IL_0021;
				case 18:
					Class4.smethod_0();
					num5 = 22;
					num = 33;
					goto IL_0039;
				case 16:
					num2++;
					num5 = 15;
					num = 33;
					goto IL_0048;
				case 38:
					if ((((Array)structuralComparable) as byte[])[num2] >= 196)
					{
						num = 15;
						goto case 15;
					}
					num = 36;
					goto case 36;
				case 15:
					num4 = 12;
					goto IL_006d;
				case 36:
					num4 = 28;
					goto IL_006d;
				case 3:
					if (((byte[])(Array)structuralComparable)[num2] < 208)
					{
						num = 19;
						goto case 19;
					}
					num = byte_[159] - 32;
					continue;
				case 19:
					num11 = (int)(byte_4 as byte[])[122] / 4;
					goto IL_009d;
				case 34:
					if (196 != ((byte[])(structuralComparable as Array))[num2])
					{
						num = 5;
						goto case 5;
					}
					num = 9;
					goto case 9;
				case 5:
				case 35:
					num3 = ((byte[])byte_3)[198] - 82;
					goto IL_00d4;
				case 9:
					num3 = 2;
					goto IL_00d4;
				case 33:
					switch (num5)
					{
					case 27:
						break;
					case 22:
						goto IL_0039;
					case 15:
						goto IL_0048;
					case 18:
						goto IL_0073;
					case 12:
						goto IL_00a3;
					default:
						goto IL_0156;
					case 0:
						goto IL_0166;
					case 1:
						goto IL_0172;
					case 2:
						goto IL_0185;
					case 4:
						goto IL_018d;
					case 5:
						goto IL_01ae;
					case 7:
						goto IL_01de;
					case 8:
						goto IL_01ee;
					case 9:
						goto IL_020a;
					case 10:
						goto IL_0216;
					case 11:
						goto IL_0226;
					case 13:
						goto IL_0235;
					case 14:
						goto IL_023f;
					case 16:
						goto IL_025c;
					case 17:
						goto IL_026e;
					case 19:
						goto IL_02aa;
					case 20:
						goto IL_02ba;
					case 23:
						goto IL_030b;
					case 24:
						goto IL_031b;
					case 25:
						goto IL_0328;
					case 26:
						goto IL_0370;
					case 29:
						goto IL_037d;
					case 3:
						goto IL_0634;
					case 6:
						goto IL_0643;
					case 21:
						goto IL_0652;
					case 28:
						goto IL_0661;
					}
					num = 18;
					goto case 18;
				case 25:
					num5 = (byte_3 as byte[])[22] + 13;
					num = byte_[221] - 57;
					continue;
				case 1:
					num = ((((structuralComparable as Array) as byte[])[num2] < 116) ? (byte_2[7] + 6) : (byte_[169] - 15));
					continue;
				case 22:
					num2++;
					num5 = 10;
					num = byte_[36] - 175;
					continue;
				case 41:
					Class4.smethod_1();
					goto case 14;
				case 14:
					num2++;
					num5 = 5;
					num = byte_2[69] - 96;
					continue;
				case 52:
					num = ((8 == ((byte[])(Array)structuralComparable)[num2]) ? (byte_2[110] - 97) : byte_2[117]);
					continue;
				case 2:
					num2 = 0;
					structuralComparable = (byte[])Class4.smethod_6(Class0.smethod_8(205, 179), Class4.Class5.Class6.smethod_7(1486502126, 10L, 6), 884, '\u0357');
					num = byte_[135] - 223;
					continue;
				case 50:
					if (((structuralComparable as Array) as byte[])[num2] >= 8)
					{
						num = 48;
						goto case 48;
					}
					num = 39;
					goto case 39;
				case 48:
					num13 = (byte_3 as byte[])[429] - (byte_3 as byte[])[94];
					goto IL_035f;
				case 39:
					num13 = 13;
					goto IL_035f;
				case 30:
					Class4.Class5.smethod_0();
					goto case 28;
				case 28:
					num2++;
					num5 = 18;
					num = byte_[111] - 88;
					continue;
				case 51:
					if (208 != ((byte[])(Array)structuralComparable)[num2])
					{
						num = 20;
						goto case 20;
					}
					num = byte_2[78];
					continue;
				case 20:
					num12 = (int)(byte_3 as byte[])[198] / 6;
					goto IL_03c3;
				default:
					num = byte_[78] - 184;
					continue;
				case 43:
					num12 = (byte_3 as byte[])[94];
					goto IL_03c3;
				case 42:
					num8 = 11;
					goto IL_03f4;
				case 40:
					num = 33;
					goto case 33;
				case 37:
					num = ((65 == ((structuralComparable as Array) as byte[])[num2]) ? (byte_2[66] - 139) : byte_[83]);
					continue;
				case 32:
					num10 = 27;
					goto IL_0434;
				case 29:
					num11 = 0;
					goto IL_009d;
				case 27:
					smethod_2();
					num5 = ((byte[])byte_3)[94];
					goto case 40;
				case 24:
					num10 = 22;
					goto IL_0434;
				case 17:
					num9 = 7;
					goto IL_045b;
				case 13:
					num7 = 23;
					goto IL_046d;
				case 12:
					num9 = 29;
					goto IL_045b;
				case 11:
					num8 = ((byte[])byte_3)[367] - 204;
					goto IL_03f4;
				case 10:
					num7 = 1;
					goto IL_046d;
				case 8:
					smethod_2();
					num5 = 23;
					num = byte_2[14] - 213;
					continue;
				case 7:
					num5 = 25;
					num = byte_[52] - 139;
					continue;
				case 6:
					num6 = (int)((byte[])byte_3)[39] / 5;
					goto IL_0021;
				case 4:
					if (((structuralComparable as Array) as byte[])[num2] >= 65)
					{
						num = 6;
						goto case 6;
					}
					num = byte_[63] - 56;
					continue;
				case 0:
					if (116 != ((byte[])(Array)structuralComparable)[num2])
					{
						num = 10;
						goto case 10;
					}
					num = byte_[170] - 17;
					continue;
				case 44:
					break;
				case 21:
					num2++;
					return typeof(Struct1);
				case 47:
				{
					Type typeFromHandle = typeof(Struct0);
					Class9.smethod_12();
					return typeFromHandle;
				}
				case 45:
					return typeof(Class2);
				case 23:
					return typeof(Class2);
				case 26:
					return typeof(_003CModule_003E);
				case 31:
					{
						return typeof(Attribute0);
					}
					IL_00d4:
					num5 = num3;
					num = 33;
					goto case 33;
					IL_046d:
					num5 = num7;
					num = 33;
					goto case 33;
					IL_045b:
					num5 = num9;
					num = (int)byte_[246] / 5;
					continue;
					IL_0434:
					num5 = num10;
					num = 33;
					goto case 33;
					IL_0073:
					num = 3;
					goto case 3;
					IL_03f4:
					num5 = num8;
					num = 33;
					goto case 33;
					IL_03c3:
					num5 = num12;
					num = 33;
					goto case 33;
					IL_0021:
					num5 = num6;
					num = 33;
					goto case 33;
					IL_0661:
					num = 31;
					goto case 31;
					IL_0652:
					num = 26;
					goto case 26;
					IL_0643:
					num = 23;
					goto case 23;
					IL_0634:
					num = 45;
					goto case 45;
					IL_037d:
					num = 30;
					goto case 30;
					IL_0370:
					num = byte_[165];
					continue;
					IL_0328:
					num = 50;
					goto case 50;
					IL_006d:
					num5 = num4;
					num = 33;
					goto case 33;
					IL_009d:
					num5 = num11;
					num = 33;
					goto case 33;
					IL_035f:
					num5 = num13;
					num = byte_[240] - 25;
					continue;
					IL_031b:
					num = byte_2[66] - 126;
					continue;
					IL_030b:
					num = byte_[21] - 206;
					continue;
					IL_02ba:
					num = 2;
					goto case 2;
					IL_02aa:
					num = byte_[196] - 111;
					continue;
					IL_026e:
					num = 52;
					goto case 52;
					IL_0039:
					num = 16;
					goto case 16;
					IL_025c:
					num = byte_2[175] - byte_2[100];
					continue;
					IL_023f:
					num = 41;
					goto case 41;
					IL_0235:
					num = byte_[116];
					continue;
					IL_0226:
					num = byte_2[1] - 134;
					continue;
					IL_0216:
					num = byte_[17] - 189;
					continue;
					IL_020a:
					num = byte_2[106] * 2;
					continue;
					IL_01ee:
					num = 22;
					goto case 22;
					IL_01de:
					num = byte_2[30] - 176;
					continue;
					IL_01ae:
					num = 1;
					goto case 1;
					IL_0048:
					num = 38;
					goto case 38;
					IL_018d:
					num = 25;
					goto case 25;
					IL_0185:
					num = 14;
					goto case 14;
					IL_0172:
					num = byte_2[160] - 177;
					continue;
					IL_0166:
					num = byte_2[19] - 7;
					continue;
					IL_0156:
					num = byte_2[38] - 144;
					continue;
					IL_00a3:
					num = 34;
					goto case 34;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte smethod_6()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		while (true)
		{
			Array byte_3 = Class1.byte_0;
			Array byte_4 = Class2.byte_0;
			int num = 23;
			while (true)
			{
				int num2 = 0;
				object obj = (byte[])Class4.smethod_6(Class0.smethod_8(313, 326), Class4.Class5.Class6.smethod_7(1486502124, 4L, 4), 781, '\u0329');
				num = 11;
				while (true)
				{
					int num3 = 22;
					num = byte_2[16] - byte_2[62];
					while (true)
					{
						int num10;
						int num7;
						int num9;
						int num8;
						int num4;
						int num6;
						int num5;
						switch (num)
						{
						case 71:
							num10 = 29;
							goto IL_0013;
						case 70:
							if ((obj as byte[])[num2] >= 116)
							{
								num = 20;
								goto case 20;
							}
							num = (int)byte_2[45] / 3;
							continue;
						case 20:
							num7 = 36;
							goto IL_0035;
						case 69:
							break;
						case 47:
							goto IL_0074;
						case 15:
							goto IL_0088;
						case 38:
							goto IL_0098;
						case 37:
							goto IL_00b7;
						case 17:
						case 49:
							goto IL_00cb;
						case 52:
							goto IL_00d2;
						case 10:
							goto IL_00de;
						case 32:
							goto IL_00f5;
						case 54:
							goto IL_0102;
						case 68:
							goto IL_011b;
						case 65:
							goto IL_0210;
						case 14:
							goto IL_0236;
						case 4:
							goto IL_023b;
						case 39:
							goto IL_0254;
						case 34:
							goto IL_0265;
						case 8:
							goto IL_02bd;
						case 50:
							goto IL_02e6;
						case 19:
							goto IL_0305;
						case 58:
							goto IL_0315;
						case 55:
							goto IL_031d;
						case 59:
							goto IL_0320;
						case 31:
							goto IL_0367;
						case 18:
							goto IL_0381;
						case 1:
							goto IL_039d;
						case 41:
							goto IL_03b6;
						case 24:
						case 28:
							goto IL_03de;
						case 3:
							goto IL_041e;
						case 67:
							goto IL_0460;
						case 66:
							num9 = 14;
							goto IL_047f;
						case 64:
							num8 = ((byte[])byte_3)[19];
							goto IL_0498;
						case 63:
							Class4.smethod_0();
							num3 = (byte_3 as byte[])[160] - 151;
							num = 68;
							goto IL_011b;
						case 62:
							num2++;
							num3 = (byte_3 as byte[])[60] - 215;
							num = byte_2[107] - 169;
							continue;
						case 61:
							goto IL_04eb;
						case 60:
							goto IL_04fa;
						case 57:
							num10 = (byte_3 as byte[])[59] - 184;
							goto IL_0013;
						case 53:
							goto IL_0524;
						case 51:
							if ((obj as byte[])[num2] >= 145)
							{
								num = 64;
								goto case 64;
							}
							num = 45;
							goto case 45;
						case 45:
							num8 = 28;
							goto IL_0498;
						case 48:
							goto IL_054f;
						case 46:
							num9 = ((byte[])byte_3)[135] - ((byte[])byte_3)[127];
							goto IL_047f;
						case 42:
							if (196 != ((byte[])obj)[num2])
							{
								num = byte_[93] - 153;
								continue;
							}
							num = 13;
							goto case 13;
						case 13:
							num4 = 35;
							goto IL_05a5;
						case 36:
							if (208 != (obj as byte[])[num2])
							{
								num = byte_[85] - byte_[75];
								continue;
							}
							num = 30;
							goto case 30;
						case 30:
							num6 = (int)((byte[])byte_3)[39] / 8;
							goto IL_05df;
						case 33:
							if (8 != ((byte[])obj)[num2])
							{
								num = 66;
								goto case 66;
							}
							num = byte_2[72] - 132;
							continue;
						case 29:
							goto IL_0614;
						case 25:
							goto IL_0625;
						case 21:
							num7 = 23;
							goto IL_0035;
						case 16:
							num5 = 10;
							goto IL_0635;
						case 9:
							num6 = (byte_4 as byte[])[375];
							goto IL_05df;
						case 6:
							num5 = 30;
							goto IL_0635;
						case 5:
							num4 = (byte_3 as byte[])[41] - ((byte[])byte_3)[41];
							goto IL_05a5;
						case 0:
							goto IL_066c;
						case 11:
							goto end_IL_0693;
						case 23:
							goto end_IL_07bc;
						default:
							num = 12;
							goto end_IL_07d3;
						case 12:
							goto end_IL_07d3;
						case 7:
							return 8;
						case 22:
							return 9;
						case 35:
							Class9.smethod_9();
							return 2;
						case 2:
							goto IL_083c;
						case 44:
							goto IL_0847;
						case 26:
							goto IL_0865;
						case 40:
							goto IL_086b;
						case 56:
							goto IL_0872;
						case 43:
							goto IL_0879;
							IL_0635:
							num3 = num5;
							num = 68;
							goto IL_011b;
							IL_0498:
							num3 = num8;
							num = 68;
							goto IL_011b;
							IL_047f:
							num3 = num9;
							num = byte_2[16] - 48;
							continue;
							IL_05df:
							num3 = num6;
							num = byte_[190] - 16;
							continue;
							IL_05a5:
							num3 = num4;
							num = 68;
							goto IL_011b;
							IL_0035:
							num3 = num7;
							num = byte_2[153] - 83;
							continue;
							IL_0013:
							num3 = num10;
							num = byte_[318];
							continue;
						}
						goto IL_0054;
						IL_066c:
						num = ((116 == (obj as byte[])[num2]) ? (byte_[190] - 78) : (byte_2[14] - 230));
						continue;
						IL_00da:
						num = 10;
						goto IL_00de;
						IL_00de:
						if (((byte[])obj)[num2] < 239)
						{
							num = 32;
							goto IL_00f5;
						}
						num = (int)byte_2[11] / 2;
						continue;
						IL_0625:
						int num11 = 25;
						goto IL_0274;
						IL_0614:
						Class4.Class5.Class6.smethod_2();
						num3 = 1;
						num = 68;
						goto IL_00fe;
						IL_054f:
						Class0.smethod_1();
						num3 = 38;
						num = 68;
						goto IL_0444;
						IL_0524:
						int num12 = 26;
						goto IL_00f7;
						IL_04fa:
						int num13 = (byte_3 as byte[])[162] - 18;
						goto IL_008a;
						IL_04eb:
						num2++;
						num3 = 2;
						num = 68;
						goto IL_01dd;
						IL_0460:
						int num14 = (byte_3 as byte[])[201] - ((byte[])byte_3)[77];
						goto IL_03df;
						IL_0074:
						if (65 != (obj as byte[])[num2])
						{
							num = 15;
							goto IL_0088;
						}
						num = byte_[123] - 122;
						continue;
						IL_00f7:
						num3 = num12;
						num = 68;
						goto IL_011b;
						IL_0088:
						num13 = 11;
						goto IL_008a;
						IL_008a:
						num3 = num13;
						num = 68;
						goto IL_011b;
						IL_011b:
						switch (num3)
						{
						case 39:
							break;
						case 35:
							goto IL_0094;
						case 26:
							goto IL_00b3;
						case 12:
							goto IL_00da;
						case 1:
							goto IL_00fe;
						default:
							goto IL_01c1;
						case 0:
							goto IL_01d2;
						case 2:
							goto IL_01dd;
						case 6:
							goto IL_01e6;
						case 7:
							goto IL_01f7;
						case 8:
							goto IL_0207;
						case 10:
							goto IL_020c;
						case 11:
							goto IL_021a;
						case 14:
							goto IL_0232;
						case 15:
							goto IL_0250;
						case 16:
							goto IL_0290;
						case 17:
							goto IL_029e;
						case 18:
							goto IL_02af;
						case 19:
							goto IL_02ba;
						case 20:
							goto IL_02e2;
						case 21:
							goto IL_02f6;
						case 22:
							goto IL_0301;
						case 25:
							goto IL_032e;
						case 27:
							goto IL_033f;
						case 29:
							goto IL_034d;
						case 30:
							goto IL_0363;
						case 13:
							goto IL_0372;
						case 31:
							goto IL_037d;
						case 32:
							goto IL_03b2;
						case 33:
							goto IL_03ee;
						case 34:
							goto IL_03fa;
						case 36:
							goto IL_040b;
						case 37:
							goto IL_041b;
						case 38:
							goto IL_0444;
						case 3:
							goto IL_07cf;
						case 4:
							goto IL_0839;
						case 5:
							goto IL_0843;
						case 9:
							goto IL_0861;
						case 23:
							goto IL_0867;
						case 24:
							goto IL_086e;
						case 28:
							goto IL_0875;
						}
						num = 47;
						goto IL_0074;
						IL_0875:
						num = 43;
						goto IL_0879;
						IL_0879:
						return 25;
						IL_086e:
						num = 56;
						goto IL_0872;
						IL_0872:
						return 13;
						IL_0867:
						num = 40;
						goto IL_086b;
						IL_086b:
						return 29;
						IL_0861:
						num = 26;
						goto IL_0865;
						IL_0865:
						return 0;
						IL_0843:
						num = 44;
						goto IL_0847;
						IL_0839:
						num = 2;
						goto IL_083c;
						IL_083c:
						smethod_3();
						goto IL_0847;
						IL_0847:
						num2++;
						Class1.byte_0[20] = Class2.byte_0[458];
						return 12;
						IL_07cf:
						num = 23;
						goto end_IL_07bc;
						IL_0444:
						num = byte_[159];
						continue;
						IL_041b:
						num = 3;
						goto IL_041e;
						IL_041e:
						num = (((obj as byte[])[num2] < 208) ? byte_2[102] : byte_[124]);
						continue;
						IL_00f5:
						num12 = 24;
						goto IL_00f7;
						IL_00b3:
						num = 37;
						goto IL_00b7;
						IL_040b:
						num = byte_[42] - byte_[42];
						continue;
						IL_03fa:
						num = byte_2[132] - 53;
						continue;
						IL_03ee:
						num = (int)byte_[7] / 6;
						continue;
						IL_03b2:
						num = 41;
						goto IL_03b6;
						IL_037d:
						num = 18;
						goto IL_0381;
						IL_0381:
						if (145 != ((byte[])obj)[num2])
						{
							num = 69;
							goto IL_0054;
						}
						num = 1;
						goto IL_039d;
						IL_00b7:
						if (239 != ((byte[])obj)[num2])
						{
							num = 17;
							goto IL_00cb;
						}
						num = 52;
						goto IL_00d2;
						IL_0054:
						int num15 = ((byte[])byte_3)[123] - 91;
						goto IL_0061;
						IL_039d:
						num15 = (byte_3 as byte[])[42] - 145;
						goto IL_0061;
						IL_0363:
						num = 31;
						goto IL_0367;
						IL_034d:
						num = byte_[145] - byte_[319];
						continue;
						IL_033f:
						num = byte_[134];
						continue;
						IL_032e:
						num = byte_[212] - 48;
						continue;
						IL_0301:
						num = 19;
						goto IL_0305;
						IL_0305:
						if ((obj as byte[])[num2] >= 8)
						{
							num = 58;
							goto IL_0315;
						}
						num = 55;
						goto IL_031d;
						IL_00cb:
						int num16 = 4;
						goto IL_00d3;
						IL_0315:
						int num17 = 33;
						goto IL_031f;
						IL_0061:
						num3 = num15;
						num = byte_[318];
						continue;
						IL_031d:
						num17 = 27;
						goto IL_031f;
						IL_031f:
						num3 = num17;
						goto IL_0320;
						IL_0320:
						num = byte_[318];
						continue;
						IL_02f6:
						num = byte_[113];
						continue;
						IL_02e2:
						num = 50;
						goto IL_02e6;
						IL_02e6:
						num3 = 3;
						num = byte_[318];
						continue;
						IL_02ba:
						num = 8;
						goto IL_02bd;
						IL_02bd:
						Class0.smethod_0();
						num3 = (byte_3 as byte[])[54] - 198;
						num = byte_[318];
						continue;
						IL_02af:
						num = byte_[42];
						continue;
						IL_029e:
						num = byte_[269] + 37;
						continue;
						IL_0290:
						num = byte_2[62] - 19;
						continue;
						IL_0250:
						num = 39;
						goto IL_0254;
						IL_0254:
						if (((byte[])obj)[num2] >= 65)
						{
							num = 34;
							goto IL_0265;
						}
						num = byte_[15];
						continue;
						IL_00d2:
						num16 = 5;
						goto IL_00d3;
						IL_0265:
						num11 = (int)((byte[])byte_4)[445] / 5;
						goto IL_0274;
						IL_0274:
						num3 = num11;
						num = byte_2[190] + 3;
						continue;
						IL_00d3:
						num3 = num16;
						num = 68;
						goto IL_011b;
						IL_0232:
						num = 14;
						goto IL_0236;
						IL_0236:
						Class4.Class5.Class6.smethod_0();
						goto IL_023b;
						IL_021a:
						num = byte_2[62];
						continue;
						IL_020c:
						num = 65;
						goto IL_0210;
						IL_0210:
						Class4.Class5.Class6.smethod_0();
						goto IL_0367;
						IL_0367:
						num2++;
						num3 = 13;
						num = 68;
						goto IL_0372;
						IL_0372:
						num = byte_[102];
						continue;
						IL_0207:
						num = 4;
						goto IL_023b;
						IL_023b:
						num2++;
						num3 = 37;
						num = byte_2[86] - 116;
						continue;
						IL_01f7:
						num = byte_2[126] - byte_2[71];
						continue;
						IL_01e6:
						num = byte_[139] + 23;
						continue;
						IL_01dd:
						num = 41;
						goto IL_03b6;
						IL_03b6:
						if (((byte[])obj)[num2] >= 196)
						{
							num = byte_[290] - 138;
							continue;
						}
						num = 24;
						goto IL_03de;
						IL_0094:
						num = 38;
						goto IL_0098;
						IL_0098:
						num2++;
						num3 = ((byte[])byte_3)[141] - 23;
						num = 68;
						goto IL_011b;
						IL_03de:
						num14 = 7;
						goto IL_03df;
						IL_03df:
						num3 = num14;
						num = byte_[318];
						continue;
						IL_01d2:
						num = byte_2[45];
						continue;
						IL_01c1:
						num = byte_[239] + 31;
						continue;
						IL_00fe:
						num = 54;
						goto IL_0102;
						IL_0102:
						num2++;
						num3 = (byte_3 as byte[])[171] - 112;
						num = 68;
						goto IL_011b;
						continue;
						end_IL_0693:
						break;
					}
					continue;
					end_IL_07bc:
					break;
				}
				continue;
				end_IL_07d3:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_7()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		int num = 3;
		object obj = default(object);
		int num5 = default(int);
		while (true)
		{
			Array byte_3 = Class2.byte_0;
			while (true)
			{
				Array byte_4 = Class1.byte_0;
				int num2 = 0;
				int num3;
				while (true)
				{
					IL_00b3:
					num = 4;
					while (true)
					{
						num3 = 0;
						num = byte_[66] - 58;
						while (true)
						{
							switch (num)
							{
							case 7:
								break;
							case 0:
								goto IL_004e;
							case 1:
							case 4:
								goto end_IL_007f;
							case 5:
								goto end_IL_00a7;
							default:
								goto end_IL_00b7;
							case 6:
								goto IL_09f7;
							case 2:
								goto IL_0a30;
							}
							goto IL_0013;
							IL_004e:
							switch (num2)
							{
							case 3:
								goto IL_0073;
							case 4:
								goto IL_0077;
							case 0:
								goto IL_00b3;
							case 1:
								goto IL_00cc;
							case 2:
								goto IL_00d3;
							}
							num = byte_[165];
							continue;
							IL_00d3:
							num = 2;
							goto IL_0a30;
							IL_00cc:
							num = 2;
							goto IL_0a30;
							IL_0077:
							num = byte_[113] - 64;
							continue;
							IL_0073:
							num = 7;
							goto IL_0013;
							IL_0013:
							obj = (byte[])Class4.smethod_6(Class0.smethod_8(0, 128), Class4.Class5.Class6.smethod_7(1486502124, 2L, 4), 5, ' ');
							num = byte_2[18] - 198;
							continue;
							end_IL_007f:
							break;
						}
						continue;
						end_IL_00a7:
						break;
					}
					break;
				}
				continue;
				IL_0a30:
				Class9.Class12.smethod_6();
				return;
				IL_09f7:
				while (((byte[])obj)[num3] >= 8)
				{
					int num4 = byte_[212];
					while (true)
					{
						int num10;
						int num18;
						int num13;
						int num8;
						int num11;
						int num7;
						int num17;
						int num19;
						int num20;
						int num16;
						int num14;
						int num9;
						int num15;
						int num12;
						int num6;
						byte num21;
						switch (num4)
						{
						case 76:
							smethod_1();
							num5 = 34;
							num4 = (int)byte_2[24] / 5;
							continue;
						case 75:
							num10 = 2;
							goto IL_0100;
						case 40:
							if (116 == (obj as byte[])[num3])
							{
								num4 = 73;
								goto case 73;
							}
							num4 = byte_[19] + 45;
							continue;
						case 73:
							num18 = (byte_3 as byte[])[243] - 72;
							goto IL_0135;
						case 30:
							if (8 == ((byte[])obj)[num3])
							{
								num4 = 25;
								goto case 25;
							}
							num4 = byte_[169] - 15;
							continue;
						case 25:
							num13 = ((byte[])byte_3)[407] - 122;
							goto IL_0169;
						case 21:
							if (65 != ((byte[])obj)[num3])
							{
								num4 = 5;
								goto case 5;
							}
							num4 = 50;
							goto case 50;
						case 5:
							num8 = 40;
							goto IL_0192;
						case 50:
							num8 = 31;
							goto IL_0192;
						case 8:
							if (((byte[])obj)[num3] >= 252)
							{
								num4 = 3;
								goto case 3;
							}
							num4 = 64;
							goto case 64;
						case 3:
							num11 = 0;
							goto IL_01bc;
						case 64:
							num11 = 25;
							goto IL_01bc;
						case 19:
						case 28:
							if ((obj as byte[])[num3] >= 239)
							{
								num4 = 7;
								goto case 7;
							}
							num4 = 23;
							goto case 23;
						case 7:
							num7 = ((byte[])byte_3)[428] - 144;
							goto IL_01f9;
						case 23:
							num7 = 23;
							goto IL_01f9;
						case 43:
							if (208 == (obj as byte[])[num3])
							{
								num4 = 2;
								goto case 2;
							}
							num4 = byte_[240];
							continue;
						case 2:
							num17 = (int)((byte[])byte_4)[96] / 4;
							goto IL_0229;
						case 59:
							num3++;
							num5 = (byte_3 as byte[])[133] - (byte_3 as byte[])[74];
							num4 = 46;
							goto case 46;
						case 46:
							switch (num5)
							{
							case 41:
								break;
							case 39:
								goto IL_0140;
							case 26:
								goto IL_0174;
							case 20:
								goto IL_019d;
							case 18:
								goto IL_01c7;
							case 16:
								goto IL_0201;
							case 2:
								goto IL_0231;
							case 0:
								goto IL_030f;
							case 1:
								goto IL_031f;
							case 3:
								goto IL_032a;
							case 4:
								goto IL_033e;
							case 6:
								goto IL_0349;
							case 7:
								goto IL_035a;
							case 8:
								goto IL_036b;
							case 9:
								goto IL_0370;
							case 11:
								goto IL_039b;
							case 12:
								goto IL_03ce;
							case 13:
								goto IL_03d9;
							case 14:
								goto IL_03fa;
							case 17:
								goto IL_0419;
							case 19:
								goto IL_0427;
							case 15:
								goto IL_0439;
							case 21:
								goto IL_044a;
							case 24:
								goto IL_0458;
							case 27:
								goto IL_0494;
							case 28:
								goto IL_04a5;
							case 29:
								goto IL_04b2;
							case 30:
								goto IL_04bd;
							case 31:
								goto IL_04cd;
							case 32:
								goto IL_04d3;
							case 34:
								goto IL_04de;
							case 35:
								goto IL_04ec;
							case 36:
								goto IL_04f9;
							case 37:
								goto IL_050a;
							case 38:
								goto IL_051e;
							case 40:
								goto IL_0543;
							case 42:
								goto IL_056f;
							case 10:
								goto IL_057e;
							default:
								num4 = 62;
								return;
							case 5:
								num4 = 18;
								return;
							case 22:
								num4 = 62;
								return;
							case 23:
								num4 = 34;
								return;
							case 25:
								num4 = 68;
								return;
							case 33:
								num4 = 13;
								return;
							}
							num4 = 40;
							goto case 40;
						case 45:
							num3++;
							num5 = (byte_4 as byte[])[60] - 194;
							num4 = byte_2[40] - 207;
							continue;
						case 33:
							Class4.Class5.Class6.smethod_0();
							goto case 0;
						case 0:
							num3++;
							num5 = 20;
							num4 = byte_2[3] - 174;
							continue;
						case 70:
							Class4.smethod_0();
							num5 = 15;
							num4 = 46;
							goto IL_0439;
						case 37:
							if (((byte[])obj)[num3] >= 116)
							{
								num4 = byte_2[38] - 103;
								continue;
							}
							num4 = 41;
							goto case 41;
						case 41:
							num19 = (byte_4 as byte[])[4];
							goto IL_0484;
						case 31:
							Class4.Class5.Class6.smethod_1();
							goto case 36;
						case 36:
							num3++;
							num5 = 35;
							num4 = byte_[3] + 19;
							continue;
						case 1:
							num3++;
							num5 = 10;
							num4 = 46;
							goto IL_057e;
						case 74:
							smethod_4();
							goto case 45;
						case 71:
							num5 = 22;
							num4 = byte_2[2] - 185;
							continue;
						case 69:
							num20 = 8;
							goto IL_05ac;
						case 67:
							if (239 != ((byte[])obj)[num3])
							{
								num4 = 15;
								goto case 15;
							}
							num4 = 69;
							goto case 69;
						case 15:
							num20 = ((byte[])byte_4)[102];
							goto IL_05ac;
						case 66:
							num19 = ((byte[])byte_4)[106] + 4;
							goto IL_0484;
						case 65:
							num16 = 38;
							goto IL_05f0;
						case 63:
							Class4.smethod_0();
							num5 = ((byte[])byte_3)[16];
							num4 = 46;
							goto case 46;
						case 61:
							num18 = ((byte[])byte_3)[136] - 87;
							goto IL_0135;
						case 58:
							num17 = ((byte[])byte_3)[310] - 220;
							goto IL_0229;
						case 56:
							num14 = 19;
							goto IL_0652;
						case 55:
							num5 = ((byte[])byte_3)[322] - 157;
							num4 = byte_2[189] - 139;
							continue;
						case 54:
							num16 = 16;
							goto IL_05f0;
						case 52:
							if (((byte[])obj)[num3] >= 196)
							{
								num4 = 22;
								goto case 22;
							}
							num4 = byte_[228] - byte_[42];
							continue;
						case 22:
							num9 = 7;
							goto IL_06a2;
						case 51:
							num15 = 26;
							goto IL_06c2;
						case 24:
						case 49:
							if (((byte[])obj)[num3] >= 65)
							{
								num4 = byte_2[75] - 202;
								continue;
							}
							num4 = 32;
							goto case 32;
						case 32:
							num15 = ((byte[])byte_4)[233];
							goto IL_06c2;
						case 6:
						case 47:
							num12 = ((byte[])byte_3)[16];
							goto IL_0710;
						case 44:
							num14 = ((byte[])byte_4)[41] - 128;
							goto IL_0652;
						case 42:
							num13 = (byte_4 as byte[])[206] - 185;
							goto IL_0169;
						case 39:
							if (252 != (obj as byte[])[num3])
							{
								num4 = 27;
								goto case 27;
							}
							num4 = byte_2[72] - 131;
							continue;
						case 27:
							num12 = 1;
							goto IL_0710;
						case 38:
							if (145 != (obj as byte[])[num3])
							{
								num4 = 56;
								goto case 56;
							}
							num4 = byte_[190] - byte_[28];
							continue;
						case 35:
							num10 = ((byte[])byte_4)[20] - ((byte[])byte_4)[109];
							goto IL_0100;
						case 29:
							Class4.smethod_0();
							num5 = 2;
							num4 = byte_[154] - 5;
							continue;
						case 26:
							num4 = ((((byte[])obj)[num3] < 145) ? (byte_[41] - 225) : byte_[75]);
							continue;
						case 20:
							num6 = ((byte[])byte_4)[53] - 136;
							goto IL_0813;
						case 17:
							num9 = 33;
							goto IL_06a2;
						case 16:
							if (196 != ((byte[])obj)[num3])
							{
								num4 = 35;
								goto case 35;
							}
							num4 = 75;
							goto case 75;
						case 14:
							if (((byte[])obj)[num3] >= 208)
							{
								num4 = 54;
								goto case 54;
							}
							num4 = 65;
							goto case 65;
						case 11:
							num6 = ((byte[])byte_4)[77] - 127;
							goto IL_0813;
						case 10:
							smethod_4();
							goto case 1;
						case 9:
							num3++;
							num5 = (byte_3 as byte[])[420] - 18;
							num4 = 46;
							goto case 46;
						case 4:
							num3++;
							num5 = (byte_4 as byte[])[106];
							num4 = 46;
							goto case 46;
						default:
							return;
						case 72:
							break;
						case 12:
							return;
						case 48:
							num3++;
							return;
						case 53:
							return;
						case 57:
							return;
						case 60:
							return;
						case 18:
							return;
						case 62:
							return;
						case 34:
							return;
						case 68:
							return;
						case 13:
							return;
							IL_01f9:
							num5 = num7;
							num4 = 46;
							goto case 46;
							IL_0813:
							num5 = num6;
							num4 = 46;
							goto case 46;
							IL_019d:
							num4 = 8;
							goto case 8;
							IL_0192:
							num5 = num8;
							num4 = 46;
							goto case 46;
							IL_0710:
							num5 = num12;
							num4 = byte_[217] - 72;
							continue;
							IL_01bc:
							num5 = num11;
							num4 = 46;
							goto case 46;
							IL_0174:
							num4 = 21;
							goto case 21;
							IL_06c2:
							num5 = num15;
							num4 = byte_2[14] - 200;
							continue;
							IL_06a2:
							num5 = num9;
							num4 = 46;
							goto case 46;
							IL_0140:
							num4 = 30;
							goto case 30;
							IL_0652:
							num5 = num14;
							num4 = 46;
							goto case 46;
							IL_05f0:
							num5 = num16;
							num4 = byte_[134] + byte_[158];
							continue;
							IL_05ac:
							num5 = num20;
							num4 = 46;
							goto case 46;
							IL_0100:
							num5 = num10;
							num4 = 46;
							goto case 46;
							IL_056f:
							num4 = 1;
							goto case 1;
							IL_057e:
							num4 = byte_2[14] - byte_2[3];
							continue;
							IL_0543:
							num4 = 31;
							goto case 31;
							IL_051e:
							num4 = byte_[135] - 173;
							continue;
							IL_050a:
							num4 = byte_[319] - 166;
							continue;
							IL_04f9:
							num4 = byte_[201] - 103;
							continue;
							IL_04ec:
							num4 = (int)byte_[107] / 2;
							continue;
							IL_04de:
							num4 = byte_[165];
							continue;
							IL_04d3:
							num4 = byte_2[64];
							continue;
							IL_04cd:
							num4 = 36;
							goto case 36;
							IL_04bd:
							num4 = (int)byte_[201] / 4;
							continue;
							IL_04b2:
							num4 = byte_2[117];
							continue;
							IL_04a5:
							num4 = (int)byte_2[83] / 2;
							continue;
							IL_0494:
							num4 = byte_2[18] - 144;
							continue;
							IL_0458:
							num4 = 37;
							goto case 37;
							IL_0135:
							num5 = num18;
							num4 = 46;
							goto case 46;
							IL_0484:
							num5 = num19;
							num4 = byte_2[38] - 123;
							continue;
							IL_044a:
							num4 = byte_2[123] - 56;
							continue;
							IL_0427:
							num4 = 70;
							goto case 70;
							IL_0439:
							num4 = byte_[41] - 227;
							continue;
							IL_0419:
							num4 = byte_2[174];
							continue;
							IL_03fa:
							num4 = byte_[259] - 52;
							continue;
							IL_03d9:
							num4 = 33;
							goto case 33;
							IL_03ce:
							num4 = byte_2[62];
							continue;
							IL_039b:
							num21 = byte_[233];
							Class1.byte_1[55] = (byte)((Class1.byte_1[55] + Class1.byte_1[96]) & 0xF8);
							num4 = num21 - 156;
							continue;
							IL_0370:
							num4 = 45;
							goto case 45;
							IL_036b:
							num4 = 0;
							goto case 0;
							IL_035a:
							num4 = byte_[52] - 156;
							continue;
							IL_0349:
							num4 = byte_[158] + 61;
							continue;
							IL_033e:
							num4 = byte_2[85];
							continue;
							IL_032a:
							num4 = byte_[314] - 200;
							continue;
							IL_031f:
							num4 = byte_2[45];
							continue;
							IL_030f:
							num4 = byte_2[2] - 192;
							continue;
							IL_0231:
							num4 = 59;
							goto case 59;
							IL_0201:
							num4 = 43;
							goto case 43;
							IL_0229:
							num5 = num17;
							num4 = 46;
							goto case 46;
							IL_01c7:
							num4 = 19;
							goto case 19;
							IL_0169:
							num5 = num13;
							num4 = 46;
							goto case 46;
						}
						break;
					}
				}
				goto IL_0a30;
				continue;
				end_IL_00b7:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_8()
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		IStructuralEquatable structuralEquatable = default(IStructuralEquatable);
		int num3 = default(int);
		int num7 = default(int);
		while (true)
		{
			object byte_3 = Class2.byte_0;
			Array byte_4 = Class1.byte_0;
			int num = byte_2[163] - 184;
			while (true)
			{
				int num8;
				int num9;
				int num4;
				int num6;
				int num5;
				int num2;
				switch (num)
				{
				case 35:
					num = ((208 == ((byte[])(structuralEquatable as Array))[num7]) ? (byte_2[212] - 54) : byte_[7]);
					continue;
				case 34:
					num8 = 14;
					goto IL_0042;
				case 33:
					num7++;
					num3 = (byte_3 as byte[])[359] - (byte_3 as byte[])[105];
					num = byte_[30] - 173;
					continue;
				case 32:
					num3 = 13;
					num = 31;
					goto IL_0083;
				case 2:
				case 12:
					num7 = 0;
					structuralEquatable = (byte[])Class4.smethod_6(Class0.smethod_8(150, 23), Class4.Class5.Class6.smethod_7(1486502127, 6L, 7), 260, 'Ģ');
					num = 4;
					goto case 4;
				case 4:
					num3 = 17;
					num = byte_2[31];
					continue;
				case 23:
					if (65 != ((byte[])(structuralEquatable as Array))[num7])
					{
						num = 16;
						goto case 16;
					}
					num = 18;
					goto case 18;
				case 16:
					num9 = (byte_3 as byte[])[94];
					goto IL_0107;
				case 18:
					num9 = ((byte[])byte_3)[389] - 147;
					goto IL_0107;
				case 14:
					smethod_2();
					num3 = ((byte[])byte_4)[33];
					num = 31;
					goto case 31;
				case 3:
					Class4.Class5.smethod_1();
					num3 = (byte_3 as byte[])[469] - 94;
					num = 31;
					goto case 31;
				case 17:
					if (((byte[])(structuralEquatable as Array))[num7] >= 208)
					{
						num = 9;
						goto case 9;
					}
					num = byte_[10] - 139;
					continue;
				case 9:
					num4 = 0;
					goto IL_0163;
				case 31:
					switch (num3)
					{
					case 13:
						break;
					case 11:
						goto IL_00ce;
					case 8:
						goto IL_010e;
					case 4:
						goto IL_0128;
					case 3:
						goto IL_0146;
					default:
						goto IL_01bf;
					case 0:
						goto IL_01c9;
					case 1:
						goto IL_01d1;
					case 5:
						goto IL_01e9;
					case 9:
						goto IL_020a;
					case 10:
						goto IL_0216;
					case 12:
						goto IL_0232;
					case 14:
						goto IL_0268;
					case 15:
						goto IL_0272;
					case 17:
						goto IL_027a;
					case 2:
						goto IL_03e9;
					case 6:
						goto IL_03f4;
					case 7:
						goto IL_03f9;
					case 16:
						goto IL_03fe;
					case 18:
						goto IL_0403;
					case 19:
						goto IL_040e;
					}
					goto IL_0083;
				case 30:
					smethod_0();
					num3 = ((byte[])byte_3)[39] - 110;
					num = byte_2[31];
					continue;
				case 7:
					num7++;
					num3 = 12;
					num = byte_[21] - 202;
					continue;
				case 26:
					if (((byte[])(Array)structuralEquatable)[num7] >= 65)
					{
						num = 19;
						goto case 19;
					}
					num = byte_[26] - 102;
					continue;
				case 19:
					num6 = 9;
					goto IL_024d;
				case 28:
					if (((byte[])(structuralEquatable as Array))[num7] >= 8)
					{
						num = byte_2[200];
						continue;
					}
					num = 27;
					goto case 27;
				case 27:
					num8 = 6;
					goto IL_0042;
				default:
					num = (int)byte_[92] / 8;
					continue;
				case 22:
					num = ((8 == ((byte[])(Array)structuralEquatable)[num7]) ? (byte_[47] - 165) : byte_[85]);
					continue;
				case 20:
					num6 = (byte_3 as byte[])[375];
					goto IL_024d;
				case 0:
				case 11:
					num5 = 1;
					goto IL_02f3;
				case 10:
					num5 = 4;
					goto IL_02f3;
				case 8:
					num4 = 7;
					goto IL_0163;
				case 5:
					num2 = ((byte[])byte_3)[135];
					goto IL_0313;
				case 1:
					num2 = (byte_3 as byte[])[76] - 214;
					goto IL_0313;
				case 6:
				case 29:
					break;
				case 21:
					num7++;
					return null;
				case 15:
					return null;
				case 24:
					Class9.Class12.smethod_4();
					return null;
				case 13:
					{
						return null;
					}
					IL_0313:
					num3 = num2;
					num = 31;
					goto case 31;
					IL_02f3:
					num3 = num5;
					num = byte_[83] - 5;
					continue;
					IL_00ce:
					num = 23;
					goto case 23;
					IL_0083:
					num = 2;
					goto case 2;
					IL_0107:
					num3 = num9;
					num = 31;
					goto case 31;
					IL_040e:
					num = 13;
					goto case 13;
					IL_0403:
					num = 24;
					goto case 24;
					IL_03fe:
					num = 15;
					goto case 15;
					IL_03f9:
					num = 15;
					goto case 15;
					IL_03f4:
					num = 24;
					goto case 24;
					IL_03e9:
					num = 21;
					goto case 21;
					IL_027a:
					num = byte_2[162] - 98;
					continue;
					IL_0272:
					num = 32;
					goto case 32;
					IL_0268:
					num = byte_2[35];
					continue;
					IL_0232:
					num = 26;
					goto case 26;
					IL_024d:
					num3 = num6;
					num = byte_[83] - 5;
					continue;
					IL_0216:
					num = 7;
					goto case 7;
					IL_020a:
					num = (int)byte_[86] / 8;
					continue;
					IL_01e9:
					num = 30;
					goto case 30;
					IL_01d1:
					num = 33;
					goto case 33;
					IL_01c9:
					num = 35;
					goto case 35;
					IL_01bf:
					num = byte_2[83];
					continue;
					IL_0146:
					num = 17;
					goto case 17;
					IL_0042:
					num3 = num8;
					num = byte_2[31];
					continue;
					IL_0163:
					num3 = num4;
					num = 31;
					goto case 31;
					IL_0128:
					num = 3;
					goto case 3;
					IL_010e:
					num = 14;
					goto case 14;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_9()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		object obj = default(object);
		int num11 = default(int);
		int num6 = default(int);
		while (true)
		{
			Array byte_3 = Class2.byte_0;
			object byte_4 = Class1.byte_0;
			int num = byte_[159];
			while (true)
			{
				int num4;
				int num13;
				int num9;
				int num2;
				int num16;
				int num10;
				int num3;
				int num15;
				int num8;
				int num12;
				int num5;
				int num7;
				switch (num)
				{
				case 63:
					num4 = 15;
					goto IL_0013;
				case 62:
					num6++;
					num11 = 18;
					num = byte_[27] - 42;
					continue;
				case 61:
					num6 = 0;
					obj = (byte[])Class4.smethod_6(Class0.smethod_8(989, 863), Class4.Class5.Class6.smethod_7(1486502112, 0L, 8), 102, 'A');
					num = 47;
					goto case 47;
				case 47:
					num11 = (byte_3 as byte[])[5];
					num = 45;
					goto case 45;
				case 4:
					if ((((Array)obj) as byte[])[num6] >= 196)
					{
						num = 31;
						goto case 31;
					}
					num = byte_[42];
					continue;
				case 31:
					num13 = 4;
					goto IL_00a4;
				case 50:
					Class4.Class5.Class6.smethod_3();
					goto case 56;
				case 56:
					num6++;
					num11 = (byte_4 as byte[])[103] - 17;
					num = 45;
					goto case 45;
				case 14:
					if (((byte[])(obj as Array))[num6] < 145)
					{
						num = 60;
						goto case 60;
					}
					num = byte_[119];
					continue;
				case 60:
					num9 = ((byte[])byte_4)[88] - 39;
					goto IL_0100;
				case 44:
					if (208 != ((byte[])(Array)obj)[num6])
					{
						num = 8;
						goto case 8;
					}
					num = byte_[78] - 228;
					continue;
				case 8:
					num2 = (byte_3 as byte[])[168] - 35;
					goto IL_0139;
				case 40:
					num = 45;
					goto case 45;
				case 3:
					Class0.smethod_0();
					num11 = ((byte[])byte_4)[233];
					num = 45;
					goto case 45;
				case 38:
					if ((((Array)obj) as byte[])[num6] >= 208)
					{
						num = 20;
						goto case 20;
					}
					num = 26;
					goto case 26;
				case 20:
					num16 = 19;
					goto IL_0199;
				case 26:
					num16 = ((byte[])byte_4)[24] - 142;
					goto IL_0199;
				case 35:
					if (((obj as Array) as byte[])[num6] >= 8)
					{
						num = 1;
						goto case 1;
					}
					num = byte_[99] - byte_[209];
					continue;
				case 1:
					num10 = ((byte[])byte_4)[45] - 188;
					goto IL_01cb;
				case 41:
					num = 45;
					goto case 45;
				case 53:
					num11 = 26;
					num = 45;
					goto IL_01e8;
				case 45:
					switch (num11)
					{
					case 33:
						break;
					case 24:
						goto IL_00af;
					case 22:
						goto IL_00d4;
					case 19:
						goto IL_010b;
					case 15:
						goto IL_0144;
					case 14:
						goto IL_0165;
					case 13:
						goto IL_01a1;
					case 8:
						goto IL_01d3;
					default:
						goto IL_01dc;
					case 26:
						goto IL_01e8;
					case 0:
						goto IL_0289;
					case 1:
						goto IL_0299;
					case 2:
						goto IL_02a3;
					case 4:
						goto IL_02ac;
					case 5:
						goto IL_02b9;
					case 6:
						goto IL_02c6;
					case 9:
						goto IL_02e6;
					case 11:
						goto IL_032c;
					case 12:
						goto IL_033a;
					case 16:
						goto IL_035b;
					case 17:
						goto IL_0392;
					case 18:
						goto IL_03be;
					case 20:
						goto IL_0401;
					case 21:
						goto IL_040f;
					case 23:
						goto IL_0443;
					case 25:
						goto IL_04b3;
					case 27:
						goto IL_04cc;
					case 28:
						goto IL_04dd;
					case 29:
						goto IL_04eb;
					case 30:
						goto IL_04fc;
					case 31:
						goto IL_050a;
					case 7:
						goto IL_051a;
					case 3:
						goto IL_0791;
					case 10:
						goto IL_0797;
					case 32:
						goto IL_079d;
					case 34:
						goto IL_07a3;
					}
					num = 4;
					goto case 4;
				case 15:
					num11 = (byte_4 as byte[])[19] + 2;
					num = byte_2[19] - 13;
					continue;
				case 24:
					if (145 != ((obj as Array) as byte[])[num6])
					{
						num = byte_[192] - byte_[13];
						continue;
					}
					num = 10;
					goto case 10;
				case 10:
					num3 = 34;
					goto IL_0317;
				case 12:
					Class4.Class5.Class6.smethod_3();
					goto case 42;
				case 51:
					num = ((116 == ((obj as Array) as byte[])[num6]) ? (byte_2[126] - 124) : (byte_[145] - 198));
					continue;
				case 11:
					if (65 != ((obj as Array) as byte[])[num6])
					{
						num = 63;
						goto case 63;
					}
					num = byte_2[120] - 112;
					continue;
				case 43:
					if ((((Array)obj) as byte[])[num6] >= 116)
					{
						num = 22;
						goto case 22;
					}
					num = 29;
					goto case 29;
				case 22:
					num15 = 16;
					goto IL_03e1;
				case 29:
					num15 = 32;
					goto IL_03e1;
				case 57:
					smethod_3();
					goto case 5;
				case 5:
					num6++;
					num11 = ((byte[])byte_4)[40] - 64;
					goto case 48;
				case 48:
					num = byte_2[118] + 4;
					continue;
				case 2:
				{
					if (((byte[])(obj as Array))[num6] >= 65)
					{
						num = 37;
						goto case 37;
					}
					byte num14 = byte_2[86];
					Class2.byte_1[134] = (byte)((Class2.byte_1[134] ^ Class2.byte_1[38]) & 0x89);
					num = num14 - 157;
					continue;
				}
				case 37:
					num8 = ((byte[])byte_4)[99] - 234;
					goto IL_046b;
				case 42:
					num6++;
					num11 = 14;
					num = byte_2[7] * 9;
					continue;
				case 6:
					Class0.smethod_1();
					num11 = 7;
					num = 45;
					goto IL_051a;
				case 59:
					num12 = 7;
					goto IL_0537;
				case 55:
					num6++;
					num = byte_2[20] - 207;
					continue;
				case 54:
					num13 = 11;
					goto IL_00a4;
				case 52:
					if (196 != ((byte[])(obj as Array))[num6])
					{
						num = 13;
						goto case 13;
					}
					num = 59;
					goto case 59;
				case 13:
					num12 = 31;
					goto IL_0537;
				case 46:
					num5 = ((byte[])byte_4)[109] - 49;
					goto IL_0595;
				case 34:
					num7 = (byte_3 as byte[])[4] - 47;
					goto IL_05b4;
				case 33:
					num10 = ((byte[])byte_4)[224] - 58;
					goto IL_01cb;
				case 30:
					num9 = 9;
					goto IL_0100;
				case 27:
					num8 = ((byte[])byte_4)[4];
					goto IL_046b;
				case 21:
					if (8 != ((byte[])(Array)obj)[num6])
					{
						num = 16;
						goto case 16;
					}
					num = byte_2[85] + 24;
					continue;
				case 16:
					num7 = ((byte[])byte_4)[133] - ((byte[])byte_4)[20];
					goto IL_05b4;
				case 18:
					num5 = ((byte[])byte_4)[148] - 115;
					goto IL_0595;
				case 17:
					num4 = ((byte[])byte_4)[233];
					goto IL_0013;
				case 9:
					num3 = 20;
					goto IL_0317;
				case 0:
					num2 = 27;
					goto IL_0139;
				default:
					num = 28;
					break;
				case 28:
					break;
				case 7:
					Class9.Class11.smethod_11();
					return null;
				case 36:
					return null;
				case 39:
					Class4.smethod_1();
					goto case 19;
				case 58:
					return null;
				case 32:
					return null;
				case 49:
					return null;
				case 25:
					return null;
				case 19:
					{
						num6++;
						return null;
					}
					IL_010b:
					num = 44;
					goto case 44;
					IL_05b4:
					num11 = num7;
					num = 45;
					goto case 45;
					IL_0595:
					num11 = num5;
					num = byte_[91] - 153;
					continue;
					IL_0537:
					num11 = num12;
					num = byte_[209] - 122;
					continue;
					IL_07a3:
					num = 19;
					goto case 19;
					IL_079d:
					num = 25;
					goto case 25;
					IL_0797:
					num = 49;
					goto case 49;
					IL_0791:
					num = 32;
					goto case 32;
					IL_050a:
					num = 6;
					goto case 6;
					IL_051a:
					num = byte_[304] + 29;
					continue;
					IL_04fc:
					num = (int)byte_2[45] / 9;
					continue;
					IL_04eb:
					num = byte_[165] * 9;
					continue;
					IL_04dd:
					num = byte_[212];
					continue;
					IL_04cc:
					num = byte_[302] + 27;
					continue;
					IL_04b3:
					num = 42;
					goto case 42;
					IL_0443:
					num = 2;
					goto case 2;
					IL_00d4:
					num = 14;
					goto case 14;
					IL_046b:
					num11 = num8;
					num = byte_2[123] - byte_2[25];
					continue;
					IL_040f:
					num = 57;
					goto case 57;
					IL_0401:
					num = byte_2[70] - 57;
					continue;
					IL_03be:
					num = 43;
					goto case 43;
					IL_03e1:
					num11 = num15;
					num = byte_2[62] - 3;
					continue;
					IL_0392:
					num = 11;
					goto case 11;
					IL_0100:
					num11 = num9;
					num = 45;
					goto case 45;
					IL_0013:
					num11 = num4;
					num = byte_2[35] - 71;
					continue;
					IL_035b:
					num = 51;
					goto case 51;
					IL_00af:
					num = 50;
					goto case 50;
					IL_033a:
					num = 12;
					goto case 12;
					IL_032c:
					num = byte_[240];
					continue;
					IL_02e6:
					num = 24;
					goto case 24;
					IL_0139:
					num11 = num2;
					goto case 40;
					IL_0317:
					num11 = num3;
					num = byte_2[140] - byte_2[91];
					continue;
					IL_02c6:
					num = 15;
					goto case 15;
					IL_02b9:
					num = byte_2[7] + 48;
					continue;
					IL_02ac:
					num = byte_2[102] - 5;
					continue;
					IL_02a3:
					num = 42;
					goto case 42;
					IL_0299:
					num = byte_2[7];
					continue;
					IL_0289:
					num = (int)byte_[190] / 4;
					continue;
					IL_01dc:
					num = 53;
					goto case 53;
					IL_01e8:
					num = 61;
					goto case 61;
					IL_01d3:
					num = 50;
					goto case 50;
					IL_01a1:
					num = 35;
					goto case 35;
					IL_01cb:
					num11 = num10;
					goto case 41;
					IL_0165:
					num = 38;
					goto case 38;
					IL_00a4:
					num11 = num13;
					num = 45;
					goto case 45;
					IL_0199:
					num11 = num16;
					num = 45;
					goto case 45;
					IL_0144:
					num = 3;
					goto case 3;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_10()
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		IEnumerable enumerable = default(IEnumerable);
		int num3 = default(int);
		while (true)
		{
			object byte_3 = Class1.byte_0;
			object byte_4 = Class2.byte_0;
			int num = 17;
			while (true)
			{
				int num2 = 0;
				num = (int)byte_[9] / 4;
				while (true)
				{
					int num8;
					int num6;
					int num4;
					int num11;
					int num10;
					int num5;
					int num9;
					int num7;
					switch (num)
					{
					case 45:
						num3 = ((byte[])byte_3)[210] - 40;
						num = byte_2[232] - byte_2[83];
						continue;
					case 44:
						Class4.smethod_0();
						num3 = 16;
						num = 37;
						goto IL_0041;
					case 43:
						num8 = 7;
						goto IL_0057;
					case 36:
						num3 = ((byte[])byte_3)[197] - 245;
						num = 37;
						goto case 37;
					case 38:
						if (((byte[])(Array)enumerable)[num2] < 8)
						{
							num = 8;
							goto case 8;
						}
						num = byte_2[158];
						continue;
					case 8:
						num6 = 22;
						goto IL_0099;
					case 28:
						if (((enumerable as Array) as byte[])[num2] >= 208)
						{
							num = 20;
							goto case 20;
						}
						num = 32;
						goto case 32;
					case 20:
						num4 = ((byte[])byte_4)[32] - 83;
						goto IL_00d0;
					case 32:
						num4 = 19;
						goto IL_00d0;
					case 39:
						Class4.smethod_0();
						num3 = ((byte[])byte_4)[139] - 201;
						num = 37;
						goto case 37;
					case 37:
						switch (num3)
						{
						case 16:
							break;
						case 17:
							goto IL_0061;
						case 14:
							goto IL_007d;
						case 2:
							goto IL_00a0;
						case 0:
							goto IL_00d7;
						default:
							goto IL_0163;
						case 3:
							goto IL_016d;
						case 5:
							goto IL_01b5;
						case 8:
							goto IL_01bd;
						case 9:
							goto IL_01c7;
						case 1:
							goto IL_01d6;
						case 10:
							goto IL_01e3;
						case 11:
							goto IL_01f6;
						case 12:
							goto IL_0206;
						case 13:
							goto IL_0216;
						case 15:
							goto IL_0231;
						case 18:
							goto IL_023e;
						case 19:
							goto IL_0248;
						case 20:
							goto IL_0252;
						case 21:
							goto IL_0262;
						case 23:
							goto IL_0272;
						case 24:
							goto IL_0282;
						case 6:
							goto IL_04f6;
						case 4:
							goto IL_0527;
						case 7:
							goto IL_052c;
						case 22:
							goto IL_0531;
						}
						goto IL_0041;
					case 6:
						enumerable = (byte[])Class4.smethod_6(Class0.smethod_8(432, 307), Class4.Class5.Class6.smethod_7(1486502125, 0L, 5), 418, 'Ɗ');
						num = byte_[64] - 29;
						continue;
					case 29:
						Class4.Class5.smethod_1();
						num3 = 1;
						num = 37;
						goto IL_01d6;
					case 31:
						if (208 != (((Array)enumerable) as byte[])[num2])
						{
							num = 10;
							goto case 10;
						}
						num = 27;
						goto case 27;
					case 10:
					case 30:
						num11 = 8;
						goto IL_02a6;
					case 27:
						num11 = 20;
						goto IL_02a6;
					case 42:
						if (((byte[])(enumerable as Array))[num2] >= 65)
						{
							num = byte_2[153] - 68;
							continue;
						}
						num = 24;
						goto case 24;
					case 24:
						num10 = 4;
						goto IL_02df;
					case 41:
						num5 = 1;
						goto IL_02ea;
					case 18:
						num = (int)byte_[64] / 2;
						continue;
					case 40:
						Class4.Class5.Class6.smethod_3();
						goto case 4;
					case 4:
						num2++;
						num3 = (byte_3 as byte[])[68] - (byte_3 as byte[])[35];
						num = 37;
						goto case 37;
					case 35:
						num2++;
						num3 = 2;
						num = 37;
						goto IL_00a0;
					case 34:
						num10 = 12;
						goto IL_02df;
					case 33:
						num9 = 16;
						goto IL_0337;
					case 26:
						break;
					case 25:
						num2++;
						num3 = 15;
						num = 37;
						goto IL_0231;
					case 23:
						num7 = ((byte[])byte_4)[124];
						goto IL_038f;
					case 22:
						num9 = 5;
						goto IL_0337;
					case 19:
						if ((((Array)enumerable) as byte[])[num2] >= 196)
						{
							num = 3;
							goto case 3;
						}
						num = 43;
						goto case 43;
					case 3:
						num8 = 10;
						goto IL_0057;
					case 15:
						num7 = 18;
						goto IL_038f;
					case 11:
						num6 = 11;
						goto IL_0099;
					case 7:
						num5 = ((byte[])byte_3)[99] - ((byte[])byte_3)[196];
						goto IL_02ea;
					case 5:
						if (65 != ((enumerable as Array) as byte[])[num2])
						{
							num = 7;
							goto case 7;
						}
						num = 41;
						goto case 41;
					case 1:
						if (196 != ((byte[])(enumerable as Array))[num2])
						{
							num = byte_2[209] - 145;
							continue;
						}
						num = 33;
						goto case 33;
					case 17:
						goto end_IL_0436;
					default:
						num = 2;
						goto end_IL_04f9;
					case 2:
						goto end_IL_04f9;
					case 0:
						num2++;
						return 3;
					case 12:
						return 9;
					case 9:
						return 7;
					case 13:
						return 8;
					case 16:
					case 21:
						{
							Class8.smethod_3();
							return 15;
						}
						IL_00d0:
						num3 = num4;
						num = 37;
						goto case 37;
						IL_007d:
						num = 38;
						goto case 38;
						IL_0041:
						num = byte_2[215] - byte_2[215];
						continue;
						IL_038f:
						num3 = num7;
						num = 37;
						goto case 37;
						IL_0337:
						num3 = num9;
						num = 37;
						goto case 37;
						IL_02ea:
						num3 = num5;
						goto case 18;
						IL_0099:
						num3 = num6;
						num = 37;
						goto case 37;
						IL_02df:
						num3 = num10;
						num = 37;
						goto case 37;
						IL_0057:
						num3 = num8;
						num = 37;
						goto case 37;
						IL_0531:
						num = 21;
						goto case 16;
						IL_052c:
						num = 13;
						goto case 13;
						IL_0527:
						num = 9;
						goto case 9;
						IL_04f6:
						num = 17;
						goto end_IL_0436;
						IL_0282:
						num = 31;
						goto case 31;
						IL_0061:
						num = 36;
						goto case 36;
						IL_02a6:
						num3 = num11;
						num = byte_[46] - 137;
						continue;
						IL_0272:
						num = byte_2[44] - 166;
						continue;
						IL_0262:
						num = byte_[27] - 210;
						continue;
						IL_0252:
						num = byte_2[228] - 67;
						continue;
						IL_0248:
						num = byte_[117];
						continue;
						IL_023e:
						num = byte_[90];
						continue;
						IL_0231:
						num = byte_2[139];
						continue;
						IL_0216:
						num = byte_[44] - byte_[0];
						continue;
						IL_0206:
						num = byte_2[259] - 123;
						continue;
						IL_01f6:
						num = byte_2[154] - 25;
						continue;
						IL_01e3:
						num = byte_2[279] - 155;
						continue;
						IL_01c7:
						num = 29;
						goto case 29;
						IL_01d6:
						num = byte_[106] + 11;
						continue;
						IL_01bd:
						num = byte_2[28];
						continue;
						IL_01b5:
						num = 44;
						goto case 44;
						IL_016d:
						num = 6;
						goto case 6;
						IL_0163:
						num = byte_[83];
						continue;
						IL_00d7:
						num = 39;
						goto case 39;
						IL_00a0:
						num = 28;
						goto case 28;
					}
					num = ((8 == ((byte[])(enumerable as Array))[num2]) ? (byte_2[102] - 36) : (byte_2[322] - 128));
					continue;
					end_IL_0436:
					break;
				}
				continue;
				end_IL_04f9:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type smethod_11()
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		int num3 = default(int);
		while (true)
		{
			Array byte_3 = Class2.byte_0;
			object byte_4 = Class1.byte_0;
			int num = 45;
			while (true)
			{
				int num2 = 0;
				object obj = (byte[])Class4.smethod_6(Class0.smethod_8(781, 905), Class4.Class5.Class6.smethod_7(1486502121, 3L, 1), 78, 'g');
				num = byte_2[193] + 8;
				while (true)
				{
					int num4;
					int num6;
					int num13;
					int num11;
					int num8;
					int num15;
					byte num14;
					int num7;
					int num12;
					int num9;
					int num10;
					int num5;
					switch (num)
					{
					case 62:
						if (((byte[])(Array)obj)[num2] >= 196)
						{
							num = 1;
							goto case 1;
						}
						num = byte_[40] - 250;
						continue;
					case 1:
						num4 = 6;
						goto IL_002d;
					case 20:
						if (208 != ((byte[])(Array)obj)[num2])
						{
							num = 44;
							goto case 44;
						}
						num = byte_2[229] - byte_2[7];
						continue;
					case 44:
						num6 = ((byte[])byte_4)[25] - 69;
						goto IL_0065;
					case 58:
						num2++;
						goto case 52;
					case 52:
						num3 = 29;
						num = 36;
						goto IL_0080;
					case 24:
						if (((obj as Array) as byte[])[num2] >= 65)
						{
							num = 42;
							goto case 42;
						}
						num = byte_2[159];
						continue;
					case 42:
						num13 = ((byte[])byte_4)[23] - 180;
						goto IL_00ad;
					case 34:
						if (8 == (((Array)obj) as byte[])[num2])
						{
							num = 49;
							goto case 49;
						}
						num = byte_[7] + 41;
						continue;
					case 49:
						num11 = (byte_4 as byte[])[33];
						goto IL_00e0;
					case 39:
						smethod_1();
						num3 = 1;
						num = 36;
						goto IL_00fc;
					case 13:
						smethod_3();
						goto case 35;
					case 35:
						num2++;
						num3 = (byte_3 as byte[])[5];
						goto case 47;
					case 47:
						num = 36;
						goto case 36;
					case 21:
						if (((obj as Array) as byte[])[num2] >= 116)
						{
							num = 60;
							goto case 60;
						}
						num = byte_2[35];
						continue;
					case 60:
						num8 = 23;
						goto IL_0147;
					case 25:
						if (((obj as Array) as byte[])[num2] >= 8)
						{
							num = 7;
							goto case 7;
						}
						num = 59;
						goto case 17;
					case 7:
						num15 = 25;
						goto IL_0171;
					case 17:
					case 59:
						num15 = 28;
						goto IL_0171;
					case 4:
						num3 = ((byte[])byte_3)[208] - 30;
						num = 36;
						goto case 36;
					case 36:
						switch (num3)
						{
						case 33:
							break;
						case 32:
							goto IL_0070;
						case 29:
							goto IL_0080;
						case 25:
							goto IL_00b8;
						case 21:
							goto IL_00eb;
						case 1:
							goto IL_00fc;
						case 19:
							goto IL_0105;
						case 17:
							goto IL_0122;
						case 7:
							goto IL_0128;
						case 3:
							goto IL_014f;
						default:
							goto IL_0179;
						case 4:
							goto IL_0229;
						case 5:
							goto IL_0239;
						case 6:
							goto IL_0249;
						case 8:
							goto IL_028f;
						case 2:
							goto IL_02a0;
						case 10:
							goto IL_02b2;
						case 11:
							goto IL_02bf;
						case 12:
							goto IL_02cd;
						case 13:
							goto IL_02d8;
						case 14:
							goto IL_02e6;
						case 15:
							goto IL_02f7;
						case 18:
							goto IL_031b;
						case 20:
							goto IL_0325;
						case 22:
							goto IL_0335;
						case 23:
							goto IL_0343;
						case 24:
							goto IL_0351;
						case 26:
							goto IL_036c;
						case 27:
							goto IL_037a;
						case 28:
							goto IL_0388;
						case 31:
							goto IL_0399;
						case 34:
							goto IL_03cd;
						case 16:
							goto IL_070e;
						case 0:
							goto IL_07a4;
						case 9:
							goto IL_07b4;
						case 30:
							goto IL_07c4;
						}
						num = 20;
						goto case 20;
					case 12:
						num = ((196 == ((byte[])(obj as Array))[num2]) ? (byte_2[221] - 59) : (byte_[72] - 130));
						continue;
					case 55:
						smethod_2();
						num3 = 2;
						num = 36;
						goto IL_02a0;
					case 40:
						num2++;
						num3 = 12;
						num = 36;
						goto IL_02cd;
					case 57:
						Class4.Class5.Class6.smethod_0();
						goto case 50;
					case 50:
						num2++;
						num3 = 34;
						num = byte_2[294] - byte_2[105];
						continue;
					case 26:
						if (((byte[])(Array)obj)[num2] >= 145)
						{
							num = 29;
							goto case 29;
						}
						num = 2;
						goto case 2;
					case 29:
						num14 = ((byte[])byte_3)[51];
						goto IL_0401;
					case 2:
						num14 = ((byte[])byte_4)[7];
						goto IL_0401;
					case 61:
						num13 = ((byte[])byte_3)[207];
						goto IL_00ad;
					case 54:
						num7 = (int)((byte[])byte_4)[172] / 9;
						goto IL_0449;
					case 53:
						smethod_4();
						goto case 28;
					case 28:
						num2++;
						num3 = 7;
						num = byte_[14] - 210;
						continue;
					case 51:
						num12 = 33;
						goto IL_0473;
					case 48:
						num9 = ((byte[])byte_3)[255] - 61;
						goto IL_048d;
					case 46:
						num11 = 24;
						goto IL_00e0;
					case 43:
						num3 = 3;
						num = 36;
						goto IL_014f;
					case 41:
						num12 = 30;
						goto IL_0473;
					case 38:
						num10 = 19;
						goto IL_04b1;
					case 37:
						if (65 != ((byte[])(Array)obj)[num2])
						{
							num = 38;
							goto case 38;
						}
						num = byte_[26] - 90;
						continue;
					case 33:
						num5 = 15;
						goto IL_04e4;
					case 32:
						num10 = ((byte[])byte_3)[437] - 176;
						goto IL_04b1;
					case 31:
						num9 = 5;
						goto IL_048d;
					case 27:
						smethod_0();
						num3 = (byte_4 as byte[])[77] - 123;
						num = byte_[200] - 193;
						continue;
					case 22:
						num8 = ((byte[])byte_4)[144];
						goto IL_0147;
					default:
						num = byte_[126] - 147;
						continue;
					case 11:
						num7 = 31;
						goto IL_0449;
					case 10:
						if (((byte[])(Array)obj)[num2] >= 208)
						{
							num = byte_[163] - 23;
							continue;
						}
						num = 41;
						goto case 41;
					case 9:
						num6 = (byte_4 as byte[])[67] - 125;
						goto IL_0065;
					case 6:
						if (145 != (((Array)obj) as byte[])[num2])
						{
							num = 54;
							goto case 54;
						}
						num = 11;
						goto case 11;
					case 5:
						num5 = ((byte[])byte_3)[354] - 223;
						goto IL_04e4;
					case 3:
						num4 = ((byte[])byte_3)[124];
						goto IL_002d;
					case 0:
						if (116 != (((Array)obj) as byte[])[num2])
						{
							num = 33;
							goto case 33;
						}
						num = (int)byte_2[122] / 2;
						continue;
					case 45:
						break;
					case 23:
						goto end_IL_0712;
					case 15:
					{
						Type typeFromHandle = typeof(Class2.Class3);
						Class9.Class12.smethod_5();
						return typeFromHandle;
					}
					case 16:
						num2++;
						return typeof(Struct0);
					case 19:
						return typeof(Class1);
					case 30:
						return typeof(Struct1);
					case 56:
						return typeof(BabelAttribute);
					case 18:
						return typeof(Struct1);
					case 8:
						{
							return typeof(Struct1);
						}
						IL_00eb:
						num = 39;
						goto case 39;
						IL_00fc:
						num = 58;
						goto case 58;
						IL_00b8:
						num = 34;
						goto case 34;
						IL_04e4:
						num3 = num5;
						num = 36;
						goto case 36;
						IL_0065:
						num3 = num6;
						num = 36;
						goto case 36;
						IL_04b1:
						num3 = num10;
						num = 36;
						goto case 36;
						IL_048d:
						num3 = num9;
						num = 36;
						goto case 36;
						IL_0473:
						num3 = num12;
						num = 36;
						goto case 36;
						IL_0449:
						num3 = num7;
						num = 36;
						goto case 36;
						IL_00e0:
						num3 = num11;
						num = 36;
						goto case 36;
						IL_002d:
						num3 = num4;
						num = 36;
						goto case 36;
						IL_07c4:
						num = 8;
						goto case 8;
						IL_07b4:
						num = 18;
						goto case 18;
						IL_07a4:
						num = 56;
						goto case 56;
						IL_070e:
						num = 45;
						break;
						IL_03cd:
						num = 26;
						goto case 26;
						IL_0080:
						num = 24;
						goto case 24;
						IL_0401:
						num3 = num14;
						num = byte_2[249] - 140;
						continue;
						IL_0399:
						num = byte_[133] - 228;
						continue;
						IL_0388:
						num = (int)byte_[201] / 9;
						continue;
						IL_037a:
						num = byte_[55] - 70;
						continue;
						IL_036c:
						num = byte_2[27] - 34;
						continue;
						IL_0351:
						num = byte_2[13] + 52;
						continue;
						IL_0343:
						num = byte_2[39] - 98;
						continue;
						IL_0335:
						num = byte_[167];
						continue;
						IL_0325:
						num = (int)byte_[183] / 4;
						continue;
						IL_031b:
						num = byte_2[3];
						continue;
						IL_02f7:
						num = 57;
						goto case 57;
						IL_02e6:
						num = byte_2[221] - 84;
						continue;
						IL_02d8:
						num = byte_[87] - 26;
						continue;
						IL_02bf:
						num = byte_[55] - 103;
						continue;
						IL_02b2:
						num = byte_[1] - 84;
						continue;
						IL_028f:
						num = 55;
						goto case 55;
						IL_02a0:
						num = 40;
						goto case 40;
						IL_02cd:
						num = byte_[85];
						continue;
						IL_0249:
						num = 12;
						goto case 12;
						IL_00ad:
						num3 = num13;
						num = 36;
						goto case 36;
						IL_0239:
						num = (int)byte_2[149] / 8;
						continue;
						IL_0229:
						num = byte_2[122] + byte_2[75];
						continue;
						IL_0179:
						num = 4;
						goto case 4;
						IL_014f:
						num = 25;
						goto case 25;
						IL_0070:
						num = 58;
						goto case 58;
						IL_0171:
						num3 = num15;
						num = 36;
						goto case 36;
						IL_0128:
						num = 21;
						goto case 21;
						IL_0147:
						num3 = num8;
						num = 36;
						goto case 36;
						IL_0122:
						num = 35;
						goto case 35;
						IL_0105:
						num = 13;
						goto case 13;
					}
					break;
				}
				continue;
				end_IL_0712:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long smethod_12()
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		while (true)
		{
			object byte_3 = Class2.byte_0;
			object byte_4 = Class1.byte_0;
			int num = 9;
			while (true)
			{
				int num2 = 0;
				object obj = (byte[])Class4.smethod_6(Class0.smethod_8(222, 91), Class4.Class5.Class6.smethod_7(1486502120, 5L, 0), 950, 'Μ');
				num = 8;
				while (true)
				{
					int num3 = 10;
					num = 22;
					while (true)
					{
						IL_03b6:
						num = byte_2[47] - 148;
						while (true)
						{
							int num6;
							int num4;
							int num7;
							int num5;
							switch (num)
							{
							case 34:
								break;
							case 14:
								goto IL_0020;
							case 33:
								num6 = 2;
								goto IL_0049;
							case 31:
								goto IL_0055;
							case 5:
								goto IL_0067;
							case 2:
								goto IL_007f;
							case 13:
								goto IL_00a1;
							case 22:
								goto IL_00bc;
							case 21:
								goto IL_0119;
							case 25:
							case 29:
								goto IL_014b;
							case 23:
								goto IL_015e;
							case 17:
								goto IL_01f0;
							case 20:
								goto IL_0206;
							case 32:
								goto IL_0211;
							case 26:
							case 30:
								num4 = 7;
								goto IL_025b;
							case 28:
								if ((obj as byte[])[num2] >= 8)
								{
									num = 15;
									goto case 15;
								}
								num = 3;
								goto case 3;
							case 15:
								num7 = 13;
								goto IL_028c;
							case 3:
								num7 = ((byte[])byte_3)[403] - 76;
								goto IL_028c;
							case 24:
								num6 = ((byte[])byte_3)[304] - 112;
								goto IL_0049;
							case 19:
								goto IL_02ae;
							case 18:
								if (8 != ((byte[])obj)[num2])
								{
									num = byte_[330] - 213;
									continue;
								}
								num = 24;
								goto case 24;
							case 16:
								num5 = 8;
								goto IL_02e6;
							case 10:
								goto IL_02f0;
							case 4:
								num5 = (byte_4 as byte[])[83] - 161;
								goto IL_02e6;
							case 0:
								num4 = 6;
								goto IL_025b;
							case 8:
								goto end_IL_031d;
							case 9:
								goto end_IL_03c7;
							default:
								num = 7;
								goto end_IL_03d5;
							case 7:
								goto end_IL_03d5;
							case 11:
								return 2L;
							case 6:
								goto IL_043b;
							case 12:
								goto IL_0440;
							case 27:
								goto IL_0452;
							case 35:
								{
									return 6L;
								}
								IL_02e6:
								num3 = num5;
								num = byte_[35];
								continue;
								IL_025b:
								num3 = num4;
								num = 22;
								goto IL_00bc;
								IL_0049:
								num3 = num6;
								num = 22;
								goto IL_00bc;
								IL_028c:
								num3 = num7;
								num = byte_[35];
								continue;
							}
							goto IL_0011;
							IL_02f0:
							int num8 = ((byte[])byte_4)[79] - 199;
							goto IL_0168;
							IL_02ae:
							int num9 = (byte_3 as byte[])[136] - 74;
							goto IL_0074;
							IL_0211:
							if (65 != (obj as byte[])[num2])
							{
								num = byte_[200] - 34;
								continue;
							}
							byte num10 = byte_2[42];
							Class2.byte_1[39] = (byte)((Class2.byte_1[39] + Class2.byte_1[66]) & 0x90);
							num = (int)num10 / 8;
							continue;
							IL_0067:
							num9 = ((byte[])byte_4)[67] - 112;
							goto IL_0074;
							IL_0074:
							num3 = num9;
							num = 22;
							goto IL_00bc;
							IL_00bc:
							switch (num3)
							{
							case 4:
								break;
							case 15:
								goto IL_0051;
							case 12:
								goto IL_007c;
							case 1:
								goto IL_009d;
							default:
								goto IL_00b6;
							case 2:
								goto IL_0115;
							case 3:
								goto IL_012d;
							case 7:
								goto IL_0136;
							case 8:
								goto IL_0147;
							case 9:
								goto IL_0186;
							case 13:
								goto IL_0197;
							case 14:
								goto IL_01a5;
							case 16:
								goto IL_01c1;
							case 17:
								goto IL_01d2;
							case 18:
								goto IL_01e3;
							case 19:
								goto IL_01ec;
							case 10:
								goto IL_03b6;
							case 5:
								goto IL_03d1;
							case 0:
								goto IL_0432;
							case 6:
								goto IL_0438;
							case 11:
								goto IL_044e;
							}
							goto IL_001c;
							IL_044e:
							num = 27;
							goto IL_0452;
							IL_0438:
							num = 6;
							goto IL_043b;
							IL_043b:
							Class4.Class5.smethod_0();
							goto IL_0440;
							IL_0440:
							num2++;
							return 12L;
							IL_0432:
							num = 27;
							goto IL_0452;
							IL_0452:
							Class9.smethod_7();
							return 10L;
							IL_03d1:
							num = 9;
							goto end_IL_03c7;
							IL_01ec:
							num = 17;
							goto IL_01f0;
							IL_01f0:
							num2++;
							num3 = ((byte[])byte_3)[246] - 70;
							goto IL_0206;
							IL_0206:
							num = byte_[35];
							continue;
							IL_01e3:
							num = 14;
							goto IL_0020;
							IL_01d2:
							num = byte_[17] - 161;
							continue;
							IL_01c1:
							num = byte_2[14] - 235;
							continue;
							IL_01a5:
							num = byte_[134];
							continue;
							IL_0197:
							num = byte_2[26] - 104;
							continue;
							IL_0186:
							num = byte_[282] - 24;
							continue;
							IL_0147:
							num = 29;
							goto IL_014b;
							IL_014b:
							if (208 != (obj as byte[])[num2])
							{
								num = 23;
								goto IL_015e;
							}
							num = byte_2[85];
							continue;
							IL_001c:
							num = 14;
							goto IL_0020;
							IL_015e:
							num8 = ((byte[])byte_3)[16];
							goto IL_0168;
							IL_0168:
							num3 = num8;
							num = byte_[272] - 26;
							continue;
							IL_0020:
							num = (((obj as byte[])[num2] < 208) ? (byte_2[123] - 85) : byte_[19]);
							continue;
							IL_0136:
							num = byte_[164] - 55;
							continue;
							IL_012d:
							num = 34;
							goto IL_0011;
							IL_0115:
							num = 21;
							goto IL_0119;
							IL_0119:
							smethod_0();
							num3 = 3;
							num = byte_[35];
							continue;
							IL_00b6:
							num = 13;
							goto IL_00a1;
							IL_009d:
							num = 13;
							goto IL_00a1;
							IL_00a1:
							num3 = ((byte[])byte_3)[135];
							num = 22;
							goto IL_00bc;
							IL_007c:
							num = 2;
							goto IL_007f;
							IL_007f:
							Class0.smethod_1();
							num3 = (byte_4 as byte[])[9] - 226;
							num = 22;
							goto IL_00bc;
							IL_0051:
							num = 31;
							goto IL_0055;
							IL_0055:
							if (((byte[])obj)[num2] < 65)
							{
								num = 5;
								goto IL_0067;
							}
							num = byte_[139];
							continue;
							IL_0011:
							num2++;
							num3 = 4;
							num = 22;
							goto IL_001c;
							continue;
							end_IL_031d:
							break;
						}
						break;
					}
					continue;
					end_IL_03c7:
					break;
				}
				continue;
				end_IL_03d5:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_13()
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		int num = 6;
		object obj = default(object);
		int num5 = default(int);
		int num2 = default(int);
		while (true)
		{
			Array byte_3 = Class1.byte_0;
			object byte_4 = Class2.byte_0;
			num = (int)byte_[117] / 3;
			while (true)
			{
				switch (num)
				{
				case 3:
				case 4:
					goto IL_0010;
				case 1:
					obj = (byte[])Class4.smethod_6(Class0.smethod_8(659, 533), Class4.Class5.Class6.smethod_7(1486502122, 9L, 2), 728, '\u02f3');
					goto case 0;
				case 0:
					while ((obj as byte[])[num2] >= 8)
					{
						int num3 = byte_[78];
						while (true)
						{
							int num17;
							int num6;
							int num10;
							int num7;
							byte num18;
							int num15;
							int num9;
							int num14;
							int num16;
							int num13;
							int num12;
							int num11;
							int num8;
							switch (num3)
							{
							case 67:
								num5 = 0;
								num3 = byte_[155] - 50;
								continue;
							case 66:
								num17 = (byte_3 as byte[])[112] - ((byte[])byte_3)[111];
								goto IL_00c5;
							case 61:
								if (((byte[])obj)[num2] >= 239)
								{
									num3 = 57;
									goto case 57;
								}
								num3 = 6;
								goto case 6;
							case 57:
								num6 = 8;
								goto IL_00fe;
							case 6:
								num6 = (byte_4 as byte[])[133] - 41;
								goto IL_00fe;
							case 38:
								Class0.smethod_1();
								num5 = 20;
								num3 = 30;
								goto IL_011b;
							case 7:
								num2++;
								num5 = (int)((byte[])byte_3)[172] / 6;
								num3 = 30;
								goto case 30;
							case 48:
								Class4.smethod_1();
								goto case 52;
							case 52:
							{
								int num4 = num2;
								Class2.byte_1[96] = (byte)(Class2.byte_1[96] & Class1.byte_1[290] & 0xB);
								num2 = num4 + 1;
								num5 = ((byte[])byte_3)[30] - 183;
								num3 = 30;
								goto case 30;
							}
							case 16:
							case 41:
								if (((byte[])obj)[num2] < 208)
								{
									num3 = 47;
									goto case 47;
								}
								num3 = byte_[201] - 98;
								continue;
							case 47:
								num10 = (int)((byte[])byte_3)[101] / 7;
								goto IL_01ae;
							case 9:
								if (145 == ((byte[])obj)[num2])
								{
									num3 = 36;
									goto case 36;
								}
								num3 = byte_[67] - 89;
								continue;
							case 36:
								num7 = (int)(byte_4 as byte[])[16] / 4;
								goto IL_01e5;
							case 51:
								Class4.Class5.Class6.smethod_3();
								goto case 50;
							case 50:
								num2++;
								num5 = 36;
								num3 = 30;
								goto IL_0204;
							case 5:
								if ((obj as byte[])[num2] < 145)
								{
									num3 = 3;
									goto case 3;
								}
								num3 = 66;
								goto case 66;
							case 3:
								num17 = 15;
								goto IL_00c5;
							case 30:
								switch (num5)
								{
								case 29:
									break;
								case 26:
									goto IL_0109;
								case 20:
									goto IL_011b;
								case 25:
									goto IL_013e;
								case 24:
									goto IL_0187;
								case 3:
									goto IL_01b6;
								case 2:
									goto IL_01bc;
								case 32:
									goto IL_01ed;
								case 36:
									goto IL_0204;
								case 0:
									goto IL_02ce;
								case 1:
									goto IL_0301;
								case 4:
									goto IL_0323;
								case 5:
									goto IL_032c;
								case 6:
									goto IL_036f;
								case 7:
									goto IL_0383;
								case 8:
									goto IL_03bf;
								case 10:
									goto IL_03d0;
								case 11:
									goto IL_03e0;
								case 14:
									goto IL_03ee;
								case 17:
									goto IL_03f9;
								case 19:
									goto IL_0405;
								case 16:
									goto IL_0417;
								case 21:
									goto IL_0426;
								case 22:
									goto IL_0437;
								case 23:
									goto IL_0448;
								case 27:
									goto IL_047b;
								case 28:
									goto IL_0489;
								case 31:
									goto IL_049a;
								case 33:
									goto IL_04a8;
								case 34:
									goto IL_04b3;
								case 35:
									goto IL_04c1;
								case 18:
									goto IL_080a;
								default:
									num3 = 13;
									return;
								case 9:
									num3 = 14;
									return;
								case 12:
									num3 = 55;
									return;
								case 13:
									num3 = 11;
									return;
								case 15:
									num3 = 39;
									return;
								case 30:
									num3 = 26;
									return;
								case 37:
									goto IL_083f;
								}
								num3 = 61;
								goto case 61;
							case 23:
								num3 = (((obj as byte[])[num2] < 65) ? (byte_2[328] - 69) : (byte_[91] - 182));
								continue;
							case 46:
								if (8 != (obj as byte[])[num2])
								{
									num3 = 27;
									goto case 27;
								}
								num3 = 58;
								goto case 58;
							case 27:
								num18 = ((byte[])byte_4)[290];
								goto IL_0360;
							case 58:
								num18 = (byte_3 as byte[])[144];
								goto IL_0360;
							case 42:
								if (65 != (obj as byte[])[num2])
								{
									num3 = byte_[193] + 32;
									continue;
								}
								num3 = 21;
								goto case 21;
							case 21:
								num15 = ((byte[])byte_3)[7];
								goto IL_03b2;
							case 32:
								smethod_4();
								goto case 44;
							case 35:
								smethod_0();
								num5 = 16;
								num3 = 30;
								goto IL_0417;
							case 17:
								num2++;
								goto case 67;
							case 44:
								num2++;
								num5 = (byte_4 as byte[])[8];
								num3 = byte_[36] + 6;
								continue;
							case 4:
								Class4.Class5.Class6.smethod_3();
								goto case 28;
							case 28:
								num2++;
								num5 = (byte_3 as byte[])[128] - 142;
								num3 = byte_[37] - 192;
								continue;
							case 65:
								num9 = 22;
								goto IL_04f7;
							case 63:
								num14 = 16;
								goto IL_0504;
							case 20:
								num3 = 30;
								goto case 30;
							case 62:
								if (((byte[])obj)[num2] >= 196)
								{
									num3 = 0;
									goto case 0;
								}
								num3 = 25;
								goto case 25;
							case 0:
								num16 = ((byte[])byte_3)[233];
								goto IL_0537;
							case 25:
								num16 = 12;
								goto IL_0537;
							case 60:
								Class4.smethod_0();
								num5 = ((byte[])byte_3)[106];
								num3 = 30;
								goto case 30;
							case 59:
								num13 = ((byte[])byte_3)[106];
								goto IL_0567;
							case 56:
								num15 = 26;
								goto IL_03b2;
							case 49:
								num12 = 13;
								goto IL_057d;
							case 43:
								num5 = (byte_3 as byte[])[68] - 109;
								num3 = 30;
								goto case 30;
							case 40:
								num11 = (byte_4 as byte[])[193] - 70;
								goto IL_05b0;
							case 37:
								num10 = (byte_3 as byte[])[28] - ((byte[])byte_3)[172];
								goto IL_01ae;
							case 34:
								num14 = 19;
								goto IL_0504;
							case 33:
								num13 = 11;
								goto IL_0567;
							case 31:
								num5 = 21;
								num3 = 30;
								goto IL_0426;
							case 29:
								num8 = 14;
								goto IL_05fa;
							case 24:
								num12 = (byte_4 as byte[])[22];
								goto IL_057d;
							case 22:
								if ((obj as byte[])[num2] >= 116)
								{
									num3 = byte_2[28];
									continue;
								}
								num3 = 10;
								goto case 10;
							case 10:
								num11 = 34;
								goto IL_05b0;
							case 19:
								num7 = 25;
								goto IL_01e5;
							case 18:
								if (208 != (obj as byte[])[num2])
								{
									num3 = 34;
									goto case 34;
								}
								num3 = 63;
								goto case 63;
							case 15:
								num9 = (byte_4 as byte[])[390];
								goto IL_04f7;
							case 12:
								num8 = (int)((byte[])byte_3)[202] / 3;
								goto IL_05fa;
							case 8:
								if (196 != ((byte[])obj)[num2])
								{
									num3 = byte_2[183] + 21;
									continue;
								}
								num3 = 12;
								goto case 12;
							case 2:
								if (239 != ((byte[])obj)[num2])
								{
									num3 = byte_[174] - 34;
									continue;
								}
								num3 = 59;
								goto case 59;
							case 1:
								if (116 != ((byte[])obj)[num2])
								{
									num3 = byte_[90] - 20;
									continue;
								}
								num3 = 65;
								goto case 65;
							default:
								return;
							case 45:
								break;
							case 53:
								return;
							case 64:
								return;
							case 13:
								return;
							case 14:
								return;
							case 55:
								return;
							case 11:
								return;
							case 39:
								return;
							case 26:
								return;
							case 54:
								{
									num2++;
									return;
								}
								IL_01e5:
								num5 = num7;
								num3 = 30;
								goto case 30;
								IL_01b6:
								num3 = 52;
								goto case 52;
								IL_0187:
								num3 = 16;
								goto case 16;
								IL_00fe:
								num5 = num6;
								num3 = 30;
								goto case 30;
								IL_05fa:
								num5 = num8;
								num3 = byte_2[119];
								continue;
								IL_05b0:
								num5 = num11;
								num3 = byte_[87] - 58;
								continue;
								IL_057d:
								num5 = num12;
								num3 = 30;
								goto case 30;
								IL_0567:
								num5 = num13;
								num3 = byte_2[119];
								continue;
								IL_01ae:
								num5 = num10;
								num3 = 30;
								goto case 30;
								IL_0537:
								num5 = num16;
								num3 = 30;
								goto case 30;
								IL_0504:
								num5 = num14;
								goto case 20;
								IL_04f7:
								num5 = num9;
								num3 = 30;
								goto case 30;
								IL_00c5:
								num5 = num17;
								num3 = 30;
								goto case 30;
								IL_083f:
								num3 = 54;
								goto case 54;
								IL_080a:
								num3 = 45;
								break;
								IL_04c1:
								num3 = 4;
								goto case 4;
								IL_04b3:
								num3 = byte_2[93] - 94;
								continue;
								IL_04a8:
								num3 = byte_[25];
								continue;
								IL_049a:
								num3 = byte_[118] - 19;
								continue;
								IL_0489:
								num3 = byte_2[106] - 228;
								continue;
								IL_047b:
								num3 = byte_[16] - 54;
								continue;
								IL_0448:
								num3 = 44;
								goto case 44;
								IL_0437:
								num3 = byte_[144] - 119;
								continue;
								IL_0426:
								num3 = byte_[174] - 54;
								continue;
								IL_0405:
								num3 = 35;
								goto case 35;
								IL_0417:
								num3 = 17;
								goto case 17;
								IL_03f9:
								num3 = (int)byte_[7] / 5;
								continue;
								IL_03ee:
								num3 = 32;
								goto case 32;
								IL_03e0:
								num3 = byte_[106] + 46;
								continue;
								IL_03d0:
								num3 = byte_[35] - byte_[55];
								continue;
								IL_03bf:
								num3 = byte_[37] - 220;
								continue;
								IL_0383:
								num3 = 42;
								goto case 42;
								IL_0109:
								num3 = 38;
								goto case 38;
								IL_03b2:
								num5 = num15;
								num3 = byte_2[119];
								continue;
								IL_036f:
								num3 = byte_2[242] - 209;
								continue;
								IL_032c:
								num3 = 46;
								goto case 46;
								IL_011b:
								num3 = 7;
								goto case 7;
								IL_0360:
								num5 = num18;
								num3 = byte_[85] * 3;
								continue;
								IL_0323:
								num3 = 28;
								goto case 28;
								IL_0301:
								num3 = byte_2[242] - 167;
								continue;
								IL_02ce:
								num3 = 23;
								goto case 23;
								IL_013e:
								num3 = 48;
								goto case 48;
								IL_01ed:
								num3 = 51;
								goto case 51;
								IL_0204:
								num3 = 5;
								goto case 5;
								IL_01bc:
								num3 = 9;
								goto case 9;
							}
							break;
						}
					}
					goto case 2;
				case 2:
					Class9.smethod_5();
					return;
				}
				break;
				IL_0010:
				num2 = 0;
				num = byte_[44] - 112;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_14()
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		while (true)
		{
			Array byte_3 = Class2.byte_0;
			Array byte_4 = Class1.byte_0;
			int num = 33;
			while (true)
			{
				int num2 = 0;
				ICollection collection = (byte[])Class4.smethod_6(Class0.smethod_8(824, 959), Class4.Class5.Class6.smethod_7(1486502125, 0L, 5), 935, '\u038b');
				num = 12;
				while (true)
				{
					int num3 = 31;
					num = byte_2[122];
					while (true)
					{
						int num5;
						int num7;
						int num6;
						int num8;
						int num11;
						int num9;
						int num10;
						int num4;
						switch (num)
						{
						case 80:
							break;
						case 46:
							goto IL_002a;
						case 18:
							goto IL_0050;
						case 3:
							goto IL_0067;
						case 52:
						case 59:
							goto IL_006f;
						case 4:
							goto IL_007f;
						case 8:
							goto IL_0095;
						case 78:
							goto IL_00b0;
						case 40:
							goto IL_00c7;
						case 25:
							goto IL_00e0;
						case 56:
							goto IL_00ff;
						case 13:
							goto IL_011a;
						case 51:
							goto IL_012b;
						case 66:
							goto IL_014d;
						case 58:
							goto IL_016a;
						case 74:
							goto IL_0186;
						case 11:
							goto IL_019b;
						case 10:
							goto IL_01ab;
						case 70:
							goto IL_026f;
						case 60:
							goto IL_02ca;
						case 37:
							goto IL_02cf;
						case 54:
							goto IL_02e1;
						case 22:
							goto IL_02eb;
						case 42:
							goto IL_02fa;
						case 29:
							goto IL_0350;
						case 72:
							goto IL_0384;
						case 6:
							goto IL_03d2;
						case 1:
							goto IL_03fe;
						case 23:
							goto IL_0413;
						case 43:
							goto IL_046f;
						case 69:
							goto IL_0487;
						case 36:
							goto IL_049a;
						case 44:
							goto IL_04d5;
						case 48:
							goto IL_051b;
						case 79:
							smethod_0();
							num3 = 43;
							num = byte_[2] - 221;
							continue;
						case 77:
							num5 = 32;
							goto IL_0563;
						case 76:
							num7 = (byte_4 as byte[])[222] - 60;
							goto IL_057e;
						case 73:
							goto IL_0589;
						case 71:
							num6 = (int)(byte_4 as byte[])[67] / 7;
							goto IL_059b;
						case 65:
							goto IL_05a6;
						case 64:
							num7 = (byte_3 as byte[])[455] - 163;
							goto IL_057e;
						case 62:
							goto IL_05c2;
						case 55:
							goto IL_05da;
						case 50:
							num8 = (byte_4 as byte[])[233] - 1;
							goto IL_05fb;
						case 49:
							num11 = (int)(byte_3 as byte[])[106] / 7;
							goto IL_0612;
						case 30:
						case 47:
							if (((collection as Array) as byte[])[num2] >= 252)
							{
								num = 71;
								goto case 71;
							}
							num = 9;
							goto case 9;
						case 9:
							num6 = 41;
							goto IL_059b;
						case 39:
							goto IL_064d;
						case 38:
							num2++;
							num3 = (byte_3 as byte[])[16];
							num = byte_2[122];
							continue;
						case 35:
							if (116 != ((byte[])(Array)collection)[num2])
							{
								num = byte_[42] - 219;
								continue;
							}
							num = 32;
							goto case 32;
						case 32:
							num9 = 37;
							goto IL_06bc;
						case 34:
							goto IL_06c7;
						case 31:
							num10 = 17;
							goto IL_06f7;
						case 28:
							num2++;
							num3 = (int)(byte_3 as byte[])[342] / 6;
							num = byte_[85];
							continue;
						case 27:
							num11 = 42;
							goto IL_0612;
						case 26:
							num10 = (byte_3 as byte[])[76] - 214;
							goto IL_06f7;
						case 21:
							num9 = 16;
							goto IL_06bc;
						case 20:
							Class4.Class5.Class6.smethod_1();
							goto IL_03d2;
						case 19:
							num8 = 1;
							goto IL_05fb;
						case 16:
							num4 = ((byte[])byte_4)[233] + 15;
							goto IL_0762;
						case 15:
							if (145 != ((byte[])(collection as Array))[num2])
							{
								num = 49;
								goto case 49;
							}
							num = byte_2[3];
							continue;
						case 14:
							num5 = ((byte[])byte_3)[240] - 95;
							goto IL_0563;
						case 7:
							num4 = ((byte[])byte_4)[103] - 34;
							goto IL_0762;
						case 5:
							goto IL_07b5;
						default:
							num = byte_[9];
							continue;
						case 12:
							goto end_IL_07cd;
						case 63:
							goto IL_0936;
						case 33:
							goto end_IL_091d;
						case 24:
							goto end_IL_0941;
						case 2:
							Class4.Class5.Class6.smethod_1();
							goto IL_09aa;
						case 53:
							return null;
						case 68:
							return null;
						case 41:
							goto IL_09a4;
						case 61:
							goto IL_09aa;
						case 67:
							goto IL_09b4;
						case 57:
							goto IL_09df;
						case 75:
							goto IL_09eb;
						case 17:
							goto IL_09f1;
						case 45:
							goto IL_09f7;
							IL_059b:
							num3 = num6;
							num = 10;
							goto IL_01ab;
							IL_0762:
							num3 = num4;
							num = 10;
							goto IL_01ab;
							IL_06f7:
							num3 = num10;
							num = 10;
							goto IL_01ab;
							IL_057e:
							num3 = num7;
							num = 10;
							goto IL_01ab;
							IL_06bc:
							num3 = num9;
							num = 10;
							goto IL_01ab;
							IL_0563:
							num3 = num5;
							num = 10;
							goto IL_01ab;
							IL_0612:
							num3 = num11;
							num = byte_2[222] - 23;
							continue;
							IL_05fb:
							num3 = num8;
							num = 10;
							goto IL_01ab;
						}
						goto IL_0011;
						IL_07b5:
						int num12 = (byte_3 as byte[])[207];
						goto IL_00f0;
						IL_06c7:
						num = ((((byte[])(Array)collection)[num2] < 145) ? ((int)byte_[2] / 3) : (byte_[111] - 46));
						continue;
						IL_011a:
						int num13 = 20;
						goto IL_011c;
						IL_011c:
						num3 = num13;
						num = 10;
						goto IL_01ab;
						IL_064d:
						num = ((196 == ((byte[])(Array)collection)[num2]) ? byte_2[19] : (byte_2[4] - 88));
						continue;
						IL_0026:
						num = 46;
						goto IL_002a;
						IL_00c3:
						num = 40;
						goto IL_00c7;
						IL_05da:
						num13 = ((byte[])byte_3)[435];
						goto IL_011c;
						IL_05c2:
						int num14 = (byte_4 as byte[])[164] - 168;
						goto IL_0415;
						IL_05a6:
						int num15 = 23;
						goto IL_00a1;
						IL_0589:
						int num16 = 7;
						goto IL_017a;
						IL_0011:
						int num17 = (byte_3 as byte[])[124];
						goto IL_001b;
						IL_001b:
						num3 = num17;
						num = 10;
						goto IL_01ab;
						IL_01ab:
						switch (num3)
						{
						case 42:
							break;
						case 38:
							goto IL_004c;
						case 31:
							goto IL_007c;
						case 28:
							goto IL_00ac;
						case 23:
							goto IL_00c3;
						case 18:
							goto IL_00fb;
						case 9:
							goto IL_0127;
						case 1:
							goto IL_0149;
						case 36:
							goto IL_0182;
						case 0:
							goto IL_026b;
						case 2:
							goto IL_02ac;
						case 6:
							goto IL_02b9;
						case 7:
							goto IL_02c6;
						case 10:
							goto IL_02dd;
						case 12:
							goto IL_02f6;
						case 13:
							goto IL_0330;
						case 14:
							goto IL_033b;
						case 15:
							goto IL_034c;
						case 16:
							goto IL_0380;
						case 17:
							goto IL_038e;
						case 19:
							goto IL_03ad;
						case 20:
							goto IL_03be;
						case 22:
							goto IL_03cf;
						case 24:
							goto IL_03fb;
						case 25:
							goto IL_0433;
						case 26:
							goto IL_0444;
						case 27:
							goto IL_0458;
						case 29:
							goto IL_046b;
						case 33:
							goto IL_04b8;
						case 35:
							goto IL_04c3;
						case 37:
							goto IL_04d1;
						case 39:
							goto IL_04e7;
						case 40:
							goto IL_04f5;
						case 41:
							goto IL_0503;
						case 43:
							goto IL_0517;
						case 44:
							goto IL_0539;
						default:
							goto IL_092c;
						case 21:
							goto IL_0932;
						case 5:
							goto IL_093d;
						case 3:
							goto IL_09a0;
						case 4:
							goto IL_09a6;
						case 8:
							goto IL_09b0;
						case 11:
							goto IL_09db;
						case 30:
							goto IL_09e7;
						case 32:
							goto IL_09ed;
						case 34:
							goto IL_09f3;
						}
						goto IL_0026;
						IL_09f3:
						num = 45;
						goto IL_09f7;
						IL_09f7:
						return null;
						IL_09ed:
						num = 17;
						goto IL_09f1;
						IL_09f1:
						return null;
						IL_09e7:
						num = 75;
						goto IL_09eb;
						IL_09eb:
						return null;
						IL_09db:
						num = 57;
						goto IL_09df;
						IL_09df:
						Class9.Class11.smethod_2();
						return null;
						IL_09b0:
						num = 67;
						goto IL_09b4;
						IL_09b4:
						Class2.byte_1[194] = (byte)(Class2.byte_1[194] & Class2.byte_1[74] & 0xAC);
						return null;
						IL_09a6:
						num = 61;
						goto IL_09aa;
						IL_09aa:
						num2++;
						return null;
						IL_09a0:
						num = 41;
						goto IL_09a4;
						IL_09a4:
						return null;
						IL_0932:
						num = 63;
						goto IL_0936;
						IL_092c:
						num = 63;
						goto IL_0936;
						IL_0936:
						num3 = 5;
						num = 10;
						goto IL_093d;
						IL_093d:
						num = 33;
						goto end_IL_091d;
						IL_0539:
						num = byte_2[134];
						continue;
						IL_0517:
						num = 48;
						goto IL_051b;
						IL_051b:
						num2++;
						num3 = (byte_4 as byte[])[126] - 51;
						num = byte_[85];
						continue;
						IL_0503:
						num = byte_[175] - 129;
						continue;
						IL_04f5:
						num = byte_[26] - 85;
						continue;
						IL_04e7:
						num = byte_2[113] - 42;
						continue;
						IL_04d1:
						num = 44;
						goto IL_04d5;
						IL_04c3:
						num = byte_[102] - 18;
						continue;
						IL_04b8:
						num = byte_2[75];
						continue;
						IL_046b:
						num = 43;
						goto IL_046f;
						IL_046f:
						if (((byte[])(Array)collection)[num2] >= 208)
						{
							num = 69;
							goto IL_0487;
						}
						num = 36;
						goto IL_049a;
						IL_00c7:
						if (8 == (((Array)collection) as byte[])[num2])
						{
							num = 25;
							goto IL_00e0;
						}
						num = byte_2[113] - 65;
						continue;
						IL_0487:
						int num18 = ((byte[])byte_4)[40] - 48;
						goto IL_049b;
						IL_0067:
						int num19 = 33;
						goto IL_0071;
						IL_049a:
						num18 = 3;
						goto IL_049b;
						IL_049b:
						num3 = num18;
						num = byte_2[122];
						continue;
						IL_0458:
						num = byte_2[91] - byte_2[215];
						continue;
						IL_0444:
						num = byte_[129] - 183;
						continue;
						IL_0433:
						num = byte_2[200] - 19;
						continue;
						IL_03fb:
						num = 1;
						goto IL_03fe;
						IL_03fe:
						if ((((Array)collection) as byte[])[num2] >= 116)
						{
							num = 23;
							goto IL_0413;
						}
						num = byte_2[273] - 38;
						continue;
						IL_002a:
						num2++;
						num3 = (byte_3 as byte[])[162] - 155;
						num = 10;
						goto IL_01ab;
						IL_0413:
						num14 = 44;
						goto IL_0415;
						IL_0415:
						num3 = num14;
						num = byte_2[122];
						continue;
						IL_00e0:
						num12 = ((byte[])byte_4)[23] - 168;
						goto IL_00f0;
						IL_03cf:
						num = 6;
						goto IL_03d2;
						IL_03d2:
						num2++;
						num3 = ((byte[])byte_4)[96];
						num = byte_[85];
						continue;
						IL_03be:
						num = byte_[107] - 235;
						continue;
						IL_03ad:
						num = byte_2[16] - 157;
						continue;
						IL_038e:
						num = byte_[67] - 70;
						continue;
						IL_0380:
						num = 72;
						goto IL_0384;
						IL_0384:
						smethod_4();
						goto IL_04d5;
						IL_04d5:
						num2++;
						num3 = 2;
						num = byte_[85];
						continue;
						IL_034c:
						num = 29;
						goto IL_0350;
						IL_0350:
						num = (((((Array)collection) as byte[])[num2] < 239) ? (byte_[110] - 64) : byte_2[139]);
						continue;
						IL_00f0:
						num3 = num12;
						num = 10;
						goto IL_01ab;
						IL_00ac:
						num = 78;
						goto IL_00b0;
						IL_033b:
						num = byte_2[190] - 55;
						continue;
						IL_02f6:
						num = 42;
						goto IL_02fa;
						IL_02fa:
						num = ((((collection as Array) as byte[])[num2] < 196) ? (byte_2[196] - 73) : (byte_2[34] - 164));
						continue;
						IL_00b0:
						smethod_2();
						num3 = 42;
						num = 10;
						goto IL_0026;
						IL_007c:
						num = 4;
						goto IL_007f;
						IL_02dd:
						num = 54;
						goto IL_02e1;
						IL_02e1:
						smethod_0();
						num3 = 17;
						goto IL_02eb;
						IL_02eb:
						num = byte_2[122];
						continue;
						IL_02c6:
						num = 60;
						goto IL_02ca;
						IL_02ca:
						Class4.smethod_1();
						goto IL_02cf;
						IL_02cf:
						num2++;
						num3 = 13;
						num = 10;
						goto IL_0330;
						IL_0330:
						num = byte_2[116];
						continue;
						IL_02b9:
						num = (int)byte_2[93] / 2;
						continue;
						IL_02ac:
						num = (int)byte_[18] / 6;
						continue;
						IL_026b:
						num = 70;
						goto IL_026f;
						IL_026f:
						num = ((65 == ((byte[])(collection as Array))[num2]) ? (byte_[45] - 32) : (byte_2[172] - 1));
						continue;
						IL_007f:
						if (((collection as Array) as byte[])[num2] < 8)
						{
							num = 8;
							goto IL_0095;
						}
						num = byte_2[184] - 1;
						continue;
						IL_006f:
						num19 = 22;
						goto IL_0071;
						IL_0182:
						num = 74;
						goto IL_0186;
						IL_0186:
						if (((collection as Array) as byte[])[num2] < 65)
						{
							num = 11;
							goto IL_019b;
						}
						num = 80;
						goto IL_0011;
						IL_0095:
						num15 = (int)((byte[])byte_3)[85] / 8;
						goto IL_00a1;
						IL_019b:
						num17 = 30;
						goto IL_001b;
						IL_00a1:
						num3 = num15;
						num = 10;
						goto IL_01ab;
						IL_0149:
						num = 66;
						goto IL_014d;
						IL_014d:
						if (239 == ((byte[])(collection as Array))[num2])
						{
							num = 58;
							goto IL_016a;
						}
						num = byte_2[31] + 42;
						continue;
						IL_0071:
						num3 = num19;
						num = 10;
						goto IL_01ab;
						IL_004c:
						num = 18;
						goto IL_0050;
						IL_016a:
						num16 = ((byte[])byte_4)[107] - 183;
						goto IL_017a;
						IL_017a:
						num3 = num16;
						num = 10;
						goto IL_01ab;
						IL_0127:
						num = 51;
						goto IL_012b;
						IL_012b:
						Class0.smethod_1();
						num3 = (byte_3 as byte[])[385] - 20;
						num = 10;
						goto IL_01ab;
						IL_00fb:
						num = 56;
						goto IL_00ff;
						IL_00ff:
						if (252 != ((byte[])(collection as Array))[num2])
						{
							num = 13;
							goto IL_011a;
						}
						num = byte_2[71] - 135;
						continue;
						IL_0050:
						if (208 != (((Array)collection) as byte[])[num2])
						{
							num = 3;
							goto IL_0067;
						}
						num = 52;
						goto IL_006f;
						continue;
						end_IL_07cd:
						break;
					}
					continue;
					end_IL_091d:
					break;
				}
				continue;
				end_IL_0941:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_15(short short_0, char char_0)
	{
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		int num2 = default(int);
		int num4 = default(int);
		object obj = default(object);
		while (true)
		{
			Array byte_3 = Class2.byte_0;
			Array byte_4 = Class1.byte_0;
			int num = byte_[124] - 54;
			while (true)
			{
				int num5;
				int num6;
				switch (num)
				{
				case 19:
				{
					int num3 = num2;
					Class2.byte_1[115] = (byte)((Class2.byte_1[115] | short_0) & 0x23);
					num2 = num3 + 1;
					Class1.byte_0[95] = (byte)((Class1.byte_0[95] ^ Class1.byte_0[143]) & 0x53);
					num = byte_2[145] - 222;
					continue;
				}
				case 9:
				case 16:
					num4 = ((byte[])byte_3)[333] - 134;
					num = 18;
					goto case 18;
				case 18:
					switch (num4)
					{
					case 4:
						break;
					default:
						goto IL_007a;
					case 2:
						goto IL_00b3;
					case 3:
						goto IL_00c3;
					case 0:
						goto IL_00ce;
					case 5:
						goto IL_00de;
					case 6:
						goto IL_00f0;
					case 7:
						goto IL_0103;
					case 8:
						goto IL_0113;
					case 9:
						goto IL_0120;
					case 10:
						goto IL_012d;
					case 1:
						goto IL_0290;
					}
					num = 16;
					goto case 9;
				case 17:
					num2 = 0;
					goto case 0;
				case 0:
				case 12:
					num4 = 0;
					num = 18;
					goto IL_00ce;
				case 6:
					num4 = 9;
					num = byte_[31] - 13;
					continue;
				case 15:
					num5 = (byte_4 as byte[])[93] - 167;
					goto IL_014d;
				case 11:
					num6 = (byte_4 as byte[])[179] - ((byte[])byte_4)[179];
					goto IL_0179;
				case 10:
					obj = Class9.Class11.smethod_16(600, 587);
					num4 = ((byte[])byte_4)[67] - 117;
					num = 18;
					goto case 18;
				case 8:
					num6 = ((byte[])byte_3)[54] - 91;
					goto IL_0179;
				case 7:
					num5 = ((byte[])byte_3)[94];
					goto IL_014d;
				case 5:
					num5 = 6;
					goto IL_014d;
				case 4:
					obj = null;
					num4 = 9;
					num = byte_[238] - 52;
					continue;
				case 3:
					switch (((short_0 ^ char_0) - 97) ^ num2)
					{
					case 0:
						goto IL_01ff;
					case 1:
						goto IL_0207;
					}
					num = 7;
					goto case 7;
				case 1:
					obj = Class9.Class11.smethod_16(78, 93);
					num = 6;
					goto case 6;
				default:
					num = 14;
					break;
				case 14:
					break;
				case 13:
					{
						Assembly result = (Assembly)(_Assembly)obj;
						Class9.Class11.smethod_10();
						return result;
					}
					IL_0207:
					num = byte_2[7];
					continue;
					IL_01ff:
					num = 15;
					goto case 15;
					IL_0179:
					num4 = num6;
					num = byte_2[72] - 160;
					continue;
					IL_014d:
					num4 = num5;
					num = byte_2[20] - 204;
					continue;
					IL_0290:
					num = 13;
					goto case 13;
					IL_012d:
					num = byte_2[73] - 173;
					continue;
					IL_0120:
					num = byte_[139];
					continue;
					IL_0113:
					num = byte_2[102] - 53;
					continue;
					IL_0103:
					num = byte_[321] - 109;
					continue;
					IL_00f0:
					num = byte_2[156] - 238;
					continue;
					IL_00de:
					num = 6;
					goto case 6;
					IL_00c3:
					num = 17;
					goto case 17;
					IL_00ce:
					num = byte_2[47] - 173;
					continue;
					IL_00b3:
					num = byte_2[37] - 218;
					continue;
					IL_007a:
					num = 16;
					goto case 9;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Stream smethod_16(PackagePart packagePart_0, char char_0, short short_0)
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		int num4 = default(int);
		int num5 = default(int);
		object obj = default(object);
		int num2 = default(int);
		while (true)
		{
			Array byte_3 = Class2.byte_0;
			object byte_4 = Class1.byte_0;
			int num = byte_[85];
			while (true)
			{
				int num3;
				switch (num)
				{
				case 15:
					switch (num4)
					{
					case 1:
						goto IL_0041;
					case 0:
						goto IL_004a;
					case 2:
						goto IL_0063;
					case 3:
						goto IL_008d;
					case 5:
						goto IL_009c;
					case 6:
						goto IL_00d1;
					case 7:
						goto IL_00e3;
					case 8:
						goto IL_00f0;
					case 4:
						goto IL_018c;
					}
					num = 12;
					goto case 12;
				case 12:
					num4 = 0;
					num = 15;
					goto IL_004a;
				case 10:
					num5 = 0;
					num4 = 7;
					num = byte_2[284] - 83;
					continue;
				case 11:
					obj = Class9.Class10.smethod_9(packagePart_0, 284, 371);
					num5++;
					num = byte_[18] - byte_[81];
					continue;
				case 13:
					if (3725 <= 745 - num2 * 5)
					{
						num = byte_[7];
						continue;
					}
					num = 9;
					goto case 9;
				case 9:
				case 14:
					num3 = ((byte[])byte_4)[144];
					goto IL_00c5;
				case 1:
					num4 = 7;
					goto case 0;
				case 0:
					num = byte_2[184] - 51;
					continue;
				case 8:
					num4 = (byte_3 as byte[])[168] - 51;
					num = byte_2[207] - 174;
					continue;
				case 5:
					num3 = 6;
					goto IL_00c5;
				case 3:
					num2 = 471;
					num = byte_[85] - 2;
					continue;
				default:
					num = 4;
					break;
				case 4:
					break;
				case 6:
					{
						Stream result = (obj as MarshalByRefObject) as Stream;
						Class8.smethod_4();
						return result;
					}
					IL_018c:
					num = 6;
					goto case 6;
					IL_00f0:
					num = byte_[73] - 163;
					continue;
					IL_00e3:
					num = byte_[60] - 211;
					continue;
					IL_00d1:
					num = 1;
					goto case 1;
					IL_009c:
					num = 13;
					goto case 13;
					IL_004a:
					num = 10;
					goto case 10;
					IL_00c5:
					num4 = num3;
					num = byte_[55] - 92;
					continue;
					IL_008d:
					num = byte_2[165] * 2;
					continue;
					IL_0063:
					num = 11;
					goto case 11;
					IL_0041:
					num = 12;
					goto case 12;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_17(byte[] byte_0, int int_0, int int_1)
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		int num5 = default(int);
		int num6 = default(int);
		object obj = default(object);
		while (true)
		{
			Array byte_3 = Class2.byte_0;
			while (true)
			{
				int num = 7;
				while (true)
				{
					int num2 = 0;
					int num3 = 1;
					num = byte_2[105] - 200;
					while (true)
					{
						int num4;
						switch (num)
						{
						case 15:
							break;
						case 13:
							num5 = 636;
							num = 10;
							goto case 10;
						case 10:
							if (5088 <= num5 - num6 * 8)
							{
								num = 9;
								goto case 9;
							}
							num = byte_[27] - 236;
							continue;
						case 9:
							num4 = 4;
							goto IL_003e;
						case 12:
							num = 1;
							goto IL_0057;
						case 0:
						case 5:
							goto IL_0048;
						case 1:
							goto IL_0057;
						case 11:
							goto IL_0090;
						case 3:
							goto IL_00ab;
						case 2:
							num4 = 0;
							goto IL_003e;
						case 7:
							goto end_IL_011a;
						case 4:
							goto end_IL_0163;
						default:
							num = 14;
							goto end_IL_0177;
						case 14:
							goto end_IL_0177;
						case 8:
							goto IL_018c;
							IL_003e:
							num3 = num4;
							goto case 12;
						}
						goto IL_0011;
						IL_0057:
						switch (num3)
						{
						case 2:
							break;
						default:
							goto IL_0082;
						case 1:
							goto IL_008c;
						case 3:
							goto IL_00cb;
						case 4:
							goto IL_00d8;
						case 5:
							goto IL_00e1;
						case 6:
							goto IL_00e9;
						case 7:
							goto IL_00f1;
						case 8:
							goto IL_00fb;
						case 0:
							goto IL_0189;
						}
						num = 5;
						goto IL_0048;
						IL_0189:
						num = 8;
						goto IL_018c;
						IL_018c:
						Assembly result = (obj as ISerializable) as Assembly;
						Class9.smethod_9();
						return result;
						IL_00fb:
						num = byte_2[75] - 13;
						continue;
						IL_00f1:
						num = byte_[1] - 121;
						continue;
						IL_00e9:
						num = byte_2[13];
						continue;
						IL_00e1:
						num = byte_[85];
						continue;
						IL_00d8:
						num = 15;
						goto IL_0011;
						IL_00cb:
						num = byte_[14] - byte_[21];
						continue;
						IL_008c:
						num = 11;
						goto IL_0090;
						IL_0090:
						obj = Class8.smethod_12(byte_0, 900, 966);
						num2++;
						num = 3;
						goto IL_00ab;
						IL_00ab:
						num6 = 423;
						num3 = ((byte[])byte_3)[22];
						num = byte_[208] - 82;
						continue;
						IL_0082:
						num = byte_[7];
						continue;
						IL_0011:
						num3 = 1;
						num = byte_[7] - 4;
						continue;
						IL_0048:
						num3 = (byte_3 as byte[])[94];
						num = 1;
						goto IL_0057;
						continue;
						end_IL_011a:
						break;
					}
					continue;
					end_IL_0163:
					break;
				}
				continue;
				end_IL_0177:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_18(Type type_0, char char_0, int int_0)
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		int num4 = default(int);
		while (true)
		{
			object byte_3 = Class2.byte_0;
			int num = 0;
			while (true)
			{
				int num2 = 0;
				int num3 = 2;
				num = 9;
				while (true)
				{
					IL_0132:
					num = 1;
					while (true)
					{
						object obj = Class9.Class12.smethod_13(type_0, 270, 312);
						num2++;
						num = byte_[179] - 112;
						while (true)
						{
							int num5;
							switch (num)
							{
							case 13:
								num3 = ((byte[])byte_3)[97] - ((byte[])byte_3)[27];
								num = byte_[66] - 154;
								continue;
							case 11:
								num5 = 4;
								goto IL_0039;
							case 8:
								if (67 >= num4 / 3 - 66)
								{
									num = 11;
									goto case 11;
								}
								num = (int)byte_[106] / 2;
								continue;
							case 9:
								switch (num3)
								{
								case 5:
									break;
								default:
									goto IL_007a;
								case 3:
									goto IL_0080;
								case 6:
									goto IL_0095;
								case 7:
									goto IL_009e;
								case 2:
									goto IL_0132;
								case 0:
									goto IL_0137;
								case 1:
									goto IL_0150;
								case 4:
									goto IL_0155;
								}
								num = 8;
								goto case 8;
							default:
								num = byte_[129] - 227;
								continue;
							case 7:
								num5 = 2;
								goto IL_0039;
							case 6:
								num4 = 201;
								num3 = 3;
								goto case 5;
							case 5:
								num = 9;
								goto case 9;
							case 1:
								break;
							case 0:
							case 12:
								goto end_IL_010e;
							case 2:
								goto end_IL_013a;
							case 3:
							case 4:
								{
									Assembly result = (Assembly)((obj is IEvidenceFactory) ? obj : null);
									Class9.Class11.smethod_3();
									return result;
								}
								IL_0039:
								num3 = num5;
								num = 9;
								goto case 9;
								IL_0155:
								num = 4;
								goto case 3;
								IL_0150:
								num = 4;
								goto case 3;
								IL_0137:
								num = 0;
								goto end_IL_010e;
								IL_009e:
								num = 13;
								goto case 13;
								IL_0095:
								num = 13;
								goto case 13;
								IL_0080:
								num = byte_2[75] - 12;
								continue;
								IL_007a:
								num = 13;
								goto case 13;
							}
							break;
						}
						continue;
						end_IL_010e:
						break;
					}
					break;
				}
				continue;
				end_IL_013a:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Package smethod_19(Stream stream_0, FileMode fileMode_0, FileAccess fileAccess_0, short short_0, int int_0)
	{
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		int num4 = default(int);
		object obj = default(object);
		while (true)
		{
			object byte_3 = Class1.byte_0;
			object byte_4 = Class2.byte_0;
			int num = 1;
			while (true)
			{
				int num2 = 0;
				int num3 = 3;
				while (true)
				{
					num = 12;
					while (true)
					{
						Package val;
						int num5;
						int num6;
						switch (num3)
						{
						case 8:
							num = 6;
							goto IL_0014;
						case 7:
							num = 11;
							goto IL_007e;
						case 6:
							num = byte_[132] - 59;
							goto IL_00e3;
						case 5:
							num = 15;
							goto IL_0036;
						case 4:
							num = (int)byte_[106] / 7;
							goto IL_00e3;
						case 3:
							num = 10;
							goto IL_00a1;
						case 2:
							num = byte_2[19] - 8;
							goto IL_00e3;
						case 0:
							num = byte_2[164] - byte_2[159];
							goto IL_00e3;
						default:
							num = 11;
							goto IL_007e;
						case 1:
							{
								num = 9;
								goto IL_01f7;
							}
							IL_0014:
							num3 = (byte_3 as byte[])[90] - (byte_3 as byte[])[40];
							num = byte_[117];
							goto IL_00e3;
							IL_00e3:
							while (true)
							{
								switch (num)
								{
								case 6:
									break;
								case 3:
								case 15:
									goto IL_0036;
								case 11:
									goto IL_007e;
								case 10:
									goto IL_00a1;
								case 8:
									goto IL_00bb;
								case 0:
									goto IL_00be;
								default:
									num = (int)byte_[9] / 6;
									continue;
								case 2:
									num4 = 200;
									num = byte_2[85] - 14;
									continue;
								case 14:
									goto IL_012c;
								case 5:
									goto IL_0132;
								case 12:
									goto end_IL_01a8;
								case 13:
									goto end_IL_01a6;
								case 1:
									goto end_IL_01d3;
								case 4:
									goto end_IL_01d9;
								case 9:
									goto IL_01f7;
								}
								break;
							}
							goto IL_0014;
							IL_01f7:
							val = (Package)obj;
							Class9.Class12.smethod_1();
							return val;
							IL_012c:
							num5 = 1;
							goto IL_013c;
							IL_00a1:
							obj = Class9.Class10.smethod_10(stream_0, fileMode_0, fileAccess_0, 273, 282);
							num2++;
							num = 8;
							goto IL_00bb;
							IL_00bb:
							num3 = 4;
							goto IL_00be;
							IL_00be:
							num = byte_2[192];
							goto IL_00e3;
							IL_007e:
							num3 = (byte_3 as byte[])[214] - 48;
							num = byte_2[201] - 140;
							goto IL_00e3;
							IL_0036:
							num6 = num4;
							Class1.byte_1[247] = (byte)(Class1.byte_1[247] & Class2.byte_1[194] & 0x5D);
							if (4383 > 487 - num6 * 9)
							{
								num = byte_2[17] - 179;
								goto IL_00e3;
							}
							num = 5;
							goto IL_0132;
							IL_0132:
							num5 = (byte_4 as byte[])[94];
							goto IL_013c;
							IL_013c:
							num3 = num5;
							num = 12;
							break;
							end_IL_01a8:
							break;
						}
						continue;
						end_IL_01a6:
						break;
					}
					continue;
					end_IL_01d3:
					break;
				}
				continue;
				end_IL_01d9:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static MethodInfo smethod_20(Assembly assembly_0, int int_0, int int_1)
	{
		byte[] byte_ = Class1.byte_1;
		byte[] byte_2 = Class2.byte_1;
		object obj = default(object);
		int num4 = default(int);
		while (true)
		{
			object byte_3 = Class1.byte_0;
			Array byte_4 = Class2.byte_0;
			int num = 5;
			while (true)
			{
				int num2 = 0;
				int num3 = ((byte[])byte_3)[24] - ((byte[])byte_3)[42];
				num = 2;
				while (true)
				{
					MethodInfo result;
					int num5;
					int num6;
					int num7;
					switch (num3)
					{
					case 6:
						num = 6;
						goto IL_0013;
					case 5:
						num = byte_2[7];
						goto IL_008f;
					case 4:
						num = 3;
						goto IL_006e;
					case 3:
						num = 4;
						goto IL_0063;
					case 2:
						num = byte_2[146] - 175;
						goto IL_008f;
					case 1:
						num = byte_2[106];
						goto IL_008f;
					case 0:
						num = 8;
						goto IL_0036;
					default:
						num = byte_[165];
						goto IL_008f;
					case 7:
						{
							num = 1;
							goto IL_0161;
						}
						IL_0013:
						obj = Class9.Class11.smethod_17(assembly_0, '\u02db', 657);
						num = 14;
						goto IL_0027;
						IL_0027:
						num2++;
						num4 = 953;
						num = 8;
						goto IL_0036;
						IL_0036:
						num3 = 4;
						num = (int)byte_[192] / 6;
						goto IL_008f;
						IL_008f:
						switch (num)
						{
						case 6:
						case 9:
							break;
						case 14:
							goto IL_0027;
						case 8:
							goto IL_0036;
						case 12:
							goto IL_0045;
						case 7:
							goto IL_0055;
						case 4:
							goto IL_0063;
						case 3:
							goto IL_006e;
						case 2:
						case 10:
							goto end_IL_0105;
						case 5:
							goto end_IL_0103;
						default:
							num = 11;
							goto end_IL_012c;
						case 11:
							goto end_IL_012c;
						case 1:
						case 13:
							goto IL_0161;
						}
						goto IL_0013;
						IL_0161:
						result = ((obj is _MethodInfo) ? obj : null) as MethodInfo;
						Class9.smethod_11();
						return result;
						IL_006e:
						num5 = num4;
						num6 = num5 * num5;
						num6 = num4 + num6;
						if (num6 % 2 == 0)
						{
							num = byte_[192];
							goto IL_008f;
						}
						num = 7;
						goto IL_0055;
						IL_0045:
						num7 = 2;
						goto IL_0046;
						IL_0046:
						num3 = num7;
						num = byte_[16] - 192;
						goto IL_008f;
						IL_0063:
						num3 = 5;
						num = 2;
						goto case 5;
						IL_0055:
						num7 = (byte_4 as byte[])[8] - 25;
						goto IL_0046;
						end_IL_0105:
						break;
					}
					continue;
					end_IL_0103:
					break;
				}
				continue;
				end_IL_012c:
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_21(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, short short_0)
	{
		byte[] byte_ = Class2.byte_1;
		byte[] byte_2 = Class1.byte_1;
		int num2 = default(int);
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			Array byte_3 = Class2.byte_0;
			object byte_4 = Class1.byte_0;
			int num = byte_[21] - 229;
			while (true)
			{
				int num4;
				switch (num)
				{
				case 14:
					num4 = 0;
					goto IL_0012;
				case 4:
					num2 = 0;
					num3 = (byte_3 as byte[])[135];
					num = 8;
					goto case 2;
				case 2:
				case 8:
					switch (num3)
					{
					case 7:
						break;
					case 4:
						goto IL_0061;
					default:
						goto IL_006a;
					case 0:
						goto IL_0076;
					case 1:
						goto IL_0086;
					case 2:
						goto IL_0099;
					case 3:
						goto IL_00a0;
					case 5:
						goto IL_00af;
					case 6:
						goto IL_00d3;
					case 8:
						goto IL_00e5;
					}
					goto IL_0020;
				case 11:
				case 13:
					num3 = 7;
					num = 8;
					goto IL_0020;
				case 5:
					num = 7;
					goto case 7;
				case 7:
					num4 = (byte_4 as byte[])[33];
					goto IL_0012;
				case 12:
					obj = Class9.Class12.smethod_14(methodBase_0, object_0, object_1, 1010, 926);
					num = byte_2[78] - 228;
					continue;
				case 9:
					num3 = 5;
					num = byte_[101] - 57;
					continue;
				default:
					num = byte_[72] - 172;
					continue;
				case 0:
					num2++;
					num3 = 1;
					num = 8;
					goto IL_0086;
				case 6:
					break;
				case 1:
				case 10:
					{
						object result = obj;
						Class9.Class11.smethod_2();
						return result;
					}
					IL_00e5:
					num = byte_2[290] - 205;
					continue;
					IL_00d3:
					num = byte_[164] - byte_[164];
					continue;
					IL_00af:
					num = 12;
					goto case 12;
					IL_00a0:
					num = byte_[75] - byte_[133];
					continue;
					IL_0099:
					num = byte_[85];
					continue;
					IL_0086:
					num = 5;
					goto case 5;
					IL_0076:
					num = byte_2[203] - 58;
					continue;
					IL_006a:
					num = (int)byte_[101] / 5;
					continue;
					IL_0061:
					num = 13;
					goto case 11;
					IL_0020:
					num = 4;
					goto case 4;
					IL_0012:
					num3 = num4;
					num = byte_[9] - 16;
					continue;
				}
				break;
			}
		}
	}
}
