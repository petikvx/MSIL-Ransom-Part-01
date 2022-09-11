using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns21;
using ns22;

namespace ns11;

internal abstract class Class85
{
	[NonSerialized]
	internal static GetString getString_0;

	public abstract List<byte[]> vmethod_0(Class48 class48_0);

	public abstract void vmethod_1(string string_0, params object[] object_0);

	public abstract bool vmethod_2(Class48 class48_0);

	public abstract List<Class47> vmethod_3();

	public abstract void vmethod_4(Class48 class48_0);

	static Class85()
	{
		Strings.CreateGetStringDelegate(typeof(Class85));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397799), getString_0(107397794)).Replace(getString_0(107397757), getString_0(107397752)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397747)))
		{
			throw new SecurityException(getString_0(107397722));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
