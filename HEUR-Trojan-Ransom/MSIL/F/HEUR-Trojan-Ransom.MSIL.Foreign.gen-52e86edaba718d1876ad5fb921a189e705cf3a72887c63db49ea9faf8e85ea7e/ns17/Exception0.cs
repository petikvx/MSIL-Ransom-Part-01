using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns17;

internal sealed class Exception0 : Exception
{
	[NonSerialized]
	internal static GetString getString_0;

	public Exception0(string string_0)
		: base(string_0)
	{
	}

	public Exception0(string string_0, Exception exception_0)
		: base(string_0, exception_0)
	{
	}

	static Exception0()
	{
		Strings.CreateGetStringDelegate(typeof(Exception0));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399555), getString_0(107399550)).Replace(getString_0(107399513), getString_0(107399508)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399503)))
		{
			throw new SecurityException(getString_0(107399478));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
