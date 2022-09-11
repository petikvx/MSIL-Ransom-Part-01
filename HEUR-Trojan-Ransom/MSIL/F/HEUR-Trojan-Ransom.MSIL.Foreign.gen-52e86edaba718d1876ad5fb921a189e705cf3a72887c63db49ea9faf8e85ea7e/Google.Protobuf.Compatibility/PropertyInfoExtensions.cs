using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Compatibility;

internal static class PropertyInfoExtensions
{
	[NonSerialized]
	internal static GetString getString_0;

	internal static MethodInfo GetGetMethod(this PropertyInfo target)
	{
		MethodInfo getMethod = target.GetMethod;
		if (getMethod != null && getMethod.IsPublic)
		{
			return getMethod;
		}
		return null;
	}

	internal static MethodInfo GetSetMethod(this PropertyInfo target)
	{
		MethodInfo setMethod = target.SetMethod;
		if (setMethod != null && setMethod.IsPublic)
		{
			return setMethod;
		}
		return null;
	}

	static PropertyInfoExtensions()
	{
		Strings.CreateGetStringDelegate(typeof(PropertyInfoExtensions));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107400748), getString_0(107400743)).Replace(getString_0(107400706), getString_0(107400701)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107400696)))
		{
			throw new SecurityException(getString_0(107400671));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
