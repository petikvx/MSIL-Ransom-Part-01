using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;

namespace YullySpoofer;

internal class AntiDLL
{
	public static bool IfExecute;

	public static int total;

	public static int dlls;

	public static Timer _timer;

	public static void Check(bool Execute)
	{
		IfExecute = Execute;
		_timer = new Timer(TimerCallback, null, 0, 200);
	}

	[DllImport("psapi.dll")]
	public static extern bool EnumProcessModulesEx(IntPtr hProcess, [In][Out] IntPtr[] lphModule, int cb, out int lpcbNeeded, uint dwFilterFlag);

	public static void Load()
	{
		EnumProcessModulesEx(Process.GetCurrentProcess().Handle, new IntPtr[1] { IntPtr.Zero }, 0, out total, 3u);
	}

	public static string ReturnHWID()
	{
		return WindowsIdentity.GetCurrent().User!.Value;
	}

	public static string ReturnIP()
	{
		return new WebClient().DownloadString("https://api64.ipify.org/");
	}

	public static string ReturnPC()
	{
		return Environment.UserName;
	}

	public static void Start()
	{
		Process.GetCurrentProcess().Kill();
	}

	public static void TimerCallback(object o)
	{
		Debug.ResumeProcess(Process.GetCurrentProcess().Id);
		if (IfExecute)
		{
			EnumProcessModulesEx(Process.GetCurrentProcess().Handle, new IntPtr[1] { IntPtr.Zero }, 0, out dlls, 3u);
			if (dlls != total)
			{
				Console.Clear();
				Console.WriteLine("YOU CANT REVERSE YOU SKID!!!!!!!!!");
				Start();
			}
		}
	}
}
