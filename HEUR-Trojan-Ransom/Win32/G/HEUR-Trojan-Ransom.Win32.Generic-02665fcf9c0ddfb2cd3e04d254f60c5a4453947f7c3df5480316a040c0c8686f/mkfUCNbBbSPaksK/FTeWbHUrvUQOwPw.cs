using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace mkfUCNbBbSPaksK;

public sealed class FTeWbHUrvUQOwPw
{
	[NonSerialized]
	internal static GetString getString_0;

	public void bXEzEPANiNsp(string udAjhsPWErMS, HashSet<string> ErHtqfiCmLEMiC, out Dictionary<ulong, jkHCDLwRtVVaj> wVdFfZKuVsbEht, out Dictionary<ulong, jkHCDLwRtVVaj> KEAdNAyVIGofBWrE)
	{
		KEAdNAyVIGofBWrE = new Dictionary<ulong, jkHCDLwRtVVaj>();
		wVdFfZKuVsbEht = new Dictionary<ulong, jkHCDLwRtVVaj>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr hyYuYhXNvxVtj = IntPtr.Zero;
		try
		{
			IluPBWMfZMfUK(udAjhsPWErMS, KEAdNAyVIGofBWrE);
			lIYRXChycLWRmL(udAjhsPWErMS, out hyYuYhXNvxVtj);
			MWTisCWJgiYM(hyYuYhXNvxVtj);
			ZAqpiIKCYVDd(ref intptr_, hyYuYhXNvxVtj);
			nnEboiTsoz(intptr_, ref wVdFfZKuVsbEht, ErHtqfiCmLEMiC, KEAdNAyVIGofBWrE, hyYuYhXNvxVtj);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107366422), ex);
		}
		finally
		{
			if (hyYuYhXNvxVtj.ToInt32() != -1)
			{
				RhCGsiILugJ.CloseHandle(hyYuYhXNvxVtj);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void IluPBWMfZMfUK(string string_0, Dictionary<ulong, jkHCDLwRtVVaj> dictionary_0)
	{
		string text = getString_0(107366385) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = RhCGsiILugJ.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			RhCGsiILugJ.dqQOtajJhhVHb FPKWuHZoSBTbMN = default(RhCGsiILugJ.dqQOtajJhhVHb);
			if (RhCGsiILugJ.GetFileInformationByHandle(intPtr, out FPKWuHZoSBTbMN))
			{
				ulong num = FPKWuHZoSBTbMN.zwcIGAwIjiP;
				ulong key = (num << 32) | FPKWuHZoSBTbMN.VGKmCajlrKAH;
				jkHCDLwRtVVaj value = new jkHCDLwRtVVaj(text, 0uL);
				dictionary_0.Add(key, value);
			}
			RhCGsiILugJ.CloseHandle(intPtr);
		}
	}

	private void lIYRXChycLWRmL(string rEVkwtUxgxtBYBj, out IntPtr hyYuYhXNvxVtj)
	{
		string string_ = getString_0(107366385) + rEVkwtUxgxtBYBj;
		hyYuYhXNvxVtj = RhCGsiILugJ.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void nnEboiTsoz(IntPtr intptr_0, ref Dictionary<ulong, jkHCDLwRtVVaj> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, jkHCDLwRtVVaj> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		RhCGsiILugJ.ZeroMemory(intPtr, 65544);
		uint GKtmRiHOyOA = 0u;
		while (RhCGsiILugJ.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(RhCGsiILugJ.UjaLxSAEEK), intPtr, 65544, out GKtmRiHOyOA, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (GKtmRiHOyOA > 60)
			{
				RhCGsiILugJ.uDxFXuAcDLUA uDxFXuAcDLUA = new RhCGsiILugJ.uDxFXuAcDLUA(intptr_2);
				if ((uDxFXuAcDLUA.OKsyrsGPHVLpJ & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(uDxFXuAcDLUA.nnVzioTTvoEr))
					{
						throw new Exception(string.Format(getString_0(107366344), uDxFXuAcDLUA.nnVzioTTvoEr, uDxFXuAcDLUA.FjRvGFCImpb));
					}
					dictionary_1.Add(uDxFXuAcDLUA.nnVzioTTvoEr, new jkHCDLwRtVVaj(uDxFXuAcDLUA.FjRvGFCImpb, uDxFXuAcDLUA.BHfGaerfFBG));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(uDxFXuAcDLUA.FjRvGFCImpb);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(uDxFXuAcDLUA.nnVzioTTvoEr))
						{
							dictionary_0.Add(uDxFXuAcDLUA.nnVzioTTvoEr, new jkHCDLwRtVVaj(uDxFXuAcDLUA.FjRvGFCImpb, uDxFXuAcDLUA.BHfGaerfFBG));
						}
						else
						{
							jkHCDLwRtVVaj jkHCDLwRtVVaj2 = dictionary_0[uDxFXuAcDLUA.nnVzioTTvoEr];
							if (string.Compare(uDxFXuAcDLUA.FjRvGFCImpb, jkHCDLwRtVVaj2.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107366307), uDxFXuAcDLUA.nnVzioTTvoEr, uDxFXuAcDLUA.FjRvGFCImpb, jkHCDLwRtVVaj2.Name);
								throw new Exception(string.Format(getString_0(107366344), uDxFXuAcDLUA.nnVzioTTvoEr, uDxFXuAcDLUA.FjRvGFCImpb));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + uDxFXuAcDLUA.zGyBWezunBimFHR);
				GKtmRiHOyOA -= uDxFXuAcDLUA.zGyBWezunBimFHR;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void MWTisCWJgiYM(IntPtr intptr_0)
	{
		RhCGsiILugJ.qUOnIFKHROCqOs structure = default(RhCGsiILugJ.qUOnIFKHROCqOs);
		structure.MvICPDkjWOLMpH = 8388608uL;
		structure.fYCTyVaFoeXoKuK = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		RhCGsiILugJ.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		RhCGsiILugJ.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void ZAqpiIKCYVDd(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint BFJRyzeyfm = 0u;
		RhCGsiILugJ.SvuIWiMIJxzOOR ZQbzQdXSOttm = default(RhCGsiILugJ.SvuIWiMIJxzOOR);
		if (RhCGsiILugJ.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out ZQbzQdXSOttm, sizeof(RhCGsiILugJ.SvuIWiMIJxzOOR), out BFJRyzeyfm, IntPtr.Zero))
		{
			RhCGsiILugJ.UjaLxSAEEK structure = default(RhCGsiILugJ.UjaLxSAEEK);
			structure.alRCWMsZEA = 0uL;
			structure.FNWPEqqVCFenaLg = 0L;
			structure.iqnHubBQMHeF = ZQbzQdXSOttm.TBdbHrXEwZA;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			RhCGsiILugJ.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static FTeWbHUrvUQOwPw()
	{
		Strings.CreateGetStringDelegate(typeof(FTeWbHUrvUQOwPw));
	}
}
