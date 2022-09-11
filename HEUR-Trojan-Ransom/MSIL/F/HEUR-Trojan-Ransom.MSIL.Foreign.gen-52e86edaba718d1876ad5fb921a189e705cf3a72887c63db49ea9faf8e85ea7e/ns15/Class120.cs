using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns15;

internal static class Class120
{
	private static bool bool_0;

	private static bool bool_1;

	[NonSerialized]
	internal static GetString getString_0;

	public static bool IsMono
	{
		get
		{
			if (!bool_0)
			{
				smethod_0();
			}
			return bool_1;
		}
	}

	private static void smethod_0()
	{
		bool_1 = Type.GetType(getString_0(107365379)) != null;
		bool_0 = true;
	}

	static Class120()
	{
		Strings.CreateGetStringDelegate(typeof(Class120));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398026), getString_0(107398021)).Replace(getString_0(107397984), getString_0(107397979)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_2: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397974)))
		{
			throw new SecurityException(getString_0(107397949));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_2, [MarshalAs(UnmanagedType.Bool)] out bool bool_3);
}
