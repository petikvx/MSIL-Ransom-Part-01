using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0023ab;

namespace SmartAssembly.Shared.ReportHelper;

public static class OsVersionInformation
{
	private struct _0083_0012_000F
	{
		public int _0001;

		public uint _0002;

		public uint _0003;

		public uint _0004;

		public uint _0005;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string _0006;

		public ushort _0007;

		public ushort _0008;

		public ushort _000E;

		public byte _000F;

		private byte _0010;
	}

	private static bool? _0001;

	private static bool? _0002;

	public static bool IsX64
	{
		get
		{
			if (!_0002.HasValue)
			{
				try
				{
					if (IntPtr.Size == 8)
					{
						_0002 = true;
					}
					else
					{
						bool _0003_0093_0093_0003 = default(bool);
						_0002 = _001B_0094_0004_0002(_00239._00237(107395365), _00239._00237(107395380)) && _0094_0087_0084(_0008_000F_0005(), out _0003_0093_0093_0003) && _0003_0093_0093_0003;
					}
				}
				catch
				{
					_0002 = false;
				}
			}
			return _0002.Value;
		}
	}

	[DllImport("kernel32.Dll", EntryPoint = "GetVersionEx")]
	private static extern short _0005_0014_000F(ref _0083_0012_000F P_0);

	[SpecialName]
	internal static bool _0012_0013_009B()
	{
		if (!_0001.HasValue)
		{
			try
			{
				_0083_0012_000F obj = default(_0083_0012_000F);
				obj._0001 = Marshal.SizeOf(typeof(_0083_0012_000F));
				_0005_0014_000F(ref obj);
				_0001 = false;
				_0001 = obj._000F == 1;
			}
			catch
			{
				_0001 = false;
			}
		}
		return _0001.Value;
	}

	private static bool _001B_0094_0004_0002(string P_0, string P_1)
	{
		IntPtr intPtr = _0010_008D_0010(P_0);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		return _000F_001D_0004(intPtr, P_1) != IntPtr.Zero;
	}

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
	private static extern IntPtr _0008_000F_0005();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GetModuleHandle")]
	private static extern IntPtr _0010_008D_0010(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "GetProcAddress", SetLastError = true)]
	private static extern IntPtr _000F_001D_0004(IntPtr _0001_0093_0093_0003, [MarshalAs(UnmanagedType.LPStr)] string _0002_0093_0093_0003);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "IsWow64Process", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool _0094_0087_0084(IntPtr _0019_0002_0019_0002, out bool _0003_0093_0093_0003);
}
