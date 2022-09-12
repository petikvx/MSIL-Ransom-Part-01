using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Examine.LuceneEngine;

internal class EmptySearchResults : IEnumerable<SearchResult>, ISearchResults, IEnumerable
{
	private List<ISearchResults> _emptyResult = new List<ISearchResults>();

	public int TotalItemCount => 0;

	public IEnumerator<SearchResult> GetEnumerator()
	{
		return Enumerable.Empty<SearchResult>().GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return Enumerable.Empty<SearchResult>().GetEnumerator();
	}

	public IEnumerable<SearchResult> Skip(int skip)
	{
		return Enumerable.Empty<SearchResult>();
	}
}
