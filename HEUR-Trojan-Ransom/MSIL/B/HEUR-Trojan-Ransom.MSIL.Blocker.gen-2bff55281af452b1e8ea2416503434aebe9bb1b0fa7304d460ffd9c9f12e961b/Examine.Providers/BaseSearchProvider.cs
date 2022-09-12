using System.Configuration.Provider;
using System.Security;
using Examine.SearchCriteria;

namespace Examine.Providers;

public abstract class BaseSearchProvider : ProviderBase, ISearcher
{
	public virtual ISearchResults Search(ISearchCriteria searchParams, int maxResults)
	{
		return Search(searchParams);
	}

	public virtual ISearchResults Search(string searchText, bool useWildcards, string indexType)
	{
		return Search(searchText, useWildcards);
	}

	public abstract ISearchResults Search(string searchText, bool useWildcards);

	public abstract ISearchResults Search(ISearchCriteria searchParams);

	public abstract ISearchCriteria CreateSearchCriteria();

	public abstract ISearchCriteria CreateSearchCriteria(string type);

	[SecuritySafeCritical]
	public abstract ISearchCriteria CreateSearchCriteria(BooleanOperation defaultOperation);

	[SecuritySafeCritical]
	public abstract ISearchCriteria CreateSearchCriteria(string type, BooleanOperation defaultOperation);
}
