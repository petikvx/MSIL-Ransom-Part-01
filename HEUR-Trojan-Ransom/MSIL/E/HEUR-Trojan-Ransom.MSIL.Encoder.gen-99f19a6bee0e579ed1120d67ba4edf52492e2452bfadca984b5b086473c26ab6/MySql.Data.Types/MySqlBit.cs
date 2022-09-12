using System;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal struct MySqlBit : IMySqlValue
{
	private ulong _value;

	public bool ReadAsString { get; set; }

	public bool IsNull { get; private set; }

	MySqlDbType IMySqlValue.MySqlDbType => MySqlDbType.Bit;

	object IMySqlValue.Value => _value;

	Type IMySqlValue.SystemType => typeof(ulong);

	string IMySqlValue.MySqlTypeName => "BIT";

	public MySqlBit(bool isnull)
	{
		_value = 0uL;
		IsNull = isnull;
		ReadAsString = false;
	}

	public void WriteValue(MySqlPacket packet, bool binary, object value, int length)
	{
		ulong v = (value as ulong?) ?? Convert.ToUInt64(value);
		if (binary)
		{
			packet.WriteInteger((long)v, 8);
		}
		else
		{
			packet.WriteStringNoNull(v.ToString());
		}
	}

	public IMySqlValue ReadValue(MySqlPacket packet, long length, bool isNull)
	{
		IsNull = isNull;
		if (isNull)
		{
			return this;
		}
		if (length == -1L)
		{
			length = packet.ReadFieldLength();
		}
		if (ReadAsString)
		{
			_value = ulong.Parse(packet.ReadString(length));
		}
		else
		{
			_value = packet.ReadBitValue((int)length);
		}
		return this;
	}

	public void SkipValue(MySqlPacket packet)
	{
		int num = (int)packet.ReadFieldLength();
		packet.Position += num;
	}

	internal static void SetDSInfo(MySqlSchemaCollection sc)
	{
		MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
		mySqlSchemaRow["TypeName"] = "BIT";
		mySqlSchemaRow["ProviderDbType"] = MySqlDbType.Bit;
		mySqlSchemaRow["ColumnSize"] = 64;
		mySqlSchemaRow["CreateFormat"] = "BIT";
		mySqlSchemaRow["CreateParameters"] = DBNull.Value;
		mySqlSchemaRow["DataType"] = typeof(ulong).ToString();
		mySqlSchemaRow["IsAutoincrementable"] = false;
		mySqlSchemaRow["IsBestMatch"] = true;
		mySqlSchemaRow["IsCaseSensitive"] = false;
		mySqlSchemaRow["IsFixedLength"] = false;
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
		mySqlSchemaRow["LiteralPrefix"] = DBNull.Value;
		mySqlSchemaRow["LiteralSuffix"] = DBNull.Value;
		mySqlSchemaRow["NativeDataType"] = DBNull.Value;
	}
}
