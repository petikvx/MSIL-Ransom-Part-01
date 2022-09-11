using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Transactions;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns1;
using ns11;
using ns12;
using ns18;
using ns2;
using ns20;
using ns21;
using ns26;
using ns27;
using ns6;
using ns9;

namespace MySql.Data.MySqlClient;

[DesignerCategory("Code")]
[ToolboxBitmap(typeof(MySqlCommand), "MySqlClient.resources.command.bmp")]
public sealed class MySqlCommand : DbCommand, IDisposable, ICloneable
{
	internal delegate object Delegate2(int type, CommandBehavior behavior);

	private Class139 class139_0;

	private string string_0;

	private Class172 class172_0;

	private int int_0;

	private bool bool_0;

	private Class140 class140_0;

	private bool bool_1;

	private static List<string> list_0;

	private bool bool_2;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private CommandType commandType_0;

	[CompilerGenerated]
	private readonly Class151 class151_0;

	[CompilerGenerated]
	private Class181 class181_0;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private List<MySqlCommand> list_1;

	[CompilerGenerated]
	private bool bool_4;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private bool bool_5;

	[CompilerGenerated]
	private UpdateRowSource updateRowSource_0;

	[CompilerGenerated]
	private bool bool_6;

	private IAsyncResult iasyncResult_0;

	internal Delegate2 delegate2_0;

	internal Exception exception_0;

	[NonSerialized]
	internal static GetString getString_0;

	[Browsable(false)]
	public long LastInsertedId
	{
		[CompilerGenerated]
		get
		{
			return long_0;
		}
		[CompilerGenerated]
		internal set
		{
			long_0 = value;
		}
	}

	[Editor("MySql.Data.Common.Design.SqlCommandTextEditor,MySqlClient.Design", typeof(UITypeEditor))]
	[Description("Command text to execute")]
	[Category("Data")]
	string DbCommand.CommandText
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value ?? string.Empty;
			class172_0 = null;
			BatchableCommandText = null;
			if (string_0 != null && string_0.EndsWith(getString_0(107355484), StringComparison.OrdinalIgnoreCase))
			{
				string_0 = string_0.Substring(0, string_0.Length - 14);
				string_0 += getString_0(107355463);
			}
		}
	}

	[Category("Misc")]
	[DefaultValue(30)]
	[Description("Time to wait for command to execute")]
	int DbCommand.CommandTimeout
	{
		get
		{
			if (!bool_1)
			{
				return int_0;
			}
			return 30;
		}
		set
		{
			if (int_0 < 0)
			{
				method_23(new ArgumentException(getString_0(107355414)));
			}
			int num = Math.Min(value, 2147483);
			if (num != value)
			{
				MySqlTrace.smethod_3(class139_0.ServerThread, getString_0(107355397) + value + getString_0(107354808) + num + getString_0(107354779));
			}
			int_0 = num;
			bool_1 = false;
		}
	}

	[Category("Data")]
	CommandType DbCommand.CommandType
	{
		[CompilerGenerated]
		get
		{
			return commandType_0;
		}
		[CompilerGenerated]
		set
		{
			commandType_0 = value;
		}
	}

	[Browsable(false)]
	public bool IsPrepared
	{
		get
		{
			if (class172_0 != null)
			{
				return class172_0.IsPrepared;
			}
			return false;
		}
	}

	[Category("Behavior")]
	[Description("Connection used by the command")]
	public new Class139 Connection
	{
		get
		{
			return class139_0;
		}
		set
		{
			if (class139_0 != value)
			{
				Transaction = null;
			}
			class139_0 = value;
			if (class139_0 != null)
			{
				if (bool_1)
				{
					int_0 = (int)class139_0.Settings.DefaultCommandTimeout;
					bool_1 = false;
				}
				EnableCaching = class139_0.Settings.TableCaching;
				CacheAge = class139_0.Settings.DefaultTableCacheAge;
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Data")]
	[Description("The parameters collection")]
	public new Class151 Parameters
	{
		[CompilerGenerated]
		get
		{
			return class151_0;
		}
	}

	[Browsable(false)]
	public new Class181 Transaction
	{
		[CompilerGenerated]
		get
		{
			return class181_0;
		}
		[CompilerGenerated]
		set
		{
			class181_0 = value;
		}
	}

	public bool EnableCaching
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
		[CompilerGenerated]
		set
		{
			bool_3 = value;
		}
	}

	public int CacheAge
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	internal List<MySqlCommand> Batch
	{
		[CompilerGenerated]
		get
		{
			return list_1;
		}
		[CompilerGenerated]
		private set
		{
			list_1 = value;
		}
	}

	internal bool Canceled
	{
		[CompilerGenerated]
		get
		{
			return bool_4;
		}
		[CompilerGenerated]
		private set
		{
			bool_4 = value;
		}
	}

	internal string BatchableCommandText
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		private set
		{
			string_1 = value;
		}
	}

	internal bool InternallyCreated
	{
		[CompilerGenerated]
		get
		{
			return bool_5;
		}
		[CompilerGenerated]
		set
		{
			bool_5 = value;
		}
	}

	UpdateRowSource DbCommand.UpdatedRowSource
	{
		[CompilerGenerated]
		get
		{
			return updateRowSource_0;
		}
		[CompilerGenerated]
		set
		{
			updateRowSource_0 = value;
		}
	}

	[Browsable(false)]
	bool DbCommand.DesignTimeVisible
	{
		[CompilerGenerated]
		get
		{
			return bool_6;
		}
		[CompilerGenerated]
		set
		{
			bool_6 = value;
		}
	}

	DbConnection DbCommand.DbConnection
	{
		get
		{
			return Connection;
		}
		set
		{
			Connection = (Class139)value;
		}
	}

	DbParameterCollection DbCommand.DbParameterCollection => Parameters;

	DbTransaction DbCommand.DbTransaction
	{
		get
		{
			return Transaction;
		}
		set
		{
			Transaction = (Class181)value;
		}
	}

	public MySqlCommand()
	{
		CommandType = CommandType.Text;
		class151_0 = new Class151(this);
		string_0 = string.Empty;
		bool_1 = true;
		UpdatedRowSource = UpdateRowSource.Both;
	}

	public MySqlCommand(string cmdText)
		: this()
	{
		CommandText = cmdText;
	}

	public MySqlCommand(string cmdText, Class139 connection)
		: this(cmdText)
	{
		Connection = connection;
	}

	public MySqlCommand(string cmdText, Class139 connection, Class181 transaction)
		: this(cmdText, connection)
	{
		Transaction = transaction;
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

	DbParameter DbCommand.CreateDbParameter()
	{
		return new MySqlParameter();
	}

	void DbCommand.Cancel()
	{
		class139_0.method_10(class139_0.ConnectionTimeout);
		Canceled = true;
	}

	public MySqlParameter method_0()
	{
		return (MySqlParameter)CreateDbParameter();
	}

	private void method_1()
	{
		if (class139_0 == null)
		{
			method_23(new InvalidOperationException(getString_0(107354734)));
		}
		if (class139_0.State != ConnectionState.Open && !class139_0.SoftClosed)
		{
			method_23(new InvalidOperationException(getString_0(107354734)));
		}
		if (class139_0.IsInUse && !InternallyCreated)
		{
			method_23(new MySqlException(getString_0(107354717)));
		}
	}

	int DbCommand.ExecuteNonQuery()
	{
		int result = -1;
		if (class139_0?.class158_0 != null && class139_0.class158_0.method_2(CommandText, ref result))
		{
			return result;
		}
		using Class142 @class = method_6();
		@class.Close();
		return @class.RecordsAffected;
	}

	internal void method_2()
	{
		if (class140_0 != null)
		{
			class140_0.System_002EIDisposable_002EDispose();
			class140_0 = null;
		}
	}

	internal void method_3(Class142 class142_0)
	{
		class172_0?.vmethod_0(class142_0);
		method_5();
		if (class172_0 != null)
		{
			class139_0?.class143_0?.vmethod_15(class139_0, class172_0.StatementId);
		}
		method_2();
	}

	DbDataReader DbCommand.ExecuteDbDataReader(CommandBehavior behavior)
	{
		return method_7(behavior);
	}

	private void method_4()
	{
		if (class139_0?.Reader != null)
		{
			class139_0.Reader.Close();
			class139_0.Reader = null;
		}
	}

	internal void method_5()
	{
		if (bool_0)
		{
			bool_0 = false;
			MySqlCommand mySqlCommand = new MySqlCommand(getString_0(107354587), class139_0);
			mySqlCommand.InternallyCreated = true;
			mySqlCommand.ExecuteNonQuery();
		}
	}

	public Class142 method_6()
	{
		return method_7(CommandBehavior.Default);
	}

	public Class142 method_7(CommandBehavior commandBehavior_0)
	{
		Class142 class142_ = null;
		if (class139_0?.class158_0 != null && class139_0.class158_0.method_3(CommandText, commandBehavior_0, ref class142_))
		{
			return class142_;
		}
		bool flag = false;
		method_1();
		Class143 class143_ = class139_0.class143_0;
		string_0 = string_0.Trim();
		if (string.IsNullOrEmpty(string_0))
		{
			method_23(new InvalidOperationException(Class121.CommandTextNotInitialized));
		}
		string text = string_0.Trim(new char[1] { ';' });
		if (class139_0.bool_0 && !class143_.method_2(Enum38.flag_0))
		{
			Class183.smethod_5(class139_0.Settings.Server, !method_9(text), class139_0);
		}
		lock (class143_)
		{
			if (class139_0.Reader != null)
			{
				method_23(new MySqlException(Class121.DataReaderOpen));
			}
			Transaction current = System.Transactions.Transaction.Current;
			if (current != null)
			{
				bool flag2 = false;
				if (class143_.currentTransaction != null)
				{
					flag2 = class143_.currentTransaction.InRollback;
				}
				if (!flag2)
				{
					TransactionStatus transactionStatus = TransactionStatus.InDoubt;
					try
					{
						transactionStatus = current.TransactionInformation.Status;
					}
					catch (TransactionException)
					{
					}
					if (transactionStatus == TransactionStatus.Aborted)
					{
						method_23(new TransactionAbortedException());
					}
				}
			}
			class140_0 = new Class140(class139_0, CommandTimeout);
			LastInsertedId = -1L;
			if (CommandType == CommandType.TableDirect)
			{
				text = getString_0(107355026) + text;
			}
			else if (CommandType == CommandType.Text && text.IndexOf(getString_0(107396370)) == -1 && method_20(text))
			{
				text = getString_0(107355037) + text;
			}
			if (class139_0.Settings.Replication && !InternallyCreated)
			{
				method_8(text);
			}
			if (class172_0 == null || !class172_0.IsPrepared)
			{
				if (CommandType == CommandType.StoredProcedure)
				{
					class172_0 = new StoredProcedure(this, text);
				}
				else
				{
					class172_0 = new Class172(this, text);
				}
			}
			class172_0.vmethod_1(bool_0: false);
			method_10(commandBehavior_0);
			try
			{
				Class142 @class = new Class142(this, class172_0, commandBehavior_0);
				class139_0.Reader = @class;
				Canceled = false;
				class172_0.vmethod_2();
				@class.NextResult();
				flag = true;
				return @class;
			}
			catch (TimeoutException ex2)
			{
				class139_0.method_9(ex2);
				throw;
			}
			catch (ThreadAbortException ex3)
			{
				class139_0.method_9(ex3);
				throw;
			}
			catch (IOException ex4)
			{
				class139_0.method_6();
				throw new MySqlException(Class121.FatalErrorDuringExecute, ex4);
			}
			catch (MySqlException ex5)
			{
				if (ex5.InnerException is TimeoutException)
				{
					throw;
				}
				try
				{
					method_4();
					method_5();
				}
				catch (Exception)
				{
					Connection.method_6();
					throw new MySqlException(ex5.Message, isFatal: true, ex5);
				}
				if (!ex5.IsQueryAborted)
				{
					if (ex5.IsFatal)
					{
						Connection.Close();
					}
					if (ex5.Number == 0)
					{
						throw new MySqlException(Class121.FatalErrorDuringExecute, ex5);
					}
					throw;
				}
				return null;
			}
			finally
			{
				if (class139_0 != null)
				{
					if (class139_0.Reader == null)
					{
						method_2();
					}
					if (!flag)
					{
						method_4();
					}
				}
			}
		}
	}

	private void method_8(string string_2)
	{
		string_2 = Class135.smethod_1(string_2);
		if (!string_2.StartsWith(getString_0(107354996)) && !string_2.StartsWith(getString_0(107354987)))
		{
			method_23(new MySqlException(Class121.ReplicatedConnectionsAllowOnlyReadonlyStatements));
		}
		if (string_2.EndsWith(getString_0(107355010)) || string_2.EndsWith(getString_0(107354961)))
		{
			method_23(new MySqlException(Class121.ReplicatedConnectionsAllowOnlyReadonlyStatements));
		}
	}

	private bool method_9(string string_2)
	{
		string_2 = string_2.ToLower();
		if (!string_2.StartsWith(getString_0(107354996)) && !string_2.StartsWith(getString_0(107354987)))
		{
			return false;
		}
		if (!string_2.EndsWith(getString_0(107355010)))
		{
			return !string_2.EndsWith(getString_0(107354961));
		}
		return false;
	}

	object DbCommand.ExecuteScalar()
	{
		LastInsertedId = -1L;
		object object_ = null;
		if (class139_0 != null && class139_0.class158_0.method_1(CommandText, ref object_))
		{
			return object_;
		}
		using Class142 @class = method_6();
		if (@class.Read())
		{
			return @class.GetValue(0);
		}
		return object_;
	}

	private void method_10(CommandBehavior commandBehavior_0)
	{
		if ((commandBehavior_0 & CommandBehavior.SchemaOnly) != 0)
		{
			new MySqlCommand(getString_0(107354936), class139_0).ExecuteNonQuery();
			bool_0 = true;
		}
		else if ((commandBehavior_0 & CommandBehavior.SingleRow) != 0)
		{
			new MySqlCommand(getString_0(107354903), class139_0).ExecuteNonQuery();
			bool_0 = true;
		}
	}

	private void method_11(int int_2)
	{
		using (new Class140(Connection, CommandTimeout))
		{
			string commandText = CommandText;
			if (commandText != null && commandText.Trim().Length != 0)
			{
				class172_0 = ((CommandType == CommandType.StoredProcedure) ? new StoredProcedure(this, CommandText) : new Class172(this, CommandText));
				class172_0.vmethod_1(bool_0: true);
				class172_0.vmethod_6();
			}
		}
	}

	void DbCommand.Prepare()
	{
		if (class139_0 == null)
		{
			method_23(new InvalidOperationException(getString_0(107354870)));
		}
		if (class139_0.State != ConnectionState.Open)
		{
			method_23(new InvalidOperationException(getString_0(107354845)));
		}
		if (!class139_0.Settings.IgnorePrepare)
		{
			method_11(0);
		}
	}

	internal object method_12(int int_2, CommandBehavior commandBehavior_0)
	{
		exception_0 = null;
		try
		{
			if (int_2 == 1)
			{
				return method_7(commandBehavior_0);
			}
			return ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			Exception ex2 = (exception_0 = ex);
		}
		return null;
	}

	public IAsyncResult method_13()
	{
		return method_14(CommandBehavior.Default);
	}

	public IAsyncResult method_14(CommandBehavior commandBehavior_0)
	{
		if (delegate2_0 != null)
		{
			method_23(new MySqlException(Class121.UnableToStartSecondAsyncOp));
		}
		delegate2_0 = method_12;
		iasyncResult_0 = delegate2_0.BeginInvoke(1, commandBehavior_0, null, null);
		return iasyncResult_0;
	}

	public Class142 method_15(IAsyncResult iasyncResult_1)
	{
		iasyncResult_1.AsyncWaitHandle.WaitOne();
		Delegate2 @delegate = delegate2_0;
		delegate2_0 = null;
		if (exception_0 != null)
		{
			throw exception_0;
		}
		return (Class142)@delegate.EndInvoke(iasyncResult_1);
	}

	public IAsyncResult method_16(AsyncCallback asyncCallback_0, object object_0)
	{
		if (delegate2_0 != null)
		{
			method_23(new MySqlException(Class121.UnableToStartSecondAsyncOp));
		}
		delegate2_0 = method_12;
		iasyncResult_0 = delegate2_0.BeginInvoke(2, CommandBehavior.Default, asyncCallback_0, object_0);
		return iasyncResult_0;
	}

	public IAsyncResult method_17()
	{
		if (delegate2_0 != null)
		{
			method_23(new MySqlException(Class121.UnableToStartSecondAsyncOp));
		}
		delegate2_0 = method_12;
		iasyncResult_0 = delegate2_0.BeginInvoke(2, CommandBehavior.Default, null, null);
		return iasyncResult_0;
	}

	public int method_18(IAsyncResult iasyncResult_1)
	{
		iasyncResult_1.AsyncWaitHandle.WaitOne();
		Delegate2 @delegate = delegate2_0;
		delegate2_0 = null;
		if (exception_0 != null)
		{
			throw exception_0;
		}
		return (int)@delegate.EndInvoke(iasyncResult_1);
	}

	internal long method_19()
	{
		return CommandText.Length + Parameters.Cast<MySqlParameter>().Sum((MySqlParameter mySqlParameter_0) => mySqlParameter_0.method_6());
	}

	private bool method_20(string string_2)
	{
		if (string.IsNullOrEmpty(string_2))
		{
			return false;
		}
		string text = string_2.ToUpper();
		int num = text.IndexOfAny(new char[5] { '(', '"', '@', '\'', '`' });
		if (num > 0)
		{
			text = text.Substring(0, num);
		}
		if (list_0 == null)
		{
			list_0 = new List<string>(Class182.smethod_0(getString_0(107354264)).Replace(getString_0(107354279), getString_0(107398092)).Split(new char[1] { '\n' }));
		}
		return !list_0.Contains(text);
	}

	internal void method_21(MySqlCommand mySqlCommand_0)
	{
		if (Batch == null)
		{
			Batch = new List<MySqlCommand>();
		}
		Batch.Add(mySqlCommand_0);
	}

	internal string method_22()
	{
		if (BatchableCommandText == null)
		{
			if (string.Compare(CommandText.Substring(0, 6), getString_0(107354274), StringComparison.OrdinalIgnoreCase) == 0)
			{
				string text = Class135.smethod_0(new MySqlCommand(getString_0(107354265), Connection).ExecuteScalar()!.ToString());
				Class127 @class = new Class127(CommandText);
				@class.AnsiQuotes = text.IndexOf(getString_0(107354240)) != -1;
				@class.BackslashEscapes = text.IndexOf(getString_0(107354191)) == -1;
				for (string text2 = Class135.smethod_1(@class.method_1()); text2 != null; text2 = @class.method_1())
				{
					if (Class135.smethod_0(text2) == getString_0(107354162) && !@class.Quoted)
					{
						text2 = @class.method_1();
						int num = 1;
						while (text2 != null)
						{
							BatchableCommandText += text2;
							text2 = @class.method_1();
							if (text2 == getString_0(107409647))
							{
								num++;
							}
							else if (text2 == getString_0(107409642))
							{
								num--;
							}
							if (num == 0)
							{
								break;
							}
						}
						if (text2 != null)
						{
							BatchableCommandText += text2;
						}
						text2 = @class.method_1();
						if (text2 != null && (text2 == getString_0(107405070) || Class135.smethod_0(text2) == getString_0(107354153)))
						{
							BatchableCommandText = null;
							break;
						}
					}
				}
			}
			else
			{
				BatchableCommandText = CommandText;
			}
		}
		return BatchableCommandText;
	}

	private void method_23(Exception exception_1)
	{
		class139_0?.method_15(exception_1);
		throw exception_1;
	}

	void IDisposable.Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	void Component.Dispose(bool disposing)
	{
		if (!bool_2 && disposing)
		{
			if (class172_0 != null && class172_0.IsPrepared)
			{
				class172_0.vmethod_7();
			}
			method_4();
			base.Dispose(disposing);
			bool_2 = true;
		}
	}

	object ICloneable.Clone()
	{
		MySqlCommand mySqlCommand = new MySqlCommand(string_0, class139_0, Transaction)
		{
			CommandType = CommandType,
			int_0 = int_0,
			bool_1 = bool_1,
			BatchableCommandText = BatchableCommandText,
			EnableCaching = EnableCaching,
			CacheAge = CacheAge
		};
		foreach (MySqlParameter parameter in Parameters)
		{
			mySqlCommand.Parameters.Add(parameter.method_0());
		}
		return mySqlCommand;
	}

	static MySqlCommand()
	{
		Strings.CreateGetStringDelegate(typeof(MySqlCommand));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398270), getString_0(107398265)).Replace(getString_0(107398228), getString_0(107398223)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_7: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398218)))
		{
			throw new SecurityException(getString_0(107398193));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_2, [MarshalAs(UnmanagedType.Bool)] bool bool_7, [MarshalAs(UnmanagedType.Bool)] out bool bool_8);
}
