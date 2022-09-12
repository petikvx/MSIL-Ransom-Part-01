using System;
using System.Data;
using System.Data.Common;

namespace MySql.Data.MySqlClient;

public sealed class MySqlTransaction : DbTransaction
{
	private bool open;

	private bool disposed;

	public new MySqlConnection Connection { get; }

	public override IsolationLevel IsolationLevel { get; }

	protected override DbConnection DbConnection => Connection;

	internal MySqlTransaction(MySqlConnection c, IsolationLevel il)
	{
		Connection = c;
		IsolationLevel = il;
		open = true;
	}

	~MySqlTransaction()
	{
		Dispose(disposing: false);
	}

	protected override void Dispose(bool disposing)
	{
		if (!disposed)
		{
			base.Dispose(disposing);
			if (disposing && ((Connection != null && Connection.State == ConnectionState.Open) || Connection.SoftClosed) && open)
			{
				Rollback();
			}
			disposed = true;
		}
	}

	public override void Commit()
	{
		if (Connection != null && (Connection.State == ConnectionState.Open || Connection.SoftClosed))
		{
			if (!open)
			{
				throw new InvalidOperationException("Transaction has already been committed or is not pending");
			}
			new MySqlCommand("COMMIT", Connection).ExecuteNonQuery();
			open = false;
			return;
		}
		throw new InvalidOperationException("Connection must be valid and open to commit transaction");
	}

	public override void Rollback()
	{
		if (Connection != null && (Connection.State == ConnectionState.Open || Connection.SoftClosed))
		{
			if (!open)
			{
				throw new InvalidOperationException("Transaction has already been rolled back or is not pending");
			}
			new MySqlCommand("ROLLBACK", Connection).ExecuteNonQuery();
			open = false;
			return;
		}
		throw new InvalidOperationException("Connection must be valid and open to rollback transaction");
	}
}
