using System;
using System.IO;

internal sealed class Class96
{
	public sealed class Class97
	{
		private Class99 class99_0 = new Class99(32769);

		private Class98 class98_0;

		private Class95 class95_0;

		private int int_0 = -1;

		private int int_1 = -1;

		private bool bool_0;

		private int int_2;

		private long long_0;

		private long long_1;

		private bool bool_1;

		private int int_3;

		private bool bool_2;

		public Class97(Stream stream_0)
		{
			class98_0 = new Class98(stream_0);
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
						switch (Class96.smethod_1(84))
						{
						default:
							continue;
						case 0:
							if (num2 > 0)
							{
								int num3 = 1;
								goto case 1;
							}
							int_0 = -1;
							break;
						case 1:
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
			long_0 = class98_0.long_0;
			int num4 = default(int);
			while (true)
			{
				int num = Class96.smethod_1(78);
				while (true)
				{
					switch (num)
					{
					case 5:
						goto IL_002c;
					case 4:
						bool_0 = class98_0.method_0(1) > 0;
						num = 5;
						goto IL_002c;
					case 0:
						if (int_0 == 7)
						{
							num = 7;
							goto case 7;
						}
						if (int_0 == 3)
						{
							Struct11[] struct11_ = Class91.struct11_0;
							while (true)
							{
								int num2 = Class96.smethod_1(83);
								while (true)
								{
									switch (num2)
									{
									case 2:
									{
										Struct11[] struct11_2 = Class91.struct11_1;
										num2 = Class96.smethod_1(77);
										continue;
									}
									case 3:
										int_2 = 0;
										num2 = 1;
										goto case 1;
									case 1:
										class95_0 = Class91.class95_0;
										num2 = 0;
										goto case 0;
									case 0:
										bool_2 = false;
										num2 = 4;
										goto end_IL_010b;
									case 4:
										goto end_IL_010b;
									}
									break;
								}
								continue;
								end_IL_010b:
								break;
							}
						}
						else if (int_0 == 10)
						{
							method_6(class98_0, out var struct11_, out var struct11_2);
							while (true)
							{
								switch (Class96.smethod_1(84))
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
									class95_0 = Class91.smethod_4(struct11_, struct11_2);
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
					case 7:
						class98_0.method_1();
						num = 2;
						goto case 2;
					case 2:
						num4 = class98_0.method_0(16) ^ 0xE239;
						num = 1;
						goto case 1;
					case 1:
						int_2 = num4;
						num = 6;
						goto case 6;
					case 6:
						class95_0 = null;
						num = 3;
						goto case 3;
					case 3:
						bool_2 = true;
						num = 8;
						goto case 8;
					case 8:
						long_1 = class98_0.long_0;
						return true;
					}
					break;
					IL_002c:
					int_0 = class98_0.method_0(4);
					num = Class96.smethod_1(84);
				}
			}
		}

		private int method_2(byte[] byte_0, int int_4, int int_5)
		{
			int num = int_4;
			if (int_0 == 7)
			{
				if (int_2 > 0)
				{
					int num2 = Math.Min(int_5, int_2);
					while (true)
					{
						int num3 = Class96.smethod_1(84);
						while (true)
						{
							switch (num3)
							{
							case 4:
								int_5 -= num2;
								num3 = 2;
								goto case 2;
							case 2:
								int_4 += num2;
								num3 = Class96.smethod_1(82);
								continue;
							case 3:
								int_2 -= num2;
								num3 = 4;
								goto case 4;
							case 1:
								class99_0.method_1(byte_0, int_4, num2);
								num3 = 3;
								goto case 3;
							case 0:
								class98_0.method_2(byte_0, int_4, num2);
								num3 = 1;
								goto case 1;
							case 5:
								goto end_IL_00ee;
							}
							break;
						}
						continue;
						end_IL_00ee:
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
						int num4 = smethod_0(class98_0, class95_0.class94_0);
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
								switch (Class96.smethod_1(80))
								{
								default:
									continue;
								case 1:
								{
									class99_0.method_0((byte)num4);
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
							int num6 = smethod_1(class98_0, num4);
							while (true)
							{
								int num7 = Class96.smethod_1(80);
								while (true)
								{
									switch (num7)
									{
									case 2:
										int_1 = num8;
										num7 = Class96.smethod_1(84);
										continue;
									case 1:
										num8 = smethod_2(class98_0, class95_0.class94_1);
										num7 = 2;
										goto case 2;
									case 0:
										int_3 = num6;
										num7 = 3;
										goto case 3;
									case 3:
										method_3(byte_0, ref int_4, ref int_5);
										goto end_IL_0233;
									}
									break;
								}
								continue;
								end_IL_0233:
								break;
							}
						}
					}
					while (int_5 > 0);
				}
			}
			long_1 = class98_0.long_0;
			return int_4 - num;
		}

		private void method_3(byte[] byte_0, ref int int_4, ref int int_5)
		{
			int num = Math.Min(int_3, int_5);
			byte[] array = class99_0.method_2(int_1, Math.Min(num, int_1));
			while (true)
			{
				switch (Class96.smethod_1(84))
				{
				default:
					continue;
				case 0:
				{
					int_5 -= num;
					int num2 = 1;
					goto case 1;
				}
				case 1:
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
					switch (Class96.smethod_1(84))
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
						class99_0.method_1(array, 0, array.Length);
						goto end_IL_0072;
					}
					continue;
					end_IL_0072:
					break;
				}
			}
			Array.Copy(array, 0, byte_0, int_4, num);
			int_4 += num;
			class99_0.method_1(array, 0, num);
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

		private static int smethod_0(Class98 class98_1, Class94 class94_0)
		{
			while (class94_0 != null && ((!class94_0.bool_0) ? true : false))
			{
				class94_0 = ((class98_1.method_0(1) > 0) ? class94_0.class94_1 : class94_0.class94_0);
			}
			return class94_0.ushort_0;
		}

		private static int smethod_1(Class98 class98_1, int int_4)
		{
			Class91.smethod_7(int_4, out var int_5, out var int_6);
			if (int_6 > 0)
			{
				return int_5 + class98_1.method_0(int_6);
			}
			return int_5;
		}

		private static int smethod_2(Class98 class98_1, Class94 class94_0)
		{
			int num = smethod_0(class98_1, class94_0);
			int num3 = default(int);
			int num5 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num2 = Class96.smethod_1(84);
				while (true)
				{
					switch (num2)
					{
					case 3:
						if (num3 > 0)
						{
							goto IL_000e;
						}
						return num5;
					case 1:
						num3 = Class91.int_4[num];
						num2 = 3;
						goto case 3;
					case 0:
						num5 = Class91.int_3[num];
						num2 = 1;
						goto case 1;
					case 2:
						num4 = class98_1.method_0(num3);
						num2 = 4;
						goto case 4;
					case 4:
						return num5 + num4;
					}
					break;
					IL_000e:
					num2 = Class96.smethod_1(83);
				}
			}
		}

		private void method_6(Class98 class98_1, out Struct11[] struct11_0, out Struct11[] struct11_1)
		{
			int num = class98_1.method_0(5) + 257;
			int num2 = default(int);
			int num4 = default(int);
			int[] array = default(int[]);
			int[] array2 = default(int[]);
			int num5 = default(int);
			int num7 = default(int);
			int[] array3 = default(int[]);
			int num9 = default(int);
			while (true)
			{
				switch (Class96.smethod_1(83))
				{
				case 2:
				{
					num2 = class98_1.method_0(5) + 1;
					int num3 = 6;
					goto case 6;
				}
				case 6:
				{
					num4 = class98_1.method_0(4) + 4;
					int num3 = 4;
					goto case 4;
				}
				case 4:
				{
					array = Class91.int_0;
					int num3 = 0;
					goto case 0;
				}
				case 0:
				{
					array2 = new int[19];
					int num3 = 1;
					goto case 1;
				}
				case 1:
				{
					num5 = 0;
					int num3 = 3;
					goto case 3;
				}
				case 3:
				{
					if (num5 == 0)
					{
						goto IL_0087;
					}
					int num3 = 5;
					goto case 5;
				}
				case 7:
					num5++;
					goto IL_0087;
				case 5:
					{
						array2[array[num5]] = class98_1.method_0(3);
						int num3 = 7;
						goto case 7;
					}
					IL_0087:
					if (num5 >= num4)
					{
						Class94 class94_ = Class91.smethod_5(Class91.smethod_2(array2));
						while (true)
						{
							int num6 = Class96.smethod_1(77);
							while (true)
							{
								switch (num6)
								{
								case 5:
									num7++;
									goto IL_00b5;
								case 2:
									goto IL_00ba;
								case 4:
									num7 = 0;
									num6 = 0;
									goto case 0;
								case 0:
									if (num7 != 0)
									{
										num6 = 2;
										goto IL_00ba;
									}
									goto IL_00b5;
								case 3:
									array3 = smethod_3(class98_1, class94_, num + num2);
									num6 = 1;
									goto case 1;
								case 1:
									{
										struct11_0 = new Struct11[num];
										num6 = 4;
										goto case 4;
									}
									IL_00b5:
									if (num7 < num)
									{
										goto IL_00ba;
									}
									Class91.smethod_3(struct11_0);
									while (true)
									{
										int num8 = Class96.smethod_1(84);
										while (true)
										{
											switch (num8)
											{
											case 4:
												num9 = 0;
												num8 = 1;
												goto case 1;
											case 1:
												if (num9 != 0)
												{
													goto IL_0141;
												}
												goto case 5;
											case 0:
												struct11_1 = new Struct11[num2];
												num8 = 4;
												goto case 4;
											case 3:
												struct11_1[num9].int_1 = array3[num9 + num];
												num8 = 2;
												goto case 2;
											case 2:
												num9++;
												num8 = 5;
												goto case 5;
											case 5:
												if (num9 >= num2)
												{
													Class91.smethod_3(struct11_1);
													return;
												}
												goto case 3;
											}
											break;
											IL_0141:
											num8 = Class96.smethod_1(77);
										}
									}
								}
								break;
								IL_00ba:
								struct11_0[num7].int_1 = array3[num7];
								num6 = Class96.smethod_1(82);
							}
						}
					}
					goto case 5;
				}
			}
		}

		private static int[] smethod_3(Class98 class98_1, Class94 class94_0, int int_4)
		{
			int[] array = new int[int_4];
			int num = 0;
			int num9 = default(int);
			int num5 = default(int);
			while (num < int_4)
			{
				int num2 = smethod_0(class98_1, class94_0);
				while (true)
				{
					switch (Class96.smethod_1(84))
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
							int num7 = class98_1.method_0(2) + 3;
							while (true)
							{
								int num8 = Class96.smethod_1(84);
								while (true)
								{
									switch (num8)
									{
									case 1:
										if (num9 != 0)
										{
											num8 = Class96.smethod_1(83);
											continue;
										}
										goto IL_008b;
									case 0:
										num9 = 0;
										num8 = 1;
										goto case 1;
									case 2:
										array[num + num9] = array[num - 1];
										num8 = 3;
										goto case 3;
									case 3:
										{
											num9++;
											goto IL_008b;
										}
										IL_008b:
										if (num9 >= num7)
										{
											goto end_IL_0080;
										}
										goto case 2;
									}
									break;
								}
								continue;
								end_IL_0080:
								break;
							}
							num += num7 - 1;
							break;
						}
						case 17:
							while (true)
							{
								switch (Class96.smethod_1(80))
								{
								default:
									continue;
								case 1:
								{
									num5 = class98_1.method_0(3) + 3;
									int num6 = 0;
									goto case 0;
								}
								case 0:
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
							int num4 = class98_1.method_0(7) + 11;
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
	}

	private sealed class Class98
	{
		private uint uint_0;

		private int int_0;

		private int int_1;

		private Stream stream_0;

		internal long long_0;

		internal Class98(Stream stream_1)
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

	private sealed class Class99
	{
		private byte[] byte_0;

		private int int_0;

		internal int int_1;

		internal long long_0;

		internal Class99(int int_2)
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
					int num2 = smethod_1(83);
					while (true)
					{
						switch (num2)
						{
						case 2:
							length = int_0 + int_3 - int_1;
							num2 = 1;
							goto IL_0066;
						case 1:
							goto IL_0066;
						case 3:
							Array.Copy(byte_1, int_2 + num, byte_0, 0, length);
							num2 = 0;
							goto case 0;
						case 0:
							int_0 = length;
							num2 = 4;
							return;
						case 4:
							return;
						}
						break;
						IL_0066:
						Array.Copy(byte_1, int_2, byte_0, int_0, num);
						num2 = smethod_1(77);
					}
				}
			}
			Array.Copy(byte_1, int_2, byte_0, int_0, int_3);
			while (true)
			{
				switch (smethod_1(84))
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
					int num2 = smethod_1(83);
					while (true)
					{
						switch (num2)
						{
						case 2:
							if (num < int_3)
							{
								num2 = 0;
								goto case 0;
							}
							Array.Copy(byte_0, int_1 - num, array, 0, int_3);
							goto end_IL_0080;
						case 0:
							Array.Copy(byte_0, int_1 - num, array, 0, num);
							num2 = 1;
							goto case 1;
						case 1:
							Array.Copy(byte_0, 0, array, num, int_3 - num);
							num2 = smethod_1(77);
							continue;
						case 3:
							goto end_IL_0080;
						}
						break;
					}
					continue;
					end_IL_0080:
					break;
				}
			}
			return array;
		}
	}

	public static void smethod_0(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[4096];
		Class97 @class = new Class97(stream_0);
		while (true)
		{
			int num = @class.method_0(array, 0, array.Length);
			while (true)
			{
				switch (smethod_1(84))
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
			76 => 9, 
			77 => 3, 
			78 => 4, 
			80 => 1, 
			81 => 15, 
			82 => 5, 
			83 => 2, 
			84 => 0, 
			85 => 11, 
			86 => 6, 
			88 => 22, 
			91 => 17, 
			_ => -1, 
		};
	}
}
