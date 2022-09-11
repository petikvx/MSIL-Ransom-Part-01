using System.Configuration;

namespace System.Runtime.Caching.Configuration;

public sealed class CachingSectionGroup : ConfigurationSectionGroup
{
	[ConfigurationProperty("memoryCache")]
	public MemoryCacheSection MemoryCaches => (MemoryCacheSection)(object)((ConfigurationSectionGroup)this).get_Sections().get_Item("memoryCache");
}
