using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace LHzwFzfXBAR;

public sealed class TKLtuxaYLWh
{
	[NonSerialized]
	internal static GetString getString_0;

	public void JHOuLlHRZiz(string GUHfBCSIUkYYG, HashSet<string> IijJOVVFzzrRp, out Dictionary<ulong, hGdahdRUOgSYh> iIOrpzxrzPVb, out Dictionary<ulong, hGdahdRUOgSYh> cTlJBraJNTgV)
	{
		cTlJBraJNTgV = new Dictionary<ulong, hGdahdRUOgSYh>();
		iIOrpzxrzPVb = new Dictionary<ulong, hGdahdRUOgSYh>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr nbNGsbGrgpEU = IntPtr.Zero;
		try
		{
			aQDmCtspkdV(GUHfBCSIUkYYG, cTlJBraJNTgV);
			QHXRiObBqiO(GUHfBCSIUkYYG, out nbNGsbGrgpEU);
			nWlasojFXhC(nbNGsbGrgpEU);
			zFMgEojofxLGdG(ref intptr_, nbNGsbGrgpEU);
			foXvyGkxWcXOvU(intptr_, ref iIOrpzxrzPVb, IijJOVVFzzrRp, cTlJBraJNTgV, nbNGsbGrgpEU);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107475772), ex);
		}
		finally
		{
			if (nbNGsbGrgpEU.ToInt32() != -1)
			{
				icrXAneOuaz.CloseHandle(nbNGsbGrgpEU);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void aQDmCtspkdV(string string_0, Dictionary<ulong, hGdahdRUOgSYh> dictionary_0)
	{
		string text = getString_0(107475767) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = icrXAneOuaz.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			icrXAneOuaz.aRrBQITLOyzGkD xMsDWEIdpSJ = default(icrXAneOuaz.aRrBQITLOyzGkD);
			if (icrXAneOuaz.GetFileInformationByHandle(intPtr, out xMsDWEIdpSJ))
			{
				ulong num = xMsDWEIdpSJ.ugVDxCdabCXRy;
				ulong key = (num << 32) | xMsDWEIdpSJ.yCxPSUXdrew;
				hGdahdRUOgSYh value = new hGdahdRUOgSYh(text, 0uL);
				dictionary_0.Add(key, value);
			}
			icrXAneOuaz.CloseHandle(intPtr);
		}
	}

	private void QHXRiObBqiO(string ajUiQRpTGhysRLpT, out IntPtr nbNGsbGrgpEU)
	{
		string string_ = getString_0(107475767) + ajUiQRpTGhysRLpT;
		nbNGsbGrgpEU = icrXAneOuaz.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void foXvyGkxWcXOvU(IntPtr intptr_0, ref Dictionary<ulong, hGdahdRUOgSYh> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, hGdahdRUOgSYh> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		icrXAneOuaz.ZeroMemory(intPtr, 65544);
		uint ZBzTxbXREonI = 0u;
		while (icrXAneOuaz.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(icrXAneOuaz.HfktFvXfDB), intPtr, 65544, out ZBzTxbXREonI, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (ZBzTxbXREonI > 60)
			{
				icrXAneOuaz.ZKtlOAFYlK zKtlOAFYlK = new icrXAneOuaz.ZKtlOAFYlK(intptr_2);
				if ((zKtlOAFYlK.VNSQNSdbZH & 0x10u) != 0)
				{
					if (dictionary_1.ContainsKey(zKtlOAFYlK.BFcFxbpPACasV))
					{
						throw new Exception(string.Format(getString_0(107475758), zKtlOAFYlK.BFcFxbpPACasV, zKtlOAFYlK.PLCSRoQaWtE));
					}
					dictionary_1.Add(zKtlOAFYlK.BFcFxbpPACasV, new hGdahdRUOgSYh(zKtlOAFYlK.PLCSRoQaWtE, zKtlOAFYlK.YdCVvjlyJloKt));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(zKtlOAFYlK.PLCSRoQaWtE);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(zKtlOAFYlK.BFcFxbpPACasV))
						{
							dictionary_0.Add(zKtlOAFYlK.BFcFxbpPACasV, new hGdahdRUOgSYh(zKtlOAFYlK.PLCSRoQaWtE, zKtlOAFYlK.YdCVvjlyJloKt));
						}
						else
						{
							hGdahdRUOgSYh hGdahdRUOgSYh2 = dictionary_0[zKtlOAFYlK.BFcFxbpPACasV];
							if (string.Compare(zKtlOAFYlK.PLCSRoQaWtE, hGdahdRUOgSYh2.Name, ignoreCase: true) != 0)
							{
								Console.WriteLine(getString_0(107475689), zKtlOAFYlK.BFcFxbpPACasV, zKtlOAFYlK.PLCSRoQaWtE, hGdahdRUOgSYh2.Name);
								throw new Exception(string.Format(getString_0(107475758), zKtlOAFYlK.BFcFxbpPACasV, zKtlOAFYlK.PLCSRoQaWtE));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + zKtlOAFYlK.VOAOrKwjfRY);
				ZBzTxbXREonI -= zKtlOAFYlK.VOAOrKwjfRY;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void nWlasojFXhC(IntPtr intptr_0)
	{
		icrXAneOuaz.VWLiYYudnwMnjv structure = default(icrXAneOuaz.VWLiYYudnwMnjv);
		structure.bDefbRCBjGYWgku = 8388608uL;
		structure.VMENVFsSAHghQel = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		icrXAneOuaz.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		icrXAneOuaz.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void zFMgEojofxLGdG(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint supnCSYJASR = 0u;
		icrXAneOuaz.NSYgDUVmlYH OhQGZLvAbewtB = default(icrXAneOuaz.NSYgDUVmlYH);
		if (icrXAneOuaz.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out OhQGZLvAbewtB, sizeof(icrXAneOuaz.NSYgDUVmlYH), out supnCSYJASR, IntPtr.Zero))
		{
			icrXAneOuaz.HfktFvXfDB structure = default(icrXAneOuaz.HfktFvXfDB);
			structure.MZdUKzgvlghV = 0uL;
			structure.vhILeRSmMdR = 0L;
			structure.tAtfqyHxoarMtE = OhQGZLvAbewtB.IvaTJgSBll;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			icrXAneOuaz.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static TKLtuxaYLWh()
	{
		Strings.CreateGetStringDelegate(typeof(TKLtuxaYLWh));
	}
}
