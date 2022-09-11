using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns17;

internal static class Class99
{
	public static readonly string string_0;

	public static readonly string string_1;

	public static readonly string string_2;

	public static readonly string string_3;

	public static readonly string string_4;

	public static readonly string string_5;

	public static readonly string string_6;

	public static readonly string string_7;

	public static readonly string string_8;

	[NonSerialized]
	internal static GetString getString_0;

	static Class99()
	{
		Strings.CreateGetStringDelegate(typeof(Class99));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397832), getString_0(107397827)).Replace(getString_0(107397790), getString_0(107397785)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397780)))
		{
			throw new SecurityException(getString_0(107397755));
		}
		string_0 = getString_0(107406784);
		string_1 = getString_0(107406791);
		string_2 = getString_0(107406758);
		string_3 = getString_0(107406398);
		string_4 = getString_0(107406737);
		string_5 = getString_0(107407303);
		string_6 = getString_0(107406728);
		string_7 = getString_0(107406675);
		string_8 = getString_0(107406654);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_9, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
