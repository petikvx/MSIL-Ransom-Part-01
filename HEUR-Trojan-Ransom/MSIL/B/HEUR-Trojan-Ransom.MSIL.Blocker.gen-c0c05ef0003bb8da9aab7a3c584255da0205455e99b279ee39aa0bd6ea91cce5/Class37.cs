using System;

internal sealed class Class37
{
	private struct Struct2
	{
		private int[] int_0;

		private int[] int_1;

		internal Struct2(int[] int_2, int[] int_3)
		{
			int_0 = int_2;
			int_1 = int_3;
		}

		internal void method_0(int int_2, int int_3)
		{
			if (int_2 == int_3)
			{
				return;
			}
			int num3 = default(int);
			int num4 = default(int);
			while (true)
			{
				switch (Class42.smethod_1(37))
				{
				case 1:
					if (int_0[int_2].CompareTo(int_0[int_3]) > 0)
					{
						int num = 0;
						goto case 0;
					}
					return;
				case 0:
				{
					num3 = int_0[int_2];
					int num = 2;
					goto case 2;
				}
				case 2:
					while (true)
					{
						switch (Class42.smethod_1(38))
						{
						case 2:
						{
							int_0[int_2] = int_0[int_3];
							int num2 = 0;
							goto case 0;
						}
						case 0:
						{
							int_0[int_3] = num3;
							int num2 = 1;
							goto case 1;
						}
						case 1:
							if (int_1 != null)
							{
								int num2 = 3;
							}
							else if (true)
							{
								return;
							}
							goto case 3;
						case 3:
							while (true)
							{
								switch (Class42.smethod_1(42))
								{
								default:
									continue;
								case 0:
								{
									num4 = int_1[int_2];
									int num5 = 1;
									goto case 1;
								}
								case 1:
								{
									int_1[int_2] = int_1[int_3];
									int num5 = 2;
									break;
								}
								case 2:
									break;
								}
								break;
							}
							int_1[int_3] = num4;
							return;
						}
					}
				}
			}
		}

		internal void method_1(int int_2, int int_3)
		{
			int num3 = default(int);
			int num4 = default(int);
			int value = default(int);
			do
			{
				int num = int_2;
				while (true)
				{
					int num2 = Class42.smethod_1(45);
					while (true)
					{
						switch (num2)
						{
						case 3:
							num3 = int_3;
							num2 = 0;
							goto case 0;
						case 0:
							num4 = num + (num3 - num >> 1);
							num2 = 2;
							goto IL_0016;
						case 2:
							goto IL_0016;
						case 1:
							method_0(num, num3);
							num2 = 5;
							goto case 5;
						case 5:
							method_0(num4, num3);
							num2 = 4;
							goto case 4;
						case 4:
							value = int_0[num4];
							num2 = 6;
							goto case 6;
						case 6:
							while (true)
							{
								if (int_0[num].CompareTo(value) < 0)
								{
									num++;
									continue;
								}
								while (value.CompareTo(int_0[num3]) < 0)
								{
									num3--;
								}
								if (num <= num3)
								{
									if (num < num3)
									{
										int num5 = int_0[num];
										while (true)
										{
											int num6 = Class42.smethod_1(38);
											while (true)
											{
												switch (num6)
												{
												case 2:
													int_0[num] = int_0[num3];
													num6 = 1;
													goto case 1;
												case 1:
													int_0[num3] = num5;
													num6 = Class42.smethod_1(42);
													continue;
												case 0:
													if (int_1 != null)
													{
														num6 = 3;
													}
													else if (true)
													{
														goto end_IL_00f2;
													}
													goto case 3;
												case 3:
												{
													int num7 = int_1[num];
													int_1[num] = int_1[num3];
													int_1[num3] = num7;
													goto end_IL_00f2;
												}
												}
												break;
											}
											continue;
											end_IL_00f2:
											break;
										}
									}
									num++;
									goto IL_014a;
								}
								goto IL_0184;
								IL_0184:
								int num8;
								if (num3 - int_2 <= int_3 - num)
								{
									num8 = 0;
									goto IL_0170;
								}
								if (num < int_3)
								{
									method_1(num, int_3);
								}
								int_3 = num3;
								break;
								IL_0170:
								if (int_2 < num3)
								{
									num8 = Class42.smethod_1(47);
									goto IL_0153;
								}
								goto IL_01b3;
								IL_01b3:
								int_2 = num;
								break;
								IL_01ab:
								method_1(int_2, num3);
								goto IL_01b3;
								IL_014a:
								num8 = Class42.smethod_1(45);
								goto IL_0153;
								IL_0153:
								switch (num8)
								{
								case 0:
									goto IL_0170;
								case 3:
									num3--;
									num8 = 2;
									goto case 2;
								case 2:
									if (num <= num3)
									{
										continue;
									}
									num8 = 1;
									goto IL_0184;
								case 1:
									goto IL_0184;
								case 4:
									goto IL_01ab;
								}
								goto IL_014a;
							}
							goto end_IL_004a;
						}
						break;
						IL_0016:
						method_0(num, num4);
						num2 = Class42.smethod_1(37);
					}
					continue;
					end_IL_004a:
					break;
				}
			}
			while (int_2 < int_3);
		}
	}

	private sealed class Class38
	{
		internal static int[] smethod_0(int[] int_0, int int_1)
		{
			int[] array = new int[int_0.Length];
			int num2 = default(int);
			int[] array2 = default(int[]);
			Struct2 @struct = default(Struct2);
			int num4 = default(int);
			int num6 = default(int);
			while (true)
			{
				int num = Class42.smethod_1(38);
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
							switch (Class42.smethod_1(37))
							{
							default:
								continue;
							case 1:
							{
								@struct = new Struct2(array2, array);
								int num3 = 0;
								goto case 0;
							}
							case 0:
							{
								@struct.method_1(0, array2.Length - 1);
								int num3 = 2;
								goto case 2;
							}
							case 2:
							{
								num4 = 0;
								int num3 = 3;
								goto case 3;
							}
							case 3:
							{
								if (num4 == 0)
								{
									goto IL_00c5;
								}
								int num3 = 4;
								goto case 4;
							}
							case 4:
								{
									num4++;
									goto IL_00c5;
								}
								IL_00c5:
								if (num4 >= array2.Length || array2[num4] != 0 || 1 == 0)
								{
									break;
								}
								goto case 4;
							}
							break;
						}
						array3 = new int[array2.Length - num4];
						Array.Copy(array2, num4, array3, 0, array3.Length);
						array4 = ((array3.Length == 0 && 0 == 0) ? new int[0] : ((array3.Length != 1) ? smethod_1(array3, int_1) : new int[1] { 1 }));
						array5 = new int[int_0.Length];
						while (true)
						{
							int num5 = Class42.smethod_1(42);
							while (true)
							{
								switch (num5)
								{
								case 3:
									num6++;
									goto IL_0136;
								case 2:
									goto IL_013e;
								case 1:
									if (num6 != 0)
									{
										num5 = 2;
										goto IL_013e;
									}
									goto IL_0136;
								case 0:
									{
										num6 = 0;
										num5 = 1;
										goto case 1;
									}
									IL_0136:
									if (num6 < array4.Length)
									{
										goto IL_013e;
									}
									return array5;
								}
								break;
								IL_013e:
								array5[array[num6 + num4]] = array4[num6];
								num5 = Class42.smethod_1(45);
							}
						}
					}
					break;
					IL_0018:
					array[num2] = num2;
					num = Class42.smethod_1(47);
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
				int num2 = Class42.smethod_1(36);
				while (true)
				{
					switch (num2)
					{
					case 5:
						goto IL_0006;
					case 2:
						array[0] = int_0;
						num2 = 3;
						goto case 3;
					case 3:
						array2 = new int[int_0.Length / 2];
						num2 = 1;
						goto case 1;
					case 1:
						num3 = 0;
						num2 = 0;
						goto case 0;
					case 0:
						if (num3 == 0)
						{
							goto IL_006e;
						}
						num2 = 4;
						goto case 4;
					case 6:
						num3++;
						goto IL_006e;
					case 4:
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
									int num4 = Class42.smethod_1(38);
									while (true)
									{
										switch (num4)
										{
										case 2:
											goto IL_00a0;
										case 3:
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
											num4 = 4;
											goto case 4;
										case 5:
											num5++;
											goto IL_00fd;
										case 4:
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
											goto case 4;
										}
										break;
										IL_00a0:
										array[i] = array3;
										num4 = Class42.smethod_1(45);
									}
									continue;
									end_IL_00ce:
									break;
								}
							}
							int[] array4 = new int[num];
							while (true)
							{
								switch (Class42.smethod_1(37))
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
						goto case 4;
					}
					break;
					IL_0006:
					array = new int[int_1][];
					num2 = Class42.smethod_1(38);
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
				int num = Class42.smethod_1(38);
				while (true)
				{
					switch (num)
					{
					case 2:
						goto IL_000f;
					case 3:
						num2 = 0;
						num = 1;
						goto case 1;
					case 1:
						num3 = 0;
						num = 0;
						goto case 0;
					case 0:
						if (num3 != 0)
						{
							num = 4;
							goto case 4;
						}
						goto case 6;
					case 4:
						if (int_0[num4] < int_1[num2])
						{
							num = 5;
							goto case 5;
						}
						array[num3++] = int_1[num2++];
						goto case 6;
					case 5:
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
					num = Class42.smethod_1(45);
				}
			}
		}
	}

	private struct Struct3
	{
		internal Struct4 struct4_0;

		internal ushort ushort_0;
	}

	internal static Struct4[] struct4_0;

	internal static Struct4[] struct4_1;

	internal static Class41 class41_0;

	internal static readonly int[] int_0;

	internal static readonly int[] int_1;

	internal static readonly int[] int_2;

	internal static readonly int[] int_3;

	internal static readonly int[] int_4;

	static Class37()
	{
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num = Class42.smethod_1(47);
			while (true)
			{
				switch (num)
				{
				case 18:
					int_0[2] = 18;
					int_0[4] = 8;
					int_0[5] = 7;
					num = 1;
					goto case 1;
				case 1:
					int_0[6] = 9;
					int_0[7] = 6;
					int_0[8] = 10;
					num = 13;
					goto case 13;
				case 13:
					int_0[9] = 5;
					int_0[10] = 11;
					int_0[11] = 4;
					num = 7;
					goto case 7;
				case 7:
					int_0[12] = 12;
					int_0[13] = 3;
					int_0[14] = 13;
					num = 6;
					goto case 6;
				case 6:
					int_0[15] = 2;
					int_0[16] = 14;
					int_0[17] = 1;
					num = 14;
					goto case 14;
				case 14:
					int_0[18] = 15;
					int_1 = new int[29];
					int_1[0] = 3;
					num = 10;
					goto case 10;
				case 10:
					int_1[1] = 4;
					int_1[2] = 5;
					int_1[3] = 6;
					num = 3;
					goto case 3;
				case 3:
					int_1[4] = 7;
					int_1[5] = 8;
					int_1[6] = 9;
					num = 15;
					goto case 15;
				case 15:
					int_1[7] = 10;
					while (true)
					{
						int num7 = Class42.smethod_1(38);
						while (true)
						{
							switch (num7)
							{
							case 2:
								int_1[8] = 11;
								num7 = 1;
								goto case 1;
							case 1:
								int_1[9] = 13;
								num7 = 0;
								goto case 0;
							case 0:
								num = Class42.smethod_1(41);
								num7 = Class42.smethod_1(45);
								continue;
							case 3:
								goto end_IL_0146;
							}
							break;
						}
						continue;
						end_IL_0146:
						break;
					}
					continue;
				case 11:
					struct4_0 = new Struct4[288];
					struct4_1 = new Struct4[32];
					num = 8;
					goto case 8;
				case 8:
					int_0 = new int[19];
					int_0[0] = 16;
					int_0[1] = 17;
					num = 18;
					goto case 18;
				case 4:
					num = 11;
					goto case 11;
				case 12:
					int_1[10] = 15;
					int_1[11] = 17;
					int_1[12] = 19;
					num = 9;
					goto case 9;
				case 9:
					int_1[13] = 23;
					int_1[14] = 27;
					int_1[15] = 31;
					num = 0;
					goto case 0;
				case 0:
					int_1[16] = 35;
					int_1[17] = 43;
					int_1[18] = 51;
					num = 2;
					goto case 2;
				case 2:
					int_1[19] = 59;
					int_1[20] = 67;
					int_1[21] = 83;
					num = 16;
					goto case 16;
				case 16:
					int_1[22] = 99;
					int_1[23] = 115;
					int_1[24] = 131;
					num = 5;
					goto case 5;
				case 5:
					int_1[25] = 163;
					int_1[26] = 195;
					int_1[27] = 227;
					num = 19;
					goto case 19;
				case 19:
					int_1[28] = 258;
					int_2 = new int[29];
					num2 = 8;
					num = 17;
					goto case 17;
				case 17:
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
						int num4 = Class42.smethod_1(49);
						while (true)
						{
							switch (num4)
							{
							case 15:
								goto IL_0335;
							case 12:
								int_3[4] = 5;
								int_3[5] = 7;
								num4 = 10;
								goto case 10;
							case 10:
								int_3[6] = 9;
								int_3[7] = 13;
								num4 = 9;
								goto case 9;
							case 9:
								int_3[8] = 17;
								int_3[9] = 25;
								num4 = 4;
								goto case 4;
							case 4:
								int_3[10] = 33;
								int_3[11] = 49;
								num4 = 15;
								goto IL_0335;
							case 6:
								int_3[0] = 1;
								int_3[1] = 2;
								num4 = 2;
								goto case 2;
							case 2:
								int_3[2] = 3;
								int_3[3] = 4;
								num4 = 12;
								goto case 12;
							case 1:
								int_3[14] = 129;
								int_3[15] = 193;
								num4 = 14;
								goto case 14;
							case 14:
								int_3[16] = 257;
								int_3[17] = 385;
								num4 = 0;
								goto case 0;
							case 0:
								int_3[18] = 513;
								int_3[19] = 769;
								num4 = 7;
								goto case 7;
							case 7:
								int_3[20] = 1025;
								int_3[21] = 1537;
								num4 = 13;
								goto case 13;
							case 13:
								int_3[22] = 2049;
								int_3[23] = 3073;
								num4 = 11;
								goto case 11;
							case 11:
								int_3[24] = 4097;
								int_3[25] = 6145;
								num4 = 8;
								goto case 8;
							case 8:
								int_3[26] = 8193;
								int_3[27] = 12289;
								num4 = 3;
								goto case 3;
							case 3:
								int_3[28] = 16385;
								int_3[29] = 24577;
								num4 = 16;
								goto case 16;
							case 16:
								int_4 = new int[30];
								num5 = 4;
								num4 = 5;
								goto case 5;
							case 5:
								num6 = 0;
								goto IL_054b;
							case 17:
								{
									if (num5 % 2 == 0 && 0 == 0)
									{
										num6++;
									}
									int_4[num5] = num6;
									num5++;
									goto IL_054b;
								}
								IL_054b:
								if (num5 >= 30)
								{
									for (int i = 0; i <= 143; i++)
									{
										struct4_0[i].int_0 = 48 + i;
										struct4_0[i].int_1 = 8;
									}
									for (int j = 144; j <= 255; j++)
									{
										struct4_0[j].int_0 = 400 + j - 144;
										struct4_0[j].int_1 = 9;
									}
									for (int k = 256; k <= 279; k++)
									{
										struct4_0[k].int_0 = k - 256;
										struct4_0[k].int_1 = 7;
									}
									for (int l = 280; l <= 287; l++)
									{
										struct4_0[l].int_0 = 192 + l - 280;
										struct4_0[l].int_1 = 8;
									}
									for (int m = 0; m <= 31; m++)
									{
										struct4_1[m].int_0 = m;
										struct4_1[m].int_1 = 5;
									}
									class41_0 = smethod_4(struct4_0, struct4_1);
									return;
								}
								goto case 17;
							}
							break;
							IL_0335:
							int_3[12] = 65;
							int_3[13] = 97;
							num4 = Class42.smethod_1(37);
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
			int num2 = Class42.smethod_1(37);
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
				case 1:
					num3 = 0;
					num2 = 2;
					goto case 2;
				case 0:
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
					goto case 0;
				}
				break;
				IL_0007:
				num2 = Class42.smethod_1(42);
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
			int num2 = Class42.smethod_1(42);
			while (true)
			{
				switch (num2)
				{
				case 3:
					num3++;
					goto IL_0008;
				case 2:
					goto IL_000e;
				case 1:
					if (num3 != 0)
					{
						num2 = 2;
						goto IL_000e;
					}
					goto IL_0008;
				case 0:
					{
						num3 = 0;
						num2 = 1;
						goto case 1;
					}
					IL_0008:
					if (num3 < int_5.Length)
					{
						goto IL_000e;
					}
					while (true)
					{
						int num4 = Class42.smethod_1(38);
						while (true)
						{
							switch (num4)
							{
							case 2:
								num5 = 0;
								num4 = 0;
								goto case 0;
							case 0:
								if (num5 != 0)
								{
									goto IL_0064;
								}
								goto IL_008f;
							case 1:
								num += int_6[num5] * struct4_1[num5].int_1;
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
								goto case 1;
							}
							break;
							IL_0064:
							num4 = Class42.smethod_1(37);
						}
					}
				}
				break;
				IL_000e:
				num += int_5[num3] * struct4_0[num3].int_1;
				num2 = Class42.smethod_1(45);
			}
		}
	}

	internal static Struct4[] smethod_2(int[] int_5)
	{
		Struct4[] array = new Struct4[int_5.Length];
		int num = default(int);
		while (true)
		{
			switch (Class42.smethod_1(42))
			{
			case 0:
			{
				num = 0;
				int num2 = 2;
				goto case 2;
			}
			case 2:
			{
				if (num == 0)
				{
					goto IL_003b;
				}
				int num2 = 1;
				goto case 1;
			}
			case 3:
				num++;
				goto IL_003b;
			case 1:
				{
					array[num].int_1 = int_5[num];
					int num2 = 3;
					goto case 3;
				}
				IL_003b:
				if (num >= int_5.Length)
				{
					smethod_3(array);
					return array;
				}
				goto case 1;
			}
		}
	}

	internal static void smethod_3(Struct4[] struct4_2)
	{
		int num = struct4_2[0].int_1;
		int num2 = default(int);
		int num4 = default(int);
		int num9 = default(int);
		int num7 = default(int);
		while (true)
		{
			switch (Class42.smethod_1(37))
			{
			case 1:
			{
				num2 = 1;
				int num3 = 2;
				goto case 2;
			}
			case 2:
			{
				if (num2 != 0)
				{
					goto IL_0055;
				}
				int num3 = 0;
				goto case 0;
			}
			case 3:
				num = struct4_2[num2].int_1;
				goto IL_004f;
			case 0:
				{
					if (num < struct4_2[num2].int_1)
					{
						int num3 = 3;
						goto case 3;
					}
					goto IL_004f;
				}
				IL_0055:
				if (num2 >= struct4_2.Length)
				{
					int[] array = new int[num + 1];
					while (true)
					{
						switch (Class42.smethod_1(38))
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
								goto IL_00b5;
							}
							int num5 = 0;
							goto case 0;
						}
						case 3:
							num4++;
							goto IL_00b5;
						case 0:
							{
								array[struct4_2[num4].int_1]++;
								int num5 = 3;
								goto case 3;
							}
							IL_00b5:
							if (num4 >= struct4_2.Length)
							{
								int[] array2 = new int[num + 1];
								while (true)
								{
									int num6 = Class42.smethod_1(36);
									while (true)
									{
										switch (num6)
										{
										case 5:
											num9 = 0;
											num6 = 3;
											goto case 3;
										case 3:
											array[0] = 0;
											num6 = 2;
											goto IL_00f0;
										case 2:
											goto IL_00f0;
										case 4:
											if (num7 != 0)
											{
												goto IL_0139;
											}
											num6 = 1;
											goto case 1;
										case 6:
											num7++;
											goto IL_0139;
										case 0:
											array2[num7] = num9;
											num6 = 6;
											goto case 6;
										case 1:
											{
												num9 = num9 + array[num7 - 1] << 1;
												num6 = 0;
												goto case 0;
											}
											IL_0139:
											if (num7 > num)
											{
												for (int i = 0; i < struct4_2.Length; i++)
												{
													int num8 = struct4_2[i].int_1;
													if (num8 != 0 || 1 == 0)
													{
														struct4_2[i].int_0 = array2[num8];
														array2[num8]++;
													}
												}
												return;
											}
											goto case 1;
										}
										break;
										IL_00f0:
										num7 = 1;
										num6 = Class42.smethod_1(47);
									}
								}
							}
							goto case 0;
						}
					}
				}
				goto case 0;
				IL_004f:
				num2++;
				goto IL_0055;
			}
		}
	}

	internal static Class41 smethod_4(Struct4[] struct4_2, Struct4[] struct4_3)
	{
		return new Class41
		{
			class40_0 = smethod_5(struct4_2),
			class40_1 = smethod_5(struct4_3)
		};
	}

	internal static Class40 smethod_5(Struct4[] struct4_2)
	{
		Struct3[] array = new Struct3[struct4_2.Length];
		int int_ = default(int);
		int num2 = default(int);
		Struct3 @struct = default(Struct3);
		while (true)
		{
			int num = Class42.smethod_1(47);
			while (true)
			{
				switch (num)
				{
				case 4:
					int_ = 0;
					num = 2;
					goto IL_0010;
				case 2:
					goto IL_0010;
				case 0:
					if (num2 == 0)
					{
						goto IL_007b;
					}
					num = 1;
					goto case 1;
				case 5:
					while (true)
					{
						switch (Class42.smethod_1(37))
						{
						default:
							continue;
						case 2:
							break;
						case 1:
						{
							@struct.struct4_0 = struct4_2[num2];
							int num3 = 0;
							goto case 0;
						}
						case 0:
						{
							@struct.ushort_0 = (ushort)num2;
							int num3 = 2;
							break;
						}
						}
						break;
					}
					array[int_++] = @struct;
					goto IL_0077;
				case 3:
					@struct = default(Struct3);
					num = 5;
					goto case 5;
				case 1:
					{
						if (struct4_2[num2].int_1 <= 0)
						{
							goto IL_0077;
						}
						num = 3;
						goto case 3;
					}
					IL_007b:
					if (num2 >= struct4_2.Length)
					{
						return smethod_6(array, int_, 0, 0);
					}
					goto case 1;
					IL_0077:
					num2++;
					goto IL_007b;
				}
				break;
				IL_0010:
				num2 = 0;
				num = Class42.smethod_1(42);
			}
		}
	}

	private static Class40 smethod_6(Struct3[] struct3_0, int int_5, int int_6, int int_7)
	{
		Struct3[] array = new Struct3[int_5];
		Struct3 @struct = default(Struct3);
		int num2 = default(int);
		Class40 @class = default(Class40);
		int num3 = default(int);
		int num4 = default(int);
		Struct3[] array2 = default(Struct3[]);
		while (true)
		{
			int num = Class42.smethod_1(37);
			while (true)
			{
				switch (num)
				{
				case 5:
					@struct = struct3_0[num2];
					num = 7;
					goto case 7;
				case 7:
					if (@struct.struct4_0.int_1 == int_7)
					{
						goto IL_0085;
					}
					goto IL_0032;
				case 11:
					num2++;
					goto IL_000c;
				case 10:
					num2 = 0;
					num = 4;
					goto case 4;
				case 4:
					if (num2 == 0)
					{
						goto IL_000c;
					}
					num = 5;
					goto case 5;
				case 9:
					@class.bool_0 = true;
					num = 3;
					goto case 3;
				case 3:
					@class.ushort_0 = @struct.ushort_0;
					num = 11;
					goto case 11;
				case 8:
					num3 = 0;
					num4 = 0;
					num = 10;
					goto case 10;
				case 6:
					@class.bool_0 = false;
					num = 8;
					goto case 8;
				case 2:
					@class = new Class40();
					num = 6;
					goto case 6;
				case 1:
					array2 = new Struct3[int_5];
					num = 2;
					goto case 2;
				case 0:
					{
						if (@struct.struct4_0.int_0 != int_6)
						{
							goto IL_0032;
						}
						num = 9;
						goto case 9;
					}
					IL_000c:
					if (num2 >= int_5)
					{
						if (!@class.bool_0 && 0 == 0)
						{
							if (num3 > 0)
							{
								@class.class40_0 = smethod_6(array, num3, int_6 << 1, int_7 + 1);
							}
							if (num4 > 0)
							{
								@class.class40_1 = smethod_6(array2, num4, (int_6 << 1) | 1, int_7 + 1);
							}
						}
						return @class;
					}
					goto case 5;
					IL_0032:
					if (((uint)(@struct.struct4_0.int_0 >> @struct.struct4_0.int_1 - int_7 - 1) & (true ? 1u : 0u)) != 0 || 1 == 0)
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
				IL_0085:
				num = Class42.smethod_1(42);
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
			switch (Class42.smethod_1(37))
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
			switch (Class42.smethod_1(42))
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
		return Class38.smethod_0(int_5, int_6);
	}

	internal static int[] smethod_11(int[] int_5)
	{
		return Class38.smethod_0(int_5, 15);
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
		Class39 @class = new Class39();
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
						int num3 = Class42.smethod_1(38);
						while (true)
						{
							switch (num3)
							{
							case 2:
								if (num + num2 < int_7)
								{
									num3 = 1;
									goto case 1;
								}
								goto case 3;
							case 1:
								if (num2 < 138)
								{
									num3 = 0;
									goto case 0;
								}
								goto case 3;
							case 0:
								if (int_5[int_6 + num + num2] != 0)
								{
									num3 = Class42.smethod_1(45);
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
				int num5 = Class42.smethod_1(38);
				while (true)
				{
					int num7;
					switch (num5)
					{
					case 2:
						@class.method_0(num4);
						num5 = 0;
						goto case 0;
					case 0:
						num6 = 0;
						num5 = 1;
						goto case 1;
					case 1:
						if (num6 != 0)
						{
							num5 = Class42.smethod_1(45);
							continue;
						}
						goto IL_0116;
					case 3:
						{
							num6++;
							goto IL_0116;
						}
						IL_013c:
						num7 = Class42.smethod_1(37);
						goto IL_0145;
						IL_0116:
						if (num + num6 < int_7 && num6 < 6)
						{
							if (int_5[int_6 + num + num6] == num4)
							{
								goto case 3;
							}
							goto IL_013c;
						}
						goto IL_0172;
						IL_015e:
						@class.method_0(16);
						num7 = Class42.smethod_1(38);
						goto IL_0145;
						IL_0145:
						switch (num7)
						{
						case 0:
							goto IL_015e;
						case 1:
							goto IL_0172;
						case 2:
							@class.method_0(num6 - 3);
							num7 = 3;
							goto case 3;
						case 3:
							num += num6;
							goto end_IL_010b;
						}
						goto IL_013c;
						IL_0172:
						if (num6 < 3)
						{
							goto end_IL_010b;
						}
						num7 = 0;
						goto IL_015e;
					}
					break;
				}
				continue;
				end_IL_010b:
				break;
			}
		}
		return @class.method_1();
	}
}
