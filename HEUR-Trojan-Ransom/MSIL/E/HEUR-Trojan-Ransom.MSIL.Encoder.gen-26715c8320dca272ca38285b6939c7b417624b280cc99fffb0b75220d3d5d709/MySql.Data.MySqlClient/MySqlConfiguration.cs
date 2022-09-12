using System.Configuration;

namespace MySql.Data.MySqlClient;

public sealed class MySqlConfiguration : ConfigurationSection
{
	private static MySqlConfiguration settings = ConfigurationManager.GetSection("MySQL") as MySqlConfiguration;

	public static MySqlConfiguration Settings => settings;

	[ConfigurationCollection(typeof(InterceptorConfigurationElement), AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
	[ConfigurationProperty("ExceptionInterceptors", IsRequired = false)]
	public GenericConfigurationElementCollection<InterceptorConfigurationElement> ExceptionInterceptors => (GenericConfigurationElementCollection<InterceptorConfigurationElement>)((ConfigurationElement)this).get_Item("ExceptionInterceptors");

	[ConfigurationProperty("CommandInterceptors", IsRequired = false)]
	[ConfigurationCollection(typeof(InterceptorConfigurationElement), AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
	public GenericConfigurationElementCollection<InterceptorConfigurationElement> CommandInterceptors => (GenericConfigurationElementCollection<InterceptorConfigurationElement>)((ConfigurationElement)this).get_Item("CommandInterceptors");

	[ConfigurationCollection(typeof(AuthenticationPluginConfigurationElement), AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
	[ConfigurationProperty("AuthenticationPlugins", IsRequired = false)]
	public GenericConfigurationElementCollection<AuthenticationPluginConfigurationElement> AuthenticationPlugins => (GenericConfigurationElementCollection<AuthenticationPluginConfigurationElement>)((ConfigurationElement)this).get_Item("AuthenticationPlugins");

	[ConfigurationProperty("Replication", IsRequired = true)]
	public ReplicationConfigurationElement Replication
	{
		get
		{
			return (ReplicationConfigurationElement)((ConfigurationElement)this).get_Item("Replication");
		}
		set
		{
			((ConfigurationElement)this).set_Item("Replication", (object)value);
		}
	}
}
