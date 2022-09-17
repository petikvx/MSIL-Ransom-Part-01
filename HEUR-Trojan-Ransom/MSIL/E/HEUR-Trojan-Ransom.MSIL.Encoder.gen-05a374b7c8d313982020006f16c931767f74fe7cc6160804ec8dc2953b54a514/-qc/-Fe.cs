using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace _0023qc;

internal class _0023Fe
{
	internal struct _0023tf
	{
		public int _0023a;

		public int _0023b;

		public int _0023c;

		public int _0023d;

		public _0023tf(Rectangle _0023uf)
		{
			_0023a = _0023uf.Left;
			_0023b = _0023uf.Top;
			_0023d = _0023uf.Bottom;
			_0023c = _0023uf.Right;
		}
	}

	internal struct _0023vf
	{
		public int _0023a;

		public uint _0023b;

		public uint _0023c;

		public uint _0023d;

		public uint _0023e;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string _0023f;

		public ushort _0023g;

		public ushort _0023h;

		public ushort _0023i;

		public byte _0023j;

		private byte _0023k;
	}

	public struct _0023wf
	{
		public ushort _0023a;

		private ushort _0023b;

		public uint _0023c;

		public IntPtr _0023d;

		public IntPtr _0023e;

		public IntPtr _0023f;

		public uint _0023g;

		public uint _0023h;

		public uint _0023i;

		public ushort _0023j;

		public ushort _0023k;
	}

	private const int _0023a = 16;

	private const int _0023b = 1024;

	private const int _0023c = 2048;

	private const int _0023d = 1;

	private const int _0023e = 89;

	private const int _0023f = 9;

	private static bool _0023g;

	private static _0023vf _0023h;

	private static _0023vf VersionInfo
	{
		get
		{
			if (!_0023g)
			{
				_0023h = default(_0023vf);
				try
				{
					_0023h._0023a = Marshal.SizeOf(typeof(_0023vf));
					_0023_0023._00231f(ref _0023h);
					_0023g = true;
				}
				catch
				{
				}
			}
			return _0023h;
		}
	}

	internal static bool IsX64
	{
		get
		{
			try
			{
				_0023wf _0023xe = default(_0023wf);
				_0023_0023._0023ng(ref _0023xe);
				return _0023xe._0023a == 9;
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
				return _0023_0023._0023Qh(89) != 0;
			}
			catch
			{
				return false;
			}
		}
	}

	internal static bool IsWorkstation => VersionInfo._0023j == 1;

	internal static string ServicePack => VersionInfo._0023f;
}
