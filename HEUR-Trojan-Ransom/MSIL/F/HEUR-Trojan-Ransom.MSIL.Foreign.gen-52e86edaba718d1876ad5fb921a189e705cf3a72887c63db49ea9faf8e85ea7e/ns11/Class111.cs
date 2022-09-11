using System;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns11;

internal sealed class Class111
{
	private MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0;

	[NonSerialized]
	internal static GetString getString_0;

	public string PluginName => getString_0(107365546);

	public string AuthName => getString_0(107407234);

	public Class111(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_1)
	{
		mySqlConnectionStringBuilder_0 = mySqlConnectionStringBuilder_1;
	}

	static Class111()
	{
		Strings.CreateGetStringDelegate(typeof(Class111));
	}
}
