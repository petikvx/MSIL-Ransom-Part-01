using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace pLpOiMPKFBqsYEtBP;

public sealed class tjzTpApWfmt
{
	[NonSerialized]
	internal static GetString getString_0;

	public void LTFjArhSgTvHJt(string JwcRUVYyNBOIb, HashSet<string> ZqvLBLcPvZxQW, out Dictionary<ulong, FGNTLXNznfbNyvZ> TEnqJKTytlxR, out Dictionary<ulong, FGNTLXNznfbNyvZ> RrnbGhQFbwur)
	{
		RrnbGhQFbwur = new Dictionary<ulong, FGNTLXNznfbNyvZ>();
		TEnqJKTytlxR = new Dictionary<ulong, FGNTLXNznfbNyvZ>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr xwIRvzuemyA = IntPtr.Zero;
		try
		{
			cpywIIQbsnDAuuUg(JwcRUVYyNBOIb, RrnbGhQFbwur);
			aAWDNLeRcHp(JwcRUVYyNBOIb, out xwIRvzuemyA);
			wkcqfuGaNAkwg(xwIRvzuemyA);
			mgAFtDxAfCpNT(ref intptr_, xwIRvzuemyA);
			sVmmvVccrFaI(intptr_, ref TEnqJKTytlxR, ZqvLBLcPvZxQW, RrnbGhQFbwur, xwIRvzuemyA);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107378039), ex);
		}
		finally
		{
			if (xwIRvzuemyA.ToInt32() != -1)
			{
				idAtkyEmuMh.CloseHandle(xwIRvzuemyA);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void cpywIIQbsnDAuuUg(string string_0, Dictionary<ulong, FGNTLXNznfbNyvZ> dictionary_0)
	{
		string text = getString_0(107378002) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = idAtkyEmuMh.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			idAtkyEmuMh.aCCyXrIDNIIA zTubMuNrkYnh = default(idAtkyEmuMh.aCCyXrIDNIIA);
			if (idAtkyEmuMh.GetFileInformationByHandle(intPtr, out zTubMuNrkYnh))
			{
				ulong num = zTubMuNrkYnh.ZEGoiZNEfT;
				ulong key = (num << 32) | zTubMuNrkYnh.yCfvgeWvXkCGvUN;
				FGNTLXNznfbNyvZ value = new FGNTLXNznfbNyvZ(text, 0uL);
				dictionary_0.Add(key, value);
			}
			idAtkyEmuMh.CloseHandle(intPtr);
		}
	}

	private void aAWDNLeRcHp(string eiRtctIfTdkjc, out IntPtr xwIRvzuemyA)
	{
		string string_ = getString_0(107378002) + eiRtctIfTdkjc;
		xwIRvzuemyA = idAtkyEmuMh.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void sVmmvVccrFaI(IntPtr intptr_0, ref Dictionary<ulong, FGNTLXNznfbNyvZ> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, FGNTLXNznfbNyvZ> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		idAtkyEmuMh.ZeroMemory(intPtr, 65544);
		uint QmDdVGubpBHMt = 0u;
		while (idAtkyEmuMh.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(idAtkyEmuMh.zivfMtfkAVIeL), intPtr, 65544, out QmDdVGubpBHMt, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (QmDdVGubpBHMt > 60)
			{
				idAtkyEmuMh.xbHcFvskYjo xbHcFvskYjo = new idAtkyEmuMh.xbHcFvskYjo(intptr_2);
				if ((xbHcFvskYjo.WcoObavgWpzA & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(xbHcFvskYjo.ZTnLhzRlRY))
					{
						throw new Exception(string.Format(getString_0(107377961), xbHcFvskYjo.ZTnLhzRlRY, xbHcFvskYjo.MzTuIXetSeOX));
					}
					dictionary_1.Add(xbHcFvskYjo.ZTnLhzRlRY, new FGNTLXNznfbNyvZ(xbHcFvskYjo.MzTuIXetSeOX, xbHcFvskYjo.NMeqFFAvHc));
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
							dictionary_0.Add(xbHcFvskYjo.ZTnLhzRlRY, new FGNTLXNznfbNyvZ(xbHcFvskYjo.MzTuIXetSeOX, xbHcFvskYjo.NMeqFFAvHc));
						}
						else
						{
							FGNTLXNznfbNyvZ fGNTLXNznfbNyvZ = dictionary_0[xbHcFvskYjo.ZTnLhzRlRY];
							if (string.Compare(xbHcFvskYjo.MzTuIXetSeOX, fGNTLXNznfbNyvZ.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107377924), xbHcFvskYjo.ZTnLhzRlRY, xbHcFvskYjo.MzTuIXetSeOX, fGNTLXNznfbNyvZ.Name);
								throw new Exception(string.Format(getString_0(107377961), xbHcFvskYjo.ZTnLhzRlRY, xbHcFvskYjo.MzTuIXetSeOX));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + xbHcFvskYjo.CoUKeocLqXUlCDDW);
				QmDdVGubpBHMt -= xbHcFvskYjo.CoUKeocLqXUlCDDW;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void wkcqfuGaNAkwg(IntPtr intptr_0)
	{
		idAtkyEmuMh.nMYQqzFSUhco structure = default(idAtkyEmuMh.nMYQqzFSUhco);
		structure.aVdWFhTFwZ = 8388608uL;
		structure.CTyZxJKAuSZiZ = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		idAtkyEmuMh.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		idAtkyEmuMh.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void mgAFtDxAfCpNT(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint DryxggKKxgYt = 0u;
		idAtkyEmuMh.tciTSHdqCSk DPUteoODapDwKm = default(idAtkyEmuMh.tciTSHdqCSk);
		if (idAtkyEmuMh.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out DPUteoODapDwKm, sizeof(idAtkyEmuMh.tciTSHdqCSk), out DryxggKKxgYt, IntPtr.Zero))
		{
			idAtkyEmuMh.zivfMtfkAVIeL structure = default(idAtkyEmuMh.zivfMtfkAVIeL);
			structure.HybLTfNPnza = 0uL;
			structure.CiPuhbXPpdLZn = 0L;
			structure.OmHIjiLmeRru = DPUteoODapDwKm.QIQPFlEFaigCkW;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			idAtkyEmuMh.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static tjzTpApWfmt()
	{
		Strings.CreateGetStringDelegate(typeof(tjzTpApWfmt));
	}
}
