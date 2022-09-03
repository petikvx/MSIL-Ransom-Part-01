using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eZkFrthrrFwCL;

public sealed class qkWKRdCGhTIAL
{
	[NonSerialized]
	internal static GetString getString_0;

	public void yQfRnhCHpWXyR(string LJivkzqEkIuGV, HashSet<string> sCplaDTHEZjUlR, out Dictionary<ulong, vnuJlJKmoK> LTpTXNUOKaxS, out Dictionary<ulong, vnuJlJKmoK> qWJbSzjdeULqpZ)
	{
		qWJbSzjdeULqpZ = new Dictionary<ulong, vnuJlJKmoK>();
		LTpTXNUOKaxS = new Dictionary<ulong, vnuJlJKmoK>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr yOqsBwgzhHPwtki = IntPtr.Zero;
		try
		{
			YReldCYNvIyY(LJivkzqEkIuGV, qWJbSzjdeULqpZ);
			GWXjOKkicWpS(LJivkzqEkIuGV, out yOqsBwgzhHPwtki);
			JIZSCHStcFjgi(yOqsBwgzhHPwtki);
			bnscRjpwNwflcWhF(ref intptr_, yOqsBwgzhHPwtki);
			lcFISFJCLm(intptr_, ref LTpTXNUOKaxS, sCplaDTHEZjUlR, qWJbSzjdeULqpZ, yOqsBwgzhHPwtki);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107455250), ex);
		}
		finally
		{
			if (yOqsBwgzhHPwtki.ToInt32() != -1)
			{
				IhRxDiuDyxSRte.CloseHandle(yOqsBwgzhHPwtki);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void YReldCYNvIyY(string string_0, Dictionary<ulong, vnuJlJKmoK> dictionary_0)
	{
		string text = getString_0(107455213) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = IhRxDiuDyxSRte.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			IhRxDiuDyxSRte.azhXJjrFTTha XtuKaTccPJbFz = default(IhRxDiuDyxSRte.azhXJjrFTTha);
			if (IhRxDiuDyxSRte.GetFileInformationByHandle(intPtr, out XtuKaTccPJbFz))
			{
				ulong num = XtuKaTccPJbFz.gMLktzYylXupVtz;
				ulong key = (num << 32) | XtuKaTccPJbFz.aELFWLpPvUUJVIa;
				vnuJlJKmoK value = new vnuJlJKmoK(text, 0uL);
				dictionary_0.Add(key, value);
			}
			IhRxDiuDyxSRte.CloseHandle(intPtr);
		}
	}

	private void GWXjOKkicWpS(string aDlDrbIekjb, out IntPtr yOqsBwgzhHPwtki)
	{
		string string_ = getString_0(107455213) + aDlDrbIekjb;
		yOqsBwgzhHPwtki = IhRxDiuDyxSRte.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void lcFISFJCLm(IntPtr intptr_0, ref Dictionary<ulong, vnuJlJKmoK> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, vnuJlJKmoK> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		IhRxDiuDyxSRte.ZeroMemory(intPtr, 65544);
		uint uaYPltplhdxWs = 0u;
		while (IhRxDiuDyxSRte.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(IhRxDiuDyxSRte.MraCNbopUXp), intPtr, 65544, out uaYPltplhdxWs, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (uaYPltplhdxWs > 60)
			{
				IhRxDiuDyxSRte.AwzyqYXxoWt awzyqYXxoWt = new IhRxDiuDyxSRte.AwzyqYXxoWt(intptr_2);
				if ((awzyqYXxoWt.ViATzxiPlJra & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(awzyqYXxoWt.QlRwoqyaKgMok))
					{
						throw new Exception(string.Format(getString_0(107455236), awzyqYXxoWt.QlRwoqyaKgMok, awzyqYXxoWt.FdEbcSDmJZeVZu));
					}
					dictionary_1.Add(awzyqYXxoWt.QlRwoqyaKgMok, new vnuJlJKmoK(awzyqYXxoWt.FdEbcSDmJZeVZu, awzyqYXxoWt.qRoovJRgXAUf));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(awzyqYXxoWt.FdEbcSDmJZeVZu);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(awzyqYXxoWt.QlRwoqyaKgMok))
						{
							dictionary_0.Add(awzyqYXxoWt.QlRwoqyaKgMok, new vnuJlJKmoK(awzyqYXxoWt.FdEbcSDmJZeVZu, awzyqYXxoWt.qRoovJRgXAUf));
						}
						else
						{
							vnuJlJKmoK vnuJlJKmoK2 = dictionary_0[awzyqYXxoWt.QlRwoqyaKgMok];
							if (string.Compare(awzyqYXxoWt.FdEbcSDmJZeVZu, vnuJlJKmoK2.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107455199), awzyqYXxoWt.QlRwoqyaKgMok, awzyqYXxoWt.FdEbcSDmJZeVZu, vnuJlJKmoK2.Name);
								throw new Exception(string.Format(getString_0(107455236), awzyqYXxoWt.QlRwoqyaKgMok, awzyqYXxoWt.FdEbcSDmJZeVZu));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + awzyqYXxoWt.ijVsedXHkZ);
				uaYPltplhdxWs -= awzyqYXxoWt.ijVsedXHkZ;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void JIZSCHStcFjgi(IntPtr intptr_0)
	{
		IhRxDiuDyxSRte.lzTPTysqIiu structure = default(IhRxDiuDyxSRte.lzTPTysqIiu);
		structure.kuFDpsORroo = 8388608uL;
		structure.nyCITIeGUJIeKK = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		IhRxDiuDyxSRte.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		IhRxDiuDyxSRte.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void bnscRjpwNwflcWhF(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint jtffXMNusUFOix = 0u;
		IhRxDiuDyxSRte.tXfLZQUTQZsqq EmObRnDfDnj = default(IhRxDiuDyxSRte.tXfLZQUTQZsqq);
		if (IhRxDiuDyxSRte.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out EmObRnDfDnj, sizeof(IhRxDiuDyxSRte.tXfLZQUTQZsqq), out jtffXMNusUFOix, IntPtr.Zero))
		{
			IhRxDiuDyxSRte.MraCNbopUXp structure = default(IhRxDiuDyxSRte.MraCNbopUXp);
			structure.wYiqJmGIruxoF = 0uL;
			structure.tiziFbpnTLqJiCQg = 0L;
			structure.JvRytqTEAqdPl = EmObRnDfDnj.sLsELvxHgsksA;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			IhRxDiuDyxSRte.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static qkWKRdCGhTIAL()
	{
		Strings.CreateGetStringDelegate(typeof(qkWKRdCGhTIAL));
	}
}
