using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using Lucene.Net.Documents;
using Lucene.Net.Search;

namespace Examine.LuceneEngine;

public class SearchResults : IEnumerable<SearchResult>, ISearchResults, IEnumerable
{
	private struct DecrementReaderResult : IEnumerator<SearchResult>, IDisposable, IEnumerator
	{
		private readonly IEnumerator<SearchResult> _baseEnumerator;

		private readonly IndexSearcher _searcher;

		public SearchResult Current => _baseEnumerator.Current;

		object IEnumerator.Current => Current;

		[SecuritySafeCritical]
		public DecrementReaderResult(IEnumerator<SearchResult> baseEnumerator, Searcher searcher)
		{
			_baseEnumerator = baseEnumerator;
			_searcher = (IndexSearcher)(object)((searcher is IndexSearcher) ? searcher : null);
			if (_searcher != null)
			{
				_searcher.GetIndexReader().IncRef();
			}
		}

		[SecuritySafeCritical]
		public void Dispose()
		{
			_baseEnumerator.Dispose();
			if (_searcher != null)
			{
				_searcher.GetIndexReader().DecRef();
			}
		}

		public bool MoveNext()
		{
			return _baseEnumerator.MoveNext();
		}

		public void Reset()
		{
			_baseEnumerator.Reset();
		}
	}

	[SecuritySafeCritical]
	private TopDocs _topDocs;

	protected Dictionary<int, SearchResult> Docs = new Dictionary<int, SearchResult>();

	public Searcher LuceneSearcher
	{
		[SecuritySafeCritical]
		get;
		[SecuritySafeCritical]
		private set;
	}

	public Query LuceneQuery
	{
		[SecuritySafeCritical]
		get;
		[SecuritySafeCritical]
		private set;
	}

	public int TotalItemCount { get; private set; }

	public static ISearchResults Empty()
	{
		return new EmptySearchResults();
	}

	[SecuritySafeCritical]
	internal SearchResults(Query query, IEnumerable<SortField> sortField, Searcher searcher)
	{
		LuceneQuery = query;
		LuceneSearcher = searcher;
		DoSearch(query, sortField, 0);
	}

	[SecuritySafeCritical]
	internal SearchResults(Query query, IEnumerable<SortField> sortField, Searcher searcher, int maxResults)
	{
		LuceneQuery = query;
		LuceneSearcher = searcher;
		DoSearch(query, sortField, maxResults);
	}

	[SecuritySafeCritical]
	private void DoSearch(Query query, IEnumerable<SortField> sortField, int maxResults)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Hashtable hashtable = new Hashtable();
			query.ExtractTerms(hashtable);
		}
		catch (NullReferenceException)
		{
			TotalItemCount = 0;
			return;
		}
		catch (NotSupportedException)
		{
		}
		maxResults = ((maxResults >= 1) ? maxResults : LuceneSearcher.MaxDoc());
		Collector val = (Collector)((!sortField.Any()) ? ((object)TopScoreDocCollector.create(maxResults, true)) : ((object)TopFieldCollector.create(new Sort(sortField.ToArray()), maxResults, false, false, false, false)));
		LuceneSearcher.Search(query, val);
		_topDocs = (sortField.Any() ? ((TopDocsCollector)(TopFieldCollector)val).TopDocs() : ((TopDocsCollector)(TopScoreDocCollector)val).TopDocs());
		TotalItemCount = _topDocs.get_TotalHits();
	}

	[SecuritySafeCritical]
	protected SearchResult CreateSearchResult(Document doc, float score)
	{
		string text = doc.Get("id");
		if (string.IsNullOrEmpty(text))
		{
			text = doc.Get("__NodeId");
		}
		SearchResult searchResult = new SearchResult
		{
			Id = int.Parse(text),
			Score = score
		};
		foreach (Field item in doc.GetFields().Cast<Field>())
		{
			string text2 = ((AbstractField)item).Name();
			string[] values = doc.GetValues(text2);
			if (values.Length > 1)
			{
				searchResult.MultiValueFields[text2] = values.ToList();
				searchResult.Fields[text2] = values[0];
			}
			else if (values.Length != 0)
			{
				searchResult.Fields[text2] = values[0];
			}
		}
		return searchResult;
	}

	[SecuritySafeCritical]
	private SearchResult CreateFromDocumentItem(int i)
	{
		int doc = _topDocs.get_ScoreDocs()[i].doc;
		Document doc2 = LuceneSearcher.Doc(doc);
		float score = _topDocs.get_ScoreDocs()[i].score;
		return CreateSearchResult(doc2, score);
	}

	[SecuritySafeCritical]
	private int GetScoreDocsLength()
	{
		if (_topDocs != null && _topDocs.get_ScoreDocs() != null)
		{
			return _topDocs.get_ScoreDocs().Length;
		}
		return 0;
	}

	[SecuritySafeCritical]
	[IteratorStateMachine(typeof(_003CSkip_003Ed__21))]
	public IEnumerable<SearchResult> Skip(int skip)
	{
		return new _003CSkip_003Ed__21(Convert.ToInt32(-2.0))
		{
			_003C_003E4__this = this,
			_003C_003E3__skip = skip
		};
	}

	[SecuritySafeCritical]
	public IEnumerator<SearchResult> GetEnumerator()
	{
		return new DecrementReaderResult(Skip(0).GetEnumerator(), LuceneSearcher);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
