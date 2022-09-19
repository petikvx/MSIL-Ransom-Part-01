using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace nLpTFjJRwUBp;

public class ZCqvFZREUcCx
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct JuXHQZwCKVi
	{
		public string sLiaVPGEmyLn;

		public uint PPnazhgMvur;

		public string kIEOJZwVvsUo;

		public JuXHQZwCKVi(string sharename, uint sharetype, string remark)
		{
			sLiaVPGEmyLn = sharename;
			PPnazhgMvur = sharetype;
			kIEOJZwVvsUo = remark;
		}

		public override string ToString()
		{
			return sLiaVPGEmyLn;
		}
	}

	private enum akZZFbsBrLsW : uint
	{
		TnSkmRnRsSac = 0u,
		uckreKNxsXjpevP = 2100u,
		lhqKjZoUKSGHoC = 2116u,
		ZXfxsbMYNxswK = 2118u,
		IgkKToUJbwP = 2123u
	}

	private enum vhbrURygKcYWkh : uint
	{
		pQvpNzrLVu = 0u,
		JGxRJckemor = 1u,
		dDYyEJlGhaxgLh = 2u,
		NziAjEVhArzFwg = 3u,
		HZLEFszPbys = 2147483648u
	}

	private const uint DEspOcgsxIyaL = uint.MaxValue;

	private const int TnSkmRnRsSac = 0;

	public JuXHQZwCKVi[] ITrCHCqBDrH(string rpRwrdzztJCLkb)
	{
		List<JuXHQZwCKVi> list = new List<JuXHQZwCKVi>();
		int MmhZvQNWQpnEJ = 0;
		int NRpSMRQbkMKIa = 0;
		int woPOCVtKghW = 0;
		int num = Marshal.SizeOf(typeof(JuXHQZwCKVi));
		IntPtr KpHZlfXuFCDb = IntPtr.Zero;
		StringBuilder ezGFrYldDIlmiocU = new StringBuilder(rpRwrdzztJCLkb);
		int num2 = NetShareEnum(ezGFrYldDIlmiocU, 1, ref KpHZlfXuFCDb, uint.MaxValue, ref MmhZvQNWQpnEJ, ref NRpSMRQbkMKIa, ref woPOCVtKghW);
		if (num2 == 0)
		{
			IntPtr ptr = KpHZlfXuFCDb;
			for (int i = 0; i < MmhZvQNWQpnEJ; i++)
			{
				JuXHQZwCKVi item = (JuXHQZwCKVi)Marshal.PtrToStructure(ptr, typeof(JuXHQZwCKVi));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(KpHZlfXuFCDb);
			return list.ToArray();
		}
		list.Add(new JuXHQZwCKVi("ERROR=" + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr SjJUqGLXJl);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder ezGFrYldDIlmiocU, int FOEIorRyqyfs, ref IntPtr KpHZlfXuFCDb, uint cQGUuYeDGZv, ref int MmhZvQNWQpnEJ, ref int NRpSMRQbkMKIa, ref int woPOCVtKghW);

	public static void sKzSqBeQdkhsQ()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			JuXHQZwCKVi[] array = new ZCqvFZREUcCx().ITrCHCqBDrH(Environment.MachineName);
			JuXHQZwCKVi[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				JuXHQZwCKVi juXHQZwCKVi = array2[i];
				if (juXHQZwCKVi.ToString().Contains("ADMIN$") || juXHQZwCKVi.ToString().Contains("User") || juXHQZwCKVi.ToString().Contains("IPC$") || logicalDrives.Contains(juXHQZwCKVi.ToString().Replace("$", ":\\")))
				{
					continue;
				}
				RLgUMHIwwGSuCLo.mVucaeNrRtoSGRM.Add("\\\\" + Environment.MachineName + "\\" + juXHQZwCKVi);
				if (RLgUMHIwwGSuCLo.nSLCvWTPGScIDK)
				{
					try
					{
						Console.WriteLine("Share Added: {0}", "\\\\" + Environment.MachineName + "\\" + juXHQZwCKVi);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (RLgUMHIwwGSuCLo.QWMTAZEOVrAU)
			{
				try
				{
					File.AppendAllText(RLgUMHIwwGSuCLo.kOKakAljNFiEE, "Error while enumerating shares: " + ex2.Message);
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
