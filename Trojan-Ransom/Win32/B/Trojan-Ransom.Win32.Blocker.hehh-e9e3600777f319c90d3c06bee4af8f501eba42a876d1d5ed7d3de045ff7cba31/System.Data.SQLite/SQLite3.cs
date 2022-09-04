using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace System.Data.SQLite;

internal class SQLite3 : SQLiteBase
{
	protected SQLiteConnectionHandle _sql;

	protected string _fileName;

	protected bool _usePool;

	protected int _poolVersion;

	private bool _buildingSchema;

	protected SQLiteFunction[] _functionsArray;

	internal override string Version => SQLiteVersion;

	internal static string SQLiteVersion => SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_libversion(), -1);

	internal override bool AutoCommit => SQLiteBase.IsAutocommit(_sql);

	internal override int Changes => UnsafeNativeMethods.sqlite3_changes(_sql);

	internal SQLite3(SQLiteDateFormats fmt)
		: base(fmt)
	{
	}

	protected override void Dispose(bool bDisposing)
	{
		if (bDisposing)
		{
			Close();
		}
	}

	internal override void Close()
	{
		if (_sql != null)
		{
			if (_usePool)
			{
				SQLiteBase.ResetConnection(_sql);
				SQLiteConnectionPool.Add(_fileName, _sql, _poolVersion);
			}
			else
			{
				_sql.Dispose();
			}
		}
		_sql = null;
	}

	internal override void Cancel()
	{
		UnsafeNativeMethods.sqlite3_interrupt(_sql);
	}

	internal override void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool)
	{
		if (_sql != null)
		{
			return;
		}
		_usePool = usePool;
		if (usePool)
		{
			_fileName = strFilename;
			_sql = SQLiteConnectionPool.Remove(strFilename, maxPoolSize, out _poolVersion);
		}
		if (_sql == null)
		{
			IntPtr db;
			int num = UnsafeNativeMethods.sqlite3_open_interop(SQLiteConvert.ToUTF8(strFilename), (int)flags, out db);
			if (num > 0)
			{
				throw new SQLiteException(num, null);
			}
			_sql = db;
		}
		_functionsArray = SQLiteFunction.BindFunctions(this);
		SetTimeout(0);
	}

	internal override void ClearPool()
	{
		SQLiteConnectionPool.ClearPool(_fileName);
	}

	internal override void SetTimeout(int nTimeoutMS)
	{
		int num = UnsafeNativeMethods.sqlite3_busy_timeout(_sql, nTimeoutMS);
		if (num > 0)
		{
			throw new SQLiteException(num, SQLiteLastError());
		}
	}

	internal override bool Step(SQLiteStatement stmt)
	{
		Random random = null;
		uint tickCount = (uint)Environment.TickCount;
		uint num = (uint)(stmt._command._commandTimeout * 1000);
		while (true)
		{
			int num2 = UnsafeNativeMethods.sqlite3_step(stmt._sqlite_stmt);
			if (num2 != 100)
			{
				if (num2 == 101)
				{
					break;
				}
				if (num2 <= 0)
				{
					continue;
				}
				int num3 = Reset(stmt);
				switch (num3)
				{
				case 5:
				case 6:
					if (stmt._command != null)
					{
						if (random == null)
						{
							random = new Random();
						}
						if ((uint)(Environment.TickCount - (int)tickCount) > num)
						{
							throw new SQLiteException(num3, SQLiteLastError());
						}
						Thread.Sleep(random.Next(1, 150));
					}
					break;
				case 0:
					throw new SQLiteException(num2, SQLiteLastError());
				}
				continue;
			}
			return true;
		}
		return false;
	}

	internal override int Reset(SQLiteStatement stmt)
	{
		int num = UnsafeNativeMethods.sqlite3_reset_interop(stmt._sqlite_stmt);
		if (num == 17)
		{
			string strRemain;
			using (SQLiteStatement sQLiteStatement = Prepare(null, stmt._sqlStatement, null, (uint)(stmt._command._commandTimeout * 1000), out strRemain))
			{
				stmt._sqlite_stmt.Dispose();
				stmt._sqlite_stmt = sQLiteStatement._sqlite_stmt;
				sQLiteStatement._sqlite_stmt = null;
				stmt.BindParameters();
			}
			return -1;
		}
		if (num != 6 && num != 5)
		{
			if (num > 0)
			{
				throw new SQLiteException(num, SQLiteLastError());
			}
			return 0;
		}
		return num;
	}

	internal override string SQLiteLastError()
	{
		return SQLiteBase.SQLiteLastError(_sql);
	}

	internal override SQLiteStatement Prepare(SQLiteConnection cnn, string strSql, SQLiteStatement previous, uint timeoutMS, out string strRemain)
	{
		IntPtr stmt = IntPtr.Zero;
		IntPtr ptrRemain = IntPtr.Zero;
		int nRemain = 0;
		int num = 17;
		int num2 = 0;
		byte[] array = SQLiteConvert.ToUTF8(strSql);
		string text = null;
		SQLiteStatement sQLiteStatement = null;
		Random random = null;
		uint tickCount = (uint)Environment.TickCount;
		GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
		IntPtr pSql = gCHandle.AddrOfPinnedObject();
		try
		{
			while ((num == 17 || num == 6 || num == 5) && num2 < 3)
			{
				num = UnsafeNativeMethods.sqlite3_prepare_interop(_sql, pSql, array.Length - 1, out stmt, out ptrRemain, out nRemain);
				switch (num)
				{
				case 17:
					num2++;
					break;
				case 1:
				{
					if (string.Compare(SQLiteLastError(), "near \"TYPES\": syntax error", StringComparison.OrdinalIgnoreCase) != 0)
					{
						if (_buildingSchema || string.Compare(SQLiteLastError(), 0, "no such table: TEMP.SCHEMA", 0, 26, StringComparison.OrdinalIgnoreCase) != 0)
						{
							break;
						}
						strRemain = "";
						_buildingSchema = true;
						try
						{
							if (((IServiceProvider)SQLiteFactory.Instance).GetService(typeof(ISQLiteSchemaExtensions)) is ISQLiteSchemaExtensions iSQLiteSchemaExtensions)
							{
								iSQLiteSchemaExtensions.BuildTempSchema(cnn);
							}
							while (sQLiteStatement == null && strSql.Length > 0)
							{
								sQLiteStatement = Prepare(cnn, strSql, previous, timeoutMS, out strRemain);
								strSql = strRemain;
							}
							return sQLiteStatement;
						}
						finally
						{
							_buildingSchema = false;
						}
					}
					int num3 = strSql.IndexOf(';');
					if (num3 == -1)
					{
						num3 = strSql.Length - 1;
					}
					text = strSql.Substring(0, num3 + 1);
					strSql = strSql.Substring(num3 + 1);
					strRemain = "";
					while (sQLiteStatement == null && strSql.Length > 0)
					{
						sQLiteStatement = Prepare(cnn, strSql, previous, timeoutMS, out strRemain);
						strSql = strRemain;
					}
					sQLiteStatement?.SetTypes(text);
					return sQLiteStatement;
				}
				case 5:
				case 6:
					if (random == null)
					{
						random = new Random();
					}
					if ((uint)(Environment.TickCount - (int)tickCount) <= timeoutMS)
					{
						Thread.Sleep(random.Next(1, 150));
						break;
					}
					throw new SQLiteException(num, SQLiteLastError());
				}
			}
			if (num > 0)
			{
				throw new SQLiteException(num, SQLiteLastError());
			}
			strRemain = SQLiteConvert.UTF8ToString(ptrRemain, nRemain);
			if (stmt != IntPtr.Zero)
			{
				sQLiteStatement = new SQLiteStatement(this, stmt, strSql.Substring(0, strSql.Length - strRemain.Length), previous);
			}
			return sQLiteStatement;
		}
		finally
		{
			gCHandle.Free();
		}
	}

	internal override void Bind_Double(SQLiteStatement stmt, int index, double value)
	{
		int num = UnsafeNativeMethods.sqlite3_bind_double(stmt._sqlite_stmt, index, value);
		if (num > 0)
		{
			throw new SQLiteException(num, SQLiteLastError());
		}
	}

	internal override void Bind_Int32(SQLiteStatement stmt, int index, int value)
	{
		int num = UnsafeNativeMethods.sqlite3_bind_int(stmt._sqlite_stmt, index, value);
		if (num > 0)
		{
			throw new SQLiteException(num, SQLiteLastError());
		}
	}

	internal override void Bind_Int64(SQLiteStatement stmt, int index, long value)
	{
		int num = UnsafeNativeMethods.sqlite3_bind_int64(stmt._sqlite_stmt, index, value);
		if (num > 0)
		{
			throw new SQLiteException(num, SQLiteLastError());
		}
	}

	internal override void Bind_Text(SQLiteStatement stmt, int index, string value)
	{
		byte[] array = SQLiteConvert.ToUTF8(value);
		int num = UnsafeNativeMethods.sqlite3_bind_text(stmt._sqlite_stmt, index, array, array.Length - 1, (IntPtr)(-1));
		if (num > 0)
		{
			throw new SQLiteException(num, SQLiteLastError());
		}
	}

	internal override void Bind_DateTime(SQLiteStatement stmt, int index, DateTime dt)
	{
		byte[] array = ToUTF8(dt);
		int num = UnsafeNativeMethods.sqlite3_bind_text(stmt._sqlite_stmt, index, array, array.Length - 1, (IntPtr)(-1));
		if (num > 0)
		{
			throw new SQLiteException(num, SQLiteLastError());
		}
	}

	internal override void Bind_Blob(SQLiteStatement stmt, int index, byte[] blobData)
	{
		int num = UnsafeNativeMethods.sqlite3_bind_blob(stmt._sqlite_stmt, index, blobData, blobData.Length, (IntPtr)(-1));
		if (num > 0)
		{
			throw new SQLiteException(num, SQLiteLastError());
		}
	}

	internal override void Bind_Null(SQLiteStatement stmt, int index)
	{
		int num = UnsafeNativeMethods.sqlite3_bind_null(stmt._sqlite_stmt, index);
		if (num > 0)
		{
			throw new SQLiteException(num, SQLiteLastError());
		}
	}

	internal override int Bind_ParamCount(SQLiteStatement stmt)
	{
		return UnsafeNativeMethods.sqlite3_bind_parameter_count(stmt._sqlite_stmt);
	}

	internal override string Bind_ParamName(SQLiteStatement stmt, int index)
	{
		int len;
		return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_bind_parameter_name_interop(stmt._sqlite_stmt, index, out len), len);
	}

	internal override int Bind_ParamIndex(SQLiteStatement stmt, string paramName)
	{
		return UnsafeNativeMethods.sqlite3_bind_parameter_index(stmt._sqlite_stmt, SQLiteConvert.ToUTF8(paramName));
	}

	internal override int ColumnCount(SQLiteStatement stmt)
	{
		return UnsafeNativeMethods.sqlite3_column_count(stmt._sqlite_stmt);
	}

	internal override string ColumnName(SQLiteStatement stmt, int index)
	{
		int len;
		return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_column_name_interop(stmt._sqlite_stmt, index, out len), len);
	}

	internal override TypeAffinity ColumnAffinity(SQLiteStatement stmt, int index)
	{
		return UnsafeNativeMethods.sqlite3_column_type(stmt._sqlite_stmt, index);
	}

	internal override string ColumnType(SQLiteStatement stmt, int index, out TypeAffinity nAffinity)
	{
		int len;
		IntPtr intPtr = UnsafeNativeMethods.sqlite3_column_decltype_interop(stmt._sqlite_stmt, index, out len);
		nAffinity = ColumnAffinity(stmt, index);
		if (intPtr != IntPtr.Zero)
		{
			return SQLiteConvert.UTF8ToString(intPtr, len);
		}
		string[] typeDefinitions = stmt.TypeDefinitions;
		if (typeDefinitions != null && index < typeDefinitions.Length && typeDefinitions[index] != null)
		{
			return typeDefinitions[index];
		}
		return string.Empty;
	}

	internal override int ColumnIndex(SQLiteStatement stmt, string columnName)
	{
		int num = ColumnCount(stmt);
		int num2 = 0;
		while (true)
		{
			if (num2 < num)
			{
				if (string.Compare(columnName, ColumnName(stmt, num2), StringComparison.OrdinalIgnoreCase) == 0)
				{
					break;
				}
				num2++;
				continue;
			}
			return -1;
		}
		return num2;
	}

	internal override string ColumnOriginalName(SQLiteStatement stmt, int index)
	{
		int len;
		return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_column_origin_name_interop(stmt._sqlite_stmt, index, out len), len);
	}

	internal override string ColumnDatabaseName(SQLiteStatement stmt, int index)
	{
		int len;
		return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_column_database_name_interop(stmt._sqlite_stmt, index, out len), len);
	}

	internal override string ColumnTableName(SQLiteStatement stmt, int index)
	{
		int len;
		return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_column_table_name_interop(stmt._sqlite_stmt, index, out len), len);
	}

	internal override void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement)
	{
		IntPtr ptrDataType;
		IntPtr ptrCollSeq;
		int notNull2;
		int primaryKey2;
		int autoInc;
		int dtLen;
		int csLen;
		int num = UnsafeNativeMethods.sqlite3_table_column_metadata_interop(_sql, SQLiteConvert.ToUTF8(dataBase), SQLiteConvert.ToUTF8(table), SQLiteConvert.ToUTF8(column), out ptrDataType, out ptrCollSeq, out notNull2, out primaryKey2, out autoInc, out dtLen, out csLen);
		if (num > 0)
		{
			throw new SQLiteException(num, SQLiteLastError());
		}
		dataType = SQLiteConvert.UTF8ToString(ptrDataType, dtLen);
		collateSequence = SQLiteConvert.UTF8ToString(ptrCollSeq, csLen);
		notNull = notNull2 == 1;
		primaryKey = primaryKey2 == 1;
		autoIncrement = autoInc == 1;
	}

	internal override double GetDouble(SQLiteStatement stmt, int index)
	{
		return UnsafeNativeMethods.sqlite3_column_double(stmt._sqlite_stmt, index);
	}

	internal override int GetInt32(SQLiteStatement stmt, int index)
	{
		return UnsafeNativeMethods.sqlite3_column_int(stmt._sqlite_stmt, index);
	}

	internal override long GetInt64(SQLiteStatement stmt, int index)
	{
		return UnsafeNativeMethods.sqlite3_column_int64(stmt._sqlite_stmt, index);
	}

	internal override string GetText(SQLiteStatement stmt, int index)
	{
		int len;
		return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_column_text_interop(stmt._sqlite_stmt, index, out len), len);
	}

	internal override DateTime GetDateTime(SQLiteStatement stmt, int index)
	{
		int len;
		return ToDateTime(UnsafeNativeMethods.sqlite3_column_text_interop(stmt._sqlite_stmt, index, out len), len);
	}

	internal override long GetBytes(SQLiteStatement stmt, int index, int nDataOffset, byte[] bDest, int nStart, int nLength)
	{
		int num = nLength;
		int num2 = UnsafeNativeMethods.sqlite3_column_bytes(stmt._sqlite_stmt, index);
		IntPtr intPtr = UnsafeNativeMethods.sqlite3_column_blob(stmt._sqlite_stmt, index);
		if (bDest == null)
		{
			return num2;
		}
		if (num + nStart > bDest.Length)
		{
			num = bDest.Length - nStart;
		}
		if (num + nDataOffset > num2)
		{
			num = num2 - nDataOffset;
		}
		if (num > 0)
		{
			Marshal.Copy((IntPtr)(intPtr.ToInt64() + nDataOffset), bDest, nStart, num);
		}
		else
		{
			num = 0;
		}
		return num;
	}

	internal override long GetChars(SQLiteStatement stmt, int index, int nDataOffset, char[] bDest, int nStart, int nLength)
	{
		int num = nLength;
		string text = GetText(stmt, index);
		int length = text.Length;
		if (bDest == null)
		{
			return length;
		}
		if (num + nStart > bDest.Length)
		{
			num = bDest.Length - nStart;
		}
		if (num + nDataOffset > length)
		{
			num = length - nDataOffset;
		}
		if (num > 0)
		{
			text.CopyTo(nDataOffset, bDest, nStart, num);
		}
		else
		{
			num = 0;
		}
		return num;
	}

	internal override bool IsNull(SQLiteStatement stmt, int index)
	{
		return ColumnAffinity(stmt, index) == TypeAffinity.Null;
	}

	internal override int AggregateCount(IntPtr context)
	{
		return UnsafeNativeMethods.sqlite3_aggregate_count(context);
	}

	internal override void CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal)
	{
		int num = UnsafeNativeMethods.sqlite3_create_function_interop(_sql, SQLiteConvert.ToUTF8(strFunction), nArgs, 4, IntPtr.Zero, func, funcstep, funcfinal, needCollSeq ? 1 : 0);
		if (num == 0)
		{
			num = UnsafeNativeMethods.sqlite3_create_function_interop(_sql, SQLiteConvert.ToUTF8(strFunction), nArgs, 1, IntPtr.Zero, func, funcstep, funcfinal, needCollSeq ? 1 : 0);
		}
		if (num > 0)
		{
			throw new SQLiteException(num, SQLiteLastError());
		}
	}

	internal override void CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16)
	{
		int num = UnsafeNativeMethods.sqlite3_create_collation(_sql, SQLiteConvert.ToUTF8(strCollation), 2, IntPtr.Zero, func16);
		if (num == 0)
		{
			num = UnsafeNativeMethods.sqlite3_create_collation(_sql, SQLiteConvert.ToUTF8(strCollation), 1, IntPtr.Zero, func);
		}
		if (num > 0)
		{
			throw new SQLiteException(num, SQLiteLastError());
		}
	}

	internal override int ContextCollateCompare(CollationEncodingEnum enc, IntPtr context, string s1, string s2)
	{
		Encoding encoding = null;
		switch (enc)
		{
		case CollationEncodingEnum.UTF8:
			encoding = Encoding.UTF8;
			break;
		case CollationEncodingEnum.UTF16LE:
			encoding = Encoding.Unicode;
			break;
		case CollationEncodingEnum.UTF16BE:
			encoding = Encoding.BigEndianUnicode;
			break;
		}
		byte[] bytes = encoding.GetBytes(s1);
		byte[] bytes2 = encoding.GetBytes(s2);
		return UnsafeNativeMethods.sqlite3_context_collcompare(context, bytes, bytes.Length, bytes2, bytes2.Length);
	}

	internal override int ContextCollateCompare(CollationEncodingEnum enc, IntPtr context, char[] c1, char[] c2)
	{
		Encoding encoding = null;
		switch (enc)
		{
		case CollationEncodingEnum.UTF8:
			encoding = Encoding.UTF8;
			break;
		case CollationEncodingEnum.UTF16LE:
			encoding = Encoding.Unicode;
			break;
		case CollationEncodingEnum.UTF16BE:
			encoding = Encoding.BigEndianUnicode;
			break;
		}
		byte[] bytes = encoding.GetBytes(c1);
		byte[] bytes2 = encoding.GetBytes(c2);
		return UnsafeNativeMethods.sqlite3_context_collcompare(context, bytes, bytes.Length, bytes2, bytes2.Length);
	}

	internal override CollationSequence GetCollationSequence(SQLiteFunction func, IntPtr context)
	{
		CollationSequence result = default(CollationSequence);
		int type;
		int enc;
		int len;
		IntPtr nativestring = UnsafeNativeMethods.sqlite3_context_collseq(context, out type, out enc, out len);
		result.Name = SQLiteConvert.UTF8ToString(nativestring, len);
		result.Type = (CollationTypeEnum)type;
		result._func = func;
		result.Encoding = (CollationEncodingEnum)enc;
		return result;
	}

	internal override long GetParamValueBytes(IntPtr p, int nDataOffset, byte[] bDest, int nStart, int nLength)
	{
		int num = nLength;
		int num2 = UnsafeNativeMethods.sqlite3_value_bytes(p);
		IntPtr intPtr = UnsafeNativeMethods.sqlite3_value_blob(p);
		if (bDest == null)
		{
			return num2;
		}
		if (num + nStart > bDest.Length)
		{
			num = bDest.Length - nStart;
		}
		if (num + nDataOffset > num2)
		{
			num = num2 - nDataOffset;
		}
		if (num > 0)
		{
			Marshal.Copy((IntPtr)(intPtr.ToInt32() + nDataOffset), bDest, nStart, num);
		}
		else
		{
			num = 0;
		}
		return num;
	}

	internal override double GetParamValueDouble(IntPtr ptr)
	{
		return UnsafeNativeMethods.sqlite3_value_double(ptr);
	}

	internal override int GetParamValueInt32(IntPtr ptr)
	{
		return UnsafeNativeMethods.sqlite3_value_int(ptr);
	}

	internal override long GetParamValueInt64(IntPtr ptr)
	{
		return UnsafeNativeMethods.sqlite3_value_int64(ptr);
	}

	internal override string GetParamValueText(IntPtr ptr)
	{
		int len;
		return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_value_text_interop(ptr, out len), len);
	}

	internal override TypeAffinity GetParamValueType(IntPtr ptr)
	{
		return UnsafeNativeMethods.sqlite3_value_type(ptr);
	}

	internal override void ReturnBlob(IntPtr context, byte[] value)
	{
		UnsafeNativeMethods.sqlite3_result_blob(context, value, value.Length, (IntPtr)(-1));
	}

	internal override void ReturnDouble(IntPtr context, double value)
	{
		UnsafeNativeMethods.sqlite3_result_double(context, value);
	}

	internal override void ReturnError(IntPtr context, string value)
	{
		UnsafeNativeMethods.sqlite3_result_error(context, SQLiteConvert.ToUTF8(value), value.Length);
	}

	internal override void ReturnInt32(IntPtr context, int value)
	{
		UnsafeNativeMethods.sqlite3_result_int(context, value);
	}

	internal override void ReturnInt64(IntPtr context, long value)
	{
		UnsafeNativeMethods.sqlite3_result_int64(context, value);
	}

	internal override void ReturnNull(IntPtr context)
	{
		UnsafeNativeMethods.sqlite3_result_null(context);
	}

	internal override void ReturnText(IntPtr context, string value)
	{
		byte[] array = SQLiteConvert.ToUTF8(value);
		UnsafeNativeMethods.sqlite3_result_text(context, SQLiteConvert.ToUTF8(value), array.Length - 1, (IntPtr)(-1));
	}

	internal override IntPtr AggregateContext(IntPtr context)
	{
		return UnsafeNativeMethods.sqlite3_aggregate_context(context, 1);
	}

	internal override void SetPassword(byte[] passwordBytes)
	{
		int num = UnsafeNativeMethods.sqlite3_key(_sql, passwordBytes, passwordBytes.Length);
		if (num > 0)
		{
			throw new SQLiteException(num, SQLiteLastError());
		}
	}

	internal override void ChangePassword(byte[] newPasswordBytes)
	{
		int num = UnsafeNativeMethods.sqlite3_rekey(_sql, newPasswordBytes, (newPasswordBytes != null) ? newPasswordBytes.Length : 0);
		if (num > 0)
		{
			throw new SQLiteException(num, SQLiteLastError());
		}
	}

	internal override void SetUpdateHook(SQLiteUpdateCallback func)
	{
		UnsafeNativeMethods.sqlite3_update_hook(_sql, func, IntPtr.Zero);
	}

	internal override void SetCommitHook(SQLiteCommitCallback func)
	{
		UnsafeNativeMethods.sqlite3_commit_hook(_sql, func, IntPtr.Zero);
	}

	internal override void SetRollbackHook(SQLiteRollbackCallback func)
	{
		UnsafeNativeMethods.sqlite3_rollback_hook(_sql, func, IntPtr.Zero);
	}

	internal override object GetValue(SQLiteStatement stmt, int index, SQLiteType typ)
	{
		if (IsNull(stmt, index))
		{
			return DBNull.Value;
		}
		TypeAffinity typeAffinity = typ.Affinity;
		Type type = null;
		if (typ.Type != DbType.Object)
		{
			type = SQLiteConvert.SQLiteTypeToType(typ);
			typeAffinity = SQLiteConvert.TypeToAffinity(type);
		}
		switch (typeAffinity)
		{
		case TypeAffinity.DateTime:
			return GetDateTime(stmt, index);
		case TypeAffinity.Int64:
			if ((object)type == null)
			{
				return GetInt64(stmt, index);
			}
			return Convert.ChangeType(GetInt64(stmt, index), type, null);
		case TypeAffinity.Double:
			if ((object)type == null)
			{
				return GetDouble(stmt, index);
			}
			return Convert.ChangeType(GetDouble(stmt, index), type, null);
		default:
			return GetText(stmt, index);
		case TypeAffinity.Blob:
		{
			if (typ.Type == DbType.Guid && typ.Affinity == TypeAffinity.Text)
			{
				return new Guid(GetText(stmt, index));
			}
			int num = (int)GetBytes(stmt, index, 0, null, 0, 0);
			byte[] array = new byte[num];
			GetBytes(stmt, index, 0, array, 0, num);
			if (typ.Type == DbType.Guid && num == 16)
			{
				return new Guid(array);
			}
			return array;
		}
		}
	}

	internal override int GetCursorForTable(SQLiteStatement stmt, int db, int rootPage)
	{
		return UnsafeNativeMethods.sqlite3_table_cursor(stmt._sqlite_stmt, db, rootPage);
	}

	internal override long GetRowIdForCursor(SQLiteStatement stmt, int cursor)
	{
		if (UnsafeNativeMethods.sqlite3_cursor_rowid(stmt._sqlite_stmt, cursor, out var rowid) == 0)
		{
			return rowid;
		}
		return 0L;
	}

	internal override void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence)
	{
		IntPtr Collation;
		int colllen;
		int num = UnsafeNativeMethods.sqlite3_index_column_info_interop(_sql, SQLiteConvert.ToUTF8(database), SQLiteConvert.ToUTF8(index), SQLiteConvert.ToUTF8(column), out sortMode, out onError, out Collation, out colllen);
		if (num != 0)
		{
			throw new SQLiteException(num, "");
		}
		collationSequence = SQLiteConvert.UTF8ToString(Collation, colllen);
	}
}
