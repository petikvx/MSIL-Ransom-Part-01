using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace LqOmRmSJUuFi;

public sealed class QEEnopKlJLPCoOHSx
{
	[NonSerialized]
	internal static GetString getString_0;

	public void ImSPvucCuANaVUv(string pUpYrmAaJOjt, HashSet<string> tZFYlVjDbgGWgFSn, out Dictionary<ulong, CJMoUoINuBFW> jcVBzybiyrOTuN, out Dictionary<ulong, CJMoUoINuBFW> znhIFkRinjKrYA)
	{
		znhIFkRinjKrYA = new Dictionary<ulong, CJMoUoINuBFW>();
		jcVBzybiyrOTuN = new Dictionary<ulong, CJMoUoINuBFW>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr FqpCAmisgo = IntPtr.Zero;
		try
		{
			YkrNDmUlnsBuOD(pUpYrmAaJOjt, znhIFkRinjKrYA);
			bWbxGuajcWC(pUpYrmAaJOjt, out FqpCAmisgo);
			RIrfJbooEf(FqpCAmisgo);
			qVHOIeNegkgUTt(ref intptr_, FqpCAmisgo);
			mZdIDuVBVDmSs(intptr_, ref jcVBzybiyrOTuN, tZFYlVjDbgGWgFSn, znhIFkRinjKrYA, FqpCAmisgo);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107459797), ex);
		}
		finally
		{
			if (FqpCAmisgo.ToInt32() != -1)
			{
				myzjczZxLYrLApQM.CloseHandle(FqpCAmisgo);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void YkrNDmUlnsBuOD(string string_0, Dictionary<ulong, CJMoUoINuBFW> dictionary_0)
	{
		string text = getString_0(107460272) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = myzjczZxLYrLApQM.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			myzjczZxLYrLApQM.EwplMszDBayCw TJEEidATSJtW = default(myzjczZxLYrLApQM.EwplMszDBayCw);
			if (myzjczZxLYrLApQM.GetFileInformationByHandle(intPtr, out TJEEidATSJtW))
			{
				ulong num = TJEEidATSJtW.QPNXlcwctD;
				ulong key = (num << 32) | TJEEidATSJtW.VCPgtVQfFohfG;
				CJMoUoINuBFW value = new CJMoUoINuBFW(text, 0uL);
				dictionary_0.Add(key, value);
			}
			myzjczZxLYrLApQM.CloseHandle(intPtr);
		}
	}

	private void bWbxGuajcWC(string HuCyFwLjewxaip, out IntPtr FqpCAmisgo)
	{
		string string_ = getString_0(107460272) + HuCyFwLjewxaip;
		FqpCAmisgo = myzjczZxLYrLApQM.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void mZdIDuVBVDmSs(IntPtr intptr_0, ref Dictionary<ulong, CJMoUoINuBFW> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, CJMoUoINuBFW> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		myzjczZxLYrLApQM.ZeroMemory(intPtr, 65544);
		uint vTmjnEShUFdZ = 0u;
		while (myzjczZxLYrLApQM.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(myzjczZxLYrLApQM.WeICQDjJjbF), intPtr, 65544, out vTmjnEShUFdZ, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (vTmjnEShUFdZ > 60)
			{
				myzjczZxLYrLApQM.OFEooBQXViMg oFEooBQXViMg = new myzjczZxLYrLApQM.OFEooBQXViMg(intptr_2);
				if ((oFEooBQXViMg.ntDcXfkeQsMll & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(oFEooBQXViMg.cBSdgPvEYwQMCs))
					{
						throw new Exception(string.Format(getString_0(107460231), oFEooBQXViMg.cBSdgPvEYwQMCs, oFEooBQXViMg.gqiQWowOLNGWA));
					}
					dictionary_1.Add(oFEooBQXViMg.cBSdgPvEYwQMCs, new CJMoUoINuBFW(oFEooBQXViMg.gqiQWowOLNGWA, oFEooBQXViMg.BJaqDKcfEI));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(oFEooBQXViMg.gqiQWowOLNGWA);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(oFEooBQXViMg.cBSdgPvEYwQMCs))
						{
							dictionary_0.Add(oFEooBQXViMg.cBSdgPvEYwQMCs, new CJMoUoINuBFW(oFEooBQXViMg.gqiQWowOLNGWA, oFEooBQXViMg.BJaqDKcfEI));
						}
						else
						{
							CJMoUoINuBFW cJMoUoINuBFW = dictionary_0[oFEooBQXViMg.cBSdgPvEYwQMCs];
							if (string.Compare(oFEooBQXViMg.gqiQWowOLNGWA, cJMoUoINuBFW.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107460194), oFEooBQXViMg.cBSdgPvEYwQMCs, oFEooBQXViMg.gqiQWowOLNGWA, cJMoUoINuBFW.Name);
								throw new Exception(string.Format(getString_0(107460231), oFEooBQXViMg.cBSdgPvEYwQMCs, oFEooBQXViMg.gqiQWowOLNGWA));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + oFEooBQXViMg.ZHouubkKOEiZ);
				vTmjnEShUFdZ -= oFEooBQXViMg.ZHouubkKOEiZ;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void RIrfJbooEf(IntPtr intptr_0)
	{
		myzjczZxLYrLApQM.pgECCXDDmOk structure = default(myzjczZxLYrLApQM.pgECCXDDmOk);
		structure.QCWusJSJryD = 8388608uL;
		structure.RgVpuIARDptS = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		myzjczZxLYrLApQM.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		myzjczZxLYrLApQM.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void qVHOIeNegkgUTt(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint GnCdjhYigsMxxFU = 0u;
		myzjczZxLYrLApQM.dtIkOZNTLU UJMLfSvJTQl = default(myzjczZxLYrLApQM.dtIkOZNTLU);
		if (myzjczZxLYrLApQM.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out UJMLfSvJTQl, sizeof(myzjczZxLYrLApQM.dtIkOZNTLU), out GnCdjhYigsMxxFU, IntPtr.Zero))
		{
			myzjczZxLYrLApQM.WeICQDjJjbF structure = default(myzjczZxLYrLApQM.WeICQDjJjbF);
			structure.PTKUGrmORa = 0uL;
			structure.umlRutkYYd = 0L;
			structure.VQfQWQAWvH = UJMLfSvJTQl.vEemOFEkTZ;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			myzjczZxLYrLApQM.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static QEEnopKlJLPCoOHSx()
	{
		Strings.CreateGetStringDelegate(typeof(QEEnopKlJLPCoOHSx));
	}
}
