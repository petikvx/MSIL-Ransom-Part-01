using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bmDbQpaZORfnY;

public sealed class fMzozyDPnFPucI
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string KXtDdKqrzpkzQ);

	public bool dxDBhZVDUbiD(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107401374));
	}

	static fMzozyDPnFPucI()
	{
		Strings.CreateGetStringDelegate(typeof(fMzozyDPnFPucI));
	}
}
