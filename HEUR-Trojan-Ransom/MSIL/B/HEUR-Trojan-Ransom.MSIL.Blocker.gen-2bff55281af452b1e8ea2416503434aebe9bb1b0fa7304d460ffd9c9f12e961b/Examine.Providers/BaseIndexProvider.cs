using System;
using System.Collections.Specialized;
using System.Configuration.Provider;
using System.Linq;
using System.Security;
using System.Xml.Linq;

namespace Examine.Providers;

public abstract class BaseIndexProvider : ProviderBase, IIndexer
{
	private CombinedIndexerDataFields _combinedIndexerDataFields;

	private IIndexCriteria _indexerData;

	public IIndexCriteria IndexerData
	{
		get
		{
			return _indexerData;
		}
		set
		{
			_indexerData = value;
			_combinedIndexerDataFields = null;
		}
	}

	internal CombinedIndexerDataFields CombinedIndexerDataFields => _combinedIndexerDataFields ?? (_combinedIndexerDataFields = new CombinedIndexerDataFields(IndexerData.UserFields.Concat(IndexerData.StandardFields.ToList())));

	public event EventHandler<IndexingErrorEventArgs> IndexingError;

	public event EventHandler<IndexingNodeEventArgs> NodeIndexing;

	public event EventHandler<IndexedNodeEventArgs> NodeIndexed;

	public event EventHandler<IndexingNodesEventArgs> NodesIndexing;

	public event EventHandler<IndexedNodesEventArgs> NodesIndexed;

	public event EventHandler<IndexingNodeDataEventArgs> GatheringNodeData;

	public event EventHandler<DeleteIndexEventArgs> IndexDeleted;

	public event EventHandler<IndexingFieldDataEventArgs> GatheringFieldData;

	public event EventHandler<IndexingNodeDataEventArgs> IgnoringNode;

	protected BaseIndexProvider()
	{
	}

	protected BaseIndexProvider(IIndexCriteria indexerData)
	{
		IndexerData = indexerData;
	}

	[SecuritySafeCritical]
	public override void Initialize(string name, NameValueCollection config)
	{
		((ProviderBase)this).Initialize(name, config);
	}

	public abstract void ReIndexNode(XElement node, string type);

	public abstract void DeleteFromIndex(string nodeId);

	public abstract void IndexAll(string type);

	public abstract void RebuildIndex();

	public abstract bool IndexExists();

	protected virtual void OnIgnoringNode(IndexingNodeDataEventArgs e)
	{
		if (this.IgnoringNode != null)
		{
			this.IgnoringNode(this, e);
		}
	}

	protected virtual void OnIndexingError(IndexingErrorEventArgs e)
	{
		if (this.IndexingError != null)
		{
			this.IndexingError(this, e);
		}
	}

	protected virtual void OnNodeIndexed(IndexedNodeEventArgs e)
	{
		if (this.NodeIndexed != null)
		{
			this.NodeIndexed(this, e);
		}
	}

	protected virtual void OnNodeIndexing(IndexingNodeEventArgs e)
	{
		if (this.NodeIndexing != null)
		{
			this.NodeIndexing(this, e);
		}
	}

	protected virtual void OnIndexDeleted(DeleteIndexEventArgs e)
	{
		if (this.IndexDeleted != null)
		{
			this.IndexDeleted(this, e);
		}
	}

	protected virtual void OnGatheringNodeData(IndexingNodeDataEventArgs e)
	{
		if (this.GatheringNodeData != null)
		{
			this.GatheringNodeData(this, e);
		}
	}

	protected virtual void OnGatheringFieldData(IndexingFieldDataEventArgs e)
	{
		if (this.GatheringFieldData != null)
		{
			this.GatheringFieldData(this, e);
		}
	}

	protected virtual void OnNodesIndexed(IndexedNodesEventArgs e)
	{
		if (this.NodesIndexed != null)
		{
			this.NodesIndexed(this, e);
		}
	}

	protected virtual void OnNodesIndexing(IndexingNodesEventArgs e)
	{
		if (this.NodesIndexing != null)
		{
			this.NodesIndexing(this, e);
		}
	}
}
