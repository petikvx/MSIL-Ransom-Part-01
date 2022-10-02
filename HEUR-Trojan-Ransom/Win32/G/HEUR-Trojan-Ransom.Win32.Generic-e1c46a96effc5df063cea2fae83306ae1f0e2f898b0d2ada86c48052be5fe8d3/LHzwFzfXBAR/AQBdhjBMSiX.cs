using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace LHzwFzfXBAR;

public sealed class AQBdhjBMSiX
{
	[NonSerialized]
	internal static GetString getString_0;

	public void pdPOjwAZoYuW(string gUOELkOncTMpJX, HashSet<string> GwzoGCCQMiUToM, out Dictionary<ulong, dfiDGXicFqh> nOODRiTkcchni, out Dictionary<ulong, dfiDGXicFqh> qMcfBdHdpK)
	{
		qMcfBdHdpK = new Dictionary<ulong, dfiDGXicFqh>();
		nOODRiTkcchni = new Dictionary<ulong, dfiDGXicFqh>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr IwsHSNxoOds = IntPtr.Zero;
		try
		{
			dDRmsyMsSUkv(gUOELkOncTMpJX, qMcfBdHdpK);
			BLEmQXPZkKkK(gUOELkOncTMpJX, out IwsHSNxoOds);
			dxbbpXcCovQJS(IwsHSNxoOds);
			tIDhPNoQEAqr(ref intptr_, IwsHSNxoOds);
			DCSIisZPGLP(intptr_, ref nOODRiTkcchni, GwzoGCCQMiUToM, qMcfBdHdpK, IwsHSNxoOds);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107473877), ex);
		}
		finally
		{
			if (IwsHSNxoOds.ToInt32() != -1)
			{
				xWdXzhvYmDg.CloseHandle(IwsHSNxoOds);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void dDRmsyMsSUkv(string string_0, Dictionary<ulong, dfiDGXicFqh> dictionary_0)
	{
		string text = getString_0(107473840) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = xWdXzhvYmDg.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			xWdXzhvYmDg.aRrBQITLOyzGkD AfiPubnkBIFgBGOeo = default(xWdXzhvYmDg.aRrBQITLOyzGkD);
			if (xWdXzhvYmDg.GetFileInformationByHandle(intPtr, out AfiPubnkBIFgBGOeo))
			{
				ulong num = AfiPubnkBIFgBGOeo.ugVDxCdabCXRy;
				ulong key = (num << 32) | AfiPubnkBIFgBGOeo.yCxPSUXdrew;
				dfiDGXicFqh value = new dfiDGXicFqh(text, 0uL);
				dictionary_0.Add(key, value);
			}
			xWdXzhvYmDg.CloseHandle(intPtr);
		}
	}

	private void BLEmQXPZkKkK(string WlpdQivyPP, out IntPtr IwsHSNxoOds)
	{
		string string_ = getString_0(107473840) + WlpdQivyPP;
		IwsHSNxoOds = xWdXzhvYmDg.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void DCSIisZPGLP(IntPtr intptr_0, ref Dictionary<ulong, dfiDGXicFqh> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, dfiDGXicFqh> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		xWdXzhvYmDg.ZeroMemory(intPtr, 65544);
		uint OAbxgxnyISk = 0u;
		while (xWdXzhvYmDg.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(xWdXzhvYmDg.HfktFvXfDB), intPtr, 65544, out OAbxgxnyISk, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (OAbxgxnyISk > 60)
			{
				xWdXzhvYmDg.ZKtlOAFYlK zKtlOAFYlK = new xWdXzhvYmDg.ZKtlOAFYlK(intptr_2);
				if ((zKtlOAFYlK.VNSQNSdbZH & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(zKtlOAFYlK.BFcFxbpPACasV))
					{
						throw new Exception(string.Format(getString_0(107473831), zKtlOAFYlK.BFcFxbpPACasV, zKtlOAFYlK.PLCSRoQaWtE));
					}
					dictionary_1.Add(zKtlOAFYlK.BFcFxbpPACasV, new dfiDGXicFqh(zKtlOAFYlK.PLCSRoQaWtE, zKtlOAFYlK.YdCVvjlyJloKt));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(zKtlOAFYlK.PLCSRoQaWtE);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(zKtlOAFYlK.BFcFxbpPACasV))
						{
							dictionary_0.Add(zKtlOAFYlK.BFcFxbpPACasV, new dfiDGXicFqh(zKtlOAFYlK.PLCSRoQaWtE, zKtlOAFYlK.YdCVvjlyJloKt));
						}
						else
						{
							dfiDGXicFqh dfiDGXicFqh2 = dictionary_0[zKtlOAFYlK.BFcFxbpPACasV];
							if (string.Compare(zKtlOAFYlK.PLCSRoQaWtE, dfiDGXicFqh2.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107473762), zKtlOAFYlK.BFcFxbpPACasV, zKtlOAFYlK.PLCSRoQaWtE, dfiDGXicFqh2.Name);
								throw new Exception(string.Format(getString_0(107473831), zKtlOAFYlK.BFcFxbpPACasV, zKtlOAFYlK.PLCSRoQaWtE));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + zKtlOAFYlK.VOAOrKwjfRY);
				OAbxgxnyISk -= zKtlOAFYlK.VOAOrKwjfRY;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void dxbbpXcCovQJS(IntPtr intptr_0)
	{
		xWdXzhvYmDg.VWLiYYudnwMnjv structure = default(xWdXzhvYmDg.VWLiYYudnwMnjv);
		structure.bDefbRCBjGYWgku = 8388608uL;
		structure.VMENVFsSAHghQel = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		xWdXzhvYmDg.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		xWdXzhvYmDg.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void tIDhPNoQEAqr(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint qxDzOKAcNjZhMCqB = 0u;
		xWdXzhvYmDg.NSYgDUVmlYH YhRnUtobalFv = default(xWdXzhvYmDg.NSYgDUVmlYH);
		if (xWdXzhvYmDg.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out YhRnUtobalFv, sizeof(xWdXzhvYmDg.NSYgDUVmlYH), out qxDzOKAcNjZhMCqB, IntPtr.Zero))
		{
			xWdXzhvYmDg.HfktFvXfDB structure = default(xWdXzhvYmDg.HfktFvXfDB);
			structure.MZdUKzgvlghV = 0uL;
			structure.vhILeRSmMdR = 0L;
			structure.tAtfqyHxoarMtE = YhRnUtobalFv.IvaTJgSBll;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			xWdXzhvYmDg.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static AQBdhjBMSiX()
	{
		Strings.CreateGetStringDelegate(typeof(AQBdhjBMSiX));
	}
}
