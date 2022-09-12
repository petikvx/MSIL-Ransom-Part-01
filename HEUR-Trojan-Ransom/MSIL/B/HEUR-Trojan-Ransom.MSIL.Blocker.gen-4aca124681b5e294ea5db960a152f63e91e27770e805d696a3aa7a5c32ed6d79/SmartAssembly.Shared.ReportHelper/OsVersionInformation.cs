using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace SmartAssembly.Shared.ReportHelper;

public static class OsVersionInformation
{
	private struct Struct2
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

	private static bool? nullable_0;

	private static bool? nullable_1;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct2 struct2_0);

	[SpecialName]
	internal static bool smethod_0()
	{
		if (!nullable_0.HasValue)
		{
			try
			{
				Struct2 struct2_ = default(Struct2);
				struct2_.int_0 = Marshal.SizeOf(typeof(Struct2));
				GetVersionEx(ref struct2_);
				nullable_0 = false;
				nullable_0 = struct2_.byte_0 == 1;
			}
			catch
			{
				nullable_0 = false;
			}
		}
		return nullable_0.Value;
	}

	[SpecialName]
	public static bool smethod_1()
	{
		if (!nullable_1.HasValue)
		{
			try
			{
				if (IntPtr.Size == 8)
				{
					nullable_1 = true;
				}
				else
				{
					bool bool_ = default(bool);
					nullable_1 = smethod_2(getString_0(107390122), getString_0(107390073)) && IsWow64Process(GetCurrentProcess(), out bool_) && bool_;
				}
			}
			catch
			{
				nullable_1 = false;
			}
		}
		return nullable_1.Value;
	}

	private static bool smethod_2(string string_0, string string_1)
	{
		IntPtr moduleHandle = GetModuleHandle(string_0);
		if (moduleHandle == IntPtr.Zero)
		{
			return false;
		}
		return GetProcAddress(moduleHandle, string_1) != IntPtr.Zero;
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPStr)] string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWow64Process(IntPtr intptr_0, out bool bool_0);

	static OsVersionInformation()
	{
		Strings.CreateGetStringDelegate(typeof(OsVersionInformation));
	}
}
