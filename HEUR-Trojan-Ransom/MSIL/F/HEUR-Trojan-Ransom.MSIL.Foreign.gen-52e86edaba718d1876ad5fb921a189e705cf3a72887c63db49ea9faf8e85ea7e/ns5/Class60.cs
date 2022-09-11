using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns18;

namespace ns5;

internal sealed class Class60 : Class59<Class60, Class42, Class54>
{
	[NonSerialized]
	internal static GetString getString_0;

	internal Class60(Class42 class42_0, string string_0)
		: base(class42_0, string_0)
	{
		base.FilterData.bool_0 = true;
	}

	public override Class54 vmethod_0()
	{
		return vmethod_1(base.Target.Session.XSession.method_25, this);
	}

	static Class60()
	{
		Strings.CreateGetStringDelegate(typeof(Class60));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397696), getString_0(107397691)).Replace(getString_0(107397654), getString_0(107397649)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397644)))
		{
			throw new SecurityException(getString_0(107397619));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
