using System.IO;

namespace ns10;

internal static class Class31
{
	internal class Class32
	{
		internal static readonly int[] int_0 = new int[29]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258
		};

		internal static readonly int[] int_1 = new int[29]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0
		};

		internal static readonly int[] int_2 = new int[30]
		{
			1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
			33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
			1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
		};

		internal static readonly int[] int_3 = new int[30]
		{
			0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
			4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
			9, 9, 10, 10, 11, 11, 12, 12, 13, 13
		};

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal int int_8;

		internal bool bool_0;

		internal Class33 class33_0;

		internal Class34 class34_0;

		internal Class36 class36_0;

		internal Class35 class35_0;

		internal Class35 class35_1;

		public Class32(byte[] bytes)
		{
			class33_0 = new Class33();
			class34_0 = new Class34();
			int_4 = 2;
			Class56.smethod_86(0, bytes.Length, bytes, class33_0);
		}

		internal static bool pc2sNIDtWOHZIyAL2Jo()
		{
			return true;
		}

		internal static bool EGPa3UD1NJLTe5hkXU9()
		{
			return false;
		}
	}

	internal class Class33
	{
		internal byte[] byte_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		public int AvailableBits => int_2;

		public int AvailableBytes => int_1 - int_0 + (int_2 >> 3);

		public bool IsNeedingInput => int_0 == int_1;

		internal static bool mxKQxvDWQKhIsRXAvBK()
		{
			return true;
		}

		internal static bool fyQFG6Dx0HnmNWY6jWg()
		{
			return false;
		}
	}

	internal class Class34
	{
		internal byte[] byte_0 = new byte[32768];

		internal int int_0;

		internal int int_1;

		internal static bool AYS4dcDehdVi4JMat9s()
		{
			return true;
		}

		internal static bool Bhbg9HDiKjuWY9w5WYa()
		{
			return false;
		}
	}

	internal class Class35
	{
		internal short[] short_0;

		public static readonly Class35 class35_0;

		public static readonly Class35 class35_1;

		static Class35()
		{
			byte[] array = new byte[288];
			int num = 0;
			while (num < 144)
			{
				array[num++] = 8;
			}
			while (num < 256)
			{
				array[num++] = 9;
			}
			while (num < 280)
			{
				array[num++] = 7;
			}
			while (num < 288)
			{
				array[num++] = 8;
			}
			class35_0 = new Class35(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			class35_1 = new Class35(array);
		}

		public Class35(byte[] codeLengths)
		{
			Class56.smethod_149(this, codeLengths);
		}

		internal static bool vWxLjjDZfkN42pNOymo()
		{
			return true;
		}

		internal static bool c50P46DBosiXw8rOjuf()
		{
			return false;
		}
	}

	internal class Class36
	{
		internal static readonly int[] int_0 = new int[3] { 3, 3, 11 };

		internal static readonly int[] int_1;

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal Class35 class35_0;

		internal int int_2;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal byte byte_2;

		internal int int_8;

		internal static readonly int[] int_9;

		static Class36()
		{
			if (HXXCPLDwCUPb8cLM3d7())
			{
			}
			switch (2)
			{
			case 0:
			case 2:
				int_1 = new int[3] { 2, 3, 7 };
				break;
			}
			int_9 = new int[19]
			{
				16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
				11, 4, 12, 3, 13, 2, 14, 1, 15
			};
		}

		internal static bool maAeBkDq5ILLdUY2Gq3()
		{
			return true;
		}

		internal static bool HXXCPLDwCUPb8cLM3d7()
		{
			return false;
		}
	}

	internal class Class37
	{
		internal int int_0;

		internal long long_0;

		internal Class41 class41_0;

		internal Class40 class40_0;

		public long TotalOut => long_0;

		public bool IsFinished
		{
			get
			{
				if (int_0 == 30)
				{
					return class41_0.IsFlushed;
				}
				return false;
			}
		}

		public bool IsNeedingInput => Class56.smethod_102(class40_0);

		public Class37()
		{
			while (true)
			{
				int_0 = 16;
				int num = 3;
				if (!t7Qf5ADPssYwy0Nhfyr())
				{
					break;
				}
				while (true)
				{
					switch (num)
					{
					default:
						num = 4;
						if (t7Qf5ADPssYwy0Nhfyr())
						{
							continue;
						}
						break;
					case 0:
					case 2:
						break;
					case 1:
					case 3:
						base._002Ector();
						goto end_IL_002b;
					case 4:
						goto end_IL_002b;
					}
					break;
				}
				continue;
				end_IL_002b:
				break;
			}
			class41_0 = new Class41();
			class40_0 = new Class40(class41_0);
		}

		internal static bool t7Qf5ADPssYwy0Nhfyr()
		{
			return true;
		}

		internal static bool JEwl8ZDAaCyDsMgYMEk()
		{
			return false;
		}
	}

	internal class Class38
	{
		public class Class39
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			internal short[] short_1;

			internal int[] int_2;

			internal int int_3;

			internal Class38 class38_0;

			public Class39(Class38 dh, int elems, int minCodes, int maxLength)
			{
				class38_0 = dh;
				int_0 = minCodes;
				int_3 = maxLength;
				short_0 = new short[elems];
				int_2 = new int[maxLength];
			}

			internal static bool oWhWdiXDowKdGKcmJFt()
			{
				return true;
			}

			internal static bool scBOTmXXFnhN84aBLRx()
			{
				return false;
			}
		}

		internal static readonly int[] int_0;

		internal static readonly byte[] byte_0;

		internal Class41 class41_0;

		internal Class39 class39_0;

		internal Class39 class39_1;

		internal Class39 class39_2;

		internal short[] short_0;

		internal byte[] byte_1;

		internal int int_1;

		internal int int_2;

		internal static readonly short[] short_1;

		internal static readonly byte[] byte_2;

		internal static readonly short[] short_2;

		internal static readonly byte[] byte_3;

		static Class38()
		{
			int_0 = new int[19]
			{
				16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
				11, 4, 12, 3, 13, 2, 14, 1, 15
			};
			while (true)
			{
				byte_0 = new byte[16]
				{
					0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
					5, 13, 3, 11, 7, 15
				};
				short_1 = new short[286];
				byte_2 = new byte[286];
				int i = 0;
				while (true)
				{
					if (i < 144)
					{
						short_1[i] = Class56.smethod_155(48 + i << 8);
					}
					else
					{
						while (true)
						{
							if (i < 256)
							{
								short_1[i] = Class56.smethod_155(256 + i << 7);
								byte_2[i++] = 9;
								continue;
							}
							while (true)
							{
								IL_0105:
								if (i < 280)
								{
									short_1[i] = Class56.smethod_155(-256 + i << 9);
									byte_2[i++] = 7;
									continue;
								}
								while (true)
								{
									IL_00fb:
									if (i < 286)
									{
										short_1[i] = Class56.smethod_155(-88 + i << 8);
										byte_2[i++] = 8;
										continue;
									}
									short_2 = new short[30];
									while (true)
									{
										byte_3 = new byte[30];
										if (!lGHCowDzxl6TiRHVFw3())
										{
											break;
										}
										switch (6)
										{
										case 4:
											break;
										case 3:
											continue;
										default:
											goto IL_00fb;
										case 5:
											goto IL_0105;
										case 2:
										case 8:
											goto end_IL_00b6;
										case 0:
										case 1:
											goto end_IL_0120;
										case 6:
											i = 0;
											goto case 9;
										case 9:
											for (; i < 30; i++)
											{
												short_2[i] = Class56.smethod_155(i << 11);
												byte_3[i] = 5;
											}
											return;
										}
										goto end_IL_0113;
										continue;
										end_IL_00b6:
										break;
									}
									break;
								}
								break;
							}
							continue;
							end_IL_0113:
							break;
						}
					}
					byte_2[i++] = 8;
					continue;
					end_IL_0120:
					break;
				}
			}
		}

		public Class38(Class41 pending)
		{
			class41_0 = pending;
			class39_0 = new Class39(this, 286, 257, 15);
			class39_1 = new Class39(this, 30, 1, 15);
			class39_2 = new Class39(this, 19, 4, 7);
			short_0 = new short[16384];
			byte_1 = new byte[16384];
		}

		internal static bool lGHCowDzxl6TiRHVFw3()
		{
			return true;
		}

		internal static bool u5VdaCXEoDQAyRdgb77()
		{
			return false;
		}
	}

	internal class Class40
	{
		internal int int_0;

		internal short[] short_0;

		internal short[] short_1;

		internal int int_1;

		internal int int_2;

		internal bool bool_0;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal int int_6;

		internal int int_7;

		internal int int_8;

		internal Class41 class41_0;

		internal Class38 class38_0;

		public Class40(Class41 pending)
		{
			class41_0 = pending;
			class38_0 = new Class38(pending);
			byte_0 = new byte[65536];
			short_0 = new short[32768];
			short_1 = new short[32768];
			int num = 1;
			int_4 = 1;
			int_3 = 1;
		}

		internal static bool afccxeXprSZn7Ta8UdO()
		{
			return true;
		}

		internal static bool YcgSEDXlLGfR9Xg59D6()
		{
			return false;
		}
	}

	internal class Class41
	{
		protected internal byte[] byte_0 = new byte[65536];

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		public int BitCount => int_2;

		public bool IsFlushed => int_1 == 0;

		internal static bool XYH8mbXgj3HeleCHTww()
		{
			return true;
		}

		internal static bool ih9CkOXRVXItaRBA5Fv()
		{
			return false;
		}
	}

	internal class Stream0 : MemoryStream
	{
		public Stream0()
		{
		}

		public Stream0(byte[] buffer)
			: base(buffer, writable: false)
		{
		}

		internal static bool N2BTfGXG9b5ZLj228iX()
		{
			return true;
		}

		internal static bool Vg7cfrXKa8tFLTN7Qfs()
		{
			return false;
		}
	}

	public static string string_0;
}
