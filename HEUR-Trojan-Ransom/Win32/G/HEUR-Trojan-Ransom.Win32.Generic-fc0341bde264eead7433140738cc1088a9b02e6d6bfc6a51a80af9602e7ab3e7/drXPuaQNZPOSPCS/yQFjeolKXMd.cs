using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace drXPuaQNZPOSPCS;

public sealed class yQFjeolKXMd
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string nZNCKBKnpJVf);

	public bool noDvZcrtQzqfZg(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107399168));
	}

	static yQFjeolKXMd()
	{
		Strings.CreateGetStringDelegate(typeof(yQFjeolKXMd));
	}
}
