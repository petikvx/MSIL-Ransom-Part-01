using System;
using System.IO;
using System.Runtime.InteropServices;
using ns0;

public sealed class GClass3 : GInterface1, GInterface2
{
	private sealed class Class2
	{
		internal Struct6 struct6_0 = default(Struct6);

		internal Struct6 struct6_1 = default(Struct6);

		internal Struct7[] struct7_0 = new Struct7[16];

		internal Struct7[] struct7_1 = new Struct7[16];

		internal Struct7 struct7_2 = new Struct7(8);

		internal uint uint_0;

		public Class2()
		{
			GClass0.smethod_3();
		}

		public void method_0(uint uint_1)
		{
			for (uint num = uint_0; num < uint_1; num++)
			{
				ref Struct7 reference = ref struct7_0[num];
				reference = new Struct7(3);
				ref Struct7 reference2 = ref struct7_1[num];
				reference2 = new Struct7(3);
			}
			uint num2 = (uint_0 = uint_1);
		}

		public void method_1()
		{
			struct6_0.method_0();
			for (uint num = 0u; num < uint_0; num++)
			{
				struct7_0[num].method_0();
				struct7_1[num].method_0();
			}
			struct6_1.method_0();
			struct7_2.method_0();
		}

		public uint method_2(Class5 class5_0, uint uint_1)
		{
			if (struct6_0.method_1(class5_0) == 0)
			{
				return struct7_0[uint_1].method_1(class5_0);
			}
			uint num = 8u;
			if (struct6_1.method_1(class5_0) == 0)
			{
				return num + struct7_1[uint_1].method_1(class5_0);
			}
			num += 8;
			return num + struct7_2.method_1(class5_0);
		}
	}

	private sealed class Class3
	{
		private struct Struct2
		{
			internal Struct6[] struct6_0;

			public void method_0()
			{
				Struct6[] array = (struct6_0 = new Struct6[768]);
			}

			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					struct6_0[i].method_0();
				}
			}

			public byte method_2(Class5 class5_0)
			{
				uint num = 1u;
				do
				{
					num = (num << 1) | struct6_0[num].method_1(class5_0);
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
					uint num3 = struct6_0[(1 + num2 << 8) + num].method_1(class5_0);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						while (num < 256)
						{
							num = (num << 1) | struct6_0[num].method_1(class5_0);
						}
						break;
					}
				}
				while (num < 256);
				return (byte)num;
			}
		}

		private Struct2[] struct2_0;

		private int int_0;

		private int int_1;

		private uint uint_0;

		public Class3()
		{
			GClass0.smethod_2();
		}

		public void method_0(int int_2, int int_3)
		{
			if (struct2_0 == null || int_0 != int_3 || int_1 != int_2)
			{
				int_1 = int_2;
				uint_0 = (uint)((1 << int_2) - 1);
				int_0 = int_3;
				uint num = (uint)(1 << int_0 + int_1);
				struct2_0 = new Struct2[num];
				for (uint num2 = 0u; num2 < num; num2++)
				{
					struct2_0[num2].method_0();
				}
			}
		}

		public void method_1()
		{
			uint num = (uint)(1 << int_0 + int_1);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				struct2_0[num2].method_1();
			}
		}

		private uint method_2(uint uint_1, byte byte_0)
		{
			return ((uint_1 & uint_0) << int_0) + (uint)(byte_0 >> 8 - int_0);
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

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20916)]
	private struct Struct3
	{
	}

	private GClass2 gclass2_0 = new GClass2();

	private Class5 class5_0 = new Class5();

	private Struct6[] struct6_0 = new Struct6[12];

	private Struct6[] struct6_1 = new Struct6[192];

	private Struct7[] struct7_0 = new Struct7[4];

	private Struct7 struct7_1 = new Struct7(4);

	private Class2 class2_0 = new Class2();

	private Class2 class2_1 = new Class2();

	private Class3 class3_0 = new Class3();

	private uint uint_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal Struct6[] struct6_2 = new Struct6[192];

	internal Struct6[] struct6_3 = new Struct6[12];

	internal Struct6[] struct6_4 = new Struct6[12];

	internal Struct6[] struct6_5 = new Struct6[12];

	internal Struct6[] struct6_6 = new Struct6[114];

	internal uint uint_1;

	internal uint uint_2;

	public GClass3()
	{
		uint_0 = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			ref Struct7 reference = ref struct7_0[i];
			reference = new Struct7(6);
		}
		GClass1.smethod_7();
	}

	private void method_0(uint uint_3)
	{
		if (uint_0 != uint_3)
		{
			uint_0 = uint_3;
			uint num = (uint_1 = Math.Max(uint_0, 1u));
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
				struct6_2[num3].method_0();
				struct6_1[num3].method_0();
			}
			struct6_3[num].method_0();
			struct6_4[num].method_0();
			struct6_5[num].method_0();
			struct6_0[num].method_0();
		}
		class3_0.method_1();
		for (uint num = 0u; num < 4; num++)
		{
			struct7_0[num].method_0();
		}
		for (uint num = 0u; num < 114; num++)
		{
			struct6_6[num].method_0();
		}
		class2_0.method_1();
		class2_1.method_1();
		struct7_1.method_0();
	}

	public void imethod_0(Stream stream_0, Stream stream_1, long long_0, long long_1, GInterface3 ginterface3_0)
	{
		method_3(stream_0, stream_1);
		Class0.Struct1 @struct = default(Class0.Struct1);
		@struct.method_0();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (0uL < (ulong)long_1)
		{
			if (struct6_2[@struct.uint_0 << 4].method_1(class5_0) != 0)
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
			if (struct6_2[(@struct.uint_0 << 4) + num6].method_1(class5_0) == 0)
			{
				byte b = gclass2_0.method_7(0u);
				byte byte_2 = (@struct.method_5() ? class3_0.method_3(class5_0, (uint)num5, b) : class3_0.method_4(class5_0, (uint)num5, b, gclass2_0.method_7(num)));
				gclass2_0.method_6(byte_2);
				@struct.method_1();
				num5++;
				continue;
			}
			uint num8;
			if (struct6_3[@struct.uint_0].method_1(class5_0) == 1)
			{
				if (struct6_4[@struct.uint_0].method_1(class5_0) == 0)
				{
					if (struct6_1[(@struct.uint_0 << 4) + num6].method_1(class5_0) == 0)
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
					if (struct6_5[@struct.uint_0].method_1(class5_0) == 0)
					{
						num7 = num2;
					}
					else
					{
						if (struct6_0[@struct.uint_0].method_1(class5_0) == 0)
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
				uint num9 = struct7_0[Class0.smethod_0(num8)].method_1(class5_0);
				if (num9 >= 4)
				{
					int num10 = (int)((num9 >> 1) - 1);
					num = (2 | (num9 & 1)) << num10;
					if (num9 < 14)
					{
						num += Struct7.smethod_0(struct6_6, num - num9 - 1, class5_0, num10);
					}
					else
					{
						num += class5_0.method_2(num10 - 4) << 4;
						num += struct7_1.method_2(class5_0);
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

	public void imethod_1(byte[] byte_1)
	{
		if (byte_1.Length < 5)
		{
			throw new Exception1();
		}
		int int_ = (int)byte_1[0] % 9;
		int num = (int)byte_1[0] / 9;
		int int_2 = num % 5;
		int num2 = num / 5;
		if (num2 > 4)
		{
			throw new Exception1();
		}
		uint num3 = 0u;
		for (int i = 0; i < 4; i++)
		{
			num3 += (uint)(byte_1[1 + i] << i * 8);
		}
		method_0(num3);
		method_1(int_2, int_);
		method_2(num2);
	}

	internal static void smethod_0()
	{
		smethod_0();
	}

	internal static long smethod_1()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				smethod_0();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Class5.smethod_0();
				}
				num++;
				return 5L;
			}
			return 12L;
		}
		return 3L;
	}

	internal static long smethod_2()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception0.smethod_1();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Exception1.smethod_3();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Exception1.smethod_0();
					}
					num++;
					return 6L;
				}
				return 0L;
			}
			return 6L;
		}
		return 12L;
	}

	internal static byte smethod_3()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception1.smethod_2();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					GClass2.smethod_0();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Exception0.smethod_0();
					}
					num++;
					if (array[num] >= 248)
					{
						if (248 != array[num])
						{
							smethod_0();
						}
						num++;
						if (array[num] >= 218)
						{
							if (218 != array[num])
							{
								GClass1.smethod_5();
							}
							num++;
							if (array[num] >= 33)
							{
								if (33 != array[num])
								{
									GClass1.smethod_5();
								}
								num++;
								return 9;
							}
							return 2;
						}
						return 19;
					}
					return 31;
				}
				return 6;
			}
			return 22;
		}
		return 15;
	}

	internal static int smethod_4()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception1.smethod_3();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					GClass0.smethod_1();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						GClass1.smethod_6();
					}
					num++;
					if (array[num] >= 248)
					{
						if (248 != array[num])
						{
							Class5.smethod_1();
						}
						num++;
						if (array[num] >= 218)
						{
							if (218 != array[num])
							{
								Class5.smethod_0();
							}
							num++;
							if (array[num] >= 33)
							{
								if (33 != array[num])
								{
									GClass1.smethod_6();
								}
								num++;
								if (array[num] >= 232)
								{
									if (232 != array[num])
									{
										GClass1.smethod_5();
									}
									num++;
									return 6;
								}
								return 12;
							}
							return 5;
						}
						return 13;
					}
					return 1;
				}
				return 5;
			}
			return 7;
		}
		return 7;
	}
}
