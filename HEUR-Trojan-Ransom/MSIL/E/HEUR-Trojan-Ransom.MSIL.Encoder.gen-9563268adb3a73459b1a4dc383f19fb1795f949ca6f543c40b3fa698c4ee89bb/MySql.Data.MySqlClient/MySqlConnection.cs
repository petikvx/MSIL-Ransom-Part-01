using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Design;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using MySql.Data.Common;
using MySql.Data.Failover;
using MySql.Data.MySqlClient.Interceptors;
using MySql.Data.MySqlClient.Replication;

namespace MySql.Data.MySqlClient;

[ToolboxBitmap(typeof(MySqlConnection), "MySqlClient.resources.connection.bmp")]
[ToolboxItem(true)]
[DesignerCategory("Code")]
public sealed class MySqlConnection : DbConnection, ICloneable
{
	internal ConnectionState connectionState;

	internal Driver driver;

	internal bool hasBeenOpen;

	private SchemaProvider _schemaProvider;

	private ExceptionInterceptor _exceptionInterceptor;

	internal CommandInterceptor commandInterceptor;

	private bool _isKillQueryConnection;

	private string _database;

	private int _commandTimeout;

	private Ssh _sshHandler;

	private static readonly Cache<string, MySqlConnectionStringBuilder> ConnectionStringCache = new Cache<string, MySqlConnectionStringBuilder>(0, 25);

	internal PerformanceMonitor PerfMonitor { get; private set; }

	internal ProcedureCache ProcedureCache { get; private set; }

	internal MySqlConnectionStringBuilder Settings { get; private set; }

	internal MySqlDataReader Reader
	{
		get
		{
			return driver?.reader;
		}
		set
		{
			driver.reader = value;
			IsInUse = driver.reader != null;
		}
	}

	internal bool SoftClosed
	{
		get
		{
			if (State == ConnectionState.Closed && driver != null)
			{
				return driver.currentTransaction != null;
			}
			return false;
		}
	}

	internal bool IsInUse { get; set; }

	internal bool IsClone { get; set; }

	internal bool ParentHasbeenOpen { get; set; }

	[Browsable(false)]
	public int ServerThread => driver.ThreadID;

	[Browsable(true)]
	public override string DataSource => Settings.Server;

	[Browsable(true)]
	public override int ConnectionTimeout => (int)Settings.ConnectionTimeout;

	[Browsable(true)]
	public override string Database => _database;

	[Browsable(false)]
	public bool UseCompression => Settings.UseCompression;

	[Browsable(false)]
	public override ConnectionState State => connectionState;

	[Browsable(false)]
	public override string ServerVersion => driver.Version.ToString();

	[Category("Data")]
	[Browsable(true)]
	[Description("Information used to connect to a DataSource, such as 'Server=xxx;UserId=yyy;Password=zzz;Database=dbdb'.")]
	[Editor("MySql.Data.MySqlClient.Design.ConnectionStringTypeEditor,MySqlClient.Design", typeof(UITypeEditor))]
	public override string ConnectionString
	{
		get
		{
			return Settings.GetConnectionString(IsClone ? (Settings.PersistSecurityInfo ? Settings.PersistSecurityInfo : (!ParentHasbeenOpen && !hasBeenOpen)) : (!hasBeenOpen || Settings.PersistSecurityInfo));
		}
		set
		{
			if (State != 0)
			{
				Throw(new MySqlException("Not allowed to change the 'ConnectionString' property while the connection (state=" + State.ToString() + ")."));
			}
			MySqlConnectionStringBuilder mySqlConnectionStringBuilder;
			lock (ConnectionStringCache)
			{
				if (value == null)
				{
					mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
				}
				else
				{
					mySqlConnectionStringBuilder = ConnectionStringCache[value];
					if (mySqlConnectionStringBuilder == null || FailoverManager.FailoverGroup == null)
					{
						mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder(value);
						ConnectionStringCache.Add(value, mySqlConnectionStringBuilder);
					}
				}
			}
			Settings = mySqlConnectionStringBuilder;
			if (!string.IsNullOrEmpty(Settings.Database))
			{
				_database = Settings.Database;
			}
			if (driver != null)
			{
				driver.Settings = mySqlConnectionStringBuilder;
			}
		}
	}

	protected override DbProviderFactory DbProviderFactory => MySqlClientFactory.Instance;

	public bool IsPasswordExpired => driver.IsPasswordExpired;

	public event MySqlInfoMessageEventHandler InfoMessage;

	public MySqlConnection()
	{
		Settings = new MySqlConnectionStringBuilder();
		_database = string.Empty;
	}

	public MySqlConnection(string connectionString)
		: this()
	{
		Settings.AnalyzeConnectionString(connectionString ?? string.Empty, isXProtocol: false, isDefaultPort: false);
		ConnectionString = connectionString;
	}

	~MySqlConnection()
	{
		Dispose(disposing: false);
	}

	internal void OnInfoMessage(MySqlInfoMessageEventArgs args)
	{
		this.InfoMessage?.Invoke(this, args);
	}

	protected override DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel)
	{
		if (isolationLevel == System.Data.IsolationLevel.Unspecified)
		{
			return BeginTransaction();
		}
		return BeginTransaction(isolationLevel);
	}

	protected override DbCommand CreateDbCommand()
	{
		return CreateCommand();
	}

	protected override void Dispose(bool disposing)
	{
		if (State == ConnectionState.Open)
		{
			Close();
		}
		base.Dispose(disposing);
	}

	public new MySqlTransaction BeginTransaction()
	{
		return BeginTransaction(System.Data.IsolationLevel.RepeatableRead);
	}

	public MySqlTransaction BeginTransaction(System.Data.IsolationLevel iso, string scope = "")
	{
		if (State != ConnectionState.Open)
		{
			Throw(new InvalidOperationException(Resources.ConnectionNotOpen));
		}
		if (driver.HasStatus(ServerStatusFlags.InTransaction))
		{
			Throw(new InvalidOperationException(Resources.NoNestedTransactions));
		}
		MySqlTransaction result = new MySqlTransaction(this, iso);
		MySqlCommand mySqlCommand = new MySqlCommand("", this);
		mySqlCommand.CommandText = "SET " + scope + " TRANSACTION ISOLATION LEVEL ";
		switch (iso)
		{
		case System.Data.IsolationLevel.ReadCommitted:
			mySqlCommand.CommandText += "READ COMMITTED";
			break;
		case System.Data.IsolationLevel.ReadUncommitted:
			mySqlCommand.CommandText += "READ UNCOMMITTED";
			break;
		case System.Data.IsolationLevel.Chaos:
			Throw(new NotSupportedException(Resources.ChaosNotSupported));
			break;
		case System.Data.IsolationLevel.Snapshot:
			Throw(new NotSupportedException(Resources.SnapshotNotSupported));
			break;
		case System.Data.IsolationLevel.Serializable:
			mySqlCommand.CommandText += "SERIALIZABLE";
			break;
		case System.Data.IsolationLevel.RepeatableRead:
			mySqlCommand.CommandText += "REPEATABLE READ";
			break;
		}
		mySqlCommand.ExecuteNonQuery();
		mySqlCommand.CommandText = "BEGIN";
		mySqlCommand.CommandType = CommandType.Text;
		mySqlCommand.ExecuteNonQuery();
		return result;
	}

	public override void ChangeDatabase(string databaseName)
	{
		if (databaseName == null || databaseName.Trim().Length == 0)
		{
			Throw(new ArgumentException(Resources.ParameterIsInvalid, "databaseName"));
		}
		if (State != ConnectionState.Open)
		{
			Throw(new InvalidOperationException(Resources.ConnectionNotOpen));
		}
		lock (driver)
		{
			using (new CommandTimer(this, (int)Settings.DefaultCommandTimeout))
			{
				driver.SetDatabase(databaseName);
			}
		}
		_database = databaseName;
	}

	internal void SetState(ConnectionState newConnectionState, bool broadcast)
	{
		if (newConnectionState != connectionState || broadcast)
		{
			ConnectionState originalState = connectionState;
			connectionState = newConnectionState;
			if (broadcast)
			{
				OnStateChange(new StateChangeEventArgs(originalState, connectionState));
			}
		}
	}

	public bool Ping()
	{
		if (Reader != null)
		{
			Throw(new MySqlException(Resources.DataReaderOpen));
		}
		if (driver != null && driver.Ping())
		{
			return true;
		}
		driver = null;
		SetState(ConnectionState.Closed, broadcast: true);
		return false;
	}

	public override void Open()
	{
		if (State == ConnectionState.Open)
		{
			Throw(new InvalidOperationException(Resources.ConnectionAlreadyOpen));
		}
		_exceptionInterceptor = new ExceptionInterceptor(this);
		commandInterceptor = new CommandInterceptor(this);
		SetState(ConnectionState.Connecting, broadcast: true);
		AssertPermissions();
		if (Settings.AutoEnlist && Transaction.Current != null)
		{
			driver = DriverTransactionManager.GetDriverInTransaction(Transaction.Current);
			if (driver != null && (driver.IsInActiveUse || !driver.Settings.EquivalentTo(Settings)))
			{
				Throw(new NotSupportedException(Resources.MultipleConnectionsInTransactionNotSupported));
			}
		}
		MySqlConnectionStringBuilder settings = Settings;
		try
		{
			if (Settings.ConnectionProtocol == MySqlConnectionProtocol.Sockets && Settings.IsSshEnabled())
			{
				_sshHandler = new Ssh(Settings.SshHostName, Settings.SshUserName, Settings.SshPassword, Settings.SshKeyFile, Settings.SshPassphrase, Settings.SshPort, Settings.Server, Settings.Port, isXProtocol: false);
				_sshHandler.StartClient();
			}
			if (!Settings.Pooling || MySqlPoolManager.Hosts == null)
			{
				FailoverManager.Reset();
				if (Settings.DnsSrv)
				{
					FailoverManager.SetHostList(DnsResolver.GetDnsSrvRecords(Settings.Server).ConvertAll((DnsSrvRecord r) => new FailoverServer(r.Target, r.Port, null)), FailoverMethod.Sequential);
				}
				else
				{
					FailoverManager.ParseHostList(Settings.Server, isXProtocol: false);
				}
			}
			if (ReplicationManager.IsReplicationGroup(Settings.Server))
			{
				if (driver == null)
				{
					ReplicationManager.GetNewConnection(Settings.Server, master: false, this);
				}
				else
				{
					settings = driver.Settings;
				}
			}
			else if (FailoverManager.FailoverGroup != null && !Settings.Pooling)
			{
				FailoverManager.AttemptConnection(this, Settings.ConnectionString, out var connectionString);
				settings.ConnectionString = connectionString;
			}
			if (Settings.Pooling)
			{
				if (FailoverManager.FailoverGroup != null)
				{
					FailoverManager.AttemptConnection(this, Settings.ConnectionString, out var connectionString2, mySqlPoolManager: true);
					settings.ConnectionString = connectionString2;
				}
				MySqlPool pool = MySqlPoolManager.GetPool(settings);
				if (driver == null || !driver.IsOpen)
				{
					driver = pool.GetConnection();
				}
				ProcedureCache = pool.ProcedureCache;
			}
			else
			{
				if (driver == null || !driver.IsOpen)
				{
					driver = Driver.Create(settings);
				}
				ProcedureCache = new ProcedureCache((int)Settings.ProcedureCacheSize);
			}
		}
		catch (Exception)
		{
			SetState(ConnectionState.Closed, broadcast: true);
			throw;
		}
		SetState(ConnectionState.Open, broadcast: false);
		driver.Configure(this);
		if (driver.IsPasswordExpired && Settings.Pooling)
		{
			MySqlPoolManager.ClearPool(settings);
		}
		if ((!driver.SupportsPasswordExpiration || !driver.IsPasswordExpired) && !string.IsNullOrEmpty(Settings.Database))
		{
			ChangeDatabase(Settings.Database);
		}
		_schemaProvider = new ISSchemaProvider(this);
		PerfMonitor = new PerformanceMonitor(this);
		if (Transaction.Current != null && Settings.AutoEnlist)
		{
			EnlistTransaction(Transaction.Current);
		}
		hasBeenOpen = true;
		SetState(ConnectionState.Open, broadcast: true);
	}

	private int ParseHostList(string hierPart)
	{
		if (string.IsNullOrWhiteSpace(hierPart))
		{
			return -1;
		}
		int num = -1;
		FailoverMethod failoverMethod = FailoverMethod.Random;
		string[] array = null;
		List<FailoverServer> list = new List<FailoverServer>();
		hierPart = hierPart.Replace(" ", "");
		if (!hierPart.StartsWith("(") && !hierPart.EndsWith(")"))
		{
			array = hierPart.Split(new char[1] { ',' });
			string[] array2 = array;
			foreach (string host in array2)
			{
				list.Add(ConvertToFailoverServer(host));
			}
			if (array.Length == 1)
			{
				return 1;
			}
			num = array.Length;
		}
		else
		{
			string[] array3 = hierPart.Split(new string[1] { "),(" }, StringSplitOptions.RemoveEmptyEntries);
			bool? flag = null;
			int num2 = 100;
			string[] array2 = array3;
			foreach (string text in array2)
			{
				string text2 = text;
				if (text2.StartsWith("("))
				{
					text2 = text.Substring(1);
				}
				if (text2.EndsWith(")"))
				{
					text2 = text2.Substring(0, text2.Length - 1);
				}
				string[] array4 = text2.Split(new char[1] { ',' });
				string[] array5 = array4[0].Split(new char[1] { '=' });
				if (!(array5[0].ToLowerInvariant() != "address"))
				{
					string text3 = array5[1];
					if (!string.IsNullOrWhiteSpace(text3))
					{
						if (array4.Length == 2)
						{
							if (flag.HasValue && flag == false)
							{
								throw new ArgumentException(ResourcesX.PriorityForAllOrNoHosts);
							}
							flag = flag ?? true;
							string[] array6 = array4[1].Split(new char[1] { '=' });
							if (array6[0].ToLowerInvariant() != "priority")
							{
								throw new KeyNotFoundException(string.Format(ResourcesX.KeywordNotFound, "priority"));
							}
							if (string.IsNullOrWhiteSpace(array6[1]))
							{
								throw new ArgumentNullException("priority");
							}
							int result = -1;
							if (!int.TryParse(array6[1], out result) || result < 0 || result > 100)
							{
								throw new ArgumentException(ResourcesX.PriorityOutOfLimits);
							}
							list.Add(ConvertToFailoverServer(text3, result));
						}
						else
						{
							if (flag.HasValue && flag == true)
							{
								throw new ArgumentException(ResourcesX.PriorityForAllOrNoHosts);
							}
							flag = flag.GetValueOrDefault();
							list.Add(ConvertToFailoverServer(text3, (num2 > 0) ? num2-- : 0));
						}
						continue;
					}
					throw new ArgumentNullException("server");
				}
				throw new KeyNotFoundException(string.Format(ResourcesX.KeywordNotFound, "address"));
			}
			num = array3.Length;
			failoverMethod = FailoverMethod.Priority;
		}
		FailoverManager.SetHostList(list, failoverMethod);
		return num;
	}

	private FailoverServer ConvertToFailoverServer(string host, int priority = -1, int port = -1)
	{
		host = host.Trim();
		int num = -1;
		if (IPAddress.TryParse(host, out var address))
		{
			if (address.AddressFamily == AddressFamily.InterNetworkV6)
			{
				if (host.StartsWith("[") && host.Contains("]") && !host.EndsWith("]"))
				{
					num = host.LastIndexOf(":");
				}
			}
			else
			{
				num = host.IndexOf(":");
			}
		}
		else
		{
			num = host.IndexOf(":");
		}
		if (num != -1)
		{
			int.TryParse(host.Substring(num + 1), out port);
			host = host.Substring(0, num);
		}
		return new FailoverServer(host, port, priority);
	}

	public new MySqlCommand CreateCommand()
	{
		return new MySqlCommand
		{
			Connection = this
		};
	}

	internal void Abort()
	{
		try
		{
			driver.Close();
		}
		catch (Exception ex)
		{
			MySqlTrace.LogWarning(ServerThread, "Error occurred aborting the connection. Exception was: " + ex.Message);
		}
		finally
		{
			IsInUse = false;
		}
		SetState(ConnectionState.Closed, broadcast: true);
	}

	internal void CloseFully()
	{
		if (Settings.Pooling && driver.IsOpen)
		{
			if (driver.HasStatus(ServerStatusFlags.InTransaction))
			{
				new MySqlTransaction(this, System.Data.IsolationLevel.Unspecified).Rollback();
			}
			MySqlPoolManager.ReleaseConnection(driver);
		}
		else
		{
			driver.Close();
		}
		driver = null;
	}

	public override void Close()
	{
		if (driver != null)
		{
			driver.IsPasswordExpired = false;
		}
		if (State == ConnectionState.Closed)
		{
			return;
		}
		if (Reader != null)
		{
			Reader.Close();
		}
		if (driver != null)
		{
			if (driver.currentTransaction == null)
			{
				CloseFully();
			}
			else
			{
				driver.IsInActiveUse = false;
			}
		}
		if (Settings.ConnectionProtocol == MySqlConnectionProtocol.Sockets && Settings.IsSshEnabled())
		{
			_sshHandler?.StopClient();
		}
		FailoverManager.Reset();
		MySqlPoolManager.Hosts = null;
		SetState(ConnectionState.Closed, broadcast: true);
	}

	internal string CurrentDatabase()
	{
		if (!string.IsNullOrEmpty(Database))
		{
			return Database;
		}
		return new MySqlCommand("SELECT database()", this).ExecuteScalar().ToString();
	}

	internal void HandleTimeoutOrThreadAbort(Exception ex)
	{
		bool isFatal = false;
		if (_isKillQueryConnection)
		{
			Abort();
			if (!(ex is TimeoutException))
			{
				return;
			}
			Throw(new MySqlException(Resources.Timeout, isFatal: true, ex));
		}
		try
		{
			CancelQuery(5);
			driver.ResetTimeout(5000);
			if (Reader != null)
			{
				Reader.Close();
				Reader = null;
			}
		}
		catch (Exception ex2)
		{
			MySqlTrace.LogWarning(ServerThread, "Could not kill query,  aborting connection. Exception was " + ex2.Message);
			Abort();
			isFatal = true;
		}
		if (ex is TimeoutException)
		{
			Throw(new MySqlException(Resources.Timeout, isFatal, ex));
		}
	}

	public void CancelQuery(int timeout)
	{
		using MySqlConnection mySqlConnection = new MySqlConnection(new MySqlConnectionStringBuilder(Settings.ConnectionString)
		{
			Pooling = false,
			AutoEnlist = false,
			ConnectionTimeout = (uint)timeout
		}.ConnectionString);
		mySqlConnection._isKillQueryConnection = true;
		mySqlConnection.Open();
		MySqlCommand mySqlCommand = new MySqlCommand("KILL QUERY " + ServerThread, mySqlConnection);
		mySqlCommand.CommandTimeout = timeout;
		mySqlCommand.ExecuteNonQuery();
	}

	internal bool SetCommandTimeout(int value)
	{
		if (!hasBeenOpen)
		{
			return false;
		}
		if (_commandTimeout != 0)
		{
			return false;
		}
		if (driver == null)
		{
			return false;
		}
		_commandTimeout = value;
		driver.ResetTimeout(_commandTimeout * 1000);
		return true;
	}

	internal void ClearCommandTimeout()
	{
		if (hasBeenOpen)
		{
			_commandTimeout = 0;
			driver?.ResetTimeout(0);
		}
	}

	public MySqlSchemaCollection GetSchemaCollection(string collectionName, string[] restrictionValues)
	{
		if (collectionName == null)
		{
			collectionName = SchemaProvider.MetaCollection;
		}
		string[] restrictions = _schemaProvider.CleanRestrictions(restrictionValues);
		return _schemaProvider.GetSchema(collectionName, restrictions);
	}

	public static void ClearPool(MySqlConnection connection)
	{
		MySqlPoolManager.ClearPool(connection.Settings);
	}

	public static void ClearAllPools()
	{
		MySqlPoolManager.ClearAllPools();
	}

	internal void Throw(Exception ex)
	{
		if (_exceptionInterceptor == null)
		{
			throw ex;
		}
		_exceptionInterceptor.Throw(ex);
	}

	public new void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public Task<MySqlTransaction> BeginTransactionAsync()
	{
		return BeginTransactionAsync(System.Data.IsolationLevel.RepeatableRead, CancellationToken.None);
	}

	public new Task<MySqlTransaction> BeginTransactionAsync(CancellationToken cancellationToken)
	{
		return BeginTransactionAsync(System.Data.IsolationLevel.RepeatableRead, cancellationToken);
	}

	public Task<MySqlTransaction> BeginTransactionAsync(System.Data.IsolationLevel iso)
	{
		return BeginTransactionAsync(iso, CancellationToken.None);
	}

	public new Task<MySqlTransaction> BeginTransactionAsync(System.Data.IsolationLevel iso, CancellationToken cancellationToken)
	{
		TaskCompletionSource<MySqlTransaction> taskCompletionSource = new TaskCompletionSource<MySqlTransaction>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				MySqlTransaction result = BeginTransaction(iso);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task ChangeDataBaseAsync(string databaseName)
	{
		return ChangeDataBaseAsync(databaseName, CancellationToken.None);
	}

	public Task ChangeDataBaseAsync(string databaseName, CancellationToken cancellationToken)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
		if (cancellationToken == CancellationToken.None || !cancellationToken.IsCancellationRequested)
		{
			try
			{
				ChangeDatabase(databaseName);
				taskCompletionSource.SetResult(result: true);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public new Task CloseAsync()
	{
		return CloseAsync(CancellationToken.None);
	}

	public Task CloseAsync(CancellationToken cancellationToken)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				Close();
				taskCompletionSource.SetResult(result: true);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task ClearPoolAsync(MySqlConnection connection)
	{
		return ClearPoolAsync(connection, CancellationToken.None);
	}

	public Task ClearPoolAsync(MySqlConnection connection, CancellationToken cancellationToken)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				ClearPool(connection);
				taskCompletionSource.SetResult(result: true);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task ClearAllPoolsAsync()
	{
		return ClearAllPoolsAsync(CancellationToken.None);
	}

	public Task ClearAllPoolsAsync(CancellationToken cancellationToken)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				ClearAllPools();
				taskCompletionSource.SetResult(result: true);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<MySqlSchemaCollection> GetSchemaCollectionAsync(string collectionName, string[] restrictionValues)
	{
		return GetSchemaCollectionAsync(collectionName, restrictionValues, CancellationToken.None);
	}

	public Task<MySqlSchemaCollection> GetSchemaCollectionAsync(string collectionName, string[] restrictionValues, CancellationToken cancellationToken)
	{
		TaskCompletionSource<MySqlSchemaCollection> taskCompletionSource = new TaskCompletionSource<MySqlSchemaCollection>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				MySqlSchemaCollection schemaCollection = GetSchemaCollection(collectionName, restrictionValues);
				taskCompletionSource.SetResult(schemaCollection);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public override DataTable GetSchema()
	{
		return GetSchema(null);
	}

	public override DataTable GetSchema(string collectionName)
	{
		if (collectionName == null)
		{
			collectionName = SchemaProvider.MetaCollection;
		}
		return GetSchema(collectionName, null);
	}

	public override DataTable GetSchema(string collectionName, string[] restrictionValues)
	{
		if (collectionName == null)
		{
			collectionName = SchemaProvider.MetaCollection;
		}
		string[] restrictions = _schemaProvider.CleanRestrictions(restrictionValues);
		return _schemaProvider.GetSchema(collectionName, restrictions).AsDataTable();
	}

	public override void EnlistTransaction(Transaction transaction)
	{
		if (transaction == null)
		{
			return;
		}
		if (driver.currentTransaction != null)
		{
			if (driver.currentTransaction.BaseTransaction == transaction)
			{
				return;
			}
			Throw(new MySqlException("Already enlisted"));
		}
		Driver driverInTransaction = DriverTransactionManager.GetDriverInTransaction(transaction);
		if (driverInTransaction != null)
		{
			if (driverInTransaction.IsInActiveUse)
			{
				Throw(new NotSupportedException(Resources.MultipleConnectionsInTransactionNotSupported));
			}
			string connectionString = driverInTransaction.Settings.ConnectionString;
			string connectionString2 = Settings.ConnectionString;
			if (string.Compare(connectionString, connectionString2, ignoreCase: true) != 0)
			{
				Throw(new NotSupportedException(Resources.MultipleConnectionsInTransactionNotSupported));
			}
			CloseFully();
			driver = driverInTransaction;
		}
		if (driver.currentTransaction == null)
		{
			MySqlPromotableTransaction mySqlPromotableTransaction = new MySqlPromotableTransaction(this, transaction);
			if (!transaction.EnlistPromotableSinglePhase(mySqlPromotableTransaction))
			{
				Throw(new NotSupportedException(Resources.DistributedTxnNotSupported));
			}
			driver.currentTransaction = mySqlPromotableTransaction;
			DriverTransactionManager.SetDriverInTransaction(driver);
			driver.IsInActiveUse = true;
		}
	}

	private void AssertPermissions()
	{
		if (Settings.IncludeSecurityAsserts)
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission((IPermission?)(object)new MySqlClientPermission(ConnectionString));
			permissionSet.Demand();
			MySqlSecurityPermission.CreatePermissionSet(includeReflectionPermission: true).Assert();
		}
	}

	public object Clone()
	{
		MySqlConnection mySqlConnection = new MySqlConnection();
		mySqlConnection.IsClone = true;
		mySqlConnection.ParentHasbeenOpen = hasBeenOpen;
		string connectionString = Settings.ConnectionString;
		if (connectionString != null)
		{
			mySqlConnection.ConnectionString = connectionString;
		}
		return mySqlConnection;
	}
}
