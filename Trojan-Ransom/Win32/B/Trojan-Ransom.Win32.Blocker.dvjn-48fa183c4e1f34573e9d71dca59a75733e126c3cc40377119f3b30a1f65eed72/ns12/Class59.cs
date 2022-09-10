using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ns12;

internal class Class59
{
	internal struct Struct23
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct23(Rectangle rectangle)
		{
			int num = 4;
			if (!eElMEsRSkrMdGuq6Git())
			{
				goto IL_001e;
			}
			goto IL_0054;
			IL_0054:
			switch (num)
			{
			case 0:
			case 4:
				int_0 = rectangle.Left;
				goto IL_0038;
			case 1:
			case 3:
				goto IL_0038;
			case 5:
				return;
			}
			goto IL_001e;
			IL_001e:
			int_2 = rectangle.Right;
			num = 5;
			if (!eElMEsRSkrMdGuq6Git())
			{
				goto IL_0038;
			}
			goto IL_0054;
			IL_0038:
			int_1 = rectangle.Top;
			int_3 = rectangle.Bottom;
			goto IL_001e;
		}

		internal static bool eElMEsRSkrMdGuq6Git()
		{
			return true;
		}

		internal static bool ifgyRARMaLXbvGaPv0B()
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
					if (MJVrx2RvM6GYNssHjnm())
					{
					}
					switch (2)
					{
					case 0:
					case 2:
						Class12.GetVersionEx(ref struct24_0);
						break;
					}
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
				Class12.GetSystemInfo(ref struct25_);
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
				return Class12.GetSystemMetrics(89) != 0;
			}
			catch
			{
				return false;
			}
		}
	}

	internal static bool IsWorkstation => VersionInfo.byte_0 == 1;

	internal static string ServicePack => VersionInfo.string_0;

	internal static bool SmtavERjHw3881SyAqI()
	{
		return true;
	}

	internal static bool MJVrx2RvM6GYNssHjnm()
	{
		return false;
	}
}
