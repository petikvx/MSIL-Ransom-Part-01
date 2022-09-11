using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace PAvKfaIFZl;

public sealed class FntIdrUCcqfQMx
{
	[NonSerialized]
	internal static GetString getString_0;

	public void EdJeFavqgTF(string OZLbzkLGLvSGhgQw, HashSet<string> GVaTZFTnxyxLelDR, out Dictionary<ulong, XovkoNBycBOnCD> afKPlNSlarL, out Dictionary<ulong, XovkoNBycBOnCD> SXJEfVrOrn)
	{
		SXJEfVrOrn = new Dictionary<ulong, XovkoNBycBOnCD>();
		afKPlNSlarL = new Dictionary<ulong, XovkoNBycBOnCD>();
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr gwjBGPWUKSJpXTG = IntPtr.Zero;
		try
		{
			XjqEmjinkZKZk(OZLbzkLGLvSGhgQw, SXJEfVrOrn);
			OTctVVVHOet(OZLbzkLGLvSGhgQw, out gwjBGPWUKSJpXTG);
			ntJOBpzyLfRQlGS(gwjBGPWUKSJpXTG);
			qUHGrTSuspYO(ref intptr_, gwjBGPWUKSJpXTG);
			emgMShqtLjRKN(intptr_, ref afKPlNSlarL, GVaTZFTnxyxLelDR, SXJEfVrOrn, gwjBGPWUKSJpXTG);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException(getString_0(107408609), ex);
		}
		finally
		{
			if (gwjBGPWUKSJpXTG.ToInt32() != -1)
			{
				WtlVoBgNqjipbDL.CloseHandle(gwjBGPWUKSJpXTG);
			}
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_);
			}
		}
	}

	private void XjqEmjinkZKZk(string string_0, Dictionary<ulong, XovkoNBycBOnCD> dictionary_0)
	{
		string text = getString_0(107409084) + string_0;
		text += Path.DirectorySeparatorChar;
		IntPtr intPtr = WtlVoBgNqjipbDL.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (intPtr.ToInt32() != -1)
		{
			WtlVoBgNqjipbDL.VgdhfvFbUVA xxgyGvYDqcjc = default(WtlVoBgNqjipbDL.VgdhfvFbUVA);
			if (WtlVoBgNqjipbDL.GetFileInformationByHandle(intPtr, out xxgyGvYDqcjc))
			{
				ulong num = xxgyGvYDqcjc.DlNFpQpnggHM;
				ulong key = (num << 32) | xxgyGvYDqcjc.jMdIfgfXKZQn;
				XovkoNBycBOnCD value = new XovkoNBycBOnCD(text, 0uL);
				dictionary_0.Add(key, value);
			}
			WtlVoBgNqjipbDL.CloseHandle(intPtr);
		}
	}

	private void OTctVVVHOet(string wfpMdQnsjzIs, out IntPtr gwjBGPWUKSJpXTG)
	{
		string string_ = getString_0(107409084) + wfpMdQnsjzIs;
		gwjBGPWUKSJpXTG = WtlVoBgNqjipbDL.CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void emgMShqtLjRKN(IntPtr intptr_0, ref Dictionary<ulong, XovkoNBycBOnCD> dictionary_0, HashSet<string> hashSet_0, Dictionary<ulong, XovkoNBycBOnCD> dictionary_1, IntPtr intptr_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		WtlVoBgNqjipbDL.ZeroMemory(intPtr, 65544);
		uint MvwpdIRJMMt = 0u;
		while (WtlVoBgNqjipbDL.DeviceIoControl_1(intptr_1, 590003u, intptr_0, sizeof(WtlVoBgNqjipbDL.IlOhtamJSJc), intPtr, 65544, out MvwpdIRJMMt, IntPtr.Zero))
		{
			IntPtr intptr_2 = new IntPtr(intPtr.ToInt32() + 8);
			while (MvwpdIRJMMt > 60)
			{
				WtlVoBgNqjipbDL.bbsMQUynbhF bbsMQUynbhF = new WtlVoBgNqjipbDL.bbsMQUynbhF(intptr_2);
				if (0 != (bbsMQUynbhF.LUfkbeziSd & 0x10))
				{
					if (dictionary_1.ContainsKey(bbsMQUynbhF.IFXYkcfMcKavWN))
					{
						throw new Exception(string.Format(getString_0(107409043), bbsMQUynbhF.IFXYkcfMcKavWN, bbsMQUynbhF.rSrtuFDJaoZnp));
					}
					dictionary_1.Add(bbsMQUynbhF.IFXYkcfMcKavWN, new XovkoNBycBOnCD(bbsMQUynbhF.rSrtuFDJaoZnp, bbsMQUynbhF.TgnGXIpbki));
				}
				else
				{
					bool flag = true;
					if (hashSet_0 != null)
					{
						string extension = Path.GetExtension(bbsMQUynbhF.rSrtuFDJaoZnp);
						flag = hashSet_0.Contains(extension);
					}
					if (flag)
					{
						if (!dictionary_0.ContainsKey(bbsMQUynbhF.IFXYkcfMcKavWN))
						{
							dictionary_0.Add(bbsMQUynbhF.IFXYkcfMcKavWN, new XovkoNBycBOnCD(bbsMQUynbhF.rSrtuFDJaoZnp, bbsMQUynbhF.TgnGXIpbki));
						}
						else
						{
							XovkoNBycBOnCD xovkoNBycBOnCD = dictionary_0[bbsMQUynbhF.IFXYkcfMcKavWN];
							if (0 != string.Compare(bbsMQUynbhF.rSrtuFDJaoZnp, xovkoNBycBOnCD.Name, ignoreCase: true))
							{
								Console.WriteLine(getString_0(107409006), bbsMQUynbhF.IFXYkcfMcKavWN, bbsMQUynbhF.rSrtuFDJaoZnp, xovkoNBycBOnCD.Name);
								throw new Exception(string.Format(getString_0(107409043), bbsMQUynbhF.IFXYkcfMcKavWN, bbsMQUynbhF.rSrtuFDJaoZnp));
							}
						}
					}
				}
				intptr_2 = new IntPtr(intptr_2.ToInt32() + bbsMQUynbhF.KTzaBpjsSVBf);
				MvwpdIRJMMt -= bbsMQUynbhF.KTzaBpjsSVBf;
			}
			Marshal.WriteInt64(intptr_0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void ntJOBpzyLfRQlGS(IntPtr intptr_0)
	{
		WtlVoBgNqjipbDL.ZrPxKPDFhjtBWSO structure = default(WtlVoBgNqjipbDL.ZrPxKPDFhjtBWSO);
		structure.LHdJkwsUPsaU = 8388608uL;
		structure.bKoYMdsnFoD = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		WtlVoBgNqjipbDL.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		WtlVoBgNqjipbDL.DeviceIoControl_1(intptr_0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void qUHGrTSuspYO(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		uint SKAxKbgHnNlY = 0u;
		WtlVoBgNqjipbDL.mWQXPMYfvQy mjFmsIGKeSGRCL = default(WtlVoBgNqjipbDL.mWQXPMYfvQy);
		if (WtlVoBgNqjipbDL.DeviceIoControl(intptr_1, 590068u, IntPtr.Zero, 0, out mjFmsIGKeSGRCL, sizeof(WtlVoBgNqjipbDL.mWQXPMYfvQy), out SKAxKbgHnNlY, IntPtr.Zero))
		{
			WtlVoBgNqjipbDL.IlOhtamJSJc structure = default(WtlVoBgNqjipbDL.IlOhtamJSJc);
			structure.sBBUxMLmPSJAGT = 0uL;
			structure.bzawjjpNMLbD = 0L;
			structure.pwjiOKnlBFLEsuo = mjFmsIGKeSGRCL.sabncygssewn;
			int num = Marshal.SizeOf(structure);
			intptr_0 = Marshal.AllocHGlobal(num);
			WtlVoBgNqjipbDL.ZeroMemory(intptr_0, num);
			Marshal.StructureToPtr(structure, intptr_0, fDeleteOld: true);
		}
	}

	static FntIdrUCcqfQMx()
	{
		Strings.CreateGetStringDelegate(typeof(FntIdrUCcqfQMx));
	}
}
