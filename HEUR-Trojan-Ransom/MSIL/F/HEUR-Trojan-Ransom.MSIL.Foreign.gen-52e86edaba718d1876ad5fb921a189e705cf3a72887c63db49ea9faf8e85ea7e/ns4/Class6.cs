using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns4;

internal sealed class Class6
{
	public bool bool_0 = false;

	public Timer timer_0;

	public bool bool_1 = false;

	public int int_0 = 1;

	[NonSerialized]
	internal static GetString getString_0;

	static Class6()
	{
		Strings.CreateGetStringDelegate(typeof(Class6));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107396836), getString_0(107396831)).Replace(getString_0(107396794), getString_0(107396789)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_2: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107396784)))
		{
			throw new SecurityException(getString_0(107396759));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_2, [MarshalAs(UnmanagedType.Bool)] out bool bool_3);
}
