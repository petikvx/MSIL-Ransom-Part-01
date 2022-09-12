using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal static class Class78
{
	public enum Enum2 : uint
	{
		const_0 = 0x1000u,
		const_1 = 0x2000u
	}

	public enum Enum3 : uint
	{
		const_0 = 0x8000u
	}

	public enum Enum4 : uint
	{
		const_0 = 16u,
		const_1 = 4u,
		const_2 = 2u,
		const_3 = 8u,
		const_4 = 32u,
		const_5 = 64u,
		const_6 = 256u,
		const_7 = 1u
	}

	public enum Enum5 : uint
	{
		const_0 = 1u,
		const_1 = 2u,
		const_2 = 8u,
		const_3 = 4u
	}

	public struct Struct4
	{
		public readonly ushort ushort_0;

		public readonly ushort ushort_1;

		private readonly IntPtr intptr_0;

		public unsafe void method_0()
		{
			//IL_0013: Expected O, but got Ref
			new GClass8().method_28(new object[1] { (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) }, 75878);
		}

		public unsafe Struct4(string string_0)
		{
			//IL_0013: Expected O, but got Ref
			new GClass8().method_28(new object[2]
			{
				(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this),
				string_0
			}, 75587);
		}
	}

	public struct Struct5
	{
		public readonly uint uint_0;

		public readonly IntPtr intptr_0;

		public readonly IntPtr intptr_1;

		public readonly uint uint_1;

		public readonly IntPtr intptr_2;

		public readonly IntPtr intptr_3;

		public unsafe void method_0()
		{
			//IL_0013: Expected O, but got Ref
			new GClass8().method_28(new object[1] { (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) }, 76326);
		}

		public unsafe Struct5(Struct4 struct4_0, uint uint_2)
		{
			//IL_0013: Expected O, but got Ref
			new GClass8().method_28(new object[3]
			{
				(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this),
				struct4_0,
				uint_2
			}, 76034);
		}
	}

	public struct Struct6
	{
		public uint uint_0;

		public IntPtr intptr_0;
	}

	public struct Struct7
	{
		public uint uint_0;

		public uint uint_1;
	}

	public struct Struct8
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;
	}

	public struct Struct9
	{
		public byte byte_0;

		public byte byte_1;
	}

	public struct Struct10
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public byte byte_0;
	}

	public enum Enum6
	{
		const_0 = 1,
		const_1 = 5,
		const_2 = 8,
		const_3 = 6,
		const_4 = 0,
		const_5 = 3,
		const_6 = 7,
		const_7 = 4,
		const_8 = 2
	}

	private delegate uint Delegate32(IntPtr intptr_0, Enum7 enum7_0, IntPtr intptr_1, uint uint_0, out uint uint_1);

	private delegate uint Delegate33(Enum8 enum8_0, IntPtr intptr_0, uint uint_0, out uint uint_1);

	private delegate uint Delegate34(IntPtr intptr_0, Enum9 enum9_0, IntPtr intptr_1, uint uint_0);

	private delegate uint Delegate35(IntPtr intptr_0);

	private delegate uint Delegate36(IntPtr intptr_0, ref IntPtr intptr_1, ref UIntPtr uintptr_0, Enum4 enum4_0, out Enum4 enum4_1);

	private delegate uint Delegate37(IntPtr intptr_0, ref IntPtr intptr_1, IntPtr intptr_2, ref UIntPtr uintptr_0, Enum2 enum2_0, Enum4 enum4_0);

	private delegate uint Delegate38(IntPtr intptr_0, ref IntPtr intptr_1, ref UIntPtr uintptr_0, Enum3 enum3_0);

	private delegate uint Delegate39(IntPtr intptr_0, IntPtr intptr_1);

	private delegate uint Delegate40(IntPtr intptr_0, IntPtr intptr_1, out IntPtr intptr_2, UIntPtr uintptr_0, UIntPtr uintptr_1, Struct7 struct7_0, ref UIntPtr uintptr_2, uint uint_0, uint uint_1, Enum4 enum4_0);

	private delegate uint Delegate41(uint uint_0, uint uint_1, uint uint_2, IntPtr[] intptr_0, uint uint_3, out Enum6 enum6_0);

	private delegate uint Delegate42(out IntPtr intptr_0, uint uint_0, ref Struct5 struct5_0, out Struct6 struct6_0, uint uint_1, uint uint_2);

	private delegate uint Delegate43(out IntPtr intptr_0, uint uint_0, ref Struct5 struct5_0, ref Struct7 struct7_0, Enum4 enum4_0, uint uint_1, IntPtr intptr_1);

	public struct Struct11
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public IntPtr intptr_4;

		public IntPtr intptr_5;
	}

	public enum Enum7
	{
		const_0 = 30,
		const_1 = 7,
		const_2 = 0
	}

	public enum Enum8
	{
		const_0 = 76,
		const_1 = 35,
		const_2 = 0
	}

	public enum Enum9
	{
		const_0 = 17
	}

	private static Delegate39 delegate39_0;

	private static IntPtr intptr_0;

	private static Delegate34 delegate34_0;

	public static readonly IntPtr intptr_1;

	private static Delegate36 delegate36_0;

	private static Delegate41 delegate41_0;

	public static readonly IntPtr intptr_2;

	private static Delegate32 delegate32_0;

	private static Delegate42 delegate42_0;

	private static Delegate40 delegate40_0;

	private static Delegate35 delegate35_0;

	private static Delegate43 delegate43_0;

	private static Delegate38 delegate38_0;

	private static Delegate37 delegate37_0;

	private static Delegate33 delegate33_0;

	public static readonly IntPtr intptr_3;

	public static IntPtr smethod_0(IntPtr intptr_4, Enum5 enum5_0, uint uint_0, uint uint_1, ref UIntPtr uintptr_0)
	{
		object[] array = new object[5] { intptr_4, enum5_0, uint_0, uint_1, uintptr_0 };
		try
		{
			return (IntPtr)new GClass8().method_28(array, 41214);
		}
		finally
		{
			uintptr_0 = (UIntPtr)array[4];
		}
	}

	public static void smethod_1(string string_0, string string_1, GEnum0 genum0_0, GEnum1 genum1_0)
	{
		new GClass8().method_28(new object[4] { string_0, string_1, genum0_0, genum1_0 }, 43077);
	}

	public static bool smethod_2(IntPtr intptr_4)
	{
		return (bool)new GClass8().method_28(new object[1] { intptr_4 }, 41972);
	}

	public static byte[] smethod_3(uint uint_0, uint uint_1)
	{
		return (byte[])(Array)new GClass8().method_28(new object[2] { uint_0, uint_1 }, 71132);
	}

	public static IntPtr smethod_4(IntPtr intptr_4, IntPtr intptr_5, Enum4 enum4_0, uint uint_0, uint uint_1, string string_0)
	{
		return (IntPtr)new GClass8().method_28(new object[6] { intptr_4, intptr_5, enum4_0, uint_0, uint_1, string_0 }, 44532);
	}

	internal static IntPtr smethod_5(IntPtr intptr_4, object object_0)
	{
		return (IntPtr)new GClass8().method_28(new object[2] { intptr_4, object_0 }, 65618);
	}

	public static bool smethod_6()
	{
		return (bool)new GClass8().method_28(null, 42076);
	}

	internal static IntPtr smethod_7(uint uint_0)
	{
		return (IntPtr)new GClass8().method_28(new object[1] { uint_0 }, 65049);
	}

	public static uint smethod_8(IntPtr intptr_4, Enum7 enum7_0, out object object_0, uint uint_0, out uint uint_1)
	{
		object[] array = new object[5] { intptr_4, enum7_0, object_0, uint_0, uint_1 };
		try
		{
			return (uint)new GClass8().method_28(array, 69210);
		}
		finally
		{
			object_0 = array[2];
			uint_1 = (uint)array[4];
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr GetModuleHandle(string string_0);

	public static bool smethod_9()
	{
		return (bool)new GClass8().method_28(null, 42735);
	}

	public static IntPtr smethod_10(string string_0, uint uint_0, uint uint_1)
	{
		return (IntPtr)new GClass8().method_28(new object[3] { string_0, uint_0, uint_1 }, 71934);
	}

	public static uint smethod_11(IntPtr intptr_4, Enum9 enum9_0, IntPtr intptr_5, uint uint_0)
	{
		return (uint)new GClass8().method_28(new object[4] { intptr_4, enum9_0, intptr_5, uint_0 }, 70303);
	}

	private static uint smethod_12(Enum8 enum8_0, out object object_0, uint uint_0, out uint uint_1)
	{
		object[] array = new object[4] { enum8_0, object_0, uint_0, uint_1 };
		try
		{
			return (uint)new GClass8().method_28(array, 69801);
		}
		finally
		{
			object_0 = array[1];
			uint_1 = (uint)array[3];
		}
	}

	public static bool smethod_13(IntPtr intptr_4)
	{
		return (bool)new GClass8().method_28(new object[1] { intptr_4 }, 71825);
	}

	public static bool smethod_14()
	{
		return (bool)new GClass8().method_28(null, 42375);
	}

	public static bool smethod_15(IntPtr intptr_4, UIntPtr uintptr_0, Enum4 enum4_0, out Enum4 enum4_1)
	{
		object[] array = new object[4] { intptr_4, uintptr_0, enum4_0, enum4_1 };
		try
		{
			return (bool)new GClass8().method_28(array, 43979);
		}
		finally
		{
			enum4_1 = (Enum4)array[3];
		}
	}

	public static IntPtr smethod_16(IntPtr intptr_4, UIntPtr uintptr_0, Enum2 enum2_0, Enum4 enum4_0)
	{
		return (IntPtr)new GClass8().method_28(new object[4] { intptr_4, uintptr_0, enum2_0, enum4_0 }, 44142);
	}

	public static byte[] smethod_17(uint uint_0)
	{
		return (byte[])(Array)new GClass8().method_28(new object[1] { uint_0 }, 70453);
	}

	static Class78()
	{
		new GClass8().method_28(null, 64035);
	}
}
