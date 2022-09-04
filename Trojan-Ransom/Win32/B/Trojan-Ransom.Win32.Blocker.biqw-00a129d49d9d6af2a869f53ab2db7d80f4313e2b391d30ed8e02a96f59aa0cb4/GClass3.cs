using System;
using System.IO;
using ns0;
using ns1;
using ns4;
using ns5;

public sealed class GClass3 : Interface3, Interface4
{
	private sealed class Class2
	{
		private Struct5 struct5_0 = default(Struct5);

		private Struct5 struct5_1 = default(Struct5);

		private Struct6[] struct6_0 = new Struct6[16];

		private Struct6[] struct6_1 = new Struct6[16];

		private Struct6 struct6_2 = new Struct6(8);

		private uint uint_0;

		public void method_0(uint uint_1)
		{
			for (uint num = uint_0; num < uint_1; num++)
			{
				ref Struct6 reference = ref struct6_0[num];
				reference = new Struct6(3);
				ref Struct6 reference2 = ref struct6_1[num];
				reference2 = new Struct6(3);
			}
			uint_0 = uint_1;
		}

		public void method_1()
		{
			struct5_0.method_1();
			for (uint num = 0u; num < uint_0; num++)
			{
				struct6_0[num].method_0();
				struct6_1[num].method_0();
			}
			struct5_1.method_1();
			struct6_2.method_0();
		}

		public uint method_2(Class5 class5_0, uint uint_1)
		{
			if (struct5_0.method_2(class5_0) == 0)
			{
				return struct6_0[uint_1].method_1(class5_0);
			}
			uint num = 8u;
			if (struct5_1.method_2(class5_0) == 0)
			{
				return num + struct6_1[uint_1].method_1(class5_0);
			}
			num += 8;
			return num + struct6_2.method_1(class5_0);
		}
	}

	private sealed class Class3
	{
		private struct Struct1
		{
			private Struct5[] struct5_0;

			public void method_0()
			{
				struct5_0 = new Struct5[768];
			}

			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					struct5_0[i].method_1();
				}
			}

			public byte method_2(Class5 class5_0)
			{
				uint num = 1u;
				do
				{
					num = (num << 1) | struct5_0[num].method_2(class5_0);
				}
				while (num < 256);
				return (byte)num;
			}

			public byte method_3(Class5 class5_0, byte byte_0)
			{
				uint num = 1u;
				do
				{
					uint num2 = (uint)(byte_0 >> 7) & 1u;
					byte_0 = (byte)(byte_0 << 1);
					uint num3 = struct5_0[(1 + num2 << 8) + num].method_2(class5_0);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						while (num < 256)
						{
							num = (num << 1) | struct5_0[num].method_2(class5_0);
						}
						break;
					}
				}
				while (num < 256);
				return (byte)num;
			}
		}

		private Struct1[] struct1_0;

		private int int_0;

		private int int_1;

		private uint uint_0;

		public void method_0(int int_2, int int_3)
		{
			if (struct1_0 == null || int_0 != int_3 || int_1 != int_2)
			{
				int_1 = int_2;
				uint_0 = (uint)((1 << int_2) - 1);
				int_0 = int_3;
				uint num = (uint)(1 << int_0 + int_1);
				struct1_0 = new Struct1[num];
				for (uint num2 = 0u; num2 < num; num2++)
				{
					struct1_0[num2].method_0();
				}
			}
		}

		public void method_1()
		{
			uint num = (uint)(1 << int_0 + int_1);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				struct1_0[num2].method_1();
			}
		}

		private uint method_2(uint uint_1, byte byte_0)
		{
			return ((uint_1 & uint_0) << int_0) + (uint)(byte_0 >> 8 - int_0);
		}

		public byte method_3(Class5 class5_0, uint uint_1, byte byte_0)
		{
			return struct1_0[method_2(uint_1, byte_0)].method_2(class5_0);
		}

		public byte method_4(Class5 class5_0, uint uint_1, byte byte_0, byte byte_1)
		{
			return struct1_0[method_2(uint_1, byte_0)].method_3(class5_0, byte_1);
		}
	}

	private GClass2 gclass2_0 = new GClass2();

	private Class5 class5_0 = new Class5();

	private Struct5[] struct5_0 = new Struct5[192];

	private Struct5[] struct5_1 = new Struct5[12];

	private Struct5[] struct5_2 = new Struct5[12];

	private Struct5[] struct5_3 = new Struct5[12];

	private Struct5[] struct5_4 = new Struct5[12];

	private Struct5[] struct5_5 = new Struct5[192];

	private Struct6[] struct6_0 = new Struct6[4];

	private Struct5[] struct5_6 = new Struct5[114];

	private Struct6 struct6_1 = new Struct6(4);

	private Class2 class2_0 = new Class2();

	private Class2 class2_1 = new Class2();

	private Class3 class3_0 = new Class3();

	private uint uint_0;

	private uint uint_1;

	private uint uint_2;

	public GClass3()
	{
		uint_0 = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			ref Struct6 reference = ref struct6_0[i];
			reference = new Struct6(6);
		}
	}

	private void method_0(uint uint_3)
	{
		if (uint_0 != uint_3)
		{
			uint_0 = uint_3;
			uint_1 = Math.Max(uint_0, 1u);
			uint uint_4 = Math.Max(uint_1, 4096u);
			gclass2_0.method_0(uint_4);
		}
	}

	private void method_1(int int_0, int int_1)
	{
		if (int_0 > 8)
		{
			throw new Exception1();
		}
		if (int_1 > 8)
		{
			throw new Exception1();
		}
		class3_0.method_0(int_0, int_1);
	}

	private void method_2(int int_0)
	{
		if (int_0 > 4)
		{
			throw new Exception1();
		}
		uint num = (uint)(1 << int_0);
		class2_0.method_0(num);
		class2_1.method_0(num);
		uint_2 = num - 1;
	}

	private void method_3(Stream stream_0, Stream stream_1)
	{
		class5_0.method_0(stream_0);
		gclass2_0.method_2(stream_1);
		for (uint num = 0u; num < 12; num++)
		{
			for (uint num2 = 0u; num2 <= uint_2; num2++)
			{
				uint num3 = (num << 4) + num2;
				struct5_0[num3].method_1();
				struct5_5[num3].method_1();
			}
			struct5_1[num].method_1();
			struct5_2[num].method_1();
			struct5_3[num].method_1();
			struct5_4[num].method_1();
		}
		class3_0.method_1();
		for (uint num = 0u; num < 4; num++)
		{
			struct6_0[num].method_0();
		}
		for (uint num = 0u; num < 114; num++)
		{
			struct5_6[num].method_1();
		}
		class2_0.method_1();
		class2_1.method_1();
		struct6_1.method_0();
	}

	public void imethod_0(Stream stream_0, Stream stream_1, long long_0, long long_1, Interface5 interface5_0)
	{
		method_3(stream_0, stream_1);
		Class0.Struct0 @struct = default(Class0.Struct0);
		@struct.method_0();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (0uL < (ulong)long_1)
		{
			if (struct5_0[@struct.uint_0 << 4].method_2(class5_0) != 0)
			{
				throw new Exception0();
			}
			@struct.method_1();
			byte byte_ = class3_0.method_3(class5_0, 0u, 0);
			gclass2_0.method_6(byte_);
			num5++;
		}
		while (num5 < (ulong)long_1)
		{
			uint num6 = (uint)(int)num5 & uint_2;
			if (struct5_0[(@struct.uint_0 << 4) + num6].method_2(class5_0) == 0)
			{
				byte byte_2 = gclass2_0.method_7(0u);
				byte byte_3 = (@struct.method_5() ? class3_0.method_3(class5_0, (uint)num5, byte_2) : class3_0.method_4(class5_0, (uint)num5, byte_2, gclass2_0.method_7(num)));
				gclass2_0.method_6(byte_3);
				@struct.method_1();
				num5++;
				continue;
			}
			uint num8;
			if (struct5_1[@struct.uint_0].method_2(class5_0) == 1)
			{
				if (struct5_2[@struct.uint_0].method_2(class5_0) == 0)
				{
					if (struct5_5[(@struct.uint_0 << 4) + num6].method_2(class5_0) == 0)
					{
						@struct.method_4();
						gclass2_0.method_6(gclass2_0.method_7(num));
						num5++;
						continue;
					}
				}
				else
				{
					uint num7;
					if (struct5_3[@struct.uint_0].method_2(class5_0) == 0)
					{
						num7 = num2;
					}
					else
					{
						if (struct5_4[@struct.uint_0].method_2(class5_0) == 0)
						{
							num7 = num3;
						}
						else
						{
							num7 = num4;
							num4 = num3;
						}
						num3 = num2;
					}
					num2 = num;
					num = num7;
				}
				num8 = class2_1.method_2(class5_0, num6) + 2;
				@struct.method_3();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				num8 = 2 + class2_0.method_2(class5_0, num6);
				@struct.method_2();
				uint num9 = struct6_0[Class0.smethod_0(num8)].method_1(class5_0);
				if (num9 >= 4)
				{
					int num10 = (int)((num9 >> 1) - 1);
					num = (2 | (num9 & 1)) << num10;
					if (num9 < 14)
					{
						num += Struct6.smethod_0(struct5_6, num - num9 - 1, class5_0, num10);
					}
					else
					{
						num += class5_0.method_7(num10 - 4) << 4;
						num += struct6_1.method_2(class5_0);
					}
				}
				else
				{
					num = num9;
				}
			}
			if (num < num5 && num < uint_1)
			{
				gclass2_0.method_5(num, num8);
				num5 += num8;
				continue;
			}
			if (num == uint.MaxValue)
			{
				break;
			}
			throw new Exception0();
		}
		gclass2_0.method_4();
		gclass2_0.method_3();
		class5_0.method_1();
	}

	public void imethod_1(byte[] byte_0)
	{
		if (byte_0.Length < 5)
		{
			throw new Exception1();
		}
		int int_ = (int)byte_0[0] % 9;
		int num = (int)byte_0[0] / 9;
		int int_2 = num % 5;
		int num2 = num / 5;
		if (num2 > 4)
		{
			throw new Exception1();
		}
		uint num3 = 0u;
		for (int i = 0; i < 4; i++)
		{
			num3 += (uint)(byte_0[1 + i] << i * 8);
		}
		method_0(num3);
		method_1(int_2, int_);
		method_2(num2);
	}
}
