using System;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal struct MySqlUInt64 : IMySqlValue
{
	public bool IsNull { get; }

	MySqlDbType IMySqlValue.MySqlDbType => MySqlDbType.UInt64;

	object IMySqlValue.Value => Value;

	public ulong Value { get; }

	Type IMySqlValue.SystemType => typeof(ulong);

	string IMySqlValue.MySqlTypeName => "BIGINT";

	public MySqlUInt64(bool isNull)
	{
		IsNull = isNull;
		Value = 0uL;
	}

	public MySqlUInt64(ulong val)
	{
		IsNull = false;
		Value = val;
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object val, int length)
	{
		ulong v = (val as ulong?) ?? Convert.ToUInt64(val);
		if (binary)
		{
			packet.WriteInteger((long)v, 8);
		}
		else
		{
			packet.WriteStringNoNull(v.ToString(CultureInfo.InvariantCulture));
		}
	}

	IMySqlValue IMySqlValue.ReadValue(MySqlPacket packet, long length, bool nullVal)
	{
		if (nullVal)
		{
			return new MySqlUInt64(isNull: true);
		}
		if (length == -1L)
		{
			return new MySqlUInt64(packet.ReadULong(8));
		}
		return new MySqlUInt64(ulong.Parse(packet.ReadString(length), CultureInfo.InvariantCulture));
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		packet.Position += 8;
	}

	internal static void SetDSInfo(MySqlSchemaCollection sc)
	{
		MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
		mySqlSchemaRow["TypeName"] = "BIGINT";
		mySqlSchemaRow["ProviderDbType"] = MySqlDbType.UInt64;
		mySqlSchemaRow["ColumnSize"] = 0;
		mySqlSchemaRow["CreateFormat"] = "BIGINT UNSIGNED";
		mySqlSchemaRow["CreateParameters"] = null;
		mySqlSchemaRow["DataType"] = "System.UInt64";
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
