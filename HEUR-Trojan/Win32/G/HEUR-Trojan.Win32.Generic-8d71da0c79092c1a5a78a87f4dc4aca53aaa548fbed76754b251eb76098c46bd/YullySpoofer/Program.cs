using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;
using KeyAuth;
using Microsoft.Win32;

namespace YullySpoofer;

public static class Program
{
	public static class AdminRelauncher
	{
		public static void RelaunchIfNotAdmin()
		{
			if (!RunningAsAdmin())
			{
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					UseShellExecute = true,
					WorkingDirectory = Environment.CurrentDirectory,
					FileName = Assembly.GetEntryAssembly()!.CodeBase,
					Verb = "runas"
				};
				try
				{
					Process.Start(startInfo);
					Environment.Exit(0);
				}
				catch
				{
					Environment.Exit(0);
				}
			}
		}

		private static bool RunningAsAdmin()
		{
			return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
		}
	}

	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	private static readonly IntPtr handle;

	private static Random random;

	public static api KeyAuthApp;

	static Program()
	{
		handle = GetConsoleWindow();
		random = new Random();
		KeyAuthApp = new api("cosmov2", "MQjirgOj8G", "103d8ec166480920f1479a989faba6bdc0c832a633c590a2dd53bac66bc255de", "1.0");
	}

	public static void DllMain(string[] args)
	{
		Debug.Initialize();
		HWIDQuery.GetHardwareID(type: true);
		try
		{
			KeyAuthApp.init();
		}
		catch
		{
			Console.Title = "Failed to connect to auth server | Yully Spoofer";
			return;
		}
		Hide();
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new LoginForm());
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	public static void Hide()
	{
		ShowWindow(handle, 0);
	}

	[STAThread]
	public static void Main(string[] args)
	{
		Console.Title = string.Empty;
		AdminRelauncher.RelaunchIfNotAdmin();
		DllMain(args);
	}

	public static string RandomString(int length)
	{
		return new string((from s in Enumerable.Repeat("ABCDEF0123456789", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	public static async void SetTaskManager(bool enable)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		if (!enable || registryKey.GetValue("DisableTaskMgr") == null)
		{
			registryKey.SetValue("DisableTaskMgr", "1");
		}
		else
		{
			registryKey.DeleteValue("DisableTaskMgr");
		}
		registryKey.Close();
	}

	public static void Show()
	{
		ShowWindow(handle, 5);
	}

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
}
