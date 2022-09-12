using System.Configuration;

namespace Examine.Config;

public class SearchProvidersSection : ConfigurationElement
{
	[ConfigurationProperty("providers")]
	public ProviderSettingsCollection Providers => (ProviderSettingsCollection)((ConfigurationElement)this).get_Item("providers");

	[StringValidator(MinLength = 1)]
	[ConfigurationProperty("defaultProvider", DefaultValue = "InternalSearch")]
	public string DefaultProvider
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item("defaultProvider");
		}
		set
		{
			((ConfigurationElement)this).set_Item("defaultProvider", (object)value);
		}
	}
}
