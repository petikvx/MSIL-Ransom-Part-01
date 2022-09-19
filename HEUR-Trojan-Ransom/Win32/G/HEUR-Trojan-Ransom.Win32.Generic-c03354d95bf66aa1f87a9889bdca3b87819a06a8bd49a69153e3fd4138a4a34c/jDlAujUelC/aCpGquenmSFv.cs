using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jDlAujUelC;

public sealed class aCpGquenmSFv
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string CRSqUUNorEkWJzp);

	public bool advpQeGLuA(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107350189));
	}

	static aCpGquenmSFv()
	{
		Strings.CreateGetStringDelegate(typeof(aCpGquenmSFv));
	}
}
