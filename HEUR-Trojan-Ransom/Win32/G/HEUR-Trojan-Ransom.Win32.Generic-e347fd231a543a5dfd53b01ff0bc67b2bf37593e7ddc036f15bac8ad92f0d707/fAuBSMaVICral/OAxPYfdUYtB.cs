using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fAuBSMaVICral;

public sealed class OAxPYfdUYtB
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string fNCDEdThcaTJ);

	public bool kBVxeUnZtOC(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107460142));
	}

	static OAxPYfdUYtB()
	{
		Strings.CreateGetStringDelegate(typeof(OAxPYfdUYtB));
	}
}
