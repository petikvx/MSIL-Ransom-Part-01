using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eMvPcEiNWKRwo;

public sealed class RoipdntborQL
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string MccGVXljCSw);

	public bool jcavobxzlIUa(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107405745));
	}

	static RoipdntborQL()
	{
		Strings.CreateGetStringDelegate(typeof(RoipdntborQL));
	}
}
