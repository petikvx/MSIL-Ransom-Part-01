using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

internal class Class18
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class19
	{
		public static readonly Class19 _003C_003E9;

		public static Func<string, char> _003C_003E9__3_0;

		static Class19()
		{
			_003CModule_003E.Class0.smethod_0();
			_003C_003E9 = new Class19();
		}

		public Class19()
		{
			_003CModule_003E.Class0.smethod_0();
			base._002Ector();
		}

		internal char method_0(string string_0)
		{
			_003CModule_003E.Class0.smethod_0();
			return string_0[random_0.Next(string_0.Length)];
		}
	}

	private static Random random_0;

	public static void smethod_0()
	{
		_003CModule_003E.Class0.smethod_0();
		Process process = new Process();
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.FileName = "cmd.exe";
		process.Start();
		process.StandardInput.WriteLine("cd C:\\Windows\\Speech");
		process.StandardInput.WriteLine("AMIDEWINx64.exe /BS " + smethod_3(15));
		process.StandardInput.WriteLine("AMIDEWINx64.exe /SS " + smethod_3(15));
		process.StandardInput.WriteLine("AMIDEWINx64.exe /SU auto");
		process.StandardInput.WriteLine("AMIDEWINx64.exe /SK " + smethod_3(15));
		process.StandardInput.WriteLine("AMIDEWINx64.exe /SF " + smethod_3(15));
		process.StandardInput.WriteLine("AMIDEWINx64.exe /CS " + smethod_3(15));
		process.StandardInput.WriteLine("AMIDEWINx64.exe /PSN " + smethod_3(15));
		process.StandardInput.WriteLine("exit");
		process.WaitForExit();
		File.Delete("C:\\Windows\\Speech\\AMIDEWINx64.exe");
		File.Delete("C:\\Windows\\Speech\\amifldrv64.sys");
	}

	public static void smethod_1()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/661208670897438731/718631145155198986/f3.exe", "C:\\Windows\\Speech\\AMIDEWINx64.exe");
		webClient.Proxy = null;
	}

	public static void smethod_2()
	{
		_003CModule_003E.Class0.smethod_0();
		WebClient webClient = new WebClient();
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/661208670897438731/718631201400684544/rj.sys", "C:\\Windows\\Speech\\amifldrv64.sys");
		webClient.Proxy = null;
	}

	public static string smethod_3(int int_0)
	{
		_003CModule_003E.Class0.smethod_0();
		return new string(Enumerable.Repeat("0123456789", int_0).Select(delegate(string string_0)
		{
			_003CModule_003E.Class0.smethod_0();
			return string_0[random_0.Next(string_0.Length)];
		}).ToArray());
	}

	public Class18()
	{
		_003CModule_003E.Class0.smethod_0();
		base._002Ector();
	}

	static Class18()
	{
		_003CModule_003E.Class0.smethod_0();
		random_0 = new Random();
	}

	static object smethod_23(char[] char_0)
	{
		return new string(char_0);
	}
}
