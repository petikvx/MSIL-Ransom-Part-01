using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gSIYQHSVYK;

public sealed class GBFUDDDTpMNpaRFV
{
	[NonSerialized]
	internal static GetString getString_0;

	public void YjszwrQAsNAa(string RhQpvEfIyGJiRGOqhI, HashSet<string> EFIOZBjUXXvB, out Dictionary<ulong, RTVnWQrlpyAp> myNkWvaYATIyWnKs, out Dictionary<ulong, RTVnWQrlpyAp> AkEOaeckaUcuS)
	{
		AkEOaeckaUcuS = new Dictionary<ulong, RTVnWQrlpyAp>();
		myNkWvaYATIyWnKs = new Dictionary<ulong, RTVnWQrlpyAp>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr nJUYulfGbCSbh = IntPtr.Zero;
		try
		{
			JhjmqBJaRaA(RhQpvEfIyGJiRGOqhI, AkEOaeckaUcuS);
			lGwyQpfMWlujrL(RhQpvEfIyGJiRGOqhI, out nJUYulfGbCSbh);
			LalJGPyMYTWL(nJUYulfGbCSbh);
			KDLvDzFNUPkqZ(ref intptr_, nJUYulfGbCSbh);
			nUWonXYxEjgO(intptr_, ref myNkWvaYATIyWnKs, EFIOZBjUXXvB, AkEOaeckaUcuS, nJUYulfGbCSbh);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107364779), ex);
		}
		finally
		{
			if (nJUYulfGbCSbh.ToInt32() != -1)
			{
				zhUgXAdGlQGuKP.CloseHandle(nJUYulfGbCSbh);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void JhjmqBJaRaA(string string_0, Dictionary<ulong, RTVnWQrlpyAp> dictionary_0)
	{
		string text = getString_0(107364742) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = zhUgXAdGlQGuKP.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			zhUgXAdGlQGuKP.azUFzPjEvMM TZAySlcErtjN = default(zhUgXAdGlQGuKP.azUFzPjEvMM);
			if (zhUgXAdGlQGuKP.GetFileInformationByHandle(intPtr, out TZAySlcErtjN))
			{
				ulong num = TZAySlcErtjN.VcYPdFGInQLH;
				ulong key = (num << 32) | TZAySlcErtjN.pAMgyICKviFPev;
				RTVnWQrlpyAp value = new RTVnWQrlpyAp(text, 0uL);
				dictionary_0.Add(key, value);
			}
			zhUgXAdGlQGuKP.CloseHandle(intPtr);
		}
	}

	private void lGwyQpfMWlujrL(string FKgVmmLqpHaSr, out IntPtr nJUYulfGbCSbh)
	{
		string string_ = getString_0(107364742) + FKgVmmLqpHaSr;
		nJUYulfGbCSbh = zhUgXAdGlQGuKP.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void nUWonXYxEjgO(IntPtr intptr_0, ref Dictionary<ulong, RTVnWQrlpyAp> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, RTVnWQrlpyAp> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		zhUgXAdGlQGuKP.ZeroMemory(intPtr, 65544);
		uint lieMzSiLPDere = 0u;
		while (zhUgXAdGlQGuKP.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(zhUgXAdGlQGuKP.IJAxwiMoErj), intPtr, 65544, out lieMzSiLPDere, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (lieMzSiLPDere > 60)
			{
				zhUgXAdGlQGuKP.dMFtAlMFtmk dMFtAlMFtmk = new zhUgXAdGlQGuKP.dMFtAlMFtmk(intptr_2);
				if (0 != (dMFtAlMFtmk.YhqkbTzGTT & 0x10))
				{
					if (dictionary_1.ContainsKey(dMFtAlMFtmk.RHrPkagKOOtWFzd))
					{
						throw new Exception(string.Format(getString_0(107364733), dMFtAlMFtmk.RHrPkagKOOtWFzd, dMFtAlMFtmk.MwFgUebNSEAa));
					}
					dictionary_1.Add(dMFtAlMFtmk.RHrPkagKOOtWFzd, new RTVnWQrlpyAp(dMFtAlMFtmk.MwFgUebNSEAa, dMFtAlMFtmk.BemdrLekRoH));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(dMFtAlMFtmk.MwFgUebNSEAa);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(dMFtAlMFtmk.RHrPkagKOOtWFzd))
						{
							dictionary_0.Add(dMFtAlMFtmk.RHrPkagKOOtWFzd, new RTVnWQrlpyAp(dMFtAlMFtmk.MwFgUebNSEAa, dMFtAlMFtmk.BemdrLekRoH));
						}
						else
						{
							RTVnWQrlpyAp rTVnWQrlpyAp = dictionary_0[dMFtAlMFtmk.RHrPkagKOOtWFzd];
							if (0 != string.Compare(dMFtAlMFtmk.MwFgUebNSEAa, rTVnWQrlpyAp.Name, ignoreCase: true))
							{
								Console.WriteLine(getString_0(107364664), dMFtAlMFtmk.RHrPkagKOOtWFzd, dMFtAlMFtmk.MwFgUebNSEAa, rTVnWQrlpyAp.Name);
								throw new Exception(string.Format(getString_0(107364733), dMFtAlMFtmk.RHrPkagKOOtWFzd, dMFtAlMFtmk.MwFgUebNSEAa));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + dMFtAlMFtmk.DUMWozJHcCJGMEO);
				lieMzSiLPDere -= dMFtAlMFtmk.DUMWozJHcCJGMEO;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void LalJGPyMYTWL(IntPtr intptr_0)
	{
		zhUgXAdGlQGuKP.flDuZgMccjpL structure = default(zhUgXAdGlQGuKP.flDuZgMccjpL);
		structure.uKtHHTkBHDG = 8388608uL;
		structure.EPfcGBSnuQCcV = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		zhUgXAdGlQGuKP.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		zhUgXAdGlQGuKP.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void KDLvDzFNUPkqZ(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint dYfpecJSfjkVG = 0u;
		zhUgXAdGlQGuKP.zKCPTVkFkYocEK xHpdYjdHYFeV = default(zhUgXAdGlQGuKP.zKCPTVkFkYocEK);
		if (zhUgXAdGlQGuKP.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out xHpdYjdHYFeV, sizeof(zhUgXAdGlQGuKP.zKCPTVkFkYocEK), out dYfpecJSfjkVG, IntPtr.Zero))
		{
			zhUgXAdGlQGuKP.IJAxwiMoErj structure = default(zhUgXAdGlQGuKP.IJAxwiMoErj);
			structure.UMHicvypAUmKy = 0uL;
			structure.EClRaDcfTGqxl = 0L;
			structure.tOmxBbmTeaPg = xHpdYjdHYFeV.FZHALDwsEzpJ;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			zhUgXAdGlQGuKP.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static GBFUDDDTpMNpaRFV()
	{
		Strings.CreateGetStringDelegate(typeof(GBFUDDDTpMNpaRFV));
	}
}
