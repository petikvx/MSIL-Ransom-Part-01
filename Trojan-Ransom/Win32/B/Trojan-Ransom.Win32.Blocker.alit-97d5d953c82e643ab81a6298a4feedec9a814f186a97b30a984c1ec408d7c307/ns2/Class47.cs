using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ns5;

namespace ns2;

internal sealed class Class47
{
	internal struct Struct20
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct20(Rectangle rectangle)
		{
			int_0 = rectangle.Left;
			int_1 = rectangle.Top;
			int_3 = rectangle.Bottom;
			int_2 = rectangle.Right;
		}
	}

	internal struct Struct21
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

	public struct Struct22
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

	private const int int_0 = 16;

	private const int int_1 = 1024;

	private const int int_2 = 2048;

	private const int int_3 = 1;

	private const int int_4 = 89;

	private const int int_5 = 9;

	private static bool bool_0;

	private static Struct21 struct21_0;

	private static Struct21 VersionInfo
	{
		get
		{
			if (!bool_0)
			{
				struct21_0 = default(Struct21);
				try
				{
					struct21_0.int_0 = Marshal.SizeOf(typeof(Struct21));
					Class32.GetVersionEx(ref struct21_0);
					bool_0 = true;
				}
				catch
				{
				}
			}
			return struct21_0;
		}
	}

	internal static bool IsX64
	{
		get
		{
			try
			{
				Struct22 lpSystemInfo = default(Struct22);
				Class32.GetSystemInfo(ref lpSystemInfo);
				return lpSystemInfo.ushort_0 == 9;
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
				return Class32.GetSystemMetrics(89) != 0;
			}
			catch
			{
				return false;
			}
		}
	}

	internal static bool IsWorkstation => VersionInfo.byte_0 == 1;

	internal static string ServicePack => VersionInfo.string_0;
}
