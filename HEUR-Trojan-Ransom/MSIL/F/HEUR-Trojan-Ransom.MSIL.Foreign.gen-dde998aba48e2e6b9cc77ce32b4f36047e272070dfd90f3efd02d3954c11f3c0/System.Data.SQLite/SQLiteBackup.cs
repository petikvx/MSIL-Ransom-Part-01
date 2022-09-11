using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal sealed class SQLiteBackup : IDisposable
{
	internal SQLiteBase _sql;

	internal SQLiteBackupHandle _sqlite_backup;

	internal IntPtr _destDb;

	internal byte[] _zDestName;

	internal IntPtr _sourceDb;

	internal byte[] _zSourceName;

	internal SQLiteErrorCode _stepResult;

	private bool disposed;

	[NonSerialized]
	internal static GetString _007F;

	internal SQLiteBackup(SQLiteBase sqlbase, SQLiteBackupHandle backup, IntPtr destDb, byte[] zDestName, IntPtr sourceDb, byte[] zSourceName)
	{
		_sql = sqlbase;
		_sqlite_backup = backup;
		_destDb = destDb;
		_zDestName = zDestName;
		_sourceDb = sourceDb;
		_zSourceName = zSourceName;
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
			throw new ObjectDisposedException(typeof(SQLiteBackup).Name);
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
			if (_sqlite_backup != null)
			{
				_sqlite_backup.Dispose();
				_sqlite_backup = null;
			}
			_zSourceName = null;
			_sourceDb = IntPtr.Zero;
			_zDestName = null;
			_destDb = IntPtr.Zero;
			_sql = null;
		}
		disposed = true;
	}

	~SQLiteBackup()
	{
		Dispose(disposing: false);
	}

	static SQLiteBackup()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteBackup));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _007F(107400602), _007F(107400565)), _007F(107400560), _007F(107400555)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _007F(107400582)))
		{
			return;
		}
		throw new SecurityException(_007F(107400525));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
