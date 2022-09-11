using System;

internal sealed class Class91
{
	private sealed class Class92
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
				int num = Class96.smethod_1(80);
				while (true)
				{
					switch (num)
					{
					case 2:
						if (num2 != 0)
						{
							goto IL_000f;
						}
						goto IL_0054;
					case 1:
						array2 = new int[int_0.Length];
						num = 0;
						goto case 0;
					case 0:
						num2 = 0;
						num = 2;
						goto case 2;
					case 3:
						array[num2] = num2;
						num = 4;
						goto case 4;
					case 4:
						{
							num2++;
							goto IL_0054;
						}
						IL_0054:
						if (num2 >= array.Length)
						{
							Array.Copy(int_0, array2, int_0.Length);
							while (true)
							{
								switch (Class96.smethod_1(84))
								{
								default:
									continue;
								case 0:
								{
									Array.Sort(array2, array);
									int num3 = 1;
									goto case 1;
								}
								case 1:
								{
									num4 = 0;
									int num3 = 2;
									goto case 2;
								}
								case 2:
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
							int[] array3 = new int[array2.Length - num4];
							Array.Copy(array2, num4, array3, 0, array3.Length);
							int[] array4 = ((array3.Length == 0 && 0 == 0) ? new int[0] : ((array3.Length != 1) ? smethod_1(array3, int_1) : new int[1] { 1 }));
							int[] array5 = new int[int_0.Length];
							while (true)
							{
								int num5 = Class96.smethod_1(80);
								while (true)
								{
									switch (num5)
									{
									case 1:
										goto IL_011a;
									case 2:
										if (num6 != 0)
										{
											num5 = 3;
											goto case 3;
										}
										goto case 4;
									case 3:
										array5[array[num6 + num4]] = array4[num6];
										num5 = 0;
										goto case 0;
									case 0:
										num6++;
										num5 = 4;
										goto case 4;
									case 4:
										if (num6 >= array4.Length)
										{
											return array5;
										}
										goto case 3;
									}
									break;
									IL_011a:
									num6 = 0;
									num5 = Class96.smethod_1(83);
								}
							}
						}
						goto case 3;
					}
					break;
					IL_000f:
					num = Class96.smethod_1(77);
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
				int num2 = Class96.smethod_1(83);
				while (true)
				{
					int[] array4;
					switch (num2)
					{
					case 6:
						num3++;
						goto IL_000f;
					case 0:
						goto IL_0016;
					case 5:
						if (num3 != 0)
						{
							num2 = 0;
							goto IL_0016;
						}
						goto IL_000f;
					case 4:
						array[0] = int_0;
						num2 = 3;
						goto case 3;
					case 3:
						array2 = new int[int_0.Length / 2];
						num2 = 1;
						goto case 1;
					case 1:
						num3 = 0;
						num2 = 5;
						goto case 5;
					case 2:
						{
							array = new int[int_1][];
							num2 = 4;
							goto case 4;
						}
						IL_000f:
						if (num3 < array2.Length)
						{
							goto IL_0016;
						}
						for (int i = 1; i < int_1; i++)
						{
							int[] array3 = smethod_2(array2, int_0);
							while (true)
							{
								int num4 = Class96.smethod_1(83);
								while (true)
								{
									switch (num4)
									{
									case 2:
										array[i] = array3;
										num4 = 1;
										goto IL_00b0;
									case 1:
										goto IL_00b0;
									case 0:
										num5 = 0;
										num4 = 3;
										goto case 3;
									case 3:
										if (num5 == 0)
										{
											goto IL_0104;
										}
										num4 = 4;
										goto case 4;
									case 5:
										num5++;
										goto IL_0104;
									case 4:
										{
											array2[num5] = array3[num5 * 2] + array3[num5 * 2 + 1];
											num4 = 5;
											goto case 5;
										}
										IL_0104:
										if (num5 >= array2.Length)
										{
											goto end_IL_00e4;
										}
										goto case 4;
									}
									break;
									IL_00b0:
									array2 = new int[array3.Length / 2];
									num4 = Class96.smethod_1(84);
								}
								continue;
								end_IL_00e4:
								break;
							}
						}
						array4 = new int[num];
						while (true)
						{
							switch (Class96.smethod_1(84))
							{
							default:
								continue;
							case 0:
							{
								num6 = num - 1;
								int num7 = 1;
								goto case 1;
							}
							case 1:
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
					break;
					IL_0016:
					array2[num3] = int_0[num3 * 2] + int_0[num3 * 2 + 1];
					num2 = Class96.smethod_1(86);
				}
			}
		}

		private static int[] smethod_2(int[] int_0, int[] int_1)
		{
			int[] array = new int[int_0.Length + int_1.Length];
			int num3 = default(int);
			int num2 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num = Class96.smethod_1(83);
				while (true)
				{
					switch (num)
					{
					case 5:
						goto IL_000f;
					case 2:
						num3 = 0;
						num = 5;
						goto IL_000f;
					case 4:
						num2 = 0;
						num = 1;
						goto case 1;
					case 1:
						if (num2 != 0)
						{
							num = 3;
							goto case 3;
						}
						goto case 6;
					case 3:
						if (int_0[num3] < int_1[num4])
						{
							num = 0;
							goto case 0;
						}
						array[num2++] = int_1[num4++];
						goto case 6;
					case 0:
						array[num2++] = int_0[num3++];
						num = 6;
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
						goto case 3;
					}
					break;
					IL_000f:
					num4 = 0;
					num = Class96.smethod_1(78);
				}
			}
		}
	}

	private struct Struct10
	{
		internal Struct11 struct11_0;

		internal ushort ushort_0;
	}

	internal static Struct11[] struct11_0;

	internal static Struct11[] struct11_1;

	internal static Class95 class95_0;

	internal static readonly int[] int_0;

	internal static readonly int[] int_1;

	internal static readonly int[] int_2;

	internal static readonly int[] int_3;

	internal static readonly int[] int_4;

	static Class91()
	{
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num = Class96.smethod_1(81);
			while (true)
			{
				switch (num)
				{
				case 19:
					int_1[16] = 35;
					while (true)
					{
						switch (Class96.smethod_1(80))
						{
						default:
							continue;
						case 1:
						{
							int_1[17] = 43;
							int num7 = 0;
							goto case 0;
						}
						case 0:
						{
							int_1[18] = 51;
							int num7 = 2;
							goto case 2;
						}
						case 2:
						{
							num = Class96.smethod_1(78);
							int num7 = 3;
							break;
						}
						case 3:
							break;
						}
						break;
					}
					continue;
				case 17:
					int_0[6] = 9;
					int_0[7] = 6;
					int_0[8] = 10;
					num = 7;
					goto case 7;
				case 7:
					int_0[9] = 5;
					int_0[10] = 11;
					int_0[11] = 4;
					num = 13;
					goto case 13;
				case 13:
					int_0[12] = 12;
					int_0[13] = 3;
					int_0[14] = 13;
					num = 9;
					goto case 9;
				case 9:
					int_0[15] = 2;
					int_0[16] = 14;
					int_0[17] = 1;
					num = 8;
					goto case 8;
				case 8:
					int_0[18] = 15;
					int_1 = new int[29];
					int_1[0] = 3;
					num = 0;
					goto case 0;
				case 0:
					int_1[1] = 4;
					int_1[2] = 5;
					int_1[3] = 6;
					num = 1;
					goto case 1;
				case 1:
					int_1[4] = 7;
					int_1[5] = 8;
					int_1[6] = 9;
					num = 16;
					goto case 16;
				case 16:
					int_1[7] = 10;
					int_1[8] = 11;
					int_1[9] = 13;
					num = 2;
					goto case 2;
				case 2:
					int_1[10] = 15;
					int_1[11] = 17;
					int_1[12] = 19;
					num = 14;
					goto case 14;
				case 14:
					int_1[13] = 23;
					int_1[14] = 27;
					int_1[15] = 31;
					num = 19;
					goto case 19;
				case 15:
					num = 10;
					goto case 10;
				case 10:
					struct11_0 = new Struct11[288];
					struct11_1 = new Struct11[32];
					num = 3;
					goto case 3;
				case 3:
					int_0 = new int[19];
					int_0[0] = 16;
					int_0[1] = 17;
					num = 12;
					goto case 12;
				case 12:
					int_0[2] = 18;
					int_0[4] = 8;
					int_0[5] = 7;
					num = 17;
					goto case 17;
				case 4:
					int_1[19] = 59;
					int_1[20] = 67;
					int_1[21] = 83;
					num = 11;
					goto case 11;
				case 11:
					int_1[22] = 99;
					int_1[23] = 115;
					int_1[24] = 131;
					num = 6;
					goto case 6;
				case 6:
					int_1[25] = 163;
					int_1[26] = 195;
					int_1[27] = 227;
					num = 18;
					goto case 18;
				case 18:
					int_1[28] = 258;
					int_2 = new int[29];
					num2 = 8;
					num = 5;
					goto case 5;
				case 5:
					num3 = 0;
					goto IL_0306;
				case 20:
					{
						if (true)
						{
							goto IL_02fa;
						}
						goto IL_0313;
					}
					IL_0306:
					if (num2 < 28)
					{
						if (num2 % 4 == 0)
						{
							goto IL_0313;
						}
						num = 20;
						goto case 20;
					}
					int_3 = new int[30];
					while (true)
					{
						int num4 = Class96.smethod_1(77);
						while (true)
						{
							switch (num4)
							{
							case 16:
								int_3[16] = 257;
								int_3[17] = 385;
								num4 = 12;
								goto IL_0353;
							case 12:
								goto IL_0353;
							case 15:
								int_3[2] = 3;
								int_3[3] = 4;
								num4 = 9;
								goto case 9;
							case 9:
								int_3[4] = 5;
								int_3[5] = 7;
								num4 = 7;
								goto case 7;
							case 7:
								int_3[6] = 9;
								int_3[7] = 13;
								num4 = 10;
								goto case 10;
							case 10:
								int_3[8] = 17;
								int_3[9] = 25;
								num4 = 6;
								goto case 6;
							case 6:
								int_3[10] = 33;
								int_3[11] = 49;
								num4 = 11;
								goto case 11;
							case 11:
								int_3[12] = 65;
								int_3[13] = 97;
								num4 = 0;
								goto case 0;
							case 0:
								int_3[14] = 129;
								int_3[15] = 193;
								num4 = 16;
								goto case 16;
							case 3:
								int_3[0] = 1;
								int_3[1] = 2;
								num4 = 15;
								goto case 15;
							case 1:
								int_3[20] = 1025;
								int_3[21] = 1537;
								num4 = 5;
								goto case 5;
							case 5:
								int_3[22] = 2049;
								int_3[23] = 3073;
								num4 = 14;
								goto case 14;
							case 14:
								int_3[24] = 4097;
								int_3[25] = 6145;
								num4 = 4;
								goto case 4;
							case 4:
								int_3[26] = 8193;
								int_3[27] = 12289;
								num4 = 2;
								goto case 2;
							case 2:
								int_3[28] = 16385;
								int_3[29] = 24577;
								num4 = 8;
								goto case 8;
							case 8:
								int_4 = new int[30];
								num5 = 4;
								num4 = 13;
								goto case 13;
							case 13:
								num6 = 0;
								goto IL_054e;
							case 17:
								{
									if (num5 % 2 == 0 && 0 == 0)
									{
										num6++;
									}
									int_4[num5] = num6;
									num5++;
									goto IL_054e;
								}
								IL_054e:
								if (num5 >= 30)
								{
									for (int i = 0; i <= 143; i++)
									{
										struct11_0[i].int_0 = 48 + i;
										struct11_0[i].int_1 = 8;
									}
									for (int j = 144; j <= 255; j++)
									{
										struct11_0[j].int_0 = 400 + j - 144;
										struct11_0[j].int_1 = 9;
									}
									for (int k = 256; k <= 279; k++)
									{
										struct11_0[k].int_0 = k - 256;
										struct11_0[k].int_1 = 7;
									}
									for (int l = 280; l <= 287; l++)
									{
										struct11_0[l].int_0 = 192 + l - 280;
										struct11_0[l].int_1 = 8;
									}
									for (int m = 0; m <= 31; m++)
									{
										struct11_1[m].int_0 = m;
										struct11_1[m].int_1 = 5;
									}
									class95_0 = smethod_4(struct11_0, struct11_1);
									return;
								}
								goto case 17;
							}
							break;
							IL_0353:
							int_3[18] = 513;
							int_3[19] = 769;
							num4 = Class96.smethod_1(80);
						}
					}
					IL_0313:
					num3++;
					goto IL_02fa;
					IL_02fa:
					int_2[num2] = num3;
					num2++;
					goto IL_0306;
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
			int num2 = Class96.smethod_1(80);
			while (true)
			{
				switch (num2)
				{
				case 3:
					num3++;
					goto IL_0008;
				case 0:
					goto IL_000e;
				case 2:
					if (num3 != 0)
					{
						num2 = 0;
						goto IL_000e;
					}
					goto IL_0008;
				case 1:
					{
						num3 = 0;
						num2 = 2;
						goto case 2;
					}
					IL_0008:
					if (num3 < int_5.Length)
					{
						goto IL_000e;
					}
					return num;
				}
				break;
				IL_000e:
				num += int_5[num3] * int_6[num3];
				num2 = Class96.smethod_1(77);
			}
		}
	}

	internal static int smethod_1(int[] int_5, int[] int_6)
	{
		int num = 0;
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2 = Class96.smethod_1(83);
			while (true)
			{
				switch (num2)
				{
				case 2:
					goto IL_0004;
				case 0:
					if (num3 == 0)
					{
						goto IL_0039;
					}
					num2 = 1;
					goto case 1;
				case 3:
					num3++;
					goto IL_0039;
				case 1:
					{
						num += int_5[num3] * struct11_0[num3].int_1;
						num2 = 3;
						goto case 3;
					}
					IL_0039:
					if (num3 >= int_5.Length)
					{
						while (true)
						{
							switch (Class96.smethod_1(83))
							{
							case 2:
							{
								num4 = 0;
								int num5 = 1;
								goto case 1;
							}
							case 1:
							{
								if (num4 == 0)
								{
									goto IL_008d;
								}
								int num5 = 0;
								goto case 0;
							}
							case 3:
								num4++;
								goto IL_008d;
							case 0:
								{
									num += int_6[num4] * struct11_1[num4].int_1;
									int num5 = 3;
									goto case 3;
								}
								IL_008d:
								if (num4 >= int_6.Length)
								{
									return num;
								}
								goto case 0;
							}
						}
					}
					goto case 1;
				}
				break;
				IL_0004:
				num3 = 0;
				num2 = Class96.smethod_1(84);
			}
		}
	}

	internal static Struct11[] smethod_2(int[] int_5)
	{
		Struct11[] array = new Struct11[int_5.Length];
		int num2 = default(int);
		while (true)
		{
			int num = Class96.smethod_1(84);
			while (true)
			{
				switch (num)
				{
				case 0:
					goto IL_000b;
				case 1:
					if (num2 == 0)
					{
						goto IL_0040;
					}
					num = 2;
					goto case 2;
				case 3:
					num2++;
					goto IL_0040;
				case 2:
					{
						array[num2].int_1 = int_5[num2];
						num = 3;
						goto case 3;
					}
					IL_0040:
					if (num2 >= int_5.Length)
					{
						smethod_3(array);
						return array;
					}
					goto case 2;
				}
				break;
				IL_000b:
				num2 = 0;
				num = Class96.smethod_1(80);
			}
		}
	}

	internal static void smethod_3(Struct11[] struct11_2)
	{
		int num = struct11_2[0].int_1;
		for (int i = 1; i < struct11_2.Length; i++)
		{
			if (num < struct11_2[i].int_1)
			{
				num = struct11_2[i].int_1;
			}
		}
		int[] array = new int[num + 1];
		int num3 = default(int);
		int num6 = default(int);
		int num5 = default(int);
		int num9 = default(int);
		while (true)
		{
			int num2 = Class96.smethod_1(83);
			while (true)
			{
				switch (num2)
				{
				case 2:
					goto IL_0048;
				case 0:
					if (num3 == 0)
					{
						goto IL_0085;
					}
					num2 = 1;
					goto case 1;
				case 3:
					num3++;
					goto IL_0085;
				case 1:
					{
						array[struct11_2[num3].int_1]++;
						num2 = 3;
						goto case 3;
					}
					IL_0085:
					if (num3 >= struct11_2.Length)
					{
						int[] array2 = new int[num + 1];
						while (true)
						{
							int num4 = Class96.smethod_1(83);
							while (true)
							{
								switch (num4)
								{
								case 4:
									array[0] = 0;
									num4 = 0;
									goto case 0;
								case 0:
									num6 = 1;
									num4 = 3;
									goto case 3;
								case 3:
									if (num6 == 0)
									{
										goto IL_00c5;
									}
									goto IL_0105;
								case 2:
									num5 = 0;
									num4 = 4;
									goto case 4;
								case 1:
									num5 = num5 + array[num6 - 1] << 1;
									num4 = 5;
									goto case 5;
								case 5:
									array2[num6] = num5;
									num4 = 6;
									goto case 6;
								case 6:
									{
										num6++;
										goto IL_0105;
									}
									IL_0105:
									if (num6 > num)
									{
										int num7 = 0;
										while (true)
										{
											int num8 = Class96.smethod_1(80);
											while (true)
											{
												switch (num8)
												{
												case 3:
													struct11_2[num7].int_0 = array2[num9];
													array2[num9]++;
													goto IL_014e;
												case 2:
													goto IL_015b;
												case 1:
													if (num7 != 0)
													{
														num8 = 2;
														goto IL_015b;
													}
													goto IL_0154;
												case 0:
													{
														if (num9 == 0)
														{
															if (true)
															{
																goto IL_014e;
															}
														}
														else
														{
															num8 = 3;
														}
														goto case 3;
													}
													IL_014e:
													num7++;
													goto IL_0154;
													IL_0154:
													if (num7 < struct11_2.Length)
													{
														goto IL_015b;
													}
													return;
												}
												break;
												IL_015b:
												num9 = struct11_2[num7].int_1;
												num8 = Class96.smethod_1(84);
											}
										}
									}
									goto case 1;
								}
								break;
								IL_00c5:
								num4 = Class96.smethod_1(80);
							}
						}
					}
					goto case 1;
				}
				break;
				IL_0048:
				num3 = 0;
				num2 = Class96.smethod_1(84);
			}
		}
	}

	internal static Class95 smethod_4(Struct11[] struct11_2, Struct11[] struct11_3)
	{
		return new Class95
		{
			class94_0 = smethod_5(struct11_2),
			class94_1 = smethod_5(struct11_3)
		};
	}

	internal static Class94 smethod_5(Struct11[] struct11_2)
	{
		Struct10[] array = new Struct10[struct11_2.Length];
		int int_ = 0;
		Struct10 @struct = default(Struct10);
		int num2 = default(int);
		while (true)
		{
			int num = Class96.smethod_1(84);
			while (true)
			{
				switch (num)
				{
				case 4:
					while (true)
					{
						switch (Class96.smethod_1(84))
						{
						default:
							continue;
						case 0:
						{
							@struct.struct11_0 = struct11_2[num2];
							int num3 = 1;
							goto case 1;
						}
						case 1:
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
					goto IL_0057;
				case 3:
					if (struct11_2[num2].int_1 > 0)
					{
						num = 1;
						goto IL_0073;
					}
					goto IL_0057;
				case 1:
					goto IL_0073;
				case 2:
					if (num2 == 0)
					{
						goto IL_005b;
					}
					num = 3;
					goto case 3;
				case 0:
					{
						num2 = 0;
						num = 2;
						goto case 2;
					}
					IL_005b:
					if (num2 >= struct11_2.Length)
					{
						return smethod_6(array, int_, 0, 0);
					}
					goto case 3;
					IL_0057:
					num2++;
					goto IL_005b;
				}
				break;
				IL_0073:
				@struct = default(Struct10);
				num = Class96.smethod_1(78);
			}
		}
	}

	private static Class94 smethod_6(Struct10[] struct10_0, int int_5, int int_6, int int_7)
	{
		Struct10[] array = new Struct10[int_5];
		Struct10 @struct = default(Struct10);
		int num4 = default(int);
		int num2 = default(int);
		int num3 = default(int);
		Class94 @class = default(Class94);
		Struct10[] array2 = default(Struct10[]);
		while (true)
		{
			int num = Class96.smethod_1(83);
			while (true)
			{
				switch (num)
				{
				case 3:
					@struct = struct10_0[num4];
					num = 5;
					goto case 5;
				case 5:
					if (@struct.struct11_0.int_1 == int_7)
					{
						num = 0;
						goto case 0;
					}
					goto IL_0044;
				case 0:
					if (@struct.struct11_0.int_0 == int_6)
					{
						goto IL_009a;
					}
					goto IL_0044;
				case 11:
					num4++;
					goto IL_000c;
				case 10:
					if (num4 == 0)
					{
						goto IL_000c;
					}
					num = 3;
					goto case 3;
				case 9:
					num2 = 0;
					num3 = 0;
					num = 6;
					goto case 6;
				case 6:
					num4 = 0;
					num = 10;
					goto case 10;
				case 8:
					@class.ushort_0 = @struct.ushort_0;
					num = 11;
					goto case 11;
				case 7:
					@class = new Class94();
					num = 1;
					goto case 1;
				case 1:
					@class.bool_0 = false;
					num = 9;
					goto case 9;
				case 4:
					@class.bool_0 = true;
					num = 8;
					goto case 8;
				case 2:
					{
						array2 = new Struct10[int_5];
						num = 7;
						goto case 7;
					}
					IL_000c:
					if (num4 >= int_5)
					{
						if (!@class.bool_0 && 0 == 0)
						{
							if (num2 > 0)
							{
								@class.class94_0 = smethod_6(array, num2, int_6 << 1, int_7 + 1);
							}
							if (num3 > 0)
							{
								@class.class94_1 = smethod_6(array2, num3, (int_6 << 1) | 1, int_7 + 1);
							}
						}
						return @class;
					}
					goto case 3;
					IL_0044:
					if (((uint)(@struct.struct11_0.int_0 >> @struct.struct11_0.int_1 - int_7 - 1) & (true ? 1u : 0u)) != 0 || 1 == 0)
					{
						array2[num3++] = @struct;
					}
					else
					{
						array[num2++] = @struct;
					}
					goto case 11;
				}
				break;
				IL_009a:
				num = Class96.smethod_1(78);
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
			switch (Class96.smethod_1(84))
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
			switch (Class96.smethod_1(84))
			{
			default:
				continue;
			case 0:
				int_7 = int_5 - int_3[num];
				num2 = 1;
				break;
			case 1:
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
		return Class92.smethod_0(int_5, int_6);
	}

	internal static int[] smethod_11(int[] int_5)
	{
		return Class92.smethod_0(int_5, 15);
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
		Class93 @class = new Class93();
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
						int num3 = Class96.smethod_1(83);
						while (true)
						{
							switch (num3)
							{
							case 2:
								if (num + num2 < int_7)
								{
									num3 = Class96.smethod_1(84);
									continue;
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
									num3 = 3;
								}
								else if (true)
								{
									goto end_IL_0047;
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
								goto end_IL_0071;
							}
							break;
						}
						continue;
						end_IL_0047:
						break;
					}
					continue;
					end_IL_0071:
					break;
				}
				continue;
			}
			int num4 = int_5[int_6 + num++];
			while (true)
			{
				int num5 = Class96.smethod_1(83);
				while (true)
				{
					switch (num5)
					{
					case 2:
						@class.method_0(num4);
						num5 = 1;
						goto case 1;
					case 1:
						num6 = 0;
						num5 = 0;
						goto case 0;
					case 0:
						if (num6 != 0)
						{
							num5 = Class96.smethod_1(77);
							continue;
						}
						goto IL_0118;
					case 3:
						{
							num6++;
							goto IL_0118;
						}
						IL_0118:
						if (num + num6 >= int_7 || num6 >= 6 || int_5[int_6 + num + num6] != num4)
						{
							goto end_IL_010d;
						}
						goto case 3;
					}
					break;
				}
				continue;
				end_IL_010d:
				break;
			}
			if (num6 < 3)
			{
				continue;
			}
			@class.method_0(16);
			while (true)
			{
				switch (Class96.smethod_1(84))
				{
				default:
					continue;
				case 0:
				{
					@class.method_0(num6 - 3);
					int num7 = 1;
					goto case 1;
				}
				case 1:
				{
					num += num6;
					int num7 = 2;
					break;
				}
				case 2:
					break;
				}
				break;
			}
		}
		return @class.method_1();
	}
}
