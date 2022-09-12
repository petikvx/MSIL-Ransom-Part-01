using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;

namespace Examine.Providers;

public class IndexProviderCollection : ProviderCollection, IEnumerable<BaseIndexProvider>, IEnumerable
{
	private List<BaseIndexProvider> m_List;

	public BaseIndexProvider this[string name] => (BaseIndexProvider)(object)((ProviderCollection)this).get_Item(name);

	public BaseIndexProvider this[int index] => this.Cast<BaseIndexProvider>().ToArray()[index];

	public override void Add(ProviderBase provider)
	{
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		if (!(provider is BaseIndexProvider))
		{
			throw new ArgumentException("Invalid provider type", "provider");
		}
		((ProviderCollection)this).Add(provider);
	}

	IEnumerator<BaseIndexProvider> IEnumerable<BaseIndexProvider>.GetEnumerator()
	{
		if (m_List == null)
		{
			m_List = new List<BaseIndexProvider>();
			foreach (object item in (ProviderCollection)this)
			{
				m_List.Add((BaseIndexProvider)item);
			}
		}
		return m_List.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((ProviderCollection)this).GetEnumerator();
	}
}
