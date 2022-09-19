using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace pLpOiMPKFBqsYEtBP;

public sealed class sDyKEwVljdR
{
	[NonSerialized]
	internal static GetString getString_0;

	public void stCgMwnttiSJsCBo(string FDbwDhmwXsi, HashSet<string> dvqyPTbZSOfESz, out Dictionary<ulong, BvgkIkgmKCVr> BMTzUYZfpZ, out Dictionary<ulong, BvgkIkgmKCVr> mmPrRgQArLY)
	{
		mmPrRgQArLY = new Dictionary<ulong, BvgkIkgmKCVr>();
		BMTzUYZfpZ = new Dictionary<ulong, BvgkIkgmKCVr>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr pnlJaOzzmvd = IntPtr.Zero;
		try
		{
			exhEmiUQGj(FDbwDhmwXsi, mmPrRgQArLY);
			lDNvtTTpGkz(FDbwDhmwXsi, out pnlJaOzzmvd);
			rMQoMfIgIRW(pnlJaOzzmvd);
			jrPAiGoBAxH(ref intptr_, pnlJaOzzmvd);
			linOxWsGGFEvrX(intptr_, ref BMTzUYZfpZ, dvqyPTbZSOfESz, mmPrRgQArLY, pnlJaOzzmvd);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107376955), ex);
		}
		finally
		{
			if (pnlJaOzzmvd.ToInt32() != -1)
			{
				EYPGBOAjVHe.CloseHandle(pnlJaOzzmvd);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void exhEmiUQGj(string string_0, Dictionary<ulong, BvgkIkgmKCVr> dictionary_0)
	{
		string text = getString_0(107376950) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = EYPGBOAjVHe.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			EYPGBOAjVHe.aCCyXrIDNIIA iCbTouFzVfk = default(EYPGBOAjVHe.aCCyXrIDNIIA);
			if (EYPGBOAjVHe.GetFileInformationByHandle(intPtr, out iCbTouFzVfk))
			{
				ulong num = iCbTouFzVfk.ZEGoiZNEfT;
				ulong key = (num << 32) | iCbTouFzVfk.yCfvgeWvXkCGvUN;
				BvgkIkgmKCVr value = new BvgkIkgmKCVr(text, 0uL);
				dictionary_0.Add(key, value);
			}
			EYPGBOAjVHe.CloseHandle(intPtr);
		}
	}

	private void lDNvtTTpGkz(string qDlsnswjOM, out IntPtr pnlJaOzzmvd)
	{
		string string_ = getString_0(107376950) + qDlsnswjOM;
		pnlJaOzzmvd = EYPGBOAjVHe.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void linOxWsGGFEvrX(IntPtr intptr_0, ref Dictionary<ulong, BvgkIkgmKCVr> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, BvgkIkgmKCVr> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		EYPGBOAjVHe.ZeroMemory(intPtr, 65544);
		uint JRLQTLIRgySyeg = 0u;
		while (EYPGBOAjVHe.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(EYPGBOAjVHe.zivfMtfkAVIeL), intPtr, 65544, out JRLQTLIRgySyeg, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (JRLQTLIRgySyeg > 60)
			{
				EYPGBOAjVHe.xbHcFvskYjo xbHcFvskYjo = new EYPGBOAjVHe.xbHcFvskYjo(intptr_2);
				if ((xbHcFvskYjo.WcoObavgWpzA & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(xbHcFvskYjo.ZTnLhzRlRY))
					{
						throw new Exception(string.Format(getString_0(107376941), xbHcFvskYjo.ZTnLhzRlRY, xbHcFvskYjo.MzTuIXetSeOX));
					}
					dictionary_1.Add(xbHcFvskYjo.ZTnLhzRlRY, new BvgkIkgmKCVr(xbHcFvskYjo.MzTuIXetSeOX, xbHcFvskYjo.NMeqFFAvHc));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(xbHcFvskYjo.MzTuIXetSeOX);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(xbHcFvskYjo.ZTnLhzRlRY))
						{
							dictionary_0.Add(xbHcFvskYjo.ZTnLhzRlRY, new BvgkIkgmKCVr(xbHcFvskYjo.MzTuIXetSeOX, xbHcFvskYjo.NMeqFFAvHc));
						}
						else
						{
							BvgkIkgmKCVr bvgkIkgmKCVr = dictionary_0[xbHcFvskYjo.ZTnLhzRlRY];
							if (string.Compare(xbHcFvskYjo.MzTuIXetSeOX, bvgkIkgmKCVr.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107377384), xbHcFvskYjo.ZTnLhzRlRY, xbHcFvskYjo.MzTuIXetSeOX, bvgkIkgmKCVr.Name);
								throw new Exception(string.Format(getString_0(107376941), xbHcFvskYjo.ZTnLhzRlRY, xbHcFvskYjo.MzTuIXetSeOX));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + xbHcFvskYjo.CoUKeocLqXUlCDDW);
				JRLQTLIRgySyeg -= xbHcFvskYjo.CoUKeocLqXUlCDDW;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void rMQoMfIgIRW(IntPtr intptr_0)
	{
		EYPGBOAjVHe.nMYQqzFSUhco structure = default(EYPGBOAjVHe.nMYQqzFSUhco);
		structure.aVdWFhTFwZ = 8388608uL;
		structure.CTyZxJKAuSZiZ = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		EYPGBOAjVHe.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		EYPGBOAjVHe.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void jrPAiGoBAxH(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint IUmJuuHZLOeFi = 0u;
		EYPGBOAjVHe.tciTSHdqCSk YghHzbgDfTV = default(EYPGBOAjVHe.tciTSHdqCSk);
		if (EYPGBOAjVHe.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out YghHzbgDfTV, sizeof(EYPGBOAjVHe.tciTSHdqCSk), out IUmJuuHZLOeFi, IntPtr.Zero))
		{
			EYPGBOAjVHe.zivfMtfkAVIeL structure = default(EYPGBOAjVHe.zivfMtfkAVIeL);
			structure.HybLTfNPnza = 0uL;
			structure.CiPuhbXPpdLZn = 0L;
			structure.OmHIjiLmeRru = YghHzbgDfTV.QIQPFlEFaigCkW;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			EYPGBOAjVHe.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static sDyKEwVljdR()
	{
		Strings.CreateGetStringDelegate(typeof(sDyKEwVljdR));
	}
}
