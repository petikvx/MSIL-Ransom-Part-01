using System;
using System.IO;

internal sealed class Class12
{
	public sealed class Class13
	{
		private Class15 class15_0 = new Class15(32769);

		private Class14 class14_0;

		private Class11 class11_0;

		private int int_0 = -1;

		private int int_1 = -1;

		private bool bool_0;

		private int int_2;

		private long long_0;

		private long long_1;

		private bool bool_1;

		private int int_3;

		private bool bool_2;

		public Class13(Stream stream_0)
		{
			class14_0 = new Class14(stream_0);
		}

		public int method_0(byte[] byte_0, int int_4, int int_5)
		{
			if ((int_5 != 0 || 1 == 0) && ((!bool_1) ? true : false))
			{
				int num = 0;
				while (num < int_5)
				{
					while (int_0 < 0 && ((!bool_1) ? true : false))
					{
						bool_1 = !method_1();
					}
					if (bool_1 ? true : false)
					{
						break;
					}
					int num2 = method_2(byte_0, int_4 + num, int_5 - num);
					while (true)
					{
						switch (Class12.smethod_1(82))
						{
						default:
							continue;
						case 1:
							if (num2 > 0)
							{
								int num3 = 0;
								goto case 0;
							}
							int_0 = -1;
							break;
						case 0:
						{
							num += num2;
							int num3 = 2;
							break;
						}
						case 2:
							break;
						}
						break;
					}
				}
				return num;
			}
			return 0;
		}

		private bool method_1()
		{
			if (bool_0 || 1 == 0)
			{
				return false;
			}
			long_0 = class14_0.long_0;
			int num4 = default(int);
			while (true)
			{
				int num = Class12.smethod_1(73);
				while (true)
				{
					switch (num)
					{
					case 6:
						goto IL_002c;
					case 5:
						int_0 = class14_0.method_0(4);
						num = 1;
						goto case 1;
					case 1:
						if (int_0 == 10)
						{
							num = 3;
							goto case 3;
						}
						if (int_0 == 5)
						{
							Struct1[] struct1_ = Class7.struct1_0;
							while (true)
							{
								int num2 = Class12.smethod_1(72);
								while (true)
								{
									switch (num2)
									{
									case 1:
										int_2 = 0;
										num2 = Class12.smethod_1(70);
										continue;
									case 0:
									{
										Struct1[] struct1_2 = Class7.struct1_1;
										num2 = 1;
										goto case 1;
									}
									case 3:
										class11_0 = Class7.class11_0;
										num2 = 2;
										goto case 2;
									case 2:
										bool_2 = false;
										num2 = 4;
										goto end_IL_0131;
									case 4:
										goto end_IL_0131;
									}
									break;
								}
								continue;
								end_IL_0131:
								break;
							}
						}
						else if (int_0 == 4)
						{
							method_6(class14_0, out var struct1_, out var struct1_2);
							while (true)
							{
								switch (Class12.smethod_1(82))
								{
								default:
									continue;
								case 1:
								{
									int_2 = 0;
									int num3 = 0;
									goto case 0;
								}
								case 0:
								{
									class11_0 = Class7.smethod_4(struct1_, struct1_2);
									int num3 = 2;
									break;
								}
								case 2:
									break;
								}
								break;
							}
							bool_2 = false;
						}
						goto case 8;
					case 3:
						class14_0.method_1();
						num = 7;
						goto case 7;
					case 7:
						num4 = class14_0.method_0(16) ^ 0x597B;
						num = 4;
						goto case 4;
					case 4:
						int_2 = num4;
						num = 0;
						goto case 0;
					case 0:
						class11_0 = null;
						num = 2;
						goto case 2;
					case 2:
						bool_2 = true;
						num = 8;
						goto case 8;
					case 8:
						long_1 = class14_0.long_0;
						return true;
					}
					break;
					IL_002c:
					bool_0 = class14_0.method_0(1) > 0;
					num = Class12.smethod_1(74);
				}
			}
		}

		private int method_2(byte[] byte_0, int int_4, int int_5)
		{
			int num = int_4;
			if (int_0 == 10)
			{
				if (int_2 > 0)
				{
					int num2 = Math.Min(int_5, int_2);
					while (true)
					{
						int num3 = Class12.smethod_1(82);
						while (true)
						{
							switch (num3)
							{
							case 1:
								class14_0.method_2(byte_0, int_4, num2);
								num3 = Class12.smethod_1(76);
								continue;
							case 4:
								class15_0.method_1(byte_0, int_4, num2);
								num3 = 0;
								goto case 0;
							case 0:
								int_2 -= num2;
								num3 = 2;
								goto case 2;
							case 2:
								int_5 -= num2;
								num3 = 3;
								goto case 3;
							case 3:
								int_4 += num2;
								num3 = 5;
								goto end_IL_0085;
							case 5:
								goto end_IL_0085;
							}
							break;
						}
						continue;
						end_IL_0085:
						break;
					}
				}
			}
			else if (!bool_2 && 0 == 0)
			{
				if (int_3 > 0)
				{
					method_3(byte_0, ref int_4, ref int_5);
				}
				if (int_5 > 0)
				{
					int num7 = default(int);
					do
					{
						int num4 = smethod_0(class14_0, class11_0.class10_0);
						bool_2 = num4 == 256;
						if (bool_2 ? true : false)
						{
							break;
						}
						if (num4 < 256)
						{
							byte_0[int_4++] = (byte)num4;
							while (true)
							{
								switch (Class12.smethod_1(72))
								{
								default:
									continue;
								case 0:
								{
									class15_0.method_0((byte)num4);
									int num5 = 1;
									goto case 1;
								}
								case 1:
								{
									int_5--;
									int num5 = 2;
									break;
								}
								case 2:
									break;
								}
								break;
							}
						}
						else
						{
							if (num4 > 285)
							{
								continue;
							}
							int num6 = smethod_1(class14_0, num4);
							while (true)
							{
								switch (Class12.smethod_1(69))
								{
								default:
									continue;
								case 2:
								{
									num7 = smethod_2(class14_0, class11_0.class10_1);
									int num8 = 1;
									goto case 1;
								}
								case 1:
								{
									int_1 = num7;
									int num8 = 0;
									goto case 0;
								}
								case 0:
								{
									int_3 = num6;
									int num8 = 3;
									break;
								}
								case 3:
									break;
								}
								break;
							}
							method_3(byte_0, ref int_4, ref int_5);
						}
					}
					while (int_5 > 0);
				}
			}
			long_1 = class14_0.long_0;
			return int_4 - num;
		}

		private void method_3(byte[] byte_0, ref int int_4, ref int int_5)
		{
			int num = Math.Min(int_3, int_5);
			byte[] array = default(byte[]);
			while (true)
			{
				int num2 = Class12.smethod_1(82);
				while (true)
				{
					switch (num2)
					{
					case 2:
						int_5 -= num;
						num2 = 0;
						goto IL_0018;
					case 0:
						goto IL_0018;
					case 1:
						array = class15_0.method_2(int_1, Math.Min(num, int_1));
						num2 = 2;
						goto case 2;
					case 3:
					{
						while (num > array.Length)
						{
							Array.Copy(array, 0, byte_0, int_4, array.Length);
							while (true)
							{
								switch (Class12.smethod_1(72))
								{
								case 0:
								{
									int_4 += array.Length;
									int num3 = 1;
									goto case 1;
								}
								case 1:
								{
									num -= array.Length;
									int num3 = 2;
									goto case 2;
								}
								case 2:
									class15_0.method_1(array, 0, array.Length);
									goto end_IL_007f;
								}
								continue;
								end_IL_007f:
								break;
							}
						}
						Array.Copy(array, 0, byte_0, int_4, num);
						int num4;
						while (true)
						{
							switch (Class12.smethod_1(82))
							{
							default:
								continue;
							case 1:
								int_4 += num;
								num4 = 0;
								break;
							case 0:
								break;
							case 2:
								return;
							}
							break;
						}
						class15_0.method_1(array, 0, num);
						num4 = 2;
						return;
					}
					}
					break;
					IL_0018:
					int_3 -= num;
					num2 = Class12.smethod_1(70);
				}
			}
		}

		public bool method_4(int int_4)
		{
			byte[] byte_ = new byte[1024];
			int num;
			while (int_4 > 0 && (num = method_0(byte_, 0, Math.Min(1024, int_4))) > 0)
			{
				int_4 -= num;
			}
			return int_4 <= 0;
		}

		public void method_5()
		{
			byte[] byte_ = new byte[1024];
			while (method_0(byte_, 0, 1024) > 0)
			{
			}
		}

		private static int smethod_0(Class14 class14_1, Class10 class10_0)
		{
			while (class10_0 != null && ((!class10_0.bool_0) ? true : false))
			{
				class10_0 = ((class14_1.method_0(1) > 0) ? class10_0.class10_1 : class10_0.class10_0);
			}
			return class10_0.ushort_0;
		}

		private static int smethod_1(Class14 class14_1, int int_4)
		{
			Class7.smethod_7(int_4, out var int_5, out var int_6);
			if (int_6 > 0)
			{
				return int_5 + class14_1.method_0(int_6);
			}
			return int_5;
		}

		private static int smethod_2(Class14 class14_1, Class10 class10_0)
		{
			int num = smethod_0(class14_1, class10_0);
			int num5 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num2 = Class12.smethod_1(70);
				while (true)
				{
					switch (num2)
					{
					case 3:
						num5 = Class7.int_3[num];
						num2 = 0;
						goto case 0;
					case 0:
						num3 = Class7.int_4[num];
						num2 = 2;
						goto case 2;
					case 2:
						if (num3 > 0)
						{
							goto IL_0024;
						}
						return num5;
					case 1:
						num4 = class14_1.method_0(num3);
						num2 = 4;
						goto case 4;
					case 4:
						return num5 + num4;
					}
					break;
					IL_0024:
					num2 = Class12.smethod_1(82);
				}
			}
		}

		private void method_6(Class14 class14_1, out Struct1[] struct1_0, out Struct1[] struct1_1)
		{
			int num = class14_1.method_0(5) + 257;
			int num4 = default(int);
			int[] array = default(int[]);
			int[] array2 = default(int[]);
			int num3 = default(int);
			int num5 = default(int);
			int[] array3 = default(int[]);
			int num7 = default(int);
			int num9 = default(int);
			while (true)
			{
				int num2 = Class12.smethod_1(73);
				while (true)
				{
					switch (num2)
					{
					case 6:
						num4 = class14_1.method_0(5) + 1;
						num2 = 3;
						goto IL_001d;
					case 3:
						goto IL_001d;
					case 0:
						array = Class7.int_0;
						num2 = 1;
						goto case 1;
					case 1:
						array2 = new int[19];
						num2 = 5;
						goto case 5;
					case 5:
						num3 = 0;
						num2 = 4;
						goto case 4;
					case 4:
						if (num3 == 0)
						{
							goto IL_008c;
						}
						num2 = 2;
						goto case 2;
					case 7:
						num3++;
						goto IL_008c;
					case 2:
						{
							array2[array[num3]] = class14_1.method_0(3);
							num2 = 7;
							goto case 7;
						}
						IL_008c:
						if (num3 >= num5)
						{
							Class10 class10_ = Class7.smethod_5(Class7.smethod_2(array2));
							while (true)
							{
								int num6 = Class12.smethod_1(70);
								while (true)
								{
									switch (num6)
									{
									case 4:
										struct1_0 = new Struct1[num];
										num6 = 1;
										goto IL_00bf;
									case 1:
										goto IL_00bf;
									case 3:
										array3 = smethod_3(class14_1, class10_, num + num4);
										num6 = 4;
										goto case 4;
									case 0:
										if (num7 == 0)
										{
											goto IL_0118;
										}
										num6 = 2;
										goto case 2;
									case 5:
										num7++;
										goto IL_0118;
									case 2:
										{
											struct1_0[num7].int_1 = array3[num7];
											num6 = 5;
											goto case 5;
										}
										IL_0118:
										if (num7 >= num)
										{
											Class7.smethod_3(struct1_0);
											while (true)
											{
												int num8 = Class12.smethod_1(82);
												while (true)
												{
													switch (num8)
													{
													case 1:
														struct1_1 = new Struct1[num4];
														num8 = 0;
														goto IL_0149;
													case 0:
														goto IL_0149;
													case 2:
														if (num9 == 0)
														{
															goto IL_018a;
														}
														num8 = 3;
														goto case 3;
													case 4:
														num9++;
														goto IL_018a;
													case 3:
														{
															struct1_1[num9].int_1 = array3[num9 + num];
															num8 = 4;
															goto case 4;
														}
														IL_018a:
														if (num9 >= num4)
														{
															Class7.smethod_3(struct1_1);
															return;
														}
														goto case 3;
													}
													break;
													IL_0149:
													num9 = 0;
													num8 = Class12.smethod_1(69);
												}
											}
										}
										goto case 2;
									}
									break;
									IL_00bf:
									num7 = 0;
									num6 = Class12.smethod_1(72);
								}
							}
						}
						goto case 2;
					}
					break;
					IL_001d:
					num5 = class14_1.method_0(4) + 4;
					num2 = Class12.smethod_1(72);
				}
			}
		}

		private static int[] smethod_3(Class14 class14_1, Class10 class10_0, int int_4)
		{
			int[] array = new int[int_4];
			int num2 = default(int);
			int num3 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			while (true)
			{
				int num = Class12.smethod_1(72);
				while (true)
				{
					switch (num)
					{
					case 5:
						num2++;
						goto IL_0010;
					case 3:
						goto IL_0017;
					case 4:
						array[num2] = num3;
						num = 5;
						goto case 5;
					case 2:
						if (num3 < 16)
						{
							num = 4;
							goto case 4;
						}
						if (num3 == 16)
						{
							int num4 = class14_1.method_0(2) + 3;
							while (true)
							{
								int num5 = Class12.smethod_1(69);
								while (true)
								{
									switch (num5)
									{
									case 2:
										num6 = 0;
										num5 = 0;
										goto case 0;
									case 0:
										if (num6 != 0)
										{
											num5 = Class12.smethod_1(82);
											continue;
										}
										goto IL_0086;
									case 1:
										array[num2 + num6] = array[num2 - 1];
										num5 = 3;
										goto case 3;
									case 3:
										{
											num6++;
											goto IL_0086;
										}
										IL_0086:
										if (num6 >= num4)
										{
											goto end_IL_007b;
										}
										goto case 1;
									}
									break;
								}
								continue;
								end_IL_007b:
								break;
							}
							num2 += num4 - 1;
						}
						else if (num3 == 17)
						{
							while (true)
							{
								switch (Class12.smethod_1(72))
								{
								case 2:
									break;
								default:
									continue;
								case 0:
								{
									num7 = class14_1.method_0(3) + 3;
									int num8 = 1;
									goto case 1;
								}
								case 1:
								{
									num2 += num7 - 1;
									int num8 = 2;
									break;
								}
								}
								break;
							}
						}
						else if (num3 == 18)
						{
							int num9 = class14_1.method_0(7) + 11;
							num2 += num9 - 1;
						}
						goto case 5;
					case 1:
						if (num2 != 0)
						{
							num = 3;
							goto IL_0017;
						}
						goto IL_0010;
					case 0:
						{
							num2 = 0;
							num = 1;
							goto case 1;
						}
						IL_0010:
						if (num2 < int_4)
						{
							goto IL_0017;
						}
						return array;
					}
					break;
					IL_0017:
					num3 = smethod_0(class14_1, class10_0);
					num = Class12.smethod_1(69);
				}
			}
		}
	}

	private sealed class Class14
	{
		private uint uint_0;

		private int int_0;

		private int int_1;

		private Stream stream_0;

		internal long long_0;

		internal Class14(Stream stream_1)
		{
			stream_0 = stream_1;
		}

		internal int method_0(int int_2)
		{
			long_0 += int_2;
			for (int num = int_2 - (int_1 - int_0); num > 0; num -= 8)
			{
				uint_0 |= checked((uint)stream_0.ReadByte()) << int_1;
				int_1 += 8;
			}
			int result = (int)(uint_0 >> int_0) & ((1 << int_2) - 1);
			int_0 += int_2;
			if (int_1 == int_0)
			{
				int_0 = 0;
				int_1 = 0;
				uint_0 = 0u;
				return result;
			}
			if (int_0 >= 8)
			{
				uint_0 >>= int_0;
				int_1 -= int_0;
				int_0 = 0;
			}
			return result;
		}

		internal void method_1()
		{
			if (int_1 != int_0)
			{
				long_0 += int_1 - int_0;
			}
			int_0 = 0;
			int_1 = 0;
			uint_0 = 0u;
		}

		internal void method_2(byte[] byte_0, int int_2, int int_3)
		{
			int num = stream_0.Read(byte_0, int_2, int_3);
			long_0 += num << 3;
		}
	}

	private sealed class Class15
	{
		private byte[] byte_0;

		private int int_0;

		internal int int_1;

		internal long long_0;

		internal Class15(int int_2)
		{
			int_1 = int_2;
			byte_0 = new byte[int_2];
		}

		internal void method_0(byte byte_1)
		{
			byte_0[int_0++] = byte_1;
			if (int_0 >= int_1)
			{
				int_0 = 0;
			}
			long_0++;
		}

		internal void method_1(byte[] byte_1, int int_2, int int_3)
		{
			long_0 += int_3;
			int length = default(int);
			while (true)
			{
				switch (smethod_1(69))
				{
				case 2:
					if (int_3 >= int_1)
					{
						int num = 0;
						goto case 0;
					}
					if (int_0 + int_3 > int_1)
					{
						int num2 = int_1 - int_0;
						while (true)
						{
							int num3 = smethod_1(72);
							while (true)
							{
								switch (num3)
								{
								case 1:
									goto IL_0086;
								case 0:
									length = int_0 + int_3 - int_1;
									num3 = 1;
									goto IL_0086;
								case 2:
									Array.Copy(byte_1, int_2 + num2, byte_0, 0, length);
									num3 = 3;
									goto case 3;
								case 3:
									int_0 = length;
									num3 = 4;
									return;
								case 4:
									return;
								}
								break;
								IL_0086:
								Array.Copy(byte_1, int_2, byte_0, int_0, num2);
								num3 = smethod_1(69);
							}
						}
					}
					Array.Copy(byte_1, int_2, byte_0, int_0, int_3);
					while (true)
					{
						switch (smethod_1(72))
						{
						case 0:
						{
							int_0 += int_3;
							int num4 = 1;
							goto case 1;
						}
						case 1:
							if (int_0 == int_1)
							{
								int num4 = 2;
								goto case 2;
							}
							return;
						case 2:
							int_0 = 0;
							return;
						}
					}
				case 0:
				{
					Array.Copy(byte_1, int_2, byte_0, 0, int_1);
					int num = 1;
					goto case 1;
				}
				case 1:
				{
					int_0 = 0;
					int num = 3;
					return;
				}
				case 3:
					return;
				}
			}
		}

		internal byte[] method_2(int int_2, int int_3)
		{
			byte[] array = new byte[int_3];
			while (true)
			{
				switch (smethod_1(82))
				{
				default:
					continue;
				case 1:
				{
					if (int_0 >= int_2)
					{
						int num = 0;
						goto case 0;
					}
					int num2 = int_2 - int_0;
					while (true)
					{
						switch (smethod_1(69))
						{
						default:
							continue;
						case 2:
							if (num2 < int_3)
							{
								int num3 = 0;
								goto case 0;
							}
							Array.Copy(byte_0, int_1 - num2, array, 0, int_3);
							break;
						case 0:
						{
							Array.Copy(byte_0, int_1 - num2, array, 0, num2);
							int num3 = 1;
							goto case 1;
						}
						case 1:
						{
							Array.Copy(byte_0, 0, array, num2, int_3 - num2);
							int num3 = 3;
							break;
						}
						case 3:
							break;
						}
						break;
					}
					break;
				}
				case 0:
				{
					Array.Copy(byte_0, int_0 - int_2, array, 0, int_3);
					int num = 2;
					break;
				}
				case 2:
					break;
				}
				break;
			}
			return array;
		}
	}

	public static void smethod_0(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[81920];
		Class13 @class = new Class13(stream_0);
		while (true)
		{
			int num = @class.method_0(array, 0, array.Length);
			while (true)
			{
				switch (smethod_1(72))
				{
				default:
					continue;
				case 0:
					if (num > 0)
					{
						int num2 = 1;
						goto case 1;
					}
					return;
				case 1:
				{
					stream_1.Write(array, 0, num);
					int num2 = 2;
					break;
				}
				case 2:
					break;
				}
				break;
			}
		}
	}

	internal static int smethod_1(int int_0)
	{
		return int_0 switch
		{
			69 => 2, 
			70 => 3, 
			72 => 0, 
			73 => 6, 
			74 => 5, 
			76 => 4, 
			77 => 11, 
			82 => 1, 
			_ => -1, 
		};
	}

	internal static int smethod_2(int int_0)
	{
		return int_0 switch
		{
			40 => 8, 
			41 => 57, 
			43 => 9, 
			19 => -14, 
			21 => 13, 
			22 => -4, 
			23 => -32, 
			25 => 27, 
			28 => -58, 
			32 => -54, 
			34 => -57, 
			35 => -30, 
			13 => -31, 
			_ => -1, 
		};
	}
}
