using System;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns3;

namespace ns24;

internal sealed class Class116 : Class115
{
	private MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0;

	[NonSerialized]
	internal static GetString getString_2;

	public override string PluginName => getString_2(107365437);

	public string AuthName => getString_2(107365400);

	public Class116(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_1)
	{
		mySqlConnectionStringBuilder_0 = mySqlConnectionStringBuilder_1;
	}

	public byte[] method_8()
	{
		return Encoding.UTF8.GetBytes(string.Format(getString_2(107365423), mySqlConnectionStringBuilder_0.Database, mySqlConnectionStringBuilder_0.UserID, mySqlConnectionStringBuilder_0.Password));
	}

	static Class116()
	{
		Strings.CreateGetStringDelegate(typeof(Class116));
	}
}
