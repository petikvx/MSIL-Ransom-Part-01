using System;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal struct MySqlUInt32 : IMySqlValue
{
	private readonly bool _is24Bit;

	public bool IsNull { get; }

	MySqlDbType IMySqlValue.MySqlDbType => MySqlDbType.UInt32;

	object IMySqlValue.Value => Value;

	public uint Value { get; }

	Type IMySqlValue.SystemType => typeof(uint);

	string IMySqlValue.MySqlTypeName
	{
		get
		{
			if (!_is24Bit)
			{
				return "INT";
			}
			return "MEDIUMINT";
		}
	}

	private MySqlUInt32(MySqlDbType type)
	{
		_is24Bit = type == MySqlDbType.Int24;
		IsNull = true;
		Value = 0u;
	}

	public MySqlUInt32(MySqlDbType type, bool isNull)
		: this(type)
	{
		IsNull = isNull;
	}

	public MySqlUInt32(MySqlDbType type, uint val)
		: this(type)
	{
		IsNull = false;
		Value = val;
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object v, int length)
	{
		uint num = (v as uint?) ?? Convert.ToUInt32(v);
		if (binary)
		{
			packet.WriteInteger(num, _is24Bit ? 3 : 4);
		}
		else
		{
			packet.WriteStringNoNull(num.ToString(CultureInfo.InvariantCulture));
		}
	}

	IMySqlValue IMySqlValue.ReadValue(MySqlPacket packet, long length, bool nullVal)
	{
		if (nullVal)
		{
			return new MySqlUInt32(((IMySqlValue)this).MySqlDbType, isNull: true);
		}
		if (length == -1L)
		{
			return new MySqlUInt32(((IMySqlValue)this).MySqlDbType, (uint)packet.ReadInteger(4));
		}
		return new MySqlUInt32(((IMySqlValue)this).MySqlDbType, uint.Parse(packet.ReadString(length), NumberStyles.Any, CultureInfo.InvariantCulture));
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		packet.Position += 4;
	}

	internal static void SetDSInfo(MySqlSchemaCollection sc)
	{
		string[] array = new string[2] { "MEDIUMINT", "INT" };
		MySqlDbType[] array2 = new MySqlDbType[2]
		{
			MySqlDbType.UInt24,
			MySqlDbType.UInt32
		};
		for (int i = 0; i < array.Length; i++)
		{
			MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
			mySqlSchemaRow["TypeName"] = array[i];
			mySqlSchemaRow["ProviderDbType"] = array2[i];
			mySqlSchemaRow["ColumnSize"] = 0;
			mySqlSchemaRow["CreateFormat"] = array[i] + " UNSIGNED";
			mySqlSchemaRow["CreateParameters"] = null;
			mySqlSchemaRow["DataType"] = "System.UInt32";
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
}
