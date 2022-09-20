using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace aHIHEJJDItp;

public class tvZewxrGkJhFBiv
{
	public void fOEHuFJGbysHO(string lLPyoTpEXFU, HashSet<string> PjxapsZaGBwwyLak, out Dictionary<ulong, hQgegBUtUPxP> zvxvmBycnaWJx, out Dictionary<ulong, hQgegBUtUPxP> LABfyAqPnN)
	{
		LABfyAqPnN = new Dictionary<ulong, hQgegBUtUPxP>();
		zvxvmBycnaWJx = new Dictionary<ulong, hQgegBUtUPxP>();
		IntPtr yXLJAiHsYznfpqSQi = IntPtr.Zero;
		IntPtr QoIfJlBujLaEz = IntPtr.Zero;
		try
		{
			vSuOkNMIiJpXT(lLPyoTpEXFU, LABfyAqPnN);
			RZsaaQsgeZFHoDvQrf(lLPyoTpEXFU, out QoIfJlBujLaEz);
			ClSJVZHYQiVQB(QoIfJlBujLaEz);
			kQymiRdluzb(ref yXLJAiHsYznfpqSQi, QoIfJlBujLaEz);
			xOUmersYsSXw(yXLJAiHsYznfpqSQi, ref zvxvmBycnaWJx, PjxapsZaGBwwyLak, LABfyAqPnN, QoIfJlBujLaEz);
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
			if (QoIfJlBujLaEz.ToInt32() != -1)
			{
				eEtYshyFmcfp.CloseHandle(QoIfJlBujLaEz);
			}
			if (yXLJAiHsYznfpqSQi != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(yXLJAiHsYznfpqSQi);
			}
		}
	}

	private void vSuOkNMIiJpXT(string LlcSrjSUqz, Dictionary<ulong, hQgegBUtUPxP> wkoJklgVaIpHa)
	{
		string text = "\\\\.\\" + LlcSrjSUqz;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = eEtYshyFmcfp.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			eEtYshyFmcfp.slJuhHvKEYjviQM PjPkYzpWPHZi = default(eEtYshyFmcfp.slJuhHvKEYjviQM);
			if (eEtYshyFmcfp.GetFileInformationByHandle(intPtr, out PjPkYzpWPHZi))
			{
				ulong num = PjPkYzpWPHZi.iIpPrIyfENBg;
				ulong key = (num << 32) | PjPkYzpWPHZi.YIAetXVgTM;
				hQgegBUtUPxP value = new hQgegBUtUPxP(text, 0uL);
				wkoJklgVaIpHa.Add(key, value);
			}
			eEtYshyFmcfp.CloseHandle(intPtr);
		}
	}

	private void RZsaaQsgeZFHoDvQrf(string XFMBjzZLOZrmb, out IntPtr QoIfJlBujLaEz)
	{
		string gBkEFnyQKeGHWw = "\\\\.\\" + XFMBjzZLOZrmb;
		QoIfJlBujLaEz = eEtYshyFmcfp.CreateFile(gBkEFnyQKeGHWw, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void xOUmersYsSXw(IntPtr TetNJiFocAUVI, ref Dictionary<ulong, hQgegBUtUPxP> OBNfGTzmGLYvK, HashSet<string> bXsPGzPPeui, Dictionary<ulong, hQgegBUtUPxP> oGmeURtBaHWh, IntPtr CxAGPlLsxEPm)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		eEtYshyFmcfp.ZeroMemory(intPtr, 65544);
		uint LXfyEQyTmw = 0u;
		while (eEtYshyFmcfp.DeviceIoControl_1(CxAGPlLsxEPm, 590003u, TetNJiFocAUVI, sizeof(eEtYshyFmcfp.sIrqiioVhQf), intPtr, 65544, out LXfyEQyTmw, IntPtr.Zero))
		{
			IntPtr p = new IntPtr(intPtr.ToInt32() + 8);
			while (LXfyEQyTmw > 60)
			{
				eEtYshyFmcfp.iXRCiPZJHeH iXRCiPZJHeH = new eEtYshyFmcfp.iXRCiPZJHeH(p);
				if ((iXRCiPZJHeH.FDRbPczgvUK & 0x10u) != 0)
				{
					if (oGmeURtBaHWh.ContainsKey(iXRCiPZJHeH.iKilXQDPLpGp))
					{
						throw new Exception($"Duplicate FRN: {iXRCiPZJHeH.iKilXQDPLpGp} for {iXRCiPZJHeH.aasPwRXxYNSDAIy}");
					}
					oGmeURtBaHWh.Add(iXRCiPZJHeH.iKilXQDPLpGp, new hQgegBUtUPxP(iXRCiPZJHeH.aasPwRXxYNSDAIy, iXRCiPZJHeH.ZVQLyhJClFkR));
				}
				else
				{
					bool flag = true;
					if (bXsPGzPPeui != null)
					{
						string extension = Path.GetExtension(iXRCiPZJHeH.aasPwRXxYNSDAIy);
						flag = bXsPGzPPeui.Contains(extension);
					}
					if (flag)
					{
						if (!OBNfGTzmGLYvK.ContainsKey(iXRCiPZJHeH.iKilXQDPLpGp))
						{
							OBNfGTzmGLYvK.Add(iXRCiPZJHeH.iKilXQDPLpGp, new hQgegBUtUPxP(iXRCiPZJHeH.aasPwRXxYNSDAIy, iXRCiPZJHeH.ZVQLyhJClFkR));
						}
						else
						{
							hQgegBUtUPxP hQgegBUtUPxP2 = OBNfGTzmGLYvK[iXRCiPZJHeH.iKilXQDPLpGp];
							if (string.Compare(iXRCiPZJHeH.aasPwRXxYNSDAIy, hQgegBUtUPxP2.BfXxdkfxUKO, ignoreCase: true) != 0)
							{
								Console.WriteLine("Attempt to add duplicate file reference number: {0} for file {1}, file from index {2}", iXRCiPZJHeH.iKilXQDPLpGp, iXRCiPZJHeH.aasPwRXxYNSDAIy, hQgegBUtUPxP2.BfXxdkfxUKO);
								throw new Exception($"Duplicate FRN: {iXRCiPZJHeH.iKilXQDPLpGp} for {iXRCiPZJHeH.aasPwRXxYNSDAIy}");
							}
						}
					}
				}
				p = new IntPtr(p.ToInt32() + iXRCiPZJHeH.UHmsNYIBnUO);
				LXfyEQyTmw -= iXRCiPZJHeH.UHmsNYIBnUO;
			}
			Marshal.WriteInt64(TetNJiFocAUVI, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void ClSJVZHYQiVQB(IntPtr DgSsxLNJYtKk)
	{
		eEtYshyFmcfp.bmPxVypUqukyhZp structure = default(eEtYshyFmcfp.bmPxVypUqukyhZp);
		structure.qZCIMQvRTyQm = 8388608uL;
		structure.smxOESQFnn = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		eEtYshyFmcfp.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		eEtYshyFmcfp.DeviceIoControl_1(DgSsxLNJYtKk, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void kQymiRdluzb(ref IntPtr yXLJAiHsYznfpqSQi, IntPtr iRefEHXCglL)
	{
		uint VVBhjfFQBvXEKE = 0u;
		eEtYshyFmcfp.pZUlAqrFRJur WOsmLUgKzvljAa = default(eEtYshyFmcfp.pZUlAqrFRJur);
		if (eEtYshyFmcfp.DeviceIoControl(iRefEHXCglL, 590068u, IntPtr.Zero, 0, out WOsmLUgKzvljAa, sizeof(eEtYshyFmcfp.pZUlAqrFRJur), out VVBhjfFQBvXEKE, IntPtr.Zero))
		{
			eEtYshyFmcfp.sIrqiioVhQf structure = default(eEtYshyFmcfp.sIrqiioVhQf);
			structure.KMOujLrHpOWNu = 0uL;
			structure.keqMnLXHQMOi = 0L;
			structure.JIyQrsfTgILhPN = WOsmLUgKzvljAa.sSjeALzWrYx;
			int num = Marshal.SizeOf(structure);
			yXLJAiHsYznfpqSQi = Marshal.AllocHGlobal(num);
			eEtYshyFmcfp.ZeroMemory(yXLJAiHsYznfpqSQi, num);
			Marshal.StructureToPtr(structure, yXLJAiHsYznfpqSQi, fDeleteOld: true);
		}
	}
}
