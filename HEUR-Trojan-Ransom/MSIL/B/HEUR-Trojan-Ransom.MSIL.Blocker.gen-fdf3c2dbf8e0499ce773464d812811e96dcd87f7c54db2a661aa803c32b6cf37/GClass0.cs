using System;
using System.IO;

public class GClass0
{
	private class Class2
	{
		private Struct4 struct4_0;

		private Struct4 struct4_1;

		private readonly Struct5[] struct5_0 = new Struct5[16];

		private readonly Struct5[] struct5_1 = new Struct5[16];

		private Struct5 struct5_2 = new Struct5(8);

		private uint uint_0;

		public void method_0(uint uint_1)
		{
			for (uint num = uint_0; num < uint_1; num++)
			{
				struct5_0[num] = new Struct5(3);
				struct5_1[num] = new Struct5(3);
			}
			uint_0 = uint_1;
		}

		public void method_1()
		{
			struct4_0.method_0();
			for (uint num = 0u; num < uint_0; num++)
			{
				struct5_0[num].method_0();
				struct5_1[num].method_0();
			}
			struct4_1.method_0();
			struct5_2.method_0();
		}

		public uint method_2(Class4 class4_0, uint uint_1)
		{
			if (struct4_0.method_1(class4_0) == 0)
			{
				return struct5_0[uint_1].method_1(class4_0);
			}
			uint num = 8u;
			if (struct4_1.method_1(class4_0) == 0)
			{
				return num + struct5_1[uint_1].method_1(class4_0);
			}
			num += 8;
			return num + struct5_2.method_1(class4_0);
		}
	}

	private class Class3
	{
		private struct Struct3
		{
			private Struct4[] struct4_0;

			public void method_0()
			{
				struct4_0 = new Struct4[768];
			}

			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					struct4_0[i].method_0();
				}
			}

			public byte method_2(Class4 class4_0)
			{
				uint num = 1u;
				do
				{
					num = (num << 1) | struct4_0[num].method_1(class4_0);
				}
				while (num < 256);
				return (byte)num;
			}

			public byte method_3(Class4 class4_0, byte byte_0)
			{
				uint num = 1u;
				do
				{
					uint num2 = (uint)(byte_0 >> 7) & 1u;
					byte_0 = (byte)(byte_0 << 1);
					uint num3 = struct4_0[(1 + num2 << 8) + num].method_1(class4_0);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						while (num < 256)
						{
							num = (num << 1) | struct4_0[num].method_1(class4_0);
						}
						break;
					}
				}
				while (num < 256);
				return (byte)num;
			}
		}

		private uint uint_0 = 1u;

		private Struct3[] struct3_0;

		private int int_0;

		private int int_1;

		private uint uint_1;

		public void method_0(int int_2, int int_3)
		{
			if (struct3_0 == null || int_0 != int_3 || int_1 != int_2)
			{
				int_1 = int_2;
				uint_1 = (uint)((1 << int_2) - 1);
				int_0 = int_3;
				uint num = (uint)(1 << int_0 + int_1);
				struct3_0 = new Struct3[num];
				for (uint num2 = 0u; num2 < num; num2++)
				{
					struct3_0[num2].method_0();
				}
			}
		}

		public void method_1()
		{
			uint num = (uint)(1 << int_0 + int_1);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				struct3_0[num2].method_1();
			}
		}

		private uint method_2(uint uint_2, byte byte_0)
		{
			return ((uint_2 & uint_1) << int_0) + (uint)(byte_0 >> 8 - int_0);
		}

		public byte method_3(Class4 class4_0, uint uint_2, byte byte_0)
		{
			return struct3_0[method_2(uint_2, byte_0)].method_2(class4_0);
		}

		public byte method_4(Class4 class4_0, uint uint_2, byte byte_0, byte byte_1)
		{
			return struct3_0[method_2(uint_2, byte_0)].method_3(class4_0, byte_1);
		}
	}

	private uint uint_0 = 1u;

	private readonly GClass1 gclass1_0 = new GClass1();

	private readonly Class4 class4_0 = new Class4();

	private readonly Struct4[] struct4_0 = new Struct4[192];

	private readonly Struct4[] struct4_1 = new Struct4[12];

	private readonly Struct4[] struct4_2 = new Struct4[12];

	private readonly Struct4[] struct4_3 = new Struct4[12];

	private readonly Struct4[] struct4_4 = new Struct4[12];

	private readonly Struct4[] struct4_5 = new Struct4[192];

	private readonly Struct5[] struct5_0 = new Struct5[4];

	private readonly Struct4[] struct4_6 = new Struct4[114];

	private Struct5 struct5_1 = new Struct5(4);

	private readonly Class2 class2_0 = new Class2();

	private readonly Class2 class2_1 = new Class2();

	private readonly Class3 class3_0 = new Class3();

	private uint uint_1;

	private uint uint_2;

	private uint uint_3;

	public GClass0()
	{
		uint_1 = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			struct5_0[i] = new Struct5(6);
		}
	}

	private void method_0(uint uint_4)
	{
		if (uint_1 != uint_4)
		{
			uint_1 = uint_4;
			uint_2 = Math.Max(uint_1, 1u);
			uint uint_5 = Math.Max(uint_2, 4096u);
			gclass1_0.method_0(uint_5);
		}
	}

	private void method_1(int int_0, int int_1)
	{
		if (int_0 > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (int_1 > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		class3_0.method_0(int_0, int_1);
	}

	private void method_2(int int_0)
	{
		if (int_0 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = (uint)(1 << int_0);
		class2_0.method_0(num);
		class2_1.method_0(num);
		uint_3 = num - 1;
	}

	private void method_3(Stream stream_0, Stream stream_1)
	{
		class4_0.method_0(stream_0);
		gclass1_0.method_1(stream_1, bool_0: false);
		for (uint num = 0u; num < 12; num++)
		{
			for (uint num2 = 0u; num2 <= uint_3; num2++)
			{
				uint num3 = (num << 4) + num2;
				struct4_0[num3].method_0();
				struct4_5[num3].method_0();
			}
			struct4_1[num].method_0();
			struct4_2[num].method_0();
			struct4_3[num].method_0();
			struct4_4[num].method_0();
		}
		class3_0.method_1();
		for (uint num = 0u; num < 4; num++)
		{
			struct5_0[num].method_0();
		}
		for (uint num = 0u; num < 114; num++)
		{
			struct4_6[num].method_0();
		}
		class2_0.method_1();
		class2_1.method_1();
		struct5_1.method_0();
	}

	public void method_4(Stream stream_0, Stream stream_1, long long_0)
	{
		method_3(stream_0, stream_1);
		Class1.Struct2 @struct = default(Class1.Struct2);
		@struct.method_0();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (0uL < (ulong)long_0)
		{
			if (struct4_0[@struct.uint_0 << 4].method_1(class4_0) != 0)
			{
				throw new InvalidDataException("IsMatchDecoders");
			}
			@struct.method_1();
			byte byte_ = class3_0.method_3(class4_0, 0u, 0);
			gclass1_0.method_5(byte_);
			num5++;
		}
		while (num5 < (ulong)long_0)
		{
			uint num6 = (uint)(int)num5 & uint_3;
			if (struct4_0[(@struct.uint_0 << 4) + num6].method_1(class4_0) == 0)
			{
				byte byte_2 = gclass1_0.method_6(0u);
				byte byte_3 = (@struct.method_5() ? class3_0.method_3(class4_0, (uint)num5, byte_2) : class3_0.method_4(class4_0, (uint)num5, byte_2, gclass1_0.method_6(num)));
				gclass1_0.method_5(byte_3);
				@struct.method_1();
				num5++;
				continue;
			}
			uint num8;
			if (struct4_1[@struct.uint_0].method_1(class4_0) == 1)
			{
				if (struct4_2[@struct.uint_0].method_1(class4_0) == 0)
				{
					if (struct4_5[(@struct.uint_0 << 4) + num6].method_1(class4_0) == 0)
					{
						@struct.method_4();
						gclass1_0.method_5(gclass1_0.method_6(num));
						num5++;
						continue;
					}
				}
				else
				{
					uint num7;
					if (struct4_3[@struct.uint_0].method_1(class4_0) == 0)
					{
						num7 = num2;
					}
					else
					{
						if (struct4_4[@struct.uint_0].method_1(class4_0) == 0)
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
				num8 = class2_1.method_2(class4_0, num6) + 2;
				@struct.method_3();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				num8 = 2 + class2_0.method_2(class4_0, num6);
				@struct.method_2();
				uint num9 = struct5_0[Class1.smethod_0(num8)].method_1(class4_0);
				if (num9 >= 4)
				{
					int num10 = (int)((num9 >> 1) - 1);
					num = (2 | (num9 & 1)) << num10;
					if (num9 < 14)
					{
						num += Struct5.smethod_0(struct4_6, num - num9 - 1, class4_0, num10);
					}
					else
					{
						num += class4_0.method_2(num10 - 4) << 4;
						num += struct5_1.method_2(class4_0);
					}
				}
				else
				{
					num = num9;
				}
			}
			if (num < gclass1_0.uint_4 + num5 && num < uint_2)
			{
				gclass1_0.method_4(num, num8);
				num5 += num8;
				continue;
			}
			if (num == uint.MaxValue)
			{
				break;
			}
			throw new InvalidDataException("rep0");
		}
		gclass1_0.method_3();
		gclass1_0.method_2();
		class4_0.method_1();
	}

	public void method_5(byte[] byte_0)
	{
		if (byte_0.Length < 5)
		{
			throw new ArgumentException("properties.Length < 5");
		}
		int int_ = (int)byte_0[0] % 9;
		int num = (int)byte_0[0] / 9;
		int int_2 = num % 5;
		int num2 = num / 5;
		if (num2 > 4)
		{
			throw new ArgumentException("pb > Base.kNumPosStatesBitsMax");
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
