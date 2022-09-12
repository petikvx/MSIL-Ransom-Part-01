using System.Collections;
using System.Collections.Generic;

namespace Examine;

public interface ISearchResults : IEnumerable<SearchResult>, IEnumerable
{
	int TotalItemCount { get; }

	IEnumerable<SearchResult> Skip(int skip);
}
