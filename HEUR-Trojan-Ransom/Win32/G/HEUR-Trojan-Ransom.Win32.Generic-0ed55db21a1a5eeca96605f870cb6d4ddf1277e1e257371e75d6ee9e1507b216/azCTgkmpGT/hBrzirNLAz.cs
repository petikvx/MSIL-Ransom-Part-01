using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public sealed class hBrzirNLAz
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string lxGHRSPGWLOE);

	public bool GKYsKpmSoqlXyDMz(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107375879));
	}

	static hBrzirNLAz()
	{
		Strings.CreateGetStringDelegate(typeof(hBrzirNLAz));
	}
}
