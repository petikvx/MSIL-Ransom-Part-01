using System;
using System.Collections;
using System.Configuration.Provider;
using System.Linq;

namespace Examine.Providers;

public class SearchProviderCollection : ProviderCollection
{
	public BaseSearchProvider this[string name] => (BaseSearchProvider)(object)((ProviderCollection)this).get_Item(name);

	public BaseSearchProvider this[int index] => ((IEnumerable)this).Cast<BaseSearchProvider>().ToArray()[index];

	public override void Add(ProviderBase provider)
	{
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		if (!(provider is BaseSearchProvider))
		{
			throw new ArgumentException("Invalid provider type", "provider");
		}
		((ProviderCollection)this).Add(provider);
	}
}
