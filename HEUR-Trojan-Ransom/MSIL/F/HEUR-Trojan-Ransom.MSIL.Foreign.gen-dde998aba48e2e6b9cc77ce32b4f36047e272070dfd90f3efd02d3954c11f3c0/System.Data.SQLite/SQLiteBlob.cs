using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class SQLiteBlob : IDisposable
{
	internal SQLiteBase _sql;

	internal SQLiteBlobHandle _sqlite_blob;

	private bool disposed;

	[NonSerialized]
	internal static GetString _0093;

	private SQLiteBlob(SQLiteBase sqlbase, SQLiteBlobHandle blob)
	{
		_sql = sqlbase;
		_sqlite_blob = blob;
	}

	public static SQLiteBlob Create(SQLiteDataReader dataReader, int i, bool readOnly)
	{
		SQLiteConnection connection = SQLiteDataReader.GetConnection(dataReader);
		if (connection == null)
		{
			throw new InvalidOperationException(_0093(107362835));
		}
		if (!(connection._sql is SQLite3 sQLite))
		{
			throw new InvalidOperationException(_0093(107362802));
		}
		SQLiteConnectionHandle sql = sQLite._sql;
		if (sql == null)
		{
			throw new InvalidOperationException(_0093(107362765));
		}
		long? rowId = dataReader.GetRowId(i);
		if (!rowId.HasValue)
		{
			throw new InvalidOperationException(_0093(107362752));
		}
		SQLiteBlobHandle sQLiteBlobHandle = null;
		try
		{
		}
		finally
		{
			IntPtr ptrBlob = IntPtr.Zero;
			SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_blob_open(sQLite._sql, SQLiteConvert.ToUTF8(dataReader.GetDatabaseName(i)), SQLiteConvert.ToUTF8(dataReader.GetTableName(i)), SQLiteConvert.ToUTF8(dataReader.GetName(i)), rowId.Value, (!readOnly) ? 1 : 0, ref ptrBlob);
			if (sQLiteErrorCode != 0)
			{
				throw new SQLiteException(sQLiteErrorCode, null);
			}
			sQLiteBlobHandle = new SQLiteBlobHandle(sql, ptrBlob);
		}
		SQLiteConnection.OnChanged(null, new ConnectionEventArgs(SQLiteConnectionEventType.NewCriticalHandle, null, null, null, dataReader, sQLiteBlobHandle, null, new object[4]
		{
			typeof(SQLiteBlob),
			dataReader,
			i,
			readOnly
		}));
		return new SQLiteBlob(sQLite, sQLiteBlobHandle);
	}

	private void CheckOpen()
	{
		if (_sqlite_blob == IntPtr.Zero)
		{
			throw new InvalidOperationException(_0093(107362723));
		}
	}

	private void VerifyParameters(byte[] buffer, int count, int offset)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException(_0093(107363178));
		}
		if (offset < 0)
		{
			throw new ArgumentException(_0093(107363201));
		}
		if (count < 0)
		{
			throw new ArgumentException(_0093(107363128));
		}
		if (count > buffer.Length)
		{
			throw new ArgumentException(_0093(107363091));
		}
	}

	public void Reopen(long rowId)
	{
		CheckDisposed();
		CheckOpen();
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_blob_reopen(_sqlite_blob, rowId);
		if (sQLiteErrorCode != 0)
		{
			Dispose();
			throw new SQLiteException(sQLiteErrorCode, null);
		}
	}

	public int GetCount()
	{
		CheckDisposed();
		CheckOpen();
		return UnsafeNativeMethods.sqlite3_blob_bytes(_sqlite_blob);
	}

	public void Read(byte[] buffer, int count, int offset)
	{
		CheckDisposed();
		CheckOpen();
		VerifyParameters(buffer, count, offset);
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_blob_read(_sqlite_blob, buffer, count, offset);
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, null);
		}
	}

	public void Write(byte[] buffer, int count, int offset)
	{
		CheckDisposed();
		CheckOpen();
		VerifyParameters(buffer, count, offset);
		SQLiteErrorCode sQLiteErrorCode = UnsafeNativeMethods.sqlite3_blob_write(_sqlite_blob, buffer, count, offset);
		if (sQLiteErrorCode != 0)
		{
			throw new SQLiteException(sQLiteErrorCode, null);
		}
	}

	public void Close()
	{
		Dispose();
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
			throw new ObjectDisposedException(typeof(SQLiteBlob).Name);
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
			if (_sqlite_blob != null)
			{
				_sqlite_blob.Dispose();
				_sqlite_blob = null;
			}
			_sql = null;
		}
		disposed = true;
	}

	~SQLiteBlob()
	{
		Dispose(disposing: false);
	}

	static SQLiteBlob()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteBlob));
	}
}
