using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns12;
using ns13;
using ns21;
using ns23;
using ns5;
using ns7;

namespace ns8;

internal sealed class Class63 : Class59<Class63, Class39, Class53>
{
	internal List<string> list_0;

	internal string[] string_0;

	internal Class74 class74_0 = new Class74();

	[NonSerialized]
	internal static GetString getString_0;

	internal Class63(Class39 class39_0, string string_1)
		: base(class39_0, string_1)
	{
	}

	public Class63 method_9(params string[] string_1)
	{
		list_0 = new List<string>(string_1);
		return this;
	}

	public override Class53 vmethod_0()
	{
		return vmethod_1(base.Target.Session.XSession.method_28, this);
	}

	public Class63 method_10(long long_0, long long_1)
	{
		base.FilterData.long_0 = long_0;
		base.FilterData.long_1 = long_1;
		return this;
	}

	public Class63 method_11(Enum45 enum45_0 = Enum45.const_0)
	{
		if (!base.Session.InternalSession.method_5().method_0(8, 0, 3))
		{
			throw new MySqlException(string.Format(Class122.FunctionalityNotSupported, getString_0(107408448)));
		}
		class74_0.enum25_0 = Enum25.const_0;
		class74_0.enum45_0 = enum45_0;
		return this;
	}

	public Class63 method_12(Enum45 enum45_0 = Enum45.const_0)
	{
		if (!base.Session.InternalSession.method_5().method_0(8, 0, 3))
		{
			throw new MySqlException(string.Format(Class122.FunctionalityNotSupported, getString_0(107408448)));
		}
		class74_0.enum25_0 = Enum25.const_1;
		class74_0.enum45_0 = enum45_0;
		return this;
	}

	static Class63()
	{
		Strings.CreateGetStringDelegate(typeof(Class63));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397756), getString_0(107397751)).Replace(getString_0(107397714), getString_0(107397709)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397704)))
		{
			throw new SecurityException(getString_0(107397679));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
