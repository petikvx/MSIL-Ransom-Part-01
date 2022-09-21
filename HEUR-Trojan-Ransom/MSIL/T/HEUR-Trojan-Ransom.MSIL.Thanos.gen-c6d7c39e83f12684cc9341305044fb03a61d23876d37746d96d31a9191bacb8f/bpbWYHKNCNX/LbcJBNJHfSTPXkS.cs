using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bpbWYHKNCNX;

internal sealed class LbcJBNJHfSTPXkS
{
	public enum ADxPPmczLJcWRuGb
	{
		xWDinyLUGUEIK = 1,
		YmGreNPoXYG,
		IwsWSJGSTXSeK,
		DdSgTyUpgzw,
		qZvFIeSPyiYB
	}

	public enum OsjLuXcQWOiB
	{
		WGbIrUJwUMADG,
		ZQzWdeLdffI,
		NNzKgtQAdBLh,
		nmWgDWVKGMItG
	}

	public enum yezCurjdXgo
	{
		PvAQgIaqwLi = 1,
		tjQAFqcoRde = 2,
		HIrVKBEmovd = 4,
		YZhXkHxJQHwBb = 8,
		tYGDntJMxZ = 16,
		kVvaWXmTAVKbaa = 19
	}

	public enum YdHPjckeWckr
	{
		ETgesRXCcoZDv,
		nKJgvdeeOucdP,
		MyEFpXzVZtLa,
		jTfFQiOdNyYjr,
		THIeIOkMkiQJN,
		MwLbKujbuVULPi,
		yaAIrwNohT,
		AePScFvHBRM,
		XOAxEQkdPRKEv,
		lwdrcCdZhhGRZxY,
		wWLGGMwCUrU,
		mIzdEZPMOOaXuyA
	}

	public sealed class vdOKiXoUMejiEPZ : IEnumerable
	{
		private enum sxPiUgzIKLA
		{
			APBMPHyqkxFuu = 0,
			hlyMebGBeuSxUSa = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class tArHrftGMtj
		{
			public ADxPPmczLJcWRuGb ZJEVZQyhcY;

			public OsjLuXcQWOiB MKjeOWffoRmQ;

			public YdHPjckeWckr hjjTxJMlgGgj;

			public yezCurjdXgo fwrdrWjncAM;

			public string saSlovnjuzaiL;

			public string ZYOaSAlRnh;

			public string tRYMtpsnOBFbe;

			public string IPEOcSZcYys;
		}

		private ArrayList QvxxvXFLTNDYPy = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern sxPiUgzIKLA WNetOpenEnumA(ADxPPmczLJcWRuGb dwScope, OsjLuXcQWOiB dwType, yezCurjdXgo dwUsage, tArHrftGMtj p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern sxPiUgzIKLA WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern sxPiUgzIKLA WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(tArHrftGMtj tArHrftGMtj_0, ADxPPmczLJcWRuGb adxPPmczLJcWRuGb_0, OsjLuXcQWOiB osjLuXcQWOiB_0, yezCurjdXgo yezCurjdXgo_0, YdHPjckeWckr ydHPjckeWckr_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(adxPPmczLJcWRuGb_0, osjLuXcQWOiB_0, yezCurjdXgo_0, tArHrftGMtj_0, out lphEnum) == sxPiUgzIKLA.APBMPHyqkxFuu)
			{
				sxPiUgzIKLA sxPiUgzIKLA;
				do
				{
					sxPiUgzIKLA = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (sxPiUgzIKLA)
					{
					case sxPiUgzIKLA.hlyMebGBeuSxUSa:
						continue;
					case sxPiUgzIKLA.APBMPHyqkxFuu:
						Marshal.PtrToStructure(intPtr, tArHrftGMtj_0);
						if (tArHrftGMtj_0.hjjTxJMlgGgj == ydHPjckeWckr_0)
						{
							QvxxvXFLTNDYPy.Add(tArHrftGMtj_0.ZYOaSAlRnh);
						}
						if ((tArHrftGMtj_0.fwrdrWjncAM & yezCurjdXgo.tjQAFqcoRde) == yezCurjdXgo.tjQAFqcoRde)
						{
							EnumerateServers(tArHrftGMtj_0, adxPPmczLJcWRuGb_0, osjLuXcQWOiB_0, yezCurjdXgo_0, ydHPjckeWckr_0);
						}
						continue;
					}
					break;
				}
				while (sxPiUgzIKLA != sxPiUgzIKLA.hlyMebGBeuSxUSa);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public vdOKiXoUMejiEPZ(ADxPPmczLJcWRuGb adxPPmczLJcWRuGb_0, OsjLuXcQWOiB osjLuXcQWOiB_0, yezCurjdXgo yezCurjdXgo_0, YdHPjckeWckr ydHPjckeWckr_0)
		{
			tArHrftGMtj tArHrftGMtj_ = new tArHrftGMtj();
			EnumerateServers(tArHrftGMtj_, adxPPmczLJcWRuGb_0, osjLuXcQWOiB_0, yezCurjdXgo_0, ydHPjckeWckr_0);
		}

		public IEnumerator GetEnumerator()
		{
			return QvxxvXFLTNDYPy.GetEnumerator();
		}
	}

	public static List<string> jVyeUdfTXbM;

	public static string jGqqbgWZEO;

	public static List<string> izXOpyeRBOPRz;

	public static List<string> wXkMsXzBmDDOSbkc;

	public static List<string> fgLMbVCgWHRSh;

	public List<string> PJMgPqxcBRS = new List<string>();

	public List<string> JYgVNvUFoprcC = new List<string>();

	public List<string> FDUIwmRNHvO = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static bool SPyYdXddNqMJB(string string_0)
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

	static LbcJBNJHfSTPXkS()
	{
		Strings.CreateGetStringDelegate(typeof(LbcJBNJHfSTPXkS));
		jVyeUdfTXbM = new List<string>();
		jGqqbgWZEO = getString_0(107393500);
		izXOpyeRBOPRz = new List<string>();
		wXkMsXzBmDDOSbkc = new List<string>();
		fgLMbVCgWHRSh = new List<string>();
	}
}
