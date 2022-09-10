using System.IO;

namespace ns8;

internal static class Class15
{
	internal class Class16
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

		internal Class17 class17_0;

		internal Class18 class18_0;

		internal Class20 class20_0;

		internal Class19 class19_0;

		internal Class19 class19_1;

		public Class16(byte[] bytes)
		{
			class17_0 = new Class17();
			while (true)
			{
				class18_0 = new Class18();
				while (true)
				{
					int_4 = 2;
					int num = 4;
					if (!zZBOKEXCCWJy5dIrHr())
					{
					}
					while (true)
					{
						switch (num)
						{
						default:
							num = 3;
							if (sN9i5olqwBY9alL0fF())
							{
								continue;
							}
							break;
						case 1:
						case 3:
							break;
						case 0:
						case 2:
							goto end_IL_003b;
						case 4:
							Class33.smethod_55(bytes.Length, 0, class17_0, bytes);
							return;
						}
						break;
					}
					continue;
					end_IL_003b:
					break;
				}
			}
		}

		internal static bool sN9i5olqwBY9alL0fF()
		{
			return true;
		}

		internal static bool zZBOKEXCCWJy5dIrHr()
		{
			return false;
		}
	}

	internal class Class17
	{
		internal byte[] byte_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		public int AvailableBits => int_2;

		public int AvailableBytes => int_1 - int_0 + (int_2 >> 3);

		public bool IsNeedingInput => int_0 == int_1;

		internal static bool M6JFinZp8JDujFs8Kt()
		{
			return true;
		}

		internal static bool xSaeoHudddqBQih4Lr()
		{
			return false;
		}
	}

	internal class Class18
	{
		internal byte[] byte_0 = new byte[32768];

		internal int int_0;

		internal int int_1;

		internal static bool tRNo04zllftckohVnr()
		{
			return true;
		}

		internal static bool OS9J7h7887t2MpUL0LL()
		{
			return false;
		}
	}

	internal class Class19
	{
		internal short[] short_0;

		public static readonly Class19 class19_0;

		public static readonly Class19 class19_1;

		static Class19()
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
			class19_0 = new Class19(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			class19_1 = new Class19(array);
		}

		public Class19(byte[] codeLengths)
		{
			Class33.smethod_35(this, codeLengths);
		}

		internal static bool JHFYPd77qVeIiXUSEph()
		{
			return true;
		}

		internal static bool UMMJii7roBAPYk2Lg5c()
		{
			return false;
		}
	}

	internal class Class20
	{
		internal static readonly int[] int_0 = new int[3] { 3, 3, 11 };

		internal static readonly int[] int_1 = new int[3] { 2, 3, 7 };

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal Class19 class19_0;

		internal int int_2;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal byte byte_2;

		internal int int_8;

		internal static readonly int[] int_9 = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};

		internal static bool e46MkR7T026UcOD6xfv()
		{
			return true;
		}

		internal static bool IFFuZv7UBvME7EH3yRH()
		{
			return false;
		}
	}

	internal class Class21
	{
		internal int int_0 = 16;

		internal long long_0;

		internal Class25 class25_0;

		internal Class24 class24_0;

		public long TotalOut => long_0;

		public bool IsFinished
		{
			get
			{
				if (int_0 == 30)
				{
					return class25_0.IsFlushed;
				}
				return false;
			}
		}

		public bool IsNeedingInput => Class33.smethod_130(class24_0);

		public Class21()
		{
			class25_0 = new Class25();
			class24_0 = new Class24(class25_0);
		}

		internal static bool aSej3S7LEThnHg29vxo()
		{
			return true;
		}

		internal static bool LxQnwL7pyi4pqZgPmTY()
		{
			return false;
		}
	}

	internal class Class22
	{
		public class Class23
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			internal short[] short_1;

			internal int[] int_2;

			internal int int_3;

			internal Class22 class22_0;

			public Class23(Class22 dh, int elems, int minCodes, int maxLength)
			{
				class22_0 = dh;
				if (!N6pMKU7mOQ1LrUR466v())
				{
					switch (2)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_003e;
					case 4:
						goto IL_0052;
					}
				}
				int_0 = minCodes;
				goto IL_003e;
				IL_0052:
				int_2 = new int[maxLength];
				return;
				IL_003e:
				int_3 = maxLength;
				short_0 = new short[elems];
				goto IL_0052;
			}

			internal static bool V7S8M772t5IJRAc9lQB()
			{
				return true;
			}

			internal static bool N6pMKU7mOQ1LrUR466v()
			{
				return false;
			}
		}

		internal static readonly int[] int_0;

		internal static readonly byte[] byte_0;

		internal Class25 class25_0;

		internal Class23 class23_0;

		internal Class23 class23_1;

		internal Class23 class23_2;

		internal short[] short_0;

		internal byte[] byte_1;

		internal int int_1;

		internal int int_2;

		internal static readonly short[] short_1;

		internal static readonly byte[] byte_2;

		internal static readonly short[] short_2;

		internal static readonly byte[] byte_3;

		static Class22()
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
				int num = 0;
				while (true)
				{
					if (num < 144)
					{
						short_1[num] = Class33.smethod_139(48 + num << 8);
						byte_2[num++] = 8;
						if (!X3QHhM74e63SWRfM2y5())
						{
							switch (5)
							{
							case 5:
								break;
							case 2:
								goto end_IL_0075;
							case 3:
								goto IL_00e0;
							case 1:
								goto IL_010c;
							default:
								goto IL_0134;
							case 0:
								goto IL_0148;
							case 6:
							case 7:
								goto IL_0170;
							case 9:
								goto IL_0174;
							}
							continue;
						}
						goto IL_0174;
					}
					goto IL_00e0;
					IL_0148:
					byte_3 = new byte[30];
					num = 0;
					goto IL_0174;
					IL_0174:
					if (num < 30)
					{
						short_2[num] = Class33.smethod_139(num << 11);
						byte_3[num] = 5;
						goto IL_0170;
					}
					return;
					IL_00e0:
					while (num < 256)
					{
						short_1[num] = Class33.smethod_139(256 + num << 7);
						byte_2[num++] = 9;
					}
					goto IL_010c;
					IL_010c:
					while (num < 280)
					{
						short_1[num] = Class33.smethod_139(-256 + num << 9);
						byte_2[num++] = 7;
					}
					goto IL_0134;
					IL_0134:
					while (num < 286)
					{
						short_1[num] = Class33.smethod_139(-88 + num << 8);
						byte_2[num++] = 8;
					}
					short_2 = new short[30];
					goto IL_0148;
					IL_0170:
					num++;
					goto IL_0174;
					continue;
					end_IL_0075:
					break;
				}
			}
		}

		public Class22(Class25 pending)
		{
			class25_0 = pending;
			class23_0 = new Class23(this, 286, 257, 15);
			class23_1 = new Class23(this, 30, 1, 15);
			class23_2 = new Class23(this, 19, 4, 7);
			short_0 = new short[16384];
			byte_1 = new byte[16384];
		}

		internal static bool GyIZZr7aDxuNuk9MTnA()
		{
			return true;
		}

		internal static bool X3QHhM74e63SWRfM2y5()
		{
			return false;
		}
	}

	internal class Class24
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

		internal Class25 class25_0;

		internal Class22 class22_0;

		public Class24(Class25 pending)
		{
			class25_0 = pending;
			while (true)
			{
				class22_0 = new Class22(pending);
				byte_0 = new byte[65536];
				if (!UOcr107Mxj1wANijUNd())
				{
					switch (4)
					{
					case 0:
					case 2:
						break;
					case 1:
					case 4:
						short_0 = new short[32768];
						goto IL_0067;
					default:
						goto IL_0067;
					case 5:
						goto end_IL_000d;
					}
					continue;
				}
				goto IL_0067;
				IL_0067:
				short_1 = new short[32768];
				break;
				continue;
				end_IL_000d:
				break;
			}
			int num = 1;
			int_4 = 1;
			int_3 = 1;
		}

		internal static bool M7X8X97Y4a2VC7ewOb1()
		{
			return true;
		}

		internal static bool UOcr107Mxj1wANijUNd()
		{
			return false;
		}
	}

	internal class Class25
	{
		protected internal byte[] byte_0 = new byte[65536];

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		public int BitCount => int_2;

		public bool IsFlushed => int_1 == 0;

		internal static bool K9UMNg7RmKlwfjvjIoM()
		{
			return true;
		}

		internal static bool HOn4tV7SEPpSRXSkj0w()
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

		internal static bool eRK2sr7txVZ8SNNfVNj()
		{
			return true;
		}

		internal static bool DCg0BU73MgAHhXcT3ar()
		{
			return false;
		}
	}

	public static string string_0;
}
