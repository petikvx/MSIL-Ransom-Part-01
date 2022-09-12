namespace MySql.Data.MySqlClient;

internal enum Field_Type : byte
{
	DECIMAL = 0,
	BYTE = 1,
	SHORT = 2,
	LONG = 3,
	FLOAT = 4,
	DOUBLE = 5,
	NULL = 6,
	TIMESTAMP = 7,
	LONGLONG = 8,
	INT24 = 9,
	DATE = 10,
	TIME = 11,
	DATETIME = 12,
	YEAR = 13,
	NEWDATE = 14,
	ENUM = 247,
	SET = 248,
	TINY_BLOB = 249,
	MEDIUM_BLOB = 250,
	LONG_BLOB = 251,
	BLOB = 252,
	VAR_STRING = 253,
	STRING = 254
}
