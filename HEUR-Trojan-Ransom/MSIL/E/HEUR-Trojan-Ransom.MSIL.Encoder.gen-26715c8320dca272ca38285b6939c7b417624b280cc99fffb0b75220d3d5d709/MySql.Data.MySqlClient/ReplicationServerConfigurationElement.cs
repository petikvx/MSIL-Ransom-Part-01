using System.Configuration;

namespace MySql.Data.MySqlClient;

public sealed class ReplicationServerConfigurationElement : ConfigurationElement
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

	[ConfigurationProperty("IsMaster", IsRequired = false, DefaultValue = false)]
	public bool IsMaster
	{
		get
		{
			return (bool)((ConfigurationElement)this).get_Item("IsMaster");
		}
		set
		{
			((ConfigurationElement)this).set_Item("IsMaster", (object)value);
		}
	}

	[ConfigurationProperty("connectionstring", IsRequired = true)]
	public string ConnectionString
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item("connectionstring");
		}
		set
		{
			((ConfigurationElement)this).set_Item("connectionstring", (object)value);
		}
	}
}
