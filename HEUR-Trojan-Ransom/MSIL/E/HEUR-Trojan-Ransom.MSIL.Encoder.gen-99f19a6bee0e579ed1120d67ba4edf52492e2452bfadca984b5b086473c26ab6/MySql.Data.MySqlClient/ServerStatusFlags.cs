using System;

namespace MySql.Data.MySqlClient;

[Flags]
internal enum ServerStatusFlags
{
	InTransaction = 1,
	AutoCommitMode = 2,
	MoreResults = 4,
	AnotherQuery = 8,
	BadIndex = 0x10,
	NoIndex = 0x20,
	CursorExists = 0x40,
	LastRowSent = 0x80,
	OutputParameters = 0x1000
}
