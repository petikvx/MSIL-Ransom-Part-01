using System.Collections;
using System.Transactions;

namespace MySql.Data.MySqlClient;

internal class DriverTransactionManager
{
	private static Hashtable driversInUse = new Hashtable();

	public static Driver GetDriverInTransaction(Transaction transaction)
	{
		lock (driversInUse.SyncRoot)
		{
			return (Driver)driversInUse[transaction.GetHashCode()];
		}
	}

	public static void SetDriverInTransaction(Driver driver)
	{
		lock (driversInUse.SyncRoot)
		{
			driversInUse[driver.currentTransaction.BaseTransaction.GetHashCode()] = driver;
		}
	}

	public static void RemoveDriverInTransaction(Transaction transaction)
	{
		lock (driversInUse.SyncRoot)
		{
			driversInUse.Remove(transaction.GetHashCode());
		}
	}
}
