using System.Configuration;

namespace System.Runtime.Caching.Configuration;

public sealed class MemoryCacheSection : ConfigurationSection
{
	private static ConfigurationPropertyCollection _properties;

	private static readonly ConfigurationProperty _propNamedCaches;

	protected override ConfigurationPropertyCollection Properties => _properties;

	[ConfigurationProperty("namedCaches")]
	public MemoryCacheSettingsCollection NamedCaches => (MemoryCacheSettingsCollection)((ConfigurationElement)this).get_Item(_propNamedCaches);

	static MemoryCacheSection()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		_propNamedCaches = new ConfigurationProperty("namedCaches", typeof(MemoryCacheSettingsCollection), (object)null, (ConfigurationPropertyOptions)0);
		_properties = new ConfigurationPropertyCollection();
		_properties.Add(_propNamedCaches);
	}
}
