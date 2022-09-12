using System;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal struct MySqlInt64 : IMySqlValue
{
	public bool IsNull { get; }

	MySqlDbType IMySqlValue.MySqlDbType => MySqlDbType.Int64;

	object IMySqlValue.Value => Value;

	public long Value { get; }

	Type IMySqlValue.SystemType => typeof(long);

	string IMySqlValue.MySqlTypeName => "BIGINT";

	public MySqlInt64(bool isNull)
	{
		IsNull = isNull;
		Value = 0L;
	}

	public MySqlInt64(long val)
	{
		IsNull = false;
		Value = val;
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object val, int length)
	{
		long v = (val as long?) ?? Convert.ToInt64(val);
		if (binary)
		{
			packet.WriteInteger(v, 8);
		}
		else
		{
			packet.WriteStringNoNull(v.ToString());
		}
	}

	IMySqlValue IMySqlValue.ReadValue(MySqlPacket packet, long length, bool nullVal)
	{
		if (nullVal)
		{
			return new MySqlInt64(isNull: true);
		}
		if (length == -1L)
		{
			return new MySqlInt64((long)packet.ReadULong(8));
		}
		return new MySqlInt64(long.Parse(packet.ReadString(length)));
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		packet.Position += 8;
	}

	internal static void SetDSInfo(MySqlSchemaCollection sc)
	{
		MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
		mySqlSchemaRow["TypeName"] = "BIGINT";
		mySqlSchemaRow["ProviderDbType"] = MySqlDbType.Int64;
		mySqlSchemaRow["ColumnSize"] = 0;
		mySqlSchemaRow["CreateFormat"] = "BIGINT";
		mySqlSchemaRow["CreateParameters"] = null;
		mySqlSchemaRow["DataType"] = "System.Int64";
		mySqlSchemaRow["IsAutoincrementable"] = true;
		mySqlSchemaRow["IsBestMatch"] = true;
		mySqlSchemaRow["IsCaseSensitive"] = false;
		mySqlSchemaRow["IsFixedLength"] = true;
		mySqlSchemaRow["IsFixedPrecisionScale"] = true;
		mySqlSchemaRow["IsLong"] = false;
		mySqlSchemaRow["IsNullable"] = true;
		mySqlSchemaRow["IsSearchable"] = true;
		mySqlSchemaRow["IsSearchableWithLike"] = false;
		mySqlSchemaRow["IsUnsigned"] = false;
		mySqlSchemaRow["MaximumScale"] = 0;
		mySqlSchemaRow["MinimumScale"] = 0;
		mySqlSchemaRow["IsConcurrencyType"] = DBNull.Value;
		mySqlSchemaRow["IsLiteralSupported"] = false;
		mySqlSchemaRow["LiteralPrefix"] = null;
		mySqlSchemaRow["LiteralSuffix"] = null;
		mySqlSchemaRow["NativeDataType"] = null;
	}
}
