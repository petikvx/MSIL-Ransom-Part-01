using System.IO;
using ns5;

namespace ns1;

internal static class Class7
{
	internal class Class8
	{
		internal int int_0 = 16;

		internal long long_0;

		internal Class12 class12_0;

		internal Class11 class11_0;

		public Class8()
		{
			class12_0 = new Class12();
			class11_0 = new Class11(class12_0);
		}
	}

	internal class Class9
	{
		public class Class10
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			internal short[] short_1;

			internal int[] int_2;

			internal int int_3;

			internal Class9 class9_0;

			public Class10(Class9 class9_1, int int_4, int int_5, int int_6)
			{
				class9_0 = class9_1;
				int_0 = int_5;
				int_3 = int_6;
				short_0 = new short[int_4];
				int_2 = new int[int_6];
			}
		}

		internal static readonly int[] int_0;

		internal static readonly byte[] byte_0;

		internal Class12 class12_0;

		internal Class10 class10_0;

		internal Class10 class10_1;

		internal Class10 class10_2;

		internal short[] short_0;

		internal byte[] byte_1;

		internal int int_1;

		internal int int_2;

		internal static readonly short[] short_1;

		internal static readonly byte[] byte_2;

		internal static readonly short[] short_2;

		internal static readonly byte[] byte_3;

		static Class9()
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
				short_1[num] = Class24.smethod_45(48 + num << 8);
				byte_2[num++] = 8;
			}
			while (num < 256)
			{
				short_1[num] = Class24.smethod_45(256 + num << 7);
				byte_2[num++] = 9;
			}
			while (num < 280)
			{
				short_1[num] = Class24.smethod_45(-256 + num << 9);
				byte_2[num++] = 7;
			}
			while (num < 286)
			{
				short_1[num] = Class24.smethod_45(-88 + num << 8);
				byte_2[num++] = 8;
			}
			short_2 = new short[30];
			byte_3 = new byte[30];
			for (num = 0; num < 30; num++)
			{
				short_2[num] = Class24.smethod_45(num << 11);
				byte_3[num] = 5;
			}
		}

		public Class9(Class12 class12_1)
		{
			class12_0 = class12_1;
			class10_0 = new Class10(this, 286, 257, 15);
			class10_1 = new Class10(this, 30, 1, 15);
			class10_2 = new Class10(this, 19, 4, 7);
			short_0 = new short[16384];
			byte_1 = new byte[16384];
		}
	}

	internal class Class11
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

		internal Class12 class12_0;

		internal Class9 class9_0;

		public Class11(Class12 class12_1)
		{
			class12_0 = class12_1;
			class9_0 = new Class9(class12_1);
			byte_0 = new byte[65536];
			short_0 = new short[32768];
			short_1 = new short[32768];
			int num = 1;
			int_4 = 1;
			int_3 = 1;
		}
	}

	internal class Class12
	{
		protected internal byte[] byte_0 = new byte[65536];

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;
	}

	internal class Stream0 : MemoryStream
	{
	}

	public static string string_0;
}
