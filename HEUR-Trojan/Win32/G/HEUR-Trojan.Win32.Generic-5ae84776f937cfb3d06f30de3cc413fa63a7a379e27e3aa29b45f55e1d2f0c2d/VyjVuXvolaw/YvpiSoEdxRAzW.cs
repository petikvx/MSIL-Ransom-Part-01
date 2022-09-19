using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

internal sealed class YvpiSoEdxRAzW
{
	public enum GWVFcRvPYepkqJ
	{
		wzevwiDaYCV = 1,
		fmkDObkOOkbJz,
		ZZCbiIoZJFUJ,
		YEhHzrKgpn,
		pRMUpNWdGxwvSD
	}

	public enum scceMdtMwtPojMP
	{
		vkGbLuPVid,
		xtNGDhxWcXBE,
		kmRmwDwqagqbmR,
		quQKrkDSzByH
	}

	public enum aRdWKWCkZOtQbD
	{
		OusyoEcpxBwBY = 1,
		YoPcTajIjpLSUk = 2,
		tnQAFFPngAATiKbJ = 4,
		vjDDRhNpQsqneqN = 8,
		eNunJvrqkmgX = 16,
		qPHNcpCyJORQ = 19
	}

	public enum EVMBSMlVoLD
	{
		PmLlWUDXueaYXp,
		owqtzGwBscyDpf,
		SgQmoXMyqeXzn,
		ZbLziAqXkBSp,
		sseIOwjutHI,
		MwWNxqBYNlZl,
		JIzGRbfVzvv,
		mJghfJARccB,
		ScQVwtHIWtwz,
		HqqmJfwCfypbDtB,
		ThYOHJbUnZOU,
		pjSzKOycDqGx
	}

	public sealed class qlpDvnfSGETmQi : IEnumerable
	{
		private enum ZJeHTgecVRh
		{
			KSCWlUZdsCzidI = 0,
			jgdiNoxLBAyROi = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class pDUByxILOhUpy
		{
			public GWVFcRvPYepkqJ ZIWuqCYVCkbKoE;

			public scceMdtMwtPojMP FPyqsjKkJWpKFY;

			public EVMBSMlVoLD gmNdqoauRkit;

			public aRdWKWCkZOtQbD pTkmJXMPRqDeH;

			public string fTZMslquDoFcW;

			public string qNrnrMztvuARmY;

			public string hvJRGEvopYaltcO;

			public string EIsfqaCvEEL;
		}

		private ArrayList YtYROOVMaAGZpMJ = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern ZJeHTgecVRh WNetOpenEnumA(GWVFcRvPYepkqJ dwScope, scceMdtMwtPojMP dwType, aRdWKWCkZOtQbD dwUsage, pDUByxILOhUpy p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern ZJeHTgecVRh WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern ZJeHTgecVRh WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(pDUByxILOhUpy pDUByxILOhUpy_0, GWVFcRvPYepkqJ gwvfcRvPYepkqJ_0, scceMdtMwtPojMP scceMdtMwtPojMP_0, aRdWKWCkZOtQbD aRdWKWCkZOtQbD_0, EVMBSMlVoLD evmbsmlVoLD_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(gwvfcRvPYepkqJ_0, scceMdtMwtPojMP_0, aRdWKWCkZOtQbD_0, pDUByxILOhUpy_0, out lphEnum) == ZJeHTgecVRh.KSCWlUZdsCzidI)
			{
				ZJeHTgecVRh zJeHTgecVRh;
				do
				{
					zJeHTgecVRh = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (zJeHTgecVRh)
					{
					case ZJeHTgecVRh.jgdiNoxLBAyROi:
						continue;
					case ZJeHTgecVRh.KSCWlUZdsCzidI:
						Marshal.PtrToStructure(intPtr, pDUByxILOhUpy_0);
						if (pDUByxILOhUpy_0.gmNdqoauRkit == evmbsmlVoLD_0)
						{
							YtYROOVMaAGZpMJ.Add(pDUByxILOhUpy_0.qNrnrMztvuARmY);
						}
						if ((pDUByxILOhUpy_0.pTkmJXMPRqDeH & aRdWKWCkZOtQbD.YoPcTajIjpLSUk) == aRdWKWCkZOtQbD.YoPcTajIjpLSUk)
						{
							EnumerateServers(pDUByxILOhUpy_0, gwvfcRvPYepkqJ_0, scceMdtMwtPojMP_0, aRdWKWCkZOtQbD_0, evmbsmlVoLD_0);
						}
						continue;
					}
					break;
				}
				while (zJeHTgecVRh != ZJeHTgecVRh.jgdiNoxLBAyROi);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public qlpDvnfSGETmQi(GWVFcRvPYepkqJ gwvfcRvPYepkqJ_0, scceMdtMwtPojMP scceMdtMwtPojMP_0, aRdWKWCkZOtQbD aRdWKWCkZOtQbD_0, EVMBSMlVoLD evmbsmlVoLD_0)
		{
			pDUByxILOhUpy pDUByxILOhUpy_ = new pDUByxILOhUpy();
			EnumerateServers(pDUByxILOhUpy_, gwvfcRvPYepkqJ_0, scceMdtMwtPojMP_0, aRdWKWCkZOtQbD_0, evmbsmlVoLD_0);
		}

		public IEnumerator GetEnumerator()
		{
			return YtYROOVMaAGZpMJ.GetEnumerator();
		}
	}

	public static List<string> VMBxGBNDBCZXLyH;

	public static string iLJRnDfGZJIsjQ;

	public static List<string> aTnIrEiGeS;

	public static List<string> sNgaNXZRxNaB;

	public static List<string> QvfGcRpQRKCp;

	public List<string> OFceHXzNvh = new List<string>();

	public List<string> abIyhspsuRCcP = new List<string>();

	public List<string> LmXbhaOtEWyrnnH = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static bool VuaFZudDlmje(string string_0)
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

	static YvpiSoEdxRAzW()
	{
		Strings.CreateGetStringDelegate(typeof(YvpiSoEdxRAzW));
		VMBxGBNDBCZXLyH = new List<string>();
		iLJRnDfGZJIsjQ = getString_0(107389177);
		aTnIrEiGeS = new List<string>();
		sNgaNXZRxNaB = new List<string>();
		QvfGcRpQRKCp = new List<string>();
	}
}
