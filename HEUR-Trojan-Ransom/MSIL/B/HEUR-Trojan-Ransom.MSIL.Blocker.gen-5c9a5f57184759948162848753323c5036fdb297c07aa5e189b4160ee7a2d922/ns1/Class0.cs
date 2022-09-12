using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Interop;
using ns4;
using ns7;
using ns8;

namespace ns1;

internal sealed class Class0 : Application
{
	internal delegate void Delegate0();

	internal static readonly int w;

	static Class0()
	{
		try
		{
			foreach (Type item in smethod_0())
			{
				Class5.smethod_0(item, out var delegate_);
				((Delegate0)delegate_)();
			}
		}
		catch
		{
		}
	}

	public static void Main()
	{
		new Class0().method_0();
	}

	internal static IEnumerable<Type> smethod_0()
	{
		return smethod_1().ExportedTypes;
	}

	internal int method_0()
	{
		return method_1(null);
	}

	internal int method_1(Window window_0)
	{
		if (!BrowserInteropHelper.get_IsBrowserHosted())
		{
			Class2.smethod_0(null);
		}
		return w;
	}

	[CompilerGenerated]
	internal static Assembly smethod_1()
	{
		return Class6.smethod_0();
	}
}
