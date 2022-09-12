using System;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal struct MySqlDouble : IMySqlValue
{
	public bool IsNull { get; }

	MySqlDbType IMySqlValue.MySqlDbType => MySqlDbType.Double;

	object IMySqlValue.Value => Value;

	public double Value { get; }

	Type IMySqlValue.SystemType => typeof(double);

	string IMySqlValue.MySqlTypeName => "DOUBLE";

	public MySqlDouble(bool isNull)
	{
		IsNull = isNull;
		Value = 0.0;
	}

	public MySqlDouble(double val)
	{
		IsNull = false;
		Value = val;
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object val, int length)
	{
		double value = (val as double?) ?? Convert.ToDouble(val);
		if (binary)
		{
			packet.Write(BitConverter.GetBytes(value));
		}
		else
		{
			packet.WriteStringNoNull(value.ToString("R", CultureInfo.InvariantCulture));
		}
	}

	IMySqlValue IMySqlValue.ReadValue(MySqlPacket packet, long length, bool nullVal)
	{
		if (nullVal)
		{
			return new MySqlDouble(isNull: true);
		}
		if (length == -1L)
		{
			byte[] array = new byte[8];
			packet.Read(array, 0, 8);
			return new MySqlDouble(BitConverter.ToDouble(array, 0));
		}
		string text = packet.ReadString(length);
		double val;
		try
		{
			val = double.Parse(text, CultureInfo.InvariantCulture);
		}
		catch (OverflowException)
		{
			val = ((!text.StartsWith("-", StringComparison.Ordinal)) ? double.MaxValue : double.MinValue);
		}
		return new MySqlDouble(val);
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		packet.Position += 8;
	}

	internal static void SetDSInfo(MySqlSchemaCollection sc)
	{
		MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
		mySqlSchemaRow["TypeName"] = "DOUBLE";
		mySqlSchemaRow["ProviderDbType"] = MySqlDbType.Double;
		mySqlSchemaRow["ColumnSize"] = 0;
		mySqlSchemaRow["CreateFormat"] = "DOUBLE";
		mySqlSchemaRow["CreateParameters"] = null;
		mySqlSchemaRow["DataType"] = "System.Double";
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
