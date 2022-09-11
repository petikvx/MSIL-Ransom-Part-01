using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal sealed class SQLiteKeyReader : IDisposable
{
	private struct KeyInfo
	{
		internal string databaseName;

		internal string tableName;

		internal string columnName;

		internal int database;

		internal int rootPage;

		internal int cursor;

		internal KeyQuery query;

		internal int column;
	}

	private struct RowIdInfo
	{
		internal string databaseName;

		internal string tableName;

		internal int column;
	}

	private sealed class KeyQuery : IDisposable
	{
		private SQLiteCommand _command;

		internal SQLiteDataReader _reader;

		private bool disposed;

		[NonSerialized]
		internal static GetString _0006;

		internal bool IsValid
		{
			set
			{
				if (value)
				{
					throw new ArgumentException();
				}
				if (_reader != null)
				{
					_reader.Dispose();
					_reader = null;
				}
			}
		}

		internal KeyQuery(SQLiteConnection cnn, string database, string table, params string[] columns)
		{
			using (SQLiteCommandBuilder sQLiteCommandBuilder = new SQLiteCommandBuilder())
			{
				_command = cnn.CreateCommand();
				for (int i = 0; i < columns.Length; i++)
				{
					columns[i] = sQLiteCommandBuilder.QuoteIdentifier(columns[i]);
				}
			}
			_command.CommandText = HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0006(107382335), string.Join(_0006(107382274), columns), database, table);
			_command.Parameters.AddWithValue(null, 0L);
		}

		internal void Sync(long rowid)
		{
			IsValid = false;
			_command.Parameters[0].Value = rowid;
			_reader = _command.ExecuteReader();
			_reader.Read();
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		private void CheckDisposed()
		{
			if (disposed)
			{
				throw new ObjectDisposedException(typeof(KeyQuery).Name);
			}
		}

		private void Dispose(bool disposing)
		{
			if (disposed)
			{
				return;
			}
			if (disposing)
			{
				IsValid = false;
				if (_command != null)
				{
					_command.Dispose();
				}
				_command = null;
			}
			disposed = true;
		}

		~KeyQuery()
		{
			Dispose(disposing: false);
		}

		static KeyQuery()
		{
			Strings.CreateGetStringDelegate(typeof(KeyQuery));
		}
	}

	private KeyInfo[] _keyInfo;

	private SQLiteStatement _stmt;

	private bool _isValid;

	private RowIdInfo[] _rowIdInfo;

	private bool disposed;

	[NonSerialized]
	internal static GetString _0080;

	internal int Count
	{
		get
		{
			if (_keyInfo != null)
			{
				return _keyInfo.Length;
			}
			return 0;
		}
	}

	internal SQLiteKeyReader(SQLiteConnection cnn, SQLiteDataReader reader, SQLiteStatement stmt)
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		Dictionary<string, List<string>> dictionary2 = new Dictionary<string, List<string>>();
		List<KeyInfo> list = new List<KeyInfo>();
		List<RowIdInfo> list2 = new List<RowIdInfo>();
		_stmt = stmt;
		using (DataTable dataTable = cnn.GetSchema(_0080(107362985)))
		{
			foreach (DataRow row in dataTable.Rows)
			{
				dictionary.Add((string)row[_0080(107354194)], Convert.ToInt32(row[_0080(107354145)], CultureInfo.InvariantCulture));
			}
		}
		using (DataTable dataTable2 = reader.GetSchemaTable(wantUniqueInfo: false, wantDefaultValue: false))
		{
			foreach (DataRow row2 in dataTable2.Rows)
			{
				if (row2[SchemaTableOptionalColumn.BaseCatalogName] != DBNull.Value)
				{
					string key = (string)row2[SchemaTableOptionalColumn.BaseCatalogName];
					string item = (string)row2[SchemaTableColumn.BaseTableName];
					List<string> list3;
					if (!dictionary2.ContainsKey(key))
					{
						list3 = new List<string>();
						dictionary2.Add(key, list3);
					}
					else
					{
						list3 = dictionary2[key];
					}
					if (!list3.Contains(item))
					{
						list3.Add(item);
					}
				}
			}
			foreach (KeyValuePair<string, List<string>> item2 in dictionary2)
			{
				for (int i = 0; i < item2.Value.Count; i++)
				{
					string text = item2.Value[i];
					DataRow dataRow3 = null;
					using DataTable dataTable3 = cnn.GetSchema(_0080(107355987), new string[3] { item2.Key, null, text });
					for (int j = 0; j < 2; j++)
					{
						if (dataRow3 != null)
						{
							break;
						}
						foreach (DataRow row3 in dataTable3.Rows)
						{
							if (j == 0 && (bool)row3[_0080(107355725)])
							{
								dataRow3 = row3;
								break;
							}
							if (j == 1 && (bool)row3[_0080(107355706)])
							{
								dataRow3 = row3;
								break;
							}
						}
					}
					if (dataRow3 == null)
					{
						item2.Value.RemoveAt(i);
						i--;
						continue;
					}
					using DataTable dataTable4 = cnn.GetSchema(_0080(107354599), new string[3] { item2.Key, null, text });
					int database = dictionary[item2.Key];
					int rootPage = Convert.ToInt32(dataTable4.Rows[0][_0080(107354560)], CultureInfo.InvariantCulture);
					int cursorForTable = stmt._sql.GetCursorForTable(stmt, database, rootPage);
					using DataTable dataTable5 = cnn.GetSchema(_0080(107353692), new string[4]
					{
						item2.Key,
						null,
						text,
						(string)dataRow3[_0080(107355904)]
					});
					bool flag = (string)dataRow3[_0080(107355904)] == _0080(107382313) + text;
					KeyQuery query = null;
					List<string> list4 = new List<string>();
					for (int k = 0; k < dataTable5.Rows.Count; k++)
					{
						string stringOrNull = SQLiteConvert.GetStringOrNull(dataTable5.Rows[k][_0080(107356769)]);
						bool flag2 = true;
						foreach (DataRow row4 in dataTable2.Rows)
						{
							if (!row4.IsNull(SchemaTableColumn.BaseColumnName) && (string)row4[SchemaTableColumn.BaseColumnName] == stringOrNull && (string)row4[SchemaTableColumn.BaseTableName] == text && (string)row4[SchemaTableOptionalColumn.BaseCatalogName] == item2.Key)
							{
								if (flag)
								{
									list2.Add(new RowIdInfo
									{
										databaseName = item2.Key,
										tableName = text,
										column = (int)row4[SchemaTableColumn.ColumnOrdinal]
									});
								}
								dataTable5.Rows.RemoveAt(k);
								k--;
								flag2 = false;
								break;
							}
						}
						if (flag2)
						{
							list4.Add(stringOrNull);
						}
					}
					if (!flag && list4.Count > 0)
					{
						string[] array = new string[list4.Count];
						list4.CopyTo(array);
						query = new KeyQuery(cnn, item2.Key, text, array);
					}
					for (int l = 0; l < dataTable5.Rows.Count; l++)
					{
						string stringOrNull2 = SQLiteConvert.GetStringOrNull(dataTable5.Rows[l][_0080(107356769)]);
						list.Add(new KeyInfo
						{
							rootPage = rootPage,
							cursor = cursorForTable,
							database = database,
							databaseName = item2.Key,
							tableName = text,
							columnName = stringOrNull2,
							query = query,
							column = l
						});
					}
				}
			}
		}
		_keyInfo = new KeyInfo[list.Count];
		list.CopyTo(_keyInfo);
		_rowIdInfo = new RowIdInfo[list2.Count];
		list2.CopyTo(_rowIdInfo);
	}

	internal int GetRowIdIndex(string databaseName, string tableName)
	{
		if (_rowIdInfo != null && databaseName != null && tableName != null)
		{
			for (int i = 0; i < _rowIdInfo.Length; i++)
			{
				if (_rowIdInfo[i].databaseName == databaseName && _rowIdInfo[i].tableName == tableName)
				{
					return _rowIdInfo[i].column;
				}
			}
		}
		return -1;
	}

	internal long? GetRowId(string databaseName, string tableName)
	{
		if (_keyInfo != null && databaseName != null && tableName != null)
		{
			for (int i = 0; i < _keyInfo.Length; i++)
			{
				if (_keyInfo[i].databaseName == databaseName && _keyInfo[i].tableName == tableName)
				{
					long rowIdForCursor = _stmt._sql.GetRowIdForCursor(_stmt, _keyInfo[i].cursor);
					if (rowIdForCursor != 0)
					{
						return rowIdForCursor;
					}
				}
			}
		}
		return null;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteKeyReader).Name);
		}
	}

	private void Dispose(bool disposing)
	{
		if (disposed)
		{
			return;
		}
		if (disposing)
		{
			_stmt = null;
			if (_keyInfo != null)
			{
				for (int i = 0; i < _keyInfo.Length; i++)
				{
					if (_keyInfo[i].query != null)
					{
						_keyInfo[i].query.Dispose();
					}
				}
				_keyInfo = null;
			}
		}
		disposed = true;
	}

	~SQLiteKeyReader()
	{
		Dispose(disposing: false);
	}

	private void Sync(int i)
	{
		Sync();
		if (_keyInfo[i].cursor == -1)
		{
			throw new InvalidCastException();
		}
	}

	private void Sync()
	{
		if (_isValid)
		{
			return;
		}
		KeyQuery keyQuery = null;
		for (int i = 0; i < _keyInfo.Length; i++)
		{
			if (_keyInfo[i].query == null || _keyInfo[i].query != keyQuery)
			{
				keyQuery = _keyInfo[i].query;
				keyQuery?.Sync(_stmt._sql.GetRowIdForCursor(_stmt, _keyInfo[i].cursor));
			}
		}
		_isValid = true;
	}

	internal void Reset()
	{
		_isValid = false;
		if (_keyInfo == null)
		{
			return;
		}
		for (int i = 0; i < _keyInfo.Length; i++)
		{
			if (_keyInfo[i].query != null)
			{
				_keyInfo[i].query.IsValid = false;
			}
		}
	}

	internal string GetDataTypeName(int i)
	{
		Sync();
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetDataTypeName(_keyInfo[i].column);
		}
		return _0080(107383750);
	}

	internal Type GetFieldType(int i)
	{
		Sync();
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetFieldType(_keyInfo[i].column);
		}
		return typeof(long);
	}

	internal string GetName(int i)
	{
		return _keyInfo[i].columnName;
	}

	internal int GetOrdinal(string name)
	{
		for (int i = 0; i < _keyInfo.Length; i++)
		{
			if (string.Compare(name, _keyInfo[i].columnName, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return i;
			}
		}
		return -1;
	}

	internal SQLiteBlob GetBlob(int i, bool readOnly)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetBlob(_keyInfo[i].column, readOnly);
		}
		throw new InvalidCastException();
	}

	internal bool GetBoolean(int i)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetBoolean(_keyInfo[i].column);
		}
		throw new InvalidCastException();
	}

	internal byte GetByte(int i)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetByte(_keyInfo[i].column);
		}
		throw new InvalidCastException();
	}

	internal long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetBytes(_keyInfo[i].column, fieldOffset, buffer, bufferoffset, length);
		}
		throw new InvalidCastException();
	}

	internal char GetChar(int i)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetChar(_keyInfo[i].column);
		}
		throw new InvalidCastException();
	}

	internal long GetChars(int i, long fieldOffset, char[] buffer, int bufferoffset, int length)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetChars(_keyInfo[i].column, fieldOffset, buffer, bufferoffset, length);
		}
		throw new InvalidCastException();
	}

	internal DateTime GetDateTime(int i)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetDateTime(_keyInfo[i].column);
		}
		throw new InvalidCastException();
	}

	internal decimal GetDecimal(int i)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetDecimal(_keyInfo[i].column);
		}
		throw new InvalidCastException();
	}

	internal double GetDouble(int i)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetDouble(_keyInfo[i].column);
		}
		throw new InvalidCastException();
	}

	internal float GetFloat(int i)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetFloat(_keyInfo[i].column);
		}
		throw new InvalidCastException();
	}

	internal Guid GetGuid(int i)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetGuid(_keyInfo[i].column);
		}
		throw new InvalidCastException();
	}

	internal short GetInt16(int i)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetInt16(_keyInfo[i].column);
		}
		long rowIdForCursor = _stmt._sql.GetRowIdForCursor(_stmt, _keyInfo[i].cursor);
		if (rowIdForCursor == 0)
		{
			throw new InvalidCastException();
		}
		return Convert.ToInt16(rowIdForCursor);
	}

	internal int GetInt32(int i)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetInt32(_keyInfo[i].column);
		}
		long rowIdForCursor = _stmt._sql.GetRowIdForCursor(_stmt, _keyInfo[i].cursor);
		if (rowIdForCursor == 0)
		{
			throw new InvalidCastException();
		}
		return Convert.ToInt32(rowIdForCursor);
	}

	internal long GetInt64(int i)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetInt64(_keyInfo[i].column);
		}
		long rowIdForCursor = _stmt._sql.GetRowIdForCursor(_stmt, _keyInfo[i].cursor);
		if (rowIdForCursor == 0)
		{
			throw new InvalidCastException();
		}
		return rowIdForCursor;
	}

	internal string GetString(int i)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetString(_keyInfo[i].column);
		}
		throw new InvalidCastException();
	}

	internal object GetValue(int i)
	{
		if (_keyInfo[i].cursor == -1)
		{
			return DBNull.Value;
		}
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetValue(_keyInfo[i].column);
		}
		if (IsDBNull(i))
		{
			return DBNull.Value;
		}
		return GetInt64(i);
	}

	internal bool IsDBNull(int i)
	{
		if (_keyInfo[i].cursor == -1)
		{
			return true;
		}
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.IsDBNull(_keyInfo[i].column);
		}
		return _stmt._sql.GetRowIdForCursor(_stmt, _keyInfo[i].cursor) == 0;
	}

	internal void AppendSchemaTable(DataTable tbl)
	{
		KeyQuery keyQuery = null;
		for (int i = 0; i < _keyInfo.Length; i++)
		{
			if (_keyInfo[i].query != null && _keyInfo[i].query == keyQuery)
			{
				continue;
			}
			keyQuery = _keyInfo[i].query;
			if (keyQuery == null)
			{
				DataRow dataRow = tbl.NewRow();
				dataRow[SchemaTableColumn.ColumnName] = _keyInfo[i].columnName;
				dataRow[SchemaTableColumn.ColumnOrdinal] = tbl.Rows.Count;
				dataRow[SchemaTableColumn.ColumnSize] = 8;
				dataRow[SchemaTableColumn.NumericPrecision] = 255;
				dataRow[SchemaTableColumn.NumericScale] = 255;
				dataRow[SchemaTableColumn.ProviderType] = DbType.Int64;
				dataRow[SchemaTableColumn.IsLong] = false;
				dataRow[SchemaTableColumn.AllowDBNull] = false;
				dataRow[SchemaTableOptionalColumn.IsReadOnly] = false;
				dataRow[SchemaTableOptionalColumn.IsRowVersion] = false;
				dataRow[SchemaTableColumn.IsUnique] = false;
				dataRow[SchemaTableColumn.IsKey] = true;
				dataRow[SchemaTableColumn.DataType] = typeof(long);
				dataRow[SchemaTableOptionalColumn.IsHidden] = true;
				dataRow[SchemaTableColumn.BaseColumnName] = _keyInfo[i].columnName;
				dataRow[SchemaTableColumn.IsExpression] = false;
				dataRow[SchemaTableColumn.IsAliased] = false;
				dataRow[SchemaTableColumn.BaseTableName] = _keyInfo[i].tableName;
				dataRow[SchemaTableOptionalColumn.BaseCatalogName] = _keyInfo[i].databaseName;
				dataRow[SchemaTableOptionalColumn.IsAutoIncrement] = true;
				dataRow[_0080(107355513)] = _0080(107383750);
				tbl.Rows.Add(dataRow);
				continue;
			}
			keyQuery.Sync(0L);
			using DataTable dataTable = keyQuery._reader.GetSchemaTable();
			foreach (DataRow row in dataTable.Rows)
			{
				object[] itemArray = row.ItemArray;
				DataRow dataRow3 = tbl.Rows.Add(itemArray);
				dataRow3[SchemaTableOptionalColumn.IsHidden] = true;
				dataRow3[SchemaTableColumn.ColumnOrdinal] = tbl.Rows.Count - 1;
			}
		}
	}

	static SQLiteKeyReader()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteKeyReader));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0080(107401167), _0080(107401130)), _0080(107401125), _0080(107401120)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0080(107401147)))
		{
			return;
		}
		throw new SecurityException(_0080(107401090));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
