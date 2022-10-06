using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KNpKkassJHAdE;

public sealed class qgJBARYOVEIp
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string lfQifBOEVbqjEVl);

	public bool GiGCbTRccdaXtRKR(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107460104));
	}

	static qgJBARYOVEIp()
	{
		Strings.CreateGetStringDelegate(typeof(qgJBARYOVEIp));
	}
}
