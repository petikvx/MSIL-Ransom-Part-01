using System.IO;
using ns0;

namespace ns4;

internal class Class15
{
	internal sealed class Class16
	{
		private const int int_0 = 0;

		private const int int_1 = 1;

		private const int int_2 = 2;

		private const int int_3 = 3;

		private const int int_4 = 4;

		private const int int_5 = 5;

		private const int int_6 = 6;

		private const int int_7 = 7;

		private const int int_8 = 8;

		private const int int_9 = 9;

		private const int int_10 = 10;

		private const int int_11 = 11;

		private const int int_12 = 12;

		internal static readonly int[] int_13 = new int[29]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258
		};

		internal static readonly int[] int_14 = new int[29]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0
		};

		internal static readonly int[] int_15 = new int[30]
		{
			1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
			33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
			1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
		};

		internal static readonly int[] int_16 = new int[30]
		{
			0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
			4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
			9, 9, 10, 10, 11, 11, 12, 12, 13, 13
		};

		internal int int_17;

		internal int int_18;

		internal int int_19;

		internal int int_20;

		internal int int_21;

		internal bool bool_0;

		internal Class17 class17_0;

		internal Class18 class18_0;

		internal Class20 class20_0;

		internal Class19 class19_0;

		internal Class19 class19_1;

		public Class16(byte[] bytes)
		{
			class17_0 = new Class17();
			class18_0 = new Class18();
			int_17 = 2;
			Class26.smethod_2(0, bytes, bytes.Length, class17_0);
		}
	}

	internal sealed class Class17
	{
		internal byte[] byte_0;

		internal int int_0 = 0;

		internal int int_1 = 0;

		internal uint uint_0 = 0u;

		internal int int_2 = 0;

		public int AvailableBits => int_2;

		public int AvailableBytes => int_1 - int_0 + (int_2 >> 3);

		public bool IsNeedingInput => int_0 == int_1;
	}

	internal sealed class Class18
	{
		private const int int_0 = 32768;

		private const int int_1 = 32767;

		internal byte[] byte_0 = new byte[32768];

		internal int int_2 = 0;

		internal int int_3 = 0;
	}

	internal sealed class Class19
	{
		private const int int_0 = 15;

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
			Class26.smethod_75(codeLengths, this);
		}
	}

	internal sealed class Class20
	{
		private const int int_0 = 0;

		private const int int_1 = 1;

		private const int int_2 = 2;

		private const int int_3 = 3;

		private const int int_4 = 4;

		private const int int_5 = 5;

		internal static readonly int[] int_6 = new int[3] { 3, 3, 11 };

		internal static readonly int[] int_7 = new int[3] { 2, 3, 7 };

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal Class19 class19_0;

		internal int int_8;

		internal int int_9;

		internal int int_10;

		internal int int_11;

		internal int int_12;

		internal int int_13;

		internal byte byte_2;

		internal int int_14;

		internal static readonly int[] int_15 = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};
	}

	internal sealed class Class21
	{
		private const int int_0 = 4;

		private const int int_1 = 8;

		private const int int_2 = 16;

		private const int int_3 = 20;

		private const int int_4 = 28;

		private const int int_5 = 30;

		internal int int_6 = 16;

		internal long long_0 = 0L;

		internal Class25 class25_0;

		internal Class24 class24_0;

		public long TotalOut => long_0;

		public bool IsFinished
		{
			get
			{
				if (int_6 == 30)
				{
					return class25_0.int_1 == 0;
				}
				return false;
			}
		}

		public bool IsNeedingInput => Class26.smethod_25(class24_0);

		public Class21()
		{
			class25_0 = new Class25();
			class24_0 = new Class24(class25_0);
		}
	}

	internal sealed class Class22
	{
		public sealed class Class23
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
				int_0 = minCodes;
				int_3 = maxLength;
				short_0 = new short[elems];
				int_2 = new int[maxLength];
			}
		}

		private const int int_0 = 16384;

		private const int int_1 = 286;

		private const int int_2 = 30;

		private const int int_3 = 19;

		private const int int_4 = 16;

		private const int int_5 = 17;

		private const int int_6 = 18;

		private const int int_7 = 256;

		internal static readonly int[] int_8;

		internal static readonly byte[] byte_0;

		internal Class25 class25_0;

		internal Class23 class23_0;

		internal Class23 class23_1;

		internal Class23 class23_2;

		internal short[] short_0;

		internal byte[] byte_1;

		internal int int_9;

		internal int int_10;

		internal static readonly short[] short_1;

		internal static readonly byte[] byte_2;

		internal static readonly short[] short_2;

		internal static readonly byte[] byte_3;

		static Class22()
		{
			int_8 = new int[19]
			{
				16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
				11, 4, 12, 3, 13, 2, 14, 1, 15
			};
			byte_0 = new byte[16]
			{
				0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
				5, 13, 3, 11, 7, 15
			};
			short_1 = new short[286];
			byte_2 = new byte[286];
			int num = 0;
			while (num < 144)
			{
				short_1[num] = Class26.smethod_43(48 + num << 8);
				byte_2[num++] = 8;
			}
			while (num < 256)
			{
				short_1[num] = Class26.smethod_43(256 + num << 7);
				byte_2[num++] = 9;
			}
			while (num < 280)
			{
				short_1[num] = Class26.smethod_43(-256 + num << 9);
				byte_2[num++] = 7;
			}
			while (num < 286)
			{
				short_1[num] = Class26.smethod_43(-88 + num << 8);
				byte_2[num++] = 8;
			}
			short_2 = new short[30];
			byte_3 = new byte[30];
			for (num = 0; num < 30; num++)
			{
				short_2[num] = Class26.smethod_43(num << 11);
				byte_3[num] = 5;
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
	}

	internal sealed class Class24
	{
		private const int int_0 = 258;

		private const int int_1 = 3;

		private const int int_2 = 32768;

		private const int int_3 = 32767;

		private const int int_4 = 32768;

		private const int int_5 = 32767;

		private const int int_6 = 5;

		private const int int_7 = 262;

		private const int int_8 = 32506;

		private const int int_9 = 4096;

		internal int int_10;

		internal short[] short_0;

		internal short[] short_1;

		internal int int_11;

		internal int int_12;

		internal bool bool_0;

		internal int int_13;

		internal int int_14;

		internal int int_15;

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal int int_16;

		internal int int_17;

		internal int int_18;

		internal Class25 class25_0;

		internal Class22 class22_0;

		public Class24(Class25 pending)
		{
			class25_0 = pending;
			class22_0 = new Class22(pending);
			byte_0 = new byte[65536];
			short_0 = new short[32768];
			short_1 = new short[32768];
			int_14 = 1;
			int_13 = 1;
		}
	}

	internal sealed class Class25
	{
		protected internal byte[] byte_0 = new byte[65536];

		internal int int_0 = 0;

		internal int int_1 = 0;

		internal uint uint_0 = 0u;

		internal int int_2 = 0;

		public int BitCount => int_2;

		public bool IsFlushed => int_1 == 0;
	}

	internal sealed class Stream0 : MemoryStream
	{
		public Stream0()
		{
		}

		public Stream0(byte[] buffer)
			: base(buffer, writable: false)
		{
		}
	}

	public static string string_0;
}
