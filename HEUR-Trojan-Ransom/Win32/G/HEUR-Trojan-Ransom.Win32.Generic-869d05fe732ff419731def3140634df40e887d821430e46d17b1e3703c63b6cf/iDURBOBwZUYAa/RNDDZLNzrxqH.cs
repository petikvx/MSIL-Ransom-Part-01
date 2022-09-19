using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace iDURBOBwZUYAa;

public sealed class RNDDZLNzrxqH
{
	[NonSerialized]
	internal static GetString getString_0;

	public void PRrEdgtFSjTYJSSzK(string DmlbitzpfLtoUT, HashSet<string> bfmiiBXhnkj, out Dictionary<ulong, ixsxKRRPgfo> MBMoStRMYrQn, out Dictionary<ulong, ixsxKRRPgfo> LofjdQYjiKHXnm)
	{
		LofjdQYjiKHXnm = new Dictionary<ulong, ixsxKRRPgfo>();
		MBMoStRMYrQn = new Dictionary<ulong, ixsxKRRPgfo>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr kMiAMLSdbPN = IntPtr.Zero;
		try
		{
			GwWwISkRkCuOx(DmlbitzpfLtoUT, LofjdQYjiKHXnm);
			ZzAOJTetUsEQnB(DmlbitzpfLtoUT, out kMiAMLSdbPN);
			gjIFRDQpLys(kMiAMLSdbPN);
			imoLWoyCfaI(ref intptr_, kMiAMLSdbPN);
			bVzvFsQCoqrRj(intptr_, ref MBMoStRMYrQn, bfmiiBXhnkj, LofjdQYjiKHXnm, kMiAMLSdbPN);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107377008), ex);
		}
		finally
		{
			if (kMiAMLSdbPN.ToInt32() != -1)
			{
				GhnPTxRSOqSWsA.CloseHandle(kMiAMLSdbPN);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void GwWwISkRkCuOx(string string_0, Dictionary<ulong, ixsxKRRPgfo> dictionary_0)
	{
		string text = getString_0(107376971) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = GhnPTxRSOqSWsA.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			GhnPTxRSOqSWsA.MUvPxLJUEpDxlSChz boKdIcmnnnjpT = default(GhnPTxRSOqSWsA.MUvPxLJUEpDxlSChz);
			if (GhnPTxRSOqSWsA.GetFileInformationByHandle(intPtr, out boKdIcmnnnjpT))
			{
				ulong num = boKdIcmnnnjpT.QbiYXlLIgdYJv;
				ulong key = (num << 32) | boKdIcmnnnjpT.tcbKojrcou;
				ixsxKRRPgfo value = new ixsxKRRPgfo(text, 0uL);
				dictionary_0.Add(key, value);
			}
			GhnPTxRSOqSWsA.CloseHandle(intPtr);
		}
	}

	private void ZzAOJTetUsEQnB(string GqWZKxzrWTiC, out IntPtr kMiAMLSdbPN)
	{
		string string_ = getString_0(107376971) + GqWZKxzrWTiC;
		kMiAMLSdbPN = GhnPTxRSOqSWsA.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void bVzvFsQCoqrRj(IntPtr intptr_0, ref Dictionary<ulong, ixsxKRRPgfo> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, ixsxKRRPgfo> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		GhnPTxRSOqSWsA.ZeroMemory(intPtr, 65544);
		uint PCBpPPsSuYUmg = 0u;
		while (GhnPTxRSOqSWsA.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(GhnPTxRSOqSWsA.mitzhZbEFSV), intPtr, 65544, out PCBpPPsSuYUmg, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (PCBpPPsSuYUmg > 60)
			{
				GhnPTxRSOqSWsA.ZdDpizzlBtxF zdDpizzlBtxF = new GhnPTxRSOqSWsA.ZdDpizzlBtxF(intptr_2);
				if ((zdDpizzlBtxF.jZBOCZRnxyFp & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(zdDpizzlBtxF.WPLQuTzteXoAv))
					{
						throw new Exception(string.Format(getString_0(107376930), zdDpizzlBtxF.WPLQuTzteXoAv, zdDpizzlBtxF.MLFJzzTLoFSlh));
					}
					dictionary_1.Add(zdDpizzlBtxF.WPLQuTzteXoAv, new ixsxKRRPgfo(zdDpizzlBtxF.MLFJzzTLoFSlh, zdDpizzlBtxF.WPesGcRbXzG));
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
							dictionary_0.Add(zdDpizzlBtxF.WPLQuTzteXoAv, new ixsxKRRPgfo(zdDpizzlBtxF.MLFJzzTLoFSlh, zdDpizzlBtxF.WPesGcRbXzG));
						}
						else
						{
							ixsxKRRPgfo ixsxKRRPgfo2 = dictionary_0[zdDpizzlBtxF.WPLQuTzteXoAv];
							if (string.Compare(zdDpizzlBtxF.MLFJzzTLoFSlh, ixsxKRRPgfo2.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107376893), zdDpizzlBtxF.WPLQuTzteXoAv, zdDpizzlBtxF.MLFJzzTLoFSlh, ixsxKRRPgfo2.Name);
								throw new Exception(string.Format(getString_0(107376930), zdDpizzlBtxF.WPLQuTzteXoAv, zdDpizzlBtxF.MLFJzzTLoFSlh));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + zdDpizzlBtxF.IuoSKnNcFIrVJjl);
				PCBpPPsSuYUmg -= zdDpizzlBtxF.IuoSKnNcFIrVJjl;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void gjIFRDQpLys(IntPtr intptr_0)
	{
		GhnPTxRSOqSWsA.aatuXRKJvlSDi structure = default(GhnPTxRSOqSWsA.aatuXRKJvlSDi);
		structure.yeIhkMjYvC = 8388608uL;
		structure.qLppcpThZcJvQeXh = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		GhnPTxRSOqSWsA.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		GhnPTxRSOqSWsA.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void imoLWoyCfaI(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint gtUSAFbTNstv = 0u;
		GhnPTxRSOqSWsA.aUwHlTGbKfOUN NGBqBmLGbWxg = default(GhnPTxRSOqSWsA.aUwHlTGbKfOUN);
		if (GhnPTxRSOqSWsA.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out NGBqBmLGbWxg, sizeof(GhnPTxRSOqSWsA.aUwHlTGbKfOUN), out gtUSAFbTNstv, IntPtr.Zero))
		{
			GhnPTxRSOqSWsA.mitzhZbEFSV structure = default(GhnPTxRSOqSWsA.mitzhZbEFSV);
			structure.zMrMvBfjEim = 0uL;
			structure.rtWDygDlPvMQ = 0L;
			structure.DkoIqPNGcPWq = NGBqBmLGbWxg.qtEMjEovhSSe;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			GhnPTxRSOqSWsA.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static RNDDZLNzrxqH()
	{
		Strings.CreateGetStringDelegate(typeof(RNDDZLNzrxqH));
	}
}
