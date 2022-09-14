using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KpMfljJgmqhysH;

public sealed class oefuEEHuDPssK
{
	[NonSerialized]
	internal static GetString getString_0;

	public void cQxcsoZrLLwdmk(string AsYapsKXGULcjo, HashSet<string> uuLnYvExblLeukdi, out Dictionary<ulong, McDDHBPuVQei> VYsxYWjAkfDvc, out Dictionary<ulong, McDDHBPuVQei> pSuSUWsCQQTOBD)
	{
		pSuSUWsCQQTOBD = new Dictionary<ulong, McDDHBPuVQei>();
		VYsxYWjAkfDvc = new Dictionary<ulong, McDDHBPuVQei>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr FcHJEMfMxMu = IntPtr.Zero;
		try
		{
			YOwIxkAsUZNMa(AsYapsKXGULcjo, pSuSUWsCQQTOBD);
			DxDkyEDRMtZ(AsYapsKXGULcjo, out FcHJEMfMxMu);
			rtWyxBeLgHPnw(FcHJEMfMxMu);
			CXYtRGpCNG(ref intptr_, FcHJEMfMxMu);
			vJuUXgMyDzHgDVC(intptr_, ref VYsxYWjAkfDvc, uuLnYvExblLeukdi, pSuSUWsCQQTOBD, FcHJEMfMxMu);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107403786), ex);
		}
		finally
		{
			if (FcHJEMfMxMu.ToInt32() != -1)
			{
				BnrERhqprMVch.CloseHandle(FcHJEMfMxMu);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void YOwIxkAsUZNMa(string string_0, Dictionary<ulong, McDDHBPuVQei> dictionary_0)
	{
		string text = getString_0(107403781) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = BnrERhqprMVch.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			BnrERhqprMVch.KeTiEAWdMUijBMgm jmelHprRfyAsk = default(BnrERhqprMVch.KeTiEAWdMUijBMgm);
			if (BnrERhqprMVch.GetFileInformationByHandle(intPtr, out jmelHprRfyAsk))
			{
				ulong num = jmelHprRfyAsk.eGArBbTECGVk;
				ulong key = (num << 32) | jmelHprRfyAsk.lDRlYTPfItWj;
				McDDHBPuVQei value = new McDDHBPuVQei(text, 0uL);
				dictionary_0.Add(key, value);
			}
			BnrERhqprMVch.CloseHandle(intPtr);
		}
	}

	private void DxDkyEDRMtZ(string MwZwiLqCIeTtg, out IntPtr FcHJEMfMxMu)
	{
		string string_ = getString_0(107403781) + MwZwiLqCIeTtg;
		FcHJEMfMxMu = BnrERhqprMVch.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void vJuUXgMyDzHgDVC(IntPtr intptr_0, ref Dictionary<ulong, McDDHBPuVQei> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, McDDHBPuVQei> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		BnrERhqprMVch.ZeroMemory(intPtr, 65544);
		uint MXpbLWojMFZf = 0u;
		while (BnrERhqprMVch.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(BnrERhqprMVch.emgFKmDVYgfSt), intPtr, 65544, out MXpbLWojMFZf, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (MXpbLWojMFZf > 60)
			{
				BnrERhqprMVch.IbWpNGWtNtj ibWpNGWtNtj = new BnrERhqprMVch.IbWpNGWtNtj(intptr_2);
				if ((ibWpNGWtNtj.qtwVndlfoEIkP & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(ibWpNGWtNtj.wJMVfKQxBwsvhZP))
					{
						throw new Exception(string.Format(getString_0(107403772), ibWpNGWtNtj.wJMVfKQxBwsvhZP, ibWpNGWtNtj.mZNcxjrbcyAxy));
					}
					dictionary_1.Add(ibWpNGWtNtj.wJMVfKQxBwsvhZP, new McDDHBPuVQei(ibWpNGWtNtj.mZNcxjrbcyAxy, ibWpNGWtNtj.XpONcGAfnyor));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(ibWpNGWtNtj.mZNcxjrbcyAxy);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(ibWpNGWtNtj.wJMVfKQxBwsvhZP))
						{
							dictionary_0.Add(ibWpNGWtNtj.wJMVfKQxBwsvhZP, new McDDHBPuVQei(ibWpNGWtNtj.mZNcxjrbcyAxy, ibWpNGWtNtj.XpONcGAfnyor));
						}
						else
						{
							McDDHBPuVQei mcDDHBPuVQei = dictionary_0[ibWpNGWtNtj.wJMVfKQxBwsvhZP];
							if (string.Compare(ibWpNGWtNtj.mZNcxjrbcyAxy, mcDDHBPuVQei.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107403703), ibWpNGWtNtj.wJMVfKQxBwsvhZP, ibWpNGWtNtj.mZNcxjrbcyAxy, mcDDHBPuVQei.Name);
								throw new Exception(string.Format(getString_0(107403772), ibWpNGWtNtj.wJMVfKQxBwsvhZP, ibWpNGWtNtj.mZNcxjrbcyAxy));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + ibWpNGWtNtj.Lljivqnbejkl);
				MXpbLWojMFZf -= ibWpNGWtNtj.Lljivqnbejkl;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void rtWyxBeLgHPnw(IntPtr intptr_0)
	{
		BnrERhqprMVch.VAStWlVtfzfdk structure = default(BnrERhqprMVch.VAStWlVtfzfdk);
		structure.nPMbGJhtqRRMcjON = 8388608uL;
		structure.UVBMxhSKLFFW = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		BnrERhqprMVch.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		BnrERhqprMVch.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void CXYtRGpCNG(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint IajMvwFUrmGho = 0u;
		BnrERhqprMVch.thVEFZPcYNv CnxGQYFBpdvxf = default(BnrERhqprMVch.thVEFZPcYNv);
		if (BnrERhqprMVch.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out CnxGQYFBpdvxf, sizeof(BnrERhqprMVch.thVEFZPcYNv), out IajMvwFUrmGho, IntPtr.Zero))
		{
			BnrERhqprMVch.emgFKmDVYgfSt structure = default(BnrERhqprMVch.emgFKmDVYgfSt);
			structure.tebVlDvwShyZmW = 0uL;
			structure.NhfSFDppwhA = 0L;
			structure.dBxhziYbsOdhkx = CnxGQYFBpdvxf.xyuBRpvCLAfcFl;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			BnrERhqprMVch.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static oefuEEHuDPssK()
	{
		Strings.CreateGetStringDelegate(typeof(oefuEEHuDPssK));
	}
}
