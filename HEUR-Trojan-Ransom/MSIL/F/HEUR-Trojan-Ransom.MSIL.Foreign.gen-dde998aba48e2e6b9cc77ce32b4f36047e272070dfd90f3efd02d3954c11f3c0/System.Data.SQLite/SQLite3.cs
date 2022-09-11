using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal class SQLite3 : SQLiteBase
{
	internal const string PublicKey = "002400000480000094000000060200000024000052534131000400000100010005a288de5687c4e1b621ddff5d844727418956997f475eb829429e411aff3e93f97b70de698b972640925bdd44280df0a25a843266973704137cbb0e7441c1fe7cae4e2440ae91ab8cde3933febcb1ac48dd33b40e13c421d8215c18a4349a436dd499e3c385cc683015f886f6c10bd90115eb2bd61b67750839e3a19941dc9c";

	internal const string DesignerVersion = "1.0.105.2";

	private static object syncRoot;

	protected internal SQLiteConnectionHandle _sql;

	protected string _fileName;

	protected SQLiteConnectionFlags _flags;

	protected bool _usePool;

	protected int _poolVersion;

	private int _cancelCount;

	private bool _buildingSchema;

	protected Dictionary<SQLiteFunctionAttribute, SQLiteFunction> _functions;

	protected string _shimExtensionFileName;

	protected bool? _shimIsLoadNeeded = null;

	protected string _shimExtensionProcName = _0011(107364241);

	protected Dictionary<string, SQLiteModule> _modules;

	private bool disposed;

	private static bool? have_errstr;

	private static bool? have_stmt_readonly;

	private static bool? forceLogPrepare;

	[NonSerialized]
	internal static GetString _0011;

	internal override string Version => SQLiteVersion;

	internal override int VersionNumber => SQLiteVersionNumber;

	internal static string DefineConstants
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			IList<string> optionList = SQLiteDefineConstants.OptionList;
			if (optionList != null)
			{
				foreach (string item in optionList)
				{
					if (item != null)
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append(' ');
						}
						stringBuilder.Append(item);
					}
				}
			}
			return stringBuilder.ToString();
		}
	}

	internal static string SQLiteVersion => SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_libversion(), -1);

	internal static int SQLiteVersionNumber => UnsafeNativeMethods.sqlite3_libversion_number();

	internal static string SQLiteSourceId => SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_sourceid(), -1);

	internal static string SQLiteCompileOptions
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			IntPtr intPtr = UnsafeNativeMethods.sqlite3_compileoption_get(num++);
			while (intPtr != IntPtr.Zero)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append(SQLiteConvert.UTF8ToString(intPtr, -1));
				intPtr = UnsafeNativeMethods.sqlite3_compileoption_get(num++);
			}
			return stringBuilder.ToString();
		}
	}

	internal static string InteropVersion => SQLiteConvert.UTF8ToString(UnsafeNativeMethods.interop_libversion(), -1);

	internal static string InteropSourceId => SQLiteConvert.UTF8ToString(UnsafeNativeMethods.interop_sourceid(), -1);

	internal static string InteropCompileOptions
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			IntPtr intPtr = UnsafeNativeMethods.interop_compileoption_get(num++);
			while (intPtr != IntPtr.Zero)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append(SQLiteConvert.UTF8ToString(intPtr, -1));
				intPtr = UnsafeNativeMethods.interop_compileoption_get(num++);
			}
			return stringBuilder.ToString();
		}
	}

	internal override bool AutoCommit => SQLiteBase.IsAutocommit(_sql, _sql);

	internal override long LastInsertRowId => UnsafeNativeMethods.sqlite3_last_insert_rowid(_sql);

	internal override int Changes => UnsafeNativeMethods.sqlite3_changes_interop(_sql);

	internal override long MemoryUsed => StaticMemoryUsed;

	internal static long StaticMemoryUsed => UnsafeNativeMethods.sqlite3_memory_used();

	internal override long MemoryHighwater => StaticMemoryHighwater;

	internal static long StaticMemoryHighwater => UnsafeNativeMethods.sqlite3_memory_highwater(0);

	internal override bool OwnHandle
	{
		get
		{
			if (_sql == null)
			{
				throw new SQLiteException(_0011(107364621));
			}
			return _sql.OwnHandle;
		}
	}

	internal override IDictionary<SQLiteFunctionAttribute, SQLiteFunction> Functions => _functions;

	internal SQLite3(SQLiteDateFormats fmt, DateTimeKind kind, string fmtString, IntPtr db, string fileName, bool ownHandle)
		: base(fmt, kind, fmtString)
	{
		if (db != IntPtr.Zero)
		{
			_sql = new SQLiteConnectionHandle(db, ownHandle);
			_fileName = fileName;
			SQLiteConnection.OnChanged(null, new ConnectionEventArgs(SQLiteConnectionEventType.NewCriticalHandle, null, null, null, null, _sql, fileName, new object[7]
			{
				typeof(SQLite3),
				fmt,
				kind,
				fmtString,
				db,
				fileName,
				ownHandle
			}));
		}
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLite3).Name);
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!disposed)
			{
				DisposeModules();
				Close(canThrow: false);
			}
		}
		finally
		{
			base.Dispose(disposing);
			disposed = true;
		}
	}

	private void DisposeModules()
	{
		if (_modules == null)
		{
			return;
		}
		foreach (KeyValuePair<string, SQLiteModule> module in _modules)
		{
			module.Value?.Dispose();
		}
		_modules.Clear();
	}

	internal override void Close(bool canThrow)
	{
		if (_sql == null)
		{
			return;
		}
		if (!_sql.OwnHandle)
		{
			_sql = null;
			return;
		}
		bool flag = (_flags & SQLiteConnectionFlags.UnbindFunctionsOnClose) == SQLiteConnectionFlags.UnbindFunctionsOnClose;
		if (_usePool)
		{
			if (SQLiteBase.ResetConnection(_sql, _sql, canThrow))
			{
				if (flag)
				{
					SQLiteFunction.UnbindAllFunctions(this, _flags, registered: false);
				}
				DisposeModules();
				SQLiteConnectionPool.Add(_fileName, _sql, _poolVersion);
				SQLiteConnection.OnChanged(null, new ConnectionEventArgs(SQLiteConnectionEventType.ClosedToPool, null, null, null, null, _sql, _fileName, new object[4]
				{
					typeof(SQLite3),
					canThrow,
					_fileName,
					_poolVersion
				}));
			}
		}
		else
		{
			if (flag)
			{
				SQLiteFunction.UnbindAllFunctions(this, _flags, registered: false);
			}
			_sql.Dispose();
		}
		_sql = null;
	}

	private int GetCancelCount()
	{
		return Interlocked.CompareExchange(ref _cancelCount, 0, 0);
	}

	private bool ShouldThrowForCancel()
	{
		return GetCancelCount() > 0;
	}

	private int ResetCancelCount()
	{
		return Interlocked.CompareExchange(ref _cancelCount, 0, _cancelCount);
	}

	internal override void Cancel()
	{
		try
		{
		}
		finally
		{
			Interlocked.Increment(ref _cancelCount);
			UnsafeNativeMethods.sqlite3_interrupt(_sql);
		}
	}

	internal override void BindFunction(SQLiteFunctionAttribute functionAttribute, SQLiteFunction function, SQLiteConnectionFlags flags)
	{
		if (functionAttribute == null)
		{
			throw new ArgumentNullException(_0011(107364212));
		}
		if (function == null)
		{
			throw new ArgumentNullException(_0011(107364187));
		}
		SQLiteFunction.BindFunction(this, functionAttribute, function, flags);
		if (_functions == null)
		{
			_functions = new Dictionary<SQLiteFunctionAttribute, SQLiteFunction>();
		}
		_functions[functionAttribute] = function;
	}

	internal override bool UnbindFunction(SQLiteFunctionAttribute functionAttribute, SQLiteConnectionFlags flags)
	{
		if (functionAttribute == null)
		{
			throw new ArgumentNullException(_0011(107364212));
		}
		if (_functions == null)
		{
			return false;
		}
		if (_functions.TryGetValue(functionAttribute, out var value) && SQLiteFunction.UnbindFunction(this, functionAttribute, value, flags) && _functions.Remove(functionAttribute))
		{
			return true;
		}
		return false;
	}

	internal override bool IsReadOnly(string name)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			if (name != null)
			{
				intPtr = SQLiteString.Utf8IntPtrFromString(name);
			}
			return UnsafeNativeMethods.sqlite3_db_readonly(_sql, intPtr) switch
			{
				-1 => throw new SQLiteException(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0011(107364174), name)), 
				0 => false, 
				_ => true, 
			};
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				SQLiteMemory.Free(intPtr);
				intPtr = IntPtr.Zero;
			}
		}
	}

	internal override SQLiteErrorCode SetMemoryStatus(bool value)
	{
		return StaticSetMemoryStatus(value);
	}

	internal static SQLiteErrorCode StaticSetMemoryStatus(bool value)
	{
		return UnsafeNativeMethods.sqlite3_config_int(SQLiteConfigOpsEnum.SQLITE_CONFIG_MEMSTATUS, value ? 1 : 0);
	}

	internal override SQLiteErrorCode ReleaseMemory()
	{
		return UnsafeNativeMethods.sqlite3_db_release_memory(_sql);
	}

	internal static SQLiteErrorCode StaticReleaseMemory(int nBytes, bool reset, bool compact, ref int nFree, ref bool resetOk, ref uint nLargest)
	{
		SQLiteErrorCode sQLiteErrorCode = SQLiteErrorCode.Ok;
		int num = UnsafeNativeMethods.sqlite3_release_memory(nBytes);
		uint largest = 0u;
		bool flag = false;
		if (HelperMethods.IsWindows())
		{
			if (sQLiteErrorCode == SQLiteErrorCode.Ok && reset)
			{
				sQLiteErrorCode = UnsafeNativeMethods.sqlite3_win32_reset_heap();
				if (sQLiteErrorCode == SQLiteErrorCode.Ok)
				{
					flag = true;
				}
			}
			if (sQLiteErrorCode == SQLiteErrorCode.Ok && compact)
			{
				sQLiteErrorCode = UnsafeNativeMethods.sqlite3_win32_compact_heap(ref largest);
			}
		}
		else if (reset || compact)
		{
			sQLiteErrorCode = SQLiteErrorCode.NotFound;
		}
		nFree = num;
		nLargest = largest;
		resetOk = flag;
		return sQLiteErrorCode;
	}

	internal override SQLiteErrorCode Shutdown()
	{
		return StaticShutdown(directories: false);
	}

	internal static SQLiteErrorCode StaticShutdown(bool directories)
	{
		SQLiteErrorCode sQLiteErrorCode = SQLiteErrorCode.Ok;
		if (directories && HelperMethods.IsWindows())
		{
			if (sQLiteErrorCode == SQLiteErrorCode.Ok)
			{
				sQLiteErrorCode = UnsafeNativeMethods.sqlite3_win32_set_directory(1u, null);
			}
			if (sQLiteErrorCode == SQLiteErrorCode.Ok)
			{
				sQLiteErrorCode = UnsafeNativeMethods.sqlite3_win32_set_directory(2u, null);
			}
		}
		if (sQLiteErrorCode == SQLiteErrorCode.Ok)
		{
			sQLiteErrorCode = UnsafeNativeMethods.sqlite3_shutdown();
		}
		return sQLiteErrorCode;
	}

	internal override bool IsOpen()
	{
		if (_sql != null && !_sql.IsInvalid)
		{
			return !_sql.IsClosed;
		}
		return false;
	}

	internal override string GetFileName(string dbName)
	{
		if (_sql == null)
		{
			return null;
		}
		return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_db_filename_bytes(_sql, SQLiteConvert.ToUTF8(dbName)), -1);
	}

	internal override void Open(string strFilename, string vfsName, SQLiteConnectionFlags connectionFlags, SQLiteOpenFlagsEnum openFlags, int maxPoolSize, bool usePool)
	{
		if (_sql != null)
		{
			Close(canThrow: true);
		}
		if (_sql != null)
		{
			throw new SQLiteException(_0011(107364580));
		}
		_usePool = usePool;
		_fileName = strFilename;
		_flags = connectionFlags;
		if (usePool)
		{
			_sql = SQLiteConnectionPool.Remove(strFilename, maxPoolSize, out _poolVersion);
			SQLiteConnection.OnChanged(null, new ConnectionEventArgs(SQLiteConnectionEventType.OpenedFromPool, null, null, null, null, _sql, strFilename, new object[8]
			{
				typeof(SQLite3),
				strFilename,
				vfsName,
				connectionFlags,
				openFlags,
				maxPoolSize,
				usePool,
				_poolVersion
			}));
		}
		if (_sql == null)
		{
			try
			{
			}
			finally
			{
				IntPtr db = IntPtr.Zero;
				int num = (((connectionFlags & SQLiteConnectionFlags.NoExtensionFunctions) != SQLiteConnectionFlags.NoExtensionFunctions) ? 1 : 0);
				SQLiteErrorCode sQLiteErrorCode = ((num == 0) ? UnsafeNativeMethods.sqlite3_open_v2(SQLiteConvert.ToUTF8(strFilename), ref db, openFlags, SQLiteConvert.ToUTF8(vfsName)) : UnsafeNativeMethods.sqlite3_open_interop(SQLiteConvert.ToUTF8(strFilename), SQLiteConvert.ToUTF8(vfsName), openFlags, num, ref db));
				if (sQLiteErrorCode != 0)
				{
					throw new SQLiteException(sQLiteErrorCode, null);
				}
				_sql = new SQLiteConnectionHandle(db, ownHandle: true);
			}
			lock (_sql)
			{
			}
			SQLiteConnection.OnChanged(null, new ConnectionEventArgs(SQLiteConnectionEventType.NewCriticalHandle, null, null, null, null, _sql, strFilename, new object[7]
			{
				typeof(SQLite3),
				strFilename,
				vfsName,
				connectionFlags,
				openFlags,
				maxPoolSize,
				usePool
			}));
		}
		if ((connectionFlags & SQLiteConnectionFlags.NoBindFunctions) != SQLiteConnectionFlags.NoBindFunctions)
		{
			if (_functions == null)
			{
				_functions = new Dictionary<SQLiteFunctionAttribute, SQLiteFunction>();
			}
			foreach (KeyValuePair<SQLiteFunctionAttribute, SQLiteFunction> item in SQLiteFunction.BindFunctions(this, connectionFlags))
			{
				_functions[item.Key] = item.Value;
			}
		}
		SetTimeout(0);
		GC.KeepAlive(_sql);
	}

	internal override void ClearPool()
	{
		SQLiteConnectionPool.ClearPool(_fileName);
	}

	internal override int CountPool()
	{
		Dictionary<string, int> counts = null;
		int openCount = 0;
		int closeCount = 0;
		int totalCount = 0;
		SQLiteConnectionPool.GetCounts(_fileName, ref counts, ref openCount, ref closeCount, ref totalCount);
		return totalCount;
	}

	internal override void SetTimeout(int nTimeoutMS)
	{
		IntPtr intPtr = _sql;
		if (intPtr == IntPtr.Zero)
		{
			throw new SQLiteException(_0011(107364621));
		}
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_busy_timeout(intPtr, nTimeoutMS);
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
	}

	internal override bool Step(SQLiteStatement stmt)
	{
		Random random = null;
		uint tickCount = (uint)Environment.TickCount;
		uint num = (uint)(stmt._command._commandTimeout * 1000);
		ResetCancelCount();
		SQLiteErrorCode sQLiteErrorCode;
		while (true)
		{
			try
			{
			}
			finally
			{
				sQLiteErrorCode = UnsafeNativeMethods.sqlite3_step(stmt._sqlite_stmt);
			}
			if (ShouldThrowForCancel())
			{
				break;
			}
			switch (sQLiteErrorCode)
			{
			case SQLiteErrorCode.Ok:
				continue;
			case SQLiteErrorCode.Interrupt:
				return false;
			case SQLiteErrorCode.Row:
				return true;
			case SQLiteErrorCode.Done:
				return false;
			}
			SQLiteErrorCode sQLiteErrorCode2 = Reset(stmt);
			switch (sQLiteErrorCode2)
			{
			case SQLiteErrorCode.Ok:
				throw new SQLiteException(sQLiteErrorCode, GetLastError());
			case SQLiteErrorCode.Busy:
			case SQLiteErrorCode.Locked:
				if (stmt._command != null)
				{
					if (random == null)
					{
						random = new Random();
					}
					if ((uint)(Environment.TickCount - (int)tickCount) > num)
					{
						throw new SQLiteException(sQLiteErrorCode2, GetLastError());
					}
					Thread.Sleep(random.Next(1, 150));
				}
				break;
			}
		}
		if (sQLiteErrorCode == SQLiteErrorCode.Ok || sQLiteErrorCode == SQLiteErrorCode.Row || sQLiteErrorCode == SQLiteErrorCode.Done)
		{
			sQLiteErrorCode = SQLiteErrorCode.Interrupt;
		}
		throw new SQLiteException(sQLiteErrorCode, null);
	}

	internal static string GetErrorString(SQLiteErrorCode rc)
	{
		try
		{
			if (!have_errstr.HasValue)
			{
				int sQLiteVersionNumber = SQLiteVersionNumber;
				have_errstr = sQLiteVersionNumber >= 3007015;
			}
			if (have_errstr.Value)
			{
				IntPtr intPtr = UnsafeNativeMethods.sqlite3_errstr(rc);
				if (intPtr != IntPtr.Zero)
				{
					return Marshal.PtrToStringAnsi(intPtr);
				}
			}
		}
		catch (EntryPointNotFoundException)
		{
		}
		return SQLiteBase.FallbackGetErrorString(rc);
	}

	internal override bool IsReadOnly(SQLiteStatement stmt)
	{
		try
		{
			if (!have_stmt_readonly.HasValue)
			{
				int sQLiteVersionNumber = SQLiteVersionNumber;
				have_stmt_readonly = sQLiteVersionNumber >= 3007004;
			}
			if (have_stmt_readonly.Value)
			{
				return UnsafeNativeMethods.sqlite3_stmt_readonly(stmt._sqlite_stmt) != 0;
			}
		}
		catch (EntryPointNotFoundException)
		{
		}
		return false;
	}

	internal override SQLiteErrorCode Reset(SQLiteStatement stmt)
	{
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_reset_interop(stmt._sqlite_stmt);
		switch (sQLiteErrorCode)
		{
		case SQLiteErrorCode.Schema:
		{
			string strRemain = null;
			using (SQLiteStatement sQLiteStatement = Prepare(null, stmt._sqlStatement, null, (uint)(stmt._command._commandTimeout * 1000), ref strRemain))
			{
				stmt._sqlite_stmt.Dispose();
				if (sQLiteStatement != null)
				{
					stmt._sqlite_stmt = sQLiteStatement._sqlite_stmt;
					sQLiteStatement._sqlite_stmt = null;
				}
				stmt.BindParameters();
			}
			return SQLiteErrorCode.Unknown;
		}
		case SQLiteErrorCode.Busy:
		case SQLiteErrorCode.Locked:
			return sQLiteErrorCode;
		default:
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		case SQLiteErrorCode.Ok:
			return sQLiteErrorCode;
		}
	}

	internal override string GetLastError()
	{
		return GetLastError(null);
	}

	internal override string GetLastError(string defValue)
	{
		string text = SQLiteBase.GetLastError(_sql, _sql);
		if (string.IsNullOrEmpty(text))
		{
			text = defValue;
		}
		return text;
	}

	private static bool ForceLogPrepare()
	{
		lock (syncRoot)
		{
			if (!forceLogPrepare.HasValue)
			{
				if (UnsafeNativeMethods.GetSettingValue(_0011(107364567), null) != null)
				{
					forceLogPrepare = true;
				}
				else
				{
					forceLogPrepare = false;
				}
			}
			return forceLogPrepare.Value;
		}
	}

	internal override SQLiteStatement Prepare(SQLiteConnection cnn, string strSql, SQLiteStatement previous, uint timeoutMS, ref string strRemain)
	{
		if (!string.IsNullOrEmpty(strSql))
		{
			strSql = strSql.Trim();
		}
		if (!string.IsNullOrEmpty(strSql))
		{
			string text = cnn?._baseSchemaName;
			if (!string.IsNullOrEmpty(text))
			{
				strSql = strSql.Replace(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0011(107364534), text), string.Empty);
				strSql = strSql.Replace(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0011(107364493), text), string.Empty);
			}
		}
		SQLiteConnectionFlags sQLiteConnectionFlags = cnn?.Flags ?? SQLiteConnectionFlags.Default;
		if (ForceLogPrepare() || (sQLiteConnectionFlags & SQLiteConnectionFlags.LogPrepare) == SQLiteConnectionFlags.LogPrepare)
		{
			if (strSql == null || strSql.Length == 0 || strSql.Trim().Length == 0)
			{
				SQLiteLog.LogMessage(_0011(107364484));
			}
			else
			{
				SQLiteLog.LogMessage(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0011(107364451), strSql));
			}
		}
		IntPtr zero = IntPtr.Zero;
		IntPtr ptrRemain = IntPtr.Zero;
		int nRemain = 0;
		SQLiteErrorCode sQLiteErrorCode = SQLiteErrorCode.Schema;
		int num = 0;
		int num2 = cnn?._prepareRetries ?? 3;
		byte[] array = SQLiteConvert.ToUTF8(strSql);
		string text2 = null;
		SQLiteStatement sQLiteStatement = null;
		Random random = null;
		uint tickCount = (uint)Environment.TickCount;
		ResetCancelCount();
		GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
		IntPtr pSql = gCHandle.AddrOfPinnedObject();
		SQLiteStatementHandle sQLiteStatementHandle = null;
		try
		{
			while ((sQLiteErrorCode == SQLiteErrorCode.Schema || sQLiteErrorCode == SQLiteErrorCode.Locked || sQLiteErrorCode == SQLiteErrorCode.Busy) && num < num2)
			{
				try
				{
				}
				finally
				{
					zero = IntPtr.Zero;
					ptrRemain = IntPtr.Zero;
					nRemain = 0;
					sQLiteErrorCode = UnsafeNativeMethods.sqlite3_prepare_interop(_sql, pSql, array.Length - 1, ref zero, ref ptrRemain, ref nRemain);
					if (sQLiteErrorCode == SQLiteErrorCode.Ok && zero != IntPtr.Zero)
					{
						sQLiteStatementHandle?.Dispose();
						sQLiteStatementHandle = new SQLiteStatementHandle(_sql, zero);
					}
				}
				if (sQLiteStatementHandle != null)
				{
					SQLiteConnection.OnChanged(null, new ConnectionEventArgs(SQLiteConnectionEventType.NewCriticalHandle, null, null, null, null, sQLiteStatementHandle, strSql, new object[5]
					{
						typeof(SQLite3),
						cnn,
						strSql,
						previous,
						timeoutMS
					}));
				}
				if (ShouldThrowForCancel())
				{
					if (sQLiteErrorCode == SQLiteErrorCode.Ok || sQLiteErrorCode == SQLiteErrorCode.Row || sQLiteErrorCode == SQLiteErrorCode.Done)
					{
						sQLiteErrorCode = SQLiteErrorCode.Interrupt;
					}
					throw new SQLiteException(sQLiteErrorCode, null);
				}
				switch (sQLiteErrorCode)
				{
				case SQLiteErrorCode.Schema:
					num++;
					continue;
				case SQLiteErrorCode.Error:
					if (string.Compare(GetLastError(), _0011(107364422), StringComparison.OrdinalIgnoreCase) == 0)
					{
						int num3 = strSql.IndexOf(';');
						if (num3 == -1)
						{
							num3 = strSql.Length - 1;
						}
						text2 = strSql.Substring(0, num3 + 1);
						strSql = strSql.Substring(num3 + 1);
						strRemain = string.Empty;
						while (sQLiteStatement == null && strSql.Length > 0)
						{
							sQLiteStatement = Prepare(cnn, strSql, previous, timeoutMS, ref strRemain);
							strSql = strRemain;
						}
						sQLiteStatement?.SetTypes(text2);
						return sQLiteStatement;
					}
					if (_buildingSchema || string.Compare(GetLastError(), 0, _0011(107364385), 0, 26, StringComparison.OrdinalIgnoreCase) != 0)
					{
						continue;
					}
					strRemain = string.Empty;
					_buildingSchema = true;
					try
					{
						if (((IServiceProvider)SQLiteFactory.Instance).GetService(typeof(ISQLiteSchemaExtensions)) is ISQLiteSchemaExtensions iSQLiteSchemaExtensions)
						{
							iSQLiteSchemaExtensions.BuildTempSchema(cnn);
						}
						while (sQLiteStatement == null && strSql.Length > 0)
						{
							sQLiteStatement = Prepare(cnn, strSql, previous, timeoutMS, ref strRemain);
							strSql = strRemain;
						}
						return sQLiteStatement;
					}
					finally
					{
						_buildingSchema = false;
					}
				case SQLiteErrorCode.Busy:
				case SQLiteErrorCode.Locked:
					if (random == null)
					{
						random = new Random();
					}
					if ((uint)(Environment.TickCount - (int)tickCount) > timeoutMS)
					{
						throw new SQLiteException(sQLiteErrorCode, GetLastError());
					}
					Thread.Sleep(random.Next(1, 150));
					continue;
				default:
					continue;
				case SQLiteErrorCode.Interrupt:
					break;
				}
				break;
			}
			if (ShouldThrowForCancel())
			{
				if (sQLiteErrorCode == SQLiteErrorCode.Ok || sQLiteErrorCode == SQLiteErrorCode.Row || sQLiteErrorCode == SQLiteErrorCode.Done)
				{
					sQLiteErrorCode = SQLiteErrorCode.Interrupt;
				}
				throw new SQLiteException(sQLiteErrorCode, null);
			}
			switch (sQLiteErrorCode)
			{
			case SQLiteErrorCode.Interrupt:
				return null;
			default:
				throw new SQLiteException(sQLiteErrorCode, GetLastError());
			case SQLiteErrorCode.Ok:
				strRemain = SQLiteConvert.UTF8ToString(ptrRemain, nRemain);
				if (sQLiteStatementHandle != null)
				{
					sQLiteStatement = new SQLiteStatement(this, sQLiteConnectionFlags, sQLiteStatementHandle, strSql.Substring(0, strSql.Length - strRemain.Length), previous);
				}
				return sQLiteStatement;
			}
		}
		finally
		{
			gCHandle.Free();
		}
	}

	protected static void LogBind(SQLiteStatementHandle handle, int index)
	{
		IntPtr intPtr = handle;
		SQLiteLog.LogMessage(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0011(107363868), intPtr, index));
	}

	protected static void LogBind(SQLiteStatementHandle handle, int index, System.ValueType value)
	{
		IntPtr intPtr = handle;
		SQLiteLog.LogMessage(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0011(107363803), intPtr, index, value.GetType(), value));
	}

	private static string FormatDateTime(DateTime value)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(value.ToString(_0011(107366430)));
		stringBuilder.Append(' ');
		stringBuilder.Append(value.Kind);
		stringBuilder.Append(' ');
		stringBuilder.Append(value.Ticks);
		return stringBuilder.ToString();
	}

	protected static void LogBind(SQLiteStatementHandle handle, int index, DateTime value)
	{
		IntPtr intPtr = handle;
		SQLiteLog.LogMessage(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0011(107363803), intPtr, index, typeof(DateTime), FormatDateTime(value)));
	}

	protected static void LogBind(SQLiteStatementHandle handle, int index, string value)
	{
		IntPtr intPtr = handle;
		SQLiteLog.LogMessage(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0011(107363803), intPtr, index, typeof(string), (value != null) ? value : _0011(107363678)));
	}

	private static string ToHexadecimalString(byte[] array)
	{
		if (array == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder(array.Length * 2);
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			stringBuilder.Append(array[i].ToString(_0011(107363701)));
		}
		return stringBuilder.ToString();
	}

	protected static void LogBind(SQLiteStatementHandle handle, int index, byte[] value)
	{
		IntPtr intPtr = handle;
		SQLiteLog.LogMessage(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0011(107363803), intPtr, index, typeof(byte[]), (value != null) ? ToHexadecimalString(value) : _0011(107363678)));
	}

	internal override void Bind_Double(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, double value)
	{
		SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			LogBind(sqlite_stmt, index, value);
		}
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_bind_double(sqlite_stmt, index, value);
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
	}

	internal override void Bind_Int32(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, int value)
	{
		SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			LogBind(sqlite_stmt, index, value);
		}
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_bind_int(sqlite_stmt, index, value);
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
	}

	internal override void Bind_UInt32(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, uint value)
	{
		SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			LogBind(sqlite_stmt, index, value);
		}
		SQLiteErrorCode sQLiteErrorCode;
		if ((flags & SQLiteConnectionFlags.BindUInt32AsInt64) == SQLiteConnectionFlags.BindUInt32AsInt64)
		{
			long value2 = value;
			sQLiteErrorCode = UnsafeNativeMethods.sqlite3_bind_int64(sqlite_stmt, index, value2);
		}
		else
		{
			sQLiteErrorCode = UnsafeNativeMethods.sqlite3_bind_uint(sqlite_stmt, index, value);
		}
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
	}

	internal override void Bind_Int64(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, long value)
	{
		SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			LogBind(sqlite_stmt, index, value);
		}
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_bind_int64(sqlite_stmt, index, value);
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
	}

	internal override void Bind_UInt64(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, ulong value)
	{
		SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			LogBind(sqlite_stmt, index, value);
		}
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_bind_uint64(sqlite_stmt, index, value);
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
	}

	internal override void Bind_Boolean(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, bool value)
	{
		SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			LogBind(sqlite_stmt, index, value);
		}
		int value2 = (value ? 1 : 0);
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_bind_int(sqlite_stmt, index, value2);
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
	}

	internal override void Bind_Text(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, string value)
	{
		SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			LogBind(sqlite_stmt, index, value);
		}
		byte[] array = SQLiteConvert.ToUTF8(value);
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			LogBind(sqlite_stmt, index, array);
		}
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_bind_text(sqlite_stmt, index, array, array.Length - 1, (IntPtr)(-1));
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
	}

	internal override void Bind_DateTime(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, DateTime dt)
	{
		SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			LogBind(sqlite_stmt, index, dt);
		}
		if ((flags & SQLiteConnectionFlags.BindDateTimeWithKind) == SQLiteConnectionFlags.BindDateTimeWithKind && _datetimeKind != 0 && dt.Kind != 0 && dt.Kind != _datetimeKind)
		{
			if (_datetimeKind == DateTimeKind.Utc)
			{
				dt = dt.ToUniversalTime();
			}
			else if (_datetimeKind == DateTimeKind.Local)
			{
				dt = dt.ToLocalTime();
			}
		}
		switch (_datetimeFormat)
		{
		case SQLiteDateFormats.Ticks:
		{
			long ticks = dt.Ticks;
			if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
			{
				LogBind(sqlite_stmt, index, ticks);
			}
			SQLiteErrorCode sQLiteErrorCode4 = UnsafeNativeMethods.sqlite3_bind_int64(sqlite_stmt, index, ticks);
			if (sQLiteErrorCode4 != 0)
			{
				throw new SQLiteException(sQLiteErrorCode4, GetLastError());
			}
			break;
		}
		case SQLiteDateFormats.JulianDay:
		{
			double num = SQLiteConvert.ToJulianDay(dt);
			if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
			{
				LogBind(sqlite_stmt, index, num);
			}
			SQLiteErrorCode sQLiteErrorCode2 = UnsafeNativeMethods.sqlite3_bind_double(sqlite_stmt, index, num);
			if (sQLiteErrorCode2 != 0)
			{
				throw new SQLiteException(sQLiteErrorCode2, GetLastError());
			}
			break;
		}
		case SQLiteDateFormats.UnixEpoch:
		{
			long num2 = Convert.ToInt64(dt.Subtract(SQLiteConvert.UnixEpoch).TotalSeconds);
			if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
			{
				LogBind(sqlite_stmt, index, num2);
			}
			SQLiteErrorCode sQLiteErrorCode3 = UnsafeNativeMethods.sqlite3_bind_int64(sqlite_stmt, index, num2);
			if (sQLiteErrorCode3 != 0)
			{
				throw new SQLiteException(sQLiteErrorCode3, GetLastError());
			}
			break;
		}
		default:
		{
			byte[] array = ToUTF8(dt);
			if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
			{
				LogBind(sqlite_stmt, index, array);
			}
			SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_bind_text(sqlite_stmt, index, array, array.Length - 1, (IntPtr)(-1));
			if (sQLiteErrorCode != 0)
			{
				throw new SQLiteException(sQLiteErrorCode, GetLastError());
			}
			break;
		}
		}
	}

	internal override void Bind_Blob(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, byte[] blobData)
	{
		SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			LogBind(sqlite_stmt, index, blobData);
		}
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_bind_blob(sqlite_stmt, index, blobData, blobData.Length, (IntPtr)(-1));
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
	}

	internal override void Bind_Null(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index)
	{
		SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			LogBind(sqlite_stmt, index);
		}
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_bind_null(sqlite_stmt, index);
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
	}

	internal override int Bind_ParamCount(SQLiteStatement stmt, SQLiteConnectionFlags flags)
	{
		SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
		int num = UnsafeNativeMethods.sqlite3_bind_parameter_count(sqlite_stmt);
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			IntPtr intPtr = sqlite_stmt;
			SQLiteLog.LogMessage(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0011(107363696), intPtr, num));
		}
		return num;
	}

	internal override string Bind_ParamName(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index)
	{
		SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
		int len = 0;
		string text = SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_bind_parameter_name_interop(sqlite_stmt, index, ref len), len);
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			IntPtr intPtr = sqlite_stmt;
			SQLiteLog.LogMessage(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0011(107363615), intPtr, index, text));
		}
		return text;
	}

	internal override int Bind_ParamIndex(SQLiteStatement stmt, SQLiteConnectionFlags flags, string paramName)
	{
		SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
		int num = UnsafeNativeMethods.sqlite3_bind_parameter_index(sqlite_stmt, SQLiteConvert.ToUTF8(paramName));
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			IntPtr intPtr = sqlite_stmt;
			SQLiteLog.LogMessage(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0011(107364066), intPtr, paramName, num));
		}
		return num;
	}

	internal override int ColumnCount(SQLiteStatement stmt)
	{
		return UnsafeNativeMethods.sqlite3_column_count(stmt._sqlite_stmt);
	}

	internal override string ColumnName(SQLiteStatement stmt, int index)
	{
		int len = 0;
		IntPtr intPtr = UnsafeNativeMethods.sqlite3_column_name_interop(stmt._sqlite_stmt, index, ref len);
		if (intPtr == IntPtr.Zero)
		{
			throw new SQLiteException(SQLiteErrorCode.NoMem, GetLastError());
		}
		return SQLiteConvert.UTF8ToString(intPtr, len);
	}

	internal override TypeAffinity ColumnAffinity(SQLiteStatement stmt, int index)
	{
		return UnsafeNativeMethods.sqlite3_column_type(stmt._sqlite_stmt, index);
	}

	internal override string ColumnType(SQLiteStatement stmt, int index, ref TypeAffinity nAffinity)
	{
		int len = 0;
		IntPtr intPtr = UnsafeNativeMethods.sqlite3_column_decltype_interop(stmt._sqlite_stmt, index, ref len);
		nAffinity = ColumnAffinity(stmt, index);
		if (intPtr != IntPtr.Zero && (len > 0 || len == -1))
		{
			string text = SQLiteConvert.UTF8ToString(intPtr, len);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
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
		for (int i = 0; i < num; i++)
		{
			if (string.Compare(columnName, ColumnName(stmt, i), StringComparison.OrdinalIgnoreCase) == 0)
			{
				return i;
			}
		}
		return -1;
	}

	internal override string ColumnOriginalName(SQLiteStatement stmt, int index)
	{
		int len = 0;
		return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_column_origin_name_interop(stmt._sqlite_stmt, index, ref len), len);
	}

	internal override string ColumnDatabaseName(SQLiteStatement stmt, int index)
	{
		int len = 0;
		return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_column_database_name_interop(stmt._sqlite_stmt, index, ref len), len);
	}

	internal override string ColumnTableName(SQLiteStatement stmt, int index)
	{
		int len = 0;
		return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_column_table_name_interop(stmt._sqlite_stmt, index, ref len), len);
	}

	internal override void ColumnMetaData(string dataBase, string table, string column, ref string dataType, ref string collateSequence, ref bool notNull, ref bool primaryKey, ref bool autoIncrement)
	{
		IntPtr ptrDataType = IntPtr.Zero;
		IntPtr ptrCollSeq = IntPtr.Zero;
		int notNull2 = 0;
		int primaryKey2 = 0;
		int autoInc = 0;
		int dtLen = 0;
		int csLen = 0;
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_table_column_metadata_interop(_sql, SQLiteConvert.ToUTF8(dataBase), SQLiteConvert.ToUTF8(table), SQLiteConvert.ToUTF8(column), ref ptrDataType, ref ptrCollSeq, ref notNull2, ref primaryKey2, ref autoInc, ref dtLen, ref csLen);
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
		dataType = SQLiteConvert.UTF8ToString(ptrDataType, dtLen);
		collateSequence = SQLiteConvert.UTF8ToString(ptrCollSeq, csLen);
		notNull = notNull2 == 1;
		primaryKey = primaryKey2 == 1;
		autoIncrement = autoInc == 1;
	}

	internal override object GetObject(SQLiteStatement stmt, int index)
	{
		switch (ColumnAffinity(stmt, index))
		{
		case TypeAffinity.Int64:
			return GetInt64(stmt, index);
		case TypeAffinity.Double:
			return GetDouble(stmt, index);
		case TypeAffinity.Text:
			return GetText(stmt, index);
		case TypeAffinity.Blob:
		{
			long bytes = GetBytes(stmt, index, 0, null, 0, 0);
			if (bytes > 0 && bytes <= int.MaxValue)
			{
				byte[] array = new byte[(int)bytes];
				GetBytes(stmt, index, 0, array, 0, (int)bytes);
				return array;
			}
			break;
		}
		case TypeAffinity.Null:
			return DBNull.Value;
		}
		throw new NotImplementedException();
	}

	internal override double GetDouble(SQLiteStatement stmt, int index)
	{
		return UnsafeNativeMethods.sqlite3_column_double(stmt._sqlite_stmt, index);
	}

	internal override bool GetBoolean(SQLiteStatement stmt, int index)
	{
		return SQLiteConvert.ToBoolean(GetObject(stmt, index), CultureInfo.InvariantCulture, viaFramework: false);
	}

	internal override sbyte GetSByte(SQLiteStatement stmt, int index)
	{
		return (sbyte)(GetInt32(stmt, index) & 0xFF);
	}

	internal override byte GetByte(SQLiteStatement stmt, int index)
	{
		return (byte)((uint)GetInt32(stmt, index) & 0xFFu);
	}

	internal override short GetInt16(SQLiteStatement stmt, int index)
	{
		return (short)(GetInt32(stmt, index) & 0xFFFF);
	}

	internal override ushort GetUInt16(SQLiteStatement stmt, int index)
	{
		return (ushort)((uint)GetInt32(stmt, index) & 0xFFFFu);
	}

	internal override int GetInt32(SQLiteStatement stmt, int index)
	{
		return UnsafeNativeMethods.sqlite3_column_int(stmt._sqlite_stmt, index);
	}

	internal override uint GetUInt32(SQLiteStatement stmt, int index)
	{
		return (uint)GetInt32(stmt, index);
	}

	internal override long GetInt64(SQLiteStatement stmt, int index)
	{
		return UnsafeNativeMethods.sqlite3_column_int64(stmt._sqlite_stmt, index);
	}

	internal override ulong GetUInt64(SQLiteStatement stmt, int index)
	{
		return (ulong)GetInt64(stmt, index);
	}

	internal override string GetText(SQLiteStatement stmt, int index)
	{
		int len = 0;
		return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_column_text_interop(stmt._sqlite_stmt, index, ref len), len);
	}

	internal override DateTime GetDateTime(SQLiteStatement stmt, int index)
	{
		if (_datetimeFormat == SQLiteDateFormats.Ticks)
		{
			return SQLiteConvert.TicksToDateTime(GetInt64(stmt, index), _datetimeKind);
		}
		if (_datetimeFormat == SQLiteDateFormats.JulianDay)
		{
			return SQLiteConvert.ToDateTime(GetDouble(stmt, index), _datetimeKind);
		}
		if (_datetimeFormat == SQLiteDateFormats.UnixEpoch)
		{
			return SQLiteConvert.UnixEpochToDateTime(GetInt64(stmt, index), _datetimeKind);
		}
		int len = 0;
		return ToDateTime(UnsafeNativeMethods.sqlite3_column_text_interop(stmt._sqlite_stmt, index, ref len), len);
	}

	internal override long GetBytes(SQLiteStatement stmt, int index, int nDataOffset, byte[] bDest, int nStart, int nLength)
	{
		int num = UnsafeNativeMethods.sqlite3_column_bytes(stmt._sqlite_stmt, index);
		if (bDest == null)
		{
			return num;
		}
		int num2 = nLength;
		if (num2 + nStart > bDest.Length)
		{
			num2 = bDest.Length - nStart;
		}
		if (num2 + nDataOffset > num)
		{
			num2 = num - nDataOffset;
		}
		if (num2 > 0)
		{
			Marshal.Copy((IntPtr)(UnsafeNativeMethods.sqlite3_column_blob(stmt._sqlite_stmt, index).ToInt64() + nDataOffset), bDest, nStart, num2);
		}
		else
		{
			num2 = 0;
		}
		return num2;
	}

	internal override char GetChar(SQLiteStatement stmt, int index)
	{
		return Convert.ToChar(GetUInt16(stmt, index));
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

	internal override SQLiteErrorCode CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal, bool canThrow)
	{
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_create_function_interop(_sql, SQLiteConvert.ToUTF8(strFunction), nArgs, 4, IntPtr.Zero, func, funcstep, funcfinal, needCollSeq ? 1 : 0);
		if (sQLiteErrorCode == SQLiteErrorCode.Ok)
		{
			sQLiteErrorCode = UnsafeNativeMethods.sqlite3_create_function_interop(_sql, SQLiteConvert.ToUTF8(strFunction), nArgs, 1, IntPtr.Zero, func, funcstep, funcfinal, needCollSeq ? 1 : 0);
		}
		if (canThrow && sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
		return sQLiteErrorCode;
	}

	internal override SQLiteErrorCode CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16, bool canThrow)
	{
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_create_collation(_sql, SQLiteConvert.ToUTF8(strCollation), 2, IntPtr.Zero, func16);
		if (sQLiteErrorCode == SQLiteErrorCode.Ok)
		{
			sQLiteErrorCode = UnsafeNativeMethods.sqlite3_create_collation(_sql, SQLiteConvert.ToUTF8(strCollation), 1, IntPtr.Zero, func);
		}
		if (canThrow && sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
		return sQLiteErrorCode;
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
		return UnsafeNativeMethods.sqlite3_context_collcompare_interop(context, bytes, bytes.Length, bytes2, bytes2.Length);
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
		return UnsafeNativeMethods.sqlite3_context_collcompare_interop(context, bytes, bytes.Length, bytes2, bytes2.Length);
	}

	internal override CollationSequence GetCollationSequence(SQLiteFunction func, IntPtr context)
	{
		CollationSequence result = default(CollationSequence);
		int len = 0;
		int type = 0;
		int enc = 0;
		IntPtr nativestring = UnsafeNativeMethods.sqlite3_context_collseq_interop(context, ref type, ref enc, ref len);
		result.Name = SQLiteConvert.UTF8ToString(nativestring, len);
		result.Type = (CollationTypeEnum)type;
		result._func = func;
		result.Encoding = (CollationEncodingEnum)enc;
		return result;
	}

	internal override long GetParamValueBytes(IntPtr p, int nDataOffset, byte[] bDest, int nStart, int nLength)
	{
		int num = UnsafeNativeMethods.sqlite3_value_bytes(p);
		if (bDest == null)
		{
			return num;
		}
		int num2 = nLength;
		if (num2 + nStart > bDest.Length)
		{
			num2 = bDest.Length - nStart;
		}
		if (num2 + nDataOffset > num)
		{
			num2 = num - nDataOffset;
		}
		if (num2 > 0)
		{
			Marshal.Copy((IntPtr)(UnsafeNativeMethods.sqlite3_value_blob(p).ToInt64() + nDataOffset), bDest, nStart, num2);
		}
		else
		{
			num2 = 0;
		}
		return num2;
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
		int len = 0;
		return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_value_text_interop(ptr, ref len), len);
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

	private string GetShimExtensionFileName(ref bool isLoadNeeded)
	{
		if (_shimIsLoadNeeded.HasValue)
		{
			isLoadNeeded = _shimIsLoadNeeded.Value;
		}
		else
		{
			isLoadNeeded = HelperMethods.IsWindows();
		}
		string shimExtensionFileName = _shimExtensionFileName;
		if (shimExtensionFileName != null)
		{
			return shimExtensionFileName;
		}
		return UnsafeNativeMethods.GetNativeLibraryFileNameOnly();
	}

	internal override void CreateModule(SQLiteModule module, SQLiteConnectionFlags flags)
	{
		if (module == null)
		{
			throw new ArgumentNullException(_0011(107364025));
		}
		if ((flags & SQLiteConnectionFlags.NoLogModule) != SQLiteConnectionFlags.NoLogModule)
		{
			module.LogErrors = (flags & SQLiteConnectionFlags.LogModuleError) == SQLiteConnectionFlags.LogModuleError;
			module.LogExceptions = (flags & SQLiteConnectionFlags.LogModuleException) == SQLiteConnectionFlags.LogModuleException;
		}
		if (_sql == null)
		{
			throw new SQLiteException(_0011(107364016));
		}
		bool isLoadNeeded = false;
		string shimExtensionFileName = GetShimExtensionFileName(ref isLoadNeeded);
		if (isLoadNeeded)
		{
			if (shimExtensionFileName == null)
			{
				throw new SQLiteException(_0011(107363939));
			}
			if (_shimExtensionProcName == null)
			{
				throw new SQLiteException(_0011(107363870));
			}
			SetLoadExtension(bOnOff: true);
			LoadExtension(shimExtensionFileName, _shimExtensionProcName);
		}
		if (module.CreateDisposableModule(_sql))
		{
			if (_modules == null)
			{
				_modules = new Dictionary<string, SQLiteModule>();
			}
			_modules.Add(module.Name, module);
			if (_usePool)
			{
				_usePool = false;
			}
			return;
		}
		throw new SQLiteException(GetLastError());
	}

	internal override void DisposeModule(SQLiteModule module, SQLiteConnectionFlags flags)
	{
		if (module == null)
		{
			throw new ArgumentNullException(_0011(107364025));
		}
		module.Dispose();
	}

	internal override IntPtr AggregateContext(IntPtr context)
	{
		return UnsafeNativeMethods.sqlite3_aggregate_context(context, 1);
	}

	internal override SQLiteErrorCode DeclareVirtualTable(SQLiteModule module, string strSql, ref string error)
	{
		if (_sql == null)
		{
			error = _0011(107364016);
			return SQLiteErrorCode.Error;
		}
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = SQLiteString.Utf8IntPtrFromString(strSql);
			SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_declare_vtab(_sql, intPtr);
			if (sQLiteErrorCode == SQLiteErrorCode.Ok && module != null)
			{
				module.Declared = true;
			}
			if (sQLiteErrorCode != 0)
			{
				error = GetLastError();
			}
			return sQLiteErrorCode;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				SQLiteMemory.Free(intPtr);
				intPtr = IntPtr.Zero;
			}
		}
	}

	internal override SQLiteErrorCode DeclareVirtualFunction(SQLiteModule module, int argumentCount, string name, ref string error)
	{
		if (_sql == null)
		{
			error = _0011(107364016);
			return SQLiteErrorCode.Error;
		}
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = SQLiteString.Utf8IntPtrFromString(name);
			SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_overload_function(_sql, intPtr, argumentCount);
			if (sQLiteErrorCode != 0)
			{
				error = GetLastError();
			}
			return sQLiteErrorCode;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				SQLiteMemory.Free(intPtr);
				intPtr = IntPtr.Zero;
			}
		}
	}

	internal override SQLiteErrorCode SetConfigurationOption(SQLiteConfigDbOpsEnum option, bool bOnOff)
	{
		if (option < SQLiteConfigDbOpsEnum.SQLITE_DBCONFIG_ENABLE_FKEY || option > SQLiteConfigDbOpsEnum.SQLITE_DBCONFIG_ENABLE_LOAD_EXTENSION)
		{
			throw new SQLiteException(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0011(107363317), SQLiteConfigDbOpsEnum.SQLITE_DBCONFIG_ENABLE_FKEY, SQLiteConfigDbOpsEnum.SQLITE_DBCONFIG_ENABLE_TRIGGER, SQLiteConfigDbOpsEnum.SQLITE_DBCONFIG_ENABLE_FTS3_TOKENIZER, SQLiteConfigDbOpsEnum.SQLITE_DBCONFIG_ENABLE_LOAD_EXTENSION));
		}
		int result = 0;
		return UnsafeNativeMethods.sqlite3_db_config_int_refint(_sql, option, bOnOff ? 1 : 0, ref result);
	}

	internal override void SetLoadExtension(bool bOnOff)
	{
		SQLiteErrorCode sQLiteErrorCode = ((SQLiteVersionNumber < 3013000) ? UnsafeNativeMethods.sqlite3_enable_load_extension(_sql, bOnOff ? (-1) : 0) : SetConfigurationOption(SQLiteConfigDbOpsEnum.SQLITE_DBCONFIG_ENABLE_LOAD_EXTENSION, bOnOff));
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
	}

	internal override void LoadExtension(string fileName, string procName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException(_0011(107363228));
		}
		IntPtr pError = IntPtr.Zero;
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(fileName + '\0');
			byte[] procName2 = null;
			if (procName != null)
			{
				procName2 = Encoding.UTF8.GetBytes(procName + '\0');
			}
			SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_load_extension(_sql, bytes, procName2, ref pError);
			if (sQLiteErrorCode != 0)
			{
				throw new SQLiteException(sQLiteErrorCode, SQLiteConvert.UTF8ToString(pError, -1));
			}
		}
		finally
		{
			if (pError != IntPtr.Zero)
			{
				UnsafeNativeMethods.sqlite3_free(pError);
				pError = IntPtr.Zero;
			}
		}
	}

	internal override void SetExtendedResultCodes(bool bOnOff)
	{
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_extended_result_codes(_sql, bOnOff ? (-1) : 0);
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
	}

	internal override SQLiteErrorCode ResultCode()
	{
		return UnsafeNativeMethods.sqlite3_errcode(_sql);
	}

	internal override SQLiteErrorCode ExtendedResultCode()
	{
		return UnsafeNativeMethods.sqlite3_extended_errcode(_sql);
	}

	internal override void LogMessage(SQLiteErrorCode iErrCode, string zMessage)
	{
		StaticLogMessage(iErrCode, zMessage);
	}

	internal static void StaticLogMessage(SQLiteErrorCode iErrCode, string zMessage)
	{
		UnsafeNativeMethods.sqlite3_log(iErrCode, SQLiteConvert.ToUTF8(zMessage));
	}

	internal override void SetPassword(byte[] passwordBytes)
	{
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_key(_sql, passwordBytes, passwordBytes.Length);
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
		if (_usePool)
		{
			_usePool = false;
		}
	}

	internal override void ChangePassword(byte[] newPasswordBytes)
	{
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_rekey(_sql, newPasswordBytes, (newPasswordBytes != null) ? newPasswordBytes.Length : 0);
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
		if (_usePool)
		{
			_usePool = false;
		}
	}

	internal override void SetProgressHook(int nOps, SQLiteProgressCallback func)
	{
		UnsafeNativeMethods.sqlite3_progress_handler(_sql, nOps, func, IntPtr.Zero);
	}

	internal override void SetAuthorizerHook(SQLiteAuthorizerCallback func)
	{
		UnsafeNativeMethods.sqlite3_set_authorizer(_sql, func, IntPtr.Zero);
	}

	internal override void SetUpdateHook(SQLiteUpdateCallback func)
	{
		UnsafeNativeMethods.sqlite3_update_hook(_sql, func, IntPtr.Zero);
	}

	internal override void SetCommitHook(SQLiteCommitCallback func)
	{
		UnsafeNativeMethods.sqlite3_commit_hook(_sql, func, IntPtr.Zero);
	}

	internal override void SetTraceCallback(SQLiteTraceCallback func)
	{
		UnsafeNativeMethods.sqlite3_trace(_sql, func, IntPtr.Zero);
	}

	internal override void SetRollbackHook(SQLiteRollbackCallback func)
	{
		UnsafeNativeMethods.sqlite3_rollback_hook(_sql, func, IntPtr.Zero);
	}

	internal override SQLiteErrorCode SetLogCallback(SQLiteLogCallback func)
	{
		return UnsafeNativeMethods.sqlite3_config_log(SQLiteConfigOpsEnum.SQLITE_CONFIG_LOG, func, IntPtr.Zero);
	}

	internal override SQLiteBackup InitializeBackup(SQLiteConnection destCnn, string destName, string sourceName)
	{
		if (destCnn == null)
		{
			throw new ArgumentNullException(_0011(107363215));
		}
		if (destName == null)
		{
			throw new ArgumentNullException(_0011(107363170));
		}
		if (sourceName == null)
		{
			throw new ArgumentNullException(_0011(107363189));
		}
		if (!(destCnn._sql is SQLite3 sQLite))
		{
			throw new ArgumentException(_0011(107363140), _0011(107363215));
		}
		SQLiteConnectionHandle sql = sQLite._sql;
		if (sql == null)
		{
			throw new ArgumentException(_0011(107363119), _0011(107363215));
		}
		SQLiteConnectionHandle sql2 = _sql;
		if (sql2 == null)
		{
			throw new InvalidOperationException(_0011(107363570));
		}
		byte[] zDestName = SQLiteConvert.ToUTF8(destName);
		byte[] zSourceName = SQLiteConvert.ToUTF8(sourceName);
		SQLiteBackupHandle sQLiteBackupHandle = null;
		try
		{
		}
		finally
		{
			IntPtr intPtr = UnsafeNativeMethods.sqlite3_backup_init(sql, zDestName, sql2, zSourceName);
			if (intPtr == IntPtr.Zero)
			{
				SQLiteErrorCode sQLiteErrorCode = ResultCode();
				if (sQLiteErrorCode != 0)
				{
					throw new SQLiteException(sQLiteErrorCode, GetLastError());
				}
				throw new SQLiteException(_0011(107363513));
			}
			sQLiteBackupHandle = new SQLiteBackupHandle(sql, intPtr);
		}
		SQLiteConnection.OnChanged(null, new ConnectionEventArgs(SQLiteConnectionEventType.NewCriticalHandle, null, null, null, null, sQLiteBackupHandle, null, new object[4]
		{
			typeof(SQLite3),
			destCnn,
			destName,
			sourceName
		}));
		return new SQLiteBackup(this, sQLiteBackupHandle, sql, zDestName, sql2, zSourceName);
	}

	internal override bool StepBackup(SQLiteBackup backup, int nPage, ref bool retry)
	{
		retry = false;
		if (backup == null)
		{
			throw new ArgumentNullException(_0011(107363476));
		}
		SQLiteBackupHandle sqlite_backup = backup._sqlite_backup;
		if (sqlite_backup == null)
		{
			throw new InvalidOperationException(_0011(107363435));
		}
		IntPtr intPtr = sqlite_backup;
		if (intPtr == IntPtr.Zero)
		{
			throw new InvalidOperationException(_0011(107363418));
		}
		SQLiteErrorCode sQLiteErrorCode = (backup._stepResult = UnsafeNativeMethods.sqlite3_backup_step(intPtr, nPage));
		switch (sQLiteErrorCode)
		{
		case SQLiteErrorCode.Ok:
			return true;
		case SQLiteErrorCode.Busy:
			retry = true;
			return true;
		case SQLiteErrorCode.Locked:
			retry = true;
			return true;
		case SQLiteErrorCode.Done:
			return false;
		default:
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
	}

	internal override int RemainingBackup(SQLiteBackup backup)
	{
		if (backup == null)
		{
			throw new ArgumentNullException(_0011(107363476));
		}
		SQLiteBackupHandle sqlite_backup = backup._sqlite_backup;
		if (sqlite_backup == null)
		{
			throw new InvalidOperationException(_0011(107363435));
		}
		IntPtr intPtr = sqlite_backup;
		if (intPtr == IntPtr.Zero)
		{
			throw new InvalidOperationException(_0011(107363418));
		}
		return UnsafeNativeMethods.sqlite3_backup_remaining(intPtr);
	}

	internal override int PageCountBackup(SQLiteBackup backup)
	{
		if (backup == null)
		{
			throw new ArgumentNullException(_0011(107363476));
		}
		SQLiteBackupHandle sqlite_backup = backup._sqlite_backup;
		if (sqlite_backup == null)
		{
			throw new InvalidOperationException(_0011(107363435));
		}
		IntPtr intPtr = sqlite_backup;
		if (intPtr == IntPtr.Zero)
		{
			throw new InvalidOperationException(_0011(107363418));
		}
		return UnsafeNativeMethods.sqlite3_backup_pagecount(intPtr);
	}

	internal override void FinishBackup(SQLiteBackup backup)
	{
		if (backup == null)
		{
			throw new ArgumentNullException(_0011(107363476));
		}
		SQLiteBackupHandle sqlite_backup = backup._sqlite_backup;
		if (sqlite_backup == null)
		{
			throw new InvalidOperationException(_0011(107363435));
		}
		IntPtr intPtr = sqlite_backup;
		if (intPtr == IntPtr.Zero)
		{
			throw new InvalidOperationException(_0011(107363418));
		}
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_backup_finish_interop(intPtr);
		sqlite_backup.SetHandleAsInvalid();
		if (sQLiteErrorCode != 0 && sQLiteErrorCode != backup._stepResult)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
	}

	internal override bool IsInitialized()
	{
		return StaticIsInitialized();
	}

	internal static bool StaticIsInitialized()
	{
		lock (syncRoot)
		{
			bool enabled = SQLiteLog.Enabled;
			SQLiteLog.Enabled = false;
			try
			{
				SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_config_none(SQLiteConfigOpsEnum.SQLITE_CONFIG_NONE);
				return sQLiteErrorCode == SQLiteErrorCode.Misuse;
			}
			finally
			{
				SQLiteLog.Enabled = enabled;
			}
		}
	}

	internal override object GetValue(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, SQLiteType typ)
	{
		TypeAffinity typeAffinity = typ.Affinity;
		if (typeAffinity == TypeAffinity.Null)
		{
			return DBNull.Value;
		}
		Type type = null;
		if (typ.Type != DbType.Object)
		{
			type = SQLiteConvert.SQLiteTypeToType(typ);
			typeAffinity = SQLiteConvert.TypeToAffinity(type);
		}
		if ((flags & SQLiteConnectionFlags.GetAllAsText) == SQLiteConnectionFlags.GetAllAsText)
		{
			return GetText(stmt, index);
		}
		switch (typeAffinity)
		{
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
		case TypeAffinity.DateTime:
			return GetDateTime(stmt, index);
		case TypeAffinity.Double:
			if ((object)type == null)
			{
				return GetDouble(stmt, index);
			}
			return Convert.ChangeType(GetDouble(stmt, index), type, null);
		case TypeAffinity.Int64:
			if ((object)type == null)
			{
				return GetInt64(stmt, index);
			}
			if ((object)type == typeof(bool))
			{
				return GetBoolean(stmt, index);
			}
			if ((object)type == typeof(sbyte))
			{
				return GetSByte(stmt, index);
			}
			if ((object)type == typeof(byte))
			{
				return GetByte(stmt, index);
			}
			if ((object)type == typeof(short))
			{
				return GetInt16(stmt, index);
			}
			if ((object)type == typeof(ushort))
			{
				return GetUInt16(stmt, index);
			}
			if ((object)type == typeof(int))
			{
				return GetInt32(stmt, index);
			}
			if ((object)type == typeof(uint))
			{
				return GetUInt32(stmt, index);
			}
			if ((object)type == typeof(long))
			{
				return GetInt64(stmt, index);
			}
			if ((object)type == typeof(ulong))
			{
				return GetUInt64(stmt, index);
			}
			return Convert.ChangeType(GetInt64(stmt, index), type, null);
		default:
			return GetText(stmt, index);
		}
	}

	internal override int GetCursorForTable(SQLiteStatement stmt, int db, int rootPage)
	{
		return UnsafeNativeMethods.sqlite3_table_cursor_interop(stmt._sqlite_stmt, db, rootPage);
	}

	internal override long GetRowIdForCursor(SQLiteStatement stmt, int cursor)
	{
		long rowid = 0L;
		if (UnsafeNativeMethods.sqlite3_cursor_rowid_interop(stmt._sqlite_stmt, cursor, ref rowid) == SQLiteErrorCode.Ok)
		{
			return rowid;
		}
		return 0L;
	}

	internal override void GetIndexColumnExtendedInfo(string database, string index, string column, ref int sortMode, ref int onError, ref string collationSequence)
	{
		IntPtr Collation = IntPtr.Zero;
		int colllen = 0;
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_index_column_info_interop(_sql, SQLiteConvert.ToUTF8(database), SQLiteConvert.ToUTF8(index), SQLiteConvert.ToUTF8(column), ref sortMode, ref onError, ref Collation, ref colllen);
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, null);
		}
		collationSequence = SQLiteConvert.UTF8ToString(Collation, colllen);
	}

	internal override SQLiteErrorCode FileControl(string zDbName, int op, IntPtr pArg)
	{
		return UnsafeNativeMethods.sqlite3_file_control(_sql, (zDbName != null) ? SQLiteConvert.ToUTF8(zDbName) : null, op, pArg);
	}

	static SQLite3()
	{
		Strings.CreateGetStringDelegate(typeof(SQLite3));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0011(107400591), _0011(107400554)).Replace(_0011(107400549), _0011(107400544)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0011(107400571)))
		{
			throw new SecurityException(_0011(107400514));
		}
		syncRoot = new object();
		have_errstr = null;
		have_stmt_readonly = null;
		forceLogPrepare = null;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
