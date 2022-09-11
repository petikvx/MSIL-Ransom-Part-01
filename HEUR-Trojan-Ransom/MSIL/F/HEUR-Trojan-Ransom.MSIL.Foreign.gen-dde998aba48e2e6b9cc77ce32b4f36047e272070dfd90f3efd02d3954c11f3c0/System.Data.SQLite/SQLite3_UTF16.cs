using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal sealed class SQLite3_UTF16 : SQLite3
{
	private bool disposed;

	[NonSerialized]
	internal static GetString _0001;

	internal SQLite3_UTF16(SQLiteDateFormats fmt, DateTimeKind kind, string fmtString, IntPtr db, string fileName, bool ownHandle)
		: base(fmt, kind, fmtString, db, fileName, ownHandle)
	{
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLite3_UTF16).Name);
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			_ = disposed;
		}
		finally
		{
			base.Dispose(disposing);
			disposed = true;
		}
	}

	public override string ToString(IntPtr b, int nbytelen)
	{
		CheckDisposed();
		return UTF16ToString(b, nbytelen);
	}

	public static string UTF16ToString(IntPtr b, int nbytelen)
	{
		if (nbytelen == 0 || b == IntPtr.Zero)
		{
			return string.Empty;
		}
		if (nbytelen == -1)
		{
			return Marshal.PtrToStringUni(b);
		}
		return Marshal.PtrToStringUni(b, nbytelen / 2);
	}

	internal override void Open(string strFilename, string vfsName, SQLiteConnectionFlags connectionFlags, SQLiteOpenFlagsEnum openFlags, int maxPoolSize, bool usePool)
	{
		if (_sql != null)
		{
			Close(canThrow: true);
		}
		if (_sql != null)
		{
			throw new SQLiteException(_0001(107364582));
		}
		_usePool = usePool;
		_fileName = strFilename;
		_flags = connectionFlags;
		if (usePool)
		{
			_sql = SQLiteConnectionPool.Remove(strFilename, maxPoolSize, out _poolVersion);
			SQLiteConnection.OnChanged(null, new ConnectionEventArgs(SQLiteConnectionEventType.OpenedFromPool, null, null, null, null, _sql, strFilename, new object[8]
			{
				typeof(SQLite3_UTF16),
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
				SQLiteErrorCode sQLiteErrorCode;
				if (vfsName != null || num != 0)
				{
					sQLiteErrorCode = UnsafeNativeMethods.sqlite3_open16_interop(SQLiteConvert.ToUTF8(strFilename), SQLiteConvert.ToUTF8(vfsName), openFlags, num, ref db);
				}
				else
				{
					if ((openFlags & SQLiteOpenFlagsEnum.Create) != SQLiteOpenFlagsEnum.Create && !File.Exists(strFilename))
					{
						throw new SQLiteException(SQLiteErrorCode.CantOpen, strFilename);
					}
					if (vfsName != null)
					{
						throw new SQLiteException(SQLiteErrorCode.CantOpen, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0001(107362847), vfsName));
					}
					sQLiteErrorCode = UnsafeNativeMethods.sqlite3_open16(strFilename, ref db);
				}
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
				typeof(SQLite3_UTF16),
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

	internal override void Bind_DateTime(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, DateTime dt)
	{
		switch (_datetimeFormat)
		{
		case SQLiteDateFormats.Ticks:
		case SQLiteDateFormats.JulianDay:
		case SQLiteDateFormats.UnixEpoch:
			base.Bind_DateTime(stmt, flags, index, dt);
			return;
		}
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			SQLiteStatementHandle handle = stmt?._sqlite_stmt;
			SQLite3.LogBind(handle, index, dt);
		}
		Bind_Text(stmt, flags, index, ToString(dt));
	}

	internal override void Bind_Text(SQLiteStatement stmt, SQLiteConnectionFlags flags, int index, string value)
	{
		SQLiteStatementHandle sqlite_stmt = stmt._sqlite_stmt;
		if ((flags & SQLiteConnectionFlags.LogBind) == SQLiteConnectionFlags.LogBind)
		{
			SQLite3.LogBind(sqlite_stmt, index, value);
		}
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_bind_text16(sqlite_stmt, index, value, value.Length * 2, (IntPtr)(-1));
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, GetLastError());
		}
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
		return ToDateTime(GetText(stmt, index));
	}

	internal override string ColumnName(SQLiteStatement stmt, int index)
	{
		int len = 0;
		IntPtr intPtr = UnsafeNativeMethods.sqlite3_column_name16_interop(stmt._sqlite_stmt, index, ref len);
		if (intPtr == IntPtr.Zero)
		{
			throw new SQLiteException(SQLiteErrorCode.NoMem, GetLastError());
		}
		return UTF16ToString(intPtr, len);
	}

	internal override string GetText(SQLiteStatement stmt, int index)
	{
		int len = 0;
		return UTF16ToString(UnsafeNativeMethods.sqlite3_column_text16_interop(stmt._sqlite_stmt, index, ref len), len);
	}

	internal override string ColumnOriginalName(SQLiteStatement stmt, int index)
	{
		int len = 0;
		return UTF16ToString(UnsafeNativeMethods.sqlite3_column_origin_name16_interop(stmt._sqlite_stmt, index, ref len), len);
	}

	internal override string ColumnDatabaseName(SQLiteStatement stmt, int index)
	{
		int len = 0;
		return UTF16ToString(UnsafeNativeMethods.sqlite3_column_database_name16_interop(stmt._sqlite_stmt, index, ref len), len);
	}

	internal override string ColumnTableName(SQLiteStatement stmt, int index)
	{
		int len = 0;
		return UTF16ToString(UnsafeNativeMethods.sqlite3_column_table_name16_interop(stmt._sqlite_stmt, index, ref len), len);
	}

	internal override string GetParamValueText(IntPtr ptr)
	{
		int len = 0;
		return UTF16ToString(UnsafeNativeMethods.sqlite3_value_text16_interop(ptr, ref len), len);
	}

	internal override void ReturnError(IntPtr context, string value)
	{
		UnsafeNativeMethods.sqlite3_result_error16(context, value, value.Length * 2);
	}

	internal override void ReturnText(IntPtr context, string value)
	{
		UnsafeNativeMethods.sqlite3_result_text16(context, value, value.Length * 2, (IntPtr)(-1));
	}

	static SQLite3_UTF16()
	{
		Strings.CreateGetStringDelegate(typeof(SQLite3_UTF16));
	}
}
