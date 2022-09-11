using System;

internal sealed class Class50
{
	private sealed class Class51
	{
		internal static int[] smethod_0(int[] int_0, int int_1)
		{
			int[] array = new int[int_0.Length];
			int num2 = default(int);
			int[] array2 = default(int[]);
			int num4 = default(int);
			int num6 = default(int);
			while (true)
			{
				int num = Class55.smethod_1(67);
				while (true)
				{
					int[] array3;
					int[] array4;
					int[] array5;
					switch (num)
					{
					case 4:
						num2++;
						goto IL_0011;
					case 1:
						goto IL_0018;
					case 3:
						if (num2 != 0)
						{
							num = 1;
							goto IL_0018;
						}
						goto IL_0011;
					case 2:
						array2 = new int[int_0.Length];
						num = 0;
						goto case 0;
					case 0:
						{
							num2 = 0;
							num = 3;
							goto case 3;
						}
						IL_0011:
						if (num2 < array.Length)
						{
							goto IL_0018;
						}
						Array.Copy(int_0, array2, int_0.Length);
						while (true)
						{
							switch (Class55.smethod_1(67))
							{
							default:
								continue;
							case 2:
							{
								Array.Sort(array2, array);
								int num3 = 0;
								goto case 0;
							}
							case 0:
							{
								num4 = 0;
								int num3 = 1;
								goto case 1;
							}
							case 1:
							{
								if (num4 == 0)
								{
									goto IL_00af;
								}
								int num3 = 3;
								goto case 3;
							}
							case 3:
								{
									num4++;
									goto IL_00af;
								}
								IL_00af:
								if (num4 >= array2.Length || array2[num4] != 0 || 1 == 0)
								{
									break;
								}
								goto case 3;
							}
							break;
						}
						array3 = new int[array2.Length - num4];
						Array.Copy(array2, num4, array3, 0, array3.Length);
						array4 = ((array3.Length == 0 && 0 == 0) ? new int[0] : ((array3.Length != 1) ? smethod_1(array3, int_1) : new int[1] { 1 }));
						array5 = new int[int_0.Length];
						while (true)
						{
							int num5 = Class55.smethod_1(65);
							while (true)
							{
								switch (num5)
								{
								case 3:
									num6++;
									goto IL_0120;
								case 0:
									goto IL_0128;
								case 2:
									if (num6 != 0)
									{
										num5 = 0;
										goto IL_0128;
									}
									goto IL_0120;
								case 1:
									{
										num6 = 0;
										num5 = 2;
										goto case 2;
									}
									IL_0120:
									if (num6 < array4.Length)
									{
										goto IL_0128;
									}
									return array5;
								}
								break;
								IL_0128:
								array5[array[num6 + num4]] = array4[num6];
								num5 = Class55.smethod_1(69);
							}
						}
					}
					break;
					IL_0018:
					array[num2] = num2;
					num = Class55.smethod_1(72);
				}
			}
		}

		private static int[] smethod_1(int[] int_0, int int_1)
		{
			int num = int_0.Length;
			int num3 = default(int);
			int[][] array = default(int[][]);
			int[] array2 = default(int[]);
			int num5 = default(int);
			int num6 = default(int);
			int num8 = default(int);
			while (true)
			{
				int num2 = Class55.smethod_1(72);
				while (true)
				{
					switch (num2)
					{
					case 5:
						if (num3 != 0)
						{
							goto IL_000a;
						}
						goto IL_006a;
					case 4:
						array = new int[int_1][];
						num2 = 2;
						goto case 2;
					case 2:
						array[0] = int_0;
						num2 = 1;
						goto case 1;
					case 1:
						array2 = new int[int_0.Length / 2];
						num2 = 3;
						goto case 3;
					case 3:
						num3 = 0;
						num2 = 5;
						goto case 5;
					case 0:
						array2[num3] = int_0[num3 * 2] + int_0[num3 * 2 + 1];
						num2 = 6;
						goto case 6;
					case 6:
						{
							num3++;
							goto IL_006a;
						}
						IL_006a:
						if (num3 >= array2.Length)
						{
							for (int i = 1; i < int_1; i++)
							{
								int[] array3 = smethod_2(array2, int_0);
								while (true)
								{
									int num4 = Class55.smethod_1(72);
									while (true)
									{
										switch (num4)
										{
										case 4:
											array[i] = array3;
											num4 = 2;
											goto case 2;
										case 2:
											array2 = new int[array3.Length / 2];
											num4 = 3;
											goto case 3;
										case 3:
											num5 = 0;
											num4 = 0;
											goto case 0;
										case 0:
											if (num5 != 0)
											{
												goto IL_00c4;
											}
											goto IL_00f7;
										case 1:
											array2[num5] = array3[num5 * 2] + array3[num5 * 2 + 1];
											num4 = 5;
											goto case 5;
										case 5:
											{
												num5++;
												goto IL_00f7;
											}
											IL_00f7:
											if (num5 >= array2.Length)
											{
												goto end_IL_00ec;
											}
											goto case 1;
										}
										break;
										IL_00c4:
										num4 = Class55.smethod_1(65);
									}
									continue;
									end_IL_00ec:
									break;
								}
							}
							int[] array4 = new int[num];
							while (true)
							{
								switch (Class55.smethod_1(65))
								{
								default:
									continue;
								case 1:
								{
									num6 = num - 1;
									int num7 = 0;
									goto case 0;
								}
								case 0:
								{
									num8 = int_1 - 1;
									int num7 = 2;
									break;
								}
								case 2:
									break;
								}
								break;
							}
							while (num8 >= 0)
							{
								int[] array5 = array[num8];
								int num9 = 0;
								int num10 = 0;
								for (int j = 0; j < num6 * 2; j++)
								{
									if (num10 < int_0.Length && int_0[num10] == array5[j])
									{
										array4[num10]++;
										num10++;
									}
									else
									{
										num9++;
									}
								}
								num6 = num9;
								num8--;
							}
							return array4;
						}
						goto case 0;
					}
					break;
					IL_000a:
					num2 = Class55.smethod_1(60);
				}
			}
		}

		private static int[] smethod_2(int[] int_0, int[] int_1)
		{
			int[] array = new int[int_0.Length + int_1.Length];
			int num3 = default(int);
			int num4 = default(int);
			int num2 = default(int);
			while (true)
			{
				int num = Class55.smethod_1(70);
				while (true)
				{
					switch (num)
					{
					case 1:
						if (int_0[num3] < int_1[num4])
						{
							goto IL_0036;
						}
						array[num2++] = int_1[num4++];
						goto case 6;
					case 6:
						if (num3 >= int_0.Length || num4 >= int_1.Length)
						{
							while (num3 < int_0.Length)
							{
								array[num2++] = int_0[num3++];
							}
							while (num4 < int_1.Length)
							{
								array[num2++] = int_1[num4++];
							}
							return array;
						}
						goto case 1;
					case 5:
						num3 = 0;
						num = 3;
						goto case 3;
					case 3:
						num4 = 0;
						num = 0;
						goto case 0;
					case 0:
						num2 = 0;
						num = 4;
						goto case 4;
					case 4:
						if (num2 != 0)
						{
							num = 1;
							goto case 1;
						}
						goto case 6;
					case 2:
						array[num2++] = int_0[num3++];
						num = 6;
						goto case 6;
					}
					break;
					IL_0036:
					num = Class55.smethod_1(67);
				}
			}
		}
	}

	private struct Struct4
	{
		internal Struct5 struct5_0;

		internal ushort ushort_0;
	}

	internal static Struct5[] struct5_0;

	internal static Struct5[] struct5_1;

	internal static Class54 class54_0;

	internal static readonly int[] int_0;

	internal static readonly int[] int_1;

	internal static readonly int[] int_2;

	internal static readonly int[] int_3;

	internal static readonly int[] int_4;

	static Class50()
	{
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num = Class55.smethod_1(68);
			while (true)
			{
				switch (num)
				{
				case 19:
					int_1[7] = 10;
					while (true)
					{
						int num7 = Class55.smethod_1(67);
						while (true)
						{
							switch (num7)
							{
							case 2:
								int_1[8] = 11;
								num7 = 0;
								goto case 0;
							case 0:
								int_1[9] = 13;
								num7 = 1;
								goto case 1;
							case 1:
								num = Class55.smethod_1(63);
								num7 = Class55.smethod_1(69);
								continue;
							case 3:
								goto end_IL_0053;
							}
							break;
						}
						continue;
						end_IL_0053:
						break;
					}
					continue;
				case 16:
					int_0[15] = 2;
					int_0[16] = 14;
					int_0[17] = 1;
					num = 0;
					goto case 0;
				case 0:
					int_0[18] = 15;
					int_1 = new int[29];
					int_1[0] = 3;
					num = 15;
					goto case 15;
				case 15:
					int_1[1] = 4;
					int_1[2] = 5;
					int_1[3] = 6;
					num = 1;
					goto case 1;
				case 1:
					int_1[4] = 7;
					int_1[5] = 8;
					int_1[6] = 9;
					num = 19;
					goto case 19;
				case 14:
					int_0[6] = 9;
					int_0[7] = 6;
					int_0[8] = 10;
					num = 12;
					goto case 12;
				case 12:
					int_0[9] = 5;
					int_0[10] = 11;
					int_0[11] = 4;
					num = 8;
					goto case 8;
				case 8:
					int_0[12] = 12;
					int_0[13] = 3;
					int_0[14] = 13;
					num = 16;
					goto case 16;
				case 13:
					num = 5;
					goto case 5;
				case 5:
					struct5_0 = new Struct5[288];
					struct5_1 = new Struct5[32];
					num = 7;
					goto case 7;
				case 7:
					int_0 = new int[19];
					int_0[0] = 16;
					int_0[1] = 17;
					num = 3;
					goto case 3;
				case 3:
					int_0[2] = 18;
					int_0[4] = 8;
					int_0[5] = 7;
					num = 14;
					goto case 14;
				case 18:
					int_1[10] = 15;
					int_1[11] = 17;
					int_1[12] = 19;
					num = 11;
					goto case 11;
				case 11:
					int_1[13] = 23;
					int_1[14] = 27;
					int_1[15] = 31;
					num = 17;
					goto case 17;
				case 17:
					int_1[16] = 35;
					int_1[17] = 43;
					int_1[18] = 51;
					num = 10;
					goto case 10;
				case 10:
					int_1[19] = 59;
					int_1[20] = 67;
					int_1[21] = 83;
					num = 2;
					goto case 2;
				case 2:
					int_1[22] = 99;
					int_1[23] = 115;
					int_1[24] = 131;
					num = 6;
					goto case 6;
				case 6:
					int_1[25] = 163;
					int_1[26] = 195;
					int_1[27] = 227;
					num = 4;
					goto case 4;
				case 4:
					int_1[28] = 258;
					int_2 = new int[29];
					num2 = 8;
					num = 9;
					goto case 9;
				case 9:
					num3 = 0;
					goto IL_030d;
				case 20:
					{
						if (true)
						{
							goto IL_0301;
						}
						goto IL_031a;
					}
					IL_030d:
					if (num2 < 28)
					{
						if (num2 % 4 == 0)
						{
							goto IL_031a;
						}
						num = 20;
						goto case 20;
					}
					int_3 = new int[30];
					while (true)
					{
						int num4 = Class55.smethod_1(61);
						while (true)
						{
							switch (num4)
							{
							case 10:
								goto IL_0339;
							case 3:
								int_3[2] = 3;
								int_3[3] = 4;
								num4 = 0;
								goto case 0;
							case 0:
								int_3[4] = 5;
								int_3[5] = 7;
								num4 = 6;
								goto case 6;
							case 6:
								int_3[6] = 9;
								int_3[7] = 13;
								num4 = 15;
								goto case 15;
							case 15:
								int_3[8] = 17;
								int_3[9] = 25;
								num4 = 2;
								goto case 2;
							case 2:
								int_3[10] = 33;
								int_3[11] = 49;
								num4 = 1;
								goto case 1;
							case 1:
								int_3[12] = 65;
								int_3[13] = 97;
								num4 = 9;
								goto case 9;
							case 9:
								int_3[14] = 129;
								int_3[15] = 193;
								num4 = 8;
								goto case 8;
							case 8:
								int_3[16] = 257;
								int_3[17] = 385;
								num4 = 12;
								goto case 12;
							case 12:
								int_3[18] = 513;
								int_3[19] = 769;
								num4 = 13;
								goto case 13;
							case 13:
								int_3[20] = 1025;
								int_3[21] = 1537;
								num4 = 16;
								goto case 16;
							case 16:
								int_3[22] = 2049;
								int_3[23] = 3073;
								num4 = 4;
								goto case 4;
							case 4:
								int_3[24] = 4097;
								int_3[25] = 6145;
								num4 = 7;
								goto case 7;
							case 7:
								int_3[26] = 8193;
								int_3[27] = 12289;
								num4 = 5;
								goto case 5;
							case 5:
								int_3[28] = 16385;
								int_3[29] = 24577;
								num4 = 14;
								goto case 14;
							case 14:
								int_4 = new int[30];
								num5 = 4;
								num4 = 11;
								goto case 11;
							case 11:
								num6 = 0;
								goto IL_0542;
							case 17:
								{
									if (num5 % 2 == 0 && 0 == 0)
									{
										num6++;
									}
									int_4[num5] = num6;
									num5++;
									goto IL_0542;
								}
								IL_0542:
								if (num5 >= 30)
								{
									for (int i = 0; i <= 143; i++)
									{
										struct5_0[i].int_0 = 48 + i;
										struct5_0[i].int_1 = 8;
									}
									for (int j = 144; j <= 255; j++)
									{
										struct5_0[j].int_0 = 400 + j - 144;
										struct5_0[j].int_1 = 9;
									}
									for (int k = 256; k <= 279; k++)
									{
										struct5_0[k].int_0 = k - 256;
										struct5_0[k].int_1 = 7;
									}
									for (int l = 280; l <= 287; l++)
									{
										struct5_0[l].int_0 = 192 + l - 280;
										struct5_0[l].int_1 = 8;
									}
									for (int m = 0; m <= 31; m++)
									{
										struct5_1[m].int_0 = m;
										struct5_1[m].int_1 = 5;
									}
									class54_0 = smethod_4(struct5_0, struct5_1);
									return;
								}
								goto case 17;
							}
							break;
							IL_0339:
							int_3[0] = 1;
							int_3[1] = 2;
							num4 = Class55.smethod_1(69);
						}
					}
					IL_031a:
					num3++;
					goto IL_0301;
					IL_0301:
					int_2[num2] = num3;
					num2++;
					goto IL_030d;
				}
				break;
			}
		}
	}

	internal static int smethod_0(int[] int_5, int[] int_6)
	{
		int num = 0;
		int num3 = default(int);
		while (true)
		{
			int num2 = Class55.smethod_1(67);
			while (true)
			{
				switch (num2)
				{
				case 2:
					goto IL_0004;
				case 1:
					if (num3 == 0)
					{
						goto IL_0039;
					}
					num2 = 0;
					goto case 0;
				case 3:
					num3++;
					goto IL_0039;
				case 0:
					{
						num += int_5[num3] * int_6[num3];
						num2 = 3;
						goto case 3;
					}
					IL_0039:
					if (num3 >= int_5.Length)
					{
						return num;
					}
					goto case 0;
				}
				break;
				IL_0004:
				num3 = 0;
				num2 = Class55.smethod_1(65);
			}
		}
	}

	internal static int smethod_1(int[] int_5, int[] int_6)
	{
		int num = 0;
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = Class55.smethod_1(60);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (num3 != 0)
					{
						goto IL_0007;
					}
					goto IL_0037;
				case 0:
					num3 = 0;
					num2 = 1;
					goto case 1;
				case 2:
					num += int_5[num3] * struct5_0[num3].int_1;
					num2 = 3;
					goto case 3;
				case 3:
					{
						num3++;
						goto IL_0037;
					}
					IL_0037:
					if (num3 >= int_5.Length)
					{
						while (true)
						{
							int num4 = Class55.smethod_1(67);
							while (true)
							{
								switch (num4)
								{
								case 2:
									num5 = 0;
									num4 = 1;
									goto case 1;
								case 1:
									if (num5 != 0)
									{
										goto IL_0064;
									}
									goto IL_008f;
								case 0:
									num += int_6[num5] * struct5_1[num5].int_1;
									num4 = 3;
									goto case 3;
								case 3:
									{
										num5++;
										goto IL_008f;
									}
									IL_008f:
									if (num5 >= int_6.Length)
									{
										return num;
									}
									goto case 0;
								}
								break;
								IL_0064:
								num4 = Class55.smethod_1(60);
							}
						}
					}
					goto case 2;
				}
				break;
				IL_0007:
				num2 = Class55.smethod_1(67);
			}
		}
	}

	internal static Struct5[] smethod_2(int[] int_5)
	{
		Struct5[] array = new Struct5[int_5.Length];
		int num2 = default(int);
		while (true)
		{
			int num = Class55.smethod_1(67);
			while (true)
			{
				switch (num)
				{
				case 3:
					num2++;
					goto IL_000f;
				case 1:
					goto IL_0015;
				case 2:
					num2 = 0;
					num = 0;
					goto case 0;
				case 0:
					{
						if (num2 != 0)
						{
							num = 1;
							goto IL_0015;
						}
						goto IL_000f;
					}
					IL_000f:
					if (num2 < int_5.Length)
					{
						goto IL_0015;
					}
					smethod_3(array);
					return array;
				}
				break;
				IL_0015:
				array[num2].int_1 = int_5[num2];
				num = Class55.smethod_1(69);
			}
		}
	}

	internal static void smethod_3(Struct5[] struct5_2)
	{
		int num = struct5_2[0].int_1;
		int num3 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num2 = Class55.smethod_1(67);
			while (true)
			{
				switch (num2)
				{
				case 2:
					goto IL_000f;
				case 1:
					if (num3 != 0)
					{
						goto IL_005a;
					}
					num2 = 0;
					goto case 0;
				case 3:
					num = struct5_2[num3].int_1;
					goto IL_0054;
				case 0:
					{
						if (num < struct5_2[num3].int_1)
						{
							num2 = 3;
							goto case 3;
						}
						goto IL_0054;
					}
					IL_005a:
					if (num3 >= struct5_2.Length)
					{
						int[] array = new int[num + 1];
						while (true)
						{
							int num4 = Class55.smethod_1(65);
							while (true)
							{
								int[] array2;
								switch (num4)
								{
								case 3:
									num5++;
									goto IL_008b;
								case 2:
									goto IL_0092;
								case 1:
									num5 = 0;
									num4 = 0;
									goto case 0;
								case 0:
									{
										if (num5 != 0)
										{
											num4 = 2;
											goto IL_0092;
										}
										goto IL_008b;
									}
									IL_008b:
									if (num5 < struct5_2.Length)
									{
										goto IL_0092;
									}
									array2 = new int[num + 1];
									while (true)
									{
										int num6 = Class55.smethod_1(69);
										while (true)
										{
											switch (num6)
											{
											case 3:
												goto IL_00f1;
											case 0:
												array[0] = 0;
												num6 = 2;
												goto case 2;
											case 2:
												num7 = 1;
												num6 = 5;
												goto case 5;
											case 5:
												if (num7 != 0)
												{
													goto IL_0146;
												}
												num6 = 1;
												goto case 1;
											case 6:
												num7++;
												goto IL_0146;
											case 4:
												array2[num7] = num8;
												num6 = 6;
												goto case 6;
											case 1:
												{
													num8 = num8 + array[num7 - 1] << 1;
													num6 = 4;
													goto case 4;
												}
												IL_0146:
												if (num7 > num)
												{
													for (int i = 0; i < struct5_2.Length; i++)
													{
														int num9 = struct5_2[i].int_1;
														if (num9 != 0 || 1 == 0)
														{
															struct5_2[i].int_0 = array2[num9];
															array2[num9]++;
														}
													}
													return;
												}
												goto case 1;
											}
											break;
											IL_00f1:
											num8 = 0;
											num6 = Class55.smethod_1(60);
										}
									}
								}
								break;
								IL_0092:
								array[struct5_2[num5].int_1]++;
								num4 = Class55.smethod_1(69);
							}
						}
					}
					goto case 0;
					IL_0054:
					num3++;
					goto IL_005a;
				}
				break;
				IL_000f:
				num3 = 1;
				num2 = Class55.smethod_1(65);
			}
		}
	}

	internal static Class54 smethod_4(Struct5[] struct5_2, Struct5[] struct5_3)
	{
		return new Class54
		{
			class53_0 = smethod_5(struct5_2),
			class53_1 = smethod_5(struct5_3)
		};
	}

	internal static Class53 smethod_5(Struct5[] struct5_2)
	{
		Struct4[] array = new Struct4[struct5_2.Length];
		Struct4 @struct = default(Struct4);
		int num2 = default(int);
		int int_ = default(int);
		while (true)
		{
			int num = Class55.smethod_1(67);
			while (true)
			{
				switch (num)
				{
				case 5:
					while (true)
					{
						switch (Class55.smethod_1(65))
						{
						default:
							continue;
						case 1:
						{
							@struct.struct5_0 = struct5_2[num2];
							int num3 = 0;
							goto case 0;
						}
						case 0:
						{
							@struct.ushort_0 = (ushort)num2;
							int num3 = 2;
							break;
						}
						case 2:
							break;
						}
						break;
					}
					array[int_++] = @struct;
					goto IL_0055;
				case 3:
					if (struct5_2[num2].int_1 > 0)
					{
						goto IL_006e;
					}
					goto IL_0055;
				case 4:
					if (num2 == 0)
					{
						goto IL_0059;
					}
					num = 3;
					goto case 3;
				case 2:
					int_ = 0;
					num = 0;
					goto case 0;
				case 0:
					num2 = 0;
					num = 4;
					goto case 4;
				case 1:
					{
						@struct = default(Struct4);
						num = 5;
						goto case 5;
					}
					IL_0059:
					if (num2 >= struct5_2.Length)
					{
						return smethod_6(array, int_, 0, 0);
					}
					goto case 3;
					IL_0055:
					num2++;
					goto IL_0059;
				}
				break;
				IL_006e:
				num = Class55.smethod_1(65);
			}
		}
	}

	private static Class53 smethod_6(Struct4[] struct4_0, int int_5, int int_6, int int_7)
	{
		Struct4[] array = new Struct4[int_5];
		Struct4[] array2 = default(Struct4[]);
		Class53 @class = default(Class53);
		int num3 = default(int);
		int num4 = default(int);
		int num2 = default(int);
		Struct4 @struct = default(Struct4);
		while (true)
		{
			int num = Class55.smethod_1(81);
			while (true)
			{
				switch (num)
				{
				case 9:
					array2 = new Struct4[int_5];
					num = 7;
					goto case 7;
				case 7:
					@class = new Class53();
					num = 5;
					goto case 5;
				case 5:
					@class.bool_0 = false;
					num = 8;
					goto case 8;
				case 8:
					num3 = 0;
					num4 = 0;
					num = 1;
					goto IL_002e;
				case 1:
					goto IL_002e;
				case 2:
					if (num2 == 0)
					{
						goto IL_008f;
					}
					num = 10;
					goto case 10;
				case 11:
					num2++;
					goto IL_008f;
				case 4:
					if (@struct.struct5_0.int_1 == int_7)
					{
						num = 3;
						goto case 3;
					}
					goto IL_00dd;
				case 3:
					if (@struct.struct5_0.int_0 == int_6)
					{
						num = 6;
						goto case 6;
					}
					goto IL_00dd;
				case 6:
					@class.bool_0 = true;
					num = 0;
					goto case 0;
				case 0:
					@class.ushort_0 = @struct.ushort_0;
					num = 11;
					goto case 11;
				case 10:
					{
						@struct = struct4_0[num2];
						num = 4;
						goto case 4;
					}
					IL_008f:
					if (num2 >= int_5)
					{
						if (!@class.bool_0 && 0 == 0)
						{
							if (num3 > 0)
							{
								@class.class53_0 = smethod_6(array, num3, int_6 << 1, int_7 + 1);
							}
							if (num4 > 0)
							{
								@class.class53_1 = smethod_6(array2, num4, (int_6 << 1) | 1, int_7 + 1);
							}
						}
						return @class;
					}
					goto case 10;
					IL_00dd:
					if (((uint)(@struct.struct5_0.int_0 >> @struct.struct5_0.int_1 - int_7 - 1) & (true ? 1u : 0u)) != 0 || 1 == 0)
					{
						array2[num4++] = @struct;
					}
					else
					{
						array[num3++] = @struct;
					}
					goto case 11;
				}
				break;
				IL_002e:
				num2 = 0;
				num = Class55.smethod_1(67);
			}
		}
	}

	internal static void smethod_7(int int_5, out int int_6, out int int_7)
	{
		int_6 = int_1[int_5 - 257];
		int_7 = int_2[int_5 - 257];
	}

	internal static void smethod_8(int int_5, out int int_6, out int int_7, out int int_8)
	{
		int num = Array.BinarySearch(int_1, int_5);
		if (num < 0)
		{
			num = ~num - 1;
		}
		int_6 = num + 257;
		int num2;
		while (true)
		{
			switch (Class55.smethod_1(60))
			{
			default:
				continue;
			case 0:
				int_7 = int_5 - int_1[num];
				num2 = 1;
				break;
			case 1:
				break;
			case 2:
				return;
			}
			break;
		}
		int_8 = int_2[num];
		num2 = 2;
	}

	internal static void smethod_9(int int_5, out int int_6, out int int_7, out int int_8)
	{
		int num = Array.BinarySearch(int_3, int_5);
		if (num < 0)
		{
			num = ~num - 1;
		}
		int_6 = num;
		int num2;
		while (true)
		{
			switch (Class55.smethod_1(65))
			{
			default:
				continue;
			case 1:
				int_7 = int_5 - int_3[num];
				num2 = 0;
				break;
			case 0:
				break;
			case 2:
				return;
			}
			break;
		}
		int_8 = int_4[num];
		num2 = 2;
	}

	internal static int[] smethod_10(int[] int_5, int int_6)
	{
		return Class51.smethod_0(int_5, int_6);
	}

	internal static int[] smethod_11(int[] int_5)
	{
		return Class51.smethod_0(int_5, 15);
	}

	internal static int smethod_12(int int_5)
	{
		return int_5 switch
		{
			16 => 2, 
			17 => 3, 
			18 => 7, 
			_ => 0, 
		};
	}

	internal static int[] smethod_13(int[] int_5, int int_6, int int_7)
	{
		Class52 @class = new Class52();
		int num = 0;
		int num6 = default(int);
		while (num < int_7)
		{
			if (int_5[int_6 + num] == 0 && 0 == 0)
			{
				int num2 = 0;
				while (true)
				{
					num2++;
					while (true)
					{
						int num3 = Class55.smethod_1(67);
						while (true)
						{
							switch (num3)
							{
							case 2:
								if (num + num2 < int_7)
								{
									num3 = 0;
									goto case 0;
								}
								goto case 3;
							case 0:
								if (num2 < 138)
								{
									num3 = 1;
									goto case 1;
								}
								goto case 3;
							case 1:
								if (int_5[int_6 + num + num2] != 0)
								{
									num3 = Class55.smethod_1(69);
									continue;
								}
								if (true)
								{
									goto end_IL_005e;
								}
								goto case 3;
							case 3:
								if (num2 < 3)
								{
									if (num2 >= 1)
									{
										@class.method_0(0);
									}
									if (num2 >= 2)
									{
										@class.method_0(0);
									}
								}
								else if (num2 < 11)
								{
									@class.method_0(17);
									@class.method_0(num2 - 3);
								}
								else
								{
									@class.method_0(18);
									@class.method_0(num2 - 11);
								}
								num += num2;
								goto end_IL_006f;
							}
							break;
						}
						continue;
						end_IL_005e:
						break;
					}
					continue;
					end_IL_006f:
					break;
				}
				continue;
			}
			int num4 = int_5[int_6 + num++];
			while (true)
			{
				int num5 = Class55.smethod_1(65);
				while (true)
				{
					int num7;
					switch (num5)
					{
					case 2:
						num6 = 0;
						num5 = 0;
						goto case 0;
					case 0:
						if (num6 != 0)
						{
							num5 = Class55.smethod_1(69);
							continue;
						}
						goto IL_011a;
					case 1:
						@class.method_0(num4);
						num5 = 2;
						goto case 2;
					case 3:
						{
							num6++;
							goto IL_011a;
						}
						IL_0168:
						if (num6 < 3)
						{
							goto end_IL_010f;
						}
						num7 = Class55.smethod_1(67);
						goto IL_014f;
						IL_011a:
						if (num + num6 < int_7 && num6 < 6)
						{
							if (int_5[int_6 + num + num6] == num4)
							{
								goto case 3;
							}
							goto IL_0146;
						}
						goto IL_0168;
						IL_0146:
						num7 = Class55.smethod_1(60);
						goto IL_014f;
						IL_014f:
						switch (num7)
						{
						case 0:
							goto IL_0168;
						case 2:
							@class.method_0(16);
							num7 = 1;
							goto case 1;
						case 1:
							@class.method_0(num6 - 3);
							num7 = 3;
							goto case 3;
						case 3:
							num += num6;
							goto end_IL_010f;
						}
						goto IL_0146;
					}
					break;
				}
				continue;
				end_IL_010f:
				break;
			}
		}
		return @class.method_1();
	}
}
