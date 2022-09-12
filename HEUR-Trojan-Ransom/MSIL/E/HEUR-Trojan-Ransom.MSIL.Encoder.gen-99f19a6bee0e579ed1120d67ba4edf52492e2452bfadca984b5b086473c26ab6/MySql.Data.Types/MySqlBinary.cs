using System;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal struct MySqlBinary : IMySqlValue
{
	private readonly MySqlDbType _type;

	private readonly byte[] _mValue;

	public bool IsNull { get; }

	MySqlDbType IMySqlValue.MySqlDbType => _type;

	object IMySqlValue.Value => _mValue;

	public byte[] Value => _mValue;

	Type IMySqlValue.SystemType => typeof(byte[]);

	string IMySqlValue.MySqlTypeName => _type switch
	{
		MySqlDbType.TinyBlob => "TINY_BLOB", 
		MySqlDbType.MediumBlob => "MEDIUM_BLOB", 
		MySqlDbType.LongBlob => "LONG_BLOB", 
		_ => "BLOB", 
	};

	public MySqlBinary(MySqlDbType type, bool isNull)
	{
		_type = type;
		IsNull = isNull;
		_mValue = null;
	}

	public MySqlBinary(MySqlDbType type, byte[] val)
	{
		_type = type;
		IsNull = false;
		_mValue = val;
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object val, int length)
	{
		byte[] array = val as byte[];
		if (array == null)
		{
			if (val is char[] chars)
			{
				array = packet.Encoding.GetBytes(chars);
			}
			else
			{
				string text = val.ToString();
				if (length == 0)
				{
					length = text.Length;
				}
				else
				{
					text = text.Substring(0, length);
				}
				array = packet.Encoding.GetBytes(text);
			}
		}
		if (length == 0)
		{
			length = array.Length;
		}
		if (array == null)
		{
			throw new MySqlException("Only byte arrays and strings can be serialized by MySqlBinary");
		}
		if (binary)
		{
			packet.WriteLength(length);
			packet.Write(array, 0, length);
			return;
		}
		packet.WriteStringNoNull("_binary ");
		packet.WriteByte(39);
		EscapeByteArray(array, length, packet);
		packet.WriteByte(39);
	}

	private static void EscapeByteArray(byte[] bytes, int length, MySqlPacket packet)
	{
		for (int i = 0; i < length; i++)
		{
			byte b = bytes[i];
			switch (b)
			{
			case 0:
				packet.WriteByte(92);
				packet.WriteByte(48);
				break;
			default:
				packet.WriteByte(b);
				break;
			case 34:
			case 39:
			case 92:
				packet.WriteByte(92);
				packet.WriteByte(b);
				break;
			}
		}
	}

	IMySqlValue IMySqlValue.ReadValue(MySqlPacket packet, long length, bool nullVal)
	{
		MySqlBinary mySqlBinary;
		if (nullVal)
		{
			mySqlBinary = new MySqlBinary(_type, isNull: true);
		}
		else
		{
			if (length == -1L)
			{
				length = packet.ReadFieldLength();
			}
			byte[] array = new byte[length];
			packet.Read(array, 0, (int)length);
			mySqlBinary = new MySqlBinary(_type, array);
		}
		return mySqlBinary;
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		int num = (int)packet.ReadFieldLength();
		packet.Position += num;
	}

	public static void SetDSInfo(MySqlSchemaCollection sc)
	{
		string[] array = new string[6] { "BLOB", "TINYBLOB", "MEDIUMBLOB", "LONGBLOB", "BINARY", "VARBINARY" };
		MySqlDbType[] array2 = new MySqlDbType[6]
		{
			MySqlDbType.Blob,
			MySqlDbType.TinyBlob,
			MySqlDbType.MediumBlob,
			MySqlDbType.LongBlob,
			MySqlDbType.Binary,
			MySqlDbType.VarBinary
		};
		long[] array3 = new long[6] { 65535L, 255L, 16777215L, 4294967295L, 255L, 65535L };
		string[] array4 = new string[6] { null, null, null, null, "binary({0})", "varbinary({0})" };
		string[] array5 = new string[6] { null, null, null, null, "length", "length" };
		for (int i = 0; i < array.Length; i++)
		{
			MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
			mySqlSchemaRow["TypeName"] = array[i];
			mySqlSchemaRow["ProviderDbType"] = array2[i];
			mySqlSchemaRow["ColumnSize"] = array3[i];
			mySqlSchemaRow["CreateFormat"] = array4[i];
			mySqlSchemaRow["CreateParameters"] = array5[i];
			mySqlSchemaRow["DataType"] = "System.Byte[]";
			mySqlSchemaRow["IsAutoincrementable"] = false;
			mySqlSchemaRow["IsBestMatch"] = true;
			mySqlSchemaRow["IsCaseSensitive"] = false;
			mySqlSchemaRow["IsFixedLength"] = i >= 4;
			mySqlSchemaRow["IsFixedPrecisionScale"] = false;
			mySqlSchemaRow["IsLong"] = array3[i] > 255L;
			mySqlSchemaRow["IsNullable"] = true;
			mySqlSchemaRow["IsSearchable"] = false;
			mySqlSchemaRow["IsSearchableWithLike"] = false;
			mySqlSchemaRow["IsUnsigned"] = DBNull.Value;
			mySqlSchemaRow["MaximumScale"] = DBNull.Value;
			mySqlSchemaRow["MinimumScale"] = DBNull.Value;
			mySqlSchemaRow["IsConcurrencyType"] = DBNull.Value;
			mySqlSchemaRow["IsLiteralSupported"] = false;
			mySqlSchemaRow["LiteralPrefix"] = "0x";
			mySqlSchemaRow["LiteralSuffix"] = DBNull.Value;
			mySqlSchemaRow["NativeDataType"] = DBNull.Value;
		}
	}
}
