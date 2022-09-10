using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace esImVhYKuzS;

internal sealed class stzyYltjcngHhF
{
	public enum bFTMNPdKeZit
	{
		pGWzJzzmJSPo = 1,
		KUMeCjHPMjlr,
		rrQQFQDxLBB,
		wAKOEwsent,
		pfVQygRFKcTgX
	}

	public enum dAZCszYzHaDwrLP
	{
		HmZESpJKmZVTuVs,
		QupUtalGBWV,
		xQdwUXibHlYd,
		kNAUdaGsjnMCtVsI
	}

	public enum cozFPHgUAgCiTj
	{
		ZyIsoVMmDpFA = 1,
		qcgtxmMIaSd = 2,
		bnnWpTBaTju = 4,
		DWEMsgYSvMpevB = 8,
		CTvMNGFSKrdS = 16,
		KRtpexWrPXyrwxdwb = 19
	}

	public enum JVUCbVYkUVx
	{
		ctcjeNcibVcfQ,
		UgfTjRYAMgZ,
		RQoozhEAQkBlJd,
		scJPOWjdtflofAp,
		XEepeNxPAwRNn,
		fqENfwccfXSGn,
		XVPqkBWpLVK,
		ARoUUDDUoN,
		jzWVEDyoGswqky,
		FZIwXEPLjysTz,
		BqeMkALCpqf,
		qMyUOxURqhup
	}

	public sealed class cClDNeFfmMmjxCq : IEnumerable
	{
		private enum IUIbuxvUryDXrY
		{
			NOUvZeAhZv = 0,
			ZldhnZooYjtmS = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class cYZslViWzDdYBsS
		{
			public bFTMNPdKeZit DiFJJGBHbVL;

			public dAZCszYzHaDwrLP fuSkZNWbbAJgl;

			public JVUCbVYkUVx wHBGPjDOzRr;

			public cozFPHgUAgCiTj moXzdpujVbn;

			public string BiXHtvnJnZ;

			public string RErUUYNBQzv;

			public string PKyNYTOtbmFBRiK;

			public string sXrPOKjKiIfUKkdw;
		}

		private ArrayList hxzDHgCcFBwqa = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern IUIbuxvUryDXrY WNetOpenEnumA(bFTMNPdKeZit dwScope, dAZCszYzHaDwrLP dwType, cozFPHgUAgCiTj dwUsage, cYZslViWzDdYBsS p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern IUIbuxvUryDXrY WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern IUIbuxvUryDXrY WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(cYZslViWzDdYBsS cYZslViWzDdYBsS_0, bFTMNPdKeZit bFTMNPdKeZit_0, dAZCszYzHaDwrLP dAZCszYzHaDwrLP_0, cozFPHgUAgCiTj cozFPHgUAgCiTj_0, JVUCbVYkUVx jvucbVYkUVx_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(bFTMNPdKeZit_0, dAZCszYzHaDwrLP_0, cozFPHgUAgCiTj_0, cYZslViWzDdYBsS_0, out lphEnum) == IUIbuxvUryDXrY.NOUvZeAhZv)
			{
				IUIbuxvUryDXrY iUIbuxvUryDXrY;
				do
				{
					iUIbuxvUryDXrY = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (iUIbuxvUryDXrY)
					{
					case IUIbuxvUryDXrY.ZldhnZooYjtmS:
						continue;
					case IUIbuxvUryDXrY.NOUvZeAhZv:
						Marshal.PtrToStructure(intPtr, cYZslViWzDdYBsS_0);
						if (cYZslViWzDdYBsS_0.wHBGPjDOzRr == jvucbVYkUVx_0)
						{
							hxzDHgCcFBwqa.Add(cYZslViWzDdYBsS_0.RErUUYNBQzv);
						}
						if ((cYZslViWzDdYBsS_0.moXzdpujVbn & cozFPHgUAgCiTj.qcgtxmMIaSd) == cozFPHgUAgCiTj.qcgtxmMIaSd)
						{
							EnumerateServers(cYZslViWzDdYBsS_0, bFTMNPdKeZit_0, dAZCszYzHaDwrLP_0, cozFPHgUAgCiTj_0, jvucbVYkUVx_0);
						}
						continue;
					}
					break;
				}
				while (iUIbuxvUryDXrY != IUIbuxvUryDXrY.ZldhnZooYjtmS);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public cClDNeFfmMmjxCq(bFTMNPdKeZit bFTMNPdKeZit_0, dAZCszYzHaDwrLP dAZCszYzHaDwrLP_0, cozFPHgUAgCiTj cozFPHgUAgCiTj_0, JVUCbVYkUVx jvucbVYkUVx_0)
		{
			cYZslViWzDdYBsS cYZslViWzDdYBsS_ = new cYZslViWzDdYBsS();
			EnumerateServers(cYZslViWzDdYBsS_, bFTMNPdKeZit_0, dAZCszYzHaDwrLP_0, cozFPHgUAgCiTj_0, jvucbVYkUVx_0);
		}

		public IEnumerator GetEnumerator()
		{
			return hxzDHgCcFBwqa.GetEnumerator();
		}
	}

	public static List<string> CqWiSkGrrfut;

	public static string EMPrOohLEW;

	public static List<string> EDYhqmyCjwl;

	public static List<string> CFcTEsodWDtV;

	public static List<string> VsmIreJlnGMC;

	public List<string> QURciiMhRcfZdD = new List<string>();

	public List<string> ghZhMYfceZjIXHd = new List<string>();

	public List<string> mfgsrRUEwouIZG = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static bool wTtycSFoMRgGzkgp(string string_0)
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

	static stzyYltjcngHhF()
	{
		Strings.CreateGetStringDelegate(typeof(stzyYltjcngHhF));
		CqWiSkGrrfut = new List<string>();
		EMPrOohLEW = getString_0(107389237);
		EDYhqmyCjwl = new List<string>();
		CFcTEsodWDtV = new List<string>();
		VsmIreJlnGMC = new List<string>();
	}
}
