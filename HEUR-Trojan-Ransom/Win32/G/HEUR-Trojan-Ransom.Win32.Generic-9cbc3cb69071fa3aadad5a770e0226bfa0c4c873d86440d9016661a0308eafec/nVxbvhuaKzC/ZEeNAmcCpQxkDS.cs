using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nVxbvhuaKzC;

public sealed class ZEeNAmcCpQxkDS
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string pVSoDLkStS);

	public bool EKaaTjlENBUCQI(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107405410));
	}

	static ZEeNAmcCpQxkDS()
	{
		Strings.CreateGetStringDelegate(typeof(ZEeNAmcCpQxkDS));
	}
}
