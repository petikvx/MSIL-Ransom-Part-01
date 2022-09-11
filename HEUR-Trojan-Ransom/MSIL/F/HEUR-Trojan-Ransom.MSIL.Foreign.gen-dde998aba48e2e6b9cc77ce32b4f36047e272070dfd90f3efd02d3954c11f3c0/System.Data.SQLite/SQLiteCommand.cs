using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

[ToolboxItem(true)]
[Designer("SQLite.Designer.SQLiteCommandDesigner, SQLite.Designer, Version=1.0.105.2, Culture=neutral, PublicKeyToken=db937bc2d44ff139")]
public sealed class SQLiteCommand : DbCommand, ICloneable
{
	private static readonly string DefaultConnectionString;

	private string _commandText;

	private SQLiteConnection _cnn;

	private int _version;

	private WeakReference _activeReader;

	internal int _commandTimeout;

	private bool _designTimeVisible;

	private UpdateRowSource _updateRowSource;

	private SQLiteParameterCollection _parameterCollection;

	internal List<SQLiteStatement> _statementList;

	internal string _remainingText;

	private SQLiteTransaction _transaction;

	private bool disposed;

	[NonSerialized]
	internal static GetString _001D;

	[DefaultValue("")]
	[RefreshProperties(RefreshProperties.All)]
	[Editor("Microsoft.VSDesigner.Data.SQL.Design.SqlCommandTextEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public override string CommandText
	{
		get
		{
			CheckDisposed();
			return _commandText;
		}
		set
		{
			CheckDisposed();
			if (!(_commandText == value))
			{
				if (_activeReader != null && _activeReader.IsAlive)
				{
					throw new InvalidOperationException(_001D(107363063));
				}
				ClearCommands();
				_commandText = value;
				_ = _cnn;
			}
		}
	}

	[DefaultValue(30)]
	public override int CommandTimeout
	{
		get
		{
			CheckDisposed();
			return _commandTimeout;
		}
		set
		{
			CheckDisposed();
			_commandTimeout = value;
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(CommandType.Text)]
	public override CommandType CommandType
	{
		get
		{
			CheckDisposed();
			return CommandType.Text;
		}
		set
		{
			CheckDisposed();
			if (value != CommandType.Text)
			{
				throw new NotSupportedException();
			}
		}
	}

	[Editor("Microsoft.VSDesigner.Data.Design.DbConnectionEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DefaultValue(null)]
	public new SQLiteConnection Connection
	{
		get
		{
			CheckDisposed();
			return _cnn;
		}
		set
		{
			CheckDisposed();
			if (_activeReader != null && _activeReader.IsAlive)
			{
				throw new InvalidOperationException(_001D(107363026));
			}
			if (_cnn != null)
			{
				ClearCommands();
			}
			_cnn = value;
			if (_cnn != null)
			{
				_version = _cnn._version;
			}
		}
	}

	protected override DbConnection DbConnection
	{
		get
		{
			return Connection;
		}
		set
		{
			Connection = (SQLiteConnection)value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public new SQLiteParameterCollection Parameters
	{
		get
		{
			CheckDisposed();
			return _parameterCollection;
		}
	}

	protected override DbParameterCollection DbParameterCollection => Parameters;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new SQLiteTransaction Transaction
	{
		get
		{
			CheckDisposed();
			return _transaction;
		}
		set
		{
			CheckDisposed();
			if (_cnn != null)
			{
				if (_activeReader != null && _activeReader.IsAlive)
				{
					throw new InvalidOperationException(_001D(107362445));
				}
				if (value != null && value._cnn != _cnn)
				{
					throw new ArgumentException(_001D(107362376));
				}
				_transaction = value;
			}
			else
			{
				if (value != null)
				{
					Connection = value.Connection;
				}
				_transaction = value;
			}
		}
	}

	protected override DbTransaction DbTransaction
	{
		get
		{
			return Transaction;
		}
		set
		{
			Transaction = (SQLiteTransaction)value;
		}
	}

	[DefaultValue(UpdateRowSource.None)]
	public override UpdateRowSource UpdatedRowSource
	{
		get
		{
			CheckDisposed();
			return _updateRowSource;
		}
		set
		{
			CheckDisposed();
			_updateRowSource = value;
		}
	}

	[DesignOnly(true)]
	[DefaultValue(true)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool DesignTimeVisible
	{
		get
		{
			CheckDisposed();
			return _designTimeVisible;
		}
		set
		{
			CheckDisposed();
			_designTimeVisible = value;
			TypeDescriptor.Refresh(this);
		}
	}

	public SQLiteCommand()
		: this(null, null)
	{
	}

	public SQLiteCommand(string commandText)
		: this(commandText, null, null)
	{
	}

	public SQLiteCommand(string commandText, SQLiteConnection connection)
		: this(commandText, connection, null)
	{
	}

	public SQLiteCommand(SQLiteConnection connection)
		: this(null, connection, null)
	{
	}

	private SQLiteCommand(SQLiteCommand source)
		: this(source.CommandText, source.Connection, source.Transaction)
	{
		CommandTimeout = source.CommandTimeout;
		DesignTimeVisible = source.DesignTimeVisible;
		UpdatedRowSource = source.UpdatedRowSource;
		foreach (SQLiteParameter item in source._parameterCollection)
		{
			Parameters.Add(item.Clone());
		}
	}

	public SQLiteCommand(string commandText, SQLiteConnection connection, SQLiteTransaction transaction)
	{
		_commandTimeout = 30;
		_parameterCollection = new SQLiteParameterCollection(this);
		_designTimeVisible = true;
		_updateRowSource = UpdateRowSource.None;
		if (commandText != null)
		{
			CommandText = commandText;
		}
		if (connection != null)
		{
			DbConnection = connection;
			_commandTimeout = connection.DefaultTimeout;
		}
		if (transaction != null)
		{
			Transaction = transaction;
		}
		SQLiteConnection.OnChanged(connection, new ConnectionEventArgs(SQLiteConnectionEventType.NewCommand, null, transaction, this, null, null, null, null));
	}

	[Conditional("CHECK_STATE")]
	internal static void Check(SQLiteCommand command)
	{
		if (command == null)
		{
			throw new ArgumentNullException(_001D(107363076));
		}
		command.CheckDisposed();
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteCommand).Name);
		}
	}

	protected override void Dispose(bool disposing)
	{
		SQLiteConnection.OnChanged(_cnn, new ConnectionEventArgs(SQLiteConnectionEventType.DisposingCommand, null, _transaction, this, null, null, null, new object[2] { disposing, disposed }));
		bool flag = false;
		try
		{
			if (disposed || !disposing)
			{
				return;
			}
			SQLiteDataReader sQLiteDataReader = null;
			if (_activeReader != null)
			{
				try
				{
					sQLiteDataReader = _activeReader.Target as SQLiteDataReader;
				}
				catch (InvalidOperationException)
				{
				}
			}
			if (sQLiteDataReader != null)
			{
				sQLiteDataReader._disposeCommand = true;
				_activeReader = null;
				flag = true;
			}
			else
			{
				Connection = null;
				_parameterCollection.Clear();
				_commandText = null;
			}
		}
		finally
		{
			if (!flag)
			{
				base.Dispose(disposing);
				disposed = true;
			}
		}
	}

	internal static SQLiteConnectionFlags GetFlags(SQLiteCommand command)
	{
		try
		{
			if (command != null)
			{
				SQLiteConnection cnn = command._cnn;
				if (cnn != null)
				{
					return cnn.Flags;
				}
			}
		}
		catch (ObjectDisposedException)
		{
		}
		return SQLiteConnectionFlags.Default;
	}

	private void DisposeStatements()
	{
		if (_statementList != null)
		{
			int count = _statementList.Count;
			for (int i = 0; i < count; i++)
			{
				_statementList[i]?.Dispose();
			}
			_statementList = null;
		}
	}

	private void ClearDataReader()
	{
		if (_activeReader != null)
		{
			SQLiteDataReader sQLiteDataReader = null;
			try
			{
				sQLiteDataReader = _activeReader.Target as SQLiteDataReader;
			}
			catch (InvalidOperationException)
			{
			}
			sQLiteDataReader?.Close();
			_activeReader = null;
		}
	}

	internal void ClearCommands()
	{
		ClearDataReader();
		DisposeStatements();
		_parameterCollection.Unbind();
	}

	internal SQLiteStatement BuildNextCommand()
	{
		SQLiteStatement sQLiteStatement = null;
		try
		{
			if (_cnn != null && _cnn._sql != null)
			{
				if (_statementList == null)
				{
					_remainingText = _commandText;
				}
				sQLiteStatement = _cnn._sql.Prepare(_cnn, _remainingText, (_statementList == null) ? null : _statementList[_statementList.Count - 1], (uint)(_commandTimeout * 1000), ref _remainingText);
				if (sQLiteStatement != null)
				{
					sQLiteStatement._command = this;
					if (_statementList == null)
					{
						_statementList = new List<SQLiteStatement>();
					}
					_statementList.Add(sQLiteStatement);
					_parameterCollection.MapParameters(sQLiteStatement);
					sQLiteStatement.BindParameters();
				}
			}
			return sQLiteStatement;
		}
		catch (Exception)
		{
			if (sQLiteStatement != null)
			{
				if (_statementList != null && _statementList.Contains(sQLiteStatement))
				{
					_statementList.Remove(sQLiteStatement);
				}
				sQLiteStatement.Dispose();
			}
			_remainingText = null;
			throw;
		}
	}

	internal SQLiteStatement GetStatement(int index)
	{
		if (_statementList == null)
		{
			return BuildNextCommand();
		}
		if (index == _statementList.Count)
		{
			if (!string.IsNullOrEmpty(_remainingText))
			{
				return BuildNextCommand();
			}
			return null;
		}
		SQLiteStatement sQLiteStatement = _statementList[index];
		sQLiteStatement.BindParameters();
		return sQLiteStatement;
	}

	public override void Cancel()
	{
		CheckDisposed();
		if (_activeReader != null && _activeReader.Target is SQLiteDataReader sQLiteDataReader)
		{
			sQLiteDataReader.Cancel();
		}
	}

	protected override DbParameter CreateDbParameter()
	{
		return CreateParameter();
	}

	public new SQLiteParameter CreateParameter()
	{
		CheckDisposed();
		return new SQLiteParameter(this);
	}

	public void VerifyOnly()
	{
		CheckDisposed();
		SQLiteConnection cnn = _cnn;
		SQLiteBase sql = cnn._sql;
		if (cnn == null || sql == null)
		{
			throw new SQLiteException(_001D(107362263));
		}
		List<SQLiteStatement> list = null;
		SQLiteStatement sQLiteStatement = null;
		try
		{
			string strRemain = _commandText;
			uint timeoutMS = (uint)(_commandTimeout * 1000);
			SQLiteStatement previous = null;
			while (strRemain != null && strRemain.Length > 0)
			{
				sQLiteStatement = sql.Prepare(cnn, strRemain, previous, timeoutMS, ref strRemain);
				previous = sQLiteStatement;
				if (sQLiteStatement != null)
				{
					if (list == null)
					{
						list = new List<SQLiteStatement>();
					}
					list.Add(sQLiteStatement);
					sQLiteStatement = null;
				}
				if (strRemain != null)
				{
					strRemain = strRemain.Trim();
				}
			}
		}
		finally
		{
			if (sQLiteStatement != null)
			{
				sQLiteStatement.Dispose();
				sQLiteStatement = null;
			}
			if (list != null)
			{
				foreach (SQLiteStatement item in list)
				{
					item?.Dispose();
				}
				list.Clear();
				list = null;
			}
		}
	}

	private void InitializeForReader()
	{
		if (_activeReader != null && _activeReader.IsAlive)
		{
			throw new InvalidOperationException(_001D(107362254));
		}
		if (_cnn == null)
		{
			throw new InvalidOperationException(_001D(107362709));
		}
		if (_cnn.State != ConnectionState.Open)
		{
			throw new InvalidOperationException(_001D(107362620));
		}
		if (_cnn._version != _version)
		{
			_version = _cnn._version;
			ClearCommands();
		}
		_parameterCollection.MapParameters(null);
	}

	protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
	{
		return ExecuteReader(behavior);
	}

	public static object Execute(string commandText, SQLiteExecuteType executeType, string connectionString, params object[] args)
	{
		return Execute(commandText, executeType, CommandBehavior.Default, connectionString, args);
	}

	public static object Execute(string commandText, SQLiteExecuteType executeType, CommandBehavior commandBehavior, string connectionString, params object[] args)
	{
		SQLiteConnection sQLiteConnection = null;
		try
		{
			if (connectionString == null)
			{
				connectionString = DefaultConnectionString;
			}
			using (sQLiteConnection = new SQLiteConnection(connectionString))
			{
				sQLiteConnection.Open();
				using SQLiteCommand sQLiteCommand = sQLiteConnection.CreateCommand();
				sQLiteCommand.CommandText = commandText;
				if (args != null)
				{
					foreach (object obj in args)
					{
						SQLiteParameter sQLiteParameter = obj as SQLiteParameter;
						if (sQLiteParameter == null)
						{
							sQLiteParameter = sQLiteCommand.CreateParameter();
							sQLiteParameter.DbType = DbType.Object;
							sQLiteParameter.Value = obj;
						}
						sQLiteCommand.Parameters.Add(sQLiteParameter);
					}
				}
				switch (executeType)
				{
				case SQLiteExecuteType.NonQuery:
					return sQLiteCommand.ExecuteNonQuery(commandBehavior);
				case SQLiteExecuteType.Scalar:
					return sQLiteCommand.ExecuteScalar(commandBehavior);
				case SQLiteExecuteType.Reader:
				{
					bool flag = true;
					try
					{
						return sQLiteCommand.ExecuteReader(commandBehavior | CommandBehavior.CloseConnection);
					}
					catch
					{
						flag = false;
						throw;
					}
					finally
					{
						if (flag)
						{
							sQLiteConnection._noDispose = true;
						}
					}
				}
				case SQLiteExecuteType.None:
					break;
				}
			}
		}
		finally
		{
			if (sQLiteConnection != null)
			{
				sQLiteConnection._noDispose = false;
			}
		}
		return null;
	}

	public new SQLiteDataReader ExecuteReader(CommandBehavior behavior)
	{
		CheckDisposed();
		InitializeForReader();
		SQLiteDataReader sQLiteDataReader = new SQLiteDataReader(this, behavior);
		_activeReader = new WeakReference(sQLiteDataReader, trackResurrection: false);
		return sQLiteDataReader;
	}

	public new SQLiteDataReader ExecuteReader()
	{
		CheckDisposed();
		return ExecuteReader(CommandBehavior.Default);
	}

	internal void ResetDataReader()
	{
		_activeReader = null;
	}

	public override int ExecuteNonQuery()
	{
		CheckDisposed();
		return ExecuteNonQuery(CommandBehavior.Default);
	}

	public int ExecuteNonQuery(CommandBehavior behavior)
	{
		CheckDisposed();
		using SQLiteDataReader sQLiteDataReader = ExecuteReader(behavior | CommandBehavior.SingleRow | CommandBehavior.SingleResult);
		while (sQLiteDataReader.NextResult())
		{
		}
		return sQLiteDataReader.RecordsAffected;
	}

	public override object ExecuteScalar()
	{
		CheckDisposed();
		return ExecuteScalar(CommandBehavior.Default);
	}

	public object ExecuteScalar(CommandBehavior behavior)
	{
		CheckDisposed();
		using (SQLiteDataReader sQLiteDataReader = ExecuteReader(behavior | CommandBehavior.SingleRow | CommandBehavior.SingleResult))
		{
			if (sQLiteDataReader.Read() && sQLiteDataReader.FieldCount > 0)
			{
				return sQLiteDataReader[0];
			}
		}
		return null;
	}

	public void Reset()
	{
		CheckDisposed();
		Reset(clearBindings: true, ignoreErrors: false);
	}

	public void Reset(bool clearBindings, bool ignoreErrors)
	{
		CheckDisposed();
		if (clearBindings && _parameterCollection != null)
		{
			_parameterCollection.Unbind();
		}
		ClearDataReader();
		if (_statementList == null)
		{
			return;
		}
		SQLiteBase sql = _cnn._sql;
		foreach (SQLiteStatement statement in _statementList)
		{
			if (statement == null)
			{
				continue;
			}
			SQLiteStatementHandle sqlite_stmt = statement._sqlite_stmt;
			if (sqlite_stmt != null)
			{
				SQLiteErrorCode sQLiteErrorCode = sql.Reset(statement);
				if (sQLiteErrorCode == SQLiteErrorCode.Ok && clearBindings && SQLite3.SQLiteVersionNumber >= 3003007)
				{
					sQLiteErrorCode = UnsafeNativeMethods.sqlite3_clear_bindings(sqlite_stmt);
				}
				if (!ignoreErrors && sQLiteErrorCode != 0)
				{
					throw new SQLiteException(sQLiteErrorCode, sql.GetLastError());
				}
			}
		}
	}

	public override void Prepare()
	{
		CheckDisposed();
	}

	public object Clone()
	{
		CheckDisposed();
		return new SQLiteCommand(this);
	}

	static SQLiteCommand()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteCommand));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_001D(107400712), _001D(107400675)).Replace(_001D(107400670), _001D(107400665)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_001D(107400692)))
		{
			throw new SecurityException(_001D(107400635));
		}
		DefaultConnectionString = _001D(107362591);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
