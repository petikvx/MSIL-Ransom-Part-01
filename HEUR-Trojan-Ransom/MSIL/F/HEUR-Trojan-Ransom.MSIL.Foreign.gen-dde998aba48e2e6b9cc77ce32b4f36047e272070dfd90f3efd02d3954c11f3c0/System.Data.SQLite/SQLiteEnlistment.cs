using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Transactions;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal sealed class SQLiteEnlistment : IDisposable, IEnlistmentNotification
{
	internal SQLiteTransaction _transaction;

	internal Transaction _scope;

	internal bool _disposeConnection;

	private bool disposed;

	[NonSerialized]
	internal static GetString _0094;

	internal SQLiteEnlistment(SQLiteConnection cnn, Transaction scope, IsolationLevel defaultIsolationLevel, bool throwOnUnavailable, bool throwOnUnsupported)
	{
		_transaction = cnn.BeginTransaction(GetSystemDataIsolationLevel(cnn, scope, defaultIsolationLevel, throwOnUnavailable, throwOnUnsupported));
		_scope = scope;
		_scope.EnlistVolatile(this, EnlistmentOptions.None);
	}

	private IsolationLevel GetSystemDataIsolationLevel(SQLiteConnection connection, Transaction transaction, IsolationLevel defaultIsolationLevel, bool throwOnUnavailable, bool throwOnUnsupported)
	{
		if (transaction == null)
		{
			if (connection != null)
			{
				return connection.GetDefaultIsolationLevel();
			}
			if (throwOnUnavailable)
			{
				throw new InvalidOperationException(_0094(107380118));
			}
			return defaultIsolationLevel;
		}
		System.Transactions.IsolationLevel isolationLevel = transaction.IsolationLevel;
		switch (isolationLevel)
		{
		case System.Transactions.IsolationLevel.Unspecified:
			return IsolationLevel.Unspecified;
		case System.Transactions.IsolationLevel.Chaos:
			return IsolationLevel.Chaos;
		case System.Transactions.IsolationLevel.ReadUncommitted:
			return IsolationLevel.ReadUncommitted;
		case System.Transactions.IsolationLevel.ReadCommitted:
			return IsolationLevel.ReadCommitted;
		case System.Transactions.IsolationLevel.RepeatableRead:
			return IsolationLevel.RepeatableRead;
		case System.Transactions.IsolationLevel.Serializable:
			return IsolationLevel.Serializable;
		case System.Transactions.IsolationLevel.Snapshot:
			return IsolationLevel.Snapshot;
		default:
			if (throwOnUnsupported)
			{
				throw new InvalidOperationException(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0094(107380045), isolationLevel));
			}
			return defaultIsolationLevel;
		}
	}

	private void Cleanup(SQLiteConnection cnn)
	{
		if (_disposeConnection)
		{
			cnn.Dispose();
		}
		_transaction = null;
		_scope = null;
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
			throw new ObjectDisposedException(typeof(SQLiteEnlistment).Name);
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
			if (_transaction != null)
			{
				_transaction.Dispose();
				_transaction = null;
			}
			if (_scope != null)
			{
				_scope = null;
			}
		}
		disposed = true;
	}

	~SQLiteEnlistment()
	{
		Dispose(disposing: false);
	}

	public void Commit(Enlistment enlistment)
	{
		CheckDisposed();
		SQLiteConnection connection = _transaction.Connection;
		connection._enlistment = null;
		try
		{
			_transaction.IsValid(throwError: true);
			_transaction.Connection._transactionLevel = 1;
			_transaction.Commit();
			enlistment.Done();
		}
		finally
		{
			Cleanup(connection);
		}
	}

	public void InDoubt(Enlistment enlistment)
	{
		CheckDisposed();
		enlistment.Done();
	}

	public void Prepare(PreparingEnlistment preparingEnlistment)
	{
		CheckDisposed();
		if (!_transaction.IsValid(throwError: false))
		{
			preparingEnlistment.ForceRollback();
		}
		else
		{
			preparingEnlistment.Prepared();
		}
	}

	public void Rollback(Enlistment enlistment)
	{
		CheckDisposed();
		SQLiteConnection connection = _transaction.Connection;
		connection._enlistment = null;
		try
		{
			_transaction.Rollback();
			enlistment.Done();
		}
		finally
		{
			Cleanup(connection);
		}
	}

	static SQLiteEnlistment()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteEnlistment));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0094(107401331), _0094(107401294)), _0094(107401289), _0094(107401284)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0094(107401311)))
		{
			return;
		}
		throw new SecurityException(_0094(107401254));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
