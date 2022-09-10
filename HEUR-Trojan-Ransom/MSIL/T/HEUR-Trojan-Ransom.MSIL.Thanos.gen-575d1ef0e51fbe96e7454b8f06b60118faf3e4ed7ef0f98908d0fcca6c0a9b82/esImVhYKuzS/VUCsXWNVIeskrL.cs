using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace esImVhYKuzS;

public sealed class VUCsXWNVIeskrL
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string tGAsiqtTmiEBVWG);

	public bool jSQKoCNPHlxV(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107399136));
	}

	static VUCsXWNVIeskrL()
	{
		Strings.CreateGetStringDelegate(typeof(VUCsXWNVIeskrL));
	}
}
