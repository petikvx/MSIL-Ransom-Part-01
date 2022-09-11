using System;
using System.IO;

internal sealed class Class56
{
	public sealed class Class57
	{
		private Class59 class59_0 = new Class59(32769);

		private Class58 class58_0;

		private Class55 class55_0;

		private int int_0 = -1;

		private int int_1 = -1;

		private bool bool_0;

		private int int_2;

		private long long_0;

		private long long_1;

		private bool bool_1;

		private int int_3;

		private bool bool_2;

		public Class57(Stream stream_0)
		{
			class58_0 = new Class58(stream_0);
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
						switch (Class56.smethod_1(65))
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
			long_0 = class58_0.long_0;
			int num4 = default(int);
			while (true)
			{
				int num = Class56.smethod_1(67);
				while (true)
				{
					switch (num)
					{
					case 7:
						if (int_0 == 1)
						{
							num = 4;
							goto case 4;
						}
						if (int_0 == 5)
						{
							Struct5[] struct5_ = Class51.struct5_0;
							while (true)
							{
								int num2 = Class56.smethod_1(67);
								while (true)
								{
									switch (num2)
									{
									case 3:
										int_2 = 0;
										num2 = 0;
										goto case 0;
									case 0:
										class55_0 = Class51.class55_0;
										num2 = Class56.smethod_1(65);
										continue;
									case 2:
									{
										Struct5[] struct5_2 = Class51.struct5_1;
										num2 = 3;
										goto case 3;
									}
									case 1:
										bool_2 = false;
										num2 = 4;
										goto end_IL_019e;
									case 4:
										goto end_IL_019e;
									}
									break;
								}
								continue;
								end_IL_019e:
								break;
							}
						}
						else if (int_0 == 2)
						{
							method_6(class58_0, out var struct5_, out var struct5_2);
							while (true)
							{
								switch (Class56.smethod_1(60))
								{
								default:
									continue;
								case 0:
								{
									int_2 = 0;
									int num3 = 1;
									goto case 1;
								}
								case 1:
								{
									class55_0 = Class51.smethod_4(struct5_, struct5_2);
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
						class58_0.method_1();
						num = 0;
						goto case 0;
					case 0:
						num4 = class58_0.method_0(16) ^ 0x32E4;
						num = 5;
						goto IL_0075;
					case 5:
						goto IL_0075;
					case 6:
						int_0 = class58_0.method_0(3);
						num = 7;
						goto case 7;
					case 2:
						bool_0 = class58_0.method_0(1) > 0;
						num = 6;
						goto case 6;
					case 3:
						class55_0 = null;
						num = 1;
						goto case 1;
					case 1:
						bool_2 = true;
						num = 8;
						goto case 8;
					case 8:
						long_1 = class58_0.long_0;
						return true;
					}
					break;
					IL_0075:
					int_2 = num4;
					num = Class56.smethod_1(69);
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
						int num3 = Class56.smethod_1(65);
						while (true)
						{
							switch (num3)
							{
							case 4:
								class59_0.method_1(byte_0, int_4, num2);
								num3 = 2;
								goto case 2;
							case 2:
								int_2 -= num2;
								num3 = Class56.smethod_1(60);
								continue;
							case 1:
								class58_0.method_2(byte_0, int_4, num2);
								num3 = 4;
								goto case 4;
							case 0:
								int_5 -= num2;
								num3 = 3;
								goto case 3;
							case 3:
								int_4 += num2;
								num3 = 5;
								goto end_IL_00c6;
							case 5:
								goto end_IL_00c6;
							}
							break;
						}
						continue;
						end_IL_00c6:
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
						int num4 = smethod_0(class58_0, class55_0.class54_0);
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
								switch (Class56.smethod_1(65))
								{
								default:
									continue;
								case 1:
								{
									class59_0.method_0((byte)num4);
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
							int num6 = smethod_1(class58_0, num4);
							while (true)
							{
								switch (Class56.smethod_1(65))
								{
								default:
									continue;
								case 1:
								{
									num7 = smethod_2(class58_0, class55_0.class54_1);
									int num8 = 0;
									goto case 0;
								}
								case 0:
								{
									int_1 = num7;
									int num8 = 2;
									goto case 2;
								}
								case 2:
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
			long_1 = class58_0.long_0;
			return int_4 - num;
		}

		private void method_3(byte[] byte_0, ref int int_4, ref int int_5)
		{
			int num = Math.Min(int_3, int_5);
			byte[] array = default(byte[]);
			while (true)
			{
				int num2 = Class56.smethod_1(65);
				while (true)
				{
					switch (num2)
					{
					case 1:
						array = class59_0.method_2(int_1, Math.Min(num, int_1));
						num2 = 0;
						goto IL_0030;
					case 0:
						goto IL_0030;
					case 2:
						int_3 -= num;
						num2 = 3;
						goto case 3;
					case 3:
					{
						while (num > array.Length)
						{
							Array.Copy(array, 0, byte_0, int_4, array.Length);
							while (true)
							{
								switch (Class56.smethod_1(65))
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
									class59_0.method_1(array, 0, array.Length);
									goto end_IL_007d;
								}
								continue;
								end_IL_007d:
								break;
							}
						}
						Array.Copy(array, 0, byte_0, int_4, num);
						int num4;
						while (true)
						{
							switch (Class56.smethod_1(65))
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
						class59_0.method_1(array, 0, num);
						num4 = 2;
						return;
					}
					}
					break;
					IL_0030:
					int_5 -= num;
					num2 = Class56.smethod_1(67);
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

		private static int smethod_0(Class58 class58_1, Class54 class54_0)
		{
			while (class54_0 != null && ((!class54_0.bool_0) ? true : false))
			{
				class54_0 = ((class58_1.method_0(1) > 0) ? class54_0.class54_1 : class54_0.class54_0);
			}
			return class54_0.ushort_0;
		}

		private static int smethod_1(Class58 class58_1, int int_4)
		{
			Class51.smethod_7(int_4, out var int_5, out var int_6);
			if (int_6 > 0)
			{
				return int_5 + class58_1.method_0(int_6);
			}
			return int_5;
		}

		private static int smethod_2(Class58 class58_1, Class54 class54_0)
		{
			int num = smethod_0(class58_1, class54_0);
			int num3 = default(int);
			int num5 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num2 = Class56.smethod_1(60);
				while (true)
				{
					switch (num2)
					{
					case 3:
						num3 = Class51.int_4[num];
						num2 = 1;
						goto case 1;
					case 1:
						if (num3 > 0)
						{
							goto IL_0019;
						}
						return num5;
					case 0:
						num5 = Class51.int_3[num];
						num2 = 3;
						goto case 3;
					case 2:
						num4 = class58_1.method_0(num3);
						num2 = 4;
						goto case 4;
					case 4:
						return num5 + num4;
					}
					break;
					IL_0019:
					num2 = Class56.smethod_1(67);
				}
			}
		}

		private void method_6(Class58 class58_1, out Struct5[] struct5_0, out Struct5[] struct5_1)
		{
			int num = class58_1.method_0(5) + 257;
			int num8 = default(int);
			int num4 = default(int);
			int[] array3 = default(int[]);
			int[] array = default(int[]);
			int num3 = default(int);
			int num6 = default(int);
			int[] array2 = default(int[]);
			int num9 = default(int);
			while (true)
			{
				int num2 = Class56.smethod_1(66);
				while (true)
				{
					switch (num2)
					{
					case 6:
						num8 = class58_1.method_0(5) + 1;
						num2 = 4;
						goto case 4;
					case 4:
						num4 = class58_1.method_0(4) + 4;
						num2 = 1;
						goto case 1;
					case 1:
						array3 = Class51.int_0;
						num2 = 0;
						goto case 0;
					case 0:
						array = new int[19];
						num2 = 2;
						goto IL_003f;
					case 2:
						goto IL_003f;
					case 3:
						if (num3 == 0)
						{
							goto IL_008c;
						}
						num2 = 5;
						goto case 5;
					case 7:
						num3++;
						goto IL_008c;
					case 5:
						{
							array[array3[num3]] = class58_1.method_0(3);
							num2 = 7;
							goto case 7;
						}
						IL_008c:
						if (num3 >= num4)
						{
							Class54 class54_ = Class51.smethod_5(Class51.smethod_2(array));
							while (true)
							{
								int num5 = Class56.smethod_1(69);
								while (true)
								{
									switch (num5)
									{
									case 3:
										goto IL_00b4;
									case 4:
										struct5_0 = new Struct5[num];
										num5 = 1;
										goto case 1;
									case 1:
										num6 = 0;
										num5 = 0;
										goto case 0;
									case 0:
										if (num6 == 0)
										{
											goto IL_0114;
										}
										num5 = 2;
										goto case 2;
									case 5:
										num6++;
										goto IL_0114;
									case 2:
										{
											struct5_0[num6].int_1 = array2[num6];
											num5 = 5;
											goto case 5;
										}
										IL_0114:
										if (num6 >= num)
										{
											Class51.smethod_3(struct5_0);
											while (true)
											{
												int num7 = Class56.smethod_1(69);
												while (true)
												{
													switch (num7)
													{
													case 3:
														struct5_1 = new Struct5[num8];
														num7 = 2;
														goto case 2;
													case 2:
														num9 = 0;
														num7 = 0;
														goto case 0;
													case 0:
														if (num9 != 0)
														{
															goto IL_014f;
														}
														goto IL_017e;
													case 1:
														struct5_1[num9].int_1 = array2[num9 + num];
														num7 = 4;
														goto case 4;
													case 4:
														{
															num9++;
															goto IL_017e;
														}
														IL_017e:
														if (num9 >= num8)
														{
															Class51.smethod_3(struct5_1);
															return;
														}
														goto case 1;
													}
													break;
													IL_014f:
													num7 = Class56.smethod_1(65);
												}
											}
										}
										goto case 2;
									}
									break;
									IL_00b4:
									array2 = smethod_3(class58_1, class54_, num + num8);
									num5 = Class56.smethod_1(72);
								}
							}
						}
						goto case 5;
					}
					break;
					IL_003f:
					num3 = 0;
					num2 = Class56.smethod_1(69);
				}
			}
		}

		private static int[] smethod_3(Class58 class58_1, Class54 class54_0, int int_4)
		{
			int[] array = new int[int_4];
			int num = default(int);
			int num3 = default(int);
			int num5 = default(int);
			int num7 = default(int);
			while (true)
			{
				switch (Class56.smethod_1(69))
				{
				case 3:
				{
					num = 0;
					int num2 = 0;
					goto case 0;
				}
				case 0:
				{
					if (num == 0)
					{
						goto IL_0048;
					}
					int num2 = 4;
					goto case 4;
				}
				case 5:
					num++;
					goto IL_0048;
				case 2:
					if (num3 < 16)
					{
						int num2 = 1;
						goto case 1;
					}
					if (num3 == 16)
					{
						int num4 = class58_1.method_0(2) + 3;
						while (true)
						{
							switch (Class56.smethod_1(60))
							{
							default:
								continue;
							case 0:
							{
								num5 = 0;
								int num6 = 1;
								goto case 1;
							}
							case 1:
							{
								if (num5 == 0)
								{
									goto IL_00ab;
								}
								int num6 = 2;
								goto case 2;
							}
							case 3:
								num5++;
								goto IL_00ab;
							case 2:
								{
									array[num + num5] = array[num - 1];
									int num6 = 3;
									goto case 3;
								}
								IL_00ab:
								if (num5 >= num4)
								{
									break;
								}
								goto case 2;
							}
							break;
						}
						num += num4 - 1;
					}
					else if (num3 == 17)
					{
						while (true)
						{
							switch (Class56.smethod_1(60))
							{
							case 2:
								break;
							default:
								continue;
							case 0:
							{
								num7 = class58_1.method_0(3) + 3;
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
						int num9 = class58_1.method_0(7) + 11;
						num += num9 - 1;
					}
					goto case 5;
				case 1:
				{
					array[num] = num3;
					int num2 = 5;
					goto case 5;
				}
				case 4:
					{
						num3 = smethod_0(class58_1, class54_0);
						int num2 = 2;
						goto case 2;
					}
					IL_0048:
					if (num >= int_4)
					{
						return array;
					}
					goto case 4;
				}
			}
		}
	}

	private sealed class Class58
	{
		private uint uint_0;

		private int int_0;

		private int int_1;

		private Stream stream_0;

		internal long long_0;

		internal Class58(Stream stream_1)
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

	private sealed class Class59
	{
		private byte[] byte_0;

		private int int_0;

		internal int int_1;

		internal long long_0;

		internal Class59(int int_2)
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
				int num = smethod_1(60);
				while (true)
				{
					switch (num)
					{
					case 0:
						if (int_3 >= int_1)
						{
							goto IL_001a;
						}
						if (int_0 + int_3 > int_1)
						{
							int num2 = int_1 - int_0;
							while (true)
							{
								int num3 = smethod_1(65);
								while (true)
								{
									switch (num3)
									{
									case 1:
										length = int_0 + int_3 - int_1;
										num3 = 0;
										goto IL_0077;
									case 0:
										goto IL_0077;
									case 3:
										Array.Copy(byte_1, int_2 + num2, byte_0, 0, length);
										num3 = 2;
										goto case 2;
									case 2:
										int_0 = length;
										num3 = 4;
										return;
									case 4:
										return;
									}
									break;
									IL_0077:
									Array.Copy(byte_1, int_2, byte_0, int_0, num2);
									num3 = smethod_1(69);
								}
							}
						}
						Array.Copy(byte_1, int_2, byte_0, int_0, int_3);
						while (true)
						{
							switch (smethod_1(65))
							{
							case 1:
							{
								int_0 += int_3;
								int num4 = 0;
								goto case 0;
							}
							case 0:
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
						Array.Copy(byte_1, int_2, byte_0, 0, int_1);
						num = 2;
						goto case 2;
					case 2:
						int_0 = 0;
						num = 3;
						return;
					case 3:
						return;
					}
					break;
					IL_001a:
					num = smethod_1(65);
				}
			}
		}

		internal byte[] method_2(int int_2, int int_3)
		{
			byte[] array = new byte[int_3];
			while (true)
			{
				switch (smethod_1(60))
				{
				default:
					continue;
				case 0:
				{
					if (int_0 >= int_2)
					{
						int num = 1;
						goto case 1;
					}
					int num2 = int_2 - int_0;
					while (true)
					{
						int num3 = smethod_1(67);
						while (true)
						{
							switch (num3)
							{
							case 2:
								if (num2 < int_3)
								{
									num3 = 0;
									goto case 0;
								}
								Array.Copy(byte_0, int_1 - num2, array, 0, int_3);
								goto end_IL_0013;
							case 0:
								Array.Copy(byte_0, int_1 - num2, array, 0, num2);
								num3 = smethod_1(65);
								continue;
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
				case 1:
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
		Class57 @class = new Class57(stream_0);
		while (true)
		{
			int num = @class.method_0(array, 0, array.Length);
			while (true)
			{
				switch (smethod_1(65))
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
			60 => 0, 
			61 => 10, 
			63 => 18, 
			64 => 22, 
			65 => 1, 
			66 => 6, 
			67 => 2, 
			68 => 13, 
			69 => 3, 
			70 => 5, 
			72 => 4, 
			78 => 7, 
			81 => 9, 
			_ => -1, 
		};
	}
}
