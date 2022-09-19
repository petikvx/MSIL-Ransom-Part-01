using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public sealed class jXmmwQRRLpp
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string QRYhbXbezdpPmKD);

	public bool EBPsQUzBBDij(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107378200));
	}

	static jXmmwQRRLpp()
	{
		Strings.CreateGetStringDelegate(typeof(jXmmwQRRLpp));
	}
}
