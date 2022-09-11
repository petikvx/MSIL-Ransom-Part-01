using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns7;

namespace ns6;

internal sealed class Class84 : Class83
{
	[NonSerialized]
	internal static GetString getString_0;

	public Class84(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_1)
		: base(mySqlConnectionStringBuilder_1)
	{
	}

	public override MySqlConnectionStringBuilder vmethod_1(Enum27 enum27_0)
	{
		return mySqlConnectionStringBuilder_0;
	}

	static Class84()
	{
		Strings.CreateGetStringDelegate(typeof(Class84));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397797), getString_0(107397792)).Replace(getString_0(107397755), getString_0(107397750)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397745)))
		{
			throw new SecurityException(getString_0(107397720));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
