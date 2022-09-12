using System;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal struct MySqlGuid : IMySqlValue
{
	public byte[] Bytes { get; }

	public bool OldGuids { get; set; }

	public bool IsNull { get; private set; }

	MySqlDbType IMySqlValue.MySqlDbType => MySqlDbType.Guid;

	object IMySqlValue.Value => Value;

	public Guid Value { get; private set; }

	Type IMySqlValue.SystemType => typeof(Guid);

	string IMySqlValue.MySqlTypeName
	{
		get
		{
			if (!OldGuids)
			{
				return "CHAR(36)";
			}
			return "BINARY(16)";
		}
	}

	public MySqlGuid(byte[] buff)
	{
		OldGuids = false;
		Value = new Guid(buff);
		IsNull = false;
		Bytes = buff;
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object val, int length)
	{
		Guid guid = Guid.Empty;
		string text = val as string;
		byte[] array = val as byte[];
		if (val is Guid)
		{
			guid = (Guid)val;
		}
		else
		{
			try
			{
				if (text != null)
				{
					guid = new Guid(text);
				}
				else if (array != null)
				{
					guid = new Guid(array);
				}
			}
			catch (Exception ex)
			{
				throw new MySqlException(Resources.DataNotInSupportedFormat, ex);
			}
		}
		if (OldGuids)
		{
			WriteOldGuid(packet, guid, binary);
			return;
		}
		guid.ToString("D");
		if (binary)
		{
			packet.WriteLenString(guid.ToString("D"));
		}
		else
		{
			packet.WriteStringNoNull("'" + MySqlHelper.EscapeString(guid.ToString("D")) + "'");
		}
	}

	private void WriteOldGuid(MySqlPacket packet, Guid guid, bool binary)
	{
		byte[] array = guid.ToByteArray();
		if (binary)
		{
			packet.WriteLength(array.Length);
			packet.Write(array);
			return;
		}
		packet.WriteStringNoNull("_binary ");
		packet.WriteByte(39);
		EscapeByteArray(array, array.Length, packet);
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

	private MySqlGuid ReadOldGuid(MySqlPacket packet, long length)
	{
		if (length == -1L)
		{
			length = packet.ReadFieldLength();
		}
		byte[] array = new byte[length];
		packet.Read(array, 0, (int)length);
		MySqlGuid result = new MySqlGuid(array);
		result.OldGuids = OldGuids;
		return result;
	}

	IMySqlValue IMySqlValue.ReadValue(MySqlPacket packet, long length, bool nullVal)
	{
		MySqlGuid mySqlGuid = default(MySqlGuid);
		mySqlGuid.IsNull = true;
		mySqlGuid.OldGuids = OldGuids;
		if (!nullVal)
		{
			if (OldGuids)
			{
				return ReadOldGuid(packet, length);
			}
			string empty = string.Empty;
			empty = ((length != -1L) ? packet.ReadString(length) : packet.ReadLenString());
			mySqlGuid.Value = new Guid(empty);
			mySqlGuid.IsNull = false;
		}
		return mySqlGuid;
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		int num = (int)packet.ReadFieldLength();
		packet.Position += num;
	}

	public static void SetDSInfo(MySqlSchemaCollection sc)
	{
		MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
		mySqlSchemaRow["TypeName"] = "GUID";
		mySqlSchemaRow["ProviderDbType"] = MySqlDbType.Guid;
		mySqlSchemaRow["ColumnSize"] = 0;
		mySqlSchemaRow["CreateFormat"] = "BINARY(16)";
		mySqlSchemaRow["CreateParameters"] = null;
		mySqlSchemaRow["DataType"] = "System.Guid";
		mySqlSchemaRow["IsAutoincrementable"] = false;
		mySqlSchemaRow["IsBestMatch"] = true;
		mySqlSchemaRow["IsCaseSensitive"] = false;
		mySqlSchemaRow["IsFixedLength"] = true;
		mySqlSchemaRow["IsFixedPrecisionScale"] = true;
		mySqlSchemaRow["IsLong"] = false;
		mySqlSchemaRow["IsNullable"] = true;
		mySqlSchemaRow["IsSearchable"] = false;
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
