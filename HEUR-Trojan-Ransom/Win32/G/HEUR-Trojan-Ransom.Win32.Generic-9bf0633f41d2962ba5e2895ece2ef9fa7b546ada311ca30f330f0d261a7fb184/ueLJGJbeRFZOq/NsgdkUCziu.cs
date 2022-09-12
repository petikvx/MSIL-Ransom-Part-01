using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ueLJGJbeRFZOq;

public sealed class NsgdkUCziu
{
	[NonSerialized]
	internal static GetString getString_0;

	public void EEHCdCakbQjF(string hgDGDkYkjPxg, HashSet<string> AYWwIobXUr, out Dictionary<ulong, MfCRkKvYSremtJ> KpMrJJxXNDaN, out Dictionary<ulong, MfCRkKvYSremtJ> LHFacPkCtVx)
	{
		LHFacPkCtVx = new Dictionary<ulong, MfCRkKvYSremtJ>();
		KpMrJJxXNDaN = new Dictionary<ulong, MfCRkKvYSremtJ>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr QeqxIrJKYazBiWD = IntPtr.Zero;
		try
		{
			MIkJcnpGhaaFPl(hgDGDkYkjPxg, LHFacPkCtVx);
			PctFqtlZXD(hgDGDkYkjPxg, out QeqxIrJKYazBiWD);
			spfHEkhaWJJSVJOI(QeqxIrJKYazBiWD);
			nJtVOoWAITMF(ref intptr_, QeqxIrJKYazBiWD);
			RntStiSqmh(intptr_, ref KpMrJJxXNDaN, AYWwIobXUr, LHFacPkCtVx, QeqxIrJKYazBiWD);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107376210), ex);
		}
		finally
		{
			if (QeqxIrJKYazBiWD.ToInt32() != -1)
			{
				WqWLCwhgVVpOo.CloseHandle(QeqxIrJKYazBiWD);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void MIkJcnpGhaaFPl(string string_0, Dictionary<ulong, MfCRkKvYSremtJ> dictionary_0)
	{
		string text = getString_0(107376173) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = WqWLCwhgVVpOo.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			WqWLCwhgVVpOo.PjOUVNuODLfT mesiyiZTHaRy = default(WqWLCwhgVVpOo.PjOUVNuODLfT);
			if (WqWLCwhgVVpOo.GetFileInformationByHandle(intPtr, out mesiyiZTHaRy))
			{
				ulong num = mesiyiZTHaRy.yDnvSwgntGPEaK;
				ulong key = (num << 32) | mesiyiZTHaRy.dtmLXAGsXRi;
				MfCRkKvYSremtJ value = new MfCRkKvYSremtJ(text, 0uL);
				dictionary_0.Add(key, value);
			}
			WqWLCwhgVVpOo.CloseHandle(intPtr);
		}
	}

	private void PctFqtlZXD(string aJqOLgvCBqpAH, out IntPtr QeqxIrJKYazBiWD)
	{
		string string_ = getString_0(107376173) + aJqOLgvCBqpAH;
		QeqxIrJKYazBiWD = WqWLCwhgVVpOo.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void RntStiSqmh(IntPtr intptr_0, ref Dictionary<ulong, MfCRkKvYSremtJ> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, MfCRkKvYSremtJ> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		WqWLCwhgVVpOo.ZeroMemory(intPtr, 65544);
		uint iFVpKFREszgD = 0u;
		while (WqWLCwhgVVpOo.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(WqWLCwhgVVpOo.qwEkaoxqNF), intPtr, 65544, out iFVpKFREszgD, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (iFVpKFREszgD > 60)
			{
				WqWLCwhgVVpOo.eNboiyhhmS eNboiyhhmS = new WqWLCwhgVVpOo.eNboiyhhmS(intptr_2);
				if ((eNboiyhhmS.pRJwNEEsxxBQp & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(eNboiyhhmS.paGJyJHPss))
					{
						throw new Exception(string.Format(getString_0(107376132), eNboiyhhmS.paGJyJHPss, eNboiyhhmS.cVvbQKOMBtmy));
					}
					dictionary_1.Add(eNboiyhhmS.paGJyJHPss, new MfCRkKvYSremtJ(eNboiyhhmS.cVvbQKOMBtmy, eNboiyhhmS.ZlLAPbqaSopJRqx));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(eNboiyhhmS.cVvbQKOMBtmy);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(eNboiyhhmS.paGJyJHPss))
						{
							dictionary_0.Add(eNboiyhhmS.paGJyJHPss, new MfCRkKvYSremtJ(eNboiyhhmS.cVvbQKOMBtmy, eNboiyhhmS.ZlLAPbqaSopJRqx));
						}
						else
						{
							MfCRkKvYSremtJ mfCRkKvYSremtJ = dictionary_0[eNboiyhhmS.paGJyJHPss];
							if (string.Compare(eNboiyhhmS.cVvbQKOMBtmy, mfCRkKvYSremtJ.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107375583), eNboiyhhmS.paGJyJHPss, eNboiyhhmS.cVvbQKOMBtmy, mfCRkKvYSremtJ.Name);
								throw new Exception(string.Format(getString_0(107376132), eNboiyhhmS.paGJyJHPss, eNboiyhhmS.cVvbQKOMBtmy));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + eNboiyhhmS.CGEMYdjwcpW);
				iFVpKFREszgD -= eNboiyhhmS.CGEMYdjwcpW;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void spfHEkhaWJJSVJOI(IntPtr intptr_0)
	{
		WqWLCwhgVVpOo.UUriaFpDXmsjyJp structure = default(WqWLCwhgVVpOo.UUriaFpDXmsjyJp);
		structure.izyvdzDqNmJF = 8388608uL;
		structure.obShgGzdVtwl = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		WqWLCwhgVVpOo.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		WqWLCwhgVVpOo.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void nJtVOoWAITMF(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint pexGFuoBKwN = 0u;
		WqWLCwhgVVpOo.VNSaMNqrqNH KookIWvWyEXm = default(WqWLCwhgVVpOo.VNSaMNqrqNH);
		if (WqWLCwhgVVpOo.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out KookIWvWyEXm, sizeof(WqWLCwhgVVpOo.VNSaMNqrqNH), out pexGFuoBKwN, IntPtr.Zero))
		{
			WqWLCwhgVVpOo.qwEkaoxqNF structure = default(WqWLCwhgVVpOo.qwEkaoxqNF);
			structure.UsgUrLfqrdyc = 0uL;
			structure.ZPtgqrlsLkzi = 0L;
			structure.NuvdBPJfIxMn = KookIWvWyEXm.uDdDTmcuzAYC;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			WqWLCwhgVVpOo.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static NsgdkUCziu()
	{
		Strings.CreateGetStringDelegate(typeof(NsgdkUCziu));
	}
}
