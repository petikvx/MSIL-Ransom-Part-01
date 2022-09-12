using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal static class Class78
{
	public enum Enum2 : uint
	{
		const_0 = 8192u,
		const_1 = 4096u
	}

	public enum Enum3 : uint
	{
		const_0 = 0x8000u
	}

	public enum Enum4 : uint
	{
		const_0 = 32u,
		const_1 = 16u,
		const_2 = 2u,
		const_3 = 256u,
		const_4 = 4u,
		const_5 = 1u,
		const_6 = 8u,
		const_7 = 64u
	}

	public enum Enum5 : uint
	{
		const_0 = 4u,
		const_1 = 1u,
		const_2 = 2u,
		const_3 = 8u
	}

	public struct Struct4
	{
		public readonly ushort ushort_0;

		public readonly ushort ushort_1;

		private readonly IntPtr intptr_0;

		public unsafe void method_0()
		{
			//IL_0013: Expected O, but got Ref
			new GClass8().method_32(new object[1] { (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) }, 81677);
		}

		public unsafe Struct4(string string_0)
		{
			//IL_0013: Expected O, but got Ref
			new GClass8().method_32(new object[2]
			{
				(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this),
				string_0
			}, 81386);
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
			new GClass8().method_32(new object[1] { (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) }, 82125);
		}

		public unsafe Struct5(Struct4 struct4_0, uint uint_2)
		{
			//IL_0013: Expected O, but got Ref
			new GClass8().method_32(new object[3]
			{
				(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this),
				struct4_0,
				uint_2
			}, 81833);
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
		const_0 = 8,
		const_1 = 0,
		const_2 = 1,
		const_3 = 5,
		const_4 = 7,
		const_5 = 2,
		const_6 = 3,
		const_7 = 4,
		const_8 = 6
	}

	private delegate uint Delegate34(IntPtr intptr_0, Enum7 enum7_0, IntPtr intptr_1, uint uint_0, out uint uint_1);

	private delegate uint Delegate35(Enum8 enum8_0, IntPtr intptr_0, uint uint_0, out uint uint_1);

	private delegate uint Delegate36(IntPtr intptr_0, Enum9 enum9_0, IntPtr intptr_1, uint uint_0);

	private delegate uint Delegate37(IntPtr intptr_0);

	private delegate uint Delegate38(IntPtr intptr_0, ref IntPtr intptr_1, ref UIntPtr uintptr_0, Enum4 enum4_0, out Enum4 enum4_1);

	private delegate uint Delegate39(IntPtr intptr_0, ref IntPtr intptr_1, IntPtr intptr_2, ref UIntPtr uintptr_0, Enum2 enum2_0, Enum4 enum4_0);

	private delegate uint Delegate40(IntPtr intptr_0, ref IntPtr intptr_1, ref UIntPtr uintptr_0, Enum3 enum3_0);

	private delegate uint Delegate41(IntPtr intptr_0, IntPtr intptr_1);

	private delegate uint Delegate42(IntPtr intptr_0, IntPtr intptr_1, out IntPtr intptr_2, UIntPtr uintptr_0, UIntPtr uintptr_1, Struct7 struct7_0, ref UIntPtr uintptr_2, uint uint_0, uint uint_1, Enum4 enum4_0);

	private delegate uint Delegate43(uint uint_0, uint uint_1, uint uint_2, IntPtr[] intptr_0, uint uint_3, out Enum6 enum6_0);

	private delegate uint Delegate44(out IntPtr intptr_0, uint uint_0, ref Struct5 struct5_0, out Struct6 struct6_0, uint uint_1, uint uint_2);

	private delegate uint Delegate45(out IntPtr intptr_0, uint uint_0, ref Struct5 struct5_0, ref Struct7 struct7_0, Enum4 enum4_0, uint uint_1, IntPtr intptr_1);

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
		const_0 = 0,
		const_1 = 7,
		const_2 = 30
	}

	public enum Enum8
	{
		const_0 = 0,
		const_1 = 35,
		const_2 = 76
	}

	public enum Enum9
	{
		const_0 = 17
	}

	private static Delegate43 delegate43_0;

	private static Delegate37 delegate37_0;

	public static readonly IntPtr intptr_0;

	private static Delegate40 delegate40_0;

	private static Delegate34 delegate34_0;

	private static Delegate36 delegate36_0;

	private static Delegate35 delegate35_0;

	private static Delegate44 delegate44_0;

	public static readonly IntPtr intptr_1;

	private static IntPtr intptr_2;

	private static Delegate38 delegate38_0;

	private static Delegate45 delegate45_0;

	private static Delegate39 delegate39_0;

	private static Delegate42 delegate42_0;

	private static Delegate41 delegate41_0;

	public static readonly IntPtr intptr_3;

	public static bool smethod_0()
	{
		return (bool)new GClass8().method_32(null, 42171);
	}

	internal static IntPtr smethod_1(uint uint_0)
	{
		return (IntPtr)new GClass8().method_32(new object[1] { uint_0 }, 73439);
	}

	internal static IntPtr smethod_2(IntPtr intptr_4, object object_0)
	{
		return (IntPtr)new GClass8().method_32(new object[2] { intptr_4, object_0 }, 74008);
	}

	public static bool smethod_3()
	{
		return (bool)new GClass8().method_32(null, 41872);
	}

	public static IntPtr smethod_4(string string_0, uint uint_0, uint uint_1)
	{
		return (IntPtr)new GClass8().method_32(new object[3] { string_0, uint_0, uint_1 }, 80324);
	}

	public static uint smethod_5(IntPtr intptr_4, Enum7 enum7_0, out object object_0, uint uint_0, out uint uint_1)
	{
		object[] array = new object[5] { intptr_4, enum7_0, object_0, uint_0, uint_1 };
		try
		{
			return (uint)new GClass8().method_32(array, 77600);
		}
		finally
		{
			object_0 = array[2];
			uint_1 = (uint)array[4];
		}
	}

	public static byte[] smethod_6(uint uint_0)
	{
		return (byte[])(Array)new GClass8().method_32(new object[1] { uint_0 }, 78843);
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr GetModuleHandle(string string_0);

	public static bool smethod_7()
	{
		return (bool)new GClass8().method_32(null, 42531);
	}

	public static IntPtr smethod_8(IntPtr intptr_4, UIntPtr uintptr_0, Enum2 enum2_0, Enum4 enum4_0)
	{
		return (IntPtr)new GClass8().method_32(new object[4] { intptr_4, uintptr_0, enum2_0, enum4_0 }, 64551);
	}

	public static bool smethod_9(IntPtr intptr_4, UIntPtr uintptr_0, Enum4 enum4_0, out Enum4 enum4_1)
	{
		object[] array = new object[4] { intptr_4, uintptr_0, enum4_0, enum4_1 };
		try
		{
			return (bool)new GClass8().method_32(array, 64388);
		}
		finally
		{
			enum4_1 = (Enum4)array[3];
		}
	}

	public static byte[] smethod_10(uint uint_0, uint uint_1)
	{
		return (byte[])(Array)new GClass8().method_32(new object[2] { uint_0, uint_1 }, 79522);
	}

	public static void smethod_11(string string_0, string string_1, GEnum0 genum0_0, GEnum1 genum1_0)
	{
		new GClass8().method_32(new object[4] { string_0, string_1, genum0_0, genum1_0 }, 42873);
	}

	public static bool smethod_12(IntPtr intptr_4)
	{
		return (bool)new GClass8().method_32(new object[1] { intptr_4 }, 41768);
	}

	public static uint smethod_13(IntPtr intptr_4, Enum9 enum9_0, IntPtr intptr_5, uint uint_0)
	{
		return (uint)new GClass8().method_32(new object[4] { intptr_4, enum9_0, intptr_5, uint_0 }, 78693);
	}

	public static IntPtr smethod_14(IntPtr intptr_4, Enum5 enum5_0, uint uint_0, uint uint_1, ref UIntPtr uintptr_0)
	{
		object[] array = new object[5] { intptr_4, enum5_0, uint_0, uint_1, uintptr_0 };
		try
		{
			return (IntPtr)new GClass8().method_32(array, 41010);
		}
		finally
		{
			uintptr_0 = (UIntPtr)array[4];
		}
	}

	private static uint smethod_15(Enum8 enum8_0, out object object_0, uint uint_0, out uint uint_1)
	{
		object[] array = new object[4] { enum8_0, object_0, uint_0, uint_1 };
		try
		{
			return (uint)new GClass8().method_32(array, 78191);
		}
		finally
		{
			object_0 = array[1];
			uint_1 = (uint)array[3];
		}
	}

	public static IntPtr smethod_16(IntPtr intptr_4, IntPtr intptr_5, Enum4 enum4_0, uint uint_0, uint uint_1, string string_0)
	{
		return (IntPtr)new GClass8().method_32(new object[6] { intptr_4, intptr_5, enum4_0, uint_0, uint_1, string_0 }, 64941);
	}

	public static bool smethod_17(IntPtr intptr_4)
	{
		return (bool)new GClass8().method_32(new object[1] { intptr_4 }, 80215);
	}

	static Class78()
	{
		new GClass8().method_32(null, 72425);
	}
}
