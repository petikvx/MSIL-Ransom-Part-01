using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wVRaLppLPGmaSaj;

public sealed class gjKVjOSgGMyg
{
	[NonSerialized]
	internal static GetString getString_0;

	public void vTsxTsmjCg(string fklvAjaRwcQ, HashSet<string> egOaMFnexekI, out Dictionary<ulong, FJuXIlXhWlTe> DXZigUbKCMs, out Dictionary<ulong, FJuXIlXhWlTe> NqbPFxSHzeBHp)
	{
		NqbPFxSHzeBHp = new Dictionary<ulong, FJuXIlXhWlTe>();
		DXZigUbKCMs = new Dictionary<ulong, FJuXIlXhWlTe>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr oFpVMcStiYLoCtuI = IntPtr.Zero;
		try
		{
			cIDzPnZotLs(fklvAjaRwcQ, NqbPFxSHzeBHp);
			MpoBrryKEspGG(fklvAjaRwcQ, out oFpVMcStiYLoCtuI);
			rEgbKrfjchKhkZ(oFpVMcStiYLoCtuI);
			HIWefxSmCRAbu(ref intptr_, oFpVMcStiYLoCtuI);
			MRzaXvDNZvZaH(intptr_, ref DXZigUbKCMs, egOaMFnexekI, NqbPFxSHzeBHp, oFpVMcStiYLoCtuI);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107399206), ex);
		}
		finally
		{
			if (oFpVMcStiYLoCtuI.ToInt32() != -1)
			{
				XABsKVQGCJIw.CloseHandle(oFpVMcStiYLoCtuI);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void cIDzPnZotLs(string string_0, Dictionary<ulong, FJuXIlXhWlTe> dictionary_0)
	{
		string text = getString_0(107399169) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = XABsKVQGCJIw.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			XABsKVQGCJIw.fkmAvYHEUKQsE ebyvZmfVwyn = default(XABsKVQGCJIw.fkmAvYHEUKQsE);
			if (XABsKVQGCJIw.GetFileInformationByHandle(intPtr, out ebyvZmfVwyn))
			{
				ulong num = ebyvZmfVwyn.kEpWmUuLUMNE;
				ulong key = (num << 32) | ebyvZmfVwyn.waHqjciqIlReMy;
				FJuXIlXhWlTe value = new FJuXIlXhWlTe(text, 0uL);
				dictionary_0.Add(key, value);
			}
			XABsKVQGCJIw.CloseHandle(intPtr);
		}
	}

	private void MpoBrryKEspGG(string jkTZTYdvJqK, out IntPtr oFpVMcStiYLoCtuI)
	{
		string string_ = getString_0(107399169) + jkTZTYdvJqK;
		oFpVMcStiYLoCtuI = XABsKVQGCJIw.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void MRzaXvDNZvZaH(IntPtr intptr_0, ref Dictionary<ulong, FJuXIlXhWlTe> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, FJuXIlXhWlTe> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		XABsKVQGCJIw.ZeroMemory(intPtr, 65544);
		uint UwFdlGjxlU = 0u;
		while (XABsKVQGCJIw.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(XABsKVQGCJIw.umbWCrEpEGaS), intPtr, 65544, out UwFdlGjxlU, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (UwFdlGjxlU > 60)
			{
				XABsKVQGCJIw.GuyKfkLltIItOOl guyKfkLltIItOOl = new XABsKVQGCJIw.GuyKfkLltIItOOl(intptr_2);
				if ((guyKfkLltIItOOl.DlHLpmlncWpHQ & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(guyKfkLltIItOOl.lMvSiAzItpi))
					{
						throw new Exception(string.Format(getString_0(107399192), guyKfkLltIItOOl.lMvSiAzItpi, guyKfkLltIItOOl.WIwScFYfupt));
					}
					dictionary_1.Add(guyKfkLltIItOOl.lMvSiAzItpi, new FJuXIlXhWlTe(guyKfkLltIItOOl.WIwScFYfupt, guyKfkLltIItOOl.akWdbZaqzlgXHvf));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(guyKfkLltIItOOl.WIwScFYfupt);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(guyKfkLltIItOOl.lMvSiAzItpi))
						{
							dictionary_0.Add(guyKfkLltIItOOl.lMvSiAzItpi, new FJuXIlXhWlTe(guyKfkLltIItOOl.WIwScFYfupt, guyKfkLltIItOOl.akWdbZaqzlgXHvf));
						}
						else
						{
							FJuXIlXhWlTe fJuXIlXhWlTe = dictionary_0[guyKfkLltIItOOl.lMvSiAzItpi];
							if (string.Compare(guyKfkLltIItOOl.WIwScFYfupt, fJuXIlXhWlTe.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107399155), guyKfkLltIItOOl.lMvSiAzItpi, guyKfkLltIItOOl.WIwScFYfupt, fJuXIlXhWlTe.Name);
								throw new Exception(string.Format(getString_0(107399192), guyKfkLltIItOOl.lMvSiAzItpi, guyKfkLltIItOOl.WIwScFYfupt));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + guyKfkLltIItOOl.YOUMkmEsSJQJ);
				UwFdlGjxlU -= guyKfkLltIItOOl.YOUMkmEsSJQJ;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void rEgbKrfjchKhkZ(IntPtr intptr_0)
	{
		XABsKVQGCJIw.ARHyCwzgZJJLi structure = default(XABsKVQGCJIw.ARHyCwzgZJJLi);
		structure.ESDWKbEwDSG = 8388608uL;
		structure.qhMlmbhVgizDMPtm = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		XABsKVQGCJIw.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		XABsKVQGCJIw.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void HIWefxSmCRAbu(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint XPPZNZqpxZFLD = 0u;
		XABsKVQGCJIw.bipYmlhZYRXLRR HskRlNeUYwXq = default(XABsKVQGCJIw.bipYmlhZYRXLRR);
		if (XABsKVQGCJIw.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out HskRlNeUYwXq, sizeof(XABsKVQGCJIw.bipYmlhZYRXLRR), out XPPZNZqpxZFLD, IntPtr.Zero))
		{
			XABsKVQGCJIw.umbWCrEpEGaS structure = default(XABsKVQGCJIw.umbWCrEpEGaS);
			structure.bUDwcFXYRwo = 0uL;
			structure.iXyuYBgljxxv = 0L;
			structure.tQbkwIqIcDXn = HskRlNeUYwXq.hurbVWvDJgVIWh;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			XABsKVQGCJIw.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static gjKVjOSgGMyg()
	{
		Strings.CreateGetStringDelegate(typeof(gjKVjOSgGMyg));
	}
}
