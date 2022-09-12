using System.Configuration;

namespace MySql.Data.MySqlClient;

public sealed class AuthenticationPluginConfigurationElement : ConfigurationElement
{
	[ConfigurationProperty("name", IsRequired = true)]
	public string Name
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item("name");
		}
		set
		{
			((ConfigurationElement)this).set_Item("name", (object)value);
		}
	}

	[ConfigurationProperty("type", IsRequired = true)]
	public string Type
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item("type");
		}
		set
		{
			((ConfigurationElement)this).set_Item("type", (object)value);
		}
	}
}
