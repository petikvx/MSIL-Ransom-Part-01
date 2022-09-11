using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns20;
using ns21;
using ns22;

namespace ns9;

internal sealed class Class191
{
	private static readonly Dictionary<string, Struct25> dictionary_0;

	[NonSerialized]
	internal static GetString getString_0;

	private static void smethod_0()
	{
		dictionary_0[getString_0(107376075)] = new Struct25(getString_0(107371038));
		if (MySqlConfiguration.Settings == null || MySqlConfiguration.Settings.AuthenticationPlugins == null)
		{
			return;
		}
		using IEnumerator<AuthenticationPluginConfigurationElement> enumerator = MySqlConfiguration.Settings.AuthenticationPlugins.System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator();
		while (enumerator.MoveNext())
		{
			AuthenticationPluginConfigurationElement current = enumerator.Current;
			dictionary_0[current.Name] = new Struct25(current.Type);
		}
	}

	static Class191()
	{
		Strings.CreateGetStringDelegate(typeof(Class191));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399586), getString_0(107399581)).Replace(getString_0(107399544), getString_0(107399539)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399534)))
		{
			throw new SecurityException(getString_0(107399509));
		}
		dictionary_0 = new Dictionary<string, Struct25>();
		dictionary_0[getString_0(107409632)] = new Struct25(getString_0(107370429));
		dictionary_0[getString_0(107370344)] = new Struct25(getString_0(107370291));
		dictionary_0[getString_0(107376075)] = new Struct25(getString_0(107371038));
		dictionary_0[getString_0(107370714)] = new Struct25(getString_0(107370717));
		smethod_0();
	}

	public static Class112 smethod_1(string string_0)
	{
		if (!dictionary_0.ContainsKey(string_0))
		{
			throw new MySqlException(string.Format(Class121.AuthenticationMethodNotSupported, string_0));
		}
		return smethod_2(string_0);
	}

	private static Class112 smethod_2(string string_0)
	{
		Struct25 @struct = dictionary_0[string_0];
		try
		{
			return (Class112)Activator.CreateInstance(Type.GetType(@struct.string_0));
		}
		catch (Exception ex)
		{
			throw new MySqlException(string.Format(Class121.UnableToCreateAuthPlugin, string_0), ex);
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
