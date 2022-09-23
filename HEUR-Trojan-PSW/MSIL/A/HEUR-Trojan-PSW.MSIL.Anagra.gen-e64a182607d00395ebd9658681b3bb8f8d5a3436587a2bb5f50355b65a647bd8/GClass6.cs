using System;
using System.IO;

public class GClass6
{
	private class Class10
	{
		private Struct9 struct9_0;

		private Struct9 struct9_1;

		private readonly Struct10[] struct10_0 = new Struct10[16];

		private readonly Struct10[] struct10_1 = new Struct10[16];

		private Struct10 struct10_2 = new Struct10(8);

		private uint uint_0;

		public void method_0(uint uint_1)
		{
			for (uint num = uint_0; num < uint_1; num++)
			{
				struct10_0[num] = new Struct10(3);
				struct10_1[num] = new Struct10(3);
			}
			uint_0 = uint_1;
		}

		public void method_1()
		{
			struct9_0.method_0();
			for (uint num = 0u; num < uint_0; num++)
			{
				struct10_0[num].method_0();
				struct10_1[num].method_0();
			}
			struct9_1.method_0();
			struct10_2.method_0();
		}

		public uint method_2(Class12 class12_0, uint uint_1)
		{
			if (struct9_0.method_1(class12_0) == 0)
			{
				return struct10_0[uint_1].method_1(class12_0);
			}
			uint num = 8u;
			if (struct9_1.method_1(class12_0) == 0)
			{
				return num + struct10_1[uint_1].method_1(class12_0);
			}
			num += 8;
			return num + struct10_2.method_1(class12_0);
		}
	}

	private class Class11
	{
		private struct Struct8
		{
			private Struct9[] struct9_0;

			public void method_0()
			{
				struct9_0 = new Struct9[768];
			}

			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					struct9_0[i].method_0();
				}
			}

			public byte method_2(Class12 class12_0)
			{
				uint num = 1u;
				do
				{
					num = (num << 1) | struct9_0[num].method_1(class12_0);
				}
				while (num < 256);
				return (byte)num;
			}

			public byte method_3(Class12 class12_0, byte byte_0)
			{
				uint num = 1u;
				do
				{
					uint num2 = (uint)(byte_0 >> 7) & 1u;
					byte_0 = (byte)(byte_0 << 1);
					uint num3 = struct9_0[(1 + num2 << 8) + num].method_1(class12_0);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						while (num < 256)
						{
							num = (num << 1) | struct9_0[num].method_1(class12_0);
						}
						break;
					}
				}
				while (num < 256);
				return (byte)num;
			}
		}

		private uint uint_0 = 1u;

		private Struct8[] struct8_0;

		private int int_0;

		private int int_1;

		private uint uint_1;

		public void method_0(int int_2, int int_3)
		{
			if (struct8_0 == null || int_0 != int_3 || int_1 != int_2)
			{
				int_1 = int_2;
				uint_1 = (uint)((1 << int_2) - 1);
				int_0 = int_3;
				uint num = (uint)(1 << int_0 + int_1);
				struct8_0 = new Struct8[num];
				for (uint num2 = 0u; num2 < num; num2++)
				{
					struct8_0[num2].method_0();
				}
			}
		}

		public void method_1()
		{
			uint num = (uint)(1 << int_0 + int_1);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				struct8_0[num2].method_1();
			}
		}

		private uint method_2(uint uint_2, byte byte_0)
		{
			return ((uint_2 & uint_1) << int_0) + (uint)(byte_0 >> 8 - int_0);
		}

		public byte method_3(Class12 class12_0, uint uint_2, byte byte_0)
		{
			return struct8_0[method_2(uint_2, byte_0)].method_2(class12_0);
		}

		public byte method_4(Class12 class12_0, uint uint_2, byte byte_0, byte byte_1)
		{
			return struct8_0[method_2(uint_2, byte_0)].method_3(class12_0, byte_1);
		}
	}

	private uint uint_0 = 1u;

	private readonly GClass7 gclass7_0 = new GClass7();

	private readonly Class12 class12_0 = new Class12();

	private readonly Struct9[] struct9_0 = new Struct9[192];

	private readonly Struct9[] struct9_1 = new Struct9[12];

	private readonly Struct9[] struct9_2 = new Struct9[12];

	private readonly Struct9[] struct9_3 = new Struct9[12];

	private readonly Struct9[] struct9_4 = new Struct9[12];

	private readonly Struct9[] struct9_5 = new Struct9[192];

	private readonly Struct10[] struct10_0 = new Struct10[4];

	private readonly Struct9[] struct9_6 = new Struct9[114];

	private Struct10 struct10_1 = new Struct10(4);

	private readonly Class10 class10_0 = new Class10();

	private readonly Class10 class10_1 = new Class10();

	private readonly Class11 class11_0 = new Class11();

	private uint uint_1;

	private uint uint_2;

	private uint uint_3;

	public GClass6()
	{
		uint_1 = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			struct10_0[i] = new Struct10(6);
		}
	}

	private void method_0(uint uint_4)
	{
		if (uint_1 != uint_4)
		{
			uint_1 = uint_4;
			uint_2 = Math.Max(uint_1, 1u);
			uint uint_5 = Math.Max(uint_2, 4096u);
			gclass7_0.method_0(uint_5);
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
		class11_0.method_0(int_0, int_1);
	}

	private void method_2(int int_0)
	{
		if (int_0 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = (uint)(1 << int_0);
		class10_0.method_0(num);
		class10_1.method_0(num);
		uint_3 = num - 1;
	}

	private void method_3(Stream stream_0, Stream stream_1)
	{
		class12_0.method_0(stream_0);
		gclass7_0.method_1(stream_1, bool_0: false);
		for (uint num = 0u; num < 12; num++)
		{
			for (uint num2 = 0u; num2 <= uint_3; num2++)
			{
				uint num3 = (num << 4) + num2;
				struct9_0[num3].method_0();
				struct9_5[num3].method_0();
			}
			struct9_1[num].method_0();
			struct9_2[num].method_0();
			struct9_3[num].method_0();
			struct9_4[num].method_0();
		}
		class11_0.method_1();
		for (uint num = 0u; num < 4; num++)
		{
			struct10_0[num].method_0();
		}
		for (uint num = 0u; num < 114; num++)
		{
			struct9_6[num].method_0();
		}
		class10_0.method_1();
		class10_1.method_1();
		struct10_1.method_0();
	}

	public void method_4(Stream stream_0, Stream stream_1, long long_0)
	{
		method_3(stream_0, stream_1);
		Class9.Struct7 @struct = default(Class9.Struct7);
		@struct.method_0();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (0uL < (ulong)long_0)
		{
			if (struct9_0[@struct.uint_0 << 4].method_1(class12_0) != 0)
			{
				throw new InvalidDataException("IsMatchDecoders");
			}
			@struct.method_1();
			byte byte_ = class11_0.method_3(class12_0, 0u, 0);
			gclass7_0.method_5(byte_);
			num5++;
		}
		while (num5 < (ulong)long_0)
		{
			uint num6 = (uint)(int)num5 & uint_3;
			if (struct9_0[(@struct.uint_0 << 4) + num6].method_1(class12_0) == 0)
			{
				byte byte_2 = gclass7_0.method_6(0u);
				byte byte_3 = (@struct.method_5() ? class11_0.method_3(class12_0, (uint)num5, byte_2) : class11_0.method_4(class12_0, (uint)num5, byte_2, gclass7_0.method_6(num)));
				gclass7_0.method_5(byte_3);
				@struct.method_1();
				num5++;
				continue;
			}
			uint num8;
			if (struct9_1[@struct.uint_0].method_1(class12_0) == 1)
			{
				if (struct9_2[@struct.uint_0].method_1(class12_0) == 0)
				{
					if (struct9_5[(@struct.uint_0 << 4) + num6].method_1(class12_0) == 0)
					{
						@struct.method_4();
						gclass7_0.method_5(gclass7_0.method_6(num));
						num5++;
						continue;
					}
				}
				else
				{
					uint num7;
					if (struct9_3[@struct.uint_0].method_1(class12_0) == 0)
					{
						num7 = num2;
					}
					else
					{
						if (struct9_4[@struct.uint_0].method_1(class12_0) == 0)
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
				num8 = class10_1.method_2(class12_0, num6) + 2;
				@struct.method_3();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				num8 = 2 + class10_0.method_2(class12_0, num6);
				@struct.method_2();
				uint num9 = struct10_0[Class9.smethod_0(num8)].method_1(class12_0);
				if (num9 >= 4)
				{
					int num10 = (int)((num9 >> 1) - 1);
					num = (2 | (num9 & 1)) << num10;
					if (num9 < 14)
					{
						num += Struct10.smethod_0(struct9_6, num - num9 - 1, class12_0, num10);
					}
					else
					{
						num += class12_0.method_2(num10 - 4) << 4;
						num += struct10_1.method_2(class12_0);
					}
				}
				else
				{
					num = num9;
				}
			}
			if (num < gclass7_0.uint_4 + num5 && num < uint_2)
			{
				gclass7_0.method_4(num, num8);
				num5 += num8;
				continue;
			}
			if (num == uint.MaxValue)
			{
				break;
			}
			throw new InvalidDataException("rep0");
		}
		gclass7_0.method_3();
		gclass7_0.method_2();
		class12_0.method_1();
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
