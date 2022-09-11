using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public class SQLiteTransaction : SQLiteTransactionBase
{
	private bool disposed;

	[NonSerialized]
	internal static GetString _008D;

	internal SQLiteTransaction(SQLiteConnection connection, bool deferredLock)
		: base(connection, deferredLock)
	{
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteTransaction).Name);
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

	public override void Commit()
	{
		CheckDisposed();
		IsValid(throwError: true);
		if (_cnn._transactionLevel - 1 == 0)
		{
			using SQLiteCommand sQLiteCommand = _cnn.CreateCommand();
			sQLiteCommand.CommandText = _008D(107382109);
			sQLiteCommand.ExecuteNonQuery();
		}
		_cnn._transactionLevel--;
		_cnn = null;
	}

	protected override void Begin(bool deferredLock)
	{
		if (_cnn._transactionLevel++ != 0)
		{
			return;
		}
		try
		{
			using SQLiteCommand sQLiteCommand = _cnn.CreateCommand();
			if (!deferredLock)
			{
				sQLiteCommand.CommandText = _008D(107382064);
			}
			else
			{
				sQLiteCommand.CommandText = _008D(107382071);
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

	protected override void IssueRollback(bool throwError)
	{
		SQLiteConnection sQLiteConnection = Interlocked.Exchange(ref _cnn, null);
		if (sQLiteConnection == null)
		{
			return;
		}
		try
		{
			using SQLiteCommand sQLiteCommand = sQLiteConnection.CreateCommand();
			sQLiteCommand.CommandText = _008D(107382030);
			sQLiteCommand.ExecuteNonQuery();
		}
		catch
		{
			if (throwError)
			{
				throw;
			}
		}
		sQLiteConnection._transactionLevel = 0;
	}

	static SQLiteTransaction()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteTransaction));
	}
}
