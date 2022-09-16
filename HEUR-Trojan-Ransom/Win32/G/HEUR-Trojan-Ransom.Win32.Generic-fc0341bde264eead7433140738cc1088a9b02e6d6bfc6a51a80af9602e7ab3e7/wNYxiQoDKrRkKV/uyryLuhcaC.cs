using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wNYxiQoDKrRkKV;

public sealed class uyryLuhcaC
{
	[NonSerialized]
	internal static GetString getString_0;

	public void NjqbKCOlkbvoE(string KCYshCvaUpN, HashSet<string> ZbFTRMAxvP, out Dictionary<ulong, xTgjpcnmTTwIo> vqdElgxFKQyzey, out Dictionary<ulong, xTgjpcnmTTwIo> DhrEthfMLZiM)
	{
		DhrEthfMLZiM = new Dictionary<ulong, xTgjpcnmTTwIo>();
		vqdElgxFKQyzey = new Dictionary<ulong, xTgjpcnmTTwIo>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr yGqNSdbLkVQVo = IntPtr.Zero;
		try
		{
			rXysQQDYSVAyF(KCYshCvaUpN, DhrEthfMLZiM);
			aafpFiruMirqY(KCYshCvaUpN, out yGqNSdbLkVQVo);
			NsOLzuRgNV(yGqNSdbLkVQVo);
			axmxvXhoVjz(ref intptr_, yGqNSdbLkVQVo);
			tKqOiWGotkN(intptr_, ref vqdElgxFKQyzey, ZbFTRMAxvP, DhrEthfMLZiM, yGqNSdbLkVQVo);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107399303), ex);
		}
		finally
		{
			if (yGqNSdbLkVQVo.ToInt32() != -1)
			{
				aAbUMGekNx.CloseHandle(yGqNSdbLkVQVo);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void rXysQQDYSVAyF(string string_0, Dictionary<ulong, xTgjpcnmTTwIo> dictionary_0)
	{
		string text = getString_0(107399298) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = aAbUMGekNx.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			aAbUMGekNx.igFyARwBRx kgPQMuMEIsF = default(aAbUMGekNx.igFyARwBRx);
			if (aAbUMGekNx.GetFileInformationByHandle(intPtr, out kgPQMuMEIsF))
			{
				ulong num = kgPQMuMEIsF.yFuOnHzcyGZEoMS;
				ulong key = (num << 32) | kgPQMuMEIsF.jDRghywqjxQM;
				xTgjpcnmTTwIo value = new xTgjpcnmTTwIo(text, 0uL);
				dictionary_0.Add(key, value);
			}
			aAbUMGekNx.CloseHandle(intPtr);
		}
	}

	private void aafpFiruMirqY(string KiTJMboBCFX, out IntPtr yGqNSdbLkVQVo)
	{
		string string_ = getString_0(107399298) + KiTJMboBCFX;
		yGqNSdbLkVQVo = aAbUMGekNx.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void tKqOiWGotkN(IntPtr intptr_0, ref Dictionary<ulong, xTgjpcnmTTwIo> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, xTgjpcnmTTwIo> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		aAbUMGekNx.ZeroMemory(intPtr, 65544);
		uint AcRzhzrvqX = 0u;
		while (aAbUMGekNx.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(aAbUMGekNx.FkUTcsbdyfIXF), intPtr, 65544, out AcRzhzrvqX, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (AcRzhzrvqX > 60)
			{
				aAbUMGekNx.RIrpYXSpeIedSNrY rIrpYXSpeIedSNrY = new aAbUMGekNx.RIrpYXSpeIedSNrY(intptr_2);
				if ((rIrpYXSpeIedSNrY.dAayYfXpYrj & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(rIrpYXSpeIedSNrY.MsncOsaXhky))
					{
						throw new Exception(string.Format(getString_0(107399289), rIrpYXSpeIedSNrY.MsncOsaXhky, rIrpYXSpeIedSNrY.sUGtKrgxbHAJ));
					}
					dictionary_1.Add(rIrpYXSpeIedSNrY.MsncOsaXhky, new xTgjpcnmTTwIo(rIrpYXSpeIedSNrY.sUGtKrgxbHAJ, rIrpYXSpeIedSNrY.cjlIOfhjUyqek));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(rIrpYXSpeIedSNrY.sUGtKrgxbHAJ);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(rIrpYXSpeIedSNrY.MsncOsaXhky))
						{
							dictionary_0.Add(rIrpYXSpeIedSNrY.MsncOsaXhky, new xTgjpcnmTTwIo(rIrpYXSpeIedSNrY.sUGtKrgxbHAJ, rIrpYXSpeIedSNrY.cjlIOfhjUyqek));
						}
						else
						{
							xTgjpcnmTTwIo xTgjpcnmTTwIo2 = dictionary_0[rIrpYXSpeIedSNrY.MsncOsaXhky];
							if (string.Compare(rIrpYXSpeIedSNrY.sUGtKrgxbHAJ, xTgjpcnmTTwIo2.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107399252), rIrpYXSpeIedSNrY.MsncOsaXhky, rIrpYXSpeIedSNrY.sUGtKrgxbHAJ, xTgjpcnmTTwIo2.Name);
								throw new Exception(string.Format(getString_0(107399289), rIrpYXSpeIedSNrY.MsncOsaXhky, rIrpYXSpeIedSNrY.sUGtKrgxbHAJ));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + rIrpYXSpeIedSNrY.ChdkHQiftsRQUf);
				AcRzhzrvqX -= rIrpYXSpeIedSNrY.ChdkHQiftsRQUf;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void NsOLzuRgNV(IntPtr intptr_0)
	{
		aAbUMGekNx.uAYGvyZVYkHmoWuG structure = default(aAbUMGekNx.uAYGvyZVYkHmoWuG);
		structure.iWEyEEWqEBoF = 8388608uL;
		structure.QZoFRaRDhYaQ = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		aAbUMGekNx.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		aAbUMGekNx.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void axmxvXhoVjz(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint UPfMvIhykvED = 0u;
		aAbUMGekNx.AiLBqivitZ qzlPtpigVHn = default(aAbUMGekNx.AiLBqivitZ);
		if (aAbUMGekNx.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out qzlPtpigVHn, sizeof(aAbUMGekNx.AiLBqivitZ), out UPfMvIhykvED, IntPtr.Zero))
		{
			aAbUMGekNx.FkUTcsbdyfIXF structure = default(aAbUMGekNx.FkUTcsbdyfIXF);
			structure.ZRHWHTjzRnrZ = 0uL;
			structure.LiKREmZiUoTK = 0L;
			structure.IeQVNOlmxtTaose = qzlPtpigVHn.teumvnAMftTe;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			aAbUMGekNx.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static uyryLuhcaC()
	{
		Strings.CreateGetStringDelegate(typeof(uyryLuhcaC));
	}
}
