using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NS002;

public sealed class IwzaWmnwcnlB
{
	[NonSerialized]
	internal static GetString f000047;

	public void CJkuFhqIgKwiFDo(string fFXTiHjBuE, HashSet<string> p1, out Dictionary<ulong, c00001f> p2, out Dictionary<ulong, c00001f> p3)
	{
		p3 = new Dictionary<ulong, c00001f>();
		p2 = new Dictionary<ulong, c00001f>();
		IntPtr p4 = IntPtr.Zero;
		IntPtr MaoGUCesvuRx = IntPtr.Zero;
		try
		{
			YcGZoNUyLA(fFXTiHjBuE, p3);
			m000030(fFXTiHjBuE, out MaoGUCesvuRx);
			m000031(MaoGUCesvuRx);
			KnDjTBGziLmP(ref p4, MaoGUCesvuRx);
			vuavHQRmyjQam(p4, ref p2, p1, p3, MaoGUCesvuRx);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, ex);
			for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
			{
				Console.WriteLine(innerException.Message, innerException);
			}
			throw new ApplicationException("Error in EnumerateVolume()", ex);
		}
		finally
		{
			if (MaoGUCesvuRx.ToInt32() != -1)
			{
				fowDTntJmGa.CloseHandle(MaoGUCesvuRx);
			}
			if (p4 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(p4);
			}
		}
	}

	private void YcGZoNUyLA(string p0, Dictionary<ulong, c00001f> p1)
	{
		string text = "\\\\.\\" + p0;
		text += Path.DirectorySeparatorChar;
		IntPtr p2 = fowDTntJmGa.CreateFile(text, 0u, 3u, IntPtr.Zero, 3u, 33554432u, IntPtr.Zero);
		if (p2.ToInt32() != -1)
		{
			fowDTntJmGa.MwxJKPNSghjaz SlbFxihzWP = default(fowDTntJmGa.MwxJKPNSghjaz);
			if (fowDTntJmGa.GetFileInformationByHandle(p2, out SlbFxihzWP))
			{
				ulong num = SlbFxihzWP.f00005e;
				ulong key = (num << 32) | SlbFxihzWP.f00005f;
				c00001f value = new c00001f(text, 0uL);
				p1.Add(key, value);
			}
			fowDTntJmGa.CloseHandle(p2);
		}
	}

	private void m000030(string p0, out IntPtr MaoGUCesvuRx)
	{
		string p = "\\\\.\\" + p0;
		MaoGUCesvuRx = fowDTntJmGa.CreateFile(p, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
	}

	private unsafe void vuavHQRmyjQam(IntPtr p0, ref Dictionary<ulong, c00001f> p1, HashSet<string> p2, Dictionary<ulong, c00001f> p3, IntPtr p4)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(65544);
		fowDTntJmGa.ZeroMemory(intPtr, 65544);
		uint JjyBKitWZnnL = 0u;
		while (fowDTntJmGa.DeviceIoControl(p4, 590003u, p0, sizeof(fowDTntJmGa.WJTnxMpwzsrxx), intPtr, 65544, out JjyBKitWZnnL, IntPtr.Zero))
		{
			IntPtr p5 = new IntPtr(intPtr.ToInt32() + 8);
			while (JjyBKitWZnnL > 60)
			{
				fowDTntJmGa.c000029 c21 = new fowDTntJmGa.c000029(p5);
				if (0 == (c21.XzwTySWWZu & 0x10))
				{
					bool flag = true;
					if (p2 != null)
					{
						string extension = Path.GetExtension(c21.BRNPsBTqGfQj);
						flag = p2.Contains(extension);
					}
					if (flag)
					{
						if (!p1.ContainsKey(c21.hTwsGlYBhKak))
						{
							p1.Add(c21.hTwsGlYBhKak, new c00001f(c21.BRNPsBTqGfQj, c21.nzELpMuvziofyW));
						}
						else
						{
							c00001f c00001f2 = p1[c21.hTwsGlYBhKak];
							if (0 != string.Compare(c21.BRNPsBTqGfQj, c00001f2.Name, ignoreCase: true))
							{
								Console.WriteLine("Attempt to add duplicate file reference number: {0} for file {1}, file from index {2}", c21.hTwsGlYBhKak, c21.BRNPsBTqGfQj, c00001f2.Name);
								throw new Exception($"Duplicate FRN: {c21.hTwsGlYBhKak} for {c21.BRNPsBTqGfQj}");
							}
						}
					}
				}
				else
				{
					if (p3.ContainsKey(c21.hTwsGlYBhKak))
					{
						throw new Exception($"Duplicate FRN: {c21.hTwsGlYBhKak} for {c21.BRNPsBTqGfQj}");
					}
					p3.Add(c21.hTwsGlYBhKak, new c00001f(c21.BRNPsBTqGfQj, c21.nzELpMuvziofyW));
				}
				p5 = new IntPtr(p5.ToInt32() + c21.YzSqECEghWmI);
				JjyBKitWZnnL -= c21.YzSqECEghWmI;
			}
			Marshal.WriteInt64(p0, Marshal.ReadInt64(intPtr, 0));
		}
		Marshal.FreeHGlobal(intPtr);
	}

	private void m000031(IntPtr p0)
	{
		fowDTntJmGa.iThKKoyFnhi structure = default(fowDTntJmGa.iThKKoyFnhi);
		structure.f000062 = 8388608uL;
		structure.ycIAFIhfPLuj = 1048576uL;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		fowDTntJmGa.ZeroMemory(intPtr, num);
		Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
		fowDTntJmGa.DeviceIoControl(p0, 590055u, intPtr, num, IntPtr.Zero, 0, out var _, IntPtr.Zero);
	}

	private unsafe void KnDjTBGziLmP(ref IntPtr p0, IntPtr p1)
	{
		uint cIbvvAaCds = 0u;
		fowDTntJmGa.yiUHJbxbUorDr p2 = default(fowDTntJmGa.yiUHJbxbUorDr);
		if (fowDTntJmGa.DeviceIoControl(p1, 590068u, IntPtr.Zero, 0, out p2, sizeof(fowDTntJmGa.yiUHJbxbUorDr), out cIbvvAaCds, IntPtr.Zero))
		{
			fowDTntJmGa.WJTnxMpwzsrxx structure = default(fowDTntJmGa.WJTnxMpwzsrxx);
			structure.f000063 = 0uL;
			structure.f000064 = 0L;
			structure.f000065 = p2.f000061;
			int num = Marshal.SizeOf(structure);
			p0 = Marshal.AllocHGlobal(num);
			fowDTntJmGa.ZeroMemory(p0, num);
			Marshal.StructureToPtr(structure, p0, fDeleteOld: true);
		}
	}

	static IwzaWmnwcnlB()
	{
		Strings.CreateGetStringDelegate(typeof(IwzaWmnwcnlB));
	}
}
