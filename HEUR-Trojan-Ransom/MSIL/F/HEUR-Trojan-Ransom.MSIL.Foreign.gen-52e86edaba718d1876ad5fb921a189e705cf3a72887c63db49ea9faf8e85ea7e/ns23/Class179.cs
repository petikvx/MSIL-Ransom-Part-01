using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns12;

namespace ns23;

internal sealed class Class179
{
	private static readonly BaseTableCache baseTableCache_0;

	[NonSerialized]
	internal static GetString getString_0;

	static Class179()
	{
		Strings.CreateGetStringDelegate(typeof(Class179));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399435), getString_0(107399430)).Replace(getString_0(107399393), getString_0(107399388)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399383)))
		{
			throw new SecurityException(getString_0(107399358));
		}
		baseTableCache_0 = new BaseTableCache(480);
	}

	public static void smethod_0(string string_0, Class175 class175_0)
	{
		baseTableCache_0.vmethod_0(string_0, class175_0);
	}

	public static Class175 smethod_1(string string_0, int int_0)
	{
		return (Class175)baseTableCache_0.vmethod_1(string_0, int_0);
	}

	public static void smethod_2(string string_0)
	{
		baseTableCache_0.method_0(string_0);
	}

	public static void smethod_3()
	{
		baseTableCache_0.vmethod_2();
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
