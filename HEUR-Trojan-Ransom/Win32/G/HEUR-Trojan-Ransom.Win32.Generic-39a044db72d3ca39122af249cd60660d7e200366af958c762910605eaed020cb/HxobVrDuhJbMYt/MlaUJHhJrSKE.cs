using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HxobVrDuhJbMYt;

public sealed class MlaUJHhJrSKE
{
	[NonSerialized]
	internal static GetString getString_0;

	public void wByqwxhiyFl(string zSsKQkKCrFeIypmWZ, HashSet<string> JiutUDZUZXBN, out Dictionary<ulong, vDHOYTKrzyM> yAOhyjqrEHfWtaCa, out Dictionary<ulong, vDHOYTKrzyM> itivqyGNUYVHKq)
	{
		itivqyGNUYVHKq = new Dictionary<ulong, vDHOYTKrzyM>();
		yAOhyjqrEHfWtaCa = new Dictionary<ulong, vDHOYTKrzyM>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr fuLaEOMajtqW = IntPtr.Zero;
		try
		{
			xXtYReCERGisdF(zSsKQkKCrFeIypmWZ, itivqyGNUYVHKq);
			bIkiMWVmMe(zSsKQkKCrFeIypmWZ, out fuLaEOMajtqW);
			ihUgGGEjMzCtR(fuLaEOMajtqW);
			tFmZgkPiKJbbcQZ(ref intptr_, fuLaEOMajtqW);
			YkozDIENKgfDl(intptr_, ref yAOhyjqrEHfWtaCa, JiutUDZUZXBN, itivqyGNUYVHKq, fuLaEOMajtqW);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107409027), ex);
		}
		finally
		{
			if (fuLaEOMajtqW.ToInt32() != -1)
			{
				WOUSvMaKfSyhnht.CloseHandle(fuLaEOMajtqW);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void xXtYReCERGisdF(string string_0, Dictionary<ulong, vDHOYTKrzyM> dictionary_0)
	{
		string text = getString_0(107408990) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = WOUSvMaKfSyhnht.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			WOUSvMaKfSyhnht.WAANxQkDJvO BgxSmxnZQJSZRnq = default(WOUSvMaKfSyhnht.WAANxQkDJvO);
			if (WOUSvMaKfSyhnht.GetFileInformationByHandle(intPtr, out BgxSmxnZQJSZRnq))
			{
				ulong num = BgxSmxnZQJSZRnq.HtVebOulCGg;
				ulong key = (num << 32) | BgxSmxnZQJSZRnq.EXXShcTKkwwObl;
				vDHOYTKrzyM value = new vDHOYTKrzyM(text, 0uL);
				dictionary_0.Add(key, value);
			}
			WOUSvMaKfSyhnht.CloseHandle(intPtr);
		}
	}

	private void bIkiMWVmMe(string WbNSdLdhxAjK, out IntPtr fuLaEOMajtqW)
	{
		string string_ = getString_0(107408990) + WbNSdLdhxAjK;
		fuLaEOMajtqW = WOUSvMaKfSyhnht.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void YkozDIENKgfDl(IntPtr intptr_0, ref Dictionary<ulong, vDHOYTKrzyM> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, vDHOYTKrzyM> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		WOUSvMaKfSyhnht.ZeroMemory(intPtr, 65544);
		uint wovtcCSHQaz = 0u;
		while (WOUSvMaKfSyhnht.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(WOUSvMaKfSyhnht.dSJwACSETVbtC), intPtr, 65544, out wovtcCSHQaz, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (wovtcCSHQaz > 60)
			{
				WOUSvMaKfSyhnht.SsEvFJslIcFio ssEvFJslIcFio = new WOUSvMaKfSyhnht.SsEvFJslIcFio(intptr_2);
				if (0 != (ssEvFJslIcFio.uiDngBrIucD & 0x10))
				{
					if (dictionary_1.ContainsKey(ssEvFJslIcFio.WLRgNPtunaMZKU))
					{
						throw new Exception(string.Format(getString_0(107408981), ssEvFJslIcFio.WLRgNPtunaMZKU, ssEvFJslIcFio.YEBKuKykjSz));
					}
					dictionary_1.Add(ssEvFJslIcFio.WLRgNPtunaMZKU, new vDHOYTKrzyM(ssEvFJslIcFio.YEBKuKykjSz, ssEvFJslIcFio.QYESlNsOGSZe));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(ssEvFJslIcFio.YEBKuKykjSz);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(ssEvFJslIcFio.WLRgNPtunaMZKU))
						{
							dictionary_0.Add(ssEvFJslIcFio.WLRgNPtunaMZKU, new vDHOYTKrzyM(ssEvFJslIcFio.YEBKuKykjSz, ssEvFJslIcFio.QYESlNsOGSZe));
						}
						else
						{
							vDHOYTKrzyM vDHOYTKrzyM2 = dictionary_0[ssEvFJslIcFio.WLRgNPtunaMZKU];
							if (0 != string.Compare(ssEvFJslIcFio.YEBKuKykjSz, vDHOYTKrzyM2.Name, ignoreCase: true))
							{
								Console.WriteLine(getString_0(107408912), ssEvFJslIcFio.WLRgNPtunaMZKU, ssEvFJslIcFio.YEBKuKykjSz, vDHOYTKrzyM2.Name);
								throw new Exception(string.Format(getString_0(107408981), ssEvFJslIcFio.WLRgNPtunaMZKU, ssEvFJslIcFio.YEBKuKykjSz));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + ssEvFJslIcFio.VsygIJSpySlH);
				wovtcCSHQaz -= ssEvFJslIcFio.VsygIJSpySlH;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void ihUgGGEjMzCtR(IntPtr intptr_0)
	{
		WOUSvMaKfSyhnht.xGupZZOPoPxAnTg structure = default(WOUSvMaKfSyhnht.xGupZZOPoPxAnTg);
		structure.fEgBJqmvnsXT = 8388608uL;
		structure.GCyLaDAbZISQ = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		WOUSvMaKfSyhnht.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		WOUSvMaKfSyhnht.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void tFmZgkPiKJbbcQZ(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint BXCkPINuODrA = 0u;
		WOUSvMaKfSyhnht.HTaMExqdETGNm kayLyvqcvkJPoX = default(WOUSvMaKfSyhnht.HTaMExqdETGNm);
		if (WOUSvMaKfSyhnht.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out kayLyvqcvkJPoX, sizeof(WOUSvMaKfSyhnht.HTaMExqdETGNm), out BXCkPINuODrA, IntPtr.Zero))
		{
			WOUSvMaKfSyhnht.dSJwACSETVbtC structure = default(WOUSvMaKfSyhnht.dSJwACSETVbtC);
			structure.FnQYdLJBXxxIR = 0uL;
			structure.VOyoeiCCTO = 0L;
			structure.PJuaqdWNUllGYR = kayLyvqcvkJPoX.hBLAirbZyQeW;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			WOUSvMaKfSyhnht.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static MlaUJHhJrSKE()
	{
		Strings.CreateGetStringDelegate(typeof(MlaUJHhJrSKE));
	}
}
