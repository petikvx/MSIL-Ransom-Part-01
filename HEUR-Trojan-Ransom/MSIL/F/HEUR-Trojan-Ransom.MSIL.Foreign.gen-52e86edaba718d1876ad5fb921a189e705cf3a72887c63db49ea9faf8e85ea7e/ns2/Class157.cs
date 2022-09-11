using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;

namespace ns2;

internal abstract class Class157
{
	protected Class139 class139_0;

	[NonSerialized]
	internal static GetString getString_0;

	protected void method_0(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		string[] array = string_0.Split(new char[1] { '|' });
		foreach (string text in array)
		{
			if (!string.IsNullOrEmpty(text))
			{
				object object_ = Activator.CreateInstance(Type.GetType(vmethod_1(text)));
				vmethod_0(object_);
			}
		}
	}

	protected abstract void vmethod_0(object object_0);

	protected virtual string vmethod_1(string string_0)
	{
		return string_0;
	}

	static Class157()
	{
		Strings.CreateGetStringDelegate(typeof(Class157));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398442), getString_0(107398437)).Replace(getString_0(107398400), getString_0(107398395)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398390)))
		{
			throw new SecurityException(getString_0(107398365));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
