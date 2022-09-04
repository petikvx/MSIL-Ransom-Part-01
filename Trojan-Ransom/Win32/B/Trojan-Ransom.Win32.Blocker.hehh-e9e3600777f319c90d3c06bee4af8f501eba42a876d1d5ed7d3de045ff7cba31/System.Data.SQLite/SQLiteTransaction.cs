using System.Data.Common;
using System.Threading;

namespace System.Data.SQLite;

public sealed class SQLiteTransaction : DbTransaction
{
	internal SQLiteConnection _cnn;

	internal long _version;

	private IsolationLevel _level;

	public new SQLiteConnection Connection => _cnn;

	protected override DbConnection DbConnection => Connection;

	public override IsolationLevel IsolationLevel => _level;

	internal SQLiteTransaction(SQLiteConnection connection, bool deferredLock)
	{
		_cnn = connection;
		_version = _cnn._version;
		_level = (deferredLock ? IsolationLevel.ReadCommitted : IsolationLevel.Serializable);
		if (_cnn._transactionLevel++ != 0)
		{
			return;
		}
		try
		{
			using SQLiteCommand sQLiteCommand = _cnn.CreateCommand();
			if (!deferredLock)
			{
				sQLiteCommand.CommandText = "BEGIN IMMEDIATE";
			}
			else
			{
				sQLiteCommand.CommandText = "BEGIN";
			}
			sQLiteCommand.ExecuteNonQuery();
		}
		catch (SQLiteException)
		{
			_cnn._transactionLevel--;
			_cnn = null;
			throw;
		}
	}

	public override void Commit()
	{
		IsValid(throwError: true);
		if (_cnn._transactionLevel - 1 == 0)
		{
			using SQLiteCommand sQLiteCommand = _cnn.CreateCommand();
			sQLiteCommand.CommandText = "COMMIT";
			sQLiteCommand.ExecuteNonQuery();
		}
		_cnn._transactionLevel--;
		_cnn = null;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && IsValid(throwError: false))
		{
			IssueRollback();
		}
		base.Dispose(disposing);
	}

	public override void Rollback()
	{
		IsValid(throwError: true);
		IssueRollback();
	}

	internal void IssueRollback()
	{
		SQLiteConnection sQLiteConnection = Interlocked.Exchange(ref _cnn, null);
		if (sQLiteConnection != null)
		{
			using (SQLiteCommand sQLiteCommand = sQLiteConnection.CreateCommand())
			{
				sQLiteCommand.CommandText = "ROLLBACK";
				sQLiteCommand.ExecuteNonQuery();
			}
			sQLiteConnection._transactionLevel = 0;
		}
	}

	internal bool IsValid(bool throwError)
	{
		if (_cnn == null)
		{
			if (throwError)
			{
				throw new ArgumentNullException("No connection associated with this transaction");
			}
			return false;
		}
		if (_cnn._version != _version)
		{
			if (throwError)
			{
				throw new SQLiteException(21, "The connection was closed and re-opened, changes were already rolled back");
			}
			return false;
		}
		if (_cnn.State != ConnectionState.Open)
		{
			if (throwError)
			{
				throw new SQLiteException(21, "Connection was closed");
			}
			return false;
		}
		if (_cnn._transactionLevel != 0 && !_cnn._sql.AutoCommit)
		{
			return true;
		}
		_cnn._transactionLevel = 0;
		if (throwError)
		{
			throw new SQLiteException(21, "No transaction is active on this connection");
		}
		return false;
	}
}
