using System;
using System.IO;

public class GClass4
{
	private class Class5
	{
		private Struct11 struct11_0;

		private Struct11 struct11_1;

		private readonly Struct12[] struct12_0 = new Struct12[16];

		private readonly Struct12[] struct12_1 = new Struct12[16];

		private Struct12 struct12_2 = new Struct12(8);

		private uint uint_0;

		public void method_0(uint uint_1)
		{
			for (uint num = uint_0; num < uint_1; num++)
			{
				struct12_0[num] = new Struct12(3);
				struct12_1[num] = new Struct12(3);
			}
			uint_0 = uint_1;
		}

		public void method_1()
		{
			struct11_0.method_0();
			for (uint num = 0u; num < uint_0; num++)
			{
				struct12_0[num].method_0();
				struct12_1[num].method_0();
			}
			struct11_1.method_0();
			struct12_2.method_0();
		}

		public uint method_2(Class7 class7_0, uint uint_1)
		{
			if (struct11_0.method_1(class7_0) == 0)
			{
				return struct12_0[uint_1].method_1(class7_0);
			}
			uint num = 8u;
			if (struct11_1.method_1(class7_0) == 0)
			{
				return num + struct12_1[uint_1].method_1(class7_0);
			}
			num += 8;
			return num + struct12_2.method_1(class7_0);
		}
	}

	private class Class6
	{
		private struct Struct10
		{
			private Struct11[] struct11_0;

			public void method_0()
			{
				struct11_0 = new Struct11[768];
			}

			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					struct11_0[i].method_0();
				}
			}

			public byte method_2(Class7 class7_0)
			{
				uint num = 1u;
				do
				{
					num = (num << 1) | struct11_0[num].method_1(class7_0);
				}
				while (num < 256);
				return (byte)num;
			}

			public byte method_3(Class7 class7_0, byte byte_0)
			{
				uint num = 1u;
				do
				{
					uint num2 = (uint)(byte_0 >> 7) & 1u;
					byte_0 = (byte)(byte_0 << 1);
					uint num3 = struct11_0[(1 + num2 << 8) + num].method_1(class7_0);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						while (num < 256)
						{
							num = (num << 1) | struct11_0[num].method_1(class7_0);
						}
						break;
					}
				}
				while (num < 256);
				return (byte)num;
			}
		}

		private uint uint_0 = 1u;

		private Struct10[] struct10_0;

		private int int_0;

		private int int_1;

		private uint uint_1;

		public void method_0(int int_2, int int_3)
		{
			if (struct10_0 == null || int_0 != int_3 || int_1 != int_2)
			{
				int_1 = int_2;
				uint_1 = (uint)((1 << int_2) - 1);
				int_0 = int_3;
				uint num = (uint)(1 << int_0 + int_1);
				struct10_0 = new Struct10[num];
				for (uint num2 = 0u; num2 < num; num2++)
				{
					struct10_0[num2].method_0();
				}
			}
		}

		public void method_1()
		{
			uint num = (uint)(1 << int_0 + int_1);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				struct10_0[num2].method_1();
			}
		}

		private uint method_2(uint uint_2, byte byte_0)
		{
			return ((uint_2 & uint_1) << int_0) + (uint)(byte_0 >> 8 - int_0);
		}

		public byte method_3(Class7 class7_0, uint uint_2, byte byte_0)
		{
			return struct10_0[method_2(uint_2, byte_0)].method_2(class7_0);
		}

		public byte method_4(Class7 class7_0, uint uint_2, byte byte_0, byte byte_1)
		{
			return struct10_0[method_2(uint_2, byte_0)].method_3(class7_0, byte_1);
		}
	}

	private uint uint_0 = 1u;

	private readonly GClass5 gclass5_0 = new GClass5();

	private readonly Class7 class7_0 = new Class7();

	private readonly Struct11[] struct11_0 = new Struct11[192];

	private readonly Struct11[] struct11_1 = new Struct11[12];

	private readonly Struct11[] struct11_2 = new Struct11[12];

	private readonly Struct11[] struct11_3 = new Struct11[12];

	private readonly Struct11[] struct11_4 = new Struct11[12];

	private readonly Struct11[] struct11_5 = new Struct11[192];

	private readonly Struct12[] struct12_0 = new Struct12[4];

	private readonly Struct11[] struct11_6 = new Struct11[114];

	private Struct12 struct12_1 = new Struct12(4);

	private readonly Class5 class5_0 = new Class5();

	private readonly Class5 class5_1 = new Class5();

	private readonly Class6 class6_0 = new Class6();

	private uint uint_1;

	private uint uint_2;

	private uint uint_3;

	public GClass4()
	{
		uint_1 = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			struct12_0[i] = new Struct12(6);
		}
	}

	private void method_0(uint uint_4)
	{
		if (uint_1 != uint_4)
		{
			uint_1 = uint_4;
			uint_2 = Math.Max(uint_1, 1u);
			uint uint_5 = Math.Max(uint_2, 4096u);
			gclass5_0.method_0(uint_5);
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
		class6_0.method_0(int_0, int_1);
	}

	private void method_2(int int_0)
	{
		if (int_0 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = (uint)(1 << int_0);
		class5_0.method_0(num);
		class5_1.method_0(num);
		uint_3 = num - 1;
	}

	private void method_3(Stream stream_0, Stream stream_1)
	{
		class7_0.method_0(stream_0);
		gclass5_0.method_1(stream_1, bool_0: false);
		for (uint num = 0u; num < 12; num++)
		{
			for (uint num2 = 0u; num2 <= uint_3; num2++)
			{
				uint num3 = (num << 4) + num2;
				struct11_0[num3].method_0();
				struct11_5[num3].method_0();
			}
			struct11_1[num].method_0();
			struct11_2[num].method_0();
			struct11_3[num].method_0();
			struct11_4[num].method_0();
		}
		class6_0.method_1();
		for (uint num = 0u; num < 4; num++)
		{
			struct12_0[num].method_0();
		}
		for (uint num = 0u; num < 114; num++)
		{
			struct11_6[num].method_0();
		}
		class5_0.method_1();
		class5_1.method_1();
		struct12_1.method_0();
	}

	public void method_4(Stream stream_0, Stream stream_1, long long_0)
	{
		method_3(stream_0, stream_1);
		Class4.Struct9 @struct = default(Class4.Struct9);
		@struct.method_0();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (0uL < (ulong)long_0)
		{
			if (struct11_0[@struct.uint_0 << 4].method_1(class7_0) != 0)
			{
				throw new InvalidDataException("IsMatchDecoders");
			}
			@struct.method_1();
			byte byte_ = class6_0.method_3(class7_0, 0u, 0);
			gclass5_0.method_5(byte_);
			num5++;
		}
		while (num5 < (ulong)long_0)
		{
			uint num6 = (uint)(int)num5 & uint_3;
			if (struct11_0[(@struct.uint_0 << 4) + num6].method_1(class7_0) == 0)
			{
				byte byte_2 = gclass5_0.method_6(0u);
				byte byte_3 = (@struct.method_5() ? class6_0.method_3(class7_0, (uint)num5, byte_2) : class6_0.method_4(class7_0, (uint)num5, byte_2, gclass5_0.method_6(num)));
				gclass5_0.method_5(byte_3);
				@struct.method_1();
				num5++;
				continue;
			}
			uint num8;
			if (struct11_1[@struct.uint_0].method_1(class7_0) == 1)
			{
				if (struct11_2[@struct.uint_0].method_1(class7_0) == 0)
				{
					if (struct11_5[(@struct.uint_0 << 4) + num6].method_1(class7_0) == 0)
					{
						@struct.method_4();
						gclass5_0.method_5(gclass5_0.method_6(num));
						num5++;
						continue;
					}
				}
				else
				{
					uint num7;
					if (struct11_3[@struct.uint_0].method_1(class7_0) == 0)
					{
						num7 = num2;
					}
					else
					{
						if (struct11_4[@struct.uint_0].method_1(class7_0) == 0)
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
				num8 = class5_1.method_2(class7_0, num6) + 2;
				@struct.method_3();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				num8 = 2 + class5_0.method_2(class7_0, num6);
				@struct.method_2();
				uint num9 = struct12_0[Class4.smethod_0(num8)].method_1(class7_0);
				if (num9 >= 4)
				{
					int num10 = (int)((num9 >> 1) - 1);
					num = (2 | (num9 & 1)) << num10;
					if (num9 < 14)
					{
						num += Struct12.smethod_0(struct11_6, num - num9 - 1, class7_0, num10);
					}
					else
					{
						num += class7_0.method_2(num10 - 4) << 4;
						num += struct12_1.method_2(class7_0);
					}
				}
				else
				{
					num = num9;
				}
			}
			if (num < gclass5_0.uint_4 + num5 && num < uint_2)
			{
				gclass5_0.method_4(num, num8);
				num5 += num8;
				continue;
			}
			if (num == uint.MaxValue)
			{
				break;
			}
			throw new InvalidDataException("rep0");
		}
		gclass5_0.method_3();
		gclass5_0.method_2();
		class7_0.method_1();
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
