namespace System.Data.SQLite;

public enum SQLiteConnectionEventType
{
	Invalid = -1,
	Unknown,
	Opening,
	ConnectionString,
	Opened,
	ChangeDatabase,
	NewTransaction,
	EnlistTransaction,
	NewCommand,
	NewDataReader,
	NewCriticalHandle,
	Closing,
	Closed,
	DisposingCommand,
	DisposingDataReader,
	ClosingDataReader,
	OpenedFromPool,
	ClosedToPool
}
