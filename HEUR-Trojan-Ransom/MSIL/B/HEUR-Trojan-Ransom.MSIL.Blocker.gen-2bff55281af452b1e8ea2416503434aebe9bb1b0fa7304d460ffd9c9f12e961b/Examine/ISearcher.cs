using Examine.SearchCriteria;

namespace Examine;

public interface ISearcher
{
	ISearchResults Search(string searchText, bool useWildcards);

	ISearchResults Search(ISearchCriteria searchParameters);

	ISearchCriteria CreateSearchCriteria();

	ISearchCriteria CreateSearchCriteria(BooleanOperation defaultOperation);

	ISearchCriteria CreateSearchCriteria(string type);

	ISearchCriteria CreateSearchCriteria(string type, BooleanOperation defaultOperation);
}
