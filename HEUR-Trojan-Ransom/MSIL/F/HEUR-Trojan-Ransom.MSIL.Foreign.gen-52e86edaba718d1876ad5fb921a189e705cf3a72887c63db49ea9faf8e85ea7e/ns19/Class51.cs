using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns13;
using ns8;

namespace ns19;

internal sealed class Class51 : Class50
{
	[NonSerialized]
	internal static GetString getString_2;

	internal Class51(Class79 class79_1)
		: base(class79_1)
	{
	}

	static Class51()
	{
		Strings.CreateGetStringDelegate(typeof(Class51));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_2(107397685), getString_2(107397680)).Replace(getString_2(107397643), getString_2(107397638)));
		if (!StrongNameSignatureVerificationEx_2(uri.LocalPath, bool_3: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_2(107397633)))
		{
			throw new SecurityException(getString_2(107397608));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx_2([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_3, [MarshalAs(UnmanagedType.Bool)] out bool bool_4);
}
