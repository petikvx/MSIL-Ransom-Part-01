using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace DFgOqDzZpZe;

public sealed class NTQxrgSdsWceAc
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string AoVDqXoYZTqtDW);

	public bool mAZxWbHOwVEf(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107364333));
	}

	static NTQxrgSdsWceAc()
	{
		Strings.CreateGetStringDelegate(typeof(NTQxrgSdsWceAc));
	}
}
