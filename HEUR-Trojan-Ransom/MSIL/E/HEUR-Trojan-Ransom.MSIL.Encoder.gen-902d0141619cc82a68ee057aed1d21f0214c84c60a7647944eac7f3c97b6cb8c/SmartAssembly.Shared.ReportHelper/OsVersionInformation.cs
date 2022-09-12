using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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

	internal static bool? _0002;

	[DllImport("kernel32.Dll", EntryPoint = "GetVersionEx")]
	private static extern short _0005_0014_000F(ref _0083_0012_000F P_0);

	[SpecialName]
	internal unsafe static bool _0012_0013_009B()
	{
		//IL_004c: Incompatible stack heights: 0 vs 1
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0065: Incompatible stack heights: 0 vs 3
		//IL_006c: Incompatible stack heights: 0 vs 1
		//IL_0073: Incompatible stack heights: 0 vs 1
		//IL_007a: Incompatible stack heights: 0 vs 1
		//IL_007d: Incompatible stack heights: 0 vs 1
		//IL_0084: Incompatible stack heights: 0 vs 1
		//IL_00a1: Incompatible stack heights: 0 vs 1
		//IL_00ab: Incompatible stack heights: 0 vs 1
		_ = _0001.HasValue;
		if ((int)/*Error near IL_000f: Stack underflow*/ == 0)
		{
			try
			{
				_0083_0012_000F obj;
				if (8u != 0)
				{
					obj = default(_0083_0012_000F);
					_ = ref obj;
					_ = _007F._009F_0002;
					_001F._009E_0002(typeof(_0083_0012_000F).TypeHandle);
					/*Error near IL_006c: Stack underflow*/((Type)/*Error near IL_006c: Stack underflow*/);
					((_0083_0012_000F*)(nint)/*Error near IL_0034: Stack underflow*/)->_0001 = (int)/*Error near IL_0034: Stack underflow*/;
				}
				do
				{
					IL_0034:
					_0005_0014_000F(ref obj);
					int num;
					if (0 == 0)
					{
						num = 0;
						if (num != 0)
						{
							goto IL_007f;
						}
						new bool?((byte)num != 0);
						_0001 = (bool?)/*Error near IL_0047: Stack underflow*/;
						if (6 == 0)
						{
							goto IL_0034;
						}
						_ = ((_0083_0012_000F)/*Error near IL_0051: Stack underflow*/)._000F;
					}
					num = (((int)/*Error near IL_0054: Stack underflow*/ == 1) ? 1 : 0);
					goto IL_007f;
					IL_007f:
					new bool?((byte)num != 0);
					_0001 = (bool?)/*Error near IL_005b: Stack underflow*/;
				}
				while (-1 == 0);
			}
			catch
			{
				_0001 = false;
			}
		}
		_ = _0001.Value;
		return (byte)/*Error near IL_009c: Stack underflow*/ != 0;
	}

	internal static bool _001B_0094_0004_0002(string P_0, string P_1)
	{
		//IL_001b: Incompatible stack heights: 0 vs 1
		//IL_0035: Incompatible stack heights: 0 vs 1
		//IL_003c: Incompatible stack heights: 0 vs 1
		//IL_0042: Incompatible stack heights: 0 vs 2
		//IL_0049: Incompatible stack heights: 0 vs 1
		//IL_004c: Incompatible stack heights: 0 vs 2
		//IL_004f: Incompatible stack heights: 0 vs 1
		//IL_0056: Incompatible stack heights: 0 vs 1
		//IL_005d: Incompatible stack heights: 0 vs 1
		_0010_008D_0010((string)/*Error near IL_003c: Stack underflow*/);
		IntPtr intPtr = (IntPtr)/*Error near IL_003f: Stack underflow*/;
		_ = _0080._0001_0003;
		IntPtr zero = IntPtr.Zero;
		/*Error near IL_0049: Stack underflow*/((IntPtr)/*Error near IL_0049: Stack underflow*/, zero);
		if (uint.MaxValue != 0)
		{
			if ((int)/*Error near IL_0019: Stack underflow*/ != 0 || 1 == 0)
			{
				if (0 == 0)
				{
					return (byte)/*Error near IL_001e: Stack underflow*/ != 0;
				}
			}
			else
			{
				_ = _0080._0002_0003;
				_000F_001D_0004((IntPtr)/*Error near IL_0056: Stack underflow*/, (string)/*Error near IL_0056: Stack underflow*/);
				IntPtr zero2 = IntPtr.Zero;
				/*Error near IL_005d: Stack underflow*/((IntPtr)/*Error near IL_005d: Stack underflow*/, zero2);
			}
		}
		return (byte)/*Error near IL_0034: Stack underflow*/ != 0;
	}

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
	internal static extern IntPtr _0008_000F_0005();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GetModuleHandle")]
	private static extern IntPtr _0010_008D_0010(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "GetProcAddress", SetLastError = true)]
	private static extern IntPtr _000F_001D_0004(IntPtr _0001_0093_0093_0003, [MarshalAs(UnmanagedType.LPStr)] string _0002_0093_0093_0003);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "IsWow64Process", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool _0094_0087_0084(IntPtr _0019_0002_0019_0002, out bool _0003_0093_0093_0003);
}
