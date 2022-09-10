using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HSFBHZCtMXjPES;

internal sealed class vUKwidQPcZK
{
	public enum ccPirCGsjtVXZp
	{
		YMbEACMoqEsrJ = 1,
		TpzRPnNZFLd,
		XUZeBqAdSGClA,
		hBxCgjwjPAnm,
		bMtwSZfcsHSKwUpG
	}

	public enum awGrdKNwNanbmSH
	{
		FBBAoZmlzRSPx,
		ckNaOLFubodAA,
		tfEGdRTVKqYu,
		spleQvdUJFefThcnq
	}

	public enum ashGsiOgDjRyIh
	{
		ZigipgpJSlIZm = 1,
		lUzqxNzQJgjVTOlT = 2,
		phqGIyXLvfi = 4,
		KZixtvtWxCiMPEO = 8,
		XwOpLFpGVfSkqp = 16,
		GwleDOZbJfwqnOc = 19
	}

	public enum yQgXtcLfnmXXOsz
	{
		BgDdXSwUosrupU,
		XIyrMOMovHIC,
		AwXyVmXXdaI,
		BFJskePIbY,
		PWCcAYbVDQU,
		KaTFwdHnoeLF,
		SAyAYQFhUUH,
		gkTFGEtSOGWaNO,
		uoeCbBhSNXIA,
		xpVXWMhIpxksa,
		FshYtJgjtJptS,
		UyDhanfztSF
	}

	public sealed class TrJvYsiAqEyJ : IEnumerable
	{
		private enum vMvzhbLPcKjRN
		{
			qbPMTYESST = 0,
			uJeOzJOGzM = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class KjCMTHeHtBcoBlP
		{
			public ccPirCGsjtVXZp MkXkdyJtAbWlSRZ = (ccPirCGsjtVXZp)0;

			public awGrdKNwNanbmSH TEeSVTIhRJpP = awGrdKNwNanbmSH.FBBAoZmlzRSPx;

			public yQgXtcLfnmXXOsz SbwlLZDomMyte = yQgXtcLfnmXXOsz.BgDdXSwUosrupU;

			public ashGsiOgDjRyIh eXxlViVapROAegq = (ashGsiOgDjRyIh)0;

			public string NpfmBAAYAVMpcaA = null;

			public string jsXCHBcckUH = null;

			public string eKCGGSDphVa = null;

			public string FMZrZBPiOsPRQ = null;
		}

		private ArrayList ixzdbVmqTBveNA = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern vMvzhbLPcKjRN WNetOpenEnumA(ccPirCGsjtVXZp dwScope, awGrdKNwNanbmSH dwType, ashGsiOgDjRyIh dwUsage, KjCMTHeHtBcoBlP p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern vMvzhbLPcKjRN WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern vMvzhbLPcKjRN WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(KjCMTHeHtBcoBlP kjCMTHeHtBcoBlP_0, ccPirCGsjtVXZp ccPirCGsjtVXZp_0, awGrdKNwNanbmSH awGrdKNwNanbmSH_0, ashGsiOgDjRyIh ashGsiOgDjRyIh_0, yQgXtcLfnmXXOsz yQgXtcLfnmXXOsz_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(ccPirCGsjtVXZp_0, awGrdKNwNanbmSH_0, ashGsiOgDjRyIh_0, kjCMTHeHtBcoBlP_0, out lphEnum) == vMvzhbLPcKjRN.qbPMTYESST)
			{
				vMvzhbLPcKjRN vMvzhbLPcKjRN;
				do
				{
					vMvzhbLPcKjRN = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (vMvzhbLPcKjRN)
					{
					case vMvzhbLPcKjRN.uJeOzJOGzM:
						continue;
					case vMvzhbLPcKjRN.qbPMTYESST:
						Marshal.PtrToStructure(intPtr, kjCMTHeHtBcoBlP_0);
						if (kjCMTHeHtBcoBlP_0.SbwlLZDomMyte == yQgXtcLfnmXXOsz_0)
						{
							ixzdbVmqTBveNA.Add(kjCMTHeHtBcoBlP_0.jsXCHBcckUH);
						}
						if ((kjCMTHeHtBcoBlP_0.eXxlViVapROAegq & ashGsiOgDjRyIh.lUzqxNzQJgjVTOlT) == ashGsiOgDjRyIh.lUzqxNzQJgjVTOlT)
						{
							EnumerateServers(kjCMTHeHtBcoBlP_0, ccPirCGsjtVXZp_0, awGrdKNwNanbmSH_0, ashGsiOgDjRyIh_0, yQgXtcLfnmXXOsz_0);
						}
						continue;
					}
					break;
				}
				while (vMvzhbLPcKjRN != vMvzhbLPcKjRN.uJeOzJOGzM);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public TrJvYsiAqEyJ(ccPirCGsjtVXZp ccPirCGsjtVXZp_0, awGrdKNwNanbmSH awGrdKNwNanbmSH_0, ashGsiOgDjRyIh ashGsiOgDjRyIh_0, yQgXtcLfnmXXOsz yQgXtcLfnmXXOsz_0)
		{
			KjCMTHeHtBcoBlP kjCMTHeHtBcoBlP_ = new KjCMTHeHtBcoBlP();
			EnumerateServers(kjCMTHeHtBcoBlP_, ccPirCGsjtVXZp_0, awGrdKNwNanbmSH_0, ashGsiOgDjRyIh_0, yQgXtcLfnmXXOsz_0);
		}

		public IEnumerator GetEnumerator()
		{
			return ixzdbVmqTBveNA.GetEnumerator();
		}
	}

	public static List<string> ipMdvISKIjM;

	public static string SVfPczxNFhAD;

	public static List<string> ddfPOEpDllkjNuU;

	public static List<string> sVmYMAcKnATJJRS;

	public static List<string> vThMjyIAdNyeLk;

	public List<string> LvPbtjkTqBNOFW = new List<string>();

	public List<string> mCYVHxeRoWJHrE = new List<string>();

	public List<string> JDRaABJaXo = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static bool SVqnxxkNCtz(string string_0)
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

	static vUKwidQPcZK()
	{
		Strings.CreateGetStringDelegate(typeof(vUKwidQPcZK));
		ipMdvISKIjM = new List<string>();
		SVfPczxNFhAD = getString_0(107386372);
		ddfPOEpDllkjNuU = new List<string>();
		sVmYMAcKnATJJRS = new List<string>();
		vThMjyIAdNyeLk = new List<string>();
	}
}
