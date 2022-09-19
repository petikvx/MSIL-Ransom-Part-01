using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

public sealed class mbfZkiAFZEWw
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string bIhWkNjGLBYN);

	public bool cXstDkUvoPpm(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107399101));
	}

	static mbfZkiAFZEWw()
	{
		Strings.CreateGetStringDelegate(typeof(mbfZkiAFZEWw));
	}
}
