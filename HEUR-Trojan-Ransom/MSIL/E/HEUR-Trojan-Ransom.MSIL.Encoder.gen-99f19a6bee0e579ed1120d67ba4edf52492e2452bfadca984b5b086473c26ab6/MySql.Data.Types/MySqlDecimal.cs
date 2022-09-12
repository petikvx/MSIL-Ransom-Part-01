using System;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

public struct MySqlDecimal : IMySqlValue
{
	private readonly string _value;

	public bool IsNull { get; }

	MySqlDbType IMySqlValue.MySqlDbType => MySqlDbType.Decimal;

	public byte Precision { get; set; }

	public byte Scale { get; set; }

	object IMySqlValue.Value => Value;

	public decimal Value => Convert.ToDecimal(_value, CultureInfo.InvariantCulture);

	Type IMySqlValue.SystemType => typeof(decimal);

	string IMySqlValue.MySqlTypeName => "DECIMAL";

	internal MySqlDecimal(bool isNull)
	{
		IsNull = isNull;
		_value = null;
		Scale = 0;
		Precision = 0;
	}

	internal MySqlDecimal(string val)
	{
		IsNull = false;
		Scale = 0;
		Precision = 0;
		_value = val;
	}

	public double ToDouble()
	{
		return double.Parse(_value);
	}

	public override string ToString()
	{
		return _value;
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object val, int length)
	{
		string text = ((val as decimal?) ?? Convert.ToDecimal(val)).ToString(CultureInfo.InvariantCulture);
		if (binary)
		{
			packet.WriteLenString(text);
		}
		else
		{
			packet.WriteStringNoNull(text);
		}
	}

	IMySqlValue IMySqlValue.ReadValue(MySqlPacket packet, long length, bool nullVal)
	{
		if (nullVal)
		{
			return new MySqlDecimal(isNull: true);
		}
		return new MySqlDecimal((length == -1L) ? packet.ReadLenString() : packet.ReadString(length));
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		int num = (int)packet.ReadFieldLength();
		packet.Position += num;
	}

	internal static void SetDSInfo(MySqlSchemaCollection sc)
	{
		MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
		mySqlSchemaRow["TypeName"] = "DECIMAL";
		mySqlSchemaRow["ProviderDbType"] = MySqlDbType.NewDecimal;
		mySqlSchemaRow["ColumnSize"] = 0;
		mySqlSchemaRow["CreateFormat"] = "DECIMAL({0},{1})";
		mySqlSchemaRow["CreateParameters"] = "precision,scale";
		mySqlSchemaRow["DataType"] = "System.Decimal";
		mySqlSchemaRow["IsAutoincrementable"] = false;
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
