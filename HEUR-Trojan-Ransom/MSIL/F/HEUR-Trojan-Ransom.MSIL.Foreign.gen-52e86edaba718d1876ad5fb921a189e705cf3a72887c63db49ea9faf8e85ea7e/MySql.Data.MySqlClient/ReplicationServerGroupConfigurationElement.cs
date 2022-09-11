using System;
using System.Configuration;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MySql.Data.MySqlClient;

public sealed class ReplicationServerGroupConfigurationElement : ConfigurationElement
{
	[NonSerialized]
	internal static GetString getString_0;

	[ConfigurationProperty("name", IsRequired = true)]
	public string Name
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item(getString_0(107409656));
		}
		set
		{
			((ConfigurationElement)this).set_Item(getString_0(107409656), (object)value);
		}
	}

	[ConfigurationProperty("groupType", IsRequired = false)]
	public string GroupType
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item(getString_0(107376154));
		}
		set
		{
			((ConfigurationElement)this).set_Item(getString_0(107376154), (object)value);
		}
	}

	[ConfigurationProperty("retryTime", IsRequired = false, DefaultValue = 60)]
	public int RetryTime
	{
		get
		{
			return (int)((ConfigurationElement)this).get_Item(getString_0(107376141));
		}
		set
		{
			((ConfigurationElement)this).set_Item(getString_0(107376141), (object)value);
		}
	}

	[ConfigurationProperty("Servers")]
	[ConfigurationCollection(typeof(ReplicationServerConfigurationElement), AddItemName = "Server")]
	public GenericConfigurationElementCollection<ReplicationServerConfigurationElement> Servers => (GenericConfigurationElementCollection<ReplicationServerConfigurationElement>)((ConfigurationElement)this).get_Item(getString_0(107376160));

	static ReplicationServerGroupConfigurationElement()
	{
		Strings.CreateGetStringDelegate(typeof(ReplicationServerGroupConfigurationElement));
	}
}
