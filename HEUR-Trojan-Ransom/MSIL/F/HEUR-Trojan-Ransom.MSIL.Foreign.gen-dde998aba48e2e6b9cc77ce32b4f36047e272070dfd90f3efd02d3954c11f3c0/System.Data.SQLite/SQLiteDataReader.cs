using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Common;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class SQLiteDataReader : DbDataReader
{
	private sealed class ColumnParent : IEqualityComparer<ColumnParent>
	{
		public string DatabaseName;

		public string TableName;

		public string ColumnName;

		public ColumnParent()
		{
		}

		public ColumnParent(string databaseName, string tableName, string columnName)
			: this()
		{
			DatabaseName = databaseName;
			TableName = tableName;
			ColumnName = columnName;
		}

		public bool Equals(ColumnParent x, ColumnParent y)
		{
			if (x == null && y == null)
			{
				return true;
			}
			if (x == null || y == null)
			{
				return false;
			}
			if (!string.Equals(x.DatabaseName, y.DatabaseName, StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			if (!string.Equals(x.TableName, y.TableName, StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			if (!string.Equals(x.ColumnName, y.ColumnName, StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			return true;
		}

		public int GetHashCode(ColumnParent obj)
		{
			int num = 0;
			if (obj != null && obj.DatabaseName != null)
			{
				num ^= obj.DatabaseName.GetHashCode();
			}
			if (obj != null && obj.TableName != null)
			{
				num ^= obj.TableName.GetHashCode();
			}
			if (obj != null && obj.ColumnName != null)
			{
				num ^= obj.ColumnName.GetHashCode();
			}
			return num;
		}
	}

	private SQLiteCommand _command;

	private SQLiteConnectionFlags _flags;

	private int _activeStatementIndex;

	private SQLiteStatement _activeStatement;

	private int _readingState;

	private int _rowsAffected;

	private int _fieldCount;

	private int _stepCount;

	private Dictionary<string, int> _fieldIndexes;

	private SQLiteType[] _fieldTypeArray;

	private CommandBehavior _commandBehavior;

	internal bool _disposeCommand;

	internal bool _throwOnDisposed;

	private SQLiteKeyReader _keyInfo;

	internal int _version;

	private string _baseSchemaName;

	private bool disposed;

	[NonSerialized]
	internal static GetString _008A;

	public override int Depth
	{
		get
		{
			CheckDisposed();
			CheckClosed();
			return 0;
		}
	}

	public override int FieldCount
	{
		get
		{
			CheckDisposed();
			CheckClosed();
			if (_keyInfo == null)
			{
				return _fieldCount;
			}
			return _fieldCount + _keyInfo.Count;
		}
	}

	public int StepCount
	{
		get
		{
			CheckDisposed();
			CheckClosed();
			return _stepCount;
		}
	}

	private int PrivateVisibleFieldCount => _fieldCount;

	public override int VisibleFieldCount
	{
		get
		{
			CheckDisposed();
			CheckClosed();
			return PrivateVisibleFieldCount;
		}
	}

	public override bool HasRows
	{
		get
		{
			CheckDisposed();
			CheckClosed();
			if ((_flags & SQLiteConnectionFlags.StickyHasRows) == SQLiteConnectionFlags.StickyHasRows)
			{
				if (_readingState == 1)
				{
					return _stepCount > 0;
				}
				return true;
			}
			return _readingState != 1;
		}
	}

	public override bool IsClosed
	{
		get
		{
			CheckDisposed();
			return _command == null;
		}
	}

	public override int RecordsAffected
	{
		get
		{
			CheckDisposed();
			return _rowsAffected;
		}
	}

	public override object this[string name]
	{
		get
		{
			CheckDisposed();
			return GetValue(GetOrdinal(name));
		}
	}

	public override object this[int i]
	{
		get
		{
			CheckDisposed();
			return GetValue(i);
		}
	}

	internal SQLiteDataReader(SQLiteCommand cmd, CommandBehavior behave)
	{
		_throwOnDisposed = true;
		_command = cmd;
		_version = _command.Connection._version;
		_baseSchemaName = _command.Connection._baseSchemaName;
		_commandBehavior = behave;
		_activeStatementIndex = -1;
		_rowsAffected = -1;
		RefreshFlags();
		SQLiteConnection.OnChanged(GetConnection(this), new ConnectionEventArgs(SQLiteConnectionEventType.NewDataReader, null, null, _command, this, null, null, new object[1] { behave }));
		if (_command != null)
		{
			NextResult();
		}
	}

	private void CheckDisposed()
	{
		if (disposed && _throwOnDisposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteDataReader).Name);
		}
	}

	protected override void Dispose(bool disposing)
	{
		SQLiteConnection.OnChanged(GetConnection(this), new ConnectionEventArgs(SQLiteConnectionEventType.DisposingDataReader, null, null, _command, this, null, null, new object[9] { disposing, disposed, _commandBehavior, _readingState, _rowsAffected, _stepCount, _fieldCount, _disposeCommand, _throwOnDisposed }));
		try
		{
			if (!disposed)
			{
				_throwOnDisposed = false;
			}
		}
		finally
		{
			base.Dispose(disposing);
			disposed = true;
		}
	}

	internal void Cancel()
	{
		_version = 0;
	}

	public override void Close()
	{
		CheckDisposed();
		SQLiteConnection.OnChanged(GetConnection(this), new ConnectionEventArgs(SQLiteConnectionEventType.ClosingDataReader, null, null, _command, this, null, null, new object[7] { _commandBehavior, _readingState, _rowsAffected, _stepCount, _fieldCount, _disposeCommand, _throwOnDisposed }));
		try
		{
			if (_command != null)
			{
				try
				{
					try
					{
						if (_version != 0)
						{
							try
							{
								while (NextResult())
								{
								}
							}
							catch (SQLiteException)
							{
							}
						}
						_command.ResetDataReader();
					}
					finally
					{
						if ((_commandBehavior & CommandBehavior.CloseConnection) != 0 && _command.Connection != null)
						{
							_command.Connection.Close();
						}
					}
				}
				finally
				{
					if (_disposeCommand)
					{
						_command.Dispose();
					}
				}
			}
			_command = null;
			_activeStatement = null;
			_fieldIndexes = null;
			_fieldTypeArray = null;
		}
		finally
		{
			if (_keyInfo != null)
			{
				_keyInfo.Dispose();
				_keyInfo = null;
			}
		}
	}

	private void CheckClosed()
	{
		if (_throwOnDisposed)
		{
			if (_command == null)
			{
				throw new InvalidOperationException(_008A(107384982));
			}
			if (_version == 0)
			{
				throw new SQLiteException(_008A(107384913));
			}
			SQLiteConnection connection = _command.Connection;
			if (connection._version != _version || connection.State != ConnectionState.Open)
			{
				throw new InvalidOperationException(_008A(107384868));
			}
		}
	}

	private void CheckValidRow()
	{
		if (_readingState != 0)
		{
			throw new InvalidOperationException(_008A(107384803));
		}
	}

	public override IEnumerator GetEnumerator()
	{
		CheckDisposed();
		return new DbEnumerator((IDataReader)this, (_commandBehavior & CommandBehavior.CloseConnection) == CommandBehavior.CloseConnection);
	}

	public void RefreshFlags()
	{
		CheckDisposed();
		_flags = SQLiteCommand.GetFlags(_command);
	}

	private void VerifyForGet()
	{
		CheckClosed();
		CheckValidRow();
	}

	private TypeAffinity VerifyType(int i, DbType typ)
	{
		if ((_flags & SQLiteConnectionFlags.NoVerifyTypeAffinity) == SQLiteConnectionFlags.NoVerifyTypeAffinity)
		{
			return TypeAffinity.None;
		}
		TypeAffinity affinity = GetSQLiteType(_flags, i).Affinity;
		switch (affinity)
		{
		case TypeAffinity.Int64:
			switch (typ)
			{
			case DbType.Int64:
				return affinity;
			case DbType.Int32:
				return affinity;
			case DbType.Int16:
				return affinity;
			case DbType.Byte:
				return affinity;
			case DbType.SByte:
				return affinity;
			case DbType.Boolean:
				return affinity;
			case DbType.DateTime:
				return affinity;
			case DbType.Double:
				return affinity;
			case DbType.Single:
				return affinity;
			case DbType.Decimal:
				return affinity;
			}
			break;
		case TypeAffinity.Double:
			switch (typ)
			{
			case DbType.Double:
				return affinity;
			case DbType.Single:
				return affinity;
			case DbType.Decimal:
				return affinity;
			case DbType.DateTime:
				return affinity;
			}
			break;
		case TypeAffinity.Text:
			switch (typ)
			{
			case DbType.String:
				return affinity;
			case DbType.Guid:
				return affinity;
			case DbType.DateTime:
				return affinity;
			case DbType.Decimal:
				return affinity;
			}
			break;
		case TypeAffinity.Blob:
			switch (typ)
			{
			case DbType.Guid:
				return affinity;
			case DbType.Binary:
				return affinity;
			case DbType.String:
				return affinity;
			}
			break;
		}
		throw new InvalidCastException();
	}

	private void InvokeReadValueCallback(int index, SQLiteReadEventArgs eventArgs, out bool complete)
	{
		complete = false;
		SQLiteConnectionFlags flags = _flags;
		_flags &= ~SQLiteConnectionFlags.UseConnectionReadValueCallbacks;
		try
		{
			string dataTypeName = GetDataTypeName(index);
			if (dataTypeName == null)
			{
				return;
			}
			SQLiteConnection connection = GetConnection(this);
			if (connection != null && connection.TryGetTypeCallbacks(dataTypeName, out var callbacks) && callbacks != null)
			{
				SQLiteReadValueCallback readValueCallback = callbacks.ReadValueCallback;
				if (readValueCallback != null)
				{
					object readValueUserData = callbacks.ReadValueUserData;
					readValueCallback(_activeStatement._sql, this, flags, eventArgs, dataTypeName, index, readValueUserData, out complete);
				}
			}
		}
		finally
		{
			_flags |= SQLiteConnectionFlags.UseConnectionReadValueCallbacks;
		}
	}

	internal long? GetRowId(int i)
	{
		VerifyForGet();
		if (_keyInfo == null)
		{
			return null;
		}
		string databaseName = GetDatabaseName(i);
		string tableName = GetTableName(i);
		int rowIdIndex = _keyInfo.GetRowIdIndex(databaseName, tableName);
		if (rowIdIndex != -1)
		{
			return GetInt64(rowIdIndex);
		}
		return _keyInfo.GetRowId(databaseName, tableName);
	}

	public SQLiteBlob GetBlob(int i, bool readOnly)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107384782), new SQLiteReadBlobEventArgs(readOnly), sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				return sQLiteDataReaderValue.BlobValue;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetBlob(i - PrivateVisibleFieldCount, readOnly);
		}
		return SQLiteBlob.Create(this, i, readOnly);
	}

	public override bool GetBoolean(int i)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107384801), null, sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				if (!sQLiteDataReaderValue.BooleanValue.HasValue)
				{
					throw new SQLiteException(_008A(107384240));
				}
				return sQLiteDataReaderValue.BooleanValue.Value;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetBoolean(i - PrivateVisibleFieldCount);
		}
		VerifyType(i, DbType.Boolean);
		return Convert.ToBoolean(GetValue(i), CultureInfo.CurrentCulture);
	}

	public override byte GetByte(int i)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107384199), null, sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				if (!((int?)sQLiteDataReaderValue.ByteValue).HasValue)
				{
					throw new SQLiteException(_008A(107384218));
				}
				return sQLiteDataReaderValue.ByteValue.Value;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetByte(i - PrivateVisibleFieldCount);
		}
		VerifyType(i, DbType.Byte);
		return _activeStatement._sql.GetByte(_activeStatement, i);
	}

	public override long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteReadArrayEventArgs sQLiteReadArrayEventArgs = new SQLiteReadArrayEventArgs(fieldOffset, buffer, bufferoffset, length);
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107384181), sQLiteReadArrayEventArgs, sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				byte[] bytesValue = sQLiteDataReaderValue.BytesValue;
				if (bytesValue != null)
				{
					Array.Copy(bytesValue, sQLiteReadArrayEventArgs.DataOffset, sQLiteReadArrayEventArgs.ByteBuffer, sQLiteReadArrayEventArgs.BufferOffset, sQLiteReadArrayEventArgs.Length);
					return sQLiteReadArrayEventArgs.Length;
				}
				return -1L;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetBytes(i - PrivateVisibleFieldCount, fieldOffset, buffer, bufferoffset, length);
		}
		VerifyType(i, DbType.Binary);
		return _activeStatement._sql.GetBytes(_activeStatement, i, (int)fieldOffset, buffer, bufferoffset, length);
	}

	public override char GetChar(int i)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107384136), null, sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				if (!((int?)sQLiteDataReaderValue.CharValue).HasValue)
				{
					throw new SQLiteException(_008A(107384155));
				}
				return sQLiteDataReaderValue.CharValue.Value;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetChar(i - PrivateVisibleFieldCount);
		}
		VerifyType(i, DbType.SByte);
		return _activeStatement._sql.GetChar(_activeStatement, i);
	}

	public override long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteReadArrayEventArgs sQLiteReadArrayEventArgs = new SQLiteReadArrayEventArgs(fieldoffset, buffer, bufferoffset, length);
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107384082), sQLiteReadArrayEventArgs, sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				char[] charsValue = sQLiteDataReaderValue.CharsValue;
				if (charsValue != null)
				{
					Array.Copy(charsValue, sQLiteReadArrayEventArgs.DataOffset, sQLiteReadArrayEventArgs.CharBuffer, sQLiteReadArrayEventArgs.BufferOffset, sQLiteReadArrayEventArgs.Length);
					return sQLiteReadArrayEventArgs.Length;
				}
				return -1L;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetChars(i - PrivateVisibleFieldCount, fieldoffset, buffer, bufferoffset, length);
		}
		if ((_flags & SQLiteConnectionFlags.NoVerifyTextAffinity) != SQLiteConnectionFlags.NoVerifyTextAffinity)
		{
			VerifyType(i, DbType.String);
		}
		return _activeStatement._sql.GetChars(_activeStatement, i, (int)fieldoffset, buffer, bufferoffset, length);
	}

	public override string GetDataTypeName(int i)
	{
		CheckDisposed();
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetDataTypeName(i - PrivateVisibleFieldCount);
		}
		TypeAffinity nAffinity = TypeAffinity.Uninitialized;
		return _activeStatement._sql.ColumnType(_activeStatement, i, ref nAffinity);
	}

	public override DateTime GetDateTime(int i)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107384069), null, sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				if (!sQLiteDataReaderValue.DateTimeValue.HasValue)
				{
					throw new SQLiteException(_008A(107384084));
				}
				return sQLiteDataReaderValue.DateTimeValue.Value;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetDateTime(i - PrivateVisibleFieldCount);
		}
		VerifyType(i, DbType.DateTime);
		return _activeStatement._sql.GetDateTime(_activeStatement, i);
	}

	public override decimal GetDecimal(int i)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107384011), null, sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				if (!sQLiteDataReaderValue.DecimalValue.HasValue)
				{
					throw new SQLiteException(_008A(107384026));
				}
				return sQLiteDataReaderValue.DecimalValue.Value;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetDecimal(i - PrivateVisibleFieldCount);
		}
		VerifyType(i, DbType.Decimal);
		return decimal.Parse(_activeStatement._sql.GetText(_activeStatement, i), NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, CultureInfo.InvariantCulture);
	}

	public override double GetDouble(int i)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107384465), null, sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				if (!sQLiteDataReaderValue.DoubleValue.HasValue)
				{
					throw new SQLiteException(_008A(107384452));
				}
				return sQLiteDataReaderValue.DoubleValue.Value;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetDouble(i - PrivateVisibleFieldCount);
		}
		VerifyType(i, DbType.Double);
		return _activeStatement._sql.GetDouble(_activeStatement, i);
	}

	public override Type GetFieldType(int i)
	{
		CheckDisposed();
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetFieldType(i - PrivateVisibleFieldCount);
		}
		return SQLiteConvert.SQLiteTypeToType(GetSQLiteType(_flags, i));
	}

	public override float GetFloat(int i)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107384447), null, sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				if (!sQLiteDataReaderValue.FloatValue.HasValue)
				{
					throw new SQLiteException(_008A(107384402));
				}
				return sQLiteDataReaderValue.FloatValue.Value;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetFloat(i - PrivateVisibleFieldCount);
		}
		VerifyType(i, DbType.Single);
		return Convert.ToSingle(_activeStatement._sql.GetDouble(_activeStatement, i));
	}

	public override Guid GetGuid(int i)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107384365), null, sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				if (!sQLiteDataReaderValue.GuidValue.HasValue)
				{
					throw new SQLiteException(_008A(107384384));
				}
				return sQLiteDataReaderValue.GuidValue.Value;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetGuid(i - PrivateVisibleFieldCount);
		}
		TypeAffinity typeAffinity = VerifyType(i, DbType.Guid);
		if (typeAffinity == TypeAffinity.Blob)
		{
			byte[] array = new byte[16];
			_activeStatement._sql.GetBytes(_activeStatement, i, 0, array, 0, 16);
			return new Guid(array);
		}
		return new Guid(_activeStatement._sql.GetText(_activeStatement, i));
	}

	public override short GetInt16(int i)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107384347), null, sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				if (!((int?)sQLiteDataReaderValue.Int16Value).HasValue)
				{
					throw new SQLiteException(_008A(107384302));
				}
				return sQLiteDataReaderValue.Int16Value.Value;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetInt16(i - PrivateVisibleFieldCount);
		}
		VerifyType(i, DbType.Int16);
		return _activeStatement._sql.GetInt16(_activeStatement, i);
	}

	public override int GetInt32(int i)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107384265), null, sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				if (!sQLiteDataReaderValue.Int32Value.HasValue)
				{
					throw new SQLiteException(_008A(107384284));
				}
				return sQLiteDataReaderValue.Int32Value.Value;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetInt32(i - PrivateVisibleFieldCount);
		}
		VerifyType(i, DbType.Int32);
		return _activeStatement._sql.GetInt32(_activeStatement, i);
	}

	public override long GetInt64(int i)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107383735), null, sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				if (!sQLiteDataReaderValue.Int64Value.HasValue)
				{
					throw new SQLiteException(_008A(107383690));
				}
				return sQLiteDataReaderValue.Int64Value.Value;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetInt64(i - PrivateVisibleFieldCount);
		}
		VerifyType(i, DbType.Int64);
		return _activeStatement._sql.GetInt64(_activeStatement, i);
	}

	public override string GetName(int i)
	{
		CheckDisposed();
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetName(i - PrivateVisibleFieldCount);
		}
		return _activeStatement._sql.ColumnName(_activeStatement, i);
	}

	public string GetDatabaseName(int i)
	{
		CheckDisposed();
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetName(i - PrivateVisibleFieldCount);
		}
		return _activeStatement._sql.ColumnDatabaseName(_activeStatement, i);
	}

	public string GetTableName(int i)
	{
		CheckDisposed();
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetName(i - PrivateVisibleFieldCount);
		}
		return _activeStatement._sql.ColumnTableName(_activeStatement, i);
	}

	public string GetOriginalName(int i)
	{
		CheckDisposed();
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetName(i - PrivateVisibleFieldCount);
		}
		return _activeStatement._sql.ColumnOriginalName(_activeStatement, i);
	}

	public override int GetOrdinal(string name)
	{
		CheckDisposed();
		_ = _throwOnDisposed;
		if (_fieldIndexes == null)
		{
			_fieldIndexes = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
		}
		if (!_fieldIndexes.TryGetValue(name, out var value))
		{
			value = _activeStatement._sql.ColumnIndex(_activeStatement, name);
			if (value == -1 && _keyInfo != null)
			{
				value = _keyInfo.GetOrdinal(name);
				if (value > -1)
				{
					value += PrivateVisibleFieldCount;
				}
			}
			_fieldIndexes.Add(name, value);
		}
		return value;
	}

	public override DataTable GetSchemaTable()
	{
		CheckDisposed();
		return GetSchemaTable(wantUniqueInfo: true, wantDefaultValue: false);
	}

	private static void GetStatementColumnParents(SQLiteBase sql, SQLiteStatement stmt, int fieldCount, ref Dictionary<ColumnParent, List<int>> parentToColumns, ref Dictionary<int, ColumnParent> columnToParent)
	{
		if (parentToColumns == null)
		{
			parentToColumns = new Dictionary<ColumnParent, List<int>>(new ColumnParent());
		}
		if (columnToParent == null)
		{
			columnToParent = new Dictionary<int, ColumnParent>();
		}
		for (int i = 0; i < fieldCount; i++)
		{
			string databaseName = sql.ColumnDatabaseName(stmt, i);
			string tableName = sql.ColumnTableName(stmt, i);
			string columnName = sql.ColumnOriginalName(stmt, i);
			ColumnParent key = new ColumnParent(databaseName, tableName, null);
			ColumnParent value = new ColumnParent(databaseName, tableName, columnName);
			if (!parentToColumns.TryGetValue(key, out var value2))
			{
				parentToColumns.Add(key, new List<int>(new int[1] { i }));
			}
			else if (value2 != null)
			{
				value2.Add(i);
			}
			else
			{
				parentToColumns[key] = new List<int>(new int[1] { i });
			}
			columnToParent.Add(i, value);
		}
	}

	private static int CountParents(Dictionary<ColumnParent, List<int>> parentToColumns)
	{
		int num = 0;
		if (parentToColumns != null)
		{
			foreach (ColumnParent key in parentToColumns.Keys)
			{
				if (key != null)
				{
					string tableName = key.TableName;
					if (!string.IsNullOrEmpty(tableName))
					{
						num++;
					}
				}
			}
			return num;
		}
		return num;
	}

	internal DataTable GetSchemaTable(bool wantUniqueInfo, bool wantDefaultValue)
	{
		CheckClosed();
		_ = _throwOnDisposed;
		Dictionary<ColumnParent, List<int>> parentToColumns = null;
		Dictionary<int, ColumnParent> columnToParent = null;
		GetStatementColumnParents(_command.Connection._sql, _activeStatement, _fieldCount, ref parentToColumns, ref columnToParent);
		DataTable dataTable = new DataTable(_008A(107383653));
		DataTable dataTable2 = null;
		string text = string.Empty;
		string text2 = string.Empty;
		string empty = string.Empty;
		dataTable.Locale = CultureInfo.InvariantCulture;
		dataTable.Columns.Add(SchemaTableColumn.ColumnName, typeof(string));
		dataTable.Columns.Add(SchemaTableColumn.ColumnOrdinal, typeof(int));
		dataTable.Columns.Add(SchemaTableColumn.ColumnSize, typeof(int));
		dataTable.Columns.Add(SchemaTableColumn.NumericPrecision, typeof(int));
		dataTable.Columns.Add(SchemaTableColumn.NumericScale, typeof(int));
		dataTable.Columns.Add(SchemaTableColumn.IsUnique, typeof(bool));
		dataTable.Columns.Add(SchemaTableColumn.IsKey, typeof(bool));
		dataTable.Columns.Add(SchemaTableOptionalColumn.BaseServerName, typeof(string));
		dataTable.Columns.Add(SchemaTableOptionalColumn.BaseCatalogName, typeof(string));
		dataTable.Columns.Add(SchemaTableColumn.BaseColumnName, typeof(string));
		dataTable.Columns.Add(SchemaTableColumn.BaseSchemaName, typeof(string));
		dataTable.Columns.Add(SchemaTableColumn.BaseTableName, typeof(string));
		dataTable.Columns.Add(SchemaTableColumn.DataType, typeof(Type));
		dataTable.Columns.Add(SchemaTableColumn.AllowDBNull, typeof(bool));
		dataTable.Columns.Add(SchemaTableColumn.ProviderType, typeof(int));
		dataTable.Columns.Add(SchemaTableColumn.IsAliased, typeof(bool));
		dataTable.Columns.Add(SchemaTableColumn.IsExpression, typeof(bool));
		dataTable.Columns.Add(SchemaTableOptionalColumn.IsAutoIncrement, typeof(bool));
		dataTable.Columns.Add(SchemaTableOptionalColumn.IsRowVersion, typeof(bool));
		dataTable.Columns.Add(SchemaTableOptionalColumn.IsHidden, typeof(bool));
		dataTable.Columns.Add(SchemaTableColumn.IsLong, typeof(bool));
		dataTable.Columns.Add(SchemaTableOptionalColumn.IsReadOnly, typeof(bool));
		dataTable.Columns.Add(SchemaTableOptionalColumn.ProviderSpecificDataType, typeof(Type));
		dataTable.Columns.Add(SchemaTableOptionalColumn.DefaultValue, typeof(object));
		dataTable.Columns.Add(_008A(107355358), typeof(string));
		dataTable.Columns.Add(_008A(107355821), typeof(string));
		dataTable.BeginLoadData();
		for (int i = 0; i < _fieldCount; i++)
		{
			SQLiteType sQLiteType = GetSQLiteType(_flags, i);
			DataRow dataRow = dataTable.NewRow();
			DbType type = sQLiteType.Type;
			dataRow[SchemaTableColumn.ColumnName] = GetName(i);
			dataRow[SchemaTableColumn.ColumnOrdinal] = i;
			dataRow[SchemaTableColumn.ColumnSize] = SQLiteConvert.DbTypeToColumnSize(type);
			dataRow[SchemaTableColumn.NumericPrecision] = SQLiteConvert.DbTypeToNumericPrecision(type);
			dataRow[SchemaTableColumn.NumericScale] = SQLiteConvert.DbTypeToNumericScale(type);
			dataRow[SchemaTableColumn.ProviderType] = sQLiteType.Type;
			dataRow[SchemaTableColumn.IsLong] = false;
			dataRow[SchemaTableColumn.AllowDBNull] = true;
			dataRow[SchemaTableOptionalColumn.IsReadOnly] = false;
			dataRow[SchemaTableOptionalColumn.IsRowVersion] = false;
			dataRow[SchemaTableColumn.IsUnique] = false;
			dataRow[SchemaTableColumn.IsKey] = false;
			dataRow[SchemaTableOptionalColumn.IsAutoIncrement] = false;
			dataRow[SchemaTableColumn.DataType] = GetFieldType(i);
			dataRow[SchemaTableOptionalColumn.IsHidden] = false;
			dataRow[SchemaTableColumn.BaseSchemaName] = _baseSchemaName;
			empty = columnToParent[i].ColumnName;
			if (!string.IsNullOrEmpty(empty))
			{
				dataRow[SchemaTableColumn.BaseColumnName] = empty;
			}
			dataRow[SchemaTableColumn.IsExpression] = string.IsNullOrEmpty(empty);
			dataRow[SchemaTableColumn.IsAliased] = string.Compare(GetName(i), empty, StringComparison.OrdinalIgnoreCase) != 0;
			string tableName = columnToParent[i].TableName;
			if (!string.IsNullOrEmpty(tableName))
			{
				dataRow[SchemaTableColumn.BaseTableName] = tableName;
			}
			tableName = columnToParent[i].DatabaseName;
			if (!string.IsNullOrEmpty(tableName))
			{
				dataRow[SchemaTableOptionalColumn.BaseCatalogName] = tableName;
			}
			string dataType = null;
			if (!string.IsNullOrEmpty(empty))
			{
				string collateSequence = null;
				bool notNull = false;
				bool primaryKey = false;
				bool autoIncrement = false;
				_command.Connection._sql.ColumnMetaData((string)dataRow[SchemaTableOptionalColumn.BaseCatalogName], (string)dataRow[SchemaTableColumn.BaseTableName], empty, ref dataType, ref collateSequence, ref notNull, ref primaryKey, ref autoIncrement);
				if (notNull || primaryKey)
				{
					dataRow[SchemaTableColumn.AllowDBNull] = false;
				}
				dataRow[SchemaTableColumn.IsKey] = primaryKey && CountParents(parentToColumns) <= 1;
				dataRow[SchemaTableOptionalColumn.IsAutoIncrement] = autoIncrement;
				dataRow[_008A(107355821)] = collateSequence;
				string[] array = dataType.Split(new char[1] { '(' });
				if (array.Length > 1)
				{
					dataType = array[0];
					array = array[1].Split(new char[1] { ')' });
					if (array.Length > 1)
					{
						array = array[0].Split(',', '.');
						if (sQLiteType.Type == DbType.Binary || SQLiteConvert.IsStringDbType(sQLiteType.Type))
						{
							dataRow[SchemaTableColumn.ColumnSize] = Convert.ToInt32(array[0], CultureInfo.InvariantCulture);
						}
						else
						{
							dataRow[SchemaTableColumn.NumericPrecision] = Convert.ToInt32(array[0], CultureInfo.InvariantCulture);
							if (array.Length > 1)
							{
								dataRow[SchemaTableColumn.NumericScale] = Convert.ToInt32(array[1], CultureInfo.InvariantCulture);
							}
						}
					}
				}
				if (wantDefaultValue)
				{
					using SQLiteCommand sQLiteCommand = new SQLiteCommand(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _008A(107383668), dataRow[SchemaTableOptionalColumn.BaseCatalogName], dataRow[SchemaTableColumn.BaseTableName]), _command.Connection);
					using DbDataReader dbDataReader = sQLiteCommand.ExecuteReader();
					while (dbDataReader.Read())
					{
						if (string.Compare((string)dataRow[SchemaTableColumn.BaseColumnName], dbDataReader.GetString(1), StringComparison.OrdinalIgnoreCase) == 0)
						{
							if (!dbDataReader.IsDBNull(4))
							{
								dataRow[SchemaTableOptionalColumn.DefaultValue] = dbDataReader[4];
							}
							break;
						}
					}
				}
				if (wantUniqueInfo)
				{
					if ((string)dataRow[SchemaTableOptionalColumn.BaseCatalogName] != text || (string)dataRow[SchemaTableColumn.BaseTableName] != text2)
					{
						text = (string)dataRow[SchemaTableOptionalColumn.BaseCatalogName];
						text2 = (string)dataRow[SchemaTableColumn.BaseTableName];
						dataTable2 = _command.Connection.GetSchema(_008A(107355832), new string[4]
						{
							(string)dataRow[SchemaTableOptionalColumn.BaseCatalogName],
							null,
							(string)dataRow[SchemaTableColumn.BaseTableName],
							null
						});
					}
					foreach (DataRow row in dataTable2.Rows)
					{
						DataTable schema = _command.Connection.GetSchema(_008A(107353537), new string[5]
						{
							(string)dataRow[SchemaTableOptionalColumn.BaseCatalogName],
							null,
							(string)dataRow[SchemaTableColumn.BaseTableName],
							(string)row[_008A(107355749)],
							null
						});
						foreach (DataRow row2 in schema.Rows)
						{
							if (string.Compare(SQLiteConvert.GetStringOrNull(row2[_008A(107356614)]), empty, StringComparison.OrdinalIgnoreCase) == 0)
							{
								if (parentToColumns.Count == 1 && schema.Rows.Count == 1 && !(bool)dataRow[SchemaTableColumn.AllowDBNull])
								{
									dataRow[SchemaTableColumn.IsUnique] = row[_008A(107355551)];
								}
								if (schema.Rows.Count == 1 && (bool)row[_008A(107355570)] && !string.IsNullOrEmpty(dataType) && string.Compare(dataType, _008A(107383595), StringComparison.OrdinalIgnoreCase) != 0)
								{
								}
								break;
							}
						}
					}
				}
				if (string.IsNullOrEmpty(dataType))
				{
					TypeAffinity nAffinity = TypeAffinity.Uninitialized;
					dataType = _activeStatement._sql.ColumnType(_activeStatement, i, ref nAffinity);
				}
				if (!string.IsNullOrEmpty(dataType))
				{
					dataRow[_008A(107355358)] = dataType;
				}
			}
			dataTable.Rows.Add(dataRow);
		}
		if (_keyInfo != null)
		{
			_keyInfo.AppendSchemaTable(dataTable);
		}
		dataTable.AcceptChanges();
		dataTable.EndLoadData();
		return dataTable;
	}

	public override string GetString(int i)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107383614), null, sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				return sQLiteDataReaderValue.StringValue;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetString(i - PrivateVisibleFieldCount);
		}
		if ((_flags & SQLiteConnectionFlags.NoVerifyTextAffinity) != SQLiteConnectionFlags.NoVerifyTextAffinity)
		{
			VerifyType(i, DbType.String);
		}
		return _activeStatement._sql.GetText(_activeStatement, i);
	}

	public override object GetValue(int i)
	{
		CheckDisposed();
		VerifyForGet();
		if ((_flags & SQLiteConnectionFlags.UseConnectionReadValueCallbacks) == SQLiteConnectionFlags.UseConnectionReadValueCallbacks)
		{
			SQLiteDataReaderValue sQLiteDataReaderValue = new SQLiteDataReaderValue();
			InvokeReadValueCallback(i, new SQLiteReadValueEventArgs(_008A(107383569), null, sQLiteDataReaderValue), out var complete);
			if (complete)
			{
				return sQLiteDataReaderValue.Value;
			}
		}
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.GetValue(i - PrivateVisibleFieldCount);
		}
		SQLiteType sQLiteType = GetSQLiteType(_flags, i);
		if ((_flags & SQLiteConnectionFlags.DetectTextAffinity) == SQLiteConnectionFlags.DetectTextAffinity && (sQLiteType == null || sQLiteType.Affinity == TypeAffinity.Text))
		{
			sQLiteType = GetSQLiteType(sQLiteType, _activeStatement._sql.GetText(_activeStatement, i));
		}
		else if ((_flags & SQLiteConnectionFlags.DetectStringType) == SQLiteConnectionFlags.DetectStringType && (sQLiteType == null || SQLiteConvert.IsStringDbType(sQLiteType.Type)))
		{
			sQLiteType = GetSQLiteType(sQLiteType, _activeStatement._sql.GetText(_activeStatement, i));
		}
		return _activeStatement._sql.GetValue(_activeStatement, _flags, i, sQLiteType);
	}

	public override int GetValues(object[] values)
	{
		CheckDisposed();
		int num = FieldCount;
		if (values.Length < num)
		{
			num = values.Length;
		}
		for (int i = 0; i < num; i++)
		{
			values[i] = GetValue(i);
		}
		return num;
	}

	public NameValueCollection GetValues()
	{
		CheckDisposed();
		if (_activeStatement == null || _activeStatement._sql == null)
		{
			throw new InvalidOperationException();
		}
		int privateVisibleFieldCount = PrivateVisibleFieldCount;
		NameValueCollection nameValueCollection = new NameValueCollection(privateVisibleFieldCount);
		for (int i = 0; i < privateVisibleFieldCount; i++)
		{
			string name = _activeStatement._sql.ColumnName(_activeStatement, i);
			string text = _activeStatement._sql.GetText(_activeStatement, i);
			nameValueCollection.Add(name, text);
		}
		return nameValueCollection;
	}

	public override bool IsDBNull(int i)
	{
		CheckDisposed();
		VerifyForGet();
		if (i >= PrivateVisibleFieldCount && _keyInfo != null)
		{
			return _keyInfo.IsDBNull(i - PrivateVisibleFieldCount);
		}
		return _activeStatement._sql.IsNull(_activeStatement, i);
	}

	public override bool NextResult()
	{
		CheckDisposed();
		CheckClosed();
		_ = _throwOnDisposed;
		SQLiteStatement sQLiteStatement = null;
		bool flag = (_commandBehavior & CommandBehavior.SchemaOnly) != 0;
		int num;
		while (true)
		{
			if (sQLiteStatement == null && _activeStatement != null && _activeStatement._sql != null && _activeStatement._sql.IsOpen())
			{
				if (!flag)
				{
					_activeStatement._sql.Reset(_activeStatement);
				}
				if ((_commandBehavior & CommandBehavior.SingleResult) != 0)
				{
					while (true)
					{
						sQLiteStatement = _command.GetStatement(_activeStatementIndex + 1);
						if (sQLiteStatement == null)
						{
							break;
						}
						_activeStatementIndex++;
						if (!flag && sQLiteStatement._sql.Step(sQLiteStatement))
						{
							_stepCount++;
						}
						if (sQLiteStatement._sql.ColumnCount(sQLiteStatement) == 0)
						{
							int changes = 0;
							bool readOnly = false;
							if (!sQLiteStatement.TryGetChanges(ref changes, ref readOnly))
							{
								return false;
							}
							if (!readOnly)
							{
								if (_rowsAffected == -1)
								{
									_rowsAffected = 0;
								}
								_rowsAffected += changes;
							}
						}
						if (!flag)
						{
							sQLiteStatement._sql.Reset(sQLiteStatement);
						}
					}
					return false;
				}
			}
			sQLiteStatement = _command.GetStatement(_activeStatementIndex + 1);
			if (sQLiteStatement == null)
			{
				return false;
			}
			if (_readingState < 1)
			{
				_readingState = 1;
			}
			_activeStatementIndex++;
			num = sQLiteStatement._sql.ColumnCount(sQLiteStatement);
			if (flag && num != 0)
			{
				break;
			}
			if (!flag && sQLiteStatement._sql.Step(sQLiteStatement))
			{
				_stepCount++;
				_readingState = -1;
				break;
			}
			if (num == 0)
			{
				int changes2 = 0;
				bool readOnly2 = false;
				if (sQLiteStatement.TryGetChanges(ref changes2, ref readOnly2))
				{
					if (!readOnly2)
					{
						if (_rowsAffected == -1)
						{
							_rowsAffected = 0;
						}
						_rowsAffected += changes2;
					}
					if (!flag)
					{
						sQLiteStatement._sql.Reset(sQLiteStatement);
					}
					continue;
				}
				return false;
			}
			_readingState = 1;
			break;
		}
		_activeStatement = sQLiteStatement;
		_fieldCount = num;
		_fieldIndexes = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
		_fieldTypeArray = new SQLiteType[PrivateVisibleFieldCount];
		if ((_commandBehavior & CommandBehavior.KeyInfo) != 0)
		{
			LoadKeyInfo();
		}
		return true;
	}

	internal static SQLiteConnection GetConnection(SQLiteDataReader dataReader)
	{
		try
		{
			if (dataReader != null)
			{
				SQLiteCommand command = dataReader._command;
				if (command != null)
				{
					SQLiteConnection connection = command.Connection;
					if (connection != null)
					{
						return connection;
					}
				}
			}
		}
		catch (ObjectDisposedException)
		{
		}
		return null;
	}

	private SQLiteType GetSQLiteType(SQLiteType oldType, string text)
	{
		if (SQLiteConvert.LooksLikeNull(text))
		{
			return new SQLiteType(TypeAffinity.Null, DbType.Object);
		}
		if (SQLiteConvert.LooksLikeInt64(text))
		{
			return new SQLiteType(TypeAffinity.Int64, DbType.Int64);
		}
		if (SQLiteConvert.LooksLikeDouble(text))
		{
			return new SQLiteType(TypeAffinity.Double, DbType.Double);
		}
		if (_activeStatement != null && SQLiteConvert.LooksLikeDateTime(_activeStatement._sql, text))
		{
			return new SQLiteType(TypeAffinity.DateTime, DbType.DateTime);
		}
		return oldType;
	}

	private SQLiteType GetSQLiteType(SQLiteConnectionFlags flags, int i)
	{
		SQLiteType sQLiteType = _fieldTypeArray[i];
		if (sQLiteType == null)
		{
			sQLiteType = (_fieldTypeArray[i] = new SQLiteType());
		}
		if (sQLiteType.Affinity == TypeAffinity.Uninitialized)
		{
			sQLiteType.Type = SQLiteConvert.TypeNameToDbType(GetConnection(this), _activeStatement._sql.ColumnType(_activeStatement, i, ref sQLiteType.Affinity), flags);
		}
		else
		{
			sQLiteType.Affinity = _activeStatement._sql.ColumnAffinity(_activeStatement, i);
		}
		return sQLiteType;
	}

	public override bool Read()
	{
		CheckDisposed();
		CheckClosed();
		_ = _throwOnDisposed;
		if ((_commandBehavior & CommandBehavior.SchemaOnly) != 0)
		{
			return false;
		}
		if (_readingState == -1)
		{
			_readingState = 0;
			return true;
		}
		if (_readingState == 0)
		{
			if ((_commandBehavior & CommandBehavior.SingleRow) == 0 && _activeStatement._sql.Step(_activeStatement))
			{
				_stepCount++;
				if (_keyInfo != null)
				{
					_keyInfo.Reset();
				}
				return true;
			}
			_readingState = 1;
		}
		return false;
	}

	private void LoadKeyInfo()
	{
		if (_keyInfo != null)
		{
			_keyInfo.Dispose();
			_keyInfo = null;
		}
		_keyInfo = new SQLiteKeyReader(_command.Connection, this, _activeStatement);
	}

	static SQLiteDataReader()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteDataReader));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _008A(107401012), _008A(107400975)), _008A(107400970), _008A(107400965)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _008A(107400992)))
		{
			return;
		}
		throw new SecurityException(_008A(107400935));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
