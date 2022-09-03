using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace vlFwgXmbIo;

public sealed class GyjxqaSPQe
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string aIIUpxtqXJOYi);

	public bool ZQZXBbcsBMnvz(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107402105));
	}

	static GyjxqaSPQe()
	{
		Strings.CreateGetStringDelegate(typeof(GyjxqaSPQe));
	}
}
