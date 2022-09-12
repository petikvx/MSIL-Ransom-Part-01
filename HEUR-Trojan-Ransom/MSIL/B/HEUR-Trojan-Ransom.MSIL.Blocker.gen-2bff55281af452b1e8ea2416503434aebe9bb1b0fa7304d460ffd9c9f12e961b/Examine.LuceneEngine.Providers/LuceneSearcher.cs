using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security;
using System.Threading;
using Examine.LuceneEngine.Config;
using Lucene.Net.Analysis;
using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Store;

namespace Examine.LuceneEngine.Providers;

public class LuceneSearcher : BaseLuceneSearcher, IDisposable
{
	private class ReaderReopener : DisposableObject
	{
		private readonly LuceneSearcher _luceneSearcher;

		private DateTime _timestamp;

		private Timer _timer;

		private readonly object _locker = new object();

		private bool _isLongPoll;

		private const int WaitMilliseconds = 2000;

		private const int MaxWaitMilliseconds = 10000;

		private const int LongPollWaitMilliseconds = 300000;

		public ReaderReopener(LuceneSearcher indexer)
		{
			_luceneSearcher = indexer;
		}

		[SecuritySafeCritical]
		public void ScheduleReopen()
		{
			lock (_locker)
			{
				bool isLongPoll = _isLongPoll;
				_isLongPoll = false;
				if (_timer == null)
				{
					if (_luceneSearcher._disposed)
					{
						return;
					}
					if (_luceneSearcher._nrtWriter != null)
					{
						MaybeReopen();
						return;
					}
					_timestamp = DateTime.Now;
					_timer = new Timer(delegate
					{
						TimerRelease();
					});
					_timer.Change(2000, 0);
					_isLongPoll = false;
				}
				else if (_luceneSearcher._disposed)
				{
					StopTimer();
				}
				else if (isLongPoll)
				{
					if (DateTime.Now - _timestamp > TimeSpan.FromMilliseconds(2000.0))
					{
						StopTimer();
						MaybeReopen();
						StartLongPoll();
					}
					else
					{
						_timer.Change(2000, 0);
					}
				}
				else if (DateTime.Now - _timestamp < TimeSpan.FromMilliseconds(10000.0) && DateTime.Now - _timestamp < TimeSpan.FromMilliseconds(2000.0))
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
				_isLongPoll = false;
				if (_timer != null)
				{
					StopTimer();
					if (!_luceneSearcher._disposed)
					{
						MaybeReopen();
						StartLongPoll();
					}
				}
			}
		}

		private void StopTimer()
		{
			_timer.Change(-1, -1);
			_timer.Dispose();
			_timer = null;
		}

		protected override void DisposeResources()
		{
			lock (_locker)
			{
				if (_timer != null)
				{
					StopTimer();
				}
			}
		}

		[SecuritySafeCritical]
		private void StartLongPoll()
		{
			if (_timer == null && !_isLongPoll && _luceneSearcher._nrtWriter == null)
			{
				_timestamp = DateTime.Now;
				_timer = new Timer(delegate
				{
					TimerRelease();
				});
				_timer.Change(300000, 0);
				_isLongPoll = true;
			}
		}

		[SecuritySafeCritical]
		private void MaybeReopen()
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected O, but got Unknown
			switch (_luceneSearcher._reader.GetReaderStatus())
			{
			case ReaderStatus.Closed:
				lock (_locker)
				{
					_luceneSearcher._reader = ((_luceneSearcher._nrtWriter == null) ? _luceneSearcher.OpenNewReader() : _luceneSearcher._nrtWriter.GetReader());
					_luceneSearcher._searcher = new IndexSearcher(_luceneSearcher._reader);
					OpenReaderTracker.Current.AddOpenReader(_luceneSearcher._reader);
					break;
				}
			case ReaderStatus.NotCurrent:
				lock (_locker)
				{
					IndexReader val = ((_luceneSearcher._nrtWriter != null || !_luceneSearcher.TryEstablishNrtReader()) ? _luceneSearcher._reader.Reopen() : _luceneSearcher._nrtWriter.GetReader());
					if (val != _luceneSearcher._reader)
					{
						_luceneSearcher._reader = val;
						_luceneSearcher._searcher = new IndexSearcher(_luceneSearcher._reader);
						OpenReaderTracker.Current.AddOpenReader(_luceneSearcher._reader);
						OpenReaderTracker.Current.CloseStaleReaders(_luceneSearcher.GetLuceneDirectory(), TimeSpan.FromMinutes(1.0));
					}
					break;
				}
			case ReaderStatus.Current:
				break;
			}
		}
	}

	private class DisposableSearcher : DisposableObject
	{
		private readonly LuceneSearcher _searcher;

		public DisposableSearcher(LuceneSearcher searcher)
		{
			_searcher = searcher;
		}

		[SecuritySafeCritical]
		protected override void DisposeResources()
		{
			_searcher._disposed = true;
			if (_searcher._reader != null)
			{
				try
				{
					_searcher._reader.Close();
				}
				catch (AlreadyClosedException)
				{
				}
			}
			_searcher._reopener.Dispose();
		}
	}

	private IndexSearcher _searcher;

	private volatile IndexReader _reader;

	private readonly object _locker = new object();

	private Directory _directory;

	private IndexWriter _nrtWriter;

	private bool? _exists;

	private bool _disposed;

	private ReaderReopener _reopener;

	private DirectoryInfo _indexFolder;

	private readonly DisposableSearcher _disposer;

	public DirectoryInfo LuceneIndexFolder
	{
		get
		{
			if (_indexFolder == null)
			{
				return null;
			}
			_indexFolder.Refresh();
			return _indexFolder;
		}
		private set
		{
			_indexFolder = value;
		}
	}

	public string IndexSetName { get; private set; }

	[SecuritySafeCritical]
	public LuceneSearcher()
	{
		_disposer = new DisposableSearcher(this);
		_reopener = new ReaderReopener(this);
	}

	[SecuritySafeCritical]
	public LuceneSearcher(IndexWriter writer, Analyzer analyzer)
		: base(analyzer)
	{
		if (writer == null)
		{
			throw new ArgumentNullException("writer");
		}
		_disposer = new DisposableSearcher(this);
		_reopener = new ReaderReopener(this);
		_nrtWriter = writer;
	}

	[SecuritySafeCritical]
	public LuceneSearcher(DirectoryInfo workingFolder, Analyzer analyzer)
		: base(analyzer)
	{
		_disposer = new DisposableSearcher(this);
		_reopener = new ReaderReopener(this);
		LuceneIndexFolder = new DirectoryInfo(Path.Combine(workingFolder.FullName, "Index"));
		InitializeDirectory();
	}

	[SecuritySafeCritical]
	public LuceneSearcher(Directory luceneDirectory, Analyzer analyzer)
		: base(analyzer)
	{
		_disposer = new DisposableSearcher(this);
		_reopener = new ReaderReopener(this);
		LuceneIndexFolder = null;
		_directory = luceneDirectory;
	}

	[SecuritySafeCritical]
	private void InitializeDirectory()
	{
		if (_directory == null)
		{
			_directory = DirectoryTracker.Current.GetDirectory(LuceneIndexFolder, throwIfEmpty: true);
		}
	}

	[SecuritySafeCritical]
	public override void Initialize(string name, NameValueCollection config)
	{
		base.Initialize(name, config);
		if (config["indexSet"] == null && LuceneIndexFolder == null && _directory == null)
		{
			bool flag = false;
			if (name.EndsWith("Searcher"))
			{
				string setNameByConvension = name.Remove(name.LastIndexOf("Searcher")) + "IndexSet";
				IndexSet indexSet = ((IEnumerable)(object)IndexSets.Instance.Sets).Cast<IndexSet>().SingleOrDefault((IndexSet x) => x.SetName == setNameByConvension);
				if (indexSet != null)
				{
					indexSet.ReplaceTokensInIndexPath();
					IndexSetName = indexSet.SetName;
					flag = true;
				}
			}
			if (!flag)
			{
				throw new ArgumentNullException("indexSet on LuceneExamineIndexer provider has not been set in configuration");
			}
			LuceneIndexFolder = new DirectoryInfo(Path.Combine(IndexSets.Instance.Sets[IndexSetName].IndexDirectory.FullName, "Index"));
		}
		else if (config["indexSet"] != null && _directory == null)
		{
			if (IndexSets.Instance.Sets[config["indexSet"]] == null)
			{
				throw new ArgumentException("The indexSet specified for the LuceneExamineIndexer provider does not exist");
			}
			IndexSetName = config["indexSet"];
			IndexSet indexSet2 = IndexSets.Instance.Sets[IndexSetName];
			indexSet2.ReplaceTokensInIndexPath();
			LuceneIndexFolder = new DirectoryInfo(Path.Combine(indexSet2.IndexDirectory.FullName, "Index"));
		}
		InitializeDirectory();
	}

	[Obsolete("This is not used and performs no operation, if no index directory exists for the searcher the searcher should just return empty results", true)]
	[SecuritySafeCritical]
	public virtual void EnsureIndex()
	{
	}

	[SecuritySafeCritical]
	public override Searcher GetSearcher()
	{
		if (!ValidateSearcher())
		{
			return null;
		}
		_searcher.SetDefaultFieldSortScoring(true, true);
		return (Searcher)(object)_searcher;
	}

	[SecuritySafeCritical]
	protected internal override string[] GetSearchFields()
	{
		if (!ValidateSearcher())
		{
			return new string[0];
		}
		return (from x in _reader.GetFieldNames(FieldOption.ALL)
			where !x.StartsWith("__")
			select x).ToArray();
	}

	[SecuritySafeCritical]
	protected virtual Directory GetLuceneDirectory()
	{
		if (_nrtWriter != null)
		{
			return _nrtWriter.GetDirectory();
		}
		return _directory;
	}

	[SecuritySafeCritical]
	protected virtual IndexReader OpenNewReader()
	{
		if (TryEstablishNrtReader())
		{
			_nrtWriter.GetReader();
		}
		return IndexReader.Open(GetLuceneDirectory(), true);
	}

	[SecuritySafeCritical]
	private bool TryEstablishNrtReader()
	{
		if (_nrtWriter == null)
		{
			_nrtWriter = WriterTracker.Current.GetWriter(GetLuceneDirectory());
		}
		return _nrtWriter != null;
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

	[SecuritySafeCritical]
	private bool ValidateSearcher()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		if (!IndexExistsImpl())
		{
			return false;
		}
		if (_reader == null)
		{
			lock (_locker)
			{
				if (_reader == null)
				{
					try
					{
						_reader = ((_nrtWriter == null) ? OpenNewReader() : _nrtWriter.GetReader());
						_searcher = new IndexSearcher(_reader);
						OpenReaderTracker.Current.AddOpenReader(_reader);
					}
					catch (IOException innerException)
					{
						throw new ApplicationException("Could not create an index searcher with the supplied lucene directory", innerException);
					}
				}
			}
		}
		else
		{
			_reopener.ScheduleReopen();
		}
		return true;
	}

	public void Dispose()
	{
		_disposer.Dispose();
	}
}
