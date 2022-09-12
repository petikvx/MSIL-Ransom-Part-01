namespace Examine.SearchCriteria;

public interface ISearchCriteria : IQuery
{
	string SearchIndexType { get; }

	ISearchCriteria RawQuery(string query);
}
