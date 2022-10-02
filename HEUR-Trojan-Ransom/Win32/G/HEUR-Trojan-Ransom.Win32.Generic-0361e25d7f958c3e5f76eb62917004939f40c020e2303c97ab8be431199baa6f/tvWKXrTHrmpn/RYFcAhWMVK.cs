using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace tvWKXrTHrmpn;

public sealed class RYFcAhWMVK
{
	[NonSerialized]
	internal static GetString getString_0;

	public void uTtOfpheHvEJ(string VjwrDeDCKbgGY, HashSet<string> xAsqWfuakL, out Dictionary<ulong, bFlVsRFfhATc> WAlstrDHtSWxa, out Dictionary<ulong, bFlVsRFfhATc> rvFzUqobNlbW)
	{
		rvFzUqobNlbW = new Dictionary<ulong, bFlVsRFfhATc>();
		WAlstrDHtSWxa = new Dictionary<ulong, bFlVsRFfhATc>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr exUeDOitiL = IntPtr.Zero;
		try
		{
			uociiwbJJe(VjwrDeDCKbgGY, rvFzUqobNlbW);
			ypuhtWVceeys(VjwrDeDCKbgGY, out exUeDOitiL);
			xmTlISSebPAhTCSp(exUeDOitiL);
			jKXRskHsgLPQa(ref intptr_, exUeDOitiL);
			iueIoTDkWOCf(intptr_, ref WAlstrDHtSWxa, xAsqWfuakL, rvFzUqobNlbW, exUeDOitiL);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107462470), ex);
		}
		finally
		{
			if (exUeDOitiL.ToInt32() != -1)
			{
				wsLyyHKBptAa.CloseHandle(exUeDOitiL);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void uociiwbJJe(string string_0, Dictionary<ulong, bFlVsRFfhATc> dictionary_0)
	{
		string text = getString_0(107462433) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = wsLyyHKBptAa.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			wsLyyHKBptAa.ogaUVwaWXtVXrxP vJZUjHFluE = default(wsLyyHKBptAa.ogaUVwaWXtVXrxP);
			if (wsLyyHKBptAa.GetFileInformationByHandle(intPtr, out vJZUjHFluE))
			{
				ulong num = vJZUjHFluE.vJzFckwIfgX;
				ulong key = (num << 32) | vJZUjHFluE.hmbsJtrjyCKDz;
				bFlVsRFfhATc value = new bFlVsRFfhATc(text, 0uL);
				dictionary_0.Add(key, value);
			}
			wsLyyHKBptAa.CloseHandle(intPtr);
		}
	}

	private void ypuhtWVceeys(string FozpZgCqnrM, out IntPtr exUeDOitiL)
	{
		string string_ = getString_0(107462433) + FozpZgCqnrM;
		exUeDOitiL = wsLyyHKBptAa.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void iueIoTDkWOCf(IntPtr intptr_0, ref Dictionary<ulong, bFlVsRFfhATc> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, bFlVsRFfhATc> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		wsLyyHKBptAa.ZeroMemory(intPtr, 65544);
		uint MGncmtQRwTpU = 0u;
		while (wsLyyHKBptAa.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(wsLyyHKBptAa.gXobEdGdEmXupLs), intPtr, 65544, out MGncmtQRwTpU, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (MGncmtQRwTpU > 60)
			{
				wsLyyHKBptAa.yqzCFnTyclbNB yqzCFnTyclbNB = new wsLyyHKBptAa.yqzCFnTyclbNB(intptr_2);
				if ((yqzCFnTyclbNB.LBybEumoYQx & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(yqzCFnTyclbNB.azCjJrojbPrPvil))
					{
						throw new Exception(string.Format(getString_0(107462424), yqzCFnTyclbNB.azCjJrojbPrPvil, yqzCFnTyclbNB.WySkYESogcz));
					}
					dictionary_1.Add(yqzCFnTyclbNB.azCjJrojbPrPvil, new bFlVsRFfhATc(yqzCFnTyclbNB.WySkYESogcz, yqzCFnTyclbNB.QgEJQqVKqKGOh));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(yqzCFnTyclbNB.WySkYESogcz);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(yqzCFnTyclbNB.azCjJrojbPrPvil))
						{
							dictionary_0.Add(yqzCFnTyclbNB.azCjJrojbPrPvil, new bFlVsRFfhATc(yqzCFnTyclbNB.WySkYESogcz, yqzCFnTyclbNB.QgEJQqVKqKGOh));
						}
						else
						{
							bFlVsRFfhATc bFlVsRFfhATc2 = dictionary_0[yqzCFnTyclbNB.azCjJrojbPrPvil];
							if (string.Compare(yqzCFnTyclbNB.WySkYESogcz, bFlVsRFfhATc2.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107462931), yqzCFnTyclbNB.azCjJrojbPrPvil, yqzCFnTyclbNB.WySkYESogcz, bFlVsRFfhATc2.Name);
								throw new Exception(string.Format(getString_0(107462424), yqzCFnTyclbNB.azCjJrojbPrPvil, yqzCFnTyclbNB.WySkYESogcz));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + yqzCFnTyclbNB.eMmtmDgwJnSO);
				MGncmtQRwTpU -= yqzCFnTyclbNB.eMmtmDgwJnSO;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void xmTlISSebPAhTCSp(IntPtr intptr_0)
	{
		wsLyyHKBptAa.fTeRlUjkDfDR structure = default(wsLyyHKBptAa.fTeRlUjkDfDR);
		structure.NdpykEKNEymdKB = 8388608uL;
		structure.wzUKVlSykYDpV = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		wsLyyHKBptAa.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		wsLyyHKBptAa.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void jKXRskHsgLPQa(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint lDpLVrkHWI = 0u;
		wsLyyHKBptAa.izBonXKVXPSlc SskneHVSYWB = default(wsLyyHKBptAa.izBonXKVXPSlc);
		if (wsLyyHKBptAa.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out SskneHVSYWB, sizeof(wsLyyHKBptAa.izBonXKVXPSlc), out lDpLVrkHWI, IntPtr.Zero))
		{
			wsLyyHKBptAa.gXobEdGdEmXupLs structure = default(wsLyyHKBptAa.gXobEdGdEmXupLs);
			structure.XTudShzdgNW = 0uL;
			structure.mlDhdItHmFk = 0L;
			structure.dmCNKEJKHP = SskneHVSYWB.NiOxbzRPgPiXMZ;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			wsLyyHKBptAa.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static RYFcAhWMVK()
	{
		Strings.CreateGetStringDelegate(typeof(RYFcAhWMVK));
	}
}
