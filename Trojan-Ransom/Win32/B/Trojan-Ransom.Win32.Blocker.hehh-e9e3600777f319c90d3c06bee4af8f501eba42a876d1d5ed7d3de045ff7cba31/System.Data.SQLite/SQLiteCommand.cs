using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;

namespace System.Data.SQLite;

[Designer("SQLite.Designer.SQLiteCommandDesigner, SQLite.Designer, Version=1.0.37.0, Culture=neutral, PublicKeyToken=db937bc2d44ff139")]
[ToolboxItem(true)]
public sealed class SQLiteCommand : DbCommand, ICloneable
{
	private string _commandText;

	private SQLiteConnection _cnn;

	private long _version;

	private WeakReference _activeReader;

	internal int _commandTimeout;

	private bool _designTimeVisible;

	private UpdateRowSource _updateRowSource;

	private SQLiteParameterCollection _parameterCollection;

	internal List<SQLiteStatement> _statementList;

	internal string _remainingText;

	private SQLiteTransaction _transaction;

	[DefaultValue("")]
	[RefreshProperties(RefreshProperties.All)]
	[Editor("Microsoft.VSDesigner.Data.SQL.Design.SqlCommandTextEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public override string CommandText
	{
		get
		{
			return _commandText;
		}
		set
		{
			if (!(_commandText == value))
			{
				if (_activeReader != null && _activeReader.IsAlive)
				{
					throw new InvalidOperationException("Cannot set CommandText while a DataReader is active");
				}
				ClearCommands();
				_commandText = value;
			}
		}
	}

	[DefaultValue(30)]
	public override int CommandTimeout
	{
		get
		{
			return _commandTimeout;
		}
		set
		{
			_commandTimeout = value;
		}
	}

	[DefaultValue(CommandType.Text)]
	[RefreshProperties(RefreshProperties.All)]
	public override CommandType CommandType
	{
		get
		{
			return CommandType.Text;
		}
		set
		{
			if (value != CommandType.Text)
			{
				throw new NotSupportedException();
			}
		}
	}

	[DefaultValue(null)]
	[Editor("Microsoft.VSDesigner.Data.Design.DbConnectionEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public new SQLiteConnection Connection
	{
		get
		{
			return _cnn;
		}
		set
		{
			if (_activeReader != null && _activeReader.IsAlive)
			{
				throw new InvalidOperationException("Cannot set Connection while a DataReader is active");
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
	public new SQLiteParameterCollection Parameters => _parameterCollection;

	protected override DbParameterCollection DbParameterCollection => Parameters;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public new SQLiteTransaction Transaction
	{
		get
		{
			return _transaction;
		}
		set
		{
			if (_cnn != null)
			{
				if (_activeReader != null && _activeReader.IsAlive)
				{
					throw new InvalidOperationException("Cannot set Transaction while a DataReader is active");
				}
				if (value != null && value._cnn != _cnn)
				{
					throw new ArgumentException("Transaction is not associated with the command's connection");
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
			return _updateRowSource;
		}
		set
		{
			_updateRowSource = value;
		}
	}

	[DefaultValue(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignOnly(true)]
	[Browsable(false)]
	public override bool DesignTimeVisible
	{
		get
		{
			return _designTimeVisible;
		}
		set
		{
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
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (!disposing)
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
		}
		else
		{
			Connection = null;
			_parameterCollection.Clear();
			_commandText = null;
		}
	}

	internal void ClearCommands()
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
		if (_statementList != null)
		{
			int count = _statementList.Count;
			for (int i = 0; i < count; i++)
			{
				_statementList[i].Dispose();
			}
			_statementList = null;
			_parameterCollection.Unbind();
		}
	}

	internal SQLiteStatement BuildNextCommand()
	{
		SQLiteStatement sQLiteStatement = null;
		try
		{
			if (_statementList == null)
			{
				_remainingText = _commandText;
			}
			sQLiteStatement = _cnn._sql.Prepare(_cnn, _remainingText, (_statementList == null) ? null : _statementList[_statementList.Count - 1], (uint)(_commandTimeout * 1000), out _remainingText);
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
			return sQLiteStatement;
		}
		catch (Exception)
		{
			if (sQLiteStatement != null)
			{
				if (_statementList.Contains(sQLiteStatement))
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
		return new SQLiteParameter();
	}

	private void InitializeForReader()
	{
		if (_activeReader != null && _activeReader.IsAlive)
		{
			throw new InvalidOperationException("DataReader already active on this command");
		}
		if (_cnn == null)
		{
			throw new InvalidOperationException("No connection associated with this command");
		}
		if (_cnn.State != ConnectionState.Open)
		{
			throw new InvalidOperationException("Database is not open");
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

	public new SQLiteDataReader ExecuteReader(CommandBehavior behavior)
	{
		InitializeForReader();
		SQLiteDataReader sQLiteDataReader = new SQLiteDataReader(this, behavior);
		_activeReader = new WeakReference(sQLiteDataReader, trackResurrection: false);
		return sQLiteDataReader;
	}

	public new SQLiteDataReader ExecuteReader()
	{
		return ExecuteReader(CommandBehavior.Default);
	}

	internal void ClearDataReader()
	{
		_activeReader = null;
	}

	public override int ExecuteNonQuery()
	{
		using SQLiteDataReader sQLiteDataReader = ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.SingleRow);
		while (sQLiteDataReader.NextResult())
		{
		}
		return sQLiteDataReader.RecordsAffected;
	}

	public override object ExecuteScalar()
	{
		using (SQLiteDataReader sQLiteDataReader = ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.SingleRow))
		{
			if (sQLiteDataReader.Read())
			{
				return sQLiteDataReader[0];
			}
		}
		return null;
	}

	public override void Prepare()
	{
	}

	public object Clone()
	{
		return new SQLiteCommand(this);
	}
}
