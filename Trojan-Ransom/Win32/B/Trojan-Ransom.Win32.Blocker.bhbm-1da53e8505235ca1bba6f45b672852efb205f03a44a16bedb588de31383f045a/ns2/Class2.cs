using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Threading;
using ns0;
using ns1;
using ns3;
using ns4;
using ns5;

namespace ns2;

internal sealed class Class2
{
	private sealed class Class3
	{
		internal Struct9 struct9_0 = default(Struct9);

		internal Struct9 struct9_1 = default(Struct9);

		internal Struct10[] struct10_0 = new Struct10[16];

		internal Struct10[] struct10_1 = new Struct10[16];

		internal Struct10 struct10_2 = new Struct10(8);

		internal uint uint_0;

		public void method_0(uint uint_1)
		{
			for (uint num = uint_0; num < uint_1; num++)
			{
				ref Struct10 reference = ref struct10_0[num];
				reference = new Struct10(3);
				ref Struct10 reference2 = ref struct10_1[num];
				reference2 = new Struct10(3);
			}
			uint num2 = (uint_0 = uint_1);
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

		public uint method_2(Class6 class6_0, uint uint_1)
		{
			if (struct9_0.method_1(class6_0) == 0)
			{
				return struct10_0[uint_1].method_1(class6_0);
			}
			uint num = 8u;
			if (struct9_1.method_1(class6_0) == 0)
			{
				return num + struct10_1[uint_1].method_1(class6_0);
			}
			num += 8;
			return num + struct10_2.method_1(class6_0);
		}

		static Class3()
		{
			Class12.Class13.Class14.smethod_1();
			Class7.smethod_15();
			GClass1.smethod_7();
		}
	}

	private sealed class Class4
	{
		private struct Struct6
		{
			internal Struct9[] struct9_0;

			public void method_0()
			{
				Struct9[] array = (struct9_0 = new Struct9[768]);
			}

			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					struct9_0[i].method_0();
				}
			}

			public byte method_2(Class6 class6_0)
			{
				uint num = 1u;
				do
				{
					num = (num << 1) | struct9_0[num].method_1(class6_0);
				}
				while (num < 256);
				return (byte)num;
			}

			public byte method_3(Class6 class6_0, byte byte_0)
			{
				uint num = 1u;
				do
				{
					uint num2 = (uint)(byte_0 >> 7) & 1u;
					byte_0 = (byte)(byte_0 << 1);
					uint num3 = struct9_0[(1 + num2 << 8) + num].method_1(class6_0);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						while (num < 256)
						{
							num = (num << 1) | struct9_0[num].method_1(class6_0);
						}
						break;
					}
				}
				while (num < 256);
				return (byte)num;
			}

			static Struct6()
			{
				Class12.Class13.Class14.smethod_1();
				Class7.smethod_15();
				GClass1.smethod_7();
			}
		}

		internal Struct6[] struct6_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		public void method_0(int int_2, int int_3)
		{
			if (struct6_0 == null || int_0 != int_3 || int_1 != int_2)
			{
				int num = (int_1 = int_2);
				uint num2 = (uint_0 = (uint)((1 << int_2) - 1));
				int num3 = (int_0 = int_3);
				uint num4 = (uint)(1 << int_0 + int_1);
				Struct6[] array = (struct6_0 = new Struct6[num4]);
				for (uint num5 = 0u; num5 < num4; num5++)
				{
					struct6_0[num5].method_0();
				}
			}
		}

		public void method_1()
		{
			uint num = (uint)(1 << int_0 + int_1);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				struct6_0[num2].method_1();
			}
		}

		private uint method_2(uint uint_1, byte byte_0)
		{
			return ((uint_1 & uint_0) << int_0) + (uint)(byte_0 >> 8 - int_0);
		}

		public byte method_3(Class6 class6_0, uint uint_1, byte byte_0)
		{
			return struct6_0[method_2(uint_1, byte_0)].method_2(class6_0);
		}

		public byte method_4(Class6 class6_0, uint uint_1, byte byte_0, byte byte_1)
		{
			return struct6_0[method_2(uint_1, byte_0)].method_3(class6_0, byte_1);
		}

		static Class4()
		{
			Class12.Class13.Class14.smethod_1();
			Class7.smethod_15();
			GClass1.smethod_7();
		}
	}

	private Class3 class3_0 = new Class3();

	private Class3 class3_1 = new Class3();

	private Class4 class4_0 = new Class4();

	internal GClass2 gclass2_0 = new GClass2();

	internal Class6 class6_0 = new Class6();

	internal Struct9[] struct9_0 = new Struct9[192];

	internal Struct9[] struct9_1 = new Struct9[12];

	internal Struct9[] struct9_2 = new Struct9[12];

	internal Struct9[] struct9_3 = new Struct9[12];

	internal Struct9[] struct9_4 = new Struct9[12];

	internal Struct9[] struct9_5 = new Struct9[192];

	internal Struct10[] struct10_0 = new Struct10[4];

	internal Struct9[] struct9_6 = new Struct9[114];

	internal Struct10 struct10_1 = new Struct10(4);

	internal uint uint_0;

	internal uint uint_1;

	internal uint uint_2;

	public Class2()
	{
		uint_0 = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			ref Struct10 reference = ref struct10_0[i];
			reference = new Struct10(6);
		}
	}

	private void method_0(uint uint_3)
	{
		if (uint_0 != uint_3)
		{
			uint num = (uint_0 = uint_3);
			uint num2 = (uint_1 = GClass2.smethod_4(uint_0, 1u, 432, 435));
			uint uint_4 = GClass2.smethod_4(uint_1, 4096u, 128, 131);
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
		class4_0.method_0(int_0, int_1);
	}

	private void method_2(int int_0)
	{
		if (int_0 > 4)
		{
			throw new Exception1();
		}
		uint num = (uint)(1 << int_0);
		class3_0.method_0(num);
		class3_1.method_0(num);
		uint num2 = (uint_2 = num - 1);
	}

	private void method_3(Stream stream_0, Stream stream_1)
	{
		class6_0.method_0(stream_0);
		gclass2_0.method_2(stream_1);
		for (uint num = 0u; num < 12; num++)
		{
			for (uint num2 = 0u; num2 <= uint_2; num2++)
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
		class4_0.method_1();
		for (uint num = 0u; num < 4; num++)
		{
			struct10_0[num].method_0();
		}
		for (uint num = 0u; num < 114; num++)
		{
			struct9_6[num].method_0();
		}
		class3_0.method_1();
		class3_1.method_1();
		struct10_1.method_0();
	}

	public void vmethod_0(Stream stream_0, Stream stream_1, long long_0, long long_1, Interface0 interface0_0)
	{
		method_3(stream_0, stream_1);
		Class0.Struct2 @struct = default(Class0.Struct2);
		@struct.method_0();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (0uL < (ulong)long_1)
		{
			if (struct9_0[@struct.uint_0 << 4].method_1(class6_0) != 0)
			{
				throw new Exception0();
			}
			@struct.method_1();
			byte byte_ = class4_0.method_3(class6_0, 0u, 0);
			gclass2_0.method_6(byte_);
			num5++;
		}
		while (num5 < (ulong)long_1)
		{
			uint num6 = (uint)(int)num5 & uint_2;
			if (struct9_0[(@struct.uint_0 << 4) + num6].method_1(class6_0) == 0)
			{
				byte byte_2 = gclass2_0.method_7(0u);
				byte byte_3 = (@struct.method_5() ? class4_0.method_3(class6_0, (uint)num5, byte_2) : class4_0.method_4(class6_0, (uint)num5, byte_2, gclass2_0.method_7(num)));
				gclass2_0.method_6(byte_3);
				@struct.method_1();
				num5++;
				continue;
			}
			uint num8;
			if (struct9_1[@struct.uint_0].method_1(class6_0) == 1)
			{
				if (struct9_2[@struct.uint_0].method_1(class6_0) == 0)
				{
					if (struct9_5[(@struct.uint_0 << 4) + num6].method_1(class6_0) == 0)
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
					if (struct9_3[@struct.uint_0].method_1(class6_0) == 0)
					{
						num7 = num2;
					}
					else
					{
						if (struct9_4[@struct.uint_0].method_1(class6_0) == 0)
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
				num8 = class3_1.method_2(class6_0, num6) + 2;
				@struct.method_3();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				num8 = 2 + class3_0.method_2(class6_0, num6);
				@struct.method_2();
				uint num9 = struct10_0[Class0.smethod_0(num8)].method_1(class6_0);
				if (num9 >= 4)
				{
					int num10 = (int)((num9 >> 1) - 1);
					num = (2 | (num9 & 1)) << num10;
					if (num9 < 14)
					{
						num += Struct10.smethod_0(struct9_6, num - num9 - 1, class6_0, num10);
					}
					else
					{
						num += class6_0.method_2(num10 - 4) << 4;
						num += struct10_1.method_2(class6_0);
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
		class6_0.method_1();
	}

	public void vmethod_1(byte[] byte_0)
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

	static Class2()
	{
		Class12.Class13.Class14.smethod_1();
		Class7.smethod_15();
		GClass1.smethod_7();
	}

	internal static string smethod_0(string string_0, string string_1, string string_2, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 71:
				return Class7.smethod_9(string_0, string_1, string_2, 135, 153);
			}
		}
	}

	internal static void smethod_1(int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 124:
				Class7.Class8.smethod_8(int_0, 784, 818);
				return;
			}
		}
	}

	internal static void smethod_2(Thread thread_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 36:
				Class9.Class10.smethod_7(thread_0, 3, 76);
				return;
			}
		}
	}

	internal static void smethod_3(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				Class7.smethod_10(appDomain_0, resolveEventHandler_0, 199, 152);
				return;
			}
		}
	}

	internal static object smethod_4(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 116:
				return Class9.smethod_8(resourceManager_0, string_0, cultureInfo_0, 646, 749);
			}
		}
	}

	internal static Assembly smethod_5(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 34:
				return Class9.Class10.smethod_0(251, 180);
			}
		}
	}
}
