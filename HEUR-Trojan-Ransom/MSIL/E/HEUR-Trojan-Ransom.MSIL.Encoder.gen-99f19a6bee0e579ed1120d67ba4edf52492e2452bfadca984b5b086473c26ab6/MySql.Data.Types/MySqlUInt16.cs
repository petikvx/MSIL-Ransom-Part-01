using System;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal struct MySqlUInt16 : IMySqlValue
{
	public bool IsNull { get; }

	MySqlDbType IMySqlValue.MySqlDbType => MySqlDbType.UInt16;

	object IMySqlValue.Value => Value;

	public ushort Value { get; }

	Type IMySqlValue.SystemType => typeof(ushort);

	string IMySqlValue.MySqlTypeName => "SMALLINT";

	public MySqlUInt16(bool isNull)
	{
		IsNull = isNull;
		Value = 0;
	}

	public MySqlUInt16(ushort val)
	{
		IsNull = false;
		Value = val;
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object val, int length)
	{
		int num = ((val is ushort) ? ((ushort)val) : Convert.ToUInt16(val));
		if (binary)
		{
			packet.WriteInteger(num, 2);
		}
		else
		{
			packet.WriteStringNoNull(num.ToString());
		}
	}

	IMySqlValue IMySqlValue.ReadValue(MySqlPacket packet, long length, bool nullVal)
	{
		if (nullVal)
		{
			return new MySqlUInt16(isNull: true);
		}
		if (length == -1L)
		{
			return new MySqlUInt16((ushort)packet.ReadInteger(2));
		}
		return new MySqlUInt16(ushort.Parse(packet.ReadString(length)));
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		packet.Position += 2;
	}

	internal static void SetDSInfo(MySqlSchemaCollection sc)
	{
		MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
		mySqlSchemaRow["TypeName"] = "SMALLINT";
		mySqlSchemaRow["ProviderDbType"] = MySqlDbType.UInt16;
		mySqlSchemaRow["ColumnSize"] = 0;
		mySqlSchemaRow["CreateFormat"] = "SMALLINT UNSIGNED";
		mySqlSchemaRow["CreateParameters"] = null;
		mySqlSchemaRow["DataType"] = "System.UInt16";
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
