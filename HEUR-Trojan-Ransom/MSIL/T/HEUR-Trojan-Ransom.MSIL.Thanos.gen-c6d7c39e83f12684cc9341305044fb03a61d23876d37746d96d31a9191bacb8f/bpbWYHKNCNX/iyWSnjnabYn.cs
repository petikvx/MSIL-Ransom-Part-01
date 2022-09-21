using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bpbWYHKNCNX;

public sealed class iyWSnjnabYn
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string gPMzXNevlAF);

	public bool XvqXWKXAtrbuzV(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107403034));
	}

	static iyWSnjnabYn()
	{
		Strings.CreateGetStringDelegate(typeof(iyWSnjnabYn));
	}
}
