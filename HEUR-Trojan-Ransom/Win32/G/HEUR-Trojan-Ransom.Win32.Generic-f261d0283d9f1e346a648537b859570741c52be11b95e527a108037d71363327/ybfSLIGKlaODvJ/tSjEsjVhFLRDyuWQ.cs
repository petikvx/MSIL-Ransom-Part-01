using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ybfSLIGKlaODvJ;

public sealed class tSjEsjVhFLRDyuWQ
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string OkJJGsbAfVeNHRl);

	public bool mfWczWUMLYhnzT(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107398091));
	}

	static tSjEsjVhFLRDyuWQ()
	{
		Strings.CreateGetStringDelegate(typeof(tSjEsjVhFLRDyuWQ));
	}
}
