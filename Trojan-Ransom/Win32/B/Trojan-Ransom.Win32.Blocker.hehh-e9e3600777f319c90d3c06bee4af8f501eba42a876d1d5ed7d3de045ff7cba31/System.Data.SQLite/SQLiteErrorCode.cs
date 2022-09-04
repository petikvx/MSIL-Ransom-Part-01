namespace System.Data.SQLite;

public enum SQLiteErrorCode
{
	Ok = 0,
	Error = 1,
	Internal = 2,
	Perm = 3,
	Abort = 4,
	Busy = 5,
	Locked = 6,
	NoMem = 7,
	ReadOnly = 8,
	Interrupt = 9,
	IOErr = 10,
	Corrupt = 11,
	NotFound = 12,
	Full = 13,
	CantOpen = 14,
	Protocol = 15,
	Empty = 16,
	Schema = 17,
	TooBig = 18,
	Constraint = 19,
	Mismatch = 20,
	Misuse = 21,
	NOLFS = 22,
	Auth = 23,
	Format = 24,
	Range = 25,
	NotADatabase = 26,
	Row = 100,
	Done = 101
}
