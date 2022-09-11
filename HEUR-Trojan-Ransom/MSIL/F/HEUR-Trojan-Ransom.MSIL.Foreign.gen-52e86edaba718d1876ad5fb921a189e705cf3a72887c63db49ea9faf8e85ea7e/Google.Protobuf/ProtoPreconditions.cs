using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf;

public static class ProtoPreconditions
{
	[NonSerialized]
	internal static GetString getString_0;

	public static T CheckNotNull<T>(T value, string name) where T : class
	{
		if (value == null)
		{
			throw new ArgumentNullException(name);
		}
		return value;
	}

	internal static T CheckNotNullUnconstrained<T>(T value, string name)
	{
		if (value == null)
		{
			throw new ArgumentNullException(name);
		}
		return value;
	}

	static ProtoPreconditions()
	{
		Strings.CreateGetStringDelegate(typeof(ProtoPreconditions));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399837), getString_0(107399832)).Replace(getString_0(107399795), getString_0(107399790)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399785)))
		{
			throw new SecurityException(getString_0(107399760));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
