using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace SyaaQuaZnuVC;

public class LeFVxlMLXOora
{
	public void oBKxowLPqDffn(string zOGkvxfPXKSF, HashSet<string> bypDrTLZMctdd, out Dictionary<ulong, LwrHnVEFYNehp> IomyjRbOTa, out Dictionary<ulong, LwrHnVEFYNehp> BSkteNLUiXVfqN)
	{
		BSkteNLUiXVfqN = new Dictionary<ulong, LwrHnVEFYNehp>();
		IomyjRbOTa = new Dictionary<ulong, LwrHnVEFYNehp>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr AvHbLEpIqSbM = IntPtr.Zero;
		try
		{
			OwWXIolSvW(zOGkvxfPXKSF, BSkteNLUiXVfqN);
			KqQivwgosnLt(zOGkvxfPXKSF, out AvHbLEpIqSbM);
			qbWXeokFBOMGsUV(AvHbLEpIqSbM);
			wmWhwmaXAPHqB(ref intptr_, AvHbLEpIqSbM);
			OnhxKIwcUDmxnHKJ(intptr_, ref IomyjRbOTa, bypDrTLZMctdd, BSkteNLUiXVfqN, AvHbLEpIqSbM);
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
			if (AvHbLEpIqSbM.ToInt32() != -1)
			{
				ACynyaxKANG.CloseHandle(AvHbLEpIqSbM);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void OwWXIolSvW(string string_0, Dictionary<ulong, LwrHnVEFYNehp> dictionary_0)
	{
		string text = "\\\\.\\" + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = ACynyaxKANG.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			ACynyaxKANG.gFXESaSNIgB qjACfiCwOUtqaX = default(ACynyaxKANG.gFXESaSNIgB);
			if (ACynyaxKANG.GetFileInformationByHandle(intPtr, out qjACfiCwOUtqaX))
			{
				ulong num = qjACfiCwOUtqaX.nrScwUqkPvZhrK;
				ulong key = (num << 32) | qjACfiCwOUtqaX.NorsNGuMhonayJFq;
				LwrHnVEFYNehp value = new LwrHnVEFYNehp(text, 0uL);
				dictionary_0.Add(key, value);
			}
			ACynyaxKANG.CloseHandle(intPtr);
		}
	}

	private void KqQivwgosnLt(string cxpyrguHzGI, out IntPtr AvHbLEpIqSbM)
	{
		string string_ = "\\\\.\\" + cxpyrguHzGI;
		AvHbLEpIqSbM = ACynyaxKANG.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void OnhxKIwcUDmxnHKJ(IntPtr intptr_0, ref Dictionary<ulong, LwrHnVEFYNehp> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, LwrHnVEFYNehp> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		ACynyaxKANG.ZeroMemory(intPtr, 65544);
		uint uGYeVCcnanrl = 0u;
		while (ACynyaxKANG.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(ACynyaxKANG.fJTIdcOVqQFS), intPtr, 65544, out uGYeVCcnanrl, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (uGYeVCcnanrl > 60)
			{
				ACynyaxKANG.FHqOuUDnubU fHqOuUDnubU = new ACynyaxKANG.FHqOuUDnubU(intptr_2);
				if ((fHqOuUDnubU.ZQjkWQUXOubEn & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(fHqOuUDnubU.QMGiDtZOpd))
					{
						throw new Exception($"Duplicate FRN: {fHqOuUDnubU.QMGiDtZOpd} for {fHqOuUDnubU.WnqumptOpuqWjJ}");
					}
					dictionary_1.Add(fHqOuUDnubU.QMGiDtZOpd, new LwrHnVEFYNehp(fHqOuUDnubU.WnqumptOpuqWjJ, fHqOuUDnubU.wRUEYcpoPDUDML));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(fHqOuUDnubU.WnqumptOpuqWjJ);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(fHqOuUDnubU.QMGiDtZOpd))
						{
							dictionary_0.Add(fHqOuUDnubU.QMGiDtZOpd, new LwrHnVEFYNehp(fHqOuUDnubU.WnqumptOpuqWjJ, fHqOuUDnubU.wRUEYcpoPDUDML));
						}
						else
						{
							LwrHnVEFYNehp lwrHnVEFYNehp = dictionary_0[fHqOuUDnubU.QMGiDtZOpd];
							if (string.Compare(fHqOuUDnubU.WnqumptOpuqWjJ, lwrHnVEFYNehp.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine("Attempt to add duplicate file reference number: {0} for file {1}, file from index {2}", fHqOuUDnubU.QMGiDtZOpd, fHqOuUDnubU.WnqumptOpuqWjJ, lwrHnVEFYNehp.Name);
								throw new Exception($"Duplicate FRN: {fHqOuUDnubU.QMGiDtZOpd} for {fHqOuUDnubU.WnqumptOpuqWjJ}");
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + fHqOuUDnubU.TUIxTXrhCZEwhGC);
				uGYeVCcnanrl -= fHqOuUDnubU.TUIxTXrhCZEwhGC;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void qbWXeokFBOMGsUV(IntPtr intptr_0)
	{
		ACynyaxKANG.adccExBvjiko structure = default(ACynyaxKANG.adccExBvjiko);
		structure.GxKkxpUknqoWn = 8388608uL;
		structure.qyAPsgAMIfOEHRJ = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		ACynyaxKANG.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		ACynyaxKANG.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void wmWhwmaXAPHqB(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint VXDfzqLiRE = 0u;
		ACynyaxKANG.quVHmTTreMtirFh roJTceYKHgGC = default(ACynyaxKANG.quVHmTTreMtirFh);
		if (ACynyaxKANG.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out roJTceYKHgGC, sizeof(ACynyaxKANG.quVHmTTreMtirFh), out VXDfzqLiRE, IntPtr.Zero))
		{
			ACynyaxKANG.fJTIdcOVqQFS structure = default(ACynyaxKANG.fJTIdcOVqQFS);
			structure.NCeaBAEDabVfyT = 0uL;
			structure.ZQFBhskpGj = 0L;
			structure.llDpsSAKiXEd = roJTceYKHgGC.hxtWZKgxpP;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			ACynyaxKANG.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}
}
