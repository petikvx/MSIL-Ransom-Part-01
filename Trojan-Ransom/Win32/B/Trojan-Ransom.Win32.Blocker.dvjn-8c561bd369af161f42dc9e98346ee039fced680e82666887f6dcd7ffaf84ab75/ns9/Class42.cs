using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ns9;

internal class Class42
{
	internal struct Struct14
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct14(Rectangle rectangle)
		{
			int_0 = rectangle.Left;
			int_1 = rectangle.Top;
			int_3 = rectangle.Bottom;
			int_2 = rectangle.Right;
		}

		internal static bool j8GLRvrOBWhq7TtBKfn()
		{
			return true;
		}

		internal static bool SBn1TLrGmRxLK3UuSRi()
		{
			return false;
		}
	}

	internal struct Struct15
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

	public struct Struct16
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

	private static Struct15 struct15_0;

	private static Struct15 VersionInfo
	{
		get
		{
			if (!bool_0)
			{
				struct15_0 = default(Struct15);
				try
				{
					struct15_0.int_0 = Marshal.SizeOf(typeof(Struct15));
					Class33.GetVersionEx(ref struct15_0);
					bool_0 = true;
				}
				catch
				{
				}
			}
			return struct15_0;
		}
	}

	internal static bool IsX64
	{
		get
		{
			try
			{
				Struct16 struct16_ = default(Struct16);
				Class33.GetSystemInfo(ref struct16_);
				return struct16_.ushort_0 == 9;
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
				return Class33.GetSystemMetrics(89) != 0;
			}
			catch
			{
				return false;
			}
		}
	}

	internal static bool IsWorkstation => VersionInfo.byte_0 == 1;

	internal static string ServicePack => VersionInfo.string_0;

	internal static bool kMkLIUrNTWwRCJm0ZJ4()
	{
		return true;
	}

	internal static bool d1f7cdrgm8nNVes6C9V()
	{
		return false;
	}
}
