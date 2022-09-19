using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

public sealed class fqIueWgOQEK
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string DtZUKNdmGxxDT);

	public bool uUMSRroBuQWna(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107375868));
	}

	static fqIueWgOQEK()
	{
		Strings.CreateGetStringDelegate(typeof(fqIueWgOQEK));
	}
}
