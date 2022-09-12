using System;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal struct MySqlUByte : IMySqlValue
{
	public bool IsNull { get; }

	MySqlDbType IMySqlValue.MySqlDbType => MySqlDbType.UByte;

	object IMySqlValue.Value => Value;

	public byte Value { get; }

	Type IMySqlValue.SystemType => typeof(byte);

	string IMySqlValue.MySqlTypeName => "TINYINT";

	public MySqlUByte(bool isNull)
	{
		IsNull = isNull;
		Value = 0;
	}

	public MySqlUByte(byte val)
	{
		IsNull = false;
		Value = val;
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object val, int length)
	{
		byte b = (val as byte?) ?? Convert.ToByte(val);
		if (binary)
		{
			packet.WriteByte(b);
		}
		else
		{
			packet.WriteStringNoNull(b.ToString());
		}
	}

	IMySqlValue IMySqlValue.ReadValue(MySqlPacket packet, long length, bool nullVal)
	{
		if (nullVal)
		{
			return new MySqlUByte(isNull: true);
		}
		if (length == -1L)
		{
			return new MySqlUByte(packet.ReadByte());
		}
		return new MySqlUByte(byte.Parse(packet.ReadString(length)));
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		packet.ReadByte();
	}

	internal static void SetDSInfo(MySqlSchemaCollection sc)
	{
		MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
		mySqlSchemaRow["TypeName"] = "TINY INT";
		mySqlSchemaRow["ProviderDbType"] = MySqlDbType.UByte;
		mySqlSchemaRow["ColumnSize"] = 0;
		mySqlSchemaRow["CreateFormat"] = "TINYINT UNSIGNED";
		mySqlSchemaRow["CreateParameters"] = null;
		mySqlSchemaRow["DataType"] = "System.Byte";
		mySqlSchemaRow["IsAutoincrementable"] = true;
		mySqlSchemaRow["IsBestMatch"] = true;
		mySqlSchemaRow["IsCaseSensitive"] = false;
		mySqlSchemaRow["IsFixedLength"] = true;
		mySqlSchemaRow["IsFixedPrecisionScale"] = true;
		mySqlSchemaRow["IsLong"] = false;
		mySqlSchemaRow["IsNullable"] = true;
		mySqlSchemaRow["IsSearchable"] = true;
		mySqlSchemaRow["IsSearchableWithLike"] = false;
		mySqlSchemaRow["IsUnsigned"] = true;
		mySqlSchemaRow["MaximumScale"] = 0;
		mySqlSchemaRow["MinimumScale"] = 0;
		mySqlSchemaRow["IsConcurrencyType"] = DBNull.Value;
		mySqlSchemaRow["IsLiteralSupported"] = false;
		mySqlSchemaRow["LiteralPrefix"] = null;
		mySqlSchemaRow["LiteralSuffix"] = null;
		mySqlSchemaRow["NativeDataType"] = null;
	}
}
