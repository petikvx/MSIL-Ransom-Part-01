using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ODusMbbiJwu;

public sealed class mDRQtbtneNnH
{
	[NonSerialized]
	internal static GetString getString_0;

	public void mmIxvLuDLRy(string HDREWrJspPrrv, HashSet<string> UsvEcUYkCxLGDx, out Dictionary<ulong, DECIbyuBTBupOG> QRTknIjEsFh, out Dictionary<ulong, DECIbyuBTBupOG> evPQwQrnNwbIH)
	{
		evPQwQrnNwbIH = new Dictionary<ulong, DECIbyuBTBupOG>();
		QRTknIjEsFh = new Dictionary<ulong, DECIbyuBTBupOG>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr XgbnGHSxyaUfYAG = IntPtr.Zero;
		try
		{
			QUZNeVvUKCmwD(HDREWrJspPrrv, evPQwQrnNwbIH);
			cgooDdReQwj(HDREWrJspPrrv, out XgbnGHSxyaUfYAG);
			cNmhMzCvAnaKs(XgbnGHSxyaUfYAG);
			tNKopeVsdvPs(ref intptr_, XgbnGHSxyaUfYAG);
			PpSSNRKmwXi(intptr_, ref QRTknIjEsFh, UsvEcUYkCxLGDx, evPQwQrnNwbIH, XgbnGHSxyaUfYAG);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107401042), ex);
		}
		finally
		{
			if (XgbnGHSxyaUfYAG.ToInt32() != -1)
			{
				SBCZoIlGDmz.CloseHandle(XgbnGHSxyaUfYAG);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void QUZNeVvUKCmwD(string string_0, Dictionary<ulong, DECIbyuBTBupOG> dictionary_0)
	{
		string text = getString_0(107401005) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = SBCZoIlGDmz.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			SBCZoIlGDmz.CubwzvkWIPTB doebuiQkCADHtY = default(SBCZoIlGDmz.CubwzvkWIPTB);
			if (SBCZoIlGDmz.GetFileInformationByHandle(intPtr, out doebuiQkCADHtY))
			{
				ulong num = doebuiQkCADHtY.hKfUyCUcKJNfSf;
				ulong key = (num << 32) | doebuiQkCADHtY.nZulTsOYgus;
				DECIbyuBTBupOG value = new DECIbyuBTBupOG(text, 0uL);
				dictionary_0.Add(key, value);
			}
			SBCZoIlGDmz.CloseHandle(intPtr);
		}
	}

	private void cgooDdReQwj(string QVTkvrCMRbIAl, out IntPtr XgbnGHSxyaUfYAG)
	{
		string string_ = getString_0(107401005) + QVTkvrCMRbIAl;
		XgbnGHSxyaUfYAG = SBCZoIlGDmz.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void PpSSNRKmwXi(IntPtr intptr_0, ref Dictionary<ulong, DECIbyuBTBupOG> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, DECIbyuBTBupOG> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		SBCZoIlGDmz.ZeroMemory(intPtr, 65544);
		uint SqaRiwEtSnTZ = 0u;
		while (SBCZoIlGDmz.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(SBCZoIlGDmz.rTHjiaLYyD), intPtr, 65544, out SqaRiwEtSnTZ, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (SqaRiwEtSnTZ > 60)
			{
				SBCZoIlGDmz.fejpCzYdChS fejpCzYdChS = new SBCZoIlGDmz.fejpCzYdChS(intptr_2);
				if ((fejpCzYdChS.FZLzkpXzMrH & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(fejpCzYdChS.nKpamWBceobrnl))
					{
						throw new Exception(string.Format(getString_0(107401476), fejpCzYdChS.nKpamWBceobrnl, fejpCzYdChS.DgsZHjXXnspHU));
					}
					dictionary_1.Add(fejpCzYdChS.nKpamWBceobrnl, new DECIbyuBTBupOG(fejpCzYdChS.DgsZHjXXnspHU, fejpCzYdChS.oZYFurtQScYLm));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(fejpCzYdChS.DgsZHjXXnspHU);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(fejpCzYdChS.nKpamWBceobrnl))
						{
							dictionary_0.Add(fejpCzYdChS.nKpamWBceobrnl, new DECIbyuBTBupOG(fejpCzYdChS.DgsZHjXXnspHU, fejpCzYdChS.oZYFurtQScYLm));
						}
						else
						{
							DECIbyuBTBupOG dECIbyuBTBupOG = dictionary_0[fejpCzYdChS.nKpamWBceobrnl];
							if (string.Compare(fejpCzYdChS.DgsZHjXXnspHU, dECIbyuBTBupOG.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107401439), fejpCzYdChS.nKpamWBceobrnl, fejpCzYdChS.DgsZHjXXnspHU, dECIbyuBTBupOG.Name);
								throw new Exception(string.Format(getString_0(107401476), fejpCzYdChS.nKpamWBceobrnl, fejpCzYdChS.DgsZHjXXnspHU));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + fejpCzYdChS.CfJrBviJMbIqxK);
				SqaRiwEtSnTZ -= fejpCzYdChS.CfJrBviJMbIqxK;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void cNmhMzCvAnaKs(IntPtr intptr_0)
	{
		SBCZoIlGDmz.nBmbQJHmOecY structure = default(SBCZoIlGDmz.nBmbQJHmOecY);
		structure.kWCbJvQLkGnsFHSCp = 8388608uL;
		structure.YzkfDFgeMNyJQ = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		SBCZoIlGDmz.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		SBCZoIlGDmz.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void tNKopeVsdvPs(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint iyjAAGUWpOUl = 0u;
		SBCZoIlGDmz.hBVPuLfOjuOcV kjbIEmiLrUIX = default(SBCZoIlGDmz.hBVPuLfOjuOcV);
		if (SBCZoIlGDmz.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out kjbIEmiLrUIX, sizeof(SBCZoIlGDmz.hBVPuLfOjuOcV), out iyjAAGUWpOUl, IntPtr.Zero))
		{
			SBCZoIlGDmz.rTHjiaLYyD structure = default(SBCZoIlGDmz.rTHjiaLYyD);
			structure.IkOHDZnFxMNas = 0uL;
			structure.unMijPBSQiVLRANx = 0L;
			structure.TMokUrCezJ = kjbIEmiLrUIX.WJQDCBijJNf;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			SBCZoIlGDmz.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static mDRQtbtneNnH()
	{
		Strings.CreateGetStringDelegate(typeof(mDRQtbtneNnH));
	}
}
