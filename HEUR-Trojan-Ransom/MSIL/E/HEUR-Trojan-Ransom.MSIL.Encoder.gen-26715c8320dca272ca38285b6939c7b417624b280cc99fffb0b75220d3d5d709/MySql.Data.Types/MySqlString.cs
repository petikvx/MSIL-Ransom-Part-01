using System;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal struct MySqlString : IMySqlValue
{
	private readonly MySqlDbType _type;

	public bool IsNull { get; }

	MySqlDbType IMySqlValue.MySqlDbType => _type;

	object IMySqlValue.Value => Value;

	public string Value { get; }

	Type IMySqlValue.SystemType => typeof(string);

	string IMySqlValue.MySqlTypeName
	{
		get
		{
			if (_type != MySqlDbType.Set)
			{
				if (_type != MySqlDbType.Enum)
				{
					return "VARCHAR";
				}
				return "ENUM";
			}
			return "SET";
		}
	}

	public MySqlString(MySqlDbType type, bool isNull)
	{
		_type = type;
		IsNull = isNull;
		Value = string.Empty;
	}

	public MySqlString(MySqlDbType type, string val)
	{
		_type = type;
		IsNull = false;
		Value = val;
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object val, int length)
	{
		string text = val.ToString();
		if (length > 0)
		{
			length = Math.Min(length, text.Length);
			text = text.Substring(0, length);
		}
		if (binary)
		{
			packet.WriteLenString(text);
		}
		else
		{
			packet.WriteStringNoNull("'" + MySqlHelper.EscapeString(text) + "'");
		}
	}

	IMySqlValue IMySqlValue.ReadValue(MySqlPacket packet, long length, bool nullVal)
	{
		if (nullVal)
		{
			return new MySqlString(_type, isNull: true);
		}
		string empty = string.Empty;
		return new MySqlString(val: (length != -1L) ? packet.ReadString(length) : packet.ReadLenString(), type: _type);
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		int num = (int)packet.ReadFieldLength();
		packet.Position += num;
	}

	internal static void SetDSInfo(MySqlSchemaCollection sc)
	{
		string[] array = new string[10] { "CHAR", "NCHAR", "VARCHAR", "NVARCHAR", "SET", "ENUM", "TINYTEXT", "TEXT", "MEDIUMTEXT", "LONGTEXT" };
		MySqlDbType[] array2 = new MySqlDbType[10]
		{
			MySqlDbType.String,
			MySqlDbType.String,
			MySqlDbType.VarChar,
			MySqlDbType.VarChar,
			MySqlDbType.Set,
			MySqlDbType.Enum,
			MySqlDbType.TinyText,
			MySqlDbType.Text,
			MySqlDbType.MediumText,
			MySqlDbType.LongText
		};
		for (int i = 0; i < array.Length; i++)
		{
			MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
			mySqlSchemaRow["TypeName"] = array[i];
			mySqlSchemaRow["ProviderDbType"] = array2[i];
			mySqlSchemaRow["ColumnSize"] = 0;
			mySqlSchemaRow["CreateFormat"] = ((i < 4) ? (array[i] + "({0})") : array[i]);
			mySqlSchemaRow["CreateParameters"] = ((i < 4) ? "size" : null);
			mySqlSchemaRow["DataType"] = "System.String";
			mySqlSchemaRow["IsAutoincrementable"] = false;
			mySqlSchemaRow["IsBestMatch"] = true;
			mySqlSchemaRow["IsCaseSensitive"] = false;
			mySqlSchemaRow["IsFixedLength"] = false;
			mySqlSchemaRow["IsFixedPrecisionScale"] = true;
			mySqlSchemaRow["IsLong"] = false;
			mySqlSchemaRow["IsNullable"] = true;
			mySqlSchemaRow["IsSearchable"] = true;
			mySqlSchemaRow["IsSearchableWithLike"] = true;
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
