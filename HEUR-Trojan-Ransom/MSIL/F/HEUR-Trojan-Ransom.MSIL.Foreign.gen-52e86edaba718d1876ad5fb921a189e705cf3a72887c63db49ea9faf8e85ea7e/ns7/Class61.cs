using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns12;
using ns18;
using ns19;
using ns21;
using ns5;

namespace ns7;

internal sealed class Class61 : Class59<Class61, Class42, Class51>
{
	internal Class74 class74_0 = new Class74();

	[NonSerialized]
	internal static GetString getString_0;

	internal Class61(Class42 class42_0, params string[] string_0)
		: base(class42_0, (string)null)
	{
		class74_0.string_4 = string_0;
		base.FilterData.bool_0 = true;
	}

	public Class61 method_9(params string[] string_0)
	{
		class74_0.string_2 = string_0;
		return this;
	}

	public Class61 method_10(string string_0)
	{
		class74_0.string_3 = string_0;
		return this;
	}

	public override Class51 vmethod_0()
	{
		return vmethod_1(base.Target.Session.XSession.method_29, this);
	}

	public Class61 method_11(long long_0, long long_1)
	{
		base.FilterData.long_0 = long_0;
		base.FilterData.long_1 = long_1;
		return this;
	}

	public Class61 method_12(Enum45 enum45_0 = Enum45.const_0)
	{
		if (!base.Session.InternalSession.method_5().method_0(8, 0, 3))
		{
			throw new MySqlException(string.Format(Class122.FunctionalityNotSupported, getString_0(107408397)));
		}
		class74_0.enum25_0 = Enum25.const_0;
		class74_0.enum45_0 = enum45_0;
		return this;
	}

	public Class61 method_13(Enum45 enum45_0 = Enum45.const_0)
	{
		if (!base.Session.InternalSession.method_5().method_0(8, 0, 3))
		{
			throw new MySqlException(string.Format(Class122.FunctionalityNotSupported, getString_0(107408397)));
		}
		class74_0.enum25_0 = Enum25.const_1;
		class74_0.enum45_0 = enum45_0;
		return this;
	}

	static Class61()
	{
		Strings.CreateGetStringDelegate(typeof(Class61));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397705), getString_0(107397700)).Replace(getString_0(107397663), getString_0(107397658)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397653)))
		{
			throw new SecurityException(getString_0(107397628));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
