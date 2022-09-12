using System.Configuration;

namespace Examine.Config;

public class IndexProvidersSection : ConfigurationElement
{
	[ConfigurationProperty("providers")]
	public ProviderSettingsCollection Providers => (ProviderSettingsCollection)((ConfigurationElement)this).get_Item("providers");
}
