using System;
using System.IO;

internal sealed class Class36
{
	public sealed class Class37
	{
		private Class39 class39_0 = new Class39(32769);

		private Class38 class38_0;

		private Class35 class35_0;

		private int int_0 = -1;

		private int int_1 = -1;

		private bool bool_0;

		private int int_2;

		private long long_0;

		private long long_1;

		private bool bool_1;

		private int int_3;

		private bool bool_2;

		public Class37(Stream stream_0)
		{
			class38_0 = new Class38(stream_0);
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
						switch (smethod_4(14))
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
			long_0 = class38_0.long_0;
			int num2 = default(int);
			while (true)
			{
				int num = smethod_4(16);
				while (true)
				{
					switch (num)
					{
					case 5:
						bool_0 = class38_0.method_0(1) > 0;
						num = 1;
						goto case 1;
					case 1:
						int_0 = class38_0.method_0(3);
						num = 3;
						goto case 3;
					case 3:
						if (int_0 == 1)
						{
							goto IL_0078;
						}
						if (int_0 == 1)
						{
							Struct3[] struct3_ = Class31.struct3_0;
							while (true)
							{
								int num3 = smethod_4(14);
								while (true)
								{
									switch (num3)
									{
									case 3:
										class35_0 = Class31.class35_0;
										num3 = smethod_4(29);
										continue;
									case 1:
									{
										Struct3[] struct3_2 = Class31.struct3_1;
										num3 = 0;
										goto case 0;
									}
									case 0:
										int_2 = 0;
										num3 = 3;
										goto case 3;
									case 2:
										bool_2 = false;
										num3 = 4;
										goto end_IL_0146;
									case 4:
										goto end_IL_0146;
									}
									break;
								}
								continue;
								end_IL_0146:
								break;
							}
						}
						else if (int_0 == 6)
						{
							method_6(class38_0, out var struct3_, out var struct3_2);
							while (true)
							{
								switch (smethod_4(18))
								{
								default:
									continue;
								case 0:
								{
									int_2 = 0;
									int num4 = 1;
									goto case 1;
								}
								case 1:
								{
									class35_0 = Class31.smethod_4(struct3_, struct3_2);
									int num4 = 2;
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
					case 4:
						class38_0.method_1();
						num = 7;
						goto case 7;
					case 7:
						num2 = class38_0.method_0(16) ^ 0xFFAF;
						num = 6;
						goto case 6;
					case 6:
						int_2 = num2;
						num = 0;
						goto case 0;
					case 0:
						class35_0 = null;
						num = 2;
						goto case 2;
					case 2:
						bool_2 = true;
						num = 8;
						goto case 8;
					case 8:
						long_1 = class38_0.long_0;
						return true;
					}
					break;
					IL_0078:
					num = smethod_4(15);
				}
			}
		}

		private int method_2(byte[] byte_0, int int_4, int int_5)
		{
			int num = int_4;
			if (int_0 == 1)
			{
				if (int_2 > 0)
				{
					int num2 = Math.Min(int_5, int_2);
					while (true)
					{
						switch (smethod_4(15))
						{
						default:
							continue;
						case 4:
						{
							class38_0.method_2(byte_0, int_4, num2);
							int num3 = 1;
							goto case 1;
						}
						case 1:
						{
							class39_0.method_1(byte_0, int_4, num2);
							int num3 = 2;
							goto case 2;
						}
						case 2:
						{
							int_2 -= num2;
							int num3 = 0;
							goto case 0;
						}
						case 0:
						{
							int_5 -= num2;
							int num3 = 3;
							goto case 3;
						}
						case 3:
						{
							int_4 += num2;
							int num3 = 5;
							break;
						}
						case 5:
							break;
						}
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
						int num4 = smethod_0(class38_0, class35_0.class34_0);
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
								switch (smethod_4(18))
								{
								default:
									continue;
								case 0:
								{
									class39_0.method_0((byte)num4);
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
							int num6 = smethod_1(class38_0, num4);
							while (true)
							{
								switch (smethod_4(18))
								{
								default:
									continue;
								case 0:
								{
									num7 = smethod_2(class38_0, class35_0.class34_1);
									int num8 = 2;
									goto case 2;
								}
								case 2:
								{
									int_1 = num7;
									int num8 = 1;
									goto case 1;
								}
								case 1:
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
			long_1 = class38_0.long_0;
			return int_4 - num;
		}

		private void method_3(byte[] byte_0, ref int int_4, ref int int_5)
		{
			int num = Math.Min(int_3, int_5);
			byte[] array = class39_0.method_2(int_1, Math.Min(num, int_1));
			while (true)
			{
				switch (smethod_4(14))
				{
				default:
					continue;
				case 1:
				{
					int_5 -= num;
					int num2 = 0;
					goto case 0;
				}
				case 0:
				{
					int_3 -= num;
					int num2 = 2;
					break;
				}
				case 2:
					break;
				}
				break;
			}
			while (num > array.Length)
			{
				Array.Copy(array, 0, byte_0, int_4, array.Length);
				while (true)
				{
					switch (smethod_4(18))
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
						class39_0.method_1(array, 0, array.Length);
						goto end_IL_0072;
					}
					continue;
					end_IL_0072:
					break;
				}
			}
			Array.Copy(array, 0, byte_0, int_4, num);
			int_4 += num;
			class39_0.method_1(array, 0, num);
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

		private static int smethod_0(Class38 class38_1, Class34 class34_0)
		{
			while (class34_0 != null && ((!class34_0.bool_0) ? true : false))
			{
				class34_0 = ((class38_1.method_0(1) > 0) ? class34_0.class34_1 : class34_0.class34_0);
			}
			return class34_0.ushort_0;
		}

		private static int smethod_1(Class38 class38_1, int int_4)
		{
			Class31.smethod_7(int_4, out var int_5, out var int_6);
			if (int_6 > 0)
			{
				return int_5 + class38_1.method_0(int_6);
			}
			return int_5;
		}

		private static int smethod_2(Class38 class38_1, Class34 class34_0)
		{
			int num = smethod_0(class38_1, class34_0);
			int num3 = default(int);
			int num5 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num2 = smethod_4(18);
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (num3 > 0)
						{
							goto IL_000e;
						}
						return num5;
					case 1:
						num3 = Class31.int_4[num];
						num2 = 2;
						goto case 2;
					case 0:
						num5 = Class31.int_3[num];
						num2 = 1;
						goto case 1;
					case 3:
						num4 = class38_1.method_0(num3);
						num2 = 4;
						goto case 4;
					case 4:
						return num5 + num4;
					}
					break;
					IL_000e:
					num2 = smethod_4(19);
				}
			}
		}

		private void method_6(Class38 class38_1, out Struct3[] struct3_0, out Struct3[] struct3_1)
		{
			int num = class38_1.method_0(5) + 257;
			int num4 = default(int);
			int num5 = default(int);
			int[] array3 = default(int[]);
			int num3 = default(int);
			int[] array = default(int[]);
			int[] array2 = default(int[]);
			int num7 = default(int);
			int num9 = default(int);
			while (true)
			{
				int num2 = smethod_4(16);
				while (true)
				{
					switch (num2)
					{
					case 5:
						num4 = class38_1.method_0(5) + 1;
						num2 = 1;
						goto case 1;
					case 1:
						num5 = class38_1.method_0(4) + 4;
						num2 = 2;
						goto case 2;
					case 2:
						array3 = Class31.int_0;
						num2 = 4;
						goto IL_0033;
					case 4:
						goto IL_0033;
					case 6:
						num3 = 0;
						num2 = 0;
						goto case 0;
					case 0:
						if (num3 == 0)
						{
							goto IL_008c;
						}
						num2 = 3;
						goto case 3;
					case 7:
						num3++;
						goto IL_008c;
					case 3:
						{
							array[array3[num3]] = class38_1.method_0(3);
							num2 = 7;
							goto case 7;
						}
						IL_008c:
						if (num3 >= num5)
						{
							Class34 class34_ = Class31.smethod_5(Class31.smethod_2(array));
							while (true)
							{
								int num6 = smethod_4(15);
								while (true)
								{
									switch (num6)
									{
									case 4:
										array2 = smethod_3(class38_1, class34_, num + num4);
										num6 = 0;
										goto IL_00c4;
									case 0:
										goto IL_00c4;
									case 3:
										num7 = 0;
										num6 = 1;
										goto case 1;
									case 1:
										if (num7 == 0)
										{
											goto IL_0114;
										}
										num6 = 2;
										goto case 2;
									case 5:
										num7++;
										goto IL_0114;
									case 2:
										{
											struct3_0[num7].int_1 = array2[num7];
											num6 = 5;
											goto case 5;
										}
										IL_0114:
										if (num7 >= num)
										{
											Class31.smethod_3(struct3_0);
											while (true)
											{
												switch (smethod_4(14))
												{
												case 1:
												{
													struct3_1 = new Struct3[num4];
													int num8 = 4;
													goto case 4;
												}
												case 4:
												{
													num9 = 0;
													int num8 = 2;
													goto case 2;
												}
												case 2:
													if (num9 != 0)
													{
														int num8 = 3;
														goto case 3;
													}
													goto case 5;
												case 3:
												{
													struct3_1[num9].int_1 = array2[num9 + num];
													int num8 = 0;
													goto case 0;
												}
												case 0:
												{
													num9++;
													int num8 = 5;
													goto case 5;
												}
												case 5:
													if (num9 >= num4)
													{
														Class31.smethod_3(struct3_1);
														return;
													}
													goto case 3;
												}
											}
										}
										goto case 2;
									}
									break;
									IL_00c4:
									struct3_0 = new Struct3[num];
									num6 = smethod_4(19);
								}
							}
						}
						goto case 3;
					}
					break;
					IL_0033:
					array = new int[19];
					num2 = smethod_4(25);
				}
			}
		}

		private static int[] smethod_3(Class38 class38_1, Class34 class34_0, int int_4)
		{
			int[] array = new int[int_4];
			int num = 0;
			int num9 = default(int);
			int num5 = default(int);
			while (num < int_4)
			{
				int num2 = smethod_0(class38_1, class34_0);
				while (true)
				{
					switch (smethod_4(18))
					{
					case 0:
						if (num2 < 16)
						{
							int num3 = 1;
							goto case 1;
						}
						switch (num2)
						{
						case 16:
						{
							int num7 = class38_1.method_0(2) + 3;
							while (true)
							{
								int num8 = smethod_4(18);
								while (true)
								{
									switch (num8)
									{
									case 3:
										num9++;
										goto IL_0058;
									case 2:
										array[num + num9] = array[num - 1];
										num8 = smethod_4(19);
										continue;
									case 1:
										if (num9 == 0)
										{
											goto IL_0058;
										}
										num8 = 2;
										goto case 2;
									case 0:
										{
											num9 = 0;
											num8 = 1;
											goto case 1;
										}
										IL_0058:
										if (num9 >= num7)
										{
											goto end_IL_009b;
										}
										goto case 2;
									}
									break;
								}
								continue;
								end_IL_009b:
								break;
							}
							num += num7 - 1;
							break;
						}
						case 17:
							while (true)
							{
								switch (smethod_4(18))
								{
								default:
									continue;
								case 0:
								{
									num5 = class38_1.method_0(3) + 3;
									int num6 = 1;
									goto case 1;
								}
								case 1:
								{
									num += num5 - 1;
									int num6 = 2;
									break;
								}
								case 2:
									break;
								}
								break;
							}
							break;
						case 18:
						{
							int num4 = class38_1.method_0(7) + 11;
							num += num4 - 1;
							break;
						}
						}
						goto case 2;
					case 1:
					{
						array[num] = num2;
						int num3 = 2;
						goto case 2;
					}
					case 2:
						num++;
						goto end_IL_0016;
					}
					continue;
					end_IL_0016:
					break;
				}
			}
			return array;
		}

		internal static int smethod_4(int int_4)
		{
			return int_4 switch
			{
				14 => 1, 
				15 => 4, 
				16 => 5, 
				17 => 9, 
				18 => 0, 
				19 => 3, 
				23 => 8, 
				25 => 6, 
				29 => 2, 
				_ => -1, 
			};
		}
	}

	private sealed class Class38
	{
		private uint uint_0;

		private int int_0;

		private int int_1;

		private Stream stream_0;

		internal long long_0;

		internal Class38(Stream stream_1)
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

	private sealed class Class39
	{
		private byte[] byte_0;

		private int int_0;

		internal int int_1;

		internal long long_0;

		internal Class39(int int_2)
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
			if (int_3 >= int_1)
			{
				Array.Copy(byte_1, int_2, byte_0, 0, int_1);
				int_0 = 0;
				return;
			}
			if (int_0 + int_3 > int_1)
			{
				int num = int_1 - int_0;
				int length = default(int);
				while (true)
				{
					int num2 = Class37.smethod_4(29);
					while (true)
					{
						switch (num2)
						{
						case 3:
							Array.Copy(byte_1, int_2, byte_0, int_0, num);
							num2 = 1;
							goto case 1;
						case 1:
							Array.Copy(byte_1, int_2 + num, byte_0, 0, length);
							num2 = 0;
							goto IL_0080;
						case 0:
							goto IL_0080;
						case 2:
							length = int_0 + int_3 - int_1;
							num2 = 3;
							goto case 3;
						case 4:
							return;
						}
						break;
						IL_0080:
						int_0 = length;
						num2 = Class37.smethod_4(15);
					}
				}
			}
			Array.Copy(byte_1, int_2, byte_0, int_0, int_3);
			while (true)
			{
				switch (Class37.smethod_4(18))
				{
				case 0:
				{
					int_0 += int_3;
					int num3 = 1;
					goto case 1;
				}
				case 1:
					if (int_0 == int_1)
					{
						int num3 = 2;
						goto case 2;
					}
					return;
				case 2:
					int_0 = 0;
					return;
				}
			}
		}

		internal byte[] method_2(int int_2, int int_3)
		{
			byte[] array = new byte[int_3];
			if (int_0 >= int_2)
			{
				Array.Copy(byte_0, int_0 - int_2, array, 0, int_3);
			}
			else
			{
				int num = int_2 - int_0;
				while (true)
				{
					int num2 = Class37.smethod_4(29);
					while (true)
					{
						switch (num2)
						{
						case 2:
							break;
						default:
							goto end_IL_003f;
						case 0:
							Array.Copy(byte_0, int_1 - num, array, 0, num);
							num2 = 1;
							goto case 1;
						case 1:
							Array.Copy(byte_0, 0, array, num, int_3 - num);
							num2 = 3;
							goto end_IL_0055;
						case 3:
							goto end_IL_0055;
						}
						if (num < int_3)
						{
							num2 = Class37.smethod_4(18);
							continue;
						}
						Array.Copy(byte_0, int_1 - num, array, 0, int_3);
						goto end_IL_0055;
						continue;
						end_IL_003f:
						break;
					}
					continue;
					end_IL_0055:
					break;
				}
			}
			return array;
		}
	}

	public static void smethod_0(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[4096];
		Class37 @class = new Class37(stream_0);
		while (true)
		{
			int num = @class.method_0(array, 0, array.Length);
			while (true)
			{
				switch (Class37.smethod_4(18))
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
}
