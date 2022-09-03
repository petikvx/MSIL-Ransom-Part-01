using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace dfbDZtGQEYGzK;

public class zLFoIDTnIZbnFn
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct mBJwcMRbNgdSqVD
	{
		public string RKssNdvuzYnwVdv;

		public uint KWGdXwjMcydW;

		public string zyBlblhKAyCzXW;

		public mBJwcMRbNgdSqVD(string sharename, uint sharetype, string remark)
		{
			RKssNdvuzYnwVdv = sharename;
			KWGdXwjMcydW = sharetype;
			zyBlblhKAyCzXW = remark;
		}

		public override string ToString()
		{
			return RKssNdvuzYnwVdv;
		}
	}

	private enum FZokPtsmCTQY : uint
	{
		WhXOIKHVVKxFjm = 0u,
		jRJnCDDUPPaZJ = 2100u,
		eLiwiUVMFFKj = 2116u,
		LYzvDMJODL = 2118u,
		DayrLLvBlUK = 2123u
	}

	private enum IOPVWCimlNVNh : uint
	{
		qBytbruwyPy = 0u,
		xAzdHMwgQempq = 1u,
		QiJgnpEhRa = 2u,
		JoeBygsedjYRwp = 3u,
		UJxcpoWQOmUNfqJ = 2147483648u
	}

	private const uint jflAltWmLVCfb = uint.MaxValue;

	private const int WhXOIKHVVKxFjm = 0;

	public mBJwcMRbNgdSqVD[] ShPTybhlqDeHsQ(string MpMnyvzxYBHEWgx)
	{
		List<mBJwcMRbNgdSqVD> list = new List<mBJwcMRbNgdSqVD>();
		int VMQuszhTUOY = 0;
		int WnbyqfSrjI = 0;
		int ihJaxMHlNIkO = 0;
		int num = Marshal.SizeOf(typeof(mBJwcMRbNgdSqVD));
		IntPtr wLZglECIeYme = IntPtr.Zero;
		StringBuilder xenghygSuTpj = new StringBuilder(MpMnyvzxYBHEWgx);
		int num2 = NetShareEnum(xenghygSuTpj, 1, ref wLZglECIeYme, uint.MaxValue, ref VMQuszhTUOY, ref WnbyqfSrjI, ref ihJaxMHlNIkO);
		if (num2 == 0)
		{
			IntPtr ptr = wLZglECIeYme;
			for (int i = 0; i < VMQuszhTUOY; i++)
			{
				mBJwcMRbNgdSqVD item = (mBJwcMRbNgdSqVD)Marshal.PtrToStructure(ptr, typeof(mBJwcMRbNgdSqVD));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(wLZglECIeYme);
			return list.ToArray();
		}
		list.Add(new mBJwcMRbNgdSqVD("ERROR=" + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr kIeUIcoZsKcCzT);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder xenghygSuTpj, int hLofFNxyisYBB, ref IntPtr wLZglECIeYme, uint yHBUfNXGhQYxKe, ref int VMQuszhTUOY, ref int WnbyqfSrjI, ref int ihJaxMHlNIkO);

	public static void ZRlBzJiEkDTWk()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			mBJwcMRbNgdSqVD[] array = new zLFoIDTnIZbnFn().ShPTybhlqDeHsQ(Environment.MachineName);
			mBJwcMRbNgdSqVD[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				mBJwcMRbNgdSqVD mBJwcMRbNgdSqVD = array2[i];
				if (mBJwcMRbNgdSqVD.ToString().Contains("ADMIN$") || mBJwcMRbNgdSqVD.ToString().Contains("print$") || mBJwcMRbNgdSqVD.ToString().Contains("User") || mBJwcMRbNgdSqVD.ToString().Contains("IPC$") || logicalDrives.Contains(mBJwcMRbNgdSqVD.ToString().Replace("$", ":\\")))
				{
					continue;
				}
				if (!sWSXzQkxHH.ykYiTFCYjtGh.Contains("\\\\" + Environment.MachineName + "\\" + mBJwcMRbNgdSqVD))
				{
					sWSXzQkxHH.ykYiTFCYjtGh.Add("\\\\" + Environment.MachineName + "\\" + mBJwcMRbNgdSqVD);
				}
				if (sWSXzQkxHH.hzzRDIjGDyq)
				{
					try
					{
						Console.WriteLine("Share Added: {0}", "\\\\" + Environment.MachineName + "\\" + mBJwcMRbNgdSqVD);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (sWSXzQkxHH.bZJnUpHOpIgqq)
			{
				try
				{
					File.AppendAllText(sWSXzQkxHH.SlCyjezmzcjRF, "Error while enumerating shares: " + ex2.Message);
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
