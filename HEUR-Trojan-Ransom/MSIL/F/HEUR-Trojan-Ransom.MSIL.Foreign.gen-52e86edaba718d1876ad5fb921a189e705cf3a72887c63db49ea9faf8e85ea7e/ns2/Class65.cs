using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns13;
using ns18;
using ns5;

namespace ns2;

internal sealed class Class65 : Class59<Class65, Class39, Class54>
{
	[NonSerialized]
	internal static GetString getString_0;

	internal Class65(Class39 class39_0, string string_0)
		: base(class39_0, string_0)
	{
	}

	public override Class54 vmethod_0()
	{
		return vmethod_1(base.Target.Session.XSession.method_24, this);
	}

	static Class65()
	{
		Strings.CreateGetStringDelegate(typeof(Class65));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397759), getString_0(107397754)).Replace(getString_0(107397717), getString_0(107397712)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397707)))
		{
			throw new SecurityException(getString_0(107397682));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
