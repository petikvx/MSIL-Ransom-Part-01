using System;

internal sealed class Class7
{
	private sealed class Class8
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
				int num = Class12.smethod_1(82);
				while (true)
				{
					switch (num)
					{
					case 3:
						if (num2 != 0)
						{
							goto IL_000f;
						}
						goto IL_0056;
					case 2:
						num2 = 0;
						num = 3;
						goto case 3;
					case 1:
						array2 = new int[int_0.Length];
						num = 2;
						goto case 2;
					case 0:
						array[num2] = num2;
						num = 4;
						goto case 4;
					case 4:
						{
							num2++;
							goto IL_0056;
						}
						IL_0056:
						if (num2 >= array.Length)
						{
							Array.Copy(int_0, array2, int_0.Length);
							while (true)
							{
								switch (Class12.smethod_1(69))
								{
								default:
									continue;
								case 2:
								{
									Array.Sort(array2, array);
									int num3 = 1;
									goto case 1;
								}
								case 1:
								{
									num4 = 0;
									int num3 = 0;
									goto case 0;
								}
								case 0:
								{
									if (num4 == 0)
									{
										goto IL_00b1;
									}
									int num3 = 3;
									goto case 3;
								}
								case 3:
									{
										num4++;
										goto IL_00b1;
									}
									IL_00b1:
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
								int num5 = Class12.smethod_1(82);
								while (true)
								{
									switch (num5)
									{
									case 3:
										num6++;
										goto IL_0122;
									case 2:
										goto IL_012a;
									case 1:
										num6 = 0;
										num5 = 0;
										goto case 0;
									case 0:
										{
											if (num6 != 0)
											{
												num5 = 2;
												goto IL_012a;
											}
											goto IL_0122;
										}
										IL_0122:
										if (num6 < array4.Length)
										{
											goto IL_012a;
										}
										return array5;
									}
									break;
									IL_012a:
									array5[array[num6 + num4]] = array4[num6];
									num5 = Class12.smethod_1(70);
								}
							}
						}
						goto case 0;
					}
					break;
					IL_000f:
					num = Class12.smethod_1(72);
				}
			}
		}

		private static int[] smethod_1(int[] int_0, int int_1)
		{
			int num = int_0.Length;
			int[][] array = default(int[][]);
			int[] array2 = default(int[]);
			int num3 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num8 = default(int);
			while (true)
			{
				int num2 = Class12.smethod_1(69);
				while (true)
				{
					switch (num2)
					{
					case 2:
						goto IL_0006;
					case 1:
						array[0] = int_0;
						num2 = 4;
						goto case 4;
					case 4:
						array2 = new int[int_0.Length / 2];
						num2 = 5;
						goto case 5;
					case 5:
						num3 = 0;
						num2 = 0;
						goto case 0;
					case 0:
						if (num3 == 0)
						{
							goto IL_006e;
						}
						num2 = 3;
						goto case 3;
					case 6:
						num3++;
						goto IL_006e;
					case 3:
						{
							array2[num3] = int_0[num3 * 2] + int_0[num3 * 2 + 1];
							num2 = 6;
							goto case 6;
						}
						IL_006e:
						if (num3 >= array2.Length)
						{
							for (int i = 1; i < int_1; i++)
							{
								int[] array3 = smethod_2(array2, int_0);
								while (true)
								{
									int num4 = Class12.smethod_1(82);
									while (true)
									{
										switch (num4)
										{
										case 5:
											num5++;
											goto IL_00a6;
										case 0:
											goto IL_00ad;
										case 4:
											array2 = new int[array3.Length / 2];
											num4 = 3;
											goto case 3;
										case 3:
											num5 = 0;
											num4 = 2;
											goto case 2;
										case 2:
											if (num5 != 0)
											{
												num4 = 0;
												goto IL_00ad;
											}
											goto IL_00a6;
										case 1:
											{
												array[i] = array3;
												num4 = 4;
												goto case 4;
											}
											IL_00a6:
											if (num5 < array2.Length)
											{
												goto IL_00ad;
											}
											goto end_IL_0115;
										}
										break;
										IL_00ad:
										array2[num5] = array3[num5 * 2] + array3[num5 * 2 + 1];
										num4 = Class12.smethod_1(74);
									}
									continue;
									end_IL_0115:
									break;
								}
							}
							int[] array4 = new int[num];
							while (true)
							{
								switch (Class12.smethod_1(72))
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
						goto case 3;
					}
					break;
					IL_0006:
					array = new int[int_1][];
					num2 = Class12.smethod_1(82);
				}
			}
		}

		private static int[] smethod_2(int[] int_0, int[] int_1)
		{
			int[] array = new int[int_0.Length + int_1.Length];
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num = Class12.smethod_1(70);
				while (true)
				{
					switch (num)
					{
					case 3:
						goto IL_000f;
					case 2:
						num2 = 0;
						num = 1;
						goto case 1;
					case 1:
						num3 = 0;
						num = 5;
						goto case 5;
					case 5:
						if (num3 != 0)
						{
							num = 4;
							goto case 4;
						}
						goto case 6;
					case 4:
						if (int_0[num4] < int_1[num2])
						{
							num = 0;
							goto case 0;
						}
						array[num3++] = int_1[num2++];
						goto case 6;
					case 0:
						array[num3++] = int_0[num4++];
						num = 6;
						goto case 6;
					case 6:
						if (num4 >= int_0.Length || num2 >= int_1.Length)
						{
							while (num4 < int_0.Length)
							{
								array[num3++] = int_0[num4++];
							}
							while (num2 < int_1.Length)
							{
								array[num3++] = int_1[num2++];
							}
							return array;
						}
						goto case 4;
					}
					break;
					IL_000f:
					num4 = 0;
					num = Class12.smethod_1(69);
				}
			}
		}
	}

	private struct Struct0
	{
		internal Struct1 struct1_0;

		internal ushort ushort_0;
	}

	internal static Struct1[] struct1_0;

	internal static Struct1[] struct1_1;

	internal static Class11 class11_0;

	internal static readonly int[] int_0;

	internal static readonly int[] int_1;

	internal static readonly int[] int_2;

	internal static readonly int[] int_3;

	internal static readonly int[] int_4;

	static Class7()
	{
		struct1_0 = new Struct1[288];
		struct1_1 = new Struct1[32];
		int_0 = new int[19];
		int_0[0] = 16;
		int_0[1] = 17;
		int_0[2] = 18;
		int_0[4] = 8;
		int_0[5] = 7;
		int_0[6] = 9;
		int_0[7] = 6;
		int_0[8] = 10;
		int_0[9] = 5;
		int_0[10] = 11;
		int_0[11] = 4;
		int_0[12] = 12;
		int_0[13] = 3;
		int_0[14] = 13;
		int_0[15] = 2;
		int_0[16] = 14;
		int_0[17] = 1;
		int_0[18] = 15;
		int_1 = new int[29];
		int_1[0] = 3;
		int_1[1] = 4;
		int_1[2] = 5;
		int_1[3] = 6;
		int_1[4] = 7;
		int_1[5] = 8;
		int_1[6] = 9;
		int_1[7] = 10;
		int_1[8] = 11;
		int_1[9] = 13;
		int_1[10] = 15;
		int_1[11] = 17;
		int_1[12] = 19;
		int_1[13] = 23;
		int_1[14] = 27;
		int_1[15] = 31;
		int_1[16] = 35;
		int_1[17] = 43;
		int_1[18] = 51;
		int_1[19] = 59;
		int_1[20] = 67;
		int_1[21] = 83;
		int_1[22] = 99;
		int_1[23] = 115;
		int_1[24] = 131;
		int_1[25] = 163;
		int_1[26] = 195;
		int_1[27] = 227;
		int_1[28] = 258;
		int_2 = new int[29];
		int i = 8;
		int num = 0;
		for (; i < 28; i++)
		{
			if (i % 4 == 0)
			{
				num++;
			}
			int_2[i] = num;
		}
		int_3 = new int[30];
		int_3[0] = 1;
		int_3[1] = 2;
		int_3[2] = 3;
		int_3[3] = 4;
		int_3[4] = 5;
		int_3[5] = 7;
		int_3[6] = 9;
		int_3[7] = 13;
		int_3[8] = 17;
		int_3[9] = 25;
		int_3[10] = 33;
		int_3[11] = 49;
		int_3[12] = 65;
		int_3[13] = 97;
		int_3[14] = 129;
		int_3[15] = 193;
		int_3[16] = 257;
		int_3[17] = 385;
		int_3[18] = 513;
		int_3[19] = 769;
		int_3[20] = 1025;
		int_3[21] = 1537;
		int_3[22] = 2049;
		int_3[23] = 3073;
		int_3[24] = 4097;
		int_3[25] = 6145;
		int_3[26] = 8193;
		int_3[27] = 12289;
		int_3[28] = 16385;
		int_3[29] = 24577;
		int_4 = new int[30];
		int j = 4;
		int num2 = 0;
		for (; j < 30; j++)
		{
			if (j % 2 == 0)
			{
				num2++;
			}
			int_4[j] = num2;
		}
		for (int k = 0; k <= 143; k++)
		{
			struct1_0[k].int_0 = 48 + k;
			struct1_0[k].int_1 = 8;
		}
		for (int l = 144; l <= 255; l++)
		{
			struct1_0[l].int_0 = 400 + l - 144;
			struct1_0[l].int_1 = 9;
		}
		for (int m = 256; m <= 279; m++)
		{
			struct1_0[m].int_0 = m - 256;
			struct1_0[m].int_1 = 7;
		}
		for (int n = 280; n <= 287; n++)
		{
			struct1_0[n].int_0 = 192 + n - 280;
			struct1_0[n].int_1 = 8;
		}
		for (int num3 = 0; num3 <= 31; num3++)
		{
			struct1_1[num3].int_0 = num3;
			struct1_1[num3].int_1 = 5;
		}
		class11_0 = smethod_4(struct1_0, struct1_1);
	}

	internal static int smethod_0(int[] int_5, int[] int_6)
	{
		int num = 0;
		int num3 = default(int);
		while (true)
		{
			int num2 = Class12.smethod_1(72);
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (num3 != 0)
					{
						goto IL_0007;
					}
					goto IL_0037;
				case 0:
					num3 = 0;
					num2 = 2;
					goto case 2;
				case 1:
					num += int_5[num3] * int_6[num3];
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
						return num;
					}
					goto case 1;
				}
				break;
				IL_0007:
				num2 = Class12.smethod_1(82);
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
			int num2 = Class12.smethod_1(69);
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
					num3 = 0;
					num2 = 1;
					goto case 1;
				case 1:
					{
						if (num3 != 0)
						{
							num2 = 0;
							goto IL_000e;
						}
						goto IL_0008;
					}
					IL_0008:
					if (num3 < int_5.Length)
					{
						goto IL_000e;
					}
					while (true)
					{
						int num4 = Class12.smethod_1(82);
						while (true)
						{
							switch (num4)
							{
							case 1:
								goto IL_005a;
							case 2:
								if (num5 == 0)
								{
									goto IL_0093;
								}
								num4 = 0;
								goto case 0;
							case 3:
								num5++;
								goto IL_0093;
							case 0:
								{
									num += int_6[num5] * struct1_1[num5].int_1;
									num4 = 3;
									goto case 3;
								}
								IL_0093:
								if (num5 >= int_6.Length)
								{
									return num;
								}
								goto case 0;
							}
							break;
							IL_005a:
							num5 = 0;
							num4 = Class12.smethod_1(69);
						}
					}
				}
				break;
				IL_000e:
				num += int_5[num3] * struct1_0[num3].int_1;
				num2 = Class12.smethod_1(70);
			}
		}
	}

	internal static Struct1[] smethod_2(int[] int_5)
	{
		Struct1[] array = new Struct1[int_5.Length];
		int num2 = default(int);
		while (true)
		{
			int num = Class12.smethod_1(69);
			while (true)
			{
				switch (num)
				{
				case 3:
					num2++;
					goto IL_000f;
				case 0:
					goto IL_0015;
				case 2:
					num2 = 0;
					num = 1;
					goto case 1;
				case 1:
					{
						if (num2 != 0)
						{
							num = 0;
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
				num = Class12.smethod_1(70);
			}
		}
	}

	internal static void smethod_3(Struct1[] struct1_2)
	{
		int num = struct1_2[0].int_1;
		int num3 = default(int);
		int num4 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num2 = Class12.smethod_1(69);
			while (true)
			{
				switch (num2)
				{
				case 2:
					num3 = 1;
					num2 = 0;
					goto case 0;
				case 0:
					if (num3 == 0)
					{
						goto IL_0019;
					}
					goto IL_0044;
				case 1:
					if (num >= struct1_2[num3].int_1)
					{
						goto IL_005b;
					}
					num2 = 3;
					goto case 3;
				case 3:
					{
						num = struct1_2[num3].int_1;
						goto IL_005b;
					}
					IL_0044:
					if (num3 >= struct1_2.Length)
					{
						int[] array = new int[num + 1];
						while (true)
						{
							switch (Class12.smethod_1(69))
							{
							case 2:
							{
								num4 = 0;
								int num5 = 0;
								goto case 0;
							}
							case 0:
							{
								if (num4 == 0)
								{
									goto IL_00b6;
								}
								int num5 = 1;
								goto case 1;
							}
							case 3:
								num4++;
								goto IL_00b6;
							case 1:
								{
									array[struct1_2[num4].int_1]++;
									int num5 = 3;
									goto case 3;
								}
								IL_00b6:
								if (num4 >= struct1_2.Length)
								{
									int[] array2 = new int[num + 1];
									while (true)
									{
										int num6 = Class12.smethod_1(70);
										while (true)
										{
											switch (num6)
											{
											case 3:
												goto IL_00e5;
											case 2:
												array[0] = 0;
												num6 = 4;
												goto case 4;
											case 4:
												num7 = 1;
												num6 = 5;
												goto case 5;
											case 5:
												if (num7 != 0)
												{
													goto IL_013a;
												}
												num6 = 1;
												goto case 1;
											case 6:
												num7++;
												goto IL_013a;
											case 0:
												array2[num7] = num8;
												num6 = 6;
												goto case 6;
											case 1:
												{
													num8 = num8 + array[num7 - 1] << 1;
													num6 = 0;
													goto case 0;
												}
												IL_013a:
												if (num7 > num)
												{
													for (int i = 0; i < struct1_2.Length; i++)
													{
														int num9 = struct1_2[i].int_1;
														if (num9 != 0 || 1 == 0)
														{
															struct1_2[i].int_0 = array2[num9];
															array2[num9]++;
														}
													}
													return;
												}
												goto case 1;
											}
											break;
											IL_00e5:
											num8 = 0;
											num6 = Class12.smethod_1(69);
										}
									}
								}
								goto case 1;
							}
						}
					}
					goto case 1;
					IL_005b:
					num3++;
					goto IL_0044;
				}
				break;
				IL_0019:
				num2 = Class12.smethod_1(82);
			}
		}
	}

	internal static Class11 smethod_4(Struct1[] struct1_2, Struct1[] struct1_3)
	{
		return new Class11
		{
			class10_0 = smethod_5(struct1_2),
			class10_1 = smethod_5(struct1_3)
		};
	}

	internal static Class10 smethod_5(Struct1[] struct1_2)
	{
		Struct0[] array = new Struct0[struct1_2.Length];
		int num2 = default(int);
		int int_ = default(int);
		Struct0 @struct = default(Struct0);
		while (true)
		{
			int num = Class12.smethod_1(70);
			while (true)
			{
				switch (num)
				{
				case 4:
					if (num2 != 0)
					{
						goto IL_000e;
					}
					goto IL_005d;
				case 3:
					int_ = 0;
					num = 0;
					goto case 0;
				case 0:
					num2 = 0;
					num = 4;
					goto case 4;
				case 2:
					if (struct1_2[num2].int_1 <= 0)
					{
						goto IL_0072;
					}
					num = 1;
					goto case 1;
				case 1:
					@struct = default(Struct0);
					num = 5;
					goto case 5;
				case 5:
					{
						while (true)
						{
							switch (Class12.smethod_1(82))
							{
							case 2:
								break;
							case 1:
							{
								@struct.struct1_0 = struct1_2[num2];
								int num3 = 0;
								goto case 0;
							}
							case 0:
							{
								@struct.ushort_0 = (ushort)num2;
								int num3 = 2;
								break;
							}
							default:
								continue;
							}
							break;
						}
						array[int_++] = @struct;
						goto IL_0072;
					}
					IL_005d:
					if (num2 >= struct1_2.Length)
					{
						return smethod_6(array, int_, 0, 0);
					}
					goto case 2;
					IL_0072:
					num2++;
					goto IL_005d;
				}
				break;
				IL_000e:
				num = Class12.smethod_1(69);
			}
		}
	}

	private static Class10 smethod_6(Struct0[] struct0_0, int int_5, int int_6, int int_7)
	{
		Struct0[] array = new Struct0[int_5];
		int num4 = default(int);
		Struct0 @struct = default(Struct0);
		Class10 @class = default(Class10);
		int num2 = default(int);
		int num3 = default(int);
		Struct0[] array2 = default(Struct0[]);
		while (true)
		{
			int num = Class12.smethod_1(76);
			while (true)
			{
				switch (num)
				{
				case 11:
					num4++;
					goto IL_0012;
				case 3:
					if (@struct.struct1_0.int_1 == int_7)
					{
						num = 10;
						goto case 10;
					}
					goto IL_0040;
				case 10:
					if (@struct.struct1_0.int_0 != int_6)
					{
						goto IL_0040;
					}
					num = 7;
					goto case 7;
				case 6:
					@struct = struct0_0[num4];
					num = 3;
					goto case 3;
				case 7:
					@class.bool_0 = true;
					num = 2;
					goto IL_00af;
				case 2:
					goto IL_00af;
				case 9:
					@class = new Class10();
					num = 5;
					goto case 5;
				case 5:
					@class.bool_0 = false;
					num = 8;
					goto case 8;
				case 8:
					num2 = 0;
					num3 = 0;
					num = 1;
					goto case 1;
				case 1:
					num4 = 0;
					num = 0;
					goto case 0;
				case 0:
					if (num4 == 0)
					{
						goto IL_0012;
					}
					num = 6;
					goto case 6;
				case 4:
					{
						array2 = new Struct0[int_5];
						num = 9;
						goto case 9;
					}
					IL_0012:
					if (num4 >= int_5)
					{
						if (!@class.bool_0 && 0 == 0)
						{
							if (num2 > 0)
							{
								@class.class10_0 = smethod_6(array, num2, int_6 << 1, int_7 + 1);
							}
							if (num3 > 0)
							{
								@class.class10_1 = smethod_6(array2, num3, (int_6 << 1) | 1, int_7 + 1);
							}
						}
						return @class;
					}
					goto case 6;
					IL_0040:
					if (((uint)(@struct.struct1_0.int_0 >> @struct.struct1_0.int_1 - int_7 - 1) & (true ? 1u : 0u)) != 0 || 1 == 0)
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
				IL_00af:
				@class.ushort_0 = @struct.ushort_0;
				num = Class12.smethod_1(77);
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
			switch (Class12.smethod_1(82))
			{
			default:
				continue;
			case 1:
				int_7 = int_5 - int_1[num];
				num2 = 0;
				break;
			case 0:
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
			switch (Class12.smethod_1(72))
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
		return Class8.smethod_0(int_5, int_6);
	}

	internal static int[] smethod_11(int[] int_5)
	{
		return Class8.smethod_0(int_5, 15);
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
		Class9 @class = new Class9();
		int num = 0;
		int num6 = default(int);
		while (num < int_7)
		{
			if (int_5[int_6 + num] == 0 && 0 == 0)
			{
				int num2 = 0;
				do
				{
					num2++;
					while (true)
					{
						switch (Class12.smethod_1(82))
						{
						default:
							continue;
						case 1:
						{
							if (num + num2 >= int_7)
							{
								break;
							}
							int num3 = 0;
							goto case 0;
						}
						case 0:
						{
							if (num2 >= 138)
							{
								break;
							}
							int num3 = 2;
							goto case 2;
						}
						case 2:
						{
							if (int_5[int_6 + num + num2] == 0)
							{
								goto end_IL_0021;
							}
							int num3 = 3;
							break;
						}
						case 3:
							break;
						}
						goto end_IL_006b;
						continue;
						end_IL_0021:
						break;
					}
					continue;
					end_IL_006b:
					break;
				}
				while (true);
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
				continue;
			}
			int num4 = int_5[int_6 + num++];
			while (true)
			{
				int num5 = Class12.smethod_1(69);
				while (true)
				{
					int num7;
					switch (num5)
					{
					case 2:
						@class.method_0(num4);
						num5 = Class12.smethod_1(72);
						continue;
					case 0:
						num6 = 0;
						num5 = 1;
						goto case 1;
					case 1:
						if (num6 == 0)
						{
							goto IL_0114;
						}
						num5 = 3;
						goto case 3;
					case 3:
						{
							num6++;
							goto IL_0114;
						}
						IL_0114:
						if (num + num6 < int_7 && num6 < 6)
						{
							if (int_5[int_6 + num + num6] == num4)
							{
								goto case 3;
							}
							goto IL_0140;
						}
						goto IL_0162;
						IL_0149:
						switch (num7)
						{
						case 0:
							goto IL_0162;
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
							goto end_IL_00fa;
						}
						goto IL_0140;
						IL_0140:
						num7 = Class12.smethod_1(72);
						goto IL_0149;
						IL_0162:
						if (num6 < 3)
						{
							goto end_IL_00fa;
						}
						num7 = Class12.smethod_1(69);
						goto IL_0149;
					}
					break;
				}
				continue;
				end_IL_00fa:
				break;
			}
		}
		return @class.method_1();
	}
}
