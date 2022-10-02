using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wFLFuclWzVArMo;

public sealed class jGfdhKPGPh
{
	[NonSerialized]
	internal static GetString getString_0;

	public void GgrQooptxtyoY(string jyZAVPJQlUTI, HashSet<string> sgWtqRmcPHGfzaO, out Dictionary<ulong, EcvBOyInqG> NBqgtgWrlqWTNPA, out Dictionary<ulong, EcvBOyInqG> dRfIeFuvIBHR)
	{
		dRfIeFuvIBHR = new Dictionary<ulong, EcvBOyInqG>();
		NBqgtgWrlqWTNPA = new Dictionary<ulong, EcvBOyInqG>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr EkmhONaStpWMxX = IntPtr.Zero;
		try
		{
			sPDPngkjJnurr(jyZAVPJQlUTI, dRfIeFuvIBHR);
			ysXyfJTinLbbl(jyZAVPJQlUTI, out EkmhONaStpWMxX);
			FuWINzwpsIdGj(EkmhONaStpWMxX);
			MmBSTIBLLo(ref intptr_, EkmhONaStpWMxX);
			tFvSeKgmPBdCbs(intptr_, ref NBqgtgWrlqWTNPA, sgWtqRmcPHGfzaO, dRfIeFuvIBHR, EkmhONaStpWMxX);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107365845), ex);
		}
		finally
		{
			if (EkmhONaStpWMxX.ToInt32() != -1)
			{
				quYsvTKKZTUsa.CloseHandle(EkmhONaStpWMxX);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void sPDPngkjJnurr(string string_0, Dictionary<ulong, EcvBOyInqG> dictionary_0)
	{
		string text = getString_0(107365808) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = quYsvTKKZTUsa.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			quYsvTKKZTUsa.oHiWVpsXirkRsp JXIEtRWjhfis = default(quYsvTKKZTUsa.oHiWVpsXirkRsp);
			if (quYsvTKKZTUsa.GetFileInformationByHandle(intPtr, out JXIEtRWjhfis))
			{
				ulong num = JXIEtRWjhfis.qCJQJxqxpTZDXc;
				ulong key = (num << 32) | JXIEtRWjhfis.PIwmZAvpIaS;
				EcvBOyInqG value = new EcvBOyInqG(text, 0uL);
				dictionary_0.Add(key, value);
			}
			quYsvTKKZTUsa.CloseHandle(intPtr);
		}
	}

	private void ysXyfJTinLbbl(string OBHNJLvczT, out IntPtr EkmhONaStpWMxX)
	{
		string string_ = getString_0(107365808) + OBHNJLvczT;
		EkmhONaStpWMxX = quYsvTKKZTUsa.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void tFvSeKgmPBdCbs(IntPtr intptr_0, ref Dictionary<ulong, EcvBOyInqG> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, EcvBOyInqG> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		quYsvTKKZTUsa.ZeroMemory(intPtr, 65544);
		uint ikIFYvehrRKs = 0u;
		while (quYsvTKKZTUsa.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(quYsvTKKZTUsa.ondIXVdddyVfAX), intPtr, 65544, out ikIFYvehrRKs, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (ikIFYvehrRKs > 60)
			{
				quYsvTKKZTUsa.qaODESWiTbucuT qaODESWiTbucuT = new quYsvTKKZTUsa.qaODESWiTbucuT(intptr_2);
				if ((qaODESWiTbucuT.ZpgLYwLqKYpEP & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(qaODESWiTbucuT.ficBzHJzaQLfXz))
					{
						throw new Exception(string.Format(getString_0(107365831), qaODESWiTbucuT.ficBzHJzaQLfXz, qaODESWiTbucuT.qsCDvptnkruEE));
					}
					dictionary_1.Add(qaODESWiTbucuT.ficBzHJzaQLfXz, new EcvBOyInqG(qaODESWiTbucuT.qsCDvptnkruEE, qaODESWiTbucuT.mgzmyxuOuitL));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(qaODESWiTbucuT.qsCDvptnkruEE);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(qaODESWiTbucuT.ficBzHJzaQLfXz))
						{
							dictionary_0.Add(qaODESWiTbucuT.ficBzHJzaQLfXz, new EcvBOyInqG(qaODESWiTbucuT.qsCDvptnkruEE, qaODESWiTbucuT.mgzmyxuOuitL));
						}
						else
						{
							EcvBOyInqG ecvBOyInqG = dictionary_0[qaODESWiTbucuT.ficBzHJzaQLfXz];
							if (string.Compare(qaODESWiTbucuT.qsCDvptnkruEE, ecvBOyInqG.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107365794), qaODESWiTbucuT.ficBzHJzaQLfXz, qaODESWiTbucuT.qsCDvptnkruEE, ecvBOyInqG.Name);
								throw new Exception(string.Format(getString_0(107365831), qaODESWiTbucuT.ficBzHJzaQLfXz, qaODESWiTbucuT.qsCDvptnkruEE));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + qaODESWiTbucuT.zwZoBRLfxYpnuC);
				ikIFYvehrRKs -= qaODESWiTbucuT.zwZoBRLfxYpnuC;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void FuWINzwpsIdGj(IntPtr intptr_0)
	{
		quYsvTKKZTUsa.OrafonymHiIhydP structure = default(quYsvTKKZTUsa.OrafonymHiIhydP);
		structure.lGsBCspJpxA = 8388608uL;
		structure.iKJuFJcEvMAqZA = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		quYsvTKKZTUsa.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		quYsvTKKZTUsa.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void MmBSTIBLLo(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint IVYxvjbDrMzZN = 0u;
		quYsvTKKZTUsa.YJbfFOdhEoGT sZqxqKqZLyK = default(quYsvTKKZTUsa.YJbfFOdhEoGT);
		if (quYsvTKKZTUsa.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out sZqxqKqZLyK, sizeof(quYsvTKKZTUsa.YJbfFOdhEoGT), out IVYxvjbDrMzZN, IntPtr.Zero))
		{
			quYsvTKKZTUsa.ondIXVdddyVfAX structure = default(quYsvTKKZTUsa.ondIXVdddyVfAX);
			structure.SXBaAZBWEgttD = 0uL;
			structure.jMuXapEZpIVnqU = 0L;
			structure.IvZzDVcbBgsT = sZqxqKqZLyK.dcvSxsxSwcROJ;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			quYsvTKKZTUsa.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static jGfdhKPGPh()
	{
		Strings.CreateGetStringDelegate(typeof(jGfdhKPGPh));
	}
}
