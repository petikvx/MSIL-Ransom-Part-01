namespace System.Data.SQLite;

public class UpdateEventArgs : EventArgs
{
	public readonly string Database;

	public readonly string Table;

	public readonly UpdateEventType Event;

	public readonly long RowId;

	internal UpdateEventArgs(string database, string table, UpdateEventType eventType, long rowid)
	{
		Database = database;
		Table = table;
		Event = eventType;
		RowId = rowid;
	}
}
