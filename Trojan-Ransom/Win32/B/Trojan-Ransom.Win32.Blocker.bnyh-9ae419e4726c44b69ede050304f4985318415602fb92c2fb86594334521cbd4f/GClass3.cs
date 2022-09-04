using System;
using System.IO;
using ns0;
using ns1;

public sealed class GClass3 : rceResolve, GInterface1
{
	private sealed class Class2
	{
		private Struct6[] struct6_0 = new Struct6[16];

		private Struct6[] struct6_1 = new Struct6[16];

		private Struct6 struct6_2 = new Struct6(8);

		internal Struct5 struct5_0 = default(Struct5);

		internal Struct5 struct5_1 = default(Struct5);

		internal uint uint_0;

		public Class2()
		{
			GClass1.smethod_16();
		}

		public void method_0(uint uint_1)
		{
			for (uint num = uint_0; num < uint_1; num++)
			{
				ref Struct6 reference = ref struct6_0[num];
				reference = new Struct6(3);
				ref Struct6 reference2 = ref struct6_1[num];
				reference2 = new Struct6(3);
			}
			uint num2 = (uint_0 = uint_1);
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

		public uint method_2(Class5 class5_0, uint uint_1)
		{
			if (struct5_0.method_1(class5_0) == 0)
			{
				return struct6_0[uint_1].method_1(class5_0);
			}
			uint num = 8u;
			if (struct5_1.method_1(class5_0) == 0)
			{
				return num + struct6_1[uint_1].method_1(class5_0);
			}
			num += 8;
			return num + struct6_2.method_1(class5_0);
		}
	}

	private sealed class Class3
	{
		private struct Struct2
		{
			internal Struct5[] struct5_0;

			public void method_0()
			{
				Struct5[] array = (struct5_0 = new Struct5[768]);
			}

			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					struct5_0[i].method_0();
				}
			}

			public byte method_2(Class5 class5_0)
			{
				uint num = 1u;
				do
				{
					num = (num << 1) | struct5_0[num].method_1(class5_0);
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
					uint num3 = struct5_0[(1 + num2 << 8) + num].method_1(class5_0);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						while (num < 256)
						{
							num = (num << 1) | struct5_0[num].method_1(class5_0);
						}
						break;
					}
				}
				while (num < 256);
				return (byte)num;
			}
		}

		private int int_0;

		internal Struct2[] struct2_0;

		internal int int_1;

		internal uint uint_0;

		public Class3()
		{
			Exception1.smethod_2();
		}

		public void method_0(int int_2, int int_3)
		{
			if (struct2_0 == null || int_1 != int_3 || int_0 != int_2)
			{
				int_0 = int_2;
				uint num = (uint_0 = (uint)((1 << int_2) - 1));
				int num2 = (int_1 = int_3);
				uint num3 = (uint)(1 << int_1 + int_0);
				Struct2[] array = (struct2_0 = new Struct2[num3]);
				for (uint num4 = 0u; num4 < num3; num4++)
				{
					struct2_0[num4].method_0();
				}
			}
		}

		public void method_1()
		{
			uint num = (uint)(1 << int_1 + int_0);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				struct2_0[num2].method_1();
			}
		}

		private uint method_2(uint uint_1, byte byte_0)
		{
			return ((uint_1 & uint_0) << int_1) + (uint)(byte_0 >> 8 - int_1);
		}

		public byte method_3(Class5 class5_0, uint uint_1, byte byte_0)
		{
			return struct2_0[method_2(uint_1, byte_0)].method_2(class5_0);
		}

		public byte method_4(Class5 class5_0, uint uint_1, byte byte_0, byte byte_1)
		{
			return struct2_0[method_2(uint_1, byte_0)].method_3(class5_0, byte_1);
		}
	}

	private GClass2 gclass2_0 = new GClass2();

	private Struct5[] struct5_0 = new Struct5[12];

	private Struct5[] struct5_1 = new Struct5[12];

	private Struct6[] struct6_0 = new Struct6[4];

	private Struct5[] struct5_2 = new Struct5[114];

	private Struct6 struct6_1 = new Struct6(4);

	private Class2 class2_0 = new Class2();

	private Class2 class2_1 = new Class2();

	private Class3 class3_0 = new Class3();

	private uint uint_0;

	private uint uint_1;

	internal Class5 class5_0 = new Class5();

	internal Struct5[] struct5_3 = new Struct5[192];

	internal Struct5[] struct5_4 = new Struct5[12];

	internal Struct5[] struct5_5 = new Struct5[12];

	internal Struct5[] struct5_6 = new Struct5[192];

	internal uint uint_2;

	public GClass3()
	{
		uint_0 = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			ref Struct6 reference = ref struct6_0[i];
			reference = new Struct6(6);
		}
		GClass0.smethod_7();
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
		uint num2 = (uint_2 = num - 1);
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
				struct5_3[num3].method_0();
				struct5_6[num3].method_0();
			}
			struct5_4[num].method_0();
			struct5_0[num].method_0();
			struct5_5[num].method_0();
			struct5_1[num].method_0();
		}
		class3_0.method_1();
		for (uint num = 0u; num < 4; num++)
		{
			struct6_0[num].method_0();
		}
		for (uint num = 0u; num < 114; num++)
		{
			struct5_2[num].method_0();
		}
		class2_0.method_1();
		class2_1.method_1();
		struct6_1.method_0();
	}

	public void imethod_0(Stream stream_0, Stream stream_1, long long_0, long long_1, GInterface2 ginterface2_0)
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
			if (struct5_3[@struct.uint_0 << 4].method_1(class5_0) != 0)
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
			if (struct5_3[(@struct.uint_0 << 4) + num6].method_1(class5_0) == 0)
			{
				byte byte_2 = gclass2_0.method_7(0u);
				byte byte_3 = (@struct.method_5() ? class3_0.method_3(class5_0, (uint)num5, byte_2) : class3_0.method_4(class5_0, (uint)num5, byte_2, gclass2_0.method_7(num)));
				gclass2_0.method_6(byte_3);
				@struct.method_1();
				num5++;
				continue;
			}
			uint num8;
			if (struct5_4[@struct.uint_0].method_1(class5_0) == 1)
			{
				if (struct5_0[@struct.uint_0].method_1(class5_0) == 0)
				{
					if (struct5_6[(@struct.uint_0 << 4) + num6].method_1(class5_0) == 0)
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
					if (struct5_5[@struct.uint_0].method_1(class5_0) == 0)
					{
						num7 = num2;
					}
					else
					{
						if (struct5_1[@struct.uint_0].method_1(class5_0) == 0)
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
						num += Struct6.smethod_0(struct5_2, num - num9 - 1, class5_0, num10);
					}
					else
					{
						num += class5_0.method_2(num10 - 4) << 4;
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

	internal static long smethod_0()
	{
		AppDomain.CurrentDomain.SetData("fe8ac553a4f34e4a8e054c1983ee8380", null);
		return 2L;
	}

	internal static object smethod_1()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				GClass0.smethod_0();
			}
			num++;
			return null;
		}
		return null;
	}

	internal static Type smethod_2()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				GClass1.smethod_10();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					smethod_0();
				}
				num++;
				if (array[num] >= 71)
				{
					if (71 != array[num])
					{
						GClass0.smethod_1();
					}
					num++;
					return typeof(GInterface0);
				}
				return typeof(Class3.Struct2);
			}
			return typeof(Struct6);
		}
		return typeof(Class5);
	}

	internal static byte smethod_3()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				GClass0.smethod_0();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					GClass0.smethod_2();
				}
				num++;
				if (array[num] >= 71)
				{
					if (71 != array[num])
					{
						Exception0.smethod_2();
					}
					num++;
					if (array[num] >= 251)
					{
						if (251 != array[num])
						{
							GClass2.smethod_2();
						}
						num++;
						if (array[num] >= 144)
						{
							if (144 != array[num])
							{
								Exception0.smethod_3();
							}
							num++;
							if (array[num] >= 220)
							{
								if (220 != array[num])
								{
									GClass0.smethod_0();
								}
								num++;
								return 9;
							}
							return 28;
						}
						return 31;
					}
					return 9;
				}
				return 23;
			}
			return 21;
		}
		return 27;
	}

	internal static string smethod_4()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				GClass1.smethod_10();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					GClass2.smethod_0();
				}
				num++;
				if (array[num] >= 71)
				{
					if (71 != array[num])
					{
						GClass2.smethod_0();
					}
					num++;
					if (array[num] >= 251)
					{
						if (251 != array[num])
						{
							GClass1.smethod_10();
						}
						num++;
						if (array[num] >= 144)
						{
							if (144 != array[num])
							{
								GClass0.smethod_1();
							}
							num++;
							if (array[num] >= 220)
							{
								if (220 != array[num])
								{
									GClass0.smethod_2();
								}
								num++;
								if (array[num] >= 229)
								{
									if (229 != array[num])
									{
										Exception1.smethod_0();
									}
									num++;
									return null;
								}
								return null;
							}
							return null;
						}
						return null;
					}
					return null;
				}
				return null;
			}
			return null;
		}
		return null;
	}
}
