using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace XmVNSVPzUwATMS;

public sealed class VyLkIyFTJp
{
	[NonSerialized]
	internal static GetString getString_0;

	public void PofSZHeQpiMf(string cQppxEpjoDKA, HashSet<string> UwpKKrObXfs, out Dictionary<ulong, wNutgPcrslPuK> KJWLssfJnJFct, out Dictionary<ulong, wNutgPcrslPuK> VvNuCOciGub)
	{
		VvNuCOciGub = new Dictionary<ulong, wNutgPcrslPuK>();
		KJWLssfJnJFct = new Dictionary<ulong, wNutgPcrslPuK>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr YUgWYDjLTclnho = IntPtr.Zero;
		try
		{
			GcKKwqUhVBLxlvey(cQppxEpjoDKA, VvNuCOciGub);
			PPEtKROQraiFW(cQppxEpjoDKA, out YUgWYDjLTclnho);
			JexkSEuKnuT(YUgWYDjLTclnho);
			avIpiAmJHEBJ(ref intptr_, YUgWYDjLTclnho);
			AdrhqRUGshIt(intptr_, ref KJWLssfJnJFct, UwpKKrObXfs, VvNuCOciGub, YUgWYDjLTclnho);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107407398), ex);
		}
		finally
		{
			if (YUgWYDjLTclnho.ToInt32() != -1)
			{
				STEMjHlNYc.CloseHandle(YUgWYDjLTclnho);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void GcKKwqUhVBLxlvey(string string_0, Dictionary<ulong, wNutgPcrslPuK> dictionary_0)
	{
		string text = getString_0(107407393) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = STEMjHlNYc.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			STEMjHlNYc.MuTcAgRDAnHNUxy GeVsNNwFrmzfVbD = default(STEMjHlNYc.MuTcAgRDAnHNUxy);
			if (STEMjHlNYc.GetFileInformationByHandle(intPtr, out GeVsNNwFrmzfVbD))
			{
				ulong num = GeVsNNwFrmzfVbD.QlJYMaQBKOSDX;
				ulong key = (num << 32) | GeVsNNwFrmzfVbD.oFQGgccFOXLNn;
				wNutgPcrslPuK value = new wNutgPcrslPuK(text, 0uL);
				dictionary_0.Add(key, value);
			}
			STEMjHlNYc.CloseHandle(intPtr);
		}
	}

	private void PPEtKROQraiFW(string yrfNMllKtzjQ, out IntPtr YUgWYDjLTclnho)
	{
		string string_ = getString_0(107407393) + yrfNMllKtzjQ;
		YUgWYDjLTclnho = STEMjHlNYc.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void AdrhqRUGshIt(IntPtr intptr_0, ref Dictionary<ulong, wNutgPcrslPuK> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, wNutgPcrslPuK> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		STEMjHlNYc.ZeroMemory(intPtr, 65544);
		uint FyacPFAfAWeL = 0u;
		while (STEMjHlNYc.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(STEMjHlNYc.fNsNMpjOkyvc), intPtr, 65544, out FyacPFAfAWeL, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (FyacPFAfAWeL > 60)
			{
				STEMjHlNYc.FYXPcsNiTYkqb fYXPcsNiTYkqb = new STEMjHlNYc.FYXPcsNiTYkqb(intptr_2);
				if (0 != (fYXPcsNiTYkqb.LJvjOShXDc & 0x10))
				{
					if (dictionary_1.ContainsKey(fYXPcsNiTYkqb.KRcxNYHUnXHOHo))
					{
						throw new Exception(string.Format(getString_0(107407384), fYXPcsNiTYkqb.KRcxNYHUnXHOHo, fYXPcsNiTYkqb.toQbNbNaLAjJNt));
					}
					dictionary_1.Add(fYXPcsNiTYkqb.KRcxNYHUnXHOHo, new wNutgPcrslPuK(fYXPcsNiTYkqb.toQbNbNaLAjJNt, fYXPcsNiTYkqb.hNewLeFEOnTF));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(fYXPcsNiTYkqb.toQbNbNaLAjJNt);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(fYXPcsNiTYkqb.KRcxNYHUnXHOHo))
						{
							dictionary_0.Add(fYXPcsNiTYkqb.KRcxNYHUnXHOHo, new wNutgPcrslPuK(fYXPcsNiTYkqb.toQbNbNaLAjJNt, fYXPcsNiTYkqb.hNewLeFEOnTF));
						}
						else
						{
							wNutgPcrslPuK wNutgPcrslPuK2 = dictionary_0[fYXPcsNiTYkqb.KRcxNYHUnXHOHo];
							if (0 != string.Compare(fYXPcsNiTYkqb.toQbNbNaLAjJNt, wNutgPcrslPuK2.Name, ignoreCase: true))
							{
								Console.WriteLine(getString_0(107406835), fYXPcsNiTYkqb.KRcxNYHUnXHOHo, fYXPcsNiTYkqb.toQbNbNaLAjJNt, wNutgPcrslPuK2.Name);
								throw new Exception(string.Format(getString_0(107407384), fYXPcsNiTYkqb.KRcxNYHUnXHOHo, fYXPcsNiTYkqb.toQbNbNaLAjJNt));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + fYXPcsNiTYkqb.pAunGxMtfHH);
				FyacPFAfAWeL -= fYXPcsNiTYkqb.pAunGxMtfHH;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void JexkSEuKnuT(IntPtr intptr_0)
	{
		STEMjHlNYc.CizRIIOsoHSJrDb structure = default(STEMjHlNYc.CizRIIOsoHSJrDb);
		structure.EfphmoMNtVXuIm = 8388608uL;
		structure.njuDjKIolHjo = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		STEMjHlNYc.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		STEMjHlNYc.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void avIpiAmJHEBJ(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint txBMOEDRoAzTbV = 0u;
		STEMjHlNYc.UnOsVnnGMoq CdPbnMdOzLsIwS = default(STEMjHlNYc.UnOsVnnGMoq);
		if (STEMjHlNYc.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out CdPbnMdOzLsIwS, sizeof(STEMjHlNYc.UnOsVnnGMoq), out txBMOEDRoAzTbV, IntPtr.Zero))
		{
			STEMjHlNYc.fNsNMpjOkyvc structure = default(STEMjHlNYc.fNsNMpjOkyvc);
			structure.SjGdCNZFzboXo = 0uL;
			structure.AnwLOtoSQmz = 0L;
			structure.BABsYbTXPn = CdPbnMdOzLsIwS.wizOtdLlaNgxi;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			STEMjHlNYc.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static VyLkIyFTJp()
	{
		Strings.CreateGetStringDelegate(typeof(VyLkIyFTJp));
	}
}
