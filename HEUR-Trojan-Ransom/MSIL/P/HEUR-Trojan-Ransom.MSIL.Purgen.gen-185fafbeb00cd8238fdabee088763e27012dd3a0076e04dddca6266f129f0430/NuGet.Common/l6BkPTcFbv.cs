using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NuGet.Common;

public static class l6BkPTcFbv
{
	[CompilerGenerated]
	private sealed class UmbZAh3dYR
	{
		public string Tyfn7HcNKW;

		internal bool CKN7c2gzCP(string _6YMr99ysUI)
		{
			return _6YMr99ysUI.Equals(Tyfn7HcNKW, StringComparison.OrdinalIgnoreCase);
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _1aGvinZU7S
	{
		public static readonly _1aGvinZU7S MhTKOAL7VI = new _1aGvinZU7S();

		internal bool nP8U01Dzf7()
		{
			return Type.GetType("Mono.Runtime") != null;
		}

		internal bool _1e3FEAN2wX()
		{
			UmbZAh3dYR CS_0024_003C_003E8__locals0 = new UmbZAh3dYR
			{
				Tyfn7HcNKW = Path.GetFileNameWithoutExtension(_56l6aVYZ3f())
			};
			return OaPxlxsXSe.Any((string _6YMr99ysUI) => _6YMr99ysUI.Equals(CS_0024_003C_003E8__locals0.Tyfn7HcNKW, StringComparison.OrdinalIgnoreCase));
		}
	}

	private static readonly string[] OaPxlxsXSe = new string[2] { "DEVENV", "BLEND" };

	private static Lazy<bool> dF1If1Vy6X = new Lazy<bool>(() => Type.GetType("Mono.Runtime") != null);

	private static Lazy<bool> sUHklNG35R = new Lazy<bool>(delegate
	{
		string Tyfn7HcNKW = Path.GetFileNameWithoutExtension(_56l6aVYZ3f());
		return OaPxlxsXSe.Any((string _6YMr99ysUI) => _6YMr99ysUI.Equals(Tyfn7HcNKW, StringComparison.OrdinalIgnoreCase));
	});

	[CompilerGenerated]
	private static bool e6jyEuGutY;

	public static bool OoRgJZVw7H
	{
		[CompilerGenerated]
		get
		{
			return e6jyEuGutY;
		}
		[CompilerGenerated]
		set
		{
			e6jyEuGutY = value;
		}
	}

	public static bool ooEPhgvzVK
	{
		get
		{
			int platform = (int)Environment.OSVersion.Platform;
			if (platform != 4 && platform != 6)
			{
				return platform != 128;
			}
			return false;
		}
	}

	public static bool k7Msslik5l
	{
		get
		{
			if (urWeakwFtm)
			{
				return false;
			}
			return dF1If1Vy6X.Value;
		}
	}

	public static bool urWeakwFtm => sUHklNG35R.Value;

	public static bool hYjWrmIQM5
	{
		get
		{
			IntPtr intPtr = IntPtr.Zero;
			try
			{
				intPtr = Marshal.AllocHGlobal(8192);
				if (sl3dT1hFQk(intPtr) == 0 && Marshal.PtrToStringAnsi(intPtr) == "Darwin")
				{
					return true;
				}
			}
			catch
			{
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
			return false;
		}
	}

	public static bool cW7xbf8Fg7 => Environment.OSVersion.Platform == PlatformID.Unix;

	[DllImport("libc", EntryPoint = "uname")]
	private static extern int sl3dT1hFQk(IntPtr M7jvZ29fTM);

	private static string _56l6aVYZ3f()
	{
		using Process process = Process.GetCurrentProcess();
		return process.MainModule!.FileName;
	}
}
