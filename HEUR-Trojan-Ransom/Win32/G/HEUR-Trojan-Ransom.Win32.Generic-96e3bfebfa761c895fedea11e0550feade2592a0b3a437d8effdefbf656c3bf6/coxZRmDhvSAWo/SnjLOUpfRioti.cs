using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public sealed class SnjLOUpfRioti
{
	[NonSerialized]
	internal static GetString f00004a;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string p0);

	public bool fwTUnyzIwakYqxR(string p0)
	{
		return DeleteFile(p0 + ":Zone.Identifier");
	}

	static SnjLOUpfRioti()
	{
		Strings.CreateGetStringDelegate(typeof(SnjLOUpfRioti));
	}
}
