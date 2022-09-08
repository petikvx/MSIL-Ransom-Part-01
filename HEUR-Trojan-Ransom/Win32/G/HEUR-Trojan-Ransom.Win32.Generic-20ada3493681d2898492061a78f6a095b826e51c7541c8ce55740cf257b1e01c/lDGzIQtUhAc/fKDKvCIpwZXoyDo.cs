using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace lDGzIQtUhAc;

public class fKDKvCIpwZXoyDo
{
	public void ZkTiGJrClka(string CGhWxbuefUN, HashSet<string> yazKJIuyHWDEj, out Dictionary<ulong, FQjZRyaCEZhgul> rTDGQJWUjXH, out Dictionary<ulong, FQjZRyaCEZhgul> KbvKJagPUyFyZ)
	{
		KbvKJagPUyFyZ = new Dictionary<ulong, FQjZRyaCEZhgul>();
		rTDGQJWUjXH = new Dictionary<ulong, FQjZRyaCEZhgul>();
		IntPtr ihSBGIfplybck = IntPtr.Zero;
		IntPtr IWOeThDPIUPcHM = IntPtr.Zero;
		try
		{
			svIcaiaPrGcT(CGhWxbuefUN, KbvKJagPUyFyZ);
			TZFQqsYSwisWOi(CGhWxbuefUN, out IWOeThDPIUPcHM);
			UYKgeHFyyeDKu(IWOeThDPIUPcHM);
			NwxdoYnIqRzMfSH(ref ihSBGIfplybck, IWOeThDPIUPcHM);
			UlbEtmdjmWFMLy(ihSBGIfplybck, ref rTDGQJWUjXH, yazKJIuyHWDEj, KbvKJagPUyFyZ, IWOeThDPIUPcHM);
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
			if (IWOeThDPIUPcHM.ToInt32() != -1)
			{
				lPxTocHkMXEJ.CloseHandle(IWOeThDPIUPcHM);
			}
			if (ihSBGIfplybck != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(ihSBGIfplybck);
			}
		}
	}

	private void svIcaiaPrGcT(string PgDHQuPKmYMV, Dictionary<ulong, FQjZRyaCEZhgul> wtRAHxZKerYDnoG)
	{
		string text = "\\\\.\\" + PgDHQuPKmYMV;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = lPxTocHkMXEJ.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			lPxTocHkMXEJ.IuzzDrMiMGNEdWSG IEgkWwWbVZIAp = default(lPxTocHkMXEJ.IuzzDrMiMGNEdWSG);
			if (lPxTocHkMXEJ.GetFileInformationByHandle(intPtr, out IEgkWwWbVZIAp))
			{
				ulong num = IEgkWwWbVZIAp.yCCAzsiGYUk;
				ulong key = (num << 32) | IEgkWwWbVZIAp.dwInPgGGDHH;
				FQjZRyaCEZhgul value = new FQjZRyaCEZhgul(text, 0uL);
				wtRAHxZKerYDnoG.Add(key, value);
			}
			lPxTocHkMXEJ.CloseHandle(intPtr);
		}
	}

	private void TZFQqsYSwisWOi(string vzaBDYDymQh, out IntPtr IWOeThDPIUPcHM)
	{
		string dGhOyGZhOHgHe = "\\\\.\\" + vzaBDYDymQh;
		IWOeThDPIUPcHM = lPxTocHkMXEJ.CreateFile(dGhOyGZhOHgHe, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void UlbEtmdjmWFMLy(IntPtr CWeIgyDmYQ, ref Dictionary<ulong, FQjZRyaCEZhgul> jnwTbUYeHtm, HashSet<string> cwmfYqpQpgxH, Dictionary<ulong, FQjZRyaCEZhgul> bHvEBSbuFaRX, IntPtr XsSLCzXSnqqN)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		lPxTocHkMXEJ.ZeroMemory(intPtr, 65544);
		uint sTdponHqpeTtoYm = 0u;
		while (lPxTocHkMXEJ.DeviceIoControl_1(XsSLCzXSnqqN, 590003u, CWeIgyDmYQ, sizeof(lPxTocHkMXEJ.CwHEXXYqDEFhu), intPtr, 65544, out sTdponHqpeTtoYm, IntPtr.Zero))
		{
			IntPtr p = new IntPtr(intPtr.ToInt32() + 8);
			while (sTdponHqpeTtoYm > 60)
			{
				lPxTocHkMXEJ.PTCLRIOwzzeki pTCLRIOwzzeki = new lPxTocHkMXEJ.PTCLRIOwzzeki(p);
				if (0 != (pTCLRIOwzzeki.VgIEHeNizxNv & 0x10))
				{
					if (bHvEBSbuFaRX.ContainsKey(pTCLRIOwzzeki.OCzfQkhzAQW))
					{
						throw new Exception($"Duplicate FRN: {pTCLRIOwzzeki.OCzfQkhzAQW} for {pTCLRIOwzzeki.oGFFSqKhoMj}");
					}
					bHvEBSbuFaRX.Add(pTCLRIOwzzeki.OCzfQkhzAQW, new FQjZRyaCEZhgul(pTCLRIOwzzeki.oGFFSqKhoMj, pTCLRIOwzzeki.UoSgXcYFBFs));
				}
				else
				{
					bool flag = true;
					if (cwmfYqpQpgxH != null)
					{
						string extension = Path.GetExtension(pTCLRIOwzzeki.oGFFSqKhoMj);
						flag = cwmfYqpQpgxH.Contains(extension);
					}
					if (flag)
					{
						if (!jnwTbUYeHtm.ContainsKey(pTCLRIOwzzeki.OCzfQkhzAQW))
						{
							jnwTbUYeHtm.Add(pTCLRIOwzzeki.OCzfQkhzAQW, new FQjZRyaCEZhgul(pTCLRIOwzzeki.oGFFSqKhoMj, pTCLRIOwzzeki.UoSgXcYFBFs));
						}
						else
						{
							FQjZRyaCEZhgul fQjZRyaCEZhgul = jnwTbUYeHtm[pTCLRIOwzzeki.OCzfQkhzAQW];
							if (0 != string.Compare(pTCLRIOwzzeki.oGFFSqKhoMj, fQjZRyaCEZhgul.CJyLygOmEsxy, ignoreCase: true))
							{
								Console.WriteLine("Attempt to add duplicate file reference number: {0} for file {1}, file from index {2}", pTCLRIOwzzeki.OCzfQkhzAQW, pTCLRIOwzzeki.oGFFSqKhoMj, fQjZRyaCEZhgul.CJyLygOmEsxy);
								throw new Exception($"Duplicate FRN: {pTCLRIOwzzeki.OCzfQkhzAQW} for {pTCLRIOwzzeki.oGFFSqKhoMj}");
							}
						}
					}
				}
				p = new IntPtr(p.ToInt32() + pTCLRIOwzzeki.npFuHbZgbobLNmtr);
				sTdponHqpeTtoYm -= pTCLRIOwzzeki.npFuHbZgbobLNmtr;
			}
			Marshal.WriteInt64(CWeIgyDmYQ, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void UYKgeHFyyeDKu(IntPtr XoIAnxbVIoMBaxGy)
	{
		lPxTocHkMXEJ.MHGsrIhBcUNEtxP structure = default(lPxTocHkMXEJ.MHGsrIhBcUNEtxP);
		structure.yVIiUGbgdzMfLKa = 8388608uL;
		structure.FcthxoxNvGd = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		lPxTocHkMXEJ.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		lPxTocHkMXEJ.DeviceIoControl_1(XoIAnxbVIoMBaxGy, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void NwxdoYnIqRzMfSH(ref IntPtr ihSBGIfplybck, IntPtr UvfHStCVrGa)
	{
		uint YLmsmXQwaVcp = 0u;
		lPxTocHkMXEJ.AgReCDYgLAq GzqCQcbfIw = default(lPxTocHkMXEJ.AgReCDYgLAq);
		if (lPxTocHkMXEJ.DeviceIoControl(UvfHStCVrGa, 590068u, IntPtr.Zero, 0, out GzqCQcbfIw, sizeof(lPxTocHkMXEJ.AgReCDYgLAq), out YLmsmXQwaVcp, IntPtr.Zero))
		{
			lPxTocHkMXEJ.CwHEXXYqDEFhu structure = default(lPxTocHkMXEJ.CwHEXXYqDEFhu);
			structure.zMYLvRBfgyEuCZ = 0uL;
			structure.cgaFxQiJnSCX = 0L;
			structure.zMUiLjxMydvt = GzqCQcbfIw.sIVfItPLTUm;
			int num = Marshal.SizeOf(structure);
			ihSBGIfplybck = Marshal.AllocHGlobal(num);
			lPxTocHkMXEJ.ZeroMemory(ihSBGIfplybck, num);
			Marshal.StructureToPtr(structure, ihSBGIfplybck, fDeleteOld: true);
		}
	}
}
