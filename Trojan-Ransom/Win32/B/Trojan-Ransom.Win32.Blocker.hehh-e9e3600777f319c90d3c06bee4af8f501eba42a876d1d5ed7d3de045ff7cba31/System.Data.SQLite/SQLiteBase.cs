namespace System.Data.SQLite;

internal abstract class SQLiteBase : SQLiteConvert, IDisposable
{
	internal static object _lock = new object();

	internal abstract string Version { get; }

	internal abstract int Changes { get; }

	internal abstract bool AutoCommit { get; }

	internal SQLiteBase(SQLiteDateFormats fmt)
		: base(fmt)
	{
	}

	internal abstract void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool);

	internal abstract void Close();

	internal abstract void SetTimeout(int nTimeoutMS);

	internal abstract string SQLiteLastError();

	internal abstract void ClearPool();

	internal abstract SQLiteStatement Prepare(SQLiteConnection cnn, string strSql, SQLiteStatement previous, uint timeoutMS, out string strRemain);

	internal abstract bool Step(SQLiteStatement stmt);

	internal abstract int Reset(SQLiteStatement stmt);

	internal abstract void Cancel();

	internal abstract void Bind_Double(SQLiteStatement stmt, int index, double value);

	internal abstract void Bind_Int32(SQLiteStatement stmt, int index, int value);

	internal abstract void Bind_Int64(SQLiteStatement stmt, int index, long value);

	internal abstract void Bind_Text(SQLiteStatement stmt, int index, string value);

	internal abstract void Bind_Blob(SQLiteStatement stmt, int index, byte[] blobData);

	internal abstract void Bind_DateTime(SQLiteStatement stmt, int index, DateTime dt);

	internal abstract void Bind_Null(SQLiteStatement stmt, int index);

	internal abstract int Bind_ParamCount(SQLiteStatement stmt);

	internal abstract string Bind_ParamName(SQLiteStatement stmt, int index);

	internal abstract int Bind_ParamIndex(SQLiteStatement stmt, string paramName);

	internal abstract int ColumnCount(SQLiteStatement stmt);

	internal abstract string ColumnName(SQLiteStatement stmt, int index);

	internal abstract TypeAffinity ColumnAffinity(SQLiteStatement stmt, int index);

	internal abstract string ColumnType(SQLiteStatement stmt, int index, out TypeAffinity nAffinity);

	internal abstract int ColumnIndex(SQLiteStatement stmt, string columnName);

	internal abstract string ColumnOriginalName(SQLiteStatement stmt, int index);

	internal abstract string ColumnDatabaseName(SQLiteStatement stmt, int index);

	internal abstract string ColumnTableName(SQLiteStatement stmt, int index);

	internal abstract void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement);

	internal abstract void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence);

	internal abstract double GetDouble(SQLiteStatement stmt, int index);

	internal abstract int GetInt32(SQLiteStatement stmt, int index);

	internal abstract long GetInt64(SQLiteStatement stmt, int index);

	internal abstract string GetText(SQLiteStatement stmt, int index);

	internal abstract long GetBytes(SQLiteStatement stmt, int index, int nDataoffset, byte[] bDest, int nStart, int nLength);

	internal abstract long GetChars(SQLiteStatement stmt, int index, int nDataoffset, char[] bDest, int nStart, int nLength);

	internal abstract DateTime GetDateTime(SQLiteStatement stmt, int index);

	internal abstract bool IsNull(SQLiteStatement stmt, int index);

	internal abstract void CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16);

	internal abstract void CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal);

	internal abstract CollationSequence GetCollationSequence(SQLiteFunction func, IntPtr context);

	internal abstract int ContextCollateCompare(CollationEncodingEnum enc, IntPtr context, string s1, string s2);

	internal abstract int ContextCollateCompare(CollationEncodingEnum enc, IntPtr context, char[] c1, char[] c2);

	internal abstract int AggregateCount(IntPtr context);

	internal abstract IntPtr AggregateContext(IntPtr context);

	internal abstract long GetParamValueBytes(IntPtr ptr, int nDataOffset, byte[] bDest, int nStart, int nLength);

	internal abstract double GetParamValueDouble(IntPtr ptr);

	internal abstract int GetParamValueInt32(IntPtr ptr);

	internal abstract long GetParamValueInt64(IntPtr ptr);

	internal abstract string GetParamValueText(IntPtr ptr);

	internal abstract TypeAffinity GetParamValueType(IntPtr ptr);

	internal abstract void ReturnBlob(IntPtr context, byte[] value);

	internal abstract void ReturnDouble(IntPtr context, double value);

	internal abstract void ReturnError(IntPtr context, string value);

	internal abstract void ReturnInt32(IntPtr context, int value);

	internal abstract void ReturnInt64(IntPtr context, long value);

	internal abstract void ReturnNull(IntPtr context);

	internal abstract void ReturnText(IntPtr context, string value);

	internal abstract void SetPassword(byte[] passwordBytes);

	internal abstract void ChangePassword(byte[] newPasswordBytes);

	internal abstract void SetUpdateHook(SQLiteUpdateCallback func);

	internal abstract void SetCommitHook(SQLiteCommitCallback func);

	internal abstract void SetRollbackHook(SQLiteRollbackCallback func);

	internal abstract int GetCursorForTable(SQLiteStatement stmt, int database, int rootPage);

	internal abstract long GetRowIdForCursor(SQLiteStatement stmt, int cursor);

	internal abstract object GetValue(SQLiteStatement stmt, int index, SQLiteType typ);

	protected virtual void Dispose(bool bDisposing)
	{
	}

	public void Dispose()
	{
		Dispose(bDisposing: true);
		GC.SuppressFinalize(this);
	}

	internal static string SQLiteLastError(SQLiteConnectionHandle db)
	{
		int len;
		return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_errmsg_interop(db, out len), len);
	}

	internal static void FinalizeStatement(SQLiteStatementHandle stmt)
	{
		lock (_lock)
		{
			int num = UnsafeNativeMethods.sqlite3_finalize_interop(stmt);
			if (num > 0)
			{
				throw new SQLiteException(num, null);
			}
		}
	}

	internal static void CloseConnection(SQLiteConnectionHandle db)
	{
		lock (_lock)
		{
			int num = UnsafeNativeMethods.sqlite3_close_interop(db);
			if (num > 0)
			{
				throw new SQLiteException(num, SQLiteLastError(db));
			}
		}
	}

	internal static void ResetConnection(SQLiteConnectionHandle db)
	{
		lock (_lock)
		{
			IntPtr errMsg = IntPtr.Zero;
			do
			{
				errMsg = UnsafeNativeMethods.sqlite3_next_stmt(db, errMsg);
				if (errMsg != IntPtr.Zero)
				{
					int num = UnsafeNativeMethods.sqlite3_reset_interop(errMsg);
				}
			}
			while (errMsg != IntPtr.Zero);
			if (!IsAutocommit(db))
			{
				int num = UnsafeNativeMethods.sqlite3_exec(db, SQLiteConvert.ToUTF8("ROLLBACK"), IntPtr.Zero, IntPtr.Zero, out errMsg);
				if (num > 0)
				{
					throw new SQLiteException(num, SQLiteLastError(db));
				}
			}
		}
	}

	internal static bool IsAutocommit(SQLiteConnectionHandle hdl)
	{
		return UnsafeNativeMethods.sqlite3_get_autocommit(hdl) == 1;
	}
}
