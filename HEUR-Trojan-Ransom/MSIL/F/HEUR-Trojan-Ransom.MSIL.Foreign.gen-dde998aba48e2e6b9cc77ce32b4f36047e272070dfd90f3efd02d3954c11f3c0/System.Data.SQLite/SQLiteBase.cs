using System.Collections.Generic;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal abstract class SQLiteBase : SQLiteConvert, IDisposable
{
	internal const int COR_E_EXCEPTION = -2146233088;

	private bool disposed;

	private static string[] _errorMessages;

	[NonSerialized]
	internal static GetString _0002;

	internal abstract string Version { get; }

	internal abstract int VersionNumber { get; }

	internal abstract long LastInsertRowId { get; }

	internal abstract int Changes { get; }

	internal abstract long MemoryUsed { get; }

	internal abstract long MemoryHighwater { get; }

	internal abstract bool OwnHandle { get; }

	internal abstract IDictionary<SQLiteFunctionAttribute, SQLiteFunction> Functions { get; }

	internal abstract bool AutoCommit { get; }

	internal SQLiteBase(SQLiteDateFormats fmt, DateTimeKind kind, string fmtString)
		: base(fmt, kind, fmtString)
	{
	}

	internal abstract bool IsReadOnly(string name);

	internal abstract SQLiteErrorCode SetMemoryStatus(bool value);

	internal abstract SQLiteErrorCode ReleaseMemory();

	internal abstract SQLiteErrorCode Shutdown();

	internal abstract bool IsOpen();

	internal abstract string GetFileName(string dbName);

	internal abstract void Open(string strFilename, string vfsName, SQLiteConnectionFlags connectionFlags, SQLiteOpenFlagsEnum openFlags, int maxPoolSize, bool usePool);

	internal abstract void Close(bool canThrow);

	internal abstract void SetTimeout(int nTimeoutMS);

	internal abstract string GetLastError();

	internal abstract string GetLastError(string defValue);

	internal abstract void ClearPool();

	internal abstract int CountPool();

	internal abstract SQLiteStatement Prepare(SQLiteConnection cnn, string strSql, SQLiteStatement previous, uint timeoutMS, ref string strRemain);

	internal abstract bool Step(SQLiteStatement stmt);

	internal abstract bool IsReadOnly(SQLiteStatement stmt);

	internal abstract SQLiteErrorCode Reset(SQLiteStatement stmt);

	internal abstract void Cancel();

	internal abstract void BindFunction(SQLiteFunctionAttribute functionAttribute, SQLiteFunction function, SQLiteConnectionFlags flags);

	internal abstract bool UnbindFunction(SQLiteFunctionAttribute functionAttribute, SQLiteConnectionFlags flags);

	internal abstract void Bind_Double(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, double value);

	internal abstract void Bind_Int32(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, int value);

	internal abstract void Bind_UInt32(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, uint value);

	internal abstract void Bind_Int64(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, long value);

	internal abstract void Bind_UInt64(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, ulong value);

	internal abstract void Bind_Boolean(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, bool value);

	internal abstract void Bind_Text(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, string value);

	internal abstract void Bind_Blob(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, byte[] blobData);

	internal abstract void Bind_DateTime(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, DateTime dt);

	internal abstract void Bind_Null(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index);

	internal abstract int Bind_ParamCount(SQLiteStatement stmt, SQLiteConnectionFlags flags);

	internal abstract string Bind_ParamName(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index);

	internal abstract int Bind_ParamIndex(SQLiteStatement stmt, SQLiteConnectionFlags flags, string paramName);

	internal abstract int ColumnCount(SQLiteStatement stmt);

	internal abstract string ColumnName(SQLiteStatement stmt, int index);

	internal abstract TypeAffinity ColumnAffinity(SQLiteStatement stmt, int index);

	internal abstract string ColumnType(SQLiteStatement stmt, int index, ref TypeAffinity nAffinity);

	internal abstract int ColumnIndex(SQLiteStatement stmt, string columnName);

	internal abstract string ColumnOriginalName(SQLiteStatement stmt, int index);

	internal abstract string ColumnDatabaseName(SQLiteStatement stmt, int index);

	internal abstract string ColumnTableName(SQLiteStatement stmt, int index);

	internal abstract void ColumnMetaData(string dataBase, string table, string column, ref string dataType, ref string collateSequence, ref bool notNull, ref bool primaryKey, ref bool autoIncrement);

	internal abstract void GetIndexColumnExtendedInfo(string database, string index, string column, ref int sortMode, ref int onError, ref string collationSequence);

	internal abstract object GetObject(SQLiteStatement stmt, int index);

	internal abstract double GetDouble(SQLiteStatement stmt, int index);

	internal abstract bool GetBoolean(SQLiteStatement stmt, int index);

	internal abstract sbyte GetSByte(SQLiteStatement stmt, int index);

	internal abstract byte GetByte(SQLiteStatement stmt, int index);

	internal abstract short GetInt16(SQLiteStatement stmt, int index);

	internal abstract ushort GetUInt16(SQLiteStatement stmt, int index);

	internal abstract int GetInt32(SQLiteStatement stmt, int index);

	internal abstract uint GetUInt32(SQLiteStatement stmt, int index);

	internal abstract long GetInt64(SQLiteStatement stmt, int index);

	internal abstract ulong GetUInt64(SQLiteStatement stmt, int index);

	internal abstract string GetText(SQLiteStatement stmt, int index);

	internal abstract long GetBytes(SQLiteStatement stmt, int index, int nDataoffset, byte[] bDest, int nStart, int nLength);

	internal abstract char GetChar(SQLiteStatement stmt, int index);

	internal abstract long GetChars(SQLiteStatement stmt, int index, int nDataoffset, char[] bDest, int nStart, int nLength);

	internal abstract DateTime GetDateTime(SQLiteStatement stmt, int index);

	internal abstract bool IsNull(SQLiteStatement stmt, int index);

	internal abstract SQLiteErrorCode CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16, bool @throw);

	internal abstract SQLiteErrorCode CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal, bool @throw);

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

	internal abstract void CreateModule(SQLiteModule module, SQLiteConnectionFlags flags);

	internal abstract void DisposeModule(SQLiteModule module, SQLiteConnectionFlags flags);

	internal abstract SQLiteErrorCode DeclareVirtualTable(SQLiteModule module, string strSql, ref string error);

	internal abstract SQLiteErrorCode DeclareVirtualFunction(SQLiteModule module, int argumentCount, string name, ref string error);

	internal abstract SQLiteErrorCode SetConfigurationOption(SQLiteConfigDbOpsEnum option, bool bOnOff);

	internal abstract void SetLoadExtension(bool bOnOff);

	internal abstract void LoadExtension(string fileName, string procName);

	internal abstract void SetExtendedResultCodes(bool bOnOff);

	internal abstract SQLiteErrorCode ResultCode();

	internal abstract SQLiteErrorCode ExtendedResultCode();

	internal abstract void LogMessage(SQLiteErrorCode iErrCode, string zMessage);

	internal abstract void SetPassword(byte[] passwordBytes);

	internal abstract void ChangePassword(byte[] newPasswordBytes);

	internal abstract void SetProgressHook(int nOps, SQLiteProgressCallback func);

	internal abstract void SetAuthorizerHook(SQLiteAuthorizerCallback func);

	internal abstract void SetUpdateHook(SQLiteUpdateCallback func);

	internal abstract void SetCommitHook(SQLiteCommitCallback func);

	internal abstract void SetTraceCallback(SQLiteTraceCallback func);

	internal abstract void SetRollbackHook(SQLiteRollbackCallback func);

	internal abstract SQLiteErrorCode SetLogCallback(SQLiteLogCallback func);

	internal abstract bool IsInitialized();

	internal abstract int GetCursorForTable(SQLiteStatement stmt, int database, int rootPage);

	internal abstract long GetRowIdForCursor(SQLiteStatement stmt, int cursor);

	internal abstract object GetValue(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, SQLiteType typ);

	internal abstract SQLiteErrorCode FileControl(string zDbName, int op, IntPtr pArg);

	internal abstract SQLiteBackup InitializeBackup(SQLiteConnection destCnn, string destName, string sourceName);

	internal abstract bool StepBackup(SQLiteBackup backup, int nPage, ref bool retry);

	internal abstract int RemainingBackup(SQLiteBackup backup);

	internal abstract int PageCountBackup(SQLiteBackup backup);

	internal abstract void FinishBackup(SQLiteBackup backup);

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteBase).Name);
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposed)
		{
			disposed = true;
		}
	}

	~SQLiteBase()
	{
		Dispose(disposing: false);
	}

	protected static string FallbackGetErrorString(SQLiteErrorCode rc)
	{
		if (_errorMessages == null)
		{
			return null;
		}
		int num = (int)rc;
		if (num < 0 || num >= _errorMessages.Length)
		{
			num = 1;
		}
		return _errorMessages[num];
	}

	internal static string GetLastError(SQLiteConnectionHandle hdl, IntPtr db)
	{
		if (hdl == null || db == IntPtr.Zero)
		{
			return _0002(107365363);
		}
		string result = null;
		try
		{
		}
		finally
		{
			lock (hdl)
			{
				if (!hdl.IsInvalid && !hdl.IsClosed)
				{
					int len = 0;
					result = SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_errmsg_interop(db, ref len), len);
				}
				else
				{
					result = _0002(107365346);
				}
			}
		}
		GC.KeepAlive(hdl);
		return result;
	}

	internal static void FinishBackup(SQLiteConnectionHandle hdl, IntPtr backup)
	{
		if (hdl == null || backup == IntPtr.Zero)
		{
			return;
		}
		try
		{
		}
		finally
		{
			lock (hdl)
			{
				SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_backup_finish_interop(backup);
				if (sQLiteErrorCode != 0)
				{
					throw new SQLiteException(sQLiteErrorCode, null);
				}
			}
		}
	}

	internal static void CloseBlob(SQLiteConnectionHandle hdl, IntPtr blob)
	{
		if (hdl == null || blob == IntPtr.Zero)
		{
			return;
		}
		try
		{
		}
		finally
		{
			lock (hdl)
			{
				SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_blob_close_interop(blob);
				if (sQLiteErrorCode != 0)
				{
					throw new SQLiteException(sQLiteErrorCode, null);
				}
			}
		}
	}

	internal static void FinalizeStatement(SQLiteConnectionHandle hdl, IntPtr stmt)
	{
		if (hdl == null || stmt == IntPtr.Zero)
		{
			return;
		}
		try
		{
		}
		finally
		{
			lock (hdl)
			{
				SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_finalize_interop(stmt);
				if (sQLiteErrorCode != 0)
				{
					throw new SQLiteException(sQLiteErrorCode, null);
				}
			}
		}
	}

	internal static void CloseConnection(SQLiteConnectionHandle hdl, IntPtr db)
	{
		if (hdl == null || db == IntPtr.Zero)
		{
			return;
		}
		try
		{
		}
		finally
		{
			lock (hdl)
			{
				SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_close_interop(db);
				if (sQLiteErrorCode != 0)
				{
					throw new SQLiteException(sQLiteErrorCode, GetLastError(hdl, db));
				}
			}
		}
	}

	internal static void CloseConnectionV2(SQLiteConnectionHandle hdl, IntPtr db)
	{
		if (hdl == null || db == IntPtr.Zero)
		{
			return;
		}
		try
		{
		}
		finally
		{
			lock (hdl)
			{
				SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_close_interop(db);
				if (sQLiteErrorCode != 0)
				{
					throw new SQLiteException(sQLiteErrorCode, GetLastError(hdl, db));
				}
			}
		}
	}

	internal static bool ResetConnection(SQLiteConnectionHandle hdl, IntPtr db, bool canThrow)
	{
		if (hdl == null || db == IntPtr.Zero)
		{
			return false;
		}
		bool result = false;
		try
		{
		}
		finally
		{
			lock (hdl)
			{
				if (canThrow && hdl.IsInvalid)
				{
					throw new InvalidOperationException(_0002(107365265));
				}
				if (canThrow && hdl.IsClosed)
				{
					throw new InvalidOperationException(_0002(107365252));
				}
				if (!hdl.IsInvalid && !hdl.IsClosed)
				{
					IntPtr errMsg = IntPtr.Zero;
					do
					{
						errMsg = UnsafeNativeMethods.sqlite3_next_stmt(db, errMsg);
						if (errMsg != IntPtr.Zero)
						{
							SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_reset_interop(errMsg);
						}
					}
					while (errMsg != IntPtr.Zero);
					if (IsAutocommit(hdl, db))
					{
						result = true;
					}
					else
					{
						SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_exec(db, SQLiteConvert.ToUTF8(_0002(107365175)), IntPtr.Zero, IntPtr.Zero, ref errMsg);
						if (sQLiteErrorCode == SQLiteErrorCode.Ok)
						{
							result = true;
						}
						else if (canThrow)
						{
							throw new SQLiteException(sQLiteErrorCode, GetLastError(hdl, db));
						}
					}
				}
			}
		}
		GC.KeepAlive(hdl);
		return result;
	}

	internal static bool IsAutocommit(SQLiteConnectionHandle hdl, IntPtr db)
	{
		if (hdl == null || db == IntPtr.Zero)
		{
			return false;
		}
		bool result = false;
		try
		{
		}
		finally
		{
			lock (hdl)
			{
				if (!hdl.IsInvalid && !hdl.IsClosed)
				{
					result = UnsafeNativeMethods.sqlite3_get_autocommit(db) == 1;
				}
			}
		}
		GC.KeepAlive(hdl);
		return result;
	}

	static SQLiteBase()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteBase));
		_errorMessages = new string[29]
		{
			_0002(107365162),
			_0002(107365145),
			_0002(107365640),
			_0002(107365579),
			_0002(107365546),
			_0002(107365537),
			_0002(107365512),
			_0002(107365479),
			_0002(107365426),
			_0002(107365409),
			_0002(107364848),
			_0002(107364859),
			_0002(107364782),
			_0002(107364757),
			_0002(107364724),
			_0002(107364683),
			_0002(107364658),
			_0002(107364625),
			_0002(107365100),
			_0002(107365067),
			_0002(107365042),
			_0002(107365017),
			_0002(107364996),
			_0002(107364955),
			_0002(107364926),
			_0002(107364337),
			_0002(107364324),
			_0002(107364239),
			_0002(107364210)
		};
	}
}
