using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ZezoEdMCwYjXbN;

public sealed class XVxmwajqDcnCPbk
{
	[NonSerialized]
	internal static GetString getString_0;

	public void TCXyaXBBsUyDcNT(string wUHDRwWULSsKG, HashSet<string> oRwsLnPgRTjA, out Dictionary<ulong, PxVrqMmyWm> ZOiKzZcWAUT, out Dictionary<ulong, PxVrqMmyWm> BfaSWtxRhxXe)
	{
		BfaSWtxRhxXe = new Dictionary<ulong, PxVrqMmyWm>();
		ZOiKzZcWAUT = new Dictionary<ulong, PxVrqMmyWm>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr IojCslzblnUpuYs = IntPtr.Zero;
		try
		{
			eUtREIWCsWL(wUHDRwWULSsKG, BfaSWtxRhxXe);
			HrWfdYPiuX(wUHDRwWULSsKG, out IojCslzblnUpuYs);
			PCDNLSexDuQCFJ(IojCslzblnUpuYs);
			nuLlBMVVmkA(ref intptr_, IojCslzblnUpuYs);
			sAxsGLesgIU(intptr_, ref ZOiKzZcWAUT, oRwsLnPgRTjA, BfaSWtxRhxXe, IojCslzblnUpuYs);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107398290), ex);
		}
		finally
		{
			if (IojCslzblnUpuYs.ToInt32() != -1)
			{
				PKFVerKCvmGqCH.CloseHandle(IojCslzblnUpuYs);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void eUtREIWCsWL(string string_0, Dictionary<ulong, PxVrqMmyWm> dictionary_0)
	{
		string text = getString_0(107398253) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = PKFVerKCvmGqCH.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			PKFVerKCvmGqCH.jSBnqBCSUPjzi KVwuFpwOztpq = default(PKFVerKCvmGqCH.jSBnqBCSUPjzi);
			if (PKFVerKCvmGqCH.GetFileInformationByHandle(intPtr, out KVwuFpwOztpq))
			{
				ulong num = KVwuFpwOztpq.dkKwLcnhOaTir;
				ulong key = (num << 32) | KVwuFpwOztpq.AUqBxgVifkvcH;
				PxVrqMmyWm value = new PxVrqMmyWm(text, 0uL);
				dictionary_0.Add(key, value);
			}
			PKFVerKCvmGqCH.CloseHandle(intPtr);
		}
	}

	private void HrWfdYPiuX(string myueUhsARBNjR, out IntPtr IojCslzblnUpuYs)
	{
		string string_ = getString_0(107398253) + myueUhsARBNjR;
		IojCslzblnUpuYs = PKFVerKCvmGqCH.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void sAxsGLesgIU(IntPtr intptr_0, ref Dictionary<ulong, PxVrqMmyWm> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, PxVrqMmyWm> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		PKFVerKCvmGqCH.ZeroMemory(intPtr, 65544);
		uint yGSxocljQGsmUPsB = 0u;
		while (PKFVerKCvmGqCH.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(PKFVerKCvmGqCH.eRGkKkkUCKGwSUg), intPtr, 65544, out yGSxocljQGsmUPsB, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (yGSxocljQGsmUPsB > 60)
			{
				PKFVerKCvmGqCH.kdQRtaytpsrM kdQRtaytpsrM = new PKFVerKCvmGqCH.kdQRtaytpsrM(intptr_2);
				if ((kdQRtaytpsrM.nJzAxuynohj & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(kdQRtaytpsrM.AZYIfuTbrxnNA))
					{
						throw new Exception(string.Format(getString_0(107398212), kdQRtaytpsrM.AZYIfuTbrxnNA, kdQRtaytpsrM.vWNTzKXgKiWE));
					}
					dictionary_1.Add(kdQRtaytpsrM.AZYIfuTbrxnNA, new PxVrqMmyWm(kdQRtaytpsrM.vWNTzKXgKiWE, kdQRtaytpsrM.TvQWyQLDsrMF));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(kdQRtaytpsrM.vWNTzKXgKiWE);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(kdQRtaytpsrM.AZYIfuTbrxnNA))
						{
							dictionary_0.Add(kdQRtaytpsrM.AZYIfuTbrxnNA, new PxVrqMmyWm(kdQRtaytpsrM.vWNTzKXgKiWE, kdQRtaytpsrM.TvQWyQLDsrMF));
						}
						else
						{
							PxVrqMmyWm pxVrqMmyWm = dictionary_0[kdQRtaytpsrM.AZYIfuTbrxnNA];
							if (string.Compare(kdQRtaytpsrM.vWNTzKXgKiWE, pxVrqMmyWm.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107398175), kdQRtaytpsrM.AZYIfuTbrxnNA, kdQRtaytpsrM.vWNTzKXgKiWE, pxVrqMmyWm.Name);
								throw new Exception(string.Format(getString_0(107398212), kdQRtaytpsrM.AZYIfuTbrxnNA, kdQRtaytpsrM.vWNTzKXgKiWE));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + kdQRtaytpsrM.OfnNFahXLhUBuepl);
				yGSxocljQGsmUPsB -= kdQRtaytpsrM.OfnNFahXLhUBuepl;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void PCDNLSexDuQCFJ(IntPtr intptr_0)
	{
		PKFVerKCvmGqCH.DIXYIxfbthYD structure = default(PKFVerKCvmGqCH.DIXYIxfbthYD);
		structure.HwbdxgxRgIFLC = 8388608uL;
		structure.nPDualsIFmmH = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		PKFVerKCvmGqCH.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		PKFVerKCvmGqCH.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void nuLlBMVVmkA(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint DCylEWYgoylv = 0u;
		PKFVerKCvmGqCH.sYWKcPdDlyg mimMSigsGcaM = default(PKFVerKCvmGqCH.sYWKcPdDlyg);
		if (PKFVerKCvmGqCH.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out mimMSigsGcaM, sizeof(PKFVerKCvmGqCH.sYWKcPdDlyg), out DCylEWYgoylv, IntPtr.Zero))
		{
			PKFVerKCvmGqCH.eRGkKkkUCKGwSUg structure = default(PKFVerKCvmGqCH.eRGkKkkUCKGwSUg);
			structure.qANUUCvkKqUH = 0uL;
			structure.yvdxcxapTGNu = 0L;
			structure.OGlCHViMiJKia = mimMSigsGcaM.gIstmVZGisLW;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			PKFVerKCvmGqCH.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static XVxmwajqDcnCPbk()
	{
		Strings.CreateGetStringDelegate(typeof(XVxmwajqDcnCPbk));
	}
}
