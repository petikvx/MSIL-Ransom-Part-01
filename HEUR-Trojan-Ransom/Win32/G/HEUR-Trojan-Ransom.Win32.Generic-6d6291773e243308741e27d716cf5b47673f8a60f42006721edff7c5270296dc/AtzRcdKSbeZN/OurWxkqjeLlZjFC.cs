using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace AtzRcdKSbeZN;

public class OurWxkqjeLlZjFC
{
	public void SQSBpaoscYlWesc(string bclzhruClRaxn, HashSet<string> lAWICVYCtRv, out Dictionary<ulong, VWKeLXnnElFS> LKYxiExDTx, out Dictionary<ulong, VWKeLXnnElFS> vBhjCWlLlUkC)
	{
		vBhjCWlLlUkC = new Dictionary<ulong, VWKeLXnnElFS>();
		LKYxiExDTx = new Dictionary<ulong, VWKeLXnnElFS>();
		IntPtr kVhDKHAFQqVT = IntPtr.Zero;
		IntPtr jhIERikWOuCJq = IntPtr.Zero;
		try
		{
			QkNwZfbuSN(bclzhruClRaxn, vBhjCWlLlUkC);
			FwtKhQpsdID(bclzhruClRaxn, out jhIERikWOuCJq);
			oxWalJCTuiSV(jhIERikWOuCJq);
			UtdbecPCIZEj(ref kVhDKHAFQqVT, jhIERikWOuCJq);
			UdtFfrPyVLJZfz(kVhDKHAFQqVT, ref LKYxiExDTx, lAWICVYCtRv, vBhjCWlLlUkC, jhIERikWOuCJq);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException("Error in EnumerateVolume()", ex);
		}
		finally
		{
			if (jhIERikWOuCJq.ToInt32() != -1)
			{
				ejjDHQVBljBK.CloseHandle(jhIERikWOuCJq);
			}
			if (kVhDKHAFQqVT != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(kVhDKHAFQqVT);
			}
		}
	}

	private void QkNwZfbuSN(string wXsGUjgjVrybJAbRe, Dictionary<ulong, VWKeLXnnElFS> NCbIFMEygEEh)
	{
		string text = "\\\\.\\" + wXsGUjgjVrybJAbRe;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = ejjDHQVBljBK.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			ejjDHQVBljBK.vNGputBbgLPFU tXNyLxDChNgQ = default(ejjDHQVBljBK.vNGputBbgLPFU);
			if (ejjDHQVBljBK.GetFileInformationByHandle(intPtr, out tXNyLxDChNgQ))
			{
				ulong num = tXNyLxDChNgQ.hXIkacAeaImopkFr;
				ulong key = (num << 32) | tXNyLxDChNgQ.bFPOYqHeYXYJ;
				VWKeLXnnElFS value = new VWKeLXnnElFS(text, 0uL);
				NCbIFMEygEEh.Add(key, value);
			}
			ejjDHQVBljBK.CloseHandle(intPtr);
		}
	}

	private void FwtKhQpsdID(string kgQVobMfRubF, out IntPtr jhIERikWOuCJq)
	{
		string nRHtIlLHOMxLn = "\\\\.\\" + kgQVobMfRubF;
		jhIERikWOuCJq = ejjDHQVBljBK.CreateFile(nRHtIlLHOMxLn, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void UdtFfrPyVLJZfz(IntPtr vYEONOiSJKHX, ref Dictionary<ulong, VWKeLXnnElFS> KrbGylNNyeIk, HashSet<string> bEhcPZZYpvijzCN, Dictionary<ulong, VWKeLXnnElFS> SdgLgqcKnjUF, IntPtr LpImWPmIdvRGnzG)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		ejjDHQVBljBK.ZeroMemory(intPtr, 65544);
		uint EBOfdODCJuTHrBQu = 0u;
		while (ejjDHQVBljBK.DeviceIoControl_1(LpImWPmIdvRGnzG, 590003u, vYEONOiSJKHX, sizeof(ejjDHQVBljBK.WtDFfGXNoQvgAQp), intPtr, 65544, out EBOfdODCJuTHrBQu, IntPtr.Zero))
		{
			IntPtr p = new IntPtr(intPtr.ToInt32() + 8);
			while (EBOfdODCJuTHrBQu > 60)
			{
				ejjDHQVBljBK.kMOyTtyccLuRjMc kMOyTtyccLuRjMc = new ejjDHQVBljBK.kMOyTtyccLuRjMc(p);
				if ((kMOyTtyccLuRjMc.sVfFLLaUXvGt & 0x10u) != 0)
				{
					if (SdgLgqcKnjUF.ContainsKey(kMOyTtyccLuRjMc.sJbnPwtZvtog))
					{
						throw new Exception($"Duplicate FRN: {kMOyTtyccLuRjMc.sJbnPwtZvtog} for {kMOyTtyccLuRjMc.VwakZWfOhV}");
					}
					SdgLgqcKnjUF.Add(kMOyTtyccLuRjMc.sJbnPwtZvtog, new VWKeLXnnElFS(kMOyTtyccLuRjMc.VwakZWfOhV, kMOyTtyccLuRjMc.qqxtkQWcSunmizY));
				}
				else
				{
					bool flag = true;
					if (bEhcPZZYpvijzCN != null)
					{
						string extension = Path.GetExtension(kMOyTtyccLuRjMc.VwakZWfOhV);
						flag = bEhcPZZYpvijzCN.Contains(extension);
					}
					if (flag)
					{
						if (!KrbGylNNyeIk.ContainsKey(kMOyTtyccLuRjMc.sJbnPwtZvtog))
						{
							KrbGylNNyeIk.Add(kMOyTtyccLuRjMc.sJbnPwtZvtog, new VWKeLXnnElFS(kMOyTtyccLuRjMc.VwakZWfOhV, kMOyTtyccLuRjMc.qqxtkQWcSunmizY));
						}
						else
						{
							VWKeLXnnElFS vWKeLXnnElFS = KrbGylNNyeIk[kMOyTtyccLuRjMc.sJbnPwtZvtog];
							if (string.Compare(kMOyTtyccLuRjMc.VwakZWfOhV, vWKeLXnnElFS.rvZOpHZlhDnGv, ignoreCase: true) != 0)
							{
								Console.WriteLine("Attempt to add duplicate file reference number: {0} for file {1}, file from index {2}", kMOyTtyccLuRjMc.sJbnPwtZvtog, kMOyTtyccLuRjMc.VwakZWfOhV, vWKeLXnnElFS.rvZOpHZlhDnGv);
								throw new Exception($"Duplicate FRN: {kMOyTtyccLuRjMc.sJbnPwtZvtog} for {kMOyTtyccLuRjMc.VwakZWfOhV}");
							}
						}
					}
				}
				p = new IntPtr(p.ToInt32() + kMOyTtyccLuRjMc.SwKGHxuHNaB);
				EBOfdODCJuTHrBQu -= kMOyTtyccLuRjMc.SwKGHxuHNaB;
			}
			Marshal.WriteInt64(vYEONOiSJKHX, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void oxWalJCTuiSV(IntPtr CiaPknCUWYwln)
	{
		ejjDHQVBljBK.ydVHVteKNsEr structure = default(ejjDHQVBljBK.ydVHVteKNsEr);
		structure.rscnuxdDYPP = 8388608uL;
		structure.RxVXarpyAZqeBqe = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		ejjDHQVBljBK.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		ejjDHQVBljBK.DeviceIoControl_1(CiaPknCUWYwln, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void UtdbecPCIZEj(ref IntPtr kVhDKHAFQqVT, IntPtr STbLTqEGptjX)
	{
		uint WRwxtPRjliK = 0u;
		ejjDHQVBljBK.JJIlQqSChVrq tWKJcPKvRtKRE = default(ejjDHQVBljBK.JJIlQqSChVrq);
		if (ejjDHQVBljBK.DeviceIoControl(STbLTqEGptjX, 590068u, IntPtr.Zero, 0, out tWKJcPKvRtKRE, sizeof(ejjDHQVBljBK.JJIlQqSChVrq), out WRwxtPRjliK, IntPtr.Zero))
		{
			ejjDHQVBljBK.WtDFfGXNoQvgAQp structure = default(ejjDHQVBljBK.WtDFfGXNoQvgAQp);
			structure.fzjhQLuUDDnZH = 0uL;
			structure.tzNhdirWqRvi = 0L;
			structure.hUrLfkhcxFARbb = tWKJcPKvRtKRE.RlDctbAmpYIi;
			int num = Marshal.SizeOf(structure);
			kVhDKHAFQqVT = Marshal.AllocHGlobal(num);
			ejjDHQVBljBK.ZeroMemory(kVhDKHAFQqVT, num);
			Marshal.StructureToPtr(structure, kVhDKHAFQqVT, fDeleteOld: true);
		}
	}
}
