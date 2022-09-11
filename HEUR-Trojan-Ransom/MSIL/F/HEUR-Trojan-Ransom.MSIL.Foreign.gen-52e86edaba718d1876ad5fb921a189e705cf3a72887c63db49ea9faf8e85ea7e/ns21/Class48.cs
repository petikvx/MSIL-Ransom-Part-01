using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns15;
using ns8;

namespace ns21;

internal abstract class Class48
{
	private List<Class78> list_0 = new List<Class78>();

	internal ulong ulong_0;

	internal ulong ulong_1;

	internal Class79 class79_0;

	internal bool bool_0;

	internal bool bool_1;

	internal List<string> list_1 = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	protected Class85 Protocol => class79_0?.vmethod_2();

	public ReadOnlyCollection<Class78> Warnings => list_0.AsReadOnly();

	internal Class48(Class79 class79_1)
	{
		if (class79_1 != null)
		{
			class79_0 = class79_1;
			if (class79_1.class48_0 != null)
			{
				class79_1.class48_0.vmethod_0();
				class79_1.class48_0 = null;
			}
			bool_0 = Protocol.vmethod_2(this);
			if (bool_0)
			{
				class79_1.class48_0 = this;
			}
		}
	}

	internal void method_0(Class78 class78_0)
	{
		list_0.Add(class78_0);
	}

	protected virtual void vmethod_0()
	{
	}

	static Class48()
	{
		Strings.CreateGetStringDelegate(typeof(Class48));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397682), getString_0(107397677)).Replace(getString_0(107397640), getString_0(107397635)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_2: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397630)))
		{
			throw new SecurityException(getString_0(107397605));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_2, [MarshalAs(UnmanagedType.Bool)] out bool bool_3);
}
