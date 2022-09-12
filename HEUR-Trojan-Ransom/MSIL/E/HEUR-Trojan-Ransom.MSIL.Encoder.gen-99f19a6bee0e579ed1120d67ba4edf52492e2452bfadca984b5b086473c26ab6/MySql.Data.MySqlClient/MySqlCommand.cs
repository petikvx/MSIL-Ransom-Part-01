using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Threading;
using System.Transactions;
using MySql.Data.Common;
using MySql.Data.MySqlClient.Replication;

namespace MySql.Data.MySqlClient;

[ToolboxBitmap(typeof(MySqlCommand), "MySqlClient.resources.command.bmp")]
[DesignerCategory("Code")]
public sealed class MySqlCommand : DbCommand, IDisposable, ICloneable
{
	internal delegate object AsyncDelegate(int type, CommandBehavior behavior);

	private MySqlConnection connection;

	private string cmdText;

	private PreparableStatement statement;

	private int commandTimeout;

	private bool resetSqlSelect;

	private CommandTimer commandTimer;

	private bool useDefaultTimeout;

	private static List<string> keywords;

	private bool disposed;

	private IAsyncResult asyncResult;

	internal AsyncDelegate Caller;

	internal Exception thrownException;

	[Browsable(false)]
	public long LastInsertedId { get; internal set; }

	[Category("Data")]
	[Editor("MySql.Data.Common.Design.SqlCommandTextEditor,MySqlClient.Design", typeof(UITypeEditor))]
	[Description("Command text to execute")]
	public override string CommandText
	{
		get
		{
			return cmdText;
		}
		set
		{
			cmdText = value ?? string.Empty;
			statement = null;
			BatchableCommandText = null;
			if (cmdText != null && cmdText.EndsWith("DEFAULT VALUES", StringComparison.OrdinalIgnoreCase))
			{
				cmdText = cmdText.Substring(0, cmdText.Length - 14);
				cmdText += "() VALUES ()";
			}
		}
	}

	[Description("Time to wait for command to execute")]
	[DefaultValue(30)]
	[Category("Misc")]
	public override int CommandTimeout
	{
		get
		{
			if (!useDefaultTimeout)
			{
				return commandTimeout;
			}
			return 30;
		}
		set
		{
			if (commandTimeout < 0)
			{
				Throw(new ArgumentException("Command timeout must not be negative"));
			}
			int num = Math.Min(value, 2147483);
			if (num != value)
			{
				MySqlTrace.LogWarning(connection.ServerThread, "Command timeout value too large (" + value + " seconds). Changed to max. possible value (" + num + " seconds)");
			}
			commandTimeout = num;
			useDefaultTimeout = false;
		}
	}

	[Category("Data")]
	public override CommandType CommandType { get; set; }

	[Browsable(false)]
	public bool IsPrepared
	{
		get
		{
			if (statement != null)
			{
				return statement.IsPrepared;
			}
			return false;
		}
	}

	[Category("Behavior")]
	[Description("Connection used by the command")]
	public new MySqlConnection Connection
	{
		get
		{
			return connection;
		}
		set
		{
			if (connection != value)
			{
				Transaction = null;
			}
			connection = value;
			if (connection != null)
			{
				if (useDefaultTimeout)
				{
					commandTimeout = (int)connection.Settings.DefaultCommandTimeout;
					useDefaultTimeout = false;
				}
				EnableCaching = connection.Settings.TableCaching;
				CacheAge = connection.Settings.DefaultTableCacheAge;
			}
		}
	}

	[Description("The parameters collection")]
	[Category("Data")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public new MySqlParameterCollection Parameters { get; }

	[Browsable(false)]
	public new MySqlTransaction Transaction { get; set; }

	public bool EnableCaching { get; set; }

	public int CacheAge { get; set; }

	internal List<MySqlCommand> Batch { get; private set; }

	internal bool Canceled { get; private set; }

	internal string BatchableCommandText { get; private set; }

	internal bool InternallyCreated { get; set; }

	public override UpdateRowSource UpdatedRowSource { get; set; }

	[Browsable(false)]
	public override bool DesignTimeVisible { get; set; }

	protected override DbConnection DbConnection
	{
		get
		{
			return Connection;
		}
		set
		{
			Connection = (MySqlConnection)value;
		}
	}

	protected override DbParameterCollection DbParameterCollection => Parameters;

	protected override DbTransaction DbTransaction
	{
		get
		{
			return Transaction;
		}
		set
		{
			Transaction = (MySqlTransaction)value;
		}
	}

	public MySqlCommand()
	{
		CommandType = CommandType.Text;
		Parameters = new MySqlParameterCollection(this);
		cmdText = string.Empty;
		useDefaultTimeout = true;
		UpdatedRowSource = UpdateRowSource.Both;
	}

	public MySqlCommand(string cmdText)
		: this()
	{
		CommandText = cmdText;
	}

	public MySqlCommand(string cmdText, MySqlConnection connection)
		: this(cmdText)
	{
		Connection = connection;
	}

	public MySqlCommand(string cmdText, MySqlConnection connection, MySqlTransaction transaction)
		: this(cmdText, connection)
	{
		Transaction = transaction;
	}

	~MySqlCommand()
	{
		Dispose(disposing: false);
	}

	protected override DbParameter CreateDbParameter()
	{
		return new MySqlParameter();
	}

	public override void Cancel()
	{
		connection.CancelQuery(connection.ConnectionTimeout);
		Canceled = true;
	}

	public new MySqlParameter CreateParameter()
	{
		return (MySqlParameter)CreateDbParameter();
	}

	private void CheckState()
	{
		if (connection == null)
		{
			Throw(new InvalidOperationException("Connection must be valid and open."));
		}
		if (connection.State != ConnectionState.Open && !connection.SoftClosed)
		{
			Throw(new InvalidOperationException("Connection must be valid and open."));
		}
		if (connection.IsInUse && !InternallyCreated)
		{
			Throw(new MySqlException("There is already an open DataReader associated with this Connection which must be closed first."));
		}
	}

	public override int ExecuteNonQuery()
	{
		int returnValue = -1;
		if (connection?.commandInterceptor != null && connection.commandInterceptor.ExecuteNonQuery(CommandText, ref returnValue))
		{
			return returnValue;
		}
		using MySqlDataReader mySqlDataReader = ExecuteReader();
		mySqlDataReader.Close();
		return mySqlDataReader.RecordsAffected;
	}

	internal void ClearCommandTimer()
	{
		if (commandTimer != null)
		{
			commandTimer.Dispose();
			commandTimer = null;
		}
	}

	internal void Close(MySqlDataReader reader)
	{
		statement?.Close(reader);
		ResetSqlSelectLimit();
		if (statement != null)
		{
			connection?.driver?.CloseQuery(connection, statement.StatementId);
		}
		ClearCommandTimer();
	}

	protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
	{
		return ExecuteReader(behavior);
	}

	private void ResetReader()
	{
		if (connection?.Reader != null)
		{
			connection.Reader.Close();
			connection.Reader = null;
		}
	}

	internal void ResetSqlSelectLimit()
	{
		if (resetSqlSelect)
		{
			resetSqlSelect = false;
			MySqlCommand mySqlCommand = new MySqlCommand("SET SQL_SELECT_LIMIT=DEFAULT", connection);
			mySqlCommand.InternallyCreated = true;
			mySqlCommand.ExecuteNonQuery();
		}
	}

	public new MySqlDataReader ExecuteReader()
	{
		return ExecuteReader(CommandBehavior.Default);
	}

	public new MySqlDataReader ExecuteReader(CommandBehavior behavior)
	{
		MySqlDataReader returnValue = null;
		if (connection?.commandInterceptor != null && connection.commandInterceptor.ExecuteReader(CommandText, behavior, ref returnValue))
		{
			return returnValue;
		}
		bool flag = false;
		CheckState();
		Driver driver = connection.driver;
		cmdText = cmdText.Trim();
		if (string.IsNullOrEmpty(cmdText))
		{
			Throw(new InvalidOperationException(Resources.CommandTextNotInitialized));
		}
		string text = cmdText.Trim(new char[1] { ';' });
		if (connection.hasBeenOpen && !driver.HasStatus(ServerStatusFlags.InTransaction))
		{
			ReplicationManager.GetNewConnection(connection.Settings.Server, !IsReadOnlyCommand(text), connection);
		}
		lock (driver)
		{
			if (connection.Reader != null)
			{
				Throw(new MySqlException(Resources.DataReaderOpen));
			}
			Transaction current = System.Transactions.Transaction.Current;
			if (current != null)
			{
				bool flag2 = false;
				if (driver.currentTransaction != null)
				{
					flag2 = driver.currentTransaction.InRollback;
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
						Throw(new TransactionAbortedException());
					}
				}
			}
			commandTimer = new CommandTimer(connection, CommandTimeout);
			LastInsertedId = -1L;
			if (CommandType == CommandType.TableDirect)
			{
				text = "SELECT * FROM " + text;
			}
			else if (CommandType == CommandType.Text && text.IndexOf(" ") == -1 && AddCallStatement(text))
			{
				text = "call " + text;
			}
			if (connection.Settings.Replication && !InternallyCreated)
			{
				EnsureCommandIsReadOnly(text);
			}
			if (statement == null || !statement.IsPrepared)
			{
				if (CommandType == CommandType.StoredProcedure)
				{
					statement = new StoredProcedure(this, text);
				}
				else
				{
					statement = new PreparableStatement(this, text);
				}
			}
			statement.Resolve(preparing: false);
			HandleCommandBehaviors(behavior);
			try
			{
				MySqlDataReader mySqlDataReader = new MySqlDataReader(this, statement, behavior);
				connection.Reader = mySqlDataReader;
				Canceled = false;
				statement.Execute();
				mySqlDataReader.NextResult();
				flag = true;
				return mySqlDataReader;
			}
			catch (TimeoutException ex2)
			{
				connection.HandleTimeoutOrThreadAbort(ex2);
				throw;
			}
			catch (ThreadAbortException ex3)
			{
				connection.HandleTimeoutOrThreadAbort(ex3);
				throw;
			}
			catch (IOException ex4)
			{
				connection.Abort();
				throw new MySqlException(Resources.FatalErrorDuringExecute, ex4);
			}
			catch (MySqlException ex5)
			{
				if (ex5.InnerException is TimeoutException)
				{
					throw;
				}
				try
				{
					ResetReader();
					ResetSqlSelectLimit();
				}
				catch (Exception)
				{
					Connection.Abort();
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
						throw new MySqlException(Resources.FatalErrorDuringExecute, ex5);
					}
					throw;
				}
				return null;
			}
			finally
			{
				if (connection != null)
				{
					if (connection.Reader == null)
					{
						ClearCommandTimer();
					}
					if (!flag)
					{
						ResetReader();
					}
				}
			}
		}
	}

	private void EnsureCommandIsReadOnly(string sql)
	{
		sql = StringUtility.ToLowerInvariant(sql);
		if (!sql.StartsWith("select") && !sql.StartsWith("show"))
		{
			Throw(new MySqlException(Resources.ReplicatedConnectionsAllowOnlyReadonlyStatements));
		}
		if (sql.EndsWith("for update") || sql.EndsWith("lock in share mode"))
		{
			Throw(new MySqlException(Resources.ReplicatedConnectionsAllowOnlyReadonlyStatements));
		}
	}

	private bool IsReadOnlyCommand(string sql)
	{
		sql = sql.ToLower();
		if (!sql.StartsWith("select") && !sql.StartsWith("show"))
		{
			return false;
		}
		if (!sql.EndsWith("for update"))
		{
			return !sql.EndsWith("lock in share mode");
		}
		return false;
	}

	public override object ExecuteScalar()
	{
		LastInsertedId = -1L;
		object returnValue = null;
		if (connection != null && connection.commandInterceptor.ExecuteScalar(CommandText, ref returnValue))
		{
			return returnValue;
		}
		using MySqlDataReader mySqlDataReader = ExecuteReader();
		if (mySqlDataReader.Read())
		{
			return mySqlDataReader.GetValue(0);
		}
		return returnValue;
	}

	private void HandleCommandBehaviors(CommandBehavior behavior)
	{
		if ((behavior & CommandBehavior.SchemaOnly) != 0)
		{
			new MySqlCommand("SET SQL_SELECT_LIMIT=0", connection).ExecuteNonQuery();
			resetSqlSelect = true;
		}
		else if ((behavior & CommandBehavior.SingleRow) != 0)
		{
			new MySqlCommand("SET SQL_SELECT_LIMIT=1", connection).ExecuteNonQuery();
			resetSqlSelect = true;
		}
	}

	private void Prepare(int cursorPageSize)
	{
		using (new CommandTimer(Connection, CommandTimeout))
		{
			string commandText = CommandText;
			if (commandText != null && commandText.Trim().Length != 0)
			{
				statement = ((CommandType == CommandType.StoredProcedure) ? new StoredProcedure(this, CommandText) : new PreparableStatement(this, CommandText));
				statement.Resolve(preparing: true);
				statement.Prepare();
			}
		}
	}

	public override void Prepare()
	{
		if (connection == null)
		{
			Throw(new InvalidOperationException("The connection property has not been set."));
		}
		if (connection.State != ConnectionState.Open)
		{
			Throw(new InvalidOperationException("The connection is not open."));
		}
		if (!connection.Settings.IgnorePrepare)
		{
			Prepare(0);
		}
	}

	internal object AsyncExecuteWrapper(int type, CommandBehavior behavior)
	{
		thrownException = null;
		try
		{
			if (type == 1)
			{
				return ExecuteReader(behavior);
			}
			return ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			Exception ex2 = (thrownException = ex);
		}
		return null;
	}

	public IAsyncResult BeginExecuteReader()
	{
		return BeginExecuteReader(CommandBehavior.Default);
	}

	public IAsyncResult BeginExecuteReader(CommandBehavior behavior)
	{
		if (Caller != null)
		{
			Throw(new MySqlException(Resources.UnableToStartSecondAsyncOp));
		}
		Caller = AsyncExecuteWrapper;
		asyncResult = Caller.BeginInvoke(1, behavior, null, null);
		return asyncResult;
	}

	public MySqlDataReader EndExecuteReader(IAsyncResult result)
	{
		result.AsyncWaitHandle.WaitOne();
		AsyncDelegate caller = Caller;
		Caller = null;
		if (thrownException != null)
		{
			throw thrownException;
		}
		return (MySqlDataReader)caller.EndInvoke(result);
	}

	public IAsyncResult BeginExecuteNonQuery(AsyncCallback callback, object stateObject)
	{
		if (Caller != null)
		{
			Throw(new MySqlException(Resources.UnableToStartSecondAsyncOp));
		}
		Caller = AsyncExecuteWrapper;
		asyncResult = Caller.BeginInvoke(2, CommandBehavior.Default, callback, stateObject);
		return asyncResult;
	}

	public IAsyncResult BeginExecuteNonQuery()
	{
		if (Caller != null)
		{
			Throw(new MySqlException(Resources.UnableToStartSecondAsyncOp));
		}
		Caller = AsyncExecuteWrapper;
		asyncResult = Caller.BeginInvoke(2, CommandBehavior.Default, null, null);
		return asyncResult;
	}

	public int EndExecuteNonQuery(IAsyncResult asyncResult)
	{
		asyncResult.AsyncWaitHandle.WaitOne();
		AsyncDelegate caller = Caller;
		Caller = null;
		if (thrownException != null)
		{
			throw thrownException;
		}
		return (int)caller.EndInvoke(asyncResult);
	}

	internal long EstimatedSize()
	{
		return CommandText.Length + Parameters.Cast<MySqlParameter>().Sum((MySqlParameter parameter) => parameter.EstimatedSize());
	}

	private bool AddCallStatement(string query)
	{
		if (string.IsNullOrEmpty(query))
		{
			return false;
		}
		string text = query.ToUpper();
		int num = text.IndexOfAny(new char[5] { '(', '"', '@', '\'', '`' });
		if (num > 0)
		{
			text = text.Substring(0, num);
		}
		if (keywords == null)
		{
			keywords = new List<string>(Utils.ReadResource("keywords.txt").Replace("\r", "").Split(new char[1] { '\n' }));
		}
		return !keywords.Contains(text);
	}

	internal void AddToBatch(MySqlCommand command)
	{
		if (Batch == null)
		{
			Batch = new List<MySqlCommand>();
		}
		Batch.Add(command);
	}

	internal string GetCommandTextForBatching()
	{
		if (BatchableCommandText == null)
		{
			if (string.Compare(CommandText.Substring(0, 6), "INSERT", StringComparison.OrdinalIgnoreCase) == 0)
			{
				string text = StringUtility.ToUpperInvariant(new MySqlCommand("SELECT @@sql_mode", Connection).ExecuteScalar().ToString());
				MySqlTokenizer mySqlTokenizer = new MySqlTokenizer(CommandText);
				mySqlTokenizer.AnsiQuotes = text.IndexOf("ANSI_QUOTES") != -1;
				mySqlTokenizer.BackslashEscapes = text.IndexOf("NO_BACKSLASH_ESCAPES") == -1;
				for (string text2 = StringUtility.ToLowerInvariant(mySqlTokenizer.NextToken()); text2 != null; text2 = mySqlTokenizer.NextToken())
				{
					if (StringUtility.ToUpperInvariant(text2) == "VALUES" && !mySqlTokenizer.Quoted)
					{
						text2 = mySqlTokenizer.NextToken();
						int num = 1;
						while (text2 != null)
						{
							BatchableCommandText += text2;
							text2 = mySqlTokenizer.NextToken();
							if (text2 == "(")
							{
								num++;
							}
							else if (text2 == ")")
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
						text2 = mySqlTokenizer.NextToken();
						if (text2 != null && (text2 == "," || StringUtility.ToUpperInvariant(text2) == "ON"))
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

	private void Throw(Exception ex)
	{
		connection?.Throw(ex);
		throw ex;
	}

	public new void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected override void Dispose(bool disposing)
	{
		if (!disposed && disposing)
		{
			if (statement != null && statement.IsPrepared)
			{
				statement.CloseStatement();
			}
			ResetReader();
			base.Dispose(disposing);
			disposed = true;
		}
	}

	public object Clone()
	{
		MySqlCommand mySqlCommand = new MySqlCommand(cmdText, connection, Transaction)
		{
			CommandType = CommandType,
			commandTimeout = commandTimeout,
			useDefaultTimeout = useDefaultTimeout,
			BatchableCommandText = BatchableCommandText,
			EnableCaching = EnableCaching,
			CacheAge = CacheAge
		};
		foreach (MySqlParameter parameter in Parameters)
		{
			mySqlCommand.Parameters.Add(parameter.Clone());
		}
		return mySqlCommand;
	}
}
