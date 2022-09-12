using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Web.Configuration;
using System.Web.Hosting;
using System.Xml.Linq;
using Examine.Config;
using Examine.LuceneEngine;
using Examine.LuceneEngine.Providers;
using Examine.Providers;
using Examine.SearchCriteria;

namespace Examine;

public class ExamineManager : IIndexer, IRegisteredObject, ISearcher
{
	private static readonly ExamineManager Manager = new ExamineManager();

	private readonly object _lock = new object();

	private volatile bool _providersInit;

	private BaseSearchProvider _defaultSearchProvider;

	private SearchProviderCollection _searchProviderCollection;

	private IndexProviderCollection _indexProviderCollection;

	public static ExamineManager Instance => Manager;

	public BaseSearchProvider DefaultSearchProvider
	{
		get
		{
			EnsureProviders();
			return _defaultSearchProvider;
		}
	}

	public SearchProviderCollection SearchProviderCollection
	{
		get
		{
			EnsureProviders();
			return _searchProviderCollection;
		}
	}

	public IndexProviderCollection IndexProviderCollection
	{
		get
		{
			EnsureProviders();
			return _indexProviderCollection;
		}
	}

	public IIndexCriteria IndexerData
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public event EventHandler<BuildingEmptyIndexOnStartupEventArgs> BuildingEmptyIndexOnStartup;

	private ExamineManager()
	{
		HostingEnvironment.RegisterObject((IRegisteredObject)(object)this);
	}

	private void EnsureProviders()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		if (_providersInit)
		{
			return;
		}
		lock (_lock)
		{
			if (_providersInit)
			{
				return;
			}
			_indexProviderCollection = new IndexProviderCollection();
			ProvidersHelper.InstantiateProviders(ExamineSettings.Instance.IndexProviders.Providers, (ProviderCollection)(object)_indexProviderCollection, typeof(BaseIndexProvider));
			_searchProviderCollection = new SearchProviderCollection();
			ProvidersHelper.InstantiateProviders(ExamineSettings.Instance.SearchProviders.Providers, (ProviderCollection)(object)_searchProviderCollection, typeof(BaseSearchProvider));
			if (!string.IsNullOrEmpty(ExamineSettings.Instance.SearchProviders.DefaultProvider))
			{
				_defaultSearchProvider = _searchProviderCollection[ExamineSettings.Instance.SearchProviders.DefaultProvider];
			}
			if (_defaultSearchProvider == null)
			{
				throw new ProviderException("Unable to load default search provider");
			}
			_providersInit = true;
			if (!ExamineSettings.Instance.RebuildOnAppStart)
			{
				return;
			}
			foreach (IIndexer item in (ProviderCollection)_indexProviderCollection)
			{
				bool flag = false;
				bool isHealthy = true;
				Exception e = null;
				if (!item.IndexExists())
				{
					flag = true;
				}
				if (!flag && !(isHealthy = IsIndexHealthy(item, out e)))
				{
					flag = true;
				}
				if (flag)
				{
					BuildingEmptyIndexOnStartupEventArgs buildingEmptyIndexOnStartupEventArgs = new BuildingEmptyIndexOnStartupEventArgs(item, isHealthy, e);
					OnBuildingEmptyIndexOnStartup(buildingEmptyIndexOnStartupEventArgs);
					if (!buildingEmptyIndexOnStartupEventArgs.Cancel)
					{
						item.RebuildIndex();
					}
				}
			}
		}
	}

	private bool IsIndexHealthy(IIndexer index, out Exception e)
	{
		if (!(index is LuceneIndexer luceneIndexer))
		{
			e = null;
			return true;
		}
		Exception ex;
		bool result = luceneIndexer.IsReadable(out ex);
		e = ex;
		return result;
	}

	public ISearchResults Search(ISearchCriteria searchParameters)
	{
		return DefaultSearchProvider.Search(searchParameters);
	}

	public ISearchResults Search(string searchText, bool useWildcards)
	{
		return DefaultSearchProvider.Search(searchText, useWildcards);
	}

	public void ReIndexNode(XElement node, string type, IEnumerable<BaseIndexProvider> providers)
	{
		_ReIndexNode(node, type, providers);
	}

	public void DeleteFromIndex(string nodeId, IEnumerable<BaseIndexProvider> providers)
	{
		_DeleteFromIndex(nodeId, providers);
	}

	public void ReIndexNode(XElement node, string type)
	{
		_ReIndexNode(node, type, IndexProviderCollection);
	}

	private void _ReIndexNode(XElement node, string type, IEnumerable<BaseIndexProvider> providers)
	{
		foreach (BaseIndexProvider provider in providers)
		{
			provider.ReIndexNode(node, type);
		}
	}

	public void DeleteFromIndex(string nodeId)
	{
		_DeleteFromIndex(nodeId, IndexProviderCollection);
	}

	private void _DeleteFromIndex(string nodeId, IEnumerable<BaseIndexProvider> providers)
	{
		foreach (BaseIndexProvider provider in providers)
		{
			provider.DeleteFromIndex(nodeId);
		}
	}

	public void IndexAll(string type)
	{
		_IndexAll(type);
	}

	private void _IndexAll(string type)
	{
		foreach (BaseIndexProvider item in (ProviderCollection)IndexProviderCollection)
		{
			item.IndexAll(type);
		}
	}

	public void RebuildIndex()
	{
		_RebuildIndex();
	}

	private void _RebuildIndex()
	{
		foreach (BaseIndexProvider item in (ProviderCollection)IndexProviderCollection)
		{
			item.RebuildIndex();
		}
	}

	public bool IndexExists()
	{
		throw new NotImplementedException();
	}

	public ISearchCriteria CreateSearchCriteria()
	{
		return CreateSearchCriteria(string.Empty, BooleanOperation.And);
	}

	public ISearchCriteria CreateSearchCriteria(string type)
	{
		return CreateSearchCriteria(type, BooleanOperation.And);
	}

	public ISearchCriteria CreateSearchCriteria(BooleanOperation defaultOperation)
	{
		return CreateSearchCriteria(string.Empty, defaultOperation);
	}

	public ISearchCriteria CreateSearchCriteria(string type, BooleanOperation defaultOperation)
	{
		return DefaultSearchProvider.CreateSearchCriteria(type, defaultOperation);
	}

	protected virtual void OnBuildingEmptyIndexOnStartup(BuildingEmptyIndexOnStartupEventArgs e)
	{
		this.BuildingEmptyIndexOnStartup?.Invoke(this, e);
	}

	public void Stop(bool immediate)
	{
		if (immediate)
		{
			foreach (IDisposable item in ((IEnumerable)SearchProviderCollection).OfType<IDisposable>())
			{
				item.Dispose();
			}
			OpenReaderTracker.Current.CloseAllReaders();
			HostingEnvironment.UnregisterObject((IRegisteredObject)(object)this);
			return;
		}
		foreach (IDisposable item2 in IndexProviderCollection.OfType<IDisposable>())
		{
			item2.Dispose();
		}
	}
}
