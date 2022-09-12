using System.Configuration;

namespace MySql.Data.MySqlClient;

public sealed class ReplicationConfigurationElement : ConfigurationElement
{
	[ConfigurationProperty("ServerGroups", IsRequired = true)]
	[ConfigurationCollection(typeof(ReplicationServerGroupConfigurationElement), AddItemName = "Group")]
	public GenericConfigurationElementCollection<ReplicationServerGroupConfigurationElement> ServerGroups => (GenericConfigurationElementCollection<ReplicationServerGroupConfigurationElement>)((ConfigurationElement)this).get_Item("ServerGroups");
}
