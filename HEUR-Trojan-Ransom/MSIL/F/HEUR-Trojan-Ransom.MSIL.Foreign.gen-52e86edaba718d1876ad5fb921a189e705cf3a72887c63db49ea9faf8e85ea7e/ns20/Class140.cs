using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;

namespace ns20;

internal sealed class Class140 : IDisposable
{
	private bool bool_0;

	private Class139 class139_0;

	[NonSerialized]
	internal static GetString getString_0;

	public Class140(Class139 class139_1, int int_0)
	{
		class139_0 = class139_1;
		if (class139_1 != null)
		{
			bool_0 = class139_1.method_12(int_0);
		}
	}

	void IDisposable.Dispose()
	{
		if (bool_0)
		{
			bool_0 = false;
			class139_0.method_13();
			class139_0 = null;
		}
	}

	static Class140()
	{
		Strings.CreateGetStringDelegate(typeof(Class140));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398302), getString_0(107398297)).Replace(getString_0(107398260), getString_0(107398255)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_1: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398250)))
		{
			throw new SecurityException(getString_0(107398225));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.Bool)] out bool bool_2);
}
