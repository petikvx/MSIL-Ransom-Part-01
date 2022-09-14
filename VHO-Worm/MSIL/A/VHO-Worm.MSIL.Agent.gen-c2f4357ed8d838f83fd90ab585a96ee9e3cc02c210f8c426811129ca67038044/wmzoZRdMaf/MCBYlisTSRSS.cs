using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wmzoZRdMaf;

internal sealed class MCBYlisTSRSS
{
	public enum AgOXWxwxScaWwF
	{
		VyEHJltgwZjayB = 1,
		ykojVxHVPyrk,
		mwTzlKerFkAg,
		vLISLHmcdx,
		UwhqMgPjiyL
	}

	public enum pbjkPSdIGJOv
	{
		ffVnZCfVabSQp,
		thOwCOfZYl,
		aXcQpEVlpze,
		EaLCKKlTyeY
	}

	public enum PMzRwQUMKQSqR
	{
		jQcNItDNTxH = 1,
		MYfqPcpkWaSee = 2,
		bsvPYEyCCkhFLXS = 4,
		VZHeOJPiRZQlalK = 8,
		HeTtCzgWXmBq = 16,
		GkuuTflZPgw = 19
	}

	public enum BBNJPuwvZbXZAv
	{
		PnkNbzXwklbvoK,
		SsfvAktLDDiXzv,
		IieOutibrvWO,
		FdjsArCtJjrkO,
		McetNUqlEKkcK,
		EvXzUZuDDHGEeoI,
		zYWIHIizjdQ,
		OaFLTYhhRn,
		icOKcpPPCOo,
		WrwOwlLWVoXiYZse,
		ACBCNkcEHB,
		xeRWkBvXnavfj
	}

	public sealed class vDDICYyPDWF : IEnumerable
	{
		private enum ydhDCCfiEuTzQ
		{
			KuISozLFYLgcp = 0,
			WjDKYMpDWGRM = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class NXBktnBnvrksmo
		{
			public AgOXWxwxScaWwF CpKaWHmvihrPEG;

			public pbjkPSdIGJOv yyvevDsKVbFJWd;

			public BBNJPuwvZbXZAv NQpUOJlzJqTLeAcR;

			public PMzRwQUMKQSqR wKqdgMNPoqs;

			public string tFSfmcghKUjP;

			public string qfRFrexjfvtXV;

			public string TeQnYyLlHEsh;

			public string drxMZsQRKMTVa;
		}

		private ArrayList kvysHoxDVbIDDF = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern ydhDCCfiEuTzQ WNetOpenEnumA(AgOXWxwxScaWwF dwScope, pbjkPSdIGJOv dwType, PMzRwQUMKQSqR dwUsage, NXBktnBnvrksmo p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern ydhDCCfiEuTzQ WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern ydhDCCfiEuTzQ WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(NXBktnBnvrksmo nxbktnBnvrksmo_0, AgOXWxwxScaWwF agOXWxwxScaWwF_0, pbjkPSdIGJOv pbjkPSdIGJOv_0, PMzRwQUMKQSqR pmzRwQUMKQSqR_0, BBNJPuwvZbXZAv bbnjpuwvZbXZAv_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(agOXWxwxScaWwF_0, pbjkPSdIGJOv_0, pmzRwQUMKQSqR_0, nxbktnBnvrksmo_0, out lphEnum) == ydhDCCfiEuTzQ.KuISozLFYLgcp)
			{
				ydhDCCfiEuTzQ ydhDCCfiEuTzQ;
				do
				{
					ydhDCCfiEuTzQ = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (ydhDCCfiEuTzQ)
					{
					case ydhDCCfiEuTzQ.WjDKYMpDWGRM:
						continue;
					case ydhDCCfiEuTzQ.KuISozLFYLgcp:
						Marshal.PtrToStructure(intPtr, nxbktnBnvrksmo_0);
						if (nxbktnBnvrksmo_0.NQpUOJlzJqTLeAcR == bbnjpuwvZbXZAv_0)
						{
							kvysHoxDVbIDDF.Add(nxbktnBnvrksmo_0.qfRFrexjfvtXV);
						}
						if ((nxbktnBnvrksmo_0.wKqdgMNPoqs & PMzRwQUMKQSqR.MYfqPcpkWaSee) == PMzRwQUMKQSqR.MYfqPcpkWaSee)
						{
							EnumerateServers(nxbktnBnvrksmo_0, agOXWxwxScaWwF_0, pbjkPSdIGJOv_0, pmzRwQUMKQSqR_0, bbnjpuwvZbXZAv_0);
						}
						continue;
					}
					break;
				}
				while (ydhDCCfiEuTzQ != ydhDCCfiEuTzQ.WjDKYMpDWGRM);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public vDDICYyPDWF(AgOXWxwxScaWwF agOXWxwxScaWwF_0, pbjkPSdIGJOv pbjkPSdIGJOv_0, PMzRwQUMKQSqR pmzRwQUMKQSqR_0, BBNJPuwvZbXZAv bbnjpuwvZbXZAv_0)
		{
			NXBktnBnvrksmo nxbktnBnvrksmo_ = new NXBktnBnvrksmo();
			EnumerateServers(nxbktnBnvrksmo_, agOXWxwxScaWwF_0, pbjkPSdIGJOv_0, pmzRwQUMKQSqR_0, bbnjpuwvZbXZAv_0);
		}

		public IEnumerator GetEnumerator()
		{
			return kvysHoxDVbIDDF.GetEnumerator();
		}
	}

	public static List<string> fydqEWUwoFN;

	public static string LqhOhWHpfORk;

	public static List<string> xVGiLShtAVgVpX;

	public static List<string> pXYQlhmKsrsWC;

	public static List<string> LqIkodHiSAg;

	public List<string> BJPErDFdEgIf = new List<string>();

	public List<string> rJsXnSylkj = new List<string>();

	public List<string> xmoMLhSGSVCgLWr = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static bool twkNavOPtUd(string string_0)
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

	static MCBYlisTSRSS()
	{
		Strings.CreateGetStringDelegate(typeof(MCBYlisTSRSS));
		fydqEWUwoFN = new List<string>();
		LqhOhWHpfORk = getString_0(107391548);
		xVGiLShtAVgVpX = new List<string>();
		pXYQlhmKsrsWC = new List<string>();
		LqIkodHiSAg = new List<string>();
	}
}
