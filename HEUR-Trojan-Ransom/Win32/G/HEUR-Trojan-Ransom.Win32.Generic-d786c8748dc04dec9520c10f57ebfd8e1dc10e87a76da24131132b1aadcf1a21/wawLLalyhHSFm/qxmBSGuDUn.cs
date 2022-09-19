using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wawLLalyhHSFm;

public sealed class qxmBSGuDUn
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string QEuSvQSWOBFhbJ);

	public bool BIKmJflQUBqn(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107363358));
	}

	static qxmBSGuDUn()
	{
		Strings.CreateGetStringDelegate(typeof(qxmBSGuDUn));
	}
}
