using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public sealed class slbXyVBmkFjuC
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string rBPJSSfiAwALaS);

	public bool RBNXdzZVQAFiAJMA(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107362933));
	}

	static slbXyVBmkFjuC()
	{
		Strings.CreateGetStringDelegate(typeof(slbXyVBmkFjuC));
	}
}
