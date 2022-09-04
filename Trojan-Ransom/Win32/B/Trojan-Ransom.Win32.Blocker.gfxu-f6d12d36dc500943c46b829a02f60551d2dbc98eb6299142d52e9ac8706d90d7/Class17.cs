using System;
using System.IO;
using ns4;

internal static class Class17
{
	internal class Class18
	{
		internal int int_0;

		internal long long_0;

		internal Class22 class22_0;

		internal Class21 class21_0;

		public Class18()
		{
			Class42.hMqjKD0znI7T7();
			int_0 = 16;
			base._002Ector();
			try
			{
				class22_0 = new Class22();
				class21_0 = new Class21(class22_0);
			}
			catch (Exception exception_)
			{
				Class24.smethod_130(exception_, (object)this);
				throw;
			}
		}
	}

	internal class Class19
	{
		public class Class20
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			internal short[] short_1;

			internal int[] int_2;

			internal int int_3;

			internal Class19 class19_0;

			public Class20(Class19 class19_1, int int_4, int int_5, int int_6)
			{
				Class42.hMqjKD0znI7T7();
				base._002Ector();
				try
				{
					class19_0 = class19_1;
					int_0 = int_5;
					int_3 = int_6;
					short_0 = new short[int_4];
					int_2 = new int[int_6];
				}
				catch (Exception exception_)
				{
					Class24.smethod_21(exception_, (object)this, (object)class19_1, (object)int_4, (object)int_5, (object)int_6);
					throw;
				}
			}
		}

		internal static readonly int[] int_0;

		internal static readonly byte[] byte_0;

		internal Class22 class22_0;

		internal Class20 class20_0;

		internal Class20 class20_1;

		internal Class20 class20_2;

		internal short[] short_0;

		internal byte[] byte_1;

		internal int int_1;

		internal int int_2;

		internal static readonly short[] short_1;

		internal static readonly byte[] byte_2;

		internal static readonly short[] short_2;

		internal static readonly byte[] byte_3;

		static Class19()
		{
			Class42.hMqjKD0znI7T7();
			int i = default(int);
			try
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
				i = 0;
				while (i < 144)
				{
					short_1[i] = Class24.smethod_25(48 + i << 8);
					byte_2[i++] = 8;
				}
				while (i < 256)
				{
					short_1[i] = Class24.smethod_25(256 + i << 7);
					byte_2[i++] = 9;
				}
				while (i < 280)
				{
					short_1[i] = Class24.smethod_25(-256 + i << 9);
					byte_2[i++] = 7;
				}
				while (i < 286)
				{
					short_1[i] = Class24.smethod_25(-88 + i << 8);
					byte_2[i++] = 8;
				}
				short_2 = new short[30];
				byte_3 = new byte[30];
				for (i = 0; i < 30; i++)
				{
					short_2[i] = Class24.smethod_25(i << 11);
					byte_3[i] = 5;
				}
			}
			catch (Exception exception_)
			{
				Class24.smethod_130(exception_, (object)i);
				throw;
			}
		}

		public Class19(Class22 class22_1)
		{
			Class42.hMqjKD0znI7T7();
			base._002Ector();
			try
			{
				class22_0 = class22_1;
				class20_0 = new Class20(this, 286, 257, 15);
				class20_1 = new Class20(this, 30, 1, 15);
				class20_2 = new Class20(this, 19, 4, 7);
				short_0 = new short[16384];
				byte_1 = new byte[16384];
			}
			catch (Exception exception_)
			{
				Class24.smethod_80(exception_, (object)this, (object)class22_1);
				throw;
			}
		}
	}

	internal class Class21
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

		internal object object_0;

		internal int int_6;

		internal int int_7;

		internal int int_8;

		internal Class22 class22_0;

		internal Class19 class19_0;

		public Class21(Class22 class22_1)
		{
			Class42.hMqjKD0znI7T7();
			base._002Ector();
			int num = default(int);
			try
			{
				class22_0 = class22_1;
				class19_0 = new Class19(class22_1);
				byte_0 = new byte[65536];
				short_0 = new short[32768];
				short_1 = new short[32768];
				num = 1;
				int_4 = 1;
				int_3 = 1;
			}
			catch (Exception exception_)
			{
				Class24.smethod_91(exception_, (object)num, (object)this, (object)class22_1);
				throw;
			}
		}
	}

	internal class Class22
	{
		protected internal byte[] byte_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		public Class22()
		{
			Class42.hMqjKD0znI7T7();
			byte_0 = new byte[65536];
			base._002Ector();
		}
	}

	internal class Stream0 : MemoryStream
	{
		public Stream0()
		{
			Class42.hMqjKD0znI7T7();
			base._002Ector();
		}
	}

	public static string string_0;
}
