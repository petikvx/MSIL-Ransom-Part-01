using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns1;

internal sealed class Class7
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct0
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public uint uint_0;

		private uint uint_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct1
	{
		public uint uint_0;

		private string string_0;

		private string string_1;

		private string string_2;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
		private byte[] byte_0;

		private IntPtr intptr_0;

		private IntPtr intptr_1;

		private IntPtr intptr_2;

		private IntPtr intptr_3;
	}

	public struct Struct2
	{
		public Enum0 enum0_0;

		public int int_0;

		public int int_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 86, ArraySubType = UnmanagedType.U1)]
		public byte[] byte_0;

		[SpecialName]
		public Struct4 method_0()
		{
			return method_1<Struct4>();
		}

		private T method_1<T>() where T : struct
		{
			int num = Marshal.SizeOf(typeof(T));
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(byte_0, 0, intPtr, num);
			object objectValue = RuntimeHelpers.GetObjectValue(Marshal.PtrToStructure(intPtr, typeof(T)));
			Marshal.FreeHGlobal(intPtr);
			return (T)objectValue;
		}
	}

	public struct Struct3
	{
		public uint uint_0;

		public uint uint_1;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public uint uint_2;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.U4)]
		public uint[] uint_3;
	}

	public struct Struct4
	{
		public Struct3 struct3_0;

		public uint uint_0;
	}

	public enum Enum0
	{
		const_0 = 4,
		const_1 = 6,
		const_2 = 8,
		const_3 = 3,
		const_4 = 2,
		const_5 = 9,
		const_6 = 7,
		const_7 = 1,
		const_8 = 5
	}

	public delegate bool Delegate0(IntPtr intptr_0, uint uint_0, int int_0, uint uint_1, ref uint uint_2);

	public delegate bool Delegate1(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_0, IntPtr intptr_2, string string_2, ref Struct1 struct1_0, ref Struct0 struct0_0);

	public delegate bool Delegate2(IntPtr intptr_0, int int_0, ref int int_1, int int_2, ref int int_3);

	public delegate bool Delegate3(IntPtr intptr_0, int int_0, byte[] byte_0, int int_1, ref int int_2);

	public delegate bool Delegate4(IntPtr intptr_0, int[] int_0);

	public delegate uint Delegate5(IntPtr intptr_0, int[] int_0);

	public delegate int Delegate6(IntPtr intptr_0, int int_0);

	public delegate int Delegate7(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3);

	public delegate int Delegate8(IntPtr handle, out uint SuspendCount);

	public delegate bool Delegate9(int int_0);

	public delegate bool Delegate10(out Struct2 lpDebugEvent, int dwMilliseconds);

	public delegate bool Delegate11([In] bool KillOnExit);

	public delegate bool Delegate12(int int_0, int int_1, int int_2);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);
}
