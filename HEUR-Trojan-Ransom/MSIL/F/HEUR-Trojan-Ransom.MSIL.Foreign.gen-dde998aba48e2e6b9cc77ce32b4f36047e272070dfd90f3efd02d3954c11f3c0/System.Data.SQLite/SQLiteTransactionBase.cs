using System.Data.Common;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public abstract class SQLiteTransactionBase : DbTransaction
{
	internal SQLiteConnection _cnn;

	internal int _version;

	private IsolationLevel _level;

	private bool disposed;

	[NonSerialized]
	internal static GetString _008E;

	public override IsolationLevel IsolationLevel
	{
		get
		{
			CheckDisposed();
			return _level;
		}
	}

	public new SQLiteConnection Connection
	{
		get
		{
			CheckDisposed();
			return _cnn;
		}
	}

	protected override DbConnection DbConnection => Connection;

	internal SQLiteTransactionBase(SQLiteConnection connection, bool deferredLock)
	{
		_cnn = connection;
		_version = _cnn._version;
		_level = (deferredLock ? IsolationLevel.ReadCommitted : IsolationLevel.Serializable);
		Begin(deferredLock);
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteTransactionBase).Name);
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!disposed && disposing && IsValid(throwError: false))
			{
				IssueRollback(throwError: false);
			}
		}
		finally
		{
			base.Dispose(disposing);
			disposed = true;
		}
	}

	public override void Rollback()
	{
		CheckDisposed();
		IsValid(throwError: true);
		IssueRollback(throwError: true);
	}

	protected abstract void Begin(bool deferredLock);

	protected abstract void IssueRollback(bool throwError);

	internal bool IsValid(bool throwError)
	{
		if (_cnn == null)
		{
			if (throwError)
			{
				throw new ArgumentNullException(_008E(107381851));
			}
			return false;
		}
		if (_cnn._version != _version)
		{
			if (throwError)
			{
				throw new SQLiteException(_008E(107381786));
			}
			return false;
		}
		if (_cnn.State != ConnectionState.Open)
		{
			if (throwError)
			{
				throw new SQLiteException(_008E(107381685));
			}
			return false;
		}
		if (_cnn._transactionLevel == 0 || _cnn._sql.AutoCommit)
		{
			_cnn._transactionLevel = 0;
			if (throwError)
			{
				throw new SQLiteException(_008E(107382168));
			}
			return false;
		}
		return true;
	}

	static SQLiteTransactionBase()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteTransactionBase));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _008E(107401235), _008E(107401198)), _008E(107401193), _008E(107401188)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _008E(107401215)))
		{
			return;
		}
		throw new SecurityException(_008E(107401158));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
