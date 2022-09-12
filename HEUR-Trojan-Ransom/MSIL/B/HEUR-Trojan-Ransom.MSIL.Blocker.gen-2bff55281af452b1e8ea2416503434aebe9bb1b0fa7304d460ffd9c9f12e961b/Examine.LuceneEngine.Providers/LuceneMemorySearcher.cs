using System.Security;
using Lucene.Net.Analysis;
using Lucene.Net.Search;
using Lucene.Net.Store;

namespace Examine.LuceneEngine.Providers;

public class LuceneMemorySearcher : LuceneSearcher
{
	private readonly Directory _luceneDirectory;

	private IndexSearcher _searcher;

	public LuceneMemorySearcher()
	{
	}

	[SecuritySafeCritical]
	public LuceneMemorySearcher(Directory luceneDirectory, Analyzer analyzer)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		_luceneDirectory = (Directory)new RAMDirectory(luceneDirectory);
		base.IndexingAnalyzer = analyzer;
	}

	[SecuritySafeCritical]
	protected override Directory GetLuceneDirectory()
	{
		return _luceneDirectory;
	}

	[SecuritySafeCritical]
	public override Searcher GetSearcher()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (_searcher == null)
		{
			_searcher = new IndexSearcher(GetLuceneDirectory(), true);
		}
		_searcher.SetDefaultFieldSortScoring(true, true);
		return (Searcher)(object)_searcher;
	}
}
