using System.Data;
using System.Threading;
using System.Transactions;

namespace MySql.Data.MySqlClient;

internal class MySqlTransactionScope
{
	public MySqlConnection connection;

	public Transaction baseTransaction;

	public MySqlTransaction simpleTransaction;

	public int rollbackThreadId;

	public MySqlTransactionScope(MySqlConnection con, Transaction trans, MySqlTransaction simpleTransaction)
	{
		connection = con;
		baseTransaction = trans;
		this.simpleTransaction = simpleTransaction;
	}

	public void Rollback(SinglePhaseEnlistment singlePhaseEnlistment)
	{
		Driver driver = connection.driver;
		lock (driver)
		{
			rollbackThreadId = Thread.CurrentThread.ManagedThreadId;
			while (connection.Reader != null)
			{
				Thread.Sleep(100);
			}
			simpleTransaction.Rollback();
			singlePhaseEnlistment.Aborted();
			DriverTransactionManager.RemoveDriverInTransaction(baseTransaction);
			driver.currentTransaction = null;
			if (connection.State == ConnectionState.Closed)
			{
				connection.CloseFully();
			}
			rollbackThreadId = 0;
		}
	}

	public void SinglePhaseCommit(SinglePhaseEnlistment singlePhaseEnlistment)
	{
		simpleTransaction.Commit();
		singlePhaseEnlistment.Committed();
		DriverTransactionManager.RemoveDriverInTransaction(baseTransaction);
		connection.driver.currentTransaction = null;
		if (connection.State == ConnectionState.Closed)
		{
			connection.CloseFully();
		}
	}
}
