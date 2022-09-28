using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace YfWvQVVobAAH;

public sealed class EfCdADPdiV
{
	[NonSerialized]
	internal static GetString getString_0;

	public void vAEyrsAhZXXPqiz(string FRuJTCVdaqC, HashSet<string> YthEnkorbGnZZqV, out Dictionary<ulong, FxgptJiCPLzC> TKsfHCurLFp, out Dictionary<ulong, FxgptJiCPLzC> qwcRhsFouRgWuA)
	{
		qwcRhsFouRgWuA = new Dictionary<ulong, FxgptJiCPLzC>();
		TKsfHCurLFp = new Dictionary<ulong, FxgptJiCPLzC>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr hTxHiylzgkfM = IntPtr.Zero;
		try
		{
			oyNkANvlKDglpb(FRuJTCVdaqC, qwcRhsFouRgWuA);
			nQbyMYYdTVbay(FRuJTCVdaqC, out hTxHiylzgkfM);
			UECQRkhqsYXVG(hTxHiylzgkfM);
			itEgINeVuN(ref intptr_, hTxHiylzgkfM);
			JLjSwEsHeBx(intptr_, ref TKsfHCurLFp, YthEnkorbGnZZqV, qwcRhsFouRgWuA, hTxHiylzgkfM);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107462139), ex);
		}
		finally
		{
			if (hTxHiylzgkfM.ToInt32() != -1)
			{
				uHtYsLEINcMwGV.CloseHandle(hTxHiylzgkfM);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void oyNkANvlKDglpb(string string_0, Dictionary<ulong, FxgptJiCPLzC> dictionary_0)
	{
		string text = getString_0(107461590) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = uHtYsLEINcMwGV.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			uHtYsLEINcMwGV.MvwrRnclGz ojgckAZbHAoVE = default(uHtYsLEINcMwGV.MvwrRnclGz);
			if (uHtYsLEINcMwGV.GetFileInformationByHandle(intPtr, out ojgckAZbHAoVE))
			{
				ulong num = ojgckAZbHAoVE.wGYIwASvlvK;
				ulong key = (num << 32) | ojgckAZbHAoVE.VJbUrzDJzJYd;
				FxgptJiCPLzC value = new FxgptJiCPLzC(text, 0uL);
				dictionary_0.Add(key, value);
			}
			uHtYsLEINcMwGV.CloseHandle(intPtr);
		}
	}

	private void nQbyMYYdTVbay(string BEjnVjRgzfbe, out IntPtr hTxHiylzgkfM)
	{
		string string_ = getString_0(107461590) + BEjnVjRgzfbe;
		hTxHiylzgkfM = uHtYsLEINcMwGV.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void JLjSwEsHeBx(IntPtr intptr_0, ref Dictionary<ulong, FxgptJiCPLzC> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, FxgptJiCPLzC> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		uHtYsLEINcMwGV.ZeroMemory(intPtr, 65544);
		uint egxfKBxpsCyXP = 0u;
		while (uHtYsLEINcMwGV.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(uHtYsLEINcMwGV.yoQFBEKLEwYF), intPtr, 65544, out egxfKBxpsCyXP, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (egxfKBxpsCyXP > 60)
			{
				uHtYsLEINcMwGV.JIJTZBiNfxWSpnx jIJTZBiNfxWSpnx = new uHtYsLEINcMwGV.JIJTZBiNfxWSpnx(intptr_2);
				if ((jIJTZBiNfxWSpnx.chkgsguaUgn & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(jIJTZBiNfxWSpnx.xqIsxxXvkKHhpTe))
					{
						throw new Exception(string.Format(getString_0(107461581), jIJTZBiNfxWSpnx.xqIsxxXvkKHhpTe, jIJTZBiNfxWSpnx.dOUqlnNEGvD));
					}
					dictionary_1.Add(jIJTZBiNfxWSpnx.xqIsxxXvkKHhpTe, new FxgptJiCPLzC(jIJTZBiNfxWSpnx.dOUqlnNEGvD, jIJTZBiNfxWSpnx.feftdaZSFhtS));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(jIJTZBiNfxWSpnx.dOUqlnNEGvD);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(jIJTZBiNfxWSpnx.xqIsxxXvkKHhpTe))
						{
							dictionary_0.Add(jIJTZBiNfxWSpnx.xqIsxxXvkKHhpTe, new FxgptJiCPLzC(jIJTZBiNfxWSpnx.dOUqlnNEGvD, jIJTZBiNfxWSpnx.feftdaZSFhtS));
						}
						else
						{
							FxgptJiCPLzC fxgptJiCPLzC = dictionary_0[jIJTZBiNfxWSpnx.xqIsxxXvkKHhpTe];
							if (string.Compare(jIJTZBiNfxWSpnx.dOUqlnNEGvD, fxgptJiCPLzC.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107461576), jIJTZBiNfxWSpnx.xqIsxxXvkKHhpTe, jIJTZBiNfxWSpnx.dOUqlnNEGvD, fxgptJiCPLzC.Name);
								throw new Exception(string.Format(getString_0(107461581), jIJTZBiNfxWSpnx.xqIsxxXvkKHhpTe, jIJTZBiNfxWSpnx.dOUqlnNEGvD));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + jIJTZBiNfxWSpnx.oEHuNTEqygKHBDI);
				egxfKBxpsCyXP -= jIJTZBiNfxWSpnx.oEHuNTEqygKHBDI;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void UECQRkhqsYXVG(IntPtr intptr_0)
	{
		uHtYsLEINcMwGV.AaEqAdioueEaA structure = default(uHtYsLEINcMwGV.AaEqAdioueEaA);
		structure.rPPZpqDgLpr = 8388608uL;
		structure.RHujjEhuoit = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		uHtYsLEINcMwGV.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		uHtYsLEINcMwGV.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void itEgINeVuN(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint BLbXJDjZNSN = 0u;
		uHtYsLEINcMwGV.HwejDoOaauYJL gddCTAZTTAp = default(uHtYsLEINcMwGV.HwejDoOaauYJL);
		if (uHtYsLEINcMwGV.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out gddCTAZTTAp, sizeof(uHtYsLEINcMwGV.HwejDoOaauYJL), out BLbXJDjZNSN, IntPtr.Zero))
		{
			uHtYsLEINcMwGV.yoQFBEKLEwYF structure = default(uHtYsLEINcMwGV.yoQFBEKLEwYF);
			structure.PLROWbkMhTC = 0uL;
			structure.NDqVvQHckp = 0L;
			structure.KGpKQGSLhZX = gddCTAZTTAp.qzTOPxgQcRjX;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			uHtYsLEINcMwGV.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static EfCdADPdiV()
	{
		Strings.CreateGetStringDelegate(typeof(EfCdADPdiV));
	}
}
