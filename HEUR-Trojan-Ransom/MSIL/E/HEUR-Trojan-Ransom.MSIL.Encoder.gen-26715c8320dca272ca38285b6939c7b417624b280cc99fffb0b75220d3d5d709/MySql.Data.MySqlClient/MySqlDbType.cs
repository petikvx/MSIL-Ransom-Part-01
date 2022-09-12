using System;

namespace MySql.Data.MySqlClient;

public enum MySqlDbType
{
	Decimal = 0,
	Byte = 1,
	Int16 = 2,
	Int24 = 9,
	Int32 = 3,
	Int64 = 8,
	Float = 4,
	Double = 5,
	Timestamp = 7,
	Date = 10,
	Time = 11,
	DateTime = 12,
	[Obsolete("The Datetime enum value is obsolete.  Please use DateTime.")]
	Datetime = 12,
	Year = 13,
	Newdate = 14,
	VarString = 15,
	Bit = 16,
	JSON = 245,
	NewDecimal = 246,
	Enum = 247,
	Set = 248,
	TinyBlob = 249,
	MediumBlob = 250,
	LongBlob = 251,
	Blob = 252,
	VarChar = 253,
	String = 254,
	Geometry = 255,
	UByte = 501,
	UInt16 = 502,
	UInt24 = 509,
	UInt32 = 503,
	UInt64 = 508,
	Binary = 754,
	VarBinary = 753,
	TinyText = 749,
	MediumText = 750,
	LongText = 751,
	Text = 752,
	Guid = 854
}
