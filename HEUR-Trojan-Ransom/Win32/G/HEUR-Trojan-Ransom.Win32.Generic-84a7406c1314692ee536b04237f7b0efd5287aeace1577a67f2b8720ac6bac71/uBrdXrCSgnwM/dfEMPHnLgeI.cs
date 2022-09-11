using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

public sealed class dfEMPHnLgeI
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string fnoZjlNmxetTHo);

	public bool KIkInStTZGC(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107408954));
	}

	static dfEMPHnLgeI()
	{
		Strings.CreateGetStringDelegate(typeof(dfEMPHnLgeI));
	}
}
