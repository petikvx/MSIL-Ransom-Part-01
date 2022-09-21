using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

internal sealed class dBSQTvAQfYhhe
{
	public enum SoFzEeBJewRLP
	{
		qNxdRsRKlexv = 1,
		ORBEXTVdDjgHDCh,
		YwTudqtUJnj,
		EmcdxPFbFg,
		fSutJbOIts
	}

	public enum vdXmePlCiXkA
	{
		YxLzAwRoJgos,
		yHOrGMmYYmb,
		mgVEAFtIuBU,
		jPRSefabsUiQir
	}

	public enum oDpfUBNiXbjBgDO
	{
		mEXvcTzFfIJR = 1,
		hmhzlAqbXd = 2,
		FFZvUDvztxY = 4,
		efaVjEWbrPJoA = 8,
		JLSXRzqJReaPdh = 16,
		NbTduHqHDqRAdp = 19
	}

	public enum djTfoTtYmXACm
	{
		TvIByTBraDYg,
		QNZVCwrhGdxix,
		bVQdayAlCZKwX,
		VfceubdsZxF,
		sWLtafdUcprQjk,
		mukDCmZrWoMZHF,
		YOBBxCHbaaOU,
		oItgMBuEKrk,
		cYRsYMpYrgpZ,
		IJETwIQNmkuJ,
		MrjqrkpRJrJVwiB,
		QHhYjNHzhSag
	}

	public sealed class serMlcSCVBPW : IEnumerable
	{
		private enum GdefUxBQfW
		{
			OLdrhuDtomHVWtMo = 0,
			tfAurTINpnVte = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class oHMEvBvgDge
		{
			public SoFzEeBJewRLP SFIwROeIrbI;

			public vdXmePlCiXkA JPITLVdoWQEAg;

			public djTfoTtYmXACm wTGCWabMMNvcg;

			public oDpfUBNiXbjBgDO LuzeDyHkMs;

			public string EAjSPtCPPecWN;

			public string tcrfENbvYQfdQ;

			public string wskJZrRFNFtpZhv;

			public string tcMYVPGqdWYRe;
		}

		private ArrayList AlFRUJmCbji = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern GdefUxBQfW WNetOpenEnumA(SoFzEeBJewRLP dwScope, vdXmePlCiXkA dwType, oDpfUBNiXbjBgDO dwUsage, oHMEvBvgDge p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern GdefUxBQfW WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern GdefUxBQfW WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(oHMEvBvgDge oHMEvBvgDge_0, SoFzEeBJewRLP soFzEeBJewRLP_0, vdXmePlCiXkA vdXmePlCiXkA_0, oDpfUBNiXbjBgDO oDpfUBNiXbjBgDO_0, djTfoTtYmXACm djTfoTtYmXACm_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(soFzEeBJewRLP_0, vdXmePlCiXkA_0, oDpfUBNiXbjBgDO_0, oHMEvBvgDge_0, out lphEnum) == GdefUxBQfW.OLdrhuDtomHVWtMo)
			{
				GdefUxBQfW gdefUxBQfW;
				do
				{
					gdefUxBQfW = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (gdefUxBQfW)
					{
					case GdefUxBQfW.tfAurTINpnVte:
						continue;
					case GdefUxBQfW.OLdrhuDtomHVWtMo:
						Marshal.PtrToStructure(intPtr, oHMEvBvgDge_0);
						if (oHMEvBvgDge_0.wTGCWabMMNvcg == djTfoTtYmXACm_0)
						{
							AlFRUJmCbji.Add(oHMEvBvgDge_0.tcrfENbvYQfdQ);
						}
						if ((oHMEvBvgDge_0.LuzeDyHkMs & oDpfUBNiXbjBgDO.hmhzlAqbXd) == oDpfUBNiXbjBgDO.hmhzlAqbXd)
						{
							EnumerateServers(oHMEvBvgDge_0, soFzEeBJewRLP_0, vdXmePlCiXkA_0, oDpfUBNiXbjBgDO_0, djTfoTtYmXACm_0);
						}
						continue;
					}
					break;
				}
				while (gdefUxBQfW != GdefUxBQfW.tfAurTINpnVte);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public serMlcSCVBPW(SoFzEeBJewRLP soFzEeBJewRLP_0, vdXmePlCiXkA vdXmePlCiXkA_0, oDpfUBNiXbjBgDO oDpfUBNiXbjBgDO_0, djTfoTtYmXACm djTfoTtYmXACm_0)
		{
			oHMEvBvgDge oHMEvBvgDge_ = new oHMEvBvgDge();
			EnumerateServers(oHMEvBvgDge_, soFzEeBJewRLP_0, vdXmePlCiXkA_0, oDpfUBNiXbjBgDO_0, djTfoTtYmXACm_0);
		}

		public IEnumerator GetEnumerator()
		{
			return AlFRUJmCbji.GetEnumerator();
		}
	}

	public static List<string> SSLdGoTbiXYIEym;

	public static string dLRIBoqyBqLUnD;

	public static List<string> hOLfxSGmpnR;

	public static List<string> noXRihEWYEAn;

	public static List<string> ugfbcfRDDhhVmR;

	public List<string> cHvTkoQknQSS = new List<string>();

	public List<string> InhbEMYTEAUHx = new List<string>();

	public List<string> rLnnTOnxiJXO = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static bool pqxLdPrWdAai(string string_0)
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

	static dBSQTvAQfYhhe()
	{
		Strings.CreateGetStringDelegate(typeof(dBSQTvAQfYhhe));
		SSLdGoTbiXYIEym = new List<string>();
		dLRIBoqyBqLUnD = getString_0(107388600);
		hOLfxSGmpnR = new List<string>();
		noXRihEWYEAn = new List<string>();
		ugfbcfRDDhhVmR = new List<string>();
	}
}
