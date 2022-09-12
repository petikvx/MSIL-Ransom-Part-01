using System;

namespace MySql.Data.MySqlClient;

[Flags]
internal enum ColumnFlags
{
	NOT_NULL = 1,
	PRIMARY_KEY = 2,
	UNIQUE_KEY = 4,
	MULTIPLE_KEY = 8,
	BLOB = 0x10,
	UNSIGNED = 0x20,
	ZERO_FILL = 0x40,
	BINARY = 0x80,
	ENUM = 0x100,
	AUTO_INCREMENT = 0x200,
	TIMESTAMP = 0x400,
	SET = 0x800,
	NUMBER = 0x8000
}
