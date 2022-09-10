using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ns11;

internal class Class57
{
	internal struct Struct23
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct23(Rectangle rectangle)
		{
			int_0 = rectangle.Left;
			int_1 = rectangle.Top;
			int_3 = rectangle.Bottom;
			int_2 = rectangle.Right;
		}

		internal static bool U1A5OGv4lJMm02XnnbJ()
		{
			return true;
		}

		internal static bool mO6YsBvQsUlN2KscxPL()
		{
			return false;
		}
	}

	internal struct Struct24
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

	public struct Struct25
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

	private static Struct24 struct24_0;

	private static Struct24 VersionInfo
	{
		get
		{
			if (!bool_0)
			{
				struct24_0 = default(Struct24);
				try
				{
					struct24_0.int_0 = Marshal.SizeOf(typeof(Struct24));
					if (!CW30s7vS7r53hJBJeEF())
					{
						switch (2)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_005c;
						}
					}
					Class58.GetVersionEx(ref struct24_0);
					goto IL_005c;
					IL_005c:
					bool_0 = true;
				}
				catch
				{
				}
			}
			return struct24_0;
		}
	}

	internal static bool IsX64
	{
		get
		{
			try
			{
				Struct25 struct25_ = default(Struct25);
				Class58.GetSystemInfo(ref struct25_);
				return struct25_.ushort_0 == 9;
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
				return Class58.GetSystemMetrics(89) != 0;
			}
			catch
			{
				return false;
			}
		}
	}

	internal static bool IsWorkstation => VersionInfo.byte_0 == 1;

	internal static string ServicePack => VersionInfo.string_0;

	internal static bool E8vtU2vXM4lTFTmtqCB()
	{
		return true;
	}

	internal static bool CW30s7vS7r53hJBJeEF()
	{
		return false;
	}
}
