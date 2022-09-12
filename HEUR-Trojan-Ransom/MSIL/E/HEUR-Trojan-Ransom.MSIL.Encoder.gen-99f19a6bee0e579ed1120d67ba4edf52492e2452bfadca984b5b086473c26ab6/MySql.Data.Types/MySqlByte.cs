using System;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal struct MySqlByte : IMySqlValue
{
	public bool IsNull { get; }

	MySqlDbType IMySqlValue.MySqlDbType => MySqlDbType.Byte;

	object IMySqlValue.Value
	{
		get
		{
			if (TreatAsBoolean)
			{
				return Convert.ToBoolean(Value);
			}
			return Value;
		}
	}

	public sbyte Value { get; set; }

	Type IMySqlValue.SystemType
	{
		get
		{
			if (!TreatAsBoolean)
			{
				return typeof(sbyte);
			}
			return typeof(bool);
		}
	}

	string IMySqlValue.MySqlTypeName => "TINYINT";

	internal bool TreatAsBoolean { get; set; }

	public MySqlByte(bool isNull)
	{
		IsNull = isNull;
		Value = 0;
		TreatAsBoolean = false;
	}

	public MySqlByte(sbyte val)
	{
		IsNull = false;
		Value = val;
		TreatAsBoolean = false;
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object val, int length)
	{
		sbyte b = (val as sbyte?) ?? Convert.ToSByte(val);
		if (binary)
		{
			packet.WriteByte((byte)b);
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
			MySqlByte mySqlByte = new MySqlByte(isNull: true);
			mySqlByte.TreatAsBoolean = TreatAsBoolean;
			return mySqlByte;
		}
		MySqlByte mySqlByte2;
		if (length == -1L)
		{
			mySqlByte2 = new MySqlByte((sbyte)packet.ReadByte());
		}
		else
		{
			string s = packet.ReadString(length);
			mySqlByte2 = new MySqlByte(sbyte.Parse(s, NumberStyles.Any, CultureInfo.InvariantCulture));
		}
		mySqlByte2.TreatAsBoolean = TreatAsBoolean;
		return mySqlByte2;
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		packet.ReadByte();
	}

	internal static void SetDSInfo(MySqlSchemaCollection sc)
	{
		MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
		mySqlSchemaRow["TypeName"] = "TINYINT";
		mySqlSchemaRow["ProviderDbType"] = MySqlDbType.Byte;
		mySqlSchemaRow["ColumnSize"] = 0;
		mySqlSchemaRow["CreateFormat"] = "TINYINT";
		mySqlSchemaRow["CreateParameters"] = null;
		mySqlSchemaRow["DataType"] = "System.SByte";
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
