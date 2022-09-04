using System.IO;
using ns0;

namespace ns1;

internal class Class30
{
	internal sealed class Class31
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

		internal Class32 class32_0;

		internal Class33 class33_0;

		internal Class35 class35_0;

		internal Class34 class34_0;

		internal Class34 class34_1;

		public Class31(byte[] byte_0)
		{
			class32_0 = new Class32();
			class33_0 = new Class33();
			int_4 = 2;
			Class42.smethod_21(byte_0, 0, byte_0.Length, class32_0);
		}
	}

	internal sealed class Class32
	{
		internal byte[] byte_0;

		internal int int_0 = 0;

		internal int int_1 = 0;

		internal uint uint_0 = 0u;

		internal int int_2 = 0;
	}

	internal sealed class Class33
	{
		internal byte[] byte_0 = new byte[32768];

		internal int int_0 = 0;

		internal int int_1 = 0;
	}

	internal sealed class Class34
	{
		internal short[] short_0;

		public static readonly Class34 class34_0;

		public static readonly Class34 class34_1;

		static Class34()
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
			class34_0 = new Class34(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			class34_1 = new Class34(array);
		}

		public Class34(byte[] byte_0)
		{
			Class42.smethod_158(byte_0, this);
		}
	}

	internal sealed class Class35
	{
		internal static readonly int[] int_0 = new int[3] { 3, 3, 11 };

		internal static readonly int[] int_1 = new int[3] { 2, 3, 7 };

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal Class34 class34_0;

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
	}

	internal sealed class Class36
	{
		internal int int_0 = 16;

		internal long long_0 = 0L;

		internal Class40 class40_0;

		internal Class39 class39_0;

		public Class36()
		{
			class40_0 = new Class40();
			class39_0 = new Class39(class40_0);
		}
	}

	internal sealed class Class37
	{
		public sealed class Class38
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			internal short[] short_1;

			internal int[] int_2;

			internal int int_3;

			internal Class37 class37_0;

			public Class38(Class37 class37_1, int int_4, int int_5, int int_6)
			{
				class37_0 = class37_1;
				int_0 = int_5;
				int_3 = int_6;
				short_0 = new short[int_4];
				int_2 = new int[int_6];
			}
		}

		internal static readonly int[] int_0;

		internal static readonly byte[] byte_0;

		internal Class40 class40_0;

		internal Class38 class38_0;

		internal Class38 class38_1;

		internal Class38 class38_2;

		internal short[] short_0;

		internal byte[] byte_1;

		internal int int_1;

		internal int int_2;

		internal static readonly short[] short_1;

		internal static readonly byte[] byte_2;

		internal static readonly short[] short_2;

		internal static readonly byte[] byte_3;

		static Class37()
		{
			int_0 = new int[19]
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
				short_1[num] = Class42.smethod_43(48 + num << 8);
				byte_2[num++] = 8;
			}
			while (num < 256)
			{
				short_1[num] = Class42.smethod_43(256 + num << 7);
				byte_2[num++] = 9;
			}
			while (num < 280)
			{
				short_1[num] = Class42.smethod_43(-256 + num << 9);
				byte_2[num++] = 7;
			}
			while (num < 286)
			{
				short_1[num] = Class42.smethod_43(-88 + num << 8);
				byte_2[num++] = 8;
			}
			short_2 = new short[30];
			byte_3 = new byte[30];
			for (num = 0; num < 30; num++)
			{
				short_2[num] = Class42.smethod_43(num << 11);
				byte_3[num] = 5;
			}
		}

		public Class37(Class40 class40_1)
		{
			class40_0 = class40_1;
			class38_0 = new Class38(this, 286, 257, 15);
			class38_1 = new Class38(this, 30, 1, 15);
			class38_2 = new Class38(this, 19, 4, 7);
			short_0 = new short[16384];
			byte_1 = new byte[16384];
		}
	}

	internal sealed class Class39
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

		internal Class40 class40_0;

		internal Class37 class37_0;

		public Class39(Class40 class40_1)
		{
			class40_0 = class40_1;
			class37_0 = new Class37(class40_1);
			byte_0 = new byte[65536];
			short_0 = new short[32768];
			short_1 = new short[32768];
			int num = 1;
			int_4 = 1;
			int_3 = 1;
		}
	}

	internal sealed class Class40
	{
		protected internal byte[] byte_0 = new byte[65536];

		internal int int_0 = 0;

		internal int int_1 = 0;

		internal uint uint_0 = 0u;

		internal int int_2 = 0;
	}

	internal sealed class Stream0 : MemoryStream
	{
		public Stream0()
		{
		}

		public Stream0(byte[] byte_0)
			: base(byte_0, writable: false)
		{
		}
	}

	public static string string_0;
}
