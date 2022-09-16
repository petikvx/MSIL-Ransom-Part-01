using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace kUSxsBmhKmv;

public sealed class IwzaWmnwcnlB
{
	[NonSerialized]
	internal static GetString getString_0;

	public void CJkuFhqIgKwiFDo(string fFXTiHjBuE, HashSet<string> yuKkAAhOuNcL, out Dictionary<ulong, RGhFDNIkuVjIouS> KHYUAfkyfZ, out Dictionary<ulong, RGhFDNIkuVjIouS> qhqRfCwmCS)
	{
		qhqRfCwmCS = new Dictionary<ulong, RGhFDNIkuVjIouS>();
		KHYUAfkyfZ = new Dictionary<ulong, RGhFDNIkuVjIouS>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr MaoGUCesvuRx = IntPtr.Zero;
		try
		{
			YcGZoNUyLA(fFXTiHjBuE, qhqRfCwmCS);
			jgoYMCOXBfJFb(fFXTiHjBuE, out MaoGUCesvuRx);
			EINjMyEIWOXby(MaoGUCesvuRx);
			KnDjTBGziLmP(ref intptr_, MaoGUCesvuRx);
			vuavHQRmyjQam(intptr_, ref KHYUAfkyfZ, yuKkAAhOuNcL, qhqRfCwmCS, MaoGUCesvuRx);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107398377), ex);
		}
		finally
		{
			if (MaoGUCesvuRx.ToInt32() != -1)
			{
				fowDTntJmGa.CloseHandle(MaoGUCesvuRx);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void YcGZoNUyLA(string string_0, Dictionary<ulong, RGhFDNIkuVjIouS> dictionary_0)
	{
		string text = getString_0(107398340) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = fowDTntJmGa.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			fowDTntJmGa.MwxJKPNSghjaz SlbFxihzWP = default(fowDTntJmGa.MwxJKPNSghjaz);
			if (fowDTntJmGa.GetFileInformationByHandle(intPtr, out SlbFxihzWP))
			{
				ulong num = SlbFxihzWP.YPUOLqlNqRFP;
				ulong key = (num << 32) | SlbFxihzWP.iTSnQeSDAOMA;
				RGhFDNIkuVjIouS value = new RGhFDNIkuVjIouS(text, 0uL);
				dictionary_0.Add(key, value);
			}
			fowDTntJmGa.CloseHandle(intPtr);
		}
	}

	private void jgoYMCOXBfJFb(string fTFbyPJAEq, out IntPtr MaoGUCesvuRx)
	{
		string string_ = getString_0(107398340) + fTFbyPJAEq;
		MaoGUCesvuRx = fowDTntJmGa.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void vuavHQRmyjQam(IntPtr intptr_0, ref Dictionary<ulong, RGhFDNIkuVjIouS> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, RGhFDNIkuVjIouS> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		fowDTntJmGa.ZeroMemory(intPtr, 65544);
		uint JjyBKitWZnnL = 0u;
		while (fowDTntJmGa.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(fowDTntJmGa.WJTnxMpwzsrxx), intPtr, 65544, out JjyBKitWZnnL, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (JjyBKitWZnnL > 60)
			{
				fowDTntJmGa.lLcyuHHXTcNO lLcyuHHXTcNO = new fowDTntJmGa.lLcyuHHXTcNO(intptr_2);
				if (0 != (lLcyuHHXTcNO.XzwTySWWZu & 0x10))
				{
					if (dictionary_1.ContainsKey(lLcyuHHXTcNO.hTwsGlYBhKak))
					{
						throw new Exception(string.Format(getString_0(107398363), lLcyuHHXTcNO.hTwsGlYBhKak, lLcyuHHXTcNO.BRNPsBTqGfQj));
					}
					dictionary_1.Add(lLcyuHHXTcNO.hTwsGlYBhKak, new RGhFDNIkuVjIouS(lLcyuHHXTcNO.BRNPsBTqGfQj, lLcyuHHXTcNO.nzELpMuvziofyW));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(lLcyuHHXTcNO.BRNPsBTqGfQj);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(lLcyuHHXTcNO.hTwsGlYBhKak))
						{
							dictionary_0.Add(lLcyuHHXTcNO.hTwsGlYBhKak, new RGhFDNIkuVjIouS(lLcyuHHXTcNO.BRNPsBTqGfQj, lLcyuHHXTcNO.nzELpMuvziofyW));
						}
						else
						{
							RGhFDNIkuVjIouS rGhFDNIkuVjIouS = dictionary_0[lLcyuHHXTcNO.hTwsGlYBhKak];
							if (0 != string.Compare(lLcyuHHXTcNO.BRNPsBTqGfQj, rGhFDNIkuVjIouS.Name, ignoreCase: true))
							{
								Console.WriteLine(getString_0(107398838), lLcyuHHXTcNO.hTwsGlYBhKak, lLcyuHHXTcNO.BRNPsBTqGfQj, rGhFDNIkuVjIouS.Name);
								throw new Exception(string.Format(getString_0(107398363), lLcyuHHXTcNO.hTwsGlYBhKak, lLcyuHHXTcNO.BRNPsBTqGfQj));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + lLcyuHHXTcNO.YzSqECEghWmI);
				JjyBKitWZnnL -= lLcyuHHXTcNO.YzSqECEghWmI;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void EINjMyEIWOXby(IntPtr intptr_0)
	{
		fowDTntJmGa.iThKKoyFnhi structure = default(fowDTntJmGa.iThKKoyFnhi);
		structure.vPVYUJqBAtmhtz = 8388608uL;
		structure.ycIAFIhfPLuj = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		fowDTntJmGa.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		fowDTntJmGa.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void KnDjTBGziLmP(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint cIbvvAaCds = 0u;
		fowDTntJmGa.yiUHJbxbUorDr UkiVmqGcpxfGnH = default(fowDTntJmGa.yiUHJbxbUorDr);
		if (fowDTntJmGa.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out UkiVmqGcpxfGnH, sizeof(fowDTntJmGa.yiUHJbxbUorDr), out cIbvvAaCds, IntPtr.Zero))
		{
			fowDTntJmGa.WJTnxMpwzsrxx structure = default(fowDTntJmGa.WJTnxMpwzsrxx);
			structure.yEpBQSfsRYJ = 0uL;
			structure.ecQtHTEkTQOzSnmP = 0L;
			structure.oUXHLtJyzDxW = UkiVmqGcpxfGnH.ngVkVSzaQPTE;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			fowDTntJmGa.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static IwzaWmnwcnlB()
	{
		Strings.CreateGetStringDelegate(typeof(IwzaWmnwcnlB));
	}
}
