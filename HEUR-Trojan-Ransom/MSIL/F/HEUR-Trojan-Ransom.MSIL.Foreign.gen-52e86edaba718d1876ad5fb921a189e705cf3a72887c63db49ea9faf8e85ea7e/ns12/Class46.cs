using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns9;

namespace ns12;

internal sealed class Class46
{
	[NonSerialized]
	internal static GetString getString_0;

	public static Class37 smethod_0(string string_0)
	{
		return new Class37(string_0);
	}

	public static Class37 smethod_1(object object_0)
	{
		return new Class37(object_0);
	}

	static Class46()
	{
		Strings.CreateGetStringDelegate(typeof(Class46));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397648), getString_0(107397643)).Replace(getString_0(107397606), getString_0(107397601)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397596)))
		{
			throw new SecurityException(getString_0(107397571));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
