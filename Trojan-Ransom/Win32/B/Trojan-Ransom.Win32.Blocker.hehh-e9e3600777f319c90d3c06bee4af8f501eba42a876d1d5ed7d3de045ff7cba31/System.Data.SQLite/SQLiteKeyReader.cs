using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;

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

	private sealed class KeyQuery : IDisposable
	{
		private SQLiteCommand _command;

		internal SQLiteDataReader _reader;

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
			_command.CommandText = string.Format(CultureInfo.InvariantCulture, "SELECT {0} FROM [{1}].[{2}] WHERE ROWID = ?", new object[3]
			{
				string.Join(",", columns),
				database,
				table
			});
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
			IsValid = false;
			if (_command != null)
			{
				_command.Dispose();
			}
			_command = null;
		}
	}

	private KeyInfo[] _keyInfo;

	private SQLiteStatement _stmt;

	private bool _isValid;

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
		_stmt = stmt;
		using (DataTable dataTable = cnn.GetSchema("Catalogs"))
		{
			foreach (DataRow row in dataTable.Rows)
			{
				dictionary.Add((string)row["CATALOG_NAME"], Convert.ToInt32(row["ID"], CultureInfo.InvariantCulture));
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
					List<string> list2;
					if (!dictionary2.ContainsKey(key))
					{
						list2 = new List<string>();
						dictionary2.Add(key, list2);
					}
					else
					{
						list2 = dictionary2[key];
					}
					if (!list2.Contains(item))
					{
						list2.Add(item);
					}
				}
			}
			foreach (KeyValuePair<string, List<string>> item2 in dictionary2)
			{
				for (int i = 0; i < item2.Value.Count; i++)
				{
					string text = item2.Value[i];
					DataRow dataRow3 = null;
					using DataTable dataTable3 = cnn.GetSchema("Indexes", new string[3] { item2.Key, null, text });
					for (int j = 0; j < 2; j++)
					{
						if (dataRow3 != null)
						{
							break;
						}
						foreach (DataRow row3 in dataTable3.Rows)
						{
							if (j != 0 || !(bool)row3["PRIMARY_KEY"])
							{
								if (j == 1 && (bool)row3["UNIQUE"])
								{
									dataRow3 = row3;
									break;
								}
								continue;
							}
							dataRow3 = row3;
							break;
						}
					}
					if (dataRow3 == null)
					{
						item2.Value.RemoveAt(i);
						i--;
						continue;
					}
					using DataTable dataTable4 = cnn.GetSchema("Tables", new string[3] { item2.Key, null, text });
					int database = dictionary[item2.Key];
					int rootPage = Convert.ToInt32(dataTable4.Rows[0]["TABLE_ROOTPAGE"], CultureInfo.InvariantCulture);
					int cursorForTable = stmt._sql.GetCursorForTable(stmt, database, rootPage);
					using DataTable dataTable5 = cnn.GetSchema("IndexColumns", new string[4]
					{
						item2.Key,
						null,
						text,
						(string)dataRow3["INDEX_NAME"]
					});
					KeyQuery query = null;
					List<string> list3 = new List<string>();
					for (int k = 0; k < dataTable5.Rows.Count; k++)
					{
						bool flag = true;
						foreach (DataRow row4 in dataTable2.Rows)
						{
							if (!row4.IsNull(SchemaTableColumn.BaseColumnName) && (string)row4[SchemaTableColumn.BaseColumnName] == (string)dataTable5.Rows[k]["COLUMN_NAME"] && (string)row4[SchemaTableColumn.BaseTableName] == text && (string)row4[SchemaTableOptionalColumn.BaseCatalogName] == item2.Key)
							{
								dataTable5.Rows.RemoveAt(k);
								k--;
								flag = false;
								break;
							}
						}
						if (flag)
						{
							list3.Add((string)dataTable5.Rows[k]["COLUMN_NAME"]);
						}
					}
					if ((string)dataRow3["INDEX_NAME"] != "sqlite_master_PK_" + text && list3.Count > 0)
					{
						string[] array = new string[list3.Count];
						list3.CopyTo(array);
						query = new KeyQuery(cnn, item2.Key, text, array);
					}
					for (int l = 0; l < dataTable5.Rows.Count; l++)
					{
						string columnName = (string)dataTable5.Rows[l]["COLUMN_NAME"];
						list.Add(new KeyInfo
						{
							rootPage = rootPage,
							cursor = cursorForTable,
							database = database,
							databaseName = item2.Key,
							tableName = text,
							columnName = columnName,
							query = query,
							column = l
						});
					}
				}
			}
		}
		_keyInfo = new KeyInfo[list.Count];
		list.CopyTo(_keyInfo);
	}

	internal void Sync(int i)
	{
		Sync();
		if (_keyInfo[i].cursor == -1)
		{
			throw new InvalidCastException();
		}
	}

	internal void Sync()
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

	public void Dispose()
	{
		_stmt = null;
		if (_keyInfo == null)
		{
			return;
		}
		for (int i = 0; i < _keyInfo.Length; i++)
		{
			if (_keyInfo[i].query != null)
			{
				_keyInfo[i].query.Dispose();
			}
		}
		_keyInfo = null;
	}

	internal string GetDataTypeName(int i)
	{
		Sync();
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetDataTypeName(_keyInfo[i].column);
		}
		return "integer";
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
		int num = 0;
		while (true)
		{
			if (num < _keyInfo.Length)
			{
				if (string.Compare(name, _keyInfo[num].columnName, StringComparison.OrdinalIgnoreCase) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	internal bool GetBoolean(int i)
	{
		Sync(i);
		if (_keyInfo[i].query == null)
		{
			throw new InvalidCastException();
		}
		return _keyInfo[i].query._reader.GetBoolean(_keyInfo[i].column);
	}

	internal byte GetByte(int i)
	{
		Sync(i);
		if (_keyInfo[i].query == null)
		{
			throw new InvalidCastException();
		}
		return _keyInfo[i].query._reader.GetByte(_keyInfo[i].column);
	}

	internal long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
	{
		Sync(i);
		if (_keyInfo[i].query == null)
		{
			throw new InvalidCastException();
		}
		return _keyInfo[i].query._reader.GetBytes(_keyInfo[i].column, fieldOffset, buffer, bufferoffset, length);
	}

	internal char GetChar(int i)
	{
		Sync(i);
		if (_keyInfo[i].query == null)
		{
			throw new InvalidCastException();
		}
		return _keyInfo[i].query._reader.GetChar(_keyInfo[i].column);
	}

	internal long GetChars(int i, long fieldOffset, char[] buffer, int bufferoffset, int length)
	{
		Sync(i);
		if (_keyInfo[i].query == null)
		{
			throw new InvalidCastException();
		}
		return _keyInfo[i].query._reader.GetChars(_keyInfo[i].column, fieldOffset, buffer, bufferoffset, length);
	}

	internal DateTime GetDateTime(int i)
	{
		Sync(i);
		if (_keyInfo[i].query == null)
		{
			throw new InvalidCastException();
		}
		return _keyInfo[i].query._reader.GetDateTime(_keyInfo[i].column);
	}

	internal decimal GetDecimal(int i)
	{
		Sync(i);
		if (_keyInfo[i].query == null)
		{
			throw new InvalidCastException();
		}
		return _keyInfo[i].query._reader.GetDecimal(_keyInfo[i].column);
	}

	internal double GetDouble(int i)
	{
		Sync(i);
		if (_keyInfo[i].query == null)
		{
			throw new InvalidCastException();
		}
		return _keyInfo[i].query._reader.GetDouble(_keyInfo[i].column);
	}

	internal float GetFloat(int i)
	{
		Sync(i);
		if (_keyInfo[i].query == null)
		{
			throw new InvalidCastException();
		}
		return _keyInfo[i].query._reader.GetFloat(_keyInfo[i].column);
	}

	internal Guid GetGuid(int i)
	{
		Sync(i);
		if (_keyInfo[i].query == null)
		{
			throw new InvalidCastException();
		}
		return _keyInfo[i].query._reader.GetGuid(_keyInfo[i].column);
	}

	internal short GetInt16(int i)
	{
		Sync(i);
		if (_keyInfo[i].query != null)
		{
			return _keyInfo[i].query._reader.GetInt16(_keyInfo[i].column);
		}
		long rowIdForCursor = _stmt._sql.GetRowIdForCursor(_stmt, _keyInfo[i].cursor);
		if (rowIdForCursor == 0L)
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
		if (rowIdForCursor == 0L)
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
		if (rowIdForCursor == 0L)
		{
			throw new InvalidCastException();
		}
		return Convert.ToInt64(rowIdForCursor);
	}

	internal string GetString(int i)
	{
		Sync(i);
		if (_keyInfo[i].query == null)
		{
			throw new InvalidCastException();
		}
		return _keyInfo[i].query._reader.GetString(_keyInfo[i].column);
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
		return _stmt._sql.GetRowIdForCursor(_stmt, _keyInfo[i].cursor) == 0L;
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
				dataRow["DataTypeName"] = "integer";
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
}
