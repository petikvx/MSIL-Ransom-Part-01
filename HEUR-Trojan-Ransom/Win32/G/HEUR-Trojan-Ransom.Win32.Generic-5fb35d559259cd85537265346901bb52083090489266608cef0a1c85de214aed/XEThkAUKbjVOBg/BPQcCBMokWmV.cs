using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace XEThkAUKbjVOBg;

public sealed class BPQcCBMokWmV
{
	[NonSerialized]
	internal static GetString getString_0;

	public void hFkyJOpOtZP(string zuYUItBvzxtP, HashSet<string> ZcerkoziDz, out Dictionary<ulong, WCXDFAuCSQrWLB> SIQgLyXKAP, out Dictionary<ulong, WCXDFAuCSQrWLB> YgMdlhGuvPvW)
	{
		YgMdlhGuvPvW = new Dictionary<ulong, WCXDFAuCSQrWLB>();
		SIQgLyXKAP = new Dictionary<ulong, WCXDFAuCSQrWLB>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr ZGUflxMSiUQFij = IntPtr.Zero;
		try
		{
			mjwPGECXLkV(zuYUItBvzxtP, YgMdlhGuvPvW);
			JfBQtMEpNulEV(zuYUItBvzxtP, out ZGUflxMSiUQFij);
			eusqPJGvqHGTQ(ZGUflxMSiUQFij);
			yFDnPpQQjY(ref intptr_, ZGUflxMSiUQFij);
			lWLImxRfRbklf(intptr_, ref SIQgLyXKAP, ZcerkoziDz, YgMdlhGuvPvW, ZGUflxMSiUQFij);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107194855), ex);
		}
		finally
		{
			if (ZGUflxMSiUQFij.ToInt32() != -1)
			{
				gubChQdYBDB.CloseHandle(ZGUflxMSiUQFij);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void mjwPGECXLkV(string string_0, Dictionary<ulong, WCXDFAuCSQrWLB> dictionary_0)
	{
		string text = getString_0(107194818) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = gubChQdYBDB.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			gubChQdYBDB.oHdjhkOVwGCCM uECpPAnzrEwJI = default(gubChQdYBDB.oHdjhkOVwGCCM);
			if (gubChQdYBDB.GetFileInformationByHandle(intPtr, out uECpPAnzrEwJI))
			{
				ulong num = uECpPAnzrEwJI.jfzytndjZE;
				ulong key = (num << 32) | uECpPAnzrEwJI.YRgLBeSzbVgVN;
				WCXDFAuCSQrWLB value = new WCXDFAuCSQrWLB(text, 0uL);
				dictionary_0.Add(key, value);
			}
			gubChQdYBDB.CloseHandle(intPtr);
		}
	}

	private void JfBQtMEpNulEV(string ydeYGehvwbzd, out IntPtr ZGUflxMSiUQFij)
	{
		string string_ = getString_0(107194818) + ydeYGehvwbzd;
		ZGUflxMSiUQFij = gubChQdYBDB.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void lWLImxRfRbklf(IntPtr intptr_0, ref Dictionary<ulong, WCXDFAuCSQrWLB> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, WCXDFAuCSQrWLB> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		gubChQdYBDB.ZeroMemory(intPtr, 65544);
		uint ICxyPEsNKrBE = 0u;
		while (gubChQdYBDB.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(gubChQdYBDB.chuFpyNmfWA), intPtr, 65544, out ICxyPEsNKrBE, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (ICxyPEsNKrBE > 60)
			{
				gubChQdYBDB.XgQhJUzYoH xgQhJUzYoH = new gubChQdYBDB.XgQhJUzYoH(intptr_2);
				if ((xgQhJUzYoH.nHUOPrUXrEpmwBcGl & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(xgQhJUzYoH.QRDEQjwcfPYiOv))
					{
						throw new Exception(string.Format(getString_0(107194841), xgQhJUzYoH.QRDEQjwcfPYiOv, xgQhJUzYoH.IpZCOYdfewCC));
					}
					dictionary_1.Add(xgQhJUzYoH.QRDEQjwcfPYiOv, new WCXDFAuCSQrWLB(xgQhJUzYoH.IpZCOYdfewCC, xgQhJUzYoH.rWHQYsfdUEFeY));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(xgQhJUzYoH.IpZCOYdfewCC);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(xgQhJUzYoH.QRDEQjwcfPYiOv))
						{
							dictionary_0.Add(xgQhJUzYoH.QRDEQjwcfPYiOv, new WCXDFAuCSQrWLB(xgQhJUzYoH.IpZCOYdfewCC, xgQhJUzYoH.rWHQYsfdUEFeY));
						}
						else
						{
							WCXDFAuCSQrWLB wCXDFAuCSQrWLB = dictionary_0[xgQhJUzYoH.QRDEQjwcfPYiOv];
							if (string.Compare(xgQhJUzYoH.IpZCOYdfewCC, wCXDFAuCSQrWLB.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107194804), xgQhJUzYoH.QRDEQjwcfPYiOv, xgQhJUzYoH.IpZCOYdfewCC, wCXDFAuCSQrWLB.Name);
								throw new Exception(string.Format(getString_0(107194841), xgQhJUzYoH.QRDEQjwcfPYiOv, xgQhJUzYoH.IpZCOYdfewCC));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + xgQhJUzYoH.RETyOirGiJLa);
				ICxyPEsNKrBE -= xgQhJUzYoH.RETyOirGiJLa;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void eusqPJGvqHGTQ(IntPtr intptr_0)
	{
		gubChQdYBDB.iBoDdXKSIpod structure = default(gubChQdYBDB.iBoDdXKSIpod);
		structure.UYagRyoCHvS = 8388608uL;
		structure.WKVendYxiSefVF = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		gubChQdYBDB.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		gubChQdYBDB.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void yFDnPpQQjY(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint GEplNUQIAknlQEDk = 0u;
		gubChQdYBDB.TpusGaAGVrxWe sXZiNWxwJD = default(gubChQdYBDB.TpusGaAGVrxWe);
		if (gubChQdYBDB.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out sXZiNWxwJD, sizeof(gubChQdYBDB.TpusGaAGVrxWe), out GEplNUQIAknlQEDk, IntPtr.Zero))
		{
			gubChQdYBDB.chuFpyNmfWA structure = default(gubChQdYBDB.chuFpyNmfWA);
			structure.xjucYlkJcXXuj = 0uL;
			structure.aDoTuHOXMgqOWUyj = 0L;
			structure.aufmEwJxDU = sXZiNWxwJD.CTqOhXgcvly;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			gubChQdYBDB.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static BPQcCBMokWmV()
	{
		Strings.CreateGetStringDelegate(typeof(BPQcCBMokWmV));
	}
}
