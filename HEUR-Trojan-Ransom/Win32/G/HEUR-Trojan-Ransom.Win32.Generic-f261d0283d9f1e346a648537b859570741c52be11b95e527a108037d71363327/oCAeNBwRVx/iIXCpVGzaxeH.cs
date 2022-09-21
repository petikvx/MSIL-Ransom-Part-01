using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace oCAeNBwRVx;

public sealed class iIXCpVGzaxeH
{
	[NonSerialized]
	internal static GetString getString_0;

	public void QVGSNCHqyxDRNe(string AHWMajvmVCTzFW, HashSet<string> beLAcxHJso, out Dictionary<ulong, RWqiBDaDvSuhe> euyoPKqnMEkizwk, out Dictionary<ulong, RWqiBDaDvSuhe> zmmyQDsxiJDh)
	{
		zmmyQDsxiJDh = new Dictionary<ulong, RWqiBDaDvSuhe>();
		euyoPKqnMEkizwk = new Dictionary<ulong, RWqiBDaDvSuhe>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr AUqLEVaQMEuM = IntPtr.Zero;
		try
		{
			hDSwLgzkHdGNqdk(AHWMajvmVCTzFW, zmmyQDsxiJDh);
			XDZMpHKUBaVL(AHWMajvmVCTzFW, out AUqLEVaQMEuM);
			EOdxDCYOTYXNyN(AUqLEVaQMEuM);
			rqAIvwYpha(ref intptr_, AUqLEVaQMEuM);
			RKdjyssXaIO(intptr_, ref euyoPKqnMEkizwk, beLAcxHJso, zmmyQDsxiJDh, AUqLEVaQMEuM);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107398739), ex);
		}
		finally
		{
			if (AUqLEVaQMEuM.ToInt32() != -1)
			{
				EQpynYbwcSokms.CloseHandle(AUqLEVaQMEuM);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void hDSwLgzkHdGNqdk(string string_0, Dictionary<ulong, RWqiBDaDvSuhe> dictionary_0)
	{
		string text = getString_0(107398734) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = EQpynYbwcSokms.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			EQpynYbwcSokms.IHmqieGAINJa qHKbidvqgUWfVf = default(EQpynYbwcSokms.IHmqieGAINJa);
			if (EQpynYbwcSokms.GetFileInformationByHandle(intPtr, out qHKbidvqgUWfVf))
			{
				ulong num = qHKbidvqgUWfVf.awpNqvOlBBZhBzf;
				ulong key = (num << 32) | qHKbidvqgUWfVf.AziXQfIAzUPW;
				RWqiBDaDvSuhe value = new RWqiBDaDvSuhe(text, 0uL);
				dictionary_0.Add(key, value);
			}
			EQpynYbwcSokms.CloseHandle(intPtr);
		}
	}

	private void XDZMpHKUBaVL(string TKjIJXSbVgcff, out IntPtr AUqLEVaQMEuM)
	{
		string string_ = getString_0(107398734) + TKjIJXSbVgcff;
		AUqLEVaQMEuM = EQpynYbwcSokms.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void RKdjyssXaIO(IntPtr intptr_0, ref Dictionary<ulong, RWqiBDaDvSuhe> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, RWqiBDaDvSuhe> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		EQpynYbwcSokms.ZeroMemory(intPtr, 65544);
		uint rBqCyLWUiFz = 0u;
		while (EQpynYbwcSokms.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(EQpynYbwcSokms.GNposVSuwKN), intPtr, 65544, out rBqCyLWUiFz, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (rBqCyLWUiFz > 60)
			{
				EQpynYbwcSokms.vSnhFSRWKNUOh vSnhFSRWKNUOh = new EQpynYbwcSokms.vSnhFSRWKNUOh(intptr_2);
				if ((vSnhFSRWKNUOh.HYkdBcHspvlbdO & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(vSnhFSRWKNUOh.WtmPgfqEqMtp))
					{
						throw new Exception(string.Format(getString_0(107398725), vSnhFSRWKNUOh.WtmPgfqEqMtp, vSnhFSRWKNUOh.yJrsHbiUVDkBv));
					}
					dictionary_1.Add(vSnhFSRWKNUOh.WtmPgfqEqMtp, new RWqiBDaDvSuhe(vSnhFSRWKNUOh.yJrsHbiUVDkBv, vSnhFSRWKNUOh.gkNuhULpXIQL));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(vSnhFSRWKNUOh.yJrsHbiUVDkBv);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(vSnhFSRWKNUOh.WtmPgfqEqMtp))
						{
							dictionary_0.Add(vSnhFSRWKNUOh.WtmPgfqEqMtp, new RWqiBDaDvSuhe(vSnhFSRWKNUOh.yJrsHbiUVDkBv, vSnhFSRWKNUOh.gkNuhULpXIQL));
						}
						else
						{
							RWqiBDaDvSuhe rWqiBDaDvSuhe = dictionary_0[vSnhFSRWKNUOh.WtmPgfqEqMtp];
							if (string.Compare(vSnhFSRWKNUOh.yJrsHbiUVDkBv, rWqiBDaDvSuhe.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107398144), vSnhFSRWKNUOh.WtmPgfqEqMtp, vSnhFSRWKNUOh.yJrsHbiUVDkBv, rWqiBDaDvSuhe.Name);
								throw new Exception(string.Format(getString_0(107398725), vSnhFSRWKNUOh.WtmPgfqEqMtp, vSnhFSRWKNUOh.yJrsHbiUVDkBv));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + vSnhFSRWKNUOh.CAHPeHntBfN);
				rBqCyLWUiFz -= vSnhFSRWKNUOh.CAHPeHntBfN;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void EOdxDCYOTYXNyN(IntPtr intptr_0)
	{
		EQpynYbwcSokms.ZnYCVHFDMzu structure = default(EQpynYbwcSokms.ZnYCVHFDMzu);
		structure.TaQiFrOFcqXr = 8388608uL;
		structure.CLqLYFmfGfa = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		EQpynYbwcSokms.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		EQpynYbwcSokms.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void rqAIvwYpha(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint EGMALOzxwb = 0u;
		EQpynYbwcSokms.vKclxHctoLQi DzZHIejwccOtoz = default(EQpynYbwcSokms.vKclxHctoLQi);
		if (EQpynYbwcSokms.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out DzZHIejwccOtoz, sizeof(EQpynYbwcSokms.vKclxHctoLQi), out EGMALOzxwb, IntPtr.Zero))
		{
			EQpynYbwcSokms.GNposVSuwKN structure = default(EQpynYbwcSokms.GNposVSuwKN);
			structure.iOupzefTrj = 0uL;
			structure.qCDuHnHLXMtCtI = 0L;
			structure.aZhxASoKKRx = DzZHIejwccOtoz.GMpyUnIuAsRF;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			EQpynYbwcSokms.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static iIXCpVGzaxeH()
	{
		Strings.CreateGetStringDelegate(typeof(iIXCpVGzaxeH));
	}
}
