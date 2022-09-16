using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns12;

public static class Unst0ck
{
	private static readonly string[] string_0 = new string[2] { "DEVENV", "BLEND" };

	private static Lazy<bool> F6uida66y = new Lazy<bool>(() => Type.GetType("Mono.Runtime") != null);

	private static Lazy<bool> Syn4rg4tic = new Lazy<bool>(delegate
	{
		string currentProcessName = Path.GetFileNameWithoutExtension(Th5b5());
		return string_0.Any((string process) => process.Equals(currentProcessName, StringComparison.OrdinalIgnoreCase));
	});

	[CompilerGenerated]
	private static bool Use4ulness;

	public static bool Tende1loins
	{
		[CompilerGenerated]
		get
		{
			return Use4ulness;
		}
		[CompilerGenerated]
		set
		{
			Use4ulness = value;
		}
	}

	public static bool Oli1odendrocyte
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

	public static bool D4bbin
	{
		get
		{
			if (Turbinat8d)
			{
				return false;
			}
			return F6uida66y.Value;
		}
	}

	public static bool Turbinat8d => Syn4rg4tic.Value;

	public static bool Letter6an
	{
		get
		{
			IntPtr intPtr = IntPtr.Zero;
			try
			{
				intPtr = Marshal.AllocHGlobal(8192);
				if (uname(intPtr) == 0 && Marshal.PtrToStringAnsi(intPtr) == "Darwin")
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

	public static bool Moch2la => Environment.OSVersion.Platform == PlatformID.Unix;

	[DllImport("libc")]
	private static extern int uname(IntPtr intptr_0);

	private static string Th5b5()
	{
		using Process process = Process.GetCurrentProcess();
		return process.MainModule!.FileName;
	}
}
