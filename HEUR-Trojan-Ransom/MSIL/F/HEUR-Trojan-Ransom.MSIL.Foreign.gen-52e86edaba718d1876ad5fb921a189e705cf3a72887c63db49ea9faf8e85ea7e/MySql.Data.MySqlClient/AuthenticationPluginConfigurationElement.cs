using System;
using System.Configuration;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MySql.Data.MySqlClient;

public sealed class AuthenticationPluginConfigurationElement : ConfigurationElement
{
	[NonSerialized]
	internal static GetString getString_0;

	[ConfigurationProperty("name", IsRequired = true)]
	public string Name
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item(getString_0(107408652));
		}
		set
		{
			((ConfigurationElement)this).set_Item(getString_0(107408652), (object)value);
		}
	}

	[ConfigurationProperty("type", IsRequired = true)]
	public string Type
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item(getString_0(107408464));
		}
		set
		{
			((ConfigurationElement)this).set_Item(getString_0(107408464), (object)value);
		}
	}

	static AuthenticationPluginConfigurationElement()
	{
		Strings.CreateGetStringDelegate(typeof(AuthenticationPluginConfigurationElement));
	}
}
