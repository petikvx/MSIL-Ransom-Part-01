using System.Transactions;

namespace System.Data.SQLite;

internal class SQLiteEnlistment : IEnlistmentNotification
{
	internal SQLiteTransaction _transaction;

	internal Transaction _scope;

	internal bool _disposeConnection;

	internal SQLiteEnlistment(SQLiteConnection cnn, Transaction scope)
	{
		_transaction = cnn.BeginTransaction();
		_scope = scope;
		_scope.EnlistVolatile(this, EnlistmentOptions.None);
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

	public void Commit(Enlistment enlistment)
	{
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
		enlistment.Done();
	}

	public void Prepare(PreparingEnlistment preparingEnlistment)
	{
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
}
