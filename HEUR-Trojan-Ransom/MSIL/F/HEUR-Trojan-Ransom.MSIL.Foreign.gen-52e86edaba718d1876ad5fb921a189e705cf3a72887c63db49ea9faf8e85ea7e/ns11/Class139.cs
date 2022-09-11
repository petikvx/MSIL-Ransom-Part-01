using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Interceptors;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns12;
using ns17;
using ns18;
using ns19;
using ns2;
using ns20;
using ns21;
using ns22;
using ns23;
using ns26;
using ns3;
using ns4;
using ns6;
using ns7;
using ns9;

namespace ns11;

[ToolboxBitmap(typeof(Class139), "MySqlClient.resources.connection.bmp")]
[DesignerCategory("Code")]
[ToolboxItem(true)]
internal sealed class Class139 : DbConnection, ICloneable
{
	internal ConnectionState connectionState_0;

	internal Class143 class143_0;

	internal bool bool_0;

	private Class159 class159_0;

	private ExceptionInterceptor exceptionInterceptor_0;

	internal Class158 class158_0;

	private bool bool_1;

	private string string_0;

	private int int_0;

	[CompilerGenerated]
	private Delegate3 delegate3_0;

	private static readonly Class124<string, MySqlConnectionStringBuilder> class124_0;

	[CompilerGenerated]
	private Class146 class146_0;

	[CompilerGenerated]
	private Class174 class174_0;

	[CompilerGenerated]
	private MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0;

	[CompilerGenerated]
	private bool bool_2;

	[NonSerialized]
	internal static GetString getString_0;

	internal Class146 PerfMonitor
	{
		[CompilerGenerated]
		get
		{
			return class146_0;
		}
		[CompilerGenerated]
		private set
		{
			class146_0 = value;
		}
	}

	internal Class174 ProcedureCache
	{
		[CompilerGenerated]
		get
		{
			return class174_0;
		}
		[CompilerGenerated]
		private set
		{
			class174_0 = value;
		}
	}

	internal MySqlConnectionStringBuilder Settings
	{
		[CompilerGenerated]
		get
		{
			return mySqlConnectionStringBuilder_0;
		}
		[CompilerGenerated]
		private set
		{
			mySqlConnectionStringBuilder_0 = value;
		}
	}

	internal Class142 Reader
	{
		get
		{
			return class143_0?.class142_0;
		}
		set
		{
			class143_0.class142_0 = value;
			IsInUse = class143_0.class142_0 != null;
		}
	}

	internal bool SoftClosed
	{
		get
		{
			if (State == ConnectionState.Closed && class143_0 != null)
			{
				return class143_0.currentTransaction != null;
			}
			return false;
		}
	}

	internal bool IsInUse
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	[Browsable(false)]
	public int ServerThread => class143_0.ThreadID;

	[Browsable(true)]
	string DbConnection.DataSource => Settings.Server;

	[Browsable(true)]
	int DbConnection.ConnectionTimeout => (int)Settings.ConnectionTimeout;

	[Browsable(true)]
	string DbConnection.Database => string_0;

	[Browsable(false)]
	public bool UseCompression => Settings.UseCompression;

	[Browsable(false)]
	ConnectionState DbConnection.State => connectionState_0;

	[Browsable(false)]
	string DbConnection.ServerVersion => class143_0.Version.ToString();

	[Category("Data")]
	[Editor("MySql.Data.MySqlClient.Design.ConnectionStringTypeEditor,MySqlClient.Design", typeof(UITypeEditor))]
	[Browsable(true)]
	[Description("Information used to connect to a DataSource, such as 'Server=xxx;UserId=yyy;Password=zzz;Database=dbdb'.")]
	string DbConnection.ConnectionString
	{
		get
		{
			return Settings.method_5(!bool_0 || Settings.PersistSecurityInfo);
		}
		set
		{
			if (State != 0)
			{
				method_15(new MySqlException(string.Concat(getString_0(107354158), State, getString_0(107354589))));
			}
			MySqlConnectionStringBuilder mySqlConnectionStringBuilder;
			lock (class124_0)
			{
				if (value == null)
				{
					mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
				}
				else
				{
					mySqlConnectionStringBuilder = class124_0[value];
					if (mySqlConnectionStringBuilder == null)
					{
						mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder(value);
						class124_0.method_0(value, mySqlConnectionStringBuilder);
					}
				}
			}
			Settings = mySqlConnectionStringBuilder;
			if (!string.IsNullOrEmpty(Settings.Database))
			{
				string_0 = Settings.Database;
			}
			if (class143_0 != null)
			{
				class143_0.Settings = mySqlConnectionStringBuilder;
			}
		}
	}

	DbProviderFactory DbConnection.DbProviderFactory => Class161.class161_0;

	public bool IsPasswordExpired => class143_0.IsPasswordExpired;

	public event Delegate3 InfoMessage
	{
		[CompilerGenerated]
		add
		{
			Delegate3 @delegate = delegate3_0;
			Delegate3 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate3 value2 = (Delegate3)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate3_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate3 @delegate = delegate3_0;
			Delegate3 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate3 value2 = (Delegate3)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate3_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public Class139()
	{
		Settings = new MySqlConnectionStringBuilder();
		string_0 = string.Empty;
	}

	public Class139(string string_1)
		: this()
	{
		ConnectionString = string_1;
		method_11();
	}

	void object.Finalize()
	{
		try
		{
			Dispose(disposing: false);
		}
		finally
		{
			Finalize();
		}
	}

	internal void method_0(EventArgs0 eventArgs0_0)
	{
		delegate3_0?.Invoke(this, eventArgs0_0);
	}

	DbTransaction DbConnection.BeginDbTransaction(System.Data.IsolationLevel isolationLevel)
	{
		if (isolationLevel == System.Data.IsolationLevel.Unspecified)
		{
			return method_1();
		}
		return method_2(isolationLevel);
	}

	DbCommand DbConnection.CreateDbCommand()
	{
		return method_5();
	}

	void Component.Dispose(bool disposing)
	{
		if (State == ConnectionState.Open)
		{
			Close();
		}
		base.Dispose(disposing);
	}

	public Class181 method_1()
	{
		return method_2(System.Data.IsolationLevel.RepeatableRead);
	}

	public Class181 method_2(System.Data.IsolationLevel isolationLevel_0)
	{
		if (State != ConnectionState.Open)
		{
			method_15(new InvalidOperationException(Class121.ConnectionNotOpen));
		}
		if (class143_0.method_2(Enum38.flag_0))
		{
			method_15(new InvalidOperationException(Class121.NoNestedTransactions));
		}
		Class181 result = new Class181(this, isolationLevel_0);
		MySqlCommand mySqlCommand = new MySqlCommand(getString_0(107398120), this);
		mySqlCommand.CommandText = getString_0(107354584);
		switch (isolationLevel_0)
		{
		case System.Data.IsolationLevel.ReadCommitted:
			mySqlCommand.CommandText += getString_0(107354527);
			break;
		case System.Data.IsolationLevel.ReadUncommitted:
			mySqlCommand.CommandText += getString_0(107354474);
			break;
		case System.Data.IsolationLevel.Chaos:
			method_15(new NotSupportedException(Class121.ChaosNotSupported));
			break;
		case System.Data.IsolationLevel.Snapshot:
			method_15(new NotSupportedException(Class121.SnapshotNotSupported));
			break;
		case System.Data.IsolationLevel.Serializable:
			mySqlCommand.CommandText += getString_0(107354460);
			break;
		case System.Data.IsolationLevel.RepeatableRead:
			mySqlCommand.CommandText += getString_0(107354449);
			break;
		}
		mySqlCommand.ExecuteNonQuery();
		mySqlCommand.CommandText = getString_0(107354411);
		mySqlCommand.CommandType = CommandType.Text;
		mySqlCommand.ExecuteNonQuery();
		return result;
	}

	void DbConnection.ChangeDatabase(string databaseName)
	{
		if (databaseName == null || databaseName.Trim().Length == 0)
		{
			method_15(new ArgumentException(Class121.ParameterIsInvalid, getString_0(107354434)));
		}
		if (State != ConnectionState.Open)
		{
			method_15(new InvalidOperationException(Class121.ConnectionNotOpen));
		}
		lock (class143_0)
		{
			using (new Class140(this, (int)Settings.DefaultCommandTimeout))
			{
				class143_0.vmethod_11(databaseName);
			}
		}
		string_0 = databaseName;
	}

	internal void method_3(ConnectionState connectionState_1, bool bool_3)
	{
		if (connectionState_1 != connectionState_0 || bool_3)
		{
			ConnectionState originalState = connectionState_0;
			connectionState_0 = connectionState_1;
			if (bool_3)
			{
				OnStateChange(new StateChangeEventArgs(originalState, connectionState_0));
			}
		}
	}

	public bool method_4()
	{
		if (Reader != null)
		{
			method_15(new MySqlException(Class121.DataReaderOpen));
		}
		if (class143_0 != null && class143_0.method_10())
		{
			return true;
		}
		class143_0 = null;
		method_3(ConnectionState.Closed, bool_3: true);
		return false;
	}

	void DbConnection.Open()
	{
		if (State == ConnectionState.Open)
		{
			method_15(new InvalidOperationException(Class121.ConnectionAlreadyOpen));
		}
		exceptionInterceptor_0 = new ExceptionInterceptor(this);
		class158_0 = new Class158(this);
		method_3(ConnectionState.Connecting, bool_3: true);
		method_31();
		if (Settings.AutoEnlist && Transaction.Current != null)
		{
			class143_0 = Class154.smethod_0(Transaction.Current);
			if (class143_0 != null && (class143_0.IsInActiveUse || !class143_0.Settings.EquivalentTo(Settings)))
			{
				method_15(new NotSupportedException(Class121.MultipleConnectionsInTransactionNotSupported));
			}
		}
		try
		{
			MySqlConnectionStringBuilder settings = Settings;
			if (Class183.smethod_4(Settings.Server))
			{
				if (class143_0 == null)
				{
					Class183.smethod_5(Settings.Server, bool_0: false, this);
				}
				else
				{
					settings = class143_0.Settings;
				}
			}
			if (Settings.Pooling)
			{
				MySqlPool mySqlPool = MySqlPoolManager.smethod_2(settings);
				if (class143_0 == null || !class143_0.IsOpen)
				{
					class143_0 = mySqlPool.method_6();
				}
				ProcedureCache = mySqlPool.ProcedureCache;
			}
			else
			{
				if (class143_0 == null || !class143_0.IsOpen)
				{
					class143_0 = Class143.smethod_0(settings);
				}
				ProcedureCache = new Class174((int)Settings.ProcedureCacheSize);
			}
		}
		catch (Exception)
		{
			method_3(ConnectionState.Closed, bool_3: true);
			throw;
		}
		method_3(ConnectionState.Open, bool_3: false);
		class143_0.vmethod_2(this);
		if ((!class143_0.SupportsPasswordExpiration || !class143_0.IsPasswordExpired) && !string.IsNullOrEmpty(Settings.Database))
		{
			ChangeDatabase(Settings.Database);
		}
		class159_0 = new Class160(this);
		PerfMonitor = new Class146(this);
		if (Transaction.Current != null && Settings.AutoEnlist)
		{
			EnlistTransaction(Transaction.Current);
		}
		bool_0 = true;
		method_3(ConnectionState.Open, bool_3: true);
	}

	public MySqlCommand method_5()
	{
		return new MySqlCommand
		{
			Connection = this
		};
	}

	internal void method_6()
	{
		try
		{
			class143_0.vmethod_1();
		}
		catch (Exception ex)
		{
			MySqlTrace.smethod_3(ServerThread, getString_0(107354385) + ex.Message);
		}
		finally
		{
			IsInUse = false;
		}
		method_3(ConnectionState.Closed, bool_3: true);
	}

	internal void method_7()
	{
		if (Settings.Pooling && class143_0.IsOpen)
		{
			if (class143_0.method_2(Enum38.flag_0))
			{
				new Class181(this, System.Data.IsolationLevel.Unspecified).Rollback();
			}
			MySqlPoolManager.smethod_4(class143_0);
		}
		else
		{
			class143_0.vmethod_1();
		}
		class143_0 = null;
	}

	void DbConnection.Close()
	{
		if (class143_0 != null)
		{
			class143_0.IsPasswordExpired = false;
		}
		if (State == ConnectionState.Closed)
		{
			return;
		}
		if (Reader != null)
		{
			Reader.Close();
		}
		if (class143_0 != null)
		{
			if (class143_0.currentTransaction == null)
			{
				method_7();
			}
			else
			{
				class143_0.IsInActiveUse = false;
			}
		}
		method_3(ConnectionState.Closed, bool_3: true);
	}

	internal string method_8()
	{
		if (!string.IsNullOrEmpty(Database))
		{
			return Database;
		}
		return new MySqlCommand(getString_0(107353828), this).ExecuteScalar()!.ToString();
	}

	internal void method_9(Exception exception_0)
	{
		bool isFatal = false;
		if (bool_1)
		{
			method_6();
			if (!(exception_0 is TimeoutException))
			{
				return;
			}
			method_15(new MySqlException(Class121.Timeout, isFatal: true, exception_0));
		}
		try
		{
			method_10(5);
			class143_0.method_9(5000);
			if (Reader != null)
			{
				Reader.Close();
				Reader = null;
			}
		}
		catch (Exception ex)
		{
			MySqlTrace.smethod_3(ServerThread, getString_0(107353771) + ex.Message);
			method_6();
			isFatal = true;
		}
		if (exception_0 is TimeoutException)
		{
			method_15(new MySqlException(Class121.Timeout, isFatal, exception_0));
		}
	}

	public void method_10(int int_1)
	{
		using Class139 @class = new Class139(new MySqlConnectionStringBuilder(Settings.ConnectionString)
		{
			Pooling = false,
			AutoEnlist = false,
			ConnectionTimeout = (uint)int_1
		}.ConnectionString);
		@class.bool_1 = true;
		@class.Open();
		MySqlCommand mySqlCommand = new MySqlCommand(getString_0(107353722) + ServerThread, @class);
		mySqlCommand.CommandTimeout = int_1;
		mySqlCommand.ExecuteNonQuery();
	}

	private void method_11()
	{
		if (Settings == null || Settings.Auth == MySqlAuthenticationMode.Default)
		{
			return;
		}
		throw new NotSupportedException(string.Format(Class121.OptionNotCurrentlySupported, getString_0(107353673)));
	}

	internal bool method_12(int int_1)
	{
		if (!bool_0)
		{
			return false;
		}
		if (int_0 != 0)
		{
			return false;
		}
		if (class143_0 == null)
		{
			return false;
		}
		int_0 = int_1;
		class143_0.method_9(int_0 * 1000);
		return true;
	}

	internal void method_13()
	{
		if (bool_0)
		{
			int_0 = 0;
			class143_0?.method_9(0);
		}
	}

	public Class176 method_14(string string_1, string[] string_2)
	{
		if (string_1 == null)
		{
			string_1 = Class159.string_0;
		}
		string[] string_3 = class159_0.method_6(string_2);
		return class159_0.vmethod_0(string_1, string_3);
	}

	public static void smethod_0(Class139 class139_0)
	{
		MySqlPoolManager.smethod_5(class139_0.Settings);
	}

	public static void smethod_1()
	{
		MySqlPoolManager.smethod_7();
	}

	internal void method_15(Exception exception_0)
	{
		if (exceptionInterceptor_0 == null)
		{
			throw exception_0;
		}
		exceptionInterceptor_0.method_1(exception_0);
	}

	public void method_16()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public Task<Class181> method_17()
	{
		return method_20(System.Data.IsolationLevel.RepeatableRead, CancellationToken.None);
	}

	public Task<Class181> method_18(CancellationToken cancellationToken_0)
	{
		return method_20(System.Data.IsolationLevel.RepeatableRead, cancellationToken_0);
	}

	public Task<Class181> method_19(System.Data.IsolationLevel isolationLevel_0)
	{
		return method_20(isolationLevel_0, CancellationToken.None);
	}

	public Task<Class181> method_20(System.Data.IsolationLevel isolationLevel_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<Class181> taskCompletionSource = new TaskCompletionSource<Class181>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				Class181 result = method_2(isolationLevel_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task method_21(string string_1)
	{
		return method_22(string_1, CancellationToken.None);
	}

	public Task method_22(string string_1, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
		if (cancellationToken_0 == CancellationToken.None || !cancellationToken_0.IsCancellationRequested)
		{
			try
			{
				ChangeDatabase(string_1);
				taskCompletionSource.SetResult(result: true);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task method_23()
	{
		return method_24(CancellationToken.None);
	}

	public Task method_24(CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
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

	public Task method_25(Class139 class139_0)
	{
		return method_26(class139_0, CancellationToken.None);
	}

	public Task method_26(Class139 class139_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				smethod_0(class139_0);
				taskCompletionSource.SetResult(result: true);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task method_27()
	{
		return method_28(CancellationToken.None);
	}

	public Task method_28(CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				smethod_1();
				taskCompletionSource.SetResult(result: true);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<Class176> method_29(string string_1, string[] string_2)
	{
		return method_30(string_1, string_2, CancellationToken.None);
	}

	public Task<Class176> method_30(string string_1, string[] string_2, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<Class176> taskCompletionSource = new TaskCompletionSource<Class176>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				Class176 result = method_14(string_1, string_2);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	DataTable DbConnection.GetSchema()
	{
		return GetSchema(null);
	}

	DataTable DbConnection.GetSchema(string collectionName)
	{
		if (collectionName == null)
		{
			collectionName = Class159.string_0;
		}
		return GetSchema(collectionName, null);
	}

	DataTable DbConnection.GetSchema(string collectionName, string[] restrictionValues)
	{
		if (collectionName == null)
		{
			collectionName = Class159.string_0;
		}
		string[] string_ = class159_0.method_6(restrictionValues);
		return class159_0.vmethod_0(collectionName, string_).method_6();
	}

	void DbConnection.EnlistTransaction(Transaction transaction)
	{
		if (transaction == null)
		{
			return;
		}
		if (class143_0.currentTransaction != null)
		{
			if (class143_0.currentTransaction.BaseTransaction == transaction)
			{
				return;
			}
			method_15(new MySqlException(getString_0(107353696)));
		}
		Class143 @class = Class154.smethod_0(transaction);
		if (@class != null)
		{
			if (@class.IsInActiveUse)
			{
				method_15(new NotSupportedException(Class121.MultipleConnectionsInTransactionNotSupported));
			}
			string connectionString = @class.Settings.ConnectionString;
			string connectionString2 = Settings.ConnectionString;
			if (string.Compare(connectionString, connectionString2, ignoreCase: true) != 0)
			{
				method_15(new NotSupportedException(Class121.MultipleConnectionsInTransactionNotSupported));
			}
			method_7();
			class143_0 = @class;
		}
		if (class143_0.currentTransaction == null)
		{
			Class153 class2 = new Class153(this, transaction);
			if (!transaction.EnlistPromotableSinglePhase(class2))
			{
				method_15(new NotSupportedException(Class121.DistributedTxnNotSupported));
			}
			class143_0.currentTransaction = class2;
			Class154.smethod_1(class143_0);
			class143_0.IsInActiveUse = true;
		}
	}

	private void method_31()
	{
		if (Settings.IncludeSecurityAsserts)
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission((IPermission?)(object)new MySqlClientPermission(ConnectionString));
			permissionSet.Demand();
			Class155.smethod_0(bool_0: true).Assert();
		}
	}

	object ICloneable.Clone()
	{
		Class139 @class = new Class139();
		string connectionString = Settings.ConnectionString;
		if (connectionString != null)
		{
			@class.ConnectionString = connectionString;
		}
		return @class;
	}

	static Class139()
	{
		Strings.CreateGetStringDelegate(typeof(Class139));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398298), getString_0(107398293)).Replace(getString_0(107398256), getString_0(107398251)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_3: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398246)))
		{
			throw new SecurityException(getString_0(107398221));
		}
		class124_0 = new Class124<string, MySqlConnectionStringBuilder>(0, 25);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_3, [MarshalAs(UnmanagedType.Bool)] out bool bool_4);
}
