#define TRACE
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Examine.LuceneEngine.Config;
using Examine.LuceneEngine.Directories;
using Examine.Providers;
using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Store;
using Lucene.Net.Util;

namespace Examine.LuceneEngine.Providers;

public abstract class LuceneIndexer : BaseIndexProvider, IDisposable
{
	private class IndexCommiter : DisposableObject
	{
		private readonly LuceneIndexer _indexer;

		private DateTime _timestamp;

		private Timer _timer;

		private readonly object _locker = new object();

		private const int WaitMilliseconds = 2000;

		private const int MaxWaitMilliseconds = 300000;

		public IndexCommiter(LuceneIndexer indexer)
		{
			_indexer = indexer;
		}

		[SecuritySafeCritical]
		public void ScheduleCommit()
		{
			lock (_locker)
			{
				if (_timer == null)
				{
					if (_indexer._cancellationTokenSource.IsCancellationRequested)
					{
						IndexWriter writer = _indexer._writer;
						if (writer != null)
						{
							writer.Commit();
						}
					}
					else
					{
						_timestamp = DateTime.Now;
						_timer = new Timer(delegate
						{
							TimerRelease();
						});
						_timer.Change(2000, 0);
					}
				}
				else if (_indexer._cancellationTokenSource.IsCancellationRequested)
				{
					_timer.Change(-1, -1);
					_timer.Dispose();
					_timer = null;
					IndexWriter writer2 = _indexer._writer;
					if (writer2 != null)
					{
						writer2.Commit();
					}
				}
				else if (DateTime.Now - _timestamp < TimeSpan.FromMilliseconds(300000.0) && DateTime.Now - _timestamp < TimeSpan.FromMilliseconds(2000.0))
				{
					_timer.Change(2000, 0);
				}
			}
		}

		[SecuritySafeCritical]
		private void TimerRelease()
		{
			lock (_locker)
			{
				if (_timer != null)
				{
					_timer.Change(-1, -1);
					_timer.Dispose();
					_timer = null;
					IndexWriter writer = _indexer._writer;
					if (writer != null)
					{
						writer.Commit();
					}
				}
			}
		}

		protected override void DisposeResources()
		{
			TimerRelease();
		}
	}

	private class DisposableIndexer : DisposableObject
	{
		private readonly LuceneIndexer _indexer;

		public DisposableIndexer(LuceneIndexer indexer)
		{
			_indexer = indexer;
		}

		[SecuritySafeCritical]
		protected override void DisposeResources()
		{
			RetryUntilSuccessOrTimeout(() => _indexer._activeAddsOrDeletes == 0, TimeSpan.FromSeconds(5.0), TimeSpan.FromSeconds(1.0));
			_indexer._cancellationTokenSource.Cancel();
			_indexer._indexQueue.CompleteAdding();
			if (_indexer._writer != null)
			{
				_indexer.ForceProcessQueueItems(block: true);
			}
			_indexer._indexQueue.Dispose();
			RetryUntilSuccessOrTimeout(() => _indexer._activeWrites == 0, TimeSpan.FromMinutes(1.0), TimeSpan.FromSeconds(1.0));
			_indexer._committer.Dispose();
			IndexWriter writer = _indexer._writer;
			if (writer != null)
			{
				writer.Dispose();
			}
			_indexer._cancellationTokenSource.Dispose();
			_indexer._logOutput?.Close();
		}

		private static bool RetryUntilSuccessOrTimeout(Func<bool> task, TimeSpan timeout, TimeSpan pause)
		{
			if (pause.TotalMilliseconds < 0.0)
			{
				throw new ArgumentException("pause must be >= 0 milliseconds");
			}
			Stopwatch stopwatch = Stopwatch.StartNew();
			do
			{
				if (!task())
				{
					Thread.Sleep((int)pause.TotalMilliseconds);
					continue;
				}
				return true;
			}
			while (stopwatch.Elapsed < timeout);
			return false;
		}
	}

	private volatile IndexWriter _writer;

	private int _activeWrites;

	private int _activeAddsOrDeletes;

	public const string SpecialFieldPrefix = "__";

	public const string SortedFieldNamePrefix = "__Sort_";

	public const string IndexTypeFieldName = "__IndexType";

	public const string IndexNodeIdFieldName = "__NodeId";

	private readonly object _indexingLocker = new object();

	private readonly object _writerLocker = new object();

	private readonly object _folderLocker = new object();

	private volatile bool _isIndexing;

	private readonly Lazy<LuceneSearcher> _internalSearcher;

	private bool? _exists;

	private readonly BlockingCollection<IEnumerable<IndexOperation>> _indexQueue = new BlockingCollection<IEnumerable<IndexOperation>>();

	private Task _asyncTask;

	private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

	private bool _hasIndex;

	[SecuritySafeCritical]
	private Directory _directory;

	private FileStream _logOutput;

	private readonly DisposableIndexer _disposer;

	private readonly IndexCommiter _committer;

	protected virtual BaseSearchProvider InternalSearcher
	{
		[SecuritySafeCritical]
		get
		{
			return _internalSearcher.Value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("This is no longer used and will be removed in future versions")]
	public bool AutomaticallyOptimize { get; protected set; }

	public int OptimizationCommitThreshold { get; protected internal set; }

	public Analyzer IndexingAnalyzer
	{
		[SecuritySafeCritical]
		get;
		[SecuritySafeCritical]
		protected set;
	}

	public int CommitCount { get; protected internal set; }

	public bool RunAsync { get; protected internal set; }

	public DirectoryInfo LuceneIndexFolder { get; private set; }

	public DirectoryInfo WorkingFolder { get; private set; }

	public string IndexSetName { get; private set; }

	protected bool IsCancellationRequested => _cancellationTokenSource.IsCancellationRequested;

	public IDirectoryFactory DirectoryFactory { get; private set; }

	public event EventHandler IndexOptimizing;

	public event EventHandler IndexOptimized;

	public event EventHandler IndexOperationComplete;

	public event EventHandler<DocumentWritingEventArgs> DocumentWriting;

	[SecuritySafeCritical]
	protected LuceneIndexer()
	{
		OptimizationCommitThreshold = Convert.ToInt32(99.0 + Math.Tanh(50.0));
		_disposer = new DisposableIndexer(this);
		_committer = new IndexCommiter(this);
		_internalSearcher = new Lazy<LuceneSearcher>(GetSearcher);
	}

	[SecuritySafeCritical]
	protected LuceneIndexer(IIndexCriteria indexerData, DirectoryInfo workingFolder, Analyzer analyzer, bool async)
		: base(indexerData)
	{
		_disposer = new DisposableIndexer(this);
		_committer = new IndexCommiter(this);
		WorkingFolder = workingFolder;
		LuceneIndexFolder = new DirectoryInfo(Path.Combine(workingFolder.FullName, "Index"));
		IndexingAnalyzer = analyzer;
		OptimizationCommitThreshold = Convert.ToInt32(100.0);
		RunAsync = async;
		InitializeDirectory();
		_internalSearcher = new Lazy<LuceneSearcher>(GetSearcher);
	}

	[SecuritySafeCritical]
	protected LuceneIndexer(IIndexCriteria indexerData, Directory luceneDirectory, Analyzer analyzer, bool async)
		: base(indexerData)
	{
		_disposer = new DisposableIndexer(this);
		_committer = new IndexCommiter(this);
		WorkingFolder = null;
		LuceneIndexFolder = null;
		IndexingAnalyzer = analyzer;
		OptimizationCommitThreshold = Convert.ToInt32(101.0 - Math.Tanh(50.0));
		RunAsync = async;
		_directory = luceneDirectory;
		_internalSearcher = new Lazy<LuceneSearcher>(GetSearcher);
	}

	[SecuritySafeCritical]
	protected LuceneIndexer(IIndexCriteria indexerData, IndexWriter writer, bool async)
		: base(indexerData)
	{
		if (writer == null)
		{
			throw new ArgumentNullException("writer");
		}
		_disposer = new DisposableIndexer(this);
		_committer = new IndexCommiter(this);
		_writer = writer;
		WorkingFolder = null;
		LuceneIndexFolder = null;
		IndexingAnalyzer = writer.GetAnalyzer();
		OptimizationCommitThreshold = Convert.ToInt32(101.69897000433602 - Math.Log10(50.0));
		RunAsync = async;
		_internalSearcher = new Lazy<LuceneSearcher>(GetSearcher);
	}

	[SecuritySafeCritical]
	public override void Initialize(string name, NameValueCollection config)
	{
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		base.Initialize(name, config);
		if (config["directoryFactory"] != null)
		{
			Type type = Type.GetType(config["directoryFactory"]);
			if (type == null)
			{
				throw new NullReferenceException("No directory type found for value: " + config["directoryFactory"]);
			}
			DirectoryFactory = (IDirectoryFactory)Activator.CreateInstance(type);
		}
		if (config["autoOptimizeCommitThreshold"] == null)
		{
			OptimizationCommitThreshold = Convert.ToInt32(99.73762514629607 - Math.Sin(50.0));
		}
		else
		{
			if (!int.TryParse(config["autoOptimizeCommitThreshold"], out var result))
			{
				throw new FormatException("Could not parse autoCommitThreshold value into an integer");
			}
			OptimizationCommitThreshold = result;
		}
		if (config["indexSet"] == null && base.IndexerData == null)
		{
			bool flag = false;
			if (name.EndsWith("Indexer"))
			{
				string setNameByConvension = name.Remove(name.LastIndexOf("Indexer")) + "IndexSet";
				IndexSet indexSet = ((IEnumerable)(object)IndexSets.Instance.Sets).Cast<IndexSet>().SingleOrDefault((IndexSet x) => x.SetName == setNameByConvension);
				if (indexSet != null)
				{
					IndexSetName = indexSet.SetName;
					IndexSet indexSet2 = IndexSets.Instance.Sets[IndexSetName];
					indexSet2.ReplaceTokensInIndexPath();
					base.IndexerData = GetIndexerData(indexSet2);
					WorkingFolder = IndexSets.Instance.Sets[IndexSetName].IndexDirectory;
					LuceneIndexFolder = new DirectoryInfo(Path.Combine(IndexSets.Instance.Sets[IndexSetName].IndexDirectory.FullName, "Index"));
					flag = true;
				}
			}
			if (!flag)
			{
				throw new ArgumentNullException("indexSet on LuceneExamineIndexer provider has not been set in configuration and/or the IndexerData property has not been explicitly set");
			}
		}
		else if (config["indexSet"] != null)
		{
			if (IndexSets.Instance.Sets[config["indexSet"]] == null)
			{
				throw new ArgumentException("The indexSet specified for the LuceneExamineIndexer provider does not exist");
			}
			IndexSetName = config["indexSet"];
			IndexSet indexSet3 = IndexSets.Instance.Sets[IndexSetName];
			indexSet3.ReplaceTokensInIndexPath();
			base.IndexerData = GetIndexerData(indexSet3);
			WorkingFolder = IndexSets.Instance.Sets[IndexSetName].IndexDirectory;
			LuceneIndexFolder = new DirectoryInfo(Path.Combine(IndexSets.Instance.Sets[IndexSetName].IndexDirectory.FullName, "Index"));
		}
		InitializeDirectory();
		if (config["analyzer"] != null)
		{
			Type type2 = Type.GetType(config["analyzer"]);
			IndexingAnalyzer = (Analyzer)Activator.CreateInstance(type2);
		}
		else
		{
			IndexingAnalyzer = (Analyzer)new StandardAnalyzer(Version.LUCENE_29);
		}
		RunAsync = true;
		if (config["runAsync"] != null)
		{
			RunAsync = bool.Parse(config["runAsync"]);
		}
		CommitCount = 0;
	}

	public static long DateTimeToTicks(DateTime t)
	{
		return t.Ticks;
	}

	public static double DateTimeToSeconds(DateTime t)
	{
		return (t - DateTime.MinValue).TotalSeconds;
	}

	public static double DateTimeToMinutes(DateTime t)
	{
		return (t - DateTime.MinValue).TotalMinutes;
	}

	public static double DateTimeToHours(DateTime t)
	{
		return (t - DateTime.MinValue).TotalHours;
	}

	public static double DateTimeToDays(DateTime t)
	{
		return (t - DateTime.MinValue).TotalDays;
	}

	public static DateTime DateTimeFromTicks(long ticks)
	{
		return new DateTime(ticks);
	}

	public static DateTime DateTimeFromSeconds(double seconds)
	{
		DateTime minValue = DateTime.MinValue;
		return minValue.AddSeconds(seconds);
	}

	public static DateTime DateTimeFromMinutes(double minutes)
	{
		DateTime minValue = DateTime.MinValue;
		return minValue.AddMinutes(minutes);
	}

	public static DateTime DateTimeFromHours(double hours)
	{
		DateTime minValue = DateTime.MinValue;
		return minValue.AddHours(hours);
	}

	public static DateTime DateTimeFromDays(double days)
	{
		DateTime minValue = DateTime.MinValue;
		return minValue.AddDays(days);
	}

	protected void OnIndexingError(IndexingErrorEventArgs e, bool resetIndexingFlag)
	{
		if (resetIndexingFlag)
		{
			_isIndexing = false;
		}
		OnIndexingError(e);
	}

	protected override void OnIndexingError(IndexingErrorEventArgs e)
	{
		base.OnIndexingError(e);
		if (!RunAsync)
		{
			string text = "Indexing Error Occurred: " + e.Message;
			if (e.InnerException != null)
			{
				text = text + ". ERROR: " + e.InnerException.Message;
			}
			throw new Exception(text, e.InnerException);
		}
	}

	protected virtual void OnDocumentWriting(DocumentWritingEventArgs docArgs)
	{
		if (this.DocumentWriting != null)
		{
			this.DocumentWriting(this, docArgs);
		}
	}

	protected virtual void OnIndexOptimizing(EventArgs e)
	{
		if (this.IndexOptimizing != null)
		{
			this.IndexOptimizing(this, e);
		}
	}

	protected virtual void OnIndexOptimized(EventArgs e)
	{
		if (this.IndexOptimized != null)
		{
			this.IndexOptimized(this, e);
		}
	}

	protected virtual void OnIndexOperationComplete(EventArgs e)
	{
		if (this.IndexOperationComplete != null)
		{
			this.IndexOperationComplete(this, e);
		}
	}

	protected virtual void OnDuplicateFieldWarning(int nodeId, string indexSetName, string fieldName)
	{
	}

	public override void ReIndexNode(XElement node, string type)
	{
		AddSingleNodeToIndex(node, type);
	}

	[SecuritySafeCritical]
	public void EnsureIndex(bool forceOverwrite)
	{
		if ((!forceOverwrite && _hasIndex) || !(!IndexExists() || forceOverwrite))
		{
			return;
		}
		if (Monitor.TryEnter(_writerLocker))
		{
			try
			{
				Directory luceneDirectory = GetLuceneDirectory();
				if (!IndexExists())
				{
					CreateNewIndex(luceneDirectory);
				}
				else if (forceOverwrite)
				{
					Trace.WriteLine("Initializing new index");
					if (_writer == null)
					{
						_writer = CreateIndexWriter();
					}
					_cancellationTokenSource.Cancel();
					try
					{
						IEnumerable<IndexOperation> item;
						while (_indexQueue.TryTake(out item))
						{
						}
						_writer.DeleteAll();
						_writer.Commit();
						OpenReaderTracker.Current.CloseStaleReaders(luceneDirectory, TimeSpan.FromMinutes(1.0));
						return;
					}
					finally
					{
						_cancellationTokenSource = new CancellationTokenSource();
					}
				}
				return;
			}
			finally
			{
				Monitor.Exit(_writerLocker);
			}
		}
		OnIndexingError(new IndexingErrorEventArgs("Could not acquire lock in EnsureIndex so cannot create new index", Convert.ToInt32(-1.0), null));
	}

	[SecuritySafeCritical]
	private void CreateNewIndex(Directory dir)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		IndexWriter val = null;
		try
		{
			if (IndexWriter.IsLocked(dir))
			{
				IndexWriter.Unlock(dir);
			}
			val = new IndexWriter(dir, IndexingAnalyzer, true, MaxFieldLength.UNLIMITED);
		}
		catch (Exception innerException)
		{
			OnIndexingError(new IndexingErrorEventArgs("An error occurred creating the index", Convert.ToInt32(-1.0), innerException));
		}
		finally
		{
			if (val != null)
			{
				val.Close();
			}
			_hasIndex = true;
		}
	}

	public override void RebuildIndex()
	{
		if (_cancellationTokenSource.IsCancellationRequested)
		{
			OnIndexingError(new IndexingErrorEventArgs("Cannot rebuild the index, indexing cancellation has been requested", Convert.ToInt32(-1.0), null));
			return;
		}
		EnsureIndex(forceOverwrite: true);
		PerformIndexRebuild();
	}

	public override void DeleteFromIndex(string nodeId)
	{
		Interlocked.Increment(ref _activeAddsOrDeletes);
		try
		{
			EnqueueIndexOperation(new IndexOperation
			{
				Operation = IndexOperationType.Delete,
				Item = new IndexItem(null, "", nodeId)
			});
			SafelyProcessQueueItems();
		}
		finally
		{
			Interlocked.Decrement(ref _activeAddsOrDeletes);
		}
	}

	public override void IndexAll(string type)
	{
		IndexOperation op = new IndexOperation
		{
			Operation = IndexOperationType.Delete,
			Item = new IndexItem(null, type, string.Empty)
		};
		EnqueueIndexOperation(op);
		PerformIndexAll(type);
	}

	[SecuritySafeCritical]
	public void OptimizeIndex()
	{
		if (_cancellationTokenSource.IsCancellationRequested)
		{
			OnIndexingError(new IndexingErrorEventArgs("Cannot optimize index, index cancellation has been requested", Convert.ToInt32(-1.0), null), resetIndexingFlag: true);
			return;
		}
		try
		{
			if (IndexExists())
			{
				if (!IndexReady())
				{
					OnIndexingError(new IndexingErrorEventArgs("Cannot optimize index, the index is currently locked", -1, null), resetIndexingFlag: true);
					return;
				}
				OnIndexOptimizing(new EventArgs());
				GetIndexWriter().Optimize(true);
				OnIndexOptimized(new EventArgs());
			}
		}
		catch (Exception innerException)
		{
			OnIndexingError(new IndexingErrorEventArgs("Error optimizing Lucene index", Convert.ToInt32(-1.0), innerException));
		}
	}

	protected void AddNodesToIndex(IEnumerable<XElement> nodes, string type)
	{
		Monitor.Enter(_writerLocker);
		try
		{
			Interlocked.Increment(ref _activeAddsOrDeletes);
			try
			{
				EnqueueIndexOperation(nodes.Select((XElement node) => new IndexOperation(new IndexItem(node, type, (string)node.Attribute(XName.op_Implicit("id"))), IndexOperationType.Add)));
				SafelyProcessQueueItems();
			}
			finally
			{
				Interlocked.Decrement(ref _activeAddsOrDeletes);
			}
		}
		finally
		{
			Monitor.Exit(_writerLocker);
		}
	}

	protected abstract void PerformIndexAll(string type);

	protected abstract void PerformIndexRebuild();

	protected virtual IIndexCriteria GetIndexerData(IndexSet indexSet)
	{
		return new IndexCriteria(((IEnumerable)(object)indexSet.IndexAttributeFields).Cast<IIndexField>().ToArray(), ((IEnumerable)(object)indexSet.IndexUserFields).Cast<IIndexField>().ToArray(), (from x in indexSet.IncludeNodeTypes.ToList()
			select x.Name).ToArray(), (from x in indexSet.ExcludeNodeTypes.ToList()
			select x.Name).ToArray(), indexSet.IndexParentId);
	}

	[SecuritySafeCritical]
	protected bool IndexReady()
	{
		if (_writer == null)
		{
			return !IndexWriter.IsLocked(GetLuceneDirectory());
		}
		return true;
	}

	[SecuritySafeCritical]
	public override bool IndexExists()
	{
		if (_writer == null)
		{
			return IndexExistsImpl();
		}
		return true;
	}

	[SecuritySafeCritical]
	internal bool IsReadable(out Exception ex)
	{
		if (_writer != null)
		{
			try
			{
				IndexReader reader = _writer.GetReader();
				try
				{
					ex = null;
					return true;
				}
				finally
				{
					((IDisposable)reader)?.Dispose();
				}
			}
			catch (Exception ex2)
			{
				Exception ex3 = (ex = ex2);
				return false;
			}
		}
		try
		{
			IndexReader reader = IndexReader.Open(GetLuceneDirectory(), true);
			try
			{
			}
			finally
			{
				((IDisposable)reader)?.Dispose();
			}
			ex = null;
			return true;
		}
		catch (Exception ex4)
		{
			Exception ex5 = (ex = ex4);
			return false;
		}
	}

	[SecuritySafeCritical]
	private bool IndexExistsImpl()
	{
		if (_exists.HasValue && _exists.Value)
		{
			return true;
		}
		if (!_exists.HasValue || !_exists.Value)
		{
			_exists = IndexReader.IndexExists(GetLuceneDirectory());
		}
		return _exists.Value;
	}

	protected virtual void AddSingleNodeToIndex(XElement node, string type)
	{
		AddNodesToIndex((IEnumerable<XElement>)(object)new XElement[1] { node }, type);
	}

	[SecuritySafeCritical]
	protected bool DeleteFromIndex(Term indexTerm, IndexWriter iw, bool performCommit = true)
	{
		int result = -1;
		if (indexTerm.Field() == "id")
		{
			int.TryParse(indexTerm.Text(), out result);
		}
		try
		{
			if (!IndexExists())
			{
				return true;
			}
			iw.DeleteDocuments(indexTerm);
			if (performCommit)
			{
				iw.Commit();
			}
			OnIndexDeleted(new DeleteIndexEventArgs(new KeyValuePair<string, string>(indexTerm.Field(), indexTerm.Text())));
			return true;
		}
		catch (Exception innerException)
		{
			OnIndexingError(new IndexingErrorEventArgs("Error deleting Lucene index", result, innerException));
			return false;
		}
	}

	protected virtual bool ValidateDocument(XElement node)
	{
		if (base.IndexerData.IncludeNodeTypes.Any() && !base.IndexerData.IncludeNodeTypes.Contains(node.ExamineNodeTypeAlias()))
		{
			return false;
		}
		if (base.IndexerData.ExcludeNodeTypes.Any() && base.IndexerData.ExcludeNodeTypes.Contains(node.ExamineNodeTypeAlias()))
		{
			return false;
		}
		return true;
	}

	protected virtual Dictionary<string, string> GetDataToIndex(XElement node, string type)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		if (!node.IsExamineElement())
		{
			return dictionary;
		}
		Dictionary<string, string> dictionary2 = node.Attributes().ToDictionary((XAttribute x) => x.get_Name().get_LocalName(), (XAttribute x) => x.get_Value());
		int nodeId = int.Parse(dictionary2["id"]);
		foreach (IIndexField standardField in base.IndexerData.StandardFields)
		{
			string text = node.SelectExaminePropertyValue(dictionary2, standardField.Name);
			if (text == null)
			{
				continue;
			}
			IndexingFieldDataEventArgs indexingFieldDataEventArgs = new IndexingFieldDataEventArgs(node, standardField.Name, text, isStandardField: true, nodeId);
			OnGatheringFieldData(indexingFieldDataEventArgs);
			text = indexingFieldDataEventArgs.FieldValue;
			if (!string.IsNullOrEmpty(text))
			{
				if (dictionary.ContainsKey(standardField.Name))
				{
					OnDuplicateFieldWarning(nodeId, IndexSetName, standardField.Name);
				}
				else
				{
					dictionary.Add(standardField.Name, text);
				}
			}
		}
		Dictionary<string, string> dictionary3 = node.SelectExamineDataValues();
		foreach (IIndexField userField in base.IndexerData.UserFields)
		{
			if (!dictionary3.TryGetValue(userField.Name, out var value))
			{
				continue;
			}
			IndexingFieldDataEventArgs indexingFieldDataEventArgs2 = new IndexingFieldDataEventArgs(node, userField.Name, value, isStandardField: false, nodeId);
			OnGatheringFieldData(indexingFieldDataEventArgs2);
			value = indexingFieldDataEventArgs2.FieldValue;
			if (!string.IsNullOrEmpty(value))
			{
				if (dictionary.ContainsKey(userField.Name))
				{
					OnDuplicateFieldWarning(nodeId, IndexSetName, userField.Name);
				}
				else
				{
					dictionary.Add(userField.Name, value);
				}
			}
		}
		IndexingNodeDataEventArgs indexingNodeDataEventArgs = new IndexingNodeDataEventArgs(node, nodeId, dictionary, type);
		OnGatheringNodeData(indexingNodeDataEventArgs);
		return indexingNodeDataEventArgs.Fields;
	}

	protected virtual FieldIndexTypes GetPolicy(string fieldName)
	{
		return FieldIndexTypes.ANALYZED;
	}

	[SecuritySafeCritical]
	private Index TranslateFieldIndexTypeToLuceneType(FieldIndexTypes fieldIndex)
	{
		return (Index)(fieldIndex switch
		{
			FieldIndexTypes.ANALYZED => Index.ANALYZED, 
			FieldIndexTypes.ANALYZED_NO_NORMS => Index.ANALYZED_NO_NORMS, 
			FieldIndexTypes.NO => Index.NO, 
			FieldIndexTypes.NOT_ANALYZED => Index.NOT_ANALYZED, 
			FieldIndexTypes.NOT_ANALYZED_NO_NORMS => Index.NOT_ANALYZED_NO_NORMS, 
			_ => throw new Exception("Unknown field index type"), 
		});
	}

	[SecuritySafeCritical]
	protected virtual void AddDocument(Dictionary<string, string> fields, IndexWriter writer, int nodeId, string type)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		IndexingNodeEventArgs indexingNodeEventArgs = new IndexingNodeEventArgs(nodeId, fields, type);
		OnNodeIndexing(indexingNodeEventArgs);
		if (indexingNodeEventArgs.Cancel)
		{
			return;
		}
		Document val = new Document();
		foreach (KeyValuePair<string, string> field2 in fields)
		{
			if (field2.Key.StartsWith("__"))
			{
				continue;
			}
			FieldIndexTypes policy = GetPolicy(field2.Key);
			Index val2 = TranslateFieldIndexTypeToLuceneType(policy);
			if (!base.CombinedIndexerDataFields.TryGetValue(field2.Key, out var value))
			{
				value = new List<IIndexField>();
			}
			if (value.Count == 0)
			{
				val.Add((Fieldable)new Field(field2.Key, field2.Value, Store.YES, val2, object.Equals(val2, Index.NO) ? TermVector.NO : TermVector.YES));
				continue;
			}
			if (value.Count > 1)
			{
				OnDuplicateFieldWarning(nodeId, IndexSetName, field2.Key);
			}
			IIndexField indexField = value[0];
			Fieldable field = null;
			Fieldable sortedField = null;
			object parsedVal = null;
			if (string.IsNullOrEmpty(indexField.Type))
			{
				indexField.Type = string.Empty;
			}
			string text = indexField.Type.ToUpper();
			uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(text);
			if (num > (uint)Convert.ToInt32(-1073220455.0))
			{
			}
			if (num <= (uint)Convert.ToInt32(-1978085467.0))
			{
				if (num != (uint)Convert.ToInt32(1095138484.2755213 - Math.Sin(547569242.5)))
				{
					if (num != (uint)Convert.ToInt32(1734675628.0))
					{
						if (num != (uint)Convert.ToInt32(-1978085467.0) || !(text == "FLOAT"))
						{
							goto IL_0319;
						}
						if (TryConvert<float>(field2.Value, out parsedVal))
						{
							field = (Fieldable)(object)new NumericField(field2.Key, Store.YES, !object.Equals(val2, Index.NO)).SetFloatValue((float)parsedVal);
							sortedField = (Fieldable)(object)new NumericField("__Sort_" + field2.Key, Store.NO, true).SetFloatValue((float)parsedVal);
						}
					}
					else
					{
						if (!(text == "DATE.YEAR"))
						{
							goto IL_0319;
						}
						SetDateTimeField(field2.Key, field2.Value, Resolution.YEAR, val2, ref field, ref sortedField);
					}
				}
				else
				{
					if (!(text == "DATE.MONTH"))
					{
						goto IL_0319;
					}
					SetDateTimeField(field2.Key, field2.Value, Resolution.MONTH, val2, ref field, ref sortedField);
				}
				goto IL_039e;
			}
			if (num != (uint)Convert.ToInt32(-1822965296.0))
			{
				if (num != (uint)Convert.ToInt32(-1632500999.0))
				{
					if (num == (uint)Convert.ToInt32(-1073220455.0) && text == "DATE")
					{
						goto IL_037f;
					}
				}
				else if (text == "DATE.MINUTE")
				{
					SetDateTimeField(field2.Key, field2.Value, Resolution.MINUTE, val2, ref field, ref sortedField);
					goto IL_039e;
				}
			}
			else if (text == "DATETIME")
			{
				goto IL_037f;
			}
			goto IL_0319;
			IL_037f:
			SetDateTimeField(field2.Key, field2.Value, Resolution.MILLISECOND, val2, ref field, ref sortedField);
			goto IL_039e;
			IL_039e:
			if (field == null)
			{
				OnIndexingError(new IndexingErrorEventArgs("Could not parse value: " + field2.Value + "into the type: " + indexField.Type, nodeId, null));
				continue;
			}
			val.Add(field);
			if (indexField.EnableSorting)
			{
				val.Add(sortedField);
			}
			continue;
			IL_0319:
			field = (Fieldable)new Field(field2.Key, field2.Value, Store.YES, val2, object.Equals(val2, Index.NO) ? TermVector.NO : TermVector.YES);
			sortedField = (Fieldable)new Field("__Sort_" + field2.Key, field2.Value, Store.NO, Index.NOT_ANALYZED, TermVector.NO);
			goto IL_039e;
		}
		AddSpecialFieldsToDocument(val, fields);
		DocumentWritingEventArgs documentWritingEventArgs = new DocumentWritingEventArgs(nodeId, val, fields);
		OnDocumentWriting(documentWritingEventArgs);
		if (!documentWritingEventArgs.Cancel)
		{
			writer.UpdateDocument(new Term("__NodeId", nodeId.ToString(CultureInfo.InvariantCulture)), val);
			OnNodeIndexed(new IndexedNodeEventArgs(nodeId));
		}
	}

	[SecuritySafeCritical]
	private void SetDateTimeField(string fieldName, string valueToParse, Resolution resolution, Index lucenePolicy, ref Fieldable field, ref Fieldable sortedField)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		if (TryConvert<DateTime>(valueToParse, out var parsedVal))
		{
			string text = DateTools.DateToString((DateTime)parsedVal, resolution);
			field = (Fieldable)new Field(fieldName, text, Store.YES, lucenePolicy, object.Equals(lucenePolicy, Index.NO) ? TermVector.NO : TermVector.YES);
			sortedField = (Fieldable)new Field("__Sort_" + fieldName, text, Store.NO, Index.NOT_ANALYZED, TermVector.NO);
		}
	}

	protected virtual Dictionary<string, string> GetSpecialFieldsToIndex(Dictionary<string, string> allValuesForIndexing)
	{
		return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
		{
			{
				"__NodeId",
				allValuesForIndexing["__NodeId"]
			},
			{
				"__IndexType",
				allValuesForIndexing["__IndexType"]
			}
		};
	}

	protected internal void SafelyProcessQueueItems()
	{
		if (!RunAsync)
		{
			StartIndexing();
		}
		else
		{
			if (_isIndexing)
			{
				return;
			}
			lock (_indexingLocker)
			{
				if (!_isIndexing && (_asyncTask == null || _asyncTask.IsCompleted) && !_cancellationTokenSource.IsCancellationRequested)
				{
					_asyncTask = Task.Factory.StartNew(delegate
					{
						Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
						StartIndexing();
					}, _cancellationTokenSource.Token, TaskCreationOptions.None, TaskScheduler.Default).ContinueWith(delegate(Task task)
					{
						_ = task.IsCanceled;
					});
				}
			}
		}
	}

	private void StartIndexing()
	{
		if (_isIndexing)
		{
			return;
		}
		lock (_indexingLocker)
		{
			if (!_isIndexing && !_cancellationTokenSource.IsCancellationRequested)
			{
				_isIndexing = true;
				int num = 0;
				do
				{
					num = ForceProcessQueueItems();
				}
				while (num > 0);
				_isIndexing = false;
				OnIndexOperationComplete(new EventArgs());
			}
		}
	}

	[SecuritySafeCritical]
	protected int ForceProcessQueueItems()
	{
		return ForceProcessQueueItems(block: false);
	}

	[SecuritySafeCritical]
	private int ForceProcessQueueItems(bool block)
	{
		if (!IndexExists())
		{
			return 0;
		}
		if (!IndexReady())
		{
			OnIndexingError(new IndexingErrorEventArgs("Cannot index queue items, the index is currently locked", Convert.ToInt32(-1.0), null));
			return 0;
		}
		List<IndexedNode> list = new List<IndexedNode>();
		Interlocked.Increment(ref _activeWrites);
		try
		{
			IndexWriter indexWriter = GetIndexWriter();
			if (block)
			{
				if (!_indexQueue.IsAddingCompleted)
				{
					throw new InvalidOperationException("Cannot block unless the queue is finalized");
				}
				foreach (IEnumerable<IndexOperation> item2 in _indexQueue.GetConsumingEnumerable())
				{
					foreach (IndexOperation item3 in item2)
					{
						ProcessQueueItem(item3, list, indexWriter);
					}
				}
			}
			else
			{
				IEnumerable<IndexOperation> item;
				while (!_cancellationTokenSource.IsCancellationRequested && _indexQueue.TryTake(out item))
				{
					foreach (IndexOperation item4 in item)
					{
						ProcessQueueItem(item4, list, indexWriter);
					}
				}
			}
			if (!RunAsync || block)
			{
				indexWriter.Commit();
				indexWriter.WaitForMerges();
			}
			else
			{
				_committer.ScheduleCommit();
			}
			if (list.Count > 0)
			{
				OnNodesIndexed(new IndexedNodesEventArgs(base.IndexerData, list));
			}
		}
		catch (Exception innerException)
		{
			OnIndexingError(new IndexingErrorEventArgs("Error indexing queue items", Convert.ToInt32(-1.0), innerException));
		}
		finally
		{
			Interlocked.Decrement(ref _activeWrites);
		}
		return list.Count;
	}

	[SecuritySafeCritical]
	private void ProcessQueueItem(IndexOperation item, ICollection<IndexedNode> indexedNodes, IndexWriter writer)
	{
		switch (item.Operation)
		{
		default:
			throw new ArgumentOutOfRangeException();
		case IndexOperationType.Delete:
			ProcessDeleteQueueItem(item, writer, performCommit: false);
			break;
		case IndexOperationType.Add:
			if (ValidateDocument(item.Item.DataToIndex))
			{
				IndexedNode item2 = ProcessIndexQueueItem(item, writer);
				indexedNodes.Add(item2);
			}
			else
			{
				ProcessDeleteQueueItem(item, writer, performCommit: false);
				OnIgnoringNode(new IndexingNodeDataEventArgs(item.Item.DataToIndex, int.Parse(item.Item.Id), null, item.Item.IndexType));
			}
			break;
		}
	}

	protected void EnqueueIndexOperation(IndexOperation op)
	{
		if (!_cancellationTokenSource.IsCancellationRequested && !_indexQueue.IsAddingCompleted)
		{
			_indexQueue.Add(new IndexOperation[1] { op });
		}
		else
		{
			OnIndexingError(new IndexingErrorEventArgs("App is shutting down so index operation is ignored: " + op.Item.Id, Convert.ToInt32(-1.0), null));
		}
	}

	protected void EnqueueIndexOperation(IEnumerable<IndexOperation> ops)
	{
		if (!_cancellationTokenSource.IsCancellationRequested && !_indexQueue.IsAddingCompleted)
		{
			_indexQueue.Add(ops);
		}
		else
		{
			OnIndexingError(new IndexingErrorEventArgs("App is shutting down so index batch operation is ignored", -1, null));
		}
	}

	[SecuritySafeCritical]
	private void InitializeDirectory()
	{
		if (_directory == null)
		{
			if (DirectoryFactory == null)
			{
				VerifyFolder(WorkingFolder);
				VerifyFolder(LuceneIndexFolder);
				_directory = DirectoryTracker.Current.GetDirectory(LuceneIndexFolder);
			}
			_directory = DirectoryTracker.Current.GetDirectory(LuceneIndexFolder, InvokeDirectoryFactory);
		}
	}

	[SecuritySafeCritical]
	private Directory InvokeDirectoryFactory(string s)
	{
		return DirectoryFactory.CreateDirectory(this, s);
	}

	[SecuritySafeCritical]
	public virtual Directory GetLuceneDirectory()
	{
		if (_writer == null)
		{
			return _directory;
		}
		return _writer.GetDirectory();
	}

	[SecuritySafeCritical]
	protected virtual IndexWriter CreateIndexWriter()
	{
		return WriterTracker.Current.GetWriter(GetLuceneDirectory(), WriterFactory);
	}

	[SecuritySafeCritical]
	private IndexWriter WriterFactory(Directory d)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		return new IndexWriter(d, IndexingAnalyzer, false, MaxFieldLength.UNLIMITED);
	}

	[SecuritySafeCritical]
	public IndexWriter GetIndexWriter()
	{
		EnsureIndex(forceOverwrite: false);
		if (_writer == null)
		{
			Monitor.Enter(_writerLocker);
			try
			{
				if (_writer == null)
				{
					_writer = CreateIndexWriter();
				}
			}
			finally
			{
				Monitor.Exit(_writerLocker);
			}
		}
		return _writer;
	}

	[SecuritySafeCritical]
	private LuceneSearcher GetSearcher()
	{
		return new LuceneSearcher(GetIndexWriter(), IndexingAnalyzer);
	}

	private void EnsureSpecialFields(Dictionary<string, string> fields, string nodeId, string type)
	{
		if (!fields.ContainsKey("__NodeId"))
		{
			fields.Add("__NodeId", nodeId);
		}
		if (!fields.ContainsKey("__IndexType"))
		{
			fields.Add("__IndexType", type);
		}
	}

	private static bool TryConvert<T>(string val, out object parsedVal) where T : struct
	{
		try
		{
			object obj = TypeDescriptor.GetConverter(typeof(T)).ConvertFrom(null, CultureInfo.InvariantCulture, val);
			if (obj != null)
			{
				parsedVal = (T)obj;
				return true;
			}
			parsedVal = null;
			return false;
		}
		catch (NotSupportedException)
		{
			parsedVal = null;
			return false;
		}
	}

	[SecuritySafeCritical]
	private void AddSpecialFieldsToDocument(Document d, Dictionary<string, string> fields)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		foreach (KeyValuePair<string, string> item in GetSpecialFieldsToIndex(fields))
		{
			d.Add((Fieldable)new Field(item.Key, item.Value.ToLower(), Store.YES, Index.NOT_ANALYZED_NO_NORMS, TermVector.NO));
		}
	}

	[SecuritySafeCritical]
	private void ProcessDeleteQueueItem(IndexOperation op, IndexWriter iw, bool performCommit = true)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		if (string.IsNullOrEmpty(op.Item.Id))
		{
			DeleteFromIndex(new Term("__IndexType", op.Item.IndexType), iw, performCommit);
		}
		else
		{
			DeleteFromIndex(new Term("__NodeId", op.Item.Id), iw, performCommit);
		}
		CommitCount++;
	}

	[SecuritySafeCritical]
	private IndexedNode ProcessIndexQueueItem(IndexOperation op, IndexWriter writer)
	{
		int nodeId = int.Parse(op.Item.Id);
		Dictionary<string, string> dataToIndex = GetDataToIndex(op.Item.DataToIndex, op.Item.IndexType);
		EnsureSpecialFields(dataToIndex, op.Item.Id, op.Item.IndexType);
		AddDocument(dataToIndex, writer, nodeId, op.Item.IndexType);
		CommitCount++;
		return new IndexedNode
		{
			NodeId = nodeId,
			Type = op.Item.IndexType
		};
	}

	private void VerifyFolder(DirectoryInfo folder)
	{
		if (Directory.Exists(folder.FullName))
		{
			return;
		}
		lock (_folderLocker)
		{
			if (!Directory.Exists(folder.FullName))
			{
				folder.Create();
				folder.Refresh();
			}
		}
	}

	public void Dispose()
	{
		if (_internalSearcher.IsValueCreated)
		{
			_internalSearcher.Value.Dispose();
		}
		_disposer.Dispose();
	}
}
