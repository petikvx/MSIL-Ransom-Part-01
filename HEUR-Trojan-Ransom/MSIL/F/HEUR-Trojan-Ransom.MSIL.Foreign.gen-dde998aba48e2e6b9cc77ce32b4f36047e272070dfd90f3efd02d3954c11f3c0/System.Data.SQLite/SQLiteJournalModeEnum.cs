namespace System.Data.SQLite;

public enum SQLiteJournalModeEnum
{
	Default = -1,
	Delete,
	Persist,
	Off,
	Truncate,
	Memory,
	Wal
}
