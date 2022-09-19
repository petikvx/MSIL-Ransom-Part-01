using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

public sealed class PEjkbesuAo
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string eZSoxuvsDyM);

	public bool YJnTvaOXFymvWeYd(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107400688));
	}

	static PEjkbesuAo()
	{
		Strings.CreateGetStringDelegate(typeof(PEjkbesuAo));
	}
}
