#define TRACE
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Transactions;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class SQLiteConnection : DbConnection, IDisposable, ICloneable
{
	internal const DbType BadDbType = (DbType)(-1);

	internal const string DefaultBaseSchemaName = "sqlite_default_schema";

	private const string MemoryFileName = ":memory:";

	internal const IsolationLevel DeferredIsolationLevel = IsolationLevel.ReadCommitted;

	internal const IsolationLevel ImmediateIsolationLevel = IsolationLevel.Serializable;

	private const SQLiteConnectionFlags FallbackDefaultFlags = SQLiteConnectionFlags.Default;

	private const SQLiteSynchronousEnum DefaultSynchronous = SQLiteSynchronousEnum.Default;

	private const SQLiteJournalModeEnum DefaultJournalMode = SQLiteJournalModeEnum.Default;

	private const IsolationLevel DefaultIsolationLevel = IsolationLevel.Serializable;

	internal const SQLiteDateFormats DefaultDateTimeFormat = SQLiteDateFormats.ISO8601;

	internal const DateTimeKind DefaultDateTimeKind = DateTimeKind.Unspecified;

	internal const string DefaultDateTimeFormatString = null;

	private const string DefaultDataSource = null;

	private const string DefaultUri = null;

	private const string DefaultFullUri = null;

	private const string DefaultHexPassword = null;

	private const string DefaultPassword = null;

	private const int DefaultVersion = 3;

	private const int DefaultPageSize = 4096;

	private const int DefaultMaxPageCount = 0;

	private const int DefaultCacheSize = -2000;

	private const int DefaultMaxPoolSize = 100;

	private const int DefaultConnectionTimeout = 30;

	private const int DefaultBusyTimeout = 0;

	private const bool DefaultNoDefaultFlags = false;

	private const bool DefaultNoSharedFlags = false;

	private const bool DefaultFailIfMissing = false;

	private const bool DefaultReadOnly = false;

	internal const bool DefaultBinaryGUID = true;

	private const bool DefaultUseUTF16Encoding = false;

	private const bool DefaultToFullPath = true;

	private const bool DefaultPooling = false;

	private const bool DefaultLegacyFormat = false;

	private const bool DefaultForeignKeys = false;

	private const bool DefaultRecursiveTriggers = false;

	private const bool DefaultEnlist = true;

	private const bool DefaultSetDefaults = true;

	internal const int DefaultPrepareRetries = 3;

	private const string DefaultVfsName = null;

	private const int DefaultProgressOps = 0;

	private const int SQLITE_FCNTL_CHUNK_SIZE = 6;

	private const int SQLITE_FCNTL_WIN32_AV_RETRY = 9;

	private const string _dataDirectory = "|DataDirectory|";

	private const string _masterdb = "sqlite_master";

	private const string _tempmasterdb = "sqlite_temp_master";

	private static readonly Assembly _assembly;

	private static readonly object _syncRoot;

	private static SQLiteConnectionFlags _sharedFlags;

	[ThreadStatic]
	private static SQLiteConnection _lastConnectionInOpen;

	private ConnectionState _connectionState;

	private string _connectionString;

	internal int _transactionLevel;

	internal int _transactionSequence;

	internal bool _noDispose;

	private bool _disposing;

	private IsolationLevel _defaultIsolation;

	internal SQLiteEnlistment _enlistment;

	internal SQLiteDbTypeMap _typeNames;

	private SQLiteTypeCallbacksMap _typeCallbacks;

	internal SQLiteBase _sql;

	private string _dataSource;

	private byte[] _password;

	internal string _baseSchemaName;

	private SQLiteConnectionFlags _flags;

	private Dictionary<string, object> _cachedSettings;

	private DbType? _defaultDbType;

	private string _defaultTypeName;

	private string _vfsName;

	private int _defaultTimeout = 30;

	private int _busyTimeout;

	internal int _prepareRetries = 3;

	private int _progressOps;

	private bool _parseViaFramework;

	internal bool _binaryGuid;

	internal int _version;

	private SQLiteProgressCallback _progressCallback;

	private SQLiteAuthorizerCallback _authorizerCallback;

	private SQLiteUpdateCallback _updateCallback;

	private SQLiteCommitCallback _commitCallback;

	private SQLiteTraceCallback _traceCallback;

	private SQLiteRollbackCallback _rollbackCallback;

	private bool disposed;

	[NonSerialized]
	internal static GetString _0015;

	public static ISQLiteConnectionPool ConnectionPool
	{
		get
		{
			return SQLiteConnectionPool.GetConnectionPool();
		}
		set
		{
			SQLiteConnectionPool.SetConnectionPool(value);
		}
	}

	public int PoolCount
	{
		get
		{
			if (_sql == null)
			{
				return 0;
			}
			return _sql.CountPool();
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue("")]
	[Editor("SQLite.Designer.SQLiteConnectionStringEditor, SQLite.Designer, Version=1.0.105.2, Culture=neutral, PublicKeyToken=db937bc2d44ff139", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public override string ConnectionString
	{
		get
		{
			CheckDisposed();
			return _connectionString;
		}
		set
		{
			CheckDisposed();
			if (value == null)
			{
				throw new ArgumentNullException();
			}
			if (_connectionState != 0)
			{
				throw new InvalidOperationException();
			}
			_connectionString = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override string DataSource
	{
		get
		{
			CheckDisposed();
			return _dataSource;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public string FileName
	{
		get
		{
			CheckDisposed();
			if (_sql == null)
			{
				throw new InvalidOperationException(_0015(107361322));
			}
			return _sql.GetFileName(_0015(107362684));
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override string Database
	{
		get
		{
			CheckDisposed();
			return _0015(107362684);
		}
	}

	public int DefaultTimeout
	{
		get
		{
			CheckDisposed();
			return _defaultTimeout;
		}
		set
		{
			CheckDisposed();
			_defaultTimeout = value;
		}
	}

	public int BusyTimeout
	{
		get
		{
			CheckDisposed();
			return _busyTimeout;
		}
		set
		{
			CheckDisposed();
			_busyTimeout = value;
		}
	}

	public int PrepareRetries
	{
		get
		{
			CheckDisposed();
			return _prepareRetries;
		}
		set
		{
			CheckDisposed();
			_prepareRetries = value;
		}
	}

	public int ProgressOps
	{
		get
		{
			CheckDisposed();
			return _progressOps;
		}
		set
		{
			CheckDisposed();
			_progressOps = value;
		}
	}

	public bool ParseViaFramework
	{
		get
		{
			CheckDisposed();
			return _parseViaFramework;
		}
		set
		{
			CheckDisposed();
			_parseViaFramework = value;
		}
	}

	public SQLiteConnectionFlags Flags
	{
		get
		{
			CheckDisposed();
			return _flags;
		}
		set
		{
			CheckDisposed();
			_flags = value;
		}
	}

	public DbType? DefaultDbType
	{
		get
		{
			CheckDisposed();
			return _defaultDbType;
		}
		set
		{
			CheckDisposed();
			_defaultDbType = value;
		}
	}

	public string DefaultTypeName
	{
		get
		{
			CheckDisposed();
			return _defaultTypeName;
		}
		set
		{
			CheckDisposed();
			_defaultTypeName = value;
		}
	}

	public string VfsName
	{
		get
		{
			CheckDisposed();
			return _vfsName;
		}
		set
		{
			CheckDisposed();
			_vfsName = value;
		}
	}

	public bool OwnHandle
	{
		get
		{
			CheckDisposed();
			if (_sql == null)
			{
				throw new InvalidOperationException(_0015(107358442));
			}
			return _sql.OwnHandle;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override string ServerVersion
	{
		get
		{
			CheckDisposed();
			return SQLiteVersion;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public long LastInsertRowId
	{
		get
		{
			CheckDisposed();
			if (_sql == null)
			{
				throw new InvalidOperationException(_0015(107358373));
			}
			return _sql.LastInsertRowId;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int Changes
	{
		get
		{
			CheckDisposed();
			if (_sql == null)
			{
				throw new InvalidOperationException(_0015(107358731));
			}
			return _sql.Changes;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool AutoCommit
	{
		get
		{
			CheckDisposed();
			if (_sql == null)
			{
				throw new InvalidOperationException(_0015(107358569));
			}
			return _sql.AutoCommit;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public long MemoryUsed
	{
		get
		{
			CheckDisposed();
			if (_sql == null)
			{
				throw new InvalidOperationException(_0015(107358520));
			}
			return _sql.MemoryUsed;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public long MemoryHighwater
	{
		get
		{
			CheckDisposed();
			if (_sql == null)
			{
				throw new InvalidOperationException(_0015(107357935));
			}
			return _sql.MemoryHighwater;
		}
	}

	public static string DefineConstants => SQLite3.DefineConstants;

	public static string SQLiteVersion => SQLite3.SQLiteVersion;

	public static string SQLiteSourceId => SQLite3.SQLiteSourceId;

	public static string SQLiteCompileOptions => SQLite3.SQLiteCompileOptions;

	public static string InteropVersion => SQLite3.InteropVersion;

	public static string InteropSourceId => SQLite3.InteropSourceId;

	public static string InteropCompileOptions => SQLite3.InteropCompileOptions;

	public static string ProviderVersion
	{
		get
		{
			if ((object)_assembly == null)
			{
				return null;
			}
			return _assembly.GetName().Version!.ToString();
		}
	}

	public static string ProviderSourceId
	{
		get
		{
			if ((object)_assembly == null)
			{
				return null;
			}
			string text = null;
			if (_assembly.IsDefined(typeof(AssemblySourceIdAttribute), inherit: false))
			{
				AssemblySourceIdAttribute assemblySourceIdAttribute = (AssemblySourceIdAttribute)_assembly.GetCustomAttributes(typeof(AssemblySourceIdAttribute), inherit: false)[0];
				text = assemblySourceIdAttribute.SourceId;
			}
			string text2 = null;
			if (_assembly.IsDefined(typeof(AssemblySourceTimeStampAttribute), inherit: false))
			{
				AssemblySourceTimeStampAttribute assemblySourceTimeStampAttribute = (AssemblySourceTimeStampAttribute)_assembly.GetCustomAttributes(typeof(AssemblySourceTimeStampAttribute), inherit: false)[0];
				text2 = assemblySourceTimeStampAttribute.SourceTimeStamp;
			}
			if (text != null || text2 != null)
			{
				if (text == null)
				{
					text = _0015(107358174);
				}
				if (text2 == null)
				{
					text2 = _0015(107358117);
				}
				return HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107399257), text, text2);
			}
			return null;
		}
	}

	public static SQLiteConnectionFlags DefaultFlags
	{
		get
		{
			string name = _0015(107358084);
			if (!TryGetLastCachedSetting(name, null, out var value))
			{
				value = UnsafeNativeMethods.GetSettingValue(name, null);
				SetLastCachedSetting(name, value);
			}
			if (value == null)
			{
				return SQLiteConnectionFlags.Default;
			}
			object obj = TryParseEnum(typeof(SQLiteConnectionFlags), value.ToString(), ignoreCase: true);
			if (obj is SQLiteConnectionFlags)
			{
				return (SQLiteConnectionFlags)obj;
			}
			return SQLiteConnectionFlags.Default;
		}
	}

	public static SQLiteConnectionFlags SharedFlags
	{
		get
		{
			lock (_syncRoot)
			{
				return _sharedFlags;
			}
		}
		set
		{
			lock (_syncRoot)
			{
				_sharedFlags = value;
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override ConnectionState State
	{
		get
		{
			CheckDisposed();
			return _connectionState;
		}
	}

	protected override DbProviderFactory DbProviderFactory => SQLiteFactory.Instance;

	private static event SQLiteConnectionEventHandler _handlers;

	private event SQLiteProgressEventHandler _progressHandler;

	private event SQLiteAuthorizerEventHandler _authorizerHandler;

	private event SQLiteUpdateEventHandler _updateHandler;

	private event SQLiteCommitHandler _commitHandler;

	private event SQLiteTraceEventHandler _traceHandler;

	private event EventHandler _rollbackHandler;

	public override event StateChangeEventHandler StateChange;

	public static event SQLiteConnectionEventHandler Changed
	{
		add
		{
			lock (_syncRoot)
			{
				SQLiteConnection._handlers = (SQLiteConnectionEventHandler)Delegate.Remove(SQLiteConnection._handlers, value);
				SQLiteConnection._handlers = (SQLiteConnectionEventHandler)Delegate.Combine(SQLiteConnection._handlers, value);
			}
		}
		remove
		{
			lock (_syncRoot)
			{
				SQLiteConnection._handlers = (SQLiteConnectionEventHandler)Delegate.Remove(SQLiteConnection._handlers, value);
			}
		}
	}

	public event SQLiteProgressEventHandler Progress
	{
		add
		{
			CheckDisposed();
			if (this._progressHandler == null)
			{
				_progressCallback = ProgressCallback;
				if (_sql != null)
				{
					_sql.SetProgressHook(_progressOps, _progressCallback);
				}
			}
			this._progressHandler = (SQLiteProgressEventHandler)Delegate.Combine(this._progressHandler, value);
		}
		remove
		{
			CheckDisposed();
			this._progressHandler = (SQLiteProgressEventHandler)Delegate.Remove(this._progressHandler, value);
			if (this._progressHandler == null)
			{
				if (_sql != null)
				{
					_sql.SetProgressHook(0, null);
				}
				_progressCallback = null;
			}
		}
	}

	public event SQLiteAuthorizerEventHandler Authorize
	{
		add
		{
			CheckDisposed();
			if (this._authorizerHandler == null)
			{
				_authorizerCallback = AuthorizerCallback;
				if (_sql != null)
				{
					_sql.SetAuthorizerHook(_authorizerCallback);
				}
			}
			this._authorizerHandler = (SQLiteAuthorizerEventHandler)Delegate.Combine(this._authorizerHandler, value);
		}
		remove
		{
			CheckDisposed();
			this._authorizerHandler = (SQLiteAuthorizerEventHandler)Delegate.Remove(this._authorizerHandler, value);
			if (this._authorizerHandler == null)
			{
				if (_sql != null)
				{
					_sql.SetAuthorizerHook(null);
				}
				_authorizerCallback = null;
			}
		}
	}

	public event SQLiteUpdateEventHandler Update
	{
		add
		{
			CheckDisposed();
			if (this._updateHandler == null)
			{
				_updateCallback = UpdateCallback;
				if (_sql != null)
				{
					_sql.SetUpdateHook(_updateCallback);
				}
			}
			this._updateHandler = (SQLiteUpdateEventHandler)Delegate.Combine(this._updateHandler, value);
		}
		remove
		{
			CheckDisposed();
			this._updateHandler = (SQLiteUpdateEventHandler)Delegate.Remove(this._updateHandler, value);
			if (this._updateHandler == null)
			{
				if (_sql != null)
				{
					_sql.SetUpdateHook(null);
				}
				_updateCallback = null;
			}
		}
	}

	public event SQLiteCommitHandler Commit
	{
		add
		{
			CheckDisposed();
			if (this._commitHandler == null)
			{
				_commitCallback = CommitCallback;
				if (_sql != null)
				{
					_sql.SetCommitHook(_commitCallback);
				}
			}
			this._commitHandler = (SQLiteCommitHandler)Delegate.Combine(this._commitHandler, value);
		}
		remove
		{
			CheckDisposed();
			this._commitHandler = (SQLiteCommitHandler)Delegate.Remove(this._commitHandler, value);
			if (this._commitHandler == null)
			{
				if (_sql != null)
				{
					_sql.SetCommitHook(null);
				}
				_commitCallback = null;
			}
		}
	}

	public event SQLiteTraceEventHandler Trace
	{
		add
		{
			CheckDisposed();
			if (this._traceHandler == null)
			{
				_traceCallback = TraceCallback;
				if (_sql != null)
				{
					_sql.SetTraceCallback(_traceCallback);
				}
			}
			this._traceHandler = (SQLiteTraceEventHandler)Delegate.Combine(this._traceHandler, value);
		}
		remove
		{
			CheckDisposed();
			this._traceHandler = (SQLiteTraceEventHandler)Delegate.Remove(this._traceHandler, value);
			if (this._traceHandler == null)
			{
				if (_sql != null)
				{
					_sql.SetTraceCallback(null);
				}
				_traceCallback = null;
			}
		}
	}

	public event EventHandler RollBack
	{
		add
		{
			CheckDisposed();
			if (this._rollbackHandler == null)
			{
				_rollbackCallback = RollbackCallback;
				if (_sql != null)
				{
					_sql.SetRollbackHook(_rollbackCallback);
				}
			}
			this._rollbackHandler = (EventHandler)Delegate.Combine(this._rollbackHandler, value);
		}
		remove
		{
			CheckDisposed();
			this._rollbackHandler = (EventHandler)Delegate.Remove(this._rollbackHandler, value);
			if (this._rollbackHandler == null)
			{
				if (_sql != null)
				{
					_sql.SetRollbackHook(null);
				}
				_rollbackCallback = null;
			}
		}
	}

	public SQLiteConnection()
		: this((string)null)
	{
	}

	public SQLiteConnection(string connectionString)
		: this(connectionString, parseViaFramework: false)
	{
	}

	internal SQLiteConnection(IntPtr db, string fileName, bool ownHandle)
		: this()
	{
		_sql = new SQLite3(SQLiteDateFormats.ISO8601, DateTimeKind.Unspecified, null, db, fileName, ownHandle);
		_flags = SQLiteConnectionFlags.None;
		_connectionState = ((db != IntPtr.Zero) ? ConnectionState.Open : ConnectionState.Closed);
		_connectionString = null;
	}

	public SQLiteConnection(string connectionString, bool parseViaFramework)
	{
		_noDispose = false;
		UnsafeNativeMethods.Initialize();
		SQLiteLog.Initialize();
		_cachedSettings = new Dictionary<string, object>(new TypeNameStringComparer());
		_typeNames = new SQLiteDbTypeMap();
		_typeCallbacks = new SQLiteTypeCallbacksMap();
		_parseViaFramework = parseViaFramework;
		_flags = SQLiteConnectionFlags.None;
		_defaultDbType = null;
		_defaultTypeName = null;
		_vfsName = null;
		_connectionState = ConnectionState.Closed;
		_connectionString = null;
		if (connectionString != null)
		{
			ConnectionString = connectionString;
		}
	}

	public SQLiteConnection(SQLiteConnection connection)
		: this(connection.ConnectionString, connection.ParseViaFramework)
	{
		if (connection.State != ConnectionState.Open)
		{
			return;
		}
		Open();
		using DataTable dataTable = connection.GetSchema(_0015(107362665));
		foreach (DataRow row in dataTable.Rows)
		{
			string strA = row[0].ToString();
			if (string.Compare(strA, _0015(107362684), StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(strA, _0015(107362675), StringComparison.OrdinalIgnoreCase) != 0)
			{
				using SQLiteCommand sQLiteCommand = CreateCommand();
				sQLiteCommand.CommandText = HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107362634), row[1], row[0]);
				sQLiteCommand.ExecuteNonQuery();
			}
		}
	}

	internal static void OnChanged(SQLiteConnection connection, ConnectionEventArgs e)
	{
		if (connection == null || connection.CanRaiseEvents)
		{
			SQLiteConnectionEventHandler sQLiteConnectionEventHandler;
			lock (_syncRoot)
			{
				sQLiteConnectionEventHandler = ((SQLiteConnection._handlers == null) ? null : (SQLiteConnection._handlers.Clone() as SQLiteConnectionEventHandler));
			}
			sQLiteConnectionEventHandler?.Invoke(connection, e);
		}
	}

	public static object CreateHandle(IntPtr nativeHandle)
	{
		SQLiteConnectionHandle sQLiteConnectionHandle;
		try
		{
		}
		finally
		{
			sQLiteConnectionHandle = ((nativeHandle != IntPtr.Zero) ? new SQLiteConnectionHandle(nativeHandle, ownHandle: true) : null);
		}
		if (sQLiteConnectionHandle != null)
		{
			OnChanged(null, new ConnectionEventArgs(SQLiteConnectionEventType.NewCriticalHandle, null, null, null, null, sQLiteConnectionHandle, null, new object[2]
			{
				typeof(SQLiteConnection),
				nativeHandle
			}));
		}
		return sQLiteConnectionHandle;
	}

	public void BackupDatabase(SQLiteConnection destination, string destinationName, string sourceName, int pages, SQLiteBackupCallback callback, int retryMilliseconds)
	{
		CheckDisposed();
		if (_connectionState != ConnectionState.Open)
		{
			throw new InvalidOperationException(_0015(107362593));
		}
		if (destination == null)
		{
			throw new ArgumentNullException(_0015(107362072));
		}
		if (destination._connectionState != ConnectionState.Open)
		{
			throw new ArgumentException(_0015(107362023), _0015(107362072));
		}
		if (destinationName == null)
		{
			throw new ArgumentNullException(_0015(107362010));
		}
		if (sourceName == null)
		{
			throw new ArgumentNullException(_0015(107363445));
		}
		SQLiteBase sql = _sql;
		if (sql == null)
		{
			throw new InvalidOperationException(_0015(107361957));
		}
		SQLiteBackup sQLiteBackup = null;
		try
		{
			sQLiteBackup = sql.InitializeBackup(destination, destinationName, sourceName);
			bool retry = false;
			while (sql.StepBackup(sQLiteBackup, pages, ref retry) && (callback == null || callback(this, sourceName, destination, destinationName, pages, sql.RemainingBackup(sQLiteBackup), sql.PageCountBackup(sQLiteBackup), retry)))
			{
				if (retry && retryMilliseconds >= 0)
				{
					Thread.Sleep(retryMilliseconds);
				}
				if (pages == 0)
				{
					break;
				}
			}
		}
		catch (Exception ex)
		{
			if ((_flags & SQLiteConnectionFlags.LogBackup) == SQLiteConnectionFlags.LogBackup)
			{
				SQLiteLog.LogMessage(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107361900), ex));
			}
			throw;
		}
		finally
		{
			if (sQLiteBackup != null)
			{
				sql.FinishBackup(sQLiteBackup);
			}
		}
	}

	public int ClearCachedSettings()
	{
		CheckDisposed();
		int result = -1;
		if (_cachedSettings != null)
		{
			result = _cachedSettings.Count;
			_cachedSettings.Clear();
		}
		return result;
	}

	internal bool TryGetCachedSetting(string name, object @default, out object value)
	{
		if (name == null || _cachedSettings == null)
		{
			value = @default;
			return false;
		}
		return _cachedSettings.TryGetValue(name, out value);
	}

	internal void SetCachedSetting(string name, object value)
	{
		if (name != null && _cachedSettings != null)
		{
			_cachedSettings[name] = value;
		}
	}

	public int ClearTypeMappings()
	{
		CheckDisposed();
		int result = -1;
		if (_typeNames != null)
		{
			result = _typeNames.Clear();
		}
		return result;
	}

	public Dictionary<string, object> GetTypeMappings()
	{
		CheckDisposed();
		Dictionary<string, object> result = null;
		if (_typeNames != null)
		{
			result = new Dictionary<string, object>(_typeNames.Count, _typeNames.Comparer);
			{
				foreach (KeyValuePair<string, SQLiteDbTypeMapping> typeName in _typeNames)
				{
					SQLiteDbTypeMapping value = typeName.Value;
					object obj = null;
					object obj2 = null;
					object obj3 = null;
					if (value != null)
					{
						obj = value.typeName;
						obj2 = value.dataType;
						obj3 = value.primary;
					}
					result.Add(typeName.Key, new object[3] { obj, obj2, obj3 });
				}
				return result;
			}
		}
		return result;
	}

	public int AddTypeMapping(string typeName, DbType dataType, bool primary)
	{
		CheckDisposed();
		if (typeName == null)
		{
			throw new ArgumentNullException(_0015(107361835));
		}
		int num = -1;
		if (_typeNames != null)
		{
			num = 0;
			if (primary && _typeNames.ContainsKey(dataType))
			{
				num += (_typeNames.Remove(dataType) ? 1 : 0);
			}
			if (_typeNames.ContainsKey(typeName))
			{
				num += (_typeNames.Remove(typeName) ? 1 : 0);
			}
			_typeNames.Add(new SQLiteDbTypeMapping(typeName, dataType, primary));
		}
		return num;
	}

	public int ClearTypeCallbacks()
	{
		CheckDisposed();
		int result = -1;
		if (_typeCallbacks != null)
		{
			result = _typeCallbacks.Count;
			_typeCallbacks.Clear();
		}
		return result;
	}

	public bool TryGetTypeCallbacks(string typeName, out SQLiteTypeCallbacks callbacks)
	{
		CheckDisposed();
		if (typeName == null)
		{
			throw new ArgumentNullException(_0015(107361835));
		}
		if (_typeCallbacks == null)
		{
			callbacks = null;
			return false;
		}
		return _typeCallbacks.TryGetValue(typeName, out callbacks);
	}

	public bool SetTypeCallbacks(string typeName, SQLiteTypeCallbacks callbacks)
	{
		CheckDisposed();
		if (typeName == null)
		{
			throw new ArgumentNullException(_0015(107361835));
		}
		if (_typeCallbacks == null)
		{
			return false;
		}
		if (callbacks == null)
		{
			return _typeCallbacks.Remove(typeName);
		}
		callbacks.TypeName = typeName;
		_typeCallbacks[typeName] = callbacks;
		return true;
	}

	public void BindFunction(SQLiteFunctionAttribute functionAttribute, SQLiteFunction function)
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(_0015(107361822));
		}
		_sql.BindFunction(functionAttribute, function, _flags);
	}

	public void BindFunction(SQLiteFunctionAttribute functionAttribute, Delegate callback1, Delegate callback2)
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(_0015(107361822));
		}
		_sql.BindFunction(functionAttribute, new SQLiteDelegateFunction(callback1, callback2), _flags);
	}

	public bool UnbindFunction(SQLiteFunctionAttribute functionAttribute)
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(_0015(107362293));
		}
		return _sql.UnbindFunction(functionAttribute, _flags);
	}

	public bool UnbindAllFunctions(bool registered)
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(_0015(107362293));
		}
		return SQLiteFunction.UnbindAllFunctions(_sql, _flags, registered);
	}

	[Conditional("CHECK_STATE")]
	internal static void Check(SQLiteConnection connection)
	{
		if (connection == null)
		{
			throw new ArgumentNullException(_0015(107362188));
		}
		connection.CheckDisposed();
		if (connection._connectionState != ConnectionState.Open)
		{
			throw new InvalidOperationException(_0015(107362203));
		}
		if (!(connection._sql is SQLite3 sQLite))
		{
			throw new InvalidOperationException(_0015(107362166));
		}
		SQLiteConnectionHandle sql = sQLite._sql;
		if (sql == null)
		{
			throw new InvalidOperationException(_0015(107362081));
		}
		if (sql.IsInvalid)
		{
			throw new InvalidOperationException(_0015(107365541));
		}
		if (sql.IsClosed)
		{
			throw new InvalidOperationException(_0015(107365528));
		}
	}

	internal static SortedList<string, string> ParseConnectionString(string connectionString, bool parseViaFramework, bool allowNameOnly)
	{
		return ParseConnectionString(null, connectionString, parseViaFramework, allowNameOnly);
	}

	private static SortedList<string, string> ParseConnectionString(SQLiteConnection connection, string connectionString, bool parseViaFramework, bool allowNameOnly)
	{
		if (!parseViaFramework)
		{
			return ParseConnectionString(connection, connectionString, allowNameOnly);
		}
		return ParseConnectionStringViaFramework(connection, connectionString, strict: false);
	}

	private void SetupSQLiteBase(SortedList<string, string> opts)
	{
		object obj = TryParseEnum(typeof(SQLiteDateFormats), FindKey(opts, _0015(107361560), SQLiteDateFormats.ISO8601.ToString()), ignoreCase: true);
		SQLiteDateFormats fmt = ((!(obj is SQLiteDateFormats)) ? SQLiteDateFormats.ISO8601 : ((SQLiteDateFormats)obj));
		obj = TryParseEnum(typeof(DateTimeKind), FindKey(opts, _0015(107361507), DateTimeKind.Unspecified.ToString()), ignoreCase: true);
		DateTimeKind kind = ((obj is DateTimeKind) ? ((DateTimeKind)obj) : DateTimeKind.Unspecified);
		string fmtString = FindKey(opts, _0015(107361522), null);
		if (SQLiteConvert.ToBoolean(FindKey(opts, _0015(107361493), false.ToString())))
		{
			_sql = new SQLite3_UTF16(fmt, kind, fmtString, IntPtr.Zero, null, ownHandle: false);
		}
		else
		{
			_sql = new SQLite3(fmt, kind, fmtString, IntPtr.Zero, null, ownHandle: false);
		}
	}

	public new void Dispose()
	{
		if (!_noDispose)
		{
			base.Dispose();
		}
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteConnection).Name);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if ((_flags & SQLiteConnectionFlags.TraceWarning) == SQLiteConnectionFlags.TraceWarning && _noDispose)
		{
			System.Diagnostics.Trace.WriteLine(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107361468), _connectionString));
		}
		_disposing = true;
		try
		{
			if (!disposed)
			{
				Close();
			}
		}
		finally
		{
			base.Dispose(disposing);
			disposed = true;
		}
	}

	public object Clone()
	{
		CheckDisposed();
		return new SQLiteConnection(this);
	}

	public static void CreateFile(string databaseFileName)
	{
		FileStream fileStream = File.Create(databaseFileName);
		fileStream.Close();
	}

	internal void OnStateChange(ConnectionState newState, ref StateChangeEventArgs eventArgs)
	{
		ConnectionState connectionState = _connectionState;
		_connectionState = newState;
		if (StateChange != null && newState != connectionState)
		{
			StateChangeEventArgs stateChangeEventArgs = new StateChangeEventArgs(connectionState, newState);
			StateChange(this, stateChangeEventArgs);
			eventArgs = stateChangeEventArgs;
		}
	}

	private static IsolationLevel GetFallbackDefaultIsolationLevel()
	{
		return IsolationLevel.Serializable;
	}

	internal IsolationLevel GetDefaultIsolationLevel()
	{
		return _defaultIsolation;
	}

	[Obsolete("Use one of the standard BeginTransaction methods, this one will be removed soon")]
	public SQLiteTransaction BeginTransaction(IsolationLevel isolationLevel, bool deferredLock)
	{
		CheckDisposed();
		return (SQLiteTransaction)BeginDbTransaction((!deferredLock) ? IsolationLevel.Serializable : IsolationLevel.ReadCommitted);
	}

	[Obsolete("Use one of the standard BeginTransaction methods, this one will be removed soon")]
	public SQLiteTransaction BeginTransaction(bool deferredLock)
	{
		CheckDisposed();
		return (SQLiteTransaction)BeginDbTransaction((!deferredLock) ? IsolationLevel.Serializable : IsolationLevel.ReadCommitted);
	}

	public new SQLiteTransaction BeginTransaction(IsolationLevel isolationLevel)
	{
		CheckDisposed();
		return (SQLiteTransaction)BeginDbTransaction(isolationLevel);
	}

	public new SQLiteTransaction BeginTransaction()
	{
		CheckDisposed();
		return (SQLiteTransaction)BeginDbTransaction(_defaultIsolation);
	}

	protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
	{
		if (_connectionState != ConnectionState.Open)
		{
			throw new InvalidOperationException();
		}
		if (isolationLevel == IsolationLevel.Unspecified)
		{
			isolationLevel = _defaultIsolation;
		}
		isolationLevel = GetEffectiveIsolationLevel(isolationLevel);
		if (isolationLevel != IsolationLevel.Serializable && isolationLevel != IsolationLevel.ReadCommitted)
		{
			throw new ArgumentException(_0015(107361343));
		}
		SQLiteTransaction sQLiteTransaction = (((_flags & SQLiteConnectionFlags.AllowNestedTransactions) != SQLiteConnectionFlags.AllowNestedTransactions) ? new SQLiteTransaction(this, isolationLevel != IsolationLevel.Serializable) : new SQLiteTransaction2(this, isolationLevel != IsolationLevel.Serializable));
		OnChanged(this, new ConnectionEventArgs(SQLiteConnectionEventType.NewTransaction, null, sQLiteTransaction, null, null, null, null, null));
		return sQLiteTransaction;
	}

	public override void ChangeDatabase(string databaseName)
	{
		CheckDisposed();
		OnChanged(this, new ConnectionEventArgs(SQLiteConnectionEventType.ChangeDatabase, null, null, null, null, null, databaseName, null));
		throw new NotImplementedException();
	}

	public override void Close()
	{
		CheckDisposed();
		OnChanged(this, new ConnectionEventArgs(SQLiteConnectionEventType.Closing, null, null, null, null, null, null, null));
		if (_sql != null)
		{
			if (_enlistment != null)
			{
				SQLiteConnection sQLiteConnection = new SQLiteConnection();
				sQLiteConnection._sql = _sql;
				sQLiteConnection._transactionLevel = _transactionLevel;
				sQLiteConnection._transactionSequence = _transactionSequence;
				sQLiteConnection._enlistment = _enlistment;
				sQLiteConnection._connectionState = _connectionState;
				sQLiteConnection._version = _version;
				sQLiteConnection._enlistment._transaction._cnn = sQLiteConnection;
				sQLiteConnection._enlistment._disposeConnection = true;
				_sql = null;
				_enlistment = null;
			}
			if (_sql != null)
			{
				_sql.Close(!_disposing);
				_sql = null;
			}
			_transactionLevel = 0;
			_transactionSequence = 0;
		}
		StateChangeEventArgs eventArgs = null;
		OnStateChange(ConnectionState.Closed, ref eventArgs);
		OnChanged(this, new ConnectionEventArgs(SQLiteConnectionEventType.Closed, eventArgs, null, null, null, null, null, null));
	}

	public static void ClearPool(SQLiteConnection connection)
	{
		if (connection._sql != null)
		{
			connection._sql.ClearPool();
		}
	}

	public static void ClearAllPools()
	{
		SQLiteConnectionPool.ClearAllPools();
	}

	public new SQLiteCommand CreateCommand()
	{
		CheckDisposed();
		return new SQLiteCommand(this);
	}

	protected override DbCommand CreateDbCommand()
	{
		return CreateCommand();
	}

	internal static string MapUriPath(string path)
	{
		if (path.StartsWith(_0015(107361761), StringComparison.OrdinalIgnoreCase))
		{
			return path.Substring(7);
		}
		if (path.StartsWith(_0015(107361780), StringComparison.OrdinalIgnoreCase))
		{
			return path.Substring(5);
		}
		if (path.StartsWith(_0015(107361739), StringComparison.OrdinalIgnoreCase))
		{
			return path;
		}
		throw new InvalidOperationException(_0015(107361734));
	}

	private static bool ShouldUseLegacyConnectionStringParser(SQLiteConnection connection)
	{
		string name = _0015(107361713);
		if (connection != null && connection.TryGetCachedSetting(name, null, out var value))
		{
			return value != null;
		}
		if (connection == null && TryGetLastCachedSetting(name, null, out value))
		{
			return value != null;
		}
		value = UnsafeNativeMethods.GetSettingValue(name, null);
		if (connection != null)
		{
			connection.SetCachedSetting(name, value);
		}
		else
		{
			SetLastCachedSetting(name, value);
		}
		return value != null;
	}

	private static SortedList<string, string> ParseConnectionString(string connectionString, bool allowNameOnly)
	{
		return ParseConnectionString(null, connectionString, allowNameOnly);
	}

	private static SortedList<string, string> ParseConnectionString(SQLiteConnection connection, string connectionString, bool allowNameOnly)
	{
		SortedList<string, string> sortedList = new SortedList<string, string>(StringComparer.OrdinalIgnoreCase);
		string error = null;
		string[] array = ((!ShouldUseLegacyConnectionStringParser(connection)) ? SQLiteConvert.NewSplit(connectionString, ';', keepQuote: true, ref error) : SQLiteConvert.Split(connectionString, ';'));
		if (array == null)
		{
			throw new ArgumentException(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107361640), (error != null) ? error : _0015(107361571)));
		}
		int num = ((array != null) ? array.Length : 0);
		for (int i = 0; i < num; i++)
		{
			if (array[i] == null)
			{
				continue;
			}
			array[i] = array[i].Trim();
			if (array[i].Length == 0)
			{
				continue;
			}
			int num2 = array[i].IndexOf('=');
			if (num2 != -1)
			{
				sortedList.Add(UnwrapString(array[i].Substring(0, num2).Trim()), UnwrapString(array[i].Substring(num2 + 1).Trim()));
				continue;
			}
			if (allowNameOnly)
			{
				sortedList.Add(UnwrapString(array[i].Trim()), string.Empty);
				continue;
			}
			throw new ArgumentException(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107360990), array[i]));
		}
		return sortedList;
	}

	private static SortedList<string, string> ParseConnectionStringViaFramework(SQLiteConnection connection, string connectionString, bool strict)
	{
		DbConnectionStringBuilder dbConnectionStringBuilder = new DbConnectionStringBuilder();
		dbConnectionStringBuilder.ConnectionString = connectionString;
		SortedList<string, string> sortedList = new SortedList<string, string>(StringComparer.OrdinalIgnoreCase);
		foreach (string key in dbConnectionStringBuilder.Keys)
		{
			object obj = dbConnectionStringBuilder[key];
			string value = null;
			if (obj is string)
			{
				value = (string)obj;
			}
			else
			{
				if (strict)
				{
					throw new ArgumentException(_0015(107360897), key);
				}
				if (obj != null)
				{
					value = obj.ToString();
				}
			}
			sortedList.Add(key, value);
		}
		return sortedList;
	}

	public override void EnlistTransaction(Transaction transaction)
	{
		CheckDisposed();
		if (_enlistment == null || !(transaction == _enlistment._scope))
		{
			if (_enlistment != null)
			{
				throw new ArgumentException(_0015(107360840));
			}
			if (_transactionLevel > 0 && transaction != null)
			{
				throw new ArgumentException(_0015(107360827));
			}
			if (transaction == null)
			{
				throw new ArgumentNullException(_0015(107361214));
			}
			bool flag = (_flags & SQLiteConnectionFlags.StrictEnlistment) == SQLiteConnectionFlags.StrictEnlistment;
			_enlistment = new SQLiteEnlistment(this, transaction, GetFallbackDefaultIsolationLevel(), flag, flag);
			OnChanged(this, new ConnectionEventArgs(SQLiteConnectionEventType.EnlistTransaction, null, null, null, null, null, null, new object[1] { _enlistment }));
		}
	}

	internal static string FindKey(SortedList<string, string> items, string key, string defValue)
	{
		if (string.IsNullOrEmpty(key))
		{
			return defValue;
		}
		if (items.TryGetValue(key, out var value))
		{
			return value;
		}
		if (items.TryGetValue(key.Replace(_0015(107410615), string.Empty), out value))
		{
			return value;
		}
		if (items.TryGetValue(key.Replace(_0015(107410615), _0015(107361153)), out value))
		{
			return value;
		}
		return defValue;
	}

	internal static object TryParseEnum(Type type, string value, bool ignoreCase)
	{
		if (!string.IsNullOrEmpty(value))
		{
			try
			{
				return Enum.Parse(type, value, ignoreCase);
			}
			catch
			{
			}
		}
		return null;
	}

	private static bool TryParseByte(string value, NumberStyles style, out byte result)
	{
		return byte.TryParse(value, style, null, out result);
	}

	public void SetConfigurationOption(SQLiteConfigDbOpsEnum option, bool enable)
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107361180), enable ? _0015(107361082) : _0015(107361063)));
		}
		if (option == SQLiteConfigDbOpsEnum.SQLITE_DBCONFIG_ENABLE_LOAD_EXTENSION && (_flags & SQLiteConnectionFlags.NoLoadExtension) == SQLiteConnectionFlags.NoLoadExtension)
		{
			throw new SQLiteException(_0015(107360525));
		}
		_sql.SetConfigurationOption(option, enable);
	}

	public void EnableExtensions(bool enable)
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107360476), enable ? _0015(107361082) : _0015(107361063)));
		}
		if ((_flags & SQLiteConnectionFlags.NoLoadExtension) == SQLiteConnectionFlags.NoLoadExtension)
		{
			throw new SQLiteException(_0015(107360525));
		}
		_sql.SetLoadExtension(enable);
	}

	public void LoadExtension(string fileName)
	{
		CheckDisposed();
		LoadExtension(fileName, null);
	}

	public void LoadExtension(string fileName, string procName)
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(_0015(107360407));
		}
		if ((_flags & SQLiteConnectionFlags.NoLoadExtension) == SQLiteConnectionFlags.NoLoadExtension)
		{
			throw new SQLiteException(_0015(107360525));
		}
		_sql.LoadExtension(fileName, procName);
	}

	public void CreateModule(SQLiteModule module)
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(_0015(107360334));
		}
		if ((_flags & SQLiteConnectionFlags.NoCreateModule) == SQLiteConnectionFlags.NoCreateModule)
		{
			throw new SQLiteException(_0015(107360745));
		}
		_sql.CreateModule(module, _flags);
	}

	internal static byte[] FromHexString(string text)
	{
		string error = null;
		return FromHexString(text, ref error);
	}

	internal static string ToHexString(byte[] array)
	{
		if (array == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			stringBuilder.AppendFormat(_0015(107360696), array[i]);
		}
		return stringBuilder.ToString();
	}

	private static byte[] FromHexString(string text, ref string error)
	{
		if (text == null)
		{
			error = _0015(107360687);
			return null;
		}
		if (text.Length % 2 != 0)
		{
			error = _0015(107360666);
			return null;
		}
		byte[] array = new byte[text.Length / 2];
		for (int i = 0; i < text.Length; i += 2)
		{
			string text2 = text.Substring(i, 2);
			if (!TryParseByte(text2, NumberStyles.HexNumber, out array[i / 2]))
			{
				error = HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107360605), text2);
				return null;
			}
		}
		return array;
	}

	private bool GetDefaultPooling()
	{
		bool flag = false;
		if (flag)
		{
			if ((_flags & SQLiteConnectionFlags.NoConnectionPool) == SQLiteConnectionFlags.NoConnectionPool)
			{
				flag = false;
			}
			if ((_flags & SQLiteConnectionFlags.UseConnectionPool) == SQLiteConnectionFlags.UseConnectionPool)
			{
				flag = true;
			}
		}
		else
		{
			if ((_flags & SQLiteConnectionFlags.UseConnectionPool) == SQLiteConnectionFlags.UseConnectionPool)
			{
				flag = true;
			}
			if ((_flags & SQLiteConnectionFlags.NoConnectionPool) == SQLiteConnectionFlags.NoConnectionPool)
			{
				flag = false;
			}
		}
		return flag;
	}

	private IsolationLevel GetEffectiveIsolationLevel(IsolationLevel isolationLevel)
	{
		if ((_flags & SQLiteConnectionFlags.MapIsolationLevels) != SQLiteConnectionFlags.MapIsolationLevels)
		{
			return isolationLevel;
		}
		switch (isolationLevel)
		{
		case IsolationLevel.Unspecified:
		case IsolationLevel.Chaos:
		case IsolationLevel.ReadUncommitted:
		case IsolationLevel.ReadCommitted:
			return IsolationLevel.ReadCommitted;
		case IsolationLevel.RepeatableRead:
		case IsolationLevel.Serializable:
		case IsolationLevel.Snapshot:
			return IsolationLevel.Serializable;
		default:
			return GetFallbackDefaultIsolationLevel();
		}
	}

	public override void Open()
	{
		CheckDisposed();
		_lastConnectionInOpen = this;
		OnChanged(this, new ConnectionEventArgs(SQLiteConnectionEventType.Opening, null, null, null, null, null, null, null));
		if (_connectionState != 0)
		{
			throw new InvalidOperationException();
		}
		Close();
		SortedList<string, string> sortedList = ParseConnectionString(this, _connectionString, _parseViaFramework, allowNameOnly: false);
		OnChanged(this, new ConnectionEventArgs(SQLiteConnectionEventType.ConnectionString, null, null, null, null, null, _connectionString, new object[1] { sortedList }));
		object obj = TryParseEnum(typeof(SQLiteConnectionFlags), FindKey(sortedList, _0015(107359972), null), ignoreCase: true);
		bool flag = SQLiteConvert.ToBoolean(FindKey(sortedList, _0015(107359995), false.ToString()));
		if (obj is SQLiteConnectionFlags)
		{
			_flags |= (SQLiteConnectionFlags)obj;
		}
		else if (!flag)
		{
			_flags |= DefaultFlags;
		}
		if (!SQLiteConvert.ToBoolean(FindKey(sortedList, _0015(107359942), false.ToString())))
		{
			lock (_syncRoot)
			{
				_flags |= _sharedFlags;
			}
		}
		obj = TryParseEnum(typeof(DbType), FindKey(sortedList, _0015(107359953), null), ignoreCase: true);
		_defaultDbType = ((obj is DbType) ? new DbType?((DbType)obj) : null);
		if (_defaultDbType.HasValue && _defaultDbType.Value == (DbType)(-1))
		{
			_defaultDbType = null;
		}
		_defaultTypeName = FindKey(sortedList, _0015(107359932), null);
		_vfsName = FindKey(sortedList, _0015(107359879), null);
		bool flag2 = false;
		bool flag3 = false;
		if (Convert.ToInt32(FindKey(sortedList, _0015(107359898), SQLiteConvert.ToString(3)), CultureInfo.InvariantCulture) != 3)
		{
			throw new NotSupportedException(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107359853), 3));
		}
		string text = FindKey(sortedList, _0015(107359784), null);
		if (string.IsNullOrEmpty(text))
		{
			text = FindKey(sortedList, _0015(107359799), null);
			if (string.IsNullOrEmpty(text))
			{
				text = FindKey(sortedList, _0015(107359794), null);
				if (string.IsNullOrEmpty(text))
				{
					throw new ArgumentException(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107360261), _0015(107360168)));
				}
				flag3 = true;
			}
			else
			{
				text = MapUriPath(text);
				flag2 = true;
			}
		}
		bool flag4 = string.Compare(text, _0015(107360168), StringComparison.OrdinalIgnoreCase) == 0;
		if ((_flags & SQLiteConnectionFlags.TraceWarning) == SQLiteConnectionFlags.TraceWarning && !flag2 && !flag3 && !flag4 && !string.IsNullOrEmpty(text) && text.StartsWith(_0015(107401047), StringComparison.OrdinalIgnoreCase) && !text.StartsWith(_0015(107360187), StringComparison.OrdinalIgnoreCase))
		{
			System.Diagnostics.Trace.WriteLine(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107360182), text));
		}
		if (!flag3)
		{
			if (flag4)
			{
				text = _0015(107360168);
			}
			else
			{
				bool toFullPath = SQLiteConvert.ToBoolean(FindKey(sortedList, _0015(107359368), true.ToString()));
				text = ExpandFileName(text, toFullPath);
			}
		}
		try
		{
			bool usePool = SQLiteConvert.ToBoolean(FindKey(sortedList, _0015(107359383), GetDefaultPooling().ToString()));
			int maxPoolSize = Convert.ToInt32(FindKey(sortedList, _0015(107359338), SQLiteConvert.ToString(100)), CultureInfo.InvariantCulture);
			_defaultTimeout = Convert.ToInt32(FindKey(sortedList, _0015(107359349), SQLiteConvert.ToString(30)), CultureInfo.InvariantCulture);
			_busyTimeout = Convert.ToInt32(FindKey(sortedList, _0015(107359296), SQLiteConvert.ToString(0)), CultureInfo.InvariantCulture);
			_prepareRetries = Convert.ToInt32(FindKey(sortedList, _0015(107359311), SQLiteConvert.ToString(3)), CultureInfo.InvariantCulture);
			_progressOps = Convert.ToInt32(FindKey(sortedList, _0015(107359290), SQLiteConvert.ToString(0)), CultureInfo.InvariantCulture);
			obj = TryParseEnum(typeof(IsolationLevel), FindKey(sortedList, _0015(107359753), IsolationLevel.Serializable.ToString()), ignoreCase: true);
			_defaultIsolation = ((obj is IsolationLevel) ? ((IsolationLevel)obj) : IsolationLevel.Serializable);
			_defaultIsolation = GetEffectiveIsolationLevel(_defaultIsolation);
			if (_defaultIsolation != IsolationLevel.Serializable && _defaultIsolation != IsolationLevel.ReadCommitted)
			{
				throw new NotSupportedException(_0015(107359720));
			}
			_baseSchemaName = FindKey(sortedList, _0015(107359695), _0015(107359674));
			if (_sql == null)
			{
				SetupSQLiteBase(sortedList);
			}
			SQLiteOpenFlagsEnum sQLiteOpenFlagsEnum = SQLiteOpenFlagsEnum.None;
			if (!SQLiteConvert.ToBoolean(FindKey(sortedList, _0015(107359645), false.ToString())))
			{
				sQLiteOpenFlagsEnum |= SQLiteOpenFlagsEnum.Create;
			}
			if (SQLiteConvert.ToBoolean(FindKey(sortedList, _0015(107359592), false.ToString())))
			{
				sQLiteOpenFlagsEnum |= SQLiteOpenFlagsEnum.ReadOnly;
				sQLiteOpenFlagsEnum &= ~SQLiteOpenFlagsEnum.Create;
			}
			else
			{
				sQLiteOpenFlagsEnum |= SQLiteOpenFlagsEnum.ReadWrite;
			}
			if (flag3)
			{
				sQLiteOpenFlagsEnum |= SQLiteOpenFlagsEnum.Uri;
			}
			_sql.Open(text, _vfsName, _flags, sQLiteOpenFlagsEnum, maxPoolSize, usePool);
			_binaryGuid = SQLiteConvert.ToBoolean(FindKey(sortedList, _0015(107359611), true.ToString()));
			string text2 = FindKey(sortedList, _0015(107359562), null);
			if (text2 != null)
			{
				string error = null;
				byte[] array = FromHexString(text2, ref error);
				if (array == null)
				{
					throw new FormatException(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107359577), error));
				}
				_sql.SetPassword(array);
			}
			else
			{
				string text3 = FindKey(sortedList, _0015(107358948), null);
				if (text3 != null)
				{
					_sql.SetPassword(Encoding.UTF8.GetBytes(text3));
				}
				else if (_password != null)
				{
					_sql.SetPassword(_password);
				}
			}
			_password = null;
			if (!flag3)
			{
				_dataSource = Path.GetFileNameWithoutExtension(text);
			}
			else
			{
				_dataSource = text;
			}
			_version++;
			ConnectionState connectionState = _connectionState;
			_connectionState = ConnectionState.Open;
			try
			{
				string source = FindKey(sortedList, _0015(107358967), true.ToString());
				if (SQLiteConvert.ToBoolean(source))
				{
					using SQLiteCommand sQLiteCommand = CreateCommand();
					if (_busyTimeout != 0)
					{
						sQLiteCommand.CommandText = HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107358918), _busyTimeout);
						sQLiteCommand.ExecuteNonQuery();
					}
					int num;
					if (!flag3 && !flag4)
					{
						source = FindKey(sortedList, _0015(107358885), SQLiteConvert.ToString(4096));
						num = Convert.ToInt32(source, CultureInfo.InvariantCulture);
						if (num != 4096)
						{
							sQLiteCommand.CommandText = HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107358904), num);
							sQLiteCommand.ExecuteNonQuery();
						}
					}
					source = FindKey(sortedList, _0015(107358875), SQLiteConvert.ToString(0));
					num = Convert.ToInt32(source, CultureInfo.InvariantCulture);
					if (num != 0)
					{
						sQLiteCommand.CommandText = HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107358822), num);
						sQLiteCommand.ExecuteNonQuery();
					}
					source = FindKey(sortedList, _0015(107358785), false.ToString());
					bool flag5 = SQLiteConvert.ToBoolean(source);
					if (flag5)
					{
						sQLiteCommand.CommandText = HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107358764), flag5 ? _0015(107359230) : _0015(107359235));
						sQLiteCommand.ExecuteNonQuery();
					}
					source = FindKey(sortedList, _0015(107359257), SQLiteSynchronousEnum.Default.ToString());
					obj = TryParseEnum(typeof(SQLiteSynchronousEnum), source, ignoreCase: true);
					if (!(obj is SQLiteSynchronousEnum) || (SQLiteSynchronousEnum)obj != SQLiteSynchronousEnum.Default)
					{
						sQLiteCommand.CommandText = HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107359208), source);
						sQLiteCommand.ExecuteNonQuery();
					}
					source = FindKey(sortedList, _0015(107359175), SQLiteConvert.ToString(-2000));
					num = Convert.ToInt32(source, CultureInfo.InvariantCulture);
					if (num != -2000)
					{
						sQLiteCommand.CommandText = HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107359190), num);
						sQLiteCommand.ExecuteNonQuery();
					}
					source = FindKey(sortedList, _0015(107359161), SQLiteJournalModeEnum.Default.ToString());
					obj = TryParseEnum(typeof(SQLiteJournalModeEnum), source, ignoreCase: true);
					if (!(obj is SQLiteJournalModeEnum) || (SQLiteJournalModeEnum)obj != SQLiteJournalModeEnum.Default)
					{
						string format = _0015(107359112);
						sQLiteCommand.CommandText = HelperMethods.StringFormat(CultureInfo.InvariantCulture, format, source);
						sQLiteCommand.ExecuteNonQuery();
					}
					source = FindKey(sortedList, _0015(107359079), false.ToString());
					flag5 = SQLiteConvert.ToBoolean(source);
					if (flag5)
					{
						sQLiteCommand.CommandText = HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107359094), flag5 ? _0015(107359230) : _0015(107359235));
						sQLiteCommand.ExecuteNonQuery();
					}
					source = FindKey(sortedList, _0015(107359061), false.ToString());
					flag5 = SQLiteConvert.ToBoolean(source);
					if (flag5)
					{
						sQLiteCommand.CommandText = HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107359036), flag5 ? _0015(107359230) : _0015(107359235));
						sQLiteCommand.ExecuteNonQuery();
					}
				}
				if (this._progressHandler != null)
				{
					_sql.SetProgressHook(_progressOps, _progressCallback);
				}
				if (this._authorizerHandler != null)
				{
					_sql.SetAuthorizerHook(_authorizerCallback);
				}
				if (this._commitHandler != null)
				{
					_sql.SetCommitHook(_commitCallback);
				}
				if (this._updateHandler != null)
				{
					_sql.SetUpdateHook(_updateCallback);
				}
				if (this._rollbackHandler != null)
				{
					_sql.SetRollbackHook(_rollbackCallback);
				}
				Transaction current = Transaction.Current;
				if (current != null && SQLiteConvert.ToBoolean(FindKey(sortedList, _0015(107358483), true.ToString())))
				{
					EnlistTransaction(current);
				}
				_connectionState = connectionState;
				StateChangeEventArgs eventArgs = null;
				OnStateChange(ConnectionState.Open, ref eventArgs);
				OnChanged(this, new ConnectionEventArgs(SQLiteConnectionEventType.Opened, eventArgs, null, null, null, null, null, null));
			}
			catch
			{
				_connectionState = connectionState;
				throw;
			}
		}
		catch (SQLiteException)
		{
			Close();
			throw;
		}
	}

	public SQLiteConnection OpenAndReturn()
	{
		CheckDisposed();
		Open();
		return this;
	}

	public void Cancel()
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(_0015(107358324));
		}
		_sql.Cancel();
	}

	public bool IsReadOnly(string name)
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(_0015(107358682));
		}
		return _sql.IsReadOnly(name);
	}

	public static void GetMemoryStatistics(ref IDictionary<string, long> statistics)
	{
		if (statistics == null)
		{
			statistics = new Dictionary<string, long>();
		}
		statistics[_0015(107357850)] = SQLite3.StaticMemoryUsed;
		statistics[_0015(107357801)] = SQLite3.StaticMemoryHighwater;
	}

	public void ReleaseMemory()
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(_0015(107357812));
		}
		SQLiteErrorCode sQLiteErrorCode = _sql.ReleaseMemory();
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, _sql.GetLastError(_0015(107357743)));
		}
	}

	public static SQLiteErrorCode ReleaseMemory(int nBytes, bool reset, bool compact, ref int nFree, ref bool resetOk, ref uint nLargest)
	{
		return SQLite3.StaticReleaseMemory(nBytes, reset, compact, ref nFree, ref resetOk, ref nLargest);
	}

	public static SQLiteErrorCode SetMemoryStatus(bool value)
	{
		return SQLite3.StaticSetMemoryStatus(value);
	}

	private static bool TryGetLastCachedSetting(string name, object @default, out object value)
	{
		if (_lastConnectionInOpen == null)
		{
			value = @default;
			return false;
		}
		return _lastConnectionInOpen.TryGetCachedSetting(name, @default, out value);
	}

	private static void SetLastCachedSetting(string name, object value)
	{
		if (_lastConnectionInOpen != null)
		{
			_lastConnectionInOpen.SetCachedSetting(name, value);
		}
	}

	public SQLiteErrorCode Shutdown()
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(_0015(107358075));
		}
		_sql.Close(canThrow: true);
		return _sql.Shutdown();
	}

	public static void Shutdown(bool directories, bool noThrow)
	{
		SQLiteErrorCode sQLiteErrorCode = SQLite3.StaticShutdown(directories);
		if (sQLiteErrorCode != 0 && !noThrow)
		{
			throw new SQLiteException(sQLiteErrorCode, null);
		}
	}

	public void SetExtendedResultCodes(bool bOnOff)
	{
		CheckDisposed();
		if (_sql != null)
		{
			_sql.SetExtendedResultCodes(bOnOff);
		}
	}

	public SQLiteErrorCode ResultCode()
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(_0015(107357982));
		}
		return _sql.ResultCode();
	}

	public SQLiteErrorCode ExtendedResultCode()
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(_0015(107357429));
		}
		return _sql.ExtendedResultCode();
	}

	public void LogMessage(SQLiteErrorCode iErrCode, string zMessage)
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(_0015(107357312));
		}
		_sql.LogMessage(iErrCode, zMessage);
	}

	public void LogMessage(int iErrCode, string zMessage)
	{
		CheckDisposed();
		if (_sql == null)
		{
			throw new InvalidOperationException(_0015(107357312));
		}
		_sql.LogMessage((SQLiteErrorCode)iErrCode, zMessage);
	}

	public void ChangePassword(string newPassword)
	{
		CheckDisposed();
		ChangePassword(string.IsNullOrEmpty(newPassword) ? null : Encoding.UTF8.GetBytes(newPassword));
	}

	public void ChangePassword(byte[] newPassword)
	{
		CheckDisposed();
		if (_connectionState != ConnectionState.Open)
		{
			throw new InvalidOperationException(_0015(107357275));
		}
		_sql.ChangePassword(newPassword);
	}

	public void SetPassword(string databasePassword)
	{
		CheckDisposed();
		SetPassword(string.IsNullOrEmpty(databasePassword) ? null : Encoding.UTF8.GetBytes(databasePassword));
	}

	public void SetPassword(byte[] databasePassword)
	{
		CheckDisposed();
		if (_connectionState != 0)
		{
			throw new InvalidOperationException(_0015(107357714));
		}
		if (databasePassword != null && databasePassword.Length == 0)
		{
			databasePassword = null;
		}
		_password = databasePassword;
	}

	public SQLiteErrorCode SetAvRetry(ref int count, ref int interval)
	{
		CheckDisposed();
		if (_connectionState != ConnectionState.Open)
		{
			throw new InvalidOperationException(_0015(107357605));
		}
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = Marshal.AllocHGlobal(8);
			Marshal.WriteInt32(intPtr, 0, count);
			Marshal.WriteInt32(intPtr, 4, interval);
			SQLiteErrorCode sQLiteErrorCode = _sql.FileControl(null, 9, intPtr);
			if (sQLiteErrorCode == SQLiteErrorCode.Ok)
			{
				count = Marshal.ReadInt32(intPtr, 0);
				interval = Marshal.ReadInt32(intPtr, 4);
				return sQLiteErrorCode;
			}
			return sQLiteErrorCode;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	public SQLiteErrorCode SetChunkSize(int size)
	{
		CheckDisposed();
		if (_connectionState != ConnectionState.Open)
		{
			throw new InvalidOperationException(_0015(107357516));
		}
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(intPtr, 0, size);
			return _sql.FileControl(null, 6, intPtr);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	private static string UnwrapString(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return value;
		}
		int length = value.Length;
		if ((value[0] == '\'' && value[length - 1] == '\'') || (value[0] == '"' && value[length - 1] == '"'))
		{
			return value.Substring(1, length - 2);
		}
		return value;
	}

	private static string GetDataDirectory()
	{
		string text = AppDomain.CurrentDomain.GetData(_0015(107356927)) as string;
		if (string.IsNullOrEmpty(text))
		{
			text = AppDomain.CurrentDomain.BaseDirectory;
		}
		return text;
	}

	private static string ExpandFileName(string sourceFile, bool toFullPath)
	{
		if (string.IsNullOrEmpty(sourceFile))
		{
			return sourceFile;
		}
		if (sourceFile.StartsWith(_0015(107356906), StringComparison.OrdinalIgnoreCase))
		{
			string dataDirectory = GetDataDirectory();
			if (sourceFile.Length > _0015(107356906).Length && (sourceFile[_0015(107356906).Length] == Path.DirectorySeparatorChar || sourceFile[_0015(107356906).Length] == Path.AltDirectorySeparatorChar))
			{
				sourceFile = sourceFile.Remove(_0015(107356906).Length, 1);
			}
			sourceFile = Path.Combine(dataDirectory, sourceFile.Substring(_0015(107356906).Length));
		}
		if (toFullPath)
		{
			sourceFile = Path.GetFullPath(sourceFile);
		}
		return sourceFile;
	}

	public override DataTable GetSchema()
	{
		CheckDisposed();
		return GetSchema(_0015(107356917), null);
	}

	public override DataTable GetSchema(string collectionName)
	{
		CheckDisposed();
		return GetSchema(collectionName, new string[0]);
	}

	public override DataTable GetSchema(string collectionName, string[] restrictionValues)
	{
		CheckDisposed();
		if (_connectionState != ConnectionState.Open)
		{
			throw new InvalidOperationException();
		}
		string[] array = new string[5];
		if (restrictionValues == null)
		{
			restrictionValues = new string[0];
		}
		restrictionValues.CopyTo(array, 0);
		string key;
		if ((key = collectionName.ToUpper(CultureInfo.InvariantCulture)) != null)
		{
			if (_003CPrivateImplementationDetails_003E_007B6FEF2758_002D124E_002D458C_002DACD8_002D241268B85071_007D._0024_0024method0x6000297_002D1 == null)
			{
				_003CPrivateImplementationDetails_003E_007B6FEF2758_002D124E_002D458C_002DACD8_002D241268B85071_007D._0024_0024method0x6000297_002D1 = new Dictionary<string, int>(14)
				{
					{
						_0015(107356888),
						0
					},
					{
						_0015(107356859),
						1
					},
					{
						_0015(107356798),
						2
					},
					{
						_0015(107356817),
						3
					},
					{
						_0015(107356772),
						4
					},
					{
						_0015(107356787),
						5
					},
					{
						_0015(107356742),
						6
					},
					{
						_0015(107356761),
						7
					},
					{
						_0015(107356712),
						8
					},
					{
						_0015(107356703),
						9
					},
					{
						_0015(107356726),
						10
					},
					{
						_0015(107357189),
						11
					},
					{
						_0015(107357204),
						12
					},
					{
						_0015(107357159),
						13
					}
				};
			}
			if (_003CPrivateImplementationDetails_003E_007B6FEF2758_002D124E_002D458C_002DACD8_002D241268B85071_007D._0024_0024method0x6000297_002D1.TryGetValue(key, out var value))
			{
				switch (value)
				{
				case 0:
					return Schema_MetaDataCollections();
				case 1:
					return Schema_DataSourceInformation();
				case 2:
					return Schema_DataTypes();
				case 3:
				case 4:
					return Schema_Columns(array[0], array[2], array[3]);
				case 5:
					return Schema_Indexes(array[0], array[2], array[3]);
				case 6:
					return Schema_Triggers(array[0], array[2], array[3]);
				case 7:
					return Schema_IndexColumns(array[0], array[2], array[3], array[4]);
				case 8:
					return Schema_Tables(array[0], array[2], array[3]);
				case 9:
					return Schema_Views(array[0], array[2]);
				case 10:
					return Schema_ViewColumns(array[0], array[2], array[3]);
				case 11:
					return Schema_ForeignKeys(array[0], array[2], array[3]);
				case 12:
					return Schema_Catalogs(array[0]);
				case 13:
					return Schema_ReservedWords();
				}
			}
		}
		throw new NotSupportedException();
	}

	private static DataTable Schema_ReservedWords()
	{
		DataTable dataTable = new DataTable(_0015(107357170));
		dataTable.Locale = CultureInfo.InvariantCulture;
		dataTable.Columns.Add(_0015(107357149), typeof(string));
		dataTable.Columns.Add(_0015(107357100), typeof(string));
		dataTable.Columns.Add(_0015(107357111), typeof(string));
		dataTable.BeginLoadData();
		string[] array = SR.Keywords.Split(new char[1] { ',' });
		foreach (string value in array)
		{
			DataRow dataRow = dataTable.NewRow();
			dataRow[0] = value;
			dataTable.Rows.Add(dataRow);
		}
		dataTable.AcceptChanges();
		dataTable.EndLoadData();
		return dataTable;
	}

	private static DataTable Schema_MetaDataCollections()
	{
		DataTable dataTable = new DataTable(_0015(107356917));
		dataTable.Locale = CultureInfo.InvariantCulture;
		dataTable.Columns.Add(_0015(107357058), typeof(string));
		dataTable.Columns.Add(_0015(107357037), typeof(int));
		dataTable.Columns.Add(_0015(107357040), typeof(int));
		dataTable.BeginLoadData();
		StringReader stringReader = new StringReader(SR.MetaDataCollections);
		dataTable.ReadXml(stringReader);
		stringReader.Close();
		dataTable.AcceptChanges();
		dataTable.EndLoadData();
		return dataTable;
	}

	private DataTable Schema_DataSourceInformation()
	{
		DataTable dataTable = new DataTable(_0015(107357007));
		dataTable.Locale = CultureInfo.InvariantCulture;
		dataTable.Columns.Add(DbMetaDataColumnNames.CompositeIdentifierSeparatorPattern, typeof(string));
		dataTable.Columns.Add(DbMetaDataColumnNames.DataSourceProductName, typeof(string));
		dataTable.Columns.Add(DbMetaDataColumnNames.DataSourceProductVersion, typeof(string));
		dataTable.Columns.Add(DbMetaDataColumnNames.DataSourceProductVersionNormalized, typeof(string));
		dataTable.Columns.Add(DbMetaDataColumnNames.GroupByBehavior, typeof(int));
		dataTable.Columns.Add(DbMetaDataColumnNames.IdentifierPattern, typeof(string));
		dataTable.Columns.Add(DbMetaDataColumnNames.IdentifierCase, typeof(int));
		dataTable.Columns.Add(DbMetaDataColumnNames.OrderByColumnsInSelect, typeof(bool));
		dataTable.Columns.Add(DbMetaDataColumnNames.ParameterMarkerFormat, typeof(string));
		dataTable.Columns.Add(DbMetaDataColumnNames.ParameterMarkerPattern, typeof(string));
		dataTable.Columns.Add(DbMetaDataColumnNames.ParameterNameMaxLength, typeof(int));
		dataTable.Columns.Add(DbMetaDataColumnNames.ParameterNamePattern, typeof(string));
		dataTable.Columns.Add(DbMetaDataColumnNames.QuotedIdentifierPattern, typeof(string));
		dataTable.Columns.Add(DbMetaDataColumnNames.QuotedIdentifierCase, typeof(int));
		dataTable.Columns.Add(DbMetaDataColumnNames.StatementSeparatorPattern, typeof(string));
		dataTable.Columns.Add(DbMetaDataColumnNames.StringLiteralPattern, typeof(string));
		dataTable.Columns.Add(DbMetaDataColumnNames.SupportedJoinOperators, typeof(int));
		dataTable.BeginLoadData();
		DataRow dataRow = dataTable.NewRow();
		dataRow.ItemArray = new object[17]
		{
			null,
			_0015(107356978),
			_sql.Version,
			_sql.Version,
			3,
			_0015(107356425),
			1,
			false,
			_0015(107356315),
			_0015(107356310),
			255,
			_0015(107356677),
			_0015(107356596),
			1,
			_0015(107356543),
			_0015(107356570),
			15
		};
		dataTable.Rows.Add(dataRow);
		dataTable.AcceptChanges();
		dataTable.EndLoadData();
		return dataTable;
	}

	private DataTable Schema_Columns(string strCatalog, string strTable, string strColumn)
	{
		DataTable dataTable = new DataTable(_0015(107356517));
		dataTable.Locale = CultureInfo.InvariantCulture;
		dataTable.Columns.Add(_0015(107356536), typeof(string));
		dataTable.Columns.Add(_0015(107356483), typeof(string));
		dataTable.Columns.Add(_0015(107356498), typeof(string));
		dataTable.Columns.Add(_0015(107356449), typeof(string));
		dataTable.Columns.Add(_0015(107356464), typeof(Guid));
		dataTable.Columns.Add(_0015(107355903), typeof(long));
		dataTable.Columns.Add(_0015(107355882), typeof(int));
		dataTable.Columns.Add(_0015(107355889), typeof(bool));
		dataTable.Columns.Add(_0015(107355864), typeof(string));
		dataTable.Columns.Add(_0015(107355811), typeof(long));
		dataTable.Columns.Add(_0015(107355826), typeof(bool));
		dataTable.Columns.Add(_0015(107355777), typeof(string));
		dataTable.Columns.Add(_0015(107355796), typeof(Guid));
		dataTable.Columns.Add(_0015(107355751), typeof(int));
		dataTable.Columns.Add(_0015(107355718), typeof(int));
		dataTable.Columns.Add(_0015(107355685), typeof(int));
		dataTable.Columns.Add(_0015(107356172), typeof(int));
		dataTable.Columns.Add(_0015(107356183), typeof(long));
		dataTable.Columns.Add(_0015(107356126), typeof(string));
		dataTable.Columns.Add(_0015(107356097), typeof(string));
		dataTable.Columns.Add(_0015(107356068), typeof(string));
		dataTable.Columns.Add(_0015(107356043), typeof(string));
		dataTable.Columns.Add(_0015(107356050), typeof(string));
		dataTable.Columns.Add(_0015(107356025), typeof(string));
		dataTable.Columns.Add(_0015(107355972), typeof(string));
		dataTable.Columns.Add(_0015(107355983), typeof(string));
		dataTable.Columns.Add(_0015(107355934), typeof(string));
		dataTable.Columns.Add(_0015(107355405), typeof(bool));
		dataTable.Columns.Add(_0015(107355420), typeof(string));
		dataTable.Columns.Add(_0015(107355407), typeof(bool));
		dataTable.Columns.Add(_0015(107355386), typeof(bool));
		dataTable.BeginLoadData();
		if (string.IsNullOrEmpty(strCatalog))
		{
			strCatalog = _0015(107362684);
		}
		string text = ((string.Compare(strCatalog, _0015(107362675), StringComparison.OrdinalIgnoreCase) == 0) ? _0015(107355356) : _0015(107355377));
		using (SQLiteCommand sQLiteCommand = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107355299), strCatalog, text), this))
		{
			using SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
			while (sQLiteDataReader.Read())
			{
				if (!string.IsNullOrEmpty(strTable) && string.Compare(strTable, sQLiteDataReader.GetString(2), StringComparison.OrdinalIgnoreCase) != 0)
				{
					continue;
				}
				try
				{
					using SQLiteCommand sQLiteCommand2 = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107355198), strCatalog, sQLiteDataReader.GetString(2)), this);
					using SQLiteDataReader sQLiteDataReader2 = sQLiteCommand2.ExecuteReader(CommandBehavior.SchemaOnly);
					using DataTable dataTable2 = sQLiteDataReader2.GetSchemaTable(wantUniqueInfo: true, wantDefaultValue: true);
					foreach (DataRow row in dataTable2.Rows)
					{
						if (string.Compare(row[SchemaTableColumn.ColumnName].ToString(), strColumn, StringComparison.OrdinalIgnoreCase) == 0 || strColumn == null)
						{
							DataRow dataRow2 = dataTable.NewRow();
							dataRow2[_0015(107355685)] = row[SchemaTableColumn.NumericPrecision];
							dataRow2[_0015(107356172)] = row[SchemaTableColumn.NumericScale];
							dataRow2[_0015(107356498)] = sQLiteDataReader.GetString(2);
							dataRow2[_0015(107356449)] = row[SchemaTableColumn.ColumnName];
							dataRow2[_0015(107356536)] = strCatalog;
							dataRow2[_0015(107355882)] = row[SchemaTableColumn.ColumnOrdinal];
							dataRow2[_0015(107355889)] = row[SchemaTableOptionalColumn.DefaultValue] != DBNull.Value;
							dataRow2[_0015(107355864)] = row[SchemaTableOptionalColumn.DefaultValue];
							dataRow2[_0015(107355826)] = row[SchemaTableColumn.AllowDBNull];
							dataRow2[_0015(107355777)] = row[_0015(107355193)].ToString()!.ToLower(CultureInfo.InvariantCulture);
							dataRow2[_0015(107355420)] = SQLiteConvert.DbTypeToTypeName(this, (DbType)row[SchemaTableColumn.ProviderType], _flags).ToString().ToLower(CultureInfo.InvariantCulture);
							dataRow2[_0015(107355751)] = row[SchemaTableColumn.ColumnSize];
							dataRow2[_0015(107356483)] = row[SchemaTableColumn.BaseSchemaName];
							dataRow2[_0015(107355405)] = row[SchemaTableColumn.IsKey];
							dataRow2[_0015(107355407)] = row[SchemaTableOptionalColumn.IsAutoIncrement];
							dataRow2[_0015(107356025)] = row[_0015(107355656)];
							dataRow2[_0015(107355386)] = row[SchemaTableColumn.IsUnique];
							dataTable.Rows.Add(dataRow2);
						}
					}
				}
				catch (SQLiteException)
				{
				}
			}
		}
		dataTable.AcceptChanges();
		dataTable.EndLoadData();
		return dataTable;
	}

	private DataTable Schema_Indexes(string strCatalog, string strTable, string strIndex)
	{
		DataTable dataTable = new DataTable(_0015(107355667));
		List<int> list = new List<int>();
		dataTable.Locale = CultureInfo.InvariantCulture;
		dataTable.Columns.Add(_0015(107356536), typeof(string));
		dataTable.Columns.Add(_0015(107356483), typeof(string));
		dataTable.Columns.Add(_0015(107356498), typeof(string));
		dataTable.Columns.Add(_0015(107355622), typeof(string));
		dataTable.Columns.Add(_0015(107355633), typeof(string));
		dataTable.Columns.Add(_0015(107355584), typeof(string));
		dataTable.Columns.Add(_0015(107355405), typeof(bool));
		dataTable.Columns.Add(_0015(107355386), typeof(bool));
		dataTable.Columns.Add(_0015(107355599), typeof(bool));
		dataTable.Columns.Add(_0015(107355554), typeof(int));
		dataTable.Columns.Add(_0015(107355577), typeof(int));
		dataTable.Columns.Add(_0015(107355528), typeof(int));
		dataTable.Columns.Add(_0015(107355543), typeof(int));
		dataTable.Columns.Add(_0015(107355534), typeof(bool));
		dataTable.Columns.Add(_0015(107355513), typeof(bool));
		dataTable.Columns.Add(_0015(107355464), typeof(int));
		dataTable.Columns.Add(_0015(107355882), typeof(int));
		dataTable.Columns.Add(_0015(107356449), typeof(string));
		dataTable.Columns.Add(_0015(107356464), typeof(Guid));
		dataTable.Columns.Add(_0015(107355903), typeof(long));
		dataTable.Columns.Add(_0015(107355475), typeof(short));
		dataTable.Columns.Add(_0015(107355430), typeof(decimal));
		dataTable.Columns.Add(_0015(107355445), typeof(int));
		dataTable.Columns.Add(_0015(107354892), typeof(string));
		dataTable.Columns.Add(_0015(107354899), typeof(bool));
		dataTable.Columns.Add(_0015(107354850), typeof(string));
		dataTable.BeginLoadData();
		if (string.IsNullOrEmpty(strCatalog))
		{
			strCatalog = _0015(107362684);
		}
		string text = ((string.Compare(strCatalog, _0015(107362675), StringComparison.OrdinalIgnoreCase) == 0) ? _0015(107355356) : _0015(107355377));
		using (SQLiteCommand sQLiteCommand = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107354825), strCatalog, text), this))
		{
			using SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
			while (sQLiteDataReader.Read())
			{
				bool flag = false;
				list.Clear();
				if (!string.IsNullOrEmpty(strTable) && string.Compare(sQLiteDataReader.GetString(2), strTable, StringComparison.OrdinalIgnoreCase) != 0)
				{
					continue;
				}
				try
				{
					using SQLiteCommand sQLiteCommand2 = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107354756), strCatalog, sQLiteDataReader.GetString(2)), this);
					using SQLiteDataReader sQLiteDataReader2 = sQLiteCommand2.ExecuteReader();
					while (sQLiteDataReader2.Read())
					{
						if (sQLiteDataReader2.GetInt32(5) != 0)
						{
							list.Add(sQLiteDataReader2.GetInt32(0));
							if (string.Compare(sQLiteDataReader2.GetString(2), _0015(107366982), StringComparison.OrdinalIgnoreCase) == 0)
							{
								flag = true;
							}
						}
					}
				}
				catch (SQLiteException)
				{
				}
				if (list.Count == 1 && flag)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow[_0015(107356536)] = strCatalog;
					dataRow[_0015(107356498)] = sQLiteDataReader.GetString(2);
					dataRow[_0015(107355622)] = strCatalog;
					dataRow[_0015(107355405)] = true;
					dataRow[_0015(107355584)] = HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107354747), sQLiteDataReader.GetString(2), text);
					dataRow[_0015(107355386)] = true;
					if (string.Compare((string)dataRow[_0015(107355584)], strIndex, StringComparison.OrdinalIgnoreCase) == 0 || strIndex == null)
					{
						dataTable.Rows.Add(dataRow);
					}
					list.Clear();
				}
				try
				{
					using SQLiteCommand sQLiteCommand3 = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107354698), strCatalog, sQLiteDataReader.GetString(2)), this);
					using SQLiteDataReader sQLiteDataReader3 = sQLiteCommand3.ExecuteReader();
					while (sQLiteDataReader3.Read())
					{
						if (string.Compare(sQLiteDataReader3.GetString(1), strIndex, StringComparison.OrdinalIgnoreCase) != 0 && strIndex != null)
						{
							continue;
						}
						DataRow dataRow = dataTable.NewRow();
						dataRow[_0015(107356536)] = strCatalog;
						dataRow[_0015(107356498)] = sQLiteDataReader.GetString(2);
						dataRow[_0015(107355622)] = strCatalog;
						dataRow[_0015(107355584)] = sQLiteDataReader3.GetString(1);
						dataRow[_0015(107355386)] = SQLiteConvert.ToBoolean(sQLiteDataReader3.GetValue(2), CultureInfo.InvariantCulture, viaFramework: false);
						dataRow[_0015(107355405)] = false;
						using (SQLiteCommand sQLiteCommand4 = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107354657), strCatalog, sQLiteDataReader3.GetString(1).Replace(_0015(107355100), _0015(107355095)), text), this))
						{
							using SQLiteDataReader sQLiteDataReader4 = sQLiteCommand4.ExecuteReader();
							if (sQLiteDataReader4.Read() && !sQLiteDataReader4.IsDBNull(4))
							{
								dataRow[_0015(107354850)] = sQLiteDataReader4.GetString(4);
							}
						}
						if (list.Count > 0 && sQLiteDataReader3.GetString(1).StartsWith(_0015(107355090) + sQLiteDataReader.GetString(2), StringComparison.InvariantCultureIgnoreCase))
						{
							using SQLiteCommand sQLiteCommand5 = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107355065), strCatalog, sQLiteDataReader3.GetString(1)), this);
							using SQLiteDataReader sQLiteDataReader5 = sQLiteCommand5.ExecuteReader();
							int num = 0;
							while (sQLiteDataReader5.Read())
							{
								if (!list.Contains(sQLiteDataReader5.GetInt32(1)))
								{
									num = 0;
									break;
								}
								num++;
							}
							if (num == list.Count)
							{
								dataRow[_0015(107355405)] = true;
								list.Clear();
							}
						}
						dataTable.Rows.Add(dataRow);
					}
				}
				catch (SQLiteException)
				{
				}
			}
		}
		dataTable.AcceptChanges();
		dataTable.EndLoadData();
		return dataTable;
	}

	private DataTable Schema_Triggers(string catalog, string table, string triggerName)
	{
		DataTable dataTable = new DataTable(_0015(107355024));
		dataTable.Locale = CultureInfo.InvariantCulture;
		dataTable.Columns.Add(_0015(107356536), typeof(string));
		dataTable.Columns.Add(_0015(107356483), typeof(string));
		dataTable.Columns.Add(_0015(107356498), typeof(string));
		dataTable.Columns.Add(_0015(107354979), typeof(string));
		dataTable.Columns.Add(_0015(107354994), typeof(string));
		dataTable.BeginLoadData();
		if (string.IsNullOrEmpty(table))
		{
			table = null;
		}
		if (string.IsNullOrEmpty(catalog))
		{
			catalog = _0015(107362684);
		}
		string text = ((string.Compare(catalog, _0015(107362675), StringComparison.OrdinalIgnoreCase) == 0) ? _0015(107355356) : _0015(107355377));
		using (SQLiteCommand sQLiteCommand = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107354969), catalog, text), this))
		{
			using SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
			while (sQLiteDataReader.Read())
			{
				if ((string.Compare(sQLiteDataReader.GetString(1), triggerName, StringComparison.OrdinalIgnoreCase) == 0 || triggerName == null) && (table == null || string.Compare(table, sQLiteDataReader.GetString(2), StringComparison.OrdinalIgnoreCase) == 0))
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow[_0015(107356536)] = catalog;
					dataRow[_0015(107356498)] = sQLiteDataReader.GetString(2);
					dataRow[_0015(107354979)] = sQLiteDataReader.GetString(1);
					dataRow[_0015(107354994)] = sQLiteDataReader.GetString(4);
					dataTable.Rows.Add(dataRow);
				}
			}
		}
		dataTable.AcceptChanges();
		dataTable.EndLoadData();
		return dataTable;
	}

	private DataTable Schema_Tables(string strCatalog, string strTable, string strType)
	{
		DataTable dataTable = new DataTable(_0015(107354279));
		dataTable.Locale = CultureInfo.InvariantCulture;
		dataTable.Columns.Add(_0015(107356536), typeof(string));
		dataTable.Columns.Add(_0015(107356483), typeof(string));
		dataTable.Columns.Add(_0015(107356498), typeof(string));
		dataTable.Columns.Add(_0015(107354270), typeof(string));
		dataTable.Columns.Add(_0015(107354253), typeof(long));
		dataTable.Columns.Add(_0015(107354240), typeof(int));
		dataTable.Columns.Add(_0015(107354219), typeof(string));
		dataTable.BeginLoadData();
		if (string.IsNullOrEmpty(strCatalog))
		{
			strCatalog = _0015(107362684);
		}
		string text = ((string.Compare(strCatalog, _0015(107362675), StringComparison.OrdinalIgnoreCase) == 0) ? _0015(107355356) : _0015(107355377));
		using (SQLiteCommand sQLiteCommand = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107354226), strCatalog, text), this))
		{
			using SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
			while (sQLiteDataReader.Read())
			{
				string text2 = sQLiteDataReader.GetString(0);
				if (string.Compare(sQLiteDataReader.GetString(2), 0, _0015(107354564), 0, 7, StringComparison.OrdinalIgnoreCase) == 0)
				{
					text2 = _0015(107354583);
				}
				if ((string.Compare(strType, text2, StringComparison.OrdinalIgnoreCase) == 0 || strType == null) && (string.Compare(sQLiteDataReader.GetString(2), strTable, StringComparison.OrdinalIgnoreCase) == 0 || strTable == null))
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow[_0015(107356536)] = strCatalog;
					dataRow[_0015(107356498)] = sQLiteDataReader.GetString(2);
					dataRow[_0015(107354270)] = text2;
					dataRow[_0015(107354253)] = sQLiteDataReader.GetInt64(5);
					dataRow[_0015(107354240)] = sQLiteDataReader.GetInt32(3);
					dataRow[_0015(107354219)] = sQLiteDataReader.GetString(4);
					dataTable.Rows.Add(dataRow);
				}
			}
		}
		dataTable.AcceptChanges();
		dataTable.EndLoadData();
		return dataTable;
	}

	private DataTable Schema_Views(string strCatalog, string strView)
	{
		DataTable dataTable = new DataTable(_0015(107354534));
		dataTable.Locale = CultureInfo.InvariantCulture;
		dataTable.Columns.Add(_0015(107356536), typeof(string));
		dataTable.Columns.Add(_0015(107356483), typeof(string));
		dataTable.Columns.Add(_0015(107356498), typeof(string));
		dataTable.Columns.Add(_0015(107354557), typeof(string));
		dataTable.Columns.Add(_0015(107354504), typeof(bool));
		dataTable.Columns.Add(_0015(107354519), typeof(bool));
		dataTable.Columns.Add(_0015(107355934), typeof(string));
		dataTable.Columns.Add(_0015(107354470), typeof(DateTime));
		dataTable.Columns.Add(_0015(107354485), typeof(DateTime));
		dataTable.BeginLoadData();
		if (string.IsNullOrEmpty(strCatalog))
		{
			strCatalog = _0015(107362684);
		}
		string text = ((string.Compare(strCatalog, _0015(107362675), StringComparison.OrdinalIgnoreCase) == 0) ? _0015(107355356) : _0015(107355377));
		using (SQLiteCommand sQLiteCommand = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107354432), strCatalog, text), this))
		{
			using SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
			while (sQLiteDataReader.Read())
			{
				if (string.Compare(sQLiteDataReader.GetString(1), strView, StringComparison.OrdinalIgnoreCase) == 0 || string.IsNullOrEmpty(strView))
				{
					string text2 = sQLiteDataReader.GetString(4).Replace('\r', ' ').Replace('\n', ' ')
						.Replace('\t', ' ');
					int num = CultureInfo.InvariantCulture.CompareInfo.IndexOf(text2, _0015(107353883), CompareOptions.IgnoreCase);
					if (num > -1)
					{
						text2 = text2.Substring(num + 4).Trim();
						DataRow dataRow = dataTable.NewRow();
						dataRow[_0015(107356536)] = strCatalog;
						dataRow[_0015(107356498)] = sQLiteDataReader.GetString(2);
						dataRow[_0015(107354519)] = false;
						dataRow[_0015(107354557)] = text2;
						dataTable.Rows.Add(dataRow);
					}
				}
			}
		}
		dataTable.AcceptChanges();
		dataTable.EndLoadData();
		return dataTable;
	}

	private DataTable Schema_Catalogs(string strCatalog)
	{
		DataTable dataTable = new DataTable(_0015(107362665));
		dataTable.Locale = CultureInfo.InvariantCulture;
		dataTable.Columns.Add(_0015(107353874), typeof(string));
		dataTable.Columns.Add(_0015(107355934), typeof(string));
		dataTable.Columns.Add(_0015(107353825), typeof(long));
		dataTable.BeginLoadData();
		using (SQLiteCommand sQLiteCommand = new SQLiteCommand(_0015(107353852), this))
		{
			using SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
			while (sQLiteDataReader.Read())
			{
				if (string.Compare(sQLiteDataReader.GetString(1), strCatalog, StringComparison.OrdinalIgnoreCase) == 0 || strCatalog == null)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow[_0015(107353874)] = sQLiteDataReader.GetString(1);
					dataRow[_0015(107355934)] = sQLiteDataReader.GetString(2);
					dataRow[_0015(107353825)] = sQLiteDataReader.GetInt64(0);
					dataTable.Rows.Add(dataRow);
				}
			}
		}
		dataTable.AcceptChanges();
		dataTable.EndLoadData();
		return dataTable;
	}

	private DataTable Schema_DataTypes()
	{
		DataTable dataTable = new DataTable(_0015(107353791));
		dataTable.Locale = CultureInfo.InvariantCulture;
		dataTable.Columns.Add(_0015(107353810), typeof(string));
		dataTable.Columns.Add(_0015(107353765), typeof(int));
		dataTable.Columns.Add(_0015(107353776), typeof(long));
		dataTable.Columns.Add(_0015(107353727), typeof(string));
		dataTable.Columns.Add(_0015(107353742), typeof(string));
		dataTable.Columns.Add(_0015(107353717), typeof(string));
		dataTable.Columns.Add(_0015(107353672), typeof(bool));
		dataTable.Columns.Add(_0015(107353643), typeof(bool));
		dataTable.Columns.Add(_0015(107353658), typeof(bool));
		dataTable.Columns.Add(_0015(107354117), typeof(bool));
		dataTable.Columns.Add(_0015(107354128), typeof(bool));
		dataTable.Columns.Add(_0015(107354099), typeof(bool));
		dataTable.Columns.Add(_0015(107354058), typeof(bool));
		dataTable.Columns.Add(_0015(107354073), typeof(bool));
		dataTable.Columns.Add(_0015(107354024), typeof(bool));
		dataTable.Columns.Add(_0015(107353995), typeof(bool));
		dataTable.Columns.Add(_0015(107354002), typeof(string));
		dataTable.Columns.Add(_0015(107353981), typeof(string));
		dataTable.Columns.Add(_0015(107353928), typeof(bool));
		dataTable.Columns.Add(_0015(107353943), typeof(short));
		dataTable.Columns.Add(_0015(107353894), typeof(short));
		dataTable.Columns.Add(_0015(107353909), typeof(bool));
		dataTable.BeginLoadData();
		StringReader stringReader = new StringReader(SR.DataTypes);
		dataTable.ReadXml(stringReader);
		stringReader.Close();
		dataTable.AcceptChanges();
		dataTable.EndLoadData();
		return dataTable;
	}

	private DataTable Schema_IndexColumns(string strCatalog, string strTable, string strIndex, string strColumn)
	{
		DataTable dataTable = new DataTable(_0015(107353372));
		List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
		dataTable.Locale = CultureInfo.InvariantCulture;
		dataTable.Columns.Add(_0015(107353323), typeof(string));
		dataTable.Columns.Add(_0015(107353330), typeof(string));
		dataTable.Columns.Add(_0015(107353305), typeof(string));
		dataTable.Columns.Add(_0015(107356536), typeof(string));
		dataTable.Columns.Add(_0015(107356483), typeof(string));
		dataTable.Columns.Add(_0015(107356498), typeof(string));
		dataTable.Columns.Add(_0015(107356449), typeof(string));
		dataTable.Columns.Add(_0015(107355882), typeof(int));
		dataTable.Columns.Add(_0015(107355584), typeof(string));
		dataTable.Columns.Add(_0015(107356025), typeof(string));
		dataTable.Columns.Add(_0015(107353252), typeof(string));
		dataTable.Columns.Add(_0015(107353271), typeof(int));
		if (string.IsNullOrEmpty(strCatalog))
		{
			strCatalog = _0015(107362684);
		}
		string text = ((string.Compare(strCatalog, _0015(107362675), StringComparison.OrdinalIgnoreCase) == 0) ? _0015(107355356) : _0015(107355377));
		dataTable.BeginLoadData();
		using (SQLiteCommand sQLiteCommand = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107354825), strCatalog, text), this))
		{
			using SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
			while (sQLiteDataReader.Read())
			{
				bool flag = false;
				list.Clear();
				if (!string.IsNullOrEmpty(strTable) && string.Compare(sQLiteDataReader.GetString(2), strTable, StringComparison.OrdinalIgnoreCase) != 0)
				{
					continue;
				}
				try
				{
					using SQLiteCommand sQLiteCommand2 = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107354756), strCatalog, sQLiteDataReader.GetString(2)), this);
					using SQLiteDataReader sQLiteDataReader2 = sQLiteCommand2.ExecuteReader();
					while (sQLiteDataReader2.Read())
					{
						if (sQLiteDataReader2.GetInt32(5) == 1)
						{
							list.Add(new KeyValuePair<int, string>(sQLiteDataReader2.GetInt32(0), sQLiteDataReader2.GetString(1)));
							if (string.Compare(sQLiteDataReader2.GetString(2), _0015(107366982), StringComparison.OrdinalIgnoreCase) == 0)
							{
								flag = true;
							}
						}
					}
				}
				catch (SQLiteException)
				{
				}
				if (list.Count == 1 && flag)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow[_0015(107353323)] = strCatalog;
					dataRow[_0015(107353305)] = HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107354747), sQLiteDataReader.GetString(2), text);
					dataRow[_0015(107356536)] = strCatalog;
					dataRow[_0015(107356498)] = sQLiteDataReader.GetString(2);
					dataRow[_0015(107356449)] = list[0].Value;
					dataRow[_0015(107355584)] = dataRow[_0015(107353305)];
					dataRow[_0015(107355882)] = 0;
					dataRow[_0015(107356025)] = _0015(107367721);
					dataRow[_0015(107353252)] = _0015(107353218);
					dataRow[_0015(107353271)] = 2;
					if (string.IsNullOrEmpty(strIndex) || string.Compare(strIndex, (string)dataRow[_0015(107355584)], StringComparison.OrdinalIgnoreCase) == 0)
					{
						dataTable.Rows.Add(dataRow);
					}
				}
				using SQLiteCommand sQLiteCommand3 = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107353245), strCatalog, sQLiteDataReader.GetString(2).Replace(_0015(107355100), _0015(107355095)), text), this);
				using SQLiteDataReader sQLiteDataReader3 = sQLiteCommand3.ExecuteReader();
				while (sQLiteDataReader3.Read())
				{
					int num = 0;
					if (!string.IsNullOrEmpty(strIndex) && string.Compare(strIndex, sQLiteDataReader3.GetString(1), StringComparison.OrdinalIgnoreCase) != 0)
					{
						continue;
					}
					try
					{
						using SQLiteCommand sQLiteCommand4 = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107355065), strCatalog, sQLiteDataReader3.GetString(1)), this);
						using SQLiteDataReader sQLiteDataReader4 = sQLiteCommand4.ExecuteReader();
						while (sQLiteDataReader4.Read())
						{
							string text2 = (sQLiteDataReader4.IsDBNull(2) ? null : sQLiteDataReader4.GetString(2));
							DataRow dataRow = dataTable.NewRow();
							dataRow[_0015(107353323)] = strCatalog;
							dataRow[_0015(107353305)] = sQLiteDataReader3.GetString(1);
							dataRow[_0015(107356536)] = strCatalog;
							dataRow[_0015(107356498)] = sQLiteDataReader3.GetString(2);
							dataRow[_0015(107356449)] = text2;
							dataRow[_0015(107355584)] = sQLiteDataReader3.GetString(1);
							dataRow[_0015(107355882)] = num;
							string collationSequence = null;
							int sortMode = 0;
							int onError = 0;
							if (text2 != null)
							{
								_sql.GetIndexColumnExtendedInfo(strCatalog, sQLiteDataReader3.GetString(1), text2, ref sortMode, ref onError, ref collationSequence);
							}
							if (!string.IsNullOrEmpty(collationSequence))
							{
								dataRow[_0015(107356025)] = collationSequence;
							}
							dataRow[_0015(107353252)] = ((sortMode == 0) ? _0015(107353218) : _0015(107353140));
							dataRow[_0015(107353271)] = onError;
							num++;
							if (strColumn == null || string.Compare(strColumn, text2, StringComparison.OrdinalIgnoreCase) == 0)
							{
								dataTable.Rows.Add(dataRow);
							}
						}
					}
					catch (SQLiteException)
					{
					}
				}
			}
		}
		dataTable.EndLoadData();
		dataTable.AcceptChanges();
		return dataTable;
	}

	private DataTable Schema_ViewColumns(string strCatalog, string strView, string strColumn)
	{
		DataTable dataTable = new DataTable(_0015(107353611));
		dataTable.Locale = CultureInfo.InvariantCulture;
		dataTable.Columns.Add(_0015(107353626), typeof(string));
		dataTable.Columns.Add(_0015(107353577), typeof(string));
		dataTable.Columns.Add(_0015(107353592), typeof(string));
		dataTable.Columns.Add(_0015(107353547), typeof(string));
		dataTable.Columns.Add(_0015(107356536), typeof(string));
		dataTable.Columns.Add(_0015(107356483), typeof(string));
		dataTable.Columns.Add(_0015(107356498), typeof(string));
		dataTable.Columns.Add(_0015(107356449), typeof(string));
		dataTable.Columns.Add(_0015(107355882), typeof(int));
		dataTable.Columns.Add(_0015(107355889), typeof(bool));
		dataTable.Columns.Add(_0015(107355864), typeof(string));
		dataTable.Columns.Add(_0015(107355811), typeof(long));
		dataTable.Columns.Add(_0015(107355826), typeof(bool));
		dataTable.Columns.Add(_0015(107355777), typeof(string));
		dataTable.Columns.Add(_0015(107355751), typeof(int));
		dataTable.Columns.Add(_0015(107355685), typeof(int));
		dataTable.Columns.Add(_0015(107356172), typeof(int));
		dataTable.Columns.Add(_0015(107356183), typeof(long));
		dataTable.Columns.Add(_0015(107356126), typeof(string));
		dataTable.Columns.Add(_0015(107356097), typeof(string));
		dataTable.Columns.Add(_0015(107356068), typeof(string));
		dataTable.Columns.Add(_0015(107356043), typeof(string));
		dataTable.Columns.Add(_0015(107356050), typeof(string));
		dataTable.Columns.Add(_0015(107356025), typeof(string));
		dataTable.Columns.Add(_0015(107355405), typeof(bool));
		dataTable.Columns.Add(_0015(107355420), typeof(string));
		dataTable.Columns.Add(_0015(107355407), typeof(bool));
		dataTable.Columns.Add(_0015(107355386), typeof(bool));
		if (string.IsNullOrEmpty(strCatalog))
		{
			strCatalog = _0015(107362684);
		}
		string text = ((string.Compare(strCatalog, _0015(107362675), StringComparison.OrdinalIgnoreCase) == 0) ? _0015(107355356) : _0015(107355377));
		dataTable.BeginLoadData();
		using (SQLiteCommand sQLiteCommand = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107354432), strCatalog, text), this))
		{
			using SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
			while (sQLiteDataReader.Read())
			{
				if (!string.IsNullOrEmpty(strView) && string.Compare(strView, sQLiteDataReader.GetString(2), StringComparison.OrdinalIgnoreCase) != 0)
				{
					continue;
				}
				using SQLiteCommand sQLiteCommand2 = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107355198), strCatalog, sQLiteDataReader.GetString(2)), this);
				string text2 = sQLiteDataReader.GetString(4).Replace('\r', ' ').Replace('\n', ' ')
					.Replace('\t', ' ');
				int num = CultureInfo.InvariantCulture.CompareInfo.IndexOf(text2, _0015(107353883), CompareOptions.IgnoreCase);
				if (num < 0)
				{
					continue;
				}
				text2 = text2.Substring(num + 4);
				using SQLiteCommand sQLiteCommand3 = new SQLiteCommand(text2, this);
				using SQLiteDataReader sQLiteDataReader2 = sQLiteCommand2.ExecuteReader(CommandBehavior.SchemaOnly);
				using SQLiteDataReader sQLiteDataReader3 = sQLiteCommand3.ExecuteReader(CommandBehavior.SchemaOnly);
				using DataTable dataTable3 = sQLiteDataReader2.GetSchemaTable(wantUniqueInfo: false, wantDefaultValue: false);
				using DataTable dataTable2 = sQLiteDataReader3.GetSchemaTable(wantUniqueInfo: false, wantDefaultValue: false);
				for (num = 0; num < dataTable2.Rows.Count; num++)
				{
					DataRow dataRow = dataTable3.Rows[num];
					DataRow dataRow2 = dataTable2.Rows[num];
					if (string.Compare(dataRow[SchemaTableColumn.ColumnName].ToString(), strColumn, StringComparison.OrdinalIgnoreCase) == 0 || strColumn == null)
					{
						DataRow dataRow3 = dataTable.NewRow();
						dataRow3[_0015(107353626)] = strCatalog;
						dataRow3[_0015(107353592)] = sQLiteDataReader.GetString(2);
						dataRow3[_0015(107356536)] = strCatalog;
						dataRow3[_0015(107356483)] = dataRow2[SchemaTableColumn.BaseSchemaName];
						dataRow3[_0015(107356498)] = dataRow2[SchemaTableColumn.BaseTableName];
						dataRow3[_0015(107356449)] = dataRow2[SchemaTableColumn.BaseColumnName];
						dataRow3[_0015(107353547)] = dataRow[SchemaTableColumn.ColumnName];
						dataRow3[_0015(107355889)] = dataRow[SchemaTableOptionalColumn.DefaultValue] != DBNull.Value;
						dataRow3[_0015(107355864)] = dataRow[SchemaTableOptionalColumn.DefaultValue];
						dataRow3[_0015(107355882)] = dataRow[SchemaTableColumn.ColumnOrdinal];
						dataRow3[_0015(107355826)] = dataRow[SchemaTableColumn.AllowDBNull];
						dataRow3[_0015(107355777)] = dataRow[_0015(107355193)];
						dataRow3[_0015(107355420)] = SQLiteConvert.DbTypeToTypeName(this, (DbType)dataRow[SchemaTableColumn.ProviderType], _flags).ToString().ToLower(CultureInfo.InvariantCulture);
						dataRow3[_0015(107355751)] = dataRow[SchemaTableColumn.ColumnSize];
						dataRow3[_0015(107356483)] = dataRow[SchemaTableColumn.BaseSchemaName];
						dataRow3[_0015(107355405)] = dataRow[SchemaTableColumn.IsKey];
						dataRow3[_0015(107355407)] = dataRow[SchemaTableOptionalColumn.IsAutoIncrement];
						dataRow3[_0015(107356025)] = dataRow[_0015(107355656)];
						dataRow3[_0015(107355386)] = dataRow[SchemaTableColumn.IsUnique];
						dataTable.Rows.Add(dataRow3);
					}
				}
			}
		}
		dataTable.EndLoadData();
		dataTable.AcceptChanges();
		return dataTable;
	}

	private DataTable Schema_ForeignKeys(string strCatalog, string strTable, string strKeyName)
	{
		DataTable dataTable = new DataTable(_0015(107353554));
		dataTable.Locale = CultureInfo.InvariantCulture;
		dataTable.Columns.Add(_0015(107353323), typeof(string));
		dataTable.Columns.Add(_0015(107353330), typeof(string));
		dataTable.Columns.Add(_0015(107353305), typeof(string));
		dataTable.Columns.Add(_0015(107356536), typeof(string));
		dataTable.Columns.Add(_0015(107356483), typeof(string));
		dataTable.Columns.Add(_0015(107356498), typeof(string));
		dataTable.Columns.Add(_0015(107353505), typeof(string));
		dataTable.Columns.Add(_0015(107353484), typeof(bool));
		dataTable.Columns.Add(_0015(107353495), typeof(bool));
		dataTable.Columns.Add(_0015(107353438), typeof(int));
		dataTable.Columns.Add(_0015(107353457), typeof(string));
		dataTable.Columns.Add(_0015(107353432), typeof(int));
		dataTable.Columns.Add(_0015(107353395), typeof(string));
		dataTable.Columns.Add(_0015(107352830), typeof(string));
		dataTable.Columns.Add(_0015(107352809), typeof(string));
		dataTable.Columns.Add(_0015(107352820), typeof(string));
		dataTable.Columns.Add(_0015(107352767), typeof(string));
		dataTable.Columns.Add(_0015(107352746), typeof(string));
		dataTable.Columns.Add(_0015(107352757), typeof(string));
		if (string.IsNullOrEmpty(strCatalog))
		{
			strCatalog = _0015(107362684);
		}
		string text = ((string.Compare(strCatalog, _0015(107362675), StringComparison.OrdinalIgnoreCase) == 0) ? _0015(107355356) : _0015(107355377));
		dataTable.BeginLoadData();
		using (SQLiteCommand sQLiteCommand = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107354825), strCatalog, text), this))
		{
			using SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
			while (sQLiteDataReader.Read())
			{
				if (!string.IsNullOrEmpty(strTable) && string.Compare(strTable, sQLiteDataReader.GetString(2), StringComparison.OrdinalIgnoreCase) != 0)
				{
					continue;
				}
				try
				{
					using SQLiteCommandBuilder sQLiteCommandBuilder = new SQLiteCommandBuilder();
					using SQLiteCommand sQLiteCommand2 = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107352708), strCatalog, sQLiteDataReader.GetString(2)), this);
					using SQLiteDataReader sQLiteDataReader2 = sQLiteCommand2.ExecuteReader();
					while (sQLiteDataReader2.Read())
					{
						DataRow dataRow = dataTable.NewRow();
						dataRow[_0015(107353323)] = strCatalog;
						dataRow[_0015(107353305)] = HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0015(107352691), sQLiteDataReader[2], sQLiteDataReader2.GetInt32(0), sQLiteDataReader2.GetInt32(1));
						dataRow[_0015(107356536)] = strCatalog;
						dataRow[_0015(107356498)] = sQLiteCommandBuilder.UnquoteIdentifier(sQLiteDataReader.GetString(2));
						dataRow[_0015(107353505)] = _0015(107352638);
						dataRow[_0015(107353484)] = false;
						dataRow[_0015(107353495)] = false;
						dataRow[_0015(107353438)] = sQLiteDataReader2[0];
						dataRow[_0015(107353457)] = sQLiteCommandBuilder.UnquoteIdentifier(sQLiteDataReader2[3].ToString());
						dataRow[_0015(107353395)] = strCatalog;
						dataRow[_0015(107352809)] = sQLiteCommandBuilder.UnquoteIdentifier(sQLiteDataReader2[2].ToString());
						dataRow[_0015(107352820)] = sQLiteCommandBuilder.UnquoteIdentifier(sQLiteDataReader2[4].ToString());
						dataRow[_0015(107353432)] = sQLiteDataReader2[1];
						dataRow[_0015(107352767)] = ((sQLiteDataReader2.FieldCount > 5) ? sQLiteDataReader2[5] : string.Empty);
						dataRow[_0015(107352746)] = ((sQLiteDataReader2.FieldCount > 6) ? sQLiteDataReader2[6] : string.Empty);
						dataRow[_0015(107352757)] = ((sQLiteDataReader2.FieldCount > 7) ? sQLiteDataReader2[7] : string.Empty);
						if (string.IsNullOrEmpty(strKeyName) || string.Compare(strKeyName, dataRow[_0015(107353305)].ToString(), StringComparison.OrdinalIgnoreCase) == 0)
						{
							dataTable.Rows.Add(dataRow);
						}
					}
				}
				catch (SQLiteException)
				{
				}
			}
		}
		dataTable.EndLoadData();
		dataTable.AcceptChanges();
		return dataTable;
	}

	private SQLiteProgressReturnCode ProgressCallback(IntPtr pUserData)
	{
		try
		{
			ProgressEventArgs progressEventArgs = new ProgressEventArgs(pUserData, SQLiteProgressReturnCode.Continue);
			if (this._progressHandler != null)
			{
				this._progressHandler(this, progressEventArgs);
			}
			return progressEventArgs.ReturnCode;
		}
		catch (Exception ex)
		{
			try
			{
				if ((_flags & SQLiteConnectionFlags.LogCallbackException) == SQLiteConnectionFlags.LogCallbackException)
				{
					SQLiteLog.LogMessage(-2146233088, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107352621), ex));
				}
			}
			catch
			{
			}
		}
		if ((_flags & SQLiteConnectionFlags.InterruptOnException) == SQLiteConnectionFlags.InterruptOnException)
		{
			return SQLiteProgressReturnCode.Interrupt;
		}
		return SQLiteProgressReturnCode.Continue;
	}

	private SQLiteAuthorizerReturnCode AuthorizerCallback(IntPtr pUserData, SQLiteAuthorizerActionCode actionCode, IntPtr pArgument1, IntPtr pArgument2, IntPtr pDatabase, IntPtr pAuthContext)
	{
		try
		{
			AuthorizerEventArgs authorizerEventArgs = new AuthorizerEventArgs(pUserData, actionCode, SQLiteConvert.UTF8ToString(pArgument1, -1), SQLiteConvert.UTF8ToString(pArgument2, -1), SQLiteConvert.UTF8ToString(pDatabase, -1), SQLiteConvert.UTF8ToString(pAuthContext, -1), SQLiteAuthorizerReturnCode.Ok);
			if (this._authorizerHandler != null)
			{
				this._authorizerHandler(this, authorizerEventArgs);
			}
			return authorizerEventArgs.ReturnCode;
		}
		catch (Exception ex)
		{
			try
			{
				if ((_flags & SQLiteConnectionFlags.LogCallbackException) == SQLiteConnectionFlags.LogCallbackException)
				{
					SQLiteLog.LogMessage(-2146233088, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107353108), ex));
				}
			}
			catch
			{
			}
		}
		if ((_flags & SQLiteConnectionFlags.DenyOnException) == SQLiteConnectionFlags.DenyOnException)
		{
			return SQLiteAuthorizerReturnCode.Deny;
		}
		return SQLiteAuthorizerReturnCode.Ok;
	}

	private void UpdateCallback(IntPtr puser, int type, IntPtr database, IntPtr table, long rowid)
	{
		try
		{
			this._updateHandler(this, new UpdateEventArgs(SQLiteConvert.UTF8ToString(database, -1), SQLiteConvert.UTF8ToString(table, -1), (UpdateEventType)type, rowid));
		}
		catch (Exception ex)
		{
			try
			{
				if ((_flags & SQLiteConnectionFlags.LogCallbackException) == SQLiteConnectionFlags.LogCallbackException)
				{
					SQLiteLog.LogMessage(-2146233088, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107353047), ex));
				}
			}
			catch
			{
			}
		}
	}

	private void TraceCallback(IntPtr puser, IntPtr statement)
	{
		try
		{
			if (this._traceHandler != null)
			{
				this._traceHandler(this, new TraceEventArgs(SQLiteConvert.UTF8ToString(statement, -1)));
			}
		}
		catch (Exception ex)
		{
			try
			{
				if ((_flags & SQLiteConnectionFlags.LogCallbackException) == SQLiteConnectionFlags.LogCallbackException)
				{
					SQLiteLog.LogMessage(-2146233088, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107352958), ex));
				}
			}
			catch
			{
			}
		}
	}

	private int CommitCallback(IntPtr parg)
	{
		try
		{
			CommitEventArgs commitEventArgs = new CommitEventArgs();
			if (this._commitHandler != null)
			{
				this._commitHandler(this, commitEventArgs);
			}
			return commitEventArgs.AbortTransaction ? 1 : 0;
		}
		catch (Exception ex)
		{
			try
			{
				if ((_flags & SQLiteConnectionFlags.LogCallbackException) == SQLiteConnectionFlags.LogCallbackException)
				{
					SQLiteLog.LogMessage(-2146233088, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107352905), ex));
				}
			}
			catch
			{
			}
		}
		if ((_flags & SQLiteConnectionFlags.RollbackOnException) == SQLiteConnectionFlags.RollbackOnException)
		{
			return 1;
		}
		return 0;
	}

	private void RollbackCallback(IntPtr parg)
	{
		try
		{
			if (this._rollbackHandler != null)
			{
				this._rollbackHandler(this, EventArgs.Empty);
			}
		}
		catch (Exception ex)
		{
			try
			{
				if ((_flags & SQLiteConnectionFlags.LogCallbackException) == SQLiteConnectionFlags.LogCallbackException)
				{
					SQLiteLog.LogMessage(-2146233088, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0015(107352880), ex));
				}
			}
			catch
			{
			}
		}
	}

	static SQLiteConnection()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteConnection));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0015(107400847), _0015(107400810)).Replace(_0015(107400805), _0015(107400800)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0015(107400827)))
		{
			throw new SecurityException(_0015(107400770));
		}
		_assembly = typeof(SQLiteConnection).Assembly;
		_syncRoot = new object();
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
