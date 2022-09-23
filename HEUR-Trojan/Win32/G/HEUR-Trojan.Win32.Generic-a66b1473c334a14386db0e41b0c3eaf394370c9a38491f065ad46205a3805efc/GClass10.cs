using System;
using System.IO;

public class GClass10
{
	private class Class7
	{
		private Struct5 struct5_0;

		private Struct5 struct5_1;

		private readonly Struct6[] struct6_0 = new Struct6[16];

		private readonly Struct6[] struct6_1 = new Struct6[16];

		private Struct6 struct6_2 = new Struct6(8);

		private uint uint_0;

		public void method_0(uint uint_1)
		{
			for (uint num = uint_0; num < uint_1; num++)
			{
				struct6_0[num] = new Struct6(3);
				struct6_1[num] = new Struct6(3);
			}
			uint_0 = uint_1;
		}

		public void method_1()
		{
			struct5_0.method_0();
			for (uint num = 0u; num < uint_0; num++)
			{
				struct6_0[num].method_0();
				struct6_1[num].method_0();
			}
			struct5_1.method_0();
			struct6_2.method_0();
		}

		public uint method_2(Class9 class9_0, uint uint_1)
		{
			if (struct5_0.method_1(class9_0) == 0)
			{
				return struct6_0[uint_1].method_1(class9_0);
			}
			uint num = 8u;
			if (struct5_1.method_1(class9_0) == 0)
			{
				return num + struct6_1[uint_1].method_1(class9_0);
			}
			num += 8;
			return num + struct6_2.method_1(class9_0);
		}
	}

	private class Class8
	{
		private struct Struct4
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
					struct5_0[i].method_0();
				}
			}

			public byte method_2(Class9 class9_0)
			{
				uint num = 1u;
				do
				{
					num = (num << 1) | struct5_0[num].method_1(class9_0);
				}
				while (num < 256);
				return (byte)num;
			}

			public byte method_3(Class9 class9_0, byte byte_0)
			{
				uint num = 1u;
				do
				{
					uint num2 = (uint)(byte_0 >> 7) & 1u;
					byte_0 = (byte)(byte_0 << 1);
					uint num3 = struct5_0[(1 + num2 << 8) + num].method_1(class9_0);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						while (num < 256)
						{
							num = (num << 1) | struct5_0[num].method_1(class9_0);
						}
						break;
					}
				}
				while (num < 256);
				return (byte)num;
			}
		}

		private uint uint_0 = 1u;

		private Struct4[] struct4_0;

		private int int_0;

		private int int_1;

		private uint uint_1;

		public void method_0(int int_2, int int_3)
		{
			if (struct4_0 == null || int_0 != int_3 || int_1 != int_2)
			{
				int_1 = int_2;
				uint_1 = (uint)((1 << int_2) - 1);
				int_0 = int_3;
				uint num = (uint)(1 << int_0 + int_1);
				struct4_0 = new Struct4[num];
				for (uint num2 = 0u; num2 < num; num2++)
				{
					struct4_0[num2].method_0();
				}
			}
		}

		public void method_1()
		{
			uint num = (uint)(1 << int_0 + int_1);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				struct4_0[num2].method_1();
			}
		}

		private uint method_2(uint uint_2, byte byte_0)
		{
			return ((uint_2 & uint_1) << int_0) + (uint)(byte_0 >> 8 - int_0);
		}

		public byte method_3(Class9 class9_0, uint uint_2, byte byte_0)
		{
			return struct4_0[method_2(uint_2, byte_0)].method_2(class9_0);
		}

		public byte method_4(Class9 class9_0, uint uint_2, byte byte_0, byte byte_1)
		{
			return struct4_0[method_2(uint_2, byte_0)].method_3(class9_0, byte_1);
		}
	}

	private uint uint_0 = 1u;

	private readonly GClass11 gclass11_0 = new GClass11();

	private readonly Class9 class9_0 = new Class9();

	private readonly Struct5[] struct5_0 = new Struct5[192];

	private readonly Struct5[] struct5_1 = new Struct5[12];

	private readonly Struct5[] struct5_2 = new Struct5[12];

	private readonly Struct5[] struct5_3 = new Struct5[12];

	private readonly Struct5[] struct5_4 = new Struct5[12];

	private readonly Struct5[] struct5_5 = new Struct5[192];

	private readonly Struct6[] struct6_0 = new Struct6[4];

	private readonly Struct5[] struct5_6 = new Struct5[114];

	private Struct6 struct6_1 = new Struct6(4);

	private readonly Class7 class7_0 = new Class7();

	private readonly Class7 class7_1 = new Class7();

	private readonly Class8 class8_0 = new Class8();

	private uint uint_1;

	private uint uint_2;

	private uint uint_3;

	public GClass10()
	{
		uint_1 = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			struct6_0[i] = new Struct6(6);
		}
	}

	private void method_0(uint uint_4)
	{
		if (uint_1 != uint_4)
		{
			uint_1 = uint_4;
			uint_2 = Math.Max(uint_1, 1u);
			uint uint_5 = Math.Max(uint_2, 4096u);
			gclass11_0.method_0(uint_5);
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
		class8_0.method_0(int_0, int_1);
	}

	private void method_2(int int_0)
	{
		if (int_0 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = (uint)(1 << int_0);
		class7_0.method_0(num);
		class7_1.method_0(num);
		uint_3 = num - 1;
	}

	private void method_3(Stream stream_0, Stream stream_1)
	{
		class9_0.method_0(stream_0);
		gclass11_0.method_1(stream_1, bool_0: false);
		for (uint num = 0u; num < 12; num++)
		{
			for (uint num2 = 0u; num2 <= uint_3; num2++)
			{
				uint num3 = (num << 4) + num2;
				struct5_0[num3].method_0();
				struct5_5[num3].method_0();
			}
			struct5_1[num].method_0();
			struct5_2[num].method_0();
			struct5_3[num].method_0();
			struct5_4[num].method_0();
		}
		class8_0.method_1();
		for (uint num = 0u; num < 4; num++)
		{
			struct6_0[num].method_0();
		}
		for (uint num = 0u; num < 114; num++)
		{
			struct5_6[num].method_0();
		}
		class7_0.method_1();
		class7_1.method_1();
		struct6_1.method_0();
	}

	public void method_4(Stream stream_0, Stream stream_1, long long_0)
	{
		method_3(stream_0, stream_1);
		Class6.Struct3 @struct = default(Class6.Struct3);
		@struct.method_0();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (0uL < (ulong)long_0)
		{
			if (struct5_0[@struct.uint_0 << 4].method_1(class9_0) != 0)
			{
				throw new InvalidDataException("IsMatchDecoders");
			}
			@struct.method_1();
			byte byte_ = class8_0.method_3(class9_0, 0u, 0);
			gclass11_0.method_5(byte_);
			num5++;
		}
		while (num5 < (ulong)long_0)
		{
			uint num6 = (uint)(int)num5 & uint_3;
			if (struct5_0[(@struct.uint_0 << 4) + num6].method_1(class9_0) == 0)
			{
				byte byte_2 = gclass11_0.method_6(0u);
				byte byte_3 = (@struct.method_5() ? class8_0.method_3(class9_0, (uint)num5, byte_2) : class8_0.method_4(class9_0, (uint)num5, byte_2, gclass11_0.method_6(num)));
				gclass11_0.method_5(byte_3);
				@struct.method_1();
				num5++;
				continue;
			}
			uint num8;
			if (struct5_1[@struct.uint_0].method_1(class9_0) == 1)
			{
				if (struct5_2[@struct.uint_0].method_1(class9_0) == 0)
				{
					if (struct5_5[(@struct.uint_0 << 4) + num6].method_1(class9_0) == 0)
					{
						@struct.method_4();
						gclass11_0.method_5(gclass11_0.method_6(num));
						num5++;
						continue;
					}
				}
				else
				{
					uint num7;
					if (struct5_3[@struct.uint_0].method_1(class9_0) == 0)
					{
						num7 = num2;
					}
					else
					{
						if (struct5_4[@struct.uint_0].method_1(class9_0) == 0)
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
				num8 = class7_1.method_2(class9_0, num6) + 2;
				@struct.method_3();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				num8 = 2 + class7_0.method_2(class9_0, num6);
				@struct.method_2();
				uint num9 = struct6_0[Class6.smethod_0(num8)].method_1(class9_0);
				if (num9 >= 4)
				{
					int num10 = (int)((num9 >> 1) - 1);
					num = (2 | (num9 & 1)) << num10;
					if (num9 < 14)
					{
						num += Struct6.smethod_0(struct5_6, num - num9 - 1, class9_0, num10);
					}
					else
					{
						num += class9_0.method_2(num10 - 4) << 4;
						num += struct6_1.method_2(class9_0);
					}
				}
				else
				{
					num = num9;
				}
			}
			if (num < gclass11_0.uint_4 + num5 && num < uint_2)
			{
				gclass11_0.method_4(num, num8);
				num5 += num8;
				continue;
			}
			if (num == uint.MaxValue)
			{
				break;
			}
			throw new InvalidDataException("rep0");
		}
		gclass11_0.method_3();
		gclass11_0.method_2();
		class9_0.method_1();
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
