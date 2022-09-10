using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ns9;

internal class Class41
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

		internal static bool AqbCRT4B6uHnDmTw6bY()
		{
			return true;
		}

		internal static bool h5vNqn4WkKx3YZMxD4C()
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
			while (!bool_0)
			{
				if (jA83DF4Zsc8xB5Er2Np())
				{
					switch (3)
					{
					case 0:
					case 2:
						continue;
					case 1:
					case 3:
						struct15_0 = default(Struct15);
						break;
					}
				}
				try
				{
					struct15_0.int_0 = Marshal.SizeOf(typeof(Struct15));
					if (jA83DF4Zsc8xB5Er2Np())
					{
						switch (2)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_008e;
						}
					}
					Class42.GetVersionEx(ref struct15_0);
					goto IL_008e;
					IL_008e:
					bool_0 = true;
				}
				catch
				{
				}
				break;
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
				Class42.GetSystemInfo(ref struct16_);
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
				return Class42.GetSystemMetrics(89) != 0;
			}
			catch
			{
				return false;
			}
		}
	}

	internal static bool IsWorkstation => VersionInfo.byte_0 == 1;

	internal static string ServicePack => VersionInfo.string_0;

	internal static bool jA83DF4Zsc8xB5Er2Np()
	{
		return true;
	}

	internal static bool heMw5O4OicbNcCEA3sn()
	{
		return false;
	}
}
