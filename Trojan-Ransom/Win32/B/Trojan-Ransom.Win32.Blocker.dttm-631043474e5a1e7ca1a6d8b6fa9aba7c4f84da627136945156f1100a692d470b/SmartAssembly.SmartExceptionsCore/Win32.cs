using System;
using System.Runtime.InteropServices;

namespace SmartAssembly.SmartExceptionsCore;

public class Win32
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

	public struct SYSTEM_INFO
	{
		public ushort wProcessorArchitecture;

		private ushort ushort_0;

		public uint dwPageSize;

		public IntPtr lpMinimumApplicationAddress;

		public IntPtr lpMaximumApplicationAddress;

		public IntPtr dwActiveProcessorMask;

		public uint dwNumberOfProcessors;

		public uint dwProcessorType;

		public uint dwAllocationGranularity;

		public ushort wProcessorLevel;

		public ushort wProcessorRevision;
	}

	private static bool bool_0;

	private static Struct7 struct7_0;

	private static Struct7 VersionInfo
	{
		get
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
	}

	internal static bool IsX64
	{
		get
		{
			try
			{
				SYSTEM_INFO system_INFO_ = default(SYSTEM_INFO);
				GetSystemInfo(ref system_INFO_);
				return system_INFO_.wProcessorArchitecture == 9;
			}
			catch
			{
				return false;
			}
		}
	}

	internal static bool IsServerR2
	{
		get
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
	}

	internal static bool IsWorkstation => VersionInfo.byte_0 == 1;

	internal static string ServicePack => VersionInfo.string_0;

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct7 struct7_1);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int int_0);

	[DllImport("kernel32.dll")]
	private static extern void GetSystemInfo(ref SYSTEM_INFO system_INFO_0);
}
