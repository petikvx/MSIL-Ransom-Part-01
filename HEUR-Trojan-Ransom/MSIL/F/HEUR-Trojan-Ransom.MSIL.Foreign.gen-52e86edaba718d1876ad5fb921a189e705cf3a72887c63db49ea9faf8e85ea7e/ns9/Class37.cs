using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using MySqlX.XDevAPI;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns19;
using ns5;

namespace ns9;

internal sealed class Class37 : BaseSession
{
	[NonSerialized]
	internal static GetString getString_1;

	internal Class37(string string_1)
		: base(string_1)
	{
	}

	internal Class37(object object_0)
		: base(object_0)
	{
	}

	public Class57 method_21(string string_1)
	{
		return new Class57(this, string_1);
	}

	public void method_22(string string_1)
	{
		base.InternalSession.method_1(string.Format(getString_1(107407833), string_1));
		method_2(string_1);
	}

	public Class41 method_23()
	{
		string text = (string)base.InternalSession.method_4(getString_1(107407788));
		if (text != null)
		{
			return method_2(text);
		}
		return null;
	}

	static Class37()
	{
		Strings.CreateGetStringDelegate(typeof(Class37));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_1(107397651), getString_1(107397646)).Replace(getString_1(107397609), getString_1(107397604)));
		if (!StrongNameSignatureVerificationEx_1(uri.LocalPath, bool_2: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_1(107397599)))
		{
			throw new SecurityException(getString_1(107397574));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx_1([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_2, [MarshalAs(UnmanagedType.Bool)] out bool bool_3);
}
