using System;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal struct MySqlInt32 : IMySqlValue
{
	private readonly int _value;

	private readonly bool _is24Bit;

	public bool IsNull { get; }

	MySqlDbType IMySqlValue.MySqlDbType => MySqlDbType.Int32;

	object IMySqlValue.Value => _value;

	public int Value => _value;

	Type IMySqlValue.SystemType => typeof(int);

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

	private MySqlInt32(MySqlDbType type)
	{
		_is24Bit = type == MySqlDbType.Int24;
		IsNull = true;
		_value = 0;
	}

	public MySqlInt32(MySqlDbType type, bool isNull)
		: this(type)
	{
		IsNull = isNull;
	}

	public MySqlInt32(MySqlDbType type, int val)
		: this(type)
	{
		IsNull = false;
		_value = val;
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object val, int length)
	{
		int num = (val as int?) ?? Convert.ToInt32(val);
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
			return new MySqlInt32(((IMySqlValue)this).MySqlDbType, isNull: true);
		}
		if (length == -1L)
		{
			return new MySqlInt32(((IMySqlValue)this).MySqlDbType, packet.ReadInteger(4));
		}
		return new MySqlInt32(((IMySqlValue)this).MySqlDbType, int.Parse(packet.ReadString(length), CultureInfo.InvariantCulture));
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		packet.Position += 4;
	}

	internal static void SetDSInfo(MySqlSchemaCollection sc)
	{
		string[] array = new string[3] { "INT", "YEAR", "MEDIUMINT" };
		MySqlDbType[] array2 = new MySqlDbType[3]
		{
			MySqlDbType.Int32,
			MySqlDbType.Year,
			MySqlDbType.Int24
		};
		for (int i = 0; i < array.Length; i++)
		{
			MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
			mySqlSchemaRow["TypeName"] = array[i];
			mySqlSchemaRow["ProviderDbType"] = array2[i];
			mySqlSchemaRow["ColumnSize"] = 0;
			mySqlSchemaRow["CreateFormat"] = array[i];
			mySqlSchemaRow["CreateParameters"] = null;
			mySqlSchemaRow["DataType"] = "System.Int32";
			mySqlSchemaRow["IsAutoincrementable"] = array2[i] != MySqlDbType.Year;
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
}
