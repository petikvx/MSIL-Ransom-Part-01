using System;
using System.IO;

internal sealed class Class65
{
	public sealed class Class66
	{
		private Class68 class68_0 = new Class68(32769);

		private Class67 class67_0;

		private Class64 class64_0;

		private int int_0 = -1;

		private int int_1 = -1;

		private bool bool_0;

		private int int_2;

		private long long_0;

		private long long_1;

		private bool bool_1;

		private int int_3;

		private bool bool_2;

		public Class66(Stream stream_0)
		{
			class67_0 = new Class67(stream_0);
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
						switch (Class65.smethod_1(37))
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
			long_0 = class67_0.long_0;
			int num4 = default(int);
			while (true)
			{
				int num = Class65.smethod_1(42);
				while (true)
				{
					switch (num)
					{
					case 7:
						num4 = class67_0.method_0(16) ^ 0xBF94;
						num = 5;
						goto case 5;
					case 5:
						int_2 = num4;
						num = 2;
						goto IL_0060;
					case 2:
						goto IL_0060;
					case 6:
						if (int_0 == 3)
						{
							num = 4;
							goto case 4;
						}
						if (int_0 == 1)
						{
							Struct7[] struct7_ = Class60.struct7_0;
							while (true)
							{
								switch (Class65.smethod_1(37))
								{
								default:
									continue;
								case 1:
								{
									Struct7[] struct7_2 = Class60.struct7_1;
									int num2 = 3;
									goto case 3;
								}
								case 3:
								{
									int_2 = 0;
									int num2 = 0;
									goto case 0;
								}
								case 0:
								{
									class64_0 = Class60.class64_0;
									int num2 = 2;
									goto case 2;
								}
								case 2:
								{
									bool_2 = false;
									int num2 = 4;
									break;
								}
								case 4:
									break;
								}
								break;
							}
						}
						else if (int_0 == 6)
						{
							method_6(class67_0, out var struct7_, out var struct7_2);
							while (true)
							{
								switch (Class65.smethod_1(37))
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
									class64_0 = Class60.smethod_4(struct7_, struct7_2);
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
					case 4:
						class67_0.method_1();
						num = 7;
						goto case 7;
					case 3:
						int_0 = class67_0.method_0(3);
						num = 6;
						goto case 6;
					case 0:
						bool_0 = class67_0.method_0(1) > 0;
						num = 3;
						goto case 3;
					case 1:
						bool_2 = true;
						num = 8;
						goto case 8;
					case 8:
						long_1 = class67_0.long_0;
						return true;
					}
					break;
					IL_0060:
					class64_0 = null;
					num = Class65.smethod_1(37);
				}
			}
		}

		private int method_2(byte[] byte_0, int int_4, int int_5)
		{
			int num = int_4;
			if (int_0 == 3)
			{
				if (int_2 > 0)
				{
					int num2 = Math.Min(int_5, int_2);
					while (true)
					{
						switch (Class65.smethod_1(38))
						{
						default:
							continue;
						case 2:
						{
							class67_0.method_2(byte_0, int_4, num2);
							int num3 = 1;
							goto case 1;
						}
						case 1:
						{
							class68_0.method_1(byte_0, int_4, num2);
							int num3 = 4;
							goto case 4;
						}
						case 4:
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
					int num8 = default(int);
					do
					{
						int num4 = smethod_0(class67_0, class64_0.class63_0);
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
								switch (Class65.smethod_1(37))
								{
								default:
									continue;
								case 1:
								{
									class68_0.method_0((byte)num4);
									int num5 = 0;
									goto case 0;
								}
								case 0:
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
							int num6 = smethod_1(class67_0, num4);
							while (true)
							{
								int num7 = Class65.smethod_1(37);
								while (true)
								{
									switch (num7)
									{
									case 2:
										int_3 = num6;
										num7 = Class65.smethod_1(45);
										continue;
									case 1:
										num8 = smethod_2(class67_0, class64_0.class63_1);
										num7 = 0;
										goto case 0;
									case 0:
										int_1 = num8;
										num7 = 2;
										goto case 2;
									case 3:
										goto end_IL_0237;
									}
									break;
								}
								continue;
								end_IL_0237:
								break;
							}
							method_3(byte_0, ref int_4, ref int_5);
						}
					}
					while (int_5 > 0);
				}
			}
			long_1 = class67_0.long_0;
			return int_4 - num;
		}

		private void method_3(byte[] byte_0, ref int int_4, ref int int_5)
		{
			int num = Math.Min(int_3, int_5);
			byte[] array = default(byte[]);
			while (true)
			{
				switch (Class65.smethod_1(38))
				{
				default:
					continue;
				case 2:
				{
					array = class68_0.method_2(int_1, Math.Min(num, int_1));
					int num2 = 0;
					goto case 0;
				}
				case 0:
				{
					int_5 -= num;
					int num2 = 1;
					goto case 1;
				}
				case 1:
				{
					int_3 -= num;
					int num2 = 3;
					break;
				}
				case 3:
					break;
				}
				break;
			}
			while (num > array.Length)
			{
				Array.Copy(array, 0, byte_0, int_4, array.Length);
				while (true)
				{
					switch (Class65.smethod_1(37))
					{
					case 1:
					{
						int_4 += array.Length;
						int num3 = 0;
						goto case 0;
					}
					case 0:
					{
						num -= array.Length;
						int num3 = 2;
						goto case 2;
					}
					case 2:
						class68_0.method_1(array, 0, array.Length);
						goto end_IL_0078;
					}
					continue;
					end_IL_0078:
					break;
				}
			}
			Array.Copy(array, 0, byte_0, int_4, num);
			int num4;
			while (true)
			{
				switch (Class65.smethod_1(42))
				{
				default:
					continue;
				case 0:
					int_4 += num;
					num4 = 1;
					break;
				case 1:
					break;
				case 2:
					return;
				}
				break;
			}
			class68_0.method_1(array, 0, num);
			num4 = 2;
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

		private static int smethod_0(Class67 class67_1, Class63 class63_0)
		{
			while (class63_0 != null && ((!class63_0.bool_0) ? true : false))
			{
				class63_0 = ((class67_1.method_0(1) > 0) ? class63_0.class63_1 : class63_0.class63_0);
			}
			return class63_0.ushort_0;
		}

		private static int smethod_1(Class67 class67_1, int int_4)
		{
			Class60.smethod_7(int_4, out var int_5, out var int_6);
			if (int_6 > 0)
			{
				return int_5 + class67_1.method_0(int_6);
			}
			return int_5;
		}

		private static int smethod_2(Class67 class67_1, Class63 class63_0)
		{
			int num = smethod_0(class67_1, class63_0);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			while (true)
			{
				int num2 = Class65.smethod_1(45);
				while (true)
				{
					switch (num2)
					{
					case 3:
						goto IL_000a;
					case 2:
						num3 = Class60.int_4[num];
						num2 = 0;
						goto case 0;
					case 0:
						if (num3 > 0)
						{
							num2 = 1;
							goto case 1;
						}
						return num4;
					case 1:
						num5 = class67_1.method_0(num3);
						num2 = 4;
						goto case 4;
					case 4:
						return num4 + num5;
					}
					break;
					IL_000a:
					num4 = Class60.int_3[num];
					num2 = Class65.smethod_1(38);
				}
			}
		}

		private void method_6(Class67 class67_1, out Struct7[] struct7_0, out Struct7[] struct7_1)
		{
			int num = class67_1.method_0(5) + 257;
			int num5 = default(int);
			int[] array = default(int[]);
			int[] array2 = default(int[]);
			int num4 = default(int);
			int num3 = default(int);
			int[] array3 = default(int[]);
			int num7 = default(int);
			int num9 = default(int);
			while (true)
			{
				int num2 = Class65.smethod_1(45);
				while (true)
				{
					Class63 class63_;
					switch (num2)
					{
					case 7:
						num5++;
						goto IL_0019;
					case 0:
						goto IL_0021;
					case 6:
						num5 = 0;
						num2 = 2;
						goto case 2;
					case 2:
						if (num5 != 0)
						{
							num2 = 0;
							goto IL_0021;
						}
						goto IL_0019;
					case 5:
						array = Class60.int_0;
						num2 = 1;
						goto case 1;
					case 1:
						array2 = new int[19];
						num2 = 6;
						goto case 6;
					case 4:
						num4 = class67_1.method_0(4) + 4;
						num2 = 5;
						goto case 5;
					case 3:
						{
							num3 = class67_1.method_0(5) + 1;
							num2 = 4;
							goto case 4;
						}
						IL_0019:
						if (num5 < num4)
						{
							goto IL_0021;
						}
						class63_ = Class60.smethod_5(Class60.smethod_2(array2));
						while (true)
						{
							switch (Class65.smethod_1(37))
							{
							case 1:
							{
								array3 = smethod_3(class67_1, class63_, num + num3);
								int num6 = 3;
								goto case 3;
							}
							case 3:
							{
								struct7_0 = new Struct7[num];
								int num6 = 2;
								goto case 2;
							}
							case 2:
							{
								num7 = 0;
								int num6 = 0;
								goto case 0;
							}
							case 0:
							{
								if (num7 == 0)
								{
									goto IL_0118;
								}
								int num6 = 4;
								goto case 4;
							}
							case 5:
								num7++;
								goto IL_0118;
							case 4:
								{
									struct7_0[num7].int_1 = array3[num7];
									int num6 = 5;
									goto case 5;
								}
								IL_0118:
								if (num7 >= num)
								{
									Class60.smethod_3(struct7_0);
									while (true)
									{
										int num8 = Class65.smethod_1(45);
										while (true)
										{
											switch (num8)
											{
											case 3:
												struct7_1 = new Struct7[num3];
												num8 = 0;
												goto IL_0149;
											case 0:
												goto IL_0149;
											case 2:
												if (num9 == 0)
												{
													goto IL_018a;
												}
												num8 = 1;
												goto case 1;
											case 4:
												num9++;
												goto IL_018a;
											case 1:
												{
													struct7_1[num9].int_1 = array3[num9 + num];
													num8 = 4;
													goto case 4;
												}
												IL_018a:
												if (num9 >= num3)
												{
													Class60.smethod_3(struct7_1);
													return;
												}
												goto case 1;
											}
											break;
											IL_0149:
											num9 = 0;
											num8 = Class65.smethod_1(38);
										}
									}
								}
								goto case 4;
							}
						}
					}
					break;
					IL_0021:
					array2[array[num5]] = class67_1.method_0(3);
					num2 = Class65.smethod_1(43);
				}
			}
		}

		private static int[] smethod_3(Class67 class67_1, Class63 class63_0, int int_4)
		{
			int[] array = new int[int_4];
			int num = default(int);
			int num3 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			while (true)
			{
				switch (Class65.smethod_1(42))
				{
				case 0:
				{
					num = 0;
					int num2 = 1;
					goto case 1;
				}
				case 1:
				{
					if (num == 0)
					{
						goto IL_0048;
					}
					int num2 = 3;
					goto case 3;
				}
				case 5:
					num++;
					goto IL_0048;
				case 4:
					if (num3 < 16)
					{
						int num2 = 2;
						goto case 2;
					}
					if (num3 == 16)
					{
						int num4 = class67_1.method_0(2) + 3;
						while (true)
						{
							int num5 = Class65.smethod_1(38);
							while (true)
							{
								switch (num5)
								{
								case 3:
									num6++;
									goto IL_007c;
								case 0:
									array[num + num6] = array[num - 1];
									num5 = Class65.smethod_1(45);
									continue;
								case 2:
									num6 = 0;
									num5 = 1;
									goto case 1;
								case 1:
									{
										if (num6 == 0)
										{
											goto IL_007c;
										}
										num5 = 0;
										goto case 0;
									}
									IL_007c:
									if (num6 >= num4)
									{
										goto end_IL_00bd;
									}
									goto case 0;
								}
								break;
							}
							continue;
							end_IL_00bd:
							break;
						}
						num += num4 - 1;
					}
					else if (num3 == 17)
					{
						while (true)
						{
							switch (Class65.smethod_1(42))
							{
							case 2:
								break;
							default:
								continue;
							case 0:
							{
								num7 = class67_1.method_0(3) + 3;
								int num8 = 1;
								goto case 1;
							}
							case 1:
							{
								num += num7 - 1;
								int num8 = 2;
								break;
							}
							}
							break;
						}
					}
					else if (num3 == 18)
					{
						int num9 = class67_1.method_0(7) + 11;
						num += num9 - 1;
					}
					goto case 5;
				case 2:
				{
					array[num] = num3;
					int num2 = 5;
					goto case 5;
				}
				case 3:
					{
						num3 = smethod_0(class67_1, class63_0);
						int num2 = 4;
						goto case 4;
					}
					IL_0048:
					if (num >= int_4)
					{
						return array;
					}
					goto case 3;
				}
			}
		}
	}

	private sealed class Class67
	{
		private uint uint_0;

		private int int_0;

		private int int_1;

		private Stream stream_0;

		internal long long_0;

		internal Class67(Stream stream_1)
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

	private sealed class Class68
	{
		private byte[] byte_0;

		private int int_0;

		internal int int_1;

		internal long long_0;

		internal Class68(int int_2)
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
				int num = smethod_1(42);
				while (true)
				{
					switch (num)
					{
					case 2:
						goto IL_0011;
					case 0:
						if (int_3 >= int_1)
						{
							num = 2;
							goto IL_0011;
						}
						if (int_0 + int_3 > int_1)
						{
							int num2 = int_1 - int_0;
							while (true)
							{
								int num3 = smethod_1(37);
								while (true)
								{
									switch (num3)
									{
									case 3:
										Array.Copy(byte_1, int_2 + num2, byte_0, 0, length);
										num3 = 2;
										goto IL_0096;
									case 2:
										goto IL_0096;
									case 1:
										length = int_0 + int_3 - int_1;
										num3 = 0;
										goto case 0;
									case 0:
										Array.Copy(byte_1, int_2, byte_0, int_0, num2);
										num3 = 3;
										goto case 3;
									case 4:
										return;
									}
									break;
									IL_0096:
									int_0 = length;
									num3 = smethod_1(47);
								}
							}
						}
						Array.Copy(byte_1, int_2, byte_0, int_0, int_3);
						while (true)
						{
							switch (smethod_1(42))
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
					case 1:
						int_0 = 0;
						num = 3;
						return;
					case 3:
						return;
					}
					break;
					IL_0011:
					Array.Copy(byte_1, int_2, byte_0, 0, int_1);
					num = smethod_1(37);
				}
			}
		}

		internal byte[] method_2(int int_2, int int_3)
		{
			byte[] array = new byte[int_3];
			while (true)
			{
				switch (smethod_1(37))
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
						int num3 = smethod_1(42);
						while (true)
						{
							switch (num3)
							{
							case 2:
								Array.Copy(byte_0, int_1 - num2, array, 0, num2);
								num3 = smethod_1(37);
								continue;
							case 0:
								if (num2 < int_3)
								{
									num3 = 2;
									goto case 2;
								}
								Array.Copy(byte_0, int_1 - num2, array, 0, int_3);
								goto end_IL_0013;
							case 1:
								Array.Copy(byte_0, 0, array, num2, int_3 - num2);
								num3 = 3;
								goto end_IL_0013;
							case 3:
								goto end_IL_0013;
							}
							break;
						}
					}
				}
				case 0:
				{
					Array.Copy(byte_0, int_0 - int_2, array, 0, int_3);
					int num = 2;
					break;
				}
				case 2:
					break;
					end_IL_0013:
					break;
				}
				break;
			}
			return array;
		}
	}

	public static void smethod_0(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[4096];
		Class66 @class = new Class66(stream_0);
		while (true)
		{
			int num = @class.method_0(array, 0, array.Length);
			while (true)
			{
				switch (smethod_1(37))
				{
				default:
					continue;
				case 1:
					if (num > 0)
					{
						int num2 = 0;
						goto case 0;
					}
					return;
				case 0:
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
			36 => 5, 
			37 => 1, 
			38 => 2, 
			41 => 12, 
			42 => 0, 
			43 => 7, 
			45 => 3, 
			47 => 4, 
			49 => 6, 
			_ => -1, 
		};
	}
}
