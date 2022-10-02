using System;

internal sealed class Class35
{
	private struct Struct1
	{
		private int[] int_0;

		private int[] int_1;

		internal Struct1(int[] int_2, int[] int_3)
		{
			int_0 = int_2;
			int_1 = int_3;
		}

		internal void method_0(int int_2, int int_3)
		{
			if (int_2 == int_3 || int_0[int_2].CompareTo(int_0[int_3]) <= 0)
			{
				return;
			}
			int num = int_0[int_2];
			int num3 = default(int);
			while (true)
			{
				int num2 = Class40.Class41.smethod_4(18);
				while (true)
				{
					switch (num2)
					{
					case 2:
						int_0[int_3] = num;
						num2 = 1;
						goto case 1;
					case 1:
						if (int_1 != null)
						{
							goto IL_0044;
						}
						if (true)
						{
							return;
						}
						goto case 3;
					case 0:
						int_0[int_2] = int_0[int_3];
						num2 = 2;
						goto case 2;
					case 3:
						while (true)
						{
							switch (Class40.Class41.smethod_4(14))
							{
							default:
								continue;
							case 1:
							{
								num3 = int_1[int_2];
								int num4 = 0;
								goto case 0;
							}
							case 0:
							{
								int_1[int_2] = int_1[int_3];
								int num4 = 2;
								break;
							}
							case 2:
								break;
							}
							break;
						}
						int_1[int_3] = num3;
						return;
					}
					break;
					IL_0044:
					num2 = Class40.Class41.smethod_4(19);
				}
			}
		}

		internal void method_1(int int_2, int int_3)
		{
			int num2 = default(int);
			int num4 = default(int);
			int value = default(int);
			do
			{
				int num = int_2;
				while (true)
				{
					switch (Class40.Class41.smethod_4(18))
					{
					default:
						continue;
					case 0:
					{
						num2 = int_3;
						int num3 = 5;
						goto case 5;
					}
					case 5:
					{
						num4 = num + (num2 - num >> 1);
						int num3 = 2;
						goto case 2;
					}
					case 2:
					{
						method_0(num, num4);
						int num3 = 4;
						goto case 4;
					}
					case 4:
					{
						method_0(num, num2);
						int num3 = 1;
						goto case 1;
					}
					case 1:
					{
						method_0(num4, num2);
						int num3 = 3;
						goto case 3;
					}
					case 3:
					{
						value = int_0[num4];
						int num3 = 6;
						break;
					}
					case 6:
						break;
					}
					break;
				}
				while (true)
				{
					IL_0166:
					if (int_0[num].CompareTo(value) < 0)
					{
						num++;
						continue;
					}
					while (value.CompareTo(int_0[num2]) < 0)
					{
						num2--;
					}
					if (num <= num2)
					{
						if (num < num2)
						{
							int num5 = int_0[num];
							while (true)
							{
								int num6 = Class40.Class41.smethod_4(14);
								while (true)
								{
									switch (num6)
									{
									case 2:
										if (int_1 != null)
										{
											num6 = Class40.Class41.smethod_4(19);
											continue;
										}
										if (true)
										{
											goto end_IL_00fc;
										}
										goto case 3;
									case 1:
										int_0[num] = int_0[num2];
										num6 = 0;
										goto case 0;
									case 0:
										int_0[num2] = num5;
										num6 = 2;
										goto case 2;
									case 3:
									{
										int num7 = int_1[num];
										int_1[num] = int_1[num2];
										int_1[num2] = num7;
										goto end_IL_00fc;
									}
									}
									break;
								}
								continue;
								end_IL_00fc:
								break;
							}
						}
						num++;
						while (true)
						{
							switch (Class40.Class41.smethod_4(19))
							{
							case 3:
							{
								num2--;
								int num8 = 0;
								goto case 0;
							}
							case 0:
							{
								if (num <= num2)
								{
									goto IL_0166;
								}
								int num8 = 2;
								goto end_IL_0135;
							}
							case 2:
								goto end_IL_0135;
							case 1:
								goto IL_0191;
							case 4:
								goto IL_0198;
							}
							continue;
							end_IL_0135:
							break;
						}
					}
					if (num2 - int_2 <= int_3 - num)
					{
						int num8 = 1;
						goto IL_0191;
					}
					if (num < int_3)
					{
						method_1(num, int_3);
					}
					int_3 = num2;
					break;
					IL_0191:
					if (int_2 < num2)
					{
						int num8 = 4;
						goto IL_0198;
					}
					goto IL_01a0;
					IL_01a0:
					int_2 = num;
					break;
					IL_0198:
					method_1(int_2, num2);
					goto IL_01a0;
				}
			}
			while (int_2 < int_3);
		}
	}

	private sealed class Class36
	{
		internal static int[] smethod_0(int[] int_0, int int_1)
		{
			int[] array = new int[int_0.Length];
			int[] array2 = new int[int_0.Length];
			int num2 = default(int);
			Struct1 @struct = default(Struct1);
			int num4 = default(int);
			int num6 = default(int);
			while (true)
			{
				int num = Class40.Class41.smethod_4(18);
				while (true)
				{
					switch (num)
					{
					case 0:
						goto IL_0014;
					case 2:
						if (num2 == 0)
						{
							goto IL_0051;
						}
						num = 1;
						goto case 1;
					case 3:
						num2++;
						goto IL_0051;
					case 1:
						{
							array[num2] = num2;
							num = 3;
							goto case 3;
						}
						IL_0051:
						if (num2 >= array.Length)
						{
							Array.Copy(int_0, array2, int_0.Length);
							while (true)
							{
								int num3 = Class40.Class41.smethod_4(18);
								while (true)
								{
									switch (num3)
									{
									case 3:
										goto IL_006f;
									case 2:
										@struct.method_1(0, array2.Length - 1);
										num3 = 3;
										goto IL_006f;
									case 0:
										@struct = new Struct1(array2, array);
										num3 = 2;
										goto case 2;
									case 1:
										if (num4 == 0)
										{
											goto IL_00ca;
										}
										num3 = 4;
										goto case 4;
									case 4:
										{
											num4++;
											goto IL_00ca;
										}
										IL_00ca:
										if (num4 >= array2.Length || array2[num4] != 0 || 1 == 0)
										{
											int[] array3 = new int[array2.Length - num4];
											Array.Copy(array2, num4, array3, 0, array3.Length);
											int[] array4 = ((array3.Length == 0 && 0 == 0) ? new int[0] : ((array3.Length != 1) ? smethod_1(array3, int_1) : new int[1] { 1 }));
											int[] array5 = new int[int_0.Length];
											while (true)
											{
												int num5 = Class40.Class41.smethod_4(14);
												while (true)
												{
													switch (num5)
													{
													case 4:
														if (num6 < array4.Length)
														{
															goto IL_013d;
														}
														return array5;
													case 2:
														goto IL_013d;
													case 3:
														num6++;
														num5 = 4;
														goto case 4;
													case 1:
														num6 = 0;
														num5 = 0;
														goto case 0;
													case 0:
														if (num6 != 0)
														{
															num5 = 2;
															goto IL_013d;
														}
														goto case 4;
													}
													break;
													IL_013d:
													array5[array[num6 + num4]] = array4[num6];
													num5 = Class40.Class41.smethod_4(19);
												}
											}
										}
										goto case 4;
									}
									break;
									IL_006f:
									num4 = 0;
									num3 = Class40.Class41.smethod_4(14);
								}
							}
						}
						goto case 1;
					}
					break;
					IL_0014:
					num2 = 0;
					num = Class40.Class41.smethod_4(29);
				}
			}
		}

		private static int[] smethod_1(int[] int_0, int int_1)
		{
			int num = int_0.Length;
			int[][] array = default(int[][]);
			int num3 = default(int);
			int[] array2 = default(int[]);
			int num5 = default(int);
			int num6 = default(int);
			int num8 = default(int);
			while (true)
			{
				int num2 = Class40.Class41.smethod_4(15);
				while (true)
				{
					switch (num2)
					{
					case 4:
						array = new int[int_1][];
						num2 = 0;
						goto case 0;
					case 0:
						array[0] = int_0;
						num2 = 2;
						goto IL_0017;
					case 2:
						goto IL_0017;
					case 5:
						num3 = 0;
						num2 = 1;
						goto case 1;
					case 1:
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
									int num4 = Class40.Class41.smethod_4(19);
									while (true)
									{
										switch (num4)
										{
										case 3:
											goto IL_00a0;
										case 4:
											array2 = new int[array3.Length / 2];
											num4 = 0;
											goto case 0;
										case 0:
											num5 = 0;
											num4 = 1;
											goto case 1;
										case 1:
											if (num5 == 0)
											{
												goto IL_00fd;
											}
											num4 = 2;
											goto case 2;
										case 5:
											num5++;
											goto IL_00fd;
										case 2:
											{
												array2[num5] = array3[num5 * 2] + array3[num5 * 2 + 1];
												num4 = 5;
												goto case 5;
											}
											IL_00fd:
											if (num5 >= array2.Length)
											{
												goto end_IL_00ce;
											}
											goto case 2;
										}
										break;
										IL_00a0:
										array[i] = array3;
										num4 = Class40.Class41.smethod_4(15);
									}
									continue;
									end_IL_00ce:
									break;
								}
							}
							int[] array4 = new int[num];
							while (true)
							{
								switch (Class40.Class41.smethod_4(14))
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
						goto case 3;
					}
					break;
					IL_0017:
					array2 = new int[int_0.Length / 2];
					num2 = Class40.Class41.smethod_4(16);
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
				int num = Class40.Class41.smethod_4(14);
				while (true)
				{
					switch (num)
					{
					case 3:
						if (int_0[num2] < int_1[num3])
						{
							goto IL_0039;
						}
						array[num4++] = int_1[num3++];
						goto case 6;
					case 6:
						if (num2 >= int_0.Length || num3 >= int_1.Length)
						{
							while (num2 < int_0.Length)
							{
								array[num4++] = int_0[num2++];
							}
							while (num3 < int_1.Length)
							{
								array[num4++] = int_1[num3++];
							}
							return array;
						}
						goto case 3;
					case 5:
						array[num4++] = int_0[num2++];
						num = 6;
						goto case 6;
					case 4:
						num3 = 0;
						num = 0;
						goto case 0;
					case 0:
						num4 = 0;
						num = 2;
						goto case 2;
					case 2:
						if (num4 != 0)
						{
							num = 3;
							goto case 3;
						}
						goto case 6;
					case 1:
						num2 = 0;
						num = 4;
						goto case 4;
					}
					break;
					IL_0039:
					num = Class40.Class41.smethod_4(16);
				}
			}
		}
	}

	private struct Struct2
	{
		internal Struct3 struct3_0;

		internal ushort ushort_0;
	}

	internal static Struct3[] struct3_0;

	internal static Struct3[] struct3_1;

	internal static Class39 class39_0;

	internal static readonly int[] int_0;

	internal static readonly int[] int_1;

	internal static readonly int[] int_2;

	internal static readonly int[] int_3;

	internal static readonly int[] int_4;

	static Class35()
	{
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num = Class40.Class41.smethod_4(18);
			while (true)
			{
				switch (num)
				{
				case 16:
					int_0 = new int[19];
					int_0[0] = 16;
					int_0[1] = 17;
					num = 1;
					goto case 1;
				case 1:
					int_0[2] = 18;
					int_0[4] = 8;
					int_0[5] = 7;
					num = 3;
					goto case 3;
				case 3:
					int_0[6] = 9;
					while (true)
					{
						int num7 = Class40.Class41.smethod_4(14);
						while (true)
						{
							switch (num7)
							{
							case 1:
								int_0[7] = 6;
								num7 = Class40.Class41.smethod_4(29);
								continue;
							case 2:
								int_0[8] = 10;
								num7 = 0;
								goto case 0;
							case 0:
								num = Class40.Class41.smethod_4(25);
								num7 = 3;
								goto end_IL_0076;
							case 3:
								goto end_IL_0076;
							}
							break;
						}
						continue;
						end_IL_0076:
						break;
					}
					continue;
				case 11:
					struct3_0 = new Struct3[288];
					struct3_1 = new Struct3[32];
					num = 16;
					goto case 16;
				case 0:
					num = 11;
					goto case 11;
				case 6:
					int_0[9] = 5;
					int_0[10] = 11;
					int_0[11] = 4;
					num = 14;
					goto case 14;
				case 14:
					int_0[12] = 12;
					int_0[13] = 3;
					int_0[14] = 13;
					num = 8;
					goto case 8;
				case 8:
					int_0[15] = 2;
					int_0[16] = 14;
					int_0[17] = 1;
					num = 13;
					goto case 13;
				case 13:
					int_0[18] = 15;
					int_1 = new int[29];
					int_1[0] = 3;
					num = 18;
					goto case 18;
				case 18:
					int_1[1] = 4;
					int_1[2] = 5;
					int_1[3] = 6;
					num = 4;
					goto case 4;
				case 4:
					int_1[4] = 7;
					int_1[5] = 8;
					int_1[6] = 9;
					num = 7;
					goto case 7;
				case 7:
					int_1[7] = 10;
					int_1[8] = 11;
					int_1[9] = 13;
					num = 15;
					goto case 15;
				case 15:
					int_1[10] = 15;
					int_1[11] = 17;
					int_1[12] = 19;
					num = 2;
					goto case 2;
				case 2:
					int_1[13] = 23;
					int_1[14] = 27;
					int_1[15] = 31;
					num = 12;
					goto case 12;
				case 12:
					int_1[16] = 35;
					int_1[17] = 43;
					int_1[18] = 51;
					num = 9;
					goto case 9;
				case 9:
					int_1[19] = 59;
					int_1[20] = 67;
					int_1[21] = 83;
					num = 5;
					goto case 5;
				case 5:
					int_1[22] = 99;
					int_1[23] = 115;
					int_1[24] = 131;
					num = 19;
					goto case 19;
				case 19:
					int_1[25] = 163;
					int_1[26] = 195;
					int_1[27] = 227;
					num = 17;
					goto case 17;
				case 17:
					int_1[28] = 258;
					int_2 = new int[29];
					num2 = 8;
					num = 10;
					goto case 10;
				case 10:
					num3 = 0;
					goto IL_0309;
				case 20:
					{
						if (true)
						{
							goto IL_02fd;
						}
						goto IL_0316;
					}
					IL_0309:
					if (num2 < 28)
					{
						if (num2 % 4 == 0)
						{
							goto IL_0316;
						}
						num = 20;
						goto case 20;
					}
					int_3 = new int[30];
					while (true)
					{
						int num4 = Class40.Class41.smethod_4(29);
						while (true)
						{
							switch (num4)
							{
							case 15:
								goto IL_0338;
							case 14:
								int_3[8] = 17;
								int_3[9] = 25;
								num4 = 15;
								goto IL_0338;
							case 13:
								int_3[6] = 9;
								int_3[7] = 13;
								num4 = 14;
								goto case 14;
							case 8:
								int_3[4] = 5;
								int_3[5] = 7;
								num4 = 13;
								goto case 13;
							case 6:
								int_3[2] = 3;
								int_3[3] = 4;
								num4 = 8;
								goto case 8;
							case 2:
								int_3[0] = 1;
								int_3[1] = 2;
								num4 = 6;
								goto case 6;
							case 3:
								int_3[12] = 65;
								int_3[13] = 97;
								num4 = 4;
								goto case 4;
							case 4:
								int_3[14] = 129;
								int_3[15] = 193;
								num4 = 10;
								goto case 10;
							case 10:
								int_3[16] = 257;
								int_3[17] = 385;
								num4 = 7;
								goto case 7;
							case 7:
								int_3[18] = 513;
								int_3[19] = 769;
								num4 = 12;
								goto case 12;
							case 12:
								int_3[20] = 1025;
								int_3[21] = 1537;
								num4 = 5;
								goto case 5;
							case 5:
								int_3[22] = 2049;
								int_3[23] = 3073;
								num4 = 0;
								goto case 0;
							case 0:
								int_3[24] = 4097;
								int_3[25] = 6145;
								num4 = 11;
								goto case 11;
							case 11:
								int_3[26] = 8193;
								int_3[27] = 12289;
								num4 = 9;
								goto case 9;
							case 9:
								int_3[28] = 16385;
								int_3[29] = 24577;
								num4 = 1;
								goto case 1;
							case 1:
								int_4 = new int[30];
								num5 = 4;
								num4 = 16;
								goto case 16;
							case 16:
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
										struct3_0[i].int_0 = 48 + i;
										struct3_0[i].int_1 = 8;
									}
									for (int j = 144; j <= 255; j++)
									{
										struct3_0[j].int_0 = 400 + j - 144;
										struct3_0[j].int_1 = 9;
									}
									for (int k = 256; k <= 279; k++)
									{
										struct3_0[k].int_0 = k - 256;
										struct3_0[k].int_1 = 7;
									}
									for (int l = 280; l <= 287; l++)
									{
										struct3_0[l].int_0 = 192 + l - 280;
										struct3_0[l].int_1 = 8;
									}
									for (int m = 0; m <= 31; m++)
									{
										struct3_1[m].int_0 = m;
										struct3_1[m].int_1 = 5;
									}
									class39_0 = smethod_4(struct3_0, struct3_1);
									return;
								}
								goto case 17;
							}
							break;
							IL_0338:
							int_3[10] = 33;
							int_3[11] = 49;
							num4 = Class40.Class41.smethod_4(19);
						}
					}
					IL_0316:
					num3++;
					goto IL_02fd;
					IL_02fd:
					int_2[num2] = num3;
					num2++;
					goto IL_0309;
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
			int num2 = Class40.Class41.smethod_4(18);
			while (true)
			{
				switch (num2)
				{
				case 0:
					goto IL_0004;
				case 2:
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
						num += int_5[num3] * int_6[num3];
						num2 = 3;
						goto case 3;
					}
					IL_0039:
					if (num3 >= int_5.Length)
					{
						return num;
					}
					goto case 1;
				}
				break;
				IL_0004:
				num3 = 0;
				num2 = Class40.Class41.smethod_4(29);
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
			int num2 = Class40.Class41.smethod_4(18);
			while (true)
			{
				switch (num2)
				{
				case 0:
					goto IL_0004;
				case 2:
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
						num += int_5[num3] * struct3_0[num3].int_1;
						num2 = 3;
						goto case 3;
					}
					IL_0039:
					if (num3 >= int_5.Length)
					{
						while (true)
						{
							int num4 = Class40.Class41.smethod_4(18);
							while (true)
							{
								switch (num4)
								{
								case 0:
									goto IL_005a;
								case 1:
									if (num5 == 0)
									{
										goto IL_0093;
									}
									num4 = 2;
									goto case 2;
								case 3:
									num5++;
									goto IL_0093;
								case 2:
									{
										num += int_6[num5] * struct3_1[num5].int_1;
										num4 = 3;
										goto case 3;
									}
									IL_0093:
									if (num5 >= int_6.Length)
									{
										return num;
									}
									goto case 2;
								}
								break;
								IL_005a:
								num5 = 0;
								num4 = Class40.Class41.smethod_4(14);
							}
						}
					}
					goto case 1;
				}
				break;
				IL_0004:
				num3 = 0;
				num2 = Class40.Class41.smethod_4(29);
			}
		}
	}

	internal static Struct3[] smethod_2(int[] int_5)
	{
		Struct3[] array = new Struct3[int_5.Length];
		int num2 = default(int);
		while (true)
		{
			int num = Class40.Class41.smethod_4(14);
			while (true)
			{
				switch (num)
				{
				case 3:
					num2++;
					goto IL_000f;
				case 2:
					goto IL_0015;
				case 1:
					num2 = 0;
					num = 0;
					goto case 0;
				case 0:
					{
						if (num2 != 0)
						{
							num = 2;
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
				num = Class40.Class41.smethod_4(19);
			}
		}
	}

	internal static void smethod_3(Struct3[] struct3_2)
	{
		int num = struct3_2[0].int_1;
		for (int i = 1; i < struct3_2.Length; i++)
		{
			if (num < struct3_2[i].int_1)
			{
				num = struct3_2[i].int_1;
			}
		}
		int[] array = new int[num + 1];
		int num3 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		int num9 = default(int);
		while (true)
		{
			int num2 = Class40.Class41.smethod_4(18);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (num3 != 0)
					{
						goto IL_004c;
					}
					goto IL_0081;
				case 0:
					num3 = 0;
					num2 = 1;
					goto case 1;
				case 2:
					array[struct3_2[num3].int_1]++;
					num2 = 3;
					goto case 3;
				case 3:
					{
						num3++;
						goto IL_0081;
					}
					IL_0081:
					if (num3 >= struct3_2.Length)
					{
						int[] array2 = new int[num + 1];
						while (true)
						{
							switch (Class40.Class41.smethod_4(19))
							{
							case 3:
							{
								num4 = 0;
								int num5 = 0;
								goto case 0;
							}
							case 0:
							{
								array[0] = 0;
								int num5 = 2;
								goto case 2;
							}
							case 2:
							{
								num6 = 1;
								int num5 = 1;
								goto case 1;
							}
							case 1:
							{
								if (num6 != 0)
								{
									goto IL_0103;
								}
								int num5 = 5;
								goto case 5;
							}
							case 6:
								num6++;
								goto IL_0103;
							case 4:
							{
								array2[num6] = num4;
								int num5 = 6;
								goto case 6;
							}
							case 5:
								{
									num4 = num4 + array[num6 - 1] << 1;
									int num5 = 4;
									goto case 4;
								}
								IL_0103:
								if (num6 > num)
								{
									int num7 = 0;
									while (true)
									{
										switch (Class40.Class41.smethod_4(18))
										{
										case 0:
										{
											if (num7 == 0)
											{
												goto IL_015b;
											}
											int num8 = 1;
											goto case 1;
										}
										case 3:
											if (0 == 0)
											{
												struct3_2[num7].int_0 = array2[num9];
												array2[num9]++;
											}
											goto IL_0155;
										case 2:
											if (num9 != 0)
											{
												int num8 = 3;
												goto case 3;
											}
											goto IL_0155;
										case 1:
											{
												num9 = struct3_2[num7].int_1;
												int num8 = 2;
												goto case 2;
											}
											IL_015b:
											if (num7 >= struct3_2.Length)
											{
												return;
											}
											goto case 1;
											IL_0155:
											num7++;
											goto IL_015b;
										}
									}
								}
								goto case 5;
							}
						}
					}
					goto case 2;
				}
				break;
				IL_004c:
				num2 = Class40.Class41.smethod_4(29);
			}
		}
	}

	internal static Class39 smethod_4(Struct3[] struct3_2, Struct3[] struct3_3)
	{
		return new Class39
		{
			class38_0 = smethod_5(struct3_2),
			class38_1 = smethod_5(struct3_3)
		};
	}

	internal static Class38 smethod_5(Struct3[] struct3_2)
	{
		Struct2[] array = new Struct2[struct3_2.Length];
		int int_ = 0;
		int num2 = default(int);
		Struct2 @struct = default(Struct2);
		while (true)
		{
			int num = Class40.Class41.smethod_4(18);
			while (true)
			{
				switch (num)
				{
				case 3:
					if (num2 != 0)
					{
						goto IL_0010;
					}
					goto IL_0056;
				case 0:
					num2 = 0;
					num = 3;
					goto case 3;
				case 2:
					if (struct3_2[num2].int_1 <= 0)
					{
						goto IL_006b;
					}
					num = 1;
					goto case 1;
				case 1:
					@struct = default(Struct2);
					num = 4;
					goto case 4;
				case 4:
					{
						while (true)
						{
							switch (Class40.Class41.smethod_4(18))
							{
							case 2:
								break;
							case 1:
							{
								@struct.ushort_0 = (ushort)num2;
								int num3 = 2;
								break;
							}
							case 0:
							{
								@struct.struct3_0 = struct3_2[num2];
								int num3 = 1;
								goto case 1;
							}
							default:
								continue;
							}
							break;
						}
						array[int_++] = @struct;
						goto IL_006b;
					}
					IL_0056:
					if (num2 >= struct3_2.Length)
					{
						return smethod_6(array, int_, 0, 0);
					}
					goto case 2;
					IL_006b:
					num2++;
					goto IL_0056;
				}
				break;
				IL_0010:
				num = Class40.Class41.smethod_4(29);
			}
		}
	}

	private static Class38 smethod_6(Struct2[] struct2_0, int int_5, int int_6, int int_7)
	{
		Struct2[] array = new Struct2[int_5];
		Class38 @class = default(Class38);
		Struct2[] array2 = default(Struct2[]);
		int num2 = default(int);
		Struct2 @struct = default(Struct2);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = Class40.Class41.smethod_4(29);
			while (true)
			{
				switch (num)
				{
				case 7:
					goto IL_0009;
				case 4:
					@class = new Class38();
					num = 1;
					goto case 1;
				case 1:
					@class.bool_0 = false;
					num = 7;
					goto IL_0009;
				case 2:
					array2 = new Struct2[int_5];
					num = 4;
					goto case 4;
				case 9:
					num2 = 0;
					num = 3;
					goto case 3;
				case 3:
					if (num2 == 0)
					{
						goto IL_0095;
					}
					num = 10;
					goto case 10;
				case 11:
					num2++;
					goto IL_0095;
				case 8:
					if (@struct.struct3_0.int_1 == int_7)
					{
						num = 6;
						goto case 6;
					}
					goto IL_00e3;
				case 6:
					if (@struct.struct3_0.int_0 == int_6)
					{
						num = 0;
						goto case 0;
					}
					goto IL_00e3;
				case 0:
					@class.bool_0 = true;
					num = 5;
					goto case 5;
				case 5:
					@class.ushort_0 = @struct.ushort_0;
					num = 11;
					goto case 11;
				case 10:
					{
						@struct = struct2_0[num2];
						num = 8;
						goto case 8;
					}
					IL_0095:
					if (num2 >= int_5)
					{
						if (!@class.bool_0 && 0 == 0)
						{
							if (num3 > 0)
							{
								@class.class38_0 = smethod_6(array, num3, int_6 << 1, int_7 + 1);
							}
							if (num4 > 0)
							{
								@class.class38_1 = smethod_6(array2, num4, (int_6 << 1) | 1, int_7 + 1);
							}
						}
						return @class;
					}
					goto case 10;
					IL_00e3:
					if (((uint)(@struct.struct3_0.int_0 >> @struct.struct3_0.int_1 - int_7 - 1) & (true ? 1u : 0u)) != 0 || 1 == 0)
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
				IL_0009:
				num3 = 0;
				num4 = 0;
				num = Class40.Class41.smethod_4(17);
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
			switch (Class40.Class41.smethod_4(18))
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
			switch (Class40.Class41.smethod_4(18))
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
		return Class36.smethod_0(int_5, int_6);
	}

	internal static int[] smethod_11(int[] int_5)
	{
		return Class36.smethod_0(int_5, 15);
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
		Class37 @class = new Class37();
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
						int num3 = Class40.Class41.smethod_4(18);
						while (true)
						{
							switch (num3)
							{
							case 2:
								if (num2 < 138)
								{
									num3 = Class40.Class41.smethod_4(14);
									continue;
								}
								goto case 3;
							case 0:
								if (num + num2 < int_7)
								{
									num3 = 2;
									goto case 2;
								}
								goto case 3;
							case 1:
								if (int_5[int_6 + num + num2] != 0)
								{
									num3 = 3;
								}
								else if (true)
								{
									goto end_IL_0056;
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
								goto end_IL_0075;
							}
							break;
						}
						continue;
						end_IL_0056:
						break;
					}
					continue;
					end_IL_0075:
					break;
				}
				continue;
			}
			int num4 = int_5[int_6 + num++];
			while (true)
			{
				int num5 = Class40.Class41.smethod_4(29);
				while (true)
				{
					switch (num5)
					{
					case 2:
						@class.method_0(num4);
						num5 = Class40.Class41.smethod_4(14);
						continue;
					case 1:
						num6 = 0;
						num5 = 0;
						goto case 0;
					case 0:
						if (num6 == 0)
						{
							goto IL_011e;
						}
						num5 = 3;
						goto case 3;
					case 3:
						{
							num6++;
							goto IL_011e;
						}
						IL_011e:
						if (num + num6 >= int_7 || num6 >= 6 || int_5[int_6 + num + num6] != num4)
						{
							goto end_IL_0104;
						}
						goto case 3;
					}
					break;
				}
				continue;
				end_IL_0104:
				break;
			}
			if (num6 < 3)
			{
				continue;
			}
			@class.method_0(16);
			while (true)
			{
				switch (Class40.Class41.smethod_4(14))
				{
				default:
					continue;
				case 1:
				{
					@class.method_0(num6 - 3);
					int num7 = 0;
					goto case 0;
				}
				case 0:
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
