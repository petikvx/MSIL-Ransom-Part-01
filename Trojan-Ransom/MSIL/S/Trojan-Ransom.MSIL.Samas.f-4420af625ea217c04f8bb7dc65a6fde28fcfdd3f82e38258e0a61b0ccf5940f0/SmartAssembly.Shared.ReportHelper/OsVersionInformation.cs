using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartAssembly.Shared.ReportHelper;

public static class OsVersionInformation
{
	private struct Struct5
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

	public static bool IsX64
	{
		get
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
						nullable_1 = smethod_1("kernel32.dll", "IsWow64Process") && IsWow64Process(GetCurrentProcess(), out bool_) && bool_;
					}
				}
				catch
				{
					nullable_1 = false;
				}
			}
			return nullable_1.Value;
		}
	}

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct5 struct5_0);

	[SpecialName]
	internal static bool smethod_0()
	{
		if (!nullable_0.HasValue)
		{
			try
			{
				Struct5 struct5_ = default(Struct5);
				struct5_.int_0 = Marshal.SizeOf(typeof(Struct5));
				GetVersionEx(ref struct5_);
				nullable_0 = false;
				nullable_0 = struct5_.byte_0 == 1;
			}
			catch
			{
				nullable_0 = false;
			}
		}
		return nullable_0.Value;
	}

	private static bool smethod_1(string string_0, string string_1)
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
}
