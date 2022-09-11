namespace System.Data.SQLite;

[Flags]
internal enum SQLiteOpenFlagsEnum
{
	None = 0,
	ReadOnly = 1,
	ReadWrite = 2,
	Create = 4,
	Uri = 0x40,
	Memory = 0x80,
	Default = 6
}
