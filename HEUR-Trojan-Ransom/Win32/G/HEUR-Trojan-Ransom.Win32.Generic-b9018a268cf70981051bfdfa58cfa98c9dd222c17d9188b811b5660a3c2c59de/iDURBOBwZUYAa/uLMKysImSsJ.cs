using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace iDURBOBwZUYAa;

public sealed class uLMKysImSsJ
{
	[NonSerialized]
	internal static GetString getString_0;

	public void LelsgrjahQdRzW(string oDWtKQusQgrCsR, HashSet<string> eEasFUZtVkrz, out Dictionary<ulong, iTusLOxKGOOgeO> HFZvQPXJdzx, out Dictionary<ulong, iTusLOxKGOOgeO> JhdlchZXKxPe)
	{
		JhdlchZXKxPe = new Dictionary<ulong, iTusLOxKGOOgeO>();
		HFZvQPXJdzx = new Dictionary<ulong, iTusLOxKGOOgeO>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr YpcIwtZLGWorz = IntPtr.Zero;
		try
		{
			WJMhGimPYOQWLb(oDWtKQusQgrCsR, JhdlchZXKxPe);
			UgJurBAyJuAW(oDWtKQusQgrCsR, out YpcIwtZLGWorz);
			LcAqZVPxDQ(YpcIwtZLGWorz);
			WVSNcpWuQUk(ref intptr_, YpcIwtZLGWorz);
			fKsFisWqkapZ(intptr_, ref HFZvQPXJdzx, eEasFUZtVkrz, JhdlchZXKxPe, YpcIwtZLGWorz);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107377380), ex);
		}
		finally
		{
			if (YpcIwtZLGWorz.ToInt32() != -1)
			{
				WPMMiAqfiYCn.CloseHandle(YpcIwtZLGWorz);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void WJMhGimPYOQWLb(string string_0, Dictionary<ulong, iTusLOxKGOOgeO> dictionary_0)
	{
		string text = getString_0(107377343) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = WPMMiAqfiYCn.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			WPMMiAqfiYCn.MUvPxLJUEpDxlSChz pAOZYKrBmBIP = default(WPMMiAqfiYCn.MUvPxLJUEpDxlSChz);
			if (WPMMiAqfiYCn.GetFileInformationByHandle(intPtr, out pAOZYKrBmBIP))
			{
				ulong num = pAOZYKrBmBIP.QbiYXlLIgdYJv;
				ulong key = (num << 32) | pAOZYKrBmBIP.tcbKojrcou;
				iTusLOxKGOOgeO value = new iTusLOxKGOOgeO(text, 0uL);
				dictionary_0.Add(key, value);
			}
			WPMMiAqfiYCn.CloseHandle(intPtr);
		}
	}

	private void UgJurBAyJuAW(string LFLfqgrYoSxAMQ, out IntPtr YpcIwtZLGWorz)
	{
		string string_ = getString_0(107377343) + LFLfqgrYoSxAMQ;
		YpcIwtZLGWorz = WPMMiAqfiYCn.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void fKsFisWqkapZ(IntPtr intptr_0, ref Dictionary<ulong, iTusLOxKGOOgeO> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, iTusLOxKGOOgeO> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		WPMMiAqfiYCn.ZeroMemory(intPtr, 65544);
		uint jRnXkxeXLsFt = 0u;
		while (WPMMiAqfiYCn.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(WPMMiAqfiYCn.mitzhZbEFSV), intPtr, 65544, out jRnXkxeXLsFt, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (jRnXkxeXLsFt > 60)
			{
				WPMMiAqfiYCn.ZdDpizzlBtxF zdDpizzlBtxF = new WPMMiAqfiYCn.ZdDpizzlBtxF(intptr_2);
				if ((zdDpizzlBtxF.jZBOCZRnxyFp & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(zdDpizzlBtxF.WPLQuTzteXoAv))
					{
						throw new Exception(string.Format(getString_0(107377366), zdDpizzlBtxF.WPLQuTzteXoAv, zdDpizzlBtxF.MLFJzzTLoFSlh));
					}
					dictionary_1.Add(zdDpizzlBtxF.WPLQuTzteXoAv, new iTusLOxKGOOgeO(zdDpizzlBtxF.MLFJzzTLoFSlh, zdDpizzlBtxF.WPesGcRbXzG));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(zdDpizzlBtxF.MLFJzzTLoFSlh);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(zdDpizzlBtxF.WPLQuTzteXoAv))
						{
							dictionary_0.Add(zdDpizzlBtxF.WPLQuTzteXoAv, new iTusLOxKGOOgeO(zdDpizzlBtxF.MLFJzzTLoFSlh, zdDpizzlBtxF.WPesGcRbXzG));
						}
						else
						{
							iTusLOxKGOOgeO iTusLOxKGOOgeO2 = dictionary_0[zdDpizzlBtxF.WPLQuTzteXoAv];
							if (string.Compare(zdDpizzlBtxF.MLFJzzTLoFSlh, iTusLOxKGOOgeO2.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107377329), zdDpizzlBtxF.WPLQuTzteXoAv, zdDpizzlBtxF.MLFJzzTLoFSlh, iTusLOxKGOOgeO2.Name);
								throw new Exception(string.Format(getString_0(107377366), zdDpizzlBtxF.WPLQuTzteXoAv, zdDpizzlBtxF.MLFJzzTLoFSlh));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + zdDpizzlBtxF.IuoSKnNcFIrVJjl);
				jRnXkxeXLsFt -= zdDpizzlBtxF.IuoSKnNcFIrVJjl;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void LcAqZVPxDQ(IntPtr intptr_0)
	{
		WPMMiAqfiYCn.aatuXRKJvlSDi structure = default(WPMMiAqfiYCn.aatuXRKJvlSDi);
		structure.yeIhkMjYvC = 8388608uL;
		structure.qLppcpThZcJvQeXh = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		WPMMiAqfiYCn.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		WPMMiAqfiYCn.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void WVSNcpWuQUk(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint IfbkispEkdyq = 0u;
		WPMMiAqfiYCn.aUwHlTGbKfOUN VAlcdNhTmUPjo = default(WPMMiAqfiYCn.aUwHlTGbKfOUN);
		if (WPMMiAqfiYCn.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out VAlcdNhTmUPjo, sizeof(WPMMiAqfiYCn.aUwHlTGbKfOUN), out IfbkispEkdyq, IntPtr.Zero))
		{
			WPMMiAqfiYCn.mitzhZbEFSV structure = default(WPMMiAqfiYCn.mitzhZbEFSV);
			structure.zMrMvBfjEim = 0uL;
			structure.rtWDygDlPvMQ = 0L;
			structure.DkoIqPNGcPWq = VAlcdNhTmUPjo.qtEMjEovhSSe;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			WPMMiAqfiYCn.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static uLMKysImSsJ()
	{
		Strings.CreateGetStringDelegate(typeof(uLMKysImSsJ));
	}
}
