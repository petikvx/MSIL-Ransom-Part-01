using System;
using System.IO;

public class GClass0
{
	private class Class35
	{
		private Struct3 struct3_0 = new Struct3(8);

		private readonly Struct3[] struct3_1 = new Struct3[16];

		private uint uint_0;

		private Struct2 struct2_0;

		private readonly Struct3[] struct3_2 = new Struct3[16];

		private Struct2 struct2_1;

		public void method_0()
		{
			struct2_1.method_1();
			for (uint num = 0u; num < uint_0; num++)
			{
				struct3_1[num].method_1();
				struct3_2[num].method_1();
			}
			struct2_0.method_1();
			struct3_0.method_1();
		}

		public uint method_1(Class37 class37_0, uint uint_1)
		{
			if (struct2_1.method_0(class37_0) == 0)
			{
				return struct3_1[uint_1].method_0(class37_0);
			}
			uint num = 8u;
			if (struct2_0.method_0(class37_0) == 0)
			{
				return num + struct3_2[uint_1].method_0(class37_0);
			}
			num += 8;
			return num + struct3_0.method_0(class37_0);
		}

		public void method_2(uint uint_1)
		{
			for (uint num = uint_0; num < uint_1; num++)
			{
				struct3_1[num] = new Struct3(3);
				struct3_2[num] = new Struct3(3);
			}
			uint_0 = uint_1;
		}
	}

	private class Class36
	{
		private struct Struct1
		{
			private Struct2[] struct2_0;

			public byte method_0(Class37 class37_0, byte byte_0)
			{
				uint num = 1u;
				do
				{
					uint num2 = (uint)(byte_0 >> 7) & 1u;
					byte_0 = (byte)(byte_0 << 1);
					uint num3 = struct2_0[(1 + num2 << 8) + num].method_0(class37_0);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						while (num < 256)
						{
							num = (num << 1) | struct2_0[num].method_0(class37_0);
						}
						break;
					}
				}
				while (num < 256);
				return (byte)num;
			}

			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					struct2_0[i].method_1();
				}
			}

			public byte method_2(Class37 class37_0)
			{
				uint num = 1u;
				do
				{
					num = (num << 1) | struct2_0[num].method_0(class37_0);
				}
				while (num < 256);
				return (byte)num;
			}

			public void method_3()
			{
				struct2_0 = new Struct2[768];
			}
		}

		private int int_0;

		private uint uint_0;

		private int int_1;

		private Struct1[] struct1_0;

		private uint uint_1 = 1u;

		public byte method_0(Class37 class37_0, uint uint_2, byte byte_0, byte byte_1)
		{
			return struct1_0[method_2(uint_2, byte_0)].method_0(class37_0, byte_1);
		}

		public void method_1()
		{
			uint num = (uint)(1 << int_0 + int_1);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				struct1_0[num2].method_1();
			}
		}

		private uint method_2(uint uint_2, byte byte_0)
		{
			return ((uint_2 & uint_0) << int_0) + (uint)(byte_0 >> 8 - int_0);
		}

		public byte method_3(Class37 class37_0, uint uint_2, byte byte_0)
		{
			return struct1_0[method_2(uint_2, byte_0)].method_2(class37_0);
		}

		public void method_4(int int_2, int int_3)
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
					struct1_0[num2].method_3();
				}
			}
		}
	}

	private readonly Class36 class36_0 = new Class36();

	private readonly Struct2[] struct2_0 = new Struct2[192];

	private readonly Struct3[] struct3_0 = new Struct3[4];

	private readonly GClass1 gclass1_0 = new GClass1();

	private readonly Class37 class37_0 = new Class37();

	private readonly Struct2[] struct2_1 = new Struct2[192];

	private uint uint_0;

	private uint uint_1;

	private readonly Class35 class35_0 = new Class35();

	private readonly Struct2[] struct2_2 = new Struct2[12];

	private readonly Struct2[] struct2_3 = new Struct2[114];

	private readonly Struct2[] struct2_4 = new Struct2[12];

	private uint uint_2;

	private readonly Struct2[] struct2_5 = new Struct2[12];

	private Struct3 struct3_1 = new Struct3(4);

	private readonly Class35 class35_1 = new Class35();

	private readonly Struct2[] struct2_6 = new Struct2[12];

	private uint uint_3 = 1u;

	private void method_0(int int_0, int int_1)
	{
		if (int_0 > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (int_1 > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		class36_0.method_4(int_0, int_1);
	}

	public void method_1(Stream stream_0, Stream stream_1, long long_0)
	{
		method_4(stream_0, stream_1);
		Class34.Struct0 @struct = default(Class34.Struct0);
		@struct.method_5();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (0uL < (ulong)long_0)
		{
			if (struct2_0[@struct.uint_0 << 4].method_0(class37_0) != 0)
			{
				throw new InvalidDataException("IsMatchDecoders");
			}
			@struct.method_4();
			byte byte_ = class36_0.method_3(class37_0, 0u, 0);
			gclass1_0.method_2(byte_);
			num5++;
		}
		while (num5 < (ulong)long_0)
		{
			uint num6 = (uint)(int)num5 & uint_1;
			if (struct2_0[(@struct.uint_0 << 4) + num6].method_0(class37_0) == 0)
			{
				byte byte_2 = gclass1_0.method_4(0u);
				byte byte_3 = (@struct.method_0() ? class36_0.method_3(class37_0, (uint)num5, byte_2) : class36_0.method_0(class37_0, (uint)num5, byte_2, gclass1_0.method_4(num)));
				gclass1_0.method_2(byte_3);
				@struct.method_4();
				num5++;
				continue;
			}
			uint num8;
			if (struct2_5[@struct.uint_0].method_0(class37_0) == 1)
			{
				if (struct2_6[@struct.uint_0].method_0(class37_0) == 0)
				{
					if (struct2_1[(@struct.uint_0 << 4) + num6].method_0(class37_0) == 0)
					{
						@struct.method_3();
						gclass1_0.method_2(gclass1_0.method_4(num));
						num5++;
						continue;
					}
				}
				else
				{
					uint num7;
					if (struct2_4[@struct.uint_0].method_0(class37_0) == 0)
					{
						num7 = num2;
					}
					else
					{
						if (struct2_2[@struct.uint_0].method_0(class37_0) == 0)
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
				num8 = class35_0.method_1(class37_0, num6) + 2;
				@struct.method_1();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				num8 = 2 + class35_1.method_1(class37_0, num6);
				@struct.method_2();
				uint num9 = struct3_0[Class34.smethod_0(num8)].method_0(class37_0);
				if (num9 >= 4)
				{
					int num10 = (int)((num9 >> 1) - 1);
					num = (2 | (num9 & 1)) << num10;
					if (num9 < 14)
					{
						num += Struct3.smethod_0(struct2_3, num - num9 - 1, class37_0, num10);
					}
					else
					{
						num += class37_0.method_0(num10 - 4) << 4;
						num += struct3_1.method_2(class37_0);
					}
				}
				else
				{
					num = num9;
				}
			}
			if (num < gclass1_0.uint_2 + num5 && num < uint_2)
			{
				gclass1_0.method_1(num, num8);
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
		gclass1_0.method_0();
		class37_0.method_1();
	}

	private void method_2(int int_0)
	{
		if (int_0 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = (uint)(1 << int_0);
		class35_1.method_2(num);
		class35_0.method_2(num);
		uint_1 = num - 1;
	}

	private void method_3(uint uint_4)
	{
		if (uint_0 != uint_4)
		{
			uint_0 = uint_4;
			uint_2 = Math.Max(uint_0, 1u);
			uint uint_5 = Math.Max(uint_2, 4096u);
			gclass1_0.method_6(uint_5);
		}
	}

	private void method_4(Stream stream_0, Stream stream_1)
	{
		class37_0.method_2(stream_0);
		gclass1_0.method_5(stream_1, bool_0: false);
		for (uint num = 0u; num < 12; num++)
		{
			for (uint num2 = 0u; num2 <= uint_1; num2++)
			{
				uint num3 = (num << 4) + num2;
				struct2_0[num3].method_1();
				struct2_1[num3].method_1();
			}
			struct2_5[num].method_1();
			struct2_6[num].method_1();
			struct2_4[num].method_1();
			struct2_2[num].method_1();
		}
		class36_0.method_1();
		for (uint num = 0u; num < 4; num++)
		{
			struct3_0[num].method_1();
		}
		for (uint num = 0u; num < 114; num++)
		{
			struct2_3[num].method_1();
		}
		class35_1.method_0();
		class35_0.method_0();
		struct3_1.method_1();
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
		method_3(num3);
		method_0(int_2, int_);
		method_2(num2);
	}

	public GClass0()
	{
		uint_0 = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			struct3_0[i] = new Struct3(6);
		}
	}
}
