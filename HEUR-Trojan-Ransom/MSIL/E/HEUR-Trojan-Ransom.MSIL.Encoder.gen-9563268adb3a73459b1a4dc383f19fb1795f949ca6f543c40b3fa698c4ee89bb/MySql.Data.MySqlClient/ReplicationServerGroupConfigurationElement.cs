using System.Configuration;

namespace MySql.Data.MySqlClient;

public sealed class ReplicationServerGroupConfigurationElement : ConfigurationElement
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

	[ConfigurationProperty("groupType", IsRequired = false)]
	public string GroupType
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item("groupType");
		}
		set
		{
			((ConfigurationElement)this).set_Item("groupType", (object)value);
		}
	}

	[ConfigurationProperty("retryTime", IsRequired = false, DefaultValue = 60)]
	public int RetryTime
	{
		get
		{
			return (int)((ConfigurationElement)this).get_Item("retryTime");
		}
		set
		{
			((ConfigurationElement)this).set_Item("retryTime", (object)value);
		}
	}

	[ConfigurationProperty("Servers")]
	[ConfigurationCollection(typeof(ReplicationServerConfigurationElement), AddItemName = "Server")]
	public GenericConfigurationElementCollection<ReplicationServerConfigurationElement> Servers => (GenericConfigurationElementCollection<ReplicationServerConfigurationElement>)((ConfigurationElement)this).get_Item("Servers");
}
