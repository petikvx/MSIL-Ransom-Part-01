using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security;
using Examine.LuceneEngine.Config;
using Lucene.Net.Analysis;
using Lucene.Net.Search;
using Lucene.Net.Store;

namespace Examine.LuceneEngine.Providers;

public class MultiIndexSearcher : BaseLuceneSearcher, IDisposable
{
	private class DisposableSearcher : DisposableObject
	{
		private readonly MultiIndexSearcher _searcher;

		public DisposableSearcher(MultiIndexSearcher searcher)
		{
			_searcher = searcher;
		}

		[SecuritySafeCritical]
		protected override void DisposeResources()
		{
			foreach (LuceneSearcher searcher in _searcher.Searchers)
			{
				searcher.Dispose();
			}
		}
	}

	private readonly DisposableSearcher _disposer;

	public IEnumerable<LuceneSearcher> Searchers
	{
		[SecuritySafeCritical]
		get;
		[SecuritySafeCritical]
		private set;
	}

	public MultiIndexSearcher()
	{
		_disposer = new DisposableSearcher(this);
	}

	[SecuritySafeCritical]
	public MultiIndexSearcher(IEnumerable<DirectoryInfo> indexPath, Analyzer analyzer)
		: base(analyzer)
	{
		_disposer = new DisposableSearcher(this);
		List<LuceneSearcher> list = new List<LuceneSearcher>();
		foreach (DirectoryInfo item in indexPath)
		{
			list.Add(new LuceneSearcher(item, base.IndexingAnalyzer));
		}
		Searchers = list;
	}

	[SecuritySafeCritical]
	public MultiIndexSearcher(IEnumerable<Directory> luceneDirs, Analyzer analyzer)
		: base(analyzer)
	{
		_disposer = new DisposableSearcher(this);
		List<LuceneSearcher> list = new List<LuceneSearcher>();
		foreach (Directory luceneDir in luceneDirs)
		{
			list.Add(new LuceneSearcher(luceneDir, base.IndexingAnalyzer));
		}
		Searchers = list;
	}

	[SecuritySafeCritical]
	public override void Initialize(string name, NameValueCollection config)
	{
		base.Initialize(name, config);
		if (config["indexSets"] == null)
		{
			throw new ArgumentNullException("indexSets on MultiIndexSearcher provider has not been set in configuration");
		}
		List<IndexSet> list = new List<IndexSet>();
		IEnumerable<IndexSet> source = ((IEnumerable)(object)IndexSets.Instance.Sets).Cast<IndexSet>();
		string[] array = config["indexSets"]!.Split(new char[1] { (char)Convert.ToInt32(22.0 + Math.Abs(22.0)) });
		int num = 0;
		List<LuceneSearcher> list2;
		while (true)
		{
			if (num < array.Length)
			{
				string i = array[num];
				IndexSet indexSet = source.Where((IndexSet x) => x.SetName == i).SingleOrDefault();
				if (indexSet != null)
				{
					list.Add(indexSet);
					num++;
					continue;
				}
				throw new ArgumentException("The index set " + i + " does not exist");
			}
			Analyzer indexingAnalyzer = base.IndexingAnalyzer;
			list2 = new List<LuceneSearcher>();
			foreach (IndexSet item in list)
			{
				list2.Add(new LuceneSearcher(item.IndexDirectory, indexingAnalyzer));
			}
			break;
		}
		Searchers = list2;
	}

	protected internal override string[] GetSearchFields()
	{
		List<string> list = new List<string>();
		foreach (LuceneSearcher searcher in Searchers)
		{
			list.AddRange(searcher.GetSearchFields());
		}
		return list.Distinct().ToArray();
	}

	[SecuritySafeCritical]
	public override Searcher GetSearcher()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		List<Searchable> list = new List<Searchable>();
		foreach (LuceneSearcher searcher2 in Searchers)
		{
			Searcher searcher = searcher2.GetSearcher();
			if (searcher != null)
			{
				list.Add((Searchable)(object)searcher);
			}
		}
		return (Searcher)new MultiSearcher(list.ToArray());
	}

	public void Dispose()
	{
		_disposer.Dispose();
	}
}
