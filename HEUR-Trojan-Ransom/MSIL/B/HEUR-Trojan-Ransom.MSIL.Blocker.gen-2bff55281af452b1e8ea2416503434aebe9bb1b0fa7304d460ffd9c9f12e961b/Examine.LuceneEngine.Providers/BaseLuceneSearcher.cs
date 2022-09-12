using System;
using System.Collections.Specialized;
using System.Configuration.Provider;
using System.Linq;
using System.Security;
using Examine.LuceneEngine.SearchCriteria;
using Examine.Providers;
using Examine.SearchCriteria;
using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Search;
using Lucene.Net.Util;

namespace Examine.LuceneEngine.Providers;

public abstract class BaseLuceneSearcher : BaseSearchProvider
{
	public bool EnableLeadingWildcards { get; set; }

	public Analyzer IndexingAnalyzer
	{
		[SecuritySafeCritical]
		get;
		[SecuritySafeCritical]
		protected internal set;
	}

	protected BaseLuceneSearcher()
	{
	}

	[SecuritySafeCritical]
	protected BaseLuceneSearcher(Analyzer analyzer)
	{
		IndexingAnalyzer = analyzer;
	}

	[SecuritySafeCritical]
	public override void Initialize(string name, NameValueCollection config)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		((ProviderBase)this).Initialize(name, config);
		if (config["analyzer"] != null)
		{
			Type type = Type.GetType(config["analyzer"]);
			IndexingAnalyzer = (Analyzer)Activator.CreateInstance(type);
		}
		else
		{
			IndexingAnalyzer = (Analyzer)new StandardAnalyzer(Version.LUCENE_29);
		}
		if (config["enableLeadingWildcard"] != null)
		{
			EnableLeadingWildcards = bool.Parse(config["enableLeadingWildcard"]);
		}
	}

	protected internal abstract string[] GetSearchFields();

	[SecuritySafeCritical]
	public abstract Searcher GetSearcher();

	[SecuritySafeCritical]
	public override ISearchCriteria CreateSearchCriteria(string type, BooleanOperation defaultOperation)
	{
		return new LuceneSearchCriteria(type, IndexingAnalyzer, GetSearchFields(), EnableLeadingWildcards, defaultOperation);
	}

	public override ISearchResults Search(string searchText, bool useWildcards)
	{
		ISearchCriteria sc = CreateSearchCriteria();
		return TextSearchAllFields(searchText, useWildcards, sc);
	}

	internal ISearchResults TextSearchAllFields(string searchText, bool useWildcards, ISearchCriteria sc)
	{
		string[] array = searchText.Split(new char[1] { (char)Convert.ToInt32(48.0 - Math.Truncate(16.0)) }, StringSplitOptions.RemoveEmptyEntries);
		sc = ((!useWildcards) ? sc.GroupedOr(GetSearchFields(), array).Compile() : sc.GroupedOr(GetSearchFields(), array.Select((string x) => new ExamineValue(Examineness.ComplexWildcard, x.MultipleCharacterWildcard().Value)).Cast<IExamineValue>().ToArray()).Compile());
		return Search(sc);
	}

	[SecuritySafeCritical]
	public override ISearchResults Search(ISearchCriteria searchParams)
	{
		return Search(searchParams, 0);
	}

	[SecuritySafeCritical]
	public override ISearchResults Search(ISearchCriteria searchParams, int maxResults)
	{
		Enforcer.ArgumentNotNull(searchParams, "searchParams");
		if (!(searchParams is LuceneSearchCriteria luceneSearchCriteria))
		{
			throw new ArgumentException("Provided ISearchCriteria dos not match the allowed ISearchCriteria. Ensure you only use an ISearchCriteria created from the current SearcherProvider");
		}
		Searcher searcher = GetSearcher();
		if (searcher == null)
		{
			return new EmptySearchResults();
		}
		return new SearchResults((Query)(object)luceneSearchCriteria.Query, luceneSearchCriteria.SortFields, searcher, maxResults);
	}

	public override ISearchResults Search(string searchText, bool useWildcards, string indexType)
	{
		ISearchCriteria sc = CreateSearchCriteria(indexType);
		return TextSearchAllFields(searchText, useWildcards, sc);
	}

	[SecuritySafeCritical]
	public override ISearchCriteria CreateSearchCriteria()
	{
		return CreateSearchCriteria(string.Empty, BooleanOperation.And);
	}

	public override ISearchCriteria CreateSearchCriteria(string type)
	{
		return CreateSearchCriteria(type, BooleanOperation.And);
	}

	[SecuritySafeCritical]
	public override ISearchCriteria CreateSearchCriteria(BooleanOperation defaultOperation)
	{
		return CreateSearchCriteria(string.Empty, defaultOperation);
	}
}
