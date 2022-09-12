using System;
using System.Diagnostics;
using System.Security;
using Examine.SearchCriteria;
using Lucene.Net.Search;

namespace Examine.LuceneEngine.SearchCriteria;

[DebuggerDisplay("{_search}")]
public class LuceneBooleanOperation : IBooleanOperation
{
	private readonly LuceneSearchCriteria _search;

	private bool _hasCompiled;

	internal LuceneBooleanOperation(LuceneSearchCriteria search)
	{
		_search = search;
	}

	[SecuritySafeCritical]
	public IQuery And()
	{
		return new LuceneQuery(_search, Occur.MUST);
	}

	[SecuritySafeCritical]
	public IQuery Or()
	{
		return new LuceneQuery(_search, Occur.SHOULD);
	}

	[SecuritySafeCritical]
	public IQuery Not()
	{
		return new LuceneQuery(_search, Occur.MUST_NOT);
	}

	[SecuritySafeCritical]
	public ISearchCriteria Compile()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		if (_hasCompiled)
		{
		}
		if (!string.IsNullOrEmpty(_search.SearchIndexType))
		{
			BooleanQuery query = _search.Query;
			_search.Query = new BooleanQuery();
			_search.Query.Add((Query)(object)query, Occur.MUST);
			_search.FieldInternal("__IndexType", new ExamineValue((Examineness)Convert.ToInt32(3.0), _search.SearchIndexType), Occur.MUST, useQueryParser: false);
			_hasCompiled = true;
		}
		return _search;
	}
}
