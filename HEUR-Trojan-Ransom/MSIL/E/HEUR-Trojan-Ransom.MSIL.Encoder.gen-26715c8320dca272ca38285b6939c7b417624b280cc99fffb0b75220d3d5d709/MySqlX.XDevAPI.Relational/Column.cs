using System;
using MySql.Data.MySqlClient.X.XDevAPI.Common;
using MySqlX.Protocol;

namespace MySqlX.XDevAPI.Relational;

public class Column
{
	internal ValueDecoder _decoder;

	internal ulong _collationNumber;

	public string ColumnName { get; internal set; }

	public string ColumnLabel { get; internal set; }

	public string TableName { get; internal set; }

	public string TableLabel { get; internal set; }

	public string SchemaName { get; internal set; }

	public string DatabaseName { get; internal set; }

	public string CollationName { get; internal set; }

	public string CharacterSetName { get; internal set; }

	public uint Length { get; internal set; }

	public uint FractionalDigits { get; internal set; }

	public ColumnType Type { get; internal set; }

	public Type ClrType { get; internal set; }

	public bool IsNumberSigned { get; internal set; }

	public bool IsPadded { get; internal set; }
}
