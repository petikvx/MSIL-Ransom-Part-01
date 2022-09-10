using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns6;

internal sealed class Class34
{
	private struct Struct7
	{
		public int int_0;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string string_0;

		public ushort ushort_0;

		public ushort ushort_1;

		public ushort ushort_2;

		public byte byte_0;

		private byte byte_1;
	}

	public struct Struct8
	{
		public ushort ushort_0;

		private ushort ushort_1;

		public uint uint_0;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public ushort ushort_2;

		public ushort ushort_3;
	}

	private static bool bool_0;

	private static Struct7 struct7_0;

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct7 struct7_1);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int int_0);

	[DllImport("kernel32.dll")]
	private static extern void GetSystemInfo(ref Struct8 struct8_0);

	[SpecialName]
	private static Struct7 smethod_0()
	{
		if (!bool_0)
		{
			struct7_0 = default(Struct7);
			try
			{
				struct7_0.int_0 = Marshal.SizeOf(typeof(Struct7));
				GetVersionEx(ref struct7_0);
				bool_0 = true;
			}
			catch
			{
			}
		}
		return struct7_0;
	}

	[SpecialName]
	internal static bool smethod_1()
	{
		try
		{
			Struct8 struct8_ = default(Struct8);
			GetSystemInfo(ref struct8_);
			return struct8_.ushort_0 == 9;
		}
		catch
		{
			return false;
		}
	}

	[SpecialName]
	internal static bool smethod_2()
	{
		try
		{
			return GetSystemMetrics(89) != 0;
		}
		catch
		{
			return false;
		}
	}

	[SpecialName]
	internal static bool smethod_3()
	{
		return smethod_0().byte_0 == 1;
	}

	[SpecialName]
	internal static string smethod_4()
	{
		return smethod_0().string_0;
	}
}
