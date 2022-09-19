using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace DxdMrHCZzlIaV;

public sealed class AOdAReGcJduxd
{
	[NonSerialized]
	internal static GetString getString_0;

	public void rqCihwqReTYk(string hxsjTlpGMdGqb, HashSet<string> OqwrNtBWENsXO, out Dictionary<ulong, sodccIdMmAL> XCgpMlSWXwtHlnKx, out Dictionary<ulong, sodccIdMmAL> nWXswKXDwSHO)
	{
		nWXswKXDwSHO = new Dictionary<ulong, sodccIdMmAL>();
		XCgpMlSWXwtHlnKx = new Dictionary<ulong, sodccIdMmAL>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr jfpXpfqIHW = IntPtr.Zero;
		try
		{
			mxKpzBDtWAdduBM(hxsjTlpGMdGqb, nWXswKXDwSHO);
			NBxooujkoRuSb(hxsjTlpGMdGqb, out jfpXpfqIHW);
			GktAhLxcrjz(jfpXpfqIHW);
			uXxxeZUBliGhAu(ref intptr_, jfpXpfqIHW);
			xOsvKCleRYoX(intptr_, ref XCgpMlSWXwtHlnKx, OqwrNtBWENsXO, nWXswKXDwSHO, jfpXpfqIHW);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107351800), ex);
		}
		finally
		{
			if (jfpXpfqIHW.ToInt32() != -1)
			{
				CDyryfTazGZaC.CloseHandle(jfpXpfqIHW);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void mxKpzBDtWAdduBM(string string_0, Dictionary<ulong, sodccIdMmAL> dictionary_0)
	{
		string text = getString_0(107351763) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = CDyryfTazGZaC.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			CDyryfTazGZaC.IqfHlqEzFiMi WYxNyCwgjOu = default(CDyryfTazGZaC.IqfHlqEzFiMi);
			if (CDyryfTazGZaC.GetFileInformationByHandle(intPtr, out WYxNyCwgjOu))
			{
				ulong num = WYxNyCwgjOu.vnKhDfxzwIl;
				ulong key = (num << 32) | WYxNyCwgjOu.gESFTRgsASpI;
				sodccIdMmAL value = new sodccIdMmAL(text, 0uL);
				dictionary_0.Add(key, value);
			}
			CDyryfTazGZaC.CloseHandle(intPtr);
		}
	}

	private void NBxooujkoRuSb(string AQmjZSTMJqfvmlUBg, out IntPtr jfpXpfqIHW)
	{
		string string_ = getString_0(107351763) + AQmjZSTMJqfvmlUBg;
		jfpXpfqIHW = CDyryfTazGZaC.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void xOsvKCleRYoX(IntPtr intptr_0, ref Dictionary<ulong, sodccIdMmAL> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, sodccIdMmAL> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		CDyryfTazGZaC.ZeroMemory(intPtr, 65544);
		uint syFAslEYVAL = 0u;
		while (CDyryfTazGZaC.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(CDyryfTazGZaC.ZYnYgEHjUGoHa), intPtr, 65544, out syFAslEYVAL, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (syFAslEYVAL > 60)
			{
				CDyryfTazGZaC.oZVSGqUVmHJj oZVSGqUVmHJj = new CDyryfTazGZaC.oZVSGqUVmHJj(intptr_2);
				if ((oZVSGqUVmHJj.LBxzyLmtFRAu & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(oZVSGqUVmHJj.mYjkrZxxOIJz))
					{
						throw new Exception(string.Format(getString_0(107351722), oZVSGqUVmHJj.mYjkrZxxOIJz, oZVSGqUVmHJj.VkbUYDCBfOlrPES));
					}
					dictionary_1.Add(oZVSGqUVmHJj.mYjkrZxxOIJz, new sodccIdMmAL(oZVSGqUVmHJj.VkbUYDCBfOlrPES, oZVSGqUVmHJj.uHzCnIDgDQuQfsDY));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(oZVSGqUVmHJj.VkbUYDCBfOlrPES);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(oZVSGqUVmHJj.mYjkrZxxOIJz))
						{
							dictionary_0.Add(oZVSGqUVmHJj.mYjkrZxxOIJz, new sodccIdMmAL(oZVSGqUVmHJj.VkbUYDCBfOlrPES, oZVSGqUVmHJj.uHzCnIDgDQuQfsDY));
						}
						else
						{
							sodccIdMmAL sodccIdMmAL2 = dictionary_0[oZVSGqUVmHJj.mYjkrZxxOIJz];
							if (string.Compare(oZVSGqUVmHJj.VkbUYDCBfOlrPES, sodccIdMmAL2.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107351685), oZVSGqUVmHJj.mYjkrZxxOIJz, oZVSGqUVmHJj.VkbUYDCBfOlrPES, sodccIdMmAL2.Name);
								throw new Exception(string.Format(getString_0(107351722), oZVSGqUVmHJj.mYjkrZxxOIJz, oZVSGqUVmHJj.VkbUYDCBfOlrPES));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + oZVSGqUVmHJj.ZWYdVmkZwrCsg);
				syFAslEYVAL -= oZVSGqUVmHJj.ZWYdVmkZwrCsg;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void GktAhLxcrjz(IntPtr intptr_0)
	{
		CDyryfTazGZaC.EipIejSotHG structure = default(CDyryfTazGZaC.EipIejSotHG);
		structure.iLvQwJfmVqIlI = 8388608uL;
		structure.fSeDxbzziNx = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		CDyryfTazGZaC.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		CDyryfTazGZaC.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void uXxxeZUBliGhAu(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint eUprZHbtyRoLZ = 0u;
		CDyryfTazGZaC.ssODQqFGZxhzHO KpzOpTWBldRBETld = default(CDyryfTazGZaC.ssODQqFGZxhzHO);
		if (CDyryfTazGZaC.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out KpzOpTWBldRBETld, sizeof(CDyryfTazGZaC.ssODQqFGZxhzHO), out eUprZHbtyRoLZ, IntPtr.Zero))
		{
			CDyryfTazGZaC.ZYnYgEHjUGoHa structure = default(CDyryfTazGZaC.ZYnYgEHjUGoHa);
			structure.jEuZjjKgxb = 0uL;
			structure.nUgsOVOoJzv = 0L;
			structure.rWLTVdWNXISu = KpzOpTWBldRBETld.IpOWsEsjUbbSHkVg;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			CDyryfTazGZaC.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static AOdAReGcJduxd()
	{
		Strings.CreateGetStringDelegate(typeof(AOdAReGcJduxd));
	}
}
