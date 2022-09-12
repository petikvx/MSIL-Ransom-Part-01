using System;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal struct MySqlSingle : IMySqlValue
{
	public bool IsNull { get; }

	MySqlDbType IMySqlValue.MySqlDbType => MySqlDbType.Float;

	object IMySqlValue.Value => Value;

	public float Value { get; }

	Type IMySqlValue.SystemType => typeof(float);

	string IMySqlValue.MySqlTypeName => "FLOAT";

	public MySqlSingle(bool isNull)
	{
		IsNull = isNull;
		Value = 0f;
	}

	public MySqlSingle(float val)
	{
		IsNull = false;
		Value = val;
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object val, int length)
	{
		float value = (val as float?) ?? Convert.ToSingle(val);
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
			return new MySqlSingle(isNull: true);
		}
		if (length == -1L)
		{
			byte[] array = new byte[4];
			packet.Read(array, 0, 4);
			return new MySqlSingle(BitConverter.ToSingle(array, 0));
		}
		return new MySqlSingle(float.Parse(packet.ReadString(length), CultureInfo.InvariantCulture));
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		packet.Position += 4;
	}

	internal static void SetDSInfo(MySqlSchemaCollection sc)
	{
		MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
		mySqlSchemaRow["TypeName"] = "FLOAT";
		mySqlSchemaRow["ProviderDbType"] = MySqlDbType.Float;
		mySqlSchemaRow["ColumnSize"] = 0;
		mySqlSchemaRow["CreateFormat"] = "FLOAT";
		mySqlSchemaRow["CreateParameters"] = null;
		mySqlSchemaRow["DataType"] = "System.Single";
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
